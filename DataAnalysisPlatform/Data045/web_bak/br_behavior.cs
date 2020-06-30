/*
               File: BR_Behavior
        Description: 个人史
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:35:52.67
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
   public class br_behavior : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"BR_BEHAVIOR_SMOKING") == 0 )
         {
            AV12tCurrentCode = GetNextPar( );
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12tCurrentCode", AV12tCurrentCode);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GXDLABR_BEHAVIOR_SMOKING089( AV12tCurrentCode) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"BR_BEHAVIOR_ACHOHOL") == 0 )
         {
            AV12tCurrentCode = GetNextPar( );
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12tCurrentCode", AV12tCurrentCode);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GXDLABR_BEHAVIOR_ACHOHOL089( AV12tCurrentCode) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel3"+"_"+"BR_BEHAVIOR_SMOKING_CODE") == 0 )
         {
            A21BR_Behavior_Smoking = GetNextPar( );
            n21BR_Behavior_Smoking = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A21BR_Behavior_Smoking", A21BR_Behavior_Smoking);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX3ASABR_BEHAVIOR_SMOKING_CODE089( A21BR_Behavior_Smoking) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel4"+"_"+"BR_BEHAVIOR_SMOKING_CODE") == 0 )
         {
            A21BR_Behavior_Smoking = GetNextPar( );
            n21BR_Behavior_Smoking = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A21BR_Behavior_Smoking", A21BR_Behavior_Smoking);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX4ASABR_BEHAVIOR_SMOKING_CODE089( A21BR_Behavior_Smoking) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel5"+"_"+"BR_BEHAVIOR_ACHOHOL_CODE") == 0 )
         {
            A25BR_Behavior_Achohol = GetNextPar( );
            n25BR_Behavior_Achohol = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A25BR_Behavior_Achohol", A25BR_Behavior_Achohol);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX5ASABR_BEHAVIOR_ACHOHOL_CODE089( A25BR_Behavior_Achohol) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel6"+"_"+"BR_BEHAVIOR_ACHOHOL_CODE") == 0 )
         {
            A25BR_Behavior_Achohol = GetNextPar( );
            n25BR_Behavior_Achohol = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A25BR_Behavior_Achohol", A25BR_Behavior_Achohol);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX6ASABR_BEHAVIOR_ACHOHOL_CODE089( A25BR_Behavior_Achohol) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel7"+"_"+"BR_BEHAVIOR_FAMILYCAHISTORY_CODE") == 0 )
         {
            A29BR_Behavior_FamilyCaHistory = GetNextPar( );
            n29BR_Behavior_FamilyCaHistory = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A29BR_Behavior_FamilyCaHistory", A29BR_Behavior_FamilyCaHistory);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX7ASABR_BEHAVIOR_FAMILYCAHISTORY_CODE089( A29BR_Behavior_FamilyCaHistory) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel8"+"_"+"BR_BEHAVIOR_FAMILYCAHISTORY_CODE") == 0 )
         {
            A29BR_Behavior_FamilyCaHistory = GetNextPar( );
            n29BR_Behavior_FamilyCaHistory = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A29BR_Behavior_FamilyCaHistory", A29BR_Behavior_FamilyCaHistory);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX8ASABR_BEHAVIOR_FAMILYCAHISTORY_CODE089( A29BR_Behavior_FamilyCaHistory) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel9"+"_"+"BR_BEHAVIOR_MENOPAUSE_CODE") == 0 )
         {
            A31BR_Behavior_Menopause = GetNextPar( );
            n31BR_Behavior_Menopause = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A31BR_Behavior_Menopause", A31BR_Behavior_Menopause);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX9ASABR_BEHAVIOR_MENOPAUSE_CODE089( A31BR_Behavior_Menopause) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel10"+"_"+"BR_BEHAVIOR_MENOPAUSE_CODE") == 0 )
         {
            A31BR_Behavior_Menopause = GetNextPar( );
            n31BR_Behavior_Menopause = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A31BR_Behavior_Menopause", A31BR_Behavior_Menopause);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX10ASABR_BEHAVIOR_MENOPAUSE_CODE089( A31BR_Behavior_Menopause) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_14") == 0 )
         {
            A19BR_EncounterID = (long)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_14( A19BR_EncounterID) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_15") == 0 )
         {
            A85BR_Information_ID = (long)(NumberUtil.Val( GetNextPar( ), "."));
            n85BR_Information_ID = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A85BR_Information_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A85BR_Information_ID), 18, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_15( A85BR_Information_ID) ;
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
            Form.Meta.addItem("description", "个人史", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtBR_EncounterID_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("WorkWithPlusTheme");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public br_behavior( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_behavior( IGxContext context )
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
         dynBR_Behavior_Smoking = new GXCombobox();
         dynBR_Behavior_Achohol = new GXCombobox();
         cmbBR_Behavior_FamilyCaHistory = new GXCombobox();
         cmbBR_Behavior_Menopause = new GXCombobox();
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
         if ( dynBR_Behavior_Smoking.ItemCount > 0 )
         {
            A21BR_Behavior_Smoking = dynBR_Behavior_Smoking.getValidValue(A21BR_Behavior_Smoking);
            n21BR_Behavior_Smoking = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A21BR_Behavior_Smoking", A21BR_Behavior_Smoking);
         }
         if ( context.isAjaxRequest( ) )
         {
            dynBR_Behavior_Smoking.CurrentValue = StringUtil.RTrim( A21BR_Behavior_Smoking);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynBR_Behavior_Smoking_Internalname, "Values", dynBR_Behavior_Smoking.ToJavascriptSource(), true);
         }
         if ( dynBR_Behavior_Achohol.ItemCount > 0 )
         {
            A25BR_Behavior_Achohol = dynBR_Behavior_Achohol.getValidValue(A25BR_Behavior_Achohol);
            n25BR_Behavior_Achohol = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A25BR_Behavior_Achohol", A25BR_Behavior_Achohol);
         }
         if ( context.isAjaxRequest( ) )
         {
            dynBR_Behavior_Achohol.CurrentValue = StringUtil.RTrim( A25BR_Behavior_Achohol);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynBR_Behavior_Achohol_Internalname, "Values", dynBR_Behavior_Achohol.ToJavascriptSource(), true);
         }
         if ( cmbBR_Behavior_FamilyCaHistory.ItemCount > 0 )
         {
            A29BR_Behavior_FamilyCaHistory = cmbBR_Behavior_FamilyCaHistory.getValidValue(A29BR_Behavior_FamilyCaHistory);
            n29BR_Behavior_FamilyCaHistory = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A29BR_Behavior_FamilyCaHistory", A29BR_Behavior_FamilyCaHistory);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbBR_Behavior_FamilyCaHistory.CurrentValue = StringUtil.RTrim( A29BR_Behavior_FamilyCaHistory);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Behavior_FamilyCaHistory_Internalname, "Values", cmbBR_Behavior_FamilyCaHistory.ToJavascriptSource(), true);
         }
         if ( cmbBR_Behavior_Menopause.ItemCount > 0 )
         {
            A31BR_Behavior_Menopause = cmbBR_Behavior_Menopause.getValidValue(A31BR_Behavior_Menopause);
            n31BR_Behavior_Menopause = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A31BR_Behavior_Menopause", A31BR_Behavior_Menopause);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbBR_Behavior_Menopause.CurrentValue = StringUtil.RTrim( A31BR_Behavior_Menopause);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Behavior_Menopause_Internalname, "Values", cmbBR_Behavior_Menopause.ToJavascriptSource(), true);
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-9 col-lg-6", "left", "top", "", "", "div");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_EncounterID_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_EncounterID_Internalname, "病人就诊信息ID", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_EncounterID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A19BR_EncounterID), 18, 0, ".", "")), ((edtBR_EncounterID_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A19BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ")) : context.localUtil.Format( (decimal)(A19BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,25);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_EncounterID_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBR_EncounterID_Enabled, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "HLP_BR_Behavior.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-6 DataContentCell", "left", "top", "", "", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-6 DataContentCell", "left", "top", "", "", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+dynBR_Behavior_Smoking_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynBR_Behavior_Smoking_Internalname, "吸烟编码", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 32,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynBR_Behavior_Smoking, dynBR_Behavior_Smoking_Internalname, StringUtil.RTrim( A21BR_Behavior_Smoking), 1, dynBR_Behavior_Smoking_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, dynBR_Behavior_Smoking.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,32);\"", "", true, "HLP_BR_Behavior.htm");
            dynBR_Behavior_Smoking.CurrentValue = StringUtil.RTrim( A21BR_Behavior_Smoking);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynBR_Behavior_Smoking_Internalname, "Values", (String)(dynBR_Behavior_Smoking.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_Behavior_SmokingTime_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Behavior_SmokingTime_Internalname, "吸烟时长", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 37,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_Behavior_SmokingTime_Internalname, A22BR_Behavior_SmokingTime, StringUtil.RTrim( context.localUtil.Format( A22BR_Behavior_SmokingTime, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,37);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Behavior_SmokingTime_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBR_Behavior_SmokingTime_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Behavior.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_Behavior_SmokingAmount_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Behavior_SmokingAmount_Internalname, "吸烟量", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 41,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_Behavior_SmokingAmount_Internalname, A23BR_Behavior_SmokingAmount, StringUtil.RTrim( context.localUtil.Format( A23BR_Behavior_SmokingAmount, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,41);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Behavior_SmokingAmount_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBR_Behavior_SmokingAmount_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Behavior.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_Behavior_RawSmokingAmount_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Behavior_RawSmokingAmount_Internalname, "约吸烟量编码", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_Behavior_RawSmokingAmount_Internalname, A24BR_Behavior_RawSmokingAmount, StringUtil.RTrim( context.localUtil.Format( A24BR_Behavior_RawSmokingAmount, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,46);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Behavior_RawSmokingAmount_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBR_Behavior_RawSmokingAmount_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Behavior.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+dynBR_Behavior_Achohol_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynBR_Behavior_Achohol_Internalname, "饮酒编码", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 50,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynBR_Behavior_Achohol, dynBR_Behavior_Achohol_Internalname, StringUtil.RTrim( A25BR_Behavior_Achohol), 1, dynBR_Behavior_Achohol_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, dynBR_Behavior_Achohol.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,50);\"", "", true, "HLP_BR_Behavior.htm");
            dynBR_Behavior_Achohol.CurrentValue = StringUtil.RTrim( A25BR_Behavior_Achohol);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynBR_Behavior_Achohol_Internalname, "Values", (String)(dynBR_Behavior_Achohol.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_Behavior_AchoholTime_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Behavior_AchoholTime_Internalname, "饮酒时长", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 55,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_Behavior_AchoholTime_Internalname, A26BR_Behavior_AchoholTime, StringUtil.RTrim( context.localUtil.Format( A26BR_Behavior_AchoholTime, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,55);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Behavior_AchoholTime_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBR_Behavior_AchoholTime_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Behavior.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_Behavior_AchoholAmount_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Behavior_AchoholAmount_Internalname, "饮酒量", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 59,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_Behavior_AchoholAmount_Internalname, A27BR_Behavior_AchoholAmount, StringUtil.RTrim( context.localUtil.Format( A27BR_Behavior_AchoholAmount, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,59);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Behavior_AchoholAmount_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBR_Behavior_AchoholAmount_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Behavior.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_Behavior_RawAchoholAmount_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Behavior_RawAchoholAmount_Internalname, "约饮酒量编码", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 64,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_Behavior_RawAchoholAmount_Internalname, A28BR_Behavior_RawAchoholAmount, StringUtil.RTrim( context.localUtil.Format( A28BR_Behavior_RawAchoholAmount, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,64);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Behavior_RawAchoholAmount_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBR_Behavior_RawAchoholAmount_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Behavior.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbBR_Behavior_FamilyCaHistory_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbBR_Behavior_FamilyCaHistory_Internalname, "家族肿瘤史编码", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 68,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbBR_Behavior_FamilyCaHistory, cmbBR_Behavior_FamilyCaHistory_Internalname, StringUtil.RTrim( A29BR_Behavior_FamilyCaHistory), 1, cmbBR_Behavior_FamilyCaHistory_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, cmbBR_Behavior_FamilyCaHistory.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,68);\"", "", true, "HLP_BR_Behavior.htm");
            cmbBR_Behavior_FamilyCaHistory.CurrentValue = StringUtil.RTrim( A29BR_Behavior_FamilyCaHistory);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Behavior_FamilyCaHistory_Internalname, "Values", (String)(cmbBR_Behavior_FamilyCaHistory.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_Behavior_FamilyCancer_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Behavior_FamilyCancer_Internalname, "家族性肿瘤", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 73,'',false,'',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtBR_Behavior_FamilyCancer_Internalname, A30BR_Behavior_FamilyCancer, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,73);\"", 0, 1, edtBR_Behavior_FamilyCancer_Enabled, 0, 80, "chr", 3, "row", StyleString, ClassString, "", "", "200", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Behavior.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbBR_Behavior_Menopause_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbBR_Behavior_Menopause_Internalname, "绝经状态编码", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 77,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbBR_Behavior_Menopause, cmbBR_Behavior_Menopause_Internalname, StringUtil.RTrim( A31BR_Behavior_Menopause), 1, cmbBR_Behavior_Menopause_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, cmbBR_Behavior_Menopause.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,77);\"", "", true, "HLP_BR_Behavior.htm");
            cmbBR_Behavior_Menopause.CurrentValue = StringUtil.RTrim( A31BR_Behavior_Menopause);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Behavior_Menopause_Internalname, "Values", (String)(cmbBR_Behavior_Menopause.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_Behavior_MenopauseAge_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Behavior_MenopauseAge_Internalname, "绝经年龄", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 82,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_Behavior_MenopauseAge_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A32BR_Behavior_MenopauseAge), 4, 0, ".", "")), ((edtBR_Behavior_MenopauseAge_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A32BR_Behavior_MenopauseAge), "ZZZZ")) : context.localUtil.Format( (decimal)(A32BR_Behavior_MenopauseAge), "ZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,82);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Behavior_MenopauseAge_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBR_Behavior_MenopauseAge_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Behavior.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_Behavior_RawMenopauseAge_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Behavior_RawMenopauseAge_Internalname, "约绝经年龄", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 86,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_Behavior_RawMenopauseAge_Internalname, A33BR_Behavior_RawMenopauseAge, StringUtil.RTrim( context.localUtil.Format( A33BR_Behavior_RawMenopauseAge, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,86);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Behavior_RawMenopauseAge_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBR_Behavior_RawMenopauseAge_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Behavior.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_Behavior_ChildNum_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Behavior_ChildNum_Internalname, "子女数量", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 91,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_Behavior_ChildNum_Internalname, A34BR_Behavior_ChildNum, StringUtil.RTrim( context.localUtil.Format( A34BR_Behavior_ChildNum, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,91);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Behavior_ChildNum_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBR_Behavior_ChildNum_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Behavior.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 96,'',false,'',0)\"";
            ClassString = "Button";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_enter_Internalname, "", "确认", bttBtntrn_enter_Jsonclick, 5, "确认", "", StyleString, ClassString, bttBtntrn_enter_Visible, bttBtntrn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_Behavior.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 98,'',false,'',0)\"";
            ClassString = "BtnDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_cancel_Internalname, "", "取消", bttBtntrn_cancel_Jsonclick, 1, "取消", "", StyleString, ClassString, bttBtntrn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_Behavior.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 100,'',false,'',0)\"";
            ClassString = "BtnDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_delete_Internalname, "", "删除", bttBtntrn_delete_Jsonclick, 5, "删除", "", StyleString, ClassString, bttBtntrn_delete_Visible, bttBtntrn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_Behavior.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 104,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_BehaviorID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A20BR_BehaviorID), 18, 0, ".", "")), ((edtBR_BehaviorID_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A20BR_BehaviorID), "ZZZZZZZZZZZZZZZZZZ")) : context.localUtil.Format( (decimal)(A20BR_BehaviorID), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,104);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_BehaviorID_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBR_BehaviorID_Enabled, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "HLP_BR_Behavior.htm");
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
         E11082 ();
         context.wbGlbDoneStart = 1;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
               if ( ( ( context.localUtil.CToN( cgiGet( edtBR_EncounterID_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtBR_EncounterID_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_ENCOUNTERID");
                  AnyError = 1;
                  GX_FocusControl = edtBR_EncounterID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A19BR_EncounterID = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
               }
               else
               {
                  A19BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( edtBR_EncounterID_Internalname), ".", ","));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
               }
               dynBR_Behavior_Smoking.CurrentValue = cgiGet( dynBR_Behavior_Smoking_Internalname);
               A21BR_Behavior_Smoking = cgiGet( dynBR_Behavior_Smoking_Internalname);
               n21BR_Behavior_Smoking = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A21BR_Behavior_Smoking", A21BR_Behavior_Smoking);
               n21BR_Behavior_Smoking = (String.IsNullOrEmpty(StringUtil.RTrim( A21BR_Behavior_Smoking)) ? true : false);
               A22BR_Behavior_SmokingTime = cgiGet( edtBR_Behavior_SmokingTime_Internalname);
               n22BR_Behavior_SmokingTime = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22BR_Behavior_SmokingTime", A22BR_Behavior_SmokingTime);
               n22BR_Behavior_SmokingTime = (String.IsNullOrEmpty(StringUtil.RTrim( A22BR_Behavior_SmokingTime)) ? true : false);
               A23BR_Behavior_SmokingAmount = cgiGet( edtBR_Behavior_SmokingAmount_Internalname);
               n23BR_Behavior_SmokingAmount = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23BR_Behavior_SmokingAmount", A23BR_Behavior_SmokingAmount);
               n23BR_Behavior_SmokingAmount = (String.IsNullOrEmpty(StringUtil.RTrim( A23BR_Behavior_SmokingAmount)) ? true : false);
               A24BR_Behavior_RawSmokingAmount = cgiGet( edtBR_Behavior_RawSmokingAmount_Internalname);
               n24BR_Behavior_RawSmokingAmount = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A24BR_Behavior_RawSmokingAmount", A24BR_Behavior_RawSmokingAmount);
               n24BR_Behavior_RawSmokingAmount = (String.IsNullOrEmpty(StringUtil.RTrim( A24BR_Behavior_RawSmokingAmount)) ? true : false);
               dynBR_Behavior_Achohol.CurrentValue = cgiGet( dynBR_Behavior_Achohol_Internalname);
               A25BR_Behavior_Achohol = cgiGet( dynBR_Behavior_Achohol_Internalname);
               n25BR_Behavior_Achohol = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A25BR_Behavior_Achohol", A25BR_Behavior_Achohol);
               n25BR_Behavior_Achohol = (String.IsNullOrEmpty(StringUtil.RTrim( A25BR_Behavior_Achohol)) ? true : false);
               A26BR_Behavior_AchoholTime = cgiGet( edtBR_Behavior_AchoholTime_Internalname);
               n26BR_Behavior_AchoholTime = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A26BR_Behavior_AchoholTime", A26BR_Behavior_AchoholTime);
               n26BR_Behavior_AchoholTime = (String.IsNullOrEmpty(StringUtil.RTrim( A26BR_Behavior_AchoholTime)) ? true : false);
               A27BR_Behavior_AchoholAmount = cgiGet( edtBR_Behavior_AchoholAmount_Internalname);
               n27BR_Behavior_AchoholAmount = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27BR_Behavior_AchoholAmount", A27BR_Behavior_AchoholAmount);
               n27BR_Behavior_AchoholAmount = (String.IsNullOrEmpty(StringUtil.RTrim( A27BR_Behavior_AchoholAmount)) ? true : false);
               A28BR_Behavior_RawAchoholAmount = cgiGet( edtBR_Behavior_RawAchoholAmount_Internalname);
               n28BR_Behavior_RawAchoholAmount = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A28BR_Behavior_RawAchoholAmount", A28BR_Behavior_RawAchoholAmount);
               n28BR_Behavior_RawAchoholAmount = (String.IsNullOrEmpty(StringUtil.RTrim( A28BR_Behavior_RawAchoholAmount)) ? true : false);
               cmbBR_Behavior_FamilyCaHistory.CurrentValue = cgiGet( cmbBR_Behavior_FamilyCaHistory_Internalname);
               A29BR_Behavior_FamilyCaHistory = cgiGet( cmbBR_Behavior_FamilyCaHistory_Internalname);
               n29BR_Behavior_FamilyCaHistory = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A29BR_Behavior_FamilyCaHistory", A29BR_Behavior_FamilyCaHistory);
               n29BR_Behavior_FamilyCaHistory = (String.IsNullOrEmpty(StringUtil.RTrim( A29BR_Behavior_FamilyCaHistory)) ? true : false);
               A30BR_Behavior_FamilyCancer = cgiGet( edtBR_Behavior_FamilyCancer_Internalname);
               n30BR_Behavior_FamilyCancer = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A30BR_Behavior_FamilyCancer", A30BR_Behavior_FamilyCancer);
               n30BR_Behavior_FamilyCancer = (String.IsNullOrEmpty(StringUtil.RTrim( A30BR_Behavior_FamilyCancer)) ? true : false);
               cmbBR_Behavior_Menopause.CurrentValue = cgiGet( cmbBR_Behavior_Menopause_Internalname);
               A31BR_Behavior_Menopause = cgiGet( cmbBR_Behavior_Menopause_Internalname);
               n31BR_Behavior_Menopause = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A31BR_Behavior_Menopause", A31BR_Behavior_Menopause);
               n31BR_Behavior_Menopause = (String.IsNullOrEmpty(StringUtil.RTrim( A31BR_Behavior_Menopause)) ? true : false);
               if ( ( ( context.localUtil.CToN( cgiGet( edtBR_Behavior_MenopauseAge_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtBR_Behavior_MenopauseAge_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_BEHAVIOR_MENOPAUSEAGE");
                  AnyError = 1;
                  GX_FocusControl = edtBR_Behavior_MenopauseAge_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A32BR_Behavior_MenopauseAge = 0;
                  n32BR_Behavior_MenopauseAge = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32BR_Behavior_MenopauseAge", StringUtil.LTrim( StringUtil.Str( (decimal)(A32BR_Behavior_MenopauseAge), 4, 0)));
               }
               else
               {
                  A32BR_Behavior_MenopauseAge = (short)(context.localUtil.CToN( cgiGet( edtBR_Behavior_MenopauseAge_Internalname), ".", ","));
                  n32BR_Behavior_MenopauseAge = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32BR_Behavior_MenopauseAge", StringUtil.LTrim( StringUtil.Str( (decimal)(A32BR_Behavior_MenopauseAge), 4, 0)));
               }
               n32BR_Behavior_MenopauseAge = ((0==A32BR_Behavior_MenopauseAge) ? true : false);
               A33BR_Behavior_RawMenopauseAge = cgiGet( edtBR_Behavior_RawMenopauseAge_Internalname);
               n33BR_Behavior_RawMenopauseAge = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33BR_Behavior_RawMenopauseAge", A33BR_Behavior_RawMenopauseAge);
               n33BR_Behavior_RawMenopauseAge = (String.IsNullOrEmpty(StringUtil.RTrim( A33BR_Behavior_RawMenopauseAge)) ? true : false);
               A34BR_Behavior_ChildNum = cgiGet( edtBR_Behavior_ChildNum_Internalname);
               n34BR_Behavior_ChildNum = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34BR_Behavior_ChildNum", A34BR_Behavior_ChildNum);
               n34BR_Behavior_ChildNum = (String.IsNullOrEmpty(StringUtil.RTrim( A34BR_Behavior_ChildNum)) ? true : false);
               if ( ( ( context.localUtil.CToN( cgiGet( edtBR_BehaviorID_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtBR_BehaviorID_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_BEHAVIORID");
                  AnyError = 1;
                  GX_FocusControl = edtBR_BehaviorID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A20BR_BehaviorID = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20BR_BehaviorID", StringUtil.LTrim( StringUtil.Str( (decimal)(A20BR_BehaviorID), 18, 0)));
               }
               else
               {
                  A20BR_BehaviorID = (long)(context.localUtil.CToN( cgiGet( edtBR_BehaviorID_Internalname), ".", ","));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20BR_BehaviorID", StringUtil.LTrim( StringUtil.Str( (decimal)(A20BR_BehaviorID), 18, 0)));
               }
               /* Read saved values. */
               Z20BR_BehaviorID = (long)(context.localUtil.CToN( cgiGet( "Z20BR_BehaviorID"), ".", ","));
               Z460BR_Behavior_Smoking_Code = cgiGet( "Z460BR_Behavior_Smoking_Code");
               n460BR_Behavior_Smoking_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A460BR_Behavior_Smoking_Code)) ? true : false);
               Z462BR_Behavior_Achohol_Code = cgiGet( "Z462BR_Behavior_Achohol_Code");
               n462BR_Behavior_Achohol_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A462BR_Behavior_Achohol_Code)) ? true : false);
               Z464BR_Behavior_FamilyCaHistory_Code = cgiGet( "Z464BR_Behavior_FamilyCaHistory_Code");
               n464BR_Behavior_FamilyCaHistory_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A464BR_Behavior_FamilyCaHistory_Code)) ? true : false);
               Z465BR_Behavior_Menopause_Code = cgiGet( "Z465BR_Behavior_Menopause_Code");
               n465BR_Behavior_Menopause_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A465BR_Behavior_Menopause_Code)) ? true : false);
               Z21BR_Behavior_Smoking = cgiGet( "Z21BR_Behavior_Smoking");
               n21BR_Behavior_Smoking = (String.IsNullOrEmpty(StringUtil.RTrim( A21BR_Behavior_Smoking)) ? true : false);
               Z22BR_Behavior_SmokingTime = cgiGet( "Z22BR_Behavior_SmokingTime");
               n22BR_Behavior_SmokingTime = (String.IsNullOrEmpty(StringUtil.RTrim( A22BR_Behavior_SmokingTime)) ? true : false);
               Z23BR_Behavior_SmokingAmount = cgiGet( "Z23BR_Behavior_SmokingAmount");
               n23BR_Behavior_SmokingAmount = (String.IsNullOrEmpty(StringUtil.RTrim( A23BR_Behavior_SmokingAmount)) ? true : false);
               Z24BR_Behavior_RawSmokingAmount = cgiGet( "Z24BR_Behavior_RawSmokingAmount");
               n24BR_Behavior_RawSmokingAmount = (String.IsNullOrEmpty(StringUtil.RTrim( A24BR_Behavior_RawSmokingAmount)) ? true : false);
               Z461BR_Behavior_RawSmokingAmount_Code = cgiGet( "Z461BR_Behavior_RawSmokingAmount_Code");
               n461BR_Behavior_RawSmokingAmount_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A461BR_Behavior_RawSmokingAmount_Code)) ? true : false);
               Z25BR_Behavior_Achohol = cgiGet( "Z25BR_Behavior_Achohol");
               n25BR_Behavior_Achohol = (String.IsNullOrEmpty(StringUtil.RTrim( A25BR_Behavior_Achohol)) ? true : false);
               Z26BR_Behavior_AchoholTime = cgiGet( "Z26BR_Behavior_AchoholTime");
               n26BR_Behavior_AchoholTime = (String.IsNullOrEmpty(StringUtil.RTrim( A26BR_Behavior_AchoholTime)) ? true : false);
               Z27BR_Behavior_AchoholAmount = cgiGet( "Z27BR_Behavior_AchoholAmount");
               n27BR_Behavior_AchoholAmount = (String.IsNullOrEmpty(StringUtil.RTrim( A27BR_Behavior_AchoholAmount)) ? true : false);
               Z28BR_Behavior_RawAchoholAmount = cgiGet( "Z28BR_Behavior_RawAchoholAmount");
               n28BR_Behavior_RawAchoholAmount = (String.IsNullOrEmpty(StringUtil.RTrim( A28BR_Behavior_RawAchoholAmount)) ? true : false);
               Z463BR_Behavior_RawAchoholAmount_Code = cgiGet( "Z463BR_Behavior_RawAchoholAmount_Code");
               n463BR_Behavior_RawAchoholAmount_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A463BR_Behavior_RawAchoholAmount_Code)) ? true : false);
               Z29BR_Behavior_FamilyCaHistory = cgiGet( "Z29BR_Behavior_FamilyCaHistory");
               n29BR_Behavior_FamilyCaHistory = (String.IsNullOrEmpty(StringUtil.RTrim( A29BR_Behavior_FamilyCaHistory)) ? true : false);
               Z30BR_Behavior_FamilyCancer = cgiGet( "Z30BR_Behavior_FamilyCancer");
               n30BR_Behavior_FamilyCancer = (String.IsNullOrEmpty(StringUtil.RTrim( A30BR_Behavior_FamilyCancer)) ? true : false);
               Z31BR_Behavior_Menopause = cgiGet( "Z31BR_Behavior_Menopause");
               n31BR_Behavior_Menopause = (String.IsNullOrEmpty(StringUtil.RTrim( A31BR_Behavior_Menopause)) ? true : false);
               Z32BR_Behavior_MenopauseAge = (short)(context.localUtil.CToN( cgiGet( "Z32BR_Behavior_MenopauseAge"), ".", ","));
               n32BR_Behavior_MenopauseAge = ((0==A32BR_Behavior_MenopauseAge) ? true : false);
               Z33BR_Behavior_RawMenopauseAge = cgiGet( "Z33BR_Behavior_RawMenopauseAge");
               n33BR_Behavior_RawMenopauseAge = (String.IsNullOrEmpty(StringUtil.RTrim( A33BR_Behavior_RawMenopauseAge)) ? true : false);
               Z34BR_Behavior_ChildNum = cgiGet( "Z34BR_Behavior_ChildNum");
               n34BR_Behavior_ChildNum = (String.IsNullOrEmpty(StringUtil.RTrim( A34BR_Behavior_ChildNum)) ? true : false);
               Z19BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( "Z19BR_EncounterID"), ".", ","));
               A460BR_Behavior_Smoking_Code = cgiGet( "Z460BR_Behavior_Smoking_Code");
               n460BR_Behavior_Smoking_Code = false;
               n460BR_Behavior_Smoking_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A460BR_Behavior_Smoking_Code)) ? true : false);
               A462BR_Behavior_Achohol_Code = cgiGet( "Z462BR_Behavior_Achohol_Code");
               n462BR_Behavior_Achohol_Code = false;
               n462BR_Behavior_Achohol_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A462BR_Behavior_Achohol_Code)) ? true : false);
               A464BR_Behavior_FamilyCaHistory_Code = cgiGet( "Z464BR_Behavior_FamilyCaHistory_Code");
               n464BR_Behavior_FamilyCaHistory_Code = false;
               n464BR_Behavior_FamilyCaHistory_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A464BR_Behavior_FamilyCaHistory_Code)) ? true : false);
               A465BR_Behavior_Menopause_Code = cgiGet( "Z465BR_Behavior_Menopause_Code");
               n465BR_Behavior_Menopause_Code = false;
               n465BR_Behavior_Menopause_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A465BR_Behavior_Menopause_Code)) ? true : false);
               A461BR_Behavior_RawSmokingAmount_Code = cgiGet( "Z461BR_Behavior_RawSmokingAmount_Code");
               n461BR_Behavior_RawSmokingAmount_Code = false;
               n461BR_Behavior_RawSmokingAmount_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A461BR_Behavior_RawSmokingAmount_Code)) ? true : false);
               A463BR_Behavior_RawAchoholAmount_Code = cgiGet( "Z463BR_Behavior_RawAchoholAmount_Code");
               n463BR_Behavior_RawAchoholAmount_Code = false;
               n463BR_Behavior_RawAchoholAmount_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A463BR_Behavior_RawAchoholAmount_Code)) ? true : false);
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ","));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ","));
               Gx_mode = cgiGet( "Mode");
               A460BR_Behavior_Smoking_Code = cgiGet( "BR_BEHAVIOR_SMOKING_CODE");
               n460BR_Behavior_Smoking_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A460BR_Behavior_Smoking_Code)) ? true : false);
               A462BR_Behavior_Achohol_Code = cgiGet( "BR_BEHAVIOR_ACHOHOL_CODE");
               n462BR_Behavior_Achohol_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A462BR_Behavior_Achohol_Code)) ? true : false);
               A464BR_Behavior_FamilyCaHistory_Code = cgiGet( "BR_BEHAVIOR_FAMILYCAHISTORY_CODE");
               n464BR_Behavior_FamilyCaHistory_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A464BR_Behavior_FamilyCaHistory_Code)) ? true : false);
               A465BR_Behavior_Menopause_Code = cgiGet( "BR_BEHAVIOR_MENOPAUSE_CODE");
               n465BR_Behavior_Menopause_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A465BR_Behavior_Menopause_Code)) ? true : false);
               AV12tCurrentCode = cgiGet( "vTCURRENTCODE");
               A461BR_Behavior_RawSmokingAmount_Code = cgiGet( "BR_BEHAVIOR_RAWSMOKINGAMOUNT_CODE");
               n461BR_Behavior_RawSmokingAmount_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A461BR_Behavior_RawSmokingAmount_Code)) ? true : false);
               A463BR_Behavior_RawAchoholAmount_Code = cgiGet( "BR_BEHAVIOR_RAWACHOHOLAMOUNT_CODE");
               n463BR_Behavior_RawAchoholAmount_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A463BR_Behavior_RawAchoholAmount_Code)) ? true : false);
               A85BR_Information_ID = (long)(context.localUtil.CToN( cgiGet( "BR_INFORMATION_ID"), ".", ","));
               A36BR_Information_PatientNo = cgiGet( "BR_INFORMATION_PATIENTNO");
               n36BR_Information_PatientNo = false;
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
               forbiddenHiddens = "hsh" + "BR_Behavior";
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( AV12tCurrentCode, ""));
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A461BR_Behavior_RawSmokingAmount_Code, ""));
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A463BR_Behavior_RawAchoholAmount_Code, ""));
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( A20BR_BehaviorID != Z20BR_BehaviorID ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
               {
                  GXUtil.WriteLog("br_behavior:[SecurityCheckFailed value for]"+"tCurrentCode:"+StringUtil.RTrim( context.localUtil.Format( AV12tCurrentCode, "")));
                  GXUtil.WriteLog("br_behavior:[SecurityCheckFailed value for]"+"BR_Behavior_RawSmokingAmount_Code:"+StringUtil.RTrim( context.localUtil.Format( A461BR_Behavior_RawSmokingAmount_Code, "")));
                  GXUtil.WriteLog("br_behavior:[SecurityCheckFailed value for]"+"BR_Behavior_RawAchoholAmount_Code:"+StringUtil.RTrim( context.localUtil.Format( A463BR_Behavior_RawAchoholAmount_Code, "")));
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
                  A20BR_BehaviorID = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20BR_BehaviorID", StringUtil.LTrim( StringUtil.Str( (decimal)(A20BR_BehaviorID), 18, 0)));
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
                        if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: Start */
                           E11082 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: After Trn */
                           E12082 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                        {
                           context.wbHandled = 1;
                           btn_enter( ) ;
                           /* No code required for Cancel button. It is implemented as the Reset button. */
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
            /* Execute user event: After Trn */
            E12082 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll089( ) ;
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
            bttBtntrn_delete_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_delete_Enabled), 5, 0)), true);
         }
      }

      protected void disable_std_buttons_dsp( )
      {
         bttBtntrn_delete_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_delete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_delete_Visible), 5, 0)), true);
         bttBtntrn_delete_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_delete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_delete_Visible), 5, 0)), true);
         if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
         {
            bttBtntrn_enter_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_enter_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_enter_Visible), 5, 0)), true);
         }
         DisableAttributes089( ) ;
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

      protected void ResetCaption080( )
      {
      }

      protected void E11082( )
      {
         /* Start Routine */
         GXt_char1 = AV12tCurrentCode;
         new zbr_getcurrenttcode(context ).execute( out  GXt_char1) ;
         AV12tCurrentCode = GXt_char1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12tCurrentCode", AV12tCurrentCode);
      }

      protected void E12082( )
      {
         /* After Trn Routine */
      }

      protected void ZM089( short GX_JID )
      {
         if ( ( GX_JID == 13 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z460BR_Behavior_Smoking_Code = T00083_A460BR_Behavior_Smoking_Code[0];
               Z462BR_Behavior_Achohol_Code = T00083_A462BR_Behavior_Achohol_Code[0];
               Z464BR_Behavior_FamilyCaHistory_Code = T00083_A464BR_Behavior_FamilyCaHistory_Code[0];
               Z465BR_Behavior_Menopause_Code = T00083_A465BR_Behavior_Menopause_Code[0];
               Z21BR_Behavior_Smoking = T00083_A21BR_Behavior_Smoking[0];
               Z22BR_Behavior_SmokingTime = T00083_A22BR_Behavior_SmokingTime[0];
               Z23BR_Behavior_SmokingAmount = T00083_A23BR_Behavior_SmokingAmount[0];
               Z24BR_Behavior_RawSmokingAmount = T00083_A24BR_Behavior_RawSmokingAmount[0];
               Z461BR_Behavior_RawSmokingAmount_Code = T00083_A461BR_Behavior_RawSmokingAmount_Code[0];
               Z25BR_Behavior_Achohol = T00083_A25BR_Behavior_Achohol[0];
               Z26BR_Behavior_AchoholTime = T00083_A26BR_Behavior_AchoholTime[0];
               Z27BR_Behavior_AchoholAmount = T00083_A27BR_Behavior_AchoholAmount[0];
               Z28BR_Behavior_RawAchoholAmount = T00083_A28BR_Behavior_RawAchoholAmount[0];
               Z463BR_Behavior_RawAchoholAmount_Code = T00083_A463BR_Behavior_RawAchoholAmount_Code[0];
               Z29BR_Behavior_FamilyCaHistory = T00083_A29BR_Behavior_FamilyCaHistory[0];
               Z30BR_Behavior_FamilyCancer = T00083_A30BR_Behavior_FamilyCancer[0];
               Z31BR_Behavior_Menopause = T00083_A31BR_Behavior_Menopause[0];
               Z32BR_Behavior_MenopauseAge = T00083_A32BR_Behavior_MenopauseAge[0];
               Z33BR_Behavior_RawMenopauseAge = T00083_A33BR_Behavior_RawMenopauseAge[0];
               Z34BR_Behavior_ChildNum = T00083_A34BR_Behavior_ChildNum[0];
               Z19BR_EncounterID = T00083_A19BR_EncounterID[0];
            }
            else
            {
               Z460BR_Behavior_Smoking_Code = A460BR_Behavior_Smoking_Code;
               Z462BR_Behavior_Achohol_Code = A462BR_Behavior_Achohol_Code;
               Z464BR_Behavior_FamilyCaHistory_Code = A464BR_Behavior_FamilyCaHistory_Code;
               Z465BR_Behavior_Menopause_Code = A465BR_Behavior_Menopause_Code;
               Z21BR_Behavior_Smoking = A21BR_Behavior_Smoking;
               Z22BR_Behavior_SmokingTime = A22BR_Behavior_SmokingTime;
               Z23BR_Behavior_SmokingAmount = A23BR_Behavior_SmokingAmount;
               Z24BR_Behavior_RawSmokingAmount = A24BR_Behavior_RawSmokingAmount;
               Z461BR_Behavior_RawSmokingAmount_Code = A461BR_Behavior_RawSmokingAmount_Code;
               Z25BR_Behavior_Achohol = A25BR_Behavior_Achohol;
               Z26BR_Behavior_AchoholTime = A26BR_Behavior_AchoholTime;
               Z27BR_Behavior_AchoholAmount = A27BR_Behavior_AchoholAmount;
               Z28BR_Behavior_RawAchoholAmount = A28BR_Behavior_RawAchoholAmount;
               Z463BR_Behavior_RawAchoholAmount_Code = A463BR_Behavior_RawAchoholAmount_Code;
               Z29BR_Behavior_FamilyCaHistory = A29BR_Behavior_FamilyCaHistory;
               Z30BR_Behavior_FamilyCancer = A30BR_Behavior_FamilyCancer;
               Z31BR_Behavior_Menopause = A31BR_Behavior_Menopause;
               Z32BR_Behavior_MenopauseAge = A32BR_Behavior_MenopauseAge;
               Z33BR_Behavior_RawMenopauseAge = A33BR_Behavior_RawMenopauseAge;
               Z34BR_Behavior_ChildNum = A34BR_Behavior_ChildNum;
               Z19BR_EncounterID = A19BR_EncounterID;
            }
         }
         if ( GX_JID == -13 )
         {
            Z20BR_BehaviorID = A20BR_BehaviorID;
            Z460BR_Behavior_Smoking_Code = A460BR_Behavior_Smoking_Code;
            Z462BR_Behavior_Achohol_Code = A462BR_Behavior_Achohol_Code;
            Z464BR_Behavior_FamilyCaHistory_Code = A464BR_Behavior_FamilyCaHistory_Code;
            Z465BR_Behavior_Menopause_Code = A465BR_Behavior_Menopause_Code;
            Z21BR_Behavior_Smoking = A21BR_Behavior_Smoking;
            Z22BR_Behavior_SmokingTime = A22BR_Behavior_SmokingTime;
            Z23BR_Behavior_SmokingAmount = A23BR_Behavior_SmokingAmount;
            Z24BR_Behavior_RawSmokingAmount = A24BR_Behavior_RawSmokingAmount;
            Z461BR_Behavior_RawSmokingAmount_Code = A461BR_Behavior_RawSmokingAmount_Code;
            Z25BR_Behavior_Achohol = A25BR_Behavior_Achohol;
            Z26BR_Behavior_AchoholTime = A26BR_Behavior_AchoholTime;
            Z27BR_Behavior_AchoholAmount = A27BR_Behavior_AchoholAmount;
            Z28BR_Behavior_RawAchoholAmount = A28BR_Behavior_RawAchoholAmount;
            Z463BR_Behavior_RawAchoholAmount_Code = A463BR_Behavior_RawAchoholAmount_Code;
            Z29BR_Behavior_FamilyCaHistory = A29BR_Behavior_FamilyCaHistory;
            Z30BR_Behavior_FamilyCancer = A30BR_Behavior_FamilyCancer;
            Z31BR_Behavior_Menopause = A31BR_Behavior_Menopause;
            Z32BR_Behavior_MenopauseAge = A32BR_Behavior_MenopauseAge;
            Z33BR_Behavior_RawMenopauseAge = A33BR_Behavior_RawMenopauseAge;
            Z34BR_Behavior_ChildNum = A34BR_Behavior_ChildNum;
            Z19BR_EncounterID = A19BR_EncounterID;
            Z85BR_Information_ID = A85BR_Information_ID;
            Z36BR_Information_PatientNo = A36BR_Information_PatientNo;
         }
      }

      protected void standaloneNotModal( )
      {
         GXABR_BEHAVIOR_SMOKING_html089( AV12tCurrentCode) ;
         GXABR_BEHAVIOR_ACHOHOL_html089( AV12tCurrentCode) ;
      }

      protected void standaloneModal( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            bttBtntrn_delete_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_delete_Enabled), 5, 0)), true);
         }
         else
         {
            bttBtntrn_delete_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_delete_Enabled), 5, 0)), true);
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
      }

      protected void Load089( )
      {
         /* Using cursor T00086 */
         pr_default.execute(4, new Object[] {A20BR_BehaviorID});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound9 = 1;
            A85BR_Information_ID = T00086_A85BR_Information_ID[0];
            n85BR_Information_ID = T00086_n85BR_Information_ID[0];
            A460BR_Behavior_Smoking_Code = T00086_A460BR_Behavior_Smoking_Code[0];
            n460BR_Behavior_Smoking_Code = T00086_n460BR_Behavior_Smoking_Code[0];
            A462BR_Behavior_Achohol_Code = T00086_A462BR_Behavior_Achohol_Code[0];
            n462BR_Behavior_Achohol_Code = T00086_n462BR_Behavior_Achohol_Code[0];
            A464BR_Behavior_FamilyCaHistory_Code = T00086_A464BR_Behavior_FamilyCaHistory_Code[0];
            n464BR_Behavior_FamilyCaHistory_Code = T00086_n464BR_Behavior_FamilyCaHistory_Code[0];
            A465BR_Behavior_Menopause_Code = T00086_A465BR_Behavior_Menopause_Code[0];
            n465BR_Behavior_Menopause_Code = T00086_n465BR_Behavior_Menopause_Code[0];
            A36BR_Information_PatientNo = T00086_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = T00086_n36BR_Information_PatientNo[0];
            A21BR_Behavior_Smoking = T00086_A21BR_Behavior_Smoking[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A21BR_Behavior_Smoking", A21BR_Behavior_Smoking);
            n21BR_Behavior_Smoking = T00086_n21BR_Behavior_Smoking[0];
            A22BR_Behavior_SmokingTime = T00086_A22BR_Behavior_SmokingTime[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22BR_Behavior_SmokingTime", A22BR_Behavior_SmokingTime);
            n22BR_Behavior_SmokingTime = T00086_n22BR_Behavior_SmokingTime[0];
            A23BR_Behavior_SmokingAmount = T00086_A23BR_Behavior_SmokingAmount[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23BR_Behavior_SmokingAmount", A23BR_Behavior_SmokingAmount);
            n23BR_Behavior_SmokingAmount = T00086_n23BR_Behavior_SmokingAmount[0];
            A24BR_Behavior_RawSmokingAmount = T00086_A24BR_Behavior_RawSmokingAmount[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A24BR_Behavior_RawSmokingAmount", A24BR_Behavior_RawSmokingAmount);
            n24BR_Behavior_RawSmokingAmount = T00086_n24BR_Behavior_RawSmokingAmount[0];
            A461BR_Behavior_RawSmokingAmount_Code = T00086_A461BR_Behavior_RawSmokingAmount_Code[0];
            n461BR_Behavior_RawSmokingAmount_Code = T00086_n461BR_Behavior_RawSmokingAmount_Code[0];
            A25BR_Behavior_Achohol = T00086_A25BR_Behavior_Achohol[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A25BR_Behavior_Achohol", A25BR_Behavior_Achohol);
            n25BR_Behavior_Achohol = T00086_n25BR_Behavior_Achohol[0];
            A26BR_Behavior_AchoholTime = T00086_A26BR_Behavior_AchoholTime[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A26BR_Behavior_AchoholTime", A26BR_Behavior_AchoholTime);
            n26BR_Behavior_AchoholTime = T00086_n26BR_Behavior_AchoholTime[0];
            A27BR_Behavior_AchoholAmount = T00086_A27BR_Behavior_AchoholAmount[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27BR_Behavior_AchoholAmount", A27BR_Behavior_AchoholAmount);
            n27BR_Behavior_AchoholAmount = T00086_n27BR_Behavior_AchoholAmount[0];
            A28BR_Behavior_RawAchoholAmount = T00086_A28BR_Behavior_RawAchoholAmount[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A28BR_Behavior_RawAchoholAmount", A28BR_Behavior_RawAchoholAmount);
            n28BR_Behavior_RawAchoholAmount = T00086_n28BR_Behavior_RawAchoholAmount[0];
            A463BR_Behavior_RawAchoholAmount_Code = T00086_A463BR_Behavior_RawAchoholAmount_Code[0];
            n463BR_Behavior_RawAchoholAmount_Code = T00086_n463BR_Behavior_RawAchoholAmount_Code[0];
            A29BR_Behavior_FamilyCaHistory = T00086_A29BR_Behavior_FamilyCaHistory[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A29BR_Behavior_FamilyCaHistory", A29BR_Behavior_FamilyCaHistory);
            n29BR_Behavior_FamilyCaHistory = T00086_n29BR_Behavior_FamilyCaHistory[0];
            A30BR_Behavior_FamilyCancer = T00086_A30BR_Behavior_FamilyCancer[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A30BR_Behavior_FamilyCancer", A30BR_Behavior_FamilyCancer);
            n30BR_Behavior_FamilyCancer = T00086_n30BR_Behavior_FamilyCancer[0];
            A31BR_Behavior_Menopause = T00086_A31BR_Behavior_Menopause[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A31BR_Behavior_Menopause", A31BR_Behavior_Menopause);
            n31BR_Behavior_Menopause = T00086_n31BR_Behavior_Menopause[0];
            A32BR_Behavior_MenopauseAge = T00086_A32BR_Behavior_MenopauseAge[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32BR_Behavior_MenopauseAge", StringUtil.LTrim( StringUtil.Str( (decimal)(A32BR_Behavior_MenopauseAge), 4, 0)));
            n32BR_Behavior_MenopauseAge = T00086_n32BR_Behavior_MenopauseAge[0];
            A33BR_Behavior_RawMenopauseAge = T00086_A33BR_Behavior_RawMenopauseAge[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33BR_Behavior_RawMenopauseAge", A33BR_Behavior_RawMenopauseAge);
            n33BR_Behavior_RawMenopauseAge = T00086_n33BR_Behavior_RawMenopauseAge[0];
            A34BR_Behavior_ChildNum = T00086_A34BR_Behavior_ChildNum[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34BR_Behavior_ChildNum", A34BR_Behavior_ChildNum);
            n34BR_Behavior_ChildNum = T00086_n34BR_Behavior_ChildNum[0];
            A19BR_EncounterID = T00086_A19BR_EncounterID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
            ZM089( -13) ;
         }
         pr_default.close(4);
         OnLoadActions089( ) ;
      }

      protected void OnLoadActions089( )
      {
      }

      protected void CheckExtendedTable089( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
         /* Using cursor T00084 */
         pr_default.execute(2, new Object[] {A19BR_EncounterID});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("不匹配' T15'", "ForeignKeyNotFound", 1, "BR_ENCOUNTERID");
            AnyError = 1;
            GX_FocusControl = edtBR_EncounterID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A85BR_Information_ID = T00084_A85BR_Information_ID[0];
         n85BR_Information_ID = T00084_n85BR_Information_ID[0];
         pr_default.close(2);
         /* Using cursor T00085 */
         pr_default.execute(3, new Object[] {n85BR_Information_ID, A85BR_Information_ID});
         if ( (pr_default.getStatus(3) == 101) )
         {
            if ( ! ( (0==A85BR_Information_ID) ) )
            {
               GX_msglist.addItem("不匹配' T16'", "ForeignKeyNotFound", 1, "");
               AnyError = 1;
            }
         }
         A36BR_Information_PatientNo = T00085_A36BR_Information_PatientNo[0];
         n36BR_Information_PatientNo = T00085_n36BR_Information_PatientNo[0];
         pr_default.close(3);
         if ( ! ( ( StringUtil.StrCmp(A29BR_Behavior_FamilyCaHistory, "否") == 0 ) || ( StringUtil.StrCmp(A29BR_Behavior_FamilyCaHistory, "是") == 0 ) || ( StringUtil.StrCmp(A29BR_Behavior_FamilyCaHistory, "不详") == 0 ) || String.IsNullOrEmpty(StringUtil.RTrim( A29BR_Behavior_FamilyCaHistory)) ) )
         {
            GX_msglist.addItem("域������������������������超界", "OutOfRange", 1, "BR_BEHAVIOR_FAMILYCAHISTORY");
            AnyError = 1;
            GX_FocusControl = cmbBR_Behavior_FamilyCaHistory_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ! ( ( StringUtil.StrCmp(A31BR_Behavior_Menopause, "否") == 0 ) || ( StringUtil.StrCmp(A31BR_Behavior_Menopause, "是") == 0 ) || ( StringUtil.StrCmp(A31BR_Behavior_Menopause, "不详") == 0 ) || String.IsNullOrEmpty(StringUtil.RTrim( A31BR_Behavior_Menopause)) ) )
         {
            GX_msglist.addItem("域������������超界", "OutOfRange", 1, "BR_BEHAVIOR_MENOPAUSE");
            AnyError = 1;
            GX_FocusControl = cmbBR_Behavior_Menopause_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
      }

      protected void CloseExtendedTableCursors089( )
      {
         pr_default.close(2);
         pr_default.close(3);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_14( long A19BR_EncounterID )
      {
         /* Using cursor T00087 */
         pr_default.execute(5, new Object[] {A19BR_EncounterID});
         if ( (pr_default.getStatus(5) == 101) )
         {
            GX_msglist.addItem("不匹配' T15'", "ForeignKeyNotFound", 1, "BR_ENCOUNTERID");
            AnyError = 1;
            GX_FocusControl = edtBR_EncounterID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A85BR_Information_ID = T00087_A85BR_Information_ID[0];
         n85BR_Information_ID = T00087_n85BR_Information_ID[0];
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A85BR_Information_ID), 18, 0, ".", "")))+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(5) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(5);
      }

      protected void gxLoad_15( long A85BR_Information_ID )
      {
         /* Using cursor T00088 */
         pr_default.execute(6, new Object[] {n85BR_Information_ID, A85BR_Information_ID});
         if ( (pr_default.getStatus(6) == 101) )
         {
            if ( ! ( (0==A85BR_Information_ID) ) )
            {
               GX_msglist.addItem("不匹配' T16'", "ForeignKeyNotFound", 1, "");
               AnyError = 1;
            }
         }
         A36BR_Information_PatientNo = T00088_A36BR_Information_PatientNo[0];
         n36BR_Information_PatientNo = T00088_n36BR_Information_PatientNo[0];
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A36BR_Information_PatientNo)+"\"");
         context.GX_webresponse.AddString("]");
         if ( (pr_default.getStatus(6) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
         pr_default.close(6);
      }

      protected void GetKey089( )
      {
         /* Using cursor T00089 */
         pr_default.execute(7, new Object[] {A20BR_BehaviorID});
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound9 = 1;
         }
         else
         {
            RcdFound9 = 0;
         }
         pr_default.close(7);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00083 */
         pr_default.execute(1, new Object[] {A20BR_BehaviorID});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM089( 13) ;
            RcdFound9 = 1;
            A20BR_BehaviorID = T00083_A20BR_BehaviorID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20BR_BehaviorID", StringUtil.LTrim( StringUtil.Str( (decimal)(A20BR_BehaviorID), 18, 0)));
            A460BR_Behavior_Smoking_Code = T00083_A460BR_Behavior_Smoking_Code[0];
            n460BR_Behavior_Smoking_Code = T00083_n460BR_Behavior_Smoking_Code[0];
            A462BR_Behavior_Achohol_Code = T00083_A462BR_Behavior_Achohol_Code[0];
            n462BR_Behavior_Achohol_Code = T00083_n462BR_Behavior_Achohol_Code[0];
            A464BR_Behavior_FamilyCaHistory_Code = T00083_A464BR_Behavior_FamilyCaHistory_Code[0];
            n464BR_Behavior_FamilyCaHistory_Code = T00083_n464BR_Behavior_FamilyCaHistory_Code[0];
            A465BR_Behavior_Menopause_Code = T00083_A465BR_Behavior_Menopause_Code[0];
            n465BR_Behavior_Menopause_Code = T00083_n465BR_Behavior_Menopause_Code[0];
            A21BR_Behavior_Smoking = T00083_A21BR_Behavior_Smoking[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A21BR_Behavior_Smoking", A21BR_Behavior_Smoking);
            n21BR_Behavior_Smoking = T00083_n21BR_Behavior_Smoking[0];
            A22BR_Behavior_SmokingTime = T00083_A22BR_Behavior_SmokingTime[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22BR_Behavior_SmokingTime", A22BR_Behavior_SmokingTime);
            n22BR_Behavior_SmokingTime = T00083_n22BR_Behavior_SmokingTime[0];
            A23BR_Behavior_SmokingAmount = T00083_A23BR_Behavior_SmokingAmount[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23BR_Behavior_SmokingAmount", A23BR_Behavior_SmokingAmount);
            n23BR_Behavior_SmokingAmount = T00083_n23BR_Behavior_SmokingAmount[0];
            A24BR_Behavior_RawSmokingAmount = T00083_A24BR_Behavior_RawSmokingAmount[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A24BR_Behavior_RawSmokingAmount", A24BR_Behavior_RawSmokingAmount);
            n24BR_Behavior_RawSmokingAmount = T00083_n24BR_Behavior_RawSmokingAmount[0];
            A461BR_Behavior_RawSmokingAmount_Code = T00083_A461BR_Behavior_RawSmokingAmount_Code[0];
            n461BR_Behavior_RawSmokingAmount_Code = T00083_n461BR_Behavior_RawSmokingAmount_Code[0];
            A25BR_Behavior_Achohol = T00083_A25BR_Behavior_Achohol[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A25BR_Behavior_Achohol", A25BR_Behavior_Achohol);
            n25BR_Behavior_Achohol = T00083_n25BR_Behavior_Achohol[0];
            A26BR_Behavior_AchoholTime = T00083_A26BR_Behavior_AchoholTime[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A26BR_Behavior_AchoholTime", A26BR_Behavior_AchoholTime);
            n26BR_Behavior_AchoholTime = T00083_n26BR_Behavior_AchoholTime[0];
            A27BR_Behavior_AchoholAmount = T00083_A27BR_Behavior_AchoholAmount[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27BR_Behavior_AchoholAmount", A27BR_Behavior_AchoholAmount);
            n27BR_Behavior_AchoholAmount = T00083_n27BR_Behavior_AchoholAmount[0];
            A28BR_Behavior_RawAchoholAmount = T00083_A28BR_Behavior_RawAchoholAmount[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A28BR_Behavior_RawAchoholAmount", A28BR_Behavior_RawAchoholAmount);
            n28BR_Behavior_RawAchoholAmount = T00083_n28BR_Behavior_RawAchoholAmount[0];
            A463BR_Behavior_RawAchoholAmount_Code = T00083_A463BR_Behavior_RawAchoholAmount_Code[0];
            n463BR_Behavior_RawAchoholAmount_Code = T00083_n463BR_Behavior_RawAchoholAmount_Code[0];
            A29BR_Behavior_FamilyCaHistory = T00083_A29BR_Behavior_FamilyCaHistory[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A29BR_Behavior_FamilyCaHistory", A29BR_Behavior_FamilyCaHistory);
            n29BR_Behavior_FamilyCaHistory = T00083_n29BR_Behavior_FamilyCaHistory[0];
            A30BR_Behavior_FamilyCancer = T00083_A30BR_Behavior_FamilyCancer[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A30BR_Behavior_FamilyCancer", A30BR_Behavior_FamilyCancer);
            n30BR_Behavior_FamilyCancer = T00083_n30BR_Behavior_FamilyCancer[0];
            A31BR_Behavior_Menopause = T00083_A31BR_Behavior_Menopause[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A31BR_Behavior_Menopause", A31BR_Behavior_Menopause);
            n31BR_Behavior_Menopause = T00083_n31BR_Behavior_Menopause[0];
            A32BR_Behavior_MenopauseAge = T00083_A32BR_Behavior_MenopauseAge[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32BR_Behavior_MenopauseAge", StringUtil.LTrim( StringUtil.Str( (decimal)(A32BR_Behavior_MenopauseAge), 4, 0)));
            n32BR_Behavior_MenopauseAge = T00083_n32BR_Behavior_MenopauseAge[0];
            A33BR_Behavior_RawMenopauseAge = T00083_A33BR_Behavior_RawMenopauseAge[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33BR_Behavior_RawMenopauseAge", A33BR_Behavior_RawMenopauseAge);
            n33BR_Behavior_RawMenopauseAge = T00083_n33BR_Behavior_RawMenopauseAge[0];
            A34BR_Behavior_ChildNum = T00083_A34BR_Behavior_ChildNum[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34BR_Behavior_ChildNum", A34BR_Behavior_ChildNum);
            n34BR_Behavior_ChildNum = T00083_n34BR_Behavior_ChildNum[0];
            A19BR_EncounterID = T00083_A19BR_EncounterID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
            Z20BR_BehaviorID = A20BR_BehaviorID;
            sMode9 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load089( ) ;
            if ( AnyError == 1 )
            {
               RcdFound9 = 0;
               InitializeNonKey089( ) ;
            }
            Gx_mode = sMode9;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound9 = 0;
            InitializeNonKey089( ) ;
            sMode9 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode9;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey089( ) ;
         if ( RcdFound9 == 0 )
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
         RcdFound9 = 0;
         /* Using cursor T000810 */
         pr_default.execute(8, new Object[] {A20BR_BehaviorID});
         if ( (pr_default.getStatus(8) != 101) )
         {
            while ( (pr_default.getStatus(8) != 101) && ( ( T000810_A20BR_BehaviorID[0] < A20BR_BehaviorID ) ) )
            {
               pr_default.readNext(8);
            }
            if ( (pr_default.getStatus(8) != 101) && ( ( T000810_A20BR_BehaviorID[0] > A20BR_BehaviorID ) ) )
            {
               A20BR_BehaviorID = T000810_A20BR_BehaviorID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20BR_BehaviorID", StringUtil.LTrim( StringUtil.Str( (decimal)(A20BR_BehaviorID), 18, 0)));
               RcdFound9 = 1;
            }
         }
         pr_default.close(8);
      }

      protected void move_previous( )
      {
         RcdFound9 = 0;
         /* Using cursor T000811 */
         pr_default.execute(9, new Object[] {A20BR_BehaviorID});
         if ( (pr_default.getStatus(9) != 101) )
         {
            while ( (pr_default.getStatus(9) != 101) && ( ( T000811_A20BR_BehaviorID[0] > A20BR_BehaviorID ) ) )
            {
               pr_default.readNext(9);
            }
            if ( (pr_default.getStatus(9) != 101) && ( ( T000811_A20BR_BehaviorID[0] < A20BR_BehaviorID ) ) )
            {
               A20BR_BehaviorID = T000811_A20BR_BehaviorID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20BR_BehaviorID", StringUtil.LTrim( StringUtil.Str( (decimal)(A20BR_BehaviorID), 18, 0)));
               RcdFound9 = 1;
            }
         }
         pr_default.close(9);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey089( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtBR_EncounterID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert089( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound9 == 1 )
            {
               if ( A20BR_BehaviorID != Z20BR_BehaviorID )
               {
                  A20BR_BehaviorID = Z20BR_BehaviorID;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20BR_BehaviorID", StringUtil.LTrim( StringUtil.Str( (decimal)(A20BR_BehaviorID), 18, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "BR_BEHAVIORID");
                  AnyError = 1;
                  GX_FocusControl = edtBR_BehaviorID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtBR_EncounterID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  Gx_mode = "UPD";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Update record */
                  Update089( ) ;
                  GX_FocusControl = edtBR_EncounterID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A20BR_BehaviorID != Z20BR_BehaviorID )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Insert record */
                  GX_FocusControl = edtBR_EncounterID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert089( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "BR_BEHAVIORID");
                     AnyError = 1;
                     GX_FocusControl = edtBR_BehaviorID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     Gx_mode = "INS";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     /* Insert record */
                     GX_FocusControl = edtBR_EncounterID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert089( ) ;
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
         if ( A20BR_BehaviorID != Z20BR_BehaviorID )
         {
            A20BR_BehaviorID = Z20BR_BehaviorID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20BR_BehaviorID", StringUtil.LTrim( StringUtil.Str( (decimal)(A20BR_BehaviorID), 18, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "BR_BEHAVIORID");
            AnyError = 1;
            GX_FocusControl = edtBR_BehaviorID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtBR_EncounterID_Internalname;
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
         if ( RcdFound9 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "BR_BEHAVIORID");
            AnyError = 1;
            GX_FocusControl = edtBR_BehaviorID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         GX_FocusControl = edtBR_EncounterID_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2;
         IsConfirmed = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         ScanStart089( ) ;
         if ( RcdFound9 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtBR_EncounterID_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd089( ) ;
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
         if ( RcdFound9 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtBR_EncounterID_Internalname;
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
         if ( RcdFound9 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtBR_EncounterID_Internalname;
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
         ScanStart089( ) ;
         if ( RcdFound9 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            while ( RcdFound9 != 0 )
            {
               ScanNext089( ) ;
            }
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtBR_EncounterID_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd089( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency089( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00082 */
            pr_default.execute(0, new Object[] {A20BR_BehaviorID});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BR_Behavior"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z460BR_Behavior_Smoking_Code, T00082_A460BR_Behavior_Smoking_Code[0]) != 0 ) || ( StringUtil.StrCmp(Z462BR_Behavior_Achohol_Code, T00082_A462BR_Behavior_Achohol_Code[0]) != 0 ) || ( StringUtil.StrCmp(Z464BR_Behavior_FamilyCaHistory_Code, T00082_A464BR_Behavior_FamilyCaHistory_Code[0]) != 0 ) || ( StringUtil.StrCmp(Z465BR_Behavior_Menopause_Code, T00082_A465BR_Behavior_Menopause_Code[0]) != 0 ) || ( StringUtil.StrCmp(Z21BR_Behavior_Smoking, T00082_A21BR_Behavior_Smoking[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z22BR_Behavior_SmokingTime, T00082_A22BR_Behavior_SmokingTime[0]) != 0 ) || ( StringUtil.StrCmp(Z23BR_Behavior_SmokingAmount, T00082_A23BR_Behavior_SmokingAmount[0]) != 0 ) || ( StringUtil.StrCmp(Z24BR_Behavior_RawSmokingAmount, T00082_A24BR_Behavior_RawSmokingAmount[0]) != 0 ) || ( StringUtil.StrCmp(Z461BR_Behavior_RawSmokingAmount_Code, T00082_A461BR_Behavior_RawSmokingAmount_Code[0]) != 0 ) || ( StringUtil.StrCmp(Z25BR_Behavior_Achohol, T00082_A25BR_Behavior_Achohol[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z26BR_Behavior_AchoholTime, T00082_A26BR_Behavior_AchoholTime[0]) != 0 ) || ( StringUtil.StrCmp(Z27BR_Behavior_AchoholAmount, T00082_A27BR_Behavior_AchoholAmount[0]) != 0 ) || ( StringUtil.StrCmp(Z28BR_Behavior_RawAchoholAmount, T00082_A28BR_Behavior_RawAchoholAmount[0]) != 0 ) || ( StringUtil.StrCmp(Z463BR_Behavior_RawAchoholAmount_Code, T00082_A463BR_Behavior_RawAchoholAmount_Code[0]) != 0 ) || ( StringUtil.StrCmp(Z29BR_Behavior_FamilyCaHistory, T00082_A29BR_Behavior_FamilyCaHistory[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z30BR_Behavior_FamilyCancer, T00082_A30BR_Behavior_FamilyCancer[0]) != 0 ) || ( StringUtil.StrCmp(Z31BR_Behavior_Menopause, T00082_A31BR_Behavior_Menopause[0]) != 0 ) || ( Z32BR_Behavior_MenopauseAge != T00082_A32BR_Behavior_MenopauseAge[0] ) || ( StringUtil.StrCmp(Z33BR_Behavior_RawMenopauseAge, T00082_A33BR_Behavior_RawMenopauseAge[0]) != 0 ) || ( StringUtil.StrCmp(Z34BR_Behavior_ChildNum, T00082_A34BR_Behavior_ChildNum[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( Z19BR_EncounterID != T00082_A19BR_EncounterID[0] ) )
            {
               if ( StringUtil.StrCmp(Z460BR_Behavior_Smoking_Code, T00082_A460BR_Behavior_Smoking_Code[0]) != 0 )
               {
                  GXUtil.WriteLog("br_behavior:[seudo value changed for attri]"+"BR_Behavior_Smoking_Code");
                  GXUtil.WriteLogRaw("Old: ",Z460BR_Behavior_Smoking_Code);
                  GXUtil.WriteLogRaw("Current: ",T00082_A460BR_Behavior_Smoking_Code[0]);
               }
               if ( StringUtil.StrCmp(Z462BR_Behavior_Achohol_Code, T00082_A462BR_Behavior_Achohol_Code[0]) != 0 )
               {
                  GXUtil.WriteLog("br_behavior:[seudo value changed for attri]"+"BR_Behavior_Achohol_Code");
                  GXUtil.WriteLogRaw("Old: ",Z462BR_Behavior_Achohol_Code);
                  GXUtil.WriteLogRaw("Current: ",T00082_A462BR_Behavior_Achohol_Code[0]);
               }
               if ( StringUtil.StrCmp(Z464BR_Behavior_FamilyCaHistory_Code, T00082_A464BR_Behavior_FamilyCaHistory_Code[0]) != 0 )
               {
                  GXUtil.WriteLog("br_behavior:[seudo value changed for attri]"+"BR_Behavior_FamilyCaHistory_Code");
                  GXUtil.WriteLogRaw("Old: ",Z464BR_Behavior_FamilyCaHistory_Code);
                  GXUtil.WriteLogRaw("Current: ",T00082_A464BR_Behavior_FamilyCaHistory_Code[0]);
               }
               if ( StringUtil.StrCmp(Z465BR_Behavior_Menopause_Code, T00082_A465BR_Behavior_Menopause_Code[0]) != 0 )
               {
                  GXUtil.WriteLog("br_behavior:[seudo value changed for attri]"+"BR_Behavior_Menopause_Code");
                  GXUtil.WriteLogRaw("Old: ",Z465BR_Behavior_Menopause_Code);
                  GXUtil.WriteLogRaw("Current: ",T00082_A465BR_Behavior_Menopause_Code[0]);
               }
               if ( StringUtil.StrCmp(Z21BR_Behavior_Smoking, T00082_A21BR_Behavior_Smoking[0]) != 0 )
               {
                  GXUtil.WriteLog("br_behavior:[seudo value changed for attri]"+"BR_Behavior_Smoking");
                  GXUtil.WriteLogRaw("Old: ",Z21BR_Behavior_Smoking);
                  GXUtil.WriteLogRaw("Current: ",T00082_A21BR_Behavior_Smoking[0]);
               }
               if ( StringUtil.StrCmp(Z22BR_Behavior_SmokingTime, T00082_A22BR_Behavior_SmokingTime[0]) != 0 )
               {
                  GXUtil.WriteLog("br_behavior:[seudo value changed for attri]"+"BR_Behavior_SmokingTime");
                  GXUtil.WriteLogRaw("Old: ",Z22BR_Behavior_SmokingTime);
                  GXUtil.WriteLogRaw("Current: ",T00082_A22BR_Behavior_SmokingTime[0]);
               }
               if ( StringUtil.StrCmp(Z23BR_Behavior_SmokingAmount, T00082_A23BR_Behavior_SmokingAmount[0]) != 0 )
               {
                  GXUtil.WriteLog("br_behavior:[seudo value changed for attri]"+"BR_Behavior_SmokingAmount");
                  GXUtil.WriteLogRaw("Old: ",Z23BR_Behavior_SmokingAmount);
                  GXUtil.WriteLogRaw("Current: ",T00082_A23BR_Behavior_SmokingAmount[0]);
               }
               if ( StringUtil.StrCmp(Z24BR_Behavior_RawSmokingAmount, T00082_A24BR_Behavior_RawSmokingAmount[0]) != 0 )
               {
                  GXUtil.WriteLog("br_behavior:[seudo value changed for attri]"+"BR_Behavior_RawSmokingAmount");
                  GXUtil.WriteLogRaw("Old: ",Z24BR_Behavior_RawSmokingAmount);
                  GXUtil.WriteLogRaw("Current: ",T00082_A24BR_Behavior_RawSmokingAmount[0]);
               }
               if ( StringUtil.StrCmp(Z461BR_Behavior_RawSmokingAmount_Code, T00082_A461BR_Behavior_RawSmokingAmount_Code[0]) != 0 )
               {
                  GXUtil.WriteLog("br_behavior:[seudo value changed for attri]"+"BR_Behavior_RawSmokingAmount_Code");
                  GXUtil.WriteLogRaw("Old: ",Z461BR_Behavior_RawSmokingAmount_Code);
                  GXUtil.WriteLogRaw("Current: ",T00082_A461BR_Behavior_RawSmokingAmount_Code[0]);
               }
               if ( StringUtil.StrCmp(Z25BR_Behavior_Achohol, T00082_A25BR_Behavior_Achohol[0]) != 0 )
               {
                  GXUtil.WriteLog("br_behavior:[seudo value changed for attri]"+"BR_Behavior_Achohol");
                  GXUtil.WriteLogRaw("Old: ",Z25BR_Behavior_Achohol);
                  GXUtil.WriteLogRaw("Current: ",T00082_A25BR_Behavior_Achohol[0]);
               }
               if ( StringUtil.StrCmp(Z26BR_Behavior_AchoholTime, T00082_A26BR_Behavior_AchoholTime[0]) != 0 )
               {
                  GXUtil.WriteLog("br_behavior:[seudo value changed for attri]"+"BR_Behavior_AchoholTime");
                  GXUtil.WriteLogRaw("Old: ",Z26BR_Behavior_AchoholTime);
                  GXUtil.WriteLogRaw("Current: ",T00082_A26BR_Behavior_AchoholTime[0]);
               }
               if ( StringUtil.StrCmp(Z27BR_Behavior_AchoholAmount, T00082_A27BR_Behavior_AchoholAmount[0]) != 0 )
               {
                  GXUtil.WriteLog("br_behavior:[seudo value changed for attri]"+"BR_Behavior_AchoholAmount");
                  GXUtil.WriteLogRaw("Old: ",Z27BR_Behavior_AchoholAmount);
                  GXUtil.WriteLogRaw("Current: ",T00082_A27BR_Behavior_AchoholAmount[0]);
               }
               if ( StringUtil.StrCmp(Z28BR_Behavior_RawAchoholAmount, T00082_A28BR_Behavior_RawAchoholAmount[0]) != 0 )
               {
                  GXUtil.WriteLog("br_behavior:[seudo value changed for attri]"+"BR_Behavior_RawAchoholAmount");
                  GXUtil.WriteLogRaw("Old: ",Z28BR_Behavior_RawAchoholAmount);
                  GXUtil.WriteLogRaw("Current: ",T00082_A28BR_Behavior_RawAchoholAmount[0]);
               }
               if ( StringUtil.StrCmp(Z463BR_Behavior_RawAchoholAmount_Code, T00082_A463BR_Behavior_RawAchoholAmount_Code[0]) != 0 )
               {
                  GXUtil.WriteLog("br_behavior:[seudo value changed for attri]"+"BR_Behavior_RawAchoholAmount_Code");
                  GXUtil.WriteLogRaw("Old: ",Z463BR_Behavior_RawAchoholAmount_Code);
                  GXUtil.WriteLogRaw("Current: ",T00082_A463BR_Behavior_RawAchoholAmount_Code[0]);
               }
               if ( StringUtil.StrCmp(Z29BR_Behavior_FamilyCaHistory, T00082_A29BR_Behavior_FamilyCaHistory[0]) != 0 )
               {
                  GXUtil.WriteLog("br_behavior:[seudo value changed for attri]"+"BR_Behavior_FamilyCaHistory");
                  GXUtil.WriteLogRaw("Old: ",Z29BR_Behavior_FamilyCaHistory);
                  GXUtil.WriteLogRaw("Current: ",T00082_A29BR_Behavior_FamilyCaHistory[0]);
               }
               if ( StringUtil.StrCmp(Z30BR_Behavior_FamilyCancer, T00082_A30BR_Behavior_FamilyCancer[0]) != 0 )
               {
                  GXUtil.WriteLog("br_behavior:[seudo value changed for attri]"+"BR_Behavior_FamilyCancer");
                  GXUtil.WriteLogRaw("Old: ",Z30BR_Behavior_FamilyCancer);
                  GXUtil.WriteLogRaw("Current: ",T00082_A30BR_Behavior_FamilyCancer[0]);
               }
               if ( StringUtil.StrCmp(Z31BR_Behavior_Menopause, T00082_A31BR_Behavior_Menopause[0]) != 0 )
               {
                  GXUtil.WriteLog("br_behavior:[seudo value changed for attri]"+"BR_Behavior_Menopause");
                  GXUtil.WriteLogRaw("Old: ",Z31BR_Behavior_Menopause);
                  GXUtil.WriteLogRaw("Current: ",T00082_A31BR_Behavior_Menopause[0]);
               }
               if ( Z32BR_Behavior_MenopauseAge != T00082_A32BR_Behavior_MenopauseAge[0] )
               {
                  GXUtil.WriteLog("br_behavior:[seudo value changed for attri]"+"BR_Behavior_MenopauseAge");
                  GXUtil.WriteLogRaw("Old: ",Z32BR_Behavior_MenopauseAge);
                  GXUtil.WriteLogRaw("Current: ",T00082_A32BR_Behavior_MenopauseAge[0]);
               }
               if ( StringUtil.StrCmp(Z33BR_Behavior_RawMenopauseAge, T00082_A33BR_Behavior_RawMenopauseAge[0]) != 0 )
               {
                  GXUtil.WriteLog("br_behavior:[seudo value changed for attri]"+"BR_Behavior_RawMenopauseAge");
                  GXUtil.WriteLogRaw("Old: ",Z33BR_Behavior_RawMenopauseAge);
                  GXUtil.WriteLogRaw("Current: ",T00082_A33BR_Behavior_RawMenopauseAge[0]);
               }
               if ( StringUtil.StrCmp(Z34BR_Behavior_ChildNum, T00082_A34BR_Behavior_ChildNum[0]) != 0 )
               {
                  GXUtil.WriteLog("br_behavior:[seudo value changed for attri]"+"BR_Behavior_ChildNum");
                  GXUtil.WriteLogRaw("Old: ",Z34BR_Behavior_ChildNum);
                  GXUtil.WriteLogRaw("Current: ",T00082_A34BR_Behavior_ChildNum[0]);
               }
               if ( Z19BR_EncounterID != T00082_A19BR_EncounterID[0] )
               {
                  GXUtil.WriteLog("br_behavior:[seudo value changed for attri]"+"BR_EncounterID");
                  GXUtil.WriteLogRaw("Old: ",Z19BR_EncounterID);
                  GXUtil.WriteLogRaw("Current: ",T00082_A19BR_EncounterID[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"BR_Behavior"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert089( )
      {
         BeforeValidate089( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable089( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM089( 0) ;
            CheckOptimisticConcurrency089( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm089( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert089( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000812 */
                     pr_default.execute(10, new Object[] {n460BR_Behavior_Smoking_Code, A460BR_Behavior_Smoking_Code, n462BR_Behavior_Achohol_Code, A462BR_Behavior_Achohol_Code, n464BR_Behavior_FamilyCaHistory_Code, A464BR_Behavior_FamilyCaHistory_Code, n465BR_Behavior_Menopause_Code, A465BR_Behavior_Menopause_Code, n21BR_Behavior_Smoking, A21BR_Behavior_Smoking, n22BR_Behavior_SmokingTime, A22BR_Behavior_SmokingTime, n23BR_Behavior_SmokingAmount, A23BR_Behavior_SmokingAmount, n24BR_Behavior_RawSmokingAmount, A24BR_Behavior_RawSmokingAmount, n461BR_Behavior_RawSmokingAmount_Code, A461BR_Behavior_RawSmokingAmount_Code, n25BR_Behavior_Achohol, A25BR_Behavior_Achohol, n26BR_Behavior_AchoholTime, A26BR_Behavior_AchoholTime, n27BR_Behavior_AchoholAmount, A27BR_Behavior_AchoholAmount, n28BR_Behavior_RawAchoholAmount, A28BR_Behavior_RawAchoholAmount, n463BR_Behavior_RawAchoholAmount_Code, A463BR_Behavior_RawAchoholAmount_Code, n29BR_Behavior_FamilyCaHistory, A29BR_Behavior_FamilyCaHistory, n30BR_Behavior_FamilyCancer, A30BR_Behavior_FamilyCancer, n31BR_Behavior_Menopause, A31BR_Behavior_Menopause, n32BR_Behavior_MenopauseAge, A32BR_Behavior_MenopauseAge, n33BR_Behavior_RawMenopauseAge, A33BR_Behavior_RawMenopauseAge, n34BR_Behavior_ChildNum, A34BR_Behavior_ChildNum, A19BR_EncounterID});
                     A20BR_BehaviorID = T000812_A20BR_BehaviorID[0];
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20BR_BehaviorID", StringUtil.LTrim( StringUtil.Str( (decimal)(A20BR_BehaviorID), 18, 0)));
                     pr_default.close(10);
                     dsDefault.SmartCacheProvider.SetUpdated("BR_Behavior") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                           ResetCaption080( ) ;
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
               Load089( ) ;
            }
            EndLevel089( ) ;
         }
         CloseExtendedTableCursors089( ) ;
      }

      protected void Update089( )
      {
         BeforeValidate089( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable089( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency089( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm089( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate089( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000813 */
                     pr_default.execute(11, new Object[] {n460BR_Behavior_Smoking_Code, A460BR_Behavior_Smoking_Code, n462BR_Behavior_Achohol_Code, A462BR_Behavior_Achohol_Code, n464BR_Behavior_FamilyCaHistory_Code, A464BR_Behavior_FamilyCaHistory_Code, n465BR_Behavior_Menopause_Code, A465BR_Behavior_Menopause_Code, n21BR_Behavior_Smoking, A21BR_Behavior_Smoking, n22BR_Behavior_SmokingTime, A22BR_Behavior_SmokingTime, n23BR_Behavior_SmokingAmount, A23BR_Behavior_SmokingAmount, n24BR_Behavior_RawSmokingAmount, A24BR_Behavior_RawSmokingAmount, n461BR_Behavior_RawSmokingAmount_Code, A461BR_Behavior_RawSmokingAmount_Code, n25BR_Behavior_Achohol, A25BR_Behavior_Achohol, n26BR_Behavior_AchoholTime, A26BR_Behavior_AchoholTime, n27BR_Behavior_AchoholAmount, A27BR_Behavior_AchoholAmount, n28BR_Behavior_RawAchoholAmount, A28BR_Behavior_RawAchoholAmount, n463BR_Behavior_RawAchoholAmount_Code, A463BR_Behavior_RawAchoholAmount_Code, n29BR_Behavior_FamilyCaHistory, A29BR_Behavior_FamilyCaHistory, n30BR_Behavior_FamilyCancer, A30BR_Behavior_FamilyCancer, n31BR_Behavior_Menopause, A31BR_Behavior_Menopause, n32BR_Behavior_MenopauseAge, A32BR_Behavior_MenopauseAge, n33BR_Behavior_RawMenopauseAge, A33BR_Behavior_RawMenopauseAge, n34BR_Behavior_ChildNum, A34BR_Behavior_ChildNum, A19BR_EncounterID, A20BR_BehaviorID});
                     pr_default.close(11);
                     dsDefault.SmartCacheProvider.SetUpdated("BR_Behavior") ;
                     if ( (pr_default.getStatus(11) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BR_Behavior"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate089( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), "SuccessfullyUpdated", 0, "", true);
                           ResetCaption080( ) ;
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
            EndLevel089( ) ;
         }
         CloseExtendedTableCursors089( ) ;
      }

      protected void DeferredUpdate089( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate089( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency089( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls089( ) ;
            AfterConfirm089( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete089( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000814 */
                  pr_default.execute(12, new Object[] {A20BR_BehaviorID});
                  pr_default.close(12);
                  dsDefault.SmartCacheProvider.SetUpdated("BR_Behavior") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        move_next( ) ;
                        if ( RcdFound9 == 0 )
                        {
                           InitAll089( ) ;
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
                        ResetCaption080( ) ;
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
         sMode9 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel089( ) ;
         Gx_mode = sMode9;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls089( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            /* Using cursor T000815 */
            pr_default.execute(13, new Object[] {A19BR_EncounterID});
            A85BR_Information_ID = T000815_A85BR_Information_ID[0];
            n85BR_Information_ID = T000815_n85BR_Information_ID[0];
            pr_default.close(13);
            /* Using cursor T000816 */
            pr_default.execute(14, new Object[] {n85BR_Information_ID, A85BR_Information_ID});
            A36BR_Information_PatientNo = T000816_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = T000816_n36BR_Information_PatientNo[0];
            pr_default.close(14);
         }
      }

      protected void EndLevel089( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete089( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(1);
            pr_default.close(13);
            pr_default.close(14);
            context.CommitDataStores("br_behavior",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues080( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(1);
            pr_default.close(13);
            pr_default.close(14);
            context.RollbackDataStores("br_behavior",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart089( )
      {
         /* Scan By routine */
         /* Using cursor T000817 */
         pr_default.execute(15);
         RcdFound9 = 0;
         if ( (pr_default.getStatus(15) != 101) )
         {
            RcdFound9 = 1;
            A20BR_BehaviorID = T000817_A20BR_BehaviorID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20BR_BehaviorID", StringUtil.LTrim( StringUtil.Str( (decimal)(A20BR_BehaviorID), 18, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext089( )
      {
         /* Scan next routine */
         pr_default.readNext(15);
         RcdFound9 = 0;
         if ( (pr_default.getStatus(15) != 101) )
         {
            RcdFound9 = 1;
            A20BR_BehaviorID = T000817_A20BR_BehaviorID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20BR_BehaviorID", StringUtil.LTrim( StringUtil.Str( (decimal)(A20BR_BehaviorID), 18, 0)));
         }
      }

      protected void ScanEnd089( )
      {
         pr_default.close(15);
      }

      protected void AfterConfirm089( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert089( )
      {
         /* Before Insert Rules */
         GXt_char1 = A460BR_Behavior_Smoking_Code;
         new zutil_findtargetcode(context ).execute(  12,  A21BR_Behavior_Smoking, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A21BR_Behavior_Smoking", A21BR_Behavior_Smoking);
         A460BR_Behavior_Smoking_Code = GXt_char1;
         n460BR_Behavior_Smoking_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A460BR_Behavior_Smoking_Code", A460BR_Behavior_Smoking_Code);
         GXt_char1 = A462BR_Behavior_Achohol_Code;
         new zutil_findtargetcode(context ).execute(  14,  A25BR_Behavior_Achohol, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A25BR_Behavior_Achohol", A25BR_Behavior_Achohol);
         A462BR_Behavior_Achohol_Code = GXt_char1;
         n462BR_Behavior_Achohol_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A462BR_Behavior_Achohol_Code", A462BR_Behavior_Achohol_Code);
         GXt_char1 = A464BR_Behavior_FamilyCaHistory_Code;
         new zutil_findtargetcode(context ).execute(  37,  A29BR_Behavior_FamilyCaHistory, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A29BR_Behavior_FamilyCaHistory", A29BR_Behavior_FamilyCaHistory);
         A464BR_Behavior_FamilyCaHistory_Code = GXt_char1;
         n464BR_Behavior_FamilyCaHistory_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A464BR_Behavior_FamilyCaHistory_Code", A464BR_Behavior_FamilyCaHistory_Code);
         GXt_char1 = A465BR_Behavior_Menopause_Code;
         new zutil_findtargetcode(context ).execute(  37,  A31BR_Behavior_Menopause, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A31BR_Behavior_Menopause", A31BR_Behavior_Menopause);
         A465BR_Behavior_Menopause_Code = GXt_char1;
         n465BR_Behavior_Menopause_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A465BR_Behavior_Menopause_Code", A465BR_Behavior_Menopause_Code);
      }

      protected void BeforeUpdate089( )
      {
         /* Before Update Rules */
         GXt_char1 = A460BR_Behavior_Smoking_Code;
         new zutil_findtargetcode(context ).execute(  12,  A21BR_Behavior_Smoking, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A21BR_Behavior_Smoking", A21BR_Behavior_Smoking);
         A460BR_Behavior_Smoking_Code = GXt_char1;
         n460BR_Behavior_Smoking_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A460BR_Behavior_Smoking_Code", A460BR_Behavior_Smoking_Code);
         GXt_char1 = A462BR_Behavior_Achohol_Code;
         new zutil_findtargetcode(context ).execute(  14,  A25BR_Behavior_Achohol, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A25BR_Behavior_Achohol", A25BR_Behavior_Achohol);
         A462BR_Behavior_Achohol_Code = GXt_char1;
         n462BR_Behavior_Achohol_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A462BR_Behavior_Achohol_Code", A462BR_Behavior_Achohol_Code);
         GXt_char1 = A464BR_Behavior_FamilyCaHistory_Code;
         new zutil_findtargetcode(context ).execute(  37,  A29BR_Behavior_FamilyCaHistory, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A29BR_Behavior_FamilyCaHistory", A29BR_Behavior_FamilyCaHistory);
         A464BR_Behavior_FamilyCaHistory_Code = GXt_char1;
         n464BR_Behavior_FamilyCaHistory_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A464BR_Behavior_FamilyCaHistory_Code", A464BR_Behavior_FamilyCaHistory_Code);
         GXt_char1 = A465BR_Behavior_Menopause_Code;
         new zutil_findtargetcode(context ).execute(  37,  A31BR_Behavior_Menopause, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A31BR_Behavior_Menopause", A31BR_Behavior_Menopause);
         A465BR_Behavior_Menopause_Code = GXt_char1;
         n465BR_Behavior_Menopause_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A465BR_Behavior_Menopause_Code", A465BR_Behavior_Menopause_Code);
      }

      protected void BeforeDelete089( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete089( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate089( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes089( )
      {
         edtBR_EncounterID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_EncounterID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_EncounterID_Enabled), 5, 0)), true);
         dynBR_Behavior_Smoking.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynBR_Behavior_Smoking_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynBR_Behavior_Smoking.Enabled), 5, 0)), true);
         edtBR_Behavior_SmokingTime_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Behavior_SmokingTime_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Behavior_SmokingTime_Enabled), 5, 0)), true);
         edtBR_Behavior_SmokingAmount_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Behavior_SmokingAmount_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Behavior_SmokingAmount_Enabled), 5, 0)), true);
         edtBR_Behavior_RawSmokingAmount_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Behavior_RawSmokingAmount_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Behavior_RawSmokingAmount_Enabled), 5, 0)), true);
         dynBR_Behavior_Achohol.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynBR_Behavior_Achohol_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynBR_Behavior_Achohol.Enabled), 5, 0)), true);
         edtBR_Behavior_AchoholTime_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Behavior_AchoholTime_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Behavior_AchoholTime_Enabled), 5, 0)), true);
         edtBR_Behavior_AchoholAmount_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Behavior_AchoholAmount_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Behavior_AchoholAmount_Enabled), 5, 0)), true);
         edtBR_Behavior_RawAchoholAmount_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Behavior_RawAchoholAmount_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Behavior_RawAchoholAmount_Enabled), 5, 0)), true);
         cmbBR_Behavior_FamilyCaHistory.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Behavior_FamilyCaHistory_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbBR_Behavior_FamilyCaHistory.Enabled), 5, 0)), true);
         edtBR_Behavior_FamilyCancer_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Behavior_FamilyCancer_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Behavior_FamilyCancer_Enabled), 5, 0)), true);
         cmbBR_Behavior_Menopause.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Behavior_Menopause_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbBR_Behavior_Menopause.Enabled), 5, 0)), true);
         edtBR_Behavior_MenopauseAge_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Behavior_MenopauseAge_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Behavior_MenopauseAge_Enabled), 5, 0)), true);
         edtBR_Behavior_RawMenopauseAge_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Behavior_RawMenopauseAge_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Behavior_RawMenopauseAge_Enabled), 5, 0)), true);
         edtBR_Behavior_ChildNum_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Behavior_ChildNum_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Behavior_ChildNum_Enabled), 5, 0)), true);
         edtBR_BehaviorID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_BehaviorID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_BehaviorID_Enabled), 5, 0)), true);
      }

      protected void send_integrity_lvl_hashes089( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues080( )
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
         context.AddJavascriptSource("gxcfg.js", "?20202279355729", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_behavior.aspx") +"\">") ;
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
         forbiddenHiddens = "hsh" + "BR_Behavior";
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( AV12tCurrentCode, ""));
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A461BR_Behavior_RawSmokingAmount_Code, ""));
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A463BR_Behavior_RawAchoholAmount_Code, ""));
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("br_behavior:[SendSecurityCheck value for]"+"tCurrentCode:"+StringUtil.RTrim( context.localUtil.Format( AV12tCurrentCode, "")));
         GXUtil.WriteLog("br_behavior:[SendSecurityCheck value for]"+"BR_Behavior_RawSmokingAmount_Code:"+StringUtil.RTrim( context.localUtil.Format( A461BR_Behavior_RawSmokingAmount_Code, "")));
         GXUtil.WriteLog("br_behavior:[SendSecurityCheck value for]"+"BR_Behavior_RawAchoholAmount_Code:"+StringUtil.RTrim( context.localUtil.Format( A463BR_Behavior_RawAchoholAmount_Code, "")));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z20BR_BehaviorID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z20BR_BehaviorID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z460BR_Behavior_Smoking_Code", Z460BR_Behavior_Smoking_Code);
         GxWebStd.gx_hidden_field( context, "Z462BR_Behavior_Achohol_Code", Z462BR_Behavior_Achohol_Code);
         GxWebStd.gx_hidden_field( context, "Z464BR_Behavior_FamilyCaHistory_Code", Z464BR_Behavior_FamilyCaHistory_Code);
         GxWebStd.gx_hidden_field( context, "Z465BR_Behavior_Menopause_Code", Z465BR_Behavior_Menopause_Code);
         GxWebStd.gx_hidden_field( context, "Z21BR_Behavior_Smoking", Z21BR_Behavior_Smoking);
         GxWebStd.gx_hidden_field( context, "Z22BR_Behavior_SmokingTime", Z22BR_Behavior_SmokingTime);
         GxWebStd.gx_hidden_field( context, "Z23BR_Behavior_SmokingAmount", Z23BR_Behavior_SmokingAmount);
         GxWebStd.gx_hidden_field( context, "Z24BR_Behavior_RawSmokingAmount", Z24BR_Behavior_RawSmokingAmount);
         GxWebStd.gx_hidden_field( context, "Z461BR_Behavior_RawSmokingAmount_Code", Z461BR_Behavior_RawSmokingAmount_Code);
         GxWebStd.gx_hidden_field( context, "Z25BR_Behavior_Achohol", Z25BR_Behavior_Achohol);
         GxWebStd.gx_hidden_field( context, "Z26BR_Behavior_AchoholTime", Z26BR_Behavior_AchoholTime);
         GxWebStd.gx_hidden_field( context, "Z27BR_Behavior_AchoholAmount", Z27BR_Behavior_AchoholAmount);
         GxWebStd.gx_hidden_field( context, "Z28BR_Behavior_RawAchoholAmount", Z28BR_Behavior_RawAchoholAmount);
         GxWebStd.gx_hidden_field( context, "Z463BR_Behavior_RawAchoholAmount_Code", Z463BR_Behavior_RawAchoholAmount_Code);
         GxWebStd.gx_hidden_field( context, "Z29BR_Behavior_FamilyCaHistory", Z29BR_Behavior_FamilyCaHistory);
         GxWebStd.gx_hidden_field( context, "Z30BR_Behavior_FamilyCancer", Z30BR_Behavior_FamilyCancer);
         GxWebStd.gx_hidden_field( context, "Z31BR_Behavior_Menopause", Z31BR_Behavior_Menopause);
         GxWebStd.gx_hidden_field( context, "Z32BR_Behavior_MenopauseAge", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z32BR_Behavior_MenopauseAge), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z33BR_Behavior_RawMenopauseAge", Z33BR_Behavior_RawMenopauseAge);
         GxWebStd.gx_hidden_field( context, "Z34BR_Behavior_ChildNum", Z34BR_Behavior_ChildNum);
         GxWebStd.gx_hidden_field( context, "Z19BR_EncounterID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z19BR_EncounterID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "BR_BEHAVIOR_SMOKING_CODE", A460BR_Behavior_Smoking_Code);
         GxWebStd.gx_hidden_field( context, "BR_BEHAVIOR_ACHOHOL_CODE", A462BR_Behavior_Achohol_Code);
         GxWebStd.gx_hidden_field( context, "BR_BEHAVIOR_FAMILYCAHISTORY_CODE", A464BR_Behavior_FamilyCaHistory_Code);
         GxWebStd.gx_hidden_field( context, "BR_BEHAVIOR_MENOPAUSE_CODE", A465BR_Behavior_Menopause_Code);
         GxWebStd.gx_hidden_field( context, "vTCURRENTCODE", AV12tCurrentCode);
         GxWebStd.gx_hidden_field( context, "BR_BEHAVIOR_RAWSMOKINGAMOUNT_CODE", A461BR_Behavior_RawSmokingAmount_Code);
         GxWebStd.gx_hidden_field( context, "BR_BEHAVIOR_RAWACHOHOLAMOUNT_CODE", A463BR_Behavior_RawAchoholAmount_Code);
         GxWebStd.gx_hidden_field( context, "BR_INFORMATION_ID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A85BR_Information_ID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "BR_INFORMATION_PATIENTNO", A36BR_Information_PatientNo);
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
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
         return formatLink("br_behavior.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "BR_Behavior" ;
      }

      public override String GetPgmdesc( )
      {
         return "个人史" ;
      }

      protected void InitializeNonKey089( )
      {
         A85BR_Information_ID = 0;
         n85BR_Information_ID = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A85BR_Information_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A85BR_Information_ID), 18, 0)));
         A460BR_Behavior_Smoking_Code = "";
         n460BR_Behavior_Smoking_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A460BR_Behavior_Smoking_Code", A460BR_Behavior_Smoking_Code);
         A462BR_Behavior_Achohol_Code = "";
         n462BR_Behavior_Achohol_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A462BR_Behavior_Achohol_Code", A462BR_Behavior_Achohol_Code);
         A464BR_Behavior_FamilyCaHistory_Code = "";
         n464BR_Behavior_FamilyCaHistory_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A464BR_Behavior_FamilyCaHistory_Code", A464BR_Behavior_FamilyCaHistory_Code);
         A465BR_Behavior_Menopause_Code = "";
         n465BR_Behavior_Menopause_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A465BR_Behavior_Menopause_Code", A465BR_Behavior_Menopause_Code);
         A19BR_EncounterID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
         A36BR_Information_PatientNo = "";
         n36BR_Information_PatientNo = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36BR_Information_PatientNo", A36BR_Information_PatientNo);
         A21BR_Behavior_Smoking = "";
         n21BR_Behavior_Smoking = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A21BR_Behavior_Smoking", A21BR_Behavior_Smoking);
         n21BR_Behavior_Smoking = (String.IsNullOrEmpty(StringUtil.RTrim( A21BR_Behavior_Smoking)) ? true : false);
         A22BR_Behavior_SmokingTime = "";
         n22BR_Behavior_SmokingTime = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22BR_Behavior_SmokingTime", A22BR_Behavior_SmokingTime);
         n22BR_Behavior_SmokingTime = (String.IsNullOrEmpty(StringUtil.RTrim( A22BR_Behavior_SmokingTime)) ? true : false);
         A23BR_Behavior_SmokingAmount = "";
         n23BR_Behavior_SmokingAmount = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23BR_Behavior_SmokingAmount", A23BR_Behavior_SmokingAmount);
         n23BR_Behavior_SmokingAmount = (String.IsNullOrEmpty(StringUtil.RTrim( A23BR_Behavior_SmokingAmount)) ? true : false);
         A24BR_Behavior_RawSmokingAmount = "";
         n24BR_Behavior_RawSmokingAmount = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A24BR_Behavior_RawSmokingAmount", A24BR_Behavior_RawSmokingAmount);
         n24BR_Behavior_RawSmokingAmount = (String.IsNullOrEmpty(StringUtil.RTrim( A24BR_Behavior_RawSmokingAmount)) ? true : false);
         A461BR_Behavior_RawSmokingAmount_Code = "";
         n461BR_Behavior_RawSmokingAmount_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A461BR_Behavior_RawSmokingAmount_Code", A461BR_Behavior_RawSmokingAmount_Code);
         A25BR_Behavior_Achohol = "";
         n25BR_Behavior_Achohol = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A25BR_Behavior_Achohol", A25BR_Behavior_Achohol);
         n25BR_Behavior_Achohol = (String.IsNullOrEmpty(StringUtil.RTrim( A25BR_Behavior_Achohol)) ? true : false);
         A26BR_Behavior_AchoholTime = "";
         n26BR_Behavior_AchoholTime = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A26BR_Behavior_AchoholTime", A26BR_Behavior_AchoholTime);
         n26BR_Behavior_AchoholTime = (String.IsNullOrEmpty(StringUtil.RTrim( A26BR_Behavior_AchoholTime)) ? true : false);
         A27BR_Behavior_AchoholAmount = "";
         n27BR_Behavior_AchoholAmount = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27BR_Behavior_AchoholAmount", A27BR_Behavior_AchoholAmount);
         n27BR_Behavior_AchoholAmount = (String.IsNullOrEmpty(StringUtil.RTrim( A27BR_Behavior_AchoholAmount)) ? true : false);
         A28BR_Behavior_RawAchoholAmount = "";
         n28BR_Behavior_RawAchoholAmount = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A28BR_Behavior_RawAchoholAmount", A28BR_Behavior_RawAchoholAmount);
         n28BR_Behavior_RawAchoholAmount = (String.IsNullOrEmpty(StringUtil.RTrim( A28BR_Behavior_RawAchoholAmount)) ? true : false);
         A463BR_Behavior_RawAchoholAmount_Code = "";
         n463BR_Behavior_RawAchoholAmount_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A463BR_Behavior_RawAchoholAmount_Code", A463BR_Behavior_RawAchoholAmount_Code);
         A29BR_Behavior_FamilyCaHistory = "";
         n29BR_Behavior_FamilyCaHistory = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A29BR_Behavior_FamilyCaHistory", A29BR_Behavior_FamilyCaHistory);
         n29BR_Behavior_FamilyCaHistory = (String.IsNullOrEmpty(StringUtil.RTrim( A29BR_Behavior_FamilyCaHistory)) ? true : false);
         A30BR_Behavior_FamilyCancer = "";
         n30BR_Behavior_FamilyCancer = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A30BR_Behavior_FamilyCancer", A30BR_Behavior_FamilyCancer);
         n30BR_Behavior_FamilyCancer = (String.IsNullOrEmpty(StringUtil.RTrim( A30BR_Behavior_FamilyCancer)) ? true : false);
         A31BR_Behavior_Menopause = "";
         n31BR_Behavior_Menopause = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A31BR_Behavior_Menopause", A31BR_Behavior_Menopause);
         n31BR_Behavior_Menopause = (String.IsNullOrEmpty(StringUtil.RTrim( A31BR_Behavior_Menopause)) ? true : false);
         A32BR_Behavior_MenopauseAge = 0;
         n32BR_Behavior_MenopauseAge = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A32BR_Behavior_MenopauseAge", StringUtil.LTrim( StringUtil.Str( (decimal)(A32BR_Behavior_MenopauseAge), 4, 0)));
         n32BR_Behavior_MenopauseAge = ((0==A32BR_Behavior_MenopauseAge) ? true : false);
         A33BR_Behavior_RawMenopauseAge = "";
         n33BR_Behavior_RawMenopauseAge = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A33BR_Behavior_RawMenopauseAge", A33BR_Behavior_RawMenopauseAge);
         n33BR_Behavior_RawMenopauseAge = (String.IsNullOrEmpty(StringUtil.RTrim( A33BR_Behavior_RawMenopauseAge)) ? true : false);
         A34BR_Behavior_ChildNum = "";
         n34BR_Behavior_ChildNum = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34BR_Behavior_ChildNum", A34BR_Behavior_ChildNum);
         n34BR_Behavior_ChildNum = (String.IsNullOrEmpty(StringUtil.RTrim( A34BR_Behavior_ChildNum)) ? true : false);
         Z460BR_Behavior_Smoking_Code = "";
         Z462BR_Behavior_Achohol_Code = "";
         Z464BR_Behavior_FamilyCaHistory_Code = "";
         Z465BR_Behavior_Menopause_Code = "";
         Z21BR_Behavior_Smoking = "";
         Z22BR_Behavior_SmokingTime = "";
         Z23BR_Behavior_SmokingAmount = "";
         Z24BR_Behavior_RawSmokingAmount = "";
         Z461BR_Behavior_RawSmokingAmount_Code = "";
         Z25BR_Behavior_Achohol = "";
         Z26BR_Behavior_AchoholTime = "";
         Z27BR_Behavior_AchoholAmount = "";
         Z28BR_Behavior_RawAchoholAmount = "";
         Z463BR_Behavior_RawAchoholAmount_Code = "";
         Z29BR_Behavior_FamilyCaHistory = "";
         Z30BR_Behavior_FamilyCancer = "";
         Z31BR_Behavior_Menopause = "";
         Z32BR_Behavior_MenopauseAge = 0;
         Z33BR_Behavior_RawMenopauseAge = "";
         Z34BR_Behavior_ChildNum = "";
         Z19BR_EncounterID = 0;
      }

      protected void InitAll089( )
      {
         A20BR_BehaviorID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A20BR_BehaviorID", StringUtil.LTrim( StringUtil.Str( (decimal)(A20BR_BehaviorID), 18, 0)));
         InitializeNonKey089( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20202279355818", true);
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
         context.AddJavascriptSource("br_behavior.js", "?20202279355818", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         edtBR_EncounterID_Internalname = "BR_ENCOUNTERID";
         dynBR_Behavior_Smoking_Internalname = "BR_BEHAVIOR_SMOKING";
         edtBR_Behavior_SmokingTime_Internalname = "BR_BEHAVIOR_SMOKINGTIME";
         edtBR_Behavior_SmokingAmount_Internalname = "BR_BEHAVIOR_SMOKINGAMOUNT";
         edtBR_Behavior_RawSmokingAmount_Internalname = "BR_BEHAVIOR_RAWSMOKINGAMOUNT";
         dynBR_Behavior_Achohol_Internalname = "BR_BEHAVIOR_ACHOHOL";
         edtBR_Behavior_AchoholTime_Internalname = "BR_BEHAVIOR_ACHOHOLTIME";
         edtBR_Behavior_AchoholAmount_Internalname = "BR_BEHAVIOR_ACHOHOLAMOUNT";
         edtBR_Behavior_RawAchoholAmount_Internalname = "BR_BEHAVIOR_RAWACHOHOLAMOUNT";
         cmbBR_Behavior_FamilyCaHistory_Internalname = "BR_BEHAVIOR_FAMILYCAHISTORY";
         edtBR_Behavior_FamilyCancer_Internalname = "BR_BEHAVIOR_FAMILYCANCER";
         cmbBR_Behavior_Menopause_Internalname = "BR_BEHAVIOR_MENOPAUSE";
         edtBR_Behavior_MenopauseAge_Internalname = "BR_BEHAVIOR_MENOPAUSEAGE";
         edtBR_Behavior_RawMenopauseAge_Internalname = "BR_BEHAVIOR_RAWMENOPAUSEAGE";
         edtBR_Behavior_ChildNum_Internalname = "BR_BEHAVIOR_CHILDNUM";
         divTableattributes_Internalname = "TABLEATTRIBUTES";
         divLayout_tableattributes_Internalname = "LAYOUT_TABLEATTRIBUTES";
         Dvpanel_tableattributes_Internalname = "DVPANEL_TABLEATTRIBUTES";
         divHtml_dvpanel_tableattributes_Internalname = "HTML_DVPANEL_TABLEATTRIBUTES";
         divTablecontent_Internalname = "TABLECONTENT";
         bttBtntrn_enter_Internalname = "BTNTRN_ENTER";
         bttBtntrn_cancel_Internalname = "BTNTRN_CANCEL";
         bttBtntrn_delete_Internalname = "BTNTRN_DELETE";
         divTablemain_Internalname = "TABLEMAIN";
         edtBR_BehaviorID_Internalname = "BR_BEHAVIORID";
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
         Form.Caption = "个人史";
         edtBR_BehaviorID_Jsonclick = "";
         edtBR_BehaviorID_Enabled = 1;
         bttBtntrn_delete_Enabled = 1;
         bttBtntrn_delete_Visible = 1;
         bttBtntrn_cancel_Visible = 1;
         bttBtntrn_enter_Enabled = 1;
         bttBtntrn_enter_Visible = 1;
         edtBR_Behavior_ChildNum_Jsonclick = "";
         edtBR_Behavior_ChildNum_Enabled = 1;
         edtBR_Behavior_RawMenopauseAge_Jsonclick = "";
         edtBR_Behavior_RawMenopauseAge_Enabled = 1;
         edtBR_Behavior_MenopauseAge_Jsonclick = "";
         edtBR_Behavior_MenopauseAge_Enabled = 1;
         cmbBR_Behavior_Menopause_Jsonclick = "";
         cmbBR_Behavior_Menopause.Enabled = 1;
         edtBR_Behavior_FamilyCancer_Enabled = 1;
         cmbBR_Behavior_FamilyCaHistory_Jsonclick = "";
         cmbBR_Behavior_FamilyCaHistory.Enabled = 1;
         edtBR_Behavior_RawAchoholAmount_Jsonclick = "";
         edtBR_Behavior_RawAchoholAmount_Enabled = 1;
         edtBR_Behavior_AchoholAmount_Jsonclick = "";
         edtBR_Behavior_AchoholAmount_Enabled = 1;
         edtBR_Behavior_AchoholTime_Jsonclick = "";
         edtBR_Behavior_AchoholTime_Enabled = 1;
         dynBR_Behavior_Achohol_Jsonclick = "";
         dynBR_Behavior_Achohol.Enabled = 1;
         edtBR_Behavior_RawSmokingAmount_Jsonclick = "";
         edtBR_Behavior_RawSmokingAmount_Enabled = 1;
         edtBR_Behavior_SmokingAmount_Jsonclick = "";
         edtBR_Behavior_SmokingAmount_Enabled = 1;
         edtBR_Behavior_SmokingTime_Jsonclick = "";
         edtBR_Behavior_SmokingTime_Enabled = 1;
         dynBR_Behavior_Smoking_Jsonclick = "";
         dynBR_Behavior_Smoking.Enabled = 1;
         edtBR_EncounterID_Jsonclick = "";
         edtBR_EncounterID_Enabled = 1;
         Dvpanel_tableattributes_Autoscroll = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Iconposition = "left";
         Dvpanel_tableattributes_Showcollapseicon = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsed = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsible = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Title = "基础信息";
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

      protected void GXDLABR_BEHAVIOR_SMOKING089( String AV12tCurrentCode )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLABR_BEHAVIOR_SMOKING_data089( AV12tCurrentCode) ;
         gxdynajaxindex = 1;
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            context.GX_webresponse.AddString(gxwrpcisep+"{\"c\":\""+GXUtil.EncodeJSConstant( ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex)))+"\",\"d\":\""+GXUtil.EncodeJSConstant( ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)))+"\"}");
            gxdynajaxindex = (int)(gxdynajaxindex+1);
            gxwrpcisep = ",";
         }
         context.GX_webresponse.AddString("]");
         if ( gxdynajaxctrlcodr.Count == 0 )
         {
            context.GX_webresponse.AddString(",101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GXABR_BEHAVIOR_SMOKING_html089( String AV12tCurrentCode )
      {
         String gxdynajaxvalue ;
         GXDLABR_BEHAVIOR_SMOKING_data089( AV12tCurrentCode) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynBR_Behavior_Smoking.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex));
            dynBR_Behavior_Smoking.addItem(gxdynajaxvalue, ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLABR_BEHAVIOR_SMOKING_data089( String AV12tCurrentCode )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add("");
         gxdynajaxctrldescr.Add("(请选择)");
         /* Using cursor T000818 */
         pr_default.execute(16, new Object[] {AV12tCurrentCode});
         while ( (pr_default.getStatus(16) != 101) )
         {
            gxdynajaxctrlcodr.Add(T000818_A168XT_DefineCodeName[0]);
            gxdynajaxctrldescr.Add(T000818_A168XT_DefineCodeName[0]);
            pr_default.readNext(16);
         }
         pr_default.close(16);
      }

      protected void GXDLABR_BEHAVIOR_ACHOHOL089( String AV12tCurrentCode )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLABR_BEHAVIOR_ACHOHOL_data089( AV12tCurrentCode) ;
         gxdynajaxindex = 1;
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            context.GX_webresponse.AddString(gxwrpcisep+"{\"c\":\""+GXUtil.EncodeJSConstant( ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex)))+"\",\"d\":\""+GXUtil.EncodeJSConstant( ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)))+"\"}");
            gxdynajaxindex = (int)(gxdynajaxindex+1);
            gxwrpcisep = ",";
         }
         context.GX_webresponse.AddString("]");
         if ( gxdynajaxctrlcodr.Count == 0 )
         {
            context.GX_webresponse.AddString(",101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GXABR_BEHAVIOR_ACHOHOL_html089( String AV12tCurrentCode )
      {
         String gxdynajaxvalue ;
         GXDLABR_BEHAVIOR_ACHOHOL_data089( AV12tCurrentCode) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynBR_Behavior_Achohol.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex));
            dynBR_Behavior_Achohol.addItem(gxdynajaxvalue, ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLABR_BEHAVIOR_ACHOHOL_data089( String AV12tCurrentCode )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add("");
         gxdynajaxctrldescr.Add("(请选择)");
         /* Using cursor T000819 */
         pr_default.execute(17, new Object[] {AV12tCurrentCode});
         while ( (pr_default.getStatus(17) != 101) )
         {
            gxdynajaxctrlcodr.Add(T000819_A168XT_DefineCodeName[0]);
            gxdynajaxctrldescr.Add(T000819_A168XT_DefineCodeName[0]);
            pr_default.readNext(17);
         }
         pr_default.close(17);
      }

      protected void GX3ASABR_BEHAVIOR_SMOKING_CODE089( String A21BR_Behavior_Smoking )
      {
         GXt_char1 = A460BR_Behavior_Smoking_Code;
         new zutil_findtargetcode(context ).execute(  12,  A21BR_Behavior_Smoking, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A21BR_Behavior_Smoking", A21BR_Behavior_Smoking);
         A460BR_Behavior_Smoking_Code = GXt_char1;
         n460BR_Behavior_Smoking_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A460BR_Behavior_Smoking_Code", A460BR_Behavior_Smoking_Code);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A460BR_Behavior_Smoking_Code)+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GX4ASABR_BEHAVIOR_SMOKING_CODE089( String A21BR_Behavior_Smoking )
      {
         GXt_char1 = A460BR_Behavior_Smoking_Code;
         new zutil_findtargetcode(context ).execute(  12,  A21BR_Behavior_Smoking, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A21BR_Behavior_Smoking", A21BR_Behavior_Smoking);
         A460BR_Behavior_Smoking_Code = GXt_char1;
         n460BR_Behavior_Smoking_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A460BR_Behavior_Smoking_Code", A460BR_Behavior_Smoking_Code);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A460BR_Behavior_Smoking_Code)+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GX5ASABR_BEHAVIOR_ACHOHOL_CODE089( String A25BR_Behavior_Achohol )
      {
         GXt_char1 = A462BR_Behavior_Achohol_Code;
         new zutil_findtargetcode(context ).execute(  14,  A25BR_Behavior_Achohol, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A25BR_Behavior_Achohol", A25BR_Behavior_Achohol);
         A462BR_Behavior_Achohol_Code = GXt_char1;
         n462BR_Behavior_Achohol_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A462BR_Behavior_Achohol_Code", A462BR_Behavior_Achohol_Code);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A462BR_Behavior_Achohol_Code)+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GX6ASABR_BEHAVIOR_ACHOHOL_CODE089( String A25BR_Behavior_Achohol )
      {
         GXt_char1 = A462BR_Behavior_Achohol_Code;
         new zutil_findtargetcode(context ).execute(  14,  A25BR_Behavior_Achohol, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A25BR_Behavior_Achohol", A25BR_Behavior_Achohol);
         A462BR_Behavior_Achohol_Code = GXt_char1;
         n462BR_Behavior_Achohol_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A462BR_Behavior_Achohol_Code", A462BR_Behavior_Achohol_Code);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A462BR_Behavior_Achohol_Code)+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GX7ASABR_BEHAVIOR_FAMILYCAHISTORY_CODE089( String A29BR_Behavior_FamilyCaHistory )
      {
         GXt_char1 = A464BR_Behavior_FamilyCaHistory_Code;
         new zutil_findtargetcode(context ).execute(  37,  A29BR_Behavior_FamilyCaHistory, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A29BR_Behavior_FamilyCaHistory", A29BR_Behavior_FamilyCaHistory);
         A464BR_Behavior_FamilyCaHistory_Code = GXt_char1;
         n464BR_Behavior_FamilyCaHistory_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A464BR_Behavior_FamilyCaHistory_Code", A464BR_Behavior_FamilyCaHistory_Code);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A464BR_Behavior_FamilyCaHistory_Code)+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GX8ASABR_BEHAVIOR_FAMILYCAHISTORY_CODE089( String A29BR_Behavior_FamilyCaHistory )
      {
         GXt_char1 = A464BR_Behavior_FamilyCaHistory_Code;
         new zutil_findtargetcode(context ).execute(  37,  A29BR_Behavior_FamilyCaHistory, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A29BR_Behavior_FamilyCaHistory", A29BR_Behavior_FamilyCaHistory);
         A464BR_Behavior_FamilyCaHistory_Code = GXt_char1;
         n464BR_Behavior_FamilyCaHistory_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A464BR_Behavior_FamilyCaHistory_Code", A464BR_Behavior_FamilyCaHistory_Code);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A464BR_Behavior_FamilyCaHistory_Code)+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GX9ASABR_BEHAVIOR_MENOPAUSE_CODE089( String A31BR_Behavior_Menopause )
      {
         GXt_char1 = A465BR_Behavior_Menopause_Code;
         new zutil_findtargetcode(context ).execute(  37,  A31BR_Behavior_Menopause, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A31BR_Behavior_Menopause", A31BR_Behavior_Menopause);
         A465BR_Behavior_Menopause_Code = GXt_char1;
         n465BR_Behavior_Menopause_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A465BR_Behavior_Menopause_Code", A465BR_Behavior_Menopause_Code);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A465BR_Behavior_Menopause_Code)+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GX10ASABR_BEHAVIOR_MENOPAUSE_CODE089( String A31BR_Behavior_Menopause )
      {
         GXt_char1 = A465BR_Behavior_Menopause_Code;
         new zutil_findtargetcode(context ).execute(  37,  A31BR_Behavior_Menopause, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A31BR_Behavior_Menopause", A31BR_Behavior_Menopause);
         A465BR_Behavior_Menopause_Code = GXt_char1;
         n465BR_Behavior_Menopause_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A465BR_Behavior_Menopause_Code", A465BR_Behavior_Menopause_Code);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A465BR_Behavior_Menopause_Code)+"\"");
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
         dynBR_Behavior_Smoking.Name = "BR_BEHAVIOR_SMOKING";
         dynBR_Behavior_Smoking.WebTags = "";
         dynBR_Behavior_Achohol.Name = "BR_BEHAVIOR_ACHOHOL";
         dynBR_Behavior_Achohol.WebTags = "";
         cmbBR_Behavior_FamilyCaHistory.Name = "BR_BEHAVIOR_FAMILYCAHISTORY";
         cmbBR_Behavior_FamilyCaHistory.WebTags = "";
         cmbBR_Behavior_FamilyCaHistory.addItem("", "(请选择)", 0);
         cmbBR_Behavior_FamilyCaHistory.addItem("否", "否", 0);
         cmbBR_Behavior_FamilyCaHistory.addItem("是", "是", 0);
         cmbBR_Behavior_FamilyCaHistory.addItem("不详", "不详", 0);
         if ( cmbBR_Behavior_FamilyCaHistory.ItemCount > 0 )
         {
            A29BR_Behavior_FamilyCaHistory = cmbBR_Behavior_FamilyCaHistory.getValidValue(A29BR_Behavior_FamilyCaHistory);
            n29BR_Behavior_FamilyCaHistory = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A29BR_Behavior_FamilyCaHistory", A29BR_Behavior_FamilyCaHistory);
         }
         cmbBR_Behavior_Menopause.Name = "BR_BEHAVIOR_MENOPAUSE";
         cmbBR_Behavior_Menopause.WebTags = "";
         cmbBR_Behavior_Menopause.addItem("", "(请选择)", 0);
         cmbBR_Behavior_Menopause.addItem("否", "否", 0);
         cmbBR_Behavior_Menopause.addItem("是", "是", 0);
         cmbBR_Behavior_Menopause.addItem("不详", "不详", 0);
         if ( cmbBR_Behavior_Menopause.ItemCount > 0 )
         {
            A31BR_Behavior_Menopause = cmbBR_Behavior_Menopause.getValidValue(A31BR_Behavior_Menopause);
            n31BR_Behavior_Menopause = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A31BR_Behavior_Menopause", A31BR_Behavior_Menopause);
         }
         /* End function init_web_controls */
      }

      protected void AfterKeyLoadScreen( )
      {
         IsConfirmed = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         getEqualNoModal( ) ;
         GX_FocusControl = edtBR_EncounterID_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         /* End function AfterKeyLoadScreen */
      }

      public void Valid_Br_behaviorid( String GX_Parm1 ,
                                       long GX_Parm2 ,
                                       String GX_Parm3 ,
                                       String GX_Parm4 ,
                                       String GX_Parm5 ,
                                       String GX_Parm6 ,
                                       GXCombobox dynGX_Parm7 ,
                                       String GX_Parm8 ,
                                       String GX_Parm9 ,
                                       String GX_Parm10 ,
                                       String GX_Parm11 ,
                                       GXCombobox dynGX_Parm12 ,
                                       String GX_Parm13 ,
                                       String GX_Parm14 ,
                                       String GX_Parm15 ,
                                       String GX_Parm16 ,
                                       GXCombobox cmbGX_Parm17 ,
                                       String GX_Parm18 ,
                                       GXCombobox cmbGX_Parm19 ,
                                       short GX_Parm20 ,
                                       String GX_Parm21 ,
                                       String GX_Parm22 ,
                                       long GX_Parm23 )
      {
         AV12tCurrentCode = GX_Parm1;
         A20BR_BehaviorID = GX_Parm2;
         A460BR_Behavior_Smoking_Code = GX_Parm3;
         n460BR_Behavior_Smoking_Code = false;
         A462BR_Behavior_Achohol_Code = GX_Parm4;
         n462BR_Behavior_Achohol_Code = false;
         A464BR_Behavior_FamilyCaHistory_Code = GX_Parm5;
         n464BR_Behavior_FamilyCaHistory_Code = false;
         A465BR_Behavior_Menopause_Code = GX_Parm6;
         n465BR_Behavior_Menopause_Code = false;
         dynBR_Behavior_Smoking = dynGX_Parm7;
         A21BR_Behavior_Smoking = dynBR_Behavior_Smoking.CurrentValue;
         n21BR_Behavior_Smoking = false;
         A22BR_Behavior_SmokingTime = GX_Parm8;
         n22BR_Behavior_SmokingTime = false;
         A23BR_Behavior_SmokingAmount = GX_Parm9;
         n23BR_Behavior_SmokingAmount = false;
         A24BR_Behavior_RawSmokingAmount = GX_Parm10;
         n24BR_Behavior_RawSmokingAmount = false;
         A461BR_Behavior_RawSmokingAmount_Code = GX_Parm11;
         n461BR_Behavior_RawSmokingAmount_Code = false;
         dynBR_Behavior_Achohol = dynGX_Parm12;
         A25BR_Behavior_Achohol = dynBR_Behavior_Achohol.CurrentValue;
         n25BR_Behavior_Achohol = false;
         A26BR_Behavior_AchoholTime = GX_Parm13;
         n26BR_Behavior_AchoholTime = false;
         A27BR_Behavior_AchoholAmount = GX_Parm14;
         n27BR_Behavior_AchoholAmount = false;
         A28BR_Behavior_RawAchoholAmount = GX_Parm15;
         n28BR_Behavior_RawAchoholAmount = false;
         A463BR_Behavior_RawAchoholAmount_Code = GX_Parm16;
         n463BR_Behavior_RawAchoholAmount_Code = false;
         cmbBR_Behavior_FamilyCaHistory = cmbGX_Parm17;
         A29BR_Behavior_FamilyCaHistory = cmbBR_Behavior_FamilyCaHistory.CurrentValue;
         n29BR_Behavior_FamilyCaHistory = false;
         cmbBR_Behavior_FamilyCaHistory.CurrentValue = A29BR_Behavior_FamilyCaHistory;
         A30BR_Behavior_FamilyCancer = GX_Parm18;
         n30BR_Behavior_FamilyCancer = false;
         cmbBR_Behavior_Menopause = cmbGX_Parm19;
         A31BR_Behavior_Menopause = cmbBR_Behavior_Menopause.CurrentValue;
         n31BR_Behavior_Menopause = false;
         cmbBR_Behavior_Menopause.CurrentValue = A31BR_Behavior_Menopause;
         A32BR_Behavior_MenopauseAge = GX_Parm20;
         n32BR_Behavior_MenopauseAge = false;
         A33BR_Behavior_RawMenopauseAge = GX_Parm21;
         n33BR_Behavior_RawMenopauseAge = false;
         A34BR_Behavior_ChildNum = GX_Parm22;
         n34BR_Behavior_ChildNum = false;
         A19BR_EncounterID = GX_Parm23;
         context.wbHandled = 1;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         send_integrity_footer_hashes( ) ;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A85BR_Information_ID = 0;
            n85BR_Information_ID = false;
            A36BR_Information_PatientNo = "";
            n36BR_Information_PatientNo = false;
         }
         dynBR_Behavior_Smoking.CurrentValue = A21BR_Behavior_Smoking;
         dynBR_Behavior_Achohol.CurrentValue = A25BR_Behavior_Achohol;
         isValidOutput.Add(A460BR_Behavior_Smoking_Code);
         isValidOutput.Add(A462BR_Behavior_Achohol_Code);
         isValidOutput.Add(A464BR_Behavior_FamilyCaHistory_Code);
         isValidOutput.Add(A465BR_Behavior_Menopause_Code);
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(A19BR_EncounterID), 18, 0, ".", "")));
         if ( dynBR_Behavior_Smoking.ItemCount > 0 )
         {
            A21BR_Behavior_Smoking = dynBR_Behavior_Smoking.getValidValue(A21BR_Behavior_Smoking);
            n21BR_Behavior_Smoking = false;
         }
         dynBR_Behavior_Smoking.CurrentValue = A21BR_Behavior_Smoking;
         isValidOutput.Add(dynBR_Behavior_Smoking);
         isValidOutput.Add(A22BR_Behavior_SmokingTime);
         isValidOutput.Add(A23BR_Behavior_SmokingAmount);
         isValidOutput.Add(A24BR_Behavior_RawSmokingAmount);
         isValidOutput.Add(A461BR_Behavior_RawSmokingAmount_Code);
         if ( dynBR_Behavior_Achohol.ItemCount > 0 )
         {
            A25BR_Behavior_Achohol = dynBR_Behavior_Achohol.getValidValue(A25BR_Behavior_Achohol);
            n25BR_Behavior_Achohol = false;
         }
         dynBR_Behavior_Achohol.CurrentValue = A25BR_Behavior_Achohol;
         isValidOutput.Add(dynBR_Behavior_Achohol);
         isValidOutput.Add(A26BR_Behavior_AchoholTime);
         isValidOutput.Add(A27BR_Behavior_AchoholAmount);
         isValidOutput.Add(A28BR_Behavior_RawAchoholAmount);
         isValidOutput.Add(A463BR_Behavior_RawAchoholAmount_Code);
         cmbBR_Behavior_FamilyCaHistory.CurrentValue = A29BR_Behavior_FamilyCaHistory;
         isValidOutput.Add(cmbBR_Behavior_FamilyCaHistory);
         isValidOutput.Add(A30BR_Behavior_FamilyCancer);
         cmbBR_Behavior_Menopause.CurrentValue = A31BR_Behavior_Menopause;
         isValidOutput.Add(cmbBR_Behavior_Menopause);
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(A32BR_Behavior_MenopauseAge), 4, 0, ".", "")));
         isValidOutput.Add(A33BR_Behavior_RawMenopauseAge);
         isValidOutput.Add(A34BR_Behavior_ChildNum);
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(A85BR_Information_ID), 18, 0, ".", "")));
         isValidOutput.Add(A36BR_Information_PatientNo);
         isValidOutput.Add(StringUtil.RTrim( Gx_mode));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z20BR_BehaviorID), 18, 0, ".", "")));
         isValidOutput.Add(Z460BR_Behavior_Smoking_Code);
         isValidOutput.Add(Z462BR_Behavior_Achohol_Code);
         isValidOutput.Add(Z464BR_Behavior_FamilyCaHistory_Code);
         isValidOutput.Add(Z465BR_Behavior_Menopause_Code);
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z19BR_EncounterID), 18, 0, ".", "")));
         isValidOutput.Add(Z21BR_Behavior_Smoking);
         isValidOutput.Add(Z22BR_Behavior_SmokingTime);
         isValidOutput.Add(Z23BR_Behavior_SmokingAmount);
         isValidOutput.Add(Z24BR_Behavior_RawSmokingAmount);
         isValidOutput.Add(Z461BR_Behavior_RawSmokingAmount_Code);
         isValidOutput.Add(Z25BR_Behavior_Achohol);
         isValidOutput.Add(Z26BR_Behavior_AchoholTime);
         isValidOutput.Add(Z27BR_Behavior_AchoholAmount);
         isValidOutput.Add(Z28BR_Behavior_RawAchoholAmount);
         isValidOutput.Add(Z463BR_Behavior_RawAchoholAmount_Code);
         isValidOutput.Add(Z29BR_Behavior_FamilyCaHistory);
         isValidOutput.Add(Z30BR_Behavior_FamilyCancer);
         isValidOutput.Add(Z31BR_Behavior_Menopause);
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z32BR_Behavior_MenopauseAge), 4, 0, ".", "")));
         isValidOutput.Add(Z33BR_Behavior_RawMenopauseAge);
         isValidOutput.Add(Z34BR_Behavior_ChildNum);
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z85BR_Information_ID), 18, 0, ".", "")));
         isValidOutput.Add(Z36BR_Information_PatientNo);
         isValidOutput.Add(bttBtntrn_delete_Enabled);
         isValidOutput.Add(bttBtntrn_enter_Enabled);
         isValidOutput.Add(context.GX_msglist.ToJavascriptSource());
         isValidOutput.Add(context.httpAjaxContext.ajax_rsp_get_hiddens( ));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json");
      }

      public void Valid_Br_encounterid( long GX_Parm1 ,
                                        long GX_Parm2 ,
                                        String GX_Parm3 )
      {
         A19BR_EncounterID = GX_Parm1;
         A85BR_Information_ID = GX_Parm2;
         n85BR_Information_ID = false;
         A36BR_Information_PatientNo = GX_Parm3;
         n36BR_Information_PatientNo = false;
         /* Using cursor T000820 */
         pr_default.execute(18, new Object[] {A19BR_EncounterID});
         if ( (pr_default.getStatus(18) == 101) )
         {
            GX_msglist.addItem("不匹配' T15'", "ForeignKeyNotFound", 1, "BR_ENCOUNTERID");
            AnyError = 1;
            GX_FocusControl = edtBR_EncounterID_Internalname;
         }
         A85BR_Information_ID = T000820_A85BR_Information_ID[0];
         n85BR_Information_ID = T000820_n85BR_Information_ID[0];
         pr_default.close(18);
         /* Using cursor T000821 */
         pr_default.execute(19, new Object[] {n85BR_Information_ID, A85BR_Information_ID});
         if ( (pr_default.getStatus(19) == 101) )
         {
            if ( ! ( (0==A85BR_Information_ID) ) )
            {
               GX_msglist.addItem("不匹配' T16'", "ForeignKeyNotFound", 1, "");
               AnyError = 1;
            }
         }
         A36BR_Information_PatientNo = T000821_A36BR_Information_PatientNo[0];
         n36BR_Information_PatientNo = T000821_n36BR_Information_PatientNo[0];
         pr_default.close(19);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A85BR_Information_ID = 0;
            n85BR_Information_ID = false;
            A36BR_Information_PatientNo = "";
            n36BR_Information_PatientNo = false;
         }
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(A85BR_Information_ID), 18, 0, ".", "")));
         isValidOutput.Add(A36BR_Information_PatientNo);
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'AV12tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'A461BR_Behavior_RawSmokingAmount_Code',fld:'BR_BEHAVIOR_RAWSMOKINGAMOUNT_CODE',pic:''},{av:'A463BR_Behavior_RawAchoholAmount_Code',fld:'BR_BEHAVIOR_RAWACHOHOLAMOUNT_CODE',pic:''}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("AFTER TRN","{handler:'E12082',iparms:[]");
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
         pr_default.close(18);
         pr_default.close(13);
         pr_default.close(19);
         pr_default.close(14);
      }

      public override void initialize( )
      {
         sPrefix = "";
         Z460BR_Behavior_Smoking_Code = "";
         Z462BR_Behavior_Achohol_Code = "";
         Z464BR_Behavior_FamilyCaHistory_Code = "";
         Z465BR_Behavior_Menopause_Code = "";
         Z21BR_Behavior_Smoking = "";
         Z22BR_Behavior_SmokingTime = "";
         Z23BR_Behavior_SmokingAmount = "";
         Z24BR_Behavior_RawSmokingAmount = "";
         Z461BR_Behavior_RawSmokingAmount_Code = "";
         Z25BR_Behavior_Achohol = "";
         Z26BR_Behavior_AchoholTime = "";
         Z27BR_Behavior_AchoholAmount = "";
         Z28BR_Behavior_RawAchoholAmount = "";
         Z463BR_Behavior_RawAchoholAmount_Code = "";
         Z29BR_Behavior_FamilyCaHistory = "";
         Z30BR_Behavior_FamilyCancer = "";
         Z31BR_Behavior_Menopause = "";
         Z33BR_Behavior_RawMenopauseAge = "";
         Z34BR_Behavior_ChildNum = "";
         scmdbuf = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV12tCurrentCode = "";
         A21BR_Behavior_Smoking = "";
         A25BR_Behavior_Achohol = "";
         A29BR_Behavior_FamilyCaHistory = "";
         A31BR_Behavior_Menopause = "";
         GXKey = "";
         PreviousTooltip = "";
         PreviousCaption = "";
         Form = new GXWebForm();
         GX_FocusControl = "";
         ClassString = "";
         StyleString = "";
         ucDvpanel_tableattributes = new GXUserControl();
         TempTags = "";
         A22BR_Behavior_SmokingTime = "";
         A23BR_Behavior_SmokingAmount = "";
         A24BR_Behavior_RawSmokingAmount = "";
         A26BR_Behavior_AchoholTime = "";
         A27BR_Behavior_AchoholAmount = "";
         A28BR_Behavior_RawAchoholAmount = "";
         A30BR_Behavior_FamilyCancer = "";
         A33BR_Behavior_RawMenopauseAge = "";
         A34BR_Behavior_ChildNum = "";
         bttBtntrn_enter_Jsonclick = "";
         bttBtntrn_cancel_Jsonclick = "";
         bttBtntrn_delete_Jsonclick = "";
         A460BR_Behavior_Smoking_Code = "";
         A462BR_Behavior_Achohol_Code = "";
         A464BR_Behavior_FamilyCaHistory_Code = "";
         A465BR_Behavior_Menopause_Code = "";
         A461BR_Behavior_RawSmokingAmount_Code = "";
         A463BR_Behavior_RawAchoholAmount_Code = "";
         Gx_mode = "";
         A36BR_Information_PatientNo = "";
         Dvpanel_tableattributes_Objectcall = "";
         Dvpanel_tableattributes_Class = "";
         Dvpanel_tableattributes_Height = "";
         forbiddenHiddens = "";
         hsh = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         Z36BR_Information_PatientNo = "";
         T00086_A85BR_Information_ID = new long[1] ;
         T00086_n85BR_Information_ID = new bool[] {false} ;
         T00086_A20BR_BehaviorID = new long[1] ;
         T00086_A460BR_Behavior_Smoking_Code = new String[] {""} ;
         T00086_n460BR_Behavior_Smoking_Code = new bool[] {false} ;
         T00086_A462BR_Behavior_Achohol_Code = new String[] {""} ;
         T00086_n462BR_Behavior_Achohol_Code = new bool[] {false} ;
         T00086_A464BR_Behavior_FamilyCaHistory_Code = new String[] {""} ;
         T00086_n464BR_Behavior_FamilyCaHistory_Code = new bool[] {false} ;
         T00086_A465BR_Behavior_Menopause_Code = new String[] {""} ;
         T00086_n465BR_Behavior_Menopause_Code = new bool[] {false} ;
         T00086_A36BR_Information_PatientNo = new String[] {""} ;
         T00086_n36BR_Information_PatientNo = new bool[] {false} ;
         T00086_A21BR_Behavior_Smoking = new String[] {""} ;
         T00086_n21BR_Behavior_Smoking = new bool[] {false} ;
         T00086_A22BR_Behavior_SmokingTime = new String[] {""} ;
         T00086_n22BR_Behavior_SmokingTime = new bool[] {false} ;
         T00086_A23BR_Behavior_SmokingAmount = new String[] {""} ;
         T00086_n23BR_Behavior_SmokingAmount = new bool[] {false} ;
         T00086_A24BR_Behavior_RawSmokingAmount = new String[] {""} ;
         T00086_n24BR_Behavior_RawSmokingAmount = new bool[] {false} ;
         T00086_A461BR_Behavior_RawSmokingAmount_Code = new String[] {""} ;
         T00086_n461BR_Behavior_RawSmokingAmount_Code = new bool[] {false} ;
         T00086_A25BR_Behavior_Achohol = new String[] {""} ;
         T00086_n25BR_Behavior_Achohol = new bool[] {false} ;
         T00086_A26BR_Behavior_AchoholTime = new String[] {""} ;
         T00086_n26BR_Behavior_AchoholTime = new bool[] {false} ;
         T00086_A27BR_Behavior_AchoholAmount = new String[] {""} ;
         T00086_n27BR_Behavior_AchoholAmount = new bool[] {false} ;
         T00086_A28BR_Behavior_RawAchoholAmount = new String[] {""} ;
         T00086_n28BR_Behavior_RawAchoholAmount = new bool[] {false} ;
         T00086_A463BR_Behavior_RawAchoholAmount_Code = new String[] {""} ;
         T00086_n463BR_Behavior_RawAchoholAmount_Code = new bool[] {false} ;
         T00086_A29BR_Behavior_FamilyCaHistory = new String[] {""} ;
         T00086_n29BR_Behavior_FamilyCaHistory = new bool[] {false} ;
         T00086_A30BR_Behavior_FamilyCancer = new String[] {""} ;
         T00086_n30BR_Behavior_FamilyCancer = new bool[] {false} ;
         T00086_A31BR_Behavior_Menopause = new String[] {""} ;
         T00086_n31BR_Behavior_Menopause = new bool[] {false} ;
         T00086_A32BR_Behavior_MenopauseAge = new short[1] ;
         T00086_n32BR_Behavior_MenopauseAge = new bool[] {false} ;
         T00086_A33BR_Behavior_RawMenopauseAge = new String[] {""} ;
         T00086_n33BR_Behavior_RawMenopauseAge = new bool[] {false} ;
         T00086_A34BR_Behavior_ChildNum = new String[] {""} ;
         T00086_n34BR_Behavior_ChildNum = new bool[] {false} ;
         T00086_A19BR_EncounterID = new long[1] ;
         T00084_A85BR_Information_ID = new long[1] ;
         T00084_n85BR_Information_ID = new bool[] {false} ;
         T00085_A36BR_Information_PatientNo = new String[] {""} ;
         T00085_n36BR_Information_PatientNo = new bool[] {false} ;
         T00087_A85BR_Information_ID = new long[1] ;
         T00087_n85BR_Information_ID = new bool[] {false} ;
         T00088_A36BR_Information_PatientNo = new String[] {""} ;
         T00088_n36BR_Information_PatientNo = new bool[] {false} ;
         T00089_A20BR_BehaviorID = new long[1] ;
         T00083_A20BR_BehaviorID = new long[1] ;
         T00083_A460BR_Behavior_Smoking_Code = new String[] {""} ;
         T00083_n460BR_Behavior_Smoking_Code = new bool[] {false} ;
         T00083_A462BR_Behavior_Achohol_Code = new String[] {""} ;
         T00083_n462BR_Behavior_Achohol_Code = new bool[] {false} ;
         T00083_A464BR_Behavior_FamilyCaHistory_Code = new String[] {""} ;
         T00083_n464BR_Behavior_FamilyCaHistory_Code = new bool[] {false} ;
         T00083_A465BR_Behavior_Menopause_Code = new String[] {""} ;
         T00083_n465BR_Behavior_Menopause_Code = new bool[] {false} ;
         T00083_A21BR_Behavior_Smoking = new String[] {""} ;
         T00083_n21BR_Behavior_Smoking = new bool[] {false} ;
         T00083_A22BR_Behavior_SmokingTime = new String[] {""} ;
         T00083_n22BR_Behavior_SmokingTime = new bool[] {false} ;
         T00083_A23BR_Behavior_SmokingAmount = new String[] {""} ;
         T00083_n23BR_Behavior_SmokingAmount = new bool[] {false} ;
         T00083_A24BR_Behavior_RawSmokingAmount = new String[] {""} ;
         T00083_n24BR_Behavior_RawSmokingAmount = new bool[] {false} ;
         T00083_A461BR_Behavior_RawSmokingAmount_Code = new String[] {""} ;
         T00083_n461BR_Behavior_RawSmokingAmount_Code = new bool[] {false} ;
         T00083_A25BR_Behavior_Achohol = new String[] {""} ;
         T00083_n25BR_Behavior_Achohol = new bool[] {false} ;
         T00083_A26BR_Behavior_AchoholTime = new String[] {""} ;
         T00083_n26BR_Behavior_AchoholTime = new bool[] {false} ;
         T00083_A27BR_Behavior_AchoholAmount = new String[] {""} ;
         T00083_n27BR_Behavior_AchoholAmount = new bool[] {false} ;
         T00083_A28BR_Behavior_RawAchoholAmount = new String[] {""} ;
         T00083_n28BR_Behavior_RawAchoholAmount = new bool[] {false} ;
         T00083_A463BR_Behavior_RawAchoholAmount_Code = new String[] {""} ;
         T00083_n463BR_Behavior_RawAchoholAmount_Code = new bool[] {false} ;
         T00083_A29BR_Behavior_FamilyCaHistory = new String[] {""} ;
         T00083_n29BR_Behavior_FamilyCaHistory = new bool[] {false} ;
         T00083_A30BR_Behavior_FamilyCancer = new String[] {""} ;
         T00083_n30BR_Behavior_FamilyCancer = new bool[] {false} ;
         T00083_A31BR_Behavior_Menopause = new String[] {""} ;
         T00083_n31BR_Behavior_Menopause = new bool[] {false} ;
         T00083_A32BR_Behavior_MenopauseAge = new short[1] ;
         T00083_n32BR_Behavior_MenopauseAge = new bool[] {false} ;
         T00083_A33BR_Behavior_RawMenopauseAge = new String[] {""} ;
         T00083_n33BR_Behavior_RawMenopauseAge = new bool[] {false} ;
         T00083_A34BR_Behavior_ChildNum = new String[] {""} ;
         T00083_n34BR_Behavior_ChildNum = new bool[] {false} ;
         T00083_A19BR_EncounterID = new long[1] ;
         sMode9 = "";
         T000810_A20BR_BehaviorID = new long[1] ;
         T000811_A20BR_BehaviorID = new long[1] ;
         T00082_A20BR_BehaviorID = new long[1] ;
         T00082_A460BR_Behavior_Smoking_Code = new String[] {""} ;
         T00082_n460BR_Behavior_Smoking_Code = new bool[] {false} ;
         T00082_A462BR_Behavior_Achohol_Code = new String[] {""} ;
         T00082_n462BR_Behavior_Achohol_Code = new bool[] {false} ;
         T00082_A464BR_Behavior_FamilyCaHistory_Code = new String[] {""} ;
         T00082_n464BR_Behavior_FamilyCaHistory_Code = new bool[] {false} ;
         T00082_A465BR_Behavior_Menopause_Code = new String[] {""} ;
         T00082_n465BR_Behavior_Menopause_Code = new bool[] {false} ;
         T00082_A21BR_Behavior_Smoking = new String[] {""} ;
         T00082_n21BR_Behavior_Smoking = new bool[] {false} ;
         T00082_A22BR_Behavior_SmokingTime = new String[] {""} ;
         T00082_n22BR_Behavior_SmokingTime = new bool[] {false} ;
         T00082_A23BR_Behavior_SmokingAmount = new String[] {""} ;
         T00082_n23BR_Behavior_SmokingAmount = new bool[] {false} ;
         T00082_A24BR_Behavior_RawSmokingAmount = new String[] {""} ;
         T00082_n24BR_Behavior_RawSmokingAmount = new bool[] {false} ;
         T00082_A461BR_Behavior_RawSmokingAmount_Code = new String[] {""} ;
         T00082_n461BR_Behavior_RawSmokingAmount_Code = new bool[] {false} ;
         T00082_A25BR_Behavior_Achohol = new String[] {""} ;
         T00082_n25BR_Behavior_Achohol = new bool[] {false} ;
         T00082_A26BR_Behavior_AchoholTime = new String[] {""} ;
         T00082_n26BR_Behavior_AchoholTime = new bool[] {false} ;
         T00082_A27BR_Behavior_AchoholAmount = new String[] {""} ;
         T00082_n27BR_Behavior_AchoholAmount = new bool[] {false} ;
         T00082_A28BR_Behavior_RawAchoholAmount = new String[] {""} ;
         T00082_n28BR_Behavior_RawAchoholAmount = new bool[] {false} ;
         T00082_A463BR_Behavior_RawAchoholAmount_Code = new String[] {""} ;
         T00082_n463BR_Behavior_RawAchoholAmount_Code = new bool[] {false} ;
         T00082_A29BR_Behavior_FamilyCaHistory = new String[] {""} ;
         T00082_n29BR_Behavior_FamilyCaHistory = new bool[] {false} ;
         T00082_A30BR_Behavior_FamilyCancer = new String[] {""} ;
         T00082_n30BR_Behavior_FamilyCancer = new bool[] {false} ;
         T00082_A31BR_Behavior_Menopause = new String[] {""} ;
         T00082_n31BR_Behavior_Menopause = new bool[] {false} ;
         T00082_A32BR_Behavior_MenopauseAge = new short[1] ;
         T00082_n32BR_Behavior_MenopauseAge = new bool[] {false} ;
         T00082_A33BR_Behavior_RawMenopauseAge = new String[] {""} ;
         T00082_n33BR_Behavior_RawMenopauseAge = new bool[] {false} ;
         T00082_A34BR_Behavior_ChildNum = new String[] {""} ;
         T00082_n34BR_Behavior_ChildNum = new bool[] {false} ;
         T00082_A19BR_EncounterID = new long[1] ;
         T000812_A20BR_BehaviorID = new long[1] ;
         T000815_A85BR_Information_ID = new long[1] ;
         T000815_n85BR_Information_ID = new bool[] {false} ;
         T000816_A36BR_Information_PatientNo = new String[] {""} ;
         T000816_n36BR_Information_PatientNo = new bool[] {false} ;
         T000817_A20BR_BehaviorID = new long[1] ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         gxdynajaxctrlcodr = new GeneXus.Utils.GxStringCollection();
         gxdynajaxctrldescr = new GeneXus.Utils.GxStringCollection();
         gxwrpcisep = "";
         T000818_A167XT_DefineCodeID = new long[1] ;
         T000818_A168XT_DefineCodeName = new String[] {""} ;
         T000818_n168XT_DefineCodeName = new bool[] {false} ;
         T000818_A165XT_DefindcodeTypeID = new long[1] ;
         T000818_A432XT_TenantCode = new String[] {""} ;
         T000818_n432XT_TenantCode = new bool[] {false} ;
         T000819_A167XT_DefineCodeID = new long[1] ;
         T000819_A168XT_DefineCodeName = new String[] {""} ;
         T000819_n168XT_DefineCodeName = new bool[] {false} ;
         T000819_A165XT_DefindcodeTypeID = new long[1] ;
         T000819_A432XT_TenantCode = new String[] {""} ;
         T000819_n432XT_TenantCode = new bool[] {false} ;
         GXt_char1 = "";
         isValidOutput = new GxUnknownObjectCollection();
         T000820_A85BR_Information_ID = new long[1] ;
         T000820_n85BR_Information_ID = new bool[] {false} ;
         T000821_A36BR_Information_PatientNo = new String[] {""} ;
         T000821_n36BR_Information_PatientNo = new bool[] {false} ;
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.br_behavior__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_behavior__default(),
            new Object[][] {
                new Object[] {
               T00082_A20BR_BehaviorID, T00082_A460BR_Behavior_Smoking_Code, T00082_n460BR_Behavior_Smoking_Code, T00082_A462BR_Behavior_Achohol_Code, T00082_n462BR_Behavior_Achohol_Code, T00082_A464BR_Behavior_FamilyCaHistory_Code, T00082_n464BR_Behavior_FamilyCaHistory_Code, T00082_A465BR_Behavior_Menopause_Code, T00082_n465BR_Behavior_Menopause_Code, T00082_A21BR_Behavior_Smoking,
               T00082_n21BR_Behavior_Smoking, T00082_A22BR_Behavior_SmokingTime, T00082_n22BR_Behavior_SmokingTime, T00082_A23BR_Behavior_SmokingAmount, T00082_n23BR_Behavior_SmokingAmount, T00082_A24BR_Behavior_RawSmokingAmount, T00082_n24BR_Behavior_RawSmokingAmount, T00082_A461BR_Behavior_RawSmokingAmount_Code, T00082_n461BR_Behavior_RawSmokingAmount_Code, T00082_A25BR_Behavior_Achohol,
               T00082_n25BR_Behavior_Achohol, T00082_A26BR_Behavior_AchoholTime, T00082_n26BR_Behavior_AchoholTime, T00082_A27BR_Behavior_AchoholAmount, T00082_n27BR_Behavior_AchoholAmount, T00082_A28BR_Behavior_RawAchoholAmount, T00082_n28BR_Behavior_RawAchoholAmount, T00082_A463BR_Behavior_RawAchoholAmount_Code, T00082_n463BR_Behavior_RawAchoholAmount_Code, T00082_A29BR_Behavior_FamilyCaHistory,
               T00082_n29BR_Behavior_FamilyCaHistory, T00082_A30BR_Behavior_FamilyCancer, T00082_n30BR_Behavior_FamilyCancer, T00082_A31BR_Behavior_Menopause, T00082_n31BR_Behavior_Menopause, T00082_A32BR_Behavior_MenopauseAge, T00082_n32BR_Behavior_MenopauseAge, T00082_A33BR_Behavior_RawMenopauseAge, T00082_n33BR_Behavior_RawMenopauseAge, T00082_A34BR_Behavior_ChildNum,
               T00082_n34BR_Behavior_ChildNum, T00082_A19BR_EncounterID
               }
               , new Object[] {
               T00083_A20BR_BehaviorID, T00083_A460BR_Behavior_Smoking_Code, T00083_n460BR_Behavior_Smoking_Code, T00083_A462BR_Behavior_Achohol_Code, T00083_n462BR_Behavior_Achohol_Code, T00083_A464BR_Behavior_FamilyCaHistory_Code, T00083_n464BR_Behavior_FamilyCaHistory_Code, T00083_A465BR_Behavior_Menopause_Code, T00083_n465BR_Behavior_Menopause_Code, T00083_A21BR_Behavior_Smoking,
               T00083_n21BR_Behavior_Smoking, T00083_A22BR_Behavior_SmokingTime, T00083_n22BR_Behavior_SmokingTime, T00083_A23BR_Behavior_SmokingAmount, T00083_n23BR_Behavior_SmokingAmount, T00083_A24BR_Behavior_RawSmokingAmount, T00083_n24BR_Behavior_RawSmokingAmount, T00083_A461BR_Behavior_RawSmokingAmount_Code, T00083_n461BR_Behavior_RawSmokingAmount_Code, T00083_A25BR_Behavior_Achohol,
               T00083_n25BR_Behavior_Achohol, T00083_A26BR_Behavior_AchoholTime, T00083_n26BR_Behavior_AchoholTime, T00083_A27BR_Behavior_AchoholAmount, T00083_n27BR_Behavior_AchoholAmount, T00083_A28BR_Behavior_RawAchoholAmount, T00083_n28BR_Behavior_RawAchoholAmount, T00083_A463BR_Behavior_RawAchoholAmount_Code, T00083_n463BR_Behavior_RawAchoholAmount_Code, T00083_A29BR_Behavior_FamilyCaHistory,
               T00083_n29BR_Behavior_FamilyCaHistory, T00083_A30BR_Behavior_FamilyCancer, T00083_n30BR_Behavior_FamilyCancer, T00083_A31BR_Behavior_Menopause, T00083_n31BR_Behavior_Menopause, T00083_A32BR_Behavior_MenopauseAge, T00083_n32BR_Behavior_MenopauseAge, T00083_A33BR_Behavior_RawMenopauseAge, T00083_n33BR_Behavior_RawMenopauseAge, T00083_A34BR_Behavior_ChildNum,
               T00083_n34BR_Behavior_ChildNum, T00083_A19BR_EncounterID
               }
               , new Object[] {
               T00084_A85BR_Information_ID, T00084_n85BR_Information_ID
               }
               , new Object[] {
               T00085_A36BR_Information_PatientNo, T00085_n36BR_Information_PatientNo
               }
               , new Object[] {
               T00086_A85BR_Information_ID, T00086_n85BR_Information_ID, T00086_A20BR_BehaviorID, T00086_A460BR_Behavior_Smoking_Code, T00086_n460BR_Behavior_Smoking_Code, T00086_A462BR_Behavior_Achohol_Code, T00086_n462BR_Behavior_Achohol_Code, T00086_A464BR_Behavior_FamilyCaHistory_Code, T00086_n464BR_Behavior_FamilyCaHistory_Code, T00086_A465BR_Behavior_Menopause_Code,
               T00086_n465BR_Behavior_Menopause_Code, T00086_A36BR_Information_PatientNo, T00086_n36BR_Information_PatientNo, T00086_A21BR_Behavior_Smoking, T00086_n21BR_Behavior_Smoking, T00086_A22BR_Behavior_SmokingTime, T00086_n22BR_Behavior_SmokingTime, T00086_A23BR_Behavior_SmokingAmount, T00086_n23BR_Behavior_SmokingAmount, T00086_A24BR_Behavior_RawSmokingAmount,
               T00086_n24BR_Behavior_RawSmokingAmount, T00086_A461BR_Behavior_RawSmokingAmount_Code, T00086_n461BR_Behavior_RawSmokingAmount_Code, T00086_A25BR_Behavior_Achohol, T00086_n25BR_Behavior_Achohol, T00086_A26BR_Behavior_AchoholTime, T00086_n26BR_Behavior_AchoholTime, T00086_A27BR_Behavior_AchoholAmount, T00086_n27BR_Behavior_AchoholAmount, T00086_A28BR_Behavior_RawAchoholAmount,
               T00086_n28BR_Behavior_RawAchoholAmount, T00086_A463BR_Behavior_RawAchoholAmount_Code, T00086_n463BR_Behavior_RawAchoholAmount_Code, T00086_A29BR_Behavior_FamilyCaHistory, T00086_n29BR_Behavior_FamilyCaHistory, T00086_A30BR_Behavior_FamilyCancer, T00086_n30BR_Behavior_FamilyCancer, T00086_A31BR_Behavior_Menopause, T00086_n31BR_Behavior_Menopause, T00086_A32BR_Behavior_MenopauseAge,
               T00086_n32BR_Behavior_MenopauseAge, T00086_A33BR_Behavior_RawMenopauseAge, T00086_n33BR_Behavior_RawMenopauseAge, T00086_A34BR_Behavior_ChildNum, T00086_n34BR_Behavior_ChildNum, T00086_A19BR_EncounterID
               }
               , new Object[] {
               T00087_A85BR_Information_ID, T00087_n85BR_Information_ID
               }
               , new Object[] {
               T00088_A36BR_Information_PatientNo, T00088_n36BR_Information_PatientNo
               }
               , new Object[] {
               T00089_A20BR_BehaviorID
               }
               , new Object[] {
               T000810_A20BR_BehaviorID
               }
               , new Object[] {
               T000811_A20BR_BehaviorID
               }
               , new Object[] {
               T000812_A20BR_BehaviorID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000815_A85BR_Information_ID, T000815_n85BR_Information_ID
               }
               , new Object[] {
               T000816_A36BR_Information_PatientNo, T000816_n36BR_Information_PatientNo
               }
               , new Object[] {
               T000817_A20BR_BehaviorID
               }
               , new Object[] {
               T000818_A167XT_DefineCodeID, T000818_A168XT_DefineCodeName, T000818_n168XT_DefineCodeName, T000818_A165XT_DefindcodeTypeID, T000818_A432XT_TenantCode, T000818_n432XT_TenantCode
               }
               , new Object[] {
               T000819_A167XT_DefineCodeID, T000819_A168XT_DefineCodeName, T000819_n168XT_DefineCodeName, T000819_A165XT_DefindcodeTypeID, T000819_A432XT_TenantCode, T000819_n432XT_TenantCode
               }
               , new Object[] {
               T000820_A85BR_Information_ID, T000820_n85BR_Information_ID
               }
               , new Object[] {
               T000821_A36BR_Information_PatientNo, T000821_n36BR_Information_PatientNo
               }
            }
         );
      }

      private short Z32BR_Behavior_MenopauseAge ;
      private short GxWebError ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A32BR_Behavior_MenopauseAge ;
      private short GX_JID ;
      private short RcdFound9 ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int trnEnded ;
      private int edtBR_EncounterID_Enabled ;
      private int edtBR_Behavior_SmokingTime_Enabled ;
      private int edtBR_Behavior_SmokingAmount_Enabled ;
      private int edtBR_Behavior_RawSmokingAmount_Enabled ;
      private int edtBR_Behavior_AchoholTime_Enabled ;
      private int edtBR_Behavior_AchoholAmount_Enabled ;
      private int edtBR_Behavior_RawAchoholAmount_Enabled ;
      private int edtBR_Behavior_FamilyCancer_Enabled ;
      private int edtBR_Behavior_MenopauseAge_Enabled ;
      private int edtBR_Behavior_RawMenopauseAge_Enabled ;
      private int edtBR_Behavior_ChildNum_Enabled ;
      private int bttBtntrn_enter_Visible ;
      private int bttBtntrn_enter_Enabled ;
      private int bttBtntrn_cancel_Visible ;
      private int bttBtntrn_delete_Visible ;
      private int bttBtntrn_delete_Enabled ;
      private int edtBR_BehaviorID_Enabled ;
      private int idxLst ;
      private int gxdynajaxindex ;
      private long Z20BR_BehaviorID ;
      private long Z19BR_EncounterID ;
      private long A19BR_EncounterID ;
      private long A85BR_Information_ID ;
      private long A20BR_BehaviorID ;
      private long Z85BR_Information_ID ;
      private String sPrefix ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String GXKey ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtBR_EncounterID_Internalname ;
      private String dynBR_Behavior_Smoking_Internalname ;
      private String dynBR_Behavior_Achohol_Internalname ;
      private String cmbBR_Behavior_FamilyCaHistory_Internalname ;
      private String cmbBR_Behavior_Menopause_Internalname ;
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
      private String edtBR_EncounterID_Jsonclick ;
      private String dynBR_Behavior_Smoking_Jsonclick ;
      private String edtBR_Behavior_SmokingTime_Internalname ;
      private String edtBR_Behavior_SmokingTime_Jsonclick ;
      private String edtBR_Behavior_SmokingAmount_Internalname ;
      private String edtBR_Behavior_SmokingAmount_Jsonclick ;
      private String edtBR_Behavior_RawSmokingAmount_Internalname ;
      private String edtBR_Behavior_RawSmokingAmount_Jsonclick ;
      private String dynBR_Behavior_Achohol_Jsonclick ;
      private String edtBR_Behavior_AchoholTime_Internalname ;
      private String edtBR_Behavior_AchoholTime_Jsonclick ;
      private String edtBR_Behavior_AchoholAmount_Internalname ;
      private String edtBR_Behavior_AchoholAmount_Jsonclick ;
      private String edtBR_Behavior_RawAchoholAmount_Internalname ;
      private String edtBR_Behavior_RawAchoholAmount_Jsonclick ;
      private String cmbBR_Behavior_FamilyCaHistory_Jsonclick ;
      private String edtBR_Behavior_FamilyCancer_Internalname ;
      private String cmbBR_Behavior_Menopause_Jsonclick ;
      private String edtBR_Behavior_MenopauseAge_Internalname ;
      private String edtBR_Behavior_MenopauseAge_Jsonclick ;
      private String edtBR_Behavior_RawMenopauseAge_Internalname ;
      private String edtBR_Behavior_RawMenopauseAge_Jsonclick ;
      private String edtBR_Behavior_ChildNum_Internalname ;
      private String edtBR_Behavior_ChildNum_Jsonclick ;
      private String bttBtntrn_enter_Internalname ;
      private String bttBtntrn_enter_Jsonclick ;
      private String bttBtntrn_cancel_Internalname ;
      private String bttBtntrn_cancel_Jsonclick ;
      private String bttBtntrn_delete_Internalname ;
      private String bttBtntrn_delete_Jsonclick ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String edtBR_BehaviorID_Internalname ;
      private String edtBR_BehaviorID_Jsonclick ;
      private String Gx_mode ;
      private String Dvpanel_tableattributes_Objectcall ;
      private String Dvpanel_tableattributes_Class ;
      private String Dvpanel_tableattributes_Height ;
      private String forbiddenHiddens ;
      private String hsh ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sMode9 ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String gxwrpcisep ;
      private String GXt_char1 ;
      private bool entryPointCalled ;
      private bool n21BR_Behavior_Smoking ;
      private bool n25BR_Behavior_Achohol ;
      private bool n29BR_Behavior_FamilyCaHistory ;
      private bool n31BR_Behavior_Menopause ;
      private bool n85BR_Information_ID ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool Dvpanel_tableattributes_Autowidth ;
      private bool Dvpanel_tableattributes_Autoheight ;
      private bool Dvpanel_tableattributes_Collapsible ;
      private bool Dvpanel_tableattributes_Collapsed ;
      private bool Dvpanel_tableattributes_Showcollapseicon ;
      private bool Dvpanel_tableattributes_Autoscroll ;
      private bool n22BR_Behavior_SmokingTime ;
      private bool n23BR_Behavior_SmokingAmount ;
      private bool n24BR_Behavior_RawSmokingAmount ;
      private bool n26BR_Behavior_AchoholTime ;
      private bool n27BR_Behavior_AchoholAmount ;
      private bool n28BR_Behavior_RawAchoholAmount ;
      private bool n30BR_Behavior_FamilyCancer ;
      private bool n32BR_Behavior_MenopauseAge ;
      private bool n33BR_Behavior_RawMenopauseAge ;
      private bool n34BR_Behavior_ChildNum ;
      private bool n460BR_Behavior_Smoking_Code ;
      private bool n462BR_Behavior_Achohol_Code ;
      private bool n464BR_Behavior_FamilyCaHistory_Code ;
      private bool n465BR_Behavior_Menopause_Code ;
      private bool n461BR_Behavior_RawSmokingAmount_Code ;
      private bool n463BR_Behavior_RawAchoholAmount_Code ;
      private bool n36BR_Information_PatientNo ;
      private bool Dvpanel_tableattributes_Enabled ;
      private bool Dvpanel_tableattributes_Showheader ;
      private bool Dvpanel_tableattributes_Visible ;
      private bool Gx_longc ;
      private bool gxdyncontrolsrefreshing ;
      private String Z460BR_Behavior_Smoking_Code ;
      private String Z462BR_Behavior_Achohol_Code ;
      private String Z464BR_Behavior_FamilyCaHistory_Code ;
      private String Z465BR_Behavior_Menopause_Code ;
      private String Z21BR_Behavior_Smoking ;
      private String Z22BR_Behavior_SmokingTime ;
      private String Z23BR_Behavior_SmokingAmount ;
      private String Z24BR_Behavior_RawSmokingAmount ;
      private String Z461BR_Behavior_RawSmokingAmount_Code ;
      private String Z25BR_Behavior_Achohol ;
      private String Z26BR_Behavior_AchoholTime ;
      private String Z27BR_Behavior_AchoholAmount ;
      private String Z28BR_Behavior_RawAchoholAmount ;
      private String Z463BR_Behavior_RawAchoholAmount_Code ;
      private String Z29BR_Behavior_FamilyCaHistory ;
      private String Z30BR_Behavior_FamilyCancer ;
      private String Z31BR_Behavior_Menopause ;
      private String Z33BR_Behavior_RawMenopauseAge ;
      private String Z34BR_Behavior_ChildNum ;
      private String AV12tCurrentCode ;
      private String A21BR_Behavior_Smoking ;
      private String A25BR_Behavior_Achohol ;
      private String A29BR_Behavior_FamilyCaHistory ;
      private String A31BR_Behavior_Menopause ;
      private String A22BR_Behavior_SmokingTime ;
      private String A23BR_Behavior_SmokingAmount ;
      private String A24BR_Behavior_RawSmokingAmount ;
      private String A26BR_Behavior_AchoholTime ;
      private String A27BR_Behavior_AchoholAmount ;
      private String A28BR_Behavior_RawAchoholAmount ;
      private String A30BR_Behavior_FamilyCancer ;
      private String A33BR_Behavior_RawMenopauseAge ;
      private String A34BR_Behavior_ChildNum ;
      private String A460BR_Behavior_Smoking_Code ;
      private String A462BR_Behavior_Achohol_Code ;
      private String A464BR_Behavior_FamilyCaHistory_Code ;
      private String A465BR_Behavior_Menopause_Code ;
      private String A461BR_Behavior_RawSmokingAmount_Code ;
      private String A463BR_Behavior_RawAchoholAmount_Code ;
      private String A36BR_Information_PatientNo ;
      private String Z36BR_Information_PatientNo ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrlcodr ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrldescr ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXUserControl ucDvpanel_tableattributes ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private GXCombobox dynBR_Behavior_Smoking ;
      private GXCombobox dynBR_Behavior_Achohol ;
      private GXCombobox cmbBR_Behavior_FamilyCaHistory ;
      private GXCombobox cmbBR_Behavior_Menopause ;
      private IDataStoreProvider pr_default ;
      private long[] T00086_A85BR_Information_ID ;
      private bool[] T00086_n85BR_Information_ID ;
      private long[] T00086_A20BR_BehaviorID ;
      private String[] T00086_A460BR_Behavior_Smoking_Code ;
      private bool[] T00086_n460BR_Behavior_Smoking_Code ;
      private String[] T00086_A462BR_Behavior_Achohol_Code ;
      private bool[] T00086_n462BR_Behavior_Achohol_Code ;
      private String[] T00086_A464BR_Behavior_FamilyCaHistory_Code ;
      private bool[] T00086_n464BR_Behavior_FamilyCaHistory_Code ;
      private String[] T00086_A465BR_Behavior_Menopause_Code ;
      private bool[] T00086_n465BR_Behavior_Menopause_Code ;
      private String[] T00086_A36BR_Information_PatientNo ;
      private bool[] T00086_n36BR_Information_PatientNo ;
      private String[] T00086_A21BR_Behavior_Smoking ;
      private bool[] T00086_n21BR_Behavior_Smoking ;
      private String[] T00086_A22BR_Behavior_SmokingTime ;
      private bool[] T00086_n22BR_Behavior_SmokingTime ;
      private String[] T00086_A23BR_Behavior_SmokingAmount ;
      private bool[] T00086_n23BR_Behavior_SmokingAmount ;
      private String[] T00086_A24BR_Behavior_RawSmokingAmount ;
      private bool[] T00086_n24BR_Behavior_RawSmokingAmount ;
      private String[] T00086_A461BR_Behavior_RawSmokingAmount_Code ;
      private bool[] T00086_n461BR_Behavior_RawSmokingAmount_Code ;
      private String[] T00086_A25BR_Behavior_Achohol ;
      private bool[] T00086_n25BR_Behavior_Achohol ;
      private String[] T00086_A26BR_Behavior_AchoholTime ;
      private bool[] T00086_n26BR_Behavior_AchoholTime ;
      private String[] T00086_A27BR_Behavior_AchoholAmount ;
      private bool[] T00086_n27BR_Behavior_AchoholAmount ;
      private String[] T00086_A28BR_Behavior_RawAchoholAmount ;
      private bool[] T00086_n28BR_Behavior_RawAchoholAmount ;
      private String[] T00086_A463BR_Behavior_RawAchoholAmount_Code ;
      private bool[] T00086_n463BR_Behavior_RawAchoholAmount_Code ;
      private String[] T00086_A29BR_Behavior_FamilyCaHistory ;
      private bool[] T00086_n29BR_Behavior_FamilyCaHistory ;
      private String[] T00086_A30BR_Behavior_FamilyCancer ;
      private bool[] T00086_n30BR_Behavior_FamilyCancer ;
      private String[] T00086_A31BR_Behavior_Menopause ;
      private bool[] T00086_n31BR_Behavior_Menopause ;
      private short[] T00086_A32BR_Behavior_MenopauseAge ;
      private bool[] T00086_n32BR_Behavior_MenopauseAge ;
      private String[] T00086_A33BR_Behavior_RawMenopauseAge ;
      private bool[] T00086_n33BR_Behavior_RawMenopauseAge ;
      private String[] T00086_A34BR_Behavior_ChildNum ;
      private bool[] T00086_n34BR_Behavior_ChildNum ;
      private long[] T00086_A19BR_EncounterID ;
      private long[] T00084_A85BR_Information_ID ;
      private bool[] T00084_n85BR_Information_ID ;
      private String[] T00085_A36BR_Information_PatientNo ;
      private bool[] T00085_n36BR_Information_PatientNo ;
      private long[] T00087_A85BR_Information_ID ;
      private bool[] T00087_n85BR_Information_ID ;
      private String[] T00088_A36BR_Information_PatientNo ;
      private bool[] T00088_n36BR_Information_PatientNo ;
      private long[] T00089_A20BR_BehaviorID ;
      private long[] T00083_A20BR_BehaviorID ;
      private String[] T00083_A460BR_Behavior_Smoking_Code ;
      private bool[] T00083_n460BR_Behavior_Smoking_Code ;
      private String[] T00083_A462BR_Behavior_Achohol_Code ;
      private bool[] T00083_n462BR_Behavior_Achohol_Code ;
      private String[] T00083_A464BR_Behavior_FamilyCaHistory_Code ;
      private bool[] T00083_n464BR_Behavior_FamilyCaHistory_Code ;
      private String[] T00083_A465BR_Behavior_Menopause_Code ;
      private bool[] T00083_n465BR_Behavior_Menopause_Code ;
      private String[] T00083_A21BR_Behavior_Smoking ;
      private bool[] T00083_n21BR_Behavior_Smoking ;
      private String[] T00083_A22BR_Behavior_SmokingTime ;
      private bool[] T00083_n22BR_Behavior_SmokingTime ;
      private String[] T00083_A23BR_Behavior_SmokingAmount ;
      private bool[] T00083_n23BR_Behavior_SmokingAmount ;
      private String[] T00083_A24BR_Behavior_RawSmokingAmount ;
      private bool[] T00083_n24BR_Behavior_RawSmokingAmount ;
      private String[] T00083_A461BR_Behavior_RawSmokingAmount_Code ;
      private bool[] T00083_n461BR_Behavior_RawSmokingAmount_Code ;
      private String[] T00083_A25BR_Behavior_Achohol ;
      private bool[] T00083_n25BR_Behavior_Achohol ;
      private String[] T00083_A26BR_Behavior_AchoholTime ;
      private bool[] T00083_n26BR_Behavior_AchoholTime ;
      private String[] T00083_A27BR_Behavior_AchoholAmount ;
      private bool[] T00083_n27BR_Behavior_AchoholAmount ;
      private String[] T00083_A28BR_Behavior_RawAchoholAmount ;
      private bool[] T00083_n28BR_Behavior_RawAchoholAmount ;
      private String[] T00083_A463BR_Behavior_RawAchoholAmount_Code ;
      private bool[] T00083_n463BR_Behavior_RawAchoholAmount_Code ;
      private String[] T00083_A29BR_Behavior_FamilyCaHistory ;
      private bool[] T00083_n29BR_Behavior_FamilyCaHistory ;
      private String[] T00083_A30BR_Behavior_FamilyCancer ;
      private bool[] T00083_n30BR_Behavior_FamilyCancer ;
      private String[] T00083_A31BR_Behavior_Menopause ;
      private bool[] T00083_n31BR_Behavior_Menopause ;
      private short[] T00083_A32BR_Behavior_MenopauseAge ;
      private bool[] T00083_n32BR_Behavior_MenopauseAge ;
      private String[] T00083_A33BR_Behavior_RawMenopauseAge ;
      private bool[] T00083_n33BR_Behavior_RawMenopauseAge ;
      private String[] T00083_A34BR_Behavior_ChildNum ;
      private bool[] T00083_n34BR_Behavior_ChildNum ;
      private long[] T00083_A19BR_EncounterID ;
      private long[] T000810_A20BR_BehaviorID ;
      private long[] T000811_A20BR_BehaviorID ;
      private long[] T00082_A20BR_BehaviorID ;
      private String[] T00082_A460BR_Behavior_Smoking_Code ;
      private bool[] T00082_n460BR_Behavior_Smoking_Code ;
      private String[] T00082_A462BR_Behavior_Achohol_Code ;
      private bool[] T00082_n462BR_Behavior_Achohol_Code ;
      private String[] T00082_A464BR_Behavior_FamilyCaHistory_Code ;
      private bool[] T00082_n464BR_Behavior_FamilyCaHistory_Code ;
      private String[] T00082_A465BR_Behavior_Menopause_Code ;
      private bool[] T00082_n465BR_Behavior_Menopause_Code ;
      private String[] T00082_A21BR_Behavior_Smoking ;
      private bool[] T00082_n21BR_Behavior_Smoking ;
      private String[] T00082_A22BR_Behavior_SmokingTime ;
      private bool[] T00082_n22BR_Behavior_SmokingTime ;
      private String[] T00082_A23BR_Behavior_SmokingAmount ;
      private bool[] T00082_n23BR_Behavior_SmokingAmount ;
      private String[] T00082_A24BR_Behavior_RawSmokingAmount ;
      private bool[] T00082_n24BR_Behavior_RawSmokingAmount ;
      private String[] T00082_A461BR_Behavior_RawSmokingAmount_Code ;
      private bool[] T00082_n461BR_Behavior_RawSmokingAmount_Code ;
      private String[] T00082_A25BR_Behavior_Achohol ;
      private bool[] T00082_n25BR_Behavior_Achohol ;
      private String[] T00082_A26BR_Behavior_AchoholTime ;
      private bool[] T00082_n26BR_Behavior_AchoholTime ;
      private String[] T00082_A27BR_Behavior_AchoholAmount ;
      private bool[] T00082_n27BR_Behavior_AchoholAmount ;
      private String[] T00082_A28BR_Behavior_RawAchoholAmount ;
      private bool[] T00082_n28BR_Behavior_RawAchoholAmount ;
      private String[] T00082_A463BR_Behavior_RawAchoholAmount_Code ;
      private bool[] T00082_n463BR_Behavior_RawAchoholAmount_Code ;
      private String[] T00082_A29BR_Behavior_FamilyCaHistory ;
      private bool[] T00082_n29BR_Behavior_FamilyCaHistory ;
      private String[] T00082_A30BR_Behavior_FamilyCancer ;
      private bool[] T00082_n30BR_Behavior_FamilyCancer ;
      private String[] T00082_A31BR_Behavior_Menopause ;
      private bool[] T00082_n31BR_Behavior_Menopause ;
      private short[] T00082_A32BR_Behavior_MenopauseAge ;
      private bool[] T00082_n32BR_Behavior_MenopauseAge ;
      private String[] T00082_A33BR_Behavior_RawMenopauseAge ;
      private bool[] T00082_n33BR_Behavior_RawMenopauseAge ;
      private String[] T00082_A34BR_Behavior_ChildNum ;
      private bool[] T00082_n34BR_Behavior_ChildNum ;
      private long[] T00082_A19BR_EncounterID ;
      private long[] T000812_A20BR_BehaviorID ;
      private long[] T000815_A85BR_Information_ID ;
      private bool[] T000815_n85BR_Information_ID ;
      private String[] T000816_A36BR_Information_PatientNo ;
      private bool[] T000816_n36BR_Information_PatientNo ;
      private long[] T000817_A20BR_BehaviorID ;
      private long[] T000818_A167XT_DefineCodeID ;
      private String[] T000818_A168XT_DefineCodeName ;
      private bool[] T000818_n168XT_DefineCodeName ;
      private long[] T000818_A165XT_DefindcodeTypeID ;
      private String[] T000818_A432XT_TenantCode ;
      private bool[] T000818_n432XT_TenantCode ;
      private long[] T000819_A167XT_DefineCodeID ;
      private String[] T000819_A168XT_DefineCodeName ;
      private bool[] T000819_n168XT_DefineCodeName ;
      private long[] T000819_A165XT_DefindcodeTypeID ;
      private String[] T000819_A432XT_TenantCode ;
      private bool[] T000819_n432XT_TenantCode ;
      private long[] T000820_A85BR_Information_ID ;
      private bool[] T000820_n85BR_Information_ID ;
      private String[] T000821_A36BR_Information_PatientNo ;
      private bool[] T000821_n36BR_Information_PatientNo ;
      private IDataStoreProvider pr_datastore1 ;
      private GXWebForm Form ;
   }

   public class br_behavior__datastore1 : DataStoreHelperBase, IDataStoreHelper
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

 public class br_behavior__default : DataStoreHelperBase, IDataStoreHelper
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
       ,new ForEachCursor(def[10])
       ,new UpdateCursor(def[11])
       ,new UpdateCursor(def[12])
       ,new ForEachCursor(def[13])
       ,new ForEachCursor(def[14])
       ,new ForEachCursor(def[15])
       ,new ForEachCursor(def[16])
       ,new ForEachCursor(def[17])
       ,new ForEachCursor(def[18])
       ,new ForEachCursor(def[19])
     };
  }

  private static CursorDef[] def;
  private void cursorDefinitions( )
  {
     if ( def == null )
     {
        Object[] prmT00086 ;
        prmT00086 = new Object[] {
        new Object[] {"@BR_BehaviorID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00084 ;
        prmT00084 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00085 ;
        prmT00085 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00087 ;
        prmT00087 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00088 ;
        prmT00088 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00089 ;
        prmT00089 = new Object[] {
        new Object[] {"@BR_BehaviorID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00083 ;
        prmT00083 = new Object[] {
        new Object[] {"@BR_BehaviorID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000810 ;
        prmT000810 = new Object[] {
        new Object[] {"@BR_BehaviorID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000811 ;
        prmT000811 = new Object[] {
        new Object[] {"@BR_BehaviorID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00082 ;
        prmT00082 = new Object[] {
        new Object[] {"@BR_BehaviorID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000812 ;
        prmT000812 = new Object[] {
        new Object[] {"@BR_Behavior_Smoking_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Behavior_Achohol_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Behavior_FamilyCaHistory_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Behavior_Menopause_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Behavior_Smoking",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Behavior_SmokingTime",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Behavior_SmokingAmount",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Behavior_RawSmokingAmount",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Behavior_RawSmokingAmount_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Behavior_Achohol",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Behavior_AchoholTime",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Behavior_AchoholAmount",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Behavior_RawAchoholAmount",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Behavior_RawAchoholAmount_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Behavior_FamilyCaHistory",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Behavior_FamilyCancer",SqlDbType.NVarChar,200,0} ,
        new Object[] {"@BR_Behavior_Menopause",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Behavior_MenopauseAge",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@BR_Behavior_RawMenopauseAge",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Behavior_ChildNum",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000813 ;
        prmT000813 = new Object[] {
        new Object[] {"@BR_Behavior_Smoking_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Behavior_Achohol_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Behavior_FamilyCaHistory_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Behavior_Menopause_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Behavior_Smoking",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Behavior_SmokingTime",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Behavior_SmokingAmount",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Behavior_RawSmokingAmount",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Behavior_RawSmokingAmount_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Behavior_Achohol",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Behavior_AchoholTime",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Behavior_AchoholAmount",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Behavior_RawAchoholAmount",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Behavior_RawAchoholAmount_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Behavior_FamilyCaHistory",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Behavior_FamilyCancer",SqlDbType.NVarChar,200,0} ,
        new Object[] {"@BR_Behavior_Menopause",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Behavior_MenopauseAge",SqlDbType.SmallInt,4,0} ,
        new Object[] {"@BR_Behavior_RawMenopauseAge",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Behavior_ChildNum",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@BR_BehaviorID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000814 ;
        prmT000814 = new Object[] {
        new Object[] {"@BR_BehaviorID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000815 ;
        prmT000815 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000816 ;
        prmT000816 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000817 ;
        prmT000817 = new Object[] {
        } ;
        Object[] prmT000818 ;
        prmT000818 = new Object[] {
        new Object[] {"@AV12tCurrentCode",SqlDbType.NVarChar,40,0}
        } ;
        Object[] prmT000819 ;
        prmT000819 = new Object[] {
        new Object[] {"@AV12tCurrentCode",SqlDbType.NVarChar,40,0}
        } ;
        Object[] prmT000820 ;
        prmT000820 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000821 ;
        prmT000821 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("T00082", "SELECT [BR_BehaviorID], [BR_Behavior_Smoking_Code], [BR_Behavior_Achohol_Code], [BR_Behavior_FamilyCaHistory_Code], [BR_Behavior_Menopause_Code], [BR_Behavior_Smoking], [BR_Behavior_SmokingTime], [BR_Behavior_SmokingAmount], [BR_Behavior_RawSmokingAmount], [BR_Behavior_RawSmokingAmount_Code], [BR_Behavior_Achohol], [BR_Behavior_AchoholTime], [BR_Behavior_AchoholAmount], [BR_Behavior_RawAchoholAmount], [BR_Behavior_RawAchoholAmount_Code], [BR_Behavior_FamilyCaHistory], [BR_Behavior_FamilyCancer], [BR_Behavior_Menopause], [BR_Behavior_MenopauseAge], [BR_Behavior_RawMenopauseAge], [BR_Behavior_ChildNum], [BR_EncounterID] FROM [BR_Behavior] WITH (UPDLOCK) WHERE [BR_BehaviorID] = @BR_BehaviorID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00082,1,0,true,false )
           ,new CursorDef("T00083", "SELECT [BR_BehaviorID], [BR_Behavior_Smoking_Code], [BR_Behavior_Achohol_Code], [BR_Behavior_FamilyCaHistory_Code], [BR_Behavior_Menopause_Code], [BR_Behavior_Smoking], [BR_Behavior_SmokingTime], [BR_Behavior_SmokingAmount], [BR_Behavior_RawSmokingAmount], [BR_Behavior_RawSmokingAmount_Code], [BR_Behavior_Achohol], [BR_Behavior_AchoholTime], [BR_Behavior_AchoholAmount], [BR_Behavior_RawAchoholAmount], [BR_Behavior_RawAchoholAmount_Code], [BR_Behavior_FamilyCaHistory], [BR_Behavior_FamilyCancer], [BR_Behavior_Menopause], [BR_Behavior_MenopauseAge], [BR_Behavior_RawMenopauseAge], [BR_Behavior_ChildNum], [BR_EncounterID] FROM [BR_Behavior] WITH (NOLOCK) WHERE [BR_BehaviorID] = @BR_BehaviorID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00083,1,0,true,false )
           ,new CursorDef("T00084", "SELECT [BR_Information_ID] FROM [BR_Encounter] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00084,1,0,true,false )
           ,new CursorDef("T00085", "SELECT [BR_Information_PatientNo] FROM [BR_Information] WITH (NOLOCK) WHERE [BR_Information_ID] = @BR_Information_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00085,1,0,true,false )
           ,new CursorDef("T00086", "SELECT T2.[BR_Information_ID], TM1.[BR_BehaviorID], TM1.[BR_Behavior_Smoking_Code], TM1.[BR_Behavior_Achohol_Code], TM1.[BR_Behavior_FamilyCaHistory_Code], TM1.[BR_Behavior_Menopause_Code], T3.[BR_Information_PatientNo], TM1.[BR_Behavior_Smoking], TM1.[BR_Behavior_SmokingTime], TM1.[BR_Behavior_SmokingAmount], TM1.[BR_Behavior_RawSmokingAmount], TM1.[BR_Behavior_RawSmokingAmount_Code], TM1.[BR_Behavior_Achohol], TM1.[BR_Behavior_AchoholTime], TM1.[BR_Behavior_AchoholAmount], TM1.[BR_Behavior_RawAchoholAmount], TM1.[BR_Behavior_RawAchoholAmount_Code], TM1.[BR_Behavior_FamilyCaHistory], TM1.[BR_Behavior_FamilyCancer], TM1.[BR_Behavior_Menopause], TM1.[BR_Behavior_MenopauseAge], TM1.[BR_Behavior_RawMenopauseAge], TM1.[BR_Behavior_ChildNum], TM1.[BR_EncounterID] FROM (([BR_Behavior] TM1 WITH (NOLOCK) INNER JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = TM1.[BR_EncounterID]) LEFT JOIN [BR_Information] T3 WITH (NOLOCK) ON T3.[BR_Information_ID] = T2.[BR_Information_ID]) WHERE TM1.[BR_BehaviorID] = @BR_BehaviorID ORDER BY TM1.[BR_BehaviorID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00086,100,0,true,false )
           ,new CursorDef("T00087", "SELECT [BR_Information_ID] FROM [BR_Encounter] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00087,1,0,true,false )
           ,new CursorDef("T00088", "SELECT [BR_Information_PatientNo] FROM [BR_Information] WITH (NOLOCK) WHERE [BR_Information_ID] = @BR_Information_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00088,1,0,true,false )
           ,new CursorDef("T00089", "SELECT [BR_BehaviorID] FROM [BR_Behavior] WITH (NOLOCK) WHERE [BR_BehaviorID] = @BR_BehaviorID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00089,1,0,true,false )
           ,new CursorDef("T000810", "SELECT TOP 1 [BR_BehaviorID] FROM [BR_Behavior] WITH (NOLOCK) WHERE ( [BR_BehaviorID] > @BR_BehaviorID) ORDER BY [BR_BehaviorID]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000810,1,0,true,true )
           ,new CursorDef("T000811", "SELECT TOP 1 [BR_BehaviorID] FROM [BR_Behavior] WITH (NOLOCK) WHERE ( [BR_BehaviorID] < @BR_BehaviorID) ORDER BY [BR_BehaviorID] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000811,1,0,true,true )
           ,new CursorDef("T000812", "INSERT INTO [BR_Behavior]([BR_Behavior_Smoking_Code], [BR_Behavior_Achohol_Code], [BR_Behavior_FamilyCaHistory_Code], [BR_Behavior_Menopause_Code], [BR_Behavior_Smoking], [BR_Behavior_SmokingTime], [BR_Behavior_SmokingAmount], [BR_Behavior_RawSmokingAmount], [BR_Behavior_RawSmokingAmount_Code], [BR_Behavior_Achohol], [BR_Behavior_AchoholTime], [BR_Behavior_AchoholAmount], [BR_Behavior_RawAchoholAmount], [BR_Behavior_RawAchoholAmount_Code], [BR_Behavior_FamilyCaHistory], [BR_Behavior_FamilyCancer], [BR_Behavior_Menopause], [BR_Behavior_MenopauseAge], [BR_Behavior_RawMenopauseAge], [BR_Behavior_ChildNum], [BR_EncounterID]) VALUES(@BR_Behavior_Smoking_Code, @BR_Behavior_Achohol_Code, @BR_Behavior_FamilyCaHistory_Code, @BR_Behavior_Menopause_Code, @BR_Behavior_Smoking, @BR_Behavior_SmokingTime, @BR_Behavior_SmokingAmount, @BR_Behavior_RawSmokingAmount, @BR_Behavior_RawSmokingAmount_Code, @BR_Behavior_Achohol, @BR_Behavior_AchoholTime, @BR_Behavior_AchoholAmount, @BR_Behavior_RawAchoholAmount, @BR_Behavior_RawAchoholAmount_Code, @BR_Behavior_FamilyCaHistory, @BR_Behavior_FamilyCancer, @BR_Behavior_Menopause, @BR_Behavior_MenopauseAge, @BR_Behavior_RawMenopauseAge, @BR_Behavior_ChildNum, @BR_EncounterID); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmT000812)
           ,new CursorDef("T000813", "UPDATE [BR_Behavior] SET [BR_Behavior_Smoking_Code]=@BR_Behavior_Smoking_Code, [BR_Behavior_Achohol_Code]=@BR_Behavior_Achohol_Code, [BR_Behavior_FamilyCaHistory_Code]=@BR_Behavior_FamilyCaHistory_Code, [BR_Behavior_Menopause_Code]=@BR_Behavior_Menopause_Code, [BR_Behavior_Smoking]=@BR_Behavior_Smoking, [BR_Behavior_SmokingTime]=@BR_Behavior_SmokingTime, [BR_Behavior_SmokingAmount]=@BR_Behavior_SmokingAmount, [BR_Behavior_RawSmokingAmount]=@BR_Behavior_RawSmokingAmount, [BR_Behavior_RawSmokingAmount_Code]=@BR_Behavior_RawSmokingAmount_Code, [BR_Behavior_Achohol]=@BR_Behavior_Achohol, [BR_Behavior_AchoholTime]=@BR_Behavior_AchoholTime, [BR_Behavior_AchoholAmount]=@BR_Behavior_AchoholAmount, [BR_Behavior_RawAchoholAmount]=@BR_Behavior_RawAchoholAmount, [BR_Behavior_RawAchoholAmount_Code]=@BR_Behavior_RawAchoholAmount_Code, [BR_Behavior_FamilyCaHistory]=@BR_Behavior_FamilyCaHistory, [BR_Behavior_FamilyCancer]=@BR_Behavior_FamilyCancer, [BR_Behavior_Menopause]=@BR_Behavior_Menopause, [BR_Behavior_MenopauseAge]=@BR_Behavior_MenopauseAge, [BR_Behavior_RawMenopauseAge]=@BR_Behavior_RawMenopauseAge, [BR_Behavior_ChildNum]=@BR_Behavior_ChildNum, [BR_EncounterID]=@BR_EncounterID  WHERE [BR_BehaviorID] = @BR_BehaviorID", GxErrorMask.GX_NOMASK,prmT000813)
           ,new CursorDef("T000814", "DELETE FROM [BR_Behavior]  WHERE [BR_BehaviorID] = @BR_BehaviorID", GxErrorMask.GX_NOMASK,prmT000814)
           ,new CursorDef("T000815", "SELECT [BR_Information_ID] FROM [BR_Encounter] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000815,1,0,true,false )
           ,new CursorDef("T000816", "SELECT [BR_Information_PatientNo] FROM [BR_Information] WITH (NOLOCK) WHERE [BR_Information_ID] = @BR_Information_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000816,1,0,true,false )
           ,new CursorDef("T000817", "SELECT [BR_BehaviorID] FROM [BR_Behavior] WITH (NOLOCK) ORDER BY [BR_BehaviorID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000817,100,0,true,false )
           ,new CursorDef("T000818", "SELECT [XT_DefineCodeID], [XT_DefineCodeName], [XT_DefindcodeTypeID], [XT_TenantCode] FROM [XT_DefineCode] WITH (NOLOCK) WHERE ([XT_DefindcodeTypeID] = 12) AND ([XT_TenantCode] = @AV12tCurrentCode) ",true, GxErrorMask.GX_NOMASK, false, this,prmT000818,0,0,true,false )
           ,new CursorDef("T000819", "SELECT [XT_DefineCodeID], [XT_DefineCodeName], [XT_DefindcodeTypeID], [XT_TenantCode] FROM [XT_DefineCode] WITH (NOLOCK) WHERE ([XT_DefindcodeTypeID] = 14) AND ([XT_TenantCode] = @AV12tCurrentCode) ",true, GxErrorMask.GX_NOMASK, false, this,prmT000819,0,0,true,false )
           ,new CursorDef("T000820", "SELECT [BR_Information_ID] FROM [BR_Encounter] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000820,1,0,true,false )
           ,new CursorDef("T000821", "SELECT [BR_Information_PatientNo] FROM [BR_Information] WITH (NOLOCK) WHERE [BR_Information_ID] = @BR_Information_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000821,1,0,true,false )
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
              ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              ((String[]) buf[13])[0] = rslt.getVarchar(8) ;
              ((bool[]) buf[14])[0] = rslt.wasNull(8);
              ((String[]) buf[15])[0] = rslt.getVarchar(9) ;
              ((bool[]) buf[16])[0] = rslt.wasNull(9);
              ((String[]) buf[17])[0] = rslt.getVarchar(10) ;
              ((bool[]) buf[18])[0] = rslt.wasNull(10);
              ((String[]) buf[19])[0] = rslt.getVarchar(11) ;
              ((bool[]) buf[20])[0] = rslt.wasNull(11);
              ((String[]) buf[21])[0] = rslt.getVarchar(12) ;
              ((bool[]) buf[22])[0] = rslt.wasNull(12);
              ((String[]) buf[23])[0] = rslt.getVarchar(13) ;
              ((bool[]) buf[24])[0] = rslt.wasNull(13);
              ((String[]) buf[25])[0] = rslt.getVarchar(14) ;
              ((bool[]) buf[26])[0] = rslt.wasNull(14);
              ((String[]) buf[27])[0] = rslt.getVarchar(15) ;
              ((bool[]) buf[28])[0] = rslt.wasNull(15);
              ((String[]) buf[29])[0] = rslt.getVarchar(16) ;
              ((bool[]) buf[30])[0] = rslt.wasNull(16);
              ((String[]) buf[31])[0] = rslt.getVarchar(17) ;
              ((bool[]) buf[32])[0] = rslt.wasNull(17);
              ((String[]) buf[33])[0] = rslt.getVarchar(18) ;
              ((bool[]) buf[34])[0] = rslt.wasNull(18);
              ((short[]) buf[35])[0] = rslt.getShort(19) ;
              ((bool[]) buf[36])[0] = rslt.wasNull(19);
              ((String[]) buf[37])[0] = rslt.getVarchar(20) ;
              ((bool[]) buf[38])[0] = rslt.wasNull(20);
              ((String[]) buf[39])[0] = rslt.getVarchar(21) ;
              ((bool[]) buf[40])[0] = rslt.wasNull(21);
              ((long[]) buf[41])[0] = rslt.getLong(22) ;
              return;
           case 1 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              ((String[]) buf[13])[0] = rslt.getVarchar(8) ;
              ((bool[]) buf[14])[0] = rslt.wasNull(8);
              ((String[]) buf[15])[0] = rslt.getVarchar(9) ;
              ((bool[]) buf[16])[0] = rslt.wasNull(9);
              ((String[]) buf[17])[0] = rslt.getVarchar(10) ;
              ((bool[]) buf[18])[0] = rslt.wasNull(10);
              ((String[]) buf[19])[0] = rslt.getVarchar(11) ;
              ((bool[]) buf[20])[0] = rslt.wasNull(11);
              ((String[]) buf[21])[0] = rslt.getVarchar(12) ;
              ((bool[]) buf[22])[0] = rslt.wasNull(12);
              ((String[]) buf[23])[0] = rslt.getVarchar(13) ;
              ((bool[]) buf[24])[0] = rslt.wasNull(13);
              ((String[]) buf[25])[0] = rslt.getVarchar(14) ;
              ((bool[]) buf[26])[0] = rslt.wasNull(14);
              ((String[]) buf[27])[0] = rslt.getVarchar(15) ;
              ((bool[]) buf[28])[0] = rslt.wasNull(15);
              ((String[]) buf[29])[0] = rslt.getVarchar(16) ;
              ((bool[]) buf[30])[0] = rslt.wasNull(16);
              ((String[]) buf[31])[0] = rslt.getVarchar(17) ;
              ((bool[]) buf[32])[0] = rslt.wasNull(17);
              ((String[]) buf[33])[0] = rslt.getVarchar(18) ;
              ((bool[]) buf[34])[0] = rslt.wasNull(18);
              ((short[]) buf[35])[0] = rslt.getShort(19) ;
              ((bool[]) buf[36])[0] = rslt.wasNull(19);
              ((String[]) buf[37])[0] = rslt.getVarchar(20) ;
              ((bool[]) buf[38])[0] = rslt.wasNull(20);
              ((String[]) buf[39])[0] = rslt.getVarchar(21) ;
              ((bool[]) buf[40])[0] = rslt.wasNull(21);
              ((long[]) buf[41])[0] = rslt.getLong(22) ;
              return;
           case 2 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((bool[]) buf[1])[0] = rslt.wasNull(1);
              return;
           case 3 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              ((bool[]) buf[1])[0] = rslt.wasNull(1);
              return;
           case 4 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((bool[]) buf[1])[0] = rslt.wasNull(1);
              ((long[]) buf[2])[0] = rslt.getLong(2) ;
              ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              ((String[]) buf[13])[0] = rslt.getVarchar(8) ;
              ((bool[]) buf[14])[0] = rslt.wasNull(8);
              ((String[]) buf[15])[0] = rslt.getVarchar(9) ;
              ((bool[]) buf[16])[0] = rslt.wasNull(9);
              ((String[]) buf[17])[0] = rslt.getVarchar(10) ;
              ((bool[]) buf[18])[0] = rslt.wasNull(10);
              ((String[]) buf[19])[0] = rslt.getVarchar(11) ;
              ((bool[]) buf[20])[0] = rslt.wasNull(11);
              ((String[]) buf[21])[0] = rslt.getVarchar(12) ;
              ((bool[]) buf[22])[0] = rslt.wasNull(12);
              ((String[]) buf[23])[0] = rslt.getVarchar(13) ;
              ((bool[]) buf[24])[0] = rslt.wasNull(13);
              ((String[]) buf[25])[0] = rslt.getVarchar(14) ;
              ((bool[]) buf[26])[0] = rslt.wasNull(14);
              ((String[]) buf[27])[0] = rslt.getVarchar(15) ;
              ((bool[]) buf[28])[0] = rslt.wasNull(15);
              ((String[]) buf[29])[0] = rslt.getVarchar(16) ;
              ((bool[]) buf[30])[0] = rslt.wasNull(16);
              ((String[]) buf[31])[0] = rslt.getVarchar(17) ;
              ((bool[]) buf[32])[0] = rslt.wasNull(17);
              ((String[]) buf[33])[0] = rslt.getVarchar(18) ;
              ((bool[]) buf[34])[0] = rslt.wasNull(18);
              ((String[]) buf[35])[0] = rslt.getVarchar(19) ;
              ((bool[]) buf[36])[0] = rslt.wasNull(19);
              ((String[]) buf[37])[0] = rslt.getVarchar(20) ;
              ((bool[]) buf[38])[0] = rslt.wasNull(20);
              ((short[]) buf[39])[0] = rslt.getShort(21) ;
              ((bool[]) buf[40])[0] = rslt.wasNull(21);
              ((String[]) buf[41])[0] = rslt.getVarchar(22) ;
              ((bool[]) buf[42])[0] = rslt.wasNull(22);
              ((String[]) buf[43])[0] = rslt.getVarchar(23) ;
              ((bool[]) buf[44])[0] = rslt.wasNull(23);
              ((long[]) buf[45])[0] = rslt.getLong(24) ;
              return;
           case 5 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((bool[]) buf[1])[0] = rslt.wasNull(1);
              return;
           case 6 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              ((bool[]) buf[1])[0] = rslt.wasNull(1);
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
           case 10 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 13 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((bool[]) buf[1])[0] = rslt.wasNull(1);
              return;
           case 14 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              ((bool[]) buf[1])[0] = rslt.wasNull(1);
              return;
           case 15 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 16 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((long[]) buf[3])[0] = rslt.getLong(3) ;
              ((String[]) buf[4])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[5])[0] = rslt.wasNull(4);
              return;
           case 17 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((long[]) buf[3])[0] = rslt.getLong(3) ;
              ((String[]) buf[4])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[5])[0] = rslt.wasNull(4);
              return;
           case 18 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((bool[]) buf[1])[0] = rslt.wasNull(1);
              return;
           case 19 :
              ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
              ((bool[]) buf[1])[0] = rslt.wasNull(1);
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
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
              }
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
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
              }
              return;
           case 7 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 8 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 9 :
              stmt.SetParameter(1, (long)parms[0]);
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
              if ( (bool)parms[2] )
              {
                 stmt.setNull( 2 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(2, (String)parms[3]);
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
                 stmt.setNull( 5 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(5, (String)parms[9]);
              }
              if ( (bool)parms[10] )
              {
                 stmt.setNull( 6 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(6, (String)parms[11]);
              }
              if ( (bool)parms[12] )
              {
                 stmt.setNull( 7 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(7, (String)parms[13]);
              }
              if ( (bool)parms[14] )
              {
                 stmt.setNull( 8 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(8, (String)parms[15]);
              }
              if ( (bool)parms[16] )
              {
                 stmt.setNull( 9 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(9, (String)parms[17]);
              }
              if ( (bool)parms[18] )
              {
                 stmt.setNull( 10 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(10, (String)parms[19]);
              }
              if ( (bool)parms[20] )
              {
                 stmt.setNull( 11 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(11, (String)parms[21]);
              }
              if ( (bool)parms[22] )
              {
                 stmt.setNull( 12 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(12, (String)parms[23]);
              }
              if ( (bool)parms[24] )
              {
                 stmt.setNull( 13 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(13, (String)parms[25]);
              }
              if ( (bool)parms[26] )
              {
                 stmt.setNull( 14 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(14, (String)parms[27]);
              }
              if ( (bool)parms[28] )
              {
                 stmt.setNull( 15 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(15, (String)parms[29]);
              }
              if ( (bool)parms[30] )
              {
                 stmt.setNull( 16 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(16, (String)parms[31]);
              }
              if ( (bool)parms[32] )
              {
                 stmt.setNull( 17 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(17, (String)parms[33]);
              }
              if ( (bool)parms[34] )
              {
                 stmt.setNull( 18 , SqlDbType.SmallInt );
              }
              else
              {
                 stmt.SetParameter(18, (short)parms[35]);
              }
              if ( (bool)parms[36] )
              {
                 stmt.setNull( 19 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(19, (String)parms[37]);
              }
              if ( (bool)parms[38] )
              {
                 stmt.setNull( 20 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(20, (String)parms[39]);
              }
              stmt.SetParameter(21, (long)parms[40]);
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
              if ( (bool)parms[2] )
              {
                 stmt.setNull( 2 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(2, (String)parms[3]);
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
                 stmt.setNull( 5 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(5, (String)parms[9]);
              }
              if ( (bool)parms[10] )
              {
                 stmt.setNull( 6 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(6, (String)parms[11]);
              }
              if ( (bool)parms[12] )
              {
                 stmt.setNull( 7 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(7, (String)parms[13]);
              }
              if ( (bool)parms[14] )
              {
                 stmt.setNull( 8 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(8, (String)parms[15]);
              }
              if ( (bool)parms[16] )
              {
                 stmt.setNull( 9 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(9, (String)parms[17]);
              }
              if ( (bool)parms[18] )
              {
                 stmt.setNull( 10 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(10, (String)parms[19]);
              }
              if ( (bool)parms[20] )
              {
                 stmt.setNull( 11 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(11, (String)parms[21]);
              }
              if ( (bool)parms[22] )
              {
                 stmt.setNull( 12 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(12, (String)parms[23]);
              }
              if ( (bool)parms[24] )
              {
                 stmt.setNull( 13 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(13, (String)parms[25]);
              }
              if ( (bool)parms[26] )
              {
                 stmt.setNull( 14 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(14, (String)parms[27]);
              }
              if ( (bool)parms[28] )
              {
                 stmt.setNull( 15 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(15, (String)parms[29]);
              }
              if ( (bool)parms[30] )
              {
                 stmt.setNull( 16 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(16, (String)parms[31]);
              }
              if ( (bool)parms[32] )
              {
                 stmt.setNull( 17 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(17, (String)parms[33]);
              }
              if ( (bool)parms[34] )
              {
                 stmt.setNull( 18 , SqlDbType.SmallInt );
              }
              else
              {
                 stmt.SetParameter(18, (short)parms[35]);
              }
              if ( (bool)parms[36] )
              {
                 stmt.setNull( 19 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(19, (String)parms[37]);
              }
              if ( (bool)parms[38] )
              {
                 stmt.setNull( 20 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(20, (String)parms[39]);
              }
              stmt.SetParameter(21, (long)parms[40]);
              stmt.SetParameter(22, (long)parms[41]);
              return;
           case 12 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 13 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 14 :
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
              }
              return;
           case 16 :
              stmt.SetParameter(1, (String)parms[0]);
              return;
           case 17 :
              stmt.SetParameter(1, (String)parms[0]);
              return;
           case 18 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 19 :
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
