/*
               File: XT_DefindcodeType
        Description: 数据字典类型
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:7:27.39
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
   public class xt_defindcodetype : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
               AV7XT_DefindcodeTypeID = (long)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7XT_DefindcodeTypeID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7XT_DefindcodeTypeID), 18, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vXT_DEFINDCODETYPEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7XT_DefindcodeTypeID), "ZZZZZZZZZZZZZZZZZZ"), context));
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
            Form.Meta.addItem("description", "数据字典类型", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtXT_DefindcodeTypeName_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("WorkWithPlusTheme");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public xt_defindcodetype( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public xt_defindcodetype( IGxContext context )
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
                           long aP1_XT_DefindcodeTypeID )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV7XT_DefindcodeTypeID = aP1_XT_DefindcodeTypeID;
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtXT_DefindcodeTypeName_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtXT_DefindcodeTypeName_Internalname, "数据字典类型名称", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtXT_DefindcodeTypeName_Internalname, A166XT_DefindcodeTypeName, StringUtil.RTrim( context.localUtil.Format( A166XT_DefindcodeTypeName, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,25);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtXT_DefindcodeTypeName_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtXT_DefindcodeTypeName_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_XT_DefindcodeType.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 30,'',false,'',0)\"";
            ClassString = "ButtonMaterial";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_enter_Internalname, "", "保存", bttBtntrn_enter_Jsonclick, 5, "确认", "", StyleString, ClassString, bttBtntrn_enter_Visible, bttBtntrn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_XT_DefindcodeType.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 32,'',false,'',0)\"";
            ClassString = "ButtonMaterialDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_cancel_Internalname, "", "取消", bttBtntrn_cancel_Jsonclick, 1, "取消", "", StyleString, ClassString, bttBtntrn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_XT_DefindcodeType.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'',0)\"";
            ClassString = "ButtonMaterialDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_delete_Internalname, "", "删除", bttBtntrn_delete_Jsonclick, 5, "删除", "", StyleString, ClassString, bttBtntrn_delete_Visible, bttBtntrn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_XT_DefindcodeType.htm");
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
            GxWebStd.gx_single_line_edit( context, edtXT_DefindcodeTypeID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A165XT_DefindcodeTypeID), 18, 0, ".", "")), ((edtXT_DefindcodeTypeID_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A165XT_DefindcodeTypeID), "ZZZZZZZZZZZZZZZZZZ")) : context.localUtil.Format( (decimal)(A165XT_DefindcodeTypeID), "ZZZZZZZZZZZZZZZZZZ")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtXT_DefindcodeTypeID_Jsonclick, 0, "Attribute", "", "", "", "", edtXT_DefindcodeTypeID_Visible, edtXT_DefindcodeTypeID_Enabled, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "HLP_XT_DefindcodeType.htm");
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
         E110M2 ();
         context.wbGlbDoneStart = 1;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
               A166XT_DefindcodeTypeName = cgiGet( edtXT_DefindcodeTypeName_Internalname);
               n166XT_DefindcodeTypeName = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A166XT_DefindcodeTypeName", A166XT_DefindcodeTypeName);
               n166XT_DefindcodeTypeName = (String.IsNullOrEmpty(StringUtil.RTrim( A166XT_DefindcodeTypeName)) ? true : false);
               A165XT_DefindcodeTypeID = (long)(context.localUtil.CToN( cgiGet( edtXT_DefindcodeTypeID_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A165XT_DefindcodeTypeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A165XT_DefindcodeTypeID), 18, 0)));
               /* Read saved values. */
               Z165XT_DefindcodeTypeID = (long)(context.localUtil.CToN( cgiGet( "Z165XT_DefindcodeTypeID"), ".", ","));
               Z166XT_DefindcodeTypeName = cgiGet( "Z166XT_DefindcodeTypeName");
               n166XT_DefindcodeTypeName = (String.IsNullOrEmpty(StringUtil.RTrim( A166XT_DefindcodeTypeName)) ? true : false);
               Z511XT_DefindcodeTypeIsShow = (short)(context.localUtil.CToN( cgiGet( "Z511XT_DefindcodeTypeIsShow"), ".", ","));
               n511XT_DefindcodeTypeIsShow = ((0==A511XT_DefindcodeTypeIsShow) ? true : false);
               A511XT_DefindcodeTypeIsShow = (short)(context.localUtil.CToN( cgiGet( "Z511XT_DefindcodeTypeIsShow"), ".", ","));
               n511XT_DefindcodeTypeIsShow = false;
               n511XT_DefindcodeTypeIsShow = ((0==A511XT_DefindcodeTypeIsShow) ? true : false);
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ","));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ","));
               Gx_mode = cgiGet( "Mode");
               AV7XT_DefindcodeTypeID = (long)(context.localUtil.CToN( cgiGet( "vXT_DEFINDCODETYPEID"), ".", ","));
               A511XT_DefindcodeTypeIsShow = (short)(context.localUtil.CToN( cgiGet( "XT_DEFINDCODETYPEISSHOW"), ".", ","));
               n511XT_DefindcodeTypeIsShow = ((0==A511XT_DefindcodeTypeIsShow) ? true : false);
               AV15Pgmname = cgiGet( "vPGMNAME");
               AV14Pgmdesc = cgiGet( "vPGMDESC");
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
               forbiddenHiddens = "hsh" + "XT_DefindcodeType";
               A165XT_DefindcodeTypeID = (long)(context.localUtil.CToN( cgiGet( edtXT_DefindcodeTypeID_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A165XT_DefindcodeTypeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A165XT_DefindcodeTypeID), 18, 0)));
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A165XT_DefindcodeTypeID), "ZZZZZZZZZZZZZZZZZZ");
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A511XT_DefindcodeTypeIsShow), "ZZZ9");
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( A165XT_DefindcodeTypeID != Z165XT_DefindcodeTypeID ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
               {
                  GXUtil.WriteLog("xt_defindcodetype:[SecurityCheckFailed value for]"+"XT_DefindcodeTypeID:"+context.localUtil.Format( (decimal)(A165XT_DefindcodeTypeID), "ZZZZZZZZZZZZZZZZZZ"));
                  GXUtil.WriteLog("xt_defindcodetype:[SecurityCheckFailed value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
                  GXUtil.WriteLog("xt_defindcodetype:[SecurityCheckFailed value for]"+"XT_DefindcodeTypeIsShow:"+context.localUtil.Format( (decimal)(A511XT_DefindcodeTypeIsShow), "ZZZ9"));
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
                  A165XT_DefindcodeTypeID = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A165XT_DefindcodeTypeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A165XT_DefindcodeTypeID), 18, 0)));
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
                     sMode23 = Gx_mode;
                     Gx_mode = "UPD";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     Gx_mode = sMode23;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound23 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_0M0( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtntrn_enter_Internalname;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert", ""), 1, "XT_DEFINDCODETYPEID");
                        AnyError = 1;
                        GX_FocusControl = edtXT_DefindcodeTypeID_Internalname;
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
                           E110M2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: After Trn */
                           E120M2 ();
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
            E120M2 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll0M23( ) ;
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
            DisableAttributes0M23( ) ;
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

      protected void CONFIRM_0M0( )
      {
         BeforeValidate0M23( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0M23( ) ;
            }
            else
            {
               CheckExtendedTable0M23( ) ;
               CloseExtendedTableCursors0M23( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         }
      }

      protected void ResetCaption0M0( )
      {
      }

      protected void E110M2( )
      {
         /* Start Routine */
         AV14Pgmdesc = "Data Mgmt Portal -RAAP";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14Pgmdesc", AV14Pgmdesc);
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV8WWPContext) ;
         AV9IsAuthorized = true;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9IsAuthorized", AV9IsAuthorized);
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            GXt_boolean1 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Check_DefindcodeType", out  GXt_boolean1) ;
            AV9IsAuthorized = GXt_boolean1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9IsAuthorized", AV9IsAuthorized);
         }
         if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
         {
            GXt_boolean1 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Check_DefindcodeType", out  GXt_boolean1) ;
            AV9IsAuthorized = GXt_boolean1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9IsAuthorized", AV9IsAuthorized);
         }
         if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
         {
            GXt_boolean1 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Check_DefindcodeType", out  GXt_boolean1) ;
            AV9IsAuthorized = GXt_boolean1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9IsAuthorized", AV9IsAuthorized);
         }
         if ( ! AV9IsAuthorized )
         {
            CallWebObject(formatLink("wwpbaseobjects.notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV15Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         AV11TrnContext.FromXml(AV12WebSession.Get("TrnContext"), null, "WWPTransactionContext", "DataAnalysisPlatform");
         edtXT_DefindcodeTypeID_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtXT_DefindcodeTypeID_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtXT_DefindcodeTypeID_Visible), 5, 0)), true);
      }

      protected void E120M2( )
      {
         /* After Trn Routine */
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV11TrnContext.gxTpr_Callerondelete )
         {
            CallWebObject(formatLink("xt_defindcodetypeww.aspx") );
            context.wjLocDisableFrm = 1;
         }
         context.setWebReturnParms(new Object[] {});
         context.setWebReturnParmsMetadata(new Object[] {});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      protected void ZM0M23( short GX_JID )
      {
         if ( ( GX_JID == 4 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z166XT_DefindcodeTypeName = T000M3_A166XT_DefindcodeTypeName[0];
               Z511XT_DefindcodeTypeIsShow = T000M3_A511XT_DefindcodeTypeIsShow[0];
            }
            else
            {
               Z166XT_DefindcodeTypeName = A166XT_DefindcodeTypeName;
               Z511XT_DefindcodeTypeIsShow = A511XT_DefindcodeTypeIsShow;
            }
         }
         if ( GX_JID == -4 )
         {
            Z165XT_DefindcodeTypeID = A165XT_DefindcodeTypeID;
            Z166XT_DefindcodeTypeName = A166XT_DefindcodeTypeName;
            Z511XT_DefindcodeTypeIsShow = A511XT_DefindcodeTypeIsShow;
         }
      }

      protected void standaloneNotModal( )
      {
         edtXT_DefindcodeTypeID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtXT_DefindcodeTypeID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtXT_DefindcodeTypeID_Enabled), 5, 0)), true);
         edtXT_DefindcodeTypeID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtXT_DefindcodeTypeID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtXT_DefindcodeTypeID_Enabled), 5, 0)), true);
         bttBtntrn_delete_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_delete_Enabled), 5, 0)), true);
         if ( ! (0==AV7XT_DefindcodeTypeID) )
         {
            A165XT_DefindcodeTypeID = AV7XT_DefindcodeTypeID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A165XT_DefindcodeTypeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A165XT_DefindcodeTypeID), 18, 0)));
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

      protected void Load0M23( )
      {
         /* Using cursor T000M4 */
         pr_default.execute(2, new Object[] {A165XT_DefindcodeTypeID});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound23 = 1;
            A166XT_DefindcodeTypeName = T000M4_A166XT_DefindcodeTypeName[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A166XT_DefindcodeTypeName", A166XT_DefindcodeTypeName);
            n166XT_DefindcodeTypeName = T000M4_n166XT_DefindcodeTypeName[0];
            A511XT_DefindcodeTypeIsShow = T000M4_A511XT_DefindcodeTypeIsShow[0];
            n511XT_DefindcodeTypeIsShow = T000M4_n511XT_DefindcodeTypeIsShow[0];
            ZM0M23( -4) ;
         }
         pr_default.close(2);
         OnLoadActions0M23( ) ;
      }

      protected void OnLoadActions0M23( )
      {
         AV15Pgmname = "XT_DefindcodeType";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15Pgmname", AV15Pgmname);
         AV14Pgmdesc = "数据字典类型";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14Pgmdesc", AV14Pgmdesc);
      }

      protected void CheckExtendedTable0M23( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
         AV15Pgmname = "XT_DefindcodeType";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15Pgmname", AV15Pgmname);
         AV14Pgmdesc = "数据字典类型";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14Pgmdesc", AV14Pgmdesc);
         if ( String.IsNullOrEmpty(StringUtil.RTrim( A166XT_DefindcodeTypeName)) )
         {
            GX_msglist.addItem("数据字典类型名称是必须填写的。", 1, "XT_DEFINDCODETYPENAME");
            AnyError = 1;
            GX_FocusControl = edtXT_DefindcodeTypeName_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
      }

      protected void CloseExtendedTableCursors0M23( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey0M23( )
      {
         /* Using cursor T000M5 */
         pr_default.execute(3, new Object[] {A165XT_DefindcodeTypeID});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound23 = 1;
         }
         else
         {
            RcdFound23 = 0;
         }
         pr_default.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T000M3 */
         pr_default.execute(1, new Object[] {A165XT_DefindcodeTypeID});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0M23( 4) ;
            RcdFound23 = 1;
            A165XT_DefindcodeTypeID = T000M3_A165XT_DefindcodeTypeID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A165XT_DefindcodeTypeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A165XT_DefindcodeTypeID), 18, 0)));
            A166XT_DefindcodeTypeName = T000M3_A166XT_DefindcodeTypeName[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A166XT_DefindcodeTypeName", A166XT_DefindcodeTypeName);
            n166XT_DefindcodeTypeName = T000M3_n166XT_DefindcodeTypeName[0];
            A511XT_DefindcodeTypeIsShow = T000M3_A511XT_DefindcodeTypeIsShow[0];
            n511XT_DefindcodeTypeIsShow = T000M3_n511XT_DefindcodeTypeIsShow[0];
            Z165XT_DefindcodeTypeID = A165XT_DefindcodeTypeID;
            sMode23 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load0M23( ) ;
            if ( AnyError == 1 )
            {
               RcdFound23 = 0;
               InitializeNonKey0M23( ) ;
            }
            Gx_mode = sMode23;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound23 = 0;
            InitializeNonKey0M23( ) ;
            sMode23 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal( ) ;
            Gx_mode = sMode23;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0M23( ) ;
         if ( RcdFound23 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound23 = 0;
         /* Using cursor T000M6 */
         pr_default.execute(4, new Object[] {A165XT_DefindcodeTypeID});
         if ( (pr_default.getStatus(4) != 101) )
         {
            while ( (pr_default.getStatus(4) != 101) && ( ( T000M6_A165XT_DefindcodeTypeID[0] < A165XT_DefindcodeTypeID ) ) )
            {
               pr_default.readNext(4);
            }
            if ( (pr_default.getStatus(4) != 101) && ( ( T000M6_A165XT_DefindcodeTypeID[0] > A165XT_DefindcodeTypeID ) ) )
            {
               A165XT_DefindcodeTypeID = T000M6_A165XT_DefindcodeTypeID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A165XT_DefindcodeTypeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A165XT_DefindcodeTypeID), 18, 0)));
               RcdFound23 = 1;
            }
         }
         pr_default.close(4);
      }

      protected void move_previous( )
      {
         RcdFound23 = 0;
         /* Using cursor T000M7 */
         pr_default.execute(5, new Object[] {A165XT_DefindcodeTypeID});
         if ( (pr_default.getStatus(5) != 101) )
         {
            while ( (pr_default.getStatus(5) != 101) && ( ( T000M7_A165XT_DefindcodeTypeID[0] > A165XT_DefindcodeTypeID ) ) )
            {
               pr_default.readNext(5);
            }
            if ( (pr_default.getStatus(5) != 101) && ( ( T000M7_A165XT_DefindcodeTypeID[0] < A165XT_DefindcodeTypeID ) ) )
            {
               A165XT_DefindcodeTypeID = T000M7_A165XT_DefindcodeTypeID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A165XT_DefindcodeTypeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A165XT_DefindcodeTypeID), 18, 0)));
               RcdFound23 = 1;
            }
         }
         pr_default.close(5);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey0M23( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtXT_DefindcodeTypeName_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert0M23( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound23 == 1 )
            {
               if ( A165XT_DefindcodeTypeID != Z165XT_DefindcodeTypeID )
               {
                  A165XT_DefindcodeTypeID = Z165XT_DefindcodeTypeID;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A165XT_DefindcodeTypeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A165XT_DefindcodeTypeID), 18, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "XT_DEFINDCODETYPEID");
                  AnyError = 1;
                  GX_FocusControl = edtXT_DefindcodeTypeID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtXT_DefindcodeTypeName_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Update record */
                  Update0M23( ) ;
                  GX_FocusControl = edtXT_DefindcodeTypeName_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A165XT_DefindcodeTypeID != Z165XT_DefindcodeTypeID )
               {
                  /* Insert record */
                  GX_FocusControl = edtXT_DefindcodeTypeName_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert0M23( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "XT_DEFINDCODETYPEID");
                     AnyError = 1;
                     GX_FocusControl = edtXT_DefindcodeTypeID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     /* Insert record */
                     GX_FocusControl = edtXT_DefindcodeTypeName_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert0M23( ) ;
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
         if ( A165XT_DefindcodeTypeID != Z165XT_DefindcodeTypeID )
         {
            A165XT_DefindcodeTypeID = Z165XT_DefindcodeTypeID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A165XT_DefindcodeTypeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A165XT_DefindcodeTypeID), 18, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "XT_DEFINDCODETYPEID");
            AnyError = 1;
            GX_FocusControl = edtXT_DefindcodeTypeID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtXT_DefindcodeTypeName_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency0M23( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000M2 */
            pr_default.execute(0, new Object[] {A165XT_DefindcodeTypeID});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"XT_DefindcodeType"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z166XT_DefindcodeTypeName, T000M2_A166XT_DefindcodeTypeName[0]) != 0 ) || ( Z511XT_DefindcodeTypeIsShow != T000M2_A511XT_DefindcodeTypeIsShow[0] ) )
            {
               if ( StringUtil.StrCmp(Z166XT_DefindcodeTypeName, T000M2_A166XT_DefindcodeTypeName[0]) != 0 )
               {
                  GXUtil.WriteLog("xt_defindcodetype:[seudo value changed for attri]"+"XT_DefindcodeTypeName");
                  GXUtil.WriteLogRaw("Old: ",Z166XT_DefindcodeTypeName);
                  GXUtil.WriteLogRaw("Current: ",T000M2_A166XT_DefindcodeTypeName[0]);
               }
               if ( Z511XT_DefindcodeTypeIsShow != T000M2_A511XT_DefindcodeTypeIsShow[0] )
               {
                  GXUtil.WriteLog("xt_defindcodetype:[seudo value changed for attri]"+"XT_DefindcodeTypeIsShow");
                  GXUtil.WriteLogRaw("Old: ",Z511XT_DefindcodeTypeIsShow);
                  GXUtil.WriteLogRaw("Current: ",T000M2_A511XT_DefindcodeTypeIsShow[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"XT_DefindcodeType"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0M23( )
      {
         BeforeValidate0M23( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0M23( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0M23( 0) ;
            CheckOptimisticConcurrency0M23( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0M23( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0M23( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000M8 */
                     pr_default.execute(6, new Object[] {n166XT_DefindcodeTypeName, A166XT_DefindcodeTypeName, n511XT_DefindcodeTypeIsShow, A511XT_DefindcodeTypeIsShow});
                     A165XT_DefindcodeTypeID = T000M8_A165XT_DefindcodeTypeID[0];
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A165XT_DefindcodeTypeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A165XT_DefindcodeTypeID), 18, 0)));
                     pr_default.close(6);
                     dsDefault.SmartCacheProvider.SetUpdated("XT_DefindcodeType") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                           ResetCaption0M0( ) ;
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
               Load0M23( ) ;
            }
            EndLevel0M23( ) ;
         }
         CloseExtendedTableCursors0M23( ) ;
      }

      protected void Update0M23( )
      {
         BeforeValidate0M23( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0M23( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0M23( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0M23( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0M23( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000M9 */
                     pr_default.execute(7, new Object[] {n166XT_DefindcodeTypeName, A166XT_DefindcodeTypeName, n511XT_DefindcodeTypeIsShow, A511XT_DefindcodeTypeIsShow, A165XT_DefindcodeTypeID});
                     pr_default.close(7);
                     dsDefault.SmartCacheProvider.SetUpdated("XT_DefindcodeType") ;
                     if ( (pr_default.getStatus(7) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"XT_DefindcodeType"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0M23( ) ;
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
            EndLevel0M23( ) ;
         }
         CloseExtendedTableCursors0M23( ) ;
      }

      protected void DeferredUpdate0M23( )
      {
      }

      protected void delete( )
      {
         BeforeValidate0M23( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0M23( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0M23( ) ;
            AfterConfirm0M23( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0M23( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000M10 */
                  pr_default.execute(8, new Object[] {A165XT_DefindcodeTypeID});
                  pr_default.close(8);
                  dsDefault.SmartCacheProvider.SetUpdated("XT_DefindcodeType") ;
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
         sMode23 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel0M23( ) ;
         Gx_mode = sMode23;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls0M23( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV15Pgmname = "XT_DefindcodeType";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15Pgmname", AV15Pgmname);
            AV14Pgmdesc = "数据字典类型";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14Pgmdesc", AV14Pgmdesc);
         }
         if ( AnyError == 0 )
         {
            /* Using cursor T000M11 */
            pr_default.execute(9, new Object[] {A165XT_DefindcodeTypeID});
            if ( (pr_default.getStatus(9) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"数据字典数据"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(9);
         }
      }

      protected void EndLevel0M23( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0M23( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(1);
            context.CommitDataStores("xt_defindcodetype",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues0M0( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(1);
            context.RollbackDataStores("xt_defindcodetype",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart0M23( )
      {
         /* Scan By routine */
         /* Using cursor T000M12 */
         pr_default.execute(10);
         RcdFound23 = 0;
         if ( (pr_default.getStatus(10) != 101) )
         {
            RcdFound23 = 1;
            A165XT_DefindcodeTypeID = T000M12_A165XT_DefindcodeTypeID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A165XT_DefindcodeTypeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A165XT_DefindcodeTypeID), 18, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0M23( )
      {
         /* Scan next routine */
         pr_default.readNext(10);
         RcdFound23 = 0;
         if ( (pr_default.getStatus(10) != 101) )
         {
            RcdFound23 = 1;
            A165XT_DefindcodeTypeID = T000M12_A165XT_DefindcodeTypeID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A165XT_DefindcodeTypeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A165XT_DefindcodeTypeID), 18, 0)));
         }
      }

      protected void ScanEnd0M23( )
      {
         pr_default.close(10);
      }

      protected void AfterConfirm0M23( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0M23( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0M23( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0M23( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0M23( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0M23( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0M23( )
      {
         edtXT_DefindcodeTypeName_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtXT_DefindcodeTypeName_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtXT_DefindcodeTypeName_Enabled), 5, 0)), true);
         edtXT_DefindcodeTypeID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtXT_DefindcodeTypeID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtXT_DefindcodeTypeID_Enabled), 5, 0)), true);
      }

      protected void send_integrity_lvl_hashes0M23( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues0M0( )
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
         context.AddJavascriptSource("gxcfg.js", "?20202281572874", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("xt_defindcodetype.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7XT_DefindcodeTypeID)+"\">") ;
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
         forbiddenHiddens = "hsh" + "XT_DefindcodeType";
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A165XT_DefindcodeTypeID), "ZZZZZZZZZZZZZZZZZZ");
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A511XT_DefindcodeTypeIsShow), "ZZZ9");
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("xt_defindcodetype:[SendSecurityCheck value for]"+"XT_DefindcodeTypeID:"+context.localUtil.Format( (decimal)(A165XT_DefindcodeTypeID), "ZZZZZZZZZZZZZZZZZZ"));
         GXUtil.WriteLog("xt_defindcodetype:[SendSecurityCheck value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
         GXUtil.WriteLog("xt_defindcodetype:[SendSecurityCheck value for]"+"XT_DefindcodeTypeIsShow:"+context.localUtil.Format( (decimal)(A511XT_DefindcodeTypeIsShow), "ZZZ9"));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z165XT_DefindcodeTypeID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z165XT_DefindcodeTypeID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z166XT_DefindcodeTypeName", Z166XT_DefindcodeTypeName);
         GxWebStd.gx_hidden_field( context, "Z511XT_DefindcodeTypeIsShow", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z511XT_DefindcodeTypeIsShow), 4, 0, ".", "")));
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
         GxWebStd.gx_hidden_field( context, "vXT_DEFINDCODETYPEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7XT_DefindcodeTypeID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vXT_DEFINDCODETYPEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7XT_DefindcodeTypeID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, "XT_DEFINDCODETYPEISSHOW", StringUtil.LTrim( StringUtil.NToC( (decimal)(A511XT_DefindcodeTypeIsShow), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV15Pgmname));
         GxWebStd.gx_hidden_field( context, "vPGMDESC", StringUtil.RTrim( AV14Pgmdesc));
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
         return formatLink("xt_defindcodetype.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7XT_DefindcodeTypeID) ;
      }

      public override String GetPgmname( )
      {
         return "XT_DefindcodeType" ;
      }

      public override String GetPgmdesc( )
      {
         return "数据字典类型" ;
      }

      protected void InitializeNonKey0M23( )
      {
         A166XT_DefindcodeTypeName = "";
         n166XT_DefindcodeTypeName = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A166XT_DefindcodeTypeName", A166XT_DefindcodeTypeName);
         n166XT_DefindcodeTypeName = (String.IsNullOrEmpty(StringUtil.RTrim( A166XT_DefindcodeTypeName)) ? true : false);
         A511XT_DefindcodeTypeIsShow = 0;
         n511XT_DefindcodeTypeIsShow = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A511XT_DefindcodeTypeIsShow", StringUtil.LTrim( StringUtil.Str( (decimal)(A511XT_DefindcodeTypeIsShow), 4, 0)));
         Z166XT_DefindcodeTypeName = "";
         Z511XT_DefindcodeTypeIsShow = 0;
      }

      protected void InitAll0M23( )
      {
         A165XT_DefindcodeTypeID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A165XT_DefindcodeTypeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A165XT_DefindcodeTypeID), 18, 0)));
         InitializeNonKey0M23( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20202281572899", true);
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
         context.AddJavascriptSource("xt_defindcodetype.js", "?2020228157290", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         edtXT_DefindcodeTypeName_Internalname = "XT_DEFINDCODETYPENAME";
         divTableattributes_Internalname = "TABLEATTRIBUTES";
         divLayout_tableattributes_Internalname = "LAYOUT_TABLEATTRIBUTES";
         Dvpanel_tableattributes_Internalname = "DVPANEL_TABLEATTRIBUTES";
         divHtml_dvpanel_tableattributes_Internalname = "HTML_DVPANEL_TABLEATTRIBUTES";
         divTablecontent_Internalname = "TABLECONTENT";
         bttBtntrn_enter_Internalname = "BTNTRN_ENTER";
         bttBtntrn_cancel_Internalname = "BTNTRN_CANCEL";
         bttBtntrn_delete_Internalname = "BTNTRN_DELETE";
         divTablemain_Internalname = "TABLEMAIN";
         edtXT_DefindcodeTypeID_Internalname = "XT_DEFINDCODETYPEID";
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
         Form.Caption = "数据字典类型";
         edtXT_DefindcodeTypeID_Jsonclick = "";
         edtXT_DefindcodeTypeID_Enabled = 0;
         edtXT_DefindcodeTypeID_Visible = 1;
         bttBtntrn_delete_Enabled = 0;
         bttBtntrn_delete_Visible = 1;
         bttBtntrn_cancel_Visible = 1;
         bttBtntrn_enter_Enabled = 1;
         bttBtntrn_enter_Visible = 1;
         edtXT_DefindcodeTypeName_Jsonclick = "";
         edtXT_DefindcodeTypeName_Enabled = 1;
         Dvpanel_tableattributes_Autoscroll = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Iconposition = "left";
         Dvpanel_tableattributes_Showcollapseicon = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsed = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsible = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Title = "数据字典类型";
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
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7XT_DefindcodeTypeID',fld:'vXT_DEFINDCODETYPEID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7XT_DefindcodeTypeID',fld:'vXT_DEFINDCODETYPEID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'A165XT_DefindcodeTypeID',fld:'XT_DEFINDCODETYPEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'A511XT_DefindcodeTypeIsShow',fld:'XT_DEFINDCODETYPEISSHOW',pic:'ZZZ9'}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("AFTER TRN","{handler:'E120M2',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV11TrnContext',fld:'vTRNCONTEXT',pic:''}]");
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
         Z166XT_DefindcodeTypeName = "";
         scmdbuf = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         GXKey = "";
         PreviousTooltip = "";
         PreviousCaption = "";
         Form = new GXWebForm();
         GX_FocusControl = "";
         ClassString = "";
         StyleString = "";
         ucDvpanel_tableattributes = new GXUserControl();
         TempTags = "";
         A166XT_DefindcodeTypeName = "";
         bttBtntrn_enter_Jsonclick = "";
         bttBtntrn_cancel_Jsonclick = "";
         bttBtntrn_delete_Jsonclick = "";
         AV15Pgmname = "";
         AV14Pgmdesc = "";
         Dvpanel_tableattributes_Objectcall = "";
         Dvpanel_tableattributes_Class = "";
         Dvpanel_tableattributes_Height = "";
         forbiddenHiddens = "";
         hsh = "";
         sMode23 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV8WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV11TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV12WebSession = context.GetSession();
         T000M4_A165XT_DefindcodeTypeID = new long[1] ;
         T000M4_A166XT_DefindcodeTypeName = new String[] {""} ;
         T000M4_n166XT_DefindcodeTypeName = new bool[] {false} ;
         T000M4_A511XT_DefindcodeTypeIsShow = new short[1] ;
         T000M4_n511XT_DefindcodeTypeIsShow = new bool[] {false} ;
         T000M5_A165XT_DefindcodeTypeID = new long[1] ;
         T000M3_A165XT_DefindcodeTypeID = new long[1] ;
         T000M3_A166XT_DefindcodeTypeName = new String[] {""} ;
         T000M3_n166XT_DefindcodeTypeName = new bool[] {false} ;
         T000M3_A511XT_DefindcodeTypeIsShow = new short[1] ;
         T000M3_n511XT_DefindcodeTypeIsShow = new bool[] {false} ;
         T000M6_A165XT_DefindcodeTypeID = new long[1] ;
         T000M7_A165XT_DefindcodeTypeID = new long[1] ;
         T000M2_A165XT_DefindcodeTypeID = new long[1] ;
         T000M2_A166XT_DefindcodeTypeName = new String[] {""} ;
         T000M2_n166XT_DefindcodeTypeName = new bool[] {false} ;
         T000M2_A511XT_DefindcodeTypeIsShow = new short[1] ;
         T000M2_n511XT_DefindcodeTypeIsShow = new bool[] {false} ;
         T000M8_A165XT_DefindcodeTypeID = new long[1] ;
         T000M11_A167XT_DefineCodeID = new long[1] ;
         T000M12_A165XT_DefindcodeTypeID = new long[1] ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.xt_defindcodetype__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.xt_defindcodetype__default(),
            new Object[][] {
                new Object[] {
               T000M2_A165XT_DefindcodeTypeID, T000M2_A166XT_DefindcodeTypeName, T000M2_n166XT_DefindcodeTypeName, T000M2_A511XT_DefindcodeTypeIsShow, T000M2_n511XT_DefindcodeTypeIsShow
               }
               , new Object[] {
               T000M3_A165XT_DefindcodeTypeID, T000M3_A166XT_DefindcodeTypeName, T000M3_n166XT_DefindcodeTypeName, T000M3_A511XT_DefindcodeTypeIsShow, T000M3_n511XT_DefindcodeTypeIsShow
               }
               , new Object[] {
               T000M4_A165XT_DefindcodeTypeID, T000M4_A166XT_DefindcodeTypeName, T000M4_n166XT_DefindcodeTypeName, T000M4_A511XT_DefindcodeTypeIsShow, T000M4_n511XT_DefindcodeTypeIsShow
               }
               , new Object[] {
               T000M5_A165XT_DefindcodeTypeID
               }
               , new Object[] {
               T000M6_A165XT_DefindcodeTypeID
               }
               , new Object[] {
               T000M7_A165XT_DefindcodeTypeID
               }
               , new Object[] {
               T000M8_A165XT_DefindcodeTypeID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000M11_A167XT_DefineCodeID
               }
               , new Object[] {
               T000M12_A165XT_DefindcodeTypeID
               }
            }
         );
         AV15Pgmname = "XT_DefindcodeType";
         AV14Pgmdesc = "数据字典类型";
      }

      private short Z511XT_DefindcodeTypeIsShow ;
      private short GxWebError ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A511XT_DefindcodeTypeIsShow ;
      private short RcdFound23 ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private int trnEnded ;
      private int edtXT_DefindcodeTypeName_Enabled ;
      private int bttBtntrn_enter_Visible ;
      private int bttBtntrn_enter_Enabled ;
      private int bttBtntrn_cancel_Visible ;
      private int bttBtntrn_delete_Visible ;
      private int bttBtntrn_delete_Enabled ;
      private int edtXT_DefindcodeTypeID_Enabled ;
      private int edtXT_DefindcodeTypeID_Visible ;
      private int idxLst ;
      private long wcpOAV7XT_DefindcodeTypeID ;
      private long Z165XT_DefindcodeTypeID ;
      private long AV7XT_DefindcodeTypeID ;
      private long A165XT_DefindcodeTypeID ;
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
      private String edtXT_DefindcodeTypeName_Internalname ;
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
      private String edtXT_DefindcodeTypeName_Jsonclick ;
      private String bttBtntrn_enter_Internalname ;
      private String bttBtntrn_enter_Jsonclick ;
      private String bttBtntrn_cancel_Internalname ;
      private String bttBtntrn_cancel_Jsonclick ;
      private String bttBtntrn_delete_Internalname ;
      private String bttBtntrn_delete_Jsonclick ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String edtXT_DefindcodeTypeID_Internalname ;
      private String edtXT_DefindcodeTypeID_Jsonclick ;
      private String AV15Pgmname ;
      private String AV14Pgmdesc ;
      private String Dvpanel_tableattributes_Objectcall ;
      private String Dvpanel_tableattributes_Class ;
      private String Dvpanel_tableattributes_Height ;
      private String forbiddenHiddens ;
      private String hsh ;
      private String sMode23 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private bool entryPointCalled ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool Dvpanel_tableattributes_Autowidth ;
      private bool Dvpanel_tableattributes_Autoheight ;
      private bool Dvpanel_tableattributes_Collapsible ;
      private bool Dvpanel_tableattributes_Collapsed ;
      private bool Dvpanel_tableattributes_Showcollapseicon ;
      private bool Dvpanel_tableattributes_Autoscroll ;
      private bool n166XT_DefindcodeTypeName ;
      private bool n511XT_DefindcodeTypeIsShow ;
      private bool Dvpanel_tableattributes_Enabled ;
      private bool Dvpanel_tableattributes_Showheader ;
      private bool Dvpanel_tableattributes_Visible ;
      private bool AV9IsAuthorized ;
      private bool GXt_boolean1 ;
      private bool returnInSub ;
      private String Z166XT_DefindcodeTypeName ;
      private String A166XT_DefindcodeTypeName ;
      private IGxSession AV12WebSession ;
      private GXUserControl ucDvpanel_tableattributes ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] T000M4_A165XT_DefindcodeTypeID ;
      private String[] T000M4_A166XT_DefindcodeTypeName ;
      private bool[] T000M4_n166XT_DefindcodeTypeName ;
      private short[] T000M4_A511XT_DefindcodeTypeIsShow ;
      private bool[] T000M4_n511XT_DefindcodeTypeIsShow ;
      private long[] T000M5_A165XT_DefindcodeTypeID ;
      private long[] T000M3_A165XT_DefindcodeTypeID ;
      private String[] T000M3_A166XT_DefindcodeTypeName ;
      private bool[] T000M3_n166XT_DefindcodeTypeName ;
      private short[] T000M3_A511XT_DefindcodeTypeIsShow ;
      private bool[] T000M3_n511XT_DefindcodeTypeIsShow ;
      private long[] T000M6_A165XT_DefindcodeTypeID ;
      private long[] T000M7_A165XT_DefindcodeTypeID ;
      private long[] T000M2_A165XT_DefindcodeTypeID ;
      private String[] T000M2_A166XT_DefindcodeTypeName ;
      private bool[] T000M2_n166XT_DefindcodeTypeName ;
      private short[] T000M2_A511XT_DefindcodeTypeIsShow ;
      private bool[] T000M2_n511XT_DefindcodeTypeIsShow ;
      private long[] T000M8_A165XT_DefindcodeTypeID ;
      private long[] T000M11_A167XT_DefineCodeID ;
      private long[] T000M12_A165XT_DefindcodeTypeID ;
      private IDataStoreProvider pr_datastore1 ;
      private GXWebForm Form ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV8WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV11TrnContext ;
   }

   public class xt_defindcodetype__datastore1 : DataStoreHelperBase, IDataStoreHelper
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

 public class xt_defindcodetype__default : DataStoreHelperBase, IDataStoreHelper
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
     };
  }

  private static CursorDef[] def;
  private void cursorDefinitions( )
  {
     if ( def == null )
     {
        Object[] prmT000M4 ;
        prmT000M4 = new Object[] {
        new Object[] {"@XT_DefindcodeTypeID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000M5 ;
        prmT000M5 = new Object[] {
        new Object[] {"@XT_DefindcodeTypeID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000M3 ;
        prmT000M3 = new Object[] {
        new Object[] {"@XT_DefindcodeTypeID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000M6 ;
        prmT000M6 = new Object[] {
        new Object[] {"@XT_DefindcodeTypeID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000M7 ;
        prmT000M7 = new Object[] {
        new Object[] {"@XT_DefindcodeTypeID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000M2 ;
        prmT000M2 = new Object[] {
        new Object[] {"@XT_DefindcodeTypeID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000M8 ;
        prmT000M8 = new Object[] {
        new Object[] {"@XT_DefindcodeTypeName",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@XT_DefindcodeTypeIsShow",SqlDbType.SmallInt,4,0}
        } ;
        Object[] prmT000M9 ;
        prmT000M9 = new Object[] {
        new Object[] {"@XT_DefindcodeTypeName",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@XT_DefindcodeTypeIsShow",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@XT_DefindcodeTypeID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000M10 ;
        prmT000M10 = new Object[] {
        new Object[] {"@XT_DefindcodeTypeID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000M11 ;
        prmT000M11 = new Object[] {
        new Object[] {"@XT_DefindcodeTypeID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000M12 ;
        prmT000M12 = new Object[] {
        } ;
        def= new CursorDef[] {
            new CursorDef("T000M2", "SELECT [XT_DefindcodeTypeID], [XT_DefindcodeTypeName], [XT_DefindcodeTypeIsShow] FROM [XT_DefindcodeType] WITH (UPDLOCK) WHERE [XT_DefindcodeTypeID] = @XT_DefindcodeTypeID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000M2,1,0,true,false )
           ,new CursorDef("T000M3", "SELECT [XT_DefindcodeTypeID], [XT_DefindcodeTypeName], [XT_DefindcodeTypeIsShow] FROM [XT_DefindcodeType] WITH (NOLOCK) WHERE [XT_DefindcodeTypeID] = @XT_DefindcodeTypeID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000M3,1,0,true,false )
           ,new CursorDef("T000M4", "SELECT TM1.[XT_DefindcodeTypeID], TM1.[XT_DefindcodeTypeName], TM1.[XT_DefindcodeTypeIsShow] FROM [XT_DefindcodeType] TM1 WITH (NOLOCK) WHERE TM1.[XT_DefindcodeTypeID] = @XT_DefindcodeTypeID ORDER BY TM1.[XT_DefindcodeTypeID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000M4,100,0,true,false )
           ,new CursorDef("T000M5", "SELECT [XT_DefindcodeTypeID] FROM [XT_DefindcodeType] WITH (NOLOCK) WHERE [XT_DefindcodeTypeID] = @XT_DefindcodeTypeID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000M5,1,0,true,false )
           ,new CursorDef("T000M6", "SELECT TOP 1 [XT_DefindcodeTypeID] FROM [XT_DefindcodeType] WITH (NOLOCK) WHERE ( [XT_DefindcodeTypeID] > @XT_DefindcodeTypeID) ORDER BY [XT_DefindcodeTypeID]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000M6,1,0,true,true )
           ,new CursorDef("T000M7", "SELECT TOP 1 [XT_DefindcodeTypeID] FROM [XT_DefindcodeType] WITH (NOLOCK) WHERE ( [XT_DefindcodeTypeID] < @XT_DefindcodeTypeID) ORDER BY [XT_DefindcodeTypeID] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000M7,1,0,true,true )
           ,new CursorDef("T000M8", "INSERT INTO [XT_DefindcodeType]([XT_DefindcodeTypeName], [XT_DefindcodeTypeIsShow]) VALUES(@XT_DefindcodeTypeName, @XT_DefindcodeTypeIsShow); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmT000M8)
           ,new CursorDef("T000M9", "UPDATE [XT_DefindcodeType] SET [XT_DefindcodeTypeName]=@XT_DefindcodeTypeName, [XT_DefindcodeTypeIsShow]=@XT_DefindcodeTypeIsShow  WHERE [XT_DefindcodeTypeID] = @XT_DefindcodeTypeID", GxErrorMask.GX_NOMASK,prmT000M9)
           ,new CursorDef("T000M10", "DELETE FROM [XT_DefindcodeType]  WHERE [XT_DefindcodeTypeID] = @XT_DefindcodeTypeID", GxErrorMask.GX_NOMASK,prmT000M10)
           ,new CursorDef("T000M11", "SELECT TOP 1 [XT_DefineCodeID] FROM [XT_DefineCode] WITH (NOLOCK) WHERE [XT_DefindcodeTypeID] = @XT_DefindcodeTypeID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000M11,1,0,true,true )
           ,new CursorDef("T000M12", "SELECT [XT_DefindcodeTypeID] FROM [XT_DefindcodeType] WITH (NOLOCK) ORDER BY [XT_DefindcodeTypeID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000M12,100,0,true,false )
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
              return;
           case 1 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((short[]) buf[3])[0] = rslt.getShort(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              return;
           case 2 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((short[]) buf[3])[0] = rslt.getShort(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              return;
           case 3 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 4 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 5 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 6 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 9 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 10 :
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
                 stmt.setNull( 2 , SqlDbType.SmallInt );
              }
              else
              {
                 stmt.SetParameter(2, (short)parms[3]);
              }
              stmt.SetParameter(3, (long)parms[4]);
              return;
           case 8 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 9 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
     }
  }

}

}
