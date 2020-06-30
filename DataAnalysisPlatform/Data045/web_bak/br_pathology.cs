/*
               File: BR_Pathology
        Description: Data Mgmt Portal - RAAP
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:38:19.63
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
   public class br_pathology : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxJX_Action22") == 0 )
         {
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            XC_22_0Z36( ) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxJX_Action23") == 0 )
         {
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            XC_23_0Z36( ) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxJX_Action24") == 0 )
         {
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            XC_24_0Z36( ) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"BR_PATHOLOGYID_PAHOSP") == 0 )
         {
            AV16tCurrentCode = GetNextPar( );
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16tCurrentCode", AV16tCurrentCode);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GXDLABR_PATHOLOGYID_PAHOSP0Z36( AV16tCurrentCode) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel11"+"_"+"BR_PATHOLOGY_N_CODE") == 0 )
         {
            A315BR_Pathology_N = GetNextPar( );
            n315BR_Pathology_N = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A315BR_Pathology_N", A315BR_Pathology_N);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX11ASABR_PATHOLOGY_N_CODE0Z36( A315BR_Pathology_N) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel12"+"_"+"BR_PATHOLOGY_N_CODE") == 0 )
         {
            A315BR_Pathology_N = GetNextPar( );
            n315BR_Pathology_N = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A315BR_Pathology_N", A315BR_Pathology_N);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX12ASABR_PATHOLOGY_N_CODE0Z36( A315BR_Pathology_N) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel13"+"_"+"BR_PATHOLOGY_M_CODE") == 0 )
         {
            A318BR_Pathology_M = GetNextPar( );
            n318BR_Pathology_M = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A318BR_Pathology_M", A318BR_Pathology_M);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX13ASABR_PATHOLOGY_M_CODE0Z36( A318BR_Pathology_M) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel14"+"_"+"BR_PATHOLOGY_M_CODE") == 0 )
         {
            A318BR_Pathology_M = GetNextPar( );
            n318BR_Pathology_M = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A318BR_Pathology_M", A318BR_Pathology_M);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX14ASABR_PATHOLOGY_M_CODE0Z36( A318BR_Pathology_M) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel15"+"_"+"BR_PATHOLOGYID_PAHOSP_CODE") == 0 )
         {
            A239BR_PathologyID_PAHosp = GetNextPar( );
            n239BR_PathologyID_PAHosp = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A239BR_PathologyID_PAHosp", A239BR_PathologyID_PAHosp);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX15ASABR_PATHOLOGYID_PAHOSP_CODE0Z36( A239BR_PathologyID_PAHosp) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel16"+"_"+"BR_PATHOLOGYID_PAHOSP_CODE") == 0 )
         {
            A239BR_PathologyID_PAHosp = GetNextPar( );
            n239BR_PathologyID_PAHosp = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A239BR_PathologyID_PAHosp", A239BR_PathologyID_PAHosp);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX16ASABR_PATHOLOGYID_PAHOSP_CODE0Z36( A239BR_PathologyID_PAHosp) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_26") == 0 )
         {
            A19BR_EncounterID = (long)(NumberUtil.Val( GetNextPar( ), "."));
            n19BR_EncounterID = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_26( A19BR_EncounterID) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_27") == 0 )
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
            gxLoad_27( A85BR_Information_ID) ;
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
               AV7BR_PathologyID = (long)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7BR_PathologyID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7BR_PathologyID), 18, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vBR_PATHOLOGYID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7BR_PathologyID), "ZZZZZZZZZZZZZZZZZZ"), context));
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
         GX_FocusControl = edtBR_PathologyID_PADate_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("WorkWithPlusTheme");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public br_pathology( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_pathology( IGxContext context )
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
                           long aP1_BR_PathologyID )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV7BR_PathologyID = aP1_BR_PathologyID;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         dynBR_PathologyID_PAHosp = new GXCombobox();
         cmbBR_Pathology_N = new GXCombobox();
         cmbBR_Pathology_M = new GXCombobox();
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
         if ( dynBR_PathologyID_PAHosp.ItemCount > 0 )
         {
            A239BR_PathologyID_PAHosp = dynBR_PathologyID_PAHosp.getValidValue(A239BR_PathologyID_PAHosp);
            n239BR_PathologyID_PAHosp = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A239BR_PathologyID_PAHosp", A239BR_PathologyID_PAHosp);
         }
         if ( context.isAjaxRequest( ) )
         {
            dynBR_PathologyID_PAHosp.CurrentValue = StringUtil.RTrim( A239BR_PathologyID_PAHosp);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynBR_PathologyID_PAHosp_Internalname, "Values", dynBR_PathologyID_PAHosp.ToJavascriptSource(), true);
         }
         if ( cmbBR_Pathology_N.ItemCount > 0 )
         {
            A315BR_Pathology_N = cmbBR_Pathology_N.getValidValue(A315BR_Pathology_N);
            n315BR_Pathology_N = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A315BR_Pathology_N", A315BR_Pathology_N);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbBR_Pathology_N.CurrentValue = StringUtil.RTrim( A315BR_Pathology_N);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Pathology_N_Internalname, "Values", cmbBR_Pathology_N.ToJavascriptSource(), true);
         }
         if ( cmbBR_Pathology_M.ItemCount > 0 )
         {
            A318BR_Pathology_M = cmbBR_Pathology_M.getValidValue(A318BR_Pathology_M);
            n318BR_Pathology_M = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A318BR_Pathology_M", A318BR_Pathology_M);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbBR_Pathology_M.CurrentValue = StringUtil.RTrim( A318BR_Pathology_M);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Pathology_M_Internalname, "Values", cmbBR_Pathology_M.ToJavascriptSource(), true);
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
            GxWebStd.gx_div_start( context, divUnnamedtablebr_pathologyid_padate_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_pathologyid_padate_Internalname, "病理检查日期", "", "", lblTextblockbr_pathologyid_padate_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Pathology.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_PathologyID_PADate_Internalname, "病理检查日期", "col-sm-3 AttributeDateLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtBR_PathologyID_PADate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtBR_PathologyID_PADate_Internalname, context.localUtil.Format(A238BR_PathologyID_PADate, "9999/99/99"), context.localUtil.Format( A238BR_PathologyID_PADate, "9999/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',0,24,'chs',false,1);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,29);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_PathologyID_PADate_Jsonclick, 0, "AttributeDate", "", "", "", "", 1, edtBR_PathologyID_PADate_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "DM_Date", "right", false, "HLP_BR_Pathology.htm");
            GxWebStd.gx_bitmap( context, edtBR_PathologyID_PADate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtBR_PathologyID_PADate_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_Pathology.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 RequiredDataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_pathologyid_paage_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_pathologyid_paage_Internalname, "年龄", "", "", lblTextblockbr_pathologyid_paage_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Pathology.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_PathologyID_PAAge_Internalname, "年龄", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 37,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_PathologyID_PAAge_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A240BR_PathologyID_PAAge), 3, 0, ".", "")), ((edtBR_PathologyID_PAAge_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A240BR_PathologyID_PAAge), "ZZZ")) : context.localUtil.Format( (decimal)(A240BR_PathologyID_PAAge), "ZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,37);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_PathologyID_PAAge_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBR_PathologyID_PAAge_Enabled, 0, "number", "1", 3, "chr", 1, "row", 3, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Pathology.htm");
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
            GxWebStd.gx_div_start( context, divUnnamedtablebr_pathologyid_pahosp_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_pathologyid_pahosp_Internalname, "检查医院", "", "", lblTextblockbr_pathologyid_pahosp_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Pathology.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynBR_PathologyID_PAHosp_Internalname, "检查医院", "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynBR_PathologyID_PAHosp, dynBR_PathologyID_PAHosp_Internalname, StringUtil.RTrim( A239BR_PathologyID_PAHosp), 1, dynBR_PathologyID_PAHosp_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, dynBR_PathologyID_PAHosp.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,46);\"", "", true, "HLP_BR_Pathology.htm");
            dynBR_PathologyID_PAHosp.CurrentValue = StringUtil.RTrim( A239BR_PathologyID_PAHosp);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynBR_PathologyID_PAHosp_Internalname, "Values", (String)(dynBR_PathologyID_PAHosp.ToJavascriptSource()), true);
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
            GxWebStd.gx_div_start( context, divUnnamedtablebr_pathology_dia_name_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-2 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_pathology_dia_name_Internalname, "病理诊断名称", "", "", lblTextblockbr_pathology_dia_name_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Pathology.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-10", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Pathology_Dia_Name_Internalname, "病理诊断名称", "col-sm-3 AttributeLabel", 0, true);
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 55,'',false,'',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtBR_Pathology_Dia_Name_Internalname, A326BR_Pathology_Dia_Name, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,55);\"", 0, 1, edtBR_Pathology_Dia_Name_Enabled, 0, 80, "chr", 10, "row", StyleString, ClassString, "", "", "3000", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Pathology.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_pathologyid_paresult_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-2 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_pathologyid_paresult_Internalname, "病理描述", "", "", lblTextblockbr_pathologyid_paresult_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Pathology.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-10", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_PathologyID_PAResult_Internalname, "病理描述", "col-sm-3 AttributeLabel", 0, true);
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtBR_PathologyID_PAResult_Internalname, A242BR_PathologyID_PAResult, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,63);\"", 0, 1, edtBR_PathologyID_PAResult_Enabled, 0, 80, "chr", 10, "row", StyleString, ClassString, "", "", "9999", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Pathology.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
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
            GxWebStd.gx_div_start( context, divUnnamedtablebr_pathologyid_prepadia_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-2 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_pathologyid_prepadia_Internalname, "病理前诊断", "", "", lblTextblockbr_pathologyid_prepadia_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Pathology.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-10", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_PathologyID_PrePaDia_Internalname, "病理前诊断", "col-sm-3 AttributeLabel", 0, true);
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 72,'',false,'',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtBR_PathologyID_PrePaDia_Internalname, A241BR_PathologyID_PrePaDia, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,72);\"", 0, 1, edtBR_PathologyID_PrePaDia_Enabled, 0, 80, "chr", 10, "row", StyleString, ClassString, "", "", "4000", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Pathology.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_pathology_t_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_pathology_t_Internalname, "原发肿瘤分级", "", "", lblTextblockbr_pathology_t_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Pathology.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Pathology_T_Internalname, "原发肿瘤分级", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 80,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_Pathology_T_Internalname, StringUtil.LTrim( StringUtil.NToC( A314BR_Pathology_T, 15, 5, ".", "")), ((edtBR_Pathology_T_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A314BR_Pathology_T, "ZZZZZZZZZ.ZZZZZ")) : context.localUtil.Format( A314BR_Pathology_T, "ZZZZZZZZZ.ZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, ',','.','5');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,80);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Pathology_T_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBR_Pathology_T_Enabled, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "DM_Numeric", "right", false, "HLP_BR_Pathology.htm");
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
            GxWebStd.gx_div_start( context, divUnnamedtablebr_pathology_n_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_pathology_n_Internalname, "是否淋巴结转移", "", "", lblTextblockbr_pathology_n_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Pathology.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbBR_Pathology_N_Internalname, "是否淋巴结转移", "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 89,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbBR_Pathology_N, cmbBR_Pathology_N_Internalname, StringUtil.RTrim( A315BR_Pathology_N), 1, cmbBR_Pathology_N_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, cmbBR_Pathology_N.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,89);\"", "", true, "HLP_BR_Pathology.htm");
            cmbBR_Pathology_N.CurrentValue = StringUtil.RTrim( A315BR_Pathology_N);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Pathology_N_Internalname, "Values", (String)(cmbBR_Pathology_N.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_pathology_lymphnum_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_pathology_lymphnum_Internalname, "淋巴结数目", "", "", lblTextblockbr_pathology_lymphnum_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Pathology.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Pathology_LymphNum_Internalname, "淋巴结数目", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 97,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_Pathology_LymphNum_Internalname, StringUtil.LTrim( StringUtil.NToC( A316BR_Pathology_LymphNum, 15, 5, ".", "")), ((edtBR_Pathology_LymphNum_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A316BR_Pathology_LymphNum, "ZZZZZZZZZ.ZZZZZ")) : context.localUtil.Format( A316BR_Pathology_LymphNum, "ZZZZZZZZZ.ZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, ',','.','5');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,97);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Pathology_LymphNum_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBR_Pathology_LymphNum_Enabled, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "DM_Numeric", "right", false, "HLP_BR_Pathology.htm");
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
            GxWebStd.gx_div_start( context, divUnnamedtablebr_pathology_lymphrate_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_pathology_lymphrate_Internalname, "淋巴结转移比例", "", "", lblTextblockbr_pathology_lymphrate_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Pathology.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Pathology_LymphRate_Internalname, "淋巴结转移比例", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 106,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_Pathology_LymphRate_Internalname, A317BR_Pathology_LymphRate, StringUtil.RTrim( context.localUtil.Format( A317BR_Pathology_LymphRate, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,106);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Pathology_LymphRate_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBR_Pathology_LymphRate_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Pathology.htm");
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
            GxWebStd.gx_div_start( context, divUnnamedtablebr_pathology_m_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_pathology_m_Internalname, "是否远端转移", "", "", lblTextblockbr_pathology_m_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Pathology.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbBR_Pathology_M_Internalname, "是否远端转移", "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 115,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbBR_Pathology_M, cmbBR_Pathology_M_Internalname, StringUtil.RTrim( A318BR_Pathology_M), 1, cmbBR_Pathology_M_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, cmbBR_Pathology_M.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,115);\"", "", true, "HLP_BR_Pathology.htm");
            cmbBR_Pathology_M.CurrentValue = StringUtil.RTrim( A318BR_Pathology_M);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Pathology_M_Internalname, "Values", (String)(cmbBR_Pathology_M.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtable1_Internalname, divUnnamedtable1_Visible, 0, "px", 0, "px", "", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_pathology_metaloc_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_pathology_metaloc_Internalname, "远端转移部位", "", "", lblTextblockbr_pathology_metaloc_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Pathology.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Pathology_MetaLoc_Internalname, "远端转移部位", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 126,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_Pathology_MetaLoc_Internalname, A319BR_Pathology_MetaLoc, StringUtil.RTrim( context.localUtil.Format( A319BR_Pathology_MetaLoc, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,126);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Pathology_MetaLoc_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBR_Pathology_MetaLoc_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Pathology.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 131,'',false,'',0)\"";
            ClassString = "ButtonMaterial";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_enter_Internalname, "", "保存", bttBtntrn_enter_Jsonclick, 5, "确认", "", StyleString, ClassString, bttBtntrn_enter_Visible, bttBtntrn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_Pathology.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 133,'',false,'',0)\"";
            ClassString = "ButtonMaterialDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_cancel_Internalname, "", "取消", bttBtntrn_cancel_Jsonclick, 1, "取消", "", StyleString, ClassString, bttBtntrn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_Pathology.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 135,'',false,'',0)\"";
            ClassString = "ButtonMaterialDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_delete_Internalname, "", "删除", bttBtntrn_delete_Jsonclick, 5, "删除", "", StyleString, ClassString, bttBtntrn_delete_Visible, bttBtntrn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_Pathology.htm");
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
            GxWebStd.gx_single_line_edit( context, edtBR_PathologyID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A226BR_PathologyID), 18, 0, ".", "")), ((edtBR_PathologyID_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A226BR_PathologyID), "ZZZZZZZZZZZZZZZZZZ")) : context.localUtil.Format( (decimal)(A226BR_PathologyID), "ZZZZZZZZZZZZZZZZZZ")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_PathologyID_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_PathologyID_Visible, edtBR_PathologyID_Enabled, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "HLP_BR_Pathology.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 140,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_EncounterID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A19BR_EncounterID), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A19BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,140);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_EncounterID_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_EncounterID_Visible, edtBR_EncounterID_Enabled, 1, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "HLP_BR_Pathology.htm");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Information_PatientNo_Internalname, A36BR_Information_PatientNo, StringUtil.RTrim( context.localUtil.Format( A36BR_Information_PatientNo, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Information_PatientNo_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_Information_PatientNo_Visible, edtBR_Information_PatientNo_Enabled, 0, "text", "", 80, "chr", 1, "row", 2000, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Pathology.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 142,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_PathologyID_TestID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A237BR_PathologyID_TestID), 10, 0, ".", "")), ((edtBR_PathologyID_TestID_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A237BR_PathologyID_TestID), "ZZZZZZZZZZ")) : context.localUtil.Format( (decimal)(A237BR_PathologyID_TestID), "ZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,142);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_PathologyID_TestID_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_PathologyID_TestID_Visible, edtBR_PathologyID_TestID_Enabled, 0, "number", "1", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Pathology.htm");
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
         E110Z2 ();
         context.wbGlbDoneStart = 1;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
               if ( context.localUtil.VCDate( cgiGet( edtBR_PathologyID_PADate_Internalname), 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"病理检查日期"}), 1, "BR_PATHOLOGYID_PADATE");
                  AnyError = 1;
                  GX_FocusControl = edtBR_PathologyID_PADate_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A238BR_PathologyID_PADate = DateTime.MinValue;
                  n238BR_PathologyID_PADate = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A238BR_PathologyID_PADate", context.localUtil.Format(A238BR_PathologyID_PADate, "9999/99/99"));
               }
               else
               {
                  A238BR_PathologyID_PADate = context.localUtil.CToD( cgiGet( edtBR_PathologyID_PADate_Internalname), 0);
                  n238BR_PathologyID_PADate = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A238BR_PathologyID_PADate", context.localUtil.Format(A238BR_PathologyID_PADate, "9999/99/99"));
               }
               n238BR_PathologyID_PADate = ((DateTime.MinValue==A238BR_PathologyID_PADate) ? true : false);
               if ( ( ( context.localUtil.CToN( cgiGet( edtBR_PathologyID_PAAge_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtBR_PathologyID_PAAge_Internalname), ".", ",") > Convert.ToDecimal( 999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_PATHOLOGYID_PAAGE");
                  AnyError = 1;
                  GX_FocusControl = edtBR_PathologyID_PAAge_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A240BR_PathologyID_PAAge = 0;
                  n240BR_PathologyID_PAAge = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A240BR_PathologyID_PAAge", StringUtil.LTrim( StringUtil.Str( (decimal)(A240BR_PathologyID_PAAge), 3, 0)));
               }
               else
               {
                  A240BR_PathologyID_PAAge = (short)(context.localUtil.CToN( cgiGet( edtBR_PathologyID_PAAge_Internalname), ".", ","));
                  n240BR_PathologyID_PAAge = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A240BR_PathologyID_PAAge", StringUtil.LTrim( StringUtil.Str( (decimal)(A240BR_PathologyID_PAAge), 3, 0)));
               }
               n240BR_PathologyID_PAAge = ((0==A240BR_PathologyID_PAAge) ? true : false);
               dynBR_PathologyID_PAHosp.CurrentValue = cgiGet( dynBR_PathologyID_PAHosp_Internalname);
               A239BR_PathologyID_PAHosp = cgiGet( dynBR_PathologyID_PAHosp_Internalname);
               n239BR_PathologyID_PAHosp = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A239BR_PathologyID_PAHosp", A239BR_PathologyID_PAHosp);
               n239BR_PathologyID_PAHosp = (String.IsNullOrEmpty(StringUtil.RTrim( A239BR_PathologyID_PAHosp)) ? true : false);
               A326BR_Pathology_Dia_Name = cgiGet( edtBR_Pathology_Dia_Name_Internalname);
               n326BR_Pathology_Dia_Name = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A326BR_Pathology_Dia_Name", A326BR_Pathology_Dia_Name);
               n326BR_Pathology_Dia_Name = (String.IsNullOrEmpty(StringUtil.RTrim( A326BR_Pathology_Dia_Name)) ? true : false);
               A242BR_PathologyID_PAResult = cgiGet( edtBR_PathologyID_PAResult_Internalname);
               n242BR_PathologyID_PAResult = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A242BR_PathologyID_PAResult", A242BR_PathologyID_PAResult);
               n242BR_PathologyID_PAResult = (String.IsNullOrEmpty(StringUtil.RTrim( A242BR_PathologyID_PAResult)) ? true : false);
               A241BR_PathologyID_PrePaDia = cgiGet( edtBR_PathologyID_PrePaDia_Internalname);
               n241BR_PathologyID_PrePaDia = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A241BR_PathologyID_PrePaDia", A241BR_PathologyID_PrePaDia);
               n241BR_PathologyID_PrePaDia = (String.IsNullOrEmpty(StringUtil.RTrim( A241BR_PathologyID_PrePaDia)) ? true : false);
               if ( ( ( context.localUtil.CToN( cgiGet( edtBR_Pathology_T_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtBR_Pathology_T_Internalname), ".", ",") > 999999999.99999m ) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_PATHOLOGY_T");
                  AnyError = 1;
                  GX_FocusControl = edtBR_Pathology_T_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A314BR_Pathology_T = 0;
                  n314BR_Pathology_T = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A314BR_Pathology_T", StringUtil.LTrim( StringUtil.Str( A314BR_Pathology_T, 15, 5)));
               }
               else
               {
                  A314BR_Pathology_T = context.localUtil.CToN( cgiGet( edtBR_Pathology_T_Internalname), ".", ",");
                  n314BR_Pathology_T = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A314BR_Pathology_T", StringUtil.LTrim( StringUtil.Str( A314BR_Pathology_T, 15, 5)));
               }
               n314BR_Pathology_T = ((Convert.ToDecimal(0)==A314BR_Pathology_T) ? true : false);
               cmbBR_Pathology_N.CurrentValue = cgiGet( cmbBR_Pathology_N_Internalname);
               A315BR_Pathology_N = cgiGet( cmbBR_Pathology_N_Internalname);
               n315BR_Pathology_N = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A315BR_Pathology_N", A315BR_Pathology_N);
               n315BR_Pathology_N = (String.IsNullOrEmpty(StringUtil.RTrim( A315BR_Pathology_N)) ? true : false);
               if ( ( ( context.localUtil.CToN( cgiGet( edtBR_Pathology_LymphNum_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtBR_Pathology_LymphNum_Internalname), ".", ",") > 999999999.99999m ) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_PATHOLOGY_LYMPHNUM");
                  AnyError = 1;
                  GX_FocusControl = edtBR_Pathology_LymphNum_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A316BR_Pathology_LymphNum = 0;
                  n316BR_Pathology_LymphNum = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A316BR_Pathology_LymphNum", StringUtil.LTrim( StringUtil.Str( A316BR_Pathology_LymphNum, 15, 5)));
               }
               else
               {
                  A316BR_Pathology_LymphNum = context.localUtil.CToN( cgiGet( edtBR_Pathology_LymphNum_Internalname), ".", ",");
                  n316BR_Pathology_LymphNum = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A316BR_Pathology_LymphNum", StringUtil.LTrim( StringUtil.Str( A316BR_Pathology_LymphNum, 15, 5)));
               }
               n316BR_Pathology_LymphNum = ((Convert.ToDecimal(0)==A316BR_Pathology_LymphNum) ? true : false);
               A317BR_Pathology_LymphRate = cgiGet( edtBR_Pathology_LymphRate_Internalname);
               n317BR_Pathology_LymphRate = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A317BR_Pathology_LymphRate", A317BR_Pathology_LymphRate);
               n317BR_Pathology_LymphRate = (String.IsNullOrEmpty(StringUtil.RTrim( A317BR_Pathology_LymphRate)) ? true : false);
               cmbBR_Pathology_M.CurrentValue = cgiGet( cmbBR_Pathology_M_Internalname);
               A318BR_Pathology_M = cgiGet( cmbBR_Pathology_M_Internalname);
               n318BR_Pathology_M = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A318BR_Pathology_M", A318BR_Pathology_M);
               n318BR_Pathology_M = (String.IsNullOrEmpty(StringUtil.RTrim( A318BR_Pathology_M)) ? true : false);
               A319BR_Pathology_MetaLoc = cgiGet( edtBR_Pathology_MetaLoc_Internalname);
               n319BR_Pathology_MetaLoc = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A319BR_Pathology_MetaLoc", A319BR_Pathology_MetaLoc);
               n319BR_Pathology_MetaLoc = (String.IsNullOrEmpty(StringUtil.RTrim( A319BR_Pathology_MetaLoc)) ? true : false);
               A226BR_PathologyID = (long)(context.localUtil.CToN( cgiGet( edtBR_PathologyID_Internalname), ".", ","));
               n226BR_PathologyID = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A226BR_PathologyID", StringUtil.LTrim( StringUtil.Str( (decimal)(A226BR_PathologyID), 18, 0)));
               if ( ( ( context.localUtil.CToN( cgiGet( edtBR_EncounterID_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtBR_EncounterID_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_ENCOUNTERID");
                  AnyError = 1;
                  GX_FocusControl = edtBR_EncounterID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A19BR_EncounterID = 0;
                  n19BR_EncounterID = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
               }
               else
               {
                  A19BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( edtBR_EncounterID_Internalname), ".", ","));
                  n19BR_EncounterID = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
               }
               n19BR_EncounterID = ((0==A19BR_EncounterID) ? true : false);
               A36BR_Information_PatientNo = cgiGet( edtBR_Information_PatientNo_Internalname);
               n36BR_Information_PatientNo = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36BR_Information_PatientNo", A36BR_Information_PatientNo);
               if ( ( ( context.localUtil.CToN( cgiGet( edtBR_PathologyID_TestID_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtBR_PathologyID_TestID_Internalname), ".", ",") > Convert.ToDecimal( 9999999999L )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_PATHOLOGYID_TESTID");
                  AnyError = 1;
                  GX_FocusControl = edtBR_PathologyID_TestID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A237BR_PathologyID_TestID = 0;
                  n237BR_PathologyID_TestID = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A237BR_PathologyID_TestID", StringUtil.LTrim( StringUtil.Str( (decimal)(A237BR_PathologyID_TestID), 10, 0)));
               }
               else
               {
                  A237BR_PathologyID_TestID = (long)(context.localUtil.CToN( cgiGet( edtBR_PathologyID_TestID_Internalname), ".", ","));
                  n237BR_PathologyID_TestID = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A237BR_PathologyID_TestID", StringUtil.LTrim( StringUtil.Str( (decimal)(A237BR_PathologyID_TestID), 10, 0)));
               }
               n237BR_PathologyID_TestID = ((0==A237BR_PathologyID_TestID) ? true : false);
               /* Read saved values. */
               Z226BR_PathologyID = (long)(context.localUtil.CToN( cgiGet( "Z226BR_PathologyID"), ".", ","));
               Z505BR_Pathology_N_Code = cgiGet( "Z505BR_Pathology_N_Code");
               n505BR_Pathology_N_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A505BR_Pathology_N_Code)) ? true : false);
               Z506BR_Pathology_M_Code = cgiGet( "Z506BR_Pathology_M_Code");
               n506BR_Pathology_M_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A506BR_Pathology_M_Code)) ? true : false);
               Z508BR_PathologyID_PAHosp_Code = cgiGet( "Z508BR_PathologyID_PAHosp_Code");
               n508BR_PathologyID_PAHosp_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A508BR_PathologyID_PAHosp_Code)) ? true : false);
               Z237BR_PathologyID_TestID = (long)(context.localUtil.CToN( cgiGet( "Z237BR_PathologyID_TestID"), ".", ","));
               n237BR_PathologyID_TestID = ((0==A237BR_PathologyID_TestID) ? true : false);
               Z238BR_PathologyID_PADate = context.localUtil.CToD( cgiGet( "Z238BR_PathologyID_PADate"), 0);
               n238BR_PathologyID_PADate = ((DateTime.MinValue==A238BR_PathologyID_PADate) ? true : false);
               Z239BR_PathologyID_PAHosp = cgiGet( "Z239BR_PathologyID_PAHosp");
               n239BR_PathologyID_PAHosp = (String.IsNullOrEmpty(StringUtil.RTrim( A239BR_PathologyID_PAHosp)) ? true : false);
               Z240BR_PathologyID_PAAge = (short)(context.localUtil.CToN( cgiGet( "Z240BR_PathologyID_PAAge"), ".", ","));
               n240BR_PathologyID_PAAge = ((0==A240BR_PathologyID_PAAge) ? true : false);
               Z241BR_PathologyID_PrePaDia = cgiGet( "Z241BR_PathologyID_PrePaDia");
               n241BR_PathologyID_PrePaDia = (String.IsNullOrEmpty(StringUtil.RTrim( A241BR_PathologyID_PrePaDia)) ? true : false);
               Z242BR_PathologyID_PAResult = cgiGet( "Z242BR_PathologyID_PAResult");
               n242BR_PathologyID_PAResult = (String.IsNullOrEmpty(StringUtil.RTrim( A242BR_PathologyID_PAResult)) ? true : false);
               Z326BR_Pathology_Dia_Name = cgiGet( "Z326BR_Pathology_Dia_Name");
               n326BR_Pathology_Dia_Name = (String.IsNullOrEmpty(StringUtil.RTrim( A326BR_Pathology_Dia_Name)) ? true : false);
               Z314BR_Pathology_T = context.localUtil.CToN( cgiGet( "Z314BR_Pathology_T"), ".", ",");
               n314BR_Pathology_T = ((Convert.ToDecimal(0)==A314BR_Pathology_T) ? true : false);
               Z315BR_Pathology_N = cgiGet( "Z315BR_Pathology_N");
               n315BR_Pathology_N = (String.IsNullOrEmpty(StringUtil.RTrim( A315BR_Pathology_N)) ? true : false);
               Z316BR_Pathology_LymphNum = context.localUtil.CToN( cgiGet( "Z316BR_Pathology_LymphNum"), ".", ",");
               n316BR_Pathology_LymphNum = ((Convert.ToDecimal(0)==A316BR_Pathology_LymphNum) ? true : false);
               Z317BR_Pathology_LymphRate = cgiGet( "Z317BR_Pathology_LymphRate");
               n317BR_Pathology_LymphRate = (String.IsNullOrEmpty(StringUtil.RTrim( A317BR_Pathology_LymphRate)) ? true : false);
               Z318BR_Pathology_M = cgiGet( "Z318BR_Pathology_M");
               n318BR_Pathology_M = (String.IsNullOrEmpty(StringUtil.RTrim( A318BR_Pathology_M)) ? true : false);
               Z319BR_Pathology_MetaLoc = cgiGet( "Z319BR_Pathology_MetaLoc");
               n319BR_Pathology_MetaLoc = (String.IsNullOrEmpty(StringUtil.RTrim( A319BR_Pathology_MetaLoc)) ? true : false);
               Z19BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( "Z19BR_EncounterID"), ".", ","));
               n19BR_EncounterID = ((0==A19BR_EncounterID) ? true : false);
               A505BR_Pathology_N_Code = cgiGet( "Z505BR_Pathology_N_Code");
               n505BR_Pathology_N_Code = false;
               n505BR_Pathology_N_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A505BR_Pathology_N_Code)) ? true : false);
               A506BR_Pathology_M_Code = cgiGet( "Z506BR_Pathology_M_Code");
               n506BR_Pathology_M_Code = false;
               n506BR_Pathology_M_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A506BR_Pathology_M_Code)) ? true : false);
               A508BR_PathologyID_PAHosp_Code = cgiGet( "Z508BR_PathologyID_PAHosp_Code");
               n508BR_PathologyID_PAHosp_Code = false;
               n508BR_PathologyID_PAHosp_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A508BR_PathologyID_PAHosp_Code)) ? true : false);
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ","));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ","));
               Gx_mode = cgiGet( "Mode");
               N19BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( "N19BR_EncounterID"), ".", ","));
               n19BR_EncounterID = ((0==A19BR_EncounterID) ? true : false);
               AV7BR_PathologyID = (long)(context.localUtil.CToN( cgiGet( "vBR_PATHOLOGYID"), ".", ","));
               AV13Insert_BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( "vINSERT_BR_ENCOUNTERID"), ".", ","));
               A505BR_Pathology_N_Code = cgiGet( "BR_PATHOLOGY_N_CODE");
               n505BR_Pathology_N_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A505BR_Pathology_N_Code)) ? true : false);
               A506BR_Pathology_M_Code = cgiGet( "BR_PATHOLOGY_M_CODE");
               n506BR_Pathology_M_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A506BR_Pathology_M_Code)) ? true : false);
               A508BR_PathologyID_PAHosp_Code = cgiGet( "BR_PATHOLOGYID_PAHOSP_CODE");
               n508BR_PathologyID_PAHosp_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A508BR_PathologyID_PAHosp_Code)) ? true : false);
               AV16tCurrentCode = cgiGet( "vTCURRENTCODE");
               A85BR_Information_ID = (long)(context.localUtil.CToN( cgiGet( "BR_INFORMATION_ID"), ".", ","));
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
               forbiddenHiddens = "hsh" + "BR_Pathology";
               A226BR_PathologyID = (long)(context.localUtil.CToN( cgiGet( edtBR_PathologyID_Internalname), ".", ","));
               n226BR_PathologyID = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A226BR_PathologyID", StringUtil.LTrim( StringUtil.Str( (decimal)(A226BR_PathologyID), 18, 0)));
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A226BR_PathologyID), "ZZZZZZZZZZZZZZZZZZ");
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( AV16tCurrentCode, ""));
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV13Insert_BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ");
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( A226BR_PathologyID != Z226BR_PathologyID ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
               {
                  GXUtil.WriteLog("br_pathology:[SecurityCheckFailed value for]"+"BR_PathologyID:"+context.localUtil.Format( (decimal)(A226BR_PathologyID), "ZZZZZZZZZZZZZZZZZZ"));
                  GXUtil.WriteLog("br_pathology:[SecurityCheckFailed value for]"+"tCurrentCode:"+StringUtil.RTrim( context.localUtil.Format( AV16tCurrentCode, "")));
                  GXUtil.WriteLog("br_pathology:[SecurityCheckFailed value for]"+"Insert_BR_EncounterID:"+context.localUtil.Format( (decimal)(AV13Insert_BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ"));
                  GXUtil.WriteLog("br_pathology:[SecurityCheckFailed value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
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
                  A226BR_PathologyID = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  n226BR_PathologyID = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A226BR_PathologyID", StringUtil.LTrim( StringUtil.Str( (decimal)(A226BR_PathologyID), 18, 0)));
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
                     sMode36 = Gx_mode;
                     Gx_mode = "UPD";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     Gx_mode = sMode36;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound36 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_0Z0( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtntrn_enter_Internalname;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert", ""), 1, "BR_PATHOLOGYID");
                        AnyError = 1;
                        GX_FocusControl = edtBR_PathologyID_Internalname;
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
                           E110Z2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: After Trn */
                           E120Z2 ();
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
            E120Z2 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll0Z36( ) ;
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
            DisableAttributes0Z36( ) ;
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

      protected void CONFIRM_0Z0( )
      {
         BeforeValidate0Z36( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0Z36( ) ;
            }
            else
            {
               CheckExtendedTable0Z36( ) ;
               CloseExtendedTableCursors0Z36( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         }
      }

      protected void ResetCaption0Z0( )
      {
      }

      protected void E110Z2( )
      {
         /* Start Routine */
         GXt_char1 = AV16tCurrentCode;
         new zbr_getcurrenttcode(context ).execute( out  GXt_char1) ;
         AV16tCurrentCode = GXt_char1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16tCurrentCode", AV16tCurrentCode);
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV8WWPContext) ;
         AV9IsAuthorized = true;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9IsAuthorized", AV9IsAuthorized);
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            GXt_boolean2 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Check_Pathology", out  GXt_boolean2) ;
            AV9IsAuthorized = GXt_boolean2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9IsAuthorized", AV9IsAuthorized);
         }
         if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
         {
            GXt_boolean2 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Check_Pathology", out  GXt_boolean2) ;
            AV9IsAuthorized = GXt_boolean2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9IsAuthorized", AV9IsAuthorized);
         }
         if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
         {
            GXt_boolean2 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Pathology", out  GXt_boolean2) ;
            AV9IsAuthorized = GXt_boolean2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9IsAuthorized", AV9IsAuthorized);
         }
         if ( ! AV9IsAuthorized )
         {
            CallWebObject(formatLink("wwpbaseobjects.notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV17Pgmname)));
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
         if ( ( StringUtil.StrCmp(AV11TrnContext.gxTpr_Transactionname, AV17Pgmname) == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) )
         {
            AV18GXV1 = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18GXV1), 8, 0)));
            while ( AV18GXV1 <= AV11TrnContext.gxTpr_Attributes.Count )
            {
               AV14TrnContextAtt = ((GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute)AV11TrnContext.gxTpr_Attributes.Item(AV18GXV1));
               if ( StringUtil.StrCmp(AV14TrnContextAtt.gxTpr_Attributename, "BR_EncounterID") == 0 )
               {
                  AV13Insert_BR_EncounterID = (long)(NumberUtil.Val( AV14TrnContextAtt.gxTpr_Attributevalue, "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13Insert_BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13Insert_BR_EncounterID), 18, 0)));
               }
               AV18GXV1 = (int)(AV18GXV1+1);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18GXV1), 8, 0)));
            }
         }
         edtBR_PathologyID_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_PathologyID_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_PathologyID_Visible), 5, 0)), true);
         edtBR_EncounterID_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_EncounterID_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_EncounterID_Visible), 5, 0)), true);
         edtBR_Information_PatientNo_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Information_PatientNo_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Information_PatientNo_Visible), 5, 0)), true);
         edtBR_PathologyID_TestID_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_PathologyID_TestID_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_PathologyID_TestID_Visible), 5, 0)), true);
         GXt_boolean2 = AV15TempBoolean;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Pathology", out  GXt_boolean2) ;
         AV15TempBoolean = GXt_boolean2;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15TempBoolean", AV15TempBoolean);
         if ( ! ( AV15TempBoolean ) )
         {
            bttBtntrn_enter_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_enter_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_enter_Visible), 5, 0)), true);
         }
         GXt_boolean2 = AV15TempBoolean;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Pathology", out  GXt_boolean2) ;
         AV15TempBoolean = GXt_boolean2;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15TempBoolean", AV15TempBoolean);
         if ( ! ( AV15TempBoolean ) )
         {
            bttBtntrn_cancel_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_cancel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_cancel_Visible), 5, 0)), true);
         }
         GXt_boolean2 = AV15TempBoolean;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Pathology", out  GXt_boolean2) ;
         AV15TempBoolean = GXt_boolean2;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15TempBoolean", AV15TempBoolean);
         if ( ! ( AV15TempBoolean ) )
         {
            bttBtntrn_delete_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_delete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_delete_Visible), 5, 0)), true);
         }
      }

      protected void E120Z2( )
      {
         /* After Trn Routine */
         if ( 1 == 0 )
         {
            if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV11TrnContext.gxTpr_Callerondelete )
            {
               CallWebObject(formatLink("br_pathologyww.aspx") );
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
            CallWebObject(formatLink("br_pathologyview.aspx") + "?" + UrlEncode("" +A226BR_PathologyID) + "," + UrlEncode(StringUtil.RTrim("General")));
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
         divUnnamedtable1_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, divUnnamedtable1_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divUnnamedtable1_Visible), 5, 0)), true);
      }

      protected void ZM0Z36( short GX_JID )
      {
         if ( ( GX_JID == 25 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z505BR_Pathology_N_Code = T000Z3_A505BR_Pathology_N_Code[0];
               Z506BR_Pathology_M_Code = T000Z3_A506BR_Pathology_M_Code[0];
               Z508BR_PathologyID_PAHosp_Code = T000Z3_A508BR_PathologyID_PAHosp_Code[0];
               Z237BR_PathologyID_TestID = T000Z3_A237BR_PathologyID_TestID[0];
               Z238BR_PathologyID_PADate = T000Z3_A238BR_PathologyID_PADate[0];
               Z239BR_PathologyID_PAHosp = T000Z3_A239BR_PathologyID_PAHosp[0];
               Z240BR_PathologyID_PAAge = T000Z3_A240BR_PathologyID_PAAge[0];
               Z241BR_PathologyID_PrePaDia = T000Z3_A241BR_PathologyID_PrePaDia[0];
               Z242BR_PathologyID_PAResult = T000Z3_A242BR_PathologyID_PAResult[0];
               Z326BR_Pathology_Dia_Name = T000Z3_A326BR_Pathology_Dia_Name[0];
               Z314BR_Pathology_T = T000Z3_A314BR_Pathology_T[0];
               Z315BR_Pathology_N = T000Z3_A315BR_Pathology_N[0];
               Z316BR_Pathology_LymphNum = T000Z3_A316BR_Pathology_LymphNum[0];
               Z317BR_Pathology_LymphRate = T000Z3_A317BR_Pathology_LymphRate[0];
               Z318BR_Pathology_M = T000Z3_A318BR_Pathology_M[0];
               Z319BR_Pathology_MetaLoc = T000Z3_A319BR_Pathology_MetaLoc[0];
               Z19BR_EncounterID = T000Z3_A19BR_EncounterID[0];
            }
            else
            {
               Z505BR_Pathology_N_Code = A505BR_Pathology_N_Code;
               Z506BR_Pathology_M_Code = A506BR_Pathology_M_Code;
               Z508BR_PathologyID_PAHosp_Code = A508BR_PathologyID_PAHosp_Code;
               Z237BR_PathologyID_TestID = A237BR_PathologyID_TestID;
               Z238BR_PathologyID_PADate = A238BR_PathologyID_PADate;
               Z239BR_PathologyID_PAHosp = A239BR_PathologyID_PAHosp;
               Z240BR_PathologyID_PAAge = A240BR_PathologyID_PAAge;
               Z241BR_PathologyID_PrePaDia = A241BR_PathologyID_PrePaDia;
               Z242BR_PathologyID_PAResult = A242BR_PathologyID_PAResult;
               Z326BR_Pathology_Dia_Name = A326BR_Pathology_Dia_Name;
               Z314BR_Pathology_T = A314BR_Pathology_T;
               Z315BR_Pathology_N = A315BR_Pathology_N;
               Z316BR_Pathology_LymphNum = A316BR_Pathology_LymphNum;
               Z317BR_Pathology_LymphRate = A317BR_Pathology_LymphRate;
               Z318BR_Pathology_M = A318BR_Pathology_M;
               Z319BR_Pathology_MetaLoc = A319BR_Pathology_MetaLoc;
               Z19BR_EncounterID = A19BR_EncounterID;
            }
         }
         if ( GX_JID == -25 )
         {
            Z226BR_PathologyID = A226BR_PathologyID;
            Z505BR_Pathology_N_Code = A505BR_Pathology_N_Code;
            Z506BR_Pathology_M_Code = A506BR_Pathology_M_Code;
            Z508BR_PathologyID_PAHosp_Code = A508BR_PathologyID_PAHosp_Code;
            Z237BR_PathologyID_TestID = A237BR_PathologyID_TestID;
            Z238BR_PathologyID_PADate = A238BR_PathologyID_PADate;
            Z239BR_PathologyID_PAHosp = A239BR_PathologyID_PAHosp;
            Z240BR_PathologyID_PAAge = A240BR_PathologyID_PAAge;
            Z241BR_PathologyID_PrePaDia = A241BR_PathologyID_PrePaDia;
            Z242BR_PathologyID_PAResult = A242BR_PathologyID_PAResult;
            Z326BR_Pathology_Dia_Name = A326BR_Pathology_Dia_Name;
            Z314BR_Pathology_T = A314BR_Pathology_T;
            Z315BR_Pathology_N = A315BR_Pathology_N;
            Z316BR_Pathology_LymphNum = A316BR_Pathology_LymphNum;
            Z317BR_Pathology_LymphRate = A317BR_Pathology_LymphRate;
            Z318BR_Pathology_M = A318BR_Pathology_M;
            Z319BR_Pathology_MetaLoc = A319BR_Pathology_MetaLoc;
            Z19BR_EncounterID = A19BR_EncounterID;
            Z85BR_Information_ID = A85BR_Information_ID;
            Z36BR_Information_PatientNo = A36BR_Information_PatientNo;
         }
      }

      protected void standaloneNotModal( )
      {
         edtBR_PathologyID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_PathologyID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_PathologyID_Enabled), 5, 0)), true);
         edtBR_PathologyID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_PathologyID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_PathologyID_Enabled), 5, 0)), true);
         bttBtntrn_delete_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_delete_Enabled), 5, 0)), true);
         if ( ! (0==AV7BR_PathologyID) )
         {
            A226BR_PathologyID = AV7BR_PathologyID;
            n226BR_PathologyID = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A226BR_PathologyID", StringUtil.LTrim( StringUtil.Str( (decimal)(A226BR_PathologyID), 18, 0)));
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
         GXABR_PATHOLOGYID_PAHOSP_html0Z36( AV16tCurrentCode) ;
      }

      protected void standaloneModal( )
      {
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV13Insert_BR_EncounterID) )
         {
            A19BR_EncounterID = AV13Insert_BR_EncounterID;
            n19BR_EncounterID = false;
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
            AV17Pgmname = "BR_Pathology";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17Pgmname", AV17Pgmname);
            /* Using cursor T000Z4 */
            pr_default.execute(2, new Object[] {n19BR_EncounterID, A19BR_EncounterID});
            A85BR_Information_ID = T000Z4_A85BR_Information_ID[0];
            n85BR_Information_ID = T000Z4_n85BR_Information_ID[0];
            pr_default.close(2);
            /* Using cursor T000Z5 */
            pr_default.execute(3, new Object[] {n85BR_Information_ID, A85BR_Information_ID});
            A36BR_Information_PatientNo = T000Z5_A36BR_Information_PatientNo[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36BR_Information_PatientNo", A36BR_Information_PatientNo);
            n36BR_Information_PatientNo = T000Z5_n36BR_Information_PatientNo[0];
            pr_default.close(3);
         }
      }

      protected void Load0Z36( )
      {
         /* Using cursor T000Z6 */
         pr_default.execute(4, new Object[] {n226BR_PathologyID, A226BR_PathologyID});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound36 = 1;
            A85BR_Information_ID = T000Z6_A85BR_Information_ID[0];
            n85BR_Information_ID = T000Z6_n85BR_Information_ID[0];
            A505BR_Pathology_N_Code = T000Z6_A505BR_Pathology_N_Code[0];
            n505BR_Pathology_N_Code = T000Z6_n505BR_Pathology_N_Code[0];
            A506BR_Pathology_M_Code = T000Z6_A506BR_Pathology_M_Code[0];
            n506BR_Pathology_M_Code = T000Z6_n506BR_Pathology_M_Code[0];
            A508BR_PathologyID_PAHosp_Code = T000Z6_A508BR_PathologyID_PAHosp_Code[0];
            n508BR_PathologyID_PAHosp_Code = T000Z6_n508BR_PathologyID_PAHosp_Code[0];
            A36BR_Information_PatientNo = T000Z6_A36BR_Information_PatientNo[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36BR_Information_PatientNo", A36BR_Information_PatientNo);
            n36BR_Information_PatientNo = T000Z6_n36BR_Information_PatientNo[0];
            A237BR_PathologyID_TestID = T000Z6_A237BR_PathologyID_TestID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A237BR_PathologyID_TestID", StringUtil.LTrim( StringUtil.Str( (decimal)(A237BR_PathologyID_TestID), 10, 0)));
            n237BR_PathologyID_TestID = T000Z6_n237BR_PathologyID_TestID[0];
            A238BR_PathologyID_PADate = T000Z6_A238BR_PathologyID_PADate[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A238BR_PathologyID_PADate", context.localUtil.Format(A238BR_PathologyID_PADate, "9999/99/99"));
            n238BR_PathologyID_PADate = T000Z6_n238BR_PathologyID_PADate[0];
            A239BR_PathologyID_PAHosp = T000Z6_A239BR_PathologyID_PAHosp[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A239BR_PathologyID_PAHosp", A239BR_PathologyID_PAHosp);
            n239BR_PathologyID_PAHosp = T000Z6_n239BR_PathologyID_PAHosp[0];
            A240BR_PathologyID_PAAge = T000Z6_A240BR_PathologyID_PAAge[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A240BR_PathologyID_PAAge", StringUtil.LTrim( StringUtil.Str( (decimal)(A240BR_PathologyID_PAAge), 3, 0)));
            n240BR_PathologyID_PAAge = T000Z6_n240BR_PathologyID_PAAge[0];
            A241BR_PathologyID_PrePaDia = T000Z6_A241BR_PathologyID_PrePaDia[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A241BR_PathologyID_PrePaDia", A241BR_PathologyID_PrePaDia);
            n241BR_PathologyID_PrePaDia = T000Z6_n241BR_PathologyID_PrePaDia[0];
            A242BR_PathologyID_PAResult = T000Z6_A242BR_PathologyID_PAResult[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A242BR_PathologyID_PAResult", A242BR_PathologyID_PAResult);
            n242BR_PathologyID_PAResult = T000Z6_n242BR_PathologyID_PAResult[0];
            A326BR_Pathology_Dia_Name = T000Z6_A326BR_Pathology_Dia_Name[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A326BR_Pathology_Dia_Name", A326BR_Pathology_Dia_Name);
            n326BR_Pathology_Dia_Name = T000Z6_n326BR_Pathology_Dia_Name[0];
            A314BR_Pathology_T = T000Z6_A314BR_Pathology_T[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A314BR_Pathology_T", StringUtil.LTrim( StringUtil.Str( A314BR_Pathology_T, 15, 5)));
            n314BR_Pathology_T = T000Z6_n314BR_Pathology_T[0];
            A315BR_Pathology_N = T000Z6_A315BR_Pathology_N[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A315BR_Pathology_N", A315BR_Pathology_N);
            n315BR_Pathology_N = T000Z6_n315BR_Pathology_N[0];
            A316BR_Pathology_LymphNum = T000Z6_A316BR_Pathology_LymphNum[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A316BR_Pathology_LymphNum", StringUtil.LTrim( StringUtil.Str( A316BR_Pathology_LymphNum, 15, 5)));
            n316BR_Pathology_LymphNum = T000Z6_n316BR_Pathology_LymphNum[0];
            A317BR_Pathology_LymphRate = T000Z6_A317BR_Pathology_LymphRate[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A317BR_Pathology_LymphRate", A317BR_Pathology_LymphRate);
            n317BR_Pathology_LymphRate = T000Z6_n317BR_Pathology_LymphRate[0];
            A318BR_Pathology_M = T000Z6_A318BR_Pathology_M[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A318BR_Pathology_M", A318BR_Pathology_M);
            n318BR_Pathology_M = T000Z6_n318BR_Pathology_M[0];
            A319BR_Pathology_MetaLoc = T000Z6_A319BR_Pathology_MetaLoc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A319BR_Pathology_MetaLoc", A319BR_Pathology_MetaLoc);
            n319BR_Pathology_MetaLoc = T000Z6_n319BR_Pathology_MetaLoc[0];
            A19BR_EncounterID = T000Z6_A19BR_EncounterID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
            n19BR_EncounterID = T000Z6_n19BR_EncounterID[0];
            ZM0Z36( -25) ;
         }
         pr_default.close(4);
         OnLoadActions0Z36( ) ;
      }

      protected void OnLoadActions0Z36( )
      {
         AV17Pgmname = "BR_Pathology";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17Pgmname", AV17Pgmname);
         divUnnamedtable1_Visible = (((StringUtil.StrCmp(A318BR_Pathology_M, "是")==0)) ? 1 : 0);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, divUnnamedtable1_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divUnnamedtable1_Visible), 5, 0)), true);
      }

      protected void CheckExtendedTable0Z36( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
         AV17Pgmname = "BR_Pathology";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17Pgmname", AV17Pgmname);
         /* Using cursor T000Z4 */
         pr_default.execute(2, new Object[] {n19BR_EncounterID, A19BR_EncounterID});
         if ( (pr_default.getStatus(2) == 101) )
         {
            if ( ! ( (0==A19BR_EncounterID) ) )
            {
               GX_msglist.addItem("不匹配' T15'", "ForeignKeyNotFound", 1, "BR_ENCOUNTERID");
               AnyError = 1;
               GX_FocusControl = edtBR_EncounterID_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         A85BR_Information_ID = T000Z4_A85BR_Information_ID[0];
         n85BR_Information_ID = T000Z4_n85BR_Information_ID[0];
         pr_default.close(2);
         /* Using cursor T000Z5 */
         pr_default.execute(3, new Object[] {n85BR_Information_ID, A85BR_Information_ID});
         if ( (pr_default.getStatus(3) == 101) )
         {
            if ( ! ( (0==A85BR_Information_ID) ) )
            {
               GX_msglist.addItem("不匹配' T16'", "ForeignKeyNotFound", 1, "");
               AnyError = 1;
            }
         }
         A36BR_Information_PatientNo = T000Z5_A36BR_Information_PatientNo[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36BR_Information_PatientNo", A36BR_Information_PatientNo);
         n36BR_Information_PatientNo = T000Z5_n36BR_Information_PatientNo[0];
         pr_default.close(3);
         if ( ! ( (DateTime.MinValue==A238BR_PathologyID_PADate) || ( A238BR_PathologyID_PADate >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("域������������������超界", "OutOfRange", 1, "BR_PATHOLOGYID_PADATE");
            AnyError = 1;
            GX_FocusControl = edtBR_PathologyID_PADate_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( (DateTime.MinValue==A238BR_PathologyID_PADate) )
         {
            GX_msglist.addItem("病理检查日期是必须填写的。", 1, "BR_PATHOLOGYID_PADATE");
            AnyError = 1;
            GX_FocusControl = edtBR_PathologyID_PADate_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( (0==A240BR_PathologyID_PAAge) )
         {
            GX_msglist.addItem("年龄是必须填写的。", 1, "BR_PATHOLOGYID_PAAGE");
            AnyError = 1;
            GX_FocusControl = edtBR_PathologyID_PAAge_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( A326BR_Pathology_Dia_Name)) )
         {
            GX_msglist.addItem("病理诊断名称是必须填写的。", 1, "BR_PATHOLOGY_DIA_NAME");
            AnyError = 1;
            GX_FocusControl = edtBR_Pathology_Dia_Name_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ! ( ( StringUtil.StrCmp(A315BR_Pathology_N, "否") == 0 ) || ( StringUtil.StrCmp(A315BR_Pathology_N, "是") == 0 ) || ( StringUtil.StrCmp(A315BR_Pathology_N, "不详") == 0 ) || String.IsNullOrEmpty(StringUtil.RTrim( A315BR_Pathology_N)) ) )
         {
            GX_msglist.addItem("域���������������������超界", "OutOfRange", 1, "BR_PATHOLOGY_N");
            AnyError = 1;
            GX_FocusControl = cmbBR_Pathology_N_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ! ( ( StringUtil.StrCmp(A318BR_Pathology_M, "否") == 0 ) || ( StringUtil.StrCmp(A318BR_Pathology_M, "是") == 0 ) || ( StringUtil.StrCmp(A318BR_Pathology_M, "不详") == 0 ) || String.IsNullOrEmpty(StringUtil.RTrim( A318BR_Pathology_M)) ) )
         {
            GX_msglist.addItem("域������������������超界", "OutOfRange", 1, "BR_PATHOLOGY_M");
            AnyError = 1;
            GX_FocusControl = cmbBR_Pathology_M_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         divUnnamedtable1_Visible = (((StringUtil.StrCmp(A318BR_Pathology_M, "是")==0)) ? 1 : 0);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, divUnnamedtable1_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divUnnamedtable1_Visible), 5, 0)), true);
      }

      protected void CloseExtendedTableCursors0Z36( )
      {
         pr_default.close(2);
         pr_default.close(3);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_26( long A19BR_EncounterID )
      {
         /* Using cursor T000Z7 */
         pr_default.execute(5, new Object[] {n19BR_EncounterID, A19BR_EncounterID});
         if ( (pr_default.getStatus(5) == 101) )
         {
            if ( ! ( (0==A19BR_EncounterID) ) )
            {
               GX_msglist.addItem("不匹配' T15'", "ForeignKeyNotFound", 1, "BR_ENCOUNTERID");
               AnyError = 1;
               GX_FocusControl = edtBR_EncounterID_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         A85BR_Information_ID = T000Z7_A85BR_Information_ID[0];
         n85BR_Information_ID = T000Z7_n85BR_Information_ID[0];
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

      protected void gxLoad_27( long A85BR_Information_ID )
      {
         /* Using cursor T000Z8 */
         pr_default.execute(6, new Object[] {n85BR_Information_ID, A85BR_Information_ID});
         if ( (pr_default.getStatus(6) == 101) )
         {
            if ( ! ( (0==A85BR_Information_ID) ) )
            {
               GX_msglist.addItem("不匹配' T16'", "ForeignKeyNotFound", 1, "");
               AnyError = 1;
            }
         }
         A36BR_Information_PatientNo = T000Z8_A36BR_Information_PatientNo[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36BR_Information_PatientNo", A36BR_Information_PatientNo);
         n36BR_Information_PatientNo = T000Z8_n36BR_Information_PatientNo[0];
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

      protected void GetKey0Z36( )
      {
         /* Using cursor T000Z9 */
         pr_default.execute(7, new Object[] {n226BR_PathologyID, A226BR_PathologyID});
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound36 = 1;
         }
         else
         {
            RcdFound36 = 0;
         }
         pr_default.close(7);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T000Z3 */
         pr_default.execute(1, new Object[] {n226BR_PathologyID, A226BR_PathologyID});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0Z36( 25) ;
            RcdFound36 = 1;
            A226BR_PathologyID = T000Z3_A226BR_PathologyID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A226BR_PathologyID", StringUtil.LTrim( StringUtil.Str( (decimal)(A226BR_PathologyID), 18, 0)));
            n226BR_PathologyID = T000Z3_n226BR_PathologyID[0];
            A505BR_Pathology_N_Code = T000Z3_A505BR_Pathology_N_Code[0];
            n505BR_Pathology_N_Code = T000Z3_n505BR_Pathology_N_Code[0];
            A506BR_Pathology_M_Code = T000Z3_A506BR_Pathology_M_Code[0];
            n506BR_Pathology_M_Code = T000Z3_n506BR_Pathology_M_Code[0];
            A508BR_PathologyID_PAHosp_Code = T000Z3_A508BR_PathologyID_PAHosp_Code[0];
            n508BR_PathologyID_PAHosp_Code = T000Z3_n508BR_PathologyID_PAHosp_Code[0];
            A237BR_PathologyID_TestID = T000Z3_A237BR_PathologyID_TestID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A237BR_PathologyID_TestID", StringUtil.LTrim( StringUtil.Str( (decimal)(A237BR_PathologyID_TestID), 10, 0)));
            n237BR_PathologyID_TestID = T000Z3_n237BR_PathologyID_TestID[0];
            A238BR_PathologyID_PADate = T000Z3_A238BR_PathologyID_PADate[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A238BR_PathologyID_PADate", context.localUtil.Format(A238BR_PathologyID_PADate, "9999/99/99"));
            n238BR_PathologyID_PADate = T000Z3_n238BR_PathologyID_PADate[0];
            A239BR_PathologyID_PAHosp = T000Z3_A239BR_PathologyID_PAHosp[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A239BR_PathologyID_PAHosp", A239BR_PathologyID_PAHosp);
            n239BR_PathologyID_PAHosp = T000Z3_n239BR_PathologyID_PAHosp[0];
            A240BR_PathologyID_PAAge = T000Z3_A240BR_PathologyID_PAAge[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A240BR_PathologyID_PAAge", StringUtil.LTrim( StringUtil.Str( (decimal)(A240BR_PathologyID_PAAge), 3, 0)));
            n240BR_PathologyID_PAAge = T000Z3_n240BR_PathologyID_PAAge[0];
            A241BR_PathologyID_PrePaDia = T000Z3_A241BR_PathologyID_PrePaDia[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A241BR_PathologyID_PrePaDia", A241BR_PathologyID_PrePaDia);
            n241BR_PathologyID_PrePaDia = T000Z3_n241BR_PathologyID_PrePaDia[0];
            A242BR_PathologyID_PAResult = T000Z3_A242BR_PathologyID_PAResult[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A242BR_PathologyID_PAResult", A242BR_PathologyID_PAResult);
            n242BR_PathologyID_PAResult = T000Z3_n242BR_PathologyID_PAResult[0];
            A326BR_Pathology_Dia_Name = T000Z3_A326BR_Pathology_Dia_Name[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A326BR_Pathology_Dia_Name", A326BR_Pathology_Dia_Name);
            n326BR_Pathology_Dia_Name = T000Z3_n326BR_Pathology_Dia_Name[0];
            A314BR_Pathology_T = T000Z3_A314BR_Pathology_T[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A314BR_Pathology_T", StringUtil.LTrim( StringUtil.Str( A314BR_Pathology_T, 15, 5)));
            n314BR_Pathology_T = T000Z3_n314BR_Pathology_T[0];
            A315BR_Pathology_N = T000Z3_A315BR_Pathology_N[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A315BR_Pathology_N", A315BR_Pathology_N);
            n315BR_Pathology_N = T000Z3_n315BR_Pathology_N[0];
            A316BR_Pathology_LymphNum = T000Z3_A316BR_Pathology_LymphNum[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A316BR_Pathology_LymphNum", StringUtil.LTrim( StringUtil.Str( A316BR_Pathology_LymphNum, 15, 5)));
            n316BR_Pathology_LymphNum = T000Z3_n316BR_Pathology_LymphNum[0];
            A317BR_Pathology_LymphRate = T000Z3_A317BR_Pathology_LymphRate[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A317BR_Pathology_LymphRate", A317BR_Pathology_LymphRate);
            n317BR_Pathology_LymphRate = T000Z3_n317BR_Pathology_LymphRate[0];
            A318BR_Pathology_M = T000Z3_A318BR_Pathology_M[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A318BR_Pathology_M", A318BR_Pathology_M);
            n318BR_Pathology_M = T000Z3_n318BR_Pathology_M[0];
            A319BR_Pathology_MetaLoc = T000Z3_A319BR_Pathology_MetaLoc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A319BR_Pathology_MetaLoc", A319BR_Pathology_MetaLoc);
            n319BR_Pathology_MetaLoc = T000Z3_n319BR_Pathology_MetaLoc[0];
            A19BR_EncounterID = T000Z3_A19BR_EncounterID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
            n19BR_EncounterID = T000Z3_n19BR_EncounterID[0];
            Z226BR_PathologyID = A226BR_PathologyID;
            sMode36 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load0Z36( ) ;
            if ( AnyError == 1 )
            {
               RcdFound36 = 0;
               InitializeNonKey0Z36( ) ;
            }
            Gx_mode = sMode36;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound36 = 0;
            InitializeNonKey0Z36( ) ;
            sMode36 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal( ) ;
            Gx_mode = sMode36;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0Z36( ) ;
         if ( RcdFound36 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound36 = 0;
         /* Using cursor T000Z10 */
         pr_default.execute(8, new Object[] {n226BR_PathologyID, A226BR_PathologyID});
         if ( (pr_default.getStatus(8) != 101) )
         {
            while ( (pr_default.getStatus(8) != 101) && ( ( T000Z10_A226BR_PathologyID[0] < A226BR_PathologyID ) ) )
            {
               pr_default.readNext(8);
            }
            if ( (pr_default.getStatus(8) != 101) && ( ( T000Z10_A226BR_PathologyID[0] > A226BR_PathologyID ) ) )
            {
               A226BR_PathologyID = T000Z10_A226BR_PathologyID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A226BR_PathologyID", StringUtil.LTrim( StringUtil.Str( (decimal)(A226BR_PathologyID), 18, 0)));
               n226BR_PathologyID = T000Z10_n226BR_PathologyID[0];
               RcdFound36 = 1;
            }
         }
         pr_default.close(8);
      }

      protected void move_previous( )
      {
         RcdFound36 = 0;
         /* Using cursor T000Z11 */
         pr_default.execute(9, new Object[] {n226BR_PathologyID, A226BR_PathologyID});
         if ( (pr_default.getStatus(9) != 101) )
         {
            while ( (pr_default.getStatus(9) != 101) && ( ( T000Z11_A226BR_PathologyID[0] > A226BR_PathologyID ) ) )
            {
               pr_default.readNext(9);
            }
            if ( (pr_default.getStatus(9) != 101) && ( ( T000Z11_A226BR_PathologyID[0] < A226BR_PathologyID ) ) )
            {
               A226BR_PathologyID = T000Z11_A226BR_PathologyID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A226BR_PathologyID", StringUtil.LTrim( StringUtil.Str( (decimal)(A226BR_PathologyID), 18, 0)));
               n226BR_PathologyID = T000Z11_n226BR_PathologyID[0];
               RcdFound36 = 1;
            }
         }
         pr_default.close(9);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey0Z36( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtBR_PathologyID_PADate_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert0Z36( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound36 == 1 )
            {
               if ( A226BR_PathologyID != Z226BR_PathologyID )
               {
                  A226BR_PathologyID = Z226BR_PathologyID;
                  n226BR_PathologyID = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A226BR_PathologyID", StringUtil.LTrim( StringUtil.Str( (decimal)(A226BR_PathologyID), 18, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "BR_PATHOLOGYID");
                  AnyError = 1;
                  GX_FocusControl = edtBR_PathologyID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtBR_PathologyID_PADate_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Update record */
                  Update0Z36( ) ;
                  GX_FocusControl = edtBR_PathologyID_PADate_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A226BR_PathologyID != Z226BR_PathologyID )
               {
                  /* Insert record */
                  GX_FocusControl = edtBR_PathologyID_PADate_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert0Z36( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "BR_PATHOLOGYID");
                     AnyError = 1;
                     GX_FocusControl = edtBR_PathologyID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     /* Insert record */
                     GX_FocusControl = edtBR_PathologyID_PADate_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert0Z36( ) ;
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
         if ( A226BR_PathologyID != Z226BR_PathologyID )
         {
            A226BR_PathologyID = Z226BR_PathologyID;
            n226BR_PathologyID = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A226BR_PathologyID", StringUtil.LTrim( StringUtil.Str( (decimal)(A226BR_PathologyID), 18, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "BR_PATHOLOGYID");
            AnyError = 1;
            GX_FocusControl = edtBR_PathologyID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtBR_PathologyID_PADate_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency0Z36( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000Z2 */
            pr_default.execute(0, new Object[] {n226BR_PathologyID, A226BR_PathologyID});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BR_Pathology"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z505BR_Pathology_N_Code, T000Z2_A505BR_Pathology_N_Code[0]) != 0 ) || ( StringUtil.StrCmp(Z506BR_Pathology_M_Code, T000Z2_A506BR_Pathology_M_Code[0]) != 0 ) || ( StringUtil.StrCmp(Z508BR_PathologyID_PAHosp_Code, T000Z2_A508BR_PathologyID_PAHosp_Code[0]) != 0 ) || ( Z237BR_PathologyID_TestID != T000Z2_A237BR_PathologyID_TestID[0] ) || ( Z238BR_PathologyID_PADate != T000Z2_A238BR_PathologyID_PADate[0] ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z239BR_PathologyID_PAHosp, T000Z2_A239BR_PathologyID_PAHosp[0]) != 0 ) || ( Z240BR_PathologyID_PAAge != T000Z2_A240BR_PathologyID_PAAge[0] ) || ( StringUtil.StrCmp(Z241BR_PathologyID_PrePaDia, T000Z2_A241BR_PathologyID_PrePaDia[0]) != 0 ) || ( StringUtil.StrCmp(Z242BR_PathologyID_PAResult, T000Z2_A242BR_PathologyID_PAResult[0]) != 0 ) || ( StringUtil.StrCmp(Z326BR_Pathology_Dia_Name, T000Z2_A326BR_Pathology_Dia_Name[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( Z314BR_Pathology_T != T000Z2_A314BR_Pathology_T[0] ) || ( StringUtil.StrCmp(Z315BR_Pathology_N, T000Z2_A315BR_Pathology_N[0]) != 0 ) || ( Z316BR_Pathology_LymphNum != T000Z2_A316BR_Pathology_LymphNum[0] ) || ( StringUtil.StrCmp(Z317BR_Pathology_LymphRate, T000Z2_A317BR_Pathology_LymphRate[0]) != 0 ) || ( StringUtil.StrCmp(Z318BR_Pathology_M, T000Z2_A318BR_Pathology_M[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z319BR_Pathology_MetaLoc, T000Z2_A319BR_Pathology_MetaLoc[0]) != 0 ) || ( Z19BR_EncounterID != T000Z2_A19BR_EncounterID[0] ) )
            {
               if ( StringUtil.StrCmp(Z505BR_Pathology_N_Code, T000Z2_A505BR_Pathology_N_Code[0]) != 0 )
               {
                  GXUtil.WriteLog("br_pathology:[seudo value changed for attri]"+"BR_Pathology_N_Code");
                  GXUtil.WriteLogRaw("Old: ",Z505BR_Pathology_N_Code);
                  GXUtil.WriteLogRaw("Current: ",T000Z2_A505BR_Pathology_N_Code[0]);
               }
               if ( StringUtil.StrCmp(Z506BR_Pathology_M_Code, T000Z2_A506BR_Pathology_M_Code[0]) != 0 )
               {
                  GXUtil.WriteLog("br_pathology:[seudo value changed for attri]"+"BR_Pathology_M_Code");
                  GXUtil.WriteLogRaw("Old: ",Z506BR_Pathology_M_Code);
                  GXUtil.WriteLogRaw("Current: ",T000Z2_A506BR_Pathology_M_Code[0]);
               }
               if ( StringUtil.StrCmp(Z508BR_PathologyID_PAHosp_Code, T000Z2_A508BR_PathologyID_PAHosp_Code[0]) != 0 )
               {
                  GXUtil.WriteLog("br_pathology:[seudo value changed for attri]"+"BR_PathologyID_PAHosp_Code");
                  GXUtil.WriteLogRaw("Old: ",Z508BR_PathologyID_PAHosp_Code);
                  GXUtil.WriteLogRaw("Current: ",T000Z2_A508BR_PathologyID_PAHosp_Code[0]);
               }
               if ( Z237BR_PathologyID_TestID != T000Z2_A237BR_PathologyID_TestID[0] )
               {
                  GXUtil.WriteLog("br_pathology:[seudo value changed for attri]"+"BR_PathologyID_TestID");
                  GXUtil.WriteLogRaw("Old: ",Z237BR_PathologyID_TestID);
                  GXUtil.WriteLogRaw("Current: ",T000Z2_A237BR_PathologyID_TestID[0]);
               }
               if ( Z238BR_PathologyID_PADate != T000Z2_A238BR_PathologyID_PADate[0] )
               {
                  GXUtil.WriteLog("br_pathology:[seudo value changed for attri]"+"BR_PathologyID_PADate");
                  GXUtil.WriteLogRaw("Old: ",Z238BR_PathologyID_PADate);
                  GXUtil.WriteLogRaw("Current: ",T000Z2_A238BR_PathologyID_PADate[0]);
               }
               if ( StringUtil.StrCmp(Z239BR_PathologyID_PAHosp, T000Z2_A239BR_PathologyID_PAHosp[0]) != 0 )
               {
                  GXUtil.WriteLog("br_pathology:[seudo value changed for attri]"+"BR_PathologyID_PAHosp");
                  GXUtil.WriteLogRaw("Old: ",Z239BR_PathologyID_PAHosp);
                  GXUtil.WriteLogRaw("Current: ",T000Z2_A239BR_PathologyID_PAHosp[0]);
               }
               if ( Z240BR_PathologyID_PAAge != T000Z2_A240BR_PathologyID_PAAge[0] )
               {
                  GXUtil.WriteLog("br_pathology:[seudo value changed for attri]"+"BR_PathologyID_PAAge");
                  GXUtil.WriteLogRaw("Old: ",Z240BR_PathologyID_PAAge);
                  GXUtil.WriteLogRaw("Current: ",T000Z2_A240BR_PathologyID_PAAge[0]);
               }
               if ( StringUtil.StrCmp(Z241BR_PathologyID_PrePaDia, T000Z2_A241BR_PathologyID_PrePaDia[0]) != 0 )
               {
                  GXUtil.WriteLog("br_pathology:[seudo value changed for attri]"+"BR_PathologyID_PrePaDia");
                  GXUtil.WriteLogRaw("Old: ",Z241BR_PathologyID_PrePaDia);
                  GXUtil.WriteLogRaw("Current: ",T000Z2_A241BR_PathologyID_PrePaDia[0]);
               }
               if ( StringUtil.StrCmp(Z242BR_PathologyID_PAResult, T000Z2_A242BR_PathologyID_PAResult[0]) != 0 )
               {
                  GXUtil.WriteLog("br_pathology:[seudo value changed for attri]"+"BR_PathologyID_PAResult");
                  GXUtil.WriteLogRaw("Old: ",Z242BR_PathologyID_PAResult);
                  GXUtil.WriteLogRaw("Current: ",T000Z2_A242BR_PathologyID_PAResult[0]);
               }
               if ( StringUtil.StrCmp(Z326BR_Pathology_Dia_Name, T000Z2_A326BR_Pathology_Dia_Name[0]) != 0 )
               {
                  GXUtil.WriteLog("br_pathology:[seudo value changed for attri]"+"BR_Pathology_Dia_Name");
                  GXUtil.WriteLogRaw("Old: ",Z326BR_Pathology_Dia_Name);
                  GXUtil.WriteLogRaw("Current: ",T000Z2_A326BR_Pathology_Dia_Name[0]);
               }
               if ( Z314BR_Pathology_T != T000Z2_A314BR_Pathology_T[0] )
               {
                  GXUtil.WriteLog("br_pathology:[seudo value changed for attri]"+"BR_Pathology_T");
                  GXUtil.WriteLogRaw("Old: ",Z314BR_Pathology_T);
                  GXUtil.WriteLogRaw("Current: ",T000Z2_A314BR_Pathology_T[0]);
               }
               if ( StringUtil.StrCmp(Z315BR_Pathology_N, T000Z2_A315BR_Pathology_N[0]) != 0 )
               {
                  GXUtil.WriteLog("br_pathology:[seudo value changed for attri]"+"BR_Pathology_N");
                  GXUtil.WriteLogRaw("Old: ",Z315BR_Pathology_N);
                  GXUtil.WriteLogRaw("Current: ",T000Z2_A315BR_Pathology_N[0]);
               }
               if ( Z316BR_Pathology_LymphNum != T000Z2_A316BR_Pathology_LymphNum[0] )
               {
                  GXUtil.WriteLog("br_pathology:[seudo value changed for attri]"+"BR_Pathology_LymphNum");
                  GXUtil.WriteLogRaw("Old: ",Z316BR_Pathology_LymphNum);
                  GXUtil.WriteLogRaw("Current: ",T000Z2_A316BR_Pathology_LymphNum[0]);
               }
               if ( StringUtil.StrCmp(Z317BR_Pathology_LymphRate, T000Z2_A317BR_Pathology_LymphRate[0]) != 0 )
               {
                  GXUtil.WriteLog("br_pathology:[seudo value changed for attri]"+"BR_Pathology_LymphRate");
                  GXUtil.WriteLogRaw("Old: ",Z317BR_Pathology_LymphRate);
                  GXUtil.WriteLogRaw("Current: ",T000Z2_A317BR_Pathology_LymphRate[0]);
               }
               if ( StringUtil.StrCmp(Z318BR_Pathology_M, T000Z2_A318BR_Pathology_M[0]) != 0 )
               {
                  GXUtil.WriteLog("br_pathology:[seudo value changed for attri]"+"BR_Pathology_M");
                  GXUtil.WriteLogRaw("Old: ",Z318BR_Pathology_M);
                  GXUtil.WriteLogRaw("Current: ",T000Z2_A318BR_Pathology_M[0]);
               }
               if ( StringUtil.StrCmp(Z319BR_Pathology_MetaLoc, T000Z2_A319BR_Pathology_MetaLoc[0]) != 0 )
               {
                  GXUtil.WriteLog("br_pathology:[seudo value changed for attri]"+"BR_Pathology_MetaLoc");
                  GXUtil.WriteLogRaw("Old: ",Z319BR_Pathology_MetaLoc);
                  GXUtil.WriteLogRaw("Current: ",T000Z2_A319BR_Pathology_MetaLoc[0]);
               }
               if ( Z19BR_EncounterID != T000Z2_A19BR_EncounterID[0] )
               {
                  GXUtil.WriteLog("br_pathology:[seudo value changed for attri]"+"BR_EncounterID");
                  GXUtil.WriteLogRaw("Old: ",Z19BR_EncounterID);
                  GXUtil.WriteLogRaw("Current: ",T000Z2_A19BR_EncounterID[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"BR_Pathology"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0Z36( )
      {
         BeforeValidate0Z36( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0Z36( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0Z36( 0) ;
            CheckOptimisticConcurrency0Z36( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0Z36( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0Z36( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000Z12 */
                     pr_default.execute(10, new Object[] {n505BR_Pathology_N_Code, A505BR_Pathology_N_Code, n506BR_Pathology_M_Code, A506BR_Pathology_M_Code, n508BR_PathologyID_PAHosp_Code, A508BR_PathologyID_PAHosp_Code, n237BR_PathologyID_TestID, A237BR_PathologyID_TestID, n238BR_PathologyID_PADate, A238BR_PathologyID_PADate, n239BR_PathologyID_PAHosp, A239BR_PathologyID_PAHosp, n240BR_PathologyID_PAAge, A240BR_PathologyID_PAAge, n241BR_PathologyID_PrePaDia, A241BR_PathologyID_PrePaDia, n242BR_PathologyID_PAResult, A242BR_PathologyID_PAResult, n326BR_Pathology_Dia_Name, A326BR_Pathology_Dia_Name, n314BR_Pathology_T, A314BR_Pathology_T, n315BR_Pathology_N, A315BR_Pathology_N, n316BR_Pathology_LymphNum, A316BR_Pathology_LymphNum, n317BR_Pathology_LymphRate, A317BR_Pathology_LymphRate, n318BR_Pathology_M, A318BR_Pathology_M, n319BR_Pathology_MetaLoc, A319BR_Pathology_MetaLoc, n19BR_EncounterID, A19BR_EncounterID});
                     A226BR_PathologyID = T000Z12_A226BR_PathologyID[0];
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A226BR_PathologyID", StringUtil.LTrim( StringUtil.Str( (decimal)(A226BR_PathologyID), 18, 0)));
                     n226BR_PathologyID = T000Z12_n226BR_PathologyID[0];
                     pr_default.close(10);
                     dsDefault.SmartCacheProvider.SetUpdated("BR_Pathology") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)),  "就诊信息",  StringUtil.Trim( StringUtil.Str( (decimal)(A226BR_PathologyID), 18, 0)),  "病理学",  "Create",  1) ;
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                           ResetCaption0Z0( ) ;
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
               Load0Z36( ) ;
            }
            EndLevel0Z36( ) ;
         }
         CloseExtendedTableCursors0Z36( ) ;
      }

      protected void Update0Z36( )
      {
         BeforeValidate0Z36( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0Z36( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0Z36( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0Z36( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0Z36( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000Z13 */
                     pr_default.execute(11, new Object[] {n505BR_Pathology_N_Code, A505BR_Pathology_N_Code, n506BR_Pathology_M_Code, A506BR_Pathology_M_Code, n508BR_PathologyID_PAHosp_Code, A508BR_PathologyID_PAHosp_Code, n237BR_PathologyID_TestID, A237BR_PathologyID_TestID, n238BR_PathologyID_PADate, A238BR_PathologyID_PADate, n239BR_PathologyID_PAHosp, A239BR_PathologyID_PAHosp, n240BR_PathologyID_PAAge, A240BR_PathologyID_PAAge, n241BR_PathologyID_PrePaDia, A241BR_PathologyID_PrePaDia, n242BR_PathologyID_PAResult, A242BR_PathologyID_PAResult, n326BR_Pathology_Dia_Name, A326BR_Pathology_Dia_Name, n314BR_Pathology_T, A314BR_Pathology_T, n315BR_Pathology_N, A315BR_Pathology_N, n316BR_Pathology_LymphNum, A316BR_Pathology_LymphNum, n317BR_Pathology_LymphRate, A317BR_Pathology_LymphRate, n318BR_Pathology_M, A318BR_Pathology_M, n319BR_Pathology_MetaLoc, A319BR_Pathology_MetaLoc, n19BR_EncounterID, A19BR_EncounterID, n226BR_PathologyID, A226BR_PathologyID});
                     pr_default.close(11);
                     dsDefault.SmartCacheProvider.SetUpdated("BR_Pathology") ;
                     if ( (pr_default.getStatus(11) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BR_Pathology"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0Z36( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)),  "就诊信息",  StringUtil.Trim( StringUtil.Str( (decimal)(A226BR_PathologyID), 18, 0)),  "病理学",  "Update",  1) ;
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
            EndLevel0Z36( ) ;
         }
         CloseExtendedTableCursors0Z36( ) ;
      }

      protected void DeferredUpdate0Z36( )
      {
      }

      protected void delete( )
      {
         BeforeValidate0Z36( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0Z36( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0Z36( ) ;
            AfterConfirm0Z36( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0Z36( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000Z14 */
                  pr_default.execute(12, new Object[] {n226BR_PathologyID, A226BR_PathologyID});
                  pr_default.close(12);
                  dsDefault.SmartCacheProvider.SetUpdated("BR_Pathology") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)),  "就诊信息",  StringUtil.Trim( StringUtil.Str( (decimal)(A226BR_PathologyID), 18, 0)),  "病理学",  "Delete",  1) ;
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
         sMode36 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel0Z36( ) ;
         Gx_mode = sMode36;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls0Z36( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV17Pgmname = "BR_Pathology";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17Pgmname", AV17Pgmname);
            /* Using cursor T000Z15 */
            pr_default.execute(13, new Object[] {n19BR_EncounterID, A19BR_EncounterID});
            A85BR_Information_ID = T000Z15_A85BR_Information_ID[0];
            n85BR_Information_ID = T000Z15_n85BR_Information_ID[0];
            pr_default.close(13);
            /* Using cursor T000Z16 */
            pr_default.execute(14, new Object[] {n85BR_Information_ID, A85BR_Information_ID});
            A36BR_Information_PatientNo = T000Z16_A36BR_Information_PatientNo[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36BR_Information_PatientNo", A36BR_Information_PatientNo);
            n36BR_Information_PatientNo = T000Z16_n36BR_Information_PatientNo[0];
            pr_default.close(14);
            divUnnamedtable1_Visible = (((StringUtil.StrCmp(A318BR_Pathology_M, "是")==0)) ? 1 : 0);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divUnnamedtable1_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divUnnamedtable1_Visible), 5, 0)), true);
         }
         if ( AnyError == 0 )
         {
            /* Using cursor T000Z17 */
            pr_default.execute(15, new Object[] {n226BR_PathologyID, A226BR_PathologyID});
            if ( (pr_default.getStatus(15) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {" T35"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(15);
            /* Using cursor T000Z18 */
            pr_default.execute(16, new Object[] {n226BR_PathologyID, A226BR_PathologyID});
            if ( (pr_default.getStatus(16) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {" T34"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(16);
            /* Using cursor T000Z19 */
            pr_default.execute(17, new Object[] {n226BR_PathologyID, A226BR_PathologyID});
            if ( (pr_default.getStatus(17) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {" T33"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(17);
         }
      }

      protected void EndLevel0Z36( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0Z36( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(1);
            pr_default.close(13);
            pr_default.close(14);
            context.CommitDataStores("br_pathology",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues0Z0( ) ;
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
            context.RollbackDataStores("br_pathology",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart0Z36( )
      {
         /* Scan By routine */
         /* Using cursor T000Z20 */
         pr_default.execute(18);
         RcdFound36 = 0;
         if ( (pr_default.getStatus(18) != 101) )
         {
            RcdFound36 = 1;
            A226BR_PathologyID = T000Z20_A226BR_PathologyID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A226BR_PathologyID", StringUtil.LTrim( StringUtil.Str( (decimal)(A226BR_PathologyID), 18, 0)));
            n226BR_PathologyID = T000Z20_n226BR_PathologyID[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0Z36( )
      {
         /* Scan next routine */
         pr_default.readNext(18);
         RcdFound36 = 0;
         if ( (pr_default.getStatus(18) != 101) )
         {
            RcdFound36 = 1;
            A226BR_PathologyID = T000Z20_A226BR_PathologyID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A226BR_PathologyID", StringUtil.LTrim( StringUtil.Str( (decimal)(A226BR_PathologyID), 18, 0)));
            n226BR_PathologyID = T000Z20_n226BR_PathologyID[0];
         }
      }

      protected void ScanEnd0Z36( )
      {
         pr_default.close(18);
      }

      protected void AfterConfirm0Z36( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0Z36( )
      {
         /* Before Insert Rules */
         GXt_char1 = A508BR_PathologyID_PAHosp_Code;
         new zutil_findtargetcode(context ).execute(  32,  A239BR_PathologyID_PAHosp, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A239BR_PathologyID_PAHosp", A239BR_PathologyID_PAHosp);
         A508BR_PathologyID_PAHosp_Code = GXt_char1;
         n508BR_PathologyID_PAHosp_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A508BR_PathologyID_PAHosp_Code", A508BR_PathologyID_PAHosp_Code);
         GXt_char1 = A505BR_Pathology_N_Code;
         new zutil_findtargetcode(context ).execute(  37,  A315BR_Pathology_N, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A315BR_Pathology_N", A315BR_Pathology_N);
         A505BR_Pathology_N_Code = GXt_char1;
         n505BR_Pathology_N_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A505BR_Pathology_N_Code", A505BR_Pathology_N_Code);
         GXt_char1 = A506BR_Pathology_M_Code;
         new zutil_findtargetcode(context ).execute(  37,  A318BR_Pathology_M, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A318BR_Pathology_M", A318BR_Pathology_M);
         A506BR_Pathology_M_Code = GXt_char1;
         n506BR_Pathology_M_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A506BR_Pathology_M_Code", A506BR_Pathology_M_Code);
      }

      protected void BeforeUpdate0Z36( )
      {
         /* Before Update Rules */
         GXt_char1 = A508BR_PathologyID_PAHosp_Code;
         new zutil_findtargetcode(context ).execute(  32,  A239BR_PathologyID_PAHosp, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A239BR_PathologyID_PAHosp", A239BR_PathologyID_PAHosp);
         A508BR_PathologyID_PAHosp_Code = GXt_char1;
         n508BR_PathologyID_PAHosp_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A508BR_PathologyID_PAHosp_Code", A508BR_PathologyID_PAHosp_Code);
         GXt_char1 = A505BR_Pathology_N_Code;
         new zutil_findtargetcode(context ).execute(  37,  A315BR_Pathology_N, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A315BR_Pathology_N", A315BR_Pathology_N);
         A505BR_Pathology_N_Code = GXt_char1;
         n505BR_Pathology_N_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A505BR_Pathology_N_Code", A505BR_Pathology_N_Code);
         GXt_char1 = A506BR_Pathology_M_Code;
         new zutil_findtargetcode(context ).execute(  37,  A318BR_Pathology_M, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A318BR_Pathology_M", A318BR_Pathology_M);
         A506BR_Pathology_M_Code = GXt_char1;
         n506BR_Pathology_M_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A506BR_Pathology_M_Code", A506BR_Pathology_M_Code);
      }

      protected void BeforeDelete0Z36( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0Z36( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0Z36( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0Z36( )
      {
         edtBR_PathologyID_PADate_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_PathologyID_PADate_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_PathologyID_PADate_Enabled), 5, 0)), true);
         edtBR_PathologyID_PAAge_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_PathologyID_PAAge_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_PathologyID_PAAge_Enabled), 5, 0)), true);
         dynBR_PathologyID_PAHosp.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynBR_PathologyID_PAHosp_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynBR_PathologyID_PAHosp.Enabled), 5, 0)), true);
         edtBR_Pathology_Dia_Name_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Pathology_Dia_Name_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Pathology_Dia_Name_Enabled), 5, 0)), true);
         edtBR_PathologyID_PAResult_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_PathologyID_PAResult_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_PathologyID_PAResult_Enabled), 5, 0)), true);
         edtBR_PathologyID_PrePaDia_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_PathologyID_PrePaDia_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_PathologyID_PrePaDia_Enabled), 5, 0)), true);
         edtBR_Pathology_T_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Pathology_T_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Pathology_T_Enabled), 5, 0)), true);
         cmbBR_Pathology_N.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Pathology_N_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbBR_Pathology_N.Enabled), 5, 0)), true);
         edtBR_Pathology_LymphNum_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Pathology_LymphNum_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Pathology_LymphNum_Enabled), 5, 0)), true);
         edtBR_Pathology_LymphRate_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Pathology_LymphRate_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Pathology_LymphRate_Enabled), 5, 0)), true);
         cmbBR_Pathology_M.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Pathology_M_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbBR_Pathology_M.Enabled), 5, 0)), true);
         edtBR_Pathology_MetaLoc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Pathology_MetaLoc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Pathology_MetaLoc_Enabled), 5, 0)), true);
         edtBR_PathologyID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_PathologyID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_PathologyID_Enabled), 5, 0)), true);
         edtBR_EncounterID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_EncounterID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_EncounterID_Enabled), 5, 0)), true);
         edtBR_Information_PatientNo_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Information_PatientNo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Information_PatientNo_Enabled), 5, 0)), true);
         edtBR_PathologyID_TestID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_PathologyID_TestID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_PathologyID_TestID_Enabled), 5, 0)), true);
      }

      protected void send_integrity_lvl_hashes0Z36( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues0Z0( )
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
         context.AddJavascriptSource("gxcfg.js", "?20202279382630", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_pathology.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7BR_PathologyID)+"\">") ;
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
         forbiddenHiddens = "hsh" + "BR_Pathology";
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A226BR_PathologyID), "ZZZZZZZZZZZZZZZZZZ");
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( AV16tCurrentCode, ""));
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV13Insert_BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ");
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("br_pathology:[SendSecurityCheck value for]"+"BR_PathologyID:"+context.localUtil.Format( (decimal)(A226BR_PathologyID), "ZZZZZZZZZZZZZZZZZZ"));
         GXUtil.WriteLog("br_pathology:[SendSecurityCheck value for]"+"tCurrentCode:"+StringUtil.RTrim( context.localUtil.Format( AV16tCurrentCode, "")));
         GXUtil.WriteLog("br_pathology:[SendSecurityCheck value for]"+"Insert_BR_EncounterID:"+context.localUtil.Format( (decimal)(AV13Insert_BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ"));
         GXUtil.WriteLog("br_pathology:[SendSecurityCheck value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z226BR_PathologyID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z226BR_PathologyID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z505BR_Pathology_N_Code", Z505BR_Pathology_N_Code);
         GxWebStd.gx_hidden_field( context, "Z506BR_Pathology_M_Code", Z506BR_Pathology_M_Code);
         GxWebStd.gx_hidden_field( context, "Z508BR_PathologyID_PAHosp_Code", Z508BR_PathologyID_PAHosp_Code);
         GxWebStd.gx_hidden_field( context, "Z237BR_PathologyID_TestID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z237BR_PathologyID_TestID), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z238BR_PathologyID_PADate", context.localUtil.DToC( Z238BR_PathologyID_PADate, 0, "/"));
         GxWebStd.gx_hidden_field( context, "Z239BR_PathologyID_PAHosp", Z239BR_PathologyID_PAHosp);
         GxWebStd.gx_hidden_field( context, "Z240BR_PathologyID_PAAge", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z240BR_PathologyID_PAAge), 3, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z241BR_PathologyID_PrePaDia", Z241BR_PathologyID_PrePaDia);
         GxWebStd.gx_hidden_field( context, "Z242BR_PathologyID_PAResult", Z242BR_PathologyID_PAResult);
         GxWebStd.gx_hidden_field( context, "Z326BR_Pathology_Dia_Name", Z326BR_Pathology_Dia_Name);
         GxWebStd.gx_hidden_field( context, "Z314BR_Pathology_T", StringUtil.LTrim( StringUtil.NToC( Z314BR_Pathology_T, 15, 5, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z315BR_Pathology_N", Z315BR_Pathology_N);
         GxWebStd.gx_hidden_field( context, "Z316BR_Pathology_LymphNum", StringUtil.LTrim( StringUtil.NToC( Z316BR_Pathology_LymphNum, 15, 5, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z317BR_Pathology_LymphRate", Z317BR_Pathology_LymphRate);
         GxWebStd.gx_hidden_field( context, "Z318BR_Pathology_M", Z318BR_Pathology_M);
         GxWebStd.gx_hidden_field( context, "Z319BR_Pathology_MetaLoc", Z319BR_Pathology_MetaLoc);
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
         GxWebStd.gx_hidden_field( context, "vBR_PATHOLOGYID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7BR_PathologyID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vBR_PATHOLOGYID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7BR_PathologyID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, "vINSERT_BR_ENCOUNTERID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13Insert_BR_EncounterID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "BR_PATHOLOGY_N_CODE", A505BR_Pathology_N_Code);
         GxWebStd.gx_hidden_field( context, "BR_PATHOLOGY_M_CODE", A506BR_Pathology_M_Code);
         GxWebStd.gx_hidden_field( context, "BR_PATHOLOGYID_PAHOSP_CODE", A508BR_PathologyID_PAHosp_Code);
         GxWebStd.gx_hidden_field( context, "vTCURRENTCODE", AV16tCurrentCode);
         GxWebStd.gx_hidden_field( context, "BR_INFORMATION_ID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A85BR_Information_ID), 18, 0, ".", "")));
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
         return formatLink("br_pathology.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7BR_PathologyID) ;
      }

      public override String GetPgmname( )
      {
         return "BR_Pathology" ;
      }

      public override String GetPgmdesc( )
      {
         return "Data Mgmt Portal - RAAP" ;
      }

      protected void InitializeNonKey0Z36( )
      {
         A85BR_Information_ID = 0;
         n85BR_Information_ID = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A85BR_Information_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A85BR_Information_ID), 18, 0)));
         A19BR_EncounterID = 0;
         n19BR_EncounterID = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
         n19BR_EncounterID = ((0==A19BR_EncounterID) ? true : false);
         A505BR_Pathology_N_Code = "";
         n505BR_Pathology_N_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A505BR_Pathology_N_Code", A505BR_Pathology_N_Code);
         A506BR_Pathology_M_Code = "";
         n506BR_Pathology_M_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A506BR_Pathology_M_Code", A506BR_Pathology_M_Code);
         A508BR_PathologyID_PAHosp_Code = "";
         n508BR_PathologyID_PAHosp_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A508BR_PathologyID_PAHosp_Code", A508BR_PathologyID_PAHosp_Code);
         A36BR_Information_PatientNo = "";
         n36BR_Information_PatientNo = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36BR_Information_PatientNo", A36BR_Information_PatientNo);
         A237BR_PathologyID_TestID = 0;
         n237BR_PathologyID_TestID = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A237BR_PathologyID_TestID", StringUtil.LTrim( StringUtil.Str( (decimal)(A237BR_PathologyID_TestID), 10, 0)));
         n237BR_PathologyID_TestID = ((0==A237BR_PathologyID_TestID) ? true : false);
         A238BR_PathologyID_PADate = DateTime.MinValue;
         n238BR_PathologyID_PADate = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A238BR_PathologyID_PADate", context.localUtil.Format(A238BR_PathologyID_PADate, "9999/99/99"));
         n238BR_PathologyID_PADate = ((DateTime.MinValue==A238BR_PathologyID_PADate) ? true : false);
         A239BR_PathologyID_PAHosp = "";
         n239BR_PathologyID_PAHosp = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A239BR_PathologyID_PAHosp", A239BR_PathologyID_PAHosp);
         n239BR_PathologyID_PAHosp = (String.IsNullOrEmpty(StringUtil.RTrim( A239BR_PathologyID_PAHosp)) ? true : false);
         A240BR_PathologyID_PAAge = 0;
         n240BR_PathologyID_PAAge = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A240BR_PathologyID_PAAge", StringUtil.LTrim( StringUtil.Str( (decimal)(A240BR_PathologyID_PAAge), 3, 0)));
         n240BR_PathologyID_PAAge = ((0==A240BR_PathologyID_PAAge) ? true : false);
         A241BR_PathologyID_PrePaDia = "";
         n241BR_PathologyID_PrePaDia = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A241BR_PathologyID_PrePaDia", A241BR_PathologyID_PrePaDia);
         n241BR_PathologyID_PrePaDia = (String.IsNullOrEmpty(StringUtil.RTrim( A241BR_PathologyID_PrePaDia)) ? true : false);
         A242BR_PathologyID_PAResult = "";
         n242BR_PathologyID_PAResult = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A242BR_PathologyID_PAResult", A242BR_PathologyID_PAResult);
         n242BR_PathologyID_PAResult = (String.IsNullOrEmpty(StringUtil.RTrim( A242BR_PathologyID_PAResult)) ? true : false);
         A326BR_Pathology_Dia_Name = "";
         n326BR_Pathology_Dia_Name = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A326BR_Pathology_Dia_Name", A326BR_Pathology_Dia_Name);
         n326BR_Pathology_Dia_Name = (String.IsNullOrEmpty(StringUtil.RTrim( A326BR_Pathology_Dia_Name)) ? true : false);
         A314BR_Pathology_T = 0;
         n314BR_Pathology_T = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A314BR_Pathology_T", StringUtil.LTrim( StringUtil.Str( A314BR_Pathology_T, 15, 5)));
         n314BR_Pathology_T = ((Convert.ToDecimal(0)==A314BR_Pathology_T) ? true : false);
         A315BR_Pathology_N = "";
         n315BR_Pathology_N = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A315BR_Pathology_N", A315BR_Pathology_N);
         n315BR_Pathology_N = (String.IsNullOrEmpty(StringUtil.RTrim( A315BR_Pathology_N)) ? true : false);
         A316BR_Pathology_LymphNum = 0;
         n316BR_Pathology_LymphNum = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A316BR_Pathology_LymphNum", StringUtil.LTrim( StringUtil.Str( A316BR_Pathology_LymphNum, 15, 5)));
         n316BR_Pathology_LymphNum = ((Convert.ToDecimal(0)==A316BR_Pathology_LymphNum) ? true : false);
         A317BR_Pathology_LymphRate = "";
         n317BR_Pathology_LymphRate = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A317BR_Pathology_LymphRate", A317BR_Pathology_LymphRate);
         n317BR_Pathology_LymphRate = (String.IsNullOrEmpty(StringUtil.RTrim( A317BR_Pathology_LymphRate)) ? true : false);
         A318BR_Pathology_M = "";
         n318BR_Pathology_M = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A318BR_Pathology_M", A318BR_Pathology_M);
         n318BR_Pathology_M = (String.IsNullOrEmpty(StringUtil.RTrim( A318BR_Pathology_M)) ? true : false);
         A319BR_Pathology_MetaLoc = "";
         n319BR_Pathology_MetaLoc = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A319BR_Pathology_MetaLoc", A319BR_Pathology_MetaLoc);
         n319BR_Pathology_MetaLoc = (String.IsNullOrEmpty(StringUtil.RTrim( A319BR_Pathology_MetaLoc)) ? true : false);
         Z505BR_Pathology_N_Code = "";
         Z506BR_Pathology_M_Code = "";
         Z508BR_PathologyID_PAHosp_Code = "";
         Z237BR_PathologyID_TestID = 0;
         Z238BR_PathologyID_PADate = DateTime.MinValue;
         Z239BR_PathologyID_PAHosp = "";
         Z240BR_PathologyID_PAAge = 0;
         Z241BR_PathologyID_PrePaDia = "";
         Z242BR_PathologyID_PAResult = "";
         Z326BR_Pathology_Dia_Name = "";
         Z314BR_Pathology_T = 0;
         Z315BR_Pathology_N = "";
         Z316BR_Pathology_LymphNum = 0;
         Z317BR_Pathology_LymphRate = "";
         Z318BR_Pathology_M = "";
         Z319BR_Pathology_MetaLoc = "";
         Z19BR_EncounterID = 0;
      }

      protected void InitAll0Z36( )
      {
         A226BR_PathologyID = 0;
         n226BR_PathologyID = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A226BR_PathologyID", StringUtil.LTrim( StringUtil.Str( (decimal)(A226BR_PathologyID), 18, 0)));
         InitializeNonKey0Z36( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20202279382679", true);
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
         context.AddJavascriptSource("br_pathology.js", "?20202279382679", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         lblTextblockbr_pathologyid_padate_Internalname = "TEXTBLOCKBR_PATHOLOGYID_PADATE";
         edtBR_PathologyID_PADate_Internalname = "BR_PATHOLOGYID_PADATE";
         divUnnamedtablebr_pathologyid_padate_Internalname = "UNNAMEDTABLEBR_PATHOLOGYID_PADATE";
         lblTextblockbr_pathologyid_paage_Internalname = "TEXTBLOCKBR_PATHOLOGYID_PAAGE";
         edtBR_PathologyID_PAAge_Internalname = "BR_PATHOLOGYID_PAAGE";
         divUnnamedtablebr_pathologyid_paage_Internalname = "UNNAMEDTABLEBR_PATHOLOGYID_PAAGE";
         lblTextblockbr_pathologyid_pahosp_Internalname = "TEXTBLOCKBR_PATHOLOGYID_PAHOSP";
         dynBR_PathologyID_PAHosp_Internalname = "BR_PATHOLOGYID_PAHOSP";
         divUnnamedtablebr_pathologyid_pahosp_Internalname = "UNNAMEDTABLEBR_PATHOLOGYID_PAHOSP";
         lblTextblockbr_pathology_dia_name_Internalname = "TEXTBLOCKBR_PATHOLOGY_DIA_NAME";
         edtBR_Pathology_Dia_Name_Internalname = "BR_PATHOLOGY_DIA_NAME";
         divUnnamedtablebr_pathology_dia_name_Internalname = "UNNAMEDTABLEBR_PATHOLOGY_DIA_NAME";
         lblTextblockbr_pathologyid_paresult_Internalname = "TEXTBLOCKBR_PATHOLOGYID_PARESULT";
         edtBR_PathologyID_PAResult_Internalname = "BR_PATHOLOGYID_PARESULT";
         divUnnamedtablebr_pathologyid_paresult_Internalname = "UNNAMEDTABLEBR_PATHOLOGYID_PARESULT";
         lblTextblockbr_pathologyid_prepadia_Internalname = "TEXTBLOCKBR_PATHOLOGYID_PREPADIA";
         edtBR_PathologyID_PrePaDia_Internalname = "BR_PATHOLOGYID_PREPADIA";
         divUnnamedtablebr_pathologyid_prepadia_Internalname = "UNNAMEDTABLEBR_PATHOLOGYID_PREPADIA";
         lblTextblockbr_pathology_t_Internalname = "TEXTBLOCKBR_PATHOLOGY_T";
         edtBR_Pathology_T_Internalname = "BR_PATHOLOGY_T";
         divUnnamedtablebr_pathology_t_Internalname = "UNNAMEDTABLEBR_PATHOLOGY_T";
         lblTextblockbr_pathology_n_Internalname = "TEXTBLOCKBR_PATHOLOGY_N";
         cmbBR_Pathology_N_Internalname = "BR_PATHOLOGY_N";
         divUnnamedtablebr_pathology_n_Internalname = "UNNAMEDTABLEBR_PATHOLOGY_N";
         lblTextblockbr_pathology_lymphnum_Internalname = "TEXTBLOCKBR_PATHOLOGY_LYMPHNUM";
         edtBR_Pathology_LymphNum_Internalname = "BR_PATHOLOGY_LYMPHNUM";
         divUnnamedtablebr_pathology_lymphnum_Internalname = "UNNAMEDTABLEBR_PATHOLOGY_LYMPHNUM";
         lblTextblockbr_pathology_lymphrate_Internalname = "TEXTBLOCKBR_PATHOLOGY_LYMPHRATE";
         edtBR_Pathology_LymphRate_Internalname = "BR_PATHOLOGY_LYMPHRATE";
         divUnnamedtablebr_pathology_lymphrate_Internalname = "UNNAMEDTABLEBR_PATHOLOGY_LYMPHRATE";
         lblTextblockbr_pathology_m_Internalname = "TEXTBLOCKBR_PATHOLOGY_M";
         cmbBR_Pathology_M_Internalname = "BR_PATHOLOGY_M";
         divUnnamedtablebr_pathology_m_Internalname = "UNNAMEDTABLEBR_PATHOLOGY_M";
         lblTextblockbr_pathology_metaloc_Internalname = "TEXTBLOCKBR_PATHOLOGY_METALOC";
         edtBR_Pathology_MetaLoc_Internalname = "BR_PATHOLOGY_METALOC";
         divUnnamedtablebr_pathology_metaloc_Internalname = "UNNAMEDTABLEBR_PATHOLOGY_METALOC";
         divUnnamedtable1_Internalname = "UNNAMEDTABLE1";
         divTableattributes_Internalname = "TABLEATTRIBUTES";
         divLayout_tableattributes_Internalname = "LAYOUT_TABLEATTRIBUTES";
         Dvpanel_tableattributes_Internalname = "DVPANEL_TABLEATTRIBUTES";
         divHtml_dvpanel_tableattributes_Internalname = "HTML_DVPANEL_TABLEATTRIBUTES";
         divTablecontent_Internalname = "TABLECONTENT";
         bttBtntrn_enter_Internalname = "BTNTRN_ENTER";
         bttBtntrn_cancel_Internalname = "BTNTRN_CANCEL";
         bttBtntrn_delete_Internalname = "BTNTRN_DELETE";
         divTablemain_Internalname = "TABLEMAIN";
         edtBR_PathologyID_Internalname = "BR_PATHOLOGYID";
         edtBR_EncounterID_Internalname = "BR_ENCOUNTERID";
         edtBR_Information_PatientNo_Internalname = "BR_INFORMATION_PATIENTNO";
         edtBR_PathologyID_TestID_Internalname = "BR_PATHOLOGYID_TESTID";
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
         edtBR_PathologyID_TestID_Jsonclick = "";
         edtBR_PathologyID_TestID_Enabled = 1;
         edtBR_PathologyID_TestID_Visible = 1;
         edtBR_Information_PatientNo_Jsonclick = "";
         edtBR_Information_PatientNo_Enabled = 0;
         edtBR_Information_PatientNo_Visible = 1;
         edtBR_EncounterID_Jsonclick = "";
         edtBR_EncounterID_Enabled = 1;
         edtBR_EncounterID_Visible = 1;
         edtBR_PathologyID_Jsonclick = "";
         edtBR_PathologyID_Enabled = 0;
         edtBR_PathologyID_Visible = 1;
         bttBtntrn_delete_Enabled = 0;
         bttBtntrn_delete_Visible = 1;
         bttBtntrn_cancel_Visible = 1;
         bttBtntrn_enter_Enabled = 1;
         bttBtntrn_enter_Visible = 1;
         edtBR_Pathology_MetaLoc_Jsonclick = "";
         edtBR_Pathology_MetaLoc_Enabled = 1;
         divUnnamedtable1_Visible = 1;
         cmbBR_Pathology_M_Jsonclick = "";
         cmbBR_Pathology_M.Enabled = 1;
         edtBR_Pathology_LymphRate_Jsonclick = "";
         edtBR_Pathology_LymphRate_Enabled = 1;
         edtBR_Pathology_LymphNum_Jsonclick = "";
         edtBR_Pathology_LymphNum_Enabled = 1;
         cmbBR_Pathology_N_Jsonclick = "";
         cmbBR_Pathology_N.Enabled = 1;
         edtBR_Pathology_T_Jsonclick = "";
         edtBR_Pathology_T_Enabled = 1;
         edtBR_PathologyID_PrePaDia_Enabled = 1;
         edtBR_PathologyID_PAResult_Enabled = 1;
         edtBR_Pathology_Dia_Name_Enabled = 1;
         dynBR_PathologyID_PAHosp_Jsonclick = "";
         dynBR_PathologyID_PAHosp.Enabled = 1;
         edtBR_PathologyID_PAAge_Jsonclick = "";
         edtBR_PathologyID_PAAge_Enabled = 1;
         edtBR_PathologyID_PADate_Jsonclick = "";
         edtBR_PathologyID_PADate_Enabled = 1;
         Dvpanel_tableattributes_Autoscroll = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Iconposition = "left";
         Dvpanel_tableattributes_Showcollapseicon = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsed = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsible = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Title = "病理学";
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

      protected void GXDLABR_PATHOLOGYID_PAHOSP0Z36( String AV16tCurrentCode )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLABR_PATHOLOGYID_PAHOSP_data0Z36( AV16tCurrentCode) ;
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

      protected void GXABR_PATHOLOGYID_PAHOSP_html0Z36( String AV16tCurrentCode )
      {
         String gxdynajaxvalue ;
         GXDLABR_PATHOLOGYID_PAHOSP_data0Z36( AV16tCurrentCode) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynBR_PathologyID_PAHosp.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex));
            dynBR_PathologyID_PAHosp.addItem(gxdynajaxvalue, ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLABR_PATHOLOGYID_PAHOSP_data0Z36( String AV16tCurrentCode )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add("");
         gxdynajaxctrldescr.Add("(请选择)");
         /* Using cursor T000Z21 */
         pr_default.execute(19, new Object[] {AV16tCurrentCode});
         while ( (pr_default.getStatus(19) != 101) )
         {
            gxdynajaxctrlcodr.Add(T000Z21_A168XT_DefineCodeName[0]);
            gxdynajaxctrldescr.Add(T000Z21_A168XT_DefineCodeName[0]);
            pr_default.readNext(19);
         }
         pr_default.close(19);
      }

      protected void GX11ASABR_PATHOLOGY_N_CODE0Z36( String A315BR_Pathology_N )
      {
         GXt_char1 = A505BR_Pathology_N_Code;
         new zutil_findtargetcode(context ).execute(  37,  A315BR_Pathology_N, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A315BR_Pathology_N", A315BR_Pathology_N);
         A505BR_Pathology_N_Code = GXt_char1;
         n505BR_Pathology_N_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A505BR_Pathology_N_Code", A505BR_Pathology_N_Code);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A505BR_Pathology_N_Code)+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GX12ASABR_PATHOLOGY_N_CODE0Z36( String A315BR_Pathology_N )
      {
         GXt_char1 = A505BR_Pathology_N_Code;
         new zutil_findtargetcode(context ).execute(  37,  A315BR_Pathology_N, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A315BR_Pathology_N", A315BR_Pathology_N);
         A505BR_Pathology_N_Code = GXt_char1;
         n505BR_Pathology_N_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A505BR_Pathology_N_Code", A505BR_Pathology_N_Code);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A505BR_Pathology_N_Code)+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GX13ASABR_PATHOLOGY_M_CODE0Z36( String A318BR_Pathology_M )
      {
         GXt_char1 = A506BR_Pathology_M_Code;
         new zutil_findtargetcode(context ).execute(  37,  A318BR_Pathology_M, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A318BR_Pathology_M", A318BR_Pathology_M);
         A506BR_Pathology_M_Code = GXt_char1;
         n506BR_Pathology_M_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A506BR_Pathology_M_Code", A506BR_Pathology_M_Code);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A506BR_Pathology_M_Code)+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GX14ASABR_PATHOLOGY_M_CODE0Z36( String A318BR_Pathology_M )
      {
         GXt_char1 = A506BR_Pathology_M_Code;
         new zutil_findtargetcode(context ).execute(  37,  A318BR_Pathology_M, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A318BR_Pathology_M", A318BR_Pathology_M);
         A506BR_Pathology_M_Code = GXt_char1;
         n506BR_Pathology_M_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A506BR_Pathology_M_Code", A506BR_Pathology_M_Code);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A506BR_Pathology_M_Code)+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GX15ASABR_PATHOLOGYID_PAHOSP_CODE0Z36( String A239BR_PathologyID_PAHosp )
      {
         GXt_char1 = A508BR_PathologyID_PAHosp_Code;
         new zutil_findtargetcode(context ).execute(  32,  A239BR_PathologyID_PAHosp, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A239BR_PathologyID_PAHosp", A239BR_PathologyID_PAHosp);
         A508BR_PathologyID_PAHosp_Code = GXt_char1;
         n508BR_PathologyID_PAHosp_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A508BR_PathologyID_PAHosp_Code", A508BR_PathologyID_PAHosp_Code);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A508BR_PathologyID_PAHosp_Code)+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GX16ASABR_PATHOLOGYID_PAHOSP_CODE0Z36( String A239BR_PathologyID_PAHosp )
      {
         GXt_char1 = A508BR_PathologyID_PAHosp_Code;
         new zutil_findtargetcode(context ).execute(  32,  A239BR_PathologyID_PAHosp, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A239BR_PathologyID_PAHosp", A239BR_PathologyID_PAHosp);
         A508BR_PathologyID_PAHosp_Code = GXt_char1;
         n508BR_PathologyID_PAHosp_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A508BR_PathologyID_PAHosp_Code", A508BR_PathologyID_PAHosp_Code);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A508BR_PathologyID_PAHosp_Code)+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void XC_22_0Z36( )
      {
         new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)),  "就诊信息",  StringUtil.Trim( StringUtil.Str( (decimal)(A226BR_PathologyID), 18, 0)),  "病理学",  "Create",  1) ;
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

      protected void XC_23_0Z36( )
      {
         new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)),  "就诊信息",  StringUtil.Trim( StringUtil.Str( (decimal)(A226BR_PathologyID), 18, 0)),  "病理学",  "Update",  1) ;
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

      protected void XC_24_0Z36( )
      {
         new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)),  "就诊信息",  StringUtil.Trim( StringUtil.Str( (decimal)(A226BR_PathologyID), 18, 0)),  "病理学",  "Delete",  1) ;
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
         dynBR_PathologyID_PAHosp.Name = "BR_PATHOLOGYID_PAHOSP";
         dynBR_PathologyID_PAHosp.WebTags = "";
         cmbBR_Pathology_N.Name = "BR_PATHOLOGY_N";
         cmbBR_Pathology_N.WebTags = "";
         cmbBR_Pathology_N.addItem("", "(请选择)", 0);
         cmbBR_Pathology_N.addItem("否", "否", 0);
         cmbBR_Pathology_N.addItem("是", "是", 0);
         cmbBR_Pathology_N.addItem("不详", "不详", 0);
         if ( cmbBR_Pathology_N.ItemCount > 0 )
         {
            A315BR_Pathology_N = cmbBR_Pathology_N.getValidValue(A315BR_Pathology_N);
            n315BR_Pathology_N = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A315BR_Pathology_N", A315BR_Pathology_N);
         }
         cmbBR_Pathology_M.Name = "BR_PATHOLOGY_M";
         cmbBR_Pathology_M.WebTags = "";
         cmbBR_Pathology_M.addItem("", "(请选择)", 0);
         cmbBR_Pathology_M.addItem("否", "否", 0);
         cmbBR_Pathology_M.addItem("是", "是", 0);
         cmbBR_Pathology_M.addItem("不详", "不详", 0);
         if ( cmbBR_Pathology_M.ItemCount > 0 )
         {
            A318BR_Pathology_M = cmbBR_Pathology_M.getValidValue(A318BR_Pathology_M);
            n318BR_Pathology_M = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A318BR_Pathology_M", A318BR_Pathology_M);
         }
         /* End function init_web_controls */
      }

      public void Valid_Br_encounterid( long GX_Parm1 ,
                                        long GX_Parm2 ,
                                        String GX_Parm3 )
      {
         A19BR_EncounterID = GX_Parm1;
         n19BR_EncounterID = false;
         A85BR_Information_ID = GX_Parm2;
         n85BR_Information_ID = false;
         A36BR_Information_PatientNo = GX_Parm3;
         n36BR_Information_PatientNo = false;
         /* Using cursor T000Z22 */
         pr_default.execute(20, new Object[] {n19BR_EncounterID, A19BR_EncounterID});
         if ( (pr_default.getStatus(20) == 101) )
         {
            if ( ! ( (0==A19BR_EncounterID) ) )
            {
               GX_msglist.addItem("不匹配' T15'", "ForeignKeyNotFound", 1, "BR_ENCOUNTERID");
               AnyError = 1;
               GX_FocusControl = edtBR_EncounterID_Internalname;
            }
         }
         A85BR_Information_ID = T000Z22_A85BR_Information_ID[0];
         n85BR_Information_ID = T000Z22_n85BR_Information_ID[0];
         pr_default.close(20);
         /* Using cursor T000Z23 */
         pr_default.execute(21, new Object[] {n85BR_Information_ID, A85BR_Information_ID});
         if ( (pr_default.getStatus(21) == 101) )
         {
            if ( ! ( (0==A85BR_Information_ID) ) )
            {
               GX_msglist.addItem("不匹配' T16'", "ForeignKeyNotFound", 1, "");
               AnyError = 1;
            }
         }
         A36BR_Information_PatientNo = T000Z23_A36BR_Information_PatientNo[0];
         n36BR_Information_PatientNo = T000Z23_n36BR_Information_PatientNo[0];
         pr_default.close(21);
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
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7BR_PathologyID',fld:'vBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7BR_PathologyID',fld:'vBR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'A226BR_PathologyID',fld:'BR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV16tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'AV13Insert_BR_EncounterID',fld:'vINSERT_BR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("AFTER TRN","{handler:'E120Z2',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV11TrnContext',fld:'vTRNCONTEXT',pic:''},{av:'A226BR_PathologyID',fld:'BR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'}]");
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
         pr_default.close(20);
         pr_default.close(13);
         pr_default.close(21);
         pr_default.close(14);
      }

      public override void initialize( )
      {
         sPrefix = "";
         wcpOGx_mode = "";
         Z505BR_Pathology_N_Code = "";
         Z506BR_Pathology_M_Code = "";
         Z508BR_PathologyID_PAHosp_Code = "";
         Z238BR_PathologyID_PADate = DateTime.MinValue;
         Z239BR_PathologyID_PAHosp = "";
         Z241BR_PathologyID_PrePaDia = "";
         Z242BR_PathologyID_PAResult = "";
         Z326BR_Pathology_Dia_Name = "";
         Z315BR_Pathology_N = "";
         Z317BR_Pathology_LymphRate = "";
         Z318BR_Pathology_M = "";
         Z319BR_Pathology_MetaLoc = "";
         scmdbuf = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV16tCurrentCode = "";
         A315BR_Pathology_N = "";
         A318BR_Pathology_M = "";
         A239BR_PathologyID_PAHosp = "";
         GXKey = "";
         PreviousTooltip = "";
         PreviousCaption = "";
         Form = new GXWebForm();
         GX_FocusControl = "";
         ClassString = "";
         StyleString = "";
         ucDvpanel_tableattributes = new GXUserControl();
         lblTextblockbr_pathologyid_padate_Jsonclick = "";
         TempTags = "";
         A238BR_PathologyID_PADate = DateTime.MinValue;
         lblTextblockbr_pathologyid_paage_Jsonclick = "";
         lblTextblockbr_pathologyid_pahosp_Jsonclick = "";
         lblTextblockbr_pathology_dia_name_Jsonclick = "";
         A326BR_Pathology_Dia_Name = "";
         lblTextblockbr_pathologyid_paresult_Jsonclick = "";
         A242BR_PathologyID_PAResult = "";
         lblTextblockbr_pathologyid_prepadia_Jsonclick = "";
         A241BR_PathologyID_PrePaDia = "";
         lblTextblockbr_pathology_t_Jsonclick = "";
         lblTextblockbr_pathology_n_Jsonclick = "";
         lblTextblockbr_pathology_lymphnum_Jsonclick = "";
         lblTextblockbr_pathology_lymphrate_Jsonclick = "";
         A317BR_Pathology_LymphRate = "";
         lblTextblockbr_pathology_m_Jsonclick = "";
         lblTextblockbr_pathology_metaloc_Jsonclick = "";
         A319BR_Pathology_MetaLoc = "";
         bttBtntrn_enter_Jsonclick = "";
         bttBtntrn_cancel_Jsonclick = "";
         bttBtntrn_delete_Jsonclick = "";
         A36BR_Information_PatientNo = "";
         A505BR_Pathology_N_Code = "";
         A506BR_Pathology_M_Code = "";
         A508BR_PathologyID_PAHosp_Code = "";
         AV17Pgmname = "";
         Dvpanel_tableattributes_Objectcall = "";
         Dvpanel_tableattributes_Class = "";
         Dvpanel_tableattributes_Height = "";
         forbiddenHiddens = "";
         hsh = "";
         sMode36 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV8WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV11TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV12WebSession = context.GetSession();
         AV14TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         Z36BR_Information_PatientNo = "";
         T000Z4_A85BR_Information_ID = new long[1] ;
         T000Z4_n85BR_Information_ID = new bool[] {false} ;
         T000Z5_A36BR_Information_PatientNo = new String[] {""} ;
         T000Z5_n36BR_Information_PatientNo = new bool[] {false} ;
         T000Z6_A85BR_Information_ID = new long[1] ;
         T000Z6_n85BR_Information_ID = new bool[] {false} ;
         T000Z6_A226BR_PathologyID = new long[1] ;
         T000Z6_n226BR_PathologyID = new bool[] {false} ;
         T000Z6_A505BR_Pathology_N_Code = new String[] {""} ;
         T000Z6_n505BR_Pathology_N_Code = new bool[] {false} ;
         T000Z6_A506BR_Pathology_M_Code = new String[] {""} ;
         T000Z6_n506BR_Pathology_M_Code = new bool[] {false} ;
         T000Z6_A508BR_PathologyID_PAHosp_Code = new String[] {""} ;
         T000Z6_n508BR_PathologyID_PAHosp_Code = new bool[] {false} ;
         T000Z6_A36BR_Information_PatientNo = new String[] {""} ;
         T000Z6_n36BR_Information_PatientNo = new bool[] {false} ;
         T000Z6_A237BR_PathologyID_TestID = new long[1] ;
         T000Z6_n237BR_PathologyID_TestID = new bool[] {false} ;
         T000Z6_A238BR_PathologyID_PADate = new DateTime[] {DateTime.MinValue} ;
         T000Z6_n238BR_PathologyID_PADate = new bool[] {false} ;
         T000Z6_A239BR_PathologyID_PAHosp = new String[] {""} ;
         T000Z6_n239BR_PathologyID_PAHosp = new bool[] {false} ;
         T000Z6_A240BR_PathologyID_PAAge = new short[1] ;
         T000Z6_n240BR_PathologyID_PAAge = new bool[] {false} ;
         T000Z6_A241BR_PathologyID_PrePaDia = new String[] {""} ;
         T000Z6_n241BR_PathologyID_PrePaDia = new bool[] {false} ;
         T000Z6_A242BR_PathologyID_PAResult = new String[] {""} ;
         T000Z6_n242BR_PathologyID_PAResult = new bool[] {false} ;
         T000Z6_A326BR_Pathology_Dia_Name = new String[] {""} ;
         T000Z6_n326BR_Pathology_Dia_Name = new bool[] {false} ;
         T000Z6_A314BR_Pathology_T = new decimal[1] ;
         T000Z6_n314BR_Pathology_T = new bool[] {false} ;
         T000Z6_A315BR_Pathology_N = new String[] {""} ;
         T000Z6_n315BR_Pathology_N = new bool[] {false} ;
         T000Z6_A316BR_Pathology_LymphNum = new decimal[1] ;
         T000Z6_n316BR_Pathology_LymphNum = new bool[] {false} ;
         T000Z6_A317BR_Pathology_LymphRate = new String[] {""} ;
         T000Z6_n317BR_Pathology_LymphRate = new bool[] {false} ;
         T000Z6_A318BR_Pathology_M = new String[] {""} ;
         T000Z6_n318BR_Pathology_M = new bool[] {false} ;
         T000Z6_A319BR_Pathology_MetaLoc = new String[] {""} ;
         T000Z6_n319BR_Pathology_MetaLoc = new bool[] {false} ;
         T000Z6_A19BR_EncounterID = new long[1] ;
         T000Z6_n19BR_EncounterID = new bool[] {false} ;
         T000Z7_A85BR_Information_ID = new long[1] ;
         T000Z7_n85BR_Information_ID = new bool[] {false} ;
         T000Z8_A36BR_Information_PatientNo = new String[] {""} ;
         T000Z8_n36BR_Information_PatientNo = new bool[] {false} ;
         T000Z9_A226BR_PathologyID = new long[1] ;
         T000Z9_n226BR_PathologyID = new bool[] {false} ;
         T000Z3_A226BR_PathologyID = new long[1] ;
         T000Z3_n226BR_PathologyID = new bool[] {false} ;
         T000Z3_A505BR_Pathology_N_Code = new String[] {""} ;
         T000Z3_n505BR_Pathology_N_Code = new bool[] {false} ;
         T000Z3_A506BR_Pathology_M_Code = new String[] {""} ;
         T000Z3_n506BR_Pathology_M_Code = new bool[] {false} ;
         T000Z3_A508BR_PathologyID_PAHosp_Code = new String[] {""} ;
         T000Z3_n508BR_PathologyID_PAHosp_Code = new bool[] {false} ;
         T000Z3_A237BR_PathologyID_TestID = new long[1] ;
         T000Z3_n237BR_PathologyID_TestID = new bool[] {false} ;
         T000Z3_A238BR_PathologyID_PADate = new DateTime[] {DateTime.MinValue} ;
         T000Z3_n238BR_PathologyID_PADate = new bool[] {false} ;
         T000Z3_A239BR_PathologyID_PAHosp = new String[] {""} ;
         T000Z3_n239BR_PathologyID_PAHosp = new bool[] {false} ;
         T000Z3_A240BR_PathologyID_PAAge = new short[1] ;
         T000Z3_n240BR_PathologyID_PAAge = new bool[] {false} ;
         T000Z3_A241BR_PathologyID_PrePaDia = new String[] {""} ;
         T000Z3_n241BR_PathologyID_PrePaDia = new bool[] {false} ;
         T000Z3_A242BR_PathologyID_PAResult = new String[] {""} ;
         T000Z3_n242BR_PathologyID_PAResult = new bool[] {false} ;
         T000Z3_A326BR_Pathology_Dia_Name = new String[] {""} ;
         T000Z3_n326BR_Pathology_Dia_Name = new bool[] {false} ;
         T000Z3_A314BR_Pathology_T = new decimal[1] ;
         T000Z3_n314BR_Pathology_T = new bool[] {false} ;
         T000Z3_A315BR_Pathology_N = new String[] {""} ;
         T000Z3_n315BR_Pathology_N = new bool[] {false} ;
         T000Z3_A316BR_Pathology_LymphNum = new decimal[1] ;
         T000Z3_n316BR_Pathology_LymphNum = new bool[] {false} ;
         T000Z3_A317BR_Pathology_LymphRate = new String[] {""} ;
         T000Z3_n317BR_Pathology_LymphRate = new bool[] {false} ;
         T000Z3_A318BR_Pathology_M = new String[] {""} ;
         T000Z3_n318BR_Pathology_M = new bool[] {false} ;
         T000Z3_A319BR_Pathology_MetaLoc = new String[] {""} ;
         T000Z3_n319BR_Pathology_MetaLoc = new bool[] {false} ;
         T000Z3_A19BR_EncounterID = new long[1] ;
         T000Z3_n19BR_EncounterID = new bool[] {false} ;
         T000Z10_A226BR_PathologyID = new long[1] ;
         T000Z10_n226BR_PathologyID = new bool[] {false} ;
         T000Z11_A226BR_PathologyID = new long[1] ;
         T000Z11_n226BR_PathologyID = new bool[] {false} ;
         T000Z2_A226BR_PathologyID = new long[1] ;
         T000Z2_n226BR_PathologyID = new bool[] {false} ;
         T000Z2_A505BR_Pathology_N_Code = new String[] {""} ;
         T000Z2_n505BR_Pathology_N_Code = new bool[] {false} ;
         T000Z2_A506BR_Pathology_M_Code = new String[] {""} ;
         T000Z2_n506BR_Pathology_M_Code = new bool[] {false} ;
         T000Z2_A508BR_PathologyID_PAHosp_Code = new String[] {""} ;
         T000Z2_n508BR_PathologyID_PAHosp_Code = new bool[] {false} ;
         T000Z2_A237BR_PathologyID_TestID = new long[1] ;
         T000Z2_n237BR_PathologyID_TestID = new bool[] {false} ;
         T000Z2_A238BR_PathologyID_PADate = new DateTime[] {DateTime.MinValue} ;
         T000Z2_n238BR_PathologyID_PADate = new bool[] {false} ;
         T000Z2_A239BR_PathologyID_PAHosp = new String[] {""} ;
         T000Z2_n239BR_PathologyID_PAHosp = new bool[] {false} ;
         T000Z2_A240BR_PathologyID_PAAge = new short[1] ;
         T000Z2_n240BR_PathologyID_PAAge = new bool[] {false} ;
         T000Z2_A241BR_PathologyID_PrePaDia = new String[] {""} ;
         T000Z2_n241BR_PathologyID_PrePaDia = new bool[] {false} ;
         T000Z2_A242BR_PathologyID_PAResult = new String[] {""} ;
         T000Z2_n242BR_PathologyID_PAResult = new bool[] {false} ;
         T000Z2_A326BR_Pathology_Dia_Name = new String[] {""} ;
         T000Z2_n326BR_Pathology_Dia_Name = new bool[] {false} ;
         T000Z2_A314BR_Pathology_T = new decimal[1] ;
         T000Z2_n314BR_Pathology_T = new bool[] {false} ;
         T000Z2_A315BR_Pathology_N = new String[] {""} ;
         T000Z2_n315BR_Pathology_N = new bool[] {false} ;
         T000Z2_A316BR_Pathology_LymphNum = new decimal[1] ;
         T000Z2_n316BR_Pathology_LymphNum = new bool[] {false} ;
         T000Z2_A317BR_Pathology_LymphRate = new String[] {""} ;
         T000Z2_n317BR_Pathology_LymphRate = new bool[] {false} ;
         T000Z2_A318BR_Pathology_M = new String[] {""} ;
         T000Z2_n318BR_Pathology_M = new bool[] {false} ;
         T000Z2_A319BR_Pathology_MetaLoc = new String[] {""} ;
         T000Z2_n319BR_Pathology_MetaLoc = new bool[] {false} ;
         T000Z2_A19BR_EncounterID = new long[1] ;
         T000Z2_n19BR_EncounterID = new bool[] {false} ;
         T000Z12_A226BR_PathologyID = new long[1] ;
         T000Z12_n226BR_PathologyID = new bool[] {false} ;
         T000Z15_A85BR_Information_ID = new long[1] ;
         T000Z15_n85BR_Information_ID = new bool[] {false} ;
         T000Z16_A36BR_Information_PatientNo = new String[] {""} ;
         T000Z16_n36BR_Information_PatientNo = new bool[] {false} ;
         T000Z17_A288BR_Pathology_OtherID = new long[1] ;
         T000Z18_A276BR_Pathology_DiagID = new long[1] ;
         T000Z19_A274BR_Pathology_SpecimenID = new long[1] ;
         T000Z20_A226BR_PathologyID = new long[1] ;
         T000Z20_n226BR_PathologyID = new bool[] {false} ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         gxdynajaxctrlcodr = new GeneXus.Utils.GxStringCollection();
         gxdynajaxctrldescr = new GeneXus.Utils.GxStringCollection();
         gxwrpcisep = "";
         T000Z21_A167XT_DefineCodeID = new long[1] ;
         T000Z21_A168XT_DefineCodeName = new String[] {""} ;
         T000Z21_n168XT_DefineCodeName = new bool[] {false} ;
         T000Z21_A165XT_DefindcodeTypeID = new long[1] ;
         T000Z21_A432XT_TenantCode = new String[] {""} ;
         T000Z21_n432XT_TenantCode = new bool[] {false} ;
         GXt_char1 = "";
         T000Z22_A85BR_Information_ID = new long[1] ;
         T000Z22_n85BR_Information_ID = new bool[] {false} ;
         T000Z23_A36BR_Information_PatientNo = new String[] {""} ;
         T000Z23_n36BR_Information_PatientNo = new bool[] {false} ;
         isValidOutput = new GxUnknownObjectCollection();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.br_pathology__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_pathology__default(),
            new Object[][] {
                new Object[] {
               T000Z2_A226BR_PathologyID, T000Z2_A505BR_Pathology_N_Code, T000Z2_n505BR_Pathology_N_Code, T000Z2_A506BR_Pathology_M_Code, T000Z2_n506BR_Pathology_M_Code, T000Z2_A508BR_PathologyID_PAHosp_Code, T000Z2_n508BR_PathologyID_PAHosp_Code, T000Z2_A237BR_PathologyID_TestID, T000Z2_n237BR_PathologyID_TestID, T000Z2_A238BR_PathologyID_PADate,
               T000Z2_n238BR_PathologyID_PADate, T000Z2_A239BR_PathologyID_PAHosp, T000Z2_n239BR_PathologyID_PAHosp, T000Z2_A240BR_PathologyID_PAAge, T000Z2_n240BR_PathologyID_PAAge, T000Z2_A241BR_PathologyID_PrePaDia, T000Z2_n241BR_PathologyID_PrePaDia, T000Z2_A242BR_PathologyID_PAResult, T000Z2_n242BR_PathologyID_PAResult, T000Z2_A326BR_Pathology_Dia_Name,
               T000Z2_n326BR_Pathology_Dia_Name, T000Z2_A314BR_Pathology_T, T000Z2_n314BR_Pathology_T, T000Z2_A315BR_Pathology_N, T000Z2_n315BR_Pathology_N, T000Z2_A316BR_Pathology_LymphNum, T000Z2_n316BR_Pathology_LymphNum, T000Z2_A317BR_Pathology_LymphRate, T000Z2_n317BR_Pathology_LymphRate, T000Z2_A318BR_Pathology_M,
               T000Z2_n318BR_Pathology_M, T000Z2_A319BR_Pathology_MetaLoc, T000Z2_n319BR_Pathology_MetaLoc, T000Z2_A19BR_EncounterID, T000Z2_n19BR_EncounterID
               }
               , new Object[] {
               T000Z3_A226BR_PathologyID, T000Z3_A505BR_Pathology_N_Code, T000Z3_n505BR_Pathology_N_Code, T000Z3_A506BR_Pathology_M_Code, T000Z3_n506BR_Pathology_M_Code, T000Z3_A508BR_PathologyID_PAHosp_Code, T000Z3_n508BR_PathologyID_PAHosp_Code, T000Z3_A237BR_PathologyID_TestID, T000Z3_n237BR_PathologyID_TestID, T000Z3_A238BR_PathologyID_PADate,
               T000Z3_n238BR_PathologyID_PADate, T000Z3_A239BR_PathologyID_PAHosp, T000Z3_n239BR_PathologyID_PAHosp, T000Z3_A240BR_PathologyID_PAAge, T000Z3_n240BR_PathologyID_PAAge, T000Z3_A241BR_PathologyID_PrePaDia, T000Z3_n241BR_PathologyID_PrePaDia, T000Z3_A242BR_PathologyID_PAResult, T000Z3_n242BR_PathologyID_PAResult, T000Z3_A326BR_Pathology_Dia_Name,
               T000Z3_n326BR_Pathology_Dia_Name, T000Z3_A314BR_Pathology_T, T000Z3_n314BR_Pathology_T, T000Z3_A315BR_Pathology_N, T000Z3_n315BR_Pathology_N, T000Z3_A316BR_Pathology_LymphNum, T000Z3_n316BR_Pathology_LymphNum, T000Z3_A317BR_Pathology_LymphRate, T000Z3_n317BR_Pathology_LymphRate, T000Z3_A318BR_Pathology_M,
               T000Z3_n318BR_Pathology_M, T000Z3_A319BR_Pathology_MetaLoc, T000Z3_n319BR_Pathology_MetaLoc, T000Z3_A19BR_EncounterID, T000Z3_n19BR_EncounterID
               }
               , new Object[] {
               T000Z4_A85BR_Information_ID, T000Z4_n85BR_Information_ID
               }
               , new Object[] {
               T000Z5_A36BR_Information_PatientNo, T000Z5_n36BR_Information_PatientNo
               }
               , new Object[] {
               T000Z6_A85BR_Information_ID, T000Z6_n85BR_Information_ID, T000Z6_A226BR_PathologyID, T000Z6_A505BR_Pathology_N_Code, T000Z6_n505BR_Pathology_N_Code, T000Z6_A506BR_Pathology_M_Code, T000Z6_n506BR_Pathology_M_Code, T000Z6_A508BR_PathologyID_PAHosp_Code, T000Z6_n508BR_PathologyID_PAHosp_Code, T000Z6_A36BR_Information_PatientNo,
               T000Z6_n36BR_Information_PatientNo, T000Z6_A237BR_PathologyID_TestID, T000Z6_n237BR_PathologyID_TestID, T000Z6_A238BR_PathologyID_PADate, T000Z6_n238BR_PathologyID_PADate, T000Z6_A239BR_PathologyID_PAHosp, T000Z6_n239BR_PathologyID_PAHosp, T000Z6_A240BR_PathologyID_PAAge, T000Z6_n240BR_PathologyID_PAAge, T000Z6_A241BR_PathologyID_PrePaDia,
               T000Z6_n241BR_PathologyID_PrePaDia, T000Z6_A242BR_PathologyID_PAResult, T000Z6_n242BR_PathologyID_PAResult, T000Z6_A326BR_Pathology_Dia_Name, T000Z6_n326BR_Pathology_Dia_Name, T000Z6_A314BR_Pathology_T, T000Z6_n314BR_Pathology_T, T000Z6_A315BR_Pathology_N, T000Z6_n315BR_Pathology_N, T000Z6_A316BR_Pathology_LymphNum,
               T000Z6_n316BR_Pathology_LymphNum, T000Z6_A317BR_Pathology_LymphRate, T000Z6_n317BR_Pathology_LymphRate, T000Z6_A318BR_Pathology_M, T000Z6_n318BR_Pathology_M, T000Z6_A319BR_Pathology_MetaLoc, T000Z6_n319BR_Pathology_MetaLoc, T000Z6_A19BR_EncounterID, T000Z6_n19BR_EncounterID
               }
               , new Object[] {
               T000Z7_A85BR_Information_ID, T000Z7_n85BR_Information_ID
               }
               , new Object[] {
               T000Z8_A36BR_Information_PatientNo, T000Z8_n36BR_Information_PatientNo
               }
               , new Object[] {
               T000Z9_A226BR_PathologyID
               }
               , new Object[] {
               T000Z10_A226BR_PathologyID
               }
               , new Object[] {
               T000Z11_A226BR_PathologyID
               }
               , new Object[] {
               T000Z12_A226BR_PathologyID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000Z15_A85BR_Information_ID, T000Z15_n85BR_Information_ID
               }
               , new Object[] {
               T000Z16_A36BR_Information_PatientNo, T000Z16_n36BR_Information_PatientNo
               }
               , new Object[] {
               T000Z17_A288BR_Pathology_OtherID
               }
               , new Object[] {
               T000Z18_A276BR_Pathology_DiagID
               }
               , new Object[] {
               T000Z19_A274BR_Pathology_SpecimenID
               }
               , new Object[] {
               T000Z20_A226BR_PathologyID
               }
               , new Object[] {
               T000Z21_A167XT_DefineCodeID, T000Z21_A168XT_DefineCodeName, T000Z21_n168XT_DefineCodeName, T000Z21_A165XT_DefindcodeTypeID, T000Z21_A432XT_TenantCode, T000Z21_n432XT_TenantCode
               }
               , new Object[] {
               T000Z22_A85BR_Information_ID, T000Z22_n85BR_Information_ID
               }
               , new Object[] {
               T000Z23_A36BR_Information_PatientNo, T000Z23_n36BR_Information_PatientNo
               }
            }
         );
         AV17Pgmname = "BR_Pathology";
      }

      private short Z240BR_PathologyID_PAAge ;
      private short GxWebError ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A240BR_PathologyID_PAAge ;
      private short RcdFound36 ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int trnEnded ;
      private int edtBR_PathologyID_PADate_Enabled ;
      private int edtBR_PathologyID_PAAge_Enabled ;
      private int edtBR_Pathology_Dia_Name_Enabled ;
      private int edtBR_PathologyID_PAResult_Enabled ;
      private int edtBR_PathologyID_PrePaDia_Enabled ;
      private int edtBR_Pathology_T_Enabled ;
      private int edtBR_Pathology_LymphNum_Enabled ;
      private int edtBR_Pathology_LymphRate_Enabled ;
      private int divUnnamedtable1_Visible ;
      private int edtBR_Pathology_MetaLoc_Enabled ;
      private int bttBtntrn_enter_Visible ;
      private int bttBtntrn_enter_Enabled ;
      private int bttBtntrn_cancel_Visible ;
      private int bttBtntrn_delete_Visible ;
      private int bttBtntrn_delete_Enabled ;
      private int edtBR_PathologyID_Enabled ;
      private int edtBR_PathologyID_Visible ;
      private int edtBR_EncounterID_Visible ;
      private int edtBR_EncounterID_Enabled ;
      private int edtBR_Information_PatientNo_Visible ;
      private int edtBR_Information_PatientNo_Enabled ;
      private int edtBR_PathologyID_TestID_Enabled ;
      private int edtBR_PathologyID_TestID_Visible ;
      private int AV18GXV1 ;
      private int idxLst ;
      private int gxdynajaxindex ;
      private long wcpOAV7BR_PathologyID ;
      private long Z226BR_PathologyID ;
      private long Z237BR_PathologyID_TestID ;
      private long Z19BR_EncounterID ;
      private long N19BR_EncounterID ;
      private long A19BR_EncounterID ;
      private long A85BR_Information_ID ;
      private long AV7BR_PathologyID ;
      private long A226BR_PathologyID ;
      private long A237BR_PathologyID_TestID ;
      private long AV13Insert_BR_EncounterID ;
      private long Z85BR_Information_ID ;
      private decimal Z314BR_Pathology_T ;
      private decimal Z316BR_Pathology_LymphNum ;
      private decimal A314BR_Pathology_T ;
      private decimal A316BR_Pathology_LymphNum ;
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
      private String edtBR_PathologyID_PADate_Internalname ;
      private String dynBR_PathologyID_PAHosp_Internalname ;
      private String cmbBR_Pathology_N_Internalname ;
      private String cmbBR_Pathology_M_Internalname ;
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
      private String divUnnamedtablebr_pathologyid_padate_Internalname ;
      private String lblTextblockbr_pathologyid_padate_Internalname ;
      private String lblTextblockbr_pathologyid_padate_Jsonclick ;
      private String TempTags ;
      private String edtBR_PathologyID_PADate_Jsonclick ;
      private String divUnnamedtablebr_pathologyid_paage_Internalname ;
      private String lblTextblockbr_pathologyid_paage_Internalname ;
      private String lblTextblockbr_pathologyid_paage_Jsonclick ;
      private String edtBR_PathologyID_PAAge_Internalname ;
      private String edtBR_PathologyID_PAAge_Jsonclick ;
      private String divUnnamedtablebr_pathologyid_pahosp_Internalname ;
      private String lblTextblockbr_pathologyid_pahosp_Internalname ;
      private String lblTextblockbr_pathologyid_pahosp_Jsonclick ;
      private String dynBR_PathologyID_PAHosp_Jsonclick ;
      private String divUnnamedtablebr_pathology_dia_name_Internalname ;
      private String lblTextblockbr_pathology_dia_name_Internalname ;
      private String lblTextblockbr_pathology_dia_name_Jsonclick ;
      private String edtBR_Pathology_Dia_Name_Internalname ;
      private String divUnnamedtablebr_pathologyid_paresult_Internalname ;
      private String lblTextblockbr_pathologyid_paresult_Internalname ;
      private String lblTextblockbr_pathologyid_paresult_Jsonclick ;
      private String edtBR_PathologyID_PAResult_Internalname ;
      private String divUnnamedtablebr_pathologyid_prepadia_Internalname ;
      private String lblTextblockbr_pathologyid_prepadia_Internalname ;
      private String lblTextblockbr_pathologyid_prepadia_Jsonclick ;
      private String edtBR_PathologyID_PrePaDia_Internalname ;
      private String divUnnamedtablebr_pathology_t_Internalname ;
      private String lblTextblockbr_pathology_t_Internalname ;
      private String lblTextblockbr_pathology_t_Jsonclick ;
      private String edtBR_Pathology_T_Internalname ;
      private String edtBR_Pathology_T_Jsonclick ;
      private String divUnnamedtablebr_pathology_n_Internalname ;
      private String lblTextblockbr_pathology_n_Internalname ;
      private String lblTextblockbr_pathology_n_Jsonclick ;
      private String cmbBR_Pathology_N_Jsonclick ;
      private String divUnnamedtablebr_pathology_lymphnum_Internalname ;
      private String lblTextblockbr_pathology_lymphnum_Internalname ;
      private String lblTextblockbr_pathology_lymphnum_Jsonclick ;
      private String edtBR_Pathology_LymphNum_Internalname ;
      private String edtBR_Pathology_LymphNum_Jsonclick ;
      private String divUnnamedtablebr_pathology_lymphrate_Internalname ;
      private String lblTextblockbr_pathology_lymphrate_Internalname ;
      private String lblTextblockbr_pathology_lymphrate_Jsonclick ;
      private String edtBR_Pathology_LymphRate_Internalname ;
      private String edtBR_Pathology_LymphRate_Jsonclick ;
      private String divUnnamedtablebr_pathology_m_Internalname ;
      private String lblTextblockbr_pathology_m_Internalname ;
      private String lblTextblockbr_pathology_m_Jsonclick ;
      private String cmbBR_Pathology_M_Jsonclick ;
      private String divUnnamedtable1_Internalname ;
      private String divUnnamedtablebr_pathology_metaloc_Internalname ;
      private String lblTextblockbr_pathology_metaloc_Internalname ;
      private String lblTextblockbr_pathology_metaloc_Jsonclick ;
      private String edtBR_Pathology_MetaLoc_Internalname ;
      private String edtBR_Pathology_MetaLoc_Jsonclick ;
      private String bttBtntrn_enter_Internalname ;
      private String bttBtntrn_enter_Jsonclick ;
      private String bttBtntrn_cancel_Internalname ;
      private String bttBtntrn_cancel_Jsonclick ;
      private String bttBtntrn_delete_Internalname ;
      private String bttBtntrn_delete_Jsonclick ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String edtBR_PathologyID_Internalname ;
      private String edtBR_PathologyID_Jsonclick ;
      private String edtBR_EncounterID_Internalname ;
      private String edtBR_EncounterID_Jsonclick ;
      private String edtBR_Information_PatientNo_Internalname ;
      private String edtBR_Information_PatientNo_Jsonclick ;
      private String edtBR_PathologyID_TestID_Internalname ;
      private String edtBR_PathologyID_TestID_Jsonclick ;
      private String AV17Pgmname ;
      private String Dvpanel_tableattributes_Objectcall ;
      private String Dvpanel_tableattributes_Class ;
      private String Dvpanel_tableattributes_Height ;
      private String forbiddenHiddens ;
      private String hsh ;
      private String sMode36 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String gxwrpcisep ;
      private String GXt_char1 ;
      private DateTime Z238BR_PathologyID_PADate ;
      private DateTime A238BR_PathologyID_PADate ;
      private bool entryPointCalled ;
      private bool n315BR_Pathology_N ;
      private bool n318BR_Pathology_M ;
      private bool n239BR_PathologyID_PAHosp ;
      private bool n19BR_EncounterID ;
      private bool n85BR_Information_ID ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool Dvpanel_tableattributes_Autowidth ;
      private bool Dvpanel_tableattributes_Autoheight ;
      private bool Dvpanel_tableattributes_Collapsible ;
      private bool Dvpanel_tableattributes_Collapsed ;
      private bool Dvpanel_tableattributes_Showcollapseicon ;
      private bool Dvpanel_tableattributes_Autoscroll ;
      private bool n238BR_PathologyID_PADate ;
      private bool n240BR_PathologyID_PAAge ;
      private bool n326BR_Pathology_Dia_Name ;
      private bool n242BR_PathologyID_PAResult ;
      private bool n241BR_PathologyID_PrePaDia ;
      private bool n314BR_Pathology_T ;
      private bool n316BR_Pathology_LymphNum ;
      private bool n317BR_Pathology_LymphRate ;
      private bool n319BR_Pathology_MetaLoc ;
      private bool n226BR_PathologyID ;
      private bool n36BR_Information_PatientNo ;
      private bool n237BR_PathologyID_TestID ;
      private bool n505BR_Pathology_N_Code ;
      private bool n506BR_Pathology_M_Code ;
      private bool n508BR_PathologyID_PAHosp_Code ;
      private bool Dvpanel_tableattributes_Enabled ;
      private bool Dvpanel_tableattributes_Showheader ;
      private bool Dvpanel_tableattributes_Visible ;
      private bool AV9IsAuthorized ;
      private bool returnInSub ;
      private bool AV15TempBoolean ;
      private bool GXt_boolean2 ;
      private bool Gx_longc ;
      private bool gxdyncontrolsrefreshing ;
      private String Z505BR_Pathology_N_Code ;
      private String Z506BR_Pathology_M_Code ;
      private String Z508BR_PathologyID_PAHosp_Code ;
      private String Z239BR_PathologyID_PAHosp ;
      private String Z241BR_PathologyID_PrePaDia ;
      private String Z242BR_PathologyID_PAResult ;
      private String Z326BR_Pathology_Dia_Name ;
      private String Z315BR_Pathology_N ;
      private String Z317BR_Pathology_LymphRate ;
      private String Z318BR_Pathology_M ;
      private String Z319BR_Pathology_MetaLoc ;
      private String AV16tCurrentCode ;
      private String A315BR_Pathology_N ;
      private String A318BR_Pathology_M ;
      private String A239BR_PathologyID_PAHosp ;
      private String A326BR_Pathology_Dia_Name ;
      private String A242BR_PathologyID_PAResult ;
      private String A241BR_PathologyID_PrePaDia ;
      private String A317BR_Pathology_LymphRate ;
      private String A319BR_Pathology_MetaLoc ;
      private String A36BR_Information_PatientNo ;
      private String A505BR_Pathology_N_Code ;
      private String A506BR_Pathology_M_Code ;
      private String A508BR_PathologyID_PAHosp_Code ;
      private String Z36BR_Information_PatientNo ;
      private IGxSession AV12WebSession ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrlcodr ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrldescr ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXUserControl ucDvpanel_tableattributes ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private GXCombobox dynBR_PathologyID_PAHosp ;
      private GXCombobox cmbBR_Pathology_N ;
      private GXCombobox cmbBR_Pathology_M ;
      private IDataStoreProvider pr_default ;
      private long[] T000Z4_A85BR_Information_ID ;
      private bool[] T000Z4_n85BR_Information_ID ;
      private String[] T000Z5_A36BR_Information_PatientNo ;
      private bool[] T000Z5_n36BR_Information_PatientNo ;
      private long[] T000Z6_A85BR_Information_ID ;
      private bool[] T000Z6_n85BR_Information_ID ;
      private long[] T000Z6_A226BR_PathologyID ;
      private bool[] T000Z6_n226BR_PathologyID ;
      private String[] T000Z6_A505BR_Pathology_N_Code ;
      private bool[] T000Z6_n505BR_Pathology_N_Code ;
      private String[] T000Z6_A506BR_Pathology_M_Code ;
      private bool[] T000Z6_n506BR_Pathology_M_Code ;
      private String[] T000Z6_A508BR_PathologyID_PAHosp_Code ;
      private bool[] T000Z6_n508BR_PathologyID_PAHosp_Code ;
      private String[] T000Z6_A36BR_Information_PatientNo ;
      private bool[] T000Z6_n36BR_Information_PatientNo ;
      private long[] T000Z6_A237BR_PathologyID_TestID ;
      private bool[] T000Z6_n237BR_PathologyID_TestID ;
      private DateTime[] T000Z6_A238BR_PathologyID_PADate ;
      private bool[] T000Z6_n238BR_PathologyID_PADate ;
      private String[] T000Z6_A239BR_PathologyID_PAHosp ;
      private bool[] T000Z6_n239BR_PathologyID_PAHosp ;
      private short[] T000Z6_A240BR_PathologyID_PAAge ;
      private bool[] T000Z6_n240BR_PathologyID_PAAge ;
      private String[] T000Z6_A241BR_PathologyID_PrePaDia ;
      private bool[] T000Z6_n241BR_PathologyID_PrePaDia ;
      private String[] T000Z6_A242BR_PathologyID_PAResult ;
      private bool[] T000Z6_n242BR_PathologyID_PAResult ;
      private String[] T000Z6_A326BR_Pathology_Dia_Name ;
      private bool[] T000Z6_n326BR_Pathology_Dia_Name ;
      private decimal[] T000Z6_A314BR_Pathology_T ;
      private bool[] T000Z6_n314BR_Pathology_T ;
      private String[] T000Z6_A315BR_Pathology_N ;
      private bool[] T000Z6_n315BR_Pathology_N ;
      private decimal[] T000Z6_A316BR_Pathology_LymphNum ;
      private bool[] T000Z6_n316BR_Pathology_LymphNum ;
      private String[] T000Z6_A317BR_Pathology_LymphRate ;
      private bool[] T000Z6_n317BR_Pathology_LymphRate ;
      private String[] T000Z6_A318BR_Pathology_M ;
      private bool[] T000Z6_n318BR_Pathology_M ;
      private String[] T000Z6_A319BR_Pathology_MetaLoc ;
      private bool[] T000Z6_n319BR_Pathology_MetaLoc ;
      private long[] T000Z6_A19BR_EncounterID ;
      private bool[] T000Z6_n19BR_EncounterID ;
      private long[] T000Z7_A85BR_Information_ID ;
      private bool[] T000Z7_n85BR_Information_ID ;
      private String[] T000Z8_A36BR_Information_PatientNo ;
      private bool[] T000Z8_n36BR_Information_PatientNo ;
      private long[] T000Z9_A226BR_PathologyID ;
      private bool[] T000Z9_n226BR_PathologyID ;
      private long[] T000Z3_A226BR_PathologyID ;
      private bool[] T000Z3_n226BR_PathologyID ;
      private String[] T000Z3_A505BR_Pathology_N_Code ;
      private bool[] T000Z3_n505BR_Pathology_N_Code ;
      private String[] T000Z3_A506BR_Pathology_M_Code ;
      private bool[] T000Z3_n506BR_Pathology_M_Code ;
      private String[] T000Z3_A508BR_PathologyID_PAHosp_Code ;
      private bool[] T000Z3_n508BR_PathologyID_PAHosp_Code ;
      private long[] T000Z3_A237BR_PathologyID_TestID ;
      private bool[] T000Z3_n237BR_PathologyID_TestID ;
      private DateTime[] T000Z3_A238BR_PathologyID_PADate ;
      private bool[] T000Z3_n238BR_PathologyID_PADate ;
      private String[] T000Z3_A239BR_PathologyID_PAHosp ;
      private bool[] T000Z3_n239BR_PathologyID_PAHosp ;
      private short[] T000Z3_A240BR_PathologyID_PAAge ;
      private bool[] T000Z3_n240BR_PathologyID_PAAge ;
      private String[] T000Z3_A241BR_PathologyID_PrePaDia ;
      private bool[] T000Z3_n241BR_PathologyID_PrePaDia ;
      private String[] T000Z3_A242BR_PathologyID_PAResult ;
      private bool[] T000Z3_n242BR_PathologyID_PAResult ;
      private String[] T000Z3_A326BR_Pathology_Dia_Name ;
      private bool[] T000Z3_n326BR_Pathology_Dia_Name ;
      private decimal[] T000Z3_A314BR_Pathology_T ;
      private bool[] T000Z3_n314BR_Pathology_T ;
      private String[] T000Z3_A315BR_Pathology_N ;
      private bool[] T000Z3_n315BR_Pathology_N ;
      private decimal[] T000Z3_A316BR_Pathology_LymphNum ;
      private bool[] T000Z3_n316BR_Pathology_LymphNum ;
      private String[] T000Z3_A317BR_Pathology_LymphRate ;
      private bool[] T000Z3_n317BR_Pathology_LymphRate ;
      private String[] T000Z3_A318BR_Pathology_M ;
      private bool[] T000Z3_n318BR_Pathology_M ;
      private String[] T000Z3_A319BR_Pathology_MetaLoc ;
      private bool[] T000Z3_n319BR_Pathology_MetaLoc ;
      private long[] T000Z3_A19BR_EncounterID ;
      private bool[] T000Z3_n19BR_EncounterID ;
      private long[] T000Z10_A226BR_PathologyID ;
      private bool[] T000Z10_n226BR_PathologyID ;
      private long[] T000Z11_A226BR_PathologyID ;
      private bool[] T000Z11_n226BR_PathologyID ;
      private long[] T000Z2_A226BR_PathologyID ;
      private bool[] T000Z2_n226BR_PathologyID ;
      private String[] T000Z2_A505BR_Pathology_N_Code ;
      private bool[] T000Z2_n505BR_Pathology_N_Code ;
      private String[] T000Z2_A506BR_Pathology_M_Code ;
      private bool[] T000Z2_n506BR_Pathology_M_Code ;
      private String[] T000Z2_A508BR_PathologyID_PAHosp_Code ;
      private bool[] T000Z2_n508BR_PathologyID_PAHosp_Code ;
      private long[] T000Z2_A237BR_PathologyID_TestID ;
      private bool[] T000Z2_n237BR_PathologyID_TestID ;
      private DateTime[] T000Z2_A238BR_PathologyID_PADate ;
      private bool[] T000Z2_n238BR_PathologyID_PADate ;
      private String[] T000Z2_A239BR_PathologyID_PAHosp ;
      private bool[] T000Z2_n239BR_PathologyID_PAHosp ;
      private short[] T000Z2_A240BR_PathologyID_PAAge ;
      private bool[] T000Z2_n240BR_PathologyID_PAAge ;
      private String[] T000Z2_A241BR_PathologyID_PrePaDia ;
      private bool[] T000Z2_n241BR_PathologyID_PrePaDia ;
      private String[] T000Z2_A242BR_PathologyID_PAResult ;
      private bool[] T000Z2_n242BR_PathologyID_PAResult ;
      private String[] T000Z2_A326BR_Pathology_Dia_Name ;
      private bool[] T000Z2_n326BR_Pathology_Dia_Name ;
      private decimal[] T000Z2_A314BR_Pathology_T ;
      private bool[] T000Z2_n314BR_Pathology_T ;
      private String[] T000Z2_A315BR_Pathology_N ;
      private bool[] T000Z2_n315BR_Pathology_N ;
      private decimal[] T000Z2_A316BR_Pathology_LymphNum ;
      private bool[] T000Z2_n316BR_Pathology_LymphNum ;
      private String[] T000Z2_A317BR_Pathology_LymphRate ;
      private bool[] T000Z2_n317BR_Pathology_LymphRate ;
      private String[] T000Z2_A318BR_Pathology_M ;
      private bool[] T000Z2_n318BR_Pathology_M ;
      private String[] T000Z2_A319BR_Pathology_MetaLoc ;
      private bool[] T000Z2_n319BR_Pathology_MetaLoc ;
      private long[] T000Z2_A19BR_EncounterID ;
      private bool[] T000Z2_n19BR_EncounterID ;
      private long[] T000Z12_A226BR_PathologyID ;
      private bool[] T000Z12_n226BR_PathologyID ;
      private long[] T000Z15_A85BR_Information_ID ;
      private bool[] T000Z15_n85BR_Information_ID ;
      private String[] T000Z16_A36BR_Information_PatientNo ;
      private bool[] T000Z16_n36BR_Information_PatientNo ;
      private long[] T000Z17_A288BR_Pathology_OtherID ;
      private long[] T000Z18_A276BR_Pathology_DiagID ;
      private long[] T000Z19_A274BR_Pathology_SpecimenID ;
      private long[] T000Z20_A226BR_PathologyID ;
      private bool[] T000Z20_n226BR_PathologyID ;
      private long[] T000Z21_A167XT_DefineCodeID ;
      private String[] T000Z21_A168XT_DefineCodeName ;
      private bool[] T000Z21_n168XT_DefineCodeName ;
      private long[] T000Z21_A165XT_DefindcodeTypeID ;
      private String[] T000Z21_A432XT_TenantCode ;
      private bool[] T000Z21_n432XT_TenantCode ;
      private long[] T000Z22_A85BR_Information_ID ;
      private bool[] T000Z22_n85BR_Information_ID ;
      private String[] T000Z23_A36BR_Information_PatientNo ;
      private bool[] T000Z23_n36BR_Information_PatientNo ;
      private IDataStoreProvider pr_datastore1 ;
      private GXWebForm Form ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV8WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV11TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute AV14TrnContextAtt ;
   }

   public class br_pathology__datastore1 : DataStoreHelperBase, IDataStoreHelper
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

 public class br_pathology__default : DataStoreHelperBase, IDataStoreHelper
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
       ,new ForEachCursor(def[20])
       ,new ForEachCursor(def[21])
     };
  }

  private static CursorDef[] def;
  private void cursorDefinitions( )
  {
     if ( def == null )
     {
        Object[] prmT000Z6 ;
        prmT000Z6 = new Object[] {
        new Object[] {"@BR_PathologyID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000Z4 ;
        prmT000Z4 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000Z5 ;
        prmT000Z5 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000Z7 ;
        prmT000Z7 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000Z8 ;
        prmT000Z8 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000Z9 ;
        prmT000Z9 = new Object[] {
        new Object[] {"@BR_PathologyID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000Z3 ;
        prmT000Z3 = new Object[] {
        new Object[] {"@BR_PathologyID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000Z10 ;
        prmT000Z10 = new Object[] {
        new Object[] {"@BR_PathologyID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000Z11 ;
        prmT000Z11 = new Object[] {
        new Object[] {"@BR_PathologyID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000Z2 ;
        prmT000Z2 = new Object[] {
        new Object[] {"@BR_PathologyID",SqlDbType.Decimal,18,0}
        } ;
        /* Definition of BR_PathologyID_PAResult changed to svchar length 4000 decimals 0 */
        Object[] prmT000Z12 ;
        prmT000Z12 = new Object[] {
        new Object[] {"@BR_Pathology_N_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Pathology_M_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_PathologyID_PAHosp_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_PathologyID_TestID",SqlDbType.Decimal,10,0} ,
        new Object[] {"@BR_PathologyID_PADate",SqlDbType.DateTime,8,0} ,
        new Object[] {"@BR_PathologyID_PAHosp",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_PathologyID_PAAge",SqlDbType.SmallInt,3,0} ,
        new Object[] {"@BR_PathologyID_PrePaDia",SqlDbType.NVarChar,4000,0} ,
        new Object[] {"@BR_PathologyID_PAResult",SqlDbType.NVarChar,4000,0} ,
        new Object[] {"@BR_Pathology_Dia_Name",SqlDbType.NVarChar,3000,0} ,
        new Object[] {"@BR_Pathology_T",SqlDbType.Decimal,15,5} ,
        new Object[] {"@BR_Pathology_N",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Pathology_LymphNum",SqlDbType.Decimal,15,5} ,
        new Object[] {"@BR_Pathology_LymphRate",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Pathology_M",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Pathology_MetaLoc",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        /* Definition of BR_PathologyID_PAResult changed to svchar length 4000 decimals 0 */
        Object[] prmT000Z13 ;
        prmT000Z13 = new Object[] {
        new Object[] {"@BR_Pathology_N_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Pathology_M_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_PathologyID_PAHosp_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_PathologyID_TestID",SqlDbType.Decimal,10,0} ,
        new Object[] {"@BR_PathologyID_PADate",SqlDbType.DateTime,8,0} ,
        new Object[] {"@BR_PathologyID_PAHosp",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_PathologyID_PAAge",SqlDbType.SmallInt,3,0} ,
        new Object[] {"@BR_PathologyID_PrePaDia",SqlDbType.NVarChar,4000,0} ,
        new Object[] {"@BR_PathologyID_PAResult",SqlDbType.NVarChar,4000,0} ,
        new Object[] {"@BR_Pathology_Dia_Name",SqlDbType.NVarChar,3000,0} ,
        new Object[] {"@BR_Pathology_T",SqlDbType.Decimal,15,5} ,
        new Object[] {"@BR_Pathology_N",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Pathology_LymphNum",SqlDbType.Decimal,15,5} ,
        new Object[] {"@BR_Pathology_LymphRate",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Pathology_M",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Pathology_MetaLoc",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@BR_PathologyID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000Z14 ;
        prmT000Z14 = new Object[] {
        new Object[] {"@BR_PathologyID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000Z15 ;
        prmT000Z15 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000Z16 ;
        prmT000Z16 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000Z17 ;
        prmT000Z17 = new Object[] {
        new Object[] {"@BR_PathologyID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000Z18 ;
        prmT000Z18 = new Object[] {
        new Object[] {"@BR_PathologyID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000Z19 ;
        prmT000Z19 = new Object[] {
        new Object[] {"@BR_PathologyID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000Z20 ;
        prmT000Z20 = new Object[] {
        } ;
        Object[] prmT000Z21 ;
        prmT000Z21 = new Object[] {
        new Object[] {"@AV16tCurrentCode",SqlDbType.NVarChar,40,0}
        } ;
        Object[] prmT000Z22 ;
        prmT000Z22 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000Z23 ;
        prmT000Z23 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("T000Z2", "SELECT [BR_PathologyID], [BR_Pathology_N_Code], [BR_Pathology_M_Code], [BR_PathologyID_PAHosp_Code], [BR_PathologyID_TestID], [BR_PathologyID_PADate], [BR_PathologyID_PAHosp], [BR_PathologyID_PAAge], [BR_PathologyID_PrePaDia], [BR_PathologyID_PAResult], [BR_Pathology_Dia_Name], [BR_Pathology_T], [BR_Pathology_N], [BR_Pathology_LymphNum], [BR_Pathology_LymphRate], [BR_Pathology_M], [BR_Pathology_MetaLoc], [BR_EncounterID] FROM [BR_Pathology] WITH (UPDLOCK) WHERE [BR_PathologyID] = @BR_PathologyID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Z2,1,0,true,false )
           ,new CursorDef("T000Z3", "SELECT [BR_PathologyID], [BR_Pathology_N_Code], [BR_Pathology_M_Code], [BR_PathologyID_PAHosp_Code], [BR_PathologyID_TestID], [BR_PathologyID_PADate], [BR_PathologyID_PAHosp], [BR_PathologyID_PAAge], [BR_PathologyID_PrePaDia], [BR_PathologyID_PAResult], [BR_Pathology_Dia_Name], [BR_Pathology_T], [BR_Pathology_N], [BR_Pathology_LymphNum], [BR_Pathology_LymphRate], [BR_Pathology_M], [BR_Pathology_MetaLoc], [BR_EncounterID] FROM [BR_Pathology] WITH (NOLOCK) WHERE [BR_PathologyID] = @BR_PathologyID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Z3,1,0,true,false )
           ,new CursorDef("T000Z4", "SELECT [BR_Information_ID] FROM [BR_Encounter] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Z4,1,0,true,false )
           ,new CursorDef("T000Z5", "SELECT [BR_Information_PatientNo] FROM [BR_Information] WITH (NOLOCK) WHERE [BR_Information_ID] = @BR_Information_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Z5,1,0,true,false )
           ,new CursorDef("T000Z6", "SELECT T2.[BR_Information_ID], TM1.[BR_PathologyID], TM1.[BR_Pathology_N_Code], TM1.[BR_Pathology_M_Code], TM1.[BR_PathologyID_PAHosp_Code], T3.[BR_Information_PatientNo], TM1.[BR_PathologyID_TestID], TM1.[BR_PathologyID_PADate], TM1.[BR_PathologyID_PAHosp], TM1.[BR_PathologyID_PAAge], TM1.[BR_PathologyID_PrePaDia], TM1.[BR_PathologyID_PAResult], TM1.[BR_Pathology_Dia_Name], TM1.[BR_Pathology_T], TM1.[BR_Pathology_N], TM1.[BR_Pathology_LymphNum], TM1.[BR_Pathology_LymphRate], TM1.[BR_Pathology_M], TM1.[BR_Pathology_MetaLoc], TM1.[BR_EncounterID] FROM (([BR_Pathology] TM1 WITH (NOLOCK) LEFT JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = TM1.[BR_EncounterID]) LEFT JOIN [BR_Information] T3 WITH (NOLOCK) ON T3.[BR_Information_ID] = T2.[BR_Information_ID]) WHERE TM1.[BR_PathologyID] = @BR_PathologyID ORDER BY TM1.[BR_PathologyID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000Z6,100,0,true,false )
           ,new CursorDef("T000Z7", "SELECT [BR_Information_ID] FROM [BR_Encounter] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Z7,1,0,true,false )
           ,new CursorDef("T000Z8", "SELECT [BR_Information_PatientNo] FROM [BR_Information] WITH (NOLOCK) WHERE [BR_Information_ID] = @BR_Information_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Z8,1,0,true,false )
           ,new CursorDef("T000Z9", "SELECT [BR_PathologyID] FROM [BR_Pathology] WITH (NOLOCK) WHERE [BR_PathologyID] = @BR_PathologyID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000Z9,1,0,true,false )
           ,new CursorDef("T000Z10", "SELECT TOP 1 [BR_PathologyID] FROM [BR_Pathology] WITH (NOLOCK) WHERE ( [BR_PathologyID] > @BR_PathologyID) ORDER BY [BR_PathologyID]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000Z10,1,0,true,true )
           ,new CursorDef("T000Z11", "SELECT TOP 1 [BR_PathologyID] FROM [BR_Pathology] WITH (NOLOCK) WHERE ( [BR_PathologyID] < @BR_PathologyID) ORDER BY [BR_PathologyID] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000Z11,1,0,true,true )
           ,new CursorDef("T000Z12", "INSERT INTO [BR_Pathology]([BR_Pathology_N_Code], [BR_Pathology_M_Code], [BR_PathologyID_PAHosp_Code], [BR_PathologyID_TestID], [BR_PathologyID_PADate], [BR_PathologyID_PAHosp], [BR_PathologyID_PAAge], [BR_PathologyID_PrePaDia], [BR_PathologyID_PAResult], [BR_Pathology_Dia_Name], [BR_Pathology_T], [BR_Pathology_N], [BR_Pathology_LymphNum], [BR_Pathology_LymphRate], [BR_Pathology_M], [BR_Pathology_MetaLoc], [BR_EncounterID]) VALUES(@BR_Pathology_N_Code, @BR_Pathology_M_Code, @BR_PathologyID_PAHosp_Code, @BR_PathologyID_TestID, @BR_PathologyID_PADate, @BR_PathologyID_PAHosp, @BR_PathologyID_PAAge, @BR_PathologyID_PrePaDia, @BR_PathologyID_PAResult, @BR_Pathology_Dia_Name, @BR_Pathology_T, @BR_Pathology_N, @BR_Pathology_LymphNum, @BR_Pathology_LymphRate, @BR_Pathology_M, @BR_Pathology_MetaLoc, @BR_EncounterID); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmT000Z12)
           ,new CursorDef("T000Z13", "UPDATE [BR_Pathology] SET [BR_Pathology_N_Code]=@BR_Pathology_N_Code, [BR_Pathology_M_Code]=@BR_Pathology_M_Code, [BR_PathologyID_PAHosp_Code]=@BR_PathologyID_PAHosp_Code, [BR_PathologyID_TestID]=@BR_PathologyID_TestID, [BR_PathologyID_PADate]=@BR_PathologyID_PADate, [BR_PathologyID_PAHosp]=@BR_PathologyID_PAHosp, [BR_PathologyID_PAAge]=@BR_PathologyID_PAAge, [BR_PathologyID_PrePaDia]=@BR_PathologyID_PrePaDia, [BR_PathologyID_PAResult]=@BR_PathologyID_PAResult, [BR_Pathology_Dia_Name]=@BR_Pathology_Dia_Name, [BR_Pathology_T]=@BR_Pathology_T, [BR_Pathology_N]=@BR_Pathology_N, [BR_Pathology_LymphNum]=@BR_Pathology_LymphNum, [BR_Pathology_LymphRate]=@BR_Pathology_LymphRate, [BR_Pathology_M]=@BR_Pathology_M, [BR_Pathology_MetaLoc]=@BR_Pathology_MetaLoc, [BR_EncounterID]=@BR_EncounterID  WHERE [BR_PathologyID] = @BR_PathologyID", GxErrorMask.GX_NOMASK,prmT000Z13)
           ,new CursorDef("T000Z14", "DELETE FROM [BR_Pathology]  WHERE [BR_PathologyID] = @BR_PathologyID", GxErrorMask.GX_NOMASK,prmT000Z14)
           ,new CursorDef("T000Z15", "SELECT [BR_Information_ID] FROM [BR_Encounter] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Z15,1,0,true,false )
           ,new CursorDef("T000Z16", "SELECT [BR_Information_PatientNo] FROM [BR_Information] WITH (NOLOCK) WHERE [BR_Information_ID] = @BR_Information_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Z16,1,0,true,false )
           ,new CursorDef("T000Z17", "SELECT TOP 1 [BR_Pathology_OtherID] FROM [BR_Pathology_Other] WITH (NOLOCK) WHERE [BR_PathologyID] = @BR_PathologyID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Z17,1,0,true,true )
           ,new CursorDef("T000Z18", "SELECT TOP 1 [BR_Pathology_DiagID] FROM [BR_Pathology_Diag] WITH (NOLOCK) WHERE [BR_PathologyID] = @BR_PathologyID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Z18,1,0,true,true )
           ,new CursorDef("T000Z19", "SELECT TOP 1 [BR_Pathology_SpecimenID] FROM [BR_Pathology_Specimen] WITH (NOLOCK) WHERE [BR_PathologyID] = @BR_PathologyID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Z19,1,0,true,true )
           ,new CursorDef("T000Z20", "SELECT [BR_PathologyID] FROM [BR_Pathology] WITH (NOLOCK) ORDER BY [BR_PathologyID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000Z20,100,0,true,false )
           ,new CursorDef("T000Z21", "SELECT [XT_DefineCodeID], [XT_DefineCodeName], [XT_DefindcodeTypeID], [XT_TenantCode] FROM [XT_DefineCode] WITH (NOLOCK) WHERE ([XT_DefindcodeTypeID] = 32) AND ([XT_TenantCode] = @AV16tCurrentCode) ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Z21,0,0,true,false )
           ,new CursorDef("T000Z22", "SELECT [BR_Information_ID] FROM [BR_Encounter] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Z22,1,0,true,false )
           ,new CursorDef("T000Z23", "SELECT [BR_Information_PatientNo] FROM [BR_Information] WITH (NOLOCK) WHERE [BR_Information_ID] = @BR_Information_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Z23,1,0,true,false )
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
              ((long[]) buf[7])[0] = rslt.getLong(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((DateTime[]) buf[9])[0] = rslt.getGXDate(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              ((short[]) buf[13])[0] = rslt.getShort(8) ;
              ((bool[]) buf[14])[0] = rslt.wasNull(8);
              ((String[]) buf[15])[0] = rslt.getVarchar(9) ;
              ((bool[]) buf[16])[0] = rslt.wasNull(9);
              ((String[]) buf[17])[0] = rslt.getVarchar(10) ;
              ((bool[]) buf[18])[0] = rslt.wasNull(10);
              ((String[]) buf[19])[0] = rslt.getVarchar(11) ;
              ((bool[]) buf[20])[0] = rslt.wasNull(11);
              ((decimal[]) buf[21])[0] = rslt.getDecimal(12) ;
              ((bool[]) buf[22])[0] = rslt.wasNull(12);
              ((String[]) buf[23])[0] = rslt.getVarchar(13) ;
              ((bool[]) buf[24])[0] = rslt.wasNull(13);
              ((decimal[]) buf[25])[0] = rslt.getDecimal(14) ;
              ((bool[]) buf[26])[0] = rslt.wasNull(14);
              ((String[]) buf[27])[0] = rslt.getVarchar(15) ;
              ((bool[]) buf[28])[0] = rslt.wasNull(15);
              ((String[]) buf[29])[0] = rslt.getVarchar(16) ;
              ((bool[]) buf[30])[0] = rslt.wasNull(16);
              ((String[]) buf[31])[0] = rslt.getVarchar(17) ;
              ((bool[]) buf[32])[0] = rslt.wasNull(17);
              ((long[]) buf[33])[0] = rslt.getLong(18) ;
              ((bool[]) buf[34])[0] = rslt.wasNull(18);
              return;
           case 1 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((long[]) buf[7])[0] = rslt.getLong(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((DateTime[]) buf[9])[0] = rslt.getGXDate(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              ((short[]) buf[13])[0] = rslt.getShort(8) ;
              ((bool[]) buf[14])[0] = rslt.wasNull(8);
              ((String[]) buf[15])[0] = rslt.getVarchar(9) ;
              ((bool[]) buf[16])[0] = rslt.wasNull(9);
              ((String[]) buf[17])[0] = rslt.getVarchar(10) ;
              ((bool[]) buf[18])[0] = rslt.wasNull(10);
              ((String[]) buf[19])[0] = rslt.getVarchar(11) ;
              ((bool[]) buf[20])[0] = rslt.wasNull(11);
              ((decimal[]) buf[21])[0] = rslt.getDecimal(12) ;
              ((bool[]) buf[22])[0] = rslt.wasNull(12);
              ((String[]) buf[23])[0] = rslt.getVarchar(13) ;
              ((bool[]) buf[24])[0] = rslt.wasNull(13);
              ((decimal[]) buf[25])[0] = rslt.getDecimal(14) ;
              ((bool[]) buf[26])[0] = rslt.wasNull(14);
              ((String[]) buf[27])[0] = rslt.getVarchar(15) ;
              ((bool[]) buf[28])[0] = rslt.wasNull(15);
              ((String[]) buf[29])[0] = rslt.getVarchar(16) ;
              ((bool[]) buf[30])[0] = rslt.wasNull(16);
              ((String[]) buf[31])[0] = rslt.getVarchar(17) ;
              ((bool[]) buf[32])[0] = rslt.wasNull(17);
              ((long[]) buf[33])[0] = rslt.getLong(18) ;
              ((bool[]) buf[34])[0] = rslt.wasNull(18);
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
              ((long[]) buf[11])[0] = rslt.getLong(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              ((DateTime[]) buf[13])[0] = rslt.getGXDate(8) ;
              ((bool[]) buf[14])[0] = rslt.wasNull(8);
              ((String[]) buf[15])[0] = rslt.getVarchar(9) ;
              ((bool[]) buf[16])[0] = rslt.wasNull(9);
              ((short[]) buf[17])[0] = rslt.getShort(10) ;
              ((bool[]) buf[18])[0] = rslt.wasNull(10);
              ((String[]) buf[19])[0] = rslt.getVarchar(11) ;
              ((bool[]) buf[20])[0] = rslt.wasNull(11);
              ((String[]) buf[21])[0] = rslt.getVarchar(12) ;
              ((bool[]) buf[22])[0] = rslt.wasNull(12);
              ((String[]) buf[23])[0] = rslt.getVarchar(13) ;
              ((bool[]) buf[24])[0] = rslt.wasNull(13);
              ((decimal[]) buf[25])[0] = rslt.getDecimal(14) ;
              ((bool[]) buf[26])[0] = rslt.wasNull(14);
              ((String[]) buf[27])[0] = rslt.getVarchar(15) ;
              ((bool[]) buf[28])[0] = rslt.wasNull(15);
              ((decimal[]) buf[29])[0] = rslt.getDecimal(16) ;
              ((bool[]) buf[30])[0] = rslt.wasNull(16);
              ((String[]) buf[31])[0] = rslt.getVarchar(17) ;
              ((bool[]) buf[32])[0] = rslt.wasNull(17);
              ((String[]) buf[33])[0] = rslt.getVarchar(18) ;
              ((bool[]) buf[34])[0] = rslt.wasNull(18);
              ((String[]) buf[35])[0] = rslt.getVarchar(19) ;
              ((bool[]) buf[36])[0] = rslt.wasNull(19);
              ((long[]) buf[37])[0] = rslt.getLong(20) ;
              ((bool[]) buf[38])[0] = rslt.wasNull(20);
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
              return;
           case 17 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 18 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              return;
           case 19 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((long[]) buf[3])[0] = rslt.getLong(3) ;
              ((String[]) buf[4])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[5])[0] = rslt.wasNull(4);
              return;
           case 20 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((bool[]) buf[1])[0] = rslt.wasNull(1);
              return;
           case 21 :
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
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
              }
              return;
           case 9 :
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
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
                 stmt.SetParameter(4, (long)parms[7]);
              }
              if ( (bool)parms[8] )
              {
                 stmt.setNull( 5 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameter(5, (DateTime)parms[9]);
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
                 stmt.setNull( 7 , SqlDbType.SmallInt );
              }
              else
              {
                 stmt.SetParameter(7, (short)parms[13]);
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
                 stmt.setNull( 11 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(11, (decimal)parms[21]);
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
                 stmt.setNull( 13 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(13, (decimal)parms[25]);
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
                 stmt.setNull( 17 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(17, (long)parms[33]);
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
                 stmt.SetParameter(4, (long)parms[7]);
              }
              if ( (bool)parms[8] )
              {
                 stmt.setNull( 5 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameter(5, (DateTime)parms[9]);
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
                 stmt.setNull( 7 , SqlDbType.SmallInt );
              }
              else
              {
                 stmt.SetParameter(7, (short)parms[13]);
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
                 stmt.setNull( 11 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(11, (decimal)parms[21]);
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
                 stmt.setNull( 13 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(13, (decimal)parms[25]);
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
                 stmt.setNull( 17 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(17, (long)parms[33]);
              }
              if ( (bool)parms[34] )
              {
                 stmt.setNull( 18 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(18, (long)parms[35]);
              }
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
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
              }
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
           case 15 :
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
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
              }
              return;
           case 17 :
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
              }
              return;
           case 19 :
              stmt.SetParameter(1, (String)parms[0]);
              return;
           case 20 :
              if ( (bool)parms[0] )
              {
                 stmt.setNull( 1 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(1, (long)parms[1]);
              }
              return;
           case 21 :
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
