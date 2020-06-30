/*
               File: BR_Demographics
        Description: 人口信息学
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 11:55:45.62
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
   public class br_demographics : GXDataArea, System.Web.SessionState.IRequiresSessionState
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
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"BR_DEMOGRAPHICS_SEX") == 0 )
         {
            AV15tCurrentCode = GetNextPar( );
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15tCurrentCode", AV15tCurrentCode);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GXDLABR_DEMOGRAPHICS_SEX0B12( AV15tCurrentCode) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"BR_DEMOGRAPHICS_MARRITALSTATUS") == 0 )
         {
            AV15tCurrentCode = GetNextPar( );
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15tCurrentCode", AV15tCurrentCode);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GXDLABR_DEMOGRAPHICS_MARRITALSTATUS0B12( AV15tCurrentCode) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"BR_DEMOGRAPHICS_ETHNIC") == 0 )
         {
            AV15tCurrentCode = GetNextPar( );
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15tCurrentCode", AV15tCurrentCode);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GXDLABR_DEMOGRAPHICS_ETHNIC0B12( AV15tCurrentCode) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"BR_DEMOGRAPHICS_EDUCATION") == 0 )
         {
            AV15tCurrentCode = GetNextPar( );
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15tCurrentCode", AV15tCurrentCode);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GXDLABR_DEMOGRAPHICS_EDUCATION0B12( AV15tCurrentCode) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"BR_DEMOGRAPHICS_INSURANCE") == 0 )
         {
            AV15tCurrentCode = GetNextPar( );
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15tCurrentCode", AV15tCurrentCode);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GXDLABR_DEMOGRAPHICS_INSURANCE0B12( AV15tCurrentCode) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel8"+"_"+"BR_DEMOGRAPHICS_SEX_CODE") == 0 )
         {
            A54BR_Demographics_Sex = GetNextPar( );
            n54BR_Demographics_Sex = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A54BR_Demographics_Sex", A54BR_Demographics_Sex);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX8ASABR_DEMOGRAPHICS_SEX_CODE0B12( A54BR_Demographics_Sex) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel9"+"_"+"BR_DEMOGRAPHICS_SEX_CODE") == 0 )
         {
            A54BR_Demographics_Sex = GetNextPar( );
            n54BR_Demographics_Sex = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A54BR_Demographics_Sex", A54BR_Demographics_Sex);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX9ASABR_DEMOGRAPHICS_SEX_CODE0B12( A54BR_Demographics_Sex) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel10"+"_"+"BR_DEMOGRAPHICS_MARRITALSTATUS_CODE") == 0 )
         {
            A63BR_Demographics_MarritalStatus = GetNextPar( );
            n63BR_Demographics_MarritalStatus = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A63BR_Demographics_MarritalStatus", A63BR_Demographics_MarritalStatus);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX10ASABR_DEMOGRAPHICS_MARRITALSTATUS_CODE0B12( A63BR_Demographics_MarritalStatus) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel11"+"_"+"BR_DEMOGRAPHICS_MARRITALSTATUS_CODE") == 0 )
         {
            A63BR_Demographics_MarritalStatus = GetNextPar( );
            n63BR_Demographics_MarritalStatus = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A63BR_Demographics_MarritalStatus", A63BR_Demographics_MarritalStatus);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX11ASABR_DEMOGRAPHICS_MARRITALSTATUS_CODE0B12( A63BR_Demographics_MarritalStatus) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel12"+"_"+"BR_DEMOGRAPHICS_ETHNIC_CODE") == 0 )
         {
            A55BR_Demographics_Ethnic = GetNextPar( );
            n55BR_Demographics_Ethnic = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A55BR_Demographics_Ethnic", A55BR_Demographics_Ethnic);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX12ASABR_DEMOGRAPHICS_ETHNIC_CODE0B12( A55BR_Demographics_Ethnic) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel13"+"_"+"BR_DEMOGRAPHICS_ETHNIC_CODE") == 0 )
         {
            A55BR_Demographics_Ethnic = GetNextPar( );
            n55BR_Demographics_Ethnic = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A55BR_Demographics_Ethnic", A55BR_Demographics_Ethnic);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX13ASABR_DEMOGRAPHICS_ETHNIC_CODE0B12( A55BR_Demographics_Ethnic) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel14"+"_"+"BR_DEMOGRAPHICS_EDUCATION_CODE") == 0 )
         {
            A56BR_Demographics_Education = GetNextPar( );
            n56BR_Demographics_Education = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A56BR_Demographics_Education", A56BR_Demographics_Education);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX14ASABR_DEMOGRAPHICS_EDUCATION_CODE0B12( A56BR_Demographics_Education) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel15"+"_"+"BR_DEMOGRAPHICS_EDUCATION_CODE") == 0 )
         {
            A56BR_Demographics_Education = GetNextPar( );
            n56BR_Demographics_Education = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A56BR_Demographics_Education", A56BR_Demographics_Education);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX15ASABR_DEMOGRAPHICS_EDUCATION_CODE0B12( A56BR_Demographics_Education) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel16"+"_"+"BR_DEMOGRAPHICS_INSURANCE_CODE") == 0 )
         {
            A58BR_Demographics_Insurance = GetNextPar( );
            n58BR_Demographics_Insurance = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A58BR_Demographics_Insurance", A58BR_Demographics_Insurance);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX16ASABR_DEMOGRAPHICS_INSURANCE_CODE0B12( A58BR_Demographics_Insurance) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxAggSel17"+"_"+"BR_DEMOGRAPHICS_INSURANCE_CODE") == 0 )
         {
            A58BR_Demographics_Insurance = GetNextPar( );
            n58BR_Demographics_Insurance = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A58BR_Demographics_Insurance", A58BR_Demographics_Insurance);
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1;
               return  ;
            }
            GX17ASABR_DEMOGRAPHICS_INSURANCE_CODE0B12( A58BR_Demographics_Insurance) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_26") == 0 )
         {
            A19BR_EncounterID = (long)(NumberUtil.Val( GetNextPar( ), "."));
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
               AV12BR_Demographics_ID = (long)(NumberUtil.Val( GetNextPar( ), "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12BR_Demographics_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12BR_Demographics_ID), 18, 0)));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vBR_DEMOGRAPHICS_ID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV12BR_Demographics_ID), "ZZZZZZZZZZZZZZZZZZ"), context));
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
            Form.Meta.addItem("description", "人口信息学", 0) ;
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

      public br_demographics( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_demographics( IGxContext context )
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
                           long aP1_BR_Demographics_ID )
      {
         this.Gx_mode = aP0_Gx_mode;
         this.AV12BR_Demographics_ID = aP1_BR_Demographics_ID;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         dynBR_Demographics_Sex = new GXCombobox();
         dynBR_Demographics_MarritalStatus = new GXCombobox();
         dynBR_Demographics_Ethnic = new GXCombobox();
         dynBR_Demographics_Education = new GXCombobox();
         dynBR_Demographics_Insurance = new GXCombobox();
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
         if ( dynBR_Demographics_Sex.ItemCount > 0 )
         {
            A54BR_Demographics_Sex = dynBR_Demographics_Sex.getValidValue(A54BR_Demographics_Sex);
            n54BR_Demographics_Sex = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A54BR_Demographics_Sex", A54BR_Demographics_Sex);
         }
         if ( context.isAjaxRequest( ) )
         {
            dynBR_Demographics_Sex.CurrentValue = StringUtil.RTrim( A54BR_Demographics_Sex);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynBR_Demographics_Sex_Internalname, "Values", dynBR_Demographics_Sex.ToJavascriptSource(), true);
         }
         if ( dynBR_Demographics_MarritalStatus.ItemCount > 0 )
         {
            A63BR_Demographics_MarritalStatus = dynBR_Demographics_MarritalStatus.getValidValue(A63BR_Demographics_MarritalStatus);
            n63BR_Demographics_MarritalStatus = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A63BR_Demographics_MarritalStatus", A63BR_Demographics_MarritalStatus);
         }
         if ( context.isAjaxRequest( ) )
         {
            dynBR_Demographics_MarritalStatus.CurrentValue = StringUtil.RTrim( A63BR_Demographics_MarritalStatus);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynBR_Demographics_MarritalStatus_Internalname, "Values", dynBR_Demographics_MarritalStatus.ToJavascriptSource(), true);
         }
         if ( dynBR_Demographics_Ethnic.ItemCount > 0 )
         {
            A55BR_Demographics_Ethnic = dynBR_Demographics_Ethnic.getValidValue(A55BR_Demographics_Ethnic);
            n55BR_Demographics_Ethnic = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A55BR_Demographics_Ethnic", A55BR_Demographics_Ethnic);
         }
         if ( context.isAjaxRequest( ) )
         {
            dynBR_Demographics_Ethnic.CurrentValue = StringUtil.RTrim( A55BR_Demographics_Ethnic);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynBR_Demographics_Ethnic_Internalname, "Values", dynBR_Demographics_Ethnic.ToJavascriptSource(), true);
         }
         if ( dynBR_Demographics_Education.ItemCount > 0 )
         {
            A56BR_Demographics_Education = dynBR_Demographics_Education.getValidValue(A56BR_Demographics_Education);
            n56BR_Demographics_Education = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A56BR_Demographics_Education", A56BR_Demographics_Education);
         }
         if ( context.isAjaxRequest( ) )
         {
            dynBR_Demographics_Education.CurrentValue = StringUtil.RTrim( A56BR_Demographics_Education);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynBR_Demographics_Education_Internalname, "Values", dynBR_Demographics_Education.ToJavascriptSource(), true);
         }
         if ( dynBR_Demographics_Insurance.ItemCount > 0 )
         {
            A58BR_Demographics_Insurance = dynBR_Demographics_Insurance.getValidValue(A58BR_Demographics_Insurance);
            n58BR_Demographics_Insurance = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A58BR_Demographics_Insurance", A58BR_Demographics_Insurance);
         }
         if ( context.isAjaxRequest( ) )
         {
            dynBR_Demographics_Insurance.CurrentValue = StringUtil.RTrim( A58BR_Demographics_Insurance);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynBR_Demographics_Insurance_Internalname, "Values", dynBR_Demographics_Insurance.ToJavascriptSource(), true);
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_Demographics_ID_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Demographics_ID_Internalname, "人口信息学主键", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Demographics_ID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A61BR_Demographics_ID), 18, 0, ".", "")), ((edtBR_Demographics_ID_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(A61BR_Demographics_ID), "ZZZZZZZZZZZZZZZZZZ")) : context.localUtil.Format( (decimal)(A61BR_Demographics_ID), "ZZZZZZZZZZZZZZZZZZ")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Demographics_ID_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBR_Demographics_ID_Enabled, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "HLP_BR_Demographics.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_EncounterID_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_EncounterID_Internalname, "就诊信息主键", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_EncounterID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A19BR_EncounterID), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(A19BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,29);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_EncounterID_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBR_EncounterID_Enabled, 1, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "HLP_BR_Demographics.htm");
            /* Static images/pictures */
            ClassString = "gx-prompt Image";
            StyleString = "";
            sImgUrl = (String)(context.GetImagePath( "f5b04895-0024-488b-8e3b-b687ca4598ee", "", context.GetTheme( )));
            GxWebStd.gx_bitmap( context, imgprompt_19_Internalname, sImgUrl, imgprompt_19_Link, "", "", context.GetTheme( ), imgprompt_19_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "", "", "", 1, false, false, context.GetImageSrcSet( sImgUrl), "HLP_BR_Demographics.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_Information_PatientNo_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Information_PatientNo_Internalname, "患者编号", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_Information_PatientNo_Internalname, A36BR_Information_PatientNo, StringUtil.RTrim( context.localUtil.Format( A36BR_Information_PatientNo, "")), "", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Information_PatientNo_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBR_Information_PatientNo_Enabled, 0, "text", "", 80, "chr", 1, "row", 2000, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Demographics.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_Demographics_BirthDate_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Demographics_BirthDate_Internalname, "出生日期", "col-sm-3 AttributeDateLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"";
            context.WriteHtmlText( "<div id=\""+edtBR_Demographics_BirthDate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtBR_Demographics_BirthDate_Internalname, context.localUtil.Format(A53BR_Demographics_BirthDate, "9999/99/99"), context.localUtil.Format( A53BR_Demographics_BirthDate, "9999/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',0,24,'chs',false,0);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,38);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Demographics_BirthDate_Jsonclick, 0, "AttributeDate", "", "", "", "", 1, edtBR_Demographics_BirthDate_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "DM_Date", "right", false, "HLP_BR_Demographics.htm");
            GxWebStd.gx_bitmap( context, edtBR_Demographics_BirthDate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtBR_Demographics_BirthDate_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_Demographics.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 RequiredDataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+dynBR_Demographics_Sex_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynBR_Demographics_Sex_Internalname, "性别", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynBR_Demographics_Sex, dynBR_Demographics_Sex_Internalname, StringUtil.RTrim( A54BR_Demographics_Sex), 1, dynBR_Demographics_Sex_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, dynBR_Demographics_Sex.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,43);\"", "", true, "HLP_BR_Demographics.htm");
            dynBR_Demographics_Sex.CurrentValue = StringUtil.RTrim( A54BR_Demographics_Sex);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynBR_Demographics_Sex_Internalname, "Values", (String)(dynBR_Demographics_Sex.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+dynBR_Demographics_MarritalStatus_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynBR_Demographics_MarritalStatus_Internalname, "婚姻状态", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 47,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynBR_Demographics_MarritalStatus, dynBR_Demographics_MarritalStatus_Internalname, StringUtil.RTrim( A63BR_Demographics_MarritalStatus), 1, dynBR_Demographics_MarritalStatus_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, dynBR_Demographics_MarritalStatus.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,47);\"", "", true, "HLP_BR_Demographics.htm");
            dynBR_Demographics_MarritalStatus.CurrentValue = StringUtil.RTrim( A63BR_Demographics_MarritalStatus);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynBR_Demographics_MarritalStatus_Internalname, "Values", (String)(dynBR_Demographics_MarritalStatus.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+dynBR_Demographics_Ethnic_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynBR_Demographics_Ethnic_Internalname, "民族", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 52,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynBR_Demographics_Ethnic, dynBR_Demographics_Ethnic_Internalname, StringUtil.RTrim( A55BR_Demographics_Ethnic), 1, dynBR_Demographics_Ethnic_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, dynBR_Demographics_Ethnic.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,52);\"", "", true, "HLP_BR_Demographics.htm");
            dynBR_Demographics_Ethnic.CurrentValue = StringUtil.RTrim( A55BR_Demographics_Ethnic);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynBR_Demographics_Ethnic_Internalname, "Values", (String)(dynBR_Demographics_Ethnic.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+dynBR_Demographics_Education_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynBR_Demographics_Education_Internalname, "学历", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 56,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynBR_Demographics_Education, dynBR_Demographics_Education_Internalname, StringUtil.RTrim( A56BR_Demographics_Education), 1, dynBR_Demographics_Education_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, dynBR_Demographics_Education.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,56);\"", "", true, "HLP_BR_Demographics.htm");
            dynBR_Demographics_Education.CurrentValue = StringUtil.RTrim( A56BR_Demographics_Education);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynBR_Demographics_Education_Internalname, "Values", (String)(dynBR_Demographics_Education.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_Demographics_Occupation_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Demographics_Occupation_Internalname, "职业", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 61,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_Demographics_Occupation_Internalname, A57BR_Demographics_Occupation, StringUtil.RTrim( context.localUtil.Format( A57BR_Demographics_Occupation, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,61);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Demographics_Occupation_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBR_Demographics_Occupation_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Demographics.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+dynBR_Demographics_Insurance_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, dynBR_Demographics_Insurance_Internalname, "保险类型", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 65,'',false,'',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynBR_Demographics_Insurance, dynBR_Demographics_Insurance_Internalname, StringUtil.RTrim( A58BR_Demographics_Insurance), 1, dynBR_Demographics_Insurance_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "svchar", "", 1, dynBR_Demographics_Insurance.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,65);\"", "", true, "HLP_BR_Demographics.htm");
            dynBR_Demographics_Insurance.CurrentValue = StringUtil.RTrim( A58BR_Demographics_Insurance);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynBR_Demographics_Insurance_Internalname, "Values", (String)(dynBR_Demographics_Insurance.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_Demographics_Province_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Demographics_Province_Internalname, "省", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 70,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_Demographics_Province_Internalname, A59BR_Demographics_Province, StringUtil.RTrim( context.localUtil.Format( A59BR_Demographics_Province, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,70);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Demographics_Province_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBR_Demographics_Province_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Demographics.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6 DataContentCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtBR_Demographics_City_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtBR_Demographics_City_Internalname, "市", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 74,'',false,'',0)\"";
            GxWebStd.gx_single_line_edit( context, edtBR_Demographics_City_Internalname, A60BR_Demographics_City, StringUtil.RTrim( context.localUtil.Format( A60BR_Demographics_City, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,74);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_Demographics_City_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtBR_Demographics_City_Enabled, 0, "text", "", 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_Demographics.htm");
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 79,'',false,'',0)\"";
            ClassString = "ButtonMaterial";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_enter_Internalname, "", "确认", bttBtntrn_enter_Jsonclick, 5, "确认", "", StyleString, ClassString, bttBtntrn_enter_Visible, bttBtntrn_enter_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EENTER."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_Demographics.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 81,'',false,'',0)\"";
            ClassString = "ButtonMaterialDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_cancel_Internalname, "", "取消", bttBtntrn_cancel_Jsonclick, 1, "取消", "", StyleString, ClassString, bttBtntrn_cancel_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"ECANCEL."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_Demographics.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 83,'',false,'',0)\"";
            ClassString = "ButtonMaterialDefault";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtntrn_delete_Internalname, "", "删除", bttBtntrn_delete_Jsonclick, 5, "删除", "", StyleString, ClassString, bttBtntrn_delete_Visible, bttBtntrn_delete_Enabled, "standard", "'"+""+"'"+",false,"+"'"+"EDELETE."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_Demographics.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
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
         E110B2 ();
         context.wbGlbDoneStart = 1;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
               A61BR_Demographics_ID = (long)(context.localUtil.CToN( cgiGet( edtBR_Demographics_ID_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A61BR_Demographics_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A61BR_Demographics_ID), 18, 0)));
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
               if ( context.localUtil.VCDate( cgiGet( edtBR_Demographics_BirthDate_Internalname), 0) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"出生日期"}), 1, "BR_DEMOGRAPHICS_BIRTHDATE");
                  AnyError = 1;
                  GX_FocusControl = edtBR_Demographics_BirthDate_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true;
                  A53BR_Demographics_BirthDate = DateTime.MinValue;
                  n53BR_Demographics_BirthDate = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A53BR_Demographics_BirthDate", context.localUtil.Format(A53BR_Demographics_BirthDate, "9999/99/99"));
               }
               else
               {
                  A53BR_Demographics_BirthDate = context.localUtil.CToD( cgiGet( edtBR_Demographics_BirthDate_Internalname), 0);
                  n53BR_Demographics_BirthDate = false;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A53BR_Demographics_BirthDate", context.localUtil.Format(A53BR_Demographics_BirthDate, "9999/99/99"));
               }
               n53BR_Demographics_BirthDate = ((DateTime.MinValue==A53BR_Demographics_BirthDate) ? true : false);
               dynBR_Demographics_Sex.CurrentValue = cgiGet( dynBR_Demographics_Sex_Internalname);
               A54BR_Demographics_Sex = cgiGet( dynBR_Demographics_Sex_Internalname);
               n54BR_Demographics_Sex = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A54BR_Demographics_Sex", A54BR_Demographics_Sex);
               n54BR_Demographics_Sex = (String.IsNullOrEmpty(StringUtil.RTrim( A54BR_Demographics_Sex)) ? true : false);
               dynBR_Demographics_MarritalStatus.CurrentValue = cgiGet( dynBR_Demographics_MarritalStatus_Internalname);
               A63BR_Demographics_MarritalStatus = cgiGet( dynBR_Demographics_MarritalStatus_Internalname);
               n63BR_Demographics_MarritalStatus = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A63BR_Demographics_MarritalStatus", A63BR_Demographics_MarritalStatus);
               n63BR_Demographics_MarritalStatus = (String.IsNullOrEmpty(StringUtil.RTrim( A63BR_Demographics_MarritalStatus)) ? true : false);
               dynBR_Demographics_Ethnic.CurrentValue = cgiGet( dynBR_Demographics_Ethnic_Internalname);
               A55BR_Demographics_Ethnic = cgiGet( dynBR_Demographics_Ethnic_Internalname);
               n55BR_Demographics_Ethnic = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A55BR_Demographics_Ethnic", A55BR_Demographics_Ethnic);
               n55BR_Demographics_Ethnic = (String.IsNullOrEmpty(StringUtil.RTrim( A55BR_Demographics_Ethnic)) ? true : false);
               dynBR_Demographics_Education.CurrentValue = cgiGet( dynBR_Demographics_Education_Internalname);
               A56BR_Demographics_Education = cgiGet( dynBR_Demographics_Education_Internalname);
               n56BR_Demographics_Education = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A56BR_Demographics_Education", A56BR_Demographics_Education);
               n56BR_Demographics_Education = (String.IsNullOrEmpty(StringUtil.RTrim( A56BR_Demographics_Education)) ? true : false);
               A57BR_Demographics_Occupation = cgiGet( edtBR_Demographics_Occupation_Internalname);
               n57BR_Demographics_Occupation = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A57BR_Demographics_Occupation", A57BR_Demographics_Occupation);
               n57BR_Demographics_Occupation = (String.IsNullOrEmpty(StringUtil.RTrim( A57BR_Demographics_Occupation)) ? true : false);
               dynBR_Demographics_Insurance.CurrentValue = cgiGet( dynBR_Demographics_Insurance_Internalname);
               A58BR_Demographics_Insurance = cgiGet( dynBR_Demographics_Insurance_Internalname);
               n58BR_Demographics_Insurance = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A58BR_Demographics_Insurance", A58BR_Demographics_Insurance);
               n58BR_Demographics_Insurance = (String.IsNullOrEmpty(StringUtil.RTrim( A58BR_Demographics_Insurance)) ? true : false);
               A59BR_Demographics_Province = cgiGet( edtBR_Demographics_Province_Internalname);
               n59BR_Demographics_Province = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A59BR_Demographics_Province", A59BR_Demographics_Province);
               n59BR_Demographics_Province = (String.IsNullOrEmpty(StringUtil.RTrim( A59BR_Demographics_Province)) ? true : false);
               A60BR_Demographics_City = cgiGet( edtBR_Demographics_City_Internalname);
               n60BR_Demographics_City = false;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A60BR_Demographics_City", A60BR_Demographics_City);
               n60BR_Demographics_City = (String.IsNullOrEmpty(StringUtil.RTrim( A60BR_Demographics_City)) ? true : false);
               /* Read saved values. */
               Z61BR_Demographics_ID = (long)(context.localUtil.CToN( cgiGet( "Z61BR_Demographics_ID"), ".", ","));
               Z455BR_Demographics_Sex_Code = cgiGet( "Z455BR_Demographics_Sex_Code");
               n455BR_Demographics_Sex_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A455BR_Demographics_Sex_Code)) ? true : false);
               Z456BR_Demographics_MarritalStatus_Code = cgiGet( "Z456BR_Demographics_MarritalStatus_Code");
               n456BR_Demographics_MarritalStatus_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A456BR_Demographics_MarritalStatus_Code)) ? true : false);
               Z457BR_Demographics_Ethnic_Code = cgiGet( "Z457BR_Demographics_Ethnic_Code");
               n457BR_Demographics_Ethnic_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A457BR_Demographics_Ethnic_Code)) ? true : false);
               Z458BR_Demographics_Education_Code = cgiGet( "Z458BR_Demographics_Education_Code");
               n458BR_Demographics_Education_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A458BR_Demographics_Education_Code)) ? true : false);
               Z459BR_Demographics_Insurance_Code = cgiGet( "Z459BR_Demographics_Insurance_Code");
               n459BR_Demographics_Insurance_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A459BR_Demographics_Insurance_Code)) ? true : false);
               Z53BR_Demographics_BirthDate = context.localUtil.CToD( cgiGet( "Z53BR_Demographics_BirthDate"), 0);
               n53BR_Demographics_BirthDate = ((DateTime.MinValue==A53BR_Demographics_BirthDate) ? true : false);
               Z54BR_Demographics_Sex = cgiGet( "Z54BR_Demographics_Sex");
               n54BR_Demographics_Sex = (String.IsNullOrEmpty(StringUtil.RTrim( A54BR_Demographics_Sex)) ? true : false);
               Z63BR_Demographics_MarritalStatus = cgiGet( "Z63BR_Demographics_MarritalStatus");
               n63BR_Demographics_MarritalStatus = (String.IsNullOrEmpty(StringUtil.RTrim( A63BR_Demographics_MarritalStatus)) ? true : false);
               Z55BR_Demographics_Ethnic = cgiGet( "Z55BR_Demographics_Ethnic");
               n55BR_Demographics_Ethnic = (String.IsNullOrEmpty(StringUtil.RTrim( A55BR_Demographics_Ethnic)) ? true : false);
               Z56BR_Demographics_Education = cgiGet( "Z56BR_Demographics_Education");
               n56BR_Demographics_Education = (String.IsNullOrEmpty(StringUtil.RTrim( A56BR_Demographics_Education)) ? true : false);
               Z57BR_Demographics_Occupation = cgiGet( "Z57BR_Demographics_Occupation");
               n57BR_Demographics_Occupation = (String.IsNullOrEmpty(StringUtil.RTrim( A57BR_Demographics_Occupation)) ? true : false);
               Z58BR_Demographics_Insurance = cgiGet( "Z58BR_Demographics_Insurance");
               n58BR_Demographics_Insurance = (String.IsNullOrEmpty(StringUtil.RTrim( A58BR_Demographics_Insurance)) ? true : false);
               Z59BR_Demographics_Province = cgiGet( "Z59BR_Demographics_Province");
               n59BR_Demographics_Province = (String.IsNullOrEmpty(StringUtil.RTrim( A59BR_Demographics_Province)) ? true : false);
               Z60BR_Demographics_City = cgiGet( "Z60BR_Demographics_City");
               n60BR_Demographics_City = (String.IsNullOrEmpty(StringUtil.RTrim( A60BR_Demographics_City)) ? true : false);
               Z19BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( "Z19BR_EncounterID"), ".", ","));
               A455BR_Demographics_Sex_Code = cgiGet( "Z455BR_Demographics_Sex_Code");
               n455BR_Demographics_Sex_Code = false;
               n455BR_Demographics_Sex_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A455BR_Demographics_Sex_Code)) ? true : false);
               A456BR_Demographics_MarritalStatus_Code = cgiGet( "Z456BR_Demographics_MarritalStatus_Code");
               n456BR_Demographics_MarritalStatus_Code = false;
               n456BR_Demographics_MarritalStatus_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A456BR_Demographics_MarritalStatus_Code)) ? true : false);
               A457BR_Demographics_Ethnic_Code = cgiGet( "Z457BR_Demographics_Ethnic_Code");
               n457BR_Demographics_Ethnic_Code = false;
               n457BR_Demographics_Ethnic_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A457BR_Demographics_Ethnic_Code)) ? true : false);
               A458BR_Demographics_Education_Code = cgiGet( "Z458BR_Demographics_Education_Code");
               n458BR_Demographics_Education_Code = false;
               n458BR_Demographics_Education_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A458BR_Demographics_Education_Code)) ? true : false);
               A459BR_Demographics_Insurance_Code = cgiGet( "Z459BR_Demographics_Insurance_Code");
               n459BR_Demographics_Insurance_Code = false;
               n459BR_Demographics_Insurance_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A459BR_Demographics_Insurance_Code)) ? true : false);
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ".", ","));
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ".", ","));
               Gx_mode = cgiGet( "Mode");
               N19BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( "N19BR_EncounterID"), ".", ","));
               AV12BR_Demographics_ID = (long)(context.localUtil.CToN( cgiGet( "vBR_DEMOGRAPHICS_ID"), ".", ","));
               AV10Insert_BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( "vINSERT_BR_ENCOUNTERID"), ".", ","));
               A455BR_Demographics_Sex_Code = cgiGet( "BR_DEMOGRAPHICS_SEX_CODE");
               n455BR_Demographics_Sex_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A455BR_Demographics_Sex_Code)) ? true : false);
               A456BR_Demographics_MarritalStatus_Code = cgiGet( "BR_DEMOGRAPHICS_MARRITALSTATUS_CODE");
               n456BR_Demographics_MarritalStatus_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A456BR_Demographics_MarritalStatus_Code)) ? true : false);
               A457BR_Demographics_Ethnic_Code = cgiGet( "BR_DEMOGRAPHICS_ETHNIC_CODE");
               n457BR_Demographics_Ethnic_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A457BR_Demographics_Ethnic_Code)) ? true : false);
               A458BR_Demographics_Education_Code = cgiGet( "BR_DEMOGRAPHICS_EDUCATION_CODE");
               n458BR_Demographics_Education_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A458BR_Demographics_Education_Code)) ? true : false);
               A459BR_Demographics_Insurance_Code = cgiGet( "BR_DEMOGRAPHICS_INSURANCE_CODE");
               n459BR_Demographics_Insurance_Code = (String.IsNullOrEmpty(StringUtil.RTrim( A459BR_Demographics_Insurance_Code)) ? true : false);
               AV15tCurrentCode = cgiGet( "vTCURRENTCODE");
               A85BR_Information_ID = (long)(context.localUtil.CToN( cgiGet( "BR_INFORMATION_ID"), ".", ","));
               AV16Pgmname = cgiGet( "vPGMNAME");
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
               forbiddenHiddens = "hsh" + "BR_Demographics";
               A61BR_Demographics_ID = (long)(context.localUtil.CToN( cgiGet( edtBR_Demographics_ID_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A61BR_Demographics_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A61BR_Demographics_ID), 18, 0)));
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A61BR_Demographics_ID), "ZZZZZZZZZZZZZZZZZZ");
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( AV15tCurrentCode, ""));
               forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV10Insert_BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ");
               forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
               hsh = cgiGet( "hsh");
               if ( ( ! ( ( A61BR_Demographics_ID != Z61BR_Demographics_ID ) ) || ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) ) && ! GXUtil.CheckEncryptedHash( forbiddenHiddens, hsh, GXKey) )
               {
                  GXUtil.WriteLog("br_demographics:[SecurityCheckFailed value for]"+"BR_Demographics_ID:"+context.localUtil.Format( (decimal)(A61BR_Demographics_ID), "ZZZZZZZZZZZZZZZZZZ"));
                  GXUtil.WriteLog("br_demographics:[SecurityCheckFailed value for]"+"tCurrentCode:"+StringUtil.RTrim( context.localUtil.Format( AV15tCurrentCode, "")));
                  GXUtil.WriteLog("br_demographics:[SecurityCheckFailed value for]"+"Insert_BR_EncounterID:"+context.localUtil.Format( (decimal)(AV10Insert_BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ"));
                  GXUtil.WriteLog("br_demographics:[SecurityCheckFailed value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
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
                  A61BR_Demographics_ID = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A61BR_Demographics_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A61BR_Demographics_ID), 18, 0)));
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
                     sMode12 = Gx_mode;
                     Gx_mode = "UPD";
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                     Gx_mode = sMode12;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
                  }
                  standaloneModal( ) ;
                  if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
                  {
                     getByPrimaryKey( ) ;
                     if ( RcdFound12 == 1 )
                     {
                        if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                        {
                           /* Confirm record */
                           CONFIRM_0B0( ) ;
                           if ( AnyError == 0 )
                           {
                              GX_FocusControl = bttBtntrn_enter_Internalname;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noinsert", ""), 1, "BR_DEMOGRAPHICS_ID");
                        AnyError = 1;
                        GX_FocusControl = edtBR_Demographics_ID_Internalname;
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
                           E110B2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "AFTER TRN") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           /* Execute user event: After Trn */
                           E120B2 ();
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
            E120B2 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll0B12( ) ;
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
            DisableAttributes0B12( ) ;
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

      protected void CONFIRM_0B0( )
      {
         BeforeValidate0B12( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0B12( ) ;
            }
            else
            {
               CheckExtendedTable0B12( ) ;
               CloseExtendedTableCursors0B12( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "IsConfirmed", StringUtil.LTrim( StringUtil.Str( (decimal)(IsConfirmed), 4, 0)));
         }
      }

      protected void ResetCaption0B0( )
      {
      }

      protected void E110B2( )
      {
         /* Start Routine */
         GXt_char1 = AV15tCurrentCode;
         new zbr_getcurrenttcode(context ).execute( out  GXt_char1) ;
         AV15tCurrentCode = GXt_char1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15tCurrentCode", AV15tCurrentCode);
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV7WWPContext) ;
         AV13IsAuthorized = true;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13IsAuthorized", AV13IsAuthorized);
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            GXt_boolean2 = AV13IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Demographics", out  GXt_boolean2) ;
            AV13IsAuthorized = GXt_boolean2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13IsAuthorized", AV13IsAuthorized);
         }
         if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
         {
            GXt_boolean2 = AV13IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Demographics", out  GXt_boolean2) ;
            AV13IsAuthorized = GXt_boolean2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13IsAuthorized", AV13IsAuthorized);
         }
         if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
         {
            GXt_boolean2 = AV13IsAuthorized;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Demographics", out  GXt_boolean2) ;
            AV13IsAuthorized = GXt_boolean2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13IsAuthorized", AV13IsAuthorized);
         }
         if ( ! AV13IsAuthorized )
         {
            CallWebObject(formatLink("wwpbaseobjects.notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV16Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         AV8TrnContext.FromXml(AV9WebSession.Get("TrnContext"), null, "WWPTransactionContext", "DataAnalysisPlatform");
         if ( ( StringUtil.StrCmp(AV8TrnContext.gxTpr_Transactionname, AV16Pgmname) == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) )
         {
            AV17GXV1 = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17GXV1), 8, 0)));
            while ( AV17GXV1 <= AV8TrnContext.gxTpr_Attributes.Count )
            {
               AV11TrnContextAtt = ((GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute)AV8TrnContext.gxTpr_Attributes.Item(AV17GXV1));
               if ( StringUtil.StrCmp(AV11TrnContextAtt.gxTpr_Attributename, "BR_EncounterID") == 0 )
               {
                  AV10Insert_BR_EncounterID = (long)(NumberUtil.Val( AV11TrnContextAtt.gxTpr_Attributevalue, "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10Insert_BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10Insert_BR_EncounterID), 18, 0)));
               }
               AV17GXV1 = (int)(AV17GXV1+1);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17GXV1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17GXV1), 8, 0)));
            }
         }
      }

      protected void E120B2( )
      {
         /* After Trn Routine */
         if ( ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) && ! AV8TrnContext.gxTpr_Callerondelete )
         {
            CallWebObject(formatLink("br_demographicsww.aspx") );
            context.wjLocDisableFrm = 1;
         }
         context.setWebReturnParms(new Object[] {});
         context.setWebReturnParmsMetadata(new Object[] {});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
      }

      protected void ZM0B12( short GX_JID )
      {
         if ( ( GX_JID == 25 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z455BR_Demographics_Sex_Code = T000B3_A455BR_Demographics_Sex_Code[0];
               Z456BR_Demographics_MarritalStatus_Code = T000B3_A456BR_Demographics_MarritalStatus_Code[0];
               Z457BR_Demographics_Ethnic_Code = T000B3_A457BR_Demographics_Ethnic_Code[0];
               Z458BR_Demographics_Education_Code = T000B3_A458BR_Demographics_Education_Code[0];
               Z459BR_Demographics_Insurance_Code = T000B3_A459BR_Demographics_Insurance_Code[0];
               Z53BR_Demographics_BirthDate = T000B3_A53BR_Demographics_BirthDate[0];
               Z54BR_Demographics_Sex = T000B3_A54BR_Demographics_Sex[0];
               Z63BR_Demographics_MarritalStatus = T000B3_A63BR_Demographics_MarritalStatus[0];
               Z55BR_Demographics_Ethnic = T000B3_A55BR_Demographics_Ethnic[0];
               Z56BR_Demographics_Education = T000B3_A56BR_Demographics_Education[0];
               Z57BR_Demographics_Occupation = T000B3_A57BR_Demographics_Occupation[0];
               Z58BR_Demographics_Insurance = T000B3_A58BR_Demographics_Insurance[0];
               Z59BR_Demographics_Province = T000B3_A59BR_Demographics_Province[0];
               Z60BR_Demographics_City = T000B3_A60BR_Demographics_City[0];
               Z19BR_EncounterID = T000B3_A19BR_EncounterID[0];
            }
            else
            {
               Z455BR_Demographics_Sex_Code = A455BR_Demographics_Sex_Code;
               Z456BR_Demographics_MarritalStatus_Code = A456BR_Demographics_MarritalStatus_Code;
               Z457BR_Demographics_Ethnic_Code = A457BR_Demographics_Ethnic_Code;
               Z458BR_Demographics_Education_Code = A458BR_Demographics_Education_Code;
               Z459BR_Demographics_Insurance_Code = A459BR_Demographics_Insurance_Code;
               Z53BR_Demographics_BirthDate = A53BR_Demographics_BirthDate;
               Z54BR_Demographics_Sex = A54BR_Demographics_Sex;
               Z63BR_Demographics_MarritalStatus = A63BR_Demographics_MarritalStatus;
               Z55BR_Demographics_Ethnic = A55BR_Demographics_Ethnic;
               Z56BR_Demographics_Education = A56BR_Demographics_Education;
               Z57BR_Demographics_Occupation = A57BR_Demographics_Occupation;
               Z58BR_Demographics_Insurance = A58BR_Demographics_Insurance;
               Z59BR_Demographics_Province = A59BR_Demographics_Province;
               Z60BR_Demographics_City = A60BR_Demographics_City;
               Z19BR_EncounterID = A19BR_EncounterID;
            }
         }
         if ( GX_JID == -25 )
         {
            Z61BR_Demographics_ID = A61BR_Demographics_ID;
            Z455BR_Demographics_Sex_Code = A455BR_Demographics_Sex_Code;
            Z456BR_Demographics_MarritalStatus_Code = A456BR_Demographics_MarritalStatus_Code;
            Z457BR_Demographics_Ethnic_Code = A457BR_Demographics_Ethnic_Code;
            Z458BR_Demographics_Education_Code = A458BR_Demographics_Education_Code;
            Z459BR_Demographics_Insurance_Code = A459BR_Demographics_Insurance_Code;
            Z53BR_Demographics_BirthDate = A53BR_Demographics_BirthDate;
            Z54BR_Demographics_Sex = A54BR_Demographics_Sex;
            Z63BR_Demographics_MarritalStatus = A63BR_Demographics_MarritalStatus;
            Z55BR_Demographics_Ethnic = A55BR_Demographics_Ethnic;
            Z56BR_Demographics_Education = A56BR_Demographics_Education;
            Z57BR_Demographics_Occupation = A57BR_Demographics_Occupation;
            Z58BR_Demographics_Insurance = A58BR_Demographics_Insurance;
            Z59BR_Demographics_Province = A59BR_Demographics_Province;
            Z60BR_Demographics_City = A60BR_Demographics_City;
            Z19BR_EncounterID = A19BR_EncounterID;
            Z85BR_Information_ID = A85BR_Information_ID;
            Z36BR_Information_PatientNo = A36BR_Information_PatientNo;
         }
      }

      protected void standaloneNotModal( )
      {
         edtBR_Demographics_ID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Demographics_ID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Demographics_ID_Enabled), 5, 0)), true);
         imgprompt_19_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"br_encounterprompt.aspx"+"',["+"{Ctrl:gx.dom.el('"+"BR_ENCOUNTERID"+"'), id:'"+"BR_ENCOUNTERID"+"'"+",IOType:'inout'}"+"],"+"null"+","+"'', false"+","+"false"+");");
         edtBR_Demographics_ID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Demographics_ID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Demographics_ID_Enabled), 5, 0)), true);
         bttBtntrn_delete_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtntrn_delete_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtntrn_delete_Enabled), 5, 0)), true);
         if ( ! (0==AV12BR_Demographics_ID) )
         {
            A61BR_Demographics_ID = AV12BR_Demographics_ID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A61BR_Demographics_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A61BR_Demographics_ID), 18, 0)));
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
         GXABR_DEMOGRAPHICS_SEX_html0B12( AV15tCurrentCode) ;
         GXABR_DEMOGRAPHICS_MARRITALSTATUS_html0B12( AV15tCurrentCode) ;
         GXABR_DEMOGRAPHICS_ETHNIC_html0B12( AV15tCurrentCode) ;
         GXABR_DEMOGRAPHICS_EDUCATION_html0B12( AV15tCurrentCode) ;
         GXABR_DEMOGRAPHICS_INSURANCE_html0B12( AV15tCurrentCode) ;
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
            AV16Pgmname = "BR_Demographics";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16Pgmname", AV16Pgmname);
            /* Using cursor T000B4 */
            pr_default.execute(2, new Object[] {A19BR_EncounterID});
            A85BR_Information_ID = T000B4_A85BR_Information_ID[0];
            n85BR_Information_ID = T000B4_n85BR_Information_ID[0];
            pr_default.close(2);
            /* Using cursor T000B5 */
            pr_default.execute(3, new Object[] {n85BR_Information_ID, A85BR_Information_ID});
            A36BR_Information_PatientNo = T000B5_A36BR_Information_PatientNo[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36BR_Information_PatientNo", A36BR_Information_PatientNo);
            n36BR_Information_PatientNo = T000B5_n36BR_Information_PatientNo[0];
            pr_default.close(3);
         }
      }

      protected void Load0B12( )
      {
         /* Using cursor T000B6 */
         pr_default.execute(4, new Object[] {A61BR_Demographics_ID});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound12 = 1;
            A85BR_Information_ID = T000B6_A85BR_Information_ID[0];
            n85BR_Information_ID = T000B6_n85BR_Information_ID[0];
            A455BR_Demographics_Sex_Code = T000B6_A455BR_Demographics_Sex_Code[0];
            n455BR_Demographics_Sex_Code = T000B6_n455BR_Demographics_Sex_Code[0];
            A456BR_Demographics_MarritalStatus_Code = T000B6_A456BR_Demographics_MarritalStatus_Code[0];
            n456BR_Demographics_MarritalStatus_Code = T000B6_n456BR_Demographics_MarritalStatus_Code[0];
            A457BR_Demographics_Ethnic_Code = T000B6_A457BR_Demographics_Ethnic_Code[0];
            n457BR_Demographics_Ethnic_Code = T000B6_n457BR_Demographics_Ethnic_Code[0];
            A458BR_Demographics_Education_Code = T000B6_A458BR_Demographics_Education_Code[0];
            n458BR_Demographics_Education_Code = T000B6_n458BR_Demographics_Education_Code[0];
            A459BR_Demographics_Insurance_Code = T000B6_A459BR_Demographics_Insurance_Code[0];
            n459BR_Demographics_Insurance_Code = T000B6_n459BR_Demographics_Insurance_Code[0];
            A36BR_Information_PatientNo = T000B6_A36BR_Information_PatientNo[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36BR_Information_PatientNo", A36BR_Information_PatientNo);
            n36BR_Information_PatientNo = T000B6_n36BR_Information_PatientNo[0];
            A53BR_Demographics_BirthDate = T000B6_A53BR_Demographics_BirthDate[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A53BR_Demographics_BirthDate", context.localUtil.Format(A53BR_Demographics_BirthDate, "9999/99/99"));
            n53BR_Demographics_BirthDate = T000B6_n53BR_Demographics_BirthDate[0];
            A54BR_Demographics_Sex = T000B6_A54BR_Demographics_Sex[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A54BR_Demographics_Sex", A54BR_Demographics_Sex);
            n54BR_Demographics_Sex = T000B6_n54BR_Demographics_Sex[0];
            A63BR_Demographics_MarritalStatus = T000B6_A63BR_Demographics_MarritalStatus[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A63BR_Demographics_MarritalStatus", A63BR_Demographics_MarritalStatus);
            n63BR_Demographics_MarritalStatus = T000B6_n63BR_Demographics_MarritalStatus[0];
            A55BR_Demographics_Ethnic = T000B6_A55BR_Demographics_Ethnic[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A55BR_Demographics_Ethnic", A55BR_Demographics_Ethnic);
            n55BR_Demographics_Ethnic = T000B6_n55BR_Demographics_Ethnic[0];
            A56BR_Demographics_Education = T000B6_A56BR_Demographics_Education[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A56BR_Demographics_Education", A56BR_Demographics_Education);
            n56BR_Demographics_Education = T000B6_n56BR_Demographics_Education[0];
            A57BR_Demographics_Occupation = T000B6_A57BR_Demographics_Occupation[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A57BR_Demographics_Occupation", A57BR_Demographics_Occupation);
            n57BR_Demographics_Occupation = T000B6_n57BR_Demographics_Occupation[0];
            A58BR_Demographics_Insurance = T000B6_A58BR_Demographics_Insurance[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A58BR_Demographics_Insurance", A58BR_Demographics_Insurance);
            n58BR_Demographics_Insurance = T000B6_n58BR_Demographics_Insurance[0];
            A59BR_Demographics_Province = T000B6_A59BR_Demographics_Province[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A59BR_Demographics_Province", A59BR_Demographics_Province);
            n59BR_Demographics_Province = T000B6_n59BR_Demographics_Province[0];
            A60BR_Demographics_City = T000B6_A60BR_Demographics_City[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A60BR_Demographics_City", A60BR_Demographics_City);
            n60BR_Demographics_City = T000B6_n60BR_Demographics_City[0];
            A19BR_EncounterID = T000B6_A19BR_EncounterID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
            ZM0B12( -25) ;
         }
         pr_default.close(4);
         OnLoadActions0B12( ) ;
      }

      protected void OnLoadActions0B12( )
      {
         AV16Pgmname = "BR_Demographics";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16Pgmname", AV16Pgmname);
      }

      protected void CheckExtendedTable0B12( )
      {
         Gx_BScreen = 1;
         standaloneModal( ) ;
         AV16Pgmname = "BR_Demographics";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16Pgmname", AV16Pgmname);
         /* Using cursor T000B4 */
         pr_default.execute(2, new Object[] {A19BR_EncounterID});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("不匹配' T15'", "ForeignKeyNotFound", 1, "BR_ENCOUNTERID");
            AnyError = 1;
            GX_FocusControl = edtBR_EncounterID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A85BR_Information_ID = T000B4_A85BR_Information_ID[0];
         n85BR_Information_ID = T000B4_n85BR_Information_ID[0];
         pr_default.close(2);
         /* Using cursor T000B5 */
         pr_default.execute(3, new Object[] {n85BR_Information_ID, A85BR_Information_ID});
         if ( (pr_default.getStatus(3) == 101) )
         {
            if ( ! ( (0==A85BR_Information_ID) ) )
            {
               GX_msglist.addItem("不匹配' T16'", "ForeignKeyNotFound", 1, "");
               AnyError = 1;
            }
         }
         A36BR_Information_PatientNo = T000B5_A36BR_Information_PatientNo[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36BR_Information_PatientNo", A36BR_Information_PatientNo);
         n36BR_Information_PatientNo = T000B5_n36BR_Information_PatientNo[0];
         pr_default.close(3);
         if ( ! ( (DateTime.MinValue==A53BR_Demographics_BirthDate) || ( A53BR_Demographics_BirthDate >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("域������������超界", "OutOfRange", 1, "BR_DEMOGRAPHICS_BIRTHDATE");
            AnyError = 1;
            GX_FocusControl = edtBR_Demographics_BirthDate_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( A54BR_Demographics_Sex)) )
         {
            GX_msglist.addItem("性别是必须选择的", 1, "BR_DEMOGRAPHICS_SEX");
            AnyError = 1;
            GX_FocusControl = dynBR_Demographics_Sex_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
      }

      protected void CloseExtendedTableCursors0B12( )
      {
         pr_default.close(2);
         pr_default.close(3);
      }

      protected void enableDisable( )
      {
      }

      protected void gxLoad_26( long A19BR_EncounterID )
      {
         /* Using cursor T000B7 */
         pr_default.execute(5, new Object[] {A19BR_EncounterID});
         if ( (pr_default.getStatus(5) == 101) )
         {
            GX_msglist.addItem("不匹配' T15'", "ForeignKeyNotFound", 1, "BR_ENCOUNTERID");
            AnyError = 1;
            GX_FocusControl = edtBR_EncounterID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         A85BR_Information_ID = T000B7_A85BR_Information_ID[0];
         n85BR_Information_ID = T000B7_n85BR_Information_ID[0];
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
         /* Using cursor T000B8 */
         pr_default.execute(6, new Object[] {n85BR_Information_ID, A85BR_Information_ID});
         if ( (pr_default.getStatus(6) == 101) )
         {
            if ( ! ( (0==A85BR_Information_ID) ) )
            {
               GX_msglist.addItem("不匹配' T16'", "ForeignKeyNotFound", 1, "");
               AnyError = 1;
            }
         }
         A36BR_Information_PatientNo = T000B8_A36BR_Information_PatientNo[0];
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36BR_Information_PatientNo", A36BR_Information_PatientNo);
         n36BR_Information_PatientNo = T000B8_n36BR_Information_PatientNo[0];
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

      protected void GetKey0B12( )
      {
         /* Using cursor T000B9 */
         pr_default.execute(7, new Object[] {A61BR_Demographics_ID});
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound12 = 1;
         }
         else
         {
            RcdFound12 = 0;
         }
         pr_default.close(7);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T000B3 */
         pr_default.execute(1, new Object[] {A61BR_Demographics_ID});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0B12( 25) ;
            RcdFound12 = 1;
            A61BR_Demographics_ID = T000B3_A61BR_Demographics_ID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A61BR_Demographics_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A61BR_Demographics_ID), 18, 0)));
            A455BR_Demographics_Sex_Code = T000B3_A455BR_Demographics_Sex_Code[0];
            n455BR_Demographics_Sex_Code = T000B3_n455BR_Demographics_Sex_Code[0];
            A456BR_Demographics_MarritalStatus_Code = T000B3_A456BR_Demographics_MarritalStatus_Code[0];
            n456BR_Demographics_MarritalStatus_Code = T000B3_n456BR_Demographics_MarritalStatus_Code[0];
            A457BR_Demographics_Ethnic_Code = T000B3_A457BR_Demographics_Ethnic_Code[0];
            n457BR_Demographics_Ethnic_Code = T000B3_n457BR_Demographics_Ethnic_Code[0];
            A458BR_Demographics_Education_Code = T000B3_A458BR_Demographics_Education_Code[0];
            n458BR_Demographics_Education_Code = T000B3_n458BR_Demographics_Education_Code[0];
            A459BR_Demographics_Insurance_Code = T000B3_A459BR_Demographics_Insurance_Code[0];
            n459BR_Demographics_Insurance_Code = T000B3_n459BR_Demographics_Insurance_Code[0];
            A53BR_Demographics_BirthDate = T000B3_A53BR_Demographics_BirthDate[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A53BR_Demographics_BirthDate", context.localUtil.Format(A53BR_Demographics_BirthDate, "9999/99/99"));
            n53BR_Demographics_BirthDate = T000B3_n53BR_Demographics_BirthDate[0];
            A54BR_Demographics_Sex = T000B3_A54BR_Demographics_Sex[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A54BR_Demographics_Sex", A54BR_Demographics_Sex);
            n54BR_Demographics_Sex = T000B3_n54BR_Demographics_Sex[0];
            A63BR_Demographics_MarritalStatus = T000B3_A63BR_Demographics_MarritalStatus[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A63BR_Demographics_MarritalStatus", A63BR_Demographics_MarritalStatus);
            n63BR_Demographics_MarritalStatus = T000B3_n63BR_Demographics_MarritalStatus[0];
            A55BR_Demographics_Ethnic = T000B3_A55BR_Demographics_Ethnic[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A55BR_Demographics_Ethnic", A55BR_Demographics_Ethnic);
            n55BR_Demographics_Ethnic = T000B3_n55BR_Demographics_Ethnic[0];
            A56BR_Demographics_Education = T000B3_A56BR_Demographics_Education[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A56BR_Demographics_Education", A56BR_Demographics_Education);
            n56BR_Demographics_Education = T000B3_n56BR_Demographics_Education[0];
            A57BR_Demographics_Occupation = T000B3_A57BR_Demographics_Occupation[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A57BR_Demographics_Occupation", A57BR_Demographics_Occupation);
            n57BR_Demographics_Occupation = T000B3_n57BR_Demographics_Occupation[0];
            A58BR_Demographics_Insurance = T000B3_A58BR_Demographics_Insurance[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A58BR_Demographics_Insurance", A58BR_Demographics_Insurance);
            n58BR_Demographics_Insurance = T000B3_n58BR_Demographics_Insurance[0];
            A59BR_Demographics_Province = T000B3_A59BR_Demographics_Province[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A59BR_Demographics_Province", A59BR_Demographics_Province);
            n59BR_Demographics_Province = T000B3_n59BR_Demographics_Province[0];
            A60BR_Demographics_City = T000B3_A60BR_Demographics_City[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A60BR_Demographics_City", A60BR_Demographics_City);
            n60BR_Demographics_City = T000B3_n60BR_Demographics_City[0];
            A19BR_EncounterID = T000B3_A19BR_EncounterID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
            Z61BR_Demographics_ID = A61BR_Demographics_ID;
            sMode12 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            Load0B12( ) ;
            if ( AnyError == 1 )
            {
               RcdFound12 = 0;
               InitializeNonKey0B12( ) ;
            }
            Gx_mode = sMode12;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         else
         {
            RcdFound12 = 0;
            InitializeNonKey0B12( ) ;
            sMode12 = Gx_mode;
            Gx_mode = "DSP";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
            standaloneModal( ) ;
            Gx_mode = sMode12;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0B12( ) ;
         if ( RcdFound12 == 0 )
         {
         }
         else
         {
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound12 = 0;
         /* Using cursor T000B10 */
         pr_default.execute(8, new Object[] {A61BR_Demographics_ID});
         if ( (pr_default.getStatus(8) != 101) )
         {
            while ( (pr_default.getStatus(8) != 101) && ( ( T000B10_A61BR_Demographics_ID[0] < A61BR_Demographics_ID ) ) )
            {
               pr_default.readNext(8);
            }
            if ( (pr_default.getStatus(8) != 101) && ( ( T000B10_A61BR_Demographics_ID[0] > A61BR_Demographics_ID ) ) )
            {
               A61BR_Demographics_ID = T000B10_A61BR_Demographics_ID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A61BR_Demographics_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A61BR_Demographics_ID), 18, 0)));
               RcdFound12 = 1;
            }
         }
         pr_default.close(8);
      }

      protected void move_previous( )
      {
         RcdFound12 = 0;
         /* Using cursor T000B11 */
         pr_default.execute(9, new Object[] {A61BR_Demographics_ID});
         if ( (pr_default.getStatus(9) != 101) )
         {
            while ( (pr_default.getStatus(9) != 101) && ( ( T000B11_A61BR_Demographics_ID[0] > A61BR_Demographics_ID ) ) )
            {
               pr_default.readNext(9);
            }
            if ( (pr_default.getStatus(9) != 101) && ( ( T000B11_A61BR_Demographics_ID[0] < A61BR_Demographics_ID ) ) )
            {
               A61BR_Demographics_ID = T000B11_A61BR_Demographics_ID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A61BR_Demographics_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A61BR_Demographics_ID), 18, 0)));
               RcdFound12 = 1;
            }
         }
         pr_default.close(9);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1;
         GetKey0B12( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            GX_FocusControl = edtBR_EncounterID_Internalname;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            Insert0B12( ) ;
            if ( AnyError == 1 )
            {
               GX_FocusControl = "";
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( RcdFound12 == 1 )
            {
               if ( A61BR_Demographics_ID != Z61BR_Demographics_ID )
               {
                  A61BR_Demographics_ID = Z61BR_Demographics_ID;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A61BR_Demographics_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A61BR_Demographics_ID), 18, 0)));
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "BR_DEMOGRAPHICS_ID");
                  AnyError = 1;
                  GX_FocusControl = edtBR_Demographics_ID_Internalname;
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
                  /* Update record */
                  Update0B12( ) ;
                  GX_FocusControl = edtBR_EncounterID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( A61BR_Demographics_ID != Z61BR_Demographics_ID )
               {
                  /* Insert record */
                  GX_FocusControl = edtBR_EncounterID_Internalname;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert0B12( ) ;
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
                     GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "BR_DEMOGRAPHICS_ID");
                     AnyError = 1;
                     GX_FocusControl = edtBR_Demographics_ID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
                  else
                  {
                     /* Insert record */
                     GX_FocusControl = edtBR_EncounterID_Internalname;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     Insert0B12( ) ;
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
         if ( A61BR_Demographics_ID != Z61BR_Demographics_ID )
         {
            A61BR_Demographics_ID = Z61BR_Demographics_ID;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A61BR_Demographics_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A61BR_Demographics_ID), 18, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt", ""), 1, "BR_DEMOGRAPHICS_ID");
            AnyError = 1;
            GX_FocusControl = edtBR_Demographics_ID_Internalname;
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
         }
      }

      protected void CheckOptimisticConcurrency0B12( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000B2 */
            pr_default.execute(0, new Object[] {A61BR_Demographics_ID});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BR_Demographics"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z455BR_Demographics_Sex_Code, T000B2_A455BR_Demographics_Sex_Code[0]) != 0 ) || ( StringUtil.StrCmp(Z456BR_Demographics_MarritalStatus_Code, T000B2_A456BR_Demographics_MarritalStatus_Code[0]) != 0 ) || ( StringUtil.StrCmp(Z457BR_Demographics_Ethnic_Code, T000B2_A457BR_Demographics_Ethnic_Code[0]) != 0 ) || ( StringUtil.StrCmp(Z458BR_Demographics_Education_Code, T000B2_A458BR_Demographics_Education_Code[0]) != 0 ) || ( StringUtil.StrCmp(Z459BR_Demographics_Insurance_Code, T000B2_A459BR_Demographics_Insurance_Code[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( Z53BR_Demographics_BirthDate != T000B2_A53BR_Demographics_BirthDate[0] ) || ( StringUtil.StrCmp(Z54BR_Demographics_Sex, T000B2_A54BR_Demographics_Sex[0]) != 0 ) || ( StringUtil.StrCmp(Z63BR_Demographics_MarritalStatus, T000B2_A63BR_Demographics_MarritalStatus[0]) != 0 ) || ( StringUtil.StrCmp(Z55BR_Demographics_Ethnic, T000B2_A55BR_Demographics_Ethnic[0]) != 0 ) || ( StringUtil.StrCmp(Z56BR_Demographics_Education, T000B2_A56BR_Demographics_Education[0]) != 0 ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( StringUtil.StrCmp(Z57BR_Demographics_Occupation, T000B2_A57BR_Demographics_Occupation[0]) != 0 ) || ( StringUtil.StrCmp(Z58BR_Demographics_Insurance, T000B2_A58BR_Demographics_Insurance[0]) != 0 ) || ( StringUtil.StrCmp(Z59BR_Demographics_Province, T000B2_A59BR_Demographics_Province[0]) != 0 ) || ( StringUtil.StrCmp(Z60BR_Demographics_City, T000B2_A60BR_Demographics_City[0]) != 0 ) || ( Z19BR_EncounterID != T000B2_A19BR_EncounterID[0] ) )
            {
               if ( StringUtil.StrCmp(Z455BR_Demographics_Sex_Code, T000B2_A455BR_Demographics_Sex_Code[0]) != 0 )
               {
                  GXUtil.WriteLog("br_demographics:[seudo value changed for attri]"+"BR_Demographics_Sex_Code");
                  GXUtil.WriteLogRaw("Old: ",Z455BR_Demographics_Sex_Code);
                  GXUtil.WriteLogRaw("Current: ",T000B2_A455BR_Demographics_Sex_Code[0]);
               }
               if ( StringUtil.StrCmp(Z456BR_Demographics_MarritalStatus_Code, T000B2_A456BR_Demographics_MarritalStatus_Code[0]) != 0 )
               {
                  GXUtil.WriteLog("br_demographics:[seudo value changed for attri]"+"BR_Demographics_MarritalStatus_Code");
                  GXUtil.WriteLogRaw("Old: ",Z456BR_Demographics_MarritalStatus_Code);
                  GXUtil.WriteLogRaw("Current: ",T000B2_A456BR_Demographics_MarritalStatus_Code[0]);
               }
               if ( StringUtil.StrCmp(Z457BR_Demographics_Ethnic_Code, T000B2_A457BR_Demographics_Ethnic_Code[0]) != 0 )
               {
                  GXUtil.WriteLog("br_demographics:[seudo value changed for attri]"+"BR_Demographics_Ethnic_Code");
                  GXUtil.WriteLogRaw("Old: ",Z457BR_Demographics_Ethnic_Code);
                  GXUtil.WriteLogRaw("Current: ",T000B2_A457BR_Demographics_Ethnic_Code[0]);
               }
               if ( StringUtil.StrCmp(Z458BR_Demographics_Education_Code, T000B2_A458BR_Demographics_Education_Code[0]) != 0 )
               {
                  GXUtil.WriteLog("br_demographics:[seudo value changed for attri]"+"BR_Demographics_Education_Code");
                  GXUtil.WriteLogRaw("Old: ",Z458BR_Demographics_Education_Code);
                  GXUtil.WriteLogRaw("Current: ",T000B2_A458BR_Demographics_Education_Code[0]);
               }
               if ( StringUtil.StrCmp(Z459BR_Demographics_Insurance_Code, T000B2_A459BR_Demographics_Insurance_Code[0]) != 0 )
               {
                  GXUtil.WriteLog("br_demographics:[seudo value changed for attri]"+"BR_Demographics_Insurance_Code");
                  GXUtil.WriteLogRaw("Old: ",Z459BR_Demographics_Insurance_Code);
                  GXUtil.WriteLogRaw("Current: ",T000B2_A459BR_Demographics_Insurance_Code[0]);
               }
               if ( Z53BR_Demographics_BirthDate != T000B2_A53BR_Demographics_BirthDate[0] )
               {
                  GXUtil.WriteLog("br_demographics:[seudo value changed for attri]"+"BR_Demographics_BirthDate");
                  GXUtil.WriteLogRaw("Old: ",Z53BR_Demographics_BirthDate);
                  GXUtil.WriteLogRaw("Current: ",T000B2_A53BR_Demographics_BirthDate[0]);
               }
               if ( StringUtil.StrCmp(Z54BR_Demographics_Sex, T000B2_A54BR_Demographics_Sex[0]) != 0 )
               {
                  GXUtil.WriteLog("br_demographics:[seudo value changed for attri]"+"BR_Demographics_Sex");
                  GXUtil.WriteLogRaw("Old: ",Z54BR_Demographics_Sex);
                  GXUtil.WriteLogRaw("Current: ",T000B2_A54BR_Demographics_Sex[0]);
               }
               if ( StringUtil.StrCmp(Z63BR_Demographics_MarritalStatus, T000B2_A63BR_Demographics_MarritalStatus[0]) != 0 )
               {
                  GXUtil.WriteLog("br_demographics:[seudo value changed for attri]"+"BR_Demographics_MarritalStatus");
                  GXUtil.WriteLogRaw("Old: ",Z63BR_Demographics_MarritalStatus);
                  GXUtil.WriteLogRaw("Current: ",T000B2_A63BR_Demographics_MarritalStatus[0]);
               }
               if ( StringUtil.StrCmp(Z55BR_Demographics_Ethnic, T000B2_A55BR_Demographics_Ethnic[0]) != 0 )
               {
                  GXUtil.WriteLog("br_demographics:[seudo value changed for attri]"+"BR_Demographics_Ethnic");
                  GXUtil.WriteLogRaw("Old: ",Z55BR_Demographics_Ethnic);
                  GXUtil.WriteLogRaw("Current: ",T000B2_A55BR_Demographics_Ethnic[0]);
               }
               if ( StringUtil.StrCmp(Z56BR_Demographics_Education, T000B2_A56BR_Demographics_Education[0]) != 0 )
               {
                  GXUtil.WriteLog("br_demographics:[seudo value changed for attri]"+"BR_Demographics_Education");
                  GXUtil.WriteLogRaw("Old: ",Z56BR_Demographics_Education);
                  GXUtil.WriteLogRaw("Current: ",T000B2_A56BR_Demographics_Education[0]);
               }
               if ( StringUtil.StrCmp(Z57BR_Demographics_Occupation, T000B2_A57BR_Demographics_Occupation[0]) != 0 )
               {
                  GXUtil.WriteLog("br_demographics:[seudo value changed for attri]"+"BR_Demographics_Occupation");
                  GXUtil.WriteLogRaw("Old: ",Z57BR_Demographics_Occupation);
                  GXUtil.WriteLogRaw("Current: ",T000B2_A57BR_Demographics_Occupation[0]);
               }
               if ( StringUtil.StrCmp(Z58BR_Demographics_Insurance, T000B2_A58BR_Demographics_Insurance[0]) != 0 )
               {
                  GXUtil.WriteLog("br_demographics:[seudo value changed for attri]"+"BR_Demographics_Insurance");
                  GXUtil.WriteLogRaw("Old: ",Z58BR_Demographics_Insurance);
                  GXUtil.WriteLogRaw("Current: ",T000B2_A58BR_Demographics_Insurance[0]);
               }
               if ( StringUtil.StrCmp(Z59BR_Demographics_Province, T000B2_A59BR_Demographics_Province[0]) != 0 )
               {
                  GXUtil.WriteLog("br_demographics:[seudo value changed for attri]"+"BR_Demographics_Province");
                  GXUtil.WriteLogRaw("Old: ",Z59BR_Demographics_Province);
                  GXUtil.WriteLogRaw("Current: ",T000B2_A59BR_Demographics_Province[0]);
               }
               if ( StringUtil.StrCmp(Z60BR_Demographics_City, T000B2_A60BR_Demographics_City[0]) != 0 )
               {
                  GXUtil.WriteLog("br_demographics:[seudo value changed for attri]"+"BR_Demographics_City");
                  GXUtil.WriteLogRaw("Old: ",Z60BR_Demographics_City);
                  GXUtil.WriteLogRaw("Current: ",T000B2_A60BR_Demographics_City[0]);
               }
               if ( Z19BR_EncounterID != T000B2_A19BR_EncounterID[0] )
               {
                  GXUtil.WriteLog("br_demographics:[seudo value changed for attri]"+"BR_EncounterID");
                  GXUtil.WriteLogRaw("Old: ",Z19BR_EncounterID);
                  GXUtil.WriteLogRaw("Current: ",T000B2_A19BR_EncounterID[0]);
               }
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"BR_Demographics"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0B12( )
      {
         BeforeValidate0B12( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0B12( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0B12( 0) ;
            CheckOptimisticConcurrency0B12( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0B12( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0B12( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000B12 */
                     pr_default.execute(10, new Object[] {n455BR_Demographics_Sex_Code, A455BR_Demographics_Sex_Code, n456BR_Demographics_MarritalStatus_Code, A456BR_Demographics_MarritalStatus_Code, n457BR_Demographics_Ethnic_Code, A457BR_Demographics_Ethnic_Code, n458BR_Demographics_Education_Code, A458BR_Demographics_Education_Code, n459BR_Demographics_Insurance_Code, A459BR_Demographics_Insurance_Code, n53BR_Demographics_BirthDate, A53BR_Demographics_BirthDate, n54BR_Demographics_Sex, A54BR_Demographics_Sex, n63BR_Demographics_MarritalStatus, A63BR_Demographics_MarritalStatus, n55BR_Demographics_Ethnic, A55BR_Demographics_Ethnic, n56BR_Demographics_Education, A56BR_Demographics_Education, n57BR_Demographics_Occupation, A57BR_Demographics_Occupation, n58BR_Demographics_Insurance, A58BR_Demographics_Insurance, n59BR_Demographics_Province, A59BR_Demographics_Province, n60BR_Demographics_City, A60BR_Demographics_City, A19BR_EncounterID});
                     A61BR_Demographics_ID = T000B12_A61BR_Demographics_ID[0];
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A61BR_Demographics_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A61BR_Demographics_ID), 18, 0)));
                     pr_default.close(10);
                     dsDefault.SmartCacheProvider.SetUpdated("BR_Demographics") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                           ResetCaption0B0( ) ;
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
               Load0B12( ) ;
            }
            EndLevel0B12( ) ;
         }
         CloseExtendedTableCursors0B12( ) ;
      }

      protected void Update0B12( )
      {
         BeforeValidate0B12( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0B12( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0B12( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0B12( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0B12( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000B13 */
                     pr_default.execute(11, new Object[] {n455BR_Demographics_Sex_Code, A455BR_Demographics_Sex_Code, n456BR_Demographics_MarritalStatus_Code, A456BR_Demographics_MarritalStatus_Code, n457BR_Demographics_Ethnic_Code, A457BR_Demographics_Ethnic_Code, n458BR_Demographics_Education_Code, A458BR_Demographics_Education_Code, n459BR_Demographics_Insurance_Code, A459BR_Demographics_Insurance_Code, n53BR_Demographics_BirthDate, A53BR_Demographics_BirthDate, n54BR_Demographics_Sex, A54BR_Demographics_Sex, n63BR_Demographics_MarritalStatus, A63BR_Demographics_MarritalStatus, n55BR_Demographics_Ethnic, A55BR_Demographics_Ethnic, n56BR_Demographics_Education, A56BR_Demographics_Education, n57BR_Demographics_Occupation, A57BR_Demographics_Occupation, n58BR_Demographics_Insurance, A58BR_Demographics_Insurance, n59BR_Demographics_Province, A59BR_Demographics_Province, n60BR_Demographics_City, A60BR_Demographics_City, A19BR_EncounterID, A61BR_Demographics_ID});
                     pr_default.close(11);
                     dsDefault.SmartCacheProvider.SetUpdated("BR_Demographics") ;
                     if ( (pr_default.getStatus(11) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"BR_Demographics"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0B12( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
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
            EndLevel0B12( ) ;
         }
         CloseExtendedTableCursors0B12( ) ;
      }

      protected void DeferredUpdate0B12( )
      {
      }

      protected void delete( )
      {
         BeforeValidate0B12( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0B12( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0B12( ) ;
            AfterConfirm0B12( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0B12( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000B14 */
                  pr_default.execute(12, new Object[] {A61BR_Demographics_ID});
                  pr_default.close(12);
                  dsDefault.SmartCacheProvider.SetUpdated("BR_Demographics") ;
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
         sMode12 = Gx_mode;
         Gx_mode = "DLT";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
         EndLevel0B12( ) ;
         Gx_mode = sMode12;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vMODE", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")), context));
      }

      protected void OnDeleteControls0B12( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            AV16Pgmname = "BR_Demographics";
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16Pgmname", AV16Pgmname);
            /* Using cursor T000B15 */
            pr_default.execute(13, new Object[] {A19BR_EncounterID});
            A85BR_Information_ID = T000B15_A85BR_Information_ID[0];
            n85BR_Information_ID = T000B15_n85BR_Information_ID[0];
            pr_default.close(13);
            /* Using cursor T000B16 */
            pr_default.execute(14, new Object[] {n85BR_Information_ID, A85BR_Information_ID});
            A36BR_Information_PatientNo = T000B16_A36BR_Information_PatientNo[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36BR_Information_PatientNo", A36BR_Information_PatientNo);
            n36BR_Information_PatientNo = T000B16_n36BR_Information_PatientNo[0];
            pr_default.close(14);
         }
      }

      protected void EndLevel0B12( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0B12( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(1);
            pr_default.close(13);
            pr_default.close(14);
            context.CommitDataStores("br_demographics",pr_default);
            if ( AnyError == 0 )
            {
               ConfirmValues0B0( ) ;
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
            context.RollbackDataStores("br_demographics",pr_default);
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanStart0B12( )
      {
         /* Scan By routine */
         /* Using cursor T000B17 */
         pr_default.execute(15);
         RcdFound12 = 0;
         if ( (pr_default.getStatus(15) != 101) )
         {
            RcdFound12 = 1;
            A61BR_Demographics_ID = T000B17_A61BR_Demographics_ID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A61BR_Demographics_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A61BR_Demographics_ID), 18, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0B12( )
      {
         /* Scan next routine */
         pr_default.readNext(15);
         RcdFound12 = 0;
         if ( (pr_default.getStatus(15) != 101) )
         {
            RcdFound12 = 1;
            A61BR_Demographics_ID = T000B17_A61BR_Demographics_ID[0];
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A61BR_Demographics_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A61BR_Demographics_ID), 18, 0)));
         }
      }

      protected void ScanEnd0B12( )
      {
         pr_default.close(15);
      }

      protected void AfterConfirm0B12( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0B12( )
      {
         /* Before Insert Rules */
         GXt_char1 = A455BR_Demographics_Sex_Code;
         new zutil_findtargetcode(context ).execute(  7,  A54BR_Demographics_Sex, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A54BR_Demographics_Sex", A54BR_Demographics_Sex);
         A455BR_Demographics_Sex_Code = GXt_char1;
         n455BR_Demographics_Sex_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A455BR_Demographics_Sex_Code", A455BR_Demographics_Sex_Code);
         GXt_char1 = A456BR_Demographics_MarritalStatus_Code;
         new zutil_findtargetcode(context ).execute(  8,  A63BR_Demographics_MarritalStatus, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A63BR_Demographics_MarritalStatus", A63BR_Demographics_MarritalStatus);
         A456BR_Demographics_MarritalStatus_Code = GXt_char1;
         n456BR_Demographics_MarritalStatus_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A456BR_Demographics_MarritalStatus_Code", A456BR_Demographics_MarritalStatus_Code);
         GXt_char1 = A457BR_Demographics_Ethnic_Code;
         new zutil_findtargetcode(context ).execute(  9,  A55BR_Demographics_Ethnic, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A55BR_Demographics_Ethnic", A55BR_Demographics_Ethnic);
         A457BR_Demographics_Ethnic_Code = GXt_char1;
         n457BR_Demographics_Ethnic_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A457BR_Demographics_Ethnic_Code", A457BR_Demographics_Ethnic_Code);
         GXt_char1 = A458BR_Demographics_Education_Code;
         new zutil_findtargetcode(context ).execute(  10,  A56BR_Demographics_Education, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A56BR_Demographics_Education", A56BR_Demographics_Education);
         A458BR_Demographics_Education_Code = GXt_char1;
         n458BR_Demographics_Education_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A458BR_Demographics_Education_Code", A458BR_Demographics_Education_Code);
         GXt_char1 = A459BR_Demographics_Insurance_Code;
         new zutil_findtargetcode(context ).execute(  11,  A58BR_Demographics_Insurance, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A58BR_Demographics_Insurance", A58BR_Demographics_Insurance);
         A459BR_Demographics_Insurance_Code = GXt_char1;
         n459BR_Demographics_Insurance_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A459BR_Demographics_Insurance_Code", A459BR_Demographics_Insurance_Code);
      }

      protected void BeforeUpdate0B12( )
      {
         /* Before Update Rules */
         GXt_char1 = A455BR_Demographics_Sex_Code;
         new zutil_findtargetcode(context ).execute(  7,  A54BR_Demographics_Sex, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A54BR_Demographics_Sex", A54BR_Demographics_Sex);
         A455BR_Demographics_Sex_Code = GXt_char1;
         n455BR_Demographics_Sex_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A455BR_Demographics_Sex_Code", A455BR_Demographics_Sex_Code);
         GXt_char1 = A456BR_Demographics_MarritalStatus_Code;
         new zutil_findtargetcode(context ).execute(  8,  A63BR_Demographics_MarritalStatus, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A63BR_Demographics_MarritalStatus", A63BR_Demographics_MarritalStatus);
         A456BR_Demographics_MarritalStatus_Code = GXt_char1;
         n456BR_Demographics_MarritalStatus_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A456BR_Demographics_MarritalStatus_Code", A456BR_Demographics_MarritalStatus_Code);
         GXt_char1 = A457BR_Demographics_Ethnic_Code;
         new zutil_findtargetcode(context ).execute(  9,  A55BR_Demographics_Ethnic, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A55BR_Demographics_Ethnic", A55BR_Demographics_Ethnic);
         A457BR_Demographics_Ethnic_Code = GXt_char1;
         n457BR_Demographics_Ethnic_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A457BR_Demographics_Ethnic_Code", A457BR_Demographics_Ethnic_Code);
         GXt_char1 = A458BR_Demographics_Education_Code;
         new zutil_findtargetcode(context ).execute(  10,  A56BR_Demographics_Education, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A56BR_Demographics_Education", A56BR_Demographics_Education);
         A458BR_Demographics_Education_Code = GXt_char1;
         n458BR_Demographics_Education_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A458BR_Demographics_Education_Code", A458BR_Demographics_Education_Code);
         GXt_char1 = A459BR_Demographics_Insurance_Code;
         new zutil_findtargetcode(context ).execute(  11,  A58BR_Demographics_Insurance, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A58BR_Demographics_Insurance", A58BR_Demographics_Insurance);
         A459BR_Demographics_Insurance_Code = GXt_char1;
         n459BR_Demographics_Insurance_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A459BR_Demographics_Insurance_Code", A459BR_Demographics_Insurance_Code);
      }

      protected void BeforeDelete0B12( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0B12( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0B12( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0B12( )
      {
         edtBR_Demographics_ID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Demographics_ID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Demographics_ID_Enabled), 5, 0)), true);
         edtBR_EncounterID_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_EncounterID_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_EncounterID_Enabled), 5, 0)), true);
         edtBR_Information_PatientNo_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Information_PatientNo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Information_PatientNo_Enabled), 5, 0)), true);
         edtBR_Demographics_BirthDate_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Demographics_BirthDate_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Demographics_BirthDate_Enabled), 5, 0)), true);
         dynBR_Demographics_Sex.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynBR_Demographics_Sex_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynBR_Demographics_Sex.Enabled), 5, 0)), true);
         dynBR_Demographics_MarritalStatus.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynBR_Demographics_MarritalStatus_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynBR_Demographics_MarritalStatus.Enabled), 5, 0)), true);
         dynBR_Demographics_Ethnic.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynBR_Demographics_Ethnic_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynBR_Demographics_Ethnic.Enabled), 5, 0)), true);
         dynBR_Demographics_Education.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynBR_Demographics_Education_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynBR_Demographics_Education.Enabled), 5, 0)), true);
         edtBR_Demographics_Occupation_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Demographics_Occupation_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Demographics_Occupation_Enabled), 5, 0)), true);
         dynBR_Demographics_Insurance.Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynBR_Demographics_Insurance_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(dynBR_Demographics_Insurance.Enabled), 5, 0)), true);
         edtBR_Demographics_Province_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Demographics_Province_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Demographics_Province_Enabled), 5, 0)), true);
         edtBR_Demographics_City_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Demographics_City_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_Demographics_City_Enabled), 5, 0)), true);
      }

      protected void send_integrity_lvl_hashes0B12( )
      {
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues0B0( )
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
         context.AddJavascriptSource("gxcfg.js", "?202022711554953", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_demographics.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV12BR_Demographics_ID)+"\">") ;
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
         forbiddenHiddens = "hsh" + "BR_Demographics";
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(A61BR_Demographics_ID), "ZZZZZZZZZZZZZZZZZZ");
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( AV15tCurrentCode, ""));
         forbiddenHiddens = forbiddenHiddens + context.localUtil.Format( (decimal)(AV10Insert_BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ");
         forbiddenHiddens = forbiddenHiddens + StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!"));
         GxWebStd.gx_hidden_field( context, "hsh", GetEncryptedHash( forbiddenHiddens, GXKey));
         GXUtil.WriteLog("br_demographics:[SendSecurityCheck value for]"+"BR_Demographics_ID:"+context.localUtil.Format( (decimal)(A61BR_Demographics_ID), "ZZZZZZZZZZZZZZZZZZ"));
         GXUtil.WriteLog("br_demographics:[SendSecurityCheck value for]"+"tCurrentCode:"+StringUtil.RTrim( context.localUtil.Format( AV15tCurrentCode, "")));
         GXUtil.WriteLog("br_demographics:[SendSecurityCheck value for]"+"Insert_BR_EncounterID:"+context.localUtil.Format( (decimal)(AV10Insert_BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ"));
         GXUtil.WriteLog("br_demographics:[SendSecurityCheck value for]"+"Gx_mode:"+StringUtil.RTrim( context.localUtil.Format( Gx_mode, "@!")));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "Z61BR_Demographics_ID", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z61BR_Demographics_ID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "Z455BR_Demographics_Sex_Code", Z455BR_Demographics_Sex_Code);
         GxWebStd.gx_hidden_field( context, "Z456BR_Demographics_MarritalStatus_Code", Z456BR_Demographics_MarritalStatus_Code);
         GxWebStd.gx_hidden_field( context, "Z457BR_Demographics_Ethnic_Code", Z457BR_Demographics_Ethnic_Code);
         GxWebStd.gx_hidden_field( context, "Z458BR_Demographics_Education_Code", Z458BR_Demographics_Education_Code);
         GxWebStd.gx_hidden_field( context, "Z459BR_Demographics_Insurance_Code", Z459BR_Demographics_Insurance_Code);
         GxWebStd.gx_hidden_field( context, "Z53BR_Demographics_BirthDate", context.localUtil.DToC( Z53BR_Demographics_BirthDate, 0, "/"));
         GxWebStd.gx_hidden_field( context, "Z54BR_Demographics_Sex", Z54BR_Demographics_Sex);
         GxWebStd.gx_hidden_field( context, "Z63BR_Demographics_MarritalStatus", Z63BR_Demographics_MarritalStatus);
         GxWebStd.gx_hidden_field( context, "Z55BR_Demographics_Ethnic", Z55BR_Demographics_Ethnic);
         GxWebStd.gx_hidden_field( context, "Z56BR_Demographics_Education", Z56BR_Demographics_Education);
         GxWebStd.gx_hidden_field( context, "Z57BR_Demographics_Occupation", Z57BR_Demographics_Occupation);
         GxWebStd.gx_hidden_field( context, "Z58BR_Demographics_Insurance", Z58BR_Demographics_Insurance);
         GxWebStd.gx_hidden_field( context, "Z59BR_Demographics_Province", Z59BR_Demographics_Province);
         GxWebStd.gx_hidden_field( context, "Z60BR_Demographics_City", Z60BR_Demographics_City);
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
         GxWebStd.gx_hidden_field( context, "vBR_DEMOGRAPHICS_ID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV12BR_Demographics_ID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_vBR_DEMOGRAPHICS_ID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(AV12BR_Demographics_ID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, "vINSERT_BR_ENCOUNTERID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10Insert_BR_EncounterID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "BR_DEMOGRAPHICS_SEX_CODE", A455BR_Demographics_Sex_Code);
         GxWebStd.gx_hidden_field( context, "BR_DEMOGRAPHICS_MARRITALSTATUS_CODE", A456BR_Demographics_MarritalStatus_Code);
         GxWebStd.gx_hidden_field( context, "BR_DEMOGRAPHICS_ETHNIC_CODE", A457BR_Demographics_Ethnic_Code);
         GxWebStd.gx_hidden_field( context, "BR_DEMOGRAPHICS_EDUCATION_CODE", A458BR_Demographics_Education_Code);
         GxWebStd.gx_hidden_field( context, "BR_DEMOGRAPHICS_INSURANCE_CODE", A459BR_Demographics_Insurance_Code);
         GxWebStd.gx_hidden_field( context, "vTCURRENTCODE", AV15tCurrentCode);
         GxWebStd.gx_hidden_field( context, "BR_INFORMATION_ID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A85BR_Information_ID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV16Pgmname));
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
         return formatLink("br_demographics.aspx") + "?" + UrlEncode(StringUtil.RTrim(Gx_mode)) + "," + UrlEncode("" +AV12BR_Demographics_ID) ;
      }

      public override String GetPgmname( )
      {
         return "BR_Demographics" ;
      }

      public override String GetPgmdesc( )
      {
         return "人口信息学" ;
      }

      protected void InitializeNonKey0B12( )
      {
         A85BR_Information_ID = 0;
         n85BR_Information_ID = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A85BR_Information_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A85BR_Information_ID), 18, 0)));
         A19BR_EncounterID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
         A455BR_Demographics_Sex_Code = "";
         n455BR_Demographics_Sex_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A455BR_Demographics_Sex_Code", A455BR_Demographics_Sex_Code);
         A456BR_Demographics_MarritalStatus_Code = "";
         n456BR_Demographics_MarritalStatus_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A456BR_Demographics_MarritalStatus_Code", A456BR_Demographics_MarritalStatus_Code);
         A457BR_Demographics_Ethnic_Code = "";
         n457BR_Demographics_Ethnic_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A457BR_Demographics_Ethnic_Code", A457BR_Demographics_Ethnic_Code);
         A458BR_Demographics_Education_Code = "";
         n458BR_Demographics_Education_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A458BR_Demographics_Education_Code", A458BR_Demographics_Education_Code);
         A459BR_Demographics_Insurance_Code = "";
         n459BR_Demographics_Insurance_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A459BR_Demographics_Insurance_Code", A459BR_Demographics_Insurance_Code);
         A36BR_Information_PatientNo = "";
         n36BR_Information_PatientNo = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A36BR_Information_PatientNo", A36BR_Information_PatientNo);
         A53BR_Demographics_BirthDate = DateTime.MinValue;
         n53BR_Demographics_BirthDate = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A53BR_Demographics_BirthDate", context.localUtil.Format(A53BR_Demographics_BirthDate, "9999/99/99"));
         n53BR_Demographics_BirthDate = ((DateTime.MinValue==A53BR_Demographics_BirthDate) ? true : false);
         A54BR_Demographics_Sex = "";
         n54BR_Demographics_Sex = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A54BR_Demographics_Sex", A54BR_Demographics_Sex);
         n54BR_Demographics_Sex = (String.IsNullOrEmpty(StringUtil.RTrim( A54BR_Demographics_Sex)) ? true : false);
         A63BR_Demographics_MarritalStatus = "";
         n63BR_Demographics_MarritalStatus = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A63BR_Demographics_MarritalStatus", A63BR_Demographics_MarritalStatus);
         n63BR_Demographics_MarritalStatus = (String.IsNullOrEmpty(StringUtil.RTrim( A63BR_Demographics_MarritalStatus)) ? true : false);
         A55BR_Demographics_Ethnic = "";
         n55BR_Demographics_Ethnic = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A55BR_Demographics_Ethnic", A55BR_Demographics_Ethnic);
         n55BR_Demographics_Ethnic = (String.IsNullOrEmpty(StringUtil.RTrim( A55BR_Demographics_Ethnic)) ? true : false);
         A56BR_Demographics_Education = "";
         n56BR_Demographics_Education = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A56BR_Demographics_Education", A56BR_Demographics_Education);
         n56BR_Demographics_Education = (String.IsNullOrEmpty(StringUtil.RTrim( A56BR_Demographics_Education)) ? true : false);
         A57BR_Demographics_Occupation = "";
         n57BR_Demographics_Occupation = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A57BR_Demographics_Occupation", A57BR_Demographics_Occupation);
         n57BR_Demographics_Occupation = (String.IsNullOrEmpty(StringUtil.RTrim( A57BR_Demographics_Occupation)) ? true : false);
         A58BR_Demographics_Insurance = "";
         n58BR_Demographics_Insurance = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A58BR_Demographics_Insurance", A58BR_Demographics_Insurance);
         n58BR_Demographics_Insurance = (String.IsNullOrEmpty(StringUtil.RTrim( A58BR_Demographics_Insurance)) ? true : false);
         A59BR_Demographics_Province = "";
         n59BR_Demographics_Province = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A59BR_Demographics_Province", A59BR_Demographics_Province);
         n59BR_Demographics_Province = (String.IsNullOrEmpty(StringUtil.RTrim( A59BR_Demographics_Province)) ? true : false);
         A60BR_Demographics_City = "";
         n60BR_Demographics_City = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A60BR_Demographics_City", A60BR_Demographics_City);
         n60BR_Demographics_City = (String.IsNullOrEmpty(StringUtil.RTrim( A60BR_Demographics_City)) ? true : false);
         Z455BR_Demographics_Sex_Code = "";
         Z456BR_Demographics_MarritalStatus_Code = "";
         Z457BR_Demographics_Ethnic_Code = "";
         Z458BR_Demographics_Education_Code = "";
         Z459BR_Demographics_Insurance_Code = "";
         Z53BR_Demographics_BirthDate = DateTime.MinValue;
         Z54BR_Demographics_Sex = "";
         Z63BR_Demographics_MarritalStatus = "";
         Z55BR_Demographics_Ethnic = "";
         Z56BR_Demographics_Education = "";
         Z57BR_Demographics_Occupation = "";
         Z58BR_Demographics_Insurance = "";
         Z59BR_Demographics_Province = "";
         Z60BR_Demographics_City = "";
         Z19BR_EncounterID = 0;
      }

      protected void InitAll0B12( )
      {
         A61BR_Demographics_ID = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A61BR_Demographics_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(A61BR_Demographics_ID), 18, 0)));
         InitializeNonKey0B12( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20202271155504", true);
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
         context.AddJavascriptSource("br_demographics.js", "?20202271155504", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         edtBR_Demographics_ID_Internalname = "BR_DEMOGRAPHICS_ID";
         edtBR_EncounterID_Internalname = "BR_ENCOUNTERID";
         edtBR_Information_PatientNo_Internalname = "BR_INFORMATION_PATIENTNO";
         edtBR_Demographics_BirthDate_Internalname = "BR_DEMOGRAPHICS_BIRTHDATE";
         dynBR_Demographics_Sex_Internalname = "BR_DEMOGRAPHICS_SEX";
         dynBR_Demographics_MarritalStatus_Internalname = "BR_DEMOGRAPHICS_MARRITALSTATUS";
         dynBR_Demographics_Ethnic_Internalname = "BR_DEMOGRAPHICS_ETHNIC";
         dynBR_Demographics_Education_Internalname = "BR_DEMOGRAPHICS_EDUCATION";
         edtBR_Demographics_Occupation_Internalname = "BR_DEMOGRAPHICS_OCCUPATION";
         dynBR_Demographics_Insurance_Internalname = "BR_DEMOGRAPHICS_INSURANCE";
         edtBR_Demographics_Province_Internalname = "BR_DEMOGRAPHICS_PROVINCE";
         edtBR_Demographics_City_Internalname = "BR_DEMOGRAPHICS_CITY";
         divTableattributes_Internalname = "TABLEATTRIBUTES";
         divLayout_tableattributes_Internalname = "LAYOUT_TABLEATTRIBUTES";
         Dvpanel_tableattributes_Internalname = "DVPANEL_TABLEATTRIBUTES";
         divHtml_dvpanel_tableattributes_Internalname = "HTML_DVPANEL_TABLEATTRIBUTES";
         divTablecontent_Internalname = "TABLECONTENT";
         bttBtntrn_enter_Internalname = "BTNTRN_ENTER";
         bttBtntrn_cancel_Internalname = "BTNTRN_CANCEL";
         bttBtntrn_delete_Internalname = "BTNTRN_DELETE";
         divTablemain_Internalname = "TABLEMAIN";
         divLayoutmaintable_Internalname = "LAYOUTMAINTABLE";
         Form.Internalname = "FORM";
         imgprompt_19_Internalname = "PROMPT_19";
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
         Form.Caption = "人口信息学";
         bttBtntrn_delete_Enabled = 0;
         bttBtntrn_delete_Visible = 1;
         bttBtntrn_cancel_Visible = 1;
         bttBtntrn_enter_Enabled = 1;
         bttBtntrn_enter_Visible = 1;
         edtBR_Demographics_City_Jsonclick = "";
         edtBR_Demographics_City_Enabled = 1;
         edtBR_Demographics_Province_Jsonclick = "";
         edtBR_Demographics_Province_Enabled = 1;
         dynBR_Demographics_Insurance_Jsonclick = "";
         dynBR_Demographics_Insurance.Enabled = 1;
         edtBR_Demographics_Occupation_Jsonclick = "";
         edtBR_Demographics_Occupation_Enabled = 1;
         dynBR_Demographics_Education_Jsonclick = "";
         dynBR_Demographics_Education.Enabled = 1;
         dynBR_Demographics_Ethnic_Jsonclick = "";
         dynBR_Demographics_Ethnic.Enabled = 1;
         dynBR_Demographics_MarritalStatus_Jsonclick = "";
         dynBR_Demographics_MarritalStatus.Enabled = 1;
         dynBR_Demographics_Sex_Jsonclick = "";
         dynBR_Demographics_Sex.Enabled = 1;
         edtBR_Demographics_BirthDate_Jsonclick = "";
         edtBR_Demographics_BirthDate_Enabled = 1;
         edtBR_Information_PatientNo_Jsonclick = "";
         edtBR_Information_PatientNo_Enabled = 0;
         imgprompt_19_Visible = 1;
         imgprompt_19_Link = "";
         edtBR_EncounterID_Jsonclick = "";
         edtBR_EncounterID_Enabled = 1;
         edtBR_Demographics_ID_Jsonclick = "";
         edtBR_Demographics_ID_Enabled = 0;
         Dvpanel_tableattributes_Autoscroll = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Iconposition = "left";
         Dvpanel_tableattributes_Showcollapseicon = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsed = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Collapsible = Convert.ToBoolean( 0);
         Dvpanel_tableattributes_Title = "人口信息学";
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

      protected void GXDLABR_DEMOGRAPHICS_SEX0B12( String AV15tCurrentCode )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLABR_DEMOGRAPHICS_SEX_data0B12( AV15tCurrentCode) ;
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

      protected void GXABR_DEMOGRAPHICS_SEX_html0B12( String AV15tCurrentCode )
      {
         String gxdynajaxvalue ;
         GXDLABR_DEMOGRAPHICS_SEX_data0B12( AV15tCurrentCode) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynBR_Demographics_Sex.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex));
            dynBR_Demographics_Sex.addItem(gxdynajaxvalue, ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLABR_DEMOGRAPHICS_SEX_data0B12( String AV15tCurrentCode )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add("");
         gxdynajaxctrldescr.Add("(请选择)");
         /* Using cursor T000B18 */
         pr_default.execute(16, new Object[] {AV15tCurrentCode});
         while ( (pr_default.getStatus(16) != 101) )
         {
            gxdynajaxctrlcodr.Add(T000B18_A168XT_DefineCodeName[0]);
            gxdynajaxctrldescr.Add(T000B18_A168XT_DefineCodeName[0]);
            pr_default.readNext(16);
         }
         pr_default.close(16);
      }

      protected void GXDLABR_DEMOGRAPHICS_MARRITALSTATUS0B12( String AV15tCurrentCode )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLABR_DEMOGRAPHICS_MARRITALSTATUS_data0B12( AV15tCurrentCode) ;
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

      protected void GXABR_DEMOGRAPHICS_MARRITALSTATUS_html0B12( String AV15tCurrentCode )
      {
         String gxdynajaxvalue ;
         GXDLABR_DEMOGRAPHICS_MARRITALSTATUS_data0B12( AV15tCurrentCode) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynBR_Demographics_MarritalStatus.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex));
            dynBR_Demographics_MarritalStatus.addItem(gxdynajaxvalue, ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLABR_DEMOGRAPHICS_MARRITALSTATUS_data0B12( String AV15tCurrentCode )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add("");
         gxdynajaxctrldescr.Add("(请选择)");
         /* Using cursor T000B19 */
         pr_default.execute(17, new Object[] {AV15tCurrentCode});
         while ( (pr_default.getStatus(17) != 101) )
         {
            gxdynajaxctrlcodr.Add(T000B19_A168XT_DefineCodeName[0]);
            gxdynajaxctrldescr.Add(T000B19_A168XT_DefineCodeName[0]);
            pr_default.readNext(17);
         }
         pr_default.close(17);
      }

      protected void GXDLABR_DEMOGRAPHICS_ETHNIC0B12( String AV15tCurrentCode )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLABR_DEMOGRAPHICS_ETHNIC_data0B12( AV15tCurrentCode) ;
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

      protected void GXABR_DEMOGRAPHICS_ETHNIC_html0B12( String AV15tCurrentCode )
      {
         String gxdynajaxvalue ;
         GXDLABR_DEMOGRAPHICS_ETHNIC_data0B12( AV15tCurrentCode) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynBR_Demographics_Ethnic.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex));
            dynBR_Demographics_Ethnic.addItem(gxdynajaxvalue, ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLABR_DEMOGRAPHICS_ETHNIC_data0B12( String AV15tCurrentCode )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add("");
         gxdynajaxctrldescr.Add("(请选择)");
         /* Using cursor T000B20 */
         pr_default.execute(18, new Object[] {AV15tCurrentCode});
         while ( (pr_default.getStatus(18) != 101) )
         {
            gxdynajaxctrlcodr.Add(T000B20_A168XT_DefineCodeName[0]);
            gxdynajaxctrldescr.Add(T000B20_A168XT_DefineCodeName[0]);
            pr_default.readNext(18);
         }
         pr_default.close(18);
      }

      protected void GXDLABR_DEMOGRAPHICS_EDUCATION0B12( String AV15tCurrentCode )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLABR_DEMOGRAPHICS_EDUCATION_data0B12( AV15tCurrentCode) ;
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

      protected void GXABR_DEMOGRAPHICS_EDUCATION_html0B12( String AV15tCurrentCode )
      {
         String gxdynajaxvalue ;
         GXDLABR_DEMOGRAPHICS_EDUCATION_data0B12( AV15tCurrentCode) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynBR_Demographics_Education.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex));
            dynBR_Demographics_Education.addItem(gxdynajaxvalue, ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLABR_DEMOGRAPHICS_EDUCATION_data0B12( String AV15tCurrentCode )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add("");
         gxdynajaxctrldescr.Add("(请选择)");
         /* Using cursor T000B21 */
         pr_default.execute(19, new Object[] {AV15tCurrentCode});
         while ( (pr_default.getStatus(19) != 101) )
         {
            gxdynajaxctrlcodr.Add(T000B21_A168XT_DefineCodeName[0]);
            gxdynajaxctrldescr.Add(T000B21_A168XT_DefineCodeName[0]);
            pr_default.readNext(19);
         }
         pr_default.close(19);
      }

      protected void GXDLABR_DEMOGRAPHICS_INSURANCE0B12( String AV15tCurrentCode )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "no-store");
         }
         context.GX_webresponse.AddString("[[");
         GXDLABR_DEMOGRAPHICS_INSURANCE_data0B12( AV15tCurrentCode) ;
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

      protected void GXABR_DEMOGRAPHICS_INSURANCE_html0B12( String AV15tCurrentCode )
      {
         String gxdynajaxvalue ;
         GXDLABR_DEMOGRAPHICS_INSURANCE_data0B12( AV15tCurrentCode) ;
         gxdynajaxindex = 1;
         if ( ! ( gxdyncontrolsrefreshing && context.isAjaxRequest( ) ) )
         {
            dynBR_Demographics_Insurance.removeAllItems();
         }
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = ((String)gxdynajaxctrlcodr.Item(gxdynajaxindex));
            dynBR_Demographics_Insurance.addItem(gxdynajaxvalue, ((String)gxdynajaxctrldescr.Item(gxdynajaxindex)), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1);
         }
      }

      protected void GXDLABR_DEMOGRAPHICS_INSURANCE_data0B12( String AV15tCurrentCode )
      {
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         gxdynajaxctrlcodr.Add("");
         gxdynajaxctrldescr.Add("(请选择)");
         /* Using cursor T000B22 */
         pr_default.execute(20, new Object[] {AV15tCurrentCode});
         while ( (pr_default.getStatus(20) != 101) )
         {
            gxdynajaxctrlcodr.Add(T000B22_A168XT_DefineCodeName[0]);
            gxdynajaxctrldescr.Add(T000B22_A168XT_DefineCodeName[0]);
            pr_default.readNext(20);
         }
         pr_default.close(20);
      }

      protected void GX8ASABR_DEMOGRAPHICS_SEX_CODE0B12( String A54BR_Demographics_Sex )
      {
         GXt_char1 = A455BR_Demographics_Sex_Code;
         new zutil_findtargetcode(context ).execute(  7,  A54BR_Demographics_Sex, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A54BR_Demographics_Sex", A54BR_Demographics_Sex);
         A455BR_Demographics_Sex_Code = GXt_char1;
         n455BR_Demographics_Sex_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A455BR_Demographics_Sex_Code", A455BR_Demographics_Sex_Code);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A455BR_Demographics_Sex_Code)+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GX9ASABR_DEMOGRAPHICS_SEX_CODE0B12( String A54BR_Demographics_Sex )
      {
         GXt_char1 = A455BR_Demographics_Sex_Code;
         new zutil_findtargetcode(context ).execute(  7,  A54BR_Demographics_Sex, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A54BR_Demographics_Sex", A54BR_Demographics_Sex);
         A455BR_Demographics_Sex_Code = GXt_char1;
         n455BR_Demographics_Sex_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A455BR_Demographics_Sex_Code", A455BR_Demographics_Sex_Code);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A455BR_Demographics_Sex_Code)+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GX10ASABR_DEMOGRAPHICS_MARRITALSTATUS_CODE0B12( String A63BR_Demographics_MarritalStatus )
      {
         GXt_char1 = A456BR_Demographics_MarritalStatus_Code;
         new zutil_findtargetcode(context ).execute(  8,  A63BR_Demographics_MarritalStatus, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A63BR_Demographics_MarritalStatus", A63BR_Demographics_MarritalStatus);
         A456BR_Demographics_MarritalStatus_Code = GXt_char1;
         n456BR_Demographics_MarritalStatus_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A456BR_Demographics_MarritalStatus_Code", A456BR_Demographics_MarritalStatus_Code);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A456BR_Demographics_MarritalStatus_Code)+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GX11ASABR_DEMOGRAPHICS_MARRITALSTATUS_CODE0B12( String A63BR_Demographics_MarritalStatus )
      {
         GXt_char1 = A456BR_Demographics_MarritalStatus_Code;
         new zutil_findtargetcode(context ).execute(  8,  A63BR_Demographics_MarritalStatus, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A63BR_Demographics_MarritalStatus", A63BR_Demographics_MarritalStatus);
         A456BR_Demographics_MarritalStatus_Code = GXt_char1;
         n456BR_Demographics_MarritalStatus_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A456BR_Demographics_MarritalStatus_Code", A456BR_Demographics_MarritalStatus_Code);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A456BR_Demographics_MarritalStatus_Code)+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GX12ASABR_DEMOGRAPHICS_ETHNIC_CODE0B12( String A55BR_Demographics_Ethnic )
      {
         GXt_char1 = A457BR_Demographics_Ethnic_Code;
         new zutil_findtargetcode(context ).execute(  9,  A55BR_Demographics_Ethnic, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A55BR_Demographics_Ethnic", A55BR_Demographics_Ethnic);
         A457BR_Demographics_Ethnic_Code = GXt_char1;
         n457BR_Demographics_Ethnic_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A457BR_Demographics_Ethnic_Code", A457BR_Demographics_Ethnic_Code);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A457BR_Demographics_Ethnic_Code)+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GX13ASABR_DEMOGRAPHICS_ETHNIC_CODE0B12( String A55BR_Demographics_Ethnic )
      {
         GXt_char1 = A457BR_Demographics_Ethnic_Code;
         new zutil_findtargetcode(context ).execute(  9,  A55BR_Demographics_Ethnic, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A55BR_Demographics_Ethnic", A55BR_Demographics_Ethnic);
         A457BR_Demographics_Ethnic_Code = GXt_char1;
         n457BR_Demographics_Ethnic_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A457BR_Demographics_Ethnic_Code", A457BR_Demographics_Ethnic_Code);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A457BR_Demographics_Ethnic_Code)+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GX14ASABR_DEMOGRAPHICS_EDUCATION_CODE0B12( String A56BR_Demographics_Education )
      {
         GXt_char1 = A458BR_Demographics_Education_Code;
         new zutil_findtargetcode(context ).execute(  10,  A56BR_Demographics_Education, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A56BR_Demographics_Education", A56BR_Demographics_Education);
         A458BR_Demographics_Education_Code = GXt_char1;
         n458BR_Demographics_Education_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A458BR_Demographics_Education_Code", A458BR_Demographics_Education_Code);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A458BR_Demographics_Education_Code)+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GX15ASABR_DEMOGRAPHICS_EDUCATION_CODE0B12( String A56BR_Demographics_Education )
      {
         GXt_char1 = A458BR_Demographics_Education_Code;
         new zutil_findtargetcode(context ).execute(  10,  A56BR_Demographics_Education, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A56BR_Demographics_Education", A56BR_Demographics_Education);
         A458BR_Demographics_Education_Code = GXt_char1;
         n458BR_Demographics_Education_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A458BR_Demographics_Education_Code", A458BR_Demographics_Education_Code);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A458BR_Demographics_Education_Code)+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GX16ASABR_DEMOGRAPHICS_INSURANCE_CODE0B12( String A58BR_Demographics_Insurance )
      {
         GXt_char1 = A459BR_Demographics_Insurance_Code;
         new zutil_findtargetcode(context ).execute(  11,  A58BR_Demographics_Insurance, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A58BR_Demographics_Insurance", A58BR_Demographics_Insurance);
         A459BR_Demographics_Insurance_Code = GXt_char1;
         n459BR_Demographics_Insurance_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A459BR_Demographics_Insurance_Code", A459BR_Demographics_Insurance_Code);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A459BR_Demographics_Insurance_Code)+"\"");
         context.GX_webresponse.AddString("]");
         if ( true )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString("]");
      }

      protected void GX17ASABR_DEMOGRAPHICS_INSURANCE_CODE0B12( String A58BR_Demographics_Insurance )
      {
         GXt_char1 = A459BR_Demographics_Insurance_Code;
         new zutil_findtargetcode(context ).execute(  11,  A58BR_Demographics_Insurance, out  GXt_char1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A58BR_Demographics_Insurance", A58BR_Demographics_Insurance);
         A459BR_Demographics_Insurance_Code = GXt_char1;
         n459BR_Demographics_Insurance_Code = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A459BR_Demographics_Insurance_Code", A459BR_Demographics_Insurance_Code);
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("[[");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( A459BR_Demographics_Insurance_Code)+"\"");
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
         dynBR_Demographics_Sex.Name = "BR_DEMOGRAPHICS_SEX";
         dynBR_Demographics_Sex.WebTags = "";
         dynBR_Demographics_MarritalStatus.Name = "BR_DEMOGRAPHICS_MARRITALSTATUS";
         dynBR_Demographics_MarritalStatus.WebTags = "";
         dynBR_Demographics_Ethnic.Name = "BR_DEMOGRAPHICS_ETHNIC";
         dynBR_Demographics_Ethnic.WebTags = "";
         dynBR_Demographics_Education.Name = "BR_DEMOGRAPHICS_EDUCATION";
         dynBR_Demographics_Education.WebTags = "";
         dynBR_Demographics_Insurance.Name = "BR_DEMOGRAPHICS_INSURANCE";
         dynBR_Demographics_Insurance.WebTags = "";
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
         /* Using cursor T000B23 */
         pr_default.execute(21, new Object[] {A19BR_EncounterID});
         if ( (pr_default.getStatus(21) == 101) )
         {
            GX_msglist.addItem("不匹配' T15'", "ForeignKeyNotFound", 1, "BR_ENCOUNTERID");
            AnyError = 1;
            GX_FocusControl = edtBR_EncounterID_Internalname;
         }
         A85BR_Information_ID = T000B23_A85BR_Information_ID[0];
         n85BR_Information_ID = T000B23_n85BR_Information_ID[0];
         pr_default.close(21);
         /* Using cursor T000B24 */
         pr_default.execute(22, new Object[] {n85BR_Information_ID, A85BR_Information_ID});
         if ( (pr_default.getStatus(22) == 101) )
         {
            if ( ! ( (0==A85BR_Information_ID) ) )
            {
               GX_msglist.addItem("不匹配' T16'", "ForeignKeyNotFound", 1, "");
               AnyError = 1;
            }
         }
         A36BR_Information_PatientNo = T000B24_A36BR_Information_PatientNo[0];
         n36BR_Information_PatientNo = T000B24_n36BR_Information_PatientNo[0];
         pr_default.close(22);
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
         setEventMetadata("ENTER","{handler:'UserMainFullajax',iparms:[{postForm:true},{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV12BR_Demographics_ID',fld:'vBR_DEMOGRAPHICS_ID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[]}");
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV12BR_Demographics_ID',fld:'vBR_DEMOGRAPHICS_ID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'A61BR_Demographics_ID',fld:'BR_DEMOGRAPHICS_ID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV15tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'AV10Insert_BR_EncounterID',fld:'vINSERT_BR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'}]");
         setEventMetadata("REFRESH",",oparms:[]}");
         setEventMetadata("AFTER TRN","{handler:'E120B2',iparms:[{av:'Gx_mode',fld:'vMODE',pic:'@!',hsh:true},{av:'AV8TrnContext',fld:'vTRNCONTEXT',pic:''}]");
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
         pr_default.close(21);
         pr_default.close(13);
         pr_default.close(22);
         pr_default.close(14);
      }

      public override void initialize( )
      {
         sPrefix = "";
         wcpOGx_mode = "";
         Z455BR_Demographics_Sex_Code = "";
         Z456BR_Demographics_MarritalStatus_Code = "";
         Z457BR_Demographics_Ethnic_Code = "";
         Z458BR_Demographics_Education_Code = "";
         Z459BR_Demographics_Insurance_Code = "";
         Z53BR_Demographics_BirthDate = DateTime.MinValue;
         Z54BR_Demographics_Sex = "";
         Z63BR_Demographics_MarritalStatus = "";
         Z55BR_Demographics_Ethnic = "";
         Z56BR_Demographics_Education = "";
         Z57BR_Demographics_Occupation = "";
         Z58BR_Demographics_Insurance = "";
         Z59BR_Demographics_Province = "";
         Z60BR_Demographics_City = "";
         scmdbuf = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV15tCurrentCode = "";
         A54BR_Demographics_Sex = "";
         A63BR_Demographics_MarritalStatus = "";
         A55BR_Demographics_Ethnic = "";
         A56BR_Demographics_Education = "";
         A58BR_Demographics_Insurance = "";
         GXKey = "";
         PreviousTooltip = "";
         PreviousCaption = "";
         Form = new GXWebForm();
         GX_FocusControl = "";
         ClassString = "";
         StyleString = "";
         ucDvpanel_tableattributes = new GXUserControl();
         TempTags = "";
         sImgUrl = "";
         A36BR_Information_PatientNo = "";
         A53BR_Demographics_BirthDate = DateTime.MinValue;
         A57BR_Demographics_Occupation = "";
         A59BR_Demographics_Province = "";
         A60BR_Demographics_City = "";
         bttBtntrn_enter_Jsonclick = "";
         bttBtntrn_cancel_Jsonclick = "";
         bttBtntrn_delete_Jsonclick = "";
         A455BR_Demographics_Sex_Code = "";
         A456BR_Demographics_MarritalStatus_Code = "";
         A457BR_Demographics_Ethnic_Code = "";
         A458BR_Demographics_Education_Code = "";
         A459BR_Demographics_Insurance_Code = "";
         AV16Pgmname = "";
         Dvpanel_tableattributes_Objectcall = "";
         Dvpanel_tableattributes_Class = "";
         Dvpanel_tableattributes_Height = "";
         forbiddenHiddens = "";
         hsh = "";
         sMode12 = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV7WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV8TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV9WebSession = context.GetSession();
         AV11TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         Z36BR_Information_PatientNo = "";
         T000B4_A85BR_Information_ID = new long[1] ;
         T000B4_n85BR_Information_ID = new bool[] {false} ;
         T000B5_A36BR_Information_PatientNo = new String[] {""} ;
         T000B5_n36BR_Information_PatientNo = new bool[] {false} ;
         T000B6_A85BR_Information_ID = new long[1] ;
         T000B6_n85BR_Information_ID = new bool[] {false} ;
         T000B6_A61BR_Demographics_ID = new long[1] ;
         T000B6_A455BR_Demographics_Sex_Code = new String[] {""} ;
         T000B6_n455BR_Demographics_Sex_Code = new bool[] {false} ;
         T000B6_A456BR_Demographics_MarritalStatus_Code = new String[] {""} ;
         T000B6_n456BR_Demographics_MarritalStatus_Code = new bool[] {false} ;
         T000B6_A457BR_Demographics_Ethnic_Code = new String[] {""} ;
         T000B6_n457BR_Demographics_Ethnic_Code = new bool[] {false} ;
         T000B6_A458BR_Demographics_Education_Code = new String[] {""} ;
         T000B6_n458BR_Demographics_Education_Code = new bool[] {false} ;
         T000B6_A459BR_Demographics_Insurance_Code = new String[] {""} ;
         T000B6_n459BR_Demographics_Insurance_Code = new bool[] {false} ;
         T000B6_A36BR_Information_PatientNo = new String[] {""} ;
         T000B6_n36BR_Information_PatientNo = new bool[] {false} ;
         T000B6_A53BR_Demographics_BirthDate = new DateTime[] {DateTime.MinValue} ;
         T000B6_n53BR_Demographics_BirthDate = new bool[] {false} ;
         T000B6_A54BR_Demographics_Sex = new String[] {""} ;
         T000B6_n54BR_Demographics_Sex = new bool[] {false} ;
         T000B6_A63BR_Demographics_MarritalStatus = new String[] {""} ;
         T000B6_n63BR_Demographics_MarritalStatus = new bool[] {false} ;
         T000B6_A55BR_Demographics_Ethnic = new String[] {""} ;
         T000B6_n55BR_Demographics_Ethnic = new bool[] {false} ;
         T000B6_A56BR_Demographics_Education = new String[] {""} ;
         T000B6_n56BR_Demographics_Education = new bool[] {false} ;
         T000B6_A57BR_Demographics_Occupation = new String[] {""} ;
         T000B6_n57BR_Demographics_Occupation = new bool[] {false} ;
         T000B6_A58BR_Demographics_Insurance = new String[] {""} ;
         T000B6_n58BR_Demographics_Insurance = new bool[] {false} ;
         T000B6_A59BR_Demographics_Province = new String[] {""} ;
         T000B6_n59BR_Demographics_Province = new bool[] {false} ;
         T000B6_A60BR_Demographics_City = new String[] {""} ;
         T000B6_n60BR_Demographics_City = new bool[] {false} ;
         T000B6_A19BR_EncounterID = new long[1] ;
         T000B7_A85BR_Information_ID = new long[1] ;
         T000B7_n85BR_Information_ID = new bool[] {false} ;
         T000B8_A36BR_Information_PatientNo = new String[] {""} ;
         T000B8_n36BR_Information_PatientNo = new bool[] {false} ;
         T000B9_A61BR_Demographics_ID = new long[1] ;
         T000B3_A61BR_Demographics_ID = new long[1] ;
         T000B3_A455BR_Demographics_Sex_Code = new String[] {""} ;
         T000B3_n455BR_Demographics_Sex_Code = new bool[] {false} ;
         T000B3_A456BR_Demographics_MarritalStatus_Code = new String[] {""} ;
         T000B3_n456BR_Demographics_MarritalStatus_Code = new bool[] {false} ;
         T000B3_A457BR_Demographics_Ethnic_Code = new String[] {""} ;
         T000B3_n457BR_Demographics_Ethnic_Code = new bool[] {false} ;
         T000B3_A458BR_Demographics_Education_Code = new String[] {""} ;
         T000B3_n458BR_Demographics_Education_Code = new bool[] {false} ;
         T000B3_A459BR_Demographics_Insurance_Code = new String[] {""} ;
         T000B3_n459BR_Demographics_Insurance_Code = new bool[] {false} ;
         T000B3_A53BR_Demographics_BirthDate = new DateTime[] {DateTime.MinValue} ;
         T000B3_n53BR_Demographics_BirthDate = new bool[] {false} ;
         T000B3_A54BR_Demographics_Sex = new String[] {""} ;
         T000B3_n54BR_Demographics_Sex = new bool[] {false} ;
         T000B3_A63BR_Demographics_MarritalStatus = new String[] {""} ;
         T000B3_n63BR_Demographics_MarritalStatus = new bool[] {false} ;
         T000B3_A55BR_Demographics_Ethnic = new String[] {""} ;
         T000B3_n55BR_Demographics_Ethnic = new bool[] {false} ;
         T000B3_A56BR_Demographics_Education = new String[] {""} ;
         T000B3_n56BR_Demographics_Education = new bool[] {false} ;
         T000B3_A57BR_Demographics_Occupation = new String[] {""} ;
         T000B3_n57BR_Demographics_Occupation = new bool[] {false} ;
         T000B3_A58BR_Demographics_Insurance = new String[] {""} ;
         T000B3_n58BR_Demographics_Insurance = new bool[] {false} ;
         T000B3_A59BR_Demographics_Province = new String[] {""} ;
         T000B3_n59BR_Demographics_Province = new bool[] {false} ;
         T000B3_A60BR_Demographics_City = new String[] {""} ;
         T000B3_n60BR_Demographics_City = new bool[] {false} ;
         T000B3_A19BR_EncounterID = new long[1] ;
         T000B10_A61BR_Demographics_ID = new long[1] ;
         T000B11_A61BR_Demographics_ID = new long[1] ;
         T000B2_A61BR_Demographics_ID = new long[1] ;
         T000B2_A455BR_Demographics_Sex_Code = new String[] {""} ;
         T000B2_n455BR_Demographics_Sex_Code = new bool[] {false} ;
         T000B2_A456BR_Demographics_MarritalStatus_Code = new String[] {""} ;
         T000B2_n456BR_Demographics_MarritalStatus_Code = new bool[] {false} ;
         T000B2_A457BR_Demographics_Ethnic_Code = new String[] {""} ;
         T000B2_n457BR_Demographics_Ethnic_Code = new bool[] {false} ;
         T000B2_A458BR_Demographics_Education_Code = new String[] {""} ;
         T000B2_n458BR_Demographics_Education_Code = new bool[] {false} ;
         T000B2_A459BR_Demographics_Insurance_Code = new String[] {""} ;
         T000B2_n459BR_Demographics_Insurance_Code = new bool[] {false} ;
         T000B2_A53BR_Demographics_BirthDate = new DateTime[] {DateTime.MinValue} ;
         T000B2_n53BR_Demographics_BirthDate = new bool[] {false} ;
         T000B2_A54BR_Demographics_Sex = new String[] {""} ;
         T000B2_n54BR_Demographics_Sex = new bool[] {false} ;
         T000B2_A63BR_Demographics_MarritalStatus = new String[] {""} ;
         T000B2_n63BR_Demographics_MarritalStatus = new bool[] {false} ;
         T000B2_A55BR_Demographics_Ethnic = new String[] {""} ;
         T000B2_n55BR_Demographics_Ethnic = new bool[] {false} ;
         T000B2_A56BR_Demographics_Education = new String[] {""} ;
         T000B2_n56BR_Demographics_Education = new bool[] {false} ;
         T000B2_A57BR_Demographics_Occupation = new String[] {""} ;
         T000B2_n57BR_Demographics_Occupation = new bool[] {false} ;
         T000B2_A58BR_Demographics_Insurance = new String[] {""} ;
         T000B2_n58BR_Demographics_Insurance = new bool[] {false} ;
         T000B2_A59BR_Demographics_Province = new String[] {""} ;
         T000B2_n59BR_Demographics_Province = new bool[] {false} ;
         T000B2_A60BR_Demographics_City = new String[] {""} ;
         T000B2_n60BR_Demographics_City = new bool[] {false} ;
         T000B2_A19BR_EncounterID = new long[1] ;
         T000B12_A61BR_Demographics_ID = new long[1] ;
         T000B15_A85BR_Information_ID = new long[1] ;
         T000B15_n85BR_Information_ID = new bool[] {false} ;
         T000B16_A36BR_Information_PatientNo = new String[] {""} ;
         T000B16_n36BR_Information_PatientNo = new bool[] {false} ;
         T000B17_A61BR_Demographics_ID = new long[1] ;
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         gxdynajaxctrlcodr = new GeneXus.Utils.GxStringCollection();
         gxdynajaxctrldescr = new GeneXus.Utils.GxStringCollection();
         gxwrpcisep = "";
         T000B18_A167XT_DefineCodeID = new long[1] ;
         T000B18_A168XT_DefineCodeName = new String[] {""} ;
         T000B18_n168XT_DefineCodeName = new bool[] {false} ;
         T000B18_A165XT_DefindcodeTypeID = new long[1] ;
         T000B18_A432XT_TenantCode = new String[] {""} ;
         T000B18_n432XT_TenantCode = new bool[] {false} ;
         T000B19_A167XT_DefineCodeID = new long[1] ;
         T000B19_A168XT_DefineCodeName = new String[] {""} ;
         T000B19_n168XT_DefineCodeName = new bool[] {false} ;
         T000B19_A165XT_DefindcodeTypeID = new long[1] ;
         T000B19_A432XT_TenantCode = new String[] {""} ;
         T000B19_n432XT_TenantCode = new bool[] {false} ;
         T000B20_A167XT_DefineCodeID = new long[1] ;
         T000B20_A168XT_DefineCodeName = new String[] {""} ;
         T000B20_n168XT_DefineCodeName = new bool[] {false} ;
         T000B20_A165XT_DefindcodeTypeID = new long[1] ;
         T000B20_A432XT_TenantCode = new String[] {""} ;
         T000B20_n432XT_TenantCode = new bool[] {false} ;
         T000B21_A167XT_DefineCodeID = new long[1] ;
         T000B21_A168XT_DefineCodeName = new String[] {""} ;
         T000B21_n168XT_DefineCodeName = new bool[] {false} ;
         T000B21_A165XT_DefindcodeTypeID = new long[1] ;
         T000B21_A432XT_TenantCode = new String[] {""} ;
         T000B21_n432XT_TenantCode = new bool[] {false} ;
         T000B22_A167XT_DefineCodeID = new long[1] ;
         T000B22_A168XT_DefineCodeName = new String[] {""} ;
         T000B22_n168XT_DefineCodeName = new bool[] {false} ;
         T000B22_A165XT_DefindcodeTypeID = new long[1] ;
         T000B22_A432XT_TenantCode = new String[] {""} ;
         T000B22_n432XT_TenantCode = new bool[] {false} ;
         GXt_char1 = "";
         T000B23_A85BR_Information_ID = new long[1] ;
         T000B23_n85BR_Information_ID = new bool[] {false} ;
         T000B24_A36BR_Information_PatientNo = new String[] {""} ;
         T000B24_n36BR_Information_PatientNo = new bool[] {false} ;
         isValidOutput = new GxUnknownObjectCollection();
         pr_datastore1 = new DataStoreProvider(context, new GeneXus.Programs.br_demographics__datastore1(),
            new Object[][] {
            }
         );
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_demographics__default(),
            new Object[][] {
                new Object[] {
               T000B2_A61BR_Demographics_ID, T000B2_A455BR_Demographics_Sex_Code, T000B2_n455BR_Demographics_Sex_Code, T000B2_A456BR_Demographics_MarritalStatus_Code, T000B2_n456BR_Demographics_MarritalStatus_Code, T000B2_A457BR_Demographics_Ethnic_Code, T000B2_n457BR_Demographics_Ethnic_Code, T000B2_A458BR_Demographics_Education_Code, T000B2_n458BR_Demographics_Education_Code, T000B2_A459BR_Demographics_Insurance_Code,
               T000B2_n459BR_Demographics_Insurance_Code, T000B2_A53BR_Demographics_BirthDate, T000B2_n53BR_Demographics_BirthDate, T000B2_A54BR_Demographics_Sex, T000B2_n54BR_Demographics_Sex, T000B2_A63BR_Demographics_MarritalStatus, T000B2_n63BR_Demographics_MarritalStatus, T000B2_A55BR_Demographics_Ethnic, T000B2_n55BR_Demographics_Ethnic, T000B2_A56BR_Demographics_Education,
               T000B2_n56BR_Demographics_Education, T000B2_A57BR_Demographics_Occupation, T000B2_n57BR_Demographics_Occupation, T000B2_A58BR_Demographics_Insurance, T000B2_n58BR_Demographics_Insurance, T000B2_A59BR_Demographics_Province, T000B2_n59BR_Demographics_Province, T000B2_A60BR_Demographics_City, T000B2_n60BR_Demographics_City, T000B2_A19BR_EncounterID
               }
               , new Object[] {
               T000B3_A61BR_Demographics_ID, T000B3_A455BR_Demographics_Sex_Code, T000B3_n455BR_Demographics_Sex_Code, T000B3_A456BR_Demographics_MarritalStatus_Code, T000B3_n456BR_Demographics_MarritalStatus_Code, T000B3_A457BR_Demographics_Ethnic_Code, T000B3_n457BR_Demographics_Ethnic_Code, T000B3_A458BR_Demographics_Education_Code, T000B3_n458BR_Demographics_Education_Code, T000B3_A459BR_Demographics_Insurance_Code,
               T000B3_n459BR_Demographics_Insurance_Code, T000B3_A53BR_Demographics_BirthDate, T000B3_n53BR_Demographics_BirthDate, T000B3_A54BR_Demographics_Sex, T000B3_n54BR_Demographics_Sex, T000B3_A63BR_Demographics_MarritalStatus, T000B3_n63BR_Demographics_MarritalStatus, T000B3_A55BR_Demographics_Ethnic, T000B3_n55BR_Demographics_Ethnic, T000B3_A56BR_Demographics_Education,
               T000B3_n56BR_Demographics_Education, T000B3_A57BR_Demographics_Occupation, T000B3_n57BR_Demographics_Occupation, T000B3_A58BR_Demographics_Insurance, T000B3_n58BR_Demographics_Insurance, T000B3_A59BR_Demographics_Province, T000B3_n59BR_Demographics_Province, T000B3_A60BR_Demographics_City, T000B3_n60BR_Demographics_City, T000B3_A19BR_EncounterID
               }
               , new Object[] {
               T000B4_A85BR_Information_ID, T000B4_n85BR_Information_ID
               }
               , new Object[] {
               T000B5_A36BR_Information_PatientNo, T000B5_n36BR_Information_PatientNo
               }
               , new Object[] {
               T000B6_A85BR_Information_ID, T000B6_n85BR_Information_ID, T000B6_A61BR_Demographics_ID, T000B6_A455BR_Demographics_Sex_Code, T000B6_n455BR_Demographics_Sex_Code, T000B6_A456BR_Demographics_MarritalStatus_Code, T000B6_n456BR_Demographics_MarritalStatus_Code, T000B6_A457BR_Demographics_Ethnic_Code, T000B6_n457BR_Demographics_Ethnic_Code, T000B6_A458BR_Demographics_Education_Code,
               T000B6_n458BR_Demographics_Education_Code, T000B6_A459BR_Demographics_Insurance_Code, T000B6_n459BR_Demographics_Insurance_Code, T000B6_A36BR_Information_PatientNo, T000B6_n36BR_Information_PatientNo, T000B6_A53BR_Demographics_BirthDate, T000B6_n53BR_Demographics_BirthDate, T000B6_A54BR_Demographics_Sex, T000B6_n54BR_Demographics_Sex, T000B6_A63BR_Demographics_MarritalStatus,
               T000B6_n63BR_Demographics_MarritalStatus, T000B6_A55BR_Demographics_Ethnic, T000B6_n55BR_Demographics_Ethnic, T000B6_A56BR_Demographics_Education, T000B6_n56BR_Demographics_Education, T000B6_A57BR_Demographics_Occupation, T000B6_n57BR_Demographics_Occupation, T000B6_A58BR_Demographics_Insurance, T000B6_n58BR_Demographics_Insurance, T000B6_A59BR_Demographics_Province,
               T000B6_n59BR_Demographics_Province, T000B6_A60BR_Demographics_City, T000B6_n60BR_Demographics_City, T000B6_A19BR_EncounterID
               }
               , new Object[] {
               T000B7_A85BR_Information_ID, T000B7_n85BR_Information_ID
               }
               , new Object[] {
               T000B8_A36BR_Information_PatientNo, T000B8_n36BR_Information_PatientNo
               }
               , new Object[] {
               T000B9_A61BR_Demographics_ID
               }
               , new Object[] {
               T000B10_A61BR_Demographics_ID
               }
               , new Object[] {
               T000B11_A61BR_Demographics_ID
               }
               , new Object[] {
               T000B12_A61BR_Demographics_ID
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000B15_A85BR_Information_ID, T000B15_n85BR_Information_ID
               }
               , new Object[] {
               T000B16_A36BR_Information_PatientNo, T000B16_n36BR_Information_PatientNo
               }
               , new Object[] {
               T000B17_A61BR_Demographics_ID
               }
               , new Object[] {
               T000B18_A167XT_DefineCodeID, T000B18_A168XT_DefineCodeName, T000B18_n168XT_DefineCodeName, T000B18_A165XT_DefindcodeTypeID, T000B18_A432XT_TenantCode, T000B18_n432XT_TenantCode
               }
               , new Object[] {
               T000B19_A167XT_DefineCodeID, T000B19_A168XT_DefineCodeName, T000B19_n168XT_DefineCodeName, T000B19_A165XT_DefindcodeTypeID, T000B19_A432XT_TenantCode, T000B19_n432XT_TenantCode
               }
               , new Object[] {
               T000B20_A167XT_DefineCodeID, T000B20_A168XT_DefineCodeName, T000B20_n168XT_DefineCodeName, T000B20_A165XT_DefindcodeTypeID, T000B20_A432XT_TenantCode, T000B20_n432XT_TenantCode
               }
               , new Object[] {
               T000B21_A167XT_DefineCodeID, T000B21_A168XT_DefineCodeName, T000B21_n168XT_DefineCodeName, T000B21_A165XT_DefindcodeTypeID, T000B21_A432XT_TenantCode, T000B21_n432XT_TenantCode
               }
               , new Object[] {
               T000B22_A167XT_DefineCodeID, T000B22_A168XT_DefineCodeName, T000B22_n168XT_DefineCodeName, T000B22_A165XT_DefindcodeTypeID, T000B22_A432XT_TenantCode, T000B22_n432XT_TenantCode
               }
               , new Object[] {
               T000B23_A85BR_Information_ID, T000B23_n85BR_Information_ID
               }
               , new Object[] {
               T000B24_A36BR_Information_PatientNo, T000B24_n36BR_Information_PatientNo
               }
            }
         );
         AV16Pgmname = "BR_Demographics";
      }

      private short GxWebError ;
      private short gxcookieaux ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short RcdFound12 ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int trnEnded ;
      private int edtBR_Demographics_ID_Enabled ;
      private int edtBR_EncounterID_Enabled ;
      private int imgprompt_19_Visible ;
      private int edtBR_Information_PatientNo_Enabled ;
      private int edtBR_Demographics_BirthDate_Enabled ;
      private int edtBR_Demographics_Occupation_Enabled ;
      private int edtBR_Demographics_Province_Enabled ;
      private int edtBR_Demographics_City_Enabled ;
      private int bttBtntrn_enter_Visible ;
      private int bttBtntrn_enter_Enabled ;
      private int bttBtntrn_cancel_Visible ;
      private int bttBtntrn_delete_Visible ;
      private int bttBtntrn_delete_Enabled ;
      private int AV17GXV1 ;
      private int idxLst ;
      private int gxdynajaxindex ;
      private long wcpOAV12BR_Demographics_ID ;
      private long Z61BR_Demographics_ID ;
      private long Z19BR_EncounterID ;
      private long N19BR_EncounterID ;
      private long A19BR_EncounterID ;
      private long A85BR_Information_ID ;
      private long AV12BR_Demographics_ID ;
      private long A61BR_Demographics_ID ;
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
      private String edtBR_EncounterID_Internalname ;
      private String dynBR_Demographics_Sex_Internalname ;
      private String dynBR_Demographics_MarritalStatus_Internalname ;
      private String dynBR_Demographics_Ethnic_Internalname ;
      private String dynBR_Demographics_Education_Internalname ;
      private String dynBR_Demographics_Insurance_Internalname ;
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
      private String edtBR_Demographics_ID_Internalname ;
      private String edtBR_Demographics_ID_Jsonclick ;
      private String TempTags ;
      private String edtBR_EncounterID_Jsonclick ;
      private String sImgUrl ;
      private String imgprompt_19_Internalname ;
      private String imgprompt_19_Link ;
      private String edtBR_Information_PatientNo_Internalname ;
      private String edtBR_Information_PatientNo_Jsonclick ;
      private String edtBR_Demographics_BirthDate_Internalname ;
      private String edtBR_Demographics_BirthDate_Jsonclick ;
      private String dynBR_Demographics_Sex_Jsonclick ;
      private String dynBR_Demographics_MarritalStatus_Jsonclick ;
      private String dynBR_Demographics_Ethnic_Jsonclick ;
      private String dynBR_Demographics_Education_Jsonclick ;
      private String edtBR_Demographics_Occupation_Internalname ;
      private String edtBR_Demographics_Occupation_Jsonclick ;
      private String dynBR_Demographics_Insurance_Jsonclick ;
      private String edtBR_Demographics_Province_Internalname ;
      private String edtBR_Demographics_Province_Jsonclick ;
      private String edtBR_Demographics_City_Internalname ;
      private String edtBR_Demographics_City_Jsonclick ;
      private String bttBtntrn_enter_Internalname ;
      private String bttBtntrn_enter_Jsonclick ;
      private String bttBtntrn_cancel_Internalname ;
      private String bttBtntrn_cancel_Jsonclick ;
      private String bttBtntrn_delete_Internalname ;
      private String bttBtntrn_delete_Jsonclick ;
      private String AV16Pgmname ;
      private String Dvpanel_tableattributes_Objectcall ;
      private String Dvpanel_tableattributes_Class ;
      private String Dvpanel_tableattributes_Height ;
      private String forbiddenHiddens ;
      private String hsh ;
      private String sMode12 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String gxwrpcisep ;
      private String GXt_char1 ;
      private DateTime Z53BR_Demographics_BirthDate ;
      private DateTime A53BR_Demographics_BirthDate ;
      private bool entryPointCalled ;
      private bool n54BR_Demographics_Sex ;
      private bool n63BR_Demographics_MarritalStatus ;
      private bool n55BR_Demographics_Ethnic ;
      private bool n56BR_Demographics_Education ;
      private bool n58BR_Demographics_Insurance ;
      private bool n85BR_Information_ID ;
      private bool toggleJsOutput ;
      private bool wbErr ;
      private bool Dvpanel_tableattributes_Autowidth ;
      private bool Dvpanel_tableattributes_Autoheight ;
      private bool Dvpanel_tableattributes_Collapsible ;
      private bool Dvpanel_tableattributes_Collapsed ;
      private bool Dvpanel_tableattributes_Showcollapseicon ;
      private bool Dvpanel_tableattributes_Autoscroll ;
      private bool n36BR_Information_PatientNo ;
      private bool n53BR_Demographics_BirthDate ;
      private bool n57BR_Demographics_Occupation ;
      private bool n59BR_Demographics_Province ;
      private bool n60BR_Demographics_City ;
      private bool n455BR_Demographics_Sex_Code ;
      private bool n456BR_Demographics_MarritalStatus_Code ;
      private bool n457BR_Demographics_Ethnic_Code ;
      private bool n458BR_Demographics_Education_Code ;
      private bool n459BR_Demographics_Insurance_Code ;
      private bool Dvpanel_tableattributes_Enabled ;
      private bool Dvpanel_tableattributes_Showheader ;
      private bool Dvpanel_tableattributes_Visible ;
      private bool AV13IsAuthorized ;
      private bool GXt_boolean2 ;
      private bool returnInSub ;
      private bool Gx_longc ;
      private bool gxdyncontrolsrefreshing ;
      private String Z455BR_Demographics_Sex_Code ;
      private String Z456BR_Demographics_MarritalStatus_Code ;
      private String Z457BR_Demographics_Ethnic_Code ;
      private String Z458BR_Demographics_Education_Code ;
      private String Z459BR_Demographics_Insurance_Code ;
      private String Z54BR_Demographics_Sex ;
      private String Z63BR_Demographics_MarritalStatus ;
      private String Z55BR_Demographics_Ethnic ;
      private String Z56BR_Demographics_Education ;
      private String Z57BR_Demographics_Occupation ;
      private String Z58BR_Demographics_Insurance ;
      private String Z59BR_Demographics_Province ;
      private String Z60BR_Demographics_City ;
      private String AV15tCurrentCode ;
      private String A54BR_Demographics_Sex ;
      private String A63BR_Demographics_MarritalStatus ;
      private String A55BR_Demographics_Ethnic ;
      private String A56BR_Demographics_Education ;
      private String A58BR_Demographics_Insurance ;
      private String A36BR_Information_PatientNo ;
      private String A57BR_Demographics_Occupation ;
      private String A59BR_Demographics_Province ;
      private String A60BR_Demographics_City ;
      private String A455BR_Demographics_Sex_Code ;
      private String A456BR_Demographics_MarritalStatus_Code ;
      private String A457BR_Demographics_Ethnic_Code ;
      private String A458BR_Demographics_Education_Code ;
      private String A459BR_Demographics_Insurance_Code ;
      private String Z36BR_Information_PatientNo ;
      private IGxSession AV9WebSession ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrlcodr ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrldescr ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXUserControl ucDvpanel_tableattributes ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private GXCombobox dynBR_Demographics_Sex ;
      private GXCombobox dynBR_Demographics_MarritalStatus ;
      private GXCombobox dynBR_Demographics_Ethnic ;
      private GXCombobox dynBR_Demographics_Education ;
      private GXCombobox dynBR_Demographics_Insurance ;
      private IDataStoreProvider pr_default ;
      private long[] T000B4_A85BR_Information_ID ;
      private bool[] T000B4_n85BR_Information_ID ;
      private String[] T000B5_A36BR_Information_PatientNo ;
      private bool[] T000B5_n36BR_Information_PatientNo ;
      private long[] T000B6_A85BR_Information_ID ;
      private bool[] T000B6_n85BR_Information_ID ;
      private long[] T000B6_A61BR_Demographics_ID ;
      private String[] T000B6_A455BR_Demographics_Sex_Code ;
      private bool[] T000B6_n455BR_Demographics_Sex_Code ;
      private String[] T000B6_A456BR_Demographics_MarritalStatus_Code ;
      private bool[] T000B6_n456BR_Demographics_MarritalStatus_Code ;
      private String[] T000B6_A457BR_Demographics_Ethnic_Code ;
      private bool[] T000B6_n457BR_Demographics_Ethnic_Code ;
      private String[] T000B6_A458BR_Demographics_Education_Code ;
      private bool[] T000B6_n458BR_Demographics_Education_Code ;
      private String[] T000B6_A459BR_Demographics_Insurance_Code ;
      private bool[] T000B6_n459BR_Demographics_Insurance_Code ;
      private String[] T000B6_A36BR_Information_PatientNo ;
      private bool[] T000B6_n36BR_Information_PatientNo ;
      private DateTime[] T000B6_A53BR_Demographics_BirthDate ;
      private bool[] T000B6_n53BR_Demographics_BirthDate ;
      private String[] T000B6_A54BR_Demographics_Sex ;
      private bool[] T000B6_n54BR_Demographics_Sex ;
      private String[] T000B6_A63BR_Demographics_MarritalStatus ;
      private bool[] T000B6_n63BR_Demographics_MarritalStatus ;
      private String[] T000B6_A55BR_Demographics_Ethnic ;
      private bool[] T000B6_n55BR_Demographics_Ethnic ;
      private String[] T000B6_A56BR_Demographics_Education ;
      private bool[] T000B6_n56BR_Demographics_Education ;
      private String[] T000B6_A57BR_Demographics_Occupation ;
      private bool[] T000B6_n57BR_Demographics_Occupation ;
      private String[] T000B6_A58BR_Demographics_Insurance ;
      private bool[] T000B6_n58BR_Demographics_Insurance ;
      private String[] T000B6_A59BR_Demographics_Province ;
      private bool[] T000B6_n59BR_Demographics_Province ;
      private String[] T000B6_A60BR_Demographics_City ;
      private bool[] T000B6_n60BR_Demographics_City ;
      private long[] T000B6_A19BR_EncounterID ;
      private long[] T000B7_A85BR_Information_ID ;
      private bool[] T000B7_n85BR_Information_ID ;
      private String[] T000B8_A36BR_Information_PatientNo ;
      private bool[] T000B8_n36BR_Information_PatientNo ;
      private long[] T000B9_A61BR_Demographics_ID ;
      private long[] T000B3_A61BR_Demographics_ID ;
      private String[] T000B3_A455BR_Demographics_Sex_Code ;
      private bool[] T000B3_n455BR_Demographics_Sex_Code ;
      private String[] T000B3_A456BR_Demographics_MarritalStatus_Code ;
      private bool[] T000B3_n456BR_Demographics_MarritalStatus_Code ;
      private String[] T000B3_A457BR_Demographics_Ethnic_Code ;
      private bool[] T000B3_n457BR_Demographics_Ethnic_Code ;
      private String[] T000B3_A458BR_Demographics_Education_Code ;
      private bool[] T000B3_n458BR_Demographics_Education_Code ;
      private String[] T000B3_A459BR_Demographics_Insurance_Code ;
      private bool[] T000B3_n459BR_Demographics_Insurance_Code ;
      private DateTime[] T000B3_A53BR_Demographics_BirthDate ;
      private bool[] T000B3_n53BR_Demographics_BirthDate ;
      private String[] T000B3_A54BR_Demographics_Sex ;
      private bool[] T000B3_n54BR_Demographics_Sex ;
      private String[] T000B3_A63BR_Demographics_MarritalStatus ;
      private bool[] T000B3_n63BR_Demographics_MarritalStatus ;
      private String[] T000B3_A55BR_Demographics_Ethnic ;
      private bool[] T000B3_n55BR_Demographics_Ethnic ;
      private String[] T000B3_A56BR_Demographics_Education ;
      private bool[] T000B3_n56BR_Demographics_Education ;
      private String[] T000B3_A57BR_Demographics_Occupation ;
      private bool[] T000B3_n57BR_Demographics_Occupation ;
      private String[] T000B3_A58BR_Demographics_Insurance ;
      private bool[] T000B3_n58BR_Demographics_Insurance ;
      private String[] T000B3_A59BR_Demographics_Province ;
      private bool[] T000B3_n59BR_Demographics_Province ;
      private String[] T000B3_A60BR_Demographics_City ;
      private bool[] T000B3_n60BR_Demographics_City ;
      private long[] T000B3_A19BR_EncounterID ;
      private long[] T000B10_A61BR_Demographics_ID ;
      private long[] T000B11_A61BR_Demographics_ID ;
      private long[] T000B2_A61BR_Demographics_ID ;
      private String[] T000B2_A455BR_Demographics_Sex_Code ;
      private bool[] T000B2_n455BR_Demographics_Sex_Code ;
      private String[] T000B2_A456BR_Demographics_MarritalStatus_Code ;
      private bool[] T000B2_n456BR_Demographics_MarritalStatus_Code ;
      private String[] T000B2_A457BR_Demographics_Ethnic_Code ;
      private bool[] T000B2_n457BR_Demographics_Ethnic_Code ;
      private String[] T000B2_A458BR_Demographics_Education_Code ;
      private bool[] T000B2_n458BR_Demographics_Education_Code ;
      private String[] T000B2_A459BR_Demographics_Insurance_Code ;
      private bool[] T000B2_n459BR_Demographics_Insurance_Code ;
      private DateTime[] T000B2_A53BR_Demographics_BirthDate ;
      private bool[] T000B2_n53BR_Demographics_BirthDate ;
      private String[] T000B2_A54BR_Demographics_Sex ;
      private bool[] T000B2_n54BR_Demographics_Sex ;
      private String[] T000B2_A63BR_Demographics_MarritalStatus ;
      private bool[] T000B2_n63BR_Demographics_MarritalStatus ;
      private String[] T000B2_A55BR_Demographics_Ethnic ;
      private bool[] T000B2_n55BR_Demographics_Ethnic ;
      private String[] T000B2_A56BR_Demographics_Education ;
      private bool[] T000B2_n56BR_Demographics_Education ;
      private String[] T000B2_A57BR_Demographics_Occupation ;
      private bool[] T000B2_n57BR_Demographics_Occupation ;
      private String[] T000B2_A58BR_Demographics_Insurance ;
      private bool[] T000B2_n58BR_Demographics_Insurance ;
      private String[] T000B2_A59BR_Demographics_Province ;
      private bool[] T000B2_n59BR_Demographics_Province ;
      private String[] T000B2_A60BR_Demographics_City ;
      private bool[] T000B2_n60BR_Demographics_City ;
      private long[] T000B2_A19BR_EncounterID ;
      private long[] T000B12_A61BR_Demographics_ID ;
      private long[] T000B15_A85BR_Information_ID ;
      private bool[] T000B15_n85BR_Information_ID ;
      private String[] T000B16_A36BR_Information_PatientNo ;
      private bool[] T000B16_n36BR_Information_PatientNo ;
      private long[] T000B17_A61BR_Demographics_ID ;
      private long[] T000B18_A167XT_DefineCodeID ;
      private String[] T000B18_A168XT_DefineCodeName ;
      private bool[] T000B18_n168XT_DefineCodeName ;
      private long[] T000B18_A165XT_DefindcodeTypeID ;
      private String[] T000B18_A432XT_TenantCode ;
      private bool[] T000B18_n432XT_TenantCode ;
      private long[] T000B19_A167XT_DefineCodeID ;
      private String[] T000B19_A168XT_DefineCodeName ;
      private bool[] T000B19_n168XT_DefineCodeName ;
      private long[] T000B19_A165XT_DefindcodeTypeID ;
      private String[] T000B19_A432XT_TenantCode ;
      private bool[] T000B19_n432XT_TenantCode ;
      private long[] T000B20_A167XT_DefineCodeID ;
      private String[] T000B20_A168XT_DefineCodeName ;
      private bool[] T000B20_n168XT_DefineCodeName ;
      private long[] T000B20_A165XT_DefindcodeTypeID ;
      private String[] T000B20_A432XT_TenantCode ;
      private bool[] T000B20_n432XT_TenantCode ;
      private long[] T000B21_A167XT_DefineCodeID ;
      private String[] T000B21_A168XT_DefineCodeName ;
      private bool[] T000B21_n168XT_DefineCodeName ;
      private long[] T000B21_A165XT_DefindcodeTypeID ;
      private String[] T000B21_A432XT_TenantCode ;
      private bool[] T000B21_n432XT_TenantCode ;
      private long[] T000B22_A167XT_DefineCodeID ;
      private String[] T000B22_A168XT_DefineCodeName ;
      private bool[] T000B22_n168XT_DefineCodeName ;
      private long[] T000B22_A165XT_DefindcodeTypeID ;
      private String[] T000B22_A432XT_TenantCode ;
      private bool[] T000B22_n432XT_TenantCode ;
      private long[] T000B23_A85BR_Information_ID ;
      private bool[] T000B23_n85BR_Information_ID ;
      private String[] T000B24_A36BR_Information_PatientNo ;
      private bool[] T000B24_n36BR_Information_PatientNo ;
      private IDataStoreProvider pr_datastore1 ;
      private GXWebForm Form ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV8TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute AV11TrnContextAtt ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV7WWPContext ;
   }

   public class br_demographics__datastore1 : DataStoreHelperBase, IDataStoreHelper
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

 public class br_demographics__default : DataStoreHelperBase, IDataStoreHelper
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
       ,new ForEachCursor(def[22])
     };
  }

  private static CursorDef[] def;
  private void cursorDefinitions( )
  {
     if ( def == null )
     {
        Object[] prmT000B6 ;
        prmT000B6 = new Object[] {
        new Object[] {"@BR_Demographics_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000B4 ;
        prmT000B4 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000B5 ;
        prmT000B5 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000B7 ;
        prmT000B7 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000B8 ;
        prmT000B8 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000B9 ;
        prmT000B9 = new Object[] {
        new Object[] {"@BR_Demographics_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000B3 ;
        prmT000B3 = new Object[] {
        new Object[] {"@BR_Demographics_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000B10 ;
        prmT000B10 = new Object[] {
        new Object[] {"@BR_Demographics_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000B11 ;
        prmT000B11 = new Object[] {
        new Object[] {"@BR_Demographics_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000B2 ;
        prmT000B2 = new Object[] {
        new Object[] {"@BR_Demographics_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000B12 ;
        prmT000B12 = new Object[] {
        new Object[] {"@BR_Demographics_Sex_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Demographics_MarritalStatus_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Demographics_Ethnic_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Demographics_Education_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Demographics_Insurance_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Demographics_BirthDate",SqlDbType.DateTime,8,0} ,
        new Object[] {"@BR_Demographics_Sex",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Demographics_MarritalStatus",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Demographics_Ethnic",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Demographics_Education",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Demographics_Occupation",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Demographics_Insurance",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Demographics_Province",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Demographics_City",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000B13 ;
        prmT000B13 = new Object[] {
        new Object[] {"@BR_Demographics_Sex_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Demographics_MarritalStatus_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Demographics_Ethnic_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Demographics_Education_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Demographics_Insurance_Code",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Demographics_BirthDate",SqlDbType.DateTime,8,0} ,
        new Object[] {"@BR_Demographics_Sex",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Demographics_MarritalStatus",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Demographics_Ethnic",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Demographics_Education",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Demographics_Occupation",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Demographics_Insurance",SqlDbType.NVarChar,100,0} ,
        new Object[] {"@BR_Demographics_Province",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_Demographics_City",SqlDbType.NVarChar,40,0} ,
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0} ,
        new Object[] {"@BR_Demographics_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000B14 ;
        prmT000B14 = new Object[] {
        new Object[] {"@BR_Demographics_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000B15 ;
        prmT000B15 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000B16 ;
        prmT000B16 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000B17 ;
        prmT000B17 = new Object[] {
        } ;
        Object[] prmT000B18 ;
        prmT000B18 = new Object[] {
        new Object[] {"@AV15tCurrentCode",SqlDbType.NVarChar,40,0}
        } ;
        Object[] prmT000B19 ;
        prmT000B19 = new Object[] {
        new Object[] {"@AV15tCurrentCode",SqlDbType.NVarChar,40,0}
        } ;
        Object[] prmT000B20 ;
        prmT000B20 = new Object[] {
        new Object[] {"@AV15tCurrentCode",SqlDbType.NVarChar,40,0}
        } ;
        Object[] prmT000B21 ;
        prmT000B21 = new Object[] {
        new Object[] {"@AV15tCurrentCode",SqlDbType.NVarChar,40,0}
        } ;
        Object[] prmT000B22 ;
        prmT000B22 = new Object[] {
        new Object[] {"@AV15tCurrentCode",SqlDbType.NVarChar,40,0}
        } ;
        Object[] prmT000B23 ;
        prmT000B23 = new Object[] {
        new Object[] {"@BR_EncounterID",SqlDbType.Decimal,18,0}
        } ;
        Object[] prmT000B24 ;
        prmT000B24 = new Object[] {
        new Object[] {"@BR_Information_ID",SqlDbType.Decimal,18,0}
        } ;
        def= new CursorDef[] {
            new CursorDef("T000B2", "SELECT [BR_Demographics_ID], [BR_Demographics_Sex_Code], [BR_Demographics_MarritalStatus_Code], [BR_Demographics_Ethnic_Code], [BR_Demographics_Education_Code], [BR_Demographics_Insurance_Code], [BR_Demographics_BirthDate], [BR_Demographics_Sex], [BR_Demographics_MarritalStatus], [BR_Demographics_Ethnic], [BR_Demographics_Education], [BR_Demographics_Occupation], [BR_Demographics_Insurance], [BR_Demographics_Province], [BR_Demographics_City], [BR_EncounterID] FROM [BR_Demographics] WITH (UPDLOCK) WHERE [BR_Demographics_ID] = @BR_Demographics_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B2,1,0,true,false )
           ,new CursorDef("T000B3", "SELECT [BR_Demographics_ID], [BR_Demographics_Sex_Code], [BR_Demographics_MarritalStatus_Code], [BR_Demographics_Ethnic_Code], [BR_Demographics_Education_Code], [BR_Demographics_Insurance_Code], [BR_Demographics_BirthDate], [BR_Demographics_Sex], [BR_Demographics_MarritalStatus], [BR_Demographics_Ethnic], [BR_Demographics_Education], [BR_Demographics_Occupation], [BR_Demographics_Insurance], [BR_Demographics_Province], [BR_Demographics_City], [BR_EncounterID] FROM [BR_Demographics] WITH (NOLOCK) WHERE [BR_Demographics_ID] = @BR_Demographics_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B3,1,0,true,false )
           ,new CursorDef("T000B4", "SELECT [BR_Information_ID] FROM [BR_Encounter] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B4,1,0,true,false )
           ,new CursorDef("T000B5", "SELECT [BR_Information_PatientNo] FROM [BR_Information] WITH (NOLOCK) WHERE [BR_Information_ID] = @BR_Information_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B5,1,0,true,false )
           ,new CursorDef("T000B6", "SELECT T2.[BR_Information_ID], TM1.[BR_Demographics_ID], TM1.[BR_Demographics_Sex_Code], TM1.[BR_Demographics_MarritalStatus_Code], TM1.[BR_Demographics_Ethnic_Code], TM1.[BR_Demographics_Education_Code], TM1.[BR_Demographics_Insurance_Code], T3.[BR_Information_PatientNo], TM1.[BR_Demographics_BirthDate], TM1.[BR_Demographics_Sex], TM1.[BR_Demographics_MarritalStatus], TM1.[BR_Demographics_Ethnic], TM1.[BR_Demographics_Education], TM1.[BR_Demographics_Occupation], TM1.[BR_Demographics_Insurance], TM1.[BR_Demographics_Province], TM1.[BR_Demographics_City], TM1.[BR_EncounterID] FROM (([BR_Demographics] TM1 WITH (NOLOCK) INNER JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = TM1.[BR_EncounterID]) LEFT JOIN [BR_Information] T3 WITH (NOLOCK) ON T3.[BR_Information_ID] = T2.[BR_Information_ID]) WHERE TM1.[BR_Demographics_ID] = @BR_Demographics_ID ORDER BY TM1.[BR_Demographics_ID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000B6,100,0,true,false )
           ,new CursorDef("T000B7", "SELECT [BR_Information_ID] FROM [BR_Encounter] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B7,1,0,true,false )
           ,new CursorDef("T000B8", "SELECT [BR_Information_PatientNo] FROM [BR_Information] WITH (NOLOCK) WHERE [BR_Information_ID] = @BR_Information_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B8,1,0,true,false )
           ,new CursorDef("T000B9", "SELECT [BR_Demographics_ID] FROM [BR_Demographics] WITH (NOLOCK) WHERE [BR_Demographics_ID] = @BR_Demographics_ID  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000B9,1,0,true,false )
           ,new CursorDef("T000B10", "SELECT TOP 1 [BR_Demographics_ID] FROM [BR_Demographics] WITH (NOLOCK) WHERE ( [BR_Demographics_ID] > @BR_Demographics_ID) ORDER BY [BR_Demographics_ID]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000B10,1,0,true,true )
           ,new CursorDef("T000B11", "SELECT TOP 1 [BR_Demographics_ID] FROM [BR_Demographics] WITH (NOLOCK) WHERE ( [BR_Demographics_ID] < @BR_Demographics_ID) ORDER BY [BR_Demographics_ID] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000B11,1,0,true,true )
           ,new CursorDef("T000B12", "INSERT INTO [BR_Demographics]([BR_Demographics_Sex_Code], [BR_Demographics_MarritalStatus_Code], [BR_Demographics_Ethnic_Code], [BR_Demographics_Education_Code], [BR_Demographics_Insurance_Code], [BR_Demographics_BirthDate], [BR_Demographics_Sex], [BR_Demographics_MarritalStatus], [BR_Demographics_Ethnic], [BR_Demographics_Education], [BR_Demographics_Occupation], [BR_Demographics_Insurance], [BR_Demographics_Province], [BR_Demographics_City], [BR_EncounterID]) VALUES(@BR_Demographics_Sex_Code, @BR_Demographics_MarritalStatus_Code, @BR_Demographics_Ethnic_Code, @BR_Demographics_Education_Code, @BR_Demographics_Insurance_Code, @BR_Demographics_BirthDate, @BR_Demographics_Sex, @BR_Demographics_MarritalStatus, @BR_Demographics_Ethnic, @BR_Demographics_Education, @BR_Demographics_Occupation, @BR_Demographics_Insurance, @BR_Demographics_Province, @BR_Demographics_City, @BR_EncounterID); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmT000B12)
           ,new CursorDef("T000B13", "UPDATE [BR_Demographics] SET [BR_Demographics_Sex_Code]=@BR_Demographics_Sex_Code, [BR_Demographics_MarritalStatus_Code]=@BR_Demographics_MarritalStatus_Code, [BR_Demographics_Ethnic_Code]=@BR_Demographics_Ethnic_Code, [BR_Demographics_Education_Code]=@BR_Demographics_Education_Code, [BR_Demographics_Insurance_Code]=@BR_Demographics_Insurance_Code, [BR_Demographics_BirthDate]=@BR_Demographics_BirthDate, [BR_Demographics_Sex]=@BR_Demographics_Sex, [BR_Demographics_MarritalStatus]=@BR_Demographics_MarritalStatus, [BR_Demographics_Ethnic]=@BR_Demographics_Ethnic, [BR_Demographics_Education]=@BR_Demographics_Education, [BR_Demographics_Occupation]=@BR_Demographics_Occupation, [BR_Demographics_Insurance]=@BR_Demographics_Insurance, [BR_Demographics_Province]=@BR_Demographics_Province, [BR_Demographics_City]=@BR_Demographics_City, [BR_EncounterID]=@BR_EncounterID  WHERE [BR_Demographics_ID] = @BR_Demographics_ID", GxErrorMask.GX_NOMASK,prmT000B13)
           ,new CursorDef("T000B14", "DELETE FROM [BR_Demographics]  WHERE [BR_Demographics_ID] = @BR_Demographics_ID", GxErrorMask.GX_NOMASK,prmT000B14)
           ,new CursorDef("T000B15", "SELECT [BR_Information_ID] FROM [BR_Encounter] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B15,1,0,true,false )
           ,new CursorDef("T000B16", "SELECT [BR_Information_PatientNo] FROM [BR_Information] WITH (NOLOCK) WHERE [BR_Information_ID] = @BR_Information_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B16,1,0,true,false )
           ,new CursorDef("T000B17", "SELECT [BR_Demographics_ID] FROM [BR_Demographics] WITH (NOLOCK) ORDER BY [BR_Demographics_ID]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000B17,100,0,true,false )
           ,new CursorDef("T000B18", "SELECT [XT_DefineCodeID], [XT_DefineCodeName], [XT_DefindcodeTypeID], [XT_TenantCode] FROM [XT_DefineCode] WITH (NOLOCK) WHERE ([XT_DefindcodeTypeID] = 7) AND ([XT_TenantCode] = @AV15tCurrentCode) ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B18,0,0,true,false )
           ,new CursorDef("T000B19", "SELECT [XT_DefineCodeID], [XT_DefineCodeName], [XT_DefindcodeTypeID], [XT_TenantCode] FROM [XT_DefineCode] WITH (NOLOCK) WHERE ([XT_DefindcodeTypeID] = 8) AND ([XT_TenantCode] = @AV15tCurrentCode) ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B19,0,0,true,false )
           ,new CursorDef("T000B20", "SELECT [XT_DefineCodeID], [XT_DefineCodeName], [XT_DefindcodeTypeID], [XT_TenantCode] FROM [XT_DefineCode] WITH (NOLOCK) WHERE ([XT_DefindcodeTypeID] = 9) AND ([XT_TenantCode] = @AV15tCurrentCode) ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B20,0,0,true,false )
           ,new CursorDef("T000B21", "SELECT [XT_DefineCodeID], [XT_DefineCodeName], [XT_DefindcodeTypeID], [XT_TenantCode] FROM [XT_DefineCode] WITH (NOLOCK) WHERE ([XT_DefindcodeTypeID] = 10) AND ([XT_TenantCode] = @AV15tCurrentCode) ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B21,0,0,true,false )
           ,new CursorDef("T000B22", "SELECT [XT_DefineCodeID], [XT_DefineCodeName], [XT_DefindcodeTypeID], [XT_TenantCode] FROM [XT_DefineCode] WITH (NOLOCK) WHERE ([XT_DefindcodeTypeID] = 11) AND ([XT_TenantCode] = @AV15tCurrentCode) ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B22,0,0,true,false )
           ,new CursorDef("T000B23", "SELECT [BR_Information_ID] FROM [BR_Encounter] WITH (NOLOCK) WHERE [BR_EncounterID] = @BR_EncounterID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B23,1,0,true,false )
           ,new CursorDef("T000B24", "SELECT [BR_Information_PatientNo] FROM [BR_Information] WITH (NOLOCK) WHERE [BR_Information_ID] = @BR_Information_ID ",true, GxErrorMask.GX_NOMASK, false, this,prmT000B24,1,0,true,false )
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
              ((DateTime[]) buf[11])[0] = rslt.getGXDate(7) ;
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
              ((long[]) buf[29])[0] = rslt.getLong(16) ;
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
              ((DateTime[]) buf[11])[0] = rslt.getGXDate(7) ;
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
              ((long[]) buf[29])[0] = rslt.getLong(16) ;
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
              ((DateTime[]) buf[15])[0] = rslt.getGXDate(9) ;
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
              ((long[]) buf[33])[0] = rslt.getLong(18) ;
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
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((long[]) buf[3])[0] = rslt.getLong(3) ;
              ((String[]) buf[4])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[5])[0] = rslt.wasNull(4);
              return;
           case 20 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
              ((bool[]) buf[2])[0] = rslt.wasNull(2);
              ((long[]) buf[3])[0] = rslt.getLong(3) ;
              ((String[]) buf[4])[0] = rslt.getVarchar(4) ;
              ((bool[]) buf[5])[0] = rslt.wasNull(4);
              return;
           case 21 :
              ((long[]) buf[0])[0] = rslt.getLong(1) ;
              ((bool[]) buf[1])[0] = rslt.wasNull(1);
              return;
           case 22 :
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
              stmt.SetParameter(15, (long)parms[28]);
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
              stmt.SetParameter(15, (long)parms[28]);
              stmt.SetParameter(16, (long)parms[29]);
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
              stmt.SetParameter(1, (String)parms[0]);
              return;
           case 20 :
              stmt.SetParameter(1, (String)parms[0]);
              return;
           case 21 :
              stmt.SetParameter(1, (long)parms[0]);
              return;
           case 22 :
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
