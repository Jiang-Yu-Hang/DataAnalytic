/*
               File: BR_Medication_Detail
        Description: 药物治疗药物详情0813弃用
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:8:5.24
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
   public class br_medication_detail : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxJX_Action9") == 0 )
         {
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            XC_9_0U31( ) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxJX_Action10") == 0 )
         {
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            XC_10_0U31( ) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxJX_Action11") == 0 )
         {
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            XC_11_0U31( ) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_13") == 0 )
         {
            A296BR_Medication_SchemeID = (long)(NumberUtil.Val( GetNextPar( ), "."));
            n296BR_Medication_SchemeID = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A296BR_Medication_SchemeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A296BR_Medication_SchemeID), 18, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_13( A296BR_Medication_SchemeID) ;
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
               AV7BR_Medication_DetailID = (long)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7BR_Medication_DetailID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7BR_Medication_DetailID), 18, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vBR_MEDICATION_DETAILID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7BR_Medication_DetailID), "ZZZZZZZZZZZZZZZZZZ"), context));
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
            Form.Meta.addItem("description", "药物治疗药物详情0813弃用", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtBR_Medication_Drug_Name_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("WorkWithPlusTheme");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public br_medication_detail( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_medication_detail( IGxContext context )
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
                           long aP1_BR_Medication_DetailID )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV7BR_Medication_DetailID = aP1_BR_Medication_DetailID;
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 RequiredDataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_Medication_Drug_Name_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Medication_Drug_Name_Internalname, "药物名称", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_Medication_Drug_Name_Internalname, A310BR_Medication_Drug_Name, StringUtil.RTrim( context.localUtil.Format( A310BR_Medication_Drug_Name, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,25);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Medication_Drug_Name_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBR_Medication_Drug_Name_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Medication_Detail.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_Medication_Drug_Num_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Medication_Drug_Num_Internalname, "数量", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_Medication_Drug_Num_Internalname, StringUtil.LTrim( StringUtil.NToC( A311BR_Medication_Drug_Num, 15, 5, ".", "")), ((edtBR_Medication_Drug_Num_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A311BR_Medication_Drug_Num, "ZZZZZZZZZ.ZZZZZ")) : context.localUtil.Format( A311BR_Medication_Drug_Num, "ZZZZZZZZZ.ZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, ',','.','5');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,29);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Medication_Drug_Num_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBR_Medication_Drug_Num_Enabled, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "DM_Numeric", "right", false, "HLP_BR_Medication_Detail.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_Medication_Drug_Unit_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Medication_Drug_Unit_Internalname, "单位", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 33,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_Medication_Drug_Unit_Internalname, A312BR_Medication_Drug_Unit, StringUtil.RTrim( context.localUtil.Format( A312BR_Medication_Drug_Unit, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,33);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Medication_Drug_Unit_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBR_Medication_Drug_Unit_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Medication_Detail.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"";
            ClassString = "ButtonMaterial";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_enter_Internalname, "", "保存", bttBtntrn_enter_Jsonclick, 5, "确认", "", StyleString, ClassString, bttBtntrn_enter_Visible, bttBtntrn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_Medication_Detail.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 40,'',false,'',0)\"";
            ClassString = "ButtonMaterialDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_cancel_Internalname, "", "取消", bttBtntrn_cancel_Jsonclick, 1, "取消", "", StyleString, ClassString, bttBtntrn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_Medication_Detail.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 42,'',false,'',0)\"";
            ClassString = "ButtonMaterialDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_delete_Internalname, "", "删除", bttBtntrn_delete_Jsonclick, 5, "删除", "", StyleString, ClassString, bttBtntrn_delete_Visible, bttBtntrn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_Medication_Detail.htm");
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
            GxWebStd.gx_single_line_edit( context, edtBR_Medication_DetailID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A301BR_Medication_DetailID), 18, 0, ".", "")), ((edtBR_Medication_DetailID_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A301BR_Medication_DetailID), "ZZZZZZZZZZZZZZZZZZ")) : context.localUtil.Format( (decimal)(A301BR_Medication_DetailID), "ZZZZZZZZZZZZZZZZZZ")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Medication_DetailID_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_Medication_DetailID_Visible, edtBR_Medication_DetailID_Enabled, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "HLP_BR_Medication_Detail.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 47,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_Medication_SchemeID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A296BR_Medication_SchemeID), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A296BR_Medication_SchemeID), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,47);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Medication_SchemeID_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_Medication_SchemeID_Visible, edtBR_Medication_SchemeID_Enabled, 1, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "HLP_BR_Medication_Detail.htm");
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
         E110U2 ();
         context.wbGlbDoneStart = 1;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
               A310BR_Medication_Drug_Name = cgiGet( edtBR_Medication_Drug_Name_Internalname);
               n310BR_Medication_Drug_Name = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A310BR_Medication_Drug_Name", A310BR_Medication_Drug_Name);
               n310BR_Medication_Drug_Name = (String.IsNullOrEmpty(StringUtil.RTrim( A310BR_Medication_Drug_Name)) ? true : false);
               if ( ( ( context.localUtil.CToN( cgiGet( edtBR_Medication_Drug_Num_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtBR_Medication_Drug_Num_Internalname), ".", ",") > 999999999.99999m ) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_MEDICATION_DRUG_NUM");
                  AnyError = 1;
                  GX_FocusControl = edtBR_Medication_Drug_Num_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A311BR_Medication_Drug_Num = 0;
                  n311BR_Medication_Drug_Num = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A311BR_Medication_Drug_Num", StringUtil.LTrim( StringUtil.Str( A311BR_Medication_Drug_Num, 15, 5)));
               }
               else
               {
                  A311BR_Medication_Drug_Num = context.localUtil.CToN( cgiGet( edtBR_Medication_Drug_Num_Internalname), ".", ",");
                  n311BR_Medication_Drug_Num = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A311BR_Medication_Drug_Num", StringUtil.LTrim( StringUtil.Str( A311BR_Medication_Drug_Num, 15, 5)));
               }
               n311BR_Medication_Drug_Num = ((Convert.ToDecimal(0)==A311BR_Medication_Drug_Num) ? true : false);
               A312BR_Medication_Drug_Unit = cgiGet( edtBR_Medication_Drug_Unit_Internalname);
               n312BR_Medication_Drug_Unit = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A312BR_Medication_Drug_Unit", A312BR_Medication_Drug_Unit);
               n312BR_Medication_Drug_Unit = (String.IsNullOrEmpty(StringUtil.RTrim( A312BR_Medication_Drug_Unit)) ? true : false);
               A301BR_Medication_DetailID = (long)(context.localUtil.CToN( cgiGet( edtBR_Medication_DetailID_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A301BR_Medication_DetailID", StringUtil.LTrim( StringUtil.Str( (decimal)(A301BR_Medication_DetailID), 18, 0)));
               if ( ( ( context.localUtil.CToN( cgiGet( edtBR_Medication_SchemeID_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtBR_Medication_SchemeID_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_MEDICATION_SCHEMEID");
                  AnyError = 1;
                  GX_FocusControl = edtBR_Medication_SchemeID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A296BR_Medication_SchemeID = 0;
                  n296BR_Medication_SchemeID = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A296BR_Medication_SchemeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A296BR_Medication_SchemeID), 18, 0)));
               }
               else
               {
                  A296BR_Medication_SchemeID = (long)(context.localUtil.CToN( cgiGet( edtBR_Medication_SchemeID_Internalname), ".", ","));
                  n296BR_Medication_SchemeID = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A296BR_Medication_SchemeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A296BR_Medication_SchemeID), 18, 0)));
               }
               n296BR_Medication_SchemeID = ((0==A296BR_Medication_SchemeID) ? true : false);
               /* Read saved values. */
               Z301BR_Medication_DetailID = (long)(context.localUtil.CToN( cgiGet( "Z301BR_Medication_DetailID"), ".", ","));
               Z310BR_Medication_Drug_Name = cgiGet( "Z310BR_Medication_Drug_Name");
               n310BR_Medication_Drug_Name = (String.IsNullOrEmpty(StringUtil.RTrim( A310BR_Medication_Drug_Name)) ? true : false);
               Z311BR_Medication_Drug_Num = context.localUtil.CToN( cgiGet( "Z311BR_Medication_Drug_Num"), ".", ",");
               n311BR_Medication_Drug_Num = ((Convert.ToDecimal(0)==A311BR_Medication_Drug_Num) ? true : false);
               Z312BR_Medication_Drug_Unit = cgiGet( "Z312BR_Medication_Drug_Unit");
               n312BR_Medication_Drug_Unit = (String.IsNullOrEmpty(StringUtil.RTrim( A312BR_Medication_Drug_Unit)) ? true : false);
               Z296BR_Medication_SchemeID = (long)(context.localUtil.CToN( cgiGet( "Z296BR_Medication_SchemeID"), ".", ","));
               n296BR_Medication_SchemeID = ((0==A296BR_Medication_SchemeID) ? true : false);
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ","));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ","));
               Gx_mode = cgiGet( "Mode");
               N296BR_Medication_SchemeID = (long)(context.localUtil.CToN( cgiGet( "N296BR_Medication_SchemeID"), ".", ","));
               n296BR_Medication_SchemeID = ((0==A296BR_Medication_SchemeID) ? true : false);
               AV7BR_Medication_DetailID = (long)(context.localUtil.CToN( cgiGet( "vBR_MEDICATION_DETAILID"), ".", ","));
               AV13Insert_BR_Medication_SchemeID = (long)(context.localUtil.CToN( cgiGet( "vINSERT_BR_MEDICATION_SCHEMEID"), ".", ","));
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
               forbiddenHiddens = "hsh" + "BR_Medication_Detail";
               A301BR_Medication_DetailID = (long)(context.localUtil.CToN( cgiGet( edtBR_Medication_DetailID_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A301BR_Medication_DetailID", StringUtil.LTrim( StringUtil.Str( (decimal)(A301BR_Medication_DetailID), 18, 0)));
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A301BR_Medication_DetailID), "ZZZZZZZZZZZZZZZZZZ");
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV13Insert_BR_Medication_SchemeID), "ZZZZZZZZZZZZZZZZZZ");
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( A301BR_Medication_DetailID != Z301BR_Medication_DetailID ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
               {
                  GXUtil.WriteLog("br_medication_detail:[SecurityCheckFailed value for]"+"BR_Medication_DetailID:"+context.localUtil.Format( (decimal)(A301BR_Medication_DetailID), "ZZZZZZZZZZZZZZZZZZ"));
                  GXUtil.WriteLog("br_medication_detail:[SecurityCheckFailed value for]"+"Insert_BR_Medication_SchemeID:"+context.localUtil.Format( (decimal)(AV13Insert_BR_Medication_SchemeID), "ZZZZZZZZZZZZZZZZZZ"));
                  GXUtil.WriteLog("br_medication_detail:[SecurityCheckFailed value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
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
                  A301BR_Medication_DetailID = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A301BR_Medication_DetailID", StringUtil.LTrim( StringUtil.Str( (decimal)(A301BR_Medication_DetailID), 18, 0)));
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
                     sMode31 = Gx_mode;
                     Gx_mode = "UPD";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     Gx_mode = sMode31;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound31 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_0U0( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtntrn_enter_Internalname;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert", ""), 1, "BR_MEDICATION_DETAILID");
                        AnyError = 1;
                        GX_FocusControl = edtBR_Medication_DetailID_Internalname;
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
                           E110U2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: After Trn */
                           E120U2 ();
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
            E120U2 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll0U31( ) ;
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
            DisableAttributes0U31( ) ;
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

      protected void CONFIRM_0U0( )
      {
         BeforeValidate0U31( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0U31( ) ;
            }
            else
            {
               CheckExtendedTable0U31( ) ;
               CloseExtendedTableCursors0U31( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         }
      }

      protected void ResetCaption0U0( )
      {
      }

      protected void E110U2( )
      {
         /* Start Routine */
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV8WWPContext) ;
         AV9IsAuthorized = true;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9IsAuthorized", AV9IsAuthorized);
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            GXt_boolean1 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "WWBR_Medication_Detail_Insert", out  GXt_boolean1) ;
            AV9IsAuthorized = GXt_boolean1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9IsAuthorized", AV9IsAuthorized);
         }
         if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
         {
            GXt_boolean1 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "WWBR_Medication_Detail_Update", out  GXt_boolean1) ;
            AV9IsAuthorized = GXt_boolean1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9IsAuthorized", AV9IsAuthorized);
         }
         if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
         {
            GXt_boolean1 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "WWBR_Medication_Detail_Delete", out  GXt_boolean1) ;
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
               if ( StringUtil.StrCmp(AV14TrnContextAtt.gxTpr_Attributename, "BR_Medication_SchemeID") == 0 )
               {
                  AV13Insert_BR_Medication_SchemeID = (long)(NumberUtil.Val( AV14TrnContextAtt.gxTpr_Attributevalue, "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13Insert_BR_Medication_SchemeID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13Insert_BR_Medication_SchemeID), 18, 0)));
               }
               AV16GXV1 = (int)(AV16GXV1+1);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV16GXV1), 8, 0)));
            }
         }
         edtBR_Medication_DetailID_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Medication_DetailID_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Medication_DetailID_Visible), 5, 0)), true);
         edtBR_Medication_SchemeID_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Medication_SchemeID_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Medication_SchemeID_Visible), 5, 0)), true);
      }

      protected void E120U2( )
      {
         /* After Trn Routine */
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV11TrnContext.gxTpr_Callerondelete )
         {
            CallWebObject(formatLink("br_medication_detailww.aspx") );
            context.wjLocDisableFrm = 1;
         }
         context.setWebReturnParms(new Object[] {});
         context.setWebReturnParmsMetadata(new Object[] {});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      protected void ZM0U31( short GX_JID )
      {
         if ( ( GX_JID == 12 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z310BR_Medication_Drug_Name = T000U3_A310BR_Medication_Drug_Name[0];
               Z311BR_Medication_Drug_Num = T000U3_A311BR_Medication_Drug_Num[0];
               Z312BR_Medication_Drug_Unit = T000U3_A312BR_Medication_Drug_Unit[0];
               Z296BR_Medication_SchemeID = T000U3_A296BR_Medication_SchemeID[0];
            }
            else
            {
               Z310BR_Medication_Drug_Name = A310BR_Medication_Drug_Name;
               Z311BR_Medication_Drug_Num = A311BR_Medication_Drug_Num;
               Z312BR_Medication_Drug_Unit = A312BR_Medication_Drug_Unit;
               Z296BR_Medication_SchemeID = A296BR_Medication_SchemeID;
            }
         }
         if ( GX_JID == -12 )
         {
            Z301BR_Medication_DetailID = A301BR_Medication_DetailID;
            Z310BR_Medication_Drug_Name = A310BR_Medication_Drug_Name;
            Z311BR_Medication_Drug_Num = A311BR_Medication_Drug_Num;
            Z312BR_Medication_Drug_Unit = A312BR_Medication_Drug_Unit;
            Z296BR_Medication_SchemeID = A296BR_Medication_SchemeID;
         }
      }

      protected void standaloneNotModal( )
      {
         edtBR_Medication_DetailID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Medication_DetailID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Medication_DetailID_Enabled), 5, 0)), true);
         edtBR_Medication_DetailID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Medication_DetailID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Medication_DetailID_Enabled), 5, 0)), true);
         bttBtntrn_delete_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_delete_Enabled), 5, 0)), true);
         if ( ! (0==AV7BR_Medication_DetailID) )
         {
            A301BR_Medication_DetailID = AV7BR_Medication_DetailID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A301BR_Medication_DetailID", StringUtil.LTrim( StringUtil.Str( (decimal)(A301BR_Medication_DetailID), 18, 0)));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV13Insert_BR_Medication_SchemeID) )
         {
            edtBR_Medication_SchemeID_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Medication_SchemeID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Medication_SchemeID_Enabled), 5, 0)), true);
         }
         else
         {
            edtBR_Medication_SchemeID_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Medication_SchemeID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Medication_SchemeID_Enabled), 5, 0)), true);
         }
      }

      protected void standaloneModal( )
      {
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV13Insert_BR_Medication_SchemeID) )
         {
            A296BR_Medication_SchemeID = AV13Insert_BR_Medication_SchemeID;
            n296BR_Medication_SchemeID = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A296BR_Medication_SchemeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A296BR_Medication_SchemeID), 18, 0)));
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
            AV15Pgmname = "BR_Medication_Detail";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15Pgmname", AV15Pgmname);
         }
      }

      protected void Load0U31( )
      {
         /* Using cursor T000U5 */
         pr_default.execute(3, new Object[] {A301BR_Medication_DetailID});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound31 = 1;
            A310BR_Medication_Drug_Name = T000U5_A310BR_Medication_Drug_Name[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A310BR_Medication_Drug_Name", A310BR_Medication_Drug_Name);
            n310BR_Medication_Drug_Name = T000U5_n310BR_Medication_Drug_Name[0];
            A311BR_Medication_Drug_Num = T000U5_A311BR_Medication_Drug_Num[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A311BR_Medication_Drug_Num", StringUtil.LTrim( StringUtil.Str( A311BR_Medication_Drug_Num, 15, 5)));
            n311BR_Medication_Drug_Num = T000U5_n311BR_Medication_Drug_Num[0];
            A312BR_Medication_Drug_Unit = T000U5_A312BR_Medication_Drug_Unit[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A312BR_Medication_Drug_Unit", A312BR_Medication_Drug_Unit);
            n312BR_Medication_Drug_Unit = T000U5_n312BR_Medication_Drug_Unit[0];
            A296BR_Medication_SchemeID = T000U5_A296BR_Medication_SchemeID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A296BR_Medication_SchemeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A296BR_Medication_SchemeID), 18, 0)));
            n296BR_Medication_SchemeID = T000U5_n296BR_Medication_SchemeID[0];
            ZM0U31( -12) ;
         }
         pr_default.close(3);
         OnLoadActions0U31( ) ;
      }

      protected void OnLoadActions0U31( )
      {
         AV15Pgmname = "BR_Medication_Detail";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15Pgmname", AV15Pgmname);
      }

      protected void CheckExtendedTable0U31( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
         AV15Pgmname = "BR_Medication_Detail";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15Pgmname", AV15Pgmname);
         /* Using cursor T000U4 */
         pr_default.execute(2, new Object[] {n296BR_Medication_SchemeID, A296BR_Medication_SchemeID});
         if ( (pr_default.getStatus(2) == 101) )
         {
            if ( ! ( (0==A296BR_Medication_SchemeID) ) )
            {
               GX_msglist.addItem("不匹配' T32'", "ForeignKeyNotFound", 1, "BR_MEDICATION_SCHEMEID");
               AnyError = 1;
               GX_FocusControl = edtBR_Medication_SchemeID_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         pr_default.close(2);
         if ( String.IsNullOrEmpty(StringUtil.RTrim( A310BR_Medication_Drug_Name)) )
         {
            GX_msglist.addItem("药物名称是必须填写的。", 1, "BR_MEDICATION_DRUG_NAME");
            AnyError = 1;
            GX_FocusControl = edtBR_Medication_Drug_Name_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
      }

      protected void CloseExtendedTableCursors0U31( )
      {
         pr_default.close(2);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_13( long A296BR_Medication_SchemeID )
      {
         /* Using cursor T000U6 */
         pr_default.execute(4, new Object[] {n296BR_Medication_SchemeID, A296BR_Medication_SchemeID});
         if ( (pr_default.getStatus(4) == 101) )
         {
            if ( ! ( (0==A296BR_Medication_SchemeID) ) )
            {
               GX_msglist.addItem("不匹配' T32'", "ForeignKeyNotFound", 1, "BR_MEDICATION_SCHEMEID");
               AnyError = 1;
               GX_FocusControl = edtBR_Medication_SchemeID_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(4) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(4);
      }

      protected void GetKey0U31( )
      {
         /* Using cursor T000U7 */
         pr_default.execute(5, new Object[] {A301BR_Medication_DetailID});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound31 = 1;
         }
         else
         {
            RcdFound31 = 0;
         }
         pr_default.close(5);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T000U3 */
         pr_default.execute(1, new Object[] {A301BR_Medication_DetailID});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0U31( 12) ;
            RcdFound31 = 1;
            A301BR_Medication_DetailID = T000U3_A301BR_Medication_DetailID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A301BR_Medication_DetailID", StringUtil.LTrim( StringUtil.Str( (decimal)(A301BR_Medication_DetailID), 18, 0)));
            A310BR_Medication_Drug_Name = T000U3_A310BR_Medication_Drug_Name[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A310BR_Medication_Drug_Name", A310BR_Medication_Drug_Name);
            n310BR_Medication_Drug_Name = T000U3_n310BR_Medication_Drug_Name[0];
            A311BR_Medication_Drug_Num = T000U3_A311BR_Medication_Drug_Num[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A311BR_Medication_Drug_Num", StringUtil.LTrim( StringUtil.Str( A311BR_Medication_Drug_Num, 15, 5)));
            n311BR_Medication_Drug_Num = T000U3_n311BR_Medication_Drug_Num[0];
            A312BR_Medication_Drug_Unit = T000U3_A312BR_Medication_Drug_Unit[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A312BR_Medication_Drug_Unit", A312BR_Medication_Drug_Unit);
            n312BR_Medication_Drug_Unit = T000U3_n312BR_Medication_Drug_Unit[0];
            A296BR_Medication_SchemeID = T000U3_A296BR_Medication_SchemeID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A296BR_Medication_SchemeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A296BR_Medication_SchemeID), 18, 0)));
            n296BR_Medication_SchemeID = T000U3_n296BR_Medication_SchemeID[0];
            Z301BR_Medication_DetailID = A301BR_Medication_DetailID;
            sMode31 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load0U31( ) ;
            if ( AnyError == 1 )
            {
               RcdFound31 = 0;
               InitializeNonKey0U31( ) ;
            }
            Gx_mode = sMode31;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound31 = 0;
            InitializeNonKey0U31( ) ;
            sMode31 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal( ) ;
            Gx_mode = sMode31;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0U31( ) ;
         if ( RcdFound31 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound31 = 0;
         /* Using cursor T000U8 */
         pr_default.execute(6, new Object[] {A301BR_Medication_DetailID});
         if ( (pr_default.getStatus(6) != 101) )
         {
            while ( (pr_default.getStatus(6) != 101) && ( ( T000U8_A301BR_Medication_DetailID[0] < A301BR_Medication_DetailID ) ) )
            {
               pr_default.readNext(6);
            }
            if ( (pr_default.getStatus(6) != 101) && ( ( T000U8_A301BR_Medication_DetailID[0] > A301BR_Medication_DetailID ) ) )
            {
               A301BR_Medication_DetailID = T000U8_A301BR_Medication_DetailID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A301BR_Medication_DetailID", StringUtil.LTrim( StringUtil.Str( (decimal)(A301BR_Medication_DetailID), 18, 0)));
               RcdFound31 = 1;
            }
         }
         pr_default.close(6);
      }

      protected void move_previous( )
      {
         RcdFound31 = 0;
         /* Using cursor T000U9 */
         pr_default.execute(7, new Object[] {A301BR_Medication_DetailID});
         if ( (pr_default.getStatus(7) != 101) )
         {
            while ( (pr_default.getStatus(7) != 101) && ( ( T000U9_A301BR_Medication_DetailID[0] > A301BR_Medication_DetailID ) ) )
            {
               pr_default.readNext(7);
            }
            if ( (pr_default.getStatus(7) != 101) && ( ( T000U9_A301BR_Medication_DetailID[0] < A301BR_Medication_DetailID ) ) )
            {
               A301BR_Medication_DetailID = T000U9_A301BR_Medication_DetailID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A301BR_Medication_DetailID", StringUtil.LTrim( StringUtil.Str( (decimal)(A301BR_Medication_DetailID), 18, 0)));
               RcdFound31 = 1;
            }
         }
         pr_default.close(7);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey0U31( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtBR_Medication_Drug_Name_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert0U31( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound31 == 1 )
            {
               if ( A301BR_Medication_DetailID != Z301BR_Medication_DetailID )
               {
                  A301BR_Medication_DetailID = Z301BR_Medication_DetailID;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A301BR_Medication_DetailID", StringUtil.LTrim( StringUtil.Str( (decimal)(A301BR_Medication_DetailID), 18, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "BR_MEDICATION_DETAILID");
                  AnyError = 1;
                  GX_FocusControl = edtBR_Medication_DetailID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtBR_Medication_Drug_Name_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Update record */
                  Update0U31( ) ;
                  GX_FocusControl = edtBR_Medication_Drug_Name_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A301BR_Medication_DetailID != Z301BR_Medication_DetailID )
               {
                  /* Insert record */
                  GX_FocusControl = edtBR_Medication_Drug_Name_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert0U31( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "BR_MEDICATION_DETAILID");
                     AnyError = 1;
                     GX_FocusControl = edtBR_Medication_DetailID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     /* Insert record */
                     GX_FocusControl = edtBR_Medication_Drug_Name_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert0U31( ) ;
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
         if ( A301BR_Medication_DetailID != Z301BR_Medication_DetailID )
         {
            A301BR_Medication_DetailID = Z301BR_Medication_DetailID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A301BR_Medication_DetailID", StringUtil.LTrim( StringUtil.Str( (decimal)(A301BR_Medication_DetailID), 18, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "BR_MEDICATION_DETAILID");
            AnyError = 1;
            GX_FocusControl = edtBR_Medication_DetailID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtBR_Medication_Drug_Name_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency0U31( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000U2 */
            pr_default.execute(0, new Object[] {A301BR_Medication_DetailID});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BR_Medication_Detail"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z310BR_Medication_Drug_Name, T000U2_A310BR_Medication_Drug_Name[0]) != 0 ) || ( Z311BR_Medication_Drug_Num != T000U2_A311BR_Medication_Drug_Num[0] ) || ( StringUtil.StrCmp(Z312BR_Medication_Drug_Unit, T000U2_A312BR_Medication_Drug_Unit[0]) != 0 ) || ( Z296BR_Medication_SchemeID != T000U2_A296BR_Medication_SchemeID[0] ) )
            {
               if ( StringUtil.StrCmp(Z310BR_Medication_Drug_Name, T000U2_A310BR_Medication_Drug_Name[0]) != 0 )
               {
                  GXUtil.WriteLog("br_medication_detail:[seudo value changed for attri]"+"BR_Medication_Drug_Name");
                  GXUtil.WriteLogRaw("Old: ",Z310BR_Medication_Drug_Name);
                  GXUtil.WriteLogRaw("Current: ",T000U2_A310BR_Medication_Drug_Name[0]);
               }
               if ( Z311BR_Medication_Drug_Num != T000U2_A311BR_Medication_Drug_Num[0] )
               {
                  GXUtil.WriteLog("br_medication_detail:[seudo value changed for attri]"+"BR_Medication_Drug_Num");
                  GXUtil.WriteLogRaw("Old: ",Z311BR_Medication_Drug_Num);
                  GXUtil.WriteLogRaw("Current: ",T000U2_A311BR_Medication_Drug_Num[0]);
               }
               if ( StringUtil.StrCmp(Z312BR_Medication_Drug_Unit, T000U2_A312BR_Medication_Drug_Unit[0]) != 0 )
               {
                  GXUtil.WriteLog("br_medication_detail:[seudo value changed for attri]"+"BR_Medication_Drug_Unit");
                  GXUtil.WriteLogRaw("Old: ",Z312BR_Medication_Drug_Unit);
                  GXUtil.WriteLogRaw("Current: ",T000U2_A312BR_Medication_Drug_Unit[0]);
               }
               if ( Z296BR_Medication_SchemeID != T000U2_A296BR_Medication_SchemeID[0] )
               {
                  GXUtil.WriteLog("br_medication_detail:[seudo value changed for attri]"+"BR_Medication_SchemeID");
                  GXUtil.WriteLogRaw("Old: ",Z296BR_Medication_SchemeID);
                  GXUtil.WriteLogRaw("Current: ",T000U2_A296BR_Medication_SchemeID[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"BR_Medication_Detail"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0U31( )
      {
         BeforeValidate0U31( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0U31( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0U31( 0) ;
            CheckOptimisticConcurrency0U31( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0U31( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0U31( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000U10 */
                     pr_default.execute(8, new Object[] {n310BR_Medication_Drug_Name, A310BR_Medication_Drug_Name, n311BR_Medication_Drug_Num, A311BR_Medication_Drug_Num, n312BR_Medication_Drug_Unit, A312BR_Medication_Drug_Unit, n296BR_Medication_SchemeID, A296BR_Medication_SchemeID});
                     A301BR_Medication_DetailID = T000U10_A301BR_Medication_DetailID[0];
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A301BR_Medication_DetailID", StringUtil.LTrim( StringUtil.Str( (decimal)(A301BR_Medication_DetailID), 18, 0)));
                     pr_default.close(8);
                     dsDefault.SmartCacheProvider.SetUpdated("BR_Medication_Detail") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A296BR_Medication_SchemeID), 18, 0)),  "化疗方案",  StringUtil.Trim( StringUtil.Str( (decimal)(A301BR_Medication_DetailID), 18, 0)),  "药物详情",  "Create",  1) ;
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                           ResetCaption0U0( ) ;
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
               Load0U31( ) ;
            }
            EndLevel0U31( ) ;
         }
         CloseExtendedTableCursors0U31( ) ;
      }

      protected void Update0U31( )
      {
         BeforeValidate0U31( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0U31( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0U31( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0U31( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0U31( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000U11 */
                     pr_default.execute(9, new Object[] {n310BR_Medication_Drug_Name, A310BR_Medication_Drug_Name, n311BR_Medication_Drug_Num, A311BR_Medication_Drug_Num, n312BR_Medication_Drug_Unit, A312BR_Medication_Drug_Unit, n296BR_Medication_SchemeID, A296BR_Medication_SchemeID, A301BR_Medication_DetailID});
                     pr_default.close(9);
                     dsDefault.SmartCacheProvider.SetUpdated("BR_Medication_Detail") ;
                     if ( (pr_default.getStatus(9) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BR_Medication_Detail"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0U31( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A296BR_Medication_SchemeID), 18, 0)),  "化疗方案",  StringUtil.Trim( StringUtil.Str( (decimal)(A301BR_Medication_DetailID), 18, 0)),  "药物详情",  "Update",  1) ;
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
            EndLevel0U31( ) ;
         }
         CloseExtendedTableCursors0U31( ) ;
      }

      protected void DeferredUpdate0U31( )
      {
      }

      protected void delete( )
      {
         BeforeValidate0U31( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0U31( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0U31( ) ;
            AfterConfirm0U31( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0U31( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000U12 */
                  pr_default.execute(10, new Object[] {A301BR_Medication_DetailID});
                  pr_default.close(10);
                  dsDefault.SmartCacheProvider.SetUpdated("BR_Medication_Detail") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A296BR_Medication_SchemeID), 18, 0)),  "化疗方案",  StringUtil.Trim( StringUtil.Str( (decimal)(A301BR_Medication_DetailID), 18, 0)),  "药物详情",  "Delete",  1) ;
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
         sMode31 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel0U31( ) ;
         Gx_mode = sMode31;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls0U31( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV15Pgmname = "BR_Medication_Detail";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15Pgmname", AV15Pgmname);
         }
      }

      protected void EndLevel0U31( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0U31( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(1);
            context.CommitDataStores("br_medication_detail",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues0U0( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(1);
            context.RollbackDataStores("br_medication_detail",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart0U31( )
      {
         /* Scan By routine */
         /* Using cursor T000U13 */
         pr_default.execute(11);
         RcdFound31 = 0;
         if ( (pr_default.getStatus(11) != 101) )
         {
            RcdFound31 = 1;
            A301BR_Medication_DetailID = T000U13_A301BR_Medication_DetailID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A301BR_Medication_DetailID", StringUtil.LTrim( StringUtil.Str( (decimal)(A301BR_Medication_DetailID), 18, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0U31( )
      {
         /* Scan next routine */
         pr_default.readNext(11);
         RcdFound31 = 0;
         if ( (pr_default.getStatus(11) != 101) )
         {
            RcdFound31 = 1;
            A301BR_Medication_DetailID = T000U13_A301BR_Medication_DetailID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A301BR_Medication_DetailID", StringUtil.LTrim( StringUtil.Str( (decimal)(A301BR_Medication_DetailID), 18, 0)));
         }
      }

      protected void ScanEnd0U31( )
      {
         pr_default.close(11);
      }

      protected void AfterConfirm0U31( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0U31( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0U31( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0U31( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0U31( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0U31( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0U31( )
      {
         edtBR_Medication_Drug_Name_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Medication_Drug_Name_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Medication_Drug_Name_Enabled), 5, 0)), true);
         edtBR_Medication_Drug_Num_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Medication_Drug_Num_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Medication_Drug_Num_Enabled), 5, 0)), true);
         edtBR_Medication_Drug_Unit_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Medication_Drug_Unit_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Medication_Drug_Unit_Enabled), 5, 0)), true);
         edtBR_Medication_DetailID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Medication_DetailID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Medication_DetailID_Enabled), 5, 0)), true);
         edtBR_Medication_SchemeID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Medication_SchemeID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Medication_SchemeID_Enabled), 5, 0)), true);
      }

      protected void send_integrity_lvl_hashes0U31( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues0U0( )
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
         context.AddJavascriptSource("gxcfg.js", "?2020228158693", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_medication_detail.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7BR_Medication_DetailID)+"\">") ;
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
         forbiddenHiddens = "hsh" + "BR_Medication_Detail";
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A301BR_Medication_DetailID), "ZZZZZZZZZZZZZZZZZZ");
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV13Insert_BR_Medication_SchemeID), "ZZZZZZZZZZZZZZZZZZ");
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("br_medication_detail:[SendSecurityCheck value for]"+"BR_Medication_DetailID:"+context.localUtil.Format( (decimal)(A301BR_Medication_DetailID), "ZZZZZZZZZZZZZZZZZZ"));
         GXUtil.WriteLog("br_medication_detail:[SendSecurityCheck value for]"+"Insert_BR_Medication_SchemeID:"+context.localUtil.Format( (decimal)(AV13Insert_BR_Medication_SchemeID), "ZZZZZZZZZZZZZZZZZZ"));
         GXUtil.WriteLog("br_medication_detail:[SendSecurityCheck value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z301BR_Medication_DetailID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z301BR_Medication_DetailID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z310BR_Medication_Drug_Name", Z310BR_Medication_Drug_Name);
         GxWebStd.gx_hidden_field( context, "Z311BR_Medication_Drug_Num", StringUtil.LTrim( StringUtil.NToC( Z311BR_Medication_Drug_Num, 15, 5, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z312BR_Medication_Drug_Unit", Z312BR_Medication_Drug_Unit);
         GxWebStd.gx_hidden_field( context, "Z296BR_Medication_SchemeID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z296BR_Medication_SchemeID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_Mode", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GxWebStd.gx_hidden_field( context, "N296BR_Medication_SchemeID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A296BR_Medication_SchemeID), 18, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vTRNCONTEXT", AV11TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vTRNCONTEXT", AV11TrnContext);
         }
         GxWebStd.gx_hidden_field( context, "vBR_MEDICATION_DETAILID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7BR_Medication_DetailID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vBR_MEDICATION_DETAILID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7BR_Medication_DetailID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, "vINSERT_BR_MEDICATION_SCHEMEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13Insert_BR_Medication_SchemeID), 18, 0, ".", "")));
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
         return formatLink("br_medication_detail.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7BR_Medication_DetailID) ;
      }

      public override String GetPgmname( )
      {
         return "BR_Medication_Detail" ;
      }

      public override String GetPgmdesc( )
      {
         return "药物治疗药物详情0813弃用" ;
      }

      protected void InitializeNonKey0U31( )
      {
         A296BR_Medication_SchemeID = 0;
         n296BR_Medication_SchemeID = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A296BR_Medication_SchemeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A296BR_Medication_SchemeID), 18, 0)));
         n296BR_Medication_SchemeID = ((0==A296BR_Medication_SchemeID) ? true : false);
         A310BR_Medication_Drug_Name = "";
         n310BR_Medication_Drug_Name = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A310BR_Medication_Drug_Name", A310BR_Medication_Drug_Name);
         n310BR_Medication_Drug_Name = (String.IsNullOrEmpty(StringUtil.RTrim( A310BR_Medication_Drug_Name)) ? true : false);
         A311BR_Medication_Drug_Num = 0;
         n311BR_Medication_Drug_Num = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A311BR_Medication_Drug_Num", StringUtil.LTrim( StringUtil.Str( A311BR_Medication_Drug_Num, 15, 5)));
         n311BR_Medication_Drug_Num = ((Convert.ToDecimal(0)==A311BR_Medication_Drug_Num) ? true : false);
         A312BR_Medication_Drug_Unit = "";
         n312BR_Medication_Drug_Unit = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A312BR_Medication_Drug_Unit", A312BR_Medication_Drug_Unit);
         n312BR_Medication_Drug_Unit = (String.IsNullOrEmpty(StringUtil.RTrim( A312BR_Medication_Drug_Unit)) ? true : false);
         Z310BR_Medication_Drug_Name = "";
         Z311BR_Medication_Drug_Num = 0;
         Z312BR_Medication_Drug_Unit = "";
         Z296BR_Medication_SchemeID = 0;
      }

      protected void InitAll0U31( )
      {
         A301BR_Medication_DetailID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A301BR_Medication_DetailID", StringUtil.LTrim( StringUtil.Str( (decimal)(A301BR_Medication_DetailID), 18, 0)));
         InitializeNonKey0U31( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2020228158721", true);
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
         context.AddJavascriptSource("br_medication_detail.js", "?2020228158722", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         edtBR_Medication_Drug_Name_Internalname = "BR_MEDICATION_DRUG_NAME";
         edtBR_Medication_Drug_Num_Internalname = "BR_MEDICATION_DRUG_NUM";
         edtBR_Medication_Drug_Unit_Internalname = "BR_MEDICATION_DRUG_UNIT";
         divTableattributes_Internalname = "TABLEATTRIBUTES";
         divLayout_tableattributes_Internalname = "LAYOUT_TABLEATTRIBUTES";
         Dvpanel_tableattributes_Internalname = "DVPANEL_TABLEATTRIBUTES";
         divHtml_dvpanel_tableattributes_Internalname = "HTML_DVPANEL_TABLEATTRIBUTES";
         divTablecontent_Internalname = "TABLECONTENT";
         bttBtntrn_enter_Internalname = "BTNTRN_ENTER";
         bttBtntrn_cancel_Internalname = "BTNTRN_CANCEL";
         bttBtntrn_delete_Internalname = "BTNTRN_DELETE";
         divTablemain_Internalname = "TABLEMAIN";
         edtBR_Medication_DetailID_Internalname = "BR_MEDICATION_DETAILID";
         edtBR_Medication_SchemeID_Internalname = "BR_MEDICATION_SCHEMEID";
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
         Form.Caption = "药物治疗药物详情0813弃用";
         edtBR_Medication_SchemeID_Jsonclick = "";
         edtBR_Medication_SchemeID_Enabled = 1;
         edtBR_Medication_SchemeID_Visible = 1;
         edtBR_Medication_DetailID_Jsonclick = "";
         edtBR_Medication_DetailID_Enabled = 0;
         edtBR_Medication_DetailID_Visible = 1;
         bttBtntrn_delete_Enabled = 0;
         bttBtntrn_delete_Visible = 1;
         bttBtntrn_cancel_Visible = 1;
         bttBtntrn_enter_Enabled = 1;
         bttBtntrn_enter_Visible = 1;
         edtBR_Medication_Drug_Unit_Jsonclick = "";
         edtBR_Medication_Drug_Unit_Enabled = 1;
         edtBR_Medication_Drug_Num_Jsonclick = "";
         edtBR_Medication_Drug_Num_Enabled = 1;
         edtBR_Medication_Drug_Name_Jsonclick = "";
         edtBR_Medication_Drug_Name_Enabled = 1;
         Dvpanel_tableattributes_Autoscroll = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Iconposition = "left";
         Dvpanel_tableattributes_Showcollapseicon = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsed = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsible = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Title = "药物治疗药物详情";
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

      protected void XC_9_0U31( )
      {
         new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A296BR_Medication_SchemeID), 18, 0)),  "化疗方案",  StringUtil.Trim( StringUtil.Str( (decimal)(A301BR_Medication_DetailID), 18, 0)),  "药物详情",  "Create",  1) ;
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

      protected void XC_10_0U31( )
      {
         new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A296BR_Medication_SchemeID), 18, 0)),  "化疗方案",  StringUtil.Trim( StringUtil.Str( (decimal)(A301BR_Medication_DetailID), 18, 0)),  "药物详情",  "Update",  1) ;
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

      protected void XC_11_0U31( )
      {
         new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A296BR_Medication_SchemeID), 18, 0)),  "化疗方案",  StringUtil.Trim( StringUtil.Str( (decimal)(A301BR_Medication_DetailID), 18, 0)),  "药物详情",  "Delete",  1) ;
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

      public void Valid_Br_medication_schemeid( long GX_Parm1 )
      {
         A296BR_Medication_SchemeID = GX_Parm1;
         n296BR_Medication_SchemeID = false;
         /* Using cursor T000U14 */
         pr_default.execute(12, new Object[] {n296BR_Medication_SchemeID, A296BR_Medication_SchemeID});
         if ( (pr_default.getStatus(12) == 101) )
         {
            if ( ! ( (0==A296BR_Medication_SchemeID) ) )
            {
               GX_msglist.addItem("不匹配' T32'", "ForeignKeyNotFound", 1, "BR_MEDICATION_SCHEMEID");
               AnyError = 1;
               GX_FocusControl = edtBR_Medication_SchemeID_Internalname;
            }
         }
         pr_default.close(12);
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
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7BR_Medication_DetailID',fld:'vBR_MEDICATION_DETAILID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7BR_Medication_DetailID',fld:'vBR_MEDICATION_DETAILID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'A301BR_Medication_DetailID',fld:'BR_MEDICATION_DETAILID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV13Insert_BR_Medication_SchemeID',fld:'vINSERT_BR_MEDICATION_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("AFTER TRN","{handler:'E120U2',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV11TrnContext',fld:'vTRNCONTEXT',pic:''}]");
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
         Z310BR_Medication_Drug_Name = "";
         Z312BR_Medication_Drug_Unit = "";
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
         A310BR_Medication_Drug_Name = "";
         A312BR_Medication_Drug_Unit = "";
         bttBtntrn_enter_Jsonclick = "";
         bttBtntrn_cancel_Jsonclick = "";
         bttBtntrn_delete_Jsonclick = "";
         AV15Pgmname = "";
         Dvpanel_tableattributes_Objectcall = "";
         Dvpanel_tableattributes_Class = "";
         Dvpanel_tableattributes_Height = "";
         forbiddenHiddens = "";
         hsh = "";
         sMode31 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV8WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV11TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV12WebSession = context.GetSession();
         AV14TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         T000U5_A301BR_Medication_DetailID = new long[1] ;
         T000U5_A310BR_Medication_Drug_Name = new String[] {""} ;
         T000U5_n310BR_Medication_Drug_Name = new bool[] {false} ;
         T000U5_A311BR_Medication_Drug_Num = new decimal[1] ;
         T000U5_n311BR_Medication_Drug_Num = new bool[] {false} ;
         T000U5_A312BR_Medication_Drug_Unit = new String[] {""} ;
         T000U5_n312BR_Medication_Drug_Unit = new bool[] {false} ;
         T000U5_A296BR_Medication_SchemeID = new long[1] ;
         T000U5_n296BR_Medication_SchemeID = new bool[] {false} ;
         T000U4_A296BR_Medication_SchemeID = new long[1] ;
         T000U4_n296BR_Medication_SchemeID = new bool[] {false} ;
         T000U6_A296BR_Medication_SchemeID = new long[1] ;
         T000U6_n296BR_Medication_SchemeID = new bool[] {false} ;
         T000U7_A301BR_Medication_DetailID = new long[1] ;
         T000U3_A301BR_Medication_DetailID = new long[1] ;
         T000U3_A310BR_Medication_Drug_Name = new String[] {""} ;
         T000U3_n310BR_Medication_Drug_Name = new bool[] {false} ;
         T000U3_A311BR_Medication_Drug_Num = new decimal[1] ;
         T000U3_n311BR_Medication_Drug_Num = new bool[] {false} ;
         T000U3_A312BR_Medication_Drug_Unit = new String[] {""} ;
         T000U3_n312BR_Medication_Drug_Unit = new bool[] {false} ;
         T000U3_A296BR_Medication_SchemeID = new long[1] ;
         T000U3_n296BR_Medication_SchemeID = new bool[] {false} ;
         T000U8_A301BR_Medication_DetailID = new long[1] ;
         T000U9_A301BR_Medication_DetailID = new long[1] ;
         T000U2_A301BR_Medication_DetailID = new long[1] ;
         T000U2_A310BR_Medication_Drug_Name = new String[] {""} ;
         T000U2_n310BR_Medication_Drug_Name = new bool[] {false} ;
         T000U2_A311BR_Medication_Drug_Num = new decimal[1] ;
         T000U2_n311BR_Medication_Drug_Num = new bool[] {false} ;
         T000U2_A312BR_Medication_Drug_Unit = new String[] {""} ;
         T000U2_n312BR_Medication_Drug_Unit = new bool[] {false} ;
         T000U2_A296BR_Medication_SchemeID = new long[1] ;
         T000U2_n296BR_Medication_SchemeID = new bool[] {false} ;
         T000U10_A301BR_Medication_DetailID = new long[1] ;
         T000U13_A301BR_Medication_DetailID = new long[1] ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         T000U14_A296BR_Medication_SchemeID = new long[1] ;
         T000U14_n296BR_Medication_SchemeID = new bool[] {false} ;
         isValidOutput = new GxUnknownObjectCollection();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.br_medication_detail__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_medication_detail__default(),
            new Object[][] {
                new Object[] {
               T000U2_A301BR_Medication_DetailID, T000U2_A310BR_Medication_Drug_Name, T000U2_n310BR_Medication_Drug_Name, T000U2_A311BR_Medication_Drug_Num, T000U2_n311BR_Medication_Drug_Num, T000U2_A312BR_Medication_Drug_Unit, T000U2_n312BR_Medication_Drug_Unit, T000U2_A296BR_Medication_SchemeID, T000U2_n296BR_Medication_SchemeID
               }
               , new Object[] {
               T000U3_A301BR_Medication_DetailID, T000U3_A310BR_Medication_Drug_Name, T000U3_n310BR_Medication_Drug_Name, T000U3_A311BR_Medication_Drug_Num, T000U3_n311BR_Medication_Drug_Num, T000U3_A312BR_Medication_Drug_Unit, T000U3_n312BR_Medication_Drug_Unit, T000U3_A296BR_Medication_SchemeID, T000U3_n296BR_Medication_SchemeID
               }
               , new Object[] {
               T000U4_A296BR_Medication_SchemeID
               }
               , new Object[] {
               T000U5_A301BR_Medication_DetailID, T000U5_A310BR_Medication_Drug_Name, T000U5_n310BR_Medication_Drug_Name, T000U5_A311BR_Medication_Drug_Num, T000U5_n311BR_Medication_Drug_Num, T000U5_A312BR_Medication_Drug_Unit, T000U5_n312BR_Medication_Drug_Unit, T000U5_A296BR_Medication_SchemeID, T000U5_n296BR_Medication_SchemeID
               }
               , new Object[] {
               T000U6_A296BR_Medication_SchemeID
               }
               , new Object[] {
               T000U7_A301BR_Medication_DetailID
               }
               , new Object[] {
               T000U8_A301BR_Medication_DetailID
               }
               , new Object[] {
               T000U9_A301BR_Medication_DetailID
               }
               , new Object[] {
               T000U10_A301BR_Medication_DetailID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000U13_A301BR_Medication_DetailID
               }
               , new Object[] {
               T000U14_A296BR_Medication_SchemeID
               }
            }
         );
         AV15Pgmname = "BR_Medication_Detail";
      }

      private short GxWebError ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short RcdFound31 ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int trnEnded ;
      private int edtBR_Medication_Drug_Name_Enabled ;
      private int edtBR_Medication_Drug_Num_Enabled ;
      private int edtBR_Medication_Drug_Unit_Enabled ;
      private int bttBtntrn_enter_Visible ;
      private int bttBtntrn_enter_Enabled ;
      private int bttBtntrn_cancel_Visible ;
      private int bttBtntrn_delete_Visible ;
      private int bttBtntrn_delete_Enabled ;
      private int edtBR_Medication_DetailID_Enabled ;
      private int edtBR_Medication_DetailID_Visible ;
      private int edtBR_Medication_SchemeID_Visible ;
      private int edtBR_Medication_SchemeID_Enabled ;
      private int AV16GXV1 ;
      private int idxLst ;
      private long wcpOAV7BR_Medication_DetailID ;
      private long Z301BR_Medication_DetailID ;
      private long Z296BR_Medication_SchemeID ;
      private long N296BR_Medication_SchemeID ;
      private long A296BR_Medication_SchemeID ;
      private long AV7BR_Medication_DetailID ;
      private long A301BR_Medication_DetailID ;
      private long AV13Insert_BR_Medication_SchemeID ;
      private decimal Z311BR_Medication_Drug_Num ;
      private decimal A311BR_Medication_Drug_Num ;
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
      private String edtBR_Medication_Drug_Name_Internalname ;
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
      private String edtBR_Medication_Drug_Name_Jsonclick ;
      private String edtBR_Medication_Drug_Num_Internalname ;
      private String edtBR_Medication_Drug_Num_Jsonclick ;
      private String edtBR_Medication_Drug_Unit_Internalname ;
      private String edtBR_Medication_Drug_Unit_Jsonclick ;
      private String bttBtntrn_enter_Internalname ;
      private String bttBtntrn_enter_Jsonclick ;
      private String bttBtntrn_cancel_Internalname ;
      private String bttBtntrn_cancel_Jsonclick ;
      private String bttBtntrn_delete_Internalname ;
      private String bttBtntrn_delete_Jsonclick ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String edtBR_Medication_DetailID_Internalname ;
      private String edtBR_Medication_DetailID_Jsonclick ;
      private String edtBR_Medication_SchemeID_Internalname ;
      private String edtBR_Medication_SchemeID_Jsonclick ;
      private String AV15Pgmname ;
      private String Dvpanel_tableattributes_Objectcall ;
      private String Dvpanel_tableattributes_Class ;
      private String Dvpanel_tableattributes_Height ;
      private String forbiddenHiddens ;
      private String hsh ;
      private String sMode31 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private bool entryPointCalled ;
      private bool n296BR_Medication_SchemeID ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool Dvpanel_tableattributes_Autowidth ;
      private bool Dvpanel_tableattributes_Autoheight ;
      private bool Dvpanel_tableattributes_Collapsible ;
      private bool Dvpanel_tableattributes_Collapsed ;
      private bool Dvpanel_tableattributes_Showcollapseicon ;
      private bool Dvpanel_tableattributes_Autoscroll ;
      private bool n310BR_Medication_Drug_Name ;
      private bool n311BR_Medication_Drug_Num ;
      private bool n312BR_Medication_Drug_Unit ;
      private bool Dvpanel_tableattributes_Enabled ;
      private bool Dvpanel_tableattributes_Showheader ;
      private bool Dvpanel_tableattributes_Visible ;
      private bool AV9IsAuthorized ;
      private bool GXt_boolean1 ;
      private bool returnInSub ;
      private String Z310BR_Medication_Drug_Name ;
      private String Z312BR_Medication_Drug_Unit ;
      private String A310BR_Medication_Drug_Name ;
      private String A312BR_Medication_Drug_Unit ;
      private IGxSession AV12WebSession ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXUserControl ucDvpanel_tableattributes ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] T000U5_A301BR_Medication_DetailID ;
      private String[] T000U5_A310BR_Medication_Drug_Name ;
      private bool[] T000U5_n310BR_Medication_Drug_Name ;
      private decimal[] T000U5_A311BR_Medication_Drug_Num ;
      private bool[] T000U5_n311BR_Medication_Drug_Num ;
      private String[] T000U5_A312BR_Medication_Drug_Unit ;
      private bool[] T000U5_n312BR_Medication_Drug_Unit ;
      private long[] T000U5_A296BR_Medication_SchemeID ;
      private bool[] T000U5_n296BR_Medication_SchemeID ;
      private long[] T000U4_A296BR_Medication_SchemeID ;
      private bool[] T000U4_n296BR_Medication_SchemeID ;
      private long[] T000U6_A296BR_Medication_SchemeID ;
      private bool[] T000U6_n296BR_Medication_SchemeID ;
      private long[] T000U7_A301BR_Medication_DetailID ;
      private long[] T000U3_A301BR_Medication_DetailID ;
      private String[] T000U3_A310BR_Medication_Drug_Name ;
      private bool[] T000U3_n310BR_Medication_Drug_Name ;
      private decimal[] T000U3_A311BR_Medication_Drug_Num ;
      private bool[] T000U3_n311BR_Medication_Drug_Num ;
      private String[] T000U3_A312BR_Medication_Drug_Unit ;
      private bool[] T000U3_n312BR_Medication_Drug_Unit ;
      private long[] T000U3_A296BR_Medication_SchemeID ;
      private bool[] T000U3_n296BR_Medication_SchemeID ;
      private long[] T000U8_A301BR_Medication_DetailID ;
      private long[] T000U9_A301BR_Medication_DetailID ;
      private long[] T000U2_A301BR_Medication_DetailID ;
      private String[] T000U2_A310BR_Medication_Drug_Name ;
      private bool[] T000U2_n310BR_Medication_Drug_Name ;
      private decimal[] T000U2_A311BR_Medication_Drug_Num ;
      private bool[] T000U2_n311BR_Medication_Drug_Num ;
      private String[] T000U2_A312BR_Medication_Drug_Unit ;
      private bool[] T000U2_n312BR_Medication_Drug_Unit ;
      private long[] T000U2_A296BR_Medication_SchemeID ;
      private bool[] T000U2_n296BR_Medication_SchemeID ;
      private long[] T000U10_A301BR_Medication_DetailID ;
      private long[] T000U13_A301BR_Medication_DetailID ;
      private long[] T000U14_A296BR_Medication_SchemeID ;
      private bool[] T000U14_n296BR_Medication_SchemeID ;
      private IDataStoreProvider pr_datastore1 ;
      private GXWebForm Form ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV8WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV11TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute AV14TrnContextAtt ;
   }

   public class br_medication_detail__datastore1 : DataStoreHelperBase, IDataStoreHelper
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

 public class br_medication_detail__default : DataStoreHelperBase, IDataStoreHelper
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
        Object[] prmT000U5 ;
        prmT000U5 = new Object[] {
        new Object[] {"@BR_Medication_DetailID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000U4 ;
        prmT000U4 = new Object[] {
        new Object[] {"@BR_Medication_SchemeID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000U6 ;
        prmT000U6 = new Object[] {
        new Object[] {"@BR_Medication_SchemeID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000U7 ;
        prmT000U7 = new Object[] {
        new Object[] {"@BR_Medication_DetailID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000U3 ;
        prmT000U3 = new Object[] {
        new Object[] {"@BR_Medication_DetailID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000U8 ;
        prmT000U8 = new Object[] {
        new Object[] {"@BR_Medication_DetailID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000U9 ;
        prmT000U9 = new Object[] {
        new Object[] {"@BR_Medication_DetailID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000U2 ;
        prmT000U2 = new Object[] {
        new Object[] {"@BR_Medication_DetailID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000U10 ;
        prmT000U10 = new Object[] {
        new Object[] {"@BR_Medication_Drug_Name",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Medication_Drug_Num",SqlDbType.Decimal,15,5} ,
        new Object[] {"@BR_Medication_Drug_Unit",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Medication_SchemeID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000U11 ;
        prmT000U11 = new Object[] {
        new Object[] {"@BR_Medication_Drug_Name",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Medication_Drug_Num",SqlDbType.Decimal,15,5} ,
        new Object[] {"@BR_Medication_Drug_Unit",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Medication_SchemeID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@BR_Medication_DetailID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000U12 ;
        prmT000U12 = new Object[] {
        new Object[] {"@BR_Medication_DetailID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000U13 ;
        prmT000U13 = new Object[] {
        } ;
        Object[] prmT000U14 ;
        prmT000U14 = new Object[] {
        new Object[] {"@BR_Medication_SchemeID",SqlDbType.Decimal,18,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("T000U2", "SELECT [BR_Medication_DetailID], [BR_Medication_Drug_Name], [BR_Medication_Drug_Num], [BR_Medication_Drug_Unit], [BR_Medication_SchemeID] FROM [BR_Medication_Detail] WITH (UPDLOCK) WHERE [BR_Medication_DetailID] = @BR_Medication_DetailID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000U2,1,0,true,false )
           ,new CursorDef("T000U3", "SELECT [BR_Medication_DetailID], [BR_Medication_Drug_Name], [BR_Medication_Drug_Num], [BR_Medication_Drug_Unit], [BR_Medication_SchemeID] FROM [BR_Medication_Detail] WITH (NOLOCK) WHERE [BR_Medication_DetailID] = @BR_Medication_DetailID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000U3,1,0,true,false )
           ,new CursorDef("T000U4", "SELECT [BR_Medication_SchemeID] FROM [BR_Medication_Scheme] WITH (NOLOCK) WHERE [BR_Medication_SchemeID] = @BR_Medication_SchemeID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000U4,1,0,true,false )
           ,new CursorDef("T000U5", "SELECT TM1.[BR_Medication_DetailID], TM1.[BR_Medication_Drug_Name], TM1.[BR_Medication_Drug_Num], TM1.[BR_Medication_Drug_Unit], TM1.[BR_Medication_SchemeID] FROM [BR_Medication_Detail] TM1 WITH (NOLOCK) WHERE TM1.[BR_Medication_DetailID] = @BR_Medication_DetailID ORDER BY TM1.[BR_Medication_DetailID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000U5,100,0,true,false )
           ,new CursorDef("T000U6", "SELECT [BR_Medication_SchemeID] FROM [BR_Medication_Scheme] WITH (NOLOCK) WHERE [BR_Medication_SchemeID] = @BR_Medication_SchemeID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000U6,1,0,true,false )
           ,new CursorDef("T000U7", "SELECT [BR_Medication_DetailID] FROM [BR_Medication_Detail] WITH (NOLOCK) WHERE [BR_Medication_DetailID] = @BR_Medication_DetailID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000U7,1,0,true,false )
           ,new CursorDef("T000U8", "SELECT TOP 1 [BR_Medication_DetailID] FROM [BR_Medication_Detail] WITH (NOLOCK) WHERE ( [BR_Medication_DetailID] > @BR_Medication_DetailID) ORDER BY [BR_Medication_DetailID]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000U8,1,0,true,true )
           ,new CursorDef("T000U9", "SELECT TOP 1 [BR_Medication_DetailID] FROM [BR_Medication_Detail] WITH (NOLOCK) WHERE ( [BR_Medication_DetailID] < @BR_Medication_DetailID) ORDER BY [BR_Medication_DetailID] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000U9,1,0,true,true )
           ,new CursorDef("T000U10", "INSERT INTO [BR_Medication_Detail]([BR_Medication_Drug_Name], [BR_Medication_Drug_Num], [BR_Medication_Drug_Unit], [BR_Medication_SchemeID]) VALUES(@BR_Medication_Drug_Name, @BR_Medication_Drug_Num, @BR_Medication_Drug_Unit, @BR_Medication_SchemeID); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmT000U10)
           ,new CursorDef("T000U11", "UPDATE [BR_Medication_Detail] SET [BR_Medication_Drug_Name]=@BR_Medication_Drug_Name, [BR_Medication_Drug_Num]=@BR_Medication_Drug_Num, [BR_Medication_Drug_Unit]=@BR_Medication_Drug_Unit, [BR_Medication_SchemeID]=@BR_Medication_SchemeID  WHERE [BR_Medication_DetailID] = @BR_Medication_DetailID", GxErrorMask.GX_NOMASK,prmT000U11)
           ,new CursorDef("T000U12", "DELETE FROM [BR_Medication_Detail]  WHERE [BR_Medication_DetailID] = @BR_Medication_DetailID", GxErrorMask.GX_NOMASK,prmT000U12)
           ,new CursorDef("T000U13", "SELECT [BR_Medication_DetailID] FROM [BR_Medication_Detail] WITH (NOLOCK) ORDER BY [BR_Medication_DetailID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000U13,100,0,true,false )
           ,new CursorDef("T000U14", "SELECT [BR_Medication_SchemeID] FROM [BR_Medication_Scheme] WITH (NOLOCK) WHERE [BR_Medication_SchemeID] = @BR_Medication_SchemeID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000U14,1,0,true,false )
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
              ((decimal[]) buf[3])[0] = rslt.getDecimal(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((long[]) buf[7])[0] = rslt.getLong(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              return;
           case 1 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((decimal[]) buf[3])[0] = rslt.getDecimal(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((long[]) buf[7])[0] = rslt.getLong(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              return;
           case 2 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 3 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((decimal[]) buf[3])[0] = rslt.getDecimal(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((long[]) buf[7])[0] = rslt.getLong(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
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
           case 7 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 8 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 11 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
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
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
              }
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
                 stmt.setNull( 2 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(2, (decimal)parms[3]);
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
                 stmt.setNull( 4 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(4, (long)parms[7]);
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
              if ( (bool)parms[2] )
              {
                 stmt.setNull( 2 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(2, (decimal)parms[3]);
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
                 stmt.setNull( 4 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(4, (long)parms[7]);
              }
              stmt.SetParameter(5, (long)parms[8]);
              return;
           case 10 :
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
     }
  }

}

}
