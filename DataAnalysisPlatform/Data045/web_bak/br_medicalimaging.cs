/*
               File: BR_MedicalImaging
        Description: Data Mgmt Portal - RAAP
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:37:48.78
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
   public class br_medicalimaging : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxJX_Action33") == 0 )
         {
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            XC_33_0T30( ) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxJX_Action34") == 0 )
         {
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            XC_34_0T30( ) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxJX_Action35") == 0 )
         {
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            XC_35_0T30( ) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"BR_MEDICALIMAGING_IMAGENAME") == 0 )
         {
            AV18tCurrentCode = GetNextPar( );
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18tCurrentCode", AV18tCurrentCode);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GXDLABR_MEDICALIMAGING_IMAGENAME0T30( AV18tCurrentCode) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"BR_MEDICALIMAGING_IMAGEHOSP") == 0 )
         {
            AV18tCurrentCode = GetNextPar( );
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18tCurrentCode", AV18tCurrentCode);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GXDLABR_MEDICALIMAGING_IMAGEHOSP0T30( AV18tCurrentCode) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"BR_MEDICALIMAGING_IMAGELOC") == 0 )
         {
            AV18tCurrentCode = GetNextPar( );
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18tCurrentCode", AV18tCurrentCode);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GXDLABR_MEDICALIMAGING_IMAGELOC0T30( AV18tCurrentCode) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel18"+"_"+"BR_MEDICALIMAGING_IMAGENAME_CODE") == 0 )
         {
            A228BR_MedicalImaging_ImageName = GetNextPar( );
            n228BR_MedicalImaging_ImageName = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A228BR_MedicalImaging_ImageName", A228BR_MedicalImaging_ImageName);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX18ASABR_MEDICALIMAGING_IMAGENAME_CODE0T30( A228BR_MedicalImaging_ImageName) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel19"+"_"+"BR_MEDICALIMAGING_IMAGENAME_CODE") == 0 )
         {
            A228BR_MedicalImaging_ImageName = GetNextPar( );
            n228BR_MedicalImaging_ImageName = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A228BR_MedicalImaging_ImageName", A228BR_MedicalImaging_ImageName);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX19ASABR_MEDICALIMAGING_IMAGENAME_CODE0T30( A228BR_MedicalImaging_ImageName) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel20"+"_"+"BR_MEDICALIMAGING_IMAGEHOSP_CODE") == 0 )
         {
            A230BR_MedicalImaging_ImageHosp = GetNextPar( );
            n230BR_MedicalImaging_ImageHosp = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A230BR_MedicalImaging_ImageHosp", A230BR_MedicalImaging_ImageHosp);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX20ASABR_MEDICALIMAGING_IMAGEHOSP_CODE0T30( A230BR_MedicalImaging_ImageHosp) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel21"+"_"+"BR_MEDICALIMAGING_IMAGEHOSP_CODE") == 0 )
         {
            A230BR_MedicalImaging_ImageHosp = GetNextPar( );
            n230BR_MedicalImaging_ImageHosp = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A230BR_MedicalImaging_ImageHosp", A230BR_MedicalImaging_ImageHosp);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX21ASABR_MEDICALIMAGING_IMAGEHOSP_CODE0T30( A230BR_MedicalImaging_ImageHosp) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_37") == 0 )
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
            gxLoad_37( A19BR_EncounterID) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_38") == 0 )
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
            gxLoad_38( A85BR_Information_ID) ;
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
               AV7BR_MedicalImagingID = (long)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7BR_MedicalImagingID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7BR_MedicalImagingID), 18, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vBR_MEDICALIMAGINGID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7BR_MedicalImagingID), "ZZZZZZZZZZZZZZZZZZ"), context));
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
         GX_FocusControl = edtBR_MedicalImaging_No_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("WorkWithPlusTheme");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public br_medicalimaging( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_medicalimaging( IGxContext context )
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
                           long aP1_BR_MedicalImagingID )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV7BR_MedicalImagingID = aP1_BR_MedicalImagingID;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         dynBR_MedicalImaging_ImageName = new GXCombobox();
         dynBR_MedicalImaging_ImageHosp = new GXCombobox();
         dynBR_MedicalImaging_ImageLoc = new GXCombobox();
         cmbBR_MedicalImaging_MetastasesDX = new GXCombobox();
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
         if ( dynBR_MedicalImaging_ImageName.ItemCount > 0 )
         {
            A228BR_MedicalImaging_ImageName = dynBR_MedicalImaging_ImageName.getValidValue(A228BR_MedicalImaging_ImageName);
            n228BR_MedicalImaging_ImageName = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A228BR_MedicalImaging_ImageName", A228BR_MedicalImaging_ImageName);
         }
         if ( context.isAjaxRequest( ) )
         {
            dynBR_MedicalImaging_ImageName.CurrentValue = StringUtil.RTrim( A228BR_MedicalImaging_ImageName);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynBR_MedicalImaging_ImageName_Internalname, "Values", dynBR_MedicalImaging_ImageName.ToJavascriptSource(), true);
         }
         if ( dynBR_MedicalImaging_ImageHosp.ItemCount > 0 )
         {
            A230BR_MedicalImaging_ImageHosp = dynBR_MedicalImaging_ImageHosp.getValidValue(A230BR_MedicalImaging_ImageHosp);
            n230BR_MedicalImaging_ImageHosp = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A230BR_MedicalImaging_ImageHosp", A230BR_MedicalImaging_ImageHosp);
         }
         if ( context.isAjaxRequest( ) )
         {
            dynBR_MedicalImaging_ImageHosp.CurrentValue = StringUtil.RTrim( A230BR_MedicalImaging_ImageHosp);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynBR_MedicalImaging_ImageHosp_Internalname, "Values", dynBR_MedicalImaging_ImageHosp.ToJavascriptSource(), true);
         }
         if ( dynBR_MedicalImaging_ImageLoc.ItemCount > 0 )
         {
            A232BR_MedicalImaging_ImageLoc = dynBR_MedicalImaging_ImageLoc.getValidValue(A232BR_MedicalImaging_ImageLoc);
            n232BR_MedicalImaging_ImageLoc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A232BR_MedicalImaging_ImageLoc", A232BR_MedicalImaging_ImageLoc);
         }
         if ( context.isAjaxRequest( ) )
         {
            dynBR_MedicalImaging_ImageLoc.CurrentValue = StringUtil.RTrim( A232BR_MedicalImaging_ImageLoc);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynBR_MedicalImaging_ImageLoc_Internalname, "Values", dynBR_MedicalImaging_ImageLoc.ToJavascriptSource(), true);
         }
         if ( cmbBR_MedicalImaging_MetastasesDX.ItemCount > 0 )
         {
            A514BR_MedicalImaging_MetastasesDX = cmbBR_MedicalImaging_MetastasesDX.getValidValue(A514BR_MedicalImaging_MetastasesDX);
            n514BR_MedicalImaging_MetastasesDX = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A514BR_MedicalImaging_MetastasesDX", A514BR_MedicalImaging_MetastasesDX);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbBR_MedicalImaging_MetastasesDX.CurrentValue = StringUtil.RTrim( A514BR_MedicalImaging_MetastasesDX);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_MedicalImaging_MetastasesDX_Internalname, "Values", cmbBR_MedicalImaging_MetastasesDX.ToJavascriptSource(), true);
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
            GxWebStd.gx_div_start( context, divUnnamedtablebr_medicalimaging_no_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_medicalimaging_no_Internalname, "编号", "", "", lblTextblockbr_medicalimaging_no_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_MedicalImaging.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_MedicalImaging_No_Internalname, "编号", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_MedicalImaging_No_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A518BR_MedicalImaging_No), 18, 0, ".", "")), ((edtBR_MedicalImaging_No_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A518BR_MedicalImaging_No), "ZZZZZZZZZZZZZZZZZZ")) : context.localUtil.Format( (decimal)(A518BR_MedicalImaging_No), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,29);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_MedicalImaging_No_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBR_MedicalImaging_No_Enabled, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_MedicalImaging.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 RequiredDataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablesplittedbr_medicalimaging_imagename_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_medicalimaging_imagename_Internalname, "影像名称", "", "", lblTextblockbr_medicalimaging_imagename_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_MedicalImaging.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            wb_table1_36_0T30( true) ;
         }
         return  ;
      }

      protected void wb_table1_36_0T30e( bool wbgen )
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 RequiredDataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_medicalimaging_imageage_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_medicalimaging_imageage_Internalname, "年龄", "", "", lblTextblockbr_medicalimaging_imageage_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_MedicalImaging.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_MedicalImaging_ImageAge_Internalname, "年龄", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 52,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_MedicalImaging_ImageAge_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A231BR_MedicalImaging_ImageAge), 3, 0, ".", "")), ((edtBR_MedicalImaging_ImageAge_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A231BR_MedicalImaging_ImageAge), "ZZZ")) : context.localUtil.Format( (decimal)(A231BR_MedicalImaging_ImageAge), "ZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,52);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_MedicalImaging_ImageAge_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBR_MedicalImaging_ImageAge_Enabled, 0, "number", "1", 3, "chr", 1, "row", 3, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_MedicalImaging.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_medicalimaging_imagedate_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_medicalimaging_imagedate_Internalname, "检查日期", "", "", lblTextblockbr_medicalimaging_imagedate_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_MedicalImaging.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_MedicalImaging_ImageDate_Internalname, "检查日期", "col-sm-3 AttributeDateLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 60,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtBR_MedicalImaging_ImageDate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtBR_MedicalImaging_ImageDate_Internalname, context.localUtil.Format(A229BR_MedicalImaging_ImageDate, "9999/99/99"), context.localUtil.Format( A229BR_MedicalImaging_ImageDate, "9999/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',0,24,'chs',false,1);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,60);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_MedicalImaging_ImageDate_Jsonclick, 0, "AttributeDate", "", "", "", "", 1, edtBR_MedicalImaging_ImageDate_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "DM_Date", "right", false, "HLP_BR_MedicalImaging.htm");
            GxWebStd.gx_bitmap( context, edtBR_MedicalImaging_ImageDate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtBR_MedicalImaging_ImageDate_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_MedicalImaging.htm");
            context.WriteHtmlTextNl( "</div>") ;
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
            GxWebStd.gx_div_start( context, divUnnamedtablebr_medicalimaging_imagehosp_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_medicalimaging_imagehosp_Internalname, "行检医院", "", "", lblTextblockbr_medicalimaging_imagehosp_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_MedicalImaging.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynBR_MedicalImaging_ImageHosp_Internalname, "行检医院", "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 69,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynBR_MedicalImaging_ImageHosp, dynBR_MedicalImaging_ImageHosp_Internalname, StringUtil.RTrim( A230BR_MedicalImaging_ImageHosp), 1, dynBR_MedicalImaging_ImageHosp_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, dynBR_MedicalImaging_ImageHosp.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,69);\"", "", true, "HLP_BR_MedicalImaging.htm");
            dynBR_MedicalImaging_ImageHosp.CurrentValue = StringUtil.RTrim( A230BR_MedicalImaging_ImageHosp);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynBR_MedicalImaging_ImageHosp_Internalname, "Values", (String)(dynBR_MedicalImaging_ImageHosp.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_medicalimaging_tumorsize_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_medicalimaging_tumorsize_Internalname, "肿瘤大小", "", "", lblTextblockbr_medicalimaging_tumorsize_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_MedicalImaging.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_MedicalImaging_TumorSize_Internalname, "肿瘤大小", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 77,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_MedicalImaging_TumorSize_Internalname, A236BR_MedicalImaging_TumorSize, StringUtil.RTrim( context.localUtil.Format( A236BR_MedicalImaging_TumorSize, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,77);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_MedicalImaging_TumorSize_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBR_MedicalImaging_TumorSize_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_MedicalImaging.htm");
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
            GxWebStd.gx_div_start( context, divUnnamedtablebr_medicalimaging_preimagediag_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-2 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_medicalimaging_preimagediag_Internalname, "影像前诊断", "", "", lblTextblockbr_medicalimaging_preimagediag_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_MedicalImaging.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-10", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_MedicalImaging_PreImageDiag_Internalname, "影像前诊断", "col-sm-3 AttributeLabel", 0, true);
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 86,'',false,'',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtBR_MedicalImaging_PreImageDiag_Internalname, A234BR_MedicalImaging_PreImageDiag, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,86);\"", 0, 1, edtBR_MedicalImaging_PreImageDiag_Enabled, 0, 80, "chr", 10, "row", StyleString, ClassString, "", "", "4000", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_MedicalImaging.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablesplittedbr_medicalimaging_imageloc_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-2 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_medicalimaging_imageloc_Internalname, "检查部位(位置)", "", "", lblTextblockbr_medicalimaging_imageloc_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_MedicalImaging.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-10", "left", "top", "", "", "div");
            wb_table2_93_0T30( true) ;
         }
         return  ;
      }

      protected void wb_table2_93_0T30e( bool wbgen )
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
            GxWebStd.gx_div_start( context, divUnnamedtablebr_medicalimaging_imageorgan_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-2 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_medicalimaging_imageorgan_Internalname, "检查部位(器官)", "", "", lblTextblockbr_medicalimaging_imageorgan_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_MedicalImaging.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-10", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_MedicalImaging_ImageOrgan_Internalname, "检查部位(器官)", "col-sm-3 AttributeLabel", 0, true);
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 109,'',false,'',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtBR_MedicalImaging_ImageOrgan_Internalname, A233BR_MedicalImaging_ImageOrgan, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,109);\"", 0, 1, edtBR_MedicalImaging_ImageOrgan_Enabled, 0, 80, "chr", 10, "row", StyleString, ClassString, "", "", "5000", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_MedicalImaging.htm");
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
            GxWebStd.gx_div_start( context, divUnnamedtablebr_medicalimaging_imagedes_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-2 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_medicalimaging_imagedes_Internalname, "图像描述", "", "", lblTextblockbr_medicalimaging_imagedes_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_MedicalImaging.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-10", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_MedicalImaging_ImageDes_Internalname, "图像描述", "col-sm-3 AttributeLabel", 0, true);
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 118,'',false,'',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtBR_MedicalImaging_ImageDes_Internalname, A235BR_MedicalImaging_ImageDes, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,118);\"", 0, 1, edtBR_MedicalImaging_ImageDes_Enabled, 0, 80, "chr", 10, "row", StyleString, ClassString, "", "", "9999", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_MedicalImaging.htm");
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
            GxWebStd.gx_div_start( context, divUnnamedtablebr_medicalimaging_metastasesdx_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-2 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_medicalimaging_metastasesdx_Internalname, "是否有肿瘤转移", "", "", lblTextblockbr_medicalimaging_metastasesdx_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_MedicalImaging.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-10", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbBR_MedicalImaging_MetastasesDX_Internalname, "是否有肿瘤转移", "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 127,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbBR_MedicalImaging_MetastasesDX, cmbBR_MedicalImaging_MetastasesDX_Internalname, StringUtil.RTrim( A514BR_MedicalImaging_MetastasesDX), 1, cmbBR_MedicalImaging_MetastasesDX_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, cmbBR_MedicalImaging_MetastasesDX.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,127);\"", "", true, "HLP_BR_MedicalImaging.htm");
            cmbBR_MedicalImaging_MetastasesDX.CurrentValue = StringUtil.RTrim( A514BR_MedicalImaging_MetastasesDX);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_MedicalImaging_MetastasesDX_Internalname, "Values", (String)(cmbBR_MedicalImaging_MetastasesDX.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divBr_medicalimaging_metaloc_cell_Internalname, 1, 0, "px", 0, "px", divBr_medicalimaging_metaloc_cell_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_medicalimaging_metaloc_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_medicalimaging_metaloc_Internalname, "肿瘤转移部位", "", "", lblTextblockbr_medicalimaging_metaloc_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_MedicalImaging.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_MedicalImaging_MetaLoc_Internalname, "肿瘤转移部位", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 136,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_MedicalImaging_MetaLoc_Internalname, A515BR_MedicalImaging_MetaLoc, StringUtil.RTrim( context.localUtil.Format( A515BR_MedicalImaging_MetaLoc, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,136);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_MedicalImaging_MetaLoc_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_MedicalImaging_MetaLoc_Visible, edtBR_MedicalImaging_MetaLoc_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_MedicalImaging.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divBr_medicalimaging_metadate_cell_Internalname, 1, 0, "px", 0, "px", divBr_medicalimaging_metadate_cell_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_medicalimaging_metadate_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_medicalimaging_metadate_Internalname, "肿瘤转移时间", "", "", lblTextblockbr_medicalimaging_metadate_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_MedicalImaging.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_MedicalImaging_MetaDate_Internalname, "肿瘤转移时间", "col-sm-3 AttributeDateLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 144,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtBR_MedicalImaging_MetaDate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtBR_MedicalImaging_MetaDate_Internalname, context.localUtil.Format(A516BR_MedicalImaging_MetaDate, "9999/99/99"), context.localUtil.Format( A516BR_MedicalImaging_MetaDate, "9999/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',0,24,'chs',false,1);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,144);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_MedicalImaging_MetaDate_Jsonclick, 0, "AttributeDate", "", "", "", "", edtBR_MedicalImaging_MetaDate_Visible, edtBR_MedicalImaging_MetaDate_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "DM_Date", "right", false, "HLP_BR_MedicalImaging.htm");
            GxWebStd.gx_bitmap( context, edtBR_MedicalImaging_MetaDate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((edtBR_MedicalImaging_MetaDate_Visible==0)||(edtBR_MedicalImaging_MetaDate_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_MedicalImaging.htm");
            context.WriteHtmlTextNl( "</div>") ;
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 149,'',false,'',0)\"";
            ClassString = "ButtonMaterial";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_enter_Internalname, "", "保存", bttBtntrn_enter_Jsonclick, 5, "确认", "", StyleString, ClassString, bttBtntrn_enter_Visible, bttBtntrn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_MedicalImaging.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 151,'',false,'',0)\"";
            ClassString = "ButtonMaterialDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_cancel_Internalname, "", "取消", bttBtntrn_cancel_Jsonclick, 1, "取消", "", StyleString, ClassString, bttBtntrn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_MedicalImaging.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 153,'',false,'',0)\"";
            ClassString = "ButtonMaterialDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_delete_Internalname, "", "删除", bttBtntrn_delete_Jsonclick, 5, "删除", "", StyleString, ClassString, bttBtntrn_delete_Visible, bttBtntrn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_MedicalImaging.htm");
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
            GxWebStd.gx_single_line_edit( context, edtBR_MedicalImagingID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A225BR_MedicalImagingID), 18, 0, ".", "")), ((edtBR_MedicalImagingID_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A225BR_MedicalImagingID), "ZZZZZZZZZZZZZZZZZZ")) : context.localUtil.Format( (decimal)(A225BR_MedicalImagingID), "ZZZZZZZZZZZZZZZZZZ")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_MedicalImagingID_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_MedicalImagingID_Visible, edtBR_MedicalImagingID_Enabled, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "HLP_BR_MedicalImaging.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 158,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_EncounterID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A19BR_EncounterID), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A19BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,158);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_EncounterID_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_EncounterID_Visible, edtBR_EncounterID_Enabled, 1, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "HLP_BR_MedicalImaging.htm");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Information_PatientNo_Internalname, A36BR_Information_PatientNo, StringUtil.RTrim( context.localUtil.Format( A36BR_Information_PatientNo, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Information_PatientNo_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_Information_PatientNo_Visible, edtBR_Information_PatientNo_Enabled, 0, "text", "", 80, "chr", 1, "row", 2000, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_MedicalImaging.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 160,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_MedicalImaging_ID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A227BR_MedicalImaging_ID), 10, 0, ".", "")), ((edtBR_MedicalImaging_ID_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A227BR_MedicalImaging_ID), "ZZZZZZZZZZ")) : context.localUtil.Format( (decimal)(A227BR_MedicalImaging_ID), "ZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,160);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_MedicalImaging_ID_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_MedicalImaging_ID_Visible, edtBR_MedicalImaging_ID_Enabled, 0, "number", "1", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_MedicalImaging.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            fix_multi_value_controls( ) ;
         }
         /* Execute Exit event if defined. */
      }

      protected void wb_table2_93_0T30( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTablemergedbr_medicalimaging_imageloc_Internalname, tblTablemergedbr_medicalimaging_imageloc_Internalname, "", "TableMerged", 0, "", "", 0, 0, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='MergeDataCell'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynBR_MedicalImaging_ImageLoc_Internalname, "检查部位(位置)", "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 97,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynBR_MedicalImaging_ImageLoc, dynBR_MedicalImaging_ImageLoc_Internalname, StringUtil.RTrim( A232BR_MedicalImaging_ImageLoc), 1, dynBR_MedicalImaging_ImageLoc_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, dynBR_MedicalImaging_ImageLoc.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,97);\"", "", true, "HLP_BR_MedicalImaging.htm");
            dynBR_MedicalImaging_ImageLoc.CurrentValue = StringUtil.RTrim( A232BR_MedicalImaging_ImageLoc);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynBR_MedicalImaging_ImageLoc_Internalname, "Values", (String)(dynBR_MedicalImaging_ImageLoc.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\""+cellWxname_cell_Internalname+"\"  class='"+cellWxname_cell_Class+"'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavWxname_Internalname, "wxname", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 100,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavWxname_Internalname, AV16wxname, StringUtil.RTrim( context.localUtil.Format( AV16wxname, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,100);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "请填写其它检测部位", edtavWxname_Jsonclick, 0, "Attribute", "", "", "", "", edtavWxname_Visible, edtavWxname_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_MedicalImaging.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_93_0T30e( true) ;
         }
         else
         {
            wb_table2_93_0T30e( false) ;
         }
      }

      protected void wb_table1_36_0T30( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTablemergedbr_medicalimaging_imagename_Internalname, tblTablemergedbr_medicalimaging_imagename_Internalname, "", "TableMerged", 0, "", "", 0, 0, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='MergeDataCell'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynBR_MedicalImaging_ImageName_Internalname, "影像名称", "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 40,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynBR_MedicalImaging_ImageName, dynBR_MedicalImaging_ImageName_Internalname, StringUtil.RTrim( A228BR_MedicalImaging_ImageName), 1, dynBR_MedicalImaging_ImageName_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, dynBR_MedicalImaging_ImageName.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,40);\"", "", true, "HLP_BR_MedicalImaging.htm");
            dynBR_MedicalImaging_ImageName.CurrentValue = StringUtil.RTrim( A228BR_MedicalImaging_ImageName);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynBR_MedicalImaging_ImageName_Internalname, "Values", (String)(dynBR_MedicalImaging_ImageName.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\""+cellVname_cell_Internalname+"\"  class='"+cellVname_cell_Class+"'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavVname_Internalname, "v Name", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavVname_Internalname, AV15vName, StringUtil.RTrim( context.localUtil.Format( AV15vName, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,43);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "请填写其它影像名称", edtavVname_Jsonclick, 0, "Attribute", "", "", "", "", edtavVname_Visible, edtavVname_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_MedicalImaging.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_36_0T30e( true) ;
         }
         else
         {
            wb_table1_36_0T30e( false) ;
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
         E110T2 ();
         context.wbGlbDoneStart = 1;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
               if ( ( ( context.localUtil.CToN( cgiGet( edtBR_MedicalImaging_No_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtBR_MedicalImaging_No_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_MEDICALIMAGING_NO");
                  AnyError = 1;
                  GX_FocusControl = edtBR_MedicalImaging_No_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A518BR_MedicalImaging_No = 0;
                  n518BR_MedicalImaging_No = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A518BR_MedicalImaging_No", StringUtil.LTrim( StringUtil.Str( (decimal)(A518BR_MedicalImaging_No), 18, 0)));
               }
               else
               {
                  A518BR_MedicalImaging_No = (long)(context.localUtil.CToN( cgiGet( edtBR_MedicalImaging_No_Internalname), ".", ","));
                  n518BR_MedicalImaging_No = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A518BR_MedicalImaging_No", StringUtil.LTrim( StringUtil.Str( (decimal)(A518BR_MedicalImaging_No), 18, 0)));
               }
               n518BR_MedicalImaging_No = ((0==A518BR_MedicalImaging_No) ? true : false);
               dynBR_MedicalImaging_ImageName.CurrentValue = cgiGet( dynBR_MedicalImaging_ImageName_Internalname);
               A228BR_MedicalImaging_ImageName = cgiGet( dynBR_MedicalImaging_ImageName_Internalname);
               n228BR_MedicalImaging_ImageName = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A228BR_MedicalImaging_ImageName", A228BR_MedicalImaging_ImageName);
               n228BR_MedicalImaging_ImageName = (String.IsNullOrEmpty(StringUtil.RTrim( A228BR_MedicalImaging_ImageName)) ? true : false);
               AV15vName = cgiGet( edtavVname_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15vName", AV15vName);
               if ( ( ( context.localUtil.CToN( cgiGet( edtBR_MedicalImaging_ImageAge_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtBR_MedicalImaging_ImageAge_Internalname), ".", ",") > Convert.ToDecimal( 999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_MEDICALIMAGING_IMAGEAGE");
                  AnyError = 1;
                  GX_FocusControl = edtBR_MedicalImaging_ImageAge_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A231BR_MedicalImaging_ImageAge = 0;
                  n231BR_MedicalImaging_ImageAge = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A231BR_MedicalImaging_ImageAge", StringUtil.LTrim( StringUtil.Str( (decimal)(A231BR_MedicalImaging_ImageAge), 3, 0)));
               }
               else
               {
                  A231BR_MedicalImaging_ImageAge = (short)(context.localUtil.CToN( cgiGet( edtBR_MedicalImaging_ImageAge_Internalname), ".", ","));
                  n231BR_MedicalImaging_ImageAge = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A231BR_MedicalImaging_ImageAge", StringUtil.LTrim( StringUtil.Str( (decimal)(A231BR_MedicalImaging_ImageAge), 3, 0)));
               }
               n231BR_MedicalImaging_ImageAge = ((0==A231BR_MedicalImaging_ImageAge) ? true : false);
               if ( context.localUtil.VCDate( cgiGet( edtBR_MedicalImaging_ImageDate_Internalname), 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"检查日期"}), 1, "BR_MEDICALIMAGING_IMAGEDATE");
                  AnyError = 1;
                  GX_FocusControl = edtBR_MedicalImaging_ImageDate_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A229BR_MedicalImaging_ImageDate = DateTime.MinValue;
                  n229BR_MedicalImaging_ImageDate = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A229BR_MedicalImaging_ImageDate", context.localUtil.Format(A229BR_MedicalImaging_ImageDate, "9999/99/99"));
               }
               else
               {
                  A229BR_MedicalImaging_ImageDate = context.localUtil.CToD( cgiGet( edtBR_MedicalImaging_ImageDate_Internalname), 0);
                  n229BR_MedicalImaging_ImageDate = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A229BR_MedicalImaging_ImageDate", context.localUtil.Format(A229BR_MedicalImaging_ImageDate, "9999/99/99"));
               }
               n229BR_MedicalImaging_ImageDate = ((DateTime.MinValue==A229BR_MedicalImaging_ImageDate) ? true : false);
               dynBR_MedicalImaging_ImageHosp.CurrentValue = cgiGet( dynBR_MedicalImaging_ImageHosp_Internalname);
               A230BR_MedicalImaging_ImageHosp = cgiGet( dynBR_MedicalImaging_ImageHosp_Internalname);
               n230BR_MedicalImaging_ImageHosp = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A230BR_MedicalImaging_ImageHosp", A230BR_MedicalImaging_ImageHosp);
               n230BR_MedicalImaging_ImageHosp = (String.IsNullOrEmpty(StringUtil.RTrim( A230BR_MedicalImaging_ImageHosp)) ? true : false);
               A236BR_MedicalImaging_TumorSize = cgiGet( edtBR_MedicalImaging_TumorSize_Internalname);
               n236BR_MedicalImaging_TumorSize = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A236BR_MedicalImaging_TumorSize", A236BR_MedicalImaging_TumorSize);
               n236BR_MedicalImaging_TumorSize = (String.IsNullOrEmpty(StringUtil.RTrim( A236BR_MedicalImaging_TumorSize)) ? true : false);
               A234BR_MedicalImaging_PreImageDiag = cgiGet( edtBR_MedicalImaging_PreImageDiag_Internalname);
               n234BR_MedicalImaging_PreImageDiag = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A234BR_MedicalImaging_PreImageDiag", A234BR_MedicalImaging_PreImageDiag);
               n234BR_MedicalImaging_PreImageDiag = (String.IsNullOrEmpty(StringUtil.RTrim( A234BR_MedicalImaging_PreImageDiag)) ? true : false);
               dynBR_MedicalImaging_ImageLoc.CurrentValue = cgiGet( dynBR_MedicalImaging_ImageLoc_Internalname);
               A232BR_MedicalImaging_ImageLoc = cgiGet( dynBR_MedicalImaging_ImageLoc_Internalname);
               n232BR_MedicalImaging_ImageLoc = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A232BR_MedicalImaging_ImageLoc", A232BR_MedicalImaging_ImageLoc);
               n232BR_MedicalImaging_ImageLoc = (String.IsNullOrEmpty(StringUtil.RTrim( A232BR_MedicalImaging_ImageLoc)) ? true : false);
               AV16wxname = cgiGet( edtavWxname_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16wxname", AV16wxname);
               A233BR_MedicalImaging_ImageOrgan = cgiGet( edtBR_MedicalImaging_ImageOrgan_Internalname);
               n233BR_MedicalImaging_ImageOrgan = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A233BR_MedicalImaging_ImageOrgan", A233BR_MedicalImaging_ImageOrgan);
               n233BR_MedicalImaging_ImageOrgan = (String.IsNullOrEmpty(StringUtil.RTrim( A233BR_MedicalImaging_ImageOrgan)) ? true : false);
               A235BR_MedicalImaging_ImageDes = cgiGet( edtBR_MedicalImaging_ImageDes_Internalname);
               n235BR_MedicalImaging_ImageDes = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A235BR_MedicalImaging_ImageDes", A235BR_MedicalImaging_ImageDes);
               n235BR_MedicalImaging_ImageDes = (String.IsNullOrEmpty(StringUtil.RTrim( A235BR_MedicalImaging_ImageDes)) ? true : false);
               cmbBR_MedicalImaging_MetastasesDX.CurrentValue = cgiGet( cmbBR_MedicalImaging_MetastasesDX_Internalname);
               A514BR_MedicalImaging_MetastasesDX = cgiGet( cmbBR_MedicalImaging_MetastasesDX_Internalname);
               n514BR_MedicalImaging_MetastasesDX = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A514BR_MedicalImaging_MetastasesDX", A514BR_MedicalImaging_MetastasesDX);
               n514BR_MedicalImaging_MetastasesDX = (String.IsNullOrEmpty(StringUtil.RTrim( A514BR_MedicalImaging_MetastasesDX)) ? true : false);
               A515BR_MedicalImaging_MetaLoc = cgiGet( edtBR_MedicalImaging_MetaLoc_Internalname);
               n515BR_MedicalImaging_MetaLoc = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A515BR_MedicalImaging_MetaLoc", A515BR_MedicalImaging_MetaLoc);
               n515BR_MedicalImaging_MetaLoc = (String.IsNullOrEmpty(StringUtil.RTrim( A515BR_MedicalImaging_MetaLoc)) ? true : false);
               if ( context.localUtil.VCDate( cgiGet( edtBR_MedicalImaging_MetaDate_Internalname), 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"肿瘤转移时间"}), 1, "BR_MEDICALIMAGING_METADATE");
                  AnyError = 1;
                  GX_FocusControl = edtBR_MedicalImaging_MetaDate_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A516BR_MedicalImaging_MetaDate = DateTime.MinValue;
                  n516BR_MedicalImaging_MetaDate = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A516BR_MedicalImaging_MetaDate", context.localUtil.Format(A516BR_MedicalImaging_MetaDate, "9999/99/99"));
               }
               else
               {
                  A516BR_MedicalImaging_MetaDate = context.localUtil.CToD( cgiGet( edtBR_MedicalImaging_MetaDate_Internalname), 0);
                  n516BR_MedicalImaging_MetaDate = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A516BR_MedicalImaging_MetaDate", context.localUtil.Format(A516BR_MedicalImaging_MetaDate, "9999/99/99"));
               }
               n516BR_MedicalImaging_MetaDate = ((DateTime.MinValue==A516BR_MedicalImaging_MetaDate) ? true : false);
               A225BR_MedicalImagingID = (long)(context.localUtil.CToN( cgiGet( edtBR_MedicalImagingID_Internalname), ".", ","));
               n225BR_MedicalImagingID = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A225BR_MedicalImagingID", StringUtil.LTrim( StringUtil.Str( (decimal)(A225BR_MedicalImagingID), 18, 0)));
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
               if ( ( ( context.localUtil.CToN( cgiGet( edtBR_MedicalImaging_ID_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtBR_MedicalImaging_ID_Internalname), ".", ",") > Convert.ToDecimal( 9999999999L )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_MEDICALIMAGING_ID");
                  AnyError = 1;
                  GX_FocusControl = edtBR_MedicalImaging_ID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A227BR_MedicalImaging_ID = 0;
                  n227BR_MedicalImaging_ID = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A227BR_MedicalImaging_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A227BR_MedicalImaging_ID), 10, 0)));
               }
               else
               {
                  A227BR_MedicalImaging_ID = (long)(context.localUtil.CToN( cgiGet( edtBR_MedicalImaging_ID_Internalname), ".", ","));
                  n227BR_MedicalImaging_ID = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A227BR_MedicalImaging_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A227BR_MedicalImaging_ID), 10, 0)));
               }
               n227BR_MedicalImaging_ID = ((0==A227BR_MedicalImaging_ID) ? true : false);
               /* Read saved values. */
               Z225BR_MedicalImagingID = (long)(context.localUtil.CToN( cgiGet( "Z225BR_MedicalImagingID"), ".", ","));
               Z484BR_MedicalImaging_ImageName_Code = cgiGet( "Z484BR_MedicalImaging_ImageName_Code");
               n484BR_MedicalImaging_ImageName_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A484BR_MedicalImaging_ImageName_Code)) ? true : false);
               Z485BR_MedicalImaging_ImageHosp_Code = cgiGet( "Z485BR_MedicalImaging_ImageHosp_Code");
               n485BR_MedicalImaging_ImageHosp_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A485BR_MedicalImaging_ImageHosp_Code)) ? true : false);
               Z227BR_MedicalImaging_ID = (long)(context.localUtil.CToN( cgiGet( "Z227BR_MedicalImaging_ID"), ".", ","));
               n227BR_MedicalImaging_ID = ((0==A227BR_MedicalImaging_ID) ? true : false);
               Z518BR_MedicalImaging_No = (long)(context.localUtil.CToN( cgiGet( "Z518BR_MedicalImaging_No"), ".", ","));
               n518BR_MedicalImaging_No = ((0==A518BR_MedicalImaging_No) ? true : false);
               Z228BR_MedicalImaging_ImageName = cgiGet( "Z228BR_MedicalImaging_ImageName");
               n228BR_MedicalImaging_ImageName = (String.IsNullOrEmpty(StringUtil.RTrim( A228BR_MedicalImaging_ImageName)) ? true : false);
               Z229BR_MedicalImaging_ImageDate = context.localUtil.CToD( cgiGet( "Z229BR_MedicalImaging_ImageDate"), 0);
               n229BR_MedicalImaging_ImageDate = ((DateTime.MinValue==A229BR_MedicalImaging_ImageDate) ? true : false);
               Z230BR_MedicalImaging_ImageHosp = cgiGet( "Z230BR_MedicalImaging_ImageHosp");
               n230BR_MedicalImaging_ImageHosp = (String.IsNullOrEmpty(StringUtil.RTrim( A230BR_MedicalImaging_ImageHosp)) ? true : false);
               Z231BR_MedicalImaging_ImageAge = (short)(context.localUtil.CToN( cgiGet( "Z231BR_MedicalImaging_ImageAge"), ".", ","));
               n231BR_MedicalImaging_ImageAge = ((0==A231BR_MedicalImaging_ImageAge) ? true : false);
               Z232BR_MedicalImaging_ImageLoc = cgiGet( "Z232BR_MedicalImaging_ImageLoc");
               n232BR_MedicalImaging_ImageLoc = (String.IsNullOrEmpty(StringUtil.RTrim( A232BR_MedicalImaging_ImageLoc)) ? true : false);
               Z486BR_MedicalImaging_ImageLoc_Code = cgiGet( "Z486BR_MedicalImaging_ImageLoc_Code");
               n486BR_MedicalImaging_ImageLoc_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A486BR_MedicalImaging_ImageLoc_Code)) ? true : false);
               Z233BR_MedicalImaging_ImageOrgan = cgiGet( "Z233BR_MedicalImaging_ImageOrgan");
               n233BR_MedicalImaging_ImageOrgan = (String.IsNullOrEmpty(StringUtil.RTrim( A233BR_MedicalImaging_ImageOrgan)) ? true : false);
               Z234BR_MedicalImaging_PreImageDiag = cgiGet( "Z234BR_MedicalImaging_PreImageDiag");
               n234BR_MedicalImaging_PreImageDiag = (String.IsNullOrEmpty(StringUtil.RTrim( A234BR_MedicalImaging_PreImageDiag)) ? true : false);
               Z235BR_MedicalImaging_ImageDes = cgiGet( "Z235BR_MedicalImaging_ImageDes");
               n235BR_MedicalImaging_ImageDes = (String.IsNullOrEmpty(StringUtil.RTrim( A235BR_MedicalImaging_ImageDes)) ? true : false);
               Z236BR_MedicalImaging_TumorSize = cgiGet( "Z236BR_MedicalImaging_TumorSize");
               n236BR_MedicalImaging_TumorSize = (String.IsNullOrEmpty(StringUtil.RTrim( A236BR_MedicalImaging_TumorSize)) ? true : false);
               Z514BR_MedicalImaging_MetastasesDX = cgiGet( "Z514BR_MedicalImaging_MetastasesDX");
               n514BR_MedicalImaging_MetastasesDX = (String.IsNullOrEmpty(StringUtil.RTrim( A514BR_MedicalImaging_MetastasesDX)) ? true : false);
               Z515BR_MedicalImaging_MetaLoc = cgiGet( "Z515BR_MedicalImaging_MetaLoc");
               n515BR_MedicalImaging_MetaLoc = (String.IsNullOrEmpty(StringUtil.RTrim( A515BR_MedicalImaging_MetaLoc)) ? true : false);
               Z516BR_MedicalImaging_MetaDate = context.localUtil.CToD( cgiGet( "Z516BR_MedicalImaging_MetaDate"), 0);
               n516BR_MedicalImaging_MetaDate = ((DateTime.MinValue==A516BR_MedicalImaging_MetaDate) ? true : false);
               Z19BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( "Z19BR_EncounterID"), ".", ","));
               n19BR_EncounterID = ((0==A19BR_EncounterID) ? true : false);
               A484BR_MedicalImaging_ImageName_Code = cgiGet( "Z484BR_MedicalImaging_ImageName_Code");
               n484BR_MedicalImaging_ImageName_Code = false;
               n484BR_MedicalImaging_ImageName_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A484BR_MedicalImaging_ImageName_Code)) ? true : false);
               A485BR_MedicalImaging_ImageHosp_Code = cgiGet( "Z485BR_MedicalImaging_ImageHosp_Code");
               n485BR_MedicalImaging_ImageHosp_Code = false;
               n485BR_MedicalImaging_ImageHosp_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A485BR_MedicalImaging_ImageHosp_Code)) ? true : false);
               A486BR_MedicalImaging_ImageLoc_Code = cgiGet( "Z486BR_MedicalImaging_ImageLoc_Code");
               n486BR_MedicalImaging_ImageLoc_Code = false;
               n486BR_MedicalImaging_ImageLoc_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A486BR_MedicalImaging_ImageLoc_Code)) ? true : false);
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ","));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ","));
               Gx_mode = cgiGet( "Mode");
               N19BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( "N19BR_EncounterID"), ".", ","));
               n19BR_EncounterID = ((0==A19BR_EncounterID) ? true : false);
               AV7BR_MedicalImagingID = (long)(context.localUtil.CToN( cgiGet( "vBR_MEDICALIMAGINGID"), ".", ","));
               AV13Insert_BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( "vINSERT_BR_ENCOUNTERID"), ".", ","));
               A484BR_MedicalImaging_ImageName_Code = cgiGet( "BR_MEDICALIMAGING_IMAGENAME_CODE");
               n484BR_MedicalImaging_ImageName_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A484BR_MedicalImaging_ImageName_Code)) ? true : false);
               A485BR_MedicalImaging_ImageHosp_Code = cgiGet( "BR_MEDICALIMAGING_IMAGEHOSP_CODE");
               n485BR_MedicalImaging_ImageHosp_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A485BR_MedicalImaging_ImageHosp_Code)) ? true : false);
               AV18tCurrentCode = cgiGet( "vTCURRENTCODE");
               A486BR_MedicalImaging_ImageLoc_Code = cgiGet( "BR_MEDICALIMAGING_IMAGELOC_CODE");
               n486BR_MedicalImaging_ImageLoc_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A486BR_MedicalImaging_ImageLoc_Code)) ? true : false);
               A334BR_MedicalImaging_ImageHtml = cgiGet( "BR_MEDICALIMAGING_IMAGEHTML");
               n334BR_MedicalImaging_ImageHtml = false;
               n334BR_MedicalImaging_ImageHtml = (String.IsNullOrEmpty(StringUtil.RTrim( A334BR_MedicalImaging_ImageHtml)) ? true : false);
               A85BR_Information_ID = (long)(context.localUtil.CToN( cgiGet( "BR_INFORMATION_ID"), ".", ","));
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
               forbiddenHiddens = "hsh" + "BR_MedicalImaging";
               A225BR_MedicalImagingID = (long)(context.localUtil.CToN( cgiGet( edtBR_MedicalImagingID_Internalname), ".", ","));
               n225BR_MedicalImagingID = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A225BR_MedicalImagingID", StringUtil.LTrim( StringUtil.Str( (decimal)(A225BR_MedicalImagingID), 18, 0)));
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A225BR_MedicalImagingID), "ZZZZZZZZZZZZZZZZZZ");
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( AV18tCurrentCode, ""));
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV13Insert_BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ");
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A486BR_MedicalImaging_ImageLoc_Code, ""));
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( A225BR_MedicalImagingID != Z225BR_MedicalImagingID ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
               {
                  GXUtil.WriteLog("br_medicalimaging:[SecurityCheckFailed value for]"+"BR_MedicalImagingID:"+context.localUtil.Format( (decimal)(A225BR_MedicalImagingID), "ZZZZZZZZZZZZZZZZZZ"));
                  GXUtil.WriteLog("br_medicalimaging:[SecurityCheckFailed value for]"+"tCurrentCode:"+StringUtil.RTrim( context.localUtil.Format( AV18tCurrentCode, "")));
                  GXUtil.WriteLog("br_medicalimaging:[SecurityCheckFailed value for]"+"Insert_BR_EncounterID:"+context.localUtil.Format( (decimal)(AV13Insert_BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ"));
                  GXUtil.WriteLog("br_medicalimaging:[SecurityCheckFailed value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
                  GXUtil.WriteLog("br_medicalimaging:[SecurityCheckFailed value for]"+"BR_MedicalImaging_ImageLoc_Code:"+StringUtil.RTrim( context.localUtil.Format( A486BR_MedicalImaging_ImageLoc_Code, "")));
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
                  A225BR_MedicalImagingID = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  n225BR_MedicalImagingID = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A225BR_MedicalImagingID", StringUtil.LTrim( StringUtil.Str( (decimal)(A225BR_MedicalImagingID), 18, 0)));
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
                     sMode30 = Gx_mode;
                     Gx_mode = "UPD";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     Gx_mode = sMode30;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound30 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_0T0( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtntrn_enter_Internalname;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert", ""), 1, "BR_MEDICALIMAGINGID");
                        AnyError = 1;
                        GX_FocusControl = edtBR_MedicalImagingID_Internalname;
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
                           E110T2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: After Trn */
                           E120T2 ();
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
            E120T2 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll0T30( ) ;
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
            DisableAttributes0T30( ) ;
         }
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVname_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVname_Enabled), 5, 0)), true);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavWxname_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavWxname_Enabled), 5, 0)), true);
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

      protected void CONFIRM_0T0( )
      {
         BeforeValidate0T30( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0T30( ) ;
            }
            else
            {
               CheckExtendedTable0T30( ) ;
               CloseExtendedTableCursors0T30( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         }
      }

      protected void ResetCaption0T0( )
      {
      }

      protected void E110T2( )
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
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_MedicalImaging", out  GXt_boolean2) ;
            AV9IsAuthorized = GXt_boolean2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9IsAuthorized", AV9IsAuthorized);
         }
         if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
         {
            GXt_boolean2 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_MedicalImaging", out  GXt_boolean2) ;
            AV9IsAuthorized = GXt_boolean2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9IsAuthorized", AV9IsAuthorized);
         }
         if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
         {
            GXt_boolean2 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_MedicalImaging", out  GXt_boolean2) ;
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
         edtBR_MedicalImagingID_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_MedicalImagingID_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_MedicalImagingID_Visible), 5, 0)), true);
         edtBR_EncounterID_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_EncounterID_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_EncounterID_Visible), 5, 0)), true);
         edtBR_Information_PatientNo_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Information_PatientNo_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Information_PatientNo_Visible), 5, 0)), true);
         edtBR_MedicalImaging_ID_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_MedicalImaging_ID_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_MedicalImaging_ID_Visible), 5, 0)), true);
         GXt_boolean2 = AV17TempBoolean;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_MedicalImaging", out  GXt_boolean2) ;
         AV17TempBoolean = GXt_boolean2;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17TempBoolean", AV17TempBoolean);
         if ( ! ( AV17TempBoolean ) )
         {
            bttBtntrn_enter_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_enter_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_enter_Visible), 5, 0)), true);
         }
         GXt_boolean2 = AV17TempBoolean;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_MedicalImaging", out  GXt_boolean2) ;
         AV17TempBoolean = GXt_boolean2;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17TempBoolean", AV17TempBoolean);
         if ( ! ( AV17TempBoolean ) )
         {
            bttBtntrn_cancel_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_cancel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_cancel_Visible), 5, 0)), true);
         }
         GXt_boolean2 = AV17TempBoolean;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_MedicalImaging", out  GXt_boolean2) ;
         AV17TempBoolean = GXt_boolean2;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17TempBoolean", AV17TempBoolean);
         if ( ! ( AV17TempBoolean ) )
         {
            bttBtntrn_delete_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_delete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_delete_Visible), 5, 0)), true);
         }
      }

      protected void E120T2( )
      {
         /* After Trn Routine */
         if ( 1 == 0 )
         {
            if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV11TrnContext.gxTpr_Callerondelete )
            {
               CallWebObject(formatLink("br_medicalimagingww.aspx") );
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
            CallWebObject(formatLink("br_medicalimagingview.aspx") + "?" + UrlEncode("" +A225BR_MedicalImagingID) + "," + UrlEncode(StringUtil.RTrim("General")));
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
         edtavVname_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVname_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVname_Visible), 5, 0)), true);
         cellVname_cell_Class = "Invisible";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVname_cell_Internalname, "Class", cellVname_cell_Class, true);
         edtavWxname_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavWxname_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavWxname_Visible), 5, 0)), true);
         cellWxname_cell_Class = "Invisible";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellWxname_cell_Internalname, "Class", cellWxname_cell_Class, true);
         edtBR_MedicalImaging_MetaLoc_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_MedicalImaging_MetaLoc_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_MedicalImaging_MetaLoc_Visible), 5, 0)), true);
         divBr_medicalimaging_metaloc_cell_Class = "Invisible";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, divBr_medicalimaging_metaloc_cell_Internalname, "Class", divBr_medicalimaging_metaloc_cell_Class, true);
         edtBR_MedicalImaging_MetaDate_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_MedicalImaging_MetaDate_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_MedicalImaging_MetaDate_Visible), 5, 0)), true);
         divBr_medicalimaging_metadate_cell_Class = "Invisible";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, divBr_medicalimaging_metadate_cell_Internalname, "Class", divBr_medicalimaging_metadate_cell_Class, true);
      }

      protected void ZM0T30( short GX_JID )
      {
         if ( ( GX_JID == 36 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z484BR_MedicalImaging_ImageName_Code = T000T3_A484BR_MedicalImaging_ImageName_Code[0];
               Z485BR_MedicalImaging_ImageHosp_Code = T000T3_A485BR_MedicalImaging_ImageHosp_Code[0];
               Z227BR_MedicalImaging_ID = T000T3_A227BR_MedicalImaging_ID[0];
               Z518BR_MedicalImaging_No = T000T3_A518BR_MedicalImaging_No[0];
               Z228BR_MedicalImaging_ImageName = T000T3_A228BR_MedicalImaging_ImageName[0];
               Z229BR_MedicalImaging_ImageDate = T000T3_A229BR_MedicalImaging_ImageDate[0];
               Z230BR_MedicalImaging_ImageHosp = T000T3_A230BR_MedicalImaging_ImageHosp[0];
               Z231BR_MedicalImaging_ImageAge = T000T3_A231BR_MedicalImaging_ImageAge[0];
               Z232BR_MedicalImaging_ImageLoc = T000T3_A232BR_MedicalImaging_ImageLoc[0];
               Z486BR_MedicalImaging_ImageLoc_Code = T000T3_A486BR_MedicalImaging_ImageLoc_Code[0];
               Z233BR_MedicalImaging_ImageOrgan = T000T3_A233BR_MedicalImaging_ImageOrgan[0];
               Z234BR_MedicalImaging_PreImageDiag = T000T3_A234BR_MedicalImaging_PreImageDiag[0];
               Z235BR_MedicalImaging_ImageDes = T000T3_A235BR_MedicalImaging_ImageDes[0];
               Z236BR_MedicalImaging_TumorSize = T000T3_A236BR_MedicalImaging_TumorSize[0];
               Z514BR_MedicalImaging_MetastasesDX = T000T3_A514BR_MedicalImaging_MetastasesDX[0];
               Z515BR_MedicalImaging_MetaLoc = T000T3_A515BR_MedicalImaging_MetaLoc[0];
               Z516BR_MedicalImaging_MetaDate = T000T3_A516BR_MedicalImaging_MetaDate[0];
               Z19BR_EncounterID = T000T3_A19BR_EncounterID[0];
            }
            else
            {
               Z484BR_MedicalImaging_ImageName_Code = A484BR_MedicalImaging_ImageName_Code;
               Z485BR_MedicalImaging_ImageHosp_Code = A485BR_MedicalImaging_ImageHosp_Code;
               Z227BR_MedicalImaging_ID = A227BR_MedicalImaging_ID;
               Z518BR_MedicalImaging_No = A518BR_MedicalImaging_No;
               Z228BR_MedicalImaging_ImageName = A228BR_MedicalImaging_ImageName;
               Z229BR_MedicalImaging_ImageDate = A229BR_MedicalImaging_ImageDate;
               Z230BR_MedicalImaging_ImageHosp = A230BR_MedicalImaging_ImageHosp;
               Z231BR_MedicalImaging_ImageAge = A231BR_MedicalImaging_ImageAge;
               Z232BR_MedicalImaging_ImageLoc = A232BR_MedicalImaging_ImageLoc;
               Z486BR_MedicalImaging_ImageLoc_Code = A486BR_MedicalImaging_ImageLoc_Code;
               Z233BR_MedicalImaging_ImageOrgan = A233BR_MedicalImaging_ImageOrgan;
               Z234BR_MedicalImaging_PreImageDiag = A234BR_MedicalImaging_PreImageDiag;
               Z235BR_MedicalImaging_ImageDes = A235BR_MedicalImaging_ImageDes;
               Z236BR_MedicalImaging_TumorSize = A236BR_MedicalImaging_TumorSize;
               Z514BR_MedicalImaging_MetastasesDX = A514BR_MedicalImaging_MetastasesDX;
               Z515BR_MedicalImaging_MetaLoc = A515BR_MedicalImaging_MetaLoc;
               Z516BR_MedicalImaging_MetaDate = A516BR_MedicalImaging_MetaDate;
               Z19BR_EncounterID = A19BR_EncounterID;
            }
         }
         if ( GX_JID == -36 )
         {
            Z225BR_MedicalImagingID = A225BR_MedicalImagingID;
            Z484BR_MedicalImaging_ImageName_Code = A484BR_MedicalImaging_ImageName_Code;
            Z485BR_MedicalImaging_ImageHosp_Code = A485BR_MedicalImaging_ImageHosp_Code;
            Z227BR_MedicalImaging_ID = A227BR_MedicalImaging_ID;
            Z518BR_MedicalImaging_No = A518BR_MedicalImaging_No;
            Z228BR_MedicalImaging_ImageName = A228BR_MedicalImaging_ImageName;
            Z229BR_MedicalImaging_ImageDate = A229BR_MedicalImaging_ImageDate;
            Z230BR_MedicalImaging_ImageHosp = A230BR_MedicalImaging_ImageHosp;
            Z231BR_MedicalImaging_ImageAge = A231BR_MedicalImaging_ImageAge;
            Z232BR_MedicalImaging_ImageLoc = A232BR_MedicalImaging_ImageLoc;
            Z486BR_MedicalImaging_ImageLoc_Code = A486BR_MedicalImaging_ImageLoc_Code;
            Z233BR_MedicalImaging_ImageOrgan = A233BR_MedicalImaging_ImageOrgan;
            Z234BR_MedicalImaging_PreImageDiag = A234BR_MedicalImaging_PreImageDiag;
            Z235BR_MedicalImaging_ImageDes = A235BR_MedicalImaging_ImageDes;
            Z236BR_MedicalImaging_TumorSize = A236BR_MedicalImaging_TumorSize;
            Z334BR_MedicalImaging_ImageHtml = A334BR_MedicalImaging_ImageHtml;
            Z514BR_MedicalImaging_MetastasesDX = A514BR_MedicalImaging_MetastasesDX;
            Z515BR_MedicalImaging_MetaLoc = A515BR_MedicalImaging_MetaLoc;
            Z516BR_MedicalImaging_MetaDate = A516BR_MedicalImaging_MetaDate;
            Z19BR_EncounterID = A19BR_EncounterID;
            Z85BR_Information_ID = A85BR_Information_ID;
            Z36BR_Information_PatientNo = A36BR_Information_PatientNo;
         }
      }

      protected void standaloneNotModal( )
      {
         edtBR_MedicalImagingID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_MedicalImagingID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_MedicalImagingID_Enabled), 5, 0)), true);
         edtBR_MedicalImagingID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_MedicalImagingID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_MedicalImagingID_Enabled), 5, 0)), true);
         bttBtntrn_delete_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_delete_Enabled), 5, 0)), true);
         if ( ! (0==AV7BR_MedicalImagingID) )
         {
            A225BR_MedicalImagingID = AV7BR_MedicalImagingID;
            n225BR_MedicalImagingID = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A225BR_MedicalImagingID", StringUtil.LTrim( StringUtil.Str( (decimal)(A225BR_MedicalImagingID), 18, 0)));
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
         GXABR_MEDICALIMAGING_IMAGENAME_html0T30( AV18tCurrentCode) ;
         GXABR_MEDICALIMAGING_IMAGEHOSP_html0T30( AV18tCurrentCode) ;
         GXABR_MEDICALIMAGING_IMAGELOC_html0T30( AV18tCurrentCode) ;
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
            AV19Pgmname = "BR_MedicalImaging";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19Pgmname", AV19Pgmname);
            edtavVname_Visible = ((StringUtil.StrCmp(A228BR_MedicalImaging_ImageName, "其它")==0) ? 1 : 0);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVname_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVname_Visible), 5, 0)), true);
            if ( ! ( ( StringUtil.StrCmp(A228BR_MedicalImaging_ImageName, "其它") == 0 ) ) )
            {
               cellVname_cell_Class = "Invisible";
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVname_cell_Internalname, "Class", cellVname_cell_Class, true);
            }
            else
            {
               if ( StringUtil.StrCmp(A228BR_MedicalImaging_ImageName, "其它") == 0 )
               {
                  cellVname_cell_Class = "RequiredDataContentCell";
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVname_cell_Internalname, "Class", cellVname_cell_Class, true);
               }
            }
            edtavWxname_Visible = ((StringUtil.StrCmp(A232BR_MedicalImaging_ImageLoc, "其它")==0) ? 1 : 0);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavWxname_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavWxname_Visible), 5, 0)), true);
            if ( ! ( ( StringUtil.StrCmp(A232BR_MedicalImaging_ImageLoc, "其它") == 0 ) ) )
            {
               cellWxname_cell_Class = "Invisible";
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellWxname_cell_Internalname, "Class", cellWxname_cell_Class, true);
            }
            else
            {
               if ( StringUtil.StrCmp(A232BR_MedicalImaging_ImageLoc, "其它") == 0 )
               {
                  cellWxname_cell_Class = "RequiredDataContentCell";
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellWxname_cell_Internalname, "Class", cellWxname_cell_Class, true);
               }
            }
            /* Using cursor T000T4 */
            pr_default.execute(2, new Object[] {n19BR_EncounterID, A19BR_EncounterID});
            A85BR_Information_ID = T000T4_A85BR_Information_ID[0];
            n85BR_Information_ID = T000T4_n85BR_Information_ID[0];
            pr_default.close(2);
            /* Using cursor T000T5 */
            pr_default.execute(3, new Object[] {n85BR_Information_ID, A85BR_Information_ID});
            A36BR_Information_PatientNo = T000T5_A36BR_Information_PatientNo[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36BR_Information_PatientNo", A36BR_Information_PatientNo);
            n36BR_Information_PatientNo = T000T5_n36BR_Information_PatientNo[0];
            pr_default.close(3);
         }
      }

      protected void Load0T30( )
      {
         /* Using cursor T000T6 */
         pr_default.execute(4, new Object[] {n225BR_MedicalImagingID, A225BR_MedicalImagingID});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound30 = 1;
            A85BR_Information_ID = T000T6_A85BR_Information_ID[0];
            n85BR_Information_ID = T000T6_n85BR_Information_ID[0];
            A484BR_MedicalImaging_ImageName_Code = T000T6_A484BR_MedicalImaging_ImageName_Code[0];
            n484BR_MedicalImaging_ImageName_Code = T000T6_n484BR_MedicalImaging_ImageName_Code[0];
            A485BR_MedicalImaging_ImageHosp_Code = T000T6_A485BR_MedicalImaging_ImageHosp_Code[0];
            n485BR_MedicalImaging_ImageHosp_Code = T000T6_n485BR_MedicalImaging_ImageHosp_Code[0];
            A36BR_Information_PatientNo = T000T6_A36BR_Information_PatientNo[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36BR_Information_PatientNo", A36BR_Information_PatientNo);
            n36BR_Information_PatientNo = T000T6_n36BR_Information_PatientNo[0];
            A227BR_MedicalImaging_ID = T000T6_A227BR_MedicalImaging_ID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A227BR_MedicalImaging_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A227BR_MedicalImaging_ID), 10, 0)));
            n227BR_MedicalImaging_ID = T000T6_n227BR_MedicalImaging_ID[0];
            A518BR_MedicalImaging_No = T000T6_A518BR_MedicalImaging_No[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A518BR_MedicalImaging_No", StringUtil.LTrim( StringUtil.Str( (decimal)(A518BR_MedicalImaging_No), 18, 0)));
            n518BR_MedicalImaging_No = T000T6_n518BR_MedicalImaging_No[0];
            A228BR_MedicalImaging_ImageName = T000T6_A228BR_MedicalImaging_ImageName[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A228BR_MedicalImaging_ImageName", A228BR_MedicalImaging_ImageName);
            n228BR_MedicalImaging_ImageName = T000T6_n228BR_MedicalImaging_ImageName[0];
            A229BR_MedicalImaging_ImageDate = T000T6_A229BR_MedicalImaging_ImageDate[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A229BR_MedicalImaging_ImageDate", context.localUtil.Format(A229BR_MedicalImaging_ImageDate, "9999/99/99"));
            n229BR_MedicalImaging_ImageDate = T000T6_n229BR_MedicalImaging_ImageDate[0];
            A230BR_MedicalImaging_ImageHosp = T000T6_A230BR_MedicalImaging_ImageHosp[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A230BR_MedicalImaging_ImageHosp", A230BR_MedicalImaging_ImageHosp);
            n230BR_MedicalImaging_ImageHosp = T000T6_n230BR_MedicalImaging_ImageHosp[0];
            A231BR_MedicalImaging_ImageAge = T000T6_A231BR_MedicalImaging_ImageAge[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A231BR_MedicalImaging_ImageAge", StringUtil.LTrim( StringUtil.Str( (decimal)(A231BR_MedicalImaging_ImageAge), 3, 0)));
            n231BR_MedicalImaging_ImageAge = T000T6_n231BR_MedicalImaging_ImageAge[0];
            A232BR_MedicalImaging_ImageLoc = T000T6_A232BR_MedicalImaging_ImageLoc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A232BR_MedicalImaging_ImageLoc", A232BR_MedicalImaging_ImageLoc);
            n232BR_MedicalImaging_ImageLoc = T000T6_n232BR_MedicalImaging_ImageLoc[0];
            A486BR_MedicalImaging_ImageLoc_Code = T000T6_A486BR_MedicalImaging_ImageLoc_Code[0];
            n486BR_MedicalImaging_ImageLoc_Code = T000T6_n486BR_MedicalImaging_ImageLoc_Code[0];
            A233BR_MedicalImaging_ImageOrgan = T000T6_A233BR_MedicalImaging_ImageOrgan[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A233BR_MedicalImaging_ImageOrgan", A233BR_MedicalImaging_ImageOrgan);
            n233BR_MedicalImaging_ImageOrgan = T000T6_n233BR_MedicalImaging_ImageOrgan[0];
            A234BR_MedicalImaging_PreImageDiag = T000T6_A234BR_MedicalImaging_PreImageDiag[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A234BR_MedicalImaging_PreImageDiag", A234BR_MedicalImaging_PreImageDiag);
            n234BR_MedicalImaging_PreImageDiag = T000T6_n234BR_MedicalImaging_PreImageDiag[0];
            A235BR_MedicalImaging_ImageDes = T000T6_A235BR_MedicalImaging_ImageDes[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A235BR_MedicalImaging_ImageDes", A235BR_MedicalImaging_ImageDes);
            n235BR_MedicalImaging_ImageDes = T000T6_n235BR_MedicalImaging_ImageDes[0];
            A236BR_MedicalImaging_TumorSize = T000T6_A236BR_MedicalImaging_TumorSize[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A236BR_MedicalImaging_TumorSize", A236BR_MedicalImaging_TumorSize);
            n236BR_MedicalImaging_TumorSize = T000T6_n236BR_MedicalImaging_TumorSize[0];
            A334BR_MedicalImaging_ImageHtml = T000T6_A334BR_MedicalImaging_ImageHtml[0];
            n334BR_MedicalImaging_ImageHtml = T000T6_n334BR_MedicalImaging_ImageHtml[0];
            A514BR_MedicalImaging_MetastasesDX = T000T6_A514BR_MedicalImaging_MetastasesDX[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A514BR_MedicalImaging_MetastasesDX", A514BR_MedicalImaging_MetastasesDX);
            n514BR_MedicalImaging_MetastasesDX = T000T6_n514BR_MedicalImaging_MetastasesDX[0];
            A515BR_MedicalImaging_MetaLoc = T000T6_A515BR_MedicalImaging_MetaLoc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A515BR_MedicalImaging_MetaLoc", A515BR_MedicalImaging_MetaLoc);
            n515BR_MedicalImaging_MetaLoc = T000T6_n515BR_MedicalImaging_MetaLoc[0];
            A516BR_MedicalImaging_MetaDate = T000T6_A516BR_MedicalImaging_MetaDate[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A516BR_MedicalImaging_MetaDate", context.localUtil.Format(A516BR_MedicalImaging_MetaDate, "9999/99/99"));
            n516BR_MedicalImaging_MetaDate = T000T6_n516BR_MedicalImaging_MetaDate[0];
            A19BR_EncounterID = T000T6_A19BR_EncounterID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
            n19BR_EncounterID = T000T6_n19BR_EncounterID[0];
            ZM0T30( -36) ;
         }
         pr_default.close(4);
         OnLoadActions0T30( ) ;
      }

      protected void OnLoadActions0T30( )
      {
         AV19Pgmname = "BR_MedicalImaging";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19Pgmname", AV19Pgmname);
         edtavVname_Visible = ((StringUtil.StrCmp(A228BR_MedicalImaging_ImageName, "其它")==0) ? 1 : 0);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVname_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVname_Visible), 5, 0)), true);
         if ( ! ( ( StringUtil.StrCmp(A228BR_MedicalImaging_ImageName, "其它") == 0 ) ) )
         {
            cellVname_cell_Class = "Invisible";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVname_cell_Internalname, "Class", cellVname_cell_Class, true);
         }
         else
         {
            if ( StringUtil.StrCmp(A228BR_MedicalImaging_ImageName, "其它") == 0 )
            {
               cellVname_cell_Class = "RequiredDataContentCell";
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVname_cell_Internalname, "Class", cellVname_cell_Class, true);
            }
         }
         edtavWxname_Visible = ((StringUtil.StrCmp(A232BR_MedicalImaging_ImageLoc, "其它")==0) ? 1 : 0);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavWxname_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavWxname_Visible), 5, 0)), true);
         if ( ! ( ( StringUtil.StrCmp(A232BR_MedicalImaging_ImageLoc, "其它") == 0 ) ) )
         {
            cellWxname_cell_Class = "Invisible";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellWxname_cell_Internalname, "Class", cellWxname_cell_Class, true);
         }
         else
         {
            if ( StringUtil.StrCmp(A232BR_MedicalImaging_ImageLoc, "其它") == 0 )
            {
               cellWxname_cell_Class = "RequiredDataContentCell";
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellWxname_cell_Internalname, "Class", cellWxname_cell_Class, true);
            }
         }
         edtBR_MedicalImaging_MetaLoc_Visible = ((StringUtil.StrCmp(A514BR_MedicalImaging_MetastasesDX, "是")==0) ? 1 : 0);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_MedicalImaging_MetaLoc_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_MedicalImaging_MetaLoc_Visible), 5, 0)), true);
         if ( ! ( ( StringUtil.StrCmp(A514BR_MedicalImaging_MetastasesDX, "是") == 0 ) ) )
         {
            divBr_medicalimaging_metaloc_cell_Class = "Invisible";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divBr_medicalimaging_metaloc_cell_Internalname, "Class", divBr_medicalimaging_metaloc_cell_Class, true);
         }
         else
         {
            if ( StringUtil.StrCmp(A514BR_MedicalImaging_MetastasesDX, "是") == 0 )
            {
               divBr_medicalimaging_metaloc_cell_Class = "col-xs-12 col-md-6 DataContentCell";
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, divBr_medicalimaging_metaloc_cell_Internalname, "Class", divBr_medicalimaging_metaloc_cell_Class, true);
            }
         }
         edtBR_MedicalImaging_MetaDate_Visible = ((StringUtil.StrCmp(A514BR_MedicalImaging_MetastasesDX, "是")==0) ? 1 : 0);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_MedicalImaging_MetaDate_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_MedicalImaging_MetaDate_Visible), 5, 0)), true);
         if ( ! ( ( StringUtil.StrCmp(A514BR_MedicalImaging_MetastasesDX, "是") == 0 ) ) )
         {
            divBr_medicalimaging_metadate_cell_Class = "Invisible";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divBr_medicalimaging_metadate_cell_Internalname, "Class", divBr_medicalimaging_metadate_cell_Class, true);
         }
         else
         {
            if ( StringUtil.StrCmp(A514BR_MedicalImaging_MetastasesDX, "是") == 0 )
            {
               divBr_medicalimaging_metadate_cell_Class = "col-xs-12 col-md-6 DataContentCell";
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, divBr_medicalimaging_metadate_cell_Internalname, "Class", divBr_medicalimaging_metadate_cell_Class, true);
            }
         }
      }

      protected void CheckExtendedTable0T30( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
         AV19Pgmname = "BR_MedicalImaging";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19Pgmname", AV19Pgmname);
         /* Using cursor T000T4 */
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
         A85BR_Information_ID = T000T4_A85BR_Information_ID[0];
         n85BR_Information_ID = T000T4_n85BR_Information_ID[0];
         pr_default.close(2);
         /* Using cursor T000T5 */
         pr_default.execute(3, new Object[] {n85BR_Information_ID, A85BR_Information_ID});
         if ( (pr_default.getStatus(3) == 101) )
         {
            if ( ! ( (0==A85BR_Information_ID) ) )
            {
               GX_msglist.addItem("不匹配' T16'", "ForeignKeyNotFound", 1, "");
               AnyError = 1;
            }
         }
         A36BR_Information_PatientNo = T000T5_A36BR_Information_PatientNo[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36BR_Information_PatientNo", A36BR_Information_PatientNo);
         n36BR_Information_PatientNo = T000T5_n36BR_Information_PatientNo[0];
         pr_default.close(3);
         if ( (0==A518BR_MedicalImaging_No) )
         {
            GX_msglist.addItem("编号是必须填写的。", 1, "BR_MEDICALIMAGING_NO");
            AnyError = 1;
            GX_FocusControl = edtBR_MedicalImaging_No_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         edtavVname_Visible = ((StringUtil.StrCmp(A228BR_MedicalImaging_ImageName, "其它")==0) ? 1 : 0);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVname_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVname_Visible), 5, 0)), true);
         if ( ! ( ( StringUtil.StrCmp(A228BR_MedicalImaging_ImageName, "其它") == 0 ) ) )
         {
            cellVname_cell_Class = "Invisible";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVname_cell_Internalname, "Class", cellVname_cell_Class, true);
         }
         else
         {
            if ( StringUtil.StrCmp(A228BR_MedicalImaging_ImageName, "其它") == 0 )
            {
               cellVname_cell_Class = "RequiredDataContentCell";
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVname_cell_Internalname, "Class", cellVname_cell_Class, true);
            }
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( A228BR_MedicalImaging_ImageName)) )
         {
            GX_msglist.addItem("影像名称是必须填写的。", 1, "BR_MEDICALIMAGING_IMAGENAME");
            AnyError = 1;
            GX_FocusControl = dynBR_MedicalImaging_ImageName_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ! ( (DateTime.MinValue==A229BR_MedicalImaging_ImageDate) || ( A229BR_MedicalImaging_ImageDate >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("域������������超界", "OutOfRange", 1, "BR_MEDICALIMAGING_IMAGEDATE");
            AnyError = 1;
            GX_FocusControl = edtBR_MedicalImaging_ImageDate_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( (0==A231BR_MedicalImaging_ImageAge) )
         {
            GX_msglist.addItem("年龄是必须填写的。", 1, "BR_MEDICALIMAGING_IMAGEAGE");
            AnyError = 1;
            GX_FocusControl = edtBR_MedicalImaging_ImageAge_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         edtavWxname_Visible = ((StringUtil.StrCmp(A232BR_MedicalImaging_ImageLoc, "其它")==0) ? 1 : 0);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavWxname_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavWxname_Visible), 5, 0)), true);
         if ( ! ( ( StringUtil.StrCmp(A232BR_MedicalImaging_ImageLoc, "其它") == 0 ) ) )
         {
            cellWxname_cell_Class = "Invisible";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellWxname_cell_Internalname, "Class", cellWxname_cell_Class, true);
         }
         else
         {
            if ( StringUtil.StrCmp(A232BR_MedicalImaging_ImageLoc, "其它") == 0 )
            {
               cellWxname_cell_Class = "RequiredDataContentCell";
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellWxname_cell_Internalname, "Class", cellWxname_cell_Class, true);
            }
         }
         if ( ! ( ( StringUtil.StrCmp(A514BR_MedicalImaging_MetastasesDX, "否") == 0 ) || ( StringUtil.StrCmp(A514BR_MedicalImaging_MetastasesDX, "是") == 0 ) || ( StringUtil.StrCmp(A514BR_MedicalImaging_MetastasesDX, "不详") == 0 ) || String.IsNullOrEmpty(StringUtil.RTrim( A514BR_MedicalImaging_MetastasesDX)) ) )
         {
            GX_msglist.addItem("域���������������������超界", "OutOfRange", 1, "BR_MEDICALIMAGING_METASTASESDX");
            AnyError = 1;
            GX_FocusControl = cmbBR_MedicalImaging_MetastasesDX_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         edtBR_MedicalImaging_MetaLoc_Visible = ((StringUtil.StrCmp(A514BR_MedicalImaging_MetastasesDX, "是")==0) ? 1 : 0);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_MedicalImaging_MetaLoc_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_MedicalImaging_MetaLoc_Visible), 5, 0)), true);
         if ( ! ( ( StringUtil.StrCmp(A514BR_MedicalImaging_MetastasesDX, "是") == 0 ) ) )
         {
            divBr_medicalimaging_metaloc_cell_Class = "Invisible";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divBr_medicalimaging_metaloc_cell_Internalname, "Class", divBr_medicalimaging_metaloc_cell_Class, true);
         }
         else
         {
            if ( StringUtil.StrCmp(A514BR_MedicalImaging_MetastasesDX, "是") == 0 )
            {
               divBr_medicalimaging_metaloc_cell_Class = "col-xs-12 col-md-6 DataContentCell";
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, divBr_medicalimaging_metaloc_cell_Internalname, "Class", divBr_medicalimaging_metaloc_cell_Class, true);
            }
         }
         edtBR_MedicalImaging_MetaDate_Visible = ((StringUtil.StrCmp(A514BR_MedicalImaging_MetastasesDX, "是")==0) ? 1 : 0);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_MedicalImaging_MetaDate_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_MedicalImaging_MetaDate_Visible), 5, 0)), true);
         if ( ! ( ( StringUtil.StrCmp(A514BR_MedicalImaging_MetastasesDX, "是") == 0 ) ) )
         {
            divBr_medicalimaging_metadate_cell_Class = "Invisible";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divBr_medicalimaging_metadate_cell_Internalname, "Class", divBr_medicalimaging_metadate_cell_Class, true);
         }
         else
         {
            if ( StringUtil.StrCmp(A514BR_MedicalImaging_MetastasesDX, "是") == 0 )
            {
               divBr_medicalimaging_metadate_cell_Class = "col-xs-12 col-md-6 DataContentCell";
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, divBr_medicalimaging_metadate_cell_Internalname, "Class", divBr_medicalimaging_metadate_cell_Class, true);
            }
         }
         if ( ! ( (DateTime.MinValue==A516BR_MedicalImaging_MetaDate) || ( A516BR_MedicalImaging_MetaDate >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("域������������������超界", "OutOfRange", 1, "BR_MEDICALIMAGING_METADATE");
            AnyError = 1;
            GX_FocusControl = edtBR_MedicalImaging_MetaDate_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ( ( StringUtil.StrCmp(A228BR_MedicalImaging_ImageName, "其它") == 0 ) ) && String.IsNullOrEmpty(StringUtil.RTrim( AV15vName)) )
         {
            GX_msglist.addItem("其它影像名称是必填的", 1, "BR_MEDICALIMAGING_IMAGENAME");
            AnyError = 1;
            GX_FocusControl = dynBR_MedicalImaging_ImageName_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ( ( StringUtil.StrCmp(A232BR_MedicalImaging_ImageLoc, "其它") == 0 ) ) && String.IsNullOrEmpty(StringUtil.RTrim( AV16wxname)) )
         {
            GX_msglist.addItem("其它检测部位是必填的", 1, "BR_MEDICALIMAGING_IMAGELOC");
            AnyError = 1;
            GX_FocusControl = dynBR_MedicalImaging_ImageLoc_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
      }

      protected void CloseExtendedTableCursors0T30( )
      {
         pr_default.close(2);
         pr_default.close(3);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_37( long A19BR_EncounterID )
      {
         /* Using cursor T000T7 */
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
         A85BR_Information_ID = T000T7_A85BR_Information_ID[0];
         n85BR_Information_ID = T000T7_n85BR_Information_ID[0];
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

      protected void gxLoad_38( long A85BR_Information_ID )
      {
         /* Using cursor T000T8 */
         pr_default.execute(6, new Object[] {n85BR_Information_ID, A85BR_Information_ID});
         if ( (pr_default.getStatus(6) == 101) )
         {
            if ( ! ( (0==A85BR_Information_ID) ) )
            {
               GX_msglist.addItem("不匹配' T16'", "ForeignKeyNotFound", 1, "");
               AnyError = 1;
            }
         }
         A36BR_Information_PatientNo = T000T8_A36BR_Information_PatientNo[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36BR_Information_PatientNo", A36BR_Information_PatientNo);
         n36BR_Information_PatientNo = T000T8_n36BR_Information_PatientNo[0];
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

      protected void GetKey0T30( )
      {
         /* Using cursor T000T9 */
         pr_default.execute(7, new Object[] {n225BR_MedicalImagingID, A225BR_MedicalImagingID});
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound30 = 1;
         }
         else
         {
            RcdFound30 = 0;
         }
         pr_default.close(7);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T000T3 */
         pr_default.execute(1, new Object[] {n225BR_MedicalImagingID, A225BR_MedicalImagingID});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0T30( 36) ;
            RcdFound30 = 1;
            A225BR_MedicalImagingID = T000T3_A225BR_MedicalImagingID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A225BR_MedicalImagingID", StringUtil.LTrim( StringUtil.Str( (decimal)(A225BR_MedicalImagingID), 18, 0)));
            n225BR_MedicalImagingID = T000T3_n225BR_MedicalImagingID[0];
            A484BR_MedicalImaging_ImageName_Code = T000T3_A484BR_MedicalImaging_ImageName_Code[0];
            n484BR_MedicalImaging_ImageName_Code = T000T3_n484BR_MedicalImaging_ImageName_Code[0];
            A485BR_MedicalImaging_ImageHosp_Code = T000T3_A485BR_MedicalImaging_ImageHosp_Code[0];
            n485BR_MedicalImaging_ImageHosp_Code = T000T3_n485BR_MedicalImaging_ImageHosp_Code[0];
            A227BR_MedicalImaging_ID = T000T3_A227BR_MedicalImaging_ID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A227BR_MedicalImaging_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A227BR_MedicalImaging_ID), 10, 0)));
            n227BR_MedicalImaging_ID = T000T3_n227BR_MedicalImaging_ID[0];
            A518BR_MedicalImaging_No = T000T3_A518BR_MedicalImaging_No[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A518BR_MedicalImaging_No", StringUtil.LTrim( StringUtil.Str( (decimal)(A518BR_MedicalImaging_No), 18, 0)));
            n518BR_MedicalImaging_No = T000T3_n518BR_MedicalImaging_No[0];
            A228BR_MedicalImaging_ImageName = T000T3_A228BR_MedicalImaging_ImageName[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A228BR_MedicalImaging_ImageName", A228BR_MedicalImaging_ImageName);
            n228BR_MedicalImaging_ImageName = T000T3_n228BR_MedicalImaging_ImageName[0];
            A229BR_MedicalImaging_ImageDate = T000T3_A229BR_MedicalImaging_ImageDate[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A229BR_MedicalImaging_ImageDate", context.localUtil.Format(A229BR_MedicalImaging_ImageDate, "9999/99/99"));
            n229BR_MedicalImaging_ImageDate = T000T3_n229BR_MedicalImaging_ImageDate[0];
            A230BR_MedicalImaging_ImageHosp = T000T3_A230BR_MedicalImaging_ImageHosp[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A230BR_MedicalImaging_ImageHosp", A230BR_MedicalImaging_ImageHosp);
            n230BR_MedicalImaging_ImageHosp = T000T3_n230BR_MedicalImaging_ImageHosp[0];
            A231BR_MedicalImaging_ImageAge = T000T3_A231BR_MedicalImaging_ImageAge[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A231BR_MedicalImaging_ImageAge", StringUtil.LTrim( StringUtil.Str( (decimal)(A231BR_MedicalImaging_ImageAge), 3, 0)));
            n231BR_MedicalImaging_ImageAge = T000T3_n231BR_MedicalImaging_ImageAge[0];
            A232BR_MedicalImaging_ImageLoc = T000T3_A232BR_MedicalImaging_ImageLoc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A232BR_MedicalImaging_ImageLoc", A232BR_MedicalImaging_ImageLoc);
            n232BR_MedicalImaging_ImageLoc = T000T3_n232BR_MedicalImaging_ImageLoc[0];
            A486BR_MedicalImaging_ImageLoc_Code = T000T3_A486BR_MedicalImaging_ImageLoc_Code[0];
            n486BR_MedicalImaging_ImageLoc_Code = T000T3_n486BR_MedicalImaging_ImageLoc_Code[0];
            A233BR_MedicalImaging_ImageOrgan = T000T3_A233BR_MedicalImaging_ImageOrgan[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A233BR_MedicalImaging_ImageOrgan", A233BR_MedicalImaging_ImageOrgan);
            n233BR_MedicalImaging_ImageOrgan = T000T3_n233BR_MedicalImaging_ImageOrgan[0];
            A234BR_MedicalImaging_PreImageDiag = T000T3_A234BR_MedicalImaging_PreImageDiag[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A234BR_MedicalImaging_PreImageDiag", A234BR_MedicalImaging_PreImageDiag);
            n234BR_MedicalImaging_PreImageDiag = T000T3_n234BR_MedicalImaging_PreImageDiag[0];
            A235BR_MedicalImaging_ImageDes = T000T3_A235BR_MedicalImaging_ImageDes[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A235BR_MedicalImaging_ImageDes", A235BR_MedicalImaging_ImageDes);
            n235BR_MedicalImaging_ImageDes = T000T3_n235BR_MedicalImaging_ImageDes[0];
            A236BR_MedicalImaging_TumorSize = T000T3_A236BR_MedicalImaging_TumorSize[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A236BR_MedicalImaging_TumorSize", A236BR_MedicalImaging_TumorSize);
            n236BR_MedicalImaging_TumorSize = T000T3_n236BR_MedicalImaging_TumorSize[0];
            A334BR_MedicalImaging_ImageHtml = T000T3_A334BR_MedicalImaging_ImageHtml[0];
            n334BR_MedicalImaging_ImageHtml = T000T3_n334BR_MedicalImaging_ImageHtml[0];
            A514BR_MedicalImaging_MetastasesDX = T000T3_A514BR_MedicalImaging_MetastasesDX[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A514BR_MedicalImaging_MetastasesDX", A514BR_MedicalImaging_MetastasesDX);
            n514BR_MedicalImaging_MetastasesDX = T000T3_n514BR_MedicalImaging_MetastasesDX[0];
            A515BR_MedicalImaging_MetaLoc = T000T3_A515BR_MedicalImaging_MetaLoc[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A515BR_MedicalImaging_MetaLoc", A515BR_MedicalImaging_MetaLoc);
            n515BR_MedicalImaging_MetaLoc = T000T3_n515BR_MedicalImaging_MetaLoc[0];
            A516BR_MedicalImaging_MetaDate = T000T3_A516BR_MedicalImaging_MetaDate[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A516BR_MedicalImaging_MetaDate", context.localUtil.Format(A516BR_MedicalImaging_MetaDate, "9999/99/99"));
            n516BR_MedicalImaging_MetaDate = T000T3_n516BR_MedicalImaging_MetaDate[0];
            A19BR_EncounterID = T000T3_A19BR_EncounterID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
            n19BR_EncounterID = T000T3_n19BR_EncounterID[0];
            Z225BR_MedicalImagingID = A225BR_MedicalImagingID;
            sMode30 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load0T30( ) ;
            if ( AnyError == 1 )
            {
               RcdFound30 = 0;
               InitializeNonKey0T30( ) ;
            }
            Gx_mode = sMode30;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound30 = 0;
            InitializeNonKey0T30( ) ;
            sMode30 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal( ) ;
            Gx_mode = sMode30;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0T30( ) ;
         if ( RcdFound30 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound30 = 0;
         /* Using cursor T000T10 */
         pr_default.execute(8, new Object[] {n225BR_MedicalImagingID, A225BR_MedicalImagingID});
         if ( (pr_default.getStatus(8) != 101) )
         {
            while ( (pr_default.getStatus(8) != 101) && ( ( T000T10_A225BR_MedicalImagingID[0] < A225BR_MedicalImagingID ) ) )
            {
               pr_default.readNext(8);
            }
            if ( (pr_default.getStatus(8) != 101) && ( ( T000T10_A225BR_MedicalImagingID[0] > A225BR_MedicalImagingID ) ) )
            {
               A225BR_MedicalImagingID = T000T10_A225BR_MedicalImagingID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A225BR_MedicalImagingID", StringUtil.LTrim( StringUtil.Str( (decimal)(A225BR_MedicalImagingID), 18, 0)));
               n225BR_MedicalImagingID = T000T10_n225BR_MedicalImagingID[0];
               RcdFound30 = 1;
            }
         }
         pr_default.close(8);
      }

      protected void move_previous( )
      {
         RcdFound30 = 0;
         /* Using cursor T000T11 */
         pr_default.execute(9, new Object[] {n225BR_MedicalImagingID, A225BR_MedicalImagingID});
         if ( (pr_default.getStatus(9) != 101) )
         {
            while ( (pr_default.getStatus(9) != 101) && ( ( T000T11_A225BR_MedicalImagingID[0] > A225BR_MedicalImagingID ) ) )
            {
               pr_default.readNext(9);
            }
            if ( (pr_default.getStatus(9) != 101) && ( ( T000T11_A225BR_MedicalImagingID[0] < A225BR_MedicalImagingID ) ) )
            {
               A225BR_MedicalImagingID = T000T11_A225BR_MedicalImagingID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A225BR_MedicalImagingID", StringUtil.LTrim( StringUtil.Str( (decimal)(A225BR_MedicalImagingID), 18, 0)));
               n225BR_MedicalImagingID = T000T11_n225BR_MedicalImagingID[0];
               RcdFound30 = 1;
            }
         }
         pr_default.close(9);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey0T30( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtBR_MedicalImaging_No_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert0T30( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound30 == 1 )
            {
               if ( A225BR_MedicalImagingID != Z225BR_MedicalImagingID )
               {
                  A225BR_MedicalImagingID = Z225BR_MedicalImagingID;
                  n225BR_MedicalImagingID = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A225BR_MedicalImagingID", StringUtil.LTrim( StringUtil.Str( (decimal)(A225BR_MedicalImagingID), 18, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "BR_MEDICALIMAGINGID");
                  AnyError = 1;
                  GX_FocusControl = edtBR_MedicalImagingID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtBR_MedicalImaging_No_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Update record */
                  Update0T30( ) ;
                  GX_FocusControl = edtBR_MedicalImaging_No_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A225BR_MedicalImagingID != Z225BR_MedicalImagingID )
               {
                  /* Insert record */
                  GX_FocusControl = edtBR_MedicalImaging_No_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert0T30( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "BR_MEDICALIMAGINGID");
                     AnyError = 1;
                     GX_FocusControl = edtBR_MedicalImagingID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     /* Insert record */
                     GX_FocusControl = edtBR_MedicalImaging_No_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert0T30( ) ;
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
         if ( A225BR_MedicalImagingID != Z225BR_MedicalImagingID )
         {
            A225BR_MedicalImagingID = Z225BR_MedicalImagingID;
            n225BR_MedicalImagingID = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A225BR_MedicalImagingID", StringUtil.LTrim( StringUtil.Str( (decimal)(A225BR_MedicalImagingID), 18, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "BR_MEDICALIMAGINGID");
            AnyError = 1;
            GX_FocusControl = edtBR_MedicalImagingID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtBR_MedicalImaging_No_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency0T30( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000T2 */
            pr_default.execute(0, new Object[] {n225BR_MedicalImagingID, A225BR_MedicalImagingID});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BR_MedicalImaging"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z484BR_MedicalImaging_ImageName_Code, T000T2_A484BR_MedicalImaging_ImageName_Code[0]) != 0 ) || ( StringUtil.StrCmp(Z485BR_MedicalImaging_ImageHosp_Code, T000T2_A485BR_MedicalImaging_ImageHosp_Code[0]) != 0 ) || ( Z227BR_MedicalImaging_ID != T000T2_A227BR_MedicalImaging_ID[0] ) || ( Z518BR_MedicalImaging_No != T000T2_A518BR_MedicalImaging_No[0] ) || ( StringUtil.StrCmp(Z228BR_MedicalImaging_ImageName, T000T2_A228BR_MedicalImaging_ImageName[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( Z229BR_MedicalImaging_ImageDate != T000T2_A229BR_MedicalImaging_ImageDate[0] ) || ( StringUtil.StrCmp(Z230BR_MedicalImaging_ImageHosp, T000T2_A230BR_MedicalImaging_ImageHosp[0]) != 0 ) || ( Z231BR_MedicalImaging_ImageAge != T000T2_A231BR_MedicalImaging_ImageAge[0] ) || ( StringUtil.StrCmp(Z232BR_MedicalImaging_ImageLoc, T000T2_A232BR_MedicalImaging_ImageLoc[0]) != 0 ) || ( StringUtil.StrCmp(Z486BR_MedicalImaging_ImageLoc_Code, T000T2_A486BR_MedicalImaging_ImageLoc_Code[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z233BR_MedicalImaging_ImageOrgan, T000T2_A233BR_MedicalImaging_ImageOrgan[0]) != 0 ) || ( StringUtil.StrCmp(Z234BR_MedicalImaging_PreImageDiag, T000T2_A234BR_MedicalImaging_PreImageDiag[0]) != 0 ) || ( StringUtil.StrCmp(Z235BR_MedicalImaging_ImageDes, T000T2_A235BR_MedicalImaging_ImageDes[0]) != 0 ) || ( StringUtil.StrCmp(Z236BR_MedicalImaging_TumorSize, T000T2_A236BR_MedicalImaging_TumorSize[0]) != 0 ) || ( StringUtil.StrCmp(Z514BR_MedicalImaging_MetastasesDX, T000T2_A514BR_MedicalImaging_MetastasesDX[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z515BR_MedicalImaging_MetaLoc, T000T2_A515BR_MedicalImaging_MetaLoc[0]) != 0 ) || ( Z516BR_MedicalImaging_MetaDate != T000T2_A516BR_MedicalImaging_MetaDate[0] ) || ( Z19BR_EncounterID != T000T2_A19BR_EncounterID[0] ) )
            {
               if ( StringUtil.StrCmp(Z484BR_MedicalImaging_ImageName_Code, T000T2_A484BR_MedicalImaging_ImageName_Code[0]) != 0 )
               {
                  GXUtil.WriteLog("br_medicalimaging:[seudo value changed for attri]"+"BR_MedicalImaging_ImageName_Code");
                  GXUtil.WriteLogRaw("Old: ",Z484BR_MedicalImaging_ImageName_Code);
                  GXUtil.WriteLogRaw("Current: ",T000T2_A484BR_MedicalImaging_ImageName_Code[0]);
               }
               if ( StringUtil.StrCmp(Z485BR_MedicalImaging_ImageHosp_Code, T000T2_A485BR_MedicalImaging_ImageHosp_Code[0]) != 0 )
               {
                  GXUtil.WriteLog("br_medicalimaging:[seudo value changed for attri]"+"BR_MedicalImaging_ImageHosp_Code");
                  GXUtil.WriteLogRaw("Old: ",Z485BR_MedicalImaging_ImageHosp_Code);
                  GXUtil.WriteLogRaw("Current: ",T000T2_A485BR_MedicalImaging_ImageHosp_Code[0]);
               }
               if ( Z227BR_MedicalImaging_ID != T000T2_A227BR_MedicalImaging_ID[0] )
               {
                  GXUtil.WriteLog("br_medicalimaging:[seudo value changed for attri]"+"BR_MedicalImaging_ID");
                  GXUtil.WriteLogRaw("Old: ",Z227BR_MedicalImaging_ID);
                  GXUtil.WriteLogRaw("Current: ",T000T2_A227BR_MedicalImaging_ID[0]);
               }
               if ( Z518BR_MedicalImaging_No != T000T2_A518BR_MedicalImaging_No[0] )
               {
                  GXUtil.WriteLog("br_medicalimaging:[seudo value changed for attri]"+"BR_MedicalImaging_No");
                  GXUtil.WriteLogRaw("Old: ",Z518BR_MedicalImaging_No);
                  GXUtil.WriteLogRaw("Current: ",T000T2_A518BR_MedicalImaging_No[0]);
               }
               if ( StringUtil.StrCmp(Z228BR_MedicalImaging_ImageName, T000T2_A228BR_MedicalImaging_ImageName[0]) != 0 )
               {
                  GXUtil.WriteLog("br_medicalimaging:[seudo value changed for attri]"+"BR_MedicalImaging_ImageName");
                  GXUtil.WriteLogRaw("Old: ",Z228BR_MedicalImaging_ImageName);
                  GXUtil.WriteLogRaw("Current: ",T000T2_A228BR_MedicalImaging_ImageName[0]);
               }
               if ( Z229BR_MedicalImaging_ImageDate != T000T2_A229BR_MedicalImaging_ImageDate[0] )
               {
                  GXUtil.WriteLog("br_medicalimaging:[seudo value changed for attri]"+"BR_MedicalImaging_ImageDate");
                  GXUtil.WriteLogRaw("Old: ",Z229BR_MedicalImaging_ImageDate);
                  GXUtil.WriteLogRaw("Current: ",T000T2_A229BR_MedicalImaging_ImageDate[0]);
               }
               if ( StringUtil.StrCmp(Z230BR_MedicalImaging_ImageHosp, T000T2_A230BR_MedicalImaging_ImageHosp[0]) != 0 )
               {
                  GXUtil.WriteLog("br_medicalimaging:[seudo value changed for attri]"+"BR_MedicalImaging_ImageHosp");
                  GXUtil.WriteLogRaw("Old: ",Z230BR_MedicalImaging_ImageHosp);
                  GXUtil.WriteLogRaw("Current: ",T000T2_A230BR_MedicalImaging_ImageHosp[0]);
               }
               if ( Z231BR_MedicalImaging_ImageAge != T000T2_A231BR_MedicalImaging_ImageAge[0] )
               {
                  GXUtil.WriteLog("br_medicalimaging:[seudo value changed for attri]"+"BR_MedicalImaging_ImageAge");
                  GXUtil.WriteLogRaw("Old: ",Z231BR_MedicalImaging_ImageAge);
                  GXUtil.WriteLogRaw("Current: ",T000T2_A231BR_MedicalImaging_ImageAge[0]);
               }
               if ( StringUtil.StrCmp(Z232BR_MedicalImaging_ImageLoc, T000T2_A232BR_MedicalImaging_ImageLoc[0]) != 0 )
               {
                  GXUtil.WriteLog("br_medicalimaging:[seudo value changed for attri]"+"BR_MedicalImaging_ImageLoc");
                  GXUtil.WriteLogRaw("Old: ",Z232BR_MedicalImaging_ImageLoc);
                  GXUtil.WriteLogRaw("Current: ",T000T2_A232BR_MedicalImaging_ImageLoc[0]);
               }
               if ( StringUtil.StrCmp(Z486BR_MedicalImaging_ImageLoc_Code, T000T2_A486BR_MedicalImaging_ImageLoc_Code[0]) != 0 )
               {
                  GXUtil.WriteLog("br_medicalimaging:[seudo value changed for attri]"+"BR_MedicalImaging_ImageLoc_Code");
                  GXUtil.WriteLogRaw("Old: ",Z486BR_MedicalImaging_ImageLoc_Code);
                  GXUtil.WriteLogRaw("Current: ",T000T2_A486BR_MedicalImaging_ImageLoc_Code[0]);
               }
               if ( StringUtil.StrCmp(Z233BR_MedicalImaging_ImageOrgan, T000T2_A233BR_MedicalImaging_ImageOrgan[0]) != 0 )
               {
                  GXUtil.WriteLog("br_medicalimaging:[seudo value changed for attri]"+"BR_MedicalImaging_ImageOrgan");
                  GXUtil.WriteLogRaw("Old: ",Z233BR_MedicalImaging_ImageOrgan);
                  GXUtil.WriteLogRaw("Current: ",T000T2_A233BR_MedicalImaging_ImageOrgan[0]);
               }
               if ( StringUtil.StrCmp(Z234BR_MedicalImaging_PreImageDiag, T000T2_A234BR_MedicalImaging_PreImageDiag[0]) != 0 )
               {
                  GXUtil.WriteLog("br_medicalimaging:[seudo value changed for attri]"+"BR_MedicalImaging_PreImageDiag");
                  GXUtil.WriteLogRaw("Old: ",Z234BR_MedicalImaging_PreImageDiag);
                  GXUtil.WriteLogRaw("Current: ",T000T2_A234BR_MedicalImaging_PreImageDiag[0]);
               }
               if ( StringUtil.StrCmp(Z235BR_MedicalImaging_ImageDes, T000T2_A235BR_MedicalImaging_ImageDes[0]) != 0 )
               {
                  GXUtil.WriteLog("br_medicalimaging:[seudo value changed for attri]"+"BR_MedicalImaging_ImageDes");
                  GXUtil.WriteLogRaw("Old: ",Z235BR_MedicalImaging_ImageDes);
                  GXUtil.WriteLogRaw("Current: ",T000T2_A235BR_MedicalImaging_ImageDes[0]);
               }
               if ( StringUtil.StrCmp(Z236BR_MedicalImaging_TumorSize, T000T2_A236BR_MedicalImaging_TumorSize[0]) != 0 )
               {
                  GXUtil.WriteLog("br_medicalimaging:[seudo value changed for attri]"+"BR_MedicalImaging_TumorSize");
                  GXUtil.WriteLogRaw("Old: ",Z236BR_MedicalImaging_TumorSize);
                  GXUtil.WriteLogRaw("Current: ",T000T2_A236BR_MedicalImaging_TumorSize[0]);
               }
               if ( StringUtil.StrCmp(Z514BR_MedicalImaging_MetastasesDX, T000T2_A514BR_MedicalImaging_MetastasesDX[0]) != 0 )
               {
                  GXUtil.WriteLog("br_medicalimaging:[seudo value changed for attri]"+"BR_MedicalImaging_MetastasesDX");
                  GXUtil.WriteLogRaw("Old: ",Z514BR_MedicalImaging_MetastasesDX);
                  GXUtil.WriteLogRaw("Current: ",T000T2_A514BR_MedicalImaging_MetastasesDX[0]);
               }
               if ( StringUtil.StrCmp(Z515BR_MedicalImaging_MetaLoc, T000T2_A515BR_MedicalImaging_MetaLoc[0]) != 0 )
               {
                  GXUtil.WriteLog("br_medicalimaging:[seudo value changed for attri]"+"BR_MedicalImaging_MetaLoc");
                  GXUtil.WriteLogRaw("Old: ",Z515BR_MedicalImaging_MetaLoc);
                  GXUtil.WriteLogRaw("Current: ",T000T2_A515BR_MedicalImaging_MetaLoc[0]);
               }
               if ( Z516BR_MedicalImaging_MetaDate != T000T2_A516BR_MedicalImaging_MetaDate[0] )
               {
                  GXUtil.WriteLog("br_medicalimaging:[seudo value changed for attri]"+"BR_MedicalImaging_MetaDate");
                  GXUtil.WriteLogRaw("Old: ",Z516BR_MedicalImaging_MetaDate);
                  GXUtil.WriteLogRaw("Current: ",T000T2_A516BR_MedicalImaging_MetaDate[0]);
               }
               if ( Z19BR_EncounterID != T000T2_A19BR_EncounterID[0] )
               {
                  GXUtil.WriteLog("br_medicalimaging:[seudo value changed for attri]"+"BR_EncounterID");
                  GXUtil.WriteLogRaw("Old: ",Z19BR_EncounterID);
                  GXUtil.WriteLogRaw("Current: ",T000T2_A19BR_EncounterID[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"BR_MedicalImaging"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0T30( )
      {
         BeforeValidate0T30( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0T30( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0T30( 0) ;
            CheckOptimisticConcurrency0T30( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0T30( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0T30( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000T12 */
                     pr_default.execute(10, new Object[] {n484BR_MedicalImaging_ImageName_Code, A484BR_MedicalImaging_ImageName_Code, n485BR_MedicalImaging_ImageHosp_Code, A485BR_MedicalImaging_ImageHosp_Code, n227BR_MedicalImaging_ID, A227BR_MedicalImaging_ID, n518BR_MedicalImaging_No, A518BR_MedicalImaging_No, n228BR_MedicalImaging_ImageName, A228BR_MedicalImaging_ImageName, n229BR_MedicalImaging_ImageDate, A229BR_MedicalImaging_ImageDate, n230BR_MedicalImaging_ImageHosp, A230BR_MedicalImaging_ImageHosp, n231BR_MedicalImaging_ImageAge, A231BR_MedicalImaging_ImageAge, n232BR_MedicalImaging_ImageLoc, A232BR_MedicalImaging_ImageLoc, n486BR_MedicalImaging_ImageLoc_Code, A486BR_MedicalImaging_ImageLoc_Code, n233BR_MedicalImaging_ImageOrgan, A233BR_MedicalImaging_ImageOrgan, n234BR_MedicalImaging_PreImageDiag, A234BR_MedicalImaging_PreImageDiag, n235BR_MedicalImaging_ImageDes, A235BR_MedicalImaging_ImageDes, n236BR_MedicalImaging_TumorSize, A236BR_MedicalImaging_TumorSize, n334BR_MedicalImaging_ImageHtml, A334BR_MedicalImaging_ImageHtml, n514BR_MedicalImaging_MetastasesDX, A514BR_MedicalImaging_MetastasesDX, n515BR_MedicalImaging_MetaLoc, A515BR_MedicalImaging_MetaLoc, n516BR_MedicalImaging_MetaDate, A516BR_MedicalImaging_MetaDate, n19BR_EncounterID, A19BR_EncounterID});
                     A225BR_MedicalImagingID = T000T12_A225BR_MedicalImagingID[0];
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A225BR_MedicalImagingID", StringUtil.LTrim( StringUtil.Str( (decimal)(A225BR_MedicalImagingID), 18, 0)));
                     n225BR_MedicalImagingID = T000T12_n225BR_MedicalImagingID[0];
                     pr_default.close(10);
                     dsDefault.SmartCacheProvider.SetUpdated("BR_MedicalImaging") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)),  "就诊信息",  StringUtil.Trim( StringUtil.Str( (decimal)(A225BR_MedicalImagingID), 18, 0)),  "影像学",  "Create",  1) ;
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                           ResetCaption0T0( ) ;
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
               Load0T30( ) ;
            }
            EndLevel0T30( ) ;
         }
         CloseExtendedTableCursors0T30( ) ;
      }

      protected void Update0T30( )
      {
         BeforeValidate0T30( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0T30( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0T30( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0T30( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0T30( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000T13 */
                     pr_default.execute(11, new Object[] {n484BR_MedicalImaging_ImageName_Code, A484BR_MedicalImaging_ImageName_Code, n485BR_MedicalImaging_ImageHosp_Code, A485BR_MedicalImaging_ImageHosp_Code, n227BR_MedicalImaging_ID, A227BR_MedicalImaging_ID, n518BR_MedicalImaging_No, A518BR_MedicalImaging_No, n228BR_MedicalImaging_ImageName, A228BR_MedicalImaging_ImageName, n229BR_MedicalImaging_ImageDate, A229BR_MedicalImaging_ImageDate, n230BR_MedicalImaging_ImageHosp, A230BR_MedicalImaging_ImageHosp, n231BR_MedicalImaging_ImageAge, A231BR_MedicalImaging_ImageAge, n232BR_MedicalImaging_ImageLoc, A232BR_MedicalImaging_ImageLoc, n486BR_MedicalImaging_ImageLoc_Code, A486BR_MedicalImaging_ImageLoc_Code, n233BR_MedicalImaging_ImageOrgan, A233BR_MedicalImaging_ImageOrgan, n234BR_MedicalImaging_PreImageDiag, A234BR_MedicalImaging_PreImageDiag, n235BR_MedicalImaging_ImageDes, A235BR_MedicalImaging_ImageDes, n236BR_MedicalImaging_TumorSize, A236BR_MedicalImaging_TumorSize, n334BR_MedicalImaging_ImageHtml, A334BR_MedicalImaging_ImageHtml, n514BR_MedicalImaging_MetastasesDX, A514BR_MedicalImaging_MetastasesDX, n515BR_MedicalImaging_MetaLoc, A515BR_MedicalImaging_MetaLoc, n516BR_MedicalImaging_MetaDate, A516BR_MedicalImaging_MetaDate, n19BR_EncounterID, A19BR_EncounterID, n225BR_MedicalImagingID, A225BR_MedicalImagingID});
                     pr_default.close(11);
                     dsDefault.SmartCacheProvider.SetUpdated("BR_MedicalImaging") ;
                     if ( (pr_default.getStatus(11) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BR_MedicalImaging"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0T30( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)),  "就诊信息",  StringUtil.Trim( StringUtil.Str( (decimal)(A225BR_MedicalImagingID), 18, 0)),  "影像学",  "Update",  1) ;
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
            EndLevel0T30( ) ;
         }
         CloseExtendedTableCursors0T30( ) ;
      }

      protected void DeferredUpdate0T30( )
      {
      }

      protected void delete( )
      {
         BeforeValidate0T30( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0T30( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0T30( ) ;
            AfterConfirm0T30( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0T30( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000T14 */
                  pr_default.execute(12, new Object[] {n225BR_MedicalImagingID, A225BR_MedicalImagingID});
                  pr_default.close(12);
                  dsDefault.SmartCacheProvider.SetUpdated("BR_MedicalImaging") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)),  "就诊信息",  StringUtil.Trim( StringUtil.Str( (decimal)(A225BR_MedicalImagingID), 18, 0)),  "影像学",  "Delete",  1) ;
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
         sMode30 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel0T30( ) ;
         Gx_mode = sMode30;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls0T30( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV19Pgmname = "BR_MedicalImaging";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19Pgmname", AV19Pgmname);
            /* Using cursor T000T15 */
            pr_default.execute(13, new Object[] {n19BR_EncounterID, A19BR_EncounterID});
            A85BR_Information_ID = T000T15_A85BR_Information_ID[0];
            n85BR_Information_ID = T000T15_n85BR_Information_ID[0];
            pr_default.close(13);
            /* Using cursor T000T16 */
            pr_default.execute(14, new Object[] {n85BR_Information_ID, A85BR_Information_ID});
            A36BR_Information_PatientNo = T000T16_A36BR_Information_PatientNo[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36BR_Information_PatientNo", A36BR_Information_PatientNo);
            n36BR_Information_PatientNo = T000T16_n36BR_Information_PatientNo[0];
            pr_default.close(14);
            edtavVname_Visible = ((StringUtil.StrCmp(A228BR_MedicalImaging_ImageName, "其它")==0) ? 1 : 0);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVname_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVname_Visible), 5, 0)), true);
            if ( ! ( ( StringUtil.StrCmp(A228BR_MedicalImaging_ImageName, "其它") == 0 ) ) )
            {
               cellVname_cell_Class = "Invisible";
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVname_cell_Internalname, "Class", cellVname_cell_Class, true);
            }
            else
            {
               if ( StringUtil.StrCmp(A228BR_MedicalImaging_ImageName, "其它") == 0 )
               {
                  cellVname_cell_Class = "RequiredDataContentCell";
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVname_cell_Internalname, "Class", cellVname_cell_Class, true);
               }
            }
            edtavWxname_Visible = ((StringUtil.StrCmp(A232BR_MedicalImaging_ImageLoc, "其它")==0) ? 1 : 0);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavWxname_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavWxname_Visible), 5, 0)), true);
            if ( ! ( ( StringUtil.StrCmp(A232BR_MedicalImaging_ImageLoc, "其它") == 0 ) ) )
            {
               cellWxname_cell_Class = "Invisible";
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellWxname_cell_Internalname, "Class", cellWxname_cell_Class, true);
            }
            else
            {
               if ( StringUtil.StrCmp(A232BR_MedicalImaging_ImageLoc, "其它") == 0 )
               {
                  cellWxname_cell_Class = "RequiredDataContentCell";
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellWxname_cell_Internalname, "Class", cellWxname_cell_Class, true);
               }
            }
            edtBR_MedicalImaging_MetaLoc_Visible = ((StringUtil.StrCmp(A514BR_MedicalImaging_MetastasesDX, "是")==0) ? 1 : 0);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_MedicalImaging_MetaLoc_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_MedicalImaging_MetaLoc_Visible), 5, 0)), true);
            if ( ! ( ( StringUtil.StrCmp(A514BR_MedicalImaging_MetastasesDX, "是") == 0 ) ) )
            {
               divBr_medicalimaging_metaloc_cell_Class = "Invisible";
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, divBr_medicalimaging_metaloc_cell_Internalname, "Class", divBr_medicalimaging_metaloc_cell_Class, true);
            }
            else
            {
               if ( StringUtil.StrCmp(A514BR_MedicalImaging_MetastasesDX, "是") == 0 )
               {
                  divBr_medicalimaging_metaloc_cell_Class = "col-xs-12 col-md-6 DataContentCell";
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, divBr_medicalimaging_metaloc_cell_Internalname, "Class", divBr_medicalimaging_metaloc_cell_Class, true);
               }
            }
            edtBR_MedicalImaging_MetaDate_Visible = ((StringUtil.StrCmp(A514BR_MedicalImaging_MetastasesDX, "是")==0) ? 1 : 0);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_MedicalImaging_MetaDate_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_MedicalImaging_MetaDate_Visible), 5, 0)), true);
            if ( ! ( ( StringUtil.StrCmp(A514BR_MedicalImaging_MetastasesDX, "是") == 0 ) ) )
            {
               divBr_medicalimaging_metadate_cell_Class = "Invisible";
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, divBr_medicalimaging_metadate_cell_Internalname, "Class", divBr_medicalimaging_metadate_cell_Class, true);
            }
            else
            {
               if ( StringUtil.StrCmp(A514BR_MedicalImaging_MetastasesDX, "是") == 0 )
               {
                  divBr_medicalimaging_metadate_cell_Class = "col-xs-12 col-md-6 DataContentCell";
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, divBr_medicalimaging_metadate_cell_Internalname, "Class", divBr_medicalimaging_metadate_cell_Class, true);
               }
            }
         }
         if ( AnyError == 0 )
         {
            /* Using cursor T000T17 */
            pr_default.execute(15, new Object[] {n225BR_MedicalImagingID, A225BR_MedicalImagingID});
            if ( (pr_default.getStatus(15) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {" T29"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(15);
         }
      }

      protected void EndLevel0T30( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0T30( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(1);
            pr_default.close(13);
            pr_default.close(14);
            context.CommitDataStores("br_medicalimaging",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues0T0( ) ;
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
            context.RollbackDataStores("br_medicalimaging",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart0T30( )
      {
         /* Scan By routine */
         /* Using cursor T000T18 */
         pr_default.execute(16);
         RcdFound30 = 0;
         if ( (pr_default.getStatus(16) != 101) )
         {
            RcdFound30 = 1;
            A225BR_MedicalImagingID = T000T18_A225BR_MedicalImagingID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A225BR_MedicalImagingID", StringUtil.LTrim( StringUtil.Str( (decimal)(A225BR_MedicalImagingID), 18, 0)));
            n225BR_MedicalImagingID = T000T18_n225BR_MedicalImagingID[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0T30( )
      {
         /* Scan next routine */
         pr_default.readNext(16);
         RcdFound30 = 0;
         if ( (pr_default.getStatus(16) != 101) )
         {
            RcdFound30 = 1;
            A225BR_MedicalImagingID = T000T18_A225BR_MedicalImagingID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A225BR_MedicalImagingID", StringUtil.LTrim( StringUtil.Str( (decimal)(A225BR_MedicalImagingID), 18, 0)));
            n225BR_MedicalImagingID = T000T18_n225BR_MedicalImagingID[0];
         }
      }

      protected void ScanEnd0T30( )
      {
         pr_default.close(16);
      }

      protected void AfterConfirm0T30( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0T30( )
      {
         /* Before Insert Rules */
         GXt_char1 = A485BR_MedicalImaging_ImageHosp_Code;
         new zutil_findtargetcode(context ).execute(  31,  A230BR_MedicalImaging_ImageHosp, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A230BR_MedicalImaging_ImageHosp", A230BR_MedicalImaging_ImageHosp);
         A485BR_MedicalImaging_ImageHosp_Code = GXt_char1;
         n485BR_MedicalImaging_ImageHosp_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A485BR_MedicalImaging_ImageHosp_Code", A485BR_MedicalImaging_ImageHosp_Code);
         if ( StringUtil.StrCmp(A232BR_MedicalImaging_ImageLoc, "其它") == 0 )
         {
            A232BR_MedicalImaging_ImageLoc = AV16wxname;
            n232BR_MedicalImaging_ImageLoc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A232BR_MedicalImaging_ImageLoc", A232BR_MedicalImaging_ImageLoc);
         }
         if ( StringUtil.StrCmp(A228BR_MedicalImaging_ImageName, "其它") == 0 )
         {
            A228BR_MedicalImaging_ImageName = AV15vName;
            n228BR_MedicalImaging_ImageName = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A228BR_MedicalImaging_ImageName", A228BR_MedicalImaging_ImageName);
         }
         GXt_char1 = A484BR_MedicalImaging_ImageName_Code;
         new zutil_findtargetcode(context ).execute(  30,  A228BR_MedicalImaging_ImageName, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A228BR_MedicalImaging_ImageName", A228BR_MedicalImaging_ImageName);
         A484BR_MedicalImaging_ImageName_Code = GXt_char1;
         n484BR_MedicalImaging_ImageName_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A484BR_MedicalImaging_ImageName_Code", A484BR_MedicalImaging_ImageName_Code);
      }

      protected void BeforeUpdate0T30( )
      {
         /* Before Update Rules */
         GXt_char1 = A484BR_MedicalImaging_ImageName_Code;
         new zutil_findtargetcode(context ).execute(  30,  A228BR_MedicalImaging_ImageName, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A228BR_MedicalImaging_ImageName", A228BR_MedicalImaging_ImageName);
         A484BR_MedicalImaging_ImageName_Code = GXt_char1;
         n484BR_MedicalImaging_ImageName_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A484BR_MedicalImaging_ImageName_Code", A484BR_MedicalImaging_ImageName_Code);
         GXt_char1 = A485BR_MedicalImaging_ImageHosp_Code;
         new zutil_findtargetcode(context ).execute(  31,  A230BR_MedicalImaging_ImageHosp, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A230BR_MedicalImaging_ImageHosp", A230BR_MedicalImaging_ImageHosp);
         A485BR_MedicalImaging_ImageHosp_Code = GXt_char1;
         n485BR_MedicalImaging_ImageHosp_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A485BR_MedicalImaging_ImageHosp_Code", A485BR_MedicalImaging_ImageHosp_Code);
      }

      protected void BeforeDelete0T30( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0T30( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0T30( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0T30( )
      {
         edtBR_MedicalImaging_No_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_MedicalImaging_No_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_MedicalImaging_No_Enabled), 5, 0)), true);
         dynBR_MedicalImaging_ImageName.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynBR_MedicalImaging_ImageName_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynBR_MedicalImaging_ImageName.Enabled), 5, 0)), true);
         edtavVname_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVname_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVname_Enabled), 5, 0)), true);
         edtBR_MedicalImaging_ImageAge_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_MedicalImaging_ImageAge_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_MedicalImaging_ImageAge_Enabled), 5, 0)), true);
         edtBR_MedicalImaging_ImageDate_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_MedicalImaging_ImageDate_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_MedicalImaging_ImageDate_Enabled), 5, 0)), true);
         dynBR_MedicalImaging_ImageHosp.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynBR_MedicalImaging_ImageHosp_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynBR_MedicalImaging_ImageHosp.Enabled), 5, 0)), true);
         edtBR_MedicalImaging_TumorSize_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_MedicalImaging_TumorSize_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_MedicalImaging_TumorSize_Enabled), 5, 0)), true);
         edtBR_MedicalImaging_PreImageDiag_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_MedicalImaging_PreImageDiag_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_MedicalImaging_PreImageDiag_Enabled), 5, 0)), true);
         dynBR_MedicalImaging_ImageLoc.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynBR_MedicalImaging_ImageLoc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynBR_MedicalImaging_ImageLoc.Enabled), 5, 0)), true);
         edtavWxname_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavWxname_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavWxname_Enabled), 5, 0)), true);
         edtBR_MedicalImaging_ImageOrgan_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_MedicalImaging_ImageOrgan_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_MedicalImaging_ImageOrgan_Enabled), 5, 0)), true);
         edtBR_MedicalImaging_ImageDes_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_MedicalImaging_ImageDes_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_MedicalImaging_ImageDes_Enabled), 5, 0)), true);
         cmbBR_MedicalImaging_MetastasesDX.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_MedicalImaging_MetastasesDX_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbBR_MedicalImaging_MetastasesDX.Enabled), 5, 0)), true);
         edtBR_MedicalImaging_MetaLoc_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_MedicalImaging_MetaLoc_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_MedicalImaging_MetaLoc_Enabled), 5, 0)), true);
         edtBR_MedicalImaging_MetaDate_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_MedicalImaging_MetaDate_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_MedicalImaging_MetaDate_Enabled), 5, 0)), true);
         edtBR_MedicalImagingID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_MedicalImagingID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_MedicalImagingID_Enabled), 5, 0)), true);
         edtBR_EncounterID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_EncounterID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_EncounterID_Enabled), 5, 0)), true);
         edtBR_Information_PatientNo_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Information_PatientNo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Information_PatientNo_Enabled), 5, 0)), true);
         edtBR_MedicalImaging_ID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_MedicalImaging_ID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_MedicalImaging_ID_Enabled), 5, 0)), true);
      }

      protected void send_integrity_lvl_hashes0T30( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues0T0( )
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
         context.AddJavascriptSource("gxcfg.js", "?20202279375657", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_medicalimaging.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7BR_MedicalImagingID)+"\">") ;
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
         forbiddenHiddens = "hsh" + "BR_MedicalImaging";
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A225BR_MedicalImagingID), "ZZZZZZZZZZZZZZZZZZ");
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( AV18tCurrentCode, ""));
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV13Insert_BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ");
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A486BR_MedicalImaging_ImageLoc_Code, ""));
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("br_medicalimaging:[SendSecurityCheck value for]"+"BR_MedicalImagingID:"+context.localUtil.Format( (decimal)(A225BR_MedicalImagingID), "ZZZZZZZZZZZZZZZZZZ"));
         GXUtil.WriteLog("br_medicalimaging:[SendSecurityCheck value for]"+"tCurrentCode:"+StringUtil.RTrim( context.localUtil.Format( AV18tCurrentCode, "")));
         GXUtil.WriteLog("br_medicalimaging:[SendSecurityCheck value for]"+"Insert_BR_EncounterID:"+context.localUtil.Format( (decimal)(AV13Insert_BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ"));
         GXUtil.WriteLog("br_medicalimaging:[SendSecurityCheck value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
         GXUtil.WriteLog("br_medicalimaging:[SendSecurityCheck value for]"+"BR_MedicalImaging_ImageLoc_Code:"+StringUtil.RTrim( context.localUtil.Format( A486BR_MedicalImaging_ImageLoc_Code, "")));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z225BR_MedicalImagingID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z225BR_MedicalImagingID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z484BR_MedicalImaging_ImageName_Code", Z484BR_MedicalImaging_ImageName_Code);
         GxWebStd.gx_hidden_field( context, "Z485BR_MedicalImaging_ImageHosp_Code", Z485BR_MedicalImaging_ImageHosp_Code);
         GxWebStd.gx_hidden_field( context, "Z227BR_MedicalImaging_ID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z227BR_MedicalImaging_ID), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z518BR_MedicalImaging_No", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z518BR_MedicalImaging_No), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z228BR_MedicalImaging_ImageName", Z228BR_MedicalImaging_ImageName);
         GxWebStd.gx_hidden_field( context, "Z229BR_MedicalImaging_ImageDate", context.localUtil.DToC( Z229BR_MedicalImaging_ImageDate, 0, "/"));
         GxWebStd.gx_hidden_field( context, "Z230BR_MedicalImaging_ImageHosp", Z230BR_MedicalImaging_ImageHosp);
         GxWebStd.gx_hidden_field( context, "Z231BR_MedicalImaging_ImageAge", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z231BR_MedicalImaging_ImageAge), 3, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z232BR_MedicalImaging_ImageLoc", Z232BR_MedicalImaging_ImageLoc);
         GxWebStd.gx_hidden_field( context, "Z486BR_MedicalImaging_ImageLoc_Code", Z486BR_MedicalImaging_ImageLoc_Code);
         GxWebStd.gx_hidden_field( context, "Z233BR_MedicalImaging_ImageOrgan", Z233BR_MedicalImaging_ImageOrgan);
         GxWebStd.gx_hidden_field( context, "Z234BR_MedicalImaging_PreImageDiag", Z234BR_MedicalImaging_PreImageDiag);
         GxWebStd.gx_hidden_field( context, "Z235BR_MedicalImaging_ImageDes", Z235BR_MedicalImaging_ImageDes);
         GxWebStd.gx_hidden_field( context, "Z236BR_MedicalImaging_TumorSize", Z236BR_MedicalImaging_TumorSize);
         GxWebStd.gx_hidden_field( context, "Z514BR_MedicalImaging_MetastasesDX", Z514BR_MedicalImaging_MetastasesDX);
         GxWebStd.gx_hidden_field( context, "Z515BR_MedicalImaging_MetaLoc", Z515BR_MedicalImaging_MetaLoc);
         GxWebStd.gx_hidden_field( context, "Z516BR_MedicalImaging_MetaDate", context.localUtil.DToC( Z516BR_MedicalImaging_MetaDate, 0, "/"));
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
         GxWebStd.gx_hidden_field( context, "vBR_MEDICALIMAGINGID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7BR_MedicalImagingID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vBR_MEDICALIMAGINGID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7BR_MedicalImagingID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, "vINSERT_BR_ENCOUNTERID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13Insert_BR_EncounterID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "BR_MEDICALIMAGING_IMAGENAME_CODE", A484BR_MedicalImaging_ImageName_Code);
         GxWebStd.gx_hidden_field( context, "BR_MEDICALIMAGING_IMAGEHOSP_CODE", A485BR_MedicalImaging_ImageHosp_Code);
         GxWebStd.gx_hidden_field( context, "vTCURRENTCODE", AV18tCurrentCode);
         GxWebStd.gx_hidden_field( context, "BR_MEDICALIMAGING_IMAGELOC_CODE", A486BR_MedicalImaging_ImageLoc_Code);
         GxWebStd.gx_hidden_field( context, "BR_MEDICALIMAGING_IMAGEHTML", A334BR_MedicalImaging_ImageHtml);
         GxWebStd.gx_hidden_field( context, "BR_INFORMATION_ID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A85BR_Information_ID), 18, 0, ".", "")));
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
         return formatLink("br_medicalimaging.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7BR_MedicalImagingID) ;
      }

      public override String GetPgmname( )
      {
         return "BR_MedicalImaging" ;
      }

      public override String GetPgmdesc( )
      {
         return "Data Mgmt Portal - RAAP" ;
      }

      protected void InitializeNonKey0T30( )
      {
         A85BR_Information_ID = 0;
         n85BR_Information_ID = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A85BR_Information_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A85BR_Information_ID), 18, 0)));
         A19BR_EncounterID = 0;
         n19BR_EncounterID = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
         n19BR_EncounterID = ((0==A19BR_EncounterID) ? true : false);
         AV15vName = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15vName", AV15vName);
         AV16wxname = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16wxname", AV16wxname);
         A484BR_MedicalImaging_ImageName_Code = "";
         n484BR_MedicalImaging_ImageName_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A484BR_MedicalImaging_ImageName_Code", A484BR_MedicalImaging_ImageName_Code);
         A485BR_MedicalImaging_ImageHosp_Code = "";
         n485BR_MedicalImaging_ImageHosp_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A485BR_MedicalImaging_ImageHosp_Code", A485BR_MedicalImaging_ImageHosp_Code);
         A36BR_Information_PatientNo = "";
         n36BR_Information_PatientNo = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36BR_Information_PatientNo", A36BR_Information_PatientNo);
         A227BR_MedicalImaging_ID = 0;
         n227BR_MedicalImaging_ID = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A227BR_MedicalImaging_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A227BR_MedicalImaging_ID), 10, 0)));
         n227BR_MedicalImaging_ID = ((0==A227BR_MedicalImaging_ID) ? true : false);
         A518BR_MedicalImaging_No = 0;
         n518BR_MedicalImaging_No = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A518BR_MedicalImaging_No", StringUtil.LTrim( StringUtil.Str( (decimal)(A518BR_MedicalImaging_No), 18, 0)));
         n518BR_MedicalImaging_No = ((0==A518BR_MedicalImaging_No) ? true : false);
         A228BR_MedicalImaging_ImageName = "";
         n228BR_MedicalImaging_ImageName = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A228BR_MedicalImaging_ImageName", A228BR_MedicalImaging_ImageName);
         n228BR_MedicalImaging_ImageName = (String.IsNullOrEmpty(StringUtil.RTrim( A228BR_MedicalImaging_ImageName)) ? true : false);
         A229BR_MedicalImaging_ImageDate = DateTime.MinValue;
         n229BR_MedicalImaging_ImageDate = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A229BR_MedicalImaging_ImageDate", context.localUtil.Format(A229BR_MedicalImaging_ImageDate, "9999/99/99"));
         n229BR_MedicalImaging_ImageDate = ((DateTime.MinValue==A229BR_MedicalImaging_ImageDate) ? true : false);
         A230BR_MedicalImaging_ImageHosp = "";
         n230BR_MedicalImaging_ImageHosp = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A230BR_MedicalImaging_ImageHosp", A230BR_MedicalImaging_ImageHosp);
         n230BR_MedicalImaging_ImageHosp = (String.IsNullOrEmpty(StringUtil.RTrim( A230BR_MedicalImaging_ImageHosp)) ? true : false);
         A231BR_MedicalImaging_ImageAge = 0;
         n231BR_MedicalImaging_ImageAge = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A231BR_MedicalImaging_ImageAge", StringUtil.LTrim( StringUtil.Str( (decimal)(A231BR_MedicalImaging_ImageAge), 3, 0)));
         n231BR_MedicalImaging_ImageAge = ((0==A231BR_MedicalImaging_ImageAge) ? true : false);
         A232BR_MedicalImaging_ImageLoc = "";
         n232BR_MedicalImaging_ImageLoc = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A232BR_MedicalImaging_ImageLoc", A232BR_MedicalImaging_ImageLoc);
         n232BR_MedicalImaging_ImageLoc = (String.IsNullOrEmpty(StringUtil.RTrim( A232BR_MedicalImaging_ImageLoc)) ? true : false);
         A486BR_MedicalImaging_ImageLoc_Code = "";
         n486BR_MedicalImaging_ImageLoc_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A486BR_MedicalImaging_ImageLoc_Code", A486BR_MedicalImaging_ImageLoc_Code);
         A233BR_MedicalImaging_ImageOrgan = "";
         n233BR_MedicalImaging_ImageOrgan = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A233BR_MedicalImaging_ImageOrgan", A233BR_MedicalImaging_ImageOrgan);
         n233BR_MedicalImaging_ImageOrgan = (String.IsNullOrEmpty(StringUtil.RTrim( A233BR_MedicalImaging_ImageOrgan)) ? true : false);
         A234BR_MedicalImaging_PreImageDiag = "";
         n234BR_MedicalImaging_PreImageDiag = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A234BR_MedicalImaging_PreImageDiag", A234BR_MedicalImaging_PreImageDiag);
         n234BR_MedicalImaging_PreImageDiag = (String.IsNullOrEmpty(StringUtil.RTrim( A234BR_MedicalImaging_PreImageDiag)) ? true : false);
         A235BR_MedicalImaging_ImageDes = "";
         n235BR_MedicalImaging_ImageDes = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A235BR_MedicalImaging_ImageDes", A235BR_MedicalImaging_ImageDes);
         n235BR_MedicalImaging_ImageDes = (String.IsNullOrEmpty(StringUtil.RTrim( A235BR_MedicalImaging_ImageDes)) ? true : false);
         A236BR_MedicalImaging_TumorSize = "";
         n236BR_MedicalImaging_TumorSize = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A236BR_MedicalImaging_TumorSize", A236BR_MedicalImaging_TumorSize);
         n236BR_MedicalImaging_TumorSize = (String.IsNullOrEmpty(StringUtil.RTrim( A236BR_MedicalImaging_TumorSize)) ? true : false);
         A334BR_MedicalImaging_ImageHtml = "";
         n334BR_MedicalImaging_ImageHtml = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A334BR_MedicalImaging_ImageHtml", A334BR_MedicalImaging_ImageHtml);
         A514BR_MedicalImaging_MetastasesDX = "";
         n514BR_MedicalImaging_MetastasesDX = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A514BR_MedicalImaging_MetastasesDX", A514BR_MedicalImaging_MetastasesDX);
         n514BR_MedicalImaging_MetastasesDX = (String.IsNullOrEmpty(StringUtil.RTrim( A514BR_MedicalImaging_MetastasesDX)) ? true : false);
         A515BR_MedicalImaging_MetaLoc = "";
         n515BR_MedicalImaging_MetaLoc = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A515BR_MedicalImaging_MetaLoc", A515BR_MedicalImaging_MetaLoc);
         n515BR_MedicalImaging_MetaLoc = (String.IsNullOrEmpty(StringUtil.RTrim( A515BR_MedicalImaging_MetaLoc)) ? true : false);
         A516BR_MedicalImaging_MetaDate = DateTime.MinValue;
         n516BR_MedicalImaging_MetaDate = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A516BR_MedicalImaging_MetaDate", context.localUtil.Format(A516BR_MedicalImaging_MetaDate, "9999/99/99"));
         n516BR_MedicalImaging_MetaDate = ((DateTime.MinValue==A516BR_MedicalImaging_MetaDate) ? true : false);
         Z484BR_MedicalImaging_ImageName_Code = "";
         Z485BR_MedicalImaging_ImageHosp_Code = "";
         Z227BR_MedicalImaging_ID = 0;
         Z518BR_MedicalImaging_No = 0;
         Z228BR_MedicalImaging_ImageName = "";
         Z229BR_MedicalImaging_ImageDate = DateTime.MinValue;
         Z230BR_MedicalImaging_ImageHosp = "";
         Z231BR_MedicalImaging_ImageAge = 0;
         Z232BR_MedicalImaging_ImageLoc = "";
         Z486BR_MedicalImaging_ImageLoc_Code = "";
         Z233BR_MedicalImaging_ImageOrgan = "";
         Z234BR_MedicalImaging_PreImageDiag = "";
         Z235BR_MedicalImaging_ImageDes = "";
         Z236BR_MedicalImaging_TumorSize = "";
         Z514BR_MedicalImaging_MetastasesDX = "";
         Z515BR_MedicalImaging_MetaLoc = "";
         Z516BR_MedicalImaging_MetaDate = DateTime.MinValue;
         Z19BR_EncounterID = 0;
      }

      protected void InitAll0T30( )
      {
         A225BR_MedicalImagingID = 0;
         n225BR_MedicalImagingID = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A225BR_MedicalImagingID", StringUtil.LTrim( StringUtil.Str( (decimal)(A225BR_MedicalImagingID), 18, 0)));
         InitializeNonKey0T30( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20202279375715", true);
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
         context.AddJavascriptSource("br_medicalimaging.js", "?20202279375716", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         lblTextblockbr_medicalimaging_no_Internalname = "TEXTBLOCKBR_MEDICALIMAGING_NO";
         edtBR_MedicalImaging_No_Internalname = "BR_MEDICALIMAGING_NO";
         divUnnamedtablebr_medicalimaging_no_Internalname = "UNNAMEDTABLEBR_MEDICALIMAGING_NO";
         lblTextblockbr_medicalimaging_imagename_Internalname = "TEXTBLOCKBR_MEDICALIMAGING_IMAGENAME";
         dynBR_MedicalImaging_ImageName_Internalname = "BR_MEDICALIMAGING_IMAGENAME";
         edtavVname_Internalname = "vVNAME";
         cellVname_cell_Internalname = "VNAME_CELL";
         tblTablemergedbr_medicalimaging_imagename_Internalname = "TABLEMERGEDBR_MEDICALIMAGING_IMAGENAME";
         divTablesplittedbr_medicalimaging_imagename_Internalname = "TABLESPLITTEDBR_MEDICALIMAGING_IMAGENAME";
         lblTextblockbr_medicalimaging_imageage_Internalname = "TEXTBLOCKBR_MEDICALIMAGING_IMAGEAGE";
         edtBR_MedicalImaging_ImageAge_Internalname = "BR_MEDICALIMAGING_IMAGEAGE";
         divUnnamedtablebr_medicalimaging_imageage_Internalname = "UNNAMEDTABLEBR_MEDICALIMAGING_IMAGEAGE";
         lblTextblockbr_medicalimaging_imagedate_Internalname = "TEXTBLOCKBR_MEDICALIMAGING_IMAGEDATE";
         edtBR_MedicalImaging_ImageDate_Internalname = "BR_MEDICALIMAGING_IMAGEDATE";
         divUnnamedtablebr_medicalimaging_imagedate_Internalname = "UNNAMEDTABLEBR_MEDICALIMAGING_IMAGEDATE";
         lblTextblockbr_medicalimaging_imagehosp_Internalname = "TEXTBLOCKBR_MEDICALIMAGING_IMAGEHOSP";
         dynBR_MedicalImaging_ImageHosp_Internalname = "BR_MEDICALIMAGING_IMAGEHOSP";
         divUnnamedtablebr_medicalimaging_imagehosp_Internalname = "UNNAMEDTABLEBR_MEDICALIMAGING_IMAGEHOSP";
         lblTextblockbr_medicalimaging_tumorsize_Internalname = "TEXTBLOCKBR_MEDICALIMAGING_TUMORSIZE";
         edtBR_MedicalImaging_TumorSize_Internalname = "BR_MEDICALIMAGING_TUMORSIZE";
         divUnnamedtablebr_medicalimaging_tumorsize_Internalname = "UNNAMEDTABLEBR_MEDICALIMAGING_TUMORSIZE";
         lblTextblockbr_medicalimaging_preimagediag_Internalname = "TEXTBLOCKBR_MEDICALIMAGING_PREIMAGEDIAG";
         edtBR_MedicalImaging_PreImageDiag_Internalname = "BR_MEDICALIMAGING_PREIMAGEDIAG";
         divUnnamedtablebr_medicalimaging_preimagediag_Internalname = "UNNAMEDTABLEBR_MEDICALIMAGING_PREIMAGEDIAG";
         lblTextblockbr_medicalimaging_imageloc_Internalname = "TEXTBLOCKBR_MEDICALIMAGING_IMAGELOC";
         dynBR_MedicalImaging_ImageLoc_Internalname = "BR_MEDICALIMAGING_IMAGELOC";
         edtavWxname_Internalname = "vWXNAME";
         cellWxname_cell_Internalname = "WXNAME_CELL";
         tblTablemergedbr_medicalimaging_imageloc_Internalname = "TABLEMERGEDBR_MEDICALIMAGING_IMAGELOC";
         divTablesplittedbr_medicalimaging_imageloc_Internalname = "TABLESPLITTEDBR_MEDICALIMAGING_IMAGELOC";
         lblTextblockbr_medicalimaging_imageorgan_Internalname = "TEXTBLOCKBR_MEDICALIMAGING_IMAGEORGAN";
         edtBR_MedicalImaging_ImageOrgan_Internalname = "BR_MEDICALIMAGING_IMAGEORGAN";
         divUnnamedtablebr_medicalimaging_imageorgan_Internalname = "UNNAMEDTABLEBR_MEDICALIMAGING_IMAGEORGAN";
         lblTextblockbr_medicalimaging_imagedes_Internalname = "TEXTBLOCKBR_MEDICALIMAGING_IMAGEDES";
         edtBR_MedicalImaging_ImageDes_Internalname = "BR_MEDICALIMAGING_IMAGEDES";
         divUnnamedtablebr_medicalimaging_imagedes_Internalname = "UNNAMEDTABLEBR_MEDICALIMAGING_IMAGEDES";
         lblTextblockbr_medicalimaging_metastasesdx_Internalname = "TEXTBLOCKBR_MEDICALIMAGING_METASTASESDX";
         cmbBR_MedicalImaging_MetastasesDX_Internalname = "BR_MEDICALIMAGING_METASTASESDX";
         divUnnamedtablebr_medicalimaging_metastasesdx_Internalname = "UNNAMEDTABLEBR_MEDICALIMAGING_METASTASESDX";
         lblTextblockbr_medicalimaging_metaloc_Internalname = "TEXTBLOCKBR_MEDICALIMAGING_METALOC";
         edtBR_MedicalImaging_MetaLoc_Internalname = "BR_MEDICALIMAGING_METALOC";
         divUnnamedtablebr_medicalimaging_metaloc_Internalname = "UNNAMEDTABLEBR_MEDICALIMAGING_METALOC";
         divBr_medicalimaging_metaloc_cell_Internalname = "BR_MEDICALIMAGING_METALOC_CELL";
         lblTextblockbr_medicalimaging_metadate_Internalname = "TEXTBLOCKBR_MEDICALIMAGING_METADATE";
         edtBR_MedicalImaging_MetaDate_Internalname = "BR_MEDICALIMAGING_METADATE";
         divUnnamedtablebr_medicalimaging_metadate_Internalname = "UNNAMEDTABLEBR_MEDICALIMAGING_METADATE";
         divBr_medicalimaging_metadate_cell_Internalname = "BR_MEDICALIMAGING_METADATE_CELL";
         divTableattributes_Internalname = "TABLEATTRIBUTES";
         divLayout_tableattributes_Internalname = "LAYOUT_TABLEATTRIBUTES";
         Dvpanel_tableattributes_Internalname = "DVPANEL_TABLEATTRIBUTES";
         divHtml_dvpanel_tableattributes_Internalname = "HTML_DVPANEL_TABLEATTRIBUTES";
         divTablecontent_Internalname = "TABLECONTENT";
         bttBtntrn_enter_Internalname = "BTNTRN_ENTER";
         bttBtntrn_cancel_Internalname = "BTNTRN_CANCEL";
         bttBtntrn_delete_Internalname = "BTNTRN_DELETE";
         divTablemain_Internalname = "TABLEMAIN";
         edtBR_MedicalImagingID_Internalname = "BR_MEDICALIMAGINGID";
         edtBR_EncounterID_Internalname = "BR_ENCOUNTERID";
         edtBR_Information_PatientNo_Internalname = "BR_INFORMATION_PATIENTNO";
         edtBR_MedicalImaging_ID_Internalname = "BR_MEDICALIMAGING_ID";
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
         edtavVname_Jsonclick = "";
         edtavVname_Enabled = 1;
         edtavVname_Visible = 1;
         cellVname_cell_Class = "";
         dynBR_MedicalImaging_ImageName_Jsonclick = "";
         dynBR_MedicalImaging_ImageName.Enabled = 1;
         edtavWxname_Jsonclick = "";
         edtavWxname_Enabled = 1;
         edtavWxname_Visible = 1;
         cellWxname_cell_Class = "";
         dynBR_MedicalImaging_ImageLoc_Jsonclick = "";
         dynBR_MedicalImaging_ImageLoc.Enabled = 1;
         edtBR_MedicalImaging_ID_Jsonclick = "";
         edtBR_MedicalImaging_ID_Enabled = 1;
         edtBR_MedicalImaging_ID_Visible = 1;
         edtBR_Information_PatientNo_Jsonclick = "";
         edtBR_Information_PatientNo_Enabled = 0;
         edtBR_Information_PatientNo_Visible = 1;
         edtBR_EncounterID_Jsonclick = "";
         edtBR_EncounterID_Enabled = 1;
         edtBR_EncounterID_Visible = 1;
         edtBR_MedicalImagingID_Jsonclick = "";
         edtBR_MedicalImagingID_Enabled = 0;
         edtBR_MedicalImagingID_Visible = 1;
         bttBtntrn_delete_Enabled = 0;
         bttBtntrn_delete_Visible = 1;
         bttBtntrn_cancel_Visible = 1;
         bttBtntrn_enter_Enabled = 1;
         bttBtntrn_enter_Visible = 1;
         edtBR_MedicalImaging_MetaDate_Jsonclick = "";
         edtBR_MedicalImaging_MetaDate_Enabled = 1;
         edtBR_MedicalImaging_MetaDate_Visible = 1;
         divBr_medicalimaging_metadate_cell_Class = "col-xs-12 col-md-6";
         edtBR_MedicalImaging_MetaLoc_Jsonclick = "";
         edtBR_MedicalImaging_MetaLoc_Enabled = 1;
         edtBR_MedicalImaging_MetaLoc_Visible = 1;
         divBr_medicalimaging_metaloc_cell_Class = "col-xs-12 col-md-6";
         cmbBR_MedicalImaging_MetastasesDX_Jsonclick = "";
         cmbBR_MedicalImaging_MetastasesDX.Enabled = 1;
         edtBR_MedicalImaging_ImageDes_Enabled = 1;
         edtBR_MedicalImaging_ImageOrgan_Enabled = 1;
         edtBR_MedicalImaging_PreImageDiag_Enabled = 1;
         edtBR_MedicalImaging_TumorSize_Jsonclick = "";
         edtBR_MedicalImaging_TumorSize_Enabled = 1;
         dynBR_MedicalImaging_ImageHosp_Jsonclick = "";
         dynBR_MedicalImaging_ImageHosp.Enabled = 1;
         edtBR_MedicalImaging_ImageDate_Jsonclick = "";
         edtBR_MedicalImaging_ImageDate_Enabled = 1;
         edtBR_MedicalImaging_ImageAge_Jsonclick = "";
         edtBR_MedicalImaging_ImageAge_Enabled = 1;
         edtBR_MedicalImaging_No_Jsonclick = "";
         edtBR_MedicalImaging_No_Enabled = 1;
         Dvpanel_tableattributes_Autoscroll = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Iconposition = "left";
         Dvpanel_tableattributes_Showcollapseicon = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsed = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsible = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Title = "影像学";
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

      protected void GXDLABR_MEDICALIMAGING_IMAGENAME0T30( String AV18tCurrentCode )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLABR_MEDICALIMAGING_IMAGENAME_data0T30( AV18tCurrentCode) ;
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

      protected void GXABR_MEDICALIMAGING_IMAGENAME_html0T30( String AV18tCurrentCode )
      {
         String gxdynajaxvalue ;
         GXDLABR_MEDICALIMAGING_IMAGENAME_data0T30( AV18tCurrentCode) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynBR_MedicalImaging_ImageName.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex));
            dynBR_MedicalImaging_ImageName.addItem(gxdynajaxvalue, ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLABR_MEDICALIMAGING_IMAGENAME_data0T30( String AV18tCurrentCode )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         /* Using cursor T000T19 */
         pr_default.execute(17, new Object[] {AV18tCurrentCode});
         while ( (pr_default.getStatus(17) != 101) )
         {
            gxdynajaxctrlcodr.Add(T000T19_A168XT_DefineCodeName[0]);
            gxdynajaxctrldescr.Add(T000T19_A168XT_DefineCodeName[0]);
            pr_default.readNext(17);
         }
         pr_default.close(17);
      }

      protected void GXDLABR_MEDICALIMAGING_IMAGEHOSP0T30( String AV18tCurrentCode )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLABR_MEDICALIMAGING_IMAGEHOSP_data0T30( AV18tCurrentCode) ;
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

      protected void GXABR_MEDICALIMAGING_IMAGEHOSP_html0T30( String AV18tCurrentCode )
      {
         String gxdynajaxvalue ;
         GXDLABR_MEDICALIMAGING_IMAGEHOSP_data0T30( AV18tCurrentCode) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynBR_MedicalImaging_ImageHosp.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex));
            dynBR_MedicalImaging_ImageHosp.addItem(gxdynajaxvalue, ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLABR_MEDICALIMAGING_IMAGEHOSP_data0T30( String AV18tCurrentCode )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add("");
         gxdynajaxctrldescr.Add("(请选择)");
         /* Using cursor T000T20 */
         pr_default.execute(18, new Object[] {AV18tCurrentCode});
         while ( (pr_default.getStatus(18) != 101) )
         {
            gxdynajaxctrlcodr.Add(T000T20_A168XT_DefineCodeName[0]);
            gxdynajaxctrldescr.Add(T000T20_A168XT_DefineCodeName[0]);
            pr_default.readNext(18);
         }
         pr_default.close(18);
      }

      protected void GXDLABR_MEDICALIMAGING_IMAGELOC0T30( String AV18tCurrentCode )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLABR_MEDICALIMAGING_IMAGELOC_data0T30( AV18tCurrentCode) ;
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

      protected void GXABR_MEDICALIMAGING_IMAGELOC_html0T30( String AV18tCurrentCode )
      {
         String gxdynajaxvalue ;
         GXDLABR_MEDICALIMAGING_IMAGELOC_data0T30( AV18tCurrentCode) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynBR_MedicalImaging_ImageLoc.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex));
            dynBR_MedicalImaging_ImageLoc.addItem(gxdynajaxvalue, ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLABR_MEDICALIMAGING_IMAGELOC_data0T30( String AV18tCurrentCode )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add("");
         gxdynajaxctrldescr.Add("(请选择)");
         /* Using cursor T000T21 */
         pr_default.execute(19, new Object[] {AV18tCurrentCode});
         while ( (pr_default.getStatus(19) != 101) )
         {
            gxdynajaxctrlcodr.Add(T000T21_A168XT_DefineCodeName[0]);
            gxdynajaxctrldescr.Add(T000T21_A168XT_DefineCodeName[0]);
            pr_default.readNext(19);
         }
         pr_default.close(19);
      }

      protected void GX18ASABR_MEDICALIMAGING_IMAGENAME_CODE0T30( String A228BR_MedicalImaging_ImageName )
      {
         GXt_char1 = A484BR_MedicalImaging_ImageName_Code;
         new zutil_findtargetcode(context ).execute(  30,  A228BR_MedicalImaging_ImageName, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A228BR_MedicalImaging_ImageName", A228BR_MedicalImaging_ImageName);
         A484BR_MedicalImaging_ImageName_Code = GXt_char1;
         n484BR_MedicalImaging_ImageName_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A484BR_MedicalImaging_ImageName_Code", A484BR_MedicalImaging_ImageName_Code);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A484BR_MedicalImaging_ImageName_Code)+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GX19ASABR_MEDICALIMAGING_IMAGENAME_CODE0T30( String A228BR_MedicalImaging_ImageName )
      {
         GXt_char1 = A484BR_MedicalImaging_ImageName_Code;
         new zutil_findtargetcode(context ).execute(  30,  A228BR_MedicalImaging_ImageName, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A228BR_MedicalImaging_ImageName", A228BR_MedicalImaging_ImageName);
         A484BR_MedicalImaging_ImageName_Code = GXt_char1;
         n484BR_MedicalImaging_ImageName_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A484BR_MedicalImaging_ImageName_Code", A484BR_MedicalImaging_ImageName_Code);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A484BR_MedicalImaging_ImageName_Code)+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GX20ASABR_MEDICALIMAGING_IMAGEHOSP_CODE0T30( String A230BR_MedicalImaging_ImageHosp )
      {
         GXt_char1 = A485BR_MedicalImaging_ImageHosp_Code;
         new zutil_findtargetcode(context ).execute(  31,  A230BR_MedicalImaging_ImageHosp, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A230BR_MedicalImaging_ImageHosp", A230BR_MedicalImaging_ImageHosp);
         A485BR_MedicalImaging_ImageHosp_Code = GXt_char1;
         n485BR_MedicalImaging_ImageHosp_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A485BR_MedicalImaging_ImageHosp_Code", A485BR_MedicalImaging_ImageHosp_Code);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A485BR_MedicalImaging_ImageHosp_Code)+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GX21ASABR_MEDICALIMAGING_IMAGEHOSP_CODE0T30( String A230BR_MedicalImaging_ImageHosp )
      {
         GXt_char1 = A485BR_MedicalImaging_ImageHosp_Code;
         new zutil_findtargetcode(context ).execute(  31,  A230BR_MedicalImaging_ImageHosp, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A230BR_MedicalImaging_ImageHosp", A230BR_MedicalImaging_ImageHosp);
         A485BR_MedicalImaging_ImageHosp_Code = GXt_char1;
         n485BR_MedicalImaging_ImageHosp_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A485BR_MedicalImaging_ImageHosp_Code", A485BR_MedicalImaging_ImageHosp_Code);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A485BR_MedicalImaging_ImageHosp_Code)+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void XC_33_0T30( )
      {
         new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)),  "就诊信息",  StringUtil.Trim( StringUtil.Str( (decimal)(A225BR_MedicalImagingID), 18, 0)),  "影像学",  "Create",  1) ;
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

      protected void XC_34_0T30( )
      {
         new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)),  "就诊信息",  StringUtil.Trim( StringUtil.Str( (decimal)(A225BR_MedicalImagingID), 18, 0)),  "影像学",  "Update",  1) ;
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

      protected void XC_35_0T30( )
      {
         new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)),  "就诊信息",  StringUtil.Trim( StringUtil.Str( (decimal)(A225BR_MedicalImagingID), 18, 0)),  "影像学",  "Delete",  1) ;
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
         dynBR_MedicalImaging_ImageName.Name = "BR_MEDICALIMAGING_IMAGENAME";
         dynBR_MedicalImaging_ImageName.WebTags = "";
         dynBR_MedicalImaging_ImageHosp.Name = "BR_MEDICALIMAGING_IMAGEHOSP";
         dynBR_MedicalImaging_ImageHosp.WebTags = "";
         dynBR_MedicalImaging_ImageLoc.Name = "BR_MEDICALIMAGING_IMAGELOC";
         dynBR_MedicalImaging_ImageLoc.WebTags = "";
         cmbBR_MedicalImaging_MetastasesDX.Name = "BR_MEDICALIMAGING_METASTASESDX";
         cmbBR_MedicalImaging_MetastasesDX.WebTags = "";
         cmbBR_MedicalImaging_MetastasesDX.addItem("", "(请选择)", 0);
         cmbBR_MedicalImaging_MetastasesDX.addItem("否", "否", 0);
         cmbBR_MedicalImaging_MetastasesDX.addItem("是", "是", 0);
         cmbBR_MedicalImaging_MetastasesDX.addItem("不详", "不详", 0);
         if ( cmbBR_MedicalImaging_MetastasesDX.ItemCount > 0 )
         {
            A514BR_MedicalImaging_MetastasesDX = cmbBR_MedicalImaging_MetastasesDX.getValidValue(A514BR_MedicalImaging_MetastasesDX);
            n514BR_MedicalImaging_MetastasesDX = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A514BR_MedicalImaging_MetastasesDX", A514BR_MedicalImaging_MetastasesDX);
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
         /* Using cursor T000T22 */
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
         A85BR_Information_ID = T000T22_A85BR_Information_ID[0];
         n85BR_Information_ID = T000T22_n85BR_Information_ID[0];
         pr_default.close(20);
         /* Using cursor T000T23 */
         pr_default.execute(21, new Object[] {n85BR_Information_ID, A85BR_Information_ID});
         if ( (pr_default.getStatus(21) == 101) )
         {
            if ( ! ( (0==A85BR_Information_ID) ) )
            {
               GX_msglist.addItem("不匹配' T16'", "ForeignKeyNotFound", 1, "");
               AnyError = 1;
            }
         }
         A36BR_Information_PatientNo = T000T23_A36BR_Information_PatientNo[0];
         n36BR_Information_PatientNo = T000T23_n36BR_Information_PatientNo[0];
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
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7BR_MedicalImagingID',fld:'vBR_MEDICALIMAGINGID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7BR_MedicalImagingID',fld:'vBR_MEDICALIMAGINGID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'A225BR_MedicalImagingID',fld:'BR_MEDICALIMAGINGID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'AV13Insert_BR_EncounterID',fld:'vINSERT_BR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'A486BR_MedicalImaging_ImageLoc_Code',fld:'BR_MEDICALIMAGING_IMAGELOC_CODE',pic:''}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("AFTER TRN","{handler:'E120T2',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV11TrnContext',fld:'vTRNCONTEXT',pic:''},{av:'A225BR_MedicalImagingID',fld:'BR_MEDICALIMAGINGID',pic:'ZZZZZZZZZZZZZZZZZZ'}]");
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
         Z484BR_MedicalImaging_ImageName_Code = "";
         Z485BR_MedicalImaging_ImageHosp_Code = "";
         Z228BR_MedicalImaging_ImageName = "";
         Z229BR_MedicalImaging_ImageDate = DateTime.MinValue;
         Z230BR_MedicalImaging_ImageHosp = "";
         Z232BR_MedicalImaging_ImageLoc = "";
         Z486BR_MedicalImaging_ImageLoc_Code = "";
         Z233BR_MedicalImaging_ImageOrgan = "";
         Z234BR_MedicalImaging_PreImageDiag = "";
         Z235BR_MedicalImaging_ImageDes = "";
         Z236BR_MedicalImaging_TumorSize = "";
         Z514BR_MedicalImaging_MetastasesDX = "";
         Z515BR_MedicalImaging_MetaLoc = "";
         Z516BR_MedicalImaging_MetaDate = DateTime.MinValue;
         scmdbuf = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV18tCurrentCode = "";
         A228BR_MedicalImaging_ImageName = "";
         A230BR_MedicalImaging_ImageHosp = "";
         GXKey = "";
         PreviousTooltip = "";
         PreviousCaption = "";
         Form = new GXWebForm();
         GX_FocusControl = "";
         A232BR_MedicalImaging_ImageLoc = "";
         A514BR_MedicalImaging_MetastasesDX = "";
         ClassString = "";
         StyleString = "";
         ucDvpanel_tableattributes = new GXUserControl();
         lblTextblockbr_medicalimaging_no_Jsonclick = "";
         TempTags = "";
         lblTextblockbr_medicalimaging_imagename_Jsonclick = "";
         lblTextblockbr_medicalimaging_imageage_Jsonclick = "";
         lblTextblockbr_medicalimaging_imagedate_Jsonclick = "";
         A229BR_MedicalImaging_ImageDate = DateTime.MinValue;
         lblTextblockbr_medicalimaging_imagehosp_Jsonclick = "";
         lblTextblockbr_medicalimaging_tumorsize_Jsonclick = "";
         A236BR_MedicalImaging_TumorSize = "";
         lblTextblockbr_medicalimaging_preimagediag_Jsonclick = "";
         A234BR_MedicalImaging_PreImageDiag = "";
         lblTextblockbr_medicalimaging_imageloc_Jsonclick = "";
         lblTextblockbr_medicalimaging_imageorgan_Jsonclick = "";
         A233BR_MedicalImaging_ImageOrgan = "";
         lblTextblockbr_medicalimaging_imagedes_Jsonclick = "";
         A235BR_MedicalImaging_ImageDes = "";
         lblTextblockbr_medicalimaging_metastasesdx_Jsonclick = "";
         lblTextblockbr_medicalimaging_metaloc_Jsonclick = "";
         A515BR_MedicalImaging_MetaLoc = "";
         lblTextblockbr_medicalimaging_metadate_Jsonclick = "";
         A516BR_MedicalImaging_MetaDate = DateTime.MinValue;
         bttBtntrn_enter_Jsonclick = "";
         bttBtntrn_cancel_Jsonclick = "";
         bttBtntrn_delete_Jsonclick = "";
         A36BR_Information_PatientNo = "";
         sStyleString = "";
         AV16wxname = "";
         AV15vName = "";
         A484BR_MedicalImaging_ImageName_Code = "";
         A485BR_MedicalImaging_ImageHosp_Code = "";
         A486BR_MedicalImaging_ImageLoc_Code = "";
         A334BR_MedicalImaging_ImageHtml = "";
         AV19Pgmname = "";
         Dvpanel_tableattributes_Objectcall = "";
         Dvpanel_tableattributes_Class = "";
         Dvpanel_tableattributes_Height = "";
         forbiddenHiddens = "";
         hsh = "";
         sMode30 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV8WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV11TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV12WebSession = context.GetSession();
         AV14TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         Z334BR_MedicalImaging_ImageHtml = "";
         Z36BR_Information_PatientNo = "";
         T000T4_A85BR_Information_ID = new long[1] ;
         T000T4_n85BR_Information_ID = new bool[] {false} ;
         T000T5_A36BR_Information_PatientNo = new String[] {""} ;
         T000T5_n36BR_Information_PatientNo = new bool[] {false} ;
         T000T6_A85BR_Information_ID = new long[1] ;
         T000T6_n85BR_Information_ID = new bool[] {false} ;
         T000T6_A225BR_MedicalImagingID = new long[1] ;
         T000T6_n225BR_MedicalImagingID = new bool[] {false} ;
         T000T6_A484BR_MedicalImaging_ImageName_Code = new String[] {""} ;
         T000T6_n484BR_MedicalImaging_ImageName_Code = new bool[] {false} ;
         T000T6_A485BR_MedicalImaging_ImageHosp_Code = new String[] {""} ;
         T000T6_n485BR_MedicalImaging_ImageHosp_Code = new bool[] {false} ;
         T000T6_A36BR_Information_PatientNo = new String[] {""} ;
         T000T6_n36BR_Information_PatientNo = new bool[] {false} ;
         T000T6_A227BR_MedicalImaging_ID = new long[1] ;
         T000T6_n227BR_MedicalImaging_ID = new bool[] {false} ;
         T000T6_A518BR_MedicalImaging_No = new long[1] ;
         T000T6_n518BR_MedicalImaging_No = new bool[] {false} ;
         T000T6_A228BR_MedicalImaging_ImageName = new String[] {""} ;
         T000T6_n228BR_MedicalImaging_ImageName = new bool[] {false} ;
         T000T6_A229BR_MedicalImaging_ImageDate = new DateTime[] {DateTime.MinValue} ;
         T000T6_n229BR_MedicalImaging_ImageDate = new bool[] {false} ;
         T000T6_A230BR_MedicalImaging_ImageHosp = new String[] {""} ;
         T000T6_n230BR_MedicalImaging_ImageHosp = new bool[] {false} ;
         T000T6_A231BR_MedicalImaging_ImageAge = new short[1] ;
         T000T6_n231BR_MedicalImaging_ImageAge = new bool[] {false} ;
         T000T6_A232BR_MedicalImaging_ImageLoc = new String[] {""} ;
         T000T6_n232BR_MedicalImaging_ImageLoc = new bool[] {false} ;
         T000T6_A486BR_MedicalImaging_ImageLoc_Code = new String[] {""} ;
         T000T6_n486BR_MedicalImaging_ImageLoc_Code = new bool[] {false} ;
         T000T6_A233BR_MedicalImaging_ImageOrgan = new String[] {""} ;
         T000T6_n233BR_MedicalImaging_ImageOrgan = new bool[] {false} ;
         T000T6_A234BR_MedicalImaging_PreImageDiag = new String[] {""} ;
         T000T6_n234BR_MedicalImaging_PreImageDiag = new bool[] {false} ;
         T000T6_A235BR_MedicalImaging_ImageDes = new String[] {""} ;
         T000T6_n235BR_MedicalImaging_ImageDes = new bool[] {false} ;
         T000T6_A236BR_MedicalImaging_TumorSize = new String[] {""} ;
         T000T6_n236BR_MedicalImaging_TumorSize = new bool[] {false} ;
         T000T6_A334BR_MedicalImaging_ImageHtml = new String[] {""} ;
         T000T6_n334BR_MedicalImaging_ImageHtml = new bool[] {false} ;
         T000T6_A514BR_MedicalImaging_MetastasesDX = new String[] {""} ;
         T000T6_n514BR_MedicalImaging_MetastasesDX = new bool[] {false} ;
         T000T6_A515BR_MedicalImaging_MetaLoc = new String[] {""} ;
         T000T6_n515BR_MedicalImaging_MetaLoc = new bool[] {false} ;
         T000T6_A516BR_MedicalImaging_MetaDate = new DateTime[] {DateTime.MinValue} ;
         T000T6_n516BR_MedicalImaging_MetaDate = new bool[] {false} ;
         T000T6_A19BR_EncounterID = new long[1] ;
         T000T6_n19BR_EncounterID = new bool[] {false} ;
         T000T7_A85BR_Information_ID = new long[1] ;
         T000T7_n85BR_Information_ID = new bool[] {false} ;
         T000T8_A36BR_Information_PatientNo = new String[] {""} ;
         T000T8_n36BR_Information_PatientNo = new bool[] {false} ;
         T000T9_A225BR_MedicalImagingID = new long[1] ;
         T000T9_n225BR_MedicalImagingID = new bool[] {false} ;
         T000T3_A225BR_MedicalImagingID = new long[1] ;
         T000T3_n225BR_MedicalImagingID = new bool[] {false} ;
         T000T3_A484BR_MedicalImaging_ImageName_Code = new String[] {""} ;
         T000T3_n484BR_MedicalImaging_ImageName_Code = new bool[] {false} ;
         T000T3_A485BR_MedicalImaging_ImageHosp_Code = new String[] {""} ;
         T000T3_n485BR_MedicalImaging_ImageHosp_Code = new bool[] {false} ;
         T000T3_A227BR_MedicalImaging_ID = new long[1] ;
         T000T3_n227BR_MedicalImaging_ID = new bool[] {false} ;
         T000T3_A518BR_MedicalImaging_No = new long[1] ;
         T000T3_n518BR_MedicalImaging_No = new bool[] {false} ;
         T000T3_A228BR_MedicalImaging_ImageName = new String[] {""} ;
         T000T3_n228BR_MedicalImaging_ImageName = new bool[] {false} ;
         T000T3_A229BR_MedicalImaging_ImageDate = new DateTime[] {DateTime.MinValue} ;
         T000T3_n229BR_MedicalImaging_ImageDate = new bool[] {false} ;
         T000T3_A230BR_MedicalImaging_ImageHosp = new String[] {""} ;
         T000T3_n230BR_MedicalImaging_ImageHosp = new bool[] {false} ;
         T000T3_A231BR_MedicalImaging_ImageAge = new short[1] ;
         T000T3_n231BR_MedicalImaging_ImageAge = new bool[] {false} ;
         T000T3_A232BR_MedicalImaging_ImageLoc = new String[] {""} ;
         T000T3_n232BR_MedicalImaging_ImageLoc = new bool[] {false} ;
         T000T3_A486BR_MedicalImaging_ImageLoc_Code = new String[] {""} ;
         T000T3_n486BR_MedicalImaging_ImageLoc_Code = new bool[] {false} ;
         T000T3_A233BR_MedicalImaging_ImageOrgan = new String[] {""} ;
         T000T3_n233BR_MedicalImaging_ImageOrgan = new bool[] {false} ;
         T000T3_A234BR_MedicalImaging_PreImageDiag = new String[] {""} ;
         T000T3_n234BR_MedicalImaging_PreImageDiag = new bool[] {false} ;
         T000T3_A235BR_MedicalImaging_ImageDes = new String[] {""} ;
         T000T3_n235BR_MedicalImaging_ImageDes = new bool[] {false} ;
         T000T3_A236BR_MedicalImaging_TumorSize = new String[] {""} ;
         T000T3_n236BR_MedicalImaging_TumorSize = new bool[] {false} ;
         T000T3_A334BR_MedicalImaging_ImageHtml = new String[] {""} ;
         T000T3_n334BR_MedicalImaging_ImageHtml = new bool[] {false} ;
         T000T3_A514BR_MedicalImaging_MetastasesDX = new String[] {""} ;
         T000T3_n514BR_MedicalImaging_MetastasesDX = new bool[] {false} ;
         T000T3_A515BR_MedicalImaging_MetaLoc = new String[] {""} ;
         T000T3_n515BR_MedicalImaging_MetaLoc = new bool[] {false} ;
         T000T3_A516BR_MedicalImaging_MetaDate = new DateTime[] {DateTime.MinValue} ;
         T000T3_n516BR_MedicalImaging_MetaDate = new bool[] {false} ;
         T000T3_A19BR_EncounterID = new long[1] ;
         T000T3_n19BR_EncounterID = new bool[] {false} ;
         T000T10_A225BR_MedicalImagingID = new long[1] ;
         T000T10_n225BR_MedicalImagingID = new bool[] {false} ;
         T000T11_A225BR_MedicalImagingID = new long[1] ;
         T000T11_n225BR_MedicalImagingID = new bool[] {false} ;
         T000T2_A225BR_MedicalImagingID = new long[1] ;
         T000T2_n225BR_MedicalImagingID = new bool[] {false} ;
         T000T2_A484BR_MedicalImaging_ImageName_Code = new String[] {""} ;
         T000T2_n484BR_MedicalImaging_ImageName_Code = new bool[] {false} ;
         T000T2_A485BR_MedicalImaging_ImageHosp_Code = new String[] {""} ;
         T000T2_n485BR_MedicalImaging_ImageHosp_Code = new bool[] {false} ;
         T000T2_A227BR_MedicalImaging_ID = new long[1] ;
         T000T2_n227BR_MedicalImaging_ID = new bool[] {false} ;
         T000T2_A518BR_MedicalImaging_No = new long[1] ;
         T000T2_n518BR_MedicalImaging_No = new bool[] {false} ;
         T000T2_A228BR_MedicalImaging_ImageName = new String[] {""} ;
         T000T2_n228BR_MedicalImaging_ImageName = new bool[] {false} ;
         T000T2_A229BR_MedicalImaging_ImageDate = new DateTime[] {DateTime.MinValue} ;
         T000T2_n229BR_MedicalImaging_ImageDate = new bool[] {false} ;
         T000T2_A230BR_MedicalImaging_ImageHosp = new String[] {""} ;
         T000T2_n230BR_MedicalImaging_ImageHosp = new bool[] {false} ;
         T000T2_A231BR_MedicalImaging_ImageAge = new short[1] ;
         T000T2_n231BR_MedicalImaging_ImageAge = new bool[] {false} ;
         T000T2_A232BR_MedicalImaging_ImageLoc = new String[] {""} ;
         T000T2_n232BR_MedicalImaging_ImageLoc = new bool[] {false} ;
         T000T2_A486BR_MedicalImaging_ImageLoc_Code = new String[] {""} ;
         T000T2_n486BR_MedicalImaging_ImageLoc_Code = new bool[] {false} ;
         T000T2_A233BR_MedicalImaging_ImageOrgan = new String[] {""} ;
         T000T2_n233BR_MedicalImaging_ImageOrgan = new bool[] {false} ;
         T000T2_A234BR_MedicalImaging_PreImageDiag = new String[] {""} ;
         T000T2_n234BR_MedicalImaging_PreImageDiag = new bool[] {false} ;
         T000T2_A235BR_MedicalImaging_ImageDes = new String[] {""} ;
         T000T2_n235BR_MedicalImaging_ImageDes = new bool[] {false} ;
         T000T2_A236BR_MedicalImaging_TumorSize = new String[] {""} ;
         T000T2_n236BR_MedicalImaging_TumorSize = new bool[] {false} ;
         T000T2_A334BR_MedicalImaging_ImageHtml = new String[] {""} ;
         T000T2_n334BR_MedicalImaging_ImageHtml = new bool[] {false} ;
         T000T2_A514BR_MedicalImaging_MetastasesDX = new String[] {""} ;
         T000T2_n514BR_MedicalImaging_MetastasesDX = new bool[] {false} ;
         T000T2_A515BR_MedicalImaging_MetaLoc = new String[] {""} ;
         T000T2_n515BR_MedicalImaging_MetaLoc = new bool[] {false} ;
         T000T2_A516BR_MedicalImaging_MetaDate = new DateTime[] {DateTime.MinValue} ;
         T000T2_n516BR_MedicalImaging_MetaDate = new bool[] {false} ;
         T000T2_A19BR_EncounterID = new long[1] ;
         T000T2_n19BR_EncounterID = new bool[] {false} ;
         T000T12_A225BR_MedicalImagingID = new long[1] ;
         T000T12_n225BR_MedicalImagingID = new bool[] {false} ;
         T000T15_A85BR_Information_ID = new long[1] ;
         T000T15_n85BR_Information_ID = new bool[] {false} ;
         T000T16_A36BR_Information_PatientNo = new String[] {""} ;
         T000T16_n36BR_Information_PatientNo = new bool[] {false} ;
         T000T17_A270BR_MedicalImaging_DiagID = new long[1] ;
         T000T18_A225BR_MedicalImagingID = new long[1] ;
         T000T18_n225BR_MedicalImagingID = new bool[] {false} ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         gxdynajaxctrlcodr = new GeneXus.Utils.GxStringCollection();
         gxdynajaxctrldescr = new GeneXus.Utils.GxStringCollection();
         gxwrpcisep = "";
         T000T19_A167XT_DefineCodeID = new long[1] ;
         T000T19_A168XT_DefineCodeName = new String[] {""} ;
         T000T19_n168XT_DefineCodeName = new bool[] {false} ;
         T000T19_A165XT_DefindcodeTypeID = new long[1] ;
         T000T19_A432XT_TenantCode = new String[] {""} ;
         T000T19_n432XT_TenantCode = new bool[] {false} ;
         T000T20_A167XT_DefineCodeID = new long[1] ;
         T000T20_A168XT_DefineCodeName = new String[] {""} ;
         T000T20_n168XT_DefineCodeName = new bool[] {false} ;
         T000T20_A165XT_DefindcodeTypeID = new long[1] ;
         T000T20_A432XT_TenantCode = new String[] {""} ;
         T000T20_n432XT_TenantCode = new bool[] {false} ;
         T000T21_A167XT_DefineCodeID = new long[1] ;
         T000T21_A168XT_DefineCodeName = new String[] {""} ;
         T000T21_n168XT_DefineCodeName = new bool[] {false} ;
         T000T21_A165XT_DefindcodeTypeID = new long[1] ;
         T000T21_A432XT_TenantCode = new String[] {""} ;
         T000T21_n432XT_TenantCode = new bool[] {false} ;
         GXt_char1 = "";
         T000T22_A85BR_Information_ID = new long[1] ;
         T000T22_n85BR_Information_ID = new bool[] {false} ;
         T000T23_A36BR_Information_PatientNo = new String[] {""} ;
         T000T23_n36BR_Information_PatientNo = new bool[] {false} ;
         isValidOutput = new GxUnknownObjectCollection();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.br_medicalimaging__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_medicalimaging__default(),
            new Object[][] {
                new Object[] {
               T000T2_A225BR_MedicalImagingID, T000T2_A484BR_MedicalImaging_ImageName_Code, T000T2_n484BR_MedicalImaging_ImageName_Code, T000T2_A485BR_MedicalImaging_ImageHosp_Code, T000T2_n485BR_MedicalImaging_ImageHosp_Code, T000T2_A227BR_MedicalImaging_ID, T000T2_n227BR_MedicalImaging_ID, T000T2_A518BR_MedicalImaging_No, T000T2_n518BR_MedicalImaging_No, T000T2_A228BR_MedicalImaging_ImageName,
               T000T2_n228BR_MedicalImaging_ImageName, T000T2_A229BR_MedicalImaging_ImageDate, T000T2_n229BR_MedicalImaging_ImageDate, T000T2_A230BR_MedicalImaging_ImageHosp, T000T2_n230BR_MedicalImaging_ImageHosp, T000T2_A231BR_MedicalImaging_ImageAge, T000T2_n231BR_MedicalImaging_ImageAge, T000T2_A232BR_MedicalImaging_ImageLoc, T000T2_n232BR_MedicalImaging_ImageLoc, T000T2_A486BR_MedicalImaging_ImageLoc_Code,
               T000T2_n486BR_MedicalImaging_ImageLoc_Code, T000T2_A233BR_MedicalImaging_ImageOrgan, T000T2_n233BR_MedicalImaging_ImageOrgan, T000T2_A234BR_MedicalImaging_PreImageDiag, T000T2_n234BR_MedicalImaging_PreImageDiag, T000T2_A235BR_MedicalImaging_ImageDes, T000T2_n235BR_MedicalImaging_ImageDes, T000T2_A236BR_MedicalImaging_TumorSize, T000T2_n236BR_MedicalImaging_TumorSize, T000T2_A334BR_MedicalImaging_ImageHtml,
               T000T2_n334BR_MedicalImaging_ImageHtml, T000T2_A514BR_MedicalImaging_MetastasesDX, T000T2_n514BR_MedicalImaging_MetastasesDX, T000T2_A515BR_MedicalImaging_MetaLoc, T000T2_n515BR_MedicalImaging_MetaLoc, T000T2_A516BR_MedicalImaging_MetaDate, T000T2_n516BR_MedicalImaging_MetaDate, T000T2_A19BR_EncounterID, T000T2_n19BR_EncounterID
               }
               , new Object[] {
               T000T3_A225BR_MedicalImagingID, T000T3_A484BR_MedicalImaging_ImageName_Code, T000T3_n484BR_MedicalImaging_ImageName_Code, T000T3_A485BR_MedicalImaging_ImageHosp_Code, T000T3_n485BR_MedicalImaging_ImageHosp_Code, T000T3_A227BR_MedicalImaging_ID, T000T3_n227BR_MedicalImaging_ID, T000T3_A518BR_MedicalImaging_No, T000T3_n518BR_MedicalImaging_No, T000T3_A228BR_MedicalImaging_ImageName,
               T000T3_n228BR_MedicalImaging_ImageName, T000T3_A229BR_MedicalImaging_ImageDate, T000T3_n229BR_MedicalImaging_ImageDate, T000T3_A230BR_MedicalImaging_ImageHosp, T000T3_n230BR_MedicalImaging_ImageHosp, T000T3_A231BR_MedicalImaging_ImageAge, T000T3_n231BR_MedicalImaging_ImageAge, T000T3_A232BR_MedicalImaging_ImageLoc, T000T3_n232BR_MedicalImaging_ImageLoc, T000T3_A486BR_MedicalImaging_ImageLoc_Code,
               T000T3_n486BR_MedicalImaging_ImageLoc_Code, T000T3_A233BR_MedicalImaging_ImageOrgan, T000T3_n233BR_MedicalImaging_ImageOrgan, T000T3_A234BR_MedicalImaging_PreImageDiag, T000T3_n234BR_MedicalImaging_PreImageDiag, T000T3_A235BR_MedicalImaging_ImageDes, T000T3_n235BR_MedicalImaging_ImageDes, T000T3_A236BR_MedicalImaging_TumorSize, T000T3_n236BR_MedicalImaging_TumorSize, T000T3_A334BR_MedicalImaging_ImageHtml,
               T000T3_n334BR_MedicalImaging_ImageHtml, T000T3_A514BR_MedicalImaging_MetastasesDX, T000T3_n514BR_MedicalImaging_MetastasesDX, T000T3_A515BR_MedicalImaging_MetaLoc, T000T3_n515BR_MedicalImaging_MetaLoc, T000T3_A516BR_MedicalImaging_MetaDate, T000T3_n516BR_MedicalImaging_MetaDate, T000T3_A19BR_EncounterID, T000T3_n19BR_EncounterID
               }
               , new Object[] {
               T000T4_A85BR_Information_ID, T000T4_n85BR_Information_ID
               }
               , new Object[] {
               T000T5_A36BR_Information_PatientNo, T000T5_n36BR_Information_PatientNo
               }
               , new Object[] {
               T000T6_A85BR_Information_ID, T000T6_n85BR_Information_ID, T000T6_A225BR_MedicalImagingID, T000T6_A484BR_MedicalImaging_ImageName_Code, T000T6_n484BR_MedicalImaging_ImageName_Code, T000T6_A485BR_MedicalImaging_ImageHosp_Code, T000T6_n485BR_MedicalImaging_ImageHosp_Code, T000T6_A36BR_Information_PatientNo, T000T6_n36BR_Information_PatientNo, T000T6_A227BR_MedicalImaging_ID,
               T000T6_n227BR_MedicalImaging_ID, T000T6_A518BR_MedicalImaging_No, T000T6_n518BR_MedicalImaging_No, T000T6_A228BR_MedicalImaging_ImageName, T000T6_n228BR_MedicalImaging_ImageName, T000T6_A229BR_MedicalImaging_ImageDate, T000T6_n229BR_MedicalImaging_ImageDate, T000T6_A230BR_MedicalImaging_ImageHosp, T000T6_n230BR_MedicalImaging_ImageHosp, T000T6_A231BR_MedicalImaging_ImageAge,
               T000T6_n231BR_MedicalImaging_ImageAge, T000T6_A232BR_MedicalImaging_ImageLoc, T000T6_n232BR_MedicalImaging_ImageLoc, T000T6_A486BR_MedicalImaging_ImageLoc_Code, T000T6_n486BR_MedicalImaging_ImageLoc_Code, T000T6_A233BR_MedicalImaging_ImageOrgan, T000T6_n233BR_MedicalImaging_ImageOrgan, T000T6_A234BR_MedicalImaging_PreImageDiag, T000T6_n234BR_MedicalImaging_PreImageDiag, T000T6_A235BR_MedicalImaging_ImageDes,
               T000T6_n235BR_MedicalImaging_ImageDes, T000T6_A236BR_MedicalImaging_TumorSize, T000T6_n236BR_MedicalImaging_TumorSize, T000T6_A334BR_MedicalImaging_ImageHtml, T000T6_n334BR_MedicalImaging_ImageHtml, T000T6_A514BR_MedicalImaging_MetastasesDX, T000T6_n514BR_MedicalImaging_MetastasesDX, T000T6_A515BR_MedicalImaging_MetaLoc, T000T6_n515BR_MedicalImaging_MetaLoc, T000T6_A516BR_MedicalImaging_MetaDate,
               T000T6_n516BR_MedicalImaging_MetaDate, T000T6_A19BR_EncounterID, T000T6_n19BR_EncounterID
               }
               , new Object[] {
               T000T7_A85BR_Information_ID, T000T7_n85BR_Information_ID
               }
               , new Object[] {
               T000T8_A36BR_Information_PatientNo, T000T8_n36BR_Information_PatientNo
               }
               , new Object[] {
               T000T9_A225BR_MedicalImagingID
               }
               , new Object[] {
               T000T10_A225BR_MedicalImagingID
               }
               , new Object[] {
               T000T11_A225BR_MedicalImagingID
               }
               , new Object[] {
               T000T12_A225BR_MedicalImagingID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000T15_A85BR_Information_ID, T000T15_n85BR_Information_ID
               }
               , new Object[] {
               T000T16_A36BR_Information_PatientNo, T000T16_n36BR_Information_PatientNo
               }
               , new Object[] {
               T000T17_A270BR_MedicalImaging_DiagID
               }
               , new Object[] {
               T000T18_A225BR_MedicalImagingID
               }
               , new Object[] {
               T000T19_A167XT_DefineCodeID, T000T19_A168XT_DefineCodeName, T000T19_n168XT_DefineCodeName, T000T19_A165XT_DefindcodeTypeID, T000T19_A432XT_TenantCode, T000T19_n432XT_TenantCode
               }
               , new Object[] {
               T000T20_A167XT_DefineCodeID, T000T20_A168XT_DefineCodeName, T000T20_n168XT_DefineCodeName, T000T20_A165XT_DefindcodeTypeID, T000T20_A432XT_TenantCode, T000T20_n432XT_TenantCode
               }
               , new Object[] {
               T000T21_A167XT_DefineCodeID, T000T21_A168XT_DefineCodeName, T000T21_n168XT_DefineCodeName, T000T21_A165XT_DefindcodeTypeID, T000T21_A432XT_TenantCode, T000T21_n432XT_TenantCode
               }
               , new Object[] {
               T000T22_A85BR_Information_ID, T000T22_n85BR_Information_ID
               }
               , new Object[] {
               T000T23_A36BR_Information_PatientNo, T000T23_n36BR_Information_PatientNo
               }
            }
         );
         AV19Pgmname = "BR_MedicalImaging";
      }

      private short Z231BR_MedicalImaging_ImageAge ;
      private short GxWebError ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A231BR_MedicalImaging_ImageAge ;
      private short RcdFound30 ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int trnEnded ;
      private int edtBR_MedicalImaging_No_Enabled ;
      private int edtBR_MedicalImaging_ImageAge_Enabled ;
      private int edtBR_MedicalImaging_ImageDate_Enabled ;
      private int edtBR_MedicalImaging_TumorSize_Enabled ;
      private int edtBR_MedicalImaging_PreImageDiag_Enabled ;
      private int edtBR_MedicalImaging_ImageOrgan_Enabled ;
      private int edtBR_MedicalImaging_ImageDes_Enabled ;
      private int edtBR_MedicalImaging_MetaLoc_Visible ;
      private int edtBR_MedicalImaging_MetaLoc_Enabled ;
      private int edtBR_MedicalImaging_MetaDate_Visible ;
      private int edtBR_MedicalImaging_MetaDate_Enabled ;
      private int bttBtntrn_enter_Visible ;
      private int bttBtntrn_enter_Enabled ;
      private int bttBtntrn_cancel_Visible ;
      private int bttBtntrn_delete_Visible ;
      private int bttBtntrn_delete_Enabled ;
      private int edtBR_MedicalImagingID_Enabled ;
      private int edtBR_MedicalImagingID_Visible ;
      private int edtBR_EncounterID_Visible ;
      private int edtBR_EncounterID_Enabled ;
      private int edtBR_Information_PatientNo_Visible ;
      private int edtBR_Information_PatientNo_Enabled ;
      private int edtBR_MedicalImaging_ID_Enabled ;
      private int edtBR_MedicalImaging_ID_Visible ;
      private int edtavWxname_Visible ;
      private int edtavWxname_Enabled ;
      private int edtavVname_Visible ;
      private int edtavVname_Enabled ;
      private int AV20GXV1 ;
      private int idxLst ;
      private int gxdynajaxindex ;
      private long wcpOAV7BR_MedicalImagingID ;
      private long Z225BR_MedicalImagingID ;
      private long Z227BR_MedicalImaging_ID ;
      private long Z518BR_MedicalImaging_No ;
      private long Z19BR_EncounterID ;
      private long N19BR_EncounterID ;
      private long A19BR_EncounterID ;
      private long A85BR_Information_ID ;
      private long AV7BR_MedicalImagingID ;
      private long A518BR_MedicalImaging_No ;
      private long A225BR_MedicalImagingID ;
      private long A227BR_MedicalImaging_ID ;
      private long AV13Insert_BR_EncounterID ;
      private long Z85BR_Information_ID ;
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
      private String edtBR_MedicalImaging_No_Internalname ;
      private String dynBR_MedicalImaging_ImageName_Internalname ;
      private String dynBR_MedicalImaging_ImageHosp_Internalname ;
      private String dynBR_MedicalImaging_ImageLoc_Internalname ;
      private String cmbBR_MedicalImaging_MetastasesDX_Internalname ;
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
      private String divUnnamedtablebr_medicalimaging_no_Internalname ;
      private String lblTextblockbr_medicalimaging_no_Internalname ;
      private String lblTextblockbr_medicalimaging_no_Jsonclick ;
      private String TempTags ;
      private String edtBR_MedicalImaging_No_Jsonclick ;
      private String divTablesplittedbr_medicalimaging_imagename_Internalname ;
      private String lblTextblockbr_medicalimaging_imagename_Internalname ;
      private String lblTextblockbr_medicalimaging_imagename_Jsonclick ;
      private String divUnnamedtablebr_medicalimaging_imageage_Internalname ;
      private String lblTextblockbr_medicalimaging_imageage_Internalname ;
      private String lblTextblockbr_medicalimaging_imageage_Jsonclick ;
      private String edtBR_MedicalImaging_ImageAge_Internalname ;
      private String edtBR_MedicalImaging_ImageAge_Jsonclick ;
      private String divUnnamedtablebr_medicalimaging_imagedate_Internalname ;
      private String lblTextblockbr_medicalimaging_imagedate_Internalname ;
      private String lblTextblockbr_medicalimaging_imagedate_Jsonclick ;
      private String edtBR_MedicalImaging_ImageDate_Internalname ;
      private String edtBR_MedicalImaging_ImageDate_Jsonclick ;
      private String divUnnamedtablebr_medicalimaging_imagehosp_Internalname ;
      private String lblTextblockbr_medicalimaging_imagehosp_Internalname ;
      private String lblTextblockbr_medicalimaging_imagehosp_Jsonclick ;
      private String dynBR_MedicalImaging_ImageHosp_Jsonclick ;
      private String divUnnamedtablebr_medicalimaging_tumorsize_Internalname ;
      private String lblTextblockbr_medicalimaging_tumorsize_Internalname ;
      private String lblTextblockbr_medicalimaging_tumorsize_Jsonclick ;
      private String edtBR_MedicalImaging_TumorSize_Internalname ;
      private String edtBR_MedicalImaging_TumorSize_Jsonclick ;
      private String divUnnamedtablebr_medicalimaging_preimagediag_Internalname ;
      private String lblTextblockbr_medicalimaging_preimagediag_Internalname ;
      private String lblTextblockbr_medicalimaging_preimagediag_Jsonclick ;
      private String edtBR_MedicalImaging_PreImageDiag_Internalname ;
      private String divTablesplittedbr_medicalimaging_imageloc_Internalname ;
      private String lblTextblockbr_medicalimaging_imageloc_Internalname ;
      private String lblTextblockbr_medicalimaging_imageloc_Jsonclick ;
      private String divUnnamedtablebr_medicalimaging_imageorgan_Internalname ;
      private String lblTextblockbr_medicalimaging_imageorgan_Internalname ;
      private String lblTextblockbr_medicalimaging_imageorgan_Jsonclick ;
      private String edtBR_MedicalImaging_ImageOrgan_Internalname ;
      private String divUnnamedtablebr_medicalimaging_imagedes_Internalname ;
      private String lblTextblockbr_medicalimaging_imagedes_Internalname ;
      private String lblTextblockbr_medicalimaging_imagedes_Jsonclick ;
      private String edtBR_MedicalImaging_ImageDes_Internalname ;
      private String divUnnamedtablebr_medicalimaging_metastasesdx_Internalname ;
      private String lblTextblockbr_medicalimaging_metastasesdx_Internalname ;
      private String lblTextblockbr_medicalimaging_metastasesdx_Jsonclick ;
      private String cmbBR_MedicalImaging_MetastasesDX_Jsonclick ;
      private String divBr_medicalimaging_metaloc_cell_Internalname ;
      private String divBr_medicalimaging_metaloc_cell_Class ;
      private String divUnnamedtablebr_medicalimaging_metaloc_Internalname ;
      private String lblTextblockbr_medicalimaging_metaloc_Internalname ;
      private String lblTextblockbr_medicalimaging_metaloc_Jsonclick ;
      private String edtBR_MedicalImaging_MetaLoc_Internalname ;
      private String edtBR_MedicalImaging_MetaLoc_Jsonclick ;
      private String divBr_medicalimaging_metadate_cell_Internalname ;
      private String divBr_medicalimaging_metadate_cell_Class ;
      private String divUnnamedtablebr_medicalimaging_metadate_Internalname ;
      private String lblTextblockbr_medicalimaging_metadate_Internalname ;
      private String lblTextblockbr_medicalimaging_metadate_Jsonclick ;
      private String edtBR_MedicalImaging_MetaDate_Internalname ;
      private String edtBR_MedicalImaging_MetaDate_Jsonclick ;
      private String bttBtntrn_enter_Internalname ;
      private String bttBtntrn_enter_Jsonclick ;
      private String bttBtntrn_cancel_Internalname ;
      private String bttBtntrn_cancel_Jsonclick ;
      private String bttBtntrn_delete_Internalname ;
      private String bttBtntrn_delete_Jsonclick ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String edtBR_MedicalImagingID_Internalname ;
      private String edtBR_MedicalImagingID_Jsonclick ;
      private String edtBR_EncounterID_Internalname ;
      private String edtBR_EncounterID_Jsonclick ;
      private String edtBR_Information_PatientNo_Internalname ;
      private String edtBR_Information_PatientNo_Jsonclick ;
      private String edtBR_MedicalImaging_ID_Internalname ;
      private String edtBR_MedicalImaging_ID_Jsonclick ;
      private String sStyleString ;
      private String tblTablemergedbr_medicalimaging_imageloc_Internalname ;
      private String dynBR_MedicalImaging_ImageLoc_Jsonclick ;
      private String cellWxname_cell_Internalname ;
      private String cellWxname_cell_Class ;
      private String edtavWxname_Internalname ;
      private String edtavWxname_Jsonclick ;
      private String tblTablemergedbr_medicalimaging_imagename_Internalname ;
      private String dynBR_MedicalImaging_ImageName_Jsonclick ;
      private String cellVname_cell_Internalname ;
      private String cellVname_cell_Class ;
      private String edtavVname_Internalname ;
      private String edtavVname_Jsonclick ;
      private String AV19Pgmname ;
      private String Dvpanel_tableattributes_Objectcall ;
      private String Dvpanel_tableattributes_Class ;
      private String Dvpanel_tableattributes_Height ;
      private String forbiddenHiddens ;
      private String hsh ;
      private String sMode30 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String gxwrpcisep ;
      private String GXt_char1 ;
      private DateTime Z229BR_MedicalImaging_ImageDate ;
      private DateTime Z516BR_MedicalImaging_MetaDate ;
      private DateTime A229BR_MedicalImaging_ImageDate ;
      private DateTime A516BR_MedicalImaging_MetaDate ;
      private bool entryPointCalled ;
      private bool n228BR_MedicalImaging_ImageName ;
      private bool n230BR_MedicalImaging_ImageHosp ;
      private bool n19BR_EncounterID ;
      private bool n85BR_Information_ID ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool n232BR_MedicalImaging_ImageLoc ;
      private bool n514BR_MedicalImaging_MetastasesDX ;
      private bool Dvpanel_tableattributes_Autowidth ;
      private bool Dvpanel_tableattributes_Autoheight ;
      private bool Dvpanel_tableattributes_Collapsible ;
      private bool Dvpanel_tableattributes_Collapsed ;
      private bool Dvpanel_tableattributes_Showcollapseicon ;
      private bool Dvpanel_tableattributes_Autoscroll ;
      private bool n518BR_MedicalImaging_No ;
      private bool n231BR_MedicalImaging_ImageAge ;
      private bool n229BR_MedicalImaging_ImageDate ;
      private bool n236BR_MedicalImaging_TumorSize ;
      private bool n234BR_MedicalImaging_PreImageDiag ;
      private bool n233BR_MedicalImaging_ImageOrgan ;
      private bool n235BR_MedicalImaging_ImageDes ;
      private bool n515BR_MedicalImaging_MetaLoc ;
      private bool n516BR_MedicalImaging_MetaDate ;
      private bool n225BR_MedicalImagingID ;
      private bool n36BR_Information_PatientNo ;
      private bool n227BR_MedicalImaging_ID ;
      private bool n484BR_MedicalImaging_ImageName_Code ;
      private bool n485BR_MedicalImaging_ImageHosp_Code ;
      private bool n486BR_MedicalImaging_ImageLoc_Code ;
      private bool n334BR_MedicalImaging_ImageHtml ;
      private bool Dvpanel_tableattributes_Enabled ;
      private bool Dvpanel_tableattributes_Showheader ;
      private bool Dvpanel_tableattributes_Visible ;
      private bool AV9IsAuthorized ;
      private bool returnInSub ;
      private bool AV17TempBoolean ;
      private bool GXt_boolean2 ;
      private bool Gx_longc ;
      private bool gxdyncontrolsrefreshing ;
      private String A334BR_MedicalImaging_ImageHtml ;
      private String Z334BR_MedicalImaging_ImageHtml ;
      private String Z484BR_MedicalImaging_ImageName_Code ;
      private String Z485BR_MedicalImaging_ImageHosp_Code ;
      private String Z228BR_MedicalImaging_ImageName ;
      private String Z230BR_MedicalImaging_ImageHosp ;
      private String Z232BR_MedicalImaging_ImageLoc ;
      private String Z486BR_MedicalImaging_ImageLoc_Code ;
      private String Z233BR_MedicalImaging_ImageOrgan ;
      private String Z234BR_MedicalImaging_PreImageDiag ;
      private String Z235BR_MedicalImaging_ImageDes ;
      private String Z236BR_MedicalImaging_TumorSize ;
      private String Z514BR_MedicalImaging_MetastasesDX ;
      private String Z515BR_MedicalImaging_MetaLoc ;
      private String AV18tCurrentCode ;
      private String A228BR_MedicalImaging_ImageName ;
      private String A230BR_MedicalImaging_ImageHosp ;
      private String A232BR_MedicalImaging_ImageLoc ;
      private String A514BR_MedicalImaging_MetastasesDX ;
      private String A236BR_MedicalImaging_TumorSize ;
      private String A234BR_MedicalImaging_PreImageDiag ;
      private String A233BR_MedicalImaging_ImageOrgan ;
      private String A235BR_MedicalImaging_ImageDes ;
      private String A515BR_MedicalImaging_MetaLoc ;
      private String A36BR_Information_PatientNo ;
      private String AV16wxname ;
      private String AV15vName ;
      private String A484BR_MedicalImaging_ImageName_Code ;
      private String A485BR_MedicalImaging_ImageHosp_Code ;
      private String A486BR_MedicalImaging_ImageLoc_Code ;
      private String Z36BR_Information_PatientNo ;
      private IGxSession AV12WebSession ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrlcodr ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrldescr ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXUserControl ucDvpanel_tableattributes ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private GXCombobox dynBR_MedicalImaging_ImageName ;
      private GXCombobox dynBR_MedicalImaging_ImageHosp ;
      private GXCombobox dynBR_MedicalImaging_ImageLoc ;
      private GXCombobox cmbBR_MedicalImaging_MetastasesDX ;
      private IDataStoreProvider pr_default ;
      private long[] T000T4_A85BR_Information_ID ;
      private bool[] T000T4_n85BR_Information_ID ;
      private String[] T000T5_A36BR_Information_PatientNo ;
      private bool[] T000T5_n36BR_Information_PatientNo ;
      private long[] T000T6_A85BR_Information_ID ;
      private bool[] T000T6_n85BR_Information_ID ;
      private long[] T000T6_A225BR_MedicalImagingID ;
      private bool[] T000T6_n225BR_MedicalImagingID ;
      private String[] T000T6_A484BR_MedicalImaging_ImageName_Code ;
      private bool[] T000T6_n484BR_MedicalImaging_ImageName_Code ;
      private String[] T000T6_A485BR_MedicalImaging_ImageHosp_Code ;
      private bool[] T000T6_n485BR_MedicalImaging_ImageHosp_Code ;
      private String[] T000T6_A36BR_Information_PatientNo ;
      private bool[] T000T6_n36BR_Information_PatientNo ;
      private long[] T000T6_A227BR_MedicalImaging_ID ;
      private bool[] T000T6_n227BR_MedicalImaging_ID ;
      private long[] T000T6_A518BR_MedicalImaging_No ;
      private bool[] T000T6_n518BR_MedicalImaging_No ;
      private String[] T000T6_A228BR_MedicalImaging_ImageName ;
      private bool[] T000T6_n228BR_MedicalImaging_ImageName ;
      private DateTime[] T000T6_A229BR_MedicalImaging_ImageDate ;
      private bool[] T000T6_n229BR_MedicalImaging_ImageDate ;
      private String[] T000T6_A230BR_MedicalImaging_ImageHosp ;
      private bool[] T000T6_n230BR_MedicalImaging_ImageHosp ;
      private short[] T000T6_A231BR_MedicalImaging_ImageAge ;
      private bool[] T000T6_n231BR_MedicalImaging_ImageAge ;
      private String[] T000T6_A232BR_MedicalImaging_ImageLoc ;
      private bool[] T000T6_n232BR_MedicalImaging_ImageLoc ;
      private String[] T000T6_A486BR_MedicalImaging_ImageLoc_Code ;
      private bool[] T000T6_n486BR_MedicalImaging_ImageLoc_Code ;
      private String[] T000T6_A233BR_MedicalImaging_ImageOrgan ;
      private bool[] T000T6_n233BR_MedicalImaging_ImageOrgan ;
      private String[] T000T6_A234BR_MedicalImaging_PreImageDiag ;
      private bool[] T000T6_n234BR_MedicalImaging_PreImageDiag ;
      private String[] T000T6_A235BR_MedicalImaging_ImageDes ;
      private bool[] T000T6_n235BR_MedicalImaging_ImageDes ;
      private String[] T000T6_A236BR_MedicalImaging_TumorSize ;
      private bool[] T000T6_n236BR_MedicalImaging_TumorSize ;
      private String[] T000T6_A334BR_MedicalImaging_ImageHtml ;
      private bool[] T000T6_n334BR_MedicalImaging_ImageHtml ;
      private String[] T000T6_A514BR_MedicalImaging_MetastasesDX ;
      private bool[] T000T6_n514BR_MedicalImaging_MetastasesDX ;
      private String[] T000T6_A515BR_MedicalImaging_MetaLoc ;
      private bool[] T000T6_n515BR_MedicalImaging_MetaLoc ;
      private DateTime[] T000T6_A516BR_MedicalImaging_MetaDate ;
      private bool[] T000T6_n516BR_MedicalImaging_MetaDate ;
      private long[] T000T6_A19BR_EncounterID ;
      private bool[] T000T6_n19BR_EncounterID ;
      private long[] T000T7_A85BR_Information_ID ;
      private bool[] T000T7_n85BR_Information_ID ;
      private String[] T000T8_A36BR_Information_PatientNo ;
      private bool[] T000T8_n36BR_Information_PatientNo ;
      private long[] T000T9_A225BR_MedicalImagingID ;
      private bool[] T000T9_n225BR_MedicalImagingID ;
      private long[] T000T3_A225BR_MedicalImagingID ;
      private bool[] T000T3_n225BR_MedicalImagingID ;
      private String[] T000T3_A484BR_MedicalImaging_ImageName_Code ;
      private bool[] T000T3_n484BR_MedicalImaging_ImageName_Code ;
      private String[] T000T3_A485BR_MedicalImaging_ImageHosp_Code ;
      private bool[] T000T3_n485BR_MedicalImaging_ImageHosp_Code ;
      private long[] T000T3_A227BR_MedicalImaging_ID ;
      private bool[] T000T3_n227BR_MedicalImaging_ID ;
      private long[] T000T3_A518BR_MedicalImaging_No ;
      private bool[] T000T3_n518BR_MedicalImaging_No ;
      private String[] T000T3_A228BR_MedicalImaging_ImageName ;
      private bool[] T000T3_n228BR_MedicalImaging_ImageName ;
      private DateTime[] T000T3_A229BR_MedicalImaging_ImageDate ;
      private bool[] T000T3_n229BR_MedicalImaging_ImageDate ;
      private String[] T000T3_A230BR_MedicalImaging_ImageHosp ;
      private bool[] T000T3_n230BR_MedicalImaging_ImageHosp ;
      private short[] T000T3_A231BR_MedicalImaging_ImageAge ;
      private bool[] T000T3_n231BR_MedicalImaging_ImageAge ;
      private String[] T000T3_A232BR_MedicalImaging_ImageLoc ;
      private bool[] T000T3_n232BR_MedicalImaging_ImageLoc ;
      private String[] T000T3_A486BR_MedicalImaging_ImageLoc_Code ;
      private bool[] T000T3_n486BR_MedicalImaging_ImageLoc_Code ;
      private String[] T000T3_A233BR_MedicalImaging_ImageOrgan ;
      private bool[] T000T3_n233BR_MedicalImaging_ImageOrgan ;
      private String[] T000T3_A234BR_MedicalImaging_PreImageDiag ;
      private bool[] T000T3_n234BR_MedicalImaging_PreImageDiag ;
      private String[] T000T3_A235BR_MedicalImaging_ImageDes ;
      private bool[] T000T3_n235BR_MedicalImaging_ImageDes ;
      private String[] T000T3_A236BR_MedicalImaging_TumorSize ;
      private bool[] T000T3_n236BR_MedicalImaging_TumorSize ;
      private String[] T000T3_A334BR_MedicalImaging_ImageHtml ;
      private bool[] T000T3_n334BR_MedicalImaging_ImageHtml ;
      private String[] T000T3_A514BR_MedicalImaging_MetastasesDX ;
      private bool[] T000T3_n514BR_MedicalImaging_MetastasesDX ;
      private String[] T000T3_A515BR_MedicalImaging_MetaLoc ;
      private bool[] T000T3_n515BR_MedicalImaging_MetaLoc ;
      private DateTime[] T000T3_A516BR_MedicalImaging_MetaDate ;
      private bool[] T000T3_n516BR_MedicalImaging_MetaDate ;
      private long[] T000T3_A19BR_EncounterID ;
      private bool[] T000T3_n19BR_EncounterID ;
      private long[] T000T10_A225BR_MedicalImagingID ;
      private bool[] T000T10_n225BR_MedicalImagingID ;
      private long[] T000T11_A225BR_MedicalImagingID ;
      private bool[] T000T11_n225BR_MedicalImagingID ;
      private long[] T000T2_A225BR_MedicalImagingID ;
      private bool[] T000T2_n225BR_MedicalImagingID ;
      private String[] T000T2_A484BR_MedicalImaging_ImageName_Code ;
      private bool[] T000T2_n484BR_MedicalImaging_ImageName_Code ;
      private String[] T000T2_A485BR_MedicalImaging_ImageHosp_Code ;
      private bool[] T000T2_n485BR_MedicalImaging_ImageHosp_Code ;
      private long[] T000T2_A227BR_MedicalImaging_ID ;
      private bool[] T000T2_n227BR_MedicalImaging_ID ;
      private long[] T000T2_A518BR_MedicalImaging_No ;
      private bool[] T000T2_n518BR_MedicalImaging_No ;
      private String[] T000T2_A228BR_MedicalImaging_ImageName ;
      private bool[] T000T2_n228BR_MedicalImaging_ImageName ;
      private DateTime[] T000T2_A229BR_MedicalImaging_ImageDate ;
      private bool[] T000T2_n229BR_MedicalImaging_ImageDate ;
      private String[] T000T2_A230BR_MedicalImaging_ImageHosp ;
      private bool[] T000T2_n230BR_MedicalImaging_ImageHosp ;
      private short[] T000T2_A231BR_MedicalImaging_ImageAge ;
      private bool[] T000T2_n231BR_MedicalImaging_ImageAge ;
      private String[] T000T2_A232BR_MedicalImaging_ImageLoc ;
      private bool[] T000T2_n232BR_MedicalImaging_ImageLoc ;
      private String[] T000T2_A486BR_MedicalImaging_ImageLoc_Code ;
      private bool[] T000T2_n486BR_MedicalImaging_ImageLoc_Code ;
      private String[] T000T2_A233BR_MedicalImaging_ImageOrgan ;
      private bool[] T000T2_n233BR_MedicalImaging_ImageOrgan ;
      private String[] T000T2_A234BR_MedicalImaging_PreImageDiag ;
      private bool[] T000T2_n234BR_MedicalImaging_PreImageDiag ;
      private String[] T000T2_A235BR_MedicalImaging_ImageDes ;
      private bool[] T000T2_n235BR_MedicalImaging_ImageDes ;
      private String[] T000T2_A236BR_MedicalImaging_TumorSize ;
      private bool[] T000T2_n236BR_MedicalImaging_TumorSize ;
      private String[] T000T2_A334BR_MedicalImaging_ImageHtml ;
      private bool[] T000T2_n334BR_MedicalImaging_ImageHtml ;
      private String[] T000T2_A514BR_MedicalImaging_MetastasesDX ;
      private bool[] T000T2_n514BR_MedicalImaging_MetastasesDX ;
      private String[] T000T2_A515BR_MedicalImaging_MetaLoc ;
      private bool[] T000T2_n515BR_MedicalImaging_MetaLoc ;
      private DateTime[] T000T2_A516BR_MedicalImaging_MetaDate ;
      private bool[] T000T2_n516BR_MedicalImaging_MetaDate ;
      private long[] T000T2_A19BR_EncounterID ;
      private bool[] T000T2_n19BR_EncounterID ;
      private long[] T000T12_A225BR_MedicalImagingID ;
      private bool[] T000T12_n225BR_MedicalImagingID ;
      private long[] T000T15_A85BR_Information_ID ;
      private bool[] T000T15_n85BR_Information_ID ;
      private String[] T000T16_A36BR_Information_PatientNo ;
      private bool[] T000T16_n36BR_Information_PatientNo ;
      private long[] T000T17_A270BR_MedicalImaging_DiagID ;
      private long[] T000T18_A225BR_MedicalImagingID ;
      private bool[] T000T18_n225BR_MedicalImagingID ;
      private long[] T000T19_A167XT_DefineCodeID ;
      private String[] T000T19_A168XT_DefineCodeName ;
      private bool[] T000T19_n168XT_DefineCodeName ;
      private long[] T000T19_A165XT_DefindcodeTypeID ;
      private String[] T000T19_A432XT_TenantCode ;
      private bool[] T000T19_n432XT_TenantCode ;
      private long[] T000T20_A167XT_DefineCodeID ;
      private String[] T000T20_A168XT_DefineCodeName ;
      private bool[] T000T20_n168XT_DefineCodeName ;
      private long[] T000T20_A165XT_DefindcodeTypeID ;
      private String[] T000T20_A432XT_TenantCode ;
      private bool[] T000T20_n432XT_TenantCode ;
      private long[] T000T21_A167XT_DefineCodeID ;
      private String[] T000T21_A168XT_DefineCodeName ;
      private bool[] T000T21_n168XT_DefineCodeName ;
      private long[] T000T21_A165XT_DefindcodeTypeID ;
      private String[] T000T21_A432XT_TenantCode ;
      private bool[] T000T21_n432XT_TenantCode ;
      private long[] T000T22_A85BR_Information_ID ;
      private bool[] T000T22_n85BR_Information_ID ;
      private String[] T000T23_A36BR_Information_PatientNo ;
      private bool[] T000T23_n36BR_Information_PatientNo ;
      private IDataStoreProvider pr_datastore1 ;
      private GXWebForm Form ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV8WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV11TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute AV14TrnContextAtt ;
   }

   public class br_medicalimaging__datastore1 : DataStoreHelperBase, IDataStoreHelper
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

 public class br_medicalimaging__default : DataStoreHelperBase, IDataStoreHelper
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
        Object[] prmT000T6 ;
        prmT000T6 = new Object[] {
        new Object[] {"@BR_MedicalImagingID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000T4 ;
        prmT000T4 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000T5 ;
        prmT000T5 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000T7 ;
        prmT000T7 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000T8 ;
        prmT000T8 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000T9 ;
        prmT000T9 = new Object[] {
        new Object[] {"@BR_MedicalImagingID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000T3 ;
        prmT000T3 = new Object[] {
        new Object[] {"@BR_MedicalImagingID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000T10 ;
        prmT000T10 = new Object[] {
        new Object[] {"@BR_MedicalImagingID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000T11 ;
        prmT000T11 = new Object[] {
        new Object[] {"@BR_MedicalImagingID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000T2 ;
        prmT000T2 = new Object[] {
        new Object[] {"@BR_MedicalImagingID",SqlDbType.Decimal,18,0}
        } ;
        /* Definition of BR_MedicalImaging_ImageLoc changed to svchar length 4000 decimals 0 */
        /* Definition of BR_MedicalImaging_ImageOrgan changed to svchar length 4000 decimals 0 */
        /* Definition of BR_MedicalImaging_ImageDes changed to svchar length 4000 decimals 0 */
        Object[] prmT000T12 ;
        prmT000T12 = new Object[] {
        new Object[] {"@BR_MedicalImaging_ImageName_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_MedicalImaging_ImageHosp_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_MedicalImaging_ID",SqlDbType.Decimal,10,0} ,
        new Object[] {"@BR_MedicalImaging_No",SqlDbType.Decimal,18,0} ,
        new Object[] {"@BR_MedicalImaging_ImageName",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_MedicalImaging_ImageDate",SqlDbType.DateTime,8,0} ,
        new Object[] {"@BR_MedicalImaging_ImageHosp",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_MedicalImaging_ImageAge",SqlDbType.SmallInt,3,0} ,
        new Object[] {"@BR_MedicalImaging_ImageLoc",SqlDbType.NVarChar,4000,0} ,
        new Object[] {"@BR_MedicalImaging_ImageLoc_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_MedicalImaging_ImageOrgan",SqlDbType.NVarChar,4000,0} ,
        new Object[] {"@BR_MedicalImaging_PreImageDiag",SqlDbType.NVarChar,4000,0} ,
        new Object[] {"@BR_MedicalImaging_ImageDes",SqlDbType.NVarChar,4000,0} ,
        new Object[] {"@BR_MedicalImaging_TumorSize",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_MedicalImaging_ImageHtml",SqlDbType.NVarChar,2097152,0} ,
        new Object[] {"@BR_MedicalImaging_MetastasesDX",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_MedicalImaging_MetaLoc",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_MedicalImaging_MetaDate",SqlDbType.DateTime,8,0} ,
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        /* Definition of BR_MedicalImaging_ImageLoc changed to svchar length 4000 decimals 0 */
        /* Definition of BR_MedicalImaging_ImageOrgan changed to svchar length 4000 decimals 0 */
        /* Definition of BR_MedicalImaging_ImageDes changed to svchar length 4000 decimals 0 */
        Object[] prmT000T13 ;
        prmT000T13 = new Object[] {
        new Object[] {"@BR_MedicalImaging_ImageName_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_MedicalImaging_ImageHosp_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_MedicalImaging_ID",SqlDbType.Decimal,10,0} ,
        new Object[] {"@BR_MedicalImaging_No",SqlDbType.Decimal,18,0} ,
        new Object[] {"@BR_MedicalImaging_ImageName",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_MedicalImaging_ImageDate",SqlDbType.DateTime,8,0} ,
        new Object[] {"@BR_MedicalImaging_ImageHosp",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_MedicalImaging_ImageAge",SqlDbType.SmallInt,3,0} ,
        new Object[] {"@BR_MedicalImaging_ImageLoc",SqlDbType.NVarChar,4000,0} ,
        new Object[] {"@BR_MedicalImaging_ImageLoc_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_MedicalImaging_ImageOrgan",SqlDbType.NVarChar,4000,0} ,
        new Object[] {"@BR_MedicalImaging_PreImageDiag",SqlDbType.NVarChar,4000,0} ,
        new Object[] {"@BR_MedicalImaging_ImageDes",SqlDbType.NVarChar,4000,0} ,
        new Object[] {"@BR_MedicalImaging_TumorSize",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_MedicalImaging_ImageHtml",SqlDbType.NVarChar,2097152,0} ,
        new Object[] {"@BR_MedicalImaging_MetastasesDX",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_MedicalImaging_MetaLoc",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_MedicalImaging_MetaDate",SqlDbType.DateTime,8,0} ,
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@BR_MedicalImagingID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000T14 ;
        prmT000T14 = new Object[] {
        new Object[] {"@BR_MedicalImagingID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000T15 ;
        prmT000T15 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000T16 ;
        prmT000T16 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000T17 ;
        prmT000T17 = new Object[] {
        new Object[] {"@BR_MedicalImagingID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000T18 ;
        prmT000T18 = new Object[] {
        } ;
        Object[] prmT000T19 ;
        prmT000T19 = new Object[] {
        new Object[] {"@AV18tCurrentCode",SqlDbType.NVarChar,40,0}
        } ;
        Object[] prmT000T20 ;
        prmT000T20 = new Object[] {
        new Object[] {"@AV18tCurrentCode",SqlDbType.NVarChar,40,0}
        } ;
        Object[] prmT000T21 ;
        prmT000T21 = new Object[] {
        new Object[] {"@AV18tCurrentCode",SqlDbType.NVarChar,40,0}
        } ;
        Object[] prmT000T22 ;
        prmT000T22 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000T23 ;
        prmT000T23 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("T000T2", "SELECT [BR_MedicalImagingID], [BR_MedicalImaging_ImageName_Code], [BR_MedicalImaging_ImageHosp_Code], [BR_MedicalImaging_ID], [BR_MedicalImaging_No], [BR_MedicalImaging_ImageName], [BR_MedicalImaging_ImageDate], [BR_MedicalImaging_ImageHosp], [BR_MedicalImaging_ImageAge], [BR_MedicalImaging_ImageLoc], [BR_MedicalImaging_ImageLoc_Code], [BR_MedicalImaging_ImageOrgan], [BR_MedicalImaging_PreImageDiag], [BR_MedicalImaging_ImageDes], [BR_MedicalImaging_TumorSize], [BR_MedicalImaging_ImageHtml], [BR_MedicalImaging_MetastasesDX], [BR_MedicalImaging_MetaLoc], [BR_MedicalImaging_MetaDate], [BR_EncounterID] FROM [BR_MedicalImaging] WITH (UPDLOCK) WHERE [BR_MedicalImagingID] = @BR_MedicalImagingID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000T2,1,0,true,false )
           ,new CursorDef("T000T3", "SELECT [BR_MedicalImagingID], [BR_MedicalImaging_ImageName_Code], [BR_MedicalImaging_ImageHosp_Code], [BR_MedicalImaging_ID], [BR_MedicalImaging_No], [BR_MedicalImaging_ImageName], [BR_MedicalImaging_ImageDate], [BR_MedicalImaging_ImageHosp], [BR_MedicalImaging_ImageAge], [BR_MedicalImaging_ImageLoc], [BR_MedicalImaging_ImageLoc_Code], [BR_MedicalImaging_ImageOrgan], [BR_MedicalImaging_PreImageDiag], [BR_MedicalImaging_ImageDes], [BR_MedicalImaging_TumorSize], [BR_MedicalImaging_ImageHtml], [BR_MedicalImaging_MetastasesDX], [BR_MedicalImaging_MetaLoc], [BR_MedicalImaging_MetaDate], [BR_EncounterID] FROM [BR_MedicalImaging] WITH (NOLOCK) WHERE [BR_MedicalImagingID] = @BR_MedicalImagingID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000T3,1,0,true,false )
           ,new CursorDef("T000T4", "SELECT [BR_Information_ID] FROM [BR_Encounter] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000T4,1,0,true,false )
           ,new CursorDef("T000T5", "SELECT [BR_Information_PatientNo] FROM [BR_Information] WITH (NOLOCK) WHERE [BR_Information_ID] = @BR_Information_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000T5,1,0,true,false )
           ,new CursorDef("T000T6", "SELECT T2.[BR_Information_ID], TM1.[BR_MedicalImagingID], TM1.[BR_MedicalImaging_ImageName_Code], TM1.[BR_MedicalImaging_ImageHosp_Code], T3.[BR_Information_PatientNo], TM1.[BR_MedicalImaging_ID], TM1.[BR_MedicalImaging_No], TM1.[BR_MedicalImaging_ImageName], TM1.[BR_MedicalImaging_ImageDate], TM1.[BR_MedicalImaging_ImageHosp], TM1.[BR_MedicalImaging_ImageAge], TM1.[BR_MedicalImaging_ImageLoc], TM1.[BR_MedicalImaging_ImageLoc_Code], TM1.[BR_MedicalImaging_ImageOrgan], TM1.[BR_MedicalImaging_PreImageDiag], TM1.[BR_MedicalImaging_ImageDes], TM1.[BR_MedicalImaging_TumorSize], TM1.[BR_MedicalImaging_ImageHtml], TM1.[BR_MedicalImaging_MetastasesDX], TM1.[BR_MedicalImaging_MetaLoc], TM1.[BR_MedicalImaging_MetaDate], TM1.[BR_EncounterID] FROM (([BR_MedicalImaging] TM1 WITH (NOLOCK) LEFT JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = TM1.[BR_EncounterID]) LEFT JOIN [BR_Information] T3 WITH (NOLOCK) ON T3.[BR_Information_ID] = T2.[BR_Information_ID]) WHERE TM1.[BR_MedicalImagingID] = @BR_MedicalImagingID ORDER BY TM1.[BR_MedicalImagingID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000T6,100,0,true,false )
           ,new CursorDef("T000T7", "SELECT [BR_Information_ID] FROM [BR_Encounter] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000T7,1,0,true,false )
           ,new CursorDef("T000T8", "SELECT [BR_Information_PatientNo] FROM [BR_Information] WITH (NOLOCK) WHERE [BR_Information_ID] = @BR_Information_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000T8,1,0,true,false )
           ,new CursorDef("T000T9", "SELECT [BR_MedicalImagingID] FROM [BR_MedicalImaging] WITH (NOLOCK) WHERE [BR_MedicalImagingID] = @BR_MedicalImagingID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000T9,1,0,true,false )
           ,new CursorDef("T000T10", "SELECT TOP 1 [BR_MedicalImagingID] FROM [BR_MedicalImaging] WITH (NOLOCK) WHERE ( [BR_MedicalImagingID] > @BR_MedicalImagingID) ORDER BY [BR_MedicalImagingID]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000T10,1,0,true,true )
           ,new CursorDef("T000T11", "SELECT TOP 1 [BR_MedicalImagingID] FROM [BR_MedicalImaging] WITH (NOLOCK) WHERE ( [BR_MedicalImagingID] < @BR_MedicalImagingID) ORDER BY [BR_MedicalImagingID] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000T11,1,0,true,true )
           ,new CursorDef("T000T12", "INSERT INTO [BR_MedicalImaging]([BR_MedicalImaging_ImageName_Code], [BR_MedicalImaging_ImageHosp_Code], [BR_MedicalImaging_ID], [BR_MedicalImaging_No], [BR_MedicalImaging_ImageName], [BR_MedicalImaging_ImageDate], [BR_MedicalImaging_ImageHosp], [BR_MedicalImaging_ImageAge], [BR_MedicalImaging_ImageLoc], [BR_MedicalImaging_ImageLoc_Code], [BR_MedicalImaging_ImageOrgan], [BR_MedicalImaging_PreImageDiag], [BR_MedicalImaging_ImageDes], [BR_MedicalImaging_TumorSize], [BR_MedicalImaging_ImageHtml], [BR_MedicalImaging_MetastasesDX], [BR_MedicalImaging_MetaLoc], [BR_MedicalImaging_MetaDate], [BR_EncounterID]) VALUES(@BR_MedicalImaging_ImageName_Code, @BR_MedicalImaging_ImageHosp_Code, @BR_MedicalImaging_ID, @BR_MedicalImaging_No, @BR_MedicalImaging_ImageName, @BR_MedicalImaging_ImageDate, @BR_MedicalImaging_ImageHosp, @BR_MedicalImaging_ImageAge, @BR_MedicalImaging_ImageLoc, @BR_MedicalImaging_ImageLoc_Code, @BR_MedicalImaging_ImageOrgan, @BR_MedicalImaging_PreImageDiag, @BR_MedicalImaging_ImageDes, @BR_MedicalImaging_TumorSize, @BR_MedicalImaging_ImageHtml, @BR_MedicalImaging_MetastasesDX, @BR_MedicalImaging_MetaLoc, @BR_MedicalImaging_MetaDate, @BR_EncounterID); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmT000T12)
           ,new CursorDef("T000T13", "UPDATE [BR_MedicalImaging] SET [BR_MedicalImaging_ImageName_Code]=@BR_MedicalImaging_ImageName_Code, [BR_MedicalImaging_ImageHosp_Code]=@BR_MedicalImaging_ImageHosp_Code, [BR_MedicalImaging_ID]=@BR_MedicalImaging_ID, [BR_MedicalImaging_No]=@BR_MedicalImaging_No, [BR_MedicalImaging_ImageName]=@BR_MedicalImaging_ImageName, [BR_MedicalImaging_ImageDate]=@BR_MedicalImaging_ImageDate, [BR_MedicalImaging_ImageHosp]=@BR_MedicalImaging_ImageHosp, [BR_MedicalImaging_ImageAge]=@BR_MedicalImaging_ImageAge, [BR_MedicalImaging_ImageLoc]=@BR_MedicalImaging_ImageLoc, [BR_MedicalImaging_ImageLoc_Code]=@BR_MedicalImaging_ImageLoc_Code, [BR_MedicalImaging_ImageOrgan]=@BR_MedicalImaging_ImageOrgan, [BR_MedicalImaging_PreImageDiag]=@BR_MedicalImaging_PreImageDiag, [BR_MedicalImaging_ImageDes]=@BR_MedicalImaging_ImageDes, [BR_MedicalImaging_TumorSize]=@BR_MedicalImaging_TumorSize, [BR_MedicalImaging_ImageHtml]=@BR_MedicalImaging_ImageHtml, [BR_MedicalImaging_MetastasesDX]=@BR_MedicalImaging_MetastasesDX, [BR_MedicalImaging_MetaLoc]=@BR_MedicalImaging_MetaLoc, [BR_MedicalImaging_MetaDate]=@BR_MedicalImaging_MetaDate, [BR_EncounterID]=@BR_EncounterID  WHERE [BR_MedicalImagingID] = @BR_MedicalImagingID", GxErrorMask.GX_NOMASK,prmT000T13)
           ,new CursorDef("T000T14", "DELETE FROM [BR_MedicalImaging]  WHERE [BR_MedicalImagingID] = @BR_MedicalImagingID", GxErrorMask.GX_NOMASK,prmT000T14)
           ,new CursorDef("T000T15", "SELECT [BR_Information_ID] FROM [BR_Encounter] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000T15,1,0,true,false )
           ,new CursorDef("T000T16", "SELECT [BR_Information_PatientNo] FROM [BR_Information] WITH (NOLOCK) WHERE [BR_Information_ID] = @BR_Information_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000T16,1,0,true,false )
           ,new CursorDef("T000T17", "SELECT TOP 1 [BR_MedicalImaging_DiagID] FROM [BR_MedicalImaging_Diag] WITH (NOLOCK) WHERE [BR_MedicalImagingID] = @BR_MedicalImagingID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000T17,1,0,true,true )
           ,new CursorDef("T000T18", "SELECT [BR_MedicalImagingID] FROM [BR_MedicalImaging] WITH (NOLOCK) ORDER BY [BR_MedicalImagingID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000T18,100,0,true,false )
           ,new CursorDef("T000T19", "SELECT [XT_DefineCodeID], [XT_DefineCodeName], [XT_DefindcodeTypeID], [XT_TenantCode] FROM [XT_DefineCode] WITH (NOLOCK) WHERE ([XT_DefindcodeTypeID] = 30) AND ([XT_TenantCode] = @AV18tCurrentCode) ",true, GxErrorMask.GX_NOMASK, false, this,prmT000T19,0,0,true,false )
           ,new CursorDef("T000T20", "SELECT [XT_DefineCodeID], [XT_DefineCodeName], [XT_DefindcodeTypeID], [XT_TenantCode] FROM [XT_DefineCode] WITH (NOLOCK) WHERE ([XT_DefindcodeTypeID] = 31) AND ([XT_TenantCode] = @AV18tCurrentCode) ",true, GxErrorMask.GX_NOMASK, false, this,prmT000T20,0,0,true,false )
           ,new CursorDef("T000T21", "SELECT [XT_DefineCodeID], [XT_DefineCodeName], [XT_DefindcodeTypeID], [XT_TenantCode] FROM [XT_DefineCode] WITH (NOLOCK) WHERE ([XT_DefindcodeTypeID] = 34) AND ([XT_TenantCode] = @AV18tCurrentCode) ",true, GxErrorMask.GX_NOMASK, false, this,prmT000T21,0,0,true,false )
           ,new CursorDef("T000T22", "SELECT [BR_Information_ID] FROM [BR_Encounter] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000T22,1,0,true,false )
           ,new CursorDef("T000T23", "SELECT [BR_Information_PatientNo] FROM [BR_Information] WITH (NOLOCK) WHERE [BR_Information_ID] = @BR_Information_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000T23,1,0,true,false )
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
              ((long[]) buf[5])[0] = rslt.getLong(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((long[]) buf[7])[0] = rslt.getLong(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((DateTime[]) buf[11])[0] = rslt.getGXDate(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              ((String[]) buf[13])[0] = rslt.getVarchar(8) ;
              ((bool[]) buf[14])[0] = rslt.wasNull(8);
              ((short[]) buf[15])[0] = rslt.getShort(9) ;
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
              ((String[]) buf[29])[0] = rslt.getLongVarchar(16) ;
              ((bool[]) buf[30])[0] = rslt.wasNull(16);
              ((String[]) buf[31])[0] = rslt.getVarchar(17) ;
              ((bool[]) buf[32])[0] = rslt.wasNull(17);
              ((String[]) buf[33])[0] = rslt.getVarchar(18) ;
              ((bool[]) buf[34])[0] = rslt.wasNull(18);
              ((DateTime[]) buf[35])[0] = rslt.getGXDate(19) ;
              ((bool[]) buf[36])[0] = rslt.wasNull(19);
              ((long[]) buf[37])[0] = rslt.getLong(20) ;
              ((bool[]) buf[38])[0] = rslt.wasNull(20);
              return;
           case 1 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((long[]) buf[5])[0] = rslt.getLong(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((long[]) buf[7])[0] = rslt.getLong(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((DateTime[]) buf[11])[0] = rslt.getGXDate(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              ((String[]) buf[13])[0] = rslt.getVarchar(8) ;
              ((bool[]) buf[14])[0] = rslt.wasNull(8);
              ((short[]) buf[15])[0] = rslt.getShort(9) ;
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
              ((String[]) buf[29])[0] = rslt.getLongVarchar(16) ;
              ((bool[]) buf[30])[0] = rslt.wasNull(16);
              ((String[]) buf[31])[0] = rslt.getVarchar(17) ;
              ((bool[]) buf[32])[0] = rslt.wasNull(17);
              ((String[]) buf[33])[0] = rslt.getVarchar(18) ;
              ((bool[]) buf[34])[0] = rslt.wasNull(18);
              ((DateTime[]) buf[35])[0] = rslt.getGXDate(19) ;
              ((bool[]) buf[36])[0] = rslt.wasNull(19);
              ((long[]) buf[37])[0] = rslt.getLong(20) ;
              ((bool[]) buf[38])[0] = rslt.wasNull(20);
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
              ((long[]) buf[9])[0] = rslt.getLong(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((long[]) buf[11])[0] = rslt.getLong(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              ((String[]) buf[13])[0] = rslt.getVarchar(8) ;
              ((bool[]) buf[14])[0] = rslt.wasNull(8);
              ((DateTime[]) buf[15])[0] = rslt.getGXDate(9) ;
              ((bool[]) buf[16])[0] = rslt.wasNull(9);
              ((String[]) buf[17])[0] = rslt.getVarchar(10) ;
              ((bool[]) buf[18])[0] = rslt.wasNull(10);
              ((short[]) buf[19])[0] = rslt.getShort(11) ;
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
              ((String[]) buf[33])[0] = rslt.getLongVarchar(18) ;
              ((bool[]) buf[34])[0] = rslt.wasNull(18);
              ((String[]) buf[35])[0] = rslt.getVarchar(19) ;
              ((bool[]) buf[36])[0] = rslt.wasNull(19);
              ((String[]) buf[37])[0] = rslt.getVarchar(20) ;
              ((bool[]) buf[38])[0] = rslt.wasNull(20);
              ((DateTime[]) buf[39])[0] = rslt.getGXDate(21) ;
              ((bool[]) buf[40])[0] = rslt.wasNull(21);
              ((long[]) buf[41])[0] = rslt.getLong(22) ;
              ((bool[]) buf[42])[0] = rslt.wasNull(22);
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
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((long[]) buf[3])[0] = rslt.getLong(3) ;
              ((String[]) buf[4])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[5])[0] = rslt.wasNull(4);
              return;
           case 18 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((long[]) buf[3])[0] = rslt.getLong(3) ;
              ((String[]) buf[4])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[5])[0] = rslt.wasNull(4);
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
                 stmt.setNull( 3 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(3, (long)parms[5]);
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
                 stmt.setNull( 5 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(5, (String)parms[9]);
              }
              if ( (bool)parms[10] )
              {
                 stmt.setNull( 6 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameter(6, (DateTime)parms[11]);
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
                 stmt.setNull( 8 , SqlDbType.SmallInt );
              }
              else
              {
                 stmt.SetParameter(8, (short)parms[15]);
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
                 stmt.setNull( 18 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameter(18, (DateTime)parms[35]);
              }
              if ( (bool)parms[36] )
              {
                 stmt.setNull( 19 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(19, (long)parms[37]);
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
                 stmt.setNull( 3 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(3, (long)parms[5]);
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
                 stmt.setNull( 5 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(5, (String)parms[9]);
              }
              if ( (bool)parms[10] )
              {
                 stmt.setNull( 6 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameter(6, (DateTime)parms[11]);
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
                 stmt.setNull( 8 , SqlDbType.SmallInt );
              }
              else
              {
                 stmt.SetParameter(8, (short)parms[15]);
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
                 stmt.setNull( 18 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameter(18, (DateTime)parms[35]);
              }
              if ( (bool)parms[36] )
              {
                 stmt.setNull( 19 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(19, (long)parms[37]);
              }
              if ( (bool)parms[38] )
              {
                 stmt.setNull( 20 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(20, (long)parms[39]);
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
           case 17 :
              stmt.SetParameter(1, (String)parms[0]);
              return;
           case 18 :
              stmt.SetParameter(1, (String)parms[0]);
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
