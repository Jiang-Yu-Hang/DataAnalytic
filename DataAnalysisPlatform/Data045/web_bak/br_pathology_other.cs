/*
               File: BR_Pathology_Other
        Description: Data Mgmt Portal - RAAP
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:38:10.25
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
   public class br_pathology_other : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxJX_Action23") == 0 )
         {
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            XC_23_0Y35( ) ;
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
            XC_24_0Y35( ) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxJX_Action25") == 0 )
         {
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            XC_25_0Y35( ) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"BR_PATHOLOGY_OTHER_BIO") == 0 )
         {
            AV19tCurrentCode = GetNextPar( );
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19tCurrentCode", AV19tCurrentCode);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GXDLABR_PATHOLOGY_OTHER_BIO0Y35( AV19tCurrentCode) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"BR_PATHOLOGY_OTHER_BIONUMUNIT") == 0 )
         {
            AV19tCurrentCode = GetNextPar( );
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19tCurrentCode", AV19tCurrentCode);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GXDLABR_PATHOLOGY_OTHER_BIONUMUNIT0Y35( AV19tCurrentCode) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"BR_PATHOLOGY_OTHER_BIOQUAL") == 0 )
         {
            AV19tCurrentCode = GetNextPar( );
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19tCurrentCode", AV19tCurrentCode);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GXDLABR_PATHOLOGY_OTHER_BIOQUAL0Y35( AV19tCurrentCode) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel11"+"_"+"BR_PATHOLOGY_OTHER_ABNIND_CODE") == 0 )
         {
            A295BR_Pathology_Other_AbnInd = GetNextPar( );
            n295BR_Pathology_Other_AbnInd = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295BR_Pathology_Other_AbnInd", A295BR_Pathology_Other_AbnInd);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX11ASABR_PATHOLOGY_OTHER_ABNIND_CODE0Y35( A295BR_Pathology_Other_AbnInd) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel12"+"_"+"BR_PATHOLOGY_OTHER_ABNIND_CODE") == 0 )
         {
            A295BR_Pathology_Other_AbnInd = GetNextPar( );
            n295BR_Pathology_Other_AbnInd = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295BR_Pathology_Other_AbnInd", A295BR_Pathology_Other_AbnInd);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX12ASABR_PATHOLOGY_OTHER_ABNIND_CODE0Y35( A295BR_Pathology_Other_AbnInd) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_27") == 0 )
         {
            A226BR_PathologyID = (long)(NumberUtil.Val( GetNextPar( ), "."));
            n226BR_PathologyID = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A226BR_PathologyID", StringUtil.LTrim( StringUtil.Str( (decimal)(A226BR_PathologyID), 18, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            gxLoad_27( A226BR_PathologyID) ;
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
               AV7BR_Pathology_OtherID = (long)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7BR_Pathology_OtherID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7BR_Pathology_OtherID), 18, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vBR_PATHOLOGY_OTHERID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7BR_Pathology_OtherID), "ZZZZZZZZZZZZZZZZZZ"), context));
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
         GX_FocusControl = dynBR_Pathology_Other_Bio_Internalname;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false;
         context.SetDefaultTheme("WorkWithPlusTheme");
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public br_pathology_other( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_pathology_other( IGxContext context )
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
                           long aP1_BR_Pathology_OtherID )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV7BR_Pathology_OtherID = aP1_BR_Pathology_OtherID;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         dynBR_Pathology_Other_Bio = new GXCombobox();
         dynBR_Pathology_Other_BioNumUnit = new GXCombobox();
         dynBR_Pathology_Other_BioQual = new GXCombobox();
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
         if ( dynBR_Pathology_Other_Bio.ItemCount > 0 )
         {
            A289BR_Pathology_Other_Bio = dynBR_Pathology_Other_Bio.getValidValue(A289BR_Pathology_Other_Bio);
            n289BR_Pathology_Other_Bio = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A289BR_Pathology_Other_Bio", A289BR_Pathology_Other_Bio);
         }
         if ( context.isAjaxRequest( ) )
         {
            dynBR_Pathology_Other_Bio.CurrentValue = StringUtil.RTrim( A289BR_Pathology_Other_Bio);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynBR_Pathology_Other_Bio_Internalname, "Values", dynBR_Pathology_Other_Bio.ToJavascriptSource(), true);
         }
         if ( dynBR_Pathology_Other_BioNumUnit.ItemCount > 0 )
         {
            A291BR_Pathology_Other_BioNumUnit = dynBR_Pathology_Other_BioNumUnit.getValidValue(A291BR_Pathology_Other_BioNumUnit);
            n291BR_Pathology_Other_BioNumUnit = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A291BR_Pathology_Other_BioNumUnit", A291BR_Pathology_Other_BioNumUnit);
         }
         if ( context.isAjaxRequest( ) )
         {
            dynBR_Pathology_Other_BioNumUnit.CurrentValue = StringUtil.RTrim( A291BR_Pathology_Other_BioNumUnit);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynBR_Pathology_Other_BioNumUnit_Internalname, "Values", dynBR_Pathology_Other_BioNumUnit.ToJavascriptSource(), true);
         }
         if ( dynBR_Pathology_Other_BioQual.ItemCount > 0 )
         {
            A292BR_Pathology_Other_BioQual = dynBR_Pathology_Other_BioQual.getValidValue(A292BR_Pathology_Other_BioQual);
            n292BR_Pathology_Other_BioQual = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A292BR_Pathology_Other_BioQual", A292BR_Pathology_Other_BioQual);
         }
         if ( context.isAjaxRequest( ) )
         {
            dynBR_Pathology_Other_BioQual.CurrentValue = StringUtil.RTrim( A292BR_Pathology_Other_BioQual);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynBR_Pathology_Other_BioQual_Internalname, "Values", dynBR_Pathology_Other_BioQual.ToJavascriptSource(), true);
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
            GxWebStd.gx_div_start( context, divTablesplittedbr_pathology_other_bio_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_pathology_other_bio_Internalname, "肿瘤标志物", "", "", lblTextblockbr_pathology_other_bio_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Pathology_Other.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            wb_table1_28_0Y35( true) ;
         }
         return  ;
      }

      protected void wb_table1_28_0Y35e( bool wbgen )
      {
         if ( wbgen )
         {
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_pathology_other_bionum_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_pathology_other_bionum_Internalname, "定量结果", "", "", lblTextblockbr_pathology_other_bionum_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Pathology_Other.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Pathology_Other_BioNum_Internalname, "定量结果", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_Pathology_Other_BioNum_Internalname, StringUtil.LTrim( StringUtil.NToC( A290BR_Pathology_Other_BioNum, 15, 5, ".", "")), ((edtBR_Pathology_Other_BioNum_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A290BR_Pathology_Other_BioNum, "ZZZZZZZZZ.ZZZZZ")) : context.localUtil.Format( A290BR_Pathology_Other_BioNum, "ZZZZZZZZZ.ZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, ',','.','5');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,43);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Pathology_Other_BioNum_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBR_Pathology_Other_BioNum_Enabled, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "DM_Numeric", "right", false, "HLP_BR_Pathology_Other.htm");
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
            GxWebStd.gx_div_start( context, divUnnamedtablebr_pathology_other_bionumunit_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-2 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_pathology_other_bionumunit_Internalname, "定量结果单位", "", "", lblTextblockbr_pathology_other_bionumunit_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Pathology_Other.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-10", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynBR_Pathology_Other_BioNumUnit_Internalname, "定量结果单位", "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 52,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynBR_Pathology_Other_BioNumUnit, dynBR_Pathology_Other_BioNumUnit_Internalname, StringUtil.RTrim( A291BR_Pathology_Other_BioNumUnit), 1, dynBR_Pathology_Other_BioNumUnit_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, dynBR_Pathology_Other_BioNumUnit.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,52);\"", "", true, "HLP_BR_Pathology_Other.htm");
            dynBR_Pathology_Other_BioNumUnit.CurrentValue = StringUtil.RTrim( A291BR_Pathology_Other_BioNumUnit);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynBR_Pathology_Other_BioNumUnit_Internalname, "Values", (String)(dynBR_Pathology_Other_BioNumUnit.ToJavascriptSource()), true);
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
            GxWebStd.gx_div_start( context, divUnnamedtablebr_pathology_other_low_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_pathology_other_low_Internalname, "参考上限", "", "", lblTextblockbr_pathology_other_low_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Pathology_Other.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Pathology_Other_Low_Internalname, "参考上限", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 61,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_Pathology_Other_Low_Internalname, StringUtil.LTrim( StringUtil.NToC( A293BR_Pathology_Other_Low, 15, 5, ".", "")), ((edtBR_Pathology_Other_Low_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A293BR_Pathology_Other_Low, "ZZZZZZZZZ.ZZZZZ")) : context.localUtil.Format( A293BR_Pathology_Other_Low, "ZZZZZZZZZ.ZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, ',','.','5');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,61);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Pathology_Other_Low_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBR_Pathology_Other_Low_Enabled, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "DM_Numeric", "right", false, "HLP_BR_Pathology_Other.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtablebr_pathology_other_high_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_pathology_other_high_Internalname, "参考下限", "", "", lblTextblockbr_pathology_other_high_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Pathology_Other.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-8", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Pathology_Other_High_Internalname, "参考下限", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 69,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_Pathology_Other_High_Internalname, StringUtil.LTrim( StringUtil.NToC( A294BR_Pathology_Other_High, 15, 5, ".", "")), ((edtBR_Pathology_Other_High_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( A294BR_Pathology_Other_High, "ZZZZZZZZZ.ZZZZZ")) : context.localUtil.Format( A294BR_Pathology_Other_High, "ZZZZZZZZZ.ZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, ',','.','5');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,69);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Pathology_Other_High_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBR_Pathology_Other_High_Enabled, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "DM_Numeric", "right", false, "HLP_BR_Pathology_Other.htm");
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
            GxWebStd.gx_div_start( context, divUnnamedtablebr_pathology_other_abnind_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-2 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_pathology_other_abnind_Internalname, "结果提示", "", "", lblTextblockbr_pathology_other_abnind_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Pathology_Other.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-10", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Pathology_Other_AbnInd_Internalname, "结果提示", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 78,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_Pathology_Other_AbnInd_Internalname, A295BR_Pathology_Other_AbnInd, StringUtil.RTrim( context.localUtil.Format( A295BR_Pathology_Other_AbnInd, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,78);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Pathology_Other_AbnInd_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBR_Pathology_Other_AbnInd_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Pathology_Other.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 RequiredDataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablesplittedbr_pathology_other_bioqual_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-2 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblTextblockbr_pathology_other_bioqual_Internalname, "定性结果", "", "", lblTextblockbr_pathology_other_bioqual_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_Pathology_Other.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-10", "left", "top", "", "", "div");
            wb_table2_85_0Y35( true) ;
         }
         return  ;
      }

      protected void wb_table2_85_0Y35e( bool wbgen )
      {
         if ( wbgen )
         {
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 99,'',false,'',0)\"";
            ClassString = "ButtonMaterial";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_enter_Internalname, "", "保存", bttBtntrn_enter_Jsonclick, 5, "确认", "", StyleString, ClassString, bttBtntrn_enter_Visible, bttBtntrn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_Pathology_Other.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 101,'',false,'',0)\"";
            ClassString = "ButtonMaterialDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_cancel_Internalname, "", "取消", bttBtntrn_cancel_Jsonclick, 1, "取消", "", StyleString, ClassString, bttBtntrn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_Pathology_Other.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 103,'',false,'',0)\"";
            ClassString = "ButtonMaterialDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_delete_Internalname, "", "删除", bttBtntrn_delete_Jsonclick, 5, "删除", "", StyleString, ClassString, bttBtntrn_delete_Visible, bttBtntrn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_Pathology_Other.htm");
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
            GxWebStd.gx_single_line_edit( context, edtBR_Pathology_OtherID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A288BR_Pathology_OtherID), 18, 0, ".", "")), ((edtBR_Pathology_OtherID_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A288BR_Pathology_OtherID), "ZZZZZZZZZZZZZZZZZZ")) : context.localUtil.Format( (decimal)(A288BR_Pathology_OtherID), "ZZZZZZZZZZZZZZZZZZ")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Pathology_OtherID_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_Pathology_OtherID_Visible, edtBR_Pathology_OtherID_Enabled, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "HLP_BR_Pathology_Other.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 108,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_PathologyID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A226BR_PathologyID), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A226BR_PathologyID), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,108);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_PathologyID_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_PathologyID_Visible, edtBR_PathologyID_Enabled, 1, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "HLP_BR_Pathology_Other.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            fix_multi_value_controls( ) ;
         }
         /* Execute Exit event if defined. */
      }

      protected void wb_table2_85_0Y35( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTablemergedbr_pathology_other_bioqual_Internalname, tblTablemergedbr_pathology_other_bioqual_Internalname, "", "TableMerged", 0, "", "", 0, 0, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='MergeDataCell'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynBR_Pathology_Other_BioQual_Internalname, "定性结果", "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 89,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynBR_Pathology_Other_BioQual, dynBR_Pathology_Other_BioQual_Internalname, StringUtil.RTrim( A292BR_Pathology_Other_BioQual), 1, dynBR_Pathology_Other_BioQual_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, dynBR_Pathology_Other_BioQual.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,89);\"", "", true, "HLP_BR_Pathology_Other.htm");
            dynBR_Pathology_Other_BioQual.CurrentValue = StringUtil.RTrim( A292BR_Pathology_Other_BioQual);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynBR_Pathology_Other_BioQual_Internalname, "Values", (String)(dynBR_Pathology_Other_BioQual.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\""+cellVname_cell_Internalname+"\"  class='"+cellVname_cell_Class+"'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavVname_Internalname, "vname", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 92,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavVname_Internalname, AV17vname, StringUtil.RTrim( context.localUtil.Format( AV17vname, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,92);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "请填写其它定性结果", edtavVname_Jsonclick, 0, "Attribute", "", "", "", "", edtavVname_Visible, edtavVname_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Pathology_Other.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 94,'',false,'',0)\"";
            ClassString = "bangzhu";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnbeizhu_Internalname, "", "帮助", bttBtnbeizhu_Jsonclick, 7, "帮助", "", StyleString, ClassString, bttBtnbeizhu_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"e110y35_client"+"'", TempTags, "", 2, "HLP_BR_Pathology_Other.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_85_0Y35e( true) ;
         }
         else
         {
            wb_table2_85_0Y35e( false) ;
         }
      }

      protected void wb_table1_28_0Y35( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTablemergedbr_pathology_other_bio_Internalname, tblTablemergedbr_pathology_other_bio_Internalname, "", "TableMerged", 0, "", "", 0, 0, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='MergeDataCell'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynBR_Pathology_Other_Bio_Internalname, "肿瘤标志物", "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 32,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynBR_Pathology_Other_Bio, dynBR_Pathology_Other_Bio_Internalname, StringUtil.RTrim( A289BR_Pathology_Other_Bio), 1, dynBR_Pathology_Other_Bio_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, dynBR_Pathology_Other_Bio.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,32);\"", "", true, "HLP_BR_Pathology_Other.htm");
            dynBR_Pathology_Other_Bio.CurrentValue = StringUtil.RTrim( A289BR_Pathology_Other_Bio);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynBR_Pathology_Other_Bio_Internalname, "Values", (String)(dynBR_Pathology_Other_Bio.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\""+cellBzname_cell_Internalname+"\"  class='"+cellBzname_cell_Class+"'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBzname_Internalname, "bz Name", "col-sm-3 AttributeLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 35,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBzname_Internalname, AV15bzName, StringUtil.RTrim( context.localUtil.Format( AV15bzName, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,35);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "请填写其它肿瘤标志物", edtavBzname_Jsonclick, 0, "Attribute", "", "", "", "", edtavBzname_Visible, edtavBzname_Enabled, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Pathology_Other.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_28_0Y35e( true) ;
         }
         else
         {
            wb_table1_28_0Y35e( false) ;
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
         E120Y2 ();
         context.wbGlbDoneStart = 1;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
               dynBR_Pathology_Other_Bio.CurrentValue = cgiGet( dynBR_Pathology_Other_Bio_Internalname);
               A289BR_Pathology_Other_Bio = cgiGet( dynBR_Pathology_Other_Bio_Internalname);
               n289BR_Pathology_Other_Bio = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A289BR_Pathology_Other_Bio", A289BR_Pathology_Other_Bio);
               n289BR_Pathology_Other_Bio = (String.IsNullOrEmpty(StringUtil.RTrim( A289BR_Pathology_Other_Bio)) ? true : false);
               AV15bzName = cgiGet( edtavBzname_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15bzName", AV15bzName);
               if ( ( ( context.localUtil.CToN( cgiGet( edtBR_Pathology_Other_BioNum_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtBR_Pathology_Other_BioNum_Internalname), ".", ",") > 999999999.99999m ) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_PATHOLOGY_OTHER_BIONUM");
                  AnyError = 1;
                  GX_FocusControl = edtBR_Pathology_Other_BioNum_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A290BR_Pathology_Other_BioNum = 0;
                  n290BR_Pathology_Other_BioNum = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A290BR_Pathology_Other_BioNum", StringUtil.LTrim( StringUtil.Str( A290BR_Pathology_Other_BioNum, 15, 5)));
               }
               else
               {
                  A290BR_Pathology_Other_BioNum = context.localUtil.CToN( cgiGet( edtBR_Pathology_Other_BioNum_Internalname), ".", ",");
                  n290BR_Pathology_Other_BioNum = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A290BR_Pathology_Other_BioNum", StringUtil.LTrim( StringUtil.Str( A290BR_Pathology_Other_BioNum, 15, 5)));
               }
               n290BR_Pathology_Other_BioNum = ((Convert.ToDecimal(0)==A290BR_Pathology_Other_BioNum) ? true : false);
               dynBR_Pathology_Other_BioNumUnit.CurrentValue = cgiGet( dynBR_Pathology_Other_BioNumUnit_Internalname);
               A291BR_Pathology_Other_BioNumUnit = cgiGet( dynBR_Pathology_Other_BioNumUnit_Internalname);
               n291BR_Pathology_Other_BioNumUnit = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A291BR_Pathology_Other_BioNumUnit", A291BR_Pathology_Other_BioNumUnit);
               n291BR_Pathology_Other_BioNumUnit = (String.IsNullOrEmpty(StringUtil.RTrim( A291BR_Pathology_Other_BioNumUnit)) ? true : false);
               if ( ( ( context.localUtil.CToN( cgiGet( edtBR_Pathology_Other_Low_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtBR_Pathology_Other_Low_Internalname), ".", ",") > 999999999.99999m ) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_PATHOLOGY_OTHER_LOW");
                  AnyError = 1;
                  GX_FocusControl = edtBR_Pathology_Other_Low_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A293BR_Pathology_Other_Low = 0;
                  n293BR_Pathology_Other_Low = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A293BR_Pathology_Other_Low", StringUtil.LTrim( StringUtil.Str( A293BR_Pathology_Other_Low, 15, 5)));
               }
               else
               {
                  A293BR_Pathology_Other_Low = context.localUtil.CToN( cgiGet( edtBR_Pathology_Other_Low_Internalname), ".", ",");
                  n293BR_Pathology_Other_Low = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A293BR_Pathology_Other_Low", StringUtil.LTrim( StringUtil.Str( A293BR_Pathology_Other_Low, 15, 5)));
               }
               n293BR_Pathology_Other_Low = ((Convert.ToDecimal(0)==A293BR_Pathology_Other_Low) ? true : false);
               if ( ( ( context.localUtil.CToN( cgiGet( edtBR_Pathology_Other_High_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtBR_Pathology_Other_High_Internalname), ".", ",") > 999999999.99999m ) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_PATHOLOGY_OTHER_HIGH");
                  AnyError = 1;
                  GX_FocusControl = edtBR_Pathology_Other_High_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A294BR_Pathology_Other_High = 0;
                  n294BR_Pathology_Other_High = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294BR_Pathology_Other_High", StringUtil.LTrim( StringUtil.Str( A294BR_Pathology_Other_High, 15, 5)));
               }
               else
               {
                  A294BR_Pathology_Other_High = context.localUtil.CToN( cgiGet( edtBR_Pathology_Other_High_Internalname), ".", ",");
                  n294BR_Pathology_Other_High = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294BR_Pathology_Other_High", StringUtil.LTrim( StringUtil.Str( A294BR_Pathology_Other_High, 15, 5)));
               }
               n294BR_Pathology_Other_High = ((Convert.ToDecimal(0)==A294BR_Pathology_Other_High) ? true : false);
               A295BR_Pathology_Other_AbnInd = cgiGet( edtBR_Pathology_Other_AbnInd_Internalname);
               n295BR_Pathology_Other_AbnInd = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295BR_Pathology_Other_AbnInd", A295BR_Pathology_Other_AbnInd);
               n295BR_Pathology_Other_AbnInd = (String.IsNullOrEmpty(StringUtil.RTrim( A295BR_Pathology_Other_AbnInd)) ? true : false);
               dynBR_Pathology_Other_BioQual.CurrentValue = cgiGet( dynBR_Pathology_Other_BioQual_Internalname);
               A292BR_Pathology_Other_BioQual = cgiGet( dynBR_Pathology_Other_BioQual_Internalname);
               n292BR_Pathology_Other_BioQual = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A292BR_Pathology_Other_BioQual", A292BR_Pathology_Other_BioQual);
               n292BR_Pathology_Other_BioQual = (String.IsNullOrEmpty(StringUtil.RTrim( A292BR_Pathology_Other_BioQual)) ? true : false);
               AV17vname = cgiGet( edtavVname_Internalname);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17vname", AV17vname);
               A288BR_Pathology_OtherID = (long)(context.localUtil.CToN( cgiGet( edtBR_Pathology_OtherID_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A288BR_Pathology_OtherID", StringUtil.LTrim( StringUtil.Str( (decimal)(A288BR_Pathology_OtherID), 18, 0)));
               if ( ( ( context.localUtil.CToN( cgiGet( edtBR_PathologyID_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtBR_PathologyID_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "BR_PATHOLOGYID");
                  AnyError = 1;
                  GX_FocusControl = edtBR_PathologyID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A226BR_PathologyID = 0;
                  n226BR_PathologyID = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A226BR_PathologyID", StringUtil.LTrim( StringUtil.Str( (decimal)(A226BR_PathologyID), 18, 0)));
               }
               else
               {
                  A226BR_PathologyID = (long)(context.localUtil.CToN( cgiGet( edtBR_PathologyID_Internalname), ".", ","));
                  n226BR_PathologyID = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A226BR_PathologyID", StringUtil.LTrim( StringUtil.Str( (decimal)(A226BR_PathologyID), 18, 0)));
               }
               n226BR_PathologyID = ((0==A226BR_PathologyID) ? true : false);
               /* Read saved values. */
               Z288BR_Pathology_OtherID = (long)(context.localUtil.CToN( cgiGet( "Z288BR_Pathology_OtherID"), ".", ","));
               Z509BR_Pathology_Other_AbnInd_Code = cgiGet( "Z509BR_Pathology_Other_AbnInd_Code");
               n509BR_Pathology_Other_AbnInd_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A509BR_Pathology_Other_AbnInd_Code)) ? true : false);
               Z289BR_Pathology_Other_Bio = cgiGet( "Z289BR_Pathology_Other_Bio");
               n289BR_Pathology_Other_Bio = (String.IsNullOrEmpty(StringUtil.RTrim( A289BR_Pathology_Other_Bio)) ? true : false);
               Z480BR_Pathology_Other_Bio_Code = cgiGet( "Z480BR_Pathology_Other_Bio_Code");
               n480BR_Pathology_Other_Bio_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A480BR_Pathology_Other_Bio_Code)) ? true : false);
               Z290BR_Pathology_Other_BioNum = context.localUtil.CToN( cgiGet( "Z290BR_Pathology_Other_BioNum"), ".", ",");
               n290BR_Pathology_Other_BioNum = ((Convert.ToDecimal(0)==A290BR_Pathology_Other_BioNum) ? true : false);
               Z481BR_Pathology_Other_BioNum_Code = cgiGet( "Z481BR_Pathology_Other_BioNum_Code");
               n481BR_Pathology_Other_BioNum_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A481BR_Pathology_Other_BioNum_Code)) ? true : false);
               Z291BR_Pathology_Other_BioNumUnit = cgiGet( "Z291BR_Pathology_Other_BioNumUnit");
               n291BR_Pathology_Other_BioNumUnit = (String.IsNullOrEmpty(StringUtil.RTrim( A291BR_Pathology_Other_BioNumUnit)) ? true : false);
               Z292BR_Pathology_Other_BioQual = cgiGet( "Z292BR_Pathology_Other_BioQual");
               n292BR_Pathology_Other_BioQual = (String.IsNullOrEmpty(StringUtil.RTrim( A292BR_Pathology_Other_BioQual)) ? true : false);
               Z482BR_Pathology_Other_BioQual_Code = cgiGet( "Z482BR_Pathology_Other_BioQual_Code");
               n482BR_Pathology_Other_BioQual_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A482BR_Pathology_Other_BioQual_Code)) ? true : false);
               Z293BR_Pathology_Other_Low = context.localUtil.CToN( cgiGet( "Z293BR_Pathology_Other_Low"), ".", ",");
               n293BR_Pathology_Other_Low = ((Convert.ToDecimal(0)==A293BR_Pathology_Other_Low) ? true : false);
               Z294BR_Pathology_Other_High = context.localUtil.CToN( cgiGet( "Z294BR_Pathology_Other_High"), ".", ",");
               n294BR_Pathology_Other_High = ((Convert.ToDecimal(0)==A294BR_Pathology_Other_High) ? true : false);
               Z295BR_Pathology_Other_AbnInd = cgiGet( "Z295BR_Pathology_Other_AbnInd");
               n295BR_Pathology_Other_AbnInd = (String.IsNullOrEmpty(StringUtil.RTrim( A295BR_Pathology_Other_AbnInd)) ? true : false);
               Z226BR_PathologyID = (long)(context.localUtil.CToN( cgiGet( "Z226BR_PathologyID"), ".", ","));
               n226BR_PathologyID = ((0==A226BR_PathologyID) ? true : false);
               A509BR_Pathology_Other_AbnInd_Code = cgiGet( "Z509BR_Pathology_Other_AbnInd_Code");
               n509BR_Pathology_Other_AbnInd_Code = false;
               n509BR_Pathology_Other_AbnInd_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A509BR_Pathology_Other_AbnInd_Code)) ? true : false);
               A480BR_Pathology_Other_Bio_Code = cgiGet( "Z480BR_Pathology_Other_Bio_Code");
               n480BR_Pathology_Other_Bio_Code = false;
               n480BR_Pathology_Other_Bio_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A480BR_Pathology_Other_Bio_Code)) ? true : false);
               A481BR_Pathology_Other_BioNum_Code = cgiGet( "Z481BR_Pathology_Other_BioNum_Code");
               n481BR_Pathology_Other_BioNum_Code = false;
               n481BR_Pathology_Other_BioNum_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A481BR_Pathology_Other_BioNum_Code)) ? true : false);
               A482BR_Pathology_Other_BioQual_Code = cgiGet( "Z482BR_Pathology_Other_BioQual_Code");
               n482BR_Pathology_Other_BioQual_Code = false;
               n482BR_Pathology_Other_BioQual_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A482BR_Pathology_Other_BioQual_Code)) ? true : false);
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ","));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ","));
               Gx_mode = cgiGet( "Mode");
               N226BR_PathologyID = (long)(context.localUtil.CToN( cgiGet( "N226BR_PathologyID"), ".", ","));
               n226BR_PathologyID = ((0==A226BR_PathologyID) ? true : false);
               AV7BR_Pathology_OtherID = (long)(context.localUtil.CToN( cgiGet( "vBR_PATHOLOGY_OTHERID"), ".", ","));
               AV13Insert_BR_PathologyID = (long)(context.localUtil.CToN( cgiGet( "vINSERT_BR_PATHOLOGYID"), ".", ","));
               A509BR_Pathology_Other_AbnInd_Code = cgiGet( "BR_PATHOLOGY_OTHER_ABNIND_CODE");
               n509BR_Pathology_Other_AbnInd_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A509BR_Pathology_Other_AbnInd_Code)) ? true : false);
               AV19tCurrentCode = cgiGet( "vTCURRENTCODE");
               A480BR_Pathology_Other_Bio_Code = cgiGet( "BR_PATHOLOGY_OTHER_BIO_CODE");
               n480BR_Pathology_Other_Bio_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A480BR_Pathology_Other_Bio_Code)) ? true : false);
               A481BR_Pathology_Other_BioNum_Code = cgiGet( "BR_PATHOLOGY_OTHER_BIONUM_CODE");
               n481BR_Pathology_Other_BioNum_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A481BR_Pathology_Other_BioNum_Code)) ? true : false);
               A482BR_Pathology_Other_BioQual_Code = cgiGet( "BR_PATHOLOGY_OTHER_BIOQUAL_CODE");
               n482BR_Pathology_Other_BioQual_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A482BR_Pathology_Other_BioQual_Code)) ? true : false);
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
               forbiddenHiddens = "hsh" + "BR_Pathology_Other";
               A288BR_Pathology_OtherID = (long)(context.localUtil.CToN( cgiGet( edtBR_Pathology_OtherID_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A288BR_Pathology_OtherID", StringUtil.LTrim( StringUtil.Str( (decimal)(A288BR_Pathology_OtherID), 18, 0)));
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A288BR_Pathology_OtherID), "ZZZZZZZZZZZZZZZZZZ");
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( AV19tCurrentCode, ""));
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV13Insert_BR_PathologyID), "ZZZZZZZZZZZZZZZZZZ");
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A480BR_Pathology_Other_Bio_Code, ""));
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A481BR_Pathology_Other_BioNum_Code, ""));
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A482BR_Pathology_Other_BioQual_Code, ""));
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( A288BR_Pathology_OtherID != Z288BR_Pathology_OtherID ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
               {
                  GXUtil.WriteLog("br_pathology_other:[SecurityCheckFailed value for]"+"BR_Pathology_OtherID:"+context.localUtil.Format( (decimal)(A288BR_Pathology_OtherID), "ZZZZZZZZZZZZZZZZZZ"));
                  GXUtil.WriteLog("br_pathology_other:[SecurityCheckFailed value for]"+"tCurrentCode:"+StringUtil.RTrim( context.localUtil.Format( AV19tCurrentCode, "")));
                  GXUtil.WriteLog("br_pathology_other:[SecurityCheckFailed value for]"+"Insert_BR_PathologyID:"+context.localUtil.Format( (decimal)(AV13Insert_BR_PathologyID), "ZZZZZZZZZZZZZZZZZZ"));
                  GXUtil.WriteLog("br_pathology_other:[SecurityCheckFailed value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
                  GXUtil.WriteLog("br_pathology_other:[SecurityCheckFailed value for]"+"BR_Pathology_Other_Bio_Code:"+StringUtil.RTrim( context.localUtil.Format( A480BR_Pathology_Other_Bio_Code, "")));
                  GXUtil.WriteLog("br_pathology_other:[SecurityCheckFailed value for]"+"BR_Pathology_Other_BioNum_Code:"+StringUtil.RTrim( context.localUtil.Format( A481BR_Pathology_Other_BioNum_Code, "")));
                  GXUtil.WriteLog("br_pathology_other:[SecurityCheckFailed value for]"+"BR_Pathology_Other_BioQual_Code:"+StringUtil.RTrim( context.localUtil.Format( A482BR_Pathology_Other_BioQual_Code, "")));
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
                  A288BR_Pathology_OtherID = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A288BR_Pathology_OtherID", StringUtil.LTrim( StringUtil.Str( (decimal)(A288BR_Pathology_OtherID), 18, 0)));
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
                     sMode35 = Gx_mode;
                     Gx_mode = "UPD";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     Gx_mode = sMode35;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound35 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_0Y0( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtntrn_enter_Internalname;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert", ""), 1, "BR_PATHOLOGY_OTHERID");
                        AnyError = 1;
                        GX_FocusControl = edtBR_Pathology_OtherID_Internalname;
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
                           E120Y2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: After Trn */
                           E130Y2 ();
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
            E130Y2 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll0Y35( ) ;
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
            DisableAttributes0Y35( ) ;
         }
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBzname_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBzname_Enabled), 5, 0)), true);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVname_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVname_Enabled), 5, 0)), true);
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

      protected void CONFIRM_0Y0( )
      {
         BeforeValidate0Y35( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0Y35( ) ;
            }
            else
            {
               CheckExtendedTable0Y35( ) ;
               CloseExtendedTableCursors0Y35( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         }
      }

      protected void ResetCaption0Y0( )
      {
      }

      protected void E120Y2( )
      {
         /* Start Routine */
         GXt_char1 = AV19tCurrentCode;
         new zbr_getcurrenttcode(context ).execute( out  GXt_char1) ;
         AV19tCurrentCode = GXt_char1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19tCurrentCode", AV19tCurrentCode);
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV8WWPContext) ;
         AV9IsAuthorized = true;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9IsAuthorized", AV9IsAuthorized);
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            GXt_boolean2 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Pathology_Other", out  GXt_boolean2) ;
            AV9IsAuthorized = GXt_boolean2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9IsAuthorized", AV9IsAuthorized);
         }
         if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
         {
            GXt_boolean2 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Pathology_Other", out  GXt_boolean2) ;
            AV9IsAuthorized = GXt_boolean2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9IsAuthorized", AV9IsAuthorized);
         }
         if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
         {
            GXt_boolean2 = AV9IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Pathology_Other", out  GXt_boolean2) ;
            AV9IsAuthorized = GXt_boolean2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9IsAuthorized", AV9IsAuthorized);
         }
         if ( ! AV9IsAuthorized )
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
         AV11TrnContext.FromXml(AV12WebSession.Get("TrnContext"), null, "WWPTransactionContext", "DataAnalysisPlatform");
         if ( ( StringUtil.StrCmp(AV11TrnContext.gxTpr_Transactionname, AV20Pgmname) == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) )
         {
            AV21GXV1 = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21GXV1), 8, 0)));
            while ( AV21GXV1 <= AV11TrnContext.gxTpr_Attributes.Count )
            {
               AV14TrnContextAtt = ((GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute)AV11TrnContext.gxTpr_Attributes.Item(AV21GXV1));
               if ( StringUtil.StrCmp(AV14TrnContextAtt.gxTpr_Attributename, "BR_PathologyID") == 0 )
               {
                  AV13Insert_BR_PathologyID = (long)(NumberUtil.Val( AV14TrnContextAtt.gxTpr_Attributevalue, "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13Insert_BR_PathologyID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13Insert_BR_PathologyID), 18, 0)));
               }
               AV21GXV1 = (int)(AV21GXV1+1);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21GXV1), 8, 0)));
            }
         }
         edtBR_Pathology_OtherID_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Pathology_OtherID_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Pathology_OtherID_Visible), 5, 0)), true);
         edtBR_PathologyID_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_PathologyID_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_PathologyID_Visible), 5, 0)), true);
         GXt_boolean2 = AV18TempBoolean;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Pathology_Other", out  GXt_boolean2) ;
         AV18TempBoolean = GXt_boolean2;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18TempBoolean", AV18TempBoolean);
         if ( ! ( AV18TempBoolean ) )
         {
            bttBtntrn_enter_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_enter_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_enter_Visible), 5, 0)), true);
         }
         GXt_boolean2 = AV18TempBoolean;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Pathology_Other", out  GXt_boolean2) ;
         AV18TempBoolean = GXt_boolean2;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18TempBoolean", AV18TempBoolean);
         if ( ! ( AV18TempBoolean ) )
         {
            bttBtntrn_cancel_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_cancel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_cancel_Visible), 5, 0)), true);
         }
         GXt_boolean2 = AV18TempBoolean;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Pathology_Other", out  GXt_boolean2) ;
         AV18TempBoolean = GXt_boolean2;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18TempBoolean", AV18TempBoolean);
         if ( ! ( AV18TempBoolean ) )
         {
            bttBtntrn_delete_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_delete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_delete_Visible), 5, 0)), true);
         }
         GXt_boolean2 = AV18TempBoolean;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Pathology_Other", out  GXt_boolean2) ;
         AV18TempBoolean = GXt_boolean2;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18TempBoolean", AV18TempBoolean);
         if ( ! ( AV18TempBoolean ) )
         {
            bttBtnbeizhu_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtnbeizhu_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtnbeizhu_Visible), 5, 0)), true);
         }
      }

      protected void E130Y2( )
      {
         /* After Trn Routine */
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV11TrnContext.gxTpr_Callerondelete )
         {
            CallWebObject(formatLink("br_pathology_otherww.aspx") );
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
         edtavBzname_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBzname_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBzname_Visible), 5, 0)), true);
         cellBzname_cell_Class = "Invisible";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellBzname_cell_Internalname, "Class", cellBzname_cell_Class, true);
         edtavVname_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVname_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVname_Visible), 5, 0)), true);
         cellVname_cell_Class = "Invisible";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVname_cell_Internalname, "Class", cellVname_cell_Class, true);
      }

      protected void ZM0Y35( short GX_JID )
      {
         if ( ( GX_JID == 26 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z509BR_Pathology_Other_AbnInd_Code = T000Y3_A509BR_Pathology_Other_AbnInd_Code[0];
               Z289BR_Pathology_Other_Bio = T000Y3_A289BR_Pathology_Other_Bio[0];
               Z480BR_Pathology_Other_Bio_Code = T000Y3_A480BR_Pathology_Other_Bio_Code[0];
               Z290BR_Pathology_Other_BioNum = T000Y3_A290BR_Pathology_Other_BioNum[0];
               Z481BR_Pathology_Other_BioNum_Code = T000Y3_A481BR_Pathology_Other_BioNum_Code[0];
               Z291BR_Pathology_Other_BioNumUnit = T000Y3_A291BR_Pathology_Other_BioNumUnit[0];
               Z292BR_Pathology_Other_BioQual = T000Y3_A292BR_Pathology_Other_BioQual[0];
               Z482BR_Pathology_Other_BioQual_Code = T000Y3_A482BR_Pathology_Other_BioQual_Code[0];
               Z293BR_Pathology_Other_Low = T000Y3_A293BR_Pathology_Other_Low[0];
               Z294BR_Pathology_Other_High = T000Y3_A294BR_Pathology_Other_High[0];
               Z295BR_Pathology_Other_AbnInd = T000Y3_A295BR_Pathology_Other_AbnInd[0];
               Z226BR_PathologyID = T000Y3_A226BR_PathologyID[0];
            }
            else
            {
               Z509BR_Pathology_Other_AbnInd_Code = A509BR_Pathology_Other_AbnInd_Code;
               Z289BR_Pathology_Other_Bio = A289BR_Pathology_Other_Bio;
               Z480BR_Pathology_Other_Bio_Code = A480BR_Pathology_Other_Bio_Code;
               Z290BR_Pathology_Other_BioNum = A290BR_Pathology_Other_BioNum;
               Z481BR_Pathology_Other_BioNum_Code = A481BR_Pathology_Other_BioNum_Code;
               Z291BR_Pathology_Other_BioNumUnit = A291BR_Pathology_Other_BioNumUnit;
               Z292BR_Pathology_Other_BioQual = A292BR_Pathology_Other_BioQual;
               Z482BR_Pathology_Other_BioQual_Code = A482BR_Pathology_Other_BioQual_Code;
               Z293BR_Pathology_Other_Low = A293BR_Pathology_Other_Low;
               Z294BR_Pathology_Other_High = A294BR_Pathology_Other_High;
               Z295BR_Pathology_Other_AbnInd = A295BR_Pathology_Other_AbnInd;
               Z226BR_PathologyID = A226BR_PathologyID;
            }
         }
         if ( GX_JID == -26 )
         {
            Z288BR_Pathology_OtherID = A288BR_Pathology_OtherID;
            Z509BR_Pathology_Other_AbnInd_Code = A509BR_Pathology_Other_AbnInd_Code;
            Z289BR_Pathology_Other_Bio = A289BR_Pathology_Other_Bio;
            Z480BR_Pathology_Other_Bio_Code = A480BR_Pathology_Other_Bio_Code;
            Z290BR_Pathology_Other_BioNum = A290BR_Pathology_Other_BioNum;
            Z481BR_Pathology_Other_BioNum_Code = A481BR_Pathology_Other_BioNum_Code;
            Z291BR_Pathology_Other_BioNumUnit = A291BR_Pathology_Other_BioNumUnit;
            Z292BR_Pathology_Other_BioQual = A292BR_Pathology_Other_BioQual;
            Z482BR_Pathology_Other_BioQual_Code = A482BR_Pathology_Other_BioQual_Code;
            Z293BR_Pathology_Other_Low = A293BR_Pathology_Other_Low;
            Z294BR_Pathology_Other_High = A294BR_Pathology_Other_High;
            Z295BR_Pathology_Other_AbnInd = A295BR_Pathology_Other_AbnInd;
            Z226BR_PathologyID = A226BR_PathologyID;
         }
      }

      protected void standaloneNotModal( )
      {
         edtBR_Pathology_OtherID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Pathology_OtherID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Pathology_OtherID_Enabled), 5, 0)), true);
         edtBR_Pathology_OtherID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Pathology_OtherID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Pathology_OtherID_Enabled), 5, 0)), true);
         bttBtntrn_delete_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_delete_Enabled), 5, 0)), true);
         if ( ! (0==AV7BR_Pathology_OtherID) )
         {
            A288BR_Pathology_OtherID = AV7BR_Pathology_OtherID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A288BR_Pathology_OtherID", StringUtil.LTrim( StringUtil.Str( (decimal)(A288BR_Pathology_OtherID), 18, 0)));
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV13Insert_BR_PathologyID) )
         {
            edtBR_PathologyID_Enabled = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_PathologyID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_PathologyID_Enabled), 5, 0)), true);
         }
         else
         {
            edtBR_PathologyID_Enabled = 1;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_PathologyID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_PathologyID_Enabled), 5, 0)), true);
         }
         GXABR_PATHOLOGY_OTHER_BIO_html0Y35( AV19tCurrentCode) ;
         GXABR_PATHOLOGY_OTHER_BIONUMUNIT_html0Y35( AV19tCurrentCode) ;
         GXABR_PATHOLOGY_OTHER_BIOQUAL_html0Y35( AV19tCurrentCode) ;
      }

      protected void standaloneModal( )
      {
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ! (0==AV13Insert_BR_PathologyID) )
         {
            A226BR_PathologyID = AV13Insert_BR_PathologyID;
            n226BR_PathologyID = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A226BR_PathologyID", StringUtil.LTrim( StringUtil.Str( (decimal)(A226BR_PathologyID), 18, 0)));
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
            AV20Pgmname = "BR_Pathology_Other";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20Pgmname", AV20Pgmname);
            edtavBzname_Visible = ((StringUtil.StrCmp(A289BR_Pathology_Other_Bio, "其它")==0) ? 1 : 0);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBzname_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBzname_Visible), 5, 0)), true);
            if ( ! ( ( StringUtil.StrCmp(A289BR_Pathology_Other_Bio, "其它") == 0 ) ) )
            {
               cellBzname_cell_Class = "Invisible";
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellBzname_cell_Internalname, "Class", cellBzname_cell_Class, true);
            }
            else
            {
               if ( StringUtil.StrCmp(A289BR_Pathology_Other_Bio, "其它") == 0 )
               {
                  cellBzname_cell_Class = "RequiredDataContentCell";
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellBzname_cell_Internalname, "Class", cellBzname_cell_Class, true);
               }
            }
            edtavVname_Visible = ((StringUtil.StrCmp(A292BR_Pathology_Other_BioQual, "其它")==0) ? 1 : 0);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVname_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVname_Visible), 5, 0)), true);
            if ( ! ( ( StringUtil.StrCmp(A292BR_Pathology_Other_BioQual, "其它") == 0 ) ) )
            {
               cellVname_cell_Class = "Invisible";
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVname_cell_Internalname, "Class", cellVname_cell_Class, true);
            }
            else
            {
               if ( StringUtil.StrCmp(A292BR_Pathology_Other_BioQual, "其它") == 0 )
               {
                  cellVname_cell_Class = "RequiredDataContentCell";
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVname_cell_Internalname, "Class", cellVname_cell_Class, true);
               }
            }
         }
      }

      protected void Load0Y35( )
      {
         /* Using cursor T000Y5 */
         pr_default.execute(3, new Object[] {A288BR_Pathology_OtherID});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound35 = 1;
            A509BR_Pathology_Other_AbnInd_Code = T000Y5_A509BR_Pathology_Other_AbnInd_Code[0];
            n509BR_Pathology_Other_AbnInd_Code = T000Y5_n509BR_Pathology_Other_AbnInd_Code[0];
            A289BR_Pathology_Other_Bio = T000Y5_A289BR_Pathology_Other_Bio[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A289BR_Pathology_Other_Bio", A289BR_Pathology_Other_Bio);
            n289BR_Pathology_Other_Bio = T000Y5_n289BR_Pathology_Other_Bio[0];
            A480BR_Pathology_Other_Bio_Code = T000Y5_A480BR_Pathology_Other_Bio_Code[0];
            n480BR_Pathology_Other_Bio_Code = T000Y5_n480BR_Pathology_Other_Bio_Code[0];
            A290BR_Pathology_Other_BioNum = T000Y5_A290BR_Pathology_Other_BioNum[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A290BR_Pathology_Other_BioNum", StringUtil.LTrim( StringUtil.Str( A290BR_Pathology_Other_BioNum, 15, 5)));
            n290BR_Pathology_Other_BioNum = T000Y5_n290BR_Pathology_Other_BioNum[0];
            A481BR_Pathology_Other_BioNum_Code = T000Y5_A481BR_Pathology_Other_BioNum_Code[0];
            n481BR_Pathology_Other_BioNum_Code = T000Y5_n481BR_Pathology_Other_BioNum_Code[0];
            A291BR_Pathology_Other_BioNumUnit = T000Y5_A291BR_Pathology_Other_BioNumUnit[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A291BR_Pathology_Other_BioNumUnit", A291BR_Pathology_Other_BioNumUnit);
            n291BR_Pathology_Other_BioNumUnit = T000Y5_n291BR_Pathology_Other_BioNumUnit[0];
            A292BR_Pathology_Other_BioQual = T000Y5_A292BR_Pathology_Other_BioQual[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A292BR_Pathology_Other_BioQual", A292BR_Pathology_Other_BioQual);
            n292BR_Pathology_Other_BioQual = T000Y5_n292BR_Pathology_Other_BioQual[0];
            A482BR_Pathology_Other_BioQual_Code = T000Y5_A482BR_Pathology_Other_BioQual_Code[0];
            n482BR_Pathology_Other_BioQual_Code = T000Y5_n482BR_Pathology_Other_BioQual_Code[0];
            A293BR_Pathology_Other_Low = T000Y5_A293BR_Pathology_Other_Low[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A293BR_Pathology_Other_Low", StringUtil.LTrim( StringUtil.Str( A293BR_Pathology_Other_Low, 15, 5)));
            n293BR_Pathology_Other_Low = T000Y5_n293BR_Pathology_Other_Low[0];
            A294BR_Pathology_Other_High = T000Y5_A294BR_Pathology_Other_High[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294BR_Pathology_Other_High", StringUtil.LTrim( StringUtil.Str( A294BR_Pathology_Other_High, 15, 5)));
            n294BR_Pathology_Other_High = T000Y5_n294BR_Pathology_Other_High[0];
            A295BR_Pathology_Other_AbnInd = T000Y5_A295BR_Pathology_Other_AbnInd[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295BR_Pathology_Other_AbnInd", A295BR_Pathology_Other_AbnInd);
            n295BR_Pathology_Other_AbnInd = T000Y5_n295BR_Pathology_Other_AbnInd[0];
            A226BR_PathologyID = T000Y5_A226BR_PathologyID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A226BR_PathologyID", StringUtil.LTrim( StringUtil.Str( (decimal)(A226BR_PathologyID), 18, 0)));
            n226BR_PathologyID = T000Y5_n226BR_PathologyID[0];
            ZM0Y35( -26) ;
         }
         pr_default.close(3);
         OnLoadActions0Y35( ) ;
      }

      protected void OnLoadActions0Y35( )
      {
         AV20Pgmname = "BR_Pathology_Other";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20Pgmname", AV20Pgmname);
         edtavBzname_Visible = ((StringUtil.StrCmp(A289BR_Pathology_Other_Bio, "其它")==0) ? 1 : 0);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBzname_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBzname_Visible), 5, 0)), true);
         if ( ! ( ( StringUtil.StrCmp(A289BR_Pathology_Other_Bio, "其它") == 0 ) ) )
         {
            cellBzname_cell_Class = "Invisible";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellBzname_cell_Internalname, "Class", cellBzname_cell_Class, true);
         }
         else
         {
            if ( StringUtil.StrCmp(A289BR_Pathology_Other_Bio, "其它") == 0 )
            {
               cellBzname_cell_Class = "RequiredDataContentCell";
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellBzname_cell_Internalname, "Class", cellBzname_cell_Class, true);
            }
         }
         edtavVname_Visible = ((StringUtil.StrCmp(A292BR_Pathology_Other_BioQual, "其它")==0) ? 1 : 0);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVname_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVname_Visible), 5, 0)), true);
         if ( ! ( ( StringUtil.StrCmp(A292BR_Pathology_Other_BioQual, "其它") == 0 ) ) )
         {
            cellVname_cell_Class = "Invisible";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVname_cell_Internalname, "Class", cellVname_cell_Class, true);
         }
         else
         {
            if ( StringUtil.StrCmp(A292BR_Pathology_Other_BioQual, "其它") == 0 )
            {
               cellVname_cell_Class = "RequiredDataContentCell";
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVname_cell_Internalname, "Class", cellVname_cell_Class, true);
            }
         }
      }

      protected void CheckExtendedTable0Y35( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
         AV20Pgmname = "BR_Pathology_Other";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20Pgmname", AV20Pgmname);
         /* Using cursor T000Y4 */
         pr_default.execute(2, new Object[] {n226BR_PathologyID, A226BR_PathologyID});
         if ( (pr_default.getStatus(2) == 101) )
         {
            if ( ! ( (0==A226BR_PathologyID) ) )
            {
               GX_msglist.addItem("不匹配' T36'", "ForeignKeyNotFound", 1, "BR_PATHOLOGYID");
               AnyError = 1;
               GX_FocusControl = edtBR_PathologyID_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         pr_default.close(2);
         edtavBzname_Visible = ((StringUtil.StrCmp(A289BR_Pathology_Other_Bio, "其它")==0) ? 1 : 0);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBzname_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBzname_Visible), 5, 0)), true);
         if ( ! ( ( StringUtil.StrCmp(A289BR_Pathology_Other_Bio, "其它") == 0 ) ) )
         {
            cellBzname_cell_Class = "Invisible";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellBzname_cell_Internalname, "Class", cellBzname_cell_Class, true);
         }
         else
         {
            if ( StringUtil.StrCmp(A289BR_Pathology_Other_Bio, "其它") == 0 )
            {
               cellBzname_cell_Class = "RequiredDataContentCell";
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellBzname_cell_Internalname, "Class", cellBzname_cell_Class, true);
            }
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( A289BR_Pathology_Other_Bio)) )
         {
            GX_msglist.addItem("肿瘤标志物是必须填写的。", 1, "BR_PATHOLOGY_OTHER_BIO");
            AnyError = 1;
            GX_FocusControl = dynBR_Pathology_Other_Bio_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         edtavVname_Visible = ((StringUtil.StrCmp(A292BR_Pathology_Other_BioQual, "其它")==0) ? 1 : 0);
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVname_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVname_Visible), 5, 0)), true);
         if ( ! ( ( StringUtil.StrCmp(A292BR_Pathology_Other_BioQual, "其它") == 0 ) ) )
         {
            cellVname_cell_Class = "Invisible";
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVname_cell_Internalname, "Class", cellVname_cell_Class, true);
         }
         else
         {
            if ( StringUtil.StrCmp(A292BR_Pathology_Other_BioQual, "其它") == 0 )
            {
               cellVname_cell_Class = "RequiredDataContentCell";
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVname_cell_Internalname, "Class", cellVname_cell_Class, true);
            }
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( A292BR_Pathology_Other_BioQual)) )
         {
            GX_msglist.addItem("定性结果是必须填写的。", 1, "BR_PATHOLOGY_OTHER_BIOQUAL");
            AnyError = 1;
            GX_FocusControl = dynBR_Pathology_Other_BioQual_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ( ( StringUtil.StrCmp(A289BR_Pathology_Other_Bio, "其它") == 0 ) ) && String.IsNullOrEmpty(StringUtil.RTrim( AV15bzName)) )
         {
            GX_msglist.addItem("其它肿瘤标志物是必填的", 1, "BR_PATHOLOGY_OTHER_BIO");
            AnyError = 1;
            GX_FocusControl = dynBR_Pathology_Other_Bio_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( ( ( StringUtil.StrCmp(A292BR_Pathology_Other_BioQual, "其它") == 0 ) ) && String.IsNullOrEmpty(StringUtil.RTrim( AV17vname)) )
         {
            GX_msglist.addItem("其它定性结果是必填的", 1, "BR_PATHOLOGY_OTHER_BIOQUAL");
            AnyError = 1;
            GX_FocusControl = dynBR_Pathology_Other_BioQual_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
      }

      protected void CloseExtendedTableCursors0Y35( )
      {
         pr_default.close(2);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_27( long A226BR_PathologyID )
      {
         /* Using cursor T000Y6 */
         pr_default.execute(4, new Object[] {n226BR_PathologyID, A226BR_PathologyID});
         if ( (pr_default.getStatus(4) == 101) )
         {
            if ( ! ( (0==A226BR_PathologyID) ) )
            {
               GX_msglist.addItem("不匹配' T36'", "ForeignKeyNotFound", 1, "BR_PATHOLOGYID");
               AnyError = 1;
               GX_FocusControl = edtBR_PathologyID_Internalname;
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

      protected void GetKey0Y35( )
      {
         /* Using cursor T000Y7 */
         pr_default.execute(5, new Object[] {A288BR_Pathology_OtherID});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound35 = 1;
         }
         else
         {
            RcdFound35 = 0;
         }
         pr_default.close(5);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T000Y3 */
         pr_default.execute(1, new Object[] {A288BR_Pathology_OtherID});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0Y35( 26) ;
            RcdFound35 = 1;
            A288BR_Pathology_OtherID = T000Y3_A288BR_Pathology_OtherID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A288BR_Pathology_OtherID", StringUtil.LTrim( StringUtil.Str( (decimal)(A288BR_Pathology_OtherID), 18, 0)));
            A509BR_Pathology_Other_AbnInd_Code = T000Y3_A509BR_Pathology_Other_AbnInd_Code[0];
            n509BR_Pathology_Other_AbnInd_Code = T000Y3_n509BR_Pathology_Other_AbnInd_Code[0];
            A289BR_Pathology_Other_Bio = T000Y3_A289BR_Pathology_Other_Bio[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A289BR_Pathology_Other_Bio", A289BR_Pathology_Other_Bio);
            n289BR_Pathology_Other_Bio = T000Y3_n289BR_Pathology_Other_Bio[0];
            A480BR_Pathology_Other_Bio_Code = T000Y3_A480BR_Pathology_Other_Bio_Code[0];
            n480BR_Pathology_Other_Bio_Code = T000Y3_n480BR_Pathology_Other_Bio_Code[0];
            A290BR_Pathology_Other_BioNum = T000Y3_A290BR_Pathology_Other_BioNum[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A290BR_Pathology_Other_BioNum", StringUtil.LTrim( StringUtil.Str( A290BR_Pathology_Other_BioNum, 15, 5)));
            n290BR_Pathology_Other_BioNum = T000Y3_n290BR_Pathology_Other_BioNum[0];
            A481BR_Pathology_Other_BioNum_Code = T000Y3_A481BR_Pathology_Other_BioNum_Code[0];
            n481BR_Pathology_Other_BioNum_Code = T000Y3_n481BR_Pathology_Other_BioNum_Code[0];
            A291BR_Pathology_Other_BioNumUnit = T000Y3_A291BR_Pathology_Other_BioNumUnit[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A291BR_Pathology_Other_BioNumUnit", A291BR_Pathology_Other_BioNumUnit);
            n291BR_Pathology_Other_BioNumUnit = T000Y3_n291BR_Pathology_Other_BioNumUnit[0];
            A292BR_Pathology_Other_BioQual = T000Y3_A292BR_Pathology_Other_BioQual[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A292BR_Pathology_Other_BioQual", A292BR_Pathology_Other_BioQual);
            n292BR_Pathology_Other_BioQual = T000Y3_n292BR_Pathology_Other_BioQual[0];
            A482BR_Pathology_Other_BioQual_Code = T000Y3_A482BR_Pathology_Other_BioQual_Code[0];
            n482BR_Pathology_Other_BioQual_Code = T000Y3_n482BR_Pathology_Other_BioQual_Code[0];
            A293BR_Pathology_Other_Low = T000Y3_A293BR_Pathology_Other_Low[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A293BR_Pathology_Other_Low", StringUtil.LTrim( StringUtil.Str( A293BR_Pathology_Other_Low, 15, 5)));
            n293BR_Pathology_Other_Low = T000Y3_n293BR_Pathology_Other_Low[0];
            A294BR_Pathology_Other_High = T000Y3_A294BR_Pathology_Other_High[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294BR_Pathology_Other_High", StringUtil.LTrim( StringUtil.Str( A294BR_Pathology_Other_High, 15, 5)));
            n294BR_Pathology_Other_High = T000Y3_n294BR_Pathology_Other_High[0];
            A295BR_Pathology_Other_AbnInd = T000Y3_A295BR_Pathology_Other_AbnInd[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295BR_Pathology_Other_AbnInd", A295BR_Pathology_Other_AbnInd);
            n295BR_Pathology_Other_AbnInd = T000Y3_n295BR_Pathology_Other_AbnInd[0];
            A226BR_PathologyID = T000Y3_A226BR_PathologyID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A226BR_PathologyID", StringUtil.LTrim( StringUtil.Str( (decimal)(A226BR_PathologyID), 18, 0)));
            n226BR_PathologyID = T000Y3_n226BR_PathologyID[0];
            Z288BR_Pathology_OtherID = A288BR_Pathology_OtherID;
            sMode35 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load0Y35( ) ;
            if ( AnyError == 1 )
            {
               RcdFound35 = 0;
               InitializeNonKey0Y35( ) ;
            }
            Gx_mode = sMode35;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound35 = 0;
            InitializeNonKey0Y35( ) ;
            sMode35 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal( ) ;
            Gx_mode = sMode35;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0Y35( ) ;
         if ( RcdFound35 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound35 = 0;
         /* Using cursor T000Y8 */
         pr_default.execute(6, new Object[] {A288BR_Pathology_OtherID});
         if ( (pr_default.getStatus(6) != 101) )
         {
            while ( (pr_default.getStatus(6) != 101) && ( ( T000Y8_A288BR_Pathology_OtherID[0] < A288BR_Pathology_OtherID ) ) )
            {
               pr_default.readNext(6);
            }
            if ( (pr_default.getStatus(6) != 101) && ( ( T000Y8_A288BR_Pathology_OtherID[0] > A288BR_Pathology_OtherID ) ) )
            {
               A288BR_Pathology_OtherID = T000Y8_A288BR_Pathology_OtherID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A288BR_Pathology_OtherID", StringUtil.LTrim( StringUtil.Str( (decimal)(A288BR_Pathology_OtherID), 18, 0)));
               RcdFound35 = 1;
            }
         }
         pr_default.close(6);
      }

      protected void move_previous( )
      {
         RcdFound35 = 0;
         /* Using cursor T000Y9 */
         pr_default.execute(7, new Object[] {A288BR_Pathology_OtherID});
         if ( (pr_default.getStatus(7) != 101) )
         {
            while ( (pr_default.getStatus(7) != 101) && ( ( T000Y9_A288BR_Pathology_OtherID[0] > A288BR_Pathology_OtherID ) ) )
            {
               pr_default.readNext(7);
            }
            if ( (pr_default.getStatus(7) != 101) && ( ( T000Y9_A288BR_Pathology_OtherID[0] < A288BR_Pathology_OtherID ) ) )
            {
               A288BR_Pathology_OtherID = T000Y9_A288BR_Pathology_OtherID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A288BR_Pathology_OtherID", StringUtil.LTrim( StringUtil.Str( (decimal)(A288BR_Pathology_OtherID), 18, 0)));
               RcdFound35 = 1;
            }
         }
         pr_default.close(7);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey0Y35( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = dynBR_Pathology_Other_Bio_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert0Y35( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound35 == 1 )
            {
               if ( A288BR_Pathology_OtherID != Z288BR_Pathology_OtherID )
               {
                  A288BR_Pathology_OtherID = Z288BR_Pathology_OtherID;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A288BR_Pathology_OtherID", StringUtil.LTrim( StringUtil.Str( (decimal)(A288BR_Pathology_OtherID), 18, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "BR_PATHOLOGY_OTHERID");
                  AnyError = 1;
                  GX_FocusControl = edtBR_Pathology_OtherID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
                  GX_FocusControl = dynBR_Pathology_Other_Bio_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  /* Update record */
                  Update0Y35( ) ;
                  GX_FocusControl = dynBR_Pathology_Other_Bio_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A288BR_Pathology_OtherID != Z288BR_Pathology_OtherID )
               {
                  /* Insert record */
                  GX_FocusControl = dynBR_Pathology_Other_Bio_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert0Y35( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "BR_PATHOLOGY_OTHERID");
                     AnyError = 1;
                     GX_FocusControl = edtBR_Pathology_OtherID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     /* Insert record */
                     GX_FocusControl = dynBR_Pathology_Other_Bio_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert0Y35( ) ;
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
         if ( A288BR_Pathology_OtherID != Z288BR_Pathology_OtherID )
         {
            A288BR_Pathology_OtherID = Z288BR_Pathology_OtherID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A288BR_Pathology_OtherID", StringUtil.LTrim( StringUtil.Str( (decimal)(A288BR_Pathology_OtherID), 18, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "BR_PATHOLOGY_OTHERID");
            AnyError = 1;
            GX_FocusControl = edtBR_Pathology_OtherID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = dynBR_Pathology_Other_Bio_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
         }
      }

      protected void CheckOptimisticConcurrency0Y35( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000Y2 */
            pr_default.execute(0, new Object[] {A288BR_Pathology_OtherID});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BR_Pathology_Other"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z509BR_Pathology_Other_AbnInd_Code, T000Y2_A509BR_Pathology_Other_AbnInd_Code[0]) != 0 ) || ( StringUtil.StrCmp(Z289BR_Pathology_Other_Bio, T000Y2_A289BR_Pathology_Other_Bio[0]) != 0 ) || ( StringUtil.StrCmp(Z480BR_Pathology_Other_Bio_Code, T000Y2_A480BR_Pathology_Other_Bio_Code[0]) != 0 ) || ( Z290BR_Pathology_Other_BioNum != T000Y2_A290BR_Pathology_Other_BioNum[0] ) || ( StringUtil.StrCmp(Z481BR_Pathology_Other_BioNum_Code, T000Y2_A481BR_Pathology_Other_BioNum_Code[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z291BR_Pathology_Other_BioNumUnit, T000Y2_A291BR_Pathology_Other_BioNumUnit[0]) != 0 ) || ( StringUtil.StrCmp(Z292BR_Pathology_Other_BioQual, T000Y2_A292BR_Pathology_Other_BioQual[0]) != 0 ) || ( StringUtil.StrCmp(Z482BR_Pathology_Other_BioQual_Code, T000Y2_A482BR_Pathology_Other_BioQual_Code[0]) != 0 ) || ( Z293BR_Pathology_Other_Low != T000Y2_A293BR_Pathology_Other_Low[0] ) || ( Z294BR_Pathology_Other_High != T000Y2_A294BR_Pathology_Other_High[0] ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z295BR_Pathology_Other_AbnInd, T000Y2_A295BR_Pathology_Other_AbnInd[0]) != 0 ) || ( Z226BR_PathologyID != T000Y2_A226BR_PathologyID[0] ) )
            {
               if ( StringUtil.StrCmp(Z509BR_Pathology_Other_AbnInd_Code, T000Y2_A509BR_Pathology_Other_AbnInd_Code[0]) != 0 )
               {
                  GXUtil.WriteLog("br_pathology_other:[seudo value changed for attri]"+"BR_Pathology_Other_AbnInd_Code");
                  GXUtil.WriteLogRaw("Old: ",Z509BR_Pathology_Other_AbnInd_Code);
                  GXUtil.WriteLogRaw("Current: ",T000Y2_A509BR_Pathology_Other_AbnInd_Code[0]);
               }
               if ( StringUtil.StrCmp(Z289BR_Pathology_Other_Bio, T000Y2_A289BR_Pathology_Other_Bio[0]) != 0 )
               {
                  GXUtil.WriteLog("br_pathology_other:[seudo value changed for attri]"+"BR_Pathology_Other_Bio");
                  GXUtil.WriteLogRaw("Old: ",Z289BR_Pathology_Other_Bio);
                  GXUtil.WriteLogRaw("Current: ",T000Y2_A289BR_Pathology_Other_Bio[0]);
               }
               if ( StringUtil.StrCmp(Z480BR_Pathology_Other_Bio_Code, T000Y2_A480BR_Pathology_Other_Bio_Code[0]) != 0 )
               {
                  GXUtil.WriteLog("br_pathology_other:[seudo value changed for attri]"+"BR_Pathology_Other_Bio_Code");
                  GXUtil.WriteLogRaw("Old: ",Z480BR_Pathology_Other_Bio_Code);
                  GXUtil.WriteLogRaw("Current: ",T000Y2_A480BR_Pathology_Other_Bio_Code[0]);
               }
               if ( Z290BR_Pathology_Other_BioNum != T000Y2_A290BR_Pathology_Other_BioNum[0] )
               {
                  GXUtil.WriteLog("br_pathology_other:[seudo value changed for attri]"+"BR_Pathology_Other_BioNum");
                  GXUtil.WriteLogRaw("Old: ",Z290BR_Pathology_Other_BioNum);
                  GXUtil.WriteLogRaw("Current: ",T000Y2_A290BR_Pathology_Other_BioNum[0]);
               }
               if ( StringUtil.StrCmp(Z481BR_Pathology_Other_BioNum_Code, T000Y2_A481BR_Pathology_Other_BioNum_Code[0]) != 0 )
               {
                  GXUtil.WriteLog("br_pathology_other:[seudo value changed for attri]"+"BR_Pathology_Other_BioNum_Code");
                  GXUtil.WriteLogRaw("Old: ",Z481BR_Pathology_Other_BioNum_Code);
                  GXUtil.WriteLogRaw("Current: ",T000Y2_A481BR_Pathology_Other_BioNum_Code[0]);
               }
               if ( StringUtil.StrCmp(Z291BR_Pathology_Other_BioNumUnit, T000Y2_A291BR_Pathology_Other_BioNumUnit[0]) != 0 )
               {
                  GXUtil.WriteLog("br_pathology_other:[seudo value changed for attri]"+"BR_Pathology_Other_BioNumUnit");
                  GXUtil.WriteLogRaw("Old: ",Z291BR_Pathology_Other_BioNumUnit);
                  GXUtil.WriteLogRaw("Current: ",T000Y2_A291BR_Pathology_Other_BioNumUnit[0]);
               }
               if ( StringUtil.StrCmp(Z292BR_Pathology_Other_BioQual, T000Y2_A292BR_Pathology_Other_BioQual[0]) != 0 )
               {
                  GXUtil.WriteLog("br_pathology_other:[seudo value changed for attri]"+"BR_Pathology_Other_BioQual");
                  GXUtil.WriteLogRaw("Old: ",Z292BR_Pathology_Other_BioQual);
                  GXUtil.WriteLogRaw("Current: ",T000Y2_A292BR_Pathology_Other_BioQual[0]);
               }
               if ( StringUtil.StrCmp(Z482BR_Pathology_Other_BioQual_Code, T000Y2_A482BR_Pathology_Other_BioQual_Code[0]) != 0 )
               {
                  GXUtil.WriteLog("br_pathology_other:[seudo value changed for attri]"+"BR_Pathology_Other_BioQual_Code");
                  GXUtil.WriteLogRaw("Old: ",Z482BR_Pathology_Other_BioQual_Code);
                  GXUtil.WriteLogRaw("Current: ",T000Y2_A482BR_Pathology_Other_BioQual_Code[0]);
               }
               if ( Z293BR_Pathology_Other_Low != T000Y2_A293BR_Pathology_Other_Low[0] )
               {
                  GXUtil.WriteLog("br_pathology_other:[seudo value changed for attri]"+"BR_Pathology_Other_Low");
                  GXUtil.WriteLogRaw("Old: ",Z293BR_Pathology_Other_Low);
                  GXUtil.WriteLogRaw("Current: ",T000Y2_A293BR_Pathology_Other_Low[0]);
               }
               if ( Z294BR_Pathology_Other_High != T000Y2_A294BR_Pathology_Other_High[0] )
               {
                  GXUtil.WriteLog("br_pathology_other:[seudo value changed for attri]"+"BR_Pathology_Other_High");
                  GXUtil.WriteLogRaw("Old: ",Z294BR_Pathology_Other_High);
                  GXUtil.WriteLogRaw("Current: ",T000Y2_A294BR_Pathology_Other_High[0]);
               }
               if ( StringUtil.StrCmp(Z295BR_Pathology_Other_AbnInd, T000Y2_A295BR_Pathology_Other_AbnInd[0]) != 0 )
               {
                  GXUtil.WriteLog("br_pathology_other:[seudo value changed for attri]"+"BR_Pathology_Other_AbnInd");
                  GXUtil.WriteLogRaw("Old: ",Z295BR_Pathology_Other_AbnInd);
                  GXUtil.WriteLogRaw("Current: ",T000Y2_A295BR_Pathology_Other_AbnInd[0]);
               }
               if ( Z226BR_PathologyID != T000Y2_A226BR_PathologyID[0] )
               {
                  GXUtil.WriteLog("br_pathology_other:[seudo value changed for attri]"+"BR_PathologyID");
                  GXUtil.WriteLogRaw("Old: ",Z226BR_PathologyID);
                  GXUtil.WriteLogRaw("Current: ",T000Y2_A226BR_PathologyID[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"BR_Pathology_Other"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0Y35( )
      {
         BeforeValidate0Y35( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0Y35( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0Y35( 0) ;
            CheckOptimisticConcurrency0Y35( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0Y35( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0Y35( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000Y10 */
                     pr_default.execute(8, new Object[] {n509BR_Pathology_Other_AbnInd_Code, A509BR_Pathology_Other_AbnInd_Code, n289BR_Pathology_Other_Bio, A289BR_Pathology_Other_Bio, n480BR_Pathology_Other_Bio_Code, A480BR_Pathology_Other_Bio_Code, n290BR_Pathology_Other_BioNum, A290BR_Pathology_Other_BioNum, n481BR_Pathology_Other_BioNum_Code, A481BR_Pathology_Other_BioNum_Code, n291BR_Pathology_Other_BioNumUnit, A291BR_Pathology_Other_BioNumUnit, n292BR_Pathology_Other_BioQual, A292BR_Pathology_Other_BioQual, n482BR_Pathology_Other_BioQual_Code, A482BR_Pathology_Other_BioQual_Code, n293BR_Pathology_Other_Low, A293BR_Pathology_Other_Low, n294BR_Pathology_Other_High, A294BR_Pathology_Other_High, n295BR_Pathology_Other_AbnInd, A295BR_Pathology_Other_AbnInd, n226BR_PathologyID, A226BR_PathologyID});
                     A288BR_Pathology_OtherID = T000Y10_A288BR_Pathology_OtherID[0];
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A288BR_Pathology_OtherID", StringUtil.LTrim( StringUtil.Str( (decimal)(A288BR_Pathology_OtherID), 18, 0)));
                     pr_default.close(8);
                     dsDefault.SmartCacheProvider.SetUpdated("BR_Pathology_Other") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A226BR_PathologyID), 18, 0)),  "病理学",  StringUtil.Trim( StringUtil.Str( (decimal)(A288BR_Pathology_OtherID), 18, 0)),  "其它信息",  "Create",  1) ;
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                           ResetCaption0Y0( ) ;
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
               Load0Y35( ) ;
            }
            EndLevel0Y35( ) ;
         }
         CloseExtendedTableCursors0Y35( ) ;
      }

      protected void Update0Y35( )
      {
         BeforeValidate0Y35( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0Y35( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0Y35( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0Y35( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0Y35( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000Y11 */
                     pr_default.execute(9, new Object[] {n509BR_Pathology_Other_AbnInd_Code, A509BR_Pathology_Other_AbnInd_Code, n289BR_Pathology_Other_Bio, A289BR_Pathology_Other_Bio, n480BR_Pathology_Other_Bio_Code, A480BR_Pathology_Other_Bio_Code, n290BR_Pathology_Other_BioNum, A290BR_Pathology_Other_BioNum, n481BR_Pathology_Other_BioNum_Code, A481BR_Pathology_Other_BioNum_Code, n291BR_Pathology_Other_BioNumUnit, A291BR_Pathology_Other_BioNumUnit, n292BR_Pathology_Other_BioQual, A292BR_Pathology_Other_BioQual, n482BR_Pathology_Other_BioQual_Code, A482BR_Pathology_Other_BioQual_Code, n293BR_Pathology_Other_Low, A293BR_Pathology_Other_Low, n294BR_Pathology_Other_High, A294BR_Pathology_Other_High, n295BR_Pathology_Other_AbnInd, A295BR_Pathology_Other_AbnInd, n226BR_PathologyID, A226BR_PathologyID, A288BR_Pathology_OtherID});
                     pr_default.close(9);
                     dsDefault.SmartCacheProvider.SetUpdated("BR_Pathology_Other") ;
                     if ( (pr_default.getStatus(9) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BR_Pathology_Other"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0Y35( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A226BR_PathologyID), 18, 0)),  "病理学",  StringUtil.Trim( StringUtil.Str( (decimal)(A288BR_Pathology_OtherID), 18, 0)),  "其它信息",  "Update",  1) ;
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
            EndLevel0Y35( ) ;
         }
         CloseExtendedTableCursors0Y35( ) ;
      }

      protected void DeferredUpdate0Y35( )
      {
      }

      protected void delete( )
      {
         BeforeValidate0Y35( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0Y35( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0Y35( ) ;
            AfterConfirm0Y35( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0Y35( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000Y12 */
                  pr_default.execute(10, new Object[] {A288BR_Pathology_OtherID});
                  pr_default.close(10);
                  dsDefault.SmartCacheProvider.SetUpdated("BR_Pathology_Other") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A226BR_PathologyID), 18, 0)),  "病理学",  StringUtil.Trim( StringUtil.Str( (decimal)(A288BR_Pathology_OtherID), 18, 0)),  "其它信息",  "Delete",  1) ;
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
         sMode35 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel0Y35( ) ;
         Gx_mode = sMode35;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls0Y35( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV20Pgmname = "BR_Pathology_Other";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20Pgmname", AV20Pgmname);
            edtavBzname_Visible = ((StringUtil.StrCmp(A289BR_Pathology_Other_Bio, "其它")==0) ? 1 : 0);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBzname_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBzname_Visible), 5, 0)), true);
            if ( ! ( ( StringUtil.StrCmp(A289BR_Pathology_Other_Bio, "其它") == 0 ) ) )
            {
               cellBzname_cell_Class = "Invisible";
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellBzname_cell_Internalname, "Class", cellBzname_cell_Class, true);
            }
            else
            {
               if ( StringUtil.StrCmp(A289BR_Pathology_Other_Bio, "其它") == 0 )
               {
                  cellBzname_cell_Class = "RequiredDataContentCell";
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellBzname_cell_Internalname, "Class", cellBzname_cell_Class, true);
               }
            }
            edtavVname_Visible = ((StringUtil.StrCmp(A292BR_Pathology_Other_BioQual, "其它")==0) ? 1 : 0);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVname_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVname_Visible), 5, 0)), true);
            if ( ! ( ( StringUtil.StrCmp(A292BR_Pathology_Other_BioQual, "其它") == 0 ) ) )
            {
               cellVname_cell_Class = "Invisible";
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVname_cell_Internalname, "Class", cellVname_cell_Class, true);
            }
            else
            {
               if ( StringUtil.StrCmp(A292BR_Pathology_Other_BioQual, "其它") == 0 )
               {
                  cellVname_cell_Class = "RequiredDataContentCell";
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, cellVname_cell_Internalname, "Class", cellVname_cell_Class, true);
               }
            }
         }
      }

      protected void EndLevel0Y35( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0Y35( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(1);
            context.CommitDataStores("br_pathology_other",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues0Y0( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
            pr_default.close(1);
            context.RollbackDataStores("br_pathology_other",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart0Y35( )
      {
         /* Scan By routine */
         /* Using cursor T000Y13 */
         pr_default.execute(11);
         RcdFound35 = 0;
         if ( (pr_default.getStatus(11) != 101) )
         {
            RcdFound35 = 1;
            A288BR_Pathology_OtherID = T000Y13_A288BR_Pathology_OtherID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A288BR_Pathology_OtherID", StringUtil.LTrim( StringUtil.Str( (decimal)(A288BR_Pathology_OtherID), 18, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0Y35( )
      {
         /* Scan next routine */
         pr_default.readNext(11);
         RcdFound35 = 0;
         if ( (pr_default.getStatus(11) != 101) )
         {
            RcdFound35 = 1;
            A288BR_Pathology_OtherID = T000Y13_A288BR_Pathology_OtherID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A288BR_Pathology_OtherID", StringUtil.LTrim( StringUtil.Str( (decimal)(A288BR_Pathology_OtherID), 18, 0)));
         }
      }

      protected void ScanEnd0Y35( )
      {
         pr_default.close(11);
      }

      protected void AfterConfirm0Y35( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0Y35( )
      {
         /* Before Insert Rules */
         GXt_char1 = A509BR_Pathology_Other_AbnInd_Code;
         new zutil_findtargetcode(context ).execute(  38,  A295BR_Pathology_Other_AbnInd, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295BR_Pathology_Other_AbnInd", A295BR_Pathology_Other_AbnInd);
         A509BR_Pathology_Other_AbnInd_Code = GXt_char1;
         n509BR_Pathology_Other_AbnInd_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A509BR_Pathology_Other_AbnInd_Code", A509BR_Pathology_Other_AbnInd_Code);
         if ( StringUtil.StrCmp(A292BR_Pathology_Other_BioQual, "其它") == 0 )
         {
            A292BR_Pathology_Other_BioQual = AV17vname;
            n292BR_Pathology_Other_BioQual = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A292BR_Pathology_Other_BioQual", A292BR_Pathology_Other_BioQual);
         }
         if ( StringUtil.StrCmp(A289BR_Pathology_Other_Bio, "其它") == 0 )
         {
            A289BR_Pathology_Other_Bio = AV15bzName;
            n289BR_Pathology_Other_Bio = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A289BR_Pathology_Other_Bio", A289BR_Pathology_Other_Bio);
         }
      }

      protected void BeforeUpdate0Y35( )
      {
         /* Before Update Rules */
         GXt_char1 = A509BR_Pathology_Other_AbnInd_Code;
         new zutil_findtargetcode(context ).execute(  38,  A295BR_Pathology_Other_AbnInd, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295BR_Pathology_Other_AbnInd", A295BR_Pathology_Other_AbnInd);
         A509BR_Pathology_Other_AbnInd_Code = GXt_char1;
         n509BR_Pathology_Other_AbnInd_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A509BR_Pathology_Other_AbnInd_Code", A509BR_Pathology_Other_AbnInd_Code);
      }

      protected void BeforeDelete0Y35( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0Y35( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0Y35( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0Y35( )
      {
         dynBR_Pathology_Other_Bio.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynBR_Pathology_Other_Bio_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynBR_Pathology_Other_Bio.Enabled), 5, 0)), true);
         edtavBzname_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBzname_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBzname_Enabled), 5, 0)), true);
         edtBR_Pathology_Other_BioNum_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Pathology_Other_BioNum_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Pathology_Other_BioNum_Enabled), 5, 0)), true);
         dynBR_Pathology_Other_BioNumUnit.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynBR_Pathology_Other_BioNumUnit_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynBR_Pathology_Other_BioNumUnit.Enabled), 5, 0)), true);
         edtBR_Pathology_Other_Low_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Pathology_Other_Low_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Pathology_Other_Low_Enabled), 5, 0)), true);
         edtBR_Pathology_Other_High_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Pathology_Other_High_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Pathology_Other_High_Enabled), 5, 0)), true);
         edtBR_Pathology_Other_AbnInd_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Pathology_Other_AbnInd_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Pathology_Other_AbnInd_Enabled), 5, 0)), true);
         dynBR_Pathology_Other_BioQual.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynBR_Pathology_Other_BioQual_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynBR_Pathology_Other_BioQual.Enabled), 5, 0)), true);
         edtavVname_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavVname_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavVname_Enabled), 5, 0)), true);
         edtBR_Pathology_OtherID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Pathology_OtherID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Pathology_OtherID_Enabled), 5, 0)), true);
         edtBR_PathologyID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_PathologyID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_PathologyID_Enabled), 5, 0)), true);
      }

      protected void send_integrity_lvl_hashes0Y35( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues0Y0( )
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
         context.AddJavascriptSource("gxcfg.js", "?20202279381490", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_pathology_other.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7BR_Pathology_OtherID)+"\">") ;
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
         forbiddenHiddens = "hsh" + "BR_Pathology_Other";
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A288BR_Pathology_OtherID), "ZZZZZZZZZZZZZZZZZZ");
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( AV19tCurrentCode, ""));
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV13Insert_BR_PathologyID), "ZZZZZZZZZZZZZZZZZZ");
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A480BR_Pathology_Other_Bio_Code, ""));
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A481BR_Pathology_Other_BioNum_Code, ""));
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( A482BR_Pathology_Other_BioQual_Code, ""));
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("br_pathology_other:[SendSecurityCheck value for]"+"BR_Pathology_OtherID:"+context.localUtil.Format( (decimal)(A288BR_Pathology_OtherID), "ZZZZZZZZZZZZZZZZZZ"));
         GXUtil.WriteLog("br_pathology_other:[SendSecurityCheck value for]"+"tCurrentCode:"+StringUtil.RTrim( context.localUtil.Format( AV19tCurrentCode, "")));
         GXUtil.WriteLog("br_pathology_other:[SendSecurityCheck value for]"+"Insert_BR_PathologyID:"+context.localUtil.Format( (decimal)(AV13Insert_BR_PathologyID), "ZZZZZZZZZZZZZZZZZZ"));
         GXUtil.WriteLog("br_pathology_other:[SendSecurityCheck value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
         GXUtil.WriteLog("br_pathology_other:[SendSecurityCheck value for]"+"BR_Pathology_Other_Bio_Code:"+StringUtil.RTrim( context.localUtil.Format( A480BR_Pathology_Other_Bio_Code, "")));
         GXUtil.WriteLog("br_pathology_other:[SendSecurityCheck value for]"+"BR_Pathology_Other_BioNum_Code:"+StringUtil.RTrim( context.localUtil.Format( A481BR_Pathology_Other_BioNum_Code, "")));
         GXUtil.WriteLog("br_pathology_other:[SendSecurityCheck value for]"+"BR_Pathology_Other_BioQual_Code:"+StringUtil.RTrim( context.localUtil.Format( A482BR_Pathology_Other_BioQual_Code, "")));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z288BR_Pathology_OtherID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z288BR_Pathology_OtherID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z509BR_Pathology_Other_AbnInd_Code", Z509BR_Pathology_Other_AbnInd_Code);
         GxWebStd.gx_hidden_field( context, "Z289BR_Pathology_Other_Bio", Z289BR_Pathology_Other_Bio);
         GxWebStd.gx_hidden_field( context, "Z480BR_Pathology_Other_Bio_Code", Z480BR_Pathology_Other_Bio_Code);
         GxWebStd.gx_hidden_field( context, "Z290BR_Pathology_Other_BioNum", StringUtil.LTrim( StringUtil.NToC( Z290BR_Pathology_Other_BioNum, 15, 5, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z481BR_Pathology_Other_BioNum_Code", Z481BR_Pathology_Other_BioNum_Code);
         GxWebStd.gx_hidden_field( context, "Z291BR_Pathology_Other_BioNumUnit", Z291BR_Pathology_Other_BioNumUnit);
         GxWebStd.gx_hidden_field( context, "Z292BR_Pathology_Other_BioQual", Z292BR_Pathology_Other_BioQual);
         GxWebStd.gx_hidden_field( context, "Z482BR_Pathology_Other_BioQual_Code", Z482BR_Pathology_Other_BioQual_Code);
         GxWebStd.gx_hidden_field( context, "Z293BR_Pathology_Other_Low", StringUtil.LTrim( StringUtil.NToC( Z293BR_Pathology_Other_Low, 15, 5, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z294BR_Pathology_Other_High", StringUtil.LTrim( StringUtil.NToC( Z294BR_Pathology_Other_High, 15, 5, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z295BR_Pathology_Other_AbnInd", Z295BR_Pathology_Other_AbnInd);
         GxWebStd.gx_hidden_field( context, "Z226BR_PathologyID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z226BR_PathologyID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "gxhash_Mode", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         GxWebStd.gx_hidden_field( context, "N226BR_PathologyID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A226BR_PathologyID), 18, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vTRNCONTEXT", AV11TrnContext);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vTRNCONTEXT", AV11TrnContext);
         }
         GxWebStd.gx_hidden_field( context, "vBR_PATHOLOGY_OTHERID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7BR_Pathology_OtherID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vBR_PATHOLOGY_OTHERID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV7BR_Pathology_OtherID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, "vINSERT_BR_PATHOLOGYID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13Insert_BR_PathologyID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "BR_PATHOLOGY_OTHER_ABNIND_CODE", A509BR_Pathology_Other_AbnInd_Code);
         GxWebStd.gx_hidden_field( context, "vTCURRENTCODE", AV19tCurrentCode);
         GxWebStd.gx_hidden_field( context, "BR_PATHOLOGY_OTHER_BIO_CODE", A480BR_Pathology_Other_Bio_Code);
         GxWebStd.gx_hidden_field( context, "BR_PATHOLOGY_OTHER_BIONUM_CODE", A481BR_Pathology_Other_BioNum_Code);
         GxWebStd.gx_hidden_field( context, "BR_PATHOLOGY_OTHER_BIOQUAL_CODE", A482BR_Pathology_Other_BioQual_Code);
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
         return formatLink("br_pathology_other.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV7BR_Pathology_OtherID) ;
      }

      public override String GetPgmname( )
      {
         return "BR_Pathology_Other" ;
      }

      public override String GetPgmdesc( )
      {
         return "Data Mgmt Portal - RAAP" ;
      }

      protected void InitializeNonKey0Y35( )
      {
         A226BR_PathologyID = 0;
         n226BR_PathologyID = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A226BR_PathologyID", StringUtil.LTrim( StringUtil.Str( (decimal)(A226BR_PathologyID), 18, 0)));
         n226BR_PathologyID = ((0==A226BR_PathologyID) ? true : false);
         AV15bzName = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15bzName", AV15bzName);
         AV17vname = "";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17vname", AV17vname);
         A509BR_Pathology_Other_AbnInd_Code = "";
         n509BR_Pathology_Other_AbnInd_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A509BR_Pathology_Other_AbnInd_Code", A509BR_Pathology_Other_AbnInd_Code);
         A289BR_Pathology_Other_Bio = "";
         n289BR_Pathology_Other_Bio = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A289BR_Pathology_Other_Bio", A289BR_Pathology_Other_Bio);
         n289BR_Pathology_Other_Bio = (String.IsNullOrEmpty(StringUtil.RTrim( A289BR_Pathology_Other_Bio)) ? true : false);
         A480BR_Pathology_Other_Bio_Code = "";
         n480BR_Pathology_Other_Bio_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A480BR_Pathology_Other_Bio_Code", A480BR_Pathology_Other_Bio_Code);
         A290BR_Pathology_Other_BioNum = 0;
         n290BR_Pathology_Other_BioNum = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A290BR_Pathology_Other_BioNum", StringUtil.LTrim( StringUtil.Str( A290BR_Pathology_Other_BioNum, 15, 5)));
         n290BR_Pathology_Other_BioNum = ((Convert.ToDecimal(0)==A290BR_Pathology_Other_BioNum) ? true : false);
         A481BR_Pathology_Other_BioNum_Code = "";
         n481BR_Pathology_Other_BioNum_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A481BR_Pathology_Other_BioNum_Code", A481BR_Pathology_Other_BioNum_Code);
         A291BR_Pathology_Other_BioNumUnit = "";
         n291BR_Pathology_Other_BioNumUnit = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A291BR_Pathology_Other_BioNumUnit", A291BR_Pathology_Other_BioNumUnit);
         n291BR_Pathology_Other_BioNumUnit = (String.IsNullOrEmpty(StringUtil.RTrim( A291BR_Pathology_Other_BioNumUnit)) ? true : false);
         A292BR_Pathology_Other_BioQual = "";
         n292BR_Pathology_Other_BioQual = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A292BR_Pathology_Other_BioQual", A292BR_Pathology_Other_BioQual);
         n292BR_Pathology_Other_BioQual = (String.IsNullOrEmpty(StringUtil.RTrim( A292BR_Pathology_Other_BioQual)) ? true : false);
         A482BR_Pathology_Other_BioQual_Code = "";
         n482BR_Pathology_Other_BioQual_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A482BR_Pathology_Other_BioQual_Code", A482BR_Pathology_Other_BioQual_Code);
         A293BR_Pathology_Other_Low = 0;
         n293BR_Pathology_Other_Low = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A293BR_Pathology_Other_Low", StringUtil.LTrim( StringUtil.Str( A293BR_Pathology_Other_Low, 15, 5)));
         n293BR_Pathology_Other_Low = ((Convert.ToDecimal(0)==A293BR_Pathology_Other_Low) ? true : false);
         A294BR_Pathology_Other_High = 0;
         n294BR_Pathology_Other_High = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A294BR_Pathology_Other_High", StringUtil.LTrim( StringUtil.Str( A294BR_Pathology_Other_High, 15, 5)));
         n294BR_Pathology_Other_High = ((Convert.ToDecimal(0)==A294BR_Pathology_Other_High) ? true : false);
         A295BR_Pathology_Other_AbnInd = "";
         n295BR_Pathology_Other_AbnInd = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295BR_Pathology_Other_AbnInd", A295BR_Pathology_Other_AbnInd);
         n295BR_Pathology_Other_AbnInd = (String.IsNullOrEmpty(StringUtil.RTrim( A295BR_Pathology_Other_AbnInd)) ? true : false);
         Z509BR_Pathology_Other_AbnInd_Code = "";
         Z289BR_Pathology_Other_Bio = "";
         Z480BR_Pathology_Other_Bio_Code = "";
         Z290BR_Pathology_Other_BioNum = 0;
         Z481BR_Pathology_Other_BioNum_Code = "";
         Z291BR_Pathology_Other_BioNumUnit = "";
         Z292BR_Pathology_Other_BioQual = "";
         Z482BR_Pathology_Other_BioQual_Code = "";
         Z293BR_Pathology_Other_Low = 0;
         Z294BR_Pathology_Other_High = 0;
         Z295BR_Pathology_Other_AbnInd = "";
         Z226BR_PathologyID = 0;
      }

      protected void InitAll0Y35( )
      {
         A288BR_Pathology_OtherID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A288BR_Pathology_OtherID", StringUtil.LTrim( StringUtil.Str( (decimal)(A288BR_Pathology_OtherID), 18, 0)));
         InitializeNonKey0Y35( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20202279381539", true);
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
         context.AddJavascriptSource("br_pathology_other.js", "?20202279381539", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         lblTextblockbr_pathology_other_bio_Internalname = "TEXTBLOCKBR_PATHOLOGY_OTHER_BIO";
         dynBR_Pathology_Other_Bio_Internalname = "BR_PATHOLOGY_OTHER_BIO";
         edtavBzname_Internalname = "vBZNAME";
         cellBzname_cell_Internalname = "BZNAME_CELL";
         tblTablemergedbr_pathology_other_bio_Internalname = "TABLEMERGEDBR_PATHOLOGY_OTHER_BIO";
         divTablesplittedbr_pathology_other_bio_Internalname = "TABLESPLITTEDBR_PATHOLOGY_OTHER_BIO";
         lblTextblockbr_pathology_other_bionum_Internalname = "TEXTBLOCKBR_PATHOLOGY_OTHER_BIONUM";
         edtBR_Pathology_Other_BioNum_Internalname = "BR_PATHOLOGY_OTHER_BIONUM";
         divUnnamedtablebr_pathology_other_bionum_Internalname = "UNNAMEDTABLEBR_PATHOLOGY_OTHER_BIONUM";
         lblTextblockbr_pathology_other_bionumunit_Internalname = "TEXTBLOCKBR_PATHOLOGY_OTHER_BIONUMUNIT";
         dynBR_Pathology_Other_BioNumUnit_Internalname = "BR_PATHOLOGY_OTHER_BIONUMUNIT";
         divUnnamedtablebr_pathology_other_bionumunit_Internalname = "UNNAMEDTABLEBR_PATHOLOGY_OTHER_BIONUMUNIT";
         lblTextblockbr_pathology_other_low_Internalname = "TEXTBLOCKBR_PATHOLOGY_OTHER_LOW";
         edtBR_Pathology_Other_Low_Internalname = "BR_PATHOLOGY_OTHER_LOW";
         divUnnamedtablebr_pathology_other_low_Internalname = "UNNAMEDTABLEBR_PATHOLOGY_OTHER_LOW";
         lblTextblockbr_pathology_other_high_Internalname = "TEXTBLOCKBR_PATHOLOGY_OTHER_HIGH";
         edtBR_Pathology_Other_High_Internalname = "BR_PATHOLOGY_OTHER_HIGH";
         divUnnamedtablebr_pathology_other_high_Internalname = "UNNAMEDTABLEBR_PATHOLOGY_OTHER_HIGH";
         lblTextblockbr_pathology_other_abnind_Internalname = "TEXTBLOCKBR_PATHOLOGY_OTHER_ABNIND";
         edtBR_Pathology_Other_AbnInd_Internalname = "BR_PATHOLOGY_OTHER_ABNIND";
         divUnnamedtablebr_pathology_other_abnind_Internalname = "UNNAMEDTABLEBR_PATHOLOGY_OTHER_ABNIND";
         lblTextblockbr_pathology_other_bioqual_Internalname = "TEXTBLOCKBR_PATHOLOGY_OTHER_BIOQUAL";
         dynBR_Pathology_Other_BioQual_Internalname = "BR_PATHOLOGY_OTHER_BIOQUAL";
         edtavVname_Internalname = "vVNAME";
         cellVname_cell_Internalname = "VNAME_CELL";
         bttBtnbeizhu_Internalname = "BTNBEIZHU";
         tblTablemergedbr_pathology_other_bioqual_Internalname = "TABLEMERGEDBR_PATHOLOGY_OTHER_BIOQUAL";
         divTablesplittedbr_pathology_other_bioqual_Internalname = "TABLESPLITTEDBR_PATHOLOGY_OTHER_BIOQUAL";
         divTableattributes_Internalname = "TABLEATTRIBUTES";
         divLayout_tableattributes_Internalname = "LAYOUT_TABLEATTRIBUTES";
         Dvpanel_tableattributes_Internalname = "DVPANEL_TABLEATTRIBUTES";
         divHtml_dvpanel_tableattributes_Internalname = "HTML_DVPANEL_TABLEATTRIBUTES";
         divTablecontent_Internalname = "TABLECONTENT";
         bttBtntrn_enter_Internalname = "BTNTRN_ENTER";
         bttBtntrn_cancel_Internalname = "BTNTRN_CANCEL";
         bttBtntrn_delete_Internalname = "BTNTRN_DELETE";
         divTablemain_Internalname = "TABLEMAIN";
         edtBR_Pathology_OtherID_Internalname = "BR_PATHOLOGY_OTHERID";
         edtBR_PathologyID_Internalname = "BR_PATHOLOGYID";
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
         edtavBzname_Jsonclick = "";
         edtavBzname_Enabled = 1;
         edtavBzname_Visible = 1;
         cellBzname_cell_Class = "";
         dynBR_Pathology_Other_Bio_Jsonclick = "";
         dynBR_Pathology_Other_Bio.Enabled = 1;
         bttBtnbeizhu_Visible = 1;
         edtavVname_Jsonclick = "";
         edtavVname_Enabled = 1;
         edtavVname_Visible = 1;
         cellVname_cell_Class = "";
         dynBR_Pathology_Other_BioQual_Jsonclick = "";
         dynBR_Pathology_Other_BioQual.Enabled = 1;
         edtBR_PathologyID_Jsonclick = "";
         edtBR_PathologyID_Enabled = 1;
         edtBR_PathologyID_Visible = 1;
         edtBR_Pathology_OtherID_Jsonclick = "";
         edtBR_Pathology_OtherID_Enabled = 0;
         edtBR_Pathology_OtherID_Visible = 1;
         bttBtntrn_delete_Enabled = 0;
         bttBtntrn_delete_Visible = 1;
         bttBtntrn_cancel_Visible = 1;
         bttBtntrn_enter_Enabled = 1;
         bttBtntrn_enter_Visible = 1;
         edtBR_Pathology_Other_AbnInd_Jsonclick = "";
         edtBR_Pathology_Other_AbnInd_Enabled = 1;
         edtBR_Pathology_Other_High_Jsonclick = "";
         edtBR_Pathology_Other_High_Enabled = 1;
         edtBR_Pathology_Other_Low_Jsonclick = "";
         edtBR_Pathology_Other_Low_Enabled = 1;
         dynBR_Pathology_Other_BioNumUnit_Jsonclick = "";
         dynBR_Pathology_Other_BioNumUnit.Enabled = 1;
         edtBR_Pathology_Other_BioNum_Jsonclick = "";
         edtBR_Pathology_Other_BioNum_Enabled = 1;
         Dvpanel_tableattributes_Autoscroll = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Iconposition = "left";
         Dvpanel_tableattributes_Showcollapseicon = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsed = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsible = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Title = "病理学其它信息";
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

      protected void GXDLABR_PATHOLOGY_OTHER_BIO0Y35( String AV19tCurrentCode )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLABR_PATHOLOGY_OTHER_BIO_data0Y35( AV19tCurrentCode) ;
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

      protected void GXABR_PATHOLOGY_OTHER_BIO_html0Y35( String AV19tCurrentCode )
      {
         String gxdynajaxvalue ;
         GXDLABR_PATHOLOGY_OTHER_BIO_data0Y35( AV19tCurrentCode) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynBR_Pathology_Other_Bio.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex));
            dynBR_Pathology_Other_Bio.addItem(gxdynajaxvalue, ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLABR_PATHOLOGY_OTHER_BIO_data0Y35( String AV19tCurrentCode )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         /* Using cursor T000Y14 */
         pr_default.execute(12, new Object[] {AV19tCurrentCode});
         while ( (pr_default.getStatus(12) != 101) )
         {
            gxdynajaxctrlcodr.Add(T000Y14_A168XT_DefineCodeName[0]);
            gxdynajaxctrldescr.Add(T000Y14_A168XT_DefineCodeName[0]);
            pr_default.readNext(12);
         }
         pr_default.close(12);
      }

      protected void GXDLABR_PATHOLOGY_OTHER_BIONUMUNIT0Y35( String AV19tCurrentCode )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLABR_PATHOLOGY_OTHER_BIONUMUNIT_data0Y35( AV19tCurrentCode) ;
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

      protected void GXABR_PATHOLOGY_OTHER_BIONUMUNIT_html0Y35( String AV19tCurrentCode )
      {
         String gxdynajaxvalue ;
         GXDLABR_PATHOLOGY_OTHER_BIONUMUNIT_data0Y35( AV19tCurrentCode) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynBR_Pathology_Other_BioNumUnit.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex));
            dynBR_Pathology_Other_BioNumUnit.addItem(gxdynajaxvalue, ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLABR_PATHOLOGY_OTHER_BIONUMUNIT_data0Y35( String AV19tCurrentCode )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add("");
         gxdynajaxctrldescr.Add("(请选择)");
         /* Using cursor T000Y15 */
         pr_default.execute(13, new Object[] {AV19tCurrentCode});
         while ( (pr_default.getStatus(13) != 101) )
         {
            gxdynajaxctrlcodr.Add(T000Y15_A168XT_DefineCodeName[0]);
            gxdynajaxctrldescr.Add(T000Y15_A168XT_DefineCodeName[0]);
            pr_default.readNext(13);
         }
         pr_default.close(13);
      }

      protected void GXDLABR_PATHOLOGY_OTHER_BIOQUAL0Y35( String AV19tCurrentCode )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLABR_PATHOLOGY_OTHER_BIOQUAL_data0Y35( AV19tCurrentCode) ;
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

      protected void GXABR_PATHOLOGY_OTHER_BIOQUAL_html0Y35( String AV19tCurrentCode )
      {
         String gxdynajaxvalue ;
         GXDLABR_PATHOLOGY_OTHER_BIOQUAL_data0Y35( AV19tCurrentCode) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynBR_Pathology_Other_BioQual.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex));
            dynBR_Pathology_Other_BioQual.addItem(gxdynajaxvalue, ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLABR_PATHOLOGY_OTHER_BIOQUAL_data0Y35( String AV19tCurrentCode )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         /* Using cursor T000Y16 */
         pr_default.execute(14, new Object[] {AV19tCurrentCode});
         while ( (pr_default.getStatus(14) != 101) )
         {
            gxdynajaxctrlcodr.Add(T000Y16_A168XT_DefineCodeName[0]);
            gxdynajaxctrldescr.Add(T000Y16_A168XT_DefineCodeName[0]);
            pr_default.readNext(14);
         }
         pr_default.close(14);
      }

      protected void GX11ASABR_PATHOLOGY_OTHER_ABNIND_CODE0Y35( String A295BR_Pathology_Other_AbnInd )
      {
         GXt_char1 = A509BR_Pathology_Other_AbnInd_Code;
         new zutil_findtargetcode(context ).execute(  38,  A295BR_Pathology_Other_AbnInd, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295BR_Pathology_Other_AbnInd", A295BR_Pathology_Other_AbnInd);
         A509BR_Pathology_Other_AbnInd_Code = GXt_char1;
         n509BR_Pathology_Other_AbnInd_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A509BR_Pathology_Other_AbnInd_Code", A509BR_Pathology_Other_AbnInd_Code);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A509BR_Pathology_Other_AbnInd_Code)+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GX12ASABR_PATHOLOGY_OTHER_ABNIND_CODE0Y35( String A295BR_Pathology_Other_AbnInd )
      {
         GXt_char1 = A509BR_Pathology_Other_AbnInd_Code;
         new zutil_findtargetcode(context ).execute(  38,  A295BR_Pathology_Other_AbnInd, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A295BR_Pathology_Other_AbnInd", A295BR_Pathology_Other_AbnInd);
         A509BR_Pathology_Other_AbnInd_Code = GXt_char1;
         n509BR_Pathology_Other_AbnInd_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A509BR_Pathology_Other_AbnInd_Code", A509BR_Pathology_Other_AbnInd_Code);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A509BR_Pathology_Other_AbnInd_Code)+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void XC_23_0Y35( )
      {
         new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A226BR_PathologyID), 18, 0)),  "病理学",  StringUtil.Trim( StringUtil.Str( (decimal)(A288BR_Pathology_OtherID), 18, 0)),  "其它信息",  "Create",  1) ;
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

      protected void XC_24_0Y35( )
      {
         new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A226BR_PathologyID), 18, 0)),  "病理学",  StringUtil.Trim( StringUtil.Str( (decimal)(A288BR_Pathology_OtherID), 18, 0)),  "其它信息",  "Update",  1) ;
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

      protected void XC_25_0Y35( )
      {
         new zutil_recordsonlog(context ).execute(  StringUtil.Trim( StringUtil.Str( (decimal)(A226BR_PathologyID), 18, 0)),  "病理学",  StringUtil.Trim( StringUtil.Str( (decimal)(A288BR_Pathology_OtherID), 18, 0)),  "其它信息",  "Delete",  1) ;
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
         dynBR_Pathology_Other_Bio.Name = "BR_PATHOLOGY_OTHER_BIO";
         dynBR_Pathology_Other_Bio.WebTags = "";
         dynBR_Pathology_Other_BioNumUnit.Name = "BR_PATHOLOGY_OTHER_BIONUMUNIT";
         dynBR_Pathology_Other_BioNumUnit.WebTags = "";
         dynBR_Pathology_Other_BioQual.Name = "BR_PATHOLOGY_OTHER_BIOQUAL";
         dynBR_Pathology_Other_BioQual.WebTags = "";
         /* End function init_web_controls */
      }

      public void Valid_Br_pathologyid( long GX_Parm1 )
      {
         A226BR_PathologyID = GX_Parm1;
         n226BR_PathologyID = false;
         /* Using cursor T000Y17 */
         pr_default.execute(15, new Object[] {n226BR_PathologyID, A226BR_PathologyID});
         if ( (pr_default.getStatus(15) == 101) )
         {
            if ( ! ( (0==A226BR_PathologyID) ) )
            {
               GX_msglist.addItem("不匹配' T36'", "ForeignKeyNotFound", 1, "BR_PATHOLOGYID");
               AnyError = 1;
               GX_FocusControl = edtBR_PathologyID_Internalname;
            }
         }
         pr_default.close(15);
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
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7BR_Pathology_OtherID',fld:'vBR_PATHOLOGY_OTHERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV7BR_Pathology_OtherID',fld:'vBR_PATHOLOGY_OTHERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'A288BR_Pathology_OtherID',fld:'BR_PATHOLOGY_OTHERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV19tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'AV13Insert_BR_PathologyID',fld:'vINSERT_BR_PATHOLOGYID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'A480BR_Pathology_Other_Bio_Code',fld:'BR_PATHOLOGY_OTHER_BIO_CODE',pic:''},{av:'A481BR_Pathology_Other_BioNum_Code',fld:'BR_PATHOLOGY_OTHER_BIONUM_CODE',pic:''},{av:'A482BR_Pathology_Other_BioQual_Code',fld:'BR_PATHOLOGY_OTHER_BIOQUAL_CODE',pic:''}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("AFTER TRN","{handler:'E130Y2',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV11TrnContext',fld:'vTRNCONTEXT',pic:''}]");
         setEventMetadata("AFTER TRN",",oparms:[]}");
         setEventMetadata("'DOBEIZHU'","{handler:'E110Y35',iparms:[]");
         setEventMetadata("'DOBEIZHU'",",oparms:[]}");
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
         pr_default.close(15);
      }

      public override void initialize( )
      {
         sPrefix = "";
         wcpOGx_mode = "";
         Z509BR_Pathology_Other_AbnInd_Code = "";
         Z289BR_Pathology_Other_Bio = "";
         Z480BR_Pathology_Other_Bio_Code = "";
         Z481BR_Pathology_Other_BioNum_Code = "";
         Z291BR_Pathology_Other_BioNumUnit = "";
         Z292BR_Pathology_Other_BioQual = "";
         Z482BR_Pathology_Other_BioQual_Code = "";
         Z295BR_Pathology_Other_AbnInd = "";
         scmdbuf = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV19tCurrentCode = "";
         A295BR_Pathology_Other_AbnInd = "";
         GXKey = "";
         PreviousTooltip = "";
         PreviousCaption = "";
         Form = new GXWebForm();
         GX_FocusControl = "";
         A289BR_Pathology_Other_Bio = "";
         A291BR_Pathology_Other_BioNumUnit = "";
         A292BR_Pathology_Other_BioQual = "";
         ClassString = "";
         StyleString = "";
         ucDvpanel_tableattributes = new GXUserControl();
         lblTextblockbr_pathology_other_bio_Jsonclick = "";
         lblTextblockbr_pathology_other_bionum_Jsonclick = "";
         TempTags = "";
         lblTextblockbr_pathology_other_bionumunit_Jsonclick = "";
         lblTextblockbr_pathology_other_low_Jsonclick = "";
         lblTextblockbr_pathology_other_high_Jsonclick = "";
         lblTextblockbr_pathology_other_abnind_Jsonclick = "";
         lblTextblockbr_pathology_other_bioqual_Jsonclick = "";
         bttBtntrn_enter_Jsonclick = "";
         bttBtntrn_cancel_Jsonclick = "";
         bttBtntrn_delete_Jsonclick = "";
         sStyleString = "";
         AV17vname = "";
         bttBtnbeizhu_Jsonclick = "";
         AV15bzName = "";
         A509BR_Pathology_Other_AbnInd_Code = "";
         A480BR_Pathology_Other_Bio_Code = "";
         A481BR_Pathology_Other_BioNum_Code = "";
         A482BR_Pathology_Other_BioQual_Code = "";
         AV20Pgmname = "";
         Dvpanel_tableattributes_Objectcall = "";
         Dvpanel_tableattributes_Class = "";
         Dvpanel_tableattributes_Height = "";
         forbiddenHiddens = "";
         hsh = "";
         sMode35 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV8WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV11TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV12WebSession = context.GetSession();
         AV14TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         T000Y5_A288BR_Pathology_OtherID = new long[1] ;
         T000Y5_A509BR_Pathology_Other_AbnInd_Code = new String[] {""} ;
         T000Y5_n509BR_Pathology_Other_AbnInd_Code = new bool[] {false} ;
         T000Y5_A289BR_Pathology_Other_Bio = new String[] {""} ;
         T000Y5_n289BR_Pathology_Other_Bio = new bool[] {false} ;
         T000Y5_A480BR_Pathology_Other_Bio_Code = new String[] {""} ;
         T000Y5_n480BR_Pathology_Other_Bio_Code = new bool[] {false} ;
         T000Y5_A290BR_Pathology_Other_BioNum = new decimal[1] ;
         T000Y5_n290BR_Pathology_Other_BioNum = new bool[] {false} ;
         T000Y5_A481BR_Pathology_Other_BioNum_Code = new String[] {""} ;
         T000Y5_n481BR_Pathology_Other_BioNum_Code = new bool[] {false} ;
         T000Y5_A291BR_Pathology_Other_BioNumUnit = new String[] {""} ;
         T000Y5_n291BR_Pathology_Other_BioNumUnit = new bool[] {false} ;
         T000Y5_A292BR_Pathology_Other_BioQual = new String[] {""} ;
         T000Y5_n292BR_Pathology_Other_BioQual = new bool[] {false} ;
         T000Y5_A482BR_Pathology_Other_BioQual_Code = new String[] {""} ;
         T000Y5_n482BR_Pathology_Other_BioQual_Code = new bool[] {false} ;
         T000Y5_A293BR_Pathology_Other_Low = new decimal[1] ;
         T000Y5_n293BR_Pathology_Other_Low = new bool[] {false} ;
         T000Y5_A294BR_Pathology_Other_High = new decimal[1] ;
         T000Y5_n294BR_Pathology_Other_High = new bool[] {false} ;
         T000Y5_A295BR_Pathology_Other_AbnInd = new String[] {""} ;
         T000Y5_n295BR_Pathology_Other_AbnInd = new bool[] {false} ;
         T000Y5_A226BR_PathologyID = new long[1] ;
         T000Y5_n226BR_PathologyID = new bool[] {false} ;
         T000Y4_A226BR_PathologyID = new long[1] ;
         T000Y4_n226BR_PathologyID = new bool[] {false} ;
         T000Y6_A226BR_PathologyID = new long[1] ;
         T000Y6_n226BR_PathologyID = new bool[] {false} ;
         T000Y7_A288BR_Pathology_OtherID = new long[1] ;
         T000Y3_A288BR_Pathology_OtherID = new long[1] ;
         T000Y3_A509BR_Pathology_Other_AbnInd_Code = new String[] {""} ;
         T000Y3_n509BR_Pathology_Other_AbnInd_Code = new bool[] {false} ;
         T000Y3_A289BR_Pathology_Other_Bio = new String[] {""} ;
         T000Y3_n289BR_Pathology_Other_Bio = new bool[] {false} ;
         T000Y3_A480BR_Pathology_Other_Bio_Code = new String[] {""} ;
         T000Y3_n480BR_Pathology_Other_Bio_Code = new bool[] {false} ;
         T000Y3_A290BR_Pathology_Other_BioNum = new decimal[1] ;
         T000Y3_n290BR_Pathology_Other_BioNum = new bool[] {false} ;
         T000Y3_A481BR_Pathology_Other_BioNum_Code = new String[] {""} ;
         T000Y3_n481BR_Pathology_Other_BioNum_Code = new bool[] {false} ;
         T000Y3_A291BR_Pathology_Other_BioNumUnit = new String[] {""} ;
         T000Y3_n291BR_Pathology_Other_BioNumUnit = new bool[] {false} ;
         T000Y3_A292BR_Pathology_Other_BioQual = new String[] {""} ;
         T000Y3_n292BR_Pathology_Other_BioQual = new bool[] {false} ;
         T000Y3_A482BR_Pathology_Other_BioQual_Code = new String[] {""} ;
         T000Y3_n482BR_Pathology_Other_BioQual_Code = new bool[] {false} ;
         T000Y3_A293BR_Pathology_Other_Low = new decimal[1] ;
         T000Y3_n293BR_Pathology_Other_Low = new bool[] {false} ;
         T000Y3_A294BR_Pathology_Other_High = new decimal[1] ;
         T000Y3_n294BR_Pathology_Other_High = new bool[] {false} ;
         T000Y3_A295BR_Pathology_Other_AbnInd = new String[] {""} ;
         T000Y3_n295BR_Pathology_Other_AbnInd = new bool[] {false} ;
         T000Y3_A226BR_PathologyID = new long[1] ;
         T000Y3_n226BR_PathologyID = new bool[] {false} ;
         T000Y8_A288BR_Pathology_OtherID = new long[1] ;
         T000Y9_A288BR_Pathology_OtherID = new long[1] ;
         T000Y2_A288BR_Pathology_OtherID = new long[1] ;
         T000Y2_A509BR_Pathology_Other_AbnInd_Code = new String[] {""} ;
         T000Y2_n509BR_Pathology_Other_AbnInd_Code = new bool[] {false} ;
         T000Y2_A289BR_Pathology_Other_Bio = new String[] {""} ;
         T000Y2_n289BR_Pathology_Other_Bio = new bool[] {false} ;
         T000Y2_A480BR_Pathology_Other_Bio_Code = new String[] {""} ;
         T000Y2_n480BR_Pathology_Other_Bio_Code = new bool[] {false} ;
         T000Y2_A290BR_Pathology_Other_BioNum = new decimal[1] ;
         T000Y2_n290BR_Pathology_Other_BioNum = new bool[] {false} ;
         T000Y2_A481BR_Pathology_Other_BioNum_Code = new String[] {""} ;
         T000Y2_n481BR_Pathology_Other_BioNum_Code = new bool[] {false} ;
         T000Y2_A291BR_Pathology_Other_BioNumUnit = new String[] {""} ;
         T000Y2_n291BR_Pathology_Other_BioNumUnit = new bool[] {false} ;
         T000Y2_A292BR_Pathology_Other_BioQual = new String[] {""} ;
         T000Y2_n292BR_Pathology_Other_BioQual = new bool[] {false} ;
         T000Y2_A482BR_Pathology_Other_BioQual_Code = new String[] {""} ;
         T000Y2_n482BR_Pathology_Other_BioQual_Code = new bool[] {false} ;
         T000Y2_A293BR_Pathology_Other_Low = new decimal[1] ;
         T000Y2_n293BR_Pathology_Other_Low = new bool[] {false} ;
         T000Y2_A294BR_Pathology_Other_High = new decimal[1] ;
         T000Y2_n294BR_Pathology_Other_High = new bool[] {false} ;
         T000Y2_A295BR_Pathology_Other_AbnInd = new String[] {""} ;
         T000Y2_n295BR_Pathology_Other_AbnInd = new bool[] {false} ;
         T000Y2_A226BR_PathologyID = new long[1] ;
         T000Y2_n226BR_PathologyID = new bool[] {false} ;
         T000Y10_A288BR_Pathology_OtherID = new long[1] ;
         T000Y13_A288BR_Pathology_OtherID = new long[1] ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         gxdynajaxctrlcodr = new GeneXus.Utils.GxStringCollection();
         gxdynajaxctrldescr = new GeneXus.Utils.GxStringCollection();
         gxwrpcisep = "";
         T000Y14_A167XT_DefineCodeID = new long[1] ;
         T000Y14_A168XT_DefineCodeName = new String[] {""} ;
         T000Y14_n168XT_DefineCodeName = new bool[] {false} ;
         T000Y14_A165XT_DefindcodeTypeID = new long[1] ;
         T000Y14_A432XT_TenantCode = new String[] {""} ;
         T000Y14_n432XT_TenantCode = new bool[] {false} ;
         T000Y15_A167XT_DefineCodeID = new long[1] ;
         T000Y15_A168XT_DefineCodeName = new String[] {""} ;
         T000Y15_n168XT_DefineCodeName = new bool[] {false} ;
         T000Y15_A165XT_DefindcodeTypeID = new long[1] ;
         T000Y15_A432XT_TenantCode = new String[] {""} ;
         T000Y15_n432XT_TenantCode = new bool[] {false} ;
         T000Y16_A167XT_DefineCodeID = new long[1] ;
         T000Y16_A168XT_DefineCodeName = new String[] {""} ;
         T000Y16_n168XT_DefineCodeName = new bool[] {false} ;
         T000Y16_A165XT_DefindcodeTypeID = new long[1] ;
         T000Y16_A432XT_TenantCode = new String[] {""} ;
         T000Y16_n432XT_TenantCode = new bool[] {false} ;
         GXt_char1 = "";
         T000Y17_A226BR_PathologyID = new long[1] ;
         T000Y17_n226BR_PathologyID = new bool[] {false} ;
         isValidOutput = new GxUnknownObjectCollection();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.br_pathology_other__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_pathology_other__default(),
            new Object[][] {
                new Object[] {
               T000Y2_A288BR_Pathology_OtherID, T000Y2_A509BR_Pathology_Other_AbnInd_Code, T000Y2_n509BR_Pathology_Other_AbnInd_Code, T000Y2_A289BR_Pathology_Other_Bio, T000Y2_n289BR_Pathology_Other_Bio, T000Y2_A480BR_Pathology_Other_Bio_Code, T000Y2_n480BR_Pathology_Other_Bio_Code, T000Y2_A290BR_Pathology_Other_BioNum, T000Y2_n290BR_Pathology_Other_BioNum, T000Y2_A481BR_Pathology_Other_BioNum_Code,
               T000Y2_n481BR_Pathology_Other_BioNum_Code, T000Y2_A291BR_Pathology_Other_BioNumUnit, T000Y2_n291BR_Pathology_Other_BioNumUnit, T000Y2_A292BR_Pathology_Other_BioQual, T000Y2_n292BR_Pathology_Other_BioQual, T000Y2_A482BR_Pathology_Other_BioQual_Code, T000Y2_n482BR_Pathology_Other_BioQual_Code, T000Y2_A293BR_Pathology_Other_Low, T000Y2_n293BR_Pathology_Other_Low, T000Y2_A294BR_Pathology_Other_High,
               T000Y2_n294BR_Pathology_Other_High, T000Y2_A295BR_Pathology_Other_AbnInd, T000Y2_n295BR_Pathology_Other_AbnInd, T000Y2_A226BR_PathologyID, T000Y2_n226BR_PathologyID
               }
               , new Object[] {
               T000Y3_A288BR_Pathology_OtherID, T000Y3_A509BR_Pathology_Other_AbnInd_Code, T000Y3_n509BR_Pathology_Other_AbnInd_Code, T000Y3_A289BR_Pathology_Other_Bio, T000Y3_n289BR_Pathology_Other_Bio, T000Y3_A480BR_Pathology_Other_Bio_Code, T000Y3_n480BR_Pathology_Other_Bio_Code, T000Y3_A290BR_Pathology_Other_BioNum, T000Y3_n290BR_Pathology_Other_BioNum, T000Y3_A481BR_Pathology_Other_BioNum_Code,
               T000Y3_n481BR_Pathology_Other_BioNum_Code, T000Y3_A291BR_Pathology_Other_BioNumUnit, T000Y3_n291BR_Pathology_Other_BioNumUnit, T000Y3_A292BR_Pathology_Other_BioQual, T000Y3_n292BR_Pathology_Other_BioQual, T000Y3_A482BR_Pathology_Other_BioQual_Code, T000Y3_n482BR_Pathology_Other_BioQual_Code, T000Y3_A293BR_Pathology_Other_Low, T000Y3_n293BR_Pathology_Other_Low, T000Y3_A294BR_Pathology_Other_High,
               T000Y3_n294BR_Pathology_Other_High, T000Y3_A295BR_Pathology_Other_AbnInd, T000Y3_n295BR_Pathology_Other_AbnInd, T000Y3_A226BR_PathologyID, T000Y3_n226BR_PathologyID
               }
               , new Object[] {
               T000Y4_A226BR_PathologyID
               }
               , new Object[] {
               T000Y5_A288BR_Pathology_OtherID, T000Y5_A509BR_Pathology_Other_AbnInd_Code, T000Y5_n509BR_Pathology_Other_AbnInd_Code, T000Y5_A289BR_Pathology_Other_Bio, T000Y5_n289BR_Pathology_Other_Bio, T000Y5_A480BR_Pathology_Other_Bio_Code, T000Y5_n480BR_Pathology_Other_Bio_Code, T000Y5_A290BR_Pathology_Other_BioNum, T000Y5_n290BR_Pathology_Other_BioNum, T000Y5_A481BR_Pathology_Other_BioNum_Code,
               T000Y5_n481BR_Pathology_Other_BioNum_Code, T000Y5_A291BR_Pathology_Other_BioNumUnit, T000Y5_n291BR_Pathology_Other_BioNumUnit, T000Y5_A292BR_Pathology_Other_BioQual, T000Y5_n292BR_Pathology_Other_BioQual, T000Y5_A482BR_Pathology_Other_BioQual_Code, T000Y5_n482BR_Pathology_Other_BioQual_Code, T000Y5_A293BR_Pathology_Other_Low, T000Y5_n293BR_Pathology_Other_Low, T000Y5_A294BR_Pathology_Other_High,
               T000Y5_n294BR_Pathology_Other_High, T000Y5_A295BR_Pathology_Other_AbnInd, T000Y5_n295BR_Pathology_Other_AbnInd, T000Y5_A226BR_PathologyID, T000Y5_n226BR_PathologyID
               }
               , new Object[] {
               T000Y6_A226BR_PathologyID
               }
               , new Object[] {
               T000Y7_A288BR_Pathology_OtherID
               }
               , new Object[] {
               T000Y8_A288BR_Pathology_OtherID
               }
               , new Object[] {
               T000Y9_A288BR_Pathology_OtherID
               }
               , new Object[] {
               T000Y10_A288BR_Pathology_OtherID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000Y13_A288BR_Pathology_OtherID
               }
               , new Object[] {
               T000Y14_A167XT_DefineCodeID, T000Y14_A168XT_DefineCodeName, T000Y14_n168XT_DefineCodeName, T000Y14_A165XT_DefindcodeTypeID, T000Y14_A432XT_TenantCode, T000Y14_n432XT_TenantCode
               }
               , new Object[] {
               T000Y15_A167XT_DefineCodeID, T000Y15_A168XT_DefineCodeName, T000Y15_n168XT_DefineCodeName, T000Y15_A165XT_DefindcodeTypeID, T000Y15_A432XT_TenantCode, T000Y15_n432XT_TenantCode
               }
               , new Object[] {
               T000Y16_A167XT_DefineCodeID, T000Y16_A168XT_DefineCodeName, T000Y16_n168XT_DefineCodeName, T000Y16_A165XT_DefindcodeTypeID, T000Y16_A432XT_TenantCode, T000Y16_n432XT_TenantCode
               }
               , new Object[] {
               T000Y17_A226BR_PathologyID
               }
            }
         );
         AV20Pgmname = "BR_Pathology_Other";
      }

      private short GxWebError ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short RcdFound35 ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int trnEnded ;
      private int edtBR_Pathology_Other_BioNum_Enabled ;
      private int edtBR_Pathology_Other_Low_Enabled ;
      private int edtBR_Pathology_Other_High_Enabled ;
      private int edtBR_Pathology_Other_AbnInd_Enabled ;
      private int bttBtntrn_enter_Visible ;
      private int bttBtntrn_enter_Enabled ;
      private int bttBtntrn_cancel_Visible ;
      private int bttBtntrn_delete_Visible ;
      private int bttBtntrn_delete_Enabled ;
      private int edtBR_Pathology_OtherID_Enabled ;
      private int edtBR_Pathology_OtherID_Visible ;
      private int edtBR_PathologyID_Visible ;
      private int edtBR_PathologyID_Enabled ;
      private int edtavVname_Visible ;
      private int edtavVname_Enabled ;
      private int bttBtnbeizhu_Visible ;
      private int edtavBzname_Visible ;
      private int edtavBzname_Enabled ;
      private int AV21GXV1 ;
      private int idxLst ;
      private int gxdynajaxindex ;
      private long wcpOAV7BR_Pathology_OtherID ;
      private long Z288BR_Pathology_OtherID ;
      private long Z226BR_PathologyID ;
      private long N226BR_PathologyID ;
      private long A226BR_PathologyID ;
      private long AV7BR_Pathology_OtherID ;
      private long A288BR_Pathology_OtherID ;
      private long AV13Insert_BR_PathologyID ;
      private decimal Z290BR_Pathology_Other_BioNum ;
      private decimal Z293BR_Pathology_Other_Low ;
      private decimal Z294BR_Pathology_Other_High ;
      private decimal A290BR_Pathology_Other_BioNum ;
      private decimal A293BR_Pathology_Other_Low ;
      private decimal A294BR_Pathology_Other_High ;
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
      private String dynBR_Pathology_Other_Bio_Internalname ;
      private String dynBR_Pathology_Other_BioNumUnit_Internalname ;
      private String dynBR_Pathology_Other_BioQual_Internalname ;
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
      private String divTablesplittedbr_pathology_other_bio_Internalname ;
      private String lblTextblockbr_pathology_other_bio_Internalname ;
      private String lblTextblockbr_pathology_other_bio_Jsonclick ;
      private String divUnnamedtablebr_pathology_other_bionum_Internalname ;
      private String lblTextblockbr_pathology_other_bionum_Internalname ;
      private String lblTextblockbr_pathology_other_bionum_Jsonclick ;
      private String edtBR_Pathology_Other_BioNum_Internalname ;
      private String TempTags ;
      private String edtBR_Pathology_Other_BioNum_Jsonclick ;
      private String divUnnamedtablebr_pathology_other_bionumunit_Internalname ;
      private String lblTextblockbr_pathology_other_bionumunit_Internalname ;
      private String lblTextblockbr_pathology_other_bionumunit_Jsonclick ;
      private String dynBR_Pathology_Other_BioNumUnit_Jsonclick ;
      private String divUnnamedtablebr_pathology_other_low_Internalname ;
      private String lblTextblockbr_pathology_other_low_Internalname ;
      private String lblTextblockbr_pathology_other_low_Jsonclick ;
      private String edtBR_Pathology_Other_Low_Internalname ;
      private String edtBR_Pathology_Other_Low_Jsonclick ;
      private String divUnnamedtablebr_pathology_other_high_Internalname ;
      private String lblTextblockbr_pathology_other_high_Internalname ;
      private String lblTextblockbr_pathology_other_high_Jsonclick ;
      private String edtBR_Pathology_Other_High_Internalname ;
      private String edtBR_Pathology_Other_High_Jsonclick ;
      private String divUnnamedtablebr_pathology_other_abnind_Internalname ;
      private String lblTextblockbr_pathology_other_abnind_Internalname ;
      private String lblTextblockbr_pathology_other_abnind_Jsonclick ;
      private String edtBR_Pathology_Other_AbnInd_Internalname ;
      private String edtBR_Pathology_Other_AbnInd_Jsonclick ;
      private String divTablesplittedbr_pathology_other_bioqual_Internalname ;
      private String lblTextblockbr_pathology_other_bioqual_Internalname ;
      private String lblTextblockbr_pathology_other_bioqual_Jsonclick ;
      private String bttBtntrn_enter_Internalname ;
      private String bttBtntrn_enter_Jsonclick ;
      private String bttBtntrn_cancel_Internalname ;
      private String bttBtntrn_cancel_Jsonclick ;
      private String bttBtntrn_delete_Internalname ;
      private String bttBtntrn_delete_Jsonclick ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String edtBR_Pathology_OtherID_Internalname ;
      private String edtBR_Pathology_OtherID_Jsonclick ;
      private String edtBR_PathologyID_Internalname ;
      private String edtBR_PathologyID_Jsonclick ;
      private String sStyleString ;
      private String tblTablemergedbr_pathology_other_bioqual_Internalname ;
      private String dynBR_Pathology_Other_BioQual_Jsonclick ;
      private String cellVname_cell_Internalname ;
      private String cellVname_cell_Class ;
      private String edtavVname_Internalname ;
      private String edtavVname_Jsonclick ;
      private String bttBtnbeizhu_Internalname ;
      private String bttBtnbeizhu_Jsonclick ;
      private String tblTablemergedbr_pathology_other_bio_Internalname ;
      private String dynBR_Pathology_Other_Bio_Jsonclick ;
      private String cellBzname_cell_Internalname ;
      private String cellBzname_cell_Class ;
      private String edtavBzname_Internalname ;
      private String edtavBzname_Jsonclick ;
      private String AV20Pgmname ;
      private String Dvpanel_tableattributes_Objectcall ;
      private String Dvpanel_tableattributes_Class ;
      private String Dvpanel_tableattributes_Height ;
      private String forbiddenHiddens ;
      private String hsh ;
      private String sMode35 ;
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
      private bool n295BR_Pathology_Other_AbnInd ;
      private bool n226BR_PathologyID ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool n289BR_Pathology_Other_Bio ;
      private bool n291BR_Pathology_Other_BioNumUnit ;
      private bool n292BR_Pathology_Other_BioQual ;
      private bool Dvpanel_tableattributes_Autowidth ;
      private bool Dvpanel_tableattributes_Autoheight ;
      private bool Dvpanel_tableattributes_Collapsible ;
      private bool Dvpanel_tableattributes_Collapsed ;
      private bool Dvpanel_tableattributes_Showcollapseicon ;
      private bool Dvpanel_tableattributes_Autoscroll ;
      private bool n290BR_Pathology_Other_BioNum ;
      private bool n293BR_Pathology_Other_Low ;
      private bool n294BR_Pathology_Other_High ;
      private bool n509BR_Pathology_Other_AbnInd_Code ;
      private bool n480BR_Pathology_Other_Bio_Code ;
      private bool n481BR_Pathology_Other_BioNum_Code ;
      private bool n482BR_Pathology_Other_BioQual_Code ;
      private bool Dvpanel_tableattributes_Enabled ;
      private bool Dvpanel_tableattributes_Showheader ;
      private bool Dvpanel_tableattributes_Visible ;
      private bool AV9IsAuthorized ;
      private bool returnInSub ;
      private bool AV18TempBoolean ;
      private bool GXt_boolean2 ;
      private bool Gx_longc ;
      private bool gxdyncontrolsrefreshing ;
      private String Z509BR_Pathology_Other_AbnInd_Code ;
      private String Z289BR_Pathology_Other_Bio ;
      private String Z480BR_Pathology_Other_Bio_Code ;
      private String Z481BR_Pathology_Other_BioNum_Code ;
      private String Z291BR_Pathology_Other_BioNumUnit ;
      private String Z292BR_Pathology_Other_BioQual ;
      private String Z482BR_Pathology_Other_BioQual_Code ;
      private String Z295BR_Pathology_Other_AbnInd ;
      private String AV19tCurrentCode ;
      private String A295BR_Pathology_Other_AbnInd ;
      private String A289BR_Pathology_Other_Bio ;
      private String A291BR_Pathology_Other_BioNumUnit ;
      private String A292BR_Pathology_Other_BioQual ;
      private String AV17vname ;
      private String AV15bzName ;
      private String A509BR_Pathology_Other_AbnInd_Code ;
      private String A480BR_Pathology_Other_Bio_Code ;
      private String A481BR_Pathology_Other_BioNum_Code ;
      private String A482BR_Pathology_Other_BioQual_Code ;
      private IGxSession AV12WebSession ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrlcodr ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrldescr ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXUserControl ucDvpanel_tableattributes ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private GXCombobox dynBR_Pathology_Other_Bio ;
      private GXCombobox dynBR_Pathology_Other_BioNumUnit ;
      private GXCombobox dynBR_Pathology_Other_BioQual ;
      private IDataStoreProvider pr_default ;
      private long[] T000Y5_A288BR_Pathology_OtherID ;
      private String[] T000Y5_A509BR_Pathology_Other_AbnInd_Code ;
      private bool[] T000Y5_n509BR_Pathology_Other_AbnInd_Code ;
      private String[] T000Y5_A289BR_Pathology_Other_Bio ;
      private bool[] T000Y5_n289BR_Pathology_Other_Bio ;
      private String[] T000Y5_A480BR_Pathology_Other_Bio_Code ;
      private bool[] T000Y5_n480BR_Pathology_Other_Bio_Code ;
      private decimal[] T000Y5_A290BR_Pathology_Other_BioNum ;
      private bool[] T000Y5_n290BR_Pathology_Other_BioNum ;
      private String[] T000Y5_A481BR_Pathology_Other_BioNum_Code ;
      private bool[] T000Y5_n481BR_Pathology_Other_BioNum_Code ;
      private String[] T000Y5_A291BR_Pathology_Other_BioNumUnit ;
      private bool[] T000Y5_n291BR_Pathology_Other_BioNumUnit ;
      private String[] T000Y5_A292BR_Pathology_Other_BioQual ;
      private bool[] T000Y5_n292BR_Pathology_Other_BioQual ;
      private String[] T000Y5_A482BR_Pathology_Other_BioQual_Code ;
      private bool[] T000Y5_n482BR_Pathology_Other_BioQual_Code ;
      private decimal[] T000Y5_A293BR_Pathology_Other_Low ;
      private bool[] T000Y5_n293BR_Pathology_Other_Low ;
      private decimal[] T000Y5_A294BR_Pathology_Other_High ;
      private bool[] T000Y5_n294BR_Pathology_Other_High ;
      private String[] T000Y5_A295BR_Pathology_Other_AbnInd ;
      private bool[] T000Y5_n295BR_Pathology_Other_AbnInd ;
      private long[] T000Y5_A226BR_PathologyID ;
      private bool[] T000Y5_n226BR_PathologyID ;
      private long[] T000Y4_A226BR_PathologyID ;
      private bool[] T000Y4_n226BR_PathologyID ;
      private long[] T000Y6_A226BR_PathologyID ;
      private bool[] T000Y6_n226BR_PathologyID ;
      private long[] T000Y7_A288BR_Pathology_OtherID ;
      private long[] T000Y3_A288BR_Pathology_OtherID ;
      private String[] T000Y3_A509BR_Pathology_Other_AbnInd_Code ;
      private bool[] T000Y3_n509BR_Pathology_Other_AbnInd_Code ;
      private String[] T000Y3_A289BR_Pathology_Other_Bio ;
      private bool[] T000Y3_n289BR_Pathology_Other_Bio ;
      private String[] T000Y3_A480BR_Pathology_Other_Bio_Code ;
      private bool[] T000Y3_n480BR_Pathology_Other_Bio_Code ;
      private decimal[] T000Y3_A290BR_Pathology_Other_BioNum ;
      private bool[] T000Y3_n290BR_Pathology_Other_BioNum ;
      private String[] T000Y3_A481BR_Pathology_Other_BioNum_Code ;
      private bool[] T000Y3_n481BR_Pathology_Other_BioNum_Code ;
      private String[] T000Y3_A291BR_Pathology_Other_BioNumUnit ;
      private bool[] T000Y3_n291BR_Pathology_Other_BioNumUnit ;
      private String[] T000Y3_A292BR_Pathology_Other_BioQual ;
      private bool[] T000Y3_n292BR_Pathology_Other_BioQual ;
      private String[] T000Y3_A482BR_Pathology_Other_BioQual_Code ;
      private bool[] T000Y3_n482BR_Pathology_Other_BioQual_Code ;
      private decimal[] T000Y3_A293BR_Pathology_Other_Low ;
      private bool[] T000Y3_n293BR_Pathology_Other_Low ;
      private decimal[] T000Y3_A294BR_Pathology_Other_High ;
      private bool[] T000Y3_n294BR_Pathology_Other_High ;
      private String[] T000Y3_A295BR_Pathology_Other_AbnInd ;
      private bool[] T000Y3_n295BR_Pathology_Other_AbnInd ;
      private long[] T000Y3_A226BR_PathologyID ;
      private bool[] T000Y3_n226BR_PathologyID ;
      private long[] T000Y8_A288BR_Pathology_OtherID ;
      private long[] T000Y9_A288BR_Pathology_OtherID ;
      private long[] T000Y2_A288BR_Pathology_OtherID ;
      private String[] T000Y2_A509BR_Pathology_Other_AbnInd_Code ;
      private bool[] T000Y2_n509BR_Pathology_Other_AbnInd_Code ;
      private String[] T000Y2_A289BR_Pathology_Other_Bio ;
      private bool[] T000Y2_n289BR_Pathology_Other_Bio ;
      private String[] T000Y2_A480BR_Pathology_Other_Bio_Code ;
      private bool[] T000Y2_n480BR_Pathology_Other_Bio_Code ;
      private decimal[] T000Y2_A290BR_Pathology_Other_BioNum ;
      private bool[] T000Y2_n290BR_Pathology_Other_BioNum ;
      private String[] T000Y2_A481BR_Pathology_Other_BioNum_Code ;
      private bool[] T000Y2_n481BR_Pathology_Other_BioNum_Code ;
      private String[] T000Y2_A291BR_Pathology_Other_BioNumUnit ;
      private bool[] T000Y2_n291BR_Pathology_Other_BioNumUnit ;
      private String[] T000Y2_A292BR_Pathology_Other_BioQual ;
      private bool[] T000Y2_n292BR_Pathology_Other_BioQual ;
      private String[] T000Y2_A482BR_Pathology_Other_BioQual_Code ;
      private bool[] T000Y2_n482BR_Pathology_Other_BioQual_Code ;
      private decimal[] T000Y2_A293BR_Pathology_Other_Low ;
      private bool[] T000Y2_n293BR_Pathology_Other_Low ;
      private decimal[] T000Y2_A294BR_Pathology_Other_High ;
      private bool[] T000Y2_n294BR_Pathology_Other_High ;
      private String[] T000Y2_A295BR_Pathology_Other_AbnInd ;
      private bool[] T000Y2_n295BR_Pathology_Other_AbnInd ;
      private long[] T000Y2_A226BR_PathologyID ;
      private bool[] T000Y2_n226BR_PathologyID ;
      private long[] T000Y10_A288BR_Pathology_OtherID ;
      private long[] T000Y13_A288BR_Pathology_OtherID ;
      private long[] T000Y14_A167XT_DefineCodeID ;
      private String[] T000Y14_A168XT_DefineCodeName ;
      private bool[] T000Y14_n168XT_DefineCodeName ;
      private long[] T000Y14_A165XT_DefindcodeTypeID ;
      private String[] T000Y14_A432XT_TenantCode ;
      private bool[] T000Y14_n432XT_TenantCode ;
      private long[] T000Y15_A167XT_DefineCodeID ;
      private String[] T000Y15_A168XT_DefineCodeName ;
      private bool[] T000Y15_n168XT_DefineCodeName ;
      private long[] T000Y15_A165XT_DefindcodeTypeID ;
      private String[] T000Y15_A432XT_TenantCode ;
      private bool[] T000Y15_n432XT_TenantCode ;
      private long[] T000Y16_A167XT_DefineCodeID ;
      private String[] T000Y16_A168XT_DefineCodeName ;
      private bool[] T000Y16_n168XT_DefineCodeName ;
      private long[] T000Y16_A165XT_DefindcodeTypeID ;
      private String[] T000Y16_A432XT_TenantCode ;
      private bool[] T000Y16_n432XT_TenantCode ;
      private long[] T000Y17_A226BR_PathologyID ;
      private bool[] T000Y17_n226BR_PathologyID ;
      private IDataStoreProvider pr_datastore1 ;
      private GXWebForm Form ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV8WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV11TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute AV14TrnContextAtt ;
   }

   public class br_pathology_other__datastore1 : DataStoreHelperBase, IDataStoreHelper
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

 public class br_pathology_other__default : DataStoreHelperBase, IDataStoreHelper
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
       ,new ForEachCursor(def[15])
     };
  }

  private static CursorDef[] def;
  private void cursorDefinitions( )
  {
     if ( def == null )
     {
        Object[] prmT000Y5 ;
        prmT000Y5 = new Object[] {
        new Object[] {"@BR_Pathology_OtherID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000Y4 ;
        prmT000Y4 = new Object[] {
        new Object[] {"@BR_PathologyID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000Y6 ;
        prmT000Y6 = new Object[] {
        new Object[] {"@BR_PathologyID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000Y7 ;
        prmT000Y7 = new Object[] {
        new Object[] {"@BR_Pathology_OtherID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000Y3 ;
        prmT000Y3 = new Object[] {
        new Object[] {"@BR_Pathology_OtherID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000Y8 ;
        prmT000Y8 = new Object[] {
        new Object[] {"@BR_Pathology_OtherID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000Y9 ;
        prmT000Y9 = new Object[] {
        new Object[] {"@BR_Pathology_OtherID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000Y2 ;
        prmT000Y2 = new Object[] {
        new Object[] {"@BR_Pathology_OtherID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000Y10 ;
        prmT000Y10 = new Object[] {
        new Object[] {"@BR_Pathology_Other_AbnInd_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Pathology_Other_Bio",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Pathology_Other_Bio_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Pathology_Other_BioNum",SqlDbType.Decimal,15,5} ,
        new Object[] {"@BR_Pathology_Other_BioNum_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Pathology_Other_BioNumUnit",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Pathology_Other_BioQual",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Pathology_Other_BioQual_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Pathology_Other_Low",SqlDbType.Decimal,15,5} ,
        new Object[] {"@BR_Pathology_Other_High",SqlDbType.Decimal,15,5} ,
        new Object[] {"@BR_Pathology_Other_AbnInd",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_PathologyID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000Y11 ;
        prmT000Y11 = new Object[] {
        new Object[] {"@BR_Pathology_Other_AbnInd_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Pathology_Other_Bio",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Pathology_Other_Bio_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Pathology_Other_BioNum",SqlDbType.Decimal,15,5} ,
        new Object[] {"@BR_Pathology_Other_BioNum_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Pathology_Other_BioNumUnit",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Pathology_Other_BioQual",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Pathology_Other_BioQual_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Pathology_Other_Low",SqlDbType.Decimal,15,5} ,
        new Object[] {"@BR_Pathology_Other_High",SqlDbType.Decimal,15,5} ,
        new Object[] {"@BR_Pathology_Other_AbnInd",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_PathologyID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@BR_Pathology_OtherID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000Y12 ;
        prmT000Y12 = new Object[] {
        new Object[] {"@BR_Pathology_OtherID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000Y13 ;
        prmT000Y13 = new Object[] {
        } ;
        Object[] prmT000Y14 ;
        prmT000Y14 = new Object[] {
        new Object[] {"@AV19tCurrentCode",SqlDbType.NVarChar,40,0}
        } ;
        Object[] prmT000Y15 ;
        prmT000Y15 = new Object[] {
        new Object[] {"@AV19tCurrentCode",SqlDbType.NVarChar,40,0}
        } ;
        Object[] prmT000Y16 ;
        prmT000Y16 = new Object[] {
        new Object[] {"@AV19tCurrentCode",SqlDbType.NVarChar,40,0}
        } ;
        Object[] prmT000Y17 ;
        prmT000Y17 = new Object[] {
        new Object[] {"@BR_PathologyID",SqlDbType.Decimal,18,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("T000Y2", "SELECT [BR_Pathology_OtherID], [BR_Pathology_Other_AbnInd_Code], [BR_Pathology_Other_Bio], [BR_Pathology_Other_Bio_Code], [BR_Pathology_Other_BioNum], [BR_Pathology_Other_BioNum_Code], [BR_Pathology_Other_BioNumUnit], [BR_Pathology_Other_BioQual], [BR_Pathology_Other_BioQual_Code], [BR_Pathology_Other_Low], [BR_Pathology_Other_High], [BR_Pathology_Other_AbnInd], [BR_PathologyID] FROM [BR_Pathology_Other] WITH (UPDLOCK) WHERE [BR_Pathology_OtherID] = @BR_Pathology_OtherID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Y2,1,0,true,false )
           ,new CursorDef("T000Y3", "SELECT [BR_Pathology_OtherID], [BR_Pathology_Other_AbnInd_Code], [BR_Pathology_Other_Bio], [BR_Pathology_Other_Bio_Code], [BR_Pathology_Other_BioNum], [BR_Pathology_Other_BioNum_Code], [BR_Pathology_Other_BioNumUnit], [BR_Pathology_Other_BioQual], [BR_Pathology_Other_BioQual_Code], [BR_Pathology_Other_Low], [BR_Pathology_Other_High], [BR_Pathology_Other_AbnInd], [BR_PathologyID] FROM [BR_Pathology_Other] WITH (NOLOCK) WHERE [BR_Pathology_OtherID] = @BR_Pathology_OtherID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Y3,1,0,true,false )
           ,new CursorDef("T000Y4", "SELECT [BR_PathologyID] FROM [BR_Pathology] WITH (NOLOCK) WHERE [BR_PathologyID] = @BR_PathologyID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Y4,1,0,true,false )
           ,new CursorDef("T000Y5", "SELECT TM1.[BR_Pathology_OtherID], TM1.[BR_Pathology_Other_AbnInd_Code], TM1.[BR_Pathology_Other_Bio], TM1.[BR_Pathology_Other_Bio_Code], TM1.[BR_Pathology_Other_BioNum], TM1.[BR_Pathology_Other_BioNum_Code], TM1.[BR_Pathology_Other_BioNumUnit], TM1.[BR_Pathology_Other_BioQual], TM1.[BR_Pathology_Other_BioQual_Code], TM1.[BR_Pathology_Other_Low], TM1.[BR_Pathology_Other_High], TM1.[BR_Pathology_Other_AbnInd], TM1.[BR_PathologyID] FROM [BR_Pathology_Other] TM1 WITH (NOLOCK) WHERE TM1.[BR_Pathology_OtherID] = @BR_Pathology_OtherID ORDER BY TM1.[BR_Pathology_OtherID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000Y5,100,0,true,false )
           ,new CursorDef("T000Y6", "SELECT [BR_PathologyID] FROM [BR_Pathology] WITH (NOLOCK) WHERE [BR_PathologyID] = @BR_PathologyID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Y6,1,0,true,false )
           ,new CursorDef("T000Y7", "SELECT [BR_Pathology_OtherID] FROM [BR_Pathology_Other] WITH (NOLOCK) WHERE [BR_Pathology_OtherID] = @BR_Pathology_OtherID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000Y7,1,0,true,false )
           ,new CursorDef("T000Y8", "SELECT TOP 1 [BR_Pathology_OtherID] FROM [BR_Pathology_Other] WITH (NOLOCK) WHERE ( [BR_Pathology_OtherID] > @BR_Pathology_OtherID) ORDER BY [BR_Pathology_OtherID]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000Y8,1,0,true,true )
           ,new CursorDef("T000Y9", "SELECT TOP 1 [BR_Pathology_OtherID] FROM [BR_Pathology_Other] WITH (NOLOCK) WHERE ( [BR_Pathology_OtherID] < @BR_Pathology_OtherID) ORDER BY [BR_Pathology_OtherID] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000Y9,1,0,true,true )
           ,new CursorDef("T000Y10", "INSERT INTO [BR_Pathology_Other]([BR_Pathology_Other_AbnInd_Code], [BR_Pathology_Other_Bio], [BR_Pathology_Other_Bio_Code], [BR_Pathology_Other_BioNum], [BR_Pathology_Other_BioNum_Code], [BR_Pathology_Other_BioNumUnit], [BR_Pathology_Other_BioQual], [BR_Pathology_Other_BioQual_Code], [BR_Pathology_Other_Low], [BR_Pathology_Other_High], [BR_Pathology_Other_AbnInd], [BR_PathologyID]) VALUES(@BR_Pathology_Other_AbnInd_Code, @BR_Pathology_Other_Bio, @BR_Pathology_Other_Bio_Code, @BR_Pathology_Other_BioNum, @BR_Pathology_Other_BioNum_Code, @BR_Pathology_Other_BioNumUnit, @BR_Pathology_Other_BioQual, @BR_Pathology_Other_BioQual_Code, @BR_Pathology_Other_Low, @BR_Pathology_Other_High, @BR_Pathology_Other_AbnInd, @BR_PathologyID); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmT000Y10)
           ,new CursorDef("T000Y11", "UPDATE [BR_Pathology_Other] SET [BR_Pathology_Other_AbnInd_Code]=@BR_Pathology_Other_AbnInd_Code, [BR_Pathology_Other_Bio]=@BR_Pathology_Other_Bio, [BR_Pathology_Other_Bio_Code]=@BR_Pathology_Other_Bio_Code, [BR_Pathology_Other_BioNum]=@BR_Pathology_Other_BioNum, [BR_Pathology_Other_BioNum_Code]=@BR_Pathology_Other_BioNum_Code, [BR_Pathology_Other_BioNumUnit]=@BR_Pathology_Other_BioNumUnit, [BR_Pathology_Other_BioQual]=@BR_Pathology_Other_BioQual, [BR_Pathology_Other_BioQual_Code]=@BR_Pathology_Other_BioQual_Code, [BR_Pathology_Other_Low]=@BR_Pathology_Other_Low, [BR_Pathology_Other_High]=@BR_Pathology_Other_High, [BR_Pathology_Other_AbnInd]=@BR_Pathology_Other_AbnInd, [BR_PathologyID]=@BR_PathologyID  WHERE [BR_Pathology_OtherID] = @BR_Pathology_OtherID", GxErrorMask.GX_NOMASK,prmT000Y11)
           ,new CursorDef("T000Y12", "DELETE FROM [BR_Pathology_Other]  WHERE [BR_Pathology_OtherID] = @BR_Pathology_OtherID", GxErrorMask.GX_NOMASK,prmT000Y12)
           ,new CursorDef("T000Y13", "SELECT [BR_Pathology_OtherID] FROM [BR_Pathology_Other] WITH (NOLOCK) ORDER BY [BR_Pathology_OtherID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000Y13,100,0,true,false )
           ,new CursorDef("T000Y14", "SELECT [XT_DefineCodeID], [XT_DefineCodeName], [XT_DefindcodeTypeID], [XT_TenantCode] FROM [XT_DefineCode] WITH (NOLOCK) WHERE ([XT_DefindcodeTypeID] = 35) AND ([XT_TenantCode] = @AV19tCurrentCode) ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Y14,0,0,true,false )
           ,new CursorDef("T000Y15", "SELECT [XT_DefineCodeID], [XT_DefineCodeName], [XT_DefindcodeTypeID], [XT_TenantCode] FROM [XT_DefineCode] WITH (NOLOCK) WHERE ([XT_DefindcodeTypeID] = 28) AND ([XT_TenantCode] = @AV19tCurrentCode) ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Y15,0,0,true,false )
           ,new CursorDef("T000Y16", "SELECT [XT_DefineCodeID], [XT_DefineCodeName], [XT_DefindcodeTypeID], [XT_TenantCode] FROM [XT_DefineCode] WITH (NOLOCK) WHERE ([XT_DefindcodeTypeID] = 36) AND ([XT_TenantCode] = @AV19tCurrentCode) ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Y16,0,0,true,false )
           ,new CursorDef("T000Y17", "SELECT [BR_PathologyID] FROM [BR_Pathology] WITH (NOLOCK) WHERE [BR_PathologyID] = @BR_PathologyID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000Y17,1,0,true,false )
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
              ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              ((String[]) buf[13])[0] = rslt.getVarchar(8) ;
              ((bool[]) buf[14])[0] = rslt.wasNull(8);
              ((String[]) buf[15])[0] = rslt.getVarchar(9) ;
              ((bool[]) buf[16])[0] = rslt.wasNull(9);
              ((decimal[]) buf[17])[0] = rslt.getDecimal(10) ;
              ((bool[]) buf[18])[0] = rslt.wasNull(10);
              ((decimal[]) buf[19])[0] = rslt.getDecimal(11) ;
              ((bool[]) buf[20])[0] = rslt.wasNull(11);
              ((String[]) buf[21])[0] = rslt.getVarchar(12) ;
              ((bool[]) buf[22])[0] = rslt.wasNull(12);
              ((long[]) buf[23])[0] = rslt.getLong(13) ;
              ((bool[]) buf[24])[0] = rslt.wasNull(13);
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
              ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              ((String[]) buf[13])[0] = rslt.getVarchar(8) ;
              ((bool[]) buf[14])[0] = rslt.wasNull(8);
              ((String[]) buf[15])[0] = rslt.getVarchar(9) ;
              ((bool[]) buf[16])[0] = rslt.wasNull(9);
              ((decimal[]) buf[17])[0] = rslt.getDecimal(10) ;
              ((bool[]) buf[18])[0] = rslt.wasNull(10);
              ((decimal[]) buf[19])[0] = rslt.getDecimal(11) ;
              ((bool[]) buf[20])[0] = rslt.wasNull(11);
              ((String[]) buf[21])[0] = rslt.getVarchar(12) ;
              ((bool[]) buf[22])[0] = rslt.wasNull(12);
              ((long[]) buf[23])[0] = rslt.getLong(13) ;
              ((bool[]) buf[24])[0] = rslt.wasNull(13);
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
              ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
              ((bool[]) buf[12])[0] = rslt.wasNull(7);
              ((String[]) buf[13])[0] = rslt.getVarchar(8) ;
              ((bool[]) buf[14])[0] = rslt.wasNull(8);
              ((String[]) buf[15])[0] = rslt.getVarchar(9) ;
              ((bool[]) buf[16])[0] = rslt.wasNull(9);
              ((decimal[]) buf[17])[0] = rslt.getDecimal(10) ;
              ((bool[]) buf[18])[0] = rslt.wasNull(10);
              ((decimal[]) buf[19])[0] = rslt.getDecimal(11) ;
              ((bool[]) buf[20])[0] = rslt.wasNull(11);
              ((String[]) buf[21])[0] = rslt.getVarchar(12) ;
              ((bool[]) buf[22])[0] = rslt.wasNull(12);
              ((long[]) buf[23])[0] = rslt.getLong(13) ;
              ((bool[]) buf[24])[0] = rslt.wasNull(13);
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
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((long[]) buf[3])[0] = rslt.getLong(3) ;
              ((String[]) buf[4])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[5])[0] = rslt.wasNull(4);
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
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((long[]) buf[3])[0] = rslt.getLong(3) ;
              ((String[]) buf[4])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[5])[0] = rslt.wasNull(4);
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
                 stmt.setNull( 9 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(9, (decimal)parms[17]);
              }
              if ( (bool)parms[18] )
              {
                 stmt.setNull( 10 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(10, (decimal)parms[19]);
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
                 stmt.setNull( 12 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(12, (long)parms[23]);
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
                 stmt.setNull( 9 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(9, (decimal)parms[17]);
              }
              if ( (bool)parms[18] )
              {
                 stmt.setNull( 10 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(10, (decimal)parms[19]);
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
                 stmt.setNull( 12 , SqlDbType.Decimal );
              }
              else
              {
                 stmt.SetParameter(12, (long)parms[23]);
              }
              stmt.SetParameter(13, (long)parms[24]);
              return;
           case 10 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 12 :
              stmt.SetParameter(1, (String)parms[0]);
              return;
           case 13 :
              stmt.SetParameter(1, (String)parms[0]);
              return;
           case 14 :
              stmt.SetParameter(1, (String)parms[0]);
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
     }
  }

}

}
