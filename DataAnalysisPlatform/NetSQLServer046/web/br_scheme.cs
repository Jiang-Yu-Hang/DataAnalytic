/*
               File: BR_Scheme
        Description: Data Mgmt Portal - RAAP
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 11:57:56.80
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
   public class br_scheme : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxJX_Action16") == 0 )
         {
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            XC_16_1239( ) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxJX_Action17") == 0 )
         {
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            XC_17_1239( ) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"BR_SCHEME_THERAPY_LINE") == 0 )
         {
            AV18tCurrentCode = GetNextPar( );
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18tCurrentCode", AV18tCurrentCode);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GXDLABR_SCHEME_THERAPY_LINE1239( AV18tCurrentCode) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel9"+"_"+"BR_SCHEME_THERAPY_LINE_CODE") == 0 )
         {
            A329BR_Scheme_Therapy_Line = GetNextPar( );
            n329BR_Scheme_Therapy_Line = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A329BR_Scheme_Therapy_Line", A329BR_Scheme_Therapy_Line);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX9ASABR_SCHEME_THERAPY_LINE_CODE1239( A329BR_Scheme_Therapy_Line) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel10"+"_"+"BR_SCHEME_THERAPY_LINE_CODE") == 0 )
         {
            A329BR_Scheme_Therapy_Line = GetNextPar( );
            n329BR_Scheme_Therapy_Line = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A329BR_Scheme_Therapy_Line", A329BR_Scheme_Therapy_Line);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX10ASABR_SCHEME_THERAPY_LINE_CODE1239( A329BR_Scheme_Therapy_Line) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_19") == 0 )
         {
            A19BR_EncounterID = (long)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_19( A19BR_EncounterID) ;
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
               AV7BR_SchemeID = (long)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7BR_SchemeID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7BR_SchemeID), 18, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vBR_SCHEMEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7BR_SchemeID), "ZZZZZZZZZZZZZZZZZZ"), context));
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
         GX_FocusControl = edtBR_Scheme_Chem_Regimens_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("WorkWithPlusTheme");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public br_scheme( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_scheme( IGxContext context )
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
                           long aP1_BR_SchemeID )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV7BR_SchemeID = aP1_BR_SchemeID;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         dynBR_Scheme_Therapy_Line = new GXCombobox();
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
         if ( dynBR_Scheme_Therapy_Line.ItemCount > 0 )
         {
            A329BR_Scheme_Therapy_Line = dynBR_Scheme_Therapy_Line.getValidValue(A329BR_Scheme_Therapy_Line);
            n329BR_Scheme_Therapy_Line = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A329BR_Scheme_Therapy_Line", A329BR_Scheme_Therapy_Line);
         }
         if ( context.isAjaxRequest( ) )
         {
            dynBR_Scheme_Therapy_Line.CurrentValue = StringUtil.RTrim( A329BR_Scheme_Therapy_Line);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynBR_Scheme_Therapy_Line_Internalname, "Values", dynBR_Scheme_Therapy_Line.ToJavascriptSource(), true);
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
            GxWebStd.gx_div_start( context, divUnnamedtablebr_scheme_chem_regimens_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_scheme_chem_regimens_Internalname, "化疗方案", "", "", lblTextblockbr_scheme_chem_regimens_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Scheme.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Scheme_Chem_Regimens_Internalname, "化疗方案", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_Scheme_Chem_Regimens_Internalname, A328BR_Scheme_Chem_Regimens, StringUtil.RTrim( context.localUtil.Format( A328BR_Scheme_Chem_Regimens, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,29);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Scheme_Chem_Regimens_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBR_Scheme_Chem_Regimens_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Scheme.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablesplittedbr_scheme_therapy_line_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_scheme_therapy_line_Internalname, "方案线级", "", "", lblTextblockbr_scheme_therapy_line_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Scheme.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            wb_table1_36_1239( true) ;
         }
         return  ;
      }

      protected void wb_table1_36_1239e( bool wbgen )
      {
         if ( wbgen )
         {
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_scheme_chem_cycle_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-2 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_scheme_chem_cycle_Internalname, "化疗周期", "", "", lblTextblockbr_scheme_chem_cycle_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Scheme.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-10", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Scheme_Chem_Cycle_Internalname, "化疗周期", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 52,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_Scheme_Chem_Cycle_Internalname, StringUtil.LTrim( StringUtil.NToC( A330BR_Scheme_Chem_Cycle, 15, 5, ".", "")), ((edtBR_Scheme_Chem_Cycle_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A330BR_Scheme_Chem_Cycle, "ZZZZZZZZZ.ZZZZZ")) : context.localUtil.Format( A330BR_Scheme_Chem_Cycle, "ZZZZZZZZZ.ZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, ',','.','5');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,52);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Scheme_Chem_Cycle_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBR_Scheme_Chem_Cycle_Enabled, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "DM_Numeric", "right", false, "HLP_BR_Scheme.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_scheme_chem_detail_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-2 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_scheme_chem_detail_Internalname, "化疗方案描述", "", "", lblTextblockbr_scheme_chem_detail_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Scheme.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-10", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Scheme_Chem_Detail_Internalname, "化疗方案描述", "col-sm-3 AttributeLabel", 0, true);
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 60,'',false,'',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtBR_Scheme_Chem_Detail_Internalname, A331BR_Scheme_Chem_Detail, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,60);\"", 0, 1, edtBR_Scheme_Chem_Detail_Enabled, 0, 80, "chr", 10, "row", StyleString, ClassString, "", "", "4000", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Scheme.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 65,'',false,'',0)\"";
            ClassString = "ButtonMaterial";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_enter_Internalname, "", "保存", bttBtntrn_enter_Jsonclick, 5, "确认", "", StyleString, ClassString, bttBtntrn_enter_Visible, bttBtntrn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_Scheme.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 67,'',false,'',0)\"";
            ClassString = "ButtonMaterialDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_cancel_Internalname, "", "取消", bttBtntrn_cancel_Jsonclick, 1, "取消", "", StyleString, ClassString, bttBtntrn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_Scheme.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 69,'',false,'',0)\"";
            ClassString = "ButtonMaterialDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_delete_Internalname, "", "删除", bttBtntrn_delete_Jsonclick, 5, "删除", "", StyleString, ClassString, bttBtntrn_delete_Visible, bttBtntrn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_Scheme.htm");
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
            GxWebStd.gx_single_line_edit( context, edtBR_SchemeID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A327BR_SchemeID), 18, 0, ".", "")), ((edtBR_SchemeID_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A327BR_SchemeID), "ZZZZZZZZZZZZZZZZZZ")) : context.localUtil.Format( (decimal)(A327BR_SchemeID), "ZZZZZZZZZZZZZZZZZZ")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_SchemeID_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_SchemeID_Visible, edtBR_SchemeID_Enabled, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "HLP_BR_Scheme.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 74,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_EncounterID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A19BR_EncounterID), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A19BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,74);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_EncounterID_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_EncounterID_Visible, edtBR_EncounterID_Enabled, 1, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "HLP_BR_Scheme.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            fix_multi_value_controls( ) ;
         }
         /* Execute Exit event if defined. */
      }

      protected void wb_table1_36_1239( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTablemergedbr_scheme_therapy_line_Internalname, tblTablemergedbr_scheme_therapy_line_Internalname, "", "TableMerged", 0, "", "", 0, 0, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='MergeDataCell'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynBR_Scheme_Therapy_Line_Internalname, "方案线级", "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 40,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynBR_Scheme_Therapy_Line, dynBR_Scheme_Therapy_Line_Internalname, StringUtil.RTrim( A329BR_Scheme_Therapy_Line), 1, dynBR_Scheme_Therapy_Line_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, dynBR_Scheme_Therapy_Line.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,40);\"", "", true, "HLP_BR_Scheme.htm");
            dynBR_Scheme_Therapy_Line.CurrentValue = StringUtil.RTrim( A329BR_Scheme_Therapy_Line);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynBR_Scheme_Therapy_Line_Internalname, "Values", (String)(dynBR_Scheme_Therapy_Line.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\""+cellVline_cell_Internalname+"\"  class='"+cellVline_cell_Class+"'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavVline_Internalname, "其它线级", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavVline_Internalname, AV16vline, StringUtil.RTrim( context.localUtil.Format( AV16vline, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,43);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "请填写其它线级", edtavVline_Jsonclick, 0, "Attribute", "", "", "", "", edtavVline_Visible, edtavVline_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Scheme.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_36_1239e( true) ;
         }
         else
         {
            wb_table1_36_1239e( false) ;
         }
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
         E11122 ();
         context.wbGlbDoneStart = 1;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
               A328BR_Scheme_Chem_Regimens = cgiGet( edtBR_Scheme_Chem_Regimens_Internalname);
               n328BR_Scheme_Chem_Regimens = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A328BR_Scheme_Chem_Regimens", A328BR_Scheme_Chem_Regimens);
               n328BR_Scheme_Chem_Regimens = (String.IsNullOrEmpty(StringUtil.RTrim( A328BR_Scheme_Chem_Regimens)) ? true : false);
               dynBR_Scheme_Therapy_Line.CurrentValue = cgiGet( dynBR_Scheme_Therapy_Line_Internalname);
               A329BR_Scheme_Therapy_Line = cgiGet( dynBR_Scheme_Therapy_Line_Internalname);
               n329BR_Scheme_Therapy_Line = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A329BR_Scheme_Therapy_Line", A329BR_Scheme_Therapy_Line);
               n329BR_Scheme_Therapy_Line = (String.IsNullOrEmpty(StringUtil.RTrim( A329BR_Scheme_Therapy_Line)) ? true : false);
               AV16vline = cgiGet( edtavVline_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16vline", AV16vline);
               if ( ( ( context.localUtil.CToN( cgiGet( edtBR_Scheme_Chem_Cycle_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtBR_Scheme_Chem_Cycle_Internalname), ".", ",") > 999999999.99999m ) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_SCHEME_CHEM_CYCLE");
                  AnyError = 1;
                  GX_FocusControl = edtBR_Scheme_Chem_Cycle_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A330BR_Scheme_Chem_Cycle = 0;
                  n330BR_Scheme_Chem_Cycle = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A330BR_Scheme_Chem_Cycle", StringUtil.LTrim( StringUtil.Str( A330BR_Scheme_Chem_Cycle, 15, 5)));
               }
               else
               {
                  A330BR_Scheme_Chem_Cycle = context.localUtil.CToN( cgiGet( edtBR_Scheme_Chem_Cycle_Internalname), ".", ",");
                  n330BR_Scheme_Chem_Cycle = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A330BR_Scheme_Chem_Cycle", StringUtil.LTrim( StringUtil.Str( A330BR_Scheme_Chem_Cycle, 15, 5)));
               }
               n330BR_Scheme_Chem_Cycle = ((Convert.ToDecimal(0)==A330BR_Scheme_Chem_Cycle) ? true : false);
               A331BR_Scheme_Chem_Detail = cgiGet( edtBR_Scheme_Chem_Detail_Internalname);
               n331BR_Scheme_Chem_Detail = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A331BR_Scheme_Chem_Detail", A331BR_Scheme_Chem_Detail);
               n331BR_Scheme_Chem_Detail = (String.IsNullOrEmpty(StringUtil.RTrim( A331BR_Scheme_Chem_Detail)) ? true : false);
               A327BR_SchemeID = (long)(context.localUtil.CToN( cgiGet( edtBR_SchemeID_Internalname), ".", ","));
               n327BR_SchemeID = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A327BR_SchemeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A327BR_SchemeID), 18, 0)));
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
               /* Read saved values. */
               Z327BR_SchemeID = (long)(context.localUtil.CToN( cgiGet( "Z327BR_SchemeID"), ".", ","));
               Z500BR_Scheme_Therapy_Line_Code = cgiGet( "Z500BR_Scheme_Therapy_Line_Code");
               n500BR_Scheme_Therapy_Line_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A500BR_Scheme_Therapy_Line_Code)) ? true : false);
               Z328BR_Scheme_Chem_Regimens = cgiGet( "Z328BR_Scheme_Chem_Regimens");
               n328BR_Scheme_Chem_Regimens = (String.IsNullOrEmpty(StringUtil.RTrim( A328BR_Scheme_Chem_Regimens)) ? true : false);
               Z329BR_Scheme_Therapy_Line = cgiGet( "Z329BR_Scheme_Therapy_Line");
               n329BR_Scheme_Therapy_Line = (String.IsNullOrEmpty(StringUtil.RTrim( A329BR_Scheme_Therapy_Line)) ? true : false);
               Z330BR_Scheme_Chem_Cycle = context.localUtil.CToN( cgiGet( "Z330BR_Scheme_Chem_Cycle"), ".", ",");
               n330BR_Scheme_Chem_Cycle = ((Convert.ToDecimal(0)==A330BR_Scheme_Chem_Cycle) ? true : false);
               Z331BR_Scheme_Chem_Detail = cgiGet( "Z331BR_Scheme_Chem_Detail");
               n331BR_Scheme_Chem_Detail = (String.IsNullOrEmpty(StringUtil.RTrim( A331BR_Scheme_Chem_Detail)) ? true : false);
               Z19BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( "Z19BR_EncounterID"), ".", ","));
               A500BR_Scheme_Therapy_Line_Code = cgiGet( "Z500BR_Scheme_Therapy_Line_Code");
               n500BR_Scheme_Therapy_Line_Code = false;
               n500BR_Scheme_Therapy_Line_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A500BR_Scheme_Therapy_Line_Code)) ? true : false);
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ","));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ","));
               Gx_mode = cgiGet( "Mode");
               N19BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( "N19BR_EncounterID"), ".", ","));
               AV7BR_SchemeID = (long)(context.localUtil.CToN( cgiGet( "vBR_SCHEMEID"), ".", ","));
               AV13Insert_BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( "vINSERT_BR_ENCOUNTERID"), ".", ","));
               A500BR_Scheme_Therapy_Line_Code = cgiGet( "BR_SCHEME_THERAPY_LINE_CODE");
               n500BR_Scheme_Therapy_Line_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A500BR_Scheme_Therapy_Line_Code)) ? true : false);
               AV18tCurrentCode = cgiGet( "vTCURRENTCODE");
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
               forbiddenHiddens = "hsh" + "BR_Scheme";
               A327BR_SchemeID = (long)(context.localUtil.CToN( cgiGet( edtBR_SchemeID_Internalname), ".", ","));
               n327BR_SchemeID = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A327BR_SchemeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A327BR_SchemeID), 18, 0)));
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A327BR_SchemeID), "ZZZZZZZZZZZZZZZZZZ");
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( AV18tCurrentCode, ""));
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV13Insert_BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ");
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( A327BR_SchemeID != Z327BR_SchemeID ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
               {
                  GXUtil.WriteLog("br_scheme:[SecurityCheckFailed value for]"+"BR_SchemeID:"+context.localUtil.Format( (decimal)(A327BR_SchemeID), "ZZZZZZZZZZZZZZZZZZ"));
                  GXUtil.WriteLog("br_scheme:[SecurityCheckFailed value for]"+"tCurrentCode:"+StringUtil.RTrim( context.localUtil.Format( AV18tCurrentCode, "")));
                  GXUtil.WriteLog("br_scheme:[SecurityCheckFailed value for]"+"Insert_BR_EncounterID:"+context.localUtil.Format( (decimal)(AV13Insert_BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ"));
                  GXUtil.WriteLog("br_scheme:[SecurityCheckFailed value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
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
                  A327BR_SchemeID = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  n327BR_SchemeID = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A327BR_SchemeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A327BR_SchemeID), 18, 0)));
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
                     sMode39 = Gx_mode;
                     Gx_mode = "UPD";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     Gx_mode = sMode39;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound39 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_120( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtntrn_enter_Internalname;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert", ""), 1, "BR_SCHEMEID");
                        AnyError = 1;
                        GX_FocusControl = edtBR_SchemeID_Internalname;
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
                           E11122 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: After Trn */
                           E12122 ();
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
            E12122 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll1239( ) ;
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
            DisableAttributes1239( ) ;
         }
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVline_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVline_Enabled), 5, 0)), true);
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

      protected void CONFIRM_120( )
      {
         BeforeValidate1239( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls1239( ) ;
            }
            else
            {
               CheckExtendedTable1239( ) ;
               CloseExtendedTableCursors1239( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         }
      }

      protected void ResetCaption120( )
      {
      }

      protected void E11122( )
      {
         /* Start Routine */
         GXt_char1 = AV18tCurrentCode;
         new zbr_getcurrenttcode(context ).execute( out  GXt_char1) ;
         AV18tCurrentCode = GXt_char1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18tCurrentCode", AV18tCurrentCode);
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV8WWPContext) ;
         AV9IsAuthorized = true;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9IsAuthorized", AV9IsAuthorized);
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            GXt_boolean2 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Scheme", out  GXt_boolean2) ;
            AV9IsAuthorized = GXt_boolean2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9IsAuthorized", AV9IsAuthorized);
         }
         if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
         {
            GXt_boolean2 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Scheme", out  GXt_boolean2) ;
            AV9IsAuthorized = GXt_boolean2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9IsAuthorized", AV9IsAuthorized);
         }
         if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
         {
            GXt_boolean2 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Scheme", out  GXt_boolean2) ;
            AV9IsAuthorized = GXt_boolean2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9IsAuthorized", AV9IsAuthorized);
         }
         if ( ! AV9IsAuthorized )
         {
            CallWebObject(formatLink("wwpbaseobjects.notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV19Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         /* Execute user subroutine: 'ATTRIBUTESSECURITYCODE' */
         S112 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         AV11TrnContext.FromXml(AV12WebSession.Get("TrnContext"), null, "WWPTransactionContext", "DataAnalysisPlatform");
         if ( ( StringUtil.StrCmp(AV11TrnContext.gxTpr_Transactionname, AV19Pgmname) == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) )
         {
            AV20GXV1 = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV20GXV1), 8, 0)));
            while ( AV20GXV1 <= AV11TrnContext.gxTpr_Attributes.Count )
            {
               AV14TrnContextAtt = ((GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute)AV11TrnContext.gxTpr_Attributes.Item(AV20GXV1));
               if ( StringUtil.StrCmp(AV14TrnContextAtt.gxTpr_Attributename, "BR_EncounterID") == 0 )
               {
                  AV13Insert_BR_EncounterID = (long)(NumberUtil.Val( AV14TrnContextAtt.gxTpr_Attributevalue, "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13Insert_BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13Insert_BR_EncounterID), 18, 0)));
               }
               AV20GXV1 = (int)(AV20GXV1+1);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV20GXV1), 8, 0)));
            }
         }
         edtBR_SchemeID_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_SchemeID_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_SchemeID_Visible), 5, 0)), true);
         edtBR_EncounterID_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_EncounterID_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_EncounterID_Visible), 5, 0)), true);
         GXt_boolean2 = AV17TempBoolean;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Scheme", out  GXt_boolean2) ;
         AV17TempBoolean = GXt_boolean2;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17TempBoolean", AV17TempBoolean);
         if ( ! ( AV17TempBoolean ) )
         {
            bttBtntrn_enter_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_enter_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_enter_Visible), 5, 0)), true);
         }
         GXt_boolean2 = AV17TempBoolean;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Scheme", out  GXt_boolean2) ;
         AV17TempBoolean = GXt_boolean2;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17TempBoolean", AV17TempBoolean);
         if ( ! ( AV17TempBoolean ) )
         {
            bttBtntrn_cancel_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_cancel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_cancel_Visible), 5, 0)), true);
         }
         GXt_boolean2 = AV17TempBoolean;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Scheme", out  GXt_boolean2) ;
         AV17TempBoolean = GXt_boolean2;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17TempBoolean", AV17TempBoolean);
         if ( ! ( AV17TempBoolean ) )
         {
            bttBtntrn_delete_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_delete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_delete_Visible), 5, 0)), true);
         }
      }

      protected void E12122( )
      {
         /* After Trn Routine */
         if ( 1 == 0 )
         {
            if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV11TrnContext.gxTpr_Callerondelete )
            {
               CallWebObject(formatLink("br_schemeww.aspx") );
               context.wjLocDisableFrm = 1;
            }
            context.setWebReturnParms(new Object[] {});
            context.setWebReturnParmsMetadata(new Object[] {});
            context.wjLocDisableFrm = 1;
            context.nUserReturn = 1;
            returnInSub = true;
            if (true) return;
         }
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            CallWebObject(formatLink("br_schemeview.aspx") + "?" + UrlEncode("" +A327BR_SchemeID) + "," + UrlEncode(StringUtil.RTrim("General")));
            context.wjLocDisableFrm = 1;
         }
         context.setWebReturnParms(new Object[] {});
         context.setWebReturnParmsMetadata(new Object[] {});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      protected void S112( )
      {
         /* 'ATTRIBUTESSECURITYCODE' Routine */
         edtavVline_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVline_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVline_Visible), 5, 0)), true);
         cellVline_cell_Class = "Invisible";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVline_cell_Internalname, "Class", cellVline_cell_Class, true);
      }

      protected void ZM1239( short GX_JID )
      {
         if ( ( GX_JID == 18 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z500BR_Scheme_Therapy_Line_Code = T00123_A500BR_Scheme_Therapy_Line_Code[0];
               Z328BR_Scheme_Chem_Regimens = T00123_A328BR_Scheme_Chem_Regimens[0];
               Z329BR_Scheme_Therapy_Line = T00123_A329BR_Scheme_Therapy_Line[0];
               Z330BR_Scheme_Chem_Cycle = T00123_A330BR_Scheme_Chem_Cycle[0];
               Z331BR_Scheme_Chem_Detail = T00123_A331BR_Scheme_Chem_Detail[0];
               Z19BR_EncounterID = T00123_A19BR_EncounterID[0];
            }
            else
            {
               Z500BR_Scheme_Therapy_Line_Code = A500BR_Scheme_Therapy_Line_Code;
               Z328BR_Scheme_Chem_Regimens = A328BR_Scheme_Chem_Regimens;
               Z329BR_Scheme_Therapy_Line = A329BR_Scheme_Therapy_Line;
               Z330BR_Scheme_Chem_Cycle = A330BR_Scheme_Chem_Cycle;
               Z331BR_Scheme_Chem_Detail = A331BR_Scheme_Chem_Detail;
               Z19BR_EncounterID = A19BR_EncounterID;
            }
         }
         if ( GX_JID == -18 )
         {
            Z327BR_SchemeID = A327BR_SchemeID;
            Z500BR_Scheme_Therapy_Line_Code = A500BR_Scheme_Therapy_Line_Code;
            Z328BR_Scheme_Chem_Regimens = A328BR_Scheme_Chem_Regimens;
            Z329BR_Scheme_Therapy_Line = A329BR_Scheme_Therapy_Line;
            Z330BR_Scheme_Chem_Cycle = A330BR_Scheme_Chem_Cycle;
            Z331BR_Scheme_Chem_Detail = A331BR_Scheme_Chem_Detail;
            Z19BR_EncounterID = A19BR_EncounterID;
         }
      }

      protected void standaloneNotModal( )
      {
         edtBR_SchemeID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_SchemeID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_SchemeID_Enabled), 5, 0)), true);
         edtBR_SchemeID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_SchemeID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_SchemeID_Enabled), 5, 0)), true);
         bttBtntrn_delete_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_delete_Enabled), 5, 0)), true);
         if ( ! (0==AV7BR_SchemeID) )
         {
            A327BR_SchemeID = AV7BR_SchemeID;
            n327BR_SchemeID = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A327BR_SchemeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A327BR_SchemeID), 18, 0)));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV13Insert_BR_EncounterID) )
         {
            edtBR_EncounterID_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_EncounterID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_EncounterID_Enabled), 5, 0)), true);
         }
         else
         {
            edtBR_EncounterID_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_EncounterID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_EncounterID_Enabled), 5, 0)), true);
         }
         GXABR_SCHEME_THERAPY_LINE_html1239( AV18tCurrentCode) ;
      }

      protected void standaloneModal( )
      {
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV13Insert_BR_EncounterID) )
         {
            A19BR_EncounterID = AV13Insert_BR_EncounterID;
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
            AV19Pgmname = "BR_Scheme";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19Pgmname", AV19Pgmname);
            edtavVline_Visible = ((StringUtil.StrCmp(A329BR_Scheme_Therapy_Line, "其它")==0) ? 1 : 0);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVline_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVline_Visible), 5, 0)), true);
            if ( ! ( ( StringUtil.StrCmp(A329BR_Scheme_Therapy_Line, "其它") == 0 ) ) )
            {
               cellVline_cell_Class = "Invisible";
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVline_cell_Internalname, "Class", cellVline_cell_Class, true);
            }
            else
            {
               if ( StringUtil.StrCmp(A329BR_Scheme_Therapy_Line, "其它") == 0 )
               {
                  cellVline_cell_Class = "RequiredDataContentCell";
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVline_cell_Internalname, "Class", cellVline_cell_Class, true);
               }
            }
         }
      }

      protected void Load1239( )
      {
         /* Using cursor T00125 */
         pr_default.execute(3, new Object[] {n327BR_SchemeID, A327BR_SchemeID});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound39 = 1;
            A500BR_Scheme_Therapy_Line_Code = T00125_A500BR_Scheme_Therapy_Line_Code[0];
            n500BR_Scheme_Therapy_Line_Code = T00125_n500BR_Scheme_Therapy_Line_Code[0];
            A328BR_Scheme_Chem_Regimens = T00125_A328BR_Scheme_Chem_Regimens[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A328BR_Scheme_Chem_Regimens", A328BR_Scheme_Chem_Regimens);
            n328BR_Scheme_Chem_Regimens = T00125_n328BR_Scheme_Chem_Regimens[0];
            A329BR_Scheme_Therapy_Line = T00125_A329BR_Scheme_Therapy_Line[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A329BR_Scheme_Therapy_Line", A329BR_Scheme_Therapy_Line);
            n329BR_Scheme_Therapy_Line = T00125_n329BR_Scheme_Therapy_Line[0];
            A330BR_Scheme_Chem_Cycle = T00125_A330BR_Scheme_Chem_Cycle[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A330BR_Scheme_Chem_Cycle", StringUtil.LTrim( StringUtil.Str( A330BR_Scheme_Chem_Cycle, 15, 5)));
            n330BR_Scheme_Chem_Cycle = T00125_n330BR_Scheme_Chem_Cycle[0];
            A331BR_Scheme_Chem_Detail = T00125_A331BR_Scheme_Chem_Detail[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A331BR_Scheme_Chem_Detail", A331BR_Scheme_Chem_Detail);
            n331BR_Scheme_Chem_Detail = T00125_n331BR_Scheme_Chem_Detail[0];
            A19BR_EncounterID = T00125_A19BR_EncounterID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
            ZM1239( -18) ;
         }
         pr_default.close(3);
         OnLoadActions1239( ) ;
      }

      protected void OnLoadActions1239( )
      {
         AV19Pgmname = "BR_Scheme";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19Pgmname", AV19Pgmname);
         edtavVline_Visible = ((StringUtil.StrCmp(A329BR_Scheme_Therapy_Line, "其它")==0) ? 1 : 0);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVline_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVline_Visible), 5, 0)), true);
         if ( ! ( ( StringUtil.StrCmp(A329BR_Scheme_Therapy_Line, "其它") == 0 ) ) )
         {
            cellVline_cell_Class = "Invisible";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVline_cell_Internalname, "Class", cellVline_cell_Class, true);
         }
         else
         {
            if ( StringUtil.StrCmp(A329BR_Scheme_Therapy_Line, "其它") == 0 )
            {
               cellVline_cell_Class = "RequiredDataContentCell";
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVline_cell_Internalname, "Class", cellVline_cell_Class, true);
            }
         }
      }

      protected void CheckExtendedTable1239( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
         AV19Pgmname = "BR_Scheme";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19Pgmname", AV19Pgmname);
         /* Using cursor T00124 */
         pr_default.execute(2, new Object[] {A19BR_EncounterID});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("不匹配' T15'", "ForeignKeyNotFound", 1, "BR_ENCOUNTERID");
            AnyError = 1;
            GX_FocusControl = edtBR_EncounterID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         pr_default.close(2);
         if ( String.IsNullOrEmpty(StringUtil.RTrim( A328BR_Scheme_Chem_Regimens)) )
         {
            GX_msglist.addItem("化疗方案是必须填写的。", 1, "BR_SCHEME_CHEM_REGIMENS");
            AnyError = 1;
            GX_FocusControl = edtBR_Scheme_Chem_Regimens_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         edtavVline_Visible = ((StringUtil.StrCmp(A329BR_Scheme_Therapy_Line, "其它")==0) ? 1 : 0);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVline_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVline_Visible), 5, 0)), true);
         if ( ! ( ( StringUtil.StrCmp(A329BR_Scheme_Therapy_Line, "其它") == 0 ) ) )
         {
            cellVline_cell_Class = "Invisible";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVline_cell_Internalname, "Class", cellVline_cell_Class, true);
         }
         else
         {
            if ( StringUtil.StrCmp(A329BR_Scheme_Therapy_Line, "其它") == 0 )
            {
               cellVline_cell_Class = "RequiredDataContentCell";
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVline_cell_Internalname, "Class", cellVline_cell_Class, true);
            }
         }
         if ( ( ( StringUtil.StrCmp(A329BR_Scheme_Therapy_Line, "其它") == 0 ) ) && String.IsNullOrEmpty(StringUtil.RTrim( AV16vline)) )
         {
            GX_msglist.addItem("其它线级是必填的", 1, "BR_SCHEME_THERAPY_LINE");
            AnyError = 1;
            GX_FocusControl = dynBR_Scheme_Therapy_Line_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
      }

      protected void CloseExtendedTableCursors1239( )
      {
         pr_default.close(2);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_19( long A19BR_EncounterID )
      {
         /* Using cursor T00126 */
         pr_default.execute(4, new Object[] {A19BR_EncounterID});
         if ( (pr_default.getStatus(4) == 101) )
         {
            GX_msglist.addItem("不匹配' T15'", "ForeignKeyNotFound", 1, "BR_ENCOUNTERID");
            AnyError = 1;
            GX_FocusControl = edtBR_EncounterID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
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

      protected void GetKey1239( )
      {
         /* Using cursor T00127 */
         pr_default.execute(5, new Object[] {n327BR_SchemeID, A327BR_SchemeID});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound39 = 1;
         }
         else
         {
            RcdFound39 = 0;
         }
         pr_default.close(5);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00123 */
         pr_default.execute(1, new Object[] {n327BR_SchemeID, A327BR_SchemeID});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM1239( 18) ;
            RcdFound39 = 1;
            A327BR_SchemeID = T00123_A327BR_SchemeID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A327BR_SchemeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A327BR_SchemeID), 18, 0)));
            n327BR_SchemeID = T00123_n327BR_SchemeID[0];
            A500BR_Scheme_Therapy_Line_Code = T00123_A500BR_Scheme_Therapy_Line_Code[0];
            n500BR_Scheme_Therapy_Line_Code = T00123_n500BR_Scheme_Therapy_Line_Code[0];
            A328BR_Scheme_Chem_Regimens = T00123_A328BR_Scheme_Chem_Regimens[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A328BR_Scheme_Chem_Regimens", A328BR_Scheme_Chem_Regimens);
            n328BR_Scheme_Chem_Regimens = T00123_n328BR_Scheme_Chem_Regimens[0];
            A329BR_Scheme_Therapy_Line = T00123_A329BR_Scheme_Therapy_Line[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A329BR_Scheme_Therapy_Line", A329BR_Scheme_Therapy_Line);
            n329BR_Scheme_Therapy_Line = T00123_n329BR_Scheme_Therapy_Line[0];
            A330BR_Scheme_Chem_Cycle = T00123_A330BR_Scheme_Chem_Cycle[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A330BR_Scheme_Chem_Cycle", StringUtil.LTrim( StringUtil.Str( A330BR_Scheme_Chem_Cycle, 15, 5)));
            n330BR_Scheme_Chem_Cycle = T00123_n330BR_Scheme_Chem_Cycle[0];
            A331BR_Scheme_Chem_Detail = T00123_A331BR_Scheme_Chem_Detail[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A331BR_Scheme_Chem_Detail", A331BR_Scheme_Chem_Detail);
            n331BR_Scheme_Chem_Detail = T00123_n331BR_Scheme_Chem_Detail[0];
            A19BR_EncounterID = T00123_A19BR_EncounterID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
            Z327BR_SchemeID = A327BR_SchemeID;
            sMode39 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load1239( ) ;
            if ( AnyError == 1 )
            {
               RcdFound39 = 0;
               InitializeNonKey1239( ) ;
            }
            Gx_mode = sMode39;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound39 = 0;
            InitializeNonKey1239( ) ;
            sMode39 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal( ) ;
            Gx_mode = sMode39;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey1239( ) ;
         if ( RcdFound39 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound39 = 0;
         /* Using cursor T00128 */
         pr_default.execute(6, new Object[] {n327BR_SchemeID, A327BR_SchemeID});
         if ( (pr_default.getStatus(6) != 101) )
         {
            while ( (pr_default.getStatus(6) != 101) && ( ( T00128_A327BR_SchemeID[0] < A327BR_SchemeID ) ) )
            {
               pr_default.readNext(6);
            }
            if ( (pr_default.getStatus(6) != 101) && ( ( T00128_A327BR_SchemeID[0] > A327BR_SchemeID ) ) )
            {
               A327BR_SchemeID = T00128_A327BR_SchemeID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A327BR_SchemeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A327BR_SchemeID), 18, 0)));
               n327BR_SchemeID = T00128_n327BR_SchemeID[0];
               RcdFound39 = 1;
            }
         }
         pr_default.close(6);
      }

      protected void move_previous( )
      {
         RcdFound39 = 0;
         /* Using cursor T00129 */
         pr_default.execute(7, new Object[] {n327BR_SchemeID, A327BR_SchemeID});
         if ( (pr_default.getStatus(7) != 101) )
         {
            while ( (pr_default.getStatus(7) != 101) && ( ( T00129_A327BR_SchemeID[0] > A327BR_SchemeID ) ) )
            {
               pr_default.readNext(7);
            }
            if ( (pr_default.getStatus(7) != 101) && ( ( T00129_A327BR_SchemeID[0] < A327BR_SchemeID ) ) )
            {
               A327BR_SchemeID = T00129_A327BR_SchemeID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A327BR_SchemeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A327BR_SchemeID), 18, 0)));
               n327BR_SchemeID = T00129_n327BR_SchemeID[0];
               RcdFound39 = 1;
            }
         }
         pr_default.close(7);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey1239( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtBR_Scheme_Chem_Regimens_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert1239( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound39 == 1 )
            {
               if ( A327BR_SchemeID != Z327BR_SchemeID )
               {
                  A327BR_SchemeID = Z327BR_SchemeID;
                  n327BR_SchemeID = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A327BR_SchemeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A327BR_SchemeID), 18, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "BR_SCHEMEID");
                  AnyError = 1;
                  GX_FocusControl = edtBR_SchemeID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtBR_Scheme_Chem_Regimens_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Update record */
                  Update1239( ) ;
                  GX_FocusControl = edtBR_Scheme_Chem_Regimens_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A327BR_SchemeID != Z327BR_SchemeID )
               {
                  /* Insert record */
                  GX_FocusControl = edtBR_Scheme_Chem_Regimens_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert1239( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "BR_SCHEMEID");
                     AnyError = 1;
                     GX_FocusControl = edtBR_SchemeID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     /* Insert record */
                     GX_FocusControl = edtBR_Scheme_Chem_Regimens_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert1239( ) ;
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
         if ( A327BR_SchemeID != Z327BR_SchemeID )
         {
            A327BR_SchemeID = Z327BR_SchemeID;
            n327BR_SchemeID = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A327BR_SchemeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A327BR_SchemeID), 18, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "BR_SCHEMEID");
            AnyError = 1;
            GX_FocusControl = edtBR_SchemeID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtBR_Scheme_Chem_Regimens_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency1239( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00122 */
            pr_default.execute(0, new Object[] {n327BR_SchemeID, A327BR_SchemeID});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BR_Scheme"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z500BR_Scheme_Therapy_Line_Code, T00122_A500BR_Scheme_Therapy_Line_Code[0]) != 0 ) || ( StringUtil.StrCmp(Z328BR_Scheme_Chem_Regimens, T00122_A328BR_Scheme_Chem_Regimens[0]) != 0 ) || ( StringUtil.StrCmp(Z329BR_Scheme_Therapy_Line, T00122_A329BR_Scheme_Therapy_Line[0]) != 0 ) || ( Z330BR_Scheme_Chem_Cycle != T00122_A330BR_Scheme_Chem_Cycle[0] ) || ( StringUtil.StrCmp(Z331BR_Scheme_Chem_Detail, T00122_A331BR_Scheme_Chem_Detail[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( Z19BR_EncounterID != T00122_A19BR_EncounterID[0] ) )
            {
               if ( StringUtil.StrCmp(Z500BR_Scheme_Therapy_Line_Code, T00122_A500BR_Scheme_Therapy_Line_Code[0]) != 0 )
               {
                  GXUtil.WriteLog("br_scheme:[seudo value changed for attri]"+"BR_Scheme_Therapy_Line_Code");
                  GXUtil.WriteLogRaw("Old: ",Z500BR_Scheme_Therapy_Line_Code);
                  GXUtil.WriteLogRaw("Current: ",T00122_A500BR_Scheme_Therapy_Line_Code[0]);
               }
               if ( StringUtil.StrCmp(Z328BR_Scheme_Chem_Regimens, T00122_A328BR_Scheme_Chem_Regimens[0]) != 0 )
               {
                  GXUtil.WriteLog("br_scheme:[seudo value changed for attri]"+"BR_Scheme_Chem_Regimens");
                  GXUtil.WriteLogRaw("Old: ",Z328BR_Scheme_Chem_Regimens);
                  GXUtil.WriteLogRaw("Current: ",T00122_A328BR_Scheme_Chem_Regimens[0]);
               }
               if ( StringUtil.StrCmp(Z329BR_Scheme_Therapy_Line, T00122_A329BR_Scheme_Therapy_Line[0]) != 0 )
               {
                  GXUtil.WriteLog("br_scheme:[seudo value changed for attri]"+"BR_Scheme_Therapy_Line");
                  GXUtil.WriteLogRaw("Old: ",Z329BR_Scheme_Therapy_Line);
                  GXUtil.WriteLogRaw("Current: ",T00122_A329BR_Scheme_Therapy_Line[0]);
               }
               if ( Z330BR_Scheme_Chem_Cycle != T00122_A330BR_Scheme_Chem_Cycle[0] )
               {
                  GXUtil.WriteLog("br_scheme:[seudo value changed for attri]"+"BR_Scheme_Chem_Cycle");
                  GXUtil.WriteLogRaw("Old: ",Z330BR_Scheme_Chem_Cycle);
                  GXUtil.WriteLogRaw("Current: ",T00122_A330BR_Scheme_Chem_Cycle[0]);
               }
               if ( StringUtil.StrCmp(Z331BR_Scheme_Chem_Detail, T00122_A331BR_Scheme_Chem_Detail[0]) != 0 )
               {
                  GXUtil.WriteLog("br_scheme:[seudo value changed for attri]"+"BR_Scheme_Chem_Detail");
                  GXUtil.WriteLogRaw("Old: ",Z331BR_Scheme_Chem_Detail);
                  GXUtil.WriteLogRaw("Current: ",T00122_A331BR_Scheme_Chem_Detail[0]);
               }
               if ( Z19BR_EncounterID != T00122_A19BR_EncounterID[0] )
               {
                  GXUtil.WriteLog("br_scheme:[seudo value changed for attri]"+"BR_EncounterID");
                  GXUtil.WriteLogRaw("Old: ",Z19BR_EncounterID);
                  GXUtil.WriteLogRaw("Current: ",T00122_A19BR_EncounterID[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"BR_Scheme"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert1239( )
      {
         BeforeValidate1239( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1239( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM1239( 0) ;
            CheckOptimisticConcurrency1239( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1239( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert1239( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001210 */
                     pr_default.execute(8, new Object[] {n500BR_Scheme_Therapy_Line_Code, A500BR_Scheme_Therapy_Line_Code, n328BR_Scheme_Chem_Regimens, A328BR_Scheme_Chem_Regimens, n329BR_Scheme_Therapy_Line, A329BR_Scheme_Therapy_Line, n330BR_Scheme_Chem_Cycle, A330BR_Scheme_Chem_Cycle, n331BR_Scheme_Chem_Detail, A331BR_Scheme_Chem_Detail, A19BR_EncounterID});
                     A327BR_SchemeID = T001210_A327BR_SchemeID[0];
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A327BR_SchemeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A327BR_SchemeID), 18, 0)));
                     n327BR_SchemeID = T001210_n327BR_SchemeID[0];
                     pr_default.close(8);
                     dsDefault.SmartCacheProvider.SetUpdated("BR_Scheme") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)),  "就诊信息",  StringUtil.Trim( StringUtil.Str( (decimal)(A327BR_SchemeID), 18, 0)),  "化疗方案",  "Create",  1) ;
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                           ResetCaption120( ) ;
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
               Load1239( ) ;
            }
            EndLevel1239( ) ;
         }
         CloseExtendedTableCursors1239( ) ;
      }

      protected void Update1239( )
      {
         BeforeValidate1239( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable1239( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1239( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm1239( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate1239( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T001211 */
                     pr_default.execute(9, new Object[] {n500BR_Scheme_Therapy_Line_Code, A500BR_Scheme_Therapy_Line_Code, n328BR_Scheme_Chem_Regimens, A328BR_Scheme_Chem_Regimens, n329BR_Scheme_Therapy_Line, A329BR_Scheme_Therapy_Line, n330BR_Scheme_Chem_Cycle, A330BR_Scheme_Chem_Cycle, n331BR_Scheme_Chem_Detail, A331BR_Scheme_Chem_Detail, A19BR_EncounterID, n327BR_SchemeID, A327BR_SchemeID});
                     pr_default.close(9);
                     dsDefault.SmartCacheProvider.SetUpdated("BR_Scheme") ;
                     if ( (pr_default.getStatus(9) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BR_Scheme"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate1239( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)),  "就诊信息",  StringUtil.Trim( StringUtil.Str( (decimal)(A327BR_SchemeID), 18, 0)),  "化疗方案",  "Update",  1) ;
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
            EndLevel1239( ) ;
         }
         CloseExtendedTableCursors1239( ) ;
      }

      protected void DeferredUpdate1239( )
      {
      }

      protected void delete( )
      {
         BeforeValidate1239( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency1239( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls1239( ) ;
            AfterConfirm1239( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete1239( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T001212 */
                  pr_default.execute(10, new Object[] {n327BR_SchemeID, A327BR_SchemeID});
                  pr_default.close(10);
                  dsDefault.SmartCacheProvider.SetUpdated("BR_Scheme") ;
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
         sMode39 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel1239( ) ;
         Gx_mode = sMode39;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls1239( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV19Pgmname = "BR_Scheme";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19Pgmname", AV19Pgmname);
            edtavVline_Visible = ((StringUtil.StrCmp(A329BR_Scheme_Therapy_Line, "其它")==0) ? 1 : 0);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVline_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVline_Visible), 5, 0)), true);
            if ( ! ( ( StringUtil.StrCmp(A329BR_Scheme_Therapy_Line, "其它") == 0 ) ) )
            {
               cellVline_cell_Class = "Invisible";
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVline_cell_Internalname, "Class", cellVline_cell_Class, true);
            }
            else
            {
               if ( StringUtil.StrCmp(A329BR_Scheme_Therapy_Line, "其它") == 0 )
               {
                  cellVline_cell_Class = "RequiredDataContentCell";
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVline_cell_Internalname, "Class", cellVline_cell_Class, true);
               }
            }
         }
         if ( AnyError == 0 )
         {
            /* Using cursor T001213 */
            pr_default.execute(11, new Object[] {n327BR_SchemeID, A327BR_SchemeID});
            if ( (pr_default.getStatus(11) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {" T40"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(11);
         }
      }

      protected void EndLevel1239( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete1239( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(1);
            context.CommitDataStores("br_scheme",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues120( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(1);
            context.RollbackDataStores("br_scheme",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart1239( )
      {
         /* Scan By routine */
         /* Using cursor T001214 */
         pr_default.execute(12);
         RcdFound39 = 0;
         if ( (pr_default.getStatus(12) != 101) )
         {
            RcdFound39 = 1;
            A327BR_SchemeID = T001214_A327BR_SchemeID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A327BR_SchemeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A327BR_SchemeID), 18, 0)));
            n327BR_SchemeID = T001214_n327BR_SchemeID[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext1239( )
      {
         /* Scan next routine */
         pr_default.readNext(12);
         RcdFound39 = 0;
         if ( (pr_default.getStatus(12) != 101) )
         {
            RcdFound39 = 1;
            A327BR_SchemeID = T001214_A327BR_SchemeID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A327BR_SchemeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A327BR_SchemeID), 18, 0)));
            n327BR_SchemeID = T001214_n327BR_SchemeID[0];
         }
      }

      protected void ScanEnd1239( )
      {
         pr_default.close(12);
      }

      protected void AfterConfirm1239( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert1239( )
      {
         /* Before Insert Rules */
         if ( StringUtil.StrCmp(A329BR_Scheme_Therapy_Line, "其它") == 0 )
         {
            A329BR_Scheme_Therapy_Line = AV16vline;
            n329BR_Scheme_Therapy_Line = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A329BR_Scheme_Therapy_Line", A329BR_Scheme_Therapy_Line);
         }
         GXt_char1 = A500BR_Scheme_Therapy_Line_Code;
         new zutil_findtargetcode(context ).execute(  27,  A329BR_Scheme_Therapy_Line, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A329BR_Scheme_Therapy_Line", A329BR_Scheme_Therapy_Line);
         A500BR_Scheme_Therapy_Line_Code = GXt_char1;
         n500BR_Scheme_Therapy_Line_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A500BR_Scheme_Therapy_Line_Code", A500BR_Scheme_Therapy_Line_Code);
      }

      protected void BeforeUpdate1239( )
      {
         /* Before Update Rules */
         GXt_char1 = A500BR_Scheme_Therapy_Line_Code;
         new zutil_findtargetcode(context ).execute(  27,  A329BR_Scheme_Therapy_Line, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A329BR_Scheme_Therapy_Line", A329BR_Scheme_Therapy_Line);
         A500BR_Scheme_Therapy_Line_Code = GXt_char1;
         n500BR_Scheme_Therapy_Line_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A500BR_Scheme_Therapy_Line_Code", A500BR_Scheme_Therapy_Line_Code);
      }

      protected void BeforeDelete1239( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete1239( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate1239( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes1239( )
      {
         edtBR_Scheme_Chem_Regimens_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Scheme_Chem_Regimens_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Scheme_Chem_Regimens_Enabled), 5, 0)), true);
         dynBR_Scheme_Therapy_Line.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynBR_Scheme_Therapy_Line_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynBR_Scheme_Therapy_Line.Enabled), 5, 0)), true);
         edtavVline_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVline_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVline_Enabled), 5, 0)), true);
         edtBR_Scheme_Chem_Cycle_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Scheme_Chem_Cycle_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Scheme_Chem_Cycle_Enabled), 5, 0)), true);
         edtBR_Scheme_Chem_Detail_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Scheme_Chem_Detail_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Scheme_Chem_Detail_Enabled), 5, 0)), true);
         edtBR_SchemeID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_SchemeID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_SchemeID_Enabled), 5, 0)), true);
         edtBR_EncounterID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_EncounterID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_EncounterID_Enabled), 5, 0)), true);
      }

      protected void send_integrity_lvl_hashes1239( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues120( )
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
         context.AddJavascriptSource("gxcfg.js", "?202022711575859", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_scheme.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7BR_SchemeID)+"\">") ;
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
         forbiddenHiddens = "hsh" + "BR_Scheme";
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A327BR_SchemeID), "ZZZZZZZZZZZZZZZZZZ");
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( AV18tCurrentCode, ""));
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV13Insert_BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ");
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("br_scheme:[SendSecurityCheck value for]"+"BR_SchemeID:"+context.localUtil.Format( (decimal)(A327BR_SchemeID), "ZZZZZZZZZZZZZZZZZZ"));
         GXUtil.WriteLog("br_scheme:[SendSecurityCheck value for]"+"tCurrentCode:"+StringUtil.RTrim( context.localUtil.Format( AV18tCurrentCode, "")));
         GXUtil.WriteLog("br_scheme:[SendSecurityCheck value for]"+"Insert_BR_EncounterID:"+context.localUtil.Format( (decimal)(AV13Insert_BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ"));
         GXUtil.WriteLog("br_scheme:[SendSecurityCheck value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z327BR_SchemeID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z327BR_SchemeID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z500BR_Scheme_Therapy_Line_Code", Z500BR_Scheme_Therapy_Line_Code);
         GxWebStd.gx_hidden_field( context, "Z328BR_Scheme_Chem_Regimens", Z328BR_Scheme_Chem_Regimens);
         GxWebStd.gx_hidden_field( context, "Z329BR_Scheme_Therapy_Line", Z329BR_Scheme_Therapy_Line);
         GxWebStd.gx_hidden_field( context, "Z330BR_Scheme_Chem_Cycle", StringUtil.LTrim( StringUtil.NToC( Z330BR_Scheme_Chem_Cycle, 15, 5, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z331BR_Scheme_Chem_Detail", Z331BR_Scheme_Chem_Detail);
         GxWebStd.gx_hidden_field( context, "Z19BR_EncounterID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z19BR_EncounterID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_Mode", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GxWebStd.gx_hidden_field( context, "N19BR_EncounterID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A19BR_EncounterID), 18, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vTRNCONTEXT", AV11TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vTRNCONTEXT", AV11TrnContext);
         }
         GxWebStd.gx_hidden_field( context, "vBR_SCHEMEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7BR_SchemeID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vBR_SCHEMEID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7BR_SchemeID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, "vINSERT_BR_ENCOUNTERID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13Insert_BR_EncounterID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "BR_SCHEME_THERAPY_LINE_CODE", A500BR_Scheme_Therapy_Line_Code);
         GxWebStd.gx_hidden_field( context, "vTCURRENTCODE", AV18tCurrentCode);
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
         return formatLink("br_scheme.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7BR_SchemeID) ;
      }

      public override String GetPgmname( )
      {
         return "BR_Scheme" ;
      }

      public override String GetPgmdesc( )
      {
         return "Data Mgmt Portal - RAAP" ;
      }

      protected void InitializeNonKey1239( )
      {
         A19BR_EncounterID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
         AV16vline = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16vline", AV16vline);
         A500BR_Scheme_Therapy_Line_Code = "";
         n500BR_Scheme_Therapy_Line_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A500BR_Scheme_Therapy_Line_Code", A500BR_Scheme_Therapy_Line_Code);
         A328BR_Scheme_Chem_Regimens = "";
         n328BR_Scheme_Chem_Regimens = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A328BR_Scheme_Chem_Regimens", A328BR_Scheme_Chem_Regimens);
         n328BR_Scheme_Chem_Regimens = (String.IsNullOrEmpty(StringUtil.RTrim( A328BR_Scheme_Chem_Regimens)) ? true : false);
         A329BR_Scheme_Therapy_Line = "";
         n329BR_Scheme_Therapy_Line = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A329BR_Scheme_Therapy_Line", A329BR_Scheme_Therapy_Line);
         n329BR_Scheme_Therapy_Line = (String.IsNullOrEmpty(StringUtil.RTrim( A329BR_Scheme_Therapy_Line)) ? true : false);
         A330BR_Scheme_Chem_Cycle = 0;
         n330BR_Scheme_Chem_Cycle = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A330BR_Scheme_Chem_Cycle", StringUtil.LTrim( StringUtil.Str( A330BR_Scheme_Chem_Cycle, 15, 5)));
         n330BR_Scheme_Chem_Cycle = ((Convert.ToDecimal(0)==A330BR_Scheme_Chem_Cycle) ? true : false);
         A331BR_Scheme_Chem_Detail = "";
         n331BR_Scheme_Chem_Detail = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A331BR_Scheme_Chem_Detail", A331BR_Scheme_Chem_Detail);
         n331BR_Scheme_Chem_Detail = (String.IsNullOrEmpty(StringUtil.RTrim( A331BR_Scheme_Chem_Detail)) ? true : false);
         Z500BR_Scheme_Therapy_Line_Code = "";
         Z328BR_Scheme_Chem_Regimens = "";
         Z329BR_Scheme_Therapy_Line = "";
         Z330BR_Scheme_Chem_Cycle = 0;
         Z331BR_Scheme_Chem_Detail = "";
         Z19BR_EncounterID = 0;
      }

      protected void InitAll1239( )
      {
         A327BR_SchemeID = 0;
         n327BR_SchemeID = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A327BR_SchemeID", StringUtil.LTrim( StringUtil.Str( (decimal)(A327BR_SchemeID), 18, 0)));
         InitializeNonKey1239( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202022711575884", true);
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
         context.AddJavascriptSource("br_scheme.js", "?202022711575885", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         lblTextblockbr_scheme_chem_regimens_Internalname = "TEXTBLOCKBR_SCHEME_CHEM_REGIMENS";
         edtBR_Scheme_Chem_Regimens_Internalname = "BR_SCHEME_CHEM_REGIMENS";
         divUnnamedtablebr_scheme_chem_regimens_Internalname = "UNNAMEDTABLEBR_SCHEME_CHEM_REGIMENS";
         lblTextblockbr_scheme_therapy_line_Internalname = "TEXTBLOCKBR_SCHEME_THERAPY_LINE";
         dynBR_Scheme_Therapy_Line_Internalname = "BR_SCHEME_THERAPY_LINE";
         edtavVline_Internalname = "vVLINE";
         cellVline_cell_Internalname = "VLINE_CELL";
         tblTablemergedbr_scheme_therapy_line_Internalname = "TABLEMERGEDBR_SCHEME_THERAPY_LINE";
         divTablesplittedbr_scheme_therapy_line_Internalname = "TABLESPLITTEDBR_SCHEME_THERAPY_LINE";
         lblTextblockbr_scheme_chem_cycle_Internalname = "TEXTBLOCKBR_SCHEME_CHEM_CYCLE";
         edtBR_Scheme_Chem_Cycle_Internalname = "BR_SCHEME_CHEM_CYCLE";
         divUnnamedtablebr_scheme_chem_cycle_Internalname = "UNNAMEDTABLEBR_SCHEME_CHEM_CYCLE";
         lblTextblockbr_scheme_chem_detail_Internalname = "TEXTBLOCKBR_SCHEME_CHEM_DETAIL";
         edtBR_Scheme_Chem_Detail_Internalname = "BR_SCHEME_CHEM_DETAIL";
         divUnnamedtablebr_scheme_chem_detail_Internalname = "UNNAMEDTABLEBR_SCHEME_CHEM_DETAIL";
         divTableattributes_Internalname = "TABLEATTRIBUTES";
         divLayout_tableattributes_Internalname = "LAYOUT_TABLEATTRIBUTES";
         Dvpanel_tableattributes_Internalname = "DVPANEL_TABLEATTRIBUTES";
         divHtml_dvpanel_tableattributes_Internalname = "HTML_DVPANEL_TABLEATTRIBUTES";
         divTablecontent_Internalname = "TABLECONTENT";
         bttBtntrn_enter_Internalname = "BTNTRN_ENTER";
         bttBtntrn_cancel_Internalname = "BTNTRN_CANCEL";
         bttBtntrn_delete_Internalname = "BTNTRN_DELETE";
         divTablemain_Internalname = "TABLEMAIN";
         edtBR_SchemeID_Internalname = "BR_SCHEMEID";
         edtBR_EncounterID_Internalname = "BR_ENCOUNTERID";
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
         edtavVline_Jsonclick = "";
         edtavVline_Enabled = 1;
         edtavVline_Visible = 1;
         cellVline_cell_Class = "";
         dynBR_Scheme_Therapy_Line_Jsonclick = "";
         dynBR_Scheme_Therapy_Line.Enabled = 1;
         edtBR_EncounterID_Jsonclick = "";
         edtBR_EncounterID_Enabled = 1;
         edtBR_EncounterID_Visible = 1;
         edtBR_SchemeID_Jsonclick = "";
         edtBR_SchemeID_Enabled = 0;
         edtBR_SchemeID_Visible = 1;
         bttBtntrn_delete_Enabled = 0;
         bttBtntrn_delete_Visible = 1;
         bttBtntrn_cancel_Visible = 1;
         bttBtntrn_enter_Enabled = 1;
         bttBtntrn_enter_Visible = 1;
         edtBR_Scheme_Chem_Detail_Enabled = 1;
         edtBR_Scheme_Chem_Cycle_Jsonclick = "";
         edtBR_Scheme_Chem_Cycle_Enabled = 1;
         edtBR_Scheme_Chem_Regimens_Jsonclick = "";
         edtBR_Scheme_Chem_Regimens_Enabled = 1;
         Dvpanel_tableattributes_Autoscroll = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Iconposition = "left";
         Dvpanel_tableattributes_Showcollapseicon = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsed = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsible = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Title = "化疗方案";
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

      protected void GXDLABR_SCHEME_THERAPY_LINE1239( String AV18tCurrentCode )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLABR_SCHEME_THERAPY_LINE_data1239( AV18tCurrentCode) ;
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

      protected void GXABR_SCHEME_THERAPY_LINE_html1239( String AV18tCurrentCode )
      {
         String gxdynajaxvalue ;
         GXDLABR_SCHEME_THERAPY_LINE_data1239( AV18tCurrentCode) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynBR_Scheme_Therapy_Line.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex));
            dynBR_Scheme_Therapy_Line.addItem(gxdynajaxvalue, ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLABR_SCHEME_THERAPY_LINE_data1239( String AV18tCurrentCode )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add("");
         gxdynajaxctrldescr.Add("(请选择)");
         /* Using cursor T001215 */
         pr_default.execute(13, new Object[] {AV18tCurrentCode});
         while ( (pr_default.getStatus(13) != 101) )
         {
            gxdynajaxctrlcodr.Add(T001215_A168XT_DefineCodeName[0]);
            gxdynajaxctrldescr.Add(T001215_A168XT_DefineCodeName[0]);
            pr_default.readNext(13);
         }
         pr_default.close(13);
      }

      protected void GX9ASABR_SCHEME_THERAPY_LINE_CODE1239( String A329BR_Scheme_Therapy_Line )
      {
         GXt_char1 = A500BR_Scheme_Therapy_Line_Code;
         new zutil_findtargetcode(context ).execute(  27,  A329BR_Scheme_Therapy_Line, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A329BR_Scheme_Therapy_Line", A329BR_Scheme_Therapy_Line);
         A500BR_Scheme_Therapy_Line_Code = GXt_char1;
         n500BR_Scheme_Therapy_Line_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A500BR_Scheme_Therapy_Line_Code", A500BR_Scheme_Therapy_Line_Code);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A500BR_Scheme_Therapy_Line_Code)+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GX10ASABR_SCHEME_THERAPY_LINE_CODE1239( String A329BR_Scheme_Therapy_Line )
      {
         GXt_char1 = A500BR_Scheme_Therapy_Line_Code;
         new zutil_findtargetcode(context ).execute(  27,  A329BR_Scheme_Therapy_Line, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A329BR_Scheme_Therapy_Line", A329BR_Scheme_Therapy_Line);
         A500BR_Scheme_Therapy_Line_Code = GXt_char1;
         n500BR_Scheme_Therapy_Line_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A500BR_Scheme_Therapy_Line_Code", A500BR_Scheme_Therapy_Line_Code);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A500BR_Scheme_Therapy_Line_Code)+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void XC_16_1239( )
      {
         new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)),  "就诊信息",  StringUtil.Trim( StringUtil.Str( (decimal)(A327BR_SchemeID), 18, 0)),  "化疗方案",  "Create",  1) ;
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

      protected void XC_17_1239( )
      {
         new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)),  "就诊信息",  StringUtil.Trim( StringUtil.Str( (decimal)(A327BR_SchemeID), 18, 0)),  "化疗方案",  "Update",  1) ;
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
         dynBR_Scheme_Therapy_Line.Name = "BR_SCHEME_THERAPY_LINE";
         dynBR_Scheme_Therapy_Line.WebTags = "";
         /* End function init_web_controls */
      }

      public void Valid_Br_encounterid( long GX_Parm1 )
      {
         A19BR_EncounterID = GX_Parm1;
         /* Using cursor T001216 */
         pr_default.execute(14, new Object[] {A19BR_EncounterID});
         if ( (pr_default.getStatus(14) == 101) )
         {
            GX_msglist.addItem("不匹配' T15'", "ForeignKeyNotFound", 1, "BR_ENCOUNTERID");
            AnyError = 1;
            GX_FocusControl = edtBR_EncounterID_Internalname;
         }
         pr_default.close(14);
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
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7BR_SchemeID',fld:'vBR_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7BR_SchemeID',fld:'vBR_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'A327BR_SchemeID',fld:'BR_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'AV13Insert_BR_EncounterID',fld:'vINSERT_BR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("AFTER TRN","{handler:'E12122',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV11TrnContext',fld:'vTRNCONTEXT',pic:''},{av:'A327BR_SchemeID',fld:'BR_SCHEMEID',pic:'ZZZZZZZZZZZZZZZZZZ'}]");
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
         pr_default.close(14);
      }

      public override void initialize( )
      {
         sPrefix = "";
         wcpOGx_mode = "";
         Z500BR_Scheme_Therapy_Line_Code = "";
         Z328BR_Scheme_Chem_Regimens = "";
         Z329BR_Scheme_Therapy_Line = "";
         Z331BR_Scheme_Chem_Detail = "";
         scmdbuf = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV18tCurrentCode = "";
         A329BR_Scheme_Therapy_Line = "";
         GXKey = "";
         PreviousTooltip = "";
         PreviousCaption = "";
         Form = new GXWebForm();
         GX_FocusControl = "";
         ClassString = "";
         StyleString = "";
         ucDvpanel_tableattributes = new GXUserControl();
         lblTextblockbr_scheme_chem_regimens_Jsonclick = "";
         TempTags = "";
         A328BR_Scheme_Chem_Regimens = "";
         lblTextblockbr_scheme_therapy_line_Jsonclick = "";
         lblTextblockbr_scheme_chem_cycle_Jsonclick = "";
         lblTextblockbr_scheme_chem_detail_Jsonclick = "";
         A331BR_Scheme_Chem_Detail = "";
         bttBtntrn_enter_Jsonclick = "";
         bttBtntrn_cancel_Jsonclick = "";
         bttBtntrn_delete_Jsonclick = "";
         sStyleString = "";
         AV16vline = "";
         A500BR_Scheme_Therapy_Line_Code = "";
         AV19Pgmname = "";
         Dvpanel_tableattributes_Objectcall = "";
         Dvpanel_tableattributes_Class = "";
         Dvpanel_tableattributes_Height = "";
         forbiddenHiddens = "";
         hsh = "";
         sMode39 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV8WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV11TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV12WebSession = context.GetSession();
         AV14TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         T00125_A327BR_SchemeID = new long[1] ;
         T00125_n327BR_SchemeID = new bool[] {false} ;
         T00125_A500BR_Scheme_Therapy_Line_Code = new String[] {""} ;
         T00125_n500BR_Scheme_Therapy_Line_Code = new bool[] {false} ;
         T00125_A328BR_Scheme_Chem_Regimens = new String[] {""} ;
         T00125_n328BR_Scheme_Chem_Regimens = new bool[] {false} ;
         T00125_A329BR_Scheme_Therapy_Line = new String[] {""} ;
         T00125_n329BR_Scheme_Therapy_Line = new bool[] {false} ;
         T00125_A330BR_Scheme_Chem_Cycle = new decimal[1] ;
         T00125_n330BR_Scheme_Chem_Cycle = new bool[] {false} ;
         T00125_A331BR_Scheme_Chem_Detail = new String[] {""} ;
         T00125_n331BR_Scheme_Chem_Detail = new bool[] {false} ;
         T00125_A19BR_EncounterID = new long[1] ;
         T00124_A19BR_EncounterID = new long[1] ;
         T00126_A19BR_EncounterID = new long[1] ;
         T00127_A327BR_SchemeID = new long[1] ;
         T00127_n327BR_SchemeID = new bool[] {false} ;
         T00123_A327BR_SchemeID = new long[1] ;
         T00123_n327BR_SchemeID = new bool[] {false} ;
         T00123_A500BR_Scheme_Therapy_Line_Code = new String[] {""} ;
         T00123_n500BR_Scheme_Therapy_Line_Code = new bool[] {false} ;
         T00123_A328BR_Scheme_Chem_Regimens = new String[] {""} ;
         T00123_n328BR_Scheme_Chem_Regimens = new bool[] {false} ;
         T00123_A329BR_Scheme_Therapy_Line = new String[] {""} ;
         T00123_n329BR_Scheme_Therapy_Line = new bool[] {false} ;
         T00123_A330BR_Scheme_Chem_Cycle = new decimal[1] ;
         T00123_n330BR_Scheme_Chem_Cycle = new bool[] {false} ;
         T00123_A331BR_Scheme_Chem_Detail = new String[] {""} ;
         T00123_n331BR_Scheme_Chem_Detail = new bool[] {false} ;
         T00123_A19BR_EncounterID = new long[1] ;
         T00128_A327BR_SchemeID = new long[1] ;
         T00128_n327BR_SchemeID = new bool[] {false} ;
         T00129_A327BR_SchemeID = new long[1] ;
         T00129_n327BR_SchemeID = new bool[] {false} ;
         T00122_A327BR_SchemeID = new long[1] ;
         T00122_n327BR_SchemeID = new bool[] {false} ;
         T00122_A500BR_Scheme_Therapy_Line_Code = new String[] {""} ;
         T00122_n500BR_Scheme_Therapy_Line_Code = new bool[] {false} ;
         T00122_A328BR_Scheme_Chem_Regimens = new String[] {""} ;
         T00122_n328BR_Scheme_Chem_Regimens = new bool[] {false} ;
         T00122_A329BR_Scheme_Therapy_Line = new String[] {""} ;
         T00122_n329BR_Scheme_Therapy_Line = new bool[] {false} ;
         T00122_A330BR_Scheme_Chem_Cycle = new decimal[1] ;
         T00122_n330BR_Scheme_Chem_Cycle = new bool[] {false} ;
         T00122_A331BR_Scheme_Chem_Detail = new String[] {""} ;
         T00122_n331BR_Scheme_Chem_Detail = new bool[] {false} ;
         T00122_A19BR_EncounterID = new long[1] ;
         T001210_A327BR_SchemeID = new long[1] ;
         T001210_n327BR_SchemeID = new bool[] {false} ;
         T001213_A332BR_Scheme_MedicationID = new long[1] ;
         T001214_A327BR_SchemeID = new long[1] ;
         T001214_n327BR_SchemeID = new bool[] {false} ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         gxdynajaxctrlcodr = new GeneXus.Utils.GxStringCollection();
         gxdynajaxctrldescr = new GeneXus.Utils.GxStringCollection();
         gxwrpcisep = "";
         T001215_A167XT_DefineCodeID = new long[1] ;
         T001215_A168XT_DefineCodeName = new String[] {""} ;
         T001215_n168XT_DefineCodeName = new bool[] {false} ;
         T001215_A165XT_DefindcodeTypeID = new long[1] ;
         T001215_A432XT_TenantCode = new String[] {""} ;
         T001215_n432XT_TenantCode = new bool[] {false} ;
         GXt_char1 = "";
         T001216_A19BR_EncounterID = new long[1] ;
         isValidOutput = new GxUnknownObjectCollection();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.br_scheme__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_scheme__default(),
            new Object[][] {
                new Object[] {
               T00122_A327BR_SchemeID, T00122_A500BR_Scheme_Therapy_Line_Code, T00122_n500BR_Scheme_Therapy_Line_Code, T00122_A328BR_Scheme_Chem_Regimens, T00122_n328BR_Scheme_Chem_Regimens, T00122_A329BR_Scheme_Therapy_Line, T00122_n329BR_Scheme_Therapy_Line, T00122_A330BR_Scheme_Chem_Cycle, T00122_n330BR_Scheme_Chem_Cycle, T00122_A331BR_Scheme_Chem_Detail,
               T00122_n331BR_Scheme_Chem_Detail, T00122_A19BR_EncounterID
               }
               , new Object[] {
               T00123_A327BR_SchemeID, T00123_A500BR_Scheme_Therapy_Line_Code, T00123_n500BR_Scheme_Therapy_Line_Code, T00123_A328BR_Scheme_Chem_Regimens, T00123_n328BR_Scheme_Chem_Regimens, T00123_A329BR_Scheme_Therapy_Line, T00123_n329BR_Scheme_Therapy_Line, T00123_A330BR_Scheme_Chem_Cycle, T00123_n330BR_Scheme_Chem_Cycle, T00123_A331BR_Scheme_Chem_Detail,
               T00123_n331BR_Scheme_Chem_Detail, T00123_A19BR_EncounterID
               }
               , new Object[] {
               T00124_A19BR_EncounterID
               }
               , new Object[] {
               T00125_A327BR_SchemeID, T00125_A500BR_Scheme_Therapy_Line_Code, T00125_n500BR_Scheme_Therapy_Line_Code, T00125_A328BR_Scheme_Chem_Regimens, T00125_n328BR_Scheme_Chem_Regimens, T00125_A329BR_Scheme_Therapy_Line, T00125_n329BR_Scheme_Therapy_Line, T00125_A330BR_Scheme_Chem_Cycle, T00125_n330BR_Scheme_Chem_Cycle, T00125_A331BR_Scheme_Chem_Detail,
               T00125_n331BR_Scheme_Chem_Detail, T00125_A19BR_EncounterID
               }
               , new Object[] {
               T00126_A19BR_EncounterID
               }
               , new Object[] {
               T00127_A327BR_SchemeID
               }
               , new Object[] {
               T00128_A327BR_SchemeID
               }
               , new Object[] {
               T00129_A327BR_SchemeID
               }
               , new Object[] {
               T001210_A327BR_SchemeID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T001213_A332BR_Scheme_MedicationID
               }
               , new Object[] {
               T001214_A327BR_SchemeID
               }
               , new Object[] {
               T001215_A167XT_DefineCodeID, T001215_A168XT_DefineCodeName, T001215_n168XT_DefineCodeName, T001215_A165XT_DefindcodeTypeID, T001215_A432XT_TenantCode, T001215_n432XT_TenantCode
               }
               , new Object[] {
               T001216_A19BR_EncounterID
               }
            }
         );
         AV19Pgmname = "BR_Scheme";
      }

      private short GxWebError ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short RcdFound39 ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int trnEnded ;
      private int edtBR_Scheme_Chem_Regimens_Enabled ;
      private int edtBR_Scheme_Chem_Cycle_Enabled ;
      private int edtBR_Scheme_Chem_Detail_Enabled ;
      private int bttBtntrn_enter_Visible ;
      private int bttBtntrn_enter_Enabled ;
      private int bttBtntrn_cancel_Visible ;
      private int bttBtntrn_delete_Visible ;
      private int bttBtntrn_delete_Enabled ;
      private int edtBR_SchemeID_Enabled ;
      private int edtBR_SchemeID_Visible ;
      private int edtBR_EncounterID_Visible ;
      private int edtBR_EncounterID_Enabled ;
      private int edtavVline_Visible ;
      private int edtavVline_Enabled ;
      private int AV20GXV1 ;
      private int idxLst ;
      private int gxdynajaxindex ;
      private long wcpOAV7BR_SchemeID ;
      private long Z327BR_SchemeID ;
      private long Z19BR_EncounterID ;
      private long N19BR_EncounterID ;
      private long A19BR_EncounterID ;
      private long AV7BR_SchemeID ;
      private long A327BR_SchemeID ;
      private long AV13Insert_BR_EncounterID ;
      private decimal Z330BR_Scheme_Chem_Cycle ;
      private decimal A330BR_Scheme_Chem_Cycle ;
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
      private String edtBR_Scheme_Chem_Regimens_Internalname ;
      private String dynBR_Scheme_Therapy_Line_Internalname ;
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
      private String divUnnamedtablebr_scheme_chem_regimens_Internalname ;
      private String lblTextblockbr_scheme_chem_regimens_Internalname ;
      private String lblTextblockbr_scheme_chem_regimens_Jsonclick ;
      private String TempTags ;
      private String edtBR_Scheme_Chem_Regimens_Jsonclick ;
      private String divTablesplittedbr_scheme_therapy_line_Internalname ;
      private String lblTextblockbr_scheme_therapy_line_Internalname ;
      private String lblTextblockbr_scheme_therapy_line_Jsonclick ;
      private String divUnnamedtablebr_scheme_chem_cycle_Internalname ;
      private String lblTextblockbr_scheme_chem_cycle_Internalname ;
      private String lblTextblockbr_scheme_chem_cycle_Jsonclick ;
      private String edtBR_Scheme_Chem_Cycle_Internalname ;
      private String edtBR_Scheme_Chem_Cycle_Jsonclick ;
      private String divUnnamedtablebr_scheme_chem_detail_Internalname ;
      private String lblTextblockbr_scheme_chem_detail_Internalname ;
      private String lblTextblockbr_scheme_chem_detail_Jsonclick ;
      private String edtBR_Scheme_Chem_Detail_Internalname ;
      private String bttBtntrn_enter_Internalname ;
      private String bttBtntrn_enter_Jsonclick ;
      private String bttBtntrn_cancel_Internalname ;
      private String bttBtntrn_cancel_Jsonclick ;
      private String bttBtntrn_delete_Internalname ;
      private String bttBtntrn_delete_Jsonclick ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String edtBR_SchemeID_Internalname ;
      private String edtBR_SchemeID_Jsonclick ;
      private String edtBR_EncounterID_Internalname ;
      private String edtBR_EncounterID_Jsonclick ;
      private String sStyleString ;
      private String tblTablemergedbr_scheme_therapy_line_Internalname ;
      private String dynBR_Scheme_Therapy_Line_Jsonclick ;
      private String cellVline_cell_Internalname ;
      private String cellVline_cell_Class ;
      private String edtavVline_Internalname ;
      private String edtavVline_Jsonclick ;
      private String AV19Pgmname ;
      private String Dvpanel_tableattributes_Objectcall ;
      private String Dvpanel_tableattributes_Class ;
      private String Dvpanel_tableattributes_Height ;
      private String forbiddenHiddens ;
      private String hsh ;
      private String sMode39 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String gxwrpcisep ;
      private String GXt_char1 ;
      private bool entryPointCalled ;
      private bool n329BR_Scheme_Therapy_Line ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool Dvpanel_tableattributes_Autowidth ;
      private bool Dvpanel_tableattributes_Autoheight ;
      private bool Dvpanel_tableattributes_Collapsible ;
      private bool Dvpanel_tableattributes_Collapsed ;
      private bool Dvpanel_tableattributes_Showcollapseicon ;
      private bool Dvpanel_tableattributes_Autoscroll ;
      private bool n328BR_Scheme_Chem_Regimens ;
      private bool n330BR_Scheme_Chem_Cycle ;
      private bool n331BR_Scheme_Chem_Detail ;
      private bool n327BR_SchemeID ;
      private bool n500BR_Scheme_Therapy_Line_Code ;
      private bool Dvpanel_tableattributes_Enabled ;
      private bool Dvpanel_tableattributes_Showheader ;
      private bool Dvpanel_tableattributes_Visible ;
      private bool AV9IsAuthorized ;
      private bool returnInSub ;
      private bool AV17TempBoolean ;
      private bool GXt_boolean2 ;
      private bool Gx_longc ;
      private bool gxdyncontrolsrefreshing ;
      private String Z500BR_Scheme_Therapy_Line_Code ;
      private String Z328BR_Scheme_Chem_Regimens ;
      private String Z329BR_Scheme_Therapy_Line ;
      private String Z331BR_Scheme_Chem_Detail ;
      private String AV18tCurrentCode ;
      private String A329BR_Scheme_Therapy_Line ;
      private String A328BR_Scheme_Chem_Regimens ;
      private String A331BR_Scheme_Chem_Detail ;
      private String AV16vline ;
      private String A500BR_Scheme_Therapy_Line_Code ;
      private IGxSession AV12WebSession ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrlcodr ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrldescr ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXUserControl ucDvpanel_tableattributes ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private GXCombobox dynBR_Scheme_Therapy_Line ;
      private IDataStoreProvider pr_default ;
      private long[] T00125_A327BR_SchemeID ;
      private bool[] T00125_n327BR_SchemeID ;
      private String[] T00125_A500BR_Scheme_Therapy_Line_Code ;
      private bool[] T00125_n500BR_Scheme_Therapy_Line_Code ;
      private String[] T00125_A328BR_Scheme_Chem_Regimens ;
      private bool[] T00125_n328BR_Scheme_Chem_Regimens ;
      private String[] T00125_A329BR_Scheme_Therapy_Line ;
      private bool[] T00125_n329BR_Scheme_Therapy_Line ;
      private decimal[] T00125_A330BR_Scheme_Chem_Cycle ;
      private bool[] T00125_n330BR_Scheme_Chem_Cycle ;
      private String[] T00125_A331BR_Scheme_Chem_Detail ;
      private bool[] T00125_n331BR_Scheme_Chem_Detail ;
      private long[] T00125_A19BR_EncounterID ;
      private long[] T00124_A19BR_EncounterID ;
      private long[] T00126_A19BR_EncounterID ;
      private long[] T00127_A327BR_SchemeID ;
      private bool[] T00127_n327BR_SchemeID ;
      private long[] T00123_A327BR_SchemeID ;
      private bool[] T00123_n327BR_SchemeID ;
      private String[] T00123_A500BR_Scheme_Therapy_Line_Code ;
      private bool[] T00123_n500BR_Scheme_Therapy_Line_Code ;
      private String[] T00123_A328BR_Scheme_Chem_Regimens ;
      private bool[] T00123_n328BR_Scheme_Chem_Regimens ;
      private String[] T00123_A329BR_Scheme_Therapy_Line ;
      private bool[] T00123_n329BR_Scheme_Therapy_Line ;
      private decimal[] T00123_A330BR_Scheme_Chem_Cycle ;
      private bool[] T00123_n330BR_Scheme_Chem_Cycle ;
      private String[] T00123_A331BR_Scheme_Chem_Detail ;
      private bool[] T00123_n331BR_Scheme_Chem_Detail ;
      private long[] T00123_A19BR_EncounterID ;
      private long[] T00128_A327BR_SchemeID ;
      private bool[] T00128_n327BR_SchemeID ;
      private long[] T00129_A327BR_SchemeID ;
      private bool[] T00129_n327BR_SchemeID ;
      private long[] T00122_A327BR_SchemeID ;
      private bool[] T00122_n327BR_SchemeID ;
      private String[] T00122_A500BR_Scheme_Therapy_Line_Code ;
      private bool[] T00122_n500BR_Scheme_Therapy_Line_Code ;
      private String[] T00122_A328BR_Scheme_Chem_Regimens ;
      private bool[] T00122_n328BR_Scheme_Chem_Regimens ;
      private String[] T00122_A329BR_Scheme_Therapy_Line ;
      private bool[] T00122_n329BR_Scheme_Therapy_Line ;
      private decimal[] T00122_A330BR_Scheme_Chem_Cycle ;
      private bool[] T00122_n330BR_Scheme_Chem_Cycle ;
      private String[] T00122_A331BR_Scheme_Chem_Detail ;
      private bool[] T00122_n331BR_Scheme_Chem_Detail ;
      private long[] T00122_A19BR_EncounterID ;
      private long[] T001210_A327BR_SchemeID ;
      private bool[] T001210_n327BR_SchemeID ;
      private long[] T001213_A332BR_Scheme_MedicationID ;
      private long[] T001214_A327BR_SchemeID ;
      private bool[] T001214_n327BR_SchemeID ;
      private long[] T001215_A167XT_DefineCodeID ;
      private String[] T001215_A168XT_DefineCodeName ;
      private bool[] T001215_n168XT_DefineCodeName ;
      private long[] T001215_A165XT_DefindcodeTypeID ;
      private String[] T001215_A432XT_TenantCode ;
      private bool[] T001215_n432XT_TenantCode ;
      private long[] T001216_A19BR_EncounterID ;
      private IDataStoreProvider pr_datastore1 ;
      private GXWebForm Form ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV8WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV11TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute AV14TrnContextAtt ;
   }

   public class br_scheme__datastore1 : DataStoreHelperBase, IDataStoreHelper
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

 public class br_scheme__default : DataStoreHelperBase, IDataStoreHelper
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
       ,new ForEachCursor(def[13])
       ,new ForEachCursor(def[14])
     };
  }

  private static CursorDef[] def;
  private void cursorDefinitions( )
  {
     if ( def == null )
     {
        Object[] prmT00125 ;
        prmT00125 = new Object[] {
        new Object[] {"@BR_SchemeID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00124 ;
        prmT00124 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00126 ;
        prmT00126 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00127 ;
        prmT00127 = new Object[] {
        new Object[] {"@BR_SchemeID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00123 ;
        prmT00123 = new Object[] {
        new Object[] {"@BR_SchemeID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00128 ;
        prmT00128 = new Object[] {
        new Object[] {"@BR_SchemeID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00129 ;
        prmT00129 = new Object[] {
        new Object[] {"@BR_SchemeID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT00122 ;
        prmT00122 = new Object[] {
        new Object[] {"@BR_SchemeID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT001210 ;
        prmT001210 = new Object[] {
        new Object[] {"@BR_Scheme_Therapy_Line_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Scheme_Chem_Regimens",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Scheme_Therapy_Line",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Scheme_Chem_Cycle",SqlDbType.Decimal,15,5} ,
        new Object[] {"@BR_Scheme_Chem_Detail",SqlDbType.NVarChar,4000,0} ,
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT001211 ;
        prmT001211 = new Object[] {
        new Object[] {"@BR_Scheme_Therapy_Line_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Scheme_Chem_Regimens",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Scheme_Therapy_Line",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Scheme_Chem_Cycle",SqlDbType.Decimal,15,5} ,
        new Object[] {"@BR_Scheme_Chem_Detail",SqlDbType.NVarChar,4000,0} ,
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@BR_SchemeID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT001212 ;
        prmT001212 = new Object[] {
        new Object[] {"@BR_SchemeID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT001213 ;
        prmT001213 = new Object[] {
        new Object[] {"@BR_SchemeID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT001214 ;
        prmT001214 = new Object[] {
        } ;
        Object[] prmT001215 ;
        prmT001215 = new Object[] {
        new Object[] {"@AV18tCurrentCode",SqlDbType.NVarChar,40,0}
        } ;
        Object[] prmT001216 ;
        prmT001216 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("T00122", "SELECT [BR_SchemeID], [BR_Scheme_Therapy_Line_Code], [BR_Scheme_Chem_Regimens], [BR_Scheme_Therapy_Line], [BR_Scheme_Chem_Cycle], [BR_Scheme_Chem_Detail], [BR_EncounterID] FROM [BR_Scheme] WITH (UPDLOCK) WHERE [BR_SchemeID] = @BR_SchemeID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00122,1,0,true,false )
           ,new CursorDef("T00123", "SELECT [BR_SchemeID], [BR_Scheme_Therapy_Line_Code], [BR_Scheme_Chem_Regimens], [BR_Scheme_Therapy_Line], [BR_Scheme_Chem_Cycle], [BR_Scheme_Chem_Detail], [BR_EncounterID] FROM [BR_Scheme] WITH (NOLOCK) WHERE [BR_SchemeID] = @BR_SchemeID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00123,1,0,true,false )
           ,new CursorDef("T00124", "SELECT [BR_EncounterID] FROM [BR_Encounter] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00124,1,0,true,false )
           ,new CursorDef("T00125", "SELECT TM1.[BR_SchemeID], TM1.[BR_Scheme_Therapy_Line_Code], TM1.[BR_Scheme_Chem_Regimens], TM1.[BR_Scheme_Therapy_Line], TM1.[BR_Scheme_Chem_Cycle], TM1.[BR_Scheme_Chem_Detail], TM1.[BR_EncounterID] FROM [BR_Scheme] TM1 WITH (NOLOCK) WHERE TM1.[BR_SchemeID] = @BR_SchemeID ORDER BY TM1.[BR_SchemeID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00125,100,0,true,false )
           ,new CursorDef("T00126", "SELECT [BR_EncounterID] FROM [BR_Encounter] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmT00126,1,0,true,false )
           ,new CursorDef("T00127", "SELECT [BR_SchemeID] FROM [BR_Scheme] WITH (NOLOCK) WHERE [BR_SchemeID] = @BR_SchemeID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00127,1,0,true,false )
           ,new CursorDef("T00128", "SELECT TOP 1 [BR_SchemeID] FROM [BR_Scheme] WITH (NOLOCK) WHERE ( [BR_SchemeID] > @BR_SchemeID) ORDER BY [BR_SchemeID]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00128,1,0,true,true )
           ,new CursorDef("T00129", "SELECT TOP 1 [BR_SchemeID] FROM [BR_Scheme] WITH (NOLOCK) WHERE ( [BR_SchemeID] < @BR_SchemeID) ORDER BY [BR_SchemeID] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00129,1,0,true,true )
           ,new CursorDef("T001210", "INSERT INTO [BR_Scheme]([BR_Scheme_Therapy_Line_Code], [BR_Scheme_Chem_Regimens], [BR_Scheme_Therapy_Line], [BR_Scheme_Chem_Cycle], [BR_Scheme_Chem_Detail], [BR_EncounterID]) VALUES(@BR_Scheme_Therapy_Line_Code, @BR_Scheme_Chem_Regimens, @BR_Scheme_Therapy_Line, @BR_Scheme_Chem_Cycle, @BR_Scheme_Chem_Detail, @BR_EncounterID); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmT001210)
           ,new CursorDef("T001211", "UPDATE [BR_Scheme] SET [BR_Scheme_Therapy_Line_Code]=@BR_Scheme_Therapy_Line_Code, [BR_Scheme_Chem_Regimens]=@BR_Scheme_Chem_Regimens, [BR_Scheme_Therapy_Line]=@BR_Scheme_Therapy_Line, [BR_Scheme_Chem_Cycle]=@BR_Scheme_Chem_Cycle, [BR_Scheme_Chem_Detail]=@BR_Scheme_Chem_Detail, [BR_EncounterID]=@BR_EncounterID  WHERE [BR_SchemeID] = @BR_SchemeID", GxErrorMask.GX_NOMASK,prmT001211)
           ,new CursorDef("T001212", "DELETE FROM [BR_Scheme]  WHERE [BR_SchemeID] = @BR_SchemeID", GxErrorMask.GX_NOMASK,prmT001212)
           ,new CursorDef("T001213", "SELECT TOP 1 [BR_Scheme_MedicationID] FROM [BR_Scheme_Medication] WITH (NOLOCK) WHERE [BR_SchemeID] = @BR_SchemeID ",true, GxErrorMask.GX_NOMASK, false, this,prmT001213,1,0,true,true )
           ,new CursorDef("T001214", "SELECT [BR_SchemeID] FROM [BR_Scheme] WITH (NOLOCK) ORDER BY [BR_SchemeID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT001214,100,0,true,false )
           ,new CursorDef("T001215", "SELECT [XT_DefineCodeID], [XT_DefineCodeName], [XT_DefindcodeTypeID], [XT_TenantCode] FROM [XT_DefineCode] WITH (NOLOCK) WHERE ([XT_DefindcodeTypeID] = 27) AND ([XT_TenantCode] = @AV18tCurrentCode) ",true, GxErrorMask.GX_NOMASK, false, this,prmT001215,0,0,true,false )
           ,new CursorDef("T001216", "SELECT [BR_EncounterID] FROM [BR_Encounter] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmT001216,1,0,true,false )
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
              ((decimal[]) buf[7])[0] = rslt.getDecimal(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((long[]) buf[11])[0] = rslt.getLong(7) ;
              return;
           case 1 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((decimal[]) buf[7])[0] = rslt.getDecimal(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((long[]) buf[11])[0] = rslt.getLong(7) ;
              return;
           case 2 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 3 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((decimal[]) buf[7])[0] = rslt.getDecimal(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((long[]) buf[11])[0] = rslt.getLong(7) ;
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
           case 13 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((long[]) buf[3])[0] = rslt.getLong(3) ;
              ((String[]) buf[4])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[5])[0] = rslt.wasNull(4);
              return;
           case 14 :
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
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
              }
              return;
           case 1 :
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
              }
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
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
              }
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
                 stmt.setNull( 4 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(4, (decimal)parms[7]);
              }
              if ( (bool)parms[8] )
              {
                 stmt.setNull( 5 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(5, (String)parms[9]);
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
                 stmt.setNull( 4 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(4, (decimal)parms[7]);
              }
              if ( (bool)parms[8] )
              {
                 stmt.setNull( 5 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(5, (String)parms[9]);
              }
              stmt.SetParameter(6, (long)parms[10]);
              if ( (bool)parms[11] )
              {
                 stmt.setNull( 7 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(7, (long)parms[12]);
              }
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
              return;
           case 13 :
              stmt.SetParameter(1, (String)parms[0]);
              return;
           case 14 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
     }
  }

}

}
