/*
               File: BR_Procedure
        Description: Data Mgmt Portal - RAAP
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 11:57:52.10
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
   public class br_procedure : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxJX_Action27") == 0 )
         {
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            XC_27_0I19( ) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxJX_Action28") == 0 )
         {
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            XC_28_0I19( ) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxJX_Action29") == 0 )
         {
            A143BR_Procedure_PXRadiotherapy = GetNextPar( );
            n143BR_Procedure_PXRadiotherapy = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A143BR_Procedure_PXRadiotherapy", A143BR_Procedure_PXRadiotherapy);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            XC_29_0I19( A143BR_Procedure_PXRadiotherapy) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxJX_Action30") == 0 )
         {
            A143BR_Procedure_PXRadiotherapy = GetNextPar( );
            n143BR_Procedure_PXRadiotherapy = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A143BR_Procedure_PXRadiotherapy", A143BR_Procedure_PXRadiotherapy);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            XC_30_0I19( A143BR_Procedure_PXRadiotherapy) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxJX_Action31") == 0 )
         {
            A141BR_Procedure_PXSurgery = GetNextPar( );
            n141BR_Procedure_PXSurgery = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A141BR_Procedure_PXSurgery", A141BR_Procedure_PXSurgery);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            XC_31_0I19( A141BR_Procedure_PXSurgery) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxJX_Action32") == 0 )
         {
            A141BR_Procedure_PXSurgery = GetNextPar( );
            n141BR_Procedure_PXSurgery = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A141BR_Procedure_PXSurgery", A141BR_Procedure_PXSurgery);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            XC_32_0I19( A141BR_Procedure_PXSurgery) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel20"+"_"+"BR_PROCEDURE_PXSURGERY_CODE") == 0 )
         {
            A141BR_Procedure_PXSurgery = GetNextPar( );
            n141BR_Procedure_PXSurgery = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A141BR_Procedure_PXSurgery", A141BR_Procedure_PXSurgery);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX20ASABR_PROCEDURE_PXSURGERY_CODE0I19( A141BR_Procedure_PXSurgery) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel21"+"_"+"BR_PROCEDURE_PXSURGERY_CODE") == 0 )
         {
            A141BR_Procedure_PXSurgery = GetNextPar( );
            n141BR_Procedure_PXSurgery = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A141BR_Procedure_PXSurgery", A141BR_Procedure_PXSurgery);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX21ASABR_PROCEDURE_PXSURGERY_CODE0I19( A141BR_Procedure_PXSurgery) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel22"+"_"+"BR_PROCEDURE_PXRADIOTHERAPY_CODE") == 0 )
         {
            A143BR_Procedure_PXRadiotherapy = GetNextPar( );
            n143BR_Procedure_PXRadiotherapy = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A143BR_Procedure_PXRadiotherapy", A143BR_Procedure_PXRadiotherapy);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX22ASABR_PROCEDURE_PXRADIOTHERAPY_CODE0I19( A143BR_Procedure_PXRadiotherapy) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel23"+"_"+"BR_PROCEDURE_PXRADIOTHERAPY_CODE") == 0 )
         {
            A143BR_Procedure_PXRadiotherapy = GetNextPar( );
            n143BR_Procedure_PXRadiotherapy = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A143BR_Procedure_PXRadiotherapy", A143BR_Procedure_PXRadiotherapy);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX23ASABR_PROCEDURE_PXRADIOTHERAPY_CODE0I19( A143BR_Procedure_PXRadiotherapy) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_34") == 0 )
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
            gxLoad_34( A19BR_EncounterID) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_35") == 0 )
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
            gxLoad_35( A85BR_Information_ID) ;
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
               AV12BR_ProcedureID = (long)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12BR_ProcedureID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12BR_ProcedureID), 18, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vBR_PROCEDUREID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV12BR_ProcedureID), "ZZZZZZZZZZZZZZZZZZ"), context));
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
         GX_FocusControl = cmbBR_Procedure_PXSurgery_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("WorkWithPlusTheme");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public br_procedure( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_procedure( IGxContext context )
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
                           long aP1_BR_ProcedureID )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV12BR_ProcedureID = aP1_BR_ProcedureID;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         cmbBR_Procedure_PXSurgery = new GXCombobox();
         cmbBR_Procedure_PXRadiotherapy = new GXCombobox();
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
         if ( cmbBR_Procedure_PXSurgery.ItemCount > 0 )
         {
            A141BR_Procedure_PXSurgery = cmbBR_Procedure_PXSurgery.getValidValue(A141BR_Procedure_PXSurgery);
            n141BR_Procedure_PXSurgery = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A141BR_Procedure_PXSurgery", A141BR_Procedure_PXSurgery);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbBR_Procedure_PXSurgery.CurrentValue = StringUtil.RTrim( A141BR_Procedure_PXSurgery);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Procedure_PXSurgery_Internalname, "Values", cmbBR_Procedure_PXSurgery.ToJavascriptSource(), true);
         }
         if ( cmbBR_Procedure_PXRadiotherapy.ItemCount > 0 )
         {
            A143BR_Procedure_PXRadiotherapy = cmbBR_Procedure_PXRadiotherapy.getValidValue(A143BR_Procedure_PXRadiotherapy);
            n143BR_Procedure_PXRadiotherapy = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A143BR_Procedure_PXRadiotherapy", A143BR_Procedure_PXRadiotherapy);
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbBR_Procedure_PXRadiotherapy.CurrentValue = StringUtil.RTrim( A143BR_Procedure_PXRadiotherapy);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Procedure_PXRadiotherapy_Internalname, "Values", cmbBR_Procedure_PXRadiotherapy.ToJavascriptSource(), true);
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
            GxWebStd.gx_div_start( context, divBr_procedure_pxsurgery_cell_Internalname, 1, 0, "px", 0, "px", divBr_procedure_pxsurgery_cell_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_procedure_pxsurgery_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_procedure_pxsurgery_Internalname, "是否手术", "", "", lblTextblockbr_procedure_pxsurgery_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Procedure.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbBR_Procedure_PXSurgery_Internalname, "是否手术", "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbBR_Procedure_PXSurgery, cmbBR_Procedure_PXSurgery_Internalname, StringUtil.RTrim( A141BR_Procedure_PXSurgery), 1, cmbBR_Procedure_PXSurgery_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", cmbBR_Procedure_PXSurgery.Visible, cmbBR_Procedure_PXSurgery.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,29);\"", "", true, "HLP_BR_Procedure.htm");
            cmbBR_Procedure_PXSurgery.CurrentValue = StringUtil.RTrim( A141BR_Procedure_PXSurgery);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Procedure_PXSurgery_Internalname, "Values", (String)(cmbBR_Procedure_PXSurgery.ToJavascriptSource()), true);
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
            GxWebStd.gx_div_start( context, divUnnamedtablebr_procedure_date_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_procedure_date_Internalname, "手术日期", "", "", lblTextblockbr_procedure_date_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Procedure.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Procedure_Date_Internalname, "手术日期", "col-sm-3 AttributeDateLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 40,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtBR_Procedure_Date_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtBR_Procedure_Date_Internalname, context.localUtil.Format(A266BR_Procedure_Date, "9999/99/99"), context.localUtil.Format( A266BR_Procedure_Date, "9999/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',0,24,'chs',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,40);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Procedure_Date_Jsonclick, 0, "AttributeDate", "", "", "", "", 1, edtBR_Procedure_Date_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "DM_Date", "right", false, "HLP_BR_Procedure.htm");
            GxWebStd.gx_bitmap( context, edtBR_Procedure_Date_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtBR_Procedure_Date_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_Procedure.htm");
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
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divBr_procedure_pxradiotherapy_cell_Internalname, 1, 0, "px", 0, "px", divBr_procedure_pxradiotherapy_cell_Class, "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_procedure_pxradiotherapy_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_procedure_pxradiotherapy_Internalname, "是否接受放射疗法", "", "", lblTextblockbr_procedure_pxradiotherapy_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Procedure.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbBR_Procedure_PXRadiotherapy_Internalname, "是否接受放射疗法", "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 49,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbBR_Procedure_PXRadiotherapy, cmbBR_Procedure_PXRadiotherapy_Internalname, StringUtil.RTrim( A143BR_Procedure_PXRadiotherapy), 1, cmbBR_Procedure_PXRadiotherapy_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", cmbBR_Procedure_PXRadiotherapy.Visible, cmbBR_Procedure_PXRadiotherapy.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,49);\"", "", true, "HLP_BR_Procedure.htm");
            cmbBR_Procedure_PXRadiotherapy.CurrentValue = StringUtil.RTrim( A143BR_Procedure_PXRadiotherapy);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Procedure_PXRadiotherapy_Internalname, "Values", (String)(cmbBR_Procedure_PXRadiotherapy.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtable2_Internalname, divUnnamedtable2_Visible, 0, "px", 0, "px", "", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_procedure_radiodate_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_procedure_radiodate_Internalname, "放疗日期", "", "", lblTextblockbr_procedure_radiodate_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Procedure.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Procedure_RadioDate_Internalname, "放疗日期", "col-sm-3 AttributeDateLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 60,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtBR_Procedure_RadioDate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtBR_Procedure_RadioDate_Internalname, context.localUtil.Format(A268BR_Procedure_RadioDate, "9999/99/99"), context.localUtil.Format( A268BR_Procedure_RadioDate, "9999/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',0,24,'chs',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,60);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Procedure_RadioDate_Jsonclick, 0, "AttributeDate", "", "", "", "", 1, edtBR_Procedure_RadioDate_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "DM_Date", "right", false, "HLP_BR_Procedure.htm");
            GxWebStd.gx_bitmap( context, edtBR_Procedure_RadioDate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtBR_Procedure_RadioDate_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_Procedure.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_procedure_radiotime_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_procedure_radiotime_Internalname, "放疗疗程", "", "", lblTextblockbr_procedure_radiotime_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Procedure.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Procedure_RadioTime_Internalname, "放疗疗程", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 68,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_Procedure_RadioTime_Internalname, StringUtil.LTrim( StringUtil.NToC( A269BR_Procedure_RadioTime, 15, 5, ".", "")), ((edtBR_Procedure_RadioTime_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A269BR_Procedure_RadioTime, "ZZZZZZZZZ.ZZZZZ")) : context.localUtil.Format( A269BR_Procedure_RadioTime, "ZZZZZZZZZ.ZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, ',','.','5');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,68);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Procedure_RadioTime_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBR_Procedure_RadioTime_Enabled, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "DM_Numeric", "right", false, "HLP_BR_Procedure.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 73,'',false,'',0)\"";
            ClassString = "ButtonMaterial";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_enter_Internalname, "", "保存", bttBtntrn_enter_Jsonclick, 5, "确认", "", StyleString, ClassString, bttBtntrn_enter_Visible, bttBtntrn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_Procedure.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 75,'',false,'',0)\"";
            ClassString = "ButtonMaterialDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_cancel_Internalname, "", "取消", bttBtntrn_cancel_Jsonclick, 1, "取消", "", StyleString, ClassString, bttBtntrn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_Procedure.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 77,'',false,'',0)\"";
            ClassString = "ButtonMaterialDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_delete_Internalname, "", "删除", bttBtntrn_delete_Jsonclick, 5, "删除", "", StyleString, ClassString, bttBtntrn_delete_Visible, bttBtntrn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_Procedure.htm");
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
            GxWebStd.gx_single_line_edit( context, edtBR_ProcedureID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A139BR_ProcedureID), 18, 0, ".", "")), ((edtBR_ProcedureID_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A139BR_ProcedureID), "ZZZZZZZZZZZZZZZZZZ")) : context.localUtil.Format( (decimal)(A139BR_ProcedureID), "ZZZZZZZZZZZZZZZZZZ")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_ProcedureID_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_ProcedureID_Visible, edtBR_ProcedureID_Enabled, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "HLP_BR_Procedure.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 82,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_EncounterID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A19BR_EncounterID), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A19BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,82);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_EncounterID_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_EncounterID_Visible, edtBR_EncounterID_Enabled, 1, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "HLP_BR_Procedure.htm");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Information_PatientNo_Internalname, A36BR_Information_PatientNo, StringUtil.RTrim( context.localUtil.Format( A36BR_Information_PatientNo, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Information_PatientNo_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_Information_PatientNo_Visible, edtBR_Information_PatientNo_Enabled, 0, "text", "", 80, "chr", 1, "row", 2000, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Procedure.htm");
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
         E110I2 ();
         context.wbGlbDoneStart = 1;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
               cmbBR_Procedure_PXSurgery.CurrentValue = cgiGet( cmbBR_Procedure_PXSurgery_Internalname);
               A141BR_Procedure_PXSurgery = cgiGet( cmbBR_Procedure_PXSurgery_Internalname);
               n141BR_Procedure_PXSurgery = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A141BR_Procedure_PXSurgery", A141BR_Procedure_PXSurgery);
               n141BR_Procedure_PXSurgery = (String.IsNullOrEmpty(StringUtil.RTrim( A141BR_Procedure_PXSurgery)) ? true : false);
               if ( context.localUtil.VCDate( cgiGet( edtBR_Procedure_Date_Internalname), 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"手术日期"}), 1, "BR_PROCEDURE_DATE");
                  AnyError = 1;
                  GX_FocusControl = edtBR_Procedure_Date_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A266BR_Procedure_Date = DateTime.MinValue;
                  n266BR_Procedure_Date = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A266BR_Procedure_Date", context.localUtil.Format(A266BR_Procedure_Date, "9999/99/99"));
               }
               else
               {
                  A266BR_Procedure_Date = context.localUtil.CToD( cgiGet( edtBR_Procedure_Date_Internalname), 0);
                  n266BR_Procedure_Date = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A266BR_Procedure_Date", context.localUtil.Format(A266BR_Procedure_Date, "9999/99/99"));
               }
               n266BR_Procedure_Date = ((DateTime.MinValue==A266BR_Procedure_Date) ? true : false);
               cmbBR_Procedure_PXRadiotherapy.CurrentValue = cgiGet( cmbBR_Procedure_PXRadiotherapy_Internalname);
               A143BR_Procedure_PXRadiotherapy = cgiGet( cmbBR_Procedure_PXRadiotherapy_Internalname);
               n143BR_Procedure_PXRadiotherapy = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A143BR_Procedure_PXRadiotherapy", A143BR_Procedure_PXRadiotherapy);
               n143BR_Procedure_PXRadiotherapy = (String.IsNullOrEmpty(StringUtil.RTrim( A143BR_Procedure_PXRadiotherapy)) ? true : false);
               if ( context.localUtil.VCDate( cgiGet( edtBR_Procedure_RadioDate_Internalname), 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"放疗日期"}), 1, "BR_PROCEDURE_RADIODATE");
                  AnyError = 1;
                  GX_FocusControl = edtBR_Procedure_RadioDate_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A268BR_Procedure_RadioDate = DateTime.MinValue;
                  n268BR_Procedure_RadioDate = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A268BR_Procedure_RadioDate", context.localUtil.Format(A268BR_Procedure_RadioDate, "9999/99/99"));
               }
               else
               {
                  A268BR_Procedure_RadioDate = context.localUtil.CToD( cgiGet( edtBR_Procedure_RadioDate_Internalname), 0);
                  n268BR_Procedure_RadioDate = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A268BR_Procedure_RadioDate", context.localUtil.Format(A268BR_Procedure_RadioDate, "9999/99/99"));
               }
               n268BR_Procedure_RadioDate = ((DateTime.MinValue==A268BR_Procedure_RadioDate) ? true : false);
               if ( ( ( context.localUtil.CToN( cgiGet( edtBR_Procedure_RadioTime_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtBR_Procedure_RadioTime_Internalname), ".", ",") > 999999999.99999m ) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_PROCEDURE_RADIOTIME");
                  AnyError = 1;
                  GX_FocusControl = edtBR_Procedure_RadioTime_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A269BR_Procedure_RadioTime = 0;
                  n269BR_Procedure_RadioTime = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A269BR_Procedure_RadioTime", StringUtil.LTrim( StringUtil.Str( A269BR_Procedure_RadioTime, 15, 5)));
               }
               else
               {
                  A269BR_Procedure_RadioTime = context.localUtil.CToN( cgiGet( edtBR_Procedure_RadioTime_Internalname), ".", ",");
                  n269BR_Procedure_RadioTime = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A269BR_Procedure_RadioTime", StringUtil.LTrim( StringUtil.Str( A269BR_Procedure_RadioTime, 15, 5)));
               }
               n269BR_Procedure_RadioTime = ((Convert.ToDecimal(0)==A269BR_Procedure_RadioTime) ? true : false);
               A139BR_ProcedureID = (long)(context.localUtil.CToN( cgiGet( edtBR_ProcedureID_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A139BR_ProcedureID", StringUtil.LTrim( StringUtil.Str( (decimal)(A139BR_ProcedureID), 18, 0)));
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
               /* Read saved values. */
               Z139BR_ProcedureID = (long)(context.localUtil.CToN( cgiGet( "Z139BR_ProcedureID"), ".", ","));
               Z497BR_Procedure_PXSurgery_Code = cgiGet( "Z497BR_Procedure_PXSurgery_Code");
               n497BR_Procedure_PXSurgery_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A497BR_Procedure_PXSurgery_Code)) ? true : false);
               Z498BR_Procedure_PXRadiotherapy_Code = cgiGet( "Z498BR_Procedure_PXRadiotherapy_Code");
               n498BR_Procedure_PXRadiotherapy_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A498BR_Procedure_PXRadiotherapy_Code)) ? true : false);
               Z140BR_Procedure_PXID = (long)(context.localUtil.CToN( cgiGet( "Z140BR_Procedure_PXID"), ".", ","));
               n140BR_Procedure_PXID = ((0==A140BR_Procedure_PXID) ? true : false);
               Z141BR_Procedure_PXSurgery = cgiGet( "Z141BR_Procedure_PXSurgery");
               n141BR_Procedure_PXSurgery = (String.IsNullOrEmpty(StringUtil.RTrim( A141BR_Procedure_PXSurgery)) ? true : false);
               Z266BR_Procedure_Date = context.localUtil.CToD( cgiGet( "Z266BR_Procedure_Date"), 0);
               n266BR_Procedure_Date = ((DateTime.MinValue==A266BR_Procedure_Date) ? true : false);
               Z143BR_Procedure_PXRadiotherapy = cgiGet( "Z143BR_Procedure_PXRadiotherapy");
               n143BR_Procedure_PXRadiotherapy = (String.IsNullOrEmpty(StringUtil.RTrim( A143BR_Procedure_PXRadiotherapy)) ? true : false);
               Z268BR_Procedure_RadioDate = context.localUtil.CToD( cgiGet( "Z268BR_Procedure_RadioDate"), 0);
               n268BR_Procedure_RadioDate = ((DateTime.MinValue==A268BR_Procedure_RadioDate) ? true : false);
               Z269BR_Procedure_RadioTime = context.localUtil.CToN( cgiGet( "Z269BR_Procedure_RadioTime"), ".", ",");
               n269BR_Procedure_RadioTime = ((Convert.ToDecimal(0)==A269BR_Procedure_RadioTime) ? true : false);
               Z19BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( "Z19BR_EncounterID"), ".", ","));
               n19BR_EncounterID = ((0==A19BR_EncounterID) ? true : false);
               A497BR_Procedure_PXSurgery_Code = cgiGet( "Z497BR_Procedure_PXSurgery_Code");
               n497BR_Procedure_PXSurgery_Code = false;
               n497BR_Procedure_PXSurgery_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A497BR_Procedure_PXSurgery_Code)) ? true : false);
               A498BR_Procedure_PXRadiotherapy_Code = cgiGet( "Z498BR_Procedure_PXRadiotherapy_Code");
               n498BR_Procedure_PXRadiotherapy_Code = false;
               n498BR_Procedure_PXRadiotherapy_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A498BR_Procedure_PXRadiotherapy_Code)) ? true : false);
               A140BR_Procedure_PXID = (long)(context.localUtil.CToN( cgiGet( "Z140BR_Procedure_PXID"), ".", ","));
               n140BR_Procedure_PXID = false;
               n140BR_Procedure_PXID = ((0==A140BR_Procedure_PXID) ? true : false);
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ","));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ","));
               Gx_mode = cgiGet( "Mode");
               N19BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( "N19BR_EncounterID"), ".", ","));
               n19BR_EncounterID = ((0==A19BR_EncounterID) ? true : false);
               AV12BR_ProcedureID = (long)(context.localUtil.CToN( cgiGet( "vBR_PROCEDUREID"), ".", ","));
               AV10Insert_BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( "vINSERT_BR_ENCOUNTERID"), ".", ","));
               A497BR_Procedure_PXSurgery_Code = cgiGet( "BR_PROCEDURE_PXSURGERY_CODE");
               n497BR_Procedure_PXSurgery_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A497BR_Procedure_PXSurgery_Code)) ? true : false);
               A498BR_Procedure_PXRadiotherapy_Code = cgiGet( "BR_PROCEDURE_PXRADIOTHERAPY_CODE");
               n498BR_Procedure_PXRadiotherapy_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A498BR_Procedure_PXRadiotherapy_Code)) ? true : false);
               A140BR_Procedure_PXID = (long)(context.localUtil.CToN( cgiGet( "BR_PROCEDURE_PXID"), ".", ","));
               n140BR_Procedure_PXID = ((0==A140BR_Procedure_PXID) ? true : false);
               A85BR_Information_ID = (long)(context.localUtil.CToN( cgiGet( "BR_INFORMATION_ID"), ".", ","));
               AV20Pgmname = cgiGet( "vPGMNAME");
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
               forbiddenHiddens = "hsh" + "BR_Procedure";
               A139BR_ProcedureID = (long)(context.localUtil.CToN( cgiGet( edtBR_ProcedureID_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A139BR_ProcedureID", StringUtil.LTrim( StringUtil.Str( (decimal)(A139BR_ProcedureID), 18, 0)));
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A139BR_ProcedureID), "ZZZZZZZZZZZZZZZZZZ");
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV10Insert_BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ");
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A140BR_Procedure_PXID), "ZZZZZZZZZZ");
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( A139BR_ProcedureID != Z139BR_ProcedureID ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
               {
                  GXUtil.WriteLog("br_procedure:[SecurityCheckFailed value for]"+"BR_ProcedureID:"+context.localUtil.Format( (decimal)(A139BR_ProcedureID), "ZZZZZZZZZZZZZZZZZZ"));
                  GXUtil.WriteLog("br_procedure:[SecurityCheckFailed value for]"+"Insert_BR_EncounterID:"+context.localUtil.Format( (decimal)(AV10Insert_BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ"));
                  GXUtil.WriteLog("br_procedure:[SecurityCheckFailed value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
                  GXUtil.WriteLog("br_procedure:[SecurityCheckFailed value for]"+"BR_Procedure_PXID:"+context.localUtil.Format( (decimal)(A140BR_Procedure_PXID), "ZZZZZZZZZZ"));
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
                  A139BR_ProcedureID = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A139BR_ProcedureID", StringUtil.LTrim( StringUtil.Str( (decimal)(A139BR_ProcedureID), 18, 0)));
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
                     sMode19 = Gx_mode;
                     Gx_mode = "UPD";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     Gx_mode = sMode19;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound19 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_0I0( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtntrn_enter_Internalname;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert", ""), 1, "BR_PROCEDUREID");
                        AnyError = 1;
                        GX_FocusControl = edtBR_ProcedureID_Internalname;
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
                           E110I2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: After Trn */
                           E120I2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "'DOTEST'") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: 'Dotest' */
                           E130I2 ();
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
            E120I2 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll0I19( ) ;
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
            DisableAttributes0I19( ) ;
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

      protected void CONFIRM_0I0( )
      {
         BeforeValidate0I19( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0I19( ) ;
            }
            else
            {
               CheckExtendedTable0I19( ) ;
               CloseExtendedTableCursors0I19( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         }
      }

      protected void ResetCaption0I0( )
      {
      }

      protected void E110I2( )
      {
         /* Start Routine */
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV7WWPContext) ;
         AV13IsAuthorized = true;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13IsAuthorized", AV13IsAuthorized);
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            GXt_boolean1 = AV13IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Procedure", out  GXt_boolean1) ;
            AV13IsAuthorized = GXt_boolean1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13IsAuthorized", AV13IsAuthorized);
         }
         if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
         {
            GXt_boolean1 = AV13IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Procedure", out  GXt_boolean1) ;
            AV13IsAuthorized = GXt_boolean1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13IsAuthorized", AV13IsAuthorized);
         }
         if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
         {
            GXt_boolean1 = AV13IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Procedure", out  GXt_boolean1) ;
            AV13IsAuthorized = GXt_boolean1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13IsAuthorized", AV13IsAuthorized);
         }
         if ( ! AV13IsAuthorized )
         {
            CallWebObject(formatLink("wwpbaseobjects.notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV20Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         /* Execute user subroutine: 'ATTRIBUTESSECURITYCODE' */
         S112 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         AV8TrnContext.FromXml(AV9WebSession.Get("TrnContext"), null, "WWPTransactionContext", "DataAnalysisPlatform");
         if ( ( StringUtil.StrCmp(AV8TrnContext.gxTpr_Transactionname, AV20Pgmname) == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) )
         {
            AV21GXV1 = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21GXV1), 8, 0)));
            while ( AV21GXV1 <= AV8TrnContext.gxTpr_Attributes.Count )
            {
               AV11TrnContextAtt = ((GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute)AV8TrnContext.gxTpr_Attributes.Item(AV21GXV1));
               if ( StringUtil.StrCmp(AV11TrnContextAtt.gxTpr_Attributename, "BR_EncounterID") == 0 )
               {
                  AV10Insert_BR_EncounterID = (long)(NumberUtil.Val( AV11TrnContextAtt.gxTpr_Attributevalue, "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10Insert_BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10Insert_BR_EncounterID), 18, 0)));
               }
               AV21GXV1 = (int)(AV21GXV1+1);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21GXV1), 8, 0)));
            }
         }
         edtBR_ProcedureID_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_ProcedureID_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_ProcedureID_Visible), 5, 0)), true);
         edtBR_EncounterID_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_EncounterID_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_EncounterID_Visible), 5, 0)), true);
         edtBR_Information_PatientNo_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Information_PatientNo_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Information_PatientNo_Visible), 5, 0)), true);
         GXt_boolean1 = AV15TempBoolean;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Procedure", out  GXt_boolean1) ;
         AV15TempBoolean = GXt_boolean1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15TempBoolean", AV15TempBoolean);
         if ( ! ( AV15TempBoolean ) )
         {
            bttBtntrn_enter_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_enter_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_enter_Visible), 5, 0)), true);
         }
         GXt_boolean1 = AV15TempBoolean;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Procedure", out  GXt_boolean1) ;
         AV15TempBoolean = GXt_boolean1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15TempBoolean", AV15TempBoolean);
         if ( ! ( AV15TempBoolean ) )
         {
            bttBtntrn_cancel_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_cancel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_cancel_Visible), 5, 0)), true);
         }
         GXt_boolean1 = AV15TempBoolean;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Procedure", out  GXt_boolean1) ;
         AV15TempBoolean = GXt_boolean1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15TempBoolean", AV15TempBoolean);
         if ( ! ( AV15TempBoolean ) )
         {
            bttBtntrn_delete_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_delete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_delete_Visible), 5, 0)), true);
         }
      }

      protected void E120I2( )
      {
         /* After Trn Routine */
         if ( 1 == 0 )
         {
            if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV8TrnContext.gxTpr_Callerondelete )
            {
               CallWebObject(formatLink("br_procedureww.aspx") );
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
            CallWebObject(formatLink("br_procedureview.aspx") + "?" + UrlEncode("" +A139BR_ProcedureID) + "," + UrlEncode(StringUtil.RTrim("General")));
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
         divBr_procedure_pxsurgery_cell_Class = "col-xs-12 col-sm-6 RequiredDataContentCell";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, divBr_procedure_pxsurgery_cell_Internalname, "Class", divBr_procedure_pxsurgery_cell_Class, true);
         divBr_procedure_pxradiotherapy_cell_Class = "col-xs-12 col-sm-6 RequiredDataContentCell";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, divBr_procedure_pxradiotherapy_cell_Internalname, "Class", divBr_procedure_pxradiotherapy_cell_Class, true);
         divUnnamedtable1_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, divUnnamedtable1_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divUnnamedtable1_Visible), 5, 0)), true);
         divUnnamedtable2_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, divUnnamedtable2_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divUnnamedtable2_Visible), 5, 0)), true);
      }

      protected void E130I2( )
      {
         /* 'Dotest' Routine */
      }

      protected void ZM0I19( short GX_JID )
      {
         if ( ( GX_JID == 33 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z497BR_Procedure_PXSurgery_Code = T000I3_A497BR_Procedure_PXSurgery_Code[0];
               Z498BR_Procedure_PXRadiotherapy_Code = T000I3_A498BR_Procedure_PXRadiotherapy_Code[0];
               Z140BR_Procedure_PXID = T000I3_A140BR_Procedure_PXID[0];
               Z141BR_Procedure_PXSurgery = T000I3_A141BR_Procedure_PXSurgery[0];
               Z266BR_Procedure_Date = T000I3_A266BR_Procedure_Date[0];
               Z143BR_Procedure_PXRadiotherapy = T000I3_A143BR_Procedure_PXRadiotherapy[0];
               Z268BR_Procedure_RadioDate = T000I3_A268BR_Procedure_RadioDate[0];
               Z269BR_Procedure_RadioTime = T000I3_A269BR_Procedure_RadioTime[0];
               Z19BR_EncounterID = T000I3_A19BR_EncounterID[0];
            }
            else
            {
               Z497BR_Procedure_PXSurgery_Code = A497BR_Procedure_PXSurgery_Code;
               Z498BR_Procedure_PXRadiotherapy_Code = A498BR_Procedure_PXRadiotherapy_Code;
               Z140BR_Procedure_PXID = A140BR_Procedure_PXID;
               Z141BR_Procedure_PXSurgery = A141BR_Procedure_PXSurgery;
               Z266BR_Procedure_Date = A266BR_Procedure_Date;
               Z143BR_Procedure_PXRadiotherapy = A143BR_Procedure_PXRadiotherapy;
               Z268BR_Procedure_RadioDate = A268BR_Procedure_RadioDate;
               Z269BR_Procedure_RadioTime = A269BR_Procedure_RadioTime;
               Z19BR_EncounterID = A19BR_EncounterID;
            }
         }
         if ( GX_JID == -33 )
         {
            Z139BR_ProcedureID = A139BR_ProcedureID;
            Z497BR_Procedure_PXSurgery_Code = A497BR_Procedure_PXSurgery_Code;
            Z498BR_Procedure_PXRadiotherapy_Code = A498BR_Procedure_PXRadiotherapy_Code;
            Z140BR_Procedure_PXID = A140BR_Procedure_PXID;
            Z141BR_Procedure_PXSurgery = A141BR_Procedure_PXSurgery;
            Z266BR_Procedure_Date = A266BR_Procedure_Date;
            Z143BR_Procedure_PXRadiotherapy = A143BR_Procedure_PXRadiotherapy;
            Z268BR_Procedure_RadioDate = A268BR_Procedure_RadioDate;
            Z269BR_Procedure_RadioTime = A269BR_Procedure_RadioTime;
            Z19BR_EncounterID = A19BR_EncounterID;
            Z85BR_Information_ID = A85BR_Information_ID;
            Z36BR_Information_PatientNo = A36BR_Information_PatientNo;
         }
      }

      protected void standaloneNotModal( )
      {
         edtBR_ProcedureID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_ProcedureID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_ProcedureID_Enabled), 5, 0)), true);
         edtBR_ProcedureID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_ProcedureID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_ProcedureID_Enabled), 5, 0)), true);
         bttBtntrn_delete_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_delete_Enabled), 5, 0)), true);
         if ( ! (0==AV12BR_ProcedureID) )
         {
            A139BR_ProcedureID = AV12BR_ProcedureID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A139BR_ProcedureID", StringUtil.LTrim( StringUtil.Str( (decimal)(A139BR_ProcedureID), 18, 0)));
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
            AV20Pgmname = "BR_Procedure";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20Pgmname", AV20Pgmname);
            /* Using cursor T000I4 */
            pr_default.execute(2, new Object[] {n19BR_EncounterID, A19BR_EncounterID});
            A85BR_Information_ID = T000I4_A85BR_Information_ID[0];
            n85BR_Information_ID = T000I4_n85BR_Information_ID[0];
            pr_default.close(2);
            /* Using cursor T000I5 */
            pr_default.execute(3, new Object[] {n85BR_Information_ID, A85BR_Information_ID});
            A36BR_Information_PatientNo = T000I5_A36BR_Information_PatientNo[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36BR_Information_PatientNo", A36BR_Information_PatientNo);
            n36BR_Information_PatientNo = T000I5_n36BR_Information_PatientNo[0];
            pr_default.close(3);
         }
      }

      protected void Load0I19( )
      {
         /* Using cursor T000I6 */
         pr_default.execute(4, new Object[] {A139BR_ProcedureID});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound19 = 1;
            A85BR_Information_ID = T000I6_A85BR_Information_ID[0];
            n85BR_Information_ID = T000I6_n85BR_Information_ID[0];
            A497BR_Procedure_PXSurgery_Code = T000I6_A497BR_Procedure_PXSurgery_Code[0];
            n497BR_Procedure_PXSurgery_Code = T000I6_n497BR_Procedure_PXSurgery_Code[0];
            A498BR_Procedure_PXRadiotherapy_Code = T000I6_A498BR_Procedure_PXRadiotherapy_Code[0];
            n498BR_Procedure_PXRadiotherapy_Code = T000I6_n498BR_Procedure_PXRadiotherapy_Code[0];
            A36BR_Information_PatientNo = T000I6_A36BR_Information_PatientNo[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36BR_Information_PatientNo", A36BR_Information_PatientNo);
            n36BR_Information_PatientNo = T000I6_n36BR_Information_PatientNo[0];
            A140BR_Procedure_PXID = T000I6_A140BR_Procedure_PXID[0];
            n140BR_Procedure_PXID = T000I6_n140BR_Procedure_PXID[0];
            A141BR_Procedure_PXSurgery = T000I6_A141BR_Procedure_PXSurgery[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A141BR_Procedure_PXSurgery", A141BR_Procedure_PXSurgery);
            n141BR_Procedure_PXSurgery = T000I6_n141BR_Procedure_PXSurgery[0];
            A266BR_Procedure_Date = T000I6_A266BR_Procedure_Date[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A266BR_Procedure_Date", context.localUtil.Format(A266BR_Procedure_Date, "9999/99/99"));
            n266BR_Procedure_Date = T000I6_n266BR_Procedure_Date[0];
            A143BR_Procedure_PXRadiotherapy = T000I6_A143BR_Procedure_PXRadiotherapy[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A143BR_Procedure_PXRadiotherapy", A143BR_Procedure_PXRadiotherapy);
            n143BR_Procedure_PXRadiotherapy = T000I6_n143BR_Procedure_PXRadiotherapy[0];
            A268BR_Procedure_RadioDate = T000I6_A268BR_Procedure_RadioDate[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A268BR_Procedure_RadioDate", context.localUtil.Format(A268BR_Procedure_RadioDate, "9999/99/99"));
            n268BR_Procedure_RadioDate = T000I6_n268BR_Procedure_RadioDate[0];
            A269BR_Procedure_RadioTime = T000I6_A269BR_Procedure_RadioTime[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A269BR_Procedure_RadioTime", StringUtil.LTrim( StringUtil.Str( A269BR_Procedure_RadioTime, 15, 5)));
            n269BR_Procedure_RadioTime = T000I6_n269BR_Procedure_RadioTime[0];
            A19BR_EncounterID = T000I6_A19BR_EncounterID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
            n19BR_EncounterID = T000I6_n19BR_EncounterID[0];
            ZM0I19( -33) ;
         }
         pr_default.close(4);
         OnLoadActions0I19( ) ;
      }

      protected void OnLoadActions0I19( )
      {
         AV20Pgmname = "BR_Procedure";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20Pgmname", AV20Pgmname);
         cmbBR_Procedure_PXRadiotherapy.Visible = ((StringUtil.StrCmp(A141BR_Procedure_PXSurgery, "否")==0) ? 1 : 0);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Procedure_PXRadiotherapy_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbBR_Procedure_PXRadiotherapy.Visible), 5, 0)), true);
         if ( ! ( ( StringUtil.StrCmp(A141BR_Procedure_PXSurgery, "否") == 0 ) ) )
         {
            divBr_procedure_pxradiotherapy_cell_Class = "Invisible";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divBr_procedure_pxradiotherapy_cell_Internalname, "Class", divBr_procedure_pxradiotherapy_cell_Class, true);
         }
         else
         {
            if ( StringUtil.StrCmp(A141BR_Procedure_PXSurgery, "否") == 0 )
            {
               divBr_procedure_pxradiotherapy_cell_Class = "col-xs-12 col-sm-6 RequiredDataContentCell";
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, divBr_procedure_pxradiotherapy_cell_Internalname, "Class", divBr_procedure_pxradiotherapy_cell_Class, true);
            }
         }
         divUnnamedtable1_Visible = (((StringUtil.StrCmp(A141BR_Procedure_PXSurgery, "是")==0)) ? 1 : 0);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, divUnnamedtable1_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divUnnamedtable1_Visible), 5, 0)), true);
         cmbBR_Procedure_PXSurgery.Visible = ((StringUtil.StrCmp(A143BR_Procedure_PXRadiotherapy, "否")==0) ? 1 : 0);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Procedure_PXSurgery_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbBR_Procedure_PXSurgery.Visible), 5, 0)), true);
         if ( ! ( ( StringUtil.StrCmp(A143BR_Procedure_PXRadiotherapy, "否") == 0 ) ) )
         {
            divBr_procedure_pxsurgery_cell_Class = "Invisible";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divBr_procedure_pxsurgery_cell_Internalname, "Class", divBr_procedure_pxsurgery_cell_Class, true);
         }
         else
         {
            if ( StringUtil.StrCmp(A143BR_Procedure_PXRadiotherapy, "否") == 0 )
            {
               divBr_procedure_pxsurgery_cell_Class = "col-xs-12 col-sm-6 RequiredDataContentCell";
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, divBr_procedure_pxsurgery_cell_Internalname, "Class", divBr_procedure_pxsurgery_cell_Class, true);
            }
         }
         divUnnamedtable2_Visible = (((StringUtil.StrCmp(A143BR_Procedure_PXRadiotherapy, "是")==0)) ? 1 : 0);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, divUnnamedtable2_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divUnnamedtable2_Visible), 5, 0)), true);
      }

      protected void CheckExtendedTable0I19( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
         AV20Pgmname = "BR_Procedure";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20Pgmname", AV20Pgmname);
         /* Using cursor T000I4 */
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
         A85BR_Information_ID = T000I4_A85BR_Information_ID[0];
         n85BR_Information_ID = T000I4_n85BR_Information_ID[0];
         pr_default.close(2);
         /* Using cursor T000I5 */
         pr_default.execute(3, new Object[] {n85BR_Information_ID, A85BR_Information_ID});
         if ( (pr_default.getStatus(3) == 101) )
         {
            if ( ! ( (0==A85BR_Information_ID) ) )
            {
               GX_msglist.addItem("不匹配' T16'", "ForeignKeyNotFound", 1, "");
               AnyError = 1;
            }
         }
         A36BR_Information_PatientNo = T000I5_A36BR_Information_PatientNo[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36BR_Information_PatientNo", A36BR_Information_PatientNo);
         n36BR_Information_PatientNo = T000I5_n36BR_Information_PatientNo[0];
         pr_default.close(3);
         if ( ! ( ( StringUtil.StrCmp(A141BR_Procedure_PXSurgery, "否") == 0 ) || ( StringUtil.StrCmp(A141BR_Procedure_PXSurgery, "是") == 0 ) || ( StringUtil.StrCmp(A141BR_Procedure_PXSurgery, "不详") == 0 ) || String.IsNullOrEmpty(StringUtil.RTrim( A141BR_Procedure_PXSurgery)) ) )
         {
            GX_msglist.addItem("域������������超界", "OutOfRange", 1, "BR_PROCEDURE_PXSURGERY");
            AnyError = 1;
            GX_FocusControl = cmbBR_Procedure_PXSurgery_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         cmbBR_Procedure_PXRadiotherapy.Visible = ((StringUtil.StrCmp(A141BR_Procedure_PXSurgery, "否")==0) ? 1 : 0);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Procedure_PXRadiotherapy_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbBR_Procedure_PXRadiotherapy.Visible), 5, 0)), true);
         if ( ! ( ( StringUtil.StrCmp(A141BR_Procedure_PXSurgery, "否") == 0 ) ) )
         {
            divBr_procedure_pxradiotherapy_cell_Class = "Invisible";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divBr_procedure_pxradiotherapy_cell_Internalname, "Class", divBr_procedure_pxradiotherapy_cell_Class, true);
         }
         else
         {
            if ( StringUtil.StrCmp(A141BR_Procedure_PXSurgery, "否") == 0 )
            {
               divBr_procedure_pxradiotherapy_cell_Class = "col-xs-12 col-sm-6 RequiredDataContentCell";
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, divBr_procedure_pxradiotherapy_cell_Internalname, "Class", divBr_procedure_pxradiotherapy_cell_Class, true);
            }
         }
         divUnnamedtable1_Visible = (((StringUtil.StrCmp(A141BR_Procedure_PXSurgery, "是")==0)) ? 1 : 0);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, divUnnamedtable1_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divUnnamedtable1_Visible), 5, 0)), true);
         if ( String.IsNullOrEmpty(StringUtil.RTrim( A141BR_Procedure_PXSurgery)) )
         {
            GX_msglist.addItem("是否手术是必须填写的。", 1, "BR_PROCEDURE_PXSURGERY");
            AnyError = 1;
            GX_FocusControl = cmbBR_Procedure_PXSurgery_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ! ( (DateTime.MinValue==A266BR_Procedure_Date) || ( A266BR_Procedure_Date >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("域������������超界", "OutOfRange", 1, "BR_PROCEDURE_DATE");
            AnyError = 1;
            GX_FocusControl = edtBR_Procedure_Date_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ! ( ( StringUtil.StrCmp(A143BR_Procedure_PXRadiotherapy, "否") == 0 ) || ( StringUtil.StrCmp(A143BR_Procedure_PXRadiotherapy, "是") == 0 ) || ( StringUtil.StrCmp(A143BR_Procedure_PXRadiotherapy, "不详") == 0 ) || String.IsNullOrEmpty(StringUtil.RTrim( A143BR_Procedure_PXRadiotherapy)) ) )
         {
            GX_msglist.addItem("域������������������������超界", "OutOfRange", 1, "BR_PROCEDURE_PXRADIOTHERAPY");
            AnyError = 1;
            GX_FocusControl = cmbBR_Procedure_PXRadiotherapy_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         cmbBR_Procedure_PXSurgery.Visible = ((StringUtil.StrCmp(A143BR_Procedure_PXRadiotherapy, "否")==0) ? 1 : 0);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Procedure_PXSurgery_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbBR_Procedure_PXSurgery.Visible), 5, 0)), true);
         if ( ! ( ( StringUtil.StrCmp(A143BR_Procedure_PXRadiotherapy, "否") == 0 ) ) )
         {
            divBr_procedure_pxsurgery_cell_Class = "Invisible";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divBr_procedure_pxsurgery_cell_Internalname, "Class", divBr_procedure_pxsurgery_cell_Class, true);
         }
         else
         {
            if ( StringUtil.StrCmp(A143BR_Procedure_PXRadiotherapy, "否") == 0 )
            {
               divBr_procedure_pxsurgery_cell_Class = "col-xs-12 col-sm-6 RequiredDataContentCell";
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, divBr_procedure_pxsurgery_cell_Internalname, "Class", divBr_procedure_pxsurgery_cell_Class, true);
            }
         }
         divUnnamedtable2_Visible = (((StringUtil.StrCmp(A143BR_Procedure_PXRadiotherapy, "是")==0)) ? 1 : 0);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, divUnnamedtable2_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divUnnamedtable2_Visible), 5, 0)), true);
         if ( String.IsNullOrEmpty(StringUtil.RTrim( A143BR_Procedure_PXRadiotherapy)) )
         {
            GX_msglist.addItem("是否接受放射疗法是必须填写的。", 1, "BR_PROCEDURE_PXRADIOTHERAPY");
            AnyError = 1;
            GX_FocusControl = cmbBR_Procedure_PXRadiotherapy_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ! ( (DateTime.MinValue==A268BR_Procedure_RadioDate) || ( A268BR_Procedure_RadioDate >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("域������������超界", "OutOfRange", 1, "BR_PROCEDURE_RADIODATE");
            AnyError = 1;
            GX_FocusControl = edtBR_Procedure_RadioDate_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
      }

      protected void CloseExtendedTableCursors0I19( )
      {
         pr_default.close(2);
         pr_default.close(3);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_34( long A19BR_EncounterID )
      {
         /* Using cursor T000I7 */
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
         A85BR_Information_ID = T000I7_A85BR_Information_ID[0];
         n85BR_Information_ID = T000I7_n85BR_Information_ID[0];
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

      protected void gxLoad_35( long A85BR_Information_ID )
      {
         /* Using cursor T000I8 */
         pr_default.execute(6, new Object[] {n85BR_Information_ID, A85BR_Information_ID});
         if ( (pr_default.getStatus(6) == 101) )
         {
            if ( ! ( (0==A85BR_Information_ID) ) )
            {
               GX_msglist.addItem("不匹配' T16'", "ForeignKeyNotFound", 1, "");
               AnyError = 1;
            }
         }
         A36BR_Information_PatientNo = T000I8_A36BR_Information_PatientNo[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36BR_Information_PatientNo", A36BR_Information_PatientNo);
         n36BR_Information_PatientNo = T000I8_n36BR_Information_PatientNo[0];
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

      protected void GetKey0I19( )
      {
         /* Using cursor T000I9 */
         pr_default.execute(7, new Object[] {A139BR_ProcedureID});
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound19 = 1;
         }
         else
         {
            RcdFound19 = 0;
         }
         pr_default.close(7);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T000I3 */
         pr_default.execute(1, new Object[] {A139BR_ProcedureID});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0I19( 33) ;
            RcdFound19 = 1;
            A139BR_ProcedureID = T000I3_A139BR_ProcedureID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A139BR_ProcedureID", StringUtil.LTrim( StringUtil.Str( (decimal)(A139BR_ProcedureID), 18, 0)));
            A497BR_Procedure_PXSurgery_Code = T000I3_A497BR_Procedure_PXSurgery_Code[0];
            n497BR_Procedure_PXSurgery_Code = T000I3_n497BR_Procedure_PXSurgery_Code[0];
            A498BR_Procedure_PXRadiotherapy_Code = T000I3_A498BR_Procedure_PXRadiotherapy_Code[0];
            n498BR_Procedure_PXRadiotherapy_Code = T000I3_n498BR_Procedure_PXRadiotherapy_Code[0];
            A140BR_Procedure_PXID = T000I3_A140BR_Procedure_PXID[0];
            n140BR_Procedure_PXID = T000I3_n140BR_Procedure_PXID[0];
            A141BR_Procedure_PXSurgery = T000I3_A141BR_Procedure_PXSurgery[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A141BR_Procedure_PXSurgery", A141BR_Procedure_PXSurgery);
            n141BR_Procedure_PXSurgery = T000I3_n141BR_Procedure_PXSurgery[0];
            A266BR_Procedure_Date = T000I3_A266BR_Procedure_Date[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A266BR_Procedure_Date", context.localUtil.Format(A266BR_Procedure_Date, "9999/99/99"));
            n266BR_Procedure_Date = T000I3_n266BR_Procedure_Date[0];
            A143BR_Procedure_PXRadiotherapy = T000I3_A143BR_Procedure_PXRadiotherapy[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A143BR_Procedure_PXRadiotherapy", A143BR_Procedure_PXRadiotherapy);
            n143BR_Procedure_PXRadiotherapy = T000I3_n143BR_Procedure_PXRadiotherapy[0];
            A268BR_Procedure_RadioDate = T000I3_A268BR_Procedure_RadioDate[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A268BR_Procedure_RadioDate", context.localUtil.Format(A268BR_Procedure_RadioDate, "9999/99/99"));
            n268BR_Procedure_RadioDate = T000I3_n268BR_Procedure_RadioDate[0];
            A269BR_Procedure_RadioTime = T000I3_A269BR_Procedure_RadioTime[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A269BR_Procedure_RadioTime", StringUtil.LTrim( StringUtil.Str( A269BR_Procedure_RadioTime, 15, 5)));
            n269BR_Procedure_RadioTime = T000I3_n269BR_Procedure_RadioTime[0];
            A19BR_EncounterID = T000I3_A19BR_EncounterID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
            n19BR_EncounterID = T000I3_n19BR_EncounterID[0];
            Z139BR_ProcedureID = A139BR_ProcedureID;
            sMode19 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load0I19( ) ;
            if ( AnyError == 1 )
            {
               RcdFound19 = 0;
               InitializeNonKey0I19( ) ;
            }
            Gx_mode = sMode19;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound19 = 0;
            InitializeNonKey0I19( ) ;
            sMode19 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal( ) ;
            Gx_mode = sMode19;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0I19( ) ;
         if ( RcdFound19 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound19 = 0;
         /* Using cursor T000I10 */
         pr_default.execute(8, new Object[] {A139BR_ProcedureID});
         if ( (pr_default.getStatus(8) != 101) )
         {
            while ( (pr_default.getStatus(8) != 101) && ( ( T000I10_A139BR_ProcedureID[0] < A139BR_ProcedureID ) ) )
            {
               pr_default.readNext(8);
            }
            if ( (pr_default.getStatus(8) != 101) && ( ( T000I10_A139BR_ProcedureID[0] > A139BR_ProcedureID ) ) )
            {
               A139BR_ProcedureID = T000I10_A139BR_ProcedureID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A139BR_ProcedureID", StringUtil.LTrim( StringUtil.Str( (decimal)(A139BR_ProcedureID), 18, 0)));
               RcdFound19 = 1;
            }
         }
         pr_default.close(8);
      }

      protected void move_previous( )
      {
         RcdFound19 = 0;
         /* Using cursor T000I11 */
         pr_default.execute(9, new Object[] {A139BR_ProcedureID});
         if ( (pr_default.getStatus(9) != 101) )
         {
            while ( (pr_default.getStatus(9) != 101) && ( ( T000I11_A139BR_ProcedureID[0] > A139BR_ProcedureID ) ) )
            {
               pr_default.readNext(9);
            }
            if ( (pr_default.getStatus(9) != 101) && ( ( T000I11_A139BR_ProcedureID[0] < A139BR_ProcedureID ) ) )
            {
               A139BR_ProcedureID = T000I11_A139BR_ProcedureID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A139BR_ProcedureID", StringUtil.LTrim( StringUtil.Str( (decimal)(A139BR_ProcedureID), 18, 0)));
               RcdFound19 = 1;
            }
         }
         pr_default.close(9);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey0I19( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = cmbBR_Procedure_PXSurgery_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert0I19( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound19 == 1 )
            {
               if ( A139BR_ProcedureID != Z139BR_ProcedureID )
               {
                  A139BR_ProcedureID = Z139BR_ProcedureID;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A139BR_ProcedureID", StringUtil.LTrim( StringUtil.Str( (decimal)(A139BR_ProcedureID), 18, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "BR_PROCEDUREID");
                  AnyError = 1;
                  GX_FocusControl = edtBR_ProcedureID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = cmbBR_Procedure_PXSurgery_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Update record */
                  Update0I19( ) ;
                  GX_FocusControl = cmbBR_Procedure_PXSurgery_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A139BR_ProcedureID != Z139BR_ProcedureID )
               {
                  /* Insert record */
                  GX_FocusControl = cmbBR_Procedure_PXSurgery_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert0I19( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "BR_PROCEDUREID");
                     AnyError = 1;
                     GX_FocusControl = edtBR_ProcedureID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     /* Insert record */
                     GX_FocusControl = cmbBR_Procedure_PXSurgery_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert0I19( ) ;
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
         if ( A139BR_ProcedureID != Z139BR_ProcedureID )
         {
            A139BR_ProcedureID = Z139BR_ProcedureID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A139BR_ProcedureID", StringUtil.LTrim( StringUtil.Str( (decimal)(A139BR_ProcedureID), 18, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "BR_PROCEDUREID");
            AnyError = 1;
            GX_FocusControl = edtBR_ProcedureID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = cmbBR_Procedure_PXSurgery_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency0I19( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000I2 */
            pr_default.execute(0, new Object[] {A139BR_ProcedureID});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BR_Procedure"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z497BR_Procedure_PXSurgery_Code, T000I2_A497BR_Procedure_PXSurgery_Code[0]) != 0 ) || ( StringUtil.StrCmp(Z498BR_Procedure_PXRadiotherapy_Code, T000I2_A498BR_Procedure_PXRadiotherapy_Code[0]) != 0 ) || ( Z140BR_Procedure_PXID != T000I2_A140BR_Procedure_PXID[0] ) || ( StringUtil.StrCmp(Z141BR_Procedure_PXSurgery, T000I2_A141BR_Procedure_PXSurgery[0]) != 0 ) || ( Z266BR_Procedure_Date != T000I2_A266BR_Procedure_Date[0] ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z143BR_Procedure_PXRadiotherapy, T000I2_A143BR_Procedure_PXRadiotherapy[0]) != 0 ) || ( Z268BR_Procedure_RadioDate != T000I2_A268BR_Procedure_RadioDate[0] ) || ( Z269BR_Procedure_RadioTime != T000I2_A269BR_Procedure_RadioTime[0] ) || ( Z19BR_EncounterID != T000I2_A19BR_EncounterID[0] ) )
            {
               if ( StringUtil.StrCmp(Z497BR_Procedure_PXSurgery_Code, T000I2_A497BR_Procedure_PXSurgery_Code[0]) != 0 )
               {
                  GXUtil.WriteLog("br_procedure:[seudo value changed for attri]"+"BR_Procedure_PXSurgery_Code");
                  GXUtil.WriteLogRaw("Old: ",Z497BR_Procedure_PXSurgery_Code);
                  GXUtil.WriteLogRaw("Current: ",T000I2_A497BR_Procedure_PXSurgery_Code[0]);
               }
               if ( StringUtil.StrCmp(Z498BR_Procedure_PXRadiotherapy_Code, T000I2_A498BR_Procedure_PXRadiotherapy_Code[0]) != 0 )
               {
                  GXUtil.WriteLog("br_procedure:[seudo value changed for attri]"+"BR_Procedure_PXRadiotherapy_Code");
                  GXUtil.WriteLogRaw("Old: ",Z498BR_Procedure_PXRadiotherapy_Code);
                  GXUtil.WriteLogRaw("Current: ",T000I2_A498BR_Procedure_PXRadiotherapy_Code[0]);
               }
               if ( Z140BR_Procedure_PXID != T000I2_A140BR_Procedure_PXID[0] )
               {
                  GXUtil.WriteLog("br_procedure:[seudo value changed for attri]"+"BR_Procedure_PXID");
                  GXUtil.WriteLogRaw("Old: ",Z140BR_Procedure_PXID);
                  GXUtil.WriteLogRaw("Current: ",T000I2_A140BR_Procedure_PXID[0]);
               }
               if ( StringUtil.StrCmp(Z141BR_Procedure_PXSurgery, T000I2_A141BR_Procedure_PXSurgery[0]) != 0 )
               {
                  GXUtil.WriteLog("br_procedure:[seudo value changed for attri]"+"BR_Procedure_PXSurgery");
                  GXUtil.WriteLogRaw("Old: ",Z141BR_Procedure_PXSurgery);
                  GXUtil.WriteLogRaw("Current: ",T000I2_A141BR_Procedure_PXSurgery[0]);
               }
               if ( Z266BR_Procedure_Date != T000I2_A266BR_Procedure_Date[0] )
               {
                  GXUtil.WriteLog("br_procedure:[seudo value changed for attri]"+"BR_Procedure_Date");
                  GXUtil.WriteLogRaw("Old: ",Z266BR_Procedure_Date);
                  GXUtil.WriteLogRaw("Current: ",T000I2_A266BR_Procedure_Date[0]);
               }
               if ( StringUtil.StrCmp(Z143BR_Procedure_PXRadiotherapy, T000I2_A143BR_Procedure_PXRadiotherapy[0]) != 0 )
               {
                  GXUtil.WriteLog("br_procedure:[seudo value changed for attri]"+"BR_Procedure_PXRadiotherapy");
                  GXUtil.WriteLogRaw("Old: ",Z143BR_Procedure_PXRadiotherapy);
                  GXUtil.WriteLogRaw("Current: ",T000I2_A143BR_Procedure_PXRadiotherapy[0]);
               }
               if ( Z268BR_Procedure_RadioDate != T000I2_A268BR_Procedure_RadioDate[0] )
               {
                  GXUtil.WriteLog("br_procedure:[seudo value changed for attri]"+"BR_Procedure_RadioDate");
                  GXUtil.WriteLogRaw("Old: ",Z268BR_Procedure_RadioDate);
                  GXUtil.WriteLogRaw("Current: ",T000I2_A268BR_Procedure_RadioDate[0]);
               }
               if ( Z269BR_Procedure_RadioTime != T000I2_A269BR_Procedure_RadioTime[0] )
               {
                  GXUtil.WriteLog("br_procedure:[seudo value changed for attri]"+"BR_Procedure_RadioTime");
                  GXUtil.WriteLogRaw("Old: ",Z269BR_Procedure_RadioTime);
                  GXUtil.WriteLogRaw("Current: ",T000I2_A269BR_Procedure_RadioTime[0]);
               }
               if ( Z19BR_EncounterID != T000I2_A19BR_EncounterID[0] )
               {
                  GXUtil.WriteLog("br_procedure:[seudo value changed for attri]"+"BR_EncounterID");
                  GXUtil.WriteLogRaw("Old: ",Z19BR_EncounterID);
                  GXUtil.WriteLogRaw("Current: ",T000I2_A19BR_EncounterID[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"BR_Procedure"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0I19( )
      {
         BeforeValidate0I19( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0I19( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0I19( 0) ;
            CheckOptimisticConcurrency0I19( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0I19( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0I19( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000I12 */
                     pr_default.execute(10, new Object[] {n497BR_Procedure_PXSurgery_Code, A497BR_Procedure_PXSurgery_Code, n498BR_Procedure_PXRadiotherapy_Code, A498BR_Procedure_PXRadiotherapy_Code, n140BR_Procedure_PXID, A140BR_Procedure_PXID, n141BR_Procedure_PXSurgery, A141BR_Procedure_PXSurgery, n266BR_Procedure_Date, A266BR_Procedure_Date, n143BR_Procedure_PXRadiotherapy, A143BR_Procedure_PXRadiotherapy, n268BR_Procedure_RadioDate, A268BR_Procedure_RadioDate, n269BR_Procedure_RadioTime, A269BR_Procedure_RadioTime, n19BR_EncounterID, A19BR_EncounterID});
                     A139BR_ProcedureID = T000I12_A139BR_ProcedureID[0];
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A139BR_ProcedureID", StringUtil.LTrim( StringUtil.Str( (decimal)(A139BR_ProcedureID), 18, 0)));
                     pr_default.close(10);
                     dsDefault.SmartCacheProvider.SetUpdated("BR_Procedure") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)),  "就诊信息",  StringUtil.Trim( StringUtil.Str( (decimal)(A139BR_ProcedureID), 18, 0)),  "诊疗处理",  "Create",  1) ;
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                           ResetCaption0I0( ) ;
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
               Load0I19( ) ;
            }
            EndLevel0I19( ) ;
         }
         CloseExtendedTableCursors0I19( ) ;
      }

      protected void Update0I19( )
      {
         BeforeValidate0I19( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0I19( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0I19( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0I19( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0I19( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000I13 */
                     pr_default.execute(11, new Object[] {n497BR_Procedure_PXSurgery_Code, A497BR_Procedure_PXSurgery_Code, n498BR_Procedure_PXRadiotherapy_Code, A498BR_Procedure_PXRadiotherapy_Code, n140BR_Procedure_PXID, A140BR_Procedure_PXID, n141BR_Procedure_PXSurgery, A141BR_Procedure_PXSurgery, n266BR_Procedure_Date, A266BR_Procedure_Date, n143BR_Procedure_PXRadiotherapy, A143BR_Procedure_PXRadiotherapy, n268BR_Procedure_RadioDate, A268BR_Procedure_RadioDate, n269BR_Procedure_RadioTime, A269BR_Procedure_RadioTime, n19BR_EncounterID, A19BR_EncounterID, A139BR_ProcedureID});
                     pr_default.close(11);
                     dsDefault.SmartCacheProvider.SetUpdated("BR_Procedure") ;
                     if ( (pr_default.getStatus(11) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BR_Procedure"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0I19( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)),  "就诊信息",  StringUtil.Trim( StringUtil.Str( (decimal)(A139BR_ProcedureID), 18, 0)),  "诊疗处理",  "Update",  1) ;
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
            EndLevel0I19( ) ;
         }
         CloseExtendedTableCursors0I19( ) ;
      }

      protected void DeferredUpdate0I19( )
      {
      }

      protected void delete( )
      {
         BeforeValidate0I19( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0I19( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0I19( ) ;
            AfterConfirm0I19( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0I19( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000I14 */
                  pr_default.execute(12, new Object[] {A139BR_ProcedureID});
                  pr_default.close(12);
                  dsDefault.SmartCacheProvider.SetUpdated("BR_Procedure") ;
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
         sMode19 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel0I19( ) ;
         Gx_mode = sMode19;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls0I19( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV20Pgmname = "BR_Procedure";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20Pgmname", AV20Pgmname);
            /* Using cursor T000I15 */
            pr_default.execute(13, new Object[] {n19BR_EncounterID, A19BR_EncounterID});
            A85BR_Information_ID = T000I15_A85BR_Information_ID[0];
            n85BR_Information_ID = T000I15_n85BR_Information_ID[0];
            pr_default.close(13);
            /* Using cursor T000I16 */
            pr_default.execute(14, new Object[] {n85BR_Information_ID, A85BR_Information_ID});
            A36BR_Information_PatientNo = T000I16_A36BR_Information_PatientNo[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36BR_Information_PatientNo", A36BR_Information_PatientNo);
            n36BR_Information_PatientNo = T000I16_n36BR_Information_PatientNo[0];
            pr_default.close(14);
            cmbBR_Procedure_PXRadiotherapy.Visible = ((StringUtil.StrCmp(A141BR_Procedure_PXSurgery, "否")==0) ? 1 : 0);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Procedure_PXRadiotherapy_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbBR_Procedure_PXRadiotherapy.Visible), 5, 0)), true);
            if ( ! ( ( StringUtil.StrCmp(A141BR_Procedure_PXSurgery, "否") == 0 ) ) )
            {
               divBr_procedure_pxradiotherapy_cell_Class = "Invisible";
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, divBr_procedure_pxradiotherapy_cell_Internalname, "Class", divBr_procedure_pxradiotherapy_cell_Class, true);
            }
            else
            {
               if ( StringUtil.StrCmp(A141BR_Procedure_PXSurgery, "否") == 0 )
               {
                  divBr_procedure_pxradiotherapy_cell_Class = "col-xs-12 col-sm-6 RequiredDataContentCell";
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, divBr_procedure_pxradiotherapy_cell_Internalname, "Class", divBr_procedure_pxradiotherapy_cell_Class, true);
               }
            }
            divUnnamedtable1_Visible = (((StringUtil.StrCmp(A141BR_Procedure_PXSurgery, "是")==0)) ? 1 : 0);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divUnnamedtable1_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divUnnamedtable1_Visible), 5, 0)), true);
            cmbBR_Procedure_PXSurgery.Visible = ((StringUtil.StrCmp(A143BR_Procedure_PXRadiotherapy, "否")==0) ? 1 : 0);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Procedure_PXSurgery_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbBR_Procedure_PXSurgery.Visible), 5, 0)), true);
            if ( ! ( ( StringUtil.StrCmp(A143BR_Procedure_PXRadiotherapy, "否") == 0 ) ) )
            {
               divBr_procedure_pxsurgery_cell_Class = "Invisible";
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, divBr_procedure_pxsurgery_cell_Internalname, "Class", divBr_procedure_pxsurgery_cell_Class, true);
            }
            else
            {
               if ( StringUtil.StrCmp(A143BR_Procedure_PXRadiotherapy, "否") == 0 )
               {
                  divBr_procedure_pxsurgery_cell_Class = "col-xs-12 col-sm-6 RequiredDataContentCell";
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, divBr_procedure_pxsurgery_cell_Internalname, "Class", divBr_procedure_pxsurgery_cell_Class, true);
               }
            }
            divUnnamedtable2_Visible = (((StringUtil.StrCmp(A143BR_Procedure_PXRadiotherapy, "是")==0)) ? 1 : 0);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, divUnnamedtable2_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(divUnnamedtable2_Visible), 5, 0)), true);
         }
         if ( AnyError == 0 )
         {
            /* Using cursor T000I17 */
            pr_default.execute(15, new Object[] {A139BR_ProcedureID});
            if ( (pr_default.getStatus(15) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {" T38"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(15);
            /* Using cursor T000I18 */
            pr_default.execute(16, new Object[] {A139BR_ProcedureID});
            if ( (pr_default.getStatus(16) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {" T37"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(16);
         }
      }

      protected void EndLevel0I19( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0I19( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(1);
            pr_default.close(13);
            pr_default.close(14);
            context.CommitDataStores("br_procedure",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues0I0( ) ;
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
            context.RollbackDataStores("br_procedure",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart0I19( )
      {
         /* Scan By routine */
         /* Using cursor T000I19 */
         pr_default.execute(17);
         RcdFound19 = 0;
         if ( (pr_default.getStatus(17) != 101) )
         {
            RcdFound19 = 1;
            A139BR_ProcedureID = T000I19_A139BR_ProcedureID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A139BR_ProcedureID", StringUtil.LTrim( StringUtil.Str( (decimal)(A139BR_ProcedureID), 18, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0I19( )
      {
         /* Scan next routine */
         pr_default.readNext(17);
         RcdFound19 = 0;
         if ( (pr_default.getStatus(17) != 101) )
         {
            RcdFound19 = 1;
            A139BR_ProcedureID = T000I19_A139BR_ProcedureID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A139BR_ProcedureID", StringUtil.LTrim( StringUtil.Str( (decimal)(A139BR_ProcedureID), 18, 0)));
         }
      }

      protected void ScanEnd0I19( )
      {
         pr_default.close(17);
      }

      protected void AfterConfirm0I19( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0I19( )
      {
         /* Before Insert Rules */
         GXt_char2 = A497BR_Procedure_PXSurgery_Code;
         new zutil_findtargetcode(context ).execute(  37,  A141BR_Procedure_PXSurgery, out  GXt_char2) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A141BR_Procedure_PXSurgery", A141BR_Procedure_PXSurgery);
         A497BR_Procedure_PXSurgery_Code = GXt_char2;
         n497BR_Procedure_PXSurgery_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A497BR_Procedure_PXSurgery_Code", A497BR_Procedure_PXSurgery_Code);
         GXt_char2 = A498BR_Procedure_PXRadiotherapy_Code;
         new zutil_findtargetcode(context ).execute(  37,  A143BR_Procedure_PXRadiotherapy, out  GXt_char2) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A143BR_Procedure_PXRadiotherapy", A143BR_Procedure_PXRadiotherapy);
         A498BR_Procedure_PXRadiotherapy_Code = GXt_char2;
         n498BR_Procedure_PXRadiotherapy_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A498BR_Procedure_PXRadiotherapy_Code", A498BR_Procedure_PXRadiotherapy_Code);
      }

      protected void BeforeUpdate0I19( )
      {
         /* Before Update Rules */
         if ( StringUtil.StrCmp(A141BR_Procedure_PXSurgery, "否") == 0 )
         {
            A266BR_Procedure_Date = DateTime.MinValue;
            n266BR_Procedure_Date = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A266BR_Procedure_Date", context.localUtil.Format(A266BR_Procedure_Date, "9999/99/99"));
            n266BR_Procedure_Date = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A266BR_Procedure_Date", context.localUtil.Format(A266BR_Procedure_Date, "9999/99/99"));
         }
         else
         {
            if ( StringUtil.StrCmp(A141BR_Procedure_PXSurgery, "不详") == 0 )
            {
               A266BR_Procedure_Date = DateTime.MinValue;
               n266BR_Procedure_Date = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A266BR_Procedure_Date", context.localUtil.Format(A266BR_Procedure_Date, "9999/99/99"));
               n266BR_Procedure_Date = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A266BR_Procedure_Date", context.localUtil.Format(A266BR_Procedure_Date, "9999/99/99"));
            }
         }
         GXt_char2 = A497BR_Procedure_PXSurgery_Code;
         new zutil_findtargetcode(context ).execute(  37,  A141BR_Procedure_PXSurgery, out  GXt_char2) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A141BR_Procedure_PXSurgery", A141BR_Procedure_PXSurgery);
         A497BR_Procedure_PXSurgery_Code = GXt_char2;
         n497BR_Procedure_PXSurgery_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A497BR_Procedure_PXSurgery_Code", A497BR_Procedure_PXSurgery_Code);
         if ( StringUtil.StrCmp(A141BR_Procedure_PXSurgery, "否") == 0 )
         {
            new zbr_deleteproceduresurgery(context ).execute( ) ;
         }
         if ( StringUtil.StrCmp(A141BR_Procedure_PXSurgery, "不详") == 0 )
         {
            new zbr_deleteproceduresurgery(context ).execute( ) ;
         }
         if ( StringUtil.StrCmp(A143BR_Procedure_PXRadiotherapy, "否") == 0 )
         {
            A268BR_Procedure_RadioDate = DateTime.MinValue;
            n268BR_Procedure_RadioDate = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A268BR_Procedure_RadioDate", context.localUtil.Format(A268BR_Procedure_RadioDate, "9999/99/99"));
            n268BR_Procedure_RadioDate = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A268BR_Procedure_RadioDate", context.localUtil.Format(A268BR_Procedure_RadioDate, "9999/99/99"));
         }
         else
         {
            if ( StringUtil.StrCmp(A143BR_Procedure_PXRadiotherapy, "不详") == 0 )
            {
               A268BR_Procedure_RadioDate = DateTime.MinValue;
               n268BR_Procedure_RadioDate = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A268BR_Procedure_RadioDate", context.localUtil.Format(A268BR_Procedure_RadioDate, "9999/99/99"));
               n268BR_Procedure_RadioDate = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A268BR_Procedure_RadioDate", context.localUtil.Format(A268BR_Procedure_RadioDate, "9999/99/99"));
            }
         }
         if ( StringUtil.StrCmp(A143BR_Procedure_PXRadiotherapy, "否") == 0 )
         {
            A269BR_Procedure_RadioTime = 0;
            n269BR_Procedure_RadioTime = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A269BR_Procedure_RadioTime", StringUtil.LTrim( StringUtil.Str( A269BR_Procedure_RadioTime, 15, 5)));
            n269BR_Procedure_RadioTime = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A269BR_Procedure_RadioTime", StringUtil.LTrim( StringUtil.Str( A269BR_Procedure_RadioTime, 15, 5)));
         }
         else
         {
            if ( StringUtil.StrCmp(A143BR_Procedure_PXRadiotherapy, "不详") == 0 )
            {
               A269BR_Procedure_RadioTime = 0;
               n269BR_Procedure_RadioTime = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A269BR_Procedure_RadioTime", StringUtil.LTrim( StringUtil.Str( A269BR_Procedure_RadioTime, 15, 5)));
               n269BR_Procedure_RadioTime = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A269BR_Procedure_RadioTime", StringUtil.LTrim( StringUtil.Str( A269BR_Procedure_RadioTime, 15, 5)));
            }
         }
         GXt_char2 = A498BR_Procedure_PXRadiotherapy_Code;
         new zutil_findtargetcode(context ).execute(  37,  A143BR_Procedure_PXRadiotherapy, out  GXt_char2) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A143BR_Procedure_PXRadiotherapy", A143BR_Procedure_PXRadiotherapy);
         A498BR_Procedure_PXRadiotherapy_Code = GXt_char2;
         n498BR_Procedure_PXRadiotherapy_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A498BR_Procedure_PXRadiotherapy_Code", A498BR_Procedure_PXRadiotherapy_Code);
         if ( StringUtil.StrCmp(A143BR_Procedure_PXRadiotherapy, "否") == 0 )
         {
            new zbr_deleteprocedureradio(context ).execute( ) ;
         }
         if ( StringUtil.StrCmp(A143BR_Procedure_PXRadiotherapy, "不详") == 0 )
         {
            new zbr_deleteprocedureradio(context ).execute( ) ;
         }
      }

      protected void BeforeDelete0I19( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0I19( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0I19( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0I19( )
      {
         cmbBR_Procedure_PXSurgery.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Procedure_PXSurgery_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbBR_Procedure_PXSurgery.Enabled), 5, 0)), true);
         edtBR_Procedure_Date_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Procedure_Date_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Procedure_Date_Enabled), 5, 0)), true);
         cmbBR_Procedure_PXRadiotherapy.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Procedure_PXRadiotherapy_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(cmbBR_Procedure_PXRadiotherapy.Enabled), 5, 0)), true);
         edtBR_Procedure_RadioDate_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Procedure_RadioDate_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Procedure_RadioDate_Enabled), 5, 0)), true);
         edtBR_Procedure_RadioTime_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Procedure_RadioTime_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Procedure_RadioTime_Enabled), 5, 0)), true);
         edtBR_ProcedureID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_ProcedureID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_ProcedureID_Enabled), 5, 0)), true);
         edtBR_EncounterID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_EncounterID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_EncounterID_Enabled), 5, 0)), true);
         edtBR_Information_PatientNo_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Information_PatientNo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Information_PatientNo_Enabled), 5, 0)), true);
      }

      protected void send_integrity_lvl_hashes0I19( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues0I0( )
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
         context.AddJavascriptSource("gxcfg.js", "?202022711575479", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_procedure.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV12BR_ProcedureID)+"\">") ;
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
         forbiddenHiddens = "hsh" + "BR_Procedure";
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A139BR_ProcedureID), "ZZZZZZZZZZZZZZZZZZ");
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV10Insert_BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ");
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A140BR_Procedure_PXID), "ZZZZZZZZZZ");
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("br_procedure:[SendSecurityCheck value for]"+"BR_ProcedureID:"+context.localUtil.Format( (decimal)(A139BR_ProcedureID), "ZZZZZZZZZZZZZZZZZZ"));
         GXUtil.WriteLog("br_procedure:[SendSecurityCheck value for]"+"Insert_BR_EncounterID:"+context.localUtil.Format( (decimal)(AV10Insert_BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ"));
         GXUtil.WriteLog("br_procedure:[SendSecurityCheck value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
         GXUtil.WriteLog("br_procedure:[SendSecurityCheck value for]"+"BR_Procedure_PXID:"+context.localUtil.Format( (decimal)(A140BR_Procedure_PXID), "ZZZZZZZZZZ"));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z139BR_ProcedureID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z139BR_ProcedureID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z497BR_Procedure_PXSurgery_Code", Z497BR_Procedure_PXSurgery_Code);
         GxWebStd.gx_hidden_field( context, "Z498BR_Procedure_PXRadiotherapy_Code", Z498BR_Procedure_PXRadiotherapy_Code);
         GxWebStd.gx_hidden_field( context, "Z140BR_Procedure_PXID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z140BR_Procedure_PXID), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z141BR_Procedure_PXSurgery", Z141BR_Procedure_PXSurgery);
         GxWebStd.gx_hidden_field( context, "Z266BR_Procedure_Date", context.localUtil.DToC( Z266BR_Procedure_Date, 0, "/"));
         GxWebStd.gx_hidden_field( context, "Z143BR_Procedure_PXRadiotherapy", Z143BR_Procedure_PXRadiotherapy);
         GxWebStd.gx_hidden_field( context, "Z268BR_Procedure_RadioDate", context.localUtil.DToC( Z268BR_Procedure_RadioDate, 0, "/"));
         GxWebStd.gx_hidden_field( context, "Z269BR_Procedure_RadioTime", StringUtil.LTrim( StringUtil.NToC( Z269BR_Procedure_RadioTime, 15, 5, ".", "")));
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
         GxWebStd.gx_hidden_field( context, "vBR_PROCEDUREID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV12BR_ProcedureID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vBR_PROCEDUREID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV12BR_ProcedureID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, "vINSERT_BR_ENCOUNTERID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10Insert_BR_EncounterID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "BR_PROCEDURE_PXSURGERY_CODE", A497BR_Procedure_PXSurgery_Code);
         GxWebStd.gx_hidden_field( context, "BR_PROCEDURE_PXRADIOTHERAPY_CODE", A498BR_Procedure_PXRadiotherapy_Code);
         GxWebStd.gx_hidden_field( context, "BR_PROCEDURE_PXID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A140BR_Procedure_PXID), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "BR_INFORMATION_ID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A85BR_Information_ID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV20Pgmname));
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
         return formatLink("br_procedure.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV12BR_ProcedureID) ;
      }

      public override String GetPgmname( )
      {
         return "BR_Procedure" ;
      }

      public override String GetPgmdesc( )
      {
         return "Data Mgmt Portal - RAAP" ;
      }

      protected void InitializeNonKey0I19( )
      {
         A85BR_Information_ID = 0;
         n85BR_Information_ID = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A85BR_Information_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A85BR_Information_ID), 18, 0)));
         A19BR_EncounterID = 0;
         n19BR_EncounterID = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
         n19BR_EncounterID = ((0==A19BR_EncounterID) ? true : false);
         A497BR_Procedure_PXSurgery_Code = "";
         n497BR_Procedure_PXSurgery_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A497BR_Procedure_PXSurgery_Code", A497BR_Procedure_PXSurgery_Code);
         A498BR_Procedure_PXRadiotherapy_Code = "";
         n498BR_Procedure_PXRadiotherapy_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A498BR_Procedure_PXRadiotherapy_Code", A498BR_Procedure_PXRadiotherapy_Code);
         A36BR_Information_PatientNo = "";
         n36BR_Information_PatientNo = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36BR_Information_PatientNo", A36BR_Information_PatientNo);
         A140BR_Procedure_PXID = 0;
         n140BR_Procedure_PXID = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A140BR_Procedure_PXID", StringUtil.LTrim( StringUtil.Str( (decimal)(A140BR_Procedure_PXID), 10, 0)));
         A141BR_Procedure_PXSurgery = "";
         n141BR_Procedure_PXSurgery = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A141BR_Procedure_PXSurgery", A141BR_Procedure_PXSurgery);
         n141BR_Procedure_PXSurgery = (String.IsNullOrEmpty(StringUtil.RTrim( A141BR_Procedure_PXSurgery)) ? true : false);
         A266BR_Procedure_Date = DateTime.MinValue;
         n266BR_Procedure_Date = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A266BR_Procedure_Date", context.localUtil.Format(A266BR_Procedure_Date, "9999/99/99"));
         n266BR_Procedure_Date = ((DateTime.MinValue==A266BR_Procedure_Date) ? true : false);
         A143BR_Procedure_PXRadiotherapy = "";
         n143BR_Procedure_PXRadiotherapy = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A143BR_Procedure_PXRadiotherapy", A143BR_Procedure_PXRadiotherapy);
         n143BR_Procedure_PXRadiotherapy = (String.IsNullOrEmpty(StringUtil.RTrim( A143BR_Procedure_PXRadiotherapy)) ? true : false);
         A268BR_Procedure_RadioDate = DateTime.MinValue;
         n268BR_Procedure_RadioDate = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A268BR_Procedure_RadioDate", context.localUtil.Format(A268BR_Procedure_RadioDate, "9999/99/99"));
         n268BR_Procedure_RadioDate = ((DateTime.MinValue==A268BR_Procedure_RadioDate) ? true : false);
         A269BR_Procedure_RadioTime = 0;
         n269BR_Procedure_RadioTime = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A269BR_Procedure_RadioTime", StringUtil.LTrim( StringUtil.Str( A269BR_Procedure_RadioTime, 15, 5)));
         n269BR_Procedure_RadioTime = ((Convert.ToDecimal(0)==A269BR_Procedure_RadioTime) ? true : false);
         Z497BR_Procedure_PXSurgery_Code = "";
         Z498BR_Procedure_PXRadiotherapy_Code = "";
         Z140BR_Procedure_PXID = 0;
         Z141BR_Procedure_PXSurgery = "";
         Z266BR_Procedure_Date = DateTime.MinValue;
         Z143BR_Procedure_PXRadiotherapy = "";
         Z268BR_Procedure_RadioDate = DateTime.MinValue;
         Z269BR_Procedure_RadioTime = 0;
         Z19BR_EncounterID = 0;
      }

      protected void InitAll0I19( )
      {
         A139BR_ProcedureID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A139BR_ProcedureID", StringUtil.LTrim( StringUtil.Str( (decimal)(A139BR_ProcedureID), 18, 0)));
         InitializeNonKey0I19( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20202271157558", true);
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
         context.AddJavascriptSource("br_procedure.js", "?20202271157558", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         lblTextblockbr_procedure_pxsurgery_Internalname = "TEXTBLOCKBR_PROCEDURE_PXSURGERY";
         cmbBR_Procedure_PXSurgery_Internalname = "BR_PROCEDURE_PXSURGERY";
         divUnnamedtablebr_procedure_pxsurgery_Internalname = "UNNAMEDTABLEBR_PROCEDURE_PXSURGERY";
         divBr_procedure_pxsurgery_cell_Internalname = "BR_PROCEDURE_PXSURGERY_CELL";
         lblTextblockbr_procedure_date_Internalname = "TEXTBLOCKBR_PROCEDURE_DATE";
         edtBR_Procedure_Date_Internalname = "BR_PROCEDURE_DATE";
         divUnnamedtablebr_procedure_date_Internalname = "UNNAMEDTABLEBR_PROCEDURE_DATE";
         divUnnamedtable1_Internalname = "UNNAMEDTABLE1";
         lblTextblockbr_procedure_pxradiotherapy_Internalname = "TEXTBLOCKBR_PROCEDURE_PXRADIOTHERAPY";
         cmbBR_Procedure_PXRadiotherapy_Internalname = "BR_PROCEDURE_PXRADIOTHERAPY";
         divUnnamedtablebr_procedure_pxradiotherapy_Internalname = "UNNAMEDTABLEBR_PROCEDURE_PXRADIOTHERAPY";
         divBr_procedure_pxradiotherapy_cell_Internalname = "BR_PROCEDURE_PXRADIOTHERAPY_CELL";
         lblTextblockbr_procedure_radiodate_Internalname = "TEXTBLOCKBR_PROCEDURE_RADIODATE";
         edtBR_Procedure_RadioDate_Internalname = "BR_PROCEDURE_RADIODATE";
         divUnnamedtablebr_procedure_radiodate_Internalname = "UNNAMEDTABLEBR_PROCEDURE_RADIODATE";
         lblTextblockbr_procedure_radiotime_Internalname = "TEXTBLOCKBR_PROCEDURE_RADIOTIME";
         edtBR_Procedure_RadioTime_Internalname = "BR_PROCEDURE_RADIOTIME";
         divUnnamedtablebr_procedure_radiotime_Internalname = "UNNAMEDTABLEBR_PROCEDURE_RADIOTIME";
         divUnnamedtable2_Internalname = "UNNAMEDTABLE2";
         divTableattributes_Internalname = "TABLEATTRIBUTES";
         divLayout_tableattributes_Internalname = "LAYOUT_TABLEATTRIBUTES";
         Dvpanel_tableattributes_Internalname = "DVPANEL_TABLEATTRIBUTES";
         divHtml_dvpanel_tableattributes_Internalname = "HTML_DVPANEL_TABLEATTRIBUTES";
         divTablecontent_Internalname = "TABLECONTENT";
         bttBtntrn_enter_Internalname = "BTNTRN_ENTER";
         bttBtntrn_cancel_Internalname = "BTNTRN_CANCEL";
         bttBtntrn_delete_Internalname = "BTNTRN_DELETE";
         divTablemain_Internalname = "TABLEMAIN";
         edtBR_ProcedureID_Internalname = "BR_PROCEDUREID";
         edtBR_EncounterID_Internalname = "BR_ENCOUNTERID";
         edtBR_Information_PatientNo_Internalname = "BR_INFORMATION_PATIENTNO";
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
         edtBR_Information_PatientNo_Jsonclick = "";
         edtBR_Information_PatientNo_Enabled = 0;
         edtBR_Information_PatientNo_Visible = 1;
         edtBR_EncounterID_Jsonclick = "";
         edtBR_EncounterID_Enabled = 1;
         edtBR_EncounterID_Visible = 1;
         edtBR_ProcedureID_Jsonclick = "";
         edtBR_ProcedureID_Enabled = 0;
         edtBR_ProcedureID_Visible = 1;
         bttBtntrn_delete_Enabled = 0;
         bttBtntrn_delete_Visible = 1;
         bttBtntrn_cancel_Visible = 1;
         bttBtntrn_enter_Enabled = 1;
         bttBtntrn_enter_Visible = 1;
         edtBR_Procedure_RadioTime_Jsonclick = "";
         edtBR_Procedure_RadioTime_Enabled = 1;
         edtBR_Procedure_RadioDate_Jsonclick = "";
         edtBR_Procedure_RadioDate_Enabled = 1;
         divUnnamedtable2_Visible = 1;
         cmbBR_Procedure_PXRadiotherapy_Jsonclick = "";
         cmbBR_Procedure_PXRadiotherapy.Enabled = 1;
         cmbBR_Procedure_PXRadiotherapy.Visible = 1;
         divBr_procedure_pxradiotherapy_cell_Class = "col-xs-12 col-sm-6";
         edtBR_Procedure_Date_Jsonclick = "";
         edtBR_Procedure_Date_Enabled = 1;
         divUnnamedtable1_Visible = 1;
         cmbBR_Procedure_PXSurgery_Jsonclick = "";
         cmbBR_Procedure_PXSurgery.Enabled = 1;
         cmbBR_Procedure_PXSurgery.Visible = 1;
         divBr_procedure_pxsurgery_cell_Class = "col-xs-12 col-sm-6";
         Dvpanel_tableattributes_Autoscroll = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Iconposition = "left";
         Dvpanel_tableattributes_Showcollapseicon = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsed = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsible = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Title = "诊疗处理";
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

      protected void GX20ASABR_PROCEDURE_PXSURGERY_CODE0I19( String A141BR_Procedure_PXSurgery )
      {
         GXt_char2 = A497BR_Procedure_PXSurgery_Code;
         new zutil_findtargetcode(context ).execute(  37,  A141BR_Procedure_PXSurgery, out  GXt_char2) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A141BR_Procedure_PXSurgery", A141BR_Procedure_PXSurgery);
         A497BR_Procedure_PXSurgery_Code = GXt_char2;
         n497BR_Procedure_PXSurgery_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A497BR_Procedure_PXSurgery_Code", A497BR_Procedure_PXSurgery_Code);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A497BR_Procedure_PXSurgery_Code)+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GX21ASABR_PROCEDURE_PXSURGERY_CODE0I19( String A141BR_Procedure_PXSurgery )
      {
         GXt_char2 = A497BR_Procedure_PXSurgery_Code;
         new zutil_findtargetcode(context ).execute(  37,  A141BR_Procedure_PXSurgery, out  GXt_char2) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A141BR_Procedure_PXSurgery", A141BR_Procedure_PXSurgery);
         A497BR_Procedure_PXSurgery_Code = GXt_char2;
         n497BR_Procedure_PXSurgery_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A497BR_Procedure_PXSurgery_Code", A497BR_Procedure_PXSurgery_Code);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A497BR_Procedure_PXSurgery_Code)+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GX22ASABR_PROCEDURE_PXRADIOTHERAPY_CODE0I19( String A143BR_Procedure_PXRadiotherapy )
      {
         GXt_char2 = A498BR_Procedure_PXRadiotherapy_Code;
         new zutil_findtargetcode(context ).execute(  37,  A143BR_Procedure_PXRadiotherapy, out  GXt_char2) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A143BR_Procedure_PXRadiotherapy", A143BR_Procedure_PXRadiotherapy);
         A498BR_Procedure_PXRadiotherapy_Code = GXt_char2;
         n498BR_Procedure_PXRadiotherapy_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A498BR_Procedure_PXRadiotherapy_Code", A498BR_Procedure_PXRadiotherapy_Code);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A498BR_Procedure_PXRadiotherapy_Code)+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GX23ASABR_PROCEDURE_PXRADIOTHERAPY_CODE0I19( String A143BR_Procedure_PXRadiotherapy )
      {
         GXt_char2 = A498BR_Procedure_PXRadiotherapy_Code;
         new zutil_findtargetcode(context ).execute(  37,  A143BR_Procedure_PXRadiotherapy, out  GXt_char2) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A143BR_Procedure_PXRadiotherapy", A143BR_Procedure_PXRadiotherapy);
         A498BR_Procedure_PXRadiotherapy_Code = GXt_char2;
         n498BR_Procedure_PXRadiotherapy_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A498BR_Procedure_PXRadiotherapy_Code", A498BR_Procedure_PXRadiotherapy_Code);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A498BR_Procedure_PXRadiotherapy_Code)+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void XC_27_0I19( )
      {
         new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)),  "就诊信息",  StringUtil.Trim( StringUtil.Str( (decimal)(A139BR_ProcedureID), 18, 0)),  "诊疗处理",  "Create",  1) ;
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

      protected void XC_28_0I19( )
      {
         new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)),  "就诊信息",  StringUtil.Trim( StringUtil.Str( (decimal)(A139BR_ProcedureID), 18, 0)),  "诊疗处理",  "Update",  1) ;
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

      protected void XC_29_0I19( String A143BR_Procedure_PXRadiotherapy )
      {
         if ( StringUtil.StrCmp(A143BR_Procedure_PXRadiotherapy, "否") == 0 )
         {
            new zbr_deleteprocedureradio(context ).execute( ) ;
         }
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

      protected void XC_30_0I19( String A143BR_Procedure_PXRadiotherapy )
      {
         if ( StringUtil.StrCmp(A143BR_Procedure_PXRadiotherapy, "不详") == 0 )
         {
            new zbr_deleteprocedureradio(context ).execute( ) ;
         }
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

      protected void XC_31_0I19( String A141BR_Procedure_PXSurgery )
      {
         if ( StringUtil.StrCmp(A141BR_Procedure_PXSurgery, "否") == 0 )
         {
            new zbr_deleteproceduresurgery(context ).execute( ) ;
         }
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

      protected void XC_32_0I19( String A141BR_Procedure_PXSurgery )
      {
         if ( StringUtil.StrCmp(A141BR_Procedure_PXSurgery, "不详") == 0 )
         {
            new zbr_deleteproceduresurgery(context ).execute( ) ;
         }
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
         cmbBR_Procedure_PXSurgery.Name = "BR_PROCEDURE_PXSURGERY";
         cmbBR_Procedure_PXSurgery.WebTags = "";
         cmbBR_Procedure_PXSurgery.addItem("否", "否", 0);
         cmbBR_Procedure_PXSurgery.addItem("是", "是", 0);
         cmbBR_Procedure_PXSurgery.addItem("不详", "不详", 0);
         if ( cmbBR_Procedure_PXSurgery.ItemCount > 0 )
         {
            A141BR_Procedure_PXSurgery = cmbBR_Procedure_PXSurgery.getValidValue(A141BR_Procedure_PXSurgery);
            n141BR_Procedure_PXSurgery = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A141BR_Procedure_PXSurgery", A141BR_Procedure_PXSurgery);
         }
         cmbBR_Procedure_PXRadiotherapy.Name = "BR_PROCEDURE_PXRADIOTHERAPY";
         cmbBR_Procedure_PXRadiotherapy.WebTags = "";
         cmbBR_Procedure_PXRadiotherapy.addItem("否", "否", 0);
         cmbBR_Procedure_PXRadiotherapy.addItem("是", "是", 0);
         cmbBR_Procedure_PXRadiotherapy.addItem("不详", "不详", 0);
         if ( cmbBR_Procedure_PXRadiotherapy.ItemCount > 0 )
         {
            A143BR_Procedure_PXRadiotherapy = cmbBR_Procedure_PXRadiotherapy.getValidValue(A143BR_Procedure_PXRadiotherapy);
            n143BR_Procedure_PXRadiotherapy = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A143BR_Procedure_PXRadiotherapy", A143BR_Procedure_PXRadiotherapy);
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
         /* Using cursor T000I15 */
         pr_default.execute(13, new Object[] {n19BR_EncounterID, A19BR_EncounterID});
         if ( (pr_default.getStatus(13) == 101) )
         {
            if ( ! ( (0==A19BR_EncounterID) ) )
            {
               GX_msglist.addItem("不匹配' T15'", "ForeignKeyNotFound", 1, "BR_ENCOUNTERID");
               AnyError = 1;
               GX_FocusControl = edtBR_EncounterID_Internalname;
            }
         }
         A85BR_Information_ID = T000I15_A85BR_Information_ID[0];
         n85BR_Information_ID = T000I15_n85BR_Information_ID[0];
         pr_default.close(13);
         /* Using cursor T000I16 */
         pr_default.execute(14, new Object[] {n85BR_Information_ID, A85BR_Information_ID});
         if ( (pr_default.getStatus(14) == 101) )
         {
            if ( ! ( (0==A85BR_Information_ID) ) )
            {
               GX_msglist.addItem("不匹配' T16'", "ForeignKeyNotFound", 1, "");
               AnyError = 1;
            }
         }
         A36BR_Information_PatientNo = T000I16_A36BR_Information_PatientNo[0];
         n36BR_Information_PatientNo = T000I16_n36BR_Information_PatientNo[0];
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
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV12BR_ProcedureID',fld:'vBR_PROCEDUREID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV12BR_ProcedureID',fld:'vBR_PROCEDUREID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'A139BR_ProcedureID',fld:'BR_PROCEDUREID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV10Insert_BR_EncounterID',fld:'vINSERT_BR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'A140BR_Procedure_PXID',fld:'BR_PROCEDURE_PXID',pic:'ZZZZZZZZZZ'}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("AFTER TRN","{handler:'E120I2',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV8TrnContext',fld:'vTRNCONTEXT',pic:''},{av:'A139BR_ProcedureID',fld:'BR_PROCEDUREID',pic:'ZZZZZZZZZZZZZZZZZZ'}]");
         setEventMetadata("AFTER TRN",",oparms:[]}");
         setEventMetadata("'DOTEST'","{handler:'E130I2',iparms:[]");
         setEventMetadata("'DOTEST'",",oparms:[]}");
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
         Z497BR_Procedure_PXSurgery_Code = "";
         Z498BR_Procedure_PXRadiotherapy_Code = "";
         Z141BR_Procedure_PXSurgery = "";
         Z266BR_Procedure_Date = DateTime.MinValue;
         Z143BR_Procedure_PXRadiotherapy = "";
         Z268BR_Procedure_RadioDate = DateTime.MinValue;
         scmdbuf = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         A143BR_Procedure_PXRadiotherapy = "";
         A141BR_Procedure_PXSurgery = "";
         GXKey = "";
         PreviousTooltip = "";
         PreviousCaption = "";
         Form = new GXWebForm();
         GX_FocusControl = "";
         ClassString = "";
         StyleString = "";
         ucDvpanel_tableattributes = new GXUserControl();
         lblTextblockbr_procedure_pxsurgery_Jsonclick = "";
         TempTags = "";
         lblTextblockbr_procedure_date_Jsonclick = "";
         A266BR_Procedure_Date = DateTime.MinValue;
         lblTextblockbr_procedure_pxradiotherapy_Jsonclick = "";
         lblTextblockbr_procedure_radiodate_Jsonclick = "";
         A268BR_Procedure_RadioDate = DateTime.MinValue;
         lblTextblockbr_procedure_radiotime_Jsonclick = "";
         bttBtntrn_enter_Jsonclick = "";
         bttBtntrn_cancel_Jsonclick = "";
         bttBtntrn_delete_Jsonclick = "";
         A36BR_Information_PatientNo = "";
         A497BR_Procedure_PXSurgery_Code = "";
         A498BR_Procedure_PXRadiotherapy_Code = "";
         AV20Pgmname = "";
         Dvpanel_tableattributes_Objectcall = "";
         Dvpanel_tableattributes_Class = "";
         Dvpanel_tableattributes_Height = "";
         forbiddenHiddens = "";
         hsh = "";
         sMode19 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV7WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV8TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV9WebSession = context.GetSession();
         AV11TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         Z36BR_Information_PatientNo = "";
         T000I4_A85BR_Information_ID = new long[1] ;
         T000I4_n85BR_Information_ID = new bool[] {false} ;
         T000I5_A36BR_Information_PatientNo = new String[] {""} ;
         T000I5_n36BR_Information_PatientNo = new bool[] {false} ;
         T000I6_A85BR_Information_ID = new long[1] ;
         T000I6_n85BR_Information_ID = new bool[] {false} ;
         T000I6_A139BR_ProcedureID = new long[1] ;
         T000I6_A497BR_Procedure_PXSurgery_Code = new String[] {""} ;
         T000I6_n497BR_Procedure_PXSurgery_Code = new bool[] {false} ;
         T000I6_A498BR_Procedure_PXRadiotherapy_Code = new String[] {""} ;
         T000I6_n498BR_Procedure_PXRadiotherapy_Code = new bool[] {false} ;
         T000I6_A36BR_Information_PatientNo = new String[] {""} ;
         T000I6_n36BR_Information_PatientNo = new bool[] {false} ;
         T000I6_A140BR_Procedure_PXID = new long[1] ;
         T000I6_n140BR_Procedure_PXID = new bool[] {false} ;
         T000I6_A141BR_Procedure_PXSurgery = new String[] {""} ;
         T000I6_n141BR_Procedure_PXSurgery = new bool[] {false} ;
         T000I6_A266BR_Procedure_Date = new DateTime[] {DateTime.MinValue} ;
         T000I6_n266BR_Procedure_Date = new bool[] {false} ;
         T000I6_A143BR_Procedure_PXRadiotherapy = new String[] {""} ;
         T000I6_n143BR_Procedure_PXRadiotherapy = new bool[] {false} ;
         T000I6_A268BR_Procedure_RadioDate = new DateTime[] {DateTime.MinValue} ;
         T000I6_n268BR_Procedure_RadioDate = new bool[] {false} ;
         T000I6_A269BR_Procedure_RadioTime = new decimal[1] ;
         T000I6_n269BR_Procedure_RadioTime = new bool[] {false} ;
         T000I6_A19BR_EncounterID = new long[1] ;
         T000I6_n19BR_EncounterID = new bool[] {false} ;
         T000I7_A85BR_Information_ID = new long[1] ;
         T000I7_n85BR_Information_ID = new bool[] {false} ;
         T000I8_A36BR_Information_PatientNo = new String[] {""} ;
         T000I8_n36BR_Information_PatientNo = new bool[] {false} ;
         T000I9_A139BR_ProcedureID = new long[1] ;
         T000I3_A139BR_ProcedureID = new long[1] ;
         T000I3_A497BR_Procedure_PXSurgery_Code = new String[] {""} ;
         T000I3_n497BR_Procedure_PXSurgery_Code = new bool[] {false} ;
         T000I3_A498BR_Procedure_PXRadiotherapy_Code = new String[] {""} ;
         T000I3_n498BR_Procedure_PXRadiotherapy_Code = new bool[] {false} ;
         T000I3_A140BR_Procedure_PXID = new long[1] ;
         T000I3_n140BR_Procedure_PXID = new bool[] {false} ;
         T000I3_A141BR_Procedure_PXSurgery = new String[] {""} ;
         T000I3_n141BR_Procedure_PXSurgery = new bool[] {false} ;
         T000I3_A266BR_Procedure_Date = new DateTime[] {DateTime.MinValue} ;
         T000I3_n266BR_Procedure_Date = new bool[] {false} ;
         T000I3_A143BR_Procedure_PXRadiotherapy = new String[] {""} ;
         T000I3_n143BR_Procedure_PXRadiotherapy = new bool[] {false} ;
         T000I3_A268BR_Procedure_RadioDate = new DateTime[] {DateTime.MinValue} ;
         T000I3_n268BR_Procedure_RadioDate = new bool[] {false} ;
         T000I3_A269BR_Procedure_RadioTime = new decimal[1] ;
         T000I3_n269BR_Procedure_RadioTime = new bool[] {false} ;
         T000I3_A19BR_EncounterID = new long[1] ;
         T000I3_n19BR_EncounterID = new bool[] {false} ;
         T000I10_A139BR_ProcedureID = new long[1] ;
         T000I11_A139BR_ProcedureID = new long[1] ;
         T000I2_A139BR_ProcedureID = new long[1] ;
         T000I2_A497BR_Procedure_PXSurgery_Code = new String[] {""} ;
         T000I2_n497BR_Procedure_PXSurgery_Code = new bool[] {false} ;
         T000I2_A498BR_Procedure_PXRadiotherapy_Code = new String[] {""} ;
         T000I2_n498BR_Procedure_PXRadiotherapy_Code = new bool[] {false} ;
         T000I2_A140BR_Procedure_PXID = new long[1] ;
         T000I2_n140BR_Procedure_PXID = new bool[] {false} ;
         T000I2_A141BR_Procedure_PXSurgery = new String[] {""} ;
         T000I2_n141BR_Procedure_PXSurgery = new bool[] {false} ;
         T000I2_A266BR_Procedure_Date = new DateTime[] {DateTime.MinValue} ;
         T000I2_n266BR_Procedure_Date = new bool[] {false} ;
         T000I2_A143BR_Procedure_PXRadiotherapy = new String[] {""} ;
         T000I2_n143BR_Procedure_PXRadiotherapy = new bool[] {false} ;
         T000I2_A268BR_Procedure_RadioDate = new DateTime[] {DateTime.MinValue} ;
         T000I2_n268BR_Procedure_RadioDate = new bool[] {false} ;
         T000I2_A269BR_Procedure_RadioTime = new decimal[1] ;
         T000I2_n269BR_Procedure_RadioTime = new bool[] {false} ;
         T000I2_A19BR_EncounterID = new long[1] ;
         T000I2_n19BR_EncounterID = new bool[] {false} ;
         T000I12_A139BR_ProcedureID = new long[1] ;
         T000I15_A85BR_Information_ID = new long[1] ;
         T000I15_n85BR_Information_ID = new bool[] {false} ;
         T000I16_A36BR_Information_PatientNo = new String[] {""} ;
         T000I16_n36BR_Information_PatientNo = new bool[] {false} ;
         T000I17_A323BR_Procedure_RadioID = new long[1] ;
         T000I18_A320BR_Procedure_SurgeryID = new long[1] ;
         T000I19_A139BR_ProcedureID = new long[1] ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         GXt_char2 = "";
         isValidOutput = new GxUnknownObjectCollection();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.br_procedure__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_procedure__default(),
            new Object[][] {
                new Object[] {
               T000I2_A139BR_ProcedureID, T000I2_A497BR_Procedure_PXSurgery_Code, T000I2_n497BR_Procedure_PXSurgery_Code, T000I2_A498BR_Procedure_PXRadiotherapy_Code, T000I2_n498BR_Procedure_PXRadiotherapy_Code, T000I2_A140BR_Procedure_PXID, T000I2_n140BR_Procedure_PXID, T000I2_A141BR_Procedure_PXSurgery, T000I2_n141BR_Procedure_PXSurgery, T000I2_A266BR_Procedure_Date,
               T000I2_n266BR_Procedure_Date, T000I2_A143BR_Procedure_PXRadiotherapy, T000I2_n143BR_Procedure_PXRadiotherapy, T000I2_A268BR_Procedure_RadioDate, T000I2_n268BR_Procedure_RadioDate, T000I2_A269BR_Procedure_RadioTime, T000I2_n269BR_Procedure_RadioTime, T000I2_A19BR_EncounterID, T000I2_n19BR_EncounterID
               }
               , new Object[] {
               T000I3_A139BR_ProcedureID, T000I3_A497BR_Procedure_PXSurgery_Code, T000I3_n497BR_Procedure_PXSurgery_Code, T000I3_A498BR_Procedure_PXRadiotherapy_Code, T000I3_n498BR_Procedure_PXRadiotherapy_Code, T000I3_A140BR_Procedure_PXID, T000I3_n140BR_Procedure_PXID, T000I3_A141BR_Procedure_PXSurgery, T000I3_n141BR_Procedure_PXSurgery, T000I3_A266BR_Procedure_Date,
               T000I3_n266BR_Procedure_Date, T000I3_A143BR_Procedure_PXRadiotherapy, T000I3_n143BR_Procedure_PXRadiotherapy, T000I3_A268BR_Procedure_RadioDate, T000I3_n268BR_Procedure_RadioDate, T000I3_A269BR_Procedure_RadioTime, T000I3_n269BR_Procedure_RadioTime, T000I3_A19BR_EncounterID, T000I3_n19BR_EncounterID
               }
               , new Object[] {
               T000I4_A85BR_Information_ID, T000I4_n85BR_Information_ID
               }
               , new Object[] {
               T000I5_A36BR_Information_PatientNo, T000I5_n36BR_Information_PatientNo
               }
               , new Object[] {
               T000I6_A85BR_Information_ID, T000I6_n85BR_Information_ID, T000I6_A139BR_ProcedureID, T000I6_A497BR_Procedure_PXSurgery_Code, T000I6_n497BR_Procedure_PXSurgery_Code, T000I6_A498BR_Procedure_PXRadiotherapy_Code, T000I6_n498BR_Procedure_PXRadiotherapy_Code, T000I6_A36BR_Information_PatientNo, T000I6_n36BR_Information_PatientNo, T000I6_A140BR_Procedure_PXID,
               T000I6_n140BR_Procedure_PXID, T000I6_A141BR_Procedure_PXSurgery, T000I6_n141BR_Procedure_PXSurgery, T000I6_A266BR_Procedure_Date, T000I6_n266BR_Procedure_Date, T000I6_A143BR_Procedure_PXRadiotherapy, T000I6_n143BR_Procedure_PXRadiotherapy, T000I6_A268BR_Procedure_RadioDate, T000I6_n268BR_Procedure_RadioDate, T000I6_A269BR_Procedure_RadioTime,
               T000I6_n269BR_Procedure_RadioTime, T000I6_A19BR_EncounterID, T000I6_n19BR_EncounterID
               }
               , new Object[] {
               T000I7_A85BR_Information_ID, T000I7_n85BR_Information_ID
               }
               , new Object[] {
               T000I8_A36BR_Information_PatientNo, T000I8_n36BR_Information_PatientNo
               }
               , new Object[] {
               T000I9_A139BR_ProcedureID
               }
               , new Object[] {
               T000I10_A139BR_ProcedureID
               }
               , new Object[] {
               T000I11_A139BR_ProcedureID
               }
               , new Object[] {
               T000I12_A139BR_ProcedureID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000I15_A85BR_Information_ID, T000I15_n85BR_Information_ID
               }
               , new Object[] {
               T000I16_A36BR_Information_PatientNo, T000I16_n36BR_Information_PatientNo
               }
               , new Object[] {
               T000I17_A323BR_Procedure_RadioID
               }
               , new Object[] {
               T000I18_A320BR_Procedure_SurgeryID
               }
               , new Object[] {
               T000I19_A139BR_ProcedureID
               }
            }
         );
         AV20Pgmname = "BR_Procedure";
      }

      private short GxWebError ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short RcdFound19 ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int trnEnded ;
      private int divUnnamedtable1_Visible ;
      private int edtBR_Procedure_Date_Enabled ;
      private int divUnnamedtable2_Visible ;
      private int edtBR_Procedure_RadioDate_Enabled ;
      private int edtBR_Procedure_RadioTime_Enabled ;
      private int bttBtntrn_enter_Visible ;
      private int bttBtntrn_enter_Enabled ;
      private int bttBtntrn_cancel_Visible ;
      private int bttBtntrn_delete_Visible ;
      private int bttBtntrn_delete_Enabled ;
      private int edtBR_ProcedureID_Enabled ;
      private int edtBR_ProcedureID_Visible ;
      private int edtBR_EncounterID_Visible ;
      private int edtBR_EncounterID_Enabled ;
      private int edtBR_Information_PatientNo_Visible ;
      private int edtBR_Information_PatientNo_Enabled ;
      private int AV21GXV1 ;
      private int idxLst ;
      private long wcpOAV12BR_ProcedureID ;
      private long Z139BR_ProcedureID ;
      private long Z140BR_Procedure_PXID ;
      private long Z19BR_EncounterID ;
      private long N19BR_EncounterID ;
      private long A19BR_EncounterID ;
      private long A85BR_Information_ID ;
      private long AV12BR_ProcedureID ;
      private long A139BR_ProcedureID ;
      private long A140BR_Procedure_PXID ;
      private long AV10Insert_BR_EncounterID ;
      private long Z85BR_Information_ID ;
      private decimal Z269BR_Procedure_RadioTime ;
      private decimal A269BR_Procedure_RadioTime ;
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
      private String cmbBR_Procedure_PXSurgery_Internalname ;
      private String cmbBR_Procedure_PXRadiotherapy_Internalname ;
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
      private String divBr_procedure_pxsurgery_cell_Internalname ;
      private String divBr_procedure_pxsurgery_cell_Class ;
      private String divUnnamedtablebr_procedure_pxsurgery_Internalname ;
      private String lblTextblockbr_procedure_pxsurgery_Internalname ;
      private String lblTextblockbr_procedure_pxsurgery_Jsonclick ;
      private String TempTags ;
      private String cmbBR_Procedure_PXSurgery_Jsonclick ;
      private String divUnnamedtable1_Internalname ;
      private String divUnnamedtablebr_procedure_date_Internalname ;
      private String lblTextblockbr_procedure_date_Internalname ;
      private String lblTextblockbr_procedure_date_Jsonclick ;
      private String edtBR_Procedure_Date_Internalname ;
      private String edtBR_Procedure_Date_Jsonclick ;
      private String divBr_procedure_pxradiotherapy_cell_Internalname ;
      private String divBr_procedure_pxradiotherapy_cell_Class ;
      private String divUnnamedtablebr_procedure_pxradiotherapy_Internalname ;
      private String lblTextblockbr_procedure_pxradiotherapy_Internalname ;
      private String lblTextblockbr_procedure_pxradiotherapy_Jsonclick ;
      private String cmbBR_Procedure_PXRadiotherapy_Jsonclick ;
      private String divUnnamedtable2_Internalname ;
      private String divUnnamedtablebr_procedure_radiodate_Internalname ;
      private String lblTextblockbr_procedure_radiodate_Internalname ;
      private String lblTextblockbr_procedure_radiodate_Jsonclick ;
      private String edtBR_Procedure_RadioDate_Internalname ;
      private String edtBR_Procedure_RadioDate_Jsonclick ;
      private String divUnnamedtablebr_procedure_radiotime_Internalname ;
      private String lblTextblockbr_procedure_radiotime_Internalname ;
      private String lblTextblockbr_procedure_radiotime_Jsonclick ;
      private String edtBR_Procedure_RadioTime_Internalname ;
      private String edtBR_Procedure_RadioTime_Jsonclick ;
      private String bttBtntrn_enter_Internalname ;
      private String bttBtntrn_enter_Jsonclick ;
      private String bttBtntrn_cancel_Internalname ;
      private String bttBtntrn_cancel_Jsonclick ;
      private String bttBtntrn_delete_Internalname ;
      private String bttBtntrn_delete_Jsonclick ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String edtBR_ProcedureID_Internalname ;
      private String edtBR_ProcedureID_Jsonclick ;
      private String edtBR_EncounterID_Internalname ;
      private String edtBR_EncounterID_Jsonclick ;
      private String edtBR_Information_PatientNo_Internalname ;
      private String edtBR_Information_PatientNo_Jsonclick ;
      private String AV20Pgmname ;
      private String Dvpanel_tableattributes_Objectcall ;
      private String Dvpanel_tableattributes_Class ;
      private String Dvpanel_tableattributes_Height ;
      private String forbiddenHiddens ;
      private String hsh ;
      private String sMode19 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String GXt_char2 ;
      private DateTime Z266BR_Procedure_Date ;
      private DateTime Z268BR_Procedure_RadioDate ;
      private DateTime A266BR_Procedure_Date ;
      private DateTime A268BR_Procedure_RadioDate ;
      private bool entryPointCalled ;
      private bool n143BR_Procedure_PXRadiotherapy ;
      private bool n141BR_Procedure_PXSurgery ;
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
      private bool n266BR_Procedure_Date ;
      private bool n268BR_Procedure_RadioDate ;
      private bool n269BR_Procedure_RadioTime ;
      private bool n36BR_Information_PatientNo ;
      private bool n497BR_Procedure_PXSurgery_Code ;
      private bool n498BR_Procedure_PXRadiotherapy_Code ;
      private bool n140BR_Procedure_PXID ;
      private bool Dvpanel_tableattributes_Enabled ;
      private bool Dvpanel_tableattributes_Showheader ;
      private bool Dvpanel_tableattributes_Visible ;
      private bool AV13IsAuthorized ;
      private bool returnInSub ;
      private bool AV15TempBoolean ;
      private bool GXt_boolean1 ;
      private bool Gx_longc ;
      private String Z497BR_Procedure_PXSurgery_Code ;
      private String Z498BR_Procedure_PXRadiotherapy_Code ;
      private String Z141BR_Procedure_PXSurgery ;
      private String Z143BR_Procedure_PXRadiotherapy ;
      private String A143BR_Procedure_PXRadiotherapy ;
      private String A141BR_Procedure_PXSurgery ;
      private String A36BR_Information_PatientNo ;
      private String A497BR_Procedure_PXSurgery_Code ;
      private String A498BR_Procedure_PXRadiotherapy_Code ;
      private String Z36BR_Information_PatientNo ;
      private IGxSession AV9WebSession ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXUserControl ucDvpanel_tableattributes ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbBR_Procedure_PXSurgery ;
      private GXCombobox cmbBR_Procedure_PXRadiotherapy ;
      private IDataStoreProvider pr_default ;
      private long[] T000I4_A85BR_Information_ID ;
      private bool[] T000I4_n85BR_Information_ID ;
      private String[] T000I5_A36BR_Information_PatientNo ;
      private bool[] T000I5_n36BR_Information_PatientNo ;
      private long[] T000I6_A85BR_Information_ID ;
      private bool[] T000I6_n85BR_Information_ID ;
      private long[] T000I6_A139BR_ProcedureID ;
      private String[] T000I6_A497BR_Procedure_PXSurgery_Code ;
      private bool[] T000I6_n497BR_Procedure_PXSurgery_Code ;
      private String[] T000I6_A498BR_Procedure_PXRadiotherapy_Code ;
      private bool[] T000I6_n498BR_Procedure_PXRadiotherapy_Code ;
      private String[] T000I6_A36BR_Information_PatientNo ;
      private bool[] T000I6_n36BR_Information_PatientNo ;
      private long[] T000I6_A140BR_Procedure_PXID ;
      private bool[] T000I6_n140BR_Procedure_PXID ;
      private String[] T000I6_A141BR_Procedure_PXSurgery ;
      private bool[] T000I6_n141BR_Procedure_PXSurgery ;
      private DateTime[] T000I6_A266BR_Procedure_Date ;
      private bool[] T000I6_n266BR_Procedure_Date ;
      private String[] T000I6_A143BR_Procedure_PXRadiotherapy ;
      private bool[] T000I6_n143BR_Procedure_PXRadiotherapy ;
      private DateTime[] T000I6_A268BR_Procedure_RadioDate ;
      private bool[] T000I6_n268BR_Procedure_RadioDate ;
      private decimal[] T000I6_A269BR_Procedure_RadioTime ;
      private bool[] T000I6_n269BR_Procedure_RadioTime ;
      private long[] T000I6_A19BR_EncounterID ;
      private bool[] T000I6_n19BR_EncounterID ;
      private long[] T000I7_A85BR_Information_ID ;
      private bool[] T000I7_n85BR_Information_ID ;
      private String[] T000I8_A36BR_Information_PatientNo ;
      private bool[] T000I8_n36BR_Information_PatientNo ;
      private long[] T000I9_A139BR_ProcedureID ;
      private long[] T000I3_A139BR_ProcedureID ;
      private String[] T000I3_A497BR_Procedure_PXSurgery_Code ;
      private bool[] T000I3_n497BR_Procedure_PXSurgery_Code ;
      private String[] T000I3_A498BR_Procedure_PXRadiotherapy_Code ;
      private bool[] T000I3_n498BR_Procedure_PXRadiotherapy_Code ;
      private long[] T000I3_A140BR_Procedure_PXID ;
      private bool[] T000I3_n140BR_Procedure_PXID ;
      private String[] T000I3_A141BR_Procedure_PXSurgery ;
      private bool[] T000I3_n141BR_Procedure_PXSurgery ;
      private DateTime[] T000I3_A266BR_Procedure_Date ;
      private bool[] T000I3_n266BR_Procedure_Date ;
      private String[] T000I3_A143BR_Procedure_PXRadiotherapy ;
      private bool[] T000I3_n143BR_Procedure_PXRadiotherapy ;
      private DateTime[] T000I3_A268BR_Procedure_RadioDate ;
      private bool[] T000I3_n268BR_Procedure_RadioDate ;
      private decimal[] T000I3_A269BR_Procedure_RadioTime ;
      private bool[] T000I3_n269BR_Procedure_RadioTime ;
      private long[] T000I3_A19BR_EncounterID ;
      private bool[] T000I3_n19BR_EncounterID ;
      private long[] T000I10_A139BR_ProcedureID ;
      private long[] T000I11_A139BR_ProcedureID ;
      private long[] T000I2_A139BR_ProcedureID ;
      private String[] T000I2_A497BR_Procedure_PXSurgery_Code ;
      private bool[] T000I2_n497BR_Procedure_PXSurgery_Code ;
      private String[] T000I2_A498BR_Procedure_PXRadiotherapy_Code ;
      private bool[] T000I2_n498BR_Procedure_PXRadiotherapy_Code ;
      private long[] T000I2_A140BR_Procedure_PXID ;
      private bool[] T000I2_n140BR_Procedure_PXID ;
      private String[] T000I2_A141BR_Procedure_PXSurgery ;
      private bool[] T000I2_n141BR_Procedure_PXSurgery ;
      private DateTime[] T000I2_A266BR_Procedure_Date ;
      private bool[] T000I2_n266BR_Procedure_Date ;
      private String[] T000I2_A143BR_Procedure_PXRadiotherapy ;
      private bool[] T000I2_n143BR_Procedure_PXRadiotherapy ;
      private DateTime[] T000I2_A268BR_Procedure_RadioDate ;
      private bool[] T000I2_n268BR_Procedure_RadioDate ;
      private decimal[] T000I2_A269BR_Procedure_RadioTime ;
      private bool[] T000I2_n269BR_Procedure_RadioTime ;
      private long[] T000I2_A19BR_EncounterID ;
      private bool[] T000I2_n19BR_EncounterID ;
      private long[] T000I12_A139BR_ProcedureID ;
      private long[] T000I15_A85BR_Information_ID ;
      private bool[] T000I15_n85BR_Information_ID ;
      private String[] T000I16_A36BR_Information_PatientNo ;
      private bool[] T000I16_n36BR_Information_PatientNo ;
      private long[] T000I17_A323BR_Procedure_RadioID ;
      private long[] T000I18_A320BR_Procedure_SurgeryID ;
      private long[] T000I19_A139BR_ProcedureID ;
      private IDataStoreProvider pr_datastore1 ;
      private GXWebForm Form ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV8TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute AV11TrnContextAtt ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV7WWPContext ;
   }

   public class br_procedure__datastore1 : DataStoreHelperBase, IDataStoreHelper
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

 public class br_procedure__default : DataStoreHelperBase, IDataStoreHelper
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
     };
  }

  private static CursorDef[] def;
  private void cursorDefinitions( )
  {
     if ( def == null )
     {
        Object[] prmT000I6 ;
        prmT000I6 = new Object[] {
        new Object[] {"@BR_ProcedureID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000I4 ;
        prmT000I4 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000I5 ;
        prmT000I5 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000I7 ;
        prmT000I7 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000I8 ;
        prmT000I8 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000I9 ;
        prmT000I9 = new Object[] {
        new Object[] {"@BR_ProcedureID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000I3 ;
        prmT000I3 = new Object[] {
        new Object[] {"@BR_ProcedureID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000I10 ;
        prmT000I10 = new Object[] {
        new Object[] {"@BR_ProcedureID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000I11 ;
        prmT000I11 = new Object[] {
        new Object[] {"@BR_ProcedureID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000I2 ;
        prmT000I2 = new Object[] {
        new Object[] {"@BR_ProcedureID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000I12 ;
        prmT000I12 = new Object[] {
        new Object[] {"@BR_Procedure_PXSurgery_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Procedure_PXRadiotherapy_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Procedure_PXID",SqlDbType.Decimal,10,0} ,
        new Object[] {"@BR_Procedure_PXSurgery",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Procedure_Date",SqlDbType.DateTime,8,0} ,
        new Object[] {"@BR_Procedure_PXRadiotherapy",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Procedure_RadioDate",SqlDbType.DateTime,8,0} ,
        new Object[] {"@BR_Procedure_RadioTime",SqlDbType.Decimal,15,5} ,
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000I13 ;
        prmT000I13 = new Object[] {
        new Object[] {"@BR_Procedure_PXSurgery_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Procedure_PXRadiotherapy_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Procedure_PXID",SqlDbType.Decimal,10,0} ,
        new Object[] {"@BR_Procedure_PXSurgery",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Procedure_Date",SqlDbType.DateTime,8,0} ,
        new Object[] {"@BR_Procedure_PXRadiotherapy",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Procedure_RadioDate",SqlDbType.DateTime,8,0} ,
        new Object[] {"@BR_Procedure_RadioTime",SqlDbType.Decimal,15,5} ,
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@BR_ProcedureID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000I14 ;
        prmT000I14 = new Object[] {
        new Object[] {"@BR_ProcedureID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000I17 ;
        prmT000I17 = new Object[] {
        new Object[] {"@BR_ProcedureID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000I18 ;
        prmT000I18 = new Object[] {
        new Object[] {"@BR_ProcedureID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000I19 ;
        prmT000I19 = new Object[] {
        } ;
        Object[] prmT000I15 ;
        prmT000I15 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000I16 ;
        prmT000I16 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("T000I2", "SELECT [BR_ProcedureID], [BR_Procedure_PXSurgery_Code], [BR_Procedure_PXRadiotherapy_Code], [BR_Procedure_PXID], [BR_Procedure_PXSurgery], [BR_Procedure_Date], [BR_Procedure_PXRadiotherapy], [BR_Procedure_RadioDate], [BR_Procedure_RadioTime], [BR_EncounterID] FROM [BR_Procedure] WITH (UPDLOCK) WHERE [BR_ProcedureID] = @BR_ProcedureID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000I2,1,0,true,false )
           ,new CursorDef("T000I3", "SELECT [BR_ProcedureID], [BR_Procedure_PXSurgery_Code], [BR_Procedure_PXRadiotherapy_Code], [BR_Procedure_PXID], [BR_Procedure_PXSurgery], [BR_Procedure_Date], [BR_Procedure_PXRadiotherapy], [BR_Procedure_RadioDate], [BR_Procedure_RadioTime], [BR_EncounterID] FROM [BR_Procedure] WITH (NOLOCK) WHERE [BR_ProcedureID] = @BR_ProcedureID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000I3,1,0,true,false )
           ,new CursorDef("T000I4", "SELECT [BR_Information_ID] FROM [BR_Encounter] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000I4,1,0,true,false )
           ,new CursorDef("T000I5", "SELECT [BR_Information_PatientNo] FROM [BR_Information] WITH (NOLOCK) WHERE [BR_Information_ID] = @BR_Information_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000I5,1,0,true,false )
           ,new CursorDef("T000I6", "SELECT T2.[BR_Information_ID], TM1.[BR_ProcedureID], TM1.[BR_Procedure_PXSurgery_Code], TM1.[BR_Procedure_PXRadiotherapy_Code], T3.[BR_Information_PatientNo], TM1.[BR_Procedure_PXID], TM1.[BR_Procedure_PXSurgery], TM1.[BR_Procedure_Date], TM1.[BR_Procedure_PXRadiotherapy], TM1.[BR_Procedure_RadioDate], TM1.[BR_Procedure_RadioTime], TM1.[BR_EncounterID] FROM (([BR_Procedure] TM1 WITH (NOLOCK) LEFT JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = TM1.[BR_EncounterID]) LEFT JOIN [BR_Information] T3 WITH (NOLOCK) ON T3.[BR_Information_ID] = T2.[BR_Information_ID]) WHERE TM1.[BR_ProcedureID] = @BR_ProcedureID ORDER BY TM1.[BR_ProcedureID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000I6,100,0,true,false )
           ,new CursorDef("T000I7", "SELECT [BR_Information_ID] FROM [BR_Encounter] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000I7,1,0,true,false )
           ,new CursorDef("T000I8", "SELECT [BR_Information_PatientNo] FROM [BR_Information] WITH (NOLOCK) WHERE [BR_Information_ID] = @BR_Information_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000I8,1,0,true,false )
           ,new CursorDef("T000I9", "SELECT [BR_ProcedureID] FROM [BR_Procedure] WITH (NOLOCK) WHERE [BR_ProcedureID] = @BR_ProcedureID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000I9,1,0,true,false )
           ,new CursorDef("T000I10", "SELECT TOP 1 [BR_ProcedureID] FROM [BR_Procedure] WITH (NOLOCK) WHERE ( [BR_ProcedureID] > @BR_ProcedureID) ORDER BY [BR_ProcedureID]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000I10,1,0,true,true )
           ,new CursorDef("T000I11", "SELECT TOP 1 [BR_ProcedureID] FROM [BR_Procedure] WITH (NOLOCK) WHERE ( [BR_ProcedureID] < @BR_ProcedureID) ORDER BY [BR_ProcedureID] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000I11,1,0,true,true )
           ,new CursorDef("T000I12", "INSERT INTO [BR_Procedure]([BR_Procedure_PXSurgery_Code], [BR_Procedure_PXRadiotherapy_Code], [BR_Procedure_PXID], [BR_Procedure_PXSurgery], [BR_Procedure_Date], [BR_Procedure_PXRadiotherapy], [BR_Procedure_RadioDate], [BR_Procedure_RadioTime], [BR_EncounterID]) VALUES(@BR_Procedure_PXSurgery_Code, @BR_Procedure_PXRadiotherapy_Code, @BR_Procedure_PXID, @BR_Procedure_PXSurgery, @BR_Procedure_Date, @BR_Procedure_PXRadiotherapy, @BR_Procedure_RadioDate, @BR_Procedure_RadioTime, @BR_EncounterID); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmT000I12)
           ,new CursorDef("T000I13", "UPDATE [BR_Procedure] SET [BR_Procedure_PXSurgery_Code]=@BR_Procedure_PXSurgery_Code, [BR_Procedure_PXRadiotherapy_Code]=@BR_Procedure_PXRadiotherapy_Code, [BR_Procedure_PXID]=@BR_Procedure_PXID, [BR_Procedure_PXSurgery]=@BR_Procedure_PXSurgery, [BR_Procedure_Date]=@BR_Procedure_Date, [BR_Procedure_PXRadiotherapy]=@BR_Procedure_PXRadiotherapy, [BR_Procedure_RadioDate]=@BR_Procedure_RadioDate, [BR_Procedure_RadioTime]=@BR_Procedure_RadioTime, [BR_EncounterID]=@BR_EncounterID  WHERE [BR_ProcedureID] = @BR_ProcedureID", GxErrorMask.GX_NOMASK,prmT000I13)
           ,new CursorDef("T000I14", "DELETE FROM [BR_Procedure]  WHERE [BR_ProcedureID] = @BR_ProcedureID", GxErrorMask.GX_NOMASK,prmT000I14)
           ,new CursorDef("T000I15", "SELECT [BR_Information_ID] FROM [BR_Encounter] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000I15,1,0,true,false )
           ,new CursorDef("T000I16", "SELECT [BR_Information_PatientNo] FROM [BR_Information] WITH (NOLOCK) WHERE [BR_Information_ID] = @BR_Information_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000I16,1,0,true,false )
           ,new CursorDef("T000I17", "SELECT TOP 1 [BR_Procedure_RadioID] FROM [BR_Procedure_Radio] WITH (NOLOCK) WHERE [BR_ProcedureID] = @BR_ProcedureID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000I17,1,0,true,true )
           ,new CursorDef("T000I18", "SELECT TOP 1 [BR_Procedure_SurgeryID] FROM [BR_Procedure_Surgery] WITH (NOLOCK) WHERE [BR_ProcedureID] = @BR_ProcedureID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000I18,1,0,true,true )
           ,new CursorDef("T000I19", "SELECT [BR_ProcedureID] FROM [BR_Procedure] WITH (NOLOCK) ORDER BY [BR_ProcedureID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000I19,100,0,true,false )
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
              ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((DateTime[]) buf[9])[0] = rslt.getGXDate(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              ((DateTime[]) buf[13])[0] = rslt.getGXDate(8) ;
              ((bool[]) buf[14])[0] = rslt.wasNull(8);
              ((decimal[]) buf[15])[0] = rslt.getDecimal(9) ;
              ((bool[]) buf[16])[0] = rslt.wasNull(9);
              ((long[]) buf[17])[0] = rslt.getLong(10) ;
              ((bool[]) buf[18])[0] = rslt.wasNull(10);
              return;
           case 1 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((String[]) buf[3])[0] = rslt.getVarchar(3) ;
              ((bool[]) buf[4])[0] = rslt.wasNull(3);
              ((long[]) buf[5])[0] = rslt.getLong(4) ;
              ((bool[]) buf[6])[0] = rslt.wasNull(4);
              ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
              ((bool[]) buf[8])[0] = rslt.wasNull(5);
              ((DateTime[]) buf[9])[0] = rslt.getGXDate(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              ((DateTime[]) buf[13])[0] = rslt.getGXDate(8) ;
              ((bool[]) buf[14])[0] = rslt.wasNull(8);
              ((decimal[]) buf[15])[0] = rslt.getDecimal(9) ;
              ((bool[]) buf[16])[0] = rslt.wasNull(9);
              ((long[]) buf[17])[0] = rslt.getLong(10) ;
              ((bool[]) buf[18])[0] = rslt.wasNull(10);
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
              ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              ((DateTime[]) buf[13])[0] = rslt.getGXDate(8) ;
              ((bool[]) buf[14])[0] = rslt.wasNull(8);
              ((String[]) buf[15])[0] = rslt.getVarchar(9) ;
              ((bool[]) buf[16])[0] = rslt.wasNull(9);
              ((DateTime[]) buf[17])[0] = rslt.getGXDate(10) ;
              ((bool[]) buf[18])[0] = rslt.wasNull(10);
              ((decimal[]) buf[19])[0] = rslt.getDecimal(11) ;
              ((bool[]) buf[20])[0] = rslt.wasNull(11);
              ((long[]) buf[21])[0] = rslt.getLong(12) ;
              ((bool[]) buf[22])[0] = rslt.wasNull(12);
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
                 stmt.setNull( 3 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(3, (long)parms[5]);
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
                 stmt.setNull( 7 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameter(7, (DateTime)parms[13]);
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
                 stmt.SetParameter(9, (long)parms[17]);
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
                 stmt.setNull( 4 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(4, (String)parms[7]);
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
                 stmt.setNull( 7 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameter(7, (DateTime)parms[13]);
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
                 stmt.SetParameter(9, (long)parms[17]);
              }
              stmt.SetParameter(10, (long)parms[18]);
              return;
           case 12 :
              stmt.SetParameter(1, (long)parms[0]);
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
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 16 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
     }
  }

}

}
