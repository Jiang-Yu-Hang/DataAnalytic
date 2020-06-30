/*
               File: BR_ProcedureWW
        Description:  诊疗处理
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:10:52.68
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
   public class br_procedureww : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public br_procedureww( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_procedureww( IGxContext context )
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
         cmbBR_Procedure_PXSurgery = new GXCombobox();
         cmbBR_Procedure_PXRadiotherapy = new GXCombobox();
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
               nRC_GXsfl_28 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               nGXsfl_28_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
               sGXsfl_28_idx = GetNextPar( );
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
               AV13OrderedBy = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV14OrderedDsc = StringUtil.StrToBool( GetNextPar( ));
               AV80TFBR_ProcedureID = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV81TFBR_ProcedureID_To = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV19TFBR_EncounterID = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV20TFBR_EncounterID_To = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV23TFBR_Information_PatientNo = GetNextPar( );
               AV24TFBR_Information_PatientNo_Sel = GetNextPar( );
               AV27TFBR_Procedure_PXID = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV28TFBR_Procedure_PXID_To = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV83TFBR_Procedure_Date = context.localUtil.ParseDateParm( GetNextPar( ));
               AV84TFBR_Procedure_Date_To = context.localUtil.ParseDateParm( GetNextPar( ));
               AV93TFBR_Procedure_RadioDate = context.localUtil.ParseDateParm( GetNextPar( ));
               AV94TFBR_Procedure_RadioDate_To = context.localUtil.ParseDateParm( GetNextPar( ));
               AV99TFBR_Procedure_RadioTime = NumberUtil.Val( GetNextPar( ), ".");
               AV100TFBR_Procedure_RadioTime_To = NumberUtil.Val( GetNextPar( ), ".");
               AV17ddo_BR_ProcedureIDTitleControlIdToReplace = GetNextPar( );
               AV21ddo_BR_EncounterIDTitleControlIdToReplace = GetNextPar( );
               AV25ddo_BR_Information_PatientNoTitleControlIdToReplace = GetNextPar( );
               AV29ddo_BR_Procedure_PXIDTitleControlIdToReplace = GetNextPar( );
               AV33ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace = GetNextPar( );
               AV87ddo_BR_Procedure_DateTitleControlIdToReplace = GetNextPar( );
               AV41ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace = GetNextPar( );
               AV97ddo_BR_Procedure_RadioDateTitleControlIdToReplace = GetNextPar( );
               AV101ddo_BR_Procedure_RadioTimeTitleControlIdToReplace = GetNextPar( );
               ajax_req_read_hidden_sdt(GetNextPar( ), AV32TFBR_Procedure_PXSurgery_Sels);
               ajax_req_read_hidden_sdt(GetNextPar( ), AV40TFBR_Procedure_PXRadiotherapy_Sels);
               AV124Pgmname = GetNextPar( );
               AV75IsAuthorized_Update = StringUtil.StrToBool( GetNextPar( ));
               AV77IsAuthorized_Delete = StringUtil.StrToBool( GetNextPar( ));
               AV78IsAuthorized_BR_Information_PatientNo = StringUtil.StrToBool( GetNextPar( ));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV80TFBR_ProcedureID, AV81TFBR_ProcedureID_To, AV19TFBR_EncounterID, AV20TFBR_EncounterID_To, AV23TFBR_Information_PatientNo, AV24TFBR_Information_PatientNo_Sel, AV27TFBR_Procedure_PXID, AV28TFBR_Procedure_PXID_To, AV83TFBR_Procedure_Date, AV84TFBR_Procedure_Date_To, AV93TFBR_Procedure_RadioDate, AV94TFBR_Procedure_RadioDate_To, AV99TFBR_Procedure_RadioTime, AV100TFBR_Procedure_RadioTime_To, AV17ddo_BR_ProcedureIDTitleControlIdToReplace, AV21ddo_BR_EncounterIDTitleControlIdToReplace, AV25ddo_BR_Information_PatientNoTitleControlIdToReplace, AV29ddo_BR_Procedure_PXIDTitleControlIdToReplace, AV33ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace, AV87ddo_BR_Procedure_DateTitleControlIdToReplace, AV41ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace, AV97ddo_BR_Procedure_RadioDateTitleControlIdToReplace, AV101ddo_BR_Procedure_RadioTimeTitleControlIdToReplace, AV32TFBR_Procedure_PXSurgery_Sels, AV40TFBR_Procedure_PXRadiotherapy_Sels, AV124Pgmname, AV75IsAuthorized_Update, AV77IsAuthorized_Delete, AV78IsAuthorized_BR_Information_PatientNo) ;
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
         PA3O2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START3O2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?202022815105311", false);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.AddJavascriptSource("calendar.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("calendar-setup.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("calendar-zh.js", "?"+context.GetBuildNumber( 127771), false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_procedureww.aspx") +"\">") ;
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
         GxWebStd.gx_hidden_field( context, "GXH_vORDEREDBY", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13OrderedBy), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vORDEREDDSC", StringUtil.BoolToStr( AV14OrderedDsc));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_PROCEDUREID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV80TFBR_ProcedureID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_PROCEDUREID_TO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV81TFBR_ProcedureID_To), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_ENCOUNTERID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV19TFBR_EncounterID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_ENCOUNTERID_TO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV20TFBR_EncounterID_To), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_INFORMATION_PATIENTNO", AV23TFBR_Information_PatientNo);
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_INFORMATION_PATIENTNO_SEL", AV24TFBR_Information_PatientNo_Sel);
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_PROCEDURE_PXID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV27TFBR_Procedure_PXID), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_PROCEDURE_PXID_TO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV28TFBR_Procedure_PXID_To), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_PROCEDURE_DATE", context.localUtil.Format(AV83TFBR_Procedure_Date, "9999/99/99"));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_PROCEDURE_DATE_TO", context.localUtil.Format(AV84TFBR_Procedure_Date_To, "9999/99/99"));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_PROCEDURE_RADIODATE", context.localUtil.Format(AV93TFBR_Procedure_RadioDate, "9999/99/99"));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_PROCEDURE_RADIODATE_TO", context.localUtil.Format(AV94TFBR_Procedure_RadioDate_To, "9999/99/99"));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_PROCEDURE_RADIOTIME", StringUtil.LTrim( StringUtil.NToC( AV99TFBR_Procedure_RadioTime, 15, 5, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_PROCEDURE_RADIOTIME_TO", StringUtil.LTrim( StringUtil.NToC( AV100TFBR_Procedure_RadioTime_To, 15, 5, ".", "")));
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_28", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_28), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDCURRENTPAGE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV70GridCurrentPage), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDRECORDCOUNT", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV72GridRecordCount), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDPAGESIZE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV71GridPageSize), 10, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vDDO_TITLESETTINGSICONS", AV68DDO_TitleSettingsIcons);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vDDO_TITLESETTINGSICONS", AV68DDO_TitleSettingsIcons);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_PROCEDUREIDTITLEFILTERDATA", AV16BR_ProcedureIDTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_PROCEDUREIDTITLEFILTERDATA", AV16BR_ProcedureIDTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_ENCOUNTERIDTITLEFILTERDATA", AV18BR_EncounterIDTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_ENCOUNTERIDTITLEFILTERDATA", AV18BR_EncounterIDTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_INFORMATION_PATIENTNOTITLEFILTERDATA", AV22BR_Information_PatientNoTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_INFORMATION_PATIENTNOTITLEFILTERDATA", AV22BR_Information_PatientNoTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_PROCEDURE_PXIDTITLEFILTERDATA", AV26BR_Procedure_PXIDTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_PROCEDURE_PXIDTITLEFILTERDATA", AV26BR_Procedure_PXIDTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_PROCEDURE_PXSURGERYTITLEFILTERDATA", AV30BR_Procedure_PXSurgeryTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_PROCEDURE_PXSURGERYTITLEFILTERDATA", AV30BR_Procedure_PXSurgeryTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_PROCEDURE_DATETITLEFILTERDATA", AV82BR_Procedure_DateTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_PROCEDURE_DATETITLEFILTERDATA", AV82BR_Procedure_DateTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_PROCEDURE_PXRADIOTHERAPYTITLEFILTERDATA", AV38BR_Procedure_PXRadiotherapyTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_PROCEDURE_PXRADIOTHERAPYTITLEFILTERDATA", AV38BR_Procedure_PXRadiotherapyTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_PROCEDURE_RADIODATETITLEFILTERDATA", AV92BR_Procedure_RadioDateTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_PROCEDURE_RADIODATETITLEFILTERDATA", AV92BR_Procedure_RadioDateTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_PROCEDURE_RADIOTIMETITLEFILTERDATA", AV98BR_Procedure_RadioTimeTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_PROCEDURE_RADIOTIMETITLEFILTERDATA", AV98BR_Procedure_RadioTimeTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vTFBR_PROCEDURE_PXSURGERY_SELS", AV32TFBR_Procedure_PXSurgery_Sels);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vTFBR_PROCEDURE_PXSURGERY_SELS", AV32TFBR_Procedure_PXSurgery_Sels);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vTFBR_PROCEDURE_PXRADIOTHERAPY_SELS", AV40TFBR_Procedure_PXRadiotherapy_Sels);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vTFBR_PROCEDURE_PXRADIOTHERAPY_SELS", AV40TFBR_Procedure_PXRadiotherapy_Sels);
         }
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV124Pgmname));
         GxWebStd.gx_boolean_hidden_field( context, "vISAUTHORIZED_UPDATE", AV75IsAuthorized_Update);
         GxWebStd.gx_boolean_hidden_field( context, "vISAUTHORIZED_DELETE", AV77IsAuthorized_Delete);
         GxWebStd.gx_boolean_hidden_field( context, "vISAUTHORIZED_BR_INFORMATION_PATIENTNO", AV78IsAuthorized_BR_Information_PatientNo);
         GxWebStd.gx_hidden_field( context, "gxhash_vISAUTHORIZED_BR_INFORMATION_PATIENTNO", GetSecureSignedToken( "", AV78IsAuthorized_BR_Information_PatientNo, context));
         GxWebStd.gx_hidden_field( context, "BR_INFORMATION_ID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A85BR_Information_ID), 18, 0, ".", "")));
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
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDUREID_Caption", StringUtil.RTrim( Ddo_br_procedureid_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDUREID_Tooltip", StringUtil.RTrim( Ddo_br_procedureid_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDUREID_Cls", StringUtil.RTrim( Ddo_br_procedureid_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDUREID_Filteredtext_set", StringUtil.RTrim( Ddo_br_procedureid_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDUREID_Filteredtextto_set", StringUtil.RTrim( Ddo_br_procedureid_Filteredtextto_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDUREID_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_procedureid_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDUREID_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_procedureid_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDUREID_Includesortasc", StringUtil.BoolToStr( Ddo_br_procedureid_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDUREID_Includesortdsc", StringUtil.BoolToStr( Ddo_br_procedureid_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDUREID_Sortedstatus", StringUtil.RTrim( Ddo_br_procedureid_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDUREID_Includefilter", StringUtil.BoolToStr( Ddo_br_procedureid_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDUREID_Filtertype", StringUtil.RTrim( Ddo_br_procedureid_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDUREID_Filterisrange", StringUtil.BoolToStr( Ddo_br_procedureid_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDUREID_Includedatalist", StringUtil.BoolToStr( Ddo_br_procedureid_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDUREID_Sortasc", StringUtil.RTrim( Ddo_br_procedureid_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDUREID_Sortdsc", StringUtil.RTrim( Ddo_br_procedureid_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDUREID_Cleanfilter", StringUtil.RTrim( Ddo_br_procedureid_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDUREID_Rangefilterfrom", StringUtil.RTrim( Ddo_br_procedureid_Rangefilterfrom));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDUREID_Rangefilterto", StringUtil.RTrim( Ddo_br_procedureid_Rangefilterto));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDUREID_Searchbuttontext", StringUtil.RTrim( Ddo_br_procedureid_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Caption", StringUtil.RTrim( Ddo_br_encounterid_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Tooltip", StringUtil.RTrim( Ddo_br_encounterid_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Cls", StringUtil.RTrim( Ddo_br_encounterid_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Filteredtext_set", StringUtil.RTrim( Ddo_br_encounterid_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Filteredtextto_set", StringUtil.RTrim( Ddo_br_encounterid_Filteredtextto_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_encounterid_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_encounterid_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Includesortasc", StringUtil.BoolToStr( Ddo_br_encounterid_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Includesortdsc", StringUtil.BoolToStr( Ddo_br_encounterid_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Sortedstatus", StringUtil.RTrim( Ddo_br_encounterid_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Includefilter", StringUtil.BoolToStr( Ddo_br_encounterid_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Filtertype", StringUtil.RTrim( Ddo_br_encounterid_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Filterisrange", StringUtil.BoolToStr( Ddo_br_encounterid_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Includedatalist", StringUtil.BoolToStr( Ddo_br_encounterid_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Sortasc", StringUtil.RTrim( Ddo_br_encounterid_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Sortdsc", StringUtil.RTrim( Ddo_br_encounterid_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Cleanfilter", StringUtil.RTrim( Ddo_br_encounterid_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Rangefilterfrom", StringUtil.RTrim( Ddo_br_encounterid_Rangefilterfrom));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Rangefilterto", StringUtil.RTrim( Ddo_br_encounterid_Rangefilterto));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Searchbuttontext", StringUtil.RTrim( Ddo_br_encounterid_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Caption", StringUtil.RTrim( Ddo_br_information_patientno_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Tooltip", StringUtil.RTrim( Ddo_br_information_patientno_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Cls", StringUtil.RTrim( Ddo_br_information_patientno_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Filteredtext_set", StringUtil.RTrim( Ddo_br_information_patientno_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Selectedvalue_set", StringUtil.RTrim( Ddo_br_information_patientno_Selectedvalue_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_information_patientno_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_information_patientno_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Includesortasc", StringUtil.BoolToStr( Ddo_br_information_patientno_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Includesortdsc", StringUtil.BoolToStr( Ddo_br_information_patientno_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Sortedstatus", StringUtil.RTrim( Ddo_br_information_patientno_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Includefilter", StringUtil.BoolToStr( Ddo_br_information_patientno_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Filtertype", StringUtil.RTrim( Ddo_br_information_patientno_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Filterisrange", StringUtil.BoolToStr( Ddo_br_information_patientno_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Includedatalist", StringUtil.BoolToStr( Ddo_br_information_patientno_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Datalisttype", StringUtil.RTrim( Ddo_br_information_patientno_Datalisttype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Datalistproc", StringUtil.RTrim( Ddo_br_information_patientno_Datalistproc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Datalistupdateminimumcharacters", StringUtil.LTrim( StringUtil.NToC( (decimal)(Ddo_br_information_patientno_Datalistupdateminimumcharacters), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Sortasc", StringUtil.RTrim( Ddo_br_information_patientno_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Sortdsc", StringUtil.RTrim( Ddo_br_information_patientno_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Loadingdata", StringUtil.RTrim( Ddo_br_information_patientno_Loadingdata));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Cleanfilter", StringUtil.RTrim( Ddo_br_information_patientno_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Noresultsfound", StringUtil.RTrim( Ddo_br_information_patientno_Noresultsfound));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Searchbuttontext", StringUtil.RTrim( Ddo_br_information_patientno_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXID_Caption", StringUtil.RTrim( Ddo_br_procedure_pxid_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXID_Tooltip", StringUtil.RTrim( Ddo_br_procedure_pxid_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXID_Cls", StringUtil.RTrim( Ddo_br_procedure_pxid_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXID_Filteredtext_set", StringUtil.RTrim( Ddo_br_procedure_pxid_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXID_Filteredtextto_set", StringUtil.RTrim( Ddo_br_procedure_pxid_Filteredtextto_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXID_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_procedure_pxid_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXID_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_procedure_pxid_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXID_Includesortasc", StringUtil.BoolToStr( Ddo_br_procedure_pxid_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXID_Includesortdsc", StringUtil.BoolToStr( Ddo_br_procedure_pxid_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXID_Sortedstatus", StringUtil.RTrim( Ddo_br_procedure_pxid_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXID_Includefilter", StringUtil.BoolToStr( Ddo_br_procedure_pxid_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXID_Filtertype", StringUtil.RTrim( Ddo_br_procedure_pxid_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXID_Filterisrange", StringUtil.BoolToStr( Ddo_br_procedure_pxid_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXID_Includedatalist", StringUtil.BoolToStr( Ddo_br_procedure_pxid_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXID_Sortasc", StringUtil.RTrim( Ddo_br_procedure_pxid_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXID_Sortdsc", StringUtil.RTrim( Ddo_br_procedure_pxid_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXID_Cleanfilter", StringUtil.RTrim( Ddo_br_procedure_pxid_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXID_Rangefilterfrom", StringUtil.RTrim( Ddo_br_procedure_pxid_Rangefilterfrom));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXID_Rangefilterto", StringUtil.RTrim( Ddo_br_procedure_pxid_Rangefilterto));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXID_Searchbuttontext", StringUtil.RTrim( Ddo_br_procedure_pxid_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXSURGERY_Caption", StringUtil.RTrim( Ddo_br_procedure_pxsurgery_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXSURGERY_Tooltip", StringUtil.RTrim( Ddo_br_procedure_pxsurgery_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXSURGERY_Cls", StringUtil.RTrim( Ddo_br_procedure_pxsurgery_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXSURGERY_Selectedvalue_set", StringUtil.RTrim( Ddo_br_procedure_pxsurgery_Selectedvalue_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXSURGERY_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_procedure_pxsurgery_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXSURGERY_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_procedure_pxsurgery_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXSURGERY_Includesortasc", StringUtil.BoolToStr( Ddo_br_procedure_pxsurgery_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXSURGERY_Includesortdsc", StringUtil.BoolToStr( Ddo_br_procedure_pxsurgery_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXSURGERY_Sortedstatus", StringUtil.RTrim( Ddo_br_procedure_pxsurgery_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXSURGERY_Includefilter", StringUtil.BoolToStr( Ddo_br_procedure_pxsurgery_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXSURGERY_Includedatalist", StringUtil.BoolToStr( Ddo_br_procedure_pxsurgery_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXSURGERY_Datalisttype", StringUtil.RTrim( Ddo_br_procedure_pxsurgery_Datalisttype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXSURGERY_Allowmultipleselection", StringUtil.BoolToStr( Ddo_br_procedure_pxsurgery_Allowmultipleselection));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXSURGERY_Datalistfixedvalues", StringUtil.RTrim( Ddo_br_procedure_pxsurgery_Datalistfixedvalues));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXSURGERY_Sortasc", StringUtil.RTrim( Ddo_br_procedure_pxsurgery_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXSURGERY_Sortdsc", StringUtil.RTrim( Ddo_br_procedure_pxsurgery_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXSURGERY_Cleanfilter", StringUtil.RTrim( Ddo_br_procedure_pxsurgery_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXSURGERY_Searchbuttontext", StringUtil.RTrim( Ddo_br_procedure_pxsurgery_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_DATE_Caption", StringUtil.RTrim( Ddo_br_procedure_date_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_DATE_Tooltip", StringUtil.RTrim( Ddo_br_procedure_date_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_DATE_Cls", StringUtil.RTrim( Ddo_br_procedure_date_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_DATE_Filteredtext_set", StringUtil.RTrim( Ddo_br_procedure_date_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_DATE_Filteredtextto_set", StringUtil.RTrim( Ddo_br_procedure_date_Filteredtextto_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_DATE_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_procedure_date_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_DATE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_procedure_date_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_DATE_Includesortasc", StringUtil.BoolToStr( Ddo_br_procedure_date_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_DATE_Includesortdsc", StringUtil.BoolToStr( Ddo_br_procedure_date_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_DATE_Sortedstatus", StringUtil.RTrim( Ddo_br_procedure_date_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_DATE_Includefilter", StringUtil.BoolToStr( Ddo_br_procedure_date_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_DATE_Filtertype", StringUtil.RTrim( Ddo_br_procedure_date_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_DATE_Filterisrange", StringUtil.BoolToStr( Ddo_br_procedure_date_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_DATE_Includedatalist", StringUtil.BoolToStr( Ddo_br_procedure_date_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_DATE_Sortasc", StringUtil.RTrim( Ddo_br_procedure_date_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_DATE_Sortdsc", StringUtil.RTrim( Ddo_br_procedure_date_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_DATE_Cleanfilter", StringUtil.RTrim( Ddo_br_procedure_date_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_DATE_Rangefilterfrom", StringUtil.RTrim( Ddo_br_procedure_date_Rangefilterfrom));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_DATE_Rangefilterto", StringUtil.RTrim( Ddo_br_procedure_date_Rangefilterto));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_DATE_Searchbuttontext", StringUtil.RTrim( Ddo_br_procedure_date_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXRADIOTHERAPY_Caption", StringUtil.RTrim( Ddo_br_procedure_pxradiotherapy_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXRADIOTHERAPY_Tooltip", StringUtil.RTrim( Ddo_br_procedure_pxradiotherapy_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXRADIOTHERAPY_Cls", StringUtil.RTrim( Ddo_br_procedure_pxradiotherapy_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXRADIOTHERAPY_Selectedvalue_set", StringUtil.RTrim( Ddo_br_procedure_pxradiotherapy_Selectedvalue_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXRADIOTHERAPY_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_procedure_pxradiotherapy_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXRADIOTHERAPY_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_procedure_pxradiotherapy_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXRADIOTHERAPY_Includesortasc", StringUtil.BoolToStr( Ddo_br_procedure_pxradiotherapy_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXRADIOTHERAPY_Includesortdsc", StringUtil.BoolToStr( Ddo_br_procedure_pxradiotherapy_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXRADIOTHERAPY_Sortedstatus", StringUtil.RTrim( Ddo_br_procedure_pxradiotherapy_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXRADIOTHERAPY_Includefilter", StringUtil.BoolToStr( Ddo_br_procedure_pxradiotherapy_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXRADIOTHERAPY_Includedatalist", StringUtil.BoolToStr( Ddo_br_procedure_pxradiotherapy_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXRADIOTHERAPY_Datalisttype", StringUtil.RTrim( Ddo_br_procedure_pxradiotherapy_Datalisttype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXRADIOTHERAPY_Allowmultipleselection", StringUtil.BoolToStr( Ddo_br_procedure_pxradiotherapy_Allowmultipleselection));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXRADIOTHERAPY_Datalistfixedvalues", StringUtil.RTrim( Ddo_br_procedure_pxradiotherapy_Datalistfixedvalues));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXRADIOTHERAPY_Sortasc", StringUtil.RTrim( Ddo_br_procedure_pxradiotherapy_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXRADIOTHERAPY_Sortdsc", StringUtil.RTrim( Ddo_br_procedure_pxradiotherapy_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXRADIOTHERAPY_Cleanfilter", StringUtil.RTrim( Ddo_br_procedure_pxradiotherapy_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXRADIOTHERAPY_Searchbuttontext", StringUtil.RTrim( Ddo_br_procedure_pxradiotherapy_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIODATE_Caption", StringUtil.RTrim( Ddo_br_procedure_radiodate_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIODATE_Tooltip", StringUtil.RTrim( Ddo_br_procedure_radiodate_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIODATE_Cls", StringUtil.RTrim( Ddo_br_procedure_radiodate_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIODATE_Filteredtext_set", StringUtil.RTrim( Ddo_br_procedure_radiodate_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIODATE_Filteredtextto_set", StringUtil.RTrim( Ddo_br_procedure_radiodate_Filteredtextto_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIODATE_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_procedure_radiodate_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIODATE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_procedure_radiodate_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIODATE_Includesortasc", StringUtil.BoolToStr( Ddo_br_procedure_radiodate_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIODATE_Includesortdsc", StringUtil.BoolToStr( Ddo_br_procedure_radiodate_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIODATE_Sortedstatus", StringUtil.RTrim( Ddo_br_procedure_radiodate_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIODATE_Includefilter", StringUtil.BoolToStr( Ddo_br_procedure_radiodate_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIODATE_Filtertype", StringUtil.RTrim( Ddo_br_procedure_radiodate_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIODATE_Filterisrange", StringUtil.BoolToStr( Ddo_br_procedure_radiodate_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIODATE_Includedatalist", StringUtil.BoolToStr( Ddo_br_procedure_radiodate_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIODATE_Sortasc", StringUtil.RTrim( Ddo_br_procedure_radiodate_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIODATE_Sortdsc", StringUtil.RTrim( Ddo_br_procedure_radiodate_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIODATE_Cleanfilter", StringUtil.RTrim( Ddo_br_procedure_radiodate_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIODATE_Rangefilterfrom", StringUtil.RTrim( Ddo_br_procedure_radiodate_Rangefilterfrom));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIODATE_Rangefilterto", StringUtil.RTrim( Ddo_br_procedure_radiodate_Rangefilterto));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIODATE_Searchbuttontext", StringUtil.RTrim( Ddo_br_procedure_radiodate_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIOTIME_Caption", StringUtil.RTrim( Ddo_br_procedure_radiotime_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIOTIME_Tooltip", StringUtil.RTrim( Ddo_br_procedure_radiotime_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIOTIME_Cls", StringUtil.RTrim( Ddo_br_procedure_radiotime_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIOTIME_Filteredtext_set", StringUtil.RTrim( Ddo_br_procedure_radiotime_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIOTIME_Filteredtextto_set", StringUtil.RTrim( Ddo_br_procedure_radiotime_Filteredtextto_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIOTIME_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_procedure_radiotime_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIOTIME_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_procedure_radiotime_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIOTIME_Includesortasc", StringUtil.BoolToStr( Ddo_br_procedure_radiotime_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIOTIME_Includesortdsc", StringUtil.BoolToStr( Ddo_br_procedure_radiotime_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIOTIME_Sortedstatus", StringUtil.RTrim( Ddo_br_procedure_radiotime_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIOTIME_Includefilter", StringUtil.BoolToStr( Ddo_br_procedure_radiotime_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIOTIME_Filtertype", StringUtil.RTrim( Ddo_br_procedure_radiotime_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIOTIME_Filterisrange", StringUtil.BoolToStr( Ddo_br_procedure_radiotime_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIOTIME_Includedatalist", StringUtil.BoolToStr( Ddo_br_procedure_radiotime_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIOTIME_Sortasc", StringUtil.RTrim( Ddo_br_procedure_radiotime_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIOTIME_Sortdsc", StringUtil.RTrim( Ddo_br_procedure_radiotime_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIOTIME_Cleanfilter", StringUtil.RTrim( Ddo_br_procedure_radiotime_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIOTIME_Rangefilterfrom", StringUtil.RTrim( Ddo_br_procedure_radiotime_Rangefilterfrom));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIOTIME_Rangefilterto", StringUtil.RTrim( Ddo_br_procedure_radiotime_Rangefilterto));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIOTIME_Searchbuttontext", StringUtil.RTrim( Ddo_br_procedure_radiotime_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDUREID_Activeeventkey", StringUtil.RTrim( Ddo_br_procedureid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDUREID_Filteredtext_get", StringUtil.RTrim( Ddo_br_procedureid_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDUREID_Filteredtextto_get", StringUtil.RTrim( Ddo_br_procedureid_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Activeeventkey", StringUtil.RTrim( Ddo_br_encounterid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Filteredtext_get", StringUtil.RTrim( Ddo_br_encounterid_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Filteredtextto_get", StringUtil.RTrim( Ddo_br_encounterid_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Activeeventkey", StringUtil.RTrim( Ddo_br_information_patientno_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Filteredtext_get", StringUtil.RTrim( Ddo_br_information_patientno_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Selectedvalue_get", StringUtil.RTrim( Ddo_br_information_patientno_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXID_Activeeventkey", StringUtil.RTrim( Ddo_br_procedure_pxid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXID_Filteredtext_get", StringUtil.RTrim( Ddo_br_procedure_pxid_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXID_Filteredtextto_get", StringUtil.RTrim( Ddo_br_procedure_pxid_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXSURGERY_Activeeventkey", StringUtil.RTrim( Ddo_br_procedure_pxsurgery_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXSURGERY_Selectedvalue_get", StringUtil.RTrim( Ddo_br_procedure_pxsurgery_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_DATE_Activeeventkey", StringUtil.RTrim( Ddo_br_procedure_date_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_DATE_Filteredtext_get", StringUtil.RTrim( Ddo_br_procedure_date_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_DATE_Filteredtextto_get", StringUtil.RTrim( Ddo_br_procedure_date_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXRADIOTHERAPY_Activeeventkey", StringUtil.RTrim( Ddo_br_procedure_pxradiotherapy_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXRADIOTHERAPY_Selectedvalue_get", StringUtil.RTrim( Ddo_br_procedure_pxradiotherapy_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIODATE_Activeeventkey", StringUtil.RTrim( Ddo_br_procedure_radiodate_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIODATE_Filteredtext_get", StringUtil.RTrim( Ddo_br_procedure_radiodate_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIODATE_Filteredtextto_get", StringUtil.RTrim( Ddo_br_procedure_radiodate_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIOTIME_Activeeventkey", StringUtil.RTrim( Ddo_br_procedure_radiotime_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIOTIME_Filteredtext_get", StringUtil.RTrim( Ddo_br_procedure_radiotime_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIOTIME_Filteredtextto_get", StringUtil.RTrim( Ddo_br_procedure_radiotime_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDUREID_Activeeventkey", StringUtil.RTrim( Ddo_br_procedureid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDUREID_Filteredtext_get", StringUtil.RTrim( Ddo_br_procedureid_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDUREID_Filteredtextto_get", StringUtil.RTrim( Ddo_br_procedureid_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Activeeventkey", StringUtil.RTrim( Ddo_br_encounterid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Filteredtext_get", StringUtil.RTrim( Ddo_br_encounterid_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Filteredtextto_get", StringUtil.RTrim( Ddo_br_encounterid_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Activeeventkey", StringUtil.RTrim( Ddo_br_information_patientno_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Filteredtext_get", StringUtil.RTrim( Ddo_br_information_patientno_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Selectedvalue_get", StringUtil.RTrim( Ddo_br_information_patientno_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXID_Activeeventkey", StringUtil.RTrim( Ddo_br_procedure_pxid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXID_Filteredtext_get", StringUtil.RTrim( Ddo_br_procedure_pxid_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXID_Filteredtextto_get", StringUtil.RTrim( Ddo_br_procedure_pxid_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXSURGERY_Activeeventkey", StringUtil.RTrim( Ddo_br_procedure_pxsurgery_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXSURGERY_Selectedvalue_get", StringUtil.RTrim( Ddo_br_procedure_pxsurgery_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_DATE_Activeeventkey", StringUtil.RTrim( Ddo_br_procedure_date_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_DATE_Filteredtext_get", StringUtil.RTrim( Ddo_br_procedure_date_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_DATE_Filteredtextto_get", StringUtil.RTrim( Ddo_br_procedure_date_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXRADIOTHERAPY_Activeeventkey", StringUtil.RTrim( Ddo_br_procedure_pxradiotherapy_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXRADIOTHERAPY_Selectedvalue_get", StringUtil.RTrim( Ddo_br_procedure_pxradiotherapy_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIODATE_Activeeventkey", StringUtil.RTrim( Ddo_br_procedure_radiodate_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIODATE_Filteredtext_get", StringUtil.RTrim( Ddo_br_procedure_radiodate_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIODATE_Filteredtextto_get", StringUtil.RTrim( Ddo_br_procedure_radiodate_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIOTIME_Activeeventkey", StringUtil.RTrim( Ddo_br_procedure_radiotime_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIOTIME_Filteredtext_get", StringUtil.RTrim( Ddo_br_procedure_radiotime_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIOTIME_Filteredtextto_get", StringUtil.RTrim( Ddo_br_procedure_radiotime_Filteredtextto_get));
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
            WE3O2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT3O2( ) ;
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
         return formatLink("br_procedureww.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "BR_ProcedureWW" ;
      }

      public override String GetPgmdesc( )
      {
         return " 诊疗处理" ;
      }

      protected void WB3O0( )
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 CellWidthAuto", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTableactions_Internalname, 1, 0, "px", 0, "px", "TableCellsWidthAuto", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group ActionGroupColoredActions", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"";
            ClassString = "Button ButtonColor";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtninsert_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(28), 2, 0)+","+"null"+");", "插入", bttBtninsert_Jsonclick, 5, "插入", "", StyleString, ClassString, bttBtninsert_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'DOINSERT\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_ProcedureWW.htm");
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
               context.WriteHtmlText( "<div id=\""+"GridContainer"+"DivS\" data-gxgridid=\"28\">") ;
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
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"ActionBaseColorAttribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"ActionBaseColorAttribute"+"\" "+" style=\""+((edtavUpdate_Visible==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"DeleteAttribute ActionBaseColorAttribute"+"\" "+" style=\""+((edtavDelete_Visible==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_ProcedureID_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_ProcedureID_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_ProcedureID_Title) ;
               }
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
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Procedure_PXID_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Procedure_PXID_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Procedure_PXID_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( cmbBR_Procedure_PXSurgery_Titleformat == 0 )
               {
                  context.SendWebValue( cmbBR_Procedure_PXSurgery.Title.Text) ;
               }
               else
               {
                  context.WriteHtmlText( cmbBR_Procedure_PXSurgery.Title.Text) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Procedure_Date_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Procedure_Date_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Procedure_Date_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( cmbBR_Procedure_PXRadiotherapy_Titleformat == 0 )
               {
                  context.SendWebValue( cmbBR_Procedure_PXRadiotherapy.Title.Text) ;
               }
               else
               {
                  context.WriteHtmlText( cmbBR_Procedure_PXRadiotherapy.Title.Text) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Procedure_RadioDate_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Procedure_RadioDate_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Procedure_RadioDate_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Procedure_RadioTime_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Procedure_RadioTime_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Procedure_RadioTime_Title) ;
               }
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
               GridColumn.AddObjectProperty("Value", context.convertURL( AV73Display));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavDisplay_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavDisplay_Tooltiptext));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.convertURL( AV74Update));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavUpdate_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavUpdate_Tooltiptext));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavUpdate_Visible), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.convertURL( AV76Delete));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavDelete_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavDelete_Tooltiptext));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavDelete_Visible), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A139BR_ProcedureID), 18, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_ProcedureID_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_ProcedureID_Titleformat), 4, 0, ".", "")));
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
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtBR_Information_PatientNo_Link));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A140BR_Procedure_PXID), 10, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Procedure_PXID_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Procedure_PXID_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A141BR_Procedure_PXSurgery);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( cmbBR_Procedure_PXSurgery.Title.Text));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(cmbBR_Procedure_PXSurgery_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.localUtil.Format(A266BR_Procedure_Date, "9999/99/99"));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Procedure_Date_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Procedure_Date_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A143BR_Procedure_PXRadiotherapy);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( cmbBR_Procedure_PXRadiotherapy.Title.Text));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(cmbBR_Procedure_PXRadiotherapy_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.localUtil.Format(A268BR_Procedure_RadioDate, "9999/99/99"));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Procedure_RadioDate_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Procedure_RadioDate_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A269BR_Procedure_RadioTime, 15, 5, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Procedure_RadioTime_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Procedure_RadioTime_Titleformat), 4, 0, ".", "")));
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
         if ( wbEnd == 28 )
         {
            wbEnd = 0;
            nRC_GXsfl_28 = (short)(nGXsfl_28_idx-1);
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
            ucGridpaginationbar.SetProperty("CurrentPage", AV70GridCurrentPage);
            ucGridpaginationbar.SetProperty("RecordCount", AV72GridRecordCount);
            ucGridpaginationbar.SetProperty("Page", AV71GridPageSize);
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
            ucDdo_br_procedureid.SetProperty("Caption", Ddo_br_procedureid_Caption);
            ucDdo_br_procedureid.SetProperty("Tooltip", Ddo_br_procedureid_Tooltip);
            ucDdo_br_procedureid.SetProperty("Cls", Ddo_br_procedureid_Cls);
            ucDdo_br_procedureid.SetProperty("DropDownOptionsType", Ddo_br_procedureid_Dropdownoptionstype);
            ucDdo_br_procedureid.SetProperty("IncludeSortASC", Ddo_br_procedureid_Includesortasc);
            ucDdo_br_procedureid.SetProperty("IncludeSortDSC", Ddo_br_procedureid_Includesortdsc);
            ucDdo_br_procedureid.SetProperty("IncludeFilter", Ddo_br_procedureid_Includefilter);
            ucDdo_br_procedureid.SetProperty("FilterType", Ddo_br_procedureid_Filtertype);
            ucDdo_br_procedureid.SetProperty("FilterIsRange", Ddo_br_procedureid_Filterisrange);
            ucDdo_br_procedureid.SetProperty("IncludeDataList", Ddo_br_procedureid_Includedatalist);
            ucDdo_br_procedureid.SetProperty("SortASC", Ddo_br_procedureid_Sortasc);
            ucDdo_br_procedureid.SetProperty("SortDSC", Ddo_br_procedureid_Sortdsc);
            ucDdo_br_procedureid.SetProperty("CleanFilter", Ddo_br_procedureid_Cleanfilter);
            ucDdo_br_procedureid.SetProperty("RangeFilterFrom", Ddo_br_procedureid_Rangefilterfrom);
            ucDdo_br_procedureid.SetProperty("RangeFilterTo", Ddo_br_procedureid_Rangefilterto);
            ucDdo_br_procedureid.SetProperty("SearchButtonText", Ddo_br_procedureid_Searchbuttontext);
            ucDdo_br_procedureid.SetProperty("DropDownOptionsTitleSettingsIcons", AV68DDO_TitleSettingsIcons);
            ucDdo_br_procedureid.SetProperty("DropDownOptionsData", AV16BR_ProcedureIDTitleFilterData);
            ucDdo_br_procedureid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_procedureid_Internalname, "DDO_BR_PROCEDUREIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 49,'',false,'" + sGXsfl_28_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_procedureidtitlecontrolidtoreplace_Internalname, AV17ddo_BR_ProcedureIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,49);\"", 0, edtavDdo_br_procedureidtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_ProcedureWW.htm");
            /* User Defined Control */
            ucDdo_br_encounterid.SetProperty("Caption", Ddo_br_encounterid_Caption);
            ucDdo_br_encounterid.SetProperty("Tooltip", Ddo_br_encounterid_Tooltip);
            ucDdo_br_encounterid.SetProperty("Cls", Ddo_br_encounterid_Cls);
            ucDdo_br_encounterid.SetProperty("DropDownOptionsType", Ddo_br_encounterid_Dropdownoptionstype);
            ucDdo_br_encounterid.SetProperty("IncludeSortASC", Ddo_br_encounterid_Includesortasc);
            ucDdo_br_encounterid.SetProperty("IncludeSortDSC", Ddo_br_encounterid_Includesortdsc);
            ucDdo_br_encounterid.SetProperty("IncludeFilter", Ddo_br_encounterid_Includefilter);
            ucDdo_br_encounterid.SetProperty("FilterType", Ddo_br_encounterid_Filtertype);
            ucDdo_br_encounterid.SetProperty("FilterIsRange", Ddo_br_encounterid_Filterisrange);
            ucDdo_br_encounterid.SetProperty("IncludeDataList", Ddo_br_encounterid_Includedatalist);
            ucDdo_br_encounterid.SetProperty("SortASC", Ddo_br_encounterid_Sortasc);
            ucDdo_br_encounterid.SetProperty("SortDSC", Ddo_br_encounterid_Sortdsc);
            ucDdo_br_encounterid.SetProperty("CleanFilter", Ddo_br_encounterid_Cleanfilter);
            ucDdo_br_encounterid.SetProperty("RangeFilterFrom", Ddo_br_encounterid_Rangefilterfrom);
            ucDdo_br_encounterid.SetProperty("RangeFilterTo", Ddo_br_encounterid_Rangefilterto);
            ucDdo_br_encounterid.SetProperty("SearchButtonText", Ddo_br_encounterid_Searchbuttontext);
            ucDdo_br_encounterid.SetProperty("DropDownOptionsTitleSettingsIcons", AV68DDO_TitleSettingsIcons);
            ucDdo_br_encounterid.SetProperty("DropDownOptionsData", AV18BR_EncounterIDTitleFilterData);
            ucDdo_br_encounterid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_encounterid_Internalname, "DDO_BR_ENCOUNTERIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 51,'',false,'" + sGXsfl_28_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_encounteridtitlecontrolidtoreplace_Internalname, AV21ddo_BR_EncounterIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,51);\"", 0, edtavDdo_br_encounteridtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_ProcedureWW.htm");
            /* User Defined Control */
            ucDdo_br_information_patientno.SetProperty("Caption", Ddo_br_information_patientno_Caption);
            ucDdo_br_information_patientno.SetProperty("Tooltip", Ddo_br_information_patientno_Tooltip);
            ucDdo_br_information_patientno.SetProperty("Cls", Ddo_br_information_patientno_Cls);
            ucDdo_br_information_patientno.SetProperty("DropDownOptionsType", Ddo_br_information_patientno_Dropdownoptionstype);
            ucDdo_br_information_patientno.SetProperty("IncludeSortASC", Ddo_br_information_patientno_Includesortasc);
            ucDdo_br_information_patientno.SetProperty("IncludeSortDSC", Ddo_br_information_patientno_Includesortdsc);
            ucDdo_br_information_patientno.SetProperty("IncludeFilter", Ddo_br_information_patientno_Includefilter);
            ucDdo_br_information_patientno.SetProperty("FilterType", Ddo_br_information_patientno_Filtertype);
            ucDdo_br_information_patientno.SetProperty("FilterIsRange", Ddo_br_information_patientno_Filterisrange);
            ucDdo_br_information_patientno.SetProperty("IncludeDataList", Ddo_br_information_patientno_Includedatalist);
            ucDdo_br_information_patientno.SetProperty("DataListType", Ddo_br_information_patientno_Datalisttype);
            ucDdo_br_information_patientno.SetProperty("DataListProc", Ddo_br_information_patientno_Datalistproc);
            ucDdo_br_information_patientno.SetProperty("DataListUpdateMinimumCharacters", Ddo_br_information_patientno_Datalistupdateminimumcharacters);
            ucDdo_br_information_patientno.SetProperty("SortASC", Ddo_br_information_patientno_Sortasc);
            ucDdo_br_information_patientno.SetProperty("SortDSC", Ddo_br_information_patientno_Sortdsc);
            ucDdo_br_information_patientno.SetProperty("LoadingData", Ddo_br_information_patientno_Loadingdata);
            ucDdo_br_information_patientno.SetProperty("CleanFilter", Ddo_br_information_patientno_Cleanfilter);
            ucDdo_br_information_patientno.SetProperty("NoResultsFound", Ddo_br_information_patientno_Noresultsfound);
            ucDdo_br_information_patientno.SetProperty("SearchButtonText", Ddo_br_information_patientno_Searchbuttontext);
            ucDdo_br_information_patientno.SetProperty("DropDownOptionsTitleSettingsIcons", AV68DDO_TitleSettingsIcons);
            ucDdo_br_information_patientno.SetProperty("DropDownOptionsData", AV22BR_Information_PatientNoTitleFilterData);
            ucDdo_br_information_patientno.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_information_patientno_Internalname, "DDO_BR_INFORMATION_PATIENTNOContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'" + sGXsfl_28_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_information_patientnotitlecontrolidtoreplace_Internalname, AV25ddo_BR_Information_PatientNoTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,53);\"", 0, edtavDdo_br_information_patientnotitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_ProcedureWW.htm");
            /* User Defined Control */
            ucDdo_br_procedure_pxid.SetProperty("Caption", Ddo_br_procedure_pxid_Caption);
            ucDdo_br_procedure_pxid.SetProperty("Tooltip", Ddo_br_procedure_pxid_Tooltip);
            ucDdo_br_procedure_pxid.SetProperty("Cls", Ddo_br_procedure_pxid_Cls);
            ucDdo_br_procedure_pxid.SetProperty("DropDownOptionsType", Ddo_br_procedure_pxid_Dropdownoptionstype);
            ucDdo_br_procedure_pxid.SetProperty("IncludeSortASC", Ddo_br_procedure_pxid_Includesortasc);
            ucDdo_br_procedure_pxid.SetProperty("IncludeSortDSC", Ddo_br_procedure_pxid_Includesortdsc);
            ucDdo_br_procedure_pxid.SetProperty("IncludeFilter", Ddo_br_procedure_pxid_Includefilter);
            ucDdo_br_procedure_pxid.SetProperty("FilterType", Ddo_br_procedure_pxid_Filtertype);
            ucDdo_br_procedure_pxid.SetProperty("FilterIsRange", Ddo_br_procedure_pxid_Filterisrange);
            ucDdo_br_procedure_pxid.SetProperty("IncludeDataList", Ddo_br_procedure_pxid_Includedatalist);
            ucDdo_br_procedure_pxid.SetProperty("SortASC", Ddo_br_procedure_pxid_Sortasc);
            ucDdo_br_procedure_pxid.SetProperty("SortDSC", Ddo_br_procedure_pxid_Sortdsc);
            ucDdo_br_procedure_pxid.SetProperty("CleanFilter", Ddo_br_procedure_pxid_Cleanfilter);
            ucDdo_br_procedure_pxid.SetProperty("RangeFilterFrom", Ddo_br_procedure_pxid_Rangefilterfrom);
            ucDdo_br_procedure_pxid.SetProperty("RangeFilterTo", Ddo_br_procedure_pxid_Rangefilterto);
            ucDdo_br_procedure_pxid.SetProperty("SearchButtonText", Ddo_br_procedure_pxid_Searchbuttontext);
            ucDdo_br_procedure_pxid.SetProperty("DropDownOptionsTitleSettingsIcons", AV68DDO_TitleSettingsIcons);
            ucDdo_br_procedure_pxid.SetProperty("DropDownOptionsData", AV26BR_Procedure_PXIDTitleFilterData);
            ucDdo_br_procedure_pxid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_procedure_pxid_Internalname, "DDO_BR_PROCEDURE_PXIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 55,'',false,'" + sGXsfl_28_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_procedure_pxidtitlecontrolidtoreplace_Internalname, AV29ddo_BR_Procedure_PXIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,55);\"", 0, edtavDdo_br_procedure_pxidtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_ProcedureWW.htm");
            /* User Defined Control */
            ucDdo_br_procedure_pxsurgery.SetProperty("Caption", Ddo_br_procedure_pxsurgery_Caption);
            ucDdo_br_procedure_pxsurgery.SetProperty("Tooltip", Ddo_br_procedure_pxsurgery_Tooltip);
            ucDdo_br_procedure_pxsurgery.SetProperty("Cls", Ddo_br_procedure_pxsurgery_Cls);
            ucDdo_br_procedure_pxsurgery.SetProperty("DropDownOptionsType", Ddo_br_procedure_pxsurgery_Dropdownoptionstype);
            ucDdo_br_procedure_pxsurgery.SetProperty("IncludeSortASC", Ddo_br_procedure_pxsurgery_Includesortasc);
            ucDdo_br_procedure_pxsurgery.SetProperty("IncludeSortDSC", Ddo_br_procedure_pxsurgery_Includesortdsc);
            ucDdo_br_procedure_pxsurgery.SetProperty("IncludeFilter", Ddo_br_procedure_pxsurgery_Includefilter);
            ucDdo_br_procedure_pxsurgery.SetProperty("IncludeDataList", Ddo_br_procedure_pxsurgery_Includedatalist);
            ucDdo_br_procedure_pxsurgery.SetProperty("DataListType", Ddo_br_procedure_pxsurgery_Datalisttype);
            ucDdo_br_procedure_pxsurgery.SetProperty("AllowMultipleSelection", Ddo_br_procedure_pxsurgery_Allowmultipleselection);
            ucDdo_br_procedure_pxsurgery.SetProperty("DataListFixedValues", Ddo_br_procedure_pxsurgery_Datalistfixedvalues);
            ucDdo_br_procedure_pxsurgery.SetProperty("SortASC", Ddo_br_procedure_pxsurgery_Sortasc);
            ucDdo_br_procedure_pxsurgery.SetProperty("SortDSC", Ddo_br_procedure_pxsurgery_Sortdsc);
            ucDdo_br_procedure_pxsurgery.SetProperty("CleanFilter", Ddo_br_procedure_pxsurgery_Cleanfilter);
            ucDdo_br_procedure_pxsurgery.SetProperty("SearchButtonText", Ddo_br_procedure_pxsurgery_Searchbuttontext);
            ucDdo_br_procedure_pxsurgery.SetProperty("DropDownOptionsTitleSettingsIcons", AV68DDO_TitleSettingsIcons);
            ucDdo_br_procedure_pxsurgery.SetProperty("DropDownOptionsData", AV30BR_Procedure_PXSurgeryTitleFilterData);
            ucDdo_br_procedure_pxsurgery.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_procedure_pxsurgery_Internalname, "DDO_BR_PROCEDURE_PXSURGERYContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 57,'',false,'" + sGXsfl_28_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_procedure_pxsurgerytitlecontrolidtoreplace_Internalname, AV33ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,57);\"", 0, edtavDdo_br_procedure_pxsurgerytitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_ProcedureWW.htm");
            /* User Defined Control */
            ucDdo_br_procedure_date.SetProperty("Caption", Ddo_br_procedure_date_Caption);
            ucDdo_br_procedure_date.SetProperty("Tooltip", Ddo_br_procedure_date_Tooltip);
            ucDdo_br_procedure_date.SetProperty("Cls", Ddo_br_procedure_date_Cls);
            ucDdo_br_procedure_date.SetProperty("DropDownOptionsType", Ddo_br_procedure_date_Dropdownoptionstype);
            ucDdo_br_procedure_date.SetProperty("IncludeSortASC", Ddo_br_procedure_date_Includesortasc);
            ucDdo_br_procedure_date.SetProperty("IncludeSortDSC", Ddo_br_procedure_date_Includesortdsc);
            ucDdo_br_procedure_date.SetProperty("IncludeFilter", Ddo_br_procedure_date_Includefilter);
            ucDdo_br_procedure_date.SetProperty("FilterType", Ddo_br_procedure_date_Filtertype);
            ucDdo_br_procedure_date.SetProperty("FilterIsRange", Ddo_br_procedure_date_Filterisrange);
            ucDdo_br_procedure_date.SetProperty("IncludeDataList", Ddo_br_procedure_date_Includedatalist);
            ucDdo_br_procedure_date.SetProperty("SortASC", Ddo_br_procedure_date_Sortasc);
            ucDdo_br_procedure_date.SetProperty("SortDSC", Ddo_br_procedure_date_Sortdsc);
            ucDdo_br_procedure_date.SetProperty("CleanFilter", Ddo_br_procedure_date_Cleanfilter);
            ucDdo_br_procedure_date.SetProperty("RangeFilterFrom", Ddo_br_procedure_date_Rangefilterfrom);
            ucDdo_br_procedure_date.SetProperty("RangeFilterTo", Ddo_br_procedure_date_Rangefilterto);
            ucDdo_br_procedure_date.SetProperty("SearchButtonText", Ddo_br_procedure_date_Searchbuttontext);
            ucDdo_br_procedure_date.SetProperty("DropDownOptionsTitleSettingsIcons", AV68DDO_TitleSettingsIcons);
            ucDdo_br_procedure_date.SetProperty("DropDownOptionsData", AV82BR_Procedure_DateTitleFilterData);
            ucDdo_br_procedure_date.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_procedure_date_Internalname, "DDO_BR_PROCEDURE_DATEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 59,'',false,'" + sGXsfl_28_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_procedure_datetitlecontrolidtoreplace_Internalname, AV87ddo_BR_Procedure_DateTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,59);\"", 0, edtavDdo_br_procedure_datetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_ProcedureWW.htm");
            /* User Defined Control */
            ucDdo_br_procedure_pxradiotherapy.SetProperty("Caption", Ddo_br_procedure_pxradiotherapy_Caption);
            ucDdo_br_procedure_pxradiotherapy.SetProperty("Tooltip", Ddo_br_procedure_pxradiotherapy_Tooltip);
            ucDdo_br_procedure_pxradiotherapy.SetProperty("Cls", Ddo_br_procedure_pxradiotherapy_Cls);
            ucDdo_br_procedure_pxradiotherapy.SetProperty("DropDownOptionsType", Ddo_br_procedure_pxradiotherapy_Dropdownoptionstype);
            ucDdo_br_procedure_pxradiotherapy.SetProperty("IncludeSortASC", Ddo_br_procedure_pxradiotherapy_Includesortasc);
            ucDdo_br_procedure_pxradiotherapy.SetProperty("IncludeSortDSC", Ddo_br_procedure_pxradiotherapy_Includesortdsc);
            ucDdo_br_procedure_pxradiotherapy.SetProperty("IncludeFilter", Ddo_br_procedure_pxradiotherapy_Includefilter);
            ucDdo_br_procedure_pxradiotherapy.SetProperty("IncludeDataList", Ddo_br_procedure_pxradiotherapy_Includedatalist);
            ucDdo_br_procedure_pxradiotherapy.SetProperty("DataListType", Ddo_br_procedure_pxradiotherapy_Datalisttype);
            ucDdo_br_procedure_pxradiotherapy.SetProperty("AllowMultipleSelection", Ddo_br_procedure_pxradiotherapy_Allowmultipleselection);
            ucDdo_br_procedure_pxradiotherapy.SetProperty("DataListFixedValues", Ddo_br_procedure_pxradiotherapy_Datalistfixedvalues);
            ucDdo_br_procedure_pxradiotherapy.SetProperty("SortASC", Ddo_br_procedure_pxradiotherapy_Sortasc);
            ucDdo_br_procedure_pxradiotherapy.SetProperty("SortDSC", Ddo_br_procedure_pxradiotherapy_Sortdsc);
            ucDdo_br_procedure_pxradiotherapy.SetProperty("CleanFilter", Ddo_br_procedure_pxradiotherapy_Cleanfilter);
            ucDdo_br_procedure_pxradiotherapy.SetProperty("SearchButtonText", Ddo_br_procedure_pxradiotherapy_Searchbuttontext);
            ucDdo_br_procedure_pxradiotherapy.SetProperty("DropDownOptionsTitleSettingsIcons", AV68DDO_TitleSettingsIcons);
            ucDdo_br_procedure_pxradiotherapy.SetProperty("DropDownOptionsData", AV38BR_Procedure_PXRadiotherapyTitleFilterData);
            ucDdo_br_procedure_pxradiotherapy.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_procedure_pxradiotherapy_Internalname, "DDO_BR_PROCEDURE_PXRADIOTHERAPYContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 61,'',false,'" + sGXsfl_28_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_procedure_pxradiotherapytitlecontrolidtoreplace_Internalname, AV41ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,61);\"", 0, edtavDdo_br_procedure_pxradiotherapytitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_ProcedureWW.htm");
            /* User Defined Control */
            ucDdo_br_procedure_radiodate.SetProperty("Caption", Ddo_br_procedure_radiodate_Caption);
            ucDdo_br_procedure_radiodate.SetProperty("Tooltip", Ddo_br_procedure_radiodate_Tooltip);
            ucDdo_br_procedure_radiodate.SetProperty("Cls", Ddo_br_procedure_radiodate_Cls);
            ucDdo_br_procedure_radiodate.SetProperty("DropDownOptionsType", Ddo_br_procedure_radiodate_Dropdownoptionstype);
            ucDdo_br_procedure_radiodate.SetProperty("IncludeSortASC", Ddo_br_procedure_radiodate_Includesortasc);
            ucDdo_br_procedure_radiodate.SetProperty("IncludeSortDSC", Ddo_br_procedure_radiodate_Includesortdsc);
            ucDdo_br_procedure_radiodate.SetProperty("IncludeFilter", Ddo_br_procedure_radiodate_Includefilter);
            ucDdo_br_procedure_radiodate.SetProperty("FilterType", Ddo_br_procedure_radiodate_Filtertype);
            ucDdo_br_procedure_radiodate.SetProperty("FilterIsRange", Ddo_br_procedure_radiodate_Filterisrange);
            ucDdo_br_procedure_radiodate.SetProperty("IncludeDataList", Ddo_br_procedure_radiodate_Includedatalist);
            ucDdo_br_procedure_radiodate.SetProperty("SortASC", Ddo_br_procedure_radiodate_Sortasc);
            ucDdo_br_procedure_radiodate.SetProperty("SortDSC", Ddo_br_procedure_radiodate_Sortdsc);
            ucDdo_br_procedure_radiodate.SetProperty("CleanFilter", Ddo_br_procedure_radiodate_Cleanfilter);
            ucDdo_br_procedure_radiodate.SetProperty("RangeFilterFrom", Ddo_br_procedure_radiodate_Rangefilterfrom);
            ucDdo_br_procedure_radiodate.SetProperty("RangeFilterTo", Ddo_br_procedure_radiodate_Rangefilterto);
            ucDdo_br_procedure_radiodate.SetProperty("SearchButtonText", Ddo_br_procedure_radiodate_Searchbuttontext);
            ucDdo_br_procedure_radiodate.SetProperty("DropDownOptionsTitleSettingsIcons", AV68DDO_TitleSettingsIcons);
            ucDdo_br_procedure_radiodate.SetProperty("DropDownOptionsData", AV92BR_Procedure_RadioDateTitleFilterData);
            ucDdo_br_procedure_radiodate.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_procedure_radiodate_Internalname, "DDO_BR_PROCEDURE_RADIODATEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'" + sGXsfl_28_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_procedure_radiodatetitlecontrolidtoreplace_Internalname, AV97ddo_BR_Procedure_RadioDateTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,63);\"", 0, edtavDdo_br_procedure_radiodatetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_ProcedureWW.htm");
            /* User Defined Control */
            ucDdo_br_procedure_radiotime.SetProperty("Caption", Ddo_br_procedure_radiotime_Caption);
            ucDdo_br_procedure_radiotime.SetProperty("Tooltip", Ddo_br_procedure_radiotime_Tooltip);
            ucDdo_br_procedure_radiotime.SetProperty("Cls", Ddo_br_procedure_radiotime_Cls);
            ucDdo_br_procedure_radiotime.SetProperty("DropDownOptionsType", Ddo_br_procedure_radiotime_Dropdownoptionstype);
            ucDdo_br_procedure_radiotime.SetProperty("IncludeSortASC", Ddo_br_procedure_radiotime_Includesortasc);
            ucDdo_br_procedure_radiotime.SetProperty("IncludeSortDSC", Ddo_br_procedure_radiotime_Includesortdsc);
            ucDdo_br_procedure_radiotime.SetProperty("IncludeFilter", Ddo_br_procedure_radiotime_Includefilter);
            ucDdo_br_procedure_radiotime.SetProperty("FilterType", Ddo_br_procedure_radiotime_Filtertype);
            ucDdo_br_procedure_radiotime.SetProperty("FilterIsRange", Ddo_br_procedure_radiotime_Filterisrange);
            ucDdo_br_procedure_radiotime.SetProperty("IncludeDataList", Ddo_br_procedure_radiotime_Includedatalist);
            ucDdo_br_procedure_radiotime.SetProperty("SortASC", Ddo_br_procedure_radiotime_Sortasc);
            ucDdo_br_procedure_radiotime.SetProperty("SortDSC", Ddo_br_procedure_radiotime_Sortdsc);
            ucDdo_br_procedure_radiotime.SetProperty("CleanFilter", Ddo_br_procedure_radiotime_Cleanfilter);
            ucDdo_br_procedure_radiotime.SetProperty("RangeFilterFrom", Ddo_br_procedure_radiotime_Rangefilterfrom);
            ucDdo_br_procedure_radiotime.SetProperty("RangeFilterTo", Ddo_br_procedure_radiotime_Rangefilterto);
            ucDdo_br_procedure_radiotime.SetProperty("SearchButtonText", Ddo_br_procedure_radiotime_Searchbuttontext);
            ucDdo_br_procedure_radiotime.SetProperty("DropDownOptionsTitleSettingsIcons", AV68DDO_TitleSettingsIcons);
            ucDdo_br_procedure_radiotime.SetProperty("DropDownOptionsData", AV98BR_Procedure_RadioTimeTitleFilterData);
            ucDdo_br_procedure_radiotime.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_procedure_radiotime_Internalname, "DDO_BR_PROCEDURE_RADIOTIMEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 65,'',false,'" + sGXsfl_28_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_procedure_radiotimetitlecontrolidtoreplace_Internalname, AV101ddo_BR_Procedure_RadioTimeTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,65);\"", 0, edtavDdo_br_procedure_radiotimetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_ProcedureWW.htm");
            /* User Defined Control */
            ucWorkwithplusutilities1.Render(context, "dvelop.workwithplusutilities", Workwithplusutilities1_Internalname, "WORKWITHPLUSUTILITIES1Container");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 67,'',false,'" + sGXsfl_28_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrderedby_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13OrderedBy), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV13OrderedBy), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,67);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrderedby_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrderedby_Visible, 1, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_ProcedureWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 68,'',false,'" + sGXsfl_28_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrdereddsc_Internalname, StringUtil.BoolToStr( AV14OrderedDsc), StringUtil.BoolToStr( AV14OrderedDsc), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,68);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrdereddsc_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrdereddsc_Visible, 1, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, 0, 0, true, "", "right", false, "HLP_BR_ProcedureWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 69,'',false,'" + sGXsfl_28_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_procedureid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV80TFBR_ProcedureID), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV80TFBR_ProcedureID), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,69);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_procedureid_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_procedureid_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_ProcedureWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 70,'',false,'" + sGXsfl_28_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_procedureid_to_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV81TFBR_ProcedureID_To), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV81TFBR_ProcedureID_To), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,70);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_procedureid_to_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_procedureid_to_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_ProcedureWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 71,'',false,'" + sGXsfl_28_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_encounterid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV19TFBR_EncounterID), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV19TFBR_EncounterID), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,71);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_encounterid_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_encounterid_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_ProcedureWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 72,'',false,'" + sGXsfl_28_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_encounterid_to_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV20TFBR_EncounterID_To), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV20TFBR_EncounterID_To), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,72);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_encounterid_to_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_encounterid_to_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_ProcedureWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 73,'',false,'" + sGXsfl_28_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_information_patientno_Internalname, AV23TFBR_Information_PatientNo, StringUtil.RTrim( context.localUtil.Format( AV23TFBR_Information_PatientNo, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,73);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_information_patientno_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_information_patientno_Visible, 1, 0, "text", "", 80, "chr", 1, "row", 2000, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_ProcedureWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 74,'',false,'" + sGXsfl_28_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_information_patientno_sel_Internalname, AV24TFBR_Information_PatientNo_Sel, StringUtil.RTrim( context.localUtil.Format( AV24TFBR_Information_PatientNo_Sel, "")), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,74);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_information_patientno_sel_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_information_patientno_sel_Visible, 1, 0, "text", "", 80, "chr", 1, "row", 2000, 0, 0, 0, 1, -1, -1, true, "", "left", true, "HLP_BR_ProcedureWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 75,'',false,'" + sGXsfl_28_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_procedure_pxid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV27TFBR_Procedure_PXID), 10, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV27TFBR_Procedure_PXID), "ZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,75);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_procedure_pxid_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_procedure_pxid_Visible, 1, 0, "number", "1", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_ProcedureWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 76,'',false,'" + sGXsfl_28_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_procedure_pxid_to_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV28TFBR_Procedure_PXID_To), 10, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV28TFBR_Procedure_PXID_To), "ZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,76);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_procedure_pxid_to_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_procedure_pxid_to_Visible, 1, 0, "number", "1", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_ProcedureWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 77,'',false,'" + sGXsfl_28_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavTfbr_procedure_date_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavTfbr_procedure_date_Internalname, context.localUtil.Format(AV83TFBR_Procedure_Date, "9999/99/99"), context.localUtil.Format( AV83TFBR_Procedure_Date, "9999/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',0,24,'chs',false,1);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,77);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_procedure_date_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_procedure_date_Visible, 1, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_ProcedureWW.htm");
            GxWebStd.gx_bitmap( context, edtavTfbr_procedure_date_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((edtavTfbr_procedure_date_Visible==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_ProcedureWW.htm");
            context.WriteHtmlTextNl( "</div>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 78,'',false,'" + sGXsfl_28_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavTfbr_procedure_date_to_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavTfbr_procedure_date_to_Internalname, context.localUtil.Format(AV84TFBR_Procedure_Date_To, "9999/99/99"), context.localUtil.Format( AV84TFBR_Procedure_Date_To, "9999/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',0,24,'chs',false,1);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,78);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_procedure_date_to_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_procedure_date_to_Visible, 1, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_ProcedureWW.htm");
            GxWebStd.gx_bitmap( context, edtavTfbr_procedure_date_to_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((edtavTfbr_procedure_date_to_Visible==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_ProcedureWW.htm");
            context.WriteHtmlTextNl( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divDdo_br_procedure_dateauxdates_Internalname, 1, 0, "px", 0, "px", "Invisible", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 80,'',false,'" + sGXsfl_28_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavDdo_br_procedure_dateauxdate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavDdo_br_procedure_dateauxdate_Internalname, context.localUtil.Format(AV85DDO_BR_Procedure_DateAuxDate, "9999/99/99"), context.localUtil.Format( AV85DDO_BR_Procedure_DateAuxDate, "9999/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',0,24,'chs',false,1);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,80);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavDdo_br_procedure_dateauxdate_Jsonclick, 0, "Attribute", "", "", "", "", 1, 1, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_ProcedureWW.htm");
            GxWebStd.gx_bitmap( context, edtavDdo_br_procedure_dateauxdate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_ProcedureWW.htm");
            context.WriteHtmlTextNl( "</div>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 81,'',false,'" + sGXsfl_28_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavDdo_br_procedure_dateauxdateto_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavDdo_br_procedure_dateauxdateto_Internalname, context.localUtil.Format(AV86DDO_BR_Procedure_DateAuxDateTo, "9999/99/99"), context.localUtil.Format( AV86DDO_BR_Procedure_DateAuxDateTo, "9999/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',0,24,'chs',false,1);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,81);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavDdo_br_procedure_dateauxdateto_Jsonclick, 0, "Attribute", "", "", "", "", 1, 1, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_ProcedureWW.htm");
            GxWebStd.gx_bitmap( context, edtavDdo_br_procedure_dateauxdateto_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_ProcedureWW.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 82,'',false,'" + sGXsfl_28_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavTfbr_procedure_radiodate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavTfbr_procedure_radiodate_Internalname, context.localUtil.Format(AV93TFBR_Procedure_RadioDate, "9999/99/99"), context.localUtil.Format( AV93TFBR_Procedure_RadioDate, "9999/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',0,24,'chs',false,1);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,82);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_procedure_radiodate_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_procedure_radiodate_Visible, 1, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_ProcedureWW.htm");
            GxWebStd.gx_bitmap( context, edtavTfbr_procedure_radiodate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((edtavTfbr_procedure_radiodate_Visible==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_ProcedureWW.htm");
            context.WriteHtmlTextNl( "</div>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 83,'',false,'" + sGXsfl_28_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavTfbr_procedure_radiodate_to_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavTfbr_procedure_radiodate_to_Internalname, context.localUtil.Format(AV94TFBR_Procedure_RadioDate_To, "9999/99/99"), context.localUtil.Format( AV94TFBR_Procedure_RadioDate_To, "9999/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',0,24,'chs',false,1);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,83);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_procedure_radiodate_to_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_procedure_radiodate_to_Visible, 1, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_ProcedureWW.htm");
            GxWebStd.gx_bitmap( context, edtavTfbr_procedure_radiodate_to_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((edtavTfbr_procedure_radiodate_to_Visible==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_ProcedureWW.htm");
            context.WriteHtmlTextNl( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divDdo_br_procedure_radiodateauxdates_Internalname, 1, 0, "px", 0, "px", "Invisible", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 85,'',false,'" + sGXsfl_28_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavDdo_br_procedure_radiodateauxdate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavDdo_br_procedure_radiodateauxdate_Internalname, context.localUtil.Format(AV95DDO_BR_Procedure_RadioDateAuxDate, "9999/99/99"), context.localUtil.Format( AV95DDO_BR_Procedure_RadioDateAuxDate, "9999/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',0,24,'chs',false,1);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,85);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavDdo_br_procedure_radiodateauxdate_Jsonclick, 0, "Attribute", "", "", "", "", 1, 1, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_ProcedureWW.htm");
            GxWebStd.gx_bitmap( context, edtavDdo_br_procedure_radiodateauxdate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_ProcedureWW.htm");
            context.WriteHtmlTextNl( "</div>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 86,'',false,'" + sGXsfl_28_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavDdo_br_procedure_radiodateauxdateto_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavDdo_br_procedure_radiodateauxdateto_Internalname, context.localUtil.Format(AV96DDO_BR_Procedure_RadioDateAuxDateTo, "9999/99/99"), context.localUtil.Format( AV96DDO_BR_Procedure_RadioDateAuxDateTo, "9999/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',0,24,'chs',false,1);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,86);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavDdo_br_procedure_radiodateauxdateto_Jsonclick, 0, "Attribute", "", "", "", "", 1, 1, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_ProcedureWW.htm");
            GxWebStd.gx_bitmap( context, edtavDdo_br_procedure_radiodateauxdateto_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_ProcedureWW.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 87,'',false,'" + sGXsfl_28_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_procedure_radiotime_Internalname, StringUtil.LTrim( StringUtil.NToC( AV99TFBR_Procedure_RadioTime, 15, 5, ".", "")), StringUtil.LTrim( context.localUtil.Format( AV99TFBR_Procedure_RadioTime, "ZZZZZZZZZ.ZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, ',','.','5');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,87);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_procedure_radiotime_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_procedure_radiotime_Visible, 1, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_ProcedureWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 88,'',false,'" + sGXsfl_28_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_procedure_radiotime_to_Internalname, StringUtil.LTrim( StringUtil.NToC( AV100TFBR_Procedure_RadioTime_To, 15, 5, ".", "")), StringUtil.LTrim( context.localUtil.Format( AV100TFBR_Procedure_RadioTime_To, "ZZZZZZZZZ.ZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, ',','.','5');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,88);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_procedure_radiotime_to_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_procedure_radiotime_to_Visible, 1, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_ProcedureWW.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         if ( wbEnd == 28 )
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

      protected void START3O2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_0-127771", 0) ;
            Form.Meta.addItem("description", " 诊疗处理", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP3O0( ) ;
      }

      protected void WS3O2( )
      {
         START3O2( ) ;
         EVT3O2( ) ;
      }

      protected void EVT3O2( )
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
                              E113O2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEROWSPERPAGE") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E123O2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PROCEDUREID.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E133O2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_ENCOUNTERID.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E143O2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_INFORMATION_PATIENTNO.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E153O2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PROCEDURE_PXID.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E163O2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PROCEDURE_PXSURGERY.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E173O2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PROCEDURE_DATE.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E183O2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PROCEDURE_PXRADIOTHERAPY.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E193O2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PROCEDURE_RADIODATE.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E203O2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PROCEDURE_RADIOTIME.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E213O2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'DOINSERT'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'DoInsert' */
                              E223O2 ();
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
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 7), "REFRESH") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 9), "GRID.LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) )
                           {
                              nGXsfl_28_idx = (short)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_28_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_28_idx), 4, 0)), 4, "0");
                              SubsflControlProps_282( ) ;
                              AV73Display = cgiGet( edtavDisplay_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDisplay_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV73Display)) ? AV121Display_GXI : context.convertURL( context.PathToRelativeUrl( AV73Display))), !bGXsfl_28_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDisplay_Internalname, "SrcSet", context.GetImageSrcSet( AV73Display), true);
                              AV74Update = cgiGet( edtavUpdate_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV74Update)) ? AV122Update_GXI : context.convertURL( context.PathToRelativeUrl( AV74Update))), !bGXsfl_28_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "SrcSet", context.GetImageSrcSet( AV74Update), true);
                              AV76Delete = cgiGet( edtavDelete_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV76Delete)) ? AV123Delete_GXI : context.convertURL( context.PathToRelativeUrl( AV76Delete))), !bGXsfl_28_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "SrcSet", context.GetImageSrcSet( AV76Delete), true);
                              A139BR_ProcedureID = (long)(context.localUtil.CToN( cgiGet( edtBR_ProcedureID_Internalname), ".", ","));
                              A19BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( edtBR_EncounterID_Internalname), ".", ","));
                              n19BR_EncounterID = false;
                              A36BR_Information_PatientNo = cgiGet( edtBR_Information_PatientNo_Internalname);
                              n36BR_Information_PatientNo = false;
                              A140BR_Procedure_PXID = (long)(context.localUtil.CToN( cgiGet( edtBR_Procedure_PXID_Internalname), ".", ","));
                              n140BR_Procedure_PXID = false;
                              cmbBR_Procedure_PXSurgery.Name = cmbBR_Procedure_PXSurgery_Internalname;
                              cmbBR_Procedure_PXSurgery.CurrentValue = cgiGet( cmbBR_Procedure_PXSurgery_Internalname);
                              A141BR_Procedure_PXSurgery = cgiGet( cmbBR_Procedure_PXSurgery_Internalname);
                              n141BR_Procedure_PXSurgery = false;
                              A266BR_Procedure_Date = DateTimeUtil.ResetTime(context.localUtil.CToT( cgiGet( edtBR_Procedure_Date_Internalname), 0));
                              n266BR_Procedure_Date = false;
                              cmbBR_Procedure_PXRadiotherapy.Name = cmbBR_Procedure_PXRadiotherapy_Internalname;
                              cmbBR_Procedure_PXRadiotherapy.CurrentValue = cgiGet( cmbBR_Procedure_PXRadiotherapy_Internalname);
                              A143BR_Procedure_PXRadiotherapy = cgiGet( cmbBR_Procedure_PXRadiotherapy_Internalname);
                              n143BR_Procedure_PXRadiotherapy = false;
                              A268BR_Procedure_RadioDate = DateTimeUtil.ResetTime(context.localUtil.CToT( cgiGet( edtBR_Procedure_RadioDate_Internalname), 0));
                              n268BR_Procedure_RadioDate = false;
                              A269BR_Procedure_RadioTime = context.localUtil.CToN( cgiGet( edtBR_Procedure_RadioTime_Internalname), ".", ",");
                              n269BR_Procedure_RadioTime = false;
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E233O2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Refresh */
                                    E243O2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "GRID.LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    E253O2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false;
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
                                       /* Set Refresh If Tfbr_procedureid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_PROCEDUREID"), ".", ",") != Convert.ToDecimal( AV80TFBR_ProcedureID )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_procedureid_to Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_PROCEDUREID_TO"), ".", ",") != Convert.ToDecimal( AV81TFBR_ProcedureID_To )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_encounterid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_ENCOUNTERID"), ".", ",") != Convert.ToDecimal( AV19TFBR_EncounterID )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_encounterid_to Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_ENCOUNTERID_TO"), ".", ",") != Convert.ToDecimal( AV20TFBR_EncounterID_To )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_information_patientno Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_INFORMATION_PATIENTNO"), AV23TFBR_Information_PatientNo) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_information_patientno_sel Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_INFORMATION_PATIENTNO_SEL"), AV24TFBR_Information_PatientNo_Sel) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_procedure_pxid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_PROCEDURE_PXID"), ".", ",") != Convert.ToDecimal( AV27TFBR_Procedure_PXID )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_procedure_pxid_to Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_PROCEDURE_PXID_TO"), ".", ",") != Convert.ToDecimal( AV28TFBR_Procedure_PXID_To )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_procedure_date Changed */
                                       if ( context.localUtil.CToT( cgiGet( "GXH_vTFBR_PROCEDURE_DATE"), 0) != AV83TFBR_Procedure_Date )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_procedure_date_to Changed */
                                       if ( context.localUtil.CToT( cgiGet( "GXH_vTFBR_PROCEDURE_DATE_TO"), 0) != AV84TFBR_Procedure_Date_To )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_procedure_radiodate Changed */
                                       if ( context.localUtil.CToT( cgiGet( "GXH_vTFBR_PROCEDURE_RADIODATE"), 0) != AV93TFBR_Procedure_RadioDate )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_procedure_radiodate_to Changed */
                                       if ( context.localUtil.CToT( cgiGet( "GXH_vTFBR_PROCEDURE_RADIODATE_TO"), 0) != AV94TFBR_Procedure_RadioDate_To )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_procedure_radiotime Changed */
                                       if ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_PROCEDURE_RADIOTIME"), ".", ",") != AV99TFBR_Procedure_RadioTime )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_procedure_radiotime_to Changed */
                                       if ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_PROCEDURE_RADIOTIME_TO"), ".", ",") != AV100TFBR_Procedure_RadioTime_To )
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

      protected void WE3O2( )
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

      protected void PA3O2( )
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
               GX_FocusControl = edtavDdo_br_procedureidtitlecontrolidtoreplace_Internalname;
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
         SubsflControlProps_282( ) ;
         while ( nGXsfl_28_idx <= nRC_GXsfl_28 )
         {
            sendrow_282( ) ;
            nGXsfl_28_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_28_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_28_idx+1));
            sGXsfl_28_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_28_idx), 4, 0)), 4, "0");
            SubsflControlProps_282( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( GridContainer));
         /* End function gxnrGrid_newrow */
      }

      protected void gxgrGrid_refresh( int subGrid_Rows ,
                                       short AV13OrderedBy ,
                                       bool AV14OrderedDsc ,
                                       long AV80TFBR_ProcedureID ,
                                       long AV81TFBR_ProcedureID_To ,
                                       long AV19TFBR_EncounterID ,
                                       long AV20TFBR_EncounterID_To ,
                                       String AV23TFBR_Information_PatientNo ,
                                       String AV24TFBR_Information_PatientNo_Sel ,
                                       long AV27TFBR_Procedure_PXID ,
                                       long AV28TFBR_Procedure_PXID_To ,
                                       DateTime AV83TFBR_Procedure_Date ,
                                       DateTime AV84TFBR_Procedure_Date_To ,
                                       DateTime AV93TFBR_Procedure_RadioDate ,
                                       DateTime AV94TFBR_Procedure_RadioDate_To ,
                                       decimal AV99TFBR_Procedure_RadioTime ,
                                       decimal AV100TFBR_Procedure_RadioTime_To ,
                                       String AV17ddo_BR_ProcedureIDTitleControlIdToReplace ,
                                       String AV21ddo_BR_EncounterIDTitleControlIdToReplace ,
                                       String AV25ddo_BR_Information_PatientNoTitleControlIdToReplace ,
                                       String AV29ddo_BR_Procedure_PXIDTitleControlIdToReplace ,
                                       String AV33ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace ,
                                       String AV87ddo_BR_Procedure_DateTitleControlIdToReplace ,
                                       String AV41ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace ,
                                       String AV97ddo_BR_Procedure_RadioDateTitleControlIdToReplace ,
                                       String AV101ddo_BR_Procedure_RadioTimeTitleControlIdToReplace ,
                                       GxSimpleCollection<String> AV32TFBR_Procedure_PXSurgery_Sels ,
                                       GxSimpleCollection<String> AV40TFBR_Procedure_PXRadiotherapy_Sels ,
                                       String AV124Pgmname ,
                                       bool AV75IsAuthorized_Update ,
                                       bool AV77IsAuthorized_Delete ,
                                       bool AV78IsAuthorized_BR_Information_PatientNo )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GRID_nCurrentRecord = 0;
         RF3O2( ) ;
         /* End function gxgrGrid_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_BR_PROCEDUREID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A139BR_ProcedureID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, "BR_PROCEDUREID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A139BR_ProcedureID), 18, 0, ".", "")));
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
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF3O2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV124Pgmname = "BR_ProcedureWW";
         context.Gx_err = 0;
      }

      protected void RF3O2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridContainer.ClearRows();
         }
         wbStart = 28;
         /* Execute user event: Refresh */
         E243O2 ();
         nGXsfl_28_idx = 1;
         sGXsfl_28_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_28_idx), 4, 0)), 4, "0");
         SubsflControlProps_282( ) ;
         bGXsfl_28_Refreshing = true;
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
            SubsflControlProps_282( ) ;
            GXPagingFrom2 = (int)(((subGrid_Rows==0) ? 0 : GRID_nFirstRecordOnPage));
            GXPagingTo2 = ((subGrid_Rows==0) ? 10000 : subGrid_Recordsperpage( )+1);
            pr_default.dynParam(0, new Object[]{ new Object[]{
                                                 A141BR_Procedure_PXSurgery ,
                                                 AV113BR_ProcedureWWDS_9_Tfbr_procedure_pxsurgery_sels ,
                                                 A143BR_Procedure_PXRadiotherapy ,
                                                 AV116BR_ProcedureWWDS_12_Tfbr_procedure_pxradiotherapy_sels ,
                                                 AV105BR_ProcedureWWDS_1_Tfbr_procedureid ,
                                                 AV106BR_ProcedureWWDS_2_Tfbr_procedureid_to ,
                                                 AV107BR_ProcedureWWDS_3_Tfbr_encounterid ,
                                                 AV108BR_ProcedureWWDS_4_Tfbr_encounterid_to ,
                                                 AV110BR_ProcedureWWDS_6_Tfbr_information_patientno_sel ,
                                                 AV109BR_ProcedureWWDS_5_Tfbr_information_patientno ,
                                                 AV111BR_ProcedureWWDS_7_Tfbr_procedure_pxid ,
                                                 AV112BR_ProcedureWWDS_8_Tfbr_procedure_pxid_to ,
                                                 AV113BR_ProcedureWWDS_9_Tfbr_procedure_pxsurgery_sels.Count ,
                                                 AV114BR_ProcedureWWDS_10_Tfbr_procedure_date ,
                                                 AV115BR_ProcedureWWDS_11_Tfbr_procedure_date_to ,
                                                 AV116BR_ProcedureWWDS_12_Tfbr_procedure_pxradiotherapy_sels.Count ,
                                                 AV117BR_ProcedureWWDS_13_Tfbr_procedure_radiodate ,
                                                 AV118BR_ProcedureWWDS_14_Tfbr_procedure_radiodate_to ,
                                                 AV119BR_ProcedureWWDS_15_Tfbr_procedure_radiotime ,
                                                 AV120BR_ProcedureWWDS_16_Tfbr_procedure_radiotime_to ,
                                                 A139BR_ProcedureID ,
                                                 A19BR_EncounterID ,
                                                 A36BR_Information_PatientNo ,
                                                 A140BR_Procedure_PXID ,
                                                 A266BR_Procedure_Date ,
                                                 A268BR_Procedure_RadioDate ,
                                                 A269BR_Procedure_RadioTime ,
                                                 AV13OrderedBy ,
                                                 AV14OrderedDsc } ,
                                                 new int[]{
                                                 TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING,
                                                 TypeConstants.LONG, TypeConstants.LONG, TypeConstants.INT, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.INT, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.DECIMAL, TypeConstants.DECIMAL,
                                                 TypeConstants.LONG, TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.DATE, TypeConstants.BOOLEAN, TypeConstants.DATE,
                                                 TypeConstants.BOOLEAN, TypeConstants.DECIMAL, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN
                                                 }
            } ) ;
            lV109BR_ProcedureWWDS_5_Tfbr_information_patientno = StringUtil.Concat( StringUtil.RTrim( AV109BR_ProcedureWWDS_5_Tfbr_information_patientno), "%", "");
            /* Using cursor H003O2 */
            pr_default.execute(0, new Object[] {AV105BR_ProcedureWWDS_1_Tfbr_procedureid, AV106BR_ProcedureWWDS_2_Tfbr_procedureid_to, AV107BR_ProcedureWWDS_3_Tfbr_encounterid, AV108BR_ProcedureWWDS_4_Tfbr_encounterid_to, lV109BR_ProcedureWWDS_5_Tfbr_information_patientno, AV110BR_ProcedureWWDS_6_Tfbr_information_patientno_sel, AV111BR_ProcedureWWDS_7_Tfbr_procedure_pxid, AV112BR_ProcedureWWDS_8_Tfbr_procedure_pxid_to, AV114BR_ProcedureWWDS_10_Tfbr_procedure_date, AV115BR_ProcedureWWDS_11_Tfbr_procedure_date_to, AV117BR_ProcedureWWDS_13_Tfbr_procedure_radiodate, AV118BR_ProcedureWWDS_14_Tfbr_procedure_radiodate_to, AV119BR_ProcedureWWDS_15_Tfbr_procedure_radiotime, AV120BR_ProcedureWWDS_16_Tfbr_procedure_radiotime_to, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_28_idx = 1;
            sGXsfl_28_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_28_idx), 4, 0)), 4, "0");
            SubsflControlProps_282( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < subGrid_Recordsperpage( ) ) ) ) )
            {
               A85BR_Information_ID = H003O2_A85BR_Information_ID[0];
               n85BR_Information_ID = H003O2_n85BR_Information_ID[0];
               A269BR_Procedure_RadioTime = H003O2_A269BR_Procedure_RadioTime[0];
               n269BR_Procedure_RadioTime = H003O2_n269BR_Procedure_RadioTime[0];
               A268BR_Procedure_RadioDate = H003O2_A268BR_Procedure_RadioDate[0];
               n268BR_Procedure_RadioDate = H003O2_n268BR_Procedure_RadioDate[0];
               A143BR_Procedure_PXRadiotherapy = H003O2_A143BR_Procedure_PXRadiotherapy[0];
               n143BR_Procedure_PXRadiotherapy = H003O2_n143BR_Procedure_PXRadiotherapy[0];
               A266BR_Procedure_Date = H003O2_A266BR_Procedure_Date[0];
               n266BR_Procedure_Date = H003O2_n266BR_Procedure_Date[0];
               A141BR_Procedure_PXSurgery = H003O2_A141BR_Procedure_PXSurgery[0];
               n141BR_Procedure_PXSurgery = H003O2_n141BR_Procedure_PXSurgery[0];
               A140BR_Procedure_PXID = H003O2_A140BR_Procedure_PXID[0];
               n140BR_Procedure_PXID = H003O2_n140BR_Procedure_PXID[0];
               A36BR_Information_PatientNo = H003O2_A36BR_Information_PatientNo[0];
               n36BR_Information_PatientNo = H003O2_n36BR_Information_PatientNo[0];
               A19BR_EncounterID = H003O2_A19BR_EncounterID[0];
               n19BR_EncounterID = H003O2_n19BR_EncounterID[0];
               A139BR_ProcedureID = H003O2_A139BR_ProcedureID[0];
               A85BR_Information_ID = H003O2_A85BR_Information_ID[0];
               n85BR_Information_ID = H003O2_n85BR_Information_ID[0];
               A36BR_Information_PatientNo = H003O2_A36BR_Information_PatientNo[0];
               n36BR_Information_PatientNo = H003O2_n36BR_Information_PatientNo[0];
               E253O2 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 28;
            WB3O0( ) ;
         }
         bGXsfl_28_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes3O2( )
      {
         GxWebStd.gx_boolean_hidden_field( context, "vISAUTHORIZED_BR_INFORMATION_PATIENTNO", AV78IsAuthorized_BR_Information_PatientNo);
         GxWebStd.gx_hidden_field( context, "gxhash_vISAUTHORIZED_BR_INFORMATION_PATIENTNO", GetSecureSignedToken( "", AV78IsAuthorized_BR_Information_PatientNo, context));
         GxWebStd.gx_hidden_field( context, "gxhash_BR_PROCEDUREID"+"_"+sGXsfl_28_idx, GetSecureSignedToken( sGXsfl_28_idx, context.localUtil.Format( (decimal)(A139BR_ProcedureID), "ZZZZZZZZZZZZZZZZZZ"), context));
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
         AV105BR_ProcedureWWDS_1_Tfbr_procedureid = AV80TFBR_ProcedureID;
         AV106BR_ProcedureWWDS_2_Tfbr_procedureid_to = AV81TFBR_ProcedureID_To;
         AV107BR_ProcedureWWDS_3_Tfbr_encounterid = AV19TFBR_EncounterID;
         AV108BR_ProcedureWWDS_4_Tfbr_encounterid_to = AV20TFBR_EncounterID_To;
         AV109BR_ProcedureWWDS_5_Tfbr_information_patientno = AV23TFBR_Information_PatientNo;
         AV110BR_ProcedureWWDS_6_Tfbr_information_patientno_sel = AV24TFBR_Information_PatientNo_Sel;
         AV111BR_ProcedureWWDS_7_Tfbr_procedure_pxid = AV27TFBR_Procedure_PXID;
         AV112BR_ProcedureWWDS_8_Tfbr_procedure_pxid_to = AV28TFBR_Procedure_PXID_To;
         AV113BR_ProcedureWWDS_9_Tfbr_procedure_pxsurgery_sels = AV32TFBR_Procedure_PXSurgery_Sels;
         AV114BR_ProcedureWWDS_10_Tfbr_procedure_date = AV83TFBR_Procedure_Date;
         AV115BR_ProcedureWWDS_11_Tfbr_procedure_date_to = AV84TFBR_Procedure_Date_To;
         AV116BR_ProcedureWWDS_12_Tfbr_procedure_pxradiotherapy_sels = AV40TFBR_Procedure_PXRadiotherapy_Sels;
         AV117BR_ProcedureWWDS_13_Tfbr_procedure_radiodate = AV93TFBR_Procedure_RadioDate;
         AV118BR_ProcedureWWDS_14_Tfbr_procedure_radiodate_to = AV94TFBR_Procedure_RadioDate_To;
         AV119BR_ProcedureWWDS_15_Tfbr_procedure_radiotime = AV99TFBR_Procedure_RadioTime;
         AV120BR_ProcedureWWDS_16_Tfbr_procedure_radiotime_to = AV100TFBR_Procedure_RadioTime_To;
         pr_default.dynParam(1, new Object[]{ new Object[]{
                                              A141BR_Procedure_PXSurgery ,
                                              AV113BR_ProcedureWWDS_9_Tfbr_procedure_pxsurgery_sels ,
                                              A143BR_Procedure_PXRadiotherapy ,
                                              AV116BR_ProcedureWWDS_12_Tfbr_procedure_pxradiotherapy_sels ,
                                              AV105BR_ProcedureWWDS_1_Tfbr_procedureid ,
                                              AV106BR_ProcedureWWDS_2_Tfbr_procedureid_to ,
                                              AV107BR_ProcedureWWDS_3_Tfbr_encounterid ,
                                              AV108BR_ProcedureWWDS_4_Tfbr_encounterid_to ,
                                              AV110BR_ProcedureWWDS_6_Tfbr_information_patientno_sel ,
                                              AV109BR_ProcedureWWDS_5_Tfbr_information_patientno ,
                                              AV111BR_ProcedureWWDS_7_Tfbr_procedure_pxid ,
                                              AV112BR_ProcedureWWDS_8_Tfbr_procedure_pxid_to ,
                                              AV113BR_ProcedureWWDS_9_Tfbr_procedure_pxsurgery_sels.Count ,
                                              AV114BR_ProcedureWWDS_10_Tfbr_procedure_date ,
                                              AV115BR_ProcedureWWDS_11_Tfbr_procedure_date_to ,
                                              AV116BR_ProcedureWWDS_12_Tfbr_procedure_pxradiotherapy_sels.Count ,
                                              AV117BR_ProcedureWWDS_13_Tfbr_procedure_radiodate ,
                                              AV118BR_ProcedureWWDS_14_Tfbr_procedure_radiodate_to ,
                                              AV119BR_ProcedureWWDS_15_Tfbr_procedure_radiotime ,
                                              AV120BR_ProcedureWWDS_16_Tfbr_procedure_radiotime_to ,
                                              A139BR_ProcedureID ,
                                              A19BR_EncounterID ,
                                              A36BR_Information_PatientNo ,
                                              A140BR_Procedure_PXID ,
                                              A266BR_Procedure_Date ,
                                              A268BR_Procedure_RadioDate ,
                                              A269BR_Procedure_RadioTime ,
                                              AV13OrderedBy ,
                                              AV14OrderedDsc } ,
                                              new int[]{
                                              TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING,
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.INT, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.INT, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.DECIMAL, TypeConstants.DECIMAL,
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.DATE, TypeConstants.BOOLEAN, TypeConstants.DATE,
                                              TypeConstants.BOOLEAN, TypeConstants.DECIMAL, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV109BR_ProcedureWWDS_5_Tfbr_information_patientno = StringUtil.Concat( StringUtil.RTrim( AV109BR_ProcedureWWDS_5_Tfbr_information_patientno), "%", "");
         /* Using cursor H003O3 */
         pr_default.execute(1, new Object[] {AV105BR_ProcedureWWDS_1_Tfbr_procedureid, AV106BR_ProcedureWWDS_2_Tfbr_procedureid_to, AV107BR_ProcedureWWDS_3_Tfbr_encounterid, AV108BR_ProcedureWWDS_4_Tfbr_encounterid_to, lV109BR_ProcedureWWDS_5_Tfbr_information_patientno, AV110BR_ProcedureWWDS_6_Tfbr_information_patientno_sel, AV111BR_ProcedureWWDS_7_Tfbr_procedure_pxid, AV112BR_ProcedureWWDS_8_Tfbr_procedure_pxid_to, AV114BR_ProcedureWWDS_10_Tfbr_procedure_date, AV115BR_ProcedureWWDS_11_Tfbr_procedure_date_to, AV117BR_ProcedureWWDS_13_Tfbr_procedure_radiodate, AV118BR_ProcedureWWDS_14_Tfbr_procedure_radiodate_to, AV119BR_ProcedureWWDS_15_Tfbr_procedure_radiotime, AV120BR_ProcedureWWDS_16_Tfbr_procedure_radiotime_to});
         GRID_nRecordCount = H003O3_AGRID_nRecordCount[0];
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
         AV105BR_ProcedureWWDS_1_Tfbr_procedureid = AV80TFBR_ProcedureID;
         AV106BR_ProcedureWWDS_2_Tfbr_procedureid_to = AV81TFBR_ProcedureID_To;
         AV107BR_ProcedureWWDS_3_Tfbr_encounterid = AV19TFBR_EncounterID;
         AV108BR_ProcedureWWDS_4_Tfbr_encounterid_to = AV20TFBR_EncounterID_To;
         AV109BR_ProcedureWWDS_5_Tfbr_information_patientno = AV23TFBR_Information_PatientNo;
         AV110BR_ProcedureWWDS_6_Tfbr_information_patientno_sel = AV24TFBR_Information_PatientNo_Sel;
         AV111BR_ProcedureWWDS_7_Tfbr_procedure_pxid = AV27TFBR_Procedure_PXID;
         AV112BR_ProcedureWWDS_8_Tfbr_procedure_pxid_to = AV28TFBR_Procedure_PXID_To;
         AV113BR_ProcedureWWDS_9_Tfbr_procedure_pxsurgery_sels = AV32TFBR_Procedure_PXSurgery_Sels;
         AV114BR_ProcedureWWDS_10_Tfbr_procedure_date = AV83TFBR_Procedure_Date;
         AV115BR_ProcedureWWDS_11_Tfbr_procedure_date_to = AV84TFBR_Procedure_Date_To;
         AV116BR_ProcedureWWDS_12_Tfbr_procedure_pxradiotherapy_sels = AV40TFBR_Procedure_PXRadiotherapy_Sels;
         AV117BR_ProcedureWWDS_13_Tfbr_procedure_radiodate = AV93TFBR_Procedure_RadioDate;
         AV118BR_ProcedureWWDS_14_Tfbr_procedure_radiodate_to = AV94TFBR_Procedure_RadioDate_To;
         AV119BR_ProcedureWWDS_15_Tfbr_procedure_radiotime = AV99TFBR_Procedure_RadioTime;
         AV120BR_ProcedureWWDS_16_Tfbr_procedure_radiotime_to = AV100TFBR_Procedure_RadioTime_To;
         GRID_nFirstRecordOnPage = 0;
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV80TFBR_ProcedureID, AV81TFBR_ProcedureID_To, AV19TFBR_EncounterID, AV20TFBR_EncounterID_To, AV23TFBR_Information_PatientNo, AV24TFBR_Information_PatientNo_Sel, AV27TFBR_Procedure_PXID, AV28TFBR_Procedure_PXID_To, AV83TFBR_Procedure_Date, AV84TFBR_Procedure_Date_To, AV93TFBR_Procedure_RadioDate, AV94TFBR_Procedure_RadioDate_To, AV99TFBR_Procedure_RadioTime, AV100TFBR_Procedure_RadioTime_To, AV17ddo_BR_ProcedureIDTitleControlIdToReplace, AV21ddo_BR_EncounterIDTitleControlIdToReplace, AV25ddo_BR_Information_PatientNoTitleControlIdToReplace, AV29ddo_BR_Procedure_PXIDTitleControlIdToReplace, AV33ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace, AV87ddo_BR_Procedure_DateTitleControlIdToReplace, AV41ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace, AV97ddo_BR_Procedure_RadioDateTitleControlIdToReplace, AV101ddo_BR_Procedure_RadioTimeTitleControlIdToReplace, AV32TFBR_Procedure_PXSurgery_Sels, AV40TFBR_Procedure_PXRadiotherapy_Sels, AV124Pgmname, AV75IsAuthorized_Update, AV77IsAuthorized_Delete, AV78IsAuthorized_BR_Information_PatientNo) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid_nextpage( )
      {
         AV105BR_ProcedureWWDS_1_Tfbr_procedureid = AV80TFBR_ProcedureID;
         AV106BR_ProcedureWWDS_2_Tfbr_procedureid_to = AV81TFBR_ProcedureID_To;
         AV107BR_ProcedureWWDS_3_Tfbr_encounterid = AV19TFBR_EncounterID;
         AV108BR_ProcedureWWDS_4_Tfbr_encounterid_to = AV20TFBR_EncounterID_To;
         AV109BR_ProcedureWWDS_5_Tfbr_information_patientno = AV23TFBR_Information_PatientNo;
         AV110BR_ProcedureWWDS_6_Tfbr_information_patientno_sel = AV24TFBR_Information_PatientNo_Sel;
         AV111BR_ProcedureWWDS_7_Tfbr_procedure_pxid = AV27TFBR_Procedure_PXID;
         AV112BR_ProcedureWWDS_8_Tfbr_procedure_pxid_to = AV28TFBR_Procedure_PXID_To;
         AV113BR_ProcedureWWDS_9_Tfbr_procedure_pxsurgery_sels = AV32TFBR_Procedure_PXSurgery_Sels;
         AV114BR_ProcedureWWDS_10_Tfbr_procedure_date = AV83TFBR_Procedure_Date;
         AV115BR_ProcedureWWDS_11_Tfbr_procedure_date_to = AV84TFBR_Procedure_Date_To;
         AV116BR_ProcedureWWDS_12_Tfbr_procedure_pxradiotherapy_sels = AV40TFBR_Procedure_PXRadiotherapy_Sels;
         AV117BR_ProcedureWWDS_13_Tfbr_procedure_radiodate = AV93TFBR_Procedure_RadioDate;
         AV118BR_ProcedureWWDS_14_Tfbr_procedure_radiodate_to = AV94TFBR_Procedure_RadioDate_To;
         AV119BR_ProcedureWWDS_15_Tfbr_procedure_radiotime = AV99TFBR_Procedure_RadioTime;
         AV120BR_ProcedureWWDS_16_Tfbr_procedure_radiotime_to = AV100TFBR_Procedure_RadioTime_To;
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
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV80TFBR_ProcedureID, AV81TFBR_ProcedureID_To, AV19TFBR_EncounterID, AV20TFBR_EncounterID_To, AV23TFBR_Information_PatientNo, AV24TFBR_Information_PatientNo_Sel, AV27TFBR_Procedure_PXID, AV28TFBR_Procedure_PXID_To, AV83TFBR_Procedure_Date, AV84TFBR_Procedure_Date_To, AV93TFBR_Procedure_RadioDate, AV94TFBR_Procedure_RadioDate_To, AV99TFBR_Procedure_RadioTime, AV100TFBR_Procedure_RadioTime_To, AV17ddo_BR_ProcedureIDTitleControlIdToReplace, AV21ddo_BR_EncounterIDTitleControlIdToReplace, AV25ddo_BR_Information_PatientNoTitleControlIdToReplace, AV29ddo_BR_Procedure_PXIDTitleControlIdToReplace, AV33ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace, AV87ddo_BR_Procedure_DateTitleControlIdToReplace, AV41ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace, AV97ddo_BR_Procedure_RadioDateTitleControlIdToReplace, AV101ddo_BR_Procedure_RadioTimeTitleControlIdToReplace, AV32TFBR_Procedure_PXSurgery_Sels, AV40TFBR_Procedure_PXRadiotherapy_Sels, AV124Pgmname, AV75IsAuthorized_Update, AV77IsAuthorized_Delete, AV78IsAuthorized_BR_Information_PatientNo) ;
         }
         send_integrity_footer_hashes( ) ;
         return (short)(((GRID_nEOF==0) ? 0 : 2)) ;
      }

      protected short subgrid_previouspage( )
      {
         AV105BR_ProcedureWWDS_1_Tfbr_procedureid = AV80TFBR_ProcedureID;
         AV106BR_ProcedureWWDS_2_Tfbr_procedureid_to = AV81TFBR_ProcedureID_To;
         AV107BR_ProcedureWWDS_3_Tfbr_encounterid = AV19TFBR_EncounterID;
         AV108BR_ProcedureWWDS_4_Tfbr_encounterid_to = AV20TFBR_EncounterID_To;
         AV109BR_ProcedureWWDS_5_Tfbr_information_patientno = AV23TFBR_Information_PatientNo;
         AV110BR_ProcedureWWDS_6_Tfbr_information_patientno_sel = AV24TFBR_Information_PatientNo_Sel;
         AV111BR_ProcedureWWDS_7_Tfbr_procedure_pxid = AV27TFBR_Procedure_PXID;
         AV112BR_ProcedureWWDS_8_Tfbr_procedure_pxid_to = AV28TFBR_Procedure_PXID_To;
         AV113BR_ProcedureWWDS_9_Tfbr_procedure_pxsurgery_sels = AV32TFBR_Procedure_PXSurgery_Sels;
         AV114BR_ProcedureWWDS_10_Tfbr_procedure_date = AV83TFBR_Procedure_Date;
         AV115BR_ProcedureWWDS_11_Tfbr_procedure_date_to = AV84TFBR_Procedure_Date_To;
         AV116BR_ProcedureWWDS_12_Tfbr_procedure_pxradiotherapy_sels = AV40TFBR_Procedure_PXRadiotherapy_Sels;
         AV117BR_ProcedureWWDS_13_Tfbr_procedure_radiodate = AV93TFBR_Procedure_RadioDate;
         AV118BR_ProcedureWWDS_14_Tfbr_procedure_radiodate_to = AV94TFBR_Procedure_RadioDate_To;
         AV119BR_ProcedureWWDS_15_Tfbr_procedure_radiotime = AV99TFBR_Procedure_RadioTime;
         AV120BR_ProcedureWWDS_16_Tfbr_procedure_radiotime_to = AV100TFBR_Procedure_RadioTime_To;
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
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV80TFBR_ProcedureID, AV81TFBR_ProcedureID_To, AV19TFBR_EncounterID, AV20TFBR_EncounterID_To, AV23TFBR_Information_PatientNo, AV24TFBR_Information_PatientNo_Sel, AV27TFBR_Procedure_PXID, AV28TFBR_Procedure_PXID_To, AV83TFBR_Procedure_Date, AV84TFBR_Procedure_Date_To, AV93TFBR_Procedure_RadioDate, AV94TFBR_Procedure_RadioDate_To, AV99TFBR_Procedure_RadioTime, AV100TFBR_Procedure_RadioTime_To, AV17ddo_BR_ProcedureIDTitleControlIdToReplace, AV21ddo_BR_EncounterIDTitleControlIdToReplace, AV25ddo_BR_Information_PatientNoTitleControlIdToReplace, AV29ddo_BR_Procedure_PXIDTitleControlIdToReplace, AV33ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace, AV87ddo_BR_Procedure_DateTitleControlIdToReplace, AV41ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace, AV97ddo_BR_Procedure_RadioDateTitleControlIdToReplace, AV101ddo_BR_Procedure_RadioTimeTitleControlIdToReplace, AV32TFBR_Procedure_PXSurgery_Sels, AV40TFBR_Procedure_PXRadiotherapy_Sels, AV124Pgmname, AV75IsAuthorized_Update, AV77IsAuthorized_Delete, AV78IsAuthorized_BR_Information_PatientNo) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid_lastpage( )
      {
         AV105BR_ProcedureWWDS_1_Tfbr_procedureid = AV80TFBR_ProcedureID;
         AV106BR_ProcedureWWDS_2_Tfbr_procedureid_to = AV81TFBR_ProcedureID_To;
         AV107BR_ProcedureWWDS_3_Tfbr_encounterid = AV19TFBR_EncounterID;
         AV108BR_ProcedureWWDS_4_Tfbr_encounterid_to = AV20TFBR_EncounterID_To;
         AV109BR_ProcedureWWDS_5_Tfbr_information_patientno = AV23TFBR_Information_PatientNo;
         AV110BR_ProcedureWWDS_6_Tfbr_information_patientno_sel = AV24TFBR_Information_PatientNo_Sel;
         AV111BR_ProcedureWWDS_7_Tfbr_procedure_pxid = AV27TFBR_Procedure_PXID;
         AV112BR_ProcedureWWDS_8_Tfbr_procedure_pxid_to = AV28TFBR_Procedure_PXID_To;
         AV113BR_ProcedureWWDS_9_Tfbr_procedure_pxsurgery_sels = AV32TFBR_Procedure_PXSurgery_Sels;
         AV114BR_ProcedureWWDS_10_Tfbr_procedure_date = AV83TFBR_Procedure_Date;
         AV115BR_ProcedureWWDS_11_Tfbr_procedure_date_to = AV84TFBR_Procedure_Date_To;
         AV116BR_ProcedureWWDS_12_Tfbr_procedure_pxradiotherapy_sels = AV40TFBR_Procedure_PXRadiotherapy_Sels;
         AV117BR_ProcedureWWDS_13_Tfbr_procedure_radiodate = AV93TFBR_Procedure_RadioDate;
         AV118BR_ProcedureWWDS_14_Tfbr_procedure_radiodate_to = AV94TFBR_Procedure_RadioDate_To;
         AV119BR_ProcedureWWDS_15_Tfbr_procedure_radiotime = AV99TFBR_Procedure_RadioTime;
         AV120BR_ProcedureWWDS_16_Tfbr_procedure_radiotime_to = AV100TFBR_Procedure_RadioTime_To;
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
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV80TFBR_ProcedureID, AV81TFBR_ProcedureID_To, AV19TFBR_EncounterID, AV20TFBR_EncounterID_To, AV23TFBR_Information_PatientNo, AV24TFBR_Information_PatientNo_Sel, AV27TFBR_Procedure_PXID, AV28TFBR_Procedure_PXID_To, AV83TFBR_Procedure_Date, AV84TFBR_Procedure_Date_To, AV93TFBR_Procedure_RadioDate, AV94TFBR_Procedure_RadioDate_To, AV99TFBR_Procedure_RadioTime, AV100TFBR_Procedure_RadioTime_To, AV17ddo_BR_ProcedureIDTitleControlIdToReplace, AV21ddo_BR_EncounterIDTitleControlIdToReplace, AV25ddo_BR_Information_PatientNoTitleControlIdToReplace, AV29ddo_BR_Procedure_PXIDTitleControlIdToReplace, AV33ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace, AV87ddo_BR_Procedure_DateTitleControlIdToReplace, AV41ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace, AV97ddo_BR_Procedure_RadioDateTitleControlIdToReplace, AV101ddo_BR_Procedure_RadioTimeTitleControlIdToReplace, AV32TFBR_Procedure_PXSurgery_Sels, AV40TFBR_Procedure_PXRadiotherapy_Sels, AV124Pgmname, AV75IsAuthorized_Update, AV77IsAuthorized_Delete, AV78IsAuthorized_BR_Information_PatientNo) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected int subgrid_gotopage( int nPageNo )
      {
         AV105BR_ProcedureWWDS_1_Tfbr_procedureid = AV80TFBR_ProcedureID;
         AV106BR_ProcedureWWDS_2_Tfbr_procedureid_to = AV81TFBR_ProcedureID_To;
         AV107BR_ProcedureWWDS_3_Tfbr_encounterid = AV19TFBR_EncounterID;
         AV108BR_ProcedureWWDS_4_Tfbr_encounterid_to = AV20TFBR_EncounterID_To;
         AV109BR_ProcedureWWDS_5_Tfbr_information_patientno = AV23TFBR_Information_PatientNo;
         AV110BR_ProcedureWWDS_6_Tfbr_information_patientno_sel = AV24TFBR_Information_PatientNo_Sel;
         AV111BR_ProcedureWWDS_7_Tfbr_procedure_pxid = AV27TFBR_Procedure_PXID;
         AV112BR_ProcedureWWDS_8_Tfbr_procedure_pxid_to = AV28TFBR_Procedure_PXID_To;
         AV113BR_ProcedureWWDS_9_Tfbr_procedure_pxsurgery_sels = AV32TFBR_Procedure_PXSurgery_Sels;
         AV114BR_ProcedureWWDS_10_Tfbr_procedure_date = AV83TFBR_Procedure_Date;
         AV115BR_ProcedureWWDS_11_Tfbr_procedure_date_to = AV84TFBR_Procedure_Date_To;
         AV116BR_ProcedureWWDS_12_Tfbr_procedure_pxradiotherapy_sels = AV40TFBR_Procedure_PXRadiotherapy_Sels;
         AV117BR_ProcedureWWDS_13_Tfbr_procedure_radiodate = AV93TFBR_Procedure_RadioDate;
         AV118BR_ProcedureWWDS_14_Tfbr_procedure_radiodate_to = AV94TFBR_Procedure_RadioDate_To;
         AV119BR_ProcedureWWDS_15_Tfbr_procedure_radiotime = AV99TFBR_Procedure_RadioTime;
         AV120BR_ProcedureWWDS_16_Tfbr_procedure_radiotime_to = AV100TFBR_Procedure_RadioTime_To;
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
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV80TFBR_ProcedureID, AV81TFBR_ProcedureID_To, AV19TFBR_EncounterID, AV20TFBR_EncounterID_To, AV23TFBR_Information_PatientNo, AV24TFBR_Information_PatientNo_Sel, AV27TFBR_Procedure_PXID, AV28TFBR_Procedure_PXID_To, AV83TFBR_Procedure_Date, AV84TFBR_Procedure_Date_To, AV93TFBR_Procedure_RadioDate, AV94TFBR_Procedure_RadioDate_To, AV99TFBR_Procedure_RadioTime, AV100TFBR_Procedure_RadioTime_To, AV17ddo_BR_ProcedureIDTitleControlIdToReplace, AV21ddo_BR_EncounterIDTitleControlIdToReplace, AV25ddo_BR_Information_PatientNoTitleControlIdToReplace, AV29ddo_BR_Procedure_PXIDTitleControlIdToReplace, AV33ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace, AV87ddo_BR_Procedure_DateTitleControlIdToReplace, AV41ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace, AV97ddo_BR_Procedure_RadioDateTitleControlIdToReplace, AV101ddo_BR_Procedure_RadioTimeTitleControlIdToReplace, AV32TFBR_Procedure_PXSurgery_Sels, AV40TFBR_Procedure_PXRadiotherapy_Sels, AV124Pgmname, AV75IsAuthorized_Update, AV77IsAuthorized_Delete, AV78IsAuthorized_BR_Information_PatientNo) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP3O0( )
      {
         /* Before Start, stand alone formulas. */
         AV124Pgmname = "BR_ProcedureWW";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E233O2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( "vDDO_TITLESETTINGSICONS"), AV68DDO_TitleSettingsIcons);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_PROCEDUREIDTITLEFILTERDATA"), AV16BR_ProcedureIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_ENCOUNTERIDTITLEFILTERDATA"), AV18BR_EncounterIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_INFORMATION_PATIENTNOTITLEFILTERDATA"), AV22BR_Information_PatientNoTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_PROCEDURE_PXIDTITLEFILTERDATA"), AV26BR_Procedure_PXIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_PROCEDURE_PXSURGERYTITLEFILTERDATA"), AV30BR_Procedure_PXSurgeryTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_PROCEDURE_DATETITLEFILTERDATA"), AV82BR_Procedure_DateTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_PROCEDURE_PXRADIOTHERAPYTITLEFILTERDATA"), AV38BR_Procedure_PXRadiotherapyTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_PROCEDURE_RADIODATETITLEFILTERDATA"), AV92BR_Procedure_RadioDateTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_PROCEDURE_RADIOTIMETITLEFILTERDATA"), AV98BR_Procedure_RadioTimeTitleFilterData);
            /* Read variables values. */
            AV17ddo_BR_ProcedureIDTitleControlIdToReplace = cgiGet( edtavDdo_br_procedureidtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17ddo_BR_ProcedureIDTitleControlIdToReplace", AV17ddo_BR_ProcedureIDTitleControlIdToReplace);
            AV21ddo_BR_EncounterIDTitleControlIdToReplace = cgiGet( edtavDdo_br_encounteridtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21ddo_BR_EncounterIDTitleControlIdToReplace", AV21ddo_BR_EncounterIDTitleControlIdToReplace);
            AV25ddo_BR_Information_PatientNoTitleControlIdToReplace = cgiGet( edtavDdo_br_information_patientnotitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25ddo_BR_Information_PatientNoTitleControlIdToReplace", AV25ddo_BR_Information_PatientNoTitleControlIdToReplace);
            AV29ddo_BR_Procedure_PXIDTitleControlIdToReplace = cgiGet( edtavDdo_br_procedure_pxidtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29ddo_BR_Procedure_PXIDTitleControlIdToReplace", AV29ddo_BR_Procedure_PXIDTitleControlIdToReplace);
            AV33ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace = cgiGet( edtavDdo_br_procedure_pxsurgerytitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace", AV33ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace);
            AV87ddo_BR_Procedure_DateTitleControlIdToReplace = cgiGet( edtavDdo_br_procedure_datetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV87ddo_BR_Procedure_DateTitleControlIdToReplace", AV87ddo_BR_Procedure_DateTitleControlIdToReplace);
            AV41ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace = cgiGet( edtavDdo_br_procedure_pxradiotherapytitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV41ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace", AV41ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace);
            AV97ddo_BR_Procedure_RadioDateTitleControlIdToReplace = cgiGet( edtavDdo_br_procedure_radiodatetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV97ddo_BR_Procedure_RadioDateTitleControlIdToReplace", AV97ddo_BR_Procedure_RadioDateTitleControlIdToReplace);
            AV101ddo_BR_Procedure_RadioTimeTitleControlIdToReplace = cgiGet( edtavDdo_br_procedure_radiotimetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV101ddo_BR_Procedure_RadioTimeTitleControlIdToReplace", AV101ddo_BR_Procedure_RadioTimeTitleControlIdToReplace);
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
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_procedureid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_procedureid_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_PROCEDUREID");
               GX_FocusControl = edtavTfbr_procedureid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV80TFBR_ProcedureID = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV80TFBR_ProcedureID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV80TFBR_ProcedureID), 18, 0)));
            }
            else
            {
               AV80TFBR_ProcedureID = (long)(context.localUtil.CToN( cgiGet( edtavTfbr_procedureid_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV80TFBR_ProcedureID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV80TFBR_ProcedureID), 18, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_procedureid_to_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_procedureid_to_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_PROCEDUREID_TO");
               GX_FocusControl = edtavTfbr_procedureid_to_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV81TFBR_ProcedureID_To = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV81TFBR_ProcedureID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV81TFBR_ProcedureID_To), 18, 0)));
            }
            else
            {
               AV81TFBR_ProcedureID_To = (long)(context.localUtil.CToN( cgiGet( edtavTfbr_procedureid_to_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV81TFBR_ProcedureID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV81TFBR_ProcedureID_To), 18, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_encounterid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_encounterid_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_ENCOUNTERID");
               GX_FocusControl = edtavTfbr_encounterid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV19TFBR_EncounterID = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19TFBR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV19TFBR_EncounterID), 18, 0)));
            }
            else
            {
               AV19TFBR_EncounterID = (long)(context.localUtil.CToN( cgiGet( edtavTfbr_encounterid_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19TFBR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV19TFBR_EncounterID), 18, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_encounterid_to_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_encounterid_to_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_ENCOUNTERID_TO");
               GX_FocusControl = edtavTfbr_encounterid_to_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV20TFBR_EncounterID_To = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20TFBR_EncounterID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV20TFBR_EncounterID_To), 18, 0)));
            }
            else
            {
               AV20TFBR_EncounterID_To = (long)(context.localUtil.CToN( cgiGet( edtavTfbr_encounterid_to_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20TFBR_EncounterID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV20TFBR_EncounterID_To), 18, 0)));
            }
            AV23TFBR_Information_PatientNo = cgiGet( edtavTfbr_information_patientno_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23TFBR_Information_PatientNo", AV23TFBR_Information_PatientNo);
            AV24TFBR_Information_PatientNo_Sel = cgiGet( edtavTfbr_information_patientno_sel_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24TFBR_Information_PatientNo_Sel", AV24TFBR_Information_PatientNo_Sel);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_procedure_pxid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_procedure_pxid_Internalname), ".", ",") > Convert.ToDecimal( 9999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_PROCEDURE_PXID");
               GX_FocusControl = edtavTfbr_procedure_pxid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV27TFBR_Procedure_PXID = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27TFBR_Procedure_PXID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV27TFBR_Procedure_PXID), 10, 0)));
            }
            else
            {
               AV27TFBR_Procedure_PXID = (long)(context.localUtil.CToN( cgiGet( edtavTfbr_procedure_pxid_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27TFBR_Procedure_PXID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV27TFBR_Procedure_PXID), 10, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_procedure_pxid_to_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_procedure_pxid_to_Internalname), ".", ",") > Convert.ToDecimal( 9999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_PROCEDURE_PXID_TO");
               GX_FocusControl = edtavTfbr_procedure_pxid_to_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV28TFBR_Procedure_PXID_To = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV28TFBR_Procedure_PXID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV28TFBR_Procedure_PXID_To), 10, 0)));
            }
            else
            {
               AV28TFBR_Procedure_PXID_To = (long)(context.localUtil.CToN( cgiGet( edtavTfbr_procedure_pxid_to_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV28TFBR_Procedure_PXID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV28TFBR_Procedure_PXID_To), 10, 0)));
            }
            if ( context.localUtil.VCDate( cgiGet( edtavTfbr_procedure_date_Internalname), 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"TFBR_Procedure_Date"}), 1, "vTFBR_PROCEDURE_DATE");
               GX_FocusControl = edtavTfbr_procedure_date_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV83TFBR_Procedure_Date = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV83TFBR_Procedure_Date", context.localUtil.Format(AV83TFBR_Procedure_Date, "9999/99/99"));
            }
            else
            {
               AV83TFBR_Procedure_Date = context.localUtil.CToD( cgiGet( edtavTfbr_procedure_date_Internalname), 0);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV83TFBR_Procedure_Date", context.localUtil.Format(AV83TFBR_Procedure_Date, "9999/99/99"));
            }
            if ( context.localUtil.VCDate( cgiGet( edtavTfbr_procedure_date_to_Internalname), 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"TFBR_Procedure_Date_To"}), 1, "vTFBR_PROCEDURE_DATE_TO");
               GX_FocusControl = edtavTfbr_procedure_date_to_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV84TFBR_Procedure_Date_To = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV84TFBR_Procedure_Date_To", context.localUtil.Format(AV84TFBR_Procedure_Date_To, "9999/99/99"));
            }
            else
            {
               AV84TFBR_Procedure_Date_To = context.localUtil.CToD( cgiGet( edtavTfbr_procedure_date_to_Internalname), 0);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV84TFBR_Procedure_Date_To", context.localUtil.Format(AV84TFBR_Procedure_Date_To, "9999/99/99"));
            }
            if ( context.localUtil.VCDate( cgiGet( edtavDdo_br_procedure_dateauxdate_Internalname), 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"DDO_BR_Procedure_Date Aux Date"}), 1, "vDDO_BR_PROCEDURE_DATEAUXDATE");
               GX_FocusControl = edtavDdo_br_procedure_dateauxdate_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV85DDO_BR_Procedure_DateAuxDate = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV85DDO_BR_Procedure_DateAuxDate", context.localUtil.Format(AV85DDO_BR_Procedure_DateAuxDate, "9999/99/99"));
            }
            else
            {
               AV85DDO_BR_Procedure_DateAuxDate = context.localUtil.CToD( cgiGet( edtavDdo_br_procedure_dateauxdate_Internalname), 0);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV85DDO_BR_Procedure_DateAuxDate", context.localUtil.Format(AV85DDO_BR_Procedure_DateAuxDate, "9999/99/99"));
            }
            if ( context.localUtil.VCDate( cgiGet( edtavDdo_br_procedure_dateauxdateto_Internalname), 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"DDO_BR_Procedure_Date Aux Date To"}), 1, "vDDO_BR_PROCEDURE_DATEAUXDATETO");
               GX_FocusControl = edtavDdo_br_procedure_dateauxdateto_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV86DDO_BR_Procedure_DateAuxDateTo = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV86DDO_BR_Procedure_DateAuxDateTo", context.localUtil.Format(AV86DDO_BR_Procedure_DateAuxDateTo, "9999/99/99"));
            }
            else
            {
               AV86DDO_BR_Procedure_DateAuxDateTo = context.localUtil.CToD( cgiGet( edtavDdo_br_procedure_dateauxdateto_Internalname), 0);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV86DDO_BR_Procedure_DateAuxDateTo", context.localUtil.Format(AV86DDO_BR_Procedure_DateAuxDateTo, "9999/99/99"));
            }
            if ( context.localUtil.VCDate( cgiGet( edtavTfbr_procedure_radiodate_Internalname), 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"TFBR_Procedure_Radio Date"}), 1, "vTFBR_PROCEDURE_RADIODATE");
               GX_FocusControl = edtavTfbr_procedure_radiodate_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV93TFBR_Procedure_RadioDate = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV93TFBR_Procedure_RadioDate", context.localUtil.Format(AV93TFBR_Procedure_RadioDate, "9999/99/99"));
            }
            else
            {
               AV93TFBR_Procedure_RadioDate = context.localUtil.CToD( cgiGet( edtavTfbr_procedure_radiodate_Internalname), 0);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV93TFBR_Procedure_RadioDate", context.localUtil.Format(AV93TFBR_Procedure_RadioDate, "9999/99/99"));
            }
            if ( context.localUtil.VCDate( cgiGet( edtavTfbr_procedure_radiodate_to_Internalname), 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"TFBR_Procedure_Radio Date_To"}), 1, "vTFBR_PROCEDURE_RADIODATE_TO");
               GX_FocusControl = edtavTfbr_procedure_radiodate_to_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV94TFBR_Procedure_RadioDate_To = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV94TFBR_Procedure_RadioDate_To", context.localUtil.Format(AV94TFBR_Procedure_RadioDate_To, "9999/99/99"));
            }
            else
            {
               AV94TFBR_Procedure_RadioDate_To = context.localUtil.CToD( cgiGet( edtavTfbr_procedure_radiodate_to_Internalname), 0);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV94TFBR_Procedure_RadioDate_To", context.localUtil.Format(AV94TFBR_Procedure_RadioDate_To, "9999/99/99"));
            }
            if ( context.localUtil.VCDate( cgiGet( edtavDdo_br_procedure_radiodateauxdate_Internalname), 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"DDO_BR_Procedure_Radio Date Aux Date"}), 1, "vDDO_BR_PROCEDURE_RADIODATEAUXDATE");
               GX_FocusControl = edtavDdo_br_procedure_radiodateauxdate_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV95DDO_BR_Procedure_RadioDateAuxDate = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV95DDO_BR_Procedure_RadioDateAuxDate", context.localUtil.Format(AV95DDO_BR_Procedure_RadioDateAuxDate, "9999/99/99"));
            }
            else
            {
               AV95DDO_BR_Procedure_RadioDateAuxDate = context.localUtil.CToD( cgiGet( edtavDdo_br_procedure_radiodateauxdate_Internalname), 0);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV95DDO_BR_Procedure_RadioDateAuxDate", context.localUtil.Format(AV95DDO_BR_Procedure_RadioDateAuxDate, "9999/99/99"));
            }
            if ( context.localUtil.VCDate( cgiGet( edtavDdo_br_procedure_radiodateauxdateto_Internalname), 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"DDO_BR_Procedure_Radio Date Aux Date To"}), 1, "vDDO_BR_PROCEDURE_RADIODATEAUXDATETO");
               GX_FocusControl = edtavDdo_br_procedure_radiodateauxdateto_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV96DDO_BR_Procedure_RadioDateAuxDateTo = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV96DDO_BR_Procedure_RadioDateAuxDateTo", context.localUtil.Format(AV96DDO_BR_Procedure_RadioDateAuxDateTo, "9999/99/99"));
            }
            else
            {
               AV96DDO_BR_Procedure_RadioDateAuxDateTo = context.localUtil.CToD( cgiGet( edtavDdo_br_procedure_radiodateauxdateto_Internalname), 0);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV96DDO_BR_Procedure_RadioDateAuxDateTo", context.localUtil.Format(AV96DDO_BR_Procedure_RadioDateAuxDateTo, "9999/99/99"));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_procedure_radiotime_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_procedure_radiotime_Internalname), ".", ",") > 999999999.99999m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_PROCEDURE_RADIOTIME");
               GX_FocusControl = edtavTfbr_procedure_radiotime_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV99TFBR_Procedure_RadioTime = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV99TFBR_Procedure_RadioTime", StringUtil.LTrim( StringUtil.Str( AV99TFBR_Procedure_RadioTime, 15, 5)));
            }
            else
            {
               AV99TFBR_Procedure_RadioTime = context.localUtil.CToN( cgiGet( edtavTfbr_procedure_radiotime_Internalname), ".", ",");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV99TFBR_Procedure_RadioTime", StringUtil.LTrim( StringUtil.Str( AV99TFBR_Procedure_RadioTime, 15, 5)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_procedure_radiotime_to_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_procedure_radiotime_to_Internalname), ".", ",") > 999999999.99999m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_PROCEDURE_RADIOTIME_TO");
               GX_FocusControl = edtavTfbr_procedure_radiotime_to_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV100TFBR_Procedure_RadioTime_To = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV100TFBR_Procedure_RadioTime_To", StringUtil.LTrim( StringUtil.Str( AV100TFBR_Procedure_RadioTime_To, 15, 5)));
            }
            else
            {
               AV100TFBR_Procedure_RadioTime_To = context.localUtil.CToN( cgiGet( edtavTfbr_procedure_radiotime_to_Internalname), ".", ",");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV100TFBR_Procedure_RadioTime_To", StringUtil.LTrim( StringUtil.Str( AV100TFBR_Procedure_RadioTime_To, 15, 5)));
            }
            /* Read saved values. */
            nRC_GXsfl_28 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_28"), ".", ","));
            AV70GridCurrentPage = (long)(context.localUtil.CToN( cgiGet( "vGRIDCURRENTPAGE"), ".", ","));
            AV72GridRecordCount = (long)(context.localUtil.CToN( cgiGet( "vGRIDRECORDCOUNT"), ".", ","));
            AV71GridPageSize = (long)(context.localUtil.CToN( cgiGet( "vGRIDPAGESIZE"), ".", ","));
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
            Ddo_br_procedureid_Caption = cgiGet( "DDO_BR_PROCEDUREID_Caption");
            Ddo_br_procedureid_Tooltip = cgiGet( "DDO_BR_PROCEDUREID_Tooltip");
            Ddo_br_procedureid_Cls = cgiGet( "DDO_BR_PROCEDUREID_Cls");
            Ddo_br_procedureid_Filteredtext_set = cgiGet( "DDO_BR_PROCEDUREID_Filteredtext_set");
            Ddo_br_procedureid_Filteredtextto_set = cgiGet( "DDO_BR_PROCEDUREID_Filteredtextto_set");
            Ddo_br_procedureid_Dropdownoptionstype = cgiGet( "DDO_BR_PROCEDUREID_Dropdownoptionstype");
            Ddo_br_procedureid_Titlecontrolidtoreplace = cgiGet( "DDO_BR_PROCEDUREID_Titlecontrolidtoreplace");
            Ddo_br_procedureid_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDUREID_Includesortasc"));
            Ddo_br_procedureid_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDUREID_Includesortdsc"));
            Ddo_br_procedureid_Sortedstatus = cgiGet( "DDO_BR_PROCEDUREID_Sortedstatus");
            Ddo_br_procedureid_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDUREID_Includefilter"));
            Ddo_br_procedureid_Filtertype = cgiGet( "DDO_BR_PROCEDUREID_Filtertype");
            Ddo_br_procedureid_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDUREID_Filterisrange"));
            Ddo_br_procedureid_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDUREID_Includedatalist"));
            Ddo_br_procedureid_Sortasc = cgiGet( "DDO_BR_PROCEDUREID_Sortasc");
            Ddo_br_procedureid_Sortdsc = cgiGet( "DDO_BR_PROCEDUREID_Sortdsc");
            Ddo_br_procedureid_Cleanfilter = cgiGet( "DDO_BR_PROCEDUREID_Cleanfilter");
            Ddo_br_procedureid_Rangefilterfrom = cgiGet( "DDO_BR_PROCEDUREID_Rangefilterfrom");
            Ddo_br_procedureid_Rangefilterto = cgiGet( "DDO_BR_PROCEDUREID_Rangefilterto");
            Ddo_br_procedureid_Searchbuttontext = cgiGet( "DDO_BR_PROCEDUREID_Searchbuttontext");
            Ddo_br_encounterid_Caption = cgiGet( "DDO_BR_ENCOUNTERID_Caption");
            Ddo_br_encounterid_Tooltip = cgiGet( "DDO_BR_ENCOUNTERID_Tooltip");
            Ddo_br_encounterid_Cls = cgiGet( "DDO_BR_ENCOUNTERID_Cls");
            Ddo_br_encounterid_Filteredtext_set = cgiGet( "DDO_BR_ENCOUNTERID_Filteredtext_set");
            Ddo_br_encounterid_Filteredtextto_set = cgiGet( "DDO_BR_ENCOUNTERID_Filteredtextto_set");
            Ddo_br_encounterid_Dropdownoptionstype = cgiGet( "DDO_BR_ENCOUNTERID_Dropdownoptionstype");
            Ddo_br_encounterid_Titlecontrolidtoreplace = cgiGet( "DDO_BR_ENCOUNTERID_Titlecontrolidtoreplace");
            Ddo_br_encounterid_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTERID_Includesortasc"));
            Ddo_br_encounterid_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTERID_Includesortdsc"));
            Ddo_br_encounterid_Sortedstatus = cgiGet( "DDO_BR_ENCOUNTERID_Sortedstatus");
            Ddo_br_encounterid_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTERID_Includefilter"));
            Ddo_br_encounterid_Filtertype = cgiGet( "DDO_BR_ENCOUNTERID_Filtertype");
            Ddo_br_encounterid_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTERID_Filterisrange"));
            Ddo_br_encounterid_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTERID_Includedatalist"));
            Ddo_br_encounterid_Sortasc = cgiGet( "DDO_BR_ENCOUNTERID_Sortasc");
            Ddo_br_encounterid_Sortdsc = cgiGet( "DDO_BR_ENCOUNTERID_Sortdsc");
            Ddo_br_encounterid_Cleanfilter = cgiGet( "DDO_BR_ENCOUNTERID_Cleanfilter");
            Ddo_br_encounterid_Rangefilterfrom = cgiGet( "DDO_BR_ENCOUNTERID_Rangefilterfrom");
            Ddo_br_encounterid_Rangefilterto = cgiGet( "DDO_BR_ENCOUNTERID_Rangefilterto");
            Ddo_br_encounterid_Searchbuttontext = cgiGet( "DDO_BR_ENCOUNTERID_Searchbuttontext");
            Ddo_br_information_patientno_Caption = cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Caption");
            Ddo_br_information_patientno_Tooltip = cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Tooltip");
            Ddo_br_information_patientno_Cls = cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Cls");
            Ddo_br_information_patientno_Filteredtext_set = cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Filteredtext_set");
            Ddo_br_information_patientno_Selectedvalue_set = cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Selectedvalue_set");
            Ddo_br_information_patientno_Dropdownoptionstype = cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Dropdownoptionstype");
            Ddo_br_information_patientno_Titlecontrolidtoreplace = cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Titlecontrolidtoreplace");
            Ddo_br_information_patientno_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Includesortasc"));
            Ddo_br_information_patientno_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Includesortdsc"));
            Ddo_br_information_patientno_Sortedstatus = cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Sortedstatus");
            Ddo_br_information_patientno_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Includefilter"));
            Ddo_br_information_patientno_Filtertype = cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Filtertype");
            Ddo_br_information_patientno_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Filterisrange"));
            Ddo_br_information_patientno_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Includedatalist"));
            Ddo_br_information_patientno_Datalisttype = cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Datalisttype");
            Ddo_br_information_patientno_Datalistproc = cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Datalistproc");
            Ddo_br_information_patientno_Datalistupdateminimumcharacters = (int)(context.localUtil.CToN( cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Datalistupdateminimumcharacters"), ".", ","));
            Ddo_br_information_patientno_Sortasc = cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Sortasc");
            Ddo_br_information_patientno_Sortdsc = cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Sortdsc");
            Ddo_br_information_patientno_Loadingdata = cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Loadingdata");
            Ddo_br_information_patientno_Cleanfilter = cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Cleanfilter");
            Ddo_br_information_patientno_Noresultsfound = cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Noresultsfound");
            Ddo_br_information_patientno_Searchbuttontext = cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Searchbuttontext");
            Ddo_br_procedure_pxid_Caption = cgiGet( "DDO_BR_PROCEDURE_PXID_Caption");
            Ddo_br_procedure_pxid_Tooltip = cgiGet( "DDO_BR_PROCEDURE_PXID_Tooltip");
            Ddo_br_procedure_pxid_Cls = cgiGet( "DDO_BR_PROCEDURE_PXID_Cls");
            Ddo_br_procedure_pxid_Filteredtext_set = cgiGet( "DDO_BR_PROCEDURE_PXID_Filteredtext_set");
            Ddo_br_procedure_pxid_Filteredtextto_set = cgiGet( "DDO_BR_PROCEDURE_PXID_Filteredtextto_set");
            Ddo_br_procedure_pxid_Dropdownoptionstype = cgiGet( "DDO_BR_PROCEDURE_PXID_Dropdownoptionstype");
            Ddo_br_procedure_pxid_Titlecontrolidtoreplace = cgiGet( "DDO_BR_PROCEDURE_PXID_Titlecontrolidtoreplace");
            Ddo_br_procedure_pxid_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_PXID_Includesortasc"));
            Ddo_br_procedure_pxid_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_PXID_Includesortdsc"));
            Ddo_br_procedure_pxid_Sortedstatus = cgiGet( "DDO_BR_PROCEDURE_PXID_Sortedstatus");
            Ddo_br_procedure_pxid_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_PXID_Includefilter"));
            Ddo_br_procedure_pxid_Filtertype = cgiGet( "DDO_BR_PROCEDURE_PXID_Filtertype");
            Ddo_br_procedure_pxid_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_PXID_Filterisrange"));
            Ddo_br_procedure_pxid_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_PXID_Includedatalist"));
            Ddo_br_procedure_pxid_Sortasc = cgiGet( "DDO_BR_PROCEDURE_PXID_Sortasc");
            Ddo_br_procedure_pxid_Sortdsc = cgiGet( "DDO_BR_PROCEDURE_PXID_Sortdsc");
            Ddo_br_procedure_pxid_Cleanfilter = cgiGet( "DDO_BR_PROCEDURE_PXID_Cleanfilter");
            Ddo_br_procedure_pxid_Rangefilterfrom = cgiGet( "DDO_BR_PROCEDURE_PXID_Rangefilterfrom");
            Ddo_br_procedure_pxid_Rangefilterto = cgiGet( "DDO_BR_PROCEDURE_PXID_Rangefilterto");
            Ddo_br_procedure_pxid_Searchbuttontext = cgiGet( "DDO_BR_PROCEDURE_PXID_Searchbuttontext");
            Ddo_br_procedure_pxsurgery_Caption = cgiGet( "DDO_BR_PROCEDURE_PXSURGERY_Caption");
            Ddo_br_procedure_pxsurgery_Tooltip = cgiGet( "DDO_BR_PROCEDURE_PXSURGERY_Tooltip");
            Ddo_br_procedure_pxsurgery_Cls = cgiGet( "DDO_BR_PROCEDURE_PXSURGERY_Cls");
            Ddo_br_procedure_pxsurgery_Selectedvalue_set = cgiGet( "DDO_BR_PROCEDURE_PXSURGERY_Selectedvalue_set");
            Ddo_br_procedure_pxsurgery_Dropdownoptionstype = cgiGet( "DDO_BR_PROCEDURE_PXSURGERY_Dropdownoptionstype");
            Ddo_br_procedure_pxsurgery_Titlecontrolidtoreplace = cgiGet( "DDO_BR_PROCEDURE_PXSURGERY_Titlecontrolidtoreplace");
            Ddo_br_procedure_pxsurgery_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_PXSURGERY_Includesortasc"));
            Ddo_br_procedure_pxsurgery_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_PXSURGERY_Includesortdsc"));
            Ddo_br_procedure_pxsurgery_Sortedstatus = cgiGet( "DDO_BR_PROCEDURE_PXSURGERY_Sortedstatus");
            Ddo_br_procedure_pxsurgery_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_PXSURGERY_Includefilter"));
            Ddo_br_procedure_pxsurgery_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_PXSURGERY_Includedatalist"));
            Ddo_br_procedure_pxsurgery_Datalisttype = cgiGet( "DDO_BR_PROCEDURE_PXSURGERY_Datalisttype");
            Ddo_br_procedure_pxsurgery_Allowmultipleselection = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_PXSURGERY_Allowmultipleselection"));
            Ddo_br_procedure_pxsurgery_Datalistfixedvalues = cgiGet( "DDO_BR_PROCEDURE_PXSURGERY_Datalistfixedvalues");
            Ddo_br_procedure_pxsurgery_Sortasc = cgiGet( "DDO_BR_PROCEDURE_PXSURGERY_Sortasc");
            Ddo_br_procedure_pxsurgery_Sortdsc = cgiGet( "DDO_BR_PROCEDURE_PXSURGERY_Sortdsc");
            Ddo_br_procedure_pxsurgery_Cleanfilter = cgiGet( "DDO_BR_PROCEDURE_PXSURGERY_Cleanfilter");
            Ddo_br_procedure_pxsurgery_Searchbuttontext = cgiGet( "DDO_BR_PROCEDURE_PXSURGERY_Searchbuttontext");
            Ddo_br_procedure_date_Caption = cgiGet( "DDO_BR_PROCEDURE_DATE_Caption");
            Ddo_br_procedure_date_Tooltip = cgiGet( "DDO_BR_PROCEDURE_DATE_Tooltip");
            Ddo_br_procedure_date_Cls = cgiGet( "DDO_BR_PROCEDURE_DATE_Cls");
            Ddo_br_procedure_date_Filteredtext_set = cgiGet( "DDO_BR_PROCEDURE_DATE_Filteredtext_set");
            Ddo_br_procedure_date_Filteredtextto_set = cgiGet( "DDO_BR_PROCEDURE_DATE_Filteredtextto_set");
            Ddo_br_procedure_date_Dropdownoptionstype = cgiGet( "DDO_BR_PROCEDURE_DATE_Dropdownoptionstype");
            Ddo_br_procedure_date_Titlecontrolidtoreplace = cgiGet( "DDO_BR_PROCEDURE_DATE_Titlecontrolidtoreplace");
            Ddo_br_procedure_date_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_DATE_Includesortasc"));
            Ddo_br_procedure_date_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_DATE_Includesortdsc"));
            Ddo_br_procedure_date_Sortedstatus = cgiGet( "DDO_BR_PROCEDURE_DATE_Sortedstatus");
            Ddo_br_procedure_date_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_DATE_Includefilter"));
            Ddo_br_procedure_date_Filtertype = cgiGet( "DDO_BR_PROCEDURE_DATE_Filtertype");
            Ddo_br_procedure_date_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_DATE_Filterisrange"));
            Ddo_br_procedure_date_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_DATE_Includedatalist"));
            Ddo_br_procedure_date_Sortasc = cgiGet( "DDO_BR_PROCEDURE_DATE_Sortasc");
            Ddo_br_procedure_date_Sortdsc = cgiGet( "DDO_BR_PROCEDURE_DATE_Sortdsc");
            Ddo_br_procedure_date_Cleanfilter = cgiGet( "DDO_BR_PROCEDURE_DATE_Cleanfilter");
            Ddo_br_procedure_date_Rangefilterfrom = cgiGet( "DDO_BR_PROCEDURE_DATE_Rangefilterfrom");
            Ddo_br_procedure_date_Rangefilterto = cgiGet( "DDO_BR_PROCEDURE_DATE_Rangefilterto");
            Ddo_br_procedure_date_Searchbuttontext = cgiGet( "DDO_BR_PROCEDURE_DATE_Searchbuttontext");
            Ddo_br_procedure_pxradiotherapy_Caption = cgiGet( "DDO_BR_PROCEDURE_PXRADIOTHERAPY_Caption");
            Ddo_br_procedure_pxradiotherapy_Tooltip = cgiGet( "DDO_BR_PROCEDURE_PXRADIOTHERAPY_Tooltip");
            Ddo_br_procedure_pxradiotherapy_Cls = cgiGet( "DDO_BR_PROCEDURE_PXRADIOTHERAPY_Cls");
            Ddo_br_procedure_pxradiotherapy_Selectedvalue_set = cgiGet( "DDO_BR_PROCEDURE_PXRADIOTHERAPY_Selectedvalue_set");
            Ddo_br_procedure_pxradiotherapy_Dropdownoptionstype = cgiGet( "DDO_BR_PROCEDURE_PXRADIOTHERAPY_Dropdownoptionstype");
            Ddo_br_procedure_pxradiotherapy_Titlecontrolidtoreplace = cgiGet( "DDO_BR_PROCEDURE_PXRADIOTHERAPY_Titlecontrolidtoreplace");
            Ddo_br_procedure_pxradiotherapy_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_PXRADIOTHERAPY_Includesortasc"));
            Ddo_br_procedure_pxradiotherapy_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_PXRADIOTHERAPY_Includesortdsc"));
            Ddo_br_procedure_pxradiotherapy_Sortedstatus = cgiGet( "DDO_BR_PROCEDURE_PXRADIOTHERAPY_Sortedstatus");
            Ddo_br_procedure_pxradiotherapy_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_PXRADIOTHERAPY_Includefilter"));
            Ddo_br_procedure_pxradiotherapy_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_PXRADIOTHERAPY_Includedatalist"));
            Ddo_br_procedure_pxradiotherapy_Datalisttype = cgiGet( "DDO_BR_PROCEDURE_PXRADIOTHERAPY_Datalisttype");
            Ddo_br_procedure_pxradiotherapy_Allowmultipleselection = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_PXRADIOTHERAPY_Allowmultipleselection"));
            Ddo_br_procedure_pxradiotherapy_Datalistfixedvalues = cgiGet( "DDO_BR_PROCEDURE_PXRADIOTHERAPY_Datalistfixedvalues");
            Ddo_br_procedure_pxradiotherapy_Sortasc = cgiGet( "DDO_BR_PROCEDURE_PXRADIOTHERAPY_Sortasc");
            Ddo_br_procedure_pxradiotherapy_Sortdsc = cgiGet( "DDO_BR_PROCEDURE_PXRADIOTHERAPY_Sortdsc");
            Ddo_br_procedure_pxradiotherapy_Cleanfilter = cgiGet( "DDO_BR_PROCEDURE_PXRADIOTHERAPY_Cleanfilter");
            Ddo_br_procedure_pxradiotherapy_Searchbuttontext = cgiGet( "DDO_BR_PROCEDURE_PXRADIOTHERAPY_Searchbuttontext");
            Ddo_br_procedure_radiodate_Caption = cgiGet( "DDO_BR_PROCEDURE_RADIODATE_Caption");
            Ddo_br_procedure_radiodate_Tooltip = cgiGet( "DDO_BR_PROCEDURE_RADIODATE_Tooltip");
            Ddo_br_procedure_radiodate_Cls = cgiGet( "DDO_BR_PROCEDURE_RADIODATE_Cls");
            Ddo_br_procedure_radiodate_Filteredtext_set = cgiGet( "DDO_BR_PROCEDURE_RADIODATE_Filteredtext_set");
            Ddo_br_procedure_radiodate_Filteredtextto_set = cgiGet( "DDO_BR_PROCEDURE_RADIODATE_Filteredtextto_set");
            Ddo_br_procedure_radiodate_Dropdownoptionstype = cgiGet( "DDO_BR_PROCEDURE_RADIODATE_Dropdownoptionstype");
            Ddo_br_procedure_radiodate_Titlecontrolidtoreplace = cgiGet( "DDO_BR_PROCEDURE_RADIODATE_Titlecontrolidtoreplace");
            Ddo_br_procedure_radiodate_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_RADIODATE_Includesortasc"));
            Ddo_br_procedure_radiodate_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_RADIODATE_Includesortdsc"));
            Ddo_br_procedure_radiodate_Sortedstatus = cgiGet( "DDO_BR_PROCEDURE_RADIODATE_Sortedstatus");
            Ddo_br_procedure_radiodate_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_RADIODATE_Includefilter"));
            Ddo_br_procedure_radiodate_Filtertype = cgiGet( "DDO_BR_PROCEDURE_RADIODATE_Filtertype");
            Ddo_br_procedure_radiodate_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_RADIODATE_Filterisrange"));
            Ddo_br_procedure_radiodate_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_RADIODATE_Includedatalist"));
            Ddo_br_procedure_radiodate_Sortasc = cgiGet( "DDO_BR_PROCEDURE_RADIODATE_Sortasc");
            Ddo_br_procedure_radiodate_Sortdsc = cgiGet( "DDO_BR_PROCEDURE_RADIODATE_Sortdsc");
            Ddo_br_procedure_radiodate_Cleanfilter = cgiGet( "DDO_BR_PROCEDURE_RADIODATE_Cleanfilter");
            Ddo_br_procedure_radiodate_Rangefilterfrom = cgiGet( "DDO_BR_PROCEDURE_RADIODATE_Rangefilterfrom");
            Ddo_br_procedure_radiodate_Rangefilterto = cgiGet( "DDO_BR_PROCEDURE_RADIODATE_Rangefilterto");
            Ddo_br_procedure_radiodate_Searchbuttontext = cgiGet( "DDO_BR_PROCEDURE_RADIODATE_Searchbuttontext");
            Ddo_br_procedure_radiotime_Caption = cgiGet( "DDO_BR_PROCEDURE_RADIOTIME_Caption");
            Ddo_br_procedure_radiotime_Tooltip = cgiGet( "DDO_BR_PROCEDURE_RADIOTIME_Tooltip");
            Ddo_br_procedure_radiotime_Cls = cgiGet( "DDO_BR_PROCEDURE_RADIOTIME_Cls");
            Ddo_br_procedure_radiotime_Filteredtext_set = cgiGet( "DDO_BR_PROCEDURE_RADIOTIME_Filteredtext_set");
            Ddo_br_procedure_radiotime_Filteredtextto_set = cgiGet( "DDO_BR_PROCEDURE_RADIOTIME_Filteredtextto_set");
            Ddo_br_procedure_radiotime_Dropdownoptionstype = cgiGet( "DDO_BR_PROCEDURE_RADIOTIME_Dropdownoptionstype");
            Ddo_br_procedure_radiotime_Titlecontrolidtoreplace = cgiGet( "DDO_BR_PROCEDURE_RADIOTIME_Titlecontrolidtoreplace");
            Ddo_br_procedure_radiotime_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_RADIOTIME_Includesortasc"));
            Ddo_br_procedure_radiotime_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_RADIOTIME_Includesortdsc"));
            Ddo_br_procedure_radiotime_Sortedstatus = cgiGet( "DDO_BR_PROCEDURE_RADIOTIME_Sortedstatus");
            Ddo_br_procedure_radiotime_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_RADIOTIME_Includefilter"));
            Ddo_br_procedure_radiotime_Filtertype = cgiGet( "DDO_BR_PROCEDURE_RADIOTIME_Filtertype");
            Ddo_br_procedure_radiotime_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_RADIOTIME_Filterisrange"));
            Ddo_br_procedure_radiotime_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_RADIOTIME_Includedatalist"));
            Ddo_br_procedure_radiotime_Sortasc = cgiGet( "DDO_BR_PROCEDURE_RADIOTIME_Sortasc");
            Ddo_br_procedure_radiotime_Sortdsc = cgiGet( "DDO_BR_PROCEDURE_RADIOTIME_Sortdsc");
            Ddo_br_procedure_radiotime_Cleanfilter = cgiGet( "DDO_BR_PROCEDURE_RADIOTIME_Cleanfilter");
            Ddo_br_procedure_radiotime_Rangefilterfrom = cgiGet( "DDO_BR_PROCEDURE_RADIOTIME_Rangefilterfrom");
            Ddo_br_procedure_radiotime_Rangefilterto = cgiGet( "DDO_BR_PROCEDURE_RADIOTIME_Rangefilterto");
            Ddo_br_procedure_radiotime_Searchbuttontext = cgiGet( "DDO_BR_PROCEDURE_RADIOTIME_Searchbuttontext");
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( "GRID_Rows"), ".", ","));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            Gridpaginationbar_Selectedpage = cgiGet( "GRIDPAGINATIONBAR_Selectedpage");
            Gridpaginationbar_Rowsperpageselectedvalue = (int)(context.localUtil.CToN( cgiGet( "GRIDPAGINATIONBAR_Rowsperpageselectedvalue"), ".", ","));
            Ddo_br_procedureid_Activeeventkey = cgiGet( "DDO_BR_PROCEDUREID_Activeeventkey");
            Ddo_br_procedureid_Filteredtext_get = cgiGet( "DDO_BR_PROCEDUREID_Filteredtext_get");
            Ddo_br_procedureid_Filteredtextto_get = cgiGet( "DDO_BR_PROCEDUREID_Filteredtextto_get");
            Ddo_br_encounterid_Activeeventkey = cgiGet( "DDO_BR_ENCOUNTERID_Activeeventkey");
            Ddo_br_encounterid_Filteredtext_get = cgiGet( "DDO_BR_ENCOUNTERID_Filteredtext_get");
            Ddo_br_encounterid_Filteredtextto_get = cgiGet( "DDO_BR_ENCOUNTERID_Filteredtextto_get");
            Ddo_br_information_patientno_Activeeventkey = cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Activeeventkey");
            Ddo_br_information_patientno_Filteredtext_get = cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Filteredtext_get");
            Ddo_br_information_patientno_Selectedvalue_get = cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Selectedvalue_get");
            Ddo_br_procedure_pxid_Activeeventkey = cgiGet( "DDO_BR_PROCEDURE_PXID_Activeeventkey");
            Ddo_br_procedure_pxid_Filteredtext_get = cgiGet( "DDO_BR_PROCEDURE_PXID_Filteredtext_get");
            Ddo_br_procedure_pxid_Filteredtextto_get = cgiGet( "DDO_BR_PROCEDURE_PXID_Filteredtextto_get");
            Ddo_br_procedure_pxsurgery_Activeeventkey = cgiGet( "DDO_BR_PROCEDURE_PXSURGERY_Activeeventkey");
            Ddo_br_procedure_pxsurgery_Selectedvalue_get = cgiGet( "DDO_BR_PROCEDURE_PXSURGERY_Selectedvalue_get");
            Ddo_br_procedure_date_Activeeventkey = cgiGet( "DDO_BR_PROCEDURE_DATE_Activeeventkey");
            Ddo_br_procedure_date_Filteredtext_get = cgiGet( "DDO_BR_PROCEDURE_DATE_Filteredtext_get");
            Ddo_br_procedure_date_Filteredtextto_get = cgiGet( "DDO_BR_PROCEDURE_DATE_Filteredtextto_get");
            Ddo_br_procedure_pxradiotherapy_Activeeventkey = cgiGet( "DDO_BR_PROCEDURE_PXRADIOTHERAPY_Activeeventkey");
            Ddo_br_procedure_pxradiotherapy_Selectedvalue_get = cgiGet( "DDO_BR_PROCEDURE_PXRADIOTHERAPY_Selectedvalue_get");
            Ddo_br_procedure_radiodate_Activeeventkey = cgiGet( "DDO_BR_PROCEDURE_RADIODATE_Activeeventkey");
            Ddo_br_procedure_radiodate_Filteredtext_get = cgiGet( "DDO_BR_PROCEDURE_RADIODATE_Filteredtext_get");
            Ddo_br_procedure_radiodate_Filteredtextto_get = cgiGet( "DDO_BR_PROCEDURE_RADIODATE_Filteredtextto_get");
            Ddo_br_procedure_radiotime_Activeeventkey = cgiGet( "DDO_BR_PROCEDURE_RADIOTIME_Activeeventkey");
            Ddo_br_procedure_radiotime_Filteredtext_get = cgiGet( "DDO_BR_PROCEDURE_RADIOTIME_Filteredtext_get");
            Ddo_br_procedure_radiotime_Filteredtextto_get = cgiGet( "DDO_BR_PROCEDURE_RADIOTIME_Filteredtextto_get");
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vORDEREDBY"), ".", ",") != Convert.ToDecimal( AV13OrderedBy )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrToBool( cgiGet( "GXH_vORDEREDDSC")) != AV14OrderedDsc )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_PROCEDUREID"), ".", ",") != Convert.ToDecimal( AV80TFBR_ProcedureID )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_PROCEDUREID_TO"), ".", ",") != Convert.ToDecimal( AV81TFBR_ProcedureID_To )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_ENCOUNTERID"), ".", ",") != Convert.ToDecimal( AV19TFBR_EncounterID )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_ENCOUNTERID_TO"), ".", ",") != Convert.ToDecimal( AV20TFBR_EncounterID_To )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_INFORMATION_PATIENTNO"), AV23TFBR_Information_PatientNo) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_INFORMATION_PATIENTNO_SEL"), AV24TFBR_Information_PatientNo_Sel) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_PROCEDURE_PXID"), ".", ",") != Convert.ToDecimal( AV27TFBR_Procedure_PXID )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_PROCEDURE_PXID_TO"), ".", ",") != Convert.ToDecimal( AV28TFBR_Procedure_PXID_To )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToD( cgiGet( "GXH_vTFBR_PROCEDURE_DATE"), 0) != AV83TFBR_Procedure_Date )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToD( cgiGet( "GXH_vTFBR_PROCEDURE_DATE_TO"), 0) != AV84TFBR_Procedure_Date_To )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToD( cgiGet( "GXH_vTFBR_PROCEDURE_RADIODATE"), 0) != AV93TFBR_Procedure_RadioDate )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToD( cgiGet( "GXH_vTFBR_PROCEDURE_RADIODATE_TO"), 0) != AV94TFBR_Procedure_RadioDate_To )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_PROCEDURE_RADIOTIME"), ".", ",") != AV99TFBR_Procedure_RadioTime )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_PROCEDURE_RADIOTIME_TO"), ".", ",") != AV100TFBR_Procedure_RadioTime_To )
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
         E233O2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E233O2( )
      {
         /* Start Routine */
         subGrid_Rows = 9;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GXt_boolean1 = AV78IsAuthorized_BR_Information_PatientNo;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Check_Information", out  GXt_boolean1) ;
         AV78IsAuthorized_BR_Information_PatientNo = GXt_boolean1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV78IsAuthorized_BR_Information_PatientNo", AV78IsAuthorized_BR_Information_PatientNo);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vISAUTHORIZED_BR_INFORMATION_PATIENTNO", GetSecureSignedToken( "", AV78IsAuthorized_BR_Information_PatientNo, context));
         edtavTfbr_procedureid_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_procedureid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_procedureid_Visible), 5, 0)), true);
         edtavTfbr_procedureid_to_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_procedureid_to_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_procedureid_to_Visible), 5, 0)), true);
         edtavTfbr_encounterid_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_encounterid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_encounterid_Visible), 5, 0)), true);
         edtavTfbr_encounterid_to_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_encounterid_to_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_encounterid_to_Visible), 5, 0)), true);
         edtavTfbr_information_patientno_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_information_patientno_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_information_patientno_Visible), 5, 0)), true);
         edtavTfbr_information_patientno_sel_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_information_patientno_sel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_information_patientno_sel_Visible), 5, 0)), true);
         edtavTfbr_procedure_pxid_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_procedure_pxid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_procedure_pxid_Visible), 5, 0)), true);
         edtavTfbr_procedure_pxid_to_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_procedure_pxid_to_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_procedure_pxid_to_Visible), 5, 0)), true);
         edtavTfbr_procedure_date_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_procedure_date_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_procedure_date_Visible), 5, 0)), true);
         edtavTfbr_procedure_date_to_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_procedure_date_to_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_procedure_date_to_Visible), 5, 0)), true);
         edtavTfbr_procedure_radiodate_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_procedure_radiodate_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_procedure_radiodate_Visible), 5, 0)), true);
         edtavTfbr_procedure_radiodate_to_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_procedure_radiodate_to_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_procedure_radiodate_to_Visible), 5, 0)), true);
         edtavTfbr_procedure_radiotime_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_procedure_radiotime_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_procedure_radiotime_Visible), 5, 0)), true);
         edtavTfbr_procedure_radiotime_to_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_procedure_radiotime_to_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_procedure_radiotime_to_Visible), 5, 0)), true);
         Ddo_br_procedureid_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_ProcedureID";
         ucDdo_br_procedureid.SendProperty(context, "", false, Ddo_br_procedureid_Internalname, "TitleControlIdToReplace", Ddo_br_procedureid_Titlecontrolidtoreplace);
         AV17ddo_BR_ProcedureIDTitleControlIdToReplace = Ddo_br_procedureid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17ddo_BR_ProcedureIDTitleControlIdToReplace", AV17ddo_BR_ProcedureIDTitleControlIdToReplace);
         edtavDdo_br_procedureidtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_procedureidtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_procedureidtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_encounterid_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_EncounterID";
         ucDdo_br_encounterid.SendProperty(context, "", false, Ddo_br_encounterid_Internalname, "TitleControlIdToReplace", Ddo_br_encounterid_Titlecontrolidtoreplace);
         AV21ddo_BR_EncounterIDTitleControlIdToReplace = Ddo_br_encounterid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21ddo_BR_EncounterIDTitleControlIdToReplace", AV21ddo_BR_EncounterIDTitleControlIdToReplace);
         edtavDdo_br_encounteridtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_encounteridtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_encounteridtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_information_patientno_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Information_PatientNo";
         ucDdo_br_information_patientno.SendProperty(context, "", false, Ddo_br_information_patientno_Internalname, "TitleControlIdToReplace", Ddo_br_information_patientno_Titlecontrolidtoreplace);
         AV25ddo_BR_Information_PatientNoTitleControlIdToReplace = Ddo_br_information_patientno_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25ddo_BR_Information_PatientNoTitleControlIdToReplace", AV25ddo_BR_Information_PatientNoTitleControlIdToReplace);
         edtavDdo_br_information_patientnotitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_information_patientnotitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_information_patientnotitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_procedure_pxid_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Procedure_PXID";
         ucDdo_br_procedure_pxid.SendProperty(context, "", false, Ddo_br_procedure_pxid_Internalname, "TitleControlIdToReplace", Ddo_br_procedure_pxid_Titlecontrolidtoreplace);
         AV29ddo_BR_Procedure_PXIDTitleControlIdToReplace = Ddo_br_procedure_pxid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29ddo_BR_Procedure_PXIDTitleControlIdToReplace", AV29ddo_BR_Procedure_PXIDTitleControlIdToReplace);
         edtavDdo_br_procedure_pxidtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_procedure_pxidtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_procedure_pxidtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_procedure_pxsurgery_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Procedure_PXSurgery";
         ucDdo_br_procedure_pxsurgery.SendProperty(context, "", false, Ddo_br_procedure_pxsurgery_Internalname, "TitleControlIdToReplace", Ddo_br_procedure_pxsurgery_Titlecontrolidtoreplace);
         AV33ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace = Ddo_br_procedure_pxsurgery_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace", AV33ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace);
         edtavDdo_br_procedure_pxsurgerytitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_procedure_pxsurgerytitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_procedure_pxsurgerytitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_procedure_date_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Procedure_Date";
         ucDdo_br_procedure_date.SendProperty(context, "", false, Ddo_br_procedure_date_Internalname, "TitleControlIdToReplace", Ddo_br_procedure_date_Titlecontrolidtoreplace);
         AV87ddo_BR_Procedure_DateTitleControlIdToReplace = Ddo_br_procedure_date_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV87ddo_BR_Procedure_DateTitleControlIdToReplace", AV87ddo_BR_Procedure_DateTitleControlIdToReplace);
         edtavDdo_br_procedure_datetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_procedure_datetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_procedure_datetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_procedure_pxradiotherapy_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Procedure_PXRadiotherapy";
         ucDdo_br_procedure_pxradiotherapy.SendProperty(context, "", false, Ddo_br_procedure_pxradiotherapy_Internalname, "TitleControlIdToReplace", Ddo_br_procedure_pxradiotherapy_Titlecontrolidtoreplace);
         AV41ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace = Ddo_br_procedure_pxradiotherapy_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV41ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace", AV41ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace);
         edtavDdo_br_procedure_pxradiotherapytitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_procedure_pxradiotherapytitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_procedure_pxradiotherapytitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_procedure_radiodate_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Procedure_RadioDate";
         ucDdo_br_procedure_radiodate.SendProperty(context, "", false, Ddo_br_procedure_radiodate_Internalname, "TitleControlIdToReplace", Ddo_br_procedure_radiodate_Titlecontrolidtoreplace);
         AV97ddo_BR_Procedure_RadioDateTitleControlIdToReplace = Ddo_br_procedure_radiodate_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV97ddo_BR_Procedure_RadioDateTitleControlIdToReplace", AV97ddo_BR_Procedure_RadioDateTitleControlIdToReplace);
         edtavDdo_br_procedure_radiodatetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_procedure_radiodatetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_procedure_radiodatetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_procedure_radiotime_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Procedure_RadioTime";
         ucDdo_br_procedure_radiotime.SendProperty(context, "", false, Ddo_br_procedure_radiotime_Internalname, "TitleControlIdToReplace", Ddo_br_procedure_radiotime_Titlecontrolidtoreplace);
         AV101ddo_BR_Procedure_RadioTimeTitleControlIdToReplace = Ddo_br_procedure_radiotime_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV101ddo_BR_Procedure_RadioTimeTitleControlIdToReplace", AV101ddo_BR_Procedure_RadioTimeTitleControlIdToReplace);
         edtavDdo_br_procedure_radiotimetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_procedure_radiotimetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_procedure_radiotimetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Form.Caption = " 诊疗处理";
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
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 = AV68DDO_TitleSettingsIcons;
         new GeneXus.Programs.wwpbaseobjects.getwwptitlesettingsicons(context ).execute( out  GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2) ;
         AV68DDO_TitleSettingsIcons = GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2;
         Gridpaginationbar_Rowsperpageselectedvalue = subGrid_Rows;
         ucGridpaginationbar.SendProperty(context, "", false, Gridpaginationbar_Internalname, "RowsPerPageSelectedValue", StringUtil.LTrim( StringUtil.Str( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0)));
      }

      protected void E243O2( )
      {
         if ( gx_refresh_fired )
         {
            return  ;
         }
         gx_refresh_fired = true;
         /* Refresh Routine */
         AV16BR_ProcedureIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV18BR_EncounterIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV22BR_Information_PatientNoTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV26BR_Procedure_PXIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV30BR_Procedure_PXSurgeryTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV82BR_Procedure_DateTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV38BR_Procedure_PXRadiotherapyTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV92BR_Procedure_RadioDateTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV98BR_Procedure_RadioTimeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
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
         edtBR_ProcedureID_Titleformat = 2;
         edtBR_ProcedureID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "诊疗处理主键", AV17ddo_BR_ProcedureIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_ProcedureID_Internalname, "Title", edtBR_ProcedureID_Title, !bGXsfl_28_Refreshing);
         edtBR_EncounterID_Titleformat = 2;
         edtBR_EncounterID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "就诊信息主键", AV21ddo_BR_EncounterIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_EncounterID_Internalname, "Title", edtBR_EncounterID_Title, !bGXsfl_28_Refreshing);
         edtBR_Information_PatientNo_Titleformat = 2;
         edtBR_Information_PatientNo_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "患者编号", AV25ddo_BR_Information_PatientNoTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Information_PatientNo_Internalname, "Title", edtBR_Information_PatientNo_Title, !bGXsfl_28_Refreshing);
         edtBR_Procedure_PXID_Titleformat = 2;
         edtBR_Procedure_PXID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "诊疗序号", AV29ddo_BR_Procedure_PXIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Procedure_PXID_Internalname, "Title", edtBR_Procedure_PXID_Title, !bGXsfl_28_Refreshing);
         cmbBR_Procedure_PXSurgery_Titleformat = 2;
         cmbBR_Procedure_PXSurgery.Title.Text = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "是否手术", AV33ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Procedure_PXSurgery_Internalname, "Title", cmbBR_Procedure_PXSurgery.Title.Text, !bGXsfl_28_Refreshing);
         edtBR_Procedure_Date_Titleformat = 2;
         edtBR_Procedure_Date_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "手术日期", AV87ddo_BR_Procedure_DateTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Procedure_Date_Internalname, "Title", edtBR_Procedure_Date_Title, !bGXsfl_28_Refreshing);
         cmbBR_Procedure_PXRadiotherapy_Titleformat = 2;
         cmbBR_Procedure_PXRadiotherapy.Title.Text = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "是否接受放射疗法", AV41ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Procedure_PXRadiotherapy_Internalname, "Title", cmbBR_Procedure_PXRadiotherapy.Title.Text, !bGXsfl_28_Refreshing);
         edtBR_Procedure_RadioDate_Titleformat = 2;
         edtBR_Procedure_RadioDate_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "放疗日期", AV97ddo_BR_Procedure_RadioDateTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Procedure_RadioDate_Internalname, "Title", edtBR_Procedure_RadioDate_Title, !bGXsfl_28_Refreshing);
         edtBR_Procedure_RadioTime_Titleformat = 2;
         edtBR_Procedure_RadioTime_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "放疗疗程", AV101ddo_BR_Procedure_RadioTimeTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Procedure_RadioTime_Internalname, "Title", edtBR_Procedure_RadioTime_Title, !bGXsfl_28_Refreshing);
         AV70GridCurrentPage = subGrid_Currentpage( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV70GridCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV70GridCurrentPage), 10, 0)));
         AV71GridPageSize = subGrid_Rows;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV71GridPageSize", StringUtil.LTrim( StringUtil.Str( (decimal)(AV71GridPageSize), 10, 0)));
         AV72GridRecordCount = subGrid_Recordcount( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV72GridRecordCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV72GridRecordCount), 10, 0)));
         AV105BR_ProcedureWWDS_1_Tfbr_procedureid = AV80TFBR_ProcedureID;
         AV106BR_ProcedureWWDS_2_Tfbr_procedureid_to = AV81TFBR_ProcedureID_To;
         AV107BR_ProcedureWWDS_3_Tfbr_encounterid = AV19TFBR_EncounterID;
         AV108BR_ProcedureWWDS_4_Tfbr_encounterid_to = AV20TFBR_EncounterID_To;
         AV109BR_ProcedureWWDS_5_Tfbr_information_patientno = AV23TFBR_Information_PatientNo;
         AV110BR_ProcedureWWDS_6_Tfbr_information_patientno_sel = AV24TFBR_Information_PatientNo_Sel;
         AV111BR_ProcedureWWDS_7_Tfbr_procedure_pxid = AV27TFBR_Procedure_PXID;
         AV112BR_ProcedureWWDS_8_Tfbr_procedure_pxid_to = AV28TFBR_Procedure_PXID_To;
         AV113BR_ProcedureWWDS_9_Tfbr_procedure_pxsurgery_sels = AV32TFBR_Procedure_PXSurgery_Sels;
         AV114BR_ProcedureWWDS_10_Tfbr_procedure_date = AV83TFBR_Procedure_Date;
         AV115BR_ProcedureWWDS_11_Tfbr_procedure_date_to = AV84TFBR_Procedure_Date_To;
         AV116BR_ProcedureWWDS_12_Tfbr_procedure_pxradiotherapy_sels = AV40TFBR_Procedure_PXRadiotherapy_Sels;
         AV117BR_ProcedureWWDS_13_Tfbr_procedure_radiodate = AV93TFBR_Procedure_RadioDate;
         AV118BR_ProcedureWWDS_14_Tfbr_procedure_radiodate_to = AV94TFBR_Procedure_RadioDate_To;
         AV119BR_ProcedureWWDS_15_Tfbr_procedure_radiotime = AV99TFBR_Procedure_RadioTime;
         AV120BR_ProcedureWWDS_16_Tfbr_procedure_radiotime_to = AV100TFBR_Procedure_RadioTime_To;
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_ProcedureIDTitleFilterData", AV16BR_ProcedureIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18BR_EncounterIDTitleFilterData", AV18BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22BR_Information_PatientNoTitleFilterData", AV22BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV26BR_Procedure_PXIDTitleFilterData", AV26BR_Procedure_PXIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30BR_Procedure_PXSurgeryTitleFilterData", AV30BR_Procedure_PXSurgeryTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV82BR_Procedure_DateTitleFilterData", AV82BR_Procedure_DateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_Procedure_PXRadiotherapyTitleFilterData", AV38BR_Procedure_PXRadiotherapyTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV92BR_Procedure_RadioDateTitleFilterData", AV92BR_Procedure_RadioDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV98BR_Procedure_RadioTimeTitleFilterData", AV98BR_Procedure_RadioTimeTitleFilterData);
      }

      protected void E113O2( )
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
            AV69PageToGo = (int)(NumberUtil.Val( Gridpaginationbar_Selectedpage, "."));
            subgrid_gotopage( AV69PageToGo) ;
         }
      }

      protected void E123O2( )
      {
         /* Gridpaginationbar_Changerowsperpage Routine */
         subGrid_Rows = Gridpaginationbar_Rowsperpageselectedvalue;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         subgrid_firstpage( ) ;
         /*  Sending Event outputs  */
      }

      protected void E133O2( )
      {
         /* Ddo_br_procedureid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_procedureid_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_br_procedureid_Sortedstatus = "ASC";
            ucDdo_br_procedureid.SendProperty(context, "", false, Ddo_br_procedureid_Internalname, "SortedStatus", Ddo_br_procedureid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_procedureid_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_br_procedureid_Sortedstatus = "DSC";
            ucDdo_br_procedureid.SendProperty(context, "", false, Ddo_br_procedureid_Internalname, "SortedStatus", Ddo_br_procedureid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_procedureid_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV80TFBR_ProcedureID = (long)(NumberUtil.Val( Ddo_br_procedureid_Filteredtext_get, "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV80TFBR_ProcedureID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV80TFBR_ProcedureID), 18, 0)));
            AV81TFBR_ProcedureID_To = (long)(NumberUtil.Val( Ddo_br_procedureid_Filteredtextto_get, "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV81TFBR_ProcedureID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV81TFBR_ProcedureID_To), 18, 0)));
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_ProcedureIDTitleFilterData", AV16BR_ProcedureIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18BR_EncounterIDTitleFilterData", AV18BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22BR_Information_PatientNoTitleFilterData", AV22BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV26BR_Procedure_PXIDTitleFilterData", AV26BR_Procedure_PXIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30BR_Procedure_PXSurgeryTitleFilterData", AV30BR_Procedure_PXSurgeryTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV82BR_Procedure_DateTitleFilterData", AV82BR_Procedure_DateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_Procedure_PXRadiotherapyTitleFilterData", AV38BR_Procedure_PXRadiotherapyTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV92BR_Procedure_RadioDateTitleFilterData", AV92BR_Procedure_RadioDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV98BR_Procedure_RadioTimeTitleFilterData", AV98BR_Procedure_RadioTimeTitleFilterData);
      }

      protected void E143O2( )
      {
         /* Ddo_br_encounterid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_encounterid_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_br_encounterid_Sortedstatus = "ASC";
            ucDdo_br_encounterid.SendProperty(context, "", false, Ddo_br_encounterid_Internalname, "SortedStatus", Ddo_br_encounterid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_encounterid_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_br_encounterid_Sortedstatus = "DSC";
            ucDdo_br_encounterid.SendProperty(context, "", false, Ddo_br_encounterid_Internalname, "SortedStatus", Ddo_br_encounterid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_encounterid_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV19TFBR_EncounterID = (long)(NumberUtil.Val( Ddo_br_encounterid_Filteredtext_get, "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19TFBR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV19TFBR_EncounterID), 18, 0)));
            AV20TFBR_EncounterID_To = (long)(NumberUtil.Val( Ddo_br_encounterid_Filteredtextto_get, "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20TFBR_EncounterID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV20TFBR_EncounterID_To), 18, 0)));
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_ProcedureIDTitleFilterData", AV16BR_ProcedureIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18BR_EncounterIDTitleFilterData", AV18BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22BR_Information_PatientNoTitleFilterData", AV22BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV26BR_Procedure_PXIDTitleFilterData", AV26BR_Procedure_PXIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30BR_Procedure_PXSurgeryTitleFilterData", AV30BR_Procedure_PXSurgeryTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV82BR_Procedure_DateTitleFilterData", AV82BR_Procedure_DateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_Procedure_PXRadiotherapyTitleFilterData", AV38BR_Procedure_PXRadiotherapyTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV92BR_Procedure_RadioDateTitleFilterData", AV92BR_Procedure_RadioDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV98BR_Procedure_RadioTimeTitleFilterData", AV98BR_Procedure_RadioTimeTitleFilterData);
      }

      protected void E153O2( )
      {
         /* Ddo_br_information_patientno_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_information_patientno_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_br_information_patientno_Sortedstatus = "ASC";
            ucDdo_br_information_patientno.SendProperty(context, "", false, Ddo_br_information_patientno_Internalname, "SortedStatus", Ddo_br_information_patientno_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_information_patientno_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_br_information_patientno_Sortedstatus = "DSC";
            ucDdo_br_information_patientno.SendProperty(context, "", false, Ddo_br_information_patientno_Internalname, "SortedStatus", Ddo_br_information_patientno_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_information_patientno_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV23TFBR_Information_PatientNo = Ddo_br_information_patientno_Filteredtext_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23TFBR_Information_PatientNo", AV23TFBR_Information_PatientNo);
            AV24TFBR_Information_PatientNo_Sel = Ddo_br_information_patientno_Selectedvalue_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24TFBR_Information_PatientNo_Sel", AV24TFBR_Information_PatientNo_Sel);
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_ProcedureIDTitleFilterData", AV16BR_ProcedureIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18BR_EncounterIDTitleFilterData", AV18BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22BR_Information_PatientNoTitleFilterData", AV22BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV26BR_Procedure_PXIDTitleFilterData", AV26BR_Procedure_PXIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30BR_Procedure_PXSurgeryTitleFilterData", AV30BR_Procedure_PXSurgeryTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV82BR_Procedure_DateTitleFilterData", AV82BR_Procedure_DateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_Procedure_PXRadiotherapyTitleFilterData", AV38BR_Procedure_PXRadiotherapyTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV92BR_Procedure_RadioDateTitleFilterData", AV92BR_Procedure_RadioDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV98BR_Procedure_RadioTimeTitleFilterData", AV98BR_Procedure_RadioTimeTitleFilterData);
      }

      protected void E163O2( )
      {
         /* Ddo_br_procedure_pxid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_procedure_pxid_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_br_procedure_pxid_Sortedstatus = "ASC";
            ucDdo_br_procedure_pxid.SendProperty(context, "", false, Ddo_br_procedure_pxid_Internalname, "SortedStatus", Ddo_br_procedure_pxid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_procedure_pxid_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_br_procedure_pxid_Sortedstatus = "DSC";
            ucDdo_br_procedure_pxid.SendProperty(context, "", false, Ddo_br_procedure_pxid_Internalname, "SortedStatus", Ddo_br_procedure_pxid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_procedure_pxid_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV27TFBR_Procedure_PXID = (long)(NumberUtil.Val( Ddo_br_procedure_pxid_Filteredtext_get, "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27TFBR_Procedure_PXID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV27TFBR_Procedure_PXID), 10, 0)));
            AV28TFBR_Procedure_PXID_To = (long)(NumberUtil.Val( Ddo_br_procedure_pxid_Filteredtextto_get, "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV28TFBR_Procedure_PXID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV28TFBR_Procedure_PXID_To), 10, 0)));
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_ProcedureIDTitleFilterData", AV16BR_ProcedureIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18BR_EncounterIDTitleFilterData", AV18BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22BR_Information_PatientNoTitleFilterData", AV22BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV26BR_Procedure_PXIDTitleFilterData", AV26BR_Procedure_PXIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30BR_Procedure_PXSurgeryTitleFilterData", AV30BR_Procedure_PXSurgeryTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV82BR_Procedure_DateTitleFilterData", AV82BR_Procedure_DateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_Procedure_PXRadiotherapyTitleFilterData", AV38BR_Procedure_PXRadiotherapyTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV92BR_Procedure_RadioDateTitleFilterData", AV92BR_Procedure_RadioDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV98BR_Procedure_RadioTimeTitleFilterData", AV98BR_Procedure_RadioTimeTitleFilterData);
      }

      protected void E173O2( )
      {
         /* Ddo_br_procedure_pxsurgery_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_procedure_pxsurgery_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_br_procedure_pxsurgery_Sortedstatus = "ASC";
            ucDdo_br_procedure_pxsurgery.SendProperty(context, "", false, Ddo_br_procedure_pxsurgery_Internalname, "SortedStatus", Ddo_br_procedure_pxsurgery_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_procedure_pxsurgery_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_br_procedure_pxsurgery_Sortedstatus = "DSC";
            ucDdo_br_procedure_pxsurgery.SendProperty(context, "", false, Ddo_br_procedure_pxsurgery_Internalname, "SortedStatus", Ddo_br_procedure_pxsurgery_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_procedure_pxsurgery_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV31TFBR_Procedure_PXSurgery_SelsJson = Ddo_br_procedure_pxsurgery_Selectedvalue_get;
            AV32TFBR_Procedure_PXSurgery_Sels.FromJSonString(AV31TFBR_Procedure_PXSurgery_SelsJson, null);
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32TFBR_Procedure_PXSurgery_Sels", AV32TFBR_Procedure_PXSurgery_Sels);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_ProcedureIDTitleFilterData", AV16BR_ProcedureIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18BR_EncounterIDTitleFilterData", AV18BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22BR_Information_PatientNoTitleFilterData", AV22BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV26BR_Procedure_PXIDTitleFilterData", AV26BR_Procedure_PXIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30BR_Procedure_PXSurgeryTitleFilterData", AV30BR_Procedure_PXSurgeryTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV82BR_Procedure_DateTitleFilterData", AV82BR_Procedure_DateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_Procedure_PXRadiotherapyTitleFilterData", AV38BR_Procedure_PXRadiotherapyTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV92BR_Procedure_RadioDateTitleFilterData", AV92BR_Procedure_RadioDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV98BR_Procedure_RadioTimeTitleFilterData", AV98BR_Procedure_RadioTimeTitleFilterData);
      }

      protected void E183O2( )
      {
         /* Ddo_br_procedure_date_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_procedure_date_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_br_procedure_date_Sortedstatus = "ASC";
            ucDdo_br_procedure_date.SendProperty(context, "", false, Ddo_br_procedure_date_Internalname, "SortedStatus", Ddo_br_procedure_date_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_procedure_date_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_br_procedure_date_Sortedstatus = "DSC";
            ucDdo_br_procedure_date.SendProperty(context, "", false, Ddo_br_procedure_date_Internalname, "SortedStatus", Ddo_br_procedure_date_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_procedure_date_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV83TFBR_Procedure_Date = context.localUtil.CToD( Ddo_br_procedure_date_Filteredtext_get, 0);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV83TFBR_Procedure_Date", context.localUtil.Format(AV83TFBR_Procedure_Date, "9999/99/99"));
            AV84TFBR_Procedure_Date_To = context.localUtil.CToD( Ddo_br_procedure_date_Filteredtextto_get, 0);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV84TFBR_Procedure_Date_To", context.localUtil.Format(AV84TFBR_Procedure_Date_To, "9999/99/99"));
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_ProcedureIDTitleFilterData", AV16BR_ProcedureIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18BR_EncounterIDTitleFilterData", AV18BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22BR_Information_PatientNoTitleFilterData", AV22BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV26BR_Procedure_PXIDTitleFilterData", AV26BR_Procedure_PXIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30BR_Procedure_PXSurgeryTitleFilterData", AV30BR_Procedure_PXSurgeryTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV82BR_Procedure_DateTitleFilterData", AV82BR_Procedure_DateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_Procedure_PXRadiotherapyTitleFilterData", AV38BR_Procedure_PXRadiotherapyTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV92BR_Procedure_RadioDateTitleFilterData", AV92BR_Procedure_RadioDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV98BR_Procedure_RadioTimeTitleFilterData", AV98BR_Procedure_RadioTimeTitleFilterData);
      }

      protected void E193O2( )
      {
         /* Ddo_br_procedure_pxradiotherapy_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_procedure_pxradiotherapy_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_br_procedure_pxradiotherapy_Sortedstatus = "ASC";
            ucDdo_br_procedure_pxradiotherapy.SendProperty(context, "", false, Ddo_br_procedure_pxradiotherapy_Internalname, "SortedStatus", Ddo_br_procedure_pxradiotherapy_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_procedure_pxradiotherapy_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_br_procedure_pxradiotherapy_Sortedstatus = "DSC";
            ucDdo_br_procedure_pxradiotherapy.SendProperty(context, "", false, Ddo_br_procedure_pxradiotherapy_Internalname, "SortedStatus", Ddo_br_procedure_pxradiotherapy_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_procedure_pxradiotherapy_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV39TFBR_Procedure_PXRadiotherapy_SelsJson = Ddo_br_procedure_pxradiotherapy_Selectedvalue_get;
            AV40TFBR_Procedure_PXRadiotherapy_Sels.FromJSonString(AV39TFBR_Procedure_PXRadiotherapy_SelsJson, null);
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40TFBR_Procedure_PXRadiotherapy_Sels", AV40TFBR_Procedure_PXRadiotherapy_Sels);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_ProcedureIDTitleFilterData", AV16BR_ProcedureIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18BR_EncounterIDTitleFilterData", AV18BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22BR_Information_PatientNoTitleFilterData", AV22BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV26BR_Procedure_PXIDTitleFilterData", AV26BR_Procedure_PXIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30BR_Procedure_PXSurgeryTitleFilterData", AV30BR_Procedure_PXSurgeryTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV82BR_Procedure_DateTitleFilterData", AV82BR_Procedure_DateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_Procedure_PXRadiotherapyTitleFilterData", AV38BR_Procedure_PXRadiotherapyTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV92BR_Procedure_RadioDateTitleFilterData", AV92BR_Procedure_RadioDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV98BR_Procedure_RadioTimeTitleFilterData", AV98BR_Procedure_RadioTimeTitleFilterData);
      }

      protected void E203O2( )
      {
         /* Ddo_br_procedure_radiodate_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_procedure_radiodate_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_br_procedure_radiodate_Sortedstatus = "ASC";
            ucDdo_br_procedure_radiodate.SendProperty(context, "", false, Ddo_br_procedure_radiodate_Internalname, "SortedStatus", Ddo_br_procedure_radiodate_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_procedure_radiodate_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_br_procedure_radiodate_Sortedstatus = "DSC";
            ucDdo_br_procedure_radiodate.SendProperty(context, "", false, Ddo_br_procedure_radiodate_Internalname, "SortedStatus", Ddo_br_procedure_radiodate_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_procedure_radiodate_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV93TFBR_Procedure_RadioDate = context.localUtil.CToD( Ddo_br_procedure_radiodate_Filteredtext_get, 0);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV93TFBR_Procedure_RadioDate", context.localUtil.Format(AV93TFBR_Procedure_RadioDate, "9999/99/99"));
            AV94TFBR_Procedure_RadioDate_To = context.localUtil.CToD( Ddo_br_procedure_radiodate_Filteredtextto_get, 0);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV94TFBR_Procedure_RadioDate_To", context.localUtil.Format(AV94TFBR_Procedure_RadioDate_To, "9999/99/99"));
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_ProcedureIDTitleFilterData", AV16BR_ProcedureIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18BR_EncounterIDTitleFilterData", AV18BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22BR_Information_PatientNoTitleFilterData", AV22BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV26BR_Procedure_PXIDTitleFilterData", AV26BR_Procedure_PXIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30BR_Procedure_PXSurgeryTitleFilterData", AV30BR_Procedure_PXSurgeryTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV82BR_Procedure_DateTitleFilterData", AV82BR_Procedure_DateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_Procedure_PXRadiotherapyTitleFilterData", AV38BR_Procedure_PXRadiotherapyTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV92BR_Procedure_RadioDateTitleFilterData", AV92BR_Procedure_RadioDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV98BR_Procedure_RadioTimeTitleFilterData", AV98BR_Procedure_RadioTimeTitleFilterData);
      }

      protected void E213O2( )
      {
         /* Ddo_br_procedure_radiotime_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_procedure_radiotime_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 9;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_procedure_radiotime_Sortedstatus = "ASC";
            ucDdo_br_procedure_radiotime.SendProperty(context, "", false, Ddo_br_procedure_radiotime_Internalname, "SortedStatus", Ddo_br_procedure_radiotime_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_procedure_radiotime_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 9;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_procedure_radiotime_Sortedstatus = "DSC";
            ucDdo_br_procedure_radiotime.SendProperty(context, "", false, Ddo_br_procedure_radiotime_Internalname, "SortedStatus", Ddo_br_procedure_radiotime_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_procedure_radiotime_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV99TFBR_Procedure_RadioTime = NumberUtil.Val( Ddo_br_procedure_radiotime_Filteredtext_get, ".");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV99TFBR_Procedure_RadioTime", StringUtil.LTrim( StringUtil.Str( AV99TFBR_Procedure_RadioTime, 15, 5)));
            AV100TFBR_Procedure_RadioTime_To = NumberUtil.Val( Ddo_br_procedure_radiotime_Filteredtextto_get, ".");
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV100TFBR_Procedure_RadioTime_To", StringUtil.LTrim( StringUtil.Str( AV100TFBR_Procedure_RadioTime_To, 15, 5)));
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_ProcedureIDTitleFilterData", AV16BR_ProcedureIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18BR_EncounterIDTitleFilterData", AV18BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22BR_Information_PatientNoTitleFilterData", AV22BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV26BR_Procedure_PXIDTitleFilterData", AV26BR_Procedure_PXIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30BR_Procedure_PXSurgeryTitleFilterData", AV30BR_Procedure_PXSurgeryTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV82BR_Procedure_DateTitleFilterData", AV82BR_Procedure_DateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_Procedure_PXRadiotherapyTitleFilterData", AV38BR_Procedure_PXRadiotherapyTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV92BR_Procedure_RadioDateTitleFilterData", AV92BR_Procedure_RadioDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV98BR_Procedure_RadioTimeTitleFilterData", AV98BR_Procedure_RadioTimeTitleFilterData);
      }

      private void E253O2( )
      {
         /* Grid_Load Routine */
         AV73Display = context.GetImagePath( "f11923b6-6acd-4a79-bfc0-0cfc6f3bced5", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavDisplay_Internalname, AV73Display);
         AV121Display_GXI = GXDbFile.PathToUrl( context.GetImagePath( "f11923b6-6acd-4a79-bfc0-0cfc6f3bced5", "", context.GetTheme( )));
         edtavDisplay_Tooltiptext = "显示";
         edtavDisplay_Link = formatLink("br_procedureview.aspx") + "?" + UrlEncode("" +A139BR_ProcedureID) + "," + UrlEncode(StringUtil.RTrim(""));
         AV74Update = context.GetImagePath( "7c63c2b9-483e-4035-b512-febf9186a274", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavUpdate_Internalname, AV74Update);
         AV122Update_GXI = GXDbFile.PathToUrl( context.GetImagePath( "7c63c2b9-483e-4035-b512-febf9186a274", "", context.GetTheme( )));
         edtavUpdate_Tooltiptext = "修改";
         if ( AV75IsAuthorized_Update )
         {
            edtavUpdate_Link = formatLink("br_procedure.aspx") + "?" + UrlEncode(StringUtil.RTrim("UPD")) + "," + UrlEncode("" +A139BR_ProcedureID);
         }
         AV76Delete = context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavDelete_Internalname, AV76Delete);
         AV123Delete_GXI = GXDbFile.PathToUrl( context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", context.GetTheme( )));
         edtavDelete_Tooltiptext = "删除";
         if ( AV77IsAuthorized_Delete )
         {
            edtavDelete_Link = formatLink("br_procedure.aspx") + "?" + UrlEncode(StringUtil.RTrim("DLT")) + "," + UrlEncode("" +A139BR_ProcedureID);
         }
         if ( AV78IsAuthorized_BR_Information_PatientNo )
         {
            edtBR_Information_PatientNo_Link = formatLink("br_informationview.aspx") + "?" + UrlEncode("" +A85BR_Information_ID) + "," + UrlEncode(StringUtil.RTrim(""));
         }
         /* Load Method */
         if ( wbStart != -1 )
         {
            wbStart = 28;
         }
         sendrow_282( ) ;
         GRID_nCurrentRecord = (long)(GRID_nCurrentRecord+1);
         if ( isFullAjaxMode( ) && ! bGXsfl_28_Refreshing )
         {
            context.DoAjaxLoad(28, GridRow);
         }
         /*  Sending Event outputs  */
      }

      protected void E223O2( )
      {
         /* 'DoInsert' Routine */
         CallWebObject(formatLink("br_procedure.aspx") + "?" + UrlEncode(StringUtil.RTrim("INS")) + "," + UrlEncode("" +0));
         context.wjLocDisableFrm = 1;
      }

      protected void S162( )
      {
         /* 'RESETDDOSORTEDSTATUS' Routine */
         Ddo_br_procedureid_Sortedstatus = "";
         ucDdo_br_procedureid.SendProperty(context, "", false, Ddo_br_procedureid_Internalname, "SortedStatus", Ddo_br_procedureid_Sortedstatus);
         Ddo_br_encounterid_Sortedstatus = "";
         ucDdo_br_encounterid.SendProperty(context, "", false, Ddo_br_encounterid_Internalname, "SortedStatus", Ddo_br_encounterid_Sortedstatus);
         Ddo_br_information_patientno_Sortedstatus = "";
         ucDdo_br_information_patientno.SendProperty(context, "", false, Ddo_br_information_patientno_Internalname, "SortedStatus", Ddo_br_information_patientno_Sortedstatus);
         Ddo_br_procedure_pxid_Sortedstatus = "";
         ucDdo_br_procedure_pxid.SendProperty(context, "", false, Ddo_br_procedure_pxid_Internalname, "SortedStatus", Ddo_br_procedure_pxid_Sortedstatus);
         Ddo_br_procedure_pxsurgery_Sortedstatus = "";
         ucDdo_br_procedure_pxsurgery.SendProperty(context, "", false, Ddo_br_procedure_pxsurgery_Internalname, "SortedStatus", Ddo_br_procedure_pxsurgery_Sortedstatus);
         Ddo_br_procedure_date_Sortedstatus = "";
         ucDdo_br_procedure_date.SendProperty(context, "", false, Ddo_br_procedure_date_Internalname, "SortedStatus", Ddo_br_procedure_date_Sortedstatus);
         Ddo_br_procedure_pxradiotherapy_Sortedstatus = "";
         ucDdo_br_procedure_pxradiotherapy.SendProperty(context, "", false, Ddo_br_procedure_pxradiotherapy_Internalname, "SortedStatus", Ddo_br_procedure_pxradiotherapy_Sortedstatus);
         Ddo_br_procedure_radiodate_Sortedstatus = "";
         ucDdo_br_procedure_radiodate.SendProperty(context, "", false, Ddo_br_procedure_radiodate_Internalname, "SortedStatus", Ddo_br_procedure_radiodate_Sortedstatus);
         Ddo_br_procedure_radiotime_Sortedstatus = "";
         ucDdo_br_procedure_radiotime.SendProperty(context, "", false, Ddo_br_procedure_radiotime_Internalname, "SortedStatus", Ddo_br_procedure_radiotime_Sortedstatus);
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
            Ddo_br_procedureid_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_procedureid.SendProperty(context, "", false, Ddo_br_procedureid_Internalname, "SortedStatus", Ddo_br_procedureid_Sortedstatus);
         }
         else if ( AV13OrderedBy == 2 )
         {
            Ddo_br_encounterid_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_encounterid.SendProperty(context, "", false, Ddo_br_encounterid_Internalname, "SortedStatus", Ddo_br_encounterid_Sortedstatus);
         }
         else if ( AV13OrderedBy == 3 )
         {
            Ddo_br_information_patientno_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_information_patientno.SendProperty(context, "", false, Ddo_br_information_patientno_Internalname, "SortedStatus", Ddo_br_information_patientno_Sortedstatus);
         }
         else if ( AV13OrderedBy == 4 )
         {
            Ddo_br_procedure_pxid_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_procedure_pxid.SendProperty(context, "", false, Ddo_br_procedure_pxid_Internalname, "SortedStatus", Ddo_br_procedure_pxid_Sortedstatus);
         }
         else if ( AV13OrderedBy == 5 )
         {
            Ddo_br_procedure_pxsurgery_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_procedure_pxsurgery.SendProperty(context, "", false, Ddo_br_procedure_pxsurgery_Internalname, "SortedStatus", Ddo_br_procedure_pxsurgery_Sortedstatus);
         }
         else if ( AV13OrderedBy == 6 )
         {
            Ddo_br_procedure_date_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_procedure_date.SendProperty(context, "", false, Ddo_br_procedure_date_Internalname, "SortedStatus", Ddo_br_procedure_date_Sortedstatus);
         }
         else if ( AV13OrderedBy == 7 )
         {
            Ddo_br_procedure_pxradiotherapy_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_procedure_pxradiotherapy.SendProperty(context, "", false, Ddo_br_procedure_pxradiotherapy_Internalname, "SortedStatus", Ddo_br_procedure_pxradiotherapy_Sortedstatus);
         }
         else if ( AV13OrderedBy == 8 )
         {
            Ddo_br_procedure_radiodate_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_procedure_radiodate.SendProperty(context, "", false, Ddo_br_procedure_radiodate_Internalname, "SortedStatus", Ddo_br_procedure_radiodate_Sortedstatus);
         }
         else if ( AV13OrderedBy == 9 )
         {
            Ddo_br_procedure_radiotime_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_procedure_radiotime.SendProperty(context, "", false, Ddo_br_procedure_radiotime_Internalname, "SortedStatus", Ddo_br_procedure_radiotime_Sortedstatus);
         }
      }

      protected void S142( )
      {
         /* 'CHECKSECURITYFORACTIONS' Routine */
         GXt_boolean1 = AV75IsAuthorized_Update;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Procedure", out  GXt_boolean1) ;
         AV75IsAuthorized_Update = GXt_boolean1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV75IsAuthorized_Update", AV75IsAuthorized_Update);
         if ( ! ( AV75IsAuthorized_Update ) )
         {
            edtavUpdate_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUpdate_Visible), 5, 0)), !bGXsfl_28_Refreshing);
         }
         GXt_boolean1 = AV77IsAuthorized_Delete;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Procedure", out  GXt_boolean1) ;
         AV77IsAuthorized_Delete = GXt_boolean1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV77IsAuthorized_Delete", AV77IsAuthorized_Delete);
         if ( ! ( AV77IsAuthorized_Delete ) )
         {
            edtavDelete_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDelete_Visible), 5, 0)), !bGXsfl_28_Refreshing);
         }
         GXt_boolean1 = AV79TempBoolean;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Procedure", out  GXt_boolean1) ;
         AV79TempBoolean = GXt_boolean1;
         if ( ! ( AV79TempBoolean ) )
         {
            bttBtninsert_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtninsert_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtninsert_Visible), 5, 0)), true);
         }
      }

      protected void S122( )
      {
         /* 'LOADGRIDSTATE' Routine */
         if ( StringUtil.StrCmp(AV15Session.Get(AV124Pgmname+"GridState"), "") == 0 )
         {
            AV11GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  AV124Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         else
         {
            AV11GridState.FromXml(AV15Session.Get(AV124Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
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
         AV125GXV1 = 1;
         while ( AV125GXV1 <= AV11GridState.gxTpr_Filtervalues.Count )
         {
            AV12GridStateFilterValue = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue)AV11GridState.gxTpr_Filtervalues.Item(AV125GXV1));
            if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_PROCEDUREID") == 0 )
            {
               AV80TFBR_ProcedureID = (long)(NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Value, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV80TFBR_ProcedureID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV80TFBR_ProcedureID), 18, 0)));
               AV81TFBR_ProcedureID_To = (long)(NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Valueto, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV81TFBR_ProcedureID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV81TFBR_ProcedureID_To), 18, 0)));
               if ( ! (0==AV80TFBR_ProcedureID) )
               {
                  Ddo_br_procedureid_Filteredtext_set = StringUtil.Str( (decimal)(AV80TFBR_ProcedureID), 18, 0);
                  ucDdo_br_procedureid.SendProperty(context, "", false, Ddo_br_procedureid_Internalname, "FilteredText_set", Ddo_br_procedureid_Filteredtext_set);
               }
               if ( ! (0==AV81TFBR_ProcedureID_To) )
               {
                  Ddo_br_procedureid_Filteredtextto_set = StringUtil.Str( (decimal)(AV81TFBR_ProcedureID_To), 18, 0);
                  ucDdo_br_procedureid.SendProperty(context, "", false, Ddo_br_procedureid_Internalname, "FilteredTextTo_set", Ddo_br_procedureid_Filteredtextto_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_ENCOUNTERID") == 0 )
            {
               AV19TFBR_EncounterID = (long)(NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Value, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19TFBR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV19TFBR_EncounterID), 18, 0)));
               AV20TFBR_EncounterID_To = (long)(NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Valueto, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20TFBR_EncounterID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV20TFBR_EncounterID_To), 18, 0)));
               if ( ! (0==AV19TFBR_EncounterID) )
               {
                  Ddo_br_encounterid_Filteredtext_set = StringUtil.Str( (decimal)(AV19TFBR_EncounterID), 18, 0);
                  ucDdo_br_encounterid.SendProperty(context, "", false, Ddo_br_encounterid_Internalname, "FilteredText_set", Ddo_br_encounterid_Filteredtext_set);
               }
               if ( ! (0==AV20TFBR_EncounterID_To) )
               {
                  Ddo_br_encounterid_Filteredtextto_set = StringUtil.Str( (decimal)(AV20TFBR_EncounterID_To), 18, 0);
                  ucDdo_br_encounterid.SendProperty(context, "", false, Ddo_br_encounterid_Internalname, "FilteredTextTo_set", Ddo_br_encounterid_Filteredtextto_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_INFORMATION_PATIENTNO") == 0 )
            {
               AV23TFBR_Information_PatientNo = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23TFBR_Information_PatientNo", AV23TFBR_Information_PatientNo);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV23TFBR_Information_PatientNo)) )
               {
                  Ddo_br_information_patientno_Filteredtext_set = AV23TFBR_Information_PatientNo;
                  ucDdo_br_information_patientno.SendProperty(context, "", false, Ddo_br_information_patientno_Internalname, "FilteredText_set", Ddo_br_information_patientno_Filteredtext_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_INFORMATION_PATIENTNO_SEL") == 0 )
            {
               AV24TFBR_Information_PatientNo_Sel = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24TFBR_Information_PatientNo_Sel", AV24TFBR_Information_PatientNo_Sel);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV24TFBR_Information_PatientNo_Sel)) )
               {
                  Ddo_br_information_patientno_Selectedvalue_set = AV24TFBR_Information_PatientNo_Sel;
                  ucDdo_br_information_patientno.SendProperty(context, "", false, Ddo_br_information_patientno_Internalname, "SelectedValue_set", Ddo_br_information_patientno_Selectedvalue_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_PROCEDURE_PXID") == 0 )
            {
               AV27TFBR_Procedure_PXID = (long)(NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Value, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27TFBR_Procedure_PXID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV27TFBR_Procedure_PXID), 10, 0)));
               AV28TFBR_Procedure_PXID_To = (long)(NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Valueto, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV28TFBR_Procedure_PXID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV28TFBR_Procedure_PXID_To), 10, 0)));
               if ( ! (0==AV27TFBR_Procedure_PXID) )
               {
                  Ddo_br_procedure_pxid_Filteredtext_set = StringUtil.Str( (decimal)(AV27TFBR_Procedure_PXID), 10, 0);
                  ucDdo_br_procedure_pxid.SendProperty(context, "", false, Ddo_br_procedure_pxid_Internalname, "FilteredText_set", Ddo_br_procedure_pxid_Filteredtext_set);
               }
               if ( ! (0==AV28TFBR_Procedure_PXID_To) )
               {
                  Ddo_br_procedure_pxid_Filteredtextto_set = StringUtil.Str( (decimal)(AV28TFBR_Procedure_PXID_To), 10, 0);
                  ucDdo_br_procedure_pxid.SendProperty(context, "", false, Ddo_br_procedure_pxid_Internalname, "FilteredTextTo_set", Ddo_br_procedure_pxid_Filteredtextto_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_PROCEDURE_PXSURGERY_SEL") == 0 )
            {
               AV31TFBR_Procedure_PXSurgery_SelsJson = AV12GridStateFilterValue.gxTpr_Value;
               AV32TFBR_Procedure_PXSurgery_Sels.FromJSonString(AV31TFBR_Procedure_PXSurgery_SelsJson, null);
               if ( ! ( AV32TFBR_Procedure_PXSurgery_Sels.Count == 0 ) )
               {
                  Ddo_br_procedure_pxsurgery_Selectedvalue_set = AV31TFBR_Procedure_PXSurgery_SelsJson;
                  ucDdo_br_procedure_pxsurgery.SendProperty(context, "", false, Ddo_br_procedure_pxsurgery_Internalname, "SelectedValue_set", Ddo_br_procedure_pxsurgery_Selectedvalue_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_PROCEDURE_DATE") == 0 )
            {
               AV83TFBR_Procedure_Date = context.localUtil.CToD( AV12GridStateFilterValue.gxTpr_Value, 0);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV83TFBR_Procedure_Date", context.localUtil.Format(AV83TFBR_Procedure_Date, "9999/99/99"));
               AV84TFBR_Procedure_Date_To = context.localUtil.CToD( AV12GridStateFilterValue.gxTpr_Valueto, 0);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV84TFBR_Procedure_Date_To", context.localUtil.Format(AV84TFBR_Procedure_Date_To, "9999/99/99"));
               if ( ! (DateTime.MinValue==AV83TFBR_Procedure_Date) )
               {
                  Ddo_br_procedure_date_Filteredtext_set = context.localUtil.DToC( AV83TFBR_Procedure_Date, 0, "/");
                  ucDdo_br_procedure_date.SendProperty(context, "", false, Ddo_br_procedure_date_Internalname, "FilteredText_set", Ddo_br_procedure_date_Filteredtext_set);
               }
               if ( ! (DateTime.MinValue==AV84TFBR_Procedure_Date_To) )
               {
                  Ddo_br_procedure_date_Filteredtextto_set = context.localUtil.DToC( AV84TFBR_Procedure_Date_To, 0, "/");
                  ucDdo_br_procedure_date.SendProperty(context, "", false, Ddo_br_procedure_date_Internalname, "FilteredTextTo_set", Ddo_br_procedure_date_Filteredtextto_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_PROCEDURE_PXRADIOTHERAPY_SEL") == 0 )
            {
               AV39TFBR_Procedure_PXRadiotherapy_SelsJson = AV12GridStateFilterValue.gxTpr_Value;
               AV40TFBR_Procedure_PXRadiotherapy_Sels.FromJSonString(AV39TFBR_Procedure_PXRadiotherapy_SelsJson, null);
               if ( ! ( AV40TFBR_Procedure_PXRadiotherapy_Sels.Count == 0 ) )
               {
                  Ddo_br_procedure_pxradiotherapy_Selectedvalue_set = AV39TFBR_Procedure_PXRadiotherapy_SelsJson;
                  ucDdo_br_procedure_pxradiotherapy.SendProperty(context, "", false, Ddo_br_procedure_pxradiotherapy_Internalname, "SelectedValue_set", Ddo_br_procedure_pxradiotherapy_Selectedvalue_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_PROCEDURE_RADIODATE") == 0 )
            {
               AV93TFBR_Procedure_RadioDate = context.localUtil.CToD( AV12GridStateFilterValue.gxTpr_Value, 0);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV93TFBR_Procedure_RadioDate", context.localUtil.Format(AV93TFBR_Procedure_RadioDate, "9999/99/99"));
               AV94TFBR_Procedure_RadioDate_To = context.localUtil.CToD( AV12GridStateFilterValue.gxTpr_Valueto, 0);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV94TFBR_Procedure_RadioDate_To", context.localUtil.Format(AV94TFBR_Procedure_RadioDate_To, "9999/99/99"));
               if ( ! (DateTime.MinValue==AV93TFBR_Procedure_RadioDate) )
               {
                  Ddo_br_procedure_radiodate_Filteredtext_set = context.localUtil.DToC( AV93TFBR_Procedure_RadioDate, 0, "/");
                  ucDdo_br_procedure_radiodate.SendProperty(context, "", false, Ddo_br_procedure_radiodate_Internalname, "FilteredText_set", Ddo_br_procedure_radiodate_Filteredtext_set);
               }
               if ( ! (DateTime.MinValue==AV94TFBR_Procedure_RadioDate_To) )
               {
                  Ddo_br_procedure_radiodate_Filteredtextto_set = context.localUtil.DToC( AV94TFBR_Procedure_RadioDate_To, 0, "/");
                  ucDdo_br_procedure_radiodate.SendProperty(context, "", false, Ddo_br_procedure_radiodate_Internalname, "FilteredTextTo_set", Ddo_br_procedure_radiodate_Filteredtextto_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_PROCEDURE_RADIOTIME") == 0 )
            {
               AV99TFBR_Procedure_RadioTime = NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Value, ".");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV99TFBR_Procedure_RadioTime", StringUtil.LTrim( StringUtil.Str( AV99TFBR_Procedure_RadioTime, 15, 5)));
               AV100TFBR_Procedure_RadioTime_To = NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Valueto, ".");
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV100TFBR_Procedure_RadioTime_To", StringUtil.LTrim( StringUtil.Str( AV100TFBR_Procedure_RadioTime_To, 15, 5)));
               if ( ! (Convert.ToDecimal(0)==AV99TFBR_Procedure_RadioTime) )
               {
                  Ddo_br_procedure_radiotime_Filteredtext_set = StringUtil.Str( AV99TFBR_Procedure_RadioTime, 15, 5);
                  ucDdo_br_procedure_radiotime.SendProperty(context, "", false, Ddo_br_procedure_radiotime_Internalname, "FilteredText_set", Ddo_br_procedure_radiotime_Filteredtext_set);
               }
               if ( ! (Convert.ToDecimal(0)==AV100TFBR_Procedure_RadioTime_To) )
               {
                  Ddo_br_procedure_radiotime_Filteredtextto_set = StringUtil.Str( AV100TFBR_Procedure_RadioTime_To, 15, 5);
                  ucDdo_br_procedure_radiotime.SendProperty(context, "", false, Ddo_br_procedure_radiotime_Internalname, "FilteredTextTo_set", Ddo_br_procedure_radiotime_Filteredtextto_set);
               }
            }
            AV125GXV1 = (int)(AV125GXV1+1);
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
         AV11GridState.FromXml(AV15Session.Get(AV124Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         AV11GridState.gxTpr_Orderedby = AV13OrderedBy;
         AV11GridState.gxTpr_Ordereddsc = AV14OrderedDsc;
         AV11GridState.gxTpr_Filtervalues.Clear();
         if ( ! ( (0==AV80TFBR_ProcedureID) && (0==AV81TFBR_ProcedureID_To) ) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_PROCEDUREID";
            AV12GridStateFilterValue.gxTpr_Value = StringUtil.Str( (decimal)(AV80TFBR_ProcedureID), 18, 0);
            AV12GridStateFilterValue.gxTpr_Valueto = StringUtil.Str( (decimal)(AV81TFBR_ProcedureID_To), 18, 0);
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! ( (0==AV19TFBR_EncounterID) && (0==AV20TFBR_EncounterID_To) ) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_ENCOUNTERID";
            AV12GridStateFilterValue.gxTpr_Value = StringUtil.Str( (decimal)(AV19TFBR_EncounterID), 18, 0);
            AV12GridStateFilterValue.gxTpr_Valueto = StringUtil.Str( (decimal)(AV20TFBR_EncounterID_To), 18, 0);
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV23TFBR_Information_PatientNo)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_INFORMATION_PATIENTNO";
            AV12GridStateFilterValue.gxTpr_Value = AV23TFBR_Information_PatientNo;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV24TFBR_Information_PatientNo_Sel)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_INFORMATION_PATIENTNO_SEL";
            AV12GridStateFilterValue.gxTpr_Value = AV24TFBR_Information_PatientNo_Sel;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! ( (0==AV27TFBR_Procedure_PXID) && (0==AV28TFBR_Procedure_PXID_To) ) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_PROCEDURE_PXID";
            AV12GridStateFilterValue.gxTpr_Value = StringUtil.Str( (decimal)(AV27TFBR_Procedure_PXID), 10, 0);
            AV12GridStateFilterValue.gxTpr_Valueto = StringUtil.Str( (decimal)(AV28TFBR_Procedure_PXID_To), 10, 0);
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! ( AV32TFBR_Procedure_PXSurgery_Sels.Count == 0 ) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_PROCEDURE_PXSURGERY_SEL";
            AV12GridStateFilterValue.gxTpr_Value = AV32TFBR_Procedure_PXSurgery_Sels.ToJSonString(false);
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! ( (DateTime.MinValue==AV83TFBR_Procedure_Date) && (DateTime.MinValue==AV84TFBR_Procedure_Date_To) ) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_PROCEDURE_DATE";
            AV12GridStateFilterValue.gxTpr_Value = context.localUtil.DToC( AV83TFBR_Procedure_Date, 0, "/");
            AV12GridStateFilterValue.gxTpr_Valueto = context.localUtil.DToC( AV84TFBR_Procedure_Date_To, 0, "/");
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! ( AV40TFBR_Procedure_PXRadiotherapy_Sels.Count == 0 ) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_PROCEDURE_PXRADIOTHERAPY_SEL";
            AV12GridStateFilterValue.gxTpr_Value = AV40TFBR_Procedure_PXRadiotherapy_Sels.ToJSonString(false);
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! ( (DateTime.MinValue==AV93TFBR_Procedure_RadioDate) && (DateTime.MinValue==AV94TFBR_Procedure_RadioDate_To) ) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_PROCEDURE_RADIODATE";
            AV12GridStateFilterValue.gxTpr_Value = context.localUtil.DToC( AV93TFBR_Procedure_RadioDate, 0, "/");
            AV12GridStateFilterValue.gxTpr_Valueto = context.localUtil.DToC( AV94TFBR_Procedure_RadioDate_To, 0, "/");
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! ( (Convert.ToDecimal(0)==AV99TFBR_Procedure_RadioTime) && (Convert.ToDecimal(0)==AV100TFBR_Procedure_RadioTime_To) ) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_PROCEDURE_RADIOTIME";
            AV12GridStateFilterValue.gxTpr_Value = StringUtil.Str( AV99TFBR_Procedure_RadioTime, 15, 5);
            AV12GridStateFilterValue.gxTpr_Valueto = StringUtil.Str( AV100TFBR_Procedure_RadioTime_To, 15, 5);
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         AV11GridState.gxTpr_Pagesize = StringUtil.Str( (decimal)(subGrid_Rows), 10, 0);
         AV11GridState.gxTpr_Currentpage = (short)(subGrid_Currentpage( ));
         new GeneXus.Programs.wwpbaseobjects.savegridstate(context ).execute(  AV124Pgmname+"GridState",  AV11GridState.ToXml(false, true, "WWPGridState", "DataAnalysisPlatform")) ;
      }

      protected void S112( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV9TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV9TrnContext.gxTpr_Callerobject = AV124Pgmname;
         AV9TrnContext.gxTpr_Callerondelete = true;
         AV9TrnContext.gxTpr_Callerurl = AV8HTTPRequest.ScriptName+"?"+AV8HTTPRequest.QueryString;
         AV9TrnContext.gxTpr_Transactionname = "BR_Procedure";
         AV15Session.Set("TrnContext", AV9TrnContext.ToXml(false, true, "WWPTransactionContext", "DataAnalysisPlatform"));
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
         PA3O2( ) ;
         WS3O2( ) ;
         WE3O2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202022815111543", true);
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
         context.AddJavascriptSource("br_procedureww.js", "?202022815111544", false);
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
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_282( )
      {
         edtavDisplay_Internalname = "vDISPLAY_"+sGXsfl_28_idx;
         edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_28_idx;
         edtavDelete_Internalname = "vDELETE_"+sGXsfl_28_idx;
         edtBR_ProcedureID_Internalname = "BR_PROCEDUREID_"+sGXsfl_28_idx;
         edtBR_EncounterID_Internalname = "BR_ENCOUNTERID_"+sGXsfl_28_idx;
         edtBR_Information_PatientNo_Internalname = "BR_INFORMATION_PATIENTNO_"+sGXsfl_28_idx;
         edtBR_Procedure_PXID_Internalname = "BR_PROCEDURE_PXID_"+sGXsfl_28_idx;
         cmbBR_Procedure_PXSurgery_Internalname = "BR_PROCEDURE_PXSURGERY_"+sGXsfl_28_idx;
         edtBR_Procedure_Date_Internalname = "BR_PROCEDURE_DATE_"+sGXsfl_28_idx;
         cmbBR_Procedure_PXRadiotherapy_Internalname = "BR_PROCEDURE_PXRADIOTHERAPY_"+sGXsfl_28_idx;
         edtBR_Procedure_RadioDate_Internalname = "BR_PROCEDURE_RADIODATE_"+sGXsfl_28_idx;
         edtBR_Procedure_RadioTime_Internalname = "BR_PROCEDURE_RADIOTIME_"+sGXsfl_28_idx;
      }

      protected void SubsflControlProps_fel_282( )
      {
         edtavDisplay_Internalname = "vDISPLAY_"+sGXsfl_28_fel_idx;
         edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_28_fel_idx;
         edtavDelete_Internalname = "vDELETE_"+sGXsfl_28_fel_idx;
         edtBR_ProcedureID_Internalname = "BR_PROCEDUREID_"+sGXsfl_28_fel_idx;
         edtBR_EncounterID_Internalname = "BR_ENCOUNTERID_"+sGXsfl_28_fel_idx;
         edtBR_Information_PatientNo_Internalname = "BR_INFORMATION_PATIENTNO_"+sGXsfl_28_fel_idx;
         edtBR_Procedure_PXID_Internalname = "BR_PROCEDURE_PXID_"+sGXsfl_28_fel_idx;
         cmbBR_Procedure_PXSurgery_Internalname = "BR_PROCEDURE_PXSURGERY_"+sGXsfl_28_fel_idx;
         edtBR_Procedure_Date_Internalname = "BR_PROCEDURE_DATE_"+sGXsfl_28_fel_idx;
         cmbBR_Procedure_PXRadiotherapy_Internalname = "BR_PROCEDURE_PXRADIOTHERAPY_"+sGXsfl_28_fel_idx;
         edtBR_Procedure_RadioDate_Internalname = "BR_PROCEDURE_RADIODATE_"+sGXsfl_28_fel_idx;
         edtBR_Procedure_RadioTime_Internalname = "BR_PROCEDURE_RADIOTIME_"+sGXsfl_28_fel_idx;
      }

      protected void sendrow_282( )
      {
         SubsflControlProps_282( ) ;
         WB3O0( ) ;
         if ( ( subGrid_Rows * 1 == 0 ) || ( nGXsfl_28_idx <= subGrid_Recordsperpage( ) * 1 ) )
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
               if ( ((int)(((nGXsfl_28_idx-1)/ (decimal)(1)) % (2))) == 0 )
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
               context.WriteHtmlText( " gxrow=\""+sGXsfl_28_idx+"\">") ;
            }
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "ActionBaseColorAttribute";
            StyleString = "";
            AV73Display_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV73Display))&&String.IsNullOrEmpty(StringUtil.RTrim( AV121Display_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV73Display)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV73Display)) ? AV121Display_GXI : context.PathToRelativeUrl( AV73Display));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavDisplay_Internalname,(String)sImgUrl,(String)edtavDisplay_Link,(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)edtavDisplay_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV73Display_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((edtavUpdate_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "ActionBaseColorAttribute";
            StyleString = "";
            AV74Update_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV74Update))&&String.IsNullOrEmpty(StringUtil.RTrim( AV122Update_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV74Update)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV74Update)) ? AV122Update_GXI : context.PathToRelativeUrl( AV74Update));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavUpdate_Internalname,(String)sImgUrl,(String)edtavUpdate_Link,(String)"",(String)"",context.GetTheme( ),(int)edtavUpdate_Visible,(short)1,(String)"",(String)edtavUpdate_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV74Update_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((edtavDelete_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "DeleteAttribute ActionBaseColorAttribute";
            StyleString = "";
            AV76Delete_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV76Delete))&&String.IsNullOrEmpty(StringUtil.RTrim( AV123Delete_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV76Delete)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV76Delete)) ? AV123Delete_GXI : context.PathToRelativeUrl( AV76Delete));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavDelete_Internalname,(String)sImgUrl,(String)edtavDelete_Link,(String)"",(String)"",context.GetTheme( ),(int)edtavDelete_Visible,(short)1,(String)"",(String)edtavDelete_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV76Delete_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_ProcedureID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A139BR_ProcedureID), 18, 0, ".", "")),context.localUtil.Format( (decimal)(A139BR_ProcedureID), "ZZZZZZZZZZZZZZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_ProcedureID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)28,(short)1,(short)-1,(short)0,(bool)true,(String)"ID",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_EncounterID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A19BR_EncounterID), 18, 0, ".", "")),context.localUtil.Format( (decimal)(A19BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_EncounterID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)28,(short)1,(short)-1,(short)0,(bool)true,(String)"ID",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Information_PatientNo_Internalname,(String)A36BR_Information_PatientNo,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)edtBR_Information_PatientNo_Link,(String)"",(String)"",(String)"",(String)edtBR_Information_PatientNo_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)410,(String)"px",(short)17,(String)"px",(short)2000,(short)0,(short)0,(short)28,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Procedure_PXID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A140BR_Procedure_PXID), 10, 0, ".", "")),context.localUtil.Format( (decimal)(A140BR_Procedure_PXID), "ZZZZZZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Procedure_PXID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)28,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            if ( ( cmbBR_Procedure_PXSurgery.ItemCount == 0 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "BR_PROCEDURE_PXSURGERY_" + sGXsfl_28_idx;
               cmbBR_Procedure_PXSurgery.Name = GXCCtl;
               cmbBR_Procedure_PXSurgery.WebTags = "";
               cmbBR_Procedure_PXSurgery.addItem("否", "否", 0);
               cmbBR_Procedure_PXSurgery.addItem("是", "是", 0);
               cmbBR_Procedure_PXSurgery.addItem("不详", "不详", 0);
               if ( cmbBR_Procedure_PXSurgery.ItemCount > 0 )
               {
                  A141BR_Procedure_PXSurgery = cmbBR_Procedure_PXSurgery.getValidValue(A141BR_Procedure_PXSurgery);
                  n141BR_Procedure_PXSurgery = false;
               }
            }
            /* ComboBox */
            GridRow.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbBR_Procedure_PXSurgery,(String)cmbBR_Procedure_PXSurgery_Internalname,StringUtil.RTrim( A141BR_Procedure_PXSurgery),(short)1,(String)cmbBR_Procedure_PXSurgery_Jsonclick,(short)0,(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"svchar",(String)"",(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)"",(String)"Attribute",(String)"WWColumn hidden-xs",(String)"",(String)"",(String)"",(bool)true});
            cmbBR_Procedure_PXSurgery.CurrentValue = StringUtil.RTrim( A141BR_Procedure_PXSurgery);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Procedure_PXSurgery_Internalname, "Values", (String)(cmbBR_Procedure_PXSurgery.ToJavascriptSource()), !bGXsfl_28_Refreshing);
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Procedure_Date_Internalname,context.localUtil.Format(A266BR_Procedure_Date, "9999/99/99"),context.localUtil.Format( A266BR_Procedure_Date, "9999/99/99"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Procedure_Date_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)28,(short)1,(short)-1,(short)0,(bool)true,(String)"DM_Date",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            if ( ( cmbBR_Procedure_PXRadiotherapy.ItemCount == 0 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "BR_PROCEDURE_PXRADIOTHERAPY_" + sGXsfl_28_idx;
               cmbBR_Procedure_PXRadiotherapy.Name = GXCCtl;
               cmbBR_Procedure_PXRadiotherapy.WebTags = "";
               cmbBR_Procedure_PXRadiotherapy.addItem("否", "否", 0);
               cmbBR_Procedure_PXRadiotherapy.addItem("是", "是", 0);
               cmbBR_Procedure_PXRadiotherapy.addItem("不详", "不详", 0);
               if ( cmbBR_Procedure_PXRadiotherapy.ItemCount > 0 )
               {
                  A143BR_Procedure_PXRadiotherapy = cmbBR_Procedure_PXRadiotherapy.getValidValue(A143BR_Procedure_PXRadiotherapy);
                  n143BR_Procedure_PXRadiotherapy = false;
               }
            }
            /* ComboBox */
            GridRow.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbBR_Procedure_PXRadiotherapy,(String)cmbBR_Procedure_PXRadiotherapy_Internalname,StringUtil.RTrim( A143BR_Procedure_PXRadiotherapy),(short)1,(String)cmbBR_Procedure_PXRadiotherapy_Jsonclick,(short)0,(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"svchar",(String)"",(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)"",(String)"Attribute",(String)"WWColumn hidden-xs",(String)"",(String)"",(String)"",(bool)true});
            cmbBR_Procedure_PXRadiotherapy.CurrentValue = StringUtil.RTrim( A143BR_Procedure_PXRadiotherapy);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Procedure_PXRadiotherapy_Internalname, "Values", (String)(cmbBR_Procedure_PXRadiotherapy.ToJavascriptSource()), !bGXsfl_28_Refreshing);
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Procedure_RadioDate_Internalname,context.localUtil.Format(A268BR_Procedure_RadioDate, "9999/99/99"),context.localUtil.Format( A268BR_Procedure_RadioDate, "9999/99/99"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Procedure_RadioDate_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)28,(short)1,(short)-1,(short)0,(bool)true,(String)"DM_Date",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Procedure_RadioTime_Internalname,StringUtil.LTrim( StringUtil.NToC( A269BR_Procedure_RadioTime, 15, 5, ".", "")),context.localUtil.Format( A269BR_Procedure_RadioTime, "ZZZZZZZZZ.ZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Procedure_RadioTime_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)15,(short)0,(short)0,(short)28,(short)1,(short)-1,(short)0,(bool)true,(String)"DM_Numeric",(String)"right",(bool)false});
            send_integrity_lvl_hashes3O2( ) ;
            GridContainer.AddRow(GridRow);
            nGXsfl_28_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_28_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_28_idx+1));
            sGXsfl_28_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_28_idx), 4, 0)), 4, "0");
            SubsflControlProps_282( ) ;
         }
         /* End function sendrow_282 */
      }

      protected void init_web_controls( )
      {
         GXCCtl = "BR_PROCEDURE_PXSURGERY_" + sGXsfl_28_idx;
         cmbBR_Procedure_PXSurgery.Name = GXCCtl;
         cmbBR_Procedure_PXSurgery.WebTags = "";
         cmbBR_Procedure_PXSurgery.addItem("否", "否", 0);
         cmbBR_Procedure_PXSurgery.addItem("是", "是", 0);
         cmbBR_Procedure_PXSurgery.addItem("不详", "不详", 0);
         if ( cmbBR_Procedure_PXSurgery.ItemCount > 0 )
         {
            A141BR_Procedure_PXSurgery = cmbBR_Procedure_PXSurgery.getValidValue(A141BR_Procedure_PXSurgery);
            n141BR_Procedure_PXSurgery = false;
         }
         GXCCtl = "BR_PROCEDURE_PXRADIOTHERAPY_" + sGXsfl_28_idx;
         cmbBR_Procedure_PXRadiotherapy.Name = GXCCtl;
         cmbBR_Procedure_PXRadiotherapy.WebTags = "";
         cmbBR_Procedure_PXRadiotherapy.addItem("否", "否", 0);
         cmbBR_Procedure_PXRadiotherapy.addItem("是", "是", 0);
         cmbBR_Procedure_PXRadiotherapy.addItem("不详", "不详", 0);
         if ( cmbBR_Procedure_PXRadiotherapy.ItemCount > 0 )
         {
            A143BR_Procedure_PXRadiotherapy = cmbBR_Procedure_PXRadiotherapy.getValidValue(A143BR_Procedure_PXRadiotherapy);
            n143BR_Procedure_PXRadiotherapy = false;
         }
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         bttBtninsert_Internalname = "BTNINSERT";
         divTableactions_Internalname = "TABLEACTIONS";
         divTableheader_Internalname = "TABLEHEADER";
         divLayout_tableheader_Internalname = "LAYOUT_TABLEHEADER";
         Dvpanel_tableheader_Internalname = "DVPANEL_TABLEHEADER";
         divHtml_dvpanel_tableheader_Internalname = "HTML_DVPANEL_TABLEHEADER";
         edtavDisplay_Internalname = "vDISPLAY";
         edtavUpdate_Internalname = "vUPDATE";
         edtavDelete_Internalname = "vDELETE";
         edtBR_ProcedureID_Internalname = "BR_PROCEDUREID";
         edtBR_EncounterID_Internalname = "BR_ENCOUNTERID";
         edtBR_Information_PatientNo_Internalname = "BR_INFORMATION_PATIENTNO";
         edtBR_Procedure_PXID_Internalname = "BR_PROCEDURE_PXID";
         cmbBR_Procedure_PXSurgery_Internalname = "BR_PROCEDURE_PXSURGERY";
         edtBR_Procedure_Date_Internalname = "BR_PROCEDURE_DATE";
         cmbBR_Procedure_PXRadiotherapy_Internalname = "BR_PROCEDURE_PXRADIOTHERAPY";
         edtBR_Procedure_RadioDate_Internalname = "BR_PROCEDURE_RADIODATE";
         edtBR_Procedure_RadioTime_Internalname = "BR_PROCEDURE_RADIOTIME";
         Gridpaginationbar_Internalname = "GRIDPAGINATIONBAR";
         divHtml_gridpaginationbar_Internalname = "HTML_GRIDPAGINATIONBAR";
         divGridtablewithpaginationbar_Internalname = "GRIDTABLEWITHPAGINATIONBAR";
         divTablemain_Internalname = "TABLEMAIN";
         Ddo_br_procedureid_Internalname = "DDO_BR_PROCEDUREID";
         edtavDdo_br_procedureidtitlecontrolidtoreplace_Internalname = "vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE";
         Ddo_br_encounterid_Internalname = "DDO_BR_ENCOUNTERID";
         edtavDdo_br_encounteridtitlecontrolidtoreplace_Internalname = "vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE";
         Ddo_br_information_patientno_Internalname = "DDO_BR_INFORMATION_PATIENTNO";
         edtavDdo_br_information_patientnotitlecontrolidtoreplace_Internalname = "vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE";
         Ddo_br_procedure_pxid_Internalname = "DDO_BR_PROCEDURE_PXID";
         edtavDdo_br_procedure_pxidtitlecontrolidtoreplace_Internalname = "vDDO_BR_PROCEDURE_PXIDTITLECONTROLIDTOREPLACE";
         Ddo_br_procedure_pxsurgery_Internalname = "DDO_BR_PROCEDURE_PXSURGERY";
         edtavDdo_br_procedure_pxsurgerytitlecontrolidtoreplace_Internalname = "vDDO_BR_PROCEDURE_PXSURGERYTITLECONTROLIDTOREPLACE";
         Ddo_br_procedure_date_Internalname = "DDO_BR_PROCEDURE_DATE";
         edtavDdo_br_procedure_datetitlecontrolidtoreplace_Internalname = "vDDO_BR_PROCEDURE_DATETITLECONTROLIDTOREPLACE";
         Ddo_br_procedure_pxradiotherapy_Internalname = "DDO_BR_PROCEDURE_PXRADIOTHERAPY";
         edtavDdo_br_procedure_pxradiotherapytitlecontrolidtoreplace_Internalname = "vDDO_BR_PROCEDURE_PXRADIOTHERAPYTITLECONTROLIDTOREPLACE";
         Ddo_br_procedure_radiodate_Internalname = "DDO_BR_PROCEDURE_RADIODATE";
         edtavDdo_br_procedure_radiodatetitlecontrolidtoreplace_Internalname = "vDDO_BR_PROCEDURE_RADIODATETITLECONTROLIDTOREPLACE";
         Ddo_br_procedure_radiotime_Internalname = "DDO_BR_PROCEDURE_RADIOTIME";
         edtavDdo_br_procedure_radiotimetitlecontrolidtoreplace_Internalname = "vDDO_BR_PROCEDURE_RADIOTIMETITLECONTROLIDTOREPLACE";
         Workwithplusutilities1_Internalname = "WORKWITHPLUSUTILITIES1";
         edtavOrderedby_Internalname = "vORDEREDBY";
         edtavOrdereddsc_Internalname = "vORDEREDDSC";
         edtavTfbr_procedureid_Internalname = "vTFBR_PROCEDUREID";
         edtavTfbr_procedureid_to_Internalname = "vTFBR_PROCEDUREID_TO";
         edtavTfbr_encounterid_Internalname = "vTFBR_ENCOUNTERID";
         edtavTfbr_encounterid_to_Internalname = "vTFBR_ENCOUNTERID_TO";
         edtavTfbr_information_patientno_Internalname = "vTFBR_INFORMATION_PATIENTNO";
         edtavTfbr_information_patientno_sel_Internalname = "vTFBR_INFORMATION_PATIENTNO_SEL";
         edtavTfbr_procedure_pxid_Internalname = "vTFBR_PROCEDURE_PXID";
         edtavTfbr_procedure_pxid_to_Internalname = "vTFBR_PROCEDURE_PXID_TO";
         edtavTfbr_procedure_date_Internalname = "vTFBR_PROCEDURE_DATE";
         edtavTfbr_procedure_date_to_Internalname = "vTFBR_PROCEDURE_DATE_TO";
         edtavDdo_br_procedure_dateauxdate_Internalname = "vDDO_BR_PROCEDURE_DATEAUXDATE";
         edtavDdo_br_procedure_dateauxdateto_Internalname = "vDDO_BR_PROCEDURE_DATEAUXDATETO";
         divDdo_br_procedure_dateauxdates_Internalname = "DDO_BR_PROCEDURE_DATEAUXDATES";
         edtavTfbr_procedure_radiodate_Internalname = "vTFBR_PROCEDURE_RADIODATE";
         edtavTfbr_procedure_radiodate_to_Internalname = "vTFBR_PROCEDURE_RADIODATE_TO";
         edtavDdo_br_procedure_radiodateauxdate_Internalname = "vDDO_BR_PROCEDURE_RADIODATEAUXDATE";
         edtavDdo_br_procedure_radiodateauxdateto_Internalname = "vDDO_BR_PROCEDURE_RADIODATEAUXDATETO";
         divDdo_br_procedure_radiodateauxdates_Internalname = "DDO_BR_PROCEDURE_RADIODATEAUXDATES";
         edtavTfbr_procedure_radiotime_Internalname = "vTFBR_PROCEDURE_RADIOTIME";
         edtavTfbr_procedure_radiotime_to_Internalname = "vTFBR_PROCEDURE_RADIOTIME_TO";
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
         edtBR_Procedure_RadioTime_Jsonclick = "";
         edtBR_Procedure_RadioDate_Jsonclick = "";
         cmbBR_Procedure_PXRadiotherapy_Jsonclick = "";
         edtBR_Procedure_Date_Jsonclick = "";
         cmbBR_Procedure_PXSurgery_Jsonclick = "";
         edtBR_Procedure_PXID_Jsonclick = "";
         edtBR_Information_PatientNo_Jsonclick = "";
         edtBR_EncounterID_Jsonclick = "";
         edtBR_ProcedureID_Jsonclick = "";
         edtavTfbr_procedure_radiotime_to_Jsonclick = "";
         edtavTfbr_procedure_radiotime_to_Visible = 1;
         edtavTfbr_procedure_radiotime_Jsonclick = "";
         edtavTfbr_procedure_radiotime_Visible = 1;
         edtavDdo_br_procedure_radiodateauxdateto_Jsonclick = "";
         edtavDdo_br_procedure_radiodateauxdate_Jsonclick = "";
         edtavTfbr_procedure_radiodate_to_Jsonclick = "";
         edtavTfbr_procedure_radiodate_to_Visible = 1;
         edtavTfbr_procedure_radiodate_Jsonclick = "";
         edtavTfbr_procedure_radiodate_Visible = 1;
         edtavDdo_br_procedure_dateauxdateto_Jsonclick = "";
         edtavDdo_br_procedure_dateauxdate_Jsonclick = "";
         edtavTfbr_procedure_date_to_Jsonclick = "";
         edtavTfbr_procedure_date_to_Visible = 1;
         edtavTfbr_procedure_date_Jsonclick = "";
         edtavTfbr_procedure_date_Visible = 1;
         edtavTfbr_procedure_pxid_to_Jsonclick = "";
         edtavTfbr_procedure_pxid_to_Visible = 1;
         edtavTfbr_procedure_pxid_Jsonclick = "";
         edtavTfbr_procedure_pxid_Visible = 1;
         edtavTfbr_information_patientno_sel_Jsonclick = "";
         edtavTfbr_information_patientno_sel_Visible = 1;
         edtavTfbr_information_patientno_Jsonclick = "";
         edtavTfbr_information_patientno_Visible = 1;
         edtavTfbr_encounterid_to_Jsonclick = "";
         edtavTfbr_encounterid_to_Visible = 1;
         edtavTfbr_encounterid_Jsonclick = "";
         edtavTfbr_encounterid_Visible = 1;
         edtavTfbr_procedureid_to_Jsonclick = "";
         edtavTfbr_procedureid_to_Visible = 1;
         edtavTfbr_procedureid_Jsonclick = "";
         edtavTfbr_procedureid_Visible = 1;
         edtavOrdereddsc_Jsonclick = "";
         edtavOrdereddsc_Visible = 1;
         edtavOrderedby_Jsonclick = "";
         edtavOrderedby_Visible = 1;
         edtavDdo_br_procedure_radiotimetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_procedure_radiodatetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_procedure_pxradiotherapytitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_procedure_datetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_procedure_pxsurgerytitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_procedure_pxidtitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_information_patientnotitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_encounteridtitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_procedureidtitlecontrolidtoreplace_Visible = 1;
         subGrid_Allowcollapsing = 0;
         subGrid_Allowselection = 0;
         edtBR_Information_PatientNo_Link = "";
         edtavDelete_Tooltiptext = "删除";
         edtavDelete_Link = "";
         edtavUpdate_Tooltiptext = "修改";
         edtavUpdate_Link = "";
         edtavDisplay_Tooltiptext = "显示";
         edtavDisplay_Link = "";
         subGrid_Sortable = 0;
         subGrid_Header = "";
         edtBR_Procedure_RadioTime_Titleformat = 0;
         edtBR_Procedure_RadioTime_Title = "放疗疗程";
         edtBR_Procedure_RadioDate_Titleformat = 0;
         edtBR_Procedure_RadioDate_Title = "放疗日期";
         cmbBR_Procedure_PXRadiotherapy_Titleformat = 0;
         cmbBR_Procedure_PXRadiotherapy.Title.Text = "是否接受放射疗法";
         edtBR_Procedure_Date_Titleformat = 0;
         edtBR_Procedure_Date_Title = "手术日期";
         cmbBR_Procedure_PXSurgery_Titleformat = 0;
         cmbBR_Procedure_PXSurgery.Title.Text = "是否手术";
         edtBR_Procedure_PXID_Titleformat = 0;
         edtBR_Procedure_PXID_Title = "诊疗序号";
         edtBR_Information_PatientNo_Titleformat = 0;
         edtBR_Information_PatientNo_Title = "患者编号";
         edtBR_EncounterID_Titleformat = 0;
         edtBR_EncounterID_Title = "就诊信息主键";
         edtBR_ProcedureID_Titleformat = 0;
         edtBR_ProcedureID_Title = "诊疗处理主键";
         edtavDelete_Visible = -1;
         edtavUpdate_Visible = -1;
         subGrid_Class = "GridWithPaginationBar GridWithBorderColor WorkWith";
         subGrid_Backcolorstyle = 0;
         bttBtninsert_Visible = 1;
         Ddo_br_procedure_radiotime_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_procedure_radiotime_Rangefilterto = "WWP_TSTo";
         Ddo_br_procedure_radiotime_Rangefilterfrom = "WWP_TSFrom";
         Ddo_br_procedure_radiotime_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_procedure_radiotime_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_procedure_radiotime_Sortasc = "WWP_TSSortASC";
         Ddo_br_procedure_radiotime_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_procedure_radiotime_Filterisrange = Convert.ToBoolean( -1);
         Ddo_br_procedure_radiotime_Filtertype = "Numeric";
         Ddo_br_procedure_radiotime_Includefilter = Convert.ToBoolean( -1);
         Ddo_br_procedure_radiotime_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_procedure_radiotime_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_procedure_radiotime_Titlecontrolidtoreplace = "";
         Ddo_br_procedure_radiotime_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_procedure_radiotime_Cls = "ColumnSettings";
         Ddo_br_procedure_radiotime_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_procedure_radiotime_Caption = "";
         Ddo_br_procedure_radiodate_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_procedure_radiodate_Rangefilterto = "WWP_TSTo";
         Ddo_br_procedure_radiodate_Rangefilterfrom = "WWP_TSFrom";
         Ddo_br_procedure_radiodate_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_procedure_radiodate_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_procedure_radiodate_Sortasc = "WWP_TSSortASC";
         Ddo_br_procedure_radiodate_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_procedure_radiodate_Filterisrange = Convert.ToBoolean( -1);
         Ddo_br_procedure_radiodate_Filtertype = "Date";
         Ddo_br_procedure_radiodate_Includefilter = Convert.ToBoolean( -1);
         Ddo_br_procedure_radiodate_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_procedure_radiodate_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_procedure_radiodate_Titlecontrolidtoreplace = "";
         Ddo_br_procedure_radiodate_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_procedure_radiodate_Cls = "ColumnSettings";
         Ddo_br_procedure_radiodate_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_procedure_radiodate_Caption = "";
         Ddo_br_procedure_pxradiotherapy_Searchbuttontext = "WWP_FilterSelected";
         Ddo_br_procedure_pxradiotherapy_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_procedure_pxradiotherapy_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_procedure_pxradiotherapy_Sortasc = "WWP_TSSortASC";
         Ddo_br_procedure_pxradiotherapy_Datalistfixedvalues = "否:否,是:是,不详:不详";
         Ddo_br_procedure_pxradiotherapy_Allowmultipleselection = Convert.ToBoolean( -1);
         Ddo_br_procedure_pxradiotherapy_Datalisttype = "FixedValues";
         Ddo_br_procedure_pxradiotherapy_Includedatalist = Convert.ToBoolean( -1);
         Ddo_br_procedure_pxradiotherapy_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_procedure_pxradiotherapy_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_procedure_pxradiotherapy_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_procedure_pxradiotherapy_Titlecontrolidtoreplace = "";
         Ddo_br_procedure_pxradiotherapy_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_procedure_pxradiotherapy_Cls = "ColumnSettings";
         Ddo_br_procedure_pxradiotherapy_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_procedure_pxradiotherapy_Caption = "";
         Ddo_br_procedure_date_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_procedure_date_Rangefilterto = "WWP_TSTo";
         Ddo_br_procedure_date_Rangefilterfrom = "WWP_TSFrom";
         Ddo_br_procedure_date_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_procedure_date_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_procedure_date_Sortasc = "WWP_TSSortASC";
         Ddo_br_procedure_date_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_procedure_date_Filterisrange = Convert.ToBoolean( -1);
         Ddo_br_procedure_date_Filtertype = "Date";
         Ddo_br_procedure_date_Includefilter = Convert.ToBoolean( -1);
         Ddo_br_procedure_date_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_procedure_date_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_procedure_date_Titlecontrolidtoreplace = "";
         Ddo_br_procedure_date_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_procedure_date_Cls = "ColumnSettings";
         Ddo_br_procedure_date_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_procedure_date_Caption = "";
         Ddo_br_procedure_pxsurgery_Searchbuttontext = "WWP_FilterSelected";
         Ddo_br_procedure_pxsurgery_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_procedure_pxsurgery_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_procedure_pxsurgery_Sortasc = "WWP_TSSortASC";
         Ddo_br_procedure_pxsurgery_Datalistfixedvalues = "否:否,是:是,不详:不详";
         Ddo_br_procedure_pxsurgery_Allowmultipleselection = Convert.ToBoolean( -1);
         Ddo_br_procedure_pxsurgery_Datalisttype = "FixedValues";
         Ddo_br_procedure_pxsurgery_Includedatalist = Convert.ToBoolean( -1);
         Ddo_br_procedure_pxsurgery_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_procedure_pxsurgery_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_procedure_pxsurgery_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_procedure_pxsurgery_Titlecontrolidtoreplace = "";
         Ddo_br_procedure_pxsurgery_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_procedure_pxsurgery_Cls = "ColumnSettings";
         Ddo_br_procedure_pxsurgery_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_procedure_pxsurgery_Caption = "";
         Ddo_br_procedure_pxid_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_procedure_pxid_Rangefilterto = "WWP_TSTo";
         Ddo_br_procedure_pxid_Rangefilterfrom = "WWP_TSFrom";
         Ddo_br_procedure_pxid_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_procedure_pxid_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_procedure_pxid_Sortasc = "WWP_TSSortASC";
         Ddo_br_procedure_pxid_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_procedure_pxid_Filterisrange = Convert.ToBoolean( -1);
         Ddo_br_procedure_pxid_Filtertype = "Numeric";
         Ddo_br_procedure_pxid_Includefilter = Convert.ToBoolean( -1);
         Ddo_br_procedure_pxid_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_procedure_pxid_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_procedure_pxid_Titlecontrolidtoreplace = "";
         Ddo_br_procedure_pxid_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_procedure_pxid_Cls = "ColumnSettings";
         Ddo_br_procedure_pxid_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_procedure_pxid_Caption = "";
         Ddo_br_information_patientno_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_information_patientno_Noresultsfound = "WWP_TSNoResults";
         Ddo_br_information_patientno_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_information_patientno_Loadingdata = "WWP_TSLoading";
         Ddo_br_information_patientno_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_information_patientno_Sortasc = "WWP_TSSortASC";
         Ddo_br_information_patientno_Datalistupdateminimumcharacters = 0;
         Ddo_br_information_patientno_Datalistproc = "BR_ProcedureWWGetFilterData";
         Ddo_br_information_patientno_Datalisttype = "Dynamic";
         Ddo_br_information_patientno_Includedatalist = Convert.ToBoolean( -1);
         Ddo_br_information_patientno_Filterisrange = Convert.ToBoolean( 0);
         Ddo_br_information_patientno_Filtertype = "Character";
         Ddo_br_information_patientno_Includefilter = Convert.ToBoolean( -1);
         Ddo_br_information_patientno_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_information_patientno_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_information_patientno_Titlecontrolidtoreplace = "";
         Ddo_br_information_patientno_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_information_patientno_Cls = "ColumnSettings";
         Ddo_br_information_patientno_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_information_patientno_Caption = "";
         Ddo_br_encounterid_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_encounterid_Rangefilterto = "WWP_TSTo";
         Ddo_br_encounterid_Rangefilterfrom = "WWP_TSFrom";
         Ddo_br_encounterid_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_encounterid_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_encounterid_Sortasc = "WWP_TSSortASC";
         Ddo_br_encounterid_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_encounterid_Filterisrange = Convert.ToBoolean( -1);
         Ddo_br_encounterid_Filtertype = "Numeric";
         Ddo_br_encounterid_Includefilter = Convert.ToBoolean( -1);
         Ddo_br_encounterid_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_encounterid_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_encounterid_Titlecontrolidtoreplace = "";
         Ddo_br_encounterid_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_encounterid_Cls = "ColumnSettings";
         Ddo_br_encounterid_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_encounterid_Caption = "";
         Ddo_br_procedureid_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_procedureid_Rangefilterto = "WWP_TSTo";
         Ddo_br_procedureid_Rangefilterfrom = "WWP_TSFrom";
         Ddo_br_procedureid_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_procedureid_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_procedureid_Sortasc = "WWP_TSSortASC";
         Ddo_br_procedureid_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_procedureid_Filterisrange = Convert.ToBoolean( -1);
         Ddo_br_procedureid_Filtertype = "Numeric";
         Ddo_br_procedureid_Includefilter = Convert.ToBoolean( -1);
         Ddo_br_procedureid_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_procedureid_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_procedureid_Titlecontrolidtoreplace = "";
         Ddo_br_procedureid_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_procedureid_Cls = "ColumnSettings";
         Ddo_br_procedureid_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_procedureid_Caption = "";
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
         Form.Caption = " 诊疗处理";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV75IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV77IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV17ddo_BR_ProcedureIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_BR_Procedure_PXIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXSURGERYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV87ddo_BR_Procedure_DateTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_DATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXRADIOTHERAPYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV97ddo_BR_Procedure_RadioDateTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIODATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV101ddo_BR_Procedure_RadioTimeTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIOTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV80TFBR_ProcedureID',fld:'vTFBR_PROCEDUREID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV81TFBR_ProcedureID_To',fld:'vTFBR_PROCEDUREID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV19TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV20TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV23TFBR_Information_PatientNo',fld:'vTFBR_INFORMATION_PATIENTNO',pic:''},{av:'AV24TFBR_Information_PatientNo_Sel',fld:'vTFBR_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV27TFBR_Procedure_PXID',fld:'vTFBR_PROCEDURE_PXID',pic:'ZZZZZZZZZZ'},{av:'AV28TFBR_Procedure_PXID_To',fld:'vTFBR_PROCEDURE_PXID_TO',pic:'ZZZZZZZZZZ'},{av:'AV32TFBR_Procedure_PXSurgery_Sels',fld:'vTFBR_PROCEDURE_PXSURGERY_SELS',pic:''},{av:'AV83TFBR_Procedure_Date',fld:'vTFBR_PROCEDURE_DATE',pic:''},{av:'AV84TFBR_Procedure_Date_To',fld:'vTFBR_PROCEDURE_DATE_TO',pic:''},{av:'AV40TFBR_Procedure_PXRadiotherapy_Sels',fld:'vTFBR_PROCEDURE_PXRADIOTHERAPY_SELS',pic:''},{av:'AV93TFBR_Procedure_RadioDate',fld:'vTFBR_PROCEDURE_RADIODATE',pic:''},{av:'AV94TFBR_Procedure_RadioDate_To',fld:'vTFBR_PROCEDURE_RADIODATE_TO',pic:''},{av:'AV99TFBR_Procedure_RadioTime',fld:'vTFBR_PROCEDURE_RADIOTIME',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV100TFBR_Procedure_RadioTime_To',fld:'vTFBR_PROCEDURE_RADIOTIME_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV124Pgmname',fld:'vPGMNAME',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV78IsAuthorized_BR_Information_PatientNo',fld:'vISAUTHORIZED_BR_INFORMATION_PATIENTNO',pic:'',hsh:true}]");
         setEventMetadata("REFRESH",",oparms:[{av:'AV16BR_ProcedureIDTitleFilterData',fld:'vBR_PROCEDUREIDTITLEFILTERDATA',pic:''},{av:'AV18BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV22BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV26BR_Procedure_PXIDTitleFilterData',fld:'vBR_PROCEDURE_PXIDTITLEFILTERDATA',pic:''},{av:'AV30BR_Procedure_PXSurgeryTitleFilterData',fld:'vBR_PROCEDURE_PXSURGERYTITLEFILTERDATA',pic:''},{av:'AV82BR_Procedure_DateTitleFilterData',fld:'vBR_PROCEDURE_DATETITLEFILTERDATA',pic:''},{av:'AV38BR_Procedure_PXRadiotherapyTitleFilterData',fld:'vBR_PROCEDURE_PXRADIOTHERAPYTITLEFILTERDATA',pic:''},{av:'AV92BR_Procedure_RadioDateTitleFilterData',fld:'vBR_PROCEDURE_RADIODATETITLEFILTERDATA',pic:''},{av:'AV98BR_Procedure_RadioTimeTitleFilterData',fld:'vBR_PROCEDURE_RADIOTIMETITLEFILTERDATA',pic:''},{av:'edtBR_ProcedureID_Titleformat',ctrl:'BR_PROCEDUREID',prop:'Titleformat'},{av:'edtBR_ProcedureID_Title',ctrl:'BR_PROCEDUREID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Procedure_PXID_Titleformat',ctrl:'BR_PROCEDURE_PXID',prop:'Titleformat'},{av:'edtBR_Procedure_PXID_Title',ctrl:'BR_PROCEDURE_PXID',prop:'Title'},{av:'cmbBR_Procedure_PXSurgery'},{av:'edtBR_Procedure_Date_Titleformat',ctrl:'BR_PROCEDURE_DATE',prop:'Titleformat'},{av:'edtBR_Procedure_Date_Title',ctrl:'BR_PROCEDURE_DATE',prop:'Title'},{av:'cmbBR_Procedure_PXRadiotherapy'},{av:'edtBR_Procedure_RadioDate_Titleformat',ctrl:'BR_PROCEDURE_RADIODATE',prop:'Titleformat'},{av:'edtBR_Procedure_RadioDate_Title',ctrl:'BR_PROCEDURE_RADIODATE',prop:'Title'},{av:'edtBR_Procedure_RadioTime_Titleformat',ctrl:'BR_PROCEDURE_RADIOTIME',prop:'Titleformat'},{av:'edtBR_Procedure_RadioTime_Title',ctrl:'BR_PROCEDURE_RADIOTIME',prop:'Title'},{av:'AV70GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV71GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV72GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV75IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV77IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE","{handler:'E113O2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV80TFBR_ProcedureID',fld:'vTFBR_PROCEDUREID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV81TFBR_ProcedureID_To',fld:'vTFBR_PROCEDUREID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV19TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV20TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV23TFBR_Information_PatientNo',fld:'vTFBR_INFORMATION_PATIENTNO',pic:''},{av:'AV24TFBR_Information_PatientNo_Sel',fld:'vTFBR_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV27TFBR_Procedure_PXID',fld:'vTFBR_PROCEDURE_PXID',pic:'ZZZZZZZZZZ'},{av:'AV28TFBR_Procedure_PXID_To',fld:'vTFBR_PROCEDURE_PXID_TO',pic:'ZZZZZZZZZZ'},{av:'AV83TFBR_Procedure_Date',fld:'vTFBR_PROCEDURE_DATE',pic:''},{av:'AV84TFBR_Procedure_Date_To',fld:'vTFBR_PROCEDURE_DATE_TO',pic:''},{av:'AV93TFBR_Procedure_RadioDate',fld:'vTFBR_PROCEDURE_RADIODATE',pic:''},{av:'AV94TFBR_Procedure_RadioDate_To',fld:'vTFBR_PROCEDURE_RADIODATE_TO',pic:''},{av:'AV99TFBR_Procedure_RadioTime',fld:'vTFBR_PROCEDURE_RADIOTIME',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV100TFBR_Procedure_RadioTime_To',fld:'vTFBR_PROCEDURE_RADIOTIME_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV17ddo_BR_ProcedureIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_BR_Procedure_PXIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXSURGERYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV87ddo_BR_Procedure_DateTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_DATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXRADIOTHERAPYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV97ddo_BR_Procedure_RadioDateTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIODATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV101ddo_BR_Procedure_RadioTimeTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIOTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV32TFBR_Procedure_PXSurgery_Sels',fld:'vTFBR_PROCEDURE_PXSURGERY_SELS',pic:''},{av:'AV40TFBR_Procedure_PXRadiotherapy_Sels',fld:'vTFBR_PROCEDURE_PXRADIOTHERAPY_SELS',pic:''},{av:'AV124Pgmname',fld:'vPGMNAME',pic:''},{av:'AV75IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV77IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV78IsAuthorized_BR_Information_PatientNo',fld:'vISAUTHORIZED_BR_INFORMATION_PATIENTNO',pic:'',hsh:true},{av:'Gridpaginationbar_Selectedpage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE",",oparms:[]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE","{handler:'E123O2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV80TFBR_ProcedureID',fld:'vTFBR_PROCEDUREID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV81TFBR_ProcedureID_To',fld:'vTFBR_PROCEDUREID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV19TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV20TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV23TFBR_Information_PatientNo',fld:'vTFBR_INFORMATION_PATIENTNO',pic:''},{av:'AV24TFBR_Information_PatientNo_Sel',fld:'vTFBR_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV27TFBR_Procedure_PXID',fld:'vTFBR_PROCEDURE_PXID',pic:'ZZZZZZZZZZ'},{av:'AV28TFBR_Procedure_PXID_To',fld:'vTFBR_PROCEDURE_PXID_TO',pic:'ZZZZZZZZZZ'},{av:'AV83TFBR_Procedure_Date',fld:'vTFBR_PROCEDURE_DATE',pic:''},{av:'AV84TFBR_Procedure_Date_To',fld:'vTFBR_PROCEDURE_DATE_TO',pic:''},{av:'AV93TFBR_Procedure_RadioDate',fld:'vTFBR_PROCEDURE_RADIODATE',pic:''},{av:'AV94TFBR_Procedure_RadioDate_To',fld:'vTFBR_PROCEDURE_RADIODATE_TO',pic:''},{av:'AV99TFBR_Procedure_RadioTime',fld:'vTFBR_PROCEDURE_RADIOTIME',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV100TFBR_Procedure_RadioTime_To',fld:'vTFBR_PROCEDURE_RADIOTIME_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV17ddo_BR_ProcedureIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_BR_Procedure_PXIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXSURGERYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV87ddo_BR_Procedure_DateTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_DATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXRADIOTHERAPYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV97ddo_BR_Procedure_RadioDateTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIODATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV101ddo_BR_Procedure_RadioTimeTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIOTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV32TFBR_Procedure_PXSurgery_Sels',fld:'vTFBR_PROCEDURE_PXSURGERY_SELS',pic:''},{av:'AV40TFBR_Procedure_PXRadiotherapy_Sels',fld:'vTFBR_PROCEDURE_PXRADIOTHERAPY_SELS',pic:''},{av:'AV124Pgmname',fld:'vPGMNAME',pic:''},{av:'AV75IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV77IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV78IsAuthorized_BR_Information_PatientNo',fld:'vISAUTHORIZED_BR_INFORMATION_PATIENTNO',pic:'',hsh:true},{av:'Gridpaginationbar_Rowsperpageselectedvalue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE",",oparms:[{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]}");
         setEventMetadata("DDO_BR_PROCEDUREID.ONOPTIONCLICKED","{handler:'E133O2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV80TFBR_ProcedureID',fld:'vTFBR_PROCEDUREID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV81TFBR_ProcedureID_To',fld:'vTFBR_PROCEDUREID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV19TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV20TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV23TFBR_Information_PatientNo',fld:'vTFBR_INFORMATION_PATIENTNO',pic:''},{av:'AV24TFBR_Information_PatientNo_Sel',fld:'vTFBR_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV27TFBR_Procedure_PXID',fld:'vTFBR_PROCEDURE_PXID',pic:'ZZZZZZZZZZ'},{av:'AV28TFBR_Procedure_PXID_To',fld:'vTFBR_PROCEDURE_PXID_TO',pic:'ZZZZZZZZZZ'},{av:'AV83TFBR_Procedure_Date',fld:'vTFBR_PROCEDURE_DATE',pic:''},{av:'AV84TFBR_Procedure_Date_To',fld:'vTFBR_PROCEDURE_DATE_TO',pic:''},{av:'AV93TFBR_Procedure_RadioDate',fld:'vTFBR_PROCEDURE_RADIODATE',pic:''},{av:'AV94TFBR_Procedure_RadioDate_To',fld:'vTFBR_PROCEDURE_RADIODATE_TO',pic:''},{av:'AV99TFBR_Procedure_RadioTime',fld:'vTFBR_PROCEDURE_RADIOTIME',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV100TFBR_Procedure_RadioTime_To',fld:'vTFBR_PROCEDURE_RADIOTIME_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV17ddo_BR_ProcedureIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_BR_Procedure_PXIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXSURGERYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV87ddo_BR_Procedure_DateTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_DATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXRADIOTHERAPYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV97ddo_BR_Procedure_RadioDateTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIODATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV101ddo_BR_Procedure_RadioTimeTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIOTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV32TFBR_Procedure_PXSurgery_Sels',fld:'vTFBR_PROCEDURE_PXSURGERY_SELS',pic:''},{av:'AV40TFBR_Procedure_PXRadiotherapy_Sels',fld:'vTFBR_PROCEDURE_PXRADIOTHERAPY_SELS',pic:''},{av:'AV124Pgmname',fld:'vPGMNAME',pic:''},{av:'AV75IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV77IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV78IsAuthorized_BR_Information_PatientNo',fld:'vISAUTHORIZED_BR_INFORMATION_PATIENTNO',pic:'',hsh:true},{av:'Ddo_br_procedureid_Activeeventkey',ctrl:'DDO_BR_PROCEDUREID',prop:'ActiveEventKey'},{av:'Ddo_br_procedureid_Filteredtext_get',ctrl:'DDO_BR_PROCEDUREID',prop:'FilteredText_get'},{av:'Ddo_br_procedureid_Filteredtextto_get',ctrl:'DDO_BR_PROCEDUREID',prop:'FilteredTextTo_get'}]");
         setEventMetadata("DDO_BR_PROCEDUREID.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_procedureid_Sortedstatus',ctrl:'DDO_BR_PROCEDUREID',prop:'SortedStatus'},{av:'AV80TFBR_ProcedureID',fld:'vTFBR_PROCEDUREID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV81TFBR_ProcedureID_To',fld:'vTFBR_PROCEDUREID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'Ddo_br_encounterid_Sortedstatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'Ddo_br_information_patientno_Sortedstatus',ctrl:'DDO_BR_INFORMATION_PATIENTNO',prop:'SortedStatus'},{av:'Ddo_br_procedure_pxid_Sortedstatus',ctrl:'DDO_BR_PROCEDURE_PXID',prop:'SortedStatus'},{av:'Ddo_br_procedure_pxsurgery_Sortedstatus',ctrl:'DDO_BR_PROCEDURE_PXSURGERY',prop:'SortedStatus'},{av:'Ddo_br_procedure_date_Sortedstatus',ctrl:'DDO_BR_PROCEDURE_DATE',prop:'SortedStatus'},{av:'Ddo_br_procedure_pxradiotherapy_Sortedstatus',ctrl:'DDO_BR_PROCEDURE_PXRADIOTHERAPY',prop:'SortedStatus'},{av:'Ddo_br_procedure_radiodate_Sortedstatus',ctrl:'DDO_BR_PROCEDURE_RADIODATE',prop:'SortedStatus'},{av:'Ddo_br_procedure_radiotime_Sortedstatus',ctrl:'DDO_BR_PROCEDURE_RADIOTIME',prop:'SortedStatus'},{av:'AV16BR_ProcedureIDTitleFilterData',fld:'vBR_PROCEDUREIDTITLEFILTERDATA',pic:''},{av:'AV18BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV22BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV26BR_Procedure_PXIDTitleFilterData',fld:'vBR_PROCEDURE_PXIDTITLEFILTERDATA',pic:''},{av:'AV30BR_Procedure_PXSurgeryTitleFilterData',fld:'vBR_PROCEDURE_PXSURGERYTITLEFILTERDATA',pic:''},{av:'AV82BR_Procedure_DateTitleFilterData',fld:'vBR_PROCEDURE_DATETITLEFILTERDATA',pic:''},{av:'AV38BR_Procedure_PXRadiotherapyTitleFilterData',fld:'vBR_PROCEDURE_PXRADIOTHERAPYTITLEFILTERDATA',pic:''},{av:'AV92BR_Procedure_RadioDateTitleFilterData',fld:'vBR_PROCEDURE_RADIODATETITLEFILTERDATA',pic:''},{av:'AV98BR_Procedure_RadioTimeTitleFilterData',fld:'vBR_PROCEDURE_RADIOTIMETITLEFILTERDATA',pic:''},{av:'edtBR_ProcedureID_Titleformat',ctrl:'BR_PROCEDUREID',prop:'Titleformat'},{av:'edtBR_ProcedureID_Title',ctrl:'BR_PROCEDUREID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Procedure_PXID_Titleformat',ctrl:'BR_PROCEDURE_PXID',prop:'Titleformat'},{av:'edtBR_Procedure_PXID_Title',ctrl:'BR_PROCEDURE_PXID',prop:'Title'},{av:'cmbBR_Procedure_PXSurgery'},{av:'edtBR_Procedure_Date_Titleformat',ctrl:'BR_PROCEDURE_DATE',prop:'Titleformat'},{av:'edtBR_Procedure_Date_Title',ctrl:'BR_PROCEDURE_DATE',prop:'Title'},{av:'cmbBR_Procedure_PXRadiotherapy'},{av:'edtBR_Procedure_RadioDate_Titleformat',ctrl:'BR_PROCEDURE_RADIODATE',prop:'Titleformat'},{av:'edtBR_Procedure_RadioDate_Title',ctrl:'BR_PROCEDURE_RADIODATE',prop:'Title'},{av:'edtBR_Procedure_RadioTime_Titleformat',ctrl:'BR_PROCEDURE_RADIOTIME',prop:'Titleformat'},{av:'edtBR_Procedure_RadioTime_Title',ctrl:'BR_PROCEDURE_RADIOTIME',prop:'Title'},{av:'AV70GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV71GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV72GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV75IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV77IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_ENCOUNTERID.ONOPTIONCLICKED","{handler:'E143O2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV80TFBR_ProcedureID',fld:'vTFBR_PROCEDUREID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV81TFBR_ProcedureID_To',fld:'vTFBR_PROCEDUREID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV19TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV20TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV23TFBR_Information_PatientNo',fld:'vTFBR_INFORMATION_PATIENTNO',pic:''},{av:'AV24TFBR_Information_PatientNo_Sel',fld:'vTFBR_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV27TFBR_Procedure_PXID',fld:'vTFBR_PROCEDURE_PXID',pic:'ZZZZZZZZZZ'},{av:'AV28TFBR_Procedure_PXID_To',fld:'vTFBR_PROCEDURE_PXID_TO',pic:'ZZZZZZZZZZ'},{av:'AV83TFBR_Procedure_Date',fld:'vTFBR_PROCEDURE_DATE',pic:''},{av:'AV84TFBR_Procedure_Date_To',fld:'vTFBR_PROCEDURE_DATE_TO',pic:''},{av:'AV93TFBR_Procedure_RadioDate',fld:'vTFBR_PROCEDURE_RADIODATE',pic:''},{av:'AV94TFBR_Procedure_RadioDate_To',fld:'vTFBR_PROCEDURE_RADIODATE_TO',pic:''},{av:'AV99TFBR_Procedure_RadioTime',fld:'vTFBR_PROCEDURE_RADIOTIME',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV100TFBR_Procedure_RadioTime_To',fld:'vTFBR_PROCEDURE_RADIOTIME_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV17ddo_BR_ProcedureIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_BR_Procedure_PXIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXSURGERYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV87ddo_BR_Procedure_DateTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_DATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXRADIOTHERAPYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV97ddo_BR_Procedure_RadioDateTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIODATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV101ddo_BR_Procedure_RadioTimeTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIOTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV32TFBR_Procedure_PXSurgery_Sels',fld:'vTFBR_PROCEDURE_PXSURGERY_SELS',pic:''},{av:'AV40TFBR_Procedure_PXRadiotherapy_Sels',fld:'vTFBR_PROCEDURE_PXRADIOTHERAPY_SELS',pic:''},{av:'AV124Pgmname',fld:'vPGMNAME',pic:''},{av:'AV75IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV77IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV78IsAuthorized_BR_Information_PatientNo',fld:'vISAUTHORIZED_BR_INFORMATION_PATIENTNO',pic:'',hsh:true},{av:'Ddo_br_encounterid_Activeeventkey',ctrl:'DDO_BR_ENCOUNTERID',prop:'ActiveEventKey'},{av:'Ddo_br_encounterid_Filteredtext_get',ctrl:'DDO_BR_ENCOUNTERID',prop:'FilteredText_get'},{av:'Ddo_br_encounterid_Filteredtextto_get',ctrl:'DDO_BR_ENCOUNTERID',prop:'FilteredTextTo_get'}]");
         setEventMetadata("DDO_BR_ENCOUNTERID.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_encounterid_Sortedstatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'AV19TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV20TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'Ddo_br_procedureid_Sortedstatus',ctrl:'DDO_BR_PROCEDUREID',prop:'SortedStatus'},{av:'Ddo_br_information_patientno_Sortedstatus',ctrl:'DDO_BR_INFORMATION_PATIENTNO',prop:'SortedStatus'},{av:'Ddo_br_procedure_pxid_Sortedstatus',ctrl:'DDO_BR_PROCEDURE_PXID',prop:'SortedStatus'},{av:'Ddo_br_procedure_pxsurgery_Sortedstatus',ctrl:'DDO_BR_PROCEDURE_PXSURGERY',prop:'SortedStatus'},{av:'Ddo_br_procedure_date_Sortedstatus',ctrl:'DDO_BR_PROCEDURE_DATE',prop:'SortedStatus'},{av:'Ddo_br_procedure_pxradiotherapy_Sortedstatus',ctrl:'DDO_BR_PROCEDURE_PXRADIOTHERAPY',prop:'SortedStatus'},{av:'Ddo_br_procedure_radiodate_Sortedstatus',ctrl:'DDO_BR_PROCEDURE_RADIODATE',prop:'SortedStatus'},{av:'Ddo_br_procedure_radiotime_Sortedstatus',ctrl:'DDO_BR_PROCEDURE_RADIOTIME',prop:'SortedStatus'},{av:'AV16BR_ProcedureIDTitleFilterData',fld:'vBR_PROCEDUREIDTITLEFILTERDATA',pic:''},{av:'AV18BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV22BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV26BR_Procedure_PXIDTitleFilterData',fld:'vBR_PROCEDURE_PXIDTITLEFILTERDATA',pic:''},{av:'AV30BR_Procedure_PXSurgeryTitleFilterData',fld:'vBR_PROCEDURE_PXSURGERYTITLEFILTERDATA',pic:''},{av:'AV82BR_Procedure_DateTitleFilterData',fld:'vBR_PROCEDURE_DATETITLEFILTERDATA',pic:''},{av:'AV38BR_Procedure_PXRadiotherapyTitleFilterData',fld:'vBR_PROCEDURE_PXRADIOTHERAPYTITLEFILTERDATA',pic:''},{av:'AV92BR_Procedure_RadioDateTitleFilterData',fld:'vBR_PROCEDURE_RADIODATETITLEFILTERDATA',pic:''},{av:'AV98BR_Procedure_RadioTimeTitleFilterData',fld:'vBR_PROCEDURE_RADIOTIMETITLEFILTERDATA',pic:''},{av:'edtBR_ProcedureID_Titleformat',ctrl:'BR_PROCEDUREID',prop:'Titleformat'},{av:'edtBR_ProcedureID_Title',ctrl:'BR_PROCEDUREID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Procedure_PXID_Titleformat',ctrl:'BR_PROCEDURE_PXID',prop:'Titleformat'},{av:'edtBR_Procedure_PXID_Title',ctrl:'BR_PROCEDURE_PXID',prop:'Title'},{av:'cmbBR_Procedure_PXSurgery'},{av:'edtBR_Procedure_Date_Titleformat',ctrl:'BR_PROCEDURE_DATE',prop:'Titleformat'},{av:'edtBR_Procedure_Date_Title',ctrl:'BR_PROCEDURE_DATE',prop:'Title'},{av:'cmbBR_Procedure_PXRadiotherapy'},{av:'edtBR_Procedure_RadioDate_Titleformat',ctrl:'BR_PROCEDURE_RADIODATE',prop:'Titleformat'},{av:'edtBR_Procedure_RadioDate_Title',ctrl:'BR_PROCEDURE_RADIODATE',prop:'Title'},{av:'edtBR_Procedure_RadioTime_Titleformat',ctrl:'BR_PROCEDURE_RADIOTIME',prop:'Titleformat'},{av:'edtBR_Procedure_RadioTime_Title',ctrl:'BR_PROCEDURE_RADIOTIME',prop:'Title'},{av:'AV70GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV71GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV72GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV75IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV77IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_INFORMATION_PATIENTNO.ONOPTIONCLICKED","{handler:'E153O2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV80TFBR_ProcedureID',fld:'vTFBR_PROCEDUREID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV81TFBR_ProcedureID_To',fld:'vTFBR_PROCEDUREID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV19TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV20TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV23TFBR_Information_PatientNo',fld:'vTFBR_INFORMATION_PATIENTNO',pic:''},{av:'AV24TFBR_Information_PatientNo_Sel',fld:'vTFBR_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV27TFBR_Procedure_PXID',fld:'vTFBR_PROCEDURE_PXID',pic:'ZZZZZZZZZZ'},{av:'AV28TFBR_Procedure_PXID_To',fld:'vTFBR_PROCEDURE_PXID_TO',pic:'ZZZZZZZZZZ'},{av:'AV83TFBR_Procedure_Date',fld:'vTFBR_PROCEDURE_DATE',pic:''},{av:'AV84TFBR_Procedure_Date_To',fld:'vTFBR_PROCEDURE_DATE_TO',pic:''},{av:'AV93TFBR_Procedure_RadioDate',fld:'vTFBR_PROCEDURE_RADIODATE',pic:''},{av:'AV94TFBR_Procedure_RadioDate_To',fld:'vTFBR_PROCEDURE_RADIODATE_TO',pic:''},{av:'AV99TFBR_Procedure_RadioTime',fld:'vTFBR_PROCEDURE_RADIOTIME',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV100TFBR_Procedure_RadioTime_To',fld:'vTFBR_PROCEDURE_RADIOTIME_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV17ddo_BR_ProcedureIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_BR_Procedure_PXIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXSURGERYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV87ddo_BR_Procedure_DateTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_DATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXRADIOTHERAPYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV97ddo_BR_Procedure_RadioDateTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIODATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV101ddo_BR_Procedure_RadioTimeTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIOTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV32TFBR_Procedure_PXSurgery_Sels',fld:'vTFBR_PROCEDURE_PXSURGERY_SELS',pic:''},{av:'AV40TFBR_Procedure_PXRadiotherapy_Sels',fld:'vTFBR_PROCEDURE_PXRADIOTHERAPY_SELS',pic:''},{av:'AV124Pgmname',fld:'vPGMNAME',pic:''},{av:'AV75IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV77IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV78IsAuthorized_BR_Information_PatientNo',fld:'vISAUTHORIZED_BR_INFORMATION_PATIENTNO',pic:'',hsh:true},{av:'Ddo_br_information_patientno_Activeeventkey',ctrl:'DDO_BR_INFORMATION_PATIENTNO',prop:'ActiveEventKey'},{av:'Ddo_br_information_patientno_Filteredtext_get',ctrl:'DDO_BR_INFORMATION_PATIENTNO',prop:'FilteredText_get'},{av:'Ddo_br_information_patientno_Selectedvalue_get',ctrl:'DDO_BR_INFORMATION_PATIENTNO',prop:'SelectedValue_get'}]");
         setEventMetadata("DDO_BR_INFORMATION_PATIENTNO.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_information_patientno_Sortedstatus',ctrl:'DDO_BR_INFORMATION_PATIENTNO',prop:'SortedStatus'},{av:'AV23TFBR_Information_PatientNo',fld:'vTFBR_INFORMATION_PATIENTNO',pic:''},{av:'AV24TFBR_Information_PatientNo_Sel',fld:'vTFBR_INFORMATION_PATIENTNO_SEL',pic:''},{av:'Ddo_br_procedureid_Sortedstatus',ctrl:'DDO_BR_PROCEDUREID',prop:'SortedStatus'},{av:'Ddo_br_encounterid_Sortedstatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'Ddo_br_procedure_pxid_Sortedstatus',ctrl:'DDO_BR_PROCEDURE_PXID',prop:'SortedStatus'},{av:'Ddo_br_procedure_pxsurgery_Sortedstatus',ctrl:'DDO_BR_PROCEDURE_PXSURGERY',prop:'SortedStatus'},{av:'Ddo_br_procedure_date_Sortedstatus',ctrl:'DDO_BR_PROCEDURE_DATE',prop:'SortedStatus'},{av:'Ddo_br_procedure_pxradiotherapy_Sortedstatus',ctrl:'DDO_BR_PROCEDURE_PXRADIOTHERAPY',prop:'SortedStatus'},{av:'Ddo_br_procedure_radiodate_Sortedstatus',ctrl:'DDO_BR_PROCEDURE_RADIODATE',prop:'SortedStatus'},{av:'Ddo_br_procedure_radiotime_Sortedstatus',ctrl:'DDO_BR_PROCEDURE_RADIOTIME',prop:'SortedStatus'},{av:'AV16BR_ProcedureIDTitleFilterData',fld:'vBR_PROCEDUREIDTITLEFILTERDATA',pic:''},{av:'AV18BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV22BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV26BR_Procedure_PXIDTitleFilterData',fld:'vBR_PROCEDURE_PXIDTITLEFILTERDATA',pic:''},{av:'AV30BR_Procedure_PXSurgeryTitleFilterData',fld:'vBR_PROCEDURE_PXSURGERYTITLEFILTERDATA',pic:''},{av:'AV82BR_Procedure_DateTitleFilterData',fld:'vBR_PROCEDURE_DATETITLEFILTERDATA',pic:''},{av:'AV38BR_Procedure_PXRadiotherapyTitleFilterData',fld:'vBR_PROCEDURE_PXRADIOTHERAPYTITLEFILTERDATA',pic:''},{av:'AV92BR_Procedure_RadioDateTitleFilterData',fld:'vBR_PROCEDURE_RADIODATETITLEFILTERDATA',pic:''},{av:'AV98BR_Procedure_RadioTimeTitleFilterData',fld:'vBR_PROCEDURE_RADIOTIMETITLEFILTERDATA',pic:''},{av:'edtBR_ProcedureID_Titleformat',ctrl:'BR_PROCEDUREID',prop:'Titleformat'},{av:'edtBR_ProcedureID_Title',ctrl:'BR_PROCEDUREID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Procedure_PXID_Titleformat',ctrl:'BR_PROCEDURE_PXID',prop:'Titleformat'},{av:'edtBR_Procedure_PXID_Title',ctrl:'BR_PROCEDURE_PXID',prop:'Title'},{av:'cmbBR_Procedure_PXSurgery'},{av:'edtBR_Procedure_Date_Titleformat',ctrl:'BR_PROCEDURE_DATE',prop:'Titleformat'},{av:'edtBR_Procedure_Date_Title',ctrl:'BR_PROCEDURE_DATE',prop:'Title'},{av:'cmbBR_Procedure_PXRadiotherapy'},{av:'edtBR_Procedure_RadioDate_Titleformat',ctrl:'BR_PROCEDURE_RADIODATE',prop:'Titleformat'},{av:'edtBR_Procedure_RadioDate_Title',ctrl:'BR_PROCEDURE_RADIODATE',prop:'Title'},{av:'edtBR_Procedure_RadioTime_Titleformat',ctrl:'BR_PROCEDURE_RADIOTIME',prop:'Titleformat'},{av:'edtBR_Procedure_RadioTime_Title',ctrl:'BR_PROCEDURE_RADIOTIME',prop:'Title'},{av:'AV70GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV71GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV72GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV75IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV77IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_PROCEDURE_PXID.ONOPTIONCLICKED","{handler:'E163O2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV80TFBR_ProcedureID',fld:'vTFBR_PROCEDUREID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV81TFBR_ProcedureID_To',fld:'vTFBR_PROCEDUREID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV19TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV20TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV23TFBR_Information_PatientNo',fld:'vTFBR_INFORMATION_PATIENTNO',pic:''},{av:'AV24TFBR_Information_PatientNo_Sel',fld:'vTFBR_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV27TFBR_Procedure_PXID',fld:'vTFBR_PROCEDURE_PXID',pic:'ZZZZZZZZZZ'},{av:'AV28TFBR_Procedure_PXID_To',fld:'vTFBR_PROCEDURE_PXID_TO',pic:'ZZZZZZZZZZ'},{av:'AV83TFBR_Procedure_Date',fld:'vTFBR_PROCEDURE_DATE',pic:''},{av:'AV84TFBR_Procedure_Date_To',fld:'vTFBR_PROCEDURE_DATE_TO',pic:''},{av:'AV93TFBR_Procedure_RadioDate',fld:'vTFBR_PROCEDURE_RADIODATE',pic:''},{av:'AV94TFBR_Procedure_RadioDate_To',fld:'vTFBR_PROCEDURE_RADIODATE_TO',pic:''},{av:'AV99TFBR_Procedure_RadioTime',fld:'vTFBR_PROCEDURE_RADIOTIME',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV100TFBR_Procedure_RadioTime_To',fld:'vTFBR_PROCEDURE_RADIOTIME_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV17ddo_BR_ProcedureIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_BR_Procedure_PXIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXSURGERYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV87ddo_BR_Procedure_DateTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_DATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXRADIOTHERAPYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV97ddo_BR_Procedure_RadioDateTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIODATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV101ddo_BR_Procedure_RadioTimeTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIOTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV32TFBR_Procedure_PXSurgery_Sels',fld:'vTFBR_PROCEDURE_PXSURGERY_SELS',pic:''},{av:'AV40TFBR_Procedure_PXRadiotherapy_Sels',fld:'vTFBR_PROCEDURE_PXRADIOTHERAPY_SELS',pic:''},{av:'AV124Pgmname',fld:'vPGMNAME',pic:''},{av:'AV75IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV77IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV78IsAuthorized_BR_Information_PatientNo',fld:'vISAUTHORIZED_BR_INFORMATION_PATIENTNO',pic:'',hsh:true},{av:'Ddo_br_procedure_pxid_Activeeventkey',ctrl:'DDO_BR_PROCEDURE_PXID',prop:'ActiveEventKey'},{av:'Ddo_br_procedure_pxid_Filteredtext_get',ctrl:'DDO_BR_PROCEDURE_PXID',prop:'FilteredText_get'},{av:'Ddo_br_procedure_pxid_Filteredtextto_get',ctrl:'DDO_BR_PROCEDURE_PXID',prop:'FilteredTextTo_get'}]");
         setEventMetadata("DDO_BR_PROCEDURE_PXID.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_procedure_pxid_Sortedstatus',ctrl:'DDO_BR_PROCEDURE_PXID',prop:'SortedStatus'},{av:'AV27TFBR_Procedure_PXID',fld:'vTFBR_PROCEDURE_PXID',pic:'ZZZZZZZZZZ'},{av:'AV28TFBR_Procedure_PXID_To',fld:'vTFBR_PROCEDURE_PXID_TO',pic:'ZZZZZZZZZZ'},{av:'Ddo_br_procedureid_Sortedstatus',ctrl:'DDO_BR_PROCEDUREID',prop:'SortedStatus'},{av:'Ddo_br_encounterid_Sortedstatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'Ddo_br_information_patientno_Sortedstatus',ctrl:'DDO_BR_INFORMATION_PATIENTNO',prop:'SortedStatus'},{av:'Ddo_br_procedure_pxsurgery_Sortedstatus',ctrl:'DDO_BR_PROCEDURE_PXSURGERY',prop:'SortedStatus'},{av:'Ddo_br_procedure_date_Sortedstatus',ctrl:'DDO_BR_PROCEDURE_DATE',prop:'SortedStatus'},{av:'Ddo_br_procedure_pxradiotherapy_Sortedstatus',ctrl:'DDO_BR_PROCEDURE_PXRADIOTHERAPY',prop:'SortedStatus'},{av:'Ddo_br_procedure_radiodate_Sortedstatus',ctrl:'DDO_BR_PROCEDURE_RADIODATE',prop:'SortedStatus'},{av:'Ddo_br_procedure_radiotime_Sortedstatus',ctrl:'DDO_BR_PROCEDURE_RADIOTIME',prop:'SortedStatus'},{av:'AV16BR_ProcedureIDTitleFilterData',fld:'vBR_PROCEDUREIDTITLEFILTERDATA',pic:''},{av:'AV18BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV22BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV26BR_Procedure_PXIDTitleFilterData',fld:'vBR_PROCEDURE_PXIDTITLEFILTERDATA',pic:''},{av:'AV30BR_Procedure_PXSurgeryTitleFilterData',fld:'vBR_PROCEDURE_PXSURGERYTITLEFILTERDATA',pic:''},{av:'AV82BR_Procedure_DateTitleFilterData',fld:'vBR_PROCEDURE_DATETITLEFILTERDATA',pic:''},{av:'AV38BR_Procedure_PXRadiotherapyTitleFilterData',fld:'vBR_PROCEDURE_PXRADIOTHERAPYTITLEFILTERDATA',pic:''},{av:'AV92BR_Procedure_RadioDateTitleFilterData',fld:'vBR_PROCEDURE_RADIODATETITLEFILTERDATA',pic:''},{av:'AV98BR_Procedure_RadioTimeTitleFilterData',fld:'vBR_PROCEDURE_RADIOTIMETITLEFILTERDATA',pic:''},{av:'edtBR_ProcedureID_Titleformat',ctrl:'BR_PROCEDUREID',prop:'Titleformat'},{av:'edtBR_ProcedureID_Title',ctrl:'BR_PROCEDUREID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Procedure_PXID_Titleformat',ctrl:'BR_PROCEDURE_PXID',prop:'Titleformat'},{av:'edtBR_Procedure_PXID_Title',ctrl:'BR_PROCEDURE_PXID',prop:'Title'},{av:'cmbBR_Procedure_PXSurgery'},{av:'edtBR_Procedure_Date_Titleformat',ctrl:'BR_PROCEDURE_DATE',prop:'Titleformat'},{av:'edtBR_Procedure_Date_Title',ctrl:'BR_PROCEDURE_DATE',prop:'Title'},{av:'cmbBR_Procedure_PXRadiotherapy'},{av:'edtBR_Procedure_RadioDate_Titleformat',ctrl:'BR_PROCEDURE_RADIODATE',prop:'Titleformat'},{av:'edtBR_Procedure_RadioDate_Title',ctrl:'BR_PROCEDURE_RADIODATE',prop:'Title'},{av:'edtBR_Procedure_RadioTime_Titleformat',ctrl:'BR_PROCEDURE_RADIOTIME',prop:'Titleformat'},{av:'edtBR_Procedure_RadioTime_Title',ctrl:'BR_PROCEDURE_RADIOTIME',prop:'Title'},{av:'AV70GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV71GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV72GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV75IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV77IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_PROCEDURE_PXSURGERY.ONOPTIONCLICKED","{handler:'E173O2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV80TFBR_ProcedureID',fld:'vTFBR_PROCEDUREID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV81TFBR_ProcedureID_To',fld:'vTFBR_PROCEDUREID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV19TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV20TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV23TFBR_Information_PatientNo',fld:'vTFBR_INFORMATION_PATIENTNO',pic:''},{av:'AV24TFBR_Information_PatientNo_Sel',fld:'vTFBR_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV27TFBR_Procedure_PXID',fld:'vTFBR_PROCEDURE_PXID',pic:'ZZZZZZZZZZ'},{av:'AV28TFBR_Procedure_PXID_To',fld:'vTFBR_PROCEDURE_PXID_TO',pic:'ZZZZZZZZZZ'},{av:'AV83TFBR_Procedure_Date',fld:'vTFBR_PROCEDURE_DATE',pic:''},{av:'AV84TFBR_Procedure_Date_To',fld:'vTFBR_PROCEDURE_DATE_TO',pic:''},{av:'AV93TFBR_Procedure_RadioDate',fld:'vTFBR_PROCEDURE_RADIODATE',pic:''},{av:'AV94TFBR_Procedure_RadioDate_To',fld:'vTFBR_PROCEDURE_RADIODATE_TO',pic:''},{av:'AV99TFBR_Procedure_RadioTime',fld:'vTFBR_PROCEDURE_RADIOTIME',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV100TFBR_Procedure_RadioTime_To',fld:'vTFBR_PROCEDURE_RADIOTIME_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV17ddo_BR_ProcedureIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_BR_Procedure_PXIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXSURGERYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV87ddo_BR_Procedure_DateTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_DATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXRADIOTHERAPYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV97ddo_BR_Procedure_RadioDateTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIODATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV101ddo_BR_Procedure_RadioTimeTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIOTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV32TFBR_Procedure_PXSurgery_Sels',fld:'vTFBR_PROCEDURE_PXSURGERY_SELS',pic:''},{av:'AV40TFBR_Procedure_PXRadiotherapy_Sels',fld:'vTFBR_PROCEDURE_PXRADIOTHERAPY_SELS',pic:''},{av:'AV124Pgmname',fld:'vPGMNAME',pic:''},{av:'AV75IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV77IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV78IsAuthorized_BR_Information_PatientNo',fld:'vISAUTHORIZED_BR_INFORMATION_PATIENTNO',pic:'',hsh:true},{av:'Ddo_br_procedure_pxsurgery_Activeeventkey',ctrl:'DDO_BR_PROCEDURE_PXSURGERY',prop:'ActiveEventKey'},{av:'Ddo_br_procedure_pxsurgery_Selectedvalue_get',ctrl:'DDO_BR_PROCEDURE_PXSURGERY',prop:'SelectedValue_get'}]");
         setEventMetadata("DDO_BR_PROCEDURE_PXSURGERY.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_procedure_pxsurgery_Sortedstatus',ctrl:'DDO_BR_PROCEDURE_PXSURGERY',prop:'SortedStatus'},{av:'AV32TFBR_Procedure_PXSurgery_Sels',fld:'vTFBR_PROCEDURE_PXSURGERY_SELS',pic:''},{av:'Ddo_br_procedureid_Sortedstatus',ctrl:'DDO_BR_PROCEDUREID',prop:'SortedStatus'},{av:'Ddo_br_encounterid_Sortedstatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'Ddo_br_information_patientno_Sortedstatus',ctrl:'DDO_BR_INFORMATION_PATIENTNO',prop:'SortedStatus'},{av:'Ddo_br_procedure_pxid_Sortedstatus',ctrl:'DDO_BR_PROCEDURE_PXID',prop:'SortedStatus'},{av:'Ddo_br_procedure_date_Sortedstatus',ctrl:'DDO_BR_PROCEDURE_DATE',prop:'SortedStatus'},{av:'Ddo_br_procedure_pxradiotherapy_Sortedstatus',ctrl:'DDO_BR_PROCEDURE_PXRADIOTHERAPY',prop:'SortedStatus'},{av:'Ddo_br_procedure_radiodate_Sortedstatus',ctrl:'DDO_BR_PROCEDURE_RADIODATE',prop:'SortedStatus'},{av:'Ddo_br_procedure_radiotime_Sortedstatus',ctrl:'DDO_BR_PROCEDURE_RADIOTIME',prop:'SortedStatus'},{av:'AV16BR_ProcedureIDTitleFilterData',fld:'vBR_PROCEDUREIDTITLEFILTERDATA',pic:''},{av:'AV18BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV22BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV26BR_Procedure_PXIDTitleFilterData',fld:'vBR_PROCEDURE_PXIDTITLEFILTERDATA',pic:''},{av:'AV30BR_Procedure_PXSurgeryTitleFilterData',fld:'vBR_PROCEDURE_PXSURGERYTITLEFILTERDATA',pic:''},{av:'AV82BR_Procedure_DateTitleFilterData',fld:'vBR_PROCEDURE_DATETITLEFILTERDATA',pic:''},{av:'AV38BR_Procedure_PXRadiotherapyTitleFilterData',fld:'vBR_PROCEDURE_PXRADIOTHERAPYTITLEFILTERDATA',pic:''},{av:'AV92BR_Procedure_RadioDateTitleFilterData',fld:'vBR_PROCEDURE_RADIODATETITLEFILTERDATA',pic:''},{av:'AV98BR_Procedure_RadioTimeTitleFilterData',fld:'vBR_PROCEDURE_RADIOTIMETITLEFILTERDATA',pic:''},{av:'edtBR_ProcedureID_Titleformat',ctrl:'BR_PROCEDUREID',prop:'Titleformat'},{av:'edtBR_ProcedureID_Title',ctrl:'BR_PROCEDUREID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Procedure_PXID_Titleformat',ctrl:'BR_PROCEDURE_PXID',prop:'Titleformat'},{av:'edtBR_Procedure_PXID_Title',ctrl:'BR_PROCEDURE_PXID',prop:'Title'},{av:'cmbBR_Procedure_PXSurgery'},{av:'edtBR_Procedure_Date_Titleformat',ctrl:'BR_PROCEDURE_DATE',prop:'Titleformat'},{av:'edtBR_Procedure_Date_Title',ctrl:'BR_PROCEDURE_DATE',prop:'Title'},{av:'cmbBR_Procedure_PXRadiotherapy'},{av:'edtBR_Procedure_RadioDate_Titleformat',ctrl:'BR_PROCEDURE_RADIODATE',prop:'Titleformat'},{av:'edtBR_Procedure_RadioDate_Title',ctrl:'BR_PROCEDURE_RADIODATE',prop:'Title'},{av:'edtBR_Procedure_RadioTime_Titleformat',ctrl:'BR_PROCEDURE_RADIOTIME',prop:'Titleformat'},{av:'edtBR_Procedure_RadioTime_Title',ctrl:'BR_PROCEDURE_RADIOTIME',prop:'Title'},{av:'AV70GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV71GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV72GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV75IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV77IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_PROCEDURE_DATE.ONOPTIONCLICKED","{handler:'E183O2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV80TFBR_ProcedureID',fld:'vTFBR_PROCEDUREID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV81TFBR_ProcedureID_To',fld:'vTFBR_PROCEDUREID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV19TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV20TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV23TFBR_Information_PatientNo',fld:'vTFBR_INFORMATION_PATIENTNO',pic:''},{av:'AV24TFBR_Information_PatientNo_Sel',fld:'vTFBR_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV27TFBR_Procedure_PXID',fld:'vTFBR_PROCEDURE_PXID',pic:'ZZZZZZZZZZ'},{av:'AV28TFBR_Procedure_PXID_To',fld:'vTFBR_PROCEDURE_PXID_TO',pic:'ZZZZZZZZZZ'},{av:'AV83TFBR_Procedure_Date',fld:'vTFBR_PROCEDURE_DATE',pic:''},{av:'AV84TFBR_Procedure_Date_To',fld:'vTFBR_PROCEDURE_DATE_TO',pic:''},{av:'AV93TFBR_Procedure_RadioDate',fld:'vTFBR_PROCEDURE_RADIODATE',pic:''},{av:'AV94TFBR_Procedure_RadioDate_To',fld:'vTFBR_PROCEDURE_RADIODATE_TO',pic:''},{av:'AV99TFBR_Procedure_RadioTime',fld:'vTFBR_PROCEDURE_RADIOTIME',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV100TFBR_Procedure_RadioTime_To',fld:'vTFBR_PROCEDURE_RADIOTIME_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV17ddo_BR_ProcedureIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_BR_Procedure_PXIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXSURGERYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV87ddo_BR_Procedure_DateTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_DATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXRADIOTHERAPYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV97ddo_BR_Procedure_RadioDateTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIODATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV101ddo_BR_Procedure_RadioTimeTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIOTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV32TFBR_Procedure_PXSurgery_Sels',fld:'vTFBR_PROCEDURE_PXSURGERY_SELS',pic:''},{av:'AV40TFBR_Procedure_PXRadiotherapy_Sels',fld:'vTFBR_PROCEDURE_PXRADIOTHERAPY_SELS',pic:''},{av:'AV124Pgmname',fld:'vPGMNAME',pic:''},{av:'AV75IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV77IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV78IsAuthorized_BR_Information_PatientNo',fld:'vISAUTHORIZED_BR_INFORMATION_PATIENTNO',pic:'',hsh:true},{av:'Ddo_br_procedure_date_Activeeventkey',ctrl:'DDO_BR_PROCEDURE_DATE',prop:'ActiveEventKey'},{av:'Ddo_br_procedure_date_Filteredtext_get',ctrl:'DDO_BR_PROCEDURE_DATE',prop:'FilteredText_get'},{av:'Ddo_br_procedure_date_Filteredtextto_get',ctrl:'DDO_BR_PROCEDURE_DATE',prop:'FilteredTextTo_get'}]");
         setEventMetadata("DDO_BR_PROCEDURE_DATE.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_procedure_date_Sortedstatus',ctrl:'DDO_BR_PROCEDURE_DATE',prop:'SortedStatus'},{av:'AV83TFBR_Procedure_Date',fld:'vTFBR_PROCEDURE_DATE',pic:''},{av:'AV84TFBR_Procedure_Date_To',fld:'vTFBR_PROCEDURE_DATE_TO',pic:''},{av:'Ddo_br_procedureid_Sortedstatus',ctrl:'DDO_BR_PROCEDUREID',prop:'SortedStatus'},{av:'Ddo_br_encounterid_Sortedstatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'Ddo_br_information_patientno_Sortedstatus',ctrl:'DDO_BR_INFORMATION_PATIENTNO',prop:'SortedStatus'},{av:'Ddo_br_procedure_pxid_Sortedstatus',ctrl:'DDO_BR_PROCEDURE_PXID',prop:'SortedStatus'},{av:'Ddo_br_procedure_pxsurgery_Sortedstatus',ctrl:'DDO_BR_PROCEDURE_PXSURGERY',prop:'SortedStatus'},{av:'Ddo_br_procedure_pxradiotherapy_Sortedstatus',ctrl:'DDO_BR_PROCEDURE_PXRADIOTHERAPY',prop:'SortedStatus'},{av:'Ddo_br_procedure_radiodate_Sortedstatus',ctrl:'DDO_BR_PROCEDURE_RADIODATE',prop:'SortedStatus'},{av:'Ddo_br_procedure_radiotime_Sortedstatus',ctrl:'DDO_BR_PROCEDURE_RADIOTIME',prop:'SortedStatus'},{av:'AV16BR_ProcedureIDTitleFilterData',fld:'vBR_PROCEDUREIDTITLEFILTERDATA',pic:''},{av:'AV18BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV22BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV26BR_Procedure_PXIDTitleFilterData',fld:'vBR_PROCEDURE_PXIDTITLEFILTERDATA',pic:''},{av:'AV30BR_Procedure_PXSurgeryTitleFilterData',fld:'vBR_PROCEDURE_PXSURGERYTITLEFILTERDATA',pic:''},{av:'AV82BR_Procedure_DateTitleFilterData',fld:'vBR_PROCEDURE_DATETITLEFILTERDATA',pic:''},{av:'AV38BR_Procedure_PXRadiotherapyTitleFilterData',fld:'vBR_PROCEDURE_PXRADIOTHERAPYTITLEFILTERDATA',pic:''},{av:'AV92BR_Procedure_RadioDateTitleFilterData',fld:'vBR_PROCEDURE_RADIODATETITLEFILTERDATA',pic:''},{av:'AV98BR_Procedure_RadioTimeTitleFilterData',fld:'vBR_PROCEDURE_RADIOTIMETITLEFILTERDATA',pic:''},{av:'edtBR_ProcedureID_Titleformat',ctrl:'BR_PROCEDUREID',prop:'Titleformat'},{av:'edtBR_ProcedureID_Title',ctrl:'BR_PROCEDUREID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Procedure_PXID_Titleformat',ctrl:'BR_PROCEDURE_PXID',prop:'Titleformat'},{av:'edtBR_Procedure_PXID_Title',ctrl:'BR_PROCEDURE_PXID',prop:'Title'},{av:'cmbBR_Procedure_PXSurgery'},{av:'edtBR_Procedure_Date_Titleformat',ctrl:'BR_PROCEDURE_DATE',prop:'Titleformat'},{av:'edtBR_Procedure_Date_Title',ctrl:'BR_PROCEDURE_DATE',prop:'Title'},{av:'cmbBR_Procedure_PXRadiotherapy'},{av:'edtBR_Procedure_RadioDate_Titleformat',ctrl:'BR_PROCEDURE_RADIODATE',prop:'Titleformat'},{av:'edtBR_Procedure_RadioDate_Title',ctrl:'BR_PROCEDURE_RADIODATE',prop:'Title'},{av:'edtBR_Procedure_RadioTime_Titleformat',ctrl:'BR_PROCEDURE_RADIOTIME',prop:'Titleformat'},{av:'edtBR_Procedure_RadioTime_Title',ctrl:'BR_PROCEDURE_RADIOTIME',prop:'Title'},{av:'AV70GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV71GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV72GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV75IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV77IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_PROCEDURE_PXRADIOTHERAPY.ONOPTIONCLICKED","{handler:'E193O2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV80TFBR_ProcedureID',fld:'vTFBR_PROCEDUREID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV81TFBR_ProcedureID_To',fld:'vTFBR_PROCEDUREID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV19TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV20TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV23TFBR_Information_PatientNo',fld:'vTFBR_INFORMATION_PATIENTNO',pic:''},{av:'AV24TFBR_Information_PatientNo_Sel',fld:'vTFBR_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV27TFBR_Procedure_PXID',fld:'vTFBR_PROCEDURE_PXID',pic:'ZZZZZZZZZZ'},{av:'AV28TFBR_Procedure_PXID_To',fld:'vTFBR_PROCEDURE_PXID_TO',pic:'ZZZZZZZZZZ'},{av:'AV83TFBR_Procedure_Date',fld:'vTFBR_PROCEDURE_DATE',pic:''},{av:'AV84TFBR_Procedure_Date_To',fld:'vTFBR_PROCEDURE_DATE_TO',pic:''},{av:'AV93TFBR_Procedure_RadioDate',fld:'vTFBR_PROCEDURE_RADIODATE',pic:''},{av:'AV94TFBR_Procedure_RadioDate_To',fld:'vTFBR_PROCEDURE_RADIODATE_TO',pic:''},{av:'AV99TFBR_Procedure_RadioTime',fld:'vTFBR_PROCEDURE_RADIOTIME',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV100TFBR_Procedure_RadioTime_To',fld:'vTFBR_PROCEDURE_RADIOTIME_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV17ddo_BR_ProcedureIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_BR_Procedure_PXIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXSURGERYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV87ddo_BR_Procedure_DateTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_DATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXRADIOTHERAPYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV97ddo_BR_Procedure_RadioDateTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIODATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV101ddo_BR_Procedure_RadioTimeTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIOTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV32TFBR_Procedure_PXSurgery_Sels',fld:'vTFBR_PROCEDURE_PXSURGERY_SELS',pic:''},{av:'AV40TFBR_Procedure_PXRadiotherapy_Sels',fld:'vTFBR_PROCEDURE_PXRADIOTHERAPY_SELS',pic:''},{av:'AV124Pgmname',fld:'vPGMNAME',pic:''},{av:'AV75IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV77IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV78IsAuthorized_BR_Information_PatientNo',fld:'vISAUTHORIZED_BR_INFORMATION_PATIENTNO',pic:'',hsh:true},{av:'Ddo_br_procedure_pxradiotherapy_Activeeventkey',ctrl:'DDO_BR_PROCEDURE_PXRADIOTHERAPY',prop:'ActiveEventKey'},{av:'Ddo_br_procedure_pxradiotherapy_Selectedvalue_get',ctrl:'DDO_BR_PROCEDURE_PXRADIOTHERAPY',prop:'SelectedValue_get'}]");
         setEventMetadata("DDO_BR_PROCEDURE_PXRADIOTHERAPY.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_procedure_pxradiotherapy_Sortedstatus',ctrl:'DDO_BR_PROCEDURE_PXRADIOTHERAPY',prop:'SortedStatus'},{av:'AV40TFBR_Procedure_PXRadiotherapy_Sels',fld:'vTFBR_PROCEDURE_PXRADIOTHERAPY_SELS',pic:''},{av:'Ddo_br_procedureid_Sortedstatus',ctrl:'DDO_BR_PROCEDUREID',prop:'SortedStatus'},{av:'Ddo_br_encounterid_Sortedstatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'Ddo_br_information_patientno_Sortedstatus',ctrl:'DDO_BR_INFORMATION_PATIENTNO',prop:'SortedStatus'},{av:'Ddo_br_procedure_pxid_Sortedstatus',ctrl:'DDO_BR_PROCEDURE_PXID',prop:'SortedStatus'},{av:'Ddo_br_procedure_pxsurgery_Sortedstatus',ctrl:'DDO_BR_PROCEDURE_PXSURGERY',prop:'SortedStatus'},{av:'Ddo_br_procedure_date_Sortedstatus',ctrl:'DDO_BR_PROCEDURE_DATE',prop:'SortedStatus'},{av:'Ddo_br_procedure_radiodate_Sortedstatus',ctrl:'DDO_BR_PROCEDURE_RADIODATE',prop:'SortedStatus'},{av:'Ddo_br_procedure_radiotime_Sortedstatus',ctrl:'DDO_BR_PROCEDURE_RADIOTIME',prop:'SortedStatus'},{av:'AV16BR_ProcedureIDTitleFilterData',fld:'vBR_PROCEDUREIDTITLEFILTERDATA',pic:''},{av:'AV18BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV22BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV26BR_Procedure_PXIDTitleFilterData',fld:'vBR_PROCEDURE_PXIDTITLEFILTERDATA',pic:''},{av:'AV30BR_Procedure_PXSurgeryTitleFilterData',fld:'vBR_PROCEDURE_PXSURGERYTITLEFILTERDATA',pic:''},{av:'AV82BR_Procedure_DateTitleFilterData',fld:'vBR_PROCEDURE_DATETITLEFILTERDATA',pic:''},{av:'AV38BR_Procedure_PXRadiotherapyTitleFilterData',fld:'vBR_PROCEDURE_PXRADIOTHERAPYTITLEFILTERDATA',pic:''},{av:'AV92BR_Procedure_RadioDateTitleFilterData',fld:'vBR_PROCEDURE_RADIODATETITLEFILTERDATA',pic:''},{av:'AV98BR_Procedure_RadioTimeTitleFilterData',fld:'vBR_PROCEDURE_RADIOTIMETITLEFILTERDATA',pic:''},{av:'edtBR_ProcedureID_Titleformat',ctrl:'BR_PROCEDUREID',prop:'Titleformat'},{av:'edtBR_ProcedureID_Title',ctrl:'BR_PROCEDUREID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Procedure_PXID_Titleformat',ctrl:'BR_PROCEDURE_PXID',prop:'Titleformat'},{av:'edtBR_Procedure_PXID_Title',ctrl:'BR_PROCEDURE_PXID',prop:'Title'},{av:'cmbBR_Procedure_PXSurgery'},{av:'edtBR_Procedure_Date_Titleformat',ctrl:'BR_PROCEDURE_DATE',prop:'Titleformat'},{av:'edtBR_Procedure_Date_Title',ctrl:'BR_PROCEDURE_DATE',prop:'Title'},{av:'cmbBR_Procedure_PXRadiotherapy'},{av:'edtBR_Procedure_RadioDate_Titleformat',ctrl:'BR_PROCEDURE_RADIODATE',prop:'Titleformat'},{av:'edtBR_Procedure_RadioDate_Title',ctrl:'BR_PROCEDURE_RADIODATE',prop:'Title'},{av:'edtBR_Procedure_RadioTime_Titleformat',ctrl:'BR_PROCEDURE_RADIOTIME',prop:'Titleformat'},{av:'edtBR_Procedure_RadioTime_Title',ctrl:'BR_PROCEDURE_RADIOTIME',prop:'Title'},{av:'AV70GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV71GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV72GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV75IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV77IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_PROCEDURE_RADIODATE.ONOPTIONCLICKED","{handler:'E203O2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV80TFBR_ProcedureID',fld:'vTFBR_PROCEDUREID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV81TFBR_ProcedureID_To',fld:'vTFBR_PROCEDUREID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV19TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV20TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV23TFBR_Information_PatientNo',fld:'vTFBR_INFORMATION_PATIENTNO',pic:''},{av:'AV24TFBR_Information_PatientNo_Sel',fld:'vTFBR_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV27TFBR_Procedure_PXID',fld:'vTFBR_PROCEDURE_PXID',pic:'ZZZZZZZZZZ'},{av:'AV28TFBR_Procedure_PXID_To',fld:'vTFBR_PROCEDURE_PXID_TO',pic:'ZZZZZZZZZZ'},{av:'AV83TFBR_Procedure_Date',fld:'vTFBR_PROCEDURE_DATE',pic:''},{av:'AV84TFBR_Procedure_Date_To',fld:'vTFBR_PROCEDURE_DATE_TO',pic:''},{av:'AV93TFBR_Procedure_RadioDate',fld:'vTFBR_PROCEDURE_RADIODATE',pic:''},{av:'AV94TFBR_Procedure_RadioDate_To',fld:'vTFBR_PROCEDURE_RADIODATE_TO',pic:''},{av:'AV99TFBR_Procedure_RadioTime',fld:'vTFBR_PROCEDURE_RADIOTIME',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV100TFBR_Procedure_RadioTime_To',fld:'vTFBR_PROCEDURE_RADIOTIME_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV17ddo_BR_ProcedureIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_BR_Procedure_PXIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXSURGERYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV87ddo_BR_Procedure_DateTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_DATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXRADIOTHERAPYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV97ddo_BR_Procedure_RadioDateTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIODATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV101ddo_BR_Procedure_RadioTimeTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIOTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV32TFBR_Procedure_PXSurgery_Sels',fld:'vTFBR_PROCEDURE_PXSURGERY_SELS',pic:''},{av:'AV40TFBR_Procedure_PXRadiotherapy_Sels',fld:'vTFBR_PROCEDURE_PXRADIOTHERAPY_SELS',pic:''},{av:'AV124Pgmname',fld:'vPGMNAME',pic:''},{av:'AV75IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV77IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV78IsAuthorized_BR_Information_PatientNo',fld:'vISAUTHORIZED_BR_INFORMATION_PATIENTNO',pic:'',hsh:true},{av:'Ddo_br_procedure_radiodate_Activeeventkey',ctrl:'DDO_BR_PROCEDURE_RADIODATE',prop:'ActiveEventKey'},{av:'Ddo_br_procedure_radiodate_Filteredtext_get',ctrl:'DDO_BR_PROCEDURE_RADIODATE',prop:'FilteredText_get'},{av:'Ddo_br_procedure_radiodate_Filteredtextto_get',ctrl:'DDO_BR_PROCEDURE_RADIODATE',prop:'FilteredTextTo_get'}]");
         setEventMetadata("DDO_BR_PROCEDURE_RADIODATE.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_procedure_radiodate_Sortedstatus',ctrl:'DDO_BR_PROCEDURE_RADIODATE',prop:'SortedStatus'},{av:'AV93TFBR_Procedure_RadioDate',fld:'vTFBR_PROCEDURE_RADIODATE',pic:''},{av:'AV94TFBR_Procedure_RadioDate_To',fld:'vTFBR_PROCEDURE_RADIODATE_TO',pic:''},{av:'Ddo_br_procedureid_Sortedstatus',ctrl:'DDO_BR_PROCEDUREID',prop:'SortedStatus'},{av:'Ddo_br_encounterid_Sortedstatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'Ddo_br_information_patientno_Sortedstatus',ctrl:'DDO_BR_INFORMATION_PATIENTNO',prop:'SortedStatus'},{av:'Ddo_br_procedure_pxid_Sortedstatus',ctrl:'DDO_BR_PROCEDURE_PXID',prop:'SortedStatus'},{av:'Ddo_br_procedure_pxsurgery_Sortedstatus',ctrl:'DDO_BR_PROCEDURE_PXSURGERY',prop:'SortedStatus'},{av:'Ddo_br_procedure_date_Sortedstatus',ctrl:'DDO_BR_PROCEDURE_DATE',prop:'SortedStatus'},{av:'Ddo_br_procedure_pxradiotherapy_Sortedstatus',ctrl:'DDO_BR_PROCEDURE_PXRADIOTHERAPY',prop:'SortedStatus'},{av:'Ddo_br_procedure_radiotime_Sortedstatus',ctrl:'DDO_BR_PROCEDURE_RADIOTIME',prop:'SortedStatus'},{av:'AV16BR_ProcedureIDTitleFilterData',fld:'vBR_PROCEDUREIDTITLEFILTERDATA',pic:''},{av:'AV18BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV22BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV26BR_Procedure_PXIDTitleFilterData',fld:'vBR_PROCEDURE_PXIDTITLEFILTERDATA',pic:''},{av:'AV30BR_Procedure_PXSurgeryTitleFilterData',fld:'vBR_PROCEDURE_PXSURGERYTITLEFILTERDATA',pic:''},{av:'AV82BR_Procedure_DateTitleFilterData',fld:'vBR_PROCEDURE_DATETITLEFILTERDATA',pic:''},{av:'AV38BR_Procedure_PXRadiotherapyTitleFilterData',fld:'vBR_PROCEDURE_PXRADIOTHERAPYTITLEFILTERDATA',pic:''},{av:'AV92BR_Procedure_RadioDateTitleFilterData',fld:'vBR_PROCEDURE_RADIODATETITLEFILTERDATA',pic:''},{av:'AV98BR_Procedure_RadioTimeTitleFilterData',fld:'vBR_PROCEDURE_RADIOTIMETITLEFILTERDATA',pic:''},{av:'edtBR_ProcedureID_Titleformat',ctrl:'BR_PROCEDUREID',prop:'Titleformat'},{av:'edtBR_ProcedureID_Title',ctrl:'BR_PROCEDUREID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Procedure_PXID_Titleformat',ctrl:'BR_PROCEDURE_PXID',prop:'Titleformat'},{av:'edtBR_Procedure_PXID_Title',ctrl:'BR_PROCEDURE_PXID',prop:'Title'},{av:'cmbBR_Procedure_PXSurgery'},{av:'edtBR_Procedure_Date_Titleformat',ctrl:'BR_PROCEDURE_DATE',prop:'Titleformat'},{av:'edtBR_Procedure_Date_Title',ctrl:'BR_PROCEDURE_DATE',prop:'Title'},{av:'cmbBR_Procedure_PXRadiotherapy'},{av:'edtBR_Procedure_RadioDate_Titleformat',ctrl:'BR_PROCEDURE_RADIODATE',prop:'Titleformat'},{av:'edtBR_Procedure_RadioDate_Title',ctrl:'BR_PROCEDURE_RADIODATE',prop:'Title'},{av:'edtBR_Procedure_RadioTime_Titleformat',ctrl:'BR_PROCEDURE_RADIOTIME',prop:'Titleformat'},{av:'edtBR_Procedure_RadioTime_Title',ctrl:'BR_PROCEDURE_RADIOTIME',prop:'Title'},{av:'AV70GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV71GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV72GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV75IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV77IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_PROCEDURE_RADIOTIME.ONOPTIONCLICKED","{handler:'E213O2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV80TFBR_ProcedureID',fld:'vTFBR_PROCEDUREID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV81TFBR_ProcedureID_To',fld:'vTFBR_PROCEDUREID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV19TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV20TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV23TFBR_Information_PatientNo',fld:'vTFBR_INFORMATION_PATIENTNO',pic:''},{av:'AV24TFBR_Information_PatientNo_Sel',fld:'vTFBR_INFORMATION_PATIENTNO_SEL',pic:''},{av:'AV27TFBR_Procedure_PXID',fld:'vTFBR_PROCEDURE_PXID',pic:'ZZZZZZZZZZ'},{av:'AV28TFBR_Procedure_PXID_To',fld:'vTFBR_PROCEDURE_PXID_TO',pic:'ZZZZZZZZZZ'},{av:'AV83TFBR_Procedure_Date',fld:'vTFBR_PROCEDURE_DATE',pic:''},{av:'AV84TFBR_Procedure_Date_To',fld:'vTFBR_PROCEDURE_DATE_TO',pic:''},{av:'AV93TFBR_Procedure_RadioDate',fld:'vTFBR_PROCEDURE_RADIODATE',pic:''},{av:'AV94TFBR_Procedure_RadioDate_To',fld:'vTFBR_PROCEDURE_RADIODATE_TO',pic:''},{av:'AV99TFBR_Procedure_RadioTime',fld:'vTFBR_PROCEDURE_RADIOTIME',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV100TFBR_Procedure_RadioTime_To',fld:'vTFBR_PROCEDURE_RADIOTIME_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV17ddo_BR_ProcedureIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_BR_Procedure_PXIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXSURGERYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV87ddo_BR_Procedure_DateTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_DATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXRADIOTHERAPYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV97ddo_BR_Procedure_RadioDateTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIODATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV101ddo_BR_Procedure_RadioTimeTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIOTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV32TFBR_Procedure_PXSurgery_Sels',fld:'vTFBR_PROCEDURE_PXSURGERY_SELS',pic:''},{av:'AV40TFBR_Procedure_PXRadiotherapy_Sels',fld:'vTFBR_PROCEDURE_PXRADIOTHERAPY_SELS',pic:''},{av:'AV124Pgmname',fld:'vPGMNAME',pic:''},{av:'AV75IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV77IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV78IsAuthorized_BR_Information_PatientNo',fld:'vISAUTHORIZED_BR_INFORMATION_PATIENTNO',pic:'',hsh:true},{av:'Ddo_br_procedure_radiotime_Activeeventkey',ctrl:'DDO_BR_PROCEDURE_RADIOTIME',prop:'ActiveEventKey'},{av:'Ddo_br_procedure_radiotime_Filteredtext_get',ctrl:'DDO_BR_PROCEDURE_RADIOTIME',prop:'FilteredText_get'},{av:'Ddo_br_procedure_radiotime_Filteredtextto_get',ctrl:'DDO_BR_PROCEDURE_RADIOTIME',prop:'FilteredTextTo_get'}]");
         setEventMetadata("DDO_BR_PROCEDURE_RADIOTIME.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_procedure_radiotime_Sortedstatus',ctrl:'DDO_BR_PROCEDURE_RADIOTIME',prop:'SortedStatus'},{av:'AV99TFBR_Procedure_RadioTime',fld:'vTFBR_PROCEDURE_RADIOTIME',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV100TFBR_Procedure_RadioTime_To',fld:'vTFBR_PROCEDURE_RADIOTIME_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'Ddo_br_procedureid_Sortedstatus',ctrl:'DDO_BR_PROCEDUREID',prop:'SortedStatus'},{av:'Ddo_br_encounterid_Sortedstatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'Ddo_br_information_patientno_Sortedstatus',ctrl:'DDO_BR_INFORMATION_PATIENTNO',prop:'SortedStatus'},{av:'Ddo_br_procedure_pxid_Sortedstatus',ctrl:'DDO_BR_PROCEDURE_PXID',prop:'SortedStatus'},{av:'Ddo_br_procedure_pxsurgery_Sortedstatus',ctrl:'DDO_BR_PROCEDURE_PXSURGERY',prop:'SortedStatus'},{av:'Ddo_br_procedure_date_Sortedstatus',ctrl:'DDO_BR_PROCEDURE_DATE',prop:'SortedStatus'},{av:'Ddo_br_procedure_pxradiotherapy_Sortedstatus',ctrl:'DDO_BR_PROCEDURE_PXRADIOTHERAPY',prop:'SortedStatus'},{av:'Ddo_br_procedure_radiodate_Sortedstatus',ctrl:'DDO_BR_PROCEDURE_RADIODATE',prop:'SortedStatus'},{av:'AV16BR_ProcedureIDTitleFilterData',fld:'vBR_PROCEDUREIDTITLEFILTERDATA',pic:''},{av:'AV18BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV22BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV26BR_Procedure_PXIDTitleFilterData',fld:'vBR_PROCEDURE_PXIDTITLEFILTERDATA',pic:''},{av:'AV30BR_Procedure_PXSurgeryTitleFilterData',fld:'vBR_PROCEDURE_PXSURGERYTITLEFILTERDATA',pic:''},{av:'AV82BR_Procedure_DateTitleFilterData',fld:'vBR_PROCEDURE_DATETITLEFILTERDATA',pic:''},{av:'AV38BR_Procedure_PXRadiotherapyTitleFilterData',fld:'vBR_PROCEDURE_PXRADIOTHERAPYTITLEFILTERDATA',pic:''},{av:'AV92BR_Procedure_RadioDateTitleFilterData',fld:'vBR_PROCEDURE_RADIODATETITLEFILTERDATA',pic:''},{av:'AV98BR_Procedure_RadioTimeTitleFilterData',fld:'vBR_PROCEDURE_RADIOTIMETITLEFILTERDATA',pic:''},{av:'edtBR_ProcedureID_Titleformat',ctrl:'BR_PROCEDUREID',prop:'Titleformat'},{av:'edtBR_ProcedureID_Title',ctrl:'BR_PROCEDUREID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Procedure_PXID_Titleformat',ctrl:'BR_PROCEDURE_PXID',prop:'Titleformat'},{av:'edtBR_Procedure_PXID_Title',ctrl:'BR_PROCEDURE_PXID',prop:'Title'},{av:'cmbBR_Procedure_PXSurgery'},{av:'edtBR_Procedure_Date_Titleformat',ctrl:'BR_PROCEDURE_DATE',prop:'Titleformat'},{av:'edtBR_Procedure_Date_Title',ctrl:'BR_PROCEDURE_DATE',prop:'Title'},{av:'cmbBR_Procedure_PXRadiotherapy'},{av:'edtBR_Procedure_RadioDate_Titleformat',ctrl:'BR_PROCEDURE_RADIODATE',prop:'Titleformat'},{av:'edtBR_Procedure_RadioDate_Title',ctrl:'BR_PROCEDURE_RADIODATE',prop:'Title'},{av:'edtBR_Procedure_RadioTime_Titleformat',ctrl:'BR_PROCEDURE_RADIOTIME',prop:'Titleformat'},{av:'edtBR_Procedure_RadioTime_Title',ctrl:'BR_PROCEDURE_RADIOTIME',prop:'Title'},{av:'AV70GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV71GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV72GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV75IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV77IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("GRID.LOAD","{handler:'E253O2',iparms:[{av:'A139BR_ProcedureID',fld:'BR_PROCEDUREID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV75IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV77IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV78IsAuthorized_BR_Information_PatientNo',fld:'vISAUTHORIZED_BR_INFORMATION_PATIENTNO',pic:'',hsh:true},{av:'A85BR_Information_ID',fld:'BR_INFORMATION_ID',pic:'ZZZZZZZZZZZZZZZZZZ'}]");
         setEventMetadata("GRID.LOAD",",oparms:[{av:'AV73Display',fld:'vDISPLAY',pic:''},{av:'edtavDisplay_Tooltiptext',ctrl:'vDISPLAY',prop:'Tooltiptext'},{av:'edtavDisplay_Link',ctrl:'vDISPLAY',prop:'Link'},{av:'AV74Update',fld:'vUPDATE',pic:''},{av:'edtavUpdate_Tooltiptext',ctrl:'vUPDATE',prop:'Tooltiptext'},{av:'edtavUpdate_Link',ctrl:'vUPDATE',prop:'Link'},{av:'AV76Delete',fld:'vDELETE',pic:''},{av:'edtavDelete_Tooltiptext',ctrl:'vDELETE',prop:'Tooltiptext'},{av:'edtavDelete_Link',ctrl:'vDELETE',prop:'Link'},{av:'edtBR_Information_PatientNo_Link',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Link'}]}");
         setEventMetadata("'DOINSERT'","{handler:'E223O2',iparms:[{av:'A139BR_ProcedureID',fld:'BR_PROCEDUREID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
         setEventMetadata("'DOINSERT'",",oparms:[]}");
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
         Ddo_br_procedureid_Activeeventkey = "";
         Ddo_br_procedureid_Filteredtext_get = "";
         Ddo_br_procedureid_Filteredtextto_get = "";
         Ddo_br_encounterid_Activeeventkey = "";
         Ddo_br_encounterid_Filteredtext_get = "";
         Ddo_br_encounterid_Filteredtextto_get = "";
         Ddo_br_information_patientno_Activeeventkey = "";
         Ddo_br_information_patientno_Filteredtext_get = "";
         Ddo_br_information_patientno_Selectedvalue_get = "";
         Ddo_br_procedure_pxid_Activeeventkey = "";
         Ddo_br_procedure_pxid_Filteredtext_get = "";
         Ddo_br_procedure_pxid_Filteredtextto_get = "";
         Ddo_br_procedure_pxsurgery_Activeeventkey = "";
         Ddo_br_procedure_pxsurgery_Selectedvalue_get = "";
         Ddo_br_procedure_date_Activeeventkey = "";
         Ddo_br_procedure_date_Filteredtext_get = "";
         Ddo_br_procedure_date_Filteredtextto_get = "";
         Ddo_br_procedure_pxradiotherapy_Activeeventkey = "";
         Ddo_br_procedure_pxradiotherapy_Selectedvalue_get = "";
         Ddo_br_procedure_radiodate_Activeeventkey = "";
         Ddo_br_procedure_radiodate_Filteredtext_get = "";
         Ddo_br_procedure_radiodate_Filteredtextto_get = "";
         Ddo_br_procedure_radiotime_Activeeventkey = "";
         Ddo_br_procedure_radiotime_Filteredtext_get = "";
         Ddo_br_procedure_radiotime_Filteredtextto_get = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV23TFBR_Information_PatientNo = "";
         AV24TFBR_Information_PatientNo_Sel = "";
         AV83TFBR_Procedure_Date = DateTime.MinValue;
         AV84TFBR_Procedure_Date_To = DateTime.MinValue;
         AV93TFBR_Procedure_RadioDate = DateTime.MinValue;
         AV94TFBR_Procedure_RadioDate_To = DateTime.MinValue;
         AV17ddo_BR_ProcedureIDTitleControlIdToReplace = "";
         AV21ddo_BR_EncounterIDTitleControlIdToReplace = "";
         AV25ddo_BR_Information_PatientNoTitleControlIdToReplace = "";
         AV29ddo_BR_Procedure_PXIDTitleControlIdToReplace = "";
         AV33ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace = "";
         AV87ddo_BR_Procedure_DateTitleControlIdToReplace = "";
         AV41ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace = "";
         AV97ddo_BR_Procedure_RadioDateTitleControlIdToReplace = "";
         AV101ddo_BR_Procedure_RadioTimeTitleControlIdToReplace = "";
         AV32TFBR_Procedure_PXSurgery_Sels = new GxSimpleCollection<String>();
         AV40TFBR_Procedure_PXRadiotherapy_Sels = new GxSimpleCollection<String>();
         AV124Pgmname = "";
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         AV68DDO_TitleSettingsIcons = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV16BR_ProcedureIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV18BR_EncounterIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV22BR_Information_PatientNoTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV26BR_Procedure_PXIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV30BR_Procedure_PXSurgeryTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV82BR_Procedure_DateTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV38BR_Procedure_PXRadiotherapyTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV92BR_Procedure_RadioDateTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV98BR_Procedure_RadioTimeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         Ddo_br_procedureid_Filteredtext_set = "";
         Ddo_br_procedureid_Filteredtextto_set = "";
         Ddo_br_procedureid_Sortedstatus = "";
         Ddo_br_encounterid_Filteredtext_set = "";
         Ddo_br_encounterid_Filteredtextto_set = "";
         Ddo_br_encounterid_Sortedstatus = "";
         Ddo_br_information_patientno_Filteredtext_set = "";
         Ddo_br_information_patientno_Selectedvalue_set = "";
         Ddo_br_information_patientno_Sortedstatus = "";
         Ddo_br_procedure_pxid_Filteredtext_set = "";
         Ddo_br_procedure_pxid_Filteredtextto_set = "";
         Ddo_br_procedure_pxid_Sortedstatus = "";
         Ddo_br_procedure_pxsurgery_Selectedvalue_set = "";
         Ddo_br_procedure_pxsurgery_Sortedstatus = "";
         Ddo_br_procedure_date_Filteredtext_set = "";
         Ddo_br_procedure_date_Filteredtextto_set = "";
         Ddo_br_procedure_date_Sortedstatus = "";
         Ddo_br_procedure_pxradiotherapy_Selectedvalue_set = "";
         Ddo_br_procedure_pxradiotherapy_Sortedstatus = "";
         Ddo_br_procedure_radiodate_Filteredtext_set = "";
         Ddo_br_procedure_radiodate_Filteredtextto_set = "";
         Ddo_br_procedure_radiodate_Sortedstatus = "";
         Ddo_br_procedure_radiotime_Filteredtext_set = "";
         Ddo_br_procedure_radiotime_Filteredtextto_set = "";
         Ddo_br_procedure_radiotime_Sortedstatus = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         ucDvpanel_tableheader = new GXUserControl();
         TempTags = "";
         ClassString = "";
         StyleString = "";
         bttBtninsert_Jsonclick = "";
         GridContainer = new GXWebGrid( context);
         sStyleString = "";
         subGrid_Linesclass = "";
         GridColumn = new GXWebColumn();
         AV73Display = "";
         AV74Update = "";
         AV76Delete = "";
         A36BR_Information_PatientNo = "";
         A141BR_Procedure_PXSurgery = "";
         A266BR_Procedure_Date = DateTime.MinValue;
         A143BR_Procedure_PXRadiotherapy = "";
         A268BR_Procedure_RadioDate = DateTime.MinValue;
         ucGridpaginationbar = new GXUserControl();
         ucDdo_br_procedureid = new GXUserControl();
         ucDdo_br_encounterid = new GXUserControl();
         ucDdo_br_information_patientno = new GXUserControl();
         ucDdo_br_procedure_pxid = new GXUserControl();
         ucDdo_br_procedure_pxsurgery = new GXUserControl();
         ucDdo_br_procedure_date = new GXUserControl();
         ucDdo_br_procedure_pxradiotherapy = new GXUserControl();
         ucDdo_br_procedure_radiodate = new GXUserControl();
         ucDdo_br_procedure_radiotime = new GXUserControl();
         ucWorkwithplusutilities1 = new GXUserControl();
         AV85DDO_BR_Procedure_DateAuxDate = DateTime.MinValue;
         AV86DDO_BR_Procedure_DateAuxDateTo = DateTime.MinValue;
         AV95DDO_BR_Procedure_RadioDateAuxDate = DateTime.MinValue;
         AV96DDO_BR_Procedure_RadioDateAuxDateTo = DateTime.MinValue;
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV121Display_GXI = "";
         AV122Update_GXI = "";
         AV123Delete_GXI = "";
         AV113BR_ProcedureWWDS_9_Tfbr_procedure_pxsurgery_sels = new GxSimpleCollection<String>();
         AV116BR_ProcedureWWDS_12_Tfbr_procedure_pxradiotherapy_sels = new GxSimpleCollection<String>();
         scmdbuf = "";
         lV109BR_ProcedureWWDS_5_Tfbr_information_patientno = "";
         AV110BR_ProcedureWWDS_6_Tfbr_information_patientno_sel = "";
         AV109BR_ProcedureWWDS_5_Tfbr_information_patientno = "";
         AV114BR_ProcedureWWDS_10_Tfbr_procedure_date = DateTime.MinValue;
         AV115BR_ProcedureWWDS_11_Tfbr_procedure_date_to = DateTime.MinValue;
         AV117BR_ProcedureWWDS_13_Tfbr_procedure_radiodate = DateTime.MinValue;
         AV118BR_ProcedureWWDS_14_Tfbr_procedure_radiodate_to = DateTime.MinValue;
         H003O2_A85BR_Information_ID = new long[1] ;
         H003O2_n85BR_Information_ID = new bool[] {false} ;
         H003O2_A269BR_Procedure_RadioTime = new decimal[1] ;
         H003O2_n269BR_Procedure_RadioTime = new bool[] {false} ;
         H003O2_A268BR_Procedure_RadioDate = new DateTime[] {DateTime.MinValue} ;
         H003O2_n268BR_Procedure_RadioDate = new bool[] {false} ;
         H003O2_A143BR_Procedure_PXRadiotherapy = new String[] {""} ;
         H003O2_n143BR_Procedure_PXRadiotherapy = new bool[] {false} ;
         H003O2_A266BR_Procedure_Date = new DateTime[] {DateTime.MinValue} ;
         H003O2_n266BR_Procedure_Date = new bool[] {false} ;
         H003O2_A141BR_Procedure_PXSurgery = new String[] {""} ;
         H003O2_n141BR_Procedure_PXSurgery = new bool[] {false} ;
         H003O2_A140BR_Procedure_PXID = new long[1] ;
         H003O2_n140BR_Procedure_PXID = new bool[] {false} ;
         H003O2_A36BR_Information_PatientNo = new String[] {""} ;
         H003O2_n36BR_Information_PatientNo = new bool[] {false} ;
         H003O2_A19BR_EncounterID = new long[1] ;
         H003O2_n19BR_EncounterID = new bool[] {false} ;
         H003O2_A139BR_ProcedureID = new long[1] ;
         H003O3_AGRID_nRecordCount = new long[1] ;
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV6WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV31TFBR_Procedure_PXSurgery_SelsJson = "";
         AV39TFBR_Procedure_PXRadiotherapy_SelsJson = "";
         GridRow = new GXWebRow();
         AV15Session = context.GetSession();
         AV11GridState = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState(context);
         AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
         AV9TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV8HTTPRequest = new GxHttpRequest( context);
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sImgUrl = "";
         ROClassString = "";
         GXCCtl = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_procedureww__default(),
            new Object[][] {
                new Object[] {
               H003O2_A85BR_Information_ID, H003O2_n85BR_Information_ID, H003O2_A269BR_Procedure_RadioTime, H003O2_n269BR_Procedure_RadioTime, H003O2_A268BR_Procedure_RadioDate, H003O2_n268BR_Procedure_RadioDate, H003O2_A143BR_Procedure_PXRadiotherapy, H003O2_n143BR_Procedure_PXRadiotherapy, H003O2_A266BR_Procedure_Date, H003O2_n266BR_Procedure_Date,
               H003O2_A141BR_Procedure_PXSurgery, H003O2_n141BR_Procedure_PXSurgery, H003O2_A140BR_Procedure_PXID, H003O2_n140BR_Procedure_PXID, H003O2_A36BR_Information_PatientNo, H003O2_n36BR_Information_PatientNo, H003O2_A19BR_EncounterID, H003O2_n19BR_EncounterID, H003O2_A139BR_ProcedureID
               }
               , new Object[] {
               H003O3_AGRID_nRecordCount
               }
            }
         );
         AV124Pgmname = "BR_ProcedureWW";
         /* GeneXus formulas. */
         AV124Pgmname = "BR_ProcedureWW";
         context.Gx_err = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_GXsfl_28 ;
      private short nGXsfl_28_idx=1 ;
      private short GRID_nEOF ;
      private short AV13OrderedBy ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short subGrid_Backcolorstyle ;
      private short subGrid_Titlebackstyle ;
      private short edtBR_ProcedureID_Titleformat ;
      private short edtBR_EncounterID_Titleformat ;
      private short edtBR_Information_PatientNo_Titleformat ;
      private short edtBR_Procedure_PXID_Titleformat ;
      private short cmbBR_Procedure_PXSurgery_Titleformat ;
      private short edtBR_Procedure_Date_Titleformat ;
      private short cmbBR_Procedure_PXRadiotherapy_Titleformat ;
      private short edtBR_Procedure_RadioDate_Titleformat ;
      private short edtBR_Procedure_RadioTime_Titleformat ;
      private short subGrid_Sortable ;
      private short subGrid_Allowselection ;
      private short subGrid_Allowhovering ;
      private short subGrid_Allowcollapsing ;
      private short subGrid_Collapsed ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short nGXWrapped ;
      private short subGrid_Backstyle ;
      private int subGrid_Rows ;
      private int Gridpaginationbar_Rowsperpageselectedvalue ;
      private int Gridpaginationbar_Pagestoshow ;
      private int Ddo_br_information_patientno_Datalistupdateminimumcharacters ;
      private int bttBtninsert_Visible ;
      private int subGrid_Titlebackcolor ;
      private int subGrid_Allbackcolor ;
      private int edtavUpdate_Visible ;
      private int edtavDelete_Visible ;
      private int subGrid_Selectedindex ;
      private int subGrid_Selectioncolor ;
      private int subGrid_Hoveringcolor ;
      private int edtavDdo_br_procedureidtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_encounteridtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_information_patientnotitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_procedure_pxidtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_procedure_pxsurgerytitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_procedure_datetitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_procedure_pxradiotherapytitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_procedure_radiodatetitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_procedure_radiotimetitlecontrolidtoreplace_Visible ;
      private int edtavOrderedby_Visible ;
      private int edtavOrdereddsc_Visible ;
      private int edtavTfbr_procedureid_Visible ;
      private int edtavTfbr_procedureid_to_Visible ;
      private int edtavTfbr_encounterid_Visible ;
      private int edtavTfbr_encounterid_to_Visible ;
      private int edtavTfbr_information_patientno_Visible ;
      private int edtavTfbr_information_patientno_sel_Visible ;
      private int edtavTfbr_procedure_pxid_Visible ;
      private int edtavTfbr_procedure_pxid_to_Visible ;
      private int edtavTfbr_procedure_date_Visible ;
      private int edtavTfbr_procedure_date_to_Visible ;
      private int edtavTfbr_procedure_radiodate_Visible ;
      private int edtavTfbr_procedure_radiodate_to_Visible ;
      private int edtavTfbr_procedure_radiotime_Visible ;
      private int edtavTfbr_procedure_radiotime_to_Visible ;
      private int subGrid_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int AV113BR_ProcedureWWDS_9_Tfbr_procedure_pxsurgery_sels_Count ;
      private int AV116BR_ProcedureWWDS_12_Tfbr_procedure_pxradiotherapy_sels_Count ;
      private int AV69PageToGo ;
      private int AV125GXV1 ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private long GRID_nFirstRecordOnPage ;
      private long AV80TFBR_ProcedureID ;
      private long AV81TFBR_ProcedureID_To ;
      private long AV19TFBR_EncounterID ;
      private long AV20TFBR_EncounterID_To ;
      private long AV27TFBR_Procedure_PXID ;
      private long AV28TFBR_Procedure_PXID_To ;
      private long AV70GridCurrentPage ;
      private long AV72GridRecordCount ;
      private long AV71GridPageSize ;
      private long A85BR_Information_ID ;
      private long A139BR_ProcedureID ;
      private long A19BR_EncounterID ;
      private long A140BR_Procedure_PXID ;
      private long GRID_nCurrentRecord ;
      private long AV105BR_ProcedureWWDS_1_Tfbr_procedureid ;
      private long AV106BR_ProcedureWWDS_2_Tfbr_procedureid_to ;
      private long AV107BR_ProcedureWWDS_3_Tfbr_encounterid ;
      private long AV108BR_ProcedureWWDS_4_Tfbr_encounterid_to ;
      private long AV111BR_ProcedureWWDS_7_Tfbr_procedure_pxid ;
      private long AV112BR_ProcedureWWDS_8_Tfbr_procedure_pxid_to ;
      private long GRID_nRecordCount ;
      private decimal AV99TFBR_Procedure_RadioTime ;
      private decimal AV100TFBR_Procedure_RadioTime_To ;
      private decimal A269BR_Procedure_RadioTime ;
      private decimal AV119BR_ProcedureWWDS_15_Tfbr_procedure_radiotime ;
      private decimal AV120BR_ProcedureWWDS_16_Tfbr_procedure_radiotime_to ;
      private String Gridpaginationbar_Selectedpage ;
      private String Ddo_br_procedureid_Activeeventkey ;
      private String Ddo_br_procedureid_Filteredtext_get ;
      private String Ddo_br_procedureid_Filteredtextto_get ;
      private String Ddo_br_encounterid_Activeeventkey ;
      private String Ddo_br_encounterid_Filteredtext_get ;
      private String Ddo_br_encounterid_Filteredtextto_get ;
      private String Ddo_br_information_patientno_Activeeventkey ;
      private String Ddo_br_information_patientno_Filteredtext_get ;
      private String Ddo_br_information_patientno_Selectedvalue_get ;
      private String Ddo_br_procedure_pxid_Activeeventkey ;
      private String Ddo_br_procedure_pxid_Filteredtext_get ;
      private String Ddo_br_procedure_pxid_Filteredtextto_get ;
      private String Ddo_br_procedure_pxsurgery_Activeeventkey ;
      private String Ddo_br_procedure_pxsurgery_Selectedvalue_get ;
      private String Ddo_br_procedure_date_Activeeventkey ;
      private String Ddo_br_procedure_date_Filteredtext_get ;
      private String Ddo_br_procedure_date_Filteredtextto_get ;
      private String Ddo_br_procedure_pxradiotherapy_Activeeventkey ;
      private String Ddo_br_procedure_pxradiotherapy_Selectedvalue_get ;
      private String Ddo_br_procedure_radiodate_Activeeventkey ;
      private String Ddo_br_procedure_radiodate_Filteredtext_get ;
      private String Ddo_br_procedure_radiodate_Filteredtextto_get ;
      private String Ddo_br_procedure_radiotime_Activeeventkey ;
      private String Ddo_br_procedure_radiotime_Filteredtext_get ;
      private String Ddo_br_procedure_radiotime_Filteredtextto_get ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_28_idx="0001" ;
      private String AV124Pgmname ;
      private String GXKey ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
      private String Dvpanel_tableheader_Width ;
      private String Dvpanel_tableheader_Cls ;
      private String Dvpanel_tableheader_Title ;
      private String Dvpanel_tableheader_Iconposition ;
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
      private String Ddo_br_procedureid_Caption ;
      private String Ddo_br_procedureid_Tooltip ;
      private String Ddo_br_procedureid_Cls ;
      private String Ddo_br_procedureid_Filteredtext_set ;
      private String Ddo_br_procedureid_Filteredtextto_set ;
      private String Ddo_br_procedureid_Dropdownoptionstype ;
      private String Ddo_br_procedureid_Titlecontrolidtoreplace ;
      private String Ddo_br_procedureid_Sortedstatus ;
      private String Ddo_br_procedureid_Filtertype ;
      private String Ddo_br_procedureid_Sortasc ;
      private String Ddo_br_procedureid_Sortdsc ;
      private String Ddo_br_procedureid_Cleanfilter ;
      private String Ddo_br_procedureid_Rangefilterfrom ;
      private String Ddo_br_procedureid_Rangefilterto ;
      private String Ddo_br_procedureid_Searchbuttontext ;
      private String Ddo_br_encounterid_Caption ;
      private String Ddo_br_encounterid_Tooltip ;
      private String Ddo_br_encounterid_Cls ;
      private String Ddo_br_encounterid_Filteredtext_set ;
      private String Ddo_br_encounterid_Filteredtextto_set ;
      private String Ddo_br_encounterid_Dropdownoptionstype ;
      private String Ddo_br_encounterid_Titlecontrolidtoreplace ;
      private String Ddo_br_encounterid_Sortedstatus ;
      private String Ddo_br_encounterid_Filtertype ;
      private String Ddo_br_encounterid_Sortasc ;
      private String Ddo_br_encounterid_Sortdsc ;
      private String Ddo_br_encounterid_Cleanfilter ;
      private String Ddo_br_encounterid_Rangefilterfrom ;
      private String Ddo_br_encounterid_Rangefilterto ;
      private String Ddo_br_encounterid_Searchbuttontext ;
      private String Ddo_br_information_patientno_Caption ;
      private String Ddo_br_information_patientno_Tooltip ;
      private String Ddo_br_information_patientno_Cls ;
      private String Ddo_br_information_patientno_Filteredtext_set ;
      private String Ddo_br_information_patientno_Selectedvalue_set ;
      private String Ddo_br_information_patientno_Dropdownoptionstype ;
      private String Ddo_br_information_patientno_Titlecontrolidtoreplace ;
      private String Ddo_br_information_patientno_Sortedstatus ;
      private String Ddo_br_information_patientno_Filtertype ;
      private String Ddo_br_information_patientno_Datalisttype ;
      private String Ddo_br_information_patientno_Datalistproc ;
      private String Ddo_br_information_patientno_Sortasc ;
      private String Ddo_br_information_patientno_Sortdsc ;
      private String Ddo_br_information_patientno_Loadingdata ;
      private String Ddo_br_information_patientno_Cleanfilter ;
      private String Ddo_br_information_patientno_Noresultsfound ;
      private String Ddo_br_information_patientno_Searchbuttontext ;
      private String Ddo_br_procedure_pxid_Caption ;
      private String Ddo_br_procedure_pxid_Tooltip ;
      private String Ddo_br_procedure_pxid_Cls ;
      private String Ddo_br_procedure_pxid_Filteredtext_set ;
      private String Ddo_br_procedure_pxid_Filteredtextto_set ;
      private String Ddo_br_procedure_pxid_Dropdownoptionstype ;
      private String Ddo_br_procedure_pxid_Titlecontrolidtoreplace ;
      private String Ddo_br_procedure_pxid_Sortedstatus ;
      private String Ddo_br_procedure_pxid_Filtertype ;
      private String Ddo_br_procedure_pxid_Sortasc ;
      private String Ddo_br_procedure_pxid_Sortdsc ;
      private String Ddo_br_procedure_pxid_Cleanfilter ;
      private String Ddo_br_procedure_pxid_Rangefilterfrom ;
      private String Ddo_br_procedure_pxid_Rangefilterto ;
      private String Ddo_br_procedure_pxid_Searchbuttontext ;
      private String Ddo_br_procedure_pxsurgery_Caption ;
      private String Ddo_br_procedure_pxsurgery_Tooltip ;
      private String Ddo_br_procedure_pxsurgery_Cls ;
      private String Ddo_br_procedure_pxsurgery_Selectedvalue_set ;
      private String Ddo_br_procedure_pxsurgery_Dropdownoptionstype ;
      private String Ddo_br_procedure_pxsurgery_Titlecontrolidtoreplace ;
      private String Ddo_br_procedure_pxsurgery_Sortedstatus ;
      private String Ddo_br_procedure_pxsurgery_Datalisttype ;
      private String Ddo_br_procedure_pxsurgery_Datalistfixedvalues ;
      private String Ddo_br_procedure_pxsurgery_Sortasc ;
      private String Ddo_br_procedure_pxsurgery_Sortdsc ;
      private String Ddo_br_procedure_pxsurgery_Cleanfilter ;
      private String Ddo_br_procedure_pxsurgery_Searchbuttontext ;
      private String Ddo_br_procedure_date_Caption ;
      private String Ddo_br_procedure_date_Tooltip ;
      private String Ddo_br_procedure_date_Cls ;
      private String Ddo_br_procedure_date_Filteredtext_set ;
      private String Ddo_br_procedure_date_Filteredtextto_set ;
      private String Ddo_br_procedure_date_Dropdownoptionstype ;
      private String Ddo_br_procedure_date_Titlecontrolidtoreplace ;
      private String Ddo_br_procedure_date_Sortedstatus ;
      private String Ddo_br_procedure_date_Filtertype ;
      private String Ddo_br_procedure_date_Sortasc ;
      private String Ddo_br_procedure_date_Sortdsc ;
      private String Ddo_br_procedure_date_Cleanfilter ;
      private String Ddo_br_procedure_date_Rangefilterfrom ;
      private String Ddo_br_procedure_date_Rangefilterto ;
      private String Ddo_br_procedure_date_Searchbuttontext ;
      private String Ddo_br_procedure_pxradiotherapy_Caption ;
      private String Ddo_br_procedure_pxradiotherapy_Tooltip ;
      private String Ddo_br_procedure_pxradiotherapy_Cls ;
      private String Ddo_br_procedure_pxradiotherapy_Selectedvalue_set ;
      private String Ddo_br_procedure_pxradiotherapy_Dropdownoptionstype ;
      private String Ddo_br_procedure_pxradiotherapy_Titlecontrolidtoreplace ;
      private String Ddo_br_procedure_pxradiotherapy_Sortedstatus ;
      private String Ddo_br_procedure_pxradiotherapy_Datalisttype ;
      private String Ddo_br_procedure_pxradiotherapy_Datalistfixedvalues ;
      private String Ddo_br_procedure_pxradiotherapy_Sortasc ;
      private String Ddo_br_procedure_pxradiotherapy_Sortdsc ;
      private String Ddo_br_procedure_pxradiotherapy_Cleanfilter ;
      private String Ddo_br_procedure_pxradiotherapy_Searchbuttontext ;
      private String Ddo_br_procedure_radiodate_Caption ;
      private String Ddo_br_procedure_radiodate_Tooltip ;
      private String Ddo_br_procedure_radiodate_Cls ;
      private String Ddo_br_procedure_radiodate_Filteredtext_set ;
      private String Ddo_br_procedure_radiodate_Filteredtextto_set ;
      private String Ddo_br_procedure_radiodate_Dropdownoptionstype ;
      private String Ddo_br_procedure_radiodate_Titlecontrolidtoreplace ;
      private String Ddo_br_procedure_radiodate_Sortedstatus ;
      private String Ddo_br_procedure_radiodate_Filtertype ;
      private String Ddo_br_procedure_radiodate_Sortasc ;
      private String Ddo_br_procedure_radiodate_Sortdsc ;
      private String Ddo_br_procedure_radiodate_Cleanfilter ;
      private String Ddo_br_procedure_radiodate_Rangefilterfrom ;
      private String Ddo_br_procedure_radiodate_Rangefilterto ;
      private String Ddo_br_procedure_radiodate_Searchbuttontext ;
      private String Ddo_br_procedure_radiotime_Caption ;
      private String Ddo_br_procedure_radiotime_Tooltip ;
      private String Ddo_br_procedure_radiotime_Cls ;
      private String Ddo_br_procedure_radiotime_Filteredtext_set ;
      private String Ddo_br_procedure_radiotime_Filteredtextto_set ;
      private String Ddo_br_procedure_radiotime_Dropdownoptionstype ;
      private String Ddo_br_procedure_radiotime_Titlecontrolidtoreplace ;
      private String Ddo_br_procedure_radiotime_Sortedstatus ;
      private String Ddo_br_procedure_radiotime_Filtertype ;
      private String Ddo_br_procedure_radiotime_Sortasc ;
      private String Ddo_br_procedure_radiotime_Sortdsc ;
      private String Ddo_br_procedure_radiotime_Cleanfilter ;
      private String Ddo_br_procedure_radiotime_Rangefilterfrom ;
      private String Ddo_br_procedure_radiotime_Rangefilterto ;
      private String Ddo_br_procedure_radiotime_Searchbuttontext ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divLayoutmaintable_Internalname ;
      private String divTablemain_Internalname ;
      private String divHtml_dvpanel_tableheader_Internalname ;
      private String Dvpanel_tableheader_Internalname ;
      private String divLayout_tableheader_Internalname ;
      private String divTableheader_Internalname ;
      private String divTableactions_Internalname ;
      private String TempTags ;
      private String ClassString ;
      private String StyleString ;
      private String bttBtninsert_Internalname ;
      private String bttBtninsert_Jsonclick ;
      private String divGridtablewithpaginationbar_Internalname ;
      private String sStyleString ;
      private String subGrid_Internalname ;
      private String subGrid_Class ;
      private String subGrid_Linesclass ;
      private String edtBR_ProcedureID_Title ;
      private String edtBR_EncounterID_Title ;
      private String edtBR_Information_PatientNo_Title ;
      private String edtBR_Procedure_PXID_Title ;
      private String edtBR_Procedure_Date_Title ;
      private String edtBR_Procedure_RadioDate_Title ;
      private String edtBR_Procedure_RadioTime_Title ;
      private String subGrid_Header ;
      private String edtavDisplay_Link ;
      private String edtavDisplay_Tooltiptext ;
      private String edtavUpdate_Link ;
      private String edtavUpdate_Tooltiptext ;
      private String edtavDelete_Link ;
      private String edtavDelete_Tooltiptext ;
      private String edtBR_Information_PatientNo_Link ;
      private String divHtml_gridpaginationbar_Internalname ;
      private String Gridpaginationbar_Internalname ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String Ddo_br_procedureid_Internalname ;
      private String edtavDdo_br_procedureidtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_encounterid_Internalname ;
      private String edtavDdo_br_encounteridtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_information_patientno_Internalname ;
      private String edtavDdo_br_information_patientnotitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_procedure_pxid_Internalname ;
      private String edtavDdo_br_procedure_pxidtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_procedure_pxsurgery_Internalname ;
      private String edtavDdo_br_procedure_pxsurgerytitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_procedure_date_Internalname ;
      private String edtavDdo_br_procedure_datetitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_procedure_pxradiotherapy_Internalname ;
      private String edtavDdo_br_procedure_pxradiotherapytitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_procedure_radiodate_Internalname ;
      private String edtavDdo_br_procedure_radiodatetitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_procedure_radiotime_Internalname ;
      private String edtavDdo_br_procedure_radiotimetitlecontrolidtoreplace_Internalname ;
      private String Workwithplusutilities1_Internalname ;
      private String edtavOrderedby_Internalname ;
      private String edtavOrderedby_Jsonclick ;
      private String edtavOrdereddsc_Internalname ;
      private String edtavOrdereddsc_Jsonclick ;
      private String edtavTfbr_procedureid_Internalname ;
      private String edtavTfbr_procedureid_Jsonclick ;
      private String edtavTfbr_procedureid_to_Internalname ;
      private String edtavTfbr_procedureid_to_Jsonclick ;
      private String edtavTfbr_encounterid_Internalname ;
      private String edtavTfbr_encounterid_Jsonclick ;
      private String edtavTfbr_encounterid_to_Internalname ;
      private String edtavTfbr_encounterid_to_Jsonclick ;
      private String edtavTfbr_information_patientno_Internalname ;
      private String edtavTfbr_information_patientno_Jsonclick ;
      private String edtavTfbr_information_patientno_sel_Internalname ;
      private String edtavTfbr_information_patientno_sel_Jsonclick ;
      private String edtavTfbr_procedure_pxid_Internalname ;
      private String edtavTfbr_procedure_pxid_Jsonclick ;
      private String edtavTfbr_procedure_pxid_to_Internalname ;
      private String edtavTfbr_procedure_pxid_to_Jsonclick ;
      private String edtavTfbr_procedure_date_Internalname ;
      private String edtavTfbr_procedure_date_Jsonclick ;
      private String edtavTfbr_procedure_date_to_Internalname ;
      private String edtavTfbr_procedure_date_to_Jsonclick ;
      private String divDdo_br_procedure_dateauxdates_Internalname ;
      private String edtavDdo_br_procedure_dateauxdate_Internalname ;
      private String edtavDdo_br_procedure_dateauxdate_Jsonclick ;
      private String edtavDdo_br_procedure_dateauxdateto_Internalname ;
      private String edtavDdo_br_procedure_dateauxdateto_Jsonclick ;
      private String edtavTfbr_procedure_radiodate_Internalname ;
      private String edtavTfbr_procedure_radiodate_Jsonclick ;
      private String edtavTfbr_procedure_radiodate_to_Internalname ;
      private String edtavTfbr_procedure_radiodate_to_Jsonclick ;
      private String divDdo_br_procedure_radiodateauxdates_Internalname ;
      private String edtavDdo_br_procedure_radiodateauxdate_Internalname ;
      private String edtavDdo_br_procedure_radiodateauxdate_Jsonclick ;
      private String edtavDdo_br_procedure_radiodateauxdateto_Internalname ;
      private String edtavDdo_br_procedure_radiodateauxdateto_Jsonclick ;
      private String edtavTfbr_procedure_radiotime_Internalname ;
      private String edtavTfbr_procedure_radiotime_Jsonclick ;
      private String edtavTfbr_procedure_radiotime_to_Internalname ;
      private String edtavTfbr_procedure_radiotime_to_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavDisplay_Internalname ;
      private String edtavUpdate_Internalname ;
      private String edtavDelete_Internalname ;
      private String edtBR_ProcedureID_Internalname ;
      private String edtBR_EncounterID_Internalname ;
      private String edtBR_Information_PatientNo_Internalname ;
      private String edtBR_Procedure_PXID_Internalname ;
      private String cmbBR_Procedure_PXSurgery_Internalname ;
      private String edtBR_Procedure_Date_Internalname ;
      private String cmbBR_Procedure_PXRadiotherapy_Internalname ;
      private String edtBR_Procedure_RadioDate_Internalname ;
      private String edtBR_Procedure_RadioTime_Internalname ;
      private String scmdbuf ;
      private String sGXsfl_28_fel_idx="0001" ;
      private String sImgUrl ;
      private String ROClassString ;
      private String edtBR_ProcedureID_Jsonclick ;
      private String edtBR_EncounterID_Jsonclick ;
      private String edtBR_Information_PatientNo_Jsonclick ;
      private String edtBR_Procedure_PXID_Jsonclick ;
      private String GXCCtl ;
      private String cmbBR_Procedure_PXSurgery_Jsonclick ;
      private String edtBR_Procedure_Date_Jsonclick ;
      private String cmbBR_Procedure_PXRadiotherapy_Jsonclick ;
      private String edtBR_Procedure_RadioDate_Jsonclick ;
      private String edtBR_Procedure_RadioTime_Jsonclick ;
      private DateTime AV83TFBR_Procedure_Date ;
      private DateTime AV84TFBR_Procedure_Date_To ;
      private DateTime AV93TFBR_Procedure_RadioDate ;
      private DateTime AV94TFBR_Procedure_RadioDate_To ;
      private DateTime A266BR_Procedure_Date ;
      private DateTime A268BR_Procedure_RadioDate ;
      private DateTime AV85DDO_BR_Procedure_DateAuxDate ;
      private DateTime AV86DDO_BR_Procedure_DateAuxDateTo ;
      private DateTime AV95DDO_BR_Procedure_RadioDateAuxDate ;
      private DateTime AV96DDO_BR_Procedure_RadioDateAuxDateTo ;
      private DateTime AV114BR_ProcedureWWDS_10_Tfbr_procedure_date ;
      private DateTime AV115BR_ProcedureWWDS_11_Tfbr_procedure_date_to ;
      private DateTime AV117BR_ProcedureWWDS_13_Tfbr_procedure_radiodate ;
      private DateTime AV118BR_ProcedureWWDS_14_Tfbr_procedure_radiodate_to ;
      private bool entryPointCalled ;
      private bool AV14OrderedDsc ;
      private bool AV75IsAuthorized_Update ;
      private bool AV77IsAuthorized_Delete ;
      private bool AV78IsAuthorized_BR_Information_PatientNo ;
      private bool toggleJsOutput ;
      private bool Dvpanel_tableheader_Collapsible ;
      private bool Dvpanel_tableheader_Collapsed ;
      private bool Dvpanel_tableheader_Autowidth ;
      private bool Dvpanel_tableheader_Autoheight ;
      private bool Dvpanel_tableheader_Showcollapseicon ;
      private bool Dvpanel_tableheader_Autoscroll ;
      private bool Gridpaginationbar_Showfirst ;
      private bool Gridpaginationbar_Showprevious ;
      private bool Gridpaginationbar_Shownext ;
      private bool Gridpaginationbar_Showlast ;
      private bool Gridpaginationbar_Rowsperpageselector ;
      private bool Ddo_br_procedureid_Includesortasc ;
      private bool Ddo_br_procedureid_Includesortdsc ;
      private bool Ddo_br_procedureid_Includefilter ;
      private bool Ddo_br_procedureid_Filterisrange ;
      private bool Ddo_br_procedureid_Includedatalist ;
      private bool Ddo_br_encounterid_Includesortasc ;
      private bool Ddo_br_encounterid_Includesortdsc ;
      private bool Ddo_br_encounterid_Includefilter ;
      private bool Ddo_br_encounterid_Filterisrange ;
      private bool Ddo_br_encounterid_Includedatalist ;
      private bool Ddo_br_information_patientno_Includesortasc ;
      private bool Ddo_br_information_patientno_Includesortdsc ;
      private bool Ddo_br_information_patientno_Includefilter ;
      private bool Ddo_br_information_patientno_Filterisrange ;
      private bool Ddo_br_information_patientno_Includedatalist ;
      private bool Ddo_br_procedure_pxid_Includesortasc ;
      private bool Ddo_br_procedure_pxid_Includesortdsc ;
      private bool Ddo_br_procedure_pxid_Includefilter ;
      private bool Ddo_br_procedure_pxid_Filterisrange ;
      private bool Ddo_br_procedure_pxid_Includedatalist ;
      private bool Ddo_br_procedure_pxsurgery_Includesortasc ;
      private bool Ddo_br_procedure_pxsurgery_Includesortdsc ;
      private bool Ddo_br_procedure_pxsurgery_Includefilter ;
      private bool Ddo_br_procedure_pxsurgery_Includedatalist ;
      private bool Ddo_br_procedure_pxsurgery_Allowmultipleselection ;
      private bool Ddo_br_procedure_date_Includesortasc ;
      private bool Ddo_br_procedure_date_Includesortdsc ;
      private bool Ddo_br_procedure_date_Includefilter ;
      private bool Ddo_br_procedure_date_Filterisrange ;
      private bool Ddo_br_procedure_date_Includedatalist ;
      private bool Ddo_br_procedure_pxradiotherapy_Includesortasc ;
      private bool Ddo_br_procedure_pxradiotherapy_Includesortdsc ;
      private bool Ddo_br_procedure_pxradiotherapy_Includefilter ;
      private bool Ddo_br_procedure_pxradiotherapy_Includedatalist ;
      private bool Ddo_br_procedure_pxradiotherapy_Allowmultipleselection ;
      private bool Ddo_br_procedure_radiodate_Includesortasc ;
      private bool Ddo_br_procedure_radiodate_Includesortdsc ;
      private bool Ddo_br_procedure_radiodate_Includefilter ;
      private bool Ddo_br_procedure_radiodate_Filterisrange ;
      private bool Ddo_br_procedure_radiodate_Includedatalist ;
      private bool Ddo_br_procedure_radiotime_Includesortasc ;
      private bool Ddo_br_procedure_radiotime_Includesortdsc ;
      private bool Ddo_br_procedure_radiotime_Includefilter ;
      private bool Ddo_br_procedure_radiotime_Filterisrange ;
      private bool Ddo_br_procedure_radiotime_Includedatalist ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_28_Refreshing=false ;
      private bool n19BR_EncounterID ;
      private bool n36BR_Information_PatientNo ;
      private bool n140BR_Procedure_PXID ;
      private bool n141BR_Procedure_PXSurgery ;
      private bool n266BR_Procedure_Date ;
      private bool n143BR_Procedure_PXRadiotherapy ;
      private bool n268BR_Procedure_RadioDate ;
      private bool n269BR_Procedure_RadioTime ;
      private bool gxdyncontrolsrefreshing ;
      private bool n85BR_Information_ID ;
      private bool returnInSub ;
      private bool gx_refresh_fired ;
      private bool AV79TempBoolean ;
      private bool GXt_boolean1 ;
      private bool AV73Display_IsBlob ;
      private bool AV74Update_IsBlob ;
      private bool AV76Delete_IsBlob ;
      private String AV31TFBR_Procedure_PXSurgery_SelsJson ;
      private String AV39TFBR_Procedure_PXRadiotherapy_SelsJson ;
      private String AV23TFBR_Information_PatientNo ;
      private String AV24TFBR_Information_PatientNo_Sel ;
      private String AV17ddo_BR_ProcedureIDTitleControlIdToReplace ;
      private String AV21ddo_BR_EncounterIDTitleControlIdToReplace ;
      private String AV25ddo_BR_Information_PatientNoTitleControlIdToReplace ;
      private String AV29ddo_BR_Procedure_PXIDTitleControlIdToReplace ;
      private String AV33ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace ;
      private String AV87ddo_BR_Procedure_DateTitleControlIdToReplace ;
      private String AV41ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace ;
      private String AV97ddo_BR_Procedure_RadioDateTitleControlIdToReplace ;
      private String AV101ddo_BR_Procedure_RadioTimeTitleControlIdToReplace ;
      private String A36BR_Information_PatientNo ;
      private String A141BR_Procedure_PXSurgery ;
      private String A143BR_Procedure_PXRadiotherapy ;
      private String AV121Display_GXI ;
      private String AV122Update_GXI ;
      private String AV123Delete_GXI ;
      private String lV109BR_ProcedureWWDS_5_Tfbr_information_patientno ;
      private String AV110BR_ProcedureWWDS_6_Tfbr_information_patientno_sel ;
      private String AV109BR_ProcedureWWDS_5_Tfbr_information_patientno ;
      private String AV73Display ;
      private String AV74Update ;
      private String AV76Delete ;
      private IGxSession AV15Session ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private GXUserControl ucDvpanel_tableheader ;
      private GXUserControl ucGridpaginationbar ;
      private GXUserControl ucDdo_br_procedureid ;
      private GXUserControl ucDdo_br_encounterid ;
      private GXUserControl ucDdo_br_information_patientno ;
      private GXUserControl ucDdo_br_procedure_pxid ;
      private GXUserControl ucDdo_br_procedure_pxsurgery ;
      private GXUserControl ucDdo_br_procedure_date ;
      private GXUserControl ucDdo_br_procedure_pxradiotherapy ;
      private GXUserControl ucDdo_br_procedure_radiodate ;
      private GXUserControl ucDdo_br_procedure_radiotime ;
      private GXUserControl ucWorkwithplusutilities1 ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbBR_Procedure_PXSurgery ;
      private GXCombobox cmbBR_Procedure_PXRadiotherapy ;
      private IDataStoreProvider pr_default ;
      private long[] H003O2_A85BR_Information_ID ;
      private bool[] H003O2_n85BR_Information_ID ;
      private decimal[] H003O2_A269BR_Procedure_RadioTime ;
      private bool[] H003O2_n269BR_Procedure_RadioTime ;
      private DateTime[] H003O2_A268BR_Procedure_RadioDate ;
      private bool[] H003O2_n268BR_Procedure_RadioDate ;
      private String[] H003O2_A143BR_Procedure_PXRadiotherapy ;
      private bool[] H003O2_n143BR_Procedure_PXRadiotherapy ;
      private DateTime[] H003O2_A266BR_Procedure_Date ;
      private bool[] H003O2_n266BR_Procedure_Date ;
      private String[] H003O2_A141BR_Procedure_PXSurgery ;
      private bool[] H003O2_n141BR_Procedure_PXSurgery ;
      private long[] H003O2_A140BR_Procedure_PXID ;
      private bool[] H003O2_n140BR_Procedure_PXID ;
      private String[] H003O2_A36BR_Information_PatientNo ;
      private bool[] H003O2_n36BR_Information_PatientNo ;
      private long[] H003O2_A19BR_EncounterID ;
      private bool[] H003O2_n19BR_EncounterID ;
      private long[] H003O2_A139BR_ProcedureID ;
      private long[] H003O3_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV8HTTPRequest ;
      private GxSimpleCollection<String> AV32TFBR_Procedure_PXSurgery_Sels ;
      private GxSimpleCollection<String> AV40TFBR_Procedure_PXRadiotherapy_Sels ;
      private GxSimpleCollection<String> AV113BR_ProcedureWWDS_9_Tfbr_procedure_pxsurgery_sels ;
      private GxSimpleCollection<String> AV116BR_ProcedureWWDS_12_Tfbr_procedure_pxradiotherapy_sels ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV16BR_ProcedureIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV18BR_EncounterIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV22BR_Information_PatientNoTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV26BR_Procedure_PXIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV30BR_Procedure_PXSurgeryTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV82BR_Procedure_DateTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV38BR_Procedure_PXRadiotherapyTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV92BR_Procedure_RadioDateTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV98BR_Procedure_RadioTimeTitleFilterData ;
      private GXWebForm Form ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV9TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV11GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue AV12GridStateFilterValue ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons AV68DDO_TitleSettingsIcons ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 ;
   }

   public class br_procedureww__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H003O2( IGxContext context ,
                                             String A141BR_Procedure_PXSurgery ,
                                             GxSimpleCollection<String> AV113BR_ProcedureWWDS_9_Tfbr_procedure_pxsurgery_sels ,
                                             String A143BR_Procedure_PXRadiotherapy ,
                                             GxSimpleCollection<String> AV116BR_ProcedureWWDS_12_Tfbr_procedure_pxradiotherapy_sels ,
                                             long AV105BR_ProcedureWWDS_1_Tfbr_procedureid ,
                                             long AV106BR_ProcedureWWDS_2_Tfbr_procedureid_to ,
                                             long AV107BR_ProcedureWWDS_3_Tfbr_encounterid ,
                                             long AV108BR_ProcedureWWDS_4_Tfbr_encounterid_to ,
                                             String AV110BR_ProcedureWWDS_6_Tfbr_information_patientno_sel ,
                                             String AV109BR_ProcedureWWDS_5_Tfbr_information_patientno ,
                                             long AV111BR_ProcedureWWDS_7_Tfbr_procedure_pxid ,
                                             long AV112BR_ProcedureWWDS_8_Tfbr_procedure_pxid_to ,
                                             int AV113BR_ProcedureWWDS_9_Tfbr_procedure_pxsurgery_sels_Count ,
                                             DateTime AV114BR_ProcedureWWDS_10_Tfbr_procedure_date ,
                                             DateTime AV115BR_ProcedureWWDS_11_Tfbr_procedure_date_to ,
                                             int AV116BR_ProcedureWWDS_12_Tfbr_procedure_pxradiotherapy_sels_Count ,
                                             DateTime AV117BR_ProcedureWWDS_13_Tfbr_procedure_radiodate ,
                                             DateTime AV118BR_ProcedureWWDS_14_Tfbr_procedure_radiodate_to ,
                                             decimal AV119BR_ProcedureWWDS_15_Tfbr_procedure_radiotime ,
                                             decimal AV120BR_ProcedureWWDS_16_Tfbr_procedure_radiotime_to ,
                                             long A139BR_ProcedureID ,
                                             long A19BR_EncounterID ,
                                             String A36BR_Information_PatientNo ,
                                             long A140BR_Procedure_PXID ,
                                             DateTime A266BR_Procedure_Date ,
                                             DateTime A268BR_Procedure_RadioDate ,
                                             decimal A269BR_Procedure_RadioTime ,
                                             short AV13OrderedBy ,
                                             bool AV14OrderedDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int3 ;
         GXv_int3 = new short [17] ;
         Object[] GXv_Object4 ;
         GXv_Object4 = new Object [2] ;
         String sSelectString ;
         String sFromString ;
         String sOrderString ;
         sSelectString = " T2.[BR_Information_ID], T1.[BR_Procedure_RadioTime], T1.[BR_Procedure_RadioDate], T1.[BR_Procedure_PXRadiotherapy], T1.[BR_Procedure_Date], T1.[BR_Procedure_PXSurgery], T1.[BR_Procedure_PXID], T3.[BR_Information_PatientNo], T1.[BR_EncounterID], T1.[BR_ProcedureID]";
         sFromString = " FROM (([BR_Procedure] T1 WITH (NOLOCK) LEFT JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = T1.[BR_EncounterID]) LEFT JOIN [BR_Information] T3 WITH (NOLOCK) ON T3.[BR_Information_ID] = T2.[BR_Information_ID])";
         sOrderString = "";
         if ( ! (0==AV105BR_ProcedureWWDS_1_Tfbr_procedureid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_ProcedureID] >= @AV105BR_ProcedureWWDS_1_Tfbr_procedureid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_ProcedureID] >= @AV105BR_ProcedureWWDS_1_Tfbr_procedureid)";
            }
         }
         else
         {
            GXv_int3[0] = 1;
         }
         if ( ! (0==AV106BR_ProcedureWWDS_2_Tfbr_procedureid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_ProcedureID] <= @AV106BR_ProcedureWWDS_2_Tfbr_procedureid_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_ProcedureID] <= @AV106BR_ProcedureWWDS_2_Tfbr_procedureid_to)";
            }
         }
         else
         {
            GXv_int3[1] = 1;
         }
         if ( ! (0==AV107BR_ProcedureWWDS_3_Tfbr_encounterid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_EncounterID] >= @AV107BR_ProcedureWWDS_3_Tfbr_encounterid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_EncounterID] >= @AV107BR_ProcedureWWDS_3_Tfbr_encounterid)";
            }
         }
         else
         {
            GXv_int3[2] = 1;
         }
         if ( ! (0==AV108BR_ProcedureWWDS_4_Tfbr_encounterid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_EncounterID] <= @AV108BR_ProcedureWWDS_4_Tfbr_encounterid_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_EncounterID] <= @AV108BR_ProcedureWWDS_4_Tfbr_encounterid_to)";
            }
         }
         else
         {
            GXv_int3[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV110BR_ProcedureWWDS_6_Tfbr_information_patientno_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV109BR_ProcedureWWDS_5_Tfbr_information_patientno)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T3.[BR_Information_PatientNo] like @lV109BR_ProcedureWWDS_5_Tfbr_information_patientno)";
            }
            else
            {
               sWhereString = sWhereString + " (T3.[BR_Information_PatientNo] like @lV109BR_ProcedureWWDS_5_Tfbr_information_patientno)";
            }
         }
         else
         {
            GXv_int3[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV110BR_ProcedureWWDS_6_Tfbr_information_patientno_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T3.[BR_Information_PatientNo] = @AV110BR_ProcedureWWDS_6_Tfbr_information_patientno_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T3.[BR_Information_PatientNo] = @AV110BR_ProcedureWWDS_6_Tfbr_information_patientno_sel)";
            }
         }
         else
         {
            GXv_int3[5] = 1;
         }
         if ( ! (0==AV111BR_ProcedureWWDS_7_Tfbr_procedure_pxid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Procedure_PXID] >= @AV111BR_ProcedureWWDS_7_Tfbr_procedure_pxid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Procedure_PXID] >= @AV111BR_ProcedureWWDS_7_Tfbr_procedure_pxid)";
            }
         }
         else
         {
            GXv_int3[6] = 1;
         }
         if ( ! (0==AV112BR_ProcedureWWDS_8_Tfbr_procedure_pxid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Procedure_PXID] <= @AV112BR_ProcedureWWDS_8_Tfbr_procedure_pxid_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Procedure_PXID] <= @AV112BR_ProcedureWWDS_8_Tfbr_procedure_pxid_to)";
            }
         }
         else
         {
            GXv_int3[7] = 1;
         }
         if ( AV113BR_ProcedureWWDS_9_Tfbr_procedure_pxsurgery_sels_Count > 0 )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV113BR_ProcedureWWDS_9_Tfbr_procedure_pxsurgery_sels, "T1.[BR_Procedure_PXSurgery] IN (", ")") + ")";
            }
            else
            {
               sWhereString = sWhereString + " (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV113BR_ProcedureWWDS_9_Tfbr_procedure_pxsurgery_sels, "T1.[BR_Procedure_PXSurgery] IN (", ")") + ")";
            }
         }
         if ( ! (DateTime.MinValue==AV114BR_ProcedureWWDS_10_Tfbr_procedure_date) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Procedure_Date] >= @AV114BR_ProcedureWWDS_10_Tfbr_procedure_date)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Procedure_Date] >= @AV114BR_ProcedureWWDS_10_Tfbr_procedure_date)";
            }
         }
         else
         {
            GXv_int3[8] = 1;
         }
         if ( ! (DateTime.MinValue==AV115BR_ProcedureWWDS_11_Tfbr_procedure_date_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Procedure_Date] <= @AV115BR_ProcedureWWDS_11_Tfbr_procedure_date_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Procedure_Date] <= @AV115BR_ProcedureWWDS_11_Tfbr_procedure_date_to)";
            }
         }
         else
         {
            GXv_int3[9] = 1;
         }
         if ( AV116BR_ProcedureWWDS_12_Tfbr_procedure_pxradiotherapy_sels_Count > 0 )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV116BR_ProcedureWWDS_12_Tfbr_procedure_pxradiotherapy_sels, "T1.[BR_Procedure_PXRadiotherapy] IN (", ")") + ")";
            }
            else
            {
               sWhereString = sWhereString + " (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV116BR_ProcedureWWDS_12_Tfbr_procedure_pxradiotherapy_sels, "T1.[BR_Procedure_PXRadiotherapy] IN (", ")") + ")";
            }
         }
         if ( ! (DateTime.MinValue==AV117BR_ProcedureWWDS_13_Tfbr_procedure_radiodate) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Procedure_RadioDate] >= @AV117BR_ProcedureWWDS_13_Tfbr_procedure_radiodate)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Procedure_RadioDate] >= @AV117BR_ProcedureWWDS_13_Tfbr_procedure_radiodate)";
            }
         }
         else
         {
            GXv_int3[10] = 1;
         }
         if ( ! (DateTime.MinValue==AV118BR_ProcedureWWDS_14_Tfbr_procedure_radiodate_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Procedure_RadioDate] <= @AV118BR_ProcedureWWDS_14_Tfbr_procedure_radiodate_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Procedure_RadioDate] <= @AV118BR_ProcedureWWDS_14_Tfbr_procedure_radiodate_to)";
            }
         }
         else
         {
            GXv_int3[11] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV119BR_ProcedureWWDS_15_Tfbr_procedure_radiotime) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Procedure_RadioTime] >= @AV119BR_ProcedureWWDS_15_Tfbr_procedure_radiotime)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Procedure_RadioTime] >= @AV119BR_ProcedureWWDS_15_Tfbr_procedure_radiotime)";
            }
         }
         else
         {
            GXv_int3[12] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV120BR_ProcedureWWDS_16_Tfbr_procedure_radiotime_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Procedure_RadioTime] <= @AV120BR_ProcedureWWDS_16_Tfbr_procedure_radiotime_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Procedure_RadioTime] <= @AV120BR_ProcedureWWDS_16_Tfbr_procedure_radiotime_to)";
            }
         }
         else
         {
            GXv_int3[13] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            sWhereString = " WHERE" + sWhereString;
         }
         if ( ( AV13OrderedBy == 1 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_ProcedureID]";
         }
         else if ( ( AV13OrderedBy == 1 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_ProcedureID] DESC";
         }
         else if ( ( AV13OrderedBy == 2 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_EncounterID]";
         }
         else if ( ( AV13OrderedBy == 2 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_EncounterID] DESC";
         }
         else if ( ( AV13OrderedBy == 3 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T3.[BR_Information_PatientNo]";
         }
         else if ( ( AV13OrderedBy == 3 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T3.[BR_Information_PatientNo] DESC";
         }
         else if ( ( AV13OrderedBy == 4 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Procedure_PXID]";
         }
         else if ( ( AV13OrderedBy == 4 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Procedure_PXID] DESC";
         }
         else if ( ( AV13OrderedBy == 5 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Procedure_PXSurgery]";
         }
         else if ( ( AV13OrderedBy == 5 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Procedure_PXSurgery] DESC";
         }
         else if ( ( AV13OrderedBy == 6 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Procedure_Date]";
         }
         else if ( ( AV13OrderedBy == 6 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Procedure_Date] DESC";
         }
         else if ( ( AV13OrderedBy == 7 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Procedure_PXRadiotherapy]";
         }
         else if ( ( AV13OrderedBy == 7 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Procedure_PXRadiotherapy] DESC";
         }
         else if ( ( AV13OrderedBy == 8 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Procedure_RadioDate]";
         }
         else if ( ( AV13OrderedBy == 8 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Procedure_RadioDate] DESC";
         }
         else if ( ( AV13OrderedBy == 9 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Procedure_RadioTime]";
         }
         else if ( ( AV13OrderedBy == 9 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Procedure_RadioTime] DESC";
         }
         else if ( true )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_ProcedureID]";
         }
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object4[0] = scmdbuf;
         GXv_Object4[1] = GXv_int3;
         return GXv_Object4 ;
      }

      protected Object[] conditional_H003O3( IGxContext context ,
                                             String A141BR_Procedure_PXSurgery ,
                                             GxSimpleCollection<String> AV113BR_ProcedureWWDS_9_Tfbr_procedure_pxsurgery_sels ,
                                             String A143BR_Procedure_PXRadiotherapy ,
                                             GxSimpleCollection<String> AV116BR_ProcedureWWDS_12_Tfbr_procedure_pxradiotherapy_sels ,
                                             long AV105BR_ProcedureWWDS_1_Tfbr_procedureid ,
                                             long AV106BR_ProcedureWWDS_2_Tfbr_procedureid_to ,
                                             long AV107BR_ProcedureWWDS_3_Tfbr_encounterid ,
                                             long AV108BR_ProcedureWWDS_4_Tfbr_encounterid_to ,
                                             String AV110BR_ProcedureWWDS_6_Tfbr_information_patientno_sel ,
                                             String AV109BR_ProcedureWWDS_5_Tfbr_information_patientno ,
                                             long AV111BR_ProcedureWWDS_7_Tfbr_procedure_pxid ,
                                             long AV112BR_ProcedureWWDS_8_Tfbr_procedure_pxid_to ,
                                             int AV113BR_ProcedureWWDS_9_Tfbr_procedure_pxsurgery_sels_Count ,
                                             DateTime AV114BR_ProcedureWWDS_10_Tfbr_procedure_date ,
                                             DateTime AV115BR_ProcedureWWDS_11_Tfbr_procedure_date_to ,
                                             int AV116BR_ProcedureWWDS_12_Tfbr_procedure_pxradiotherapy_sels_Count ,
                                             DateTime AV117BR_ProcedureWWDS_13_Tfbr_procedure_radiodate ,
                                             DateTime AV118BR_ProcedureWWDS_14_Tfbr_procedure_radiodate_to ,
                                             decimal AV119BR_ProcedureWWDS_15_Tfbr_procedure_radiotime ,
                                             decimal AV120BR_ProcedureWWDS_16_Tfbr_procedure_radiotime_to ,
                                             long A139BR_ProcedureID ,
                                             long A19BR_EncounterID ,
                                             String A36BR_Information_PatientNo ,
                                             long A140BR_Procedure_PXID ,
                                             DateTime A266BR_Procedure_Date ,
                                             DateTime A268BR_Procedure_RadioDate ,
                                             decimal A269BR_Procedure_RadioTime ,
                                             short AV13OrderedBy ,
                                             bool AV14OrderedDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int5 ;
         GXv_int5 = new short [14] ;
         Object[] GXv_Object6 ;
         GXv_Object6 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM (([BR_Procedure] T1 WITH (NOLOCK) LEFT JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = T1.[BR_EncounterID]) LEFT JOIN [BR_Information] T3 WITH (NOLOCK) ON T3.[BR_Information_ID] = T2.[BR_Information_ID])";
         if ( ! (0==AV105BR_ProcedureWWDS_1_Tfbr_procedureid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_ProcedureID] >= @AV105BR_ProcedureWWDS_1_Tfbr_procedureid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_ProcedureID] >= @AV105BR_ProcedureWWDS_1_Tfbr_procedureid)";
            }
         }
         else
         {
            GXv_int5[0] = 1;
         }
         if ( ! (0==AV106BR_ProcedureWWDS_2_Tfbr_procedureid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_ProcedureID] <= @AV106BR_ProcedureWWDS_2_Tfbr_procedureid_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_ProcedureID] <= @AV106BR_ProcedureWWDS_2_Tfbr_procedureid_to)";
            }
         }
         else
         {
            GXv_int5[1] = 1;
         }
         if ( ! (0==AV107BR_ProcedureWWDS_3_Tfbr_encounterid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_EncounterID] >= @AV107BR_ProcedureWWDS_3_Tfbr_encounterid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_EncounterID] >= @AV107BR_ProcedureWWDS_3_Tfbr_encounterid)";
            }
         }
         else
         {
            GXv_int5[2] = 1;
         }
         if ( ! (0==AV108BR_ProcedureWWDS_4_Tfbr_encounterid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_EncounterID] <= @AV108BR_ProcedureWWDS_4_Tfbr_encounterid_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_EncounterID] <= @AV108BR_ProcedureWWDS_4_Tfbr_encounterid_to)";
            }
         }
         else
         {
            GXv_int5[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV110BR_ProcedureWWDS_6_Tfbr_information_patientno_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV109BR_ProcedureWWDS_5_Tfbr_information_patientno)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T3.[BR_Information_PatientNo] like @lV109BR_ProcedureWWDS_5_Tfbr_information_patientno)";
            }
            else
            {
               sWhereString = sWhereString + " (T3.[BR_Information_PatientNo] like @lV109BR_ProcedureWWDS_5_Tfbr_information_patientno)";
            }
         }
         else
         {
            GXv_int5[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV110BR_ProcedureWWDS_6_Tfbr_information_patientno_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T3.[BR_Information_PatientNo] = @AV110BR_ProcedureWWDS_6_Tfbr_information_patientno_sel)";
            }
            else
            {
               sWhereString = sWhereString + " (T3.[BR_Information_PatientNo] = @AV110BR_ProcedureWWDS_6_Tfbr_information_patientno_sel)";
            }
         }
         else
         {
            GXv_int5[5] = 1;
         }
         if ( ! (0==AV111BR_ProcedureWWDS_7_Tfbr_procedure_pxid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Procedure_PXID] >= @AV111BR_ProcedureWWDS_7_Tfbr_procedure_pxid)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Procedure_PXID] >= @AV111BR_ProcedureWWDS_7_Tfbr_procedure_pxid)";
            }
         }
         else
         {
            GXv_int5[6] = 1;
         }
         if ( ! (0==AV112BR_ProcedureWWDS_8_Tfbr_procedure_pxid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Procedure_PXID] <= @AV112BR_ProcedureWWDS_8_Tfbr_procedure_pxid_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Procedure_PXID] <= @AV112BR_ProcedureWWDS_8_Tfbr_procedure_pxid_to)";
            }
         }
         else
         {
            GXv_int5[7] = 1;
         }
         if ( AV113BR_ProcedureWWDS_9_Tfbr_procedure_pxsurgery_sels_Count > 0 )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV113BR_ProcedureWWDS_9_Tfbr_procedure_pxsurgery_sels, "T1.[BR_Procedure_PXSurgery] IN (", ")") + ")";
            }
            else
            {
               sWhereString = sWhereString + " (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV113BR_ProcedureWWDS_9_Tfbr_procedure_pxsurgery_sels, "T1.[BR_Procedure_PXSurgery] IN (", ")") + ")";
            }
         }
         if ( ! (DateTime.MinValue==AV114BR_ProcedureWWDS_10_Tfbr_procedure_date) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Procedure_Date] >= @AV114BR_ProcedureWWDS_10_Tfbr_procedure_date)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Procedure_Date] >= @AV114BR_ProcedureWWDS_10_Tfbr_procedure_date)";
            }
         }
         else
         {
            GXv_int5[8] = 1;
         }
         if ( ! (DateTime.MinValue==AV115BR_ProcedureWWDS_11_Tfbr_procedure_date_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Procedure_Date] <= @AV115BR_ProcedureWWDS_11_Tfbr_procedure_date_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Procedure_Date] <= @AV115BR_ProcedureWWDS_11_Tfbr_procedure_date_to)";
            }
         }
         else
         {
            GXv_int5[9] = 1;
         }
         if ( AV116BR_ProcedureWWDS_12_Tfbr_procedure_pxradiotherapy_sels_Count > 0 )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV116BR_ProcedureWWDS_12_Tfbr_procedure_pxradiotherapy_sels, "T1.[BR_Procedure_PXRadiotherapy] IN (", ")") + ")";
            }
            else
            {
               sWhereString = sWhereString + " (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV116BR_ProcedureWWDS_12_Tfbr_procedure_pxradiotherapy_sels, "T1.[BR_Procedure_PXRadiotherapy] IN (", ")") + ")";
            }
         }
         if ( ! (DateTime.MinValue==AV117BR_ProcedureWWDS_13_Tfbr_procedure_radiodate) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Procedure_RadioDate] >= @AV117BR_ProcedureWWDS_13_Tfbr_procedure_radiodate)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Procedure_RadioDate] >= @AV117BR_ProcedureWWDS_13_Tfbr_procedure_radiodate)";
            }
         }
         else
         {
            GXv_int5[10] = 1;
         }
         if ( ! (DateTime.MinValue==AV118BR_ProcedureWWDS_14_Tfbr_procedure_radiodate_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Procedure_RadioDate] <= @AV118BR_ProcedureWWDS_14_Tfbr_procedure_radiodate_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Procedure_RadioDate] <= @AV118BR_ProcedureWWDS_14_Tfbr_procedure_radiodate_to)";
            }
         }
         else
         {
            GXv_int5[11] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV119BR_ProcedureWWDS_15_Tfbr_procedure_radiotime) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Procedure_RadioTime] >= @AV119BR_ProcedureWWDS_15_Tfbr_procedure_radiotime)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Procedure_RadioTime] >= @AV119BR_ProcedureWWDS_15_Tfbr_procedure_radiotime)";
            }
         }
         else
         {
            GXv_int5[12] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV120BR_ProcedureWWDS_16_Tfbr_procedure_radiotime_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (T1.[BR_Procedure_RadioTime] <= @AV120BR_ProcedureWWDS_16_Tfbr_procedure_radiotime_to)";
            }
            else
            {
               sWhereString = sWhereString + " (T1.[BR_Procedure_RadioTime] <= @AV120BR_ProcedureWWDS_16_Tfbr_procedure_radiotime_to)";
            }
         }
         else
         {
            GXv_int5[13] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE" + sWhereString;
         }
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
         GXv_Object6[0] = scmdbuf;
         GXv_Object6[1] = GXv_int5;
         return GXv_Object6 ;
      }

      public override Object [] getDynamicStatement( int cursor ,
                                                     IGxContext context ,
                                                     Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 0 :
                     return conditional_H003O2(context, (String)dynConstraints[0] , (GxSimpleCollection<String>)dynConstraints[1] , (String)dynConstraints[2] , (GxSimpleCollection<String>)dynConstraints[3] , (long)dynConstraints[4] , (long)dynConstraints[5] , (long)dynConstraints[6] , (long)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (long)dynConstraints[10] , (long)dynConstraints[11] , (int)dynConstraints[12] , (DateTime)dynConstraints[13] , (DateTime)dynConstraints[14] , (int)dynConstraints[15] , (DateTime)dynConstraints[16] , (DateTime)dynConstraints[17] , (decimal)dynConstraints[18] , (decimal)dynConstraints[19] , (long)dynConstraints[20] , (long)dynConstraints[21] , (String)dynConstraints[22] , (long)dynConstraints[23] , (DateTime)dynConstraints[24] , (DateTime)dynConstraints[25] , (decimal)dynConstraints[26] , (short)dynConstraints[27] , (bool)dynConstraints[28] );
               case 1 :
                     return conditional_H003O3(context, (String)dynConstraints[0] , (GxSimpleCollection<String>)dynConstraints[1] , (String)dynConstraints[2] , (GxSimpleCollection<String>)dynConstraints[3] , (long)dynConstraints[4] , (long)dynConstraints[5] , (long)dynConstraints[6] , (long)dynConstraints[7] , (String)dynConstraints[8] , (String)dynConstraints[9] , (long)dynConstraints[10] , (long)dynConstraints[11] , (int)dynConstraints[12] , (DateTime)dynConstraints[13] , (DateTime)dynConstraints[14] , (int)dynConstraints[15] , (DateTime)dynConstraints[16] , (DateTime)dynConstraints[17] , (decimal)dynConstraints[18] , (decimal)dynConstraints[19] , (long)dynConstraints[20] , (long)dynConstraints[21] , (String)dynConstraints[22] , (long)dynConstraints[23] , (DateTime)dynConstraints[24] , (DateTime)dynConstraints[25] , (decimal)dynConstraints[26] , (short)dynConstraints[27] , (bool)dynConstraints[28] );
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
          Object[] prmH003O2 ;
          prmH003O2 = new Object[] {
          new Object[] {"@AV105BR_ProcedureWWDS_1_Tfbr_procedureid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV106BR_ProcedureWWDS_2_Tfbr_procedureid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV107BR_ProcedureWWDS_3_Tfbr_encounterid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV108BR_ProcedureWWDS_4_Tfbr_encounterid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV109BR_ProcedureWWDS_5_Tfbr_information_patientno",SqlDbType.NVarChar,2000,0} ,
          new Object[] {"@AV110BR_ProcedureWWDS_6_Tfbr_information_patientno_sel",SqlDbType.NVarChar,2000,0} ,
          new Object[] {"@AV111BR_ProcedureWWDS_7_Tfbr_procedure_pxid",SqlDbType.Decimal,10,0} ,
          new Object[] {"@AV112BR_ProcedureWWDS_8_Tfbr_procedure_pxid_to",SqlDbType.Decimal,10,0} ,
          new Object[] {"@AV114BR_ProcedureWWDS_10_Tfbr_procedure_date",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV115BR_ProcedureWWDS_11_Tfbr_procedure_date_to",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV117BR_ProcedureWWDS_13_Tfbr_procedure_radiodate",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV118BR_ProcedureWWDS_14_Tfbr_procedure_radiodate_to",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV119BR_ProcedureWWDS_15_Tfbr_procedure_radiotime",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV120BR_ProcedureWWDS_16_Tfbr_procedure_radiotime_to",SqlDbType.Decimal,15,5} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH003O3 ;
          prmH003O3 = new Object[] {
          new Object[] {"@AV105BR_ProcedureWWDS_1_Tfbr_procedureid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV106BR_ProcedureWWDS_2_Tfbr_procedureid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV107BR_ProcedureWWDS_3_Tfbr_encounterid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV108BR_ProcedureWWDS_4_Tfbr_encounterid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV109BR_ProcedureWWDS_5_Tfbr_information_patientno",SqlDbType.NVarChar,2000,0} ,
          new Object[] {"@AV110BR_ProcedureWWDS_6_Tfbr_information_patientno_sel",SqlDbType.NVarChar,2000,0} ,
          new Object[] {"@AV111BR_ProcedureWWDS_7_Tfbr_procedure_pxid",SqlDbType.Decimal,10,0} ,
          new Object[] {"@AV112BR_ProcedureWWDS_8_Tfbr_procedure_pxid_to",SqlDbType.Decimal,10,0} ,
          new Object[] {"@AV114BR_ProcedureWWDS_10_Tfbr_procedure_date",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV115BR_ProcedureWWDS_11_Tfbr_procedure_date_to",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV117BR_ProcedureWWDS_13_Tfbr_procedure_radiodate",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV118BR_ProcedureWWDS_14_Tfbr_procedure_radiodate_to",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV119BR_ProcedureWWDS_15_Tfbr_procedure_radiotime",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV120BR_ProcedureWWDS_16_Tfbr_procedure_radiotime_to",SqlDbType.Decimal,15,5}
          } ;
          def= new CursorDef[] {
              new CursorDef("H003O2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH003O2,11,0,true,false )
             ,new CursorDef("H003O3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH003O3,1,0,true,false )
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
                ((decimal[]) buf[2])[0] = rslt.getDecimal(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((DateTime[]) buf[4])[0] = rslt.getGXDate(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((String[]) buf[6])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((DateTime[]) buf[8])[0] = rslt.getGXDate(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((String[]) buf[10])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(6);
                ((long[]) buf[12])[0] = rslt.getLong(7) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(7);
                ((String[]) buf[14])[0] = rslt.getVarchar(8) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(8);
                ((long[]) buf[16])[0] = rslt.getLong(9) ;
                ((bool[]) buf[17])[0] = rslt.wasNull(9);
                ((long[]) buf[18])[0] = rslt.getLong(10) ;
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
                   stmt.SetParameter(sIdx, (long)parms[17]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[18]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[19]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[20]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[21]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[22]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[23]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[24]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[25]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[26]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[27]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[28]);
                }
                if ( (short)parms[12] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[29]);
                }
                if ( (short)parms[13] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[30]);
                }
                if ( (short)parms[14] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[31]);
                }
                if ( (short)parms[15] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[32]);
                }
                if ( (short)parms[16] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[33]);
                }
                return;
             case 1 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[14]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[15]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[16]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[17]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[18]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[19]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[20]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[21]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[22]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[23]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[24]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[25]);
                }
                if ( (short)parms[12] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[26]);
                }
                if ( (short)parms[13] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[27]);
                }
                return;
       }
    }

 }

}
