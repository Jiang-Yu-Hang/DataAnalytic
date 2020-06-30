/*
               File: BR_Encounter_RefuseReasonWW
        Description:  就诊信息驳回原因
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:16:10.33
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
   public class br_encounter_refusereasonww : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public br_encounter_refusereasonww( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_encounter_refusereasonww( IGxContext context )
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
         cmbBR_Encounter_RefuseReason_Status = new GXCombobox();
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
               nRC_GXsfl_31 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               nGXsfl_31_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
               sGXsfl_31_idx = GetNextPar( );
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
               AV17TFBR_Encounter_RefuseReasonID = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV18TFBR_Encounter_RefuseReasonID_To = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV21TFBR_EncounterID = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV22TFBR_EncounterID_To = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV25TFBR_Encounter_RefuseReason_Reason = GetNextPar( );
               AV26TFBR_Encounter_RefuseReason_Reason_Sel = GetNextPar( );
               AV29TFBR_Encounter_RefuseReason_NoApproveDate = context.localUtil.ParseDTimeParm( GetNextPar( ));
               AV30TFBR_Encounter_RefuseReason_NoApproveDate_To = context.localUtil.ParseDTimeParm( GetNextPar( ));
               AV19ddo_BR_Encounter_RefuseReasonIDTitleControlIdToReplace = GetNextPar( );
               AV23ddo_BR_EncounterIDTitleControlIdToReplace = GetNextPar( );
               AV27ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace = GetNextPar( );
               AV33ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace = GetNextPar( );
               AV37ddo_BR_Encounter_RefuseReason_StatusTitleControlIdToReplace = GetNextPar( );
               ajax_req_read_hidden_sdt(GetNextPar( ), AV36TFBR_Encounter_RefuseReason_Status_Sels);
               AV63Pgmname = GetNextPar( );
               AV45IsAuthorized_Update = StringUtil.StrToBool( GetNextPar( ));
               AV47IsAuthorized_Delete = StringUtil.StrToBool( GetNextPar( ));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV17TFBR_Encounter_RefuseReasonID, AV18TFBR_Encounter_RefuseReasonID_To, AV21TFBR_EncounterID, AV22TFBR_EncounterID_To, AV25TFBR_Encounter_RefuseReason_Reason, AV26TFBR_Encounter_RefuseReason_Reason_Sel, AV29TFBR_Encounter_RefuseReason_NoApproveDate, AV30TFBR_Encounter_RefuseReason_NoApproveDate_To, AV19ddo_BR_Encounter_RefuseReasonIDTitleControlIdToReplace, AV23ddo_BR_EncounterIDTitleControlIdToReplace, AV27ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace, AV33ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace, AV37ddo_BR_Encounter_RefuseReason_StatusTitleControlIdToReplace, AV36TFBR_Encounter_RefuseReason_Status_Sels, AV63Pgmname, AV45IsAuthorized_Update, AV47IsAuthorized_Delete) ;
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
         PA7C2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START7C2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?202022815161054", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_encounter_refusereasonww.aspx") +"\">") ;
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
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_ENCOUNTER_REFUSEREASONID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV17TFBR_Encounter_RefuseReasonID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_ENCOUNTER_REFUSEREASONID_TO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV18TFBR_Encounter_RefuseReasonID_To), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_ENCOUNTERID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV21TFBR_EncounterID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_ENCOUNTERID_TO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV22TFBR_EncounterID_To), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_ENCOUNTER_REFUSEREASON_REASON", AV25TFBR_Encounter_RefuseReason_Reason);
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_ENCOUNTER_REFUSEREASON_REASON_SEL", AV26TFBR_Encounter_RefuseReason_Reason_Sel);
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE", context.localUtil.TToC( AV29TFBR_Encounter_RefuseReason_NoApproveDate, 10, 8, 0, 0, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_TO", context.localUtil.TToC( AV30TFBR_Encounter_RefuseReason_NoApproveDate_To, 10, 8, 0, 0, "/", ":", " "));
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_31", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_31), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDCURRENTPAGE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV40GridCurrentPage), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDRECORDCOUNT", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV42GridRecordCount), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDPAGESIZE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV41GridPageSize), 10, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vDDO_TITLESETTINGSICONS", AV38DDO_TitleSettingsIcons);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vDDO_TITLESETTINGSICONS", AV38DDO_TitleSettingsIcons);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_ENCOUNTER_REFUSEREASONIDTITLEFILTERDATA", AV16BR_Encounter_RefuseReasonIDTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_ENCOUNTER_REFUSEREASONIDTITLEFILTERDATA", AV16BR_Encounter_RefuseReasonIDTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_ENCOUNTERIDTITLEFILTERDATA", AV20BR_EncounterIDTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_ENCOUNTERIDTITLEFILTERDATA", AV20BR_EncounterIDTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_ENCOUNTER_REFUSEREASON_REASONTITLEFILTERDATA", AV24BR_Encounter_RefuseReason_ReasonTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_ENCOUNTER_REFUSEREASON_REASONTITLEFILTERDATA", AV24BR_Encounter_RefuseReason_ReasonTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATETITLEFILTERDATA", AV28BR_Encounter_RefuseReason_NoApproveDateTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATETITLEFILTERDATA", AV28BR_Encounter_RefuseReason_NoApproveDateTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_ENCOUNTER_REFUSEREASON_STATUSTITLEFILTERDATA", AV34BR_Encounter_RefuseReason_StatusTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_ENCOUNTER_REFUSEREASON_STATUSTITLEFILTERDATA", AV34BR_Encounter_RefuseReason_StatusTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vTFBR_ENCOUNTER_REFUSEREASON_STATUS_SELS", AV36TFBR_Encounter_RefuseReason_Status_Sels);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vTFBR_ENCOUNTER_REFUSEREASON_STATUS_SELS", AV36TFBR_Encounter_RefuseReason_Status_Sels);
         }
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV63Pgmname));
         GxWebStd.gx_boolean_hidden_field( context, "vISAUTHORIZED_UPDATE", AV45IsAuthorized_Update);
         GxWebStd.gx_boolean_hidden_field( context, "vISAUTHORIZED_DELETE", AV47IsAuthorized_Delete);
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
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASONID_Caption", StringUtil.RTrim( Ddo_br_encounter_refusereasonid_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASONID_Tooltip", StringUtil.RTrim( Ddo_br_encounter_refusereasonid_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASONID_Cls", StringUtil.RTrim( Ddo_br_encounter_refusereasonid_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASONID_Filteredtext_set", StringUtil.RTrim( Ddo_br_encounter_refusereasonid_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASONID_Filteredtextto_set", StringUtil.RTrim( Ddo_br_encounter_refusereasonid_Filteredtextto_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASONID_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_encounter_refusereasonid_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASONID_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_encounter_refusereasonid_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASONID_Includesortasc", StringUtil.BoolToStr( Ddo_br_encounter_refusereasonid_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASONID_Includesortdsc", StringUtil.BoolToStr( Ddo_br_encounter_refusereasonid_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASONID_Sortedstatus", StringUtil.RTrim( Ddo_br_encounter_refusereasonid_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASONID_Includefilter", StringUtil.BoolToStr( Ddo_br_encounter_refusereasonid_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASONID_Filtertype", StringUtil.RTrim( Ddo_br_encounter_refusereasonid_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASONID_Filterisrange", StringUtil.BoolToStr( Ddo_br_encounter_refusereasonid_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASONID_Includedatalist", StringUtil.BoolToStr( Ddo_br_encounter_refusereasonid_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASONID_Sortasc", StringUtil.RTrim( Ddo_br_encounter_refusereasonid_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASONID_Sortdsc", StringUtil.RTrim( Ddo_br_encounter_refusereasonid_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASONID_Cleanfilter", StringUtil.RTrim( Ddo_br_encounter_refusereasonid_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASONID_Rangefilterfrom", StringUtil.RTrim( Ddo_br_encounter_refusereasonid_Rangefilterfrom));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASONID_Rangefilterto", StringUtil.RTrim( Ddo_br_encounter_refusereasonid_Rangefilterto));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASONID_Searchbuttontext", StringUtil.RTrim( Ddo_br_encounter_refusereasonid_Searchbuttontext));
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
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_REASON_Caption", StringUtil.RTrim( Ddo_br_encounter_refusereason_reason_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_REASON_Tooltip", StringUtil.RTrim( Ddo_br_encounter_refusereason_reason_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_REASON_Cls", StringUtil.RTrim( Ddo_br_encounter_refusereason_reason_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_REASON_Filteredtext_set", StringUtil.RTrim( Ddo_br_encounter_refusereason_reason_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_REASON_Selectedvalue_set", StringUtil.RTrim( Ddo_br_encounter_refusereason_reason_Selectedvalue_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_REASON_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_encounter_refusereason_reason_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_REASON_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_encounter_refusereason_reason_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_REASON_Includesortasc", StringUtil.BoolToStr( Ddo_br_encounter_refusereason_reason_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_REASON_Includesortdsc", StringUtil.BoolToStr( Ddo_br_encounter_refusereason_reason_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_REASON_Sortedstatus", StringUtil.RTrim( Ddo_br_encounter_refusereason_reason_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_REASON_Includefilter", StringUtil.BoolToStr( Ddo_br_encounter_refusereason_reason_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_REASON_Filtertype", StringUtil.RTrim( Ddo_br_encounter_refusereason_reason_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_REASON_Filterisrange", StringUtil.BoolToStr( Ddo_br_encounter_refusereason_reason_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_REASON_Includedatalist", StringUtil.BoolToStr( Ddo_br_encounter_refusereason_reason_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_REASON_Datalisttype", StringUtil.RTrim( Ddo_br_encounter_refusereason_reason_Datalisttype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_REASON_Datalistproc", StringUtil.RTrim( Ddo_br_encounter_refusereason_reason_Datalistproc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_REASON_Datalistupdateminimumcharacters", StringUtil.LTrim( StringUtil.NToC( (decimal)(Ddo_br_encounter_refusereason_reason_Datalistupdateminimumcharacters), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_REASON_Sortasc", StringUtil.RTrim( Ddo_br_encounter_refusereason_reason_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_REASON_Sortdsc", StringUtil.RTrim( Ddo_br_encounter_refusereason_reason_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_REASON_Loadingdata", StringUtil.RTrim( Ddo_br_encounter_refusereason_reason_Loadingdata));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_REASON_Cleanfilter", StringUtil.RTrim( Ddo_br_encounter_refusereason_reason_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_REASON_Noresultsfound", StringUtil.RTrim( Ddo_br_encounter_refusereason_reason_Noresultsfound));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_REASON_Searchbuttontext", StringUtil.RTrim( Ddo_br_encounter_refusereason_reason_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_Caption", StringUtil.RTrim( Ddo_br_encounter_refusereason_noapprovedate_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_Tooltip", StringUtil.RTrim( Ddo_br_encounter_refusereason_noapprovedate_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_Cls", StringUtil.RTrim( Ddo_br_encounter_refusereason_noapprovedate_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_Filteredtext_set", StringUtil.RTrim( Ddo_br_encounter_refusereason_noapprovedate_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_Filteredtextto_set", StringUtil.RTrim( Ddo_br_encounter_refusereason_noapprovedate_Filteredtextto_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_encounter_refusereason_noapprovedate_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_encounter_refusereason_noapprovedate_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_Includesortasc", StringUtil.BoolToStr( Ddo_br_encounter_refusereason_noapprovedate_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_Includesortdsc", StringUtil.BoolToStr( Ddo_br_encounter_refusereason_noapprovedate_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_Sortedstatus", StringUtil.RTrim( Ddo_br_encounter_refusereason_noapprovedate_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_Includefilter", StringUtil.BoolToStr( Ddo_br_encounter_refusereason_noapprovedate_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_Filtertype", StringUtil.RTrim( Ddo_br_encounter_refusereason_noapprovedate_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_Filterisrange", StringUtil.BoolToStr( Ddo_br_encounter_refusereason_noapprovedate_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_Includedatalist", StringUtil.BoolToStr( Ddo_br_encounter_refusereason_noapprovedate_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_Sortasc", StringUtil.RTrim( Ddo_br_encounter_refusereason_noapprovedate_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_Sortdsc", StringUtil.RTrim( Ddo_br_encounter_refusereason_noapprovedate_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_Cleanfilter", StringUtil.RTrim( Ddo_br_encounter_refusereason_noapprovedate_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_Rangefilterfrom", StringUtil.RTrim( Ddo_br_encounter_refusereason_noapprovedate_Rangefilterfrom));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_Rangefilterto", StringUtil.RTrim( Ddo_br_encounter_refusereason_noapprovedate_Rangefilterto));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_Searchbuttontext", StringUtil.RTrim( Ddo_br_encounter_refusereason_noapprovedate_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_STATUS_Caption", StringUtil.RTrim( Ddo_br_encounter_refusereason_status_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_STATUS_Tooltip", StringUtil.RTrim( Ddo_br_encounter_refusereason_status_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_STATUS_Cls", StringUtil.RTrim( Ddo_br_encounter_refusereason_status_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_STATUS_Selectedvalue_set", StringUtil.RTrim( Ddo_br_encounter_refusereason_status_Selectedvalue_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_STATUS_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_encounter_refusereason_status_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_STATUS_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_encounter_refusereason_status_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_STATUS_Includesortasc", StringUtil.BoolToStr( Ddo_br_encounter_refusereason_status_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_STATUS_Includesortdsc", StringUtil.BoolToStr( Ddo_br_encounter_refusereason_status_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_STATUS_Sortedstatus", StringUtil.RTrim( Ddo_br_encounter_refusereason_status_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_STATUS_Includefilter", StringUtil.BoolToStr( Ddo_br_encounter_refusereason_status_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_STATUS_Includedatalist", StringUtil.BoolToStr( Ddo_br_encounter_refusereason_status_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_STATUS_Datalisttype", StringUtil.RTrim( Ddo_br_encounter_refusereason_status_Datalisttype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_STATUS_Allowmultipleselection", StringUtil.BoolToStr( Ddo_br_encounter_refusereason_status_Allowmultipleselection));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_STATUS_Datalistfixedvalues", StringUtil.RTrim( Ddo_br_encounter_refusereason_status_Datalistfixedvalues));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_STATUS_Sortasc", StringUtil.RTrim( Ddo_br_encounter_refusereason_status_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_STATUS_Sortdsc", StringUtil.RTrim( Ddo_br_encounter_refusereason_status_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_STATUS_Cleanfilter", StringUtil.RTrim( Ddo_br_encounter_refusereason_status_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_STATUS_Searchbuttontext", StringUtil.RTrim( Ddo_br_encounter_refusereason_status_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASONID_Activeeventkey", StringUtil.RTrim( Ddo_br_encounter_refusereasonid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASONID_Filteredtext_get", StringUtil.RTrim( Ddo_br_encounter_refusereasonid_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASONID_Filteredtextto_get", StringUtil.RTrim( Ddo_br_encounter_refusereasonid_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Activeeventkey", StringUtil.RTrim( Ddo_br_encounterid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Filteredtext_get", StringUtil.RTrim( Ddo_br_encounterid_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Filteredtextto_get", StringUtil.RTrim( Ddo_br_encounterid_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_REASON_Activeeventkey", StringUtil.RTrim( Ddo_br_encounter_refusereason_reason_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_REASON_Filteredtext_get", StringUtil.RTrim( Ddo_br_encounter_refusereason_reason_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_REASON_Selectedvalue_get", StringUtil.RTrim( Ddo_br_encounter_refusereason_reason_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_Activeeventkey", StringUtil.RTrim( Ddo_br_encounter_refusereason_noapprovedate_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_Filteredtext_get", StringUtil.RTrim( Ddo_br_encounter_refusereason_noapprovedate_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_Filteredtextto_get", StringUtil.RTrim( Ddo_br_encounter_refusereason_noapprovedate_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_STATUS_Activeeventkey", StringUtil.RTrim( Ddo_br_encounter_refusereason_status_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_STATUS_Selectedvalue_get", StringUtil.RTrim( Ddo_br_encounter_refusereason_status_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASONID_Activeeventkey", StringUtil.RTrim( Ddo_br_encounter_refusereasonid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASONID_Filteredtext_get", StringUtil.RTrim( Ddo_br_encounter_refusereasonid_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASONID_Filteredtextto_get", StringUtil.RTrim( Ddo_br_encounter_refusereasonid_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Activeeventkey", StringUtil.RTrim( Ddo_br_encounterid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Filteredtext_get", StringUtil.RTrim( Ddo_br_encounterid_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Filteredtextto_get", StringUtil.RTrim( Ddo_br_encounterid_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_REASON_Activeeventkey", StringUtil.RTrim( Ddo_br_encounter_refusereason_reason_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_REASON_Filteredtext_get", StringUtil.RTrim( Ddo_br_encounter_refusereason_reason_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_REASON_Selectedvalue_get", StringUtil.RTrim( Ddo_br_encounter_refusereason_reason_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_Activeeventkey", StringUtil.RTrim( Ddo_br_encounter_refusereason_noapprovedate_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_Filteredtext_get", StringUtil.RTrim( Ddo_br_encounter_refusereason_noapprovedate_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_Filteredtextto_get", StringUtil.RTrim( Ddo_br_encounter_refusereason_noapprovedate_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_STATUS_Activeeventkey", StringUtil.RTrim( Ddo_br_encounter_refusereason_status_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_STATUS_Selectedvalue_get", StringUtil.RTrim( Ddo_br_encounter_refusereason_status_Selectedvalue_get));
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
            WE7C2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT7C2( ) ;
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
         return formatLink("br_encounter_refusereasonww.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "BR_Encounter_RefuseReasonWW" ;
      }

      public override String GetPgmdesc( )
      {
         return " 就诊信息驳回原因" ;
      }

      protected void WB7C0( )
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
            GxWebStd.gx_button_ctrl( context, bttBtninsert_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(31), 2, 0)+","+"null"+");", "插入", bttBtninsert_Jsonclick, 5, "插入", "", StyleString, ClassString, bttBtninsert_Visible, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'DOINSERT\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_Encounter_RefuseReasonWW.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            ClassString = "ErrorViewer";
            StyleString = "";
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, "", "false");
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
               context.WriteHtmlText( "<div id=\""+"GridContainer"+"DivS\" data-gxgridid=\"31\">") ;
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
               if ( edtBR_Encounter_RefuseReasonID_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Encounter_RefuseReasonID_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Encounter_RefuseReasonID_Title) ;
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
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Encounter_RefuseReason_Reason_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Encounter_RefuseReason_Reason_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Encounter_RefuseReason_Reason_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Encounter_RefuseReason_NoApproveDate_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Encounter_RefuseReason_NoApproveDate_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Encounter_RefuseReason_NoApproveDate_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( cmbBR_Encounter_RefuseReason_Status_Titleformat == 0 )
               {
                  context.SendWebValue( cmbBR_Encounter_RefuseReason_Status.Title.Text) ;
               }
               else
               {
                  context.WriteHtmlText( cmbBR_Encounter_RefuseReason_Status.Title.Text) ;
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
               GridColumn.AddObjectProperty("Value", context.convertURL( AV43Display));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavDisplay_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavDisplay_Tooltiptext));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.convertURL( AV44Update));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavUpdate_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavUpdate_Tooltiptext));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavUpdate_Visible), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.convertURL( AV46Delete));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavDelete_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavDelete_Tooltiptext));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavDelete_Visible), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A348BR_Encounter_RefuseReasonID), 18, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Encounter_RefuseReasonID_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Encounter_RefuseReasonID_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A19BR_EncounterID), 18, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_EncounterID_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_EncounterID_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A349BR_Encounter_RefuseReason_Reason);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Encounter_RefuseReason_Reason_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Encounter_RefuseReason_Reason_Titleformat), 4, 0, ".", "")));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtBR_Encounter_RefuseReason_Reason_Link));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.localUtil.TToC( A350BR_Encounter_RefuseReason_NoApproveDate, 10, 8, 0, 0, "/", ":", " "));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Encounter_RefuseReason_NoApproveDate_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Encounter_RefuseReason_NoApproveDate_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A351BR_Encounter_RefuseReason_Status), 4, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( cmbBR_Encounter_RefuseReason_Status.Title.Text));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(cmbBR_Encounter_RefuseReason_Status_Titleformat), 4, 0, ".", "")));
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
         if ( wbEnd == 31 )
         {
            wbEnd = 0;
            nRC_GXsfl_31 = (short)(nGXsfl_31_idx-1);
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
            ucGridpaginationbar.SetProperty("CurrentPage", AV40GridCurrentPage);
            ucGridpaginationbar.SetProperty("RecordCount", AV42GridRecordCount);
            ucGridpaginationbar.SetProperty("Page", AV41GridPageSize);
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
            ucDdo_br_encounter_refusereasonid.SetProperty("Caption", Ddo_br_encounter_refusereasonid_Caption);
            ucDdo_br_encounter_refusereasonid.SetProperty("Tooltip", Ddo_br_encounter_refusereasonid_Tooltip);
            ucDdo_br_encounter_refusereasonid.SetProperty("Cls", Ddo_br_encounter_refusereasonid_Cls);
            ucDdo_br_encounter_refusereasonid.SetProperty("DropDownOptionsType", Ddo_br_encounter_refusereasonid_Dropdownoptionstype);
            ucDdo_br_encounter_refusereasonid.SetProperty("IncludeSortASC", Ddo_br_encounter_refusereasonid_Includesortasc);
            ucDdo_br_encounter_refusereasonid.SetProperty("IncludeSortDSC", Ddo_br_encounter_refusereasonid_Includesortdsc);
            ucDdo_br_encounter_refusereasonid.SetProperty("IncludeFilter", Ddo_br_encounter_refusereasonid_Includefilter);
            ucDdo_br_encounter_refusereasonid.SetProperty("FilterType", Ddo_br_encounter_refusereasonid_Filtertype);
            ucDdo_br_encounter_refusereasonid.SetProperty("FilterIsRange", Ddo_br_encounter_refusereasonid_Filterisrange);
            ucDdo_br_encounter_refusereasonid.SetProperty("IncludeDataList", Ddo_br_encounter_refusereasonid_Includedatalist);
            ucDdo_br_encounter_refusereasonid.SetProperty("SortASC", Ddo_br_encounter_refusereasonid_Sortasc);
            ucDdo_br_encounter_refusereasonid.SetProperty("SortDSC", Ddo_br_encounter_refusereasonid_Sortdsc);
            ucDdo_br_encounter_refusereasonid.SetProperty("CleanFilter", Ddo_br_encounter_refusereasonid_Cleanfilter);
            ucDdo_br_encounter_refusereasonid.SetProperty("RangeFilterFrom", Ddo_br_encounter_refusereasonid_Rangefilterfrom);
            ucDdo_br_encounter_refusereasonid.SetProperty("RangeFilterTo", Ddo_br_encounter_refusereasonid_Rangefilterto);
            ucDdo_br_encounter_refusereasonid.SetProperty("SearchButtonText", Ddo_br_encounter_refusereasonid_Searchbuttontext);
            ucDdo_br_encounter_refusereasonid.SetProperty("DropDownOptionsTitleSettingsIcons", AV38DDO_TitleSettingsIcons);
            ucDdo_br_encounter_refusereasonid.SetProperty("DropDownOptionsData", AV16BR_Encounter_RefuseReasonIDTitleFilterData);
            ucDdo_br_encounter_refusereasonid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_encounter_refusereasonid_Internalname, "DDO_BR_ENCOUNTER_REFUSEREASONIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_encounter_refusereasonidtitlecontrolidtoreplace_Internalname, AV19ddo_BR_Encounter_RefuseReasonIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,48);\"", 0, edtavDdo_br_encounter_refusereasonidtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Encounter_RefuseReasonWW.htm");
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
            ucDdo_br_encounterid.SetProperty("DropDownOptionsTitleSettingsIcons", AV38DDO_TitleSettingsIcons);
            ucDdo_br_encounterid.SetProperty("DropDownOptionsData", AV20BR_EncounterIDTitleFilterData);
            ucDdo_br_encounterid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_encounterid_Internalname, "DDO_BR_ENCOUNTERIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 50,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_encounteridtitlecontrolidtoreplace_Internalname, AV23ddo_BR_EncounterIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,50);\"", 0, edtavDdo_br_encounteridtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Encounter_RefuseReasonWW.htm");
            /* User Defined Control */
            ucDdo_br_encounter_refusereason_reason.SetProperty("Caption", Ddo_br_encounter_refusereason_reason_Caption);
            ucDdo_br_encounter_refusereason_reason.SetProperty("Tooltip", Ddo_br_encounter_refusereason_reason_Tooltip);
            ucDdo_br_encounter_refusereason_reason.SetProperty("Cls", Ddo_br_encounter_refusereason_reason_Cls);
            ucDdo_br_encounter_refusereason_reason.SetProperty("DropDownOptionsType", Ddo_br_encounter_refusereason_reason_Dropdownoptionstype);
            ucDdo_br_encounter_refusereason_reason.SetProperty("IncludeSortASC", Ddo_br_encounter_refusereason_reason_Includesortasc);
            ucDdo_br_encounter_refusereason_reason.SetProperty("IncludeSortDSC", Ddo_br_encounter_refusereason_reason_Includesortdsc);
            ucDdo_br_encounter_refusereason_reason.SetProperty("IncludeFilter", Ddo_br_encounter_refusereason_reason_Includefilter);
            ucDdo_br_encounter_refusereason_reason.SetProperty("FilterType", Ddo_br_encounter_refusereason_reason_Filtertype);
            ucDdo_br_encounter_refusereason_reason.SetProperty("FilterIsRange", Ddo_br_encounter_refusereason_reason_Filterisrange);
            ucDdo_br_encounter_refusereason_reason.SetProperty("IncludeDataList", Ddo_br_encounter_refusereason_reason_Includedatalist);
            ucDdo_br_encounter_refusereason_reason.SetProperty("DataListType", Ddo_br_encounter_refusereason_reason_Datalisttype);
            ucDdo_br_encounter_refusereason_reason.SetProperty("DataListProc", Ddo_br_encounter_refusereason_reason_Datalistproc);
            ucDdo_br_encounter_refusereason_reason.SetProperty("DataListUpdateMinimumCharacters", Ddo_br_encounter_refusereason_reason_Datalistupdateminimumcharacters);
            ucDdo_br_encounter_refusereason_reason.SetProperty("SortASC", Ddo_br_encounter_refusereason_reason_Sortasc);
            ucDdo_br_encounter_refusereason_reason.SetProperty("SortDSC", Ddo_br_encounter_refusereason_reason_Sortdsc);
            ucDdo_br_encounter_refusereason_reason.SetProperty("LoadingData", Ddo_br_encounter_refusereason_reason_Loadingdata);
            ucDdo_br_encounter_refusereason_reason.SetProperty("CleanFilter", Ddo_br_encounter_refusereason_reason_Cleanfilter);
            ucDdo_br_encounter_refusereason_reason.SetProperty("NoResultsFound", Ddo_br_encounter_refusereason_reason_Noresultsfound);
            ucDdo_br_encounter_refusereason_reason.SetProperty("SearchButtonText", Ddo_br_encounter_refusereason_reason_Searchbuttontext);
            ucDdo_br_encounter_refusereason_reason.SetProperty("DropDownOptionsTitleSettingsIcons", AV38DDO_TitleSettingsIcons);
            ucDdo_br_encounter_refusereason_reason.SetProperty("DropDownOptionsData", AV24BR_Encounter_RefuseReason_ReasonTitleFilterData);
            ucDdo_br_encounter_refusereason_reason.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_encounter_refusereason_reason_Internalname, "DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 52,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_encounter_refusereason_reasontitlecontrolidtoreplace_Internalname, AV27ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,52);\"", 0, edtavDdo_br_encounter_refusereason_reasontitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Encounter_RefuseReasonWW.htm");
            /* User Defined Control */
            ucDdo_br_encounter_refusereason_noapprovedate.SetProperty("Caption", Ddo_br_encounter_refusereason_noapprovedate_Caption);
            ucDdo_br_encounter_refusereason_noapprovedate.SetProperty("Tooltip", Ddo_br_encounter_refusereason_noapprovedate_Tooltip);
            ucDdo_br_encounter_refusereason_noapprovedate.SetProperty("Cls", Ddo_br_encounter_refusereason_noapprovedate_Cls);
            ucDdo_br_encounter_refusereason_noapprovedate.SetProperty("DropDownOptionsType", Ddo_br_encounter_refusereason_noapprovedate_Dropdownoptionstype);
            ucDdo_br_encounter_refusereason_noapprovedate.SetProperty("IncludeSortASC", Ddo_br_encounter_refusereason_noapprovedate_Includesortasc);
            ucDdo_br_encounter_refusereason_noapprovedate.SetProperty("IncludeSortDSC", Ddo_br_encounter_refusereason_noapprovedate_Includesortdsc);
            ucDdo_br_encounter_refusereason_noapprovedate.SetProperty("IncludeFilter", Ddo_br_encounter_refusereason_noapprovedate_Includefilter);
            ucDdo_br_encounter_refusereason_noapprovedate.SetProperty("FilterType", Ddo_br_encounter_refusereason_noapprovedate_Filtertype);
            ucDdo_br_encounter_refusereason_noapprovedate.SetProperty("FilterIsRange", Ddo_br_encounter_refusereason_noapprovedate_Filterisrange);
            ucDdo_br_encounter_refusereason_noapprovedate.SetProperty("IncludeDataList", Ddo_br_encounter_refusereason_noapprovedate_Includedatalist);
            ucDdo_br_encounter_refusereason_noapprovedate.SetProperty("SortASC", Ddo_br_encounter_refusereason_noapprovedate_Sortasc);
            ucDdo_br_encounter_refusereason_noapprovedate.SetProperty("SortDSC", Ddo_br_encounter_refusereason_noapprovedate_Sortdsc);
            ucDdo_br_encounter_refusereason_noapprovedate.SetProperty("CleanFilter", Ddo_br_encounter_refusereason_noapprovedate_Cleanfilter);
            ucDdo_br_encounter_refusereason_noapprovedate.SetProperty("RangeFilterFrom", Ddo_br_encounter_refusereason_noapprovedate_Rangefilterfrom);
            ucDdo_br_encounter_refusereason_noapprovedate.SetProperty("RangeFilterTo", Ddo_br_encounter_refusereason_noapprovedate_Rangefilterto);
            ucDdo_br_encounter_refusereason_noapprovedate.SetProperty("SearchButtonText", Ddo_br_encounter_refusereason_noapprovedate_Searchbuttontext);
            ucDdo_br_encounter_refusereason_noapprovedate.SetProperty("DropDownOptionsTitleSettingsIcons", AV38DDO_TitleSettingsIcons);
            ucDdo_br_encounter_refusereason_noapprovedate.SetProperty("DropDownOptionsData", AV28BR_Encounter_RefuseReason_NoApproveDateTitleFilterData);
            ucDdo_br_encounter_refusereason_noapprovedate.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_encounter_refusereason_noapprovedate_Internalname, "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_encounter_refusereason_noapprovedatetitlecontrolidtoreplace_Internalname, AV33ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,54);\"", 0, edtavDdo_br_encounter_refusereason_noapprovedatetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Encounter_RefuseReasonWW.htm");
            /* User Defined Control */
            ucDdo_br_encounter_refusereason_status.SetProperty("Caption", Ddo_br_encounter_refusereason_status_Caption);
            ucDdo_br_encounter_refusereason_status.SetProperty("Tooltip", Ddo_br_encounter_refusereason_status_Tooltip);
            ucDdo_br_encounter_refusereason_status.SetProperty("Cls", Ddo_br_encounter_refusereason_status_Cls);
            ucDdo_br_encounter_refusereason_status.SetProperty("DropDownOptionsType", Ddo_br_encounter_refusereason_status_Dropdownoptionstype);
            ucDdo_br_encounter_refusereason_status.SetProperty("IncludeSortASC", Ddo_br_encounter_refusereason_status_Includesortasc);
            ucDdo_br_encounter_refusereason_status.SetProperty("IncludeSortDSC", Ddo_br_encounter_refusereason_status_Includesortdsc);
            ucDdo_br_encounter_refusereason_status.SetProperty("IncludeFilter", Ddo_br_encounter_refusereason_status_Includefilter);
            ucDdo_br_encounter_refusereason_status.SetProperty("IncludeDataList", Ddo_br_encounter_refusereason_status_Includedatalist);
            ucDdo_br_encounter_refusereason_status.SetProperty("DataListType", Ddo_br_encounter_refusereason_status_Datalisttype);
            ucDdo_br_encounter_refusereason_status.SetProperty("AllowMultipleSelection", Ddo_br_encounter_refusereason_status_Allowmultipleselection);
            ucDdo_br_encounter_refusereason_status.SetProperty("DataListFixedValues", Ddo_br_encounter_refusereason_status_Datalistfixedvalues);
            ucDdo_br_encounter_refusereason_status.SetProperty("SortASC", Ddo_br_encounter_refusereason_status_Sortasc);
            ucDdo_br_encounter_refusereason_status.SetProperty("SortDSC", Ddo_br_encounter_refusereason_status_Sortdsc);
            ucDdo_br_encounter_refusereason_status.SetProperty("CleanFilter", Ddo_br_encounter_refusereason_status_Cleanfilter);
            ucDdo_br_encounter_refusereason_status.SetProperty("SearchButtonText", Ddo_br_encounter_refusereason_status_Searchbuttontext);
            ucDdo_br_encounter_refusereason_status.SetProperty("DropDownOptionsTitleSettingsIcons", AV38DDO_TitleSettingsIcons);
            ucDdo_br_encounter_refusereason_status.SetProperty("DropDownOptionsData", AV34BR_Encounter_RefuseReason_StatusTitleFilterData);
            ucDdo_br_encounter_refusereason_status.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_encounter_refusereason_status_Internalname, "DDO_BR_ENCOUNTER_REFUSEREASON_STATUSContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 56,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_encounter_refusereason_statustitlecontrolidtoreplace_Internalname, AV37ddo_BR_Encounter_RefuseReason_StatusTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,56);\"", 0, edtavDdo_br_encounter_refusereason_statustitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Encounter_RefuseReasonWW.htm");
            /* User Defined Control */
            ucWorkwithplusutilities1.Render(context, "dvelop.workwithplusutilities", Workwithplusutilities1_Internalname, "WORKWITHPLUSUTILITIES1Container");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrderedby_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13OrderedBy), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV13OrderedBy), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,58);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrderedby_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrderedby_Visible, 1, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Encounter_RefuseReasonWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 59,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrdereddsc_Internalname, StringUtil.BoolToStr( AV14OrderedDsc), StringUtil.BoolToStr( AV14OrderedDsc), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,59);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrdereddsc_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrdereddsc_Visible, 1, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, 0, 0, true, "", "right", false, "HLP_BR_Encounter_RefuseReasonWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 60,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_encounter_refusereasonid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV17TFBR_Encounter_RefuseReasonID), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV17TFBR_Encounter_RefuseReasonID), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,60);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_encounter_refusereasonid_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_encounter_refusereasonid_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Encounter_RefuseReasonWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 61,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_encounter_refusereasonid_to_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV18TFBR_Encounter_RefuseReasonID_To), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV18TFBR_Encounter_RefuseReasonID_To), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,61);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_encounter_refusereasonid_to_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_encounter_refusereasonid_to_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Encounter_RefuseReasonWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 62,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_encounterid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV21TFBR_EncounterID), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV21TFBR_EncounterID), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,62);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_encounterid_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_encounterid_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Encounter_RefuseReasonWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_encounterid_to_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV22TFBR_EncounterID_To), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV22TFBR_EncounterID_To), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,63);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_encounterid_to_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_encounterid_to_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Encounter_RefuseReasonWW.htm");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 64,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavTfbr_encounter_refusereason_reason_Internalname, AV25TFBR_Encounter_RefuseReason_Reason, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,64);\"", 0, edtavTfbr_encounter_refusereason_reason_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Encounter_RefuseReasonWW.htm");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 65,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavTfbr_encounter_refusereason_reason_sel_Internalname, AV26TFBR_Encounter_RefuseReason_Reason_Sel, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,65);\"", 0, edtavTfbr_encounter_refusereason_reason_sel_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Encounter_RefuseReasonWW.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 66,'',false,'" + sGXsfl_31_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavTfbr_encounter_refusereason_noapprovedate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavTfbr_encounter_refusereason_noapprovedate_Internalname, context.localUtil.TToC( AV29TFBR_Encounter_RefuseReason_NoApproveDate, 10, 8, 0, 0, "/", ":", " "), context.localUtil.Format( AV29TFBR_Encounter_RefuseReason_NoApproveDate, "9999/99/99 99:99:99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',8,24,'chs',false,1);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,66);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_encounter_refusereason_noapprovedate_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_encounter_refusereason_noapprovedate_Visible, 1, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Encounter_RefuseReasonWW.htm");
            GxWebStd.gx_bitmap( context, edtavTfbr_encounter_refusereason_noapprovedate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((edtavTfbr_encounter_refusereason_noapprovedate_Visible==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_Encounter_RefuseReasonWW.htm");
            context.WriteHtmlTextNl( "</div>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 67,'',false,'" + sGXsfl_31_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavTfbr_encounter_refusereason_noapprovedate_to_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavTfbr_encounter_refusereason_noapprovedate_to_Internalname, context.localUtil.TToC( AV30TFBR_Encounter_RefuseReason_NoApproveDate_To, 10, 8, 0, 0, "/", ":", " "), context.localUtil.Format( AV30TFBR_Encounter_RefuseReason_NoApproveDate_To, "9999/99/99 99:99:99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',8,24,'chs',false,1);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,67);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_encounter_refusereason_noapprovedate_to_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_encounter_refusereason_noapprovedate_to_Visible, 1, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Encounter_RefuseReasonWW.htm");
            GxWebStd.gx_bitmap( context, edtavTfbr_encounter_refusereason_noapprovedate_to_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((edtavTfbr_encounter_refusereason_noapprovedate_to_Visible==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_Encounter_RefuseReasonWW.htm");
            context.WriteHtmlTextNl( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divDdo_br_encounter_refusereason_noapprovedateauxdates_Internalname, 1, 0, "px", 0, "px", "Invisible", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 69,'',false,'" + sGXsfl_31_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavDdo_br_encounter_refusereason_noapprovedateauxdate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavDdo_br_encounter_refusereason_noapprovedateauxdate_Internalname, context.localUtil.Format(AV31DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDate, "9999/99/99"), context.localUtil.Format( AV31DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDate, "9999/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',0,24,'chs',false,1);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,69);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavDdo_br_encounter_refusereason_noapprovedateauxdate_Jsonclick, 0, "Attribute", "", "", "", "", 1, 1, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Encounter_RefuseReasonWW.htm");
            GxWebStd.gx_bitmap( context, edtavDdo_br_encounter_refusereason_noapprovedateauxdate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_Encounter_RefuseReasonWW.htm");
            context.WriteHtmlTextNl( "</div>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 70,'',false,'" + sGXsfl_31_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavDdo_br_encounter_refusereason_noapprovedateauxdateto_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavDdo_br_encounter_refusereason_noapprovedateauxdateto_Internalname, context.localUtil.Format(AV32DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDateTo, "9999/99/99"), context.localUtil.Format( AV32DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDateTo, "9999/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',0,24,'chs',false,1);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,70);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavDdo_br_encounter_refusereason_noapprovedateauxdateto_Jsonclick, 0, "Attribute", "", "", "", "", 1, 1, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Encounter_RefuseReasonWW.htm");
            GxWebStd.gx_bitmap( context, edtavDdo_br_encounter_refusereason_noapprovedateauxdateto_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_Encounter_RefuseReasonWW.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         if ( wbEnd == 31 )
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

      protected void START7C2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_0-127771", 0) ;
            Form.Meta.addItem("description", " 就诊信息驳回原因", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP7C0( ) ;
      }

      protected void WS7C2( )
      {
         START7C2( ) ;
         EVT7C2( ) ;
      }

      protected void EVT7C2( )
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
                              E117C2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEROWSPERPAGE") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E127C2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_ENCOUNTER_REFUSEREASONID.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E137C2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_ENCOUNTERID.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E147C2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_ENCOUNTER_REFUSEREASON_REASON.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E157C2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E167C2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_ENCOUNTER_REFUSEREASON_STATUS.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E177C2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'DOINSERT'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'DoInsert' */
                              E187C2 ();
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
                              nGXsfl_31_idx = (short)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_31_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_31_idx), 4, 0)), 4, "0");
                              SubsflControlProps_312( ) ;
                              AV43Display = cgiGet( edtavDisplay_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDisplay_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV43Display)) ? AV60Display_GXI : context.convertURL( context.PathToRelativeUrl( AV43Display))), !bGXsfl_31_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDisplay_Internalname, "SrcSet", context.GetImageSrcSet( AV43Display), true);
                              AV44Update = cgiGet( edtavUpdate_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV44Update)) ? AV61Update_GXI : context.convertURL( context.PathToRelativeUrl( AV44Update))), !bGXsfl_31_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "SrcSet", context.GetImageSrcSet( AV44Update), true);
                              AV46Delete = cgiGet( edtavDelete_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV46Delete)) ? AV62Delete_GXI : context.convertURL( context.PathToRelativeUrl( AV46Delete))), !bGXsfl_31_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "SrcSet", context.GetImageSrcSet( AV46Delete), true);
                              A348BR_Encounter_RefuseReasonID = (long)(context.localUtil.CToN( cgiGet( edtBR_Encounter_RefuseReasonID_Internalname), ".", ","));
                              A19BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( edtBR_EncounterID_Internalname), ".", ","));
                              A349BR_Encounter_RefuseReason_Reason = cgiGet( edtBR_Encounter_RefuseReason_Reason_Internalname);
                              n349BR_Encounter_RefuseReason_Reason = false;
                              A350BR_Encounter_RefuseReason_NoApproveDate = context.localUtil.CToT( cgiGet( edtBR_Encounter_RefuseReason_NoApproveDate_Internalname), 0);
                              n350BR_Encounter_RefuseReason_NoApproveDate = false;
                              cmbBR_Encounter_RefuseReason_Status.Name = cmbBR_Encounter_RefuseReason_Status_Internalname;
                              cmbBR_Encounter_RefuseReason_Status.CurrentValue = cgiGet( cmbBR_Encounter_RefuseReason_Status_Internalname);
                              A351BR_Encounter_RefuseReason_Status = (short)(NumberUtil.Val( cgiGet( cmbBR_Encounter_RefuseReason_Status_Internalname), "."));
                              n351BR_Encounter_RefuseReason_Status = false;
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E197C2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Refresh */
                                    E207C2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "GRID.LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    E217C2 ();
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
                                       /* Set Refresh If Tfbr_encounter_refusereasonid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_ENCOUNTER_REFUSEREASONID"), ".", ",") != Convert.ToDecimal( AV17TFBR_Encounter_RefuseReasonID )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_encounter_refusereasonid_to Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_ENCOUNTER_REFUSEREASONID_TO"), ".", ",") != Convert.ToDecimal( AV18TFBR_Encounter_RefuseReasonID_To )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_encounterid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_ENCOUNTERID"), ".", ",") != Convert.ToDecimal( AV21TFBR_EncounterID )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_encounterid_to Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_ENCOUNTERID_TO"), ".", ",") != Convert.ToDecimal( AV22TFBR_EncounterID_To )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_encounter_refusereason_reason Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_ENCOUNTER_REFUSEREASON_REASON"), AV25TFBR_Encounter_RefuseReason_Reason) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_encounter_refusereason_reason_sel Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_ENCOUNTER_REFUSEREASON_REASON_SEL"), AV26TFBR_Encounter_RefuseReason_Reason_Sel) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_encounter_refusereason_noapprovedate Changed */
                                       if ( context.localUtil.CToT( cgiGet( "GXH_vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE"), 0) != AV29TFBR_Encounter_RefuseReason_NoApproveDate )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_encounter_refusereason_noapprovedate_to Changed */
                                       if ( context.localUtil.CToT( cgiGet( "GXH_vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_TO"), 0) != AV30TFBR_Encounter_RefuseReason_NoApproveDate_To )
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

      protected void WE7C2( )
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

      protected void PA7C2( )
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
               GX_FocusControl = edtavDdo_br_encounter_refusereasonidtitlecontrolidtoreplace_Internalname;
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
         SubsflControlProps_312( ) ;
         while ( nGXsfl_31_idx <= nRC_GXsfl_31 )
         {
            sendrow_312( ) ;
            nGXsfl_31_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_31_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_31_idx+1));
            sGXsfl_31_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_31_idx), 4, 0)), 4, "0");
            SubsflControlProps_312( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( GridContainer));
         /* End function gxnrGrid_newrow */
      }

      protected void gxgrGrid_refresh( int subGrid_Rows ,
                                       short AV13OrderedBy ,
                                       bool AV14OrderedDsc ,
                                       long AV17TFBR_Encounter_RefuseReasonID ,
                                       long AV18TFBR_Encounter_RefuseReasonID_To ,
                                       long AV21TFBR_EncounterID ,
                                       long AV22TFBR_EncounterID_To ,
                                       String AV25TFBR_Encounter_RefuseReason_Reason ,
                                       String AV26TFBR_Encounter_RefuseReason_Reason_Sel ,
                                       DateTime AV29TFBR_Encounter_RefuseReason_NoApproveDate ,
                                       DateTime AV30TFBR_Encounter_RefuseReason_NoApproveDate_To ,
                                       String AV19ddo_BR_Encounter_RefuseReasonIDTitleControlIdToReplace ,
                                       String AV23ddo_BR_EncounterIDTitleControlIdToReplace ,
                                       String AV27ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace ,
                                       String AV33ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace ,
                                       String AV37ddo_BR_Encounter_RefuseReason_StatusTitleControlIdToReplace ,
                                       GxSimpleCollection<short> AV36TFBR_Encounter_RefuseReason_Status_Sels ,
                                       String AV63Pgmname ,
                                       bool AV45IsAuthorized_Update ,
                                       bool AV47IsAuthorized_Delete )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GRID_nCurrentRecord = 0;
         RF7C2( ) ;
         /* End function gxgrGrid_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_BR_ENCOUNTER_REFUSEREASONID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A348BR_Encounter_RefuseReasonID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, "BR_ENCOUNTER_REFUSEREASONID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A348BR_Encounter_RefuseReasonID), 18, 0, ".", "")));
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
         RF7C2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV63Pgmname = "BR_Encounter_RefuseReasonWW";
         context.Gx_err = 0;
      }

      protected void RF7C2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridContainer.ClearRows();
         }
         wbStart = 31;
         /* Execute user event: Refresh */
         E207C2 ();
         nGXsfl_31_idx = 1;
         sGXsfl_31_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_31_idx), 4, 0)), 4, "0");
         SubsflControlProps_312( ) ;
         bGXsfl_31_Refreshing = true;
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
            SubsflControlProps_312( ) ;
            GXPagingFrom2 = (int)(((subGrid_Rows==0) ? 0 : GRID_nFirstRecordOnPage));
            GXPagingTo2 = ((subGrid_Rows==0) ? 10000 : subGrid_Recordsperpage( )+1);
            pr_default.dynParam(0, new Object[]{ new Object[]{
                                                 A351BR_Encounter_RefuseReason_Status ,
                                                 AV59BR_Encounter_RefuseReasonWWDS_9_Tfbr_encounter_refusereason_status_sels ,
                                                 AV51BR_Encounter_RefuseReasonWWDS_1_Tfbr_encounter_refusereasonid ,
                                                 AV52BR_Encounter_RefuseReasonWWDS_2_Tfbr_encounter_refusereasonid_to ,
                                                 AV53BR_Encounter_RefuseReasonWWDS_3_Tfbr_encounterid ,
                                                 AV54BR_Encounter_RefuseReasonWWDS_4_Tfbr_encounterid_to ,
                                                 AV56BR_Encounter_RefuseReasonWWDS_6_Tfbr_encounter_refusereason_reason_sel ,
                                                 AV55BR_Encounter_RefuseReasonWWDS_5_Tfbr_encounter_refusereason_reason ,
                                                 AV57BR_Encounter_RefuseReasonWWDS_7_Tfbr_encounter_refusereason_noapprovedate ,
                                                 AV58BR_Encounter_RefuseReasonWWDS_8_Tfbr_encounter_refusereason_noapprovedate_to ,
                                                 AV59BR_Encounter_RefuseReasonWWDS_9_Tfbr_encounter_refusereason_status_sels.Count ,
                                                 A348BR_Encounter_RefuseReasonID ,
                                                 A19BR_EncounterID ,
                                                 A349BR_Encounter_RefuseReason_Reason ,
                                                 A350BR_Encounter_RefuseReason_NoApproveDate ,
                                                 AV13OrderedBy ,
                                                 AV14OrderedDsc } ,
                                                 new int[]{
                                                 TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DATE, TypeConstants.DATE,
                                                 TypeConstants.INT, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DATE, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN
                                                 }
            } ) ;
            lV55BR_Encounter_RefuseReasonWWDS_5_Tfbr_encounter_refusereason_reason = StringUtil.Concat( StringUtil.RTrim( AV55BR_Encounter_RefuseReasonWWDS_5_Tfbr_encounter_refusereason_reason), "%", "");
            /* Using cursor H007C2 */
            pr_default.execute(0, new Object[] {AV51BR_Encounter_RefuseReasonWWDS_1_Tfbr_encounter_refusereasonid, AV52BR_Encounter_RefuseReasonWWDS_2_Tfbr_encounter_refusereasonid_to, AV53BR_Encounter_RefuseReasonWWDS_3_Tfbr_encounterid, AV54BR_Encounter_RefuseReasonWWDS_4_Tfbr_encounterid_to, lV55BR_Encounter_RefuseReasonWWDS_5_Tfbr_encounter_refusereason_reason, AV56BR_Encounter_RefuseReasonWWDS_6_Tfbr_encounter_refusereason_reason_sel, AV57BR_Encounter_RefuseReasonWWDS_7_Tfbr_encounter_refusereason_noapprovedate, AV58BR_Encounter_RefuseReasonWWDS_8_Tfbr_encounter_refusereason_noapprovedate_to, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_31_idx = 1;
            sGXsfl_31_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_31_idx), 4, 0)), 4, "0");
            SubsflControlProps_312( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < subGrid_Recordsperpage( ) ) ) ) )
            {
               A351BR_Encounter_RefuseReason_Status = H007C2_A351BR_Encounter_RefuseReason_Status[0];
               n351BR_Encounter_RefuseReason_Status = H007C2_n351BR_Encounter_RefuseReason_Status[0];
               A350BR_Encounter_RefuseReason_NoApproveDate = H007C2_A350BR_Encounter_RefuseReason_NoApproveDate[0];
               n350BR_Encounter_RefuseReason_NoApproveDate = H007C2_n350BR_Encounter_RefuseReason_NoApproveDate[0];
               A349BR_Encounter_RefuseReason_Reason = H007C2_A349BR_Encounter_RefuseReason_Reason[0];
               n349BR_Encounter_RefuseReason_Reason = H007C2_n349BR_Encounter_RefuseReason_Reason[0];
               A19BR_EncounterID = H007C2_A19BR_EncounterID[0];
               A348BR_Encounter_RefuseReasonID = H007C2_A348BR_Encounter_RefuseReasonID[0];
               E217C2 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 31;
            WB7C0( ) ;
         }
         bGXsfl_31_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes7C2( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_BR_ENCOUNTER_REFUSEREASONID"+"_"+sGXsfl_31_idx, GetSecureSignedToken( sGXsfl_31_idx, context.localUtil.Format( (decimal)(A348BR_Encounter_RefuseReasonID), "ZZZZZZZZZZZZZZZZZZ"), context));
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
         AV51BR_Encounter_RefuseReasonWWDS_1_Tfbr_encounter_refusereasonid = AV17TFBR_Encounter_RefuseReasonID;
         AV52BR_Encounter_RefuseReasonWWDS_2_Tfbr_encounter_refusereasonid_to = AV18TFBR_Encounter_RefuseReasonID_To;
         AV53BR_Encounter_RefuseReasonWWDS_3_Tfbr_encounterid = AV21TFBR_EncounterID;
         AV54BR_Encounter_RefuseReasonWWDS_4_Tfbr_encounterid_to = AV22TFBR_EncounterID_To;
         AV55BR_Encounter_RefuseReasonWWDS_5_Tfbr_encounter_refusereason_reason = AV25TFBR_Encounter_RefuseReason_Reason;
         AV56BR_Encounter_RefuseReasonWWDS_6_Tfbr_encounter_refusereason_reason_sel = AV26TFBR_Encounter_RefuseReason_Reason_Sel;
         AV57BR_Encounter_RefuseReasonWWDS_7_Tfbr_encounter_refusereason_noapprovedate = AV29TFBR_Encounter_RefuseReason_NoApproveDate;
         AV58BR_Encounter_RefuseReasonWWDS_8_Tfbr_encounter_refusereason_noapprovedate_to = AV30TFBR_Encounter_RefuseReason_NoApproveDate_To;
         AV59BR_Encounter_RefuseReasonWWDS_9_Tfbr_encounter_refusereason_status_sels = AV36TFBR_Encounter_RefuseReason_Status_Sels;
         pr_default.dynParam(1, new Object[]{ new Object[]{
                                              A351BR_Encounter_RefuseReason_Status ,
                                              AV59BR_Encounter_RefuseReasonWWDS_9_Tfbr_encounter_refusereason_status_sels ,
                                              AV51BR_Encounter_RefuseReasonWWDS_1_Tfbr_encounter_refusereasonid ,
                                              AV52BR_Encounter_RefuseReasonWWDS_2_Tfbr_encounter_refusereasonid_to ,
                                              AV53BR_Encounter_RefuseReasonWWDS_3_Tfbr_encounterid ,
                                              AV54BR_Encounter_RefuseReasonWWDS_4_Tfbr_encounterid_to ,
                                              AV56BR_Encounter_RefuseReasonWWDS_6_Tfbr_encounter_refusereason_reason_sel ,
                                              AV55BR_Encounter_RefuseReasonWWDS_5_Tfbr_encounter_refusereason_reason ,
                                              AV57BR_Encounter_RefuseReasonWWDS_7_Tfbr_encounter_refusereason_noapprovedate ,
                                              AV58BR_Encounter_RefuseReasonWWDS_8_Tfbr_encounter_refusereason_noapprovedate_to ,
                                              AV59BR_Encounter_RefuseReasonWWDS_9_Tfbr_encounter_refusereason_status_sels.Count ,
                                              A348BR_Encounter_RefuseReasonID ,
                                              A19BR_EncounterID ,
                                              A349BR_Encounter_RefuseReason_Reason ,
                                              A350BR_Encounter_RefuseReason_NoApproveDate ,
                                              AV13OrderedBy ,
                                              AV14OrderedDsc } ,
                                              new int[]{
                                              TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DATE, TypeConstants.DATE,
                                              TypeConstants.INT, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DATE, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN
                                              }
         } ) ;
         lV55BR_Encounter_RefuseReasonWWDS_5_Tfbr_encounter_refusereason_reason = StringUtil.Concat( StringUtil.RTrim( AV55BR_Encounter_RefuseReasonWWDS_5_Tfbr_encounter_refusereason_reason), "%", "");
         /* Using cursor H007C3 */
         pr_default.execute(1, new Object[] {AV51BR_Encounter_RefuseReasonWWDS_1_Tfbr_encounter_refusereasonid, AV52BR_Encounter_RefuseReasonWWDS_2_Tfbr_encounter_refusereasonid_to, AV53BR_Encounter_RefuseReasonWWDS_3_Tfbr_encounterid, AV54BR_Encounter_RefuseReasonWWDS_4_Tfbr_encounterid_to, lV55BR_Encounter_RefuseReasonWWDS_5_Tfbr_encounter_refusereason_reason, AV56BR_Encounter_RefuseReasonWWDS_6_Tfbr_encounter_refusereason_reason_sel, AV57BR_Encounter_RefuseReasonWWDS_7_Tfbr_encounter_refusereason_noapprovedate, AV58BR_Encounter_RefuseReasonWWDS_8_Tfbr_encounter_refusereason_noapprovedate_to});
         GRID_nRecordCount = H007C3_AGRID_nRecordCount[0];
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
         AV51BR_Encounter_RefuseReasonWWDS_1_Tfbr_encounter_refusereasonid = AV17TFBR_Encounter_RefuseReasonID;
         AV52BR_Encounter_RefuseReasonWWDS_2_Tfbr_encounter_refusereasonid_to = AV18TFBR_Encounter_RefuseReasonID_To;
         AV53BR_Encounter_RefuseReasonWWDS_3_Tfbr_encounterid = AV21TFBR_EncounterID;
         AV54BR_Encounter_RefuseReasonWWDS_4_Tfbr_encounterid_to = AV22TFBR_EncounterID_To;
         AV55BR_Encounter_RefuseReasonWWDS_5_Tfbr_encounter_refusereason_reason = AV25TFBR_Encounter_RefuseReason_Reason;
         AV56BR_Encounter_RefuseReasonWWDS_6_Tfbr_encounter_refusereason_reason_sel = AV26TFBR_Encounter_RefuseReason_Reason_Sel;
         AV57BR_Encounter_RefuseReasonWWDS_7_Tfbr_encounter_refusereason_noapprovedate = AV29TFBR_Encounter_RefuseReason_NoApproveDate;
         AV58BR_Encounter_RefuseReasonWWDS_8_Tfbr_encounter_refusereason_noapprovedate_to = AV30TFBR_Encounter_RefuseReason_NoApproveDate_To;
         AV59BR_Encounter_RefuseReasonWWDS_9_Tfbr_encounter_refusereason_status_sels = AV36TFBR_Encounter_RefuseReason_Status_Sels;
         GRID_nFirstRecordOnPage = 0;
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV17TFBR_Encounter_RefuseReasonID, AV18TFBR_Encounter_RefuseReasonID_To, AV21TFBR_EncounterID, AV22TFBR_EncounterID_To, AV25TFBR_Encounter_RefuseReason_Reason, AV26TFBR_Encounter_RefuseReason_Reason_Sel, AV29TFBR_Encounter_RefuseReason_NoApproveDate, AV30TFBR_Encounter_RefuseReason_NoApproveDate_To, AV19ddo_BR_Encounter_RefuseReasonIDTitleControlIdToReplace, AV23ddo_BR_EncounterIDTitleControlIdToReplace, AV27ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace, AV33ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace, AV37ddo_BR_Encounter_RefuseReason_StatusTitleControlIdToReplace, AV36TFBR_Encounter_RefuseReason_Status_Sels, AV63Pgmname, AV45IsAuthorized_Update, AV47IsAuthorized_Delete) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid_nextpage( )
      {
         AV51BR_Encounter_RefuseReasonWWDS_1_Tfbr_encounter_refusereasonid = AV17TFBR_Encounter_RefuseReasonID;
         AV52BR_Encounter_RefuseReasonWWDS_2_Tfbr_encounter_refusereasonid_to = AV18TFBR_Encounter_RefuseReasonID_To;
         AV53BR_Encounter_RefuseReasonWWDS_3_Tfbr_encounterid = AV21TFBR_EncounterID;
         AV54BR_Encounter_RefuseReasonWWDS_4_Tfbr_encounterid_to = AV22TFBR_EncounterID_To;
         AV55BR_Encounter_RefuseReasonWWDS_5_Tfbr_encounter_refusereason_reason = AV25TFBR_Encounter_RefuseReason_Reason;
         AV56BR_Encounter_RefuseReasonWWDS_6_Tfbr_encounter_refusereason_reason_sel = AV26TFBR_Encounter_RefuseReason_Reason_Sel;
         AV57BR_Encounter_RefuseReasonWWDS_7_Tfbr_encounter_refusereason_noapprovedate = AV29TFBR_Encounter_RefuseReason_NoApproveDate;
         AV58BR_Encounter_RefuseReasonWWDS_8_Tfbr_encounter_refusereason_noapprovedate_to = AV30TFBR_Encounter_RefuseReason_NoApproveDate_To;
         AV59BR_Encounter_RefuseReasonWWDS_9_Tfbr_encounter_refusereason_status_sels = AV36TFBR_Encounter_RefuseReason_Status_Sels;
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
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV17TFBR_Encounter_RefuseReasonID, AV18TFBR_Encounter_RefuseReasonID_To, AV21TFBR_EncounterID, AV22TFBR_EncounterID_To, AV25TFBR_Encounter_RefuseReason_Reason, AV26TFBR_Encounter_RefuseReason_Reason_Sel, AV29TFBR_Encounter_RefuseReason_NoApproveDate, AV30TFBR_Encounter_RefuseReason_NoApproveDate_To, AV19ddo_BR_Encounter_RefuseReasonIDTitleControlIdToReplace, AV23ddo_BR_EncounterIDTitleControlIdToReplace, AV27ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace, AV33ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace, AV37ddo_BR_Encounter_RefuseReason_StatusTitleControlIdToReplace, AV36TFBR_Encounter_RefuseReason_Status_Sels, AV63Pgmname, AV45IsAuthorized_Update, AV47IsAuthorized_Delete) ;
         }
         send_integrity_footer_hashes( ) ;
         return (short)(((GRID_nEOF==0) ? 0 : 2)) ;
      }

      protected short subgrid_previouspage( )
      {
         AV51BR_Encounter_RefuseReasonWWDS_1_Tfbr_encounter_refusereasonid = AV17TFBR_Encounter_RefuseReasonID;
         AV52BR_Encounter_RefuseReasonWWDS_2_Tfbr_encounter_refusereasonid_to = AV18TFBR_Encounter_RefuseReasonID_To;
         AV53BR_Encounter_RefuseReasonWWDS_3_Tfbr_encounterid = AV21TFBR_EncounterID;
         AV54BR_Encounter_RefuseReasonWWDS_4_Tfbr_encounterid_to = AV22TFBR_EncounterID_To;
         AV55BR_Encounter_RefuseReasonWWDS_5_Tfbr_encounter_refusereason_reason = AV25TFBR_Encounter_RefuseReason_Reason;
         AV56BR_Encounter_RefuseReasonWWDS_6_Tfbr_encounter_refusereason_reason_sel = AV26TFBR_Encounter_RefuseReason_Reason_Sel;
         AV57BR_Encounter_RefuseReasonWWDS_7_Tfbr_encounter_refusereason_noapprovedate = AV29TFBR_Encounter_RefuseReason_NoApproveDate;
         AV58BR_Encounter_RefuseReasonWWDS_8_Tfbr_encounter_refusereason_noapprovedate_to = AV30TFBR_Encounter_RefuseReason_NoApproveDate_To;
         AV59BR_Encounter_RefuseReasonWWDS_9_Tfbr_encounter_refusereason_status_sels = AV36TFBR_Encounter_RefuseReason_Status_Sels;
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
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV17TFBR_Encounter_RefuseReasonID, AV18TFBR_Encounter_RefuseReasonID_To, AV21TFBR_EncounterID, AV22TFBR_EncounterID_To, AV25TFBR_Encounter_RefuseReason_Reason, AV26TFBR_Encounter_RefuseReason_Reason_Sel, AV29TFBR_Encounter_RefuseReason_NoApproveDate, AV30TFBR_Encounter_RefuseReason_NoApproveDate_To, AV19ddo_BR_Encounter_RefuseReasonIDTitleControlIdToReplace, AV23ddo_BR_EncounterIDTitleControlIdToReplace, AV27ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace, AV33ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace, AV37ddo_BR_Encounter_RefuseReason_StatusTitleControlIdToReplace, AV36TFBR_Encounter_RefuseReason_Status_Sels, AV63Pgmname, AV45IsAuthorized_Update, AV47IsAuthorized_Delete) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid_lastpage( )
      {
         AV51BR_Encounter_RefuseReasonWWDS_1_Tfbr_encounter_refusereasonid = AV17TFBR_Encounter_RefuseReasonID;
         AV52BR_Encounter_RefuseReasonWWDS_2_Tfbr_encounter_refusereasonid_to = AV18TFBR_Encounter_RefuseReasonID_To;
         AV53BR_Encounter_RefuseReasonWWDS_3_Tfbr_encounterid = AV21TFBR_EncounterID;
         AV54BR_Encounter_RefuseReasonWWDS_4_Tfbr_encounterid_to = AV22TFBR_EncounterID_To;
         AV55BR_Encounter_RefuseReasonWWDS_5_Tfbr_encounter_refusereason_reason = AV25TFBR_Encounter_RefuseReason_Reason;
         AV56BR_Encounter_RefuseReasonWWDS_6_Tfbr_encounter_refusereason_reason_sel = AV26TFBR_Encounter_RefuseReason_Reason_Sel;
         AV57BR_Encounter_RefuseReasonWWDS_7_Tfbr_encounter_refusereason_noapprovedate = AV29TFBR_Encounter_RefuseReason_NoApproveDate;
         AV58BR_Encounter_RefuseReasonWWDS_8_Tfbr_encounter_refusereason_noapprovedate_to = AV30TFBR_Encounter_RefuseReason_NoApproveDate_To;
         AV59BR_Encounter_RefuseReasonWWDS_9_Tfbr_encounter_refusereason_status_sels = AV36TFBR_Encounter_RefuseReason_Status_Sels;
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
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV17TFBR_Encounter_RefuseReasonID, AV18TFBR_Encounter_RefuseReasonID_To, AV21TFBR_EncounterID, AV22TFBR_EncounterID_To, AV25TFBR_Encounter_RefuseReason_Reason, AV26TFBR_Encounter_RefuseReason_Reason_Sel, AV29TFBR_Encounter_RefuseReason_NoApproveDate, AV30TFBR_Encounter_RefuseReason_NoApproveDate_To, AV19ddo_BR_Encounter_RefuseReasonIDTitleControlIdToReplace, AV23ddo_BR_EncounterIDTitleControlIdToReplace, AV27ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace, AV33ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace, AV37ddo_BR_Encounter_RefuseReason_StatusTitleControlIdToReplace, AV36TFBR_Encounter_RefuseReason_Status_Sels, AV63Pgmname, AV45IsAuthorized_Update, AV47IsAuthorized_Delete) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected int subgrid_gotopage( int nPageNo )
      {
         AV51BR_Encounter_RefuseReasonWWDS_1_Tfbr_encounter_refusereasonid = AV17TFBR_Encounter_RefuseReasonID;
         AV52BR_Encounter_RefuseReasonWWDS_2_Tfbr_encounter_refusereasonid_to = AV18TFBR_Encounter_RefuseReasonID_To;
         AV53BR_Encounter_RefuseReasonWWDS_3_Tfbr_encounterid = AV21TFBR_EncounterID;
         AV54BR_Encounter_RefuseReasonWWDS_4_Tfbr_encounterid_to = AV22TFBR_EncounterID_To;
         AV55BR_Encounter_RefuseReasonWWDS_5_Tfbr_encounter_refusereason_reason = AV25TFBR_Encounter_RefuseReason_Reason;
         AV56BR_Encounter_RefuseReasonWWDS_6_Tfbr_encounter_refusereason_reason_sel = AV26TFBR_Encounter_RefuseReason_Reason_Sel;
         AV57BR_Encounter_RefuseReasonWWDS_7_Tfbr_encounter_refusereason_noapprovedate = AV29TFBR_Encounter_RefuseReason_NoApproveDate;
         AV58BR_Encounter_RefuseReasonWWDS_8_Tfbr_encounter_refusereason_noapprovedate_to = AV30TFBR_Encounter_RefuseReason_NoApproveDate_To;
         AV59BR_Encounter_RefuseReasonWWDS_9_Tfbr_encounter_refusereason_status_sels = AV36TFBR_Encounter_RefuseReason_Status_Sels;
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
            gxgrGrid_refresh( subGrid_Rows, AV13OrderedBy, AV14OrderedDsc, AV17TFBR_Encounter_RefuseReasonID, AV18TFBR_Encounter_RefuseReasonID_To, AV21TFBR_EncounterID, AV22TFBR_EncounterID_To, AV25TFBR_Encounter_RefuseReason_Reason, AV26TFBR_Encounter_RefuseReason_Reason_Sel, AV29TFBR_Encounter_RefuseReason_NoApproveDate, AV30TFBR_Encounter_RefuseReason_NoApproveDate_To, AV19ddo_BR_Encounter_RefuseReasonIDTitleControlIdToReplace, AV23ddo_BR_EncounterIDTitleControlIdToReplace, AV27ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace, AV33ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace, AV37ddo_BR_Encounter_RefuseReason_StatusTitleControlIdToReplace, AV36TFBR_Encounter_RefuseReason_Status_Sels, AV63Pgmname, AV45IsAuthorized_Update, AV47IsAuthorized_Delete) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP7C0( )
      {
         /* Before Start, stand alone formulas. */
         AV63Pgmname = "BR_Encounter_RefuseReasonWW";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E197C2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( "vDDO_TITLESETTINGSICONS"), AV38DDO_TitleSettingsIcons);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_ENCOUNTER_REFUSEREASONIDTITLEFILTERDATA"), AV16BR_Encounter_RefuseReasonIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_ENCOUNTERIDTITLEFILTERDATA"), AV20BR_EncounterIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_ENCOUNTER_REFUSEREASON_REASONTITLEFILTERDATA"), AV24BR_Encounter_RefuseReason_ReasonTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATETITLEFILTERDATA"), AV28BR_Encounter_RefuseReason_NoApproveDateTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_ENCOUNTER_REFUSEREASON_STATUSTITLEFILTERDATA"), AV34BR_Encounter_RefuseReason_StatusTitleFilterData);
            /* Read variables values. */
            AV19ddo_BR_Encounter_RefuseReasonIDTitleControlIdToReplace = cgiGet( edtavDdo_br_encounter_refusereasonidtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19ddo_BR_Encounter_RefuseReasonIDTitleControlIdToReplace", AV19ddo_BR_Encounter_RefuseReasonIDTitleControlIdToReplace);
            AV23ddo_BR_EncounterIDTitleControlIdToReplace = cgiGet( edtavDdo_br_encounteridtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23ddo_BR_EncounterIDTitleControlIdToReplace", AV23ddo_BR_EncounterIDTitleControlIdToReplace);
            AV27ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace = cgiGet( edtavDdo_br_encounter_refusereason_reasontitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace", AV27ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace);
            AV33ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace = cgiGet( edtavDdo_br_encounter_refusereason_noapprovedatetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace", AV33ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace);
            AV37ddo_BR_Encounter_RefuseReason_StatusTitleControlIdToReplace = cgiGet( edtavDdo_br_encounter_refusereason_statustitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV37ddo_BR_Encounter_RefuseReason_StatusTitleControlIdToReplace", AV37ddo_BR_Encounter_RefuseReason_StatusTitleControlIdToReplace);
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
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_encounter_refusereasonid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_encounter_refusereasonid_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_ENCOUNTER_REFUSEREASONID");
               GX_FocusControl = edtavTfbr_encounter_refusereasonid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV17TFBR_Encounter_RefuseReasonID = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17TFBR_Encounter_RefuseReasonID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17TFBR_Encounter_RefuseReasonID), 18, 0)));
            }
            else
            {
               AV17TFBR_Encounter_RefuseReasonID = (long)(context.localUtil.CToN( cgiGet( edtavTfbr_encounter_refusereasonid_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17TFBR_Encounter_RefuseReasonID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17TFBR_Encounter_RefuseReasonID), 18, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_encounter_refusereasonid_to_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_encounter_refusereasonid_to_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_ENCOUNTER_REFUSEREASONID_TO");
               GX_FocusControl = edtavTfbr_encounter_refusereasonid_to_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV18TFBR_Encounter_RefuseReasonID_To = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18TFBR_Encounter_RefuseReasonID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18TFBR_Encounter_RefuseReasonID_To), 18, 0)));
            }
            else
            {
               AV18TFBR_Encounter_RefuseReasonID_To = (long)(context.localUtil.CToN( cgiGet( edtavTfbr_encounter_refusereasonid_to_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18TFBR_Encounter_RefuseReasonID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18TFBR_Encounter_RefuseReasonID_To), 18, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_encounterid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_encounterid_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_ENCOUNTERID");
               GX_FocusControl = edtavTfbr_encounterid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV21TFBR_EncounterID = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21TFBR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21TFBR_EncounterID), 18, 0)));
            }
            else
            {
               AV21TFBR_EncounterID = (long)(context.localUtil.CToN( cgiGet( edtavTfbr_encounterid_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21TFBR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21TFBR_EncounterID), 18, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_encounterid_to_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_encounterid_to_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_ENCOUNTERID_TO");
               GX_FocusControl = edtavTfbr_encounterid_to_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV22TFBR_EncounterID_To = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22TFBR_EncounterID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV22TFBR_EncounterID_To), 18, 0)));
            }
            else
            {
               AV22TFBR_EncounterID_To = (long)(context.localUtil.CToN( cgiGet( edtavTfbr_encounterid_to_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22TFBR_EncounterID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV22TFBR_EncounterID_To), 18, 0)));
            }
            AV25TFBR_Encounter_RefuseReason_Reason = cgiGet( edtavTfbr_encounter_refusereason_reason_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25TFBR_Encounter_RefuseReason_Reason", AV25TFBR_Encounter_RefuseReason_Reason);
            AV26TFBR_Encounter_RefuseReason_Reason_Sel = cgiGet( edtavTfbr_encounter_refusereason_reason_sel_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26TFBR_Encounter_RefuseReason_Reason_Sel", AV26TFBR_Encounter_RefuseReason_Reason_Sel);
            if ( context.localUtil.VCDateTime( cgiGet( edtavTfbr_encounter_refusereason_noapprovedate_Internalname), 0, 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"TFBR_Encounter_Refuse Reason_No Approve Date"}), 1, "vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE");
               GX_FocusControl = edtavTfbr_encounter_refusereason_noapprovedate_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV29TFBR_Encounter_RefuseReason_NoApproveDate = (DateTime)(DateTime.MinValue);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29TFBR_Encounter_RefuseReason_NoApproveDate", context.localUtil.TToC( AV29TFBR_Encounter_RefuseReason_NoApproveDate, 10, 8, 0, 0, "/", ":", " "));
            }
            else
            {
               AV29TFBR_Encounter_RefuseReason_NoApproveDate = context.localUtil.CToT( cgiGet( edtavTfbr_encounter_refusereason_noapprovedate_Internalname));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29TFBR_Encounter_RefuseReason_NoApproveDate", context.localUtil.TToC( AV29TFBR_Encounter_RefuseReason_NoApproveDate, 10, 8, 0, 0, "/", ":", " "));
            }
            if ( context.localUtil.VCDateTime( cgiGet( edtavTfbr_encounter_refusereason_noapprovedate_to_Internalname), 0, 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"TFBR_Encounter_Refuse Reason_No Approve Date_To"}), 1, "vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_TO");
               GX_FocusControl = edtavTfbr_encounter_refusereason_noapprovedate_to_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV30TFBR_Encounter_RefuseReason_NoApproveDate_To = (DateTime)(DateTime.MinValue);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30TFBR_Encounter_RefuseReason_NoApproveDate_To", context.localUtil.TToC( AV30TFBR_Encounter_RefuseReason_NoApproveDate_To, 10, 8, 0, 0, "/", ":", " "));
            }
            else
            {
               AV30TFBR_Encounter_RefuseReason_NoApproveDate_To = context.localUtil.CToT( cgiGet( edtavTfbr_encounter_refusereason_noapprovedate_to_Internalname));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30TFBR_Encounter_RefuseReason_NoApproveDate_To", context.localUtil.TToC( AV30TFBR_Encounter_RefuseReason_NoApproveDate_To, 10, 8, 0, 0, "/", ":", " "));
            }
            if ( context.localUtil.VCDate( cgiGet( edtavDdo_br_encounter_refusereason_noapprovedateauxdate_Internalname), 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"DDO_BR_Encounter_Refuse Reason_No Approve Date Aux Date"}), 1, "vDDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEAUXDATE");
               GX_FocusControl = edtavDdo_br_encounter_refusereason_noapprovedateauxdate_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV31DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDate = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDate", context.localUtil.Format(AV31DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDate, "9999/99/99"));
            }
            else
            {
               AV31DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDate = context.localUtil.CToD( cgiGet( edtavDdo_br_encounter_refusereason_noapprovedateauxdate_Internalname), 0);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDate", context.localUtil.Format(AV31DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDate, "9999/99/99"));
            }
            if ( context.localUtil.VCDate( cgiGet( edtavDdo_br_encounter_refusereason_noapprovedateauxdateto_Internalname), 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"DDO_BR_Encounter_Refuse Reason_No Approve Date Aux Date To"}), 1, "vDDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEAUXDATETO");
               GX_FocusControl = edtavDdo_br_encounter_refusereason_noapprovedateauxdateto_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV32DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDateTo = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV32DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDateTo", context.localUtil.Format(AV32DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDateTo, "9999/99/99"));
            }
            else
            {
               AV32DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDateTo = context.localUtil.CToD( cgiGet( edtavDdo_br_encounter_refusereason_noapprovedateauxdateto_Internalname), 0);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV32DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDateTo", context.localUtil.Format(AV32DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDateTo, "9999/99/99"));
            }
            /* Read saved values. */
            nRC_GXsfl_31 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_31"), ".", ","));
            AV40GridCurrentPage = (long)(context.localUtil.CToN( cgiGet( "vGRIDCURRENTPAGE"), ".", ","));
            AV42GridRecordCount = (long)(context.localUtil.CToN( cgiGet( "vGRIDRECORDCOUNT"), ".", ","));
            AV41GridPageSize = (long)(context.localUtil.CToN( cgiGet( "vGRIDPAGESIZE"), ".", ","));
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
            Ddo_br_encounter_refusereasonid_Caption = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASONID_Caption");
            Ddo_br_encounter_refusereasonid_Tooltip = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASONID_Tooltip");
            Ddo_br_encounter_refusereasonid_Cls = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASONID_Cls");
            Ddo_br_encounter_refusereasonid_Filteredtext_set = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASONID_Filteredtext_set");
            Ddo_br_encounter_refusereasonid_Filteredtextto_set = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASONID_Filteredtextto_set");
            Ddo_br_encounter_refusereasonid_Dropdownoptionstype = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASONID_Dropdownoptionstype");
            Ddo_br_encounter_refusereasonid_Titlecontrolidtoreplace = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASONID_Titlecontrolidtoreplace");
            Ddo_br_encounter_refusereasonid_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASONID_Includesortasc"));
            Ddo_br_encounter_refusereasonid_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASONID_Includesortdsc"));
            Ddo_br_encounter_refusereasonid_Sortedstatus = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASONID_Sortedstatus");
            Ddo_br_encounter_refusereasonid_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASONID_Includefilter"));
            Ddo_br_encounter_refusereasonid_Filtertype = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASONID_Filtertype");
            Ddo_br_encounter_refusereasonid_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASONID_Filterisrange"));
            Ddo_br_encounter_refusereasonid_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASONID_Includedatalist"));
            Ddo_br_encounter_refusereasonid_Sortasc = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASONID_Sortasc");
            Ddo_br_encounter_refusereasonid_Sortdsc = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASONID_Sortdsc");
            Ddo_br_encounter_refusereasonid_Cleanfilter = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASONID_Cleanfilter");
            Ddo_br_encounter_refusereasonid_Rangefilterfrom = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASONID_Rangefilterfrom");
            Ddo_br_encounter_refusereasonid_Rangefilterto = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASONID_Rangefilterto");
            Ddo_br_encounter_refusereasonid_Searchbuttontext = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASONID_Searchbuttontext");
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
            Ddo_br_encounter_refusereason_reason_Caption = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_REASON_Caption");
            Ddo_br_encounter_refusereason_reason_Tooltip = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_REASON_Tooltip");
            Ddo_br_encounter_refusereason_reason_Cls = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_REASON_Cls");
            Ddo_br_encounter_refusereason_reason_Filteredtext_set = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_REASON_Filteredtext_set");
            Ddo_br_encounter_refusereason_reason_Selectedvalue_set = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_REASON_Selectedvalue_set");
            Ddo_br_encounter_refusereason_reason_Dropdownoptionstype = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_REASON_Dropdownoptionstype");
            Ddo_br_encounter_refusereason_reason_Titlecontrolidtoreplace = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_REASON_Titlecontrolidtoreplace");
            Ddo_br_encounter_refusereason_reason_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_REASON_Includesortasc"));
            Ddo_br_encounter_refusereason_reason_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_REASON_Includesortdsc"));
            Ddo_br_encounter_refusereason_reason_Sortedstatus = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_REASON_Sortedstatus");
            Ddo_br_encounter_refusereason_reason_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_REASON_Includefilter"));
            Ddo_br_encounter_refusereason_reason_Filtertype = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_REASON_Filtertype");
            Ddo_br_encounter_refusereason_reason_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_REASON_Filterisrange"));
            Ddo_br_encounter_refusereason_reason_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_REASON_Includedatalist"));
            Ddo_br_encounter_refusereason_reason_Datalisttype = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_REASON_Datalisttype");
            Ddo_br_encounter_refusereason_reason_Datalistproc = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_REASON_Datalistproc");
            Ddo_br_encounter_refusereason_reason_Datalistupdateminimumcharacters = (int)(context.localUtil.CToN( cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_REASON_Datalistupdateminimumcharacters"), ".", ","));
            Ddo_br_encounter_refusereason_reason_Sortasc = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_REASON_Sortasc");
            Ddo_br_encounter_refusereason_reason_Sortdsc = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_REASON_Sortdsc");
            Ddo_br_encounter_refusereason_reason_Loadingdata = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_REASON_Loadingdata");
            Ddo_br_encounter_refusereason_reason_Cleanfilter = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_REASON_Cleanfilter");
            Ddo_br_encounter_refusereason_reason_Noresultsfound = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_REASON_Noresultsfound");
            Ddo_br_encounter_refusereason_reason_Searchbuttontext = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_REASON_Searchbuttontext");
            Ddo_br_encounter_refusereason_noapprovedate_Caption = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_Caption");
            Ddo_br_encounter_refusereason_noapprovedate_Tooltip = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_Tooltip");
            Ddo_br_encounter_refusereason_noapprovedate_Cls = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_Cls");
            Ddo_br_encounter_refusereason_noapprovedate_Filteredtext_set = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_Filteredtext_set");
            Ddo_br_encounter_refusereason_noapprovedate_Filteredtextto_set = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_Filteredtextto_set");
            Ddo_br_encounter_refusereason_noapprovedate_Dropdownoptionstype = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_Dropdownoptionstype");
            Ddo_br_encounter_refusereason_noapprovedate_Titlecontrolidtoreplace = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_Titlecontrolidtoreplace");
            Ddo_br_encounter_refusereason_noapprovedate_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_Includesortasc"));
            Ddo_br_encounter_refusereason_noapprovedate_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_Includesortdsc"));
            Ddo_br_encounter_refusereason_noapprovedate_Sortedstatus = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_Sortedstatus");
            Ddo_br_encounter_refusereason_noapprovedate_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_Includefilter"));
            Ddo_br_encounter_refusereason_noapprovedate_Filtertype = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_Filtertype");
            Ddo_br_encounter_refusereason_noapprovedate_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_Filterisrange"));
            Ddo_br_encounter_refusereason_noapprovedate_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_Includedatalist"));
            Ddo_br_encounter_refusereason_noapprovedate_Sortasc = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_Sortasc");
            Ddo_br_encounter_refusereason_noapprovedate_Sortdsc = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_Sortdsc");
            Ddo_br_encounter_refusereason_noapprovedate_Cleanfilter = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_Cleanfilter");
            Ddo_br_encounter_refusereason_noapprovedate_Rangefilterfrom = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_Rangefilterfrom");
            Ddo_br_encounter_refusereason_noapprovedate_Rangefilterto = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_Rangefilterto");
            Ddo_br_encounter_refusereason_noapprovedate_Searchbuttontext = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_Searchbuttontext");
            Ddo_br_encounter_refusereason_status_Caption = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_STATUS_Caption");
            Ddo_br_encounter_refusereason_status_Tooltip = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_STATUS_Tooltip");
            Ddo_br_encounter_refusereason_status_Cls = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_STATUS_Cls");
            Ddo_br_encounter_refusereason_status_Selectedvalue_set = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_STATUS_Selectedvalue_set");
            Ddo_br_encounter_refusereason_status_Dropdownoptionstype = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_STATUS_Dropdownoptionstype");
            Ddo_br_encounter_refusereason_status_Titlecontrolidtoreplace = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_STATUS_Titlecontrolidtoreplace");
            Ddo_br_encounter_refusereason_status_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_STATUS_Includesortasc"));
            Ddo_br_encounter_refusereason_status_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_STATUS_Includesortdsc"));
            Ddo_br_encounter_refusereason_status_Sortedstatus = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_STATUS_Sortedstatus");
            Ddo_br_encounter_refusereason_status_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_STATUS_Includefilter"));
            Ddo_br_encounter_refusereason_status_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_STATUS_Includedatalist"));
            Ddo_br_encounter_refusereason_status_Datalisttype = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_STATUS_Datalisttype");
            Ddo_br_encounter_refusereason_status_Allowmultipleselection = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_STATUS_Allowmultipleselection"));
            Ddo_br_encounter_refusereason_status_Datalistfixedvalues = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_STATUS_Datalistfixedvalues");
            Ddo_br_encounter_refusereason_status_Sortasc = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_STATUS_Sortasc");
            Ddo_br_encounter_refusereason_status_Sortdsc = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_STATUS_Sortdsc");
            Ddo_br_encounter_refusereason_status_Cleanfilter = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_STATUS_Cleanfilter");
            Ddo_br_encounter_refusereason_status_Searchbuttontext = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_STATUS_Searchbuttontext");
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( "GRID_Rows"), ".", ","));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            Gridpaginationbar_Selectedpage = cgiGet( "GRIDPAGINATIONBAR_Selectedpage");
            Gridpaginationbar_Rowsperpageselectedvalue = (int)(context.localUtil.CToN( cgiGet( "GRIDPAGINATIONBAR_Rowsperpageselectedvalue"), ".", ","));
            Ddo_br_encounter_refusereasonid_Activeeventkey = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASONID_Activeeventkey");
            Ddo_br_encounter_refusereasonid_Filteredtext_get = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASONID_Filteredtext_get");
            Ddo_br_encounter_refusereasonid_Filteredtextto_get = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASONID_Filteredtextto_get");
            Ddo_br_encounterid_Activeeventkey = cgiGet( "DDO_BR_ENCOUNTERID_Activeeventkey");
            Ddo_br_encounterid_Filteredtext_get = cgiGet( "DDO_BR_ENCOUNTERID_Filteredtext_get");
            Ddo_br_encounterid_Filteredtextto_get = cgiGet( "DDO_BR_ENCOUNTERID_Filteredtextto_get");
            Ddo_br_encounter_refusereason_reason_Activeeventkey = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_REASON_Activeeventkey");
            Ddo_br_encounter_refusereason_reason_Filteredtext_get = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_REASON_Filteredtext_get");
            Ddo_br_encounter_refusereason_reason_Selectedvalue_get = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_REASON_Selectedvalue_get");
            Ddo_br_encounter_refusereason_noapprovedate_Activeeventkey = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_Activeeventkey");
            Ddo_br_encounter_refusereason_noapprovedate_Filteredtext_get = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_Filteredtext_get");
            Ddo_br_encounter_refusereason_noapprovedate_Filteredtextto_get = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_Filteredtextto_get");
            Ddo_br_encounter_refusereason_status_Activeeventkey = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_STATUS_Activeeventkey");
            Ddo_br_encounter_refusereason_status_Selectedvalue_get = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_STATUS_Selectedvalue_get");
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
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_ENCOUNTER_REFUSEREASONID"), ".", ",") != Convert.ToDecimal( AV17TFBR_Encounter_RefuseReasonID )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_ENCOUNTER_REFUSEREASONID_TO"), ".", ",") != Convert.ToDecimal( AV18TFBR_Encounter_RefuseReasonID_To )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_ENCOUNTERID"), ".", ",") != Convert.ToDecimal( AV21TFBR_EncounterID )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_ENCOUNTERID_TO"), ".", ",") != Convert.ToDecimal( AV22TFBR_EncounterID_To )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_ENCOUNTER_REFUSEREASON_REASON"), AV25TFBR_Encounter_RefuseReason_Reason) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_ENCOUNTER_REFUSEREASON_REASON_SEL"), AV26TFBR_Encounter_RefuseReason_Reason_Sel) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToT( cgiGet( "GXH_vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE")) != AV29TFBR_Encounter_RefuseReason_NoApproveDate )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToT( cgiGet( "GXH_vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_TO")) != AV30TFBR_Encounter_RefuseReason_NoApproveDate_To )
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
         E197C2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E197C2( )
      {
         /* Start Routine */
         subGrid_Rows = 9;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         edtavTfbr_encounter_refusereasonid_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_encounter_refusereasonid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_encounter_refusereasonid_Visible), 5, 0)), true);
         edtavTfbr_encounter_refusereasonid_to_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_encounter_refusereasonid_to_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_encounter_refusereasonid_to_Visible), 5, 0)), true);
         edtavTfbr_encounterid_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_encounterid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_encounterid_Visible), 5, 0)), true);
         edtavTfbr_encounterid_to_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_encounterid_to_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_encounterid_to_Visible), 5, 0)), true);
         edtavTfbr_encounter_refusereason_reason_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_encounter_refusereason_reason_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_encounter_refusereason_reason_Visible), 5, 0)), true);
         edtavTfbr_encounter_refusereason_reason_sel_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_encounter_refusereason_reason_sel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_encounter_refusereason_reason_sel_Visible), 5, 0)), true);
         edtavTfbr_encounter_refusereason_noapprovedate_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_encounter_refusereason_noapprovedate_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_encounter_refusereason_noapprovedate_Visible), 5, 0)), true);
         edtavTfbr_encounter_refusereason_noapprovedate_to_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_encounter_refusereason_noapprovedate_to_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_encounter_refusereason_noapprovedate_to_Visible), 5, 0)), true);
         Ddo_br_encounter_refusereasonid_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Encounter_RefuseReasonID";
         ucDdo_br_encounter_refusereasonid.SendProperty(context, "", false, Ddo_br_encounter_refusereasonid_Internalname, "TitleControlIdToReplace", Ddo_br_encounter_refusereasonid_Titlecontrolidtoreplace);
         AV19ddo_BR_Encounter_RefuseReasonIDTitleControlIdToReplace = Ddo_br_encounter_refusereasonid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19ddo_BR_Encounter_RefuseReasonIDTitleControlIdToReplace", AV19ddo_BR_Encounter_RefuseReasonIDTitleControlIdToReplace);
         edtavDdo_br_encounter_refusereasonidtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_encounter_refusereasonidtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_encounter_refusereasonidtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_encounterid_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_EncounterID";
         ucDdo_br_encounterid.SendProperty(context, "", false, Ddo_br_encounterid_Internalname, "TitleControlIdToReplace", Ddo_br_encounterid_Titlecontrolidtoreplace);
         AV23ddo_BR_EncounterIDTitleControlIdToReplace = Ddo_br_encounterid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23ddo_BR_EncounterIDTitleControlIdToReplace", AV23ddo_BR_EncounterIDTitleControlIdToReplace);
         edtavDdo_br_encounteridtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_encounteridtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_encounteridtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_encounter_refusereason_reason_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Encounter_RefuseReason_Reason";
         ucDdo_br_encounter_refusereason_reason.SendProperty(context, "", false, Ddo_br_encounter_refusereason_reason_Internalname, "TitleControlIdToReplace", Ddo_br_encounter_refusereason_reason_Titlecontrolidtoreplace);
         AV27ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace = Ddo_br_encounter_refusereason_reason_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace", AV27ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace);
         edtavDdo_br_encounter_refusereason_reasontitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_encounter_refusereason_reasontitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_encounter_refusereason_reasontitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_encounter_refusereason_noapprovedate_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Encounter_RefuseReason_NoApproveDate";
         ucDdo_br_encounter_refusereason_noapprovedate.SendProperty(context, "", false, Ddo_br_encounter_refusereason_noapprovedate_Internalname, "TitleControlIdToReplace", Ddo_br_encounter_refusereason_noapprovedate_Titlecontrolidtoreplace);
         AV33ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace = Ddo_br_encounter_refusereason_noapprovedate_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace", AV33ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace);
         edtavDdo_br_encounter_refusereason_noapprovedatetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_encounter_refusereason_noapprovedatetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_encounter_refusereason_noapprovedatetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_encounter_refusereason_status_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Encounter_RefuseReason_Status";
         ucDdo_br_encounter_refusereason_status.SendProperty(context, "", false, Ddo_br_encounter_refusereason_status_Internalname, "TitleControlIdToReplace", Ddo_br_encounter_refusereason_status_Titlecontrolidtoreplace);
         AV37ddo_BR_Encounter_RefuseReason_StatusTitleControlIdToReplace = Ddo_br_encounter_refusereason_status_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV37ddo_BR_Encounter_RefuseReason_StatusTitleControlIdToReplace", AV37ddo_BR_Encounter_RefuseReason_StatusTitleControlIdToReplace);
         edtavDdo_br_encounter_refusereason_statustitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_encounter_refusereason_statustitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_encounter_refusereason_statustitlecontrolidtoreplace_Visible), 5, 0)), true);
         Form.Caption = " 就诊信息驳回原因";
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
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 = AV38DDO_TitleSettingsIcons;
         new GeneXus.Programs.wwpbaseobjects.getwwptitlesettingsicons(context ).execute( out  GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1) ;
         AV38DDO_TitleSettingsIcons = GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1;
         Gridpaginationbar_Rowsperpageselectedvalue = subGrid_Rows;
         ucGridpaginationbar.SendProperty(context, "", false, Gridpaginationbar_Internalname, "RowsPerPageSelectedValue", StringUtil.LTrim( StringUtil.Str( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0)));
      }

      protected void E207C2( )
      {
         if ( gx_refresh_fired )
         {
            return  ;
         }
         gx_refresh_fired = true;
         /* Refresh Routine */
         AV16BR_Encounter_RefuseReasonIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV20BR_EncounterIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV24BR_Encounter_RefuseReason_ReasonTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV28BR_Encounter_RefuseReason_NoApproveDateTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV34BR_Encounter_RefuseReason_StatusTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
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
         edtBR_Encounter_RefuseReasonID_Titleformat = 2;
         edtBR_Encounter_RefuseReasonID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "Reason ID", AV19ddo_BR_Encounter_RefuseReasonIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Encounter_RefuseReasonID_Internalname, "Title", edtBR_Encounter_RefuseReasonID_Title, !bGXsfl_31_Refreshing);
         edtBR_EncounterID_Titleformat = 2;
         edtBR_EncounterID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "就诊信息主键", AV23ddo_BR_EncounterIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_EncounterID_Internalname, "Title", edtBR_EncounterID_Title, !bGXsfl_31_Refreshing);
         edtBR_Encounter_RefuseReason_Reason_Titleformat = 2;
         edtBR_Encounter_RefuseReason_Reason_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "初审不通过原因", AV27ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Encounter_RefuseReason_Reason_Internalname, "Title", edtBR_Encounter_RefuseReason_Reason_Title, !bGXsfl_31_Refreshing);
         edtBR_Encounter_RefuseReason_NoApproveDate_Titleformat = 2;
         edtBR_Encounter_RefuseReason_NoApproveDate_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "初审不通过时间", AV33ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Encounter_RefuseReason_NoApproveDate_Internalname, "Title", edtBR_Encounter_RefuseReason_NoApproveDate_Title, !bGXsfl_31_Refreshing);
         cmbBR_Encounter_RefuseReason_Status_Titleformat = 2;
         cmbBR_Encounter_RefuseReason_Status.Title.Text = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "初审不通过状态", AV37ddo_BR_Encounter_RefuseReason_StatusTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Encounter_RefuseReason_Status_Internalname, "Title", cmbBR_Encounter_RefuseReason_Status.Title.Text, !bGXsfl_31_Refreshing);
         AV40GridCurrentPage = subGrid_Currentpage( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV40GridCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV40GridCurrentPage), 10, 0)));
         AV41GridPageSize = subGrid_Rows;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV41GridPageSize", StringUtil.LTrim( StringUtil.Str( (decimal)(AV41GridPageSize), 10, 0)));
         AV42GridRecordCount = subGrid_Recordcount( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV42GridRecordCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV42GridRecordCount), 10, 0)));
         AV51BR_Encounter_RefuseReasonWWDS_1_Tfbr_encounter_refusereasonid = AV17TFBR_Encounter_RefuseReasonID;
         AV52BR_Encounter_RefuseReasonWWDS_2_Tfbr_encounter_refusereasonid_to = AV18TFBR_Encounter_RefuseReasonID_To;
         AV53BR_Encounter_RefuseReasonWWDS_3_Tfbr_encounterid = AV21TFBR_EncounterID;
         AV54BR_Encounter_RefuseReasonWWDS_4_Tfbr_encounterid_to = AV22TFBR_EncounterID_To;
         AV55BR_Encounter_RefuseReasonWWDS_5_Tfbr_encounter_refusereason_reason = AV25TFBR_Encounter_RefuseReason_Reason;
         AV56BR_Encounter_RefuseReasonWWDS_6_Tfbr_encounter_refusereason_reason_sel = AV26TFBR_Encounter_RefuseReason_Reason_Sel;
         AV57BR_Encounter_RefuseReasonWWDS_7_Tfbr_encounter_refusereason_noapprovedate = AV29TFBR_Encounter_RefuseReason_NoApproveDate;
         AV58BR_Encounter_RefuseReasonWWDS_8_Tfbr_encounter_refusereason_noapprovedate_to = AV30TFBR_Encounter_RefuseReason_NoApproveDate_To;
         AV59BR_Encounter_RefuseReasonWWDS_9_Tfbr_encounter_refusereason_status_sels = AV36TFBR_Encounter_RefuseReason_Status_Sels;
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Encounter_RefuseReasonIDTitleFilterData", AV16BR_Encounter_RefuseReasonIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_EncounterIDTitleFilterData", AV20BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Encounter_RefuseReason_ReasonTitleFilterData", AV24BR_Encounter_RefuseReason_ReasonTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Encounter_RefuseReason_NoApproveDateTitleFilterData", AV28BR_Encounter_RefuseReason_NoApproveDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34BR_Encounter_RefuseReason_StatusTitleFilterData", AV34BR_Encounter_RefuseReason_StatusTitleFilterData);
      }

      protected void E117C2( )
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
            AV39PageToGo = (int)(NumberUtil.Val( Gridpaginationbar_Selectedpage, "."));
            subgrid_gotopage( AV39PageToGo) ;
         }
      }

      protected void E127C2( )
      {
         /* Gridpaginationbar_Changerowsperpage Routine */
         subGrid_Rows = Gridpaginationbar_Rowsperpageselectedvalue;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         subgrid_firstpage( ) ;
         /*  Sending Event outputs  */
      }

      protected void E137C2( )
      {
         /* Ddo_br_encounter_refusereasonid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_encounter_refusereasonid_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_br_encounter_refusereasonid_Sortedstatus = "ASC";
            ucDdo_br_encounter_refusereasonid.SendProperty(context, "", false, Ddo_br_encounter_refusereasonid_Internalname, "SortedStatus", Ddo_br_encounter_refusereasonid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_encounter_refusereasonid_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_br_encounter_refusereasonid_Sortedstatus = "DSC";
            ucDdo_br_encounter_refusereasonid.SendProperty(context, "", false, Ddo_br_encounter_refusereasonid_Internalname, "SortedStatus", Ddo_br_encounter_refusereasonid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_encounter_refusereasonid_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV17TFBR_Encounter_RefuseReasonID = (long)(NumberUtil.Val( Ddo_br_encounter_refusereasonid_Filteredtext_get, "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17TFBR_Encounter_RefuseReasonID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17TFBR_Encounter_RefuseReasonID), 18, 0)));
            AV18TFBR_Encounter_RefuseReasonID_To = (long)(NumberUtil.Val( Ddo_br_encounter_refusereasonid_Filteredtextto_get, "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18TFBR_Encounter_RefuseReasonID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18TFBR_Encounter_RefuseReasonID_To), 18, 0)));
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Encounter_RefuseReasonIDTitleFilterData", AV16BR_Encounter_RefuseReasonIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_EncounterIDTitleFilterData", AV20BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Encounter_RefuseReason_ReasonTitleFilterData", AV24BR_Encounter_RefuseReason_ReasonTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Encounter_RefuseReason_NoApproveDateTitleFilterData", AV28BR_Encounter_RefuseReason_NoApproveDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34BR_Encounter_RefuseReason_StatusTitleFilterData", AV34BR_Encounter_RefuseReason_StatusTitleFilterData);
      }

      protected void E147C2( )
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
            AV21TFBR_EncounterID = (long)(NumberUtil.Val( Ddo_br_encounterid_Filteredtext_get, "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21TFBR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21TFBR_EncounterID), 18, 0)));
            AV22TFBR_EncounterID_To = (long)(NumberUtil.Val( Ddo_br_encounterid_Filteredtextto_get, "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22TFBR_EncounterID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV22TFBR_EncounterID_To), 18, 0)));
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Encounter_RefuseReasonIDTitleFilterData", AV16BR_Encounter_RefuseReasonIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_EncounterIDTitleFilterData", AV20BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Encounter_RefuseReason_ReasonTitleFilterData", AV24BR_Encounter_RefuseReason_ReasonTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Encounter_RefuseReason_NoApproveDateTitleFilterData", AV28BR_Encounter_RefuseReason_NoApproveDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34BR_Encounter_RefuseReason_StatusTitleFilterData", AV34BR_Encounter_RefuseReason_StatusTitleFilterData);
      }

      protected void E157C2( )
      {
         /* Ddo_br_encounter_refusereason_reason_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_encounter_refusereason_reason_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_br_encounter_refusereason_reason_Sortedstatus = "ASC";
            ucDdo_br_encounter_refusereason_reason.SendProperty(context, "", false, Ddo_br_encounter_refusereason_reason_Internalname, "SortedStatus", Ddo_br_encounter_refusereason_reason_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_encounter_refusereason_reason_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_br_encounter_refusereason_reason_Sortedstatus = "DSC";
            ucDdo_br_encounter_refusereason_reason.SendProperty(context, "", false, Ddo_br_encounter_refusereason_reason_Internalname, "SortedStatus", Ddo_br_encounter_refusereason_reason_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_encounter_refusereason_reason_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV25TFBR_Encounter_RefuseReason_Reason = Ddo_br_encounter_refusereason_reason_Filteredtext_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25TFBR_Encounter_RefuseReason_Reason", AV25TFBR_Encounter_RefuseReason_Reason);
            AV26TFBR_Encounter_RefuseReason_Reason_Sel = Ddo_br_encounter_refusereason_reason_Selectedvalue_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26TFBR_Encounter_RefuseReason_Reason_Sel", AV26TFBR_Encounter_RefuseReason_Reason_Sel);
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Encounter_RefuseReasonIDTitleFilterData", AV16BR_Encounter_RefuseReasonIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_EncounterIDTitleFilterData", AV20BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Encounter_RefuseReason_ReasonTitleFilterData", AV24BR_Encounter_RefuseReason_ReasonTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Encounter_RefuseReason_NoApproveDateTitleFilterData", AV28BR_Encounter_RefuseReason_NoApproveDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34BR_Encounter_RefuseReason_StatusTitleFilterData", AV34BR_Encounter_RefuseReason_StatusTitleFilterData);
      }

      protected void E167C2( )
      {
         /* Ddo_br_encounter_refusereason_noapprovedate_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_encounter_refusereason_noapprovedate_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_br_encounter_refusereason_noapprovedate_Sortedstatus = "ASC";
            ucDdo_br_encounter_refusereason_noapprovedate.SendProperty(context, "", false, Ddo_br_encounter_refusereason_noapprovedate_Internalname, "SortedStatus", Ddo_br_encounter_refusereason_noapprovedate_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_encounter_refusereason_noapprovedate_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_br_encounter_refusereason_noapprovedate_Sortedstatus = "DSC";
            ucDdo_br_encounter_refusereason_noapprovedate.SendProperty(context, "", false, Ddo_br_encounter_refusereason_noapprovedate_Internalname, "SortedStatus", Ddo_br_encounter_refusereason_noapprovedate_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_encounter_refusereason_noapprovedate_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV29TFBR_Encounter_RefuseReason_NoApproveDate = context.localUtil.CToT( Ddo_br_encounter_refusereason_noapprovedate_Filteredtext_get, 0);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29TFBR_Encounter_RefuseReason_NoApproveDate", context.localUtil.TToC( AV29TFBR_Encounter_RefuseReason_NoApproveDate, 10, 8, 0, 0, "/", ":", " "));
            AV30TFBR_Encounter_RefuseReason_NoApproveDate_To = context.localUtil.CToT( Ddo_br_encounter_refusereason_noapprovedate_Filteredtextto_get, 0);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30TFBR_Encounter_RefuseReason_NoApproveDate_To", context.localUtil.TToC( AV30TFBR_Encounter_RefuseReason_NoApproveDate_To, 10, 8, 0, 0, "/", ":", " "));
            if ( ! (DateTime.MinValue==AV30TFBR_Encounter_RefuseReason_NoApproveDate_To) )
            {
               AV30TFBR_Encounter_RefuseReason_NoApproveDate_To = context.localUtil.YMDHMSToT( (short)(DateTimeUtil.Year( AV30TFBR_Encounter_RefuseReason_NoApproveDate_To)), (short)(DateTimeUtil.Month( AV30TFBR_Encounter_RefuseReason_NoApproveDate_To)), (short)(DateTimeUtil.Day( AV30TFBR_Encounter_RefuseReason_NoApproveDate_To)), 23, 59, 59);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30TFBR_Encounter_RefuseReason_NoApproveDate_To", context.localUtil.TToC( AV30TFBR_Encounter_RefuseReason_NoApproveDate_To, 10, 8, 0, 0, "/", ":", " "));
            }
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Encounter_RefuseReasonIDTitleFilterData", AV16BR_Encounter_RefuseReasonIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_EncounterIDTitleFilterData", AV20BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Encounter_RefuseReason_ReasonTitleFilterData", AV24BR_Encounter_RefuseReason_ReasonTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Encounter_RefuseReason_NoApproveDateTitleFilterData", AV28BR_Encounter_RefuseReason_NoApproveDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34BR_Encounter_RefuseReason_StatusTitleFilterData", AV34BR_Encounter_RefuseReason_StatusTitleFilterData);
      }

      protected void E177C2( )
      {
         /* Ddo_br_encounter_refusereason_status_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_encounter_refusereason_status_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_br_encounter_refusereason_status_Sortedstatus = "ASC";
            ucDdo_br_encounter_refusereason_status.SendProperty(context, "", false, Ddo_br_encounter_refusereason_status_Internalname, "SortedStatus", Ddo_br_encounter_refusereason_status_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_encounter_refusereason_status_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_br_encounter_refusereason_status_Sortedstatus = "DSC";
            ucDdo_br_encounter_refusereason_status.SendProperty(context, "", false, Ddo_br_encounter_refusereason_status_Internalname, "SortedStatus", Ddo_br_encounter_refusereason_status_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_encounter_refusereason_status_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV35TFBR_Encounter_RefuseReason_Status_SelsJson = Ddo_br_encounter_refusereason_status_Selectedvalue_get;
            AV36TFBR_Encounter_RefuseReason_Status_Sels.FromJSonString(StringUtil.StringReplace( AV35TFBR_Encounter_RefuseReason_Status_SelsJson, "\"", ""), null);
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36TFBR_Encounter_RefuseReason_Status_Sels", AV36TFBR_Encounter_RefuseReason_Status_Sels);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Encounter_RefuseReasonIDTitleFilterData", AV16BR_Encounter_RefuseReasonIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_EncounterIDTitleFilterData", AV20BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Encounter_RefuseReason_ReasonTitleFilterData", AV24BR_Encounter_RefuseReason_ReasonTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Encounter_RefuseReason_NoApproveDateTitleFilterData", AV28BR_Encounter_RefuseReason_NoApproveDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34BR_Encounter_RefuseReason_StatusTitleFilterData", AV34BR_Encounter_RefuseReason_StatusTitleFilterData);
      }

      private void E217C2( )
      {
         /* Grid_Load Routine */
         AV43Display = context.GetImagePath( "f11923b6-6acd-4a79-bfc0-0cfc6f3bced5", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavDisplay_Internalname, AV43Display);
         AV60Display_GXI = GXDbFile.PathToUrl( context.GetImagePath( "f11923b6-6acd-4a79-bfc0-0cfc6f3bced5", "", context.GetTheme( )));
         edtavDisplay_Tooltiptext = "显示";
         edtavDisplay_Link = formatLink("br_encounter_refusereasonview.aspx") + "?" + UrlEncode("" +A348BR_Encounter_RefuseReasonID) + "," + UrlEncode(StringUtil.RTrim(""));
         AV44Update = context.GetImagePath( "7c63c2b9-483e-4035-b512-febf9186a274", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavUpdate_Internalname, AV44Update);
         AV61Update_GXI = GXDbFile.PathToUrl( context.GetImagePath( "7c63c2b9-483e-4035-b512-febf9186a274", "", context.GetTheme( )));
         edtavUpdate_Tooltiptext = "修改";
         if ( AV45IsAuthorized_Update )
         {
            edtavUpdate_Link = formatLink("br_encounter_refusereason.aspx") + "?" + UrlEncode(StringUtil.RTrim("UPD")) + "," + UrlEncode("" +A348BR_Encounter_RefuseReasonID);
         }
         AV46Delete = context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavDelete_Internalname, AV46Delete);
         AV62Delete_GXI = GXDbFile.PathToUrl( context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", context.GetTheme( )));
         edtavDelete_Tooltiptext = "删除";
         if ( AV47IsAuthorized_Delete )
         {
            edtavDelete_Link = formatLink("br_encounter_refusereason.aspx") + "?" + UrlEncode(StringUtil.RTrim("DLT")) + "," + UrlEncode("" +A348BR_Encounter_RefuseReasonID);
         }
         edtBR_Encounter_RefuseReason_Reason_Link = formatLink("br_encounter_refusereasonview.aspx") + "?" + UrlEncode("" +A348BR_Encounter_RefuseReasonID) + "," + UrlEncode(StringUtil.RTrim(""));
         /* Load Method */
         if ( wbStart != -1 )
         {
            wbStart = 31;
         }
         sendrow_312( ) ;
         GRID_nCurrentRecord = (long)(GRID_nCurrentRecord+1);
         if ( isFullAjaxMode( ) && ! bGXsfl_31_Refreshing )
         {
            context.DoAjaxLoad(31, GridRow);
         }
         /*  Sending Event outputs  */
      }

      protected void E187C2( )
      {
         /* 'DoInsert' Routine */
         CallWebObject(formatLink("br_encounter_refusereason.aspx") + "?" + UrlEncode(StringUtil.RTrim("INS")) + "," + UrlEncode("" +0));
         context.wjLocDisableFrm = 1;
      }

      protected void S162( )
      {
         /* 'RESETDDOSORTEDSTATUS' Routine */
         Ddo_br_encounter_refusereasonid_Sortedstatus = "";
         ucDdo_br_encounter_refusereasonid.SendProperty(context, "", false, Ddo_br_encounter_refusereasonid_Internalname, "SortedStatus", Ddo_br_encounter_refusereasonid_Sortedstatus);
         Ddo_br_encounterid_Sortedstatus = "";
         ucDdo_br_encounterid.SendProperty(context, "", false, Ddo_br_encounterid_Internalname, "SortedStatus", Ddo_br_encounterid_Sortedstatus);
         Ddo_br_encounter_refusereason_reason_Sortedstatus = "";
         ucDdo_br_encounter_refusereason_reason.SendProperty(context, "", false, Ddo_br_encounter_refusereason_reason_Internalname, "SortedStatus", Ddo_br_encounter_refusereason_reason_Sortedstatus);
         Ddo_br_encounter_refusereason_noapprovedate_Sortedstatus = "";
         ucDdo_br_encounter_refusereason_noapprovedate.SendProperty(context, "", false, Ddo_br_encounter_refusereason_noapprovedate_Internalname, "SortedStatus", Ddo_br_encounter_refusereason_noapprovedate_Sortedstatus);
         Ddo_br_encounter_refusereason_status_Sortedstatus = "";
         ucDdo_br_encounter_refusereason_status.SendProperty(context, "", false, Ddo_br_encounter_refusereason_status_Internalname, "SortedStatus", Ddo_br_encounter_refusereason_status_Sortedstatus);
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
            Ddo_br_encounter_refusereasonid_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_encounter_refusereasonid.SendProperty(context, "", false, Ddo_br_encounter_refusereasonid_Internalname, "SortedStatus", Ddo_br_encounter_refusereasonid_Sortedstatus);
         }
         else if ( AV13OrderedBy == 2 )
         {
            Ddo_br_encounterid_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_encounterid.SendProperty(context, "", false, Ddo_br_encounterid_Internalname, "SortedStatus", Ddo_br_encounterid_Sortedstatus);
         }
         else if ( AV13OrderedBy == 3 )
         {
            Ddo_br_encounter_refusereason_reason_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_encounter_refusereason_reason.SendProperty(context, "", false, Ddo_br_encounter_refusereason_reason_Internalname, "SortedStatus", Ddo_br_encounter_refusereason_reason_Sortedstatus);
         }
         else if ( AV13OrderedBy == 4 )
         {
            Ddo_br_encounter_refusereason_noapprovedate_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_encounter_refusereason_noapprovedate.SendProperty(context, "", false, Ddo_br_encounter_refusereason_noapprovedate_Internalname, "SortedStatus", Ddo_br_encounter_refusereason_noapprovedate_Sortedstatus);
         }
         else if ( AV13OrderedBy == 5 )
         {
            Ddo_br_encounter_refusereason_status_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_encounter_refusereason_status.SendProperty(context, "", false, Ddo_br_encounter_refusereason_status_Internalname, "SortedStatus", Ddo_br_encounter_refusereason_status_Sortedstatus);
         }
      }

      protected void S142( )
      {
         /* 'CHECKSECURITYFORACTIONS' Routine */
         GXt_boolean2 = AV45IsAuthorized_Update;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Check_RefuteReason", out  GXt_boolean2) ;
         AV45IsAuthorized_Update = GXt_boolean2;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV45IsAuthorized_Update", AV45IsAuthorized_Update);
         if ( ! ( AV45IsAuthorized_Update ) )
         {
            edtavUpdate_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUpdate_Visible), 5, 0)), !bGXsfl_31_Refreshing);
         }
         GXt_boolean2 = AV47IsAuthorized_Delete;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Check_RefuteReason", out  GXt_boolean2) ;
         AV47IsAuthorized_Delete = GXt_boolean2;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV47IsAuthorized_Delete", AV47IsAuthorized_Delete);
         if ( ! ( AV47IsAuthorized_Delete ) )
         {
            edtavDelete_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDelete_Visible), 5, 0)), !bGXsfl_31_Refreshing);
         }
         GXt_boolean2 = AV48TempBoolean;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Check_RefuteReason", out  GXt_boolean2) ;
         AV48TempBoolean = GXt_boolean2;
         if ( ! ( AV48TempBoolean ) )
         {
            bttBtninsert_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtninsert_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtninsert_Visible), 5, 0)), true);
         }
      }

      protected void S122( )
      {
         /* 'LOADGRIDSTATE' Routine */
         if ( StringUtil.StrCmp(AV15Session.Get(AV63Pgmname+"GridState"), "") == 0 )
         {
            AV11GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  AV63Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         else
         {
            AV11GridState.FromXml(AV15Session.Get(AV63Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
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
         AV64GXV1 = 1;
         while ( AV64GXV1 <= AV11GridState.gxTpr_Filtervalues.Count )
         {
            AV12GridStateFilterValue = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue)AV11GridState.gxTpr_Filtervalues.Item(AV64GXV1));
            if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_ENCOUNTER_REFUSEREASONID") == 0 )
            {
               AV17TFBR_Encounter_RefuseReasonID = (long)(NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Value, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17TFBR_Encounter_RefuseReasonID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17TFBR_Encounter_RefuseReasonID), 18, 0)));
               AV18TFBR_Encounter_RefuseReasonID_To = (long)(NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Valueto, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18TFBR_Encounter_RefuseReasonID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18TFBR_Encounter_RefuseReasonID_To), 18, 0)));
               if ( ! (0==AV17TFBR_Encounter_RefuseReasonID) )
               {
                  Ddo_br_encounter_refusereasonid_Filteredtext_set = StringUtil.Str( (decimal)(AV17TFBR_Encounter_RefuseReasonID), 18, 0);
                  ucDdo_br_encounter_refusereasonid.SendProperty(context, "", false, Ddo_br_encounter_refusereasonid_Internalname, "FilteredText_set", Ddo_br_encounter_refusereasonid_Filteredtext_set);
               }
               if ( ! (0==AV18TFBR_Encounter_RefuseReasonID_To) )
               {
                  Ddo_br_encounter_refusereasonid_Filteredtextto_set = StringUtil.Str( (decimal)(AV18TFBR_Encounter_RefuseReasonID_To), 18, 0);
                  ucDdo_br_encounter_refusereasonid.SendProperty(context, "", false, Ddo_br_encounter_refusereasonid_Internalname, "FilteredTextTo_set", Ddo_br_encounter_refusereasonid_Filteredtextto_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_ENCOUNTERID") == 0 )
            {
               AV21TFBR_EncounterID = (long)(NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Value, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21TFBR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21TFBR_EncounterID), 18, 0)));
               AV22TFBR_EncounterID_To = (long)(NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Valueto, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22TFBR_EncounterID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV22TFBR_EncounterID_To), 18, 0)));
               if ( ! (0==AV21TFBR_EncounterID) )
               {
                  Ddo_br_encounterid_Filteredtext_set = StringUtil.Str( (decimal)(AV21TFBR_EncounterID), 18, 0);
                  ucDdo_br_encounterid.SendProperty(context, "", false, Ddo_br_encounterid_Internalname, "FilteredText_set", Ddo_br_encounterid_Filteredtext_set);
               }
               if ( ! (0==AV22TFBR_EncounterID_To) )
               {
                  Ddo_br_encounterid_Filteredtextto_set = StringUtil.Str( (decimal)(AV22TFBR_EncounterID_To), 18, 0);
                  ucDdo_br_encounterid.SendProperty(context, "", false, Ddo_br_encounterid_Internalname, "FilteredTextTo_set", Ddo_br_encounterid_Filteredtextto_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_ENCOUNTER_REFUSEREASON_REASON") == 0 )
            {
               AV25TFBR_Encounter_RefuseReason_Reason = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25TFBR_Encounter_RefuseReason_Reason", AV25TFBR_Encounter_RefuseReason_Reason);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV25TFBR_Encounter_RefuseReason_Reason)) )
               {
                  Ddo_br_encounter_refusereason_reason_Filteredtext_set = AV25TFBR_Encounter_RefuseReason_Reason;
                  ucDdo_br_encounter_refusereason_reason.SendProperty(context, "", false, Ddo_br_encounter_refusereason_reason_Internalname, "FilteredText_set", Ddo_br_encounter_refusereason_reason_Filteredtext_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_ENCOUNTER_REFUSEREASON_REASON_SEL") == 0 )
            {
               AV26TFBR_Encounter_RefuseReason_Reason_Sel = AV12GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26TFBR_Encounter_RefuseReason_Reason_Sel", AV26TFBR_Encounter_RefuseReason_Reason_Sel);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV26TFBR_Encounter_RefuseReason_Reason_Sel)) )
               {
                  Ddo_br_encounter_refusereason_reason_Selectedvalue_set = AV26TFBR_Encounter_RefuseReason_Reason_Sel;
                  ucDdo_br_encounter_refusereason_reason.SendProperty(context, "", false, Ddo_br_encounter_refusereason_reason_Internalname, "SelectedValue_set", Ddo_br_encounter_refusereason_reason_Selectedvalue_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE") == 0 )
            {
               AV29TFBR_Encounter_RefuseReason_NoApproveDate = context.localUtil.CToT( AV12GridStateFilterValue.gxTpr_Value, 0);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29TFBR_Encounter_RefuseReason_NoApproveDate", context.localUtil.TToC( AV29TFBR_Encounter_RefuseReason_NoApproveDate, 10, 8, 0, 0, "/", ":", " "));
               AV30TFBR_Encounter_RefuseReason_NoApproveDate_To = context.localUtil.CToT( AV12GridStateFilterValue.gxTpr_Valueto, 0);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30TFBR_Encounter_RefuseReason_NoApproveDate_To", context.localUtil.TToC( AV30TFBR_Encounter_RefuseReason_NoApproveDate_To, 10, 8, 0, 0, "/", ":", " "));
               if ( ! (DateTime.MinValue==AV29TFBR_Encounter_RefuseReason_NoApproveDate) )
               {
                  AV31DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDate = DateTimeUtil.ResetTime(AV29TFBR_Encounter_RefuseReason_NoApproveDate);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDate", context.localUtil.Format(AV31DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDate, "9999/99/99"));
                  Ddo_br_encounter_refusereason_noapprovedate_Filteredtext_set = context.localUtil.DToC( AV31DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDate, 0, "/");
                  ucDdo_br_encounter_refusereason_noapprovedate.SendProperty(context, "", false, Ddo_br_encounter_refusereason_noapprovedate_Internalname, "FilteredText_set", Ddo_br_encounter_refusereason_noapprovedate_Filteredtext_set);
               }
               if ( ! (DateTime.MinValue==AV30TFBR_Encounter_RefuseReason_NoApproveDate_To) )
               {
                  AV32DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDateTo = DateTimeUtil.ResetTime(AV30TFBR_Encounter_RefuseReason_NoApproveDate_To);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV32DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDateTo", context.localUtil.Format(AV32DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDateTo, "9999/99/99"));
                  Ddo_br_encounter_refusereason_noapprovedate_Filteredtextto_set = context.localUtil.DToC( AV32DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDateTo, 0, "/");
                  ucDdo_br_encounter_refusereason_noapprovedate.SendProperty(context, "", false, Ddo_br_encounter_refusereason_noapprovedate_Internalname, "FilteredTextTo_set", Ddo_br_encounter_refusereason_noapprovedate_Filteredtextto_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_ENCOUNTER_REFUSEREASON_STATUS_SEL") == 0 )
            {
               AV35TFBR_Encounter_RefuseReason_Status_SelsJson = AV12GridStateFilterValue.gxTpr_Value;
               AV36TFBR_Encounter_RefuseReason_Status_Sels.FromJSonString(AV35TFBR_Encounter_RefuseReason_Status_SelsJson, null);
               if ( ! ( AV36TFBR_Encounter_RefuseReason_Status_Sels.Count == 0 ) )
               {
                  Ddo_br_encounter_refusereason_status_Selectedvalue_set = AV35TFBR_Encounter_RefuseReason_Status_SelsJson;
                  ucDdo_br_encounter_refusereason_status.SendProperty(context, "", false, Ddo_br_encounter_refusereason_status_Internalname, "SelectedValue_set", Ddo_br_encounter_refusereason_status_Selectedvalue_set);
               }
            }
            AV64GXV1 = (int)(AV64GXV1+1);
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
         AV11GridState.FromXml(AV15Session.Get(AV63Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         AV11GridState.gxTpr_Orderedby = AV13OrderedBy;
         AV11GridState.gxTpr_Ordereddsc = AV14OrderedDsc;
         AV11GridState.gxTpr_Filtervalues.Clear();
         if ( ! ( (0==AV17TFBR_Encounter_RefuseReasonID) && (0==AV18TFBR_Encounter_RefuseReasonID_To) ) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_ENCOUNTER_REFUSEREASONID";
            AV12GridStateFilterValue.gxTpr_Value = StringUtil.Str( (decimal)(AV17TFBR_Encounter_RefuseReasonID), 18, 0);
            AV12GridStateFilterValue.gxTpr_Valueto = StringUtil.Str( (decimal)(AV18TFBR_Encounter_RefuseReasonID_To), 18, 0);
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! ( (0==AV21TFBR_EncounterID) && (0==AV22TFBR_EncounterID_To) ) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_ENCOUNTERID";
            AV12GridStateFilterValue.gxTpr_Value = StringUtil.Str( (decimal)(AV21TFBR_EncounterID), 18, 0);
            AV12GridStateFilterValue.gxTpr_Valueto = StringUtil.Str( (decimal)(AV22TFBR_EncounterID_To), 18, 0);
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV25TFBR_Encounter_RefuseReason_Reason)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_ENCOUNTER_REFUSEREASON_REASON";
            AV12GridStateFilterValue.gxTpr_Value = AV25TFBR_Encounter_RefuseReason_Reason;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV26TFBR_Encounter_RefuseReason_Reason_Sel)) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_ENCOUNTER_REFUSEREASON_REASON_SEL";
            AV12GridStateFilterValue.gxTpr_Value = AV26TFBR_Encounter_RefuseReason_Reason_Sel;
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! ( (DateTime.MinValue==AV29TFBR_Encounter_RefuseReason_NoApproveDate) && (DateTime.MinValue==AV30TFBR_Encounter_RefuseReason_NoApproveDate_To) ) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE";
            AV12GridStateFilterValue.gxTpr_Value = context.localUtil.TToC( AV29TFBR_Encounter_RefuseReason_NoApproveDate, 10, 8, 0, 0, "/", ":", " ");
            AV12GridStateFilterValue.gxTpr_Valueto = context.localUtil.TToC( AV30TFBR_Encounter_RefuseReason_NoApproveDate_To, 10, 8, 0, 0, "/", ":", " ");
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! ( AV36TFBR_Encounter_RefuseReason_Status_Sels.Count == 0 ) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_ENCOUNTER_REFUSEREASON_STATUS_SEL";
            AV12GridStateFilterValue.gxTpr_Value = AV36TFBR_Encounter_RefuseReason_Status_Sels.ToJSonString(false);
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         AV11GridState.gxTpr_Pagesize = StringUtil.Str( (decimal)(subGrid_Rows), 10, 0);
         AV11GridState.gxTpr_Currentpage = (short)(subGrid_Currentpage( ));
         new GeneXus.Programs.wwpbaseobjects.savegridstate(context ).execute(  AV63Pgmname+"GridState",  AV11GridState.ToXml(false, true, "WWPGridState", "DataAnalysisPlatform")) ;
      }

      protected void S112( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV9TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV9TrnContext.gxTpr_Callerobject = AV63Pgmname;
         AV9TrnContext.gxTpr_Callerondelete = true;
         AV9TrnContext.gxTpr_Callerurl = AV8HTTPRequest.ScriptName+"?"+AV8HTTPRequest.QueryString;
         AV9TrnContext.gxTpr_Transactionname = "BR_Encounter_RefuseReason";
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
         PA7C2( ) ;
         WS7C2( ) ;
         WE7C2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202022815162297", true);
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
         context.AddJavascriptSource("br_encounter_refusereasonww.js", "?202022815162297", false);
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
         context.AddJavascriptSource("DVelop/WorkWithPlusUtilities/WorkWithPlusUtilitiesRender.js", "", false);
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_312( )
      {
         edtavDisplay_Internalname = "vDISPLAY_"+sGXsfl_31_idx;
         edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_31_idx;
         edtavDelete_Internalname = "vDELETE_"+sGXsfl_31_idx;
         edtBR_Encounter_RefuseReasonID_Internalname = "BR_ENCOUNTER_REFUSEREASONID_"+sGXsfl_31_idx;
         edtBR_EncounterID_Internalname = "BR_ENCOUNTERID_"+sGXsfl_31_idx;
         edtBR_Encounter_RefuseReason_Reason_Internalname = "BR_ENCOUNTER_REFUSEREASON_REASON_"+sGXsfl_31_idx;
         edtBR_Encounter_RefuseReason_NoApproveDate_Internalname = "BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_"+sGXsfl_31_idx;
         cmbBR_Encounter_RefuseReason_Status_Internalname = "BR_ENCOUNTER_REFUSEREASON_STATUS_"+sGXsfl_31_idx;
      }

      protected void SubsflControlProps_fel_312( )
      {
         edtavDisplay_Internalname = "vDISPLAY_"+sGXsfl_31_fel_idx;
         edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_31_fel_idx;
         edtavDelete_Internalname = "vDELETE_"+sGXsfl_31_fel_idx;
         edtBR_Encounter_RefuseReasonID_Internalname = "BR_ENCOUNTER_REFUSEREASONID_"+sGXsfl_31_fel_idx;
         edtBR_EncounterID_Internalname = "BR_ENCOUNTERID_"+sGXsfl_31_fel_idx;
         edtBR_Encounter_RefuseReason_Reason_Internalname = "BR_ENCOUNTER_REFUSEREASON_REASON_"+sGXsfl_31_fel_idx;
         edtBR_Encounter_RefuseReason_NoApproveDate_Internalname = "BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_"+sGXsfl_31_fel_idx;
         cmbBR_Encounter_RefuseReason_Status_Internalname = "BR_ENCOUNTER_REFUSEREASON_STATUS_"+sGXsfl_31_fel_idx;
      }

      protected void sendrow_312( )
      {
         SubsflControlProps_312( ) ;
         WB7C0( ) ;
         if ( ( subGrid_Rows * 1 == 0 ) || ( nGXsfl_31_idx <= subGrid_Recordsperpage( ) * 1 ) )
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
               if ( ((int)(((nGXsfl_31_idx-1)/ (decimal)(1)) % (2))) == 0 )
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
               context.WriteHtmlText( " gxrow=\""+sGXsfl_31_idx+"\">") ;
            }
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "ActionBaseColorAttribute";
            StyleString = "";
            AV43Display_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV43Display))&&String.IsNullOrEmpty(StringUtil.RTrim( AV60Display_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV43Display)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV43Display)) ? AV60Display_GXI : context.PathToRelativeUrl( AV43Display));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavDisplay_Internalname,(String)sImgUrl,(String)edtavDisplay_Link,(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)edtavDisplay_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV43Display_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((edtavUpdate_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "ActionBaseColorAttribute";
            StyleString = "";
            AV44Update_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV44Update))&&String.IsNullOrEmpty(StringUtil.RTrim( AV61Update_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV44Update)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV44Update)) ? AV61Update_GXI : context.PathToRelativeUrl( AV44Update));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavUpdate_Internalname,(String)sImgUrl,(String)edtavUpdate_Link,(String)"",(String)"",context.GetTheme( ),(int)edtavUpdate_Visible,(short)1,(String)"",(String)edtavUpdate_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV44Update_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((edtavDelete_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "DeleteAttribute ActionBaseColorAttribute";
            StyleString = "";
            AV46Delete_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV46Delete))&&String.IsNullOrEmpty(StringUtil.RTrim( AV62Delete_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV46Delete)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV46Delete)) ? AV62Delete_GXI : context.PathToRelativeUrl( AV46Delete));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavDelete_Internalname,(String)sImgUrl,(String)edtavDelete_Link,(String)"",(String)"",context.GetTheme( ),(int)edtavDelete_Visible,(short)1,(String)"",(String)edtavDelete_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV46Delete_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Encounter_RefuseReasonID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A348BR_Encounter_RefuseReasonID), 18, 0, ".", "")),context.localUtil.Format( (decimal)(A348BR_Encounter_RefuseReasonID), "ZZZZZZZZZZZZZZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Encounter_RefuseReasonID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)31,(short)1,(short)-1,(short)0,(bool)true,(String)"ID",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_EncounterID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A19BR_EncounterID), 18, 0, ".", "")),context.localUtil.Format( (decimal)(A19BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_EncounterID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)31,(short)1,(short)-1,(short)0,(bool)true,(String)"ID",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Encounter_RefuseReason_Reason_Internalname,(String)A349BR_Encounter_RefuseReason_Reason,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)edtBR_Encounter_RefuseReason_Reason_Link,(String)"",(String)"",(String)"",(String)edtBR_Encounter_RefuseReason_Reason_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)300,(short)0,(short)0,(short)31,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Encounter_RefuseReason_NoApproveDate_Internalname,context.localUtil.TToC( A350BR_Encounter_RefuseReason_NoApproveDate, 10, 8, 0, 0, "/", ":", " "),context.localUtil.Format( A350BR_Encounter_RefuseReason_NoApproveDate, "9999/99/99 99:99:99"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Encounter_RefuseReason_NoApproveDate_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)19,(short)0,(short)0,(short)31,(short)1,(short)-1,(short)0,(bool)true,(String)"UpdDate",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            if ( ( cmbBR_Encounter_RefuseReason_Status.ItemCount == 0 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "BR_ENCOUNTER_REFUSEREASON_STATUS_" + sGXsfl_31_idx;
               cmbBR_Encounter_RefuseReason_Status.Name = GXCCtl;
               cmbBR_Encounter_RefuseReason_Status.WebTags = "";
               cmbBR_Encounter_RefuseReason_Status.addItem("1", "未处理", 0);
               cmbBR_Encounter_RefuseReason_Status.addItem("2", "已处理", 0);
               if ( cmbBR_Encounter_RefuseReason_Status.ItemCount > 0 )
               {
                  A351BR_Encounter_RefuseReason_Status = (short)(NumberUtil.Val( cmbBR_Encounter_RefuseReason_Status.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A351BR_Encounter_RefuseReason_Status), 4, 0))), "."));
                  n351BR_Encounter_RefuseReason_Status = false;
               }
            }
            /* ComboBox */
            GridRow.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbBR_Encounter_RefuseReason_Status,(String)cmbBR_Encounter_RefuseReason_Status_Internalname,StringUtil.Trim( StringUtil.Str( (decimal)(A351BR_Encounter_RefuseReason_Status), 4, 0)),(short)1,(String)cmbBR_Encounter_RefuseReason_Status_Jsonclick,(short)0,(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"int",(String)"",(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)"",(String)"Attribute",(String)"WWColumn hidden-xs",(String)"",(String)"",(String)"",(bool)true});
            cmbBR_Encounter_RefuseReason_Status.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A351BR_Encounter_RefuseReason_Status), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Encounter_RefuseReason_Status_Internalname, "Values", (String)(cmbBR_Encounter_RefuseReason_Status.ToJavascriptSource()), !bGXsfl_31_Refreshing);
            send_integrity_lvl_hashes7C2( ) ;
            GridContainer.AddRow(GridRow);
            nGXsfl_31_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_31_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_31_idx+1));
            sGXsfl_31_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_31_idx), 4, 0)), 4, "0");
            SubsflControlProps_312( ) ;
         }
         /* End function sendrow_312 */
      }

      protected void init_web_controls( )
      {
         GXCCtl = "BR_ENCOUNTER_REFUSEREASON_STATUS_" + sGXsfl_31_idx;
         cmbBR_Encounter_RefuseReason_Status.Name = GXCCtl;
         cmbBR_Encounter_RefuseReason_Status.WebTags = "";
         cmbBR_Encounter_RefuseReason_Status.addItem("1", "未处理", 0);
         cmbBR_Encounter_RefuseReason_Status.addItem("2", "已处理", 0);
         if ( cmbBR_Encounter_RefuseReason_Status.ItemCount > 0 )
         {
            A351BR_Encounter_RefuseReason_Status = (short)(NumberUtil.Val( cmbBR_Encounter_RefuseReason_Status.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A351BR_Encounter_RefuseReason_Status), 4, 0))), "."));
            n351BR_Encounter_RefuseReason_Status = false;
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
         edtBR_Encounter_RefuseReasonID_Internalname = "BR_ENCOUNTER_REFUSEREASONID";
         edtBR_EncounterID_Internalname = "BR_ENCOUNTERID";
         edtBR_Encounter_RefuseReason_Reason_Internalname = "BR_ENCOUNTER_REFUSEREASON_REASON";
         edtBR_Encounter_RefuseReason_NoApproveDate_Internalname = "BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE";
         cmbBR_Encounter_RefuseReason_Status_Internalname = "BR_ENCOUNTER_REFUSEREASON_STATUS";
         Gridpaginationbar_Internalname = "GRIDPAGINATIONBAR";
         divHtml_gridpaginationbar_Internalname = "HTML_GRIDPAGINATIONBAR";
         divGridtablewithpaginationbar_Internalname = "GRIDTABLEWITHPAGINATIONBAR";
         divTablemain_Internalname = "TABLEMAIN";
         Ddo_br_encounter_refusereasonid_Internalname = "DDO_BR_ENCOUNTER_REFUSEREASONID";
         edtavDdo_br_encounter_refusereasonidtitlecontrolidtoreplace_Internalname = "vDDO_BR_ENCOUNTER_REFUSEREASONIDTITLECONTROLIDTOREPLACE";
         Ddo_br_encounterid_Internalname = "DDO_BR_ENCOUNTERID";
         edtavDdo_br_encounteridtitlecontrolidtoreplace_Internalname = "vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE";
         Ddo_br_encounter_refusereason_reason_Internalname = "DDO_BR_ENCOUNTER_REFUSEREASON_REASON";
         edtavDdo_br_encounter_refusereason_reasontitlecontrolidtoreplace_Internalname = "vDDO_BR_ENCOUNTER_REFUSEREASON_REASONTITLECONTROLIDTOREPLACE";
         Ddo_br_encounter_refusereason_noapprovedate_Internalname = "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE";
         edtavDdo_br_encounter_refusereason_noapprovedatetitlecontrolidtoreplace_Internalname = "vDDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATETITLECONTROLIDTOREPLACE";
         Ddo_br_encounter_refusereason_status_Internalname = "DDO_BR_ENCOUNTER_REFUSEREASON_STATUS";
         edtavDdo_br_encounter_refusereason_statustitlecontrolidtoreplace_Internalname = "vDDO_BR_ENCOUNTER_REFUSEREASON_STATUSTITLECONTROLIDTOREPLACE";
         Workwithplusutilities1_Internalname = "WORKWITHPLUSUTILITIES1";
         edtavOrderedby_Internalname = "vORDEREDBY";
         edtavOrdereddsc_Internalname = "vORDEREDDSC";
         edtavTfbr_encounter_refusereasonid_Internalname = "vTFBR_ENCOUNTER_REFUSEREASONID";
         edtavTfbr_encounter_refusereasonid_to_Internalname = "vTFBR_ENCOUNTER_REFUSEREASONID_TO";
         edtavTfbr_encounterid_Internalname = "vTFBR_ENCOUNTERID";
         edtavTfbr_encounterid_to_Internalname = "vTFBR_ENCOUNTERID_TO";
         edtavTfbr_encounter_refusereason_reason_Internalname = "vTFBR_ENCOUNTER_REFUSEREASON_REASON";
         edtavTfbr_encounter_refusereason_reason_sel_Internalname = "vTFBR_ENCOUNTER_REFUSEREASON_REASON_SEL";
         edtavTfbr_encounter_refusereason_noapprovedate_Internalname = "vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE";
         edtavTfbr_encounter_refusereason_noapprovedate_to_Internalname = "vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_TO";
         edtavDdo_br_encounter_refusereason_noapprovedateauxdate_Internalname = "vDDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEAUXDATE";
         edtavDdo_br_encounter_refusereason_noapprovedateauxdateto_Internalname = "vDDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEAUXDATETO";
         divDdo_br_encounter_refusereason_noapprovedateauxdates_Internalname = "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEAUXDATES";
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
         cmbBR_Encounter_RefuseReason_Status_Jsonclick = "";
         edtBR_Encounter_RefuseReason_NoApproveDate_Jsonclick = "";
         edtBR_Encounter_RefuseReason_Reason_Jsonclick = "";
         edtBR_EncounterID_Jsonclick = "";
         edtBR_Encounter_RefuseReasonID_Jsonclick = "";
         edtavDdo_br_encounter_refusereason_noapprovedateauxdateto_Jsonclick = "";
         edtavDdo_br_encounter_refusereason_noapprovedateauxdate_Jsonclick = "";
         edtavTfbr_encounter_refusereason_noapprovedate_to_Jsonclick = "";
         edtavTfbr_encounter_refusereason_noapprovedate_to_Visible = 1;
         edtavTfbr_encounter_refusereason_noapprovedate_Jsonclick = "";
         edtavTfbr_encounter_refusereason_noapprovedate_Visible = 1;
         edtavTfbr_encounter_refusereason_reason_sel_Visible = 1;
         edtavTfbr_encounter_refusereason_reason_Visible = 1;
         edtavTfbr_encounterid_to_Jsonclick = "";
         edtavTfbr_encounterid_to_Visible = 1;
         edtavTfbr_encounterid_Jsonclick = "";
         edtavTfbr_encounterid_Visible = 1;
         edtavTfbr_encounter_refusereasonid_to_Jsonclick = "";
         edtavTfbr_encounter_refusereasonid_to_Visible = 1;
         edtavTfbr_encounter_refusereasonid_Jsonclick = "";
         edtavTfbr_encounter_refusereasonid_Visible = 1;
         edtavOrdereddsc_Jsonclick = "";
         edtavOrdereddsc_Visible = 1;
         edtavOrderedby_Jsonclick = "";
         edtavOrderedby_Visible = 1;
         edtavDdo_br_encounter_refusereason_statustitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_encounter_refusereason_noapprovedatetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_encounter_refusereason_reasontitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_encounteridtitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_encounter_refusereasonidtitlecontrolidtoreplace_Visible = 1;
         subGrid_Allowcollapsing = 0;
         subGrid_Allowselection = 0;
         edtBR_Encounter_RefuseReason_Reason_Link = "";
         edtavDelete_Tooltiptext = "删除";
         edtavDelete_Link = "";
         edtavUpdate_Tooltiptext = "修改";
         edtavUpdate_Link = "";
         edtavDisplay_Tooltiptext = "显示";
         edtavDisplay_Link = "";
         subGrid_Sortable = 0;
         subGrid_Header = "";
         cmbBR_Encounter_RefuseReason_Status_Titleformat = 0;
         cmbBR_Encounter_RefuseReason_Status.Title.Text = "初审不通过状态";
         edtBR_Encounter_RefuseReason_NoApproveDate_Titleformat = 0;
         edtBR_Encounter_RefuseReason_NoApproveDate_Title = "初审不通过时间";
         edtBR_Encounter_RefuseReason_Reason_Titleformat = 0;
         edtBR_Encounter_RefuseReason_Reason_Title = "初审不通过原因";
         edtBR_EncounterID_Titleformat = 0;
         edtBR_EncounterID_Title = "就诊信息主键";
         edtBR_Encounter_RefuseReasonID_Titleformat = 0;
         edtBR_Encounter_RefuseReasonID_Title = "Reason ID";
         edtavDelete_Visible = -1;
         edtavUpdate_Visible = -1;
         subGrid_Class = "GridWithPaginationBar GridWithBorderColor WorkWith";
         subGrid_Backcolorstyle = 0;
         bttBtninsert_Visible = 1;
         Ddo_br_encounter_refusereason_status_Searchbuttontext = "WWP_FilterSelected";
         Ddo_br_encounter_refusereason_status_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_encounter_refusereason_status_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_encounter_refusereason_status_Sortasc = "WWP_TSSortASC";
         Ddo_br_encounter_refusereason_status_Datalistfixedvalues = "1:未处理,2:已处理";
         Ddo_br_encounter_refusereason_status_Allowmultipleselection = Convert.ToBoolean( -1);
         Ddo_br_encounter_refusereason_status_Datalisttype = "FixedValues";
         Ddo_br_encounter_refusereason_status_Includedatalist = Convert.ToBoolean( -1);
         Ddo_br_encounter_refusereason_status_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_encounter_refusereason_status_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_encounter_refusereason_status_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_encounter_refusereason_status_Titlecontrolidtoreplace = "";
         Ddo_br_encounter_refusereason_status_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_encounter_refusereason_status_Cls = "ColumnSettings";
         Ddo_br_encounter_refusereason_status_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_encounter_refusereason_status_Caption = "";
         Ddo_br_encounter_refusereason_noapprovedate_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_encounter_refusereason_noapprovedate_Rangefilterto = "WWP_TSTo";
         Ddo_br_encounter_refusereason_noapprovedate_Rangefilterfrom = "WWP_TSFrom";
         Ddo_br_encounter_refusereason_noapprovedate_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_encounter_refusereason_noapprovedate_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_encounter_refusereason_noapprovedate_Sortasc = "WWP_TSSortASC";
         Ddo_br_encounter_refusereason_noapprovedate_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_encounter_refusereason_noapprovedate_Filterisrange = Convert.ToBoolean( -1);
         Ddo_br_encounter_refusereason_noapprovedate_Filtertype = "Date";
         Ddo_br_encounter_refusereason_noapprovedate_Includefilter = Convert.ToBoolean( -1);
         Ddo_br_encounter_refusereason_noapprovedate_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_encounter_refusereason_noapprovedate_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_encounter_refusereason_noapprovedate_Titlecontrolidtoreplace = "";
         Ddo_br_encounter_refusereason_noapprovedate_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_encounter_refusereason_noapprovedate_Cls = "ColumnSettings";
         Ddo_br_encounter_refusereason_noapprovedate_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_encounter_refusereason_noapprovedate_Caption = "";
         Ddo_br_encounter_refusereason_reason_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_encounter_refusereason_reason_Noresultsfound = "WWP_TSNoResults";
         Ddo_br_encounter_refusereason_reason_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_encounter_refusereason_reason_Loadingdata = "WWP_TSLoading";
         Ddo_br_encounter_refusereason_reason_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_encounter_refusereason_reason_Sortasc = "WWP_TSSortASC";
         Ddo_br_encounter_refusereason_reason_Datalistupdateminimumcharacters = 0;
         Ddo_br_encounter_refusereason_reason_Datalistproc = "BR_Encounter_RefuseReasonWWGetFilterData";
         Ddo_br_encounter_refusereason_reason_Datalisttype = "Dynamic";
         Ddo_br_encounter_refusereason_reason_Includedatalist = Convert.ToBoolean( -1);
         Ddo_br_encounter_refusereason_reason_Filterisrange = Convert.ToBoolean( 0);
         Ddo_br_encounter_refusereason_reason_Filtertype = "Character";
         Ddo_br_encounter_refusereason_reason_Includefilter = Convert.ToBoolean( -1);
         Ddo_br_encounter_refusereason_reason_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_encounter_refusereason_reason_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_encounter_refusereason_reason_Titlecontrolidtoreplace = "";
         Ddo_br_encounter_refusereason_reason_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_encounter_refusereason_reason_Cls = "ColumnSettings";
         Ddo_br_encounter_refusereason_reason_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_encounter_refusereason_reason_Caption = "";
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
         Ddo_br_encounter_refusereasonid_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_encounter_refusereasonid_Rangefilterto = "WWP_TSTo";
         Ddo_br_encounter_refusereasonid_Rangefilterfrom = "WWP_TSFrom";
         Ddo_br_encounter_refusereasonid_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_encounter_refusereasonid_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_encounter_refusereasonid_Sortasc = "WWP_TSSortASC";
         Ddo_br_encounter_refusereasonid_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_encounter_refusereasonid_Filterisrange = Convert.ToBoolean( -1);
         Ddo_br_encounter_refusereasonid_Filtertype = "Numeric";
         Ddo_br_encounter_refusereasonid_Includefilter = Convert.ToBoolean( -1);
         Ddo_br_encounter_refusereasonid_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_encounter_refusereasonid_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_encounter_refusereasonid_Titlecontrolidtoreplace = "";
         Ddo_br_encounter_refusereasonid_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_encounter_refusereasonid_Cls = "ColumnSettings";
         Ddo_br_encounter_refusereasonid_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_encounter_refusereasonid_Caption = "";
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
         Form.Caption = " 就诊信息驳回原因";
         subGrid_Rows = 0;
         context.GX_msglist.DisplayMode = 1;
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV45IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV47IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'AV19ddo_BR_Encounter_RefuseReasonIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_REASONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Encounter_RefuseReason_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV17TFBR_Encounter_RefuseReasonID',fld:'vTFBR_ENCOUNTER_REFUSEREASONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Encounter_RefuseReasonID_To',fld:'vTFBR_ENCOUNTER_REFUSEREASONID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Encounter_RefuseReason_Reason',fld:'vTFBR_ENCOUNTER_REFUSEREASON_REASON',pic:''},{av:'AV26TFBR_Encounter_RefuseReason_Reason_Sel',fld:'vTFBR_ENCOUNTER_REFUSEREASON_REASON_SEL',pic:''},{av:'AV29TFBR_Encounter_RefuseReason_NoApproveDate',fld:'vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',pic:'9999/99/99 99:99:99'},{av:'AV30TFBR_Encounter_RefuseReason_NoApproveDate_To',fld:'vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_TO',pic:'9999/99/99 99:99:99'},{av:'AV36TFBR_Encounter_RefuseReason_Status_Sels',fld:'vTFBR_ENCOUNTER_REFUSEREASON_STATUS_SELS',pic:''},{av:'AV63Pgmname',fld:'vPGMNAME',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''}]");
         setEventMetadata("REFRESH",",oparms:[{av:'AV16BR_Encounter_RefuseReasonIDTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASONIDTITLEFILTERDATA',pic:''},{av:'AV20BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Encounter_RefuseReason_ReasonTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASON_REASONTITLEFILTERDATA',pic:''},{av:'AV28BR_Encounter_RefuseReason_NoApproveDateTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATETITLEFILTERDATA',pic:''},{av:'AV34BR_Encounter_RefuseReason_StatusTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASON_STATUSTITLEFILTERDATA',pic:''},{av:'edtBR_Encounter_RefuseReasonID_Titleformat',ctrl:'BR_ENCOUNTER_REFUSEREASONID',prop:'Titleformat'},{av:'edtBR_Encounter_RefuseReasonID_Title',ctrl:'BR_ENCOUNTER_REFUSEREASONID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Encounter_RefuseReason_Reason_Titleformat',ctrl:'BR_ENCOUNTER_REFUSEREASON_REASON',prop:'Titleformat'},{av:'edtBR_Encounter_RefuseReason_Reason_Title',ctrl:'BR_ENCOUNTER_REFUSEREASON_REASON',prop:'Title'},{av:'edtBR_Encounter_RefuseReason_NoApproveDate_Titleformat',ctrl:'BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'Titleformat'},{av:'edtBR_Encounter_RefuseReason_NoApproveDate_Title',ctrl:'BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'Title'},{av:'cmbBR_Encounter_RefuseReason_Status'},{av:'AV40GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV41GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV42GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV45IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV47IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE","{handler:'E117C2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Encounter_RefuseReasonID',fld:'vTFBR_ENCOUNTER_REFUSEREASONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Encounter_RefuseReasonID_To',fld:'vTFBR_ENCOUNTER_REFUSEREASONID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Encounter_RefuseReason_Reason',fld:'vTFBR_ENCOUNTER_REFUSEREASON_REASON',pic:''},{av:'AV26TFBR_Encounter_RefuseReason_Reason_Sel',fld:'vTFBR_ENCOUNTER_REFUSEREASON_REASON_SEL',pic:''},{av:'AV29TFBR_Encounter_RefuseReason_NoApproveDate',fld:'vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',pic:'9999/99/99 99:99:99'},{av:'AV30TFBR_Encounter_RefuseReason_NoApproveDate_To',fld:'vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_TO',pic:'9999/99/99 99:99:99'},{av:'AV19ddo_BR_Encounter_RefuseReasonIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_REASONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Encounter_RefuseReason_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV36TFBR_Encounter_RefuseReason_Status_Sels',fld:'vTFBR_ENCOUNTER_REFUSEREASON_STATUS_SELS',pic:''},{av:'AV63Pgmname',fld:'vPGMNAME',pic:''},{av:'AV45IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV47IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'Gridpaginationbar_Selectedpage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE",",oparms:[]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE","{handler:'E127C2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Encounter_RefuseReasonID',fld:'vTFBR_ENCOUNTER_REFUSEREASONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Encounter_RefuseReasonID_To',fld:'vTFBR_ENCOUNTER_REFUSEREASONID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Encounter_RefuseReason_Reason',fld:'vTFBR_ENCOUNTER_REFUSEREASON_REASON',pic:''},{av:'AV26TFBR_Encounter_RefuseReason_Reason_Sel',fld:'vTFBR_ENCOUNTER_REFUSEREASON_REASON_SEL',pic:''},{av:'AV29TFBR_Encounter_RefuseReason_NoApproveDate',fld:'vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',pic:'9999/99/99 99:99:99'},{av:'AV30TFBR_Encounter_RefuseReason_NoApproveDate_To',fld:'vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_TO',pic:'9999/99/99 99:99:99'},{av:'AV19ddo_BR_Encounter_RefuseReasonIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_REASONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Encounter_RefuseReason_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV36TFBR_Encounter_RefuseReason_Status_Sels',fld:'vTFBR_ENCOUNTER_REFUSEREASON_STATUS_SELS',pic:''},{av:'AV63Pgmname',fld:'vPGMNAME',pic:''},{av:'AV45IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV47IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'Gridpaginationbar_Rowsperpageselectedvalue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE",",oparms:[{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]}");
         setEventMetadata("DDO_BR_ENCOUNTER_REFUSEREASONID.ONOPTIONCLICKED","{handler:'E137C2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Encounter_RefuseReasonID',fld:'vTFBR_ENCOUNTER_REFUSEREASONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Encounter_RefuseReasonID_To',fld:'vTFBR_ENCOUNTER_REFUSEREASONID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Encounter_RefuseReason_Reason',fld:'vTFBR_ENCOUNTER_REFUSEREASON_REASON',pic:''},{av:'AV26TFBR_Encounter_RefuseReason_Reason_Sel',fld:'vTFBR_ENCOUNTER_REFUSEREASON_REASON_SEL',pic:''},{av:'AV29TFBR_Encounter_RefuseReason_NoApproveDate',fld:'vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',pic:'9999/99/99 99:99:99'},{av:'AV30TFBR_Encounter_RefuseReason_NoApproveDate_To',fld:'vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_TO',pic:'9999/99/99 99:99:99'},{av:'AV19ddo_BR_Encounter_RefuseReasonIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_REASONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Encounter_RefuseReason_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV36TFBR_Encounter_RefuseReason_Status_Sels',fld:'vTFBR_ENCOUNTER_REFUSEREASON_STATUS_SELS',pic:''},{av:'AV63Pgmname',fld:'vPGMNAME',pic:''},{av:'AV45IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV47IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'Ddo_br_encounter_refusereasonid_Activeeventkey',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASONID',prop:'ActiveEventKey'},{av:'Ddo_br_encounter_refusereasonid_Filteredtext_get',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASONID',prop:'FilteredText_get'},{av:'Ddo_br_encounter_refusereasonid_Filteredtextto_get',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASONID',prop:'FilteredTextTo_get'}]");
         setEventMetadata("DDO_BR_ENCOUNTER_REFUSEREASONID.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_encounter_refusereasonid_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASONID',prop:'SortedStatus'},{av:'AV17TFBR_Encounter_RefuseReasonID',fld:'vTFBR_ENCOUNTER_REFUSEREASONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Encounter_RefuseReasonID_To',fld:'vTFBR_ENCOUNTER_REFUSEREASONID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'Ddo_br_encounterid_Sortedstatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'Ddo_br_encounter_refusereason_reason_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_REASON',prop:'SortedStatus'},{av:'Ddo_br_encounter_refusereason_noapprovedate_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'SortedStatus'},{av:'Ddo_br_encounter_refusereason_status_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_STATUS',prop:'SortedStatus'},{av:'AV16BR_Encounter_RefuseReasonIDTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASONIDTITLEFILTERDATA',pic:''},{av:'AV20BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Encounter_RefuseReason_ReasonTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASON_REASONTITLEFILTERDATA',pic:''},{av:'AV28BR_Encounter_RefuseReason_NoApproveDateTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATETITLEFILTERDATA',pic:''},{av:'AV34BR_Encounter_RefuseReason_StatusTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASON_STATUSTITLEFILTERDATA',pic:''},{av:'edtBR_Encounter_RefuseReasonID_Titleformat',ctrl:'BR_ENCOUNTER_REFUSEREASONID',prop:'Titleformat'},{av:'edtBR_Encounter_RefuseReasonID_Title',ctrl:'BR_ENCOUNTER_REFUSEREASONID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Encounter_RefuseReason_Reason_Titleformat',ctrl:'BR_ENCOUNTER_REFUSEREASON_REASON',prop:'Titleformat'},{av:'edtBR_Encounter_RefuseReason_Reason_Title',ctrl:'BR_ENCOUNTER_REFUSEREASON_REASON',prop:'Title'},{av:'edtBR_Encounter_RefuseReason_NoApproveDate_Titleformat',ctrl:'BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'Titleformat'},{av:'edtBR_Encounter_RefuseReason_NoApproveDate_Title',ctrl:'BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'Title'},{av:'cmbBR_Encounter_RefuseReason_Status'},{av:'AV40GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV41GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV42GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV45IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV47IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_ENCOUNTERID.ONOPTIONCLICKED","{handler:'E147C2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Encounter_RefuseReasonID',fld:'vTFBR_ENCOUNTER_REFUSEREASONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Encounter_RefuseReasonID_To',fld:'vTFBR_ENCOUNTER_REFUSEREASONID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Encounter_RefuseReason_Reason',fld:'vTFBR_ENCOUNTER_REFUSEREASON_REASON',pic:''},{av:'AV26TFBR_Encounter_RefuseReason_Reason_Sel',fld:'vTFBR_ENCOUNTER_REFUSEREASON_REASON_SEL',pic:''},{av:'AV29TFBR_Encounter_RefuseReason_NoApproveDate',fld:'vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',pic:'9999/99/99 99:99:99'},{av:'AV30TFBR_Encounter_RefuseReason_NoApproveDate_To',fld:'vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_TO',pic:'9999/99/99 99:99:99'},{av:'AV19ddo_BR_Encounter_RefuseReasonIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_REASONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Encounter_RefuseReason_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV36TFBR_Encounter_RefuseReason_Status_Sels',fld:'vTFBR_ENCOUNTER_REFUSEREASON_STATUS_SELS',pic:''},{av:'AV63Pgmname',fld:'vPGMNAME',pic:''},{av:'AV45IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV47IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'Ddo_br_encounterid_Activeeventkey',ctrl:'DDO_BR_ENCOUNTERID',prop:'ActiveEventKey'},{av:'Ddo_br_encounterid_Filteredtext_get',ctrl:'DDO_BR_ENCOUNTERID',prop:'FilteredText_get'},{av:'Ddo_br_encounterid_Filteredtextto_get',ctrl:'DDO_BR_ENCOUNTERID',prop:'FilteredTextTo_get'}]");
         setEventMetadata("DDO_BR_ENCOUNTERID.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_encounterid_Sortedstatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'AV21TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'Ddo_br_encounter_refusereasonid_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASONID',prop:'SortedStatus'},{av:'Ddo_br_encounter_refusereason_reason_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_REASON',prop:'SortedStatus'},{av:'Ddo_br_encounter_refusereason_noapprovedate_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'SortedStatus'},{av:'Ddo_br_encounter_refusereason_status_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_STATUS',prop:'SortedStatus'},{av:'AV16BR_Encounter_RefuseReasonIDTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASONIDTITLEFILTERDATA',pic:''},{av:'AV20BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Encounter_RefuseReason_ReasonTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASON_REASONTITLEFILTERDATA',pic:''},{av:'AV28BR_Encounter_RefuseReason_NoApproveDateTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATETITLEFILTERDATA',pic:''},{av:'AV34BR_Encounter_RefuseReason_StatusTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASON_STATUSTITLEFILTERDATA',pic:''},{av:'edtBR_Encounter_RefuseReasonID_Titleformat',ctrl:'BR_ENCOUNTER_REFUSEREASONID',prop:'Titleformat'},{av:'edtBR_Encounter_RefuseReasonID_Title',ctrl:'BR_ENCOUNTER_REFUSEREASONID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Encounter_RefuseReason_Reason_Titleformat',ctrl:'BR_ENCOUNTER_REFUSEREASON_REASON',prop:'Titleformat'},{av:'edtBR_Encounter_RefuseReason_Reason_Title',ctrl:'BR_ENCOUNTER_REFUSEREASON_REASON',prop:'Title'},{av:'edtBR_Encounter_RefuseReason_NoApproveDate_Titleformat',ctrl:'BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'Titleformat'},{av:'edtBR_Encounter_RefuseReason_NoApproveDate_Title',ctrl:'BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'Title'},{av:'cmbBR_Encounter_RefuseReason_Status'},{av:'AV40GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV41GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV42GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV45IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV47IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_ENCOUNTER_REFUSEREASON_REASON.ONOPTIONCLICKED","{handler:'E157C2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Encounter_RefuseReasonID',fld:'vTFBR_ENCOUNTER_REFUSEREASONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Encounter_RefuseReasonID_To',fld:'vTFBR_ENCOUNTER_REFUSEREASONID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Encounter_RefuseReason_Reason',fld:'vTFBR_ENCOUNTER_REFUSEREASON_REASON',pic:''},{av:'AV26TFBR_Encounter_RefuseReason_Reason_Sel',fld:'vTFBR_ENCOUNTER_REFUSEREASON_REASON_SEL',pic:''},{av:'AV29TFBR_Encounter_RefuseReason_NoApproveDate',fld:'vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',pic:'9999/99/99 99:99:99'},{av:'AV30TFBR_Encounter_RefuseReason_NoApproveDate_To',fld:'vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_TO',pic:'9999/99/99 99:99:99'},{av:'AV19ddo_BR_Encounter_RefuseReasonIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_REASONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Encounter_RefuseReason_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV36TFBR_Encounter_RefuseReason_Status_Sels',fld:'vTFBR_ENCOUNTER_REFUSEREASON_STATUS_SELS',pic:''},{av:'AV63Pgmname',fld:'vPGMNAME',pic:''},{av:'AV45IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV47IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'Ddo_br_encounter_refusereason_reason_Activeeventkey',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_REASON',prop:'ActiveEventKey'},{av:'Ddo_br_encounter_refusereason_reason_Filteredtext_get',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_REASON',prop:'FilteredText_get'},{av:'Ddo_br_encounter_refusereason_reason_Selectedvalue_get',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_REASON',prop:'SelectedValue_get'}]");
         setEventMetadata("DDO_BR_ENCOUNTER_REFUSEREASON_REASON.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_encounter_refusereason_reason_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_REASON',prop:'SortedStatus'},{av:'AV25TFBR_Encounter_RefuseReason_Reason',fld:'vTFBR_ENCOUNTER_REFUSEREASON_REASON',pic:''},{av:'AV26TFBR_Encounter_RefuseReason_Reason_Sel',fld:'vTFBR_ENCOUNTER_REFUSEREASON_REASON_SEL',pic:''},{av:'Ddo_br_encounter_refusereasonid_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASONID',prop:'SortedStatus'},{av:'Ddo_br_encounterid_Sortedstatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'Ddo_br_encounter_refusereason_noapprovedate_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'SortedStatus'},{av:'Ddo_br_encounter_refusereason_status_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_STATUS',prop:'SortedStatus'},{av:'AV16BR_Encounter_RefuseReasonIDTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASONIDTITLEFILTERDATA',pic:''},{av:'AV20BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Encounter_RefuseReason_ReasonTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASON_REASONTITLEFILTERDATA',pic:''},{av:'AV28BR_Encounter_RefuseReason_NoApproveDateTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATETITLEFILTERDATA',pic:''},{av:'AV34BR_Encounter_RefuseReason_StatusTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASON_STATUSTITLEFILTERDATA',pic:''},{av:'edtBR_Encounter_RefuseReasonID_Titleformat',ctrl:'BR_ENCOUNTER_REFUSEREASONID',prop:'Titleformat'},{av:'edtBR_Encounter_RefuseReasonID_Title',ctrl:'BR_ENCOUNTER_REFUSEREASONID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Encounter_RefuseReason_Reason_Titleformat',ctrl:'BR_ENCOUNTER_REFUSEREASON_REASON',prop:'Titleformat'},{av:'edtBR_Encounter_RefuseReason_Reason_Title',ctrl:'BR_ENCOUNTER_REFUSEREASON_REASON',prop:'Title'},{av:'edtBR_Encounter_RefuseReason_NoApproveDate_Titleformat',ctrl:'BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'Titleformat'},{av:'edtBR_Encounter_RefuseReason_NoApproveDate_Title',ctrl:'BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'Title'},{av:'cmbBR_Encounter_RefuseReason_Status'},{av:'AV40GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV41GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV42GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV45IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV47IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE.ONOPTIONCLICKED","{handler:'E167C2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Encounter_RefuseReasonID',fld:'vTFBR_ENCOUNTER_REFUSEREASONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Encounter_RefuseReasonID_To',fld:'vTFBR_ENCOUNTER_REFUSEREASONID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Encounter_RefuseReason_Reason',fld:'vTFBR_ENCOUNTER_REFUSEREASON_REASON',pic:''},{av:'AV26TFBR_Encounter_RefuseReason_Reason_Sel',fld:'vTFBR_ENCOUNTER_REFUSEREASON_REASON_SEL',pic:''},{av:'AV29TFBR_Encounter_RefuseReason_NoApproveDate',fld:'vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',pic:'9999/99/99 99:99:99'},{av:'AV30TFBR_Encounter_RefuseReason_NoApproveDate_To',fld:'vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_TO',pic:'9999/99/99 99:99:99'},{av:'AV19ddo_BR_Encounter_RefuseReasonIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_REASONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Encounter_RefuseReason_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV36TFBR_Encounter_RefuseReason_Status_Sels',fld:'vTFBR_ENCOUNTER_REFUSEREASON_STATUS_SELS',pic:''},{av:'AV63Pgmname',fld:'vPGMNAME',pic:''},{av:'AV45IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV47IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'Ddo_br_encounter_refusereason_noapprovedate_Activeeventkey',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'ActiveEventKey'},{av:'Ddo_br_encounter_refusereason_noapprovedate_Filteredtext_get',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'FilteredText_get'},{av:'Ddo_br_encounter_refusereason_noapprovedate_Filteredtextto_get',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'FilteredTextTo_get'}]");
         setEventMetadata("DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_encounter_refusereason_noapprovedate_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'SortedStatus'},{av:'AV29TFBR_Encounter_RefuseReason_NoApproveDate',fld:'vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',pic:'9999/99/99 99:99:99'},{av:'AV30TFBR_Encounter_RefuseReason_NoApproveDate_To',fld:'vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_TO',pic:'9999/99/99 99:99:99'},{av:'Ddo_br_encounter_refusereasonid_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASONID',prop:'SortedStatus'},{av:'Ddo_br_encounterid_Sortedstatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'Ddo_br_encounter_refusereason_reason_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_REASON',prop:'SortedStatus'},{av:'Ddo_br_encounter_refusereason_status_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_STATUS',prop:'SortedStatus'},{av:'AV16BR_Encounter_RefuseReasonIDTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASONIDTITLEFILTERDATA',pic:''},{av:'AV20BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Encounter_RefuseReason_ReasonTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASON_REASONTITLEFILTERDATA',pic:''},{av:'AV28BR_Encounter_RefuseReason_NoApproveDateTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATETITLEFILTERDATA',pic:''},{av:'AV34BR_Encounter_RefuseReason_StatusTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASON_STATUSTITLEFILTERDATA',pic:''},{av:'edtBR_Encounter_RefuseReasonID_Titleformat',ctrl:'BR_ENCOUNTER_REFUSEREASONID',prop:'Titleformat'},{av:'edtBR_Encounter_RefuseReasonID_Title',ctrl:'BR_ENCOUNTER_REFUSEREASONID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Encounter_RefuseReason_Reason_Titleformat',ctrl:'BR_ENCOUNTER_REFUSEREASON_REASON',prop:'Titleformat'},{av:'edtBR_Encounter_RefuseReason_Reason_Title',ctrl:'BR_ENCOUNTER_REFUSEREASON_REASON',prop:'Title'},{av:'edtBR_Encounter_RefuseReason_NoApproveDate_Titleformat',ctrl:'BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'Titleformat'},{av:'edtBR_Encounter_RefuseReason_NoApproveDate_Title',ctrl:'BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'Title'},{av:'cmbBR_Encounter_RefuseReason_Status'},{av:'AV40GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV41GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV42GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV45IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV47IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_ENCOUNTER_REFUSEREASON_STATUS.ONOPTIONCLICKED","{handler:'E177C2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFBR_Encounter_RefuseReasonID',fld:'vTFBR_ENCOUNTER_REFUSEREASONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18TFBR_Encounter_RefuseReasonID_To',fld:'vTFBR_ENCOUNTER_REFUSEREASONID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV21TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV25TFBR_Encounter_RefuseReason_Reason',fld:'vTFBR_ENCOUNTER_REFUSEREASON_REASON',pic:''},{av:'AV26TFBR_Encounter_RefuseReason_Reason_Sel',fld:'vTFBR_ENCOUNTER_REFUSEREASON_REASON_SEL',pic:''},{av:'AV29TFBR_Encounter_RefuseReason_NoApproveDate',fld:'vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',pic:'9999/99/99 99:99:99'},{av:'AV30TFBR_Encounter_RefuseReason_NoApproveDate_To',fld:'vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_TO',pic:'9999/99/99 99:99:99'},{av:'AV19ddo_BR_Encounter_RefuseReasonIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_REASONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Encounter_RefuseReason_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV36TFBR_Encounter_RefuseReason_Status_Sels',fld:'vTFBR_ENCOUNTER_REFUSEREASON_STATUS_SELS',pic:''},{av:'AV63Pgmname',fld:'vPGMNAME',pic:''},{av:'AV45IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV47IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'Ddo_br_encounter_refusereason_status_Activeeventkey',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_STATUS',prop:'ActiveEventKey'},{av:'Ddo_br_encounter_refusereason_status_Selectedvalue_get',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_STATUS',prop:'SelectedValue_get'}]");
         setEventMetadata("DDO_BR_ENCOUNTER_REFUSEREASON_STATUS.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_encounter_refusereason_status_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_STATUS',prop:'SortedStatus'},{av:'AV36TFBR_Encounter_RefuseReason_Status_Sels',fld:'vTFBR_ENCOUNTER_REFUSEREASON_STATUS_SELS',pic:''},{av:'Ddo_br_encounter_refusereasonid_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASONID',prop:'SortedStatus'},{av:'Ddo_br_encounterid_Sortedstatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'Ddo_br_encounter_refusereason_reason_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_REASON',prop:'SortedStatus'},{av:'Ddo_br_encounter_refusereason_noapprovedate_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'SortedStatus'},{av:'AV16BR_Encounter_RefuseReasonIDTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASONIDTITLEFILTERDATA',pic:''},{av:'AV20BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV24BR_Encounter_RefuseReason_ReasonTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASON_REASONTITLEFILTERDATA',pic:''},{av:'AV28BR_Encounter_RefuseReason_NoApproveDateTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATETITLEFILTERDATA',pic:''},{av:'AV34BR_Encounter_RefuseReason_StatusTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASON_STATUSTITLEFILTERDATA',pic:''},{av:'edtBR_Encounter_RefuseReasonID_Titleformat',ctrl:'BR_ENCOUNTER_REFUSEREASONID',prop:'Titleformat'},{av:'edtBR_Encounter_RefuseReasonID_Title',ctrl:'BR_ENCOUNTER_REFUSEREASONID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Encounter_RefuseReason_Reason_Titleformat',ctrl:'BR_ENCOUNTER_REFUSEREASON_REASON',prop:'Titleformat'},{av:'edtBR_Encounter_RefuseReason_Reason_Title',ctrl:'BR_ENCOUNTER_REFUSEREASON_REASON',prop:'Title'},{av:'edtBR_Encounter_RefuseReason_NoApproveDate_Titleformat',ctrl:'BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'Titleformat'},{av:'edtBR_Encounter_RefuseReason_NoApproveDate_Title',ctrl:'BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'Title'},{av:'cmbBR_Encounter_RefuseReason_Status'},{av:'AV40GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV41GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV42GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV45IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV47IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("GRID.LOAD","{handler:'E217C2',iparms:[{av:'A348BR_Encounter_RefuseReasonID',fld:'BR_ENCOUNTER_REFUSEREASONID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV45IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV47IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''}]");
         setEventMetadata("GRID.LOAD",",oparms:[{av:'AV43Display',fld:'vDISPLAY',pic:''},{av:'edtavDisplay_Tooltiptext',ctrl:'vDISPLAY',prop:'Tooltiptext'},{av:'edtavDisplay_Link',ctrl:'vDISPLAY',prop:'Link'},{av:'AV44Update',fld:'vUPDATE',pic:''},{av:'edtavUpdate_Tooltiptext',ctrl:'vUPDATE',prop:'Tooltiptext'},{av:'edtavUpdate_Link',ctrl:'vUPDATE',prop:'Link'},{av:'AV46Delete',fld:'vDELETE',pic:''},{av:'edtavDelete_Tooltiptext',ctrl:'vDELETE',prop:'Tooltiptext'},{av:'edtavDelete_Link',ctrl:'vDELETE',prop:'Link'},{av:'edtBR_Encounter_RefuseReason_Reason_Link',ctrl:'BR_ENCOUNTER_REFUSEREASON_REASON',prop:'Link'}]}");
         setEventMetadata("'DOINSERT'","{handler:'E187C2',iparms:[{av:'A348BR_Encounter_RefuseReasonID',fld:'BR_ENCOUNTER_REFUSEREASONID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
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
         Ddo_br_encounter_refusereasonid_Activeeventkey = "";
         Ddo_br_encounter_refusereasonid_Filteredtext_get = "";
         Ddo_br_encounter_refusereasonid_Filteredtextto_get = "";
         Ddo_br_encounterid_Activeeventkey = "";
         Ddo_br_encounterid_Filteredtext_get = "";
         Ddo_br_encounterid_Filteredtextto_get = "";
         Ddo_br_encounter_refusereason_reason_Activeeventkey = "";
         Ddo_br_encounter_refusereason_reason_Filteredtext_get = "";
         Ddo_br_encounter_refusereason_reason_Selectedvalue_get = "";
         Ddo_br_encounter_refusereason_noapprovedate_Activeeventkey = "";
         Ddo_br_encounter_refusereason_noapprovedate_Filteredtext_get = "";
         Ddo_br_encounter_refusereason_noapprovedate_Filteredtextto_get = "";
         Ddo_br_encounter_refusereason_status_Activeeventkey = "";
         Ddo_br_encounter_refusereason_status_Selectedvalue_get = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV25TFBR_Encounter_RefuseReason_Reason = "";
         AV26TFBR_Encounter_RefuseReason_Reason_Sel = "";
         AV29TFBR_Encounter_RefuseReason_NoApproveDate = (DateTime)(DateTime.MinValue);
         AV30TFBR_Encounter_RefuseReason_NoApproveDate_To = (DateTime)(DateTime.MinValue);
         AV19ddo_BR_Encounter_RefuseReasonIDTitleControlIdToReplace = "";
         AV23ddo_BR_EncounterIDTitleControlIdToReplace = "";
         AV27ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace = "";
         AV33ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace = "";
         AV37ddo_BR_Encounter_RefuseReason_StatusTitleControlIdToReplace = "";
         AV36TFBR_Encounter_RefuseReason_Status_Sels = new GxSimpleCollection<short>();
         AV63Pgmname = "";
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         AV38DDO_TitleSettingsIcons = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV16BR_Encounter_RefuseReasonIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV20BR_EncounterIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV24BR_Encounter_RefuseReason_ReasonTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV28BR_Encounter_RefuseReason_NoApproveDateTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV34BR_Encounter_RefuseReason_StatusTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         Ddo_br_encounter_refusereasonid_Filteredtext_set = "";
         Ddo_br_encounter_refusereasonid_Filteredtextto_set = "";
         Ddo_br_encounter_refusereasonid_Sortedstatus = "";
         Ddo_br_encounterid_Filteredtext_set = "";
         Ddo_br_encounterid_Filteredtextto_set = "";
         Ddo_br_encounterid_Sortedstatus = "";
         Ddo_br_encounter_refusereason_reason_Filteredtext_set = "";
         Ddo_br_encounter_refusereason_reason_Selectedvalue_set = "";
         Ddo_br_encounter_refusereason_reason_Sortedstatus = "";
         Ddo_br_encounter_refusereason_noapprovedate_Filteredtext_set = "";
         Ddo_br_encounter_refusereason_noapprovedate_Filteredtextto_set = "";
         Ddo_br_encounter_refusereason_noapprovedate_Sortedstatus = "";
         Ddo_br_encounter_refusereason_status_Selectedvalue_set = "";
         Ddo_br_encounter_refusereason_status_Sortedstatus = "";
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
         AV43Display = "";
         AV44Update = "";
         AV46Delete = "";
         A349BR_Encounter_RefuseReason_Reason = "";
         A350BR_Encounter_RefuseReason_NoApproveDate = (DateTime)(DateTime.MinValue);
         ucGridpaginationbar = new GXUserControl();
         ucDdo_br_encounter_refusereasonid = new GXUserControl();
         ucDdo_br_encounterid = new GXUserControl();
         ucDdo_br_encounter_refusereason_reason = new GXUserControl();
         ucDdo_br_encounter_refusereason_noapprovedate = new GXUserControl();
         ucDdo_br_encounter_refusereason_status = new GXUserControl();
         ucWorkwithplusutilities1 = new GXUserControl();
         AV31DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDate = DateTime.MinValue;
         AV32DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDateTo = DateTime.MinValue;
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV60Display_GXI = "";
         AV61Update_GXI = "";
         AV62Delete_GXI = "";
         AV59BR_Encounter_RefuseReasonWWDS_9_Tfbr_encounter_refusereason_status_sels = new GxSimpleCollection<short>();
         scmdbuf = "";
         lV55BR_Encounter_RefuseReasonWWDS_5_Tfbr_encounter_refusereason_reason = "";
         AV56BR_Encounter_RefuseReasonWWDS_6_Tfbr_encounter_refusereason_reason_sel = "";
         AV55BR_Encounter_RefuseReasonWWDS_5_Tfbr_encounter_refusereason_reason = "";
         AV57BR_Encounter_RefuseReasonWWDS_7_Tfbr_encounter_refusereason_noapprovedate = (DateTime)(DateTime.MinValue);
         AV58BR_Encounter_RefuseReasonWWDS_8_Tfbr_encounter_refusereason_noapprovedate_to = (DateTime)(DateTime.MinValue);
         H007C2_A351BR_Encounter_RefuseReason_Status = new short[1] ;
         H007C2_n351BR_Encounter_RefuseReason_Status = new bool[] {false} ;
         H007C2_A350BR_Encounter_RefuseReason_NoApproveDate = new DateTime[] {DateTime.MinValue} ;
         H007C2_n350BR_Encounter_RefuseReason_NoApproveDate = new bool[] {false} ;
         H007C2_A349BR_Encounter_RefuseReason_Reason = new String[] {""} ;
         H007C2_n349BR_Encounter_RefuseReason_Reason = new bool[] {false} ;
         H007C2_A19BR_EncounterID = new long[1] ;
         H007C2_A348BR_Encounter_RefuseReasonID = new long[1] ;
         H007C3_AGRID_nRecordCount = new long[1] ;
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV6WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV35TFBR_Encounter_RefuseReason_Status_SelsJson = "";
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
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_encounter_refusereasonww__default(),
            new Object[][] {
                new Object[] {
               H007C2_A351BR_Encounter_RefuseReason_Status, H007C2_n351BR_Encounter_RefuseReason_Status, H007C2_A350BR_Encounter_RefuseReason_NoApproveDate, H007C2_n350BR_Encounter_RefuseReason_NoApproveDate, H007C2_A349BR_Encounter_RefuseReason_Reason, H007C2_n349BR_Encounter_RefuseReason_Reason, H007C2_A19BR_EncounterID, H007C2_A348BR_Encounter_RefuseReasonID
               }
               , new Object[] {
               H007C3_AGRID_nRecordCount
               }
            }
         );
         AV63Pgmname = "BR_Encounter_RefuseReasonWW";
         /* GeneXus formulas. */
         AV63Pgmname = "BR_Encounter_RefuseReasonWW";
         context.Gx_err = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_GXsfl_31 ;
      private short nGXsfl_31_idx=1 ;
      private short GRID_nEOF ;
      private short AV13OrderedBy ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short subGrid_Backcolorstyle ;
      private short subGrid_Titlebackstyle ;
      private short edtBR_Encounter_RefuseReasonID_Titleformat ;
      private short edtBR_EncounterID_Titleformat ;
      private short edtBR_Encounter_RefuseReason_Reason_Titleformat ;
      private short edtBR_Encounter_RefuseReason_NoApproveDate_Titleformat ;
      private short cmbBR_Encounter_RefuseReason_Status_Titleformat ;
      private short subGrid_Sortable ;
      private short A351BR_Encounter_RefuseReason_Status ;
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
      private int Ddo_br_encounter_refusereason_reason_Datalistupdateminimumcharacters ;
      private int bttBtninsert_Visible ;
      private int subGrid_Titlebackcolor ;
      private int subGrid_Allbackcolor ;
      private int edtavUpdate_Visible ;
      private int edtavDelete_Visible ;
      private int subGrid_Selectedindex ;
      private int subGrid_Selectioncolor ;
      private int subGrid_Hoveringcolor ;
      private int edtavDdo_br_encounter_refusereasonidtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_encounteridtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_encounter_refusereason_reasontitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_encounter_refusereason_noapprovedatetitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_encounter_refusereason_statustitlecontrolidtoreplace_Visible ;
      private int edtavOrderedby_Visible ;
      private int edtavOrdereddsc_Visible ;
      private int edtavTfbr_encounter_refusereasonid_Visible ;
      private int edtavTfbr_encounter_refusereasonid_to_Visible ;
      private int edtavTfbr_encounterid_Visible ;
      private int edtavTfbr_encounterid_to_Visible ;
      private int edtavTfbr_encounter_refusereason_reason_Visible ;
      private int edtavTfbr_encounter_refusereason_reason_sel_Visible ;
      private int edtavTfbr_encounter_refusereason_noapprovedate_Visible ;
      private int edtavTfbr_encounter_refusereason_noapprovedate_to_Visible ;
      private int subGrid_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int AV59BR_Encounter_RefuseReasonWWDS_9_Tfbr_encounter_refusereason_status_sels_Count ;
      private int AV39PageToGo ;
      private int AV64GXV1 ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private long GRID_nFirstRecordOnPage ;
      private long AV17TFBR_Encounter_RefuseReasonID ;
      private long AV18TFBR_Encounter_RefuseReasonID_To ;
      private long AV21TFBR_EncounterID ;
      private long AV22TFBR_EncounterID_To ;
      private long AV40GridCurrentPage ;
      private long AV42GridRecordCount ;
      private long AV41GridPageSize ;
      private long A348BR_Encounter_RefuseReasonID ;
      private long A19BR_EncounterID ;
      private long GRID_nCurrentRecord ;
      private long AV51BR_Encounter_RefuseReasonWWDS_1_Tfbr_encounter_refusereasonid ;
      private long AV52BR_Encounter_RefuseReasonWWDS_2_Tfbr_encounter_refusereasonid_to ;
      private long AV53BR_Encounter_RefuseReasonWWDS_3_Tfbr_encounterid ;
      private long AV54BR_Encounter_RefuseReasonWWDS_4_Tfbr_encounterid_to ;
      private long GRID_nRecordCount ;
      private String Gridpaginationbar_Selectedpage ;
      private String Ddo_br_encounter_refusereasonid_Activeeventkey ;
      private String Ddo_br_encounter_refusereasonid_Filteredtext_get ;
      private String Ddo_br_encounter_refusereasonid_Filteredtextto_get ;
      private String Ddo_br_encounterid_Activeeventkey ;
      private String Ddo_br_encounterid_Filteredtext_get ;
      private String Ddo_br_encounterid_Filteredtextto_get ;
      private String Ddo_br_encounter_refusereason_reason_Activeeventkey ;
      private String Ddo_br_encounter_refusereason_reason_Filteredtext_get ;
      private String Ddo_br_encounter_refusereason_reason_Selectedvalue_get ;
      private String Ddo_br_encounter_refusereason_noapprovedate_Activeeventkey ;
      private String Ddo_br_encounter_refusereason_noapprovedate_Filteredtext_get ;
      private String Ddo_br_encounter_refusereason_noapprovedate_Filteredtextto_get ;
      private String Ddo_br_encounter_refusereason_status_Activeeventkey ;
      private String Ddo_br_encounter_refusereason_status_Selectedvalue_get ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_31_idx="0001" ;
      private String AV63Pgmname ;
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
      private String Ddo_br_encounter_refusereasonid_Caption ;
      private String Ddo_br_encounter_refusereasonid_Tooltip ;
      private String Ddo_br_encounter_refusereasonid_Cls ;
      private String Ddo_br_encounter_refusereasonid_Filteredtext_set ;
      private String Ddo_br_encounter_refusereasonid_Filteredtextto_set ;
      private String Ddo_br_encounter_refusereasonid_Dropdownoptionstype ;
      private String Ddo_br_encounter_refusereasonid_Titlecontrolidtoreplace ;
      private String Ddo_br_encounter_refusereasonid_Sortedstatus ;
      private String Ddo_br_encounter_refusereasonid_Filtertype ;
      private String Ddo_br_encounter_refusereasonid_Sortasc ;
      private String Ddo_br_encounter_refusereasonid_Sortdsc ;
      private String Ddo_br_encounter_refusereasonid_Cleanfilter ;
      private String Ddo_br_encounter_refusereasonid_Rangefilterfrom ;
      private String Ddo_br_encounter_refusereasonid_Rangefilterto ;
      private String Ddo_br_encounter_refusereasonid_Searchbuttontext ;
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
      private String Ddo_br_encounter_refusereason_reason_Caption ;
      private String Ddo_br_encounter_refusereason_reason_Tooltip ;
      private String Ddo_br_encounter_refusereason_reason_Cls ;
      private String Ddo_br_encounter_refusereason_reason_Filteredtext_set ;
      private String Ddo_br_encounter_refusereason_reason_Selectedvalue_set ;
      private String Ddo_br_encounter_refusereason_reason_Dropdownoptionstype ;
      private String Ddo_br_encounter_refusereason_reason_Titlecontrolidtoreplace ;
      private String Ddo_br_encounter_refusereason_reason_Sortedstatus ;
      private String Ddo_br_encounter_refusereason_reason_Filtertype ;
      private String Ddo_br_encounter_refusereason_reason_Datalisttype ;
      private String Ddo_br_encounter_refusereason_reason_Datalistproc ;
      private String Ddo_br_encounter_refusereason_reason_Sortasc ;
      private String Ddo_br_encounter_refusereason_reason_Sortdsc ;
      private String Ddo_br_encounter_refusereason_reason_Loadingdata ;
      private String Ddo_br_encounter_refusereason_reason_Cleanfilter ;
      private String Ddo_br_encounter_refusereason_reason_Noresultsfound ;
      private String Ddo_br_encounter_refusereason_reason_Searchbuttontext ;
      private String Ddo_br_encounter_refusereason_noapprovedate_Caption ;
      private String Ddo_br_encounter_refusereason_noapprovedate_Tooltip ;
      private String Ddo_br_encounter_refusereason_noapprovedate_Cls ;
      private String Ddo_br_encounter_refusereason_noapprovedate_Filteredtext_set ;
      private String Ddo_br_encounter_refusereason_noapprovedate_Filteredtextto_set ;
      private String Ddo_br_encounter_refusereason_noapprovedate_Dropdownoptionstype ;
      private String Ddo_br_encounter_refusereason_noapprovedate_Titlecontrolidtoreplace ;
      private String Ddo_br_encounter_refusereason_noapprovedate_Sortedstatus ;
      private String Ddo_br_encounter_refusereason_noapprovedate_Filtertype ;
      private String Ddo_br_encounter_refusereason_noapprovedate_Sortasc ;
      private String Ddo_br_encounter_refusereason_noapprovedate_Sortdsc ;
      private String Ddo_br_encounter_refusereason_noapprovedate_Cleanfilter ;
      private String Ddo_br_encounter_refusereason_noapprovedate_Rangefilterfrom ;
      private String Ddo_br_encounter_refusereason_noapprovedate_Rangefilterto ;
      private String Ddo_br_encounter_refusereason_noapprovedate_Searchbuttontext ;
      private String Ddo_br_encounter_refusereason_status_Caption ;
      private String Ddo_br_encounter_refusereason_status_Tooltip ;
      private String Ddo_br_encounter_refusereason_status_Cls ;
      private String Ddo_br_encounter_refusereason_status_Selectedvalue_set ;
      private String Ddo_br_encounter_refusereason_status_Dropdownoptionstype ;
      private String Ddo_br_encounter_refusereason_status_Titlecontrolidtoreplace ;
      private String Ddo_br_encounter_refusereason_status_Sortedstatus ;
      private String Ddo_br_encounter_refusereason_status_Datalisttype ;
      private String Ddo_br_encounter_refusereason_status_Datalistfixedvalues ;
      private String Ddo_br_encounter_refusereason_status_Sortasc ;
      private String Ddo_br_encounter_refusereason_status_Sortdsc ;
      private String Ddo_br_encounter_refusereason_status_Cleanfilter ;
      private String Ddo_br_encounter_refusereason_status_Searchbuttontext ;
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
      private String edtBR_Encounter_RefuseReasonID_Title ;
      private String edtBR_EncounterID_Title ;
      private String edtBR_Encounter_RefuseReason_Reason_Title ;
      private String edtBR_Encounter_RefuseReason_NoApproveDate_Title ;
      private String subGrid_Header ;
      private String edtavDisplay_Link ;
      private String edtavDisplay_Tooltiptext ;
      private String edtavUpdate_Link ;
      private String edtavUpdate_Tooltiptext ;
      private String edtavDelete_Link ;
      private String edtavDelete_Tooltiptext ;
      private String edtBR_Encounter_RefuseReason_Reason_Link ;
      private String divHtml_gridpaginationbar_Internalname ;
      private String Gridpaginationbar_Internalname ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String Ddo_br_encounter_refusereasonid_Internalname ;
      private String edtavDdo_br_encounter_refusereasonidtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_encounterid_Internalname ;
      private String edtavDdo_br_encounteridtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_encounter_refusereason_reason_Internalname ;
      private String edtavDdo_br_encounter_refusereason_reasontitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_encounter_refusereason_noapprovedate_Internalname ;
      private String edtavDdo_br_encounter_refusereason_noapprovedatetitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_encounter_refusereason_status_Internalname ;
      private String edtavDdo_br_encounter_refusereason_statustitlecontrolidtoreplace_Internalname ;
      private String Workwithplusutilities1_Internalname ;
      private String edtavOrderedby_Internalname ;
      private String edtavOrderedby_Jsonclick ;
      private String edtavOrdereddsc_Internalname ;
      private String edtavOrdereddsc_Jsonclick ;
      private String edtavTfbr_encounter_refusereasonid_Internalname ;
      private String edtavTfbr_encounter_refusereasonid_Jsonclick ;
      private String edtavTfbr_encounter_refusereasonid_to_Internalname ;
      private String edtavTfbr_encounter_refusereasonid_to_Jsonclick ;
      private String edtavTfbr_encounterid_Internalname ;
      private String edtavTfbr_encounterid_Jsonclick ;
      private String edtavTfbr_encounterid_to_Internalname ;
      private String edtavTfbr_encounterid_to_Jsonclick ;
      private String edtavTfbr_encounter_refusereason_reason_Internalname ;
      private String edtavTfbr_encounter_refusereason_reason_sel_Internalname ;
      private String edtavTfbr_encounter_refusereason_noapprovedate_Internalname ;
      private String edtavTfbr_encounter_refusereason_noapprovedate_Jsonclick ;
      private String edtavTfbr_encounter_refusereason_noapprovedate_to_Internalname ;
      private String edtavTfbr_encounter_refusereason_noapprovedate_to_Jsonclick ;
      private String divDdo_br_encounter_refusereason_noapprovedateauxdates_Internalname ;
      private String edtavDdo_br_encounter_refusereason_noapprovedateauxdate_Internalname ;
      private String edtavDdo_br_encounter_refusereason_noapprovedateauxdate_Jsonclick ;
      private String edtavDdo_br_encounter_refusereason_noapprovedateauxdateto_Internalname ;
      private String edtavDdo_br_encounter_refusereason_noapprovedateauxdateto_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavDisplay_Internalname ;
      private String edtavUpdate_Internalname ;
      private String edtavDelete_Internalname ;
      private String edtBR_Encounter_RefuseReasonID_Internalname ;
      private String edtBR_EncounterID_Internalname ;
      private String edtBR_Encounter_RefuseReason_Reason_Internalname ;
      private String edtBR_Encounter_RefuseReason_NoApproveDate_Internalname ;
      private String cmbBR_Encounter_RefuseReason_Status_Internalname ;
      private String scmdbuf ;
      private String sGXsfl_31_fel_idx="0001" ;
      private String sImgUrl ;
      private String ROClassString ;
      private String edtBR_Encounter_RefuseReasonID_Jsonclick ;
      private String edtBR_EncounterID_Jsonclick ;
      private String edtBR_Encounter_RefuseReason_Reason_Jsonclick ;
      private String edtBR_Encounter_RefuseReason_NoApproveDate_Jsonclick ;
      private String GXCCtl ;
      private String cmbBR_Encounter_RefuseReason_Status_Jsonclick ;
      private DateTime AV29TFBR_Encounter_RefuseReason_NoApproveDate ;
      private DateTime AV30TFBR_Encounter_RefuseReason_NoApproveDate_To ;
      private DateTime A350BR_Encounter_RefuseReason_NoApproveDate ;
      private DateTime AV57BR_Encounter_RefuseReasonWWDS_7_Tfbr_encounter_refusereason_noapprovedate ;
      private DateTime AV58BR_Encounter_RefuseReasonWWDS_8_Tfbr_encounter_refusereason_noapprovedate_to ;
      private DateTime AV31DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDate ;
      private DateTime AV32DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDateTo ;
      private bool entryPointCalled ;
      private bool AV14OrderedDsc ;
      private bool AV45IsAuthorized_Update ;
      private bool AV47IsAuthorized_Delete ;
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
      private bool Ddo_br_encounter_refusereasonid_Includesortasc ;
      private bool Ddo_br_encounter_refusereasonid_Includesortdsc ;
      private bool Ddo_br_encounter_refusereasonid_Includefilter ;
      private bool Ddo_br_encounter_refusereasonid_Filterisrange ;
      private bool Ddo_br_encounter_refusereasonid_Includedatalist ;
      private bool Ddo_br_encounterid_Includesortasc ;
      private bool Ddo_br_encounterid_Includesortdsc ;
      private bool Ddo_br_encounterid_Includefilter ;
      private bool Ddo_br_encounterid_Filterisrange ;
      private bool Ddo_br_encounterid_Includedatalist ;
      private bool Ddo_br_encounter_refusereason_reason_Includesortasc ;
      private bool Ddo_br_encounter_refusereason_reason_Includesortdsc ;
      private bool Ddo_br_encounter_refusereason_reason_Includefilter ;
      private bool Ddo_br_encounter_refusereason_reason_Filterisrange ;
      private bool Ddo_br_encounter_refusereason_reason_Includedatalist ;
      private bool Ddo_br_encounter_refusereason_noapprovedate_Includesortasc ;
      private bool Ddo_br_encounter_refusereason_noapprovedate_Includesortdsc ;
      private bool Ddo_br_encounter_refusereason_noapprovedate_Includefilter ;
      private bool Ddo_br_encounter_refusereason_noapprovedate_Filterisrange ;
      private bool Ddo_br_encounter_refusereason_noapprovedate_Includedatalist ;
      private bool Ddo_br_encounter_refusereason_status_Includesortasc ;
      private bool Ddo_br_encounter_refusereason_status_Includesortdsc ;
      private bool Ddo_br_encounter_refusereason_status_Includefilter ;
      private bool Ddo_br_encounter_refusereason_status_Includedatalist ;
      private bool Ddo_br_encounter_refusereason_status_Allowmultipleselection ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_31_Refreshing=false ;
      private bool n349BR_Encounter_RefuseReason_Reason ;
      private bool n350BR_Encounter_RefuseReason_NoApproveDate ;
      private bool n351BR_Encounter_RefuseReason_Status ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool gx_refresh_fired ;
      private bool AV48TempBoolean ;
      private bool GXt_boolean2 ;
      private bool AV43Display_IsBlob ;
      private bool AV44Update_IsBlob ;
      private bool AV46Delete_IsBlob ;
      private String AV35TFBR_Encounter_RefuseReason_Status_SelsJson ;
      private String AV25TFBR_Encounter_RefuseReason_Reason ;
      private String AV26TFBR_Encounter_RefuseReason_Reason_Sel ;
      private String AV19ddo_BR_Encounter_RefuseReasonIDTitleControlIdToReplace ;
      private String AV23ddo_BR_EncounterIDTitleControlIdToReplace ;
      private String AV27ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace ;
      private String AV33ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace ;
      private String AV37ddo_BR_Encounter_RefuseReason_StatusTitleControlIdToReplace ;
      private String A349BR_Encounter_RefuseReason_Reason ;
      private String AV60Display_GXI ;
      private String AV61Update_GXI ;
      private String AV62Delete_GXI ;
      private String lV55BR_Encounter_RefuseReasonWWDS_5_Tfbr_encounter_refusereason_reason ;
      private String AV56BR_Encounter_RefuseReasonWWDS_6_Tfbr_encounter_refusereason_reason_sel ;
      private String AV55BR_Encounter_RefuseReasonWWDS_5_Tfbr_encounter_refusereason_reason ;
      private String AV43Display ;
      private String AV44Update ;
      private String AV46Delete ;
      private GxSimpleCollection<short> AV36TFBR_Encounter_RefuseReason_Status_Sels ;
      private GxSimpleCollection<short> AV59BR_Encounter_RefuseReasonWWDS_9_Tfbr_encounter_refusereason_status_sels ;
      private IGxSession AV15Session ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private GXUserControl ucDvpanel_tableheader ;
      private GXUserControl ucGridpaginationbar ;
      private GXUserControl ucDdo_br_encounter_refusereasonid ;
      private GXUserControl ucDdo_br_encounterid ;
      private GXUserControl ucDdo_br_encounter_refusereason_reason ;
      private GXUserControl ucDdo_br_encounter_refusereason_noapprovedate ;
      private GXUserControl ucDdo_br_encounter_refusereason_status ;
      private GXUserControl ucWorkwithplusutilities1 ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbBR_Encounter_RefuseReason_Status ;
      private IDataStoreProvider pr_default ;
      private short[] H007C2_A351BR_Encounter_RefuseReason_Status ;
      private bool[] H007C2_n351BR_Encounter_RefuseReason_Status ;
      private DateTime[] H007C2_A350BR_Encounter_RefuseReason_NoApproveDate ;
      private bool[] H007C2_n350BR_Encounter_RefuseReason_NoApproveDate ;
      private String[] H007C2_A349BR_Encounter_RefuseReason_Reason ;
      private bool[] H007C2_n349BR_Encounter_RefuseReason_Reason ;
      private long[] H007C2_A19BR_EncounterID ;
      private long[] H007C2_A348BR_Encounter_RefuseReasonID ;
      private long[] H007C3_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV8HTTPRequest ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV16BR_Encounter_RefuseReasonIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV20BR_EncounterIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV24BR_Encounter_RefuseReason_ReasonTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV28BR_Encounter_RefuseReason_NoApproveDateTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV34BR_Encounter_RefuseReason_StatusTitleFilterData ;
      private GXWebForm Form ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV9TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV11GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue AV12GridStateFilterValue ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons AV38DDO_TitleSettingsIcons ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 ;
   }

   public class br_encounter_refusereasonww__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H007C2( IGxContext context ,
                                             short A351BR_Encounter_RefuseReason_Status ,
                                             GxSimpleCollection<short> AV59BR_Encounter_RefuseReasonWWDS_9_Tfbr_encounter_refusereason_status_sels ,
                                             long AV51BR_Encounter_RefuseReasonWWDS_1_Tfbr_encounter_refusereasonid ,
                                             long AV52BR_Encounter_RefuseReasonWWDS_2_Tfbr_encounter_refusereasonid_to ,
                                             long AV53BR_Encounter_RefuseReasonWWDS_3_Tfbr_encounterid ,
                                             long AV54BR_Encounter_RefuseReasonWWDS_4_Tfbr_encounterid_to ,
                                             String AV56BR_Encounter_RefuseReasonWWDS_6_Tfbr_encounter_refusereason_reason_sel ,
                                             String AV55BR_Encounter_RefuseReasonWWDS_5_Tfbr_encounter_refusereason_reason ,
                                             DateTime AV57BR_Encounter_RefuseReasonWWDS_7_Tfbr_encounter_refusereason_noapprovedate ,
                                             DateTime AV58BR_Encounter_RefuseReasonWWDS_8_Tfbr_encounter_refusereason_noapprovedate_to ,
                                             int AV59BR_Encounter_RefuseReasonWWDS_9_Tfbr_encounter_refusereason_status_sels_Count ,
                                             long A348BR_Encounter_RefuseReasonID ,
                                             long A19BR_EncounterID ,
                                             String A349BR_Encounter_RefuseReason_Reason ,
                                             DateTime A350BR_Encounter_RefuseReason_NoApproveDate ,
                                             short AV13OrderedBy ,
                                             bool AV14OrderedDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int3 ;
         GXv_int3 = new short [11] ;
         Object[] GXv_Object4 ;
         GXv_Object4 = new Object [2] ;
         String sSelectString ;
         String sFromString ;
         String sOrderString ;
         sSelectString = " [BR_Encounter_RefuseReason_Status], [BR_Encounter_RefuseReason_NoApproveDate], [BR_Encounter_RefuseReason_Reason], [BR_EncounterID], [BR_Encounter_RefuseReasonID]";
         sFromString = " FROM [BR_Encounter_RefuseReason] WITH (NOLOCK)";
         sOrderString = "";
         if ( ! (0==AV51BR_Encounter_RefuseReasonWWDS_1_Tfbr_encounter_refusereasonid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Encounter_RefuseReasonID] >= @AV51BR_Encounter_RefuseReasonWWDS_1_Tfbr_encounter_refusereasonid)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Encounter_RefuseReasonID] >= @AV51BR_Encounter_RefuseReasonWWDS_1_Tfbr_encounter_refusereasonid)";
            }
         }
         else
         {
            GXv_int3[0] = 1;
         }
         if ( ! (0==AV52BR_Encounter_RefuseReasonWWDS_2_Tfbr_encounter_refusereasonid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Encounter_RefuseReasonID] <= @AV52BR_Encounter_RefuseReasonWWDS_2_Tfbr_encounter_refusereasonid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Encounter_RefuseReasonID] <= @AV52BR_Encounter_RefuseReasonWWDS_2_Tfbr_encounter_refusereasonid_to)";
            }
         }
         else
         {
            GXv_int3[1] = 1;
         }
         if ( ! (0==AV53BR_Encounter_RefuseReasonWWDS_3_Tfbr_encounterid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_EncounterID] >= @AV53BR_Encounter_RefuseReasonWWDS_3_Tfbr_encounterid)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_EncounterID] >= @AV53BR_Encounter_RefuseReasonWWDS_3_Tfbr_encounterid)";
            }
         }
         else
         {
            GXv_int3[2] = 1;
         }
         if ( ! (0==AV54BR_Encounter_RefuseReasonWWDS_4_Tfbr_encounterid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_EncounterID] <= @AV54BR_Encounter_RefuseReasonWWDS_4_Tfbr_encounterid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_EncounterID] <= @AV54BR_Encounter_RefuseReasonWWDS_4_Tfbr_encounterid_to)";
            }
         }
         else
         {
            GXv_int3[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV56BR_Encounter_RefuseReasonWWDS_6_Tfbr_encounter_refusereason_reason_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV55BR_Encounter_RefuseReasonWWDS_5_Tfbr_encounter_refusereason_reason)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Encounter_RefuseReason_Reason] like @lV55BR_Encounter_RefuseReasonWWDS_5_Tfbr_encounter_refusereason_reason)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Encounter_RefuseReason_Reason] like @lV55BR_Encounter_RefuseReasonWWDS_5_Tfbr_encounter_refusereason_reason)";
            }
         }
         else
         {
            GXv_int3[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV56BR_Encounter_RefuseReasonWWDS_6_Tfbr_encounter_refusereason_reason_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Encounter_RefuseReason_Reason] = @AV56BR_Encounter_RefuseReasonWWDS_6_Tfbr_encounter_refusereason_reason_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Encounter_RefuseReason_Reason] = @AV56BR_Encounter_RefuseReasonWWDS_6_Tfbr_encounter_refusereason_reason_sel)";
            }
         }
         else
         {
            GXv_int3[5] = 1;
         }
         if ( ! (DateTime.MinValue==AV57BR_Encounter_RefuseReasonWWDS_7_Tfbr_encounter_refusereason_noapprovedate) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Encounter_RefuseReason_NoApproveDate] >= @AV57BR_Encounter_RefuseReasonWWDS_7_Tfbr_encounter_refusereason_noapprovedate)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Encounter_RefuseReason_NoApproveDate] >= @AV57BR_Encounter_RefuseReasonWWDS_7_Tfbr_encounter_refusereason_noapprovedate)";
            }
         }
         else
         {
            GXv_int3[6] = 1;
         }
         if ( ! (DateTime.MinValue==AV58BR_Encounter_RefuseReasonWWDS_8_Tfbr_encounter_refusereason_noapprovedate_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Encounter_RefuseReason_NoApproveDate] <= @AV58BR_Encounter_RefuseReasonWWDS_8_Tfbr_encounter_refusereason_noapprovedate_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Encounter_RefuseReason_NoApproveDate] <= @AV58BR_Encounter_RefuseReasonWWDS_8_Tfbr_encounter_refusereason_noapprovedate_to)";
            }
         }
         else
         {
            GXv_int3[7] = 1;
         }
         if ( AV59BR_Encounter_RefuseReasonWWDS_9_Tfbr_encounter_refusereason_status_sels_Count > 0 )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV59BR_Encounter_RefuseReasonWWDS_9_Tfbr_encounter_refusereason_status_sels, "[BR_Encounter_RefuseReason_Status] IN (", ")") + ")";
            }
            else
            {
               sWhereString = sWhereString + " (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV59BR_Encounter_RefuseReasonWWDS_9_Tfbr_encounter_refusereason_status_sels, "[BR_Encounter_RefuseReason_Status] IN (", ")") + ")";
            }
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            sWhereString = " WHERE" + sWhereString;
         }
         if ( ( AV13OrderedBy == 1 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Encounter_RefuseReasonID]";
         }
         else if ( ( AV13OrderedBy == 1 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Encounter_RefuseReasonID] DESC";
         }
         else if ( ( AV13OrderedBy == 2 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_EncounterID]";
         }
         else if ( ( AV13OrderedBy == 2 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_EncounterID] DESC";
         }
         else if ( ( AV13OrderedBy == 3 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Encounter_RefuseReason_Reason]";
         }
         else if ( ( AV13OrderedBy == 3 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Encounter_RefuseReason_Reason] DESC";
         }
         else if ( ( AV13OrderedBy == 4 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Encounter_RefuseReason_NoApproveDate]";
         }
         else if ( ( AV13OrderedBy == 4 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Encounter_RefuseReason_NoApproveDate] DESC";
         }
         else if ( ( AV13OrderedBy == 5 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Encounter_RefuseReason_Status]";
         }
         else if ( ( AV13OrderedBy == 5 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Encounter_RefuseReason_Status] DESC";
         }
         else if ( true )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Encounter_RefuseReasonID]";
         }
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object4[0] = scmdbuf;
         GXv_Object4[1] = GXv_int3;
         return GXv_Object4 ;
      }

      protected Object[] conditional_H007C3( IGxContext context ,
                                             short A351BR_Encounter_RefuseReason_Status ,
                                             GxSimpleCollection<short> AV59BR_Encounter_RefuseReasonWWDS_9_Tfbr_encounter_refusereason_status_sels ,
                                             long AV51BR_Encounter_RefuseReasonWWDS_1_Tfbr_encounter_refusereasonid ,
                                             long AV52BR_Encounter_RefuseReasonWWDS_2_Tfbr_encounter_refusereasonid_to ,
                                             long AV53BR_Encounter_RefuseReasonWWDS_3_Tfbr_encounterid ,
                                             long AV54BR_Encounter_RefuseReasonWWDS_4_Tfbr_encounterid_to ,
                                             String AV56BR_Encounter_RefuseReasonWWDS_6_Tfbr_encounter_refusereason_reason_sel ,
                                             String AV55BR_Encounter_RefuseReasonWWDS_5_Tfbr_encounter_refusereason_reason ,
                                             DateTime AV57BR_Encounter_RefuseReasonWWDS_7_Tfbr_encounter_refusereason_noapprovedate ,
                                             DateTime AV58BR_Encounter_RefuseReasonWWDS_8_Tfbr_encounter_refusereason_noapprovedate_to ,
                                             int AV59BR_Encounter_RefuseReasonWWDS_9_Tfbr_encounter_refusereason_status_sels_Count ,
                                             long A348BR_Encounter_RefuseReasonID ,
                                             long A19BR_EncounterID ,
                                             String A349BR_Encounter_RefuseReason_Reason ,
                                             DateTime A350BR_Encounter_RefuseReason_NoApproveDate ,
                                             short AV13OrderedBy ,
                                             bool AV14OrderedDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int5 ;
         GXv_int5 = new short [8] ;
         Object[] GXv_Object6 ;
         GXv_Object6 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM [BR_Encounter_RefuseReason] WITH (NOLOCK)";
         if ( ! (0==AV51BR_Encounter_RefuseReasonWWDS_1_Tfbr_encounter_refusereasonid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Encounter_RefuseReasonID] >= @AV51BR_Encounter_RefuseReasonWWDS_1_Tfbr_encounter_refusereasonid)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Encounter_RefuseReasonID] >= @AV51BR_Encounter_RefuseReasonWWDS_1_Tfbr_encounter_refusereasonid)";
            }
         }
         else
         {
            GXv_int5[0] = 1;
         }
         if ( ! (0==AV52BR_Encounter_RefuseReasonWWDS_2_Tfbr_encounter_refusereasonid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Encounter_RefuseReasonID] <= @AV52BR_Encounter_RefuseReasonWWDS_2_Tfbr_encounter_refusereasonid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Encounter_RefuseReasonID] <= @AV52BR_Encounter_RefuseReasonWWDS_2_Tfbr_encounter_refusereasonid_to)";
            }
         }
         else
         {
            GXv_int5[1] = 1;
         }
         if ( ! (0==AV53BR_Encounter_RefuseReasonWWDS_3_Tfbr_encounterid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_EncounterID] >= @AV53BR_Encounter_RefuseReasonWWDS_3_Tfbr_encounterid)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_EncounterID] >= @AV53BR_Encounter_RefuseReasonWWDS_3_Tfbr_encounterid)";
            }
         }
         else
         {
            GXv_int5[2] = 1;
         }
         if ( ! (0==AV54BR_Encounter_RefuseReasonWWDS_4_Tfbr_encounterid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_EncounterID] <= @AV54BR_Encounter_RefuseReasonWWDS_4_Tfbr_encounterid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_EncounterID] <= @AV54BR_Encounter_RefuseReasonWWDS_4_Tfbr_encounterid_to)";
            }
         }
         else
         {
            GXv_int5[3] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV56BR_Encounter_RefuseReasonWWDS_6_Tfbr_encounter_refusereason_reason_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV55BR_Encounter_RefuseReasonWWDS_5_Tfbr_encounter_refusereason_reason)) ) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Encounter_RefuseReason_Reason] like @lV55BR_Encounter_RefuseReasonWWDS_5_Tfbr_encounter_refusereason_reason)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Encounter_RefuseReason_Reason] like @lV55BR_Encounter_RefuseReasonWWDS_5_Tfbr_encounter_refusereason_reason)";
            }
         }
         else
         {
            GXv_int5[4] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV56BR_Encounter_RefuseReasonWWDS_6_Tfbr_encounter_refusereason_reason_sel)) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Encounter_RefuseReason_Reason] = @AV56BR_Encounter_RefuseReasonWWDS_6_Tfbr_encounter_refusereason_reason_sel)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Encounter_RefuseReason_Reason] = @AV56BR_Encounter_RefuseReasonWWDS_6_Tfbr_encounter_refusereason_reason_sel)";
            }
         }
         else
         {
            GXv_int5[5] = 1;
         }
         if ( ! (DateTime.MinValue==AV57BR_Encounter_RefuseReasonWWDS_7_Tfbr_encounter_refusereason_noapprovedate) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Encounter_RefuseReason_NoApproveDate] >= @AV57BR_Encounter_RefuseReasonWWDS_7_Tfbr_encounter_refusereason_noapprovedate)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Encounter_RefuseReason_NoApproveDate] >= @AV57BR_Encounter_RefuseReasonWWDS_7_Tfbr_encounter_refusereason_noapprovedate)";
            }
         }
         else
         {
            GXv_int5[6] = 1;
         }
         if ( ! (DateTime.MinValue==AV58BR_Encounter_RefuseReasonWWDS_8_Tfbr_encounter_refusereason_noapprovedate_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Encounter_RefuseReason_NoApproveDate] <= @AV58BR_Encounter_RefuseReasonWWDS_8_Tfbr_encounter_refusereason_noapprovedate_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Encounter_RefuseReason_NoApproveDate] <= @AV58BR_Encounter_RefuseReasonWWDS_8_Tfbr_encounter_refusereason_noapprovedate_to)";
            }
         }
         else
         {
            GXv_int5[7] = 1;
         }
         if ( AV59BR_Encounter_RefuseReasonWWDS_9_Tfbr_encounter_refusereason_status_sels_Count > 0 )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV59BR_Encounter_RefuseReasonWWDS_9_Tfbr_encounter_refusereason_status_sels, "[BR_Encounter_RefuseReason_Status] IN (", ")") + ")";
            }
            else
            {
               sWhereString = sWhereString + " (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV59BR_Encounter_RefuseReasonWWDS_9_Tfbr_encounter_refusereason_status_sels, "[BR_Encounter_RefuseReason_Status] IN (", ")") + ")";
            }
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
                     return conditional_H007C2(context, (short)dynConstraints[0] , (GxSimpleCollection<short>)dynConstraints[1] , (long)dynConstraints[2] , (long)dynConstraints[3] , (long)dynConstraints[4] , (long)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (DateTime)dynConstraints[8] , (DateTime)dynConstraints[9] , (int)dynConstraints[10] , (long)dynConstraints[11] , (long)dynConstraints[12] , (String)dynConstraints[13] , (DateTime)dynConstraints[14] , (short)dynConstraints[15] , (bool)dynConstraints[16] );
               case 1 :
                     return conditional_H007C3(context, (short)dynConstraints[0] , (GxSimpleCollection<short>)dynConstraints[1] , (long)dynConstraints[2] , (long)dynConstraints[3] , (long)dynConstraints[4] , (long)dynConstraints[5] , (String)dynConstraints[6] , (String)dynConstraints[7] , (DateTime)dynConstraints[8] , (DateTime)dynConstraints[9] , (int)dynConstraints[10] , (long)dynConstraints[11] , (long)dynConstraints[12] , (String)dynConstraints[13] , (DateTime)dynConstraints[14] , (short)dynConstraints[15] , (bool)dynConstraints[16] );
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
          Object[] prmH007C2 ;
          prmH007C2 = new Object[] {
          new Object[] {"@AV51BR_Encounter_RefuseReasonWWDS_1_Tfbr_encounter_refusereasonid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV52BR_Encounter_RefuseReasonWWDS_2_Tfbr_encounter_refusereasonid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV53BR_Encounter_RefuseReasonWWDS_3_Tfbr_encounterid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV54BR_Encounter_RefuseReasonWWDS_4_Tfbr_encounterid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV55BR_Encounter_RefuseReasonWWDS_5_Tfbr_encounter_refusereason_reason",SqlDbType.NVarChar,300,0} ,
          new Object[] {"@AV56BR_Encounter_RefuseReasonWWDS_6_Tfbr_encounter_refusereason_reason_sel",SqlDbType.NVarChar,300,0} ,
          new Object[] {"@AV57BR_Encounter_RefuseReasonWWDS_7_Tfbr_encounter_refusereason_noapprovedate",SqlDbType.DateTime,10,8} ,
          new Object[] {"@AV58BR_Encounter_RefuseReasonWWDS_8_Tfbr_encounter_refusereason_noapprovedate_to",SqlDbType.DateTime,10,8} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH007C3 ;
          prmH007C3 = new Object[] {
          new Object[] {"@AV51BR_Encounter_RefuseReasonWWDS_1_Tfbr_encounter_refusereasonid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV52BR_Encounter_RefuseReasonWWDS_2_Tfbr_encounter_refusereasonid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV53BR_Encounter_RefuseReasonWWDS_3_Tfbr_encounterid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV54BR_Encounter_RefuseReasonWWDS_4_Tfbr_encounterid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@lV55BR_Encounter_RefuseReasonWWDS_5_Tfbr_encounter_refusereason_reason",SqlDbType.NVarChar,300,0} ,
          new Object[] {"@AV56BR_Encounter_RefuseReasonWWDS_6_Tfbr_encounter_refusereason_reason_sel",SqlDbType.NVarChar,300,0} ,
          new Object[] {"@AV57BR_Encounter_RefuseReasonWWDS_7_Tfbr_encounter_refusereason_noapprovedate",SqlDbType.DateTime,10,8} ,
          new Object[] {"@AV58BR_Encounter_RefuseReasonWWDS_8_Tfbr_encounter_refusereason_noapprovedate_to",SqlDbType.DateTime,10,8}
          } ;
          def= new CursorDef[] {
              new CursorDef("H007C2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH007C2,11,0,true,false )
             ,new CursorDef("H007C3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH007C3,1,0,true,false )
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
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((DateTime[]) buf[2])[0] = rslt.getGXDateTime(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((String[]) buf[4])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((long[]) buf[6])[0] = rslt.getLong(4) ;
                ((long[]) buf[7])[0] = rslt.getLong(5) ;
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
                   stmt.SetParameter(sIdx, (long)parms[11]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[12]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[13]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[14]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[15]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[16]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameterDatetime(sIdx, (DateTime)parms[17]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameterDatetime(sIdx, (DateTime)parms[18]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[19]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[20]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[21]);
                }
                return;
             case 1 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[8]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[9]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[10]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[11]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[12]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[13]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameterDatetime(sIdx, (DateTime)parms[14]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameterDatetime(sIdx, (DateTime)parms[15]);
                }
                return;
       }
    }

 }

}
