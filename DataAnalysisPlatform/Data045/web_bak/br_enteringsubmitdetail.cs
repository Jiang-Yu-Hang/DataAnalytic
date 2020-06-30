/*
               File: BR_EnteringSubmitDetail
        Description: Data Mgmt Portal - RAAP
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:46:54.5
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
   public class br_enteringsubmitdetail : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public br_enteringsubmitdetail( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_enteringsubmitdetail( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( long aP0_BR_EncounterID )
      {
         this.AV13BR_EncounterID = aP0_BR_EncounterID;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         cmbavBr_encounterreason_vstatus = new GXCombobox();
         cmbBR_Encounter_RefuseReason_Status = new GXCombobox();
         chkBR_EncounterReason_IsApprove = new GXCheckbox();
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
               nRC_GXsfl_17 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               nGXsfl_17_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
               sGXsfl_17_idx = GetNextPar( );
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
               AV48BR_EncounterReason_vStatus = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV26OrderedBy = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV27OrderedDsc = StringUtil.StrToBool( GetNextPar( ));
               AV34TFBR_Encounter_RefuseReason_Reason = GetNextPar( );
               AV35TFBR_Encounter_RefuseReason_Reason_Sel = GetNextPar( );
               AV38TFBR_Encounter_RefuseReason_NoApproveDate = context.localUtil.ParseDTimeParm( GetNextPar( ));
               AV39TFBR_Encounter_RefuseReason_NoApproveDate_To = context.localUtil.ParseDTimeParm( GetNextPar( ));
               AV50TFBR_Encounter_RefuseReason_FReason = GetNextPar( );
               AV51TFBR_Encounter_RefuseReason_FReason_Sel = GetNextPar( );
               AV54TFBR_Encounter_RefuseReason_FApproveDate = context.localUtil.ParseDTimeParm( GetNextPar( ));
               AV55TFBR_Encounter_RefuseReason_FApproveDate_To = context.localUtil.ParseDTimeParm( GetNextPar( ));
               AV13BR_EncounterID = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV36ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace = GetNextPar( );
               AV42ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace = GetNextPar( );
               AV52ddo_BR_Encounter_RefuseReason_FReasonTitleControlIdToReplace = GetNextPar( );
               AV58ddo_BR_Encounter_RefuseReason_FApproveDateTitleControlIdToReplace = GetNextPar( );
               AV70Pgmname = GetNextPar( );
               AV20IsAuthorized_BR_Encounter_RefuseReason_Reason = StringUtil.StrToBool( GetNextPar( ));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid_refresh( subGrid_Rows, AV48BR_EncounterReason_vStatus, AV26OrderedBy, AV27OrderedDsc, AV34TFBR_Encounter_RefuseReason_Reason, AV35TFBR_Encounter_RefuseReason_Reason_Sel, AV38TFBR_Encounter_RefuseReason_NoApproveDate, AV39TFBR_Encounter_RefuseReason_NoApproveDate_To, AV50TFBR_Encounter_RefuseReason_FReason, AV51TFBR_Encounter_RefuseReason_FReason_Sel, AV54TFBR_Encounter_RefuseReason_FApproveDate, AV55TFBR_Encounter_RefuseReason_FApproveDate_To, AV13BR_EncounterID, AV36ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace, AV42ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace, AV52ddo_BR_Encounter_RefuseReason_FReasonTitleControlIdToReplace, AV58ddo_BR_Encounter_RefuseReason_FApproveDateTitleControlIdToReplace, AV70Pgmname, AV20IsAuthorized_BR_Encounter_RefuseReason_Reason) ;
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
            if ( ! entryPointCalled && ! ( isAjaxCallMode( ) || isFullAjaxMode( ) ) )
            {
               AV13BR_EncounterID = (long)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13BR_EncounterID), 18, 0)));
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
         PA7D2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START7D2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?20202279465431", false);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.AddJavascriptSource("calendar.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("calendar-setup.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("calendar-zh.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("DVelop/DVPaginationBar/DVPaginationBarRender.js", "", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_enteringsubmitdetail.aspx") + "?" + UrlEncode("" +AV13BR_EncounterID)+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "GXH_vBR_ENCOUNTERREASON_VSTATUS", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV48BR_EncounterReason_vStatus), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vORDEREDBY", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV26OrderedBy), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vORDEREDDSC", StringUtil.BoolToStr( AV27OrderedDsc));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_ENCOUNTER_REFUSEREASON_REASON", AV34TFBR_Encounter_RefuseReason_Reason);
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_ENCOUNTER_REFUSEREASON_REASON_SEL", AV35TFBR_Encounter_RefuseReason_Reason_Sel);
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE", context.localUtil.TToC( AV38TFBR_Encounter_RefuseReason_NoApproveDate, 10, 8, 0, 0, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_TO", context.localUtil.TToC( AV39TFBR_Encounter_RefuseReason_NoApproveDate_To, 10, 8, 0, 0, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_ENCOUNTER_REFUSEREASON_FREASON", AV50TFBR_Encounter_RefuseReason_FReason);
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_ENCOUNTER_REFUSEREASON_FREASON_SEL", AV51TFBR_Encounter_RefuseReason_FReason_Sel);
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE", context.localUtil.TToC( AV54TFBR_Encounter_RefuseReason_FApproveDate, 10, 8, 0, 0, "/", ":", " "));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE_TO", context.localUtil.TToC( AV55TFBR_Encounter_RefuseReason_FApproveDate_To, 10, 8, 0, 0, "/", ":", " "));
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_17", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_17), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDCURRENTPAGE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV17GridCurrentPage), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDRECORDCOUNT", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV19GridRecordCount), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDPAGESIZE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV18GridPageSize), 10, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vDDO_TITLESETTINGSICONS", AV43DDO_TitleSettingsIcons);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vDDO_TITLESETTINGSICONS", AV43DDO_TitleSettingsIcons);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_ENCOUNTER_REFUSEREASON_REASONTITLEFILTERDATA", AV33BR_Encounter_RefuseReason_ReasonTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_ENCOUNTER_REFUSEREASON_REASONTITLEFILTERDATA", AV33BR_Encounter_RefuseReason_ReasonTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATETITLEFILTERDATA", AV37BR_Encounter_RefuseReason_NoApproveDateTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATETITLEFILTERDATA", AV37BR_Encounter_RefuseReason_NoApproveDateTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_ENCOUNTER_REFUSEREASON_FREASONTITLEFILTERDATA", AV49BR_Encounter_RefuseReason_FReasonTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_ENCOUNTER_REFUSEREASON_FREASONTITLEFILTERDATA", AV49BR_Encounter_RefuseReason_FReasonTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_ENCOUNTER_REFUSEREASON_FAPPROVEDATETITLEFILTERDATA", AV53BR_Encounter_RefuseReason_FApproveDateTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_ENCOUNTER_REFUSEREASON_FAPPROVEDATETITLEFILTERDATA", AV53BR_Encounter_RefuseReason_FApproveDateTitleFilterData);
         }
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV70Pgmname));
         GxWebStd.gx_boolean_hidden_field( context, "vISAUTHORIZED_BR_ENCOUNTER_REFUSEREASON_REASON", AV20IsAuthorized_BR_Encounter_RefuseReason_Reason);
         GxWebStd.gx_hidden_field( context, "gxhash_vISAUTHORIZED_BR_ENCOUNTER_REFUSEREASON_REASON", GetSecureSignedToken( "", AV20IsAuthorized_BR_Encounter_RefuseReason_Reason, context));
         GxWebStd.gx_hidden_field( context, "vBR_ENCOUNTERID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13BR_EncounterID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
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
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_FREASON_Caption", StringUtil.RTrim( Ddo_br_encounter_refusereason_freason_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_FREASON_Tooltip", StringUtil.RTrim( Ddo_br_encounter_refusereason_freason_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_FREASON_Cls", StringUtil.RTrim( Ddo_br_encounter_refusereason_freason_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_FREASON_Filteredtext_set", StringUtil.RTrim( Ddo_br_encounter_refusereason_freason_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_FREASON_Selectedvalue_set", StringUtil.RTrim( Ddo_br_encounter_refusereason_freason_Selectedvalue_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_FREASON_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_encounter_refusereason_freason_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_FREASON_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_encounter_refusereason_freason_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_FREASON_Includesortasc", StringUtil.BoolToStr( Ddo_br_encounter_refusereason_freason_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_FREASON_Includesortdsc", StringUtil.BoolToStr( Ddo_br_encounter_refusereason_freason_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_FREASON_Sortedstatus", StringUtil.RTrim( Ddo_br_encounter_refusereason_freason_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_FREASON_Includefilter", StringUtil.BoolToStr( Ddo_br_encounter_refusereason_freason_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_FREASON_Filtertype", StringUtil.RTrim( Ddo_br_encounter_refusereason_freason_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_FREASON_Filterisrange", StringUtil.BoolToStr( Ddo_br_encounter_refusereason_freason_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_FREASON_Includedatalist", StringUtil.BoolToStr( Ddo_br_encounter_refusereason_freason_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_FREASON_Datalisttype", StringUtil.RTrim( Ddo_br_encounter_refusereason_freason_Datalisttype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_FREASON_Datalistproc", StringUtil.RTrim( Ddo_br_encounter_refusereason_freason_Datalistproc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_FREASON_Datalistupdateminimumcharacters", StringUtil.LTrim( StringUtil.NToC( (decimal)(Ddo_br_encounter_refusereason_freason_Datalistupdateminimumcharacters), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_FREASON_Sortasc", StringUtil.RTrim( Ddo_br_encounter_refusereason_freason_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_FREASON_Sortdsc", StringUtil.RTrim( Ddo_br_encounter_refusereason_freason_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_FREASON_Loadingdata", StringUtil.RTrim( Ddo_br_encounter_refusereason_freason_Loadingdata));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_FREASON_Cleanfilter", StringUtil.RTrim( Ddo_br_encounter_refusereason_freason_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_FREASON_Noresultsfound", StringUtil.RTrim( Ddo_br_encounter_refusereason_freason_Noresultsfound));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_FREASON_Searchbuttontext", StringUtil.RTrim( Ddo_br_encounter_refusereason_freason_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE_Caption", StringUtil.RTrim( Ddo_br_encounter_refusereason_fapprovedate_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE_Tooltip", StringUtil.RTrim( Ddo_br_encounter_refusereason_fapprovedate_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE_Cls", StringUtil.RTrim( Ddo_br_encounter_refusereason_fapprovedate_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE_Filteredtext_set", StringUtil.RTrim( Ddo_br_encounter_refusereason_fapprovedate_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE_Filteredtextto_set", StringUtil.RTrim( Ddo_br_encounter_refusereason_fapprovedate_Filteredtextto_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_encounter_refusereason_fapprovedate_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_encounter_refusereason_fapprovedate_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE_Includesortasc", StringUtil.BoolToStr( Ddo_br_encounter_refusereason_fapprovedate_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE_Includesortdsc", StringUtil.BoolToStr( Ddo_br_encounter_refusereason_fapprovedate_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE_Sortedstatus", StringUtil.RTrim( Ddo_br_encounter_refusereason_fapprovedate_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE_Includefilter", StringUtil.BoolToStr( Ddo_br_encounter_refusereason_fapprovedate_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE_Filtertype", StringUtil.RTrim( Ddo_br_encounter_refusereason_fapprovedate_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE_Filterisrange", StringUtil.BoolToStr( Ddo_br_encounter_refusereason_fapprovedate_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE_Includedatalist", StringUtil.BoolToStr( Ddo_br_encounter_refusereason_fapprovedate_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE_Sortasc", StringUtil.RTrim( Ddo_br_encounter_refusereason_fapprovedate_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE_Sortdsc", StringUtil.RTrim( Ddo_br_encounter_refusereason_fapprovedate_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE_Cleanfilter", StringUtil.RTrim( Ddo_br_encounter_refusereason_fapprovedate_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE_Rangefilterfrom", StringUtil.RTrim( Ddo_br_encounter_refusereason_fapprovedate_Rangefilterfrom));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE_Rangefilterto", StringUtil.RTrim( Ddo_br_encounter_refusereason_fapprovedate_Rangefilterto));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE_Searchbuttontext", StringUtil.RTrim( Ddo_br_encounter_refusereason_fapprovedate_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_REASON_Activeeventkey", StringUtil.RTrim( Ddo_br_encounter_refusereason_reason_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_REASON_Filteredtext_get", StringUtil.RTrim( Ddo_br_encounter_refusereason_reason_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_REASON_Selectedvalue_get", StringUtil.RTrim( Ddo_br_encounter_refusereason_reason_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_Activeeventkey", StringUtil.RTrim( Ddo_br_encounter_refusereason_noapprovedate_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_Filteredtext_get", StringUtil.RTrim( Ddo_br_encounter_refusereason_noapprovedate_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_Filteredtextto_get", StringUtil.RTrim( Ddo_br_encounter_refusereason_noapprovedate_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_FREASON_Activeeventkey", StringUtil.RTrim( Ddo_br_encounter_refusereason_freason_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_FREASON_Filteredtext_get", StringUtil.RTrim( Ddo_br_encounter_refusereason_freason_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_FREASON_Selectedvalue_get", StringUtil.RTrim( Ddo_br_encounter_refusereason_freason_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE_Activeeventkey", StringUtil.RTrim( Ddo_br_encounter_refusereason_fapprovedate_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE_Filteredtext_get", StringUtil.RTrim( Ddo_br_encounter_refusereason_fapprovedate_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE_Filteredtextto_get", StringUtil.RTrim( Ddo_br_encounter_refusereason_fapprovedate_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_REASON_Activeeventkey", StringUtil.RTrim( Ddo_br_encounter_refusereason_reason_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_REASON_Filteredtext_get", StringUtil.RTrim( Ddo_br_encounter_refusereason_reason_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_REASON_Selectedvalue_get", StringUtil.RTrim( Ddo_br_encounter_refusereason_reason_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_Activeeventkey", StringUtil.RTrim( Ddo_br_encounter_refusereason_noapprovedate_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_Filteredtext_get", StringUtil.RTrim( Ddo_br_encounter_refusereason_noapprovedate_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_Filteredtextto_get", StringUtil.RTrim( Ddo_br_encounter_refusereason_noapprovedate_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_FREASON_Activeeventkey", StringUtil.RTrim( Ddo_br_encounter_refusereason_freason_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_FREASON_Filteredtext_get", StringUtil.RTrim( Ddo_br_encounter_refusereason_freason_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_FREASON_Selectedvalue_get", StringUtil.RTrim( Ddo_br_encounter_refusereason_freason_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE_Activeeventkey", StringUtil.RTrim( Ddo_br_encounter_refusereason_fapprovedate_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE_Filteredtext_get", StringUtil.RTrim( Ddo_br_encounter_refusereason_fapprovedate_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE_Filteredtextto_get", StringUtil.RTrim( Ddo_br_encounter_refusereason_fapprovedate_Filteredtextto_get));
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
            WE7D2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT7D2( ) ;
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
         return formatLink("br_enteringsubmitdetail.aspx") + "?" + UrlEncode("" +AV13BR_EncounterID) ;
      }

      public override String GetPgmname( )
      {
         return "BR_EnteringSubmitDetail" ;
      }

      public override String GetPgmdesc( )
      {
         return "Data Mgmt Portal - RAAP" ;
      }

      protected void WB7D0( )
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbavBr_encounterreason_vstatus_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavBr_encounterreason_vstatus_Internalname, "是否复审/是否初审", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 11,'',false,'" + sGXsfl_17_idx + "',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavBr_encounterreason_vstatus, cmbavBr_encounterreason_vstatus_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(AV48BR_EncounterReason_vStatus), 4, 0)), 1, cmbavBr_encounterreason_vstatus_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", 1, cmbavBr_encounterreason_vstatus.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,11);\"", "", true, "HLP_BR_EnteringSubmitDetail.htm");
            cmbavBr_encounterreason_vstatus.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV48BR_EncounterReason_vStatus), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavBr_encounterreason_vstatus_Internalname, "Values", (String)(cmbavBr_encounterreason_vstatus.ToJavascriptSource()), true);
            GxWebStd.gx_div_end( context, "left", "top", "div");
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
               context.WriteHtmlText( "<div id=\""+"GridContainer"+"DivS\" data-gxgridid=\"17\">") ;
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
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "Reason ID") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "就诊序号") ;
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
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "初审不通过状态") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "初审抽查通过操作人") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"AttributeCheckBox"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "是否初审抽查") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "患者基本信息主键ID") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Encounter_RefuseReason_FReason_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Encounter_RefuseReason_FReason_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Encounter_RefuseReason_FReason_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Encounter_RefuseReason_FApproveDate_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Encounter_RefuseReason_FApproveDate_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Encounter_RefuseReason_FApproveDate_Title) ;
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
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A348BR_Encounter_RefuseReasonID), 18, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A19BR_EncounterID), 18, 0, ".", "")));
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
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A352BR_Encounter_RefuseReason_Approver);
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.BoolToStr( A353BR_EncounterReason_IsApprove));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A85BR_Information_ID), 18, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A355BR_Encounter_RefuseReason_FReason);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Encounter_RefuseReason_FReason_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Encounter_RefuseReason_FReason_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.localUtil.TToC( A354BR_Encounter_RefuseReason_FApproveDate, 10, 8, 0, 0, "/", ":", " "));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Encounter_RefuseReason_FApproveDate_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Encounter_RefuseReason_FApproveDate_Titleformat), 4, 0, ".", "")));
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
         if ( wbEnd == 17 )
         {
            wbEnd = 0;
            nRC_GXsfl_17 = (short)(nGXsfl_17_idx-1);
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
            ucGridpaginationbar.SetProperty("CurrentPage", AV17GridCurrentPage);
            ucGridpaginationbar.SetProperty("RecordCount", AV19GridRecordCount);
            ucGridpaginationbar.SetProperty("Page", AV18GridPageSize);
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
            ucDdo_br_encounter_refusereason_reason.SetProperty("DropDownOptionsTitleSettingsIcons", AV43DDO_TitleSettingsIcons);
            ucDdo_br_encounter_refusereason_reason.SetProperty("DropDownOptionsData", AV33BR_Encounter_RefuseReason_ReasonTitleFilterData);
            ucDdo_br_encounter_refusereason_reason.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_encounter_refusereason_reason_Internalname, "DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 36,'',false,'" + sGXsfl_17_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_encounter_refusereason_reasontitlecontrolidtoreplace_Internalname, AV36ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,36);\"", 0, edtavDdo_br_encounter_refusereason_reasontitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_EnteringSubmitDetail.htm");
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
            ucDdo_br_encounter_refusereason_noapprovedate.SetProperty("DropDownOptionsTitleSettingsIcons", AV43DDO_TitleSettingsIcons);
            ucDdo_br_encounter_refusereason_noapprovedate.SetProperty("DropDownOptionsData", AV37BR_Encounter_RefuseReason_NoApproveDateTitleFilterData);
            ucDdo_br_encounter_refusereason_noapprovedate.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_encounter_refusereason_noapprovedate_Internalname, "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'" + sGXsfl_17_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_encounter_refusereason_noapprovedatetitlecontrolidtoreplace_Internalname, AV42ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,38);\"", 0, edtavDdo_br_encounter_refusereason_noapprovedatetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_EnteringSubmitDetail.htm");
            /* User Defined Control */
            ucDdo_br_encounter_refusereason_freason.SetProperty("Caption", Ddo_br_encounter_refusereason_freason_Caption);
            ucDdo_br_encounter_refusereason_freason.SetProperty("Tooltip", Ddo_br_encounter_refusereason_freason_Tooltip);
            ucDdo_br_encounter_refusereason_freason.SetProperty("Cls", Ddo_br_encounter_refusereason_freason_Cls);
            ucDdo_br_encounter_refusereason_freason.SetProperty("DropDownOptionsType", Ddo_br_encounter_refusereason_freason_Dropdownoptionstype);
            ucDdo_br_encounter_refusereason_freason.SetProperty("IncludeSortASC", Ddo_br_encounter_refusereason_freason_Includesortasc);
            ucDdo_br_encounter_refusereason_freason.SetProperty("IncludeSortDSC", Ddo_br_encounter_refusereason_freason_Includesortdsc);
            ucDdo_br_encounter_refusereason_freason.SetProperty("IncludeFilter", Ddo_br_encounter_refusereason_freason_Includefilter);
            ucDdo_br_encounter_refusereason_freason.SetProperty("FilterType", Ddo_br_encounter_refusereason_freason_Filtertype);
            ucDdo_br_encounter_refusereason_freason.SetProperty("FilterIsRange", Ddo_br_encounter_refusereason_freason_Filterisrange);
            ucDdo_br_encounter_refusereason_freason.SetProperty("IncludeDataList", Ddo_br_encounter_refusereason_freason_Includedatalist);
            ucDdo_br_encounter_refusereason_freason.SetProperty("DataListType", Ddo_br_encounter_refusereason_freason_Datalisttype);
            ucDdo_br_encounter_refusereason_freason.SetProperty("DataListProc", Ddo_br_encounter_refusereason_freason_Datalistproc);
            ucDdo_br_encounter_refusereason_freason.SetProperty("DataListUpdateMinimumCharacters", Ddo_br_encounter_refusereason_freason_Datalistupdateminimumcharacters);
            ucDdo_br_encounter_refusereason_freason.SetProperty("SortASC", Ddo_br_encounter_refusereason_freason_Sortasc);
            ucDdo_br_encounter_refusereason_freason.SetProperty("SortDSC", Ddo_br_encounter_refusereason_freason_Sortdsc);
            ucDdo_br_encounter_refusereason_freason.SetProperty("LoadingData", Ddo_br_encounter_refusereason_freason_Loadingdata);
            ucDdo_br_encounter_refusereason_freason.SetProperty("CleanFilter", Ddo_br_encounter_refusereason_freason_Cleanfilter);
            ucDdo_br_encounter_refusereason_freason.SetProperty("NoResultsFound", Ddo_br_encounter_refusereason_freason_Noresultsfound);
            ucDdo_br_encounter_refusereason_freason.SetProperty("SearchButtonText", Ddo_br_encounter_refusereason_freason_Searchbuttontext);
            ucDdo_br_encounter_refusereason_freason.SetProperty("DropDownOptionsTitleSettingsIcons", AV43DDO_TitleSettingsIcons);
            ucDdo_br_encounter_refusereason_freason.SetProperty("DropDownOptionsData", AV49BR_Encounter_RefuseReason_FReasonTitleFilterData);
            ucDdo_br_encounter_refusereason_freason.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_encounter_refusereason_freason_Internalname, "DDO_BR_ENCOUNTER_REFUSEREASON_FREASONContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 40,'',false,'" + sGXsfl_17_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_encounter_refusereason_freasontitlecontrolidtoreplace_Internalname, AV52ddo_BR_Encounter_RefuseReason_FReasonTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,40);\"", 0, edtavDdo_br_encounter_refusereason_freasontitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_EnteringSubmitDetail.htm");
            /* User Defined Control */
            ucDdo_br_encounter_refusereason_fapprovedate.SetProperty("Caption", Ddo_br_encounter_refusereason_fapprovedate_Caption);
            ucDdo_br_encounter_refusereason_fapprovedate.SetProperty("Tooltip", Ddo_br_encounter_refusereason_fapprovedate_Tooltip);
            ucDdo_br_encounter_refusereason_fapprovedate.SetProperty("Cls", Ddo_br_encounter_refusereason_fapprovedate_Cls);
            ucDdo_br_encounter_refusereason_fapprovedate.SetProperty("DropDownOptionsType", Ddo_br_encounter_refusereason_fapprovedate_Dropdownoptionstype);
            ucDdo_br_encounter_refusereason_fapprovedate.SetProperty("IncludeSortASC", Ddo_br_encounter_refusereason_fapprovedate_Includesortasc);
            ucDdo_br_encounter_refusereason_fapprovedate.SetProperty("IncludeSortDSC", Ddo_br_encounter_refusereason_fapprovedate_Includesortdsc);
            ucDdo_br_encounter_refusereason_fapprovedate.SetProperty("IncludeFilter", Ddo_br_encounter_refusereason_fapprovedate_Includefilter);
            ucDdo_br_encounter_refusereason_fapprovedate.SetProperty("FilterType", Ddo_br_encounter_refusereason_fapprovedate_Filtertype);
            ucDdo_br_encounter_refusereason_fapprovedate.SetProperty("FilterIsRange", Ddo_br_encounter_refusereason_fapprovedate_Filterisrange);
            ucDdo_br_encounter_refusereason_fapprovedate.SetProperty("IncludeDataList", Ddo_br_encounter_refusereason_fapprovedate_Includedatalist);
            ucDdo_br_encounter_refusereason_fapprovedate.SetProperty("SortASC", Ddo_br_encounter_refusereason_fapprovedate_Sortasc);
            ucDdo_br_encounter_refusereason_fapprovedate.SetProperty("SortDSC", Ddo_br_encounter_refusereason_fapprovedate_Sortdsc);
            ucDdo_br_encounter_refusereason_fapprovedate.SetProperty("CleanFilter", Ddo_br_encounter_refusereason_fapprovedate_Cleanfilter);
            ucDdo_br_encounter_refusereason_fapprovedate.SetProperty("RangeFilterFrom", Ddo_br_encounter_refusereason_fapprovedate_Rangefilterfrom);
            ucDdo_br_encounter_refusereason_fapprovedate.SetProperty("RangeFilterTo", Ddo_br_encounter_refusereason_fapprovedate_Rangefilterto);
            ucDdo_br_encounter_refusereason_fapprovedate.SetProperty("SearchButtonText", Ddo_br_encounter_refusereason_fapprovedate_Searchbuttontext);
            ucDdo_br_encounter_refusereason_fapprovedate.SetProperty("DropDownOptionsTitleSettingsIcons", AV43DDO_TitleSettingsIcons);
            ucDdo_br_encounter_refusereason_fapprovedate.SetProperty("DropDownOptionsData", AV53BR_Encounter_RefuseReason_FApproveDateTitleFilterData);
            ucDdo_br_encounter_refusereason_fapprovedate.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_encounter_refusereason_fapprovedate_Internalname, "DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 42,'',false,'" + sGXsfl_17_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_encounter_refusereason_fapprovedatetitlecontrolidtoreplace_Internalname, AV58ddo_BR_Encounter_RefuseReason_FApproveDateTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,42);\"", 0, edtavDdo_br_encounter_refusereason_fapprovedatetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_EnteringSubmitDetail.htm");
            /* User Defined Control */
            ucWorkwithplusutilities1.Render(context, "dvelop.workwithplusutilities", Workwithplusutilities1_Internalname, "WORKWITHPLUSUTILITIES1Container");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'" + sGXsfl_17_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrderedby_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV26OrderedBy), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV26OrderedBy), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,44);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrderedby_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrderedby_Visible, 1, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_EnteringSubmitDetail.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 45,'',false,'" + sGXsfl_17_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrdereddsc_Internalname, StringUtil.BoolToStr( AV27OrderedDsc), StringUtil.BoolToStr( AV27OrderedDsc), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,45);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrdereddsc_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrdereddsc_Visible, 1, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, 0, 0, true, "", "right", false, "HLP_BR_EnteringSubmitDetail.htm");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'" + sGXsfl_17_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavTfbr_encounter_refusereason_reason_Internalname, AV34TFBR_Encounter_RefuseReason_Reason, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,46);\"", 0, edtavTfbr_encounter_refusereason_reason_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_EnteringSubmitDetail.htm");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 47,'',false,'" + sGXsfl_17_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavTfbr_encounter_refusereason_reason_sel_Internalname, AV35TFBR_Encounter_RefuseReason_Reason_Sel, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,47);\"", 0, edtavTfbr_encounter_refusereason_reason_sel_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_EnteringSubmitDetail.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'" + sGXsfl_17_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavTfbr_encounter_refusereason_noapprovedate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavTfbr_encounter_refusereason_noapprovedate_Internalname, context.localUtil.TToC( AV38TFBR_Encounter_RefuseReason_NoApproveDate, 10, 8, 0, 0, "/", ":", " "), context.localUtil.Format( AV38TFBR_Encounter_RefuseReason_NoApproveDate, "9999/99/99 99:99:99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',8,24,'chs',false,1);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,48);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_encounter_refusereason_noapprovedate_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_encounter_refusereason_noapprovedate_Visible, 1, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_EnteringSubmitDetail.htm");
            GxWebStd.gx_bitmap( context, edtavTfbr_encounter_refusereason_noapprovedate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((edtavTfbr_encounter_refusereason_noapprovedate_Visible==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_EnteringSubmitDetail.htm");
            context.WriteHtmlTextNl( "</div>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 49,'',false,'" + sGXsfl_17_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavTfbr_encounter_refusereason_noapprovedate_to_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavTfbr_encounter_refusereason_noapprovedate_to_Internalname, context.localUtil.TToC( AV39TFBR_Encounter_RefuseReason_NoApproveDate_To, 10, 8, 0, 0, "/", ":", " "), context.localUtil.Format( AV39TFBR_Encounter_RefuseReason_NoApproveDate_To, "9999/99/99 99:99:99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',8,24,'chs',false,1);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,49);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_encounter_refusereason_noapprovedate_to_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_encounter_refusereason_noapprovedate_to_Visible, 1, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_EnteringSubmitDetail.htm");
            GxWebStd.gx_bitmap( context, edtavTfbr_encounter_refusereason_noapprovedate_to_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((edtavTfbr_encounter_refusereason_noapprovedate_to_Visible==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_EnteringSubmitDetail.htm");
            context.WriteHtmlTextNl( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divDdo_br_encounter_refusereason_noapprovedateauxdates_Internalname, 1, 0, "px", 0, "px", "Invisible", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 51,'',false,'" + sGXsfl_17_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavDdo_br_encounter_refusereason_noapprovedateauxdate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavDdo_br_encounter_refusereason_noapprovedateauxdate_Internalname, context.localUtil.Format(AV40DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDate, "9999/99/99"), context.localUtil.Format( AV40DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDate, "9999/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',0,24,'chs',false,1);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,51);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavDdo_br_encounter_refusereason_noapprovedateauxdate_Jsonclick, 0, "Attribute", "", "", "", "", 1, 1, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_EnteringSubmitDetail.htm");
            GxWebStd.gx_bitmap( context, edtavDdo_br_encounter_refusereason_noapprovedateauxdate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_EnteringSubmitDetail.htm");
            context.WriteHtmlTextNl( "</div>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 52,'',false,'" + sGXsfl_17_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavDdo_br_encounter_refusereason_noapprovedateauxdateto_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavDdo_br_encounter_refusereason_noapprovedateauxdateto_Internalname, context.localUtil.Format(AV41DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDateTo, "9999/99/99"), context.localUtil.Format( AV41DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDateTo, "9999/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',0,24,'chs',false,1);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,52);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavDdo_br_encounter_refusereason_noapprovedateauxdateto_Jsonclick, 0, "Attribute", "", "", "", "", 1, 1, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_EnteringSubmitDetail.htm");
            GxWebStd.gx_bitmap( context, edtavDdo_br_encounter_refusereason_noapprovedateauxdateto_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_EnteringSubmitDetail.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'" + sGXsfl_17_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavTfbr_encounter_refusereason_freason_Internalname, AV50TFBR_Encounter_RefuseReason_FReason, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,53);\"", 0, edtavTfbr_encounter_refusereason_freason_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_EnteringSubmitDetail.htm");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'',false,'" + sGXsfl_17_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavTfbr_encounter_refusereason_freason_sel_Internalname, AV51TFBR_Encounter_RefuseReason_FReason_Sel, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,54);\"", 0, edtavTfbr_encounter_refusereason_freason_sel_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_EnteringSubmitDetail.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 55,'',false,'" + sGXsfl_17_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavTfbr_encounter_refusereason_fapprovedate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavTfbr_encounter_refusereason_fapprovedate_Internalname, context.localUtil.TToC( AV54TFBR_Encounter_RefuseReason_FApproveDate, 10, 8, 0, 0, "/", ":", " "), context.localUtil.Format( AV54TFBR_Encounter_RefuseReason_FApproveDate, "9999/99/99 99:99:99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',8,24,'chs',false,1);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,55);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_encounter_refusereason_fapprovedate_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_encounter_refusereason_fapprovedate_Visible, 1, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_EnteringSubmitDetail.htm");
            GxWebStd.gx_bitmap( context, edtavTfbr_encounter_refusereason_fapprovedate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((edtavTfbr_encounter_refusereason_fapprovedate_Visible==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_EnteringSubmitDetail.htm");
            context.WriteHtmlTextNl( "</div>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 56,'',false,'" + sGXsfl_17_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavTfbr_encounter_refusereason_fapprovedate_to_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavTfbr_encounter_refusereason_fapprovedate_to_Internalname, context.localUtil.TToC( AV55TFBR_Encounter_RefuseReason_FApproveDate_To, 10, 8, 0, 0, "/", ":", " "), context.localUtil.Format( AV55TFBR_Encounter_RefuseReason_FApproveDate_To, "9999/99/99 99:99:99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',8,24,'chs',false,1);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,56);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_encounter_refusereason_fapprovedate_to_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_encounter_refusereason_fapprovedate_to_Visible, 1, 0, "text", "", 19, "chr", 1, "row", 19, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_EnteringSubmitDetail.htm");
            GxWebStd.gx_bitmap( context, edtavTfbr_encounter_refusereason_fapprovedate_to_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((edtavTfbr_encounter_refusereason_fapprovedate_to_Visible==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_EnteringSubmitDetail.htm");
            context.WriteHtmlTextNl( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divDdo_br_encounter_refusereason_fapprovedateauxdates_Internalname, 1, 0, "px", 0, "px", "Invisible", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'" + sGXsfl_17_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavDdo_br_encounter_refusereason_fapprovedateauxdate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavDdo_br_encounter_refusereason_fapprovedateauxdate_Internalname, context.localUtil.Format(AV56DDO_BR_Encounter_RefuseReason_FApproveDateAuxDate, "9999/99/99"), context.localUtil.Format( AV56DDO_BR_Encounter_RefuseReason_FApproveDateAuxDate, "9999/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',0,24,'chs',false,1);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,58);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavDdo_br_encounter_refusereason_fapprovedateauxdate_Jsonclick, 0, "Attribute", "", "", "", "", 1, 1, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_EnteringSubmitDetail.htm");
            GxWebStd.gx_bitmap( context, edtavDdo_br_encounter_refusereason_fapprovedateauxdate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_EnteringSubmitDetail.htm");
            context.WriteHtmlTextNl( "</div>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 59,'',false,'" + sGXsfl_17_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavDdo_br_encounter_refusereason_fapprovedateauxdateto_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavDdo_br_encounter_refusereason_fapprovedateauxdateto_Internalname, context.localUtil.Format(AV57DDO_BR_Encounter_RefuseReason_FApproveDateAuxDateTo, "9999/99/99"), context.localUtil.Format( AV57DDO_BR_Encounter_RefuseReason_FApproveDateAuxDateTo, "9999/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',0,24,'chs',false,1);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,59);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavDdo_br_encounter_refusereason_fapprovedateauxdateto_Jsonclick, 0, "Attribute", "", "", "", "", 1, 1, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_EnteringSubmitDetail.htm");
            GxWebStd.gx_bitmap( context, edtavDdo_br_encounter_refusereason_fapprovedateauxdateto_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_EnteringSubmitDetail.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         if ( wbEnd == 17 )
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

      protected void START7D2( )
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
         STRUP7D0( ) ;
      }

      protected void WS7D2( )
      {
         START7D2( ) ;
         EVT7D2( ) ;
      }

      protected void EVT7D2( )
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
                              E117D2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEROWSPERPAGE") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E127D2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_ENCOUNTER_REFUSEREASON_REASON.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E137D2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E147D2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_ENCOUNTER_REFUSEREASON_FREASON.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E157D2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E167D2 ();
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
                              nGXsfl_17_idx = (short)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_17_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_17_idx), 4, 0)), 4, "0");
                              SubsflControlProps_172( ) ;
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
                              A352BR_Encounter_RefuseReason_Approver = cgiGet( edtBR_Encounter_RefuseReason_Approver_Internalname);
                              n352BR_Encounter_RefuseReason_Approver = false;
                              A353BR_EncounterReason_IsApprove = StringUtil.StrToBool( cgiGet( chkBR_EncounterReason_IsApprove_Internalname));
                              n353BR_EncounterReason_IsApprove = false;
                              A85BR_Information_ID = (long)(context.localUtil.CToN( cgiGet( edtBR_Information_ID_Internalname), ".", ","));
                              n85BR_Information_ID = false;
                              A355BR_Encounter_RefuseReason_FReason = cgiGet( edtBR_Encounter_RefuseReason_FReason_Internalname);
                              n355BR_Encounter_RefuseReason_FReason = false;
                              A354BR_Encounter_RefuseReason_FApproveDate = context.localUtil.CToT( cgiGet( edtBR_Encounter_RefuseReason_FApproveDate_Internalname), 0);
                              n354BR_Encounter_RefuseReason_FApproveDate = false;
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E177D2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Refresh */
                                    E187D2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "GRID.LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    E197D2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false;
                                       /* Set Refresh If Br_encounterreason_vstatus Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vBR_ENCOUNTERREASON_VSTATUS"), ".", ",") != Convert.ToDecimal( AV48BR_EncounterReason_vStatus )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Orderedby Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vORDEREDBY"), ".", ",") != Convert.ToDecimal( AV26OrderedBy )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Ordereddsc Changed */
                                       if ( StringUtil.StrToBool( cgiGet( "GXH_vORDEREDDSC")) != AV27OrderedDsc )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_encounter_refusereason_reason Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_ENCOUNTER_REFUSEREASON_REASON"), AV34TFBR_Encounter_RefuseReason_Reason) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_encounter_refusereason_reason_sel Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_ENCOUNTER_REFUSEREASON_REASON_SEL"), AV35TFBR_Encounter_RefuseReason_Reason_Sel) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_encounter_refusereason_noapprovedate Changed */
                                       if ( context.localUtil.CToT( cgiGet( "GXH_vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE"), 0) != AV38TFBR_Encounter_RefuseReason_NoApproveDate )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_encounter_refusereason_noapprovedate_to Changed */
                                       if ( context.localUtil.CToT( cgiGet( "GXH_vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_TO"), 0) != AV39TFBR_Encounter_RefuseReason_NoApproveDate_To )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_encounter_refusereason_freason Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_ENCOUNTER_REFUSEREASON_FREASON"), AV50TFBR_Encounter_RefuseReason_FReason) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_encounter_refusereason_freason_sel Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_ENCOUNTER_REFUSEREASON_FREASON_SEL"), AV51TFBR_Encounter_RefuseReason_FReason_Sel) != 0 )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_encounter_refusereason_fapprovedate Changed */
                                       if ( context.localUtil.CToT( cgiGet( "GXH_vTFBR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE"), 0) != AV54TFBR_Encounter_RefuseReason_FApproveDate )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_encounter_refusereason_fapprovedate_to Changed */
                                       if ( context.localUtil.CToT( cgiGet( "GXH_vTFBR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE_TO"), 0) != AV55TFBR_Encounter_RefuseReason_FApproveDate_To )
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

      protected void WE7D2( )
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

      protected void PA7D2( )
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
               GX_FocusControl = cmbavBr_encounterreason_vstatus_Internalname;
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
         SubsflControlProps_172( ) ;
         while ( nGXsfl_17_idx <= nRC_GXsfl_17 )
         {
            sendrow_172( ) ;
            nGXsfl_17_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_17_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_17_idx+1));
            sGXsfl_17_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_17_idx), 4, 0)), 4, "0");
            SubsflControlProps_172( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( GridContainer));
         /* End function gxnrGrid_newrow */
      }

      protected void gxgrGrid_refresh( int subGrid_Rows ,
                                       short AV48BR_EncounterReason_vStatus ,
                                       short AV26OrderedBy ,
                                       bool AV27OrderedDsc ,
                                       String AV34TFBR_Encounter_RefuseReason_Reason ,
                                       String AV35TFBR_Encounter_RefuseReason_Reason_Sel ,
                                       DateTime AV38TFBR_Encounter_RefuseReason_NoApproveDate ,
                                       DateTime AV39TFBR_Encounter_RefuseReason_NoApproveDate_To ,
                                       String AV50TFBR_Encounter_RefuseReason_FReason ,
                                       String AV51TFBR_Encounter_RefuseReason_FReason_Sel ,
                                       DateTime AV54TFBR_Encounter_RefuseReason_FApproveDate ,
                                       DateTime AV55TFBR_Encounter_RefuseReason_FApproveDate_To ,
                                       long AV13BR_EncounterID ,
                                       String AV36ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace ,
                                       String AV42ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace ,
                                       String AV52ddo_BR_Encounter_RefuseReason_FReasonTitleControlIdToReplace ,
                                       String AV58ddo_BR_Encounter_RefuseReason_FApproveDateTitleControlIdToReplace ,
                                       String AV70Pgmname ,
                                       bool AV20IsAuthorized_BR_Encounter_RefuseReason_Reason )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GRID_nCurrentRecord = 0;
         RF7D2( ) ;
         /* End function gxgrGrid_refresh */
      }

      protected void send_integrity_hashes( )
      {
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
         if ( cmbavBr_encounterreason_vstatus.ItemCount > 0 )
         {
            AV48BR_EncounterReason_vStatus = (short)(NumberUtil.Val( cmbavBr_encounterreason_vstatus.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV48BR_EncounterReason_vStatus), 4, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV48BR_EncounterReason_vStatus", StringUtil.LTrim( StringUtil.Str( (decimal)(AV48BR_EncounterReason_vStatus), 4, 0)));
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavBr_encounterreason_vstatus.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV48BR_EncounterReason_vStatus), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavBr_encounterreason_vstatus_Internalname, "Values", cmbavBr_encounterreason_vstatus.ToJavascriptSource(), true);
         }
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF7D2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV70Pgmname = "BR_EnteringSubmitDetail";
         context.Gx_err = 0;
      }

      protected void RF7D2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridContainer.ClearRows();
         }
         wbStart = 17;
         /* Execute user event: Refresh */
         E187D2 ();
         nGXsfl_17_idx = 1;
         sGXsfl_17_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_17_idx), 4, 0)), 4, "0");
         SubsflControlProps_172( ) ;
         bGXsfl_17_Refreshing = true;
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
            SubsflControlProps_172( ) ;
            GXPagingFrom2 = (int)(((subGrid_Rows==0) ? 0 : GRID_nFirstRecordOnPage));
            GXPagingTo2 = ((subGrid_Rows==0) ? 10000 : subGrid_Recordsperpage( )+1);
            pr_default.dynParam(0, new Object[]{ new Object[]{
                                                 AV61BR_EnteringSubmitDetailDS_1_Br_encounterreason_vstatus ,
                                                 AV63BR_EnteringSubmitDetailDS_3_Tfbr_encounter_refusereason_reason_sel ,
                                                 AV62BR_EnteringSubmitDetailDS_2_Tfbr_encounter_refusereason_reason ,
                                                 AV64BR_EnteringSubmitDetailDS_4_Tfbr_encounter_refusereason_noapprovedate ,
                                                 AV65BR_EnteringSubmitDetailDS_5_Tfbr_encounter_refusereason_noapprovedate_to ,
                                                 AV67BR_EnteringSubmitDetailDS_7_Tfbr_encounter_refusereason_freason_sel ,
                                                 AV66BR_EnteringSubmitDetailDS_6_Tfbr_encounter_refusereason_freason ,
                                                 AV68BR_EnteringSubmitDetailDS_8_Tfbr_encounter_refusereason_fapprovedate ,
                                                 AV69BR_EnteringSubmitDetailDS_9_Tfbr_encounter_refusereason_fapprovedate_to ,
                                                 A356BR_EncounterReason_vStatus ,
                                                 A349BR_Encounter_RefuseReason_Reason ,
                                                 A350BR_Encounter_RefuseReason_NoApproveDate ,
                                                 A355BR_Encounter_RefuseReason_FReason ,
                                                 A354BR_Encounter_RefuseReason_FApproveDate ,
                                                 AV26OrderedBy ,
                                                 AV27OrderedDsc ,
                                                 A19BR_EncounterID ,
                                                 AV13BR_EncounterID } ,
                                                 new int[]{
                                                 TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.SHORT,
                                                 TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DATE, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DATE, TypeConstants.BOOLEAN, TypeConstants.SHORT,
                                                 TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.LONG
                                                 }
            } ) ;
            lV62BR_EnteringSubmitDetailDS_2_Tfbr_encounter_refusereason_reason = StringUtil.Concat( StringUtil.RTrim( AV62BR_EnteringSubmitDetailDS_2_Tfbr_encounter_refusereason_reason), "%", "");
            lV66BR_EnteringSubmitDetailDS_6_Tfbr_encounter_refusereason_freason = StringUtil.Concat( StringUtil.RTrim( AV66BR_EnteringSubmitDetailDS_6_Tfbr_encounter_refusereason_freason), "%", "");
            /* Using cursor H007D2 */
            pr_default.execute(0, new Object[] {AV13BR_EncounterID, AV61BR_EnteringSubmitDetailDS_1_Br_encounterreason_vstatus, lV62BR_EnteringSubmitDetailDS_2_Tfbr_encounter_refusereason_reason, AV63BR_EnteringSubmitDetailDS_3_Tfbr_encounter_refusereason_reason_sel, AV64BR_EnteringSubmitDetailDS_4_Tfbr_encounter_refusereason_noapprovedate, AV65BR_EnteringSubmitDetailDS_5_Tfbr_encounter_refusereason_noapprovedate_to, lV66BR_EnteringSubmitDetailDS_6_Tfbr_encounter_refusereason_freason, AV67BR_EnteringSubmitDetailDS_7_Tfbr_encounter_refusereason_freason_sel, AV68BR_EnteringSubmitDetailDS_8_Tfbr_encounter_refusereason_fapprovedate, AV69BR_EnteringSubmitDetailDS_9_Tfbr_encounter_refusereason_fapprovedate_to, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_17_idx = 1;
            sGXsfl_17_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_17_idx), 4, 0)), 4, "0");
            SubsflControlProps_172( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < subGrid_Recordsperpage( ) ) ) ) )
            {
               A356BR_EncounterReason_vStatus = H007D2_A356BR_EncounterReason_vStatus[0];
               n356BR_EncounterReason_vStatus = H007D2_n356BR_EncounterReason_vStatus[0];
               A354BR_Encounter_RefuseReason_FApproveDate = H007D2_A354BR_Encounter_RefuseReason_FApproveDate[0];
               n354BR_Encounter_RefuseReason_FApproveDate = H007D2_n354BR_Encounter_RefuseReason_FApproveDate[0];
               A355BR_Encounter_RefuseReason_FReason = H007D2_A355BR_Encounter_RefuseReason_FReason[0];
               n355BR_Encounter_RefuseReason_FReason = H007D2_n355BR_Encounter_RefuseReason_FReason[0];
               A85BR_Information_ID = H007D2_A85BR_Information_ID[0];
               n85BR_Information_ID = H007D2_n85BR_Information_ID[0];
               A353BR_EncounterReason_IsApprove = H007D2_A353BR_EncounterReason_IsApprove[0];
               n353BR_EncounterReason_IsApprove = H007D2_n353BR_EncounterReason_IsApprove[0];
               A352BR_Encounter_RefuseReason_Approver = H007D2_A352BR_Encounter_RefuseReason_Approver[0];
               n352BR_Encounter_RefuseReason_Approver = H007D2_n352BR_Encounter_RefuseReason_Approver[0];
               A351BR_Encounter_RefuseReason_Status = H007D2_A351BR_Encounter_RefuseReason_Status[0];
               n351BR_Encounter_RefuseReason_Status = H007D2_n351BR_Encounter_RefuseReason_Status[0];
               A350BR_Encounter_RefuseReason_NoApproveDate = H007D2_A350BR_Encounter_RefuseReason_NoApproveDate[0];
               n350BR_Encounter_RefuseReason_NoApproveDate = H007D2_n350BR_Encounter_RefuseReason_NoApproveDate[0];
               A349BR_Encounter_RefuseReason_Reason = H007D2_A349BR_Encounter_RefuseReason_Reason[0];
               n349BR_Encounter_RefuseReason_Reason = H007D2_n349BR_Encounter_RefuseReason_Reason[0];
               A19BR_EncounterID = H007D2_A19BR_EncounterID[0];
               A348BR_Encounter_RefuseReasonID = H007D2_A348BR_Encounter_RefuseReasonID[0];
               A85BR_Information_ID = H007D2_A85BR_Information_ID[0];
               n85BR_Information_ID = H007D2_n85BR_Information_ID[0];
               E197D2 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 17;
            WB7D0( ) ;
         }
         bGXsfl_17_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes7D2( )
      {
         GxWebStd.gx_boolean_hidden_field( context, "vISAUTHORIZED_BR_ENCOUNTER_REFUSEREASON_REASON", AV20IsAuthorized_BR_Encounter_RefuseReason_Reason);
         GxWebStd.gx_hidden_field( context, "gxhash_vISAUTHORIZED_BR_ENCOUNTER_REFUSEREASON_REASON", GetSecureSignedToken( "", AV20IsAuthorized_BR_Encounter_RefuseReason_Reason, context));
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
         AV61BR_EnteringSubmitDetailDS_1_Br_encounterreason_vstatus = AV48BR_EncounterReason_vStatus;
         AV62BR_EnteringSubmitDetailDS_2_Tfbr_encounter_refusereason_reason = AV34TFBR_Encounter_RefuseReason_Reason;
         AV63BR_EnteringSubmitDetailDS_3_Tfbr_encounter_refusereason_reason_sel = AV35TFBR_Encounter_RefuseReason_Reason_Sel;
         AV64BR_EnteringSubmitDetailDS_4_Tfbr_encounter_refusereason_noapprovedate = AV38TFBR_Encounter_RefuseReason_NoApproveDate;
         AV65BR_EnteringSubmitDetailDS_5_Tfbr_encounter_refusereason_noapprovedate_to = AV39TFBR_Encounter_RefuseReason_NoApproveDate_To;
         AV66BR_EnteringSubmitDetailDS_6_Tfbr_encounter_refusereason_freason = AV50TFBR_Encounter_RefuseReason_FReason;
         AV67BR_EnteringSubmitDetailDS_7_Tfbr_encounter_refusereason_freason_sel = AV51TFBR_Encounter_RefuseReason_FReason_Sel;
         AV68BR_EnteringSubmitDetailDS_8_Tfbr_encounter_refusereason_fapprovedate = AV54TFBR_Encounter_RefuseReason_FApproveDate;
         AV69BR_EnteringSubmitDetailDS_9_Tfbr_encounter_refusereason_fapprovedate_to = AV55TFBR_Encounter_RefuseReason_FApproveDate_To;
         pr_default.dynParam(1, new Object[]{ new Object[]{
                                              AV61BR_EnteringSubmitDetailDS_1_Br_encounterreason_vstatus ,
                                              AV63BR_EnteringSubmitDetailDS_3_Tfbr_encounter_refusereason_reason_sel ,
                                              AV62BR_EnteringSubmitDetailDS_2_Tfbr_encounter_refusereason_reason ,
                                              AV64BR_EnteringSubmitDetailDS_4_Tfbr_encounter_refusereason_noapprovedate ,
                                              AV65BR_EnteringSubmitDetailDS_5_Tfbr_encounter_refusereason_noapprovedate_to ,
                                              AV67BR_EnteringSubmitDetailDS_7_Tfbr_encounter_refusereason_freason_sel ,
                                              AV66BR_EnteringSubmitDetailDS_6_Tfbr_encounter_refusereason_freason ,
                                              AV68BR_EnteringSubmitDetailDS_8_Tfbr_encounter_refusereason_fapprovedate ,
                                              AV69BR_EnteringSubmitDetailDS_9_Tfbr_encounter_refusereason_fapprovedate_to ,
                                              A356BR_EncounterReason_vStatus ,
                                              A349BR_Encounter_RefuseReason_Reason ,
                                              A350BR_Encounter_RefuseReason_NoApproveDate ,
                                              A355BR_Encounter_RefuseReason_FReason ,
                                              A354BR_Encounter_RefuseReason_FApproveDate ,
                                              AV26OrderedBy ,
                                              AV27OrderedDsc ,
                                              A19BR_EncounterID ,
                                              AV13BR_EncounterID } ,
                                              new int[]{
                                              TypeConstants.SHORT, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.STRING, TypeConstants.STRING, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.SHORT,
                                              TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DATE, TypeConstants.BOOLEAN, TypeConstants.STRING, TypeConstants.BOOLEAN, TypeConstants.DATE, TypeConstants.BOOLEAN, TypeConstants.SHORT,
                                              TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.LONG
                                              }
         } ) ;
         lV62BR_EnteringSubmitDetailDS_2_Tfbr_encounter_refusereason_reason = StringUtil.Concat( StringUtil.RTrim( AV62BR_EnteringSubmitDetailDS_2_Tfbr_encounter_refusereason_reason), "%", "");
         lV66BR_EnteringSubmitDetailDS_6_Tfbr_encounter_refusereason_freason = StringUtil.Concat( StringUtil.RTrim( AV66BR_EnteringSubmitDetailDS_6_Tfbr_encounter_refusereason_freason), "%", "");
         /* Using cursor H007D3 */
         pr_default.execute(1, new Object[] {AV13BR_EncounterID, AV61BR_EnteringSubmitDetailDS_1_Br_encounterreason_vstatus, lV62BR_EnteringSubmitDetailDS_2_Tfbr_encounter_refusereason_reason, AV63BR_EnteringSubmitDetailDS_3_Tfbr_encounter_refusereason_reason_sel, AV64BR_EnteringSubmitDetailDS_4_Tfbr_encounter_refusereason_noapprovedate, AV65BR_EnteringSubmitDetailDS_5_Tfbr_encounter_refusereason_noapprovedate_to, lV66BR_EnteringSubmitDetailDS_6_Tfbr_encounter_refusereason_freason, AV67BR_EnteringSubmitDetailDS_7_Tfbr_encounter_refusereason_freason_sel, AV68BR_EnteringSubmitDetailDS_8_Tfbr_encounter_refusereason_fapprovedate, AV69BR_EnteringSubmitDetailDS_9_Tfbr_encounter_refusereason_fapprovedate_to});
         GRID_nRecordCount = H007D3_AGRID_nRecordCount[0];
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
         AV61BR_EnteringSubmitDetailDS_1_Br_encounterreason_vstatus = AV48BR_EncounterReason_vStatus;
         AV62BR_EnteringSubmitDetailDS_2_Tfbr_encounter_refusereason_reason = AV34TFBR_Encounter_RefuseReason_Reason;
         AV63BR_EnteringSubmitDetailDS_3_Tfbr_encounter_refusereason_reason_sel = AV35TFBR_Encounter_RefuseReason_Reason_Sel;
         AV64BR_EnteringSubmitDetailDS_4_Tfbr_encounter_refusereason_noapprovedate = AV38TFBR_Encounter_RefuseReason_NoApproveDate;
         AV65BR_EnteringSubmitDetailDS_5_Tfbr_encounter_refusereason_noapprovedate_to = AV39TFBR_Encounter_RefuseReason_NoApproveDate_To;
         AV66BR_EnteringSubmitDetailDS_6_Tfbr_encounter_refusereason_freason = AV50TFBR_Encounter_RefuseReason_FReason;
         AV67BR_EnteringSubmitDetailDS_7_Tfbr_encounter_refusereason_freason_sel = AV51TFBR_Encounter_RefuseReason_FReason_Sel;
         AV68BR_EnteringSubmitDetailDS_8_Tfbr_encounter_refusereason_fapprovedate = AV54TFBR_Encounter_RefuseReason_FApproveDate;
         AV69BR_EnteringSubmitDetailDS_9_Tfbr_encounter_refusereason_fapprovedate_to = AV55TFBR_Encounter_RefuseReason_FApproveDate_To;
         GRID_nFirstRecordOnPage = 0;
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV48BR_EncounterReason_vStatus, AV26OrderedBy, AV27OrderedDsc, AV34TFBR_Encounter_RefuseReason_Reason, AV35TFBR_Encounter_RefuseReason_Reason_Sel, AV38TFBR_Encounter_RefuseReason_NoApproveDate, AV39TFBR_Encounter_RefuseReason_NoApproveDate_To, AV50TFBR_Encounter_RefuseReason_FReason, AV51TFBR_Encounter_RefuseReason_FReason_Sel, AV54TFBR_Encounter_RefuseReason_FApproveDate, AV55TFBR_Encounter_RefuseReason_FApproveDate_To, AV13BR_EncounterID, AV36ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace, AV42ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace, AV52ddo_BR_Encounter_RefuseReason_FReasonTitleControlIdToReplace, AV58ddo_BR_Encounter_RefuseReason_FApproveDateTitleControlIdToReplace, AV70Pgmname, AV20IsAuthorized_BR_Encounter_RefuseReason_Reason) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid_nextpage( )
      {
         AV61BR_EnteringSubmitDetailDS_1_Br_encounterreason_vstatus = AV48BR_EncounterReason_vStatus;
         AV62BR_EnteringSubmitDetailDS_2_Tfbr_encounter_refusereason_reason = AV34TFBR_Encounter_RefuseReason_Reason;
         AV63BR_EnteringSubmitDetailDS_3_Tfbr_encounter_refusereason_reason_sel = AV35TFBR_Encounter_RefuseReason_Reason_Sel;
         AV64BR_EnteringSubmitDetailDS_4_Tfbr_encounter_refusereason_noapprovedate = AV38TFBR_Encounter_RefuseReason_NoApproveDate;
         AV65BR_EnteringSubmitDetailDS_5_Tfbr_encounter_refusereason_noapprovedate_to = AV39TFBR_Encounter_RefuseReason_NoApproveDate_To;
         AV66BR_EnteringSubmitDetailDS_6_Tfbr_encounter_refusereason_freason = AV50TFBR_Encounter_RefuseReason_FReason;
         AV67BR_EnteringSubmitDetailDS_7_Tfbr_encounter_refusereason_freason_sel = AV51TFBR_Encounter_RefuseReason_FReason_Sel;
         AV68BR_EnteringSubmitDetailDS_8_Tfbr_encounter_refusereason_fapprovedate = AV54TFBR_Encounter_RefuseReason_FApproveDate;
         AV69BR_EnteringSubmitDetailDS_9_Tfbr_encounter_refusereason_fapprovedate_to = AV55TFBR_Encounter_RefuseReason_FApproveDate_To;
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
            gxgrGrid_refresh( subGrid_Rows, AV48BR_EncounterReason_vStatus, AV26OrderedBy, AV27OrderedDsc, AV34TFBR_Encounter_RefuseReason_Reason, AV35TFBR_Encounter_RefuseReason_Reason_Sel, AV38TFBR_Encounter_RefuseReason_NoApproveDate, AV39TFBR_Encounter_RefuseReason_NoApproveDate_To, AV50TFBR_Encounter_RefuseReason_FReason, AV51TFBR_Encounter_RefuseReason_FReason_Sel, AV54TFBR_Encounter_RefuseReason_FApproveDate, AV55TFBR_Encounter_RefuseReason_FApproveDate_To, AV13BR_EncounterID, AV36ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace, AV42ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace, AV52ddo_BR_Encounter_RefuseReason_FReasonTitleControlIdToReplace, AV58ddo_BR_Encounter_RefuseReason_FApproveDateTitleControlIdToReplace, AV70Pgmname, AV20IsAuthorized_BR_Encounter_RefuseReason_Reason) ;
         }
         send_integrity_footer_hashes( ) ;
         return (short)(((GRID_nEOF==0) ? 0 : 2)) ;
      }

      protected short subgrid_previouspage( )
      {
         AV61BR_EnteringSubmitDetailDS_1_Br_encounterreason_vstatus = AV48BR_EncounterReason_vStatus;
         AV62BR_EnteringSubmitDetailDS_2_Tfbr_encounter_refusereason_reason = AV34TFBR_Encounter_RefuseReason_Reason;
         AV63BR_EnteringSubmitDetailDS_3_Tfbr_encounter_refusereason_reason_sel = AV35TFBR_Encounter_RefuseReason_Reason_Sel;
         AV64BR_EnteringSubmitDetailDS_4_Tfbr_encounter_refusereason_noapprovedate = AV38TFBR_Encounter_RefuseReason_NoApproveDate;
         AV65BR_EnteringSubmitDetailDS_5_Tfbr_encounter_refusereason_noapprovedate_to = AV39TFBR_Encounter_RefuseReason_NoApproveDate_To;
         AV66BR_EnteringSubmitDetailDS_6_Tfbr_encounter_refusereason_freason = AV50TFBR_Encounter_RefuseReason_FReason;
         AV67BR_EnteringSubmitDetailDS_7_Tfbr_encounter_refusereason_freason_sel = AV51TFBR_Encounter_RefuseReason_FReason_Sel;
         AV68BR_EnteringSubmitDetailDS_8_Tfbr_encounter_refusereason_fapprovedate = AV54TFBR_Encounter_RefuseReason_FApproveDate;
         AV69BR_EnteringSubmitDetailDS_9_Tfbr_encounter_refusereason_fapprovedate_to = AV55TFBR_Encounter_RefuseReason_FApproveDate_To;
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
            gxgrGrid_refresh( subGrid_Rows, AV48BR_EncounterReason_vStatus, AV26OrderedBy, AV27OrderedDsc, AV34TFBR_Encounter_RefuseReason_Reason, AV35TFBR_Encounter_RefuseReason_Reason_Sel, AV38TFBR_Encounter_RefuseReason_NoApproveDate, AV39TFBR_Encounter_RefuseReason_NoApproveDate_To, AV50TFBR_Encounter_RefuseReason_FReason, AV51TFBR_Encounter_RefuseReason_FReason_Sel, AV54TFBR_Encounter_RefuseReason_FApproveDate, AV55TFBR_Encounter_RefuseReason_FApproveDate_To, AV13BR_EncounterID, AV36ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace, AV42ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace, AV52ddo_BR_Encounter_RefuseReason_FReasonTitleControlIdToReplace, AV58ddo_BR_Encounter_RefuseReason_FApproveDateTitleControlIdToReplace, AV70Pgmname, AV20IsAuthorized_BR_Encounter_RefuseReason_Reason) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid_lastpage( )
      {
         AV61BR_EnteringSubmitDetailDS_1_Br_encounterreason_vstatus = AV48BR_EncounterReason_vStatus;
         AV62BR_EnteringSubmitDetailDS_2_Tfbr_encounter_refusereason_reason = AV34TFBR_Encounter_RefuseReason_Reason;
         AV63BR_EnteringSubmitDetailDS_3_Tfbr_encounter_refusereason_reason_sel = AV35TFBR_Encounter_RefuseReason_Reason_Sel;
         AV64BR_EnteringSubmitDetailDS_4_Tfbr_encounter_refusereason_noapprovedate = AV38TFBR_Encounter_RefuseReason_NoApproveDate;
         AV65BR_EnteringSubmitDetailDS_5_Tfbr_encounter_refusereason_noapprovedate_to = AV39TFBR_Encounter_RefuseReason_NoApproveDate_To;
         AV66BR_EnteringSubmitDetailDS_6_Tfbr_encounter_refusereason_freason = AV50TFBR_Encounter_RefuseReason_FReason;
         AV67BR_EnteringSubmitDetailDS_7_Tfbr_encounter_refusereason_freason_sel = AV51TFBR_Encounter_RefuseReason_FReason_Sel;
         AV68BR_EnteringSubmitDetailDS_8_Tfbr_encounter_refusereason_fapprovedate = AV54TFBR_Encounter_RefuseReason_FApproveDate;
         AV69BR_EnteringSubmitDetailDS_9_Tfbr_encounter_refusereason_fapprovedate_to = AV55TFBR_Encounter_RefuseReason_FApproveDate_To;
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
            gxgrGrid_refresh( subGrid_Rows, AV48BR_EncounterReason_vStatus, AV26OrderedBy, AV27OrderedDsc, AV34TFBR_Encounter_RefuseReason_Reason, AV35TFBR_Encounter_RefuseReason_Reason_Sel, AV38TFBR_Encounter_RefuseReason_NoApproveDate, AV39TFBR_Encounter_RefuseReason_NoApproveDate_To, AV50TFBR_Encounter_RefuseReason_FReason, AV51TFBR_Encounter_RefuseReason_FReason_Sel, AV54TFBR_Encounter_RefuseReason_FApproveDate, AV55TFBR_Encounter_RefuseReason_FApproveDate_To, AV13BR_EncounterID, AV36ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace, AV42ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace, AV52ddo_BR_Encounter_RefuseReason_FReasonTitleControlIdToReplace, AV58ddo_BR_Encounter_RefuseReason_FApproveDateTitleControlIdToReplace, AV70Pgmname, AV20IsAuthorized_BR_Encounter_RefuseReason_Reason) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected int subgrid_gotopage( int nPageNo )
      {
         AV61BR_EnteringSubmitDetailDS_1_Br_encounterreason_vstatus = AV48BR_EncounterReason_vStatus;
         AV62BR_EnteringSubmitDetailDS_2_Tfbr_encounter_refusereason_reason = AV34TFBR_Encounter_RefuseReason_Reason;
         AV63BR_EnteringSubmitDetailDS_3_Tfbr_encounter_refusereason_reason_sel = AV35TFBR_Encounter_RefuseReason_Reason_Sel;
         AV64BR_EnteringSubmitDetailDS_4_Tfbr_encounter_refusereason_noapprovedate = AV38TFBR_Encounter_RefuseReason_NoApproveDate;
         AV65BR_EnteringSubmitDetailDS_5_Tfbr_encounter_refusereason_noapprovedate_to = AV39TFBR_Encounter_RefuseReason_NoApproveDate_To;
         AV66BR_EnteringSubmitDetailDS_6_Tfbr_encounter_refusereason_freason = AV50TFBR_Encounter_RefuseReason_FReason;
         AV67BR_EnteringSubmitDetailDS_7_Tfbr_encounter_refusereason_freason_sel = AV51TFBR_Encounter_RefuseReason_FReason_Sel;
         AV68BR_EnteringSubmitDetailDS_8_Tfbr_encounter_refusereason_fapprovedate = AV54TFBR_Encounter_RefuseReason_FApproveDate;
         AV69BR_EnteringSubmitDetailDS_9_Tfbr_encounter_refusereason_fapprovedate_to = AV55TFBR_Encounter_RefuseReason_FApproveDate_To;
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
            gxgrGrid_refresh( subGrid_Rows, AV48BR_EncounterReason_vStatus, AV26OrderedBy, AV27OrderedDsc, AV34TFBR_Encounter_RefuseReason_Reason, AV35TFBR_Encounter_RefuseReason_Reason_Sel, AV38TFBR_Encounter_RefuseReason_NoApproveDate, AV39TFBR_Encounter_RefuseReason_NoApproveDate_To, AV50TFBR_Encounter_RefuseReason_FReason, AV51TFBR_Encounter_RefuseReason_FReason_Sel, AV54TFBR_Encounter_RefuseReason_FApproveDate, AV55TFBR_Encounter_RefuseReason_FApproveDate_To, AV13BR_EncounterID, AV36ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace, AV42ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace, AV52ddo_BR_Encounter_RefuseReason_FReasonTitleControlIdToReplace, AV58ddo_BR_Encounter_RefuseReason_FApproveDateTitleControlIdToReplace, AV70Pgmname, AV20IsAuthorized_BR_Encounter_RefuseReason_Reason) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP7D0( )
      {
         /* Before Start, stand alone formulas. */
         AV70Pgmname = "BR_EnteringSubmitDetail";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E177D2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( "vDDO_TITLESETTINGSICONS"), AV43DDO_TitleSettingsIcons);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_ENCOUNTER_REFUSEREASON_REASONTITLEFILTERDATA"), AV33BR_Encounter_RefuseReason_ReasonTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATETITLEFILTERDATA"), AV37BR_Encounter_RefuseReason_NoApproveDateTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_ENCOUNTER_REFUSEREASON_FREASONTITLEFILTERDATA"), AV49BR_Encounter_RefuseReason_FReasonTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_ENCOUNTER_REFUSEREASON_FAPPROVEDATETITLEFILTERDATA"), AV53BR_Encounter_RefuseReason_FApproveDateTitleFilterData);
            /* Read variables values. */
            cmbavBr_encounterreason_vstatus.Name = cmbavBr_encounterreason_vstatus_Internalname;
            cmbavBr_encounterreason_vstatus.CurrentValue = cgiGet( cmbavBr_encounterreason_vstatus_Internalname);
            AV48BR_EncounterReason_vStatus = (short)(NumberUtil.Val( cgiGet( cmbavBr_encounterreason_vstatus_Internalname), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV48BR_EncounterReason_vStatus", StringUtil.LTrim( StringUtil.Str( (decimal)(AV48BR_EncounterReason_vStatus), 4, 0)));
            AV36ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace = cgiGet( edtavDdo_br_encounter_refusereason_reasontitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV36ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace", AV36ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace);
            AV42ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace = cgiGet( edtavDdo_br_encounter_refusereason_noapprovedatetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV42ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace", AV42ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace);
            AV52ddo_BR_Encounter_RefuseReason_FReasonTitleControlIdToReplace = cgiGet( edtavDdo_br_encounter_refusereason_freasontitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV52ddo_BR_Encounter_RefuseReason_FReasonTitleControlIdToReplace", AV52ddo_BR_Encounter_RefuseReason_FReasonTitleControlIdToReplace);
            AV58ddo_BR_Encounter_RefuseReason_FApproveDateTitleControlIdToReplace = cgiGet( edtavDdo_br_encounter_refusereason_fapprovedatetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV58ddo_BR_Encounter_RefuseReason_FApproveDateTitleControlIdToReplace", AV58ddo_BR_Encounter_RefuseReason_FApproveDateTitleControlIdToReplace);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavOrderedby_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavOrderedby_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vORDEREDBY");
               GX_FocusControl = edtavOrderedby_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV26OrderedBy = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV26OrderedBy), 4, 0)));
            }
            else
            {
               AV26OrderedBy = (short)(context.localUtil.CToN( cgiGet( edtavOrderedby_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV26OrderedBy), 4, 0)));
            }
            AV27OrderedDsc = StringUtil.StrToBool( cgiGet( edtavOrdereddsc_Internalname));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27OrderedDsc", AV27OrderedDsc);
            AV34TFBR_Encounter_RefuseReason_Reason = cgiGet( edtavTfbr_encounter_refusereason_reason_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34TFBR_Encounter_RefuseReason_Reason", AV34TFBR_Encounter_RefuseReason_Reason);
            AV35TFBR_Encounter_RefuseReason_Reason_Sel = cgiGet( edtavTfbr_encounter_refusereason_reason_sel_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV35TFBR_Encounter_RefuseReason_Reason_Sel", AV35TFBR_Encounter_RefuseReason_Reason_Sel);
            if ( context.localUtil.VCDateTime( cgiGet( edtavTfbr_encounter_refusereason_noapprovedate_Internalname), 0, 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"TFBR_Encounter_Refuse Reason_No Approve Date"}), 1, "vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE");
               GX_FocusControl = edtavTfbr_encounter_refusereason_noapprovedate_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV38TFBR_Encounter_RefuseReason_NoApproveDate = (DateTime)(DateTime.MinValue);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV38TFBR_Encounter_RefuseReason_NoApproveDate", context.localUtil.TToC( AV38TFBR_Encounter_RefuseReason_NoApproveDate, 10, 8, 0, 0, "/", ":", " "));
            }
            else
            {
               AV38TFBR_Encounter_RefuseReason_NoApproveDate = context.localUtil.CToT( cgiGet( edtavTfbr_encounter_refusereason_noapprovedate_Internalname));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV38TFBR_Encounter_RefuseReason_NoApproveDate", context.localUtil.TToC( AV38TFBR_Encounter_RefuseReason_NoApproveDate, 10, 8, 0, 0, "/", ":", " "));
            }
            if ( context.localUtil.VCDateTime( cgiGet( edtavTfbr_encounter_refusereason_noapprovedate_to_Internalname), 0, 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"TFBR_Encounter_Refuse Reason_No Approve Date_To"}), 1, "vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_TO");
               GX_FocusControl = edtavTfbr_encounter_refusereason_noapprovedate_to_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV39TFBR_Encounter_RefuseReason_NoApproveDate_To = (DateTime)(DateTime.MinValue);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV39TFBR_Encounter_RefuseReason_NoApproveDate_To", context.localUtil.TToC( AV39TFBR_Encounter_RefuseReason_NoApproveDate_To, 10, 8, 0, 0, "/", ":", " "));
            }
            else
            {
               AV39TFBR_Encounter_RefuseReason_NoApproveDate_To = context.localUtil.CToT( cgiGet( edtavTfbr_encounter_refusereason_noapprovedate_to_Internalname));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV39TFBR_Encounter_RefuseReason_NoApproveDate_To", context.localUtil.TToC( AV39TFBR_Encounter_RefuseReason_NoApproveDate_To, 10, 8, 0, 0, "/", ":", " "));
            }
            if ( context.localUtil.VCDate( cgiGet( edtavDdo_br_encounter_refusereason_noapprovedateauxdate_Internalname), 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"DDO_BR_Encounter_Refuse Reason_No Approve Date Aux Date"}), 1, "vDDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEAUXDATE");
               GX_FocusControl = edtavDdo_br_encounter_refusereason_noapprovedateauxdate_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV40DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDate = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV40DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDate", context.localUtil.Format(AV40DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDate, "9999/99/99"));
            }
            else
            {
               AV40DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDate = context.localUtil.CToD( cgiGet( edtavDdo_br_encounter_refusereason_noapprovedateauxdate_Internalname), 0);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV40DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDate", context.localUtil.Format(AV40DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDate, "9999/99/99"));
            }
            if ( context.localUtil.VCDate( cgiGet( edtavDdo_br_encounter_refusereason_noapprovedateauxdateto_Internalname), 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"DDO_BR_Encounter_Refuse Reason_No Approve Date Aux Date To"}), 1, "vDDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEAUXDATETO");
               GX_FocusControl = edtavDdo_br_encounter_refusereason_noapprovedateauxdateto_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV41DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDateTo = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV41DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDateTo", context.localUtil.Format(AV41DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDateTo, "9999/99/99"));
            }
            else
            {
               AV41DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDateTo = context.localUtil.CToD( cgiGet( edtavDdo_br_encounter_refusereason_noapprovedateauxdateto_Internalname), 0);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV41DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDateTo", context.localUtil.Format(AV41DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDateTo, "9999/99/99"));
            }
            AV50TFBR_Encounter_RefuseReason_FReason = cgiGet( edtavTfbr_encounter_refusereason_freason_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV50TFBR_Encounter_RefuseReason_FReason", AV50TFBR_Encounter_RefuseReason_FReason);
            AV51TFBR_Encounter_RefuseReason_FReason_Sel = cgiGet( edtavTfbr_encounter_refusereason_freason_sel_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV51TFBR_Encounter_RefuseReason_FReason_Sel", AV51TFBR_Encounter_RefuseReason_FReason_Sel);
            if ( context.localUtil.VCDateTime( cgiGet( edtavTfbr_encounter_refusereason_fapprovedate_Internalname), 0, 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"TFBR_Encounter_Refuse Reason_FApprove Date"}), 1, "vTFBR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE");
               GX_FocusControl = edtavTfbr_encounter_refusereason_fapprovedate_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV54TFBR_Encounter_RefuseReason_FApproveDate = (DateTime)(DateTime.MinValue);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV54TFBR_Encounter_RefuseReason_FApproveDate", context.localUtil.TToC( AV54TFBR_Encounter_RefuseReason_FApproveDate, 10, 8, 0, 0, "/", ":", " "));
            }
            else
            {
               AV54TFBR_Encounter_RefuseReason_FApproveDate = context.localUtil.CToT( cgiGet( edtavTfbr_encounter_refusereason_fapprovedate_Internalname));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV54TFBR_Encounter_RefuseReason_FApproveDate", context.localUtil.TToC( AV54TFBR_Encounter_RefuseReason_FApproveDate, 10, 8, 0, 0, "/", ":", " "));
            }
            if ( context.localUtil.VCDateTime( cgiGet( edtavTfbr_encounter_refusereason_fapprovedate_to_Internalname), 0, 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_baddatetime", new   object[]  {"TFBR_Encounter_Refuse Reason_FApprove Date_To"}), 1, "vTFBR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE_TO");
               GX_FocusControl = edtavTfbr_encounter_refusereason_fapprovedate_to_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV55TFBR_Encounter_RefuseReason_FApproveDate_To = (DateTime)(DateTime.MinValue);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV55TFBR_Encounter_RefuseReason_FApproveDate_To", context.localUtil.TToC( AV55TFBR_Encounter_RefuseReason_FApproveDate_To, 10, 8, 0, 0, "/", ":", " "));
            }
            else
            {
               AV55TFBR_Encounter_RefuseReason_FApproveDate_To = context.localUtil.CToT( cgiGet( edtavTfbr_encounter_refusereason_fapprovedate_to_Internalname));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV55TFBR_Encounter_RefuseReason_FApproveDate_To", context.localUtil.TToC( AV55TFBR_Encounter_RefuseReason_FApproveDate_To, 10, 8, 0, 0, "/", ":", " "));
            }
            if ( context.localUtil.VCDate( cgiGet( edtavDdo_br_encounter_refusereason_fapprovedateauxdate_Internalname), 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"DDO_BR_Encounter_Refuse Reason_FApprove Date Aux Date"}), 1, "vDDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATEAUXDATE");
               GX_FocusControl = edtavDdo_br_encounter_refusereason_fapprovedateauxdate_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV56DDO_BR_Encounter_RefuseReason_FApproveDateAuxDate = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV56DDO_BR_Encounter_RefuseReason_FApproveDateAuxDate", context.localUtil.Format(AV56DDO_BR_Encounter_RefuseReason_FApproveDateAuxDate, "9999/99/99"));
            }
            else
            {
               AV56DDO_BR_Encounter_RefuseReason_FApproveDateAuxDate = context.localUtil.CToD( cgiGet( edtavDdo_br_encounter_refusereason_fapprovedateauxdate_Internalname), 0);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV56DDO_BR_Encounter_RefuseReason_FApproveDateAuxDate", context.localUtil.Format(AV56DDO_BR_Encounter_RefuseReason_FApproveDateAuxDate, "9999/99/99"));
            }
            if ( context.localUtil.VCDate( cgiGet( edtavDdo_br_encounter_refusereason_fapprovedateauxdateto_Internalname), 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"DDO_BR_Encounter_Refuse Reason_FApprove Date Aux Date To"}), 1, "vDDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATEAUXDATETO");
               GX_FocusControl = edtavDdo_br_encounter_refusereason_fapprovedateauxdateto_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV57DDO_BR_Encounter_RefuseReason_FApproveDateAuxDateTo = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV57DDO_BR_Encounter_RefuseReason_FApproveDateAuxDateTo", context.localUtil.Format(AV57DDO_BR_Encounter_RefuseReason_FApproveDateAuxDateTo, "9999/99/99"));
            }
            else
            {
               AV57DDO_BR_Encounter_RefuseReason_FApproveDateAuxDateTo = context.localUtil.CToD( cgiGet( edtavDdo_br_encounter_refusereason_fapprovedateauxdateto_Internalname), 0);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV57DDO_BR_Encounter_RefuseReason_FApproveDateAuxDateTo", context.localUtil.Format(AV57DDO_BR_Encounter_RefuseReason_FApproveDateAuxDateTo, "9999/99/99"));
            }
            /* Read saved values. */
            nRC_GXsfl_17 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_17"), ".", ","));
            AV17GridCurrentPage = (long)(context.localUtil.CToN( cgiGet( "vGRIDCURRENTPAGE"), ".", ","));
            AV19GridRecordCount = (long)(context.localUtil.CToN( cgiGet( "vGRIDRECORDCOUNT"), ".", ","));
            AV18GridPageSize = (long)(context.localUtil.CToN( cgiGet( "vGRIDPAGESIZE"), ".", ","));
            GRID_nFirstRecordOnPage = (long)(context.localUtil.CToN( cgiGet( "GRID_nFirstRecordOnPage"), ".", ","));
            GRID_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRID_nEOF"), ".", ","));
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( "GRID_Rows"), ".", ","));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
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
            Ddo_br_encounter_refusereason_freason_Caption = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_FREASON_Caption");
            Ddo_br_encounter_refusereason_freason_Tooltip = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_FREASON_Tooltip");
            Ddo_br_encounter_refusereason_freason_Cls = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_FREASON_Cls");
            Ddo_br_encounter_refusereason_freason_Filteredtext_set = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_FREASON_Filteredtext_set");
            Ddo_br_encounter_refusereason_freason_Selectedvalue_set = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_FREASON_Selectedvalue_set");
            Ddo_br_encounter_refusereason_freason_Dropdownoptionstype = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_FREASON_Dropdownoptionstype");
            Ddo_br_encounter_refusereason_freason_Titlecontrolidtoreplace = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_FREASON_Titlecontrolidtoreplace");
            Ddo_br_encounter_refusereason_freason_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_FREASON_Includesortasc"));
            Ddo_br_encounter_refusereason_freason_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_FREASON_Includesortdsc"));
            Ddo_br_encounter_refusereason_freason_Sortedstatus = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_FREASON_Sortedstatus");
            Ddo_br_encounter_refusereason_freason_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_FREASON_Includefilter"));
            Ddo_br_encounter_refusereason_freason_Filtertype = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_FREASON_Filtertype");
            Ddo_br_encounter_refusereason_freason_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_FREASON_Filterisrange"));
            Ddo_br_encounter_refusereason_freason_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_FREASON_Includedatalist"));
            Ddo_br_encounter_refusereason_freason_Datalisttype = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_FREASON_Datalisttype");
            Ddo_br_encounter_refusereason_freason_Datalistproc = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_FREASON_Datalistproc");
            Ddo_br_encounter_refusereason_freason_Datalistupdateminimumcharacters = (int)(context.localUtil.CToN( cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_FREASON_Datalistupdateminimumcharacters"), ".", ","));
            Ddo_br_encounter_refusereason_freason_Sortasc = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_FREASON_Sortasc");
            Ddo_br_encounter_refusereason_freason_Sortdsc = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_FREASON_Sortdsc");
            Ddo_br_encounter_refusereason_freason_Loadingdata = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_FREASON_Loadingdata");
            Ddo_br_encounter_refusereason_freason_Cleanfilter = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_FREASON_Cleanfilter");
            Ddo_br_encounter_refusereason_freason_Noresultsfound = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_FREASON_Noresultsfound");
            Ddo_br_encounter_refusereason_freason_Searchbuttontext = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_FREASON_Searchbuttontext");
            Ddo_br_encounter_refusereason_fapprovedate_Caption = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE_Caption");
            Ddo_br_encounter_refusereason_fapprovedate_Tooltip = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE_Tooltip");
            Ddo_br_encounter_refusereason_fapprovedate_Cls = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE_Cls");
            Ddo_br_encounter_refusereason_fapprovedate_Filteredtext_set = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE_Filteredtext_set");
            Ddo_br_encounter_refusereason_fapprovedate_Filteredtextto_set = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE_Filteredtextto_set");
            Ddo_br_encounter_refusereason_fapprovedate_Dropdownoptionstype = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE_Dropdownoptionstype");
            Ddo_br_encounter_refusereason_fapprovedate_Titlecontrolidtoreplace = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE_Titlecontrolidtoreplace");
            Ddo_br_encounter_refusereason_fapprovedate_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE_Includesortasc"));
            Ddo_br_encounter_refusereason_fapprovedate_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE_Includesortdsc"));
            Ddo_br_encounter_refusereason_fapprovedate_Sortedstatus = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE_Sortedstatus");
            Ddo_br_encounter_refusereason_fapprovedate_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE_Includefilter"));
            Ddo_br_encounter_refusereason_fapprovedate_Filtertype = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE_Filtertype");
            Ddo_br_encounter_refusereason_fapprovedate_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE_Filterisrange"));
            Ddo_br_encounter_refusereason_fapprovedate_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE_Includedatalist"));
            Ddo_br_encounter_refusereason_fapprovedate_Sortasc = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE_Sortasc");
            Ddo_br_encounter_refusereason_fapprovedate_Sortdsc = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE_Sortdsc");
            Ddo_br_encounter_refusereason_fapprovedate_Cleanfilter = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE_Cleanfilter");
            Ddo_br_encounter_refusereason_fapprovedate_Rangefilterfrom = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE_Rangefilterfrom");
            Ddo_br_encounter_refusereason_fapprovedate_Rangefilterto = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE_Rangefilterto");
            Ddo_br_encounter_refusereason_fapprovedate_Searchbuttontext = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE_Searchbuttontext");
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( "GRID_Rows"), ".", ","));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            Gridpaginationbar_Selectedpage = cgiGet( "GRIDPAGINATIONBAR_Selectedpage");
            Gridpaginationbar_Rowsperpageselectedvalue = (int)(context.localUtil.CToN( cgiGet( "GRIDPAGINATIONBAR_Rowsperpageselectedvalue"), ".", ","));
            Ddo_br_encounter_refusereason_reason_Activeeventkey = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_REASON_Activeeventkey");
            Ddo_br_encounter_refusereason_reason_Filteredtext_get = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_REASON_Filteredtext_get");
            Ddo_br_encounter_refusereason_reason_Selectedvalue_get = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_REASON_Selectedvalue_get");
            Ddo_br_encounter_refusereason_noapprovedate_Activeeventkey = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_Activeeventkey");
            Ddo_br_encounter_refusereason_noapprovedate_Filteredtext_get = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_Filteredtext_get");
            Ddo_br_encounter_refusereason_noapprovedate_Filteredtextto_get = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_Filteredtextto_get");
            Ddo_br_encounter_refusereason_freason_Activeeventkey = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_FREASON_Activeeventkey");
            Ddo_br_encounter_refusereason_freason_Filteredtext_get = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_FREASON_Filteredtext_get");
            Ddo_br_encounter_refusereason_freason_Selectedvalue_get = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_FREASON_Selectedvalue_get");
            Ddo_br_encounter_refusereason_fapprovedate_Activeeventkey = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE_Activeeventkey");
            Ddo_br_encounter_refusereason_fapprovedate_Filteredtext_get = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE_Filteredtext_get");
            Ddo_br_encounter_refusereason_fapprovedate_Filteredtextto_get = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE_Filteredtextto_get");
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vBR_ENCOUNTERREASON_VSTATUS"), ".", ",") != Convert.ToDecimal( AV48BR_EncounterReason_vStatus )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vORDEREDBY"), ".", ",") != Convert.ToDecimal( AV26OrderedBy )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrToBool( cgiGet( "GXH_vORDEREDDSC")) != AV27OrderedDsc )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_ENCOUNTER_REFUSEREASON_REASON"), AV34TFBR_Encounter_RefuseReason_Reason) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_ENCOUNTER_REFUSEREASON_REASON_SEL"), AV35TFBR_Encounter_RefuseReason_Reason_Sel) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToT( cgiGet( "GXH_vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE")) != AV38TFBR_Encounter_RefuseReason_NoApproveDate )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToT( cgiGet( "GXH_vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_TO")) != AV39TFBR_Encounter_RefuseReason_NoApproveDate_To )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_ENCOUNTER_REFUSEREASON_FREASON"), AV50TFBR_Encounter_RefuseReason_FReason) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrCmp(cgiGet( "GXH_vTFBR_ENCOUNTER_REFUSEREASON_FREASON_SEL"), AV51TFBR_Encounter_RefuseReason_FReason_Sel) != 0 )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToT( cgiGet( "GXH_vTFBR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE")) != AV54TFBR_Encounter_RefuseReason_FApproveDate )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToT( cgiGet( "GXH_vTFBR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE_TO")) != AV55TFBR_Encounter_RefuseReason_FApproveDate_To )
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
         E177D2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E177D2( )
      {
         /* Start Routine */
         AV12BR_Encounter_RefuseReason.Load(AV6BR_Encounter_RefuseReasonID);
         subGrid_Rows = 9;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GXt_boolean1 = AV20IsAuthorized_BR_Encounter_RefuseReason_Reason;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "WWBR_Encounter_RefuseReason", out  GXt_boolean1) ;
         AV20IsAuthorized_BR_Encounter_RefuseReason_Reason = GXt_boolean1;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20IsAuthorized_BR_Encounter_RefuseReason_Reason", AV20IsAuthorized_BR_Encounter_RefuseReason_Reason);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "gxhash_vISAUTHORIZED_BR_ENCOUNTER_REFUSEREASON_REASON", GetSecureSignedToken( "", AV20IsAuthorized_BR_Encounter_RefuseReason_Reason, context));
         AV48BR_EncounterReason_vStatus = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV48BR_EncounterReason_vStatus", StringUtil.LTrim( StringUtil.Str( (decimal)(AV48BR_EncounterReason_vStatus), 4, 0)));
         edtavTfbr_encounter_refusereason_reason_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_encounter_refusereason_reason_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_encounter_refusereason_reason_Visible), 5, 0)), true);
         edtavTfbr_encounter_refusereason_reason_sel_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_encounter_refusereason_reason_sel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_encounter_refusereason_reason_sel_Visible), 5, 0)), true);
         edtavTfbr_encounter_refusereason_noapprovedate_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_encounter_refusereason_noapprovedate_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_encounter_refusereason_noapprovedate_Visible), 5, 0)), true);
         edtavTfbr_encounter_refusereason_noapprovedate_to_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_encounter_refusereason_noapprovedate_to_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_encounter_refusereason_noapprovedate_to_Visible), 5, 0)), true);
         edtavTfbr_encounter_refusereason_freason_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_encounter_refusereason_freason_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_encounter_refusereason_freason_Visible), 5, 0)), true);
         edtavTfbr_encounter_refusereason_freason_sel_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_encounter_refusereason_freason_sel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_encounter_refusereason_freason_sel_Visible), 5, 0)), true);
         edtavTfbr_encounter_refusereason_fapprovedate_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_encounter_refusereason_fapprovedate_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_encounter_refusereason_fapprovedate_Visible), 5, 0)), true);
         edtavTfbr_encounter_refusereason_fapprovedate_to_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_encounter_refusereason_fapprovedate_to_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_encounter_refusereason_fapprovedate_to_Visible), 5, 0)), true);
         Ddo_br_encounter_refusereason_reason_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Encounter_RefuseReason_Reason";
         ucDdo_br_encounter_refusereason_reason.SendProperty(context, "", false, Ddo_br_encounter_refusereason_reason_Internalname, "TitleControlIdToReplace", Ddo_br_encounter_refusereason_reason_Titlecontrolidtoreplace);
         AV36ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace = Ddo_br_encounter_refusereason_reason_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV36ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace", AV36ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace);
         edtavDdo_br_encounter_refusereason_reasontitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_encounter_refusereason_reasontitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_encounter_refusereason_reasontitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_encounter_refusereason_noapprovedate_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Encounter_RefuseReason_NoApproveDate";
         ucDdo_br_encounter_refusereason_noapprovedate.SendProperty(context, "", false, Ddo_br_encounter_refusereason_noapprovedate_Internalname, "TitleControlIdToReplace", Ddo_br_encounter_refusereason_noapprovedate_Titlecontrolidtoreplace);
         AV42ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace = Ddo_br_encounter_refusereason_noapprovedate_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV42ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace", AV42ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace);
         edtavDdo_br_encounter_refusereason_noapprovedatetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_encounter_refusereason_noapprovedatetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_encounter_refusereason_noapprovedatetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_encounter_refusereason_freason_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Encounter_RefuseReason_FReason";
         ucDdo_br_encounter_refusereason_freason.SendProperty(context, "", false, Ddo_br_encounter_refusereason_freason_Internalname, "TitleControlIdToReplace", Ddo_br_encounter_refusereason_freason_Titlecontrolidtoreplace);
         AV52ddo_BR_Encounter_RefuseReason_FReasonTitleControlIdToReplace = Ddo_br_encounter_refusereason_freason_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV52ddo_BR_Encounter_RefuseReason_FReasonTitleControlIdToReplace", AV52ddo_BR_Encounter_RefuseReason_FReasonTitleControlIdToReplace);
         edtavDdo_br_encounter_refusereason_freasontitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_encounter_refusereason_freasontitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_encounter_refusereason_freasontitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_encounter_refusereason_fapprovedate_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Encounter_RefuseReason_FApproveDate";
         ucDdo_br_encounter_refusereason_fapprovedate.SendProperty(context, "", false, Ddo_br_encounter_refusereason_fapprovedate_Internalname, "TitleControlIdToReplace", Ddo_br_encounter_refusereason_fapprovedate_Titlecontrolidtoreplace);
         AV58ddo_BR_Encounter_RefuseReason_FApproveDateTitleControlIdToReplace = Ddo_br_encounter_refusereason_fapprovedate_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV58ddo_BR_Encounter_RefuseReason_FApproveDateTitleControlIdToReplace", AV58ddo_BR_Encounter_RefuseReason_FApproveDateTitleControlIdToReplace);
         edtavDdo_br_encounter_refusereason_fapprovedatetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_encounter_refusereason_fapprovedatetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_encounter_refusereason_fapprovedatetitlecontrolidtoreplace_Visible), 5, 0)), true);
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
         if ( AV26OrderedBy < 1 )
         {
            AV26OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV26OrderedBy), 4, 0)));
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
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 = AV43DDO_TitleSettingsIcons;
         new GeneXus.Programs.wwpbaseobjects.getwwptitlesettingsicons(context ).execute( out  GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2) ;
         AV43DDO_TitleSettingsIcons = GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2;
         Gridpaginationbar_Rowsperpageselectedvalue = subGrid_Rows;
         ucGridpaginationbar.SendProperty(context, "", false, Gridpaginationbar_Internalname, "RowsPerPageSelectedValue", StringUtil.LTrim( StringUtil.Str( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0)));
      }

      protected void E187D2( )
      {
         if ( gx_refresh_fired )
         {
            return  ;
         }
         gx_refresh_fired = true;
         /* Refresh Routine */
         AV33BR_Encounter_RefuseReason_ReasonTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV37BR_Encounter_RefuseReason_NoApproveDateTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV49BR_Encounter_RefuseReason_FReasonTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV53BR_Encounter_RefuseReason_FApproveDateTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV21WWPContext) ;
         /* Execute user subroutine: 'SAVEGRIDSTATE' */
         S142 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         edtBR_Encounter_RefuseReason_Reason_Titleformat = 2;
         edtBR_Encounter_RefuseReason_Reason_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "初审不通过原因", AV36ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Encounter_RefuseReason_Reason_Internalname, "Title", edtBR_Encounter_RefuseReason_Reason_Title, !bGXsfl_17_Refreshing);
         edtBR_Encounter_RefuseReason_NoApproveDate_Titleformat = 2;
         edtBR_Encounter_RefuseReason_NoApproveDate_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "初审不通过时间", AV42ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Encounter_RefuseReason_NoApproveDate_Internalname, "Title", edtBR_Encounter_RefuseReason_NoApproveDate_Title, !bGXsfl_17_Refreshing);
         edtBR_Encounter_RefuseReason_FReason_Titleformat = 2;
         edtBR_Encounter_RefuseReason_FReason_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "复审不通过原因", AV52ddo_BR_Encounter_RefuseReason_FReasonTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Encounter_RefuseReason_FReason_Internalname, "Title", edtBR_Encounter_RefuseReason_FReason_Title, !bGXsfl_17_Refreshing);
         edtBR_Encounter_RefuseReason_FApproveDate_Titleformat = 2;
         edtBR_Encounter_RefuseReason_FApproveDate_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "复审不通过时间", AV58ddo_BR_Encounter_RefuseReason_FApproveDateTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Encounter_RefuseReason_FApproveDate_Internalname, "Title", edtBR_Encounter_RefuseReason_FApproveDate_Title, !bGXsfl_17_Refreshing);
         AV17GridCurrentPage = subGrid_Currentpage( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17GridCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17GridCurrentPage), 10, 0)));
         AV18GridPageSize = subGrid_Rows;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18GridPageSize", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18GridPageSize), 10, 0)));
         AV19GridRecordCount = subGrid_Recordcount( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19GridRecordCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV19GridRecordCount), 10, 0)));
         AV61BR_EnteringSubmitDetailDS_1_Br_encounterreason_vstatus = AV48BR_EncounterReason_vStatus;
         AV62BR_EnteringSubmitDetailDS_2_Tfbr_encounter_refusereason_reason = AV34TFBR_Encounter_RefuseReason_Reason;
         AV63BR_EnteringSubmitDetailDS_3_Tfbr_encounter_refusereason_reason_sel = AV35TFBR_Encounter_RefuseReason_Reason_Sel;
         AV64BR_EnteringSubmitDetailDS_4_Tfbr_encounter_refusereason_noapprovedate = AV38TFBR_Encounter_RefuseReason_NoApproveDate;
         AV65BR_EnteringSubmitDetailDS_5_Tfbr_encounter_refusereason_noapprovedate_to = AV39TFBR_Encounter_RefuseReason_NoApproveDate_To;
         AV66BR_EnteringSubmitDetailDS_6_Tfbr_encounter_refusereason_freason = AV50TFBR_Encounter_RefuseReason_FReason;
         AV67BR_EnteringSubmitDetailDS_7_Tfbr_encounter_refusereason_freason_sel = AV51TFBR_Encounter_RefuseReason_FReason_Sel;
         AV68BR_EnteringSubmitDetailDS_8_Tfbr_encounter_refusereason_fapprovedate = AV54TFBR_Encounter_RefuseReason_FApproveDate;
         AV69BR_EnteringSubmitDetailDS_9_Tfbr_encounter_refusereason_fapprovedate_to = AV55TFBR_Encounter_RefuseReason_FApproveDate_To;
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV33BR_Encounter_RefuseReason_ReasonTitleFilterData", AV33BR_Encounter_RefuseReason_ReasonTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV37BR_Encounter_RefuseReason_NoApproveDateTitleFilterData", AV37BR_Encounter_RefuseReason_NoApproveDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV49BR_Encounter_RefuseReason_FReasonTitleFilterData", AV49BR_Encounter_RefuseReason_FReasonTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV53BR_Encounter_RefuseReason_FApproveDateTitleFilterData", AV53BR_Encounter_RefuseReason_FApproveDateTitleFilterData);
      }

      protected void E117D2( )
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
            AV16PageToGo = (int)(NumberUtil.Val( Gridpaginationbar_Selectedpage, "."));
            subgrid_gotopage( AV16PageToGo) ;
         }
      }

      protected void E127D2( )
      {
         /* Gridpaginationbar_Changerowsperpage Routine */
         subGrid_Rows = Gridpaginationbar_Rowsperpageselectedvalue;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         subgrid_firstpage( ) ;
         /*  Sending Event outputs  */
      }

      protected void E137D2( )
      {
         /* Ddo_br_encounter_refusereason_reason_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_encounter_refusereason_reason_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S152 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV26OrderedBy = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV26OrderedBy), 4, 0)));
            AV27OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27OrderedDsc", AV27OrderedDsc);
            Ddo_br_encounter_refusereason_reason_Sortedstatus = "ASC";
            ucDdo_br_encounter_refusereason_reason.SendProperty(context, "", false, Ddo_br_encounter_refusereason_reason_Internalname, "SortedStatus", Ddo_br_encounter_refusereason_reason_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_encounter_refusereason_reason_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S152 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV26OrderedBy = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV26OrderedBy), 4, 0)));
            AV27OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27OrderedDsc", AV27OrderedDsc);
            Ddo_br_encounter_refusereason_reason_Sortedstatus = "DSC";
            ucDdo_br_encounter_refusereason_reason.SendProperty(context, "", false, Ddo_br_encounter_refusereason_reason_Internalname, "SortedStatus", Ddo_br_encounter_refusereason_reason_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_encounter_refusereason_reason_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV34TFBR_Encounter_RefuseReason_Reason = Ddo_br_encounter_refusereason_reason_Filteredtext_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34TFBR_Encounter_RefuseReason_Reason", AV34TFBR_Encounter_RefuseReason_Reason);
            AV35TFBR_Encounter_RefuseReason_Reason_Sel = Ddo_br_encounter_refusereason_reason_Selectedvalue_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV35TFBR_Encounter_RefuseReason_Reason_Sel", AV35TFBR_Encounter_RefuseReason_Reason_Sel);
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV33BR_Encounter_RefuseReason_ReasonTitleFilterData", AV33BR_Encounter_RefuseReason_ReasonTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV37BR_Encounter_RefuseReason_NoApproveDateTitleFilterData", AV37BR_Encounter_RefuseReason_NoApproveDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV49BR_Encounter_RefuseReason_FReasonTitleFilterData", AV49BR_Encounter_RefuseReason_FReasonTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV53BR_Encounter_RefuseReason_FApproveDateTitleFilterData", AV53BR_Encounter_RefuseReason_FApproveDateTitleFilterData);
      }

      protected void E147D2( )
      {
         /* Ddo_br_encounter_refusereason_noapprovedate_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_encounter_refusereason_noapprovedate_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S152 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV26OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV26OrderedBy), 4, 0)));
            AV27OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27OrderedDsc", AV27OrderedDsc);
            Ddo_br_encounter_refusereason_noapprovedate_Sortedstatus = "ASC";
            ucDdo_br_encounter_refusereason_noapprovedate.SendProperty(context, "", false, Ddo_br_encounter_refusereason_noapprovedate_Internalname, "SortedStatus", Ddo_br_encounter_refusereason_noapprovedate_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_encounter_refusereason_noapprovedate_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S152 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV26OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV26OrderedBy), 4, 0)));
            AV27OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27OrderedDsc", AV27OrderedDsc);
            Ddo_br_encounter_refusereason_noapprovedate_Sortedstatus = "DSC";
            ucDdo_br_encounter_refusereason_noapprovedate.SendProperty(context, "", false, Ddo_br_encounter_refusereason_noapprovedate_Internalname, "SortedStatus", Ddo_br_encounter_refusereason_noapprovedate_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_encounter_refusereason_noapprovedate_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV38TFBR_Encounter_RefuseReason_NoApproveDate = context.localUtil.CToT( Ddo_br_encounter_refusereason_noapprovedate_Filteredtext_get, 0);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV38TFBR_Encounter_RefuseReason_NoApproveDate", context.localUtil.TToC( AV38TFBR_Encounter_RefuseReason_NoApproveDate, 10, 8, 0, 0, "/", ":", " "));
            AV39TFBR_Encounter_RefuseReason_NoApproveDate_To = context.localUtil.CToT( Ddo_br_encounter_refusereason_noapprovedate_Filteredtextto_get, 0);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV39TFBR_Encounter_RefuseReason_NoApproveDate_To", context.localUtil.TToC( AV39TFBR_Encounter_RefuseReason_NoApproveDate_To, 10, 8, 0, 0, "/", ":", " "));
            if ( ! (DateTime.MinValue==AV39TFBR_Encounter_RefuseReason_NoApproveDate_To) )
            {
               AV39TFBR_Encounter_RefuseReason_NoApproveDate_To = context.localUtil.YMDHMSToT( (short)(DateTimeUtil.Year( AV39TFBR_Encounter_RefuseReason_NoApproveDate_To)), (short)(DateTimeUtil.Month( AV39TFBR_Encounter_RefuseReason_NoApproveDate_To)), (short)(DateTimeUtil.Day( AV39TFBR_Encounter_RefuseReason_NoApproveDate_To)), 23, 59, 59);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV39TFBR_Encounter_RefuseReason_NoApproveDate_To", context.localUtil.TToC( AV39TFBR_Encounter_RefuseReason_NoApproveDate_To, 10, 8, 0, 0, "/", ":", " "));
            }
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV33BR_Encounter_RefuseReason_ReasonTitleFilterData", AV33BR_Encounter_RefuseReason_ReasonTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV37BR_Encounter_RefuseReason_NoApproveDateTitleFilterData", AV37BR_Encounter_RefuseReason_NoApproveDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV49BR_Encounter_RefuseReason_FReasonTitleFilterData", AV49BR_Encounter_RefuseReason_FReasonTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV53BR_Encounter_RefuseReason_FApproveDateTitleFilterData", AV53BR_Encounter_RefuseReason_FApproveDateTitleFilterData);
      }

      protected void E157D2( )
      {
         /* Ddo_br_encounter_refusereason_freason_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_encounter_refusereason_freason_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S152 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV26OrderedBy = 3;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV26OrderedBy), 4, 0)));
            AV27OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27OrderedDsc", AV27OrderedDsc);
            Ddo_br_encounter_refusereason_freason_Sortedstatus = "ASC";
            ucDdo_br_encounter_refusereason_freason.SendProperty(context, "", false, Ddo_br_encounter_refusereason_freason_Internalname, "SortedStatus", Ddo_br_encounter_refusereason_freason_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_encounter_refusereason_freason_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S152 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV26OrderedBy = 3;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV26OrderedBy), 4, 0)));
            AV27OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27OrderedDsc", AV27OrderedDsc);
            Ddo_br_encounter_refusereason_freason_Sortedstatus = "DSC";
            ucDdo_br_encounter_refusereason_freason.SendProperty(context, "", false, Ddo_br_encounter_refusereason_freason_Internalname, "SortedStatus", Ddo_br_encounter_refusereason_freason_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_encounter_refusereason_freason_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV50TFBR_Encounter_RefuseReason_FReason = Ddo_br_encounter_refusereason_freason_Filteredtext_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV50TFBR_Encounter_RefuseReason_FReason", AV50TFBR_Encounter_RefuseReason_FReason);
            AV51TFBR_Encounter_RefuseReason_FReason_Sel = Ddo_br_encounter_refusereason_freason_Selectedvalue_get;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV51TFBR_Encounter_RefuseReason_FReason_Sel", AV51TFBR_Encounter_RefuseReason_FReason_Sel);
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV33BR_Encounter_RefuseReason_ReasonTitleFilterData", AV33BR_Encounter_RefuseReason_ReasonTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV37BR_Encounter_RefuseReason_NoApproveDateTitleFilterData", AV37BR_Encounter_RefuseReason_NoApproveDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV49BR_Encounter_RefuseReason_FReasonTitleFilterData", AV49BR_Encounter_RefuseReason_FReasonTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV53BR_Encounter_RefuseReason_FApproveDateTitleFilterData", AV53BR_Encounter_RefuseReason_FApproveDateTitleFilterData);
      }

      protected void E167D2( )
      {
         /* Ddo_br_encounter_refusereason_fapprovedate_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_encounter_refusereason_fapprovedate_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S152 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV26OrderedBy = 4;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV26OrderedBy), 4, 0)));
            AV27OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27OrderedDsc", AV27OrderedDsc);
            Ddo_br_encounter_refusereason_fapprovedate_Sortedstatus = "ASC";
            ucDdo_br_encounter_refusereason_fapprovedate.SendProperty(context, "", false, Ddo_br_encounter_refusereason_fapprovedate_Internalname, "SortedStatus", Ddo_br_encounter_refusereason_fapprovedate_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_encounter_refusereason_fapprovedate_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S152 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV26OrderedBy = 4;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV26OrderedBy), 4, 0)));
            AV27OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27OrderedDsc", AV27OrderedDsc);
            Ddo_br_encounter_refusereason_fapprovedate_Sortedstatus = "DSC";
            ucDdo_br_encounter_refusereason_fapprovedate.SendProperty(context, "", false, Ddo_br_encounter_refusereason_fapprovedate_Internalname, "SortedStatus", Ddo_br_encounter_refusereason_fapprovedate_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_encounter_refusereason_fapprovedate_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV54TFBR_Encounter_RefuseReason_FApproveDate = context.localUtil.CToT( Ddo_br_encounter_refusereason_fapprovedate_Filteredtext_get, 0);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV54TFBR_Encounter_RefuseReason_FApproveDate", context.localUtil.TToC( AV54TFBR_Encounter_RefuseReason_FApproveDate, 10, 8, 0, 0, "/", ":", " "));
            AV55TFBR_Encounter_RefuseReason_FApproveDate_To = context.localUtil.CToT( Ddo_br_encounter_refusereason_fapprovedate_Filteredtextto_get, 0);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV55TFBR_Encounter_RefuseReason_FApproveDate_To", context.localUtil.TToC( AV55TFBR_Encounter_RefuseReason_FApproveDate_To, 10, 8, 0, 0, "/", ":", " "));
            if ( ! (DateTime.MinValue==AV55TFBR_Encounter_RefuseReason_FApproveDate_To) )
            {
               AV55TFBR_Encounter_RefuseReason_FApproveDate_To = context.localUtil.YMDHMSToT( (short)(DateTimeUtil.Year( AV55TFBR_Encounter_RefuseReason_FApproveDate_To)), (short)(DateTimeUtil.Month( AV55TFBR_Encounter_RefuseReason_FApproveDate_To)), (short)(DateTimeUtil.Day( AV55TFBR_Encounter_RefuseReason_FApproveDate_To)), 23, 59, 59);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV55TFBR_Encounter_RefuseReason_FApproveDate_To", context.localUtil.TToC( AV55TFBR_Encounter_RefuseReason_FApproveDate_To, 10, 8, 0, 0, "/", ":", " "));
            }
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV33BR_Encounter_RefuseReason_ReasonTitleFilterData", AV33BR_Encounter_RefuseReason_ReasonTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV37BR_Encounter_RefuseReason_NoApproveDateTitleFilterData", AV37BR_Encounter_RefuseReason_NoApproveDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV49BR_Encounter_RefuseReason_FReasonTitleFilterData", AV49BR_Encounter_RefuseReason_FReasonTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV53BR_Encounter_RefuseReason_FApproveDateTitleFilterData", AV53BR_Encounter_RefuseReason_FApproveDateTitleFilterData);
      }

      private void E197D2( )
      {
         /* Grid_Load Routine */
         if ( AV20IsAuthorized_BR_Encounter_RefuseReason_Reason )
         {
            edtBR_Encounter_RefuseReason_Reason_Link = formatLink("br_encounter_refusereasonview.aspx") + "?" + UrlEncode("" +A348BR_Encounter_RefuseReasonID) + "," + UrlEncode(StringUtil.RTrim(""));
         }
         /* Load Method */
         if ( wbStart != -1 )
         {
            wbStart = 17;
         }
         sendrow_172( ) ;
         GRID_nCurrentRecord = (long)(GRID_nCurrentRecord+1);
         if ( isFullAjaxMode( ) && ! bGXsfl_17_Refreshing )
         {
            context.DoAjaxLoad(17, GridRow);
         }
         /*  Sending Event outputs  */
      }

      protected void S152( )
      {
         /* 'RESETDDOSORTEDSTATUS' Routine */
         Ddo_br_encounter_refusereason_reason_Sortedstatus = "";
         ucDdo_br_encounter_refusereason_reason.SendProperty(context, "", false, Ddo_br_encounter_refusereason_reason_Internalname, "SortedStatus", Ddo_br_encounter_refusereason_reason_Sortedstatus);
         Ddo_br_encounter_refusereason_noapprovedate_Sortedstatus = "";
         ucDdo_br_encounter_refusereason_noapprovedate.SendProperty(context, "", false, Ddo_br_encounter_refusereason_noapprovedate_Internalname, "SortedStatus", Ddo_br_encounter_refusereason_noapprovedate_Sortedstatus);
         Ddo_br_encounter_refusereason_freason_Sortedstatus = "";
         ucDdo_br_encounter_refusereason_freason.SendProperty(context, "", false, Ddo_br_encounter_refusereason_freason_Internalname, "SortedStatus", Ddo_br_encounter_refusereason_freason_Sortedstatus);
         Ddo_br_encounter_refusereason_fapprovedate_Sortedstatus = "";
         ucDdo_br_encounter_refusereason_fapprovedate.SendProperty(context, "", false, Ddo_br_encounter_refusereason_fapprovedate_Internalname, "SortedStatus", Ddo_br_encounter_refusereason_fapprovedate_Sortedstatus);
      }

      protected void S132( )
      {
         /* 'SETDDOSORTEDSTATUS' Routine */
         /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
         S152 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         if ( AV26OrderedBy == 2 )
         {
            Ddo_br_encounter_refusereason_reason_Sortedstatus = (AV27OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_encounter_refusereason_reason.SendProperty(context, "", false, Ddo_br_encounter_refusereason_reason_Internalname, "SortedStatus", Ddo_br_encounter_refusereason_reason_Sortedstatus);
         }
         else if ( AV26OrderedBy == 1 )
         {
            Ddo_br_encounter_refusereason_noapprovedate_Sortedstatus = (AV27OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_encounter_refusereason_noapprovedate.SendProperty(context, "", false, Ddo_br_encounter_refusereason_noapprovedate_Internalname, "SortedStatus", Ddo_br_encounter_refusereason_noapprovedate_Sortedstatus);
         }
         else if ( AV26OrderedBy == 3 )
         {
            Ddo_br_encounter_refusereason_freason_Sortedstatus = (AV27OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_encounter_refusereason_freason.SendProperty(context, "", false, Ddo_br_encounter_refusereason_freason_Internalname, "SortedStatus", Ddo_br_encounter_refusereason_freason_Sortedstatus);
         }
         else if ( AV26OrderedBy == 4 )
         {
            Ddo_br_encounter_refusereason_fapprovedate_Sortedstatus = (AV27OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_encounter_refusereason_fapprovedate.SendProperty(context, "", false, Ddo_br_encounter_refusereason_fapprovedate_Internalname, "SortedStatus", Ddo_br_encounter_refusereason_fapprovedate_Sortedstatus);
         }
      }

      protected void S122( )
      {
         /* 'LOADGRIDSTATE' Routine */
         if ( StringUtil.StrCmp(AV28Session.Get(AV70Pgmname+"GridState"), "") == 0 )
         {
            AV24GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  AV70Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         else
         {
            AV24GridState.FromXml(AV28Session.Get(AV70Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         AV26OrderedBy = AV24GridState.gxTpr_Orderedby;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV26OrderedBy), 4, 0)));
         AV27OrderedDsc = AV24GridState.gxTpr_Ordereddsc;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27OrderedDsc", AV27OrderedDsc);
         /* Execute user subroutine: 'SETDDOSORTEDSTATUS' */
         S132 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         AV71GXV1 = 1;
         while ( AV71GXV1 <= AV24GridState.gxTpr_Filtervalues.Count )
         {
            AV25GridStateFilterValue = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue)AV24GridState.gxTpr_Filtervalues.Item(AV71GXV1));
            if ( StringUtil.StrCmp(AV25GridStateFilterValue.gxTpr_Name, "BR_ENCOUNTERREASON_VSTATUS") == 0 )
            {
               AV48BR_EncounterReason_vStatus = (short)(NumberUtil.Val( AV25GridStateFilterValue.gxTpr_Value, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV48BR_EncounterReason_vStatus", StringUtil.LTrim( StringUtil.Str( (decimal)(AV48BR_EncounterReason_vStatus), 4, 0)));
            }
            else if ( StringUtil.StrCmp(AV25GridStateFilterValue.gxTpr_Name, "TFBR_ENCOUNTER_REFUSEREASON_REASON") == 0 )
            {
               AV34TFBR_Encounter_RefuseReason_Reason = AV25GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34TFBR_Encounter_RefuseReason_Reason", AV34TFBR_Encounter_RefuseReason_Reason);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV34TFBR_Encounter_RefuseReason_Reason)) )
               {
                  Ddo_br_encounter_refusereason_reason_Filteredtext_set = AV34TFBR_Encounter_RefuseReason_Reason;
                  ucDdo_br_encounter_refusereason_reason.SendProperty(context, "", false, Ddo_br_encounter_refusereason_reason_Internalname, "FilteredText_set", Ddo_br_encounter_refusereason_reason_Filteredtext_set);
               }
            }
            else if ( StringUtil.StrCmp(AV25GridStateFilterValue.gxTpr_Name, "TFBR_ENCOUNTER_REFUSEREASON_REASON_SEL") == 0 )
            {
               AV35TFBR_Encounter_RefuseReason_Reason_Sel = AV25GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV35TFBR_Encounter_RefuseReason_Reason_Sel", AV35TFBR_Encounter_RefuseReason_Reason_Sel);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV35TFBR_Encounter_RefuseReason_Reason_Sel)) )
               {
                  Ddo_br_encounter_refusereason_reason_Selectedvalue_set = AV35TFBR_Encounter_RefuseReason_Reason_Sel;
                  ucDdo_br_encounter_refusereason_reason.SendProperty(context, "", false, Ddo_br_encounter_refusereason_reason_Internalname, "SelectedValue_set", Ddo_br_encounter_refusereason_reason_Selectedvalue_set);
               }
            }
            else if ( StringUtil.StrCmp(AV25GridStateFilterValue.gxTpr_Name, "TFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE") == 0 )
            {
               AV38TFBR_Encounter_RefuseReason_NoApproveDate = context.localUtil.CToT( AV25GridStateFilterValue.gxTpr_Value, 0);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV38TFBR_Encounter_RefuseReason_NoApproveDate", context.localUtil.TToC( AV38TFBR_Encounter_RefuseReason_NoApproveDate, 10, 8, 0, 0, "/", ":", " "));
               AV39TFBR_Encounter_RefuseReason_NoApproveDate_To = context.localUtil.CToT( AV25GridStateFilterValue.gxTpr_Valueto, 0);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV39TFBR_Encounter_RefuseReason_NoApproveDate_To", context.localUtil.TToC( AV39TFBR_Encounter_RefuseReason_NoApproveDate_To, 10, 8, 0, 0, "/", ":", " "));
               if ( ! (DateTime.MinValue==AV38TFBR_Encounter_RefuseReason_NoApproveDate) )
               {
                  AV40DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDate = DateTimeUtil.ResetTime(AV38TFBR_Encounter_RefuseReason_NoApproveDate);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV40DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDate", context.localUtil.Format(AV40DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDate, "9999/99/99"));
                  Ddo_br_encounter_refusereason_noapprovedate_Filteredtext_set = context.localUtil.DToC( AV40DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDate, 0, "/");
                  ucDdo_br_encounter_refusereason_noapprovedate.SendProperty(context, "", false, Ddo_br_encounter_refusereason_noapprovedate_Internalname, "FilteredText_set", Ddo_br_encounter_refusereason_noapprovedate_Filteredtext_set);
               }
               if ( ! (DateTime.MinValue==AV39TFBR_Encounter_RefuseReason_NoApproveDate_To) )
               {
                  AV41DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDateTo = DateTimeUtil.ResetTime(AV39TFBR_Encounter_RefuseReason_NoApproveDate_To);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV41DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDateTo", context.localUtil.Format(AV41DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDateTo, "9999/99/99"));
                  Ddo_br_encounter_refusereason_noapprovedate_Filteredtextto_set = context.localUtil.DToC( AV41DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDateTo, 0, "/");
                  ucDdo_br_encounter_refusereason_noapprovedate.SendProperty(context, "", false, Ddo_br_encounter_refusereason_noapprovedate_Internalname, "FilteredTextTo_set", Ddo_br_encounter_refusereason_noapprovedate_Filteredtextto_set);
               }
            }
            else if ( StringUtil.StrCmp(AV25GridStateFilterValue.gxTpr_Name, "TFBR_ENCOUNTER_REFUSEREASON_FREASON") == 0 )
            {
               AV50TFBR_Encounter_RefuseReason_FReason = AV25GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV50TFBR_Encounter_RefuseReason_FReason", AV50TFBR_Encounter_RefuseReason_FReason);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV50TFBR_Encounter_RefuseReason_FReason)) )
               {
                  Ddo_br_encounter_refusereason_freason_Filteredtext_set = AV50TFBR_Encounter_RefuseReason_FReason;
                  ucDdo_br_encounter_refusereason_freason.SendProperty(context, "", false, Ddo_br_encounter_refusereason_freason_Internalname, "FilteredText_set", Ddo_br_encounter_refusereason_freason_Filteredtext_set);
               }
            }
            else if ( StringUtil.StrCmp(AV25GridStateFilterValue.gxTpr_Name, "TFBR_ENCOUNTER_REFUSEREASON_FREASON_SEL") == 0 )
            {
               AV51TFBR_Encounter_RefuseReason_FReason_Sel = AV25GridStateFilterValue.gxTpr_Value;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV51TFBR_Encounter_RefuseReason_FReason_Sel", AV51TFBR_Encounter_RefuseReason_FReason_Sel);
               if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV51TFBR_Encounter_RefuseReason_FReason_Sel)) )
               {
                  Ddo_br_encounter_refusereason_freason_Selectedvalue_set = AV51TFBR_Encounter_RefuseReason_FReason_Sel;
                  ucDdo_br_encounter_refusereason_freason.SendProperty(context, "", false, Ddo_br_encounter_refusereason_freason_Internalname, "SelectedValue_set", Ddo_br_encounter_refusereason_freason_Selectedvalue_set);
               }
            }
            else if ( StringUtil.StrCmp(AV25GridStateFilterValue.gxTpr_Name, "TFBR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE") == 0 )
            {
               AV54TFBR_Encounter_RefuseReason_FApproveDate = context.localUtil.CToT( AV25GridStateFilterValue.gxTpr_Value, 0);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV54TFBR_Encounter_RefuseReason_FApproveDate", context.localUtil.TToC( AV54TFBR_Encounter_RefuseReason_FApproveDate, 10, 8, 0, 0, "/", ":", " "));
               AV55TFBR_Encounter_RefuseReason_FApproveDate_To = context.localUtil.CToT( AV25GridStateFilterValue.gxTpr_Valueto, 0);
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV55TFBR_Encounter_RefuseReason_FApproveDate_To", context.localUtil.TToC( AV55TFBR_Encounter_RefuseReason_FApproveDate_To, 10, 8, 0, 0, "/", ":", " "));
               if ( ! (DateTime.MinValue==AV54TFBR_Encounter_RefuseReason_FApproveDate) )
               {
                  AV56DDO_BR_Encounter_RefuseReason_FApproveDateAuxDate = DateTimeUtil.ResetTime(AV54TFBR_Encounter_RefuseReason_FApproveDate);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV56DDO_BR_Encounter_RefuseReason_FApproveDateAuxDate", context.localUtil.Format(AV56DDO_BR_Encounter_RefuseReason_FApproveDateAuxDate, "9999/99/99"));
                  Ddo_br_encounter_refusereason_fapprovedate_Filteredtext_set = context.localUtil.DToC( AV56DDO_BR_Encounter_RefuseReason_FApproveDateAuxDate, 0, "/");
                  ucDdo_br_encounter_refusereason_fapprovedate.SendProperty(context, "", false, Ddo_br_encounter_refusereason_fapprovedate_Internalname, "FilteredText_set", Ddo_br_encounter_refusereason_fapprovedate_Filteredtext_set);
               }
               if ( ! (DateTime.MinValue==AV55TFBR_Encounter_RefuseReason_FApproveDate_To) )
               {
                  AV57DDO_BR_Encounter_RefuseReason_FApproveDateAuxDateTo = DateTimeUtil.ResetTime(AV55TFBR_Encounter_RefuseReason_FApproveDate_To);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV57DDO_BR_Encounter_RefuseReason_FApproveDateAuxDateTo", context.localUtil.Format(AV57DDO_BR_Encounter_RefuseReason_FApproveDateAuxDateTo, "9999/99/99"));
                  Ddo_br_encounter_refusereason_fapprovedate_Filteredtextto_set = context.localUtil.DToC( AV57DDO_BR_Encounter_RefuseReason_FApproveDateAuxDateTo, 0, "/");
                  ucDdo_br_encounter_refusereason_fapprovedate.SendProperty(context, "", false, Ddo_br_encounter_refusereason_fapprovedate_Internalname, "FilteredTextTo_set", Ddo_br_encounter_refusereason_fapprovedate_Filteredtextto_set);
               }
            }
            AV71GXV1 = (int)(AV71GXV1+1);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( StringUtil.Trim( AV24GridState.gxTpr_Pagesize))) )
         {
            subGrid_Rows = (int)(NumberUtil.Val( AV24GridState.gxTpr_Pagesize, "."));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         }
         subgrid_gotopage( AV24GridState.gxTpr_Currentpage) ;
      }

      protected void S142( )
      {
         /* 'SAVEGRIDSTATE' Routine */
         AV24GridState.FromXml(AV28Session.Get(AV70Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         AV24GridState.gxTpr_Orderedby = AV26OrderedBy;
         AV24GridState.gxTpr_Ordereddsc = AV27OrderedDsc;
         AV24GridState.gxTpr_Filtervalues.Clear();
         if ( ! (0==AV48BR_EncounterReason_vStatus) )
         {
            AV25GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV25GridStateFilterValue.gxTpr_Name = "BR_ENCOUNTERREASON_VSTATUS";
            AV25GridStateFilterValue.gxTpr_Value = StringUtil.Str( (decimal)(AV48BR_EncounterReason_vStatus), 4, 0);
            AV24GridState.gxTpr_Filtervalues.Add(AV25GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV34TFBR_Encounter_RefuseReason_Reason)) )
         {
            AV25GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV25GridStateFilterValue.gxTpr_Name = "TFBR_ENCOUNTER_REFUSEREASON_REASON";
            AV25GridStateFilterValue.gxTpr_Value = AV34TFBR_Encounter_RefuseReason_Reason;
            AV24GridState.gxTpr_Filtervalues.Add(AV25GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV35TFBR_Encounter_RefuseReason_Reason_Sel)) )
         {
            AV25GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV25GridStateFilterValue.gxTpr_Name = "TFBR_ENCOUNTER_REFUSEREASON_REASON_SEL";
            AV25GridStateFilterValue.gxTpr_Value = AV35TFBR_Encounter_RefuseReason_Reason_Sel;
            AV24GridState.gxTpr_Filtervalues.Add(AV25GridStateFilterValue, 0);
         }
         if ( ! ( (DateTime.MinValue==AV38TFBR_Encounter_RefuseReason_NoApproveDate) && (DateTime.MinValue==AV39TFBR_Encounter_RefuseReason_NoApproveDate_To) ) )
         {
            AV25GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV25GridStateFilterValue.gxTpr_Name = "TFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE";
            AV25GridStateFilterValue.gxTpr_Value = context.localUtil.TToC( AV38TFBR_Encounter_RefuseReason_NoApproveDate, 10, 8, 0, 0, "/", ":", " ");
            AV25GridStateFilterValue.gxTpr_Valueto = context.localUtil.TToC( AV39TFBR_Encounter_RefuseReason_NoApproveDate_To, 10, 8, 0, 0, "/", ":", " ");
            AV24GridState.gxTpr_Filtervalues.Add(AV25GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV50TFBR_Encounter_RefuseReason_FReason)) )
         {
            AV25GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV25GridStateFilterValue.gxTpr_Name = "TFBR_ENCOUNTER_REFUSEREASON_FREASON";
            AV25GridStateFilterValue.gxTpr_Value = AV50TFBR_Encounter_RefuseReason_FReason;
            AV24GridState.gxTpr_Filtervalues.Add(AV25GridStateFilterValue, 0);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV51TFBR_Encounter_RefuseReason_FReason_Sel)) )
         {
            AV25GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV25GridStateFilterValue.gxTpr_Name = "TFBR_ENCOUNTER_REFUSEREASON_FREASON_SEL";
            AV25GridStateFilterValue.gxTpr_Value = AV51TFBR_Encounter_RefuseReason_FReason_Sel;
            AV24GridState.gxTpr_Filtervalues.Add(AV25GridStateFilterValue, 0);
         }
         if ( ! ( (DateTime.MinValue==AV54TFBR_Encounter_RefuseReason_FApproveDate) && (DateTime.MinValue==AV55TFBR_Encounter_RefuseReason_FApproveDate_To) ) )
         {
            AV25GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV25GridStateFilterValue.gxTpr_Name = "TFBR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE";
            AV25GridStateFilterValue.gxTpr_Value = context.localUtil.TToC( AV54TFBR_Encounter_RefuseReason_FApproveDate, 10, 8, 0, 0, "/", ":", " ");
            AV25GridStateFilterValue.gxTpr_Valueto = context.localUtil.TToC( AV55TFBR_Encounter_RefuseReason_FApproveDate_To, 10, 8, 0, 0, "/", ":", " ");
            AV24GridState.gxTpr_Filtervalues.Add(AV25GridStateFilterValue, 0);
         }
         AV24GridState.gxTpr_Pagesize = StringUtil.Str( (decimal)(subGrid_Rows), 10, 0);
         AV24GridState.gxTpr_Currentpage = (short)(subGrid_Currentpage( ));
         new GeneXus.Programs.wwpbaseobjects.savegridstate(context ).execute(  AV70Pgmname+"GridState",  AV24GridState.ToXml(false, true, "WWPGridState", "DataAnalysisPlatform")) ;
      }

      protected void S112( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV22TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV22TrnContext.gxTpr_Callerobject = AV70Pgmname;
         AV22TrnContext.gxTpr_Callerondelete = true;
         AV22TrnContext.gxTpr_Callerurl = AV15HTTPRequest.ScriptName+"?"+AV15HTTPRequest.QueryString;
         AV22TrnContext.gxTpr_Transactionname = "BR_Encounter_RefuseReason";
         AV28Session.Set("TrnContext", AV22TrnContext.ToXml(false, true, "WWPTransactionContext", "DataAnalysisPlatform"));
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV13BR_EncounterID = Convert.ToInt64(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13BR_EncounterID), 18, 0)));
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
         PA7D2( ) ;
         WS7D2( ) ;
         WE7D2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2020227947538", true);
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
         context.AddJavascriptSource("br_enteringsubmitdetail.js", "?2020227947539", false);
         context.AddJavascriptSource("DVelop/DVPaginationBar/DVPaginationBarRender.js", "", false);
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

      protected void SubsflControlProps_172( )
      {
         edtBR_Encounter_RefuseReasonID_Internalname = "BR_ENCOUNTER_REFUSEREASONID_"+sGXsfl_17_idx;
         edtBR_EncounterID_Internalname = "BR_ENCOUNTERID_"+sGXsfl_17_idx;
         edtBR_Encounter_RefuseReason_Reason_Internalname = "BR_ENCOUNTER_REFUSEREASON_REASON_"+sGXsfl_17_idx;
         edtBR_Encounter_RefuseReason_NoApproveDate_Internalname = "BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_"+sGXsfl_17_idx;
         cmbBR_Encounter_RefuseReason_Status_Internalname = "BR_ENCOUNTER_REFUSEREASON_STATUS_"+sGXsfl_17_idx;
         edtBR_Encounter_RefuseReason_Approver_Internalname = "BR_ENCOUNTER_REFUSEREASON_APPROVER_"+sGXsfl_17_idx;
         chkBR_EncounterReason_IsApprove_Internalname = "BR_ENCOUNTERREASON_ISAPPROVE_"+sGXsfl_17_idx;
         edtBR_Information_ID_Internalname = "BR_INFORMATION_ID_"+sGXsfl_17_idx;
         edtBR_Encounter_RefuseReason_FReason_Internalname = "BR_ENCOUNTER_REFUSEREASON_FREASON_"+sGXsfl_17_idx;
         edtBR_Encounter_RefuseReason_FApproveDate_Internalname = "BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE_"+sGXsfl_17_idx;
      }

      protected void SubsflControlProps_fel_172( )
      {
         edtBR_Encounter_RefuseReasonID_Internalname = "BR_ENCOUNTER_REFUSEREASONID_"+sGXsfl_17_fel_idx;
         edtBR_EncounterID_Internalname = "BR_ENCOUNTERID_"+sGXsfl_17_fel_idx;
         edtBR_Encounter_RefuseReason_Reason_Internalname = "BR_ENCOUNTER_REFUSEREASON_REASON_"+sGXsfl_17_fel_idx;
         edtBR_Encounter_RefuseReason_NoApproveDate_Internalname = "BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_"+sGXsfl_17_fel_idx;
         cmbBR_Encounter_RefuseReason_Status_Internalname = "BR_ENCOUNTER_REFUSEREASON_STATUS_"+sGXsfl_17_fel_idx;
         edtBR_Encounter_RefuseReason_Approver_Internalname = "BR_ENCOUNTER_REFUSEREASON_APPROVER_"+sGXsfl_17_fel_idx;
         chkBR_EncounterReason_IsApprove_Internalname = "BR_ENCOUNTERREASON_ISAPPROVE_"+sGXsfl_17_fel_idx;
         edtBR_Information_ID_Internalname = "BR_INFORMATION_ID_"+sGXsfl_17_fel_idx;
         edtBR_Encounter_RefuseReason_FReason_Internalname = "BR_ENCOUNTER_REFUSEREASON_FREASON_"+sGXsfl_17_fel_idx;
         edtBR_Encounter_RefuseReason_FApproveDate_Internalname = "BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE_"+sGXsfl_17_fel_idx;
      }

      protected void sendrow_172( )
      {
         SubsflControlProps_172( ) ;
         WB7D0( ) ;
         if ( ( subGrid_Rows * 1 == 0 ) || ( nGXsfl_17_idx <= subGrid_Recordsperpage( ) * 1 ) )
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
               if ( ((int)(((nGXsfl_17_idx-1)/ (decimal)(1)) % (2))) == 0 )
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
               context.WriteHtmlText( " gxrow=\""+sGXsfl_17_idx+"\">") ;
            }
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Encounter_RefuseReasonID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A348BR_Encounter_RefuseReasonID), 18, 0, ".", "")),context.localUtil.Format( (decimal)(A348BR_Encounter_RefuseReasonID), "ZZZZZZZZZZZZZZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Encounter_RefuseReasonID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)0,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)17,(short)1,(short)-1,(short)0,(bool)true,(String)"ID",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_EncounterID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A19BR_EncounterID), 18, 0, ".", "")),context.localUtil.Format( (decimal)(A19BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_EncounterID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)0,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)17,(short)1,(short)-1,(short)0,(bool)true,(String)"ID",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Encounter_RefuseReason_Reason_Internalname,(String)A349BR_Encounter_RefuseReason_Reason,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)edtBR_Encounter_RefuseReason_Reason_Link,(String)"",(String)"",(String)"",(String)edtBR_Encounter_RefuseReason_Reason_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)300,(short)0,(short)0,(short)17,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Encounter_RefuseReason_NoApproveDate_Internalname,context.localUtil.TToC( A350BR_Encounter_RefuseReason_NoApproveDate, 10, 8, 0, 0, "/", ":", " "),context.localUtil.Format( A350BR_Encounter_RefuseReason_NoApproveDate, "9999/99/99 99:99:99"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Encounter_RefuseReason_NoApproveDate_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)19,(short)0,(short)0,(short)17,(short)1,(short)-1,(short)0,(bool)true,(String)"UpdDate",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            if ( ( cmbBR_Encounter_RefuseReason_Status.ItemCount == 0 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "BR_ENCOUNTER_REFUSEREASON_STATUS_" + sGXsfl_17_idx;
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
            GridRow.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbBR_Encounter_RefuseReason_Status,(String)cmbBR_Encounter_RefuseReason_Status_Internalname,StringUtil.Trim( StringUtil.Str( (decimal)(A351BR_Encounter_RefuseReason_Status), 4, 0)),(short)1,(String)cmbBR_Encounter_RefuseReason_Status_Jsonclick,(short)0,(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"int",(String)"",(short)0,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)"",(String)"Attribute",(String)"WWColumn hidden-xs",(String)"",(String)"",(String)"",(bool)true});
            cmbBR_Encounter_RefuseReason_Status.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A351BR_Encounter_RefuseReason_Status), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Encounter_RefuseReason_Status_Internalname, "Values", (String)(cmbBR_Encounter_RefuseReason_Status.ToJavascriptSource()), !bGXsfl_17_Refreshing);
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Encounter_RefuseReason_Approver_Internalname,(String)A352BR_Encounter_RefuseReason_Approver,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Encounter_RefuseReason_Approver_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)0,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)17,(short)1,(short)-1,(short)-1,(bool)true,(String)"UpdUser",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Check box */
            ClassString = "AttributeCheckBox";
            StyleString = "";
            GridRow.AddColumnProperties("checkbox", 1, isAjaxCallMode( ), new Object[] {(String)chkBR_EncounterReason_IsApprove_Internalname,StringUtil.BoolToStr( A353BR_EncounterReason_IsApprove),(String)"",(String)"",(short)0,(short)0,(String)"true",(String)"",(String)StyleString,(String)ClassString,(String)"WWColumn hidden-xs",(String)"",(String)""});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Information_ID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A85BR_Information_ID), 18, 0, ".", "")),context.localUtil.Format( (decimal)(A85BR_Information_ID), "ZZZZZZZZZZZZZZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Information_ID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)0,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)17,(short)1,(short)-1,(short)0,(bool)true,(String)"ID",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Encounter_RefuseReason_FReason_Internalname,(String)A355BR_Encounter_RefuseReason_FReason,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Encounter_RefuseReason_FReason_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)300,(short)0,(short)0,(short)17,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Encounter_RefuseReason_FApproveDate_Internalname,context.localUtil.TToC( A354BR_Encounter_RefuseReason_FApproveDate, 10, 8, 0, 0, "/", ":", " "),context.localUtil.Format( A354BR_Encounter_RefuseReason_FApproveDate, "9999/99/99 99:99:99"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Encounter_RefuseReason_FApproveDate_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)19,(short)0,(short)0,(short)17,(short)1,(short)-1,(short)0,(bool)true,(String)"UpdDate",(String)"right",(bool)false});
            send_integrity_lvl_hashes7D2( ) ;
            GridContainer.AddRow(GridRow);
            nGXsfl_17_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_17_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_17_idx+1));
            sGXsfl_17_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_17_idx), 4, 0)), 4, "0");
            SubsflControlProps_172( ) ;
         }
         /* End function sendrow_172 */
      }

      protected void init_web_controls( )
      {
         cmbavBr_encounterreason_vstatus.Name = "vBR_ENCOUNTERREASON_VSTATUS";
         cmbavBr_encounterreason_vstatus.WebTags = "";
         cmbavBr_encounterreason_vstatus.addItem(StringUtil.Trim( StringUtil.Str( (decimal)(0), 4, 0)), "全部", 0);
         cmbavBr_encounterreason_vstatus.addItem("1", "初审", 0);
         cmbavBr_encounterreason_vstatus.addItem("2", "复审", 0);
         if ( cmbavBr_encounterreason_vstatus.ItemCount > 0 )
         {
            AV48BR_EncounterReason_vStatus = (short)(NumberUtil.Val( cmbavBr_encounterreason_vstatus.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV48BR_EncounterReason_vStatus), 4, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV48BR_EncounterReason_vStatus", StringUtil.LTrim( StringUtil.Str( (decimal)(AV48BR_EncounterReason_vStatus), 4, 0)));
         }
         GXCCtl = "BR_ENCOUNTER_REFUSEREASON_STATUS_" + sGXsfl_17_idx;
         cmbBR_Encounter_RefuseReason_Status.Name = GXCCtl;
         cmbBR_Encounter_RefuseReason_Status.WebTags = "";
         cmbBR_Encounter_RefuseReason_Status.addItem("1", "未处理", 0);
         cmbBR_Encounter_RefuseReason_Status.addItem("2", "已处理", 0);
         if ( cmbBR_Encounter_RefuseReason_Status.ItemCount > 0 )
         {
            A351BR_Encounter_RefuseReason_Status = (short)(NumberUtil.Val( cmbBR_Encounter_RefuseReason_Status.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A351BR_Encounter_RefuseReason_Status), 4, 0))), "."));
            n351BR_Encounter_RefuseReason_Status = false;
         }
         GXCCtl = "BR_ENCOUNTERREASON_ISAPPROVE_" + sGXsfl_17_idx;
         chkBR_EncounterReason_IsApprove.Name = GXCCtl;
         chkBR_EncounterReason_IsApprove.WebTags = "";
         chkBR_EncounterReason_IsApprove.Caption = "";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkBR_EncounterReason_IsApprove_Internalname, "TitleCaption", chkBR_EncounterReason_IsApprove.Caption, !bGXsfl_17_Refreshing);
         chkBR_EncounterReason_IsApprove.CheckedValue = "false";
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         cmbavBr_encounterreason_vstatus_Internalname = "vBR_ENCOUNTERREASON_VSTATUS";
         edtBR_Encounter_RefuseReasonID_Internalname = "BR_ENCOUNTER_REFUSEREASONID";
         edtBR_EncounterID_Internalname = "BR_ENCOUNTERID";
         edtBR_Encounter_RefuseReason_Reason_Internalname = "BR_ENCOUNTER_REFUSEREASON_REASON";
         edtBR_Encounter_RefuseReason_NoApproveDate_Internalname = "BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE";
         cmbBR_Encounter_RefuseReason_Status_Internalname = "BR_ENCOUNTER_REFUSEREASON_STATUS";
         edtBR_Encounter_RefuseReason_Approver_Internalname = "BR_ENCOUNTER_REFUSEREASON_APPROVER";
         chkBR_EncounterReason_IsApprove_Internalname = "BR_ENCOUNTERREASON_ISAPPROVE";
         edtBR_Information_ID_Internalname = "BR_INFORMATION_ID";
         edtBR_Encounter_RefuseReason_FReason_Internalname = "BR_ENCOUNTER_REFUSEREASON_FREASON";
         edtBR_Encounter_RefuseReason_FApproveDate_Internalname = "BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE";
         Gridpaginationbar_Internalname = "GRIDPAGINATIONBAR";
         divHtml_gridpaginationbar_Internalname = "HTML_GRIDPAGINATIONBAR";
         divGridtablewithpaginationbar_Internalname = "GRIDTABLEWITHPAGINATIONBAR";
         divTablemain_Internalname = "TABLEMAIN";
         Ddo_br_encounter_refusereason_reason_Internalname = "DDO_BR_ENCOUNTER_REFUSEREASON_REASON";
         edtavDdo_br_encounter_refusereason_reasontitlecontrolidtoreplace_Internalname = "vDDO_BR_ENCOUNTER_REFUSEREASON_REASONTITLECONTROLIDTOREPLACE";
         Ddo_br_encounter_refusereason_noapprovedate_Internalname = "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE";
         edtavDdo_br_encounter_refusereason_noapprovedatetitlecontrolidtoreplace_Internalname = "vDDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATETITLECONTROLIDTOREPLACE";
         Ddo_br_encounter_refusereason_freason_Internalname = "DDO_BR_ENCOUNTER_REFUSEREASON_FREASON";
         edtavDdo_br_encounter_refusereason_freasontitlecontrolidtoreplace_Internalname = "vDDO_BR_ENCOUNTER_REFUSEREASON_FREASONTITLECONTROLIDTOREPLACE";
         Ddo_br_encounter_refusereason_fapprovedate_Internalname = "DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE";
         edtavDdo_br_encounter_refusereason_fapprovedatetitlecontrolidtoreplace_Internalname = "vDDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATETITLECONTROLIDTOREPLACE";
         Workwithplusutilities1_Internalname = "WORKWITHPLUSUTILITIES1";
         edtavOrderedby_Internalname = "vORDEREDBY";
         edtavOrdereddsc_Internalname = "vORDEREDDSC";
         edtavTfbr_encounter_refusereason_reason_Internalname = "vTFBR_ENCOUNTER_REFUSEREASON_REASON";
         edtavTfbr_encounter_refusereason_reason_sel_Internalname = "vTFBR_ENCOUNTER_REFUSEREASON_REASON_SEL";
         edtavTfbr_encounter_refusereason_noapprovedate_Internalname = "vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE";
         edtavTfbr_encounter_refusereason_noapprovedate_to_Internalname = "vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_TO";
         edtavDdo_br_encounter_refusereason_noapprovedateauxdate_Internalname = "vDDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEAUXDATE";
         edtavDdo_br_encounter_refusereason_noapprovedateauxdateto_Internalname = "vDDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEAUXDATETO";
         divDdo_br_encounter_refusereason_noapprovedateauxdates_Internalname = "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEAUXDATES";
         edtavTfbr_encounter_refusereason_freason_Internalname = "vTFBR_ENCOUNTER_REFUSEREASON_FREASON";
         edtavTfbr_encounter_refusereason_freason_sel_Internalname = "vTFBR_ENCOUNTER_REFUSEREASON_FREASON_SEL";
         edtavTfbr_encounter_refusereason_fapprovedate_Internalname = "vTFBR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE";
         edtavTfbr_encounter_refusereason_fapprovedate_to_Internalname = "vTFBR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE_TO";
         edtavDdo_br_encounter_refusereason_fapprovedateauxdate_Internalname = "vDDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATEAUXDATE";
         edtavDdo_br_encounter_refusereason_fapprovedateauxdateto_Internalname = "vDDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATEAUXDATETO";
         divDdo_br_encounter_refusereason_fapprovedateauxdates_Internalname = "DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATEAUXDATES";
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
         chkBR_EncounterReason_IsApprove.Caption = "";
         edtBR_Encounter_RefuseReason_FApproveDate_Jsonclick = "";
         edtBR_Encounter_RefuseReason_FReason_Jsonclick = "";
         edtBR_Information_ID_Jsonclick = "";
         edtBR_Encounter_RefuseReason_Approver_Jsonclick = "";
         cmbBR_Encounter_RefuseReason_Status_Jsonclick = "";
         edtBR_Encounter_RefuseReason_NoApproveDate_Jsonclick = "";
         edtBR_Encounter_RefuseReason_Reason_Jsonclick = "";
         edtBR_EncounterID_Jsonclick = "";
         edtBR_Encounter_RefuseReasonID_Jsonclick = "";
         edtavDdo_br_encounter_refusereason_fapprovedateauxdateto_Jsonclick = "";
         edtavDdo_br_encounter_refusereason_fapprovedateauxdate_Jsonclick = "";
         edtavTfbr_encounter_refusereason_fapprovedate_to_Jsonclick = "";
         edtavTfbr_encounter_refusereason_fapprovedate_to_Visible = 1;
         edtavTfbr_encounter_refusereason_fapprovedate_Jsonclick = "";
         edtavTfbr_encounter_refusereason_fapprovedate_Visible = 1;
         edtavTfbr_encounter_refusereason_freason_sel_Visible = 1;
         edtavTfbr_encounter_refusereason_freason_Visible = 1;
         edtavDdo_br_encounter_refusereason_noapprovedateauxdateto_Jsonclick = "";
         edtavDdo_br_encounter_refusereason_noapprovedateauxdate_Jsonclick = "";
         edtavTfbr_encounter_refusereason_noapprovedate_to_Jsonclick = "";
         edtavTfbr_encounter_refusereason_noapprovedate_to_Visible = 1;
         edtavTfbr_encounter_refusereason_noapprovedate_Jsonclick = "";
         edtavTfbr_encounter_refusereason_noapprovedate_Visible = 1;
         edtavTfbr_encounter_refusereason_reason_sel_Visible = 1;
         edtavTfbr_encounter_refusereason_reason_Visible = 1;
         edtavOrdereddsc_Jsonclick = "";
         edtavOrdereddsc_Visible = 1;
         edtavOrderedby_Jsonclick = "";
         edtavOrderedby_Visible = 1;
         edtavDdo_br_encounter_refusereason_fapprovedatetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_encounter_refusereason_freasontitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_encounter_refusereason_noapprovedatetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_encounter_refusereason_reasontitlecontrolidtoreplace_Visible = 1;
         subGrid_Allowcollapsing = 0;
         subGrid_Allowselection = 0;
         edtBR_Encounter_RefuseReason_Reason_Link = "";
         subGrid_Sortable = 0;
         subGrid_Header = "";
         edtBR_Encounter_RefuseReason_FApproveDate_Titleformat = 0;
         edtBR_Encounter_RefuseReason_FApproveDate_Title = "复审不通过时间";
         edtBR_Encounter_RefuseReason_FReason_Titleformat = 0;
         edtBR_Encounter_RefuseReason_FReason_Title = "复审不通过原因";
         edtBR_Encounter_RefuseReason_NoApproveDate_Titleformat = 0;
         edtBR_Encounter_RefuseReason_NoApproveDate_Title = "初审不通过时间";
         edtBR_Encounter_RefuseReason_Reason_Titleformat = 0;
         edtBR_Encounter_RefuseReason_Reason_Title = "初审不通过原因";
         subGrid_Class = "GridWithPaginationBar GridWithBorderColor WorkWith";
         subGrid_Backcolorstyle = 0;
         cmbavBr_encounterreason_vstatus_Jsonclick = "";
         cmbavBr_encounterreason_vstatus.Enabled = 1;
         Ddo_br_encounter_refusereason_fapprovedate_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_encounter_refusereason_fapprovedate_Rangefilterto = "WWP_TSTo";
         Ddo_br_encounter_refusereason_fapprovedate_Rangefilterfrom = "WWP_TSFrom";
         Ddo_br_encounter_refusereason_fapprovedate_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_encounter_refusereason_fapprovedate_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_encounter_refusereason_fapprovedate_Sortasc = "WWP_TSSortASC";
         Ddo_br_encounter_refusereason_fapprovedate_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_encounter_refusereason_fapprovedate_Filterisrange = Convert.ToBoolean( -1);
         Ddo_br_encounter_refusereason_fapprovedate_Filtertype = "Date";
         Ddo_br_encounter_refusereason_fapprovedate_Includefilter = Convert.ToBoolean( -1);
         Ddo_br_encounter_refusereason_fapprovedate_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_encounter_refusereason_fapprovedate_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_encounter_refusereason_fapprovedate_Titlecontrolidtoreplace = "";
         Ddo_br_encounter_refusereason_fapprovedate_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_encounter_refusereason_fapprovedate_Cls = "ColumnSettings";
         Ddo_br_encounter_refusereason_fapprovedate_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_encounter_refusereason_fapprovedate_Caption = "";
         Ddo_br_encounter_refusereason_freason_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_encounter_refusereason_freason_Noresultsfound = "WWP_TSNoResults";
         Ddo_br_encounter_refusereason_freason_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_encounter_refusereason_freason_Loadingdata = "WWP_TSLoading";
         Ddo_br_encounter_refusereason_freason_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_encounter_refusereason_freason_Sortasc = "WWP_TSSortASC";
         Ddo_br_encounter_refusereason_freason_Datalistupdateminimumcharacters = 0;
         Ddo_br_encounter_refusereason_freason_Datalistproc = "BR_EnteringSubmitDetailGetFilterData";
         Ddo_br_encounter_refusereason_freason_Datalisttype = "Dynamic";
         Ddo_br_encounter_refusereason_freason_Includedatalist = Convert.ToBoolean( -1);
         Ddo_br_encounter_refusereason_freason_Filterisrange = Convert.ToBoolean( 0);
         Ddo_br_encounter_refusereason_freason_Filtertype = "Character";
         Ddo_br_encounter_refusereason_freason_Includefilter = Convert.ToBoolean( -1);
         Ddo_br_encounter_refusereason_freason_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_encounter_refusereason_freason_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_encounter_refusereason_freason_Titlecontrolidtoreplace = "";
         Ddo_br_encounter_refusereason_freason_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_encounter_refusereason_freason_Cls = "ColumnSettings";
         Ddo_br_encounter_refusereason_freason_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_encounter_refusereason_freason_Caption = "";
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
         Ddo_br_encounter_refusereason_reason_Datalistproc = "BR_EnteringSubmitDetailGetFilterData";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV13BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV36ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_REASONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV42ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV52ddo_BR_Encounter_RefuseReason_FReasonTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_FREASONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV58ddo_BR_Encounter_RefuseReason_FApproveDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavBr_encounterreason_vstatus'},{av:'AV48BR_EncounterReason_vStatus',fld:'vBR_ENCOUNTERREASON_VSTATUS',pic:'ZZZ9'},{av:'AV34TFBR_Encounter_RefuseReason_Reason',fld:'vTFBR_ENCOUNTER_REFUSEREASON_REASON',pic:''},{av:'AV35TFBR_Encounter_RefuseReason_Reason_Sel',fld:'vTFBR_ENCOUNTER_REFUSEREASON_REASON_SEL',pic:''},{av:'AV38TFBR_Encounter_RefuseReason_NoApproveDate',fld:'vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',pic:'9999/99/99 99:99:99'},{av:'AV39TFBR_Encounter_RefuseReason_NoApproveDate_To',fld:'vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_TO',pic:'9999/99/99 99:99:99'},{av:'AV50TFBR_Encounter_RefuseReason_FReason',fld:'vTFBR_ENCOUNTER_REFUSEREASON_FREASON',pic:''},{av:'AV51TFBR_Encounter_RefuseReason_FReason_Sel',fld:'vTFBR_ENCOUNTER_REFUSEREASON_FREASON_SEL',pic:''},{av:'AV54TFBR_Encounter_RefuseReason_FApproveDate',fld:'vTFBR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE',pic:'9999/99/99 99:99:99'},{av:'AV55TFBR_Encounter_RefuseReason_FApproveDate_To',fld:'vTFBR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE_TO',pic:'9999/99/99 99:99:99'},{av:'AV70Pgmname',fld:'vPGMNAME',pic:''},{av:'AV26OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV27OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV20IsAuthorized_BR_Encounter_RefuseReason_Reason',fld:'vISAUTHORIZED_BR_ENCOUNTER_REFUSEREASON_REASON',pic:'',hsh:true}]");
         setEventMetadata("REFRESH",",oparms:[{av:'AV33BR_Encounter_RefuseReason_ReasonTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASON_REASONTITLEFILTERDATA',pic:''},{av:'AV37BR_Encounter_RefuseReason_NoApproveDateTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATETITLEFILTERDATA',pic:''},{av:'AV49BR_Encounter_RefuseReason_FReasonTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASON_FREASONTITLEFILTERDATA',pic:''},{av:'AV53BR_Encounter_RefuseReason_FApproveDateTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASON_FAPPROVEDATETITLEFILTERDATA',pic:''},{av:'edtBR_Encounter_RefuseReason_Reason_Titleformat',ctrl:'BR_ENCOUNTER_REFUSEREASON_REASON',prop:'Titleformat'},{av:'edtBR_Encounter_RefuseReason_Reason_Title',ctrl:'BR_ENCOUNTER_REFUSEREASON_REASON',prop:'Title'},{av:'edtBR_Encounter_RefuseReason_NoApproveDate_Titleformat',ctrl:'BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'Titleformat'},{av:'edtBR_Encounter_RefuseReason_NoApproveDate_Title',ctrl:'BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'Title'},{av:'edtBR_Encounter_RefuseReason_FReason_Titleformat',ctrl:'BR_ENCOUNTER_REFUSEREASON_FREASON',prop:'Titleformat'},{av:'edtBR_Encounter_RefuseReason_FReason_Title',ctrl:'BR_ENCOUNTER_REFUSEREASON_FREASON',prop:'Title'},{av:'edtBR_Encounter_RefuseReason_FApproveDate_Titleformat',ctrl:'BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE',prop:'Titleformat'},{av:'edtBR_Encounter_RefuseReason_FApproveDate_Title',ctrl:'BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE',prop:'Title'},{av:'AV17GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV18GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV19GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE","{handler:'E117D2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavBr_encounterreason_vstatus'},{av:'AV48BR_EncounterReason_vStatus',fld:'vBR_ENCOUNTERREASON_VSTATUS',pic:'ZZZ9'},{av:'AV26OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV27OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV34TFBR_Encounter_RefuseReason_Reason',fld:'vTFBR_ENCOUNTER_REFUSEREASON_REASON',pic:''},{av:'AV35TFBR_Encounter_RefuseReason_Reason_Sel',fld:'vTFBR_ENCOUNTER_REFUSEREASON_REASON_SEL',pic:''},{av:'AV38TFBR_Encounter_RefuseReason_NoApproveDate',fld:'vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',pic:'9999/99/99 99:99:99'},{av:'AV39TFBR_Encounter_RefuseReason_NoApproveDate_To',fld:'vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_TO',pic:'9999/99/99 99:99:99'},{av:'AV50TFBR_Encounter_RefuseReason_FReason',fld:'vTFBR_ENCOUNTER_REFUSEREASON_FREASON',pic:''},{av:'AV51TFBR_Encounter_RefuseReason_FReason_Sel',fld:'vTFBR_ENCOUNTER_REFUSEREASON_FREASON_SEL',pic:''},{av:'AV54TFBR_Encounter_RefuseReason_FApproveDate',fld:'vTFBR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE',pic:'9999/99/99 99:99:99'},{av:'AV55TFBR_Encounter_RefuseReason_FApproveDate_To',fld:'vTFBR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE_TO',pic:'9999/99/99 99:99:99'},{av:'AV13BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV36ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_REASONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV42ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV52ddo_BR_Encounter_RefuseReason_FReasonTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_FREASONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV58ddo_BR_Encounter_RefuseReason_FApproveDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV70Pgmname',fld:'vPGMNAME',pic:''},{av:'AV20IsAuthorized_BR_Encounter_RefuseReason_Reason',fld:'vISAUTHORIZED_BR_ENCOUNTER_REFUSEREASON_REASON',pic:'',hsh:true},{av:'Gridpaginationbar_Selectedpage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE",",oparms:[]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE","{handler:'E127D2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavBr_encounterreason_vstatus'},{av:'AV48BR_EncounterReason_vStatus',fld:'vBR_ENCOUNTERREASON_VSTATUS',pic:'ZZZ9'},{av:'AV26OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV27OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV34TFBR_Encounter_RefuseReason_Reason',fld:'vTFBR_ENCOUNTER_REFUSEREASON_REASON',pic:''},{av:'AV35TFBR_Encounter_RefuseReason_Reason_Sel',fld:'vTFBR_ENCOUNTER_REFUSEREASON_REASON_SEL',pic:''},{av:'AV38TFBR_Encounter_RefuseReason_NoApproveDate',fld:'vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',pic:'9999/99/99 99:99:99'},{av:'AV39TFBR_Encounter_RefuseReason_NoApproveDate_To',fld:'vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_TO',pic:'9999/99/99 99:99:99'},{av:'AV50TFBR_Encounter_RefuseReason_FReason',fld:'vTFBR_ENCOUNTER_REFUSEREASON_FREASON',pic:''},{av:'AV51TFBR_Encounter_RefuseReason_FReason_Sel',fld:'vTFBR_ENCOUNTER_REFUSEREASON_FREASON_SEL',pic:''},{av:'AV54TFBR_Encounter_RefuseReason_FApproveDate',fld:'vTFBR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE',pic:'9999/99/99 99:99:99'},{av:'AV55TFBR_Encounter_RefuseReason_FApproveDate_To',fld:'vTFBR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE_TO',pic:'9999/99/99 99:99:99'},{av:'AV13BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV36ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_REASONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV42ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV52ddo_BR_Encounter_RefuseReason_FReasonTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_FREASONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV58ddo_BR_Encounter_RefuseReason_FApproveDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV70Pgmname',fld:'vPGMNAME',pic:''},{av:'AV20IsAuthorized_BR_Encounter_RefuseReason_Reason',fld:'vISAUTHORIZED_BR_ENCOUNTER_REFUSEREASON_REASON',pic:'',hsh:true},{av:'Gridpaginationbar_Rowsperpageselectedvalue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE",",oparms:[{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]}");
         setEventMetadata("DDO_BR_ENCOUNTER_REFUSEREASON_REASON.ONOPTIONCLICKED","{handler:'E137D2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavBr_encounterreason_vstatus'},{av:'AV48BR_EncounterReason_vStatus',fld:'vBR_ENCOUNTERREASON_VSTATUS',pic:'ZZZ9'},{av:'AV26OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV27OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV34TFBR_Encounter_RefuseReason_Reason',fld:'vTFBR_ENCOUNTER_REFUSEREASON_REASON',pic:''},{av:'AV35TFBR_Encounter_RefuseReason_Reason_Sel',fld:'vTFBR_ENCOUNTER_REFUSEREASON_REASON_SEL',pic:''},{av:'AV38TFBR_Encounter_RefuseReason_NoApproveDate',fld:'vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',pic:'9999/99/99 99:99:99'},{av:'AV39TFBR_Encounter_RefuseReason_NoApproveDate_To',fld:'vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_TO',pic:'9999/99/99 99:99:99'},{av:'AV50TFBR_Encounter_RefuseReason_FReason',fld:'vTFBR_ENCOUNTER_REFUSEREASON_FREASON',pic:''},{av:'AV51TFBR_Encounter_RefuseReason_FReason_Sel',fld:'vTFBR_ENCOUNTER_REFUSEREASON_FREASON_SEL',pic:''},{av:'AV54TFBR_Encounter_RefuseReason_FApproveDate',fld:'vTFBR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE',pic:'9999/99/99 99:99:99'},{av:'AV55TFBR_Encounter_RefuseReason_FApproveDate_To',fld:'vTFBR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE_TO',pic:'9999/99/99 99:99:99'},{av:'AV13BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV36ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_REASONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV42ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV52ddo_BR_Encounter_RefuseReason_FReasonTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_FREASONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV58ddo_BR_Encounter_RefuseReason_FApproveDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV70Pgmname',fld:'vPGMNAME',pic:''},{av:'AV20IsAuthorized_BR_Encounter_RefuseReason_Reason',fld:'vISAUTHORIZED_BR_ENCOUNTER_REFUSEREASON_REASON',pic:'',hsh:true},{av:'Ddo_br_encounter_refusereason_reason_Activeeventkey',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_REASON',prop:'ActiveEventKey'},{av:'Ddo_br_encounter_refusereason_reason_Filteredtext_get',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_REASON',prop:'FilteredText_get'},{av:'Ddo_br_encounter_refusereason_reason_Selectedvalue_get',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_REASON',prop:'SelectedValue_get'}]");
         setEventMetadata("DDO_BR_ENCOUNTER_REFUSEREASON_REASON.ONOPTIONCLICKED",",oparms:[{av:'AV26OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV27OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_encounter_refusereason_reason_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_REASON',prop:'SortedStatus'},{av:'AV34TFBR_Encounter_RefuseReason_Reason',fld:'vTFBR_ENCOUNTER_REFUSEREASON_REASON',pic:''},{av:'AV35TFBR_Encounter_RefuseReason_Reason_Sel',fld:'vTFBR_ENCOUNTER_REFUSEREASON_REASON_SEL',pic:''},{av:'Ddo_br_encounter_refusereason_noapprovedate_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'SortedStatus'},{av:'Ddo_br_encounter_refusereason_freason_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_FREASON',prop:'SortedStatus'},{av:'Ddo_br_encounter_refusereason_fapprovedate_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE',prop:'SortedStatus'},{av:'AV33BR_Encounter_RefuseReason_ReasonTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASON_REASONTITLEFILTERDATA',pic:''},{av:'AV37BR_Encounter_RefuseReason_NoApproveDateTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATETITLEFILTERDATA',pic:''},{av:'AV49BR_Encounter_RefuseReason_FReasonTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASON_FREASONTITLEFILTERDATA',pic:''},{av:'AV53BR_Encounter_RefuseReason_FApproveDateTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASON_FAPPROVEDATETITLEFILTERDATA',pic:''},{av:'edtBR_Encounter_RefuseReason_Reason_Titleformat',ctrl:'BR_ENCOUNTER_REFUSEREASON_REASON',prop:'Titleformat'},{av:'edtBR_Encounter_RefuseReason_Reason_Title',ctrl:'BR_ENCOUNTER_REFUSEREASON_REASON',prop:'Title'},{av:'edtBR_Encounter_RefuseReason_NoApproveDate_Titleformat',ctrl:'BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'Titleformat'},{av:'edtBR_Encounter_RefuseReason_NoApproveDate_Title',ctrl:'BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'Title'},{av:'edtBR_Encounter_RefuseReason_FReason_Titleformat',ctrl:'BR_ENCOUNTER_REFUSEREASON_FREASON',prop:'Titleformat'},{av:'edtBR_Encounter_RefuseReason_FReason_Title',ctrl:'BR_ENCOUNTER_REFUSEREASON_FREASON',prop:'Title'},{av:'edtBR_Encounter_RefuseReason_FApproveDate_Titleformat',ctrl:'BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE',prop:'Titleformat'},{av:'edtBR_Encounter_RefuseReason_FApproveDate_Title',ctrl:'BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE',prop:'Title'},{av:'AV17GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV18GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV19GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE.ONOPTIONCLICKED","{handler:'E147D2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavBr_encounterreason_vstatus'},{av:'AV48BR_EncounterReason_vStatus',fld:'vBR_ENCOUNTERREASON_VSTATUS',pic:'ZZZ9'},{av:'AV26OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV27OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV34TFBR_Encounter_RefuseReason_Reason',fld:'vTFBR_ENCOUNTER_REFUSEREASON_REASON',pic:''},{av:'AV35TFBR_Encounter_RefuseReason_Reason_Sel',fld:'vTFBR_ENCOUNTER_REFUSEREASON_REASON_SEL',pic:''},{av:'AV38TFBR_Encounter_RefuseReason_NoApproveDate',fld:'vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',pic:'9999/99/99 99:99:99'},{av:'AV39TFBR_Encounter_RefuseReason_NoApproveDate_To',fld:'vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_TO',pic:'9999/99/99 99:99:99'},{av:'AV50TFBR_Encounter_RefuseReason_FReason',fld:'vTFBR_ENCOUNTER_REFUSEREASON_FREASON',pic:''},{av:'AV51TFBR_Encounter_RefuseReason_FReason_Sel',fld:'vTFBR_ENCOUNTER_REFUSEREASON_FREASON_SEL',pic:''},{av:'AV54TFBR_Encounter_RefuseReason_FApproveDate',fld:'vTFBR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE',pic:'9999/99/99 99:99:99'},{av:'AV55TFBR_Encounter_RefuseReason_FApproveDate_To',fld:'vTFBR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE_TO',pic:'9999/99/99 99:99:99'},{av:'AV13BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV36ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_REASONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV42ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV52ddo_BR_Encounter_RefuseReason_FReasonTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_FREASONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV58ddo_BR_Encounter_RefuseReason_FApproveDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV70Pgmname',fld:'vPGMNAME',pic:''},{av:'AV20IsAuthorized_BR_Encounter_RefuseReason_Reason',fld:'vISAUTHORIZED_BR_ENCOUNTER_REFUSEREASON_REASON',pic:'',hsh:true},{av:'Ddo_br_encounter_refusereason_noapprovedate_Activeeventkey',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'ActiveEventKey'},{av:'Ddo_br_encounter_refusereason_noapprovedate_Filteredtext_get',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'FilteredText_get'},{av:'Ddo_br_encounter_refusereason_noapprovedate_Filteredtextto_get',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'FilteredTextTo_get'}]");
         setEventMetadata("DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE.ONOPTIONCLICKED",",oparms:[{av:'AV26OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV27OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_encounter_refusereason_noapprovedate_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'SortedStatus'},{av:'AV38TFBR_Encounter_RefuseReason_NoApproveDate',fld:'vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',pic:'9999/99/99 99:99:99'},{av:'AV39TFBR_Encounter_RefuseReason_NoApproveDate_To',fld:'vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_TO',pic:'9999/99/99 99:99:99'},{av:'Ddo_br_encounter_refusereason_reason_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_REASON',prop:'SortedStatus'},{av:'Ddo_br_encounter_refusereason_freason_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_FREASON',prop:'SortedStatus'},{av:'Ddo_br_encounter_refusereason_fapprovedate_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE',prop:'SortedStatus'},{av:'AV33BR_Encounter_RefuseReason_ReasonTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASON_REASONTITLEFILTERDATA',pic:''},{av:'AV37BR_Encounter_RefuseReason_NoApproveDateTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATETITLEFILTERDATA',pic:''},{av:'AV49BR_Encounter_RefuseReason_FReasonTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASON_FREASONTITLEFILTERDATA',pic:''},{av:'AV53BR_Encounter_RefuseReason_FApproveDateTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASON_FAPPROVEDATETITLEFILTERDATA',pic:''},{av:'edtBR_Encounter_RefuseReason_Reason_Titleformat',ctrl:'BR_ENCOUNTER_REFUSEREASON_REASON',prop:'Titleformat'},{av:'edtBR_Encounter_RefuseReason_Reason_Title',ctrl:'BR_ENCOUNTER_REFUSEREASON_REASON',prop:'Title'},{av:'edtBR_Encounter_RefuseReason_NoApproveDate_Titleformat',ctrl:'BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'Titleformat'},{av:'edtBR_Encounter_RefuseReason_NoApproveDate_Title',ctrl:'BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'Title'},{av:'edtBR_Encounter_RefuseReason_FReason_Titleformat',ctrl:'BR_ENCOUNTER_REFUSEREASON_FREASON',prop:'Titleformat'},{av:'edtBR_Encounter_RefuseReason_FReason_Title',ctrl:'BR_ENCOUNTER_REFUSEREASON_FREASON',prop:'Title'},{av:'edtBR_Encounter_RefuseReason_FApproveDate_Titleformat',ctrl:'BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE',prop:'Titleformat'},{av:'edtBR_Encounter_RefuseReason_FApproveDate_Title',ctrl:'BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE',prop:'Title'},{av:'AV17GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV18GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV19GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_ENCOUNTER_REFUSEREASON_FREASON.ONOPTIONCLICKED","{handler:'E157D2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavBr_encounterreason_vstatus'},{av:'AV48BR_EncounterReason_vStatus',fld:'vBR_ENCOUNTERREASON_VSTATUS',pic:'ZZZ9'},{av:'AV26OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV27OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV34TFBR_Encounter_RefuseReason_Reason',fld:'vTFBR_ENCOUNTER_REFUSEREASON_REASON',pic:''},{av:'AV35TFBR_Encounter_RefuseReason_Reason_Sel',fld:'vTFBR_ENCOUNTER_REFUSEREASON_REASON_SEL',pic:''},{av:'AV38TFBR_Encounter_RefuseReason_NoApproveDate',fld:'vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',pic:'9999/99/99 99:99:99'},{av:'AV39TFBR_Encounter_RefuseReason_NoApproveDate_To',fld:'vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_TO',pic:'9999/99/99 99:99:99'},{av:'AV50TFBR_Encounter_RefuseReason_FReason',fld:'vTFBR_ENCOUNTER_REFUSEREASON_FREASON',pic:''},{av:'AV51TFBR_Encounter_RefuseReason_FReason_Sel',fld:'vTFBR_ENCOUNTER_REFUSEREASON_FREASON_SEL',pic:''},{av:'AV54TFBR_Encounter_RefuseReason_FApproveDate',fld:'vTFBR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE',pic:'9999/99/99 99:99:99'},{av:'AV55TFBR_Encounter_RefuseReason_FApproveDate_To',fld:'vTFBR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE_TO',pic:'9999/99/99 99:99:99'},{av:'AV13BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV36ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_REASONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV42ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV52ddo_BR_Encounter_RefuseReason_FReasonTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_FREASONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV58ddo_BR_Encounter_RefuseReason_FApproveDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV70Pgmname',fld:'vPGMNAME',pic:''},{av:'AV20IsAuthorized_BR_Encounter_RefuseReason_Reason',fld:'vISAUTHORIZED_BR_ENCOUNTER_REFUSEREASON_REASON',pic:'',hsh:true},{av:'Ddo_br_encounter_refusereason_freason_Activeeventkey',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_FREASON',prop:'ActiveEventKey'},{av:'Ddo_br_encounter_refusereason_freason_Filteredtext_get',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_FREASON',prop:'FilteredText_get'},{av:'Ddo_br_encounter_refusereason_freason_Selectedvalue_get',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_FREASON',prop:'SelectedValue_get'}]");
         setEventMetadata("DDO_BR_ENCOUNTER_REFUSEREASON_FREASON.ONOPTIONCLICKED",",oparms:[{av:'AV26OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV27OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_encounter_refusereason_freason_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_FREASON',prop:'SortedStatus'},{av:'AV50TFBR_Encounter_RefuseReason_FReason',fld:'vTFBR_ENCOUNTER_REFUSEREASON_FREASON',pic:''},{av:'AV51TFBR_Encounter_RefuseReason_FReason_Sel',fld:'vTFBR_ENCOUNTER_REFUSEREASON_FREASON_SEL',pic:''},{av:'Ddo_br_encounter_refusereason_reason_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_REASON',prop:'SortedStatus'},{av:'Ddo_br_encounter_refusereason_noapprovedate_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'SortedStatus'},{av:'Ddo_br_encounter_refusereason_fapprovedate_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE',prop:'SortedStatus'},{av:'AV33BR_Encounter_RefuseReason_ReasonTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASON_REASONTITLEFILTERDATA',pic:''},{av:'AV37BR_Encounter_RefuseReason_NoApproveDateTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATETITLEFILTERDATA',pic:''},{av:'AV49BR_Encounter_RefuseReason_FReasonTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASON_FREASONTITLEFILTERDATA',pic:''},{av:'AV53BR_Encounter_RefuseReason_FApproveDateTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASON_FAPPROVEDATETITLEFILTERDATA',pic:''},{av:'edtBR_Encounter_RefuseReason_Reason_Titleformat',ctrl:'BR_ENCOUNTER_REFUSEREASON_REASON',prop:'Titleformat'},{av:'edtBR_Encounter_RefuseReason_Reason_Title',ctrl:'BR_ENCOUNTER_REFUSEREASON_REASON',prop:'Title'},{av:'edtBR_Encounter_RefuseReason_NoApproveDate_Titleformat',ctrl:'BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'Titleformat'},{av:'edtBR_Encounter_RefuseReason_NoApproveDate_Title',ctrl:'BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'Title'},{av:'edtBR_Encounter_RefuseReason_FReason_Titleformat',ctrl:'BR_ENCOUNTER_REFUSEREASON_FREASON',prop:'Titleformat'},{av:'edtBR_Encounter_RefuseReason_FReason_Title',ctrl:'BR_ENCOUNTER_REFUSEREASON_FREASON',prop:'Title'},{av:'edtBR_Encounter_RefuseReason_FApproveDate_Titleformat',ctrl:'BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE',prop:'Titleformat'},{av:'edtBR_Encounter_RefuseReason_FApproveDate_Title',ctrl:'BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE',prop:'Title'},{av:'AV17GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV18GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV19GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE.ONOPTIONCLICKED","{handler:'E167D2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavBr_encounterreason_vstatus'},{av:'AV48BR_EncounterReason_vStatus',fld:'vBR_ENCOUNTERREASON_VSTATUS',pic:'ZZZ9'},{av:'AV26OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV27OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV34TFBR_Encounter_RefuseReason_Reason',fld:'vTFBR_ENCOUNTER_REFUSEREASON_REASON',pic:''},{av:'AV35TFBR_Encounter_RefuseReason_Reason_Sel',fld:'vTFBR_ENCOUNTER_REFUSEREASON_REASON_SEL',pic:''},{av:'AV38TFBR_Encounter_RefuseReason_NoApproveDate',fld:'vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',pic:'9999/99/99 99:99:99'},{av:'AV39TFBR_Encounter_RefuseReason_NoApproveDate_To',fld:'vTFBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_TO',pic:'9999/99/99 99:99:99'},{av:'AV50TFBR_Encounter_RefuseReason_FReason',fld:'vTFBR_ENCOUNTER_REFUSEREASON_FREASON',pic:''},{av:'AV51TFBR_Encounter_RefuseReason_FReason_Sel',fld:'vTFBR_ENCOUNTER_REFUSEREASON_FREASON_SEL',pic:''},{av:'AV54TFBR_Encounter_RefuseReason_FApproveDate',fld:'vTFBR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE',pic:'9999/99/99 99:99:99'},{av:'AV55TFBR_Encounter_RefuseReason_FApproveDate_To',fld:'vTFBR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE_TO',pic:'9999/99/99 99:99:99'},{av:'AV13BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV36ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_REASONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV42ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV52ddo_BR_Encounter_RefuseReason_FReasonTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_FREASONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV58ddo_BR_Encounter_RefuseReason_FApproveDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV70Pgmname',fld:'vPGMNAME',pic:''},{av:'AV20IsAuthorized_BR_Encounter_RefuseReason_Reason',fld:'vISAUTHORIZED_BR_ENCOUNTER_REFUSEREASON_REASON',pic:'',hsh:true},{av:'Ddo_br_encounter_refusereason_fapprovedate_Activeeventkey',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE',prop:'ActiveEventKey'},{av:'Ddo_br_encounter_refusereason_fapprovedate_Filteredtext_get',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE',prop:'FilteredText_get'},{av:'Ddo_br_encounter_refusereason_fapprovedate_Filteredtextto_get',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE',prop:'FilteredTextTo_get'}]");
         setEventMetadata("DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE.ONOPTIONCLICKED",",oparms:[{av:'AV26OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV27OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_encounter_refusereason_fapprovedate_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE',prop:'SortedStatus'},{av:'AV54TFBR_Encounter_RefuseReason_FApproveDate',fld:'vTFBR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE',pic:'9999/99/99 99:99:99'},{av:'AV55TFBR_Encounter_RefuseReason_FApproveDate_To',fld:'vTFBR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE_TO',pic:'9999/99/99 99:99:99'},{av:'Ddo_br_encounter_refusereason_reason_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_REASON',prop:'SortedStatus'},{av:'Ddo_br_encounter_refusereason_noapprovedate_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'SortedStatus'},{av:'Ddo_br_encounter_refusereason_freason_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_FREASON',prop:'SortedStatus'},{av:'AV33BR_Encounter_RefuseReason_ReasonTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASON_REASONTITLEFILTERDATA',pic:''},{av:'AV37BR_Encounter_RefuseReason_NoApproveDateTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATETITLEFILTERDATA',pic:''},{av:'AV49BR_Encounter_RefuseReason_FReasonTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASON_FREASONTITLEFILTERDATA',pic:''},{av:'AV53BR_Encounter_RefuseReason_FApproveDateTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASON_FAPPROVEDATETITLEFILTERDATA',pic:''},{av:'edtBR_Encounter_RefuseReason_Reason_Titleformat',ctrl:'BR_ENCOUNTER_REFUSEREASON_REASON',prop:'Titleformat'},{av:'edtBR_Encounter_RefuseReason_Reason_Title',ctrl:'BR_ENCOUNTER_REFUSEREASON_REASON',prop:'Title'},{av:'edtBR_Encounter_RefuseReason_NoApproveDate_Titleformat',ctrl:'BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'Titleformat'},{av:'edtBR_Encounter_RefuseReason_NoApproveDate_Title',ctrl:'BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'Title'},{av:'edtBR_Encounter_RefuseReason_FReason_Titleformat',ctrl:'BR_ENCOUNTER_REFUSEREASON_FREASON',prop:'Titleformat'},{av:'edtBR_Encounter_RefuseReason_FReason_Title',ctrl:'BR_ENCOUNTER_REFUSEREASON_FREASON',prop:'Title'},{av:'edtBR_Encounter_RefuseReason_FApproveDate_Titleformat',ctrl:'BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE',prop:'Titleformat'},{av:'edtBR_Encounter_RefuseReason_FApproveDate_Title',ctrl:'BR_ENCOUNTER_REFUSEREASON_FAPPROVEDATE',prop:'Title'},{av:'AV17GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV18GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV19GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("GRID.LOAD","{handler:'E197D2',iparms:[{av:'AV20IsAuthorized_BR_Encounter_RefuseReason_Reason',fld:'vISAUTHORIZED_BR_ENCOUNTER_REFUSEREASON_REASON',pic:'',hsh:true},{av:'A348BR_Encounter_RefuseReasonID',fld:'BR_ENCOUNTER_REFUSEREASONID',pic:'ZZZZZZZZZZZZZZZZZZ'}]");
         setEventMetadata("GRID.LOAD",",oparms:[{av:'edtBR_Encounter_RefuseReason_Reason_Link',ctrl:'BR_ENCOUNTER_REFUSEREASON_REASON',prop:'Link'}]}");
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
         Ddo_br_encounter_refusereason_reason_Activeeventkey = "";
         Ddo_br_encounter_refusereason_reason_Filteredtext_get = "";
         Ddo_br_encounter_refusereason_reason_Selectedvalue_get = "";
         Ddo_br_encounter_refusereason_noapprovedate_Activeeventkey = "";
         Ddo_br_encounter_refusereason_noapprovedate_Filteredtext_get = "";
         Ddo_br_encounter_refusereason_noapprovedate_Filteredtextto_get = "";
         Ddo_br_encounter_refusereason_freason_Activeeventkey = "";
         Ddo_br_encounter_refusereason_freason_Filteredtext_get = "";
         Ddo_br_encounter_refusereason_freason_Selectedvalue_get = "";
         Ddo_br_encounter_refusereason_fapprovedate_Activeeventkey = "";
         Ddo_br_encounter_refusereason_fapprovedate_Filteredtext_get = "";
         Ddo_br_encounter_refusereason_fapprovedate_Filteredtextto_get = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV34TFBR_Encounter_RefuseReason_Reason = "";
         AV35TFBR_Encounter_RefuseReason_Reason_Sel = "";
         AV38TFBR_Encounter_RefuseReason_NoApproveDate = (DateTime)(DateTime.MinValue);
         AV39TFBR_Encounter_RefuseReason_NoApproveDate_To = (DateTime)(DateTime.MinValue);
         AV50TFBR_Encounter_RefuseReason_FReason = "";
         AV51TFBR_Encounter_RefuseReason_FReason_Sel = "";
         AV54TFBR_Encounter_RefuseReason_FApproveDate = (DateTime)(DateTime.MinValue);
         AV55TFBR_Encounter_RefuseReason_FApproveDate_To = (DateTime)(DateTime.MinValue);
         AV36ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace = "";
         AV42ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace = "";
         AV52ddo_BR_Encounter_RefuseReason_FReasonTitleControlIdToReplace = "";
         AV58ddo_BR_Encounter_RefuseReason_FApproveDateTitleControlIdToReplace = "";
         AV70Pgmname = "";
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         AV43DDO_TitleSettingsIcons = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV33BR_Encounter_RefuseReason_ReasonTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV37BR_Encounter_RefuseReason_NoApproveDateTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV49BR_Encounter_RefuseReason_FReasonTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV53BR_Encounter_RefuseReason_FApproveDateTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         Ddo_br_encounter_refusereason_reason_Filteredtext_set = "";
         Ddo_br_encounter_refusereason_reason_Selectedvalue_set = "";
         Ddo_br_encounter_refusereason_reason_Sortedstatus = "";
         Ddo_br_encounter_refusereason_noapprovedate_Filteredtext_set = "";
         Ddo_br_encounter_refusereason_noapprovedate_Filteredtextto_set = "";
         Ddo_br_encounter_refusereason_noapprovedate_Sortedstatus = "";
         Ddo_br_encounter_refusereason_freason_Filteredtext_set = "";
         Ddo_br_encounter_refusereason_freason_Selectedvalue_set = "";
         Ddo_br_encounter_refusereason_freason_Sortedstatus = "";
         Ddo_br_encounter_refusereason_fapprovedate_Filteredtext_set = "";
         Ddo_br_encounter_refusereason_fapprovedate_Filteredtextto_set = "";
         Ddo_br_encounter_refusereason_fapprovedate_Sortedstatus = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         TempTags = "";
         GridContainer = new GXWebGrid( context);
         sStyleString = "";
         subGrid_Linesclass = "";
         GridColumn = new GXWebColumn();
         A349BR_Encounter_RefuseReason_Reason = "";
         A350BR_Encounter_RefuseReason_NoApproveDate = (DateTime)(DateTime.MinValue);
         A352BR_Encounter_RefuseReason_Approver = "";
         A355BR_Encounter_RefuseReason_FReason = "";
         A354BR_Encounter_RefuseReason_FApproveDate = (DateTime)(DateTime.MinValue);
         ucGridpaginationbar = new GXUserControl();
         ucDdo_br_encounter_refusereason_reason = new GXUserControl();
         ClassString = "";
         StyleString = "";
         ucDdo_br_encounter_refusereason_noapprovedate = new GXUserControl();
         ucDdo_br_encounter_refusereason_freason = new GXUserControl();
         ucDdo_br_encounter_refusereason_fapprovedate = new GXUserControl();
         ucWorkwithplusutilities1 = new GXUserControl();
         AV40DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDate = DateTime.MinValue;
         AV41DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDateTo = DateTime.MinValue;
         AV56DDO_BR_Encounter_RefuseReason_FApproveDateAuxDate = DateTime.MinValue;
         AV57DDO_BR_Encounter_RefuseReason_FApproveDateAuxDateTo = DateTime.MinValue;
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         scmdbuf = "";
         lV62BR_EnteringSubmitDetailDS_2_Tfbr_encounter_refusereason_reason = "";
         lV66BR_EnteringSubmitDetailDS_6_Tfbr_encounter_refusereason_freason = "";
         AV63BR_EnteringSubmitDetailDS_3_Tfbr_encounter_refusereason_reason_sel = "";
         AV62BR_EnteringSubmitDetailDS_2_Tfbr_encounter_refusereason_reason = "";
         AV64BR_EnteringSubmitDetailDS_4_Tfbr_encounter_refusereason_noapprovedate = (DateTime)(DateTime.MinValue);
         AV65BR_EnteringSubmitDetailDS_5_Tfbr_encounter_refusereason_noapprovedate_to = (DateTime)(DateTime.MinValue);
         AV67BR_EnteringSubmitDetailDS_7_Tfbr_encounter_refusereason_freason_sel = "";
         AV66BR_EnteringSubmitDetailDS_6_Tfbr_encounter_refusereason_freason = "";
         AV68BR_EnteringSubmitDetailDS_8_Tfbr_encounter_refusereason_fapprovedate = (DateTime)(DateTime.MinValue);
         AV69BR_EnteringSubmitDetailDS_9_Tfbr_encounter_refusereason_fapprovedate_to = (DateTime)(DateTime.MinValue);
         H007D2_A356BR_EncounterReason_vStatus = new short[1] ;
         H007D2_n356BR_EncounterReason_vStatus = new bool[] {false} ;
         H007D2_A354BR_Encounter_RefuseReason_FApproveDate = new DateTime[] {DateTime.MinValue} ;
         H007D2_n354BR_Encounter_RefuseReason_FApproveDate = new bool[] {false} ;
         H007D2_A355BR_Encounter_RefuseReason_FReason = new String[] {""} ;
         H007D2_n355BR_Encounter_RefuseReason_FReason = new bool[] {false} ;
         H007D2_A85BR_Information_ID = new long[1] ;
         H007D2_n85BR_Information_ID = new bool[] {false} ;
         H007D2_A353BR_EncounterReason_IsApprove = new bool[] {false} ;
         H007D2_n353BR_EncounterReason_IsApprove = new bool[] {false} ;
         H007D2_A352BR_Encounter_RefuseReason_Approver = new String[] {""} ;
         H007D2_n352BR_Encounter_RefuseReason_Approver = new bool[] {false} ;
         H007D2_A351BR_Encounter_RefuseReason_Status = new short[1] ;
         H007D2_n351BR_Encounter_RefuseReason_Status = new bool[] {false} ;
         H007D2_A350BR_Encounter_RefuseReason_NoApproveDate = new DateTime[] {DateTime.MinValue} ;
         H007D2_n350BR_Encounter_RefuseReason_NoApproveDate = new bool[] {false} ;
         H007D2_A349BR_Encounter_RefuseReason_Reason = new String[] {""} ;
         H007D2_n349BR_Encounter_RefuseReason_Reason = new bool[] {false} ;
         H007D2_A19BR_EncounterID = new long[1] ;
         H007D2_A348BR_Encounter_RefuseReasonID = new long[1] ;
         H007D3_AGRID_nRecordCount = new long[1] ;
         AV12BR_Encounter_RefuseReason = new SdtBR_Encounter_RefuseReason(context);
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV21WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         GridRow = new GXWebRow();
         AV28Session = context.GetSession();
         AV24GridState = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState(context);
         AV25GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
         AV22TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV15HTTPRequest = new GxHttpRequest( context);
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         ROClassString = "";
         GXCCtl = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_enteringsubmitdetail__default(),
            new Object[][] {
                new Object[] {
               H007D2_A356BR_EncounterReason_vStatus, H007D2_n356BR_EncounterReason_vStatus, H007D2_A354BR_Encounter_RefuseReason_FApproveDate, H007D2_n354BR_Encounter_RefuseReason_FApproveDate, H007D2_A355BR_Encounter_RefuseReason_FReason, H007D2_n355BR_Encounter_RefuseReason_FReason, H007D2_A85BR_Information_ID, H007D2_n85BR_Information_ID, H007D2_A353BR_EncounterReason_IsApprove, H007D2_n353BR_EncounterReason_IsApprove,
               H007D2_A352BR_Encounter_RefuseReason_Approver, H007D2_n352BR_Encounter_RefuseReason_Approver, H007D2_A351BR_Encounter_RefuseReason_Status, H007D2_n351BR_Encounter_RefuseReason_Status, H007D2_A350BR_Encounter_RefuseReason_NoApproveDate, H007D2_n350BR_Encounter_RefuseReason_NoApproveDate, H007D2_A349BR_Encounter_RefuseReason_Reason, H007D2_n349BR_Encounter_RefuseReason_Reason, H007D2_A19BR_EncounterID, H007D2_A348BR_Encounter_RefuseReasonID
               }
               , new Object[] {
               H007D3_AGRID_nRecordCount
               }
            }
         );
         AV70Pgmname = "BR_EnteringSubmitDetail";
         /* GeneXus formulas. */
         AV70Pgmname = "BR_EnteringSubmitDetail";
         context.Gx_err = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_GXsfl_17 ;
      private short nGXsfl_17_idx=1 ;
      private short GRID_nEOF ;
      private short AV48BR_EncounterReason_vStatus ;
      private short AV26OrderedBy ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short subGrid_Backcolorstyle ;
      private short subGrid_Titlebackstyle ;
      private short edtBR_Encounter_RefuseReason_Reason_Titleformat ;
      private short edtBR_Encounter_RefuseReason_NoApproveDate_Titleformat ;
      private short edtBR_Encounter_RefuseReason_FReason_Titleformat ;
      private short edtBR_Encounter_RefuseReason_FApproveDate_Titleformat ;
      private short subGrid_Sortable ;
      private short A351BR_Encounter_RefuseReason_Status ;
      private short subGrid_Allowselection ;
      private short subGrid_Allowhovering ;
      private short subGrid_Allowcollapsing ;
      private short subGrid_Collapsed ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short AV61BR_EnteringSubmitDetailDS_1_Br_encounterreason_vstatus ;
      private short A356BR_EncounterReason_vStatus ;
      private short nGXWrapped ;
      private short subGrid_Backstyle ;
      private int subGrid_Rows ;
      private int Gridpaginationbar_Rowsperpageselectedvalue ;
      private int Gridpaginationbar_Pagestoshow ;
      private int Ddo_br_encounter_refusereason_reason_Datalistupdateminimumcharacters ;
      private int Ddo_br_encounter_refusereason_freason_Datalistupdateminimumcharacters ;
      private int subGrid_Titlebackcolor ;
      private int subGrid_Allbackcolor ;
      private int subGrid_Selectedindex ;
      private int subGrid_Selectioncolor ;
      private int subGrid_Hoveringcolor ;
      private int edtavDdo_br_encounter_refusereason_reasontitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_encounter_refusereason_noapprovedatetitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_encounter_refusereason_freasontitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_encounter_refusereason_fapprovedatetitlecontrolidtoreplace_Visible ;
      private int edtavOrderedby_Visible ;
      private int edtavOrdereddsc_Visible ;
      private int edtavTfbr_encounter_refusereason_reason_Visible ;
      private int edtavTfbr_encounter_refusereason_reason_sel_Visible ;
      private int edtavTfbr_encounter_refusereason_noapprovedate_Visible ;
      private int edtavTfbr_encounter_refusereason_noapprovedate_to_Visible ;
      private int edtavTfbr_encounter_refusereason_freason_Visible ;
      private int edtavTfbr_encounter_refusereason_freason_sel_Visible ;
      private int edtavTfbr_encounter_refusereason_fapprovedate_Visible ;
      private int edtavTfbr_encounter_refusereason_fapprovedate_to_Visible ;
      private int subGrid_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int AV16PageToGo ;
      private int AV71GXV1 ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private long AV13BR_EncounterID ;
      private long wcpOAV13BR_EncounterID ;
      private long GRID_nFirstRecordOnPage ;
      private long AV17GridCurrentPage ;
      private long AV19GridRecordCount ;
      private long AV18GridPageSize ;
      private long A348BR_Encounter_RefuseReasonID ;
      private long A19BR_EncounterID ;
      private long A85BR_Information_ID ;
      private long GRID_nCurrentRecord ;
      private long GRID_nRecordCount ;
      private long AV6BR_Encounter_RefuseReasonID ;
      private String Gridpaginationbar_Selectedpage ;
      private String Ddo_br_encounter_refusereason_reason_Activeeventkey ;
      private String Ddo_br_encounter_refusereason_reason_Filteredtext_get ;
      private String Ddo_br_encounter_refusereason_reason_Selectedvalue_get ;
      private String Ddo_br_encounter_refusereason_noapprovedate_Activeeventkey ;
      private String Ddo_br_encounter_refusereason_noapprovedate_Filteredtext_get ;
      private String Ddo_br_encounter_refusereason_noapprovedate_Filteredtextto_get ;
      private String Ddo_br_encounter_refusereason_freason_Activeeventkey ;
      private String Ddo_br_encounter_refusereason_freason_Filteredtext_get ;
      private String Ddo_br_encounter_refusereason_freason_Selectedvalue_get ;
      private String Ddo_br_encounter_refusereason_fapprovedate_Activeeventkey ;
      private String Ddo_br_encounter_refusereason_fapprovedate_Filteredtext_get ;
      private String Ddo_br_encounter_refusereason_fapprovedate_Filteredtextto_get ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_17_idx="0001" ;
      private String AV70Pgmname ;
      private String GXKey ;
      private String sDynURL ;
      private String FormProcess ;
      private String bodyStyle ;
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
      private String Ddo_br_encounter_refusereason_freason_Caption ;
      private String Ddo_br_encounter_refusereason_freason_Tooltip ;
      private String Ddo_br_encounter_refusereason_freason_Cls ;
      private String Ddo_br_encounter_refusereason_freason_Filteredtext_set ;
      private String Ddo_br_encounter_refusereason_freason_Selectedvalue_set ;
      private String Ddo_br_encounter_refusereason_freason_Dropdownoptionstype ;
      private String Ddo_br_encounter_refusereason_freason_Titlecontrolidtoreplace ;
      private String Ddo_br_encounter_refusereason_freason_Sortedstatus ;
      private String Ddo_br_encounter_refusereason_freason_Filtertype ;
      private String Ddo_br_encounter_refusereason_freason_Datalisttype ;
      private String Ddo_br_encounter_refusereason_freason_Datalistproc ;
      private String Ddo_br_encounter_refusereason_freason_Sortasc ;
      private String Ddo_br_encounter_refusereason_freason_Sortdsc ;
      private String Ddo_br_encounter_refusereason_freason_Loadingdata ;
      private String Ddo_br_encounter_refusereason_freason_Cleanfilter ;
      private String Ddo_br_encounter_refusereason_freason_Noresultsfound ;
      private String Ddo_br_encounter_refusereason_freason_Searchbuttontext ;
      private String Ddo_br_encounter_refusereason_fapprovedate_Caption ;
      private String Ddo_br_encounter_refusereason_fapprovedate_Tooltip ;
      private String Ddo_br_encounter_refusereason_fapprovedate_Cls ;
      private String Ddo_br_encounter_refusereason_fapprovedate_Filteredtext_set ;
      private String Ddo_br_encounter_refusereason_fapprovedate_Filteredtextto_set ;
      private String Ddo_br_encounter_refusereason_fapprovedate_Dropdownoptionstype ;
      private String Ddo_br_encounter_refusereason_fapprovedate_Titlecontrolidtoreplace ;
      private String Ddo_br_encounter_refusereason_fapprovedate_Sortedstatus ;
      private String Ddo_br_encounter_refusereason_fapprovedate_Filtertype ;
      private String Ddo_br_encounter_refusereason_fapprovedate_Sortasc ;
      private String Ddo_br_encounter_refusereason_fapprovedate_Sortdsc ;
      private String Ddo_br_encounter_refusereason_fapprovedate_Cleanfilter ;
      private String Ddo_br_encounter_refusereason_fapprovedate_Rangefilterfrom ;
      private String Ddo_br_encounter_refusereason_fapprovedate_Rangefilterto ;
      private String Ddo_br_encounter_refusereason_fapprovedate_Searchbuttontext ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divLayoutmaintable_Internalname ;
      private String divTablemain_Internalname ;
      private String cmbavBr_encounterreason_vstatus_Internalname ;
      private String TempTags ;
      private String cmbavBr_encounterreason_vstatus_Jsonclick ;
      private String divGridtablewithpaginationbar_Internalname ;
      private String sStyleString ;
      private String subGrid_Internalname ;
      private String subGrid_Class ;
      private String subGrid_Linesclass ;
      private String edtBR_Encounter_RefuseReason_Reason_Title ;
      private String edtBR_Encounter_RefuseReason_NoApproveDate_Title ;
      private String edtBR_Encounter_RefuseReason_FReason_Title ;
      private String edtBR_Encounter_RefuseReason_FApproveDate_Title ;
      private String subGrid_Header ;
      private String edtBR_Encounter_RefuseReason_Reason_Link ;
      private String divHtml_gridpaginationbar_Internalname ;
      private String Gridpaginationbar_Internalname ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String Ddo_br_encounter_refusereason_reason_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String edtavDdo_br_encounter_refusereason_reasontitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_encounter_refusereason_noapprovedate_Internalname ;
      private String edtavDdo_br_encounter_refusereason_noapprovedatetitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_encounter_refusereason_freason_Internalname ;
      private String edtavDdo_br_encounter_refusereason_freasontitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_encounter_refusereason_fapprovedate_Internalname ;
      private String edtavDdo_br_encounter_refusereason_fapprovedatetitlecontrolidtoreplace_Internalname ;
      private String Workwithplusutilities1_Internalname ;
      private String edtavOrderedby_Internalname ;
      private String edtavOrderedby_Jsonclick ;
      private String edtavOrdereddsc_Internalname ;
      private String edtavOrdereddsc_Jsonclick ;
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
      private String edtavTfbr_encounter_refusereason_freason_Internalname ;
      private String edtavTfbr_encounter_refusereason_freason_sel_Internalname ;
      private String edtavTfbr_encounter_refusereason_fapprovedate_Internalname ;
      private String edtavTfbr_encounter_refusereason_fapprovedate_Jsonclick ;
      private String edtavTfbr_encounter_refusereason_fapprovedate_to_Internalname ;
      private String edtavTfbr_encounter_refusereason_fapprovedate_to_Jsonclick ;
      private String divDdo_br_encounter_refusereason_fapprovedateauxdates_Internalname ;
      private String edtavDdo_br_encounter_refusereason_fapprovedateauxdate_Internalname ;
      private String edtavDdo_br_encounter_refusereason_fapprovedateauxdate_Jsonclick ;
      private String edtavDdo_br_encounter_refusereason_fapprovedateauxdateto_Internalname ;
      private String edtavDdo_br_encounter_refusereason_fapprovedateauxdateto_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtBR_Encounter_RefuseReasonID_Internalname ;
      private String edtBR_EncounterID_Internalname ;
      private String edtBR_Encounter_RefuseReason_Reason_Internalname ;
      private String edtBR_Encounter_RefuseReason_NoApproveDate_Internalname ;
      private String cmbBR_Encounter_RefuseReason_Status_Internalname ;
      private String edtBR_Encounter_RefuseReason_Approver_Internalname ;
      private String chkBR_EncounterReason_IsApprove_Internalname ;
      private String edtBR_Information_ID_Internalname ;
      private String edtBR_Encounter_RefuseReason_FReason_Internalname ;
      private String edtBR_Encounter_RefuseReason_FApproveDate_Internalname ;
      private String scmdbuf ;
      private String sGXsfl_17_fel_idx="0001" ;
      private String ROClassString ;
      private String edtBR_Encounter_RefuseReasonID_Jsonclick ;
      private String edtBR_EncounterID_Jsonclick ;
      private String edtBR_Encounter_RefuseReason_Reason_Jsonclick ;
      private String edtBR_Encounter_RefuseReason_NoApproveDate_Jsonclick ;
      private String GXCCtl ;
      private String cmbBR_Encounter_RefuseReason_Status_Jsonclick ;
      private String edtBR_Encounter_RefuseReason_Approver_Jsonclick ;
      private String edtBR_Information_ID_Jsonclick ;
      private String edtBR_Encounter_RefuseReason_FReason_Jsonclick ;
      private String edtBR_Encounter_RefuseReason_FApproveDate_Jsonclick ;
      private DateTime AV38TFBR_Encounter_RefuseReason_NoApproveDate ;
      private DateTime AV39TFBR_Encounter_RefuseReason_NoApproveDate_To ;
      private DateTime AV54TFBR_Encounter_RefuseReason_FApproveDate ;
      private DateTime AV55TFBR_Encounter_RefuseReason_FApproveDate_To ;
      private DateTime A350BR_Encounter_RefuseReason_NoApproveDate ;
      private DateTime A354BR_Encounter_RefuseReason_FApproveDate ;
      private DateTime AV64BR_EnteringSubmitDetailDS_4_Tfbr_encounter_refusereason_noapprovedate ;
      private DateTime AV65BR_EnteringSubmitDetailDS_5_Tfbr_encounter_refusereason_noapprovedate_to ;
      private DateTime AV68BR_EnteringSubmitDetailDS_8_Tfbr_encounter_refusereason_fapprovedate ;
      private DateTime AV69BR_EnteringSubmitDetailDS_9_Tfbr_encounter_refusereason_fapprovedate_to ;
      private DateTime AV40DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDate ;
      private DateTime AV41DDO_BR_Encounter_RefuseReason_NoApproveDateAuxDateTo ;
      private DateTime AV56DDO_BR_Encounter_RefuseReason_FApproveDateAuxDate ;
      private DateTime AV57DDO_BR_Encounter_RefuseReason_FApproveDateAuxDateTo ;
      private bool entryPointCalled ;
      private bool AV27OrderedDsc ;
      private bool AV20IsAuthorized_BR_Encounter_RefuseReason_Reason ;
      private bool toggleJsOutput ;
      private bool Gridpaginationbar_Showfirst ;
      private bool Gridpaginationbar_Showprevious ;
      private bool Gridpaginationbar_Shownext ;
      private bool Gridpaginationbar_Showlast ;
      private bool Gridpaginationbar_Rowsperpageselector ;
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
      private bool Ddo_br_encounter_refusereason_freason_Includesortasc ;
      private bool Ddo_br_encounter_refusereason_freason_Includesortdsc ;
      private bool Ddo_br_encounter_refusereason_freason_Includefilter ;
      private bool Ddo_br_encounter_refusereason_freason_Filterisrange ;
      private bool Ddo_br_encounter_refusereason_freason_Includedatalist ;
      private bool Ddo_br_encounter_refusereason_fapprovedate_Includesortasc ;
      private bool Ddo_br_encounter_refusereason_fapprovedate_Includesortdsc ;
      private bool Ddo_br_encounter_refusereason_fapprovedate_Includefilter ;
      private bool Ddo_br_encounter_refusereason_fapprovedate_Filterisrange ;
      private bool Ddo_br_encounter_refusereason_fapprovedate_Includedatalist ;
      private bool wbLoad ;
      private bool A353BR_EncounterReason_IsApprove ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool n349BR_Encounter_RefuseReason_Reason ;
      private bool n350BR_Encounter_RefuseReason_NoApproveDate ;
      private bool n351BR_Encounter_RefuseReason_Status ;
      private bool n352BR_Encounter_RefuseReason_Approver ;
      private bool n353BR_EncounterReason_IsApprove ;
      private bool n85BR_Information_ID ;
      private bool n355BR_Encounter_RefuseReason_FReason ;
      private bool n354BR_Encounter_RefuseReason_FApproveDate ;
      private bool bGXsfl_17_Refreshing=false ;
      private bool gxdyncontrolsrefreshing ;
      private bool n356BR_EncounterReason_vStatus ;
      private bool returnInSub ;
      private bool GXt_boolean1 ;
      private bool gx_refresh_fired ;
      private String AV34TFBR_Encounter_RefuseReason_Reason ;
      private String AV35TFBR_Encounter_RefuseReason_Reason_Sel ;
      private String AV50TFBR_Encounter_RefuseReason_FReason ;
      private String AV51TFBR_Encounter_RefuseReason_FReason_Sel ;
      private String AV36ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace ;
      private String AV42ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace ;
      private String AV52ddo_BR_Encounter_RefuseReason_FReasonTitleControlIdToReplace ;
      private String AV58ddo_BR_Encounter_RefuseReason_FApproveDateTitleControlIdToReplace ;
      private String A349BR_Encounter_RefuseReason_Reason ;
      private String A352BR_Encounter_RefuseReason_Approver ;
      private String A355BR_Encounter_RefuseReason_FReason ;
      private String lV62BR_EnteringSubmitDetailDS_2_Tfbr_encounter_refusereason_reason ;
      private String lV66BR_EnteringSubmitDetailDS_6_Tfbr_encounter_refusereason_freason ;
      private String AV63BR_EnteringSubmitDetailDS_3_Tfbr_encounter_refusereason_reason_sel ;
      private String AV62BR_EnteringSubmitDetailDS_2_Tfbr_encounter_refusereason_reason ;
      private String AV67BR_EnteringSubmitDetailDS_7_Tfbr_encounter_refusereason_freason_sel ;
      private String AV66BR_EnteringSubmitDetailDS_6_Tfbr_encounter_refusereason_freason ;
      private IGxSession AV28Session ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private GXUserControl ucGridpaginationbar ;
      private GXUserControl ucDdo_br_encounter_refusereason_reason ;
      private GXUserControl ucDdo_br_encounter_refusereason_noapprovedate ;
      private GXUserControl ucDdo_br_encounter_refusereason_freason ;
      private GXUserControl ucDdo_br_encounter_refusereason_fapprovedate ;
      private GXUserControl ucWorkwithplusutilities1 ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbavBr_encounterreason_vstatus ;
      private GXCombobox cmbBR_Encounter_RefuseReason_Status ;
      private GXCheckbox chkBR_EncounterReason_IsApprove ;
      private IDataStoreProvider pr_default ;
      private short[] H007D2_A356BR_EncounterReason_vStatus ;
      private bool[] H007D2_n356BR_EncounterReason_vStatus ;
      private DateTime[] H007D2_A354BR_Encounter_RefuseReason_FApproveDate ;
      private bool[] H007D2_n354BR_Encounter_RefuseReason_FApproveDate ;
      private String[] H007D2_A355BR_Encounter_RefuseReason_FReason ;
      private bool[] H007D2_n355BR_Encounter_RefuseReason_FReason ;
      private long[] H007D2_A85BR_Information_ID ;
      private bool[] H007D2_n85BR_Information_ID ;
      private bool[] H007D2_A353BR_EncounterReason_IsApprove ;
      private bool[] H007D2_n353BR_EncounterReason_IsApprove ;
      private String[] H007D2_A352BR_Encounter_RefuseReason_Approver ;
      private bool[] H007D2_n352BR_Encounter_RefuseReason_Approver ;
      private short[] H007D2_A351BR_Encounter_RefuseReason_Status ;
      private bool[] H007D2_n351BR_Encounter_RefuseReason_Status ;
      private DateTime[] H007D2_A350BR_Encounter_RefuseReason_NoApproveDate ;
      private bool[] H007D2_n350BR_Encounter_RefuseReason_NoApproveDate ;
      private String[] H007D2_A349BR_Encounter_RefuseReason_Reason ;
      private bool[] H007D2_n349BR_Encounter_RefuseReason_Reason ;
      private long[] H007D2_A19BR_EncounterID ;
      private long[] H007D2_A348BR_Encounter_RefuseReasonID ;
      private long[] H007D3_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV15HTTPRequest ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV33BR_Encounter_RefuseReason_ReasonTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV37BR_Encounter_RefuseReason_NoApproveDateTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV49BR_Encounter_RefuseReason_FReasonTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV53BR_Encounter_RefuseReason_FApproveDateTitleFilterData ;
      private GXWebForm Form ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV21WWPContext ;
      private SdtBR_Encounter_RefuseReason AV12BR_Encounter_RefuseReason ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV22TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV24GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue AV25GridStateFilterValue ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons AV43DDO_TitleSettingsIcons ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 ;
   }

   public class br_enteringsubmitdetail__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H007D2( IGxContext context ,
                                             short AV61BR_EnteringSubmitDetailDS_1_Br_encounterreason_vstatus ,
                                             String AV63BR_EnteringSubmitDetailDS_3_Tfbr_encounter_refusereason_reason_sel ,
                                             String AV62BR_EnteringSubmitDetailDS_2_Tfbr_encounter_refusereason_reason ,
                                             DateTime AV64BR_EnteringSubmitDetailDS_4_Tfbr_encounter_refusereason_noapprovedate ,
                                             DateTime AV65BR_EnteringSubmitDetailDS_5_Tfbr_encounter_refusereason_noapprovedate_to ,
                                             String AV67BR_EnteringSubmitDetailDS_7_Tfbr_encounter_refusereason_freason_sel ,
                                             String AV66BR_EnteringSubmitDetailDS_6_Tfbr_encounter_refusereason_freason ,
                                             DateTime AV68BR_EnteringSubmitDetailDS_8_Tfbr_encounter_refusereason_fapprovedate ,
                                             DateTime AV69BR_EnteringSubmitDetailDS_9_Tfbr_encounter_refusereason_fapprovedate_to ,
                                             short A356BR_EncounterReason_vStatus ,
                                             String A349BR_Encounter_RefuseReason_Reason ,
                                             DateTime A350BR_Encounter_RefuseReason_NoApproveDate ,
                                             String A355BR_Encounter_RefuseReason_FReason ,
                                             DateTime A354BR_Encounter_RefuseReason_FApproveDate ,
                                             short AV26OrderedBy ,
                                             bool AV27OrderedDsc ,
                                             long A19BR_EncounterID ,
                                             long AV13BR_EncounterID )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int3 ;
         GXv_int3 = new short [13] ;
         Object[] GXv_Object4 ;
         GXv_Object4 = new Object [2] ;
         String sSelectString ;
         String sFromString ;
         String sOrderString ;
         sSelectString = " T1.[BR_EncounterReason_vStatus], T1.[BR_Encounter_RefuseReason_FApproveDate], T1.[BR_Encounter_RefuseReason_FReason], T2.[BR_Information_ID], T1.[BR_EncounterReason_IsApprove], T1.[BR_Encounter_RefuseReason_Approver], T1.[BR_Encounter_RefuseReason_Status], T1.[BR_Encounter_RefuseReason_NoApproveDate], T1.[BR_Encounter_RefuseReason_Reason], T1.[BR_EncounterID], T1.[BR_Encounter_RefuseReasonID]";
         sFromString = " FROM ([BR_Encounter_RefuseReason] T1 WITH (NOLOCK) INNER JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = T1.[BR_EncounterID])";
         sOrderString = "";
         sWhereString = sWhereString + " WHERE (T1.[BR_EncounterID] = @AV13BR_EncounterID)";
         if ( ! (0==AV61BR_EnteringSubmitDetailDS_1_Br_encounterreason_vstatus) )
         {
            sWhereString = sWhereString + " and (T1.[BR_EncounterReason_vStatus] = @AV61BR_EnteringSubmitDetailDS_1_Br_encounterreason_vstatus)";
         }
         else
         {
            GXv_int3[1] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV63BR_EnteringSubmitDetailDS_3_Tfbr_encounter_refusereason_reason_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV62BR_EnteringSubmitDetailDS_2_Tfbr_encounter_refusereason_reason)) ) )
         {
            sWhereString = sWhereString + " and (T1.[BR_Encounter_RefuseReason_Reason] like @lV62BR_EnteringSubmitDetailDS_2_Tfbr_encounter_refusereason_reason)";
         }
         else
         {
            GXv_int3[2] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV63BR_EnteringSubmitDetailDS_3_Tfbr_encounter_refusereason_reason_sel)) )
         {
            sWhereString = sWhereString + " and (T1.[BR_Encounter_RefuseReason_Reason] = @AV63BR_EnteringSubmitDetailDS_3_Tfbr_encounter_refusereason_reason_sel)";
         }
         else
         {
            GXv_int3[3] = 1;
         }
         if ( ! (DateTime.MinValue==AV64BR_EnteringSubmitDetailDS_4_Tfbr_encounter_refusereason_noapprovedate) )
         {
            sWhereString = sWhereString + " and (T1.[BR_Encounter_RefuseReason_NoApproveDate] >= @AV64BR_EnteringSubmitDetailDS_4_Tfbr_encounter_refusereason_noapprovedate)";
         }
         else
         {
            GXv_int3[4] = 1;
         }
         if ( ! (DateTime.MinValue==AV65BR_EnteringSubmitDetailDS_5_Tfbr_encounter_refusereason_noapprovedate_to) )
         {
            sWhereString = sWhereString + " and (T1.[BR_Encounter_RefuseReason_NoApproveDate] <= @AV65BR_EnteringSubmitDetailDS_5_Tfbr_encounter_refusereason_noapprovedate_to)";
         }
         else
         {
            GXv_int3[5] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV67BR_EnteringSubmitDetailDS_7_Tfbr_encounter_refusereason_freason_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV66BR_EnteringSubmitDetailDS_6_Tfbr_encounter_refusereason_freason)) ) )
         {
            sWhereString = sWhereString + " and (T1.[BR_Encounter_RefuseReason_FReason] like @lV66BR_EnteringSubmitDetailDS_6_Tfbr_encounter_refusereason_freason)";
         }
         else
         {
            GXv_int3[6] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV67BR_EnteringSubmitDetailDS_7_Tfbr_encounter_refusereason_freason_sel)) )
         {
            sWhereString = sWhereString + " and (T1.[BR_Encounter_RefuseReason_FReason] = @AV67BR_EnteringSubmitDetailDS_7_Tfbr_encounter_refusereason_freason_sel)";
         }
         else
         {
            GXv_int3[7] = 1;
         }
         if ( ! (DateTime.MinValue==AV68BR_EnteringSubmitDetailDS_8_Tfbr_encounter_refusereason_fapprovedate) )
         {
            sWhereString = sWhereString + " and (T1.[BR_Encounter_RefuseReason_FApproveDate] >= @AV68BR_EnteringSubmitDetailDS_8_Tfbr_encounter_refusereason_fapprovedate)";
         }
         else
         {
            GXv_int3[8] = 1;
         }
         if ( ! (DateTime.MinValue==AV69BR_EnteringSubmitDetailDS_9_Tfbr_encounter_refusereason_fapprovedate_to) )
         {
            sWhereString = sWhereString + " and (T1.[BR_Encounter_RefuseReason_FApproveDate] <= @AV69BR_EnteringSubmitDetailDS_9_Tfbr_encounter_refusereason_fapprovedate_to)";
         }
         else
         {
            GXv_int3[9] = 1;
         }
         if ( ( AV26OrderedBy == 1 ) && ! AV27OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Encounter_RefuseReason_NoApproveDate]";
         }
         else if ( ( AV26OrderedBy == 1 ) && ( AV27OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Encounter_RefuseReason_NoApproveDate] DESC";
         }
         else if ( ( AV26OrderedBy == 2 ) && ! AV27OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Encounter_RefuseReason_Reason]";
         }
         else if ( ( AV26OrderedBy == 2 ) && ( AV27OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Encounter_RefuseReason_Reason] DESC";
         }
         else if ( ( AV26OrderedBy == 3 ) && ! AV27OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Encounter_RefuseReason_FReason]";
         }
         else if ( ( AV26OrderedBy == 3 ) && ( AV27OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Encounter_RefuseReason_FReason] DESC";
         }
         else if ( ( AV26OrderedBy == 4 ) && ! AV27OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Encounter_RefuseReason_FApproveDate]";
         }
         else if ( ( AV26OrderedBy == 4 ) && ( AV27OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Encounter_RefuseReason_FApproveDate] DESC";
         }
         else if ( true )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Encounter_RefuseReasonID]";
         }
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object4[0] = scmdbuf;
         GXv_Object4[1] = GXv_int3;
         return GXv_Object4 ;
      }

      protected Object[] conditional_H007D3( IGxContext context ,
                                             short AV61BR_EnteringSubmitDetailDS_1_Br_encounterreason_vstatus ,
                                             String AV63BR_EnteringSubmitDetailDS_3_Tfbr_encounter_refusereason_reason_sel ,
                                             String AV62BR_EnteringSubmitDetailDS_2_Tfbr_encounter_refusereason_reason ,
                                             DateTime AV64BR_EnteringSubmitDetailDS_4_Tfbr_encounter_refusereason_noapprovedate ,
                                             DateTime AV65BR_EnteringSubmitDetailDS_5_Tfbr_encounter_refusereason_noapprovedate_to ,
                                             String AV67BR_EnteringSubmitDetailDS_7_Tfbr_encounter_refusereason_freason_sel ,
                                             String AV66BR_EnteringSubmitDetailDS_6_Tfbr_encounter_refusereason_freason ,
                                             DateTime AV68BR_EnteringSubmitDetailDS_8_Tfbr_encounter_refusereason_fapprovedate ,
                                             DateTime AV69BR_EnteringSubmitDetailDS_9_Tfbr_encounter_refusereason_fapprovedate_to ,
                                             short A356BR_EncounterReason_vStatus ,
                                             String A349BR_Encounter_RefuseReason_Reason ,
                                             DateTime A350BR_Encounter_RefuseReason_NoApproveDate ,
                                             String A355BR_Encounter_RefuseReason_FReason ,
                                             DateTime A354BR_Encounter_RefuseReason_FApproveDate ,
                                             short AV26OrderedBy ,
                                             bool AV27OrderedDsc ,
                                             long A19BR_EncounterID ,
                                             long AV13BR_EncounterID )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int5 ;
         GXv_int5 = new short [10] ;
         Object[] GXv_Object6 ;
         GXv_Object6 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM ([BR_Encounter_RefuseReason] T1 WITH (NOLOCK) INNER JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = T1.[BR_EncounterID])";
         scmdbuf = scmdbuf + " WHERE (T1.[BR_EncounterID] = @AV13BR_EncounterID)";
         if ( ! (0==AV61BR_EnteringSubmitDetailDS_1_Br_encounterreason_vstatus) )
         {
            sWhereString = sWhereString + " and (T1.[BR_EncounterReason_vStatus] = @AV61BR_EnteringSubmitDetailDS_1_Br_encounterreason_vstatus)";
         }
         else
         {
            GXv_int5[1] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV63BR_EnteringSubmitDetailDS_3_Tfbr_encounter_refusereason_reason_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV62BR_EnteringSubmitDetailDS_2_Tfbr_encounter_refusereason_reason)) ) )
         {
            sWhereString = sWhereString + " and (T1.[BR_Encounter_RefuseReason_Reason] like @lV62BR_EnteringSubmitDetailDS_2_Tfbr_encounter_refusereason_reason)";
         }
         else
         {
            GXv_int5[2] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV63BR_EnteringSubmitDetailDS_3_Tfbr_encounter_refusereason_reason_sel)) )
         {
            sWhereString = sWhereString + " and (T1.[BR_Encounter_RefuseReason_Reason] = @AV63BR_EnteringSubmitDetailDS_3_Tfbr_encounter_refusereason_reason_sel)";
         }
         else
         {
            GXv_int5[3] = 1;
         }
         if ( ! (DateTime.MinValue==AV64BR_EnteringSubmitDetailDS_4_Tfbr_encounter_refusereason_noapprovedate) )
         {
            sWhereString = sWhereString + " and (T1.[BR_Encounter_RefuseReason_NoApproveDate] >= @AV64BR_EnteringSubmitDetailDS_4_Tfbr_encounter_refusereason_noapprovedate)";
         }
         else
         {
            GXv_int5[4] = 1;
         }
         if ( ! (DateTime.MinValue==AV65BR_EnteringSubmitDetailDS_5_Tfbr_encounter_refusereason_noapprovedate_to) )
         {
            sWhereString = sWhereString + " and (T1.[BR_Encounter_RefuseReason_NoApproveDate] <= @AV65BR_EnteringSubmitDetailDS_5_Tfbr_encounter_refusereason_noapprovedate_to)";
         }
         else
         {
            GXv_int5[5] = 1;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( AV67BR_EnteringSubmitDetailDS_7_Tfbr_encounter_refusereason_freason_sel)) && ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV66BR_EnteringSubmitDetailDS_6_Tfbr_encounter_refusereason_freason)) ) )
         {
            sWhereString = sWhereString + " and (T1.[BR_Encounter_RefuseReason_FReason] like @lV66BR_EnteringSubmitDetailDS_6_Tfbr_encounter_refusereason_freason)";
         }
         else
         {
            GXv_int5[6] = 1;
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( AV67BR_EnteringSubmitDetailDS_7_Tfbr_encounter_refusereason_freason_sel)) )
         {
            sWhereString = sWhereString + " and (T1.[BR_Encounter_RefuseReason_FReason] = @AV67BR_EnteringSubmitDetailDS_7_Tfbr_encounter_refusereason_freason_sel)";
         }
         else
         {
            GXv_int5[7] = 1;
         }
         if ( ! (DateTime.MinValue==AV68BR_EnteringSubmitDetailDS_8_Tfbr_encounter_refusereason_fapprovedate) )
         {
            sWhereString = sWhereString + " and (T1.[BR_Encounter_RefuseReason_FApproveDate] >= @AV68BR_EnteringSubmitDetailDS_8_Tfbr_encounter_refusereason_fapprovedate)";
         }
         else
         {
            GXv_int5[8] = 1;
         }
         if ( ! (DateTime.MinValue==AV69BR_EnteringSubmitDetailDS_9_Tfbr_encounter_refusereason_fapprovedate_to) )
         {
            sWhereString = sWhereString + " and (T1.[BR_Encounter_RefuseReason_FApproveDate] <= @AV69BR_EnteringSubmitDetailDS_9_Tfbr_encounter_refusereason_fapprovedate_to)";
         }
         else
         {
            GXv_int5[9] = 1;
         }
         scmdbuf = scmdbuf + sWhereString;
         if ( ( AV26OrderedBy == 1 ) && ! AV27OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV26OrderedBy == 1 ) && ( AV27OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV26OrderedBy == 2 ) && ! AV27OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV26OrderedBy == 2 ) && ( AV27OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV26OrderedBy == 3 ) && ! AV27OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV26OrderedBy == 3 ) && ( AV27OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV26OrderedBy == 4 ) && ! AV27OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV26OrderedBy == 4 ) && ( AV27OrderedDsc ) )
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
                     return conditional_H007D2(context, (short)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] , (DateTime)dynConstraints[3] , (DateTime)dynConstraints[4] , (String)dynConstraints[5] , (String)dynConstraints[6] , (DateTime)dynConstraints[7] , (DateTime)dynConstraints[8] , (short)dynConstraints[9] , (String)dynConstraints[10] , (DateTime)dynConstraints[11] , (String)dynConstraints[12] , (DateTime)dynConstraints[13] , (short)dynConstraints[14] , (bool)dynConstraints[15] , (long)dynConstraints[16] , (long)dynConstraints[17] );
               case 1 :
                     return conditional_H007D3(context, (short)dynConstraints[0] , (String)dynConstraints[1] , (String)dynConstraints[2] , (DateTime)dynConstraints[3] , (DateTime)dynConstraints[4] , (String)dynConstraints[5] , (String)dynConstraints[6] , (DateTime)dynConstraints[7] , (DateTime)dynConstraints[8] , (short)dynConstraints[9] , (String)dynConstraints[10] , (DateTime)dynConstraints[11] , (String)dynConstraints[12] , (DateTime)dynConstraints[13] , (short)dynConstraints[14] , (bool)dynConstraints[15] , (long)dynConstraints[16] , (long)dynConstraints[17] );
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
          Object[] prmH007D2 ;
          prmH007D2 = new Object[] {
          new Object[] {"@AV13BR_EncounterID",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV61BR_EnteringSubmitDetailDS_1_Br_encounterreason_vstatus",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@lV62BR_EnteringSubmitDetailDS_2_Tfbr_encounter_refusereason_reason",SqlDbType.NVarChar,300,0} ,
          new Object[] {"@AV63BR_EnteringSubmitDetailDS_3_Tfbr_encounter_refusereason_reason_sel",SqlDbType.NVarChar,300,0} ,
          new Object[] {"@AV64BR_EnteringSubmitDetailDS_4_Tfbr_encounter_refusereason_noapprovedate",SqlDbType.DateTime,10,8} ,
          new Object[] {"@AV65BR_EnteringSubmitDetailDS_5_Tfbr_encounter_refusereason_noapprovedate_to",SqlDbType.DateTime,10,8} ,
          new Object[] {"@lV66BR_EnteringSubmitDetailDS_6_Tfbr_encounter_refusereason_freason",SqlDbType.NVarChar,300,0} ,
          new Object[] {"@AV67BR_EnteringSubmitDetailDS_7_Tfbr_encounter_refusereason_freason_sel",SqlDbType.NVarChar,300,0} ,
          new Object[] {"@AV68BR_EnteringSubmitDetailDS_8_Tfbr_encounter_refusereason_fapprovedate",SqlDbType.DateTime,10,8} ,
          new Object[] {"@AV69BR_EnteringSubmitDetailDS_9_Tfbr_encounter_refusereason_fapprovedate_to",SqlDbType.DateTime,10,8} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH007D3 ;
          prmH007D3 = new Object[] {
          new Object[] {"@AV13BR_EncounterID",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV61BR_EnteringSubmitDetailDS_1_Br_encounterreason_vstatus",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@lV62BR_EnteringSubmitDetailDS_2_Tfbr_encounter_refusereason_reason",SqlDbType.NVarChar,300,0} ,
          new Object[] {"@AV63BR_EnteringSubmitDetailDS_3_Tfbr_encounter_refusereason_reason_sel",SqlDbType.NVarChar,300,0} ,
          new Object[] {"@AV64BR_EnteringSubmitDetailDS_4_Tfbr_encounter_refusereason_noapprovedate",SqlDbType.DateTime,10,8} ,
          new Object[] {"@AV65BR_EnteringSubmitDetailDS_5_Tfbr_encounter_refusereason_noapprovedate_to",SqlDbType.DateTime,10,8} ,
          new Object[] {"@lV66BR_EnteringSubmitDetailDS_6_Tfbr_encounter_refusereason_freason",SqlDbType.NVarChar,300,0} ,
          new Object[] {"@AV67BR_EnteringSubmitDetailDS_7_Tfbr_encounter_refusereason_freason_sel",SqlDbType.NVarChar,300,0} ,
          new Object[] {"@AV68BR_EnteringSubmitDetailDS_8_Tfbr_encounter_refusereason_fapprovedate",SqlDbType.DateTime,10,8} ,
          new Object[] {"@AV69BR_EnteringSubmitDetailDS_9_Tfbr_encounter_refusereason_fapprovedate_to",SqlDbType.DateTime,10,8}
          } ;
          def= new CursorDef[] {
              new CursorDef("H007D2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH007D2,11,0,true,false )
             ,new CursorDef("H007D3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH007D3,1,0,true,false )
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
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((bool[]) buf[8])[0] = rslt.getBool(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((String[]) buf[10])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(6);
                ((short[]) buf[12])[0] = rslt.getShort(7) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(7);
                ((DateTime[]) buf[14])[0] = rslt.getGXDateTime(8) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(8);
                ((String[]) buf[16])[0] = rslt.getVarchar(9) ;
                ((bool[]) buf[17])[0] = rslt.wasNull(9);
                ((long[]) buf[18])[0] = rslt.getLong(10) ;
                ((long[]) buf[19])[0] = rslt.getLong(11) ;
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
                   stmt.SetParameter(sIdx, (long)parms[13]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[14]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[15]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[16]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameterDatetime(sIdx, (DateTime)parms[17]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameterDatetime(sIdx, (DateTime)parms[18]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[19]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[20]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameterDatetime(sIdx, (DateTime)parms[21]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameterDatetime(sIdx, (DateTime)parms[22]);
                }
                if ( (short)parms[10] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[23]);
                }
                if ( (short)parms[11] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[24]);
                }
                if ( (short)parms[12] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[25]);
                }
                return;
             case 1 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[10]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[11]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[12]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[13]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameterDatetime(sIdx, (DateTime)parms[14]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameterDatetime(sIdx, (DateTime)parms[15]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[16]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (String)parms[17]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameterDatetime(sIdx, (DateTime)parms[18]);
                }
                if ( (short)parms[9] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameterDatetime(sIdx, (DateTime)parms[19]);
                }
                return;
       }
    }

 }

}
