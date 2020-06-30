/*
               File: BR_EncounterWW
        Description: Data Mgmt Portal - RAAP
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:39:46.18
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
using GeneXus.Http.Server;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class br_encounterww : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public br_encounterww( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_encounterww( IGxContext context )
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
         cmbavBr_encounter_admitdateoperator = new GXCombobox();
         cmbavBr_encounter_status = new GXCombobox();
         chkavBr_encounter_israndapprove = new GXCheckbox();
         chkavBr_encounter_israndrecheck = new GXCheckbox();
         chkavBr_encounter_isupdate = new GXCheckbox();
         cmbBR_Encounter_Status = new GXCombobox();
         chkBR_Encounter_IsRandApprove = new GXCheckbox();
         chkBR_Encounter_IsRandRecheck = new GXCheckbox();
         chkBR_Encounter_IsUpdate = new GXCheckbox();
      }

      protected void INITWEB( )
      {
         initialize_properties( ) ;
         if ( nGotPars == 0 )
         {
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
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Grid") == 0 )
            {
               nRC_GXsfl_87 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               nGXsfl_87_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
               sGXsfl_87_idx = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxnrGrid_newrow( ) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Grid") == 0 )
            {
               subGrid_Rows = (int)(NumberUtil.Val( GetNextPar( ), "."));
               AV221sBR_EncounterID = GetNextPar( );
               AV17BR_Information_PatientNo = GetNextPar( );
               AV120BR_Encounter_AdmitDateOperator = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV122BR_Encounter_AdmitDate = context.localUtil.ParseDateParm( GetNextPar( ));
               AV121BR_Encounter_AdmitDate_To = context.localUtil.ParseDateParm( GetNextPar( ));
               AV141BR_Encounter_Status = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV151BR_Encounter_IsRandApprove = StringUtil.StrToBool( GetNextPar( ));
               AV152BR_Encounter_IsRandRecheck = StringUtil.StrToBool( GetNextPar( ));
               AV153BR_Encounter_IsUpdate = StringUtil.StrToBool( GetNextPar( ));
               AV13OrderedBy = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV14OrderedDsc = StringUtil.StrToBool( GetNextPar( ));
               AV48ddo_BR_EncounterIDTitleControlIdToReplace = GetNextPar( );
               AV86ddo_BR_Information_PatientNoTitleControlIdToReplace = GetNextPar( );
               AV56ddo_BR_Encounter_DepartmentTitleControlIdToReplace = GetNextPar( );
               AV60ddo_BR_Encounter_ENCTypeTitleControlIdToReplace = GetNextPar( );
               AV66ddo_BR_Encounter_AdmitDateTitleControlIdToReplace = GetNextPar( );
               AV135ddo_BR_Encounter_StatusTitleControlIdToReplace = GetNextPar( );
               AV157ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace = GetNextPar( );
               AV160ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace = GetNextPar( );
               AV163ddo_BR_Encounter_IsUpdateTitleControlIdToReplace = GetNextPar( );
               AV243Pgmname = GetNextPar( );
               AV137IsInsert = StringUtil.StrToBool( GetNextPar( ));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid_refresh( subGrid_Rows, AV221sBR_EncounterID, AV17BR_Information_PatientNo, AV120BR_Encounter_AdmitDateOperator, AV122BR_Encounter_AdmitDate, AV121BR_Encounter_AdmitDate_To, AV141BR_Encounter_Status, AV151BR_Encounter_IsRandApprove, AV152BR_Encounter_IsRandRecheck, AV153BR_Encounter_IsUpdate, AV13OrderedBy, AV14OrderedDsc, AV48ddo_BR_EncounterIDTitleControlIdToReplace, AV86ddo_BR_Information_PatientNoTitleControlIdToReplace, AV56ddo_BR_Encounter_DepartmentTitleControlIdToReplace, AV60ddo_BR_Encounter_ENCTypeTitleControlIdToReplace, AV66ddo_BR_Encounter_AdmitDateTitleControlIdToReplace, AV135ddo_BR_Encounter_StatusTitleControlIdToReplace, AV157ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace, AV160ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace, AV163ddo_BR_Encounter_IsUpdateTitleControlIdToReplace, AV243Pgmname, AV137IsInsert) ;
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
               context.GX_webresponse.AddString((String)(context.getJSONResponse( )));
               return  ;
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
         }
         if ( ! context.IsLocalStorageSupported( ) )
         {
            context.PushCurrentUrl();
         }
      }

      public override void webExecute( )
      {
         if ( initialized == 0 )
         {
            createObjects();
            initialize();
         }
         INITWEB( ) ;
         if ( ! isAjaxCallMode( ) )
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

      public override short ExecuteStartEvent( )
      {
         PA142( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START142( ) ;
         }
         return gxajaxcallmode ;
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
         if ( nGXWrapped != 1 )
         {
            MasterPageObj.master_styles();
         }
         if ( ( ( context.GetBrowserType( ) == 1 ) || ( context.GetBrowserType( ) == 5 ) ) && ( StringUtil.StrCmp(context.GetBrowserVersion( ), "7.0") == 0 ) )
         {
            context.AddJavascriptSource("json2.js", "?"+context.GetBuildNumber( 127771), false);
         }
         context.AddJavascriptSource("jquery.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("gxtimezone.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("gxgral.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("gxcfg.js", "?20202279394667", false);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.AddJavascriptSource("calendar.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("calendar-setup.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("calendar-zh.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         context.AddJavascriptSource("DVelop/DVPaginationBar/DVPaginationBarRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/WorkWithPlusUtilities/WorkWithPlusUtilitiesRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/ConfirmPanel/BootstrapConfirmPanelRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/ConfirmPanel/BootstrapConfirmPanelRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/ConfirmPanel/BootstrapConfirmPanelRender.js", "", false);
         context.WriteHtmlText( Form.Headerrawhtml) ;
         context.CloseHtmlHeader();
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         FormProcess = " data-HasEnter=\"false\" data-Skiponenter=\"false\"";
         context.WriteHtmlText( "<body ") ;
         bodyStyle = "" + "background-color:" + context.BuildHTMLColor( Form.Backcolor) + ";color:" + context.BuildHTMLColor( Form.Textcolor) + ";";
         if ( nGXWrapped == 0 )
         {
            bodyStyle = bodyStyle + "-moz-opacity:0;opacity:0;";
         }
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( Form.Background)) ) )
         {
            bodyStyle = bodyStyle + " background-image:url(" + context.convertURL( Form.Background) + ")";
         }
         context.WriteHtmlText( " "+"class=\"form-horizontal Form\""+" "+ "style='"+bodyStyle+"'") ;
         context.WriteHtmlText( FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_encounterww.aspx") +"\">") ;
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
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         GxWebStd.gx_hidden_field( context, "GXH_vSBR_ENCOUNTERID", AV221sBR_EncounterID);
         GxWebStd.gx_hidden_field( context, "GXH_vBR_INFORMATION_PATIENTNO", AV17BR_Information_PatientNo);
         GxWebStd.gx_hidden_field( context, "GXH_vBR_ENCOUNTER_ADMITDATEOPERATOR", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV120BR_Encounter_AdmitDateOperator), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vBR_ENCOUNTER_ADMITDATE", context.localUtil.Format(AV122BR_Encounter_AdmitDate, "9999/99/99"));
         GxWebStd.gx_hidden_field( context, "GXH_vBR_ENCOUNTER_ADMITDATE_TO", context.localUtil.Format(AV121BR_Encounter_AdmitDate_To, "9999/99/99"));
         GxWebStd.gx_hidden_field( context, "GXH_vBR_ENCOUNTER_STATUS", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV141BR_Encounter_Status), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vBR_ENCOUNTER_ISRANDAPPROVE", StringUtil.BoolToStr( AV151BR_Encounter_IsRandApprove));
         GxWebStd.gx_hidden_field( context, "GXH_vBR_ENCOUNTER_ISRANDRECHECK", StringUtil.BoolToStr( AV152BR_Encounter_IsRandRecheck));
         GxWebStd.gx_hidden_field( context, "GXH_vBR_ENCOUNTER_ISUPDATE", StringUtil.BoolToStr( AV153BR_Encounter_IsUpdate));
         GxWebStd.gx_hidden_field( context, "GXH_vORDEREDBY", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13OrderedBy), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vORDEREDDSC", StringUtil.BoolToStr( AV14OrderedDsc));
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_87", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_87), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDCURRENTPAGE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV97GridCurrentPage), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDRECORDCOUNT", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV99GridRecordCount), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDPAGESIZE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV98GridPageSize), 10, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vDDO_TITLESETTINGSICONS", AV95DDO_TitleSettingsIcons);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vDDO_TITLESETTINGSICONS", AV95DDO_TitleSettingsIcons);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_ENCOUNTERIDTITLEFILTERDATA", AV45BR_EncounterIDTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_ENCOUNTERIDTITLEFILTERDATA", AV45BR_EncounterIDTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_INFORMATION_PATIENTNOTITLEFILTERDATA", AV83BR_Information_PatientNoTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_INFORMATION_PATIENTNOTITLEFILTERDATA", AV83BR_Information_PatientNoTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_ENCOUNTER_DEPARTMENTTITLEFILTERDATA", AV53BR_Encounter_DepartmentTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_ENCOUNTER_DEPARTMENTTITLEFILTERDATA", AV53BR_Encounter_DepartmentTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_ENCOUNTER_ENCTYPETITLEFILTERDATA", AV57BR_Encounter_ENCTypeTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_ENCOUNTER_ENCTYPETITLEFILTERDATA", AV57BR_Encounter_ENCTypeTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_ENCOUNTER_ADMITDATETITLEFILTERDATA", AV61BR_Encounter_AdmitDateTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_ENCOUNTER_ADMITDATETITLEFILTERDATA", AV61BR_Encounter_AdmitDateTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_ENCOUNTER_STATUSTITLEFILTERDATA", AV132BR_Encounter_StatusTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_ENCOUNTER_STATUSTITLEFILTERDATA", AV132BR_Encounter_StatusTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_ENCOUNTER_ISRANDAPPROVETITLEFILTERDATA", AV155BR_Encounter_IsRandApproveTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_ENCOUNTER_ISRANDAPPROVETITLEFILTERDATA", AV155BR_Encounter_IsRandApproveTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_ENCOUNTER_ISRANDRECHECKTITLEFILTERDATA", AV158BR_Encounter_IsRandRecheckTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_ENCOUNTER_ISRANDRECHECKTITLEFILTERDATA", AV158BR_Encounter_IsRandRecheckTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_ENCOUNTER_ISUPDATETITLEFILTERDATA", AV161BR_Encounter_IsUpdateTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_ENCOUNTER_ISUPDATETITLEFILTERDATA", AV161BR_Encounter_IsUpdateTitleFilterData);
         }
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV243Pgmname));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vTALLBR_ENCOUNTERID", AV231tAllBR_EncounterID);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vTALLBR_ENCOUNTERID", AV231tAllBR_EncounterID);
         }
         GxWebStd.gx_boolean_hidden_field( context, "vISINSERT", AV137IsInsert);
         GxWebStd.gx_hidden_field( context, "gxhash_vISINSERT", GetSecureSignedToken( "", AV137IsInsert, context));
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEHEADER_Width", StringUtil.RTrim( Dvpanel_tableheader_Width));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEHEADER_Cls", StringUtil.RTrim( Dvpanel_tableheader_Cls));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEHEADER_Title", StringUtil.RTrim( Dvpanel_tableheader_Title));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEHEADER_Collapsible", StringUtil.BoolToStr( Dvpanel_tableheader_Collapsible));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEHEADER_Collapsed", StringUtil.BoolToStr( Dvpanel_tableheader_Collapsed));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEHEADER_Autowidth", StringUtil.BoolToStr( Dvpanel_tableheader_Autowidth));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEHEADER_Autoheight", StringUtil.BoolToStr( Dvpanel_tableheader_Autoheight));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEHEADER_Showcollapseicon", StringUtil.BoolToStr( Dvpanel_tableheader_Showcollapseicon));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEHEADER_Iconposition", StringUtil.RTrim( Dvpanel_tableheader_Iconposition));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEHEADER_Autoscroll", StringUtil.BoolToStr( Dvpanel_tableheader_Autoscroll));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE1_Width", StringUtil.RTrim( Dvpanel_unnamedtable1_Width));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE1_Cls", StringUtil.RTrim( Dvpanel_unnamedtable1_Cls));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE1_Title", StringUtil.RTrim( Dvpanel_unnamedtable1_Title));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE1_Collapsible", StringUtil.BoolToStr( Dvpanel_unnamedtable1_Collapsible));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE1_Collapsed", StringUtil.BoolToStr( Dvpanel_unnamedtable1_Collapsed));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE1_Autowidth", StringUtil.BoolToStr( Dvpanel_unnamedtable1_Autowidth));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE1_Autoheight", StringUtil.BoolToStr( Dvpanel_unnamedtable1_Autoheight));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE1_Showcollapseicon", StringUtil.BoolToStr( Dvpanel_unnamedtable1_Showcollapseicon));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE1_Iconposition", StringUtil.RTrim( Dvpanel_unnamedtable1_Iconposition));
         GxWebStd.gx_hidden_field( context, "DVPANEL_UNNAMEDTABLE1_Autoscroll", StringUtil.BoolToStr( Dvpanel_unnamedtable1_Autoscroll));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Class", StringUtil.RTrim( Gridpaginationbar_Class));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Previous", StringUtil.RTrim( Gridpaginationbar_Previous));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Next", StringUtil.RTrim( Gridpaginationbar_Next));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Caption", StringUtil.RTrim( Gridpaginationbar_Caption));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Showfirst", StringUtil.BoolToStr( Gridpaginationbar_Showfirst));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Showprevious", StringUtil.BoolToStr( Gridpaginationbar_Showprevious));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Shownext", StringUtil.BoolToStr( Gridpaginationbar_Shownext));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Showlast", StringUtil.BoolToStr( Gridpaginationbar_Showlast));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Pagestoshow", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Pagestoshow), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Pagingbuttonsposition", StringUtil.RTrim( Gridpaginationbar_Pagingbuttonsposition));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Pagingcaptionposition", StringUtil.RTrim( Gridpaginationbar_Pagingcaptionposition));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Emptygridclass", StringUtil.RTrim( Gridpaginationbar_Emptygridclass));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselector", StringUtil.BoolToStr( Gridpaginationbar_Rowsperpageselector));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageoptions", StringUtil.RTrim( Gridpaginationbar_Rowsperpageoptions));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Emptygridcaption", StringUtil.RTrim( Gridpaginationbar_Emptygridcaption));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpagecaption", StringUtil.RTrim( Gridpaginationbar_Rowsperpagecaption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Caption", StringUtil.RTrim( Ddo_br_encounterid_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Tooltip", StringUtil.RTrim( Ddo_br_encounterid_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Cls", StringUtil.RTrim( Ddo_br_encounterid_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_encounterid_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_encounterid_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Includesortasc", StringUtil.BoolToStr( Ddo_br_encounterid_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Includesortdsc", StringUtil.BoolToStr( Ddo_br_encounterid_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Sortedstatus", StringUtil.RTrim( Ddo_br_encounterid_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Includefilter", StringUtil.BoolToStr( Ddo_br_encounterid_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Includedatalist", StringUtil.BoolToStr( Ddo_br_encounterid_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Sortasc", StringUtil.RTrim( Ddo_br_encounterid_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Sortdsc", StringUtil.RTrim( Ddo_br_encounterid_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Searchbuttontext", StringUtil.RTrim( Ddo_br_encounterid_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Caption", StringUtil.RTrim( Ddo_br_information_patientno_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Tooltip", StringUtil.RTrim( Ddo_br_information_patientno_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Cls", StringUtil.RTrim( Ddo_br_information_patientno_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_information_patientno_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_information_patientno_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Includesortasc", StringUtil.BoolToStr( Ddo_br_information_patientno_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Includesortdsc", StringUtil.BoolToStr( Ddo_br_information_patientno_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Sortedstatus", StringUtil.RTrim( Ddo_br_information_patientno_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Includefilter", StringUtil.BoolToStr( Ddo_br_information_patientno_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Includedatalist", StringUtil.BoolToStr( Ddo_br_information_patientno_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Sortasc", StringUtil.RTrim( Ddo_br_information_patientno_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Sortdsc", StringUtil.RTrim( Ddo_br_information_patientno_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Searchbuttontext", StringUtil.RTrim( Ddo_br_information_patientno_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_DEPARTMENT_Caption", StringUtil.RTrim( Ddo_br_encounter_department_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_DEPARTMENT_Tooltip", StringUtil.RTrim( Ddo_br_encounter_department_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_DEPARTMENT_Cls", StringUtil.RTrim( Ddo_br_encounter_department_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_DEPARTMENT_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_encounter_department_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_DEPARTMENT_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_encounter_department_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_DEPARTMENT_Includesortasc", StringUtil.BoolToStr( Ddo_br_encounter_department_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_DEPARTMENT_Includesortdsc", StringUtil.BoolToStr( Ddo_br_encounter_department_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_DEPARTMENT_Sortedstatus", StringUtil.RTrim( Ddo_br_encounter_department_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_DEPARTMENT_Includefilter", StringUtil.BoolToStr( Ddo_br_encounter_department_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_DEPARTMENT_Includedatalist", StringUtil.BoolToStr( Ddo_br_encounter_department_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_DEPARTMENT_Sortasc", StringUtil.RTrim( Ddo_br_encounter_department_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_DEPARTMENT_Sortdsc", StringUtil.RTrim( Ddo_br_encounter_department_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_DEPARTMENT_Searchbuttontext", StringUtil.RTrim( Ddo_br_encounter_department_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ENCTYPE_Caption", StringUtil.RTrim( Ddo_br_encounter_enctype_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ENCTYPE_Tooltip", StringUtil.RTrim( Ddo_br_encounter_enctype_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ENCTYPE_Cls", StringUtil.RTrim( Ddo_br_encounter_enctype_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ENCTYPE_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_encounter_enctype_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ENCTYPE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_encounter_enctype_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ENCTYPE_Includesortasc", StringUtil.BoolToStr( Ddo_br_encounter_enctype_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ENCTYPE_Includesortdsc", StringUtil.BoolToStr( Ddo_br_encounter_enctype_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ENCTYPE_Sortedstatus", StringUtil.RTrim( Ddo_br_encounter_enctype_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ENCTYPE_Includefilter", StringUtil.BoolToStr( Ddo_br_encounter_enctype_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ENCTYPE_Includedatalist", StringUtil.BoolToStr( Ddo_br_encounter_enctype_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ENCTYPE_Sortasc", StringUtil.RTrim( Ddo_br_encounter_enctype_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ENCTYPE_Sortdsc", StringUtil.RTrim( Ddo_br_encounter_enctype_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ENCTYPE_Searchbuttontext", StringUtil.RTrim( Ddo_br_encounter_enctype_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ADMITDATE_Caption", StringUtil.RTrim( Ddo_br_encounter_admitdate_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ADMITDATE_Tooltip", StringUtil.RTrim( Ddo_br_encounter_admitdate_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ADMITDATE_Cls", StringUtil.RTrim( Ddo_br_encounter_admitdate_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ADMITDATE_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_encounter_admitdate_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ADMITDATE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_encounter_admitdate_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ADMITDATE_Includesortasc", StringUtil.BoolToStr( Ddo_br_encounter_admitdate_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ADMITDATE_Includesortdsc", StringUtil.BoolToStr( Ddo_br_encounter_admitdate_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ADMITDATE_Sortedstatus", StringUtil.RTrim( Ddo_br_encounter_admitdate_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ADMITDATE_Includefilter", StringUtil.BoolToStr( Ddo_br_encounter_admitdate_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ADMITDATE_Includedatalist", StringUtil.BoolToStr( Ddo_br_encounter_admitdate_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ADMITDATE_Sortasc", StringUtil.RTrim( Ddo_br_encounter_admitdate_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ADMITDATE_Sortdsc", StringUtil.RTrim( Ddo_br_encounter_admitdate_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ADMITDATE_Searchbuttontext", StringUtil.RTrim( Ddo_br_encounter_admitdate_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_STATUS_Caption", StringUtil.RTrim( Ddo_br_encounter_status_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_STATUS_Tooltip", StringUtil.RTrim( Ddo_br_encounter_status_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_STATUS_Cls", StringUtil.RTrim( Ddo_br_encounter_status_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_STATUS_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_encounter_status_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_STATUS_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_encounter_status_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_STATUS_Includesortasc", StringUtil.BoolToStr( Ddo_br_encounter_status_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_STATUS_Includesortdsc", StringUtil.BoolToStr( Ddo_br_encounter_status_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_STATUS_Sortedstatus", StringUtil.RTrim( Ddo_br_encounter_status_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_STATUS_Includefilter", StringUtil.BoolToStr( Ddo_br_encounter_status_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_STATUS_Includedatalist", StringUtil.BoolToStr( Ddo_br_encounter_status_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_STATUS_Sortasc", StringUtil.RTrim( Ddo_br_encounter_status_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_STATUS_Sortdsc", StringUtil.RTrim( Ddo_br_encounter_status_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_STATUS_Searchbuttontext", StringUtil.RTrim( Ddo_br_encounter_status_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ISRANDAPPROVE_Caption", StringUtil.RTrim( Ddo_br_encounter_israndapprove_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ISRANDAPPROVE_Tooltip", StringUtil.RTrim( Ddo_br_encounter_israndapprove_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ISRANDAPPROVE_Cls", StringUtil.RTrim( Ddo_br_encounter_israndapprove_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ISRANDAPPROVE_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_encounter_israndapprove_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ISRANDAPPROVE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_encounter_israndapprove_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ISRANDAPPROVE_Includesortasc", StringUtil.BoolToStr( Ddo_br_encounter_israndapprove_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ISRANDAPPROVE_Includesortdsc", StringUtil.BoolToStr( Ddo_br_encounter_israndapprove_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ISRANDAPPROVE_Sortedstatus", StringUtil.RTrim( Ddo_br_encounter_israndapprove_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ISRANDAPPROVE_Includefilter", StringUtil.BoolToStr( Ddo_br_encounter_israndapprove_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ISRANDAPPROVE_Includedatalist", StringUtil.BoolToStr( Ddo_br_encounter_israndapprove_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ISRANDAPPROVE_Sortasc", StringUtil.RTrim( Ddo_br_encounter_israndapprove_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ISRANDAPPROVE_Sortdsc", StringUtil.RTrim( Ddo_br_encounter_israndapprove_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ISRANDAPPROVE_Searchbuttontext", StringUtil.RTrim( Ddo_br_encounter_israndapprove_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ISRANDRECHECK_Caption", StringUtil.RTrim( Ddo_br_encounter_israndrecheck_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ISRANDRECHECK_Tooltip", StringUtil.RTrim( Ddo_br_encounter_israndrecheck_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ISRANDRECHECK_Cls", StringUtil.RTrim( Ddo_br_encounter_israndrecheck_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ISRANDRECHECK_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_encounter_israndrecheck_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ISRANDRECHECK_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_encounter_israndrecheck_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ISRANDRECHECK_Includesortasc", StringUtil.BoolToStr( Ddo_br_encounter_israndrecheck_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ISRANDRECHECK_Includesortdsc", StringUtil.BoolToStr( Ddo_br_encounter_israndrecheck_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ISRANDRECHECK_Sortedstatus", StringUtil.RTrim( Ddo_br_encounter_israndrecheck_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ISRANDRECHECK_Includefilter", StringUtil.BoolToStr( Ddo_br_encounter_israndrecheck_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ISRANDRECHECK_Includedatalist", StringUtil.BoolToStr( Ddo_br_encounter_israndrecheck_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ISRANDRECHECK_Sortasc", StringUtil.RTrim( Ddo_br_encounter_israndrecheck_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ISRANDRECHECK_Sortdsc", StringUtil.RTrim( Ddo_br_encounter_israndrecheck_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ISRANDRECHECK_Searchbuttontext", StringUtil.RTrim( Ddo_br_encounter_israndrecheck_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ISUPDATE_Caption", StringUtil.RTrim( Ddo_br_encounter_isupdate_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ISUPDATE_Tooltip", StringUtil.RTrim( Ddo_br_encounter_isupdate_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ISUPDATE_Cls", StringUtil.RTrim( Ddo_br_encounter_isupdate_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ISUPDATE_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_encounter_isupdate_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ISUPDATE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_encounter_isupdate_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ISUPDATE_Includesortasc", StringUtil.BoolToStr( Ddo_br_encounter_isupdate_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ISUPDATE_Includesortdsc", StringUtil.BoolToStr( Ddo_br_encounter_isupdate_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ISUPDATE_Sortedstatus", StringUtil.RTrim( Ddo_br_encounter_isupdate_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ISUPDATE_Includefilter", StringUtil.BoolToStr( Ddo_br_encounter_isupdate_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ISUPDATE_Includedatalist", StringUtil.BoolToStr( Ddo_br_encounter_isupdate_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ISUPDATE_Sortasc", StringUtil.RTrim( Ddo_br_encounter_isupdate_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ISUPDATE_Sortdsc", StringUtil.RTrim( Ddo_br_encounter_isupdate_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ISUPDATE_Searchbuttontext", StringUtil.RTrim( Ddo_br_encounter_isupdate_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_DELETEENCOUNTER_Title", StringUtil.RTrim( Dvelop_confirmpanel_deleteencounter_Title));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_DELETEENCOUNTER_Confirmationtext", StringUtil.RTrim( Dvelop_confirmpanel_deleteencounter_Confirmationtext));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_DELETEENCOUNTER_Yesbuttoncaption", StringUtil.RTrim( Dvelop_confirmpanel_deleteencounter_Yesbuttoncaption));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_DELETEENCOUNTER_Nobuttoncaption", StringUtil.RTrim( Dvelop_confirmpanel_deleteencounter_Nobuttoncaption));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_DELETEENCOUNTER_Cancelbuttoncaption", StringUtil.RTrim( Dvelop_confirmpanel_deleteencounter_Cancelbuttoncaption));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_DELETEENCOUNTER_Yesbuttonposition", StringUtil.RTrim( Dvelop_confirmpanel_deleteencounter_Yesbuttonposition));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_DELETEENCOUNTER_Confirmtype", StringUtil.RTrim( Dvelop_confirmpanel_deleteencounter_Confirmtype));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_BATCHAPPROVE_Title", StringUtil.RTrim( Dvelop_confirmpanel_batchapprove_Title));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_BATCHAPPROVE_Confirmationtext", StringUtil.RTrim( Dvelop_confirmpanel_batchapprove_Confirmationtext));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_BATCHAPPROVE_Yesbuttoncaption", StringUtil.RTrim( Dvelop_confirmpanel_batchapprove_Yesbuttoncaption));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_BATCHAPPROVE_Nobuttoncaption", StringUtil.RTrim( Dvelop_confirmpanel_batchapprove_Nobuttoncaption));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_BATCHAPPROVE_Cancelbuttoncaption", StringUtil.RTrim( Dvelop_confirmpanel_batchapprove_Cancelbuttoncaption));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_BATCHAPPROVE_Yesbuttonposition", StringUtil.RTrim( Dvelop_confirmpanel_batchapprove_Yesbuttonposition));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_BATCHAPPROVE_Confirmtype", StringUtil.RTrim( Dvelop_confirmpanel_batchapprove_Confirmtype));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_BATCHRECHECK_Title", StringUtil.RTrim( Dvelop_confirmpanel_batchrecheck_Title));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_BATCHRECHECK_Confirmationtext", StringUtil.RTrim( Dvelop_confirmpanel_batchrecheck_Confirmationtext));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_BATCHRECHECK_Yesbuttoncaption", StringUtil.RTrim( Dvelop_confirmpanel_batchrecheck_Yesbuttoncaption));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_BATCHRECHECK_Nobuttoncaption", StringUtil.RTrim( Dvelop_confirmpanel_batchrecheck_Nobuttoncaption));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_BATCHRECHECK_Cancelbuttoncaption", StringUtil.RTrim( Dvelop_confirmpanel_batchrecheck_Cancelbuttoncaption));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_BATCHRECHECK_Yesbuttonposition", StringUtil.RTrim( Dvelop_confirmpanel_batchrecheck_Yesbuttonposition));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_BATCHRECHECK_Confirmtype", StringUtil.RTrim( Dvelop_confirmpanel_batchrecheck_Confirmtype));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Activeeventkey", StringUtil.RTrim( Ddo_br_encounterid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Activeeventkey", StringUtil.RTrim( Ddo_br_information_patientno_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_DEPARTMENT_Activeeventkey", StringUtil.RTrim( Ddo_br_encounter_department_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ENCTYPE_Activeeventkey", StringUtil.RTrim( Ddo_br_encounter_enctype_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ADMITDATE_Activeeventkey", StringUtil.RTrim( Ddo_br_encounter_admitdate_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_STATUS_Activeeventkey", StringUtil.RTrim( Ddo_br_encounter_status_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ISRANDAPPROVE_Activeeventkey", StringUtil.RTrim( Ddo_br_encounter_israndapprove_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ISRANDRECHECK_Activeeventkey", StringUtil.RTrim( Ddo_br_encounter_israndrecheck_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ISUPDATE_Activeeventkey", StringUtil.RTrim( Ddo_br_encounter_isupdate_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_DELETEENCOUNTER_Result", StringUtil.RTrim( Dvelop_confirmpanel_deleteencounter_Result));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_BATCHAPPROVE_Result", StringUtil.RTrim( Dvelop_confirmpanel_batchapprove_Result));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_BATCHRECHECK_Result", StringUtil.RTrim( Dvelop_confirmpanel_batchrecheck_Result));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Activeeventkey", StringUtil.RTrim( Ddo_br_encounterid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Activeeventkey", StringUtil.RTrim( Ddo_br_information_patientno_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_DEPARTMENT_Activeeventkey", StringUtil.RTrim( Ddo_br_encounter_department_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ENCTYPE_Activeeventkey", StringUtil.RTrim( Ddo_br_encounter_enctype_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ADMITDATE_Activeeventkey", StringUtil.RTrim( Ddo_br_encounter_admitdate_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_STATUS_Activeeventkey", StringUtil.RTrim( Ddo_br_encounter_status_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ISRANDAPPROVE_Activeeventkey", StringUtil.RTrim( Ddo_br_encounter_israndapprove_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ISRANDRECHECK_Activeeventkey", StringUtil.RTrim( Ddo_br_encounter_israndrecheck_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ISUPDATE_Activeeventkey", StringUtil.RTrim( Ddo_br_encounter_isupdate_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_DELETEENCOUNTER_Result", StringUtil.RTrim( Dvelop_confirmpanel_deleteencounter_Result));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_BATCHAPPROVE_Result", StringUtil.RTrim( Dvelop_confirmpanel_batchapprove_Result));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_BATCHRECHECK_Result", StringUtil.RTrim( Dvelop_confirmpanel_batchrecheck_Result));
      }

      public override void RenderHtmlCloseForm( )
      {
         SendCloseFormHiddens( ) ;
         GxWebStd.gx_hidden_field( context, "GX_FocusControl", GX_FocusControl);
         SendAjaxEncryptionKey();
         SendSecurityToken((String)(sPrefix));
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

      public override void RenderHtmlContent( )
      {
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            context.WriteHtmlText( "<div") ;
            GxWebStd.ClassAttribute( context, "gx-ct-body"+" "+(String.IsNullOrEmpty(StringUtil.RTrim( Form.Class)) ? "form-horizontal Form" : Form.Class)+"-fx");
            context.WriteHtmlText( ">") ;
            WE142( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT142( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return false ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("br_encounterww.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "BR_EncounterWW" ;
      }

      public override String GetPgmdesc( )
      {
         return "Data Mgmt Portal - RAAP" ;
      }

      protected void WB140( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! wbLoad )
         {
            if ( nGXWrapped == 1 )
            {
               RenderHtmlHeaders( ) ;
               RenderHtmlOpenForm( ) ;
            }
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, "", "", "", "false");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-gx-base-lib=\"bootstrapv3\""+" "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divLayoutmaintable_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablemain_Internalname, 1, 0, "px", 0, "px", "TableMain", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WWFiltersCell", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divHtml_dvpanel_tableheader_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* User Defined Control */
            ucDvpanel_tableheader.SetProperty("Width", Dvpanel_tableheader_Width);
            ucDvpanel_tableheader.SetProperty("AutoWidth", Dvpanel_tableheader_Autowidth);
            ucDvpanel_tableheader.SetProperty("AutoHeight", Dvpanel_tableheader_Autoheight);
            ucDvpanel_tableheader.SetProperty("Cls", Dvpanel_tableheader_Cls);
            ucDvpanel_tableheader.SetProperty("Title", Dvpanel_tableheader_Title);
            ucDvpanel_tableheader.SetProperty("Collapsible", Dvpanel_tableheader_Collapsible);
            ucDvpanel_tableheader.SetProperty("Collapsed", Dvpanel_tableheader_Collapsed);
            ucDvpanel_tableheader.SetProperty("ShowCollapseIcon", Dvpanel_tableheader_Showcollapseicon);
            ucDvpanel_tableheader.SetProperty("IconPosition", Dvpanel_tableheader_Iconposition);
            ucDvpanel_tableheader.SetProperty("AutoScroll", Dvpanel_tableheader_Autoscroll);
            ucDvpanel_tableheader.Render(context, "dvelop.gxbootstrap.panel", Dvpanel_tableheader_Internalname, "DVPANEL_TABLEHEADERContainer");
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"DVPANEL_TABLEHEADERContainer"+"Body"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divLayout_tableheader_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-gx-base-lib=\"bootstrapv3\""+" "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTableheader_Internalname, 1, 0, "px", 0, "px", "", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 CellWidthAuto", "Right", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTableactions_Internalname, 1, 0, "px", 0, "px", "TableCellsWidthAuto", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavSbr_encounterid_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavSbr_encounterid_Internalname, "就诊序号", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'" + sGXsfl_87_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavSbr_encounterid_Internalname, AV221sBR_EncounterID, StringUtil.RTrim( context.localUtil.Format( AV221sBR_EncounterID, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,22);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavSbr_encounterid_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavSbr_encounterid_Enabled, 0, "text", "", 50, "chr", 1, "row", 50, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_EncounterWW.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavBr_information_patientno_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_information_patientno_Internalname, "患者编号", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 26,'',false,'" + sGXsfl_87_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBr_information_patientno_Internalname, AV17BR_Information_PatientNo, StringUtil.RTrim( context.localUtil.Format( AV17BR_Information_PatientNo, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,26);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_information_patientno_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavBr_information_patientno_Enabled, 0, "text", "", 80, "chr", 1, "row", 2000, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_EncounterWW.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablesplittedfiltertextbr_encounter_admitdate_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-3 MergeLabelCell", "left", "top", "", "", "div");
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblFiltertextbr_encounter_admitdate_Internalname, "就诊/入院时间", "", "", lblFiltertextbr_encounter_admitdate_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "Label", 0, "", 1, 1, 0, "HLP_BR_EncounterWW.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-9", "left", "top", "", "", "div");
            wb_table1_33_142( true) ;
         }
         else
         {
            wb_table1_33_142( false) ;
         }
         return  ;
      }

      protected void wb_table1_33_142e( bool wbgen )
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbavBr_encounter_status_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavBr_encounter_status_Internalname, "审批状态", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 50,'',false,'" + sGXsfl_87_idx + "',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavBr_encounter_status, cmbavBr_encounter_status_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(AV141BR_Encounter_Status), 4, 0)), 1, cmbavBr_encounter_status_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", 1, cmbavBr_encounter_status.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,50);\"", "", true, "HLP_BR_EncounterWW.htm");
            cmbavBr_encounter_status.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV141BR_Encounter_Status), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavBr_encounter_status_Internalname, "Values", (String)(cmbavBr_encounter_status.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divUnnamedtable2_Internalname, 1, 0, "px", 0, "px", "", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+chkavBr_encounter_israndapprove_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkavBr_encounter_israndapprove_Internalname, "是否初审抽查", "col-sm-3 AttributeCheckBoxLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'" + sGXsfl_87_idx + "',0)\"";
            ClassString = "AttributeCheckBox";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavBr_encounter_israndapprove_Internalname, StringUtil.BoolToStr( AV151BR_Encounter_IsRandApprove), "", "是否初审抽查", 1, chkavBr_encounter_israndapprove.Enabled, "true", "", StyleString, ClassString, "", "", TempTags+" onclick=\"gx.fn.checkboxClick(58, this, 'true', 'false');gx.evt.onchange(this, event);\" ");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+chkavBr_encounter_israndrecheck_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkavBr_encounter_israndrecheck_Internalname, "是否复审抽查", "col-sm-3 AttributeCheckBoxLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 62,'',false,'" + sGXsfl_87_idx + "',0)\"";
            ClassString = "AttributeCheckBox";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavBr_encounter_israndrecheck_Internalname, StringUtil.BoolToStr( AV152BR_Encounter_IsRandRecheck), "", "是否复审抽查", 1, chkavBr_encounter_israndrecheck.Enabled, "true", "", StyleString, ClassString, "", "", TempTags+" onclick=\"gx.fn.checkboxClick(62, this, 'true', 'false');gx.evt.onchange(this, event);\" ");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+chkavBr_encounter_isupdate_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkavBr_encounter_isupdate_Internalname, "是否修改", "col-sm-3 AttributeCheckBoxLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 66,'',false,'" + sGXsfl_87_idx + "',0)\"";
            ClassString = "AttributeCheckBox";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavBr_encounter_isupdate_Internalname, StringUtil.BoolToStr( AV153BR_Encounter_IsUpdate), "", "是否修改", 1, chkavBr_encounter_isupdate.Enabled, "true", "", StyleString, ClassString, "", "", TempTags+" onclick=\"gx.fn.checkboxClick(66, this, 'true', 'false');gx.evt.onchange(this, event);\" ");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "Right", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divHtml_dvpanel_unnamedtable1_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* User Defined Control */
            ucDvpanel_unnamedtable1.SetProperty("Width", Dvpanel_unnamedtable1_Width);
            ucDvpanel_unnamedtable1.SetProperty("AutoWidth", Dvpanel_unnamedtable1_Autowidth);
            ucDvpanel_unnamedtable1.SetProperty("AutoHeight", Dvpanel_unnamedtable1_Autoheight);
            ucDvpanel_unnamedtable1.SetProperty("Cls", Dvpanel_unnamedtable1_Cls);
            ucDvpanel_unnamedtable1.SetProperty("Title", Dvpanel_unnamedtable1_Title);
            ucDvpanel_unnamedtable1.SetProperty("Collapsible", Dvpanel_unnamedtable1_Collapsible);
            ucDvpanel_unnamedtable1.SetProperty("Collapsed", Dvpanel_unnamedtable1_Collapsed);
            ucDvpanel_unnamedtable1.SetProperty("ShowCollapseIcon", Dvpanel_unnamedtable1_Showcollapseicon);
            ucDvpanel_unnamedtable1.SetProperty("IconPosition", Dvpanel_unnamedtable1_Iconposition);
            ucDvpanel_unnamedtable1.SetProperty("AutoScroll", Dvpanel_unnamedtable1_Autoscroll);
            ucDvpanel_unnamedtable1.Render(context, "dvelop.gxbootstrap.panel", Dvpanel_unnamedtable1_Internalname, "DVPANEL_UNNAMEDTABLE1Container");
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"DVPANEL_UNNAMEDTABLE1Container"+"Body"+"\" style=\"display:none;\">") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divLayout_unnamedtable1_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-gx-base-lib=\"bootstrapv3\""+" "+"data-abstract-form"+" ", "", "div");
            wb_table2_74_142( true) ;
         }
         else
         {
            wb_table2_74_142( false) ;
         }
         return  ;
      }

      protected void wb_table2_74_142e( bool wbgen )
      {
         if ( wbgen )
         {
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 SectionGrid", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divGridtablewithpaginationbar_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /*  Grid Control  */
            GridContainer.SetWrapped(nGXWrapped);
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<div id=\""+"GridContainer"+"DivS\" data-gxgridid=\"87\">") ;
               sStyleString = "";
               GxWebStd.gx_table_start( context, subGrid_Internalname, subGrid_Internalname, "", "GridWithPaginationBar GridWithBorderColor WorkWithSelection WorkWith", 0, "", "", 1, 2, sStyleString, "", "", 0);
               /* Subfile titles */
               context.WriteHtmlText( "<tr") ;
               context.WriteHtmlTextNl( ">") ;
               if ( subGrid_Backcolorstyle == 0 )
               {
                  subGrid_Titlebackstyle = 0;
                  if ( StringUtil.Len( subGrid_Class) > 0 )
                  {
                     subGrid_Linesclass = subGrid_Class+"Title";
                  }
               }
               else
               {
                  subGrid_Titlebackstyle = 1;
                  if ( subGrid_Backcolorstyle == 1 )
                  {
                     subGrid_Titlebackcolor = subGrid_Allbackcolor;
                     if ( StringUtil.Len( subGrid_Class) > 0 )
                     {
                        subGrid_Linesclass = subGrid_Class+"UniformTitle";
                     }
                  }
                  else
                  {
                     if ( StringUtil.Len( subGrid_Class) > 0 )
                     {
                        subGrid_Linesclass = subGrid_Class+"Title";
                     }
                  }
               }
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"ActionBaseColorAttribute"+"\" "+" style=\""+((edtavDeleteencounter_Visible==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_EncounterID_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_EncounterID_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_EncounterID_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" width="+StringUtil.LTrim( StringUtil.Str( (decimal)(410), 4, 0))+"px"+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Information_PatientNo_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Information_PatientNo_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Information_PatientNo_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Encounter_Department_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Encounter_Department_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Encounter_Department_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Encounter_ENCType_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Encounter_ENCType_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Encounter_ENCType_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Encounter_AdmitDate_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Encounter_AdmitDate_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Encounter_AdmitDate_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "患者基本信息主键ID") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( cmbBR_Encounter_Status_Titleformat == 0 )
               {
                  context.SendWebValue( cmbBR_Encounter_Status.Title.Text) ;
               }
               else
               {
                  context.WriteHtmlText( cmbBR_Encounter_Status.Title.Text) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"AttributeCheckBox"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( chkBR_Encounter_IsRandApprove_Titleformat == 0 )
               {
                  context.SendWebValue( chkBR_Encounter_IsRandApprove.Title.Text) ;
               }
               else
               {
                  context.WriteHtmlText( chkBR_Encounter_IsRandApprove.Title.Text) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"AttributeCheckBox"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( chkBR_Encounter_IsRandRecheck_Titleformat == 0 )
               {
                  context.SendWebValue( chkBR_Encounter_IsRandRecheck.Title.Text) ;
               }
               else
               {
                  context.WriteHtmlText( chkBR_Encounter_IsRandRecheck.Title.Text) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"AttributeCheckBox"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( chkBR_Encounter_IsUpdate_Titleformat == 0 )
               {
                  context.SendWebValue( chkBR_Encounter_IsUpdate.Title.Text) ;
               }
               else
               {
                  context.WriteHtmlText( chkBR_Encounter_IsUpdate.Title.Text) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "BAS_Tenant Tenant Code") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlTextNl( "</tr>") ;
               GridContainer.AddObjectProperty("GridName", "Grid");
            }
            else
            {
               if ( isAjaxCallMode( ) )
               {
                  GridContainer = new GXWebGrid( context);
               }
               else
               {
                  GridContainer.Clear();
               }
               GridContainer.SetWrapped(nGXWrapped);
               GridContainer.AddObjectProperty("GridName", "Grid");
               GridContainer.AddObjectProperty("Header", subGrid_Header);
               GridContainer.AddObjectProperty("Class", "GridWithPaginationBar GridWithBorderColor WorkWithSelection WorkWith");
               GridContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
               GridContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
               GridContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Backcolorstyle), 1, 0, ".", "")));
               GridContainer.AddObjectProperty("Sortable", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Sortable), 1, 0, ".", "")));
               GridContainer.AddObjectProperty("CmpContext", "");
               GridContainer.AddObjectProperty("InMasterPage", "false");
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.convertURL( AV164deleteEncounter));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavDeleteencounter_Tooltiptext));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavDeleteencounter_Visible), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A19BR_EncounterID), 18, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_EncounterID_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_EncounterID_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A36BR_Information_PatientNo);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Information_PatientNo_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Information_PatientNo_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A84BR_Encounter_Department);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Encounter_Department_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Encounter_Department_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A90BR_Encounter_ENCType);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Encounter_ENCType_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Encounter_ENCType_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.localUtil.Format(A91BR_Encounter_AdmitDate, "9999/99/99"));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Encounter_AdmitDate_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Encounter_AdmitDate_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A85BR_Information_ID), 18, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A172BR_Encounter_Status), 4, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( cmbBR_Encounter_Status.Title.Text));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(cmbBR_Encounter_Status_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.BoolToStr( A192BR_Encounter_IsRandApprove));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( chkBR_Encounter_IsRandApprove.Title.Text));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(chkBR_Encounter_IsRandApprove_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.BoolToStr( A193BR_Encounter_IsRandRecheck));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( chkBR_Encounter_IsRandRecheck.Title.Text));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(chkBR_Encounter_IsRandRecheck_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.BoolToStr( A202BR_Encounter_IsUpdate));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( chkBR_Encounter_IsUpdate.Title.Text));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(chkBR_Encounter_IsUpdate_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A360BAS_TenantTenantCode);
               GridContainer.AddColumnProperties(GridColumn);
               GridContainer.AddObjectProperty("Selectedindex", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Selectedindex), 4, 0, ".", "")));
               GridContainer.AddObjectProperty("Allowselection", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Allowselection), 1, 0, ".", "")));
               GridContainer.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Selectioncolor), 9, 0, ".", "")));
               GridContainer.AddObjectProperty("Allowhover", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Allowhovering), 1, 0, ".", "")));
               GridContainer.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Hoveringcolor), 9, 0, ".", "")));
               GridContainer.AddObjectProperty("Allowcollapsing", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Allowcollapsing), 1, 0, ".", "")));
               GridContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Collapsed), 1, 0, ".", "")));
            }
         }
         if ( wbEnd == 87 )
         {
            wbEnd = 0;
            nRC_GXsfl_87 = (short)(nGXsfl_87_idx-1);
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "</table>") ;
               context.WriteHtmlText( "</div>") ;
            }
            else
            {
               sStyleString = "";
               context.WriteHtmlText( "<div id=\""+"GridContainer"+"Div\" "+sStyleString+">"+"</div>") ;
               context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Grid", GridContainer);
               if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "GridContainerData", GridContainer.ToJavascriptSource());
               }
               if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "GridContainerData"+"V", GridContainer.GridValuesHidden());
               }
               else
               {
                  context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"GridContainerData"+"V"+"\" value='"+GridContainer.GridValuesHidden()+"'/>") ;
               }
            }
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divHtml_gridpaginationbar_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* User Defined Control */
            ucGridpaginationbar.SetProperty("Class", Gridpaginationbar_Class);
            ucGridpaginationbar.SetProperty("ShowFirst", Gridpaginationbar_Showfirst);
            ucGridpaginationbar.SetProperty("ShowPrevious", Gridpaginationbar_Showprevious);
            ucGridpaginationbar.SetProperty("ShowNext", Gridpaginationbar_Shownext);
            ucGridpaginationbar.SetProperty("ShowLast", Gridpaginationbar_Showlast);
            ucGridpaginationbar.SetProperty("PagesToShow", Gridpaginationbar_Pagestoshow);
            ucGridpaginationbar.SetProperty("PagingButtonsPosition", Gridpaginationbar_Pagingbuttonsposition);
            ucGridpaginationbar.SetProperty("PagingCaptionPosition", Gridpaginationbar_Pagingcaptionposition);
            ucGridpaginationbar.SetProperty("EmptyGridClass", Gridpaginationbar_Emptygridclass);
            ucGridpaginationbar.SetProperty("RowsPerPageSelector", Gridpaginationbar_Rowsperpageselector);
            ucGridpaginationbar.SetProperty("RowsPerPageOptions", Gridpaginationbar_Rowsperpageoptions);
            ucGridpaginationbar.SetProperty("Previous", Gridpaginationbar_Previous);
            ucGridpaginationbar.SetProperty("Next", Gridpaginationbar_Next);
            ucGridpaginationbar.SetProperty("Caption", Gridpaginationbar_Caption);
            ucGridpaginationbar.SetProperty("EmptyGridCaption", Gridpaginationbar_Emptygridcaption);
            ucGridpaginationbar.SetProperty("RowsPerPageCaption", Gridpaginationbar_Rowsperpagecaption);
            ucGridpaginationbar.SetProperty("CurrentPage", AV97GridCurrentPage);
            ucGridpaginationbar.SetProperty("RecordCount", AV99GridRecordCount);
            ucGridpaginationbar.SetProperty("Page", AV98GridPageSize);
            ucGridpaginationbar.Render(context, "dvelop.dvpaginationbar", Gridpaginationbar_Internalname, "GRIDPAGINATIONBARContainer");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divHtml_bottomauxiliarcontrols_Internalname, 1, 0, "px", 0, "px", "Section", "left", "top", "", "", "div");
            /* User Defined Control */
            ucDdo_br_encounterid.SetProperty("Caption", Ddo_br_encounterid_Caption);
            ucDdo_br_encounterid.SetProperty("Tooltip", Ddo_br_encounterid_Tooltip);
            ucDdo_br_encounterid.SetProperty("Cls", Ddo_br_encounterid_Cls);
            ucDdo_br_encounterid.SetProperty("DropDownOptionsType", Ddo_br_encounterid_Dropdownoptionstype);
            ucDdo_br_encounterid.SetProperty("IncludeSortASC", Ddo_br_encounterid_Includesortasc);
            ucDdo_br_encounterid.SetProperty("IncludeSortDSC", Ddo_br_encounterid_Includesortdsc);
            ucDdo_br_encounterid.SetProperty("IncludeFilter", Ddo_br_encounterid_Includefilter);
            ucDdo_br_encounterid.SetProperty("IncludeDataList", Ddo_br_encounterid_Includedatalist);
            ucDdo_br_encounterid.SetProperty("SortASC", Ddo_br_encounterid_Sortasc);
            ucDdo_br_encounterid.SetProperty("SortDSC", Ddo_br_encounterid_Sortdsc);
            ucDdo_br_encounterid.SetProperty("SearchButtonText", Ddo_br_encounterid_Searchbuttontext);
            ucDdo_br_encounterid.SetProperty("DropDownOptionsTitleSettingsIcons", AV95DDO_TitleSettingsIcons);
            ucDdo_br_encounterid.SetProperty("DropDownOptionsData", AV45BR_EncounterIDTitleFilterData);
            ucDdo_br_encounterid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_encounterid_Internalname, "DDO_BR_ENCOUNTERIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 108,'',false,'" + sGXsfl_87_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_encounteridtitlecontrolidtoreplace_Internalname, AV48ddo_BR_EncounterIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,108);\"", 0, edtavDdo_br_encounteridtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_EncounterWW.htm");
            /* User Defined Control */
            ucDdo_br_information_patientno.SetProperty("Caption", Ddo_br_information_patientno_Caption);
            ucDdo_br_information_patientno.SetProperty("Tooltip", Ddo_br_information_patientno_Tooltip);
            ucDdo_br_information_patientno.SetProperty("Cls", Ddo_br_information_patientno_Cls);
            ucDdo_br_information_patientno.SetProperty("DropDownOptionsType", Ddo_br_information_patientno_Dropdownoptionstype);
            ucDdo_br_information_patientno.SetProperty("IncludeSortASC", Ddo_br_information_patientno_Includesortasc);
            ucDdo_br_information_patientno.SetProperty("IncludeSortDSC", Ddo_br_information_patientno_Includesortdsc);
            ucDdo_br_information_patientno.SetProperty("IncludeFilter", Ddo_br_information_patientno_Includefilter);
            ucDdo_br_information_patientno.SetProperty("IncludeDataList", Ddo_br_information_patientno_Includedatalist);
            ucDdo_br_information_patientno.SetProperty("SortASC", Ddo_br_information_patientno_Sortasc);
            ucDdo_br_information_patientno.SetProperty("SortDSC", Ddo_br_information_patientno_Sortdsc);
            ucDdo_br_information_patientno.SetProperty("SearchButtonText", Ddo_br_information_patientno_Searchbuttontext);
            ucDdo_br_information_patientno.SetProperty("DropDownOptionsTitleSettingsIcons", AV95DDO_TitleSettingsIcons);
            ucDdo_br_information_patientno.SetProperty("DropDownOptionsData", AV83BR_Information_PatientNoTitleFilterData);
            ucDdo_br_information_patientno.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_information_patientno_Internalname, "DDO_BR_INFORMATION_PATIENTNOContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 110,'',false,'" + sGXsfl_87_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_information_patientnotitlecontrolidtoreplace_Internalname, AV86ddo_BR_Information_PatientNoTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,110);\"", 0, edtavDdo_br_information_patientnotitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_EncounterWW.htm");
            /* User Defined Control */
            ucDdo_br_encounter_department.SetProperty("Caption", Ddo_br_encounter_department_Caption);
            ucDdo_br_encounter_department.SetProperty("Tooltip", Ddo_br_encounter_department_Tooltip);
            ucDdo_br_encounter_department.SetProperty("Cls", Ddo_br_encounter_department_Cls);
            ucDdo_br_encounter_department.SetProperty("DropDownOptionsType", Ddo_br_encounter_department_Dropdownoptionstype);
            ucDdo_br_encounter_department.SetProperty("IncludeSortASC", Ddo_br_encounter_department_Includesortasc);
            ucDdo_br_encounter_department.SetProperty("IncludeSortDSC", Ddo_br_encounter_department_Includesortdsc);
            ucDdo_br_encounter_department.SetProperty("IncludeFilter", Ddo_br_encounter_department_Includefilter);
            ucDdo_br_encounter_department.SetProperty("IncludeDataList", Ddo_br_encounter_department_Includedatalist);
            ucDdo_br_encounter_department.SetProperty("SortASC", Ddo_br_encounter_department_Sortasc);
            ucDdo_br_encounter_department.SetProperty("SortDSC", Ddo_br_encounter_department_Sortdsc);
            ucDdo_br_encounter_department.SetProperty("SearchButtonText", Ddo_br_encounter_department_Searchbuttontext);
            ucDdo_br_encounter_department.SetProperty("DropDownOptionsTitleSettingsIcons", AV95DDO_TitleSettingsIcons);
            ucDdo_br_encounter_department.SetProperty("DropDownOptionsData", AV53BR_Encounter_DepartmentTitleFilterData);
            ucDdo_br_encounter_department.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_encounter_department_Internalname, "DDO_BR_ENCOUNTER_DEPARTMENTContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 112,'',false,'" + sGXsfl_87_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_encounter_departmenttitlecontrolidtoreplace_Internalname, AV56ddo_BR_Encounter_DepartmentTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,112);\"", 0, edtavDdo_br_encounter_departmenttitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_EncounterWW.htm");
            /* User Defined Control */
            ucDdo_br_encounter_enctype.SetProperty("Caption", Ddo_br_encounter_enctype_Caption);
            ucDdo_br_encounter_enctype.SetProperty("Tooltip", Ddo_br_encounter_enctype_Tooltip);
            ucDdo_br_encounter_enctype.SetProperty("Cls", Ddo_br_encounter_enctype_Cls);
            ucDdo_br_encounter_enctype.SetProperty("DropDownOptionsType", Ddo_br_encounter_enctype_Dropdownoptionstype);
            ucDdo_br_encounter_enctype.SetProperty("IncludeSortASC", Ddo_br_encounter_enctype_Includesortasc);
            ucDdo_br_encounter_enctype.SetProperty("IncludeSortDSC", Ddo_br_encounter_enctype_Includesortdsc);
            ucDdo_br_encounter_enctype.SetProperty("IncludeFilter", Ddo_br_encounter_enctype_Includefilter);
            ucDdo_br_encounter_enctype.SetProperty("IncludeDataList", Ddo_br_encounter_enctype_Includedatalist);
            ucDdo_br_encounter_enctype.SetProperty("SortASC", Ddo_br_encounter_enctype_Sortasc);
            ucDdo_br_encounter_enctype.SetProperty("SortDSC", Ddo_br_encounter_enctype_Sortdsc);
            ucDdo_br_encounter_enctype.SetProperty("SearchButtonText", Ddo_br_encounter_enctype_Searchbuttontext);
            ucDdo_br_encounter_enctype.SetProperty("DropDownOptionsTitleSettingsIcons", AV95DDO_TitleSettingsIcons);
            ucDdo_br_encounter_enctype.SetProperty("DropDownOptionsData", AV57BR_Encounter_ENCTypeTitleFilterData);
            ucDdo_br_encounter_enctype.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_encounter_enctype_Internalname, "DDO_BR_ENCOUNTER_ENCTYPEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 114,'',false,'" + sGXsfl_87_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_encounter_enctypetitlecontrolidtoreplace_Internalname, AV60ddo_BR_Encounter_ENCTypeTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,114);\"", 0, edtavDdo_br_encounter_enctypetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_EncounterWW.htm");
            /* User Defined Control */
            ucDdo_br_encounter_admitdate.SetProperty("Caption", Ddo_br_encounter_admitdate_Caption);
            ucDdo_br_encounter_admitdate.SetProperty("Tooltip", Ddo_br_encounter_admitdate_Tooltip);
            ucDdo_br_encounter_admitdate.SetProperty("Cls", Ddo_br_encounter_admitdate_Cls);
            ucDdo_br_encounter_admitdate.SetProperty("DropDownOptionsType", Ddo_br_encounter_admitdate_Dropdownoptionstype);
            ucDdo_br_encounter_admitdate.SetProperty("IncludeSortASC", Ddo_br_encounter_admitdate_Includesortasc);
            ucDdo_br_encounter_admitdate.SetProperty("IncludeSortDSC", Ddo_br_encounter_admitdate_Includesortdsc);
            ucDdo_br_encounter_admitdate.SetProperty("IncludeFilter", Ddo_br_encounter_admitdate_Includefilter);
            ucDdo_br_encounter_admitdate.SetProperty("IncludeDataList", Ddo_br_encounter_admitdate_Includedatalist);
            ucDdo_br_encounter_admitdate.SetProperty("SortASC", Ddo_br_encounter_admitdate_Sortasc);
            ucDdo_br_encounter_admitdate.SetProperty("SortDSC", Ddo_br_encounter_admitdate_Sortdsc);
            ucDdo_br_encounter_admitdate.SetProperty("SearchButtonText", Ddo_br_encounter_admitdate_Searchbuttontext);
            ucDdo_br_encounter_admitdate.SetProperty("DropDownOptionsTitleSettingsIcons", AV95DDO_TitleSettingsIcons);
            ucDdo_br_encounter_admitdate.SetProperty("DropDownOptionsData", AV61BR_Encounter_AdmitDateTitleFilterData);
            ucDdo_br_encounter_admitdate.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_encounter_admitdate_Internalname, "DDO_BR_ENCOUNTER_ADMITDATEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 116,'',false,'" + sGXsfl_87_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_encounter_admitdatetitlecontrolidtoreplace_Internalname, AV66ddo_BR_Encounter_AdmitDateTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,116);\"", 0, edtavDdo_br_encounter_admitdatetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_EncounterWW.htm");
            /* User Defined Control */
            ucDdo_br_encounter_status.SetProperty("Caption", Ddo_br_encounter_status_Caption);
            ucDdo_br_encounter_status.SetProperty("Tooltip", Ddo_br_encounter_status_Tooltip);
            ucDdo_br_encounter_status.SetProperty("Cls", Ddo_br_encounter_status_Cls);
            ucDdo_br_encounter_status.SetProperty("DropDownOptionsType", Ddo_br_encounter_status_Dropdownoptionstype);
            ucDdo_br_encounter_status.SetProperty("IncludeSortASC", Ddo_br_encounter_status_Includesortasc);
            ucDdo_br_encounter_status.SetProperty("IncludeSortDSC", Ddo_br_encounter_status_Includesortdsc);
            ucDdo_br_encounter_status.SetProperty("IncludeFilter", Ddo_br_encounter_status_Includefilter);
            ucDdo_br_encounter_status.SetProperty("IncludeDataList", Ddo_br_encounter_status_Includedatalist);
            ucDdo_br_encounter_status.SetProperty("SortASC", Ddo_br_encounter_status_Sortasc);
            ucDdo_br_encounter_status.SetProperty("SortDSC", Ddo_br_encounter_status_Sortdsc);
            ucDdo_br_encounter_status.SetProperty("SearchButtonText", Ddo_br_encounter_status_Searchbuttontext);
            ucDdo_br_encounter_status.SetProperty("DropDownOptionsTitleSettingsIcons", AV95DDO_TitleSettingsIcons);
            ucDdo_br_encounter_status.SetProperty("DropDownOptionsData", AV132BR_Encounter_StatusTitleFilterData);
            ucDdo_br_encounter_status.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_encounter_status_Internalname, "DDO_BR_ENCOUNTER_STATUSContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 118,'',false,'" + sGXsfl_87_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_encounter_statustitlecontrolidtoreplace_Internalname, AV135ddo_BR_Encounter_StatusTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,118);\"", 0, edtavDdo_br_encounter_statustitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_EncounterWW.htm");
            /* User Defined Control */
            ucDdo_br_encounter_israndapprove.SetProperty("Caption", Ddo_br_encounter_israndapprove_Caption);
            ucDdo_br_encounter_israndapprove.SetProperty("Tooltip", Ddo_br_encounter_israndapprove_Tooltip);
            ucDdo_br_encounter_israndapprove.SetProperty("Cls", Ddo_br_encounter_israndapprove_Cls);
            ucDdo_br_encounter_israndapprove.SetProperty("DropDownOptionsType", Ddo_br_encounter_israndapprove_Dropdownoptionstype);
            ucDdo_br_encounter_israndapprove.SetProperty("IncludeSortASC", Ddo_br_encounter_israndapprove_Includesortasc);
            ucDdo_br_encounter_israndapprove.SetProperty("IncludeSortDSC", Ddo_br_encounter_israndapprove_Includesortdsc);
            ucDdo_br_encounter_israndapprove.SetProperty("IncludeFilter", Ddo_br_encounter_israndapprove_Includefilter);
            ucDdo_br_encounter_israndapprove.SetProperty("IncludeDataList", Ddo_br_encounter_israndapprove_Includedatalist);
            ucDdo_br_encounter_israndapprove.SetProperty("SortASC", Ddo_br_encounter_israndapprove_Sortasc);
            ucDdo_br_encounter_israndapprove.SetProperty("SortDSC", Ddo_br_encounter_israndapprove_Sortdsc);
            ucDdo_br_encounter_israndapprove.SetProperty("SearchButtonText", Ddo_br_encounter_israndapprove_Searchbuttontext);
            ucDdo_br_encounter_israndapprove.SetProperty("DropDownOptionsTitleSettingsIcons", AV95DDO_TitleSettingsIcons);
            ucDdo_br_encounter_israndapprove.SetProperty("DropDownOptionsData", AV155BR_Encounter_IsRandApproveTitleFilterData);
            ucDdo_br_encounter_israndapprove.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_encounter_israndapprove_Internalname, "DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 120,'',false,'" + sGXsfl_87_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_encounter_israndapprovetitlecontrolidtoreplace_Internalname, AV157ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,120);\"", 0, edtavDdo_br_encounter_israndapprovetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_EncounterWW.htm");
            /* User Defined Control */
            ucDdo_br_encounter_israndrecheck.SetProperty("Caption", Ddo_br_encounter_israndrecheck_Caption);
            ucDdo_br_encounter_israndrecheck.SetProperty("Tooltip", Ddo_br_encounter_israndrecheck_Tooltip);
            ucDdo_br_encounter_israndrecheck.SetProperty("Cls", Ddo_br_encounter_israndrecheck_Cls);
            ucDdo_br_encounter_israndrecheck.SetProperty("DropDownOptionsType", Ddo_br_encounter_israndrecheck_Dropdownoptionstype);
            ucDdo_br_encounter_israndrecheck.SetProperty("IncludeSortASC", Ddo_br_encounter_israndrecheck_Includesortasc);
            ucDdo_br_encounter_israndrecheck.SetProperty("IncludeSortDSC", Ddo_br_encounter_israndrecheck_Includesortdsc);
            ucDdo_br_encounter_israndrecheck.SetProperty("IncludeFilter", Ddo_br_encounter_israndrecheck_Includefilter);
            ucDdo_br_encounter_israndrecheck.SetProperty("IncludeDataList", Ddo_br_encounter_israndrecheck_Includedatalist);
            ucDdo_br_encounter_israndrecheck.SetProperty("SortASC", Ddo_br_encounter_israndrecheck_Sortasc);
            ucDdo_br_encounter_israndrecheck.SetProperty("SortDSC", Ddo_br_encounter_israndrecheck_Sortdsc);
            ucDdo_br_encounter_israndrecheck.SetProperty("SearchButtonText", Ddo_br_encounter_israndrecheck_Searchbuttontext);
            ucDdo_br_encounter_israndrecheck.SetProperty("DropDownOptionsTitleSettingsIcons", AV95DDO_TitleSettingsIcons);
            ucDdo_br_encounter_israndrecheck.SetProperty("DropDownOptionsData", AV158BR_Encounter_IsRandRecheckTitleFilterData);
            ucDdo_br_encounter_israndrecheck.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_encounter_israndrecheck_Internalname, "DDO_BR_ENCOUNTER_ISRANDRECHECKContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 122,'',false,'" + sGXsfl_87_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_encounter_israndrechecktitlecontrolidtoreplace_Internalname, AV160ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,122);\"", 0, edtavDdo_br_encounter_israndrechecktitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_EncounterWW.htm");
            /* User Defined Control */
            ucDdo_br_encounter_isupdate.SetProperty("Caption", Ddo_br_encounter_isupdate_Caption);
            ucDdo_br_encounter_isupdate.SetProperty("Tooltip", Ddo_br_encounter_isupdate_Tooltip);
            ucDdo_br_encounter_isupdate.SetProperty("Cls", Ddo_br_encounter_isupdate_Cls);
            ucDdo_br_encounter_isupdate.SetProperty("DropDownOptionsType", Ddo_br_encounter_isupdate_Dropdownoptionstype);
            ucDdo_br_encounter_isupdate.SetProperty("IncludeSortASC", Ddo_br_encounter_isupdate_Includesortasc);
            ucDdo_br_encounter_isupdate.SetProperty("IncludeSortDSC", Ddo_br_encounter_isupdate_Includesortdsc);
            ucDdo_br_encounter_isupdate.SetProperty("IncludeFilter", Ddo_br_encounter_isupdate_Includefilter);
            ucDdo_br_encounter_isupdate.SetProperty("IncludeDataList", Ddo_br_encounter_isupdate_Includedatalist);
            ucDdo_br_encounter_isupdate.SetProperty("SortASC", Ddo_br_encounter_isupdate_Sortasc);
            ucDdo_br_encounter_isupdate.SetProperty("SortDSC", Ddo_br_encounter_isupdate_Sortdsc);
            ucDdo_br_encounter_isupdate.SetProperty("SearchButtonText", Ddo_br_encounter_isupdate_Searchbuttontext);
            ucDdo_br_encounter_isupdate.SetProperty("DropDownOptionsTitleSettingsIcons", AV95DDO_TitleSettingsIcons);
            ucDdo_br_encounter_isupdate.SetProperty("DropDownOptionsData", AV161BR_Encounter_IsUpdateTitleFilterData);
            ucDdo_br_encounter_isupdate.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_encounter_isupdate_Internalname, "DDO_BR_ENCOUNTER_ISUPDATEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 124,'',false,'" + sGXsfl_87_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_encounter_isupdatetitlecontrolidtoreplace_Internalname, AV163ddo_BR_Encounter_IsUpdateTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,124);\"", 0, edtavDdo_br_encounter_isupdatetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_EncounterWW.htm");
            /* User Defined Control */
            ucWorkwithplusutilities1.Render(context, "dvelop.workwithplusutilities", Workwithplusutilities1_Internalname, "WORKWITHPLUSUTILITIES1Container");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 126,'',false,'" + sGXsfl_87_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBr_encounterid_selected_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV165BR_EncounterID_Selected), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV165BR_EncounterID_Selected), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,126);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_encounterid_selected_Jsonclick, 0, "Attribute", "", "", "", "", edtavBr_encounterid_selected_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_EncounterWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 127,'',false,'" + sGXsfl_87_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrderedby_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13OrderedBy), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV13OrderedBy), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,127);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrderedby_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrderedby_Visible, 1, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_EncounterWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 128,'',false,'" + sGXsfl_87_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrdereddsc_Internalname, StringUtil.BoolToStr( AV14OrderedDsc), StringUtil.BoolToStr( AV14OrderedDsc), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,128);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrdereddsc_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrdereddsc_Visible, 1, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, 0, 0, true, "", "right", false, "HLP_BR_EncounterWW.htm");
            wb_table3_129_142( true) ;
         }
         else
         {
            wb_table3_129_142( false) ;
         }
         return  ;
      }

      protected void wb_table3_129_142e( bool wbgen )
      {
         if ( wbgen )
         {
            wb_table4_134_142( true) ;
         }
         else
         {
            wb_table4_134_142( false) ;
         }
         return  ;
      }

      protected void wb_table4_134_142e( bool wbgen )
      {
         if ( wbgen )
         {
            wb_table5_139_142( true) ;
         }
         else
         {
            wb_table5_139_142( false) ;
         }
         return  ;
      }

      protected void wb_table5_139_142e( bool wbgen )
      {
         if ( wbgen )
         {
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         if ( wbEnd == 87 )
         {
            wbEnd = 0;
            if ( isFullAjaxMode( ) )
            {
               if ( GridContainer.GetWrapped() == 1 )
               {
                  context.WriteHtmlText( "</table>") ;
                  context.WriteHtmlText( "</div>") ;
               }
               else
               {
                  sStyleString = "";
                  context.WriteHtmlText( "<div id=\""+"GridContainer"+"Div\" "+sStyleString+">"+"</div>") ;
                  context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Grid", GridContainer);
                  if ( ! context.isAjaxRequest( ) && ! context.isSpaRequest( ) )
                  {
                     GxWebStd.gx_hidden_field( context, "GridContainerData", GridContainer.ToJavascriptSource());
                  }
                  if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
                  {
                     GxWebStd.gx_hidden_field( context, "GridContainerData"+"V", GridContainer.GridValuesHidden());
                  }
                  else
                  {
                     context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"GridContainerData"+"V"+"\" value='"+GridContainer.GridValuesHidden()+"'/>") ;
                  }
               }
            }
         }
         wbLoad = true;
      }

      protected void START142( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
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
         wbErr = false;
         STRUP140( ) ;
      }

      protected void WS142( )
      {
         START142( ) ;
         EVT142( ) ;
      }

      protected void EVT142( )
      {
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) && ! wbErr )
            {
               /* Read Web Panel buttons. */
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
                           if ( StringUtil.StrCmp(sEvt, "RFR") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEPAGE") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E11142 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEROWSPERPAGE") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E12142 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_ENCOUNTERID.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E13142 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_INFORMATION_PATIENTNO.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E14142 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_ENCOUNTER_DEPARTMENT.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E15142 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_ENCOUNTER_ENCTYPE.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E16142 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_ENCOUNTER_ADMITDATE.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E17142 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_ENCOUNTER_STATUS.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E18142 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_ENCOUNTER_ISRANDAPPROVE.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E19142 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_ENCOUNTER_ISRANDRECHECK.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E20142 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_ENCOUNTER_ISUPDATE.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E21142 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DVELOP_CONFIRMPANEL_DELETEENCOUNTER.CLOSE") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E22142 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DVELOP_CONFIRMPANEL_BATCHAPPROVE.CLOSE") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E23142 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DVELOP_CONFIRMPANEL_BATCHRECHECK.CLOSE") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E24142 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "VSBR_ENCOUNTERID.CONTROLVALUECHANGING") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E25142 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              dynload_actions( ) ;
                           }
                        }
                        else
                        {
                           sEvtType = StringUtil.Right( sEvt, 4);
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4));
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 7), "REFRESH") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 9), "GRID.LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 8), "'DOTEST'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 7), "'DOADD'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 20), "BR_ENCOUNTERID.CLICK") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 20), "BR_ENCOUNTERID.CLICK") == 0 ) )
                           {
                              nGXsfl_87_idx = (short)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_87_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_87_idx), 4, 0)), 4, "0");
                              SubsflControlProps_872( ) ;
                              AV164deleteEncounter = cgiGet( edtavDeleteencounter_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDeleteencounter_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV164deleteEncounter)) ? AV242Deleteencounter_GXI : context.convertURL( context.PathToRelativeUrl( AV164deleteEncounter))), !bGXsfl_87_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDeleteencounter_Internalname, "SrcSet", context.GetImageSrcSet( AV164deleteEncounter), true);
                              A19BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( edtBR_EncounterID_Internalname), ".", ","));
                              A36BR_Information_PatientNo = cgiGet( edtBR_Information_PatientNo_Internalname);
                              n36BR_Information_PatientNo = false;
                              A84BR_Encounter_Department = cgiGet( edtBR_Encounter_Department_Internalname);
                              n84BR_Encounter_Department = false;
                              A90BR_Encounter_ENCType = cgiGet( edtBR_Encounter_ENCType_Internalname);
                              n90BR_Encounter_ENCType = false;
                              A91BR_Encounter_AdmitDate = DateTimeUtil.ResetTime(context.localUtil.CToT( cgiGet( edtBR_Encounter_AdmitDate_Internalname), 0));
                              n91BR_Encounter_AdmitDate = false;
                              A85BR_Information_ID = (long)(context.localUtil.CToN( cgiGet( edtBR_Information_ID_Internalname), ".", ","));
                              n85BR_Information_ID = false;
                              cmbBR_Encounter_Status.Name = cmbBR_Encounter_Status_Internalname;
                              cmbBR_Encounter_Status.CurrentValue = cgiGet( cmbBR_Encounter_Status_Internalname);
                              A172BR_Encounter_Status = (short)(NumberUtil.Val( cgiGet( cmbBR_Encounter_Status_Internalname), "."));
                              n172BR_Encounter_Status = false;
                              A192BR_Encounter_IsRandApprove = StringUtil.StrToBool( cgiGet( chkBR_Encounter_IsRandApprove_Internalname));
                              n192BR_Encounter_IsRandApprove = false;
                              A193BR_Encounter_IsRandRecheck = StringUtil.StrToBool( cgiGet( chkBR_Encounter_IsRandRecheck_Internalname));
                              n193BR_Encounter_IsRandRecheck = false;
                              A202BR_Encounter_IsUpdate = StringUtil.StrToBool( cgiGet( chkBR_Encounter_IsUpdate_Internalname));
                              n202BR_Encounter_IsUpdate = false;
                              A360BAS_TenantTenantCode = cgiGet( edtBAS_TenantTenantCode_Internalname);
                              n360BAS_TenantTenantCode = false;
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E26142 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Refresh */
                                    E27142 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "GRID.LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    E28142 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'DOTEST'") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: 'Dotest' */
                                    E29142 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'DOADD'") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: 'Doadd' */
                                    E30142 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "BR_ENCOUNTERID.CLICK") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    E31142 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false;
                                       /* Set Refresh If Sbr_encounterid Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vSBR_ENCOUNTERID"), AV221sBR_EncounterID) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Br_information_patientno Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vBR_INFORMATION_PATIENTNO"), AV17BR_Information_PatientNo) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Br_encounter_admitdateoperator Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vBR_ENCOUNTER_ADMITDATEOPERATOR"), ".", ",") != Convert.ToDecimal( AV120BR_Encounter_AdmitDateOperator )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Br_encounter_admitdate Changed */
                                       if ( context.localUtil.CToT( cgiGet( "GXH_vBR_ENCOUNTER_ADMITDATE"), 0) != AV122BR_Encounter_AdmitDate )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Br_encounter_admitdate_to Changed */
                                       if ( context.localUtil.CToT( cgiGet( "GXH_vBR_ENCOUNTER_ADMITDATE_TO"), 0) != AV121BR_Encounter_AdmitDate_To )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Br_encounter_status Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vBR_ENCOUNTER_STATUS"), ".", ",") != Convert.ToDecimal( AV141BR_Encounter_Status )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Br_encounter_israndapprove Changed */
                                       if ( StringUtil.StrToBool( cgiGet( "GXH_vBR_ENCOUNTER_ISRANDAPPROVE")) != AV151BR_Encounter_IsRandApprove )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Br_encounter_israndrecheck Changed */
                                       if ( StringUtil.StrToBool( cgiGet( "GXH_vBR_ENCOUNTER_ISRANDRECHECK")) != AV152BR_Encounter_IsRandRecheck )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Br_encounter_isupdate Changed */
                                       if ( StringUtil.StrToBool( cgiGet( "GXH_vBR_ENCOUNTER_ISUPDATE")) != AV153BR_Encounter_IsUpdate )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Orderedby Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vORDEREDBY"), ".", ",") != Convert.ToDecimal( AV13OrderedBy )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Ordereddsc Changed */
                                       if ( StringUtil.StrToBool( cgiGet( "GXH_vORDEREDDSC")) != AV14OrderedDsc )
                                       {
                                          Rfr0gs = true;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                       }
                                       dynload_actions( ) ;
                                    }
                                    /* No code required for Cancel button. It is implemented as the Reset button. */
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                 }
                              }
                              else
                              {
                              }
                           }
                        }
                     }
                     context.wbHandled = 1;
                  }
               }
            }
         }
      }

      protected void WE142( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               if ( nGXWrapped == 1 )
               {
                  RenderHtmlCloseForm( ) ;
               }
            }
         }
      }

      protected void PA142( )
      {
         if ( nDonePA == 0 )
         {
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
            if ( ! context.isAjaxRequest( ) )
            {
               GX_FocusControl = edtavSbr_encounterid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            nDonePA = 1;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void gxnrGrid_newrow( )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         SubsflControlProps_872( ) ;
         while ( nGXsfl_87_idx <= nRC_GXsfl_87 )
         {
            sendrow_872( ) ;
            nGXsfl_87_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_87_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_87_idx+1));
            sGXsfl_87_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_87_idx), 4, 0)), 4, "0");
            SubsflControlProps_872( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( GridContainer));
         /* End function gxnrGrid_newrow */
      }

      protected void gxgrGrid_refresh( int subGrid_Rows ,
                                       String AV221sBR_EncounterID ,
                                       String AV17BR_Information_PatientNo ,
                                       short AV120BR_Encounter_AdmitDateOperator ,
                                       DateTime AV122BR_Encounter_AdmitDate ,
                                       DateTime AV121BR_Encounter_AdmitDate_To ,
                                       short AV141BR_Encounter_Status ,
                                       bool AV151BR_Encounter_IsRandApprove ,
                                       bool AV152BR_Encounter_IsRandRecheck ,
                                       bool AV153BR_Encounter_IsUpdate ,
                                       short AV13OrderedBy ,
                                       bool AV14OrderedDsc ,
                                       String AV48ddo_BR_EncounterIDTitleControlIdToReplace ,
                                       String AV86ddo_BR_Information_PatientNoTitleControlIdToReplace ,
                                       String AV56ddo_BR_Encounter_DepartmentTitleControlIdToReplace ,
                                       String AV60ddo_BR_Encounter_ENCTypeTitleControlIdToReplace ,
                                       String AV66ddo_BR_Encounter_AdmitDateTitleControlIdToReplace ,
                                       String AV135ddo_BR_Encounter_StatusTitleControlIdToReplace ,
                                       String AV157ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace ,
                                       String AV160ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace ,
                                       String AV163ddo_BR_Encounter_IsUpdateTitleControlIdToReplace ,
                                       String AV243Pgmname ,
                                       bool AV137IsInsert )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GRID_nCurrentRecord = 0;
         RF142( ) ;
         /* End function gxgrGrid_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_BR_ENCOUNTERID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A19BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, "BR_ENCOUNTERID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A19BR_EncounterID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_BR_INFORMATION_ID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A85BR_Information_ID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, "BR_INFORMATION_ID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A85BR_Information_ID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_BR_ENCOUNTER_STATUS", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A172BR_Encounter_Status), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "BR_ENCOUNTER_STATUS", StringUtil.LTrim( StringUtil.NToC( (decimal)(A172BR_Encounter_Status), 4, 0, ".", "")));
      }

      protected void clear_multi_value_controls( )
      {
         if ( context.isAjaxRequest( ) )
         {
            dynload_actions( ) ;
         }
      }

      protected void fix_multi_value_controls( )
      {
         if ( cmbavBr_encounter_admitdateoperator.ItemCount > 0 )
         {
            AV120BR_Encounter_AdmitDateOperator = (short)(NumberUtil.Val( cmbavBr_encounter_admitdateoperator.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV120BR_Encounter_AdmitDateOperator), 4, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV120BR_Encounter_AdmitDateOperator", StringUtil.LTrim( StringUtil.Str( (decimal)(AV120BR_Encounter_AdmitDateOperator), 4, 0)));
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavBr_encounter_admitdateoperator.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV120BR_Encounter_AdmitDateOperator), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavBr_encounter_admitdateoperator_Internalname, "Values", cmbavBr_encounter_admitdateoperator.ToJavascriptSource(), true);
         }
         if ( cmbavBr_encounter_status.ItemCount > 0 )
         {
            AV141BR_Encounter_Status = (short)(NumberUtil.Val( cmbavBr_encounter_status.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV141BR_Encounter_Status), 4, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV141BR_Encounter_Status", StringUtil.LTrim( StringUtil.Str( (decimal)(AV141BR_Encounter_Status), 4, 0)));
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavBr_encounter_status.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV141BR_Encounter_Status), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavBr_encounter_status_Internalname, "Values", cmbavBr_encounter_status.ToJavascriptSource(), true);
         }
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF142( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV243Pgmname = "BR_EncounterWW";
         context.Gx_err = 0;
      }

      protected void RF142( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridContainer.ClearRows();
         }
         wbStart = 87;
         /* Execute user event: Refresh */
         E27142 ();
         nGXsfl_87_idx = 1;
         sGXsfl_87_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_87_idx), 4, 0)), 4, "0");
         SubsflControlProps_872( ) ;
         bGXsfl_87_Refreshing = true;
         GridContainer.AddObjectProperty("GridName", "Grid");
         GridContainer.AddObjectProperty("CmpContext", "");
         GridContainer.AddObjectProperty("InMasterPage", "false");
         GridContainer.AddObjectProperty("Class", "GridWithPaginationBar GridWithBorderColor WorkWithSelection WorkWith");
         GridContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
         GridContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
         GridContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Backcolorstyle), 1, 0, ".", "")));
         GridContainer.AddObjectProperty("Sortable", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Sortable), 1, 0, ".", "")));
         GridContainer.PageSize = subGrid_Recordsperpage( );
         gxdyncontrolsrefreshing = true;
         fix_multi_value_controls( ) ;
         gxdyncontrolsrefreshing = false;
         if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
         {
            SubsflControlProps_872( ) ;
            GXPagingFrom2 = (int)(((subGrid_Rows==0) ? 0 : GRID_nFirstRecordOnPage));
            GXPagingTo2 = ((subGrid_Rows==0) ? 10000 : subGrid_Recordsperpage( )+1);
            pr_default.dynParam(0, new Object[]{ new Object[]{
                                                 AV235BR_EncounterWWDS_1_Br_information_patientno ,
                                                 AV120BR_Encounter_AdmitDateOperator ,
                                                 AV236BR_EncounterWWDS_2_Br_encounter_admitdate ,
                                                 AV237BR_EncounterWWDS_3_Br_encounter_admitdate_to ,
                                                 AV238BR_EncounterWWDS_4_Br_encounter_status ,
                                                 AV239BR_EncounterWWDS_5_Br_encounter_israndapprove ,
                                                 AV240BR_EncounterWWDS_6_Br_encounter_israndrecheck ,
                                                 AV241BR_EncounterWWDS_7_Br_encounter_isupdate ,
                                                 AV221sBR_EncounterID ,
                                                 A36BR_Information_PatientNo ,
                                                 A91BR_Encounter_AdmitDate ,
                                                 A172BR_Encounter_Status ,
                                                 A192BR_Encounter_IsRandApprove ,
                                                 A193BR_Encounter_IsRandRecheck ,
                                                 A202BR_Encounter_IsUpdate ,
                                                 A19BR_EncounterID ,
                                                 AV13OrderedBy ,
                                                 AV14OrderedDsc ,
                                                 A360BAS_TenantTenantCode ,
                                                 AV223tCurrentCode } ,
                                                 new int[]{
                                                 TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.BOOLEAN, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.STRING,
                                                 TypeConstants.BOOLEAN, TypeConstants.DATE, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.BOOLEAN, TypeConstants.BOOLEAN, TypeConstants.BOOLEAN, TypeConstants.BOOLEAN, TypeConstants.BOOLEAN,
                                                 TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING
                                                 }
            } ) ;
            lV235BR_EncounterWWDS_1_Br_information_patientno = StringUtil.Concat( StringUtil.RTrim( AV235BR_EncounterWWDS_1_Br_information_patientno), "%", "");
            lV221sBR_EncounterID = StringUtil.Concat( StringUtil.RTrim( AV221sBR_EncounterID), "%", "");
            /* Using cursor H00142 */
            pr_default.execute(0, new Object[] {AV223tCurrentCode, lV235BR_EncounterWWDS_1_Br_information_patientno, AV236BR_EncounterWWDS_2_Br_encounter_admitdate, AV237BR_EncounterWWDS_3_Br_encounter_admitdate_to, AV238BR_EncounterWWDS_4_Br_encounter_status, AV239BR_EncounterWWDS_5_Br_encounter_israndapprove, AV240BR_EncounterWWDS_6_Br_encounter_israndrecheck, AV241BR_EncounterWWDS_7_Br_encounter_isupdate, lV221sBR_EncounterID, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_87_idx = 1;
            sGXsfl_87_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_87_idx), 4, 0)), 4, "0");
            SubsflControlProps_872( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < subGrid_Recordsperpage( ) ) ) ) )
            {
               A360BAS_TenantTenantCode = H00142_A360BAS_TenantTenantCode[0];
               n360BAS_TenantTenantCode = H00142_n360BAS_TenantTenantCode[0];
               A202BR_Encounter_IsUpdate = H00142_A202BR_Encounter_IsUpdate[0];
               n202BR_Encounter_IsUpdate = H00142_n202BR_Encounter_IsUpdate[0];
               A193BR_Encounter_IsRandRecheck = H00142_A193BR_Encounter_IsRandRecheck[0];
               n193BR_Encounter_IsRandRecheck = H00142_n193BR_Encounter_IsRandRecheck[0];
               A192BR_Encounter_IsRandApprove = H00142_A192BR_Encounter_IsRandApprove[0];
               n192BR_Encounter_IsRandApprove = H00142_n192BR_Encounter_IsRandApprove[0];
               A172BR_Encounter_Status = H00142_A172BR_Encounter_Status[0];
               n172BR_Encounter_Status = H00142_n172BR_Encounter_Status[0];
               A85BR_Information_ID = H00142_A85BR_Information_ID[0];
               n85BR_Information_ID = H00142_n85BR_Information_ID[0];
               A91BR_Encounter_AdmitDate = H00142_A91BR_Encounter_AdmitDate[0];
               n91BR_Encounter_AdmitDate = H00142_n91BR_Encounter_AdmitDate[0];
               A90BR_Encounter_ENCType = H00142_A90BR_Encounter_ENCType[0];
               n90BR_Encounter_ENCType = H00142_n90BR_Encounter_ENCType[0];
               A84BR_Encounter_Department = H00142_A84BR_Encounter_Department[0];
               n84BR_Encounter_Department = H00142_n84BR_Encounter_Department[0];
               A36BR_Information_PatientNo = H00142_A36BR_Information_PatientNo[0];
               n36BR_Information_PatientNo = H00142_n36BR_Information_PatientNo[0];
               A19BR_EncounterID = H00142_A19BR_EncounterID[0];
               A36BR_Information_PatientNo = H00142_A36BR_Information_PatientNo[0];
               n36BR_Information_PatientNo = H00142_n36BR_Information_PatientNo[0];
               E28142 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 87;
            WB140( ) ;
         }
         bGXsfl_87_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes142( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_BR_ENCOUNTERID"+"_"+sGXsfl_87_idx, GetSecureSignedToken( sGXsfl_87_idx, context.localUtil.Format( (decimal)(A19BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, "gxhash_BR_INFORMATION_ID"+"_"+sGXsfl_87_idx, GetSecureSignedToken( sGXsfl_87_idx, context.localUtil.Format( (decimal)(A85BR_Information_ID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_boolean_hidden_field( context, "vISINSERT", AV137IsInsert);
         GxWebStd.gx_hidden_field( context, "gxhash_vISINSERT", GetSecureSignedToken( "", AV137IsInsert, context));
         GxWebStd.gx_hidden_field( context, "gxhash_BR_ENCOUNTER_STATUS"+"_"+sGXsfl_87_idx, GetSecureSignedToken( sGXsfl_87_idx, context.localUtil.Format( (decimal)(A172BR_Encounter_Status), "ZZZ9"), context));
      }

      protected int subGrid_Pagecount( )
      {
         GRID_nRecordCount = subGrid_Recordcount( );
         if ( ((int)((GRID_nRecordCount) % (subGrid_Recordsperpage( )))) == 0 )
         {
            return (int)(NumberUtil.Int( (long)(GRID_nRecordCount/ (decimal)(subGrid_Recordsperpage( ))))) ;
         }
         return (int)(NumberUtil.Int( (long)(GRID_nRecordCount/ (decimal)(subGrid_Recordsperpage( ))))+1) ;
      }

      protected int subGrid_Recordcount( )
      {
         AV235BR_EncounterWWDS_1_Br_information_patientno = AV17BR_Information_PatientNo;
         AV236BR_EncounterWWDS_2_Br_encounter_admitdate = AV122BR_Encounter_AdmitDate;
         AV237BR_EncounterWWDS_3_Br_encounter_admitdate_to = AV121BR_Encounter_AdmitDate_To;
         AV238BR_EncounterWWDS_4_Br_encounter_status = AV141BR_Encounter_Status;
         AV239BR_EncounterWWDS_5_Br_encounter_israndapprove = AV151BR_Encounter_IsRandApprove;
         AV240BR_EncounterWWDS_6_Br_encounter_israndrecheck = AV152BR_Encounter_IsRandRecheck;
         AV241BR_EncounterWWDS_7_Br_encounter_isupdate = AV153BR_Encounter_IsUpdate;
         pr_default.dynParam(1, new Object[]{ new Object[]{
                                              AV235BR_EncounterWWDS_1_Br_information_patientno ,
                                              AV120BR_Encounter_AdmitDateOperator ,
                                              AV236BR_EncounterWWDS_2_Br_encounter_admitdate ,
                                              AV237BR_EncounterWWDS_3_Br_encounter_admitdate_to ,
                                              AV238BR_EncounterWWDS_4_Br_encounter_status ,
                                              AV239BR_EncounterWWDS_5_Br_encounter_israndapprove ,
                                              AV240BR_EncounterWWDS_6_Br_encounter_israndrecheck ,
                                              AV241BR_EncounterWWDS_7_Br_encounter_isupdate ,
                                              AV221sBR_EncounterID ,
                                              A36BR_Information_PatientNo ,
                                              A91BR_Encounter_AdmitDate ,
                                              A172BR_Encounter_Status ,
                                              A192BR_Encounter_IsRandApprove ,
                                              A193BR_Encounter_IsRandRecheck ,
                                              A202BR_Encounter_IsUpdate ,
                                              A19BR_EncounterID ,
                                              AV13OrderedBy ,
                                              AV14OrderedDsc ,
                                              A360BAS_TenantTenantCode ,
                                              AV223tCurrentCode } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.SHORT, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.BOOLEAN, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.BOOLEAN, TypeConstants.DATE, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.BOOLEAN, TypeConstants.BOOLEAN, TypeConstants.BOOLEAN, TypeConstants.BOOLEAN, TypeConstants.BOOLEAN,
                                              TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING
                                              }
         } ) ;
         lV235BR_EncounterWWDS_1_Br_information_patientno = StringUtil.Concat( StringUtil.RTrim( AV235BR_EncounterWWDS_1_Br_information_patientno), "%", "");
         lV221sBR_EncounterID = StringUtil.Concat( StringUtil.RTrim( AV221sBR_EncounterID), "%", "");
         /* Using cursor H00143 */
         pr_default.execute(1, new Object[] {AV223tCurrentCode, lV235BR_EncounterWWDS_1_Br_information_patientno, AV236BR_EncounterWWDS_2_Br_encounter_admitdate, AV237BR_EncounterWWDS_3_Br_encounter_admitdate_to, AV238BR_EncounterWWDS_4_Br_encounter_status, AV239BR_EncounterWWDS_5_Br_encounter_israndapprove, AV240BR_EncounterWWDS_6_Br_encounter_israndrecheck, AV241BR_EncounterWWDS_7_Br_encounter_isupdate, lV221sBR_EncounterID});
         GRID_nRecordCount = H00143_AGRID_nRecordCount[0];
         pr_default.close(1);
         return (int)(GRID_nRecordCount) ;
      }

      protected int subGrid_Recordsperpage( )
      {
         if ( subGrid_Rows > 0 )
         {
            return subGrid_Rows*1 ;
         }
         else
         {
            return (int)(-1) ;
         }
      }

      protected int subGrid_Currentpage( )
      {
         return (int)(NumberUtil.Int( (long)(GRID_nFirstRecordOnPage/ (decimal)(subGrid_Recordsperpage( ))))+1) ;
      }

      protected short subgrid_firstpage( )
      {
         AV235BR_EncounterWWDS_1_Br_information_patientno = AV17BR_Information_PatientNo;
         AV236BR_EncounterWWDS_2_Br_encounter_admitdate = AV122BR_Encounter_AdmitDate;
         AV237BR_EncounterWWDS_3_Br_encounter_admitdate_to = AV121BR_Encounter_AdmitDate_To;
         AV238BR_EncounterWWDS_4_Br_encounter_status = AV141BR_Encounter_Status;
         AV239BR_EncounterWWDS_5_Br_encounter_israndapprove = AV151BR_Encounter_IsRandApprove;
         AV240BR_EncounterWWDS_6_Br_encounter_israndrecheck = AV152BR_Encounter_IsRandRecheck;
         AV241BR_EncounterWWDS_7_Br_encounter_isupdate = AV153BR_Encounter_IsUpdate;
         GRID_nFirstRecordOnPage = 0;
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV221sBR_EncounterID, AV17BR_Information_PatientNo, AV120BR_Encounter_AdmitDateOperator, AV122BR_Encounter_AdmitDate, AV121BR_Encounter_AdmitDate_To, AV141BR_Encounter_Status, AV151BR_Encounter_IsRandApprove, AV152BR_Encounter_IsRandRecheck, AV153BR_Encounter_IsUpdate, AV13OrderedBy, AV14OrderedDsc, AV48ddo_BR_EncounterIDTitleControlIdToReplace, AV86ddo_BR_Information_PatientNoTitleControlIdToReplace, AV56ddo_BR_Encounter_DepartmentTitleControlIdToReplace, AV60ddo_BR_Encounter_ENCTypeTitleControlIdToReplace, AV66ddo_BR_Encounter_AdmitDateTitleControlIdToReplace, AV135ddo_BR_Encounter_StatusTitleControlIdToReplace, AV157ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace, AV160ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace, AV163ddo_BR_Encounter_IsUpdateTitleControlIdToReplace, AV243Pgmname, AV137IsInsert) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid_nextpage( )
      {
         AV235BR_EncounterWWDS_1_Br_information_patientno = AV17BR_Information_PatientNo;
         AV236BR_EncounterWWDS_2_Br_encounter_admitdate = AV122BR_Encounter_AdmitDate;
         AV237BR_EncounterWWDS_3_Br_encounter_admitdate_to = AV121BR_Encounter_AdmitDate_To;
         AV238BR_EncounterWWDS_4_Br_encounter_status = AV141BR_Encounter_Status;
         AV239BR_EncounterWWDS_5_Br_encounter_israndapprove = AV151BR_Encounter_IsRandApprove;
         AV240BR_EncounterWWDS_6_Br_encounter_israndrecheck = AV152BR_Encounter_IsRandRecheck;
         AV241BR_EncounterWWDS_7_Br_encounter_isupdate = AV153BR_Encounter_IsUpdate;
         GRID_nRecordCount = subGrid_Recordcount( );
         if ( ( GRID_nRecordCount >= subGrid_Recordsperpage( ) ) && ( GRID_nEOF == 0 ) )
         {
            GRID_nFirstRecordOnPage = (long)(GRID_nFirstRecordOnPage+subGrid_Recordsperpage( ));
         }
         else
         {
            return 2 ;
         }
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         GridContainer.AddObjectProperty("GRID_nFirstRecordOnPage", GRID_nFirstRecordOnPage);
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV221sBR_EncounterID, AV17BR_Information_PatientNo, AV120BR_Encounter_AdmitDateOperator, AV122BR_Encounter_AdmitDate, AV121BR_Encounter_AdmitDate_To, AV141BR_Encounter_Status, AV151BR_Encounter_IsRandApprove, AV152BR_Encounter_IsRandRecheck, AV153BR_Encounter_IsUpdate, AV13OrderedBy, AV14OrderedDsc, AV48ddo_BR_EncounterIDTitleControlIdToReplace, AV86ddo_BR_Information_PatientNoTitleControlIdToReplace, AV56ddo_BR_Encounter_DepartmentTitleControlIdToReplace, AV60ddo_BR_Encounter_ENCTypeTitleControlIdToReplace, AV66ddo_BR_Encounter_AdmitDateTitleControlIdToReplace, AV135ddo_BR_Encounter_StatusTitleControlIdToReplace, AV157ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace, AV160ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace, AV163ddo_BR_Encounter_IsUpdateTitleControlIdToReplace, AV243Pgmname, AV137IsInsert) ;
         }
         send_integrity_footer_hashes( ) ;
         return (short)(((GRID_nEOF==0) ? 0 : 2)) ;
      }

      protected short subgrid_previouspage( )
      {
         AV235BR_EncounterWWDS_1_Br_information_patientno = AV17BR_Information_PatientNo;
         AV236BR_EncounterWWDS_2_Br_encounter_admitdate = AV122BR_Encounter_AdmitDate;
         AV237BR_EncounterWWDS_3_Br_encounter_admitdate_to = AV121BR_Encounter_AdmitDate_To;
         AV238BR_EncounterWWDS_4_Br_encounter_status = AV141BR_Encounter_Status;
         AV239BR_EncounterWWDS_5_Br_encounter_israndapprove = AV151BR_Encounter_IsRandApprove;
         AV240BR_EncounterWWDS_6_Br_encounter_israndrecheck = AV152BR_Encounter_IsRandRecheck;
         AV241BR_EncounterWWDS_7_Br_encounter_isupdate = AV153BR_Encounter_IsUpdate;
         if ( GRID_nFirstRecordOnPage >= subGrid_Recordsperpage( ) )
         {
            GRID_nFirstRecordOnPage = (long)(GRID_nFirstRecordOnPage-subGrid_Recordsperpage( ));
         }
         else
         {
            return 2 ;
         }
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV221sBR_EncounterID, AV17BR_Information_PatientNo, AV120BR_Encounter_AdmitDateOperator, AV122BR_Encounter_AdmitDate, AV121BR_Encounter_AdmitDate_To, AV141BR_Encounter_Status, AV151BR_Encounter_IsRandApprove, AV152BR_Encounter_IsRandRecheck, AV153BR_Encounter_IsUpdate, AV13OrderedBy, AV14OrderedDsc, AV48ddo_BR_EncounterIDTitleControlIdToReplace, AV86ddo_BR_Information_PatientNoTitleControlIdToReplace, AV56ddo_BR_Encounter_DepartmentTitleControlIdToReplace, AV60ddo_BR_Encounter_ENCTypeTitleControlIdToReplace, AV66ddo_BR_Encounter_AdmitDateTitleControlIdToReplace, AV135ddo_BR_Encounter_StatusTitleControlIdToReplace, AV157ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace, AV160ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace, AV163ddo_BR_Encounter_IsUpdateTitleControlIdToReplace, AV243Pgmname, AV137IsInsert) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid_lastpage( )
      {
         AV235BR_EncounterWWDS_1_Br_information_patientno = AV17BR_Information_PatientNo;
         AV236BR_EncounterWWDS_2_Br_encounter_admitdate = AV122BR_Encounter_AdmitDate;
         AV237BR_EncounterWWDS_3_Br_encounter_admitdate_to = AV121BR_Encounter_AdmitDate_To;
         AV238BR_EncounterWWDS_4_Br_encounter_status = AV141BR_Encounter_Status;
         AV239BR_EncounterWWDS_5_Br_encounter_israndapprove = AV151BR_Encounter_IsRandApprove;
         AV240BR_EncounterWWDS_6_Br_encounter_israndrecheck = AV152BR_Encounter_IsRandRecheck;
         AV241BR_EncounterWWDS_7_Br_encounter_isupdate = AV153BR_Encounter_IsUpdate;
         GRID_nRecordCount = subGrid_Recordcount( );
         if ( GRID_nRecordCount > subGrid_Recordsperpage( ) )
         {
            if ( ((int)((GRID_nRecordCount) % (subGrid_Recordsperpage( )))) == 0 )
            {
               GRID_nFirstRecordOnPage = (long)(GRID_nRecordCount-subGrid_Recordsperpage( ));
            }
            else
            {
               GRID_nFirstRecordOnPage = (long)(GRID_nRecordCount-((int)((GRID_nRecordCount) % (subGrid_Recordsperpage( )))));
            }
         }
         else
         {
            GRID_nFirstRecordOnPage = 0;
         }
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV221sBR_EncounterID, AV17BR_Information_PatientNo, AV120BR_Encounter_AdmitDateOperator, AV122BR_Encounter_AdmitDate, AV121BR_Encounter_AdmitDate_To, AV141BR_Encounter_Status, AV151BR_Encounter_IsRandApprove, AV152BR_Encounter_IsRandRecheck, AV153BR_Encounter_IsUpdate, AV13OrderedBy, AV14OrderedDsc, AV48ddo_BR_EncounterIDTitleControlIdToReplace, AV86ddo_BR_Information_PatientNoTitleControlIdToReplace, AV56ddo_BR_Encounter_DepartmentTitleControlIdToReplace, AV60ddo_BR_Encounter_ENCTypeTitleControlIdToReplace, AV66ddo_BR_Encounter_AdmitDateTitleControlIdToReplace, AV135ddo_BR_Encounter_StatusTitleControlIdToReplace, AV157ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace, AV160ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace, AV163ddo_BR_Encounter_IsUpdateTitleControlIdToReplace, AV243Pgmname, AV137IsInsert) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected int subgrid_gotopage( int nPageNo )
      {
         AV235BR_EncounterWWDS_1_Br_information_patientno = AV17BR_Information_PatientNo;
         AV236BR_EncounterWWDS_2_Br_encounter_admitdate = AV122BR_Encounter_AdmitDate;
         AV237BR_EncounterWWDS_3_Br_encounter_admitdate_to = AV121BR_Encounter_AdmitDate_To;
         AV238BR_EncounterWWDS_4_Br_encounter_status = AV141BR_Encounter_Status;
         AV239BR_EncounterWWDS_5_Br_encounter_israndapprove = AV151BR_Encounter_IsRandApprove;
         AV240BR_EncounterWWDS_6_Br_encounter_israndrecheck = AV152BR_Encounter_IsRandRecheck;
         AV241BR_EncounterWWDS_7_Br_encounter_isupdate = AV153BR_Encounter_IsUpdate;
         if ( nPageNo > 0 )
         {
            GRID_nFirstRecordOnPage = (long)(subGrid_Recordsperpage( )*(nPageNo-1));
         }
         else
         {
            GRID_nFirstRecordOnPage = 0;
         }
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV221sBR_EncounterID, AV17BR_Information_PatientNo, AV120BR_Encounter_AdmitDateOperator, AV122BR_Encounter_AdmitDate, AV121BR_Encounter_AdmitDate_To, AV141BR_Encounter_Status, AV151BR_Encounter_IsRandApprove, AV152BR_Encounter_IsRandRecheck, AV153BR_Encounter_IsUpdate, AV13OrderedBy, AV14OrderedDsc, AV48ddo_BR_EncounterIDTitleControlIdToReplace, AV86ddo_BR_Information_PatientNoTitleControlIdToReplace, AV56ddo_BR_Encounter_DepartmentTitleControlIdToReplace, AV60ddo_BR_Encounter_ENCTypeTitleControlIdToReplace, AV66ddo_BR_Encounter_AdmitDateTitleControlIdToReplace, AV135ddo_BR_Encounter_StatusTitleControlIdToReplace, AV157ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace, AV160ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace, AV163ddo_BR_Encounter_IsUpdateTitleControlIdToReplace, AV243Pgmname, AV137IsInsert) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP140( )
      {
         /* Before Start, stand alone formulas. */
         AV243Pgmname = "BR_EncounterWW";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E26142 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( "vDDO_TITLESETTINGSICONS"), AV95DDO_TitleSettingsIcons);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_ENCOUNTERIDTITLEFILTERDATA"), AV45BR_EncounterIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_INFORMATION_PATIENTNOTITLEFILTERDATA"), AV83BR_Information_PatientNoTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_ENCOUNTER_DEPARTMENTTITLEFILTERDATA"), AV53BR_Encounter_DepartmentTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_ENCOUNTER_ENCTYPETITLEFILTERDATA"), AV57BR_Encounter_ENCTypeTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_ENCOUNTER_ADMITDATETITLEFILTERDATA"), AV61BR_Encounter_AdmitDateTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_ENCOUNTER_STATUSTITLEFILTERDATA"), AV132BR_Encounter_StatusTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_ENCOUNTER_ISRANDAPPROVETITLEFILTERDATA"), AV155BR_Encounter_IsRandApproveTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_ENCOUNTER_ISRANDRECHECKTITLEFILTERDATA"), AV158BR_Encounter_IsRandRecheckTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_ENCOUNTER_ISUPDATETITLEFILTERDATA"), AV161BR_Encounter_IsUpdateTitleFilterData);
            /* Read variables values. */
            AV221sBR_EncounterID = cgiGet( edtavSbr_encounterid_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV221sBR_EncounterID", AV221sBR_EncounterID);
            AV17BR_Information_PatientNo = cgiGet( edtavBr_information_patientno_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17BR_Information_PatientNo", AV17BR_Information_PatientNo);
            cmbavBr_encounter_admitdateoperator.Name = cmbavBr_encounter_admitdateoperator_Internalname;
            cmbavBr_encounter_admitdateoperator.CurrentValue = cgiGet( cmbavBr_encounter_admitdateoperator_Internalname);
            AV120BR_Encounter_AdmitDateOperator = (short)(NumberUtil.Val( cgiGet( cmbavBr_encounter_admitdateoperator_Internalname), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV120BR_Encounter_AdmitDateOperator", StringUtil.LTrim( StringUtil.Str( (decimal)(AV120BR_Encounter_AdmitDateOperator), 4, 0)));
            if ( context.localUtil.VCDate( cgiGet( edtavBr_encounter_admitdate_Internalname), 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"BR_Encounter_Admit Date"}), 1, "vBR_ENCOUNTER_ADMITDATE");
               GX_FocusControl = edtavBr_encounter_admitdate_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV122BR_Encounter_AdmitDate = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV122BR_Encounter_AdmitDate", context.localUtil.Format(AV122BR_Encounter_AdmitDate, "9999/99/99"));
            }
            else
            {
               AV122BR_Encounter_AdmitDate = context.localUtil.CToD( cgiGet( edtavBr_encounter_admitdate_Internalname), 0);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV122BR_Encounter_AdmitDate", context.localUtil.Format(AV122BR_Encounter_AdmitDate, "9999/99/99"));
            }
            if ( context.localUtil.VCDate( cgiGet( edtavBr_encounter_admitdate_to_Internalname), 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"BR_Encounter_Admit Date_To"}), 1, "vBR_ENCOUNTER_ADMITDATE_TO");
               GX_FocusControl = edtavBr_encounter_admitdate_to_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV121BR_Encounter_AdmitDate_To = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV121BR_Encounter_AdmitDate_To", context.localUtil.Format(AV121BR_Encounter_AdmitDate_To, "9999/99/99"));
            }
            else
            {
               AV121BR_Encounter_AdmitDate_To = context.localUtil.CToD( cgiGet( edtavBr_encounter_admitdate_to_Internalname), 0);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV121BR_Encounter_AdmitDate_To", context.localUtil.Format(AV121BR_Encounter_AdmitDate_To, "9999/99/99"));
            }
            cmbavBr_encounter_status.Name = cmbavBr_encounter_status_Internalname;
            cmbavBr_encounter_status.CurrentValue = cgiGet( cmbavBr_encounter_status_Internalname);
            AV141BR_Encounter_Status = (short)(NumberUtil.Val( cgiGet( cmbavBr_encounter_status_Internalname), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV141BR_Encounter_Status", StringUtil.LTrim( StringUtil.Str( (decimal)(AV141BR_Encounter_Status), 4, 0)));
            AV151BR_Encounter_IsRandApprove = StringUtil.StrToBool( cgiGet( chkavBr_encounter_israndapprove_Internalname));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV151BR_Encounter_IsRandApprove", AV151BR_Encounter_IsRandApprove);
            AV152BR_Encounter_IsRandRecheck = StringUtil.StrToBool( cgiGet( chkavBr_encounter_israndrecheck_Internalname));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV152BR_Encounter_IsRandRecheck", AV152BR_Encounter_IsRandRecheck);
            AV153BR_Encounter_IsUpdate = StringUtil.StrToBool( cgiGet( chkavBr_encounter_isupdate_Internalname));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV153BR_Encounter_IsUpdate", AV153BR_Encounter_IsUpdate);
            AV48ddo_BR_EncounterIDTitleControlIdToReplace = cgiGet( edtavDdo_br_encounteridtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV48ddo_BR_EncounterIDTitleControlIdToReplace", AV48ddo_BR_EncounterIDTitleControlIdToReplace);
            AV86ddo_BR_Information_PatientNoTitleControlIdToReplace = cgiGet( edtavDdo_br_information_patientnotitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV86ddo_BR_Information_PatientNoTitleControlIdToReplace", AV86ddo_BR_Information_PatientNoTitleControlIdToReplace);
            AV56ddo_BR_Encounter_DepartmentTitleControlIdToReplace = cgiGet( edtavDdo_br_encounter_departmenttitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV56ddo_BR_Encounter_DepartmentTitleControlIdToReplace", AV56ddo_BR_Encounter_DepartmentTitleControlIdToReplace);
            AV60ddo_BR_Encounter_ENCTypeTitleControlIdToReplace = cgiGet( edtavDdo_br_encounter_enctypetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV60ddo_BR_Encounter_ENCTypeTitleControlIdToReplace", AV60ddo_BR_Encounter_ENCTypeTitleControlIdToReplace);
            AV66ddo_BR_Encounter_AdmitDateTitleControlIdToReplace = cgiGet( edtavDdo_br_encounter_admitdatetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV66ddo_BR_Encounter_AdmitDateTitleControlIdToReplace", AV66ddo_BR_Encounter_AdmitDateTitleControlIdToReplace);
            AV135ddo_BR_Encounter_StatusTitleControlIdToReplace = cgiGet( edtavDdo_br_encounter_statustitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV135ddo_BR_Encounter_StatusTitleControlIdToReplace", AV135ddo_BR_Encounter_StatusTitleControlIdToReplace);
            AV157ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace = cgiGet( edtavDdo_br_encounter_israndapprovetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV157ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace", AV157ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace);
            AV160ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace = cgiGet( edtavDdo_br_encounter_israndrechecktitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV160ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace", AV160ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace);
            AV163ddo_BR_Encounter_IsUpdateTitleControlIdToReplace = cgiGet( edtavDdo_br_encounter_isupdatetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV163ddo_BR_Encounter_IsUpdateTitleControlIdToReplace", AV163ddo_BR_Encounter_IsUpdateTitleControlIdToReplace);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavBr_encounterid_selected_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavBr_encounterid_selected_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vBR_ENCOUNTERID_SELECTED");
               GX_FocusControl = edtavBr_encounterid_selected_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV165BR_EncounterID_Selected = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV165BR_EncounterID_Selected", StringUtil.LTrim( StringUtil.Str( (decimal)(AV165BR_EncounterID_Selected), 18, 0)));
            }
            else
            {
               AV165BR_EncounterID_Selected = (long)(context.localUtil.CToN( cgiGet( edtavBr_encounterid_selected_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV165BR_EncounterID_Selected", StringUtil.LTrim( StringUtil.Str( (decimal)(AV165BR_EncounterID_Selected), 18, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavOrderedby_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavOrderedby_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vORDEREDBY");
               GX_FocusControl = edtavOrderedby_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV13OrderedBy = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            }
            else
            {
               AV13OrderedBy = (short)(context.localUtil.CToN( cgiGet( edtavOrderedby_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            }
            AV14OrderedDsc = StringUtil.StrToBool( cgiGet( edtavOrdereddsc_Internalname));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            /* Read saved values. */
            nRC_GXsfl_87 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_87"), ".", ","));
            AV97GridCurrentPage = (long)(context.localUtil.CToN( cgiGet( "vGRIDCURRENTPAGE"), ".", ","));
            AV99GridRecordCount = (long)(context.localUtil.CToN( cgiGet( "vGRIDRECORDCOUNT"), ".", ","));
            AV98GridPageSize = (long)(context.localUtil.CToN( cgiGet( "vGRIDPAGESIZE"), ".", ","));
            GRID_nFirstRecordOnPage = (long)(context.localUtil.CToN( cgiGet( "GRID_nFirstRecordOnPage"), ".", ","));
            GRID_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRID_nEOF"), ".", ","));
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( "GRID_Rows"), ".", ","));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            Dvpanel_tableheader_Width = cgiGet( "DVPANEL_TABLEHEADER_Width");
            Dvpanel_tableheader_Cls = cgiGet( "DVPANEL_TABLEHEADER_Cls");
            Dvpanel_tableheader_Title = cgiGet( "DVPANEL_TABLEHEADER_Title");
            Dvpanel_tableheader_Collapsible = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEHEADER_Collapsible"));
            Dvpanel_tableheader_Collapsed = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEHEADER_Collapsed"));
            Dvpanel_tableheader_Autowidth = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEHEADER_Autowidth"));
            Dvpanel_tableheader_Autoheight = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEHEADER_Autoheight"));
            Dvpanel_tableheader_Showcollapseicon = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEHEADER_Showcollapseicon"));
            Dvpanel_tableheader_Iconposition = cgiGet( "DVPANEL_TABLEHEADER_Iconposition");
            Dvpanel_tableheader_Autoscroll = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEHEADER_Autoscroll"));
            Dvpanel_unnamedtable1_Width = cgiGet( "DVPANEL_UNNAMEDTABLE1_Width");
            Dvpanel_unnamedtable1_Cls = cgiGet( "DVPANEL_UNNAMEDTABLE1_Cls");
            Dvpanel_unnamedtable1_Title = cgiGet( "DVPANEL_UNNAMEDTABLE1_Title");
            Dvpanel_unnamedtable1_Collapsible = StringUtil.StrToBool( cgiGet( "DVPANEL_UNNAMEDTABLE1_Collapsible"));
            Dvpanel_unnamedtable1_Collapsed = StringUtil.StrToBool( cgiGet( "DVPANEL_UNNAMEDTABLE1_Collapsed"));
            Dvpanel_unnamedtable1_Autowidth = StringUtil.StrToBool( cgiGet( "DVPANEL_UNNAMEDTABLE1_Autowidth"));
            Dvpanel_unnamedtable1_Autoheight = StringUtil.StrToBool( cgiGet( "DVPANEL_UNNAMEDTABLE1_Autoheight"));
            Dvpanel_unnamedtable1_Showcollapseicon = StringUtil.StrToBool( cgiGet( "DVPANEL_UNNAMEDTABLE1_Showcollapseicon"));
            Dvpanel_unnamedtable1_Iconposition = cgiGet( "DVPANEL_UNNAMEDTABLE1_Iconposition");
            Dvpanel_unnamedtable1_Autoscroll = StringUtil.StrToBool( cgiGet( "DVPANEL_UNNAMEDTABLE1_Autoscroll"));
            Gridpaginationbar_Class = cgiGet( "GRIDPAGINATIONBAR_Class");
            Gridpaginationbar_Previous = cgiGet( "GRIDPAGINATIONBAR_Previous");
            Gridpaginationbar_Next = cgiGet( "GRIDPAGINATIONBAR_Next");
            Gridpaginationbar_Caption = cgiGet( "GRIDPAGINATIONBAR_Caption");
            Gridpaginationbar_Showfirst = StringUtil.StrToBool( cgiGet( "GRIDPAGINATIONBAR_Showfirst"));
            Gridpaginationbar_Showprevious = StringUtil.StrToBool( cgiGet( "GRIDPAGINATIONBAR_Showprevious"));
            Gridpaginationbar_Shownext = StringUtil.StrToBool( cgiGet( "GRIDPAGINATIONBAR_Shownext"));
            Gridpaginationbar_Showlast = StringUtil.StrToBool( cgiGet( "GRIDPAGINATIONBAR_Showlast"));
            Gridpaginationbar_Pagestoshow = (int)(context.localUtil.CToN( cgiGet( "GRIDPAGINATIONBAR_Pagestoshow"), ".", ","));
            Gridpaginationbar_Pagingbuttonsposition = cgiGet( "GRIDPAGINATIONBAR_Pagingbuttonsposition");
            Gridpaginationbar_Pagingcaptionposition = cgiGet( "GRIDPAGINATIONBAR_Pagingcaptionposition");
            Gridpaginationbar_Emptygridclass = cgiGet( "GRIDPAGINATIONBAR_Emptygridclass");
            Gridpaginationbar_Rowsperpageselector = StringUtil.StrToBool( cgiGet( "GRIDPAGINATIONBAR_Rowsperpageselector"));
            Gridpaginationbar_Rowsperpageselectedvalue = (int)(context.localUtil.CToN( cgiGet( "GRIDPAGINATIONBAR_Rowsperpageselectedvalue"), ".", ","));
            Gridpaginationbar_Rowsperpageoptions = cgiGet( "GRIDPAGINATIONBAR_Rowsperpageoptions");
            Gridpaginationbar_Emptygridcaption = cgiGet( "GRIDPAGINATIONBAR_Emptygridcaption");
            Gridpaginationbar_Rowsperpagecaption = cgiGet( "GRIDPAGINATIONBAR_Rowsperpagecaption");
            Ddo_br_encounterid_Caption = cgiGet( "DDO_BR_ENCOUNTERID_Caption");
            Ddo_br_encounterid_Tooltip = cgiGet( "DDO_BR_ENCOUNTERID_Tooltip");
            Ddo_br_encounterid_Cls = cgiGet( "DDO_BR_ENCOUNTERID_Cls");
            Ddo_br_encounterid_Dropdownoptionstype = cgiGet( "DDO_BR_ENCOUNTERID_Dropdownoptionstype");
            Ddo_br_encounterid_Titlecontrolidtoreplace = cgiGet( "DDO_BR_ENCOUNTERID_Titlecontrolidtoreplace");
            Ddo_br_encounterid_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTERID_Includesortasc"));
            Ddo_br_encounterid_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTERID_Includesortdsc"));
            Ddo_br_encounterid_Sortedstatus = cgiGet( "DDO_BR_ENCOUNTERID_Sortedstatus");
            Ddo_br_encounterid_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTERID_Includefilter"));
            Ddo_br_encounterid_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTERID_Includedatalist"));
            Ddo_br_encounterid_Sortasc = cgiGet( "DDO_BR_ENCOUNTERID_Sortasc");
            Ddo_br_encounterid_Sortdsc = cgiGet( "DDO_BR_ENCOUNTERID_Sortdsc");
            Ddo_br_encounterid_Searchbuttontext = cgiGet( "DDO_BR_ENCOUNTERID_Searchbuttontext");
            Ddo_br_information_patientno_Caption = cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Caption");
            Ddo_br_information_patientno_Tooltip = cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Tooltip");
            Ddo_br_information_patientno_Cls = cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Cls");
            Ddo_br_information_patientno_Dropdownoptionstype = cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Dropdownoptionstype");
            Ddo_br_information_patientno_Titlecontrolidtoreplace = cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Titlecontrolidtoreplace");
            Ddo_br_information_patientno_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Includesortasc"));
            Ddo_br_information_patientno_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Includesortdsc"));
            Ddo_br_information_patientno_Sortedstatus = cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Sortedstatus");
            Ddo_br_information_patientno_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Includefilter"));
            Ddo_br_information_patientno_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Includedatalist"));
            Ddo_br_information_patientno_Sortasc = cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Sortasc");
            Ddo_br_information_patientno_Sortdsc = cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Sortdsc");
            Ddo_br_information_patientno_Searchbuttontext = cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Searchbuttontext");
            Ddo_br_encounter_department_Caption = cgiGet( "DDO_BR_ENCOUNTER_DEPARTMENT_Caption");
            Ddo_br_encounter_department_Tooltip = cgiGet( "DDO_BR_ENCOUNTER_DEPARTMENT_Tooltip");
            Ddo_br_encounter_department_Cls = cgiGet( "DDO_BR_ENCOUNTER_DEPARTMENT_Cls");
            Ddo_br_encounter_department_Dropdownoptionstype = cgiGet( "DDO_BR_ENCOUNTER_DEPARTMENT_Dropdownoptionstype");
            Ddo_br_encounter_department_Titlecontrolidtoreplace = cgiGet( "DDO_BR_ENCOUNTER_DEPARTMENT_Titlecontrolidtoreplace");
            Ddo_br_encounter_department_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_DEPARTMENT_Includesortasc"));
            Ddo_br_encounter_department_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_DEPARTMENT_Includesortdsc"));
            Ddo_br_encounter_department_Sortedstatus = cgiGet( "DDO_BR_ENCOUNTER_DEPARTMENT_Sortedstatus");
            Ddo_br_encounter_department_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_DEPARTMENT_Includefilter"));
            Ddo_br_encounter_department_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_DEPARTMENT_Includedatalist"));
            Ddo_br_encounter_department_Sortasc = cgiGet( "DDO_BR_ENCOUNTER_DEPARTMENT_Sortasc");
            Ddo_br_encounter_department_Sortdsc = cgiGet( "DDO_BR_ENCOUNTER_DEPARTMENT_Sortdsc");
            Ddo_br_encounter_department_Searchbuttontext = cgiGet( "DDO_BR_ENCOUNTER_DEPARTMENT_Searchbuttontext");
            Ddo_br_encounter_enctype_Caption = cgiGet( "DDO_BR_ENCOUNTER_ENCTYPE_Caption");
            Ddo_br_encounter_enctype_Tooltip = cgiGet( "DDO_BR_ENCOUNTER_ENCTYPE_Tooltip");
            Ddo_br_encounter_enctype_Cls = cgiGet( "DDO_BR_ENCOUNTER_ENCTYPE_Cls");
            Ddo_br_encounter_enctype_Dropdownoptionstype = cgiGet( "DDO_BR_ENCOUNTER_ENCTYPE_Dropdownoptionstype");
            Ddo_br_encounter_enctype_Titlecontrolidtoreplace = cgiGet( "DDO_BR_ENCOUNTER_ENCTYPE_Titlecontrolidtoreplace");
            Ddo_br_encounter_enctype_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_ENCTYPE_Includesortasc"));
            Ddo_br_encounter_enctype_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_ENCTYPE_Includesortdsc"));
            Ddo_br_encounter_enctype_Sortedstatus = cgiGet( "DDO_BR_ENCOUNTER_ENCTYPE_Sortedstatus");
            Ddo_br_encounter_enctype_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_ENCTYPE_Includefilter"));
            Ddo_br_encounter_enctype_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_ENCTYPE_Includedatalist"));
            Ddo_br_encounter_enctype_Sortasc = cgiGet( "DDO_BR_ENCOUNTER_ENCTYPE_Sortasc");
            Ddo_br_encounter_enctype_Sortdsc = cgiGet( "DDO_BR_ENCOUNTER_ENCTYPE_Sortdsc");
            Ddo_br_encounter_enctype_Searchbuttontext = cgiGet( "DDO_BR_ENCOUNTER_ENCTYPE_Searchbuttontext");
            Ddo_br_encounter_admitdate_Caption = cgiGet( "DDO_BR_ENCOUNTER_ADMITDATE_Caption");
            Ddo_br_encounter_admitdate_Tooltip = cgiGet( "DDO_BR_ENCOUNTER_ADMITDATE_Tooltip");
            Ddo_br_encounter_admitdate_Cls = cgiGet( "DDO_BR_ENCOUNTER_ADMITDATE_Cls");
            Ddo_br_encounter_admitdate_Dropdownoptionstype = cgiGet( "DDO_BR_ENCOUNTER_ADMITDATE_Dropdownoptionstype");
            Ddo_br_encounter_admitdate_Titlecontrolidtoreplace = cgiGet( "DDO_BR_ENCOUNTER_ADMITDATE_Titlecontrolidtoreplace");
            Ddo_br_encounter_admitdate_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_ADMITDATE_Includesortasc"));
            Ddo_br_encounter_admitdate_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_ADMITDATE_Includesortdsc"));
            Ddo_br_encounter_admitdate_Sortedstatus = cgiGet( "DDO_BR_ENCOUNTER_ADMITDATE_Sortedstatus");
            Ddo_br_encounter_admitdate_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_ADMITDATE_Includefilter"));
            Ddo_br_encounter_admitdate_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_ADMITDATE_Includedatalist"));
            Ddo_br_encounter_admitdate_Sortasc = cgiGet( "DDO_BR_ENCOUNTER_ADMITDATE_Sortasc");
            Ddo_br_encounter_admitdate_Sortdsc = cgiGet( "DDO_BR_ENCOUNTER_ADMITDATE_Sortdsc");
            Ddo_br_encounter_admitdate_Searchbuttontext = cgiGet( "DDO_BR_ENCOUNTER_ADMITDATE_Searchbuttontext");
            Ddo_br_encounter_status_Caption = cgiGet( "DDO_BR_ENCOUNTER_STATUS_Caption");
            Ddo_br_encounter_status_Tooltip = cgiGet( "DDO_BR_ENCOUNTER_STATUS_Tooltip");
            Ddo_br_encounter_status_Cls = cgiGet( "DDO_BR_ENCOUNTER_STATUS_Cls");
            Ddo_br_encounter_status_Dropdownoptionstype = cgiGet( "DDO_BR_ENCOUNTER_STATUS_Dropdownoptionstype");
            Ddo_br_encounter_status_Titlecontrolidtoreplace = cgiGet( "DDO_BR_ENCOUNTER_STATUS_Titlecontrolidtoreplace");
            Ddo_br_encounter_status_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_STATUS_Includesortasc"));
            Ddo_br_encounter_status_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_STATUS_Includesortdsc"));
            Ddo_br_encounter_status_Sortedstatus = cgiGet( "DDO_BR_ENCOUNTER_STATUS_Sortedstatus");
            Ddo_br_encounter_status_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_STATUS_Includefilter"));
            Ddo_br_encounter_status_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_STATUS_Includedatalist"));
            Ddo_br_encounter_status_Sortasc = cgiGet( "DDO_BR_ENCOUNTER_STATUS_Sortasc");
            Ddo_br_encounter_status_Sortdsc = cgiGet( "DDO_BR_ENCOUNTER_STATUS_Sortdsc");
            Ddo_br_encounter_status_Searchbuttontext = cgiGet( "DDO_BR_ENCOUNTER_STATUS_Searchbuttontext");
            Ddo_br_encounter_israndapprove_Caption = cgiGet( "DDO_BR_ENCOUNTER_ISRANDAPPROVE_Caption");
            Ddo_br_encounter_israndapprove_Tooltip = cgiGet( "DDO_BR_ENCOUNTER_ISRANDAPPROVE_Tooltip");
            Ddo_br_encounter_israndapprove_Cls = cgiGet( "DDO_BR_ENCOUNTER_ISRANDAPPROVE_Cls");
            Ddo_br_encounter_israndapprove_Dropdownoptionstype = cgiGet( "DDO_BR_ENCOUNTER_ISRANDAPPROVE_Dropdownoptionstype");
            Ddo_br_encounter_israndapprove_Titlecontrolidtoreplace = cgiGet( "DDO_BR_ENCOUNTER_ISRANDAPPROVE_Titlecontrolidtoreplace");
            Ddo_br_encounter_israndapprove_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_ISRANDAPPROVE_Includesortasc"));
            Ddo_br_encounter_israndapprove_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_ISRANDAPPROVE_Includesortdsc"));
            Ddo_br_encounter_israndapprove_Sortedstatus = cgiGet( "DDO_BR_ENCOUNTER_ISRANDAPPROVE_Sortedstatus");
            Ddo_br_encounter_israndapprove_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_ISRANDAPPROVE_Includefilter"));
            Ddo_br_encounter_israndapprove_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_ISRANDAPPROVE_Includedatalist"));
            Ddo_br_encounter_israndapprove_Sortasc = cgiGet( "DDO_BR_ENCOUNTER_ISRANDAPPROVE_Sortasc");
            Ddo_br_encounter_israndapprove_Sortdsc = cgiGet( "DDO_BR_ENCOUNTER_ISRANDAPPROVE_Sortdsc");
            Ddo_br_encounter_israndapprove_Searchbuttontext = cgiGet( "DDO_BR_ENCOUNTER_ISRANDAPPROVE_Searchbuttontext");
            Ddo_br_encounter_israndrecheck_Caption = cgiGet( "DDO_BR_ENCOUNTER_ISRANDRECHECK_Caption");
            Ddo_br_encounter_israndrecheck_Tooltip = cgiGet( "DDO_BR_ENCOUNTER_ISRANDRECHECK_Tooltip");
            Ddo_br_encounter_israndrecheck_Cls = cgiGet( "DDO_BR_ENCOUNTER_ISRANDRECHECK_Cls");
            Ddo_br_encounter_israndrecheck_Dropdownoptionstype = cgiGet( "DDO_BR_ENCOUNTER_ISRANDRECHECK_Dropdownoptionstype");
            Ddo_br_encounter_israndrecheck_Titlecontrolidtoreplace = cgiGet( "DDO_BR_ENCOUNTER_ISRANDRECHECK_Titlecontrolidtoreplace");
            Ddo_br_encounter_israndrecheck_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_ISRANDRECHECK_Includesortasc"));
            Ddo_br_encounter_israndrecheck_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_ISRANDRECHECK_Includesortdsc"));
            Ddo_br_encounter_israndrecheck_Sortedstatus = cgiGet( "DDO_BR_ENCOUNTER_ISRANDRECHECK_Sortedstatus");
            Ddo_br_encounter_israndrecheck_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_ISRANDRECHECK_Includefilter"));
            Ddo_br_encounter_israndrecheck_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_ISRANDRECHECK_Includedatalist"));
            Ddo_br_encounter_israndrecheck_Sortasc = cgiGet( "DDO_BR_ENCOUNTER_ISRANDRECHECK_Sortasc");
            Ddo_br_encounter_israndrecheck_Sortdsc = cgiGet( "DDO_BR_ENCOUNTER_ISRANDRECHECK_Sortdsc");
            Ddo_br_encounter_israndrecheck_Searchbuttontext = cgiGet( "DDO_BR_ENCOUNTER_ISRANDRECHECK_Searchbuttontext");
            Ddo_br_encounter_isupdate_Caption = cgiGet( "DDO_BR_ENCOUNTER_ISUPDATE_Caption");
            Ddo_br_encounter_isupdate_Tooltip = cgiGet( "DDO_BR_ENCOUNTER_ISUPDATE_Tooltip");
            Ddo_br_encounter_isupdate_Cls = cgiGet( "DDO_BR_ENCOUNTER_ISUPDATE_Cls");
            Ddo_br_encounter_isupdate_Dropdownoptionstype = cgiGet( "DDO_BR_ENCOUNTER_ISUPDATE_Dropdownoptionstype");
            Ddo_br_encounter_isupdate_Titlecontrolidtoreplace = cgiGet( "DDO_BR_ENCOUNTER_ISUPDATE_Titlecontrolidtoreplace");
            Ddo_br_encounter_isupdate_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_ISUPDATE_Includesortasc"));
            Ddo_br_encounter_isupdate_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_ISUPDATE_Includesortdsc"));
            Ddo_br_encounter_isupdate_Sortedstatus = cgiGet( "DDO_BR_ENCOUNTER_ISUPDATE_Sortedstatus");
            Ddo_br_encounter_isupdate_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_ISUPDATE_Includefilter"));
            Ddo_br_encounter_isupdate_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_ISUPDATE_Includedatalist"));
            Ddo_br_encounter_isupdate_Sortasc = cgiGet( "DDO_BR_ENCOUNTER_ISUPDATE_Sortasc");
            Ddo_br_encounter_isupdate_Sortdsc = cgiGet( "DDO_BR_ENCOUNTER_ISUPDATE_Sortdsc");
            Ddo_br_encounter_isupdate_Searchbuttontext = cgiGet( "DDO_BR_ENCOUNTER_ISUPDATE_Searchbuttontext");
            Dvelop_confirmpanel_deleteencounter_Title = cgiGet( "DVELOP_CONFIRMPANEL_DELETEENCOUNTER_Title");
            Dvelop_confirmpanel_deleteencounter_Confirmationtext = cgiGet( "DVELOP_CONFIRMPANEL_DELETEENCOUNTER_Confirmationtext");
            Dvelop_confirmpanel_deleteencounter_Yesbuttoncaption = cgiGet( "DVELOP_CONFIRMPANEL_DELETEENCOUNTER_Yesbuttoncaption");
            Dvelop_confirmpanel_deleteencounter_Nobuttoncaption = cgiGet( "DVELOP_CONFIRMPANEL_DELETEENCOUNTER_Nobuttoncaption");
            Dvelop_confirmpanel_deleteencounter_Cancelbuttoncaption = cgiGet( "DVELOP_CONFIRMPANEL_DELETEENCOUNTER_Cancelbuttoncaption");
            Dvelop_confirmpanel_deleteencounter_Yesbuttonposition = cgiGet( "DVELOP_CONFIRMPANEL_DELETEENCOUNTER_Yesbuttonposition");
            Dvelop_confirmpanel_deleteencounter_Confirmtype = cgiGet( "DVELOP_CONFIRMPANEL_DELETEENCOUNTER_Confirmtype");
            Dvelop_confirmpanel_batchapprove_Title = cgiGet( "DVELOP_CONFIRMPANEL_BATCHAPPROVE_Title");
            Dvelop_confirmpanel_batchapprove_Confirmationtext = cgiGet( "DVELOP_CONFIRMPANEL_BATCHAPPROVE_Confirmationtext");
            Dvelop_confirmpanel_batchapprove_Yesbuttoncaption = cgiGet( "DVELOP_CONFIRMPANEL_BATCHAPPROVE_Yesbuttoncaption");
            Dvelop_confirmpanel_batchapprove_Nobuttoncaption = cgiGet( "DVELOP_CONFIRMPANEL_BATCHAPPROVE_Nobuttoncaption");
            Dvelop_confirmpanel_batchapprove_Cancelbuttoncaption = cgiGet( "DVELOP_CONFIRMPANEL_BATCHAPPROVE_Cancelbuttoncaption");
            Dvelop_confirmpanel_batchapprove_Yesbuttonposition = cgiGet( "DVELOP_CONFIRMPANEL_BATCHAPPROVE_Yesbuttonposition");
            Dvelop_confirmpanel_batchapprove_Confirmtype = cgiGet( "DVELOP_CONFIRMPANEL_BATCHAPPROVE_Confirmtype");
            Dvelop_confirmpanel_batchrecheck_Title = cgiGet( "DVELOP_CONFIRMPANEL_BATCHRECHECK_Title");
            Dvelop_confirmpanel_batchrecheck_Confirmationtext = cgiGet( "DVELOP_CONFIRMPANEL_BATCHRECHECK_Confirmationtext");
            Dvelop_confirmpanel_batchrecheck_Yesbuttoncaption = cgiGet( "DVELOP_CONFIRMPANEL_BATCHRECHECK_Yesbuttoncaption");
            Dvelop_confirmpanel_batchrecheck_Nobuttoncaption = cgiGet( "DVELOP_CONFIRMPANEL_BATCHRECHECK_Nobuttoncaption");
            Dvelop_confirmpanel_batchrecheck_Cancelbuttoncaption = cgiGet( "DVELOP_CONFIRMPANEL_BATCHRECHECK_Cancelbuttoncaption");
            Dvelop_confirmpanel_batchrecheck_Yesbuttonposition = cgiGet( "DVELOP_CONFIRMPANEL_BATCHRECHECK_Yesbuttonposition");
            Dvelop_confirmpanel_batchrecheck_Confirmtype = cgiGet( "DVELOP_CONFIRMPANEL_BATCHRECHECK_Confirmtype");
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( "GRID_Rows"), ".", ","));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            Gridpaginationbar_Selectedpage = cgiGet( "GRIDPAGINATIONBAR_Selectedpage");
            Gridpaginationbar_Rowsperpageselectedvalue = (int)(context.localUtil.CToN( cgiGet( "GRIDPAGINATIONBAR_Rowsperpageselectedvalue"), ".", ","));
            Ddo_br_encounterid_Activeeventkey = cgiGet( "DDO_BR_ENCOUNTERID_Activeeventkey");
            Ddo_br_information_patientno_Activeeventkey = cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Activeeventkey");
            Ddo_br_encounter_department_Activeeventkey = cgiGet( "DDO_BR_ENCOUNTER_DEPARTMENT_Activeeventkey");
            Ddo_br_encounter_enctype_Activeeventkey = cgiGet( "DDO_BR_ENCOUNTER_ENCTYPE_Activeeventkey");
            Ddo_br_encounter_admitdate_Activeeventkey = cgiGet( "DDO_BR_ENCOUNTER_ADMITDATE_Activeeventkey");
            Ddo_br_encounter_status_Activeeventkey = cgiGet( "DDO_BR_ENCOUNTER_STATUS_Activeeventkey");
            Ddo_br_encounter_israndapprove_Activeeventkey = cgiGet( "DDO_BR_ENCOUNTER_ISRANDAPPROVE_Activeeventkey");
            Ddo_br_encounter_israndrecheck_Activeeventkey = cgiGet( "DDO_BR_ENCOUNTER_ISRANDRECHECK_Activeeventkey");
            Ddo_br_encounter_isupdate_Activeeventkey = cgiGet( "DDO_BR_ENCOUNTER_ISUPDATE_Activeeventkey");
            Dvelop_confirmpanel_deleteencounter_Result = cgiGet( "DVELOP_CONFIRMPANEL_DELETEENCOUNTER_Result");
            Dvelop_confirmpanel_batchapprove_Result = cgiGet( "DVELOP_CONFIRMPANEL_BATCHAPPROVE_Result");
            Dvelop_confirmpanel_batchrecheck_Result = cgiGet( "DVELOP_CONFIRMPANEL_BATCHRECHECK_Result");
            /* Read subfile selected row values. */
            nGXsfl_87_idx = (short)(context.localUtil.CToN( cgiGet( subGrid_Internalname+"_ROW"), ".", ","));
            sGXsfl_87_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_87_idx), 4, 0)), 4, "0");
            SubsflControlProps_872( ) ;
            if ( nGXsfl_87_idx > 0 )
            {
               AV164deleteEncounter = cgiGet( edtavDeleteencounter_Internalname);
               A19BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( edtBR_EncounterID_Internalname), ".", ","));
               A36BR_Information_PatientNo = cgiGet( edtBR_Information_PatientNo_Internalname);
               n36BR_Information_PatientNo = false;
               A84BR_Encounter_Department = cgiGet( edtBR_Encounter_Department_Internalname);
               n84BR_Encounter_Department = false;
               A90BR_Encounter_ENCType = cgiGet( edtBR_Encounter_ENCType_Internalname);
               n90BR_Encounter_ENCType = false;
               A91BR_Encounter_AdmitDate = context.localUtil.CToD( cgiGet( edtBR_Encounter_AdmitDate_Internalname), 0);
               n91BR_Encounter_AdmitDate = false;
               A85BR_Information_ID = (long)(context.localUtil.CToN( cgiGet( edtBR_Information_ID_Internalname), ".", ","));
               n85BR_Information_ID = false;
               cmbBR_Encounter_Status.Name = cmbBR_Encounter_Status_Internalname;
               cmbBR_Encounter_Status.CurrentValue = cgiGet( cmbBR_Encounter_Status_Internalname);
               A172BR_Encounter_Status = (short)(NumberUtil.Val( cgiGet( cmbBR_Encounter_Status_Internalname), "."));
               n172BR_Encounter_Status = false;
               A192BR_Encounter_IsRandApprove = StringUtil.StrToBool( cgiGet( chkBR_Encounter_IsRandApprove_Internalname));
               n192BR_Encounter_IsRandApprove = false;
               A193BR_Encounter_IsRandRecheck = StringUtil.StrToBool( cgiGet( chkBR_Encounter_IsRandRecheck_Internalname));
               n193BR_Encounter_IsRandRecheck = false;
               A202BR_Encounter_IsUpdate = StringUtil.StrToBool( cgiGet( chkBR_Encounter_IsUpdate_Internalname));
               n202BR_Encounter_IsUpdate = false;
               A360BAS_TenantTenantCode = cgiGet( edtBAS_TenantTenantCode_Internalname);
               n360BAS_TenantTenantCode = false;
            }
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
            if ( StringUtil.StrCmp(cgiGet( "GXH_vSBR_ENCOUNTERID"), AV221sBR_EncounterID) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vBR_INFORMATION_PATIENTNO"), AV17BR_Information_PatientNo) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vBR_ENCOUNTER_ADMITDATEOPERATOR"), ".", ",") != Convert.ToDecimal( AV120BR_Encounter_AdmitDateOperator )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToD( cgiGet( "GXH_vBR_ENCOUNTER_ADMITDATE"), 0) != AV122BR_Encounter_AdmitDate )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToD( cgiGet( "GXH_vBR_ENCOUNTER_ADMITDATE_TO"), 0) != AV121BR_Encounter_AdmitDate_To )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vBR_ENCOUNTER_STATUS"), ".", ",") != Convert.ToDecimal( AV141BR_Encounter_Status )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrToBool( cgiGet( "GXH_vBR_ENCOUNTER_ISRANDAPPROVE")) != AV151BR_Encounter_IsRandApprove )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrToBool( cgiGet( "GXH_vBR_ENCOUNTER_ISRANDRECHECK")) != AV152BR_Encounter_IsRandRecheck )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrToBool( cgiGet( "GXH_vBR_ENCOUNTER_ISUPDATE")) != AV153BR_Encounter_IsUpdate )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vORDEREDBY"), ".", ",") != Convert.ToDecimal( AV13OrderedBy )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrToBool( cgiGet( "GXH_vORDEREDDSC")) != AV14OrderedDsc )
            {
               GRID_nFirstRecordOnPage = 0;
            }
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      protected void GXStart( )
      {
         /* Execute user event: Start */
         E26142 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E26142( )
      {
         /* Start Routine */
         GXt_char1 = AV223tCurrentCode;
         new zbr_getcurrenttcode(context ).execute( out  GXt_char1) ;
         AV223tCurrentCode = GXt_char1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV223tCurrentCode", AV223tCurrentCode);
         edtavBr_encounterid_selected_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavBr_encounterid_selected_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_encounterid_selected_Visible), 5, 0)), true);
         subGrid_Rows = 9;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         AV141BR_Encounter_Status = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV141BR_Encounter_Status", StringUtil.LTrim( StringUtil.Str( (decimal)(AV141BR_Encounter_Status), 4, 0)));
         Ddo_br_encounterid_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_EncounterID";
         ucDdo_br_encounterid.SendProperty(context, "", false, Ddo_br_encounterid_Internalname, "TitleControlIdToReplace", Ddo_br_encounterid_Titlecontrolidtoreplace);
         AV48ddo_BR_EncounterIDTitleControlIdToReplace = Ddo_br_encounterid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV48ddo_BR_EncounterIDTitleControlIdToReplace", AV48ddo_BR_EncounterIDTitleControlIdToReplace);
         edtavDdo_br_encounteridtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_encounteridtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_encounteridtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_information_patientno_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Information_PatientNo";
         ucDdo_br_information_patientno.SendProperty(context, "", false, Ddo_br_information_patientno_Internalname, "TitleControlIdToReplace", Ddo_br_information_patientno_Titlecontrolidtoreplace);
         AV86ddo_BR_Information_PatientNoTitleControlIdToReplace = Ddo_br_information_patientno_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV86ddo_BR_Information_PatientNoTitleControlIdToReplace", AV86ddo_BR_Information_PatientNoTitleControlIdToReplace);
         edtavDdo_br_information_patientnotitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_information_patientnotitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_information_patientnotitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_encounter_department_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Encounter_Department";
         ucDdo_br_encounter_department.SendProperty(context, "", false, Ddo_br_encounter_department_Internalname, "TitleControlIdToReplace", Ddo_br_encounter_department_Titlecontrolidtoreplace);
         AV56ddo_BR_Encounter_DepartmentTitleControlIdToReplace = Ddo_br_encounter_department_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV56ddo_BR_Encounter_DepartmentTitleControlIdToReplace", AV56ddo_BR_Encounter_DepartmentTitleControlIdToReplace);
         edtavDdo_br_encounter_departmenttitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_encounter_departmenttitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_encounter_departmenttitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_encounter_enctype_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Encounter_ENCType";
         ucDdo_br_encounter_enctype.SendProperty(context, "", false, Ddo_br_encounter_enctype_Internalname, "TitleControlIdToReplace", Ddo_br_encounter_enctype_Titlecontrolidtoreplace);
         AV60ddo_BR_Encounter_ENCTypeTitleControlIdToReplace = Ddo_br_encounter_enctype_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV60ddo_BR_Encounter_ENCTypeTitleControlIdToReplace", AV60ddo_BR_Encounter_ENCTypeTitleControlIdToReplace);
         edtavDdo_br_encounter_enctypetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_encounter_enctypetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_encounter_enctypetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_encounter_admitdate_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Encounter_AdmitDate";
         ucDdo_br_encounter_admitdate.SendProperty(context, "", false, Ddo_br_encounter_admitdate_Internalname, "TitleControlIdToReplace", Ddo_br_encounter_admitdate_Titlecontrolidtoreplace);
         AV66ddo_BR_Encounter_AdmitDateTitleControlIdToReplace = Ddo_br_encounter_admitdate_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV66ddo_BR_Encounter_AdmitDateTitleControlIdToReplace", AV66ddo_BR_Encounter_AdmitDateTitleControlIdToReplace);
         edtavDdo_br_encounter_admitdatetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_encounter_admitdatetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_encounter_admitdatetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_encounter_status_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Encounter_Status";
         ucDdo_br_encounter_status.SendProperty(context, "", false, Ddo_br_encounter_status_Internalname, "TitleControlIdToReplace", Ddo_br_encounter_status_Titlecontrolidtoreplace);
         AV135ddo_BR_Encounter_StatusTitleControlIdToReplace = Ddo_br_encounter_status_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV135ddo_BR_Encounter_StatusTitleControlIdToReplace", AV135ddo_BR_Encounter_StatusTitleControlIdToReplace);
         edtavDdo_br_encounter_statustitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_encounter_statustitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_encounter_statustitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_encounter_israndapprove_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Encounter_IsRandApprove";
         ucDdo_br_encounter_israndapprove.SendProperty(context, "", false, Ddo_br_encounter_israndapprove_Internalname, "TitleControlIdToReplace", Ddo_br_encounter_israndapprove_Titlecontrolidtoreplace);
         AV157ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace = Ddo_br_encounter_israndapprove_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV157ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace", AV157ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace);
         edtavDdo_br_encounter_israndapprovetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_encounter_israndapprovetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_encounter_israndapprovetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_encounter_israndrecheck_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Encounter_IsRandRecheck";
         ucDdo_br_encounter_israndrecheck.SendProperty(context, "", false, Ddo_br_encounter_israndrecheck_Internalname, "TitleControlIdToReplace", Ddo_br_encounter_israndrecheck_Titlecontrolidtoreplace);
         AV160ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace = Ddo_br_encounter_israndrecheck_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV160ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace", AV160ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace);
         edtavDdo_br_encounter_israndrechecktitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_encounter_israndrechecktitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_encounter_israndrechecktitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_encounter_isupdate_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Encounter_IsUpdate";
         ucDdo_br_encounter_isupdate.SendProperty(context, "", false, Ddo_br_encounter_isupdate_Internalname, "TitleControlIdToReplace", Ddo_br_encounter_isupdate_Titlecontrolidtoreplace);
         AV163ddo_BR_Encounter_IsUpdateTitleControlIdToReplace = Ddo_br_encounter_isupdate_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV163ddo_BR_Encounter_IsUpdateTitleControlIdToReplace", AV163ddo_BR_Encounter_IsUpdateTitleControlIdToReplace);
         edtavDdo_br_encounter_isupdatetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_encounter_isupdatetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_encounter_isupdatetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Form.Caption = "Data Mgmt Portal - RAAP";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption, true);
         /* Execute user subroutine: 'PREPARETRANSACTION' */
         S112 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         /* Execute user subroutine: 'LOADGRIDSTATE' */
         S122 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         edtavOrderedby_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavOrderedby_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavOrderedby_Visible), 5, 0)), true);
         if ( AV13OrderedBy < 1 )
         {
            AV13OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
         }
         edtavOrdereddsc_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavOrdereddsc_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavOrdereddsc_Visible), 5, 0)), true);
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 = AV95DDO_TitleSettingsIcons;
         new GeneXus.Programs.wwpbaseobjects.getwwptitlesettingsicons(context ).execute( out  GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2) ;
         AV95DDO_TitleSettingsIcons = GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2;
         Gridpaginationbar_Rowsperpageselectedvalue = subGrid_Rows;
         ucGridpaginationbar.SendProperty(context, "", false, Gridpaginationbar_Internalname, "RowsPerPageSelectedValue", StringUtil.LTrim( StringUtil.Str( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0)));
         AV139IsChecker = false;
         AV137IsInsert = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV137IsInsert", AV137IsInsert);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vISINSERT", GetSecureSignedToken( "", AV137IsInsert, context));
         AV140IsManager = false;
         AV154IsRocheUser = false;
         AV138IsApprover = false;
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV6WWPContext) ;
         AV226tUserType = AV6WWPContext.gxTpr_Usertype;
         AV224tBR_Encounter_Status = (short)(NumberUtil.Val( AV38Session.Get("BR_Encounter_Status"), "."));
         if ( ! (0==AV224tBR_Encounter_Status) )
         {
            if ( StringUtil.StrCmp(StringUtil.Trim( StringUtil.Str( (decimal)(AV224tBR_Encounter_Status), 4, 0)), "9") == 0 )
            {
               AV141BR_Encounter_Status = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV141BR_Encounter_Status", StringUtil.LTrim( StringUtil.Str( (decimal)(AV141BR_Encounter_Status), 4, 0)));
            }
            else
            {
               AV141BR_Encounter_Status = AV224tBR_Encounter_Status;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV141BR_Encounter_Status", StringUtil.LTrim( StringUtil.Str( (decimal)(AV141BR_Encounter_Status), 4, 0)));
            }
         }
         else
         {
            if ( ! AV140IsManager )
            {
               GXt_boolean3 = AV137IsInsert;
               new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Role_CRC", out  GXt_boolean3) ;
               AV137IsInsert = GXt_boolean3;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV137IsInsert", AV137IsInsert);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vISINSERT", GetSecureSignedToken( "", AV137IsInsert, context));
               if ( AV137IsInsert )
               {
                  AV141BR_Encounter_Status = 1;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV141BR_Encounter_Status", StringUtil.LTrim( StringUtil.Str( (decimal)(AV141BR_Encounter_Status), 4, 0)));
               }
               GXt_boolean3 = AV139IsChecker;
               new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Role_Checker", out  GXt_boolean3) ;
               AV139IsChecker = GXt_boolean3;
               if ( AV139IsChecker )
               {
                  AV141BR_Encounter_Status = 2;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV141BR_Encounter_Status", StringUtil.LTrim( StringUtil.Str( (decimal)(AV141BR_Encounter_Status), 4, 0)));
               }
               GXt_boolean3 = AV138IsApprover;
               new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Role_Approver", out  GXt_boolean3) ;
               AV138IsApprover = GXt_boolean3;
               if ( AV138IsApprover )
               {
                  AV141BR_Encounter_Status = 4;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV141BR_Encounter_Status", StringUtil.LTrim( StringUtil.Str( (decimal)(AV141BR_Encounter_Status), 4, 0)));
               }
            }
         }
         AV38Session.Set("BR_InformationView_Return", "BR_EncounterWW");
      }

      protected void E27142( )
      {
         if ( gx_refresh_fired )
         {
            return  ;
         }
         gx_refresh_fired = true;
         /* Refresh Routine */
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV6WWPContext) ;
         GXt_char1 = AV223tCurrentCode;
         new zbr_getcurrenttcode(context ).execute( out  GXt_char1) ;
         AV223tCurrentCode = GXt_char1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV223tCurrentCode", AV223tCurrentCode);
         AV139IsChecker = false;
         AV137IsInsert = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV137IsInsert", AV137IsInsert);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vISINSERT", GetSecureSignedToken( "", AV137IsInsert, context));
         AV140IsManager = false;
         AV138IsApprover = false;
         GXt_boolean3 = AV137IsInsert;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Role_CRC", out  GXt_boolean3) ;
         AV137IsInsert = GXt_boolean3;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV137IsInsert", AV137IsInsert);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vISINSERT", GetSecureSignedToken( "", AV137IsInsert, context));
         GXt_boolean3 = AV139IsChecker;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Role_Checker", out  GXt_boolean3) ;
         AV139IsChecker = GXt_boolean3;
         GXt_boolean3 = AV138IsApprover;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Role_Approver", out  GXt_boolean3) ;
         AV138IsApprover = GXt_boolean3;
         GXt_boolean3 = AV140IsManager;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Role_Manager", out  GXt_boolean3) ;
         AV140IsManager = GXt_boolean3;
         if ( ! AV140IsManager )
         {
            GXt_boolean3 = AV140IsManager;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Role_ReadOnlyer", out  GXt_boolean3) ;
            AV140IsManager = GXt_boolean3;
            if ( ! AV140IsManager )
            {
               GXt_boolean3 = AV140IsManager;
               new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Role_AllManager", out  GXt_boolean3) ;
               AV140IsManager = GXt_boolean3;
            }
         }
         AV231tAllBR_EncounterID.Clear();
         if ( ! AV140IsManager )
         {
            AV227tDataPackage.Clear();
            AV228tResult = AV149WebSession.Get("DAS_UserPermission");
            AV229tSDT_MicroUserInfo.FromJSonString(AV228tResult, null);
            AV227tDataPackage.Clear();
            AV230tNum = 1;
            while ( AV230tNum <= ((SdtSDT_MicroUserInfo_Tenants)AV229tSDT_MicroUserInfo.gxTpr_Tenants.Item(1)).gxTpr_Datascoptes.Count )
            {
               AV227tDataPackage.Add(StringUtil.Trim( ((String)((SdtSDT_MicroUserInfo_Tenants)AV229tSDT_MicroUserInfo.gxTpr_Tenants.Item(1)).gxTpr_Datascoptes.Item((int)(AV230tNum)))), 0);
               AV230tNum = (long)(AV230tNum+1);
            }
         }
         AV45BR_EncounterIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV83BR_Information_PatientNoTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV53BR_Encounter_DepartmentTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV57BR_Encounter_ENCTypeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV61BR_Encounter_AdmitDateTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV132BR_Encounter_StatusTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV155BR_Encounter_IsRandApproveTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV158BR_Encounter_IsRandRecheckTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV161BR_Encounter_IsUpdateTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV6WWPContext) ;
         /* Execute user subroutine: 'CHECKSECURITYFORACTIONS' */
         S132 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         /* Execute user subroutine: 'SAVEGRIDSTATE' */
         S142 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         edtBR_EncounterID_Titleformat = 2;
         edtBR_EncounterID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "就诊序号", AV48ddo_BR_EncounterIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_EncounterID_Internalname, "Title", edtBR_EncounterID_Title, !bGXsfl_87_Refreshing);
         edtBR_Information_PatientNo_Titleformat = 2;
         edtBR_Information_PatientNo_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "患者编号", AV86ddo_BR_Information_PatientNoTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Information_PatientNo_Internalname, "Title", edtBR_Information_PatientNo_Title, !bGXsfl_87_Refreshing);
         edtBR_Encounter_Department_Titleformat = 2;
         edtBR_Encounter_Department_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "就诊科室", AV56ddo_BR_Encounter_DepartmentTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Encounter_Department_Internalname, "Title", edtBR_Encounter_Department_Title, !bGXsfl_87_Refreshing);
         edtBR_Encounter_ENCType_Titleformat = 2;
         edtBR_Encounter_ENCType_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "就诊方式", AV60ddo_BR_Encounter_ENCTypeTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Encounter_ENCType_Internalname, "Title", edtBR_Encounter_ENCType_Title, !bGXsfl_87_Refreshing);
         edtBR_Encounter_AdmitDate_Titleformat = 2;
         edtBR_Encounter_AdmitDate_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "就诊/入院时间", AV66ddo_BR_Encounter_AdmitDateTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Encounter_AdmitDate_Internalname, "Title", edtBR_Encounter_AdmitDate_Title, !bGXsfl_87_Refreshing);
         cmbBR_Encounter_Status_Titleformat = 2;
         cmbBR_Encounter_Status.Title.Text = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "审批状态", AV135ddo_BR_Encounter_StatusTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Encounter_Status_Internalname, "Title", cmbBR_Encounter_Status.Title.Text, !bGXsfl_87_Refreshing);
         chkBR_Encounter_IsRandApprove_Titleformat = 2;
         chkBR_Encounter_IsRandApprove.Title.Text = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "初审抽查", AV157ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkBR_Encounter_IsRandApprove_Internalname, "Title", chkBR_Encounter_IsRandApprove.Title.Text, !bGXsfl_87_Refreshing);
         chkBR_Encounter_IsRandRecheck_Titleformat = 2;
         chkBR_Encounter_IsRandRecheck.Title.Text = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "复审抽查", AV160ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkBR_Encounter_IsRandRecheck_Internalname, "Title", chkBR_Encounter_IsRandRecheck.Title.Text, !bGXsfl_87_Refreshing);
         chkBR_Encounter_IsUpdate_Titleformat = 2;
         chkBR_Encounter_IsUpdate.Title.Text = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "是否修改", AV163ddo_BR_Encounter_IsUpdateTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkBR_Encounter_IsUpdate_Internalname, "Title", chkBR_Encounter_IsUpdate.Title.Text, !bGXsfl_87_Refreshing);
         AV97GridCurrentPage = subGrid_Currentpage( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV97GridCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV97GridCurrentPage), 10, 0)));
         AV98GridPageSize = subGrid_Rows;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV98GridPageSize", StringUtil.LTrim( StringUtil.Str( (decimal)(AV98GridPageSize), 10, 0)));
         AV99GridRecordCount = subGrid_Recordcount( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV99GridRecordCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV99GridRecordCount), 10, 0)));
         AV235BR_EncounterWWDS_1_Br_information_patientno = AV17BR_Information_PatientNo;
         AV236BR_EncounterWWDS_2_Br_encounter_admitdate = AV122BR_Encounter_AdmitDate;
         AV237BR_EncounterWWDS_3_Br_encounter_admitdate_to = AV121BR_Encounter_AdmitDate_To;
         AV238BR_EncounterWWDS_4_Br_encounter_status = AV141BR_Encounter_Status;
         AV239BR_EncounterWWDS_5_Br_encounter_israndapprove = AV151BR_Encounter_IsRandApprove;
         AV240BR_EncounterWWDS_6_Br_encounter_israndrecheck = AV152BR_Encounter_IsRandRecheck;
         AV241BR_EncounterWWDS_7_Br_encounter_isupdate = AV153BR_Encounter_IsUpdate;
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV231tAllBR_EncounterID", AV231tAllBR_EncounterID);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV45BR_EncounterIDTitleFilterData", AV45BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV83BR_Information_PatientNoTitleFilterData", AV83BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV53BR_Encounter_DepartmentTitleFilterData", AV53BR_Encounter_DepartmentTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV57BR_Encounter_ENCTypeTitleFilterData", AV57BR_Encounter_ENCTypeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV61BR_Encounter_AdmitDateTitleFilterData", AV61BR_Encounter_AdmitDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV132BR_Encounter_StatusTitleFilterData", AV132BR_Encounter_StatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV155BR_Encounter_IsRandApproveTitleFilterData", AV155BR_Encounter_IsRandApproveTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV158BR_Encounter_IsRandRecheckTitleFilterData", AV158BR_Encounter_IsRandRecheckTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV161BR_Encounter_IsUpdateTitleFilterData", AV161BR_Encounter_IsUpdateTitleFilterData);
      }

      protected void E11142( )
      {
         /* Gridpaginationbar_Changepage Routine */
         if ( 1 == 0 )
         {
            if ( StringUtil.StrCmp(Gridpaginationbar_Selectedpage, "Previous") == 0 )
            {
               subgrid_previouspage( ) ;
            }
            else if ( StringUtil.StrCmp(Gridpaginationbar_Selectedpage, "Next") == 0 )
            {
               subgrid_nextpage( ) ;
            }
            else
            {
               AV96PageToGo = (int)(NumberUtil.Val( Gridpaginationbar_Selectedpage, "."));
               subgrid_gotopage( AV96PageToGo) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(Gridpaginationbar_Selectedpage, "Previous") == 0 )
            {
               subgrid_previouspage( ) ;
            }
            else if ( StringUtil.StrCmp(Gridpaginationbar_Selectedpage, "Next") == 0 )
            {
               subgrid_gotopage( subGrid_Currentpage( )+1) ;
            }
            else
            {
               AV96PageToGo = (int)(NumberUtil.Val( Gridpaginationbar_Selectedpage, "."));
               subgrid_gotopage( AV96PageToGo) ;
            }
         }
      }

      protected void E12142( )
      {
         /* Gridpaginationbar_Changerowsperpage Routine */
         subGrid_Rows = Gridpaginationbar_Rowsperpageselectedvalue;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         subgrid_firstpage( ) ;
         /*  Sending Event outputs  */
      }

      protected void E13142( )
      {
         /* Ddo_br_encounterid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_encounterid_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV13OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_encounterid_Sortedstatus = "ASC";
            ucDdo_br_encounterid.SendProperty(context, "", false, Ddo_br_encounterid_Internalname, "SortedStatus", Ddo_br_encounterid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_encounterid_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV13OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_encounterid_Sortedstatus = "DSC";
            ucDdo_br_encounterid.SendProperty(context, "", false, Ddo_br_encounterid_Internalname, "SortedStatus", Ddo_br_encounterid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV231tAllBR_EncounterID", AV231tAllBR_EncounterID);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV45BR_EncounterIDTitleFilterData", AV45BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV83BR_Information_PatientNoTitleFilterData", AV83BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV53BR_Encounter_DepartmentTitleFilterData", AV53BR_Encounter_DepartmentTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV57BR_Encounter_ENCTypeTitleFilterData", AV57BR_Encounter_ENCTypeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV61BR_Encounter_AdmitDateTitleFilterData", AV61BR_Encounter_AdmitDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV132BR_Encounter_StatusTitleFilterData", AV132BR_Encounter_StatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV155BR_Encounter_IsRandApproveTitleFilterData", AV155BR_Encounter_IsRandApproveTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV158BR_Encounter_IsRandRecheckTitleFilterData", AV158BR_Encounter_IsRandRecheckTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV161BR_Encounter_IsUpdateTitleFilterData", AV161BR_Encounter_IsUpdateTitleFilterData);
      }

      protected void E14142( )
      {
         /* Ddo_br_information_patientno_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_information_patientno_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV13OrderedBy = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_information_patientno_Sortedstatus = "ASC";
            ucDdo_br_information_patientno.SendProperty(context, "", false, Ddo_br_information_patientno_Internalname, "SortedStatus", Ddo_br_information_patientno_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_information_patientno_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV13OrderedBy = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_information_patientno_Sortedstatus = "DSC";
            ucDdo_br_information_patientno.SendProperty(context, "", false, Ddo_br_information_patientno_Internalname, "SortedStatus", Ddo_br_information_patientno_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV231tAllBR_EncounterID", AV231tAllBR_EncounterID);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV45BR_EncounterIDTitleFilterData", AV45BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV83BR_Information_PatientNoTitleFilterData", AV83BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV53BR_Encounter_DepartmentTitleFilterData", AV53BR_Encounter_DepartmentTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV57BR_Encounter_ENCTypeTitleFilterData", AV57BR_Encounter_ENCTypeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV61BR_Encounter_AdmitDateTitleFilterData", AV61BR_Encounter_AdmitDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV132BR_Encounter_StatusTitleFilterData", AV132BR_Encounter_StatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV155BR_Encounter_IsRandApproveTitleFilterData", AV155BR_Encounter_IsRandApproveTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV158BR_Encounter_IsRandRecheckTitleFilterData", AV158BR_Encounter_IsRandRecheckTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV161BR_Encounter_IsUpdateTitleFilterData", AV161BR_Encounter_IsUpdateTitleFilterData);
      }

      protected void E15142( )
      {
         /* Ddo_br_encounter_department_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_encounter_department_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV13OrderedBy = 3;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_encounter_department_Sortedstatus = "ASC";
            ucDdo_br_encounter_department.SendProperty(context, "", false, Ddo_br_encounter_department_Internalname, "SortedStatus", Ddo_br_encounter_department_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_encounter_department_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV13OrderedBy = 3;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_encounter_department_Sortedstatus = "DSC";
            ucDdo_br_encounter_department.SendProperty(context, "", false, Ddo_br_encounter_department_Internalname, "SortedStatus", Ddo_br_encounter_department_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV231tAllBR_EncounterID", AV231tAllBR_EncounterID);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV45BR_EncounterIDTitleFilterData", AV45BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV83BR_Information_PatientNoTitleFilterData", AV83BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV53BR_Encounter_DepartmentTitleFilterData", AV53BR_Encounter_DepartmentTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV57BR_Encounter_ENCTypeTitleFilterData", AV57BR_Encounter_ENCTypeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV61BR_Encounter_AdmitDateTitleFilterData", AV61BR_Encounter_AdmitDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV132BR_Encounter_StatusTitleFilterData", AV132BR_Encounter_StatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV155BR_Encounter_IsRandApproveTitleFilterData", AV155BR_Encounter_IsRandApproveTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV158BR_Encounter_IsRandRecheckTitleFilterData", AV158BR_Encounter_IsRandRecheckTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV161BR_Encounter_IsUpdateTitleFilterData", AV161BR_Encounter_IsUpdateTitleFilterData);
      }

      protected void E16142( )
      {
         /* Ddo_br_encounter_enctype_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_encounter_enctype_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV13OrderedBy = 4;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_encounter_enctype_Sortedstatus = "ASC";
            ucDdo_br_encounter_enctype.SendProperty(context, "", false, Ddo_br_encounter_enctype_Internalname, "SortedStatus", Ddo_br_encounter_enctype_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_encounter_enctype_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV13OrderedBy = 4;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_encounter_enctype_Sortedstatus = "DSC";
            ucDdo_br_encounter_enctype.SendProperty(context, "", false, Ddo_br_encounter_enctype_Internalname, "SortedStatus", Ddo_br_encounter_enctype_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV231tAllBR_EncounterID", AV231tAllBR_EncounterID);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV45BR_EncounterIDTitleFilterData", AV45BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV83BR_Information_PatientNoTitleFilterData", AV83BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV53BR_Encounter_DepartmentTitleFilterData", AV53BR_Encounter_DepartmentTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV57BR_Encounter_ENCTypeTitleFilterData", AV57BR_Encounter_ENCTypeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV61BR_Encounter_AdmitDateTitleFilterData", AV61BR_Encounter_AdmitDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV132BR_Encounter_StatusTitleFilterData", AV132BR_Encounter_StatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV155BR_Encounter_IsRandApproveTitleFilterData", AV155BR_Encounter_IsRandApproveTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV158BR_Encounter_IsRandRecheckTitleFilterData", AV158BR_Encounter_IsRandRecheckTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV161BR_Encounter_IsUpdateTitleFilterData", AV161BR_Encounter_IsUpdateTitleFilterData);
      }

      protected void E17142( )
      {
         /* Ddo_br_encounter_admitdate_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_encounter_admitdate_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV13OrderedBy = 5;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_encounter_admitdate_Sortedstatus = "ASC";
            ucDdo_br_encounter_admitdate.SendProperty(context, "", false, Ddo_br_encounter_admitdate_Internalname, "SortedStatus", Ddo_br_encounter_admitdate_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_encounter_admitdate_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV13OrderedBy = 5;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_encounter_admitdate_Sortedstatus = "DSC";
            ucDdo_br_encounter_admitdate.SendProperty(context, "", false, Ddo_br_encounter_admitdate_Internalname, "SortedStatus", Ddo_br_encounter_admitdate_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV231tAllBR_EncounterID", AV231tAllBR_EncounterID);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV45BR_EncounterIDTitleFilterData", AV45BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV83BR_Information_PatientNoTitleFilterData", AV83BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV53BR_Encounter_DepartmentTitleFilterData", AV53BR_Encounter_DepartmentTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV57BR_Encounter_ENCTypeTitleFilterData", AV57BR_Encounter_ENCTypeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV61BR_Encounter_AdmitDateTitleFilterData", AV61BR_Encounter_AdmitDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV132BR_Encounter_StatusTitleFilterData", AV132BR_Encounter_StatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV155BR_Encounter_IsRandApproveTitleFilterData", AV155BR_Encounter_IsRandApproveTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV158BR_Encounter_IsRandRecheckTitleFilterData", AV158BR_Encounter_IsRandRecheckTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV161BR_Encounter_IsUpdateTitleFilterData", AV161BR_Encounter_IsUpdateTitleFilterData);
      }

      protected void E18142( )
      {
         /* Ddo_br_encounter_status_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_encounter_status_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV13OrderedBy = 6;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_encounter_status_Sortedstatus = "ASC";
            ucDdo_br_encounter_status.SendProperty(context, "", false, Ddo_br_encounter_status_Internalname, "SortedStatus", Ddo_br_encounter_status_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_encounter_status_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV13OrderedBy = 6;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_encounter_status_Sortedstatus = "DSC";
            ucDdo_br_encounter_status.SendProperty(context, "", false, Ddo_br_encounter_status_Internalname, "SortedStatus", Ddo_br_encounter_status_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV231tAllBR_EncounterID", AV231tAllBR_EncounterID);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV45BR_EncounterIDTitleFilterData", AV45BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV83BR_Information_PatientNoTitleFilterData", AV83BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV53BR_Encounter_DepartmentTitleFilterData", AV53BR_Encounter_DepartmentTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV57BR_Encounter_ENCTypeTitleFilterData", AV57BR_Encounter_ENCTypeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV61BR_Encounter_AdmitDateTitleFilterData", AV61BR_Encounter_AdmitDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV132BR_Encounter_StatusTitleFilterData", AV132BR_Encounter_StatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV155BR_Encounter_IsRandApproveTitleFilterData", AV155BR_Encounter_IsRandApproveTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV158BR_Encounter_IsRandRecheckTitleFilterData", AV158BR_Encounter_IsRandRecheckTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV161BR_Encounter_IsUpdateTitleFilterData", AV161BR_Encounter_IsUpdateTitleFilterData);
      }

      protected void E19142( )
      {
         /* Ddo_br_encounter_israndapprove_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_encounter_israndapprove_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV13OrderedBy = 7;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_encounter_israndapprove_Sortedstatus = "ASC";
            ucDdo_br_encounter_israndapprove.SendProperty(context, "", false, Ddo_br_encounter_israndapprove_Internalname, "SortedStatus", Ddo_br_encounter_israndapprove_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_encounter_israndapprove_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV13OrderedBy = 7;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_encounter_israndapprove_Sortedstatus = "DSC";
            ucDdo_br_encounter_israndapprove.SendProperty(context, "", false, Ddo_br_encounter_israndapprove_Internalname, "SortedStatus", Ddo_br_encounter_israndapprove_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV231tAllBR_EncounterID", AV231tAllBR_EncounterID);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV45BR_EncounterIDTitleFilterData", AV45BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV83BR_Information_PatientNoTitleFilterData", AV83BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV53BR_Encounter_DepartmentTitleFilterData", AV53BR_Encounter_DepartmentTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV57BR_Encounter_ENCTypeTitleFilterData", AV57BR_Encounter_ENCTypeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV61BR_Encounter_AdmitDateTitleFilterData", AV61BR_Encounter_AdmitDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV132BR_Encounter_StatusTitleFilterData", AV132BR_Encounter_StatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV155BR_Encounter_IsRandApproveTitleFilterData", AV155BR_Encounter_IsRandApproveTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV158BR_Encounter_IsRandRecheckTitleFilterData", AV158BR_Encounter_IsRandRecheckTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV161BR_Encounter_IsUpdateTitleFilterData", AV161BR_Encounter_IsUpdateTitleFilterData);
      }

      protected void E20142( )
      {
         /* Ddo_br_encounter_israndrecheck_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_encounter_israndrecheck_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV13OrderedBy = 8;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_encounter_israndrecheck_Sortedstatus = "ASC";
            ucDdo_br_encounter_israndrecheck.SendProperty(context, "", false, Ddo_br_encounter_israndrecheck_Internalname, "SortedStatus", Ddo_br_encounter_israndrecheck_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_encounter_israndrecheck_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV13OrderedBy = 8;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_encounter_israndrecheck_Sortedstatus = "DSC";
            ucDdo_br_encounter_israndrecheck.SendProperty(context, "", false, Ddo_br_encounter_israndrecheck_Internalname, "SortedStatus", Ddo_br_encounter_israndrecheck_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV231tAllBR_EncounterID", AV231tAllBR_EncounterID);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV45BR_EncounterIDTitleFilterData", AV45BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV83BR_Information_PatientNoTitleFilterData", AV83BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV53BR_Encounter_DepartmentTitleFilterData", AV53BR_Encounter_DepartmentTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV57BR_Encounter_ENCTypeTitleFilterData", AV57BR_Encounter_ENCTypeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV61BR_Encounter_AdmitDateTitleFilterData", AV61BR_Encounter_AdmitDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV132BR_Encounter_StatusTitleFilterData", AV132BR_Encounter_StatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV155BR_Encounter_IsRandApproveTitleFilterData", AV155BR_Encounter_IsRandApproveTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV158BR_Encounter_IsRandRecheckTitleFilterData", AV158BR_Encounter_IsRandRecheckTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV161BR_Encounter_IsUpdateTitleFilterData", AV161BR_Encounter_IsUpdateTitleFilterData);
      }

      protected void E21142( )
      {
         /* Ddo_br_encounter_isupdate_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_encounter_isupdate_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV13OrderedBy = 9;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_encounter_isupdate_Sortedstatus = "ASC";
            ucDdo_br_encounter_isupdate.SendProperty(context, "", false, Ddo_br_encounter_isupdate_Internalname, "SortedStatus", Ddo_br_encounter_isupdate_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_encounter_isupdate_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV13OrderedBy = 9;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_encounter_isupdate_Sortedstatus = "DSC";
            ucDdo_br_encounter_isupdate.SendProperty(context, "", false, Ddo_br_encounter_isupdate_Internalname, "SortedStatus", Ddo_br_encounter_isupdate_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV231tAllBR_EncounterID", AV231tAllBR_EncounterID);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV45BR_EncounterIDTitleFilterData", AV45BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV83BR_Information_PatientNoTitleFilterData", AV83BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV53BR_Encounter_DepartmentTitleFilterData", AV53BR_Encounter_DepartmentTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV57BR_Encounter_ENCTypeTitleFilterData", AV57BR_Encounter_ENCTypeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV61BR_Encounter_AdmitDateTitleFilterData", AV61BR_Encounter_AdmitDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV132BR_Encounter_StatusTitleFilterData", AV132BR_Encounter_StatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV155BR_Encounter_IsRandApproveTitleFilterData", AV155BR_Encounter_IsRandApproveTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV158BR_Encounter_IsRandRecheckTitleFilterData", AV158BR_Encounter_IsRandRecheckTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV161BR_Encounter_IsUpdateTitleFilterData", AV161BR_Encounter_IsUpdateTitleFilterData);
      }

      private void E28142( )
      {
         /* Grid_Load Routine */
         AV164deleteEncounter = context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavDeleteencounter_Internalname, AV164deleteEncounter);
         AV242Deleteencounter_GXI = GXDbFile.PathToUrl( context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", context.GetTheme( )));
         edtavDeleteencounter_Tooltiptext = "";
         /* Load Method */
         if ( wbStart != -1 )
         {
            wbStart = 87;
         }
         sendrow_872( ) ;
         GRID_nCurrentRecord = (long)(GRID_nCurrentRecord+1);
         if ( isFullAjaxMode( ) && ! bGXsfl_87_Refreshing )
         {
            context.DoAjaxLoad(87, GridRow);
         }
         /*  Sending Event outputs  */
      }

      protected void E22142( )
      {
         /* Dvelop_confirmpanel_deleteencounter_Close Routine */
         if ( StringUtil.StrCmp(Dvelop_confirmpanel_deleteencounter_Result, "Yes") == 0 )
         {
            /* Execute user subroutine: 'DO DELETEENCOUNTER' */
            S152 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV231tAllBR_EncounterID", AV231tAllBR_EncounterID);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV45BR_EncounterIDTitleFilterData", AV45BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV83BR_Information_PatientNoTitleFilterData", AV83BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV53BR_Encounter_DepartmentTitleFilterData", AV53BR_Encounter_DepartmentTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV57BR_Encounter_ENCTypeTitleFilterData", AV57BR_Encounter_ENCTypeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV61BR_Encounter_AdmitDateTitleFilterData", AV61BR_Encounter_AdmitDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV132BR_Encounter_StatusTitleFilterData", AV132BR_Encounter_StatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV155BR_Encounter_IsRandApproveTitleFilterData", AV155BR_Encounter_IsRandApproveTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV158BR_Encounter_IsRandRecheckTitleFilterData", AV158BR_Encounter_IsRandRecheckTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV161BR_Encounter_IsUpdateTitleFilterData", AV161BR_Encounter_IsUpdateTitleFilterData);
      }

      protected void E23142( )
      {
         /* Dvelop_confirmpanel_batchapprove_Close Routine */
         if ( StringUtil.StrCmp(Dvelop_confirmpanel_batchapprove_Result, "Yes") == 0 )
         {
            /* Execute user subroutine: 'DO ACTION BATCHAPPROVE' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV231tAllBR_EncounterID", AV231tAllBR_EncounterID);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV45BR_EncounterIDTitleFilterData", AV45BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV83BR_Information_PatientNoTitleFilterData", AV83BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV53BR_Encounter_DepartmentTitleFilterData", AV53BR_Encounter_DepartmentTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV57BR_Encounter_ENCTypeTitleFilterData", AV57BR_Encounter_ENCTypeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV61BR_Encounter_AdmitDateTitleFilterData", AV61BR_Encounter_AdmitDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV132BR_Encounter_StatusTitleFilterData", AV132BR_Encounter_StatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV155BR_Encounter_IsRandApproveTitleFilterData", AV155BR_Encounter_IsRandApproveTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV158BR_Encounter_IsRandRecheckTitleFilterData", AV158BR_Encounter_IsRandRecheckTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV161BR_Encounter_IsUpdateTitleFilterData", AV161BR_Encounter_IsUpdateTitleFilterData);
      }

      protected void E24142( )
      {
         /* Dvelop_confirmpanel_batchrecheck_Close Routine */
         if ( StringUtil.StrCmp(Dvelop_confirmpanel_batchrecheck_Result, "Yes") == 0 )
         {
            /* Execute user subroutine: 'DO ACTION BATCHRECHECK' */
            S172 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV231tAllBR_EncounterID", AV231tAllBR_EncounterID);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV45BR_EncounterIDTitleFilterData", AV45BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV83BR_Information_PatientNoTitleFilterData", AV83BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV53BR_Encounter_DepartmentTitleFilterData", AV53BR_Encounter_DepartmentTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV57BR_Encounter_ENCTypeTitleFilterData", AV57BR_Encounter_ENCTypeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV61BR_Encounter_AdmitDateTitleFilterData", AV61BR_Encounter_AdmitDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV132BR_Encounter_StatusTitleFilterData", AV132BR_Encounter_StatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV155BR_Encounter_IsRandApproveTitleFilterData", AV155BR_Encounter_IsRandApproveTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV158BR_Encounter_IsRandRecheckTitleFilterData", AV158BR_Encounter_IsRandRecheckTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV161BR_Encounter_IsUpdateTitleFilterData", AV161BR_Encounter_IsUpdateTitleFilterData);
      }

      protected void S132( )
      {
         /* 'CHECKSECURITYFORACTIONS' Routine */
         GXt_boolean3 = AV166IsAuthorized_deleteEncounter;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "WWBR_Encounter_Delete", out  GXt_boolean3) ;
         AV166IsAuthorized_deleteEncounter = GXt_boolean3;
         if ( ! ( AV166IsAuthorized_deleteEncounter ) )
         {
            edtavDeleteencounter_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDeleteencounter_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDeleteencounter_Visible), 5, 0)), !bGXsfl_87_Refreshing);
         }
         GXt_boolean3 = AV105TempBoolean;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Role_Checker", out  GXt_boolean3) ;
         AV105TempBoolean = GXt_boolean3;
         if ( ! ( AV105TempBoolean ) )
         {
            bttBtnbatchapprove_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtnbatchapprove_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtnbatchapprove_Visible), 5, 0)), true);
         }
         GXt_boolean3 = AV105TempBoolean;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Role_Approver", out  GXt_boolean3) ;
         AV105TempBoolean = GXt_boolean3;
         if ( ! ( AV105TempBoolean ) )
         {
            bttBtnbatchrecheck_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtnbatchrecheck_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtnbatchrecheck_Visible), 5, 0)), true);
         }
      }

      protected void S152( )
      {
         /* 'DO DELETEENCOUNTER' Routine */
         new zbr_deleteencounter(context ).execute(  A19BR_EncounterID) ;
         context.DoAjaxRefresh();
      }

      protected void S162( )
      {
         /* 'DO ACTION BATCHAPPROVE' Routine */
         new zutil_checksession(context ).execute( out  AV232tCheckFlag) ;
         if ( ! AV232tCheckFlag )
         {
            new zbr_batchapprove(context ).execute(  AV231tAllBR_EncounterID) ;
            context.DoAjaxRefresh();
         }
      }

      protected void S172( )
      {
         /* 'DO ACTION BATCHRECHECK' Routine */
         new zutil_checksession(context ).execute( out  AV232tCheckFlag) ;
         if ( ! AV232tCheckFlag )
         {
            new zbr_batchrecheck(context ).execute(  AV231tAllBR_EncounterID) ;
            context.DoAjaxRefresh();
         }
      }

      protected void S122( )
      {
         /* 'LOADGRIDSTATE' Routine */
         if ( StringUtil.StrCmp(AV38Session.Get(AV243Pgmname+"GridState"), "") == 0 )
         {
            AV11GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  AV243Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         else
         {
            AV11GridState.FromXml(AV38Session.Get(AV243Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         AV13OrderedBy = AV11GridState.gxTpr_Orderedby;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
         AV14OrderedDsc = AV11GridState.gxTpr_Ordereddsc;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
         AV244GXV1 = 1;
         while ( AV244GXV1 <= AV11GridState.gxTpr_Filtervalues.Count )
         {
            AV12GridStateFilterValue = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue)AV11GridState.gxTpr_Filtervalues.Item(AV244GXV1));
            if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "BR_INFORMATION_PATIENTNO") == 0 )
            {
               AV17BR_Information_PatientNo = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17BR_Information_PatientNo", AV17BR_Information_PatientNo);
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "BR_ENCOUNTER_ADMITDATE") == 0 )
            {
               AV122BR_Encounter_AdmitDate = context.localUtil.CToD( AV12GridStateFilterValue.gxTpr_Value, 0);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV122BR_Encounter_AdmitDate", context.localUtil.Format(AV122BR_Encounter_AdmitDate, "9999/99/99"));
               AV120BR_Encounter_AdmitDateOperator = AV12GridStateFilterValue.gxTpr_Operator;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV120BR_Encounter_AdmitDateOperator", StringUtil.LTrim( StringUtil.Str( (decimal)(AV120BR_Encounter_AdmitDateOperator), 4, 0)));
               AV121BR_Encounter_AdmitDate_To = context.localUtil.CToD( AV12GridStateFilterValue.gxTpr_Valueto, 0);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV121BR_Encounter_AdmitDate_To", context.localUtil.Format(AV121BR_Encounter_AdmitDate_To, "9999/99/99"));
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "BR_ENCOUNTER_STATUS") == 0 )
            {
               AV141BR_Encounter_Status = (short)(NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Value, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV141BR_Encounter_Status", StringUtil.LTrim( StringUtil.Str( (decimal)(AV141BR_Encounter_Status), 4, 0)));
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "BR_ENCOUNTER_ISRANDAPPROVE") == 0 )
            {
               AV151BR_Encounter_IsRandApprove = BooleanUtil.Val( AV12GridStateFilterValue.gxTpr_Value);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV151BR_Encounter_IsRandApprove", AV151BR_Encounter_IsRandApprove);
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "BR_ENCOUNTER_ISRANDRECHECK") == 0 )
            {
               AV152BR_Encounter_IsRandRecheck = BooleanUtil.Val( AV12GridStateFilterValue.gxTpr_Value);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV152BR_Encounter_IsRandRecheck", AV152BR_Encounter_IsRandRecheck);
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "BR_ENCOUNTER_ISUPDATE") == 0 )
            {
               AV153BR_Encounter_IsUpdate = BooleanUtil.Val( AV12GridStateFilterValue.gxTpr_Value);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV153BR_Encounter_IsUpdate", AV153BR_Encounter_IsUpdate);
            }
            AV244GXV1 = (int)(AV244GXV1+1);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( StringUtil.Trim( AV11GridState.gxTpr_Pagesize))) )
         {
            subGrid_Rows = (int)(NumberUtil.Val( AV11GridState.gxTpr_Pagesize, "."));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         }
         subgrid_gotopage( AV11GridState.gxTpr_Currentpage) ;
      }

      protected void S142( )
      {
         /* 'SAVEGRIDSTATE' Routine */
         AV11GridState.FromXml(AV38Session.Get(AV243Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         AV11GridState.gxTpr_Orderedby = AV13OrderedBy;
         AV11GridState.gxTpr_Ordereddsc = AV14OrderedDsc;
         AV11GridState.gxTpr_Filtervalues.Clear();
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV17BR_Information_PatientNo)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "BR_INFORMATION_PATIENTNO";
            AV12GridStateFilterValue.gxTpr_Value = AV17BR_Information_PatientNo;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! (DateTime.MinValue==AV122BR_Encounter_AdmitDate) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "BR_ENCOUNTER_ADMITDATE";
            AV12GridStateFilterValue.gxTpr_Value = context.localUtil.DToC( AV122BR_Encounter_AdmitDate, 0, "/");
            AV12GridStateFilterValue.gxTpr_Operator = AV120BR_Encounter_AdmitDateOperator;
            AV12GridStateFilterValue.gxTpr_Valueto = context.localUtil.DToC( AV121BR_Encounter_AdmitDate_To, 0, "/");
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! (0==AV141BR_Encounter_Status) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "BR_ENCOUNTER_STATUS";
            AV12GridStateFilterValue.gxTpr_Value = StringUtil.Str( (decimal)(AV141BR_Encounter_Status), 4, 0);
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! (false==AV151BR_Encounter_IsRandApprove) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "BR_ENCOUNTER_ISRANDAPPROVE";
            AV12GridStateFilterValue.gxTpr_Value = StringUtil.BoolToStr( AV151BR_Encounter_IsRandApprove);
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! (false==AV152BR_Encounter_IsRandRecheck) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "BR_ENCOUNTER_ISRANDRECHECK";
            AV12GridStateFilterValue.gxTpr_Value = StringUtil.BoolToStr( AV152BR_Encounter_IsRandRecheck);
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! (false==AV153BR_Encounter_IsUpdate) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "BR_ENCOUNTER_ISUPDATE";
            AV12GridStateFilterValue.gxTpr_Value = StringUtil.BoolToStr( AV153BR_Encounter_IsUpdate);
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         AV11GridState.gxTpr_Pagesize = StringUtil.Str( (decimal)(subGrid_Rows), 10, 0);
         AV11GridState.gxTpr_Currentpage = (short)(subGrid_Currentpage( ));
         new GeneXus.Programs.wwpbaseobjects.savegridstate(context ).execute(  AV243Pgmname+"GridState",  AV11GridState.ToXml(false, true, "WWPGridState", "DataAnalysisPlatform")) ;
      }

      protected void S112( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV9TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV9TrnContext.gxTpr_Callerobject = AV243Pgmname;
         AV9TrnContext.gxTpr_Callerondelete = true;
         AV9TrnContext.gxTpr_Callerurl = AV8HTTPRequest.ScriptName+"?"+AV8HTTPRequest.QueryString;
         AV9TrnContext.gxTpr_Transactionname = "BR_Encounter";
         AV38Session.Set("TrnContext", AV9TrnContext.ToXml(false, true, "WWPTransactionContext", "DataAnalysisPlatform"));
      }

      protected void E25142( )
      {
         /* Sbr_encounterid_Controlvaluechanging Routine */
         new zutil_checksession(context ).execute( out  AV232tCheckFlag) ;
         if ( ! AV232tCheckFlag )
         {
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV231tAllBR_EncounterID", AV231tAllBR_EncounterID);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV45BR_EncounterIDTitleFilterData", AV45BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV83BR_Information_PatientNoTitleFilterData", AV83BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV53BR_Encounter_DepartmentTitleFilterData", AV53BR_Encounter_DepartmentTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV57BR_Encounter_ENCTypeTitleFilterData", AV57BR_Encounter_ENCTypeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV61BR_Encounter_AdmitDateTitleFilterData", AV61BR_Encounter_AdmitDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV132BR_Encounter_StatusTitleFilterData", AV132BR_Encounter_StatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV155BR_Encounter_IsRandApproveTitleFilterData", AV155BR_Encounter_IsRandApproveTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV158BR_Encounter_IsRandRecheckTitleFilterData", AV158BR_Encounter_IsRandRecheckTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV161BR_Encounter_IsUpdateTitleFilterData", AV161BR_Encounter_IsUpdateTitleFilterData);
      }

      protected void E29142( )
      {
         /* 'Dotest' Routine */
         subgrid_nextpage( ) ;
      }

      protected void E30142( )
      {
         /* 'Doadd' Routine */
         CallWebObject(formatLink("br_encounter.aspx") + "?" + UrlEncode(StringUtil.RTrim("INS")) + "," + UrlEncode("" +0));
         context.wjLocDisableFrm = 1;
      }

      protected void E31142( )
      {
         /* BR_EncounterID_Click Routine */
         if ( (0==AV141BR_Encounter_Status) )
         {
            AV38Session.Set("BR_Encounter_Status", "9");
         }
         else
         {
            AV38Session.Set("BR_Encounter_Status", StringUtil.Str( (decimal)(AV141BR_Encounter_Status), 4, 0));
         }
         AV149WebSession.Set("Br_EncounterReturnPage", "br_encounter");
         AV149WebSession.Remove("Permisstion_Update");
         if ( AV137IsInsert )
         {
            if ( A172BR_Encounter_Status == 1 )
            {
               CallWebObject(formatLink("br_encounterupdate.aspx") + "?" + UrlEncode("" +A19BR_EncounterID) + "," + UrlEncode(StringUtil.RTrim("BR_Encounter")));
               context.wjLocDisableFrm = 1;
            }
            else
            {
               CallWebObject(formatLink("br_encountercheck.aspx") + "?" + UrlEncode("" +A19BR_EncounterID) + "," + UrlEncode(StringUtil.RTrim("General")));
               context.wjLocDisableFrm = 1;
            }
         }
         else
         {
            CallWebObject(formatLink("br_encountercheck.aspx") + "?" + UrlEncode("" +A19BR_EncounterID) + "," + UrlEncode(StringUtil.RTrim("General")));
            context.wjLocDisableFrm = 1;
         }
         /*  Sending Event outputs  */
      }

      protected void wb_table5_139_142( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTabledvelop_confirmpanel_batchrecheck_Internalname, tblTabledvelop_confirmpanel_batchrecheck_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td data-align=\"center\"  style=\""+CSSHelper.Prettify( "text-align:-khtml-center;text-align:-moz-center;text-align:-webkit-center")+"\">") ;
            /* User Defined Control */
            ucDvelop_confirmpanel_batchrecheck.SetProperty("Title", Dvelop_confirmpanel_batchrecheck_Title);
            ucDvelop_confirmpanel_batchrecheck.SetProperty("ConfirmationText", Dvelop_confirmpanel_batchrecheck_Confirmationtext);
            ucDvelop_confirmpanel_batchrecheck.SetProperty("YesButtonCaption", Dvelop_confirmpanel_batchrecheck_Yesbuttoncaption);
            ucDvelop_confirmpanel_batchrecheck.SetProperty("NoButtonCaption", Dvelop_confirmpanel_batchrecheck_Nobuttoncaption);
            ucDvelop_confirmpanel_batchrecheck.SetProperty("CancelButtonCaption", Dvelop_confirmpanel_batchrecheck_Cancelbuttoncaption);
            ucDvelop_confirmpanel_batchrecheck.SetProperty("YesButtonPosition", Dvelop_confirmpanel_batchrecheck_Yesbuttonposition);
            ucDvelop_confirmpanel_batchrecheck.SetProperty("ConfirmType", Dvelop_confirmpanel_batchrecheck_Confirmtype);
            ucDvelop_confirmpanel_batchrecheck.Render(context, "dvelop.gxbootstrap.confirmpanel", Dvelop_confirmpanel_batchrecheck_Internalname, "DVELOP_CONFIRMPANEL_BATCHRECHECKContainer");
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"DVELOP_CONFIRMPANEL_BATCHRECHECKContainer"+"Body"+"\" style=\"display:none;\">") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table5_139_142e( true) ;
         }
         else
         {
            wb_table5_139_142e( false) ;
         }
      }

      protected void wb_table4_134_142( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTabledvelop_confirmpanel_batchapprove_Internalname, tblTabledvelop_confirmpanel_batchapprove_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td data-align=\"center\"  style=\""+CSSHelper.Prettify( "text-align:-khtml-center;text-align:-moz-center;text-align:-webkit-center")+"\">") ;
            /* User Defined Control */
            ucDvelop_confirmpanel_batchapprove.SetProperty("Title", Dvelop_confirmpanel_batchapprove_Title);
            ucDvelop_confirmpanel_batchapprove.SetProperty("ConfirmationText", Dvelop_confirmpanel_batchapprove_Confirmationtext);
            ucDvelop_confirmpanel_batchapprove.SetProperty("YesButtonCaption", Dvelop_confirmpanel_batchapprove_Yesbuttoncaption);
            ucDvelop_confirmpanel_batchapprove.SetProperty("NoButtonCaption", Dvelop_confirmpanel_batchapprove_Nobuttoncaption);
            ucDvelop_confirmpanel_batchapprove.SetProperty("CancelButtonCaption", Dvelop_confirmpanel_batchapprove_Cancelbuttoncaption);
            ucDvelop_confirmpanel_batchapprove.SetProperty("YesButtonPosition", Dvelop_confirmpanel_batchapprove_Yesbuttonposition);
            ucDvelop_confirmpanel_batchapprove.SetProperty("ConfirmType", Dvelop_confirmpanel_batchapprove_Confirmtype);
            ucDvelop_confirmpanel_batchapprove.Render(context, "dvelop.gxbootstrap.confirmpanel", Dvelop_confirmpanel_batchapprove_Internalname, "DVELOP_CONFIRMPANEL_BATCHAPPROVEContainer");
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"DVELOP_CONFIRMPANEL_BATCHAPPROVEContainer"+"Body"+"\" style=\"display:none;\">") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_134_142e( true) ;
         }
         else
         {
            wb_table4_134_142e( false) ;
         }
      }

      protected void wb_table3_129_142( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTabledvelop_confirmpanel_deleteencounter_Internalname, tblTabledvelop_confirmpanel_deleteencounter_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td data-align=\"center\"  style=\""+CSSHelper.Prettify( "text-align:-khtml-center;text-align:-moz-center;text-align:-webkit-center")+"\">") ;
            /* User Defined Control */
            ucDvelop_confirmpanel_deleteencounter.SetProperty("Title", Dvelop_confirmpanel_deleteencounter_Title);
            ucDvelop_confirmpanel_deleteencounter.SetProperty("ConfirmationText", Dvelop_confirmpanel_deleteencounter_Confirmationtext);
            ucDvelop_confirmpanel_deleteencounter.SetProperty("YesButtonCaption", Dvelop_confirmpanel_deleteencounter_Yesbuttoncaption);
            ucDvelop_confirmpanel_deleteencounter.SetProperty("NoButtonCaption", Dvelop_confirmpanel_deleteencounter_Nobuttoncaption);
            ucDvelop_confirmpanel_deleteencounter.SetProperty("CancelButtonCaption", Dvelop_confirmpanel_deleteencounter_Cancelbuttoncaption);
            ucDvelop_confirmpanel_deleteencounter.SetProperty("YesButtonPosition", Dvelop_confirmpanel_deleteencounter_Yesbuttonposition);
            ucDvelop_confirmpanel_deleteencounter.SetProperty("ConfirmType", Dvelop_confirmpanel_deleteencounter_Confirmtype);
            ucDvelop_confirmpanel_deleteencounter.Render(context, "dvelop.gxbootstrap.confirmpanel", Dvelop_confirmpanel_deleteencounter_Internalname, "DVELOP_CONFIRMPANEL_DELETEENCOUNTERContainer");
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"DVELOP_CONFIRMPANEL_DELETEENCOUNTERContainer"+"Body"+"\" style=\"display:none;\">") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_129_142e( true) ;
         }
         else
         {
            wb_table3_129_142e( false) ;
         }
      }

      protected void wb_table2_74_142( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblUnnamedtable1_Internalname, tblUnnamedtable1_Internalname, "", "", 0, "", "", 1, 2, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group ActionGroup", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 79,'',false,'',0)\"";
            ClassString = "ButtonColor";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnbatchapprove_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(87), 2, 0)+","+"null"+");", "全部通过初审", bttBtnbatchapprove_Jsonclick, 7, "全部通过初审", "", StyleString, ClassString, bttBtnbatchapprove_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"e32141_client"+"'", TempTags, "", 2, "HLP_BR_EncounterWW.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 81,'',false,'',0)\"";
            ClassString = "ButtonColor";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnbatchrecheck_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(87), 2, 0)+","+"null"+");", "全部通过复审", bttBtnbatchrecheck_Jsonclick, 7, "全部通过复审", "", StyleString, ClassString, bttBtnbatchrecheck_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"e33141_client"+"'", TempTags, "", 2, "HLP_BR_EncounterWW.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_74_142e( true) ;
         }
         else
         {
            wb_table2_74_142e( false) ;
         }
      }

      protected void wb_table1_33_142( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTablemergedbr_encounter_admitdate_Internalname, tblTablemergedbr_encounter_admitdate_Internalname, "", "TableMerged", 0, "", "", 0, 0, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class='MergeDataCell'>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavBr_encounter_admitdateoperator_Internalname, "BR_Encounter_Admit Date Operator", "col-sm-3 AttributeLabel", 0, true);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 37,'',false,'" + sGXsfl_87_idx + "',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavBr_encounter_admitdateoperator, cmbavBr_encounter_admitdateoperator_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(AV120BR_Encounter_AdmitDateOperator), 4, 0)), 1, cmbavBr_encounter_admitdateoperator_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", 1, cmbavBr_encounter_admitdateoperator.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,37);\"", "", true, "HLP_BR_EncounterWW.htm");
            cmbavBr_encounter_admitdateoperator.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV120BR_Encounter_AdmitDateOperator), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavBr_encounter_admitdateoperator_Internalname, "Values", (String)(cmbavBr_encounter_admitdateoperator.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_encounter_admitdate_Internalname, "BR_Encounter_Admit Date", "col-sm-3 AttributeDateLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 40,'',false,'" + sGXsfl_87_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavBr_encounter_admitdate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavBr_encounter_admitdate_Internalname, context.localUtil.Format(AV122BR_Encounter_AdmitDate, "9999/99/99"), context.localUtil.Format( AV122BR_Encounter_AdmitDate, "9999/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',0,24,'chs',false,1);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,40);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_encounter_admitdate_Jsonclick, 0, "AttributeDate", "", "", "", "", 1, edtavBr_encounter_admitdate_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_EncounterWW.htm");
            GxWebStd.gx_bitmap( context, edtavBr_encounter_admitdate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtavBr_encounter_admitdate_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_EncounterWW.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\""+cellBr_encounter_admitdate_rangemiddletext_1_cell_Internalname+"\"  class=''>") ;
            /* Text block */
            GxWebStd.gx_label_ctrl( context, lblBr_encounter_admitdate_rangemiddletext_1_Internalname, "到", "", "", lblBr_encounter_admitdate_rangemiddletext_1_Jsonclick, "'"+""+"'"+",false,"+"'"+""+"'", "", "DataFilterDescription", 0, "", 1, 1, 0, "HLP_BR_EncounterWW.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td id=\""+cellBr_encounter_admitdate_to_cell_Internalname+"\"  class=''>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", " gx-attribute", "left", "top", "", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_encounter_admitdate_to_Internalname, "BR_Encounter_Admit Date_To", "col-sm-3 AttributeDateLabel", 0, true);
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 45,'',false,'" + sGXsfl_87_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavBr_encounter_admitdate_to_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavBr_encounter_admitdate_to_Internalname, context.localUtil.Format(AV121BR_Encounter_AdmitDate_To, "9999/99/99"), context.localUtil.Format( AV121BR_Encounter_AdmitDate_To, "9999/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',0,24,'chs',false,1);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,45);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_encounter_admitdate_to_Jsonclick, 0, "AttributeDate", "", "", "", "", 1, edtavBr_encounter_admitdate_to_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_EncounterWW.htm");
            GxWebStd.gx_bitmap( context, edtavBr_encounter_admitdate_to_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtavBr_encounter_admitdate_to_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_EncounterWW.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_33_142e( true) ;
         }
         else
         {
            wb_table1_33_142e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
      }

      public override String getresponse( String sGXDynURL )
      {
         initialize_properties( ) ;
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         sDynURL = sGXDynURL;
         nGotPars = (short)(1);
         nGXWrapped = (short)(1);
         context.SetWrapped(true);
         PA142( ) ;
         WS142( ) ;
         WE142( ) ;
         this.cleanup();
         context.SetWrapped(false);
         context.GX_msglist = BackMsgLst;
         return "";
      }

      public void responsestatic( String sGXDynURL )
      {
      }

      protected void define_styles( )
      {
         AddStyleSheetFile("DVelop/DVPaginationBar/DVPaginationBar.css", "");
         AddStyleSheetFile("DVelop/Bootstrap/Shared/fontawesome/font-awesome.min.css", "");
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20202279401433", true);
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
         context.AddJavascriptSource("br_encounterww.js", "?20202279401433", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         context.AddJavascriptSource("DVelop/DVPaginationBar/DVPaginationBarRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/WorkWithPlusUtilities/WorkWithPlusUtilitiesRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/ConfirmPanel/BootstrapConfirmPanelRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/ConfirmPanel/BootstrapConfirmPanelRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/ConfirmPanel/BootstrapConfirmPanelRender.js", "", false);
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_872( )
      {
         edtavDeleteencounter_Internalname = "vDELETEENCOUNTER_"+sGXsfl_87_idx;
         edtBR_EncounterID_Internalname = "BR_ENCOUNTERID_"+sGXsfl_87_idx;
         edtBR_Information_PatientNo_Internalname = "BR_INFORMATION_PATIENTNO_"+sGXsfl_87_idx;
         edtBR_Encounter_Department_Internalname = "BR_ENCOUNTER_DEPARTMENT_"+sGXsfl_87_idx;
         edtBR_Encounter_ENCType_Internalname = "BR_ENCOUNTER_ENCTYPE_"+sGXsfl_87_idx;
         edtBR_Encounter_AdmitDate_Internalname = "BR_ENCOUNTER_ADMITDATE_"+sGXsfl_87_idx;
         edtBR_Information_ID_Internalname = "BR_INFORMATION_ID_"+sGXsfl_87_idx;
         cmbBR_Encounter_Status_Internalname = "BR_ENCOUNTER_STATUS_"+sGXsfl_87_idx;
         chkBR_Encounter_IsRandApprove_Internalname = "BR_ENCOUNTER_ISRANDAPPROVE_"+sGXsfl_87_idx;
         chkBR_Encounter_IsRandRecheck_Internalname = "BR_ENCOUNTER_ISRANDRECHECK_"+sGXsfl_87_idx;
         chkBR_Encounter_IsUpdate_Internalname = "BR_ENCOUNTER_ISUPDATE_"+sGXsfl_87_idx;
         edtBAS_TenantTenantCode_Internalname = "BAS_TENANTTENANTCODE_"+sGXsfl_87_idx;
      }

      protected void SubsflControlProps_fel_872( )
      {
         edtavDeleteencounter_Internalname = "vDELETEENCOUNTER_"+sGXsfl_87_fel_idx;
         edtBR_EncounterID_Internalname = "BR_ENCOUNTERID_"+sGXsfl_87_fel_idx;
         edtBR_Information_PatientNo_Internalname = "BR_INFORMATION_PATIENTNO_"+sGXsfl_87_fel_idx;
         edtBR_Encounter_Department_Internalname = "BR_ENCOUNTER_DEPARTMENT_"+sGXsfl_87_fel_idx;
         edtBR_Encounter_ENCType_Internalname = "BR_ENCOUNTER_ENCTYPE_"+sGXsfl_87_fel_idx;
         edtBR_Encounter_AdmitDate_Internalname = "BR_ENCOUNTER_ADMITDATE_"+sGXsfl_87_fel_idx;
         edtBR_Information_ID_Internalname = "BR_INFORMATION_ID_"+sGXsfl_87_fel_idx;
         cmbBR_Encounter_Status_Internalname = "BR_ENCOUNTER_STATUS_"+sGXsfl_87_fel_idx;
         chkBR_Encounter_IsRandApprove_Internalname = "BR_ENCOUNTER_ISRANDAPPROVE_"+sGXsfl_87_fel_idx;
         chkBR_Encounter_IsRandRecheck_Internalname = "BR_ENCOUNTER_ISRANDRECHECK_"+sGXsfl_87_fel_idx;
         chkBR_Encounter_IsUpdate_Internalname = "BR_ENCOUNTER_ISUPDATE_"+sGXsfl_87_fel_idx;
         edtBAS_TenantTenantCode_Internalname = "BAS_TENANTTENANTCODE_"+sGXsfl_87_fel_idx;
      }

      protected void sendrow_872( )
      {
         SubsflControlProps_872( ) ;
         WB140( ) ;
         if ( ( subGrid_Rows * 1 == 0 ) || ( nGXsfl_87_idx <= subGrid_Recordsperpage( ) * 1 ) )
         {
            GridRow = GXWebRow.GetNew(context,GridContainer);
            if ( subGrid_Backcolorstyle == 0 )
            {
               /* None style subfile background logic. */
               subGrid_Backstyle = 0;
               if ( StringUtil.StrCmp(subGrid_Class, "") != 0 )
               {
                  subGrid_Linesclass = subGrid_Class+"Odd";
               }
            }
            else if ( subGrid_Backcolorstyle == 1 )
            {
               /* Uniform style subfile background logic. */
               subGrid_Backstyle = 0;
               subGrid_Backcolor = subGrid_Allbackcolor;
               if ( StringUtil.StrCmp(subGrid_Class, "") != 0 )
               {
                  subGrid_Linesclass = subGrid_Class+"Uniform";
               }
            }
            else if ( subGrid_Backcolorstyle == 2 )
            {
               /* Header style subfile background logic. */
               subGrid_Backstyle = 1;
               if ( StringUtil.StrCmp(subGrid_Class, "") != 0 )
               {
                  subGrid_Linesclass = subGrid_Class+"Odd";
               }
               subGrid_Backcolor = (int)(0x0);
            }
            else if ( subGrid_Backcolorstyle == 3 )
            {
               /* Report style subfile background logic. */
               subGrid_Backstyle = 1;
               if ( ((int)(((nGXsfl_87_idx-1)/ (decimal)(1)) % (2))) == 0 )
               {
                  subGrid_Backcolor = (int)(0x0);
                  if ( StringUtil.StrCmp(subGrid_Class, "") != 0 )
                  {
                     subGrid_Linesclass = subGrid_Class+"Odd";
                  }
               }
               else
               {
                  subGrid_Backcolor = (int)(0x0);
                  if ( StringUtil.StrCmp(subGrid_Class, "") != 0 )
                  {
                     subGrid_Linesclass = subGrid_Class+"Even";
                  }
               }
            }
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<tr ") ;
               context.WriteHtmlText( " class=\""+"GridWithPaginationBar GridWithBorderColor WorkWithSelection WorkWith"+"\" style=\""+""+"\"") ;
               context.WriteHtmlText( " gxrow=\""+sGXsfl_87_idx+"\">") ;
            }
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((edtavDeleteencounter_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Active Bitmap Variable */
            TempTags = " " + ((edtavDeleteencounter_Enabled!=0)&&(edtavDeleteencounter_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 88,'',false,'',87)\"" : " ");
            ClassString = "ActionBaseColorAttribute";
            StyleString = "";
            AV164deleteEncounter_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV164deleteEncounter))&&String.IsNullOrEmpty(StringUtil.RTrim( AV242Deleteencounter_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV164deleteEncounter)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV164deleteEncounter)) ? AV242Deleteencounter_GXI : context.PathToRelativeUrl( AV164deleteEncounter));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavDeleteencounter_Internalname,(String)sImgUrl,(String)"",(String)"",(String)"",context.GetTheme( ),(int)edtavDeleteencounter_Visible,(short)1,(String)"",(String)edtavDeleteencounter_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)7,(String)edtavDeleteencounter_Jsonclick,(String)"'"+""+"'"+",false,"+"'"+"e34142_client"+"'",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)""+TempTags,(String)"",(String)"",(short)1,(bool)AV164deleteEncounter_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_EncounterID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A19BR_EncounterID), 18, 0, ".", "")),context.localUtil.Format( (decimal)(A19BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ"),(String)"","'"+""+"'"+",false,"+"'"+"EBR_ENCOUNTERID.CLICK."+sGXsfl_87_idx+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_EncounterID_Jsonclick,(short)5,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)87,(short)1,(short)-1,(short)0,(bool)true,(String)"ID",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Information_PatientNo_Internalname,(String)A36BR_Information_PatientNo,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+"e35142_client"+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Information_PatientNo_Jsonclick,(short)7,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)410,(String)"px",(short)17,(String)"px",(short)2000,(short)0,(short)0,(short)87,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Encounter_Department_Internalname,(String)A84BR_Encounter_Department,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Encounter_Department_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)87,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Encounter_ENCType_Internalname,(String)A90BR_Encounter_ENCType,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Encounter_ENCType_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)87,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Encounter_AdmitDate_Internalname,context.localUtil.Format(A91BR_Encounter_AdmitDate, "9999/99/99"),context.localUtil.Format( A91BR_Encounter_AdmitDate, "9999/99/99"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Encounter_AdmitDate_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)87,(short)1,(short)-1,(short)0,(bool)true,(String)"DM_Date",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Information_ID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A85BR_Information_ID), 18, 0, ".", "")),context.localUtil.Format( (decimal)(A85BR_Information_ID), "ZZZZZZZZZZZZZZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Information_ID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)0,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)87,(short)1,(short)-1,(short)0,(bool)true,(String)"ID",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            if ( ( cmbBR_Encounter_Status.ItemCount == 0 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "BR_ENCOUNTER_STATUS_" + sGXsfl_87_idx;
               cmbBR_Encounter_Status.Name = GXCCtl;
               cmbBR_Encounter_Status.WebTags = "";
               cmbBR_Encounter_Status.addItem(StringUtil.Trim( StringUtil.Str( (decimal)(0), 4, 0)), "(请选择)", 0);
               cmbBR_Encounter_Status.addItem("1", "录入中", 0);
               cmbBR_Encounter_Status.addItem("2", "待初审", 0);
               cmbBR_Encounter_Status.addItem("3", "初审不通过", 0);
               cmbBR_Encounter_Status.addItem("4", "待复审", 0);
               cmbBR_Encounter_Status.addItem("5", "复审不通过", 0);
               cmbBR_Encounter_Status.addItem("6", "完成", 0);
               if ( cmbBR_Encounter_Status.ItemCount > 0 )
               {
                  A172BR_Encounter_Status = (short)(NumberUtil.Val( cmbBR_Encounter_Status.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A172BR_Encounter_Status), 4, 0))), "."));
                  n172BR_Encounter_Status = false;
               }
            }
            /* ComboBox */
            GridRow.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbBR_Encounter_Status,(String)cmbBR_Encounter_Status_Internalname,StringUtil.Trim( StringUtil.Str( (decimal)(A172BR_Encounter_Status), 4, 0)),(short)1,(String)cmbBR_Encounter_Status_Jsonclick,(short)0,(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"int",(String)"",(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)"",(String)"Attribute",(String)"WWColumn hidden-xs",(String)"",(String)"",(String)"",(bool)true});
            cmbBR_Encounter_Status.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A172BR_Encounter_Status), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Encounter_Status_Internalname, "Values", (String)(cmbBR_Encounter_Status.ToJavascriptSource()), !bGXsfl_87_Refreshing);
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Check box */
            ClassString = "AttributeCheckBox";
            StyleString = "";
            GridRow.AddColumnProperties("checkbox", 1, isAjaxCallMode( ), new Object[] {(String)chkBR_Encounter_IsRandApprove_Internalname,StringUtil.BoolToStr( A192BR_Encounter_IsRandApprove),(String)"",(String)"",(short)-1,(short)0,(String)"true",(String)"",(String)StyleString,(String)ClassString,(String)"WWColumn hidden-xs",(String)"",(String)""});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Check box */
            ClassString = "AttributeCheckBox";
            StyleString = "";
            GridRow.AddColumnProperties("checkbox", 1, isAjaxCallMode( ), new Object[] {(String)chkBR_Encounter_IsRandRecheck_Internalname,StringUtil.BoolToStr( A193BR_Encounter_IsRandRecheck),(String)"",(String)"",(short)-1,(short)0,(String)"true",(String)"",(String)StyleString,(String)ClassString,(String)"WWColumn",(String)"",(String)""});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Check box */
            ClassString = "AttributeCheckBox";
            StyleString = "";
            GridRow.AddColumnProperties("checkbox", 1, isAjaxCallMode( ), new Object[] {(String)chkBR_Encounter_IsUpdate_Internalname,StringUtil.BoolToStr( A202BR_Encounter_IsUpdate),(String)"",(String)"",(short)-1,(short)0,(String)"true",(String)"",(String)StyleString,(String)ClassString,(String)"WWColumn",(String)"",(String)""});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBAS_TenantTenantCode_Internalname,(String)A360BAS_TenantTenantCode,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBAS_TenantTenantCode_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)0,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)20,(short)0,(short)0,(short)87,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            send_integrity_lvl_hashes142( ) ;
            GridContainer.AddRow(GridRow);
            nGXsfl_87_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_87_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_87_idx+1));
            sGXsfl_87_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_87_idx), 4, 0)), 4, "0");
            SubsflControlProps_872( ) ;
         }
         /* End function sendrow_872 */
      }

      protected void init_web_controls( )
      {
         cmbavBr_encounter_admitdateoperator.Name = "vBR_ENCOUNTER_ADMITDATEOPERATOR";
         cmbavBr_encounter_admitdateoperator.WebTags = "";
         cmbavBr_encounter_admitdateoperator.addItem("0", "范围", 0);
         if ( cmbavBr_encounter_admitdateoperator.ItemCount > 0 )
         {
            AV120BR_Encounter_AdmitDateOperator = (short)(NumberUtil.Val( cmbavBr_encounter_admitdateoperator.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV120BR_Encounter_AdmitDateOperator), 4, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV120BR_Encounter_AdmitDateOperator", StringUtil.LTrim( StringUtil.Str( (decimal)(AV120BR_Encounter_AdmitDateOperator), 4, 0)));
         }
         cmbavBr_encounter_status.Name = "vBR_ENCOUNTER_STATUS";
         cmbavBr_encounter_status.WebTags = "";
         cmbavBr_encounter_status.addItem(StringUtil.Trim( StringUtil.Str( (decimal)(0), 4, 0)), "全部", 0);
         cmbavBr_encounter_status.addItem("1", "录入中", 0);
         cmbavBr_encounter_status.addItem("2", "待初审", 0);
         cmbavBr_encounter_status.addItem("3", "初审不通过", 0);
         cmbavBr_encounter_status.addItem("4", "待复审", 0);
         cmbavBr_encounter_status.addItem("5", "复审不通过", 0);
         cmbavBr_encounter_status.addItem("6", "完成", 0);
         if ( cmbavBr_encounter_status.ItemCount > 0 )
         {
            AV141BR_Encounter_Status = (short)(NumberUtil.Val( cmbavBr_encounter_status.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV141BR_Encounter_Status), 4, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV141BR_Encounter_Status", StringUtil.LTrim( StringUtil.Str( (decimal)(AV141BR_Encounter_Status), 4, 0)));
         }
         chkavBr_encounter_israndapprove.Name = "vBR_ENCOUNTER_ISRANDAPPROVE";
         chkavBr_encounter_israndapprove.WebTags = "";
         chkavBr_encounter_israndapprove.Caption = "";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavBr_encounter_israndapprove_Internalname, "TitleCaption", chkavBr_encounter_israndapprove.Caption, true);
         chkavBr_encounter_israndapprove.CheckedValue = "false";
         chkavBr_encounter_israndrecheck.Name = "vBR_ENCOUNTER_ISRANDRECHECK";
         chkavBr_encounter_israndrecheck.WebTags = "";
         chkavBr_encounter_israndrecheck.Caption = "";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavBr_encounter_israndrecheck_Internalname, "TitleCaption", chkavBr_encounter_israndrecheck.Caption, true);
         chkavBr_encounter_israndrecheck.CheckedValue = "false";
         chkavBr_encounter_isupdate.Name = "vBR_ENCOUNTER_ISUPDATE";
         chkavBr_encounter_isupdate.WebTags = "";
         chkavBr_encounter_isupdate.Caption = "";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavBr_encounter_isupdate_Internalname, "TitleCaption", chkavBr_encounter_isupdate.Caption, true);
         chkavBr_encounter_isupdate.CheckedValue = "false";
         GXCCtl = "BR_ENCOUNTER_STATUS_" + sGXsfl_87_idx;
         cmbBR_Encounter_Status.Name = GXCCtl;
         cmbBR_Encounter_Status.WebTags = "";
         cmbBR_Encounter_Status.addItem(StringUtil.Trim( StringUtil.Str( (decimal)(0), 4, 0)), "(请选择)", 0);
         cmbBR_Encounter_Status.addItem("1", "录入中", 0);
         cmbBR_Encounter_Status.addItem("2", "待初审", 0);
         cmbBR_Encounter_Status.addItem("3", "初审不通过", 0);
         cmbBR_Encounter_Status.addItem("4", "待复审", 0);
         cmbBR_Encounter_Status.addItem("5", "复审不通过", 0);
         cmbBR_Encounter_Status.addItem("6", "完成", 0);
         if ( cmbBR_Encounter_Status.ItemCount > 0 )
         {
            A172BR_Encounter_Status = (short)(NumberUtil.Val( cmbBR_Encounter_Status.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A172BR_Encounter_Status), 4, 0))), "."));
            n172BR_Encounter_Status = false;
         }
         GXCCtl = "BR_ENCOUNTER_ISRANDAPPROVE_" + sGXsfl_87_idx;
         chkBR_Encounter_IsRandApprove.Name = GXCCtl;
         chkBR_Encounter_IsRandApprove.WebTags = "";
         chkBR_Encounter_IsRandApprove.Caption = "";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkBR_Encounter_IsRandApprove_Internalname, "TitleCaption", chkBR_Encounter_IsRandApprove.Caption, !bGXsfl_87_Refreshing);
         chkBR_Encounter_IsRandApprove.CheckedValue = "false";
         GXCCtl = "BR_ENCOUNTER_ISRANDRECHECK_" + sGXsfl_87_idx;
         chkBR_Encounter_IsRandRecheck.Name = GXCCtl;
         chkBR_Encounter_IsRandRecheck.WebTags = "";
         chkBR_Encounter_IsRandRecheck.Caption = "";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkBR_Encounter_IsRandRecheck_Internalname, "TitleCaption", chkBR_Encounter_IsRandRecheck.Caption, !bGXsfl_87_Refreshing);
         chkBR_Encounter_IsRandRecheck.CheckedValue = "false";
         GXCCtl = "BR_ENCOUNTER_ISUPDATE_" + sGXsfl_87_idx;
         chkBR_Encounter_IsUpdate.Name = GXCCtl;
         chkBR_Encounter_IsUpdate.WebTags = "";
         chkBR_Encounter_IsUpdate.Caption = "";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkBR_Encounter_IsUpdate_Internalname, "TitleCaption", chkBR_Encounter_IsUpdate.Caption, !bGXsfl_87_Refreshing);
         chkBR_Encounter_IsUpdate.CheckedValue = "false";
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         edtavSbr_encounterid_Internalname = "vSBR_ENCOUNTERID";
         edtavBr_information_patientno_Internalname = "vBR_INFORMATION_PATIENTNO";
         lblFiltertextbr_encounter_admitdate_Internalname = "FILTERTEXTBR_ENCOUNTER_ADMITDATE";
         cmbavBr_encounter_admitdateoperator_Internalname = "vBR_ENCOUNTER_ADMITDATEOPERATOR";
         edtavBr_encounter_admitdate_Internalname = "vBR_ENCOUNTER_ADMITDATE";
         lblBr_encounter_admitdate_rangemiddletext_1_Internalname = "BR_ENCOUNTER_ADMITDATE_RANGEMIDDLETEXT_1";
         cellBr_encounter_admitdate_rangemiddletext_1_cell_Internalname = "BR_ENCOUNTER_ADMITDATE_RANGEMIDDLETEXT_1_CELL";
         edtavBr_encounter_admitdate_to_Internalname = "vBR_ENCOUNTER_ADMITDATE_TO";
         cellBr_encounter_admitdate_to_cell_Internalname = "BR_ENCOUNTER_ADMITDATE_TO_CELL";
         tblTablemergedbr_encounter_admitdate_Internalname = "TABLEMERGEDBR_ENCOUNTER_ADMITDATE";
         divTablesplittedfiltertextbr_encounter_admitdate_Internalname = "TABLESPLITTEDFILTERTEXTBR_ENCOUNTER_ADMITDATE";
         cmbavBr_encounter_status_Internalname = "vBR_ENCOUNTER_STATUS";
         chkavBr_encounter_israndapprove_Internalname = "vBR_ENCOUNTER_ISRANDAPPROVE";
         chkavBr_encounter_israndrecheck_Internalname = "vBR_ENCOUNTER_ISRANDRECHECK";
         chkavBr_encounter_isupdate_Internalname = "vBR_ENCOUNTER_ISUPDATE";
         divUnnamedtable2_Internalname = "UNNAMEDTABLE2";
         divTableactions_Internalname = "TABLEACTIONS";
         divTableheader_Internalname = "TABLEHEADER";
         divLayout_tableheader_Internalname = "LAYOUT_TABLEHEADER";
         Dvpanel_tableheader_Internalname = "DVPANEL_TABLEHEADER";
         divHtml_dvpanel_tableheader_Internalname = "HTML_DVPANEL_TABLEHEADER";
         bttBtnbatchapprove_Internalname = "BTNBATCHAPPROVE";
         bttBtnbatchrecheck_Internalname = "BTNBATCHRECHECK";
         tblUnnamedtable1_Internalname = "UNNAMEDTABLE1";
         divLayout_unnamedtable1_Internalname = "LAYOUT_UNNAMEDTABLE1";
         Dvpanel_unnamedtable1_Internalname = "DVPANEL_UNNAMEDTABLE1";
         divHtml_dvpanel_unnamedtable1_Internalname = "HTML_DVPANEL_UNNAMEDTABLE1";
         edtavDeleteencounter_Internalname = "vDELETEENCOUNTER";
         edtBR_EncounterID_Internalname = "BR_ENCOUNTERID";
         edtBR_Information_PatientNo_Internalname = "BR_INFORMATION_PATIENTNO";
         edtBR_Encounter_Department_Internalname = "BR_ENCOUNTER_DEPARTMENT";
         edtBR_Encounter_ENCType_Internalname = "BR_ENCOUNTER_ENCTYPE";
         edtBR_Encounter_AdmitDate_Internalname = "BR_ENCOUNTER_ADMITDATE";
         edtBR_Information_ID_Internalname = "BR_INFORMATION_ID";
         cmbBR_Encounter_Status_Internalname = "BR_ENCOUNTER_STATUS";
         chkBR_Encounter_IsRandApprove_Internalname = "BR_ENCOUNTER_ISRANDAPPROVE";
         chkBR_Encounter_IsRandRecheck_Internalname = "BR_ENCOUNTER_ISRANDRECHECK";
         chkBR_Encounter_IsUpdate_Internalname = "BR_ENCOUNTER_ISUPDATE";
         edtBAS_TenantTenantCode_Internalname = "BAS_TENANTTENANTCODE";
         Gridpaginationbar_Internalname = "GRIDPAGINATIONBAR";
         divHtml_gridpaginationbar_Internalname = "HTML_GRIDPAGINATIONBAR";
         divGridtablewithpaginationbar_Internalname = "GRIDTABLEWITHPAGINATIONBAR";
         divTablemain_Internalname = "TABLEMAIN";
         Ddo_br_encounterid_Internalname = "DDO_BR_ENCOUNTERID";
         edtavDdo_br_encounteridtitlecontrolidtoreplace_Internalname = "vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE";
         Ddo_br_information_patientno_Internalname = "DDO_BR_INFORMATION_PATIENTNO";
         edtavDdo_br_information_patientnotitlecontrolidtoreplace_Internalname = "vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE";
         Ddo_br_encounter_department_Internalname = "DDO_BR_ENCOUNTER_DEPARTMENT";
         edtavDdo_br_encounter_departmenttitlecontrolidtoreplace_Internalname = "vDDO_BR_ENCOUNTER_DEPARTMENTTITLECONTROLIDTOREPLACE";
         Ddo_br_encounter_enctype_Internalname = "DDO_BR_ENCOUNTER_ENCTYPE";
         edtavDdo_br_encounter_enctypetitlecontrolidtoreplace_Internalname = "vDDO_BR_ENCOUNTER_ENCTYPETITLECONTROLIDTOREPLACE";
         Ddo_br_encounter_admitdate_Internalname = "DDO_BR_ENCOUNTER_ADMITDATE";
         edtavDdo_br_encounter_admitdatetitlecontrolidtoreplace_Internalname = "vDDO_BR_ENCOUNTER_ADMITDATETITLECONTROLIDTOREPLACE";
         Ddo_br_encounter_status_Internalname = "DDO_BR_ENCOUNTER_STATUS";
         edtavDdo_br_encounter_statustitlecontrolidtoreplace_Internalname = "vDDO_BR_ENCOUNTER_STATUSTITLECONTROLIDTOREPLACE";
         Ddo_br_encounter_israndapprove_Internalname = "DDO_BR_ENCOUNTER_ISRANDAPPROVE";
         edtavDdo_br_encounter_israndapprovetitlecontrolidtoreplace_Internalname = "vDDO_BR_ENCOUNTER_ISRANDAPPROVETITLECONTROLIDTOREPLACE";
         Ddo_br_encounter_israndrecheck_Internalname = "DDO_BR_ENCOUNTER_ISRANDRECHECK";
         edtavDdo_br_encounter_israndrechecktitlecontrolidtoreplace_Internalname = "vDDO_BR_ENCOUNTER_ISRANDRECHECKTITLECONTROLIDTOREPLACE";
         Ddo_br_encounter_isupdate_Internalname = "DDO_BR_ENCOUNTER_ISUPDATE";
         edtavDdo_br_encounter_isupdatetitlecontrolidtoreplace_Internalname = "vDDO_BR_ENCOUNTER_ISUPDATETITLECONTROLIDTOREPLACE";
         Workwithplusutilities1_Internalname = "WORKWITHPLUSUTILITIES1";
         edtavBr_encounterid_selected_Internalname = "vBR_ENCOUNTERID_SELECTED";
         edtavOrderedby_Internalname = "vORDEREDBY";
         edtavOrdereddsc_Internalname = "vORDEREDDSC";
         Dvelop_confirmpanel_deleteencounter_Internalname = "DVELOP_CONFIRMPANEL_DELETEENCOUNTER";
         tblTabledvelop_confirmpanel_deleteencounter_Internalname = "TABLEDVELOP_CONFIRMPANEL_DELETEENCOUNTER";
         Dvelop_confirmpanel_batchapprove_Internalname = "DVELOP_CONFIRMPANEL_BATCHAPPROVE";
         tblTabledvelop_confirmpanel_batchapprove_Internalname = "TABLEDVELOP_CONFIRMPANEL_BATCHAPPROVE";
         Dvelop_confirmpanel_batchrecheck_Internalname = "DVELOP_CONFIRMPANEL_BATCHRECHECK";
         tblTabledvelop_confirmpanel_batchrecheck_Internalname = "TABLEDVELOP_CONFIRMPANEL_BATCHRECHECK";
         divHtml_bottomauxiliarcontrols_Internalname = "HTML_BOTTOMAUXILIARCONTROLS";
         divLayoutmaintable_Internalname = "LAYOUTMAINTABLE";
         Form.Internalname = "FORM";
         subGrid_Internalname = "GRID";
      }

      public override void initialize_properties( )
      {
         context.SetDefaultTheme("WorkWithPlusTheme");
         if ( context.isSpaRequest( ) )
         {
            disableJsOutput();
         }
         init_default_properties( ) ;
         chkBR_Encounter_IsUpdate.Caption = "";
         chkBR_Encounter_IsRandRecheck.Caption = "";
         chkBR_Encounter_IsRandApprove.Caption = "";
         chkavBr_encounter_isupdate.Caption = "是否修改";
         chkavBr_encounter_israndrecheck.Caption = "是否复审抽查";
         chkavBr_encounter_israndapprove.Caption = "是否初审抽查";
         edtBAS_TenantTenantCode_Jsonclick = "";
         cmbBR_Encounter_Status_Jsonclick = "";
         edtBR_Information_ID_Jsonclick = "";
         edtBR_Encounter_AdmitDate_Jsonclick = "";
         edtBR_Encounter_ENCType_Jsonclick = "";
         edtBR_Encounter_Department_Jsonclick = "";
         edtBR_Information_PatientNo_Jsonclick = "";
         edtBR_EncounterID_Jsonclick = "";
         edtavDeleteencounter_Jsonclick = "";
         edtavDeleteencounter_Enabled = 1;
         edtavBr_encounter_admitdate_to_Jsonclick = "";
         edtavBr_encounter_admitdate_to_Enabled = 1;
         edtavBr_encounter_admitdate_Jsonclick = "";
         edtavBr_encounter_admitdate_Enabled = 1;
         cmbavBr_encounter_admitdateoperator_Jsonclick = "";
         cmbavBr_encounter_admitdateoperator.Enabled = 1;
         bttBtnbatchrecheck_Visible = 1;
         bttBtnbatchapprove_Visible = 1;
         edtavOrdereddsc_Jsonclick = "";
         edtavOrdereddsc_Visible = 1;
         edtavOrderedby_Jsonclick = "";
         edtavOrderedby_Visible = 1;
         edtavBr_encounterid_selected_Jsonclick = "";
         edtavBr_encounterid_selected_Visible = 1;
         edtavDdo_br_encounter_isupdatetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_encounter_israndrechecktitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_encounter_israndapprovetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_encounter_statustitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_encounter_admitdatetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_encounter_enctypetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_encounter_departmenttitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_information_patientnotitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_encounteridtitlecontrolidtoreplace_Visible = 1;
         subGrid_Allowcollapsing = 0;
         subGrid_Allowhovering = -1;
         subGrid_Allowselection = 1;
         edtavDeleteencounter_Tooltiptext = "";
         subGrid_Sortable = 0;
         subGrid_Header = "";
         chkBR_Encounter_IsUpdate_Titleformat = 0;
         chkBR_Encounter_IsUpdate.Title.Text = "是否修改";
         chkBR_Encounter_IsRandRecheck_Titleformat = 0;
         chkBR_Encounter_IsRandRecheck.Title.Text = "复审抽查";
         chkBR_Encounter_IsRandApprove_Titleformat = 0;
         chkBR_Encounter_IsRandApprove.Title.Text = "初审抽查";
         cmbBR_Encounter_Status_Titleformat = 0;
         cmbBR_Encounter_Status.Title.Text = "审批状态";
         edtBR_Encounter_AdmitDate_Titleformat = 0;
         edtBR_Encounter_AdmitDate_Title = "就诊/入院时间";
         edtBR_Encounter_ENCType_Titleformat = 0;
         edtBR_Encounter_ENCType_Title = "就诊方式";
         edtBR_Encounter_Department_Titleformat = 0;
         edtBR_Encounter_Department_Title = "就诊科室";
         edtBR_Information_PatientNo_Titleformat = 0;
         edtBR_Information_PatientNo_Title = "患者编号";
         edtBR_EncounterID_Titleformat = 0;
         edtBR_EncounterID_Title = "就诊序号";
         edtavDeleteencounter_Visible = -1;
         subGrid_Class = "GridWithPaginationBar GridWithBorderColor WorkWithSelection WorkWith";
         subGrid_Backcolorstyle = 0;
         chkavBr_encounter_isupdate.Enabled = 1;
         chkavBr_encounter_israndrecheck.Enabled = 1;
         chkavBr_encounter_israndapprove.Enabled = 1;
         cmbavBr_encounter_status_Jsonclick = "";
         cmbavBr_encounter_status.Enabled = 1;
         edtavBr_information_patientno_Jsonclick = "";
         edtavBr_information_patientno_Enabled = 1;
         edtavSbr_encounterid_Jsonclick = "";
         edtavSbr_encounterid_Enabled = 1;
         Dvelop_confirmpanel_batchrecheck_Confirmtype = "1";
         Dvelop_confirmpanel_batchrecheck_Yesbuttonposition = "left";
         Dvelop_confirmpanel_batchrecheck_Cancelbuttoncaption = "WWP_ConfirmTextCancel";
         Dvelop_confirmpanel_batchrecheck_Nobuttoncaption = "WWP_ConfirmTextNo";
         Dvelop_confirmpanel_batchrecheck_Yesbuttoncaption = "WWP_ConfirmTextYes";
         Dvelop_confirmpanel_batchrecheck_Confirmationtext = "确认批量提交复审？";
         Dvelop_confirmpanel_batchrecheck_Title = "";
         Dvelop_confirmpanel_batchapprove_Confirmtype = "1";
         Dvelop_confirmpanel_batchapprove_Yesbuttonposition = "left";
         Dvelop_confirmpanel_batchapprove_Cancelbuttoncaption = "WWP_ConfirmTextCancel";
         Dvelop_confirmpanel_batchapprove_Nobuttoncaption = "WWP_ConfirmTextNo";
         Dvelop_confirmpanel_batchapprove_Yesbuttoncaption = "WWP_ConfirmTextYes";
         Dvelop_confirmpanel_batchapprove_Confirmationtext = "确认批量提交初审？";
         Dvelop_confirmpanel_batchapprove_Title = "";
         Dvelop_confirmpanel_deleteencounter_Confirmtype = "1";
         Dvelop_confirmpanel_deleteencounter_Yesbuttonposition = "left";
         Dvelop_confirmpanel_deleteencounter_Cancelbuttoncaption = "WWP_ConfirmTextCancel";
         Dvelop_confirmpanel_deleteencounter_Nobuttoncaption = "WWP_ConfirmTextNo";
         Dvelop_confirmpanel_deleteencounter_Yesbuttoncaption = "WWP_ConfirmTextYes";
         Dvelop_confirmpanel_deleteencounter_Confirmationtext = "确认删除？";
         Dvelop_confirmpanel_deleteencounter_Title = "";
         Ddo_br_encounter_isupdate_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_encounter_isupdate_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_encounter_isupdate_Sortasc = "WWP_TSSortASC";
         Ddo_br_encounter_isupdate_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_encounter_isupdate_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_encounter_isupdate_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_encounter_isupdate_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_encounter_isupdate_Titlecontrolidtoreplace = "";
         Ddo_br_encounter_isupdate_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_encounter_isupdate_Cls = "ColumnSettings";
         Ddo_br_encounter_isupdate_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_encounter_isupdate_Caption = "";
         Ddo_br_encounter_israndrecheck_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_encounter_israndrecheck_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_encounter_israndrecheck_Sortasc = "WWP_TSSortASC";
         Ddo_br_encounter_israndrecheck_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_encounter_israndrecheck_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_encounter_israndrecheck_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_encounter_israndrecheck_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_encounter_israndrecheck_Titlecontrolidtoreplace = "";
         Ddo_br_encounter_israndrecheck_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_encounter_israndrecheck_Cls = "ColumnSettings";
         Ddo_br_encounter_israndrecheck_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_encounter_israndrecheck_Caption = "";
         Ddo_br_encounter_israndapprove_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_encounter_israndapprove_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_encounter_israndapprove_Sortasc = "WWP_TSSortASC";
         Ddo_br_encounter_israndapprove_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_encounter_israndapprove_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_encounter_israndapprove_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_encounter_israndapprove_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_encounter_israndapprove_Titlecontrolidtoreplace = "";
         Ddo_br_encounter_israndapprove_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_encounter_israndapprove_Cls = "ColumnSettings";
         Ddo_br_encounter_israndapprove_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_encounter_israndapprove_Caption = "";
         Ddo_br_encounter_status_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_encounter_status_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_encounter_status_Sortasc = "WWP_TSSortASC";
         Ddo_br_encounter_status_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_encounter_status_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_encounter_status_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_encounter_status_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_encounter_status_Titlecontrolidtoreplace = "";
         Ddo_br_encounter_status_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_encounter_status_Cls = "ColumnSettings";
         Ddo_br_encounter_status_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_encounter_status_Caption = "";
         Ddo_br_encounter_admitdate_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_encounter_admitdate_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_encounter_admitdate_Sortasc = "WWP_TSSortASC";
         Ddo_br_encounter_admitdate_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_encounter_admitdate_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_encounter_admitdate_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_encounter_admitdate_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_encounter_admitdate_Titlecontrolidtoreplace = "";
         Ddo_br_encounter_admitdate_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_encounter_admitdate_Cls = "ColumnSettings";
         Ddo_br_encounter_admitdate_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_encounter_admitdate_Caption = "";
         Ddo_br_encounter_enctype_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_encounter_enctype_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_encounter_enctype_Sortasc = "WWP_TSSortASC";
         Ddo_br_encounter_enctype_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_encounter_enctype_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_encounter_enctype_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_encounter_enctype_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_encounter_enctype_Titlecontrolidtoreplace = "";
         Ddo_br_encounter_enctype_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_encounter_enctype_Cls = "ColumnSettings";
         Ddo_br_encounter_enctype_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_encounter_enctype_Caption = "";
         Ddo_br_encounter_department_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_encounter_department_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_encounter_department_Sortasc = "WWP_TSSortASC";
         Ddo_br_encounter_department_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_encounter_department_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_encounter_department_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_encounter_department_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_encounter_department_Titlecontrolidtoreplace = "";
         Ddo_br_encounter_department_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_encounter_department_Cls = "ColumnSettings";
         Ddo_br_encounter_department_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_encounter_department_Caption = "";
         Ddo_br_information_patientno_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_information_patientno_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_information_patientno_Sortasc = "WWP_TSSortASC";
         Ddo_br_information_patientno_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_information_patientno_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_information_patientno_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_information_patientno_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_information_patientno_Titlecontrolidtoreplace = "";
         Ddo_br_information_patientno_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_information_patientno_Cls = "ColumnSettings";
         Ddo_br_information_patientno_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_information_patientno_Caption = "";
         Ddo_br_encounterid_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_encounterid_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_encounterid_Sortasc = "WWP_TSSortASC";
         Ddo_br_encounterid_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_encounterid_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_encounterid_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_encounterid_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_encounterid_Titlecontrolidtoreplace = "";
         Ddo_br_encounterid_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_encounterid_Cls = "ColumnSettings";
         Ddo_br_encounterid_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_encounterid_Caption = "";
         Gridpaginationbar_Rowsperpagecaption = "WWP_PagingRowsPerPage";
         Gridpaginationbar_Emptygridcaption = "WWP_PagingEmptyGridCaption";
         Gridpaginationbar_Rowsperpageoptions = "5:WWP_Rows5,10:WWP_Rows10,20:WWP_Rows20,50:WWP_Rows50";
         Gridpaginationbar_Rowsperpageselectedvalue = 10;
         Gridpaginationbar_Rowsperpageselector = Convert.ToBoolean( -1);
         Gridpaginationbar_Emptygridclass = "PaginationBarEmptyGrid";
         Gridpaginationbar_Pagingcaptionposition = "Left";
         Gridpaginationbar_Pagingbuttonsposition = "Right";
         Gridpaginationbar_Pagestoshow = 5;
         Gridpaginationbar_Showlast = Convert.ToBoolean( 0);
         Gridpaginationbar_Shownext = Convert.ToBoolean( -1);
         Gridpaginationbar_Showprevious = Convert.ToBoolean( -1);
         Gridpaginationbar_Showfirst = Convert.ToBoolean( 0);
         Gridpaginationbar_Caption = "<CURRENT_PAGE>页/<TOTAL_PAGES>页 记录：<TOTAL_RECORDS>条";
         Gridpaginationbar_Next = "WWP_PagingNextCaption";
         Gridpaginationbar_Previous = "WWP_PagingPreviousCaption";
         Gridpaginationbar_Class = "PaginationBar";
         Dvpanel_unnamedtable1_Autoscroll = Convert.ToBoolean( 0);
         Dvpanel_unnamedtable1_Iconposition = "left";
         Dvpanel_unnamedtable1_Showcollapseicon = Convert.ToBoolean( 0);
         Dvpanel_unnamedtable1_Autoheight = Convert.ToBoolean( -1);
         Dvpanel_unnamedtable1_Autowidth = Convert.ToBoolean( 0);
         Dvpanel_unnamedtable1_Collapsed = Convert.ToBoolean( 0);
         Dvpanel_unnamedtable1_Collapsible = Convert.ToBoolean( -1);
         Dvpanel_unnamedtable1_Title = "";
         Dvpanel_unnamedtable1_Cls = "PanelNoHeader";
         Dvpanel_unnamedtable1_Width = "100%";
         Dvpanel_tableheader_Autoscroll = Convert.ToBoolean( 0);
         Dvpanel_tableheader_Iconposition = "left";
         Dvpanel_tableheader_Showcollapseicon = Convert.ToBoolean( 0);
         Dvpanel_tableheader_Autoheight = Convert.ToBoolean( -1);
         Dvpanel_tableheader_Autowidth = Convert.ToBoolean( 0);
         Dvpanel_tableheader_Collapsed = Convert.ToBoolean( 0);
         Dvpanel_tableheader_Collapsible = Convert.ToBoolean( -1);
         Dvpanel_tableheader_Title = "选项";
         Dvpanel_tableheader_Cls = "PanelNoHeader";
         Dvpanel_tableheader_Width = "100%";
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Data Mgmt Portal - RAAP";
         subGrid_Rows = 0;
         if ( context.isSpaRequest( ) )
         {
            enableJsOutput();
         }
      }

      public override bool SupportAjaxEvent( )
      {
         return true ;
      }

      public override void InitializeDynEvents( )
      {
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV221sBR_EncounterID',fld:'vSBR_ENCOUNTERID',pic:''},{av:'AV48ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV86ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV56ddo_BR_Encounter_DepartmentTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DEPARTMENTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV60ddo_BR_Encounter_ENCTypeTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV66ddo_BR_Encounter_AdmitDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ADMITDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV135ddo_BR_Encounter_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV157ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV160ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDRECHECKTITLECONTROLIDTOREPLACE',pic:''},{av:'AV163ddo_BR_Encounter_IsUpdateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISUPDATETITLECONTROLIDTOREPLACE',pic:''},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV17BR_Information_PatientNo',fld:'vBR_INFORMATION_PATIENTNO',pic:''},{av:'AV122BR_Encounter_AdmitDate',fld:'vBR_ENCOUNTER_ADMITDATE',pic:''},{av:'AV121BR_Encounter_AdmitDate_To',fld:'vBR_ENCOUNTER_ADMITDATE_TO',pic:''},{av:'cmbavBr_encounter_status'},{av:'AV141BR_Encounter_Status',fld:'vBR_ENCOUNTER_STATUS',pic:'ZZZ9'},{av:'AV151BR_Encounter_IsRandApprove',fld:'vBR_ENCOUNTER_ISRANDAPPROVE',pic:''},{av:'AV152BR_Encounter_IsRandRecheck',fld:'vBR_ENCOUNTER_ISRANDRECHECK',pic:''},{av:'AV153BR_Encounter_IsUpdate',fld:'vBR_ENCOUNTER_ISUPDATE',pic:''},{av:'AV243Pgmname',fld:'vPGMNAME',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'cmbavBr_encounter_admitdateoperator'},{av:'AV120BR_Encounter_AdmitDateOperator',fld:'vBR_ENCOUNTER_ADMITDATEOPERATOR',pic:'ZZZ9'},{av:'AV137IsInsert',fld:'vISINSERT',pic:'',hsh:true}]");
         setEventMetadata("REFRESH",",oparms:[{av:'AV223tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'AV137IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'AV231tAllBR_EncounterID',fld:'vTALLBR_ENCOUNTERID',pic:''},{av:'AV45BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV83BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV53BR_Encounter_DepartmentTitleFilterData',fld:'vBR_ENCOUNTER_DEPARTMENTTITLEFILTERDATA',pic:''},{av:'AV57BR_Encounter_ENCTypeTitleFilterData',fld:'vBR_ENCOUNTER_ENCTYPETITLEFILTERDATA',pic:''},{av:'AV61BR_Encounter_AdmitDateTitleFilterData',fld:'vBR_ENCOUNTER_ADMITDATETITLEFILTERDATA',pic:''},{av:'AV132BR_Encounter_StatusTitleFilterData',fld:'vBR_ENCOUNTER_STATUSTITLEFILTERDATA',pic:''},{av:'AV155BR_Encounter_IsRandApproveTitleFilterData',fld:'vBR_ENCOUNTER_ISRANDAPPROVETITLEFILTERDATA',pic:''},{av:'AV158BR_Encounter_IsRandRecheckTitleFilterData',fld:'vBR_ENCOUNTER_ISRANDRECHECKTITLEFILTERDATA',pic:''},{av:'AV161BR_Encounter_IsUpdateTitleFilterData',fld:'vBR_ENCOUNTER_ISUPDATETITLEFILTERDATA',pic:''},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Encounter_Department_Titleformat',ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Titleformat'},{av:'edtBR_Encounter_Department_Title',ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Title'},{av:'edtBR_Encounter_ENCType_Titleformat',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Titleformat'},{av:'edtBR_Encounter_ENCType_Title',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Title'},{av:'edtBR_Encounter_AdmitDate_Titleformat',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Titleformat'},{av:'edtBR_Encounter_AdmitDate_Title',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Title'},{av:'cmbBR_Encounter_Status'},{av:'chkBR_Encounter_IsRandApprove_Titleformat',ctrl:'BR_ENCOUNTER_ISRANDAPPROVE',prop:'Titleformat'},{av:'chkBR_Encounter_IsRandApprove.Title.Text',ctrl:'BR_ENCOUNTER_ISRANDAPPROVE',prop:'Title'},{av:'chkBR_Encounter_IsRandRecheck_Titleformat',ctrl:'BR_ENCOUNTER_ISRANDRECHECK',prop:'Titleformat'},{av:'chkBR_Encounter_IsRandRecheck.Title.Text',ctrl:'BR_ENCOUNTER_ISRANDRECHECK',prop:'Title'},{av:'chkBR_Encounter_IsUpdate_Titleformat',ctrl:'BR_ENCOUNTER_ISUPDATE',prop:'Titleformat'},{av:'chkBR_Encounter_IsUpdate.Title.Text',ctrl:'BR_ENCOUNTER_ISUPDATE',prop:'Title'},{av:'AV97GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV98GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV99GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'edtavDeleteencounter_Visible',ctrl:'vDELETEENCOUNTER',prop:'Visible'},{ctrl:'BTNBATCHAPPROVE',prop:'Visible'},{ctrl:'BTNBATCHRECHECK',prop:'Visible'}]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE","{handler:'E11142',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV221sBR_EncounterID',fld:'vSBR_ENCOUNTERID',pic:''},{av:'AV17BR_Information_PatientNo',fld:'vBR_INFORMATION_PATIENTNO',pic:''},{av:'cmbavBr_encounter_admitdateoperator'},{av:'AV120BR_Encounter_AdmitDateOperator',fld:'vBR_ENCOUNTER_ADMITDATEOPERATOR',pic:'ZZZ9'},{av:'AV122BR_Encounter_AdmitDate',fld:'vBR_ENCOUNTER_ADMITDATE',pic:''},{av:'AV121BR_Encounter_AdmitDate_To',fld:'vBR_ENCOUNTER_ADMITDATE_TO',pic:''},{av:'cmbavBr_encounter_status'},{av:'AV141BR_Encounter_Status',fld:'vBR_ENCOUNTER_STATUS',pic:'ZZZ9'},{av:'AV151BR_Encounter_IsRandApprove',fld:'vBR_ENCOUNTER_ISRANDAPPROVE',pic:''},{av:'AV152BR_Encounter_IsRandRecheck',fld:'vBR_ENCOUNTER_ISRANDRECHECK',pic:''},{av:'AV153BR_Encounter_IsUpdate',fld:'vBR_ENCOUNTER_ISUPDATE',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV48ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV86ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV56ddo_BR_Encounter_DepartmentTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DEPARTMENTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV60ddo_BR_Encounter_ENCTypeTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV66ddo_BR_Encounter_AdmitDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ADMITDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV135ddo_BR_Encounter_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV157ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV160ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDRECHECKTITLECONTROLIDTOREPLACE',pic:''},{av:'AV163ddo_BR_Encounter_IsUpdateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISUPDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV243Pgmname',fld:'vPGMNAME',pic:''},{av:'AV137IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'Gridpaginationbar_Selectedpage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE",",oparms:[]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE","{handler:'E12142',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV221sBR_EncounterID',fld:'vSBR_ENCOUNTERID',pic:''},{av:'AV17BR_Information_PatientNo',fld:'vBR_INFORMATION_PATIENTNO',pic:''},{av:'cmbavBr_encounter_admitdateoperator'},{av:'AV120BR_Encounter_AdmitDateOperator',fld:'vBR_ENCOUNTER_ADMITDATEOPERATOR',pic:'ZZZ9'},{av:'AV122BR_Encounter_AdmitDate',fld:'vBR_ENCOUNTER_ADMITDATE',pic:''},{av:'AV121BR_Encounter_AdmitDate_To',fld:'vBR_ENCOUNTER_ADMITDATE_TO',pic:''},{av:'cmbavBr_encounter_status'},{av:'AV141BR_Encounter_Status',fld:'vBR_ENCOUNTER_STATUS',pic:'ZZZ9'},{av:'AV151BR_Encounter_IsRandApprove',fld:'vBR_ENCOUNTER_ISRANDAPPROVE',pic:''},{av:'AV152BR_Encounter_IsRandRecheck',fld:'vBR_ENCOUNTER_ISRANDRECHECK',pic:''},{av:'AV153BR_Encounter_IsUpdate',fld:'vBR_ENCOUNTER_ISUPDATE',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV48ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV86ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV56ddo_BR_Encounter_DepartmentTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DEPARTMENTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV60ddo_BR_Encounter_ENCTypeTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV66ddo_BR_Encounter_AdmitDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ADMITDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV135ddo_BR_Encounter_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV157ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV160ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDRECHECKTITLECONTROLIDTOREPLACE',pic:''},{av:'AV163ddo_BR_Encounter_IsUpdateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISUPDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV243Pgmname',fld:'vPGMNAME',pic:''},{av:'AV137IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'Gridpaginationbar_Rowsperpageselectedvalue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE",",oparms:[{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]}");
         setEventMetadata("DDO_BR_ENCOUNTERID.ONOPTIONCLICKED","{handler:'E13142',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV221sBR_EncounterID',fld:'vSBR_ENCOUNTERID',pic:''},{av:'AV17BR_Information_PatientNo',fld:'vBR_INFORMATION_PATIENTNO',pic:''},{av:'cmbavBr_encounter_admitdateoperator'},{av:'AV120BR_Encounter_AdmitDateOperator',fld:'vBR_ENCOUNTER_ADMITDATEOPERATOR',pic:'ZZZ9'},{av:'AV122BR_Encounter_AdmitDate',fld:'vBR_ENCOUNTER_ADMITDATE',pic:''},{av:'AV121BR_Encounter_AdmitDate_To',fld:'vBR_ENCOUNTER_ADMITDATE_TO',pic:''},{av:'cmbavBr_encounter_status'},{av:'AV141BR_Encounter_Status',fld:'vBR_ENCOUNTER_STATUS',pic:'ZZZ9'},{av:'AV151BR_Encounter_IsRandApprove',fld:'vBR_ENCOUNTER_ISRANDAPPROVE',pic:''},{av:'AV152BR_Encounter_IsRandRecheck',fld:'vBR_ENCOUNTER_ISRANDRECHECK',pic:''},{av:'AV153BR_Encounter_IsUpdate',fld:'vBR_ENCOUNTER_ISUPDATE',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV48ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV86ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV56ddo_BR_Encounter_DepartmentTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DEPARTMENTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV60ddo_BR_Encounter_ENCTypeTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV66ddo_BR_Encounter_AdmitDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ADMITDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV135ddo_BR_Encounter_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV157ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV160ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDRECHECKTITLECONTROLIDTOREPLACE',pic:''},{av:'AV163ddo_BR_Encounter_IsUpdateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISUPDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV243Pgmname',fld:'vPGMNAME',pic:''},{av:'AV137IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'Ddo_br_encounterid_Activeeventkey',ctrl:'DDO_BR_ENCOUNTERID',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_ENCOUNTERID.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_encounterid_Sortedstatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'AV223tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'AV137IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'AV231tAllBR_EncounterID',fld:'vTALLBR_ENCOUNTERID',pic:''},{av:'AV45BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV83BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV53BR_Encounter_DepartmentTitleFilterData',fld:'vBR_ENCOUNTER_DEPARTMENTTITLEFILTERDATA',pic:''},{av:'AV57BR_Encounter_ENCTypeTitleFilterData',fld:'vBR_ENCOUNTER_ENCTYPETITLEFILTERDATA',pic:''},{av:'AV61BR_Encounter_AdmitDateTitleFilterData',fld:'vBR_ENCOUNTER_ADMITDATETITLEFILTERDATA',pic:''},{av:'AV132BR_Encounter_StatusTitleFilterData',fld:'vBR_ENCOUNTER_STATUSTITLEFILTERDATA',pic:''},{av:'AV155BR_Encounter_IsRandApproveTitleFilterData',fld:'vBR_ENCOUNTER_ISRANDAPPROVETITLEFILTERDATA',pic:''},{av:'AV158BR_Encounter_IsRandRecheckTitleFilterData',fld:'vBR_ENCOUNTER_ISRANDRECHECKTITLEFILTERDATA',pic:''},{av:'AV161BR_Encounter_IsUpdateTitleFilterData',fld:'vBR_ENCOUNTER_ISUPDATETITLEFILTERDATA',pic:''},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Encounter_Department_Titleformat',ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Titleformat'},{av:'edtBR_Encounter_Department_Title',ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Title'},{av:'edtBR_Encounter_ENCType_Titleformat',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Titleformat'},{av:'edtBR_Encounter_ENCType_Title',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Title'},{av:'edtBR_Encounter_AdmitDate_Titleformat',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Titleformat'},{av:'edtBR_Encounter_AdmitDate_Title',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Title'},{av:'cmbBR_Encounter_Status'},{av:'chkBR_Encounter_IsRandApprove_Titleformat',ctrl:'BR_ENCOUNTER_ISRANDAPPROVE',prop:'Titleformat'},{av:'chkBR_Encounter_IsRandApprove.Title.Text',ctrl:'BR_ENCOUNTER_ISRANDAPPROVE',prop:'Title'},{av:'chkBR_Encounter_IsRandRecheck_Titleformat',ctrl:'BR_ENCOUNTER_ISRANDRECHECK',prop:'Titleformat'},{av:'chkBR_Encounter_IsRandRecheck.Title.Text',ctrl:'BR_ENCOUNTER_ISRANDRECHECK',prop:'Title'},{av:'chkBR_Encounter_IsUpdate_Titleformat',ctrl:'BR_ENCOUNTER_ISUPDATE',prop:'Titleformat'},{av:'chkBR_Encounter_IsUpdate.Title.Text',ctrl:'BR_ENCOUNTER_ISUPDATE',prop:'Title'},{av:'AV97GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV98GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV99GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'edtavDeleteencounter_Visible',ctrl:'vDELETEENCOUNTER',prop:'Visible'},{ctrl:'BTNBATCHAPPROVE',prop:'Visible'},{ctrl:'BTNBATCHRECHECK',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_INFORMATION_PATIENTNO.ONOPTIONCLICKED","{handler:'E14142',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV221sBR_EncounterID',fld:'vSBR_ENCOUNTERID',pic:''},{av:'AV17BR_Information_PatientNo',fld:'vBR_INFORMATION_PATIENTNO',pic:''},{av:'cmbavBr_encounter_admitdateoperator'},{av:'AV120BR_Encounter_AdmitDateOperator',fld:'vBR_ENCOUNTER_ADMITDATEOPERATOR',pic:'ZZZ9'},{av:'AV122BR_Encounter_AdmitDate',fld:'vBR_ENCOUNTER_ADMITDATE',pic:''},{av:'AV121BR_Encounter_AdmitDate_To',fld:'vBR_ENCOUNTER_ADMITDATE_TO',pic:''},{av:'cmbavBr_encounter_status'},{av:'AV141BR_Encounter_Status',fld:'vBR_ENCOUNTER_STATUS',pic:'ZZZ9'},{av:'AV151BR_Encounter_IsRandApprove',fld:'vBR_ENCOUNTER_ISRANDAPPROVE',pic:''},{av:'AV152BR_Encounter_IsRandRecheck',fld:'vBR_ENCOUNTER_ISRANDRECHECK',pic:''},{av:'AV153BR_Encounter_IsUpdate',fld:'vBR_ENCOUNTER_ISUPDATE',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV48ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV86ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV56ddo_BR_Encounter_DepartmentTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DEPARTMENTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV60ddo_BR_Encounter_ENCTypeTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV66ddo_BR_Encounter_AdmitDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ADMITDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV135ddo_BR_Encounter_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV157ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV160ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDRECHECKTITLECONTROLIDTOREPLACE',pic:''},{av:'AV163ddo_BR_Encounter_IsUpdateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISUPDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV243Pgmname',fld:'vPGMNAME',pic:''},{av:'AV137IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'Ddo_br_information_patientno_Activeeventkey',ctrl:'DDO_BR_INFORMATION_PATIENTNO',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_INFORMATION_PATIENTNO.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_information_patientno_Sortedstatus',ctrl:'DDO_BR_INFORMATION_PATIENTNO',prop:'SortedStatus'},{av:'AV223tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'AV137IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'AV231tAllBR_EncounterID',fld:'vTALLBR_ENCOUNTERID',pic:''},{av:'AV45BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV83BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV53BR_Encounter_DepartmentTitleFilterData',fld:'vBR_ENCOUNTER_DEPARTMENTTITLEFILTERDATA',pic:''},{av:'AV57BR_Encounter_ENCTypeTitleFilterData',fld:'vBR_ENCOUNTER_ENCTYPETITLEFILTERDATA',pic:''},{av:'AV61BR_Encounter_AdmitDateTitleFilterData',fld:'vBR_ENCOUNTER_ADMITDATETITLEFILTERDATA',pic:''},{av:'AV132BR_Encounter_StatusTitleFilterData',fld:'vBR_ENCOUNTER_STATUSTITLEFILTERDATA',pic:''},{av:'AV155BR_Encounter_IsRandApproveTitleFilterData',fld:'vBR_ENCOUNTER_ISRANDAPPROVETITLEFILTERDATA',pic:''},{av:'AV158BR_Encounter_IsRandRecheckTitleFilterData',fld:'vBR_ENCOUNTER_ISRANDRECHECKTITLEFILTERDATA',pic:''},{av:'AV161BR_Encounter_IsUpdateTitleFilterData',fld:'vBR_ENCOUNTER_ISUPDATETITLEFILTERDATA',pic:''},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Encounter_Department_Titleformat',ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Titleformat'},{av:'edtBR_Encounter_Department_Title',ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Title'},{av:'edtBR_Encounter_ENCType_Titleformat',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Titleformat'},{av:'edtBR_Encounter_ENCType_Title',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Title'},{av:'edtBR_Encounter_AdmitDate_Titleformat',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Titleformat'},{av:'edtBR_Encounter_AdmitDate_Title',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Title'},{av:'cmbBR_Encounter_Status'},{av:'chkBR_Encounter_IsRandApprove_Titleformat',ctrl:'BR_ENCOUNTER_ISRANDAPPROVE',prop:'Titleformat'},{av:'chkBR_Encounter_IsRandApprove.Title.Text',ctrl:'BR_ENCOUNTER_ISRANDAPPROVE',prop:'Title'},{av:'chkBR_Encounter_IsRandRecheck_Titleformat',ctrl:'BR_ENCOUNTER_ISRANDRECHECK',prop:'Titleformat'},{av:'chkBR_Encounter_IsRandRecheck.Title.Text',ctrl:'BR_ENCOUNTER_ISRANDRECHECK',prop:'Title'},{av:'chkBR_Encounter_IsUpdate_Titleformat',ctrl:'BR_ENCOUNTER_ISUPDATE',prop:'Titleformat'},{av:'chkBR_Encounter_IsUpdate.Title.Text',ctrl:'BR_ENCOUNTER_ISUPDATE',prop:'Title'},{av:'AV97GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV98GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV99GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'edtavDeleteencounter_Visible',ctrl:'vDELETEENCOUNTER',prop:'Visible'},{ctrl:'BTNBATCHAPPROVE',prop:'Visible'},{ctrl:'BTNBATCHRECHECK',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_ENCOUNTER_DEPARTMENT.ONOPTIONCLICKED","{handler:'E15142',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV221sBR_EncounterID',fld:'vSBR_ENCOUNTERID',pic:''},{av:'AV17BR_Information_PatientNo',fld:'vBR_INFORMATION_PATIENTNO',pic:''},{av:'cmbavBr_encounter_admitdateoperator'},{av:'AV120BR_Encounter_AdmitDateOperator',fld:'vBR_ENCOUNTER_ADMITDATEOPERATOR',pic:'ZZZ9'},{av:'AV122BR_Encounter_AdmitDate',fld:'vBR_ENCOUNTER_ADMITDATE',pic:''},{av:'AV121BR_Encounter_AdmitDate_To',fld:'vBR_ENCOUNTER_ADMITDATE_TO',pic:''},{av:'cmbavBr_encounter_status'},{av:'AV141BR_Encounter_Status',fld:'vBR_ENCOUNTER_STATUS',pic:'ZZZ9'},{av:'AV151BR_Encounter_IsRandApprove',fld:'vBR_ENCOUNTER_ISRANDAPPROVE',pic:''},{av:'AV152BR_Encounter_IsRandRecheck',fld:'vBR_ENCOUNTER_ISRANDRECHECK',pic:''},{av:'AV153BR_Encounter_IsUpdate',fld:'vBR_ENCOUNTER_ISUPDATE',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV48ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV86ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV56ddo_BR_Encounter_DepartmentTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DEPARTMENTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV60ddo_BR_Encounter_ENCTypeTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV66ddo_BR_Encounter_AdmitDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ADMITDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV135ddo_BR_Encounter_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV157ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV160ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDRECHECKTITLECONTROLIDTOREPLACE',pic:''},{av:'AV163ddo_BR_Encounter_IsUpdateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISUPDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV243Pgmname',fld:'vPGMNAME',pic:''},{av:'AV137IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'Ddo_br_encounter_department_Activeeventkey',ctrl:'DDO_BR_ENCOUNTER_DEPARTMENT',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_ENCOUNTER_DEPARTMENT.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_encounter_department_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_DEPARTMENT',prop:'SortedStatus'},{av:'AV223tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'AV137IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'AV231tAllBR_EncounterID',fld:'vTALLBR_ENCOUNTERID',pic:''},{av:'AV45BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV83BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV53BR_Encounter_DepartmentTitleFilterData',fld:'vBR_ENCOUNTER_DEPARTMENTTITLEFILTERDATA',pic:''},{av:'AV57BR_Encounter_ENCTypeTitleFilterData',fld:'vBR_ENCOUNTER_ENCTYPETITLEFILTERDATA',pic:''},{av:'AV61BR_Encounter_AdmitDateTitleFilterData',fld:'vBR_ENCOUNTER_ADMITDATETITLEFILTERDATA',pic:''},{av:'AV132BR_Encounter_StatusTitleFilterData',fld:'vBR_ENCOUNTER_STATUSTITLEFILTERDATA',pic:''},{av:'AV155BR_Encounter_IsRandApproveTitleFilterData',fld:'vBR_ENCOUNTER_ISRANDAPPROVETITLEFILTERDATA',pic:''},{av:'AV158BR_Encounter_IsRandRecheckTitleFilterData',fld:'vBR_ENCOUNTER_ISRANDRECHECKTITLEFILTERDATA',pic:''},{av:'AV161BR_Encounter_IsUpdateTitleFilterData',fld:'vBR_ENCOUNTER_ISUPDATETITLEFILTERDATA',pic:''},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Encounter_Department_Titleformat',ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Titleformat'},{av:'edtBR_Encounter_Department_Title',ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Title'},{av:'edtBR_Encounter_ENCType_Titleformat',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Titleformat'},{av:'edtBR_Encounter_ENCType_Title',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Title'},{av:'edtBR_Encounter_AdmitDate_Titleformat',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Titleformat'},{av:'edtBR_Encounter_AdmitDate_Title',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Title'},{av:'cmbBR_Encounter_Status'},{av:'chkBR_Encounter_IsRandApprove_Titleformat',ctrl:'BR_ENCOUNTER_ISRANDAPPROVE',prop:'Titleformat'},{av:'chkBR_Encounter_IsRandApprove.Title.Text',ctrl:'BR_ENCOUNTER_ISRANDAPPROVE',prop:'Title'},{av:'chkBR_Encounter_IsRandRecheck_Titleformat',ctrl:'BR_ENCOUNTER_ISRANDRECHECK',prop:'Titleformat'},{av:'chkBR_Encounter_IsRandRecheck.Title.Text',ctrl:'BR_ENCOUNTER_ISRANDRECHECK',prop:'Title'},{av:'chkBR_Encounter_IsUpdate_Titleformat',ctrl:'BR_ENCOUNTER_ISUPDATE',prop:'Titleformat'},{av:'chkBR_Encounter_IsUpdate.Title.Text',ctrl:'BR_ENCOUNTER_ISUPDATE',prop:'Title'},{av:'AV97GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV98GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV99GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'edtavDeleteencounter_Visible',ctrl:'vDELETEENCOUNTER',prop:'Visible'},{ctrl:'BTNBATCHAPPROVE',prop:'Visible'},{ctrl:'BTNBATCHRECHECK',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_ENCOUNTER_ENCTYPE.ONOPTIONCLICKED","{handler:'E16142',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV221sBR_EncounterID',fld:'vSBR_ENCOUNTERID',pic:''},{av:'AV17BR_Information_PatientNo',fld:'vBR_INFORMATION_PATIENTNO',pic:''},{av:'cmbavBr_encounter_admitdateoperator'},{av:'AV120BR_Encounter_AdmitDateOperator',fld:'vBR_ENCOUNTER_ADMITDATEOPERATOR',pic:'ZZZ9'},{av:'AV122BR_Encounter_AdmitDate',fld:'vBR_ENCOUNTER_ADMITDATE',pic:''},{av:'AV121BR_Encounter_AdmitDate_To',fld:'vBR_ENCOUNTER_ADMITDATE_TO',pic:''},{av:'cmbavBr_encounter_status'},{av:'AV141BR_Encounter_Status',fld:'vBR_ENCOUNTER_STATUS',pic:'ZZZ9'},{av:'AV151BR_Encounter_IsRandApprove',fld:'vBR_ENCOUNTER_ISRANDAPPROVE',pic:''},{av:'AV152BR_Encounter_IsRandRecheck',fld:'vBR_ENCOUNTER_ISRANDRECHECK',pic:''},{av:'AV153BR_Encounter_IsUpdate',fld:'vBR_ENCOUNTER_ISUPDATE',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV48ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV86ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV56ddo_BR_Encounter_DepartmentTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DEPARTMENTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV60ddo_BR_Encounter_ENCTypeTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV66ddo_BR_Encounter_AdmitDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ADMITDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV135ddo_BR_Encounter_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV157ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV160ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDRECHECKTITLECONTROLIDTOREPLACE',pic:''},{av:'AV163ddo_BR_Encounter_IsUpdateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISUPDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV243Pgmname',fld:'vPGMNAME',pic:''},{av:'AV137IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'Ddo_br_encounter_enctype_Activeeventkey',ctrl:'DDO_BR_ENCOUNTER_ENCTYPE',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_ENCOUNTER_ENCTYPE.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_encounter_enctype_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_ENCTYPE',prop:'SortedStatus'},{av:'AV223tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'AV137IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'AV231tAllBR_EncounterID',fld:'vTALLBR_ENCOUNTERID',pic:''},{av:'AV45BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV83BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV53BR_Encounter_DepartmentTitleFilterData',fld:'vBR_ENCOUNTER_DEPARTMENTTITLEFILTERDATA',pic:''},{av:'AV57BR_Encounter_ENCTypeTitleFilterData',fld:'vBR_ENCOUNTER_ENCTYPETITLEFILTERDATA',pic:''},{av:'AV61BR_Encounter_AdmitDateTitleFilterData',fld:'vBR_ENCOUNTER_ADMITDATETITLEFILTERDATA',pic:''},{av:'AV132BR_Encounter_StatusTitleFilterData',fld:'vBR_ENCOUNTER_STATUSTITLEFILTERDATA',pic:''},{av:'AV155BR_Encounter_IsRandApproveTitleFilterData',fld:'vBR_ENCOUNTER_ISRANDAPPROVETITLEFILTERDATA',pic:''},{av:'AV158BR_Encounter_IsRandRecheckTitleFilterData',fld:'vBR_ENCOUNTER_ISRANDRECHECKTITLEFILTERDATA',pic:''},{av:'AV161BR_Encounter_IsUpdateTitleFilterData',fld:'vBR_ENCOUNTER_ISUPDATETITLEFILTERDATA',pic:''},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Encounter_Department_Titleformat',ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Titleformat'},{av:'edtBR_Encounter_Department_Title',ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Title'},{av:'edtBR_Encounter_ENCType_Titleformat',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Titleformat'},{av:'edtBR_Encounter_ENCType_Title',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Title'},{av:'edtBR_Encounter_AdmitDate_Titleformat',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Titleformat'},{av:'edtBR_Encounter_AdmitDate_Title',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Title'},{av:'cmbBR_Encounter_Status'},{av:'chkBR_Encounter_IsRandApprove_Titleformat',ctrl:'BR_ENCOUNTER_ISRANDAPPROVE',prop:'Titleformat'},{av:'chkBR_Encounter_IsRandApprove.Title.Text',ctrl:'BR_ENCOUNTER_ISRANDAPPROVE',prop:'Title'},{av:'chkBR_Encounter_IsRandRecheck_Titleformat',ctrl:'BR_ENCOUNTER_ISRANDRECHECK',prop:'Titleformat'},{av:'chkBR_Encounter_IsRandRecheck.Title.Text',ctrl:'BR_ENCOUNTER_ISRANDRECHECK',prop:'Title'},{av:'chkBR_Encounter_IsUpdate_Titleformat',ctrl:'BR_ENCOUNTER_ISUPDATE',prop:'Titleformat'},{av:'chkBR_Encounter_IsUpdate.Title.Text',ctrl:'BR_ENCOUNTER_ISUPDATE',prop:'Title'},{av:'AV97GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV98GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV99GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'edtavDeleteencounter_Visible',ctrl:'vDELETEENCOUNTER',prop:'Visible'},{ctrl:'BTNBATCHAPPROVE',prop:'Visible'},{ctrl:'BTNBATCHRECHECK',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_ENCOUNTER_ADMITDATE.ONOPTIONCLICKED","{handler:'E17142',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV221sBR_EncounterID',fld:'vSBR_ENCOUNTERID',pic:''},{av:'AV17BR_Information_PatientNo',fld:'vBR_INFORMATION_PATIENTNO',pic:''},{av:'cmbavBr_encounter_admitdateoperator'},{av:'AV120BR_Encounter_AdmitDateOperator',fld:'vBR_ENCOUNTER_ADMITDATEOPERATOR',pic:'ZZZ9'},{av:'AV122BR_Encounter_AdmitDate',fld:'vBR_ENCOUNTER_ADMITDATE',pic:''},{av:'AV121BR_Encounter_AdmitDate_To',fld:'vBR_ENCOUNTER_ADMITDATE_TO',pic:''},{av:'cmbavBr_encounter_status'},{av:'AV141BR_Encounter_Status',fld:'vBR_ENCOUNTER_STATUS',pic:'ZZZ9'},{av:'AV151BR_Encounter_IsRandApprove',fld:'vBR_ENCOUNTER_ISRANDAPPROVE',pic:''},{av:'AV152BR_Encounter_IsRandRecheck',fld:'vBR_ENCOUNTER_ISRANDRECHECK',pic:''},{av:'AV153BR_Encounter_IsUpdate',fld:'vBR_ENCOUNTER_ISUPDATE',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV48ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV86ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV56ddo_BR_Encounter_DepartmentTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DEPARTMENTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV60ddo_BR_Encounter_ENCTypeTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV66ddo_BR_Encounter_AdmitDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ADMITDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV135ddo_BR_Encounter_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV157ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV160ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDRECHECKTITLECONTROLIDTOREPLACE',pic:''},{av:'AV163ddo_BR_Encounter_IsUpdateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISUPDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV243Pgmname',fld:'vPGMNAME',pic:''},{av:'AV137IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'Ddo_br_encounter_admitdate_Activeeventkey',ctrl:'DDO_BR_ENCOUNTER_ADMITDATE',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_ENCOUNTER_ADMITDATE.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_encounter_admitdate_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_ADMITDATE',prop:'SortedStatus'},{av:'AV223tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'AV137IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'AV231tAllBR_EncounterID',fld:'vTALLBR_ENCOUNTERID',pic:''},{av:'AV45BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV83BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV53BR_Encounter_DepartmentTitleFilterData',fld:'vBR_ENCOUNTER_DEPARTMENTTITLEFILTERDATA',pic:''},{av:'AV57BR_Encounter_ENCTypeTitleFilterData',fld:'vBR_ENCOUNTER_ENCTYPETITLEFILTERDATA',pic:''},{av:'AV61BR_Encounter_AdmitDateTitleFilterData',fld:'vBR_ENCOUNTER_ADMITDATETITLEFILTERDATA',pic:''},{av:'AV132BR_Encounter_StatusTitleFilterData',fld:'vBR_ENCOUNTER_STATUSTITLEFILTERDATA',pic:''},{av:'AV155BR_Encounter_IsRandApproveTitleFilterData',fld:'vBR_ENCOUNTER_ISRANDAPPROVETITLEFILTERDATA',pic:''},{av:'AV158BR_Encounter_IsRandRecheckTitleFilterData',fld:'vBR_ENCOUNTER_ISRANDRECHECKTITLEFILTERDATA',pic:''},{av:'AV161BR_Encounter_IsUpdateTitleFilterData',fld:'vBR_ENCOUNTER_ISUPDATETITLEFILTERDATA',pic:''},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Encounter_Department_Titleformat',ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Titleformat'},{av:'edtBR_Encounter_Department_Title',ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Title'},{av:'edtBR_Encounter_ENCType_Titleformat',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Titleformat'},{av:'edtBR_Encounter_ENCType_Title',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Title'},{av:'edtBR_Encounter_AdmitDate_Titleformat',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Titleformat'},{av:'edtBR_Encounter_AdmitDate_Title',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Title'},{av:'cmbBR_Encounter_Status'},{av:'chkBR_Encounter_IsRandApprove_Titleformat',ctrl:'BR_ENCOUNTER_ISRANDAPPROVE',prop:'Titleformat'},{av:'chkBR_Encounter_IsRandApprove.Title.Text',ctrl:'BR_ENCOUNTER_ISRANDAPPROVE',prop:'Title'},{av:'chkBR_Encounter_IsRandRecheck_Titleformat',ctrl:'BR_ENCOUNTER_ISRANDRECHECK',prop:'Titleformat'},{av:'chkBR_Encounter_IsRandRecheck.Title.Text',ctrl:'BR_ENCOUNTER_ISRANDRECHECK',prop:'Title'},{av:'chkBR_Encounter_IsUpdate_Titleformat',ctrl:'BR_ENCOUNTER_ISUPDATE',prop:'Titleformat'},{av:'chkBR_Encounter_IsUpdate.Title.Text',ctrl:'BR_ENCOUNTER_ISUPDATE',prop:'Title'},{av:'AV97GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV98GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV99GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'edtavDeleteencounter_Visible',ctrl:'vDELETEENCOUNTER',prop:'Visible'},{ctrl:'BTNBATCHAPPROVE',prop:'Visible'},{ctrl:'BTNBATCHRECHECK',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_ENCOUNTER_STATUS.ONOPTIONCLICKED","{handler:'E18142',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV221sBR_EncounterID',fld:'vSBR_ENCOUNTERID',pic:''},{av:'AV17BR_Information_PatientNo',fld:'vBR_INFORMATION_PATIENTNO',pic:''},{av:'cmbavBr_encounter_admitdateoperator'},{av:'AV120BR_Encounter_AdmitDateOperator',fld:'vBR_ENCOUNTER_ADMITDATEOPERATOR',pic:'ZZZ9'},{av:'AV122BR_Encounter_AdmitDate',fld:'vBR_ENCOUNTER_ADMITDATE',pic:''},{av:'AV121BR_Encounter_AdmitDate_To',fld:'vBR_ENCOUNTER_ADMITDATE_TO',pic:''},{av:'cmbavBr_encounter_status'},{av:'AV141BR_Encounter_Status',fld:'vBR_ENCOUNTER_STATUS',pic:'ZZZ9'},{av:'AV151BR_Encounter_IsRandApprove',fld:'vBR_ENCOUNTER_ISRANDAPPROVE',pic:''},{av:'AV152BR_Encounter_IsRandRecheck',fld:'vBR_ENCOUNTER_ISRANDRECHECK',pic:''},{av:'AV153BR_Encounter_IsUpdate',fld:'vBR_ENCOUNTER_ISUPDATE',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV48ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV86ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV56ddo_BR_Encounter_DepartmentTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DEPARTMENTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV60ddo_BR_Encounter_ENCTypeTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV66ddo_BR_Encounter_AdmitDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ADMITDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV135ddo_BR_Encounter_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV157ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV160ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDRECHECKTITLECONTROLIDTOREPLACE',pic:''},{av:'AV163ddo_BR_Encounter_IsUpdateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISUPDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV243Pgmname',fld:'vPGMNAME',pic:''},{av:'AV137IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'Ddo_br_encounter_status_Activeeventkey',ctrl:'DDO_BR_ENCOUNTER_STATUS',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_ENCOUNTER_STATUS.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_encounter_status_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_STATUS',prop:'SortedStatus'},{av:'AV223tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'AV137IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'AV231tAllBR_EncounterID',fld:'vTALLBR_ENCOUNTERID',pic:''},{av:'AV45BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV83BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV53BR_Encounter_DepartmentTitleFilterData',fld:'vBR_ENCOUNTER_DEPARTMENTTITLEFILTERDATA',pic:''},{av:'AV57BR_Encounter_ENCTypeTitleFilterData',fld:'vBR_ENCOUNTER_ENCTYPETITLEFILTERDATA',pic:''},{av:'AV61BR_Encounter_AdmitDateTitleFilterData',fld:'vBR_ENCOUNTER_ADMITDATETITLEFILTERDATA',pic:''},{av:'AV132BR_Encounter_StatusTitleFilterData',fld:'vBR_ENCOUNTER_STATUSTITLEFILTERDATA',pic:''},{av:'AV155BR_Encounter_IsRandApproveTitleFilterData',fld:'vBR_ENCOUNTER_ISRANDAPPROVETITLEFILTERDATA',pic:''},{av:'AV158BR_Encounter_IsRandRecheckTitleFilterData',fld:'vBR_ENCOUNTER_ISRANDRECHECKTITLEFILTERDATA',pic:''},{av:'AV161BR_Encounter_IsUpdateTitleFilterData',fld:'vBR_ENCOUNTER_ISUPDATETITLEFILTERDATA',pic:''},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Encounter_Department_Titleformat',ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Titleformat'},{av:'edtBR_Encounter_Department_Title',ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Title'},{av:'edtBR_Encounter_ENCType_Titleformat',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Titleformat'},{av:'edtBR_Encounter_ENCType_Title',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Title'},{av:'edtBR_Encounter_AdmitDate_Titleformat',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Titleformat'},{av:'edtBR_Encounter_AdmitDate_Title',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Title'},{av:'cmbBR_Encounter_Status'},{av:'chkBR_Encounter_IsRandApprove_Titleformat',ctrl:'BR_ENCOUNTER_ISRANDAPPROVE',prop:'Titleformat'},{av:'chkBR_Encounter_IsRandApprove.Title.Text',ctrl:'BR_ENCOUNTER_ISRANDAPPROVE',prop:'Title'},{av:'chkBR_Encounter_IsRandRecheck_Titleformat',ctrl:'BR_ENCOUNTER_ISRANDRECHECK',prop:'Titleformat'},{av:'chkBR_Encounter_IsRandRecheck.Title.Text',ctrl:'BR_ENCOUNTER_ISRANDRECHECK',prop:'Title'},{av:'chkBR_Encounter_IsUpdate_Titleformat',ctrl:'BR_ENCOUNTER_ISUPDATE',prop:'Titleformat'},{av:'chkBR_Encounter_IsUpdate.Title.Text',ctrl:'BR_ENCOUNTER_ISUPDATE',prop:'Title'},{av:'AV97GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV98GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV99GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'edtavDeleteencounter_Visible',ctrl:'vDELETEENCOUNTER',prop:'Visible'},{ctrl:'BTNBATCHAPPROVE',prop:'Visible'},{ctrl:'BTNBATCHRECHECK',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_ENCOUNTER_ISRANDAPPROVE.ONOPTIONCLICKED","{handler:'E19142',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV221sBR_EncounterID',fld:'vSBR_ENCOUNTERID',pic:''},{av:'AV17BR_Information_PatientNo',fld:'vBR_INFORMATION_PATIENTNO',pic:''},{av:'cmbavBr_encounter_admitdateoperator'},{av:'AV120BR_Encounter_AdmitDateOperator',fld:'vBR_ENCOUNTER_ADMITDATEOPERATOR',pic:'ZZZ9'},{av:'AV122BR_Encounter_AdmitDate',fld:'vBR_ENCOUNTER_ADMITDATE',pic:''},{av:'AV121BR_Encounter_AdmitDate_To',fld:'vBR_ENCOUNTER_ADMITDATE_TO',pic:''},{av:'cmbavBr_encounter_status'},{av:'AV141BR_Encounter_Status',fld:'vBR_ENCOUNTER_STATUS',pic:'ZZZ9'},{av:'AV151BR_Encounter_IsRandApprove',fld:'vBR_ENCOUNTER_ISRANDAPPROVE',pic:''},{av:'AV152BR_Encounter_IsRandRecheck',fld:'vBR_ENCOUNTER_ISRANDRECHECK',pic:''},{av:'AV153BR_Encounter_IsUpdate',fld:'vBR_ENCOUNTER_ISUPDATE',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV48ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV86ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV56ddo_BR_Encounter_DepartmentTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DEPARTMENTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV60ddo_BR_Encounter_ENCTypeTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV66ddo_BR_Encounter_AdmitDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ADMITDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV135ddo_BR_Encounter_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV157ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV160ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDRECHECKTITLECONTROLIDTOREPLACE',pic:''},{av:'AV163ddo_BR_Encounter_IsUpdateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISUPDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV243Pgmname',fld:'vPGMNAME',pic:''},{av:'AV137IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'Ddo_br_encounter_israndapprove_Activeeventkey',ctrl:'DDO_BR_ENCOUNTER_ISRANDAPPROVE',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_ENCOUNTER_ISRANDAPPROVE.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_encounter_israndapprove_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_ISRANDAPPROVE',prop:'SortedStatus'},{av:'AV223tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'AV137IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'AV231tAllBR_EncounterID',fld:'vTALLBR_ENCOUNTERID',pic:''},{av:'AV45BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV83BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV53BR_Encounter_DepartmentTitleFilterData',fld:'vBR_ENCOUNTER_DEPARTMENTTITLEFILTERDATA',pic:''},{av:'AV57BR_Encounter_ENCTypeTitleFilterData',fld:'vBR_ENCOUNTER_ENCTYPETITLEFILTERDATA',pic:''},{av:'AV61BR_Encounter_AdmitDateTitleFilterData',fld:'vBR_ENCOUNTER_ADMITDATETITLEFILTERDATA',pic:''},{av:'AV132BR_Encounter_StatusTitleFilterData',fld:'vBR_ENCOUNTER_STATUSTITLEFILTERDATA',pic:''},{av:'AV155BR_Encounter_IsRandApproveTitleFilterData',fld:'vBR_ENCOUNTER_ISRANDAPPROVETITLEFILTERDATA',pic:''},{av:'AV158BR_Encounter_IsRandRecheckTitleFilterData',fld:'vBR_ENCOUNTER_ISRANDRECHECKTITLEFILTERDATA',pic:''},{av:'AV161BR_Encounter_IsUpdateTitleFilterData',fld:'vBR_ENCOUNTER_ISUPDATETITLEFILTERDATA',pic:''},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Encounter_Department_Titleformat',ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Titleformat'},{av:'edtBR_Encounter_Department_Title',ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Title'},{av:'edtBR_Encounter_ENCType_Titleformat',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Titleformat'},{av:'edtBR_Encounter_ENCType_Title',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Title'},{av:'edtBR_Encounter_AdmitDate_Titleformat',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Titleformat'},{av:'edtBR_Encounter_AdmitDate_Title',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Title'},{av:'cmbBR_Encounter_Status'},{av:'chkBR_Encounter_IsRandApprove_Titleformat',ctrl:'BR_ENCOUNTER_ISRANDAPPROVE',prop:'Titleformat'},{av:'chkBR_Encounter_IsRandApprove.Title.Text',ctrl:'BR_ENCOUNTER_ISRANDAPPROVE',prop:'Title'},{av:'chkBR_Encounter_IsRandRecheck_Titleformat',ctrl:'BR_ENCOUNTER_ISRANDRECHECK',prop:'Titleformat'},{av:'chkBR_Encounter_IsRandRecheck.Title.Text',ctrl:'BR_ENCOUNTER_ISRANDRECHECK',prop:'Title'},{av:'chkBR_Encounter_IsUpdate_Titleformat',ctrl:'BR_ENCOUNTER_ISUPDATE',prop:'Titleformat'},{av:'chkBR_Encounter_IsUpdate.Title.Text',ctrl:'BR_ENCOUNTER_ISUPDATE',prop:'Title'},{av:'AV97GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV98GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV99GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'edtavDeleteencounter_Visible',ctrl:'vDELETEENCOUNTER',prop:'Visible'},{ctrl:'BTNBATCHAPPROVE',prop:'Visible'},{ctrl:'BTNBATCHRECHECK',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_ENCOUNTER_ISRANDRECHECK.ONOPTIONCLICKED","{handler:'E20142',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV221sBR_EncounterID',fld:'vSBR_ENCOUNTERID',pic:''},{av:'AV17BR_Information_PatientNo',fld:'vBR_INFORMATION_PATIENTNO',pic:''},{av:'cmbavBr_encounter_admitdateoperator'},{av:'AV120BR_Encounter_AdmitDateOperator',fld:'vBR_ENCOUNTER_ADMITDATEOPERATOR',pic:'ZZZ9'},{av:'AV122BR_Encounter_AdmitDate',fld:'vBR_ENCOUNTER_ADMITDATE',pic:''},{av:'AV121BR_Encounter_AdmitDate_To',fld:'vBR_ENCOUNTER_ADMITDATE_TO',pic:''},{av:'cmbavBr_encounter_status'},{av:'AV141BR_Encounter_Status',fld:'vBR_ENCOUNTER_STATUS',pic:'ZZZ9'},{av:'AV151BR_Encounter_IsRandApprove',fld:'vBR_ENCOUNTER_ISRANDAPPROVE',pic:''},{av:'AV152BR_Encounter_IsRandRecheck',fld:'vBR_ENCOUNTER_ISRANDRECHECK',pic:''},{av:'AV153BR_Encounter_IsUpdate',fld:'vBR_ENCOUNTER_ISUPDATE',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV48ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV86ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV56ddo_BR_Encounter_DepartmentTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DEPARTMENTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV60ddo_BR_Encounter_ENCTypeTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV66ddo_BR_Encounter_AdmitDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ADMITDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV135ddo_BR_Encounter_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV157ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV160ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDRECHECKTITLECONTROLIDTOREPLACE',pic:''},{av:'AV163ddo_BR_Encounter_IsUpdateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISUPDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV243Pgmname',fld:'vPGMNAME',pic:''},{av:'AV137IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'Ddo_br_encounter_israndrecheck_Activeeventkey',ctrl:'DDO_BR_ENCOUNTER_ISRANDRECHECK',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_ENCOUNTER_ISRANDRECHECK.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_encounter_israndrecheck_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_ISRANDRECHECK',prop:'SortedStatus'},{av:'AV223tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'AV137IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'AV231tAllBR_EncounterID',fld:'vTALLBR_ENCOUNTERID',pic:''},{av:'AV45BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV83BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV53BR_Encounter_DepartmentTitleFilterData',fld:'vBR_ENCOUNTER_DEPARTMENTTITLEFILTERDATA',pic:''},{av:'AV57BR_Encounter_ENCTypeTitleFilterData',fld:'vBR_ENCOUNTER_ENCTYPETITLEFILTERDATA',pic:''},{av:'AV61BR_Encounter_AdmitDateTitleFilterData',fld:'vBR_ENCOUNTER_ADMITDATETITLEFILTERDATA',pic:''},{av:'AV132BR_Encounter_StatusTitleFilterData',fld:'vBR_ENCOUNTER_STATUSTITLEFILTERDATA',pic:''},{av:'AV155BR_Encounter_IsRandApproveTitleFilterData',fld:'vBR_ENCOUNTER_ISRANDAPPROVETITLEFILTERDATA',pic:''},{av:'AV158BR_Encounter_IsRandRecheckTitleFilterData',fld:'vBR_ENCOUNTER_ISRANDRECHECKTITLEFILTERDATA',pic:''},{av:'AV161BR_Encounter_IsUpdateTitleFilterData',fld:'vBR_ENCOUNTER_ISUPDATETITLEFILTERDATA',pic:''},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Encounter_Department_Titleformat',ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Titleformat'},{av:'edtBR_Encounter_Department_Title',ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Title'},{av:'edtBR_Encounter_ENCType_Titleformat',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Titleformat'},{av:'edtBR_Encounter_ENCType_Title',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Title'},{av:'edtBR_Encounter_AdmitDate_Titleformat',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Titleformat'},{av:'edtBR_Encounter_AdmitDate_Title',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Title'},{av:'cmbBR_Encounter_Status'},{av:'chkBR_Encounter_IsRandApprove_Titleformat',ctrl:'BR_ENCOUNTER_ISRANDAPPROVE',prop:'Titleformat'},{av:'chkBR_Encounter_IsRandApprove.Title.Text',ctrl:'BR_ENCOUNTER_ISRANDAPPROVE',prop:'Title'},{av:'chkBR_Encounter_IsRandRecheck_Titleformat',ctrl:'BR_ENCOUNTER_ISRANDRECHECK',prop:'Titleformat'},{av:'chkBR_Encounter_IsRandRecheck.Title.Text',ctrl:'BR_ENCOUNTER_ISRANDRECHECK',prop:'Title'},{av:'chkBR_Encounter_IsUpdate_Titleformat',ctrl:'BR_ENCOUNTER_ISUPDATE',prop:'Titleformat'},{av:'chkBR_Encounter_IsUpdate.Title.Text',ctrl:'BR_ENCOUNTER_ISUPDATE',prop:'Title'},{av:'AV97GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV98GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV99GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'edtavDeleteencounter_Visible',ctrl:'vDELETEENCOUNTER',prop:'Visible'},{ctrl:'BTNBATCHAPPROVE',prop:'Visible'},{ctrl:'BTNBATCHRECHECK',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_ENCOUNTER_ISUPDATE.ONOPTIONCLICKED","{handler:'E21142',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV221sBR_EncounterID',fld:'vSBR_ENCOUNTERID',pic:''},{av:'AV17BR_Information_PatientNo',fld:'vBR_INFORMATION_PATIENTNO',pic:''},{av:'cmbavBr_encounter_admitdateoperator'},{av:'AV120BR_Encounter_AdmitDateOperator',fld:'vBR_ENCOUNTER_ADMITDATEOPERATOR',pic:'ZZZ9'},{av:'AV122BR_Encounter_AdmitDate',fld:'vBR_ENCOUNTER_ADMITDATE',pic:''},{av:'AV121BR_Encounter_AdmitDate_To',fld:'vBR_ENCOUNTER_ADMITDATE_TO',pic:''},{av:'cmbavBr_encounter_status'},{av:'AV141BR_Encounter_Status',fld:'vBR_ENCOUNTER_STATUS',pic:'ZZZ9'},{av:'AV151BR_Encounter_IsRandApprove',fld:'vBR_ENCOUNTER_ISRANDAPPROVE',pic:''},{av:'AV152BR_Encounter_IsRandRecheck',fld:'vBR_ENCOUNTER_ISRANDRECHECK',pic:''},{av:'AV153BR_Encounter_IsUpdate',fld:'vBR_ENCOUNTER_ISUPDATE',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV48ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV86ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV56ddo_BR_Encounter_DepartmentTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DEPARTMENTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV60ddo_BR_Encounter_ENCTypeTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV66ddo_BR_Encounter_AdmitDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ADMITDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV135ddo_BR_Encounter_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV157ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV160ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDRECHECKTITLECONTROLIDTOREPLACE',pic:''},{av:'AV163ddo_BR_Encounter_IsUpdateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISUPDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV243Pgmname',fld:'vPGMNAME',pic:''},{av:'AV137IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'Ddo_br_encounter_isupdate_Activeeventkey',ctrl:'DDO_BR_ENCOUNTER_ISUPDATE',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_ENCOUNTER_ISUPDATE.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_encounter_isupdate_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_ISUPDATE',prop:'SortedStatus'},{av:'AV223tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'AV137IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'AV231tAllBR_EncounterID',fld:'vTALLBR_ENCOUNTERID',pic:''},{av:'AV45BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV83BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV53BR_Encounter_DepartmentTitleFilterData',fld:'vBR_ENCOUNTER_DEPARTMENTTITLEFILTERDATA',pic:''},{av:'AV57BR_Encounter_ENCTypeTitleFilterData',fld:'vBR_ENCOUNTER_ENCTYPETITLEFILTERDATA',pic:''},{av:'AV61BR_Encounter_AdmitDateTitleFilterData',fld:'vBR_ENCOUNTER_ADMITDATETITLEFILTERDATA',pic:''},{av:'AV132BR_Encounter_StatusTitleFilterData',fld:'vBR_ENCOUNTER_STATUSTITLEFILTERDATA',pic:''},{av:'AV155BR_Encounter_IsRandApproveTitleFilterData',fld:'vBR_ENCOUNTER_ISRANDAPPROVETITLEFILTERDATA',pic:''},{av:'AV158BR_Encounter_IsRandRecheckTitleFilterData',fld:'vBR_ENCOUNTER_ISRANDRECHECKTITLEFILTERDATA',pic:''},{av:'AV161BR_Encounter_IsUpdateTitleFilterData',fld:'vBR_ENCOUNTER_ISUPDATETITLEFILTERDATA',pic:''},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Encounter_Department_Titleformat',ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Titleformat'},{av:'edtBR_Encounter_Department_Title',ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Title'},{av:'edtBR_Encounter_ENCType_Titleformat',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Titleformat'},{av:'edtBR_Encounter_ENCType_Title',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Title'},{av:'edtBR_Encounter_AdmitDate_Titleformat',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Titleformat'},{av:'edtBR_Encounter_AdmitDate_Title',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Title'},{av:'cmbBR_Encounter_Status'},{av:'chkBR_Encounter_IsRandApprove_Titleformat',ctrl:'BR_ENCOUNTER_ISRANDAPPROVE',prop:'Titleformat'},{av:'chkBR_Encounter_IsRandApprove.Title.Text',ctrl:'BR_ENCOUNTER_ISRANDAPPROVE',prop:'Title'},{av:'chkBR_Encounter_IsRandRecheck_Titleformat',ctrl:'BR_ENCOUNTER_ISRANDRECHECK',prop:'Titleformat'},{av:'chkBR_Encounter_IsRandRecheck.Title.Text',ctrl:'BR_ENCOUNTER_ISRANDRECHECK',prop:'Title'},{av:'chkBR_Encounter_IsUpdate_Titleformat',ctrl:'BR_ENCOUNTER_ISUPDATE',prop:'Titleformat'},{av:'chkBR_Encounter_IsUpdate.Title.Text',ctrl:'BR_ENCOUNTER_ISUPDATE',prop:'Title'},{av:'AV97GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV98GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV99GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'edtavDeleteencounter_Visible',ctrl:'vDELETEENCOUNTER',prop:'Visible'},{ctrl:'BTNBATCHAPPROVE',prop:'Visible'},{ctrl:'BTNBATCHRECHECK',prop:'Visible'}]}");
         setEventMetadata("GRID.LOAD","{handler:'E28142',iparms:[]");
         setEventMetadata("GRID.LOAD",",oparms:[{av:'AV164deleteEncounter',fld:'vDELETEENCOUNTER',pic:''},{av:'edtavDeleteencounter_Tooltiptext',ctrl:'vDELETEENCOUNTER',prop:'Tooltiptext'}]}");
         setEventMetadata("'DODELETEENCOUNTER'","{handler:'E34142',iparms:[{av:'A19BR_EncounterID',fld:'BR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
         setEventMetadata("'DODELETEENCOUNTER'",",oparms:[{av:'AV165BR_EncounterID_Selected',fld:'vBR_ENCOUNTERID_SELECTED',pic:'ZZZZZZZZZZZZZZZZZZ'}]}");
         setEventMetadata("DVELOP_CONFIRMPANEL_DELETEENCOUNTER.CLOSE","{handler:'E22142',iparms:[{av:'Dvelop_confirmpanel_deleteencounter_Result',ctrl:'DVELOP_CONFIRMPANEL_DELETEENCOUNTER',prop:'Result'},{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV221sBR_EncounterID',fld:'vSBR_ENCOUNTERID',pic:''},{av:'AV17BR_Information_PatientNo',fld:'vBR_INFORMATION_PATIENTNO',pic:''},{av:'cmbavBr_encounter_admitdateoperator'},{av:'AV120BR_Encounter_AdmitDateOperator',fld:'vBR_ENCOUNTER_ADMITDATEOPERATOR',pic:'ZZZ9'},{av:'AV122BR_Encounter_AdmitDate',fld:'vBR_ENCOUNTER_ADMITDATE',pic:''},{av:'AV121BR_Encounter_AdmitDate_To',fld:'vBR_ENCOUNTER_ADMITDATE_TO',pic:''},{av:'cmbavBr_encounter_status'},{av:'AV141BR_Encounter_Status',fld:'vBR_ENCOUNTER_STATUS',pic:'ZZZ9'},{av:'AV151BR_Encounter_IsRandApprove',fld:'vBR_ENCOUNTER_ISRANDAPPROVE',pic:''},{av:'AV152BR_Encounter_IsRandRecheck',fld:'vBR_ENCOUNTER_ISRANDRECHECK',pic:''},{av:'AV153BR_Encounter_IsUpdate',fld:'vBR_ENCOUNTER_ISUPDATE',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV48ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV86ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV56ddo_BR_Encounter_DepartmentTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DEPARTMENTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV60ddo_BR_Encounter_ENCTypeTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV66ddo_BR_Encounter_AdmitDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ADMITDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV135ddo_BR_Encounter_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV157ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV160ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDRECHECKTITLECONTROLIDTOREPLACE',pic:''},{av:'AV163ddo_BR_Encounter_IsUpdateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISUPDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV243Pgmname',fld:'vPGMNAME',pic:''},{av:'AV137IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'A19BR_EncounterID',fld:'BR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
         setEventMetadata("DVELOP_CONFIRMPANEL_DELETEENCOUNTER.CLOSE",",oparms:[{av:'AV223tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'AV137IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'AV231tAllBR_EncounterID',fld:'vTALLBR_ENCOUNTERID',pic:''},{av:'AV45BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV83BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV53BR_Encounter_DepartmentTitleFilterData',fld:'vBR_ENCOUNTER_DEPARTMENTTITLEFILTERDATA',pic:''},{av:'AV57BR_Encounter_ENCTypeTitleFilterData',fld:'vBR_ENCOUNTER_ENCTYPETITLEFILTERDATA',pic:''},{av:'AV61BR_Encounter_AdmitDateTitleFilterData',fld:'vBR_ENCOUNTER_ADMITDATETITLEFILTERDATA',pic:''},{av:'AV132BR_Encounter_StatusTitleFilterData',fld:'vBR_ENCOUNTER_STATUSTITLEFILTERDATA',pic:''},{av:'AV155BR_Encounter_IsRandApproveTitleFilterData',fld:'vBR_ENCOUNTER_ISRANDAPPROVETITLEFILTERDATA',pic:''},{av:'AV158BR_Encounter_IsRandRecheckTitleFilterData',fld:'vBR_ENCOUNTER_ISRANDRECHECKTITLEFILTERDATA',pic:''},{av:'AV161BR_Encounter_IsUpdateTitleFilterData',fld:'vBR_ENCOUNTER_ISUPDATETITLEFILTERDATA',pic:''},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Encounter_Department_Titleformat',ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Titleformat'},{av:'edtBR_Encounter_Department_Title',ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Title'},{av:'edtBR_Encounter_ENCType_Titleformat',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Titleformat'},{av:'edtBR_Encounter_ENCType_Title',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Title'},{av:'edtBR_Encounter_AdmitDate_Titleformat',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Titleformat'},{av:'edtBR_Encounter_AdmitDate_Title',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Title'},{av:'cmbBR_Encounter_Status'},{av:'chkBR_Encounter_IsRandApprove_Titleformat',ctrl:'BR_ENCOUNTER_ISRANDAPPROVE',prop:'Titleformat'},{av:'chkBR_Encounter_IsRandApprove.Title.Text',ctrl:'BR_ENCOUNTER_ISRANDAPPROVE',prop:'Title'},{av:'chkBR_Encounter_IsRandRecheck_Titleformat',ctrl:'BR_ENCOUNTER_ISRANDRECHECK',prop:'Titleformat'},{av:'chkBR_Encounter_IsRandRecheck.Title.Text',ctrl:'BR_ENCOUNTER_ISRANDRECHECK',prop:'Title'},{av:'chkBR_Encounter_IsUpdate_Titleformat',ctrl:'BR_ENCOUNTER_ISUPDATE',prop:'Titleformat'},{av:'chkBR_Encounter_IsUpdate.Title.Text',ctrl:'BR_ENCOUNTER_ISUPDATE',prop:'Title'},{av:'AV97GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV98GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV99GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'edtavDeleteencounter_Visible',ctrl:'vDELETEENCOUNTER',prop:'Visible'},{ctrl:'BTNBATCHAPPROVE',prop:'Visible'},{ctrl:'BTNBATCHRECHECK',prop:'Visible'}]}");
         setEventMetadata("'DOBATCHAPPROVE'","{handler:'E32141',iparms:[]");
         setEventMetadata("'DOBATCHAPPROVE'",",oparms:[]}");
         setEventMetadata("DVELOP_CONFIRMPANEL_BATCHAPPROVE.CLOSE","{handler:'E23142',iparms:[{av:'Dvelop_confirmpanel_batchapprove_Result',ctrl:'DVELOP_CONFIRMPANEL_BATCHAPPROVE',prop:'Result'},{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV221sBR_EncounterID',fld:'vSBR_ENCOUNTERID',pic:''},{av:'AV17BR_Information_PatientNo',fld:'vBR_INFORMATION_PATIENTNO',pic:''},{av:'cmbavBr_encounter_admitdateoperator'},{av:'AV120BR_Encounter_AdmitDateOperator',fld:'vBR_ENCOUNTER_ADMITDATEOPERATOR',pic:'ZZZ9'},{av:'AV122BR_Encounter_AdmitDate',fld:'vBR_ENCOUNTER_ADMITDATE',pic:''},{av:'AV121BR_Encounter_AdmitDate_To',fld:'vBR_ENCOUNTER_ADMITDATE_TO',pic:''},{av:'cmbavBr_encounter_status'},{av:'AV141BR_Encounter_Status',fld:'vBR_ENCOUNTER_STATUS',pic:'ZZZ9'},{av:'AV151BR_Encounter_IsRandApprove',fld:'vBR_ENCOUNTER_ISRANDAPPROVE',pic:''},{av:'AV152BR_Encounter_IsRandRecheck',fld:'vBR_ENCOUNTER_ISRANDRECHECK',pic:''},{av:'AV153BR_Encounter_IsUpdate',fld:'vBR_ENCOUNTER_ISUPDATE',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV48ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV86ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV56ddo_BR_Encounter_DepartmentTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DEPARTMENTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV60ddo_BR_Encounter_ENCTypeTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV66ddo_BR_Encounter_AdmitDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ADMITDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV135ddo_BR_Encounter_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV157ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV160ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDRECHECKTITLECONTROLIDTOREPLACE',pic:''},{av:'AV163ddo_BR_Encounter_IsUpdateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISUPDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV243Pgmname',fld:'vPGMNAME',pic:''},{av:'AV137IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'AV231tAllBR_EncounterID',fld:'vTALLBR_ENCOUNTERID',pic:''}]");
         setEventMetadata("DVELOP_CONFIRMPANEL_BATCHAPPROVE.CLOSE",",oparms:[{av:'AV223tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'AV137IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'AV231tAllBR_EncounterID',fld:'vTALLBR_ENCOUNTERID',pic:''},{av:'AV45BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV83BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV53BR_Encounter_DepartmentTitleFilterData',fld:'vBR_ENCOUNTER_DEPARTMENTTITLEFILTERDATA',pic:''},{av:'AV57BR_Encounter_ENCTypeTitleFilterData',fld:'vBR_ENCOUNTER_ENCTYPETITLEFILTERDATA',pic:''},{av:'AV61BR_Encounter_AdmitDateTitleFilterData',fld:'vBR_ENCOUNTER_ADMITDATETITLEFILTERDATA',pic:''},{av:'AV132BR_Encounter_StatusTitleFilterData',fld:'vBR_ENCOUNTER_STATUSTITLEFILTERDATA',pic:''},{av:'AV155BR_Encounter_IsRandApproveTitleFilterData',fld:'vBR_ENCOUNTER_ISRANDAPPROVETITLEFILTERDATA',pic:''},{av:'AV158BR_Encounter_IsRandRecheckTitleFilterData',fld:'vBR_ENCOUNTER_ISRANDRECHECKTITLEFILTERDATA',pic:''},{av:'AV161BR_Encounter_IsUpdateTitleFilterData',fld:'vBR_ENCOUNTER_ISUPDATETITLEFILTERDATA',pic:''},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Encounter_Department_Titleformat',ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Titleformat'},{av:'edtBR_Encounter_Department_Title',ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Title'},{av:'edtBR_Encounter_ENCType_Titleformat',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Titleformat'},{av:'edtBR_Encounter_ENCType_Title',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Title'},{av:'edtBR_Encounter_AdmitDate_Titleformat',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Titleformat'},{av:'edtBR_Encounter_AdmitDate_Title',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Title'},{av:'cmbBR_Encounter_Status'},{av:'chkBR_Encounter_IsRandApprove_Titleformat',ctrl:'BR_ENCOUNTER_ISRANDAPPROVE',prop:'Titleformat'},{av:'chkBR_Encounter_IsRandApprove.Title.Text',ctrl:'BR_ENCOUNTER_ISRANDAPPROVE',prop:'Title'},{av:'chkBR_Encounter_IsRandRecheck_Titleformat',ctrl:'BR_ENCOUNTER_ISRANDRECHECK',prop:'Titleformat'},{av:'chkBR_Encounter_IsRandRecheck.Title.Text',ctrl:'BR_ENCOUNTER_ISRANDRECHECK',prop:'Title'},{av:'chkBR_Encounter_IsUpdate_Titleformat',ctrl:'BR_ENCOUNTER_ISUPDATE',prop:'Titleformat'},{av:'chkBR_Encounter_IsUpdate.Title.Text',ctrl:'BR_ENCOUNTER_ISUPDATE',prop:'Title'},{av:'AV97GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV98GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV99GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'edtavDeleteencounter_Visible',ctrl:'vDELETEENCOUNTER',prop:'Visible'},{ctrl:'BTNBATCHAPPROVE',prop:'Visible'},{ctrl:'BTNBATCHRECHECK',prop:'Visible'}]}");
         setEventMetadata("'DOBATCHRECHECK'","{handler:'E33141',iparms:[]");
         setEventMetadata("'DOBATCHRECHECK'",",oparms:[]}");
         setEventMetadata("DVELOP_CONFIRMPANEL_BATCHRECHECK.CLOSE","{handler:'E24142',iparms:[{av:'Dvelop_confirmpanel_batchrecheck_Result',ctrl:'DVELOP_CONFIRMPANEL_BATCHRECHECK',prop:'Result'},{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV221sBR_EncounterID',fld:'vSBR_ENCOUNTERID',pic:''},{av:'AV17BR_Information_PatientNo',fld:'vBR_INFORMATION_PATIENTNO',pic:''},{av:'cmbavBr_encounter_admitdateoperator'},{av:'AV120BR_Encounter_AdmitDateOperator',fld:'vBR_ENCOUNTER_ADMITDATEOPERATOR',pic:'ZZZ9'},{av:'AV122BR_Encounter_AdmitDate',fld:'vBR_ENCOUNTER_ADMITDATE',pic:''},{av:'AV121BR_Encounter_AdmitDate_To',fld:'vBR_ENCOUNTER_ADMITDATE_TO',pic:''},{av:'cmbavBr_encounter_status'},{av:'AV141BR_Encounter_Status',fld:'vBR_ENCOUNTER_STATUS',pic:'ZZZ9'},{av:'AV151BR_Encounter_IsRandApprove',fld:'vBR_ENCOUNTER_ISRANDAPPROVE',pic:''},{av:'AV152BR_Encounter_IsRandRecheck',fld:'vBR_ENCOUNTER_ISRANDRECHECK',pic:''},{av:'AV153BR_Encounter_IsUpdate',fld:'vBR_ENCOUNTER_ISUPDATE',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV48ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV86ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV56ddo_BR_Encounter_DepartmentTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DEPARTMENTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV60ddo_BR_Encounter_ENCTypeTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV66ddo_BR_Encounter_AdmitDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ADMITDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV135ddo_BR_Encounter_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV157ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV160ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDRECHECKTITLECONTROLIDTOREPLACE',pic:''},{av:'AV163ddo_BR_Encounter_IsUpdateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISUPDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV243Pgmname',fld:'vPGMNAME',pic:''},{av:'AV137IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'AV231tAllBR_EncounterID',fld:'vTALLBR_ENCOUNTERID',pic:''}]");
         setEventMetadata("DVELOP_CONFIRMPANEL_BATCHRECHECK.CLOSE",",oparms:[{av:'AV223tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'AV137IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'AV231tAllBR_EncounterID',fld:'vTALLBR_ENCOUNTERID',pic:''},{av:'AV45BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV83BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV53BR_Encounter_DepartmentTitleFilterData',fld:'vBR_ENCOUNTER_DEPARTMENTTITLEFILTERDATA',pic:''},{av:'AV57BR_Encounter_ENCTypeTitleFilterData',fld:'vBR_ENCOUNTER_ENCTYPETITLEFILTERDATA',pic:''},{av:'AV61BR_Encounter_AdmitDateTitleFilterData',fld:'vBR_ENCOUNTER_ADMITDATETITLEFILTERDATA',pic:''},{av:'AV132BR_Encounter_StatusTitleFilterData',fld:'vBR_ENCOUNTER_STATUSTITLEFILTERDATA',pic:''},{av:'AV155BR_Encounter_IsRandApproveTitleFilterData',fld:'vBR_ENCOUNTER_ISRANDAPPROVETITLEFILTERDATA',pic:''},{av:'AV158BR_Encounter_IsRandRecheckTitleFilterData',fld:'vBR_ENCOUNTER_ISRANDRECHECKTITLEFILTERDATA',pic:''},{av:'AV161BR_Encounter_IsUpdateTitleFilterData',fld:'vBR_ENCOUNTER_ISUPDATETITLEFILTERDATA',pic:''},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Encounter_Department_Titleformat',ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Titleformat'},{av:'edtBR_Encounter_Department_Title',ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Title'},{av:'edtBR_Encounter_ENCType_Titleformat',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Titleformat'},{av:'edtBR_Encounter_ENCType_Title',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Title'},{av:'edtBR_Encounter_AdmitDate_Titleformat',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Titleformat'},{av:'edtBR_Encounter_AdmitDate_Title',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Title'},{av:'cmbBR_Encounter_Status'},{av:'chkBR_Encounter_IsRandApprove_Titleformat',ctrl:'BR_ENCOUNTER_ISRANDAPPROVE',prop:'Titleformat'},{av:'chkBR_Encounter_IsRandApprove.Title.Text',ctrl:'BR_ENCOUNTER_ISRANDAPPROVE',prop:'Title'},{av:'chkBR_Encounter_IsRandRecheck_Titleformat',ctrl:'BR_ENCOUNTER_ISRANDRECHECK',prop:'Titleformat'},{av:'chkBR_Encounter_IsRandRecheck.Title.Text',ctrl:'BR_ENCOUNTER_ISRANDRECHECK',prop:'Title'},{av:'chkBR_Encounter_IsUpdate_Titleformat',ctrl:'BR_ENCOUNTER_ISUPDATE',prop:'Titleformat'},{av:'chkBR_Encounter_IsUpdate.Title.Text',ctrl:'BR_ENCOUNTER_ISUPDATE',prop:'Title'},{av:'AV97GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV98GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV99GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'edtavDeleteencounter_Visible',ctrl:'vDELETEENCOUNTER',prop:'Visible'},{ctrl:'BTNBATCHAPPROVE',prop:'Visible'},{ctrl:'BTNBATCHRECHECK',prop:'Visible'}]}");
         setEventMetadata("BR_INFORMATION_PATIENTNO.CLICK","{handler:'E35142',iparms:[{av:'A85BR_Information_ID',fld:'BR_INFORMATION_ID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
         setEventMetadata("BR_INFORMATION_PATIENTNO.CLICK",",oparms:[]}");
         setEventMetadata("VSBR_ENCOUNTERID.CONTROLVALUECHANGING","{handler:'E25142',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV221sBR_EncounterID',fld:'vSBR_ENCOUNTERID',pic:''},{av:'AV17BR_Information_PatientNo',fld:'vBR_INFORMATION_PATIENTNO',pic:''},{av:'cmbavBr_encounter_admitdateoperator'},{av:'AV120BR_Encounter_AdmitDateOperator',fld:'vBR_ENCOUNTER_ADMITDATEOPERATOR',pic:'ZZZ9'},{av:'AV122BR_Encounter_AdmitDate',fld:'vBR_ENCOUNTER_ADMITDATE',pic:''},{av:'AV121BR_Encounter_AdmitDate_To',fld:'vBR_ENCOUNTER_ADMITDATE_TO',pic:''},{av:'cmbavBr_encounter_status'},{av:'AV141BR_Encounter_Status',fld:'vBR_ENCOUNTER_STATUS',pic:'ZZZ9'},{av:'AV151BR_Encounter_IsRandApprove',fld:'vBR_ENCOUNTER_ISRANDAPPROVE',pic:''},{av:'AV152BR_Encounter_IsRandRecheck',fld:'vBR_ENCOUNTER_ISRANDRECHECK',pic:''},{av:'AV153BR_Encounter_IsUpdate',fld:'vBR_ENCOUNTER_ISUPDATE',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV48ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV86ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV56ddo_BR_Encounter_DepartmentTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DEPARTMENTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV60ddo_BR_Encounter_ENCTypeTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV66ddo_BR_Encounter_AdmitDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ADMITDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV135ddo_BR_Encounter_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV157ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV160ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDRECHECKTITLECONTROLIDTOREPLACE',pic:''},{av:'AV163ddo_BR_Encounter_IsUpdateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISUPDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV243Pgmname',fld:'vPGMNAME',pic:''},{av:'AV137IsInsert',fld:'vISINSERT',pic:'',hsh:true}]");
         setEventMetadata("VSBR_ENCOUNTERID.CONTROLVALUECHANGING",",oparms:[{av:'AV223tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'AV137IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'AV231tAllBR_EncounterID',fld:'vTALLBR_ENCOUNTERID',pic:''},{av:'AV45BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV83BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV53BR_Encounter_DepartmentTitleFilterData',fld:'vBR_ENCOUNTER_DEPARTMENTTITLEFILTERDATA',pic:''},{av:'AV57BR_Encounter_ENCTypeTitleFilterData',fld:'vBR_ENCOUNTER_ENCTYPETITLEFILTERDATA',pic:''},{av:'AV61BR_Encounter_AdmitDateTitleFilterData',fld:'vBR_ENCOUNTER_ADMITDATETITLEFILTERDATA',pic:''},{av:'AV132BR_Encounter_StatusTitleFilterData',fld:'vBR_ENCOUNTER_STATUSTITLEFILTERDATA',pic:''},{av:'AV155BR_Encounter_IsRandApproveTitleFilterData',fld:'vBR_ENCOUNTER_ISRANDAPPROVETITLEFILTERDATA',pic:''},{av:'AV158BR_Encounter_IsRandRecheckTitleFilterData',fld:'vBR_ENCOUNTER_ISRANDRECHECKTITLEFILTERDATA',pic:''},{av:'AV161BR_Encounter_IsUpdateTitleFilterData',fld:'vBR_ENCOUNTER_ISUPDATETITLEFILTERDATA',pic:''},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Encounter_Department_Titleformat',ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Titleformat'},{av:'edtBR_Encounter_Department_Title',ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Title'},{av:'edtBR_Encounter_ENCType_Titleformat',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Titleformat'},{av:'edtBR_Encounter_ENCType_Title',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Title'},{av:'edtBR_Encounter_AdmitDate_Titleformat',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Titleformat'},{av:'edtBR_Encounter_AdmitDate_Title',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Title'},{av:'cmbBR_Encounter_Status'},{av:'chkBR_Encounter_IsRandApprove_Titleformat',ctrl:'BR_ENCOUNTER_ISRANDAPPROVE',prop:'Titleformat'},{av:'chkBR_Encounter_IsRandApprove.Title.Text',ctrl:'BR_ENCOUNTER_ISRANDAPPROVE',prop:'Title'},{av:'chkBR_Encounter_IsRandRecheck_Titleformat',ctrl:'BR_ENCOUNTER_ISRANDRECHECK',prop:'Titleformat'},{av:'chkBR_Encounter_IsRandRecheck.Title.Text',ctrl:'BR_ENCOUNTER_ISRANDRECHECK',prop:'Title'},{av:'chkBR_Encounter_IsUpdate_Titleformat',ctrl:'BR_ENCOUNTER_ISUPDATE',prop:'Titleformat'},{av:'chkBR_Encounter_IsUpdate.Title.Text',ctrl:'BR_ENCOUNTER_ISUPDATE',prop:'Title'},{av:'AV97GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV98GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV99GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'edtavDeleteencounter_Visible',ctrl:'vDELETEENCOUNTER',prop:'Visible'},{ctrl:'BTNBATCHAPPROVE',prop:'Visible'},{ctrl:'BTNBATCHRECHECK',prop:'Visible'}]}");
         setEventMetadata("'DOTEST'","{handler:'E29142',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV221sBR_EncounterID',fld:'vSBR_ENCOUNTERID',pic:''},{av:'AV17BR_Information_PatientNo',fld:'vBR_INFORMATION_PATIENTNO',pic:''},{av:'cmbavBr_encounter_admitdateoperator'},{av:'AV120BR_Encounter_AdmitDateOperator',fld:'vBR_ENCOUNTER_ADMITDATEOPERATOR',pic:'ZZZ9'},{av:'AV122BR_Encounter_AdmitDate',fld:'vBR_ENCOUNTER_ADMITDATE',pic:''},{av:'AV121BR_Encounter_AdmitDate_To',fld:'vBR_ENCOUNTER_ADMITDATE_TO',pic:''},{av:'cmbavBr_encounter_status'},{av:'AV141BR_Encounter_Status',fld:'vBR_ENCOUNTER_STATUS',pic:'ZZZ9'},{av:'AV151BR_Encounter_IsRandApprove',fld:'vBR_ENCOUNTER_ISRANDAPPROVE',pic:''},{av:'AV152BR_Encounter_IsRandRecheck',fld:'vBR_ENCOUNTER_ISRANDRECHECK',pic:''},{av:'AV153BR_Encounter_IsUpdate',fld:'vBR_ENCOUNTER_ISUPDATE',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV48ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV86ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV56ddo_BR_Encounter_DepartmentTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DEPARTMENTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV60ddo_BR_Encounter_ENCTypeTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV66ddo_BR_Encounter_AdmitDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ADMITDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV135ddo_BR_Encounter_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV157ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV160ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDRECHECKTITLECONTROLIDTOREPLACE',pic:''},{av:'AV163ddo_BR_Encounter_IsUpdateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISUPDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV243Pgmname',fld:'vPGMNAME',pic:''},{av:'AV137IsInsert',fld:'vISINSERT',pic:'',hsh:true}]");
         setEventMetadata("'DOTEST'",",oparms:[]}");
         setEventMetadata("'DOADD'","{handler:'E30142',iparms:[{av:'A19BR_EncounterID',fld:'BR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
         setEventMetadata("'DOADD'",",oparms:[]}");
         setEventMetadata("BR_ENCOUNTERID.CLICK","{handler:'E31142',iparms:[{av:'cmbavBr_encounter_status'},{av:'AV141BR_Encounter_Status',fld:'vBR_ENCOUNTER_STATUS',pic:'ZZZ9'},{av:'AV137IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'cmbBR_Encounter_Status'},{av:'A172BR_Encounter_Status',fld:'BR_ENCOUNTER_STATUS',pic:'ZZZ9',hsh:true},{av:'A19BR_EncounterID',fld:'BR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
         setEventMetadata("BR_ENCOUNTERID.CLICK",",oparms:[]}");
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
      }

      public override void initialize( )
      {
         Gridpaginationbar_Selectedpage = "";
         Ddo_br_encounterid_Activeeventkey = "";
         Ddo_br_information_patientno_Activeeventkey = "";
         Ddo_br_encounter_department_Activeeventkey = "";
         Ddo_br_encounter_enctype_Activeeventkey = "";
         Ddo_br_encounter_admitdate_Activeeventkey = "";
         Ddo_br_encounter_status_Activeeventkey = "";
         Ddo_br_encounter_israndapprove_Activeeventkey = "";
         Ddo_br_encounter_israndrecheck_Activeeventkey = "";
         Ddo_br_encounter_isupdate_Activeeventkey = "";
         Dvelop_confirmpanel_deleteencounter_Result = "";
         Dvelop_confirmpanel_batchapprove_Result = "";
         Dvelop_confirmpanel_batchrecheck_Result = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV221sBR_EncounterID = "";
         AV17BR_Information_PatientNo = "";
         AV122BR_Encounter_AdmitDate = DateTime.MinValue;
         AV121BR_Encounter_AdmitDate_To = DateTime.MinValue;
         AV48ddo_BR_EncounterIDTitleControlIdToReplace = "";
         AV86ddo_BR_Information_PatientNoTitleControlIdToReplace = "";
         AV56ddo_BR_Encounter_DepartmentTitleControlIdToReplace = "";
         AV60ddo_BR_Encounter_ENCTypeTitleControlIdToReplace = "";
         AV66ddo_BR_Encounter_AdmitDateTitleControlIdToReplace = "";
         AV135ddo_BR_Encounter_StatusTitleControlIdToReplace = "";
         AV157ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace = "";
         AV160ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace = "";
         AV163ddo_BR_Encounter_IsUpdateTitleControlIdToReplace = "";
         AV243Pgmname = "";
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         AV95DDO_TitleSettingsIcons = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV45BR_EncounterIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV83BR_Information_PatientNoTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV53BR_Encounter_DepartmentTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV57BR_Encounter_ENCTypeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV61BR_Encounter_AdmitDateTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV132BR_Encounter_StatusTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV155BR_Encounter_IsRandApproveTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV158BR_Encounter_IsRandRecheckTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV161BR_Encounter_IsUpdateTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV231tAllBR_EncounterID = new GxSimpleCollection<long>();
         Ddo_br_encounterid_Sortedstatus = "";
         Ddo_br_information_patientno_Sortedstatus = "";
         Ddo_br_encounter_department_Sortedstatus = "";
         Ddo_br_encounter_enctype_Sortedstatus = "";
         Ddo_br_encounter_admitdate_Sortedstatus = "";
         Ddo_br_encounter_status_Sortedstatus = "";
         Ddo_br_encounter_israndapprove_Sortedstatus = "";
         Ddo_br_encounter_israndrecheck_Sortedstatus = "";
         Ddo_br_encounter_isupdate_Sortedstatus = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         ucDvpanel_tableheader = new GXUserControl();
         TempTags = "";
         lblFiltertextbr_encounter_admitdate_Jsonclick = "";
         ClassString = "";
         StyleString = "";
         ucDvpanel_unnamedtable1 = new GXUserControl();
         GridContainer = new GXWebGrid( context);
         sStyleString = "";
         subGrid_Linesclass = "";
         GridColumn = new GXWebColumn();
         AV164deleteEncounter = "";
         A36BR_Information_PatientNo = "";
         A84BR_Encounter_Department = "";
         A90BR_Encounter_ENCType = "";
         A91BR_Encounter_AdmitDate = DateTime.MinValue;
         A360BAS_TenantTenantCode = "";
         ucGridpaginationbar = new GXUserControl();
         ucDdo_br_encounterid = new GXUserControl();
         ucDdo_br_information_patientno = new GXUserControl();
         ucDdo_br_encounter_department = new GXUserControl();
         ucDdo_br_encounter_enctype = new GXUserControl();
         ucDdo_br_encounter_admitdate = new GXUserControl();
         ucDdo_br_encounter_status = new GXUserControl();
         ucDdo_br_encounter_israndapprove = new GXUserControl();
         ucDdo_br_encounter_israndrecheck = new GXUserControl();
         ucDdo_br_encounter_isupdate = new GXUserControl();
         ucWorkwithplusutilities1 = new GXUserControl();
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV242Deleteencounter_GXI = "";
         scmdbuf = "";
         lV235BR_EncounterWWDS_1_Br_information_patientno = "";
         lV221sBR_EncounterID = "";
         AV235BR_EncounterWWDS_1_Br_information_patientno = "";
         AV236BR_EncounterWWDS_2_Br_encounter_admitdate = DateTime.MinValue;
         AV237BR_EncounterWWDS_3_Br_encounter_admitdate_to = DateTime.MinValue;
         AV223tCurrentCode = "";
         H00142_A360BAS_TenantTenantCode = new String[] {""} ;
         H00142_n360BAS_TenantTenantCode = new bool[] {false} ;
         H00142_A202BR_Encounter_IsUpdate = new bool[] {false} ;
         H00142_n202BR_Encounter_IsUpdate = new bool[] {false} ;
         H00142_A193BR_Encounter_IsRandRecheck = new bool[] {false} ;
         H00142_n193BR_Encounter_IsRandRecheck = new bool[] {false} ;
         H00142_A192BR_Encounter_IsRandApprove = new bool[] {false} ;
         H00142_n192BR_Encounter_IsRandApprove = new bool[] {false} ;
         H00142_A172BR_Encounter_Status = new short[1] ;
         H00142_n172BR_Encounter_Status = new bool[] {false} ;
         H00142_A85BR_Information_ID = new long[1] ;
         H00142_n85BR_Information_ID = new bool[] {false} ;
         H00142_A91BR_Encounter_AdmitDate = new DateTime[] {DateTime.MinValue} ;
         H00142_n91BR_Encounter_AdmitDate = new bool[] {false} ;
         H00142_A90BR_Encounter_ENCType = new String[] {""} ;
         H00142_n90BR_Encounter_ENCType = new bool[] {false} ;
         H00142_A84BR_Encounter_Department = new String[] {""} ;
         H00142_n84BR_Encounter_Department = new bool[] {false} ;
         H00142_A36BR_Information_PatientNo = new String[] {""} ;
         H00142_n36BR_Information_PatientNo = new bool[] {false} ;
         H00142_A19BR_EncounterID = new long[1] ;
         H00143_AGRID_nRecordCount = new long[1] ;
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV6WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV38Session = context.GetSession();
         GXt_char1 = "";
         AV227tDataPackage = new GxSimpleCollection<String>();
         AV228tResult = "";
         AV149WebSession = context.GetSession();
         AV229tSDT_MicroUserInfo = new SdtSDT_MicroUserInfo(context);
         GridRow = new GXWebRow();
         AV11GridState = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState(context);
         AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
         AV9TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV8HTTPRequest = new GxHttpRequest( context);
         ucDvelop_confirmpanel_batchrecheck = new GXUserControl();
         ucDvelop_confirmpanel_batchapprove = new GXUserControl();
         ucDvelop_confirmpanel_deleteencounter = new GXUserControl();
         bttBtnbatchapprove_Jsonclick = "";
         bttBtnbatchrecheck_Jsonclick = "";
         lblBr_encounter_admitdate_rangemiddletext_1_Jsonclick = "";
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sImgUrl = "";
         ROClassString = "";
         GXCCtl = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_encounterww__default(),
            new Object[][] {
                new Object[] {
               H00142_A360BAS_TenantTenantCode, H00142_n360BAS_TenantTenantCode, H00142_A202BR_Encounter_IsUpdate, H00142_n202BR_Encounter_IsUpdate, H00142_A193BR_Encounter_IsRandRecheck, H00142_n193BR_Encounter_IsRandRecheck, H00142_A192BR_Encounter_IsRandApprove, H00142_n192BR_Encounter_IsRandApprove, H00142_A172BR_Encounter_Status, H00142_n172BR_Encounter_Status,
               H00142_A85BR_Information_ID, H00142_n85BR_Information_ID, H00142_A91BR_Encounter_AdmitDate, H00142_n91BR_Encounter_AdmitDate, H00142_A90BR_Encounter_ENCType, H00142_n90BR_Encounter_ENCType, H00142_A84BR_Encounter_Department, H00142_n84BR_Encounter_Department, H00142_A36BR_Information_PatientNo, H00142_n36BR_Information_PatientNo,
               H00142_A19BR_EncounterID
               }
               , new Object[] {
               H00143_AGRID_nRecordCount
               }
            }
         );
         AV243Pgmname = "BR_EncounterWW";
         /* GeneXus formulas. */
         AV243Pgmname = "BR_EncounterWW";
         context.Gx_err = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_GXsfl_87 ;
      private short nGXsfl_87_idx=1 ;
      private short GRID_nEOF ;
      private short AV120BR_Encounter_AdmitDateOperator ;
      private short AV141BR_Encounter_Status ;
      private short AV13OrderedBy ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short subGrid_Backcolorstyle ;
      private short subGrid_Titlebackstyle ;
      private short edtBR_EncounterID_Titleformat ;
      private short edtBR_Information_PatientNo_Titleformat ;
      private short edtBR_Encounter_Department_Titleformat ;
      private short edtBR_Encounter_ENCType_Titleformat ;
      private short edtBR_Encounter_AdmitDate_Titleformat ;
      private short cmbBR_Encounter_Status_Titleformat ;
      private short chkBR_Encounter_IsRandApprove_Titleformat ;
      private short chkBR_Encounter_IsRandRecheck_Titleformat ;
      private short chkBR_Encounter_IsUpdate_Titleformat ;
      private short subGrid_Sortable ;
      private short A172BR_Encounter_Status ;
      private short subGrid_Allowselection ;
      private short subGrid_Allowhovering ;
      private short subGrid_Allowcollapsing ;
      private short subGrid_Collapsed ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short AV238BR_EncounterWWDS_4_Br_encounter_status ;
      private short AV226tUserType ;
      private short AV224tBR_Encounter_Status ;
      private short nGXWrapped ;
      private short subGrid_Backstyle ;
      private int subGrid_Rows ;
      private int Gridpaginationbar_Rowsperpageselectedvalue ;
      private int Gridpaginationbar_Pagestoshow ;
      private int edtavSbr_encounterid_Enabled ;
      private int edtavBr_information_patientno_Enabled ;
      private int subGrid_Titlebackcolor ;
      private int subGrid_Allbackcolor ;
      private int edtavDeleteencounter_Visible ;
      private int subGrid_Selectedindex ;
      private int subGrid_Selectioncolor ;
      private int subGrid_Hoveringcolor ;
      private int edtavDdo_br_encounteridtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_information_patientnotitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_encounter_departmenttitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_encounter_enctypetitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_encounter_admitdatetitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_encounter_statustitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_encounter_israndapprovetitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_encounter_israndrechecktitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_encounter_isupdatetitlecontrolidtoreplace_Visible ;
      private int edtavBr_encounterid_selected_Visible ;
      private int edtavOrderedby_Visible ;
      private int edtavOrdereddsc_Visible ;
      private int subGrid_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int AV96PageToGo ;
      private int bttBtnbatchapprove_Visible ;
      private int bttBtnbatchrecheck_Visible ;
      private int AV244GXV1 ;
      private int edtavBr_encounter_admitdate_Enabled ;
      private int edtavBr_encounter_admitdate_to_Enabled ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private int edtavDeleteencounter_Enabled ;
      private long GRID_nFirstRecordOnPage ;
      private long AV97GridCurrentPage ;
      private long AV99GridRecordCount ;
      private long AV98GridPageSize ;
      private long A19BR_EncounterID ;
      private long A85BR_Information_ID ;
      private long AV165BR_EncounterID_Selected ;
      private long GRID_nCurrentRecord ;
      private long GRID_nRecordCount ;
      private long AV230tNum ;
      private String Gridpaginationbar_Selectedpage ;
      private String Ddo_br_encounterid_Activeeventkey ;
      private String Ddo_br_information_patientno_Activeeventkey ;
      private String Ddo_br_encounter_department_Activeeventkey ;
      private String Ddo_br_encounter_enctype_Activeeventkey ;
      private String Ddo_br_encounter_admitdate_Activeeventkey ;
      private String Ddo_br_encounter_status_Activeeventkey ;
      private String Ddo_br_encounter_israndapprove_Activeeventkey ;
      private String Ddo_br_encounter_israndrecheck_Activeeventkey ;
      private String Ddo_br_encounter_isupdate_Activeeventkey ;
      private String Dvelop_confirmpanel_deleteencounter_Result ;
      private String Dvelop_confirmpanel_batchapprove_Result ;
      private String Dvelop_confirmpanel_batchrecheck_Result ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_87_idx="0001" ;
      private String AV243Pgmname ;
      private String GXKey ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String Dvpanel_tableheader_Width ;
      private String Dvpanel_tableheader_Cls ;
      private String Dvpanel_tableheader_Title ;
      private String Dvpanel_tableheader_Iconposition ;
      private String Dvpanel_unnamedtable1_Width ;
      private String Dvpanel_unnamedtable1_Cls ;
      private String Dvpanel_unnamedtable1_Title ;
      private String Dvpanel_unnamedtable1_Iconposition ;
      private String Gridpaginationbar_Class ;
      private String Gridpaginationbar_Previous ;
      private String Gridpaginationbar_Next ;
      private String Gridpaginationbar_Caption ;
      private String Gridpaginationbar_Pagingbuttonsposition ;
      private String Gridpaginationbar_Pagingcaptionposition ;
      private String Gridpaginationbar_Emptygridclass ;
      private String Gridpaginationbar_Rowsperpageoptions ;
      private String Gridpaginationbar_Emptygridcaption ;
      private String Gridpaginationbar_Rowsperpagecaption ;
      private String Ddo_br_encounterid_Caption ;
      private String Ddo_br_encounterid_Tooltip ;
      private String Ddo_br_encounterid_Cls ;
      private String Ddo_br_encounterid_Dropdownoptionstype ;
      private String Ddo_br_encounterid_Titlecontrolidtoreplace ;
      private String Ddo_br_encounterid_Sortedstatus ;
      private String Ddo_br_encounterid_Sortasc ;
      private String Ddo_br_encounterid_Sortdsc ;
      private String Ddo_br_encounterid_Searchbuttontext ;
      private String Ddo_br_information_patientno_Caption ;
      private String Ddo_br_information_patientno_Tooltip ;
      private String Ddo_br_information_patientno_Cls ;
      private String Ddo_br_information_patientno_Dropdownoptionstype ;
      private String Ddo_br_information_patientno_Titlecontrolidtoreplace ;
      private String Ddo_br_information_patientno_Sortedstatus ;
      private String Ddo_br_information_patientno_Sortasc ;
      private String Ddo_br_information_patientno_Sortdsc ;
      private String Ddo_br_information_patientno_Searchbuttontext ;
      private String Ddo_br_encounter_department_Caption ;
      private String Ddo_br_encounter_department_Tooltip ;
      private String Ddo_br_encounter_department_Cls ;
      private String Ddo_br_encounter_department_Dropdownoptionstype ;
      private String Ddo_br_encounter_department_Titlecontrolidtoreplace ;
      private String Ddo_br_encounter_department_Sortedstatus ;
      private String Ddo_br_encounter_department_Sortasc ;
      private String Ddo_br_encounter_department_Sortdsc ;
      private String Ddo_br_encounter_department_Searchbuttontext ;
      private String Ddo_br_encounter_enctype_Caption ;
      private String Ddo_br_encounter_enctype_Tooltip ;
      private String Ddo_br_encounter_enctype_Cls ;
      private String Ddo_br_encounter_enctype_Dropdownoptionstype ;
      private String Ddo_br_encounter_enctype_Titlecontrolidtoreplace ;
      private String Ddo_br_encounter_enctype_Sortedstatus ;
      private String Ddo_br_encounter_enctype_Sortasc ;
      private String Ddo_br_encounter_enctype_Sortdsc ;
      private String Ddo_br_encounter_enctype_Searchbuttontext ;
      private String Ddo_br_encounter_admitdate_Caption ;
      private String Ddo_br_encounter_admitdate_Tooltip ;
      private String Ddo_br_encounter_admitdate_Cls ;
      private String Ddo_br_encounter_admitdate_Dropdownoptionstype ;
      private String Ddo_br_encounter_admitdate_Titlecontrolidtoreplace ;
      private String Ddo_br_encounter_admitdate_Sortedstatus ;
      private String Ddo_br_encounter_admitdate_Sortasc ;
      private String Ddo_br_encounter_admitdate_Sortdsc ;
      private String Ddo_br_encounter_admitdate_Searchbuttontext ;
      private String Ddo_br_encounter_status_Caption ;
      private String Ddo_br_encounter_status_Tooltip ;
      private String Ddo_br_encounter_status_Cls ;
      private String Ddo_br_encounter_status_Dropdownoptionstype ;
      private String Ddo_br_encounter_status_Titlecontrolidtoreplace ;
      private String Ddo_br_encounter_status_Sortedstatus ;
      private String Ddo_br_encounter_status_Sortasc ;
      private String Ddo_br_encounter_status_Sortdsc ;
      private String Ddo_br_encounter_status_Searchbuttontext ;
      private String Ddo_br_encounter_israndapprove_Caption ;
      private String Ddo_br_encounter_israndapprove_Tooltip ;
      private String Ddo_br_encounter_israndapprove_Cls ;
      private String Ddo_br_encounter_israndapprove_Dropdownoptionstype ;
      private String Ddo_br_encounter_israndapprove_Titlecontrolidtoreplace ;
      private String Ddo_br_encounter_israndapprove_Sortedstatus ;
      private String Ddo_br_encounter_israndapprove_Sortasc ;
      private String Ddo_br_encounter_israndapprove_Sortdsc ;
      private String Ddo_br_encounter_israndapprove_Searchbuttontext ;
      private String Ddo_br_encounter_israndrecheck_Caption ;
      private String Ddo_br_encounter_israndrecheck_Tooltip ;
      private String Ddo_br_encounter_israndrecheck_Cls ;
      private String Ddo_br_encounter_israndrecheck_Dropdownoptionstype ;
      private String Ddo_br_encounter_israndrecheck_Titlecontrolidtoreplace ;
      private String Ddo_br_encounter_israndrecheck_Sortedstatus ;
      private String Ddo_br_encounter_israndrecheck_Sortasc ;
      private String Ddo_br_encounter_israndrecheck_Sortdsc ;
      private String Ddo_br_encounter_israndrecheck_Searchbuttontext ;
      private String Ddo_br_encounter_isupdate_Caption ;
      private String Ddo_br_encounter_isupdate_Tooltip ;
      private String Ddo_br_encounter_isupdate_Cls ;
      private String Ddo_br_encounter_isupdate_Dropdownoptionstype ;
      private String Ddo_br_encounter_isupdate_Titlecontrolidtoreplace ;
      private String Ddo_br_encounter_isupdate_Sortedstatus ;
      private String Ddo_br_encounter_isupdate_Sortasc ;
      private String Ddo_br_encounter_isupdate_Sortdsc ;
      private String Ddo_br_encounter_isupdate_Searchbuttontext ;
      private String Dvelop_confirmpanel_deleteencounter_Title ;
      private String Dvelop_confirmpanel_deleteencounter_Confirmationtext ;
      private String Dvelop_confirmpanel_deleteencounter_Yesbuttoncaption ;
      private String Dvelop_confirmpanel_deleteencounter_Nobuttoncaption ;
      private String Dvelop_confirmpanel_deleteencounter_Cancelbuttoncaption ;
      private String Dvelop_confirmpanel_deleteencounter_Yesbuttonposition ;
      private String Dvelop_confirmpanel_deleteencounter_Confirmtype ;
      private String Dvelop_confirmpanel_batchapprove_Title ;
      private String Dvelop_confirmpanel_batchapprove_Confirmationtext ;
      private String Dvelop_confirmpanel_batchapprove_Yesbuttoncaption ;
      private String Dvelop_confirmpanel_batchapprove_Nobuttoncaption ;
      private String Dvelop_confirmpanel_batchapprove_Cancelbuttoncaption ;
      private String Dvelop_confirmpanel_batchapprove_Yesbuttonposition ;
      private String Dvelop_confirmpanel_batchapprove_Confirmtype ;
      private String Dvelop_confirmpanel_batchrecheck_Title ;
      private String Dvelop_confirmpanel_batchrecheck_Confirmationtext ;
      private String Dvelop_confirmpanel_batchrecheck_Yesbuttoncaption ;
      private String Dvelop_confirmpanel_batchrecheck_Nobuttoncaption ;
      private String Dvelop_confirmpanel_batchrecheck_Cancelbuttoncaption ;
      private String Dvelop_confirmpanel_batchrecheck_Yesbuttonposition ;
      private String Dvelop_confirmpanel_batchrecheck_Confirmtype ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divLayoutmaintable_Internalname ;
      private String divTablemain_Internalname ;
      private String divHtml_dvpanel_tableheader_Internalname ;
      private String Dvpanel_tableheader_Internalname ;
      private String divLayout_tableheader_Internalname ;
      private String divTableheader_Internalname ;
      private String divTableactions_Internalname ;
      private String edtavSbr_encounterid_Internalname ;
      private String TempTags ;
      private String edtavSbr_encounterid_Jsonclick ;
      private String edtavBr_information_patientno_Internalname ;
      private String edtavBr_information_patientno_Jsonclick ;
      private String divTablesplittedfiltertextbr_encounter_admitdate_Internalname ;
      private String lblFiltertextbr_encounter_admitdate_Internalname ;
      private String lblFiltertextbr_encounter_admitdate_Jsonclick ;
      private String cmbavBr_encounter_status_Internalname ;
      private String cmbavBr_encounter_status_Jsonclick ;
      private String divUnnamedtable2_Internalname ;
      private String chkavBr_encounter_israndapprove_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String chkavBr_encounter_israndrecheck_Internalname ;
      private String chkavBr_encounter_isupdate_Internalname ;
      private String divHtml_dvpanel_unnamedtable1_Internalname ;
      private String Dvpanel_unnamedtable1_Internalname ;
      private String divLayout_unnamedtable1_Internalname ;
      private String divGridtablewithpaginationbar_Internalname ;
      private String sStyleString ;
      private String subGrid_Internalname ;
      private String subGrid_Class ;
      private String subGrid_Linesclass ;
      private String edtBR_EncounterID_Title ;
      private String edtBR_Information_PatientNo_Title ;
      private String edtBR_Encounter_Department_Title ;
      private String edtBR_Encounter_ENCType_Title ;
      private String edtBR_Encounter_AdmitDate_Title ;
      private String subGrid_Header ;
      private String edtavDeleteencounter_Tooltiptext ;
      private String divHtml_gridpaginationbar_Internalname ;
      private String Gridpaginationbar_Internalname ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String Ddo_br_encounterid_Internalname ;
      private String edtavDdo_br_encounteridtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_information_patientno_Internalname ;
      private String edtavDdo_br_information_patientnotitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_encounter_department_Internalname ;
      private String edtavDdo_br_encounter_departmenttitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_encounter_enctype_Internalname ;
      private String edtavDdo_br_encounter_enctypetitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_encounter_admitdate_Internalname ;
      private String edtavDdo_br_encounter_admitdatetitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_encounter_status_Internalname ;
      private String edtavDdo_br_encounter_statustitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_encounter_israndapprove_Internalname ;
      private String edtavDdo_br_encounter_israndapprovetitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_encounter_israndrecheck_Internalname ;
      private String edtavDdo_br_encounter_israndrechecktitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_encounter_isupdate_Internalname ;
      private String edtavDdo_br_encounter_isupdatetitlecontrolidtoreplace_Internalname ;
      private String Workwithplusutilities1_Internalname ;
      private String edtavBr_encounterid_selected_Internalname ;
      private String edtavBr_encounterid_selected_Jsonclick ;
      private String edtavOrderedby_Internalname ;
      private String edtavOrderedby_Jsonclick ;
      private String edtavOrdereddsc_Internalname ;
      private String edtavOrdereddsc_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavDeleteencounter_Internalname ;
      private String edtBR_EncounterID_Internalname ;
      private String edtBR_Information_PatientNo_Internalname ;
      private String edtBR_Encounter_Department_Internalname ;
      private String edtBR_Encounter_ENCType_Internalname ;
      private String edtBR_Encounter_AdmitDate_Internalname ;
      private String edtBR_Information_ID_Internalname ;
      private String cmbBR_Encounter_Status_Internalname ;
      private String chkBR_Encounter_IsRandApprove_Internalname ;
      private String chkBR_Encounter_IsRandRecheck_Internalname ;
      private String chkBR_Encounter_IsUpdate_Internalname ;
      private String edtBAS_TenantTenantCode_Internalname ;
      private String cmbavBr_encounter_admitdateoperator_Internalname ;
      private String scmdbuf ;
      private String edtavBr_encounter_admitdate_Internalname ;
      private String edtavBr_encounter_admitdate_to_Internalname ;
      private String GXt_char1 ;
      private String bttBtnbatchapprove_Internalname ;
      private String bttBtnbatchrecheck_Internalname ;
      private String tblTabledvelop_confirmpanel_batchrecheck_Internalname ;
      private String Dvelop_confirmpanel_batchrecheck_Internalname ;
      private String tblTabledvelop_confirmpanel_batchapprove_Internalname ;
      private String Dvelop_confirmpanel_batchapprove_Internalname ;
      private String tblTabledvelop_confirmpanel_deleteencounter_Internalname ;
      private String Dvelop_confirmpanel_deleteencounter_Internalname ;
      private String tblUnnamedtable1_Internalname ;
      private String bttBtnbatchapprove_Jsonclick ;
      private String bttBtnbatchrecheck_Jsonclick ;
      private String tblTablemergedbr_encounter_admitdate_Internalname ;
      private String cmbavBr_encounter_admitdateoperator_Jsonclick ;
      private String edtavBr_encounter_admitdate_Jsonclick ;
      private String cellBr_encounter_admitdate_rangemiddletext_1_cell_Internalname ;
      private String lblBr_encounter_admitdate_rangemiddletext_1_Internalname ;
      private String lblBr_encounter_admitdate_rangemiddletext_1_Jsonclick ;
      private String cellBr_encounter_admitdate_to_cell_Internalname ;
      private String edtavBr_encounter_admitdate_to_Jsonclick ;
      private String sGXsfl_87_fel_idx="0001" ;
      private String sImgUrl ;
      private String edtavDeleteencounter_Jsonclick ;
      private String ROClassString ;
      private String edtBR_EncounterID_Jsonclick ;
      private String edtBR_Information_PatientNo_Jsonclick ;
      private String edtBR_Encounter_Department_Jsonclick ;
      private String edtBR_Encounter_ENCType_Jsonclick ;
      private String edtBR_Encounter_AdmitDate_Jsonclick ;
      private String edtBR_Information_ID_Jsonclick ;
      private String GXCCtl ;
      private String cmbBR_Encounter_Status_Jsonclick ;
      private String edtBAS_TenantTenantCode_Jsonclick ;
      private DateTime AV122BR_Encounter_AdmitDate ;
      private DateTime AV121BR_Encounter_AdmitDate_To ;
      private DateTime A91BR_Encounter_AdmitDate ;
      private DateTime AV236BR_EncounterWWDS_2_Br_encounter_admitdate ;
      private DateTime AV237BR_EncounterWWDS_3_Br_encounter_admitdate_to ;
      private bool entryPointCalled ;
      private bool AV151BR_Encounter_IsRandApprove ;
      private bool AV152BR_Encounter_IsRandRecheck ;
      private bool AV153BR_Encounter_IsUpdate ;
      private bool AV14OrderedDsc ;
      private bool AV137IsInsert ;
      private bool toggleJsOutput ;
      private bool Dvpanel_tableheader_Collapsible ;
      private bool Dvpanel_tableheader_Collapsed ;
      private bool Dvpanel_tableheader_Autowidth ;
      private bool Dvpanel_tableheader_Autoheight ;
      private bool Dvpanel_tableheader_Showcollapseicon ;
      private bool Dvpanel_tableheader_Autoscroll ;
      private bool Dvpanel_unnamedtable1_Collapsible ;
      private bool Dvpanel_unnamedtable1_Collapsed ;
      private bool Dvpanel_unnamedtable1_Autowidth ;
      private bool Dvpanel_unnamedtable1_Autoheight ;
      private bool Dvpanel_unnamedtable1_Showcollapseicon ;
      private bool Dvpanel_unnamedtable1_Autoscroll ;
      private bool Gridpaginationbar_Showfirst ;
      private bool Gridpaginationbar_Showprevious ;
      private bool Gridpaginationbar_Shownext ;
      private bool Gridpaginationbar_Showlast ;
      private bool Gridpaginationbar_Rowsperpageselector ;
      private bool Ddo_br_encounterid_Includesortasc ;
      private bool Ddo_br_encounterid_Includesortdsc ;
      private bool Ddo_br_encounterid_Includefilter ;
      private bool Ddo_br_encounterid_Includedatalist ;
      private bool Ddo_br_information_patientno_Includesortasc ;
      private bool Ddo_br_information_patientno_Includesortdsc ;
      private bool Ddo_br_information_patientno_Includefilter ;
      private bool Ddo_br_information_patientno_Includedatalist ;
      private bool Ddo_br_encounter_department_Includesortasc ;
      private bool Ddo_br_encounter_department_Includesortdsc ;
      private bool Ddo_br_encounter_department_Includefilter ;
      private bool Ddo_br_encounter_department_Includedatalist ;
      private bool Ddo_br_encounter_enctype_Includesortasc ;
      private bool Ddo_br_encounter_enctype_Includesortdsc ;
      private bool Ddo_br_encounter_enctype_Includefilter ;
      private bool Ddo_br_encounter_enctype_Includedatalist ;
      private bool Ddo_br_encounter_admitdate_Includesortasc ;
      private bool Ddo_br_encounter_admitdate_Includesortdsc ;
      private bool Ddo_br_encounter_admitdate_Includefilter ;
      private bool Ddo_br_encounter_admitdate_Includedatalist ;
      private bool Ddo_br_encounter_status_Includesortasc ;
      private bool Ddo_br_encounter_status_Includesortdsc ;
      private bool Ddo_br_encounter_status_Includefilter ;
      private bool Ddo_br_encounter_status_Includedatalist ;
      private bool Ddo_br_encounter_israndapprove_Includesortasc ;
      private bool Ddo_br_encounter_israndapprove_Includesortdsc ;
      private bool Ddo_br_encounter_israndapprove_Includefilter ;
      private bool Ddo_br_encounter_israndapprove_Includedatalist ;
      private bool Ddo_br_encounter_israndrecheck_Includesortasc ;
      private bool Ddo_br_encounter_israndrecheck_Includesortdsc ;
      private bool Ddo_br_encounter_israndrecheck_Includefilter ;
      private bool Ddo_br_encounter_israndrecheck_Includedatalist ;
      private bool Ddo_br_encounter_isupdate_Includesortasc ;
      private bool Ddo_br_encounter_isupdate_Includesortdsc ;
      private bool Ddo_br_encounter_isupdate_Includefilter ;
      private bool Ddo_br_encounter_isupdate_Includedatalist ;
      private bool wbLoad ;
      private bool A192BR_Encounter_IsRandApprove ;
      private bool A193BR_Encounter_IsRandRecheck ;
      private bool A202BR_Encounter_IsUpdate ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_87_Refreshing=false ;
      private bool n36BR_Information_PatientNo ;
      private bool n84BR_Encounter_Department ;
      private bool n90BR_Encounter_ENCType ;
      private bool n91BR_Encounter_AdmitDate ;
      private bool n85BR_Information_ID ;
      private bool n172BR_Encounter_Status ;
      private bool n192BR_Encounter_IsRandApprove ;
      private bool n193BR_Encounter_IsRandRecheck ;
      private bool n202BR_Encounter_IsUpdate ;
      private bool n360BAS_TenantTenantCode ;
      private bool gxdyncontrolsrefreshing ;
      private bool AV239BR_EncounterWWDS_5_Br_encounter_israndapprove ;
      private bool AV240BR_EncounterWWDS_6_Br_encounter_israndrecheck ;
      private bool AV241BR_EncounterWWDS_7_Br_encounter_isupdate ;
      private bool returnInSub ;
      private bool AV139IsChecker ;
      private bool AV140IsManager ;
      private bool AV154IsRocheUser ;
      private bool AV138IsApprover ;
      private bool gx_refresh_fired ;
      private bool AV166IsAuthorized_deleteEncounter ;
      private bool AV105TempBoolean ;
      private bool GXt_boolean3 ;
      private bool AV232tCheckFlag ;
      private bool AV164deleteEncounter_IsBlob ;
      private String AV221sBR_EncounterID ;
      private String AV17BR_Information_PatientNo ;
      private String AV48ddo_BR_EncounterIDTitleControlIdToReplace ;
      private String AV86ddo_BR_Information_PatientNoTitleControlIdToReplace ;
      private String AV56ddo_BR_Encounter_DepartmentTitleControlIdToReplace ;
      private String AV60ddo_BR_Encounter_ENCTypeTitleControlIdToReplace ;
      private String AV66ddo_BR_Encounter_AdmitDateTitleControlIdToReplace ;
      private String AV135ddo_BR_Encounter_StatusTitleControlIdToReplace ;
      private String AV157ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace ;
      private String AV160ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace ;
      private String AV163ddo_BR_Encounter_IsUpdateTitleControlIdToReplace ;
      private String A36BR_Information_PatientNo ;
      private String A84BR_Encounter_Department ;
      private String A90BR_Encounter_ENCType ;
      private String A360BAS_TenantTenantCode ;
      private String AV242Deleteencounter_GXI ;
      private String lV235BR_EncounterWWDS_1_Br_information_patientno ;
      private String lV221sBR_EncounterID ;
      private String AV235BR_EncounterWWDS_1_Br_information_patientno ;
      private String AV223tCurrentCode ;
      private String AV228tResult ;
      private String AV164deleteEncounter ;
      private GxSimpleCollection<long> AV231tAllBR_EncounterID ;
      private IGxSession AV38Session ;
      private IGxSession AV149WebSession ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private GXUserControl ucDvpanel_tableheader ;
      private GXUserControl ucDvpanel_unnamedtable1 ;
      private GXUserControl ucGridpaginationbar ;
      private GXUserControl ucDdo_br_encounterid ;
      private GXUserControl ucDdo_br_information_patientno ;
      private GXUserControl ucDdo_br_encounter_department ;
      private GXUserControl ucDdo_br_encounter_enctype ;
      private GXUserControl ucDdo_br_encounter_admitdate ;
      private GXUserControl ucDdo_br_encounter_status ;
      private GXUserControl ucDdo_br_encounter_israndapprove ;
      private GXUserControl ucDdo_br_encounter_israndrecheck ;
      private GXUserControl ucDdo_br_encounter_isupdate ;
      private GXUserControl ucWorkwithplusutilities1 ;
      private GXUserControl ucDvelop_confirmpanel_batchrecheck ;
      private GXUserControl ucDvelop_confirmpanel_batchapprove ;
      private GXUserControl ucDvelop_confirmpanel_deleteencounter ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbavBr_encounter_admitdateoperator ;
      private GXCombobox cmbavBr_encounter_status ;
      private GXCheckbox chkavBr_encounter_israndapprove ;
      private GXCheckbox chkavBr_encounter_israndrecheck ;
      private GXCheckbox chkavBr_encounter_isupdate ;
      private GXCombobox cmbBR_Encounter_Status ;
      private GXCheckbox chkBR_Encounter_IsRandApprove ;
      private GXCheckbox chkBR_Encounter_IsRandRecheck ;
      private GXCheckbox chkBR_Encounter_IsUpdate ;
      private IDataStoreProvider pr_default ;
      private String[] H00142_A360BAS_TenantTenantCode ;
      private bool[] H00142_n360BAS_TenantTenantCode ;
      private bool[] H00142_A202BR_Encounter_IsUpdate ;
      private bool[] H00142_n202BR_Encounter_IsUpdate ;
      private bool[] H00142_A193BR_Encounter_IsRandRecheck ;
      private bool[] H00142_n193BR_Encounter_IsRandRecheck ;
      private bool[] H00142_A192BR_Encounter_IsRandApprove ;
      private bool[] H00142_n192BR_Encounter_IsRandApprove ;
      private short[] H00142_A172BR_Encounter_Status ;
      private bool[] H00142_n172BR_Encounter_Status ;
      private long[] H00142_A85BR_Information_ID ;
      private bool[] H00142_n85BR_Information_ID ;
      private DateTime[] H00142_A91BR_Encounter_AdmitDate ;
      private bool[] H00142_n91BR_Encounter_AdmitDate ;
      private String[] H00142_A90BR_Encounter_ENCType ;
      private bool[] H00142_n90BR_Encounter_ENCType ;
      private String[] H00142_A84BR_Encounter_Department ;
      private bool[] H00142_n84BR_Encounter_Department ;
      private String[] H00142_A36BR_Information_PatientNo ;
      private bool[] H00142_n36BR_Information_PatientNo ;
      private long[] H00142_A19BR_EncounterID ;
      private long[] H00143_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV8HTTPRequest ;
      private GxSimpleCollection<String> AV227tDataPackage ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV45BR_EncounterIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV83BR_Information_PatientNoTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV53BR_Encounter_DepartmentTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV57BR_Encounter_ENCTypeTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV61BR_Encounter_AdmitDateTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV132BR_Encounter_StatusTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV155BR_Encounter_IsRandApproveTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV158BR_Encounter_IsRandRecheckTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV161BR_Encounter_IsUpdateTitleFilterData ;
      private GXWebForm Form ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons AV95DDO_TitleSettingsIcons ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV11GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue AV12GridStateFilterValue ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV9TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private SdtSDT_MicroUserInfo AV229tSDT_MicroUserInfo ;
   }

   public class br_encounterww__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H00142( IGxContext context ,
                                             String AV235BR_EncounterWWDS_1_Br_information_patientno ,
                                             short AV120BR_Encounter_AdmitDateOperator ,
                                             DateTime AV236BR_EncounterWWDS_2_Br_encounter_admitdate ,
                                             DateTime AV237BR_EncounterWWDS_3_Br_encounter_admitdate_to ,
                                             short AV238BR_EncounterWWDS_4_Br_encounter_status ,
                                             bool AV239BR_EncounterWWDS_5_Br_encounter_israndapprove ,
                                             bool AV240BR_EncounterWWDS_6_Br_encounter_israndrecheck ,
                                             bool AV241BR_EncounterWWDS_7_Br_encounter_isupdate ,
                                             String AV221sBR_EncounterID ,
                                             String A36BR_Information_PatientNo ,
                                             DateTime A91BR_Encounter_AdmitDate ,
                                             short A172BR_Encounter_Status ,
                                             bool A192BR_Encounter_IsRandApprove ,
                                             bool A193BR_Encounter_IsRandRecheck ,
                                             bool A202BR_Encounter_IsUpdate ,
                                             long A19BR_EncounterID ,
                                             short AV13OrderedBy ,
                                             bool AV14OrderedDsc ,
                                             String A360BAS_TenantTenantCode ,
                                             String AV223tCurrentCode )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int4 ;
         GXv_int4 = new short [12] ;
         Object[] GXv_Object5 ;
         GXv_Object5 = new Object [2] ;
         String sSelectString ;
         String sFromString ;
         String sOrderString ;
         sSelectString = " T1.[BAS_TenantTenantCode], T1.[BR_Encounter_IsUpdate], T1.[BR_Encounter_IsRandRecheck], T1.[BR_Encounter_IsRandApprove], T1.[BR_Encounter_Status], T1.[BR_Information_ID], T1.[BR_Encounter_AdmitDate], T1.[BR_Encounter_ENCType], T1.[BR_Encounter_Department], T2.[BR_Information_PatientNo], T1.[BR_EncounterID]";
         sFromString = " FROM ([BR_Encounter] T1 WITH (NOLOCK) LEFT JOIN [BR_Information] T2 WITH (NOLOCK) ON T2.[BR_Information_ID] = T1.[BR_Information_ID])";
         sOrderString = "";
         sWhereString = sWhereString + " WHERE (T1.[BAS_TenantTenantCode] = @AV223tCurrentCode)";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV235BR_EncounterWWDS_1_Br_information_patientno)) )
         {
            sWhereString = sWhereString + " and (T2.[BR_Information_PatientNo] like '%' + @lV235BR_EncounterWWDS_1_Br_information_patientno + '%')";
         }
         else
         {
            GXv_int4[1] = 1;
         }
         if ( ( AV120BR_Encounter_AdmitDateOperator == 0 ) && ( ! (DateTime.MinValue==AV236BR_EncounterWWDS_2_Br_encounter_admitdate) ) )
         {
            sWhereString = sWhereString + " and (T1.[BR_Encounter_AdmitDate] >= @AV236BR_EncounterWWDS_2_Br_encounter_admitdate)";
         }
         else
         {
            GXv_int4[2] = 1;
         }
         if ( ( AV120BR_Encounter_AdmitDateOperator == 0 ) && ( ! (DateTime.MinValue==AV237BR_EncounterWWDS_3_Br_encounter_admitdate_to) ) )
         {
            sWhereString = sWhereString + " and (T1.[BR_Encounter_AdmitDate] <= @AV237BR_EncounterWWDS_3_Br_encounter_admitdate_to)";
         }
         else
         {
            GXv_int4[3] = 1;
         }
         if ( ! (0==AV238BR_EncounterWWDS_4_Br_encounter_status) )
         {
            sWhereString = sWhereString + " and (T1.[BR_Encounter_Status] = @AV238BR_EncounterWWDS_4_Br_encounter_status)";
         }
         else
         {
            GXv_int4[4] = 1;
         }
         if ( ! (false==AV239BR_EncounterWWDS_5_Br_encounter_israndapprove) )
         {
            sWhereString = sWhereString + " and (T1.[BR_Encounter_IsRandApprove] = @AV239BR_EncounterWWDS_5_Br_encounter_israndapprove)";
         }
         else
         {
            GXv_int4[5] = 1;
         }
         if ( ! (false==AV240BR_EncounterWWDS_6_Br_encounter_israndrecheck) )
         {
            sWhereString = sWhereString + " and (T1.[BR_Encounter_IsRandRecheck] = @AV240BR_EncounterWWDS_6_Br_encounter_israndrecheck)";
         }
         else
         {
            GXv_int4[6] = 1;
         }
         if ( ! (false==AV241BR_EncounterWWDS_7_Br_encounter_isupdate) )
         {
            sWhereString = sWhereString + " and (T1.[BR_Encounter_IsUpdate] = @AV241BR_EncounterWWDS_7_Br_encounter_isupdate)";
         }
         else
         {
            GXv_int4[7] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV221sBR_EncounterID)) )
         {
            sWhereString = sWhereString + " and (CONVERT( char(18), CAST(T1.[BR_EncounterID] AS decimal(18,0))) like '%' + @lV221sBR_EncounterID + '%')";
         }
         else
         {
            GXv_int4[8] = 1;
         }
         if ( ( AV13OrderedBy == 1 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_EncounterID] DESC";
         }
         else if ( ( AV13OrderedBy == 1 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_EncounterID]";
         }
         else if ( ( AV13OrderedBy == 2 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T2.[BR_Information_PatientNo]";
         }
         else if ( ( AV13OrderedBy == 2 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T2.[BR_Information_PatientNo] DESC";
         }
         else if ( ( AV13OrderedBy == 3 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Encounter_Department]";
         }
         else if ( ( AV13OrderedBy == 3 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Encounter_Department] DESC";
         }
         else if ( ( AV13OrderedBy == 4 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Encounter_ENCType]";
         }
         else if ( ( AV13OrderedBy == 4 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Encounter_ENCType] DESC";
         }
         else if ( ( AV13OrderedBy == 5 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Encounter_AdmitDate]";
         }
         else if ( ( AV13OrderedBy == 5 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Encounter_AdmitDate] DESC";
         }
         else if ( ( AV13OrderedBy == 6 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Encounter_Status]";
         }
         else if ( ( AV13OrderedBy == 6 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Encounter_Status] DESC";
         }
         else if ( ( AV13OrderedBy == 7 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Encounter_IsRandApprove]";
         }
         else if ( ( AV13OrderedBy == 7 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Encounter_IsRandApprove] DESC";
         }
         else if ( ( AV13OrderedBy == 8 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Encounter_IsRandRecheck]";
         }
         else if ( ( AV13OrderedBy == 8 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Encounter_IsRandRecheck] DESC";
         }
         else if ( ( AV13OrderedBy == 9 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Encounter_IsUpdate]";
         }
         else if ( ( AV13OrderedBy == 9 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Encounter_IsUpdate] DESC";
         }
         else if ( true )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_EncounterID]";
         }
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object5[0] = scmdbuf;
         GXv_Object5[1] = GXv_int4;
         return GXv_Object5 ;
      }

      protected Object[] conditional_H00143( IGxContext context ,
                                             String AV235BR_EncounterWWDS_1_Br_information_patientno ,
                                             short AV120BR_Encounter_AdmitDateOperator ,
                                             DateTime AV236BR_EncounterWWDS_2_Br_encounter_admitdate ,
                                             DateTime AV237BR_EncounterWWDS_3_Br_encounter_admitdate_to ,
                                             short AV238BR_EncounterWWDS_4_Br_encounter_status ,
                                             bool AV239BR_EncounterWWDS_5_Br_encounter_israndapprove ,
                                             bool AV240BR_EncounterWWDS_6_Br_encounter_israndrecheck ,
                                             bool AV241BR_EncounterWWDS_7_Br_encounter_isupdate ,
                                             String AV221sBR_EncounterID ,
                                             String A36BR_Information_PatientNo ,
                                             DateTime A91BR_Encounter_AdmitDate ,
                                             short A172BR_Encounter_Status ,
                                             bool A192BR_Encounter_IsRandApprove ,
                                             bool A193BR_Encounter_IsRandRecheck ,
                                             bool A202BR_Encounter_IsUpdate ,
                                             long A19BR_EncounterID ,
                                             short AV13OrderedBy ,
                                             bool AV14OrderedDsc ,
                                             String A360BAS_TenantTenantCode ,
                                             String AV223tCurrentCode )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int6 ;
         GXv_int6 = new short [9] ;
         Object[] GXv_Object7 ;
         GXv_Object7 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM ([BR_Encounter] T1 WITH (NOLOCK) LEFT JOIN [BR_Information] T2 WITH (NOLOCK) ON T2.[BR_Information_ID] = T1.[BR_Information_ID])";
         scmdbuf = scmdbuf + " WHERE (T1.[BAS_TenantTenantCode] = @AV223tCurrentCode)";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV235BR_EncounterWWDS_1_Br_information_patientno)) )
         {
            sWhereString = sWhereString + " and (T2.[BR_Information_PatientNo] like '%' + @lV235BR_EncounterWWDS_1_Br_information_patientno + '%')";
         }
         else
         {
            GXv_int6[1] = 1;
         }
         if ( ( AV120BR_Encounter_AdmitDateOperator == 0 ) && ( ! (DateTime.MinValue==AV236BR_EncounterWWDS_2_Br_encounter_admitdate) ) )
         {
            sWhereString = sWhereString + " and (T1.[BR_Encounter_AdmitDate] >= @AV236BR_EncounterWWDS_2_Br_encounter_admitdate)";
         }
         else
         {
            GXv_int6[2] = 1;
         }
         if ( ( AV120BR_Encounter_AdmitDateOperator == 0 ) && ( ! (DateTime.MinValue==AV237BR_EncounterWWDS_3_Br_encounter_admitdate_to) ) )
         {
            sWhereString = sWhereString + " and (T1.[BR_Encounter_AdmitDate] <= @AV237BR_EncounterWWDS_3_Br_encounter_admitdate_to)";
         }
         else
         {
            GXv_int6[3] = 1;
         }
         if ( ! (0==AV238BR_EncounterWWDS_4_Br_encounter_status) )
         {
            sWhereString = sWhereString + " and (T1.[BR_Encounter_Status] = @AV238BR_EncounterWWDS_4_Br_encounter_status)";
         }
         else
         {
            GXv_int6[4] = 1;
         }
         if ( ! (false==AV239BR_EncounterWWDS_5_Br_encounter_israndapprove) )
         {
            sWhereString = sWhereString + " and (T1.[BR_Encounter_IsRandApprove] = @AV239BR_EncounterWWDS_5_Br_encounter_israndapprove)";
         }
         else
         {
            GXv_int6[5] = 1;
         }
         if ( ! (false==AV240BR_EncounterWWDS_6_Br_encounter_israndrecheck) )
         {
            sWhereString = sWhereString + " and (T1.[BR_Encounter_IsRandRecheck] = @AV240BR_EncounterWWDS_6_Br_encounter_israndrecheck)";
         }
         else
         {
            GXv_int6[6] = 1;
         }
         if ( ! (false==AV241BR_EncounterWWDS_7_Br_encounter_isupdate) )
         {
            sWhereString = sWhereString + " and (T1.[BR_Encounter_IsUpdate] = @AV241BR_EncounterWWDS_7_Br_encounter_isupdate)";
         }
         else
         {
            GXv_int6[7] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV221sBR_EncounterID)) )
         {
            sWhereString = sWhereString + " and (CONVERT( char(18), CAST(T1.[BR_EncounterID] AS decimal(18,0))) like '%' + @lV221sBR_EncounterID + '%')";
         }
         else
         {
            GXv_int6[8] = 1;
         }
         scmdbuf = scmdbuf + sWhereString;
         if ( ( AV13OrderedBy == 1 ) && ! AV14OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 1 ) && ( AV14OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 2 ) && ! AV14OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 2 ) && ( AV14OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 3 ) && ! AV14OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 3 ) && ( AV14OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 4 ) && ! AV14OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 4 ) && ( AV14OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 5 ) && ! AV14OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 5 ) && ( AV14OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 6 ) && ! AV14OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 6 ) && ( AV14OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 7 ) && ! AV14OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 7 ) && ( AV14OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 8 ) && ! AV14OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 8 ) && ( AV14OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 9 ) && ! AV14OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 9 ) && ( AV14OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( true )
         {
            scmdbuf = scmdbuf + "";
         }
         GXv_Object7[0] = scmdbuf;
         GXv_Object7[1] = GXv_int6;
         return GXv_Object7 ;
      }

      public override Object [] getDynamicStatement( int cursor ,
                                                     IGxContext context ,
                                                     Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 0 :
                     return conditional_H00142(context, (String)dynConstraints[0] , (short)dynConstraints[1] , (DateTime)dynConstraints[2] , (DateTime)dynConstraints[3] , (short)dynConstraints[4] , (bool)dynConstraints[5] , (bool)dynConstraints[6] , (bool)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (DateTime)dynConstraints[10] , (short)dynConstraints[11] , (bool)dynConstraints[12] , (bool)dynConstraints[13] , (bool)dynConstraints[14] , (long)dynConstraints[15] , (short)dynConstraints[16] , (bool)dynConstraints[17] , (String)dynConstraints[18] , (String)dynConstraints[19] );
               case 1 :
                     return conditional_H00143(context, (String)dynConstraints[0] , (short)dynConstraints[1] , (DateTime)dynConstraints[2] , (DateTime)dynConstraints[3] , (short)dynConstraints[4] , (bool)dynConstraints[5] , (bool)dynConstraints[6] , (bool)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (DateTime)dynConstraints[10] , (short)dynConstraints[11] , (bool)dynConstraints[12] , (bool)dynConstraints[13] , (bool)dynConstraints[14] , (long)dynConstraints[15] , (short)dynConstraints[16] , (bool)dynConstraints[17] , (String)dynConstraints[18] , (String)dynConstraints[19] );
         }
         return base.getDynamicStatement(cursor, context, dynConstraints);
      }

      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmH00142 ;
          prmH00142 = new Object[] {
          new Object[] {"@AV223tCurrentCode",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV235BR_EncounterWWDS_1_Br_information_patientno",SqlDbType.NVarChar,2000,0} ,
          new Object[] {"@AV236BR_EncounterWWDS_2_Br_encounter_admitdate",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV237BR_EncounterWWDS_3_Br_encounter_admitdate_to",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV238BR_EncounterWWDS_4_Br_encounter_status",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV239BR_EncounterWWDS_5_Br_encounter_israndapprove",SqlDbType.Bit,4,0} ,
          new Object[] {"@AV240BR_EncounterWWDS_6_Br_encounter_israndrecheck",SqlDbType.Bit,4,0} ,
          new Object[] {"@AV241BR_EncounterWWDS_7_Br_encounter_isupdate",SqlDbType.Bit,4,0} ,
          new Object[] {"@lV221sBR_EncounterID",SqlDbType.NVarChar,50,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH00143 ;
          prmH00143 = new Object[] {
          new Object[] {"@AV223tCurrentCode",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV235BR_EncounterWWDS_1_Br_information_patientno",SqlDbType.NVarChar,2000,0} ,
          new Object[] {"@AV236BR_EncounterWWDS_2_Br_encounter_admitdate",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV237BR_EncounterWWDS_3_Br_encounter_admitdate_to",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV238BR_EncounterWWDS_4_Br_encounter_status",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV239BR_EncounterWWDS_5_Br_encounter_israndapprove",SqlDbType.Bit,4,0} ,
          new Object[] {"@AV240BR_EncounterWWDS_6_Br_encounter_israndrecheck",SqlDbType.Bit,4,0} ,
          new Object[] {"@AV241BR_EncounterWWDS_7_Br_encounter_isupdate",SqlDbType.Bit,4,0} ,
          new Object[] {"@lV221sBR_EncounterID",SqlDbType.NVarChar,50,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H00142", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00142,11,0,true,false )
             ,new CursorDef("H00143", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00143,1,0,true,false )
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
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((bool[]) buf[2])[0] = rslt.getBool(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((bool[]) buf[4])[0] = rslt.getBool(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((bool[]) buf[6])[0] = rslt.getBool(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((short[]) buf[8])[0] = rslt.getShort(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((long[]) buf[10])[0] = rslt.getLong(6) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(6);
                ((DateTime[]) buf[12])[0] = rslt.getGXDate(7) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(7);
                ((String[]) buf[14])[0] = rslt.getVarchar(8) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(8);
                ((String[]) buf[16])[0] = rslt.getVarchar(9) ;
                ((bool[]) buf[17])[0] = rslt.wasNull(9);
                ((String[]) buf[18])[0] = rslt.getVarchar(10) ;
                ((bool[]) buf[19])[0] = rslt.wasNull(10);
                ((long[]) buf[20])[0] = rslt.getLong(11) ;
                return;
             case 1 :
                ((long[]) buf[0])[0] = rslt.getLong(1) ;
                return;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       short sIdx ;
       switch ( cursor )
       {
             case 0 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[12]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[13]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[14]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[15]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[16]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (bool)parms[17]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (bool)parms[18]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (bool)parms[19]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[20]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[21]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[22]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[23]);
                }
                return;
             case 1 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[9]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[10]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[11]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[12]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[13]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (bool)parms[14]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (bool)parms[15]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (bool)parms[16]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[17]);
                }
                return;
       }
    }

 }

}
