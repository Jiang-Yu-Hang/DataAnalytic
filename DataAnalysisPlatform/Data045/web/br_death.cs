/*
               File: BR_Death
        Description: 死亡情况
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:6:25.50
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
   public class br_death : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"BR_DEATH_CAUSECODE") == 0 )
         {
            AV12tCurrentCode = GetNextPar( );
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12tCurrentCode", AV12tCurrentCode);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GXDLABR_DEATH_CAUSECODE0A11( AV12tCurrentCode) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"BR_DEATH_SOURSE") == 0 )
         {
            AV12tCurrentCode = GetNextPar( );
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12tCurrentCode", AV12tCurrentCode);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GXDLABR_DEATH_SOURSE0A11( AV12tCurrentCode) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel2"+"_"+"BR_DEATH_CAUSECODE_CODE") == 0 )
         {
            A51BR_Death_CauseCode = GetNextPar( );
            n51BR_Death_CauseCode = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A51BR_Death_CauseCode", A51BR_Death_CauseCode);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX2ASABR_DEATH_CAUSECODE_CODE0A11( A51BR_Death_CauseCode) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel3"+"_"+"BR_DEATH_CAUSECODE_CODE") == 0 )
         {
            A51BR_Death_CauseCode = GetNextPar( );
            n51BR_Death_CauseCode = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A51BR_Death_CauseCode", A51BR_Death_CauseCode);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX3ASABR_DEATH_CAUSECODE_CODE0A11( A51BR_Death_CauseCode) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel4"+"_"+"BR_DEATH_SOURSE_CODE") == 0 )
         {
            A52BR_Death_Sourse = GetNextPar( );
            n52BR_Death_Sourse = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A52BR_Death_Sourse", A52BR_Death_Sourse);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX4ASABR_DEATH_SOURSE_CODE0A11( A52BR_Death_Sourse) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel5"+"_"+"BR_DEATH_SOURSE_CODE") == 0 )
         {
            A52BR_Death_Sourse = GetNextPar( );
            n52BR_Death_Sourse = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A52BR_Death_Sourse", A52BR_Death_Sourse);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX5ASABR_DEATH_SOURSE_CODE0A11( A52BR_Death_Sourse) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_9") == 0 )
         {
            A19BR_EncounterID = (long)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_9( A19BR_EncounterID) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_10") == 0 )
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
            gxLoad_10( A85BR_Information_ID) ;
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
            Form.Meta.addItem("description", "死亡情况", 0) ;
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

      public br_death( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_death( IGxContext context )
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
         dynBR_Death_CauseCode = new GXCombobox();
         dynBR_Death_Sourse = new GXCombobox();
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
         if ( dynBR_Death_CauseCode.ItemCount > 0 )
         {
            A51BR_Death_CauseCode = dynBR_Death_CauseCode.getValidValue(A51BR_Death_CauseCode);
            n51BR_Death_CauseCode = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A51BR_Death_CauseCode", A51BR_Death_CauseCode);
         }
         if ( context.isAjaxRequest( ) )
         {
            dynBR_Death_CauseCode.CurrentValue = StringUtil.RTrim( A51BR_Death_CauseCode);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynBR_Death_CauseCode_Internalname, "Values", dynBR_Death_CauseCode.ToJavascriptSource(), true);
         }
         if ( dynBR_Death_Sourse.ItemCount > 0 )
         {
            A52BR_Death_Sourse = dynBR_Death_Sourse.getValidValue(A52BR_Death_Sourse);
            n52BR_Death_Sourse = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A52BR_Death_Sourse", A52BR_Death_Sourse);
         }
         if ( context.isAjaxRequest( ) )
         {
            dynBR_Death_Sourse.CurrentValue = StringUtil.RTrim( A52BR_Death_Sourse);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynBR_Death_Sourse_Internalname, "Values", dynBR_Death_Sourse.ToJavascriptSource(), true);
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
            GxWebStd.gx_single_line_edit( context, edtBR_EncounterID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A19BR_EncounterID), 18, 0, ".", "")), ((edtBR_EncounterID_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A19BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ")) : context.localUtil.Format( (decimal)(A19BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,25);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_EncounterID_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBR_EncounterID_Enabled, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "HLP_BR_Death.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_Death_Date_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Death_Date_Internalname, "死亡日期", "col-sm-3 AttributeDateLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 32,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtBR_Death_Date_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtBR_Death_Date_Internalname, context.localUtil.Format(A49BR_Death_Date, "9999/99/99"), context.localUtil.Format( A49BR_Death_Date, "9999/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',0,24,'chs',false,1);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,32);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Death_Date_Jsonclick, 0, "AttributeDate", "", "", "", "", 1, edtBR_Death_Date_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "DM_Date", "right", false, "HLP_BR_Death.htm");
            GxWebStd.gx_bitmap( context, edtBR_Death_Date_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtBR_Death_Date_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_Death.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_Death_Cause_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Death_Cause_Internalname, "死亡原因", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 37,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_Death_Cause_Internalname, A50BR_Death_Cause, StringUtil.RTrim( context.localUtil.Format( A50BR_Death_Cause, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,37);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Death_Cause_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBR_Death_Cause_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Death.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+dynBR_Death_CauseCode_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynBR_Death_CauseCode_Internalname, "死亡原因代码编码", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 41,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynBR_Death_CauseCode, dynBR_Death_CauseCode_Internalname, StringUtil.RTrim( A51BR_Death_CauseCode), 1, dynBR_Death_CauseCode_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, dynBR_Death_CauseCode.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,41);\"", "", true, "HLP_BR_Death.htm");
            dynBR_Death_CauseCode.CurrentValue = StringUtil.RTrim( A51BR_Death_CauseCode);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynBR_Death_CauseCode_Internalname, "Values", (String)(dynBR_Death_CauseCode.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+dynBR_Death_Sourse_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynBR_Death_Sourse_Internalname, "死亡来源编码", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynBR_Death_Sourse, dynBR_Death_Sourse_Internalname, StringUtil.RTrim( A52BR_Death_Sourse), 1, dynBR_Death_Sourse_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, dynBR_Death_Sourse.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,46);\"", "", true, "HLP_BR_Death.htm");
            dynBR_Death_Sourse.CurrentValue = StringUtil.RTrim( A52BR_Death_Sourse);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynBR_Death_Sourse_Internalname, "Values", (String)(dynBR_Death_Sourse.ToJavascriptSource()), true);
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 51,'',false,'',0)\"";
            ClassString = "Button";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_enter_Internalname, "", "确认", bttBtntrn_enter_Jsonclick, 5, "确认", "", StyleString, ClassString, bttBtntrn_enter_Visible, bttBtntrn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_Death.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'',0)\"";
            ClassString = "BtnDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_cancel_Internalname, "", "取消", bttBtntrn_cancel_Jsonclick, 1, "取消", "", StyleString, ClassString, bttBtntrn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_Death.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 55,'',false,'',0)\"";
            ClassString = "BtnDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_delete_Internalname, "", "删除", bttBtntrn_delete_Jsonclick, 5, "删除", "", StyleString, ClassString, bttBtntrn_delete_Visible, bttBtntrn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_Death.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 59,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_DeathID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A48BR_DeathID), 18, 0, ".", "")), ((edtBR_DeathID_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A48BR_DeathID), "ZZZZZZZZZZZZZZZZZZ")) : context.localUtil.Format( (decimal)(A48BR_DeathID), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,59);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_DeathID_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBR_DeathID_Enabled, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "HLP_BR_Death.htm");
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
         E110A2 ();
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
               if ( context.localUtil.VCDate( cgiGet( edtBR_Death_Date_Internalname), 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"死亡日期"}), 1, "BR_DEATH_DATE");
                  AnyError = 1;
                  GX_FocusControl = edtBR_Death_Date_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A49BR_Death_Date = DateTime.MinValue;
                  n49BR_Death_Date = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A49BR_Death_Date", context.localUtil.Format(A49BR_Death_Date, "9999/99/99"));
               }
               else
               {
                  A49BR_Death_Date = context.localUtil.CToD( cgiGet( edtBR_Death_Date_Internalname), 0);
                  n49BR_Death_Date = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A49BR_Death_Date", context.localUtil.Format(A49BR_Death_Date, "9999/99/99"));
               }
               n49BR_Death_Date = ((DateTime.MinValue==A49BR_Death_Date) ? true : false);
               A50BR_Death_Cause = cgiGet( edtBR_Death_Cause_Internalname);
               n50BR_Death_Cause = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A50BR_Death_Cause", A50BR_Death_Cause);
               n50BR_Death_Cause = (String.IsNullOrEmpty(StringUtil.RTrim( A50BR_Death_Cause)) ? true : false);
               dynBR_Death_CauseCode.CurrentValue = cgiGet( dynBR_Death_CauseCode_Internalname);
               A51BR_Death_CauseCode = cgiGet( dynBR_Death_CauseCode_Internalname);
               n51BR_Death_CauseCode = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A51BR_Death_CauseCode", A51BR_Death_CauseCode);
               n51BR_Death_CauseCode = (String.IsNullOrEmpty(StringUtil.RTrim( A51BR_Death_CauseCode)) ? true : false);
               dynBR_Death_Sourse.CurrentValue = cgiGet( dynBR_Death_Sourse_Internalname);
               A52BR_Death_Sourse = cgiGet( dynBR_Death_Sourse_Internalname);
               n52BR_Death_Sourse = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A52BR_Death_Sourse", A52BR_Death_Sourse);
               n52BR_Death_Sourse = (String.IsNullOrEmpty(StringUtil.RTrim( A52BR_Death_Sourse)) ? true : false);
               if ( ( ( context.localUtil.CToN( cgiGet( edtBR_DeathID_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtBR_DeathID_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_DEATHID");
                  AnyError = 1;
                  GX_FocusControl = edtBR_DeathID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A48BR_DeathID = 0;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A48BR_DeathID", StringUtil.LTrim( StringUtil.Str( (decimal)(A48BR_DeathID), 18, 0)));
               }
               else
               {
                  A48BR_DeathID = (long)(context.localUtil.CToN( cgiGet( edtBR_DeathID_Internalname), ".", ","));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A48BR_DeathID", StringUtil.LTrim( StringUtil.Str( (decimal)(A48BR_DeathID), 18, 0)));
               }
               /* Read saved values. */
               Z48BR_DeathID = (long)(context.localUtil.CToN( cgiGet( "Z48BR_DeathID"), ".", ","));
               Z501BR_Death_CauseCode_Code = cgiGet( "Z501BR_Death_CauseCode_Code");
               n501BR_Death_CauseCode_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A501BR_Death_CauseCode_Code)) ? true : false);
               Z469BR_Death_Sourse_Code = cgiGet( "Z469BR_Death_Sourse_Code");
               n469BR_Death_Sourse_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A469BR_Death_Sourse_Code)) ? true : false);
               Z49BR_Death_Date = context.localUtil.CToD( cgiGet( "Z49BR_Death_Date"), 0);
               n49BR_Death_Date = ((DateTime.MinValue==A49BR_Death_Date) ? true : false);
               Z50BR_Death_Cause = cgiGet( "Z50BR_Death_Cause");
               n50BR_Death_Cause = (String.IsNullOrEmpty(StringUtil.RTrim( A50BR_Death_Cause)) ? true : false);
               Z51BR_Death_CauseCode = cgiGet( "Z51BR_Death_CauseCode");
               n51BR_Death_CauseCode = (String.IsNullOrEmpty(StringUtil.RTrim( A51BR_Death_CauseCode)) ? true : false);
               Z52BR_Death_Sourse = cgiGet( "Z52BR_Death_Sourse");
               n52BR_Death_Sourse = (String.IsNullOrEmpty(StringUtil.RTrim( A52BR_Death_Sourse)) ? true : false);
               Z19BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( "Z19BR_EncounterID"), ".", ","));
               A501BR_Death_CauseCode_Code = cgiGet( "Z501BR_Death_CauseCode_Code");
               n501BR_Death_CauseCode_Code = false;
               n501BR_Death_CauseCode_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A501BR_Death_CauseCode_Code)) ? true : false);
               A469BR_Death_Sourse_Code = cgiGet( "Z469BR_Death_Sourse_Code");
               n469BR_Death_Sourse_Code = false;
               n469BR_Death_Sourse_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A469BR_Death_Sourse_Code)) ? true : false);
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ","));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ","));
               Gx_mode = cgiGet( "Mode");
               A501BR_Death_CauseCode_Code = cgiGet( "BR_DEATH_CAUSECODE_CODE");
               n501BR_Death_CauseCode_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A501BR_Death_CauseCode_Code)) ? true : false);
               A469BR_Death_Sourse_Code = cgiGet( "BR_DEATH_SOURSE_CODE");
               n469BR_Death_Sourse_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A469BR_Death_Sourse_Code)) ? true : false);
               AV12tCurrentCode = cgiGet( "vTCURRENTCODE");
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
               forbiddenHiddens = "hsh" + "BR_Death";
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( AV12tCurrentCode, ""));
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( A48BR_DeathID != Z48BR_DeathID ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
               {
                  GXUtil.WriteLog("br_death:[SecurityCheckFailed value for]"+"tCurrentCode:"+StringUtil.RTrim( context.localUtil.Format( AV12tCurrentCode, "")));
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
                  A48BR_DeathID = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A48BR_DeathID", StringUtil.LTrim( StringUtil.Str( (decimal)(A48BR_DeathID), 18, 0)));
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
                           E110A2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: After Trn */
                           E120A2 ();
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
            E120A2 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll0A11( ) ;
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
         DisableAttributes0A11( ) ;
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

      protected void ResetCaption0A0( )
      {
      }

      protected void E110A2( )
      {
         /* Start Routine */
         GXt_char1 = AV12tCurrentCode;
         new zbr_getcurrenttcode(context ).execute( out  GXt_char1) ;
         AV12tCurrentCode = GXt_char1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12tCurrentCode", AV12tCurrentCode);
      }

      protected void E120A2( )
      {
         /* After Trn Routine */
      }

      protected void ZM0A11( short GX_JID )
      {
         if ( ( GX_JID == 8 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z501BR_Death_CauseCode_Code = T000A3_A501BR_Death_CauseCode_Code[0];
               Z469BR_Death_Sourse_Code = T000A3_A469BR_Death_Sourse_Code[0];
               Z49BR_Death_Date = T000A3_A49BR_Death_Date[0];
               Z50BR_Death_Cause = T000A3_A50BR_Death_Cause[0];
               Z51BR_Death_CauseCode = T000A3_A51BR_Death_CauseCode[0];
               Z52BR_Death_Sourse = T000A3_A52BR_Death_Sourse[0];
               Z19BR_EncounterID = T000A3_A19BR_EncounterID[0];
            }
            else
            {
               Z501BR_Death_CauseCode_Code = A501BR_Death_CauseCode_Code;
               Z469BR_Death_Sourse_Code = A469BR_Death_Sourse_Code;
               Z49BR_Death_Date = A49BR_Death_Date;
               Z50BR_Death_Cause = A50BR_Death_Cause;
               Z51BR_Death_CauseCode = A51BR_Death_CauseCode;
               Z52BR_Death_Sourse = A52BR_Death_Sourse;
               Z19BR_EncounterID = A19BR_EncounterID;
            }
         }
         if ( GX_JID == -8 )
         {
            Z48BR_DeathID = A48BR_DeathID;
            Z501BR_Death_CauseCode_Code = A501BR_Death_CauseCode_Code;
            Z469BR_Death_Sourse_Code = A469BR_Death_Sourse_Code;
            Z49BR_Death_Date = A49BR_Death_Date;
            Z50BR_Death_Cause = A50BR_Death_Cause;
            Z51BR_Death_CauseCode = A51BR_Death_CauseCode;
            Z52BR_Death_Sourse = A52BR_Death_Sourse;
            Z19BR_EncounterID = A19BR_EncounterID;
            Z85BR_Information_ID = A85BR_Information_ID;
            Z36BR_Information_PatientNo = A36BR_Information_PatientNo;
         }
      }

      protected void standaloneNotModal( )
      {
         GXABR_DEATH_CAUSECODE_html0A11( AV12tCurrentCode) ;
         GXABR_DEATH_SOURSE_html0A11( AV12tCurrentCode) ;
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

      protected void Load0A11( )
      {
         /* Using cursor T000A6 */
         pr_default.execute(4, new Object[] {A48BR_DeathID});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound11 = 1;
            A85BR_Information_ID = T000A6_A85BR_Information_ID[0];
            n85BR_Information_ID = T000A6_n85BR_Information_ID[0];
            A501BR_Death_CauseCode_Code = T000A6_A501BR_Death_CauseCode_Code[0];
            n501BR_Death_CauseCode_Code = T000A6_n501BR_Death_CauseCode_Code[0];
            A469BR_Death_Sourse_Code = T000A6_A469BR_Death_Sourse_Code[0];
            n469BR_Death_Sourse_Code = T000A6_n469BR_Death_Sourse_Code[0];
            A36BR_Information_PatientNo = T000A6_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = T000A6_n36BR_Information_PatientNo[0];
            A49BR_Death_Date = T000A6_A49BR_Death_Date[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A49BR_Death_Date", context.localUtil.Format(A49BR_Death_Date, "9999/99/99"));
            n49BR_Death_Date = T000A6_n49BR_Death_Date[0];
            A50BR_Death_Cause = T000A6_A50BR_Death_Cause[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A50BR_Death_Cause", A50BR_Death_Cause);
            n50BR_Death_Cause = T000A6_n50BR_Death_Cause[0];
            A51BR_Death_CauseCode = T000A6_A51BR_Death_CauseCode[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A51BR_Death_CauseCode", A51BR_Death_CauseCode);
            n51BR_Death_CauseCode = T000A6_n51BR_Death_CauseCode[0];
            A52BR_Death_Sourse = T000A6_A52BR_Death_Sourse[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A52BR_Death_Sourse", A52BR_Death_Sourse);
            n52BR_Death_Sourse = T000A6_n52BR_Death_Sourse[0];
            A19BR_EncounterID = T000A6_A19BR_EncounterID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
            ZM0A11( -8) ;
         }
         pr_default.close(4);
         OnLoadActions0A11( ) ;
      }

      protected void OnLoadActions0A11( )
      {
      }

      protected void CheckExtendedTable0A11( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
         /* Using cursor T000A4 */
         pr_default.execute(2, new Object[] {A19BR_EncounterID});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("不匹配' T15'", "ForeignKeyNotFound", 1, "BR_ENCOUNTERID");
            AnyError = 1;
            GX_FocusControl = edtBR_EncounterID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A85BR_Information_ID = T000A4_A85BR_Information_ID[0];
         n85BR_Information_ID = T000A4_n85BR_Information_ID[0];
         pr_default.close(2);
         /* Using cursor T000A5 */
         pr_default.execute(3, new Object[] {n85BR_Information_ID, A85BR_Information_ID});
         if ( (pr_default.getStatus(3) == 101) )
         {
            if ( ! ( (0==A85BR_Information_ID) ) )
            {
               GX_msglist.addItem("不匹配' T16'", "ForeignKeyNotFound", 1, "");
               AnyError = 1;
            }
         }
         A36BR_Information_PatientNo = T000A5_A36BR_Information_PatientNo[0];
         n36BR_Information_PatientNo = T000A5_n36BR_Information_PatientNo[0];
         pr_default.close(3);
         if ( ! ( (DateTime.MinValue==A49BR_Death_Date) || ( A49BR_Death_Date >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("域死亡日期超界", "OutOfRange", 1, "BR_DEATH_DATE");
            AnyError = 1;
            GX_FocusControl = edtBR_Death_Date_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
      }

      protected void CloseExtendedTableCursors0A11( )
      {
         pr_default.close(2);
         pr_default.close(3);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_9( long A19BR_EncounterID )
      {
         /* Using cursor T000A7 */
         pr_default.execute(5, new Object[] {A19BR_EncounterID});
         if ( (pr_default.getStatus(5) == 101) )
         {
            GX_msglist.addItem("不匹配' T15'", "ForeignKeyNotFound", 1, "BR_ENCOUNTERID");
            AnyError = 1;
            GX_FocusControl = edtBR_EncounterID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A85BR_Information_ID = T000A7_A85BR_Information_ID[0];
         n85BR_Information_ID = T000A7_n85BR_Information_ID[0];
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

      protected void gxLoad_10( long A85BR_Information_ID )
      {
         /* Using cursor T000A8 */
         pr_default.execute(6, new Object[] {n85BR_Information_ID, A85BR_Information_ID});
         if ( (pr_default.getStatus(6) == 101) )
         {
            if ( ! ( (0==A85BR_Information_ID) ) )
            {
               GX_msglist.addItem("不匹配' T16'", "ForeignKeyNotFound", 1, "");
               AnyError = 1;
            }
         }
         A36BR_Information_PatientNo = T000A8_A36BR_Information_PatientNo[0];
         n36BR_Information_PatientNo = T000A8_n36BR_Information_PatientNo[0];
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

      protected void GetKey0A11( )
      {
         /* Using cursor T000A9 */
         pr_default.execute(7, new Object[] {A48BR_DeathID});
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound11 = 1;
         }
         else
         {
            RcdFound11 = 0;
         }
         pr_default.close(7);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T000A3 */
         pr_default.execute(1, new Object[] {A48BR_DeathID});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0A11( 8) ;
            RcdFound11 = 1;
            A48BR_DeathID = T000A3_A48BR_DeathID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A48BR_DeathID", StringUtil.LTrim( StringUtil.Str( (decimal)(A48BR_DeathID), 18, 0)));
            A501BR_Death_CauseCode_Code = T000A3_A501BR_Death_CauseCode_Code[0];
            n501BR_Death_CauseCode_Code = T000A3_n501BR_Death_CauseCode_Code[0];
            A469BR_Death_Sourse_Code = T000A3_A469BR_Death_Sourse_Code[0];
            n469BR_Death_Sourse_Code = T000A3_n469BR_Death_Sourse_Code[0];
            A49BR_Death_Date = T000A3_A49BR_Death_Date[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A49BR_Death_Date", context.localUtil.Format(A49BR_Death_Date, "9999/99/99"));
            n49BR_Death_Date = T000A3_n49BR_Death_Date[0];
            A50BR_Death_Cause = T000A3_A50BR_Death_Cause[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A50BR_Death_Cause", A50BR_Death_Cause);
            n50BR_Death_Cause = T000A3_n50BR_Death_Cause[0];
            A51BR_Death_CauseCode = T000A3_A51BR_Death_CauseCode[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A51BR_Death_CauseCode", A51BR_Death_CauseCode);
            n51BR_Death_CauseCode = T000A3_n51BR_Death_CauseCode[0];
            A52BR_Death_Sourse = T000A3_A52BR_Death_Sourse[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A52BR_Death_Sourse", A52BR_Death_Sourse);
            n52BR_Death_Sourse = T000A3_n52BR_Death_Sourse[0];
            A19BR_EncounterID = T000A3_A19BR_EncounterID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
            Z48BR_DeathID = A48BR_DeathID;
            sMode11 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load0A11( ) ;
            if ( AnyError == 1 )
            {
               RcdFound11 = 0;
               InitializeNonKey0A11( ) ;
            }
            Gx_mode = sMode11;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound11 = 0;
            InitializeNonKey0A11( ) ;
            sMode11 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode11;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0A11( ) ;
         if ( RcdFound11 == 0 )
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
         RcdFound11 = 0;
         /* Using cursor T000A10 */
         pr_default.execute(8, new Object[] {A48BR_DeathID});
         if ( (pr_default.getStatus(8) != 101) )
         {
            while ( (pr_default.getStatus(8) != 101) && ( ( T000A10_A48BR_DeathID[0] < A48BR_DeathID ) ) )
            {
               pr_default.readNext(8);
            }
            if ( (pr_default.getStatus(8) != 101) && ( ( T000A10_A48BR_DeathID[0] > A48BR_DeathID ) ) )
            {
               A48BR_DeathID = T000A10_A48BR_DeathID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A48BR_DeathID", StringUtil.LTrim( StringUtil.Str( (decimal)(A48BR_DeathID), 18, 0)));
               RcdFound11 = 1;
            }
         }
         pr_default.close(8);
      }

      protected void move_previous( )
      {
         RcdFound11 = 0;
         /* Using cursor T000A11 */
         pr_default.execute(9, new Object[] {A48BR_DeathID});
         if ( (pr_default.getStatus(9) != 101) )
         {
            while ( (pr_default.getStatus(9) != 101) && ( ( T000A11_A48BR_DeathID[0] > A48BR_DeathID ) ) )
            {
               pr_default.readNext(9);
            }
            if ( (pr_default.getStatus(9) != 101) && ( ( T000A11_A48BR_DeathID[0] < A48BR_DeathID ) ) )
            {
               A48BR_DeathID = T000A11_A48BR_DeathID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A48BR_DeathID", StringUtil.LTrim( StringUtil.Str( (decimal)(A48BR_DeathID), 18, 0)));
               RcdFound11 = 1;
            }
         }
         pr_default.close(9);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey0A11( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtBR_EncounterID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert0A11( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound11 == 1 )
            {
               if ( A48BR_DeathID != Z48BR_DeathID )
               {
                  A48BR_DeathID = Z48BR_DeathID;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A48BR_DeathID", StringUtil.LTrim( StringUtil.Str( (decimal)(A48BR_DeathID), 18, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "BR_DEATHID");
                  AnyError = 1;
                  GX_FocusControl = edtBR_DeathID_Internalname;
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
                  Update0A11( ) ;
                  GX_FocusControl = edtBR_EncounterID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A48BR_DeathID != Z48BR_DeathID )
               {
                  Gx_mode = "INS";
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Insert record */
                  GX_FocusControl = edtBR_EncounterID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert0A11( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "BR_DEATHID");
                     AnyError = 1;
                     GX_FocusControl = edtBR_DeathID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     Gx_mode = "INS";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     /* Insert record */
                     GX_FocusControl = edtBR_EncounterID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert0A11( ) ;
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
         if ( A48BR_DeathID != Z48BR_DeathID )
         {
            A48BR_DeathID = Z48BR_DeathID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A48BR_DeathID", StringUtil.LTrim( StringUtil.Str( (decimal)(A48BR_DeathID), 18, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "BR_DEATHID");
            AnyError = 1;
            GX_FocusControl = edtBR_DeathID_Internalname;
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
         if ( RcdFound11 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "BR_DEATHID");
            AnyError = 1;
            GX_FocusControl = edtBR_DeathID_Internalname;
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
         ScanStart0A11( ) ;
         if ( RcdFound11 == 0 )
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
         ScanEnd0A11( ) ;
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
         if ( RcdFound11 == 0 )
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
         if ( RcdFound11 == 0 )
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
         ScanStart0A11( ) ;
         if ( RcdFound11 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow", ""), 0, "", true);
         }
         else
         {
            while ( RcdFound11 != 0 )
            {
               ScanNext0A11( ) ;
            }
            Gx_mode = "UPD";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtBR_EncounterID_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd0A11( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency0A11( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000A2 */
            pr_default.execute(0, new Object[] {A48BR_DeathID});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BR_Death"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z501BR_Death_CauseCode_Code, T000A2_A501BR_Death_CauseCode_Code[0]) != 0 ) || ( StringUtil.StrCmp(Z469BR_Death_Sourse_Code, T000A2_A469BR_Death_Sourse_Code[0]) != 0 ) || ( Z49BR_Death_Date != T000A2_A49BR_Death_Date[0] ) || ( StringUtil.StrCmp(Z50BR_Death_Cause, T000A2_A50BR_Death_Cause[0]) != 0 ) || ( StringUtil.StrCmp(Z51BR_Death_CauseCode, T000A2_A51BR_Death_CauseCode[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z52BR_Death_Sourse, T000A2_A52BR_Death_Sourse[0]) != 0 ) || ( Z19BR_EncounterID != T000A2_A19BR_EncounterID[0] ) )
            {
               if ( StringUtil.StrCmp(Z501BR_Death_CauseCode_Code, T000A2_A501BR_Death_CauseCode_Code[0]) != 0 )
               {
                  GXUtil.WriteLog("br_death:[seudo value changed for attri]"+"BR_Death_CauseCode_Code");
                  GXUtil.WriteLogRaw("Old: ",Z501BR_Death_CauseCode_Code);
                  GXUtil.WriteLogRaw("Current: ",T000A2_A501BR_Death_CauseCode_Code[0]);
               }
               if ( StringUtil.StrCmp(Z469BR_Death_Sourse_Code, T000A2_A469BR_Death_Sourse_Code[0]) != 0 )
               {
                  GXUtil.WriteLog("br_death:[seudo value changed for attri]"+"BR_Death_Sourse_Code");
                  GXUtil.WriteLogRaw("Old: ",Z469BR_Death_Sourse_Code);
                  GXUtil.WriteLogRaw("Current: ",T000A2_A469BR_Death_Sourse_Code[0]);
               }
               if ( Z49BR_Death_Date != T000A2_A49BR_Death_Date[0] )
               {
                  GXUtil.WriteLog("br_death:[seudo value changed for attri]"+"BR_Death_Date");
                  GXUtil.WriteLogRaw("Old: ",Z49BR_Death_Date);
                  GXUtil.WriteLogRaw("Current: ",T000A2_A49BR_Death_Date[0]);
               }
               if ( StringUtil.StrCmp(Z50BR_Death_Cause, T000A2_A50BR_Death_Cause[0]) != 0 )
               {
                  GXUtil.WriteLog("br_death:[seudo value changed for attri]"+"BR_Death_Cause");
                  GXUtil.WriteLogRaw("Old: ",Z50BR_Death_Cause);
                  GXUtil.WriteLogRaw("Current: ",T000A2_A50BR_Death_Cause[0]);
               }
               if ( StringUtil.StrCmp(Z51BR_Death_CauseCode, T000A2_A51BR_Death_CauseCode[0]) != 0 )
               {
                  GXUtil.WriteLog("br_death:[seudo value changed for attri]"+"BR_Death_CauseCode");
                  GXUtil.WriteLogRaw("Old: ",Z51BR_Death_CauseCode);
                  GXUtil.WriteLogRaw("Current: ",T000A2_A51BR_Death_CauseCode[0]);
               }
               if ( StringUtil.StrCmp(Z52BR_Death_Sourse, T000A2_A52BR_Death_Sourse[0]) != 0 )
               {
                  GXUtil.WriteLog("br_death:[seudo value changed for attri]"+"BR_Death_Sourse");
                  GXUtil.WriteLogRaw("Old: ",Z52BR_Death_Sourse);
                  GXUtil.WriteLogRaw("Current: ",T000A2_A52BR_Death_Sourse[0]);
               }
               if ( Z19BR_EncounterID != T000A2_A19BR_EncounterID[0] )
               {
                  GXUtil.WriteLog("br_death:[seudo value changed for attri]"+"BR_EncounterID");
                  GXUtil.WriteLogRaw("Old: ",Z19BR_EncounterID);
                  GXUtil.WriteLogRaw("Current: ",T000A2_A19BR_EncounterID[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"BR_Death"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0A11( )
      {
         BeforeValidate0A11( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0A11( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0A11( 0) ;
            CheckOptimisticConcurrency0A11( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0A11( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0A11( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000A12 */
                     pr_default.execute(10, new Object[] {n501BR_Death_CauseCode_Code, A501BR_Death_CauseCode_Code, n469BR_Death_Sourse_Code, A469BR_Death_Sourse_Code, n49BR_Death_Date, A49BR_Death_Date, n50BR_Death_Cause, A50BR_Death_Cause, n51BR_Death_CauseCode, A51BR_Death_CauseCode, n52BR_Death_Sourse, A52BR_Death_Sourse, A19BR_EncounterID});
                     A48BR_DeathID = T000A12_A48BR_DeathID[0];
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A48BR_DeathID", StringUtil.LTrim( StringUtil.Str( (decimal)(A48BR_DeathID), 18, 0)));
                     pr_default.close(10);
                     dsDefault.SmartCacheProvider.SetUpdated("BR_Death") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                           ResetCaption0A0( ) ;
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
               Load0A11( ) ;
            }
            EndLevel0A11( ) ;
         }
         CloseExtendedTableCursors0A11( ) ;
      }

      protected void Update0A11( )
      {
         BeforeValidate0A11( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0A11( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0A11( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0A11( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0A11( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000A13 */
                     pr_default.execute(11, new Object[] {n501BR_Death_CauseCode_Code, A501BR_Death_CauseCode_Code, n469BR_Death_Sourse_Code, A469BR_Death_Sourse_Code, n49BR_Death_Date, A49BR_Death_Date, n50BR_Death_Cause, A50BR_Death_Cause, n51BR_Death_CauseCode, A51BR_Death_CauseCode, n52BR_Death_Sourse, A52BR_Death_Sourse, A19BR_EncounterID, A48BR_DeathID});
                     pr_default.close(11);
                     dsDefault.SmartCacheProvider.SetUpdated("BR_Death") ;
                     if ( (pr_default.getStatus(11) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BR_Death"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0A11( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), "SuccessfullyUpdated", 0, "", true);
                           ResetCaption0A0( ) ;
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
            EndLevel0A11( ) ;
         }
         CloseExtendedTableCursors0A11( ) ;
      }

      protected void DeferredUpdate0A11( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate0A11( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0A11( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0A11( ) ;
            AfterConfirm0A11( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0A11( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000A14 */
                  pr_default.execute(12, new Object[] {A48BR_DeathID});
                  pr_default.close(12);
                  dsDefault.SmartCacheProvider.SetUpdated("BR_Death") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        move_next( ) ;
                        if ( RcdFound11 == 0 )
                        {
                           InitAll0A11( ) ;
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
                        ResetCaption0A0( ) ;
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
         sMode11 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel0A11( ) ;
         Gx_mode = sMode11;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls0A11( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            /* Using cursor T000A15 */
            pr_default.execute(13, new Object[] {A19BR_EncounterID});
            A85BR_Information_ID = T000A15_A85BR_Information_ID[0];
            n85BR_Information_ID = T000A15_n85BR_Information_ID[0];
            pr_default.close(13);
            /* Using cursor T000A16 */
            pr_default.execute(14, new Object[] {n85BR_Information_ID, A85BR_Information_ID});
            A36BR_Information_PatientNo = T000A16_A36BR_Information_PatientNo[0];
            n36BR_Information_PatientNo = T000A16_n36BR_Information_PatientNo[0];
            pr_default.close(14);
         }
      }

      protected void EndLevel0A11( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0A11( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(1);
            pr_default.close(13);
            pr_default.close(14);
            context.CommitDataStores("br_death",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues0A0( ) ;
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
            context.RollbackDataStores("br_death",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart0A11( )
      {
         /* Scan By routine */
         /* Using cursor T000A17 */
         pr_default.execute(15);
         RcdFound11 = 0;
         if ( (pr_default.getStatus(15) != 101) )
         {
            RcdFound11 = 1;
            A48BR_DeathID = T000A17_A48BR_DeathID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A48BR_DeathID", StringUtil.LTrim( StringUtil.Str( (decimal)(A48BR_DeathID), 18, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0A11( )
      {
         /* Scan next routine */
         pr_default.readNext(15);
         RcdFound11 = 0;
         if ( (pr_default.getStatus(15) != 101) )
         {
            RcdFound11 = 1;
            A48BR_DeathID = T000A17_A48BR_DeathID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A48BR_DeathID", StringUtil.LTrim( StringUtil.Str( (decimal)(A48BR_DeathID), 18, 0)));
         }
      }

      protected void ScanEnd0A11( )
      {
         pr_default.close(15);
      }

      protected void AfterConfirm0A11( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0A11( )
      {
         /* Before Insert Rules */
         GXt_char1 = A501BR_Death_CauseCode_Code;
         new zutil_findtargetcode(context ).execute(  18,  A51BR_Death_CauseCode, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A51BR_Death_CauseCode", A51BR_Death_CauseCode);
         A501BR_Death_CauseCode_Code = GXt_char1;
         n501BR_Death_CauseCode_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A501BR_Death_CauseCode_Code", A501BR_Death_CauseCode_Code);
         GXt_char1 = A469BR_Death_Sourse_Code;
         new zutil_findtargetcode(context ).execute(  19,  A52BR_Death_Sourse, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A52BR_Death_Sourse", A52BR_Death_Sourse);
         A469BR_Death_Sourse_Code = GXt_char1;
         n469BR_Death_Sourse_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A469BR_Death_Sourse_Code", A469BR_Death_Sourse_Code);
      }

      protected void BeforeUpdate0A11( )
      {
         /* Before Update Rules */
         GXt_char1 = A501BR_Death_CauseCode_Code;
         new zutil_findtargetcode(context ).execute(  18,  A51BR_Death_CauseCode, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A51BR_Death_CauseCode", A51BR_Death_CauseCode);
         A501BR_Death_CauseCode_Code = GXt_char1;
         n501BR_Death_CauseCode_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A501BR_Death_CauseCode_Code", A501BR_Death_CauseCode_Code);
         GXt_char1 = A469BR_Death_Sourse_Code;
         new zutil_findtargetcode(context ).execute(  19,  A52BR_Death_Sourse, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A52BR_Death_Sourse", A52BR_Death_Sourse);
         A469BR_Death_Sourse_Code = GXt_char1;
         n469BR_Death_Sourse_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A469BR_Death_Sourse_Code", A469BR_Death_Sourse_Code);
      }

      protected void BeforeDelete0A11( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0A11( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0A11( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0A11( )
      {
         edtBR_EncounterID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_EncounterID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_EncounterID_Enabled), 5, 0)), true);
         edtBR_Death_Date_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Death_Date_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Death_Date_Enabled), 5, 0)), true);
         edtBR_Death_Cause_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Death_Cause_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Death_Cause_Enabled), 5, 0)), true);
         dynBR_Death_CauseCode.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynBR_Death_CauseCode_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynBR_Death_CauseCode.Enabled), 5, 0)), true);
         dynBR_Death_Sourse.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynBR_Death_Sourse_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynBR_Death_Sourse.Enabled), 5, 0)), true);
         edtBR_DeathID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_DeathID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_DeathID_Enabled), 5, 0)), true);
      }

      protected void send_integrity_lvl_hashes0A11( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues0A0( )
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
         context.AddJavascriptSource("gxcfg.js", "?20202281562773", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_death.aspx") +"\">") ;
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
         forbiddenHiddens = "hsh" + "BR_Death";
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( AV12tCurrentCode, ""));
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("br_death:[SendSecurityCheck value for]"+"tCurrentCode:"+StringUtil.RTrim( context.localUtil.Format( AV12tCurrentCode, "")));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z48BR_DeathID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z48BR_DeathID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z501BR_Death_CauseCode_Code", Z501BR_Death_CauseCode_Code);
         GxWebStd.gx_hidden_field( context, "Z469BR_Death_Sourse_Code", Z469BR_Death_Sourse_Code);
         GxWebStd.gx_hidden_field( context, "Z49BR_Death_Date", context.localUtil.DToC( Z49BR_Death_Date, 0, "/"));
         GxWebStd.gx_hidden_field( context, "Z50BR_Death_Cause", Z50BR_Death_Cause);
         GxWebStd.gx_hidden_field( context, "Z51BR_Death_CauseCode", Z51BR_Death_CauseCode);
         GxWebStd.gx_hidden_field( context, "Z52BR_Death_Sourse", Z52BR_Death_Sourse);
         GxWebStd.gx_hidden_field( context, "Z19BR_EncounterID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z19BR_EncounterID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "BR_DEATH_CAUSECODE_CODE", A501BR_Death_CauseCode_Code);
         GxWebStd.gx_hidden_field( context, "BR_DEATH_SOURSE_CODE", A469BR_Death_Sourse_Code);
         GxWebStd.gx_hidden_field( context, "vTCURRENTCODE", AV12tCurrentCode);
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
         return formatLink("br_death.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "BR_Death" ;
      }

      public override String GetPgmdesc( )
      {
         return "死亡情况" ;
      }

      protected void InitializeNonKey0A11( )
      {
         A85BR_Information_ID = 0;
         n85BR_Information_ID = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A85BR_Information_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A85BR_Information_ID), 18, 0)));
         A501BR_Death_CauseCode_Code = "";
         n501BR_Death_CauseCode_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A501BR_Death_CauseCode_Code", A501BR_Death_CauseCode_Code);
         A469BR_Death_Sourse_Code = "";
         n469BR_Death_Sourse_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A469BR_Death_Sourse_Code", A469BR_Death_Sourse_Code);
         A19BR_EncounterID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
         A36BR_Information_PatientNo = "";
         n36BR_Information_PatientNo = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36BR_Information_PatientNo", A36BR_Information_PatientNo);
         A49BR_Death_Date = DateTime.MinValue;
         n49BR_Death_Date = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A49BR_Death_Date", context.localUtil.Format(A49BR_Death_Date, "9999/99/99"));
         n49BR_Death_Date = ((DateTime.MinValue==A49BR_Death_Date) ? true : false);
         A50BR_Death_Cause = "";
         n50BR_Death_Cause = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A50BR_Death_Cause", A50BR_Death_Cause);
         n50BR_Death_Cause = (String.IsNullOrEmpty(StringUtil.RTrim( A50BR_Death_Cause)) ? true : false);
         A51BR_Death_CauseCode = "";
         n51BR_Death_CauseCode = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A51BR_Death_CauseCode", A51BR_Death_CauseCode);
         n51BR_Death_CauseCode = (String.IsNullOrEmpty(StringUtil.RTrim( A51BR_Death_CauseCode)) ? true : false);
         A52BR_Death_Sourse = "";
         n52BR_Death_Sourse = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A52BR_Death_Sourse", A52BR_Death_Sourse);
         n52BR_Death_Sourse = (String.IsNullOrEmpty(StringUtil.RTrim( A52BR_Death_Sourse)) ? true : false);
         Z501BR_Death_CauseCode_Code = "";
         Z469BR_Death_Sourse_Code = "";
         Z49BR_Death_Date = DateTime.MinValue;
         Z50BR_Death_Cause = "";
         Z51BR_Death_CauseCode = "";
         Z52BR_Death_Sourse = "";
         Z19BR_EncounterID = 0;
      }

      protected void InitAll0A11( )
      {
         A48BR_DeathID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A48BR_DeathID", StringUtil.LTrim( StringUtil.Str( (decimal)(A48BR_DeathID), 18, 0)));
         InitializeNonKey0A11( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2020228156284", true);
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
         context.AddJavascriptSource("br_death.js", "?2020228156284", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         edtBR_EncounterID_Internalname = "BR_ENCOUNTERID";
         edtBR_Death_Date_Internalname = "BR_DEATH_DATE";
         edtBR_Death_Cause_Internalname = "BR_DEATH_CAUSE";
         dynBR_Death_CauseCode_Internalname = "BR_DEATH_CAUSECODE";
         dynBR_Death_Sourse_Internalname = "BR_DEATH_SOURSE";
         divTableattributes_Internalname = "TABLEATTRIBUTES";
         divLayout_tableattributes_Internalname = "LAYOUT_TABLEATTRIBUTES";
         Dvpanel_tableattributes_Internalname = "DVPANEL_TABLEATTRIBUTES";
         divHtml_dvpanel_tableattributes_Internalname = "HTML_DVPANEL_TABLEATTRIBUTES";
         divTablecontent_Internalname = "TABLECONTENT";
         bttBtntrn_enter_Internalname = "BTNTRN_ENTER";
         bttBtntrn_cancel_Internalname = "BTNTRN_CANCEL";
         bttBtntrn_delete_Internalname = "BTNTRN_DELETE";
         divTablemain_Internalname = "TABLEMAIN";
         edtBR_DeathID_Internalname = "BR_DEATHID";
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
         Form.Caption = "死亡情况";
         edtBR_DeathID_Jsonclick = "";
         edtBR_DeathID_Enabled = 1;
         bttBtntrn_delete_Enabled = 1;
         bttBtntrn_delete_Visible = 1;
         bttBtntrn_cancel_Visible = 1;
         bttBtntrn_enter_Enabled = 1;
         bttBtntrn_enter_Visible = 1;
         dynBR_Death_Sourse_Jsonclick = "";
         dynBR_Death_Sourse.Enabled = 1;
         dynBR_Death_CauseCode_Jsonclick = "";
         dynBR_Death_CauseCode.Enabled = 1;
         edtBR_Death_Cause_Jsonclick = "";
         edtBR_Death_Cause_Enabled = 1;
         edtBR_Death_Date_Jsonclick = "";
         edtBR_Death_Date_Enabled = 1;
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

      protected void GXDLABR_DEATH_CAUSECODE0A11( String AV12tCurrentCode )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLABR_DEATH_CAUSECODE_data0A11( AV12tCurrentCode) ;
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

      protected void GXABR_DEATH_CAUSECODE_html0A11( String AV12tCurrentCode )
      {
         String gxdynajaxvalue ;
         GXDLABR_DEATH_CAUSECODE_data0A11( AV12tCurrentCode) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynBR_Death_CauseCode.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex));
            dynBR_Death_CauseCode.addItem(gxdynajaxvalue, ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLABR_DEATH_CAUSECODE_data0A11( String AV12tCurrentCode )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add("");
         gxdynajaxctrldescr.Add("(请选择)");
         /* Using cursor T000A18 */
         pr_default.execute(16, new Object[] {AV12tCurrentCode});
         while ( (pr_default.getStatus(16) != 101) )
         {
            gxdynajaxctrlcodr.Add(T000A18_A168XT_DefineCodeName[0]);
            gxdynajaxctrldescr.Add(T000A18_A168XT_DefineCodeName[0]);
            pr_default.readNext(16);
         }
         pr_default.close(16);
      }

      protected void GXDLABR_DEATH_SOURSE0A11( String AV12tCurrentCode )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLABR_DEATH_SOURSE_data0A11( AV12tCurrentCode) ;
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

      protected void GXABR_DEATH_SOURSE_html0A11( String AV12tCurrentCode )
      {
         String gxdynajaxvalue ;
         GXDLABR_DEATH_SOURSE_data0A11( AV12tCurrentCode) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynBR_Death_Sourse.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex));
            dynBR_Death_Sourse.addItem(gxdynajaxvalue, ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLABR_DEATH_SOURSE_data0A11( String AV12tCurrentCode )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add("");
         gxdynajaxctrldescr.Add("(请选择)");
         /* Using cursor T000A19 */
         pr_default.execute(17, new Object[] {AV12tCurrentCode});
         while ( (pr_default.getStatus(17) != 101) )
         {
            gxdynajaxctrlcodr.Add(T000A19_A168XT_DefineCodeName[0]);
            gxdynajaxctrldescr.Add(T000A19_A168XT_DefineCodeName[0]);
            pr_default.readNext(17);
         }
         pr_default.close(17);
      }

      protected void GX2ASABR_DEATH_CAUSECODE_CODE0A11( String A51BR_Death_CauseCode )
      {
         GXt_char1 = A501BR_Death_CauseCode_Code;
         new zutil_findtargetcode(context ).execute(  18,  A51BR_Death_CauseCode, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A51BR_Death_CauseCode", A51BR_Death_CauseCode);
         A501BR_Death_CauseCode_Code = GXt_char1;
         n501BR_Death_CauseCode_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A501BR_Death_CauseCode_Code", A501BR_Death_CauseCode_Code);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A501BR_Death_CauseCode_Code)+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GX3ASABR_DEATH_CAUSECODE_CODE0A11( String A51BR_Death_CauseCode )
      {
         GXt_char1 = A501BR_Death_CauseCode_Code;
         new zutil_findtargetcode(context ).execute(  18,  A51BR_Death_CauseCode, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A51BR_Death_CauseCode", A51BR_Death_CauseCode);
         A501BR_Death_CauseCode_Code = GXt_char1;
         n501BR_Death_CauseCode_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A501BR_Death_CauseCode_Code", A501BR_Death_CauseCode_Code);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A501BR_Death_CauseCode_Code)+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GX4ASABR_DEATH_SOURSE_CODE0A11( String A52BR_Death_Sourse )
      {
         GXt_char1 = A469BR_Death_Sourse_Code;
         new zutil_findtargetcode(context ).execute(  19,  A52BR_Death_Sourse, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A52BR_Death_Sourse", A52BR_Death_Sourse);
         A469BR_Death_Sourse_Code = GXt_char1;
         n469BR_Death_Sourse_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A469BR_Death_Sourse_Code", A469BR_Death_Sourse_Code);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A469BR_Death_Sourse_Code)+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GX5ASABR_DEATH_SOURSE_CODE0A11( String A52BR_Death_Sourse )
      {
         GXt_char1 = A469BR_Death_Sourse_Code;
         new zutil_findtargetcode(context ).execute(  19,  A52BR_Death_Sourse, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A52BR_Death_Sourse", A52BR_Death_Sourse);
         A469BR_Death_Sourse_Code = GXt_char1;
         n469BR_Death_Sourse_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A469BR_Death_Sourse_Code", A469BR_Death_Sourse_Code);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A469BR_Death_Sourse_Code)+"\"");
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
         dynBR_Death_CauseCode.Name = "BR_DEATH_CAUSECODE";
         dynBR_Death_CauseCode.WebTags = "";
         dynBR_Death_Sourse.Name = "BR_DEATH_SOURSE";
         dynBR_Death_Sourse.WebTags = "";
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

      public void Valid_Br_deathid( String GX_Parm1 ,
                                    long GX_Parm2 ,
                                    String GX_Parm3 ,
                                    String GX_Parm4 ,
                                    DateTime GX_Parm5 ,
                                    String GX_Parm6 ,
                                    GXCombobox dynGX_Parm7 ,
                                    GXCombobox dynGX_Parm8 ,
                                    long GX_Parm9 )
      {
         AV12tCurrentCode = GX_Parm1;
         A48BR_DeathID = GX_Parm2;
         A501BR_Death_CauseCode_Code = GX_Parm3;
         n501BR_Death_CauseCode_Code = false;
         A469BR_Death_Sourse_Code = GX_Parm4;
         n469BR_Death_Sourse_Code = false;
         A49BR_Death_Date = GX_Parm5;
         n49BR_Death_Date = false;
         A50BR_Death_Cause = GX_Parm6;
         n50BR_Death_Cause = false;
         dynBR_Death_CauseCode = dynGX_Parm7;
         A51BR_Death_CauseCode = dynBR_Death_CauseCode.CurrentValue;
         n51BR_Death_CauseCode = false;
         dynBR_Death_Sourse = dynGX_Parm8;
         A52BR_Death_Sourse = dynBR_Death_Sourse.CurrentValue;
         n52BR_Death_Sourse = false;
         A19BR_EncounterID = GX_Parm9;
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
         dynBR_Death_CauseCode.CurrentValue = A51BR_Death_CauseCode;
         dynBR_Death_Sourse.CurrentValue = A52BR_Death_Sourse;
         isValidOutput.Add(A501BR_Death_CauseCode_Code);
         isValidOutput.Add(A469BR_Death_Sourse_Code);
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(A19BR_EncounterID), 18, 0, ".", "")));
         isValidOutput.Add(context.localUtil.Format(A49BR_Death_Date, "9999/99/99"));
         isValidOutput.Add(A50BR_Death_Cause);
         if ( dynBR_Death_CauseCode.ItemCount > 0 )
         {
            A51BR_Death_CauseCode = dynBR_Death_CauseCode.getValidValue(A51BR_Death_CauseCode);
            n51BR_Death_CauseCode = false;
         }
         dynBR_Death_CauseCode.CurrentValue = A51BR_Death_CauseCode;
         isValidOutput.Add(dynBR_Death_CauseCode);
         if ( dynBR_Death_Sourse.ItemCount > 0 )
         {
            A52BR_Death_Sourse = dynBR_Death_Sourse.getValidValue(A52BR_Death_Sourse);
            n52BR_Death_Sourse = false;
         }
         dynBR_Death_Sourse.CurrentValue = A52BR_Death_Sourse;
         isValidOutput.Add(dynBR_Death_Sourse);
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(A85BR_Information_ID), 18, 0, ".", "")));
         isValidOutput.Add(A36BR_Information_PatientNo);
         isValidOutput.Add(StringUtil.RTrim( Gx_mode));
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z48BR_DeathID), 18, 0, ".", "")));
         isValidOutput.Add(Z501BR_Death_CauseCode_Code);
         isValidOutput.Add(Z469BR_Death_Sourse_Code);
         isValidOutput.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z19BR_EncounterID), 18, 0, ".", "")));
         isValidOutput.Add(context.localUtil.DToC( Z49BR_Death_Date, 0, "/"));
         isValidOutput.Add(Z50BR_Death_Cause);
         isValidOutput.Add(Z51BR_Death_CauseCode);
         isValidOutput.Add(Z52BR_Death_Sourse);
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
         /* Using cursor T000A20 */
         pr_default.execute(18, new Object[] {A19BR_EncounterID});
         if ( (pr_default.getStatus(18) == 101) )
         {
            GX_msglist.addItem("不匹配' T15'", "ForeignKeyNotFound", 1, "BR_ENCOUNTERID");
            AnyError = 1;
            GX_FocusControl = edtBR_EncounterID_Internalname;
         }
         A85BR_Information_ID = T000A20_A85BR_Information_ID[0];
         n85BR_Information_ID = T000A20_n85BR_Information_ID[0];
         pr_default.close(18);
         /* Using cursor T000A21 */
         pr_default.execute(19, new Object[] {n85BR_Information_ID, A85BR_Information_ID});
         if ( (pr_default.getStatus(19) == 101) )
         {
            if ( ! ( (0==A85BR_Information_ID) ) )
            {
               GX_msglist.addItem("不匹配' T16'", "ForeignKeyNotFound", 1, "");
               AnyError = 1;
            }
         }
         A36BR_Information_PatientNo = T000A21_A36BR_Information_PatientNo[0];
         n36BR_Information_PatientNo = T000A21_n36BR_Information_PatientNo[0];
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'AV12tCurrentCode',fld:'vTCURRENTCODE',pic:''}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("AFTER TRN","{handler:'E120A2',iparms:[]");
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
         Z501BR_Death_CauseCode_Code = "";
         Z469BR_Death_Sourse_Code = "";
         Z49BR_Death_Date = DateTime.MinValue;
         Z50BR_Death_Cause = "";
         Z51BR_Death_CauseCode = "";
         Z52BR_Death_Sourse = "";
         scmdbuf = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV12tCurrentCode = "";
         A51BR_Death_CauseCode = "";
         A52BR_Death_Sourse = "";
         GXKey = "";
         PreviousTooltip = "";
         PreviousCaption = "";
         Form = new GXWebForm();
         GX_FocusControl = "";
         ClassString = "";
         StyleString = "";
         ucDvpanel_tableattributes = new GXUserControl();
         TempTags = "";
         A49BR_Death_Date = DateTime.MinValue;
         A50BR_Death_Cause = "";
         bttBtntrn_enter_Jsonclick = "";
         bttBtntrn_cancel_Jsonclick = "";
         bttBtntrn_delete_Jsonclick = "";
         A501BR_Death_CauseCode_Code = "";
         A469BR_Death_Sourse_Code = "";
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
         T000A6_A85BR_Information_ID = new long[1] ;
         T000A6_n85BR_Information_ID = new bool[] {false} ;
         T000A6_A48BR_DeathID = new long[1] ;
         T000A6_A501BR_Death_CauseCode_Code = new String[] {""} ;
         T000A6_n501BR_Death_CauseCode_Code = new bool[] {false} ;
         T000A6_A469BR_Death_Sourse_Code = new String[] {""} ;
         T000A6_n469BR_Death_Sourse_Code = new bool[] {false} ;
         T000A6_A36BR_Information_PatientNo = new String[] {""} ;
         T000A6_n36BR_Information_PatientNo = new bool[] {false} ;
         T000A6_A49BR_Death_Date = new DateTime[] {DateTime.MinValue} ;
         T000A6_n49BR_Death_Date = new bool[] {false} ;
         T000A6_A50BR_Death_Cause = new String[] {""} ;
         T000A6_n50BR_Death_Cause = new bool[] {false} ;
         T000A6_A51BR_Death_CauseCode = new String[] {""} ;
         T000A6_n51BR_Death_CauseCode = new bool[] {false} ;
         T000A6_A52BR_Death_Sourse = new String[] {""} ;
         T000A6_n52BR_Death_Sourse = new bool[] {false} ;
         T000A6_A19BR_EncounterID = new long[1] ;
         T000A4_A85BR_Information_ID = new long[1] ;
         T000A4_n85BR_Information_ID = new bool[] {false} ;
         T000A5_A36BR_Information_PatientNo = new String[] {""} ;
         T000A5_n36BR_Information_PatientNo = new bool[] {false} ;
         T000A7_A85BR_Information_ID = new long[1] ;
         T000A7_n85BR_Information_ID = new bool[] {false} ;
         T000A8_A36BR_Information_PatientNo = new String[] {""} ;
         T000A8_n36BR_Information_PatientNo = new bool[] {false} ;
         T000A9_A48BR_DeathID = new long[1] ;
         T000A3_A48BR_DeathID = new long[1] ;
         T000A3_A501BR_Death_CauseCode_Code = new String[] {""} ;
         T000A3_n501BR_Death_CauseCode_Code = new bool[] {false} ;
         T000A3_A469BR_Death_Sourse_Code = new String[] {""} ;
         T000A3_n469BR_Death_Sourse_Code = new bool[] {false} ;
         T000A3_A49BR_Death_Date = new DateTime[] {DateTime.MinValue} ;
         T000A3_n49BR_Death_Date = new bool[] {false} ;
         T000A3_A50BR_Death_Cause = new String[] {""} ;
         T000A3_n50BR_Death_Cause = new bool[] {false} ;
         T000A3_A51BR_Death_CauseCode = new String[] {""} ;
         T000A3_n51BR_Death_CauseCode = new bool[] {false} ;
         T000A3_A52BR_Death_Sourse = new String[] {""} ;
         T000A3_n52BR_Death_Sourse = new bool[] {false} ;
         T000A3_A19BR_EncounterID = new long[1] ;
         sMode11 = "";
         T000A10_A48BR_DeathID = new long[1] ;
         T000A11_A48BR_DeathID = new long[1] ;
         T000A2_A48BR_DeathID = new long[1] ;
         T000A2_A501BR_Death_CauseCode_Code = new String[] {""} ;
         T000A2_n501BR_Death_CauseCode_Code = new bool[] {false} ;
         T000A2_A469BR_Death_Sourse_Code = new String[] {""} ;
         T000A2_n469BR_Death_Sourse_Code = new bool[] {false} ;
         T000A2_A49BR_Death_Date = new DateTime[] {DateTime.MinValue} ;
         T000A2_n49BR_Death_Date = new bool[] {false} ;
         T000A2_A50BR_Death_Cause = new String[] {""} ;
         T000A2_n50BR_Death_Cause = new bool[] {false} ;
         T000A2_A51BR_Death_CauseCode = new String[] {""} ;
         T000A2_n51BR_Death_CauseCode = new bool[] {false} ;
         T000A2_A52BR_Death_Sourse = new String[] {""} ;
         T000A2_n52BR_Death_Sourse = new bool[] {false} ;
         T000A2_A19BR_EncounterID = new long[1] ;
         T000A12_A48BR_DeathID = new long[1] ;
         T000A15_A85BR_Information_ID = new long[1] ;
         T000A15_n85BR_Information_ID = new bool[] {false} ;
         T000A16_A36BR_Information_PatientNo = new String[] {""} ;
         T000A16_n36BR_Information_PatientNo = new bool[] {false} ;
         T000A17_A48BR_DeathID = new long[1] ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         gxdynajaxctrlcodr = new GeneXus.Utils.GxStringCollection();
         gxdynajaxctrldescr = new GeneXus.Utils.GxStringCollection();
         gxwrpcisep = "";
         T000A18_A167XT_DefineCodeID = new long[1] ;
         T000A18_A168XT_DefineCodeName = new String[] {""} ;
         T000A18_n168XT_DefineCodeName = new bool[] {false} ;
         T000A18_A165XT_DefindcodeTypeID = new long[1] ;
         T000A18_A432XT_TenantCode = new String[] {""} ;
         T000A18_n432XT_TenantCode = new bool[] {false} ;
         T000A19_A167XT_DefineCodeID = new long[1] ;
         T000A19_A168XT_DefineCodeName = new String[] {""} ;
         T000A19_n168XT_DefineCodeName = new bool[] {false} ;
         T000A19_A165XT_DefindcodeTypeID = new long[1] ;
         T000A19_A432XT_TenantCode = new String[] {""} ;
         T000A19_n432XT_TenantCode = new bool[] {false} ;
         GXt_char1 = "";
         isValidOutput = new GxUnknownObjectCollection();
         T000A20_A85BR_Information_ID = new long[1] ;
         T000A20_n85BR_Information_ID = new bool[] {false} ;
         T000A21_A36BR_Information_PatientNo = new String[] {""} ;
         T000A21_n36BR_Information_PatientNo = new bool[] {false} ;
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.br_death__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_death__default(),
            new Object[][] {
                new Object[] {
               T000A2_A48BR_DeathID, T000A2_A501BR_Death_CauseCode_Code, T000A2_n501BR_Death_CauseCode_Code, T000A2_A469BR_Death_Sourse_Code, T000A2_n469BR_Death_Sourse_Code, T000A2_A49BR_Death_Date, T000A2_n49BR_Death_Date, T000A2_A50BR_Death_Cause, T000A2_n50BR_Death_Cause, T000A2_A51BR_Death_CauseCode,
               T000A2_n51BR_Death_CauseCode, T000A2_A52BR_Death_Sourse, T000A2_n52BR_Death_Sourse, T000A2_A19BR_EncounterID
               }
               , new Object[] {
               T000A3_A48BR_DeathID, T000A3_A501BR_Death_CauseCode_Code, T000A3_n501BR_Death_CauseCode_Code, T000A3_A469BR_Death_Sourse_Code, T000A3_n469BR_Death_Sourse_Code, T000A3_A49BR_Death_Date, T000A3_n49BR_Death_Date, T000A3_A50BR_Death_Cause, T000A3_n50BR_Death_Cause, T000A3_A51BR_Death_CauseCode,
               T000A3_n51BR_Death_CauseCode, T000A3_A52BR_Death_Sourse, T000A3_n52BR_Death_Sourse, T000A3_A19BR_EncounterID
               }
               , new Object[] {
               T000A4_A85BR_Information_ID, T000A4_n85BR_Information_ID
               }
               , new Object[] {
               T000A5_A36BR_Information_PatientNo, T000A5_n36BR_Information_PatientNo
               }
               , new Object[] {
               T000A6_A85BR_Information_ID, T000A6_n85BR_Information_ID, T000A6_A48BR_DeathID, T000A6_A501BR_Death_CauseCode_Code, T000A6_n501BR_Death_CauseCode_Code, T000A6_A469BR_Death_Sourse_Code, T000A6_n469BR_Death_Sourse_Code, T000A6_A36BR_Information_PatientNo, T000A6_n36BR_Information_PatientNo, T000A6_A49BR_Death_Date,
               T000A6_n49BR_Death_Date, T000A6_A50BR_Death_Cause, T000A6_n50BR_Death_Cause, T000A6_A51BR_Death_CauseCode, T000A6_n51BR_Death_CauseCode, T000A6_A52BR_Death_Sourse, T000A6_n52BR_Death_Sourse, T000A6_A19BR_EncounterID
               }
               , new Object[] {
               T000A7_A85BR_Information_ID, T000A7_n85BR_Information_ID
               }
               , new Object[] {
               T000A8_A36BR_Information_PatientNo, T000A8_n36BR_Information_PatientNo
               }
               , new Object[] {
               T000A9_A48BR_DeathID
               }
               , new Object[] {
               T000A10_A48BR_DeathID
               }
               , new Object[] {
               T000A11_A48BR_DeathID
               }
               , new Object[] {
               T000A12_A48BR_DeathID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000A15_A85BR_Information_ID, T000A15_n85BR_Information_ID
               }
               , new Object[] {
               T000A16_A36BR_Information_PatientNo, T000A16_n36BR_Information_PatientNo
               }
               , new Object[] {
               T000A17_A48BR_DeathID
               }
               , new Object[] {
               T000A18_A167XT_DefineCodeID, T000A18_A168XT_DefineCodeName, T000A18_n168XT_DefineCodeName, T000A18_A165XT_DefindcodeTypeID, T000A18_A432XT_TenantCode, T000A18_n432XT_TenantCode
               }
               , new Object[] {
               T000A19_A167XT_DefineCodeID, T000A19_A168XT_DefineCodeName, T000A19_n168XT_DefineCodeName, T000A19_A165XT_DefindcodeTypeID, T000A19_A432XT_TenantCode, T000A19_n432XT_TenantCode
               }
               , new Object[] {
               T000A20_A85BR_Information_ID, T000A20_n85BR_Information_ID
               }
               , new Object[] {
               T000A21_A36BR_Information_PatientNo, T000A21_n36BR_Information_PatientNo
               }
            }
         );
      }

      private short GxWebError ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short GX_JID ;
      private short RcdFound11 ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int trnEnded ;
      private int edtBR_EncounterID_Enabled ;
      private int edtBR_Death_Date_Enabled ;
      private int edtBR_Death_Cause_Enabled ;
      private int bttBtntrn_enter_Visible ;
      private int bttBtntrn_enter_Enabled ;
      private int bttBtntrn_cancel_Visible ;
      private int bttBtntrn_delete_Visible ;
      private int bttBtntrn_delete_Enabled ;
      private int edtBR_DeathID_Enabled ;
      private int idxLst ;
      private int gxdynajaxindex ;
      private long Z48BR_DeathID ;
      private long Z19BR_EncounterID ;
      private long A19BR_EncounterID ;
      private long A85BR_Information_ID ;
      private long A48BR_DeathID ;
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
      private String dynBR_Death_CauseCode_Internalname ;
      private String dynBR_Death_Sourse_Internalname ;
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
      private String edtBR_Death_Date_Internalname ;
      private String edtBR_Death_Date_Jsonclick ;
      private String edtBR_Death_Cause_Internalname ;
      private String edtBR_Death_Cause_Jsonclick ;
      private String dynBR_Death_CauseCode_Jsonclick ;
      private String dynBR_Death_Sourse_Jsonclick ;
      private String bttBtntrn_enter_Internalname ;
      private String bttBtntrn_enter_Jsonclick ;
      private String bttBtntrn_cancel_Internalname ;
      private String bttBtntrn_cancel_Jsonclick ;
      private String bttBtntrn_delete_Internalname ;
      private String bttBtntrn_delete_Jsonclick ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String edtBR_DeathID_Internalname ;
      private String edtBR_DeathID_Jsonclick ;
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
      private String sMode11 ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String gxwrpcisep ;
      private String GXt_char1 ;
      private DateTime Z49BR_Death_Date ;
      private DateTime A49BR_Death_Date ;
      private bool entryPointCalled ;
      private bool n51BR_Death_CauseCode ;
      private bool n52BR_Death_Sourse ;
      private bool n85BR_Information_ID ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool Dvpanel_tableattributes_Autowidth ;
      private bool Dvpanel_tableattributes_Autoheight ;
      private bool Dvpanel_tableattributes_Collapsible ;
      private bool Dvpanel_tableattributes_Collapsed ;
      private bool Dvpanel_tableattributes_Showcollapseicon ;
      private bool Dvpanel_tableattributes_Autoscroll ;
      private bool n49BR_Death_Date ;
      private bool n50BR_Death_Cause ;
      private bool n501BR_Death_CauseCode_Code ;
      private bool n469BR_Death_Sourse_Code ;
      private bool n36BR_Information_PatientNo ;
      private bool Dvpanel_tableattributes_Enabled ;
      private bool Dvpanel_tableattributes_Showheader ;
      private bool Dvpanel_tableattributes_Visible ;
      private bool Gx_longc ;
      private bool gxdyncontrolsrefreshing ;
      private String Z501BR_Death_CauseCode_Code ;
      private String Z469BR_Death_Sourse_Code ;
      private String Z50BR_Death_Cause ;
      private String Z51BR_Death_CauseCode ;
      private String Z52BR_Death_Sourse ;
      private String AV12tCurrentCode ;
      private String A51BR_Death_CauseCode ;
      private String A52BR_Death_Sourse ;
      private String A50BR_Death_Cause ;
      private String A501BR_Death_CauseCode_Code ;
      private String A469BR_Death_Sourse_Code ;
      private String A36BR_Information_PatientNo ;
      private String Z36BR_Information_PatientNo ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrlcodr ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrldescr ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXUserControl ucDvpanel_tableattributes ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private GXCombobox dynBR_Death_CauseCode ;
      private GXCombobox dynBR_Death_Sourse ;
      private IDataStoreProvider pr_default ;
      private long[] T000A6_A85BR_Information_ID ;
      private bool[] T000A6_n85BR_Information_ID ;
      private long[] T000A6_A48BR_DeathID ;
      private String[] T000A6_A501BR_Death_CauseCode_Code ;
      private bool[] T000A6_n501BR_Death_CauseCode_Code ;
      private String[] T000A6_A469BR_Death_Sourse_Code ;
      private bool[] T000A6_n469BR_Death_Sourse_Code ;
      private String[] T000A6_A36BR_Information_PatientNo ;
      private bool[] T000A6_n36BR_Information_PatientNo ;
      private DateTime[] T000A6_A49BR_Death_Date ;
      private bool[] T000A6_n49BR_Death_Date ;
      private String[] T000A6_A50BR_Death_Cause ;
      private bool[] T000A6_n50BR_Death_Cause ;
      private String[] T000A6_A51BR_Death_CauseCode ;
      private bool[] T000A6_n51BR_Death_CauseCode ;
      private String[] T000A6_A52BR_Death_Sourse ;
      private bool[] T000A6_n52BR_Death_Sourse ;
      private long[] T000A6_A19BR_EncounterID ;
      private long[] T000A4_A85BR_Information_ID ;
      private bool[] T000A4_n85BR_Information_ID ;
      private String[] T000A5_A36BR_Information_PatientNo ;
      private bool[] T000A5_n36BR_Information_PatientNo ;
      private long[] T000A7_A85BR_Information_ID ;
      private bool[] T000A7_n85BR_Information_ID ;
      private String[] T000A8_A36BR_Information_PatientNo ;
      private bool[] T000A8_n36BR_Information_PatientNo ;
      private long[] T000A9_A48BR_DeathID ;
      private long[] T000A3_A48BR_DeathID ;
      private String[] T000A3_A501BR_Death_CauseCode_Code ;
      private bool[] T000A3_n501BR_Death_CauseCode_Code ;
      private String[] T000A3_A469BR_Death_Sourse_Code ;
      private bool[] T000A3_n469BR_Death_Sourse_Code ;
      private DateTime[] T000A3_A49BR_Death_Date ;
      private bool[] T000A3_n49BR_Death_Date ;
      private String[] T000A3_A50BR_Death_Cause ;
      private bool[] T000A3_n50BR_Death_Cause ;
      private String[] T000A3_A51BR_Death_CauseCode ;
      private bool[] T000A3_n51BR_Death_CauseCode ;
      private String[] T000A3_A52BR_Death_Sourse ;
      private bool[] T000A3_n52BR_Death_Sourse ;
      private long[] T000A3_A19BR_EncounterID ;
      private long[] T000A10_A48BR_DeathID ;
      private long[] T000A11_A48BR_DeathID ;
      private long[] T000A2_A48BR_DeathID ;
      private String[] T000A2_A501BR_Death_CauseCode_Code ;
      private bool[] T000A2_n501BR_Death_CauseCode_Code ;
      private String[] T000A2_A469BR_Death_Sourse_Code ;
      private bool[] T000A2_n469BR_Death_Sourse_Code ;
      private DateTime[] T000A2_A49BR_Death_Date ;
      private bool[] T000A2_n49BR_Death_Date ;
      private String[] T000A2_A50BR_Death_Cause ;
      private bool[] T000A2_n50BR_Death_Cause ;
      private String[] T000A2_A51BR_Death_CauseCode ;
      private bool[] T000A2_n51BR_Death_CauseCode ;
      private String[] T000A2_A52BR_Death_Sourse ;
      private bool[] T000A2_n52BR_Death_Sourse ;
      private long[] T000A2_A19BR_EncounterID ;
      private long[] T000A12_A48BR_DeathID ;
      private long[] T000A15_A85BR_Information_ID ;
      private bool[] T000A15_n85BR_Information_ID ;
      private String[] T000A16_A36BR_Information_PatientNo ;
      private bool[] T000A16_n36BR_Information_PatientNo ;
      private long[] T000A17_A48BR_DeathID ;
      private long[] T000A18_A167XT_DefineCodeID ;
      private String[] T000A18_A168XT_DefineCodeName ;
      private bool[] T000A18_n168XT_DefineCodeName ;
      private long[] T000A18_A165XT_DefindcodeTypeID ;
      private String[] T000A18_A432XT_TenantCode ;
      private bool[] T000A18_n432XT_TenantCode ;
      private long[] T000A19_A167XT_DefineCodeID ;
      private String[] T000A19_A168XT_DefineCodeName ;
      private bool[] T000A19_n168XT_DefineCodeName ;
      private long[] T000A19_A165XT_DefindcodeTypeID ;
      private String[] T000A19_A432XT_TenantCode ;
      private bool[] T000A19_n432XT_TenantCode ;
      private long[] T000A20_A85BR_Information_ID ;
      private bool[] T000A20_n85BR_Information_ID ;
      private String[] T000A21_A36BR_Information_PatientNo ;
      private bool[] T000A21_n36BR_Information_PatientNo ;
      private IDataStoreProvider pr_datastore1 ;
      private GXWebForm Form ;
   }

   public class br_death__datastore1 : DataStoreHelperBase, IDataStoreHelper
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

 public class br_death__default : DataStoreHelperBase, IDataStoreHelper
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
        Object[] prmT000A6 ;
        prmT000A6 = new Object[] {
        new Object[] {"@BR_DeathID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000A4 ;
        prmT000A4 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000A5 ;
        prmT000A5 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000A7 ;
        prmT000A7 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000A8 ;
        prmT000A8 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000A9 ;
        prmT000A9 = new Object[] {
        new Object[] {"@BR_DeathID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000A3 ;
        prmT000A3 = new Object[] {
        new Object[] {"@BR_DeathID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000A10 ;
        prmT000A10 = new Object[] {
        new Object[] {"@BR_DeathID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000A11 ;
        prmT000A11 = new Object[] {
        new Object[] {"@BR_DeathID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000A2 ;
        prmT000A2 = new Object[] {
        new Object[] {"@BR_DeathID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000A12 ;
        prmT000A12 = new Object[] {
        new Object[] {"@BR_Death_CauseCode_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Death_Sourse_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Death_Date",SqlDbType.DateTime,8,0} ,
        new Object[] {"@BR_Death_Cause",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Death_CauseCode",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Death_Sourse",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000A13 ;
        prmT000A13 = new Object[] {
        new Object[] {"@BR_Death_CauseCode_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Death_Sourse_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Death_Date",SqlDbType.DateTime,8,0} ,
        new Object[] {"@BR_Death_Cause",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Death_CauseCode",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Death_Sourse",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@BR_DeathID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000A14 ;
        prmT000A14 = new Object[] {
        new Object[] {"@BR_DeathID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000A15 ;
        prmT000A15 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000A16 ;
        prmT000A16 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000A17 ;
        prmT000A17 = new Object[] {
        } ;
        Object[] prmT000A18 ;
        prmT000A18 = new Object[] {
        new Object[] {"@AV12tCurrentCode",SqlDbType.NVarChar,40,0}
        } ;
        Object[] prmT000A19 ;
        prmT000A19 = new Object[] {
        new Object[] {"@AV12tCurrentCode",SqlDbType.NVarChar,40,0}
        } ;
        Object[] prmT000A20 ;
        prmT000A20 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000A21 ;
        prmT000A21 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("T000A2", "SELECT [BR_DeathID], [BR_Death_CauseCode_Code], [BR_Death_Sourse_Code], [BR_Death_Date], [BR_Death_Cause], [BR_Death_CauseCode], [BR_Death_Sourse], [BR_EncounterID] FROM [BR_Death] WITH (UPDLOCK) WHERE [BR_DeathID] = @BR_DeathID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000A2,1,0,true,false )
           ,new CursorDef("T000A3", "SELECT [BR_DeathID], [BR_Death_CauseCode_Code], [BR_Death_Sourse_Code], [BR_Death_Date], [BR_Death_Cause], [BR_Death_CauseCode], [BR_Death_Sourse], [BR_EncounterID] FROM [BR_Death] WITH (NOLOCK) WHERE [BR_DeathID] = @BR_DeathID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000A3,1,0,true,false )
           ,new CursorDef("T000A4", "SELECT [BR_Information_ID] FROM [BR_Encounter] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000A4,1,0,true,false )
           ,new CursorDef("T000A5", "SELECT [BR_Information_PatientNo] FROM [BR_Information] WITH (NOLOCK) WHERE [BR_Information_ID] = @BR_Information_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000A5,1,0,true,false )
           ,new CursorDef("T000A6", "SELECT T2.[BR_Information_ID], TM1.[BR_DeathID], TM1.[BR_Death_CauseCode_Code], TM1.[BR_Death_Sourse_Code], T3.[BR_Information_PatientNo], TM1.[BR_Death_Date], TM1.[BR_Death_Cause], TM1.[BR_Death_CauseCode], TM1.[BR_Death_Sourse], TM1.[BR_EncounterID] FROM (([BR_Death] TM1 WITH (NOLOCK) INNER JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = TM1.[BR_EncounterID]) LEFT JOIN [BR_Information] T3 WITH (NOLOCK) ON T3.[BR_Information_ID] = T2.[BR_Information_ID]) WHERE TM1.[BR_DeathID] = @BR_DeathID ORDER BY TM1.[BR_DeathID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000A6,100,0,true,false )
           ,new CursorDef("T000A7", "SELECT [BR_Information_ID] FROM [BR_Encounter] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000A7,1,0,true,false )
           ,new CursorDef("T000A8", "SELECT [BR_Information_PatientNo] FROM [BR_Information] WITH (NOLOCK) WHERE [BR_Information_ID] = @BR_Information_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000A8,1,0,true,false )
           ,new CursorDef("T000A9", "SELECT [BR_DeathID] FROM [BR_Death] WITH (NOLOCK) WHERE [BR_DeathID] = @BR_DeathID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000A9,1,0,true,false )
           ,new CursorDef("T000A10", "SELECT TOP 1 [BR_DeathID] FROM [BR_Death] WITH (NOLOCK) WHERE ( [BR_DeathID] > @BR_DeathID) ORDER BY [BR_DeathID]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000A10,1,0,true,true )
           ,new CursorDef("T000A11", "SELECT TOP 1 [BR_DeathID] FROM [BR_Death] WITH (NOLOCK) WHERE ( [BR_DeathID] < @BR_DeathID) ORDER BY [BR_DeathID] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000A11,1,0,true,true )
           ,new CursorDef("T000A12", "INSERT INTO [BR_Death]([BR_Death_CauseCode_Code], [BR_Death_Sourse_Code], [BR_Death_Date], [BR_Death_Cause], [BR_Death_CauseCode], [BR_Death_Sourse], [BR_EncounterID]) VALUES(@BR_Death_CauseCode_Code, @BR_Death_Sourse_Code, @BR_Death_Date, @BR_Death_Cause, @BR_Death_CauseCode, @BR_Death_Sourse, @BR_EncounterID); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmT000A12)
           ,new CursorDef("T000A13", "UPDATE [BR_Death] SET [BR_Death_CauseCode_Code]=@BR_Death_CauseCode_Code, [BR_Death_Sourse_Code]=@BR_Death_Sourse_Code, [BR_Death_Date]=@BR_Death_Date, [BR_Death_Cause]=@BR_Death_Cause, [BR_Death_CauseCode]=@BR_Death_CauseCode, [BR_Death_Sourse]=@BR_Death_Sourse, [BR_EncounterID]=@BR_EncounterID  WHERE [BR_DeathID] = @BR_DeathID", GxErrorMask.GX_NOMASK,prmT000A13)
           ,new CursorDef("T000A14", "DELETE FROM [BR_Death]  WHERE [BR_DeathID] = @BR_DeathID", GxErrorMask.GX_NOMASK,prmT000A14)
           ,new CursorDef("T000A15", "SELECT [BR_Information_ID] FROM [BR_Encounter] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000A15,1,0,true,false )
           ,new CursorDef("T000A16", "SELECT [BR_Information_PatientNo] FROM [BR_Information] WITH (NOLOCK) WHERE [BR_Information_ID] = @BR_Information_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000A16,1,0,true,false )
           ,new CursorDef("T000A17", "SELECT [BR_DeathID] FROM [BR_Death] WITH (NOLOCK) ORDER BY [BR_DeathID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000A17,100,0,true,false )
           ,new CursorDef("T000A18", "SELECT [XT_DefineCodeID], [XT_DefineCodeName], [XT_DefindcodeTypeID], [XT_TenantCode] FROM [XT_DefineCode] WITH (NOLOCK) WHERE ([XT_DefindcodeTypeID] = 18) AND ([XT_TenantCode] = @AV12tCurrentCode) ",true, GxErrorMask.GX_NOMASK, false, this,prmT000A18,0,0,true,false )
           ,new CursorDef("T000A19", "SELECT [XT_DefineCodeID], [XT_DefineCodeName], [XT_DefindcodeTypeID], [XT_TenantCode] FROM [XT_DefineCode] WITH (NOLOCK) WHERE ([XT_DefindcodeTypeID] = 19) AND ([XT_TenantCode] = @AV12tCurrentCode) ",true, GxErrorMask.GX_NOMASK, false, this,prmT000A19,0,0,true,false )
           ,new CursorDef("T000A20", "SELECT [BR_Information_ID] FROM [BR_Encounter] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000A20,1,0,true,false )
           ,new CursorDef("T000A21", "SELECT [BR_Information_PatientNo] FROM [BR_Information] WITH (NOLOCK) WHERE [BR_Information_ID] = @BR_Information_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000A21,1,0,true,false )
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
              ((DateTime[]) buf[5])[0] = rslt.getGXDate(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              ((long[]) buf[13])[0] = rslt.getLong(8) ;
              return;
           case 1 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((DateTime[]) buf[5])[0] = rslt.getGXDate(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              ((long[]) buf[13])[0] = rslt.getLong(8) ;
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
              ((DateTime[]) buf[9])[0] = rslt.getGXDate(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              ((String[]) buf[13])[0] = rslt.getVarchar(8) ;
              ((bool[]) buf[14])[0] = rslt.wasNull(8);
              ((String[]) buf[15])[0] = rslt.getVarchar(9) ;
              ((bool[]) buf[16])[0] = rslt.wasNull(9);
              ((long[]) buf[17])[0] = rslt.getLong(10) ;
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
                 stmt.setNull( 3 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameter(3, (DateTime)parms[5]);
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
              stmt.SetParameter(7, (long)parms[12]);
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
                 stmt.setNull( 3 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameter(3, (DateTime)parms[5]);
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
              stmt.SetParameter(7, (long)parms[12]);
              stmt.SetParameter(8, (long)parms[13]);
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
