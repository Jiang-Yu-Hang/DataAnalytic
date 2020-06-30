/*
               File: BR_EncounterListww
        Description: 就诊列表
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:17:17.68
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
   public class br_encounterlistww : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public br_encounterlistww( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_encounterlistww( IGxContext context )
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
         cmbavTview_ne_status = new GXCombobox();
         chkavView_new_encounter2view_ne_israndapprove = new GXCheckbox();
         chkavView_new_encounter2view_ne_israndrecheck = new GXCheckbox();
         chkavView_new_encounter2view_ne_isupdate = new GXCheckbox();
         cmbView_New_Encounter2view_NE_Status = new GXCombobox();
         chkView_New_Encounter2view_NE_IsRandApprove = new GXCheckbox();
         chkView_New_Encounter2view_NE_IsRandRecheck = new GXCheckbox();
         chkView_New_Encounter2view_NE_IsUpdate = new GXCheckbox();
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
               nRC_GXsfl_76 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               nGXsfl_76_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
               sGXsfl_76_idx = GetNextPar( );
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
               AV15BR_Information_PatientNo = GetNextPar( );
               AV20sBR_EncounterID = GetNextPar( );
               AV21view_NE_AdmitDate = context.localUtil.ParseDateParm( GetNextPar( ));
               AV22endview_NE_AdmitDate = context.localUtil.ParseDateParm( GetNextPar( ));
               AV23tview_NE_Status = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV101View_New_Encounter2view_NE_IsRandApprove = StringUtil.StrToBool( GetNextPar( ));
               AV102View_New_Encounter2view_NE_IsRandRecheck = StringUtil.StrToBool( GetNextPar( ));
               AV103View_New_Encounter2view_NE_IsUpdate = StringUtil.StrToBool( GetNextPar( ));
               AV13OrderedBy = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV14OrderedDsc = StringUtil.StrToBool( GetNextPar( ));
               AV25TFView_New_Encounter2view_NE_EncounterID = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV26TFView_New_Encounter2view_NE_EncounterID_To = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV67TFView_New_Encounter2view_NE_Information_PatientNo = GetNextPar( );
               AV68TFView_New_Encounter2view_NE_Information_PatientNo_Sel = GetNextPar( );
               AV33TFView_New_Encounter2view_NE_Departmentadm = GetNextPar( );
               AV34TFView_New_Encounter2view_NE_Departmentadm_Sel = GetNextPar( );
               AV29TFView_New_Encounter2view_NE_ENCType = GetNextPar( );
               AV30TFView_New_Encounter2view_NE_ENCType_Sel = GetNextPar( );
               AV106TFView_New_Encounter2view_NE_IsRandApprove_Sel = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV107TFView_New_Encounter2view_NE_IsRandRecheck_Sel = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV108TFView_New_Encounter2view_NE_IsUpdate_Sel = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV85tCurrentCode = GetNextPar( );
               AV27ddo_View_New_Encounter2view_NE_EncounterIDTitleControlIdToReplace = GetNextPar( );
               AV69ddo_View_New_Encounter2view_NE_Information_PatientNoTitleControlIdToReplace = GetNextPar( );
               AV35ddo_View_New_Encounter2view_NE_DepartmentadmTitleControlIdToReplace = GetNextPar( );
               AV31ddo_View_New_Encounter2view_NE_ENCTypeTitleControlIdToReplace = GetNextPar( );
               AV45ddo_View_New_Encounter2view_NE_StatusTitleControlIdToReplace = GetNextPar( );
               AV53ddo_View_New_Encounter2view_NE_IsRandApproveTitleControlIdToReplace = GetNextPar( );
               AV49ddo_View_New_Encounter2view_NE_IsRandRecheckTitleControlIdToReplace = GetNextPar( );
               AV57ddo_View_New_Encounter2view_NE_IsUpdateTitleControlIdToReplace = GetNextPar( );
               ajax_req_read_hidden_sdt(GetNextPar( ), AV105TFView_New_Encounter2view_NE_Status_Sels);
               AV111Pgmname = GetNextPar( );
               AV87IsInsert = StringUtil.StrToBool( GetNextPar( ));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid_refresh( subGrid_Rows, AV15BR_Information_PatientNo, AV20sBR_EncounterID, AV21view_NE_AdmitDate, AV22endview_NE_AdmitDate, AV23tview_NE_Status, AV101View_New_Encounter2view_NE_IsRandApprove, AV102View_New_Encounter2view_NE_IsRandRecheck, AV103View_New_Encounter2view_NE_IsUpdate, AV13OrderedBy, AV14OrderedDsc, AV25TFView_New_Encounter2view_NE_EncounterID, AV26TFView_New_Encounter2view_NE_EncounterID_To, AV67TFView_New_Encounter2view_NE_Information_PatientNo, AV68TFView_New_Encounter2view_NE_Information_PatientNo_Sel, AV33TFView_New_Encounter2view_NE_Departmentadm, AV34TFView_New_Encounter2view_NE_Departmentadm_Sel, AV29TFView_New_Encounter2view_NE_ENCType, AV30TFView_New_Encounter2view_NE_ENCType_Sel, AV106TFView_New_Encounter2view_NE_IsRandApprove_Sel, AV107TFView_New_Encounter2view_NE_IsRandRecheck_Sel, AV108TFView_New_Encounter2view_NE_IsUpdate_Sel, AV85tCurrentCode, AV27ddo_View_New_Encounter2view_NE_EncounterIDTitleControlIdToReplace, AV69ddo_View_New_Encounter2view_NE_Information_PatientNoTitleControlIdToReplace, AV35ddo_View_New_Encounter2view_NE_DepartmentadmTitleControlIdToReplace, AV31ddo_View_New_Encounter2view_NE_ENCTypeTitleControlIdToReplace, AV45ddo_View_New_Encounter2view_NE_StatusTitleControlIdToReplace, AV53ddo_View_New_Encounter2view_NE_IsRandApproveTitleControlIdToReplace, AV49ddo_View_New_Encounter2view_NE_IsRandRecheckTitleControlIdToReplace, AV57ddo_View_New_Encounter2view_NE_IsUpdateTitleControlIdToReplace, AV105TFView_New_Encounter2view_NE_Status_Sels, AV111Pgmname, AV87IsInsert) ;
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
         PAAL2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            STARTAL2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?202022815171822", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_encounterlistww.aspx") +"\">") ;
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
         GxWebStd.gx_hidden_field( context, "GXH_vBR_INFORMATION_PATIENTNO", AV15BR_Information_PatientNo);
         GxWebStd.gx_hidden_field( context, "GXH_vSBR_ENCOUNTERID", AV20sBR_EncounterID);
         GxWebStd.gx_hidden_field( context, "GXH_vVIEW_NE_ADMITDATE", context.localUtil.Format(AV21view_NE_AdmitDate, "9999/99/99"));
         GxWebStd.gx_hidden_field( context, "GXH_vENDVIEW_NE_ADMITDATE", context.localUtil.Format(AV22endview_NE_AdmitDate, "9999/99/99"));
         GxWebStd.gx_hidden_field( context, "GXH_vTVIEW_NE_STATUS", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV23tview_NE_Status), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE", StringUtil.BoolToStr( AV101View_New_Encounter2view_NE_IsRandApprove));
         GxWebStd.gx_hidden_field( context, "GXH_vVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK", StringUtil.BoolToStr( AV102View_New_Encounter2view_NE_IsRandRecheck));
         GxWebStd.gx_hidden_field( context, "GXH_vVIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE", StringUtil.BoolToStr( AV103View_New_Encounter2view_NE_IsUpdate));
         GxWebStd.gx_hidden_field( context, "GXH_vORDEREDBY", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13OrderedBy), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vORDEREDDSC", StringUtil.BoolToStr( AV14OrderedDsc));
         GxWebStd.gx_hidden_field( context, "GXH_vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV25TFView_New_Encounter2view_NE_EncounterID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID_TO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV26TFView_New_Encounter2view_NE_EncounterID_To), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFVIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO", AV67TFView_New_Encounter2view_NE_Information_PatientNo);
         GxWebStd.gx_hidden_field( context, "GXH_vTFVIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO_SEL", AV68TFView_New_Encounter2view_NE_Information_PatientNo_Sel);
         GxWebStd.gx_hidden_field( context, "GXH_vTFVIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM", AV33TFView_New_Encounter2view_NE_Departmentadm);
         GxWebStd.gx_hidden_field( context, "GXH_vTFVIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM_SEL", AV34TFView_New_Encounter2view_NE_Departmentadm_Sel);
         GxWebStd.gx_hidden_field( context, "GXH_vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE", AV29TFView_New_Encounter2view_NE_ENCType);
         GxWebStd.gx_hidden_field( context, "GXH_vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE_SEL", AV30TFView_New_Encounter2view_NE_ENCType_Sel);
         GxWebStd.gx_hidden_field( context, "GXH_vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE_SEL", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV106TFView_New_Encounter2view_NE_IsRandApprove_Sel), 1, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK_SEL", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV107TFView_New_Encounter2view_NE_IsRandRecheck_Sel), 1, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE_SEL", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV108TFView_New_Encounter2view_NE_IsUpdate_Sel), 1, 0, ".", "")));
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_76", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_76), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDCURRENTPAGE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV72GridCurrentPage), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDPAGECOUNT", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV73GridPageCount), 10, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vDDO_TITLESETTINGSICONS", AV70DDO_TitleSettingsIcons);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vDDO_TITLESETTINGSICONS", AV70DDO_TitleSettingsIcons);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vVIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERIDTITLEFILTERDATA", AV24View_New_Encounter2view_NE_EncounterIDTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vVIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERIDTITLEFILTERDATA", AV24View_New_Encounter2view_NE_EncounterIDTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vVIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNOTITLEFILTERDATA", AV66View_New_Encounter2view_NE_Information_PatientNoTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vVIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNOTITLEFILTERDATA", AV66View_New_Encounter2view_NE_Information_PatientNoTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vVIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADMTITLEFILTERDATA", AV32View_New_Encounter2view_NE_DepartmentadmTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vVIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADMTITLEFILTERDATA", AV32View_New_Encounter2view_NE_DepartmentadmTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vVIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPETITLEFILTERDATA", AV28View_New_Encounter2view_NE_ENCTypeTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vVIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPETITLEFILTERDATA", AV28View_New_Encounter2view_NE_ENCTypeTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vVIEW_NEW_ENCOUNTER2VIEW_NE_STATUSTITLEFILTERDATA", AV42View_New_Encounter2view_NE_StatusTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vVIEW_NEW_ENCOUNTER2VIEW_NE_STATUSTITLEFILTERDATA", AV42View_New_Encounter2view_NE_StatusTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVETITLEFILTERDATA", AV50View_New_Encounter2view_NE_IsRandApproveTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVETITLEFILTERDATA", AV50View_New_Encounter2view_NE_IsRandApproveTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECKTITLEFILTERDATA", AV46View_New_Encounter2view_NE_IsRandRecheckTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECKTITLEFILTERDATA", AV46View_New_Encounter2view_NE_IsRandRecheckTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vVIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATETITLEFILTERDATA", AV54View_New_Encounter2view_NE_IsUpdateTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vVIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATETITLEFILTERDATA", AV54View_New_Encounter2view_NE_IsUpdateTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vTFVIEW_NEW_ENCOUNTER2VIEW_NE_STATUS_SELS", AV105TFView_New_Encounter2view_NE_Status_Sels);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vTFVIEW_NEW_ENCOUNTER2VIEW_NE_STATUS_SELS", AV105TFView_New_Encounter2view_NE_Status_Sels);
         }
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV111Pgmname));
         GxWebStd.gx_hidden_field( context, "gxhash_vPGMNAME", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV111Pgmname, "")), context));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vTALLBR_ENCOUNTERID", AV93tAllBR_EncounterID);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vTALLBR_ENCOUNTERID", AV93tAllBR_EncounterID);
         }
         GxWebStd.gx_hidden_field( context, "vVIEW_NE_STATUS", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV100view_NE_Status), 4, 0, ".", "")));
         GxWebStd.gx_boolean_hidden_field( context, "vISINSERT", AV87IsInsert);
         GxWebStd.gx_hidden_field( context, "gxhash_vISINSERT", GetSecureSignedToken( "", AV87IsInsert, context));
         GxWebStd.gx_hidden_field( context, "vTCURRENTCODE", AV85tCurrentCode);
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
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID_Caption", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_encounterid_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID_Tooltip", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_encounterid_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID_Cls", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_encounterid_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID_Filteredtext_set", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_encounterid_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID_Filteredtextto_set", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_encounterid_Filteredtextto_set));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID_Dropdownoptionstype", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_encounterid_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_encounterid_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID_Includesortasc", StringUtil.BoolToStr( Ddo_view_new_encounter2view_ne_encounterid_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID_Includesortdsc", StringUtil.BoolToStr( Ddo_view_new_encounter2view_ne_encounterid_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID_Sortedstatus", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_encounterid_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID_Includefilter", StringUtil.BoolToStr( Ddo_view_new_encounter2view_ne_encounterid_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID_Filtertype", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_encounterid_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID_Filterisrange", StringUtil.BoolToStr( Ddo_view_new_encounter2view_ne_encounterid_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID_Includedatalist", StringUtil.BoolToStr( Ddo_view_new_encounter2view_ne_encounterid_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID_Sortasc", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_encounterid_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID_Sortdsc", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_encounterid_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID_Cleanfilter", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_encounterid_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID_Rangefilterfrom", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_encounterid_Rangefilterfrom));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID_Rangefilterto", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_encounterid_Rangefilterto));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID_Searchbuttontext", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_encounterid_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO_Caption", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_information_patientno_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO_Tooltip", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_information_patientno_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO_Cls", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_information_patientno_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO_Filteredtext_set", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_information_patientno_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO_Selectedvalue_set", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_information_patientno_Selectedvalue_set));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO_Dropdownoptionstype", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_information_patientno_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_information_patientno_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO_Includesortasc", StringUtil.BoolToStr( Ddo_view_new_encounter2view_ne_information_patientno_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO_Includesortdsc", StringUtil.BoolToStr( Ddo_view_new_encounter2view_ne_information_patientno_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO_Sortedstatus", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_information_patientno_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO_Includefilter", StringUtil.BoolToStr( Ddo_view_new_encounter2view_ne_information_patientno_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO_Filtertype", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_information_patientno_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO_Filterisrange", StringUtil.BoolToStr( Ddo_view_new_encounter2view_ne_information_patientno_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO_Includedatalist", StringUtil.BoolToStr( Ddo_view_new_encounter2view_ne_information_patientno_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO_Datalisttype", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_information_patientno_Datalisttype));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO_Datalistproc", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_information_patientno_Datalistproc));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO_Datalistupdateminimumcharacters", StringUtil.LTrim( StringUtil.NToC( (decimal)(Ddo_view_new_encounter2view_ne_information_patientno_Datalistupdateminimumcharacters), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO_Sortasc", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_information_patientno_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO_Sortdsc", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_information_patientno_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO_Loadingdata", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_information_patientno_Loadingdata));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO_Cleanfilter", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_information_patientno_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO_Noresultsfound", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_information_patientno_Noresultsfound));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO_Searchbuttontext", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_information_patientno_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM_Caption", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_departmentadm_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM_Tooltip", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_departmentadm_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM_Cls", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_departmentadm_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM_Filteredtext_set", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_departmentadm_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM_Selectedvalue_set", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_departmentadm_Selectedvalue_set));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM_Dropdownoptionstype", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_departmentadm_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_departmentadm_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM_Includesortasc", StringUtil.BoolToStr( Ddo_view_new_encounter2view_ne_departmentadm_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM_Includesortdsc", StringUtil.BoolToStr( Ddo_view_new_encounter2view_ne_departmentadm_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM_Sortedstatus", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_departmentadm_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM_Includefilter", StringUtil.BoolToStr( Ddo_view_new_encounter2view_ne_departmentadm_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM_Filtertype", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_departmentadm_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM_Filterisrange", StringUtil.BoolToStr( Ddo_view_new_encounter2view_ne_departmentadm_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM_Includedatalist", StringUtil.BoolToStr( Ddo_view_new_encounter2view_ne_departmentadm_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM_Datalisttype", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_departmentadm_Datalisttype));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM_Datalistproc", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_departmentadm_Datalistproc));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM_Datalistupdateminimumcharacters", StringUtil.LTrim( StringUtil.NToC( (decimal)(Ddo_view_new_encounter2view_ne_departmentadm_Datalistupdateminimumcharacters), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM_Sortasc", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_departmentadm_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM_Sortdsc", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_departmentadm_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM_Loadingdata", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_departmentadm_Loadingdata));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM_Cleanfilter", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_departmentadm_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM_Noresultsfound", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_departmentadm_Noresultsfound));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM_Searchbuttontext", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_departmentadm_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE_Caption", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_enctype_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE_Tooltip", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_enctype_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE_Cls", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_enctype_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE_Filteredtext_set", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_enctype_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE_Selectedvalue_set", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_enctype_Selectedvalue_set));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE_Dropdownoptionstype", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_enctype_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_enctype_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE_Includesortasc", StringUtil.BoolToStr( Ddo_view_new_encounter2view_ne_enctype_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE_Includesortdsc", StringUtil.BoolToStr( Ddo_view_new_encounter2view_ne_enctype_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE_Sortedstatus", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_enctype_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE_Includefilter", StringUtil.BoolToStr( Ddo_view_new_encounter2view_ne_enctype_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE_Filtertype", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_enctype_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE_Filterisrange", StringUtil.BoolToStr( Ddo_view_new_encounter2view_ne_enctype_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE_Includedatalist", StringUtil.BoolToStr( Ddo_view_new_encounter2view_ne_enctype_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE_Datalisttype", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_enctype_Datalisttype));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE_Datalistproc", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_enctype_Datalistproc));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE_Datalistupdateminimumcharacters", StringUtil.LTrim( StringUtil.NToC( (decimal)(Ddo_view_new_encounter2view_ne_enctype_Datalistupdateminimumcharacters), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE_Sortasc", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_enctype_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE_Sortdsc", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_enctype_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE_Loadingdata", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_enctype_Loadingdata));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE_Cleanfilter", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_enctype_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE_Noresultsfound", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_enctype_Noresultsfound));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE_Searchbuttontext", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_enctype_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_STATUS_Caption", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_status_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_STATUS_Tooltip", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_status_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_STATUS_Cls", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_status_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_STATUS_Selectedvalue_set", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_status_Selectedvalue_set));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_STATUS_Dropdownoptionstype", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_status_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_STATUS_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_status_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_STATUS_Includesortasc", StringUtil.BoolToStr( Ddo_view_new_encounter2view_ne_status_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_STATUS_Includesortdsc", StringUtil.BoolToStr( Ddo_view_new_encounter2view_ne_status_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_STATUS_Sortedstatus", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_status_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_STATUS_Includefilter", StringUtil.BoolToStr( Ddo_view_new_encounter2view_ne_status_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_STATUS_Includedatalist", StringUtil.BoolToStr( Ddo_view_new_encounter2view_ne_status_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_STATUS_Datalisttype", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_status_Datalisttype));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_STATUS_Allowmultipleselection", StringUtil.BoolToStr( Ddo_view_new_encounter2view_ne_status_Allowmultipleselection));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_STATUS_Datalistfixedvalues", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_status_Datalistfixedvalues));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_STATUS_Sortasc", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_status_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_STATUS_Sortdsc", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_status_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_STATUS_Cleanfilter", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_status_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_STATUS_Searchbuttontext", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_status_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE_Caption", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_israndapprove_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE_Tooltip", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_israndapprove_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE_Cls", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_israndapprove_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE_Selectedvalue_set", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_israndapprove_Selectedvalue_set));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE_Dropdownoptionstype", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_israndapprove_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_israndapprove_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE_Includesortasc", StringUtil.BoolToStr( Ddo_view_new_encounter2view_ne_israndapprove_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE_Includesortdsc", StringUtil.BoolToStr( Ddo_view_new_encounter2view_ne_israndapprove_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE_Sortedstatus", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_israndapprove_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE_Includefilter", StringUtil.BoolToStr( Ddo_view_new_encounter2view_ne_israndapprove_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE_Includedatalist", StringUtil.BoolToStr( Ddo_view_new_encounter2view_ne_israndapprove_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE_Datalisttype", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_israndapprove_Datalisttype));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE_Datalistfixedvalues", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_israndapprove_Datalistfixedvalues));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE_Sortasc", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_israndapprove_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE_Sortdsc", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_israndapprove_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE_Cleanfilter", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_israndapprove_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE_Searchbuttontext", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_israndapprove_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK_Caption", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_israndrecheck_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK_Tooltip", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_israndrecheck_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK_Cls", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_israndrecheck_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK_Selectedvalue_set", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_israndrecheck_Selectedvalue_set));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK_Dropdownoptionstype", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_israndrecheck_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_israndrecheck_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK_Includesortasc", StringUtil.BoolToStr( Ddo_view_new_encounter2view_ne_israndrecheck_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK_Includesortdsc", StringUtil.BoolToStr( Ddo_view_new_encounter2view_ne_israndrecheck_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK_Sortedstatus", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_israndrecheck_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK_Includefilter", StringUtil.BoolToStr( Ddo_view_new_encounter2view_ne_israndrecheck_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK_Includedatalist", StringUtil.BoolToStr( Ddo_view_new_encounter2view_ne_israndrecheck_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK_Datalisttype", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_israndrecheck_Datalisttype));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK_Datalistfixedvalues", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_israndrecheck_Datalistfixedvalues));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK_Sortasc", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_israndrecheck_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK_Sortdsc", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_israndrecheck_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK_Cleanfilter", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_israndrecheck_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK_Searchbuttontext", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_israndrecheck_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE_Caption", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_isupdate_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE_Tooltip", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_isupdate_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE_Cls", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_isupdate_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE_Selectedvalue_set", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_isupdate_Selectedvalue_set));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE_Dropdownoptionstype", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_isupdate_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_isupdate_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE_Includesortasc", StringUtil.BoolToStr( Ddo_view_new_encounter2view_ne_isupdate_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE_Includesortdsc", StringUtil.BoolToStr( Ddo_view_new_encounter2view_ne_isupdate_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE_Sortedstatus", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_isupdate_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE_Includefilter", StringUtil.BoolToStr( Ddo_view_new_encounter2view_ne_isupdate_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE_Includedatalist", StringUtil.BoolToStr( Ddo_view_new_encounter2view_ne_isupdate_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE_Datalisttype", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_isupdate_Datalisttype));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE_Datalistfixedvalues", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_isupdate_Datalistfixedvalues));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE_Sortasc", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_isupdate_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE_Sortdsc", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_isupdate_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE_Cleanfilter", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_isupdate_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE_Searchbuttontext", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_isupdate_Searchbuttontext));
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
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID_Activeeventkey", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_encounterid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID_Filteredtext_get", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_encounterid_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID_Filteredtextto_get", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_encounterid_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO_Activeeventkey", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_information_patientno_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO_Filteredtext_get", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_information_patientno_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO_Selectedvalue_get", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_information_patientno_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM_Activeeventkey", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_departmentadm_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM_Filteredtext_get", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_departmentadm_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM_Selectedvalue_get", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_departmentadm_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE_Activeeventkey", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_enctype_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE_Filteredtext_get", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_enctype_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE_Selectedvalue_get", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_enctype_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_STATUS_Activeeventkey", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_status_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_STATUS_Selectedvalue_get", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_status_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE_Activeeventkey", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_israndapprove_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE_Selectedvalue_get", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_israndapprove_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK_Activeeventkey", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_israndrecheck_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK_Selectedvalue_get", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_israndrecheck_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE_Activeeventkey", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_isupdate_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE_Selectedvalue_get", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_isupdate_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_DELETEENCOUNTER_Result", StringUtil.RTrim( Dvelop_confirmpanel_deleteencounter_Result));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_BATCHAPPROVE_Result", StringUtil.RTrim( Dvelop_confirmpanel_batchapprove_Result));
         GxWebStd.gx_hidden_field( context, "DVELOP_CONFIRMPANEL_BATCHRECHECK_Result", StringUtil.RTrim( Dvelop_confirmpanel_batchrecheck_Result));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID_Activeeventkey", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_encounterid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID_Filteredtext_get", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_encounterid_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID_Filteredtextto_get", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_encounterid_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO_Activeeventkey", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_information_patientno_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO_Filteredtext_get", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_information_patientno_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO_Selectedvalue_get", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_information_patientno_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM_Activeeventkey", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_departmentadm_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM_Filteredtext_get", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_departmentadm_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM_Selectedvalue_get", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_departmentadm_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE_Activeeventkey", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_enctype_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE_Filteredtext_get", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_enctype_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE_Selectedvalue_get", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_enctype_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_STATUS_Activeeventkey", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_status_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_STATUS_Selectedvalue_get", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_status_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE_Activeeventkey", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_israndapprove_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE_Selectedvalue_get", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_israndapprove_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK_Activeeventkey", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_israndrecheck_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK_Selectedvalue_get", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_israndrecheck_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE_Activeeventkey", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_isupdate_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE_Selectedvalue_get", StringUtil.RTrim( Ddo_view_new_encounter2view_ne_isupdate_Selectedvalue_get));
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
            WEAL2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVTAL2( ) ;
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
         return formatLink("br_encounterlistww.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "BR_EncounterListww" ;
      }

      public override String GetPgmdesc( )
      {
         return "就诊列表" ;
      }

      protected void WBAL0( )
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-2", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavBr_information_patientno_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavBr_information_patientno_Internalname, "患者编号", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'" + sGXsfl_76_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBr_information_patientno_Internalname, AV15BR_Information_PatientNo, StringUtil.RTrim( context.localUtil.Format( AV15BR_Information_PatientNo, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,22);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_information_patientno_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavBr_information_patientno_Enabled, 0, "text", "", 80, "chr", 1, "row", 2000, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_EncounterListww.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-2", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavSbr_encounterid_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavSbr_encounterid_Internalname, "就诊序号", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 26,'',false,'" + sGXsfl_76_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavSbr_encounterid_Internalname, AV20sBR_EncounterID, StringUtil.RTrim( context.localUtil.Format( AV20sBR_EncounterID, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,26);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavSbr_encounterid_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavSbr_encounterid_Enabled, 0, "text", "", 50, "chr", 1, "row", 50, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_EncounterListww.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavView_ne_admitdate_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavView_ne_admitdate_Internalname, "就诊/入院时间", "col-sm-3 AttributeDateLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 30,'',false,'" + sGXsfl_76_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavView_ne_admitdate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavView_ne_admitdate_Internalname, context.localUtil.Format(AV21view_NE_AdmitDate, "9999/99/99"), context.localUtil.Format( AV21view_NE_AdmitDate, "9999/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',0,24,'chs',false,1);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,30);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavView_ne_admitdate_Jsonclick, 0, "AttributeDate", "", "", "", "", 1, edtavView_ne_admitdate_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_EncounterListww.htm");
            GxWebStd.gx_bitmap( context, edtavView_ne_admitdate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtavView_ne_admitdate_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_EncounterListww.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavEndview_ne_admitdate_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavEndview_ne_admitdate_Internalname, "到", "col-sm-3 AttributeDateLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'" + sGXsfl_76_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavEndview_ne_admitdate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavEndview_ne_admitdate_Internalname, context.localUtil.Format(AV22endview_NE_AdmitDate, "9999/99/99"), context.localUtil.Format( AV22endview_NE_AdmitDate, "9999/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',0,24,'chs',false,1);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,34);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavEndview_ne_admitdate_Jsonclick, 0, "AttributeDate", "", "", "", "", 1, edtavEndview_ne_admitdate_Enabled, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_EncounterListww.htm");
            GxWebStd.gx_bitmap( context, edtavEndview_ne_admitdate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(edtavEndview_ne_admitdate_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_EncounterListww.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbavTview_ne_status_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavTview_ne_status_Internalname, "审批状态", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'" + sGXsfl_76_idx + "',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavTview_ne_status, cmbavTview_ne_status_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(AV23tview_NE_Status), 4, 0)), 1, cmbavTview_ne_status_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", 1, cmbavTview_ne_status.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,39);\"", "", true, "HLP_BR_EncounterListww.htm");
            cmbavTview_ne_status.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV23tview_NE_Status), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavTview_ne_status_Internalname, "Values", (String)(cmbavTview_ne_status.ToJavascriptSource()), true);
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+chkavView_new_encounter2view_ne_israndapprove_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkavView_new_encounter2view_ne_israndapprove_Internalname, "是否初审抽查", "col-sm-3 AttributeCheckBoxLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 47,'',false,'" + sGXsfl_76_idx + "',0)\"";
            ClassString = "AttributeCheckBox";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavView_new_encounter2view_ne_israndapprove_Internalname, StringUtil.BoolToStr( AV101View_New_Encounter2view_NE_IsRandApprove), "", "是否初审抽查", 1, chkavView_new_encounter2view_ne_israndapprove.Enabled, "true", "", StyleString, ClassString, "", "", TempTags+" onclick=\"gx.fn.checkboxClick(47, this, 'true', 'false');gx.evt.onchange(this, event);\" ");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+chkavView_new_encounter2view_ne_israndrecheck_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkavView_new_encounter2view_ne_israndrecheck_Internalname, "是否复审抽查", "col-sm-3 AttributeCheckBoxLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 51,'',false,'" + sGXsfl_76_idx + "',0)\"";
            ClassString = "AttributeCheckBox";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavView_new_encounter2view_ne_israndrecheck_Internalname, StringUtil.BoolToStr( AV102View_New_Encounter2view_NE_IsRandRecheck), "", "是否复审抽查", 1, chkavView_new_encounter2view_ne_israndrecheck.Enabled, "true", "", StyleString, ClassString, "", "", TempTags+" onclick=\"gx.fn.checkboxClick(51, this, 'true', 'false');gx.evt.onchange(this, event);\" ");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-4", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+chkavView_new_encounter2view_ne_isupdate_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, chkavView_new_encounter2view_ne_isupdate_Internalname, "是否修改", "col-sm-3 AttributeCheckBoxLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Check box */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 55,'',false,'" + sGXsfl_76_idx + "',0)\"";
            ClassString = "AttributeCheckBox";
            StyleString = "";
            GxWebStd.gx_checkbox_ctrl( context, chkavView_new_encounter2view_ne_isupdate_Internalname, StringUtil.BoolToStr( AV103View_New_Encounter2view_NE_IsUpdate), "", "是否修改", 1, chkavView_new_encounter2view_ne_isupdate.Enabled, "true", "", StyleString, ClassString, "", "", TempTags+" onclick=\"gx.fn.checkboxClick(55, this, 'true', 'false');gx.evt.onchange(this, event);\" ");
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
            wb_table1_63_AL2( true) ;
         }
         else
         {
            wb_table1_63_AL2( false) ;
         }
         return  ;
      }

      protected void wb_table1_63_AL2e( bool wbgen )
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
               context.WriteHtmlText( "<div id=\""+"GridContainer"+"DivS\" data-gxgridid=\"76\">") ;
               sStyleString = "";
               GxWebStd.gx_table_start( context, subGrid_Internalname, subGrid_Internalname, "", "GridWithPaginationBar GridWithBorderColor WorkWith", 0, "", "", 1, 2, sStyleString, "", "", 0);
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
               if ( edtView_New_Encounter2view_NE_EncounterID_Titleformat == 0 )
               {
                  context.SendWebValue( edtView_New_Encounter2view_NE_EncounterID_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtView_New_Encounter2view_NE_EncounterID_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtView_New_Encounter2view_NE_Information_PatientNo_Titleformat == 0 )
               {
                  context.SendWebValue( edtView_New_Encounter2view_NE_Information_PatientNo_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtView_New_Encounter2view_NE_Information_PatientNo_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "患者编号") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtView_New_Encounter2view_NE_Departmentadm_Titleformat == 0 )
               {
                  context.SendWebValue( edtView_New_Encounter2view_NE_Departmentadm_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtView_New_Encounter2view_NE_Departmentadm_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtView_New_Encounter2view_NE_ENCType_Titleformat == 0 )
               {
                  context.SendWebValue( edtView_New_Encounter2view_NE_ENCType_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtView_New_Encounter2view_NE_ENCType_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "就诊/入院时间") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "view_NE_Admit Date") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( cmbView_New_Encounter2view_NE_Status_Titleformat == 0 )
               {
                  context.SendWebValue( cmbView_New_Encounter2view_NE_Status.Title.Text) ;
               }
               else
               {
                  context.WriteHtmlText( cmbView_New_Encounter2view_NE_Status.Title.Text) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"AttributeCheckBox"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( chkView_New_Encounter2view_NE_IsRandApprove_Titleformat == 0 )
               {
                  context.SendWebValue( chkView_New_Encounter2view_NE_IsRandApprove.Title.Text) ;
               }
               else
               {
                  context.WriteHtmlText( chkView_New_Encounter2view_NE_IsRandApprove.Title.Text) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"AttributeCheckBox"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( chkView_New_Encounter2view_NE_IsRandRecheck_Titleformat == 0 )
               {
                  context.SendWebValue( chkView_New_Encounter2view_NE_IsRandRecheck.Title.Text) ;
               }
               else
               {
                  context.WriteHtmlText( chkView_New_Encounter2view_NE_IsRandRecheck.Title.Text) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"AttributeCheckBox"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( chkView_New_Encounter2view_NE_IsUpdate_Titleformat == 0 )
               {
                  context.SendWebValue( chkView_New_Encounter2view_NE_IsUpdate.Title.Text) ;
               }
               else
               {
                  context.WriteHtmlText( chkView_New_Encounter2view_NE_IsUpdate.Title.Text) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "view_NE_Tenant Tenant Code") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "view_NE_Information_ID") ;
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
               GridContainer.AddObjectProperty("Class", "GridWithPaginationBar GridWithBorderColor WorkWith");
               GridContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
               GridContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
               GridContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Backcolorstyle), 1, 0, ".", "")));
               GridContainer.AddObjectProperty("Sortable", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Sortable), 1, 0, ".", "")));
               GridContainer.AddObjectProperty("CmpContext", "");
               GridContainer.AddObjectProperty("InMasterPage", "false");
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.convertURL( AV80deleteEncounter));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavDeleteencounter_Tooltiptext));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavDeleteencounter_Visible), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A591View_New_Encounter2view_NE_EncounterID), 18, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtView_New_Encounter2view_NE_EncounterID_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtView_New_Encounter2view_NE_EncounterID_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A601View_New_Encounter2view_NE_Information_PatientNo);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtView_New_Encounter2view_NE_Information_PatientNo_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtView_New_Encounter2view_NE_Information_PatientNo_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", AV78PatientNo);
               GridColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavPatientno_Enabled), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A593View_New_Encounter2view_NE_Departmentadm);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtView_New_Encounter2view_NE_Departmentadm_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtView_New_Encounter2view_NE_Departmentadm_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A592View_New_Encounter2view_NE_ENCType);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtView_New_Encounter2view_NE_ENCType_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtView_New_Encounter2view_NE_ENCType_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.localUtil.Format(AV79AdmitDate, "9999/99/99"));
               GridColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavAdmitdate_Enabled), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.localUtil.Format(A594View_New_Encounter2view_NE_AdmitDate, "9999/99/99"));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A595View_New_Encounter2view_NE_Status), 4, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( cmbView_New_Encounter2view_NE_Status.Title.Text));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(cmbView_New_Encounter2view_NE_Status_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.BoolToStr( A597View_New_Encounter2view_NE_IsRandApprove));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( chkView_New_Encounter2view_NE_IsRandApprove.Title.Text));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(chkView_New_Encounter2view_NE_IsRandApprove_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.BoolToStr( A596View_New_Encounter2view_NE_IsRandRecheck));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( chkView_New_Encounter2view_NE_IsRandRecheck.Title.Text));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(chkView_New_Encounter2view_NE_IsRandRecheck_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.BoolToStr( A598View_New_Encounter2view_NE_IsUpdate));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( chkView_New_Encounter2view_NE_IsUpdate.Title.Text));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(chkView_New_Encounter2view_NE_IsUpdate_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A599View_New_Encounter2view_NE_TenantTenantCode);
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A600View_New_Encounter2view_NE_Information_ID), 18, 0, ".", "")));
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
         if ( wbEnd == 76 )
         {
            wbEnd = 0;
            nRC_GXsfl_76 = (short)(nGXsfl_76_idx-1);
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
            ucGridpaginationbar.SetProperty("CurrentPage", AV72GridCurrentPage);
            ucGridpaginationbar.SetProperty("PageCount", AV73GridPageCount);
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
            ucDdo_view_new_encounter2view_ne_encounterid.SetProperty("Caption", Ddo_view_new_encounter2view_ne_encounterid_Caption);
            ucDdo_view_new_encounter2view_ne_encounterid.SetProperty("Tooltip", Ddo_view_new_encounter2view_ne_encounterid_Tooltip);
            ucDdo_view_new_encounter2view_ne_encounterid.SetProperty("Cls", Ddo_view_new_encounter2view_ne_encounterid_Cls);
            ucDdo_view_new_encounter2view_ne_encounterid.SetProperty("DropDownOptionsType", Ddo_view_new_encounter2view_ne_encounterid_Dropdownoptionstype);
            ucDdo_view_new_encounter2view_ne_encounterid.SetProperty("IncludeSortASC", Ddo_view_new_encounter2view_ne_encounterid_Includesortasc);
            ucDdo_view_new_encounter2view_ne_encounterid.SetProperty("IncludeSortDSC", Ddo_view_new_encounter2view_ne_encounterid_Includesortdsc);
            ucDdo_view_new_encounter2view_ne_encounterid.SetProperty("IncludeFilter", Ddo_view_new_encounter2view_ne_encounterid_Includefilter);
            ucDdo_view_new_encounter2view_ne_encounterid.SetProperty("FilterType", Ddo_view_new_encounter2view_ne_encounterid_Filtertype);
            ucDdo_view_new_encounter2view_ne_encounterid.SetProperty("FilterIsRange", Ddo_view_new_encounter2view_ne_encounterid_Filterisrange);
            ucDdo_view_new_encounter2view_ne_encounterid.SetProperty("IncludeDataList", Ddo_view_new_encounter2view_ne_encounterid_Includedatalist);
            ucDdo_view_new_encounter2view_ne_encounterid.SetProperty("SortASC", Ddo_view_new_encounter2view_ne_encounterid_Sortasc);
            ucDdo_view_new_encounter2view_ne_encounterid.SetProperty("SortDSC", Ddo_view_new_encounter2view_ne_encounterid_Sortdsc);
            ucDdo_view_new_encounter2view_ne_encounterid.SetProperty("CleanFilter", Ddo_view_new_encounter2view_ne_encounterid_Cleanfilter);
            ucDdo_view_new_encounter2view_ne_encounterid.SetProperty("RangeFilterFrom", Ddo_view_new_encounter2view_ne_encounterid_Rangefilterfrom);
            ucDdo_view_new_encounter2view_ne_encounterid.SetProperty("RangeFilterTo", Ddo_view_new_encounter2view_ne_encounterid_Rangefilterto);
            ucDdo_view_new_encounter2view_ne_encounterid.SetProperty("SearchButtonText", Ddo_view_new_encounter2view_ne_encounterid_Searchbuttontext);
            ucDdo_view_new_encounter2view_ne_encounterid.SetProperty("DropDownOptionsTitleSettingsIcons", AV70DDO_TitleSettingsIcons);
            ucDdo_view_new_encounter2view_ne_encounterid.SetProperty("DropDownOptionsData", AV24View_New_Encounter2view_NE_EncounterIDTitleFilterData);
            ucDdo_view_new_encounter2view_ne_encounterid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_view_new_encounter2view_ne_encounterid_Internalname, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 99,'',false,'" + sGXsfl_76_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_view_new_encounter2view_ne_encounteridtitlecontrolidtoreplace_Internalname, AV27ddo_View_New_Encounter2view_NE_EncounterIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,99);\"", 0, edtavDdo_view_new_encounter2view_ne_encounteridtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_EncounterListww.htm");
            /* User Defined Control */
            ucDdo_view_new_encounter2view_ne_information_patientno.SetProperty("Caption", Ddo_view_new_encounter2view_ne_information_patientno_Caption);
            ucDdo_view_new_encounter2view_ne_information_patientno.SetProperty("Tooltip", Ddo_view_new_encounter2view_ne_information_patientno_Tooltip);
            ucDdo_view_new_encounter2view_ne_information_patientno.SetProperty("Cls", Ddo_view_new_encounter2view_ne_information_patientno_Cls);
            ucDdo_view_new_encounter2view_ne_information_patientno.SetProperty("DropDownOptionsType", Ddo_view_new_encounter2view_ne_information_patientno_Dropdownoptionstype);
            ucDdo_view_new_encounter2view_ne_information_patientno.SetProperty("IncludeSortASC", Ddo_view_new_encounter2view_ne_information_patientno_Includesortasc);
            ucDdo_view_new_encounter2view_ne_information_patientno.SetProperty("IncludeSortDSC", Ddo_view_new_encounter2view_ne_information_patientno_Includesortdsc);
            ucDdo_view_new_encounter2view_ne_information_patientno.SetProperty("IncludeFilter", Ddo_view_new_encounter2view_ne_information_patientno_Includefilter);
            ucDdo_view_new_encounter2view_ne_information_patientno.SetProperty("FilterType", Ddo_view_new_encounter2view_ne_information_patientno_Filtertype);
            ucDdo_view_new_encounter2view_ne_information_patientno.SetProperty("FilterIsRange", Ddo_view_new_encounter2view_ne_information_patientno_Filterisrange);
            ucDdo_view_new_encounter2view_ne_information_patientno.SetProperty("IncludeDataList", Ddo_view_new_encounter2view_ne_information_patientno_Includedatalist);
            ucDdo_view_new_encounter2view_ne_information_patientno.SetProperty("DataListType", Ddo_view_new_encounter2view_ne_information_patientno_Datalisttype);
            ucDdo_view_new_encounter2view_ne_information_patientno.SetProperty("DataListProc", Ddo_view_new_encounter2view_ne_information_patientno_Datalistproc);
            ucDdo_view_new_encounter2view_ne_information_patientno.SetProperty("DataListUpdateMinimumCharacters", Ddo_view_new_encounter2view_ne_information_patientno_Datalistupdateminimumcharacters);
            ucDdo_view_new_encounter2view_ne_information_patientno.SetProperty("SortASC", Ddo_view_new_encounter2view_ne_information_patientno_Sortasc);
            ucDdo_view_new_encounter2view_ne_information_patientno.SetProperty("SortDSC", Ddo_view_new_encounter2view_ne_information_patientno_Sortdsc);
            ucDdo_view_new_encounter2view_ne_information_patientno.SetProperty("LoadingData", Ddo_view_new_encounter2view_ne_information_patientno_Loadingdata);
            ucDdo_view_new_encounter2view_ne_information_patientno.SetProperty("CleanFilter", Ddo_view_new_encounter2view_ne_information_patientno_Cleanfilter);
            ucDdo_view_new_encounter2view_ne_information_patientno.SetProperty("NoResultsFound", Ddo_view_new_encounter2view_ne_information_patientno_Noresultsfound);
            ucDdo_view_new_encounter2view_ne_information_patientno.SetProperty("SearchButtonText", Ddo_view_new_encounter2view_ne_information_patientno_Searchbuttontext);
            ucDdo_view_new_encounter2view_ne_information_patientno.SetProperty("DropDownOptionsTitleSettingsIcons", AV70DDO_TitleSettingsIcons);
            ucDdo_view_new_encounter2view_ne_information_patientno.SetProperty("DropDownOptionsData", AV66View_New_Encounter2view_NE_Information_PatientNoTitleFilterData);
            ucDdo_view_new_encounter2view_ne_information_patientno.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_view_new_encounter2view_ne_information_patientno_Internalname, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNOContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 101,'',false,'" + sGXsfl_76_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_view_new_encounter2view_ne_information_patientnotitlecontrolidtoreplace_Internalname, AV69ddo_View_New_Encounter2view_NE_Information_PatientNoTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,101);\"", 0, edtavDdo_view_new_encounter2view_ne_information_patientnotitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_EncounterListww.htm");
            /* User Defined Control */
            ucDdo_view_new_encounter2view_ne_departmentadm.SetProperty("Caption", Ddo_view_new_encounter2view_ne_departmentadm_Caption);
            ucDdo_view_new_encounter2view_ne_departmentadm.SetProperty("Tooltip", Ddo_view_new_encounter2view_ne_departmentadm_Tooltip);
            ucDdo_view_new_encounter2view_ne_departmentadm.SetProperty("Cls", Ddo_view_new_encounter2view_ne_departmentadm_Cls);
            ucDdo_view_new_encounter2view_ne_departmentadm.SetProperty("DropDownOptionsType", Ddo_view_new_encounter2view_ne_departmentadm_Dropdownoptionstype);
            ucDdo_view_new_encounter2view_ne_departmentadm.SetProperty("IncludeSortASC", Ddo_view_new_encounter2view_ne_departmentadm_Includesortasc);
            ucDdo_view_new_encounter2view_ne_departmentadm.SetProperty("IncludeSortDSC", Ddo_view_new_encounter2view_ne_departmentadm_Includesortdsc);
            ucDdo_view_new_encounter2view_ne_departmentadm.SetProperty("IncludeFilter", Ddo_view_new_encounter2view_ne_departmentadm_Includefilter);
            ucDdo_view_new_encounter2view_ne_departmentadm.SetProperty("FilterType", Ddo_view_new_encounter2view_ne_departmentadm_Filtertype);
            ucDdo_view_new_encounter2view_ne_departmentadm.SetProperty("FilterIsRange", Ddo_view_new_encounter2view_ne_departmentadm_Filterisrange);
            ucDdo_view_new_encounter2view_ne_departmentadm.SetProperty("IncludeDataList", Ddo_view_new_encounter2view_ne_departmentadm_Includedatalist);
            ucDdo_view_new_encounter2view_ne_departmentadm.SetProperty("DataListType", Ddo_view_new_encounter2view_ne_departmentadm_Datalisttype);
            ucDdo_view_new_encounter2view_ne_departmentadm.SetProperty("DataListProc", Ddo_view_new_encounter2view_ne_departmentadm_Datalistproc);
            ucDdo_view_new_encounter2view_ne_departmentadm.SetProperty("DataListUpdateMinimumCharacters", Ddo_view_new_encounter2view_ne_departmentadm_Datalistupdateminimumcharacters);
            ucDdo_view_new_encounter2view_ne_departmentadm.SetProperty("SortASC", Ddo_view_new_encounter2view_ne_departmentadm_Sortasc);
            ucDdo_view_new_encounter2view_ne_departmentadm.SetProperty("SortDSC", Ddo_view_new_encounter2view_ne_departmentadm_Sortdsc);
            ucDdo_view_new_encounter2view_ne_departmentadm.SetProperty("LoadingData", Ddo_view_new_encounter2view_ne_departmentadm_Loadingdata);
            ucDdo_view_new_encounter2view_ne_departmentadm.SetProperty("CleanFilter", Ddo_view_new_encounter2view_ne_departmentadm_Cleanfilter);
            ucDdo_view_new_encounter2view_ne_departmentadm.SetProperty("NoResultsFound", Ddo_view_new_encounter2view_ne_departmentadm_Noresultsfound);
            ucDdo_view_new_encounter2view_ne_departmentadm.SetProperty("SearchButtonText", Ddo_view_new_encounter2view_ne_departmentadm_Searchbuttontext);
            ucDdo_view_new_encounter2view_ne_departmentadm.SetProperty("DropDownOptionsTitleSettingsIcons", AV70DDO_TitleSettingsIcons);
            ucDdo_view_new_encounter2view_ne_departmentadm.SetProperty("DropDownOptionsData", AV32View_New_Encounter2view_NE_DepartmentadmTitleFilterData);
            ucDdo_view_new_encounter2view_ne_departmentadm.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_view_new_encounter2view_ne_departmentadm_Internalname, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADMContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 103,'',false,'" + sGXsfl_76_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_view_new_encounter2view_ne_departmentadmtitlecontrolidtoreplace_Internalname, AV35ddo_View_New_Encounter2view_NE_DepartmentadmTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,103);\"", 0, edtavDdo_view_new_encounter2view_ne_departmentadmtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_EncounterListww.htm");
            /* User Defined Control */
            ucDdo_view_new_encounter2view_ne_enctype.SetProperty("Caption", Ddo_view_new_encounter2view_ne_enctype_Caption);
            ucDdo_view_new_encounter2view_ne_enctype.SetProperty("Tooltip", Ddo_view_new_encounter2view_ne_enctype_Tooltip);
            ucDdo_view_new_encounter2view_ne_enctype.SetProperty("Cls", Ddo_view_new_encounter2view_ne_enctype_Cls);
            ucDdo_view_new_encounter2view_ne_enctype.SetProperty("DropDownOptionsType", Ddo_view_new_encounter2view_ne_enctype_Dropdownoptionstype);
            ucDdo_view_new_encounter2view_ne_enctype.SetProperty("IncludeSortASC", Ddo_view_new_encounter2view_ne_enctype_Includesortasc);
            ucDdo_view_new_encounter2view_ne_enctype.SetProperty("IncludeSortDSC", Ddo_view_new_encounter2view_ne_enctype_Includesortdsc);
            ucDdo_view_new_encounter2view_ne_enctype.SetProperty("IncludeFilter", Ddo_view_new_encounter2view_ne_enctype_Includefilter);
            ucDdo_view_new_encounter2view_ne_enctype.SetProperty("FilterType", Ddo_view_new_encounter2view_ne_enctype_Filtertype);
            ucDdo_view_new_encounter2view_ne_enctype.SetProperty("FilterIsRange", Ddo_view_new_encounter2view_ne_enctype_Filterisrange);
            ucDdo_view_new_encounter2view_ne_enctype.SetProperty("IncludeDataList", Ddo_view_new_encounter2view_ne_enctype_Includedatalist);
            ucDdo_view_new_encounter2view_ne_enctype.SetProperty("DataListType", Ddo_view_new_encounter2view_ne_enctype_Datalisttype);
            ucDdo_view_new_encounter2view_ne_enctype.SetProperty("DataListProc", Ddo_view_new_encounter2view_ne_enctype_Datalistproc);
            ucDdo_view_new_encounter2view_ne_enctype.SetProperty("DataListUpdateMinimumCharacters", Ddo_view_new_encounter2view_ne_enctype_Datalistupdateminimumcharacters);
            ucDdo_view_new_encounter2view_ne_enctype.SetProperty("SortASC", Ddo_view_new_encounter2view_ne_enctype_Sortasc);
            ucDdo_view_new_encounter2view_ne_enctype.SetProperty("SortDSC", Ddo_view_new_encounter2view_ne_enctype_Sortdsc);
            ucDdo_view_new_encounter2view_ne_enctype.SetProperty("LoadingData", Ddo_view_new_encounter2view_ne_enctype_Loadingdata);
            ucDdo_view_new_encounter2view_ne_enctype.SetProperty("CleanFilter", Ddo_view_new_encounter2view_ne_enctype_Cleanfilter);
            ucDdo_view_new_encounter2view_ne_enctype.SetProperty("NoResultsFound", Ddo_view_new_encounter2view_ne_enctype_Noresultsfound);
            ucDdo_view_new_encounter2view_ne_enctype.SetProperty("SearchButtonText", Ddo_view_new_encounter2view_ne_enctype_Searchbuttontext);
            ucDdo_view_new_encounter2view_ne_enctype.SetProperty("DropDownOptionsTitleSettingsIcons", AV70DDO_TitleSettingsIcons);
            ucDdo_view_new_encounter2view_ne_enctype.SetProperty("DropDownOptionsData", AV28View_New_Encounter2view_NE_ENCTypeTitleFilterData);
            ucDdo_view_new_encounter2view_ne_enctype.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_view_new_encounter2view_ne_enctype_Internalname, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 105,'',false,'" + sGXsfl_76_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_view_new_encounter2view_ne_enctypetitlecontrolidtoreplace_Internalname, AV31ddo_View_New_Encounter2view_NE_ENCTypeTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,105);\"", 0, edtavDdo_view_new_encounter2view_ne_enctypetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_EncounterListww.htm");
            /* User Defined Control */
            ucDdo_view_new_encounter2view_ne_status.SetProperty("Caption", Ddo_view_new_encounter2view_ne_status_Caption);
            ucDdo_view_new_encounter2view_ne_status.SetProperty("Tooltip", Ddo_view_new_encounter2view_ne_status_Tooltip);
            ucDdo_view_new_encounter2view_ne_status.SetProperty("Cls", Ddo_view_new_encounter2view_ne_status_Cls);
            ucDdo_view_new_encounter2view_ne_status.SetProperty("DropDownOptionsType", Ddo_view_new_encounter2view_ne_status_Dropdownoptionstype);
            ucDdo_view_new_encounter2view_ne_status.SetProperty("IncludeSortASC", Ddo_view_new_encounter2view_ne_status_Includesortasc);
            ucDdo_view_new_encounter2view_ne_status.SetProperty("IncludeSortDSC", Ddo_view_new_encounter2view_ne_status_Includesortdsc);
            ucDdo_view_new_encounter2view_ne_status.SetProperty("IncludeFilter", Ddo_view_new_encounter2view_ne_status_Includefilter);
            ucDdo_view_new_encounter2view_ne_status.SetProperty("IncludeDataList", Ddo_view_new_encounter2view_ne_status_Includedatalist);
            ucDdo_view_new_encounter2view_ne_status.SetProperty("DataListType", Ddo_view_new_encounter2view_ne_status_Datalisttype);
            ucDdo_view_new_encounter2view_ne_status.SetProperty("AllowMultipleSelection", Ddo_view_new_encounter2view_ne_status_Allowmultipleselection);
            ucDdo_view_new_encounter2view_ne_status.SetProperty("DataListFixedValues", Ddo_view_new_encounter2view_ne_status_Datalistfixedvalues);
            ucDdo_view_new_encounter2view_ne_status.SetProperty("SortASC", Ddo_view_new_encounter2view_ne_status_Sortasc);
            ucDdo_view_new_encounter2view_ne_status.SetProperty("SortDSC", Ddo_view_new_encounter2view_ne_status_Sortdsc);
            ucDdo_view_new_encounter2view_ne_status.SetProperty("CleanFilter", Ddo_view_new_encounter2view_ne_status_Cleanfilter);
            ucDdo_view_new_encounter2view_ne_status.SetProperty("SearchButtonText", Ddo_view_new_encounter2view_ne_status_Searchbuttontext);
            ucDdo_view_new_encounter2view_ne_status.SetProperty("DropDownOptionsTitleSettingsIcons", AV70DDO_TitleSettingsIcons);
            ucDdo_view_new_encounter2view_ne_status.SetProperty("DropDownOptionsData", AV42View_New_Encounter2view_NE_StatusTitleFilterData);
            ucDdo_view_new_encounter2view_ne_status.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_view_new_encounter2view_ne_status_Internalname, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_STATUSContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 107,'',false,'" + sGXsfl_76_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_view_new_encounter2view_ne_statustitlecontrolidtoreplace_Internalname, AV45ddo_View_New_Encounter2view_NE_StatusTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,107);\"", 0, edtavDdo_view_new_encounter2view_ne_statustitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_EncounterListww.htm");
            /* User Defined Control */
            ucDdo_view_new_encounter2view_ne_israndapprove.SetProperty("Caption", Ddo_view_new_encounter2view_ne_israndapprove_Caption);
            ucDdo_view_new_encounter2view_ne_israndapprove.SetProperty("Tooltip", Ddo_view_new_encounter2view_ne_israndapprove_Tooltip);
            ucDdo_view_new_encounter2view_ne_israndapprove.SetProperty("Cls", Ddo_view_new_encounter2view_ne_israndapprove_Cls);
            ucDdo_view_new_encounter2view_ne_israndapprove.SetProperty("DropDownOptionsType", Ddo_view_new_encounter2view_ne_israndapprove_Dropdownoptionstype);
            ucDdo_view_new_encounter2view_ne_israndapprove.SetProperty("IncludeSortASC", Ddo_view_new_encounter2view_ne_israndapprove_Includesortasc);
            ucDdo_view_new_encounter2view_ne_israndapprove.SetProperty("IncludeSortDSC", Ddo_view_new_encounter2view_ne_israndapprove_Includesortdsc);
            ucDdo_view_new_encounter2view_ne_israndapprove.SetProperty("IncludeFilter", Ddo_view_new_encounter2view_ne_israndapprove_Includefilter);
            ucDdo_view_new_encounter2view_ne_israndapprove.SetProperty("IncludeDataList", Ddo_view_new_encounter2view_ne_israndapprove_Includedatalist);
            ucDdo_view_new_encounter2view_ne_israndapprove.SetProperty("DataListType", Ddo_view_new_encounter2view_ne_israndapprove_Datalisttype);
            ucDdo_view_new_encounter2view_ne_israndapprove.SetProperty("DataListFixedValues", Ddo_view_new_encounter2view_ne_israndapprove_Datalistfixedvalues);
            ucDdo_view_new_encounter2view_ne_israndapprove.SetProperty("SortASC", Ddo_view_new_encounter2view_ne_israndapprove_Sortasc);
            ucDdo_view_new_encounter2view_ne_israndapprove.SetProperty("SortDSC", Ddo_view_new_encounter2view_ne_israndapprove_Sortdsc);
            ucDdo_view_new_encounter2view_ne_israndapprove.SetProperty("CleanFilter", Ddo_view_new_encounter2view_ne_israndapprove_Cleanfilter);
            ucDdo_view_new_encounter2view_ne_israndapprove.SetProperty("SearchButtonText", Ddo_view_new_encounter2view_ne_israndapprove_Searchbuttontext);
            ucDdo_view_new_encounter2view_ne_israndapprove.SetProperty("DropDownOptionsTitleSettingsIcons", AV70DDO_TitleSettingsIcons);
            ucDdo_view_new_encounter2view_ne_israndapprove.SetProperty("DropDownOptionsData", AV50View_New_Encounter2view_NE_IsRandApproveTitleFilterData);
            ucDdo_view_new_encounter2view_ne_israndapprove.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_view_new_encounter2view_ne_israndapprove_Internalname, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 109,'',false,'" + sGXsfl_76_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_view_new_encounter2view_ne_israndapprovetitlecontrolidtoreplace_Internalname, AV53ddo_View_New_Encounter2view_NE_IsRandApproveTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,109);\"", 0, edtavDdo_view_new_encounter2view_ne_israndapprovetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_EncounterListww.htm");
            /* User Defined Control */
            ucDdo_view_new_encounter2view_ne_israndrecheck.SetProperty("Caption", Ddo_view_new_encounter2view_ne_israndrecheck_Caption);
            ucDdo_view_new_encounter2view_ne_israndrecheck.SetProperty("Tooltip", Ddo_view_new_encounter2view_ne_israndrecheck_Tooltip);
            ucDdo_view_new_encounter2view_ne_israndrecheck.SetProperty("Cls", Ddo_view_new_encounter2view_ne_israndrecheck_Cls);
            ucDdo_view_new_encounter2view_ne_israndrecheck.SetProperty("DropDownOptionsType", Ddo_view_new_encounter2view_ne_israndrecheck_Dropdownoptionstype);
            ucDdo_view_new_encounter2view_ne_israndrecheck.SetProperty("IncludeSortASC", Ddo_view_new_encounter2view_ne_israndrecheck_Includesortasc);
            ucDdo_view_new_encounter2view_ne_israndrecheck.SetProperty("IncludeSortDSC", Ddo_view_new_encounter2view_ne_israndrecheck_Includesortdsc);
            ucDdo_view_new_encounter2view_ne_israndrecheck.SetProperty("IncludeFilter", Ddo_view_new_encounter2view_ne_israndrecheck_Includefilter);
            ucDdo_view_new_encounter2view_ne_israndrecheck.SetProperty("IncludeDataList", Ddo_view_new_encounter2view_ne_israndrecheck_Includedatalist);
            ucDdo_view_new_encounter2view_ne_israndrecheck.SetProperty("DataListType", Ddo_view_new_encounter2view_ne_israndrecheck_Datalisttype);
            ucDdo_view_new_encounter2view_ne_israndrecheck.SetProperty("DataListFixedValues", Ddo_view_new_encounter2view_ne_israndrecheck_Datalistfixedvalues);
            ucDdo_view_new_encounter2view_ne_israndrecheck.SetProperty("SortASC", Ddo_view_new_encounter2view_ne_israndrecheck_Sortasc);
            ucDdo_view_new_encounter2view_ne_israndrecheck.SetProperty("SortDSC", Ddo_view_new_encounter2view_ne_israndrecheck_Sortdsc);
            ucDdo_view_new_encounter2view_ne_israndrecheck.SetProperty("CleanFilter", Ddo_view_new_encounter2view_ne_israndrecheck_Cleanfilter);
            ucDdo_view_new_encounter2view_ne_israndrecheck.SetProperty("SearchButtonText", Ddo_view_new_encounter2view_ne_israndrecheck_Searchbuttontext);
            ucDdo_view_new_encounter2view_ne_israndrecheck.SetProperty("DropDownOptionsTitleSettingsIcons", AV70DDO_TitleSettingsIcons);
            ucDdo_view_new_encounter2view_ne_israndrecheck.SetProperty("DropDownOptionsData", AV46View_New_Encounter2view_NE_IsRandRecheckTitleFilterData);
            ucDdo_view_new_encounter2view_ne_israndrecheck.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_view_new_encounter2view_ne_israndrecheck_Internalname, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECKContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 111,'',false,'" + sGXsfl_76_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_view_new_encounter2view_ne_israndrechecktitlecontrolidtoreplace_Internalname, AV49ddo_View_New_Encounter2view_NE_IsRandRecheckTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,111);\"", 0, edtavDdo_view_new_encounter2view_ne_israndrechecktitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_EncounterListww.htm");
            /* User Defined Control */
            ucDdo_view_new_encounter2view_ne_isupdate.SetProperty("Caption", Ddo_view_new_encounter2view_ne_isupdate_Caption);
            ucDdo_view_new_encounter2view_ne_isupdate.SetProperty("Tooltip", Ddo_view_new_encounter2view_ne_isupdate_Tooltip);
            ucDdo_view_new_encounter2view_ne_isupdate.SetProperty("Cls", Ddo_view_new_encounter2view_ne_isupdate_Cls);
            ucDdo_view_new_encounter2view_ne_isupdate.SetProperty("DropDownOptionsType", Ddo_view_new_encounter2view_ne_isupdate_Dropdownoptionstype);
            ucDdo_view_new_encounter2view_ne_isupdate.SetProperty("IncludeSortASC", Ddo_view_new_encounter2view_ne_isupdate_Includesortasc);
            ucDdo_view_new_encounter2view_ne_isupdate.SetProperty("IncludeSortDSC", Ddo_view_new_encounter2view_ne_isupdate_Includesortdsc);
            ucDdo_view_new_encounter2view_ne_isupdate.SetProperty("IncludeFilter", Ddo_view_new_encounter2view_ne_isupdate_Includefilter);
            ucDdo_view_new_encounter2view_ne_isupdate.SetProperty("IncludeDataList", Ddo_view_new_encounter2view_ne_isupdate_Includedatalist);
            ucDdo_view_new_encounter2view_ne_isupdate.SetProperty("DataListType", Ddo_view_new_encounter2view_ne_isupdate_Datalisttype);
            ucDdo_view_new_encounter2view_ne_isupdate.SetProperty("DataListFixedValues", Ddo_view_new_encounter2view_ne_isupdate_Datalistfixedvalues);
            ucDdo_view_new_encounter2view_ne_isupdate.SetProperty("SortASC", Ddo_view_new_encounter2view_ne_isupdate_Sortasc);
            ucDdo_view_new_encounter2view_ne_isupdate.SetProperty("SortDSC", Ddo_view_new_encounter2view_ne_isupdate_Sortdsc);
            ucDdo_view_new_encounter2view_ne_isupdate.SetProperty("CleanFilter", Ddo_view_new_encounter2view_ne_isupdate_Cleanfilter);
            ucDdo_view_new_encounter2view_ne_isupdate.SetProperty("SearchButtonText", Ddo_view_new_encounter2view_ne_isupdate_Searchbuttontext);
            ucDdo_view_new_encounter2view_ne_isupdate.SetProperty("DropDownOptionsTitleSettingsIcons", AV70DDO_TitleSettingsIcons);
            ucDdo_view_new_encounter2view_ne_isupdate.SetProperty("DropDownOptionsData", AV54View_New_Encounter2view_NE_IsUpdateTitleFilterData);
            ucDdo_view_new_encounter2view_ne_isupdate.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_view_new_encounter2view_ne_isupdate_Internalname, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 113,'',false,'" + sGXsfl_76_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_view_new_encounter2view_ne_isupdatetitlecontrolidtoreplace_Internalname, AV57ddo_View_New_Encounter2view_NE_IsUpdateTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,113);\"", 0, edtavDdo_view_new_encounter2view_ne_isupdatetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_EncounterListww.htm");
            /* User Defined Control */
            ucWorkwithplusutilities1.Render(context, "dvelop.workwithplusutilities", Workwithplusutilities1_Internalname, "WORKWITHPLUSUTILITIES1Container");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 115,'',false,'" + sGXsfl_76_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavView_new_encounter2view_ne_encounterid_selected_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV82View_New_Encounter2view_NE_EncounterID_Selected), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV82View_New_Encounter2view_NE_EncounterID_Selected), "ZZZZZZZZZZZZZZZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,115);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavView_new_encounter2view_ne_encounterid_selected_Jsonclick, 0, "Attribute", "", "", "", "", edtavView_new_encounter2view_ne_encounterid_selected_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_EncounterListww.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 116,'',false,'" + sGXsfl_76_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrderedby_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13OrderedBy), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV13OrderedBy), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,116);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrderedby_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrderedby_Visible, 1, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_EncounterListww.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 117,'',false,'" + sGXsfl_76_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrdereddsc_Internalname, StringUtil.BoolToStr( AV14OrderedDsc), StringUtil.BoolToStr( AV14OrderedDsc), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,117);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrdereddsc_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrdereddsc_Visible, 1, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, 0, 0, true, "", "right", false, "HLP_BR_EncounterListww.htm");
            wb_table2_118_AL2( true) ;
         }
         else
         {
            wb_table2_118_AL2( false) ;
         }
         return  ;
      }

      protected void wb_table2_118_AL2e( bool wbgen )
      {
         if ( wbgen )
         {
            wb_table3_123_AL2( true) ;
         }
         else
         {
            wb_table3_123_AL2( false) ;
         }
         return  ;
      }

      protected void wb_table3_123_AL2e( bool wbgen )
      {
         if ( wbgen )
         {
            wb_table4_128_AL2( true) ;
         }
         else
         {
            wb_table4_128_AL2( false) ;
         }
         return  ;
      }

      protected void wb_table4_128_AL2e( bool wbgen )
      {
         if ( wbgen )
         {
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 133,'',false,'" + sGXsfl_76_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfview_new_encounter2view_ne_encounterid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV25TFView_New_Encounter2view_NE_EncounterID), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV25TFView_New_Encounter2view_NE_EncounterID), "ZZZZZZZZZZZZZZZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,133);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfview_new_encounter2view_ne_encounterid_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfview_new_encounter2view_ne_encounterid_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_EncounterListww.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 134,'',false,'" + sGXsfl_76_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfview_new_encounter2view_ne_encounterid_to_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV26TFView_New_Encounter2view_NE_EncounterID_To), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV26TFView_New_Encounter2view_NE_EncounterID_To), "ZZZZZZZZZZZZZZZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,134);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfview_new_encounter2view_ne_encounterid_to_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfview_new_encounter2view_ne_encounterid_to_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_EncounterListww.htm");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 135,'',false,'" + sGXsfl_76_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavTfview_new_encounter2view_ne_information_patientno_Internalname, AV67TFView_New_Encounter2view_NE_Information_PatientNo, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,135);\"", 0, edtavTfview_new_encounter2view_ne_information_patientno_Visible, 1, 0, 80, "chr", 10, "row", StyleString, ClassString, "", "", "4000", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_EncounterListww.htm");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 136,'',false,'" + sGXsfl_76_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavTfview_new_encounter2view_ne_information_patientno_sel_Internalname, AV68TFView_New_Encounter2view_NE_Information_PatientNo_Sel, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,136);\"", 0, edtavTfview_new_encounter2view_ne_information_patientno_sel_Visible, 1, 0, 80, "chr", 10, "row", StyleString, ClassString, "", "", "4000", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_EncounterListww.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 137,'',false,'" + sGXsfl_76_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfview_new_encounter2view_ne_departmentadm_Internalname, AV33TFView_New_Encounter2view_NE_Departmentadm, StringUtil.RTrim( context.localUtil.Format( AV33TFView_New_Encounter2view_NE_Departmentadm, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,137);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfview_new_encounter2view_ne_departmentadm_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfview_new_encounter2view_ne_departmentadm_Visible, 1, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_EncounterListww.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 138,'',false,'" + sGXsfl_76_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfview_new_encounter2view_ne_departmentadm_sel_Internalname, AV34TFView_New_Encounter2view_NE_Departmentadm_Sel, StringUtil.RTrim( context.localUtil.Format( AV34TFView_New_Encounter2view_NE_Departmentadm_Sel, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,138);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfview_new_encounter2view_ne_departmentadm_sel_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfview_new_encounter2view_ne_departmentadm_sel_Visible, 1, 0, "text", "", 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_EncounterListww.htm");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 139,'',false,'" + sGXsfl_76_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavTfview_new_encounter2view_ne_enctype_Internalname, AV29TFView_New_Encounter2view_NE_ENCType, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,139);\"", 0, edtavTfview_new_encounter2view_ne_enctype_Visible, 1, 0, 80, "chr", 10, "row", StyleString, ClassString, "", "", "4000", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_EncounterListww.htm");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 140,'',false,'" + sGXsfl_76_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavTfview_new_encounter2view_ne_enctype_sel_Internalname, AV30TFView_New_Encounter2view_NE_ENCType_Sel, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,140);\"", 0, edtavTfview_new_encounter2view_ne_enctype_sel_Visible, 1, 0, 80, "chr", 10, "row", StyleString, ClassString, "", "", "4000", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_EncounterListww.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 141,'',false,'" + sGXsfl_76_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfview_new_encounter2view_ne_israndapprove_sel_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV106TFView_New_Encounter2view_NE_IsRandApprove_Sel), 1, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV106TFView_New_Encounter2view_NE_IsRandApprove_Sel), "9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,141);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfview_new_encounter2view_ne_israndapprove_sel_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfview_new_encounter2view_ne_israndapprove_sel_Visible, 1, 0, "number", "1", 1, "chr", 1, "row", 1, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_EncounterListww.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 142,'',false,'" + sGXsfl_76_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfview_new_encounter2view_ne_israndrecheck_sel_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV107TFView_New_Encounter2view_NE_IsRandRecheck_Sel), 1, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV107TFView_New_Encounter2view_NE_IsRandRecheck_Sel), "9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,142);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfview_new_encounter2view_ne_israndrecheck_sel_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfview_new_encounter2view_ne_israndrecheck_sel_Visible, 1, 0, "number", "1", 1, "chr", 1, "row", 1, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_EncounterListww.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 143,'',false,'" + sGXsfl_76_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfview_new_encounter2view_ne_isupdate_sel_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV108TFView_New_Encounter2view_NE_IsUpdate_Sel), 1, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV108TFView_New_Encounter2view_NE_IsUpdate_Sel), "9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,143);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfview_new_encounter2view_ne_isupdate_sel_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfview_new_encounter2view_ne_isupdate_sel_Visible, 1, 0, "number", "1", 1, "chr", 1, "row", 1, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_EncounterListww.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         if ( wbEnd == 76 )
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

      protected void STARTAL2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_0-127771", 0) ;
            Form.Meta.addItem("description", "就诊列表", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUPAL0( ) ;
      }

      protected void WSAL2( )
      {
         STARTAL2( ) ;
         EVTAL2( ) ;
      }

      protected void EVTAL2( )
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
                              E11AL2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEROWSPERPAGE") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E12AL2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E13AL2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E14AL2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E15AL2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E16AL2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_STATUS.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E17AL2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E18AL2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E19AL2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E20AL2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DVELOP_CONFIRMPANEL_BATCHAPPROVE.CLOSE") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E21AL2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DVELOP_CONFIRMPANEL_BATCHRECHECK.CLOSE") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E22AL2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "VSBR_ENCOUNTERID.CONTROLVALUECHANGING") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E23AL2 ();
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
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 7), "REFRESH") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 9), "GRID.LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 8), "'DOTEST'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 7), "'DOADD'") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 44), "VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID.CLICK") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 44), "VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID.CLICK") == 0 ) )
                           {
                              nGXsfl_76_idx = (short)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_76_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_76_idx), 4, 0)), 4, "0");
                              SubsflControlProps_762( ) ;
                              AV80deleteEncounter = cgiGet( edtavDeleteencounter_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDeleteencounter_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV80deleteEncounter)) ? AV129Deleteencounter_GXI : context.convertURL( context.PathToRelativeUrl( AV80deleteEncounter))), !bGXsfl_76_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDeleteencounter_Internalname, "SrcSet", context.GetImageSrcSet( AV80deleteEncounter), true);
                              A591View_New_Encounter2view_NE_EncounterID = (long)(context.localUtil.CToN( cgiGet( edtView_New_Encounter2view_NE_EncounterID_Internalname), ".", ","));
                              A601View_New_Encounter2view_NE_Information_PatientNo = cgiGet( edtView_New_Encounter2view_NE_Information_PatientNo_Internalname);
                              n601View_New_Encounter2view_NE_Information_PatientNo = false;
                              AV78PatientNo = cgiGet( edtavPatientno_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavPatientno_Internalname, AV78PatientNo);
                              A593View_New_Encounter2view_NE_Departmentadm = cgiGet( edtView_New_Encounter2view_NE_Departmentadm_Internalname);
                              n593View_New_Encounter2view_NE_Departmentadm = false;
                              A592View_New_Encounter2view_NE_ENCType = cgiGet( edtView_New_Encounter2view_NE_ENCType_Internalname);
                              n592View_New_Encounter2view_NE_ENCType = false;
                              if ( context.localUtil.VCDateTime( cgiGet( edtavAdmitdate_Internalname), 0, 0) == 0 )
                              {
                                 GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Admit Date"}), 1, "vADMITDATE");
                                 GX_FocusControl = edtavAdmitdate_Internalname;
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                                 wbErr = true;
                                 AV79AdmitDate = (DateTime)(DateTime.MinValue);
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavAdmitdate_Internalname, context.localUtil.Format(AV79AdmitDate, "9999/99/99"));
                              }
                              else
                              {
                                 AV79AdmitDate = DateTimeUtil.ResetTime(context.localUtil.CToT( cgiGet( edtavAdmitdate_Internalname), 0));
                                 context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavAdmitdate_Internalname, context.localUtil.Format(AV79AdmitDate, "9999/99/99"));
                              }
                              A594View_New_Encounter2view_NE_AdmitDate = DateTimeUtil.ResetTime(context.localUtil.CToT( cgiGet( edtView_New_Encounter2view_NE_AdmitDate_Internalname), 0));
                              n594View_New_Encounter2view_NE_AdmitDate = false;
                              cmbView_New_Encounter2view_NE_Status.Name = cmbView_New_Encounter2view_NE_Status_Internalname;
                              cmbView_New_Encounter2view_NE_Status.CurrentValue = cgiGet( cmbView_New_Encounter2view_NE_Status_Internalname);
                              A595View_New_Encounter2view_NE_Status = (short)(NumberUtil.Val( cgiGet( cmbView_New_Encounter2view_NE_Status_Internalname), "."));
                              n595View_New_Encounter2view_NE_Status = false;
                              A597View_New_Encounter2view_NE_IsRandApprove = StringUtil.StrToBool( cgiGet( chkView_New_Encounter2view_NE_IsRandApprove_Internalname));
                              n597View_New_Encounter2view_NE_IsRandApprove = false;
                              A596View_New_Encounter2view_NE_IsRandRecheck = StringUtil.StrToBool( cgiGet( chkView_New_Encounter2view_NE_IsRandRecheck_Internalname));
                              n596View_New_Encounter2view_NE_IsRandRecheck = false;
                              A598View_New_Encounter2view_NE_IsUpdate = StringUtil.StrToBool( cgiGet( chkView_New_Encounter2view_NE_IsUpdate_Internalname));
                              n598View_New_Encounter2view_NE_IsUpdate = false;
                              A599View_New_Encounter2view_NE_TenantTenantCode = cgiGet( edtView_New_Encounter2view_NE_TenantTenantCode_Internalname);
                              n599View_New_Encounter2view_NE_TenantTenantCode = false;
                              A600View_New_Encounter2view_NE_Information_ID = (long)(context.localUtil.CToN( cgiGet( edtView_New_Encounter2view_NE_Information_ID_Internalname), ".", ","));
                              n600View_New_Encounter2view_NE_Information_ID = false;
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E24AL2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Refresh */
                                    E25AL2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "GRID.LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    E26AL2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'DOTEST'") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: 'Dotest' */
                                    E27AL2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'DOADD'") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: 'Doadd' */
                                    E28AL2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID.CLICK") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    E29AL2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false;
                                       /* Set Refresh If Br_information_patientno Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vBR_INFORMATION_PATIENTNO"), AV15BR_Information_PatientNo) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Sbr_encounterid Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vSBR_ENCOUNTERID"), AV20sBR_EncounterID) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If View_ne_admitdate Changed */
                                       if ( context.localUtil.CToT( cgiGet( "GXH_vVIEW_NE_ADMITDATE"), 0) != AV21view_NE_AdmitDate )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Endview_ne_admitdate Changed */
                                       if ( context.localUtil.CToT( cgiGet( "GXH_vENDVIEW_NE_ADMITDATE"), 0) != AV22endview_NE_AdmitDate )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tview_ne_status Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTVIEW_NE_STATUS"), ".", ",") != Convert.ToDecimal( AV23tview_NE_Status )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If View_new_encounter2view_ne_israndapprove Changed */
                                       if ( StringUtil.StrToBool( cgiGet( "GXH_vVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE")) != AV101View_New_Encounter2view_NE_IsRandApprove )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If View_new_encounter2view_ne_israndrecheck Changed */
                                       if ( StringUtil.StrToBool( cgiGet( "GXH_vVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK")) != AV102View_New_Encounter2view_NE_IsRandRecheck )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If View_new_encounter2view_ne_isupdate Changed */
                                       if ( StringUtil.StrToBool( cgiGet( "GXH_vVIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE")) != AV103View_New_Encounter2view_NE_IsUpdate )
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
                                       /* Set Refresh If Tfview_new_encounter2view_ne_encounterid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID"), ".", ",") != Convert.ToDecimal( AV25TFView_New_Encounter2view_NE_EncounterID )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfview_new_encounter2view_ne_encounterid_to Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID_TO"), ".", ",") != Convert.ToDecimal( AV26TFView_New_Encounter2view_NE_EncounterID_To )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfview_new_encounter2view_ne_information_patientno Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFVIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO"), AV67TFView_New_Encounter2view_NE_Information_PatientNo) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfview_new_encounter2view_ne_information_patientno_sel Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFVIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO_SEL"), AV68TFView_New_Encounter2view_NE_Information_PatientNo_Sel) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfview_new_encounter2view_ne_departmentadm Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFVIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM"), AV33TFView_New_Encounter2view_NE_Departmentadm) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfview_new_encounter2view_ne_departmentadm_sel Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFVIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM_SEL"), AV34TFView_New_Encounter2view_NE_Departmentadm_Sel) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfview_new_encounter2view_ne_enctype Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE"), AV29TFView_New_Encounter2view_NE_ENCType) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfview_new_encounter2view_ne_enctype_sel Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE_SEL"), AV30TFView_New_Encounter2view_NE_ENCType_Sel) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfview_new_encounter2view_ne_israndapprove_sel Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE_SEL"), ".", ",") != Convert.ToDecimal( AV106TFView_New_Encounter2view_NE_IsRandApprove_Sel )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfview_new_encounter2view_ne_israndrecheck_sel Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK_SEL"), ".", ",") != Convert.ToDecimal( AV107TFView_New_Encounter2view_NE_IsRandRecheck_Sel )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfview_new_encounter2view_ne_isupdate_sel Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE_SEL"), ".", ",") != Convert.ToDecimal( AV108TFView_New_Encounter2view_NE_IsUpdate_Sel )) )
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

      protected void WEAL2( )
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

      protected void PAAL2( )
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
               GX_FocusControl = edtavBr_information_patientno_Internalname;
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
         SubsflControlProps_762( ) ;
         while ( nGXsfl_76_idx <= nRC_GXsfl_76 )
         {
            sendrow_762( ) ;
            nGXsfl_76_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_76_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_76_idx+1));
            sGXsfl_76_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_76_idx), 4, 0)), 4, "0");
            SubsflControlProps_762( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( GridContainer));
         /* End function gxnrGrid_newrow */
      }

      protected void gxgrGrid_refresh( int subGrid_Rows ,
                                       String AV15BR_Information_PatientNo ,
                                       String AV20sBR_EncounterID ,
                                       DateTime AV21view_NE_AdmitDate ,
                                       DateTime AV22endview_NE_AdmitDate ,
                                       short AV23tview_NE_Status ,
                                       bool AV101View_New_Encounter2view_NE_IsRandApprove ,
                                       bool AV102View_New_Encounter2view_NE_IsRandRecheck ,
                                       bool AV103View_New_Encounter2view_NE_IsUpdate ,
                                       short AV13OrderedBy ,
                                       bool AV14OrderedDsc ,
                                       long AV25TFView_New_Encounter2view_NE_EncounterID ,
                                       long AV26TFView_New_Encounter2view_NE_EncounterID_To ,
                                       String AV67TFView_New_Encounter2view_NE_Information_PatientNo ,
                                       String AV68TFView_New_Encounter2view_NE_Information_PatientNo_Sel ,
                                       String AV33TFView_New_Encounter2view_NE_Departmentadm ,
                                       String AV34TFView_New_Encounter2view_NE_Departmentadm_Sel ,
                                       String AV29TFView_New_Encounter2view_NE_ENCType ,
                                       String AV30TFView_New_Encounter2view_NE_ENCType_Sel ,
                                       short AV106TFView_New_Encounter2view_NE_IsRandApprove_Sel ,
                                       short AV107TFView_New_Encounter2view_NE_IsRandRecheck_Sel ,
                                       short AV108TFView_New_Encounter2view_NE_IsUpdate_Sel ,
                                       String AV85tCurrentCode ,
                                       String AV27ddo_View_New_Encounter2view_NE_EncounterIDTitleControlIdToReplace ,
                                       String AV69ddo_View_New_Encounter2view_NE_Information_PatientNoTitleControlIdToReplace ,
                                       String AV35ddo_View_New_Encounter2view_NE_DepartmentadmTitleControlIdToReplace ,
                                       String AV31ddo_View_New_Encounter2view_NE_ENCTypeTitleControlIdToReplace ,
                                       String AV45ddo_View_New_Encounter2view_NE_StatusTitleControlIdToReplace ,
                                       String AV53ddo_View_New_Encounter2view_NE_IsRandApproveTitleControlIdToReplace ,
                                       String AV49ddo_View_New_Encounter2view_NE_IsRandRecheckTitleControlIdToReplace ,
                                       String AV57ddo_View_New_Encounter2view_NE_IsUpdateTitleControlIdToReplace ,
                                       GxSimpleCollection<short> AV105TFView_New_Encounter2view_NE_Status_Sels ,
                                       String AV111Pgmname ,
                                       bool AV87IsInsert )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GRID_nCurrentRecord = 0;
         RFAL2( ) ;
         /* End function gxgrGrid_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A591View_New_Encounter2view_NE_EncounterID), "ZZZZZZZZZZZZZZZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A591View_New_Encounter2view_NE_EncounterID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_ID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A600View_New_Encounter2view_NE_Information_ID), "ZZZZZZZZZZZZZZZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_ID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A600View_New_Encounter2view_NE_Information_ID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_VIEW_NEW_ENCOUNTER2VIEW_NE_STATUS", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A595View_New_Encounter2view_NE_Status), "ZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "VIEW_NEW_ENCOUNTER2VIEW_NE_STATUS", StringUtil.LTrim( StringUtil.NToC( (decimal)(A595View_New_Encounter2view_NE_Status), 4, 0, ".", "")));
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
         if ( cmbavTview_ne_status.ItemCount > 0 )
         {
            AV23tview_NE_Status = (short)(NumberUtil.Val( cmbavTview_ne_status.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV23tview_NE_Status), 4, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23tview_NE_Status", StringUtil.LTrim( StringUtil.Str( (decimal)(AV23tview_NE_Status), 4, 0)));
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavTview_ne_status.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV23tview_NE_Status), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavTview_ne_status_Internalname, "Values", cmbavTview_ne_status.ToJavascriptSource(), true);
         }
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RFAL2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV112Pgmdesc = "就诊列表";
         AV111Pgmname = "BR_EncounterListww";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV111Pgmname", AV111Pgmname);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vPGMNAME", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV111Pgmname, "")), context));
         context.Gx_err = 0;
         edtavPatientno_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavPatientno_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavPatientno_Enabled), 5, 0)), !bGXsfl_76_Refreshing);
         edtavAdmitdate_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavAdmitdate_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavAdmitdate_Enabled), 5, 0)), !bGXsfl_76_Refreshing);
      }

      protected void RFAL2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridContainer.ClearRows();
         }
         wbStart = 76;
         /* Execute user event: Refresh */
         E25AL2 ();
         nGXsfl_76_idx = 1;
         sGXsfl_76_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_76_idx), 4, 0)), 4, "0");
         SubsflControlProps_762( ) ;
         bGXsfl_76_Refreshing = true;
         GridContainer.AddObjectProperty("GridName", "Grid");
         GridContainer.AddObjectProperty("CmpContext", "");
         GridContainer.AddObjectProperty("InMasterPage", "false");
         GridContainer.AddObjectProperty("Class", "GridWithPaginationBar GridWithBorderColor WorkWith");
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
            SubsflControlProps_762( ) ;
            GXPagingFrom2 = (int)(((subGrid_Rows==0) ? 0 : GRID_nFirstRecordOnPage));
            GXPagingTo2 = ((subGrid_Rows==0) ? 10000 : subGrid_Recordsperpage( )+1);
            pr_default.dynParam(0, new Object[]{ new Object[]{
                                                 A595View_New_Encounter2view_NE_Status ,
                                                 AV125BR_EncounterListwwDS_13_Tfview_new_encounter2view_ne_status_sels ,
                                                 AV113BR_EncounterListwwDS_1_Br_information_patientno ,
                                                 AV114BR_EncounterListwwDS_2_View_new_encounter2view_ne_israndapprove ,
                                                 AV115BR_EncounterListwwDS_3_View_new_encounter2view_ne_israndrecheck ,
                                                 AV116BR_EncounterListwwDS_4_View_new_encounter2view_ne_isupdate ,
                                                 AV117BR_EncounterListwwDS_5_Tfview_new_encounter2view_ne_encounterid ,
                                                 AV118BR_EncounterListwwDS_6_Tfview_new_encounter2view_ne_encounterid_to ,
                                                 AV120BR_EncounterListwwDS_8_Tfview_new_encounter2view_ne_information_patientno_sel ,
                                                 AV119BR_EncounterListwwDS_7_Tfview_new_encounter2view_ne_information_patientno ,
                                                 AV122BR_EncounterListwwDS_10_Tfview_new_encounter2view_ne_departmentadm_sel ,
                                                 AV121BR_EncounterListwwDS_9_Tfview_new_encounter2view_ne_departmentadm ,
                                                 AV124BR_EncounterListwwDS_12_Tfview_new_encounter2view_ne_enctype_sel ,
                                                 AV123BR_EncounterListwwDS_11_Tfview_new_encounter2view_ne_enctype ,
                                                 AV125BR_EncounterListwwDS_13_Tfview_new_encounter2view_ne_status_sels.Count ,
                                                 AV126BR_EncounterListwwDS_14_Tfview_new_encounter2view_ne_israndapprove_sel ,
                                                 AV127BR_EncounterListwwDS_15_Tfview_new_encounter2view_ne_israndrecheck_sel ,
                                                 AV128BR_EncounterListwwDS_16_Tfview_new_encounter2view_ne_isupdate_sel ,
                                                 AV20sBR_EncounterID ,
                                                 AV21view_NE_AdmitDate ,
                                                 AV22endview_NE_AdmitDate ,
                                                 AV23tview_NE_Status ,
                                                 A601View_New_Encounter2view_NE_Information_PatientNo ,
                                                 A597View_New_Encounter2view_NE_IsRandApprove ,
                                                 A596View_New_Encounter2view_NE_IsRandRecheck ,
                                                 A598View_New_Encounter2view_NE_IsUpdate ,
                                                 A591View_New_Encounter2view_NE_EncounterID ,
                                                 A593View_New_Encounter2view_NE_Departmentadm ,
                                                 A592View_New_Encounter2view_NE_ENCType ,
                                                 A594View_New_Encounter2view_NE_AdmitDate ,
                                                 AV13OrderedBy ,
                                                 AV14OrderedDsc ,
                                                 A599View_New_Encounter2view_NE_TenantTenantCode ,
                                                 AV85tCurrentCode } ,
                                                 new int[]{
                                                 TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.BOOLEAN, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING,
                                                 TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.INT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.DATE,
                                                 TypeConstants.DATE, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.BOOLEAN, TypeConstants.BOOLEAN, TypeConstants.BOOLEAN, TypeConstants.BOOLEAN, TypeConstants.BOOLEAN, TypeConstants.BOOLEAN,
                                                 TypeConstants.LONG, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DATE, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.STRING,
                                                 TypeConstants.BOOLEAN, TypeConstants.STRING
                                                 }
            } ) ;
            lV113BR_EncounterListwwDS_1_Br_information_patientno = StringUtil.Concat( StringUtil.RTrim( AV113BR_EncounterListwwDS_1_Br_information_patientno), "%", "");
            lV119BR_EncounterListwwDS_7_Tfview_new_encounter2view_ne_information_patientno = StringUtil.Concat( StringUtil.RTrim( AV119BR_EncounterListwwDS_7_Tfview_new_encounter2view_ne_information_patientno), "%", "");
            lV121BR_EncounterListwwDS_9_Tfview_new_encounter2view_ne_departmentadm = StringUtil.Concat( StringUtil.RTrim( AV121BR_EncounterListwwDS_9_Tfview_new_encounter2view_ne_departmentadm), "%", "");
            lV123BR_EncounterListwwDS_11_Tfview_new_encounter2view_ne_enctype = StringUtil.Concat( StringUtil.RTrim( AV123BR_EncounterListwwDS_11_Tfview_new_encounter2view_ne_enctype), "%", "");
            lV20sBR_EncounterID = StringUtil.Concat( StringUtil.RTrim( AV20sBR_EncounterID), "%", "");
            /* Using cursor H00AL2 */
            pr_default.execute(0, new Object[] {AV85tCurrentCode, lV113BR_EncounterListwwDS_1_Br_information_patientno, AV114BR_EncounterListwwDS_2_View_new_encounter2view_ne_israndapprove, AV115BR_EncounterListwwDS_3_View_new_encounter2view_ne_israndrecheck, AV116BR_EncounterListwwDS_4_View_new_encounter2view_ne_isupdate, AV117BR_EncounterListwwDS_5_Tfview_new_encounter2view_ne_encounterid, AV118BR_EncounterListwwDS_6_Tfview_new_encounter2view_ne_encounterid_to, lV119BR_EncounterListwwDS_7_Tfview_new_encounter2view_ne_information_patientno, AV120BR_EncounterListwwDS_8_Tfview_new_encounter2view_ne_information_patientno_sel, lV121BR_EncounterListwwDS_9_Tfview_new_encounter2view_ne_departmentadm, AV122BR_EncounterListwwDS_10_Tfview_new_encounter2view_ne_departmentadm_sel, lV123BR_EncounterListwwDS_11_Tfview_new_encounter2view_ne_enctype, AV124BR_EncounterListwwDS_12_Tfview_new_encounter2view_ne_enctype_sel, lV20sBR_EncounterID, AV21view_NE_AdmitDate, AV22endview_NE_AdmitDate, AV23tview_NE_Status, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_76_idx = 1;
            sGXsfl_76_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_76_idx), 4, 0)), 4, "0");
            SubsflControlProps_762( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < subGrid_Recordsperpage( ) ) ) ) )
            {
               A600View_New_Encounter2view_NE_Information_ID = H00AL2_A600View_New_Encounter2view_NE_Information_ID[0];
               n600View_New_Encounter2view_NE_Information_ID = H00AL2_n600View_New_Encounter2view_NE_Information_ID[0];
               A599View_New_Encounter2view_NE_TenantTenantCode = H00AL2_A599View_New_Encounter2view_NE_TenantTenantCode[0];
               n599View_New_Encounter2view_NE_TenantTenantCode = H00AL2_n599View_New_Encounter2view_NE_TenantTenantCode[0];
               A598View_New_Encounter2view_NE_IsUpdate = H00AL2_A598View_New_Encounter2view_NE_IsUpdate[0];
               n598View_New_Encounter2view_NE_IsUpdate = H00AL2_n598View_New_Encounter2view_NE_IsUpdate[0];
               A596View_New_Encounter2view_NE_IsRandRecheck = H00AL2_A596View_New_Encounter2view_NE_IsRandRecheck[0];
               n596View_New_Encounter2view_NE_IsRandRecheck = H00AL2_n596View_New_Encounter2view_NE_IsRandRecheck[0];
               A597View_New_Encounter2view_NE_IsRandApprove = H00AL2_A597View_New_Encounter2view_NE_IsRandApprove[0];
               n597View_New_Encounter2view_NE_IsRandApprove = H00AL2_n597View_New_Encounter2view_NE_IsRandApprove[0];
               A595View_New_Encounter2view_NE_Status = H00AL2_A595View_New_Encounter2view_NE_Status[0];
               n595View_New_Encounter2view_NE_Status = H00AL2_n595View_New_Encounter2view_NE_Status[0];
               A594View_New_Encounter2view_NE_AdmitDate = H00AL2_A594View_New_Encounter2view_NE_AdmitDate[0];
               n594View_New_Encounter2view_NE_AdmitDate = H00AL2_n594View_New_Encounter2view_NE_AdmitDate[0];
               A592View_New_Encounter2view_NE_ENCType = H00AL2_A592View_New_Encounter2view_NE_ENCType[0];
               n592View_New_Encounter2view_NE_ENCType = H00AL2_n592View_New_Encounter2view_NE_ENCType[0];
               A593View_New_Encounter2view_NE_Departmentadm = H00AL2_A593View_New_Encounter2view_NE_Departmentadm[0];
               n593View_New_Encounter2view_NE_Departmentadm = H00AL2_n593View_New_Encounter2view_NE_Departmentadm[0];
               A601View_New_Encounter2view_NE_Information_PatientNo = H00AL2_A601View_New_Encounter2view_NE_Information_PatientNo[0];
               n601View_New_Encounter2view_NE_Information_PatientNo = H00AL2_n601View_New_Encounter2view_NE_Information_PatientNo[0];
               A591View_New_Encounter2view_NE_EncounterID = H00AL2_A591View_New_Encounter2view_NE_EncounterID[0];
               E26AL2 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 76;
            WBAL0( ) ;
         }
         bGXsfl_76_Refreshing = true;
      }

      protected void send_integrity_lvl_hashesAL2( )
      {
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV111Pgmname));
         GxWebStd.gx_hidden_field( context, "gxhash_vPGMNAME", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV111Pgmname, "")), context));
         GxWebStd.gx_hidden_field( context, "gxhash_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID"+"_"+sGXsfl_76_idx, GetSecureSignedToken( sGXsfl_76_idx, context.localUtil.Format( (decimal)(A591View_New_Encounter2view_NE_EncounterID), "ZZZZZZZZZZZZZZZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "gxhash_VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_ID"+"_"+sGXsfl_76_idx, GetSecureSignedToken( sGXsfl_76_idx, context.localUtil.Format( (decimal)(A600View_New_Encounter2view_NE_Information_ID), "ZZZZZZZZZZZZZZZZZ9"), context));
         GxWebStd.gx_boolean_hidden_field( context, "vISINSERT", AV87IsInsert);
         GxWebStd.gx_hidden_field( context, "gxhash_vISINSERT", GetSecureSignedToken( "", AV87IsInsert, context));
         GxWebStd.gx_hidden_field( context, "gxhash_VIEW_NEW_ENCOUNTER2VIEW_NE_STATUS"+"_"+sGXsfl_76_idx, GetSecureSignedToken( sGXsfl_76_idx, context.localUtil.Format( (decimal)(A595View_New_Encounter2view_NE_Status), "ZZZ9"), context));
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
         AV113BR_EncounterListwwDS_1_Br_information_patientno = AV15BR_Information_PatientNo;
         AV114BR_EncounterListwwDS_2_View_new_encounter2view_ne_israndapprove = AV101View_New_Encounter2view_NE_IsRandApprove;
         AV115BR_EncounterListwwDS_3_View_new_encounter2view_ne_israndrecheck = AV102View_New_Encounter2view_NE_IsRandRecheck;
         AV116BR_EncounterListwwDS_4_View_new_encounter2view_ne_isupdate = AV103View_New_Encounter2view_NE_IsUpdate;
         AV117BR_EncounterListwwDS_5_Tfview_new_encounter2view_ne_encounterid = AV25TFView_New_Encounter2view_NE_EncounterID;
         AV118BR_EncounterListwwDS_6_Tfview_new_encounter2view_ne_encounterid_to = AV26TFView_New_Encounter2view_NE_EncounterID_To;
         AV119BR_EncounterListwwDS_7_Tfview_new_encounter2view_ne_information_patientno = AV67TFView_New_Encounter2view_NE_Information_PatientNo;
         AV120BR_EncounterListwwDS_8_Tfview_new_encounter2view_ne_information_patientno_sel = AV68TFView_New_Encounter2view_NE_Information_PatientNo_Sel;
         AV121BR_EncounterListwwDS_9_Tfview_new_encounter2view_ne_departmentadm = AV33TFView_New_Encounter2view_NE_Departmentadm;
         AV122BR_EncounterListwwDS_10_Tfview_new_encounter2view_ne_departmentadm_sel = AV34TFView_New_Encounter2view_NE_Departmentadm_Sel;
         AV123BR_EncounterListwwDS_11_Tfview_new_encounter2view_ne_enctype = AV29TFView_New_Encounter2view_NE_ENCType;
         AV124BR_EncounterListwwDS_12_Tfview_new_encounter2view_ne_enctype_sel = AV30TFView_New_Encounter2view_NE_ENCType_Sel;
         AV125BR_EncounterListwwDS_13_Tfview_new_encounter2view_ne_status_sels = AV105TFView_New_Encounter2view_NE_Status_Sels;
         AV126BR_EncounterListwwDS_14_Tfview_new_encounter2view_ne_israndapprove_sel = AV106TFView_New_Encounter2view_NE_IsRandApprove_Sel;
         AV127BR_EncounterListwwDS_15_Tfview_new_encounter2view_ne_israndrecheck_sel = AV107TFView_New_Encounter2view_NE_IsRandRecheck_Sel;
         AV128BR_EncounterListwwDS_16_Tfview_new_encounter2view_ne_isupdate_sel = AV108TFView_New_Encounter2view_NE_IsUpdate_Sel;
         pr_default.dynParam(1, new Object[]{ new Object[]{
                                              A595View_New_Encounter2view_NE_Status ,
                                              AV125BR_EncounterListwwDS_13_Tfview_new_encounter2view_ne_status_sels ,
                                              AV113BR_EncounterListwwDS_1_Br_information_patientno ,
                                              AV114BR_EncounterListwwDS_2_View_new_encounter2view_ne_israndapprove ,
                                              AV115BR_EncounterListwwDS_3_View_new_encounter2view_ne_israndrecheck ,
                                              AV116BR_EncounterListwwDS_4_View_new_encounter2view_ne_isupdate ,
                                              AV117BR_EncounterListwwDS_5_Tfview_new_encounter2view_ne_encounterid ,
                                              AV118BR_EncounterListwwDS_6_Tfview_new_encounter2view_ne_encounterid_to ,
                                              AV120BR_EncounterListwwDS_8_Tfview_new_encounter2view_ne_information_patientno_sel ,
                                              AV119BR_EncounterListwwDS_7_Tfview_new_encounter2view_ne_information_patientno ,
                                              AV122BR_EncounterListwwDS_10_Tfview_new_encounter2view_ne_departmentadm_sel ,
                                              AV121BR_EncounterListwwDS_9_Tfview_new_encounter2view_ne_departmentadm ,
                                              AV124BR_EncounterListwwDS_12_Tfview_new_encounter2view_ne_enctype_sel ,
                                              AV123BR_EncounterListwwDS_11_Tfview_new_encounter2view_ne_enctype ,
                                              AV125BR_EncounterListwwDS_13_Tfview_new_encounter2view_ne_status_sels.Count ,
                                              AV126BR_EncounterListwwDS_14_Tfview_new_encounter2view_ne_israndapprove_sel ,
                                              AV127BR_EncounterListwwDS_15_Tfview_new_encounter2view_ne_israndrecheck_sel ,
                                              AV128BR_EncounterListwwDS_16_Tfview_new_encounter2view_ne_isupdate_sel ,
                                              AV20sBR_EncounterID ,
                                              AV21view_NE_AdmitDate ,
                                              AV22endview_NE_AdmitDate ,
                                              AV23tview_NE_Status ,
                                              A601View_New_Encounter2view_NE_Information_PatientNo ,
                                              A597View_New_Encounter2view_NE_IsRandApprove ,
                                              A596View_New_Encounter2view_NE_IsRandRecheck ,
                                              A598View_New_Encounter2view_NE_IsUpdate ,
                                              A591View_New_Encounter2view_NE_EncounterID ,
                                              A593View_New_Encounter2view_NE_Departmentadm ,
                                              A592View_New_Encounter2view_NE_ENCType ,
                                              A594View_New_Encounter2view_NE_AdmitDate ,
                                              AV13OrderedBy ,
                                              AV14OrderedDsc ,
                                              A599View_New_Encounter2view_NE_TenantTenantCode ,
                                              AV85tCurrentCode } ,
                                              new int[]{
                                              TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.BOOLEAN, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.INT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.DATE,
                                              TypeConstants.DATE, TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.BOOLEAN, TypeConstants.BOOLEAN, TypeConstants.BOOLEAN, TypeConstants.BOOLEAN, TypeConstants.BOOLEAN, TypeConstants.BOOLEAN,
                                              TypeConstants.LONG, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DATE, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.STRING,
                                              TypeConstants.BOOLEAN, TypeConstants.STRING
                                              }
         } ) ;
         lV113BR_EncounterListwwDS_1_Br_information_patientno = StringUtil.Concat( StringUtil.RTrim( AV113BR_EncounterListwwDS_1_Br_information_patientno), "%", "");
         lV119BR_EncounterListwwDS_7_Tfview_new_encounter2view_ne_information_patientno = StringUtil.Concat( StringUtil.RTrim( AV119BR_EncounterListwwDS_7_Tfview_new_encounter2view_ne_information_patientno), "%", "");
         lV121BR_EncounterListwwDS_9_Tfview_new_encounter2view_ne_departmentadm = StringUtil.Concat( StringUtil.RTrim( AV121BR_EncounterListwwDS_9_Tfview_new_encounter2view_ne_departmentadm), "%", "");
         lV123BR_EncounterListwwDS_11_Tfview_new_encounter2view_ne_enctype = StringUtil.Concat( StringUtil.RTrim( AV123BR_EncounterListwwDS_11_Tfview_new_encounter2view_ne_enctype), "%", "");
         lV20sBR_EncounterID = StringUtil.Concat( StringUtil.RTrim( AV20sBR_EncounterID), "%", "");
         /* Using cursor H00AL3 */
         pr_default.execute(1, new Object[] {AV85tCurrentCode, lV113BR_EncounterListwwDS_1_Br_information_patientno, AV114BR_EncounterListwwDS_2_View_new_encounter2view_ne_israndapprove, AV115BR_EncounterListwwDS_3_View_new_encounter2view_ne_israndrecheck, AV116BR_EncounterListwwDS_4_View_new_encounter2view_ne_isupdate, AV117BR_EncounterListwwDS_5_Tfview_new_encounter2view_ne_encounterid, AV118BR_EncounterListwwDS_6_Tfview_new_encounter2view_ne_encounterid_to, lV119BR_EncounterListwwDS_7_Tfview_new_encounter2view_ne_information_patientno, AV120BR_EncounterListwwDS_8_Tfview_new_encounter2view_ne_information_patientno_sel, lV121BR_EncounterListwwDS_9_Tfview_new_encounter2view_ne_departmentadm, AV122BR_EncounterListwwDS_10_Tfview_new_encounter2view_ne_departmentadm_sel, lV123BR_EncounterListwwDS_11_Tfview_new_encounter2view_ne_enctype, AV124BR_EncounterListwwDS_12_Tfview_new_encounter2view_ne_enctype_sel, lV20sBR_EncounterID, AV21view_NE_AdmitDate, AV22endview_NE_AdmitDate, AV23tview_NE_Status});
         GRID_nRecordCount = H00AL3_AGRID_nRecordCount[0];
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
         AV113BR_EncounterListwwDS_1_Br_information_patientno = AV15BR_Information_PatientNo;
         AV114BR_EncounterListwwDS_2_View_new_encounter2view_ne_israndapprove = AV101View_New_Encounter2view_NE_IsRandApprove;
         AV115BR_EncounterListwwDS_3_View_new_encounter2view_ne_israndrecheck = AV102View_New_Encounter2view_NE_IsRandRecheck;
         AV116BR_EncounterListwwDS_4_View_new_encounter2view_ne_isupdate = AV103View_New_Encounter2view_NE_IsUpdate;
         AV117BR_EncounterListwwDS_5_Tfview_new_encounter2view_ne_encounterid = AV25TFView_New_Encounter2view_NE_EncounterID;
         AV118BR_EncounterListwwDS_6_Tfview_new_encounter2view_ne_encounterid_to = AV26TFView_New_Encounter2view_NE_EncounterID_To;
         AV119BR_EncounterListwwDS_7_Tfview_new_encounter2view_ne_information_patientno = AV67TFView_New_Encounter2view_NE_Information_PatientNo;
         AV120BR_EncounterListwwDS_8_Tfview_new_encounter2view_ne_information_patientno_sel = AV68TFView_New_Encounter2view_NE_Information_PatientNo_Sel;
         AV121BR_EncounterListwwDS_9_Tfview_new_encounter2view_ne_departmentadm = AV33TFView_New_Encounter2view_NE_Departmentadm;
         AV122BR_EncounterListwwDS_10_Tfview_new_encounter2view_ne_departmentadm_sel = AV34TFView_New_Encounter2view_NE_Departmentadm_Sel;
         AV123BR_EncounterListwwDS_11_Tfview_new_encounter2view_ne_enctype = AV29TFView_New_Encounter2view_NE_ENCType;
         AV124BR_EncounterListwwDS_12_Tfview_new_encounter2view_ne_enctype_sel = AV30TFView_New_Encounter2view_NE_ENCType_Sel;
         AV125BR_EncounterListwwDS_13_Tfview_new_encounter2view_ne_status_sels = AV105TFView_New_Encounter2view_NE_Status_Sels;
         AV126BR_EncounterListwwDS_14_Tfview_new_encounter2view_ne_israndapprove_sel = AV106TFView_New_Encounter2view_NE_IsRandApprove_Sel;
         AV127BR_EncounterListwwDS_15_Tfview_new_encounter2view_ne_israndrecheck_sel = AV107TFView_New_Encounter2view_NE_IsRandRecheck_Sel;
         AV128BR_EncounterListwwDS_16_Tfview_new_encounter2view_ne_isupdate_sel = AV108TFView_New_Encounter2view_NE_IsUpdate_Sel;
         GRID_nFirstRecordOnPage = 0;
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV15BR_Information_PatientNo, AV20sBR_EncounterID, AV21view_NE_AdmitDate, AV22endview_NE_AdmitDate, AV23tview_NE_Status, AV101View_New_Encounter2view_NE_IsRandApprove, AV102View_New_Encounter2view_NE_IsRandRecheck, AV103View_New_Encounter2view_NE_IsUpdate, AV13OrderedBy, AV14OrderedDsc, AV25TFView_New_Encounter2view_NE_EncounterID, AV26TFView_New_Encounter2view_NE_EncounterID_To, AV67TFView_New_Encounter2view_NE_Information_PatientNo, AV68TFView_New_Encounter2view_NE_Information_PatientNo_Sel, AV33TFView_New_Encounter2view_NE_Departmentadm, AV34TFView_New_Encounter2view_NE_Departmentadm_Sel, AV29TFView_New_Encounter2view_NE_ENCType, AV30TFView_New_Encounter2view_NE_ENCType_Sel, AV106TFView_New_Encounter2view_NE_IsRandApprove_Sel, AV107TFView_New_Encounter2view_NE_IsRandRecheck_Sel, AV108TFView_New_Encounter2view_NE_IsUpdate_Sel, AV85tCurrentCode, AV27ddo_View_New_Encounter2view_NE_EncounterIDTitleControlIdToReplace, AV69ddo_View_New_Encounter2view_NE_Information_PatientNoTitleControlIdToReplace, AV35ddo_View_New_Encounter2view_NE_DepartmentadmTitleControlIdToReplace, AV31ddo_View_New_Encounter2view_NE_ENCTypeTitleControlIdToReplace, AV45ddo_View_New_Encounter2view_NE_StatusTitleControlIdToReplace, AV53ddo_View_New_Encounter2view_NE_IsRandApproveTitleControlIdToReplace, AV49ddo_View_New_Encounter2view_NE_IsRandRecheckTitleControlIdToReplace, AV57ddo_View_New_Encounter2view_NE_IsUpdateTitleControlIdToReplace, AV105TFView_New_Encounter2view_NE_Status_Sels, AV111Pgmname, AV87IsInsert) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid_nextpage( )
      {
         AV113BR_EncounterListwwDS_1_Br_information_patientno = AV15BR_Information_PatientNo;
         AV114BR_EncounterListwwDS_2_View_new_encounter2view_ne_israndapprove = AV101View_New_Encounter2view_NE_IsRandApprove;
         AV115BR_EncounterListwwDS_3_View_new_encounter2view_ne_israndrecheck = AV102View_New_Encounter2view_NE_IsRandRecheck;
         AV116BR_EncounterListwwDS_4_View_new_encounter2view_ne_isupdate = AV103View_New_Encounter2view_NE_IsUpdate;
         AV117BR_EncounterListwwDS_5_Tfview_new_encounter2view_ne_encounterid = AV25TFView_New_Encounter2view_NE_EncounterID;
         AV118BR_EncounterListwwDS_6_Tfview_new_encounter2view_ne_encounterid_to = AV26TFView_New_Encounter2view_NE_EncounterID_To;
         AV119BR_EncounterListwwDS_7_Tfview_new_encounter2view_ne_information_patientno = AV67TFView_New_Encounter2view_NE_Information_PatientNo;
         AV120BR_EncounterListwwDS_8_Tfview_new_encounter2view_ne_information_patientno_sel = AV68TFView_New_Encounter2view_NE_Information_PatientNo_Sel;
         AV121BR_EncounterListwwDS_9_Tfview_new_encounter2view_ne_departmentadm = AV33TFView_New_Encounter2view_NE_Departmentadm;
         AV122BR_EncounterListwwDS_10_Tfview_new_encounter2view_ne_departmentadm_sel = AV34TFView_New_Encounter2view_NE_Departmentadm_Sel;
         AV123BR_EncounterListwwDS_11_Tfview_new_encounter2view_ne_enctype = AV29TFView_New_Encounter2view_NE_ENCType;
         AV124BR_EncounterListwwDS_12_Tfview_new_encounter2view_ne_enctype_sel = AV30TFView_New_Encounter2view_NE_ENCType_Sel;
         AV125BR_EncounterListwwDS_13_Tfview_new_encounter2view_ne_status_sels = AV105TFView_New_Encounter2view_NE_Status_Sels;
         AV126BR_EncounterListwwDS_14_Tfview_new_encounter2view_ne_israndapprove_sel = AV106TFView_New_Encounter2view_NE_IsRandApprove_Sel;
         AV127BR_EncounterListwwDS_15_Tfview_new_encounter2view_ne_israndrecheck_sel = AV107TFView_New_Encounter2view_NE_IsRandRecheck_Sel;
         AV128BR_EncounterListwwDS_16_Tfview_new_encounter2view_ne_isupdate_sel = AV108TFView_New_Encounter2view_NE_IsUpdate_Sel;
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
            gxgrGrid_refresh( subGrid_Rows, AV15BR_Information_PatientNo, AV20sBR_EncounterID, AV21view_NE_AdmitDate, AV22endview_NE_AdmitDate, AV23tview_NE_Status, AV101View_New_Encounter2view_NE_IsRandApprove, AV102View_New_Encounter2view_NE_IsRandRecheck, AV103View_New_Encounter2view_NE_IsUpdate, AV13OrderedBy, AV14OrderedDsc, AV25TFView_New_Encounter2view_NE_EncounterID, AV26TFView_New_Encounter2view_NE_EncounterID_To, AV67TFView_New_Encounter2view_NE_Information_PatientNo, AV68TFView_New_Encounter2view_NE_Information_PatientNo_Sel, AV33TFView_New_Encounter2view_NE_Departmentadm, AV34TFView_New_Encounter2view_NE_Departmentadm_Sel, AV29TFView_New_Encounter2view_NE_ENCType, AV30TFView_New_Encounter2view_NE_ENCType_Sel, AV106TFView_New_Encounter2view_NE_IsRandApprove_Sel, AV107TFView_New_Encounter2view_NE_IsRandRecheck_Sel, AV108TFView_New_Encounter2view_NE_IsUpdate_Sel, AV85tCurrentCode, AV27ddo_View_New_Encounter2view_NE_EncounterIDTitleControlIdToReplace, AV69ddo_View_New_Encounter2view_NE_Information_PatientNoTitleControlIdToReplace, AV35ddo_View_New_Encounter2view_NE_DepartmentadmTitleControlIdToReplace, AV31ddo_View_New_Encounter2view_NE_ENCTypeTitleControlIdToReplace, AV45ddo_View_New_Encounter2view_NE_StatusTitleControlIdToReplace, AV53ddo_View_New_Encounter2view_NE_IsRandApproveTitleControlIdToReplace, AV49ddo_View_New_Encounter2view_NE_IsRandRecheckTitleControlIdToReplace, AV57ddo_View_New_Encounter2view_NE_IsUpdateTitleControlIdToReplace, AV105TFView_New_Encounter2view_NE_Status_Sels, AV111Pgmname, AV87IsInsert) ;
         }
         send_integrity_footer_hashes( ) ;
         return (short)(((GRID_nEOF==0) ? 0 : 2)) ;
      }

      protected short subgrid_previouspage( )
      {
         AV113BR_EncounterListwwDS_1_Br_information_patientno = AV15BR_Information_PatientNo;
         AV114BR_EncounterListwwDS_2_View_new_encounter2view_ne_israndapprove = AV101View_New_Encounter2view_NE_IsRandApprove;
         AV115BR_EncounterListwwDS_3_View_new_encounter2view_ne_israndrecheck = AV102View_New_Encounter2view_NE_IsRandRecheck;
         AV116BR_EncounterListwwDS_4_View_new_encounter2view_ne_isupdate = AV103View_New_Encounter2view_NE_IsUpdate;
         AV117BR_EncounterListwwDS_5_Tfview_new_encounter2view_ne_encounterid = AV25TFView_New_Encounter2view_NE_EncounterID;
         AV118BR_EncounterListwwDS_6_Tfview_new_encounter2view_ne_encounterid_to = AV26TFView_New_Encounter2view_NE_EncounterID_To;
         AV119BR_EncounterListwwDS_7_Tfview_new_encounter2view_ne_information_patientno = AV67TFView_New_Encounter2view_NE_Information_PatientNo;
         AV120BR_EncounterListwwDS_8_Tfview_new_encounter2view_ne_information_patientno_sel = AV68TFView_New_Encounter2view_NE_Information_PatientNo_Sel;
         AV121BR_EncounterListwwDS_9_Tfview_new_encounter2view_ne_departmentadm = AV33TFView_New_Encounter2view_NE_Departmentadm;
         AV122BR_EncounterListwwDS_10_Tfview_new_encounter2view_ne_departmentadm_sel = AV34TFView_New_Encounter2view_NE_Departmentadm_Sel;
         AV123BR_EncounterListwwDS_11_Tfview_new_encounter2view_ne_enctype = AV29TFView_New_Encounter2view_NE_ENCType;
         AV124BR_EncounterListwwDS_12_Tfview_new_encounter2view_ne_enctype_sel = AV30TFView_New_Encounter2view_NE_ENCType_Sel;
         AV125BR_EncounterListwwDS_13_Tfview_new_encounter2view_ne_status_sels = AV105TFView_New_Encounter2view_NE_Status_Sels;
         AV126BR_EncounterListwwDS_14_Tfview_new_encounter2view_ne_israndapprove_sel = AV106TFView_New_Encounter2view_NE_IsRandApprove_Sel;
         AV127BR_EncounterListwwDS_15_Tfview_new_encounter2view_ne_israndrecheck_sel = AV107TFView_New_Encounter2view_NE_IsRandRecheck_Sel;
         AV128BR_EncounterListwwDS_16_Tfview_new_encounter2view_ne_isupdate_sel = AV108TFView_New_Encounter2view_NE_IsUpdate_Sel;
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
            gxgrGrid_refresh( subGrid_Rows, AV15BR_Information_PatientNo, AV20sBR_EncounterID, AV21view_NE_AdmitDate, AV22endview_NE_AdmitDate, AV23tview_NE_Status, AV101View_New_Encounter2view_NE_IsRandApprove, AV102View_New_Encounter2view_NE_IsRandRecheck, AV103View_New_Encounter2view_NE_IsUpdate, AV13OrderedBy, AV14OrderedDsc, AV25TFView_New_Encounter2view_NE_EncounterID, AV26TFView_New_Encounter2view_NE_EncounterID_To, AV67TFView_New_Encounter2view_NE_Information_PatientNo, AV68TFView_New_Encounter2view_NE_Information_PatientNo_Sel, AV33TFView_New_Encounter2view_NE_Departmentadm, AV34TFView_New_Encounter2view_NE_Departmentadm_Sel, AV29TFView_New_Encounter2view_NE_ENCType, AV30TFView_New_Encounter2view_NE_ENCType_Sel, AV106TFView_New_Encounter2view_NE_IsRandApprove_Sel, AV107TFView_New_Encounter2view_NE_IsRandRecheck_Sel, AV108TFView_New_Encounter2view_NE_IsUpdate_Sel, AV85tCurrentCode, AV27ddo_View_New_Encounter2view_NE_EncounterIDTitleControlIdToReplace, AV69ddo_View_New_Encounter2view_NE_Information_PatientNoTitleControlIdToReplace, AV35ddo_View_New_Encounter2view_NE_DepartmentadmTitleControlIdToReplace, AV31ddo_View_New_Encounter2view_NE_ENCTypeTitleControlIdToReplace, AV45ddo_View_New_Encounter2view_NE_StatusTitleControlIdToReplace, AV53ddo_View_New_Encounter2view_NE_IsRandApproveTitleControlIdToReplace, AV49ddo_View_New_Encounter2view_NE_IsRandRecheckTitleControlIdToReplace, AV57ddo_View_New_Encounter2view_NE_IsUpdateTitleControlIdToReplace, AV105TFView_New_Encounter2view_NE_Status_Sels, AV111Pgmname, AV87IsInsert) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid_lastpage( )
      {
         AV113BR_EncounterListwwDS_1_Br_information_patientno = AV15BR_Information_PatientNo;
         AV114BR_EncounterListwwDS_2_View_new_encounter2view_ne_israndapprove = AV101View_New_Encounter2view_NE_IsRandApprove;
         AV115BR_EncounterListwwDS_3_View_new_encounter2view_ne_israndrecheck = AV102View_New_Encounter2view_NE_IsRandRecheck;
         AV116BR_EncounterListwwDS_4_View_new_encounter2view_ne_isupdate = AV103View_New_Encounter2view_NE_IsUpdate;
         AV117BR_EncounterListwwDS_5_Tfview_new_encounter2view_ne_encounterid = AV25TFView_New_Encounter2view_NE_EncounterID;
         AV118BR_EncounterListwwDS_6_Tfview_new_encounter2view_ne_encounterid_to = AV26TFView_New_Encounter2view_NE_EncounterID_To;
         AV119BR_EncounterListwwDS_7_Tfview_new_encounter2view_ne_information_patientno = AV67TFView_New_Encounter2view_NE_Information_PatientNo;
         AV120BR_EncounterListwwDS_8_Tfview_new_encounter2view_ne_information_patientno_sel = AV68TFView_New_Encounter2view_NE_Information_PatientNo_Sel;
         AV121BR_EncounterListwwDS_9_Tfview_new_encounter2view_ne_departmentadm = AV33TFView_New_Encounter2view_NE_Departmentadm;
         AV122BR_EncounterListwwDS_10_Tfview_new_encounter2view_ne_departmentadm_sel = AV34TFView_New_Encounter2view_NE_Departmentadm_Sel;
         AV123BR_EncounterListwwDS_11_Tfview_new_encounter2view_ne_enctype = AV29TFView_New_Encounter2view_NE_ENCType;
         AV124BR_EncounterListwwDS_12_Tfview_new_encounter2view_ne_enctype_sel = AV30TFView_New_Encounter2view_NE_ENCType_Sel;
         AV125BR_EncounterListwwDS_13_Tfview_new_encounter2view_ne_status_sels = AV105TFView_New_Encounter2view_NE_Status_Sels;
         AV126BR_EncounterListwwDS_14_Tfview_new_encounter2view_ne_israndapprove_sel = AV106TFView_New_Encounter2view_NE_IsRandApprove_Sel;
         AV127BR_EncounterListwwDS_15_Tfview_new_encounter2view_ne_israndrecheck_sel = AV107TFView_New_Encounter2view_NE_IsRandRecheck_Sel;
         AV128BR_EncounterListwwDS_16_Tfview_new_encounter2view_ne_isupdate_sel = AV108TFView_New_Encounter2view_NE_IsUpdate_Sel;
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
            gxgrGrid_refresh( subGrid_Rows, AV15BR_Information_PatientNo, AV20sBR_EncounterID, AV21view_NE_AdmitDate, AV22endview_NE_AdmitDate, AV23tview_NE_Status, AV101View_New_Encounter2view_NE_IsRandApprove, AV102View_New_Encounter2view_NE_IsRandRecheck, AV103View_New_Encounter2view_NE_IsUpdate, AV13OrderedBy, AV14OrderedDsc, AV25TFView_New_Encounter2view_NE_EncounterID, AV26TFView_New_Encounter2view_NE_EncounterID_To, AV67TFView_New_Encounter2view_NE_Information_PatientNo, AV68TFView_New_Encounter2view_NE_Information_PatientNo_Sel, AV33TFView_New_Encounter2view_NE_Departmentadm, AV34TFView_New_Encounter2view_NE_Departmentadm_Sel, AV29TFView_New_Encounter2view_NE_ENCType, AV30TFView_New_Encounter2view_NE_ENCType_Sel, AV106TFView_New_Encounter2view_NE_IsRandApprove_Sel, AV107TFView_New_Encounter2view_NE_IsRandRecheck_Sel, AV108TFView_New_Encounter2view_NE_IsUpdate_Sel, AV85tCurrentCode, AV27ddo_View_New_Encounter2view_NE_EncounterIDTitleControlIdToReplace, AV69ddo_View_New_Encounter2view_NE_Information_PatientNoTitleControlIdToReplace, AV35ddo_View_New_Encounter2view_NE_DepartmentadmTitleControlIdToReplace, AV31ddo_View_New_Encounter2view_NE_ENCTypeTitleControlIdToReplace, AV45ddo_View_New_Encounter2view_NE_StatusTitleControlIdToReplace, AV53ddo_View_New_Encounter2view_NE_IsRandApproveTitleControlIdToReplace, AV49ddo_View_New_Encounter2view_NE_IsRandRecheckTitleControlIdToReplace, AV57ddo_View_New_Encounter2view_NE_IsUpdateTitleControlIdToReplace, AV105TFView_New_Encounter2view_NE_Status_Sels, AV111Pgmname, AV87IsInsert) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected int subgrid_gotopage( int nPageNo )
      {
         AV113BR_EncounterListwwDS_1_Br_information_patientno = AV15BR_Information_PatientNo;
         AV114BR_EncounterListwwDS_2_View_new_encounter2view_ne_israndapprove = AV101View_New_Encounter2view_NE_IsRandApprove;
         AV115BR_EncounterListwwDS_3_View_new_encounter2view_ne_israndrecheck = AV102View_New_Encounter2view_NE_IsRandRecheck;
         AV116BR_EncounterListwwDS_4_View_new_encounter2view_ne_isupdate = AV103View_New_Encounter2view_NE_IsUpdate;
         AV117BR_EncounterListwwDS_5_Tfview_new_encounter2view_ne_encounterid = AV25TFView_New_Encounter2view_NE_EncounterID;
         AV118BR_EncounterListwwDS_6_Tfview_new_encounter2view_ne_encounterid_to = AV26TFView_New_Encounter2view_NE_EncounterID_To;
         AV119BR_EncounterListwwDS_7_Tfview_new_encounter2view_ne_information_patientno = AV67TFView_New_Encounter2view_NE_Information_PatientNo;
         AV120BR_EncounterListwwDS_8_Tfview_new_encounter2view_ne_information_patientno_sel = AV68TFView_New_Encounter2view_NE_Information_PatientNo_Sel;
         AV121BR_EncounterListwwDS_9_Tfview_new_encounter2view_ne_departmentadm = AV33TFView_New_Encounter2view_NE_Departmentadm;
         AV122BR_EncounterListwwDS_10_Tfview_new_encounter2view_ne_departmentadm_sel = AV34TFView_New_Encounter2view_NE_Departmentadm_Sel;
         AV123BR_EncounterListwwDS_11_Tfview_new_encounter2view_ne_enctype = AV29TFView_New_Encounter2view_NE_ENCType;
         AV124BR_EncounterListwwDS_12_Tfview_new_encounter2view_ne_enctype_sel = AV30TFView_New_Encounter2view_NE_ENCType_Sel;
         AV125BR_EncounterListwwDS_13_Tfview_new_encounter2view_ne_status_sels = AV105TFView_New_Encounter2view_NE_Status_Sels;
         AV126BR_EncounterListwwDS_14_Tfview_new_encounter2view_ne_israndapprove_sel = AV106TFView_New_Encounter2view_NE_IsRandApprove_Sel;
         AV127BR_EncounterListwwDS_15_Tfview_new_encounter2view_ne_israndrecheck_sel = AV107TFView_New_Encounter2view_NE_IsRandRecheck_Sel;
         AV128BR_EncounterListwwDS_16_Tfview_new_encounter2view_ne_isupdate_sel = AV108TFView_New_Encounter2view_NE_IsUpdate_Sel;
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
            gxgrGrid_refresh( subGrid_Rows, AV15BR_Information_PatientNo, AV20sBR_EncounterID, AV21view_NE_AdmitDate, AV22endview_NE_AdmitDate, AV23tview_NE_Status, AV101View_New_Encounter2view_NE_IsRandApprove, AV102View_New_Encounter2view_NE_IsRandRecheck, AV103View_New_Encounter2view_NE_IsUpdate, AV13OrderedBy, AV14OrderedDsc, AV25TFView_New_Encounter2view_NE_EncounterID, AV26TFView_New_Encounter2view_NE_EncounterID_To, AV67TFView_New_Encounter2view_NE_Information_PatientNo, AV68TFView_New_Encounter2view_NE_Information_PatientNo_Sel, AV33TFView_New_Encounter2view_NE_Departmentadm, AV34TFView_New_Encounter2view_NE_Departmentadm_Sel, AV29TFView_New_Encounter2view_NE_ENCType, AV30TFView_New_Encounter2view_NE_ENCType_Sel, AV106TFView_New_Encounter2view_NE_IsRandApprove_Sel, AV107TFView_New_Encounter2view_NE_IsRandRecheck_Sel, AV108TFView_New_Encounter2view_NE_IsUpdate_Sel, AV85tCurrentCode, AV27ddo_View_New_Encounter2view_NE_EncounterIDTitleControlIdToReplace, AV69ddo_View_New_Encounter2view_NE_Information_PatientNoTitleControlIdToReplace, AV35ddo_View_New_Encounter2view_NE_DepartmentadmTitleControlIdToReplace, AV31ddo_View_New_Encounter2view_NE_ENCTypeTitleControlIdToReplace, AV45ddo_View_New_Encounter2view_NE_StatusTitleControlIdToReplace, AV53ddo_View_New_Encounter2view_NE_IsRandApproveTitleControlIdToReplace, AV49ddo_View_New_Encounter2view_NE_IsRandRecheckTitleControlIdToReplace, AV57ddo_View_New_Encounter2view_NE_IsUpdateTitleControlIdToReplace, AV105TFView_New_Encounter2view_NE_Status_Sels, AV111Pgmname, AV87IsInsert) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUPAL0( )
      {
         /* Before Start, stand alone formulas. */
         AV112Pgmdesc = "就诊列表";
         AV111Pgmname = "BR_EncounterListww";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV111Pgmname", AV111Pgmname);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vPGMNAME", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV111Pgmname, "")), context));
         context.Gx_err = 0;
         edtavPatientno_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavPatientno_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavPatientno_Enabled), 5, 0)), !bGXsfl_76_Refreshing);
         edtavAdmitdate_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavAdmitdate_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavAdmitdate_Enabled), 5, 0)), !bGXsfl_76_Refreshing);
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E24AL2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( "vDDO_TITLESETTINGSICONS"), AV70DDO_TitleSettingsIcons);
            ajax_req_read_hidden_sdt(cgiGet( "vVIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERIDTITLEFILTERDATA"), AV24View_New_Encounter2view_NE_EncounterIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vVIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNOTITLEFILTERDATA"), AV66View_New_Encounter2view_NE_Information_PatientNoTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vVIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADMTITLEFILTERDATA"), AV32View_New_Encounter2view_NE_DepartmentadmTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vVIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPETITLEFILTERDATA"), AV28View_New_Encounter2view_NE_ENCTypeTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vVIEW_NEW_ENCOUNTER2VIEW_NE_STATUSTITLEFILTERDATA"), AV42View_New_Encounter2view_NE_StatusTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVETITLEFILTERDATA"), AV50View_New_Encounter2view_NE_IsRandApproveTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECKTITLEFILTERDATA"), AV46View_New_Encounter2view_NE_IsRandRecheckTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vVIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATETITLEFILTERDATA"), AV54View_New_Encounter2view_NE_IsUpdateTitleFilterData);
            /* Read variables values. */
            AV15BR_Information_PatientNo = cgiGet( edtavBr_information_patientno_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15BR_Information_PatientNo", AV15BR_Information_PatientNo);
            AV20sBR_EncounterID = cgiGet( edtavSbr_encounterid_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20sBR_EncounterID", AV20sBR_EncounterID);
            if ( context.localUtil.VCDate( cgiGet( edtavView_ne_admitdate_Internalname), 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"view_NE_Admit Date"}), 1, "vVIEW_NE_ADMITDATE");
               GX_FocusControl = edtavView_ne_admitdate_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV21view_NE_AdmitDate = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21view_NE_AdmitDate", context.localUtil.Format(AV21view_NE_AdmitDate, "9999/99/99"));
            }
            else
            {
               AV21view_NE_AdmitDate = context.localUtil.CToD( cgiGet( edtavView_ne_admitdate_Internalname), 0);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21view_NE_AdmitDate", context.localUtil.Format(AV21view_NE_AdmitDate, "9999/99/99"));
            }
            if ( context.localUtil.VCDate( cgiGet( edtavEndview_ne_admitdate_Internalname), 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"endview_NE_Admit Date"}), 1, "vENDVIEW_NE_ADMITDATE");
               GX_FocusControl = edtavEndview_ne_admitdate_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV22endview_NE_AdmitDate = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22endview_NE_AdmitDate", context.localUtil.Format(AV22endview_NE_AdmitDate, "9999/99/99"));
            }
            else
            {
               AV22endview_NE_AdmitDate = context.localUtil.CToD( cgiGet( edtavEndview_ne_admitdate_Internalname), 0);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22endview_NE_AdmitDate", context.localUtil.Format(AV22endview_NE_AdmitDate, "9999/99/99"));
            }
            cmbavTview_ne_status.Name = cmbavTview_ne_status_Internalname;
            cmbavTview_ne_status.CurrentValue = cgiGet( cmbavTview_ne_status_Internalname);
            AV23tview_NE_Status = (short)(NumberUtil.Val( cgiGet( cmbavTview_ne_status_Internalname), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23tview_NE_Status", StringUtil.LTrim( StringUtil.Str( (decimal)(AV23tview_NE_Status), 4, 0)));
            AV101View_New_Encounter2view_NE_IsRandApprove = StringUtil.StrToBool( cgiGet( chkavView_new_encounter2view_ne_israndapprove_Internalname));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV101View_New_Encounter2view_NE_IsRandApprove", AV101View_New_Encounter2view_NE_IsRandApprove);
            AV102View_New_Encounter2view_NE_IsRandRecheck = StringUtil.StrToBool( cgiGet( chkavView_new_encounter2view_ne_israndrecheck_Internalname));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV102View_New_Encounter2view_NE_IsRandRecheck", AV102View_New_Encounter2view_NE_IsRandRecheck);
            AV103View_New_Encounter2view_NE_IsUpdate = StringUtil.StrToBool( cgiGet( chkavView_new_encounter2view_ne_isupdate_Internalname));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV103View_New_Encounter2view_NE_IsUpdate", AV103View_New_Encounter2view_NE_IsUpdate);
            AV27ddo_View_New_Encounter2view_NE_EncounterIDTitleControlIdToReplace = cgiGet( edtavDdo_view_new_encounter2view_ne_encounteridtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27ddo_View_New_Encounter2view_NE_EncounterIDTitleControlIdToReplace", AV27ddo_View_New_Encounter2view_NE_EncounterIDTitleControlIdToReplace);
            AV69ddo_View_New_Encounter2view_NE_Information_PatientNoTitleControlIdToReplace = cgiGet( edtavDdo_view_new_encounter2view_ne_information_patientnotitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV69ddo_View_New_Encounter2view_NE_Information_PatientNoTitleControlIdToReplace", AV69ddo_View_New_Encounter2view_NE_Information_PatientNoTitleControlIdToReplace);
            AV35ddo_View_New_Encounter2view_NE_DepartmentadmTitleControlIdToReplace = cgiGet( edtavDdo_view_new_encounter2view_ne_departmentadmtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV35ddo_View_New_Encounter2view_NE_DepartmentadmTitleControlIdToReplace", AV35ddo_View_New_Encounter2view_NE_DepartmentadmTitleControlIdToReplace);
            AV31ddo_View_New_Encounter2view_NE_ENCTypeTitleControlIdToReplace = cgiGet( edtavDdo_view_new_encounter2view_ne_enctypetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31ddo_View_New_Encounter2view_NE_ENCTypeTitleControlIdToReplace", AV31ddo_View_New_Encounter2view_NE_ENCTypeTitleControlIdToReplace);
            AV45ddo_View_New_Encounter2view_NE_StatusTitleControlIdToReplace = cgiGet( edtavDdo_view_new_encounter2view_ne_statustitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV45ddo_View_New_Encounter2view_NE_StatusTitleControlIdToReplace", AV45ddo_View_New_Encounter2view_NE_StatusTitleControlIdToReplace);
            AV53ddo_View_New_Encounter2view_NE_IsRandApproveTitleControlIdToReplace = cgiGet( edtavDdo_view_new_encounter2view_ne_israndapprovetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV53ddo_View_New_Encounter2view_NE_IsRandApproveTitleControlIdToReplace", AV53ddo_View_New_Encounter2view_NE_IsRandApproveTitleControlIdToReplace);
            AV49ddo_View_New_Encounter2view_NE_IsRandRecheckTitleControlIdToReplace = cgiGet( edtavDdo_view_new_encounter2view_ne_israndrechecktitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV49ddo_View_New_Encounter2view_NE_IsRandRecheckTitleControlIdToReplace", AV49ddo_View_New_Encounter2view_NE_IsRandRecheckTitleControlIdToReplace);
            AV57ddo_View_New_Encounter2view_NE_IsUpdateTitleControlIdToReplace = cgiGet( edtavDdo_view_new_encounter2view_ne_isupdatetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV57ddo_View_New_Encounter2view_NE_IsUpdateTitleControlIdToReplace", AV57ddo_View_New_Encounter2view_NE_IsUpdateTitleControlIdToReplace);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavView_new_encounter2view_ne_encounterid_selected_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavView_new_encounter2view_ne_encounterid_selected_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vVIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID_SELECTED");
               GX_FocusControl = edtavView_new_encounter2view_ne_encounterid_selected_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV82View_New_Encounter2view_NE_EncounterID_Selected = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV82View_New_Encounter2view_NE_EncounterID_Selected", StringUtil.LTrim( StringUtil.Str( (decimal)(AV82View_New_Encounter2view_NE_EncounterID_Selected), 18, 0)));
            }
            else
            {
               AV82View_New_Encounter2view_NE_EncounterID_Selected = (long)(context.localUtil.CToN( cgiGet( edtavView_new_encounter2view_ne_encounterid_selected_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV82View_New_Encounter2view_NE_EncounterID_Selected", StringUtil.LTrim( StringUtil.Str( (decimal)(AV82View_New_Encounter2view_NE_EncounterID_Selected), 18, 0)));
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
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfview_new_encounter2view_ne_encounterid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfview_new_encounter2view_ne_encounterid_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID");
               GX_FocusControl = edtavTfview_new_encounter2view_ne_encounterid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV25TFView_New_Encounter2view_NE_EncounterID = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25TFView_New_Encounter2view_NE_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV25TFView_New_Encounter2view_NE_EncounterID), 18, 0)));
            }
            else
            {
               AV25TFView_New_Encounter2view_NE_EncounterID = (long)(context.localUtil.CToN( cgiGet( edtavTfview_new_encounter2view_ne_encounterid_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25TFView_New_Encounter2view_NE_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV25TFView_New_Encounter2view_NE_EncounterID), 18, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfview_new_encounter2view_ne_encounterid_to_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfview_new_encounter2view_ne_encounterid_to_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID_TO");
               GX_FocusControl = edtavTfview_new_encounter2view_ne_encounterid_to_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV26TFView_New_Encounter2view_NE_EncounterID_To = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26TFView_New_Encounter2view_NE_EncounterID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV26TFView_New_Encounter2view_NE_EncounterID_To), 18, 0)));
            }
            else
            {
               AV26TFView_New_Encounter2view_NE_EncounterID_To = (long)(context.localUtil.CToN( cgiGet( edtavTfview_new_encounter2view_ne_encounterid_to_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26TFView_New_Encounter2view_NE_EncounterID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV26TFView_New_Encounter2view_NE_EncounterID_To), 18, 0)));
            }
            AV67TFView_New_Encounter2view_NE_Information_PatientNo = cgiGet( edtavTfview_new_encounter2view_ne_information_patientno_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV67TFView_New_Encounter2view_NE_Information_PatientNo", AV67TFView_New_Encounter2view_NE_Information_PatientNo);
            AV68TFView_New_Encounter2view_NE_Information_PatientNo_Sel = cgiGet( edtavTfview_new_encounter2view_ne_information_patientno_sel_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV68TFView_New_Encounter2view_NE_Information_PatientNo_Sel", AV68TFView_New_Encounter2view_NE_Information_PatientNo_Sel);
            AV33TFView_New_Encounter2view_NE_Departmentadm = cgiGet( edtavTfview_new_encounter2view_ne_departmentadm_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33TFView_New_Encounter2view_NE_Departmentadm", AV33TFView_New_Encounter2view_NE_Departmentadm);
            AV34TFView_New_Encounter2view_NE_Departmentadm_Sel = cgiGet( edtavTfview_new_encounter2view_ne_departmentadm_sel_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34TFView_New_Encounter2view_NE_Departmentadm_Sel", AV34TFView_New_Encounter2view_NE_Departmentadm_Sel);
            AV29TFView_New_Encounter2view_NE_ENCType = cgiGet( edtavTfview_new_encounter2view_ne_enctype_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29TFView_New_Encounter2view_NE_ENCType", AV29TFView_New_Encounter2view_NE_ENCType);
            AV30TFView_New_Encounter2view_NE_ENCType_Sel = cgiGet( edtavTfview_new_encounter2view_ne_enctype_sel_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30TFView_New_Encounter2view_NE_ENCType_Sel", AV30TFView_New_Encounter2view_NE_ENCType_Sel);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfview_new_encounter2view_ne_israndapprove_sel_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfview_new_encounter2view_ne_israndapprove_sel_Internalname), ".", ",") > Convert.ToDecimal( 9 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE_SEL");
               GX_FocusControl = edtavTfview_new_encounter2view_ne_israndapprove_sel_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV106TFView_New_Encounter2view_NE_IsRandApprove_Sel = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV106TFView_New_Encounter2view_NE_IsRandApprove_Sel", StringUtil.Str( (decimal)(AV106TFView_New_Encounter2view_NE_IsRandApprove_Sel), 1, 0));
            }
            else
            {
               AV106TFView_New_Encounter2view_NE_IsRandApprove_Sel = (short)(context.localUtil.CToN( cgiGet( edtavTfview_new_encounter2view_ne_israndapprove_sel_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV106TFView_New_Encounter2view_NE_IsRandApprove_Sel", StringUtil.Str( (decimal)(AV106TFView_New_Encounter2view_NE_IsRandApprove_Sel), 1, 0));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfview_new_encounter2view_ne_israndrecheck_sel_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfview_new_encounter2view_ne_israndrecheck_sel_Internalname), ".", ",") > Convert.ToDecimal( 9 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK_SEL");
               GX_FocusControl = edtavTfview_new_encounter2view_ne_israndrecheck_sel_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV107TFView_New_Encounter2view_NE_IsRandRecheck_Sel = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV107TFView_New_Encounter2view_NE_IsRandRecheck_Sel", StringUtil.Str( (decimal)(AV107TFView_New_Encounter2view_NE_IsRandRecheck_Sel), 1, 0));
            }
            else
            {
               AV107TFView_New_Encounter2view_NE_IsRandRecheck_Sel = (short)(context.localUtil.CToN( cgiGet( edtavTfview_new_encounter2view_ne_israndrecheck_sel_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV107TFView_New_Encounter2view_NE_IsRandRecheck_Sel", StringUtil.Str( (decimal)(AV107TFView_New_Encounter2view_NE_IsRandRecheck_Sel), 1, 0));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfview_new_encounter2view_ne_isupdate_sel_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfview_new_encounter2view_ne_isupdate_sel_Internalname), ".", ",") > Convert.ToDecimal( 9 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE_SEL");
               GX_FocusControl = edtavTfview_new_encounter2view_ne_isupdate_sel_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV108TFView_New_Encounter2view_NE_IsUpdate_Sel = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV108TFView_New_Encounter2view_NE_IsUpdate_Sel", StringUtil.Str( (decimal)(AV108TFView_New_Encounter2view_NE_IsUpdate_Sel), 1, 0));
            }
            else
            {
               AV108TFView_New_Encounter2view_NE_IsUpdate_Sel = (short)(context.localUtil.CToN( cgiGet( edtavTfview_new_encounter2view_ne_isupdate_sel_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV108TFView_New_Encounter2view_NE_IsUpdate_Sel", StringUtil.Str( (decimal)(AV108TFView_New_Encounter2view_NE_IsUpdate_Sel), 1, 0));
            }
            /* Read saved values. */
            nRC_GXsfl_76 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_76"), ".", ","));
            AV72GridCurrentPage = (long)(context.localUtil.CToN( cgiGet( "vGRIDCURRENTPAGE"), ".", ","));
            AV73GridPageCount = (long)(context.localUtil.CToN( cgiGet( "vGRIDPAGECOUNT"), ".", ","));
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
            Ddo_view_new_encounter2view_ne_encounterid_Caption = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID_Caption");
            Ddo_view_new_encounter2view_ne_encounterid_Tooltip = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID_Tooltip");
            Ddo_view_new_encounter2view_ne_encounterid_Cls = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID_Cls");
            Ddo_view_new_encounter2view_ne_encounterid_Filteredtext_set = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID_Filteredtext_set");
            Ddo_view_new_encounter2view_ne_encounterid_Filteredtextto_set = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID_Filteredtextto_set");
            Ddo_view_new_encounter2view_ne_encounterid_Dropdownoptionstype = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID_Dropdownoptionstype");
            Ddo_view_new_encounter2view_ne_encounterid_Titlecontrolidtoreplace = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID_Titlecontrolidtoreplace");
            Ddo_view_new_encounter2view_ne_encounterid_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID_Includesortasc"));
            Ddo_view_new_encounter2view_ne_encounterid_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID_Includesortdsc"));
            Ddo_view_new_encounter2view_ne_encounterid_Sortedstatus = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID_Sortedstatus");
            Ddo_view_new_encounter2view_ne_encounterid_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID_Includefilter"));
            Ddo_view_new_encounter2view_ne_encounterid_Filtertype = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID_Filtertype");
            Ddo_view_new_encounter2view_ne_encounterid_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID_Filterisrange"));
            Ddo_view_new_encounter2view_ne_encounterid_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID_Includedatalist"));
            Ddo_view_new_encounter2view_ne_encounterid_Sortasc = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID_Sortasc");
            Ddo_view_new_encounter2view_ne_encounterid_Sortdsc = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID_Sortdsc");
            Ddo_view_new_encounter2view_ne_encounterid_Cleanfilter = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID_Cleanfilter");
            Ddo_view_new_encounter2view_ne_encounterid_Rangefilterfrom = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID_Rangefilterfrom");
            Ddo_view_new_encounter2view_ne_encounterid_Rangefilterto = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID_Rangefilterto");
            Ddo_view_new_encounter2view_ne_encounterid_Searchbuttontext = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID_Searchbuttontext");
            Ddo_view_new_encounter2view_ne_information_patientno_Caption = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO_Caption");
            Ddo_view_new_encounter2view_ne_information_patientno_Tooltip = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO_Tooltip");
            Ddo_view_new_encounter2view_ne_information_patientno_Cls = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO_Cls");
            Ddo_view_new_encounter2view_ne_information_patientno_Filteredtext_set = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO_Filteredtext_set");
            Ddo_view_new_encounter2view_ne_information_patientno_Selectedvalue_set = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO_Selectedvalue_set");
            Ddo_view_new_encounter2view_ne_information_patientno_Dropdownoptionstype = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO_Dropdownoptionstype");
            Ddo_view_new_encounter2view_ne_information_patientno_Titlecontrolidtoreplace = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO_Titlecontrolidtoreplace");
            Ddo_view_new_encounter2view_ne_information_patientno_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO_Includesortasc"));
            Ddo_view_new_encounter2view_ne_information_patientno_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO_Includesortdsc"));
            Ddo_view_new_encounter2view_ne_information_patientno_Sortedstatus = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO_Sortedstatus");
            Ddo_view_new_encounter2view_ne_information_patientno_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO_Includefilter"));
            Ddo_view_new_encounter2view_ne_information_patientno_Filtertype = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO_Filtertype");
            Ddo_view_new_encounter2view_ne_information_patientno_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO_Filterisrange"));
            Ddo_view_new_encounter2view_ne_information_patientno_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO_Includedatalist"));
            Ddo_view_new_encounter2view_ne_information_patientno_Datalisttype = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO_Datalisttype");
            Ddo_view_new_encounter2view_ne_information_patientno_Datalistproc = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO_Datalistproc");
            Ddo_view_new_encounter2view_ne_information_patientno_Datalistupdateminimumcharacters = (int)(context.localUtil.CToN( cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO_Datalistupdateminimumcharacters"), ".", ","));
            Ddo_view_new_encounter2view_ne_information_patientno_Sortasc = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO_Sortasc");
            Ddo_view_new_encounter2view_ne_information_patientno_Sortdsc = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO_Sortdsc");
            Ddo_view_new_encounter2view_ne_information_patientno_Loadingdata = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO_Loadingdata");
            Ddo_view_new_encounter2view_ne_information_patientno_Cleanfilter = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO_Cleanfilter");
            Ddo_view_new_encounter2view_ne_information_patientno_Noresultsfound = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO_Noresultsfound");
            Ddo_view_new_encounter2view_ne_information_patientno_Searchbuttontext = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO_Searchbuttontext");
            Ddo_view_new_encounter2view_ne_departmentadm_Caption = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM_Caption");
            Ddo_view_new_encounter2view_ne_departmentadm_Tooltip = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM_Tooltip");
            Ddo_view_new_encounter2view_ne_departmentadm_Cls = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM_Cls");
            Ddo_view_new_encounter2view_ne_departmentadm_Filteredtext_set = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM_Filteredtext_set");
            Ddo_view_new_encounter2view_ne_departmentadm_Selectedvalue_set = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM_Selectedvalue_set");
            Ddo_view_new_encounter2view_ne_departmentadm_Dropdownoptionstype = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM_Dropdownoptionstype");
            Ddo_view_new_encounter2view_ne_departmentadm_Titlecontrolidtoreplace = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM_Titlecontrolidtoreplace");
            Ddo_view_new_encounter2view_ne_departmentadm_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM_Includesortasc"));
            Ddo_view_new_encounter2view_ne_departmentadm_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM_Includesortdsc"));
            Ddo_view_new_encounter2view_ne_departmentadm_Sortedstatus = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM_Sortedstatus");
            Ddo_view_new_encounter2view_ne_departmentadm_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM_Includefilter"));
            Ddo_view_new_encounter2view_ne_departmentadm_Filtertype = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM_Filtertype");
            Ddo_view_new_encounter2view_ne_departmentadm_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM_Filterisrange"));
            Ddo_view_new_encounter2view_ne_departmentadm_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM_Includedatalist"));
            Ddo_view_new_encounter2view_ne_departmentadm_Datalisttype = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM_Datalisttype");
            Ddo_view_new_encounter2view_ne_departmentadm_Datalistproc = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM_Datalistproc");
            Ddo_view_new_encounter2view_ne_departmentadm_Datalistupdateminimumcharacters = (int)(context.localUtil.CToN( cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM_Datalistupdateminimumcharacters"), ".", ","));
            Ddo_view_new_encounter2view_ne_departmentadm_Sortasc = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM_Sortasc");
            Ddo_view_new_encounter2view_ne_departmentadm_Sortdsc = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM_Sortdsc");
            Ddo_view_new_encounter2view_ne_departmentadm_Loadingdata = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM_Loadingdata");
            Ddo_view_new_encounter2view_ne_departmentadm_Cleanfilter = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM_Cleanfilter");
            Ddo_view_new_encounter2view_ne_departmentadm_Noresultsfound = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM_Noresultsfound");
            Ddo_view_new_encounter2view_ne_departmentadm_Searchbuttontext = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM_Searchbuttontext");
            Ddo_view_new_encounter2view_ne_enctype_Caption = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE_Caption");
            Ddo_view_new_encounter2view_ne_enctype_Tooltip = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE_Tooltip");
            Ddo_view_new_encounter2view_ne_enctype_Cls = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE_Cls");
            Ddo_view_new_encounter2view_ne_enctype_Filteredtext_set = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE_Filteredtext_set");
            Ddo_view_new_encounter2view_ne_enctype_Selectedvalue_set = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE_Selectedvalue_set");
            Ddo_view_new_encounter2view_ne_enctype_Dropdownoptionstype = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE_Dropdownoptionstype");
            Ddo_view_new_encounter2view_ne_enctype_Titlecontrolidtoreplace = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE_Titlecontrolidtoreplace");
            Ddo_view_new_encounter2view_ne_enctype_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE_Includesortasc"));
            Ddo_view_new_encounter2view_ne_enctype_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE_Includesortdsc"));
            Ddo_view_new_encounter2view_ne_enctype_Sortedstatus = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE_Sortedstatus");
            Ddo_view_new_encounter2view_ne_enctype_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE_Includefilter"));
            Ddo_view_new_encounter2view_ne_enctype_Filtertype = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE_Filtertype");
            Ddo_view_new_encounter2view_ne_enctype_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE_Filterisrange"));
            Ddo_view_new_encounter2view_ne_enctype_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE_Includedatalist"));
            Ddo_view_new_encounter2view_ne_enctype_Datalisttype = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE_Datalisttype");
            Ddo_view_new_encounter2view_ne_enctype_Datalistproc = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE_Datalistproc");
            Ddo_view_new_encounter2view_ne_enctype_Datalistupdateminimumcharacters = (int)(context.localUtil.CToN( cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE_Datalistupdateminimumcharacters"), ".", ","));
            Ddo_view_new_encounter2view_ne_enctype_Sortasc = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE_Sortasc");
            Ddo_view_new_encounter2view_ne_enctype_Sortdsc = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE_Sortdsc");
            Ddo_view_new_encounter2view_ne_enctype_Loadingdata = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE_Loadingdata");
            Ddo_view_new_encounter2view_ne_enctype_Cleanfilter = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE_Cleanfilter");
            Ddo_view_new_encounter2view_ne_enctype_Noresultsfound = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE_Noresultsfound");
            Ddo_view_new_encounter2view_ne_enctype_Searchbuttontext = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE_Searchbuttontext");
            Ddo_view_new_encounter2view_ne_status_Caption = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_STATUS_Caption");
            Ddo_view_new_encounter2view_ne_status_Tooltip = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_STATUS_Tooltip");
            Ddo_view_new_encounter2view_ne_status_Cls = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_STATUS_Cls");
            Ddo_view_new_encounter2view_ne_status_Selectedvalue_set = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_STATUS_Selectedvalue_set");
            Ddo_view_new_encounter2view_ne_status_Dropdownoptionstype = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_STATUS_Dropdownoptionstype");
            Ddo_view_new_encounter2view_ne_status_Titlecontrolidtoreplace = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_STATUS_Titlecontrolidtoreplace");
            Ddo_view_new_encounter2view_ne_status_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_STATUS_Includesortasc"));
            Ddo_view_new_encounter2view_ne_status_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_STATUS_Includesortdsc"));
            Ddo_view_new_encounter2view_ne_status_Sortedstatus = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_STATUS_Sortedstatus");
            Ddo_view_new_encounter2view_ne_status_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_STATUS_Includefilter"));
            Ddo_view_new_encounter2view_ne_status_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_STATUS_Includedatalist"));
            Ddo_view_new_encounter2view_ne_status_Datalisttype = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_STATUS_Datalisttype");
            Ddo_view_new_encounter2view_ne_status_Allowmultipleselection = StringUtil.StrToBool( cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_STATUS_Allowmultipleselection"));
            Ddo_view_new_encounter2view_ne_status_Datalistfixedvalues = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_STATUS_Datalistfixedvalues");
            Ddo_view_new_encounter2view_ne_status_Sortasc = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_STATUS_Sortasc");
            Ddo_view_new_encounter2view_ne_status_Sortdsc = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_STATUS_Sortdsc");
            Ddo_view_new_encounter2view_ne_status_Cleanfilter = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_STATUS_Cleanfilter");
            Ddo_view_new_encounter2view_ne_status_Searchbuttontext = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_STATUS_Searchbuttontext");
            Ddo_view_new_encounter2view_ne_israndapprove_Caption = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE_Caption");
            Ddo_view_new_encounter2view_ne_israndapprove_Tooltip = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE_Tooltip");
            Ddo_view_new_encounter2view_ne_israndapprove_Cls = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE_Cls");
            Ddo_view_new_encounter2view_ne_israndapprove_Selectedvalue_set = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE_Selectedvalue_set");
            Ddo_view_new_encounter2view_ne_israndapprove_Dropdownoptionstype = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE_Dropdownoptionstype");
            Ddo_view_new_encounter2view_ne_israndapprove_Titlecontrolidtoreplace = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE_Titlecontrolidtoreplace");
            Ddo_view_new_encounter2view_ne_israndapprove_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE_Includesortasc"));
            Ddo_view_new_encounter2view_ne_israndapprove_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE_Includesortdsc"));
            Ddo_view_new_encounter2view_ne_israndapprove_Sortedstatus = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE_Sortedstatus");
            Ddo_view_new_encounter2view_ne_israndapprove_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE_Includefilter"));
            Ddo_view_new_encounter2view_ne_israndapprove_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE_Includedatalist"));
            Ddo_view_new_encounter2view_ne_israndapprove_Datalisttype = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE_Datalisttype");
            Ddo_view_new_encounter2view_ne_israndapprove_Datalistfixedvalues = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE_Datalistfixedvalues");
            Ddo_view_new_encounter2view_ne_israndapprove_Sortasc = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE_Sortasc");
            Ddo_view_new_encounter2view_ne_israndapprove_Sortdsc = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE_Sortdsc");
            Ddo_view_new_encounter2view_ne_israndapprove_Cleanfilter = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE_Cleanfilter");
            Ddo_view_new_encounter2view_ne_israndapprove_Searchbuttontext = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE_Searchbuttontext");
            Ddo_view_new_encounter2view_ne_israndrecheck_Caption = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK_Caption");
            Ddo_view_new_encounter2view_ne_israndrecheck_Tooltip = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK_Tooltip");
            Ddo_view_new_encounter2view_ne_israndrecheck_Cls = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK_Cls");
            Ddo_view_new_encounter2view_ne_israndrecheck_Selectedvalue_set = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK_Selectedvalue_set");
            Ddo_view_new_encounter2view_ne_israndrecheck_Dropdownoptionstype = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK_Dropdownoptionstype");
            Ddo_view_new_encounter2view_ne_israndrecheck_Titlecontrolidtoreplace = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK_Titlecontrolidtoreplace");
            Ddo_view_new_encounter2view_ne_israndrecheck_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK_Includesortasc"));
            Ddo_view_new_encounter2view_ne_israndrecheck_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK_Includesortdsc"));
            Ddo_view_new_encounter2view_ne_israndrecheck_Sortedstatus = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK_Sortedstatus");
            Ddo_view_new_encounter2view_ne_israndrecheck_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK_Includefilter"));
            Ddo_view_new_encounter2view_ne_israndrecheck_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK_Includedatalist"));
            Ddo_view_new_encounter2view_ne_israndrecheck_Datalisttype = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK_Datalisttype");
            Ddo_view_new_encounter2view_ne_israndrecheck_Datalistfixedvalues = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK_Datalistfixedvalues");
            Ddo_view_new_encounter2view_ne_israndrecheck_Sortasc = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK_Sortasc");
            Ddo_view_new_encounter2view_ne_israndrecheck_Sortdsc = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK_Sortdsc");
            Ddo_view_new_encounter2view_ne_israndrecheck_Cleanfilter = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK_Cleanfilter");
            Ddo_view_new_encounter2view_ne_israndrecheck_Searchbuttontext = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK_Searchbuttontext");
            Ddo_view_new_encounter2view_ne_isupdate_Caption = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE_Caption");
            Ddo_view_new_encounter2view_ne_isupdate_Tooltip = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE_Tooltip");
            Ddo_view_new_encounter2view_ne_isupdate_Cls = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE_Cls");
            Ddo_view_new_encounter2view_ne_isupdate_Selectedvalue_set = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE_Selectedvalue_set");
            Ddo_view_new_encounter2view_ne_isupdate_Dropdownoptionstype = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE_Dropdownoptionstype");
            Ddo_view_new_encounter2view_ne_isupdate_Titlecontrolidtoreplace = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE_Titlecontrolidtoreplace");
            Ddo_view_new_encounter2view_ne_isupdate_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE_Includesortasc"));
            Ddo_view_new_encounter2view_ne_isupdate_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE_Includesortdsc"));
            Ddo_view_new_encounter2view_ne_isupdate_Sortedstatus = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE_Sortedstatus");
            Ddo_view_new_encounter2view_ne_isupdate_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE_Includefilter"));
            Ddo_view_new_encounter2view_ne_isupdate_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE_Includedatalist"));
            Ddo_view_new_encounter2view_ne_isupdate_Datalisttype = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE_Datalisttype");
            Ddo_view_new_encounter2view_ne_isupdate_Datalistfixedvalues = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE_Datalistfixedvalues");
            Ddo_view_new_encounter2view_ne_isupdate_Sortasc = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE_Sortasc");
            Ddo_view_new_encounter2view_ne_isupdate_Sortdsc = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE_Sortdsc");
            Ddo_view_new_encounter2view_ne_isupdate_Cleanfilter = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE_Cleanfilter");
            Ddo_view_new_encounter2view_ne_isupdate_Searchbuttontext = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE_Searchbuttontext");
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
            Ddo_view_new_encounter2view_ne_encounterid_Activeeventkey = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID_Activeeventkey");
            Ddo_view_new_encounter2view_ne_encounterid_Filteredtext_get = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID_Filteredtext_get");
            Ddo_view_new_encounter2view_ne_encounterid_Filteredtextto_get = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID_Filteredtextto_get");
            Ddo_view_new_encounter2view_ne_information_patientno_Activeeventkey = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO_Activeeventkey");
            Ddo_view_new_encounter2view_ne_information_patientno_Filteredtext_get = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO_Filteredtext_get");
            Ddo_view_new_encounter2view_ne_information_patientno_Selectedvalue_get = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO_Selectedvalue_get");
            Ddo_view_new_encounter2view_ne_departmentadm_Activeeventkey = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM_Activeeventkey");
            Ddo_view_new_encounter2view_ne_departmentadm_Filteredtext_get = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM_Filteredtext_get");
            Ddo_view_new_encounter2view_ne_departmentadm_Selectedvalue_get = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM_Selectedvalue_get");
            Ddo_view_new_encounter2view_ne_enctype_Activeeventkey = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE_Activeeventkey");
            Ddo_view_new_encounter2view_ne_enctype_Filteredtext_get = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE_Filteredtext_get");
            Ddo_view_new_encounter2view_ne_enctype_Selectedvalue_get = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE_Selectedvalue_get");
            Ddo_view_new_encounter2view_ne_status_Activeeventkey = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_STATUS_Activeeventkey");
            Ddo_view_new_encounter2view_ne_status_Selectedvalue_get = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_STATUS_Selectedvalue_get");
            Ddo_view_new_encounter2view_ne_israndapprove_Activeeventkey = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE_Activeeventkey");
            Ddo_view_new_encounter2view_ne_israndapprove_Selectedvalue_get = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE_Selectedvalue_get");
            Ddo_view_new_encounter2view_ne_israndrecheck_Activeeventkey = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK_Activeeventkey");
            Ddo_view_new_encounter2view_ne_israndrecheck_Selectedvalue_get = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK_Selectedvalue_get");
            Ddo_view_new_encounter2view_ne_isupdate_Activeeventkey = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE_Activeeventkey");
            Ddo_view_new_encounter2view_ne_isupdate_Selectedvalue_get = cgiGet( "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE_Selectedvalue_get");
            Dvelop_confirmpanel_batchapprove_Result = cgiGet( "DVELOP_CONFIRMPANEL_BATCHAPPROVE_Result");
            Dvelop_confirmpanel_batchrecheck_Result = cgiGet( "DVELOP_CONFIRMPANEL_BATCHRECHECK_Result");
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
            if ( StringUtil.StrCmp(cgiGet( "GXH_vBR_INFORMATION_PATIENTNO"), AV15BR_Information_PatientNo) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vSBR_ENCOUNTERID"), AV20sBR_EncounterID) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToD( cgiGet( "GXH_vVIEW_NE_ADMITDATE"), 0) != AV21view_NE_AdmitDate )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToD( cgiGet( "GXH_vENDVIEW_NE_ADMITDATE"), 0) != AV22endview_NE_AdmitDate )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vTVIEW_NE_STATUS"), ".", ",") != Convert.ToDecimal( AV23tview_NE_Status )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrToBool( cgiGet( "GXH_vVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE")) != AV101View_New_Encounter2view_NE_IsRandApprove )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrToBool( cgiGet( "GXH_vVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK")) != AV102View_New_Encounter2view_NE_IsRandRecheck )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrToBool( cgiGet( "GXH_vVIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE")) != AV103View_New_Encounter2view_NE_IsUpdate )
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
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID"), ".", ",") != Convert.ToDecimal( AV25TFView_New_Encounter2view_NE_EncounterID )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID_TO"), ".", ",") != Convert.ToDecimal( AV26TFView_New_Encounter2view_NE_EncounterID_To )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFVIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO"), AV67TFView_New_Encounter2view_NE_Information_PatientNo) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFVIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO_SEL"), AV68TFView_New_Encounter2view_NE_Information_PatientNo_Sel) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFVIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM"), AV33TFView_New_Encounter2view_NE_Departmentadm) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFVIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM_SEL"), AV34TFView_New_Encounter2view_NE_Departmentadm_Sel) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE"), AV29TFView_New_Encounter2view_NE_ENCType) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE_SEL"), AV30TFView_New_Encounter2view_NE_ENCType_Sel) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE_SEL"), ".", ",") != Convert.ToDecimal( AV106TFView_New_Encounter2view_NE_IsRandApprove_Sel )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK_SEL"), ".", ",") != Convert.ToDecimal( AV107TFView_New_Encounter2view_NE_IsRandRecheck_Sel )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE_SEL"), ".", ",") != Convert.ToDecimal( AV108TFView_New_Encounter2view_NE_IsUpdate_Sel )) )
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
         E24AL2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E24AL2( )
      {
         /* Start Routine */
         GXt_char1 = AV85tCurrentCode;
         new zbr_getcurrenttcode(context ).execute( out  GXt_char1) ;
         AV85tCurrentCode = GXt_char1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV85tCurrentCode", AV85tCurrentCode);
         edtavView_new_encounter2view_ne_encounterid_selected_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavView_new_encounter2view_ne_encounterid_selected_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavView_new_encounter2view_ne_encounterid_selected_Visible), 5, 0)), true);
         subGrid_Rows = 9;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         edtavTfview_new_encounter2view_ne_encounterid_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfview_new_encounter2view_ne_encounterid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfview_new_encounter2view_ne_encounterid_Visible), 5, 0)), true);
         edtavTfview_new_encounter2view_ne_encounterid_to_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfview_new_encounter2view_ne_encounterid_to_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfview_new_encounter2view_ne_encounterid_to_Visible), 5, 0)), true);
         edtavTfview_new_encounter2view_ne_information_patientno_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfview_new_encounter2view_ne_information_patientno_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfview_new_encounter2view_ne_information_patientno_Visible), 5, 0)), true);
         edtavTfview_new_encounter2view_ne_information_patientno_sel_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfview_new_encounter2view_ne_information_patientno_sel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfview_new_encounter2view_ne_information_patientno_sel_Visible), 5, 0)), true);
         edtavTfview_new_encounter2view_ne_departmentadm_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfview_new_encounter2view_ne_departmentadm_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfview_new_encounter2view_ne_departmentadm_Visible), 5, 0)), true);
         edtavTfview_new_encounter2view_ne_departmentadm_sel_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfview_new_encounter2view_ne_departmentadm_sel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfview_new_encounter2view_ne_departmentadm_sel_Visible), 5, 0)), true);
         edtavTfview_new_encounter2view_ne_enctype_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfview_new_encounter2view_ne_enctype_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfview_new_encounter2view_ne_enctype_Visible), 5, 0)), true);
         edtavTfview_new_encounter2view_ne_enctype_sel_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfview_new_encounter2view_ne_enctype_sel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfview_new_encounter2view_ne_enctype_sel_Visible), 5, 0)), true);
         edtavTfview_new_encounter2view_ne_israndapprove_sel_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfview_new_encounter2view_ne_israndapprove_sel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfview_new_encounter2view_ne_israndapprove_sel_Visible), 5, 0)), true);
         edtavTfview_new_encounter2view_ne_israndrecheck_sel_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfview_new_encounter2view_ne_israndrecheck_sel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfview_new_encounter2view_ne_israndrecheck_sel_Visible), 5, 0)), true);
         edtavTfview_new_encounter2view_ne_isupdate_sel_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfview_new_encounter2view_ne_isupdate_sel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfview_new_encounter2view_ne_isupdate_sel_Visible), 5, 0)), true);
         Ddo_view_new_encounter2view_ne_encounterid_Titlecontrolidtoreplace = subGrid_Internalname+"_View_New_Encounter2view_NE_EncounterID";
         ucDdo_view_new_encounter2view_ne_encounterid.SendProperty(context, "", false, Ddo_view_new_encounter2view_ne_encounterid_Internalname, "TitleControlIdToReplace", Ddo_view_new_encounter2view_ne_encounterid_Titlecontrolidtoreplace);
         AV27ddo_View_New_Encounter2view_NE_EncounterIDTitleControlIdToReplace = Ddo_view_new_encounter2view_ne_encounterid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27ddo_View_New_Encounter2view_NE_EncounterIDTitleControlIdToReplace", AV27ddo_View_New_Encounter2view_NE_EncounterIDTitleControlIdToReplace);
         edtavDdo_view_new_encounter2view_ne_encounteridtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_view_new_encounter2view_ne_encounteridtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_view_new_encounter2view_ne_encounteridtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_view_new_encounter2view_ne_information_patientno_Titlecontrolidtoreplace = subGrid_Internalname+"_View_New_Encounter2view_NE_Information_PatientNo";
         ucDdo_view_new_encounter2view_ne_information_patientno.SendProperty(context, "", false, Ddo_view_new_encounter2view_ne_information_patientno_Internalname, "TitleControlIdToReplace", Ddo_view_new_encounter2view_ne_information_patientno_Titlecontrolidtoreplace);
         AV69ddo_View_New_Encounter2view_NE_Information_PatientNoTitleControlIdToReplace = Ddo_view_new_encounter2view_ne_information_patientno_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV69ddo_View_New_Encounter2view_NE_Information_PatientNoTitleControlIdToReplace", AV69ddo_View_New_Encounter2view_NE_Information_PatientNoTitleControlIdToReplace);
         edtavDdo_view_new_encounter2view_ne_information_patientnotitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_view_new_encounter2view_ne_information_patientnotitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_view_new_encounter2view_ne_information_patientnotitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_view_new_encounter2view_ne_departmentadm_Titlecontrolidtoreplace = subGrid_Internalname+"_View_New_Encounter2view_NE_Departmentadm";
         ucDdo_view_new_encounter2view_ne_departmentadm.SendProperty(context, "", false, Ddo_view_new_encounter2view_ne_departmentadm_Internalname, "TitleControlIdToReplace", Ddo_view_new_encounter2view_ne_departmentadm_Titlecontrolidtoreplace);
         AV35ddo_View_New_Encounter2view_NE_DepartmentadmTitleControlIdToReplace = Ddo_view_new_encounter2view_ne_departmentadm_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV35ddo_View_New_Encounter2view_NE_DepartmentadmTitleControlIdToReplace", AV35ddo_View_New_Encounter2view_NE_DepartmentadmTitleControlIdToReplace);
         edtavDdo_view_new_encounter2view_ne_departmentadmtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_view_new_encounter2view_ne_departmentadmtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_view_new_encounter2view_ne_departmentadmtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_view_new_encounter2view_ne_enctype_Titlecontrolidtoreplace = subGrid_Internalname+"_View_New_Encounter2view_NE_ENCType";
         ucDdo_view_new_encounter2view_ne_enctype.SendProperty(context, "", false, Ddo_view_new_encounter2view_ne_enctype_Internalname, "TitleControlIdToReplace", Ddo_view_new_encounter2view_ne_enctype_Titlecontrolidtoreplace);
         AV31ddo_View_New_Encounter2view_NE_ENCTypeTitleControlIdToReplace = Ddo_view_new_encounter2view_ne_enctype_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31ddo_View_New_Encounter2view_NE_ENCTypeTitleControlIdToReplace", AV31ddo_View_New_Encounter2view_NE_ENCTypeTitleControlIdToReplace);
         edtavDdo_view_new_encounter2view_ne_enctypetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_view_new_encounter2view_ne_enctypetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_view_new_encounter2view_ne_enctypetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_view_new_encounter2view_ne_status_Titlecontrolidtoreplace = subGrid_Internalname+"_View_New_Encounter2view_NE_Status";
         ucDdo_view_new_encounter2view_ne_status.SendProperty(context, "", false, Ddo_view_new_encounter2view_ne_status_Internalname, "TitleControlIdToReplace", Ddo_view_new_encounter2view_ne_status_Titlecontrolidtoreplace);
         AV45ddo_View_New_Encounter2view_NE_StatusTitleControlIdToReplace = Ddo_view_new_encounter2view_ne_status_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV45ddo_View_New_Encounter2view_NE_StatusTitleControlIdToReplace", AV45ddo_View_New_Encounter2view_NE_StatusTitleControlIdToReplace);
         edtavDdo_view_new_encounter2view_ne_statustitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_view_new_encounter2view_ne_statustitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_view_new_encounter2view_ne_statustitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_view_new_encounter2view_ne_israndapprove_Titlecontrolidtoreplace = subGrid_Internalname+"_View_New_Encounter2view_NE_IsRandApprove";
         ucDdo_view_new_encounter2view_ne_israndapprove.SendProperty(context, "", false, Ddo_view_new_encounter2view_ne_israndapprove_Internalname, "TitleControlIdToReplace", Ddo_view_new_encounter2view_ne_israndapprove_Titlecontrolidtoreplace);
         AV53ddo_View_New_Encounter2view_NE_IsRandApproveTitleControlIdToReplace = Ddo_view_new_encounter2view_ne_israndapprove_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV53ddo_View_New_Encounter2view_NE_IsRandApproveTitleControlIdToReplace", AV53ddo_View_New_Encounter2view_NE_IsRandApproveTitleControlIdToReplace);
         edtavDdo_view_new_encounter2view_ne_israndapprovetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_view_new_encounter2view_ne_israndapprovetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_view_new_encounter2view_ne_israndapprovetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_view_new_encounter2view_ne_israndrecheck_Titlecontrolidtoreplace = subGrid_Internalname+"_View_New_Encounter2view_NE_IsRandRecheck";
         ucDdo_view_new_encounter2view_ne_israndrecheck.SendProperty(context, "", false, Ddo_view_new_encounter2view_ne_israndrecheck_Internalname, "TitleControlIdToReplace", Ddo_view_new_encounter2view_ne_israndrecheck_Titlecontrolidtoreplace);
         AV49ddo_View_New_Encounter2view_NE_IsRandRecheckTitleControlIdToReplace = Ddo_view_new_encounter2view_ne_israndrecheck_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV49ddo_View_New_Encounter2view_NE_IsRandRecheckTitleControlIdToReplace", AV49ddo_View_New_Encounter2view_NE_IsRandRecheckTitleControlIdToReplace);
         edtavDdo_view_new_encounter2view_ne_israndrechecktitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_view_new_encounter2view_ne_israndrechecktitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_view_new_encounter2view_ne_israndrechecktitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_view_new_encounter2view_ne_isupdate_Titlecontrolidtoreplace = subGrid_Internalname+"_View_New_Encounter2view_NE_IsUpdate";
         ucDdo_view_new_encounter2view_ne_isupdate.SendProperty(context, "", false, Ddo_view_new_encounter2view_ne_isupdate_Internalname, "TitleControlIdToReplace", Ddo_view_new_encounter2view_ne_isupdate_Titlecontrolidtoreplace);
         AV57ddo_View_New_Encounter2view_NE_IsUpdateTitleControlIdToReplace = Ddo_view_new_encounter2view_ne_isupdate_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV57ddo_View_New_Encounter2view_NE_IsUpdateTitleControlIdToReplace", AV57ddo_View_New_Encounter2view_NE_IsUpdateTitleControlIdToReplace);
         edtavDdo_view_new_encounter2view_ne_isupdatetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_view_new_encounter2view_ne_isupdatetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_view_new_encounter2view_ne_isupdatetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Form.Caption = " View_New_Encounter2";
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
            /* Execute user subroutine: 'SETDDOSORTEDSTATUS' */
            S132 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
         }
         edtavOrdereddsc_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavOrdereddsc_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavOrdereddsc_Visible), 5, 0)), true);
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 = AV70DDO_TitleSettingsIcons;
         new GeneXus.Programs.wwpbaseobjects.getwwptitlesettingsicons(context ).execute( out  GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2) ;
         AV70DDO_TitleSettingsIcons = GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2;
         Gridpaginationbar_Rowsperpageselectedvalue = subGrid_Rows;
         ucGridpaginationbar.SendProperty(context, "", false, Gridpaginationbar_Internalname, "RowsPerPageSelectedValue", StringUtil.LTrim( StringUtil.Str( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0)));
         AV111Pgmname = "Data Mgmt Portal -RAAP";
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV111Pgmname", AV111Pgmname);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vPGMNAME", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( AV111Pgmname, "")), context));
         AV112Pgmdesc = "Data Mgmt Portal -RAAP";
         Form.Caption = "Data Mgmt Portal -RAAP";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption, true);
         AV86IsChecker = false;
         AV87IsInsert = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV87IsInsert", AV87IsInsert);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vISINSERT", GetSecureSignedToken( "", AV87IsInsert, context));
         AV88IsManager = false;
         AV89IsRocheUser = false;
         AV90IsApprover = false;
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV6WWPContext) ;
         AV91tUserType = AV6WWPContext.gxTpr_Usertype;
         AV92tBR_Encounter_Status = (short)(NumberUtil.Val( AV19Session.Get("BR_Encounter_Status"), "."));
         if ( ! (0==AV92tBR_Encounter_Status) )
         {
            if ( StringUtil.StrCmp(StringUtil.Trim( StringUtil.Str( (decimal)(AV92tBR_Encounter_Status), 4, 0)), "9") == 0 )
            {
               AV23tview_NE_Status = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23tview_NE_Status", StringUtil.LTrim( StringUtil.Str( (decimal)(AV23tview_NE_Status), 4, 0)));
            }
            else
            {
               AV23tview_NE_Status = AV92tBR_Encounter_Status;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23tview_NE_Status", StringUtil.LTrim( StringUtil.Str( (decimal)(AV23tview_NE_Status), 4, 0)));
            }
         }
         else
         {
            if ( ! AV88IsManager )
            {
               GXt_boolean3 = AV87IsInsert;
               new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Role_CRC", out  GXt_boolean3) ;
               AV87IsInsert = GXt_boolean3;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV87IsInsert", AV87IsInsert);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vISINSERT", GetSecureSignedToken( "", AV87IsInsert, context));
               if ( AV87IsInsert )
               {
                  AV23tview_NE_Status = 1;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23tview_NE_Status", StringUtil.LTrim( StringUtil.Str( (decimal)(AV23tview_NE_Status), 4, 0)));
               }
               GXt_boolean3 = AV86IsChecker;
               new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Role_Checker", out  GXt_boolean3) ;
               AV86IsChecker = GXt_boolean3;
               if ( AV86IsChecker )
               {
                  AV23tview_NE_Status = 2;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23tview_NE_Status", StringUtil.LTrim( StringUtil.Str( (decimal)(AV23tview_NE_Status), 4, 0)));
               }
               GXt_boolean3 = AV90IsApprover;
               new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Role_Approver", out  GXt_boolean3) ;
               AV90IsApprover = GXt_boolean3;
               if ( AV90IsApprover )
               {
                  AV23tview_NE_Status = 4;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23tview_NE_Status", StringUtil.LTrim( StringUtil.Str( (decimal)(AV23tview_NE_Status), 4, 0)));
               }
            }
         }
         AV19Session.Set("BR_InformationView_Return", "BR_EncounterWW");
      }

      protected void E25AL2( )
      {
         if ( gx_refresh_fired )
         {
            return  ;
         }
         gx_refresh_fired = true;
         /* Refresh Routine */
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV6WWPContext) ;
         AV86IsChecker = false;
         AV87IsInsert = false;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV87IsInsert", AV87IsInsert);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vISINSERT", GetSecureSignedToken( "", AV87IsInsert, context));
         AV88IsManager = false;
         AV90IsApprover = false;
         GXt_boolean3 = AV87IsInsert;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Role_CRC", out  GXt_boolean3) ;
         AV87IsInsert = GXt_boolean3;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV87IsInsert", AV87IsInsert);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vISINSERT", GetSecureSignedToken( "", AV87IsInsert, context));
         GXt_boolean3 = AV86IsChecker;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Role_Checker", out  GXt_boolean3) ;
         AV86IsChecker = GXt_boolean3;
         GXt_boolean3 = AV90IsApprover;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Role_Approver", out  GXt_boolean3) ;
         AV90IsApprover = GXt_boolean3;
         GXt_boolean3 = AV88IsManager;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Role_Manager", out  GXt_boolean3) ;
         AV88IsManager = GXt_boolean3;
         if ( ! AV88IsManager )
         {
            GXt_boolean3 = AV88IsManager;
            new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Role_ReadOnlyer", out  GXt_boolean3) ;
            AV88IsManager = GXt_boolean3;
            if ( ! AV88IsManager )
            {
               GXt_boolean3 = AV88IsManager;
               new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Role_AllManager", out  GXt_boolean3) ;
               AV88IsManager = GXt_boolean3;
            }
         }
         AV93tAllBR_EncounterID.Clear();
         if ( ! AV88IsManager )
         {
            AV94tDataPackage.Clear();
            AV98tResult = AV95websession.Get("DAS_UserPermission");
            AV96tSDT_MicroUserInfo.FromJSonString(AV98tResult, null);
            AV94tDataPackage.Clear();
            AV97tNum = 1;
            while ( AV97tNum <= ((SdtSDT_MicroUserInfo_Tenants)AV96tSDT_MicroUserInfo.gxTpr_Tenants.Item(1)).gxTpr_Datascoptes.Count )
            {
               AV94tDataPackage.Add(StringUtil.Trim( ((String)((SdtSDT_MicroUserInfo_Tenants)AV96tSDT_MicroUserInfo.gxTpr_Tenants.Item(1)).gxTpr_Datascoptes.Item(AV97tNum))), 0);
               AV97tNum = (short)(AV97tNum+1);
            }
         }
         AV24View_New_Encounter2view_NE_EncounterIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV66View_New_Encounter2view_NE_Information_PatientNoTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV32View_New_Encounter2view_NE_DepartmentadmTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV28View_New_Encounter2view_NE_ENCTypeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV42View_New_Encounter2view_NE_StatusTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV50View_New_Encounter2view_NE_IsRandApproveTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV46View_New_Encounter2view_NE_IsRandRecheckTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV54View_New_Encounter2view_NE_IsUpdateTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV6WWPContext) ;
         /* Execute user subroutine: 'CHECKSECURITYFORACTIONS' */
         S142 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         /* Execute user subroutine: 'SAVEGRIDSTATE' */
         S152 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         edtView_New_Encounter2view_NE_EncounterID_Titleformat = 2;
         edtView_New_Encounter2view_NE_EncounterID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "就诊序号", AV27ddo_View_New_Encounter2view_NE_EncounterIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtView_New_Encounter2view_NE_EncounterID_Internalname, "Title", edtView_New_Encounter2view_NE_EncounterID_Title, !bGXsfl_76_Refreshing);
         edtView_New_Encounter2view_NE_Information_PatientNo_Titleformat = 2;
         edtView_New_Encounter2view_NE_Information_PatientNo_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "患者编号", AV69ddo_View_New_Encounter2view_NE_Information_PatientNoTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtView_New_Encounter2view_NE_Information_PatientNo_Internalname, "Title", edtView_New_Encounter2view_NE_Information_PatientNo_Title, !bGXsfl_76_Refreshing);
         edtView_New_Encounter2view_NE_Departmentadm_Titleformat = 2;
         edtView_New_Encounter2view_NE_Departmentadm_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "入院科室", AV35ddo_View_New_Encounter2view_NE_DepartmentadmTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtView_New_Encounter2view_NE_Departmentadm_Internalname, "Title", edtView_New_Encounter2view_NE_Departmentadm_Title, !bGXsfl_76_Refreshing);
         edtView_New_Encounter2view_NE_ENCType_Titleformat = 2;
         edtView_New_Encounter2view_NE_ENCType_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "就诊方式", AV31ddo_View_New_Encounter2view_NE_ENCTypeTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtView_New_Encounter2view_NE_ENCType_Internalname, "Title", edtView_New_Encounter2view_NE_ENCType_Title, !bGXsfl_76_Refreshing);
         cmbView_New_Encounter2view_NE_Status_Titleformat = 2;
         cmbView_New_Encounter2view_NE_Status.Title.Text = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "审批状态", AV45ddo_View_New_Encounter2view_NE_StatusTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbView_New_Encounter2view_NE_Status_Internalname, "Title", cmbView_New_Encounter2view_NE_Status.Title.Text, !bGXsfl_76_Refreshing);
         chkView_New_Encounter2view_NE_IsRandApprove_Titleformat = 2;
         chkView_New_Encounter2view_NE_IsRandApprove.Title.Text = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "初审抽查", AV53ddo_View_New_Encounter2view_NE_IsRandApproveTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkView_New_Encounter2view_NE_IsRandApprove_Internalname, "Title", chkView_New_Encounter2view_NE_IsRandApprove.Title.Text, !bGXsfl_76_Refreshing);
         chkView_New_Encounter2view_NE_IsRandRecheck_Titleformat = 2;
         chkView_New_Encounter2view_NE_IsRandRecheck.Title.Text = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "复审抽查", AV49ddo_View_New_Encounter2view_NE_IsRandRecheckTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkView_New_Encounter2view_NE_IsRandRecheck_Internalname, "Title", chkView_New_Encounter2view_NE_IsRandRecheck.Title.Text, !bGXsfl_76_Refreshing);
         chkView_New_Encounter2view_NE_IsUpdate_Titleformat = 2;
         chkView_New_Encounter2view_NE_IsUpdate.Title.Text = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "是否修改", AV57ddo_View_New_Encounter2view_NE_IsUpdateTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkView_New_Encounter2view_NE_IsUpdate_Internalname, "Title", chkView_New_Encounter2view_NE_IsUpdate.Title.Text, !bGXsfl_76_Refreshing);
         AV72GridCurrentPage = subGrid_Currentpage( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV72GridCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV72GridCurrentPage), 10, 0)));
         AV73GridPageCount = subGrid_Pagecount( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV73GridPageCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV73GridPageCount), 10, 0)));
         AV113BR_EncounterListwwDS_1_Br_information_patientno = AV15BR_Information_PatientNo;
         AV114BR_EncounterListwwDS_2_View_new_encounter2view_ne_israndapprove = AV101View_New_Encounter2view_NE_IsRandApprove;
         AV115BR_EncounterListwwDS_3_View_new_encounter2view_ne_israndrecheck = AV102View_New_Encounter2view_NE_IsRandRecheck;
         AV116BR_EncounterListwwDS_4_View_new_encounter2view_ne_isupdate = AV103View_New_Encounter2view_NE_IsUpdate;
         AV117BR_EncounterListwwDS_5_Tfview_new_encounter2view_ne_encounterid = AV25TFView_New_Encounter2view_NE_EncounterID;
         AV118BR_EncounterListwwDS_6_Tfview_new_encounter2view_ne_encounterid_to = AV26TFView_New_Encounter2view_NE_EncounterID_To;
         AV119BR_EncounterListwwDS_7_Tfview_new_encounter2view_ne_information_patientno = AV67TFView_New_Encounter2view_NE_Information_PatientNo;
         AV120BR_EncounterListwwDS_8_Tfview_new_encounter2view_ne_information_patientno_sel = AV68TFView_New_Encounter2view_NE_Information_PatientNo_Sel;
         AV121BR_EncounterListwwDS_9_Tfview_new_encounter2view_ne_departmentadm = AV33TFView_New_Encounter2view_NE_Departmentadm;
         AV122BR_EncounterListwwDS_10_Tfview_new_encounter2view_ne_departmentadm_sel = AV34TFView_New_Encounter2view_NE_Departmentadm_Sel;
         AV123BR_EncounterListwwDS_11_Tfview_new_encounter2view_ne_enctype = AV29TFView_New_Encounter2view_NE_ENCType;
         AV124BR_EncounterListwwDS_12_Tfview_new_encounter2view_ne_enctype_sel = AV30TFView_New_Encounter2view_NE_ENCType_Sel;
         AV125BR_EncounterListwwDS_13_Tfview_new_encounter2view_ne_status_sels = AV105TFView_New_Encounter2view_NE_Status_Sels;
         AV126BR_EncounterListwwDS_14_Tfview_new_encounter2view_ne_israndapprove_sel = AV106TFView_New_Encounter2view_NE_IsRandApprove_Sel;
         AV127BR_EncounterListwwDS_15_Tfview_new_encounter2view_ne_israndrecheck_sel = AV107TFView_New_Encounter2view_NE_IsRandRecheck_Sel;
         AV128BR_EncounterListwwDS_16_Tfview_new_encounter2view_ne_isupdate_sel = AV108TFView_New_Encounter2view_NE_IsUpdate_Sel;
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV93tAllBR_EncounterID", AV93tAllBR_EncounterID);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24View_New_Encounter2view_NE_EncounterIDTitleFilterData", AV24View_New_Encounter2view_NE_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV66View_New_Encounter2view_NE_Information_PatientNoTitleFilterData", AV66View_New_Encounter2view_NE_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32View_New_Encounter2view_NE_DepartmentadmTitleFilterData", AV32View_New_Encounter2view_NE_DepartmentadmTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28View_New_Encounter2view_NE_ENCTypeTitleFilterData", AV28View_New_Encounter2view_NE_ENCTypeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42View_New_Encounter2view_NE_StatusTitleFilterData", AV42View_New_Encounter2view_NE_StatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50View_New_Encounter2view_NE_IsRandApproveTitleFilterData", AV50View_New_Encounter2view_NE_IsRandApproveTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV46View_New_Encounter2view_NE_IsRandRecheckTitleFilterData", AV46View_New_Encounter2view_NE_IsRandRecheckTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV54View_New_Encounter2view_NE_IsUpdateTitleFilterData", AV54View_New_Encounter2view_NE_IsUpdateTitleFilterData);
      }

      protected void E11AL2( )
      {
         /* Gridpaginationbar_Changepage Routine */
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
            AV71PageToGo = (int)(NumberUtil.Val( Gridpaginationbar_Selectedpage, "."));
            subgrid_gotopage( AV71PageToGo) ;
         }
      }

      protected void E12AL2( )
      {
         /* Gridpaginationbar_Changerowsperpage Routine */
         subGrid_Rows = Gridpaginationbar_Rowsperpageselectedvalue;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         subgrid_firstpage( ) ;
         /*  Sending Event outputs  */
      }

      protected void E13AL2( )
      {
         /* Ddo_view_new_encounter2view_ne_encounterid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_view_new_encounter2view_ne_encounterid_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_view_new_encounter2view_ne_encounterid_Sortedstatus = "ASC";
            ucDdo_view_new_encounter2view_ne_encounterid.SendProperty(context, "", false, Ddo_view_new_encounter2view_ne_encounterid_Internalname, "SortedStatus", Ddo_view_new_encounter2view_ne_encounterid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_view_new_encounter2view_ne_encounterid_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_view_new_encounter2view_ne_encounterid_Sortedstatus = "DSC";
            ucDdo_view_new_encounter2view_ne_encounterid.SendProperty(context, "", false, Ddo_view_new_encounter2view_ne_encounterid_Internalname, "SortedStatus", Ddo_view_new_encounter2view_ne_encounterid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_view_new_encounter2view_ne_encounterid_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV25TFView_New_Encounter2view_NE_EncounterID = (long)(NumberUtil.Val( Ddo_view_new_encounter2view_ne_encounterid_Filteredtext_get, "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25TFView_New_Encounter2view_NE_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV25TFView_New_Encounter2view_NE_EncounterID), 18, 0)));
            AV26TFView_New_Encounter2view_NE_EncounterID_To = (long)(NumberUtil.Val( Ddo_view_new_encounter2view_ne_encounterid_Filteredtextto_get, "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26TFView_New_Encounter2view_NE_EncounterID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV26TFView_New_Encounter2view_NE_EncounterID_To), 18, 0)));
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV93tAllBR_EncounterID", AV93tAllBR_EncounterID);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24View_New_Encounter2view_NE_EncounterIDTitleFilterData", AV24View_New_Encounter2view_NE_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV66View_New_Encounter2view_NE_Information_PatientNoTitleFilterData", AV66View_New_Encounter2view_NE_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32View_New_Encounter2view_NE_DepartmentadmTitleFilterData", AV32View_New_Encounter2view_NE_DepartmentadmTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28View_New_Encounter2view_NE_ENCTypeTitleFilterData", AV28View_New_Encounter2view_NE_ENCTypeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42View_New_Encounter2view_NE_StatusTitleFilterData", AV42View_New_Encounter2view_NE_StatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50View_New_Encounter2view_NE_IsRandApproveTitleFilterData", AV50View_New_Encounter2view_NE_IsRandApproveTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV46View_New_Encounter2view_NE_IsRandRecheckTitleFilterData", AV46View_New_Encounter2view_NE_IsRandRecheckTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV54View_New_Encounter2view_NE_IsUpdateTitleFilterData", AV54View_New_Encounter2view_NE_IsUpdateTitleFilterData);
      }

      protected void E14AL2( )
      {
         /* Ddo_view_new_encounter2view_ne_information_patientno_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_view_new_encounter2view_ne_information_patientno_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_view_new_encounter2view_ne_information_patientno_Sortedstatus = "ASC";
            ucDdo_view_new_encounter2view_ne_information_patientno.SendProperty(context, "", false, Ddo_view_new_encounter2view_ne_information_patientno_Internalname, "SortedStatus", Ddo_view_new_encounter2view_ne_information_patientno_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_view_new_encounter2view_ne_information_patientno_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_view_new_encounter2view_ne_information_patientno_Sortedstatus = "DSC";
            ucDdo_view_new_encounter2view_ne_information_patientno.SendProperty(context, "", false, Ddo_view_new_encounter2view_ne_information_patientno_Internalname, "SortedStatus", Ddo_view_new_encounter2view_ne_information_patientno_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_view_new_encounter2view_ne_information_patientno_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV67TFView_New_Encounter2view_NE_Information_PatientNo = Ddo_view_new_encounter2view_ne_information_patientno_Filteredtext_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV67TFView_New_Encounter2view_NE_Information_PatientNo", AV67TFView_New_Encounter2view_NE_Information_PatientNo);
            AV68TFView_New_Encounter2view_NE_Information_PatientNo_Sel = Ddo_view_new_encounter2view_ne_information_patientno_Selectedvalue_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV68TFView_New_Encounter2view_NE_Information_PatientNo_Sel", AV68TFView_New_Encounter2view_NE_Information_PatientNo_Sel);
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV93tAllBR_EncounterID", AV93tAllBR_EncounterID);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24View_New_Encounter2view_NE_EncounterIDTitleFilterData", AV24View_New_Encounter2view_NE_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV66View_New_Encounter2view_NE_Information_PatientNoTitleFilterData", AV66View_New_Encounter2view_NE_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32View_New_Encounter2view_NE_DepartmentadmTitleFilterData", AV32View_New_Encounter2view_NE_DepartmentadmTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28View_New_Encounter2view_NE_ENCTypeTitleFilterData", AV28View_New_Encounter2view_NE_ENCTypeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42View_New_Encounter2view_NE_StatusTitleFilterData", AV42View_New_Encounter2view_NE_StatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50View_New_Encounter2view_NE_IsRandApproveTitleFilterData", AV50View_New_Encounter2view_NE_IsRandApproveTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV46View_New_Encounter2view_NE_IsRandRecheckTitleFilterData", AV46View_New_Encounter2view_NE_IsRandRecheckTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV54View_New_Encounter2view_NE_IsUpdateTitleFilterData", AV54View_New_Encounter2view_NE_IsUpdateTitleFilterData);
      }

      protected void E15AL2( )
      {
         /* Ddo_view_new_encounter2view_ne_departmentadm_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_view_new_encounter2view_ne_departmentadm_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 3;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_view_new_encounter2view_ne_departmentadm_Sortedstatus = "ASC";
            ucDdo_view_new_encounter2view_ne_departmentadm.SendProperty(context, "", false, Ddo_view_new_encounter2view_ne_departmentadm_Internalname, "SortedStatus", Ddo_view_new_encounter2view_ne_departmentadm_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_view_new_encounter2view_ne_departmentadm_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 3;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_view_new_encounter2view_ne_departmentadm_Sortedstatus = "DSC";
            ucDdo_view_new_encounter2view_ne_departmentadm.SendProperty(context, "", false, Ddo_view_new_encounter2view_ne_departmentadm_Internalname, "SortedStatus", Ddo_view_new_encounter2view_ne_departmentadm_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_view_new_encounter2view_ne_departmentadm_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV33TFView_New_Encounter2view_NE_Departmentadm = Ddo_view_new_encounter2view_ne_departmentadm_Filteredtext_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33TFView_New_Encounter2view_NE_Departmentadm", AV33TFView_New_Encounter2view_NE_Departmentadm);
            AV34TFView_New_Encounter2view_NE_Departmentadm_Sel = Ddo_view_new_encounter2view_ne_departmentadm_Selectedvalue_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34TFView_New_Encounter2view_NE_Departmentadm_Sel", AV34TFView_New_Encounter2view_NE_Departmentadm_Sel);
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV93tAllBR_EncounterID", AV93tAllBR_EncounterID);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24View_New_Encounter2view_NE_EncounterIDTitleFilterData", AV24View_New_Encounter2view_NE_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV66View_New_Encounter2view_NE_Information_PatientNoTitleFilterData", AV66View_New_Encounter2view_NE_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32View_New_Encounter2view_NE_DepartmentadmTitleFilterData", AV32View_New_Encounter2view_NE_DepartmentadmTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28View_New_Encounter2view_NE_ENCTypeTitleFilterData", AV28View_New_Encounter2view_NE_ENCTypeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42View_New_Encounter2view_NE_StatusTitleFilterData", AV42View_New_Encounter2view_NE_StatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50View_New_Encounter2view_NE_IsRandApproveTitleFilterData", AV50View_New_Encounter2view_NE_IsRandApproveTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV46View_New_Encounter2view_NE_IsRandRecheckTitleFilterData", AV46View_New_Encounter2view_NE_IsRandRecheckTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV54View_New_Encounter2view_NE_IsUpdateTitleFilterData", AV54View_New_Encounter2view_NE_IsUpdateTitleFilterData);
      }

      protected void E16AL2( )
      {
         /* Ddo_view_new_encounter2view_ne_enctype_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_view_new_encounter2view_ne_enctype_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 4;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_view_new_encounter2view_ne_enctype_Sortedstatus = "ASC";
            ucDdo_view_new_encounter2view_ne_enctype.SendProperty(context, "", false, Ddo_view_new_encounter2view_ne_enctype_Internalname, "SortedStatus", Ddo_view_new_encounter2view_ne_enctype_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_view_new_encounter2view_ne_enctype_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 4;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_view_new_encounter2view_ne_enctype_Sortedstatus = "DSC";
            ucDdo_view_new_encounter2view_ne_enctype.SendProperty(context, "", false, Ddo_view_new_encounter2view_ne_enctype_Internalname, "SortedStatus", Ddo_view_new_encounter2view_ne_enctype_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_view_new_encounter2view_ne_enctype_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV29TFView_New_Encounter2view_NE_ENCType = Ddo_view_new_encounter2view_ne_enctype_Filteredtext_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29TFView_New_Encounter2view_NE_ENCType", AV29TFView_New_Encounter2view_NE_ENCType);
            AV30TFView_New_Encounter2view_NE_ENCType_Sel = Ddo_view_new_encounter2view_ne_enctype_Selectedvalue_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30TFView_New_Encounter2view_NE_ENCType_Sel", AV30TFView_New_Encounter2view_NE_ENCType_Sel);
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV93tAllBR_EncounterID", AV93tAllBR_EncounterID);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24View_New_Encounter2view_NE_EncounterIDTitleFilterData", AV24View_New_Encounter2view_NE_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV66View_New_Encounter2view_NE_Information_PatientNoTitleFilterData", AV66View_New_Encounter2view_NE_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32View_New_Encounter2view_NE_DepartmentadmTitleFilterData", AV32View_New_Encounter2view_NE_DepartmentadmTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28View_New_Encounter2view_NE_ENCTypeTitleFilterData", AV28View_New_Encounter2view_NE_ENCTypeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42View_New_Encounter2view_NE_StatusTitleFilterData", AV42View_New_Encounter2view_NE_StatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50View_New_Encounter2view_NE_IsRandApproveTitleFilterData", AV50View_New_Encounter2view_NE_IsRandApproveTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV46View_New_Encounter2view_NE_IsRandRecheckTitleFilterData", AV46View_New_Encounter2view_NE_IsRandRecheckTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV54View_New_Encounter2view_NE_IsUpdateTitleFilterData", AV54View_New_Encounter2view_NE_IsUpdateTitleFilterData);
      }

      protected void E17AL2( )
      {
         /* Ddo_view_new_encounter2view_ne_status_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_view_new_encounter2view_ne_status_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 5;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_view_new_encounter2view_ne_status_Sortedstatus = "ASC";
            ucDdo_view_new_encounter2view_ne_status.SendProperty(context, "", false, Ddo_view_new_encounter2view_ne_status_Internalname, "SortedStatus", Ddo_view_new_encounter2view_ne_status_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_view_new_encounter2view_ne_status_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 5;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_view_new_encounter2view_ne_status_Sortedstatus = "DSC";
            ucDdo_view_new_encounter2view_ne_status.SendProperty(context, "", false, Ddo_view_new_encounter2view_ne_status_Internalname, "SortedStatus", Ddo_view_new_encounter2view_ne_status_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_view_new_encounter2view_ne_status_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV104TFView_New_Encounter2view_NE_Status_SelsJson = Ddo_view_new_encounter2view_ne_status_Selectedvalue_get;
            AV105TFView_New_Encounter2view_NE_Status_Sels.FromJSonString(StringUtil.StringReplace( AV104TFView_New_Encounter2view_NE_Status_SelsJson, "\"", ""), null);
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV105TFView_New_Encounter2view_NE_Status_Sels", AV105TFView_New_Encounter2view_NE_Status_Sels);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV93tAllBR_EncounterID", AV93tAllBR_EncounterID);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24View_New_Encounter2view_NE_EncounterIDTitleFilterData", AV24View_New_Encounter2view_NE_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV66View_New_Encounter2view_NE_Information_PatientNoTitleFilterData", AV66View_New_Encounter2view_NE_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32View_New_Encounter2view_NE_DepartmentadmTitleFilterData", AV32View_New_Encounter2view_NE_DepartmentadmTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28View_New_Encounter2view_NE_ENCTypeTitleFilterData", AV28View_New_Encounter2view_NE_ENCTypeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42View_New_Encounter2view_NE_StatusTitleFilterData", AV42View_New_Encounter2view_NE_StatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50View_New_Encounter2view_NE_IsRandApproveTitleFilterData", AV50View_New_Encounter2view_NE_IsRandApproveTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV46View_New_Encounter2view_NE_IsRandRecheckTitleFilterData", AV46View_New_Encounter2view_NE_IsRandRecheckTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV54View_New_Encounter2view_NE_IsUpdateTitleFilterData", AV54View_New_Encounter2view_NE_IsUpdateTitleFilterData);
      }

      protected void E18AL2( )
      {
         /* Ddo_view_new_encounter2view_ne_israndapprove_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_view_new_encounter2view_ne_israndapprove_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 6;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_view_new_encounter2view_ne_israndapprove_Sortedstatus = "ASC";
            ucDdo_view_new_encounter2view_ne_israndapprove.SendProperty(context, "", false, Ddo_view_new_encounter2view_ne_israndapprove_Internalname, "SortedStatus", Ddo_view_new_encounter2view_ne_israndapprove_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_view_new_encounter2view_ne_israndapprove_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 6;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_view_new_encounter2view_ne_israndapprove_Sortedstatus = "DSC";
            ucDdo_view_new_encounter2view_ne_israndapprove.SendProperty(context, "", false, Ddo_view_new_encounter2view_ne_israndapprove_Internalname, "SortedStatus", Ddo_view_new_encounter2view_ne_israndapprove_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_view_new_encounter2view_ne_israndapprove_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV106TFView_New_Encounter2view_NE_IsRandApprove_Sel = (short)(NumberUtil.Val( Ddo_view_new_encounter2view_ne_israndapprove_Selectedvalue_get, "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV106TFView_New_Encounter2view_NE_IsRandApprove_Sel", StringUtil.Str( (decimal)(AV106TFView_New_Encounter2view_NE_IsRandApprove_Sel), 1, 0));
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV93tAllBR_EncounterID", AV93tAllBR_EncounterID);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24View_New_Encounter2view_NE_EncounterIDTitleFilterData", AV24View_New_Encounter2view_NE_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV66View_New_Encounter2view_NE_Information_PatientNoTitleFilterData", AV66View_New_Encounter2view_NE_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32View_New_Encounter2view_NE_DepartmentadmTitleFilterData", AV32View_New_Encounter2view_NE_DepartmentadmTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28View_New_Encounter2view_NE_ENCTypeTitleFilterData", AV28View_New_Encounter2view_NE_ENCTypeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42View_New_Encounter2view_NE_StatusTitleFilterData", AV42View_New_Encounter2view_NE_StatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50View_New_Encounter2view_NE_IsRandApproveTitleFilterData", AV50View_New_Encounter2view_NE_IsRandApproveTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV46View_New_Encounter2view_NE_IsRandRecheckTitleFilterData", AV46View_New_Encounter2view_NE_IsRandRecheckTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV54View_New_Encounter2view_NE_IsUpdateTitleFilterData", AV54View_New_Encounter2view_NE_IsUpdateTitleFilterData);
      }

      protected void E19AL2( )
      {
         /* Ddo_view_new_encounter2view_ne_israndrecheck_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_view_new_encounter2view_ne_israndrecheck_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 7;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_view_new_encounter2view_ne_israndrecheck_Sortedstatus = "ASC";
            ucDdo_view_new_encounter2view_ne_israndrecheck.SendProperty(context, "", false, Ddo_view_new_encounter2view_ne_israndrecheck_Internalname, "SortedStatus", Ddo_view_new_encounter2view_ne_israndrecheck_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_view_new_encounter2view_ne_israndrecheck_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 7;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_view_new_encounter2view_ne_israndrecheck_Sortedstatus = "DSC";
            ucDdo_view_new_encounter2view_ne_israndrecheck.SendProperty(context, "", false, Ddo_view_new_encounter2view_ne_israndrecheck_Internalname, "SortedStatus", Ddo_view_new_encounter2view_ne_israndrecheck_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_view_new_encounter2view_ne_israndrecheck_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV107TFView_New_Encounter2view_NE_IsRandRecheck_Sel = (short)(NumberUtil.Val( Ddo_view_new_encounter2view_ne_israndrecheck_Selectedvalue_get, "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV107TFView_New_Encounter2view_NE_IsRandRecheck_Sel", StringUtil.Str( (decimal)(AV107TFView_New_Encounter2view_NE_IsRandRecheck_Sel), 1, 0));
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV93tAllBR_EncounterID", AV93tAllBR_EncounterID);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24View_New_Encounter2view_NE_EncounterIDTitleFilterData", AV24View_New_Encounter2view_NE_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV66View_New_Encounter2view_NE_Information_PatientNoTitleFilterData", AV66View_New_Encounter2view_NE_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32View_New_Encounter2view_NE_DepartmentadmTitleFilterData", AV32View_New_Encounter2view_NE_DepartmentadmTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28View_New_Encounter2view_NE_ENCTypeTitleFilterData", AV28View_New_Encounter2view_NE_ENCTypeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42View_New_Encounter2view_NE_StatusTitleFilterData", AV42View_New_Encounter2view_NE_StatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50View_New_Encounter2view_NE_IsRandApproveTitleFilterData", AV50View_New_Encounter2view_NE_IsRandApproveTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV46View_New_Encounter2view_NE_IsRandRecheckTitleFilterData", AV46View_New_Encounter2view_NE_IsRandRecheckTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV54View_New_Encounter2view_NE_IsUpdateTitleFilterData", AV54View_New_Encounter2view_NE_IsUpdateTitleFilterData);
      }

      protected void E20AL2( )
      {
         /* Ddo_view_new_encounter2view_ne_isupdate_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_view_new_encounter2view_ne_isupdate_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 8;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_view_new_encounter2view_ne_isupdate_Sortedstatus = "ASC";
            ucDdo_view_new_encounter2view_ne_isupdate.SendProperty(context, "", false, Ddo_view_new_encounter2view_ne_isupdate_Internalname, "SortedStatus", Ddo_view_new_encounter2view_ne_isupdate_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_view_new_encounter2view_ne_isupdate_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 8;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_view_new_encounter2view_ne_isupdate_Sortedstatus = "DSC";
            ucDdo_view_new_encounter2view_ne_isupdate.SendProperty(context, "", false, Ddo_view_new_encounter2view_ne_isupdate_Internalname, "SortedStatus", Ddo_view_new_encounter2view_ne_isupdate_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_view_new_encounter2view_ne_isupdate_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV108TFView_New_Encounter2view_NE_IsUpdate_Sel = (short)(NumberUtil.Val( Ddo_view_new_encounter2view_ne_isupdate_Selectedvalue_get, "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV108TFView_New_Encounter2view_NE_IsUpdate_Sel", StringUtil.Str( (decimal)(AV108TFView_New_Encounter2view_NE_IsUpdate_Sel), 1, 0));
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV93tAllBR_EncounterID", AV93tAllBR_EncounterID);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24View_New_Encounter2view_NE_EncounterIDTitleFilterData", AV24View_New_Encounter2view_NE_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV66View_New_Encounter2view_NE_Information_PatientNoTitleFilterData", AV66View_New_Encounter2view_NE_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32View_New_Encounter2view_NE_DepartmentadmTitleFilterData", AV32View_New_Encounter2view_NE_DepartmentadmTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28View_New_Encounter2view_NE_ENCTypeTitleFilterData", AV28View_New_Encounter2view_NE_ENCTypeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42View_New_Encounter2view_NE_StatusTitleFilterData", AV42View_New_Encounter2view_NE_StatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50View_New_Encounter2view_NE_IsRandApproveTitleFilterData", AV50View_New_Encounter2view_NE_IsRandApproveTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV46View_New_Encounter2view_NE_IsRandRecheckTitleFilterData", AV46View_New_Encounter2view_NE_IsRandRecheckTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV54View_New_Encounter2view_NE_IsUpdateTitleFilterData", AV54View_New_Encounter2view_NE_IsUpdateTitleFilterData);
      }

      private void E26AL2( )
      {
         /* Grid_Load Routine */
         AV78PatientNo = A601View_New_Encounter2view_NE_Information_PatientNo;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavPatientno_Internalname, AV78PatientNo);
         AV79AdmitDate = A594View_New_Encounter2view_NE_AdmitDate;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavAdmitdate_Internalname, context.localUtil.Format(AV79AdmitDate, "9999/99/99"));
         AV80deleteEncounter = context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavDeleteencounter_Internalname, AV80deleteEncounter);
         AV129Deleteencounter_GXI = GXDbFile.PathToUrl( context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", context.GetTheme( )));
         edtavDeleteencounter_Tooltiptext = "";
         /* Load Method */
         if ( wbStart != -1 )
         {
            wbStart = 76;
         }
         sendrow_762( ) ;
         GRID_nCurrentRecord = (long)(GRID_nCurrentRecord+1);
         if ( isFullAjaxMode( ) && ! bGXsfl_76_Refreshing )
         {
            context.DoAjaxLoad(76, GridRow);
         }
         /*  Sending Event outputs  */
      }

      protected void E21AL2( )
      {
         /* Dvelop_confirmpanel_batchapprove_Close Routine */
         if ( StringUtil.StrCmp(Dvelop_confirmpanel_batchapprove_Result, "Yes") == 0 )
         {
            /* Execute user subroutine: 'DO ACTION BATCHAPPROVE' */
            S182 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV93tAllBR_EncounterID", AV93tAllBR_EncounterID);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24View_New_Encounter2view_NE_EncounterIDTitleFilterData", AV24View_New_Encounter2view_NE_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV66View_New_Encounter2view_NE_Information_PatientNoTitleFilterData", AV66View_New_Encounter2view_NE_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32View_New_Encounter2view_NE_DepartmentadmTitleFilterData", AV32View_New_Encounter2view_NE_DepartmentadmTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28View_New_Encounter2view_NE_ENCTypeTitleFilterData", AV28View_New_Encounter2view_NE_ENCTypeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42View_New_Encounter2view_NE_StatusTitleFilterData", AV42View_New_Encounter2view_NE_StatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50View_New_Encounter2view_NE_IsRandApproveTitleFilterData", AV50View_New_Encounter2view_NE_IsRandApproveTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV46View_New_Encounter2view_NE_IsRandRecheckTitleFilterData", AV46View_New_Encounter2view_NE_IsRandRecheckTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV54View_New_Encounter2view_NE_IsUpdateTitleFilterData", AV54View_New_Encounter2view_NE_IsUpdateTitleFilterData);
      }

      protected void E22AL2( )
      {
         /* Dvelop_confirmpanel_batchrecheck_Close Routine */
         if ( StringUtil.StrCmp(Dvelop_confirmpanel_batchrecheck_Result, "Yes") == 0 )
         {
            /* Execute user subroutine: 'DO ACTION BATCHRECHECK' */
            S192 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV93tAllBR_EncounterID", AV93tAllBR_EncounterID);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24View_New_Encounter2view_NE_EncounterIDTitleFilterData", AV24View_New_Encounter2view_NE_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV66View_New_Encounter2view_NE_Information_PatientNoTitleFilterData", AV66View_New_Encounter2view_NE_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32View_New_Encounter2view_NE_DepartmentadmTitleFilterData", AV32View_New_Encounter2view_NE_DepartmentadmTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28View_New_Encounter2view_NE_ENCTypeTitleFilterData", AV28View_New_Encounter2view_NE_ENCTypeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42View_New_Encounter2view_NE_StatusTitleFilterData", AV42View_New_Encounter2view_NE_StatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50View_New_Encounter2view_NE_IsRandApproveTitleFilterData", AV50View_New_Encounter2view_NE_IsRandApproveTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV46View_New_Encounter2view_NE_IsRandRecheckTitleFilterData", AV46View_New_Encounter2view_NE_IsRandRecheckTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV54View_New_Encounter2view_NE_IsUpdateTitleFilterData", AV54View_New_Encounter2view_NE_IsUpdateTitleFilterData);
      }

      protected void S162( )
      {
         /* 'RESETDDOSORTEDSTATUS' Routine */
         Ddo_view_new_encounter2view_ne_encounterid_Sortedstatus = "";
         ucDdo_view_new_encounter2view_ne_encounterid.SendProperty(context, "", false, Ddo_view_new_encounter2view_ne_encounterid_Internalname, "SortedStatus", Ddo_view_new_encounter2view_ne_encounterid_Sortedstatus);
         Ddo_view_new_encounter2view_ne_information_patientno_Sortedstatus = "";
         ucDdo_view_new_encounter2view_ne_information_patientno.SendProperty(context, "", false, Ddo_view_new_encounter2view_ne_information_patientno_Internalname, "SortedStatus", Ddo_view_new_encounter2view_ne_information_patientno_Sortedstatus);
         Ddo_view_new_encounter2view_ne_departmentadm_Sortedstatus = "";
         ucDdo_view_new_encounter2view_ne_departmentadm.SendProperty(context, "", false, Ddo_view_new_encounter2view_ne_departmentadm_Internalname, "SortedStatus", Ddo_view_new_encounter2view_ne_departmentadm_Sortedstatus);
         Ddo_view_new_encounter2view_ne_enctype_Sortedstatus = "";
         ucDdo_view_new_encounter2view_ne_enctype.SendProperty(context, "", false, Ddo_view_new_encounter2view_ne_enctype_Internalname, "SortedStatus", Ddo_view_new_encounter2view_ne_enctype_Sortedstatus);
         Ddo_view_new_encounter2view_ne_status_Sortedstatus = "";
         ucDdo_view_new_encounter2view_ne_status.SendProperty(context, "", false, Ddo_view_new_encounter2view_ne_status_Internalname, "SortedStatus", Ddo_view_new_encounter2view_ne_status_Sortedstatus);
         Ddo_view_new_encounter2view_ne_israndapprove_Sortedstatus = "";
         ucDdo_view_new_encounter2view_ne_israndapprove.SendProperty(context, "", false, Ddo_view_new_encounter2view_ne_israndapprove_Internalname, "SortedStatus", Ddo_view_new_encounter2view_ne_israndapprove_Sortedstatus);
         Ddo_view_new_encounter2view_ne_israndrecheck_Sortedstatus = "";
         ucDdo_view_new_encounter2view_ne_israndrecheck.SendProperty(context, "", false, Ddo_view_new_encounter2view_ne_israndrecheck_Internalname, "SortedStatus", Ddo_view_new_encounter2view_ne_israndrecheck_Sortedstatus);
         Ddo_view_new_encounter2view_ne_isupdate_Sortedstatus = "";
         ucDdo_view_new_encounter2view_ne_isupdate.SendProperty(context, "", false, Ddo_view_new_encounter2view_ne_isupdate_Internalname, "SortedStatus", Ddo_view_new_encounter2view_ne_isupdate_Sortedstatus);
      }

      protected void S132( )
      {
         /* 'SETDDOSORTEDSTATUS' Routine */
         /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
         S162 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         if ( AV13OrderedBy == 1 )
         {
            Ddo_view_new_encounter2view_ne_encounterid_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_view_new_encounter2view_ne_encounterid.SendProperty(context, "", false, Ddo_view_new_encounter2view_ne_encounterid_Internalname, "SortedStatus", Ddo_view_new_encounter2view_ne_encounterid_Sortedstatus);
         }
         else if ( AV13OrderedBy == 2 )
         {
            Ddo_view_new_encounter2view_ne_information_patientno_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_view_new_encounter2view_ne_information_patientno.SendProperty(context, "", false, Ddo_view_new_encounter2view_ne_information_patientno_Internalname, "SortedStatus", Ddo_view_new_encounter2view_ne_information_patientno_Sortedstatus);
         }
         else if ( AV13OrderedBy == 3 )
         {
            Ddo_view_new_encounter2view_ne_departmentadm_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_view_new_encounter2view_ne_departmentadm.SendProperty(context, "", false, Ddo_view_new_encounter2view_ne_departmentadm_Internalname, "SortedStatus", Ddo_view_new_encounter2view_ne_departmentadm_Sortedstatus);
         }
         else if ( AV13OrderedBy == 4 )
         {
            Ddo_view_new_encounter2view_ne_enctype_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_view_new_encounter2view_ne_enctype.SendProperty(context, "", false, Ddo_view_new_encounter2view_ne_enctype_Internalname, "SortedStatus", Ddo_view_new_encounter2view_ne_enctype_Sortedstatus);
         }
         else if ( AV13OrderedBy == 5 )
         {
            Ddo_view_new_encounter2view_ne_status_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_view_new_encounter2view_ne_status.SendProperty(context, "", false, Ddo_view_new_encounter2view_ne_status_Internalname, "SortedStatus", Ddo_view_new_encounter2view_ne_status_Sortedstatus);
         }
         else if ( AV13OrderedBy == 6 )
         {
            Ddo_view_new_encounter2view_ne_israndapprove_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_view_new_encounter2view_ne_israndapprove.SendProperty(context, "", false, Ddo_view_new_encounter2view_ne_israndapprove_Internalname, "SortedStatus", Ddo_view_new_encounter2view_ne_israndapprove_Sortedstatus);
         }
         else if ( AV13OrderedBy == 7 )
         {
            Ddo_view_new_encounter2view_ne_israndrecheck_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_view_new_encounter2view_ne_israndrecheck.SendProperty(context, "", false, Ddo_view_new_encounter2view_ne_israndrecheck_Internalname, "SortedStatus", Ddo_view_new_encounter2view_ne_israndrecheck_Sortedstatus);
         }
         else if ( AV13OrderedBy == 8 )
         {
            Ddo_view_new_encounter2view_ne_isupdate_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_view_new_encounter2view_ne_isupdate.SendProperty(context, "", false, Ddo_view_new_encounter2view_ne_isupdate_Internalname, "SortedStatus", Ddo_view_new_encounter2view_ne_isupdate_Sortedstatus);
         }
      }

      protected void S142( )
      {
         /* 'CHECKSECURITYFORACTIONS' Routine */
         GXt_boolean3 = AV81IsAuthorized_deleteEncounter;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "WWBR_Encounter_Delete", out  GXt_boolean3) ;
         AV81IsAuthorized_deleteEncounter = GXt_boolean3;
         if ( ! ( AV81IsAuthorized_deleteEncounter ) )
         {
            edtavDeleteencounter_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDeleteencounter_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDeleteencounter_Visible), 5, 0)), !bGXsfl_76_Refreshing);
         }
         GXt_boolean3 = AV77TempBoolean;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Role_Checker", out  GXt_boolean3) ;
         AV77TempBoolean = GXt_boolean3;
         if ( ! ( AV77TempBoolean ) )
         {
            bttBtnbatchapprove_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtnbatchapprove_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtnbatchapprove_Visible), 5, 0)), true);
         }
         GXt_boolean3 = AV77TempBoolean;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Role_Approver", out  GXt_boolean3) ;
         AV77TempBoolean = GXt_boolean3;
         if ( ! ( AV77TempBoolean ) )
         {
            bttBtnbatchrecheck_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtnbatchrecheck_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtnbatchrecheck_Visible), 5, 0)), true);
         }
      }

      protected void S172( )
      {
         /* 'DO DELETEENCOUNTER' Routine */
      }

      protected void S182( )
      {
         /* 'DO ACTION BATCHAPPROVE' Routine */
         new zutil_checksession(context ).execute( out  AV99tCheckFlag) ;
         if ( ! AV99tCheckFlag )
         {
            new zbr_batchapprove(context ).execute(  AV93tAllBR_EncounterID) ;
            context.DoAjaxRefresh();
         }
      }

      protected void S192( )
      {
         /* 'DO ACTION BATCHRECHECK' Routine */
         new zutil_checksession(context ).execute( out  AV99tCheckFlag) ;
         if ( ! AV99tCheckFlag )
         {
            new zbr_batchrecheck(context ).execute(  AV93tAllBR_EncounterID) ;
            context.DoAjaxRefresh();
         }
      }

      protected void S122( )
      {
         /* 'LOADGRIDSTATE' Routine */
         if ( StringUtil.StrCmp(AV19Session.Get(AV111Pgmname+"GridState"), "") == 0 )
         {
            AV11GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  AV111Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         else
         {
            AV11GridState.FromXml(AV19Session.Get(AV111Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         AV13OrderedBy = AV11GridState.gxTpr_Orderedby;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
         AV14OrderedDsc = AV11GridState.gxTpr_Ordereddsc;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
         /* Execute user subroutine: 'SETDDOSORTEDSTATUS' */
         S132 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         AV130GXV1 = 1;
         while ( AV130GXV1 <= AV11GridState.gxTpr_Filtervalues.Count )
         {
            AV12GridStateFilterValue = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue)AV11GridState.gxTpr_Filtervalues.Item(AV130GXV1));
            if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "BR_INFORMATION_PATIENTNO") == 0 )
            {
               AV15BR_Information_PatientNo = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15BR_Information_PatientNo", AV15BR_Information_PatientNo);
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE") == 0 )
            {
               AV101View_New_Encounter2view_NE_IsRandApprove = BooleanUtil.Val( AV12GridStateFilterValue.gxTpr_Value);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV101View_New_Encounter2view_NE_IsRandApprove", AV101View_New_Encounter2view_NE_IsRandApprove);
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK") == 0 )
            {
               AV102View_New_Encounter2view_NE_IsRandRecheck = BooleanUtil.Val( AV12GridStateFilterValue.gxTpr_Value);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV102View_New_Encounter2view_NE_IsRandRecheck", AV102View_New_Encounter2view_NE_IsRandRecheck);
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE") == 0 )
            {
               AV103View_New_Encounter2view_NE_IsUpdate = BooleanUtil.Val( AV12GridStateFilterValue.gxTpr_Value);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV103View_New_Encounter2view_NE_IsUpdate", AV103View_New_Encounter2view_NE_IsUpdate);
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFVIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID") == 0 )
            {
               AV25TFView_New_Encounter2view_NE_EncounterID = (long)(NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Value, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25TFView_New_Encounter2view_NE_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV25TFView_New_Encounter2view_NE_EncounterID), 18, 0)));
               AV26TFView_New_Encounter2view_NE_EncounterID_To = (long)(NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Valueto, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26TFView_New_Encounter2view_NE_EncounterID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV26TFView_New_Encounter2view_NE_EncounterID_To), 18, 0)));
               if ( ! (0==AV25TFView_New_Encounter2view_NE_EncounterID) )
               {
                  Ddo_view_new_encounter2view_ne_encounterid_Filteredtext_set = StringUtil.Str( (decimal)(AV25TFView_New_Encounter2view_NE_EncounterID), 18, 0);
                  ucDdo_view_new_encounter2view_ne_encounterid.SendProperty(context, "", false, Ddo_view_new_encounter2view_ne_encounterid_Internalname, "FilteredText_set", Ddo_view_new_encounter2view_ne_encounterid_Filteredtext_set);
               }
               if ( ! (0==AV26TFView_New_Encounter2view_NE_EncounterID_To) )
               {
                  Ddo_view_new_encounter2view_ne_encounterid_Filteredtextto_set = StringUtil.Str( (decimal)(AV26TFView_New_Encounter2view_NE_EncounterID_To), 18, 0);
                  ucDdo_view_new_encounter2view_ne_encounterid.SendProperty(context, "", false, Ddo_view_new_encounter2view_ne_encounterid_Internalname, "FilteredTextTo_set", Ddo_view_new_encounter2view_ne_encounterid_Filteredtextto_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFVIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO") == 0 )
            {
               AV67TFView_New_Encounter2view_NE_Information_PatientNo = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV67TFView_New_Encounter2view_NE_Information_PatientNo", AV67TFView_New_Encounter2view_NE_Information_PatientNo);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV67TFView_New_Encounter2view_NE_Information_PatientNo)) )
               {
                  Ddo_view_new_encounter2view_ne_information_patientno_Filteredtext_set = AV67TFView_New_Encounter2view_NE_Information_PatientNo;
                  ucDdo_view_new_encounter2view_ne_information_patientno.SendProperty(context, "", false, Ddo_view_new_encounter2view_ne_information_patientno_Internalname, "FilteredText_set", Ddo_view_new_encounter2view_ne_information_patientno_Filteredtext_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFVIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO_SEL") == 0 )
            {
               AV68TFView_New_Encounter2view_NE_Information_PatientNo_Sel = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV68TFView_New_Encounter2view_NE_Information_PatientNo_Sel", AV68TFView_New_Encounter2view_NE_Information_PatientNo_Sel);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV68TFView_New_Encounter2view_NE_Information_PatientNo_Sel)) )
               {
                  Ddo_view_new_encounter2view_ne_information_patientno_Selectedvalue_set = AV68TFView_New_Encounter2view_NE_Information_PatientNo_Sel;
                  ucDdo_view_new_encounter2view_ne_information_patientno.SendProperty(context, "", false, Ddo_view_new_encounter2view_ne_information_patientno_Internalname, "SelectedValue_set", Ddo_view_new_encounter2view_ne_information_patientno_Selectedvalue_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFVIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM") == 0 )
            {
               AV33TFView_New_Encounter2view_NE_Departmentadm = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33TFView_New_Encounter2view_NE_Departmentadm", AV33TFView_New_Encounter2view_NE_Departmentadm);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV33TFView_New_Encounter2view_NE_Departmentadm)) )
               {
                  Ddo_view_new_encounter2view_ne_departmentadm_Filteredtext_set = AV33TFView_New_Encounter2view_NE_Departmentadm;
                  ucDdo_view_new_encounter2view_ne_departmentadm.SendProperty(context, "", false, Ddo_view_new_encounter2view_ne_departmentadm_Internalname, "FilteredText_set", Ddo_view_new_encounter2view_ne_departmentadm_Filteredtext_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFVIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM_SEL") == 0 )
            {
               AV34TFView_New_Encounter2view_NE_Departmentadm_Sel = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34TFView_New_Encounter2view_NE_Departmentadm_Sel", AV34TFView_New_Encounter2view_NE_Departmentadm_Sel);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV34TFView_New_Encounter2view_NE_Departmentadm_Sel)) )
               {
                  Ddo_view_new_encounter2view_ne_departmentadm_Selectedvalue_set = AV34TFView_New_Encounter2view_NE_Departmentadm_Sel;
                  ucDdo_view_new_encounter2view_ne_departmentadm.SendProperty(context, "", false, Ddo_view_new_encounter2view_ne_departmentadm_Internalname, "SelectedValue_set", Ddo_view_new_encounter2view_ne_departmentadm_Selectedvalue_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFVIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE") == 0 )
            {
               AV29TFView_New_Encounter2view_NE_ENCType = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29TFView_New_Encounter2view_NE_ENCType", AV29TFView_New_Encounter2view_NE_ENCType);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV29TFView_New_Encounter2view_NE_ENCType)) )
               {
                  Ddo_view_new_encounter2view_ne_enctype_Filteredtext_set = AV29TFView_New_Encounter2view_NE_ENCType;
                  ucDdo_view_new_encounter2view_ne_enctype.SendProperty(context, "", false, Ddo_view_new_encounter2view_ne_enctype_Internalname, "FilteredText_set", Ddo_view_new_encounter2view_ne_enctype_Filteredtext_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFVIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE_SEL") == 0 )
            {
               AV30TFView_New_Encounter2view_NE_ENCType_Sel = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30TFView_New_Encounter2view_NE_ENCType_Sel", AV30TFView_New_Encounter2view_NE_ENCType_Sel);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV30TFView_New_Encounter2view_NE_ENCType_Sel)) )
               {
                  Ddo_view_new_encounter2view_ne_enctype_Selectedvalue_set = AV30TFView_New_Encounter2view_NE_ENCType_Sel;
                  ucDdo_view_new_encounter2view_ne_enctype.SendProperty(context, "", false, Ddo_view_new_encounter2view_ne_enctype_Internalname, "SelectedValue_set", Ddo_view_new_encounter2view_ne_enctype_Selectedvalue_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFVIEW_NEW_ENCOUNTER2VIEW_NE_STATUS_SEL") == 0 )
            {
               AV104TFView_New_Encounter2view_NE_Status_SelsJson = AV12GridStateFilterValue.gxTpr_Value;
               AV105TFView_New_Encounter2view_NE_Status_Sels.FromJSonString(AV104TFView_New_Encounter2view_NE_Status_SelsJson, null);
               if ( ! ( AV105TFView_New_Encounter2view_NE_Status_Sels.Count == 0 ) )
               {
                  Ddo_view_new_encounter2view_ne_status_Selectedvalue_set = AV104TFView_New_Encounter2view_NE_Status_SelsJson;
                  ucDdo_view_new_encounter2view_ne_status.SendProperty(context, "", false, Ddo_view_new_encounter2view_ne_status_Internalname, "SelectedValue_set", Ddo_view_new_encounter2view_ne_status_Selectedvalue_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE_SEL") == 0 )
            {
               AV106TFView_New_Encounter2view_NE_IsRandApprove_Sel = (short)(NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Value, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV106TFView_New_Encounter2view_NE_IsRandApprove_Sel", StringUtil.Str( (decimal)(AV106TFView_New_Encounter2view_NE_IsRandApprove_Sel), 1, 0));
               if ( ! (0==AV106TFView_New_Encounter2view_NE_IsRandApprove_Sel) )
               {
                  Ddo_view_new_encounter2view_ne_israndapprove_Selectedvalue_set = StringUtil.Str( (decimal)(AV106TFView_New_Encounter2view_NE_IsRandApprove_Sel), 1, 0);
                  ucDdo_view_new_encounter2view_ne_israndapprove.SendProperty(context, "", false, Ddo_view_new_encounter2view_ne_israndapprove_Internalname, "SelectedValue_set", Ddo_view_new_encounter2view_ne_israndapprove_Selectedvalue_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK_SEL") == 0 )
            {
               AV107TFView_New_Encounter2view_NE_IsRandRecheck_Sel = (short)(NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Value, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV107TFView_New_Encounter2view_NE_IsRandRecheck_Sel", StringUtil.Str( (decimal)(AV107TFView_New_Encounter2view_NE_IsRandRecheck_Sel), 1, 0));
               if ( ! (0==AV107TFView_New_Encounter2view_NE_IsRandRecheck_Sel) )
               {
                  Ddo_view_new_encounter2view_ne_israndrecheck_Selectedvalue_set = StringUtil.Str( (decimal)(AV107TFView_New_Encounter2view_NE_IsRandRecheck_Sel), 1, 0);
                  ucDdo_view_new_encounter2view_ne_israndrecheck.SendProperty(context, "", false, Ddo_view_new_encounter2view_ne_israndrecheck_Internalname, "SelectedValue_set", Ddo_view_new_encounter2view_ne_israndrecheck_Selectedvalue_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFVIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE_SEL") == 0 )
            {
               AV108TFView_New_Encounter2view_NE_IsUpdate_Sel = (short)(NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Value, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV108TFView_New_Encounter2view_NE_IsUpdate_Sel", StringUtil.Str( (decimal)(AV108TFView_New_Encounter2view_NE_IsUpdate_Sel), 1, 0));
               if ( ! (0==AV108TFView_New_Encounter2view_NE_IsUpdate_Sel) )
               {
                  Ddo_view_new_encounter2view_ne_isupdate_Selectedvalue_set = StringUtil.Str( (decimal)(AV108TFView_New_Encounter2view_NE_IsUpdate_Sel), 1, 0);
                  ucDdo_view_new_encounter2view_ne_isupdate.SendProperty(context, "", false, Ddo_view_new_encounter2view_ne_isupdate_Internalname, "SelectedValue_set", Ddo_view_new_encounter2view_ne_isupdate_Selectedvalue_set);
               }
            }
            AV130GXV1 = (int)(AV130GXV1+1);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( StringUtil.Trim( AV11GridState.gxTpr_Pagesize))) )
         {
            subGrid_Rows = (int)(NumberUtil.Val( AV11GridState.gxTpr_Pagesize, "."));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         }
         subgrid_gotopage( AV11GridState.gxTpr_Currentpage) ;
      }

      protected void S152( )
      {
         /* 'SAVEGRIDSTATE' Routine */
         AV11GridState.FromXml(AV19Session.Get(AV111Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         AV11GridState.gxTpr_Orderedby = AV13OrderedBy;
         AV11GridState.gxTpr_Ordereddsc = AV14OrderedDsc;
         AV11GridState.gxTpr_Filtervalues.Clear();
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV15BR_Information_PatientNo)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "BR_INFORMATION_PATIENTNO";
            AV12GridStateFilterValue.gxTpr_Value = AV15BR_Information_PatientNo;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! (false==AV101View_New_Encounter2view_NE_IsRandApprove) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE";
            AV12GridStateFilterValue.gxTpr_Value = StringUtil.BoolToStr( AV101View_New_Encounter2view_NE_IsRandApprove);
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! (false==AV102View_New_Encounter2view_NE_IsRandRecheck) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK";
            AV12GridStateFilterValue.gxTpr_Value = StringUtil.BoolToStr( AV102View_New_Encounter2view_NE_IsRandRecheck);
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! (false==AV103View_New_Encounter2view_NE_IsUpdate) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE";
            AV12GridStateFilterValue.gxTpr_Value = StringUtil.BoolToStr( AV103View_New_Encounter2view_NE_IsUpdate);
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! ( (0==AV25TFView_New_Encounter2view_NE_EncounterID) && (0==AV26TFView_New_Encounter2view_NE_EncounterID_To) ) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFVIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID";
            AV12GridStateFilterValue.gxTpr_Value = StringUtil.Str( (decimal)(AV25TFView_New_Encounter2view_NE_EncounterID), 18, 0);
            AV12GridStateFilterValue.gxTpr_Valueto = StringUtil.Str( (decimal)(AV26TFView_New_Encounter2view_NE_EncounterID_To), 18, 0);
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV67TFView_New_Encounter2view_NE_Information_PatientNo)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFVIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO";
            AV12GridStateFilterValue.gxTpr_Value = AV67TFView_New_Encounter2view_NE_Information_PatientNo;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV68TFView_New_Encounter2view_NE_Information_PatientNo_Sel)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFVIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO_SEL";
            AV12GridStateFilterValue.gxTpr_Value = AV68TFView_New_Encounter2view_NE_Information_PatientNo_Sel;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV33TFView_New_Encounter2view_NE_Departmentadm)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFVIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM";
            AV12GridStateFilterValue.gxTpr_Value = AV33TFView_New_Encounter2view_NE_Departmentadm;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV34TFView_New_Encounter2view_NE_Departmentadm_Sel)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFVIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM_SEL";
            AV12GridStateFilterValue.gxTpr_Value = AV34TFView_New_Encounter2view_NE_Departmentadm_Sel;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV29TFView_New_Encounter2view_NE_ENCType)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFVIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE";
            AV12GridStateFilterValue.gxTpr_Value = AV29TFView_New_Encounter2view_NE_ENCType;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV30TFView_New_Encounter2view_NE_ENCType_Sel)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFVIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE_SEL";
            AV12GridStateFilterValue.gxTpr_Value = AV30TFView_New_Encounter2view_NE_ENCType_Sel;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! ( AV105TFView_New_Encounter2view_NE_Status_Sels.Count == 0 ) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFVIEW_NEW_ENCOUNTER2VIEW_NE_STATUS_SEL";
            AV12GridStateFilterValue.gxTpr_Value = AV105TFView_New_Encounter2view_NE_Status_Sels.ToJSonString(false);
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! (0==AV106TFView_New_Encounter2view_NE_IsRandApprove_Sel) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE_SEL";
            AV12GridStateFilterValue.gxTpr_Value = StringUtil.Str( (decimal)(AV106TFView_New_Encounter2view_NE_IsRandApprove_Sel), 1, 0);
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! (0==AV107TFView_New_Encounter2view_NE_IsRandRecheck_Sel) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK_SEL";
            AV12GridStateFilterValue.gxTpr_Value = StringUtil.Str( (decimal)(AV107TFView_New_Encounter2view_NE_IsRandRecheck_Sel), 1, 0);
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! (0==AV108TFView_New_Encounter2view_NE_IsUpdate_Sel) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFVIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE_SEL";
            AV12GridStateFilterValue.gxTpr_Value = StringUtil.Str( (decimal)(AV108TFView_New_Encounter2view_NE_IsUpdate_Sel), 1, 0);
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         AV11GridState.gxTpr_Pagesize = StringUtil.Str( (decimal)(subGrid_Rows), 10, 0);
         AV11GridState.gxTpr_Currentpage = (short)(subGrid_Currentpage( ));
         new GeneXus.Programs.wwpbaseobjects.savegridstate(context ).execute(  AV111Pgmname+"GridState",  AV11GridState.ToXml(false, true, "WWPGridState", "DataAnalysisPlatform")) ;
      }

      protected void S112( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV9TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV9TrnContext.gxTpr_Callerobject = AV111Pgmname;
         AV9TrnContext.gxTpr_Callerondelete = true;
         AV9TrnContext.gxTpr_Callerurl = AV8HTTPRequest.ScriptName+"?"+AV8HTTPRequest.QueryString;
         AV9TrnContext.gxTpr_Transactionname = "View_New_Encounter2";
         AV19Session.Set("TrnContext", AV9TrnContext.ToXml(false, true, "WWPTransactionContext", "DataAnalysisPlatform"));
      }

      protected void E23AL2( )
      {
         /* Sbr_encounterid_Controlvaluechanging Routine */
         new zutil_checksession(context ).execute( out  AV99tCheckFlag) ;
         if ( ! AV99tCheckFlag )
         {
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV93tAllBR_EncounterID", AV93tAllBR_EncounterID);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24View_New_Encounter2view_NE_EncounterIDTitleFilterData", AV24View_New_Encounter2view_NE_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV66View_New_Encounter2view_NE_Information_PatientNoTitleFilterData", AV66View_New_Encounter2view_NE_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32View_New_Encounter2view_NE_DepartmentadmTitleFilterData", AV32View_New_Encounter2view_NE_DepartmentadmTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28View_New_Encounter2view_NE_ENCTypeTitleFilterData", AV28View_New_Encounter2view_NE_ENCTypeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42View_New_Encounter2view_NE_StatusTitleFilterData", AV42View_New_Encounter2view_NE_StatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50View_New_Encounter2view_NE_IsRandApproveTitleFilterData", AV50View_New_Encounter2view_NE_IsRandApproveTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV46View_New_Encounter2view_NE_IsRandRecheckTitleFilterData", AV46View_New_Encounter2view_NE_IsRandRecheckTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV54View_New_Encounter2view_NE_IsUpdateTitleFilterData", AV54View_New_Encounter2view_NE_IsUpdateTitleFilterData);
      }

      protected void E27AL2( )
      {
         /* 'Dotest' Routine */
         subgrid_nextpage( ) ;
      }

      protected void E28AL2( )
      {
         /* 'Doadd' Routine */
         CallWebObject(formatLink("br_encounter.aspx") + "?" + UrlEncode(StringUtil.RTrim("INS")) + "," + UrlEncode("" +0));
         context.wjLocDisableFrm = 1;
      }

      protected void E29AL2( )
      {
         /* View_New_Encounter2view_NE_EncounterID_Click Routine */
         if ( (0==AV100view_NE_Status) )
         {
            AV19Session.Set("BR_Encounter_Status", "9");
         }
         else
         {
            AV19Session.Set("BR_Encounter_Status", StringUtil.Str( (decimal)(AV100view_NE_Status), 4, 0));
         }
         AV95websession.Set("Br_EncounterReturnPage", "br_encounter");
         AV95websession.Remove("Permisstion_Update");
         if ( AV87IsInsert )
         {
            if ( A595View_New_Encounter2view_NE_Status == 1 )
            {
               CallWebObject(formatLink("br_encounterupdate.aspx") + "?" + UrlEncode("" +A591View_New_Encounter2view_NE_EncounterID) + "," + UrlEncode(StringUtil.RTrim("BR_Encounter")));
               context.wjLocDisableFrm = 1;
            }
            else
            {
               CallWebObject(formatLink("br_encountercheck.aspx") + "?" + UrlEncode("" +A591View_New_Encounter2view_NE_EncounterID) + "," + UrlEncode(StringUtil.RTrim("General")));
               context.wjLocDisableFrm = 1;
            }
         }
         else
         {
            CallWebObject(formatLink("br_encountercheck.aspx") + "?" + UrlEncode("" +A591View_New_Encounter2view_NE_EncounterID) + "," + UrlEncode(StringUtil.RTrim("General")));
            context.wjLocDisableFrm = 1;
         }
         /*  Sending Event outputs  */
      }

      protected void wb_table4_128_AL2( bool wbgen )
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
            wb_table4_128_AL2e( true) ;
         }
         else
         {
            wb_table4_128_AL2e( false) ;
         }
      }

      protected void wb_table3_123_AL2( bool wbgen )
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
            wb_table3_123_AL2e( true) ;
         }
         else
         {
            wb_table3_123_AL2e( false) ;
         }
      }

      protected void wb_table2_118_AL2( bool wbgen )
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
            wb_table2_118_AL2e( true) ;
         }
         else
         {
            wb_table2_118_AL2e( false) ;
         }
      }

      protected void wb_table1_63_AL2( bool wbgen )
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 68,'',false,'',0)\"";
            ClassString = "ButtonColor";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnbatchapprove_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(76), 2, 0)+","+"null"+");", "全部通过初审", bttBtnbatchapprove_Jsonclick, 7, "全部通过初审", "", StyleString, ClassString, bttBtnbatchapprove_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"e30al1_client"+"'", TempTags, "", 2, "HLP_BR_EncounterListww.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 70,'',false,'',0)\"";
            ClassString = "ButtonColor";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtnbatchrecheck_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(76), 2, 0)+","+"null"+");", "全部通过复审", bttBtnbatchrecheck_Jsonclick, 7, "全部通过复审", "", StyleString, ClassString, bttBtnbatchrecheck_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"e31al1_client"+"'", TempTags, "", 2, "HLP_BR_EncounterListww.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_63_AL2e( true) ;
         }
         else
         {
            wb_table1_63_AL2e( false) ;
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
         PAAL2( ) ;
         WSAL2( ) ;
         WEAL2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202022815174336", true);
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
         context.AddJavascriptSource("br_encounterlistww.js", "?202022815174336", false);
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
         context.AddJavascriptSource("DVelop/WorkWithPlusUtilities/WorkWithPlusUtilitiesRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/ConfirmPanel/BootstrapConfirmPanelRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/ConfirmPanel/BootstrapConfirmPanelRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/ConfirmPanel/BootstrapConfirmPanelRender.js", "", false);
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_762( )
      {
         edtavDeleteencounter_Internalname = "vDELETEENCOUNTER_"+sGXsfl_76_idx;
         edtView_New_Encounter2view_NE_EncounterID_Internalname = "VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID_"+sGXsfl_76_idx;
         edtView_New_Encounter2view_NE_Information_PatientNo_Internalname = "VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO_"+sGXsfl_76_idx;
         edtavPatientno_Internalname = "vPATIENTNO_"+sGXsfl_76_idx;
         edtView_New_Encounter2view_NE_Departmentadm_Internalname = "VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM_"+sGXsfl_76_idx;
         edtView_New_Encounter2view_NE_ENCType_Internalname = "VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE_"+sGXsfl_76_idx;
         edtavAdmitdate_Internalname = "vADMITDATE_"+sGXsfl_76_idx;
         edtView_New_Encounter2view_NE_AdmitDate_Internalname = "VIEW_NEW_ENCOUNTER2VIEW_NE_ADMITDATE_"+sGXsfl_76_idx;
         cmbView_New_Encounter2view_NE_Status_Internalname = "VIEW_NEW_ENCOUNTER2VIEW_NE_STATUS_"+sGXsfl_76_idx;
         chkView_New_Encounter2view_NE_IsRandApprove_Internalname = "VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE_"+sGXsfl_76_idx;
         chkView_New_Encounter2view_NE_IsRandRecheck_Internalname = "VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK_"+sGXsfl_76_idx;
         chkView_New_Encounter2view_NE_IsUpdate_Internalname = "VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE_"+sGXsfl_76_idx;
         edtView_New_Encounter2view_NE_TenantTenantCode_Internalname = "VIEW_NEW_ENCOUNTER2VIEW_NE_TENANTTENANTCODE_"+sGXsfl_76_idx;
         edtView_New_Encounter2view_NE_Information_ID_Internalname = "VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_ID_"+sGXsfl_76_idx;
      }

      protected void SubsflControlProps_fel_762( )
      {
         edtavDeleteencounter_Internalname = "vDELETEENCOUNTER_"+sGXsfl_76_fel_idx;
         edtView_New_Encounter2view_NE_EncounterID_Internalname = "VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID_"+sGXsfl_76_fel_idx;
         edtView_New_Encounter2view_NE_Information_PatientNo_Internalname = "VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO_"+sGXsfl_76_fel_idx;
         edtavPatientno_Internalname = "vPATIENTNO_"+sGXsfl_76_fel_idx;
         edtView_New_Encounter2view_NE_Departmentadm_Internalname = "VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM_"+sGXsfl_76_fel_idx;
         edtView_New_Encounter2view_NE_ENCType_Internalname = "VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE_"+sGXsfl_76_fel_idx;
         edtavAdmitdate_Internalname = "vADMITDATE_"+sGXsfl_76_fel_idx;
         edtView_New_Encounter2view_NE_AdmitDate_Internalname = "VIEW_NEW_ENCOUNTER2VIEW_NE_ADMITDATE_"+sGXsfl_76_fel_idx;
         cmbView_New_Encounter2view_NE_Status_Internalname = "VIEW_NEW_ENCOUNTER2VIEW_NE_STATUS_"+sGXsfl_76_fel_idx;
         chkView_New_Encounter2view_NE_IsRandApprove_Internalname = "VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE_"+sGXsfl_76_fel_idx;
         chkView_New_Encounter2view_NE_IsRandRecheck_Internalname = "VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK_"+sGXsfl_76_fel_idx;
         chkView_New_Encounter2view_NE_IsUpdate_Internalname = "VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE_"+sGXsfl_76_fel_idx;
         edtView_New_Encounter2view_NE_TenantTenantCode_Internalname = "VIEW_NEW_ENCOUNTER2VIEW_NE_TENANTTENANTCODE_"+sGXsfl_76_fel_idx;
         edtView_New_Encounter2view_NE_Information_ID_Internalname = "VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_ID_"+sGXsfl_76_fel_idx;
      }

      protected void sendrow_762( )
      {
         SubsflControlProps_762( ) ;
         WBAL0( ) ;
         if ( ( subGrid_Rows * 1 == 0 ) || ( nGXsfl_76_idx <= subGrid_Recordsperpage( ) * 1 ) )
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
               if ( ((int)(((nGXsfl_76_idx-1)/ (decimal)(1)) % (2))) == 0 )
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
               context.WriteHtmlText( " class=\""+"GridWithPaginationBar GridWithBorderColor WorkWith"+"\" style=\""+""+"\"") ;
               context.WriteHtmlText( " gxrow=\""+sGXsfl_76_idx+"\">") ;
            }
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((edtavDeleteencounter_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Active Bitmap Variable */
            TempTags = " " + ((edtavDeleteencounter_Enabled!=0)&&(edtavDeleteencounter_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 77,'',false,'',76)\"" : " ");
            ClassString = "ActionBaseColorAttribute";
            StyleString = "";
            AV80deleteEncounter_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV80deleteEncounter))&&String.IsNullOrEmpty(StringUtil.RTrim( AV129Deleteencounter_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV80deleteEncounter)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV80deleteEncounter)) ? AV129Deleteencounter_GXI : context.PathToRelativeUrl( AV80deleteEncounter));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavDeleteencounter_Internalname,(String)sImgUrl,(String)"",(String)"",(String)"",context.GetTheme( ),(int)edtavDeleteencounter_Visible,(short)1,(String)"",(String)edtavDeleteencounter_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)7,(String)edtavDeleteencounter_Jsonclick,(String)"'"+""+"'"+",false,"+"'"+"e32al2_client"+"'",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)""+TempTags,(String)"",(String)"",(short)1,(bool)AV80deleteEncounter_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtView_New_Encounter2view_NE_EncounterID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A591View_New_Encounter2view_NE_EncounterID), 18, 0, ".", "")),context.localUtil.Format( (decimal)(A591View_New_Encounter2view_NE_EncounterID), "ZZZZZZZZZZZZZZZZZ9"),(String)"","'"+""+"'"+",false,"+"'"+"EVIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID.CLICK."+sGXsfl_76_idx+"'",(String)"",(String)"",(String)"",(String)"",(String)edtView_New_Encounter2view_NE_EncounterID_Jsonclick,(short)5,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)76,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtView_New_Encounter2view_NE_Information_PatientNo_Internalname,(String)A601View_New_Encounter2view_NE_Information_PatientNo,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+"e33al2_client"+"'",(String)"",(String)"",(String)"",(String)"",(String)edtView_New_Encounter2view_NE_Information_PatientNo_Jsonclick,(short)7,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)4000,(short)0,(short)0,(short)76,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            TempTags = " " + ((edtavPatientno_Enabled!=0)&&(edtavPatientno_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 80,'',false,'"+sGXsfl_76_idx+"',76)\"" : " ");
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavPatientno_Internalname,(String)AV78PatientNo,(String)"",TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+((edtavPatientno_Enabled!=0)&&(edtavPatientno_Visible!=0) ? " onblur=\""+";gx.evt.onblur(this,80);\"" : " "),(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtavPatientno_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)0,(int)edtavPatientno_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)4000,(short)0,(short)0,(short)76,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtView_New_Encounter2view_NE_Departmentadm_Internalname,(String)A593View_New_Encounter2view_NE_Departmentadm,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtView_New_Encounter2view_NE_Departmentadm_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)76,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtView_New_Encounter2view_NE_ENCType_Internalname,(String)A592View_New_Encounter2view_NE_ENCType,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtView_New_Encounter2view_NE_ENCType_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)4000,(short)0,(short)0,(short)76,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            TempTags = " " + ((edtavAdmitdate_Enabled!=0)&&(edtavAdmitdate_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 83,'',false,'"+sGXsfl_76_idx+"',76)\"" : " ");
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavAdmitdate_Internalname,context.localUtil.Format(AV79AdmitDate, "9999/99/99"),context.localUtil.Format( AV79AdmitDate, "9999/99/99"),TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',0,24,'chs',false,1);"+";gx.evt.onchange(this, event)\" "+((edtavAdmitdate_Enabled!=0)&&(edtavAdmitdate_Visible!=0) ? " onblur=\""+";gx.evt.onblur(this,83);\"" : " "),(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtavAdmitdate_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(int)edtavAdmitdate_Enabled,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)76,(short)1,(short)-1,(short)0,(bool)true,(String)"DM_Date",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtView_New_Encounter2view_NE_AdmitDate_Internalname,context.localUtil.Format(A594View_New_Encounter2view_NE_AdmitDate, "9999/99/99"),context.localUtil.Format( A594View_New_Encounter2view_NE_AdmitDate, "9999/99/99"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtView_New_Encounter2view_NE_AdmitDate_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)0,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)76,(short)1,(short)-1,(short)0,(bool)true,(String)"DM_Date",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            if ( ( cmbView_New_Encounter2view_NE_Status.ItemCount == 0 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "VIEW_NEW_ENCOUNTER2VIEW_NE_STATUS_" + sGXsfl_76_idx;
               cmbView_New_Encounter2view_NE_Status.Name = GXCCtl;
               cmbView_New_Encounter2view_NE_Status.WebTags = "";
               cmbView_New_Encounter2view_NE_Status.addItem(StringUtil.Trim( StringUtil.Str( (decimal)(0), 4, 0)), "(请选择)", 0);
               cmbView_New_Encounter2view_NE_Status.addItem("1", "录入中", 0);
               cmbView_New_Encounter2view_NE_Status.addItem("2", "待初审", 0);
               cmbView_New_Encounter2view_NE_Status.addItem("3", "初审不通过", 0);
               cmbView_New_Encounter2view_NE_Status.addItem("4", "待复审", 0);
               cmbView_New_Encounter2view_NE_Status.addItem("5", "复审不通过", 0);
               cmbView_New_Encounter2view_NE_Status.addItem("6", "完成", 0);
               if ( cmbView_New_Encounter2view_NE_Status.ItemCount > 0 )
               {
                  A595View_New_Encounter2view_NE_Status = (short)(NumberUtil.Val( cmbView_New_Encounter2view_NE_Status.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A595View_New_Encounter2view_NE_Status), 4, 0))), "."));
                  n595View_New_Encounter2view_NE_Status = false;
               }
            }
            /* ComboBox */
            GridRow.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbView_New_Encounter2view_NE_Status,(String)cmbView_New_Encounter2view_NE_Status_Internalname,StringUtil.Trim( StringUtil.Str( (decimal)(A595View_New_Encounter2view_NE_Status), 4, 0)),(short)1,(String)cmbView_New_Encounter2view_NE_Status_Jsonclick,(short)0,(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"int",(String)"",(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)"",(String)"Attribute",(String)"WWColumn hidden-xs",(String)"",(String)"",(String)"",(bool)true});
            cmbView_New_Encounter2view_NE_Status.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A595View_New_Encounter2view_NE_Status), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbView_New_Encounter2view_NE_Status_Internalname, "Values", (String)(cmbView_New_Encounter2view_NE_Status.ToJavascriptSource()), !bGXsfl_76_Refreshing);
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Check box */
            ClassString = "AttributeCheckBox";
            StyleString = "";
            GridRow.AddColumnProperties("checkbox", 1, isAjaxCallMode( ), new Object[] {(String)chkView_New_Encounter2view_NE_IsRandApprove_Internalname,StringUtil.BoolToStr( A597View_New_Encounter2view_NE_IsRandApprove),(String)"",(String)"",(short)-1,(short)0,(String)"true",(String)"",(String)StyleString,(String)ClassString,(String)"WWColumn hidden-xs",(String)"",(String)""});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Check box */
            ClassString = "AttributeCheckBox";
            StyleString = "";
            GridRow.AddColumnProperties("checkbox", 1, isAjaxCallMode( ), new Object[] {(String)chkView_New_Encounter2view_NE_IsRandRecheck_Internalname,StringUtil.BoolToStr( A596View_New_Encounter2view_NE_IsRandRecheck),(String)"",(String)"",(short)-1,(short)0,(String)"true",(String)"",(String)StyleString,(String)ClassString,(String)"WWColumn hidden-xs",(String)"",(String)""});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Check box */
            ClassString = "AttributeCheckBox";
            StyleString = "";
            GridRow.AddColumnProperties("checkbox", 1, isAjaxCallMode( ), new Object[] {(String)chkView_New_Encounter2view_NE_IsUpdate_Internalname,StringUtil.BoolToStr( A598View_New_Encounter2view_NE_IsUpdate),(String)"",(String)"",(short)-1,(short)0,(String)"true",(String)"",(String)StyleString,(String)ClassString,(String)"WWColumn hidden-xs",(String)"",(String)""});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtView_New_Encounter2view_NE_TenantTenantCode_Internalname,(String)A599View_New_Encounter2view_NE_TenantTenantCode,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtView_New_Encounter2view_NE_TenantTenantCode_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)0,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)20,(short)0,(short)0,(short)76,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtView_New_Encounter2view_NE_Information_ID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A600View_New_Encounter2view_NE_Information_ID), 18, 0, ".", "")),context.localUtil.Format( (decimal)(A600View_New_Encounter2view_NE_Information_ID), "ZZZZZZZZZZZZZZZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtView_New_Encounter2view_NE_Information_ID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)0,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)76,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            send_integrity_lvl_hashesAL2( ) ;
            GridContainer.AddRow(GridRow);
            nGXsfl_76_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_76_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_76_idx+1));
            sGXsfl_76_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_76_idx), 4, 0)), 4, "0");
            SubsflControlProps_762( ) ;
         }
         /* End function sendrow_762 */
      }

      protected void init_web_controls( )
      {
         cmbavTview_ne_status.Name = "vTVIEW_NE_STATUS";
         cmbavTview_ne_status.WebTags = "";
         cmbavTview_ne_status.addItem(StringUtil.Trim( StringUtil.Str( (decimal)(0), 4, 0)), "全部", 0);
         cmbavTview_ne_status.addItem("1", "录入中", 0);
         cmbavTview_ne_status.addItem("2", "待初审", 0);
         cmbavTview_ne_status.addItem("3", "初审不通过", 0);
         cmbavTview_ne_status.addItem("4", "待复审", 0);
         cmbavTview_ne_status.addItem("5", "复审不通过", 0);
         cmbavTview_ne_status.addItem("6", "完成", 0);
         if ( cmbavTview_ne_status.ItemCount > 0 )
         {
            AV23tview_NE_Status = (short)(NumberUtil.Val( cmbavTview_ne_status.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV23tview_NE_Status), 4, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23tview_NE_Status", StringUtil.LTrim( StringUtil.Str( (decimal)(AV23tview_NE_Status), 4, 0)));
         }
         chkavView_new_encounter2view_ne_israndapprove.Name = "vVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE";
         chkavView_new_encounter2view_ne_israndapprove.WebTags = "";
         chkavView_new_encounter2view_ne_israndapprove.Caption = "";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavView_new_encounter2view_ne_israndapprove_Internalname, "TitleCaption", chkavView_new_encounter2view_ne_israndapprove.Caption, true);
         chkavView_new_encounter2view_ne_israndapprove.CheckedValue = "false";
         chkavView_new_encounter2view_ne_israndrecheck.Name = "vVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK";
         chkavView_new_encounter2view_ne_israndrecheck.WebTags = "";
         chkavView_new_encounter2view_ne_israndrecheck.Caption = "";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavView_new_encounter2view_ne_israndrecheck_Internalname, "TitleCaption", chkavView_new_encounter2view_ne_israndrecheck.Caption, true);
         chkavView_new_encounter2view_ne_israndrecheck.CheckedValue = "false";
         chkavView_new_encounter2view_ne_isupdate.Name = "vVIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE";
         chkavView_new_encounter2view_ne_isupdate.WebTags = "";
         chkavView_new_encounter2view_ne_isupdate.Caption = "";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavView_new_encounter2view_ne_isupdate_Internalname, "TitleCaption", chkavView_new_encounter2view_ne_isupdate.Caption, true);
         chkavView_new_encounter2view_ne_isupdate.CheckedValue = "false";
         GXCCtl = "VIEW_NEW_ENCOUNTER2VIEW_NE_STATUS_" + sGXsfl_76_idx;
         cmbView_New_Encounter2view_NE_Status.Name = GXCCtl;
         cmbView_New_Encounter2view_NE_Status.WebTags = "";
         cmbView_New_Encounter2view_NE_Status.addItem(StringUtil.Trim( StringUtil.Str( (decimal)(0), 4, 0)), "(请选择)", 0);
         cmbView_New_Encounter2view_NE_Status.addItem("1", "录入中", 0);
         cmbView_New_Encounter2view_NE_Status.addItem("2", "待初审", 0);
         cmbView_New_Encounter2view_NE_Status.addItem("3", "初审不通过", 0);
         cmbView_New_Encounter2view_NE_Status.addItem("4", "待复审", 0);
         cmbView_New_Encounter2view_NE_Status.addItem("5", "复审不通过", 0);
         cmbView_New_Encounter2view_NE_Status.addItem("6", "完成", 0);
         if ( cmbView_New_Encounter2view_NE_Status.ItemCount > 0 )
         {
            A595View_New_Encounter2view_NE_Status = (short)(NumberUtil.Val( cmbView_New_Encounter2view_NE_Status.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A595View_New_Encounter2view_NE_Status), 4, 0))), "."));
            n595View_New_Encounter2view_NE_Status = false;
         }
         GXCCtl = "VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE_" + sGXsfl_76_idx;
         chkView_New_Encounter2view_NE_IsRandApprove.Name = GXCCtl;
         chkView_New_Encounter2view_NE_IsRandApprove.WebTags = "";
         chkView_New_Encounter2view_NE_IsRandApprove.Caption = "";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkView_New_Encounter2view_NE_IsRandApprove_Internalname, "TitleCaption", chkView_New_Encounter2view_NE_IsRandApprove.Caption, !bGXsfl_76_Refreshing);
         chkView_New_Encounter2view_NE_IsRandApprove.CheckedValue = "false";
         GXCCtl = "VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK_" + sGXsfl_76_idx;
         chkView_New_Encounter2view_NE_IsRandRecheck.Name = GXCCtl;
         chkView_New_Encounter2view_NE_IsRandRecheck.WebTags = "";
         chkView_New_Encounter2view_NE_IsRandRecheck.Caption = "";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkView_New_Encounter2view_NE_IsRandRecheck_Internalname, "TitleCaption", chkView_New_Encounter2view_NE_IsRandRecheck.Caption, !bGXsfl_76_Refreshing);
         chkView_New_Encounter2view_NE_IsRandRecheck.CheckedValue = "false";
         GXCCtl = "VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE_" + sGXsfl_76_idx;
         chkView_New_Encounter2view_NE_IsUpdate.Name = GXCCtl;
         chkView_New_Encounter2view_NE_IsUpdate.WebTags = "";
         chkView_New_Encounter2view_NE_IsUpdate.Caption = "";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkView_New_Encounter2view_NE_IsUpdate_Internalname, "TitleCaption", chkView_New_Encounter2view_NE_IsUpdate.Caption, !bGXsfl_76_Refreshing);
         chkView_New_Encounter2view_NE_IsUpdate.CheckedValue = "false";
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         edtavBr_information_patientno_Internalname = "vBR_INFORMATION_PATIENTNO";
         edtavSbr_encounterid_Internalname = "vSBR_ENCOUNTERID";
         edtavView_ne_admitdate_Internalname = "vVIEW_NE_ADMITDATE";
         edtavEndview_ne_admitdate_Internalname = "vENDVIEW_NE_ADMITDATE";
         cmbavTview_ne_status_Internalname = "vTVIEW_NE_STATUS";
         chkavView_new_encounter2view_ne_israndapprove_Internalname = "vVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE";
         chkavView_new_encounter2view_ne_israndrecheck_Internalname = "vVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK";
         chkavView_new_encounter2view_ne_isupdate_Internalname = "vVIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE";
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
         edtView_New_Encounter2view_NE_EncounterID_Internalname = "VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID";
         edtView_New_Encounter2view_NE_Information_PatientNo_Internalname = "VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO";
         edtavPatientno_Internalname = "vPATIENTNO";
         edtView_New_Encounter2view_NE_Departmentadm_Internalname = "VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM";
         edtView_New_Encounter2view_NE_ENCType_Internalname = "VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE";
         edtavAdmitdate_Internalname = "vADMITDATE";
         edtView_New_Encounter2view_NE_AdmitDate_Internalname = "VIEW_NEW_ENCOUNTER2VIEW_NE_ADMITDATE";
         cmbView_New_Encounter2view_NE_Status_Internalname = "VIEW_NEW_ENCOUNTER2VIEW_NE_STATUS";
         chkView_New_Encounter2view_NE_IsRandApprove_Internalname = "VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE";
         chkView_New_Encounter2view_NE_IsRandRecheck_Internalname = "VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK";
         chkView_New_Encounter2view_NE_IsUpdate_Internalname = "VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE";
         edtView_New_Encounter2view_NE_TenantTenantCode_Internalname = "VIEW_NEW_ENCOUNTER2VIEW_NE_TENANTTENANTCODE";
         edtView_New_Encounter2view_NE_Information_ID_Internalname = "VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_ID";
         Gridpaginationbar_Internalname = "GRIDPAGINATIONBAR";
         divHtml_gridpaginationbar_Internalname = "HTML_GRIDPAGINATIONBAR";
         divGridtablewithpaginationbar_Internalname = "GRIDTABLEWITHPAGINATIONBAR";
         divTablemain_Internalname = "TABLEMAIN";
         Ddo_view_new_encounter2view_ne_encounterid_Internalname = "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID";
         edtavDdo_view_new_encounter2view_ne_encounteridtitlecontrolidtoreplace_Internalname = "vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERIDTITLECONTROLIDTOREPLACE";
         Ddo_view_new_encounter2view_ne_information_patientno_Internalname = "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO";
         edtavDdo_view_new_encounter2view_ne_information_patientnotitlecontrolidtoreplace_Internalname = "vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE";
         Ddo_view_new_encounter2view_ne_departmentadm_Internalname = "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM";
         edtavDdo_view_new_encounter2view_ne_departmentadmtitlecontrolidtoreplace_Internalname = "vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADMTITLECONTROLIDTOREPLACE";
         Ddo_view_new_encounter2view_ne_enctype_Internalname = "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE";
         edtavDdo_view_new_encounter2view_ne_enctypetitlecontrolidtoreplace_Internalname = "vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPETITLECONTROLIDTOREPLACE";
         Ddo_view_new_encounter2view_ne_status_Internalname = "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_STATUS";
         edtavDdo_view_new_encounter2view_ne_statustitlecontrolidtoreplace_Internalname = "vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_STATUSTITLECONTROLIDTOREPLACE";
         Ddo_view_new_encounter2view_ne_israndapprove_Internalname = "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE";
         edtavDdo_view_new_encounter2view_ne_israndapprovetitlecontrolidtoreplace_Internalname = "vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVETITLECONTROLIDTOREPLACE";
         Ddo_view_new_encounter2view_ne_israndrecheck_Internalname = "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK";
         edtavDdo_view_new_encounter2view_ne_israndrechecktitlecontrolidtoreplace_Internalname = "vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECKTITLECONTROLIDTOREPLACE";
         Ddo_view_new_encounter2view_ne_isupdate_Internalname = "DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE";
         edtavDdo_view_new_encounter2view_ne_isupdatetitlecontrolidtoreplace_Internalname = "vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATETITLECONTROLIDTOREPLACE";
         Workwithplusutilities1_Internalname = "WORKWITHPLUSUTILITIES1";
         edtavView_new_encounter2view_ne_encounterid_selected_Internalname = "vVIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID_SELECTED";
         edtavOrderedby_Internalname = "vORDEREDBY";
         edtavOrdereddsc_Internalname = "vORDEREDDSC";
         Dvelop_confirmpanel_deleteencounter_Internalname = "DVELOP_CONFIRMPANEL_DELETEENCOUNTER";
         tblTabledvelop_confirmpanel_deleteencounter_Internalname = "TABLEDVELOP_CONFIRMPANEL_DELETEENCOUNTER";
         Dvelop_confirmpanel_batchapprove_Internalname = "DVELOP_CONFIRMPANEL_BATCHAPPROVE";
         tblTabledvelop_confirmpanel_batchapprove_Internalname = "TABLEDVELOP_CONFIRMPANEL_BATCHAPPROVE";
         Dvelop_confirmpanel_batchrecheck_Internalname = "DVELOP_CONFIRMPANEL_BATCHRECHECK";
         tblTabledvelop_confirmpanel_batchrecheck_Internalname = "TABLEDVELOP_CONFIRMPANEL_BATCHRECHECK";
         edtavTfview_new_encounter2view_ne_encounterid_Internalname = "vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID";
         edtavTfview_new_encounter2view_ne_encounterid_to_Internalname = "vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID_TO";
         edtavTfview_new_encounter2view_ne_information_patientno_Internalname = "vTFVIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO";
         edtavTfview_new_encounter2view_ne_information_patientno_sel_Internalname = "vTFVIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO_SEL";
         edtavTfview_new_encounter2view_ne_departmentadm_Internalname = "vTFVIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM";
         edtavTfview_new_encounter2view_ne_departmentadm_sel_Internalname = "vTFVIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM_SEL";
         edtavTfview_new_encounter2view_ne_enctype_Internalname = "vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE";
         edtavTfview_new_encounter2view_ne_enctype_sel_Internalname = "vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE_SEL";
         edtavTfview_new_encounter2view_ne_israndapprove_sel_Internalname = "vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE_SEL";
         edtavTfview_new_encounter2view_ne_israndrecheck_sel_Internalname = "vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK_SEL";
         edtavTfview_new_encounter2view_ne_isupdate_sel_Internalname = "vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE_SEL";
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
         chkView_New_Encounter2view_NE_IsUpdate.Caption = "";
         chkView_New_Encounter2view_NE_IsRandRecheck.Caption = "";
         chkView_New_Encounter2view_NE_IsRandApprove.Caption = "";
         chkavView_new_encounter2view_ne_isupdate.Caption = "是否修改";
         chkavView_new_encounter2view_ne_israndrecheck.Caption = "是否复审抽查";
         chkavView_new_encounter2view_ne_israndapprove.Caption = "是否初审抽查";
         edtView_New_Encounter2view_NE_Information_ID_Jsonclick = "";
         edtView_New_Encounter2view_NE_TenantTenantCode_Jsonclick = "";
         cmbView_New_Encounter2view_NE_Status_Jsonclick = "";
         edtView_New_Encounter2view_NE_AdmitDate_Jsonclick = "";
         edtavAdmitdate_Jsonclick = "";
         edtavAdmitdate_Visible = -1;
         edtView_New_Encounter2view_NE_ENCType_Jsonclick = "";
         edtView_New_Encounter2view_NE_Departmentadm_Jsonclick = "";
         edtavPatientno_Jsonclick = "";
         edtavPatientno_Visible = 0;
         edtView_New_Encounter2view_NE_Information_PatientNo_Jsonclick = "";
         edtView_New_Encounter2view_NE_EncounterID_Jsonclick = "";
         edtavDeleteencounter_Jsonclick = "";
         edtavDeleteencounter_Enabled = 1;
         bttBtnbatchrecheck_Visible = 1;
         bttBtnbatchapprove_Visible = 1;
         edtavTfview_new_encounter2view_ne_isupdate_sel_Jsonclick = "";
         edtavTfview_new_encounter2view_ne_isupdate_sel_Visible = 1;
         edtavTfview_new_encounter2view_ne_israndrecheck_sel_Jsonclick = "";
         edtavTfview_new_encounter2view_ne_israndrecheck_sel_Visible = 1;
         edtavTfview_new_encounter2view_ne_israndapprove_sel_Jsonclick = "";
         edtavTfview_new_encounter2view_ne_israndapprove_sel_Visible = 1;
         edtavTfview_new_encounter2view_ne_enctype_sel_Visible = 1;
         edtavTfview_new_encounter2view_ne_enctype_Visible = 1;
         edtavTfview_new_encounter2view_ne_departmentadm_sel_Jsonclick = "";
         edtavTfview_new_encounter2view_ne_departmentadm_sel_Visible = 1;
         edtavTfview_new_encounter2view_ne_departmentadm_Jsonclick = "";
         edtavTfview_new_encounter2view_ne_departmentadm_Visible = 1;
         edtavTfview_new_encounter2view_ne_information_patientno_sel_Visible = 1;
         edtavTfview_new_encounter2view_ne_information_patientno_Visible = 1;
         edtavTfview_new_encounter2view_ne_encounterid_to_Jsonclick = "";
         edtavTfview_new_encounter2view_ne_encounterid_to_Visible = 1;
         edtavTfview_new_encounter2view_ne_encounterid_Jsonclick = "";
         edtavTfview_new_encounter2view_ne_encounterid_Visible = 1;
         edtavOrdereddsc_Jsonclick = "";
         edtavOrdereddsc_Visible = 1;
         edtavOrderedby_Jsonclick = "";
         edtavOrderedby_Visible = 1;
         edtavView_new_encounter2view_ne_encounterid_selected_Jsonclick = "";
         edtavView_new_encounter2view_ne_encounterid_selected_Visible = 1;
         edtavDdo_view_new_encounter2view_ne_isupdatetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_view_new_encounter2view_ne_israndrechecktitlecontrolidtoreplace_Visible = 1;
         edtavDdo_view_new_encounter2view_ne_israndapprovetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_view_new_encounter2view_ne_statustitlecontrolidtoreplace_Visible = 1;
         edtavDdo_view_new_encounter2view_ne_enctypetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_view_new_encounter2view_ne_departmentadmtitlecontrolidtoreplace_Visible = 1;
         edtavDdo_view_new_encounter2view_ne_information_patientnotitlecontrolidtoreplace_Visible = 1;
         edtavDdo_view_new_encounter2view_ne_encounteridtitlecontrolidtoreplace_Visible = 1;
         subGrid_Allowcollapsing = 0;
         subGrid_Allowselection = 0;
         edtavDeleteencounter_Tooltiptext = "";
         subGrid_Sortable = 0;
         subGrid_Header = "";
         chkView_New_Encounter2view_NE_IsUpdate_Titleformat = 0;
         chkView_New_Encounter2view_NE_IsUpdate.Title.Text = "是否修改";
         chkView_New_Encounter2view_NE_IsRandRecheck_Titleformat = 0;
         chkView_New_Encounter2view_NE_IsRandRecheck.Title.Text = "复审抽查";
         chkView_New_Encounter2view_NE_IsRandApprove_Titleformat = 0;
         chkView_New_Encounter2view_NE_IsRandApprove.Title.Text = "初审抽查";
         cmbView_New_Encounter2view_NE_Status_Titleformat = 0;
         cmbView_New_Encounter2view_NE_Status.Title.Text = "审批状态";
         edtavAdmitdate_Enabled = 1;
         edtView_New_Encounter2view_NE_ENCType_Titleformat = 0;
         edtView_New_Encounter2view_NE_ENCType_Title = "就诊方式";
         edtView_New_Encounter2view_NE_Departmentadm_Titleformat = 0;
         edtView_New_Encounter2view_NE_Departmentadm_Title = "入院科室";
         edtavPatientno_Enabled = 1;
         edtView_New_Encounter2view_NE_Information_PatientNo_Titleformat = 0;
         edtView_New_Encounter2view_NE_Information_PatientNo_Title = "患者编号";
         edtView_New_Encounter2view_NE_EncounterID_Titleformat = 0;
         edtView_New_Encounter2view_NE_EncounterID_Title = "就诊序号";
         edtavDeleteencounter_Visible = -1;
         subGrid_Class = "GridWithPaginationBar GridWithBorderColor WorkWith";
         subGrid_Backcolorstyle = 0;
         chkavView_new_encounter2view_ne_isupdate.Enabled = 1;
         chkavView_new_encounter2view_ne_israndrecheck.Enabled = 1;
         chkavView_new_encounter2view_ne_israndapprove.Enabled = 1;
         cmbavTview_ne_status_Jsonclick = "";
         cmbavTview_ne_status.Enabled = 1;
         edtavEndview_ne_admitdate_Jsonclick = "";
         edtavEndview_ne_admitdate_Enabled = 1;
         edtavView_ne_admitdate_Jsonclick = "";
         edtavView_ne_admitdate_Enabled = 1;
         edtavSbr_encounterid_Jsonclick = "";
         edtavSbr_encounterid_Enabled = 1;
         edtavBr_information_patientno_Jsonclick = "";
         edtavBr_information_patientno_Enabled = 1;
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
         Ddo_view_new_encounter2view_ne_isupdate_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_view_new_encounter2view_ne_isupdate_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_view_new_encounter2view_ne_isupdate_Sortdsc = "WWP_TSSortDSC";
         Ddo_view_new_encounter2view_ne_isupdate_Sortasc = "WWP_TSSortASC";
         Ddo_view_new_encounter2view_ne_isupdate_Datalistfixedvalues = "1:WWP_TSChecked,2:WWP_TSUnChecked";
         Ddo_view_new_encounter2view_ne_isupdate_Datalisttype = "FixedValues";
         Ddo_view_new_encounter2view_ne_isupdate_Includedatalist = Convert.ToBoolean( -1);
         Ddo_view_new_encounter2view_ne_isupdate_Includefilter = Convert.ToBoolean( 0);
         Ddo_view_new_encounter2view_ne_isupdate_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_view_new_encounter2view_ne_isupdate_Includesortasc = Convert.ToBoolean( -1);
         Ddo_view_new_encounter2view_ne_isupdate_Titlecontrolidtoreplace = "";
         Ddo_view_new_encounter2view_ne_isupdate_Dropdownoptionstype = "GridTitleSettings";
         Ddo_view_new_encounter2view_ne_isupdate_Cls = "ColumnSettings";
         Ddo_view_new_encounter2view_ne_isupdate_Tooltip = "WWP_TSColumnOptions";
         Ddo_view_new_encounter2view_ne_isupdate_Caption = "";
         Ddo_view_new_encounter2view_ne_israndrecheck_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_view_new_encounter2view_ne_israndrecheck_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_view_new_encounter2view_ne_israndrecheck_Sortdsc = "WWP_TSSortDSC";
         Ddo_view_new_encounter2view_ne_israndrecheck_Sortasc = "WWP_TSSortASC";
         Ddo_view_new_encounter2view_ne_israndrecheck_Datalistfixedvalues = "1:WWP_TSChecked,2:WWP_TSUnChecked";
         Ddo_view_new_encounter2view_ne_israndrecheck_Datalisttype = "FixedValues";
         Ddo_view_new_encounter2view_ne_israndrecheck_Includedatalist = Convert.ToBoolean( -1);
         Ddo_view_new_encounter2view_ne_israndrecheck_Includefilter = Convert.ToBoolean( 0);
         Ddo_view_new_encounter2view_ne_israndrecheck_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_view_new_encounter2view_ne_israndrecheck_Includesortasc = Convert.ToBoolean( -1);
         Ddo_view_new_encounter2view_ne_israndrecheck_Titlecontrolidtoreplace = "";
         Ddo_view_new_encounter2view_ne_israndrecheck_Dropdownoptionstype = "GridTitleSettings";
         Ddo_view_new_encounter2view_ne_israndrecheck_Cls = "ColumnSettings";
         Ddo_view_new_encounter2view_ne_israndrecheck_Tooltip = "WWP_TSColumnOptions";
         Ddo_view_new_encounter2view_ne_israndrecheck_Caption = "";
         Ddo_view_new_encounter2view_ne_israndapprove_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_view_new_encounter2view_ne_israndapprove_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_view_new_encounter2view_ne_israndapprove_Sortdsc = "WWP_TSSortDSC";
         Ddo_view_new_encounter2view_ne_israndapprove_Sortasc = "WWP_TSSortASC";
         Ddo_view_new_encounter2view_ne_israndapprove_Datalistfixedvalues = "1:WWP_TSChecked,2:WWP_TSUnChecked";
         Ddo_view_new_encounter2view_ne_israndapprove_Datalisttype = "FixedValues";
         Ddo_view_new_encounter2view_ne_israndapprove_Includedatalist = Convert.ToBoolean( -1);
         Ddo_view_new_encounter2view_ne_israndapprove_Includefilter = Convert.ToBoolean( 0);
         Ddo_view_new_encounter2view_ne_israndapprove_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_view_new_encounter2view_ne_israndapprove_Includesortasc = Convert.ToBoolean( -1);
         Ddo_view_new_encounter2view_ne_israndapprove_Titlecontrolidtoreplace = "";
         Ddo_view_new_encounter2view_ne_israndapprove_Dropdownoptionstype = "GridTitleSettings";
         Ddo_view_new_encounter2view_ne_israndapprove_Cls = "ColumnSettings";
         Ddo_view_new_encounter2view_ne_israndapprove_Tooltip = "WWP_TSColumnOptions";
         Ddo_view_new_encounter2view_ne_israndapprove_Caption = "";
         Ddo_view_new_encounter2view_ne_status_Searchbuttontext = "WWP_FilterSelected";
         Ddo_view_new_encounter2view_ne_status_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_view_new_encounter2view_ne_status_Sortdsc = "WWP_TSSortDSC";
         Ddo_view_new_encounter2view_ne_status_Sortasc = "WWP_TSSortASC";
         Ddo_view_new_encounter2view_ne_status_Datalistfixedvalues = "1:录入中,2:待初审,3:初审不通过,4:待复审,5:复审不通过,6:完成";
         Ddo_view_new_encounter2view_ne_status_Allowmultipleselection = Convert.ToBoolean( -1);
         Ddo_view_new_encounter2view_ne_status_Datalisttype = "FixedValues";
         Ddo_view_new_encounter2view_ne_status_Includedatalist = Convert.ToBoolean( -1);
         Ddo_view_new_encounter2view_ne_status_Includefilter = Convert.ToBoolean( 0);
         Ddo_view_new_encounter2view_ne_status_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_view_new_encounter2view_ne_status_Includesortasc = Convert.ToBoolean( -1);
         Ddo_view_new_encounter2view_ne_status_Titlecontrolidtoreplace = "";
         Ddo_view_new_encounter2view_ne_status_Dropdownoptionstype = "GridTitleSettings";
         Ddo_view_new_encounter2view_ne_status_Cls = "ColumnSettings";
         Ddo_view_new_encounter2view_ne_status_Tooltip = "WWP_TSColumnOptions";
         Ddo_view_new_encounter2view_ne_status_Caption = "";
         Ddo_view_new_encounter2view_ne_enctype_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_view_new_encounter2view_ne_enctype_Noresultsfound = "WWP_TSNoResults";
         Ddo_view_new_encounter2view_ne_enctype_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_view_new_encounter2view_ne_enctype_Loadingdata = "WWP_TSLoading";
         Ddo_view_new_encounter2view_ne_enctype_Sortdsc = "WWP_TSSortDSC";
         Ddo_view_new_encounter2view_ne_enctype_Sortasc = "WWP_TSSortASC";
         Ddo_view_new_encounter2view_ne_enctype_Datalistupdateminimumcharacters = 0;
         Ddo_view_new_encounter2view_ne_enctype_Datalistproc = "BR_EncounterListwwGetFilterData";
         Ddo_view_new_encounter2view_ne_enctype_Datalisttype = "Dynamic";
         Ddo_view_new_encounter2view_ne_enctype_Includedatalist = Convert.ToBoolean( -1);
         Ddo_view_new_encounter2view_ne_enctype_Filterisrange = Convert.ToBoolean( 0);
         Ddo_view_new_encounter2view_ne_enctype_Filtertype = "Character";
         Ddo_view_new_encounter2view_ne_enctype_Includefilter = Convert.ToBoolean( -1);
         Ddo_view_new_encounter2view_ne_enctype_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_view_new_encounter2view_ne_enctype_Includesortasc = Convert.ToBoolean( -1);
         Ddo_view_new_encounter2view_ne_enctype_Titlecontrolidtoreplace = "";
         Ddo_view_new_encounter2view_ne_enctype_Dropdownoptionstype = "GridTitleSettings";
         Ddo_view_new_encounter2view_ne_enctype_Cls = "ColumnSettings";
         Ddo_view_new_encounter2view_ne_enctype_Tooltip = "WWP_TSColumnOptions";
         Ddo_view_new_encounter2view_ne_enctype_Caption = "";
         Ddo_view_new_encounter2view_ne_departmentadm_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_view_new_encounter2view_ne_departmentadm_Noresultsfound = "WWP_TSNoResults";
         Ddo_view_new_encounter2view_ne_departmentadm_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_view_new_encounter2view_ne_departmentadm_Loadingdata = "WWP_TSLoading";
         Ddo_view_new_encounter2view_ne_departmentadm_Sortdsc = "WWP_TSSortDSC";
         Ddo_view_new_encounter2view_ne_departmentadm_Sortasc = "WWP_TSSortASC";
         Ddo_view_new_encounter2view_ne_departmentadm_Datalistupdateminimumcharacters = 0;
         Ddo_view_new_encounter2view_ne_departmentadm_Datalistproc = "BR_EncounterListwwGetFilterData";
         Ddo_view_new_encounter2view_ne_departmentadm_Datalisttype = "Dynamic";
         Ddo_view_new_encounter2view_ne_departmentadm_Includedatalist = Convert.ToBoolean( -1);
         Ddo_view_new_encounter2view_ne_departmentadm_Filterisrange = Convert.ToBoolean( 0);
         Ddo_view_new_encounter2view_ne_departmentadm_Filtertype = "Character";
         Ddo_view_new_encounter2view_ne_departmentadm_Includefilter = Convert.ToBoolean( -1);
         Ddo_view_new_encounter2view_ne_departmentadm_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_view_new_encounter2view_ne_departmentadm_Includesortasc = Convert.ToBoolean( -1);
         Ddo_view_new_encounter2view_ne_departmentadm_Titlecontrolidtoreplace = "";
         Ddo_view_new_encounter2view_ne_departmentadm_Dropdownoptionstype = "GridTitleSettings";
         Ddo_view_new_encounter2view_ne_departmentadm_Cls = "ColumnSettings";
         Ddo_view_new_encounter2view_ne_departmentadm_Tooltip = "WWP_TSColumnOptions";
         Ddo_view_new_encounter2view_ne_departmentadm_Caption = "";
         Ddo_view_new_encounter2view_ne_information_patientno_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_view_new_encounter2view_ne_information_patientno_Noresultsfound = "WWP_TSNoResults";
         Ddo_view_new_encounter2view_ne_information_patientno_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_view_new_encounter2view_ne_information_patientno_Loadingdata = "WWP_TSLoading";
         Ddo_view_new_encounter2view_ne_information_patientno_Sortdsc = "WWP_TSSortDSC";
         Ddo_view_new_encounter2view_ne_information_patientno_Sortasc = "WWP_TSSortASC";
         Ddo_view_new_encounter2view_ne_information_patientno_Datalistupdateminimumcharacters = 0;
         Ddo_view_new_encounter2view_ne_information_patientno_Datalistproc = "BR_EncounterListwwGetFilterData";
         Ddo_view_new_encounter2view_ne_information_patientno_Datalisttype = "Dynamic";
         Ddo_view_new_encounter2view_ne_information_patientno_Includedatalist = Convert.ToBoolean( -1);
         Ddo_view_new_encounter2view_ne_information_patientno_Filterisrange = Convert.ToBoolean( 0);
         Ddo_view_new_encounter2view_ne_information_patientno_Filtertype = "Character";
         Ddo_view_new_encounter2view_ne_information_patientno_Includefilter = Convert.ToBoolean( -1);
         Ddo_view_new_encounter2view_ne_information_patientno_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_view_new_encounter2view_ne_information_patientno_Includesortasc = Convert.ToBoolean( -1);
         Ddo_view_new_encounter2view_ne_information_patientno_Titlecontrolidtoreplace = "";
         Ddo_view_new_encounter2view_ne_information_patientno_Dropdownoptionstype = "GridTitleSettings";
         Ddo_view_new_encounter2view_ne_information_patientno_Cls = "ColumnSettings";
         Ddo_view_new_encounter2view_ne_information_patientno_Tooltip = "WWP_TSColumnOptions";
         Ddo_view_new_encounter2view_ne_information_patientno_Caption = "";
         Ddo_view_new_encounter2view_ne_encounterid_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_view_new_encounter2view_ne_encounterid_Rangefilterto = "WWP_TSTo";
         Ddo_view_new_encounter2view_ne_encounterid_Rangefilterfrom = "WWP_TSFrom";
         Ddo_view_new_encounter2view_ne_encounterid_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_view_new_encounter2view_ne_encounterid_Sortdsc = "WWP_TSSortDSC";
         Ddo_view_new_encounter2view_ne_encounterid_Sortasc = "WWP_TSSortASC";
         Ddo_view_new_encounter2view_ne_encounterid_Includedatalist = Convert.ToBoolean( 0);
         Ddo_view_new_encounter2view_ne_encounterid_Filterisrange = Convert.ToBoolean( -1);
         Ddo_view_new_encounter2view_ne_encounterid_Filtertype = "Numeric";
         Ddo_view_new_encounter2view_ne_encounterid_Includefilter = Convert.ToBoolean( -1);
         Ddo_view_new_encounter2view_ne_encounterid_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_view_new_encounter2view_ne_encounterid_Includesortasc = Convert.ToBoolean( -1);
         Ddo_view_new_encounter2view_ne_encounterid_Titlecontrolidtoreplace = "";
         Ddo_view_new_encounter2view_ne_encounterid_Dropdownoptionstype = "GridTitleSettings";
         Ddo_view_new_encounter2view_ne_encounterid_Cls = "ColumnSettings";
         Ddo_view_new_encounter2view_ne_encounterid_Tooltip = "WWP_TSColumnOptions";
         Ddo_view_new_encounter2view_ne_encounterid_Caption = "";
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
         Form.Caption = "就诊列表";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV20sBR_EncounterID',fld:'vSBR_ENCOUNTERID',pic:''},{av:'AV21view_NE_AdmitDate',fld:'vVIEW_NE_ADMITDATE',pic:''},{av:'AV22endview_NE_AdmitDate',fld:'vENDVIEW_NE_ADMITDATE',pic:''},{av:'cmbavTview_ne_status'},{av:'AV23tview_NE_Status',fld:'vTVIEW_NE_STATUS',pic:'ZZZ9'},{av:'AV85tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'AV27ddo_View_New_Encounter2view_NE_EncounterIDTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV69ddo_View_New_Encounter2view_NE_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_View_New_Encounter2view_NE_DepartmentadmTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_View_New_Encounter2view_NE_ENCTypeTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_View_New_Encounter2view_NE_StatusTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_View_New_Encounter2view_NE_IsRandApproveTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_View_New_Encounter2view_NE_IsRandRecheckTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECKTITLECONTROLIDTOREPLACE',pic:''},{av:'AV57ddo_View_New_Encounter2view_NE_IsUpdateTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV15BR_Information_PatientNo',fld:'vBR_INFORMATION_PATIENTNO',pic:''},{av:'AV101View_New_Encounter2view_NE_IsRandApprove',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE',pic:''},{av:'AV102View_New_Encounter2view_NE_IsRandRecheck',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK',pic:''},{av:'AV103View_New_Encounter2view_NE_IsUpdate',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE',pic:''},{av:'AV25TFView_New_Encounter2view_NE_EncounterID',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZ9'},{av:'AV26TFView_New_Encounter2view_NE_EncounterID_To',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZ9'},{av:'AV67TFView_New_Encounter2view_NE_Information_PatientNo',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO',pic:''},{av:'AV68TFView_New_Encounter2view_NE_Information_PatientNo_Sel',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV33TFView_New_Encounter2view_NE_Departmentadm',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM',pic:''},{av:'AV34TFView_New_Encounter2view_NE_Departmentadm_Sel',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM_SEL',pic:''},{av:'AV29TFView_New_Encounter2view_NE_ENCType',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE',pic:''},{av:'AV30TFView_New_Encounter2view_NE_ENCType_Sel',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE_SEL',pic:''},{av:'AV105TFView_New_Encounter2view_NE_Status_Sels',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_STATUS_SELS',pic:''},{av:'AV106TFView_New_Encounter2view_NE_IsRandApprove_Sel',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE_SEL',pic:'9'},{av:'AV107TFView_New_Encounter2view_NE_IsRandRecheck_Sel',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK_SEL',pic:'9'},{av:'AV108TFView_New_Encounter2view_NE_IsUpdate_Sel',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE_SEL',pic:'9'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV111Pgmname',fld:'vPGMNAME',pic:'',hsh:true},{av:'AV87IsInsert',fld:'vISINSERT',pic:'',hsh:true}]");
         setEventMetadata("REFRESH",",oparms:[{av:'AV87IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'AV93tAllBR_EncounterID',fld:'vTALLBR_ENCOUNTERID',pic:''},{av:'AV24View_New_Encounter2view_NE_EncounterIDTitleFilterData',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV66View_New_Encounter2view_NE_Information_PatientNoTitleFilterData',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV32View_New_Encounter2view_NE_DepartmentadmTitleFilterData',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADMTITLEFILTERDATA',pic:''},{av:'AV28View_New_Encounter2view_NE_ENCTypeTitleFilterData',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPETITLEFILTERDATA',pic:''},{av:'AV42View_New_Encounter2view_NE_StatusTitleFilterData',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_STATUSTITLEFILTERDATA',pic:''},{av:'AV50View_New_Encounter2view_NE_IsRandApproveTitleFilterData',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVETITLEFILTERDATA',pic:''},{av:'AV46View_New_Encounter2view_NE_IsRandRecheckTitleFilterData',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECKTITLEFILTERDATA',pic:''},{av:'AV54View_New_Encounter2view_NE_IsUpdateTitleFilterData',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATETITLEFILTERDATA',pic:''},{av:'edtView_New_Encounter2view_NE_EncounterID_Titleformat',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID',prop:'Titleformat'},{av:'edtView_New_Encounter2view_NE_EncounterID_Title',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID',prop:'Title'},{av:'edtView_New_Encounter2view_NE_Information_PatientNo_Titleformat',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtView_New_Encounter2view_NE_Information_PatientNo_Title',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtView_New_Encounter2view_NE_Departmentadm_Titleformat',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM',prop:'Titleformat'},{av:'edtView_New_Encounter2view_NE_Departmentadm_Title',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM',prop:'Title'},{av:'edtView_New_Encounter2view_NE_ENCType_Titleformat',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE',prop:'Titleformat'},{av:'edtView_New_Encounter2view_NE_ENCType_Title',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE',prop:'Title'},{av:'cmbView_New_Encounter2view_NE_Status'},{av:'chkView_New_Encounter2view_NE_IsRandApprove_Titleformat',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE',prop:'Titleformat'},{av:'chkView_New_Encounter2view_NE_IsRandApprove.Title.Text',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE',prop:'Title'},{av:'chkView_New_Encounter2view_NE_IsRandRecheck_Titleformat',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK',prop:'Titleformat'},{av:'chkView_New_Encounter2view_NE_IsRandRecheck.Title.Text',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK',prop:'Title'},{av:'chkView_New_Encounter2view_NE_IsUpdate_Titleformat',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE',prop:'Titleformat'},{av:'chkView_New_Encounter2view_NE_IsUpdate.Title.Text',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE',prop:'Title'},{av:'AV72GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV73GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{av:'edtavDeleteencounter_Visible',ctrl:'vDELETEENCOUNTER',prop:'Visible'},{ctrl:'BTNBATCHAPPROVE',prop:'Visible'},{ctrl:'BTNBATCHRECHECK',prop:'Visible'}]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE","{handler:'E11AL2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV15BR_Information_PatientNo',fld:'vBR_INFORMATION_PATIENTNO',pic:''},{av:'AV20sBR_EncounterID',fld:'vSBR_ENCOUNTERID',pic:''},{av:'AV21view_NE_AdmitDate',fld:'vVIEW_NE_ADMITDATE',pic:''},{av:'AV22endview_NE_AdmitDate',fld:'vENDVIEW_NE_ADMITDATE',pic:''},{av:'cmbavTview_ne_status'},{av:'AV23tview_NE_Status',fld:'vTVIEW_NE_STATUS',pic:'ZZZ9'},{av:'AV101View_New_Encounter2view_NE_IsRandApprove',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE',pic:''},{av:'AV102View_New_Encounter2view_NE_IsRandRecheck',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK',pic:''},{av:'AV103View_New_Encounter2view_NE_IsUpdate',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV25TFView_New_Encounter2view_NE_EncounterID',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZ9'},{av:'AV26TFView_New_Encounter2view_NE_EncounterID_To',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZ9'},{av:'AV67TFView_New_Encounter2view_NE_Information_PatientNo',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO',pic:''},{av:'AV68TFView_New_Encounter2view_NE_Information_PatientNo_Sel',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV33TFView_New_Encounter2view_NE_Departmentadm',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM',pic:''},{av:'AV34TFView_New_Encounter2view_NE_Departmentadm_Sel',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM_SEL',pic:''},{av:'AV29TFView_New_Encounter2view_NE_ENCType',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE',pic:''},{av:'AV30TFView_New_Encounter2view_NE_ENCType_Sel',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE_SEL',pic:''},{av:'AV106TFView_New_Encounter2view_NE_IsRandApprove_Sel',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE_SEL',pic:'9'},{av:'AV107TFView_New_Encounter2view_NE_IsRandRecheck_Sel',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK_SEL',pic:'9'},{av:'AV108TFView_New_Encounter2view_NE_IsUpdate_Sel',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE_SEL',pic:'9'},{av:'AV85tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'AV27ddo_View_New_Encounter2view_NE_EncounterIDTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV69ddo_View_New_Encounter2view_NE_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_View_New_Encounter2view_NE_DepartmentadmTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_View_New_Encounter2view_NE_ENCTypeTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_View_New_Encounter2view_NE_StatusTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_View_New_Encounter2view_NE_IsRandApproveTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_View_New_Encounter2view_NE_IsRandRecheckTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECKTITLECONTROLIDTOREPLACE',pic:''},{av:'AV57ddo_View_New_Encounter2view_NE_IsUpdateTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV105TFView_New_Encounter2view_NE_Status_Sels',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_STATUS_SELS',pic:''},{av:'AV111Pgmname',fld:'vPGMNAME',pic:'',hsh:true},{av:'AV87IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'Gridpaginationbar_Selectedpage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE",",oparms:[]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE","{handler:'E12AL2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV15BR_Information_PatientNo',fld:'vBR_INFORMATION_PATIENTNO',pic:''},{av:'AV20sBR_EncounterID',fld:'vSBR_ENCOUNTERID',pic:''},{av:'AV21view_NE_AdmitDate',fld:'vVIEW_NE_ADMITDATE',pic:''},{av:'AV22endview_NE_AdmitDate',fld:'vENDVIEW_NE_ADMITDATE',pic:''},{av:'cmbavTview_ne_status'},{av:'AV23tview_NE_Status',fld:'vTVIEW_NE_STATUS',pic:'ZZZ9'},{av:'AV101View_New_Encounter2view_NE_IsRandApprove',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE',pic:''},{av:'AV102View_New_Encounter2view_NE_IsRandRecheck',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK',pic:''},{av:'AV103View_New_Encounter2view_NE_IsUpdate',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV25TFView_New_Encounter2view_NE_EncounterID',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZ9'},{av:'AV26TFView_New_Encounter2view_NE_EncounterID_To',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZ9'},{av:'AV67TFView_New_Encounter2view_NE_Information_PatientNo',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO',pic:''},{av:'AV68TFView_New_Encounter2view_NE_Information_PatientNo_Sel',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV33TFView_New_Encounter2view_NE_Departmentadm',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM',pic:''},{av:'AV34TFView_New_Encounter2view_NE_Departmentadm_Sel',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM_SEL',pic:''},{av:'AV29TFView_New_Encounter2view_NE_ENCType',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE',pic:''},{av:'AV30TFView_New_Encounter2view_NE_ENCType_Sel',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE_SEL',pic:''},{av:'AV106TFView_New_Encounter2view_NE_IsRandApprove_Sel',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE_SEL',pic:'9'},{av:'AV107TFView_New_Encounter2view_NE_IsRandRecheck_Sel',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK_SEL',pic:'9'},{av:'AV108TFView_New_Encounter2view_NE_IsUpdate_Sel',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE_SEL',pic:'9'},{av:'AV85tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'AV27ddo_View_New_Encounter2view_NE_EncounterIDTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV69ddo_View_New_Encounter2view_NE_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_View_New_Encounter2view_NE_DepartmentadmTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_View_New_Encounter2view_NE_ENCTypeTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_View_New_Encounter2view_NE_StatusTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_View_New_Encounter2view_NE_IsRandApproveTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_View_New_Encounter2view_NE_IsRandRecheckTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECKTITLECONTROLIDTOREPLACE',pic:''},{av:'AV57ddo_View_New_Encounter2view_NE_IsUpdateTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV105TFView_New_Encounter2view_NE_Status_Sels',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_STATUS_SELS',pic:''},{av:'AV111Pgmname',fld:'vPGMNAME',pic:'',hsh:true},{av:'AV87IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'Gridpaginationbar_Rowsperpageselectedvalue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE",",oparms:[{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]}");
         setEventMetadata("DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID.ONOPTIONCLICKED","{handler:'E13AL2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV15BR_Information_PatientNo',fld:'vBR_INFORMATION_PATIENTNO',pic:''},{av:'AV20sBR_EncounterID',fld:'vSBR_ENCOUNTERID',pic:''},{av:'AV21view_NE_AdmitDate',fld:'vVIEW_NE_ADMITDATE',pic:''},{av:'AV22endview_NE_AdmitDate',fld:'vENDVIEW_NE_ADMITDATE',pic:''},{av:'cmbavTview_ne_status'},{av:'AV23tview_NE_Status',fld:'vTVIEW_NE_STATUS',pic:'ZZZ9'},{av:'AV101View_New_Encounter2view_NE_IsRandApprove',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE',pic:''},{av:'AV102View_New_Encounter2view_NE_IsRandRecheck',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK',pic:''},{av:'AV103View_New_Encounter2view_NE_IsUpdate',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV25TFView_New_Encounter2view_NE_EncounterID',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZ9'},{av:'AV26TFView_New_Encounter2view_NE_EncounterID_To',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZ9'},{av:'AV67TFView_New_Encounter2view_NE_Information_PatientNo',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO',pic:''},{av:'AV68TFView_New_Encounter2view_NE_Information_PatientNo_Sel',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV33TFView_New_Encounter2view_NE_Departmentadm',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM',pic:''},{av:'AV34TFView_New_Encounter2view_NE_Departmentadm_Sel',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM_SEL',pic:''},{av:'AV29TFView_New_Encounter2view_NE_ENCType',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE',pic:''},{av:'AV30TFView_New_Encounter2view_NE_ENCType_Sel',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE_SEL',pic:''},{av:'AV106TFView_New_Encounter2view_NE_IsRandApprove_Sel',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE_SEL',pic:'9'},{av:'AV107TFView_New_Encounter2view_NE_IsRandRecheck_Sel',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK_SEL',pic:'9'},{av:'AV108TFView_New_Encounter2view_NE_IsUpdate_Sel',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE_SEL',pic:'9'},{av:'AV85tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'AV27ddo_View_New_Encounter2view_NE_EncounterIDTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV69ddo_View_New_Encounter2view_NE_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_View_New_Encounter2view_NE_DepartmentadmTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_View_New_Encounter2view_NE_ENCTypeTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_View_New_Encounter2view_NE_StatusTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_View_New_Encounter2view_NE_IsRandApproveTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_View_New_Encounter2view_NE_IsRandRecheckTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECKTITLECONTROLIDTOREPLACE',pic:''},{av:'AV57ddo_View_New_Encounter2view_NE_IsUpdateTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV105TFView_New_Encounter2view_NE_Status_Sels',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_STATUS_SELS',pic:''},{av:'AV111Pgmname',fld:'vPGMNAME',pic:'',hsh:true},{av:'AV87IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'Ddo_view_new_encounter2view_ne_encounterid_Activeeventkey',ctrl:'DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID',prop:'ActiveEventKey'},{av:'Ddo_view_new_encounter2view_ne_encounterid_Filteredtext_get',ctrl:'DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID',prop:'FilteredText_get'},{av:'Ddo_view_new_encounter2view_ne_encounterid_Filteredtextto_get',ctrl:'DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID',prop:'FilteredTextTo_get'}]");
         setEventMetadata("DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_view_new_encounter2view_ne_encounterid_Sortedstatus',ctrl:'DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID',prop:'SortedStatus'},{av:'AV25TFView_New_Encounter2view_NE_EncounterID',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZ9'},{av:'AV26TFView_New_Encounter2view_NE_EncounterID_To',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZ9'},{av:'Ddo_view_new_encounter2view_ne_information_patientno_Sortedstatus',ctrl:'DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO',prop:'SortedStatus'},{av:'Ddo_view_new_encounter2view_ne_departmentadm_Sortedstatus',ctrl:'DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM',prop:'SortedStatus'},{av:'Ddo_view_new_encounter2view_ne_enctype_Sortedstatus',ctrl:'DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE',prop:'SortedStatus'},{av:'Ddo_view_new_encounter2view_ne_status_Sortedstatus',ctrl:'DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_STATUS',prop:'SortedStatus'},{av:'Ddo_view_new_encounter2view_ne_israndapprove_Sortedstatus',ctrl:'DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE',prop:'SortedStatus'},{av:'Ddo_view_new_encounter2view_ne_israndrecheck_Sortedstatus',ctrl:'DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK',prop:'SortedStatus'},{av:'Ddo_view_new_encounter2view_ne_isupdate_Sortedstatus',ctrl:'DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE',prop:'SortedStatus'},{av:'AV87IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'AV93tAllBR_EncounterID',fld:'vTALLBR_ENCOUNTERID',pic:''},{av:'AV24View_New_Encounter2view_NE_EncounterIDTitleFilterData',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV66View_New_Encounter2view_NE_Information_PatientNoTitleFilterData',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV32View_New_Encounter2view_NE_DepartmentadmTitleFilterData',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADMTITLEFILTERDATA',pic:''},{av:'AV28View_New_Encounter2view_NE_ENCTypeTitleFilterData',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPETITLEFILTERDATA',pic:''},{av:'AV42View_New_Encounter2view_NE_StatusTitleFilterData',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_STATUSTITLEFILTERDATA',pic:''},{av:'AV50View_New_Encounter2view_NE_IsRandApproveTitleFilterData',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVETITLEFILTERDATA',pic:''},{av:'AV46View_New_Encounter2view_NE_IsRandRecheckTitleFilterData',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECKTITLEFILTERDATA',pic:''},{av:'AV54View_New_Encounter2view_NE_IsUpdateTitleFilterData',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATETITLEFILTERDATA',pic:''},{av:'edtView_New_Encounter2view_NE_EncounterID_Titleformat',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID',prop:'Titleformat'},{av:'edtView_New_Encounter2view_NE_EncounterID_Title',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID',prop:'Title'},{av:'edtView_New_Encounter2view_NE_Information_PatientNo_Titleformat',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtView_New_Encounter2view_NE_Information_PatientNo_Title',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtView_New_Encounter2view_NE_Departmentadm_Titleformat',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM',prop:'Titleformat'},{av:'edtView_New_Encounter2view_NE_Departmentadm_Title',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM',prop:'Title'},{av:'edtView_New_Encounter2view_NE_ENCType_Titleformat',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE',prop:'Titleformat'},{av:'edtView_New_Encounter2view_NE_ENCType_Title',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE',prop:'Title'},{av:'cmbView_New_Encounter2view_NE_Status'},{av:'chkView_New_Encounter2view_NE_IsRandApprove_Titleformat',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE',prop:'Titleformat'},{av:'chkView_New_Encounter2view_NE_IsRandApprove.Title.Text',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE',prop:'Title'},{av:'chkView_New_Encounter2view_NE_IsRandRecheck_Titleformat',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK',prop:'Titleformat'},{av:'chkView_New_Encounter2view_NE_IsRandRecheck.Title.Text',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK',prop:'Title'},{av:'chkView_New_Encounter2view_NE_IsUpdate_Titleformat',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE',prop:'Titleformat'},{av:'chkView_New_Encounter2view_NE_IsUpdate.Title.Text',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE',prop:'Title'},{av:'AV72GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV73GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{av:'edtavDeleteencounter_Visible',ctrl:'vDELETEENCOUNTER',prop:'Visible'},{ctrl:'BTNBATCHAPPROVE',prop:'Visible'},{ctrl:'BTNBATCHRECHECK',prop:'Visible'}]}");
         setEventMetadata("DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO.ONOPTIONCLICKED","{handler:'E14AL2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV15BR_Information_PatientNo',fld:'vBR_INFORMATION_PATIENTNO',pic:''},{av:'AV20sBR_EncounterID',fld:'vSBR_ENCOUNTERID',pic:''},{av:'AV21view_NE_AdmitDate',fld:'vVIEW_NE_ADMITDATE',pic:''},{av:'AV22endview_NE_AdmitDate',fld:'vENDVIEW_NE_ADMITDATE',pic:''},{av:'cmbavTview_ne_status'},{av:'AV23tview_NE_Status',fld:'vTVIEW_NE_STATUS',pic:'ZZZ9'},{av:'AV101View_New_Encounter2view_NE_IsRandApprove',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE',pic:''},{av:'AV102View_New_Encounter2view_NE_IsRandRecheck',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK',pic:''},{av:'AV103View_New_Encounter2view_NE_IsUpdate',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV25TFView_New_Encounter2view_NE_EncounterID',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZ9'},{av:'AV26TFView_New_Encounter2view_NE_EncounterID_To',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZ9'},{av:'AV67TFView_New_Encounter2view_NE_Information_PatientNo',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO',pic:''},{av:'AV68TFView_New_Encounter2view_NE_Information_PatientNo_Sel',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV33TFView_New_Encounter2view_NE_Departmentadm',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM',pic:''},{av:'AV34TFView_New_Encounter2view_NE_Departmentadm_Sel',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM_SEL',pic:''},{av:'AV29TFView_New_Encounter2view_NE_ENCType',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE',pic:''},{av:'AV30TFView_New_Encounter2view_NE_ENCType_Sel',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE_SEL',pic:''},{av:'AV106TFView_New_Encounter2view_NE_IsRandApprove_Sel',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE_SEL',pic:'9'},{av:'AV107TFView_New_Encounter2view_NE_IsRandRecheck_Sel',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK_SEL',pic:'9'},{av:'AV108TFView_New_Encounter2view_NE_IsUpdate_Sel',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE_SEL',pic:'9'},{av:'AV85tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'AV27ddo_View_New_Encounter2view_NE_EncounterIDTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV69ddo_View_New_Encounter2view_NE_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_View_New_Encounter2view_NE_DepartmentadmTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_View_New_Encounter2view_NE_ENCTypeTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_View_New_Encounter2view_NE_StatusTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_View_New_Encounter2view_NE_IsRandApproveTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_View_New_Encounter2view_NE_IsRandRecheckTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECKTITLECONTROLIDTOREPLACE',pic:''},{av:'AV57ddo_View_New_Encounter2view_NE_IsUpdateTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV105TFView_New_Encounter2view_NE_Status_Sels',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_STATUS_SELS',pic:''},{av:'AV111Pgmname',fld:'vPGMNAME',pic:'',hsh:true},{av:'AV87IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'Ddo_view_new_encounter2view_ne_information_patientno_Activeeventkey',ctrl:'DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO',prop:'ActiveEventKey'},{av:'Ddo_view_new_encounter2view_ne_information_patientno_Filteredtext_get',ctrl:'DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO',prop:'FilteredText_get'},{av:'Ddo_view_new_encounter2view_ne_information_patientno_Selectedvalue_get',ctrl:'DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO',prop:'SelectedValue_get'}]");
         setEventMetadata("DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_view_new_encounter2view_ne_information_patientno_Sortedstatus',ctrl:'DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO',prop:'SortedStatus'},{av:'AV67TFView_New_Encounter2view_NE_Information_PatientNo',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO',pic:''},{av:'AV68TFView_New_Encounter2view_NE_Information_PatientNo_Sel',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO_SEL',pic:''},{av:'Ddo_view_new_encounter2view_ne_encounterid_Sortedstatus',ctrl:'DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID',prop:'SortedStatus'},{av:'Ddo_view_new_encounter2view_ne_departmentadm_Sortedstatus',ctrl:'DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM',prop:'SortedStatus'},{av:'Ddo_view_new_encounter2view_ne_enctype_Sortedstatus',ctrl:'DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE',prop:'SortedStatus'},{av:'Ddo_view_new_encounter2view_ne_status_Sortedstatus',ctrl:'DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_STATUS',prop:'SortedStatus'},{av:'Ddo_view_new_encounter2view_ne_israndapprove_Sortedstatus',ctrl:'DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE',prop:'SortedStatus'},{av:'Ddo_view_new_encounter2view_ne_israndrecheck_Sortedstatus',ctrl:'DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK',prop:'SortedStatus'},{av:'Ddo_view_new_encounter2view_ne_isupdate_Sortedstatus',ctrl:'DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE',prop:'SortedStatus'},{av:'AV87IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'AV93tAllBR_EncounterID',fld:'vTALLBR_ENCOUNTERID',pic:''},{av:'AV24View_New_Encounter2view_NE_EncounterIDTitleFilterData',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV66View_New_Encounter2view_NE_Information_PatientNoTitleFilterData',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV32View_New_Encounter2view_NE_DepartmentadmTitleFilterData',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADMTITLEFILTERDATA',pic:''},{av:'AV28View_New_Encounter2view_NE_ENCTypeTitleFilterData',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPETITLEFILTERDATA',pic:''},{av:'AV42View_New_Encounter2view_NE_StatusTitleFilterData',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_STATUSTITLEFILTERDATA',pic:''},{av:'AV50View_New_Encounter2view_NE_IsRandApproveTitleFilterData',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVETITLEFILTERDATA',pic:''},{av:'AV46View_New_Encounter2view_NE_IsRandRecheckTitleFilterData',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECKTITLEFILTERDATA',pic:''},{av:'AV54View_New_Encounter2view_NE_IsUpdateTitleFilterData',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATETITLEFILTERDATA',pic:''},{av:'edtView_New_Encounter2view_NE_EncounterID_Titleformat',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID',prop:'Titleformat'},{av:'edtView_New_Encounter2view_NE_EncounterID_Title',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID',prop:'Title'},{av:'edtView_New_Encounter2view_NE_Information_PatientNo_Titleformat',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtView_New_Encounter2view_NE_Information_PatientNo_Title',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtView_New_Encounter2view_NE_Departmentadm_Titleformat',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM',prop:'Titleformat'},{av:'edtView_New_Encounter2view_NE_Departmentadm_Title',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM',prop:'Title'},{av:'edtView_New_Encounter2view_NE_ENCType_Titleformat',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE',prop:'Titleformat'},{av:'edtView_New_Encounter2view_NE_ENCType_Title',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE',prop:'Title'},{av:'cmbView_New_Encounter2view_NE_Status'},{av:'chkView_New_Encounter2view_NE_IsRandApprove_Titleformat',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE',prop:'Titleformat'},{av:'chkView_New_Encounter2view_NE_IsRandApprove.Title.Text',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE',prop:'Title'},{av:'chkView_New_Encounter2view_NE_IsRandRecheck_Titleformat',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK',prop:'Titleformat'},{av:'chkView_New_Encounter2view_NE_IsRandRecheck.Title.Text',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK',prop:'Title'},{av:'chkView_New_Encounter2view_NE_IsUpdate_Titleformat',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE',prop:'Titleformat'},{av:'chkView_New_Encounter2view_NE_IsUpdate.Title.Text',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE',prop:'Title'},{av:'AV72GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV73GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{av:'edtavDeleteencounter_Visible',ctrl:'vDELETEENCOUNTER',prop:'Visible'},{ctrl:'BTNBATCHAPPROVE',prop:'Visible'},{ctrl:'BTNBATCHRECHECK',prop:'Visible'}]}");
         setEventMetadata("DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM.ONOPTIONCLICKED","{handler:'E15AL2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV15BR_Information_PatientNo',fld:'vBR_INFORMATION_PATIENTNO',pic:''},{av:'AV20sBR_EncounterID',fld:'vSBR_ENCOUNTERID',pic:''},{av:'AV21view_NE_AdmitDate',fld:'vVIEW_NE_ADMITDATE',pic:''},{av:'AV22endview_NE_AdmitDate',fld:'vENDVIEW_NE_ADMITDATE',pic:''},{av:'cmbavTview_ne_status'},{av:'AV23tview_NE_Status',fld:'vTVIEW_NE_STATUS',pic:'ZZZ9'},{av:'AV101View_New_Encounter2view_NE_IsRandApprove',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE',pic:''},{av:'AV102View_New_Encounter2view_NE_IsRandRecheck',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK',pic:''},{av:'AV103View_New_Encounter2view_NE_IsUpdate',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV25TFView_New_Encounter2view_NE_EncounterID',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZ9'},{av:'AV26TFView_New_Encounter2view_NE_EncounterID_To',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZ9'},{av:'AV67TFView_New_Encounter2view_NE_Information_PatientNo',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO',pic:''},{av:'AV68TFView_New_Encounter2view_NE_Information_PatientNo_Sel',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV33TFView_New_Encounter2view_NE_Departmentadm',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM',pic:''},{av:'AV34TFView_New_Encounter2view_NE_Departmentadm_Sel',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM_SEL',pic:''},{av:'AV29TFView_New_Encounter2view_NE_ENCType',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE',pic:''},{av:'AV30TFView_New_Encounter2view_NE_ENCType_Sel',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE_SEL',pic:''},{av:'AV106TFView_New_Encounter2view_NE_IsRandApprove_Sel',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE_SEL',pic:'9'},{av:'AV107TFView_New_Encounter2view_NE_IsRandRecheck_Sel',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK_SEL',pic:'9'},{av:'AV108TFView_New_Encounter2view_NE_IsUpdate_Sel',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE_SEL',pic:'9'},{av:'AV85tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'AV27ddo_View_New_Encounter2view_NE_EncounterIDTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV69ddo_View_New_Encounter2view_NE_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_View_New_Encounter2view_NE_DepartmentadmTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_View_New_Encounter2view_NE_ENCTypeTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_View_New_Encounter2view_NE_StatusTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_View_New_Encounter2view_NE_IsRandApproveTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_View_New_Encounter2view_NE_IsRandRecheckTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECKTITLECONTROLIDTOREPLACE',pic:''},{av:'AV57ddo_View_New_Encounter2view_NE_IsUpdateTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV105TFView_New_Encounter2view_NE_Status_Sels',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_STATUS_SELS',pic:''},{av:'AV111Pgmname',fld:'vPGMNAME',pic:'',hsh:true},{av:'AV87IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'Ddo_view_new_encounter2view_ne_departmentadm_Activeeventkey',ctrl:'DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM',prop:'ActiveEventKey'},{av:'Ddo_view_new_encounter2view_ne_departmentadm_Filteredtext_get',ctrl:'DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM',prop:'FilteredText_get'},{av:'Ddo_view_new_encounter2view_ne_departmentadm_Selectedvalue_get',ctrl:'DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM',prop:'SelectedValue_get'}]");
         setEventMetadata("DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_view_new_encounter2view_ne_departmentadm_Sortedstatus',ctrl:'DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM',prop:'SortedStatus'},{av:'AV33TFView_New_Encounter2view_NE_Departmentadm',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM',pic:''},{av:'AV34TFView_New_Encounter2view_NE_Departmentadm_Sel',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM_SEL',pic:''},{av:'Ddo_view_new_encounter2view_ne_encounterid_Sortedstatus',ctrl:'DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID',prop:'SortedStatus'},{av:'Ddo_view_new_encounter2view_ne_information_patientno_Sortedstatus',ctrl:'DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO',prop:'SortedStatus'},{av:'Ddo_view_new_encounter2view_ne_enctype_Sortedstatus',ctrl:'DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE',prop:'SortedStatus'},{av:'Ddo_view_new_encounter2view_ne_status_Sortedstatus',ctrl:'DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_STATUS',prop:'SortedStatus'},{av:'Ddo_view_new_encounter2view_ne_israndapprove_Sortedstatus',ctrl:'DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE',prop:'SortedStatus'},{av:'Ddo_view_new_encounter2view_ne_israndrecheck_Sortedstatus',ctrl:'DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK',prop:'SortedStatus'},{av:'Ddo_view_new_encounter2view_ne_isupdate_Sortedstatus',ctrl:'DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE',prop:'SortedStatus'},{av:'AV87IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'AV93tAllBR_EncounterID',fld:'vTALLBR_ENCOUNTERID',pic:''},{av:'AV24View_New_Encounter2view_NE_EncounterIDTitleFilterData',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV66View_New_Encounter2view_NE_Information_PatientNoTitleFilterData',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV32View_New_Encounter2view_NE_DepartmentadmTitleFilterData',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADMTITLEFILTERDATA',pic:''},{av:'AV28View_New_Encounter2view_NE_ENCTypeTitleFilterData',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPETITLEFILTERDATA',pic:''},{av:'AV42View_New_Encounter2view_NE_StatusTitleFilterData',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_STATUSTITLEFILTERDATA',pic:''},{av:'AV50View_New_Encounter2view_NE_IsRandApproveTitleFilterData',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVETITLEFILTERDATA',pic:''},{av:'AV46View_New_Encounter2view_NE_IsRandRecheckTitleFilterData',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECKTITLEFILTERDATA',pic:''},{av:'AV54View_New_Encounter2view_NE_IsUpdateTitleFilterData',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATETITLEFILTERDATA',pic:''},{av:'edtView_New_Encounter2view_NE_EncounterID_Titleformat',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID',prop:'Titleformat'},{av:'edtView_New_Encounter2view_NE_EncounterID_Title',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID',prop:'Title'},{av:'edtView_New_Encounter2view_NE_Information_PatientNo_Titleformat',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtView_New_Encounter2view_NE_Information_PatientNo_Title',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtView_New_Encounter2view_NE_Departmentadm_Titleformat',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM',prop:'Titleformat'},{av:'edtView_New_Encounter2view_NE_Departmentadm_Title',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM',prop:'Title'},{av:'edtView_New_Encounter2view_NE_ENCType_Titleformat',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE',prop:'Titleformat'},{av:'edtView_New_Encounter2view_NE_ENCType_Title',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE',prop:'Title'},{av:'cmbView_New_Encounter2view_NE_Status'},{av:'chkView_New_Encounter2view_NE_IsRandApprove_Titleformat',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE',prop:'Titleformat'},{av:'chkView_New_Encounter2view_NE_IsRandApprove.Title.Text',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE',prop:'Title'},{av:'chkView_New_Encounter2view_NE_IsRandRecheck_Titleformat',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK',prop:'Titleformat'},{av:'chkView_New_Encounter2view_NE_IsRandRecheck.Title.Text',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK',prop:'Title'},{av:'chkView_New_Encounter2view_NE_IsUpdate_Titleformat',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE',prop:'Titleformat'},{av:'chkView_New_Encounter2view_NE_IsUpdate.Title.Text',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE',prop:'Title'},{av:'AV72GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV73GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{av:'edtavDeleteencounter_Visible',ctrl:'vDELETEENCOUNTER',prop:'Visible'},{ctrl:'BTNBATCHAPPROVE',prop:'Visible'},{ctrl:'BTNBATCHRECHECK',prop:'Visible'}]}");
         setEventMetadata("DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE.ONOPTIONCLICKED","{handler:'E16AL2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV15BR_Information_PatientNo',fld:'vBR_INFORMATION_PATIENTNO',pic:''},{av:'AV20sBR_EncounterID',fld:'vSBR_ENCOUNTERID',pic:''},{av:'AV21view_NE_AdmitDate',fld:'vVIEW_NE_ADMITDATE',pic:''},{av:'AV22endview_NE_AdmitDate',fld:'vENDVIEW_NE_ADMITDATE',pic:''},{av:'cmbavTview_ne_status'},{av:'AV23tview_NE_Status',fld:'vTVIEW_NE_STATUS',pic:'ZZZ9'},{av:'AV101View_New_Encounter2view_NE_IsRandApprove',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE',pic:''},{av:'AV102View_New_Encounter2view_NE_IsRandRecheck',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK',pic:''},{av:'AV103View_New_Encounter2view_NE_IsUpdate',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV25TFView_New_Encounter2view_NE_EncounterID',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZ9'},{av:'AV26TFView_New_Encounter2view_NE_EncounterID_To',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZ9'},{av:'AV67TFView_New_Encounter2view_NE_Information_PatientNo',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO',pic:''},{av:'AV68TFView_New_Encounter2view_NE_Information_PatientNo_Sel',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV33TFView_New_Encounter2view_NE_Departmentadm',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM',pic:''},{av:'AV34TFView_New_Encounter2view_NE_Departmentadm_Sel',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM_SEL',pic:''},{av:'AV29TFView_New_Encounter2view_NE_ENCType',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE',pic:''},{av:'AV30TFView_New_Encounter2view_NE_ENCType_Sel',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE_SEL',pic:''},{av:'AV106TFView_New_Encounter2view_NE_IsRandApprove_Sel',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE_SEL',pic:'9'},{av:'AV107TFView_New_Encounter2view_NE_IsRandRecheck_Sel',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK_SEL',pic:'9'},{av:'AV108TFView_New_Encounter2view_NE_IsUpdate_Sel',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE_SEL',pic:'9'},{av:'AV85tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'AV27ddo_View_New_Encounter2view_NE_EncounterIDTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV69ddo_View_New_Encounter2view_NE_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_View_New_Encounter2view_NE_DepartmentadmTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_View_New_Encounter2view_NE_ENCTypeTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_View_New_Encounter2view_NE_StatusTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_View_New_Encounter2view_NE_IsRandApproveTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_View_New_Encounter2view_NE_IsRandRecheckTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECKTITLECONTROLIDTOREPLACE',pic:''},{av:'AV57ddo_View_New_Encounter2view_NE_IsUpdateTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV105TFView_New_Encounter2view_NE_Status_Sels',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_STATUS_SELS',pic:''},{av:'AV111Pgmname',fld:'vPGMNAME',pic:'',hsh:true},{av:'AV87IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'Ddo_view_new_encounter2view_ne_enctype_Activeeventkey',ctrl:'DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE',prop:'ActiveEventKey'},{av:'Ddo_view_new_encounter2view_ne_enctype_Filteredtext_get',ctrl:'DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE',prop:'FilteredText_get'},{av:'Ddo_view_new_encounter2view_ne_enctype_Selectedvalue_get',ctrl:'DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE',prop:'SelectedValue_get'}]");
         setEventMetadata("DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_view_new_encounter2view_ne_enctype_Sortedstatus',ctrl:'DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE',prop:'SortedStatus'},{av:'AV29TFView_New_Encounter2view_NE_ENCType',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE',pic:''},{av:'AV30TFView_New_Encounter2view_NE_ENCType_Sel',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE_SEL',pic:''},{av:'Ddo_view_new_encounter2view_ne_encounterid_Sortedstatus',ctrl:'DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID',prop:'SortedStatus'},{av:'Ddo_view_new_encounter2view_ne_information_patientno_Sortedstatus',ctrl:'DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO',prop:'SortedStatus'},{av:'Ddo_view_new_encounter2view_ne_departmentadm_Sortedstatus',ctrl:'DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM',prop:'SortedStatus'},{av:'Ddo_view_new_encounter2view_ne_status_Sortedstatus',ctrl:'DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_STATUS',prop:'SortedStatus'},{av:'Ddo_view_new_encounter2view_ne_israndapprove_Sortedstatus',ctrl:'DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE',prop:'SortedStatus'},{av:'Ddo_view_new_encounter2view_ne_israndrecheck_Sortedstatus',ctrl:'DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK',prop:'SortedStatus'},{av:'Ddo_view_new_encounter2view_ne_isupdate_Sortedstatus',ctrl:'DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE',prop:'SortedStatus'},{av:'AV87IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'AV93tAllBR_EncounterID',fld:'vTALLBR_ENCOUNTERID',pic:''},{av:'AV24View_New_Encounter2view_NE_EncounterIDTitleFilterData',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV66View_New_Encounter2view_NE_Information_PatientNoTitleFilterData',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV32View_New_Encounter2view_NE_DepartmentadmTitleFilterData',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADMTITLEFILTERDATA',pic:''},{av:'AV28View_New_Encounter2view_NE_ENCTypeTitleFilterData',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPETITLEFILTERDATA',pic:''},{av:'AV42View_New_Encounter2view_NE_StatusTitleFilterData',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_STATUSTITLEFILTERDATA',pic:''},{av:'AV50View_New_Encounter2view_NE_IsRandApproveTitleFilterData',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVETITLEFILTERDATA',pic:''},{av:'AV46View_New_Encounter2view_NE_IsRandRecheckTitleFilterData',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECKTITLEFILTERDATA',pic:''},{av:'AV54View_New_Encounter2view_NE_IsUpdateTitleFilterData',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATETITLEFILTERDATA',pic:''},{av:'edtView_New_Encounter2view_NE_EncounterID_Titleformat',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID',prop:'Titleformat'},{av:'edtView_New_Encounter2view_NE_EncounterID_Title',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID',prop:'Title'},{av:'edtView_New_Encounter2view_NE_Information_PatientNo_Titleformat',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtView_New_Encounter2view_NE_Information_PatientNo_Title',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtView_New_Encounter2view_NE_Departmentadm_Titleformat',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM',prop:'Titleformat'},{av:'edtView_New_Encounter2view_NE_Departmentadm_Title',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM',prop:'Title'},{av:'edtView_New_Encounter2view_NE_ENCType_Titleformat',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE',prop:'Titleformat'},{av:'edtView_New_Encounter2view_NE_ENCType_Title',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE',prop:'Title'},{av:'cmbView_New_Encounter2view_NE_Status'},{av:'chkView_New_Encounter2view_NE_IsRandApprove_Titleformat',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE',prop:'Titleformat'},{av:'chkView_New_Encounter2view_NE_IsRandApprove.Title.Text',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE',prop:'Title'},{av:'chkView_New_Encounter2view_NE_IsRandRecheck_Titleformat',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK',prop:'Titleformat'},{av:'chkView_New_Encounter2view_NE_IsRandRecheck.Title.Text',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK',prop:'Title'},{av:'chkView_New_Encounter2view_NE_IsUpdate_Titleformat',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE',prop:'Titleformat'},{av:'chkView_New_Encounter2view_NE_IsUpdate.Title.Text',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE',prop:'Title'},{av:'AV72GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV73GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{av:'edtavDeleteencounter_Visible',ctrl:'vDELETEENCOUNTER',prop:'Visible'},{ctrl:'BTNBATCHAPPROVE',prop:'Visible'},{ctrl:'BTNBATCHRECHECK',prop:'Visible'}]}");
         setEventMetadata("DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_STATUS.ONOPTIONCLICKED","{handler:'E17AL2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV15BR_Information_PatientNo',fld:'vBR_INFORMATION_PATIENTNO',pic:''},{av:'AV20sBR_EncounterID',fld:'vSBR_ENCOUNTERID',pic:''},{av:'AV21view_NE_AdmitDate',fld:'vVIEW_NE_ADMITDATE',pic:''},{av:'AV22endview_NE_AdmitDate',fld:'vENDVIEW_NE_ADMITDATE',pic:''},{av:'cmbavTview_ne_status'},{av:'AV23tview_NE_Status',fld:'vTVIEW_NE_STATUS',pic:'ZZZ9'},{av:'AV101View_New_Encounter2view_NE_IsRandApprove',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE',pic:''},{av:'AV102View_New_Encounter2view_NE_IsRandRecheck',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK',pic:''},{av:'AV103View_New_Encounter2view_NE_IsUpdate',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV25TFView_New_Encounter2view_NE_EncounterID',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZ9'},{av:'AV26TFView_New_Encounter2view_NE_EncounterID_To',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZ9'},{av:'AV67TFView_New_Encounter2view_NE_Information_PatientNo',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO',pic:''},{av:'AV68TFView_New_Encounter2view_NE_Information_PatientNo_Sel',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV33TFView_New_Encounter2view_NE_Departmentadm',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM',pic:''},{av:'AV34TFView_New_Encounter2view_NE_Departmentadm_Sel',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM_SEL',pic:''},{av:'AV29TFView_New_Encounter2view_NE_ENCType',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE',pic:''},{av:'AV30TFView_New_Encounter2view_NE_ENCType_Sel',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE_SEL',pic:''},{av:'AV106TFView_New_Encounter2view_NE_IsRandApprove_Sel',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE_SEL',pic:'9'},{av:'AV107TFView_New_Encounter2view_NE_IsRandRecheck_Sel',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK_SEL',pic:'9'},{av:'AV108TFView_New_Encounter2view_NE_IsUpdate_Sel',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE_SEL',pic:'9'},{av:'AV85tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'AV27ddo_View_New_Encounter2view_NE_EncounterIDTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV69ddo_View_New_Encounter2view_NE_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_View_New_Encounter2view_NE_DepartmentadmTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_View_New_Encounter2view_NE_ENCTypeTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_View_New_Encounter2view_NE_StatusTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_View_New_Encounter2view_NE_IsRandApproveTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_View_New_Encounter2view_NE_IsRandRecheckTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECKTITLECONTROLIDTOREPLACE',pic:''},{av:'AV57ddo_View_New_Encounter2view_NE_IsUpdateTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV105TFView_New_Encounter2view_NE_Status_Sels',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_STATUS_SELS',pic:''},{av:'AV111Pgmname',fld:'vPGMNAME',pic:'',hsh:true},{av:'AV87IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'Ddo_view_new_encounter2view_ne_status_Activeeventkey',ctrl:'DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_STATUS',prop:'ActiveEventKey'},{av:'Ddo_view_new_encounter2view_ne_status_Selectedvalue_get',ctrl:'DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_STATUS',prop:'SelectedValue_get'}]");
         setEventMetadata("DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_STATUS.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_view_new_encounter2view_ne_status_Sortedstatus',ctrl:'DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_STATUS',prop:'SortedStatus'},{av:'AV105TFView_New_Encounter2view_NE_Status_Sels',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_STATUS_SELS',pic:''},{av:'Ddo_view_new_encounter2view_ne_encounterid_Sortedstatus',ctrl:'DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID',prop:'SortedStatus'},{av:'Ddo_view_new_encounter2view_ne_information_patientno_Sortedstatus',ctrl:'DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO',prop:'SortedStatus'},{av:'Ddo_view_new_encounter2view_ne_departmentadm_Sortedstatus',ctrl:'DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM',prop:'SortedStatus'},{av:'Ddo_view_new_encounter2view_ne_enctype_Sortedstatus',ctrl:'DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE',prop:'SortedStatus'},{av:'Ddo_view_new_encounter2view_ne_israndapprove_Sortedstatus',ctrl:'DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE',prop:'SortedStatus'},{av:'Ddo_view_new_encounter2view_ne_israndrecheck_Sortedstatus',ctrl:'DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK',prop:'SortedStatus'},{av:'Ddo_view_new_encounter2view_ne_isupdate_Sortedstatus',ctrl:'DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE',prop:'SortedStatus'},{av:'AV87IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'AV93tAllBR_EncounterID',fld:'vTALLBR_ENCOUNTERID',pic:''},{av:'AV24View_New_Encounter2view_NE_EncounterIDTitleFilterData',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV66View_New_Encounter2view_NE_Information_PatientNoTitleFilterData',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV32View_New_Encounter2view_NE_DepartmentadmTitleFilterData',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADMTITLEFILTERDATA',pic:''},{av:'AV28View_New_Encounter2view_NE_ENCTypeTitleFilterData',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPETITLEFILTERDATA',pic:''},{av:'AV42View_New_Encounter2view_NE_StatusTitleFilterData',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_STATUSTITLEFILTERDATA',pic:''},{av:'AV50View_New_Encounter2view_NE_IsRandApproveTitleFilterData',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVETITLEFILTERDATA',pic:''},{av:'AV46View_New_Encounter2view_NE_IsRandRecheckTitleFilterData',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECKTITLEFILTERDATA',pic:''},{av:'AV54View_New_Encounter2view_NE_IsUpdateTitleFilterData',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATETITLEFILTERDATA',pic:''},{av:'edtView_New_Encounter2view_NE_EncounterID_Titleformat',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID',prop:'Titleformat'},{av:'edtView_New_Encounter2view_NE_EncounterID_Title',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID',prop:'Title'},{av:'edtView_New_Encounter2view_NE_Information_PatientNo_Titleformat',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtView_New_Encounter2view_NE_Information_PatientNo_Title',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtView_New_Encounter2view_NE_Departmentadm_Titleformat',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM',prop:'Titleformat'},{av:'edtView_New_Encounter2view_NE_Departmentadm_Title',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM',prop:'Title'},{av:'edtView_New_Encounter2view_NE_ENCType_Titleformat',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE',prop:'Titleformat'},{av:'edtView_New_Encounter2view_NE_ENCType_Title',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE',prop:'Title'},{av:'cmbView_New_Encounter2view_NE_Status'},{av:'chkView_New_Encounter2view_NE_IsRandApprove_Titleformat',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE',prop:'Titleformat'},{av:'chkView_New_Encounter2view_NE_IsRandApprove.Title.Text',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE',prop:'Title'},{av:'chkView_New_Encounter2view_NE_IsRandRecheck_Titleformat',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK',prop:'Titleformat'},{av:'chkView_New_Encounter2view_NE_IsRandRecheck.Title.Text',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK',prop:'Title'},{av:'chkView_New_Encounter2view_NE_IsUpdate_Titleformat',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE',prop:'Titleformat'},{av:'chkView_New_Encounter2view_NE_IsUpdate.Title.Text',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE',prop:'Title'},{av:'AV72GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV73GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{av:'edtavDeleteencounter_Visible',ctrl:'vDELETEENCOUNTER',prop:'Visible'},{ctrl:'BTNBATCHAPPROVE',prop:'Visible'},{ctrl:'BTNBATCHRECHECK',prop:'Visible'}]}");
         setEventMetadata("DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE.ONOPTIONCLICKED","{handler:'E18AL2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV15BR_Information_PatientNo',fld:'vBR_INFORMATION_PATIENTNO',pic:''},{av:'AV20sBR_EncounterID',fld:'vSBR_ENCOUNTERID',pic:''},{av:'AV21view_NE_AdmitDate',fld:'vVIEW_NE_ADMITDATE',pic:''},{av:'AV22endview_NE_AdmitDate',fld:'vENDVIEW_NE_ADMITDATE',pic:''},{av:'cmbavTview_ne_status'},{av:'AV23tview_NE_Status',fld:'vTVIEW_NE_STATUS',pic:'ZZZ9'},{av:'AV101View_New_Encounter2view_NE_IsRandApprove',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE',pic:''},{av:'AV102View_New_Encounter2view_NE_IsRandRecheck',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK',pic:''},{av:'AV103View_New_Encounter2view_NE_IsUpdate',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV25TFView_New_Encounter2view_NE_EncounterID',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZ9'},{av:'AV26TFView_New_Encounter2view_NE_EncounterID_To',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZ9'},{av:'AV67TFView_New_Encounter2view_NE_Information_PatientNo',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO',pic:''},{av:'AV68TFView_New_Encounter2view_NE_Information_PatientNo_Sel',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV33TFView_New_Encounter2view_NE_Departmentadm',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM',pic:''},{av:'AV34TFView_New_Encounter2view_NE_Departmentadm_Sel',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM_SEL',pic:''},{av:'AV29TFView_New_Encounter2view_NE_ENCType',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE',pic:''},{av:'AV30TFView_New_Encounter2view_NE_ENCType_Sel',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE_SEL',pic:''},{av:'AV106TFView_New_Encounter2view_NE_IsRandApprove_Sel',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE_SEL',pic:'9'},{av:'AV107TFView_New_Encounter2view_NE_IsRandRecheck_Sel',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK_SEL',pic:'9'},{av:'AV108TFView_New_Encounter2view_NE_IsUpdate_Sel',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE_SEL',pic:'9'},{av:'AV85tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'AV27ddo_View_New_Encounter2view_NE_EncounterIDTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV69ddo_View_New_Encounter2view_NE_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_View_New_Encounter2view_NE_DepartmentadmTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_View_New_Encounter2view_NE_ENCTypeTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_View_New_Encounter2view_NE_StatusTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_View_New_Encounter2view_NE_IsRandApproveTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_View_New_Encounter2view_NE_IsRandRecheckTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECKTITLECONTROLIDTOREPLACE',pic:''},{av:'AV57ddo_View_New_Encounter2view_NE_IsUpdateTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV105TFView_New_Encounter2view_NE_Status_Sels',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_STATUS_SELS',pic:''},{av:'AV111Pgmname',fld:'vPGMNAME',pic:'',hsh:true},{av:'AV87IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'Ddo_view_new_encounter2view_ne_israndapprove_Activeeventkey',ctrl:'DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE',prop:'ActiveEventKey'},{av:'Ddo_view_new_encounter2view_ne_israndapprove_Selectedvalue_get',ctrl:'DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE',prop:'SelectedValue_get'}]");
         setEventMetadata("DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_view_new_encounter2view_ne_israndapprove_Sortedstatus',ctrl:'DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE',prop:'SortedStatus'},{av:'AV106TFView_New_Encounter2view_NE_IsRandApprove_Sel',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE_SEL',pic:'9'},{av:'Ddo_view_new_encounter2view_ne_encounterid_Sortedstatus',ctrl:'DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID',prop:'SortedStatus'},{av:'Ddo_view_new_encounter2view_ne_information_patientno_Sortedstatus',ctrl:'DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO',prop:'SortedStatus'},{av:'Ddo_view_new_encounter2view_ne_departmentadm_Sortedstatus',ctrl:'DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM',prop:'SortedStatus'},{av:'Ddo_view_new_encounter2view_ne_enctype_Sortedstatus',ctrl:'DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE',prop:'SortedStatus'},{av:'Ddo_view_new_encounter2view_ne_status_Sortedstatus',ctrl:'DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_STATUS',prop:'SortedStatus'},{av:'Ddo_view_new_encounter2view_ne_israndrecheck_Sortedstatus',ctrl:'DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK',prop:'SortedStatus'},{av:'Ddo_view_new_encounter2view_ne_isupdate_Sortedstatus',ctrl:'DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE',prop:'SortedStatus'},{av:'AV87IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'AV93tAllBR_EncounterID',fld:'vTALLBR_ENCOUNTERID',pic:''},{av:'AV24View_New_Encounter2view_NE_EncounterIDTitleFilterData',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV66View_New_Encounter2view_NE_Information_PatientNoTitleFilterData',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV32View_New_Encounter2view_NE_DepartmentadmTitleFilterData',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADMTITLEFILTERDATA',pic:''},{av:'AV28View_New_Encounter2view_NE_ENCTypeTitleFilterData',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPETITLEFILTERDATA',pic:''},{av:'AV42View_New_Encounter2view_NE_StatusTitleFilterData',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_STATUSTITLEFILTERDATA',pic:''},{av:'AV50View_New_Encounter2view_NE_IsRandApproveTitleFilterData',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVETITLEFILTERDATA',pic:''},{av:'AV46View_New_Encounter2view_NE_IsRandRecheckTitleFilterData',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECKTITLEFILTERDATA',pic:''},{av:'AV54View_New_Encounter2view_NE_IsUpdateTitleFilterData',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATETITLEFILTERDATA',pic:''},{av:'edtView_New_Encounter2view_NE_EncounterID_Titleformat',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID',prop:'Titleformat'},{av:'edtView_New_Encounter2view_NE_EncounterID_Title',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID',prop:'Title'},{av:'edtView_New_Encounter2view_NE_Information_PatientNo_Titleformat',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtView_New_Encounter2view_NE_Information_PatientNo_Title',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtView_New_Encounter2view_NE_Departmentadm_Titleformat',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM',prop:'Titleformat'},{av:'edtView_New_Encounter2view_NE_Departmentadm_Title',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM',prop:'Title'},{av:'edtView_New_Encounter2view_NE_ENCType_Titleformat',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE',prop:'Titleformat'},{av:'edtView_New_Encounter2view_NE_ENCType_Title',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE',prop:'Title'},{av:'cmbView_New_Encounter2view_NE_Status'},{av:'chkView_New_Encounter2view_NE_IsRandApprove_Titleformat',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE',prop:'Titleformat'},{av:'chkView_New_Encounter2view_NE_IsRandApprove.Title.Text',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE',prop:'Title'},{av:'chkView_New_Encounter2view_NE_IsRandRecheck_Titleformat',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK',prop:'Titleformat'},{av:'chkView_New_Encounter2view_NE_IsRandRecheck.Title.Text',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK',prop:'Title'},{av:'chkView_New_Encounter2view_NE_IsUpdate_Titleformat',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE',prop:'Titleformat'},{av:'chkView_New_Encounter2view_NE_IsUpdate.Title.Text',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE',prop:'Title'},{av:'AV72GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV73GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{av:'edtavDeleteencounter_Visible',ctrl:'vDELETEENCOUNTER',prop:'Visible'},{ctrl:'BTNBATCHAPPROVE',prop:'Visible'},{ctrl:'BTNBATCHRECHECK',prop:'Visible'}]}");
         setEventMetadata("DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK.ONOPTIONCLICKED","{handler:'E19AL2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV15BR_Information_PatientNo',fld:'vBR_INFORMATION_PATIENTNO',pic:''},{av:'AV20sBR_EncounterID',fld:'vSBR_ENCOUNTERID',pic:''},{av:'AV21view_NE_AdmitDate',fld:'vVIEW_NE_ADMITDATE',pic:''},{av:'AV22endview_NE_AdmitDate',fld:'vENDVIEW_NE_ADMITDATE',pic:''},{av:'cmbavTview_ne_status'},{av:'AV23tview_NE_Status',fld:'vTVIEW_NE_STATUS',pic:'ZZZ9'},{av:'AV101View_New_Encounter2view_NE_IsRandApprove',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE',pic:''},{av:'AV102View_New_Encounter2view_NE_IsRandRecheck',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK',pic:''},{av:'AV103View_New_Encounter2view_NE_IsUpdate',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV25TFView_New_Encounter2view_NE_EncounterID',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZ9'},{av:'AV26TFView_New_Encounter2view_NE_EncounterID_To',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZ9'},{av:'AV67TFView_New_Encounter2view_NE_Information_PatientNo',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO',pic:''},{av:'AV68TFView_New_Encounter2view_NE_Information_PatientNo_Sel',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV33TFView_New_Encounter2view_NE_Departmentadm',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM',pic:''},{av:'AV34TFView_New_Encounter2view_NE_Departmentadm_Sel',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM_SEL',pic:''},{av:'AV29TFView_New_Encounter2view_NE_ENCType',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE',pic:''},{av:'AV30TFView_New_Encounter2view_NE_ENCType_Sel',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE_SEL',pic:''},{av:'AV106TFView_New_Encounter2view_NE_IsRandApprove_Sel',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE_SEL',pic:'9'},{av:'AV107TFView_New_Encounter2view_NE_IsRandRecheck_Sel',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK_SEL',pic:'9'},{av:'AV108TFView_New_Encounter2view_NE_IsUpdate_Sel',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE_SEL',pic:'9'},{av:'AV85tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'AV27ddo_View_New_Encounter2view_NE_EncounterIDTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV69ddo_View_New_Encounter2view_NE_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_View_New_Encounter2view_NE_DepartmentadmTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_View_New_Encounter2view_NE_ENCTypeTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_View_New_Encounter2view_NE_StatusTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_View_New_Encounter2view_NE_IsRandApproveTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_View_New_Encounter2view_NE_IsRandRecheckTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECKTITLECONTROLIDTOREPLACE',pic:''},{av:'AV57ddo_View_New_Encounter2view_NE_IsUpdateTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV105TFView_New_Encounter2view_NE_Status_Sels',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_STATUS_SELS',pic:''},{av:'AV111Pgmname',fld:'vPGMNAME',pic:'',hsh:true},{av:'AV87IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'Ddo_view_new_encounter2view_ne_israndrecheck_Activeeventkey',ctrl:'DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK',prop:'ActiveEventKey'},{av:'Ddo_view_new_encounter2view_ne_israndrecheck_Selectedvalue_get',ctrl:'DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK',prop:'SelectedValue_get'}]");
         setEventMetadata("DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_view_new_encounter2view_ne_israndrecheck_Sortedstatus',ctrl:'DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK',prop:'SortedStatus'},{av:'AV107TFView_New_Encounter2view_NE_IsRandRecheck_Sel',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK_SEL',pic:'9'},{av:'Ddo_view_new_encounter2view_ne_encounterid_Sortedstatus',ctrl:'DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID',prop:'SortedStatus'},{av:'Ddo_view_new_encounter2view_ne_information_patientno_Sortedstatus',ctrl:'DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO',prop:'SortedStatus'},{av:'Ddo_view_new_encounter2view_ne_departmentadm_Sortedstatus',ctrl:'DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM',prop:'SortedStatus'},{av:'Ddo_view_new_encounter2view_ne_enctype_Sortedstatus',ctrl:'DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE',prop:'SortedStatus'},{av:'Ddo_view_new_encounter2view_ne_status_Sortedstatus',ctrl:'DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_STATUS',prop:'SortedStatus'},{av:'Ddo_view_new_encounter2view_ne_israndapprove_Sortedstatus',ctrl:'DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE',prop:'SortedStatus'},{av:'Ddo_view_new_encounter2view_ne_isupdate_Sortedstatus',ctrl:'DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE',prop:'SortedStatus'},{av:'AV87IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'AV93tAllBR_EncounterID',fld:'vTALLBR_ENCOUNTERID',pic:''},{av:'AV24View_New_Encounter2view_NE_EncounterIDTitleFilterData',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV66View_New_Encounter2view_NE_Information_PatientNoTitleFilterData',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV32View_New_Encounter2view_NE_DepartmentadmTitleFilterData',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADMTITLEFILTERDATA',pic:''},{av:'AV28View_New_Encounter2view_NE_ENCTypeTitleFilterData',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPETITLEFILTERDATA',pic:''},{av:'AV42View_New_Encounter2view_NE_StatusTitleFilterData',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_STATUSTITLEFILTERDATA',pic:''},{av:'AV50View_New_Encounter2view_NE_IsRandApproveTitleFilterData',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVETITLEFILTERDATA',pic:''},{av:'AV46View_New_Encounter2view_NE_IsRandRecheckTitleFilterData',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECKTITLEFILTERDATA',pic:''},{av:'AV54View_New_Encounter2view_NE_IsUpdateTitleFilterData',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATETITLEFILTERDATA',pic:''},{av:'edtView_New_Encounter2view_NE_EncounterID_Titleformat',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID',prop:'Titleformat'},{av:'edtView_New_Encounter2view_NE_EncounterID_Title',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID',prop:'Title'},{av:'edtView_New_Encounter2view_NE_Information_PatientNo_Titleformat',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtView_New_Encounter2view_NE_Information_PatientNo_Title',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtView_New_Encounter2view_NE_Departmentadm_Titleformat',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM',prop:'Titleformat'},{av:'edtView_New_Encounter2view_NE_Departmentadm_Title',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM',prop:'Title'},{av:'edtView_New_Encounter2view_NE_ENCType_Titleformat',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE',prop:'Titleformat'},{av:'edtView_New_Encounter2view_NE_ENCType_Title',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE',prop:'Title'},{av:'cmbView_New_Encounter2view_NE_Status'},{av:'chkView_New_Encounter2view_NE_IsRandApprove_Titleformat',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE',prop:'Titleformat'},{av:'chkView_New_Encounter2view_NE_IsRandApprove.Title.Text',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE',prop:'Title'},{av:'chkView_New_Encounter2view_NE_IsRandRecheck_Titleformat',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK',prop:'Titleformat'},{av:'chkView_New_Encounter2view_NE_IsRandRecheck.Title.Text',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK',prop:'Title'},{av:'chkView_New_Encounter2view_NE_IsUpdate_Titleformat',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE',prop:'Titleformat'},{av:'chkView_New_Encounter2view_NE_IsUpdate.Title.Text',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE',prop:'Title'},{av:'AV72GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV73GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{av:'edtavDeleteencounter_Visible',ctrl:'vDELETEENCOUNTER',prop:'Visible'},{ctrl:'BTNBATCHAPPROVE',prop:'Visible'},{ctrl:'BTNBATCHRECHECK',prop:'Visible'}]}");
         setEventMetadata("DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE.ONOPTIONCLICKED","{handler:'E20AL2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV15BR_Information_PatientNo',fld:'vBR_INFORMATION_PATIENTNO',pic:''},{av:'AV20sBR_EncounterID',fld:'vSBR_ENCOUNTERID',pic:''},{av:'AV21view_NE_AdmitDate',fld:'vVIEW_NE_ADMITDATE',pic:''},{av:'AV22endview_NE_AdmitDate',fld:'vENDVIEW_NE_ADMITDATE',pic:''},{av:'cmbavTview_ne_status'},{av:'AV23tview_NE_Status',fld:'vTVIEW_NE_STATUS',pic:'ZZZ9'},{av:'AV101View_New_Encounter2view_NE_IsRandApprove',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE',pic:''},{av:'AV102View_New_Encounter2view_NE_IsRandRecheck',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK',pic:''},{av:'AV103View_New_Encounter2view_NE_IsUpdate',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV25TFView_New_Encounter2view_NE_EncounterID',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZ9'},{av:'AV26TFView_New_Encounter2view_NE_EncounterID_To',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZ9'},{av:'AV67TFView_New_Encounter2view_NE_Information_PatientNo',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO',pic:''},{av:'AV68TFView_New_Encounter2view_NE_Information_PatientNo_Sel',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV33TFView_New_Encounter2view_NE_Departmentadm',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM',pic:''},{av:'AV34TFView_New_Encounter2view_NE_Departmentadm_Sel',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM_SEL',pic:''},{av:'AV29TFView_New_Encounter2view_NE_ENCType',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE',pic:''},{av:'AV30TFView_New_Encounter2view_NE_ENCType_Sel',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE_SEL',pic:''},{av:'AV106TFView_New_Encounter2view_NE_IsRandApprove_Sel',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE_SEL',pic:'9'},{av:'AV107TFView_New_Encounter2view_NE_IsRandRecheck_Sel',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK_SEL',pic:'9'},{av:'AV108TFView_New_Encounter2view_NE_IsUpdate_Sel',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE_SEL',pic:'9'},{av:'AV85tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'AV27ddo_View_New_Encounter2view_NE_EncounterIDTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV69ddo_View_New_Encounter2view_NE_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_View_New_Encounter2view_NE_DepartmentadmTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_View_New_Encounter2view_NE_ENCTypeTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_View_New_Encounter2view_NE_StatusTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_View_New_Encounter2view_NE_IsRandApproveTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_View_New_Encounter2view_NE_IsRandRecheckTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECKTITLECONTROLIDTOREPLACE',pic:''},{av:'AV57ddo_View_New_Encounter2view_NE_IsUpdateTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV105TFView_New_Encounter2view_NE_Status_Sels',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_STATUS_SELS',pic:''},{av:'AV111Pgmname',fld:'vPGMNAME',pic:'',hsh:true},{av:'AV87IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'Ddo_view_new_encounter2view_ne_isupdate_Activeeventkey',ctrl:'DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE',prop:'ActiveEventKey'},{av:'Ddo_view_new_encounter2view_ne_isupdate_Selectedvalue_get',ctrl:'DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE',prop:'SelectedValue_get'}]");
         setEventMetadata("DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_view_new_encounter2view_ne_isupdate_Sortedstatus',ctrl:'DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE',prop:'SortedStatus'},{av:'AV108TFView_New_Encounter2view_NE_IsUpdate_Sel',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE_SEL',pic:'9'},{av:'Ddo_view_new_encounter2view_ne_encounterid_Sortedstatus',ctrl:'DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID',prop:'SortedStatus'},{av:'Ddo_view_new_encounter2view_ne_information_patientno_Sortedstatus',ctrl:'DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO',prop:'SortedStatus'},{av:'Ddo_view_new_encounter2view_ne_departmentadm_Sortedstatus',ctrl:'DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM',prop:'SortedStatus'},{av:'Ddo_view_new_encounter2view_ne_enctype_Sortedstatus',ctrl:'DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE',prop:'SortedStatus'},{av:'Ddo_view_new_encounter2view_ne_status_Sortedstatus',ctrl:'DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_STATUS',prop:'SortedStatus'},{av:'Ddo_view_new_encounter2view_ne_israndapprove_Sortedstatus',ctrl:'DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE',prop:'SortedStatus'},{av:'Ddo_view_new_encounter2view_ne_israndrecheck_Sortedstatus',ctrl:'DDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK',prop:'SortedStatus'},{av:'AV87IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'AV93tAllBR_EncounterID',fld:'vTALLBR_ENCOUNTERID',pic:''},{av:'AV24View_New_Encounter2view_NE_EncounterIDTitleFilterData',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV66View_New_Encounter2view_NE_Information_PatientNoTitleFilterData',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV32View_New_Encounter2view_NE_DepartmentadmTitleFilterData',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADMTITLEFILTERDATA',pic:''},{av:'AV28View_New_Encounter2view_NE_ENCTypeTitleFilterData',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPETITLEFILTERDATA',pic:''},{av:'AV42View_New_Encounter2view_NE_StatusTitleFilterData',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_STATUSTITLEFILTERDATA',pic:''},{av:'AV50View_New_Encounter2view_NE_IsRandApproveTitleFilterData',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVETITLEFILTERDATA',pic:''},{av:'AV46View_New_Encounter2view_NE_IsRandRecheckTitleFilterData',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECKTITLEFILTERDATA',pic:''},{av:'AV54View_New_Encounter2view_NE_IsUpdateTitleFilterData',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATETITLEFILTERDATA',pic:''},{av:'edtView_New_Encounter2view_NE_EncounterID_Titleformat',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID',prop:'Titleformat'},{av:'edtView_New_Encounter2view_NE_EncounterID_Title',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID',prop:'Title'},{av:'edtView_New_Encounter2view_NE_Information_PatientNo_Titleformat',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtView_New_Encounter2view_NE_Information_PatientNo_Title',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtView_New_Encounter2view_NE_Departmentadm_Titleformat',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM',prop:'Titleformat'},{av:'edtView_New_Encounter2view_NE_Departmentadm_Title',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM',prop:'Title'},{av:'edtView_New_Encounter2view_NE_ENCType_Titleformat',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE',prop:'Titleformat'},{av:'edtView_New_Encounter2view_NE_ENCType_Title',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE',prop:'Title'},{av:'cmbView_New_Encounter2view_NE_Status'},{av:'chkView_New_Encounter2view_NE_IsRandApprove_Titleformat',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE',prop:'Titleformat'},{av:'chkView_New_Encounter2view_NE_IsRandApprove.Title.Text',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE',prop:'Title'},{av:'chkView_New_Encounter2view_NE_IsRandRecheck_Titleformat',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK',prop:'Titleformat'},{av:'chkView_New_Encounter2view_NE_IsRandRecheck.Title.Text',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK',prop:'Title'},{av:'chkView_New_Encounter2view_NE_IsUpdate_Titleformat',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE',prop:'Titleformat'},{av:'chkView_New_Encounter2view_NE_IsUpdate.Title.Text',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE',prop:'Title'},{av:'AV72GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV73GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{av:'edtavDeleteencounter_Visible',ctrl:'vDELETEENCOUNTER',prop:'Visible'},{ctrl:'BTNBATCHAPPROVE',prop:'Visible'},{ctrl:'BTNBATCHRECHECK',prop:'Visible'}]}");
         setEventMetadata("GRID.LOAD","{handler:'E26AL2',iparms:[{av:'A601View_New_Encounter2view_NE_Information_PatientNo',fld:'VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO',pic:''},{av:'A594View_New_Encounter2view_NE_AdmitDate',fld:'VIEW_NEW_ENCOUNTER2VIEW_NE_ADMITDATE',pic:''}]");
         setEventMetadata("GRID.LOAD",",oparms:[{av:'AV78PatientNo',fld:'vPATIENTNO',pic:''},{av:'AV79AdmitDate',fld:'vADMITDATE',pic:''},{av:'AV80deleteEncounter',fld:'vDELETEENCOUNTER',pic:''},{av:'edtavDeleteencounter_Tooltiptext',ctrl:'vDELETEENCOUNTER',prop:'Tooltiptext'}]}");
         setEventMetadata("'DODELETEENCOUNTER'","{handler:'E32AL2',iparms:[{av:'A591View_New_Encounter2view_NE_EncounterID',fld:'VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZ9',hsh:true}]");
         setEventMetadata("'DODELETEENCOUNTER'",",oparms:[{av:'AV82View_New_Encounter2view_NE_EncounterID_Selected',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID_SELECTED',pic:'ZZZZZZZZZZZZZZZZZ9'}]}");
         setEventMetadata("'DOBATCHAPPROVE'","{handler:'E30AL1',iparms:[]");
         setEventMetadata("'DOBATCHAPPROVE'",",oparms:[]}");
         setEventMetadata("DVELOP_CONFIRMPANEL_BATCHAPPROVE.CLOSE","{handler:'E21AL2',iparms:[{av:'Dvelop_confirmpanel_batchapprove_Result',ctrl:'DVELOP_CONFIRMPANEL_BATCHAPPROVE',prop:'Result'},{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV15BR_Information_PatientNo',fld:'vBR_INFORMATION_PATIENTNO',pic:''},{av:'AV20sBR_EncounterID',fld:'vSBR_ENCOUNTERID',pic:''},{av:'AV21view_NE_AdmitDate',fld:'vVIEW_NE_ADMITDATE',pic:''},{av:'AV22endview_NE_AdmitDate',fld:'vENDVIEW_NE_ADMITDATE',pic:''},{av:'cmbavTview_ne_status'},{av:'AV23tview_NE_Status',fld:'vTVIEW_NE_STATUS',pic:'ZZZ9'},{av:'AV101View_New_Encounter2view_NE_IsRandApprove',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE',pic:''},{av:'AV102View_New_Encounter2view_NE_IsRandRecheck',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK',pic:''},{av:'AV103View_New_Encounter2view_NE_IsUpdate',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV25TFView_New_Encounter2view_NE_EncounterID',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZ9'},{av:'AV26TFView_New_Encounter2view_NE_EncounterID_To',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZ9'},{av:'AV67TFView_New_Encounter2view_NE_Information_PatientNo',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO',pic:''},{av:'AV68TFView_New_Encounter2view_NE_Information_PatientNo_Sel',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV33TFView_New_Encounter2view_NE_Departmentadm',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM',pic:''},{av:'AV34TFView_New_Encounter2view_NE_Departmentadm_Sel',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM_SEL',pic:''},{av:'AV29TFView_New_Encounter2view_NE_ENCType',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE',pic:''},{av:'AV30TFView_New_Encounter2view_NE_ENCType_Sel',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE_SEL',pic:''},{av:'AV106TFView_New_Encounter2view_NE_IsRandApprove_Sel',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE_SEL',pic:'9'},{av:'AV107TFView_New_Encounter2view_NE_IsRandRecheck_Sel',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK_SEL',pic:'9'},{av:'AV108TFView_New_Encounter2view_NE_IsUpdate_Sel',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE_SEL',pic:'9'},{av:'AV85tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'AV27ddo_View_New_Encounter2view_NE_EncounterIDTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV69ddo_View_New_Encounter2view_NE_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_View_New_Encounter2view_NE_DepartmentadmTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_View_New_Encounter2view_NE_ENCTypeTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_View_New_Encounter2view_NE_StatusTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_View_New_Encounter2view_NE_IsRandApproveTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_View_New_Encounter2view_NE_IsRandRecheckTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECKTITLECONTROLIDTOREPLACE',pic:''},{av:'AV57ddo_View_New_Encounter2view_NE_IsUpdateTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV105TFView_New_Encounter2view_NE_Status_Sels',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_STATUS_SELS',pic:''},{av:'AV111Pgmname',fld:'vPGMNAME',pic:'',hsh:true},{av:'AV87IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'AV93tAllBR_EncounterID',fld:'vTALLBR_ENCOUNTERID',pic:''}]");
         setEventMetadata("DVELOP_CONFIRMPANEL_BATCHAPPROVE.CLOSE",",oparms:[{av:'AV87IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'AV93tAllBR_EncounterID',fld:'vTALLBR_ENCOUNTERID',pic:''},{av:'AV24View_New_Encounter2view_NE_EncounterIDTitleFilterData',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV66View_New_Encounter2view_NE_Information_PatientNoTitleFilterData',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV32View_New_Encounter2view_NE_DepartmentadmTitleFilterData',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADMTITLEFILTERDATA',pic:''},{av:'AV28View_New_Encounter2view_NE_ENCTypeTitleFilterData',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPETITLEFILTERDATA',pic:''},{av:'AV42View_New_Encounter2view_NE_StatusTitleFilterData',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_STATUSTITLEFILTERDATA',pic:''},{av:'AV50View_New_Encounter2view_NE_IsRandApproveTitleFilterData',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVETITLEFILTERDATA',pic:''},{av:'AV46View_New_Encounter2view_NE_IsRandRecheckTitleFilterData',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECKTITLEFILTERDATA',pic:''},{av:'AV54View_New_Encounter2view_NE_IsUpdateTitleFilterData',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATETITLEFILTERDATA',pic:''},{av:'edtView_New_Encounter2view_NE_EncounterID_Titleformat',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID',prop:'Titleformat'},{av:'edtView_New_Encounter2view_NE_EncounterID_Title',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID',prop:'Title'},{av:'edtView_New_Encounter2view_NE_Information_PatientNo_Titleformat',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtView_New_Encounter2view_NE_Information_PatientNo_Title',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtView_New_Encounter2view_NE_Departmentadm_Titleformat',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM',prop:'Titleformat'},{av:'edtView_New_Encounter2view_NE_Departmentadm_Title',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM',prop:'Title'},{av:'edtView_New_Encounter2view_NE_ENCType_Titleformat',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE',prop:'Titleformat'},{av:'edtView_New_Encounter2view_NE_ENCType_Title',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE',prop:'Title'},{av:'cmbView_New_Encounter2view_NE_Status'},{av:'chkView_New_Encounter2view_NE_IsRandApprove_Titleformat',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE',prop:'Titleformat'},{av:'chkView_New_Encounter2view_NE_IsRandApprove.Title.Text',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE',prop:'Title'},{av:'chkView_New_Encounter2view_NE_IsRandRecheck_Titleformat',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK',prop:'Titleformat'},{av:'chkView_New_Encounter2view_NE_IsRandRecheck.Title.Text',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK',prop:'Title'},{av:'chkView_New_Encounter2view_NE_IsUpdate_Titleformat',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE',prop:'Titleformat'},{av:'chkView_New_Encounter2view_NE_IsUpdate.Title.Text',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE',prop:'Title'},{av:'AV72GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV73GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{av:'edtavDeleteencounter_Visible',ctrl:'vDELETEENCOUNTER',prop:'Visible'},{ctrl:'BTNBATCHAPPROVE',prop:'Visible'},{ctrl:'BTNBATCHRECHECK',prop:'Visible'}]}");
         setEventMetadata("'DOBATCHRECHECK'","{handler:'E31AL1',iparms:[]");
         setEventMetadata("'DOBATCHRECHECK'",",oparms:[]}");
         setEventMetadata("DVELOP_CONFIRMPANEL_BATCHRECHECK.CLOSE","{handler:'E22AL2',iparms:[{av:'Dvelop_confirmpanel_batchrecheck_Result',ctrl:'DVELOP_CONFIRMPANEL_BATCHRECHECK',prop:'Result'},{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV15BR_Information_PatientNo',fld:'vBR_INFORMATION_PATIENTNO',pic:''},{av:'AV20sBR_EncounterID',fld:'vSBR_ENCOUNTERID',pic:''},{av:'AV21view_NE_AdmitDate',fld:'vVIEW_NE_ADMITDATE',pic:''},{av:'AV22endview_NE_AdmitDate',fld:'vENDVIEW_NE_ADMITDATE',pic:''},{av:'cmbavTview_ne_status'},{av:'AV23tview_NE_Status',fld:'vTVIEW_NE_STATUS',pic:'ZZZ9'},{av:'AV101View_New_Encounter2view_NE_IsRandApprove',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE',pic:''},{av:'AV102View_New_Encounter2view_NE_IsRandRecheck',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK',pic:''},{av:'AV103View_New_Encounter2view_NE_IsUpdate',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV25TFView_New_Encounter2view_NE_EncounterID',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZ9'},{av:'AV26TFView_New_Encounter2view_NE_EncounterID_To',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZ9'},{av:'AV67TFView_New_Encounter2view_NE_Information_PatientNo',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO',pic:''},{av:'AV68TFView_New_Encounter2view_NE_Information_PatientNo_Sel',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV33TFView_New_Encounter2view_NE_Departmentadm',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM',pic:''},{av:'AV34TFView_New_Encounter2view_NE_Departmentadm_Sel',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM_SEL',pic:''},{av:'AV29TFView_New_Encounter2view_NE_ENCType',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE',pic:''},{av:'AV30TFView_New_Encounter2view_NE_ENCType_Sel',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE_SEL',pic:''},{av:'AV106TFView_New_Encounter2view_NE_IsRandApprove_Sel',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE_SEL',pic:'9'},{av:'AV107TFView_New_Encounter2view_NE_IsRandRecheck_Sel',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK_SEL',pic:'9'},{av:'AV108TFView_New_Encounter2view_NE_IsUpdate_Sel',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE_SEL',pic:'9'},{av:'AV85tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'AV27ddo_View_New_Encounter2view_NE_EncounterIDTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV69ddo_View_New_Encounter2view_NE_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_View_New_Encounter2view_NE_DepartmentadmTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_View_New_Encounter2view_NE_ENCTypeTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_View_New_Encounter2view_NE_StatusTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_View_New_Encounter2view_NE_IsRandApproveTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_View_New_Encounter2view_NE_IsRandRecheckTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECKTITLECONTROLIDTOREPLACE',pic:''},{av:'AV57ddo_View_New_Encounter2view_NE_IsUpdateTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV105TFView_New_Encounter2view_NE_Status_Sels',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_STATUS_SELS',pic:''},{av:'AV111Pgmname',fld:'vPGMNAME',pic:'',hsh:true},{av:'AV87IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'AV93tAllBR_EncounterID',fld:'vTALLBR_ENCOUNTERID',pic:''}]");
         setEventMetadata("DVELOP_CONFIRMPANEL_BATCHRECHECK.CLOSE",",oparms:[{av:'AV87IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'AV93tAllBR_EncounterID',fld:'vTALLBR_ENCOUNTERID',pic:''},{av:'AV24View_New_Encounter2view_NE_EncounterIDTitleFilterData',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV66View_New_Encounter2view_NE_Information_PatientNoTitleFilterData',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV32View_New_Encounter2view_NE_DepartmentadmTitleFilterData',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADMTITLEFILTERDATA',pic:''},{av:'AV28View_New_Encounter2view_NE_ENCTypeTitleFilterData',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPETITLEFILTERDATA',pic:''},{av:'AV42View_New_Encounter2view_NE_StatusTitleFilterData',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_STATUSTITLEFILTERDATA',pic:''},{av:'AV50View_New_Encounter2view_NE_IsRandApproveTitleFilterData',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVETITLEFILTERDATA',pic:''},{av:'AV46View_New_Encounter2view_NE_IsRandRecheckTitleFilterData',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECKTITLEFILTERDATA',pic:''},{av:'AV54View_New_Encounter2view_NE_IsUpdateTitleFilterData',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATETITLEFILTERDATA',pic:''},{av:'edtView_New_Encounter2view_NE_EncounterID_Titleformat',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID',prop:'Titleformat'},{av:'edtView_New_Encounter2view_NE_EncounterID_Title',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID',prop:'Title'},{av:'edtView_New_Encounter2view_NE_Information_PatientNo_Titleformat',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtView_New_Encounter2view_NE_Information_PatientNo_Title',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtView_New_Encounter2view_NE_Departmentadm_Titleformat',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM',prop:'Titleformat'},{av:'edtView_New_Encounter2view_NE_Departmentadm_Title',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM',prop:'Title'},{av:'edtView_New_Encounter2view_NE_ENCType_Titleformat',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE',prop:'Titleformat'},{av:'edtView_New_Encounter2view_NE_ENCType_Title',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE',prop:'Title'},{av:'cmbView_New_Encounter2view_NE_Status'},{av:'chkView_New_Encounter2view_NE_IsRandApprove_Titleformat',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE',prop:'Titleformat'},{av:'chkView_New_Encounter2view_NE_IsRandApprove.Title.Text',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE',prop:'Title'},{av:'chkView_New_Encounter2view_NE_IsRandRecheck_Titleformat',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK',prop:'Titleformat'},{av:'chkView_New_Encounter2view_NE_IsRandRecheck.Title.Text',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK',prop:'Title'},{av:'chkView_New_Encounter2view_NE_IsUpdate_Titleformat',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE',prop:'Titleformat'},{av:'chkView_New_Encounter2view_NE_IsUpdate.Title.Text',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE',prop:'Title'},{av:'AV72GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV73GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{av:'edtavDeleteencounter_Visible',ctrl:'vDELETEENCOUNTER',prop:'Visible'},{ctrl:'BTNBATCHAPPROVE',prop:'Visible'},{ctrl:'BTNBATCHRECHECK',prop:'Visible'}]}");
         setEventMetadata("VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO.CLICK","{handler:'E33AL2',iparms:[{av:'A600View_New_Encounter2view_NE_Information_ID',fld:'VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_ID',pic:'ZZZZZZZZZZZZZZZZZ9',hsh:true}]");
         setEventMetadata("VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO.CLICK",",oparms:[]}");
         setEventMetadata("VSBR_ENCOUNTERID.CONTROLVALUECHANGING","{handler:'E23AL2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV15BR_Information_PatientNo',fld:'vBR_INFORMATION_PATIENTNO',pic:''},{av:'AV20sBR_EncounterID',fld:'vSBR_ENCOUNTERID',pic:''},{av:'AV21view_NE_AdmitDate',fld:'vVIEW_NE_ADMITDATE',pic:''},{av:'AV22endview_NE_AdmitDate',fld:'vENDVIEW_NE_ADMITDATE',pic:''},{av:'cmbavTview_ne_status'},{av:'AV23tview_NE_Status',fld:'vTVIEW_NE_STATUS',pic:'ZZZ9'},{av:'AV101View_New_Encounter2view_NE_IsRandApprove',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE',pic:''},{av:'AV102View_New_Encounter2view_NE_IsRandRecheck',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK',pic:''},{av:'AV103View_New_Encounter2view_NE_IsUpdate',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV25TFView_New_Encounter2view_NE_EncounterID',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZ9'},{av:'AV26TFView_New_Encounter2view_NE_EncounterID_To',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZ9'},{av:'AV67TFView_New_Encounter2view_NE_Information_PatientNo',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO',pic:''},{av:'AV68TFView_New_Encounter2view_NE_Information_PatientNo_Sel',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV33TFView_New_Encounter2view_NE_Departmentadm',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM',pic:''},{av:'AV34TFView_New_Encounter2view_NE_Departmentadm_Sel',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM_SEL',pic:''},{av:'AV29TFView_New_Encounter2view_NE_ENCType',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE',pic:''},{av:'AV30TFView_New_Encounter2view_NE_ENCType_Sel',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE_SEL',pic:''},{av:'AV106TFView_New_Encounter2view_NE_IsRandApprove_Sel',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE_SEL',pic:'9'},{av:'AV107TFView_New_Encounter2view_NE_IsRandRecheck_Sel',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK_SEL',pic:'9'},{av:'AV108TFView_New_Encounter2view_NE_IsUpdate_Sel',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE_SEL',pic:'9'},{av:'AV85tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'AV27ddo_View_New_Encounter2view_NE_EncounterIDTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV69ddo_View_New_Encounter2view_NE_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_View_New_Encounter2view_NE_DepartmentadmTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_View_New_Encounter2view_NE_ENCTypeTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_View_New_Encounter2view_NE_StatusTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_View_New_Encounter2view_NE_IsRandApproveTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_View_New_Encounter2view_NE_IsRandRecheckTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECKTITLECONTROLIDTOREPLACE',pic:''},{av:'AV57ddo_View_New_Encounter2view_NE_IsUpdateTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV105TFView_New_Encounter2view_NE_Status_Sels',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_STATUS_SELS',pic:''},{av:'AV111Pgmname',fld:'vPGMNAME',pic:'',hsh:true},{av:'AV87IsInsert',fld:'vISINSERT',pic:'',hsh:true}]");
         setEventMetadata("VSBR_ENCOUNTERID.CONTROLVALUECHANGING",",oparms:[{av:'AV87IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'AV93tAllBR_EncounterID',fld:'vTALLBR_ENCOUNTERID',pic:''},{av:'AV24View_New_Encounter2view_NE_EncounterIDTitleFilterData',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV66View_New_Encounter2view_NE_Information_PatientNoTitleFilterData',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV32View_New_Encounter2view_NE_DepartmentadmTitleFilterData',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADMTITLEFILTERDATA',pic:''},{av:'AV28View_New_Encounter2view_NE_ENCTypeTitleFilterData',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPETITLEFILTERDATA',pic:''},{av:'AV42View_New_Encounter2view_NE_StatusTitleFilterData',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_STATUSTITLEFILTERDATA',pic:''},{av:'AV50View_New_Encounter2view_NE_IsRandApproveTitleFilterData',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVETITLEFILTERDATA',pic:''},{av:'AV46View_New_Encounter2view_NE_IsRandRecheckTitleFilterData',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECKTITLEFILTERDATA',pic:''},{av:'AV54View_New_Encounter2view_NE_IsUpdateTitleFilterData',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATETITLEFILTERDATA',pic:''},{av:'edtView_New_Encounter2view_NE_EncounterID_Titleformat',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID',prop:'Titleformat'},{av:'edtView_New_Encounter2view_NE_EncounterID_Title',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID',prop:'Title'},{av:'edtView_New_Encounter2view_NE_Information_PatientNo_Titleformat',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtView_New_Encounter2view_NE_Information_PatientNo_Title',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtView_New_Encounter2view_NE_Departmentadm_Titleformat',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM',prop:'Titleformat'},{av:'edtView_New_Encounter2view_NE_Departmentadm_Title',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM',prop:'Title'},{av:'edtView_New_Encounter2view_NE_ENCType_Titleformat',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE',prop:'Titleformat'},{av:'edtView_New_Encounter2view_NE_ENCType_Title',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE',prop:'Title'},{av:'cmbView_New_Encounter2view_NE_Status'},{av:'chkView_New_Encounter2view_NE_IsRandApprove_Titleformat',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE',prop:'Titleformat'},{av:'chkView_New_Encounter2view_NE_IsRandApprove.Title.Text',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE',prop:'Title'},{av:'chkView_New_Encounter2view_NE_IsRandRecheck_Titleformat',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK',prop:'Titleformat'},{av:'chkView_New_Encounter2view_NE_IsRandRecheck.Title.Text',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK',prop:'Title'},{av:'chkView_New_Encounter2view_NE_IsUpdate_Titleformat',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE',prop:'Titleformat'},{av:'chkView_New_Encounter2view_NE_IsUpdate.Title.Text',ctrl:'VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE',prop:'Title'},{av:'AV72GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV73GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{av:'edtavDeleteencounter_Visible',ctrl:'vDELETEENCOUNTER',prop:'Visible'},{ctrl:'BTNBATCHAPPROVE',prop:'Visible'},{ctrl:'BTNBATCHRECHECK',prop:'Visible'}]}");
         setEventMetadata("'DOTEST'","{handler:'E27AL2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV15BR_Information_PatientNo',fld:'vBR_INFORMATION_PATIENTNO',pic:''},{av:'AV20sBR_EncounterID',fld:'vSBR_ENCOUNTERID',pic:''},{av:'AV21view_NE_AdmitDate',fld:'vVIEW_NE_ADMITDATE',pic:''},{av:'AV22endview_NE_AdmitDate',fld:'vENDVIEW_NE_ADMITDATE',pic:''},{av:'cmbavTview_ne_status'},{av:'AV23tview_NE_Status',fld:'vTVIEW_NE_STATUS',pic:'ZZZ9'},{av:'AV101View_New_Encounter2view_NE_IsRandApprove',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE',pic:''},{av:'AV102View_New_Encounter2view_NE_IsRandRecheck',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK',pic:''},{av:'AV103View_New_Encounter2view_NE_IsUpdate',fld:'vVIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV25TFView_New_Encounter2view_NE_EncounterID',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZ9'},{av:'AV26TFView_New_Encounter2view_NE_EncounterID_To',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZ9'},{av:'AV67TFView_New_Encounter2view_NE_Information_PatientNo',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO',pic:''},{av:'AV68TFView_New_Encounter2view_NE_Information_PatientNo_Sel',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV33TFView_New_Encounter2view_NE_Departmentadm',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM',pic:''},{av:'AV34TFView_New_Encounter2view_NE_Departmentadm_Sel',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADM_SEL',pic:''},{av:'AV29TFView_New_Encounter2view_NE_ENCType',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE',pic:''},{av:'AV30TFView_New_Encounter2view_NE_ENCType_Sel',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPE_SEL',pic:''},{av:'AV106TFView_New_Encounter2view_NE_IsRandApprove_Sel',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVE_SEL',pic:'9'},{av:'AV107TFView_New_Encounter2view_NE_IsRandRecheck_Sel',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECK_SEL',pic:'9'},{av:'AV108TFView_New_Encounter2view_NE_IsUpdate_Sel',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATE_SEL',pic:'9'},{av:'AV85tCurrentCode',fld:'vTCURRENTCODE',pic:''},{av:'AV27ddo_View_New_Encounter2view_NE_EncounterIDTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV69ddo_View_New_Encounter2view_NE_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_View_New_Encounter2view_NE_DepartmentadmTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_DEPARTMENTADMTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_View_New_Encounter2view_NE_ENCTypeTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_View_New_Encounter2view_NE_StatusTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV53ddo_View_New_Encounter2view_NE_IsRandApproveTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_View_New_Encounter2view_NE_IsRandRecheckTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISRANDRECHECKTITLECONTROLIDTOREPLACE',pic:''},{av:'AV57ddo_View_New_Encounter2view_NE_IsUpdateTitleControlIdToReplace',fld:'vDDO_VIEW_NEW_ENCOUNTER2VIEW_NE_ISUPDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV105TFView_New_Encounter2view_NE_Status_Sels',fld:'vTFVIEW_NEW_ENCOUNTER2VIEW_NE_STATUS_SELS',pic:''},{av:'AV111Pgmname',fld:'vPGMNAME',pic:'',hsh:true},{av:'AV87IsInsert',fld:'vISINSERT',pic:'',hsh:true}]");
         setEventMetadata("'DOTEST'",",oparms:[]}");
         setEventMetadata("'DOADD'","{handler:'E28AL2',iparms:[{av:'A591View_New_Encounter2view_NE_EncounterID',fld:'VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZ9',hsh:true}]");
         setEventMetadata("'DOADD'",",oparms:[]}");
         setEventMetadata("VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID.CLICK","{handler:'E29AL2',iparms:[{av:'AV100view_NE_Status',fld:'vVIEW_NE_STATUS',pic:'ZZZ9'},{av:'AV87IsInsert',fld:'vISINSERT',pic:'',hsh:true},{av:'cmbView_New_Encounter2view_NE_Status'},{av:'A595View_New_Encounter2view_NE_Status',fld:'VIEW_NEW_ENCOUNTER2VIEW_NE_STATUS',pic:'ZZZ9',hsh:true},{av:'A591View_New_Encounter2view_NE_EncounterID',fld:'VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZ9',hsh:true}]");
         setEventMetadata("VIEW_NEW_ENCOUNTER2VIEW_NE_ENCOUNTERID.CLICK",",oparms:[]}");
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
         Ddo_view_new_encounter2view_ne_encounterid_Activeeventkey = "";
         Ddo_view_new_encounter2view_ne_encounterid_Filteredtext_get = "";
         Ddo_view_new_encounter2view_ne_encounterid_Filteredtextto_get = "";
         Ddo_view_new_encounter2view_ne_information_patientno_Activeeventkey = "";
         Ddo_view_new_encounter2view_ne_information_patientno_Filteredtext_get = "";
         Ddo_view_new_encounter2view_ne_information_patientno_Selectedvalue_get = "";
         Ddo_view_new_encounter2view_ne_departmentadm_Activeeventkey = "";
         Ddo_view_new_encounter2view_ne_departmentadm_Filteredtext_get = "";
         Ddo_view_new_encounter2view_ne_departmentadm_Selectedvalue_get = "";
         Ddo_view_new_encounter2view_ne_enctype_Activeeventkey = "";
         Ddo_view_new_encounter2view_ne_enctype_Filteredtext_get = "";
         Ddo_view_new_encounter2view_ne_enctype_Selectedvalue_get = "";
         Ddo_view_new_encounter2view_ne_status_Activeeventkey = "";
         Ddo_view_new_encounter2view_ne_status_Selectedvalue_get = "";
         Ddo_view_new_encounter2view_ne_israndapprove_Activeeventkey = "";
         Ddo_view_new_encounter2view_ne_israndapprove_Selectedvalue_get = "";
         Ddo_view_new_encounter2view_ne_israndrecheck_Activeeventkey = "";
         Ddo_view_new_encounter2view_ne_israndrecheck_Selectedvalue_get = "";
         Ddo_view_new_encounter2view_ne_isupdate_Activeeventkey = "";
         Ddo_view_new_encounter2view_ne_isupdate_Selectedvalue_get = "";
         Dvelop_confirmpanel_deleteencounter_Result = "";
         Dvelop_confirmpanel_batchapprove_Result = "";
         Dvelop_confirmpanel_batchrecheck_Result = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV15BR_Information_PatientNo = "";
         AV20sBR_EncounterID = "";
         AV21view_NE_AdmitDate = DateTime.MinValue;
         AV22endview_NE_AdmitDate = DateTime.MinValue;
         AV67TFView_New_Encounter2view_NE_Information_PatientNo = "";
         AV68TFView_New_Encounter2view_NE_Information_PatientNo_Sel = "";
         AV33TFView_New_Encounter2view_NE_Departmentadm = "";
         AV34TFView_New_Encounter2view_NE_Departmentadm_Sel = "";
         AV29TFView_New_Encounter2view_NE_ENCType = "";
         AV30TFView_New_Encounter2view_NE_ENCType_Sel = "";
         AV85tCurrentCode = "";
         AV27ddo_View_New_Encounter2view_NE_EncounterIDTitleControlIdToReplace = "";
         AV69ddo_View_New_Encounter2view_NE_Information_PatientNoTitleControlIdToReplace = "";
         AV35ddo_View_New_Encounter2view_NE_DepartmentadmTitleControlIdToReplace = "";
         AV31ddo_View_New_Encounter2view_NE_ENCTypeTitleControlIdToReplace = "";
         AV45ddo_View_New_Encounter2view_NE_StatusTitleControlIdToReplace = "";
         AV53ddo_View_New_Encounter2view_NE_IsRandApproveTitleControlIdToReplace = "";
         AV49ddo_View_New_Encounter2view_NE_IsRandRecheckTitleControlIdToReplace = "";
         AV57ddo_View_New_Encounter2view_NE_IsUpdateTitleControlIdToReplace = "";
         AV105TFView_New_Encounter2view_NE_Status_Sels = new GxSimpleCollection<short>();
         AV111Pgmname = "";
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         AV70DDO_TitleSettingsIcons = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV24View_New_Encounter2view_NE_EncounterIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV66View_New_Encounter2view_NE_Information_PatientNoTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV32View_New_Encounter2view_NE_DepartmentadmTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV28View_New_Encounter2view_NE_ENCTypeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV42View_New_Encounter2view_NE_StatusTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV50View_New_Encounter2view_NE_IsRandApproveTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV46View_New_Encounter2view_NE_IsRandRecheckTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV54View_New_Encounter2view_NE_IsUpdateTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV93tAllBR_EncounterID = new GxSimpleCollection<long>();
         Ddo_view_new_encounter2view_ne_encounterid_Filteredtext_set = "";
         Ddo_view_new_encounter2view_ne_encounterid_Filteredtextto_set = "";
         Ddo_view_new_encounter2view_ne_encounterid_Sortedstatus = "";
         Ddo_view_new_encounter2view_ne_information_patientno_Filteredtext_set = "";
         Ddo_view_new_encounter2view_ne_information_patientno_Selectedvalue_set = "";
         Ddo_view_new_encounter2view_ne_information_patientno_Sortedstatus = "";
         Ddo_view_new_encounter2view_ne_departmentadm_Filteredtext_set = "";
         Ddo_view_new_encounter2view_ne_departmentadm_Selectedvalue_set = "";
         Ddo_view_new_encounter2view_ne_departmentadm_Sortedstatus = "";
         Ddo_view_new_encounter2view_ne_enctype_Filteredtext_set = "";
         Ddo_view_new_encounter2view_ne_enctype_Selectedvalue_set = "";
         Ddo_view_new_encounter2view_ne_enctype_Sortedstatus = "";
         Ddo_view_new_encounter2view_ne_status_Selectedvalue_set = "";
         Ddo_view_new_encounter2view_ne_status_Sortedstatus = "";
         Ddo_view_new_encounter2view_ne_israndapprove_Selectedvalue_set = "";
         Ddo_view_new_encounter2view_ne_israndapprove_Sortedstatus = "";
         Ddo_view_new_encounter2view_ne_israndrecheck_Selectedvalue_set = "";
         Ddo_view_new_encounter2view_ne_israndrecheck_Sortedstatus = "";
         Ddo_view_new_encounter2view_ne_isupdate_Selectedvalue_set = "";
         Ddo_view_new_encounter2view_ne_isupdate_Sortedstatus = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         ucDvpanel_tableheader = new GXUserControl();
         TempTags = "";
         ClassString = "";
         StyleString = "";
         ucDvpanel_unnamedtable1 = new GXUserControl();
         GridContainer = new GXWebGrid( context);
         sStyleString = "";
         subGrid_Linesclass = "";
         GridColumn = new GXWebColumn();
         AV80deleteEncounter = "";
         A601View_New_Encounter2view_NE_Information_PatientNo = "";
         AV78PatientNo = "";
         A593View_New_Encounter2view_NE_Departmentadm = "";
         A592View_New_Encounter2view_NE_ENCType = "";
         AV79AdmitDate = DateTime.MinValue;
         A594View_New_Encounter2view_NE_AdmitDate = DateTime.MinValue;
         A599View_New_Encounter2view_NE_TenantTenantCode = "";
         ucGridpaginationbar = new GXUserControl();
         ucDdo_view_new_encounter2view_ne_encounterid = new GXUserControl();
         ucDdo_view_new_encounter2view_ne_information_patientno = new GXUserControl();
         ucDdo_view_new_encounter2view_ne_departmentadm = new GXUserControl();
         ucDdo_view_new_encounter2view_ne_enctype = new GXUserControl();
         ucDdo_view_new_encounter2view_ne_status = new GXUserControl();
         ucDdo_view_new_encounter2view_ne_israndapprove = new GXUserControl();
         ucDdo_view_new_encounter2view_ne_israndrecheck = new GXUserControl();
         ucDdo_view_new_encounter2view_ne_isupdate = new GXUserControl();
         ucWorkwithplusutilities1 = new GXUserControl();
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV129Deleteencounter_GXI = "";
         AV112Pgmdesc = "";
         AV125BR_EncounterListwwDS_13_Tfview_new_encounter2view_ne_status_sels = new GxSimpleCollection<short>();
         scmdbuf = "";
         lV113BR_EncounterListwwDS_1_Br_information_patientno = "";
         lV119BR_EncounterListwwDS_7_Tfview_new_encounter2view_ne_information_patientno = "";
         lV121BR_EncounterListwwDS_9_Tfview_new_encounter2view_ne_departmentadm = "";
         lV123BR_EncounterListwwDS_11_Tfview_new_encounter2view_ne_enctype = "";
         lV20sBR_EncounterID = "";
         AV113BR_EncounterListwwDS_1_Br_information_patientno = "";
         AV120BR_EncounterListwwDS_8_Tfview_new_encounter2view_ne_information_patientno_sel = "";
         AV119BR_EncounterListwwDS_7_Tfview_new_encounter2view_ne_information_patientno = "";
         AV122BR_EncounterListwwDS_10_Tfview_new_encounter2view_ne_departmentadm_sel = "";
         AV121BR_EncounterListwwDS_9_Tfview_new_encounter2view_ne_departmentadm = "";
         AV124BR_EncounterListwwDS_12_Tfview_new_encounter2view_ne_enctype_sel = "";
         AV123BR_EncounterListwwDS_11_Tfview_new_encounter2view_ne_enctype = "";
         H00AL2_A600View_New_Encounter2view_NE_Information_ID = new long[1] ;
         H00AL2_n600View_New_Encounter2view_NE_Information_ID = new bool[] {false} ;
         H00AL2_A599View_New_Encounter2view_NE_TenantTenantCode = new String[] {""} ;
         H00AL2_n599View_New_Encounter2view_NE_TenantTenantCode = new bool[] {false} ;
         H00AL2_A598View_New_Encounter2view_NE_IsUpdate = new bool[] {false} ;
         H00AL2_n598View_New_Encounter2view_NE_IsUpdate = new bool[] {false} ;
         H00AL2_A596View_New_Encounter2view_NE_IsRandRecheck = new bool[] {false} ;
         H00AL2_n596View_New_Encounter2view_NE_IsRandRecheck = new bool[] {false} ;
         H00AL2_A597View_New_Encounter2view_NE_IsRandApprove = new bool[] {false} ;
         H00AL2_n597View_New_Encounter2view_NE_IsRandApprove = new bool[] {false} ;
         H00AL2_A595View_New_Encounter2view_NE_Status = new short[1] ;
         H00AL2_n595View_New_Encounter2view_NE_Status = new bool[] {false} ;
         H00AL2_A594View_New_Encounter2view_NE_AdmitDate = new DateTime[] {DateTime.MinValue} ;
         H00AL2_n594View_New_Encounter2view_NE_AdmitDate = new bool[] {false} ;
         H00AL2_A592View_New_Encounter2view_NE_ENCType = new String[] {""} ;
         H00AL2_n592View_New_Encounter2view_NE_ENCType = new bool[] {false} ;
         H00AL2_A593View_New_Encounter2view_NE_Departmentadm = new String[] {""} ;
         H00AL2_n593View_New_Encounter2view_NE_Departmentadm = new bool[] {false} ;
         H00AL2_A601View_New_Encounter2view_NE_Information_PatientNo = new String[] {""} ;
         H00AL2_n601View_New_Encounter2view_NE_Information_PatientNo = new bool[] {false} ;
         H00AL2_A591View_New_Encounter2view_NE_EncounterID = new long[1] ;
         H00AL3_AGRID_nRecordCount = new long[1] ;
         GXt_char1 = "";
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV6WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV19Session = context.GetSession();
         AV94tDataPackage = new GxSimpleCollection<String>();
         AV98tResult = "";
         AV95websession = context.GetSession();
         AV96tSDT_MicroUserInfo = new SdtSDT_MicroUserInfo(context);
         AV104TFView_New_Encounter2view_NE_Status_SelsJson = "";
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
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sImgUrl = "";
         ROClassString = "";
         GXCCtl = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_encounterlistww__default(),
            new Object[][] {
                new Object[] {
               H00AL2_A600View_New_Encounter2view_NE_Information_ID, H00AL2_n600View_New_Encounter2view_NE_Information_ID, H00AL2_A599View_New_Encounter2view_NE_TenantTenantCode, H00AL2_n599View_New_Encounter2view_NE_TenantTenantCode, H00AL2_A598View_New_Encounter2view_NE_IsUpdate, H00AL2_n598View_New_Encounter2view_NE_IsUpdate, H00AL2_A596View_New_Encounter2view_NE_IsRandRecheck, H00AL2_n596View_New_Encounter2view_NE_IsRandRecheck, H00AL2_A597View_New_Encounter2view_NE_IsRandApprove, H00AL2_n597View_New_Encounter2view_NE_IsRandApprove,
               H00AL2_A595View_New_Encounter2view_NE_Status, H00AL2_n595View_New_Encounter2view_NE_Status, H00AL2_A594View_New_Encounter2view_NE_AdmitDate, H00AL2_n594View_New_Encounter2view_NE_AdmitDate, H00AL2_A592View_New_Encounter2view_NE_ENCType, H00AL2_n592View_New_Encounter2view_NE_ENCType, H00AL2_A593View_New_Encounter2view_NE_Departmentadm, H00AL2_n593View_New_Encounter2view_NE_Departmentadm, H00AL2_A601View_New_Encounter2view_NE_Information_PatientNo, H00AL2_n601View_New_Encounter2view_NE_Information_PatientNo,
               H00AL2_A591View_New_Encounter2view_NE_EncounterID
               }
               , new Object[] {
               H00AL3_AGRID_nRecordCount
               }
            }
         );
         AV112Pgmdesc = "就诊列表";
         AV111Pgmname = "BR_EncounterListww";
         /* GeneXus formulas. */
         AV112Pgmdesc = "就诊列表";
         AV111Pgmname = "BR_EncounterListww";
         context.Gx_err = 0;
         edtavPatientno_Enabled = 0;
         edtavAdmitdate_Enabled = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_GXsfl_76 ;
      private short nGXsfl_76_idx=1 ;
      private short GRID_nEOF ;
      private short AV23tview_NE_Status ;
      private short AV13OrderedBy ;
      private short AV106TFView_New_Encounter2view_NE_IsRandApprove_Sel ;
      private short AV107TFView_New_Encounter2view_NE_IsRandRecheck_Sel ;
      private short AV108TFView_New_Encounter2view_NE_IsUpdate_Sel ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short AV100view_NE_Status ;
      private short wbEnd ;
      private short wbStart ;
      private short subGrid_Backcolorstyle ;
      private short subGrid_Titlebackstyle ;
      private short edtView_New_Encounter2view_NE_EncounterID_Titleformat ;
      private short edtView_New_Encounter2view_NE_Information_PatientNo_Titleformat ;
      private short edtView_New_Encounter2view_NE_Departmentadm_Titleformat ;
      private short edtView_New_Encounter2view_NE_ENCType_Titleformat ;
      private short cmbView_New_Encounter2view_NE_Status_Titleformat ;
      private short chkView_New_Encounter2view_NE_IsRandApprove_Titleformat ;
      private short chkView_New_Encounter2view_NE_IsRandRecheck_Titleformat ;
      private short chkView_New_Encounter2view_NE_IsUpdate_Titleformat ;
      private short subGrid_Sortable ;
      private short A595View_New_Encounter2view_NE_Status ;
      private short subGrid_Allowselection ;
      private short subGrid_Allowhovering ;
      private short subGrid_Allowcollapsing ;
      private short subGrid_Collapsed ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short AV126BR_EncounterListwwDS_14_Tfview_new_encounter2view_ne_israndapprove_sel ;
      private short AV127BR_EncounterListwwDS_15_Tfview_new_encounter2view_ne_israndrecheck_sel ;
      private short AV128BR_EncounterListwwDS_16_Tfview_new_encounter2view_ne_isupdate_sel ;
      private short AV91tUserType ;
      private short AV92tBR_Encounter_Status ;
      private short AV97tNum ;
      private short nGXWrapped ;
      private short subGrid_Backstyle ;
      private int subGrid_Rows ;
      private int Gridpaginationbar_Rowsperpageselectedvalue ;
      private int Gridpaginationbar_Pagestoshow ;
      private int Ddo_view_new_encounter2view_ne_information_patientno_Datalistupdateminimumcharacters ;
      private int Ddo_view_new_encounter2view_ne_departmentadm_Datalistupdateminimumcharacters ;
      private int Ddo_view_new_encounter2view_ne_enctype_Datalistupdateminimumcharacters ;
      private int edtavBr_information_patientno_Enabled ;
      private int edtavSbr_encounterid_Enabled ;
      private int edtavView_ne_admitdate_Enabled ;
      private int edtavEndview_ne_admitdate_Enabled ;
      private int subGrid_Titlebackcolor ;
      private int subGrid_Allbackcolor ;
      private int edtavDeleteencounter_Visible ;
      private int edtavPatientno_Enabled ;
      private int edtavAdmitdate_Enabled ;
      private int subGrid_Selectedindex ;
      private int subGrid_Selectioncolor ;
      private int subGrid_Hoveringcolor ;
      private int edtavDdo_view_new_encounter2view_ne_encounteridtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_view_new_encounter2view_ne_information_patientnotitlecontrolidtoreplace_Visible ;
      private int edtavDdo_view_new_encounter2view_ne_departmentadmtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_view_new_encounter2view_ne_enctypetitlecontrolidtoreplace_Visible ;
      private int edtavDdo_view_new_encounter2view_ne_statustitlecontrolidtoreplace_Visible ;
      private int edtavDdo_view_new_encounter2view_ne_israndapprovetitlecontrolidtoreplace_Visible ;
      private int edtavDdo_view_new_encounter2view_ne_israndrechecktitlecontrolidtoreplace_Visible ;
      private int edtavDdo_view_new_encounter2view_ne_isupdatetitlecontrolidtoreplace_Visible ;
      private int edtavView_new_encounter2view_ne_encounterid_selected_Visible ;
      private int edtavOrderedby_Visible ;
      private int edtavOrdereddsc_Visible ;
      private int edtavTfview_new_encounter2view_ne_encounterid_Visible ;
      private int edtavTfview_new_encounter2view_ne_encounterid_to_Visible ;
      private int edtavTfview_new_encounter2view_ne_information_patientno_Visible ;
      private int edtavTfview_new_encounter2view_ne_information_patientno_sel_Visible ;
      private int edtavTfview_new_encounter2view_ne_departmentadm_Visible ;
      private int edtavTfview_new_encounter2view_ne_departmentadm_sel_Visible ;
      private int edtavTfview_new_encounter2view_ne_enctype_Visible ;
      private int edtavTfview_new_encounter2view_ne_enctype_sel_Visible ;
      private int edtavTfview_new_encounter2view_ne_israndapprove_sel_Visible ;
      private int edtavTfview_new_encounter2view_ne_israndrecheck_sel_Visible ;
      private int edtavTfview_new_encounter2view_ne_isupdate_sel_Visible ;
      private int subGrid_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int AV125BR_EncounterListwwDS_13_Tfview_new_encounter2view_ne_status_sels_Count ;
      private int AV71PageToGo ;
      private int bttBtnbatchapprove_Visible ;
      private int bttBtnbatchrecheck_Visible ;
      private int AV130GXV1 ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private int edtavDeleteencounter_Enabled ;
      private int edtavPatientno_Visible ;
      private int edtavAdmitdate_Visible ;
      private long GRID_nFirstRecordOnPage ;
      private long AV25TFView_New_Encounter2view_NE_EncounterID ;
      private long AV26TFView_New_Encounter2view_NE_EncounterID_To ;
      private long AV72GridCurrentPage ;
      private long AV73GridPageCount ;
      private long A591View_New_Encounter2view_NE_EncounterID ;
      private long A600View_New_Encounter2view_NE_Information_ID ;
      private long AV82View_New_Encounter2view_NE_EncounterID_Selected ;
      private long GRID_nCurrentRecord ;
      private long AV117BR_EncounterListwwDS_5_Tfview_new_encounter2view_ne_encounterid ;
      private long AV118BR_EncounterListwwDS_6_Tfview_new_encounter2view_ne_encounterid_to ;
      private long GRID_nRecordCount ;
      private String Gridpaginationbar_Selectedpage ;
      private String Ddo_view_new_encounter2view_ne_encounterid_Activeeventkey ;
      private String Ddo_view_new_encounter2view_ne_encounterid_Filteredtext_get ;
      private String Ddo_view_new_encounter2view_ne_encounterid_Filteredtextto_get ;
      private String Ddo_view_new_encounter2view_ne_information_patientno_Activeeventkey ;
      private String Ddo_view_new_encounter2view_ne_information_patientno_Filteredtext_get ;
      private String Ddo_view_new_encounter2view_ne_information_patientno_Selectedvalue_get ;
      private String Ddo_view_new_encounter2view_ne_departmentadm_Activeeventkey ;
      private String Ddo_view_new_encounter2view_ne_departmentadm_Filteredtext_get ;
      private String Ddo_view_new_encounter2view_ne_departmentadm_Selectedvalue_get ;
      private String Ddo_view_new_encounter2view_ne_enctype_Activeeventkey ;
      private String Ddo_view_new_encounter2view_ne_enctype_Filteredtext_get ;
      private String Ddo_view_new_encounter2view_ne_enctype_Selectedvalue_get ;
      private String Ddo_view_new_encounter2view_ne_status_Activeeventkey ;
      private String Ddo_view_new_encounter2view_ne_status_Selectedvalue_get ;
      private String Ddo_view_new_encounter2view_ne_israndapprove_Activeeventkey ;
      private String Ddo_view_new_encounter2view_ne_israndapprove_Selectedvalue_get ;
      private String Ddo_view_new_encounter2view_ne_israndrecheck_Activeeventkey ;
      private String Ddo_view_new_encounter2view_ne_israndrecheck_Selectedvalue_get ;
      private String Ddo_view_new_encounter2view_ne_isupdate_Activeeventkey ;
      private String Ddo_view_new_encounter2view_ne_isupdate_Selectedvalue_get ;
      private String Dvelop_confirmpanel_deleteencounter_Result ;
      private String Dvelop_confirmpanel_batchapprove_Result ;
      private String Dvelop_confirmpanel_batchrecheck_Result ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_76_idx="0001" ;
      private String AV111Pgmname ;
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
      private String Ddo_view_new_encounter2view_ne_encounterid_Caption ;
      private String Ddo_view_new_encounter2view_ne_encounterid_Tooltip ;
      private String Ddo_view_new_encounter2view_ne_encounterid_Cls ;
      private String Ddo_view_new_encounter2view_ne_encounterid_Filteredtext_set ;
      private String Ddo_view_new_encounter2view_ne_encounterid_Filteredtextto_set ;
      private String Ddo_view_new_encounter2view_ne_encounterid_Dropdownoptionstype ;
      private String Ddo_view_new_encounter2view_ne_encounterid_Titlecontrolidtoreplace ;
      private String Ddo_view_new_encounter2view_ne_encounterid_Sortedstatus ;
      private String Ddo_view_new_encounter2view_ne_encounterid_Filtertype ;
      private String Ddo_view_new_encounter2view_ne_encounterid_Sortasc ;
      private String Ddo_view_new_encounter2view_ne_encounterid_Sortdsc ;
      private String Ddo_view_new_encounter2view_ne_encounterid_Cleanfilter ;
      private String Ddo_view_new_encounter2view_ne_encounterid_Rangefilterfrom ;
      private String Ddo_view_new_encounter2view_ne_encounterid_Rangefilterto ;
      private String Ddo_view_new_encounter2view_ne_encounterid_Searchbuttontext ;
      private String Ddo_view_new_encounter2view_ne_information_patientno_Caption ;
      private String Ddo_view_new_encounter2view_ne_information_patientno_Tooltip ;
      private String Ddo_view_new_encounter2view_ne_information_patientno_Cls ;
      private String Ddo_view_new_encounter2view_ne_information_patientno_Filteredtext_set ;
      private String Ddo_view_new_encounter2view_ne_information_patientno_Selectedvalue_set ;
      private String Ddo_view_new_encounter2view_ne_information_patientno_Dropdownoptionstype ;
      private String Ddo_view_new_encounter2view_ne_information_patientno_Titlecontrolidtoreplace ;
      private String Ddo_view_new_encounter2view_ne_information_patientno_Sortedstatus ;
      private String Ddo_view_new_encounter2view_ne_information_patientno_Filtertype ;
      private String Ddo_view_new_encounter2view_ne_information_patientno_Datalisttype ;
      private String Ddo_view_new_encounter2view_ne_information_patientno_Datalistproc ;
      private String Ddo_view_new_encounter2view_ne_information_patientno_Sortasc ;
      private String Ddo_view_new_encounter2view_ne_information_patientno_Sortdsc ;
      private String Ddo_view_new_encounter2view_ne_information_patientno_Loadingdata ;
      private String Ddo_view_new_encounter2view_ne_information_patientno_Cleanfilter ;
      private String Ddo_view_new_encounter2view_ne_information_patientno_Noresultsfound ;
      private String Ddo_view_new_encounter2view_ne_information_patientno_Searchbuttontext ;
      private String Ddo_view_new_encounter2view_ne_departmentadm_Caption ;
      private String Ddo_view_new_encounter2view_ne_departmentadm_Tooltip ;
      private String Ddo_view_new_encounter2view_ne_departmentadm_Cls ;
      private String Ddo_view_new_encounter2view_ne_departmentadm_Filteredtext_set ;
      private String Ddo_view_new_encounter2view_ne_departmentadm_Selectedvalue_set ;
      private String Ddo_view_new_encounter2view_ne_departmentadm_Dropdownoptionstype ;
      private String Ddo_view_new_encounter2view_ne_departmentadm_Titlecontrolidtoreplace ;
      private String Ddo_view_new_encounter2view_ne_departmentadm_Sortedstatus ;
      private String Ddo_view_new_encounter2view_ne_departmentadm_Filtertype ;
      private String Ddo_view_new_encounter2view_ne_departmentadm_Datalisttype ;
      private String Ddo_view_new_encounter2view_ne_departmentadm_Datalistproc ;
      private String Ddo_view_new_encounter2view_ne_departmentadm_Sortasc ;
      private String Ddo_view_new_encounter2view_ne_departmentadm_Sortdsc ;
      private String Ddo_view_new_encounter2view_ne_departmentadm_Loadingdata ;
      private String Ddo_view_new_encounter2view_ne_departmentadm_Cleanfilter ;
      private String Ddo_view_new_encounter2view_ne_departmentadm_Noresultsfound ;
      private String Ddo_view_new_encounter2view_ne_departmentadm_Searchbuttontext ;
      private String Ddo_view_new_encounter2view_ne_enctype_Caption ;
      private String Ddo_view_new_encounter2view_ne_enctype_Tooltip ;
      private String Ddo_view_new_encounter2view_ne_enctype_Cls ;
      private String Ddo_view_new_encounter2view_ne_enctype_Filteredtext_set ;
      private String Ddo_view_new_encounter2view_ne_enctype_Selectedvalue_set ;
      private String Ddo_view_new_encounter2view_ne_enctype_Dropdownoptionstype ;
      private String Ddo_view_new_encounter2view_ne_enctype_Titlecontrolidtoreplace ;
      private String Ddo_view_new_encounter2view_ne_enctype_Sortedstatus ;
      private String Ddo_view_new_encounter2view_ne_enctype_Filtertype ;
      private String Ddo_view_new_encounter2view_ne_enctype_Datalisttype ;
      private String Ddo_view_new_encounter2view_ne_enctype_Datalistproc ;
      private String Ddo_view_new_encounter2view_ne_enctype_Sortasc ;
      private String Ddo_view_new_encounter2view_ne_enctype_Sortdsc ;
      private String Ddo_view_new_encounter2view_ne_enctype_Loadingdata ;
      private String Ddo_view_new_encounter2view_ne_enctype_Cleanfilter ;
      private String Ddo_view_new_encounter2view_ne_enctype_Noresultsfound ;
      private String Ddo_view_new_encounter2view_ne_enctype_Searchbuttontext ;
      private String Ddo_view_new_encounter2view_ne_status_Caption ;
      private String Ddo_view_new_encounter2view_ne_status_Tooltip ;
      private String Ddo_view_new_encounter2view_ne_status_Cls ;
      private String Ddo_view_new_encounter2view_ne_status_Selectedvalue_set ;
      private String Ddo_view_new_encounter2view_ne_status_Dropdownoptionstype ;
      private String Ddo_view_new_encounter2view_ne_status_Titlecontrolidtoreplace ;
      private String Ddo_view_new_encounter2view_ne_status_Sortedstatus ;
      private String Ddo_view_new_encounter2view_ne_status_Datalisttype ;
      private String Ddo_view_new_encounter2view_ne_status_Datalistfixedvalues ;
      private String Ddo_view_new_encounter2view_ne_status_Sortasc ;
      private String Ddo_view_new_encounter2view_ne_status_Sortdsc ;
      private String Ddo_view_new_encounter2view_ne_status_Cleanfilter ;
      private String Ddo_view_new_encounter2view_ne_status_Searchbuttontext ;
      private String Ddo_view_new_encounter2view_ne_israndapprove_Caption ;
      private String Ddo_view_new_encounter2view_ne_israndapprove_Tooltip ;
      private String Ddo_view_new_encounter2view_ne_israndapprove_Cls ;
      private String Ddo_view_new_encounter2view_ne_israndapprove_Selectedvalue_set ;
      private String Ddo_view_new_encounter2view_ne_israndapprove_Dropdownoptionstype ;
      private String Ddo_view_new_encounter2view_ne_israndapprove_Titlecontrolidtoreplace ;
      private String Ddo_view_new_encounter2view_ne_israndapprove_Sortedstatus ;
      private String Ddo_view_new_encounter2view_ne_israndapprove_Datalisttype ;
      private String Ddo_view_new_encounter2view_ne_israndapprove_Datalistfixedvalues ;
      private String Ddo_view_new_encounter2view_ne_israndapprove_Sortasc ;
      private String Ddo_view_new_encounter2view_ne_israndapprove_Sortdsc ;
      private String Ddo_view_new_encounter2view_ne_israndapprove_Cleanfilter ;
      private String Ddo_view_new_encounter2view_ne_israndapprove_Searchbuttontext ;
      private String Ddo_view_new_encounter2view_ne_israndrecheck_Caption ;
      private String Ddo_view_new_encounter2view_ne_israndrecheck_Tooltip ;
      private String Ddo_view_new_encounter2view_ne_israndrecheck_Cls ;
      private String Ddo_view_new_encounter2view_ne_israndrecheck_Selectedvalue_set ;
      private String Ddo_view_new_encounter2view_ne_israndrecheck_Dropdownoptionstype ;
      private String Ddo_view_new_encounter2view_ne_israndrecheck_Titlecontrolidtoreplace ;
      private String Ddo_view_new_encounter2view_ne_israndrecheck_Sortedstatus ;
      private String Ddo_view_new_encounter2view_ne_israndrecheck_Datalisttype ;
      private String Ddo_view_new_encounter2view_ne_israndrecheck_Datalistfixedvalues ;
      private String Ddo_view_new_encounter2view_ne_israndrecheck_Sortasc ;
      private String Ddo_view_new_encounter2view_ne_israndrecheck_Sortdsc ;
      private String Ddo_view_new_encounter2view_ne_israndrecheck_Cleanfilter ;
      private String Ddo_view_new_encounter2view_ne_israndrecheck_Searchbuttontext ;
      private String Ddo_view_new_encounter2view_ne_isupdate_Caption ;
      private String Ddo_view_new_encounter2view_ne_isupdate_Tooltip ;
      private String Ddo_view_new_encounter2view_ne_isupdate_Cls ;
      private String Ddo_view_new_encounter2view_ne_isupdate_Selectedvalue_set ;
      private String Ddo_view_new_encounter2view_ne_isupdate_Dropdownoptionstype ;
      private String Ddo_view_new_encounter2view_ne_isupdate_Titlecontrolidtoreplace ;
      private String Ddo_view_new_encounter2view_ne_isupdate_Sortedstatus ;
      private String Ddo_view_new_encounter2view_ne_isupdate_Datalisttype ;
      private String Ddo_view_new_encounter2view_ne_isupdate_Datalistfixedvalues ;
      private String Ddo_view_new_encounter2view_ne_isupdate_Sortasc ;
      private String Ddo_view_new_encounter2view_ne_isupdate_Sortdsc ;
      private String Ddo_view_new_encounter2view_ne_isupdate_Cleanfilter ;
      private String Ddo_view_new_encounter2view_ne_isupdate_Searchbuttontext ;
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
      private String edtavBr_information_patientno_Internalname ;
      private String TempTags ;
      private String edtavBr_information_patientno_Jsonclick ;
      private String edtavSbr_encounterid_Internalname ;
      private String edtavSbr_encounterid_Jsonclick ;
      private String edtavView_ne_admitdate_Internalname ;
      private String edtavView_ne_admitdate_Jsonclick ;
      private String edtavEndview_ne_admitdate_Internalname ;
      private String edtavEndview_ne_admitdate_Jsonclick ;
      private String cmbavTview_ne_status_Internalname ;
      private String cmbavTview_ne_status_Jsonclick ;
      private String divUnnamedtable2_Internalname ;
      private String chkavView_new_encounter2view_ne_israndapprove_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String chkavView_new_encounter2view_ne_israndrecheck_Internalname ;
      private String chkavView_new_encounter2view_ne_isupdate_Internalname ;
      private String divHtml_dvpanel_unnamedtable1_Internalname ;
      private String Dvpanel_unnamedtable1_Internalname ;
      private String divLayout_unnamedtable1_Internalname ;
      private String divGridtablewithpaginationbar_Internalname ;
      private String sStyleString ;
      private String subGrid_Internalname ;
      private String subGrid_Class ;
      private String subGrid_Linesclass ;
      private String edtView_New_Encounter2view_NE_EncounterID_Title ;
      private String edtView_New_Encounter2view_NE_Information_PatientNo_Title ;
      private String edtView_New_Encounter2view_NE_Departmentadm_Title ;
      private String edtView_New_Encounter2view_NE_ENCType_Title ;
      private String subGrid_Header ;
      private String edtavDeleteencounter_Tooltiptext ;
      private String divHtml_gridpaginationbar_Internalname ;
      private String Gridpaginationbar_Internalname ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String Ddo_view_new_encounter2view_ne_encounterid_Internalname ;
      private String edtavDdo_view_new_encounter2view_ne_encounteridtitlecontrolidtoreplace_Internalname ;
      private String Ddo_view_new_encounter2view_ne_information_patientno_Internalname ;
      private String edtavDdo_view_new_encounter2view_ne_information_patientnotitlecontrolidtoreplace_Internalname ;
      private String Ddo_view_new_encounter2view_ne_departmentadm_Internalname ;
      private String edtavDdo_view_new_encounter2view_ne_departmentadmtitlecontrolidtoreplace_Internalname ;
      private String Ddo_view_new_encounter2view_ne_enctype_Internalname ;
      private String edtavDdo_view_new_encounter2view_ne_enctypetitlecontrolidtoreplace_Internalname ;
      private String Ddo_view_new_encounter2view_ne_status_Internalname ;
      private String edtavDdo_view_new_encounter2view_ne_statustitlecontrolidtoreplace_Internalname ;
      private String Ddo_view_new_encounter2view_ne_israndapprove_Internalname ;
      private String edtavDdo_view_new_encounter2view_ne_israndapprovetitlecontrolidtoreplace_Internalname ;
      private String Ddo_view_new_encounter2view_ne_israndrecheck_Internalname ;
      private String edtavDdo_view_new_encounter2view_ne_israndrechecktitlecontrolidtoreplace_Internalname ;
      private String Ddo_view_new_encounter2view_ne_isupdate_Internalname ;
      private String edtavDdo_view_new_encounter2view_ne_isupdatetitlecontrolidtoreplace_Internalname ;
      private String Workwithplusutilities1_Internalname ;
      private String edtavView_new_encounter2view_ne_encounterid_selected_Internalname ;
      private String edtavView_new_encounter2view_ne_encounterid_selected_Jsonclick ;
      private String edtavOrderedby_Internalname ;
      private String edtavOrderedby_Jsonclick ;
      private String edtavOrdereddsc_Internalname ;
      private String edtavOrdereddsc_Jsonclick ;
      private String edtavTfview_new_encounter2view_ne_encounterid_Internalname ;
      private String edtavTfview_new_encounter2view_ne_encounterid_Jsonclick ;
      private String edtavTfview_new_encounter2view_ne_encounterid_to_Internalname ;
      private String edtavTfview_new_encounter2view_ne_encounterid_to_Jsonclick ;
      private String edtavTfview_new_encounter2view_ne_information_patientno_Internalname ;
      private String edtavTfview_new_encounter2view_ne_information_patientno_sel_Internalname ;
      private String edtavTfview_new_encounter2view_ne_departmentadm_Internalname ;
      private String edtavTfview_new_encounter2view_ne_departmentadm_Jsonclick ;
      private String edtavTfview_new_encounter2view_ne_departmentadm_sel_Internalname ;
      private String edtavTfview_new_encounter2view_ne_departmentadm_sel_Jsonclick ;
      private String edtavTfview_new_encounter2view_ne_enctype_Internalname ;
      private String edtavTfview_new_encounter2view_ne_enctype_sel_Internalname ;
      private String edtavTfview_new_encounter2view_ne_israndapprove_sel_Internalname ;
      private String edtavTfview_new_encounter2view_ne_israndapprove_sel_Jsonclick ;
      private String edtavTfview_new_encounter2view_ne_israndrecheck_sel_Internalname ;
      private String edtavTfview_new_encounter2view_ne_israndrecheck_sel_Jsonclick ;
      private String edtavTfview_new_encounter2view_ne_isupdate_sel_Internalname ;
      private String edtavTfview_new_encounter2view_ne_isupdate_sel_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavDeleteencounter_Internalname ;
      private String edtView_New_Encounter2view_NE_EncounterID_Internalname ;
      private String edtView_New_Encounter2view_NE_Information_PatientNo_Internalname ;
      private String edtavPatientno_Internalname ;
      private String edtView_New_Encounter2view_NE_Departmentadm_Internalname ;
      private String edtView_New_Encounter2view_NE_ENCType_Internalname ;
      private String edtavAdmitdate_Internalname ;
      private String edtView_New_Encounter2view_NE_AdmitDate_Internalname ;
      private String cmbView_New_Encounter2view_NE_Status_Internalname ;
      private String chkView_New_Encounter2view_NE_IsRandApprove_Internalname ;
      private String chkView_New_Encounter2view_NE_IsRandRecheck_Internalname ;
      private String chkView_New_Encounter2view_NE_IsUpdate_Internalname ;
      private String edtView_New_Encounter2view_NE_TenantTenantCode_Internalname ;
      private String edtView_New_Encounter2view_NE_Information_ID_Internalname ;
      private String AV112Pgmdesc ;
      private String scmdbuf ;
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
      private String sGXsfl_76_fel_idx="0001" ;
      private String sImgUrl ;
      private String edtavDeleteencounter_Jsonclick ;
      private String ROClassString ;
      private String edtView_New_Encounter2view_NE_EncounterID_Jsonclick ;
      private String edtView_New_Encounter2view_NE_Information_PatientNo_Jsonclick ;
      private String edtavPatientno_Jsonclick ;
      private String edtView_New_Encounter2view_NE_Departmentadm_Jsonclick ;
      private String edtView_New_Encounter2view_NE_ENCType_Jsonclick ;
      private String edtavAdmitdate_Jsonclick ;
      private String edtView_New_Encounter2view_NE_AdmitDate_Jsonclick ;
      private String GXCCtl ;
      private String cmbView_New_Encounter2view_NE_Status_Jsonclick ;
      private String edtView_New_Encounter2view_NE_TenantTenantCode_Jsonclick ;
      private String edtView_New_Encounter2view_NE_Information_ID_Jsonclick ;
      private DateTime AV21view_NE_AdmitDate ;
      private DateTime AV22endview_NE_AdmitDate ;
      private DateTime AV79AdmitDate ;
      private DateTime A594View_New_Encounter2view_NE_AdmitDate ;
      private bool entryPointCalled ;
      private bool AV101View_New_Encounter2view_NE_IsRandApprove ;
      private bool AV102View_New_Encounter2view_NE_IsRandRecheck ;
      private bool AV103View_New_Encounter2view_NE_IsUpdate ;
      private bool AV14OrderedDsc ;
      private bool AV87IsInsert ;
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
      private bool Ddo_view_new_encounter2view_ne_encounterid_Includesortasc ;
      private bool Ddo_view_new_encounter2view_ne_encounterid_Includesortdsc ;
      private bool Ddo_view_new_encounter2view_ne_encounterid_Includefilter ;
      private bool Ddo_view_new_encounter2view_ne_encounterid_Filterisrange ;
      private bool Ddo_view_new_encounter2view_ne_encounterid_Includedatalist ;
      private bool Ddo_view_new_encounter2view_ne_information_patientno_Includesortasc ;
      private bool Ddo_view_new_encounter2view_ne_information_patientno_Includesortdsc ;
      private bool Ddo_view_new_encounter2view_ne_information_patientno_Includefilter ;
      private bool Ddo_view_new_encounter2view_ne_information_patientno_Filterisrange ;
      private bool Ddo_view_new_encounter2view_ne_information_patientno_Includedatalist ;
      private bool Ddo_view_new_encounter2view_ne_departmentadm_Includesortasc ;
      private bool Ddo_view_new_encounter2view_ne_departmentadm_Includesortdsc ;
      private bool Ddo_view_new_encounter2view_ne_departmentadm_Includefilter ;
      private bool Ddo_view_new_encounter2view_ne_departmentadm_Filterisrange ;
      private bool Ddo_view_new_encounter2view_ne_departmentadm_Includedatalist ;
      private bool Ddo_view_new_encounter2view_ne_enctype_Includesortasc ;
      private bool Ddo_view_new_encounter2view_ne_enctype_Includesortdsc ;
      private bool Ddo_view_new_encounter2view_ne_enctype_Includefilter ;
      private bool Ddo_view_new_encounter2view_ne_enctype_Filterisrange ;
      private bool Ddo_view_new_encounter2view_ne_enctype_Includedatalist ;
      private bool Ddo_view_new_encounter2view_ne_status_Includesortasc ;
      private bool Ddo_view_new_encounter2view_ne_status_Includesortdsc ;
      private bool Ddo_view_new_encounter2view_ne_status_Includefilter ;
      private bool Ddo_view_new_encounter2view_ne_status_Includedatalist ;
      private bool Ddo_view_new_encounter2view_ne_status_Allowmultipleselection ;
      private bool Ddo_view_new_encounter2view_ne_israndapprove_Includesortasc ;
      private bool Ddo_view_new_encounter2view_ne_israndapprove_Includesortdsc ;
      private bool Ddo_view_new_encounter2view_ne_israndapprove_Includefilter ;
      private bool Ddo_view_new_encounter2view_ne_israndapprove_Includedatalist ;
      private bool Ddo_view_new_encounter2view_ne_israndrecheck_Includesortasc ;
      private bool Ddo_view_new_encounter2view_ne_israndrecheck_Includesortdsc ;
      private bool Ddo_view_new_encounter2view_ne_israndrecheck_Includefilter ;
      private bool Ddo_view_new_encounter2view_ne_israndrecheck_Includedatalist ;
      private bool Ddo_view_new_encounter2view_ne_isupdate_Includesortasc ;
      private bool Ddo_view_new_encounter2view_ne_isupdate_Includesortdsc ;
      private bool Ddo_view_new_encounter2view_ne_isupdate_Includefilter ;
      private bool Ddo_view_new_encounter2view_ne_isupdate_Includedatalist ;
      private bool wbLoad ;
      private bool A597View_New_Encounter2view_NE_IsRandApprove ;
      private bool A596View_New_Encounter2view_NE_IsRandRecheck ;
      private bool A598View_New_Encounter2view_NE_IsUpdate ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_76_Refreshing=false ;
      private bool n601View_New_Encounter2view_NE_Information_PatientNo ;
      private bool n593View_New_Encounter2view_NE_Departmentadm ;
      private bool n592View_New_Encounter2view_NE_ENCType ;
      private bool n594View_New_Encounter2view_NE_AdmitDate ;
      private bool n595View_New_Encounter2view_NE_Status ;
      private bool n597View_New_Encounter2view_NE_IsRandApprove ;
      private bool n596View_New_Encounter2view_NE_IsRandRecheck ;
      private bool n598View_New_Encounter2view_NE_IsUpdate ;
      private bool n599View_New_Encounter2view_NE_TenantTenantCode ;
      private bool n600View_New_Encounter2view_NE_Information_ID ;
      private bool gxdyncontrolsrefreshing ;
      private bool AV114BR_EncounterListwwDS_2_View_new_encounter2view_ne_israndapprove ;
      private bool AV115BR_EncounterListwwDS_3_View_new_encounter2view_ne_israndrecheck ;
      private bool AV116BR_EncounterListwwDS_4_View_new_encounter2view_ne_isupdate ;
      private bool returnInSub ;
      private bool AV86IsChecker ;
      private bool AV88IsManager ;
      private bool AV89IsRocheUser ;
      private bool AV90IsApprover ;
      private bool gx_refresh_fired ;
      private bool AV81IsAuthorized_deleteEncounter ;
      private bool AV77TempBoolean ;
      private bool GXt_boolean3 ;
      private bool AV99tCheckFlag ;
      private bool AV80deleteEncounter_IsBlob ;
      private String AV104TFView_New_Encounter2view_NE_Status_SelsJson ;
      private String AV15BR_Information_PatientNo ;
      private String AV20sBR_EncounterID ;
      private String AV67TFView_New_Encounter2view_NE_Information_PatientNo ;
      private String AV68TFView_New_Encounter2view_NE_Information_PatientNo_Sel ;
      private String AV33TFView_New_Encounter2view_NE_Departmentadm ;
      private String AV34TFView_New_Encounter2view_NE_Departmentadm_Sel ;
      private String AV29TFView_New_Encounter2view_NE_ENCType ;
      private String AV30TFView_New_Encounter2view_NE_ENCType_Sel ;
      private String AV85tCurrentCode ;
      private String AV27ddo_View_New_Encounter2view_NE_EncounterIDTitleControlIdToReplace ;
      private String AV69ddo_View_New_Encounter2view_NE_Information_PatientNoTitleControlIdToReplace ;
      private String AV35ddo_View_New_Encounter2view_NE_DepartmentadmTitleControlIdToReplace ;
      private String AV31ddo_View_New_Encounter2view_NE_ENCTypeTitleControlIdToReplace ;
      private String AV45ddo_View_New_Encounter2view_NE_StatusTitleControlIdToReplace ;
      private String AV53ddo_View_New_Encounter2view_NE_IsRandApproveTitleControlIdToReplace ;
      private String AV49ddo_View_New_Encounter2view_NE_IsRandRecheckTitleControlIdToReplace ;
      private String AV57ddo_View_New_Encounter2view_NE_IsUpdateTitleControlIdToReplace ;
      private String A601View_New_Encounter2view_NE_Information_PatientNo ;
      private String AV78PatientNo ;
      private String A593View_New_Encounter2view_NE_Departmentadm ;
      private String A592View_New_Encounter2view_NE_ENCType ;
      private String A599View_New_Encounter2view_NE_TenantTenantCode ;
      private String AV129Deleteencounter_GXI ;
      private String lV113BR_EncounterListwwDS_1_Br_information_patientno ;
      private String lV119BR_EncounterListwwDS_7_Tfview_new_encounter2view_ne_information_patientno ;
      private String lV121BR_EncounterListwwDS_9_Tfview_new_encounter2view_ne_departmentadm ;
      private String lV123BR_EncounterListwwDS_11_Tfview_new_encounter2view_ne_enctype ;
      private String lV20sBR_EncounterID ;
      private String AV113BR_EncounterListwwDS_1_Br_information_patientno ;
      private String AV120BR_EncounterListwwDS_8_Tfview_new_encounter2view_ne_information_patientno_sel ;
      private String AV119BR_EncounterListwwDS_7_Tfview_new_encounter2view_ne_information_patientno ;
      private String AV122BR_EncounterListwwDS_10_Tfview_new_encounter2view_ne_departmentadm_sel ;
      private String AV121BR_EncounterListwwDS_9_Tfview_new_encounter2view_ne_departmentadm ;
      private String AV124BR_EncounterListwwDS_12_Tfview_new_encounter2view_ne_enctype_sel ;
      private String AV123BR_EncounterListwwDS_11_Tfview_new_encounter2view_ne_enctype ;
      private String AV98tResult ;
      private String AV80deleteEncounter ;
      private GxSimpleCollection<short> AV105TFView_New_Encounter2view_NE_Status_Sels ;
      private GxSimpleCollection<short> AV125BR_EncounterListwwDS_13_Tfview_new_encounter2view_ne_status_sels ;
      private GxSimpleCollection<long> AV93tAllBR_EncounterID ;
      private IGxSession AV19Session ;
      private IGxSession AV95websession ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private GXUserControl ucDvpanel_tableheader ;
      private GXUserControl ucDvpanel_unnamedtable1 ;
      private GXUserControl ucGridpaginationbar ;
      private GXUserControl ucDdo_view_new_encounter2view_ne_encounterid ;
      private GXUserControl ucDdo_view_new_encounter2view_ne_information_patientno ;
      private GXUserControl ucDdo_view_new_encounter2view_ne_departmentadm ;
      private GXUserControl ucDdo_view_new_encounter2view_ne_enctype ;
      private GXUserControl ucDdo_view_new_encounter2view_ne_status ;
      private GXUserControl ucDdo_view_new_encounter2view_ne_israndapprove ;
      private GXUserControl ucDdo_view_new_encounter2view_ne_israndrecheck ;
      private GXUserControl ucDdo_view_new_encounter2view_ne_isupdate ;
      private GXUserControl ucWorkwithplusutilities1 ;
      private GXUserControl ucDvelop_confirmpanel_batchrecheck ;
      private GXUserControl ucDvelop_confirmpanel_batchapprove ;
      private GXUserControl ucDvelop_confirmpanel_deleteencounter ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbavTview_ne_status ;
      private GXCheckbox chkavView_new_encounter2view_ne_israndapprove ;
      private GXCheckbox chkavView_new_encounter2view_ne_israndrecheck ;
      private GXCheckbox chkavView_new_encounter2view_ne_isupdate ;
      private GXCombobox cmbView_New_Encounter2view_NE_Status ;
      private GXCheckbox chkView_New_Encounter2view_NE_IsRandApprove ;
      private GXCheckbox chkView_New_Encounter2view_NE_IsRandRecheck ;
      private GXCheckbox chkView_New_Encounter2view_NE_IsUpdate ;
      private IDataStoreProvider pr_default ;
      private long[] H00AL2_A600View_New_Encounter2view_NE_Information_ID ;
      private bool[] H00AL2_n600View_New_Encounter2view_NE_Information_ID ;
      private String[] H00AL2_A599View_New_Encounter2view_NE_TenantTenantCode ;
      private bool[] H00AL2_n599View_New_Encounter2view_NE_TenantTenantCode ;
      private bool[] H00AL2_A598View_New_Encounter2view_NE_IsUpdate ;
      private bool[] H00AL2_n598View_New_Encounter2view_NE_IsUpdate ;
      private bool[] H00AL2_A596View_New_Encounter2view_NE_IsRandRecheck ;
      private bool[] H00AL2_n596View_New_Encounter2view_NE_IsRandRecheck ;
      private bool[] H00AL2_A597View_New_Encounter2view_NE_IsRandApprove ;
      private bool[] H00AL2_n597View_New_Encounter2view_NE_IsRandApprove ;
      private short[] H00AL2_A595View_New_Encounter2view_NE_Status ;
      private bool[] H00AL2_n595View_New_Encounter2view_NE_Status ;
      private DateTime[] H00AL2_A594View_New_Encounter2view_NE_AdmitDate ;
      private bool[] H00AL2_n594View_New_Encounter2view_NE_AdmitDate ;
      private String[] H00AL2_A592View_New_Encounter2view_NE_ENCType ;
      private bool[] H00AL2_n592View_New_Encounter2view_NE_ENCType ;
      private String[] H00AL2_A593View_New_Encounter2view_NE_Departmentadm ;
      private bool[] H00AL2_n593View_New_Encounter2view_NE_Departmentadm ;
      private String[] H00AL2_A601View_New_Encounter2view_NE_Information_PatientNo ;
      private bool[] H00AL2_n601View_New_Encounter2view_NE_Information_PatientNo ;
      private long[] H00AL2_A591View_New_Encounter2view_NE_EncounterID ;
      private long[] H00AL3_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV8HTTPRequest ;
      private GxSimpleCollection<String> AV94tDataPackage ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV24View_New_Encounter2view_NE_EncounterIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV66View_New_Encounter2view_NE_Information_PatientNoTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV32View_New_Encounter2view_NE_DepartmentadmTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV28View_New_Encounter2view_NE_ENCTypeTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV42View_New_Encounter2view_NE_StatusTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV50View_New_Encounter2view_NE_IsRandApproveTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV46View_New_Encounter2view_NE_IsRandRecheckTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV54View_New_Encounter2view_NE_IsUpdateTitleFilterData ;
      private GXWebForm Form ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons AV70DDO_TitleSettingsIcons ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV11GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue AV12GridStateFilterValue ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV9TrnContext ;
      private SdtSDT_MicroUserInfo AV96tSDT_MicroUserInfo ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
   }

   public class br_encounterlistww__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H00AL2( IGxContext context ,
                                             short A595View_New_Encounter2view_NE_Status ,
                                             GxSimpleCollection<short> AV125BR_EncounterListwwDS_13_Tfview_new_encounter2view_ne_status_sels ,
                                             String AV113BR_EncounterListwwDS_1_Br_information_patientno ,
                                             bool AV114BR_EncounterListwwDS_2_View_new_encounter2view_ne_israndapprove ,
                                             bool AV115BR_EncounterListwwDS_3_View_new_encounter2view_ne_israndrecheck ,
                                             bool AV116BR_EncounterListwwDS_4_View_new_encounter2view_ne_isupdate ,
                                             long AV117BR_EncounterListwwDS_5_Tfview_new_encounter2view_ne_encounterid ,
                                             long AV118BR_EncounterListwwDS_6_Tfview_new_encounter2view_ne_encounterid_to ,
                                             String AV120BR_EncounterListwwDS_8_Tfview_new_encounter2view_ne_information_patientno_sel ,
                                             String AV119BR_EncounterListwwDS_7_Tfview_new_encounter2view_ne_information_patientno ,
                                             String AV122BR_EncounterListwwDS_10_Tfview_new_encounter2view_ne_departmentadm_sel ,
                                             String AV121BR_EncounterListwwDS_9_Tfview_new_encounter2view_ne_departmentadm ,
                                             String AV124BR_EncounterListwwDS_12_Tfview_new_encounter2view_ne_enctype_sel ,
                                             String AV123BR_EncounterListwwDS_11_Tfview_new_encounter2view_ne_enctype ,
                                             int AV125BR_EncounterListwwDS_13_Tfview_new_encounter2view_ne_status_sels_Count ,
                                             short AV126BR_EncounterListwwDS_14_Tfview_new_encounter2view_ne_israndapprove_sel ,
                                             short AV127BR_EncounterListwwDS_15_Tfview_new_encounter2view_ne_israndrecheck_sel ,
                                             short AV128BR_EncounterListwwDS_16_Tfview_new_encounter2view_ne_isupdate_sel ,
                                             String AV20sBR_EncounterID ,
                                             DateTime AV21view_NE_AdmitDate ,
                                             DateTime AV22endview_NE_AdmitDate ,
                                             short AV23tview_NE_Status ,
                                             String A601View_New_Encounter2view_NE_Information_PatientNo ,
                                             bool A597View_New_Encounter2view_NE_IsRandApprove ,
                                             bool A596View_New_Encounter2view_NE_IsRandRecheck ,
                                             bool A598View_New_Encounter2view_NE_IsUpdate ,
                                             long A591View_New_Encounter2view_NE_EncounterID ,
                                             String A593View_New_Encounter2view_NE_Departmentadm ,
                                             String A592View_New_Encounter2view_NE_ENCType ,
                                             DateTime A594View_New_Encounter2view_NE_AdmitDate ,
                                             short AV13OrderedBy ,
                                             bool AV14OrderedDsc ,
                                             String A599View_New_Encounter2view_NE_TenantTenantCode ,
                                             String AV85tCurrentCode )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int4 ;
         GXv_int4 = new short [20] ;
         Object[] GXv_Object5 ;
         GXv_Object5 = new Object [2] ;
         String sSelectString ;
         String sFromString ;
         String sOrderString ;
         sSelectString = " [View_New_Encounter2view_NE_Information_ID], [View_New_Encounter2view_NE_TenantTenantCode], [View_New_Encounter2view_NE_IsUpdate], [View_New_Encounter2view_NE_IsRandRecheck], [View_New_Encounter2view_NE_IsRandApprove], [View_New_Encounter2view_NE_Status], [View_New_Encounter2view_NE_AdmitDate], [View_New_Encounter2view_NE_ENCType], [View_New_Encounter2view_NE_Departmentadm], [View_New_Encounter2view_NE_Information_PatientNo], [View_New_Encounter2view_NE_EncounterID]";
         sFromString = " FROM [View_New_Encounter] WITH (NOLOCK)";
         sOrderString = "";
         sWhereString = sWhereString + " WHERE (RTRIM(LTRIM([View_New_Encounter2view_NE_TenantTenantCode])) = @AV85tCurrentCode)";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV113BR_EncounterListwwDS_1_Br_information_patientno)) )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_Information_PatientNo] like '%' + @lV113BR_EncounterListwwDS_1_Br_information_patientno + '%')";
         }
         else
         {
            GXv_int4[1] = 1;
         }
         if ( ! (false==AV114BR_EncounterListwwDS_2_View_new_encounter2view_ne_israndapprove) )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_IsRandApprove] = @AV114BR_EncounterListwwDS_2_View_new_encounter2view_ne_israndapprove)";
         }
         else
         {
            GXv_int4[2] = 1;
         }
         if ( ! (false==AV115BR_EncounterListwwDS_3_View_new_encounter2view_ne_israndrecheck) )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_IsRandRecheck] = @AV115BR_EncounterListwwDS_3_View_new_encounter2view_ne_israndrecheck)";
         }
         else
         {
            GXv_int4[3] = 1;
         }
         if ( ! (false==AV116BR_EncounterListwwDS_4_View_new_encounter2view_ne_isupdate) )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_IsUpdate] = @AV116BR_EncounterListwwDS_4_View_new_encounter2view_ne_isupdate)";
         }
         else
         {
            GXv_int4[4] = 1;
         }
         if ( ! (0==AV117BR_EncounterListwwDS_5_Tfview_new_encounter2view_ne_encounterid) )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_EncounterID] >= @AV117BR_EncounterListwwDS_5_Tfview_new_encounter2view_ne_encounterid)";
         }
         else
         {
            GXv_int4[5] = 1;
         }
         if ( ! (0==AV118BR_EncounterListwwDS_6_Tfview_new_encounter2view_ne_encounterid_to) )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_EncounterID] <= @AV118BR_EncounterListwwDS_6_Tfview_new_encounter2view_ne_encounterid_to)";
         }
         else
         {
            GXv_int4[6] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV120BR_EncounterListwwDS_8_Tfview_new_encounter2view_ne_information_patientno_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV119BR_EncounterListwwDS_7_Tfview_new_encounter2view_ne_information_patientno)) ) )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_Information_PatientNo] like @lV119BR_EncounterListwwDS_7_Tfview_new_encounter2view_ne_information_patientno)";
         }
         else
         {
            GXv_int4[7] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV120BR_EncounterListwwDS_8_Tfview_new_encounter2view_ne_information_patientno_sel)) )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_Information_PatientNo] = @AV120BR_EncounterListwwDS_8_Tfview_new_encounter2view_ne_information_patientno_sel)";
         }
         else
         {
            GXv_int4[8] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV122BR_EncounterListwwDS_10_Tfview_new_encounter2view_ne_departmentadm_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV121BR_EncounterListwwDS_9_Tfview_new_encounter2view_ne_departmentadm)) ) )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_Departmentadm] like @lV121BR_EncounterListwwDS_9_Tfview_new_encounter2view_ne_departmentadm)";
         }
         else
         {
            GXv_int4[9] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV122BR_EncounterListwwDS_10_Tfview_new_encounter2view_ne_departmentadm_sel)) )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_Departmentadm] = @AV122BR_EncounterListwwDS_10_Tfview_new_encounter2view_ne_departmentadm_sel)";
         }
         else
         {
            GXv_int4[10] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV124BR_EncounterListwwDS_12_Tfview_new_encounter2view_ne_enctype_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV123BR_EncounterListwwDS_11_Tfview_new_encounter2view_ne_enctype)) ) )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_ENCType] like @lV123BR_EncounterListwwDS_11_Tfview_new_encounter2view_ne_enctype)";
         }
         else
         {
            GXv_int4[11] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV124BR_EncounterListwwDS_12_Tfview_new_encounter2view_ne_enctype_sel)) )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_ENCType] = @AV124BR_EncounterListwwDS_12_Tfview_new_encounter2view_ne_enctype_sel)";
         }
         else
         {
            GXv_int4[12] = 1;
         }
         if ( AV125BR_EncounterListwwDS_13_Tfview_new_encounter2view_ne_status_sels_Count > 0 )
         {
            sWhereString = sWhereString + " and (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV125BR_EncounterListwwDS_13_Tfview_new_encounter2view_ne_status_sels, "[View_New_Encounter2view_NE_Status] IN (", ")") + ")";
         }
         if ( AV126BR_EncounterListwwDS_14_Tfview_new_encounter2view_ne_israndapprove_sel == 1 )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_IsRandApprove] = 1)";
         }
         if ( AV126BR_EncounterListwwDS_14_Tfview_new_encounter2view_ne_israndapprove_sel == 2 )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_IsRandApprove] = 0)";
         }
         if ( AV127BR_EncounterListwwDS_15_Tfview_new_encounter2view_ne_israndrecheck_sel == 1 )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_IsRandRecheck] = 1)";
         }
         if ( AV127BR_EncounterListwwDS_15_Tfview_new_encounter2view_ne_israndrecheck_sel == 2 )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_IsRandRecheck] = 0)";
         }
         if ( AV128BR_EncounterListwwDS_16_Tfview_new_encounter2view_ne_isupdate_sel == 1 )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_IsUpdate] = 1)";
         }
         if ( AV128BR_EncounterListwwDS_16_Tfview_new_encounter2view_ne_isupdate_sel == 2 )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_IsUpdate] = 0)";
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV20sBR_EncounterID)) )
         {
            sWhereString = sWhereString + " and (CONVERT( char(18), CAST([View_New_Encounter2view_NE_EncounterID] AS decimal(18,0))) like '%' + @lV20sBR_EncounterID + '%')";
         }
         else
         {
            GXv_int4[13] = 1;
         }
         if ( ! (DateTime.MinValue==AV21view_NE_AdmitDate) )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_AdmitDate] >= @AV21view_NE_AdmitDate)";
         }
         else
         {
            GXv_int4[14] = 1;
         }
         if ( ! (DateTime.MinValue==AV22endview_NE_AdmitDate) )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_AdmitDate] <= @AV22endview_NE_AdmitDate)";
         }
         else
         {
            GXv_int4[15] = 1;
         }
         if ( ! (0==AV23tview_NE_Status) )
         {
            sWhereString = sWhereString + " and (RTRIM(LTRIM(CONVERT( char(4), CAST([View_New_Encounter2view_NE_Status] AS decimal(4,0))))) = RTRIM(LTRIM(CONVERT( char(4), CAST(@AV23tview_NE_Status AS decimal(4,0))))))";
         }
         else
         {
            GXv_int4[16] = 1;
         }
         if ( ( AV13OrderedBy == 1 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [View_New_Encounter2view_NE_EncounterID]";
         }
         else if ( ( AV13OrderedBy == 1 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [View_New_Encounter2view_NE_EncounterID] DESC";
         }
         else if ( ( AV13OrderedBy == 2 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [View_New_Encounter2view_NE_Information_PatientNo]";
         }
         else if ( ( AV13OrderedBy == 2 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [View_New_Encounter2view_NE_Information_PatientNo] DESC";
         }
         else if ( ( AV13OrderedBy == 3 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [View_New_Encounter2view_NE_Departmentadm]";
         }
         else if ( ( AV13OrderedBy == 3 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [View_New_Encounter2view_NE_Departmentadm] DESC";
         }
         else if ( ( AV13OrderedBy == 4 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [View_New_Encounter2view_NE_ENCType]";
         }
         else if ( ( AV13OrderedBy == 4 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [View_New_Encounter2view_NE_ENCType] DESC";
         }
         else if ( ( AV13OrderedBy == 5 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [View_New_Encounter2view_NE_Status]";
         }
         else if ( ( AV13OrderedBy == 5 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [View_New_Encounter2view_NE_Status] DESC";
         }
         else if ( ( AV13OrderedBy == 6 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [View_New_Encounter2view_NE_IsRandApprove]";
         }
         else if ( ( AV13OrderedBy == 6 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [View_New_Encounter2view_NE_IsRandApprove] DESC";
         }
         else if ( ( AV13OrderedBy == 7 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [View_New_Encounter2view_NE_IsRandRecheck]";
         }
         else if ( ( AV13OrderedBy == 7 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [View_New_Encounter2view_NE_IsRandRecheck] DESC";
         }
         else if ( ( AV13OrderedBy == 8 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [View_New_Encounter2view_NE_IsUpdate]";
         }
         else if ( ( AV13OrderedBy == 8 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [View_New_Encounter2view_NE_IsUpdate] DESC";
         }
         else if ( true )
         {
            sOrderString = sOrderString + " ORDER BY [View_New_Encounter2view_NE_EncounterID]";
         }
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object5[0] = scmdbuf;
         GXv_Object5[1] = GXv_int4;
         return GXv_Object5 ;
      }

      protected Object[] conditional_H00AL3( IGxContext context ,
                                             short A595View_New_Encounter2view_NE_Status ,
                                             GxSimpleCollection<short> AV125BR_EncounterListwwDS_13_Tfview_new_encounter2view_ne_status_sels ,
                                             String AV113BR_EncounterListwwDS_1_Br_information_patientno ,
                                             bool AV114BR_EncounterListwwDS_2_View_new_encounter2view_ne_israndapprove ,
                                             bool AV115BR_EncounterListwwDS_3_View_new_encounter2view_ne_israndrecheck ,
                                             bool AV116BR_EncounterListwwDS_4_View_new_encounter2view_ne_isupdate ,
                                             long AV117BR_EncounterListwwDS_5_Tfview_new_encounter2view_ne_encounterid ,
                                             long AV118BR_EncounterListwwDS_6_Tfview_new_encounter2view_ne_encounterid_to ,
                                             String AV120BR_EncounterListwwDS_8_Tfview_new_encounter2view_ne_information_patientno_sel ,
                                             String AV119BR_EncounterListwwDS_7_Tfview_new_encounter2view_ne_information_patientno ,
                                             String AV122BR_EncounterListwwDS_10_Tfview_new_encounter2view_ne_departmentadm_sel ,
                                             String AV121BR_EncounterListwwDS_9_Tfview_new_encounter2view_ne_departmentadm ,
                                             String AV124BR_EncounterListwwDS_12_Tfview_new_encounter2view_ne_enctype_sel ,
                                             String AV123BR_EncounterListwwDS_11_Tfview_new_encounter2view_ne_enctype ,
                                             int AV125BR_EncounterListwwDS_13_Tfview_new_encounter2view_ne_status_sels_Count ,
                                             short AV126BR_EncounterListwwDS_14_Tfview_new_encounter2view_ne_israndapprove_sel ,
                                             short AV127BR_EncounterListwwDS_15_Tfview_new_encounter2view_ne_israndrecheck_sel ,
                                             short AV128BR_EncounterListwwDS_16_Tfview_new_encounter2view_ne_isupdate_sel ,
                                             String AV20sBR_EncounterID ,
                                             DateTime AV21view_NE_AdmitDate ,
                                             DateTime AV22endview_NE_AdmitDate ,
                                             short AV23tview_NE_Status ,
                                             String A601View_New_Encounter2view_NE_Information_PatientNo ,
                                             bool A597View_New_Encounter2view_NE_IsRandApprove ,
                                             bool A596View_New_Encounter2view_NE_IsRandRecheck ,
                                             bool A598View_New_Encounter2view_NE_IsUpdate ,
                                             long A591View_New_Encounter2view_NE_EncounterID ,
                                             String A593View_New_Encounter2view_NE_Departmentadm ,
                                             String A592View_New_Encounter2view_NE_ENCType ,
                                             DateTime A594View_New_Encounter2view_NE_AdmitDate ,
                                             short AV13OrderedBy ,
                                             bool AV14OrderedDsc ,
                                             String A599View_New_Encounter2view_NE_TenantTenantCode ,
                                             String AV85tCurrentCode )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int6 ;
         GXv_int6 = new short [17] ;
         Object[] GXv_Object7 ;
         GXv_Object7 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM [View_New_Encounter] WITH (NOLOCK)";
         scmdbuf = scmdbuf + " WHERE (RTRIM(LTRIM([View_New_Encounter2view_NE_TenantTenantCode])) = @AV85tCurrentCode)";
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV113BR_EncounterListwwDS_1_Br_information_patientno)) )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_Information_PatientNo] like '%' + @lV113BR_EncounterListwwDS_1_Br_information_patientno + '%')";
         }
         else
         {
            GXv_int6[1] = 1;
         }
         if ( ! (false==AV114BR_EncounterListwwDS_2_View_new_encounter2view_ne_israndapprove) )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_IsRandApprove] = @AV114BR_EncounterListwwDS_2_View_new_encounter2view_ne_israndapprove)";
         }
         else
         {
            GXv_int6[2] = 1;
         }
         if ( ! (false==AV115BR_EncounterListwwDS_3_View_new_encounter2view_ne_israndrecheck) )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_IsRandRecheck] = @AV115BR_EncounterListwwDS_3_View_new_encounter2view_ne_israndrecheck)";
         }
         else
         {
            GXv_int6[3] = 1;
         }
         if ( ! (false==AV116BR_EncounterListwwDS_4_View_new_encounter2view_ne_isupdate) )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_IsUpdate] = @AV116BR_EncounterListwwDS_4_View_new_encounter2view_ne_isupdate)";
         }
         else
         {
            GXv_int6[4] = 1;
         }
         if ( ! (0==AV117BR_EncounterListwwDS_5_Tfview_new_encounter2view_ne_encounterid) )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_EncounterID] >= @AV117BR_EncounterListwwDS_5_Tfview_new_encounter2view_ne_encounterid)";
         }
         else
         {
            GXv_int6[5] = 1;
         }
         if ( ! (0==AV118BR_EncounterListwwDS_6_Tfview_new_encounter2view_ne_encounterid_to) )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_EncounterID] <= @AV118BR_EncounterListwwDS_6_Tfview_new_encounter2view_ne_encounterid_to)";
         }
         else
         {
            GXv_int6[6] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV120BR_EncounterListwwDS_8_Tfview_new_encounter2view_ne_information_patientno_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV119BR_EncounterListwwDS_7_Tfview_new_encounter2view_ne_information_patientno)) ) )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_Information_PatientNo] like @lV119BR_EncounterListwwDS_7_Tfview_new_encounter2view_ne_information_patientno)";
         }
         else
         {
            GXv_int6[7] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV120BR_EncounterListwwDS_8_Tfview_new_encounter2view_ne_information_patientno_sel)) )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_Information_PatientNo] = @AV120BR_EncounterListwwDS_8_Tfview_new_encounter2view_ne_information_patientno_sel)";
         }
         else
         {
            GXv_int6[8] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV122BR_EncounterListwwDS_10_Tfview_new_encounter2view_ne_departmentadm_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV121BR_EncounterListwwDS_9_Tfview_new_encounter2view_ne_departmentadm)) ) )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_Departmentadm] like @lV121BR_EncounterListwwDS_9_Tfview_new_encounter2view_ne_departmentadm)";
         }
         else
         {
            GXv_int6[9] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV122BR_EncounterListwwDS_10_Tfview_new_encounter2view_ne_departmentadm_sel)) )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_Departmentadm] = @AV122BR_EncounterListwwDS_10_Tfview_new_encounter2view_ne_departmentadm_sel)";
         }
         else
         {
            GXv_int6[10] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV124BR_EncounterListwwDS_12_Tfview_new_encounter2view_ne_enctype_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV123BR_EncounterListwwDS_11_Tfview_new_encounter2view_ne_enctype)) ) )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_ENCType] like @lV123BR_EncounterListwwDS_11_Tfview_new_encounter2view_ne_enctype)";
         }
         else
         {
            GXv_int6[11] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV124BR_EncounterListwwDS_12_Tfview_new_encounter2view_ne_enctype_sel)) )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_ENCType] = @AV124BR_EncounterListwwDS_12_Tfview_new_encounter2view_ne_enctype_sel)";
         }
         else
         {
            GXv_int6[12] = 1;
         }
         if ( AV125BR_EncounterListwwDS_13_Tfview_new_encounter2view_ne_status_sels_Count > 0 )
         {
            sWhereString = sWhereString + " and (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV125BR_EncounterListwwDS_13_Tfview_new_encounter2view_ne_status_sels, "[View_New_Encounter2view_NE_Status] IN (", ")") + ")";
         }
         if ( AV126BR_EncounterListwwDS_14_Tfview_new_encounter2view_ne_israndapprove_sel == 1 )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_IsRandApprove] = 1)";
         }
         if ( AV126BR_EncounterListwwDS_14_Tfview_new_encounter2view_ne_israndapprove_sel == 2 )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_IsRandApprove] = 0)";
         }
         if ( AV127BR_EncounterListwwDS_15_Tfview_new_encounter2view_ne_israndrecheck_sel == 1 )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_IsRandRecheck] = 1)";
         }
         if ( AV127BR_EncounterListwwDS_15_Tfview_new_encounter2view_ne_israndrecheck_sel == 2 )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_IsRandRecheck] = 0)";
         }
         if ( AV128BR_EncounterListwwDS_16_Tfview_new_encounter2view_ne_isupdate_sel == 1 )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_IsUpdate] = 1)";
         }
         if ( AV128BR_EncounterListwwDS_16_Tfview_new_encounter2view_ne_isupdate_sel == 2 )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_IsUpdate] = 0)";
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV20sBR_EncounterID)) )
         {
            sWhereString = sWhereString + " and (CONVERT( char(18), CAST([View_New_Encounter2view_NE_EncounterID] AS decimal(18,0))) like '%' + @lV20sBR_EncounterID + '%')";
         }
         else
         {
            GXv_int6[13] = 1;
         }
         if ( ! (DateTime.MinValue==AV21view_NE_AdmitDate) )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_AdmitDate] >= @AV21view_NE_AdmitDate)";
         }
         else
         {
            GXv_int6[14] = 1;
         }
         if ( ! (DateTime.MinValue==AV22endview_NE_AdmitDate) )
         {
            sWhereString = sWhereString + " and ([View_New_Encounter2view_NE_AdmitDate] <= @AV22endview_NE_AdmitDate)";
         }
         else
         {
            GXv_int6[15] = 1;
         }
         if ( ! (0==AV23tview_NE_Status) )
         {
            sWhereString = sWhereString + " and (RTRIM(LTRIM(CONVERT( char(4), CAST([View_New_Encounter2view_NE_Status] AS decimal(4,0))))) = RTRIM(LTRIM(CONVERT( char(4), CAST(@AV23tview_NE_Status AS decimal(4,0))))))";
         }
         else
         {
            GXv_int6[16] = 1;
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
                     return conditional_H00AL2(context, (short)dynConstraints[0] , (GxSimpleCollection<short>)dynConstraints[1] , (String)dynConstraints[2] , (bool)dynConstraints[3] , (bool)dynConstraints[4] , (bool)dynConstraints[5] , (long)dynConstraints[6] , (long)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (String)dynConstraints[10] , (String)dynConstraints[11] , (String)dynConstraints[12] , (String)dynConstraints[13] , (int)dynConstraints[14] , (short)dynConstraints[15] , (short)dynConstraints[16] , (short)dynConstraints[17] , (String)dynConstraints[18] , (DateTime)dynConstraints[19] , (DateTime)dynConstraints[20] , (short)dynConstraints[21] , (String)dynConstraints[22] , (bool)dynConstraints[23] , (bool)dynConstraints[24] , (bool)dynConstraints[25] , (long)dynConstraints[26] , (String)dynConstraints[27] , (String)dynConstraints[28] , (DateTime)dynConstraints[29] , (short)dynConstraints[30] , (bool)dynConstraints[31] , (String)dynConstraints[32] , (String)dynConstraints[33] );
               case 1 :
                     return conditional_H00AL3(context, (short)dynConstraints[0] , (GxSimpleCollection<short>)dynConstraints[1] , (String)dynConstraints[2] , (bool)dynConstraints[3] , (bool)dynConstraints[4] , (bool)dynConstraints[5] , (long)dynConstraints[6] , (long)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (String)dynConstraints[10] , (String)dynConstraints[11] , (String)dynConstraints[12] , (String)dynConstraints[13] , (int)dynConstraints[14] , (short)dynConstraints[15] , (short)dynConstraints[16] , (short)dynConstraints[17] , (String)dynConstraints[18] , (DateTime)dynConstraints[19] , (DateTime)dynConstraints[20] , (short)dynConstraints[21] , (String)dynConstraints[22] , (bool)dynConstraints[23] , (bool)dynConstraints[24] , (bool)dynConstraints[25] , (long)dynConstraints[26] , (String)dynConstraints[27] , (String)dynConstraints[28] , (DateTime)dynConstraints[29] , (short)dynConstraints[30] , (bool)dynConstraints[31] , (String)dynConstraints[32] , (String)dynConstraints[33] );
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
          Object[] prmH00AL2 ;
          prmH00AL2 = new Object[] {
          new Object[] {"@AV85tCurrentCode",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV113BR_EncounterListwwDS_1_Br_information_patientno",SqlDbType.NVarChar,2000,0} ,
          new Object[] {"@AV114BR_EncounterListwwDS_2_View_new_encounter2view_ne_israndapprove",SqlDbType.Bit,1,0} ,
          new Object[] {"@AV115BR_EncounterListwwDS_3_View_new_encounter2view_ne_israndrecheck",SqlDbType.Bit,1,0} ,
          new Object[] {"@AV116BR_EncounterListwwDS_4_View_new_encounter2view_ne_isupdate",SqlDbType.Bit,1,0} ,
          new Object[] {"@AV117BR_EncounterListwwDS_5_Tfview_new_encounter2view_ne_encounterid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV118BR_EncounterListwwDS_6_Tfview_new_encounter2view_ne_encounterid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV119BR_EncounterListwwDS_7_Tfview_new_encounter2view_ne_information_patientno",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@AV120BR_EncounterListwwDS_8_Tfview_new_encounter2view_ne_information_patientno_sel",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@lV121BR_EncounterListwwDS_9_Tfview_new_encounter2view_ne_departmentadm",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV122BR_EncounterListwwDS_10_Tfview_new_encounter2view_ne_departmentadm_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV123BR_EncounterListwwDS_11_Tfview_new_encounter2view_ne_enctype",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@AV124BR_EncounterListwwDS_12_Tfview_new_encounter2view_ne_enctype_sel",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@lV20sBR_EncounterID",SqlDbType.NVarChar,50,0} ,
          new Object[] {"@AV21view_NE_AdmitDate",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV22endview_NE_AdmitDate",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV23tview_NE_Status",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH00AL3 ;
          prmH00AL3 = new Object[] {
          new Object[] {"@AV85tCurrentCode",SqlDbType.NVarChar,40,0} ,
          new Object[] {"@lV113BR_EncounterListwwDS_1_Br_information_patientno",SqlDbType.NVarChar,2000,0} ,
          new Object[] {"@AV114BR_EncounterListwwDS_2_View_new_encounter2view_ne_israndapprove",SqlDbType.Bit,1,0} ,
          new Object[] {"@AV115BR_EncounterListwwDS_3_View_new_encounter2view_ne_israndrecheck",SqlDbType.Bit,1,0} ,
          new Object[] {"@AV116BR_EncounterListwwDS_4_View_new_encounter2view_ne_isupdate",SqlDbType.Bit,1,0} ,
          new Object[] {"@AV117BR_EncounterListwwDS_5_Tfview_new_encounter2view_ne_encounterid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV118BR_EncounterListwwDS_6_Tfview_new_encounter2view_ne_encounterid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV119BR_EncounterListwwDS_7_Tfview_new_encounter2view_ne_information_patientno",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@AV120BR_EncounterListwwDS_8_Tfview_new_encounter2view_ne_information_patientno_sel",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@lV121BR_EncounterListwwDS_9_Tfview_new_encounter2view_ne_departmentadm",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@AV122BR_EncounterListwwDS_10_Tfview_new_encounter2view_ne_departmentadm_sel",SqlDbType.NVarChar,100,0} ,
          new Object[] {"@lV123BR_EncounterListwwDS_11_Tfview_new_encounter2view_ne_enctype",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@AV124BR_EncounterListwwDS_12_Tfview_new_encounter2view_ne_enctype_sel",SqlDbType.NVarChar,4000,0} ,
          new Object[] {"@lV20sBR_EncounterID",SqlDbType.NVarChar,50,0} ,
          new Object[] {"@AV21view_NE_AdmitDate",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV22endview_NE_AdmitDate",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV23tview_NE_Status",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H00AL2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00AL2,11,0,true,false )
             ,new CursorDef("H00AL3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00AL3,1,0,true,false )
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
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((bool[]) buf[4])[0] = rslt.getBool(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((bool[]) buf[6])[0] = rslt.getBool(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((bool[]) buf[8])[0] = rslt.getBool(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((short[]) buf[10])[0] = rslt.getShort(6) ;
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
                   stmt.SetParameter(sIdx, (String)parms[20]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[21]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (bool)parms[22]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (bool)parms[23]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (bool)parms[24]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[25]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[26]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[27]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[28]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[29]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[30]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[31]);
                }
                if ( (short)parms[12] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[32]);
                }
                if ( (short)parms[13] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[33]);
                }
                if ( (short)parms[14] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[34]);
                }
                if ( (short)parms[15] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[35]);
                }
                if ( (short)parms[16] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[36]);
                }
                if ( (short)parms[17] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[37]);
                }
                if ( (short)parms[18] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[38]);
                }
                if ( (short)parms[19] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[39]);
                }
                return;
             case 1 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[17]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[18]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (bool)parms[19]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (bool)parms[20]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (bool)parms[21]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[22]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[23]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[24]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[25]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[26]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[27]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[28]);
                }
                if ( (short)parms[12] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[29]);
                }
                if ( (short)parms[13] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[30]);
                }
                if ( (short)parms[14] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[31]);
                }
                if ( (short)parms[15] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[32]);
                }
                if ( (short)parms[16] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[33]);
                }
                return;
       }
    }

 }

}
