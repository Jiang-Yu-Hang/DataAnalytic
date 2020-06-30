/*
               File: BR_Lab
        Description: Data Mgmt Portal - RAAP
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:7:8.22
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
   public class br_lab : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxJX_Action26") == 0 )
         {
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            XC_26_0G17( ) ;
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
            XC_27_0G17( ) ;
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
            XC_28_0G17( ) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"BR_LAB_SPECIMENSOURCE") == 0 )
         {
            AV16tCurrentCode = GetNextPar( );
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16tCurrentCode", AV16tCurrentCode);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GXDLABR_LAB_SPECIMENSOURCE0G17( AV16tCurrentCode) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"BR_LAB_RESULTQUAL") == 0 )
         {
            AV16tCurrentCode = GetNextPar( );
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16tCurrentCode", AV16tCurrentCode);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GXDLABR_LAB_RESULTQUAL0G17( AV16tCurrentCode) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"BR_LAB_ABNIND") == 0 )
         {
            AV16tCurrentCode = GetNextPar( );
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16tCurrentCode", AV16tCurrentCode);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GXDLABR_LAB_ABNIND0G17( AV16tCurrentCode) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel12"+"_"+"BR_LAB_SPECIMENSOURCE_CODE") == 0 )
         {
            A106BR_Lab_SpecimenSource = GetNextPar( );
            n106BR_Lab_SpecimenSource = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A106BR_Lab_SpecimenSource", A106BR_Lab_SpecimenSource);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX12ASABR_LAB_SPECIMENSOURCE_CODE0G17( A106BR_Lab_SpecimenSource) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel13"+"_"+"BR_LAB_SPECIMENSOURCE_CODE") == 0 )
         {
            A106BR_Lab_SpecimenSource = GetNextPar( );
            n106BR_Lab_SpecimenSource = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A106BR_Lab_SpecimenSource", A106BR_Lab_SpecimenSource);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX13ASABR_LAB_SPECIMENSOURCE_CODE0G17( A106BR_Lab_SpecimenSource) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel14"+"_"+"BR_LAB_RESULTQUAL_CODE") == 0 )
         {
            A109BR_Lab_ResultQual = GetNextPar( );
            n109BR_Lab_ResultQual = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A109BR_Lab_ResultQual", A109BR_Lab_ResultQual);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX14ASABR_LAB_RESULTQUAL_CODE0G17( A109BR_Lab_ResultQual) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel15"+"_"+"BR_LAB_RESULTQUAL_CODE") == 0 )
         {
            A109BR_Lab_ResultQual = GetNextPar( );
            n109BR_Lab_ResultQual = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A109BR_Lab_ResultQual", A109BR_Lab_ResultQual);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX15ASABR_LAB_RESULTQUAL_CODE0G17( A109BR_Lab_ResultQual) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel16"+"_"+"BR_LAB_ABNIND_CODE") == 0 )
         {
            A112BR_Lab_AbnInd = GetNextPar( );
            n112BR_Lab_AbnInd = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A112BR_Lab_AbnInd", A112BR_Lab_AbnInd);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX16ASABR_LAB_ABNIND_CODE0G17( A112BR_Lab_AbnInd) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel17"+"_"+"BR_LAB_ABNIND_CODE") == 0 )
         {
            A112BR_Lab_AbnInd = GetNextPar( );
            n112BR_Lab_AbnInd = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A112BR_Lab_AbnInd", A112BR_Lab_AbnInd);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX17ASABR_LAB_ABNIND_CODE0G17( A112BR_Lab_AbnInd) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_30") == 0 )
         {
            A19BR_EncounterID = (long)(NumberUtil.Val( GetNextPar( ), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_30( A19BR_EncounterID) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_31") == 0 )
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
            gxLoad_31( A85BR_Information_ID) ;
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
               AV12BR_LabID = (long)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12BR_LabID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12BR_LabID), 18, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vBR_LABID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV12BR_LabID), "ZZZZZZZZZZZZZZZZZZ"), context));
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
         GX_FocusControl = edtBR_Lab_TestName_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("WorkWithPlusTheme");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public br_lab( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_lab( IGxContext context )
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
                           long aP1_BR_LabID )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV12BR_LabID = aP1_BR_LabID;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         dynBR_Lab_SpecimenSource = new GXCombobox();
         dynBR_Lab_ResultQual = new GXCombobox();
         dynBR_Lab_AbnInd = new GXCombobox();
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
         if ( dynBR_Lab_SpecimenSource.ItemCount > 0 )
         {
            A106BR_Lab_SpecimenSource = dynBR_Lab_SpecimenSource.getValidValue(A106BR_Lab_SpecimenSource);
            n106BR_Lab_SpecimenSource = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A106BR_Lab_SpecimenSource", A106BR_Lab_SpecimenSource);
         }
         if ( context.isAjaxRequest( ) )
         {
            dynBR_Lab_SpecimenSource.CurrentValue = StringUtil.RTrim( A106BR_Lab_SpecimenSource);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynBR_Lab_SpecimenSource_Internalname, "Values", dynBR_Lab_SpecimenSource.ToJavascriptSource(), true);
         }
         if ( dynBR_Lab_ResultQual.ItemCount > 0 )
         {
            A109BR_Lab_ResultQual = dynBR_Lab_ResultQual.getValidValue(A109BR_Lab_ResultQual);
            n109BR_Lab_ResultQual = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A109BR_Lab_ResultQual", A109BR_Lab_ResultQual);
         }
         if ( context.isAjaxRequest( ) )
         {
            dynBR_Lab_ResultQual.CurrentValue = StringUtil.RTrim( A109BR_Lab_ResultQual);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynBR_Lab_ResultQual_Internalname, "Values", dynBR_Lab_ResultQual.ToJavascriptSource(), true);
         }
         if ( dynBR_Lab_AbnInd.ItemCount > 0 )
         {
            A112BR_Lab_AbnInd = dynBR_Lab_AbnInd.getValidValue(A112BR_Lab_AbnInd);
            n112BR_Lab_AbnInd = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A112BR_Lab_AbnInd", A112BR_Lab_AbnInd);
         }
         if ( context.isAjaxRequest( ) )
         {
            dynBR_Lab_AbnInd.CurrentValue = StringUtil.RTrim( A112BR_Lab_AbnInd);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynBR_Lab_AbnInd_Internalname, "Values", dynBR_Lab_AbnInd.ToJavascriptSource(), true);
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
            GxWebStd.gx_div_start( context, divUnnamedtablebr_lab_testname_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_lab_testname_Internalname, "项目名称", "", "", lblTextblockbr_lab_testname_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Lab.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Lab_TestName_Internalname, "项目名称", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_Lab_TestName_Internalname, A104BR_Lab_TestName, StringUtil.RTrim( context.localUtil.Format( A104BR_Lab_TestName, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,29);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Lab_TestName_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBR_Lab_TestName_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Lab.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_lab_testengname_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_lab_testengname_Internalname, "项目英文名称", "", "", lblTextblockbr_lab_testengname_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Lab.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Lab_TestEngName_Internalname, "项目英文名称", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 37,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_Lab_TestEngName_Internalname, A261BR_Lab_TestEngName, StringUtil.RTrim( context.localUtil.Format( A261BR_Lab_TestEngName, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,37);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Lab_TestEngName_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBR_Lab_TestEngName_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Lab.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_Lab_TestCode_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Lab_TestCode_Internalname, "检查项目编码", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 42,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_Lab_TestCode_Internalname, A103BR_Lab_TestCode, StringUtil.RTrim( context.localUtil.Format( A103BR_Lab_TestCode, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,42);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Lab_TestCode_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBR_Lab_TestCode_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Lab.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_lab_age_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_lab_age_Internalname, "年龄", "", "", lblTextblockbr_lab_age_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Lab.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Lab_Age_Internalname, "年龄", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 50,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_Lab_Age_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A262BR_Lab_Age), 3, 0, ".", "")), ((edtBR_Lab_Age_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A262BR_Lab_Age), "ZZZ")) : context.localUtil.Format( (decimal)(A262BR_Lab_Age), "ZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,50);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Lab_Age_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBR_Lab_Age_Enabled, 0, "number", "1", 3, "chr", 1, "row", 3, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Lab.htm");
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
            GxWebStd.gx_div_start( context, divUnnamedtablebr_lab_diag_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_lab_diag_Internalname, "临床诊断", "", "", lblTextblockbr_lab_diag_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Lab.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Lab_Diag_Internalname, "临床诊断", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 59,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_Lab_Diag_Internalname, A263BR_Lab_Diag, StringUtil.RTrim( context.localUtil.Format( A263BR_Lab_Diag, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,59);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Lab_Diag_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBR_Lab_Diag_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Lab.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablesplittedbr_lab_specimensource_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_lab_specimensource_Internalname, "标本种类", "", "", lblTextblockbr_lab_specimensource_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Lab.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            wb_table1_66_0G17( true) ;
         }
         return  ;
      }

      protected void wb_table1_66_0G17e( bool wbgen )
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
            GxWebStd.gx_div_start( context, divUnnamedtablebr_lab_specimendate_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_lab_specimendate_Internalname, "采样时间", "", "", lblTextblockbr_lab_specimendate_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Lab.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Lab_SpecimenDate_Internalname, "采样时间", "col-sm-3 AttributeDateTimeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 82,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtBR_Lab_SpecimenDate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtBR_Lab_SpecimenDate_Internalname, context.localUtil.TToC( A105BR_Lab_SpecimenDate, 10, 8, 0, 0, "/", ":", " "), context.localUtil.Format( A105BR_Lab_SpecimenDate, "9999/99/99 99:99:99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',8,24,'chs',false,1);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,82);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Lab_SpecimenDate_Jsonclick, 0, "AttributeDateTime", "", "", "", "", 1, edtBR_Lab_SpecimenDate_Enabled, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, true, "DM_DataTime", "right", false, "HLP_BR_Lab.htm");
            GxWebStd.gx_bitmap( context, edtBR_Lab_SpecimenDate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtBR_Lab_SpecimenDate_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_Lab.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_lab_receivingtime_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_lab_receivingtime_Internalname, "接收时间", "", "", lblTextblockbr_lab_receivingtime_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Lab.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Lab_ReceivingTime_Internalname, "接收时间", "col-sm-3 AttributeDateTimeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 90,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtBR_Lab_ReceivingTime_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtBR_Lab_ReceivingTime_Internalname, context.localUtil.TToC( A264BR_Lab_ReceivingTime, 10, 8, 0, 0, "/", ":", " "), context.localUtil.Format( A264BR_Lab_ReceivingTime, "9999/99/99 99:99:99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',8,24,'chs',false,1);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,90);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Lab_ReceivingTime_Jsonclick, 0, "AttributeDateTime", "", "", "", "", 1, edtBR_Lab_ReceivingTime_Enabled, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, true, "DM_DataTime", "right", false, "HLP_BR_Lab.htm");
            GxWebStd.gx_bitmap( context, edtBR_Lab_ReceivingTime_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtBR_Lab_ReceivingTime_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_Lab.htm");
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
            GxWebStd.gx_div_start( context, divUnnamedtablebr_lab_reporttime_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_lab_reporttime_Internalname, "报告时间", "", "", lblTextblockbr_lab_reporttime_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Lab.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Lab_ReportTime_Internalname, "报告时间", "col-sm-3 AttributeDateTimeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 99,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtBR_Lab_ReportTime_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtBR_Lab_ReportTime_Internalname, context.localUtil.TToC( A265BR_Lab_ReportTime, 10, 8, 0, 0, "/", ":", " "), context.localUtil.Format( A265BR_Lab_ReportTime, "9999/99/99 99:99:99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',8,24,'chs',false,1);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,99);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Lab_ReportTime_Jsonclick, 0, "AttributeDateTime", "", "", "", "", 1, edtBR_Lab_ReportTime_Enabled, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, true, "DM_DataTime", "right", false, "HLP_BR_Lab.htm");
            GxWebStd.gx_bitmap( context, edtBR_Lab_ReportTime_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtBR_Lab_ReportTime_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_Lab.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_lab_resultqual_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_lab_resultqual_Internalname, "定性结果", "", "", lblTextblockbr_lab_resultqual_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Lab.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynBR_Lab_ResultQual_Internalname, "定性结果", "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 107,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynBR_Lab_ResultQual, dynBR_Lab_ResultQual_Internalname, StringUtil.RTrim( A109BR_Lab_ResultQual), 1, dynBR_Lab_ResultQual_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, dynBR_Lab_ResultQual.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,107);\"", "", true, "HLP_BR_Lab.htm");
            dynBR_Lab_ResultQual.CurrentValue = StringUtil.RTrim( A109BR_Lab_ResultQual);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynBR_Lab_ResultQual_Internalname, "Values", (String)(dynBR_Lab_ResultQual.ToJavascriptSource()), true);
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
            GxWebStd.gx_div_start( context, divUnnamedtablebr_lab_resultunit_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_lab_resultunit_Internalname, "结果单位", "", "", lblTextblockbr_lab_resultunit_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Lab.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Lab_ResultUnit_Internalname, "结果单位", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 116,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_Lab_ResultUnit_Internalname, A111BR_Lab_ResultUnit, StringUtil.RTrim( context.localUtil.Format( A111BR_Lab_ResultUnit, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,116);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Lab_ResultUnit_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBR_Lab_ResultUnit_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Lab.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_lab_abnind_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_lab_abnind_Internalname, "结果提示", "", "", lblTextblockbr_lab_abnind_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Lab.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynBR_Lab_AbnInd_Internalname, "结果提示", "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 124,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynBR_Lab_AbnInd, dynBR_Lab_AbnInd_Internalname, StringUtil.RTrim( A112BR_Lab_AbnInd), 1, dynBR_Lab_AbnInd_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, dynBR_Lab_AbnInd.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,124);\"", "", true, "HLP_BR_Lab.htm");
            dynBR_Lab_AbnInd.CurrentValue = StringUtil.RTrim( A112BR_Lab_AbnInd);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynBR_Lab_AbnInd_Internalname, "Values", (String)(dynBR_Lab_AbnInd.ToJavascriptSource()), true);
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
            GxWebStd.gx_div_start( context, divUnnamedtablebr_lab_normrangelow_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_lab_normrangelow_Internalname, "参考值范围", "", "", lblTextblockbr_lab_normrangelow_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Lab.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Lab_NormRangeLow_Internalname, "参考值下限", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 133,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_Lab_NormRangeLow_Internalname, A113BR_Lab_NormRangeLow, StringUtil.RTrim( context.localUtil.Format( A113BR_Lab_NormRangeLow, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,133);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Lab_NormRangeLow_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBR_Lab_NormRangeLow_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Lab.htm");
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
            GxWebStd.gx_div_start( context, divUnnamedtablebr_lab_testmethod_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_lab_testmethod_Internalname, "检测方法", "", "", lblTextblockbr_lab_testmethod_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Lab.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Lab_TestMethod_Internalname, "检测方法", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 142,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_Lab_TestMethod_Internalname, A115BR_Lab_TestMethod, StringUtil.RTrim( context.localUtil.Format( A115BR_Lab_TestMethod, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,142);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Lab_TestMethod_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBR_Lab_TestMethod_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Lab.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_lab_instrumentcode_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_lab_instrumentcode_Internalname, "设备编码", "", "", lblTextblockbr_lab_instrumentcode_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Lab.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Lab_InstrumentCode_Internalname, "设备编码", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 150,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_Lab_InstrumentCode_Internalname, A118BR_Lab_InstrumentCode, StringUtil.RTrim( context.localUtil.Format( A118BR_Lab_InstrumentCode, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,150);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Lab_InstrumentCode_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBR_Lab_InstrumentCode_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Lab.htm");
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
            GxWebStd.gx_div_start( context, divUnnamedtablebr_lab_instrumentname_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_lab_instrumentname_Internalname, "设备名称", "", "", lblTextblockbr_lab_instrumentname_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Lab.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Lab_InstrumentName_Internalname, "设备名称", "col-sm-3 AttributeLabel", 0, true);
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 159,'',false,'',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtBR_Lab_InstrumentName_Internalname, A117BR_Lab_InstrumentName, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,159);\"", 0, 1, edtBR_Lab_InstrumentName_Enabled, 0, 80, "chr", 3, "row", StyleString, ClassString, "", "", "200", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Lab.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_lab_resultnum_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_lab_resultnum_Internalname, "定量结果", "", "", lblTextblockbr_lab_resultnum_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Lab.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Lab_ResultNum_Internalname, "定量结果", "col-sm-3 AttributeLabel", 0, true);
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 167,'',false,'',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtBR_Lab_ResultNum_Internalname, A110BR_Lab_ResultNum, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,167);\"", 0, 1, edtBR_Lab_ResultNum_Enabled, 0, 80, "chr", 7, "row", StyleString, ClassString, "", "", "500", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Lab.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 172,'',false,'',0)\"";
            ClassString = "ButtonMaterial";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_enter_Internalname, "", "保存", bttBtntrn_enter_Jsonclick, 5, "确认", "", StyleString, ClassString, bttBtntrn_enter_Visible, bttBtntrn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_Lab.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 174,'',false,'',0)\"";
            ClassString = "ButtonMaterialDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_cancel_Internalname, "", "取消", bttBtntrn_cancel_Jsonclick, 1, "取消", "", StyleString, ClassString, bttBtntrn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_Lab.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 176,'',false,'',0)\"";
            ClassString = "ButtonMaterialDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_delete_Internalname, "", "删除", bttBtntrn_delete_Jsonclick, 5, "删除", "", StyleString, ClassString, bttBtntrn_delete_Visible, bttBtntrn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_Lab.htm");
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
            GxWebStd.gx_single_line_edit( context, edtBR_LabID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A101BR_LabID), 18, 0, ".", "")), ((edtBR_LabID_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A101BR_LabID), "ZZZZZZZZZZZZZZZZZZ")) : context.localUtil.Format( (decimal)(A101BR_LabID), "ZZZZZZZZZZZZZZZZZZ")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_LabID_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_LabID_Visible, edtBR_LabID_Enabled, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "HLP_BR_Lab.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 181,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_EncounterID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A19BR_EncounterID), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A19BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,181);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_EncounterID_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_EncounterID_Visible, edtBR_EncounterID_Enabled, 1, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "HLP_BR_Lab.htm");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Information_PatientNo_Internalname, A36BR_Information_PatientNo, StringUtil.RTrim( context.localUtil.Format( A36BR_Information_PatientNo, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Information_PatientNo_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_Information_PatientNo_Visible, edtBR_Information_PatientNo_Enabled, 0, "text", "", 80, "chr", 1, "row", 2000, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Lab.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 183,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_Lab_TestID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A102BR_Lab_TestID), 10, 0, ".", "")), ((edtBR_Lab_TestID_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A102BR_Lab_TestID), "ZZZZZZZZZZ")) : context.localUtil.Format( (decimal)(A102BR_Lab_TestID), "ZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,183);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Lab_TestID_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_Lab_TestID_Visible, edtBR_Lab_TestID_Enabled, 0, "number", "1", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Lab.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 184,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_Lab_NormRangeHigh_Internalname, A114BR_Lab_NormRangeHigh, StringUtil.RTrim( context.localUtil.Format( A114BR_Lab_NormRangeHigh, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,184);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Lab_NormRangeHigh_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_Lab_NormRangeHigh_Visible, edtBR_Lab_NormRangeHigh_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Lab.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            fix_multi_value_controls( ) ;
         }
         /* Execute Exit event if defined. */
      }

      protected void wb_table1_66_0G17( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTablemergedbr_lab_specimensource_Internalname, tblTablemergedbr_lab_specimensource_Internalname, "", "TableMerged", 0, "", "", 0, 0, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='MergeDataCell'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynBR_Lab_SpecimenSource_Internalname, "标本种类", "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 70,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynBR_Lab_SpecimenSource, dynBR_Lab_SpecimenSource_Internalname, StringUtil.RTrim( A106BR_Lab_SpecimenSource), 1, dynBR_Lab_SpecimenSource_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, dynBR_Lab_SpecimenSource.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,70);\"", "", true, "HLP_BR_Lab.htm");
            dynBR_Lab_SpecimenSource.CurrentValue = StringUtil.RTrim( A106BR_Lab_SpecimenSource);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynBR_Lab_SpecimenSource_Internalname, "Values", (String)(dynBR_Lab_SpecimenSource.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\""+cellVsource_cell_Internalname+"\"  class='"+cellVsource_cell_Class+"'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavVsource_Internalname, "v Source", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 73,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavVsource_Internalname, AV15vSource, StringUtil.RTrim( context.localUtil.Format( AV15vSource, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,73);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "请填写其它标本种类", edtavVsource_Jsonclick, 0, "Attribute", "", "", "", "", edtavVsource_Visible, edtavVsource_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Lab.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_66_0G17e( true) ;
         }
         else
         {
            wb_table1_66_0G17e( false) ;
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
         E110G2 ();
         context.wbGlbDoneStart = 1;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
               A104BR_Lab_TestName = cgiGet( edtBR_Lab_TestName_Internalname);
               n104BR_Lab_TestName = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A104BR_Lab_TestName", A104BR_Lab_TestName);
               n104BR_Lab_TestName = (String.IsNullOrEmpty(StringUtil.RTrim( A104BR_Lab_TestName)) ? true : false);
               A261BR_Lab_TestEngName = cgiGet( edtBR_Lab_TestEngName_Internalname);
               n261BR_Lab_TestEngName = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A261BR_Lab_TestEngName", A261BR_Lab_TestEngName);
               n261BR_Lab_TestEngName = (String.IsNullOrEmpty(StringUtil.RTrim( A261BR_Lab_TestEngName)) ? true : false);
               A103BR_Lab_TestCode = cgiGet( edtBR_Lab_TestCode_Internalname);
               n103BR_Lab_TestCode = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A103BR_Lab_TestCode", A103BR_Lab_TestCode);
               n103BR_Lab_TestCode = (String.IsNullOrEmpty(StringUtil.RTrim( A103BR_Lab_TestCode)) ? true : false);
               if ( ( ( context.localUtil.CToN( cgiGet( edtBR_Lab_Age_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtBR_Lab_Age_Internalname), ".", ",") > Convert.ToDecimal( 999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_LAB_AGE");
                  AnyError = 1;
                  GX_FocusControl = edtBR_Lab_Age_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A262BR_Lab_Age = 0;
                  n262BR_Lab_Age = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A262BR_Lab_Age", StringUtil.LTrim( StringUtil.Str( (decimal)(A262BR_Lab_Age), 3, 0)));
               }
               else
               {
                  A262BR_Lab_Age = (short)(context.localUtil.CToN( cgiGet( edtBR_Lab_Age_Internalname), ".", ","));
                  n262BR_Lab_Age = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A262BR_Lab_Age", StringUtil.LTrim( StringUtil.Str( (decimal)(A262BR_Lab_Age), 3, 0)));
               }
               n262BR_Lab_Age = ((0==A262BR_Lab_Age) ? true : false);
               A263BR_Lab_Diag = cgiGet( edtBR_Lab_Diag_Internalname);
               n263BR_Lab_Diag = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A263BR_Lab_Diag", A263BR_Lab_Diag);
               n263BR_Lab_Diag = (String.IsNullOrEmpty(StringUtil.RTrim( A263BR_Lab_Diag)) ? true : false);
               dynBR_Lab_SpecimenSource.CurrentValue = cgiGet( dynBR_Lab_SpecimenSource_Internalname);
               A106BR_Lab_SpecimenSource = cgiGet( dynBR_Lab_SpecimenSource_Internalname);
               n106BR_Lab_SpecimenSource = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A106BR_Lab_SpecimenSource", A106BR_Lab_SpecimenSource);
               n106BR_Lab_SpecimenSource = (String.IsNullOrEmpty(StringUtil.RTrim( A106BR_Lab_SpecimenSource)) ? true : false);
               AV15vSource = cgiGet( edtavVsource_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15vSource", AV15vSource);
               if ( context.localUtil.VCDateTime( cgiGet( edtBR_Lab_SpecimenDate_Internalname), 0, 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"采样时间"}), 1, "BR_LAB_SPECIMENDATE");
                  AnyError = 1;
                  GX_FocusControl = edtBR_Lab_SpecimenDate_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A105BR_Lab_SpecimenDate = (DateTime)(DateTime.MinValue);
                  n105BR_Lab_SpecimenDate = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A105BR_Lab_SpecimenDate", context.localUtil.TToC( A105BR_Lab_SpecimenDate, 10, 8, 0, 0, "/", ":", " "));
               }
               else
               {
                  A105BR_Lab_SpecimenDate = context.localUtil.CToT( cgiGet( edtBR_Lab_SpecimenDate_Internalname));
                  n105BR_Lab_SpecimenDate = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A105BR_Lab_SpecimenDate", context.localUtil.TToC( A105BR_Lab_SpecimenDate, 10, 8, 0, 0, "/", ":", " "));
               }
               n105BR_Lab_SpecimenDate = ((DateTime.MinValue==A105BR_Lab_SpecimenDate) ? true : false);
               if ( context.localUtil.VCDateTime( cgiGet( edtBR_Lab_ReceivingTime_Internalname), 0, 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"接收时间"}), 1, "BR_LAB_RECEIVINGTIME");
                  AnyError = 1;
                  GX_FocusControl = edtBR_Lab_ReceivingTime_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A264BR_Lab_ReceivingTime = (DateTime)(DateTime.MinValue);
                  n264BR_Lab_ReceivingTime = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A264BR_Lab_ReceivingTime", context.localUtil.TToC( A264BR_Lab_ReceivingTime, 10, 8, 0, 0, "/", ":", " "));
               }
               else
               {
                  A264BR_Lab_ReceivingTime = context.localUtil.CToT( cgiGet( edtBR_Lab_ReceivingTime_Internalname));
                  n264BR_Lab_ReceivingTime = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A264BR_Lab_ReceivingTime", context.localUtil.TToC( A264BR_Lab_ReceivingTime, 10, 8, 0, 0, "/", ":", " "));
               }
               n264BR_Lab_ReceivingTime = ((DateTime.MinValue==A264BR_Lab_ReceivingTime) ? true : false);
               if ( context.localUtil.VCDateTime( cgiGet( edtBR_Lab_ReportTime_Internalname), 0, 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"报告时间"}), 1, "BR_LAB_REPORTTIME");
                  AnyError = 1;
                  GX_FocusControl = edtBR_Lab_ReportTime_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A265BR_Lab_ReportTime = (DateTime)(DateTime.MinValue);
                  n265BR_Lab_ReportTime = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A265BR_Lab_ReportTime", context.localUtil.TToC( A265BR_Lab_ReportTime, 10, 8, 0, 0, "/", ":", " "));
               }
               else
               {
                  A265BR_Lab_ReportTime = context.localUtil.CToT( cgiGet( edtBR_Lab_ReportTime_Internalname));
                  n265BR_Lab_ReportTime = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A265BR_Lab_ReportTime", context.localUtil.TToC( A265BR_Lab_ReportTime, 10, 8, 0, 0, "/", ":", " "));
               }
               n265BR_Lab_ReportTime = ((DateTime.MinValue==A265BR_Lab_ReportTime) ? true : false);
               dynBR_Lab_ResultQual.CurrentValue = cgiGet( dynBR_Lab_ResultQual_Internalname);
               A109BR_Lab_ResultQual = cgiGet( dynBR_Lab_ResultQual_Internalname);
               n109BR_Lab_ResultQual = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A109BR_Lab_ResultQual", A109BR_Lab_ResultQual);
               n109BR_Lab_ResultQual = (String.IsNullOrEmpty(StringUtil.RTrim( A109BR_Lab_ResultQual)) ? true : false);
               A111BR_Lab_ResultUnit = cgiGet( edtBR_Lab_ResultUnit_Internalname);
               n111BR_Lab_ResultUnit = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A111BR_Lab_ResultUnit", A111BR_Lab_ResultUnit);
               n111BR_Lab_ResultUnit = (String.IsNullOrEmpty(StringUtil.RTrim( A111BR_Lab_ResultUnit)) ? true : false);
               dynBR_Lab_AbnInd.CurrentValue = cgiGet( dynBR_Lab_AbnInd_Internalname);
               A112BR_Lab_AbnInd = cgiGet( dynBR_Lab_AbnInd_Internalname);
               n112BR_Lab_AbnInd = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A112BR_Lab_AbnInd", A112BR_Lab_AbnInd);
               n112BR_Lab_AbnInd = (String.IsNullOrEmpty(StringUtil.RTrim( A112BR_Lab_AbnInd)) ? true : false);
               A113BR_Lab_NormRangeLow = cgiGet( edtBR_Lab_NormRangeLow_Internalname);
               n113BR_Lab_NormRangeLow = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A113BR_Lab_NormRangeLow", A113BR_Lab_NormRangeLow);
               n113BR_Lab_NormRangeLow = (String.IsNullOrEmpty(StringUtil.RTrim( A113BR_Lab_NormRangeLow)) ? true : false);
               A115BR_Lab_TestMethod = cgiGet( edtBR_Lab_TestMethod_Internalname);
               n115BR_Lab_TestMethod = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A115BR_Lab_TestMethod", A115BR_Lab_TestMethod);
               n115BR_Lab_TestMethod = (String.IsNullOrEmpty(StringUtil.RTrim( A115BR_Lab_TestMethod)) ? true : false);
               A118BR_Lab_InstrumentCode = cgiGet( edtBR_Lab_InstrumentCode_Internalname);
               n118BR_Lab_InstrumentCode = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A118BR_Lab_InstrumentCode", A118BR_Lab_InstrumentCode);
               n118BR_Lab_InstrumentCode = (String.IsNullOrEmpty(StringUtil.RTrim( A118BR_Lab_InstrumentCode)) ? true : false);
               A117BR_Lab_InstrumentName = cgiGet( edtBR_Lab_InstrumentName_Internalname);
               n117BR_Lab_InstrumentName = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A117BR_Lab_InstrumentName", A117BR_Lab_InstrumentName);
               n117BR_Lab_InstrumentName = (String.IsNullOrEmpty(StringUtil.RTrim( A117BR_Lab_InstrumentName)) ? true : false);
               A110BR_Lab_ResultNum = cgiGet( edtBR_Lab_ResultNum_Internalname);
               n110BR_Lab_ResultNum = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A110BR_Lab_ResultNum", A110BR_Lab_ResultNum);
               n110BR_Lab_ResultNum = (String.IsNullOrEmpty(StringUtil.RTrim( A110BR_Lab_ResultNum)) ? true : false);
               A101BR_LabID = (long)(context.localUtil.CToN( cgiGet( edtBR_LabID_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A101BR_LabID", StringUtil.LTrim( StringUtil.Str( (decimal)(A101BR_LabID), 18, 0)));
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
               if ( ( ( context.localUtil.CToN( cgiGet( edtBR_Lab_TestID_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtBR_Lab_TestID_Internalname), ".", ",") > Convert.ToDecimal( 9999999999L )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_LAB_TESTID");
                  AnyError = 1;
                  GX_FocusControl = edtBR_Lab_TestID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A102BR_Lab_TestID = 0;
                  n102BR_Lab_TestID = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A102BR_Lab_TestID", StringUtil.LTrim( StringUtil.Str( (decimal)(A102BR_Lab_TestID), 10, 0)));
               }
               else
               {
                  A102BR_Lab_TestID = (long)(context.localUtil.CToN( cgiGet( edtBR_Lab_TestID_Internalname), ".", ","));
                  n102BR_Lab_TestID = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A102BR_Lab_TestID", StringUtil.LTrim( StringUtil.Str( (decimal)(A102BR_Lab_TestID), 10, 0)));
               }
               n102BR_Lab_TestID = ((0==A102BR_Lab_TestID) ? true : false);
               A114BR_Lab_NormRangeHigh = cgiGet( edtBR_Lab_NormRangeHigh_Internalname);
               n114BR_Lab_NormRangeHigh = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A114BR_Lab_NormRangeHigh", A114BR_Lab_NormRangeHigh);
               n114BR_Lab_NormRangeHigh = (String.IsNullOrEmpty(StringUtil.RTrim( A114BR_Lab_NormRangeHigh)) ? true : false);
               /* Read saved values. */
               Z101BR_LabID = (long)(context.localUtil.CToN( cgiGet( "Z101BR_LabID"), ".", ","));
               Z474BR_Lab_SpecimenSource_Code = cgiGet( "Z474BR_Lab_SpecimenSource_Code");
               n474BR_Lab_SpecimenSource_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A474BR_Lab_SpecimenSource_Code)) ? true : false);
               Z475BR_Lab_ResultQual_Code = cgiGet( "Z475BR_Lab_ResultQual_Code");
               n475BR_Lab_ResultQual_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A475BR_Lab_ResultQual_Code)) ? true : false);
               Z476BR_Lab_AbnInd_Code = cgiGet( "Z476BR_Lab_AbnInd_Code");
               n476BR_Lab_AbnInd_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A476BR_Lab_AbnInd_Code)) ? true : false);
               Z224BR_Lab_SampleID = cgiGet( "Z224BR_Lab_SampleID");
               n224BR_Lab_SampleID = (String.IsNullOrEmpty(StringUtil.RTrim( A224BR_Lab_SampleID)) ? true : false);
               Z102BR_Lab_TestID = (long)(context.localUtil.CToN( cgiGet( "Z102BR_Lab_TestID"), ".", ","));
               n102BR_Lab_TestID = ((0==A102BR_Lab_TestID) ? true : false);
               Z103BR_Lab_TestCode = cgiGet( "Z103BR_Lab_TestCode");
               n103BR_Lab_TestCode = (String.IsNullOrEmpty(StringUtil.RTrim( A103BR_Lab_TestCode)) ? true : false);
               Z104BR_Lab_TestName = cgiGet( "Z104BR_Lab_TestName");
               n104BR_Lab_TestName = (String.IsNullOrEmpty(StringUtil.RTrim( A104BR_Lab_TestName)) ? true : false);
               Z261BR_Lab_TestEngName = cgiGet( "Z261BR_Lab_TestEngName");
               n261BR_Lab_TestEngName = (String.IsNullOrEmpty(StringUtil.RTrim( A261BR_Lab_TestEngName)) ? true : false);
               Z262BR_Lab_Age = (short)(context.localUtil.CToN( cgiGet( "Z262BR_Lab_Age"), ".", ","));
               n262BR_Lab_Age = ((0==A262BR_Lab_Age) ? true : false);
               Z263BR_Lab_Diag = cgiGet( "Z263BR_Lab_Diag");
               n263BR_Lab_Diag = (String.IsNullOrEmpty(StringUtil.RTrim( A263BR_Lab_Diag)) ? true : false);
               Z105BR_Lab_SpecimenDate = context.localUtil.CToT( cgiGet( "Z105BR_Lab_SpecimenDate"), 0);
               n105BR_Lab_SpecimenDate = ((DateTime.MinValue==A105BR_Lab_SpecimenDate) ? true : false);
               Z264BR_Lab_ReceivingTime = context.localUtil.CToT( cgiGet( "Z264BR_Lab_ReceivingTime"), 0);
               n264BR_Lab_ReceivingTime = ((DateTime.MinValue==A264BR_Lab_ReceivingTime) ? true : false);
               Z265BR_Lab_ReportTime = context.localUtil.CToT( cgiGet( "Z265BR_Lab_ReportTime"), 0);
               n265BR_Lab_ReportTime = ((DateTime.MinValue==A265BR_Lab_ReportTime) ? true : false);
               Z106BR_Lab_SpecimenSource = cgiGet( "Z106BR_Lab_SpecimenSource");
               n106BR_Lab_SpecimenSource = (String.IsNullOrEmpty(StringUtil.RTrim( A106BR_Lab_SpecimenSource)) ? true : false);
               Z109BR_Lab_ResultQual = cgiGet( "Z109BR_Lab_ResultQual");
               n109BR_Lab_ResultQual = (String.IsNullOrEmpty(StringUtil.RTrim( A109BR_Lab_ResultQual)) ? true : false);
               Z110BR_Lab_ResultNum = cgiGet( "Z110BR_Lab_ResultNum");
               n110BR_Lab_ResultNum = (String.IsNullOrEmpty(StringUtil.RTrim( A110BR_Lab_ResultNum)) ? true : false);
               Z111BR_Lab_ResultUnit = cgiGet( "Z111BR_Lab_ResultUnit");
               n111BR_Lab_ResultUnit = (String.IsNullOrEmpty(StringUtil.RTrim( A111BR_Lab_ResultUnit)) ? true : false);
               Z112BR_Lab_AbnInd = cgiGet( "Z112BR_Lab_AbnInd");
               n112BR_Lab_AbnInd = (String.IsNullOrEmpty(StringUtil.RTrim( A112BR_Lab_AbnInd)) ? true : false);
               Z113BR_Lab_NormRangeLow = cgiGet( "Z113BR_Lab_NormRangeLow");
               n113BR_Lab_NormRangeLow = (String.IsNullOrEmpty(StringUtil.RTrim( A113BR_Lab_NormRangeLow)) ? true : false);
               Z114BR_Lab_NormRangeHigh = cgiGet( "Z114BR_Lab_NormRangeHigh");
               n114BR_Lab_NormRangeHigh = (String.IsNullOrEmpty(StringUtil.RTrim( A114BR_Lab_NormRangeHigh)) ? true : false);
               Z115BR_Lab_TestMethod = cgiGet( "Z115BR_Lab_TestMethod");
               n115BR_Lab_TestMethod = (String.IsNullOrEmpty(StringUtil.RTrim( A115BR_Lab_TestMethod)) ? true : false);
               Z117BR_Lab_InstrumentName = cgiGet( "Z117BR_Lab_InstrumentName");
               n117BR_Lab_InstrumentName = (String.IsNullOrEmpty(StringUtil.RTrim( A117BR_Lab_InstrumentName)) ? true : false);
               Z118BR_Lab_InstrumentCode = cgiGet( "Z118BR_Lab_InstrumentCode");
               n118BR_Lab_InstrumentCode = (String.IsNullOrEmpty(StringUtil.RTrim( A118BR_Lab_InstrumentCode)) ? true : false);
               Z430BR_SampleId = (long)(context.localUtil.CToN( cgiGet( "Z430BR_SampleId"), ".", ","));
               n430BR_SampleId = ((0==A430BR_SampleId) ? true : false);
               Z19BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( "Z19BR_EncounterID"), ".", ","));
               A474BR_Lab_SpecimenSource_Code = cgiGet( "Z474BR_Lab_SpecimenSource_Code");
               n474BR_Lab_SpecimenSource_Code = false;
               n474BR_Lab_SpecimenSource_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A474BR_Lab_SpecimenSource_Code)) ? true : false);
               A475BR_Lab_ResultQual_Code = cgiGet( "Z475BR_Lab_ResultQual_Code");
               n475BR_Lab_ResultQual_Code = false;
               n475BR_Lab_ResultQual_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A475BR_Lab_ResultQual_Code)) ? true : false);
               A476BR_Lab_AbnInd_Code = cgiGet( "Z476BR_Lab_AbnInd_Code");
               n476BR_Lab_AbnInd_Code = false;
               n476BR_Lab_AbnInd_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A476BR_Lab_AbnInd_Code)) ? true : false);
               A224BR_Lab_SampleID = cgiGet( "Z224BR_Lab_SampleID");
               n224BR_Lab_SampleID = false;
               n224BR_Lab_SampleID = (String.IsNullOrEmpty(StringUtil.RTrim( A224BR_Lab_SampleID)) ? true : false);
               A430BR_SampleId = (long)(context.localUtil.CToN( cgiGet( "Z430BR_SampleId"), ".", ","));
               n430BR_SampleId = false;
               n430BR_SampleId = ((0==A430BR_SampleId) ? true : false);
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ","));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ","));
               Gx_mode = cgiGet( "Mode");
               N19BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( "N19BR_EncounterID"), ".", ","));
               AV12BR_LabID = (long)(context.localUtil.CToN( cgiGet( "vBR_LABID"), ".", ","));
               AV10Insert_BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( "vINSERT_BR_ENCOUNTERID"), ".", ","));
               A474BR_Lab_SpecimenSource_Code = cgiGet( "BR_LAB_SPECIMENSOURCE_CODE");
               n474BR_Lab_SpecimenSource_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A474BR_Lab_SpecimenSource_Code)) ? true : false);
               A475BR_Lab_ResultQual_Code = cgiGet( "BR_LAB_RESULTQUAL_CODE");
               n475BR_Lab_ResultQual_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A475BR_Lab_ResultQual_Code)) ? true : false);
               A476BR_Lab_AbnInd_Code = cgiGet( "BR_LAB_ABNIND_CODE");
               n476BR_Lab_AbnInd_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A476BR_Lab_AbnInd_Code)) ? true : false);
               AV16tCurrentCode = cgiGet( "vTCURRENTCODE");
               A224BR_Lab_SampleID = cgiGet( "BR_LAB_SAMPLEID");
               n224BR_Lab_SampleID = (String.IsNullOrEmpty(StringUtil.RTrim( A224BR_Lab_SampleID)) ? true : false);
               A430BR_SampleId = (long)(context.localUtil.CToN( cgiGet( "BR_SAMPLEID"), ".", ","));
               n430BR_SampleId = ((0==A430BR_SampleId) ? true : false);
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
               forbiddenHiddens = "hsh" + "BR_Lab";
               A101BR_LabID = (long)(context.localUtil.CToN( cgiGet( edtBR_LabID_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A101BR_LabID", StringUtil.LTrim( StringUtil.Str( (decimal)(A101BR_LabID), 18, 0)));
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A101BR_LabID), "ZZZZZZZZZZZZZZZZZZ");
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( AV16tCurrentCode, ""));
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV10Insert_BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ");
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A224BR_Lab_SampleID, ""));
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A430BR_SampleId), "ZZZZZZZZZZZZZZZZZZ");
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( A101BR_LabID != Z101BR_LabID ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
               {
                  GXUtil.WriteLog("br_lab:[SecurityCheckFailed value for]"+"BR_LabID:"+context.localUtil.Format( (decimal)(A101BR_LabID), "ZZZZZZZZZZZZZZZZZZ"));
                  GXUtil.WriteLog("br_lab:[SecurityCheckFailed value for]"+"tCurrentCode:"+StringUtil.RTrim( context.localUtil.Format( AV16tCurrentCode, "")));
                  GXUtil.WriteLog("br_lab:[SecurityCheckFailed value for]"+"Insert_BR_EncounterID:"+context.localUtil.Format( (decimal)(AV10Insert_BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ"));
                  GXUtil.WriteLog("br_lab:[SecurityCheckFailed value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
                  GXUtil.WriteLog("br_lab:[SecurityCheckFailed value for]"+"BR_Lab_SampleID:"+StringUtil.RTrim( context.localUtil.Format( A224BR_Lab_SampleID, "")));
                  GXUtil.WriteLog("br_lab:[SecurityCheckFailed value for]"+"BR_SampleId:"+context.localUtil.Format( (decimal)(A430BR_SampleId), "ZZZZZZZZZZZZZZZZZZ"));
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
                  A101BR_LabID = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A101BR_LabID", StringUtil.LTrim( StringUtil.Str( (decimal)(A101BR_LabID), 18, 0)));
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
                     sMode17 = Gx_mode;
                     Gx_mode = "UPD";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     Gx_mode = sMode17;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound17 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_0G0( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtntrn_enter_Internalname;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert", ""), 1, "BR_LABID");
                        AnyError = 1;
                        GX_FocusControl = edtBR_LabID_Internalname;
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
                           E110G2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: After Trn */
                           E120G2 ();
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
            E120G2 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll0G17( ) ;
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
            DisableAttributes0G17( ) ;
         }
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVsource_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVsource_Enabled), 5, 0)), true);
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

      protected void CONFIRM_0G0( )
      {
         BeforeValidate0G17( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0G17( ) ;
            }
            else
            {
               CheckExtendedTable0G17( ) ;
               CloseExtendedTableCursors0G17( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         }
      }

      protected void ResetCaption0G0( )
      {
      }

      protected void E110G2( )
      {
         /* Start Routine */
         GXt_char1 = AV16tCurrentCode;
         new zbr_getcurrenttcode(context ).execute( out  GXt_char1) ;
         AV16tCurrentCode = GXt_char1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16tCurrentCode", AV16tCurrentCode);
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV7WWPContext) ;
         AV13IsAuthorized = true;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13IsAuthorized", AV13IsAuthorized);
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            GXt_boolean2 = AV13IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Lab", out  GXt_boolean2) ;
            AV13IsAuthorized = GXt_boolean2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13IsAuthorized", AV13IsAuthorized);
         }
         if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
         {
            GXt_boolean2 = AV13IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Lab", out  GXt_boolean2) ;
            AV13IsAuthorized = GXt_boolean2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13IsAuthorized", AV13IsAuthorized);
         }
         if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
         {
            GXt_boolean2 = AV13IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Lab", out  GXt_boolean2) ;
            AV13IsAuthorized = GXt_boolean2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13IsAuthorized", AV13IsAuthorized);
         }
         if ( ! AV13IsAuthorized )
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
         edtBR_LabID_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_LabID_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_LabID_Visible), 5, 0)), true);
         edtBR_EncounterID_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_EncounterID_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_EncounterID_Visible), 5, 0)), true);
         edtBR_Information_PatientNo_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Information_PatientNo_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Information_PatientNo_Visible), 5, 0)), true);
         edtBR_Lab_TestID_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Lab_TestID_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Lab_TestID_Visible), 5, 0)), true);
         edtBR_Lab_NormRangeHigh_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Lab_NormRangeHigh_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Lab_NormRangeHigh_Visible), 5, 0)), true);
      }

      protected void E120G2( )
      {
         /* After Trn Routine */
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV8TrnContext.gxTpr_Callerondelete )
         {
            CallWebObject(formatLink("br_labww.aspx") );
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
         edtavVsource_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVsource_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVsource_Visible), 5, 0)), true);
         cellVsource_cell_Class = "Invisible";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVsource_cell_Internalname, "Class", cellVsource_cell_Class, true);
      }

      protected void ZM0G17( short GX_JID )
      {
         if ( ( GX_JID == 29 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z474BR_Lab_SpecimenSource_Code = T000G3_A474BR_Lab_SpecimenSource_Code[0];
               Z475BR_Lab_ResultQual_Code = T000G3_A475BR_Lab_ResultQual_Code[0];
               Z476BR_Lab_AbnInd_Code = T000G3_A476BR_Lab_AbnInd_Code[0];
               Z224BR_Lab_SampleID = T000G3_A224BR_Lab_SampleID[0];
               Z102BR_Lab_TestID = T000G3_A102BR_Lab_TestID[0];
               Z103BR_Lab_TestCode = T000G3_A103BR_Lab_TestCode[0];
               Z104BR_Lab_TestName = T000G3_A104BR_Lab_TestName[0];
               Z261BR_Lab_TestEngName = T000G3_A261BR_Lab_TestEngName[0];
               Z262BR_Lab_Age = T000G3_A262BR_Lab_Age[0];
               Z263BR_Lab_Diag = T000G3_A263BR_Lab_Diag[0];
               Z105BR_Lab_SpecimenDate = T000G3_A105BR_Lab_SpecimenDate[0];
               Z264BR_Lab_ReceivingTime = T000G3_A264BR_Lab_ReceivingTime[0];
               Z265BR_Lab_ReportTime = T000G3_A265BR_Lab_ReportTime[0];
               Z106BR_Lab_SpecimenSource = T000G3_A106BR_Lab_SpecimenSource[0];
               Z109BR_Lab_ResultQual = T000G3_A109BR_Lab_ResultQual[0];
               Z110BR_Lab_ResultNum = T000G3_A110BR_Lab_ResultNum[0];
               Z111BR_Lab_ResultUnit = T000G3_A111BR_Lab_ResultUnit[0];
               Z112BR_Lab_AbnInd = T000G3_A112BR_Lab_AbnInd[0];
               Z113BR_Lab_NormRangeLow = T000G3_A113BR_Lab_NormRangeLow[0];
               Z114BR_Lab_NormRangeHigh = T000G3_A114BR_Lab_NormRangeHigh[0];
               Z115BR_Lab_TestMethod = T000G3_A115BR_Lab_TestMethod[0];
               Z117BR_Lab_InstrumentName = T000G3_A117BR_Lab_InstrumentName[0];
               Z118BR_Lab_InstrumentCode = T000G3_A118BR_Lab_InstrumentCode[0];
               Z430BR_SampleId = T000G3_A430BR_SampleId[0];
               Z19BR_EncounterID = T000G3_A19BR_EncounterID[0];
            }
            else
            {
               Z474BR_Lab_SpecimenSource_Code = A474BR_Lab_SpecimenSource_Code;
               Z475BR_Lab_ResultQual_Code = A475BR_Lab_ResultQual_Code;
               Z476BR_Lab_AbnInd_Code = A476BR_Lab_AbnInd_Code;
               Z224BR_Lab_SampleID = A224BR_Lab_SampleID;
               Z102BR_Lab_TestID = A102BR_Lab_TestID;
               Z103BR_Lab_TestCode = A103BR_Lab_TestCode;
               Z104BR_Lab_TestName = A104BR_Lab_TestName;
               Z261BR_Lab_TestEngName = A261BR_Lab_TestEngName;
               Z262BR_Lab_Age = A262BR_Lab_Age;
               Z263BR_Lab_Diag = A263BR_Lab_Diag;
               Z105BR_Lab_SpecimenDate = A105BR_Lab_SpecimenDate;
               Z264BR_Lab_ReceivingTime = A264BR_Lab_ReceivingTime;
               Z265BR_Lab_ReportTime = A265BR_Lab_ReportTime;
               Z106BR_Lab_SpecimenSource = A106BR_Lab_SpecimenSource;
               Z109BR_Lab_ResultQual = A109BR_Lab_ResultQual;
               Z110BR_Lab_ResultNum = A110BR_Lab_ResultNum;
               Z111BR_Lab_ResultUnit = A111BR_Lab_ResultUnit;
               Z112BR_Lab_AbnInd = A112BR_Lab_AbnInd;
               Z113BR_Lab_NormRangeLow = A113BR_Lab_NormRangeLow;
               Z114BR_Lab_NormRangeHigh = A114BR_Lab_NormRangeHigh;
               Z115BR_Lab_TestMethod = A115BR_Lab_TestMethod;
               Z117BR_Lab_InstrumentName = A117BR_Lab_InstrumentName;
               Z118BR_Lab_InstrumentCode = A118BR_Lab_InstrumentCode;
               Z430BR_SampleId = A430BR_SampleId;
               Z19BR_EncounterID = A19BR_EncounterID;
            }
         }
         if ( GX_JID == -29 )
         {
            Z101BR_LabID = A101BR_LabID;
            Z474BR_Lab_SpecimenSource_Code = A474BR_Lab_SpecimenSource_Code;
            Z475BR_Lab_ResultQual_Code = A475BR_Lab_ResultQual_Code;
            Z476BR_Lab_AbnInd_Code = A476BR_Lab_AbnInd_Code;
            Z224BR_Lab_SampleID = A224BR_Lab_SampleID;
            Z102BR_Lab_TestID = A102BR_Lab_TestID;
            Z103BR_Lab_TestCode = A103BR_Lab_TestCode;
            Z104BR_Lab_TestName = A104BR_Lab_TestName;
            Z261BR_Lab_TestEngName = A261BR_Lab_TestEngName;
            Z262BR_Lab_Age = A262BR_Lab_Age;
            Z263BR_Lab_Diag = A263BR_Lab_Diag;
            Z105BR_Lab_SpecimenDate = A105BR_Lab_SpecimenDate;
            Z264BR_Lab_ReceivingTime = A264BR_Lab_ReceivingTime;
            Z265BR_Lab_ReportTime = A265BR_Lab_ReportTime;
            Z106BR_Lab_SpecimenSource = A106BR_Lab_SpecimenSource;
            Z109BR_Lab_ResultQual = A109BR_Lab_ResultQual;
            Z110BR_Lab_ResultNum = A110BR_Lab_ResultNum;
            Z111BR_Lab_ResultUnit = A111BR_Lab_ResultUnit;
            Z112BR_Lab_AbnInd = A112BR_Lab_AbnInd;
            Z113BR_Lab_NormRangeLow = A113BR_Lab_NormRangeLow;
            Z114BR_Lab_NormRangeHigh = A114BR_Lab_NormRangeHigh;
            Z115BR_Lab_TestMethod = A115BR_Lab_TestMethod;
            Z117BR_Lab_InstrumentName = A117BR_Lab_InstrumentName;
            Z118BR_Lab_InstrumentCode = A118BR_Lab_InstrumentCode;
            Z430BR_SampleId = A430BR_SampleId;
            Z19BR_EncounterID = A19BR_EncounterID;
            Z85BR_Information_ID = A85BR_Information_ID;
            Z36BR_Information_PatientNo = A36BR_Information_PatientNo;
         }
      }

      protected void standaloneNotModal( )
      {
         edtBR_LabID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_LabID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_LabID_Enabled), 5, 0)), true);
         edtBR_LabID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_LabID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_LabID_Enabled), 5, 0)), true);
         bttBtntrn_delete_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_delete_Enabled), 5, 0)), true);
         if ( ! (0==AV12BR_LabID) )
         {
            A101BR_LabID = AV12BR_LabID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A101BR_LabID", StringUtil.LTrim( StringUtil.Str( (decimal)(A101BR_LabID), 18, 0)));
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
         GXABR_LAB_SPECIMENSOURCE_html0G17( AV16tCurrentCode) ;
         GXABR_LAB_RESULTQUAL_html0G17( AV16tCurrentCode) ;
         GXABR_LAB_ABNIND_html0G17( AV16tCurrentCode) ;
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
            AV17Pgmname = "BR_Lab";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17Pgmname", AV17Pgmname);
            edtavVsource_Visible = ((StringUtil.StrCmp(A106BR_Lab_SpecimenSource, "其它")==0) ? 1 : 0);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVsource_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVsource_Visible), 5, 0)), true);
            if ( ! ( ( StringUtil.StrCmp(A106BR_Lab_SpecimenSource, "其它") == 0 ) ) )
            {
               cellVsource_cell_Class = "Invisible";
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVsource_cell_Internalname, "Class", cellVsource_cell_Class, true);
            }
            else
            {
               if ( StringUtil.StrCmp(A106BR_Lab_SpecimenSource, "其它") == 0 )
               {
                  cellVsource_cell_Class = "RequiredDataContentCell";
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVsource_cell_Internalname, "Class", cellVsource_cell_Class, true);
               }
            }
            /* Using cursor T000G4 */
            pr_default.execute(2, new Object[] {A19BR_EncounterID});
            A85BR_Information_ID = T000G4_A85BR_Information_ID[0];
            n85BR_Information_ID = T000G4_n85BR_Information_ID[0];
            pr_default.close(2);
            /* Using cursor T000G5 */
            pr_default.execute(3, new Object[] {n85BR_Information_ID, A85BR_Information_ID});
            A36BR_Information_PatientNo = T000G5_A36BR_Information_PatientNo[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36BR_Information_PatientNo", A36BR_Information_PatientNo);
            n36BR_Information_PatientNo = T000G5_n36BR_Information_PatientNo[0];
            pr_default.close(3);
         }
      }

      protected void Load0G17( )
      {
         /* Using cursor T000G6 */
         pr_default.execute(4, new Object[] {A101BR_LabID});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound17 = 1;
            A85BR_Information_ID = T000G6_A85BR_Information_ID[0];
            n85BR_Information_ID = T000G6_n85BR_Information_ID[0];
            A474BR_Lab_SpecimenSource_Code = T000G6_A474BR_Lab_SpecimenSource_Code[0];
            n474BR_Lab_SpecimenSource_Code = T000G6_n474BR_Lab_SpecimenSource_Code[0];
            A475BR_Lab_ResultQual_Code = T000G6_A475BR_Lab_ResultQual_Code[0];
            n475BR_Lab_ResultQual_Code = T000G6_n475BR_Lab_ResultQual_Code[0];
            A476BR_Lab_AbnInd_Code = T000G6_A476BR_Lab_AbnInd_Code[0];
            n476BR_Lab_AbnInd_Code = T000G6_n476BR_Lab_AbnInd_Code[0];
            A36BR_Information_PatientNo = T000G6_A36BR_Information_PatientNo[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36BR_Information_PatientNo", A36BR_Information_PatientNo);
            n36BR_Information_PatientNo = T000G6_n36BR_Information_PatientNo[0];
            A224BR_Lab_SampleID = T000G6_A224BR_Lab_SampleID[0];
            n224BR_Lab_SampleID = T000G6_n224BR_Lab_SampleID[0];
            A102BR_Lab_TestID = T000G6_A102BR_Lab_TestID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A102BR_Lab_TestID", StringUtil.LTrim( StringUtil.Str( (decimal)(A102BR_Lab_TestID), 10, 0)));
            n102BR_Lab_TestID = T000G6_n102BR_Lab_TestID[0];
            A103BR_Lab_TestCode = T000G6_A103BR_Lab_TestCode[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A103BR_Lab_TestCode", A103BR_Lab_TestCode);
            n103BR_Lab_TestCode = T000G6_n103BR_Lab_TestCode[0];
            A104BR_Lab_TestName = T000G6_A104BR_Lab_TestName[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A104BR_Lab_TestName", A104BR_Lab_TestName);
            n104BR_Lab_TestName = T000G6_n104BR_Lab_TestName[0];
            A261BR_Lab_TestEngName = T000G6_A261BR_Lab_TestEngName[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A261BR_Lab_TestEngName", A261BR_Lab_TestEngName);
            n261BR_Lab_TestEngName = T000G6_n261BR_Lab_TestEngName[0];
            A262BR_Lab_Age = T000G6_A262BR_Lab_Age[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A262BR_Lab_Age", StringUtil.LTrim( StringUtil.Str( (decimal)(A262BR_Lab_Age), 3, 0)));
            n262BR_Lab_Age = T000G6_n262BR_Lab_Age[0];
            A263BR_Lab_Diag = T000G6_A263BR_Lab_Diag[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A263BR_Lab_Diag", A263BR_Lab_Diag);
            n263BR_Lab_Diag = T000G6_n263BR_Lab_Diag[0];
            A105BR_Lab_SpecimenDate = T000G6_A105BR_Lab_SpecimenDate[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A105BR_Lab_SpecimenDate", context.localUtil.TToC( A105BR_Lab_SpecimenDate, 10, 8, 0, 0, "/", ":", " "));
            n105BR_Lab_SpecimenDate = T000G6_n105BR_Lab_SpecimenDate[0];
            A264BR_Lab_ReceivingTime = T000G6_A264BR_Lab_ReceivingTime[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A264BR_Lab_ReceivingTime", context.localUtil.TToC( A264BR_Lab_ReceivingTime, 10, 8, 0, 0, "/", ":", " "));
            n264BR_Lab_ReceivingTime = T000G6_n264BR_Lab_ReceivingTime[0];
            A265BR_Lab_ReportTime = T000G6_A265BR_Lab_ReportTime[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A265BR_Lab_ReportTime", context.localUtil.TToC( A265BR_Lab_ReportTime, 10, 8, 0, 0, "/", ":", " "));
            n265BR_Lab_ReportTime = T000G6_n265BR_Lab_ReportTime[0];
            A106BR_Lab_SpecimenSource = T000G6_A106BR_Lab_SpecimenSource[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A106BR_Lab_SpecimenSource", A106BR_Lab_SpecimenSource);
            n106BR_Lab_SpecimenSource = T000G6_n106BR_Lab_SpecimenSource[0];
            A109BR_Lab_ResultQual = T000G6_A109BR_Lab_ResultQual[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A109BR_Lab_ResultQual", A109BR_Lab_ResultQual);
            n109BR_Lab_ResultQual = T000G6_n109BR_Lab_ResultQual[0];
            A110BR_Lab_ResultNum = T000G6_A110BR_Lab_ResultNum[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A110BR_Lab_ResultNum", A110BR_Lab_ResultNum);
            n110BR_Lab_ResultNum = T000G6_n110BR_Lab_ResultNum[0];
            A111BR_Lab_ResultUnit = T000G6_A111BR_Lab_ResultUnit[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A111BR_Lab_ResultUnit", A111BR_Lab_ResultUnit);
            n111BR_Lab_ResultUnit = T000G6_n111BR_Lab_ResultUnit[0];
            A112BR_Lab_AbnInd = T000G6_A112BR_Lab_AbnInd[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A112BR_Lab_AbnInd", A112BR_Lab_AbnInd);
            n112BR_Lab_AbnInd = T000G6_n112BR_Lab_AbnInd[0];
            A113BR_Lab_NormRangeLow = T000G6_A113BR_Lab_NormRangeLow[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A113BR_Lab_NormRangeLow", A113BR_Lab_NormRangeLow);
            n113BR_Lab_NormRangeLow = T000G6_n113BR_Lab_NormRangeLow[0];
            A114BR_Lab_NormRangeHigh = T000G6_A114BR_Lab_NormRangeHigh[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A114BR_Lab_NormRangeHigh", A114BR_Lab_NormRangeHigh);
            n114BR_Lab_NormRangeHigh = T000G6_n114BR_Lab_NormRangeHigh[0];
            A115BR_Lab_TestMethod = T000G6_A115BR_Lab_TestMethod[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A115BR_Lab_TestMethod", A115BR_Lab_TestMethod);
            n115BR_Lab_TestMethod = T000G6_n115BR_Lab_TestMethod[0];
            A117BR_Lab_InstrumentName = T000G6_A117BR_Lab_InstrumentName[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A117BR_Lab_InstrumentName", A117BR_Lab_InstrumentName);
            n117BR_Lab_InstrumentName = T000G6_n117BR_Lab_InstrumentName[0];
            A118BR_Lab_InstrumentCode = T000G6_A118BR_Lab_InstrumentCode[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A118BR_Lab_InstrumentCode", A118BR_Lab_InstrumentCode);
            n118BR_Lab_InstrumentCode = T000G6_n118BR_Lab_InstrumentCode[0];
            A430BR_SampleId = T000G6_A430BR_SampleId[0];
            n430BR_SampleId = T000G6_n430BR_SampleId[0];
            A19BR_EncounterID = T000G6_A19BR_EncounterID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
            ZM0G17( -29) ;
         }
         pr_default.close(4);
         OnLoadActions0G17( ) ;
      }

      protected void OnLoadActions0G17( )
      {
         AV17Pgmname = "BR_Lab";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17Pgmname", AV17Pgmname);
         edtavVsource_Visible = ((StringUtil.StrCmp(A106BR_Lab_SpecimenSource, "其它")==0) ? 1 : 0);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVsource_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVsource_Visible), 5, 0)), true);
         if ( ! ( ( StringUtil.StrCmp(A106BR_Lab_SpecimenSource, "其它") == 0 ) ) )
         {
            cellVsource_cell_Class = "Invisible";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVsource_cell_Internalname, "Class", cellVsource_cell_Class, true);
         }
         else
         {
            if ( StringUtil.StrCmp(A106BR_Lab_SpecimenSource, "其它") == 0 )
            {
               cellVsource_cell_Class = "RequiredDataContentCell";
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVsource_cell_Internalname, "Class", cellVsource_cell_Class, true);
            }
         }
      }

      protected void CheckExtendedTable0G17( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
         AV17Pgmname = "BR_Lab";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17Pgmname", AV17Pgmname);
         /* Using cursor T000G4 */
         pr_default.execute(2, new Object[] {A19BR_EncounterID});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("不匹配' T15'", "ForeignKeyNotFound", 1, "BR_ENCOUNTERID");
            AnyError = 1;
            GX_FocusControl = edtBR_EncounterID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A85BR_Information_ID = T000G4_A85BR_Information_ID[0];
         n85BR_Information_ID = T000G4_n85BR_Information_ID[0];
         pr_default.close(2);
         /* Using cursor T000G5 */
         pr_default.execute(3, new Object[] {n85BR_Information_ID, A85BR_Information_ID});
         if ( (pr_default.getStatus(3) == 101) )
         {
            if ( ! ( (0==A85BR_Information_ID) ) )
            {
               GX_msglist.addItem("不匹配' T16'", "ForeignKeyNotFound", 1, "");
               AnyError = 1;
            }
         }
         A36BR_Information_PatientNo = T000G5_A36BR_Information_PatientNo[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36BR_Information_PatientNo", A36BR_Information_PatientNo);
         n36BR_Information_PatientNo = T000G5_n36BR_Information_PatientNo[0];
         pr_default.close(3);
         if ( String.IsNullOrEmpty(StringUtil.RTrim( A104BR_Lab_TestName)) )
         {
            GX_msglist.addItem("项目名称是必须填写的。", 1, "BR_LAB_TESTNAME");
            AnyError = 1;
            GX_FocusControl = edtBR_Lab_TestName_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ! ( (DateTime.MinValue==A105BR_Lab_SpecimenDate) || ( A105BR_Lab_SpecimenDate >= context.localUtil.YMDHMSToT( 1753, 1, 1, 0, 0, 0) ) ) )
         {
            GX_msglist.addItem("域采样时间超界", "OutOfRange", 1, "BR_LAB_SPECIMENDATE");
            AnyError = 1;
            GX_FocusControl = edtBR_Lab_SpecimenDate_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( (DateTime.MinValue==A105BR_Lab_SpecimenDate) )
         {
            GX_msglist.addItem("采样时间是必须填写的。", 1, "BR_LAB_SPECIMENDATE");
            AnyError = 1;
            GX_FocusControl = edtBR_Lab_SpecimenDate_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ! ( (DateTime.MinValue==A264BR_Lab_ReceivingTime) || ( A264BR_Lab_ReceivingTime >= context.localUtil.YMDHMSToT( 1753, 1, 1, 0, 0, 0) ) ) )
         {
            GX_msglist.addItem("域接收时间超界", "OutOfRange", 1, "BR_LAB_RECEIVINGTIME");
            AnyError = 1;
            GX_FocusControl = edtBR_Lab_ReceivingTime_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ! ( (DateTime.MinValue==A265BR_Lab_ReportTime) || ( A265BR_Lab_ReportTime >= context.localUtil.YMDHMSToT( 1753, 1, 1, 0, 0, 0) ) ) )
         {
            GX_msglist.addItem("域报告时间超界", "OutOfRange", 1, "BR_LAB_REPORTTIME");
            AnyError = 1;
            GX_FocusControl = edtBR_Lab_ReportTime_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         edtavVsource_Visible = ((StringUtil.StrCmp(A106BR_Lab_SpecimenSource, "其它")==0) ? 1 : 0);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVsource_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVsource_Visible), 5, 0)), true);
         if ( ! ( ( StringUtil.StrCmp(A106BR_Lab_SpecimenSource, "其它") == 0 ) ) )
         {
            cellVsource_cell_Class = "Invisible";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVsource_cell_Internalname, "Class", cellVsource_cell_Class, true);
         }
         else
         {
            if ( StringUtil.StrCmp(A106BR_Lab_SpecimenSource, "其它") == 0 )
            {
               cellVsource_cell_Class = "RequiredDataContentCell";
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVsource_cell_Internalname, "Class", cellVsource_cell_Class, true);
            }
         }
         if ( ( ( StringUtil.StrCmp(A106BR_Lab_SpecimenSource, "其它") == 0 ) ) && String.IsNullOrEmpty(StringUtil.RTrim( AV15vSource)) )
         {
            GX_msglist.addItem("其它标本种类是必填的", 1, "BR_LAB_SPECIMENSOURCE");
            AnyError = 1;
            GX_FocusControl = dynBR_Lab_SpecimenSource_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
      }

      protected void CloseExtendedTableCursors0G17( )
      {
         pr_default.close(2);
         pr_default.close(3);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_30( long A19BR_EncounterID )
      {
         /* Using cursor T000G7 */
         pr_default.execute(5, new Object[] {A19BR_EncounterID});
         if ( (pr_default.getStatus(5) == 101) )
         {
            GX_msglist.addItem("不匹配' T15'", "ForeignKeyNotFound", 1, "BR_ENCOUNTERID");
            AnyError = 1;
            GX_FocusControl = edtBR_EncounterID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A85BR_Information_ID = T000G7_A85BR_Information_ID[0];
         n85BR_Information_ID = T000G7_n85BR_Information_ID[0];
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

      protected void gxLoad_31( long A85BR_Information_ID )
      {
         /* Using cursor T000G8 */
         pr_default.execute(6, new Object[] {n85BR_Information_ID, A85BR_Information_ID});
         if ( (pr_default.getStatus(6) == 101) )
         {
            if ( ! ( (0==A85BR_Information_ID) ) )
            {
               GX_msglist.addItem("不匹配' T16'", "ForeignKeyNotFound", 1, "");
               AnyError = 1;
            }
         }
         A36BR_Information_PatientNo = T000G8_A36BR_Information_PatientNo[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36BR_Information_PatientNo", A36BR_Information_PatientNo);
         n36BR_Information_PatientNo = T000G8_n36BR_Information_PatientNo[0];
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

      protected void GetKey0G17( )
      {
         /* Using cursor T000G9 */
         pr_default.execute(7, new Object[] {A101BR_LabID});
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound17 = 1;
         }
         else
         {
            RcdFound17 = 0;
         }
         pr_default.close(7);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T000G3 */
         pr_default.execute(1, new Object[] {A101BR_LabID});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0G17( 29) ;
            RcdFound17 = 1;
            A101BR_LabID = T000G3_A101BR_LabID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A101BR_LabID", StringUtil.LTrim( StringUtil.Str( (decimal)(A101BR_LabID), 18, 0)));
            A474BR_Lab_SpecimenSource_Code = T000G3_A474BR_Lab_SpecimenSource_Code[0];
            n474BR_Lab_SpecimenSource_Code = T000G3_n474BR_Lab_SpecimenSource_Code[0];
            A475BR_Lab_ResultQual_Code = T000G3_A475BR_Lab_ResultQual_Code[0];
            n475BR_Lab_ResultQual_Code = T000G3_n475BR_Lab_ResultQual_Code[0];
            A476BR_Lab_AbnInd_Code = T000G3_A476BR_Lab_AbnInd_Code[0];
            n476BR_Lab_AbnInd_Code = T000G3_n476BR_Lab_AbnInd_Code[0];
            A224BR_Lab_SampleID = T000G3_A224BR_Lab_SampleID[0];
            n224BR_Lab_SampleID = T000G3_n224BR_Lab_SampleID[0];
            A102BR_Lab_TestID = T000G3_A102BR_Lab_TestID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A102BR_Lab_TestID", StringUtil.LTrim( StringUtil.Str( (decimal)(A102BR_Lab_TestID), 10, 0)));
            n102BR_Lab_TestID = T000G3_n102BR_Lab_TestID[0];
            A103BR_Lab_TestCode = T000G3_A103BR_Lab_TestCode[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A103BR_Lab_TestCode", A103BR_Lab_TestCode);
            n103BR_Lab_TestCode = T000G3_n103BR_Lab_TestCode[0];
            A104BR_Lab_TestName = T000G3_A104BR_Lab_TestName[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A104BR_Lab_TestName", A104BR_Lab_TestName);
            n104BR_Lab_TestName = T000G3_n104BR_Lab_TestName[0];
            A261BR_Lab_TestEngName = T000G3_A261BR_Lab_TestEngName[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A261BR_Lab_TestEngName", A261BR_Lab_TestEngName);
            n261BR_Lab_TestEngName = T000G3_n261BR_Lab_TestEngName[0];
            A262BR_Lab_Age = T000G3_A262BR_Lab_Age[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A262BR_Lab_Age", StringUtil.LTrim( StringUtil.Str( (decimal)(A262BR_Lab_Age), 3, 0)));
            n262BR_Lab_Age = T000G3_n262BR_Lab_Age[0];
            A263BR_Lab_Diag = T000G3_A263BR_Lab_Diag[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A263BR_Lab_Diag", A263BR_Lab_Diag);
            n263BR_Lab_Diag = T000G3_n263BR_Lab_Diag[0];
            A105BR_Lab_SpecimenDate = T000G3_A105BR_Lab_SpecimenDate[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A105BR_Lab_SpecimenDate", context.localUtil.TToC( A105BR_Lab_SpecimenDate, 10, 8, 0, 0, "/", ":", " "));
            n105BR_Lab_SpecimenDate = T000G3_n105BR_Lab_SpecimenDate[0];
            A264BR_Lab_ReceivingTime = T000G3_A264BR_Lab_ReceivingTime[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A264BR_Lab_ReceivingTime", context.localUtil.TToC( A264BR_Lab_ReceivingTime, 10, 8, 0, 0, "/", ":", " "));
            n264BR_Lab_ReceivingTime = T000G3_n264BR_Lab_ReceivingTime[0];
            A265BR_Lab_ReportTime = T000G3_A265BR_Lab_ReportTime[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A265BR_Lab_ReportTime", context.localUtil.TToC( A265BR_Lab_ReportTime, 10, 8, 0, 0, "/", ":", " "));
            n265BR_Lab_ReportTime = T000G3_n265BR_Lab_ReportTime[0];
            A106BR_Lab_SpecimenSource = T000G3_A106BR_Lab_SpecimenSource[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A106BR_Lab_SpecimenSource", A106BR_Lab_SpecimenSource);
            n106BR_Lab_SpecimenSource = T000G3_n106BR_Lab_SpecimenSource[0];
            A109BR_Lab_ResultQual = T000G3_A109BR_Lab_ResultQual[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A109BR_Lab_ResultQual", A109BR_Lab_ResultQual);
            n109BR_Lab_ResultQual = T000G3_n109BR_Lab_ResultQual[0];
            A110BR_Lab_ResultNum = T000G3_A110BR_Lab_ResultNum[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A110BR_Lab_ResultNum", A110BR_Lab_ResultNum);
            n110BR_Lab_ResultNum = T000G3_n110BR_Lab_ResultNum[0];
            A111BR_Lab_ResultUnit = T000G3_A111BR_Lab_ResultUnit[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A111BR_Lab_ResultUnit", A111BR_Lab_ResultUnit);
            n111BR_Lab_ResultUnit = T000G3_n111BR_Lab_ResultUnit[0];
            A112BR_Lab_AbnInd = T000G3_A112BR_Lab_AbnInd[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A112BR_Lab_AbnInd", A112BR_Lab_AbnInd);
            n112BR_Lab_AbnInd = T000G3_n112BR_Lab_AbnInd[0];
            A113BR_Lab_NormRangeLow = T000G3_A113BR_Lab_NormRangeLow[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A113BR_Lab_NormRangeLow", A113BR_Lab_NormRangeLow);
            n113BR_Lab_NormRangeLow = T000G3_n113BR_Lab_NormRangeLow[0];
            A114BR_Lab_NormRangeHigh = T000G3_A114BR_Lab_NormRangeHigh[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A114BR_Lab_NormRangeHigh", A114BR_Lab_NormRangeHigh);
            n114BR_Lab_NormRangeHigh = T000G3_n114BR_Lab_NormRangeHigh[0];
            A115BR_Lab_TestMethod = T000G3_A115BR_Lab_TestMethod[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A115BR_Lab_TestMethod", A115BR_Lab_TestMethod);
            n115BR_Lab_TestMethod = T000G3_n115BR_Lab_TestMethod[0];
            A117BR_Lab_InstrumentName = T000G3_A117BR_Lab_InstrumentName[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A117BR_Lab_InstrumentName", A117BR_Lab_InstrumentName);
            n117BR_Lab_InstrumentName = T000G3_n117BR_Lab_InstrumentName[0];
            A118BR_Lab_InstrumentCode = T000G3_A118BR_Lab_InstrumentCode[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A118BR_Lab_InstrumentCode", A118BR_Lab_InstrumentCode);
            n118BR_Lab_InstrumentCode = T000G3_n118BR_Lab_InstrumentCode[0];
            A430BR_SampleId = T000G3_A430BR_SampleId[0];
            n430BR_SampleId = T000G3_n430BR_SampleId[0];
            A19BR_EncounterID = T000G3_A19BR_EncounterID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
            Z101BR_LabID = A101BR_LabID;
            sMode17 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load0G17( ) ;
            if ( AnyError == 1 )
            {
               RcdFound17 = 0;
               InitializeNonKey0G17( ) ;
            }
            Gx_mode = sMode17;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound17 = 0;
            InitializeNonKey0G17( ) ;
            sMode17 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal( ) ;
            Gx_mode = sMode17;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0G17( ) ;
         if ( RcdFound17 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound17 = 0;
         /* Using cursor T000G10 */
         pr_default.execute(8, new Object[] {A101BR_LabID});
         if ( (pr_default.getStatus(8) != 101) )
         {
            while ( (pr_default.getStatus(8) != 101) && ( ( T000G10_A101BR_LabID[0] < A101BR_LabID ) ) )
            {
               pr_default.readNext(8);
            }
            if ( (pr_default.getStatus(8) != 101) && ( ( T000G10_A101BR_LabID[0] > A101BR_LabID ) ) )
            {
               A101BR_LabID = T000G10_A101BR_LabID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A101BR_LabID", StringUtil.LTrim( StringUtil.Str( (decimal)(A101BR_LabID), 18, 0)));
               RcdFound17 = 1;
            }
         }
         pr_default.close(8);
      }

      protected void move_previous( )
      {
         RcdFound17 = 0;
         /* Using cursor T000G11 */
         pr_default.execute(9, new Object[] {A101BR_LabID});
         if ( (pr_default.getStatus(9) != 101) )
         {
            while ( (pr_default.getStatus(9) != 101) && ( ( T000G11_A101BR_LabID[0] > A101BR_LabID ) ) )
            {
               pr_default.readNext(9);
            }
            if ( (pr_default.getStatus(9) != 101) && ( ( T000G11_A101BR_LabID[0] < A101BR_LabID ) ) )
            {
               A101BR_LabID = T000G11_A101BR_LabID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A101BR_LabID", StringUtil.LTrim( StringUtil.Str( (decimal)(A101BR_LabID), 18, 0)));
               RcdFound17 = 1;
            }
         }
         pr_default.close(9);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey0G17( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtBR_Lab_TestName_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert0G17( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound17 == 1 )
            {
               if ( A101BR_LabID != Z101BR_LabID )
               {
                  A101BR_LabID = Z101BR_LabID;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A101BR_LabID", StringUtil.LTrim( StringUtil.Str( (decimal)(A101BR_LabID), 18, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "BR_LABID");
                  AnyError = 1;
                  GX_FocusControl = edtBR_LabID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = edtBR_Lab_TestName_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Update record */
                  Update0G17( ) ;
                  GX_FocusControl = edtBR_Lab_TestName_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A101BR_LabID != Z101BR_LabID )
               {
                  /* Insert record */
                  GX_FocusControl = edtBR_Lab_TestName_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert0G17( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "BR_LABID");
                     AnyError = 1;
                     GX_FocusControl = edtBR_LabID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     /* Insert record */
                     GX_FocusControl = edtBR_Lab_TestName_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert0G17( ) ;
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
         if ( A101BR_LabID != Z101BR_LabID )
         {
            A101BR_LabID = Z101BR_LabID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A101BR_LabID", StringUtil.LTrim( StringUtil.Str( (decimal)(A101BR_LabID), 18, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "BR_LABID");
            AnyError = 1;
            GX_FocusControl = edtBR_LabID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtBR_Lab_TestName_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency0G17( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000G2 */
            pr_default.execute(0, new Object[] {A101BR_LabID});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BR_Lab"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z474BR_Lab_SpecimenSource_Code, T000G2_A474BR_Lab_SpecimenSource_Code[0]) != 0 ) || ( StringUtil.StrCmp(Z475BR_Lab_ResultQual_Code, T000G2_A475BR_Lab_ResultQual_Code[0]) != 0 ) || ( StringUtil.StrCmp(Z476BR_Lab_AbnInd_Code, T000G2_A476BR_Lab_AbnInd_Code[0]) != 0 ) || ( StringUtil.StrCmp(Z224BR_Lab_SampleID, T000G2_A224BR_Lab_SampleID[0]) != 0 ) || ( Z102BR_Lab_TestID != T000G2_A102BR_Lab_TestID[0] ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z103BR_Lab_TestCode, T000G2_A103BR_Lab_TestCode[0]) != 0 ) || ( StringUtil.StrCmp(Z104BR_Lab_TestName, T000G2_A104BR_Lab_TestName[0]) != 0 ) || ( StringUtil.StrCmp(Z261BR_Lab_TestEngName, T000G2_A261BR_Lab_TestEngName[0]) != 0 ) || ( Z262BR_Lab_Age != T000G2_A262BR_Lab_Age[0] ) || ( StringUtil.StrCmp(Z263BR_Lab_Diag, T000G2_A263BR_Lab_Diag[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( Z105BR_Lab_SpecimenDate != T000G2_A105BR_Lab_SpecimenDate[0] ) || ( Z264BR_Lab_ReceivingTime != T000G2_A264BR_Lab_ReceivingTime[0] ) || ( Z265BR_Lab_ReportTime != T000G2_A265BR_Lab_ReportTime[0] ) || ( StringUtil.StrCmp(Z106BR_Lab_SpecimenSource, T000G2_A106BR_Lab_SpecimenSource[0]) != 0 ) || ( StringUtil.StrCmp(Z109BR_Lab_ResultQual, T000G2_A109BR_Lab_ResultQual[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z110BR_Lab_ResultNum, T000G2_A110BR_Lab_ResultNum[0]) != 0 ) || ( StringUtil.StrCmp(Z111BR_Lab_ResultUnit, T000G2_A111BR_Lab_ResultUnit[0]) != 0 ) || ( StringUtil.StrCmp(Z112BR_Lab_AbnInd, T000G2_A112BR_Lab_AbnInd[0]) != 0 ) || ( StringUtil.StrCmp(Z113BR_Lab_NormRangeLow, T000G2_A113BR_Lab_NormRangeLow[0]) != 0 ) || ( StringUtil.StrCmp(Z114BR_Lab_NormRangeHigh, T000G2_A114BR_Lab_NormRangeHigh[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z115BR_Lab_TestMethod, T000G2_A115BR_Lab_TestMethod[0]) != 0 ) || ( StringUtil.StrCmp(Z117BR_Lab_InstrumentName, T000G2_A117BR_Lab_InstrumentName[0]) != 0 ) || ( StringUtil.StrCmp(Z118BR_Lab_InstrumentCode, T000G2_A118BR_Lab_InstrumentCode[0]) != 0 ) || ( Z430BR_SampleId != T000G2_A430BR_SampleId[0] ) || ( Z19BR_EncounterID != T000G2_A19BR_EncounterID[0] ) )
            {
               if ( StringUtil.StrCmp(Z474BR_Lab_SpecimenSource_Code, T000G2_A474BR_Lab_SpecimenSource_Code[0]) != 0 )
               {
                  GXUtil.WriteLog("br_lab:[seudo value changed for attri]"+"BR_Lab_SpecimenSource_Code");
                  GXUtil.WriteLogRaw("Old: ",Z474BR_Lab_SpecimenSource_Code);
                  GXUtil.WriteLogRaw("Current: ",T000G2_A474BR_Lab_SpecimenSource_Code[0]);
               }
               if ( StringUtil.StrCmp(Z475BR_Lab_ResultQual_Code, T000G2_A475BR_Lab_ResultQual_Code[0]) != 0 )
               {
                  GXUtil.WriteLog("br_lab:[seudo value changed for attri]"+"BR_Lab_ResultQual_Code");
                  GXUtil.WriteLogRaw("Old: ",Z475BR_Lab_ResultQual_Code);
                  GXUtil.WriteLogRaw("Current: ",T000G2_A475BR_Lab_ResultQual_Code[0]);
               }
               if ( StringUtil.StrCmp(Z476BR_Lab_AbnInd_Code, T000G2_A476BR_Lab_AbnInd_Code[0]) != 0 )
               {
                  GXUtil.WriteLog("br_lab:[seudo value changed for attri]"+"BR_Lab_AbnInd_Code");
                  GXUtil.WriteLogRaw("Old: ",Z476BR_Lab_AbnInd_Code);
                  GXUtil.WriteLogRaw("Current: ",T000G2_A476BR_Lab_AbnInd_Code[0]);
               }
               if ( StringUtil.StrCmp(Z224BR_Lab_SampleID, T000G2_A224BR_Lab_SampleID[0]) != 0 )
               {
                  GXUtil.WriteLog("br_lab:[seudo value changed for attri]"+"BR_Lab_SampleID");
                  GXUtil.WriteLogRaw("Old: ",Z224BR_Lab_SampleID);
                  GXUtil.WriteLogRaw("Current: ",T000G2_A224BR_Lab_SampleID[0]);
               }
               if ( Z102BR_Lab_TestID != T000G2_A102BR_Lab_TestID[0] )
               {
                  GXUtil.WriteLog("br_lab:[seudo value changed for attri]"+"BR_Lab_TestID");
                  GXUtil.WriteLogRaw("Old: ",Z102BR_Lab_TestID);
                  GXUtil.WriteLogRaw("Current: ",T000G2_A102BR_Lab_TestID[0]);
               }
               if ( StringUtil.StrCmp(Z103BR_Lab_TestCode, T000G2_A103BR_Lab_TestCode[0]) != 0 )
               {
                  GXUtil.WriteLog("br_lab:[seudo value changed for attri]"+"BR_Lab_TestCode");
                  GXUtil.WriteLogRaw("Old: ",Z103BR_Lab_TestCode);
                  GXUtil.WriteLogRaw("Current: ",T000G2_A103BR_Lab_TestCode[0]);
               }
               if ( StringUtil.StrCmp(Z104BR_Lab_TestName, T000G2_A104BR_Lab_TestName[0]) != 0 )
               {
                  GXUtil.WriteLog("br_lab:[seudo value changed for attri]"+"BR_Lab_TestName");
                  GXUtil.WriteLogRaw("Old: ",Z104BR_Lab_TestName);
                  GXUtil.WriteLogRaw("Current: ",T000G2_A104BR_Lab_TestName[0]);
               }
               if ( StringUtil.StrCmp(Z261BR_Lab_TestEngName, T000G2_A261BR_Lab_TestEngName[0]) != 0 )
               {
                  GXUtil.WriteLog("br_lab:[seudo value changed for attri]"+"BR_Lab_TestEngName");
                  GXUtil.WriteLogRaw("Old: ",Z261BR_Lab_TestEngName);
                  GXUtil.WriteLogRaw("Current: ",T000G2_A261BR_Lab_TestEngName[0]);
               }
               if ( Z262BR_Lab_Age != T000G2_A262BR_Lab_Age[0] )
               {
                  GXUtil.WriteLog("br_lab:[seudo value changed for attri]"+"BR_Lab_Age");
                  GXUtil.WriteLogRaw("Old: ",Z262BR_Lab_Age);
                  GXUtil.WriteLogRaw("Current: ",T000G2_A262BR_Lab_Age[0]);
               }
               if ( StringUtil.StrCmp(Z263BR_Lab_Diag, T000G2_A263BR_Lab_Diag[0]) != 0 )
               {
                  GXUtil.WriteLog("br_lab:[seudo value changed for attri]"+"BR_Lab_Diag");
                  GXUtil.WriteLogRaw("Old: ",Z263BR_Lab_Diag);
                  GXUtil.WriteLogRaw("Current: ",T000G2_A263BR_Lab_Diag[0]);
               }
               if ( Z105BR_Lab_SpecimenDate != T000G2_A105BR_Lab_SpecimenDate[0] )
               {
                  GXUtil.WriteLog("br_lab:[seudo value changed for attri]"+"BR_Lab_SpecimenDate");
                  GXUtil.WriteLogRaw("Old: ",Z105BR_Lab_SpecimenDate);
                  GXUtil.WriteLogRaw("Current: ",T000G2_A105BR_Lab_SpecimenDate[0]);
               }
               if ( Z264BR_Lab_ReceivingTime != T000G2_A264BR_Lab_ReceivingTime[0] )
               {
                  GXUtil.WriteLog("br_lab:[seudo value changed for attri]"+"BR_Lab_ReceivingTime");
                  GXUtil.WriteLogRaw("Old: ",Z264BR_Lab_ReceivingTime);
                  GXUtil.WriteLogRaw("Current: ",T000G2_A264BR_Lab_ReceivingTime[0]);
               }
               if ( Z265BR_Lab_ReportTime != T000G2_A265BR_Lab_ReportTime[0] )
               {
                  GXUtil.WriteLog("br_lab:[seudo value changed for attri]"+"BR_Lab_ReportTime");
                  GXUtil.WriteLogRaw("Old: ",Z265BR_Lab_ReportTime);
                  GXUtil.WriteLogRaw("Current: ",T000G2_A265BR_Lab_ReportTime[0]);
               }
               if ( StringUtil.StrCmp(Z106BR_Lab_SpecimenSource, T000G2_A106BR_Lab_SpecimenSource[0]) != 0 )
               {
                  GXUtil.WriteLog("br_lab:[seudo value changed for attri]"+"BR_Lab_SpecimenSource");
                  GXUtil.WriteLogRaw("Old: ",Z106BR_Lab_SpecimenSource);
                  GXUtil.WriteLogRaw("Current: ",T000G2_A106BR_Lab_SpecimenSource[0]);
               }
               if ( StringUtil.StrCmp(Z109BR_Lab_ResultQual, T000G2_A109BR_Lab_ResultQual[0]) != 0 )
               {
                  GXUtil.WriteLog("br_lab:[seudo value changed for attri]"+"BR_Lab_ResultQual");
                  GXUtil.WriteLogRaw("Old: ",Z109BR_Lab_ResultQual);
                  GXUtil.WriteLogRaw("Current: ",T000G2_A109BR_Lab_ResultQual[0]);
               }
               if ( StringUtil.StrCmp(Z110BR_Lab_ResultNum, T000G2_A110BR_Lab_ResultNum[0]) != 0 )
               {
                  GXUtil.WriteLog("br_lab:[seudo value changed for attri]"+"BR_Lab_ResultNum");
                  GXUtil.WriteLogRaw("Old: ",Z110BR_Lab_ResultNum);
                  GXUtil.WriteLogRaw("Current: ",T000G2_A110BR_Lab_ResultNum[0]);
               }
               if ( StringUtil.StrCmp(Z111BR_Lab_ResultUnit, T000G2_A111BR_Lab_ResultUnit[0]) != 0 )
               {
                  GXUtil.WriteLog("br_lab:[seudo value changed for attri]"+"BR_Lab_ResultUnit");
                  GXUtil.WriteLogRaw("Old: ",Z111BR_Lab_ResultUnit);
                  GXUtil.WriteLogRaw("Current: ",T000G2_A111BR_Lab_ResultUnit[0]);
               }
               if ( StringUtil.StrCmp(Z112BR_Lab_AbnInd, T000G2_A112BR_Lab_AbnInd[0]) != 0 )
               {
                  GXUtil.WriteLog("br_lab:[seudo value changed for attri]"+"BR_Lab_AbnInd");
                  GXUtil.WriteLogRaw("Old: ",Z112BR_Lab_AbnInd);
                  GXUtil.WriteLogRaw("Current: ",T000G2_A112BR_Lab_AbnInd[0]);
               }
               if ( StringUtil.StrCmp(Z113BR_Lab_NormRangeLow, T000G2_A113BR_Lab_NormRangeLow[0]) != 0 )
               {
                  GXUtil.WriteLog("br_lab:[seudo value changed for attri]"+"BR_Lab_NormRangeLow");
                  GXUtil.WriteLogRaw("Old: ",Z113BR_Lab_NormRangeLow);
                  GXUtil.WriteLogRaw("Current: ",T000G2_A113BR_Lab_NormRangeLow[0]);
               }
               if ( StringUtil.StrCmp(Z114BR_Lab_NormRangeHigh, T000G2_A114BR_Lab_NormRangeHigh[0]) != 0 )
               {
                  GXUtil.WriteLog("br_lab:[seudo value changed for attri]"+"BR_Lab_NormRangeHigh");
                  GXUtil.WriteLogRaw("Old: ",Z114BR_Lab_NormRangeHigh);
                  GXUtil.WriteLogRaw("Current: ",T000G2_A114BR_Lab_NormRangeHigh[0]);
               }
               if ( StringUtil.StrCmp(Z115BR_Lab_TestMethod, T000G2_A115BR_Lab_TestMethod[0]) != 0 )
               {
                  GXUtil.WriteLog("br_lab:[seudo value changed for attri]"+"BR_Lab_TestMethod");
                  GXUtil.WriteLogRaw("Old: ",Z115BR_Lab_TestMethod);
                  GXUtil.WriteLogRaw("Current: ",T000G2_A115BR_Lab_TestMethod[0]);
               }
               if ( StringUtil.StrCmp(Z117BR_Lab_InstrumentName, T000G2_A117BR_Lab_InstrumentName[0]) != 0 )
               {
                  GXUtil.WriteLog("br_lab:[seudo value changed for attri]"+"BR_Lab_InstrumentName");
                  GXUtil.WriteLogRaw("Old: ",Z117BR_Lab_InstrumentName);
                  GXUtil.WriteLogRaw("Current: ",T000G2_A117BR_Lab_InstrumentName[0]);
               }
               if ( StringUtil.StrCmp(Z118BR_Lab_InstrumentCode, T000G2_A118BR_Lab_InstrumentCode[0]) != 0 )
               {
                  GXUtil.WriteLog("br_lab:[seudo value changed for attri]"+"BR_Lab_InstrumentCode");
                  GXUtil.WriteLogRaw("Old: ",Z118BR_Lab_InstrumentCode);
                  GXUtil.WriteLogRaw("Current: ",T000G2_A118BR_Lab_InstrumentCode[0]);
               }
               if ( Z430BR_SampleId != T000G2_A430BR_SampleId[0] )
               {
                  GXUtil.WriteLog("br_lab:[seudo value changed for attri]"+"BR_SampleId");
                  GXUtil.WriteLogRaw("Old: ",Z430BR_SampleId);
                  GXUtil.WriteLogRaw("Current: ",T000G2_A430BR_SampleId[0]);
               }
               if ( Z19BR_EncounterID != T000G2_A19BR_EncounterID[0] )
               {
                  GXUtil.WriteLog("br_lab:[seudo value changed for attri]"+"BR_EncounterID");
                  GXUtil.WriteLogRaw("Old: ",Z19BR_EncounterID);
                  GXUtil.WriteLogRaw("Current: ",T000G2_A19BR_EncounterID[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"BR_Lab"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0G17( )
      {
         BeforeValidate0G17( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0G17( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0G17( 0) ;
            CheckOptimisticConcurrency0G17( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0G17( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0G17( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000G12 */
                     pr_default.execute(10, new Object[] {n474BR_Lab_SpecimenSource_Code, A474BR_Lab_SpecimenSource_Code, n475BR_Lab_ResultQual_Code, A475BR_Lab_ResultQual_Code, n476BR_Lab_AbnInd_Code, A476BR_Lab_AbnInd_Code, n224BR_Lab_SampleID, A224BR_Lab_SampleID, n102BR_Lab_TestID, A102BR_Lab_TestID, n103BR_Lab_TestCode, A103BR_Lab_TestCode, n104BR_Lab_TestName, A104BR_Lab_TestName, n261BR_Lab_TestEngName, A261BR_Lab_TestEngName, n262BR_Lab_Age, A262BR_Lab_Age, n263BR_Lab_Diag, A263BR_Lab_Diag, n105BR_Lab_SpecimenDate, A105BR_Lab_SpecimenDate, n264BR_Lab_ReceivingTime, A264BR_Lab_ReceivingTime, n265BR_Lab_ReportTime, A265BR_Lab_ReportTime, n106BR_Lab_SpecimenSource, A106BR_Lab_SpecimenSource, n109BR_Lab_ResultQual, A109BR_Lab_ResultQual, n110BR_Lab_ResultNum, A110BR_Lab_ResultNum, n111BR_Lab_ResultUnit, A111BR_Lab_ResultUnit, n112BR_Lab_AbnInd, A112BR_Lab_AbnInd, n113BR_Lab_NormRangeLow, A113BR_Lab_NormRangeLow, n114BR_Lab_NormRangeHigh, A114BR_Lab_NormRangeHigh, n115BR_Lab_TestMethod, A115BR_Lab_TestMethod, n117BR_Lab_InstrumentName, A117BR_Lab_InstrumentName, n118BR_Lab_InstrumentCode, A118BR_Lab_InstrumentCode, n430BR_SampleId, A430BR_SampleId, A19BR_EncounterID});
                     A101BR_LabID = T000G12_A101BR_LabID[0];
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A101BR_LabID", StringUtil.LTrim( StringUtil.Str( (decimal)(A101BR_LabID), 18, 0)));
                     pr_default.close(10);
                     dsDefault.SmartCacheProvider.SetUpdated("BR_Lab") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)),  "就诊信息",  StringUtil.Trim( StringUtil.Str( (decimal)(A101BR_LabID), 18, 0)),  "实验室检查",  "Create",  1) ;
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                           ResetCaption0G0( ) ;
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
               Load0G17( ) ;
            }
            EndLevel0G17( ) ;
         }
         CloseExtendedTableCursors0G17( ) ;
      }

      protected void Update0G17( )
      {
         BeforeValidate0G17( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0G17( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0G17( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0G17( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0G17( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000G13 */
                     pr_default.execute(11, new Object[] {n474BR_Lab_SpecimenSource_Code, A474BR_Lab_SpecimenSource_Code, n475BR_Lab_ResultQual_Code, A475BR_Lab_ResultQual_Code, n476BR_Lab_AbnInd_Code, A476BR_Lab_AbnInd_Code, n224BR_Lab_SampleID, A224BR_Lab_SampleID, n102BR_Lab_TestID, A102BR_Lab_TestID, n103BR_Lab_TestCode, A103BR_Lab_TestCode, n104BR_Lab_TestName, A104BR_Lab_TestName, n261BR_Lab_TestEngName, A261BR_Lab_TestEngName, n262BR_Lab_Age, A262BR_Lab_Age, n263BR_Lab_Diag, A263BR_Lab_Diag, n105BR_Lab_SpecimenDate, A105BR_Lab_SpecimenDate, n264BR_Lab_ReceivingTime, A264BR_Lab_ReceivingTime, n265BR_Lab_ReportTime, A265BR_Lab_ReportTime, n106BR_Lab_SpecimenSource, A106BR_Lab_SpecimenSource, n109BR_Lab_ResultQual, A109BR_Lab_ResultQual, n110BR_Lab_ResultNum, A110BR_Lab_ResultNum, n111BR_Lab_ResultUnit, A111BR_Lab_ResultUnit, n112BR_Lab_AbnInd, A112BR_Lab_AbnInd, n113BR_Lab_NormRangeLow, A113BR_Lab_NormRangeLow, n114BR_Lab_NormRangeHigh, A114BR_Lab_NormRangeHigh, n115BR_Lab_TestMethod, A115BR_Lab_TestMethod, n117BR_Lab_InstrumentName, A117BR_Lab_InstrumentName, n118BR_Lab_InstrumentCode, A118BR_Lab_InstrumentCode, n430BR_SampleId, A430BR_SampleId, A19BR_EncounterID, A101BR_LabID});
                     pr_default.close(11);
                     dsDefault.SmartCacheProvider.SetUpdated("BR_Lab") ;
                     if ( (pr_default.getStatus(11) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BR_Lab"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0G17( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)),  "就诊信息",  StringUtil.Trim( StringUtil.Str( (decimal)(A101BR_LabID), 18, 0)),  "实验室检查",  "Update",  1) ;
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
            EndLevel0G17( ) ;
         }
         CloseExtendedTableCursors0G17( ) ;
      }

      protected void DeferredUpdate0G17( )
      {
      }

      protected void delete( )
      {
         BeforeValidate0G17( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0G17( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0G17( ) ;
            AfterConfirm0G17( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0G17( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000G14 */
                  pr_default.execute(12, new Object[] {A101BR_LabID});
                  pr_default.close(12);
                  dsDefault.SmartCacheProvider.SetUpdated("BR_Lab") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)),  "就诊信息",  StringUtil.Trim( StringUtil.Str( (decimal)(A101BR_LabID), 18, 0)),  "实验室检查",  "Delete",  1) ;
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
         sMode17 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel0G17( ) ;
         Gx_mode = sMode17;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls0G17( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV17Pgmname = "BR_Lab";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17Pgmname", AV17Pgmname);
            /* Using cursor T000G15 */
            pr_default.execute(13, new Object[] {A19BR_EncounterID});
            A85BR_Information_ID = T000G15_A85BR_Information_ID[0];
            n85BR_Information_ID = T000G15_n85BR_Information_ID[0];
            pr_default.close(13);
            /* Using cursor T000G16 */
            pr_default.execute(14, new Object[] {n85BR_Information_ID, A85BR_Information_ID});
            A36BR_Information_PatientNo = T000G16_A36BR_Information_PatientNo[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36BR_Information_PatientNo", A36BR_Information_PatientNo);
            n36BR_Information_PatientNo = T000G16_n36BR_Information_PatientNo[0];
            pr_default.close(14);
            edtavVsource_Visible = ((StringUtil.StrCmp(A106BR_Lab_SpecimenSource, "其它")==0) ? 1 : 0);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVsource_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVsource_Visible), 5, 0)), true);
            if ( ! ( ( StringUtil.StrCmp(A106BR_Lab_SpecimenSource, "其它") == 0 ) ) )
            {
               cellVsource_cell_Class = "Invisible";
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVsource_cell_Internalname, "Class", cellVsource_cell_Class, true);
            }
            else
            {
               if ( StringUtil.StrCmp(A106BR_Lab_SpecimenSource, "其它") == 0 )
               {
                  cellVsource_cell_Class = "RequiredDataContentCell";
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVsource_cell_Internalname, "Class", cellVsource_cell_Class, true);
               }
            }
         }
      }

      protected void EndLevel0G17( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0G17( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(1);
            pr_default.close(13);
            pr_default.close(14);
            context.CommitDataStores("br_lab",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues0G0( ) ;
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
            context.RollbackDataStores("br_lab",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart0G17( )
      {
         /* Scan By routine */
         /* Using cursor T000G17 */
         pr_default.execute(15);
         RcdFound17 = 0;
         if ( (pr_default.getStatus(15) != 101) )
         {
            RcdFound17 = 1;
            A101BR_LabID = T000G17_A101BR_LabID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A101BR_LabID", StringUtil.LTrim( StringUtil.Str( (decimal)(A101BR_LabID), 18, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0G17( )
      {
         /* Scan next routine */
         pr_default.readNext(15);
         RcdFound17 = 0;
         if ( (pr_default.getStatus(15) != 101) )
         {
            RcdFound17 = 1;
            A101BR_LabID = T000G17_A101BR_LabID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A101BR_LabID", StringUtil.LTrim( StringUtil.Str( (decimal)(A101BR_LabID), 18, 0)));
         }
      }

      protected void ScanEnd0G17( )
      {
         pr_default.close(15);
      }

      protected void AfterConfirm0G17( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0G17( )
      {
         /* Before Insert Rules */
         GXt_char1 = A475BR_Lab_ResultQual_Code;
         new zutil_findtargetcode(context ).execute(  23,  A109BR_Lab_ResultQual, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A109BR_Lab_ResultQual", A109BR_Lab_ResultQual);
         A475BR_Lab_ResultQual_Code = GXt_char1;
         n475BR_Lab_ResultQual_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A475BR_Lab_ResultQual_Code", A475BR_Lab_ResultQual_Code);
         GXt_char1 = A476BR_Lab_AbnInd_Code;
         new zutil_findtargetcode(context ).execute(  24,  A112BR_Lab_AbnInd, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A112BR_Lab_AbnInd", A112BR_Lab_AbnInd);
         A476BR_Lab_AbnInd_Code = GXt_char1;
         n476BR_Lab_AbnInd_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A476BR_Lab_AbnInd_Code", A476BR_Lab_AbnInd_Code);
         if ( StringUtil.StrCmp(A106BR_Lab_SpecimenSource, "其它") == 0 )
         {
            A106BR_Lab_SpecimenSource = AV15vSource;
            n106BR_Lab_SpecimenSource = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A106BR_Lab_SpecimenSource", A106BR_Lab_SpecimenSource);
         }
         GXt_char1 = A474BR_Lab_SpecimenSource_Code;
         new zutil_findtargetcode(context ).execute(  22,  A106BR_Lab_SpecimenSource, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A106BR_Lab_SpecimenSource", A106BR_Lab_SpecimenSource);
         A474BR_Lab_SpecimenSource_Code = GXt_char1;
         n474BR_Lab_SpecimenSource_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A474BR_Lab_SpecimenSource_Code", A474BR_Lab_SpecimenSource_Code);
      }

      protected void BeforeUpdate0G17( )
      {
         /* Before Update Rules */
         GXt_char1 = A474BR_Lab_SpecimenSource_Code;
         new zutil_findtargetcode(context ).execute(  22,  A106BR_Lab_SpecimenSource, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A106BR_Lab_SpecimenSource", A106BR_Lab_SpecimenSource);
         A474BR_Lab_SpecimenSource_Code = GXt_char1;
         n474BR_Lab_SpecimenSource_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A474BR_Lab_SpecimenSource_Code", A474BR_Lab_SpecimenSource_Code);
         GXt_char1 = A475BR_Lab_ResultQual_Code;
         new zutil_findtargetcode(context ).execute(  23,  A109BR_Lab_ResultQual, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A109BR_Lab_ResultQual", A109BR_Lab_ResultQual);
         A475BR_Lab_ResultQual_Code = GXt_char1;
         n475BR_Lab_ResultQual_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A475BR_Lab_ResultQual_Code", A475BR_Lab_ResultQual_Code);
         GXt_char1 = A476BR_Lab_AbnInd_Code;
         new zutil_findtargetcode(context ).execute(  24,  A112BR_Lab_AbnInd, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A112BR_Lab_AbnInd", A112BR_Lab_AbnInd);
         A476BR_Lab_AbnInd_Code = GXt_char1;
         n476BR_Lab_AbnInd_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A476BR_Lab_AbnInd_Code", A476BR_Lab_AbnInd_Code);
      }

      protected void BeforeDelete0G17( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0G17( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0G17( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0G17( )
      {
         edtBR_Lab_TestName_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Lab_TestName_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Lab_TestName_Enabled), 5, 0)), true);
         edtBR_Lab_TestEngName_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Lab_TestEngName_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Lab_TestEngName_Enabled), 5, 0)), true);
         edtBR_Lab_TestCode_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Lab_TestCode_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Lab_TestCode_Enabled), 5, 0)), true);
         edtBR_Lab_Age_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Lab_Age_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Lab_Age_Enabled), 5, 0)), true);
         edtBR_Lab_Diag_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Lab_Diag_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Lab_Diag_Enabled), 5, 0)), true);
         dynBR_Lab_SpecimenSource.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynBR_Lab_SpecimenSource_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynBR_Lab_SpecimenSource.Enabled), 5, 0)), true);
         edtavVsource_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVsource_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVsource_Enabled), 5, 0)), true);
         edtBR_Lab_SpecimenDate_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Lab_SpecimenDate_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Lab_SpecimenDate_Enabled), 5, 0)), true);
         edtBR_Lab_ReceivingTime_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Lab_ReceivingTime_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Lab_ReceivingTime_Enabled), 5, 0)), true);
         edtBR_Lab_ReportTime_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Lab_ReportTime_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Lab_ReportTime_Enabled), 5, 0)), true);
         dynBR_Lab_ResultQual.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynBR_Lab_ResultQual_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynBR_Lab_ResultQual.Enabled), 5, 0)), true);
         edtBR_Lab_ResultUnit_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Lab_ResultUnit_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Lab_ResultUnit_Enabled), 5, 0)), true);
         dynBR_Lab_AbnInd.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynBR_Lab_AbnInd_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynBR_Lab_AbnInd.Enabled), 5, 0)), true);
         edtBR_Lab_NormRangeLow_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Lab_NormRangeLow_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Lab_NormRangeLow_Enabled), 5, 0)), true);
         edtBR_Lab_TestMethod_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Lab_TestMethod_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Lab_TestMethod_Enabled), 5, 0)), true);
         edtBR_Lab_InstrumentCode_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Lab_InstrumentCode_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Lab_InstrumentCode_Enabled), 5, 0)), true);
         edtBR_Lab_InstrumentName_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Lab_InstrumentName_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Lab_InstrumentName_Enabled), 5, 0)), true);
         edtBR_Lab_ResultNum_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Lab_ResultNum_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Lab_ResultNum_Enabled), 5, 0)), true);
         edtBR_LabID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_LabID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_LabID_Enabled), 5, 0)), true);
         edtBR_EncounterID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_EncounterID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_EncounterID_Enabled), 5, 0)), true);
         edtBR_Information_PatientNo_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Information_PatientNo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Information_PatientNo_Enabled), 5, 0)), true);
         edtBR_Lab_TestID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Lab_TestID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Lab_TestID_Enabled), 5, 0)), true);
         edtBR_Lab_NormRangeHigh_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Lab_NormRangeHigh_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Lab_NormRangeHigh_Enabled), 5, 0)), true);
      }

      protected void send_integrity_lvl_hashes0G17( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues0G0( )
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
         context.AddJavascriptSource("gxcfg.js", "?20202281571569", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_lab.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV12BR_LabID)+"\">") ;
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
         forbiddenHiddens = "hsh" + "BR_Lab";
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A101BR_LabID), "ZZZZZZZZZZZZZZZZZZ");
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( AV16tCurrentCode, ""));
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV10Insert_BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ");
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A224BR_Lab_SampleID, ""));
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A430BR_SampleId), "ZZZZZZZZZZZZZZZZZZ");
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("br_lab:[SendSecurityCheck value for]"+"BR_LabID:"+context.localUtil.Format( (decimal)(A101BR_LabID), "ZZZZZZZZZZZZZZZZZZ"));
         GXUtil.WriteLog("br_lab:[SendSecurityCheck value for]"+"tCurrentCode:"+StringUtil.RTrim( context.localUtil.Format( AV16tCurrentCode, "")));
         GXUtil.WriteLog("br_lab:[SendSecurityCheck value for]"+"Insert_BR_EncounterID:"+context.localUtil.Format( (decimal)(AV10Insert_BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ"));
         GXUtil.WriteLog("br_lab:[SendSecurityCheck value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
         GXUtil.WriteLog("br_lab:[SendSecurityCheck value for]"+"BR_Lab_SampleID:"+StringUtil.RTrim( context.localUtil.Format( A224BR_Lab_SampleID, "")));
         GXUtil.WriteLog("br_lab:[SendSecurityCheck value for]"+"BR_SampleId:"+context.localUtil.Format( (decimal)(A430BR_SampleId), "ZZZZZZZZZZZZZZZZZZ"));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z101BR_LabID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z101BR_LabID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z474BR_Lab_SpecimenSource_Code", Z474BR_Lab_SpecimenSource_Code);
         GxWebStd.gx_hidden_field( context, "Z475BR_Lab_ResultQual_Code", Z475BR_Lab_ResultQual_Code);
         GxWebStd.gx_hidden_field( context, "Z476BR_Lab_AbnInd_Code", Z476BR_Lab_AbnInd_Code);
         GxWebStd.gx_hidden_field( context, "Z224BR_Lab_SampleID", Z224BR_Lab_SampleID);
         GxWebStd.gx_hidden_field( context, "Z102BR_Lab_TestID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z102BR_Lab_TestID), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z103BR_Lab_TestCode", Z103BR_Lab_TestCode);
         GxWebStd.gx_hidden_field( context, "Z104BR_Lab_TestName", Z104BR_Lab_TestName);
         GxWebStd.gx_hidden_field( context, "Z261BR_Lab_TestEngName", Z261BR_Lab_TestEngName);
         GxWebStd.gx_hidden_field( context, "Z262BR_Lab_Age", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z262BR_Lab_Age), 3, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z263BR_Lab_Diag", Z263BR_Lab_Diag);
         GxWebStd.gx_hidden_field( context, "Z105BR_Lab_SpecimenDate", context.localUtil.TToC( Z105BR_Lab_SpecimenDate, 10, 8, 0, 0, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "Z264BR_Lab_ReceivingTime", context.localUtil.TToC( Z264BR_Lab_ReceivingTime, 10, 8, 0, 0, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "Z265BR_Lab_ReportTime", context.localUtil.TToC( Z265BR_Lab_ReportTime, 10, 8, 0, 0, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "Z106BR_Lab_SpecimenSource", Z106BR_Lab_SpecimenSource);
         GxWebStd.gx_hidden_field( context, "Z109BR_Lab_ResultQual", Z109BR_Lab_ResultQual);
         GxWebStd.gx_hidden_field( context, "Z110BR_Lab_ResultNum", Z110BR_Lab_ResultNum);
         GxWebStd.gx_hidden_field( context, "Z111BR_Lab_ResultUnit", Z111BR_Lab_ResultUnit);
         GxWebStd.gx_hidden_field( context, "Z112BR_Lab_AbnInd", Z112BR_Lab_AbnInd);
         GxWebStd.gx_hidden_field( context, "Z113BR_Lab_NormRangeLow", Z113BR_Lab_NormRangeLow);
         GxWebStd.gx_hidden_field( context, "Z114BR_Lab_NormRangeHigh", Z114BR_Lab_NormRangeHigh);
         GxWebStd.gx_hidden_field( context, "Z115BR_Lab_TestMethod", Z115BR_Lab_TestMethod);
         GxWebStd.gx_hidden_field( context, "Z117BR_Lab_InstrumentName", Z117BR_Lab_InstrumentName);
         GxWebStd.gx_hidden_field( context, "Z118BR_Lab_InstrumentCode", Z118BR_Lab_InstrumentCode);
         GxWebStd.gx_hidden_field( context, "Z430BR_SampleId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z430BR_SampleId), 18, 0, ".", "")));
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
         GxWebStd.gx_hidden_field( context, "vBR_LABID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV12BR_LabID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vBR_LABID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV12BR_LabID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, "vINSERT_BR_ENCOUNTERID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10Insert_BR_EncounterID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "BR_LAB_SPECIMENSOURCE_CODE", A474BR_Lab_SpecimenSource_Code);
         GxWebStd.gx_hidden_field( context, "BR_LAB_RESULTQUAL_CODE", A475BR_Lab_ResultQual_Code);
         GxWebStd.gx_hidden_field( context, "BR_LAB_ABNIND_CODE", A476BR_Lab_AbnInd_Code);
         GxWebStd.gx_hidden_field( context, "vTCURRENTCODE", AV16tCurrentCode);
         GxWebStd.gx_hidden_field( context, "BR_LAB_SAMPLEID", A224BR_Lab_SampleID);
         GxWebStd.gx_hidden_field( context, "BR_SAMPLEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A430BR_SampleId), 18, 0, ".", "")));
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
         return formatLink("br_lab.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV12BR_LabID) ;
      }

      public override String GetPgmname( )
      {
         return "BR_Lab" ;
      }

      public override String GetPgmdesc( )
      {
         return "Data Mgmt Portal - RAAP" ;
      }

      protected void InitializeNonKey0G17( )
      {
         A85BR_Information_ID = 0;
         n85BR_Information_ID = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A85BR_Information_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A85BR_Information_ID), 18, 0)));
         A19BR_EncounterID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
         AV15vSource = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15vSource", AV15vSource);
         A474BR_Lab_SpecimenSource_Code = "";
         n474BR_Lab_SpecimenSource_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A474BR_Lab_SpecimenSource_Code", A474BR_Lab_SpecimenSource_Code);
         A475BR_Lab_ResultQual_Code = "";
         n475BR_Lab_ResultQual_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A475BR_Lab_ResultQual_Code", A475BR_Lab_ResultQual_Code);
         A476BR_Lab_AbnInd_Code = "";
         n476BR_Lab_AbnInd_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A476BR_Lab_AbnInd_Code", A476BR_Lab_AbnInd_Code);
         A36BR_Information_PatientNo = "";
         n36BR_Information_PatientNo = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36BR_Information_PatientNo", A36BR_Information_PatientNo);
         A224BR_Lab_SampleID = "";
         n224BR_Lab_SampleID = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A224BR_Lab_SampleID", A224BR_Lab_SampleID);
         A102BR_Lab_TestID = 0;
         n102BR_Lab_TestID = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A102BR_Lab_TestID", StringUtil.LTrim( StringUtil.Str( (decimal)(A102BR_Lab_TestID), 10, 0)));
         n102BR_Lab_TestID = ((0==A102BR_Lab_TestID) ? true : false);
         A103BR_Lab_TestCode = "";
         n103BR_Lab_TestCode = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A103BR_Lab_TestCode", A103BR_Lab_TestCode);
         n103BR_Lab_TestCode = (String.IsNullOrEmpty(StringUtil.RTrim( A103BR_Lab_TestCode)) ? true : false);
         A104BR_Lab_TestName = "";
         n104BR_Lab_TestName = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A104BR_Lab_TestName", A104BR_Lab_TestName);
         n104BR_Lab_TestName = (String.IsNullOrEmpty(StringUtil.RTrim( A104BR_Lab_TestName)) ? true : false);
         A261BR_Lab_TestEngName = "";
         n261BR_Lab_TestEngName = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A261BR_Lab_TestEngName", A261BR_Lab_TestEngName);
         n261BR_Lab_TestEngName = (String.IsNullOrEmpty(StringUtil.RTrim( A261BR_Lab_TestEngName)) ? true : false);
         A262BR_Lab_Age = 0;
         n262BR_Lab_Age = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A262BR_Lab_Age", StringUtil.LTrim( StringUtil.Str( (decimal)(A262BR_Lab_Age), 3, 0)));
         n262BR_Lab_Age = ((0==A262BR_Lab_Age) ? true : false);
         A263BR_Lab_Diag = "";
         n263BR_Lab_Diag = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A263BR_Lab_Diag", A263BR_Lab_Diag);
         n263BR_Lab_Diag = (String.IsNullOrEmpty(StringUtil.RTrim( A263BR_Lab_Diag)) ? true : false);
         A105BR_Lab_SpecimenDate = (DateTime)(DateTime.MinValue);
         n105BR_Lab_SpecimenDate = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A105BR_Lab_SpecimenDate", context.localUtil.TToC( A105BR_Lab_SpecimenDate, 10, 8, 0, 0, "/", ":", " "));
         n105BR_Lab_SpecimenDate = ((DateTime.MinValue==A105BR_Lab_SpecimenDate) ? true : false);
         A264BR_Lab_ReceivingTime = (DateTime)(DateTime.MinValue);
         n264BR_Lab_ReceivingTime = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A264BR_Lab_ReceivingTime", context.localUtil.TToC( A264BR_Lab_ReceivingTime, 10, 8, 0, 0, "/", ":", " "));
         n264BR_Lab_ReceivingTime = ((DateTime.MinValue==A264BR_Lab_ReceivingTime) ? true : false);
         A265BR_Lab_ReportTime = (DateTime)(DateTime.MinValue);
         n265BR_Lab_ReportTime = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A265BR_Lab_ReportTime", context.localUtil.TToC( A265BR_Lab_ReportTime, 10, 8, 0, 0, "/", ":", " "));
         n265BR_Lab_ReportTime = ((DateTime.MinValue==A265BR_Lab_ReportTime) ? true : false);
         A106BR_Lab_SpecimenSource = "";
         n106BR_Lab_SpecimenSource = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A106BR_Lab_SpecimenSource", A106BR_Lab_SpecimenSource);
         n106BR_Lab_SpecimenSource = (String.IsNullOrEmpty(StringUtil.RTrim( A106BR_Lab_SpecimenSource)) ? true : false);
         A109BR_Lab_ResultQual = "";
         n109BR_Lab_ResultQual = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A109BR_Lab_ResultQual", A109BR_Lab_ResultQual);
         n109BR_Lab_ResultQual = (String.IsNullOrEmpty(StringUtil.RTrim( A109BR_Lab_ResultQual)) ? true : false);
         A110BR_Lab_ResultNum = "";
         n110BR_Lab_ResultNum = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A110BR_Lab_ResultNum", A110BR_Lab_ResultNum);
         n110BR_Lab_ResultNum = (String.IsNullOrEmpty(StringUtil.RTrim( A110BR_Lab_ResultNum)) ? true : false);
         A111BR_Lab_ResultUnit = "";
         n111BR_Lab_ResultUnit = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A111BR_Lab_ResultUnit", A111BR_Lab_ResultUnit);
         n111BR_Lab_ResultUnit = (String.IsNullOrEmpty(StringUtil.RTrim( A111BR_Lab_ResultUnit)) ? true : false);
         A112BR_Lab_AbnInd = "";
         n112BR_Lab_AbnInd = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A112BR_Lab_AbnInd", A112BR_Lab_AbnInd);
         n112BR_Lab_AbnInd = (String.IsNullOrEmpty(StringUtil.RTrim( A112BR_Lab_AbnInd)) ? true : false);
         A113BR_Lab_NormRangeLow = "";
         n113BR_Lab_NormRangeLow = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A113BR_Lab_NormRangeLow", A113BR_Lab_NormRangeLow);
         n113BR_Lab_NormRangeLow = (String.IsNullOrEmpty(StringUtil.RTrim( A113BR_Lab_NormRangeLow)) ? true : false);
         A114BR_Lab_NormRangeHigh = "";
         n114BR_Lab_NormRangeHigh = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A114BR_Lab_NormRangeHigh", A114BR_Lab_NormRangeHigh);
         n114BR_Lab_NormRangeHigh = (String.IsNullOrEmpty(StringUtil.RTrim( A114BR_Lab_NormRangeHigh)) ? true : false);
         A115BR_Lab_TestMethod = "";
         n115BR_Lab_TestMethod = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A115BR_Lab_TestMethod", A115BR_Lab_TestMethod);
         n115BR_Lab_TestMethod = (String.IsNullOrEmpty(StringUtil.RTrim( A115BR_Lab_TestMethod)) ? true : false);
         A117BR_Lab_InstrumentName = "";
         n117BR_Lab_InstrumentName = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A117BR_Lab_InstrumentName", A117BR_Lab_InstrumentName);
         n117BR_Lab_InstrumentName = (String.IsNullOrEmpty(StringUtil.RTrim( A117BR_Lab_InstrumentName)) ? true : false);
         A118BR_Lab_InstrumentCode = "";
         n118BR_Lab_InstrumentCode = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A118BR_Lab_InstrumentCode", A118BR_Lab_InstrumentCode);
         n118BR_Lab_InstrumentCode = (String.IsNullOrEmpty(StringUtil.RTrim( A118BR_Lab_InstrumentCode)) ? true : false);
         A430BR_SampleId = 0;
         n430BR_SampleId = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A430BR_SampleId", StringUtil.LTrim( StringUtil.Str( (decimal)(A430BR_SampleId), 18, 0)));
         Z474BR_Lab_SpecimenSource_Code = "";
         Z475BR_Lab_ResultQual_Code = "";
         Z476BR_Lab_AbnInd_Code = "";
         Z224BR_Lab_SampleID = "";
         Z102BR_Lab_TestID = 0;
         Z103BR_Lab_TestCode = "";
         Z104BR_Lab_TestName = "";
         Z261BR_Lab_TestEngName = "";
         Z262BR_Lab_Age = 0;
         Z263BR_Lab_Diag = "";
         Z105BR_Lab_SpecimenDate = (DateTime)(DateTime.MinValue);
         Z264BR_Lab_ReceivingTime = (DateTime)(DateTime.MinValue);
         Z265BR_Lab_ReportTime = (DateTime)(DateTime.MinValue);
         Z106BR_Lab_SpecimenSource = "";
         Z109BR_Lab_ResultQual = "";
         Z110BR_Lab_ResultNum = "";
         Z111BR_Lab_ResultUnit = "";
         Z112BR_Lab_AbnInd = "";
         Z113BR_Lab_NormRangeLow = "";
         Z114BR_Lab_NormRangeHigh = "";
         Z115BR_Lab_TestMethod = "";
         Z117BR_Lab_InstrumentName = "";
         Z118BR_Lab_InstrumentCode = "";
         Z430BR_SampleId = 0;
         Z19BR_EncounterID = 0;
      }

      protected void InitAll0G17( )
      {
         A101BR_LabID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A101BR_LabID", StringUtil.LTrim( StringUtil.Str( (decimal)(A101BR_LabID), 18, 0)));
         InitializeNonKey0G17( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20202281571628", true);
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
         context.AddJavascriptSource("br_lab.js", "?20202281571628", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         lblTextblockbr_lab_testname_Internalname = "TEXTBLOCKBR_LAB_TESTNAME";
         edtBR_Lab_TestName_Internalname = "BR_LAB_TESTNAME";
         divUnnamedtablebr_lab_testname_Internalname = "UNNAMEDTABLEBR_LAB_TESTNAME";
         lblTextblockbr_lab_testengname_Internalname = "TEXTBLOCKBR_LAB_TESTENGNAME";
         edtBR_Lab_TestEngName_Internalname = "BR_LAB_TESTENGNAME";
         divUnnamedtablebr_lab_testengname_Internalname = "UNNAMEDTABLEBR_LAB_TESTENGNAME";
         edtBR_Lab_TestCode_Internalname = "BR_LAB_TESTCODE";
         lblTextblockbr_lab_age_Internalname = "TEXTBLOCKBR_LAB_AGE";
         edtBR_Lab_Age_Internalname = "BR_LAB_AGE";
         divUnnamedtablebr_lab_age_Internalname = "UNNAMEDTABLEBR_LAB_AGE";
         lblTextblockbr_lab_diag_Internalname = "TEXTBLOCKBR_LAB_DIAG";
         edtBR_Lab_Diag_Internalname = "BR_LAB_DIAG";
         divUnnamedtablebr_lab_diag_Internalname = "UNNAMEDTABLEBR_LAB_DIAG";
         lblTextblockbr_lab_specimensource_Internalname = "TEXTBLOCKBR_LAB_SPECIMENSOURCE";
         dynBR_Lab_SpecimenSource_Internalname = "BR_LAB_SPECIMENSOURCE";
         edtavVsource_Internalname = "vVSOURCE";
         cellVsource_cell_Internalname = "VSOURCE_CELL";
         tblTablemergedbr_lab_specimensource_Internalname = "TABLEMERGEDBR_LAB_SPECIMENSOURCE";
         divTablesplittedbr_lab_specimensource_Internalname = "TABLESPLITTEDBR_LAB_SPECIMENSOURCE";
         lblTextblockbr_lab_specimendate_Internalname = "TEXTBLOCKBR_LAB_SPECIMENDATE";
         edtBR_Lab_SpecimenDate_Internalname = "BR_LAB_SPECIMENDATE";
         divUnnamedtablebr_lab_specimendate_Internalname = "UNNAMEDTABLEBR_LAB_SPECIMENDATE";
         lblTextblockbr_lab_receivingtime_Internalname = "TEXTBLOCKBR_LAB_RECEIVINGTIME";
         edtBR_Lab_ReceivingTime_Internalname = "BR_LAB_RECEIVINGTIME";
         divUnnamedtablebr_lab_receivingtime_Internalname = "UNNAMEDTABLEBR_LAB_RECEIVINGTIME";
         lblTextblockbr_lab_reporttime_Internalname = "TEXTBLOCKBR_LAB_REPORTTIME";
         edtBR_Lab_ReportTime_Internalname = "BR_LAB_REPORTTIME";
         divUnnamedtablebr_lab_reporttime_Internalname = "UNNAMEDTABLEBR_LAB_REPORTTIME";
         lblTextblockbr_lab_resultqual_Internalname = "TEXTBLOCKBR_LAB_RESULTQUAL";
         dynBR_Lab_ResultQual_Internalname = "BR_LAB_RESULTQUAL";
         divUnnamedtablebr_lab_resultqual_Internalname = "UNNAMEDTABLEBR_LAB_RESULTQUAL";
         lblTextblockbr_lab_resultunit_Internalname = "TEXTBLOCKBR_LAB_RESULTUNIT";
         edtBR_Lab_ResultUnit_Internalname = "BR_LAB_RESULTUNIT";
         divUnnamedtablebr_lab_resultunit_Internalname = "UNNAMEDTABLEBR_LAB_RESULTUNIT";
         lblTextblockbr_lab_abnind_Internalname = "TEXTBLOCKBR_LAB_ABNIND";
         dynBR_Lab_AbnInd_Internalname = "BR_LAB_ABNIND";
         divUnnamedtablebr_lab_abnind_Internalname = "UNNAMEDTABLEBR_LAB_ABNIND";
         lblTextblockbr_lab_normrangelow_Internalname = "TEXTBLOCKBR_LAB_NORMRANGELOW";
         edtBR_Lab_NormRangeLow_Internalname = "BR_LAB_NORMRANGELOW";
         divUnnamedtablebr_lab_normrangelow_Internalname = "UNNAMEDTABLEBR_LAB_NORMRANGELOW";
         lblTextblockbr_lab_testmethod_Internalname = "TEXTBLOCKBR_LAB_TESTMETHOD";
         edtBR_Lab_TestMethod_Internalname = "BR_LAB_TESTMETHOD";
         divUnnamedtablebr_lab_testmethod_Internalname = "UNNAMEDTABLEBR_LAB_TESTMETHOD";
         lblTextblockbr_lab_instrumentcode_Internalname = "TEXTBLOCKBR_LAB_INSTRUMENTCODE";
         edtBR_Lab_InstrumentCode_Internalname = "BR_LAB_INSTRUMENTCODE";
         divUnnamedtablebr_lab_instrumentcode_Internalname = "UNNAMEDTABLEBR_LAB_INSTRUMENTCODE";
         lblTextblockbr_lab_instrumentname_Internalname = "TEXTBLOCKBR_LAB_INSTRUMENTNAME";
         edtBR_Lab_InstrumentName_Internalname = "BR_LAB_INSTRUMENTNAME";
         divUnnamedtablebr_lab_instrumentname_Internalname = "UNNAMEDTABLEBR_LAB_INSTRUMENTNAME";
         lblTextblockbr_lab_resultnum_Internalname = "TEXTBLOCKBR_LAB_RESULTNUM";
         edtBR_Lab_ResultNum_Internalname = "BR_LAB_RESULTNUM";
         divUnnamedtablebr_lab_resultnum_Internalname = "UNNAMEDTABLEBR_LAB_RESULTNUM";
         divTableattributes_Internalname = "TABLEATTRIBUTES";
         divLayout_tableattributes_Internalname = "LAYOUT_TABLEATTRIBUTES";
         Dvpanel_tableattributes_Internalname = "DVPANEL_TABLEATTRIBUTES";
         divHtml_dvpanel_tableattributes_Internalname = "HTML_DVPANEL_TABLEATTRIBUTES";
         divTablecontent_Internalname = "TABLECONTENT";
         bttBtntrn_enter_Internalname = "BTNTRN_ENTER";
         bttBtntrn_cancel_Internalname = "BTNTRN_CANCEL";
         bttBtntrn_delete_Internalname = "BTNTRN_DELETE";
         divTablemain_Internalname = "TABLEMAIN";
         edtBR_LabID_Internalname = "BR_LABID";
         edtBR_EncounterID_Internalname = "BR_ENCOUNTERID";
         edtBR_Information_PatientNo_Internalname = "BR_INFORMATION_PATIENTNO";
         edtBR_Lab_TestID_Internalname = "BR_LAB_TESTID";
         edtBR_Lab_NormRangeHigh_Internalname = "BR_LAB_NORMRANGEHIGH";
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
         edtavVsource_Jsonclick = "";
         edtavVsource_Enabled = 1;
         edtavVsource_Visible = 1;
         cellVsource_cell_Class = "";
         dynBR_Lab_SpecimenSource_Jsonclick = "";
         dynBR_Lab_SpecimenSource.Enabled = 1;
         edtBR_Lab_NormRangeHigh_Jsonclick = "";
         edtBR_Lab_NormRangeHigh_Enabled = 1;
         edtBR_Lab_NormRangeHigh_Visible = 1;
         edtBR_Lab_TestID_Jsonclick = "";
         edtBR_Lab_TestID_Enabled = 1;
         edtBR_Lab_TestID_Visible = 1;
         edtBR_Information_PatientNo_Jsonclick = "";
         edtBR_Information_PatientNo_Enabled = 0;
         edtBR_Information_PatientNo_Visible = 1;
         edtBR_EncounterID_Jsonclick = "";
         edtBR_EncounterID_Enabled = 1;
         edtBR_EncounterID_Visible = 1;
         edtBR_LabID_Jsonclick = "";
         edtBR_LabID_Enabled = 0;
         edtBR_LabID_Visible = 1;
         bttBtntrn_delete_Enabled = 0;
         bttBtntrn_delete_Visible = 1;
         bttBtntrn_cancel_Visible = 1;
         bttBtntrn_enter_Enabled = 1;
         bttBtntrn_enter_Visible = 1;
         edtBR_Lab_ResultNum_Enabled = 1;
         edtBR_Lab_InstrumentName_Enabled = 1;
         edtBR_Lab_InstrumentCode_Jsonclick = "";
         edtBR_Lab_InstrumentCode_Enabled = 1;
         edtBR_Lab_TestMethod_Jsonclick = "";
         edtBR_Lab_TestMethod_Enabled = 1;
         edtBR_Lab_NormRangeLow_Jsonclick = "";
         edtBR_Lab_NormRangeLow_Enabled = 1;
         dynBR_Lab_AbnInd_Jsonclick = "";
         dynBR_Lab_AbnInd.Enabled = 1;
         edtBR_Lab_ResultUnit_Jsonclick = "";
         edtBR_Lab_ResultUnit_Enabled = 1;
         dynBR_Lab_ResultQual_Jsonclick = "";
         dynBR_Lab_ResultQual.Enabled = 1;
         edtBR_Lab_ReportTime_Jsonclick = "";
         edtBR_Lab_ReportTime_Enabled = 1;
         edtBR_Lab_ReceivingTime_Jsonclick = "";
         edtBR_Lab_ReceivingTime_Enabled = 1;
         edtBR_Lab_SpecimenDate_Jsonclick = "";
         edtBR_Lab_SpecimenDate_Enabled = 1;
         edtBR_Lab_Diag_Jsonclick = "";
         edtBR_Lab_Diag_Enabled = 1;
         edtBR_Lab_Age_Jsonclick = "";
         edtBR_Lab_Age_Enabled = 1;
         edtBR_Lab_TestCode_Jsonclick = "";
         edtBR_Lab_TestCode_Enabled = 1;
         edtBR_Lab_TestEngName_Jsonclick = "";
         edtBR_Lab_TestEngName_Enabled = 1;
         edtBR_Lab_TestName_Jsonclick = "";
         edtBR_Lab_TestName_Enabled = 1;
         Dvpanel_tableattributes_Autoscroll = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Iconposition = "left";
         Dvpanel_tableattributes_Showcollapseicon = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsed = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsible = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Title = "实验室检查";
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

      protected void GXDLABR_LAB_SPECIMENSOURCE0G17( String AV16tCurrentCode )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLABR_LAB_SPECIMENSOURCE_data0G17( AV16tCurrentCode) ;
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

      protected void GXABR_LAB_SPECIMENSOURCE_html0G17( String AV16tCurrentCode )
      {
         String gxdynajaxvalue ;
         GXDLABR_LAB_SPECIMENSOURCE_data0G17( AV16tCurrentCode) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynBR_Lab_SpecimenSource.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex));
            dynBR_Lab_SpecimenSource.addItem(gxdynajaxvalue, ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLABR_LAB_SPECIMENSOURCE_data0G17( String AV16tCurrentCode )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add("");
         gxdynajaxctrldescr.Add("(请选择)");
         /* Using cursor T000G18 */
         pr_default.execute(16, new Object[] {AV16tCurrentCode});
         while ( (pr_default.getStatus(16) != 101) )
         {
            gxdynajaxctrlcodr.Add(T000G18_A168XT_DefineCodeName[0]);
            gxdynajaxctrldescr.Add(T000G18_A168XT_DefineCodeName[0]);
            pr_default.readNext(16);
         }
         pr_default.close(16);
      }

      protected void GXDLABR_LAB_RESULTQUAL0G17( String AV16tCurrentCode )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLABR_LAB_RESULTQUAL_data0G17( AV16tCurrentCode) ;
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

      protected void GXABR_LAB_RESULTQUAL_html0G17( String AV16tCurrentCode )
      {
         String gxdynajaxvalue ;
         GXDLABR_LAB_RESULTQUAL_data0G17( AV16tCurrentCode) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynBR_Lab_ResultQual.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex));
            dynBR_Lab_ResultQual.addItem(gxdynajaxvalue, ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLABR_LAB_RESULTQUAL_data0G17( String AV16tCurrentCode )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add("");
         gxdynajaxctrldescr.Add("(请选择)");
         /* Using cursor T000G19 */
         pr_default.execute(17, new Object[] {AV16tCurrentCode});
         while ( (pr_default.getStatus(17) != 101) )
         {
            gxdynajaxctrlcodr.Add(T000G19_A168XT_DefineCodeName[0]);
            gxdynajaxctrldescr.Add(T000G19_A168XT_DefineCodeName[0]);
            pr_default.readNext(17);
         }
         pr_default.close(17);
      }

      protected void GXDLABR_LAB_ABNIND0G17( String AV16tCurrentCode )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLABR_LAB_ABNIND_data0G17( AV16tCurrentCode) ;
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

      protected void GXABR_LAB_ABNIND_html0G17( String AV16tCurrentCode )
      {
         String gxdynajaxvalue ;
         GXDLABR_LAB_ABNIND_data0G17( AV16tCurrentCode) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynBR_Lab_AbnInd.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex));
            dynBR_Lab_AbnInd.addItem(gxdynajaxvalue, ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLABR_LAB_ABNIND_data0G17( String AV16tCurrentCode )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add("");
         gxdynajaxctrldescr.Add("(请选择)");
         /* Using cursor T000G20 */
         pr_default.execute(18, new Object[] {AV16tCurrentCode});
         while ( (pr_default.getStatus(18) != 101) )
         {
            gxdynajaxctrlcodr.Add(T000G20_A168XT_DefineCodeName[0]);
            gxdynajaxctrldescr.Add(T000G20_A168XT_DefineCodeName[0]);
            pr_default.readNext(18);
         }
         pr_default.close(18);
      }

      protected void GX12ASABR_LAB_SPECIMENSOURCE_CODE0G17( String A106BR_Lab_SpecimenSource )
      {
         GXt_char1 = A474BR_Lab_SpecimenSource_Code;
         new zutil_findtargetcode(context ).execute(  22,  A106BR_Lab_SpecimenSource, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A106BR_Lab_SpecimenSource", A106BR_Lab_SpecimenSource);
         A474BR_Lab_SpecimenSource_Code = GXt_char1;
         n474BR_Lab_SpecimenSource_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A474BR_Lab_SpecimenSource_Code", A474BR_Lab_SpecimenSource_Code);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A474BR_Lab_SpecimenSource_Code)+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GX13ASABR_LAB_SPECIMENSOURCE_CODE0G17( String A106BR_Lab_SpecimenSource )
      {
         GXt_char1 = A474BR_Lab_SpecimenSource_Code;
         new zutil_findtargetcode(context ).execute(  22,  A106BR_Lab_SpecimenSource, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A106BR_Lab_SpecimenSource", A106BR_Lab_SpecimenSource);
         A474BR_Lab_SpecimenSource_Code = GXt_char1;
         n474BR_Lab_SpecimenSource_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A474BR_Lab_SpecimenSource_Code", A474BR_Lab_SpecimenSource_Code);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A474BR_Lab_SpecimenSource_Code)+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GX14ASABR_LAB_RESULTQUAL_CODE0G17( String A109BR_Lab_ResultQual )
      {
         GXt_char1 = A475BR_Lab_ResultQual_Code;
         new zutil_findtargetcode(context ).execute(  23,  A109BR_Lab_ResultQual, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A109BR_Lab_ResultQual", A109BR_Lab_ResultQual);
         A475BR_Lab_ResultQual_Code = GXt_char1;
         n475BR_Lab_ResultQual_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A475BR_Lab_ResultQual_Code", A475BR_Lab_ResultQual_Code);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A475BR_Lab_ResultQual_Code)+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GX15ASABR_LAB_RESULTQUAL_CODE0G17( String A109BR_Lab_ResultQual )
      {
         GXt_char1 = A475BR_Lab_ResultQual_Code;
         new zutil_findtargetcode(context ).execute(  23,  A109BR_Lab_ResultQual, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A109BR_Lab_ResultQual", A109BR_Lab_ResultQual);
         A475BR_Lab_ResultQual_Code = GXt_char1;
         n475BR_Lab_ResultQual_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A475BR_Lab_ResultQual_Code", A475BR_Lab_ResultQual_Code);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A475BR_Lab_ResultQual_Code)+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GX16ASABR_LAB_ABNIND_CODE0G17( String A112BR_Lab_AbnInd )
      {
         GXt_char1 = A476BR_Lab_AbnInd_Code;
         new zutil_findtargetcode(context ).execute(  24,  A112BR_Lab_AbnInd, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A112BR_Lab_AbnInd", A112BR_Lab_AbnInd);
         A476BR_Lab_AbnInd_Code = GXt_char1;
         n476BR_Lab_AbnInd_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A476BR_Lab_AbnInd_Code", A476BR_Lab_AbnInd_Code);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A476BR_Lab_AbnInd_Code)+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GX17ASABR_LAB_ABNIND_CODE0G17( String A112BR_Lab_AbnInd )
      {
         GXt_char1 = A476BR_Lab_AbnInd_Code;
         new zutil_findtargetcode(context ).execute(  24,  A112BR_Lab_AbnInd, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A112BR_Lab_AbnInd", A112BR_Lab_AbnInd);
         A476BR_Lab_AbnInd_Code = GXt_char1;
         n476BR_Lab_AbnInd_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A476BR_Lab_AbnInd_Code", A476BR_Lab_AbnInd_Code);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A476BR_Lab_AbnInd_Code)+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void XC_26_0G17( )
      {
         new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)),  "就诊信息",  StringUtil.Trim( StringUtil.Str( (decimal)(A101BR_LabID), 18, 0)),  "实验室检查",  "Create",  1) ;
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

      protected void XC_27_0G17( )
      {
         new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)),  "就诊信息",  StringUtil.Trim( StringUtil.Str( (decimal)(A101BR_LabID), 18, 0)),  "实验室检查",  "Update",  1) ;
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

      protected void XC_28_0G17( )
      {
         new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)),  "就诊信息",  StringUtil.Trim( StringUtil.Str( (decimal)(A101BR_LabID), 18, 0)),  "实验室检查",  "Delete",  1) ;
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
         dynBR_Lab_SpecimenSource.Name = "BR_LAB_SPECIMENSOURCE";
         dynBR_Lab_SpecimenSource.WebTags = "";
         dynBR_Lab_ResultQual.Name = "BR_LAB_RESULTQUAL";
         dynBR_Lab_ResultQual.WebTags = "";
         dynBR_Lab_AbnInd.Name = "BR_LAB_ABNIND";
         dynBR_Lab_AbnInd.WebTags = "";
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
         /* Using cursor T000G21 */
         pr_default.execute(19, new Object[] {A19BR_EncounterID});
         if ( (pr_default.getStatus(19) == 101) )
         {
            GX_msglist.addItem("不匹配' T15'", "ForeignKeyNotFound", 1, "BR_ENCOUNTERID");
            AnyError = 1;
            GX_FocusControl = edtBR_EncounterID_Internalname;
         }
         A85BR_Information_ID = T000G21_A85BR_Information_ID[0];
         n85BR_Information_ID = T000G21_n85BR_Information_ID[0];
         pr_default.close(19);
         /* Using cursor T000G22 */
         pr_default.execute(20, new Object[] {n85BR_Information_ID, A85BR_Information_ID});
         if ( (pr_default.getStatus(20) == 101) )
         {
            if ( ! ( (0==A85BR_Information_ID) ) )
            {
               GX_msglist.addItem("不匹配' T16'", "ForeignKeyNotFound", 1, "");
               AnyError = 1;
            }
         }
         A36BR_Information_PatientNo = T000G22_A36BR_Information_PatientNo[0];
         n36BR_Information_PatientNo = T000G22_n36BR_Information_PatientNo[0];
         pr_default.close(20);
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
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV12BR_LabID',fld:'vBR_LABID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV12BR_LabID',fld:'vBR_LABID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'A101BR_LabID',fld:'BR_LABID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV16tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'AV10Insert_BR_EncounterID',fld:'vINSERT_BR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'A224BR_Lab_SampleID',fld:'BR_LAB_SAMPLEID',pic:''},{av:'A430BR_SampleId',fld:'BR_SAMPLEID',pic:'ZZZZZZZZZZZZZZZZZZ'}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("AFTER TRN","{handler:'E120G2',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV8TrnContext',fld:'vTRNCONTEXT',pic:''}]");
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
         pr_default.close(19);
         pr_default.close(13);
         pr_default.close(20);
         pr_default.close(14);
      }

      public override void initialize( )
      {
         sPrefix = "";
         wcpOGx_mode = "";
         Z474BR_Lab_SpecimenSource_Code = "";
         Z475BR_Lab_ResultQual_Code = "";
         Z476BR_Lab_AbnInd_Code = "";
         Z224BR_Lab_SampleID = "";
         Z103BR_Lab_TestCode = "";
         Z104BR_Lab_TestName = "";
         Z261BR_Lab_TestEngName = "";
         Z263BR_Lab_Diag = "";
         Z105BR_Lab_SpecimenDate = (DateTime)(DateTime.MinValue);
         Z264BR_Lab_ReceivingTime = (DateTime)(DateTime.MinValue);
         Z265BR_Lab_ReportTime = (DateTime)(DateTime.MinValue);
         Z106BR_Lab_SpecimenSource = "";
         Z109BR_Lab_ResultQual = "";
         Z110BR_Lab_ResultNum = "";
         Z111BR_Lab_ResultUnit = "";
         Z112BR_Lab_AbnInd = "";
         Z113BR_Lab_NormRangeLow = "";
         Z114BR_Lab_NormRangeHigh = "";
         Z115BR_Lab_TestMethod = "";
         Z117BR_Lab_InstrumentName = "";
         Z118BR_Lab_InstrumentCode = "";
         scmdbuf = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV16tCurrentCode = "";
         A106BR_Lab_SpecimenSource = "";
         A109BR_Lab_ResultQual = "";
         A112BR_Lab_AbnInd = "";
         GXKey = "";
         PreviousTooltip = "";
         PreviousCaption = "";
         Form = new GXWebForm();
         GX_FocusControl = "";
         ClassString = "";
         StyleString = "";
         ucDvpanel_tableattributes = new GXUserControl();
         lblTextblockbr_lab_testname_Jsonclick = "";
         TempTags = "";
         A104BR_Lab_TestName = "";
         lblTextblockbr_lab_testengname_Jsonclick = "";
         A261BR_Lab_TestEngName = "";
         A103BR_Lab_TestCode = "";
         lblTextblockbr_lab_age_Jsonclick = "";
         lblTextblockbr_lab_diag_Jsonclick = "";
         A263BR_Lab_Diag = "";
         lblTextblockbr_lab_specimensource_Jsonclick = "";
         lblTextblockbr_lab_specimendate_Jsonclick = "";
         A105BR_Lab_SpecimenDate = (DateTime)(DateTime.MinValue);
         lblTextblockbr_lab_receivingtime_Jsonclick = "";
         A264BR_Lab_ReceivingTime = (DateTime)(DateTime.MinValue);
         lblTextblockbr_lab_reporttime_Jsonclick = "";
         A265BR_Lab_ReportTime = (DateTime)(DateTime.MinValue);
         lblTextblockbr_lab_resultqual_Jsonclick = "";
         lblTextblockbr_lab_resultunit_Jsonclick = "";
         A111BR_Lab_ResultUnit = "";
         lblTextblockbr_lab_abnind_Jsonclick = "";
         lblTextblockbr_lab_normrangelow_Jsonclick = "";
         A113BR_Lab_NormRangeLow = "";
         lblTextblockbr_lab_testmethod_Jsonclick = "";
         A115BR_Lab_TestMethod = "";
         lblTextblockbr_lab_instrumentcode_Jsonclick = "";
         A118BR_Lab_InstrumentCode = "";
         lblTextblockbr_lab_instrumentname_Jsonclick = "";
         A117BR_Lab_InstrumentName = "";
         lblTextblockbr_lab_resultnum_Jsonclick = "";
         A110BR_Lab_ResultNum = "";
         bttBtntrn_enter_Jsonclick = "";
         bttBtntrn_cancel_Jsonclick = "";
         bttBtntrn_delete_Jsonclick = "";
         A36BR_Information_PatientNo = "";
         A114BR_Lab_NormRangeHigh = "";
         sStyleString = "";
         AV15vSource = "";
         A474BR_Lab_SpecimenSource_Code = "";
         A475BR_Lab_ResultQual_Code = "";
         A476BR_Lab_AbnInd_Code = "";
         A224BR_Lab_SampleID = "";
         AV17Pgmname = "";
         Dvpanel_tableattributes_Objectcall = "";
         Dvpanel_tableattributes_Class = "";
         Dvpanel_tableattributes_Height = "";
         forbiddenHiddens = "";
         hsh = "";
         sMode17 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV7WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV8TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV9WebSession = context.GetSession();
         AV11TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         Z36BR_Information_PatientNo = "";
         T000G4_A85BR_Information_ID = new long[1] ;
         T000G4_n85BR_Information_ID = new bool[] {false} ;
         T000G5_A36BR_Information_PatientNo = new String[] {""} ;
         T000G5_n36BR_Information_PatientNo = new bool[] {false} ;
         T000G6_A85BR_Information_ID = new long[1] ;
         T000G6_n85BR_Information_ID = new bool[] {false} ;
         T000G6_A101BR_LabID = new long[1] ;
         T000G6_A474BR_Lab_SpecimenSource_Code = new String[] {""} ;
         T000G6_n474BR_Lab_SpecimenSource_Code = new bool[] {false} ;
         T000G6_A475BR_Lab_ResultQual_Code = new String[] {""} ;
         T000G6_n475BR_Lab_ResultQual_Code = new bool[] {false} ;
         T000G6_A476BR_Lab_AbnInd_Code = new String[] {""} ;
         T000G6_n476BR_Lab_AbnInd_Code = new bool[] {false} ;
         T000G6_A36BR_Information_PatientNo = new String[] {""} ;
         T000G6_n36BR_Information_PatientNo = new bool[] {false} ;
         T000G6_A224BR_Lab_SampleID = new String[] {""} ;
         T000G6_n224BR_Lab_SampleID = new bool[] {false} ;
         T000G6_A102BR_Lab_TestID = new long[1] ;
         T000G6_n102BR_Lab_TestID = new bool[] {false} ;
         T000G6_A103BR_Lab_TestCode = new String[] {""} ;
         T000G6_n103BR_Lab_TestCode = new bool[] {false} ;
         T000G6_A104BR_Lab_TestName = new String[] {""} ;
         T000G6_n104BR_Lab_TestName = new bool[] {false} ;
         T000G6_A261BR_Lab_TestEngName = new String[] {""} ;
         T000G6_n261BR_Lab_TestEngName = new bool[] {false} ;
         T000G6_A262BR_Lab_Age = new short[1] ;
         T000G6_n262BR_Lab_Age = new bool[] {false} ;
         T000G6_A263BR_Lab_Diag = new String[] {""} ;
         T000G6_n263BR_Lab_Diag = new bool[] {false} ;
         T000G6_A105BR_Lab_SpecimenDate = new DateTime[] {DateTime.MinValue} ;
         T000G6_n105BR_Lab_SpecimenDate = new bool[] {false} ;
         T000G6_A264BR_Lab_ReceivingTime = new DateTime[] {DateTime.MinValue} ;
         T000G6_n264BR_Lab_ReceivingTime = new bool[] {false} ;
         T000G6_A265BR_Lab_ReportTime = new DateTime[] {DateTime.MinValue} ;
         T000G6_n265BR_Lab_ReportTime = new bool[] {false} ;
         T000G6_A106BR_Lab_SpecimenSource = new String[] {""} ;
         T000G6_n106BR_Lab_SpecimenSource = new bool[] {false} ;
         T000G6_A109BR_Lab_ResultQual = new String[] {""} ;
         T000G6_n109BR_Lab_ResultQual = new bool[] {false} ;
         T000G6_A110BR_Lab_ResultNum = new String[] {""} ;
         T000G6_n110BR_Lab_ResultNum = new bool[] {false} ;
         T000G6_A111BR_Lab_ResultUnit = new String[] {""} ;
         T000G6_n111BR_Lab_ResultUnit = new bool[] {false} ;
         T000G6_A112BR_Lab_AbnInd = new String[] {""} ;
         T000G6_n112BR_Lab_AbnInd = new bool[] {false} ;
         T000G6_A113BR_Lab_NormRangeLow = new String[] {""} ;
         T000G6_n113BR_Lab_NormRangeLow = new bool[] {false} ;
         T000G6_A114BR_Lab_NormRangeHigh = new String[] {""} ;
         T000G6_n114BR_Lab_NormRangeHigh = new bool[] {false} ;
         T000G6_A115BR_Lab_TestMethod = new String[] {""} ;
         T000G6_n115BR_Lab_TestMethod = new bool[] {false} ;
         T000G6_A117BR_Lab_InstrumentName = new String[] {""} ;
         T000G6_n117BR_Lab_InstrumentName = new bool[] {false} ;
         T000G6_A118BR_Lab_InstrumentCode = new String[] {""} ;
         T000G6_n118BR_Lab_InstrumentCode = new bool[] {false} ;
         T000G6_A430BR_SampleId = new long[1] ;
         T000G6_n430BR_SampleId = new bool[] {false} ;
         T000G6_A19BR_EncounterID = new long[1] ;
         T000G7_A85BR_Information_ID = new long[1] ;
         T000G7_n85BR_Information_ID = new bool[] {false} ;
         T000G8_A36BR_Information_PatientNo = new String[] {""} ;
         T000G8_n36BR_Information_PatientNo = new bool[] {false} ;
         T000G9_A101BR_LabID = new long[1] ;
         T000G3_A101BR_LabID = new long[1] ;
         T000G3_A474BR_Lab_SpecimenSource_Code = new String[] {""} ;
         T000G3_n474BR_Lab_SpecimenSource_Code = new bool[] {false} ;
         T000G3_A475BR_Lab_ResultQual_Code = new String[] {""} ;
         T000G3_n475BR_Lab_ResultQual_Code = new bool[] {false} ;
         T000G3_A476BR_Lab_AbnInd_Code = new String[] {""} ;
         T000G3_n476BR_Lab_AbnInd_Code = new bool[] {false} ;
         T000G3_A224BR_Lab_SampleID = new String[] {""} ;
         T000G3_n224BR_Lab_SampleID = new bool[] {false} ;
         T000G3_A102BR_Lab_TestID = new long[1] ;
         T000G3_n102BR_Lab_TestID = new bool[] {false} ;
         T000G3_A103BR_Lab_TestCode = new String[] {""} ;
         T000G3_n103BR_Lab_TestCode = new bool[] {false} ;
         T000G3_A104BR_Lab_TestName = new String[] {""} ;
         T000G3_n104BR_Lab_TestName = new bool[] {false} ;
         T000G3_A261BR_Lab_TestEngName = new String[] {""} ;
         T000G3_n261BR_Lab_TestEngName = new bool[] {false} ;
         T000G3_A262BR_Lab_Age = new short[1] ;
         T000G3_n262BR_Lab_Age = new bool[] {false} ;
         T000G3_A263BR_Lab_Diag = new String[] {""} ;
         T000G3_n263BR_Lab_Diag = new bool[] {false} ;
         T000G3_A105BR_Lab_SpecimenDate = new DateTime[] {DateTime.MinValue} ;
         T000G3_n105BR_Lab_SpecimenDate = new bool[] {false} ;
         T000G3_A264BR_Lab_ReceivingTime = new DateTime[] {DateTime.MinValue} ;
         T000G3_n264BR_Lab_ReceivingTime = new bool[] {false} ;
         T000G3_A265BR_Lab_ReportTime = new DateTime[] {DateTime.MinValue} ;
         T000G3_n265BR_Lab_ReportTime = new bool[] {false} ;
         T000G3_A106BR_Lab_SpecimenSource = new String[] {""} ;
         T000G3_n106BR_Lab_SpecimenSource = new bool[] {false} ;
         T000G3_A109BR_Lab_ResultQual = new String[] {""} ;
         T000G3_n109BR_Lab_ResultQual = new bool[] {false} ;
         T000G3_A110BR_Lab_ResultNum = new String[] {""} ;
         T000G3_n110BR_Lab_ResultNum = new bool[] {false} ;
         T000G3_A111BR_Lab_ResultUnit = new String[] {""} ;
         T000G3_n111BR_Lab_ResultUnit = new bool[] {false} ;
         T000G3_A112BR_Lab_AbnInd = new String[] {""} ;
         T000G3_n112BR_Lab_AbnInd = new bool[] {false} ;
         T000G3_A113BR_Lab_NormRangeLow = new String[] {""} ;
         T000G3_n113BR_Lab_NormRangeLow = new bool[] {false} ;
         T000G3_A114BR_Lab_NormRangeHigh = new String[] {""} ;
         T000G3_n114BR_Lab_NormRangeHigh = new bool[] {false} ;
         T000G3_A115BR_Lab_TestMethod = new String[] {""} ;
         T000G3_n115BR_Lab_TestMethod = new bool[] {false} ;
         T000G3_A117BR_Lab_InstrumentName = new String[] {""} ;
         T000G3_n117BR_Lab_InstrumentName = new bool[] {false} ;
         T000G3_A118BR_Lab_InstrumentCode = new String[] {""} ;
         T000G3_n118BR_Lab_InstrumentCode = new bool[] {false} ;
         T000G3_A430BR_SampleId = new long[1] ;
         T000G3_n430BR_SampleId = new bool[] {false} ;
         T000G3_A19BR_EncounterID = new long[1] ;
         T000G10_A101BR_LabID = new long[1] ;
         T000G11_A101BR_LabID = new long[1] ;
         T000G2_A101BR_LabID = new long[1] ;
         T000G2_A474BR_Lab_SpecimenSource_Code = new String[] {""} ;
         T000G2_n474BR_Lab_SpecimenSource_Code = new bool[] {false} ;
         T000G2_A475BR_Lab_ResultQual_Code = new String[] {""} ;
         T000G2_n475BR_Lab_ResultQual_Code = new bool[] {false} ;
         T000G2_A476BR_Lab_AbnInd_Code = new String[] {""} ;
         T000G2_n476BR_Lab_AbnInd_Code = new bool[] {false} ;
         T000G2_A224BR_Lab_SampleID = new String[] {""} ;
         T000G2_n224BR_Lab_SampleID = new bool[] {false} ;
         T000G2_A102BR_Lab_TestID = new long[1] ;
         T000G2_n102BR_Lab_TestID = new bool[] {false} ;
         T000G2_A103BR_Lab_TestCode = new String[] {""} ;
         T000G2_n103BR_Lab_TestCode = new bool[] {false} ;
         T000G2_A104BR_Lab_TestName = new String[] {""} ;
         T000G2_n104BR_Lab_TestName = new bool[] {false} ;
         T000G2_A261BR_Lab_TestEngName = new String[] {""} ;
         T000G2_n261BR_Lab_TestEngName = new bool[] {false} ;
         T000G2_A262BR_Lab_Age = new short[1] ;
         T000G2_n262BR_Lab_Age = new bool[] {false} ;
         T000G2_A263BR_Lab_Diag = new String[] {""} ;
         T000G2_n263BR_Lab_Diag = new bool[] {false} ;
         T000G2_A105BR_Lab_SpecimenDate = new DateTime[] {DateTime.MinValue} ;
         T000G2_n105BR_Lab_SpecimenDate = new bool[] {false} ;
         T000G2_A264BR_Lab_ReceivingTime = new DateTime[] {DateTime.MinValue} ;
         T000G2_n264BR_Lab_ReceivingTime = new bool[] {false} ;
         T000G2_A265BR_Lab_ReportTime = new DateTime[] {DateTime.MinValue} ;
         T000G2_n265BR_Lab_ReportTime = new bool[] {false} ;
         T000G2_A106BR_Lab_SpecimenSource = new String[] {""} ;
         T000G2_n106BR_Lab_SpecimenSource = new bool[] {false} ;
         T000G2_A109BR_Lab_ResultQual = new String[] {""} ;
         T000G2_n109BR_Lab_ResultQual = new bool[] {false} ;
         T000G2_A110BR_Lab_ResultNum = new String[] {""} ;
         T000G2_n110BR_Lab_ResultNum = new bool[] {false} ;
         T000G2_A111BR_Lab_ResultUnit = new String[] {""} ;
         T000G2_n111BR_Lab_ResultUnit = new bool[] {false} ;
         T000G2_A112BR_Lab_AbnInd = new String[] {""} ;
         T000G2_n112BR_Lab_AbnInd = new bool[] {false} ;
         T000G2_A113BR_Lab_NormRangeLow = new String[] {""} ;
         T000G2_n113BR_Lab_NormRangeLow = new bool[] {false} ;
         T000G2_A114BR_Lab_NormRangeHigh = new String[] {""} ;
         T000G2_n114BR_Lab_NormRangeHigh = new bool[] {false} ;
         T000G2_A115BR_Lab_TestMethod = new String[] {""} ;
         T000G2_n115BR_Lab_TestMethod = new bool[] {false} ;
         T000G2_A117BR_Lab_InstrumentName = new String[] {""} ;
         T000G2_n117BR_Lab_InstrumentName = new bool[] {false} ;
         T000G2_A118BR_Lab_InstrumentCode = new String[] {""} ;
         T000G2_n118BR_Lab_InstrumentCode = new bool[] {false} ;
         T000G2_A430BR_SampleId = new long[1] ;
         T000G2_n430BR_SampleId = new bool[] {false} ;
         T000G2_A19BR_EncounterID = new long[1] ;
         T000G12_A101BR_LabID = new long[1] ;
         T000G15_A85BR_Information_ID = new long[1] ;
         T000G15_n85BR_Information_ID = new bool[] {false} ;
         T000G16_A36BR_Information_PatientNo = new String[] {""} ;
         T000G16_n36BR_Information_PatientNo = new bool[] {false} ;
         T000G17_A101BR_LabID = new long[1] ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         gxdynajaxctrlcodr = new GeneXus.Utils.GxStringCollection();
         gxdynajaxctrldescr = new GeneXus.Utils.GxStringCollection();
         gxwrpcisep = "";
         T000G18_A167XT_DefineCodeID = new long[1] ;
         T000G18_A168XT_DefineCodeName = new String[] {""} ;
         T000G18_n168XT_DefineCodeName = new bool[] {false} ;
         T000G18_A165XT_DefindcodeTypeID = new long[1] ;
         T000G18_A432XT_TenantCode = new String[] {""} ;
         T000G18_n432XT_TenantCode = new bool[] {false} ;
         T000G19_A167XT_DefineCodeID = new long[1] ;
         T000G19_A168XT_DefineCodeName = new String[] {""} ;
         T000G19_n168XT_DefineCodeName = new bool[] {false} ;
         T000G19_A165XT_DefindcodeTypeID = new long[1] ;
         T000G19_A432XT_TenantCode = new String[] {""} ;
         T000G19_n432XT_TenantCode = new bool[] {false} ;
         T000G20_A167XT_DefineCodeID = new long[1] ;
         T000G20_A168XT_DefineCodeName = new String[] {""} ;
         T000G20_n168XT_DefineCodeName = new bool[] {false} ;
         T000G20_A165XT_DefindcodeTypeID = new long[1] ;
         T000G20_A432XT_TenantCode = new String[] {""} ;
         T000G20_n432XT_TenantCode = new bool[] {false} ;
         GXt_char1 = "";
         T000G21_A85BR_Information_ID = new long[1] ;
         T000G21_n85BR_Information_ID = new bool[] {false} ;
         T000G22_A36BR_Information_PatientNo = new String[] {""} ;
         T000G22_n36BR_Information_PatientNo = new bool[] {false} ;
         isValidOutput = new GxUnknownObjectCollection();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.br_lab__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_lab__default(),
            new Object[][] {
                new Object[] {
               T000G2_A101BR_LabID, T000G2_A474BR_Lab_SpecimenSource_Code, T000G2_n474BR_Lab_SpecimenSource_Code, T000G2_A475BR_Lab_ResultQual_Code, T000G2_n475BR_Lab_ResultQual_Code, T000G2_A476BR_Lab_AbnInd_Code, T000G2_n476BR_Lab_AbnInd_Code, T000G2_A224BR_Lab_SampleID, T000G2_n224BR_Lab_SampleID, T000G2_A102BR_Lab_TestID,
               T000G2_n102BR_Lab_TestID, T000G2_A103BR_Lab_TestCode, T000G2_n103BR_Lab_TestCode, T000G2_A104BR_Lab_TestName, T000G2_n104BR_Lab_TestName, T000G2_A261BR_Lab_TestEngName, T000G2_n261BR_Lab_TestEngName, T000G2_A262BR_Lab_Age, T000G2_n262BR_Lab_Age, T000G2_A263BR_Lab_Diag,
               T000G2_n263BR_Lab_Diag, T000G2_A105BR_Lab_SpecimenDate, T000G2_n105BR_Lab_SpecimenDate, T000G2_A264BR_Lab_ReceivingTime, T000G2_n264BR_Lab_ReceivingTime, T000G2_A265BR_Lab_ReportTime, T000G2_n265BR_Lab_ReportTime, T000G2_A106BR_Lab_SpecimenSource, T000G2_n106BR_Lab_SpecimenSource, T000G2_A109BR_Lab_ResultQual,
               T000G2_n109BR_Lab_ResultQual, T000G2_A110BR_Lab_ResultNum, T000G2_n110BR_Lab_ResultNum, T000G2_A111BR_Lab_ResultUnit, T000G2_n111BR_Lab_ResultUnit, T000G2_A112BR_Lab_AbnInd, T000G2_n112BR_Lab_AbnInd, T000G2_A113BR_Lab_NormRangeLow, T000G2_n113BR_Lab_NormRangeLow, T000G2_A114BR_Lab_NormRangeHigh,
               T000G2_n114BR_Lab_NormRangeHigh, T000G2_A115BR_Lab_TestMethod, T000G2_n115BR_Lab_TestMethod, T000G2_A117BR_Lab_InstrumentName, T000G2_n117BR_Lab_InstrumentName, T000G2_A118BR_Lab_InstrumentCode, T000G2_n118BR_Lab_InstrumentCode, T000G2_A430BR_SampleId, T000G2_n430BR_SampleId, T000G2_A19BR_EncounterID
               }
               , new Object[] {
               T000G3_A101BR_LabID, T000G3_A474BR_Lab_SpecimenSource_Code, T000G3_n474BR_Lab_SpecimenSource_Code, T000G3_A475BR_Lab_ResultQual_Code, T000G3_n475BR_Lab_ResultQual_Code, T000G3_A476BR_Lab_AbnInd_Code, T000G3_n476BR_Lab_AbnInd_Code, T000G3_A224BR_Lab_SampleID, T000G3_n224BR_Lab_SampleID, T000G3_A102BR_Lab_TestID,
               T000G3_n102BR_Lab_TestID, T000G3_A103BR_Lab_TestCode, T000G3_n103BR_Lab_TestCode, T000G3_A104BR_Lab_TestName, T000G3_n104BR_Lab_TestName, T000G3_A261BR_Lab_TestEngName, T000G3_n261BR_Lab_TestEngName, T000G3_A262BR_Lab_Age, T000G3_n262BR_Lab_Age, T000G3_A263BR_Lab_Diag,
               T000G3_n263BR_Lab_Diag, T000G3_A105BR_Lab_SpecimenDate, T000G3_n105BR_Lab_SpecimenDate, T000G3_A264BR_Lab_ReceivingTime, T000G3_n264BR_Lab_ReceivingTime, T000G3_A265BR_Lab_ReportTime, T000G3_n265BR_Lab_ReportTime, T000G3_A106BR_Lab_SpecimenSource, T000G3_n106BR_Lab_SpecimenSource, T000G3_A109BR_Lab_ResultQual,
               T000G3_n109BR_Lab_ResultQual, T000G3_A110BR_Lab_ResultNum, T000G3_n110BR_Lab_ResultNum, T000G3_A111BR_Lab_ResultUnit, T000G3_n111BR_Lab_ResultUnit, T000G3_A112BR_Lab_AbnInd, T000G3_n112BR_Lab_AbnInd, T000G3_A113BR_Lab_NormRangeLow, T000G3_n113BR_Lab_NormRangeLow, T000G3_A114BR_Lab_NormRangeHigh,
               T000G3_n114BR_Lab_NormRangeHigh, T000G3_A115BR_Lab_TestMethod, T000G3_n115BR_Lab_TestMethod, T000G3_A117BR_Lab_InstrumentName, T000G3_n117BR_Lab_InstrumentName, T000G3_A118BR_Lab_InstrumentCode, T000G3_n118BR_Lab_InstrumentCode, T000G3_A430BR_SampleId, T000G3_n430BR_SampleId, T000G3_A19BR_EncounterID
               }
               , new Object[] {
               T000G4_A85BR_Information_ID, T000G4_n85BR_Information_ID
               }
               , new Object[] {
               T000G5_A36BR_Information_PatientNo, T000G5_n36BR_Information_PatientNo
               }
               , new Object[] {
               T000G6_A85BR_Information_ID, T000G6_n85BR_Information_ID, T000G6_A101BR_LabID, T000G6_A474BR_Lab_SpecimenSource_Code, T000G6_n474BR_Lab_SpecimenSource_Code, T000G6_A475BR_Lab_ResultQual_Code, T000G6_n475BR_Lab_ResultQual_Code, T000G6_A476BR_Lab_AbnInd_Code, T000G6_n476BR_Lab_AbnInd_Code, T000G6_A36BR_Information_PatientNo,
               T000G6_n36BR_Information_PatientNo, T000G6_A224BR_Lab_SampleID, T000G6_n224BR_Lab_SampleID, T000G6_A102BR_Lab_TestID, T000G6_n102BR_Lab_TestID, T000G6_A103BR_Lab_TestCode, T000G6_n103BR_Lab_TestCode, T000G6_A104BR_Lab_TestName, T000G6_n104BR_Lab_TestName, T000G6_A261BR_Lab_TestEngName,
               T000G6_n261BR_Lab_TestEngName, T000G6_A262BR_Lab_Age, T000G6_n262BR_Lab_Age, T000G6_A263BR_Lab_Diag, T000G6_n263BR_Lab_Diag, T000G6_A105BR_Lab_SpecimenDate, T000G6_n105BR_Lab_SpecimenDate, T000G6_A264BR_Lab_ReceivingTime, T000G6_n264BR_Lab_ReceivingTime, T000G6_A265BR_Lab_ReportTime,
               T000G6_n265BR_Lab_ReportTime, T000G6_A106BR_Lab_SpecimenSource, T000G6_n106BR_Lab_SpecimenSource, T000G6_A109BR_Lab_ResultQual, T000G6_n109BR_Lab_ResultQual, T000G6_A110BR_Lab_ResultNum, T000G6_n110BR_Lab_ResultNum, T000G6_A111BR_Lab_ResultUnit, T000G6_n111BR_Lab_ResultUnit, T000G6_A112BR_Lab_AbnInd,
               T000G6_n112BR_Lab_AbnInd, T000G6_A113BR_Lab_NormRangeLow, T000G6_n113BR_Lab_NormRangeLow, T000G6_A114BR_Lab_NormRangeHigh, T000G6_n114BR_Lab_NormRangeHigh, T000G6_A115BR_Lab_TestMethod, T000G6_n115BR_Lab_TestMethod, T000G6_A117BR_Lab_InstrumentName, T000G6_n117BR_Lab_InstrumentName, T000G6_A118BR_Lab_InstrumentCode,
               T000G6_n118BR_Lab_InstrumentCode, T000G6_A430BR_SampleId, T000G6_n430BR_SampleId, T000G6_A19BR_EncounterID
               }
               , new Object[] {
               T000G7_A85BR_Information_ID, T000G7_n85BR_Information_ID
               }
               , new Object[] {
               T000G8_A36BR_Information_PatientNo, T000G8_n36BR_Information_PatientNo
               }
               , new Object[] {
               T000G9_A101BR_LabID
               }
               , new Object[] {
               T000G10_A101BR_LabID
               }
               , new Object[] {
               T000G11_A101BR_LabID
               }
               , new Object[] {
               T000G12_A101BR_LabID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000G15_A85BR_Information_ID, T000G15_n85BR_Information_ID
               }
               , new Object[] {
               T000G16_A36BR_Information_PatientNo, T000G16_n36BR_Information_PatientNo
               }
               , new Object[] {
               T000G17_A101BR_LabID
               }
               , new Object[] {
               T000G18_A167XT_DefineCodeID, T000G18_A168XT_DefineCodeName, T000G18_n168XT_DefineCodeName, T000G18_A165XT_DefindcodeTypeID, T000G18_A432XT_TenantCode, T000G18_n432XT_TenantCode
               }
               , new Object[] {
               T000G19_A167XT_DefineCodeID, T000G19_A168XT_DefineCodeName, T000G19_n168XT_DefineCodeName, T000G19_A165XT_DefindcodeTypeID, T000G19_A432XT_TenantCode, T000G19_n432XT_TenantCode
               }
               , new Object[] {
               T000G20_A167XT_DefineCodeID, T000G20_A168XT_DefineCodeName, T000G20_n168XT_DefineCodeName, T000G20_A165XT_DefindcodeTypeID, T000G20_A432XT_TenantCode, T000G20_n432XT_TenantCode
               }
               , new Object[] {
               T000G21_A85BR_Information_ID, T000G21_n85BR_Information_ID
               }
               , new Object[] {
               T000G22_A36BR_Information_PatientNo, T000G22_n36BR_Information_PatientNo
               }
            }
         );
         AV17Pgmname = "BR_Lab";
      }

      private short Z262BR_Lab_Age ;
      private short GxWebError ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A262BR_Lab_Age ;
      private short RcdFound17 ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int trnEnded ;
      private int edtBR_Lab_TestName_Enabled ;
      private int edtBR_Lab_TestEngName_Enabled ;
      private int edtBR_Lab_TestCode_Enabled ;
      private int edtBR_Lab_Age_Enabled ;
      private int edtBR_Lab_Diag_Enabled ;
      private int edtBR_Lab_SpecimenDate_Enabled ;
      private int edtBR_Lab_ReceivingTime_Enabled ;
      private int edtBR_Lab_ReportTime_Enabled ;
      private int edtBR_Lab_ResultUnit_Enabled ;
      private int edtBR_Lab_NormRangeLow_Enabled ;
      private int edtBR_Lab_TestMethod_Enabled ;
      private int edtBR_Lab_InstrumentCode_Enabled ;
      private int edtBR_Lab_InstrumentName_Enabled ;
      private int edtBR_Lab_ResultNum_Enabled ;
      private int bttBtntrn_enter_Visible ;
      private int bttBtntrn_enter_Enabled ;
      private int bttBtntrn_cancel_Visible ;
      private int bttBtntrn_delete_Visible ;
      private int bttBtntrn_delete_Enabled ;
      private int edtBR_LabID_Enabled ;
      private int edtBR_LabID_Visible ;
      private int edtBR_EncounterID_Visible ;
      private int edtBR_EncounterID_Enabled ;
      private int edtBR_Information_PatientNo_Visible ;
      private int edtBR_Information_PatientNo_Enabled ;
      private int edtBR_Lab_TestID_Enabled ;
      private int edtBR_Lab_TestID_Visible ;
      private int edtBR_Lab_NormRangeHigh_Visible ;
      private int edtBR_Lab_NormRangeHigh_Enabled ;
      private int edtavVsource_Visible ;
      private int edtavVsource_Enabled ;
      private int AV18GXV1 ;
      private int idxLst ;
      private int gxdynajaxindex ;
      private long wcpOAV12BR_LabID ;
      private long Z101BR_LabID ;
      private long Z102BR_Lab_TestID ;
      private long Z430BR_SampleId ;
      private long Z19BR_EncounterID ;
      private long N19BR_EncounterID ;
      private long A19BR_EncounterID ;
      private long A85BR_Information_ID ;
      private long AV12BR_LabID ;
      private long A101BR_LabID ;
      private long A102BR_Lab_TestID ;
      private long A430BR_SampleId ;
      private long AV10Insert_BR_EncounterID ;
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
      private String edtBR_Lab_TestName_Internalname ;
      private String dynBR_Lab_SpecimenSource_Internalname ;
      private String dynBR_Lab_ResultQual_Internalname ;
      private String dynBR_Lab_AbnInd_Internalname ;
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
      private String divUnnamedtablebr_lab_testname_Internalname ;
      private String lblTextblockbr_lab_testname_Internalname ;
      private String lblTextblockbr_lab_testname_Jsonclick ;
      private String TempTags ;
      private String edtBR_Lab_TestName_Jsonclick ;
      private String divUnnamedtablebr_lab_testengname_Internalname ;
      private String lblTextblockbr_lab_testengname_Internalname ;
      private String lblTextblockbr_lab_testengname_Jsonclick ;
      private String edtBR_Lab_TestEngName_Internalname ;
      private String edtBR_Lab_TestEngName_Jsonclick ;
      private String edtBR_Lab_TestCode_Internalname ;
      private String edtBR_Lab_TestCode_Jsonclick ;
      private String divUnnamedtablebr_lab_age_Internalname ;
      private String lblTextblockbr_lab_age_Internalname ;
      private String lblTextblockbr_lab_age_Jsonclick ;
      private String edtBR_Lab_Age_Internalname ;
      private String edtBR_Lab_Age_Jsonclick ;
      private String divUnnamedtablebr_lab_diag_Internalname ;
      private String lblTextblockbr_lab_diag_Internalname ;
      private String lblTextblockbr_lab_diag_Jsonclick ;
      private String edtBR_Lab_Diag_Internalname ;
      private String edtBR_Lab_Diag_Jsonclick ;
      private String divTablesplittedbr_lab_specimensource_Internalname ;
      private String lblTextblockbr_lab_specimensource_Internalname ;
      private String lblTextblockbr_lab_specimensource_Jsonclick ;
      private String divUnnamedtablebr_lab_specimendate_Internalname ;
      private String lblTextblockbr_lab_specimendate_Internalname ;
      private String lblTextblockbr_lab_specimendate_Jsonclick ;
      private String edtBR_Lab_SpecimenDate_Internalname ;
      private String edtBR_Lab_SpecimenDate_Jsonclick ;
      private String divUnnamedtablebr_lab_receivingtime_Internalname ;
      private String lblTextblockbr_lab_receivingtime_Internalname ;
      private String lblTextblockbr_lab_receivingtime_Jsonclick ;
      private String edtBR_Lab_ReceivingTime_Internalname ;
      private String edtBR_Lab_ReceivingTime_Jsonclick ;
      private String divUnnamedtablebr_lab_reporttime_Internalname ;
      private String lblTextblockbr_lab_reporttime_Internalname ;
      private String lblTextblockbr_lab_reporttime_Jsonclick ;
      private String edtBR_Lab_ReportTime_Internalname ;
      private String edtBR_Lab_ReportTime_Jsonclick ;
      private String divUnnamedtablebr_lab_resultqual_Internalname ;
      private String lblTextblockbr_lab_resultqual_Internalname ;
      private String lblTextblockbr_lab_resultqual_Jsonclick ;
      private String dynBR_Lab_ResultQual_Jsonclick ;
      private String divUnnamedtablebr_lab_resultunit_Internalname ;
      private String lblTextblockbr_lab_resultunit_Internalname ;
      private String lblTextblockbr_lab_resultunit_Jsonclick ;
      private String edtBR_Lab_ResultUnit_Internalname ;
      private String edtBR_Lab_ResultUnit_Jsonclick ;
      private String divUnnamedtablebr_lab_abnind_Internalname ;
      private String lblTextblockbr_lab_abnind_Internalname ;
      private String lblTextblockbr_lab_abnind_Jsonclick ;
      private String dynBR_Lab_AbnInd_Jsonclick ;
      private String divUnnamedtablebr_lab_normrangelow_Internalname ;
      private String lblTextblockbr_lab_normrangelow_Internalname ;
      private String lblTextblockbr_lab_normrangelow_Jsonclick ;
      private String edtBR_Lab_NormRangeLow_Internalname ;
      private String edtBR_Lab_NormRangeLow_Jsonclick ;
      private String divUnnamedtablebr_lab_testmethod_Internalname ;
      private String lblTextblockbr_lab_testmethod_Internalname ;
      private String lblTextblockbr_lab_testmethod_Jsonclick ;
      private String edtBR_Lab_TestMethod_Internalname ;
      private String edtBR_Lab_TestMethod_Jsonclick ;
      private String divUnnamedtablebr_lab_instrumentcode_Internalname ;
      private String lblTextblockbr_lab_instrumentcode_Internalname ;
      private String lblTextblockbr_lab_instrumentcode_Jsonclick ;
      private String edtBR_Lab_InstrumentCode_Internalname ;
      private String edtBR_Lab_InstrumentCode_Jsonclick ;
      private String divUnnamedtablebr_lab_instrumentname_Internalname ;
      private String lblTextblockbr_lab_instrumentname_Internalname ;
      private String lblTextblockbr_lab_instrumentname_Jsonclick ;
      private String edtBR_Lab_InstrumentName_Internalname ;
      private String divUnnamedtablebr_lab_resultnum_Internalname ;
      private String lblTextblockbr_lab_resultnum_Internalname ;
      private String lblTextblockbr_lab_resultnum_Jsonclick ;
      private String edtBR_Lab_ResultNum_Internalname ;
      private String bttBtntrn_enter_Internalname ;
      private String bttBtntrn_enter_Jsonclick ;
      private String bttBtntrn_cancel_Internalname ;
      private String bttBtntrn_cancel_Jsonclick ;
      private String bttBtntrn_delete_Internalname ;
      private String bttBtntrn_delete_Jsonclick ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String edtBR_LabID_Internalname ;
      private String edtBR_LabID_Jsonclick ;
      private String edtBR_EncounterID_Internalname ;
      private String edtBR_EncounterID_Jsonclick ;
      private String edtBR_Information_PatientNo_Internalname ;
      private String edtBR_Information_PatientNo_Jsonclick ;
      private String edtBR_Lab_TestID_Internalname ;
      private String edtBR_Lab_TestID_Jsonclick ;
      private String edtBR_Lab_NormRangeHigh_Internalname ;
      private String edtBR_Lab_NormRangeHigh_Jsonclick ;
      private String sStyleString ;
      private String tblTablemergedbr_lab_specimensource_Internalname ;
      private String dynBR_Lab_SpecimenSource_Jsonclick ;
      private String cellVsource_cell_Internalname ;
      private String cellVsource_cell_Class ;
      private String edtavVsource_Internalname ;
      private String edtavVsource_Jsonclick ;
      private String AV17Pgmname ;
      private String Dvpanel_tableattributes_Objectcall ;
      private String Dvpanel_tableattributes_Class ;
      private String Dvpanel_tableattributes_Height ;
      private String forbiddenHiddens ;
      private String hsh ;
      private String sMode17 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String gxwrpcisep ;
      private String GXt_char1 ;
      private DateTime Z105BR_Lab_SpecimenDate ;
      private DateTime Z264BR_Lab_ReceivingTime ;
      private DateTime Z265BR_Lab_ReportTime ;
      private DateTime A105BR_Lab_SpecimenDate ;
      private DateTime A264BR_Lab_ReceivingTime ;
      private DateTime A265BR_Lab_ReportTime ;
      private bool entryPointCalled ;
      private bool n106BR_Lab_SpecimenSource ;
      private bool n109BR_Lab_ResultQual ;
      private bool n112BR_Lab_AbnInd ;
      private bool n85BR_Information_ID ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool Dvpanel_tableattributes_Autowidth ;
      private bool Dvpanel_tableattributes_Autoheight ;
      private bool Dvpanel_tableattributes_Collapsible ;
      private bool Dvpanel_tableattributes_Collapsed ;
      private bool Dvpanel_tableattributes_Showcollapseicon ;
      private bool Dvpanel_tableattributes_Autoscroll ;
      private bool n104BR_Lab_TestName ;
      private bool n261BR_Lab_TestEngName ;
      private bool n103BR_Lab_TestCode ;
      private bool n262BR_Lab_Age ;
      private bool n263BR_Lab_Diag ;
      private bool n105BR_Lab_SpecimenDate ;
      private bool n264BR_Lab_ReceivingTime ;
      private bool n265BR_Lab_ReportTime ;
      private bool n111BR_Lab_ResultUnit ;
      private bool n113BR_Lab_NormRangeLow ;
      private bool n115BR_Lab_TestMethod ;
      private bool n118BR_Lab_InstrumentCode ;
      private bool n117BR_Lab_InstrumentName ;
      private bool n110BR_Lab_ResultNum ;
      private bool n36BR_Information_PatientNo ;
      private bool n102BR_Lab_TestID ;
      private bool n114BR_Lab_NormRangeHigh ;
      private bool n474BR_Lab_SpecimenSource_Code ;
      private bool n475BR_Lab_ResultQual_Code ;
      private bool n476BR_Lab_AbnInd_Code ;
      private bool n224BR_Lab_SampleID ;
      private bool n430BR_SampleId ;
      private bool Dvpanel_tableattributes_Enabled ;
      private bool Dvpanel_tableattributes_Showheader ;
      private bool Dvpanel_tableattributes_Visible ;
      private bool AV13IsAuthorized ;
      private bool GXt_boolean2 ;
      private bool returnInSub ;
      private bool Gx_longc ;
      private bool gxdyncontrolsrefreshing ;
      private String Z474BR_Lab_SpecimenSource_Code ;
      private String Z475BR_Lab_ResultQual_Code ;
      private String Z476BR_Lab_AbnInd_Code ;
      private String Z224BR_Lab_SampleID ;
      private String Z103BR_Lab_TestCode ;
      private String Z104BR_Lab_TestName ;
      private String Z261BR_Lab_TestEngName ;
      private String Z263BR_Lab_Diag ;
      private String Z106BR_Lab_SpecimenSource ;
      private String Z109BR_Lab_ResultQual ;
      private String Z110BR_Lab_ResultNum ;
      private String Z111BR_Lab_ResultUnit ;
      private String Z112BR_Lab_AbnInd ;
      private String Z113BR_Lab_NormRangeLow ;
      private String Z114BR_Lab_NormRangeHigh ;
      private String Z115BR_Lab_TestMethod ;
      private String Z117BR_Lab_InstrumentName ;
      private String Z118BR_Lab_InstrumentCode ;
      private String AV16tCurrentCode ;
      private String A106BR_Lab_SpecimenSource ;
      private String A109BR_Lab_ResultQual ;
      private String A112BR_Lab_AbnInd ;
      private String A104BR_Lab_TestName ;
      private String A261BR_Lab_TestEngName ;
      private String A103BR_Lab_TestCode ;
      private String A263BR_Lab_Diag ;
      private String A111BR_Lab_ResultUnit ;
      private String A113BR_Lab_NormRangeLow ;
      private String A115BR_Lab_TestMethod ;
      private String A118BR_Lab_InstrumentCode ;
      private String A117BR_Lab_InstrumentName ;
      private String A110BR_Lab_ResultNum ;
      private String A36BR_Information_PatientNo ;
      private String A114BR_Lab_NormRangeHigh ;
      private String AV15vSource ;
      private String A474BR_Lab_SpecimenSource_Code ;
      private String A475BR_Lab_ResultQual_Code ;
      private String A476BR_Lab_AbnInd_Code ;
      private String A224BR_Lab_SampleID ;
      private String Z36BR_Information_PatientNo ;
      private IGxSession AV9WebSession ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrlcodr ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrldescr ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXUserControl ucDvpanel_tableattributes ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private GXCombobox dynBR_Lab_SpecimenSource ;
      private GXCombobox dynBR_Lab_ResultQual ;
      private GXCombobox dynBR_Lab_AbnInd ;
      private IDataStoreProvider pr_default ;
      private long[] T000G4_A85BR_Information_ID ;
      private bool[] T000G4_n85BR_Information_ID ;
      private String[] T000G5_A36BR_Information_PatientNo ;
      private bool[] T000G5_n36BR_Information_PatientNo ;
      private long[] T000G6_A85BR_Information_ID ;
      private bool[] T000G6_n85BR_Information_ID ;
      private long[] T000G6_A101BR_LabID ;
      private String[] T000G6_A474BR_Lab_SpecimenSource_Code ;
      private bool[] T000G6_n474BR_Lab_SpecimenSource_Code ;
      private String[] T000G6_A475BR_Lab_ResultQual_Code ;
      private bool[] T000G6_n475BR_Lab_ResultQual_Code ;
      private String[] T000G6_A476BR_Lab_AbnInd_Code ;
      private bool[] T000G6_n476BR_Lab_AbnInd_Code ;
      private String[] T000G6_A36BR_Information_PatientNo ;
      private bool[] T000G6_n36BR_Information_PatientNo ;
      private String[] T000G6_A224BR_Lab_SampleID ;
      private bool[] T000G6_n224BR_Lab_SampleID ;
      private long[] T000G6_A102BR_Lab_TestID ;
      private bool[] T000G6_n102BR_Lab_TestID ;
      private String[] T000G6_A103BR_Lab_TestCode ;
      private bool[] T000G6_n103BR_Lab_TestCode ;
      private String[] T000G6_A104BR_Lab_TestName ;
      private bool[] T000G6_n104BR_Lab_TestName ;
      private String[] T000G6_A261BR_Lab_TestEngName ;
      private bool[] T000G6_n261BR_Lab_TestEngName ;
      private short[] T000G6_A262BR_Lab_Age ;
      private bool[] T000G6_n262BR_Lab_Age ;
      private String[] T000G6_A263BR_Lab_Diag ;
      private bool[] T000G6_n263BR_Lab_Diag ;
      private DateTime[] T000G6_A105BR_Lab_SpecimenDate ;
      private bool[] T000G6_n105BR_Lab_SpecimenDate ;
      private DateTime[] T000G6_A264BR_Lab_ReceivingTime ;
      private bool[] T000G6_n264BR_Lab_ReceivingTime ;
      private DateTime[] T000G6_A265BR_Lab_ReportTime ;
      private bool[] T000G6_n265BR_Lab_ReportTime ;
      private String[] T000G6_A106BR_Lab_SpecimenSource ;
      private bool[] T000G6_n106BR_Lab_SpecimenSource ;
      private String[] T000G6_A109BR_Lab_ResultQual ;
      private bool[] T000G6_n109BR_Lab_ResultQual ;
      private String[] T000G6_A110BR_Lab_ResultNum ;
      private bool[] T000G6_n110BR_Lab_ResultNum ;
      private String[] T000G6_A111BR_Lab_ResultUnit ;
      private bool[] T000G6_n111BR_Lab_ResultUnit ;
      private String[] T000G6_A112BR_Lab_AbnInd ;
      private bool[] T000G6_n112BR_Lab_AbnInd ;
      private String[] T000G6_A113BR_Lab_NormRangeLow ;
      private bool[] T000G6_n113BR_Lab_NormRangeLow ;
      private String[] T000G6_A114BR_Lab_NormRangeHigh ;
      private bool[] T000G6_n114BR_Lab_NormRangeHigh ;
      private String[] T000G6_A115BR_Lab_TestMethod ;
      private bool[] T000G6_n115BR_Lab_TestMethod ;
      private String[] T000G6_A117BR_Lab_InstrumentName ;
      private bool[] T000G6_n117BR_Lab_InstrumentName ;
      private String[] T000G6_A118BR_Lab_InstrumentCode ;
      private bool[] T000G6_n118BR_Lab_InstrumentCode ;
      private long[] T000G6_A430BR_SampleId ;
      private bool[] T000G6_n430BR_SampleId ;
      private long[] T000G6_A19BR_EncounterID ;
      private long[] T000G7_A85BR_Information_ID ;
      private bool[] T000G7_n85BR_Information_ID ;
      private String[] T000G8_A36BR_Information_PatientNo ;
      private bool[] T000G8_n36BR_Information_PatientNo ;
      private long[] T000G9_A101BR_LabID ;
      private long[] T000G3_A101BR_LabID ;
      private String[] T000G3_A474BR_Lab_SpecimenSource_Code ;
      private bool[] T000G3_n474BR_Lab_SpecimenSource_Code ;
      private String[] T000G3_A475BR_Lab_ResultQual_Code ;
      private bool[] T000G3_n475BR_Lab_ResultQual_Code ;
      private String[] T000G3_A476BR_Lab_AbnInd_Code ;
      private bool[] T000G3_n476BR_Lab_AbnInd_Code ;
      private String[] T000G3_A224BR_Lab_SampleID ;
      private bool[] T000G3_n224BR_Lab_SampleID ;
      private long[] T000G3_A102BR_Lab_TestID ;
      private bool[] T000G3_n102BR_Lab_TestID ;
      private String[] T000G3_A103BR_Lab_TestCode ;
      private bool[] T000G3_n103BR_Lab_TestCode ;
      private String[] T000G3_A104BR_Lab_TestName ;
      private bool[] T000G3_n104BR_Lab_TestName ;
      private String[] T000G3_A261BR_Lab_TestEngName ;
      private bool[] T000G3_n261BR_Lab_TestEngName ;
      private short[] T000G3_A262BR_Lab_Age ;
      private bool[] T000G3_n262BR_Lab_Age ;
      private String[] T000G3_A263BR_Lab_Diag ;
      private bool[] T000G3_n263BR_Lab_Diag ;
      private DateTime[] T000G3_A105BR_Lab_SpecimenDate ;
      private bool[] T000G3_n105BR_Lab_SpecimenDate ;
      private DateTime[] T000G3_A264BR_Lab_ReceivingTime ;
      private bool[] T000G3_n264BR_Lab_ReceivingTime ;
      private DateTime[] T000G3_A265BR_Lab_ReportTime ;
      private bool[] T000G3_n265BR_Lab_ReportTime ;
      private String[] T000G3_A106BR_Lab_SpecimenSource ;
      private bool[] T000G3_n106BR_Lab_SpecimenSource ;
      private String[] T000G3_A109BR_Lab_ResultQual ;
      private bool[] T000G3_n109BR_Lab_ResultQual ;
      private String[] T000G3_A110BR_Lab_ResultNum ;
      private bool[] T000G3_n110BR_Lab_ResultNum ;
      private String[] T000G3_A111BR_Lab_ResultUnit ;
      private bool[] T000G3_n111BR_Lab_ResultUnit ;
      private String[] T000G3_A112BR_Lab_AbnInd ;
      private bool[] T000G3_n112BR_Lab_AbnInd ;
      private String[] T000G3_A113BR_Lab_NormRangeLow ;
      private bool[] T000G3_n113BR_Lab_NormRangeLow ;
      private String[] T000G3_A114BR_Lab_NormRangeHigh ;
      private bool[] T000G3_n114BR_Lab_NormRangeHigh ;
      private String[] T000G3_A115BR_Lab_TestMethod ;
      private bool[] T000G3_n115BR_Lab_TestMethod ;
      private String[] T000G3_A117BR_Lab_InstrumentName ;
      private bool[] T000G3_n117BR_Lab_InstrumentName ;
      private String[] T000G3_A118BR_Lab_InstrumentCode ;
      private bool[] T000G3_n118BR_Lab_InstrumentCode ;
      private long[] T000G3_A430BR_SampleId ;
      private bool[] T000G3_n430BR_SampleId ;
      private long[] T000G3_A19BR_EncounterID ;
      private long[] T000G10_A101BR_LabID ;
      private long[] T000G11_A101BR_LabID ;
      private long[] T000G2_A101BR_LabID ;
      private String[] T000G2_A474BR_Lab_SpecimenSource_Code ;
      private bool[] T000G2_n474BR_Lab_SpecimenSource_Code ;
      private String[] T000G2_A475BR_Lab_ResultQual_Code ;
      private bool[] T000G2_n475BR_Lab_ResultQual_Code ;
      private String[] T000G2_A476BR_Lab_AbnInd_Code ;
      private bool[] T000G2_n476BR_Lab_AbnInd_Code ;
      private String[] T000G2_A224BR_Lab_SampleID ;
      private bool[] T000G2_n224BR_Lab_SampleID ;
      private long[] T000G2_A102BR_Lab_TestID ;
      private bool[] T000G2_n102BR_Lab_TestID ;
      private String[] T000G2_A103BR_Lab_TestCode ;
      private bool[] T000G2_n103BR_Lab_TestCode ;
      private String[] T000G2_A104BR_Lab_TestName ;
      private bool[] T000G2_n104BR_Lab_TestName ;
      private String[] T000G2_A261BR_Lab_TestEngName ;
      private bool[] T000G2_n261BR_Lab_TestEngName ;
      private short[] T000G2_A262BR_Lab_Age ;
      private bool[] T000G2_n262BR_Lab_Age ;
      private String[] T000G2_A263BR_Lab_Diag ;
      private bool[] T000G2_n263BR_Lab_Diag ;
      private DateTime[] T000G2_A105BR_Lab_SpecimenDate ;
      private bool[] T000G2_n105BR_Lab_SpecimenDate ;
      private DateTime[] T000G2_A264BR_Lab_ReceivingTime ;
      private bool[] T000G2_n264BR_Lab_ReceivingTime ;
      private DateTime[] T000G2_A265BR_Lab_ReportTime ;
      private bool[] T000G2_n265BR_Lab_ReportTime ;
      private String[] T000G2_A106BR_Lab_SpecimenSource ;
      private bool[] T000G2_n106BR_Lab_SpecimenSource ;
      private String[] T000G2_A109BR_Lab_ResultQual ;
      private bool[] T000G2_n109BR_Lab_ResultQual ;
      private String[] T000G2_A110BR_Lab_ResultNum ;
      private bool[] T000G2_n110BR_Lab_ResultNum ;
      private String[] T000G2_A111BR_Lab_ResultUnit ;
      private bool[] T000G2_n111BR_Lab_ResultUnit ;
      private String[] T000G2_A112BR_Lab_AbnInd ;
      private bool[] T000G2_n112BR_Lab_AbnInd ;
      private String[] T000G2_A113BR_Lab_NormRangeLow ;
      private bool[] T000G2_n113BR_Lab_NormRangeLow ;
      private String[] T000G2_A114BR_Lab_NormRangeHigh ;
      private bool[] T000G2_n114BR_Lab_NormRangeHigh ;
      private String[] T000G2_A115BR_Lab_TestMethod ;
      private bool[] T000G2_n115BR_Lab_TestMethod ;
      private String[] T000G2_A117BR_Lab_InstrumentName ;
      private bool[] T000G2_n117BR_Lab_InstrumentName ;
      private String[] T000G2_A118BR_Lab_InstrumentCode ;
      private bool[] T000G2_n118BR_Lab_InstrumentCode ;
      private long[] T000G2_A430BR_SampleId ;
      private bool[] T000G2_n430BR_SampleId ;
      private long[] T000G2_A19BR_EncounterID ;
      private long[] T000G12_A101BR_LabID ;
      private long[] T000G15_A85BR_Information_ID ;
      private bool[] T000G15_n85BR_Information_ID ;
      private String[] T000G16_A36BR_Information_PatientNo ;
      private bool[] T000G16_n36BR_Information_PatientNo ;
      private long[] T000G17_A101BR_LabID ;
      private long[] T000G18_A167XT_DefineCodeID ;
      private String[] T000G18_A168XT_DefineCodeName ;
      private bool[] T000G18_n168XT_DefineCodeName ;
      private long[] T000G18_A165XT_DefindcodeTypeID ;
      private String[] T000G18_A432XT_TenantCode ;
      private bool[] T000G18_n432XT_TenantCode ;
      private long[] T000G19_A167XT_DefineCodeID ;
      private String[] T000G19_A168XT_DefineCodeName ;
      private bool[] T000G19_n168XT_DefineCodeName ;
      private long[] T000G19_A165XT_DefindcodeTypeID ;
      private String[] T000G19_A432XT_TenantCode ;
      private bool[] T000G19_n432XT_TenantCode ;
      private long[] T000G20_A167XT_DefineCodeID ;
      private String[] T000G20_A168XT_DefineCodeName ;
      private bool[] T000G20_n168XT_DefineCodeName ;
      private long[] T000G20_A165XT_DefindcodeTypeID ;
      private String[] T000G20_A432XT_TenantCode ;
      private bool[] T000G20_n432XT_TenantCode ;
      private long[] T000G21_A85BR_Information_ID ;
      private bool[] T000G21_n85BR_Information_ID ;
      private String[] T000G22_A36BR_Information_PatientNo ;
      private bool[] T000G22_n36BR_Information_PatientNo ;
      private IDataStoreProvider pr_datastore1 ;
      private GXWebForm Form ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV7WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV8TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute AV11TrnContextAtt ;
   }

   public class br_lab__datastore1 : DataStoreHelperBase, IDataStoreHelper
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

 public class br_lab__default : DataStoreHelperBase, IDataStoreHelper
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
     };
  }

  private static CursorDef[] def;
  private void cursorDefinitions( )
  {
     if ( def == null )
     {
        Object[] prmT000G6 ;
        prmT000G6 = new Object[] {
        new Object[] {"@BR_LabID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000G4 ;
        prmT000G4 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000G5 ;
        prmT000G5 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000G7 ;
        prmT000G7 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000G8 ;
        prmT000G8 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000G9 ;
        prmT000G9 = new Object[] {
        new Object[] {"@BR_LabID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000G3 ;
        prmT000G3 = new Object[] {
        new Object[] {"@BR_LabID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000G10 ;
        prmT000G10 = new Object[] {
        new Object[] {"@BR_LabID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000G11 ;
        prmT000G11 = new Object[] {
        new Object[] {"@BR_LabID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000G2 ;
        prmT000G2 = new Object[] {
        new Object[] {"@BR_LabID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000G12 ;
        prmT000G12 = new Object[] {
        new Object[] {"@BR_Lab_SpecimenSource_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Lab_ResultQual_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Lab_AbnInd_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Lab_SampleID",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Lab_TestID",SqlDbType.Decimal,10,0} ,
        new Object[] {"@BR_Lab_TestCode",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Lab_TestName",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Lab_TestEngName",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Lab_Age",SqlDbType.SmallInt,3,0} ,
        new Object[] {"@BR_Lab_Diag",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Lab_SpecimenDate",SqlDbType.DateTime,10,8} ,
        new Object[] {"@BR_Lab_ReceivingTime",SqlDbType.DateTime,10,8} ,
        new Object[] {"@BR_Lab_ReportTime",SqlDbType.DateTime,10,8} ,
        new Object[] {"@BR_Lab_SpecimenSource",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Lab_ResultQual",SqlDbType.NVarChar,500,0} ,
        new Object[] {"@BR_Lab_ResultNum",SqlDbType.NVarChar,500,0} ,
        new Object[] {"@BR_Lab_ResultUnit",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Lab_AbnInd",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Lab_NormRangeLow",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Lab_NormRangeHigh",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Lab_TestMethod",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Lab_InstrumentName",SqlDbType.NVarChar,200,0} ,
        new Object[] {"@BR_Lab_InstrumentCode",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_SampleId",SqlDbType.Decimal,18,0} ,
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000G13 ;
        prmT000G13 = new Object[] {
        new Object[] {"@BR_Lab_SpecimenSource_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Lab_ResultQual_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Lab_AbnInd_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Lab_SampleID",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Lab_TestID",SqlDbType.Decimal,10,0} ,
        new Object[] {"@BR_Lab_TestCode",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Lab_TestName",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Lab_TestEngName",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Lab_Age",SqlDbType.SmallInt,3,0} ,
        new Object[] {"@BR_Lab_Diag",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Lab_SpecimenDate",SqlDbType.DateTime,10,8} ,
        new Object[] {"@BR_Lab_ReceivingTime",SqlDbType.DateTime,10,8} ,
        new Object[] {"@BR_Lab_ReportTime",SqlDbType.DateTime,10,8} ,
        new Object[] {"@BR_Lab_SpecimenSource",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Lab_ResultQual",SqlDbType.NVarChar,500,0} ,
        new Object[] {"@BR_Lab_ResultNum",SqlDbType.NVarChar,500,0} ,
        new Object[] {"@BR_Lab_ResultUnit",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Lab_AbnInd",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Lab_NormRangeLow",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Lab_NormRangeHigh",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Lab_TestMethod",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Lab_InstrumentName",SqlDbType.NVarChar,200,0} ,
        new Object[] {"@BR_Lab_InstrumentCode",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_SampleId",SqlDbType.Decimal,18,0} ,
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@BR_LabID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000G14 ;
        prmT000G14 = new Object[] {
        new Object[] {"@BR_LabID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000G15 ;
        prmT000G15 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000G16 ;
        prmT000G16 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000G17 ;
        prmT000G17 = new Object[] {
        } ;
        Object[] prmT000G18 ;
        prmT000G18 = new Object[] {
        new Object[] {"@AV16tCurrentCode",SqlDbType.NVarChar,40,0}
        } ;
        Object[] prmT000G19 ;
        prmT000G19 = new Object[] {
        new Object[] {"@AV16tCurrentCode",SqlDbType.NVarChar,40,0}
        } ;
        Object[] prmT000G20 ;
        prmT000G20 = new Object[] {
        new Object[] {"@AV16tCurrentCode",SqlDbType.NVarChar,40,0}
        } ;
        Object[] prmT000G21 ;
        prmT000G21 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000G22 ;
        prmT000G22 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("T000G2", "SELECT [BR_LabID], [BR_Lab_SpecimenSource_Code], [BR_Lab_ResultQual_Code], [BR_Lab_AbnInd_Code], [BR_Lab_SampleID], [BR_Lab_TestID], [BR_Lab_TestCode], [BR_Lab_TestName], [BR_Lab_TestEngName], [BR_Lab_Age], [BR_Lab_Diag], [BR_Lab_SpecimenDate], [BR_Lab_ReceivingTime], [BR_Lab_ReportTime], [BR_Lab_SpecimenSource], [BR_Lab_ResultQual], [BR_Lab_ResultNum], [BR_Lab_ResultUnit], [BR_Lab_AbnInd], [BR_Lab_NormRangeLow], [BR_Lab_NormRangeHigh], [BR_Lab_TestMethod], [BR_Lab_InstrumentName], [BR_Lab_InstrumentCode], [BR_SampleId], [BR_EncounterID] FROM [BR_Lab] WITH (UPDLOCK) WHERE [BR_LabID] = @BR_LabID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000G2,1,0,true,false )
           ,new CursorDef("T000G3", "SELECT [BR_LabID], [BR_Lab_SpecimenSource_Code], [BR_Lab_ResultQual_Code], [BR_Lab_AbnInd_Code], [BR_Lab_SampleID], [BR_Lab_TestID], [BR_Lab_TestCode], [BR_Lab_TestName], [BR_Lab_TestEngName], [BR_Lab_Age], [BR_Lab_Diag], [BR_Lab_SpecimenDate], [BR_Lab_ReceivingTime], [BR_Lab_ReportTime], [BR_Lab_SpecimenSource], [BR_Lab_ResultQual], [BR_Lab_ResultNum], [BR_Lab_ResultUnit], [BR_Lab_AbnInd], [BR_Lab_NormRangeLow], [BR_Lab_NormRangeHigh], [BR_Lab_TestMethod], [BR_Lab_InstrumentName], [BR_Lab_InstrumentCode], [BR_SampleId], [BR_EncounterID] FROM [BR_Lab] WITH (NOLOCK) WHERE [BR_LabID] = @BR_LabID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000G3,1,0,true,false )
           ,new CursorDef("T000G4", "SELECT [BR_Information_ID] FROM [BR_Encounter] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000G4,1,0,true,false )
           ,new CursorDef("T000G5", "SELECT [BR_Information_PatientNo] FROM [BR_Information] WITH (NOLOCK) WHERE [BR_Information_ID] = @BR_Information_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000G5,1,0,true,false )
           ,new CursorDef("T000G6", "SELECT T2.[BR_Information_ID], TM1.[BR_LabID], TM1.[BR_Lab_SpecimenSource_Code], TM1.[BR_Lab_ResultQual_Code], TM1.[BR_Lab_AbnInd_Code], T3.[BR_Information_PatientNo], TM1.[BR_Lab_SampleID], TM1.[BR_Lab_TestID], TM1.[BR_Lab_TestCode], TM1.[BR_Lab_TestName], TM1.[BR_Lab_TestEngName], TM1.[BR_Lab_Age], TM1.[BR_Lab_Diag], TM1.[BR_Lab_SpecimenDate], TM1.[BR_Lab_ReceivingTime], TM1.[BR_Lab_ReportTime], TM1.[BR_Lab_SpecimenSource], TM1.[BR_Lab_ResultQual], TM1.[BR_Lab_ResultNum], TM1.[BR_Lab_ResultUnit], TM1.[BR_Lab_AbnInd], TM1.[BR_Lab_NormRangeLow], TM1.[BR_Lab_NormRangeHigh], TM1.[BR_Lab_TestMethod], TM1.[BR_Lab_InstrumentName], TM1.[BR_Lab_InstrumentCode], TM1.[BR_SampleId], TM1.[BR_EncounterID] FROM (([BR_Lab] TM1 WITH (NOLOCK) INNER JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = TM1.[BR_EncounterID]) LEFT JOIN [BR_Information] T3 WITH (NOLOCK) ON T3.[BR_Information_ID] = T2.[BR_Information_ID]) WHERE TM1.[BR_LabID] = @BR_LabID ORDER BY TM1.[BR_LabID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000G6,100,0,true,false )
           ,new CursorDef("T000G7", "SELECT [BR_Information_ID] FROM [BR_Encounter] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000G7,1,0,true,false )
           ,new CursorDef("T000G8", "SELECT [BR_Information_PatientNo] FROM [BR_Information] WITH (NOLOCK) WHERE [BR_Information_ID] = @BR_Information_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000G8,1,0,true,false )
           ,new CursorDef("T000G9", "SELECT [BR_LabID] FROM [BR_Lab] WITH (NOLOCK) WHERE [BR_LabID] = @BR_LabID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000G9,1,0,true,false )
           ,new CursorDef("T000G10", "SELECT TOP 1 [BR_LabID] FROM [BR_Lab] WITH (NOLOCK) WHERE ( [BR_LabID] > @BR_LabID) ORDER BY [BR_LabID]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000G10,1,0,true,true )
           ,new CursorDef("T000G11", "SELECT TOP 1 [BR_LabID] FROM [BR_Lab] WITH (NOLOCK) WHERE ( [BR_LabID] < @BR_LabID) ORDER BY [BR_LabID] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000G11,1,0,true,true )
           ,new CursorDef("T000G12", "INSERT INTO [BR_Lab]([BR_Lab_SpecimenSource_Code], [BR_Lab_ResultQual_Code], [BR_Lab_AbnInd_Code], [BR_Lab_SampleID], [BR_Lab_TestID], [BR_Lab_TestCode], [BR_Lab_TestName], [BR_Lab_TestEngName], [BR_Lab_Age], [BR_Lab_Diag], [BR_Lab_SpecimenDate], [BR_Lab_ReceivingTime], [BR_Lab_ReportTime], [BR_Lab_SpecimenSource], [BR_Lab_ResultQual], [BR_Lab_ResultNum], [BR_Lab_ResultUnit], [BR_Lab_AbnInd], [BR_Lab_NormRangeLow], [BR_Lab_NormRangeHigh], [BR_Lab_TestMethod], [BR_Lab_InstrumentName], [BR_Lab_InstrumentCode], [BR_SampleId], [BR_EncounterID]) VALUES(@BR_Lab_SpecimenSource_Code, @BR_Lab_ResultQual_Code, @BR_Lab_AbnInd_Code, @BR_Lab_SampleID, @BR_Lab_TestID, @BR_Lab_TestCode, @BR_Lab_TestName, @BR_Lab_TestEngName, @BR_Lab_Age, @BR_Lab_Diag, @BR_Lab_SpecimenDate, @BR_Lab_ReceivingTime, @BR_Lab_ReportTime, @BR_Lab_SpecimenSource, @BR_Lab_ResultQual, @BR_Lab_ResultNum, @BR_Lab_ResultUnit, @BR_Lab_AbnInd, @BR_Lab_NormRangeLow, @BR_Lab_NormRangeHigh, @BR_Lab_TestMethod, @BR_Lab_InstrumentName, @BR_Lab_InstrumentCode, @BR_SampleId, @BR_EncounterID); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmT000G12)
           ,new CursorDef("T000G13", "UPDATE [BR_Lab] SET [BR_Lab_SpecimenSource_Code]=@BR_Lab_SpecimenSource_Code, [BR_Lab_ResultQual_Code]=@BR_Lab_ResultQual_Code, [BR_Lab_AbnInd_Code]=@BR_Lab_AbnInd_Code, [BR_Lab_SampleID]=@BR_Lab_SampleID, [BR_Lab_TestID]=@BR_Lab_TestID, [BR_Lab_TestCode]=@BR_Lab_TestCode, [BR_Lab_TestName]=@BR_Lab_TestName, [BR_Lab_TestEngName]=@BR_Lab_TestEngName, [BR_Lab_Age]=@BR_Lab_Age, [BR_Lab_Diag]=@BR_Lab_Diag, [BR_Lab_SpecimenDate]=@BR_Lab_SpecimenDate, [BR_Lab_ReceivingTime]=@BR_Lab_ReceivingTime, [BR_Lab_ReportTime]=@BR_Lab_ReportTime, [BR_Lab_SpecimenSource]=@BR_Lab_SpecimenSource, [BR_Lab_ResultQual]=@BR_Lab_ResultQual, [BR_Lab_ResultNum]=@BR_Lab_ResultNum, [BR_Lab_ResultUnit]=@BR_Lab_ResultUnit, [BR_Lab_AbnInd]=@BR_Lab_AbnInd, [BR_Lab_NormRangeLow]=@BR_Lab_NormRangeLow, [BR_Lab_NormRangeHigh]=@BR_Lab_NormRangeHigh, [BR_Lab_TestMethod]=@BR_Lab_TestMethod, [BR_Lab_InstrumentName]=@BR_Lab_InstrumentName, [BR_Lab_InstrumentCode]=@BR_Lab_InstrumentCode, [BR_SampleId]=@BR_SampleId, [BR_EncounterID]=@BR_EncounterID  WHERE [BR_LabID] = @BR_LabID", GxErrorMask.GX_NOMASK,prmT000G13)
           ,new CursorDef("T000G14", "DELETE FROM [BR_Lab]  WHERE [BR_LabID] = @BR_LabID", GxErrorMask.GX_NOMASK,prmT000G14)
           ,new CursorDef("T000G15", "SELECT [BR_Information_ID] FROM [BR_Encounter] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000G15,1,0,true,false )
           ,new CursorDef("T000G16", "SELECT [BR_Information_PatientNo] FROM [BR_Information] WITH (NOLOCK) WHERE [BR_Information_ID] = @BR_Information_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000G16,1,0,true,false )
           ,new CursorDef("T000G17", "SELECT [BR_LabID] FROM [BR_Lab] WITH (NOLOCK) ORDER BY [BR_LabID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000G17,100,0,true,false )
           ,new CursorDef("T000G18", "SELECT [XT_DefineCodeID], [XT_DefineCodeName], [XT_DefindcodeTypeID], [XT_TenantCode] FROM [XT_DefineCode] WITH (NOLOCK) WHERE ([XT_DefindcodeTypeID] = 22) AND ([XT_TenantCode] = @AV16tCurrentCode) ",true, GxErrorMask.GX_NOMASK, false, this,prmT000G18,0,0,true,false )
           ,new CursorDef("T000G19", "SELECT [XT_DefineCodeID], [XT_DefineCodeName], [XT_DefindcodeTypeID], [XT_TenantCode] FROM [XT_DefineCode] WITH (NOLOCK) WHERE ([XT_DefindcodeTypeID] = 23) AND ([XT_TenantCode] = @AV16tCurrentCode) ",true, GxErrorMask.GX_NOMASK, false, this,prmT000G19,0,0,true,false )
           ,new CursorDef("T000G20", "SELECT [XT_DefineCodeID], [XT_DefineCodeName], [XT_DefindcodeTypeID], [XT_TenantCode] FROM [XT_DefineCode] WITH (NOLOCK) WHERE ([XT_DefindcodeTypeID] = 24) AND ([XT_TenantCode] = @AV16tCurrentCode) ",true, GxErrorMask.GX_NOMASK, false, this,prmT000G20,0,0,true,false )
           ,new CursorDef("T000G21", "SELECT [BR_Information_ID] FROM [BR_Encounter] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000G21,1,0,true,false )
           ,new CursorDef("T000G22", "SELECT [BR_Information_PatientNo] FROM [BR_Information] WITH (NOLOCK) WHERE [BR_Information_ID] = @BR_Information_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000G22,1,0,true,false )
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
              ((long[]) buf[9])[0] = rslt.getLong(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              ((String[]) buf[13])[0] = rslt.getVarchar(8) ;
              ((bool[]) buf[14])[0] = rslt.wasNull(8);
              ((String[]) buf[15])[0] = rslt.getVarchar(9) ;
              ((bool[]) buf[16])[0] = rslt.wasNull(9);
              ((short[]) buf[17])[0] = rslt.getShort(10) ;
              ((bool[]) buf[18])[0] = rslt.wasNull(10);
              ((String[]) buf[19])[0] = rslt.getVarchar(11) ;
              ((bool[]) buf[20])[0] = rslt.wasNull(11);
              ((DateTime[]) buf[21])[0] = rslt.getGXDateTime(12) ;
              ((bool[]) buf[22])[0] = rslt.wasNull(12);
              ((DateTime[]) buf[23])[0] = rslt.getGXDateTime(13) ;
              ((bool[]) buf[24])[0] = rslt.wasNull(13);
              ((DateTime[]) buf[25])[0] = rslt.getGXDateTime(14) ;
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
              ((String[]) buf[39])[0] = rslt.getVarchar(21) ;
              ((bool[]) buf[40])[0] = rslt.wasNull(21);
              ((String[]) buf[41])[0] = rslt.getVarchar(22) ;
              ((bool[]) buf[42])[0] = rslt.wasNull(22);
              ((String[]) buf[43])[0] = rslt.getVarchar(23) ;
              ((bool[]) buf[44])[0] = rslt.wasNull(23);
              ((String[]) buf[45])[0] = rslt.getVarchar(24) ;
              ((bool[]) buf[46])[0] = rslt.wasNull(24);
              ((long[]) buf[47])[0] = rslt.getLong(25) ;
              ((bool[]) buf[48])[0] = rslt.wasNull(25);
              ((long[]) buf[49])[0] = rslt.getLong(26) ;
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
              ((long[]) buf[9])[0] = rslt.getLong(6) ;
              ((bool[]) buf[10])[0] = rslt.wasNull(6);
              ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              ((String[]) buf[13])[0] = rslt.getVarchar(8) ;
              ((bool[]) buf[14])[0] = rslt.wasNull(8);
              ((String[]) buf[15])[0] = rslt.getVarchar(9) ;
              ((bool[]) buf[16])[0] = rslt.wasNull(9);
              ((short[]) buf[17])[0] = rslt.getShort(10) ;
              ((bool[]) buf[18])[0] = rslt.wasNull(10);
              ((String[]) buf[19])[0] = rslt.getVarchar(11) ;
              ((bool[]) buf[20])[0] = rslt.wasNull(11);
              ((DateTime[]) buf[21])[0] = rslt.getGXDateTime(12) ;
              ((bool[]) buf[22])[0] = rslt.wasNull(12);
              ((DateTime[]) buf[23])[0] = rslt.getGXDateTime(13) ;
              ((bool[]) buf[24])[0] = rslt.wasNull(13);
              ((DateTime[]) buf[25])[0] = rslt.getGXDateTime(14) ;
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
              ((String[]) buf[39])[0] = rslt.getVarchar(21) ;
              ((bool[]) buf[40])[0] = rslt.wasNull(21);
              ((String[]) buf[41])[0] = rslt.getVarchar(22) ;
              ((bool[]) buf[42])[0] = rslt.wasNull(22);
              ((String[]) buf[43])[0] = rslt.getVarchar(23) ;
              ((bool[]) buf[44])[0] = rslt.wasNull(23);
              ((String[]) buf[45])[0] = rslt.getVarchar(24) ;
              ((bool[]) buf[46])[0] = rslt.wasNull(24);
              ((long[]) buf[47])[0] = rslt.getLong(25) ;
              ((bool[]) buf[48])[0] = rslt.wasNull(25);
              ((long[]) buf[49])[0] = rslt.getLong(26) ;
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
              ((long[]) buf[13])[0] = rslt.getLong(8) ;
              ((bool[]) buf[14])[0] = rslt.wasNull(8);
              ((String[]) buf[15])[0] = rslt.getVarchar(9) ;
              ((bool[]) buf[16])[0] = rslt.wasNull(9);
              ((String[]) buf[17])[0] = rslt.getVarchar(10) ;
              ((bool[]) buf[18])[0] = rslt.wasNull(10);
              ((String[]) buf[19])[0] = rslt.getVarchar(11) ;
              ((bool[]) buf[20])[0] = rslt.wasNull(11);
              ((short[]) buf[21])[0] = rslt.getShort(12) ;
              ((bool[]) buf[22])[0] = rslt.wasNull(12);
              ((String[]) buf[23])[0] = rslt.getVarchar(13) ;
              ((bool[]) buf[24])[0] = rslt.wasNull(13);
              ((DateTime[]) buf[25])[0] = rslt.getGXDateTime(14) ;
              ((bool[]) buf[26])[0] = rslt.wasNull(14);
              ((DateTime[]) buf[27])[0] = rslt.getGXDateTime(15) ;
              ((bool[]) buf[28])[0] = rslt.wasNull(15);
              ((DateTime[]) buf[29])[0] = rslt.getGXDateTime(16) ;
              ((bool[]) buf[30])[0] = rslt.wasNull(16);
              ((String[]) buf[31])[0] = rslt.getVarchar(17) ;
              ((bool[]) buf[32])[0] = rslt.wasNull(17);
              ((String[]) buf[33])[0] = rslt.getVarchar(18) ;
              ((bool[]) buf[34])[0] = rslt.wasNull(18);
              ((String[]) buf[35])[0] = rslt.getVarchar(19) ;
              ((bool[]) buf[36])[0] = rslt.wasNull(19);
              ((String[]) buf[37])[0] = rslt.getVarchar(20) ;
              ((bool[]) buf[38])[0] = rslt.wasNull(20);
              ((String[]) buf[39])[0] = rslt.getVarchar(21) ;
              ((bool[]) buf[40])[0] = rslt.wasNull(21);
              ((String[]) buf[41])[0] = rslt.getVarchar(22) ;
              ((bool[]) buf[42])[0] = rslt.wasNull(22);
              ((String[]) buf[43])[0] = rslt.getVarchar(23) ;
              ((bool[]) buf[44])[0] = rslt.wasNull(23);
              ((String[]) buf[45])[0] = rslt.getVarchar(24) ;
              ((bool[]) buf[46])[0] = rslt.wasNull(24);
              ((String[]) buf[47])[0] = rslt.getVarchar(25) ;
              ((bool[]) buf[48])[0] = rslt.wasNull(25);
              ((String[]) buf[49])[0] = rslt.getVarchar(26) ;
              ((bool[]) buf[50])[0] = rslt.wasNull(26);
              ((long[]) buf[51])[0] = rslt.getLong(27) ;
              ((bool[]) buf[52])[0] = rslt.wasNull(27);
              ((long[]) buf[53])[0] = rslt.getLong(28) ;
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
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((long[]) buf[3])[0] = rslt.getLong(3) ;
              ((String[]) buf[4])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[5])[0] = rslt.wasNull(4);
              return;
           case 19 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((bool[]) buf[1])[0] = rslt.wasNull(1);
              return;
           case 20 :
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
                 stmt.setNull( 5 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(5, (long)parms[9]);
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
                 stmt.setNull( 9 , SqlDbType.SmallInt );
              }
              else
              {
                 stmt.SetParameter(9, (short)parms[17]);
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
                 stmt.setNull( 11 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameterDatetime(11, (DateTime)parms[21]);
              }
              if ( (bool)parms[22] )
              {
                 stmt.setNull( 12 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameterDatetime(12, (DateTime)parms[23]);
              }
              if ( (bool)parms[24] )
              {
                 stmt.setNull( 13 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameterDatetime(13, (DateTime)parms[25]);
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
                 stmt.setNull( 18 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(18, (String)parms[35]);
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
              if ( (bool)parms[40] )
              {
                 stmt.setNull( 21 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(21, (String)parms[41]);
              }
              if ( (bool)parms[42] )
              {
                 stmt.setNull( 22 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(22, (String)parms[43]);
              }
              if ( (bool)parms[44] )
              {
                 stmt.setNull( 23 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(23, (String)parms[45]);
              }
              if ( (bool)parms[46] )
              {
                 stmt.setNull( 24 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(24, (long)parms[47]);
              }
              stmt.SetParameter(25, (long)parms[48]);
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
                 stmt.setNull( 5 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(5, (long)parms[9]);
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
                 stmt.setNull( 9 , SqlDbType.SmallInt );
              }
              else
              {
                 stmt.SetParameter(9, (short)parms[17]);
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
                 stmt.setNull( 11 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameterDatetime(11, (DateTime)parms[21]);
              }
              if ( (bool)parms[22] )
              {
                 stmt.setNull( 12 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameterDatetime(12, (DateTime)parms[23]);
              }
              if ( (bool)parms[24] )
              {
                 stmt.setNull( 13 , SqlDbType.DateTime );
              }
              else
              {
                 stmt.SetParameterDatetime(13, (DateTime)parms[25]);
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
                 stmt.setNull( 18 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(18, (String)parms[35]);
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
              if ( (bool)parms[40] )
              {
                 stmt.setNull( 21 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(21, (String)parms[41]);
              }
              if ( (bool)parms[42] )
              {
                 stmt.setNull( 22 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(22, (String)parms[43]);
              }
              if ( (bool)parms[44] )
              {
                 stmt.setNull( 23 , SqlDbType.NVarChar );
              }
              else
              {
                 stmt.SetParameter(23, (String)parms[45]);
              }
              if ( (bool)parms[46] )
              {
                 stmt.setNull( 24 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(24, (long)parms[47]);
              }
              stmt.SetParameter(25, (long)parms[48]);
              stmt.SetParameter(26, (long)parms[49]);
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
              stmt.SetParameter(1, (String)parms[0]);
              return;
           case 19 :
              stmt.SetParameter(1, (long)parms[0]);
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
     }
  }

}

}
