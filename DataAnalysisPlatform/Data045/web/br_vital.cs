/*
               File: BR_Vital
        Description: Data Mgmt Portal - RAAP
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:7:18.90
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
   public class br_vital : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            XC_10_0J20( ) ;
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
            XC_11_0J20( ) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxJX_Action12") == 0 )
         {
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            XC_12_0J20( ) ;
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
         if ( ! entryPointCalled && ! ( isAjaxCallMode( ) || isFullAjaxMode( ) ) )
         {
            Gx_mode = gxfirstwebparm;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
            {
               AV12BR_VitalID = (long)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12BR_VitalID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12BR_VitalID), 18, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vBR_VITALID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV12BR_VitalID), "ZZZZZZZZZZZZZZZZZZ"), context));
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
            Form.Meta.addItem("description", "Data Mgmt Portal - RAAP", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtBR_Vital_MeasureDate_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("WorkWithPlusTheme");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public br_vital( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_vital( IGxContext context )
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
                           long aP1_BR_VitalID )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV12BR_VitalID = aP1_BR_VitalID;
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 RequiredDataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_vital_measuredate_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_vital_measuredate_Internalname, "测量日期", "", "", lblTextblockbr_vital_measuredate_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Vital.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Vital_MeasureDate_Internalname, "测量日期", "col-sm-3 AttributeDateLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtBR_Vital_MeasureDate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtBR_Vital_MeasureDate_Internalname, context.localUtil.Format(A152BR_Vital_MeasureDate, "9999/99/99"), context.localUtil.Format( A152BR_Vital_MeasureDate, "9999/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',0,24,'chs',false,1);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,29);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Vital_MeasureDate_Jsonclick, 0, "AttributeDate", "", "", "", "", 1, edtBR_Vital_MeasureDate_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "DM_Date", "right", false, "HLP_BR_Vital.htm");
            GxWebStd.gx_bitmap( context, edtBR_Vital_MeasureDate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtBR_Vital_MeasureDate_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_Vital.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_vital_temperature_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_vital_temperature_Internalname, "体温(℃)", "", "", lblTextblockbr_vital_temperature_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Vital.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Vital_Temperature_Internalname, "体温(℃)", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 37,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_Vital_Temperature_Internalname, StringUtil.LTrim( StringUtil.NToC( A153BR_Vital_Temperature, 15, 5, ".", "")), ((edtBR_Vital_Temperature_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A153BR_Vital_Temperature, "ZZZZZZZZZ.ZZZZZ")) : context.localUtil.Format( A153BR_Vital_Temperature, "ZZZZZZZZZ.ZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, ',','.','5');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,37);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Vital_Temperature_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBR_Vital_Temperature_Enabled, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "DM_Numeric", "right", false, "HLP_BR_Vital.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_vital_pulse_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_vital_pulse_Internalname, "脉搏(次/分钟)", "", "", lblTextblockbr_vital_pulse_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Vital.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Vital_Pulse_Internalname, "脉搏(次/分钟)", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_Vital_Pulse_Internalname, StringUtil.LTrim( StringUtil.NToC( A154BR_Vital_Pulse, 15, 5, ".", "")), ((edtBR_Vital_Pulse_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A154BR_Vital_Pulse, "ZZZZZZZZZ.ZZZZZ")) : context.localUtil.Format( A154BR_Vital_Pulse, "ZZZZZZZZZ.ZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, ',','.','5');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,46);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Vital_Pulse_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBR_Vital_Pulse_Enabled, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "DM_Numeric", "right", false, "HLP_BR_Vital.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_vital_respiration_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_vital_respiration_Internalname, "呼吸频率(次/分钟)", "", "", lblTextblockbr_vital_respiration_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Vital.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Vital_Respiration_Internalname, "呼吸频率(次/分钟)", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_Vital_Respiration_Internalname, StringUtil.LTrim( StringUtil.NToC( A155BR_Vital_Respiration, 15, 5, ".", "")), ((edtBR_Vital_Respiration_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A155BR_Vital_Respiration, "ZZZZZZZZZ.ZZZZZ")) : context.localUtil.Format( A155BR_Vital_Respiration, "ZZZZZZZZZ.ZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, ',','.','5');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,54);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Vital_Respiration_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBR_Vital_Respiration_Enabled, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "DM_Numeric", "right", false, "HLP_BR_Vital.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_vital_systolic_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_vital_systolic_Internalname, "收缩压(mmHg)", "", "", lblTextblockbr_vital_systolic_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Vital.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Vital_Systolic_Internalname, "收缩压(mmHg)", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_Vital_Systolic_Internalname, StringUtil.LTrim( StringUtil.NToC( A156BR_Vital_Systolic, 15, 5, ".", "")), ((edtBR_Vital_Systolic_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A156BR_Vital_Systolic, "ZZZZZZZZZ.ZZZZZ")) : context.localUtil.Format( A156BR_Vital_Systolic, "ZZZZZZZZZ.ZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, ',','.','5');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,63);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Vital_Systolic_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBR_Vital_Systolic_Enabled, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "DM_Numeric", "right", false, "HLP_BR_Vital.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_vital_diastolic_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_vital_diastolic_Internalname, "舒张压(mmHg)", "", "", lblTextblockbr_vital_diastolic_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Vital.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Vital_Diastolic_Internalname, "舒张压(mmHg)", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 71,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_Vital_Diastolic_Internalname, StringUtil.LTrim( StringUtil.NToC( A157BR_Vital_Diastolic, 15, 5, ".", "")), ((edtBR_Vital_Diastolic_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A157BR_Vital_Diastolic, "ZZZZZZZZZ.ZZZZZ")) : context.localUtil.Format( A157BR_Vital_Diastolic, "ZZZZZZZZZ.ZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, ',','.','5');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,71);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Vital_Diastolic_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBR_Vital_Diastolic_Enabled, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "DM_Numeric", "right", false, "HLP_BR_Vital.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_vital_height_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_vital_height_Internalname, "身高(cm)", "", "", lblTextblockbr_vital_height_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Vital.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Vital_Height_Internalname, "身高(cm)", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 80,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_Vital_Height_Internalname, StringUtil.LTrim( StringUtil.NToC( A158BR_Vital_Height, 15, 5, ".", "")), ((edtBR_Vital_Height_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A158BR_Vital_Height, "ZZZZZZZZZ.ZZZZZ")) : context.localUtil.Format( A158BR_Vital_Height, "ZZZZZZZZZ.ZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, ',','.','5');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,80);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Vital_Height_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBR_Vital_Height_Enabled, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "DM_Numeric", "right", false, "HLP_BR_Vital.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_vital_weight_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_vital_weight_Internalname, "体重(kg)", "", "", lblTextblockbr_vital_weight_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Vital.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Vital_Weight_Internalname, "体重(kg)", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 88,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_Vital_Weight_Internalname, StringUtil.LTrim( StringUtil.NToC( A159BR_Vital_Weight, 15, 5, ".", "")), ((edtBR_Vital_Weight_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A159BR_Vital_Weight, "ZZZZZZZZZ.ZZZZZ")) : context.localUtil.Format( A159BR_Vital_Weight, "ZZZZZZZZZ.ZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, ',','.','5');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,88);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Vital_Weight_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBR_Vital_Weight_Enabled, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "DM_Numeric", "right", false, "HLP_BR_Vital.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 93,'',false,'',0)\"";
            ClassString = "ButtonMaterial";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_enter_Internalname, "", "保存", bttBtntrn_enter_Jsonclick, 5, "确认", "", StyleString, ClassString, bttBtntrn_enter_Visible, bttBtntrn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_Vital.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 95,'',false,'',0)\"";
            ClassString = "ButtonMaterialDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_cancel_Internalname, "", "取消", bttBtntrn_cancel_Jsonclick, 1, "取消", "", StyleString, ClassString, bttBtntrn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_Vital.htm");
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
            GxWebStd.gx_single_line_edit( context, edtBR_VitalID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A150BR_VitalID), 18, 0, ".", "")), ((edtBR_VitalID_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A150BR_VitalID), "ZZZZZZZZZZZZZZZZZZ")) : context.localUtil.Format( (decimal)(A150BR_VitalID), "ZZZZZZZZZZZZZZZZZZ")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_VitalID_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_VitalID_Visible, edtBR_VitalID_Enabled, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "HLP_BR_Vital.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 100,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_EncounterID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A19BR_EncounterID), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A19BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,100);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_EncounterID_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_EncounterID_Visible, edtBR_EncounterID_Enabled, 1, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "HLP_BR_Vital.htm");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Information_PatientNo_Internalname, A36BR_Information_PatientNo, StringUtil.RTrim( context.localUtil.Format( A36BR_Information_PatientNo, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Information_PatientNo_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_Information_PatientNo_Visible, edtBR_Information_PatientNo_Enabled, 0, "text", "", 80, "chr", 1, "row", 2000, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Vital.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 102,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_Vital_VitalID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A151BR_Vital_VitalID), 10, 0, ".", "")), ((edtBR_Vital_VitalID_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A151BR_Vital_VitalID), "ZZZZZZZZZZ")) : context.localUtil.Format( (decimal)(A151BR_Vital_VitalID), "ZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,102);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Vital_VitalID_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_Vital_VitalID_Visible, edtBR_Vital_VitalID_Enabled, 0, "number", "1", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Vital.htm");
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
         E110J2 ();
         context.wbGlbDoneStart = 1;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
               if ( context.localUtil.VCDate( cgiGet( edtBR_Vital_MeasureDate_Internalname), 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"测量日期"}), 1, "BR_VITAL_MEASUREDATE");
                  AnyError = 1;
                  GX_FocusControl = edtBR_Vital_MeasureDate_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A152BR_Vital_MeasureDate = DateTime.MinValue;
                  n152BR_Vital_MeasureDate = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A152BR_Vital_MeasureDate", context.localUtil.Format(A152BR_Vital_MeasureDate, "9999/99/99"));
               }
               else
               {
                  A152BR_Vital_MeasureDate = context.localUtil.CToD( cgiGet( edtBR_Vital_MeasureDate_Internalname), 0);
                  n152BR_Vital_MeasureDate = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A152BR_Vital_MeasureDate", context.localUtil.Format(A152BR_Vital_MeasureDate, "9999/99/99"));
               }
               n152BR_Vital_MeasureDate = ((DateTime.MinValue==A152BR_Vital_MeasureDate) ? true : false);
               if ( ( ( context.localUtil.CToN( cgiGet( edtBR_Vital_Temperature_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtBR_Vital_Temperature_Internalname), ".", ",") > 999999999.99999m ) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_VITAL_TEMPERATURE");
                  AnyError = 1;
                  GX_FocusControl = edtBR_Vital_Temperature_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A153BR_Vital_Temperature = 0;
                  n153BR_Vital_Temperature = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A153BR_Vital_Temperature", StringUtil.LTrim( StringUtil.Str( A153BR_Vital_Temperature, 15, 5)));
               }
               else
               {
                  A153BR_Vital_Temperature = context.localUtil.CToN( cgiGet( edtBR_Vital_Temperature_Internalname), ".", ",");
                  n153BR_Vital_Temperature = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A153BR_Vital_Temperature", StringUtil.LTrim( StringUtil.Str( A153BR_Vital_Temperature, 15, 5)));
               }
               n153BR_Vital_Temperature = ((Convert.ToDecimal(0)==A153BR_Vital_Temperature) ? true : false);
               if ( ( ( context.localUtil.CToN( cgiGet( edtBR_Vital_Pulse_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtBR_Vital_Pulse_Internalname), ".", ",") > 999999999.99999m ) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_VITAL_PULSE");
                  AnyError = 1;
                  GX_FocusControl = edtBR_Vital_Pulse_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A154BR_Vital_Pulse = 0;
                  n154BR_Vital_Pulse = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A154BR_Vital_Pulse", StringUtil.LTrim( StringUtil.Str( A154BR_Vital_Pulse, 15, 5)));
               }
               else
               {
                  A154BR_Vital_Pulse = context.localUtil.CToN( cgiGet( edtBR_Vital_Pulse_Internalname), ".", ",");
                  n154BR_Vital_Pulse = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A154BR_Vital_Pulse", StringUtil.LTrim( StringUtil.Str( A154BR_Vital_Pulse, 15, 5)));
               }
               n154BR_Vital_Pulse = ((Convert.ToDecimal(0)==A154BR_Vital_Pulse) ? true : false);
               if ( ( ( context.localUtil.CToN( cgiGet( edtBR_Vital_Respiration_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtBR_Vital_Respiration_Internalname), ".", ",") > 999999999.99999m ) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_VITAL_RESPIRATION");
                  AnyError = 1;
                  GX_FocusControl = edtBR_Vital_Respiration_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A155BR_Vital_Respiration = 0;
                  n155BR_Vital_Respiration = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A155BR_Vital_Respiration", StringUtil.LTrim( StringUtil.Str( A155BR_Vital_Respiration, 15, 5)));
               }
               else
               {
                  A155BR_Vital_Respiration = context.localUtil.CToN( cgiGet( edtBR_Vital_Respiration_Internalname), ".", ",");
                  n155BR_Vital_Respiration = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A155BR_Vital_Respiration", StringUtil.LTrim( StringUtil.Str( A155BR_Vital_Respiration, 15, 5)));
               }
               n155BR_Vital_Respiration = ((Convert.ToDecimal(0)==A155BR_Vital_Respiration) ? true : false);
               if ( ( ( context.localUtil.CToN( cgiGet( edtBR_Vital_Systolic_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtBR_Vital_Systolic_Internalname), ".", ",") > 999999999.99999m ) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_VITAL_SYSTOLIC");
                  AnyError = 1;
                  GX_FocusControl = edtBR_Vital_Systolic_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A156BR_Vital_Systolic = 0;
                  n156BR_Vital_Systolic = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A156BR_Vital_Systolic", StringUtil.LTrim( StringUtil.Str( A156BR_Vital_Systolic, 15, 5)));
               }
               else
               {
                  A156BR_Vital_Systolic = context.localUtil.CToN( cgiGet( edtBR_Vital_Systolic_Internalname), ".", ",");
                  n156BR_Vital_Systolic = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A156BR_Vital_Systolic", StringUtil.LTrim( StringUtil.Str( A156BR_Vital_Systolic, 15, 5)));
               }
               n156BR_Vital_Systolic = ((Convert.ToDecimal(0)==A156BR_Vital_Systolic) ? true : false);
               if ( ( ( context.localUtil.CToN( cgiGet( edtBR_Vital_Diastolic_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtBR_Vital_Diastolic_Internalname), ".", ",") > 999999999.99999m ) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_VITAL_DIASTOLIC");
                  AnyError = 1;
                  GX_FocusControl = edtBR_Vital_Diastolic_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A157BR_Vital_Diastolic = 0;
                  n157BR_Vital_Diastolic = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A157BR_Vital_Diastolic", StringUtil.LTrim( StringUtil.Str( A157BR_Vital_Diastolic, 15, 5)));
               }
               else
               {
                  A157BR_Vital_Diastolic = context.localUtil.CToN( cgiGet( edtBR_Vital_Diastolic_Internalname), ".", ",");
                  n157BR_Vital_Diastolic = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A157BR_Vital_Diastolic", StringUtil.LTrim( StringUtil.Str( A157BR_Vital_Diastolic, 15, 5)));
               }
               n157BR_Vital_Diastolic = ((Convert.ToDecimal(0)==A157BR_Vital_Diastolic) ? true : false);
               if ( ( ( context.localUtil.CToN( cgiGet( edtBR_Vital_Height_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtBR_Vital_Height_Internalname), ".", ",") > 999999999.99999m ) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_VITAL_HEIGHT");
                  AnyError = 1;
                  GX_FocusControl = edtBR_Vital_Height_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A158BR_Vital_Height = 0;
                  n158BR_Vital_Height = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A158BR_Vital_Height", StringUtil.LTrim( StringUtil.Str( A158BR_Vital_Height, 15, 5)));
               }
               else
               {
                  A158BR_Vital_Height = context.localUtil.CToN( cgiGet( edtBR_Vital_Height_Internalname), ".", ",");
                  n158BR_Vital_Height = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A158BR_Vital_Height", StringUtil.LTrim( StringUtil.Str( A158BR_Vital_Height, 15, 5)));
               }
               n158BR_Vital_Height = ((Convert.ToDecimal(0)==A158BR_Vital_Height) ? true : false);
               if ( ( ( context.localUtil.CToN( cgiGet( edtBR_Vital_Weight_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtBR_Vital_Weight_Internalname), ".", ",") > 999999999.99999m ) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_VITAL_WEIGHT");
                  AnyError = 1;
                  GX_FocusControl = edtBR_Vital_Weight_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A159BR_Vital_Weight = 0;
                  n159BR_Vital_Weight = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A159BR_Vital_Weight", StringUtil.LTrim( StringUtil.Str( A159BR_Vital_Weight, 15, 5)));
               }
               else
               {
                  A159BR_Vital_Weight = context.localUtil.CToN( cgiGet( edtBR_Vital_Weight_Internalname), ".", ",");
                  n159BR_Vital_Weight = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A159BR_Vital_Weight", StringUtil.LTrim( StringUtil.Str( A159BR_Vital_Weight, 15, 5)));
               }
               n159BR_Vital_Weight = ((Convert.ToDecimal(0)==A159BR_Vital_Weight) ? true : false);
               A150BR_VitalID = (long)(context.localUtil.CToN( cgiGet( edtBR_VitalID_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A150BR_VitalID", StringUtil.LTrim( StringUtil.Str( (decimal)(A150BR_VitalID), 18, 0)));
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
               A36BR_Information_PatientNo = cgiGet( edtBR_Information_PatientNo_Internalname);
               n36BR_Information_PatientNo = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36BR_Information_PatientNo", A36BR_Information_PatientNo);
               if ( ( ( context.localUtil.CToN( cgiGet( edtBR_Vital_VitalID_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtBR_Vital_VitalID_Internalname), ".", ",") > Convert.ToDecimal( 9999999999L )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_VITAL_VITALID");
                  AnyError = 1;
                  GX_FocusControl = edtBR_Vital_VitalID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A151BR_Vital_VitalID = 0;
                  n151BR_Vital_VitalID = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A151BR_Vital_VitalID", StringUtil.LTrim( StringUtil.Str( (decimal)(A151BR_Vital_VitalID), 10, 0)));
               }
               else
               {
                  A151BR_Vital_VitalID = (long)(context.localUtil.CToN( cgiGet( edtBR_Vital_VitalID_Internalname), ".", ","));
                  n151BR_Vital_VitalID = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A151BR_Vital_VitalID", StringUtil.LTrim( StringUtil.Str( (decimal)(A151BR_Vital_VitalID), 10, 0)));
               }
               n151BR_Vital_VitalID = ((0==A151BR_Vital_VitalID) ? true : false);
               /* Read saved values. */
               Z150BR_VitalID = (long)(context.localUtil.CToN( cgiGet( "Z150BR_VitalID"), ".", ","));
               Z151BR_Vital_VitalID = (long)(context.localUtil.CToN( cgiGet( "Z151BR_Vital_VitalID"), ".", ","));
               n151BR_Vital_VitalID = ((0==A151BR_Vital_VitalID) ? true : false);
               Z152BR_Vital_MeasureDate = context.localUtil.CToD( cgiGet( "Z152BR_Vital_MeasureDate"), 0);
               n152BR_Vital_MeasureDate = ((DateTime.MinValue==A152BR_Vital_MeasureDate) ? true : false);
               Z153BR_Vital_Temperature = context.localUtil.CToN( cgiGet( "Z153BR_Vital_Temperature"), ".", ",");
               n153BR_Vital_Temperature = ((Convert.ToDecimal(0)==A153BR_Vital_Temperature) ? true : false);
               Z154BR_Vital_Pulse = context.localUtil.CToN( cgiGet( "Z154BR_Vital_Pulse"), ".", ",");
               n154BR_Vital_Pulse = ((Convert.ToDecimal(0)==A154BR_Vital_Pulse) ? true : false);
               Z155BR_Vital_Respiration = context.localUtil.CToN( cgiGet( "Z155BR_Vital_Respiration"), ".", ",");
               n155BR_Vital_Respiration = ((Convert.ToDecimal(0)==A155BR_Vital_Respiration) ? true : false);
               Z156BR_Vital_Systolic = context.localUtil.CToN( cgiGet( "Z156BR_Vital_Systolic"), ".", ",");
               n156BR_Vital_Systolic = ((Convert.ToDecimal(0)==A156BR_Vital_Systolic) ? true : false);
               Z157BR_Vital_Diastolic = context.localUtil.CToN( cgiGet( "Z157BR_Vital_Diastolic"), ".", ",");
               n157BR_Vital_Diastolic = ((Convert.ToDecimal(0)==A157BR_Vital_Diastolic) ? true : false);
               Z158BR_Vital_Height = context.localUtil.CToN( cgiGet( "Z158BR_Vital_Height"), ".", ",");
               n158BR_Vital_Height = ((Convert.ToDecimal(0)==A158BR_Vital_Height) ? true : false);
               Z159BR_Vital_Weight = context.localUtil.CToN( cgiGet( "Z159BR_Vital_Weight"), ".", ",");
               n159BR_Vital_Weight = ((Convert.ToDecimal(0)==A159BR_Vital_Weight) ? true : false);
               Z19BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( "Z19BR_EncounterID"), ".", ","));
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ","));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ","));
               Gx_mode = cgiGet( "Mode");
               N19BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( "N19BR_EncounterID"), ".", ","));
               AV12BR_VitalID = (long)(context.localUtil.CToN( cgiGet( "vBR_VITALID"), ".", ","));
               AV10Insert_BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( "vINSERT_BR_ENCOUNTERID"), ".", ","));
               A85BR_Information_ID = (long)(context.localUtil.CToN( cgiGet( "BR_INFORMATION_ID"), ".", ","));
               AV17Pgmname = cgiGet( "vPGMNAME");
               AV16Pgmdesc = cgiGet( "vPGMDESC");
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
               forbiddenHiddens = "hsh" + "BR_Vital";
               A150BR_VitalID = (long)(context.localUtil.CToN( cgiGet( edtBR_VitalID_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A150BR_VitalID", StringUtil.LTrim( StringUtil.Str( (decimal)(A150BR_VitalID), 18, 0)));
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A150BR_VitalID), "ZZZZZZZZZZZZZZZZZZ");
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV10Insert_BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ");
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( A150BR_VitalID != Z150BR_VitalID ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
               {
                  GXUtil.WriteLog("br_vital:[SecurityCheckFailed value for]"+"BR_VitalID:"+context.localUtil.Format( (decimal)(A150BR_VitalID), "ZZZZZZZZZZZZZZZZZZ"));
                  GXUtil.WriteLog("br_vital:[SecurityCheckFailed value for]"+"Insert_BR_EncounterID:"+context.localUtil.Format( (decimal)(AV10Insert_BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ"));
                  GXUtil.WriteLog("br_vital:[SecurityCheckFailed value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
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
                  A150BR_VitalID = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A150BR_VitalID", StringUtil.LTrim( StringUtil.Str( (decimal)(A150BR_VitalID), 18, 0)));
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
                     sMode20 = Gx_mode;
                     Gx_mode = "UPD";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     Gx_mode = sMode20;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound20 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_0J0( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtntrn_enter_Internalname;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert", ""), 1, "BR_VITALID");
                        AnyError = 1;
                        GX_FocusControl = edtBR_VitalID_Internalname;
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
                           E110J2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: After Trn */
                           E120J2 ();
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
            E120J2 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll0J20( ) ;
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
            DisableAttributes0J20( ) ;
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

      protected void CONFIRM_0J0( )
      {
         BeforeValidate0J20( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0J20( ) ;
            }
            else
            {
               CheckExtendedTable0J20( ) ;
               CloseExtendedTableCursors0J20( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         }
      }

      protected void ResetCaption0J0( )
      {
      }

      protected void E110J2( )
      {
         /* Start Routine */
         AV16Pgmdesc = "Data Mgmt Portal -RAAP";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16Pgmdesc", AV16Pgmdesc);
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV7WWPContext) ;
         AV13IsAuthorized = true;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13IsAuthorized", AV13IsAuthorized);
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            GXt_boolean1 = AV13IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Vital", out  GXt_boolean1) ;
            AV13IsAuthorized = GXt_boolean1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13IsAuthorized", AV13IsAuthorized);
         }
         if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
         {
            GXt_boolean1 = AV13IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Vital", out  GXt_boolean1) ;
            AV13IsAuthorized = GXt_boolean1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13IsAuthorized", AV13IsAuthorized);
         }
         if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
         {
            GXt_boolean1 = AV13IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Vital", out  GXt_boolean1) ;
            AV13IsAuthorized = GXt_boolean1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13IsAuthorized", AV13IsAuthorized);
         }
         if ( ! AV13IsAuthorized )
         {
            CallWebObject(formatLink("wwpbaseobjects.notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV17Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         AV8TrnContext.FromXml(AV9WebSession.Get("TrnContext"), null, "WWPTransactionContext", "DataAnalysisPlatform");
         if ( ( StringUtil.StrCmp(AV8TrnContext.gxTpr_Transactionname, AV17Pgmname) == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) )
         {
            AV18GXV1 = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18GXV1), 8, 0)));
            while ( AV18GXV1 <= AV8TrnContext.gxTpr_Attributes.Count )
            {
               AV11TrnContextAtt = ((GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute)AV8TrnContext.gxTpr_Attributes.Item(AV18GXV1));
               if ( StringUtil.StrCmp(AV11TrnContextAtt.gxTpr_Attributename, "BR_EncounterID") == 0 )
               {
                  AV10Insert_BR_EncounterID = (long)(NumberUtil.Val( AV11TrnContextAtt.gxTpr_Attributevalue, "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10Insert_BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10Insert_BR_EncounterID), 18, 0)));
               }
               AV18GXV1 = (int)(AV18GXV1+1);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18GXV1), 8, 0)));
            }
         }
         edtBR_VitalID_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_VitalID_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_VitalID_Visible), 5, 0)), true);
         edtBR_EncounterID_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_EncounterID_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_EncounterID_Visible), 5, 0)), true);
         edtBR_Information_PatientNo_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Information_PatientNo_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Information_PatientNo_Visible), 5, 0)), true);
         edtBR_Vital_VitalID_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Vital_VitalID_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Vital_VitalID_Visible), 5, 0)), true);
      }

      protected void E120J2( )
      {
         /* After Trn Routine */
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV8TrnContext.gxTpr_Callerondelete )
         {
            CallWebObject(formatLink("br_vitalww.aspx") );
            context.wjLocDisableFrm = 1;
         }
         context.setWebReturnParms(new Object[] {});
         context.setWebReturnParmsMetadata(new Object[] {});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      protected void ZM0J20( short GX_JID )
      {
         if ( ( GX_JID == 13 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z151BR_Vital_VitalID = T000J3_A151BR_Vital_VitalID[0];
               Z152BR_Vital_MeasureDate = T000J3_A152BR_Vital_MeasureDate[0];
               Z153BR_Vital_Temperature = T000J3_A153BR_Vital_Temperature[0];
               Z154BR_Vital_Pulse = T000J3_A154BR_Vital_Pulse[0];
               Z155BR_Vital_Respiration = T000J3_A155BR_Vital_Respiration[0];
               Z156BR_Vital_Systolic = T000J3_A156BR_Vital_Systolic[0];
               Z157BR_Vital_Diastolic = T000J3_A157BR_Vital_Diastolic[0];
               Z158BR_Vital_Height = T000J3_A158BR_Vital_Height[0];
               Z159BR_Vital_Weight = T000J3_A159BR_Vital_Weight[0];
               Z19BR_EncounterID = T000J3_A19BR_EncounterID[0];
            }
            else
            {
               Z151BR_Vital_VitalID = A151BR_Vital_VitalID;
               Z152BR_Vital_MeasureDate = A152BR_Vital_MeasureDate;
               Z153BR_Vital_Temperature = A153BR_Vital_Temperature;
               Z154BR_Vital_Pulse = A154BR_Vital_Pulse;
               Z155BR_Vital_Respiration = A155BR_Vital_Respiration;
               Z156BR_Vital_Systolic = A156BR_Vital_Systolic;
               Z157BR_Vital_Diastolic = A157BR_Vital_Diastolic;
               Z158BR_Vital_Height = A158BR_Vital_Height;
               Z159BR_Vital_Weight = A159BR_Vital_Weight;
               Z19BR_EncounterID = A19BR_EncounterID;
            }
         }
         if ( GX_JID == -13 )
         {
            Z150BR_VitalID = A150BR_VitalID;
            Z151BR_Vital_VitalID = A151BR_Vital_VitalID;
            Z152BR_Vital_MeasureDate = A152BR_Vital_MeasureDate;
            Z153BR_Vital_Temperature = A153BR_Vital_Temperature;
            Z154BR_Vital_Pulse = A154BR_Vital_Pulse;
            Z155BR_Vital_Respiration = A155BR_Vital_Respiration;
            Z156BR_Vital_Systolic = A156BR_Vital_Systolic;
            Z157BR_Vital_Diastolic = A157BR_Vital_Diastolic;
            Z158BR_Vital_Height = A158BR_Vital_Height;
            Z159BR_Vital_Weight = A159BR_Vital_Weight;
            Z19BR_EncounterID = A19BR_EncounterID;
            Z85BR_Information_ID = A85BR_Information_ID;
            Z36BR_Information_PatientNo = A36BR_Information_PatientNo;
         }
      }

      protected void standaloneNotModal( )
      {
         edtBR_VitalID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_VitalID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_VitalID_Enabled), 5, 0)), true);
         edtBR_VitalID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_VitalID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_VitalID_Enabled), 5, 0)), true);
         if ( ! (0==AV12BR_VitalID) )
         {
            A150BR_VitalID = AV12BR_VitalID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A150BR_VitalID", StringUtil.LTrim( StringUtil.Str( (decimal)(A150BR_VitalID), 18, 0)));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV10Insert_BR_EncounterID) )
         {
            edtBR_EncounterID_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_EncounterID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_EncounterID_Enabled), 5, 0)), true);
         }
         else
         {
            edtBR_EncounterID_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_EncounterID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_EncounterID_Enabled), 5, 0)), true);
         }
      }

      protected void standaloneModal( )
      {
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV10Insert_BR_EncounterID) )
         {
            A19BR_EncounterID = AV10Insert_BR_EncounterID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
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
            AV17Pgmname = "BR_Vital";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17Pgmname", AV17Pgmname);
            AV16Pgmdesc = "Data Mgmt Portal - RAAP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16Pgmdesc", AV16Pgmdesc);
            /* Using cursor T000J4 */
            pr_default.execute(2, new Object[] {A19BR_EncounterID});
            A85BR_Information_ID = T000J4_A85BR_Information_ID[0];
            n85BR_Information_ID = T000J4_n85BR_Information_ID[0];
            pr_default.close(2);
            /* Using cursor T000J5 */
            pr_default.execute(3, new Object[] {n85BR_Information_ID, A85BR_Information_ID});
            A36BR_Information_PatientNo = T000J5_A36BR_Information_PatientNo[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36BR_Information_PatientNo", A36BR_Information_PatientNo);
            n36BR_Information_PatientNo = T000J5_n36BR_Information_PatientNo[0];
            pr_default.close(3);
         }
      }

      protected void Load0J20( )
      {
         /* Using cursor T000J6 */
         pr_default.execute(4, new Object[] {A150BR_VitalID});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound20 = 1;
            A85BR_Information_ID = T000J6_A85BR_Information_ID[0];
            n85BR_Information_ID = T000J6_n85BR_Information_ID[0];
            A36BR_Information_PatientNo = T000J6_A36BR_Information_PatientNo[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36BR_Information_PatientNo", A36BR_Information_PatientNo);
            n36BR_Information_PatientNo = T000J6_n36BR_Information_PatientNo[0];
            A151BR_Vital_VitalID = T000J6_A151BR_Vital_VitalID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A151BR_Vital_VitalID", StringUtil.LTrim( StringUtil.Str( (decimal)(A151BR_Vital_VitalID), 10, 0)));
            n151BR_Vital_VitalID = T000J6_n151BR_Vital_VitalID[0];
            A152BR_Vital_MeasureDate = T000J6_A152BR_Vital_MeasureDate[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A152BR_Vital_MeasureDate", context.localUtil.Format(A152BR_Vital_MeasureDate, "9999/99/99"));
            n152BR_Vital_MeasureDate = T000J6_n152BR_Vital_MeasureDate[0];
            A153BR_Vital_Temperature = T000J6_A153BR_Vital_Temperature[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A153BR_Vital_Temperature", StringUtil.LTrim( StringUtil.Str( A153BR_Vital_Temperature, 15, 5)));
            n153BR_Vital_Temperature = T000J6_n153BR_Vital_Temperature[0];
            A154BR_Vital_Pulse = T000J6_A154BR_Vital_Pulse[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A154BR_Vital_Pulse", StringUtil.LTrim( StringUtil.Str( A154BR_Vital_Pulse, 15, 5)));
            n154BR_Vital_Pulse = T000J6_n154BR_Vital_Pulse[0];
            A155BR_Vital_Respiration = T000J6_A155BR_Vital_Respiration[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A155BR_Vital_Respiration", StringUtil.LTrim( StringUtil.Str( A155BR_Vital_Respiration, 15, 5)));
            n155BR_Vital_Respiration = T000J6_n155BR_Vital_Respiration[0];
            A156BR_Vital_Systolic = T000J6_A156BR_Vital_Systolic[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A156BR_Vital_Systolic", StringUtil.LTrim( StringUtil.Str( A156BR_Vital_Systolic, 15, 5)));
            n156BR_Vital_Systolic = T000J6_n156BR_Vital_Systolic[0];
            A157BR_Vital_Diastolic = T000J6_A157BR_Vital_Diastolic[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A157BR_Vital_Diastolic", StringUtil.LTrim( StringUtil.Str( A157BR_Vital_Diastolic, 15, 5)));
            n157BR_Vital_Diastolic = T000J6_n157BR_Vital_Diastolic[0];
            A158BR_Vital_Height = T000J6_A158BR_Vital_Height[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A158BR_Vital_Height", StringUtil.LTrim( StringUtil.Str( A158BR_Vital_Height, 15, 5)));
            n158BR_Vital_Height = T000J6_n158BR_Vital_Height[0];
            A159BR_Vital_Weight = T000J6_A159BR_Vital_Weight[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A159BR_Vital_Weight", StringUtil.LTrim( StringUtil.Str( A159BR_Vital_Weight, 15, 5)));
            n159BR_Vital_Weight = T000J6_n159BR_Vital_Weight[0];
            A19BR_EncounterID = T000J6_A19BR_EncounterID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
            ZM0J20( -13) ;
         }
         pr_default.close(4);
         OnLoadActions0J20( ) ;
      }

      protected void OnLoadActions0J20( )
      {
         AV17Pgmname = "BR_Vital";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17Pgmname", AV17Pgmname);
         AV16Pgmdesc = "Data Mgmt Portal - RAAP";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16Pgmdesc", AV16Pgmdesc);
      }

      protected void CheckExtendedTable0J20( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
         AV17Pgmname = "BR_Vital";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17Pgmname", AV17Pgmname);
         AV16Pgmdesc = "Data Mgmt Portal - RAAP";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16Pgmdesc", AV16Pgmdesc);
         /* Using cursor T000J4 */
         pr_default.execute(2, new Object[] {A19BR_EncounterID});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("不匹配' T15'", "ForeignKeyNotFound", 1, "BR_ENCOUNTERID");
            AnyError = 1;
            GX_FocusControl = edtBR_EncounterID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A85BR_Information_ID = T000J4_A85BR_Information_ID[0];
         n85BR_Information_ID = T000J4_n85BR_Information_ID[0];
         pr_default.close(2);
         /* Using cursor T000J5 */
         pr_default.execute(3, new Object[] {n85BR_Information_ID, A85BR_Information_ID});
         if ( (pr_default.getStatus(3) == 101) )
         {
            if ( ! ( (0==A85BR_Information_ID) ) )
            {
               GX_msglist.addItem("不匹配' T16'", "ForeignKeyNotFound", 1, "");
               AnyError = 1;
            }
         }
         A36BR_Information_PatientNo = T000J5_A36BR_Information_PatientNo[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36BR_Information_PatientNo", A36BR_Information_PatientNo);
         n36BR_Information_PatientNo = T000J5_n36BR_Information_PatientNo[0];
         pr_default.close(3);
         if ( ! ( (DateTime.MinValue==A152BR_Vital_MeasureDate) || ( A152BR_Vital_MeasureDate >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("域测量日期超界", "OutOfRange", 1, "BR_VITAL_MEASUREDATE");
            AnyError = 1;
            GX_FocusControl = edtBR_Vital_MeasureDate_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( (DateTime.MinValue==A152BR_Vital_MeasureDate) )
         {
            GX_msglist.addItem("测量日期是必须填写的。", 1, "BR_VITAL_MEASUREDATE");
            AnyError = 1;
            GX_FocusControl = edtBR_Vital_MeasureDate_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
      }

      protected void CloseExtendedTableCursors0J20( )
      {
         pr_default.close(2);
         pr_default.close(3);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_14( long A19BR_EncounterID )
      {
         /* Using cursor T000J7 */
         pr_default.execute(5, new Object[] {A19BR_EncounterID});
         if ( (pr_default.getStatus(5) == 101) )
         {
            GX_msglist.addItem("不匹配' T15'", "ForeignKeyNotFound", 1, "BR_ENCOUNTERID");
            AnyError = 1;
            GX_FocusControl = edtBR_EncounterID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A85BR_Information_ID = T000J7_A85BR_Information_ID[0];
         n85BR_Information_ID = T000J7_n85BR_Information_ID[0];
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
         /* Using cursor T000J8 */
         pr_default.execute(6, new Object[] {n85BR_Information_ID, A85BR_Information_ID});
         if ( (pr_default.getStatus(6) == 101) )
         {
            if ( ! ( (0==A85BR_Information_ID) ) )
            {
               GX_msglist.addItem("不匹配' T16'", "ForeignKeyNotFound", 1, "");
               AnyError = 1;
            }
         }
         A36BR_Information_PatientNo = T000J8_A36BR_Information_PatientNo[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36BR_Information_PatientNo", A36BR_Information_PatientNo);
         n36BR_Information_PatientNo = T000J8_n36BR_Information_PatientNo[0];
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

      protected void GetKey0J20( )
      {
         /* Using cursor T000J9 */
         pr_default.execute(7, new Object[] {A150BR_VitalID});
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound20 = 1;
         }
         else
         {
            RcdFound20 = 0;
         }
         pr_default.close(7);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T000J3 */
         pr_default.execute(1, new Object[] {A150BR_VitalID});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0J20( 13) ;
            RcdFound20 = 1;
            A150BR_VitalID = T000J3_A150BR_VitalID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A150BR_VitalID", StringUtil.LTrim( StringUtil.Str( (decimal)(A150BR_VitalID), 18, 0)));
            A151BR_Vital_VitalID = T000J3_A151BR_Vital_VitalID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A151BR_Vital_VitalID", StringUtil.LTrim( StringUtil.Str( (decimal)(A151BR_Vital_VitalID), 10, 0)));
            n151BR_Vital_VitalID = T000J3_n151BR_Vital_VitalID[0];
            A152BR_Vital_MeasureDate = T000J3_A152BR_Vital_MeasureDate[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A152BR_Vital_MeasureDate", context.localUtil.Format(A152BR_Vital_MeasureDate, "9999/99/99"));
            n152BR_Vital_MeasureDate = T000J3_n152BR_Vital_MeasureDate[0];
            A153BR_Vital_Temperature = T000J3_A153BR_Vital_Temperature[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A153BR_Vital_Temperature", StringUtil.LTrim( StringUtil.Str( A153BR_Vital_Temperature, 15, 5)));
            n153BR_Vital_Temperature = T000J3_n153BR_Vital_Temperature[0];
            A154BR_Vital_Pulse = T000J3_A154BR_Vital_Pulse[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A154BR_Vital_Pulse", StringUtil.LTrim( StringUtil.Str( A154BR_Vital_Pulse, 15, 5)));
            n154BR_Vital_Pulse = T000J3_n154BR_Vital_Pulse[0];
            A155BR_Vital_Respiration = T000J3_A155BR_Vital_Respiration[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A155BR_Vital_Respiration", StringUtil.LTrim( StringUtil.Str( A155BR_Vital_Respiration, 15, 5)));
            n155BR_Vital_Respiration = T000J3_n155BR_Vital_Respiration[0];
            A156BR_Vital_Systolic = T000J3_A156BR_Vital_Systolic[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A156BR_Vital_Systolic", StringUtil.LTrim( StringUtil.Str( A156BR_Vital_Systolic, 15, 5)));
            n156BR_Vital_Systolic = T000J3_n156BR_Vital_Systolic[0];
            A157BR_Vital_Diastolic = T000J3_A157BR_Vital_Diastolic[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A157BR_Vital_Diastolic", StringUtil.LTrim( StringUtil.Str( A157BR_Vital_Diastolic, 15, 5)));
            n157BR_Vital_Diastolic = T000J3_n157BR_Vital_Diastolic[0];
            A158BR_Vital_Height = T000J3_A158BR_Vital_Height[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A158BR_Vital_Height", StringUtil.LTrim( StringUtil.Str( A158BR_Vital_Height, 15, 5)));
            n158BR_Vital_Height = T000J3_n158BR_Vital_Height[0];
            A159BR_Vital_Weight = T000J3_A159BR_Vital_Weight[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A159BR_Vital_Weight", StringUtil.LTrim( StringUtil.Str( A159BR_Vital_Weight, 15, 5)));
            n159BR_Vital_Weight = T000J3_n159BR_Vital_Weight[0];
            A19BR_EncounterID = T000J3_A19BR_EncounterID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
            Z150BR_VitalID = A150BR_VitalID;
            sMode20 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load0J20( ) ;
            if ( AnyError == 1 )
            {
               RcdFound20 = 0;
               InitializeNonKey0J20( ) ;
            }
            Gx_mode = sMode20;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound20 = 0;
            InitializeNonKey0J20( ) ;
            sMode20 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal( ) ;
            Gx_mode = sMode20;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0J20( ) ;
         if ( RcdFound20 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound20 = 0;
         /* Using cursor T000J10 */
         pr_default.execute(8, new Object[] {A150BR_VitalID});
         if ( (pr_default.getStatus(8) != 101) )
         {
            while ( (pr_default.getStatus(8) != 101) && ( ( T000J10_A150BR_VitalID[0] < A150BR_VitalID ) ) )
            {
               pr_default.readNext(8);
            }
            if ( (pr_default.getStatus(8) != 101) && ( ( T000J10_A150BR_VitalID[0] > A150BR_VitalID ) ) )
            {
               A150BR_VitalID = T000J10_A150BR_VitalID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A150BR_VitalID", StringUtil.LTrim( StringUtil.Str( (decimal)(A150BR_VitalID), 18, 0)));
               RcdFound20 = 1;
            }
         }
         pr_default.close(8);
      }

      protected void move_previous( )
      {
         RcdFound20 = 0;
         /* Using cursor T000J11 */
         pr_default.execute(9, new Object[] {A150BR_VitalID});
         if ( (pr_default.getStatus(9) != 101) )
         {
            while ( (pr_default.getStatus(9) != 101) && ( ( T000J11_A150BR_VitalID[0] > A150BR_VitalID ) ) )
            {
               pr_default.readNext(9);
            }
            if ( (pr_default.getStatus(9) != 101) && ( ( T000J11_A150BR_VitalID[0] < A150BR_VitalID ) ) )
            {
               A150BR_VitalID = T000J11_A150BR_VitalID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A150BR_VitalID", StringUtil.LTrim( StringUtil.Str( (decimal)(A150BR_VitalID), 18, 0)));
               RcdFound20 = 1;
            }
         }
         pr_default.close(9);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey0J20( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtBR_Vital_MeasureDate_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert0J20( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound20 == 1 )
            {
               if ( A150BR_VitalID != Z150BR_VitalID )
               {
                  A150BR_VitalID = Z150BR_VitalID;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A150BR_VitalID", StringUtil.LTrim( StringUtil.Str( (decimal)(A150BR_VitalID), 18, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "BR_VITALID");
                  AnyError = 1;
                  GX_FocusControl = edtBR_VitalID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtBR_Vital_MeasureDate_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Update record */
                  Update0J20( ) ;
                  GX_FocusControl = edtBR_Vital_MeasureDate_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A150BR_VitalID != Z150BR_VitalID )
               {
                  /* Insert record */
                  GX_FocusControl = edtBR_Vital_MeasureDate_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert0J20( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "BR_VITALID");
                     AnyError = 1;
                     GX_FocusControl = edtBR_VitalID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     /* Insert record */
                     GX_FocusControl = edtBR_Vital_MeasureDate_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert0J20( ) ;
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
         if ( A150BR_VitalID != Z150BR_VitalID )
         {
            A150BR_VitalID = Z150BR_VitalID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A150BR_VitalID", StringUtil.LTrim( StringUtil.Str( (decimal)(A150BR_VitalID), 18, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "BR_VITALID");
            AnyError = 1;
            GX_FocusControl = edtBR_VitalID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtBR_Vital_MeasureDate_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency0J20( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000J2 */
            pr_default.execute(0, new Object[] {A150BR_VitalID});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BR_Vital"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( Z151BR_Vital_VitalID != T000J2_A151BR_Vital_VitalID[0] ) || ( Z152BR_Vital_MeasureDate != T000J2_A152BR_Vital_MeasureDate[0] ) || ( Z153BR_Vital_Temperature != T000J2_A153BR_Vital_Temperature[0] ) || ( Z154BR_Vital_Pulse != T000J2_A154BR_Vital_Pulse[0] ) || ( Z155BR_Vital_Respiration != T000J2_A155BR_Vital_Respiration[0] ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( Z156BR_Vital_Systolic != T000J2_A156BR_Vital_Systolic[0] ) || ( Z157BR_Vital_Diastolic != T000J2_A157BR_Vital_Diastolic[0] ) || ( Z158BR_Vital_Height != T000J2_A158BR_Vital_Height[0] ) || ( Z159BR_Vital_Weight != T000J2_A159BR_Vital_Weight[0] ) || ( Z19BR_EncounterID != T000J2_A19BR_EncounterID[0] ) )
            {
               if ( Z151BR_Vital_VitalID != T000J2_A151BR_Vital_VitalID[0] )
               {
                  GXUtil.WriteLog("br_vital:[seudo value changed for attri]"+"BR_Vital_VitalID");
                  GXUtil.WriteLogRaw("Old: ",Z151BR_Vital_VitalID);
                  GXUtil.WriteLogRaw("Current: ",T000J2_A151BR_Vital_VitalID[0]);
               }
               if ( Z152BR_Vital_MeasureDate != T000J2_A152BR_Vital_MeasureDate[0] )
               {
                  GXUtil.WriteLog("br_vital:[seudo value changed for attri]"+"BR_Vital_MeasureDate");
                  GXUtil.WriteLogRaw("Old: ",Z152BR_Vital_MeasureDate);
                  GXUtil.WriteLogRaw("Current: ",T000J2_A152BR_Vital_MeasureDate[0]);
               }
               if ( Z153BR_Vital_Temperature != T000J2_A153BR_Vital_Temperature[0] )
               {
                  GXUtil.WriteLog("br_vital:[seudo value changed for attri]"+"BR_Vital_Temperature");
                  GXUtil.WriteLogRaw("Old: ",Z153BR_Vital_Temperature);
                  GXUtil.WriteLogRaw("Current: ",T000J2_A153BR_Vital_Temperature[0]);
               }
               if ( Z154BR_Vital_Pulse != T000J2_A154BR_Vital_Pulse[0] )
               {
                  GXUtil.WriteLog("br_vital:[seudo value changed for attri]"+"BR_Vital_Pulse");
                  GXUtil.WriteLogRaw("Old: ",Z154BR_Vital_Pulse);
                  GXUtil.WriteLogRaw("Current: ",T000J2_A154BR_Vital_Pulse[0]);
               }
               if ( Z155BR_Vital_Respiration != T000J2_A155BR_Vital_Respiration[0] )
               {
                  GXUtil.WriteLog("br_vital:[seudo value changed for attri]"+"BR_Vital_Respiration");
                  GXUtil.WriteLogRaw("Old: ",Z155BR_Vital_Respiration);
                  GXUtil.WriteLogRaw("Current: ",T000J2_A155BR_Vital_Respiration[0]);
               }
               if ( Z156BR_Vital_Systolic != T000J2_A156BR_Vital_Systolic[0] )
               {
                  GXUtil.WriteLog("br_vital:[seudo value changed for attri]"+"BR_Vital_Systolic");
                  GXUtil.WriteLogRaw("Old: ",Z156BR_Vital_Systolic);
                  GXUtil.WriteLogRaw("Current: ",T000J2_A156BR_Vital_Systolic[0]);
               }
               if ( Z157BR_Vital_Diastolic != T000J2_A157BR_Vital_Diastolic[0] )
               {
                  GXUtil.WriteLog("br_vital:[seudo value changed for attri]"+"BR_Vital_Diastolic");
                  GXUtil.WriteLogRaw("Old: ",Z157BR_Vital_Diastolic);
                  GXUtil.WriteLogRaw("Current: ",T000J2_A157BR_Vital_Diastolic[0]);
               }
               if ( Z158BR_Vital_Height != T000J2_A158BR_Vital_Height[0] )
               {
                  GXUtil.WriteLog("br_vital:[seudo value changed for attri]"+"BR_Vital_Height");
                  GXUtil.WriteLogRaw("Old: ",Z158BR_Vital_Height);
                  GXUtil.WriteLogRaw("Current: ",T000J2_A158BR_Vital_Height[0]);
               }
               if ( Z159BR_Vital_Weight != T000J2_A159BR_Vital_Weight[0] )
               {
                  GXUtil.WriteLog("br_vital:[seudo value changed for attri]"+"BR_Vital_Weight");
                  GXUtil.WriteLogRaw("Old: ",Z159BR_Vital_Weight);
                  GXUtil.WriteLogRaw("Current: ",T000J2_A159BR_Vital_Weight[0]);
               }
               if ( Z19BR_EncounterID != T000J2_A19BR_EncounterID[0] )
               {
                  GXUtil.WriteLog("br_vital:[seudo value changed for attri]"+"BR_EncounterID");
                  GXUtil.WriteLogRaw("Old: ",Z19BR_EncounterID);
                  GXUtil.WriteLogRaw("Current: ",T000J2_A19BR_EncounterID[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"BR_Vital"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0J20( )
      {
         BeforeValidate0J20( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0J20( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0J20( 0) ;
            CheckOptimisticConcurrency0J20( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0J20( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0J20( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000J12 */
                     pr_default.execute(10, new Object[] {n151BR_Vital_VitalID, A151BR_Vital_VitalID, n152BR_Vital_MeasureDate, A152BR_Vital_MeasureDate, n153BR_Vital_Temperature, A153BR_Vital_Temperature, n154BR_Vital_Pulse, A154BR_Vital_Pulse, n155BR_Vital_Respiration, A155BR_Vital_Respiration, n156BR_Vital_Systolic, A156BR_Vital_Systolic, n157BR_Vital_Diastolic, A157BR_Vital_Diastolic, n158BR_Vital_Height, A158BR_Vital_Height, n159BR_Vital_Weight, A159BR_Vital_Weight, A19BR_EncounterID});
                     A150BR_VitalID = T000J12_A150BR_VitalID[0];
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A150BR_VitalID", StringUtil.LTrim( StringUtil.Str( (decimal)(A150BR_VitalID), 18, 0)));
                     pr_default.close(10);
                     dsDefault.SmartCacheProvider.SetUpdated("BR_Vital") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)),  "就诊信息",  StringUtil.Trim( StringUtil.Str( (decimal)(A150BR_VitalID), 18, 0)),  "生命体征",  "Create",  1) ;
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                           ResetCaption0J0( ) ;
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
               Load0J20( ) ;
            }
            EndLevel0J20( ) ;
         }
         CloseExtendedTableCursors0J20( ) ;
      }

      protected void Update0J20( )
      {
         BeforeValidate0J20( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0J20( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0J20( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0J20( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0J20( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000J13 */
                     pr_default.execute(11, new Object[] {n151BR_Vital_VitalID, A151BR_Vital_VitalID, n152BR_Vital_MeasureDate, A152BR_Vital_MeasureDate, n153BR_Vital_Temperature, A153BR_Vital_Temperature, n154BR_Vital_Pulse, A154BR_Vital_Pulse, n155BR_Vital_Respiration, A155BR_Vital_Respiration, n156BR_Vital_Systolic, A156BR_Vital_Systolic, n157BR_Vital_Diastolic, A157BR_Vital_Diastolic, n158BR_Vital_Height, A158BR_Vital_Height, n159BR_Vital_Weight, A159BR_Vital_Weight, A19BR_EncounterID, A150BR_VitalID});
                     pr_default.close(11);
                     dsDefault.SmartCacheProvider.SetUpdated("BR_Vital") ;
                     if ( (pr_default.getStatus(11) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BR_Vital"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0J20( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)),  "就诊信息",  StringUtil.Trim( StringUtil.Str( (decimal)(A150BR_VitalID), 18, 0)),  "生命体征",  "Update",  1) ;
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
            EndLevel0J20( ) ;
         }
         CloseExtendedTableCursors0J20( ) ;
      }

      protected void DeferredUpdate0J20( )
      {
      }

      protected void delete( )
      {
         BeforeValidate0J20( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0J20( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0J20( ) ;
            AfterConfirm0J20( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0J20( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000J14 */
                  pr_default.execute(12, new Object[] {A150BR_VitalID});
                  pr_default.close(12);
                  dsDefault.SmartCacheProvider.SetUpdated("BR_Vital") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)),  "就诊信息",  StringUtil.Trim( StringUtil.Str( (decimal)(A150BR_VitalID), 18, 0)),  "生命体征",  "Delete",  1) ;
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
         sMode20 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel0J20( ) ;
         Gx_mode = sMode20;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls0J20( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV17Pgmname = "BR_Vital";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17Pgmname", AV17Pgmname);
            AV16Pgmdesc = "Data Mgmt Portal - RAAP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16Pgmdesc", AV16Pgmdesc);
            /* Using cursor T000J15 */
            pr_default.execute(13, new Object[] {A19BR_EncounterID});
            A85BR_Information_ID = T000J15_A85BR_Information_ID[0];
            n85BR_Information_ID = T000J15_n85BR_Information_ID[0];
            pr_default.close(13);
            /* Using cursor T000J16 */
            pr_default.execute(14, new Object[] {n85BR_Information_ID, A85BR_Information_ID});
            A36BR_Information_PatientNo = T000J16_A36BR_Information_PatientNo[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36BR_Information_PatientNo", A36BR_Information_PatientNo);
            n36BR_Information_PatientNo = T000J16_n36BR_Information_PatientNo[0];
            pr_default.close(14);
         }
      }

      protected void EndLevel0J20( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0J20( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(1);
            pr_default.close(13);
            pr_default.close(14);
            context.CommitDataStores("br_vital",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues0J0( ) ;
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
            context.RollbackDataStores("br_vital",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart0J20( )
      {
         /* Scan By routine */
         /* Using cursor T000J17 */
         pr_default.execute(15);
         RcdFound20 = 0;
         if ( (pr_default.getStatus(15) != 101) )
         {
            RcdFound20 = 1;
            A150BR_VitalID = T000J17_A150BR_VitalID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A150BR_VitalID", StringUtil.LTrim( StringUtil.Str( (decimal)(A150BR_VitalID), 18, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0J20( )
      {
         /* Scan next routine */
         pr_default.readNext(15);
         RcdFound20 = 0;
         if ( (pr_default.getStatus(15) != 101) )
         {
            RcdFound20 = 1;
            A150BR_VitalID = T000J17_A150BR_VitalID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A150BR_VitalID", StringUtil.LTrim( StringUtil.Str( (decimal)(A150BR_VitalID), 18, 0)));
         }
      }

      protected void ScanEnd0J20( )
      {
         pr_default.close(15);
      }

      protected void AfterConfirm0J20( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0J20( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0J20( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0J20( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0J20( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0J20( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0J20( )
      {
         edtBR_Vital_MeasureDate_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Vital_MeasureDate_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Vital_MeasureDate_Enabled), 5, 0)), true);
         edtBR_Vital_Temperature_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Vital_Temperature_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Vital_Temperature_Enabled), 5, 0)), true);
         edtBR_Vital_Pulse_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Vital_Pulse_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Vital_Pulse_Enabled), 5, 0)), true);
         edtBR_Vital_Respiration_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Vital_Respiration_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Vital_Respiration_Enabled), 5, 0)), true);
         edtBR_Vital_Systolic_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Vital_Systolic_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Vital_Systolic_Enabled), 5, 0)), true);
         edtBR_Vital_Diastolic_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Vital_Diastolic_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Vital_Diastolic_Enabled), 5, 0)), true);
         edtBR_Vital_Height_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Vital_Height_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Vital_Height_Enabled), 5, 0)), true);
         edtBR_Vital_Weight_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Vital_Weight_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Vital_Weight_Enabled), 5, 0)), true);
         edtBR_VitalID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_VitalID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_VitalID_Enabled), 5, 0)), true);
         edtBR_EncounterID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_EncounterID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_EncounterID_Enabled), 5, 0)), true);
         edtBR_Information_PatientNo_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Information_PatientNo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Information_PatientNo_Enabled), 5, 0)), true);
         edtBR_Vital_VitalID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Vital_VitalID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Vital_VitalID_Enabled), 5, 0)), true);
      }

      protected void send_integrity_lvl_hashes0J20( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues0J0( )
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
         context.AddJavascriptSource("gxcfg.js", "?20202281572238", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_vital.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV12BR_VitalID)+"\">") ;
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
         forbiddenHiddens = "hsh" + "BR_Vital";
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A150BR_VitalID), "ZZZZZZZZZZZZZZZZZZ");
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV10Insert_BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ");
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("br_vital:[SendSecurityCheck value for]"+"BR_VitalID:"+context.localUtil.Format( (decimal)(A150BR_VitalID), "ZZZZZZZZZZZZZZZZZZ"));
         GXUtil.WriteLog("br_vital:[SendSecurityCheck value for]"+"Insert_BR_EncounterID:"+context.localUtil.Format( (decimal)(AV10Insert_BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ"));
         GXUtil.WriteLog("br_vital:[SendSecurityCheck value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z150BR_VitalID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z150BR_VitalID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z151BR_Vital_VitalID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z151BR_Vital_VitalID), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z152BR_Vital_MeasureDate", context.localUtil.DToC( Z152BR_Vital_MeasureDate, 0, "/"));
         GxWebStd.gx_hidden_field( context, "Z153BR_Vital_Temperature", StringUtil.LTrim( StringUtil.NToC( Z153BR_Vital_Temperature, 15, 5, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z154BR_Vital_Pulse", StringUtil.LTrim( StringUtil.NToC( Z154BR_Vital_Pulse, 15, 5, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z155BR_Vital_Respiration", StringUtil.LTrim( StringUtil.NToC( Z155BR_Vital_Respiration, 15, 5, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z156BR_Vital_Systolic", StringUtil.LTrim( StringUtil.NToC( Z156BR_Vital_Systolic, 15, 5, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z157BR_Vital_Diastolic", StringUtil.LTrim( StringUtil.NToC( Z157BR_Vital_Diastolic, 15, 5, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z158BR_Vital_Height", StringUtil.LTrim( StringUtil.NToC( Z158BR_Vital_Height, 15, 5, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z159BR_Vital_Weight", StringUtil.LTrim( StringUtil.NToC( Z159BR_Vital_Weight, 15, 5, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z19BR_EncounterID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z19BR_EncounterID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_Mode", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GxWebStd.gx_hidden_field( context, "N19BR_EncounterID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A19BR_EncounterID), 18, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vTRNCONTEXT", AV8TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vTRNCONTEXT", AV8TrnContext);
         }
         GxWebStd.gx_hidden_field( context, "vBR_VITALID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV12BR_VitalID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vBR_VITALID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV12BR_VitalID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, "vINSERT_BR_ENCOUNTERID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10Insert_BR_EncounterID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "BR_INFORMATION_ID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A85BR_Information_ID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV17Pgmname));
         GxWebStd.gx_hidden_field( context, "vPGMDESC", StringUtil.RTrim( AV16Pgmdesc));
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
         return formatLink("br_vital.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV12BR_VitalID) ;
      }

      public override String GetPgmname( )
      {
         return "BR_Vital" ;
      }

      public override String GetPgmdesc( )
      {
         return "Data Mgmt Portal - RAAP" ;
      }

      protected void InitializeNonKey0J20( )
      {
         A85BR_Information_ID = 0;
         n85BR_Information_ID = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A85BR_Information_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A85BR_Information_ID), 18, 0)));
         A19BR_EncounterID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
         A36BR_Information_PatientNo = "";
         n36BR_Information_PatientNo = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36BR_Information_PatientNo", A36BR_Information_PatientNo);
         A151BR_Vital_VitalID = 0;
         n151BR_Vital_VitalID = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A151BR_Vital_VitalID", StringUtil.LTrim( StringUtil.Str( (decimal)(A151BR_Vital_VitalID), 10, 0)));
         n151BR_Vital_VitalID = ((0==A151BR_Vital_VitalID) ? true : false);
         A152BR_Vital_MeasureDate = DateTime.MinValue;
         n152BR_Vital_MeasureDate = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A152BR_Vital_MeasureDate", context.localUtil.Format(A152BR_Vital_MeasureDate, "9999/99/99"));
         n152BR_Vital_MeasureDate = ((DateTime.MinValue==A152BR_Vital_MeasureDate) ? true : false);
         A153BR_Vital_Temperature = 0;
         n153BR_Vital_Temperature = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A153BR_Vital_Temperature", StringUtil.LTrim( StringUtil.Str( A153BR_Vital_Temperature, 15, 5)));
         n153BR_Vital_Temperature = ((Convert.ToDecimal(0)==A153BR_Vital_Temperature) ? true : false);
         A154BR_Vital_Pulse = 0;
         n154BR_Vital_Pulse = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A154BR_Vital_Pulse", StringUtil.LTrim( StringUtil.Str( A154BR_Vital_Pulse, 15, 5)));
         n154BR_Vital_Pulse = ((Convert.ToDecimal(0)==A154BR_Vital_Pulse) ? true : false);
         A155BR_Vital_Respiration = 0;
         n155BR_Vital_Respiration = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A155BR_Vital_Respiration", StringUtil.LTrim( StringUtil.Str( A155BR_Vital_Respiration, 15, 5)));
         n155BR_Vital_Respiration = ((Convert.ToDecimal(0)==A155BR_Vital_Respiration) ? true : false);
         A156BR_Vital_Systolic = 0;
         n156BR_Vital_Systolic = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A156BR_Vital_Systolic", StringUtil.LTrim( StringUtil.Str( A156BR_Vital_Systolic, 15, 5)));
         n156BR_Vital_Systolic = ((Convert.ToDecimal(0)==A156BR_Vital_Systolic) ? true : false);
         A157BR_Vital_Diastolic = 0;
         n157BR_Vital_Diastolic = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A157BR_Vital_Diastolic", StringUtil.LTrim( StringUtil.Str( A157BR_Vital_Diastolic, 15, 5)));
         n157BR_Vital_Diastolic = ((Convert.ToDecimal(0)==A157BR_Vital_Diastolic) ? true : false);
         A158BR_Vital_Height = 0;
         n158BR_Vital_Height = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A158BR_Vital_Height", StringUtil.LTrim( StringUtil.Str( A158BR_Vital_Height, 15, 5)));
         n158BR_Vital_Height = ((Convert.ToDecimal(0)==A158BR_Vital_Height) ? true : false);
         A159BR_Vital_Weight = 0;
         n159BR_Vital_Weight = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A159BR_Vital_Weight", StringUtil.LTrim( StringUtil.Str( A159BR_Vital_Weight, 15, 5)));
         n159BR_Vital_Weight = ((Convert.ToDecimal(0)==A159BR_Vital_Weight) ? true : false);
         Z151BR_Vital_VitalID = 0;
         Z152BR_Vital_MeasureDate = DateTime.MinValue;
         Z153BR_Vital_Temperature = 0;
         Z154BR_Vital_Pulse = 0;
         Z155BR_Vital_Respiration = 0;
         Z156BR_Vital_Systolic = 0;
         Z157BR_Vital_Diastolic = 0;
         Z158BR_Vital_Height = 0;
         Z159BR_Vital_Weight = 0;
         Z19BR_EncounterID = 0;
      }

      protected void InitAll0J20( )
      {
         A150BR_VitalID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A150BR_VitalID", StringUtil.LTrim( StringUtil.Str( (decimal)(A150BR_VitalID), 18, 0)));
         InitializeNonKey0J20( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20202281572278", true);
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
         context.AddJavascriptSource("br_vital.js", "?20202281572278", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         lblTextblockbr_vital_measuredate_Internalname = "TEXTBLOCKBR_VITAL_MEASUREDATE";
         edtBR_Vital_MeasureDate_Internalname = "BR_VITAL_MEASUREDATE";
         divUnnamedtablebr_vital_measuredate_Internalname = "UNNAMEDTABLEBR_VITAL_MEASUREDATE";
         lblTextblockbr_vital_temperature_Internalname = "TEXTBLOCKBR_VITAL_TEMPERATURE";
         edtBR_Vital_Temperature_Internalname = "BR_VITAL_TEMPERATURE";
         divUnnamedtablebr_vital_temperature_Internalname = "UNNAMEDTABLEBR_VITAL_TEMPERATURE";
         lblTextblockbr_vital_pulse_Internalname = "TEXTBLOCKBR_VITAL_PULSE";
         edtBR_Vital_Pulse_Internalname = "BR_VITAL_PULSE";
         divUnnamedtablebr_vital_pulse_Internalname = "UNNAMEDTABLEBR_VITAL_PULSE";
         lblTextblockbr_vital_respiration_Internalname = "TEXTBLOCKBR_VITAL_RESPIRATION";
         edtBR_Vital_Respiration_Internalname = "BR_VITAL_RESPIRATION";
         divUnnamedtablebr_vital_respiration_Internalname = "UNNAMEDTABLEBR_VITAL_RESPIRATION";
         lblTextblockbr_vital_systolic_Internalname = "TEXTBLOCKBR_VITAL_SYSTOLIC";
         edtBR_Vital_Systolic_Internalname = "BR_VITAL_SYSTOLIC";
         divUnnamedtablebr_vital_systolic_Internalname = "UNNAMEDTABLEBR_VITAL_SYSTOLIC";
         lblTextblockbr_vital_diastolic_Internalname = "TEXTBLOCKBR_VITAL_DIASTOLIC";
         edtBR_Vital_Diastolic_Internalname = "BR_VITAL_DIASTOLIC";
         divUnnamedtablebr_vital_diastolic_Internalname = "UNNAMEDTABLEBR_VITAL_DIASTOLIC";
         lblTextblockbr_vital_height_Internalname = "TEXTBLOCKBR_VITAL_HEIGHT";
         edtBR_Vital_Height_Internalname = "BR_VITAL_HEIGHT";
         divUnnamedtablebr_vital_height_Internalname = "UNNAMEDTABLEBR_VITAL_HEIGHT";
         lblTextblockbr_vital_weight_Internalname = "TEXTBLOCKBR_VITAL_WEIGHT";
         edtBR_Vital_Weight_Internalname = "BR_VITAL_WEIGHT";
         divUnnamedtablebr_vital_weight_Internalname = "UNNAMEDTABLEBR_VITAL_WEIGHT";
         divTableattributes_Internalname = "TABLEATTRIBUTES";
         divLayout_tableattributes_Internalname = "LAYOUT_TABLEATTRIBUTES";
         Dvpanel_tableattributes_Internalname = "DVPANEL_TABLEATTRIBUTES";
         divHtml_dvpanel_tableattributes_Internalname = "HTML_DVPANEL_TABLEATTRIBUTES";
         divTablecontent_Internalname = "TABLECONTENT";
         bttBtntrn_enter_Internalname = "BTNTRN_ENTER";
         bttBtntrn_cancel_Internalname = "BTNTRN_CANCEL";
         divTablemain_Internalname = "TABLEMAIN";
         edtBR_VitalID_Internalname = "BR_VITALID";
         edtBR_EncounterID_Internalname = "BR_ENCOUNTERID";
         edtBR_Information_PatientNo_Internalname = "BR_INFORMATION_PATIENTNO";
         edtBR_Vital_VitalID_Internalname = "BR_VITAL_VITALID";
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
         Form.Caption = "Data Mgmt Portal - RAAP";
         edtBR_Vital_VitalID_Jsonclick = "";
         edtBR_Vital_VitalID_Enabled = 1;
         edtBR_Vital_VitalID_Visible = 1;
         edtBR_Information_PatientNo_Jsonclick = "";
         edtBR_Information_PatientNo_Enabled = 0;
         edtBR_Information_PatientNo_Visible = 1;
         edtBR_EncounterID_Jsonclick = "";
         edtBR_EncounterID_Enabled = 1;
         edtBR_EncounterID_Visible = 1;
         edtBR_VitalID_Jsonclick = "";
         edtBR_VitalID_Enabled = 0;
         edtBR_VitalID_Visible = 1;
         bttBtntrn_cancel_Visible = 1;
         bttBtntrn_enter_Enabled = 1;
         bttBtntrn_enter_Visible = 1;
         edtBR_Vital_Weight_Jsonclick = "";
         edtBR_Vital_Weight_Enabled = 1;
         edtBR_Vital_Height_Jsonclick = "";
         edtBR_Vital_Height_Enabled = 1;
         edtBR_Vital_Diastolic_Jsonclick = "";
         edtBR_Vital_Diastolic_Enabled = 1;
         edtBR_Vital_Systolic_Jsonclick = "";
         edtBR_Vital_Systolic_Enabled = 1;
         edtBR_Vital_Respiration_Jsonclick = "";
         edtBR_Vital_Respiration_Enabled = 1;
         edtBR_Vital_Pulse_Jsonclick = "";
         edtBR_Vital_Pulse_Enabled = 1;
         edtBR_Vital_Temperature_Jsonclick = "";
         edtBR_Vital_Temperature_Enabled = 1;
         edtBR_Vital_MeasureDate_Jsonclick = "";
         edtBR_Vital_MeasureDate_Enabled = 1;
         Dvpanel_tableattributes_Autoscroll = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Iconposition = "left";
         Dvpanel_tableattributes_Showcollapseicon = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsed = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsible = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Title = "生命体征";
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

      protected void XC_10_0J20( )
      {
         new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)),  "就诊信息",  StringUtil.Trim( StringUtil.Str( (decimal)(A150BR_VitalID), 18, 0)),  "生命体征",  "Create",  1) ;
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

      protected void XC_11_0J20( )
      {
         new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)),  "就诊信息",  StringUtil.Trim( StringUtil.Str( (decimal)(A150BR_VitalID), 18, 0)),  "生命体征",  "Update",  1) ;
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

      protected void XC_12_0J20( )
      {
         new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)),  "就诊信息",  StringUtil.Trim( StringUtil.Str( (decimal)(A150BR_VitalID), 18, 0)),  "生命体征",  "Delete",  1) ;
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

      public void Valid_Br_encounterid( long GX_Parm1 ,
                                        long GX_Parm2 ,
                                        String GX_Parm3 )
      {
         A19BR_EncounterID = GX_Parm1;
         A85BR_Information_ID = GX_Parm2;
         n85BR_Information_ID = false;
         A36BR_Information_PatientNo = GX_Parm3;
         n36BR_Information_PatientNo = false;
         /* Using cursor T000J15 */
         pr_default.execute(13, new Object[] {A19BR_EncounterID});
         if ( (pr_default.getStatus(13) == 101) )
         {
            GX_msglist.addItem("不匹配' T15'", "ForeignKeyNotFound", 1, "BR_ENCOUNTERID");
            AnyError = 1;
            GX_FocusControl = edtBR_EncounterID_Internalname;
         }
         A85BR_Information_ID = T000J15_A85BR_Information_ID[0];
         n85BR_Information_ID = T000J15_n85BR_Information_ID[0];
         pr_default.close(13);
         /* Using cursor T000J16 */
         pr_default.execute(14, new Object[] {n85BR_Information_ID, A85BR_Information_ID});
         if ( (pr_default.getStatus(14) == 101) )
         {
            if ( ! ( (0==A85BR_Information_ID) ) )
            {
               GX_msglist.addItem("不匹配' T16'", "ForeignKeyNotFound", 1, "");
               AnyError = 1;
            }
         }
         A36BR_Information_PatientNo = T000J16_A36BR_Information_PatientNo[0];
         n36BR_Information_PatientNo = T000J16_n36BR_Information_PatientNo[0];
         pr_default.close(14);
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
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV12BR_VitalID',fld:'vBR_VITALID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV12BR_VitalID',fld:'vBR_VITALID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'A150BR_VitalID',fld:'BR_VITALID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV10Insert_BR_EncounterID',fld:'vINSERT_BR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("AFTER TRN","{handler:'E120J2',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV8TrnContext',fld:'vTRNCONTEXT',pic:''}]");
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
         pr_default.close(13);
         pr_default.close(14);
      }

      public override void initialize( )
      {
         sPrefix = "";
         wcpOGx_mode = "";
         Z152BR_Vital_MeasureDate = DateTime.MinValue;
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
         lblTextblockbr_vital_measuredate_Jsonclick = "";
         TempTags = "";
         A152BR_Vital_MeasureDate = DateTime.MinValue;
         lblTextblockbr_vital_temperature_Jsonclick = "";
         lblTextblockbr_vital_pulse_Jsonclick = "";
         lblTextblockbr_vital_respiration_Jsonclick = "";
         lblTextblockbr_vital_systolic_Jsonclick = "";
         lblTextblockbr_vital_diastolic_Jsonclick = "";
         lblTextblockbr_vital_height_Jsonclick = "";
         lblTextblockbr_vital_weight_Jsonclick = "";
         bttBtntrn_enter_Jsonclick = "";
         bttBtntrn_cancel_Jsonclick = "";
         A36BR_Information_PatientNo = "";
         AV17Pgmname = "";
         AV16Pgmdesc = "";
         Dvpanel_tableattributes_Objectcall = "";
         Dvpanel_tableattributes_Class = "";
         Dvpanel_tableattributes_Height = "";
         forbiddenHiddens = "";
         hsh = "";
         sMode20 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV7WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV8TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV9WebSession = context.GetSession();
         AV11TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         Z36BR_Information_PatientNo = "";
         T000J4_A85BR_Information_ID = new long[1] ;
         T000J4_n85BR_Information_ID = new bool[] {false} ;
         T000J5_A36BR_Information_PatientNo = new String[] {""} ;
         T000J5_n36BR_Information_PatientNo = new bool[] {false} ;
         T000J6_A85BR_Information_ID = new long[1] ;
         T000J6_n85BR_Information_ID = new bool[] {false} ;
         T000J6_A150BR_VitalID = new long[1] ;
         T000J6_A36BR_Information_PatientNo = new String[] {""} ;
         T000J6_n36BR_Information_PatientNo = new bool[] {false} ;
         T000J6_A151BR_Vital_VitalID = new long[1] ;
         T000J6_n151BR_Vital_VitalID = new bool[] {false} ;
         T000J6_A152BR_Vital_MeasureDate = new DateTime[] {DateTime.MinValue} ;
         T000J6_n152BR_Vital_MeasureDate = new bool[] {false} ;
         T000J6_A153BR_Vital_Temperature = new decimal[1] ;
         T000J6_n153BR_Vital_Temperature = new bool[] {false} ;
         T000J6_A154BR_Vital_Pulse = new decimal[1] ;
         T000J6_n154BR_Vital_Pulse = new bool[] {false} ;
         T000J6_A155BR_Vital_Respiration = new decimal[1] ;
         T000J6_n155BR_Vital_Respiration = new bool[] {false} ;
         T000J6_A156BR_Vital_Systolic = new decimal[1] ;
         T000J6_n156BR_Vital_Systolic = new bool[] {false} ;
         T000J6_A157BR_Vital_Diastolic = new decimal[1] ;
         T000J6_n157BR_Vital_Diastolic = new bool[] {false} ;
         T000J6_A158BR_Vital_Height = new decimal[1] ;
         T000J6_n158BR_Vital_Height = new bool[] {false} ;
         T000J6_A159BR_Vital_Weight = new decimal[1] ;
         T000J6_n159BR_Vital_Weight = new bool[] {false} ;
         T000J6_A19BR_EncounterID = new long[1] ;
         T000J7_A85BR_Information_ID = new long[1] ;
         T000J7_n85BR_Information_ID = new bool[] {false} ;
         T000J8_A36BR_Information_PatientNo = new String[] {""} ;
         T000J8_n36BR_Information_PatientNo = new bool[] {false} ;
         T000J9_A150BR_VitalID = new long[1] ;
         T000J3_A150BR_VitalID = new long[1] ;
         T000J3_A151BR_Vital_VitalID = new long[1] ;
         T000J3_n151BR_Vital_VitalID = new bool[] {false} ;
         T000J3_A152BR_Vital_MeasureDate = new DateTime[] {DateTime.MinValue} ;
         T000J3_n152BR_Vital_MeasureDate = new bool[] {false} ;
         T000J3_A153BR_Vital_Temperature = new decimal[1] ;
         T000J3_n153BR_Vital_Temperature = new bool[] {false} ;
         T000J3_A154BR_Vital_Pulse = new decimal[1] ;
         T000J3_n154BR_Vital_Pulse = new bool[] {false} ;
         T000J3_A155BR_Vital_Respiration = new decimal[1] ;
         T000J3_n155BR_Vital_Respiration = new bool[] {false} ;
         T000J3_A156BR_Vital_Systolic = new decimal[1] ;
         T000J3_n156BR_Vital_Systolic = new bool[] {false} ;
         T000J3_A157BR_Vital_Diastolic = new decimal[1] ;
         T000J3_n157BR_Vital_Diastolic = new bool[] {false} ;
         T000J3_A158BR_Vital_Height = new decimal[1] ;
         T000J3_n158BR_Vital_Height = new bool[] {false} ;
         T000J3_A159BR_Vital_Weight = new decimal[1] ;
         T000J3_n159BR_Vital_Weight = new bool[] {false} ;
         T000J3_A19BR_EncounterID = new long[1] ;
         T000J10_A150BR_VitalID = new long[1] ;
         T000J11_A150BR_VitalID = new long[1] ;
         T000J2_A150BR_VitalID = new long[1] ;
         T000J2_A151BR_Vital_VitalID = new long[1] ;
         T000J2_n151BR_Vital_VitalID = new bool[] {false} ;
         T000J2_A152BR_Vital_MeasureDate = new DateTime[] {DateTime.MinValue} ;
         T000J2_n152BR_Vital_MeasureDate = new bool[] {false} ;
         T000J2_A153BR_Vital_Temperature = new decimal[1] ;
         T000J2_n153BR_Vital_Temperature = new bool[] {false} ;
         T000J2_A154BR_Vital_Pulse = new decimal[1] ;
         T000J2_n154BR_Vital_Pulse = new bool[] {false} ;
         T000J2_A155BR_Vital_Respiration = new decimal[1] ;
         T000J2_n155BR_Vital_Respiration = new bool[] {false} ;
         T000J2_A156BR_Vital_Systolic = new decimal[1] ;
         T000J2_n156BR_Vital_Systolic = new bool[] {false} ;
         T000J2_A157BR_Vital_Diastolic = new decimal[1] ;
         T000J2_n157BR_Vital_Diastolic = new bool[] {false} ;
         T000J2_A158BR_Vital_Height = new decimal[1] ;
         T000J2_n158BR_Vital_Height = new bool[] {false} ;
         T000J2_A159BR_Vital_Weight = new decimal[1] ;
         T000J2_n159BR_Vital_Weight = new bool[] {false} ;
         T000J2_A19BR_EncounterID = new long[1] ;
         T000J12_A150BR_VitalID = new long[1] ;
         T000J15_A85BR_Information_ID = new long[1] ;
         T000J15_n85BR_Information_ID = new bool[] {false} ;
         T000J16_A36BR_Information_PatientNo = new String[] {""} ;
         T000J16_n36BR_Information_PatientNo = new bool[] {false} ;
         T000J17_A150BR_VitalID = new long[1] ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         isValidOutput = new GxUnknownObjectCollection();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.br_vital__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_vital__default(),
            new Object[][] {
                new Object[] {
               T000J2_A150BR_VitalID, T000J2_A151BR_Vital_VitalID, T000J2_n151BR_Vital_VitalID, T000J2_A152BR_Vital_MeasureDate, T000J2_n152BR_Vital_MeasureDate, T000J2_A153BR_Vital_Temperature, T000J2_n153BR_Vital_Temperature, T000J2_A154BR_Vital_Pulse, T000J2_n154BR_Vital_Pulse, T000J2_A155BR_Vital_Respiration,
               T000J2_n155BR_Vital_Respiration, T000J2_A156BR_Vital_Systolic, T000J2_n156BR_Vital_Systolic, T000J2_A157BR_Vital_Diastolic, T000J2_n157BR_Vital_Diastolic, T000J2_A158BR_Vital_Height, T000J2_n158BR_Vital_Height, T000J2_A159BR_Vital_Weight, T000J2_n159BR_Vital_Weight, T000J2_A19BR_EncounterID
               }
               , new Object[] {
               T000J3_A150BR_VitalID, T000J3_A151BR_Vital_VitalID, T000J3_n151BR_Vital_VitalID, T000J3_A152BR_Vital_MeasureDate, T000J3_n152BR_Vital_MeasureDate, T000J3_A153BR_Vital_Temperature, T000J3_n153BR_Vital_Temperature, T000J3_A154BR_Vital_Pulse, T000J3_n154BR_Vital_Pulse, T000J3_A155BR_Vital_Respiration,
               T000J3_n155BR_Vital_Respiration, T000J3_A156BR_Vital_Systolic, T000J3_n156BR_Vital_Systolic, T000J3_A157BR_Vital_Diastolic, T000J3_n157BR_Vital_Diastolic, T000J3_A158BR_Vital_Height, T000J3_n158BR_Vital_Height, T000J3_A159BR_Vital_Weight, T000J3_n159BR_Vital_Weight, T000J3_A19BR_EncounterID
               }
               , new Object[] {
               T000J4_A85BR_Information_ID, T000J4_n85BR_Information_ID
               }
               , new Object[] {
               T000J5_A36BR_Information_PatientNo, T000J5_n36BR_Information_PatientNo
               }
               , new Object[] {
               T000J6_A85BR_Information_ID, T000J6_n85BR_Information_ID, T000J6_A150BR_VitalID, T000J6_A36BR_Information_PatientNo, T000J6_n36BR_Information_PatientNo, T000J6_A151BR_Vital_VitalID, T000J6_n151BR_Vital_VitalID, T000J6_A152BR_Vital_MeasureDate, T000J6_n152BR_Vital_MeasureDate, T000J6_A153BR_Vital_Temperature,
               T000J6_n153BR_Vital_Temperature, T000J6_A154BR_Vital_Pulse, T000J6_n154BR_Vital_Pulse, T000J6_A155BR_Vital_Respiration, T000J6_n155BR_Vital_Respiration, T000J6_A156BR_Vital_Systolic, T000J6_n156BR_Vital_Systolic, T000J6_A157BR_Vital_Diastolic, T000J6_n157BR_Vital_Diastolic, T000J6_A158BR_Vital_Height,
               T000J6_n158BR_Vital_Height, T000J6_A159BR_Vital_Weight, T000J6_n159BR_Vital_Weight, T000J6_A19BR_EncounterID
               }
               , new Object[] {
               T000J7_A85BR_Information_ID, T000J7_n85BR_Information_ID
               }
               , new Object[] {
               T000J8_A36BR_Information_PatientNo, T000J8_n36BR_Information_PatientNo
               }
               , new Object[] {
               T000J9_A150BR_VitalID
               }
               , new Object[] {
               T000J10_A150BR_VitalID
               }
               , new Object[] {
               T000J11_A150BR_VitalID
               }
               , new Object[] {
               T000J12_A150BR_VitalID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000J15_A85BR_Information_ID, T000J15_n85BR_Information_ID
               }
               , new Object[] {
               T000J16_A36BR_Information_PatientNo, T000J16_n36BR_Information_PatientNo
               }
               , new Object[] {
               T000J17_A150BR_VitalID
               }
            }
         );
         AV17Pgmname = "BR_Vital";
         AV16Pgmdesc = "Data Mgmt Portal - RAAP";
      }

      private short GxWebError ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short RcdFound20 ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int trnEnded ;
      private int edtBR_Vital_MeasureDate_Enabled ;
      private int edtBR_Vital_Temperature_Enabled ;
      private int edtBR_Vital_Pulse_Enabled ;
      private int edtBR_Vital_Respiration_Enabled ;
      private int edtBR_Vital_Systolic_Enabled ;
      private int edtBR_Vital_Diastolic_Enabled ;
      private int edtBR_Vital_Height_Enabled ;
      private int edtBR_Vital_Weight_Enabled ;
      private int bttBtntrn_enter_Visible ;
      private int bttBtntrn_enter_Enabled ;
      private int bttBtntrn_cancel_Visible ;
      private int edtBR_VitalID_Enabled ;
      private int edtBR_VitalID_Visible ;
      private int edtBR_EncounterID_Visible ;
      private int edtBR_EncounterID_Enabled ;
      private int edtBR_Information_PatientNo_Visible ;
      private int edtBR_Information_PatientNo_Enabled ;
      private int edtBR_Vital_VitalID_Enabled ;
      private int edtBR_Vital_VitalID_Visible ;
      private int AV18GXV1 ;
      private int idxLst ;
      private long wcpOAV12BR_VitalID ;
      private long Z150BR_VitalID ;
      private long Z151BR_Vital_VitalID ;
      private long Z19BR_EncounterID ;
      private long N19BR_EncounterID ;
      private long A19BR_EncounterID ;
      private long A85BR_Information_ID ;
      private long AV12BR_VitalID ;
      private long A150BR_VitalID ;
      private long A151BR_Vital_VitalID ;
      private long AV10Insert_BR_EncounterID ;
      private long Z85BR_Information_ID ;
      private decimal Z153BR_Vital_Temperature ;
      private decimal Z154BR_Vital_Pulse ;
      private decimal Z155BR_Vital_Respiration ;
      private decimal Z156BR_Vital_Systolic ;
      private decimal Z157BR_Vital_Diastolic ;
      private decimal Z158BR_Vital_Height ;
      private decimal Z159BR_Vital_Weight ;
      private decimal A153BR_Vital_Temperature ;
      private decimal A154BR_Vital_Pulse ;
      private decimal A155BR_Vital_Respiration ;
      private decimal A156BR_Vital_Systolic ;
      private decimal A157BR_Vital_Diastolic ;
      private decimal A158BR_Vital_Height ;
      private decimal A159BR_Vital_Weight ;
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
      private String edtBR_Vital_MeasureDate_Internalname ;
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
      private String divUnnamedtablebr_vital_measuredate_Internalname ;
      private String lblTextblockbr_vital_measuredate_Internalname ;
      private String lblTextblockbr_vital_measuredate_Jsonclick ;
      private String TempTags ;
      private String edtBR_Vital_MeasureDate_Jsonclick ;
      private String divUnnamedtablebr_vital_temperature_Internalname ;
      private String lblTextblockbr_vital_temperature_Internalname ;
      private String lblTextblockbr_vital_temperature_Jsonclick ;
      private String edtBR_Vital_Temperature_Internalname ;
      private String edtBR_Vital_Temperature_Jsonclick ;
      private String divUnnamedtablebr_vital_pulse_Internalname ;
      private String lblTextblockbr_vital_pulse_Internalname ;
      private String lblTextblockbr_vital_pulse_Jsonclick ;
      private String edtBR_Vital_Pulse_Internalname ;
      private String edtBR_Vital_Pulse_Jsonclick ;
      private String divUnnamedtablebr_vital_respiration_Internalname ;
      private String lblTextblockbr_vital_respiration_Internalname ;
      private String lblTextblockbr_vital_respiration_Jsonclick ;
      private String edtBR_Vital_Respiration_Internalname ;
      private String edtBR_Vital_Respiration_Jsonclick ;
      private String divUnnamedtablebr_vital_systolic_Internalname ;
      private String lblTextblockbr_vital_systolic_Internalname ;
      private String lblTextblockbr_vital_systolic_Jsonclick ;
      private String edtBR_Vital_Systolic_Internalname ;
      private String edtBR_Vital_Systolic_Jsonclick ;
      private String divUnnamedtablebr_vital_diastolic_Internalname ;
      private String lblTextblockbr_vital_diastolic_Internalname ;
      private String lblTextblockbr_vital_diastolic_Jsonclick ;
      private String edtBR_Vital_Diastolic_Internalname ;
      private String edtBR_Vital_Diastolic_Jsonclick ;
      private String divUnnamedtablebr_vital_height_Internalname ;
      private String lblTextblockbr_vital_height_Internalname ;
      private String lblTextblockbr_vital_height_Jsonclick ;
      private String edtBR_Vital_Height_Internalname ;
      private String edtBR_Vital_Height_Jsonclick ;
      private String divUnnamedtablebr_vital_weight_Internalname ;
      private String lblTextblockbr_vital_weight_Internalname ;
      private String lblTextblockbr_vital_weight_Jsonclick ;
      private String edtBR_Vital_Weight_Internalname ;
      private String edtBR_Vital_Weight_Jsonclick ;
      private String bttBtntrn_enter_Internalname ;
      private String bttBtntrn_enter_Jsonclick ;
      private String bttBtntrn_cancel_Internalname ;
      private String bttBtntrn_cancel_Jsonclick ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String edtBR_VitalID_Internalname ;
      private String edtBR_VitalID_Jsonclick ;
      private String edtBR_EncounterID_Internalname ;
      private String edtBR_EncounterID_Jsonclick ;
      private String edtBR_Information_PatientNo_Internalname ;
      private String edtBR_Information_PatientNo_Jsonclick ;
      private String edtBR_Vital_VitalID_Internalname ;
      private String edtBR_Vital_VitalID_Jsonclick ;
      private String AV17Pgmname ;
      private String AV16Pgmdesc ;
      private String Dvpanel_tableattributes_Objectcall ;
      private String Dvpanel_tableattributes_Class ;
      private String Dvpanel_tableattributes_Height ;
      private String forbiddenHiddens ;
      private String hsh ;
      private String sMode20 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private DateTime Z152BR_Vital_MeasureDate ;
      private DateTime A152BR_Vital_MeasureDate ;
      private bool entryPointCalled ;
      private bool n85BR_Information_ID ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool Dvpanel_tableattributes_Autowidth ;
      private bool Dvpanel_tableattributes_Autoheight ;
      private bool Dvpanel_tableattributes_Collapsible ;
      private bool Dvpanel_tableattributes_Collapsed ;
      private bool Dvpanel_tableattributes_Showcollapseicon ;
      private bool Dvpanel_tableattributes_Autoscroll ;
      private bool n152BR_Vital_MeasureDate ;
      private bool n153BR_Vital_Temperature ;
      private bool n154BR_Vital_Pulse ;
      private bool n155BR_Vital_Respiration ;
      private bool n156BR_Vital_Systolic ;
      private bool n157BR_Vital_Diastolic ;
      private bool n158BR_Vital_Height ;
      private bool n159BR_Vital_Weight ;
      private bool n36BR_Information_PatientNo ;
      private bool n151BR_Vital_VitalID ;
      private bool Dvpanel_tableattributes_Enabled ;
      private bool Dvpanel_tableattributes_Showheader ;
      private bool Dvpanel_tableattributes_Visible ;
      private bool AV13IsAuthorized ;
      private bool GXt_boolean1 ;
      private bool returnInSub ;
      private bool Gx_longc ;
      private String A36BR_Information_PatientNo ;
      private String Z36BR_Information_PatientNo ;
      private IGxSession AV9WebSession ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXUserControl ucDvpanel_tableattributes ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] T000J4_A85BR_Information_ID ;
      private bool[] T000J4_n85BR_Information_ID ;
      private String[] T000J5_A36BR_Information_PatientNo ;
      private bool[] T000J5_n36BR_Information_PatientNo ;
      private long[] T000J6_A85BR_Information_ID ;
      private bool[] T000J6_n85BR_Information_ID ;
      private long[] T000J6_A150BR_VitalID ;
      private String[] T000J6_A36BR_Information_PatientNo ;
      private bool[] T000J6_n36BR_Information_PatientNo ;
      private long[] T000J6_A151BR_Vital_VitalID ;
      private bool[] T000J6_n151BR_Vital_VitalID ;
      private DateTime[] T000J6_A152BR_Vital_MeasureDate ;
      private bool[] T000J6_n152BR_Vital_MeasureDate ;
      private decimal[] T000J6_A153BR_Vital_Temperature ;
      private bool[] T000J6_n153BR_Vital_Temperature ;
      private decimal[] T000J6_A154BR_Vital_Pulse ;
      private bool[] T000J6_n154BR_Vital_Pulse ;
      private decimal[] T000J6_A155BR_Vital_Respiration ;
      private bool[] T000J6_n155BR_Vital_Respiration ;
      private decimal[] T000J6_A156BR_Vital_Systolic ;
      private bool[] T000J6_n156BR_Vital_Systolic ;
      private decimal[] T000J6_A157BR_Vital_Diastolic ;
      private bool[] T000J6_n157BR_Vital_Diastolic ;
      private decimal[] T000J6_A158BR_Vital_Height ;
      private bool[] T000J6_n158BR_Vital_Height ;
      private decimal[] T000J6_A159BR_Vital_Weight ;
      private bool[] T000J6_n159BR_Vital_Weight ;
      private long[] T000J6_A19BR_EncounterID ;
      private long[] T000J7_A85BR_Information_ID ;
      private bool[] T000J7_n85BR_Information_ID ;
      private String[] T000J8_A36BR_Information_PatientNo ;
      private bool[] T000J8_n36BR_Information_PatientNo ;
      private long[] T000J9_A150BR_VitalID ;
      private long[] T000J3_A150BR_VitalID ;
      private long[] T000J3_A151BR_Vital_VitalID ;
      private bool[] T000J3_n151BR_Vital_VitalID ;
      private DateTime[] T000J3_A152BR_Vital_MeasureDate ;
      private bool[] T000J3_n152BR_Vital_MeasureDate ;
      private decimal[] T000J3_A153BR_Vital_Temperature ;
      private bool[] T000J3_n153BR_Vital_Temperature ;
      private decimal[] T000J3_A154BR_Vital_Pulse ;
      private bool[] T000J3_n154BR_Vital_Pulse ;
      private decimal[] T000J3_A155BR_Vital_Respiration ;
      private bool[] T000J3_n155BR_Vital_Respiration ;
      private decimal[] T000J3_A156BR_Vital_Systolic ;
      private bool[] T000J3_n156BR_Vital_Systolic ;
      private decimal[] T000J3_A157BR_Vital_Diastolic ;
      private bool[] T000J3_n157BR_Vital_Diastolic ;
      private decimal[] T000J3_A158BR_Vital_Height ;
      private bool[] T000J3_n158BR_Vital_Height ;
      private decimal[] T000J3_A159BR_Vital_Weight ;
      private bool[] T000J3_n159BR_Vital_Weight ;
      private long[] T000J3_A19BR_EncounterID ;
      private long[] T000J10_A150BR_VitalID ;
      private long[] T000J11_A150BR_VitalID ;
      private long[] T000J2_A150BR_VitalID ;
      private long[] T000J2_A151BR_Vital_VitalID ;
      private bool[] T000J2_n151BR_Vital_VitalID ;
      private DateTime[] T000J2_A152BR_Vital_MeasureDate ;
      private bool[] T000J2_n152BR_Vital_MeasureDate ;
      private decimal[] T000J2_A153BR_Vital_Temperature ;
      private bool[] T000J2_n153BR_Vital_Temperature ;
      private decimal[] T000J2_A154BR_Vital_Pulse ;
      private bool[] T000J2_n154BR_Vital_Pulse ;
      private decimal[] T000J2_A155BR_Vital_Respiration ;
      private bool[] T000J2_n155BR_Vital_Respiration ;
      private decimal[] T000J2_A156BR_Vital_Systolic ;
      private bool[] T000J2_n156BR_Vital_Systolic ;
      private decimal[] T000J2_A157BR_Vital_Diastolic ;
      private bool[] T000J2_n157BR_Vital_Diastolic ;
      private decimal[] T000J2_A158BR_Vital_Height ;
      private bool[] T000J2_n158BR_Vital_Height ;
      private decimal[] T000J2_A159BR_Vital_Weight ;
      private bool[] T000J2_n159BR_Vital_Weight ;
      private long[] T000J2_A19BR_EncounterID ;
      private long[] T000J12_A150BR_VitalID ;
      private long[] T000J15_A85BR_Information_ID ;
      private bool[] T000J15_n85BR_Information_ID ;
      private String[] T000J16_A36BR_Information_PatientNo ;
      private bool[] T000J16_n36BR_Information_PatientNo ;
      private long[] T000J17_A150BR_VitalID ;
      private IDataStoreProvider pr_datastore1 ;
      private GXWebForm Form ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV7WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV8TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute AV11TrnContextAtt ;
   }

   public class br_vital__datastore1 : DataStoreHelperBase, IDataStoreHelper
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

 public class br_vital__default : DataStoreHelperBase, IDataStoreHelper
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
     };
  }

  private static CursorDef[] def;
  private void cursorDefinitions( )
  {
     if ( def == null )
     {
        Object[] prmT000J6 ;
        prmT000J6 = new Object[] {
        new Object[] {"@BR_VitalID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000J4 ;
        prmT000J4 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000J5 ;
        prmT000J5 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000J7 ;
        prmT000J7 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000J8 ;
        prmT000J8 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000J9 ;
        prmT000J9 = new Object[] {
        new Object[] {"@BR_VitalID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000J3 ;
        prmT000J3 = new Object[] {
        new Object[] {"@BR_VitalID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000J10 ;
        prmT000J10 = new Object[] {
        new Object[] {"@BR_VitalID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000J11 ;
        prmT000J11 = new Object[] {
        new Object[] {"@BR_VitalID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000J2 ;
        prmT000J2 = new Object[] {
        new Object[] {"@BR_VitalID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000J12 ;
        prmT000J12 = new Object[] {
        new Object[] {"@BR_Vital_VitalID",SqlDbType.Decimal,10,0} ,
        new Object[] {"@BR_Vital_MeasureDate",SqlDbType.DateTime,8,0} ,
        new Object[] {"@BR_Vital_Temperature",SqlDbType.Decimal,15,5} ,
        new Object[] {"@BR_Vital_Pulse",SqlDbType.Decimal,15,5} ,
        new Object[] {"@BR_Vital_Respiration",SqlDbType.Decimal,15,5} ,
        new Object[] {"@BR_Vital_Systolic",SqlDbType.Decimal,15,5} ,
        new Object[] {"@BR_Vital_Diastolic",SqlDbType.Decimal,15,5} ,
        new Object[] {"@BR_Vital_Height",SqlDbType.Decimal,15,5} ,
        new Object[] {"@BR_Vital_Weight",SqlDbType.Decimal,15,5} ,
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000J13 ;
        prmT000J13 = new Object[] {
        new Object[] {"@BR_Vital_VitalID",SqlDbType.Decimal,10,0} ,
        new Object[] {"@BR_Vital_MeasureDate",SqlDbType.DateTime,8,0} ,
        new Object[] {"@BR_Vital_Temperature",SqlDbType.Decimal,15,5} ,
        new Object[] {"@BR_Vital_Pulse",SqlDbType.Decimal,15,5} ,
        new Object[] {"@BR_Vital_Respiration",SqlDbType.Decimal,15,5} ,
        new Object[] {"@BR_Vital_Systolic",SqlDbType.Decimal,15,5} ,
        new Object[] {"@BR_Vital_Diastolic",SqlDbType.Decimal,15,5} ,
        new Object[] {"@BR_Vital_Height",SqlDbType.Decimal,15,5} ,
        new Object[] {"@BR_Vital_Weight",SqlDbType.Decimal,15,5} ,
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@BR_VitalID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000J14 ;
        prmT000J14 = new Object[] {
        new Object[] {"@BR_VitalID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000J17 ;
        prmT000J17 = new Object[] {
        } ;
        Object[] prmT000J15 ;
        prmT000J15 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000J16 ;
        prmT000J16 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("T000J2", "SELECT [BR_VitalID], [BR_Vital_VitalID], [BR_Vital_MeasureDate], [BR_Vital_Temperature], [BR_Vital_Pulse], [BR_Vital_Respiration], [BR_Vital_Systolic], [BR_Vital_Diastolic], [BR_Vital_Height], [BR_Vital_Weight], [BR_EncounterID] FROM [BR_Vital] WITH (UPDLOCK) WHERE [BR_VitalID] = @BR_VitalID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000J2,1,0,true,false )
           ,new CursorDef("T000J3", "SELECT [BR_VitalID], [BR_Vital_VitalID], [BR_Vital_MeasureDate], [BR_Vital_Temperature], [BR_Vital_Pulse], [BR_Vital_Respiration], [BR_Vital_Systolic], [BR_Vital_Diastolic], [BR_Vital_Height], [BR_Vital_Weight], [BR_EncounterID] FROM [BR_Vital] WITH (NOLOCK) WHERE [BR_VitalID] = @BR_VitalID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000J3,1,0,true,false )
           ,new CursorDef("T000J4", "SELECT [BR_Information_ID] FROM [BR_Encounter] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000J4,1,0,true,false )
           ,new CursorDef("T000J5", "SELECT [BR_Information_PatientNo] FROM [BR_Information] WITH (NOLOCK) WHERE [BR_Information_ID] = @BR_Information_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000J5,1,0,true,false )
           ,new CursorDef("T000J6", "SELECT T2.[BR_Information_ID], TM1.[BR_VitalID], T3.[BR_Information_PatientNo], TM1.[BR_Vital_VitalID], TM1.[BR_Vital_MeasureDate], TM1.[BR_Vital_Temperature], TM1.[BR_Vital_Pulse], TM1.[BR_Vital_Respiration], TM1.[BR_Vital_Systolic], TM1.[BR_Vital_Diastolic], TM1.[BR_Vital_Height], TM1.[BR_Vital_Weight], TM1.[BR_EncounterID] FROM (([BR_Vital] TM1 WITH (NOLOCK) INNER JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = TM1.[BR_EncounterID]) LEFT JOIN [BR_Information] T3 WITH (NOLOCK) ON T3.[BR_Information_ID] = T2.[BR_Information_ID]) WHERE TM1.[BR_VitalID] = @BR_VitalID ORDER BY TM1.[BR_VitalID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000J6,100,0,true,false )
           ,new CursorDef("T000J7", "SELECT [BR_Information_ID] FROM [BR_Encounter] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000J7,1,0,true,false )
           ,new CursorDef("T000J8", "SELECT [BR_Information_PatientNo] FROM [BR_Information] WITH (NOLOCK) WHERE [BR_Information_ID] = @BR_Information_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000J8,1,0,true,false )
           ,new CursorDef("T000J9", "SELECT [BR_VitalID] FROM [BR_Vital] WITH (NOLOCK) WHERE [BR_VitalID] = @BR_VitalID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000J9,1,0,true,false )
           ,new CursorDef("T000J10", "SELECT TOP 1 [BR_VitalID] FROM [BR_Vital] WITH (NOLOCK) WHERE ( [BR_VitalID] > @BR_VitalID) ORDER BY [BR_VitalID]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000J10,1,0,true,true )
           ,new CursorDef("T000J11", "SELECT TOP 1 [BR_VitalID] FROM [BR_Vital] WITH (NOLOCK) WHERE ( [BR_VitalID] < @BR_VitalID) ORDER BY [BR_VitalID] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000J11,1,0,true,true )
           ,new CursorDef("T000J12", "INSERT INTO [BR_Vital]([BR_Vital_VitalID], [BR_Vital_MeasureDate], [BR_Vital_Temperature], [BR_Vital_Pulse], [BR_Vital_Respiration], [BR_Vital_Systolic], [BR_Vital_Diastolic], [BR_Vital_Height], [BR_Vital_Weight], [BR_EncounterID]) VALUES(@BR_Vital_VitalID, @BR_Vital_MeasureDate, @BR_Vital_Temperature, @BR_Vital_Pulse, @BR_Vital_Respiration, @BR_Vital_Systolic, @BR_Vital_Diastolic, @BR_Vital_Height, @BR_Vital_Weight, @BR_EncounterID); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmT000J12)
           ,new CursorDef("T000J13", "UPDATE [BR_Vital] SET [BR_Vital_VitalID]=@BR_Vital_VitalID, [BR_Vital_MeasureDate]=@BR_Vital_MeasureDate, [BR_Vital_Temperature]=@BR_Vital_Temperature, [BR_Vital_Pulse]=@BR_Vital_Pulse, [BR_Vital_Respiration]=@BR_Vital_Respiration, [BR_Vital_Systolic]=@BR_Vital_Systolic, [BR_Vital_Diastolic]=@BR_Vital_Diastolic, [BR_Vital_Height]=@BR_Vital_Height, [BR_Vital_Weight]=@BR_Vital_Weight, [BR_EncounterID]=@BR_EncounterID  WHERE [BR_VitalID] = @BR_VitalID", GxErrorMask.GX_NOMASK,prmT000J13)
           ,new CursorDef("T000J14", "DELETE FROM [BR_Vital]  WHERE [BR_VitalID] = @BR_VitalID", GxErrorMask.GX_NOMASK,prmT000J14)
           ,new CursorDef("T000J15", "SELECT [BR_Information_ID] FROM [BR_Encounter] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000J15,1,0,true,false )
           ,new CursorDef("T000J16", "SELECT [BR_Information_PatientNo] FROM [BR_Information] WITH (NOLOCK) WHERE [BR_Information_ID] = @BR_Information_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000J16,1,0,true,false )
           ,new CursorDef("T000J17", "SELECT [BR_VitalID] FROM [BR_Vital] WITH (NOLOCK) ORDER BY [BR_VitalID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000J17,100,0,true,false )
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
              ((long[]) buf[1])[0] = rslt.getLong(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((DateTime[]) buf[3])[0] = rslt.getGXDate(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((decimal[]) buf[5])[0] = rslt.getDecimal(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((decimal[]) buf[7])[0] = rslt.getDecimal(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((decimal[]) buf[9])[0] = rslt.getDecimal(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((decimal[]) buf[11])[0] = rslt.getDecimal(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              ((decimal[]) buf[13])[0] = rslt.getDecimal(8) ;
              ((bool[]) buf[14])[0] = rslt.wasNull(8);
              ((decimal[]) buf[15])[0] = rslt.getDecimal(9) ;
              ((bool[]) buf[16])[0] = rslt.wasNull(9);
              ((decimal[]) buf[17])[0] = rslt.getDecimal(10) ;
              ((bool[]) buf[18])[0] = rslt.wasNull(10);
              ((long[]) buf[19])[0] = rslt.getLong(11) ;
              return;
           case 1 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((long[]) buf[1])[0] = rslt.getLong(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((DateTime[]) buf[3])[0] = rslt.getGXDate(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((decimal[]) buf[5])[0] = rslt.getDecimal(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((decimal[]) buf[7])[0] = rslt.getDecimal(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((decimal[]) buf[9])[0] = rslt.getDecimal(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((decimal[]) buf[11])[0] = rslt.getDecimal(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              ((decimal[]) buf[13])[0] = rslt.getDecimal(8) ;
              ((bool[]) buf[14])[0] = rslt.wasNull(8);
              ((decimal[]) buf[15])[0] = rslt.getDecimal(9) ;
              ((bool[]) buf[16])[0] = rslt.wasNull(9);
              ((decimal[]) buf[17])[0] = rslt.getDecimal(10) ;
              ((bool[]) buf[18])[0] = rslt.wasNull(10);
              ((long[]) buf[19])[0] = rslt.getLong(11) ;
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
              ((long[]) buf[5])[0] = rslt.getLong(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((DateTime[]) buf[7])[0] = rslt.getGXDate(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((decimal[]) buf[9])[0] = rslt.getDecimal(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((decimal[]) buf[11])[0] = rslt.getDecimal(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              ((decimal[]) buf[13])[0] = rslt.getDecimal(8) ;
              ((bool[]) buf[14])[0] = rslt.wasNull(8);
              ((decimal[]) buf[15])[0] = rslt.getDecimal(9) ;
              ((bool[]) buf[16])[0] = rslt.wasNull(9);
              ((decimal[]) buf[17])[0] = rslt.getDecimal(10) ;
              ((bool[]) buf[18])[0] = rslt.wasNull(10);
              ((decimal[]) buf[19])[0] = rslt.getDecimal(11) ;
              ((bool[]) buf[20])[0] = rslt.wasNull(11);
              ((decimal[]) buf[21])[0] = rslt.getDecimal(12) ;
              ((bool[]) buf[22])[0] = rslt.wasNull(12);
              ((long[]) buf[23])[0] = rslt.getLong(13) ;
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
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
              }
              if ( (bool)parms[2] )
              {
                 stmt.setNull( 2 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameter(2, (DateTime)parms[3]);
              }
              if ( (bool)parms[4] )
              {
                 stmt.setNull( 3 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(3, (decimal)parms[5]);
              }
              if ( (bool)parms[6] )
              {
                 stmt.setNull( 4 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(4, (decimal)parms[7]);
              }
              if ( (bool)parms[8] )
              {
                 stmt.setNull( 5 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(5, (decimal)parms[9]);
              }
              if ( (bool)parms[10] )
              {
                 stmt.setNull( 6 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(6, (decimal)parms[11]);
              }
              if ( (bool)parms[12] )
              {
                 stmt.setNull( 7 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(7, (decimal)parms[13]);
              }
              if ( (bool)parms[14] )
              {
                 stmt.setNull( 8 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(8, (decimal)parms[15]);
              }
              if ( (bool)parms[16] )
              {
                 stmt.setNull( 9 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(9, (decimal)parms[17]);
              }
              stmt.SetParameter(10, (long)parms[18]);
              return;
           case 11 :
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
              }
              if ( (bool)parms[2] )
              {
                 stmt.setNull( 2 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameter(2, (DateTime)parms[3]);
              }
              if ( (bool)parms[4] )
              {
                 stmt.setNull( 3 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(3, (decimal)parms[5]);
              }
              if ( (bool)parms[6] )
              {
                 stmt.setNull( 4 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(4, (decimal)parms[7]);
              }
              if ( (bool)parms[8] )
              {
                 stmt.setNull( 5 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(5, (decimal)parms[9]);
              }
              if ( (bool)parms[10] )
              {
                 stmt.setNull( 6 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(6, (decimal)parms[11]);
              }
              if ( (bool)parms[12] )
              {
                 stmt.setNull( 7 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(7, (decimal)parms[13]);
              }
              if ( (bool)parms[14] )
              {
                 stmt.setNull( 8 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(8, (decimal)parms[15]);
              }
              if ( (bool)parms[16] )
              {
                 stmt.setNull( 9 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(9, (decimal)parms[17]);
              }
              stmt.SetParameter(10, (long)parms[18]);
              stmt.SetParameter(11, (long)parms[19]);
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
     }
  }

}

}
