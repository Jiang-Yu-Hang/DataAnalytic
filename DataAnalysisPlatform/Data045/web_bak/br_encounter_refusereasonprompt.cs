/*
               File: BR_Encounter_RefuseReasonPrompt
        Description: 选择就诊信息驳回原因
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:46:47.72
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
   public class br_encounter_refusereasonprompt : GXHttpHandler, System.Web.SessionState.IRequiresSessionState
   {
      public br_encounter_refusereasonprompt( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_encounter_refusereasonprompt( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( ref long aP0_InOutBR_Encounter_RefuseReasonID ,
                           ref String aP1_InOutBR_Encounter_RefuseReason_Reason )
      {
         this.AV8InOutBR_Encounter_RefuseReasonID = aP0_InOutBR_Encounter_RefuseReasonID;
         this.AV9InOutBR_Encounter_RefuseReason_Reason = aP1_InOutBR_Encounter_RefuseReason_Reason;
         executePrivate();
         aP0_InOutBR_Encounter_RefuseReasonID=this.AV8InOutBR_Encounter_RefuseReasonID;
         aP1_InOutBR_Encounter_RefuseReason_Reason=this.AV9InOutBR_Encounter_RefuseReason_Reason;
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
               nRC_GXsfl_12 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               nGXsfl_12_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
               sGXsfl_12_idx = GetNextPar( );
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
               AV11OrderedBy = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV12OrderedDsc = StringUtil.StrToBool( GetNextPar( ));
               AV14ddo_BR_Encounter_RefuseReasonIDTitleControlIdToReplace = GetNextPar( );
               AV16ddo_BR_EncounterIDTitleControlIdToReplace = GetNextPar( );
               AV18ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace = GetNextPar( );
               AV20ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace = GetNextPar( );
               AV22ddo_BR_Encounter_RefuseReason_StatusTitleControlIdToReplace = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_BR_Encounter_RefuseReasonIDTitleControlIdToReplace, AV16ddo_BR_EncounterIDTitleControlIdToReplace, AV18ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace, AV20ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace, AV22ddo_BR_Encounter_RefuseReason_StatusTitleControlIdToReplace) ;
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
               AV8InOutBR_Encounter_RefuseReasonID = (long)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8InOutBR_Encounter_RefuseReasonID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8InOutBR_Encounter_RefuseReasonID), 18, 0)));
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV9InOutBR_Encounter_RefuseReason_Reason = GetNextPar( );
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9InOutBR_Encounter_RefuseReason_Reason", AV9InOutBR_Encounter_RefuseReason_Reason);
               }
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
            ValidateSpaRequest();
            PA7E2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV31Pgmname = "BR_Encounter_RefuseReasonPrompt";
               context.Gx_err = 0;
               WS7E2( ) ;
               if ( ! isAjaxCallMode( ) )
               {
                  WE7E2( ) ;
               }
            }
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

      protected void RenderHtmlHeaders( )
      {
         GxWebStd.gx_html_headers( context, 0, "", "", Form.Meta, Form.Metaequiv, true);
      }

      protected void RenderHtmlOpenForm( )
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
         if ( ( ( context.GetBrowserType( ) == 1 ) || ( context.GetBrowserType( ) == 5 ) ) && ( StringUtil.StrCmp(context.GetBrowserVersion( ), "7.0") == 0 ) )
         {
            context.AddJavascriptSource("json2.js", "?"+context.GetBuildNumber( 127771), false);
         }
         context.AddJavascriptSource("jquery.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("gxtimezone.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("gxgral.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("gxcfg.js", "?20202279464784", false);
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
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/WorkWithPlusUtilities/WorkWithPlusUtilitiesRender.js", "", false);
         context.CloseHtmlHeader();
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         FormProcess = " data-HasEnter=\"true\" data-Skiponenter=\"false\"";
         context.WriteHtmlText( "<body ") ;
         bodyStyle = "";
         if ( nGXWrapped == 0 )
         {
            bodyStyle = bodyStyle + "-moz-opacity:0;opacity:0;";
         }
         context.WriteHtmlText( " "+"class=\"form-horizontal Form\""+" "+ "style='"+bodyStyle+"'") ;
         context.WriteHtmlText( FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_encounter_refusereasonprompt.aspx") + "?" + UrlEncode("" +AV8InOutBR_Encounter_RefuseReasonID) + "," + UrlEncode(StringUtil.RTrim(AV9InOutBR_Encounter_RefuseReason_Reason))+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "GXH_vORDEREDBY", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11OrderedBy), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vORDEREDDSC", StringUtil.BoolToStr( AV12OrderedDsc));
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_12", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_12), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDCURRENTPAGE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV25GridCurrentPage), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDRECORDCOUNT", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV27GridRecordCount), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDPAGESIZE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV26GridPageSize), 10, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vDDO_TITLESETTINGSICONS", AV23DDO_TitleSettingsIcons);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vDDO_TITLESETTINGSICONS", AV23DDO_TitleSettingsIcons);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_ENCOUNTER_REFUSEREASONIDTITLEFILTERDATA", AV13BR_Encounter_RefuseReasonIDTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_ENCOUNTER_REFUSEREASONIDTITLEFILTERDATA", AV13BR_Encounter_RefuseReasonIDTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_ENCOUNTERIDTITLEFILTERDATA", AV15BR_EncounterIDTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_ENCOUNTERIDTITLEFILTERDATA", AV15BR_EncounterIDTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_ENCOUNTER_REFUSEREASON_REASONTITLEFILTERDATA", AV17BR_Encounter_RefuseReason_ReasonTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_ENCOUNTER_REFUSEREASON_REASONTITLEFILTERDATA", AV17BR_Encounter_RefuseReason_ReasonTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATETITLEFILTERDATA", AV19BR_Encounter_RefuseReason_NoApproveDateTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATETITLEFILTERDATA", AV19BR_Encounter_RefuseReason_NoApproveDateTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_ENCOUNTER_REFUSEREASON_STATUSTITLEFILTERDATA", AV21BR_Encounter_RefuseReason_StatusTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_ENCOUNTER_REFUSEREASON_STATUSTITLEFILTERDATA", AV21BR_Encounter_RefuseReason_StatusTitleFilterData);
         }
         GxWebStd.gx_hidden_field( context, "vINOUTBR_ENCOUNTER_REFUSEREASONID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8InOutBR_Encounter_RefuseReasonID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vINOUTBR_ENCOUNTER_REFUSEREASON_REASON", AV9InOutBR_Encounter_RefuseReason_Reason);
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
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASONID_Caption", StringUtil.RTrim( Ddo_br_encounter_refusereasonid_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASONID_Tooltip", StringUtil.RTrim( Ddo_br_encounter_refusereasonid_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASONID_Cls", StringUtil.RTrim( Ddo_br_encounter_refusereasonid_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASONID_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_encounter_refusereasonid_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASONID_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_encounter_refusereasonid_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASONID_Includesortasc", StringUtil.BoolToStr( Ddo_br_encounter_refusereasonid_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASONID_Includesortdsc", StringUtil.BoolToStr( Ddo_br_encounter_refusereasonid_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASONID_Sortedstatus", StringUtil.RTrim( Ddo_br_encounter_refusereasonid_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASONID_Includefilter", StringUtil.BoolToStr( Ddo_br_encounter_refusereasonid_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASONID_Includedatalist", StringUtil.BoolToStr( Ddo_br_encounter_refusereasonid_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASONID_Sortasc", StringUtil.RTrim( Ddo_br_encounter_refusereasonid_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASONID_Sortdsc", StringUtil.RTrim( Ddo_br_encounter_refusereasonid_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASONID_Searchbuttontext", StringUtil.RTrim( Ddo_br_encounter_refusereasonid_Searchbuttontext));
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
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_REASON_Caption", StringUtil.RTrim( Ddo_br_encounter_refusereason_reason_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_REASON_Tooltip", StringUtil.RTrim( Ddo_br_encounter_refusereason_reason_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_REASON_Cls", StringUtil.RTrim( Ddo_br_encounter_refusereason_reason_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_REASON_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_encounter_refusereason_reason_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_REASON_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_encounter_refusereason_reason_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_REASON_Includesortasc", StringUtil.BoolToStr( Ddo_br_encounter_refusereason_reason_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_REASON_Includesortdsc", StringUtil.BoolToStr( Ddo_br_encounter_refusereason_reason_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_REASON_Sortedstatus", StringUtil.RTrim( Ddo_br_encounter_refusereason_reason_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_REASON_Includefilter", StringUtil.BoolToStr( Ddo_br_encounter_refusereason_reason_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_REASON_Includedatalist", StringUtil.BoolToStr( Ddo_br_encounter_refusereason_reason_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_REASON_Sortasc", StringUtil.RTrim( Ddo_br_encounter_refusereason_reason_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_REASON_Sortdsc", StringUtil.RTrim( Ddo_br_encounter_refusereason_reason_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_REASON_Searchbuttontext", StringUtil.RTrim( Ddo_br_encounter_refusereason_reason_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_Caption", StringUtil.RTrim( Ddo_br_encounter_refusereason_noapprovedate_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_Tooltip", StringUtil.RTrim( Ddo_br_encounter_refusereason_noapprovedate_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_Cls", StringUtil.RTrim( Ddo_br_encounter_refusereason_noapprovedate_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_encounter_refusereason_noapprovedate_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_encounter_refusereason_noapprovedate_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_Includesortasc", StringUtil.BoolToStr( Ddo_br_encounter_refusereason_noapprovedate_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_Includesortdsc", StringUtil.BoolToStr( Ddo_br_encounter_refusereason_noapprovedate_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_Sortedstatus", StringUtil.RTrim( Ddo_br_encounter_refusereason_noapprovedate_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_Includefilter", StringUtil.BoolToStr( Ddo_br_encounter_refusereason_noapprovedate_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_Includedatalist", StringUtil.BoolToStr( Ddo_br_encounter_refusereason_noapprovedate_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_Sortasc", StringUtil.RTrim( Ddo_br_encounter_refusereason_noapprovedate_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_Sortdsc", StringUtil.RTrim( Ddo_br_encounter_refusereason_noapprovedate_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_Searchbuttontext", StringUtil.RTrim( Ddo_br_encounter_refusereason_noapprovedate_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_STATUS_Caption", StringUtil.RTrim( Ddo_br_encounter_refusereason_status_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_STATUS_Tooltip", StringUtil.RTrim( Ddo_br_encounter_refusereason_status_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_STATUS_Cls", StringUtil.RTrim( Ddo_br_encounter_refusereason_status_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_STATUS_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_encounter_refusereason_status_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_STATUS_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_encounter_refusereason_status_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_STATUS_Includesortasc", StringUtil.BoolToStr( Ddo_br_encounter_refusereason_status_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_STATUS_Includesortdsc", StringUtil.BoolToStr( Ddo_br_encounter_refusereason_status_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_STATUS_Sortedstatus", StringUtil.RTrim( Ddo_br_encounter_refusereason_status_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_STATUS_Includefilter", StringUtil.BoolToStr( Ddo_br_encounter_refusereason_status_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_STATUS_Includedatalist", StringUtil.BoolToStr( Ddo_br_encounter_refusereason_status_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_STATUS_Sortasc", StringUtil.RTrim( Ddo_br_encounter_refusereason_status_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_STATUS_Sortdsc", StringUtil.RTrim( Ddo_br_encounter_refusereason_status_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_STATUS_Searchbuttontext", StringUtil.RTrim( Ddo_br_encounter_refusereason_status_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASONID_Activeeventkey", StringUtil.RTrim( Ddo_br_encounter_refusereasonid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Activeeventkey", StringUtil.RTrim( Ddo_br_encounterid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_REASON_Activeeventkey", StringUtil.RTrim( Ddo_br_encounter_refusereason_reason_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_Activeeventkey", StringUtil.RTrim( Ddo_br_encounter_refusereason_noapprovedate_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_STATUS_Activeeventkey", StringUtil.RTrim( Ddo_br_encounter_refusereason_status_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASONID_Activeeventkey", StringUtil.RTrim( Ddo_br_encounter_refusereasonid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Activeeventkey", StringUtil.RTrim( Ddo_br_encounterid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_REASON_Activeeventkey", StringUtil.RTrim( Ddo_br_encounter_refusereason_reason_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_Activeeventkey", StringUtil.RTrim( Ddo_br_encounter_refusereason_noapprovedate_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_REFUSEREASON_STATUS_Activeeventkey", StringUtil.RTrim( Ddo_br_encounter_refusereason_status_Activeeventkey));
      }

      protected void RenderHtmlCloseForm7E2( )
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
         context.WriteHtmlTextNl( "</body>") ;
         context.WriteHtmlTextNl( "</html>") ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
      }

      public override String GetPgmname( )
      {
         return "BR_Encounter_RefuseReasonPrompt" ;
      }

      public override String GetPgmdesc( )
      {
         return "选择就诊信息驳回原因" ;
      }

      protected void WB7E0( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! wbLoad )
         {
            RenderHtmlHeaders( ) ;
            RenderHtmlOpenForm( ) ;
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
            GxWebStd.gx_div_start( context, divTablemain_Internalname, 1, 0, "px", divTablemain_Height, "px", "TableMain", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 WorkWithCell", "left", "top", "", "", "div");
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
               context.WriteHtmlText( "<div id=\""+"GridContainer"+"DivS\" data-gxgridid=\"12\">") ;
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
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"SelectAttribute ActionBaseColorAttribute"+"\" "+" style=\""+""+""+"\" "+">") ;
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
               GridColumn.AddObjectProperty("Value", context.convertURL( AV28Select));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavSelect_Tooltiptext));
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
         if ( wbEnd == 12 )
         {
            wbEnd = 0;
            nRC_GXsfl_12 = (short)(nGXsfl_12_idx-1);
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
            ucGridpaginationbar.SetProperty("CurrentPage", AV25GridCurrentPage);
            ucGridpaginationbar.SetProperty("RecordCount", AV27GridRecordCount);
            ucGridpaginationbar.SetProperty("Page", AV26GridPageSize);
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
            ucDdo_br_encounter_refusereasonid.SetProperty("IncludeDataList", Ddo_br_encounter_refusereasonid_Includedatalist);
            ucDdo_br_encounter_refusereasonid.SetProperty("SortASC", Ddo_br_encounter_refusereasonid_Sortasc);
            ucDdo_br_encounter_refusereasonid.SetProperty("SortDSC", Ddo_br_encounter_refusereasonid_Sortdsc);
            ucDdo_br_encounter_refusereasonid.SetProperty("SearchButtonText", Ddo_br_encounter_refusereasonid_Searchbuttontext);
            ucDdo_br_encounter_refusereasonid.SetProperty("DropDownOptionsTitleSettingsIcons", AV23DDO_TitleSettingsIcons);
            ucDdo_br_encounter_refusereasonid.SetProperty("DropDownOptionsData", AV13BR_Encounter_RefuseReasonIDTitleFilterData);
            ucDdo_br_encounter_refusereasonid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_encounter_refusereasonid_Internalname, "DDO_BR_ENCOUNTER_REFUSEREASONIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_encounter_refusereasonidtitlecontrolidtoreplace_Internalname, AV14ddo_BR_Encounter_RefuseReasonIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,27);\"", 0, edtavDdo_br_encounter_refusereasonidtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Encounter_RefuseReasonPrompt.htm");
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
            ucDdo_br_encounterid.SetProperty("DropDownOptionsTitleSettingsIcons", AV23DDO_TitleSettingsIcons);
            ucDdo_br_encounterid.SetProperty("DropDownOptionsData", AV15BR_EncounterIDTitleFilterData);
            ucDdo_br_encounterid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_encounterid_Internalname, "DDO_BR_ENCOUNTERIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_encounteridtitlecontrolidtoreplace_Internalname, AV16ddo_BR_EncounterIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,29);\"", 0, edtavDdo_br_encounteridtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Encounter_RefuseReasonPrompt.htm");
            /* User Defined Control */
            ucDdo_br_encounter_refusereason_reason.SetProperty("Caption", Ddo_br_encounter_refusereason_reason_Caption);
            ucDdo_br_encounter_refusereason_reason.SetProperty("Tooltip", Ddo_br_encounter_refusereason_reason_Tooltip);
            ucDdo_br_encounter_refusereason_reason.SetProperty("Cls", Ddo_br_encounter_refusereason_reason_Cls);
            ucDdo_br_encounter_refusereason_reason.SetProperty("DropDownOptionsType", Ddo_br_encounter_refusereason_reason_Dropdownoptionstype);
            ucDdo_br_encounter_refusereason_reason.SetProperty("IncludeSortASC", Ddo_br_encounter_refusereason_reason_Includesortasc);
            ucDdo_br_encounter_refusereason_reason.SetProperty("IncludeSortDSC", Ddo_br_encounter_refusereason_reason_Includesortdsc);
            ucDdo_br_encounter_refusereason_reason.SetProperty("IncludeFilter", Ddo_br_encounter_refusereason_reason_Includefilter);
            ucDdo_br_encounter_refusereason_reason.SetProperty("IncludeDataList", Ddo_br_encounter_refusereason_reason_Includedatalist);
            ucDdo_br_encounter_refusereason_reason.SetProperty("SortASC", Ddo_br_encounter_refusereason_reason_Sortasc);
            ucDdo_br_encounter_refusereason_reason.SetProperty("SortDSC", Ddo_br_encounter_refusereason_reason_Sortdsc);
            ucDdo_br_encounter_refusereason_reason.SetProperty("SearchButtonText", Ddo_br_encounter_refusereason_reason_Searchbuttontext);
            ucDdo_br_encounter_refusereason_reason.SetProperty("DropDownOptionsTitleSettingsIcons", AV23DDO_TitleSettingsIcons);
            ucDdo_br_encounter_refusereason_reason.SetProperty("DropDownOptionsData", AV17BR_Encounter_RefuseReason_ReasonTitleFilterData);
            ucDdo_br_encounter_refusereason_reason.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_encounter_refusereason_reason_Internalname, "DDO_BR_ENCOUNTER_REFUSEREASON_REASONContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 31,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_encounter_refusereason_reasontitlecontrolidtoreplace_Internalname, AV18ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,31);\"", 0, edtavDdo_br_encounter_refusereason_reasontitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Encounter_RefuseReasonPrompt.htm");
            /* User Defined Control */
            ucDdo_br_encounter_refusereason_noapprovedate.SetProperty("Caption", Ddo_br_encounter_refusereason_noapprovedate_Caption);
            ucDdo_br_encounter_refusereason_noapprovedate.SetProperty("Tooltip", Ddo_br_encounter_refusereason_noapprovedate_Tooltip);
            ucDdo_br_encounter_refusereason_noapprovedate.SetProperty("Cls", Ddo_br_encounter_refusereason_noapprovedate_Cls);
            ucDdo_br_encounter_refusereason_noapprovedate.SetProperty("DropDownOptionsType", Ddo_br_encounter_refusereason_noapprovedate_Dropdownoptionstype);
            ucDdo_br_encounter_refusereason_noapprovedate.SetProperty("IncludeSortASC", Ddo_br_encounter_refusereason_noapprovedate_Includesortasc);
            ucDdo_br_encounter_refusereason_noapprovedate.SetProperty("IncludeSortDSC", Ddo_br_encounter_refusereason_noapprovedate_Includesortdsc);
            ucDdo_br_encounter_refusereason_noapprovedate.SetProperty("IncludeFilter", Ddo_br_encounter_refusereason_noapprovedate_Includefilter);
            ucDdo_br_encounter_refusereason_noapprovedate.SetProperty("IncludeDataList", Ddo_br_encounter_refusereason_noapprovedate_Includedatalist);
            ucDdo_br_encounter_refusereason_noapprovedate.SetProperty("SortASC", Ddo_br_encounter_refusereason_noapprovedate_Sortasc);
            ucDdo_br_encounter_refusereason_noapprovedate.SetProperty("SortDSC", Ddo_br_encounter_refusereason_noapprovedate_Sortdsc);
            ucDdo_br_encounter_refusereason_noapprovedate.SetProperty("SearchButtonText", Ddo_br_encounter_refusereason_noapprovedate_Searchbuttontext);
            ucDdo_br_encounter_refusereason_noapprovedate.SetProperty("DropDownOptionsTitleSettingsIcons", AV23DDO_TitleSettingsIcons);
            ucDdo_br_encounter_refusereason_noapprovedate.SetProperty("DropDownOptionsData", AV19BR_Encounter_RefuseReason_NoApproveDateTitleFilterData);
            ucDdo_br_encounter_refusereason_noapprovedate.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_encounter_refusereason_noapprovedate_Internalname, "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 33,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_encounter_refusereason_noapprovedatetitlecontrolidtoreplace_Internalname, AV20ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,33);\"", 0, edtavDdo_br_encounter_refusereason_noapprovedatetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Encounter_RefuseReasonPrompt.htm");
            /* User Defined Control */
            ucDdo_br_encounter_refusereason_status.SetProperty("Caption", Ddo_br_encounter_refusereason_status_Caption);
            ucDdo_br_encounter_refusereason_status.SetProperty("Tooltip", Ddo_br_encounter_refusereason_status_Tooltip);
            ucDdo_br_encounter_refusereason_status.SetProperty("Cls", Ddo_br_encounter_refusereason_status_Cls);
            ucDdo_br_encounter_refusereason_status.SetProperty("DropDownOptionsType", Ddo_br_encounter_refusereason_status_Dropdownoptionstype);
            ucDdo_br_encounter_refusereason_status.SetProperty("IncludeSortASC", Ddo_br_encounter_refusereason_status_Includesortasc);
            ucDdo_br_encounter_refusereason_status.SetProperty("IncludeSortDSC", Ddo_br_encounter_refusereason_status_Includesortdsc);
            ucDdo_br_encounter_refusereason_status.SetProperty("IncludeFilter", Ddo_br_encounter_refusereason_status_Includefilter);
            ucDdo_br_encounter_refusereason_status.SetProperty("IncludeDataList", Ddo_br_encounter_refusereason_status_Includedatalist);
            ucDdo_br_encounter_refusereason_status.SetProperty("SortASC", Ddo_br_encounter_refusereason_status_Sortasc);
            ucDdo_br_encounter_refusereason_status.SetProperty("SortDSC", Ddo_br_encounter_refusereason_status_Sortdsc);
            ucDdo_br_encounter_refusereason_status.SetProperty("SearchButtonText", Ddo_br_encounter_refusereason_status_Searchbuttontext);
            ucDdo_br_encounter_refusereason_status.SetProperty("DropDownOptionsTitleSettingsIcons", AV23DDO_TitleSettingsIcons);
            ucDdo_br_encounter_refusereason_status.SetProperty("DropDownOptionsData", AV21BR_Encounter_RefuseReason_StatusTitleFilterData);
            ucDdo_br_encounter_refusereason_status.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_encounter_refusereason_status_Internalname, "DDO_BR_ENCOUNTER_REFUSEREASON_STATUSContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 35,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_encounter_refusereason_statustitlecontrolidtoreplace_Internalname, AV22ddo_BR_Encounter_RefuseReason_StatusTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,35);\"", 0, edtavDdo_br_encounter_refusereason_statustitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Encounter_RefuseReasonPrompt.htm");
            /* User Defined Control */
            ucWorkwithplusutilities1.Render(context, "dvelop.workwithplusutilities", Workwithplusutilities1_Internalname, "WORKWITHPLUSUTILITIES1Container");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 37,'',false,'" + sGXsfl_12_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrderedby_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11OrderedBy), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV11OrderedBy), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,37);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrderedby_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrderedby_Visible, 1, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Encounter_RefuseReasonPrompt.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'" + sGXsfl_12_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrdereddsc_Internalname, StringUtil.BoolToStr( AV12OrderedDsc), StringUtil.BoolToStr( AV12OrderedDsc), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,38);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrdereddsc_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrdereddsc_Visible, 1, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, 0, 0, true, "", "right", false, "HLP_BR_Encounter_RefuseReasonPrompt.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         if ( wbEnd == 12 )
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

      protected void START7E2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_0-127771", 0) ;
            Form.Meta.addItem("description", "选择就诊信息驳回原因", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP7E0( ) ;
      }

      protected void WS7E2( )
      {
         START7E2( ) ;
         EVT7E2( ) ;
      }

      protected void EVT7E2( )
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
                           E117E2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEROWSPERPAGE") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E127E2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_ENCOUNTER_REFUSEREASONID.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E137E2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_ENCOUNTERID.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E147E2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_ENCOUNTER_REFUSEREASON_REASON.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E157E2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E167E2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_ENCOUNTER_REFUSEREASON_STATUS.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E177E2 ();
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
                        if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 7), "REFRESH") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 9), "GRID.LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) )
                        {
                           nGXsfl_12_idx = (short)(NumberUtil.Val( sEvtType, "."));
                           sGXsfl_12_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_12_idx), 4, 0)), 4, "0");
                           SubsflControlProps_122( ) ;
                           AV28Select = cgiGet( edtavSelect_Internalname);
                           context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSelect_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV28Select)) ? AV32Select_GXI : context.convertURL( context.PathToRelativeUrl( AV28Select))), !bGXsfl_12_Refreshing);
                           context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSelect_Internalname, "SrcSet", context.GetImageSrcSet( AV28Select), true);
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
                                 E187E2 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 /* Execute user event: Refresh */
                                 E197E2 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "GRID.LOAD") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 E207E2 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    Rfr0gs = false;
                                    /* Set Refresh If Orderedby Changed */
                                    if ( ( context.localUtil.CToN( cgiGet( "GXH_vORDEREDBY"), ".", ",") != Convert.ToDecimal( AV11OrderedBy )) )
                                    {
                                       Rfr0gs = true;
                                    }
                                    /* Set Refresh If Ordereddsc Changed */
                                    if ( StringUtil.StrToBool( cgiGet( "GXH_vORDEREDDSC")) != AV12OrderedDsc )
                                    {
                                       Rfr0gs = true;
                                    }
                                    if ( ! Rfr0gs )
                                    {
                                       /* Execute user event: Enter */
                                       E217E2 ();
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

      protected void WE7E2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm7E2( ) ;
            }
         }
      }

      protected void PA7E2( )
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
         SubsflControlProps_122( ) ;
         while ( nGXsfl_12_idx <= nRC_GXsfl_12 )
         {
            sendrow_122( ) ;
            nGXsfl_12_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_12_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_12_idx+1));
            sGXsfl_12_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_12_idx), 4, 0)), 4, "0");
            SubsflControlProps_122( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( GridContainer));
         /* End function gxnrGrid_newrow */
      }

      protected void gxgrGrid_refresh( int subGrid_Rows ,
                                       short AV11OrderedBy ,
                                       bool AV12OrderedDsc ,
                                       String AV14ddo_BR_Encounter_RefuseReasonIDTitleControlIdToReplace ,
                                       String AV16ddo_BR_EncounterIDTitleControlIdToReplace ,
                                       String AV18ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace ,
                                       String AV20ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace ,
                                       String AV22ddo_BR_Encounter_RefuseReason_StatusTitleControlIdToReplace )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GRID_nCurrentRecord = 0;
         RF7E2( ) ;
         /* End function gxgrGrid_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_BR_ENCOUNTER_REFUSEREASONID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A348BR_Encounter_RefuseReasonID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, "BR_ENCOUNTER_REFUSEREASONID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A348BR_Encounter_RefuseReasonID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_BR_ENCOUNTER_REFUSEREASON_REASON", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( A349BR_Encounter_RefuseReason_Reason, "")), context));
         GxWebStd.gx_hidden_field( context, "BR_ENCOUNTER_REFUSEREASON_REASON", A349BR_Encounter_RefuseReason_Reason);
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
         RF7E2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV31Pgmname = "BR_Encounter_RefuseReasonPrompt";
         context.Gx_err = 0;
      }

      protected void RF7E2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridContainer.ClearRows();
         }
         wbStart = 12;
         /* Execute user event: Refresh */
         E197E2 ();
         nGXsfl_12_idx = 1;
         sGXsfl_12_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_12_idx), 4, 0)), 4, "0");
         SubsflControlProps_122( ) ;
         bGXsfl_12_Refreshing = true;
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
            SubsflControlProps_122( ) ;
            GXPagingFrom2 = (int)(((subGrid_Rows==0) ? 0 : GRID_nFirstRecordOnPage));
            GXPagingTo2 = ((subGrid_Rows==0) ? 10000 : subGrid_Recordsperpage( )+1);
            pr_default.dynParam(0, new Object[]{ new Object[]{
                                                 AV11OrderedBy ,
                                                 AV12OrderedDsc } ,
                                                 new int[]{
                                                 TypeConstants.SHORT, TypeConstants.BOOLEAN
                                                 }
            } ) ;
            /* Using cursor H007E2 */
            pr_default.execute(0, new Object[] {GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_12_idx = 1;
            sGXsfl_12_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_12_idx), 4, 0)), 4, "0");
            SubsflControlProps_122( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < subGrid_Recordsperpage( ) ) ) ) )
            {
               A351BR_Encounter_RefuseReason_Status = H007E2_A351BR_Encounter_RefuseReason_Status[0];
               n351BR_Encounter_RefuseReason_Status = H007E2_n351BR_Encounter_RefuseReason_Status[0];
               A350BR_Encounter_RefuseReason_NoApproveDate = H007E2_A350BR_Encounter_RefuseReason_NoApproveDate[0];
               n350BR_Encounter_RefuseReason_NoApproveDate = H007E2_n350BR_Encounter_RefuseReason_NoApproveDate[0];
               A349BR_Encounter_RefuseReason_Reason = H007E2_A349BR_Encounter_RefuseReason_Reason[0];
               n349BR_Encounter_RefuseReason_Reason = H007E2_n349BR_Encounter_RefuseReason_Reason[0];
               A19BR_EncounterID = H007E2_A19BR_EncounterID[0];
               A348BR_Encounter_RefuseReasonID = H007E2_A348BR_Encounter_RefuseReasonID[0];
               E207E2 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 12;
            WB7E0( ) ;
         }
         bGXsfl_12_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes7E2( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_BR_ENCOUNTER_REFUSEREASONID"+"_"+sGXsfl_12_idx, GetSecureSignedToken( sGXsfl_12_idx, context.localUtil.Format( (decimal)(A348BR_Encounter_RefuseReasonID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, "gxhash_BR_ENCOUNTER_REFUSEREASON_REASON"+"_"+sGXsfl_12_idx, GetSecureSignedToken( sGXsfl_12_idx, StringUtil.RTrim( context.localUtil.Format( A349BR_Encounter_RefuseReason_Reason, "")), context));
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
         pr_default.dynParam(1, new Object[]{ new Object[]{
                                              AV11OrderedBy ,
                                              AV12OrderedDsc } ,
                                              new int[]{
                                              TypeConstants.SHORT, TypeConstants.BOOLEAN
                                              }
         } ) ;
         /* Using cursor H007E3 */
         pr_default.execute(1);
         GRID_nRecordCount = H007E3_AGRID_nRecordCount[0];
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
         GRID_nFirstRecordOnPage = 0;
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_BR_Encounter_RefuseReasonIDTitleControlIdToReplace, AV16ddo_BR_EncounterIDTitleControlIdToReplace, AV18ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace, AV20ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace, AV22ddo_BR_Encounter_RefuseReason_StatusTitleControlIdToReplace) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid_nextpage( )
      {
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
            gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_BR_Encounter_RefuseReasonIDTitleControlIdToReplace, AV16ddo_BR_EncounterIDTitleControlIdToReplace, AV18ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace, AV20ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace, AV22ddo_BR_Encounter_RefuseReason_StatusTitleControlIdToReplace) ;
         }
         send_integrity_footer_hashes( ) ;
         return (short)(((GRID_nEOF==0) ? 0 : 2)) ;
      }

      protected short subgrid_previouspage( )
      {
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
            gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_BR_Encounter_RefuseReasonIDTitleControlIdToReplace, AV16ddo_BR_EncounterIDTitleControlIdToReplace, AV18ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace, AV20ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace, AV22ddo_BR_Encounter_RefuseReason_StatusTitleControlIdToReplace) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid_lastpage( )
      {
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
            gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_BR_Encounter_RefuseReasonIDTitleControlIdToReplace, AV16ddo_BR_EncounterIDTitleControlIdToReplace, AV18ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace, AV20ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace, AV22ddo_BR_Encounter_RefuseReason_StatusTitleControlIdToReplace) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected int subgrid_gotopage( int nPageNo )
      {
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
            gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_BR_Encounter_RefuseReasonIDTitleControlIdToReplace, AV16ddo_BR_EncounterIDTitleControlIdToReplace, AV18ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace, AV20ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace, AV22ddo_BR_Encounter_RefuseReason_StatusTitleControlIdToReplace) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP7E0( )
      {
         /* Before Start, stand alone formulas. */
         AV31Pgmname = "BR_Encounter_RefuseReasonPrompt";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E187E2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( "vDDO_TITLESETTINGSICONS"), AV23DDO_TitleSettingsIcons);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_ENCOUNTER_REFUSEREASONIDTITLEFILTERDATA"), AV13BR_Encounter_RefuseReasonIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_ENCOUNTERIDTITLEFILTERDATA"), AV15BR_EncounterIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_ENCOUNTER_REFUSEREASON_REASONTITLEFILTERDATA"), AV17BR_Encounter_RefuseReason_ReasonTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATETITLEFILTERDATA"), AV19BR_Encounter_RefuseReason_NoApproveDateTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_ENCOUNTER_REFUSEREASON_STATUSTITLEFILTERDATA"), AV21BR_Encounter_RefuseReason_StatusTitleFilterData);
            /* Read variables values. */
            AV14ddo_BR_Encounter_RefuseReasonIDTitleControlIdToReplace = cgiGet( edtavDdo_br_encounter_refusereasonidtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14ddo_BR_Encounter_RefuseReasonIDTitleControlIdToReplace", AV14ddo_BR_Encounter_RefuseReasonIDTitleControlIdToReplace);
            AV16ddo_BR_EncounterIDTitleControlIdToReplace = cgiGet( edtavDdo_br_encounteridtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16ddo_BR_EncounterIDTitleControlIdToReplace", AV16ddo_BR_EncounterIDTitleControlIdToReplace);
            AV18ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace = cgiGet( edtavDdo_br_encounter_refusereason_reasontitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace", AV18ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace);
            AV20ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace = cgiGet( edtavDdo_br_encounter_refusereason_noapprovedatetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace", AV20ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace);
            AV22ddo_BR_Encounter_RefuseReason_StatusTitleControlIdToReplace = cgiGet( edtavDdo_br_encounter_refusereason_statustitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22ddo_BR_Encounter_RefuseReason_StatusTitleControlIdToReplace", AV22ddo_BR_Encounter_RefuseReason_StatusTitleControlIdToReplace);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavOrderedby_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavOrderedby_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vORDEREDBY");
               GX_FocusControl = edtavOrderedby_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV11OrderedBy = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            }
            else
            {
               AV11OrderedBy = (short)(context.localUtil.CToN( cgiGet( edtavOrderedby_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            }
            AV12OrderedDsc = StringUtil.StrToBool( cgiGet( edtavOrdereddsc_Internalname));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            /* Read saved values. */
            nRC_GXsfl_12 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_12"), ".", ","));
            AV25GridCurrentPage = (long)(context.localUtil.CToN( cgiGet( "vGRIDCURRENTPAGE"), ".", ","));
            AV27GridRecordCount = (long)(context.localUtil.CToN( cgiGet( "vGRIDRECORDCOUNT"), ".", ","));
            AV26GridPageSize = (long)(context.localUtil.CToN( cgiGet( "vGRIDPAGESIZE"), ".", ","));
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
            Ddo_br_encounter_refusereasonid_Caption = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASONID_Caption");
            Ddo_br_encounter_refusereasonid_Tooltip = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASONID_Tooltip");
            Ddo_br_encounter_refusereasonid_Cls = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASONID_Cls");
            Ddo_br_encounter_refusereasonid_Dropdownoptionstype = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASONID_Dropdownoptionstype");
            Ddo_br_encounter_refusereasonid_Titlecontrolidtoreplace = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASONID_Titlecontrolidtoreplace");
            Ddo_br_encounter_refusereasonid_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASONID_Includesortasc"));
            Ddo_br_encounter_refusereasonid_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASONID_Includesortdsc"));
            Ddo_br_encounter_refusereasonid_Sortedstatus = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASONID_Sortedstatus");
            Ddo_br_encounter_refusereasonid_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASONID_Includefilter"));
            Ddo_br_encounter_refusereasonid_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASONID_Includedatalist"));
            Ddo_br_encounter_refusereasonid_Sortasc = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASONID_Sortasc");
            Ddo_br_encounter_refusereasonid_Sortdsc = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASONID_Sortdsc");
            Ddo_br_encounter_refusereasonid_Searchbuttontext = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASONID_Searchbuttontext");
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
            Ddo_br_encounter_refusereason_reason_Caption = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_REASON_Caption");
            Ddo_br_encounter_refusereason_reason_Tooltip = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_REASON_Tooltip");
            Ddo_br_encounter_refusereason_reason_Cls = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_REASON_Cls");
            Ddo_br_encounter_refusereason_reason_Dropdownoptionstype = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_REASON_Dropdownoptionstype");
            Ddo_br_encounter_refusereason_reason_Titlecontrolidtoreplace = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_REASON_Titlecontrolidtoreplace");
            Ddo_br_encounter_refusereason_reason_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_REASON_Includesortasc"));
            Ddo_br_encounter_refusereason_reason_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_REASON_Includesortdsc"));
            Ddo_br_encounter_refusereason_reason_Sortedstatus = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_REASON_Sortedstatus");
            Ddo_br_encounter_refusereason_reason_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_REASON_Includefilter"));
            Ddo_br_encounter_refusereason_reason_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_REASON_Includedatalist"));
            Ddo_br_encounter_refusereason_reason_Sortasc = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_REASON_Sortasc");
            Ddo_br_encounter_refusereason_reason_Sortdsc = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_REASON_Sortdsc");
            Ddo_br_encounter_refusereason_reason_Searchbuttontext = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_REASON_Searchbuttontext");
            Ddo_br_encounter_refusereason_noapprovedate_Caption = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_Caption");
            Ddo_br_encounter_refusereason_noapprovedate_Tooltip = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_Tooltip");
            Ddo_br_encounter_refusereason_noapprovedate_Cls = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_Cls");
            Ddo_br_encounter_refusereason_noapprovedate_Dropdownoptionstype = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_Dropdownoptionstype");
            Ddo_br_encounter_refusereason_noapprovedate_Titlecontrolidtoreplace = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_Titlecontrolidtoreplace");
            Ddo_br_encounter_refusereason_noapprovedate_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_Includesortasc"));
            Ddo_br_encounter_refusereason_noapprovedate_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_Includesortdsc"));
            Ddo_br_encounter_refusereason_noapprovedate_Sortedstatus = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_Sortedstatus");
            Ddo_br_encounter_refusereason_noapprovedate_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_Includefilter"));
            Ddo_br_encounter_refusereason_noapprovedate_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_Includedatalist"));
            Ddo_br_encounter_refusereason_noapprovedate_Sortasc = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_Sortasc");
            Ddo_br_encounter_refusereason_noapprovedate_Sortdsc = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_Sortdsc");
            Ddo_br_encounter_refusereason_noapprovedate_Searchbuttontext = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_Searchbuttontext");
            Ddo_br_encounter_refusereason_status_Caption = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_STATUS_Caption");
            Ddo_br_encounter_refusereason_status_Tooltip = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_STATUS_Tooltip");
            Ddo_br_encounter_refusereason_status_Cls = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_STATUS_Cls");
            Ddo_br_encounter_refusereason_status_Dropdownoptionstype = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_STATUS_Dropdownoptionstype");
            Ddo_br_encounter_refusereason_status_Titlecontrolidtoreplace = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_STATUS_Titlecontrolidtoreplace");
            Ddo_br_encounter_refusereason_status_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_STATUS_Includesortasc"));
            Ddo_br_encounter_refusereason_status_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_STATUS_Includesortdsc"));
            Ddo_br_encounter_refusereason_status_Sortedstatus = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_STATUS_Sortedstatus");
            Ddo_br_encounter_refusereason_status_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_STATUS_Includefilter"));
            Ddo_br_encounter_refusereason_status_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_STATUS_Includedatalist"));
            Ddo_br_encounter_refusereason_status_Sortasc = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_STATUS_Sortasc");
            Ddo_br_encounter_refusereason_status_Sortdsc = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_STATUS_Sortdsc");
            Ddo_br_encounter_refusereason_status_Searchbuttontext = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_STATUS_Searchbuttontext");
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( "GRID_Rows"), ".", ","));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            Gridpaginationbar_Selectedpage = cgiGet( "GRIDPAGINATIONBAR_Selectedpage");
            Gridpaginationbar_Rowsperpageselectedvalue = (int)(context.localUtil.CToN( cgiGet( "GRIDPAGINATIONBAR_Rowsperpageselectedvalue"), ".", ","));
            Ddo_br_encounter_refusereasonid_Activeeventkey = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASONID_Activeeventkey");
            Ddo_br_encounterid_Activeeventkey = cgiGet( "DDO_BR_ENCOUNTERID_Activeeventkey");
            Ddo_br_encounter_refusereason_reason_Activeeventkey = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_REASON_Activeeventkey");
            Ddo_br_encounter_refusereason_noapprovedate_Activeeventkey = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_Activeeventkey");
            Ddo_br_encounter_refusereason_status_Activeeventkey = cgiGet( "DDO_BR_ENCOUNTER_REFUSEREASON_STATUS_Activeeventkey");
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vORDEREDBY"), ".", ",") != Convert.ToDecimal( AV11OrderedBy )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrToBool( cgiGet( "GXH_vORDEREDDSC")) != AV12OrderedDsc )
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
         E187E2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E187E2( )
      {
         /* Start Routine */
         GXt_boolean1 = AV5IsAuthorized;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "WWBR_Encounter_RefuseReason", out  GXt_boolean1) ;
         AV5IsAuthorized = GXt_boolean1;
         if ( ! AV5IsAuthorized )
         {
            CallWebObject(formatLink("wwpbaseobjects.notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV31Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         divTablemain_Height = 493;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, divTablemain_Internalname, "Height", StringUtil.LTrim( StringUtil.Str( (decimal)(divTablemain_Height), 9, 0)), true);
         subGrid_Rows = 9;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         Ddo_br_encounter_refusereasonid_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Encounter_RefuseReasonID";
         ucDdo_br_encounter_refusereasonid.SendProperty(context, "", false, Ddo_br_encounter_refusereasonid_Internalname, "TitleControlIdToReplace", Ddo_br_encounter_refusereasonid_Titlecontrolidtoreplace);
         AV14ddo_BR_Encounter_RefuseReasonIDTitleControlIdToReplace = Ddo_br_encounter_refusereasonid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14ddo_BR_Encounter_RefuseReasonIDTitleControlIdToReplace", AV14ddo_BR_Encounter_RefuseReasonIDTitleControlIdToReplace);
         edtavDdo_br_encounter_refusereasonidtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_encounter_refusereasonidtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_encounter_refusereasonidtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_encounterid_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_EncounterID";
         ucDdo_br_encounterid.SendProperty(context, "", false, Ddo_br_encounterid_Internalname, "TitleControlIdToReplace", Ddo_br_encounterid_Titlecontrolidtoreplace);
         AV16ddo_BR_EncounterIDTitleControlIdToReplace = Ddo_br_encounterid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16ddo_BR_EncounterIDTitleControlIdToReplace", AV16ddo_BR_EncounterIDTitleControlIdToReplace);
         edtavDdo_br_encounteridtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_encounteridtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_encounteridtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_encounter_refusereason_reason_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Encounter_RefuseReason_Reason";
         ucDdo_br_encounter_refusereason_reason.SendProperty(context, "", false, Ddo_br_encounter_refusereason_reason_Internalname, "TitleControlIdToReplace", Ddo_br_encounter_refusereason_reason_Titlecontrolidtoreplace);
         AV18ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace = Ddo_br_encounter_refusereason_reason_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace", AV18ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace);
         edtavDdo_br_encounter_refusereason_reasontitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_encounter_refusereason_reasontitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_encounter_refusereason_reasontitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_encounter_refusereason_noapprovedate_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Encounter_RefuseReason_NoApproveDate";
         ucDdo_br_encounter_refusereason_noapprovedate.SendProperty(context, "", false, Ddo_br_encounter_refusereason_noapprovedate_Internalname, "TitleControlIdToReplace", Ddo_br_encounter_refusereason_noapprovedate_Titlecontrolidtoreplace);
         AV20ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace = Ddo_br_encounter_refusereason_noapprovedate_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace", AV20ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace);
         edtavDdo_br_encounter_refusereason_noapprovedatetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_encounter_refusereason_noapprovedatetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_encounter_refusereason_noapprovedatetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_encounter_refusereason_status_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Encounter_RefuseReason_Status";
         ucDdo_br_encounter_refusereason_status.SendProperty(context, "", false, Ddo_br_encounter_refusereason_status_Internalname, "TitleControlIdToReplace", Ddo_br_encounter_refusereason_status_Titlecontrolidtoreplace);
         AV22ddo_BR_Encounter_RefuseReason_StatusTitleControlIdToReplace = Ddo_br_encounter_refusereason_status_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22ddo_BR_Encounter_RefuseReason_StatusTitleControlIdToReplace", AV22ddo_BR_Encounter_RefuseReason_StatusTitleControlIdToReplace);
         edtavDdo_br_encounter_refusereason_statustitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_encounter_refusereason_statustitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_encounter_refusereason_statustitlecontrolidtoreplace_Visible), 5, 0)), true);
         Form.Caption = "选择就诊信息驳回原因";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption, true);
         edtavOrderedby_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavOrderedby_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavOrderedby_Visible), 5, 0)), true);
         if ( AV11OrderedBy < 1 )
         {
            AV11OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
         }
         edtavOrdereddsc_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavOrdereddsc_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavOrdereddsc_Visible), 5, 0)), true);
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 = AV23DDO_TitleSettingsIcons;
         new GeneXus.Programs.wwpbaseobjects.getwwptitlesettingsicons(context ).execute( out  GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2) ;
         AV23DDO_TitleSettingsIcons = GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2;
         Gridpaginationbar_Rowsperpageselectedvalue = subGrid_Rows;
         ucGridpaginationbar.SendProperty(context, "", false, Gridpaginationbar_Internalname, "RowsPerPageSelectedValue", StringUtil.LTrim( StringUtil.Str( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0)));
      }

      protected void E197E2( )
      {
         if ( gx_refresh_fired )
         {
            return  ;
         }
         gx_refresh_fired = true;
         /* Refresh Routine */
         AV13BR_Encounter_RefuseReasonIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV15BR_EncounterIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV17BR_Encounter_RefuseReason_ReasonTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV19BR_Encounter_RefuseReason_NoApproveDateTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV21BR_Encounter_RefuseReason_StatusTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV6WWPContext) ;
         edtBR_Encounter_RefuseReasonID_Titleformat = 2;
         edtBR_Encounter_RefuseReasonID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "Reason ID", AV14ddo_BR_Encounter_RefuseReasonIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Encounter_RefuseReasonID_Internalname, "Title", edtBR_Encounter_RefuseReasonID_Title, !bGXsfl_12_Refreshing);
         edtBR_EncounterID_Titleformat = 2;
         edtBR_EncounterID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "就诊信息主键", AV16ddo_BR_EncounterIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_EncounterID_Internalname, "Title", edtBR_EncounterID_Title, !bGXsfl_12_Refreshing);
         edtBR_Encounter_RefuseReason_Reason_Titleformat = 2;
         edtBR_Encounter_RefuseReason_Reason_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "初审不通过原因", AV18ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Encounter_RefuseReason_Reason_Internalname, "Title", edtBR_Encounter_RefuseReason_Reason_Title, !bGXsfl_12_Refreshing);
         edtBR_Encounter_RefuseReason_NoApproveDate_Titleformat = 2;
         edtBR_Encounter_RefuseReason_NoApproveDate_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "初审不通过时间", AV20ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Encounter_RefuseReason_NoApproveDate_Internalname, "Title", edtBR_Encounter_RefuseReason_NoApproveDate_Title, !bGXsfl_12_Refreshing);
         cmbBR_Encounter_RefuseReason_Status_Titleformat = 2;
         cmbBR_Encounter_RefuseReason_Status.Title.Text = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "初审不通过状态", AV22ddo_BR_Encounter_RefuseReason_StatusTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Encounter_RefuseReason_Status_Internalname, "Title", cmbBR_Encounter_RefuseReason_Status.Title.Text, !bGXsfl_12_Refreshing);
         AV25GridCurrentPage = subGrid_Currentpage( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25GridCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV25GridCurrentPage), 10, 0)));
         AV26GridPageSize = subGrid_Rows;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26GridPageSize", StringUtil.LTrim( StringUtil.Str( (decimal)(AV26GridPageSize), 10, 0)));
         AV27GridRecordCount = subGrid_Recordcount( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27GridRecordCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV27GridRecordCount), 10, 0)));
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_Encounter_RefuseReasonIDTitleFilterData", AV13BR_Encounter_RefuseReasonIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_EncounterIDTitleFilterData", AV15BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_Encounter_RefuseReason_ReasonTitleFilterData", AV17BR_Encounter_RefuseReason_ReasonTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_Encounter_RefuseReason_NoApproveDateTitleFilterData", AV19BR_Encounter_RefuseReason_NoApproveDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21BR_Encounter_RefuseReason_StatusTitleFilterData", AV21BR_Encounter_RefuseReason_StatusTitleFilterData);
      }

      protected void E117E2( )
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
            AV24PageToGo = (int)(NumberUtil.Val( Gridpaginationbar_Selectedpage, "."));
            subgrid_gotopage( AV24PageToGo) ;
         }
      }

      protected void E127E2( )
      {
         /* Gridpaginationbar_Changerowsperpage Routine */
         subGrid_Rows = Gridpaginationbar_Rowsperpageselectedvalue;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         subgrid_firstpage( ) ;
         /*  Sending Event outputs  */
      }

      protected void E137E2( )
      {
         /* Ddo_br_encounter_refusereasonid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_encounter_refusereasonid_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_encounter_refusereasonid_Sortedstatus = "ASC";
            ucDdo_br_encounter_refusereasonid.SendProperty(context, "", false, Ddo_br_encounter_refusereasonid_Internalname, "SortedStatus", Ddo_br_encounter_refusereasonid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_encounter_refusereasonid_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_encounter_refusereasonid_Sortedstatus = "DSC";
            ucDdo_br_encounter_refusereasonid.SendProperty(context, "", false, Ddo_br_encounter_refusereasonid_Internalname, "SortedStatus", Ddo_br_encounter_refusereasonid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_Encounter_RefuseReasonIDTitleFilterData", AV13BR_Encounter_RefuseReasonIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_EncounterIDTitleFilterData", AV15BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_Encounter_RefuseReason_ReasonTitleFilterData", AV17BR_Encounter_RefuseReason_ReasonTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_Encounter_RefuseReason_NoApproveDateTitleFilterData", AV19BR_Encounter_RefuseReason_NoApproveDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21BR_Encounter_RefuseReason_StatusTitleFilterData", AV21BR_Encounter_RefuseReason_StatusTitleFilterData);
      }

      protected void E147E2( )
      {
         /* Ddo_br_encounterid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_encounterid_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_encounterid_Sortedstatus = "ASC";
            ucDdo_br_encounterid.SendProperty(context, "", false, Ddo_br_encounterid_Internalname, "SortedStatus", Ddo_br_encounterid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_encounterid_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_encounterid_Sortedstatus = "DSC";
            ucDdo_br_encounterid.SendProperty(context, "", false, Ddo_br_encounterid_Internalname, "SortedStatus", Ddo_br_encounterid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_Encounter_RefuseReasonIDTitleFilterData", AV13BR_Encounter_RefuseReasonIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_EncounterIDTitleFilterData", AV15BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_Encounter_RefuseReason_ReasonTitleFilterData", AV17BR_Encounter_RefuseReason_ReasonTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_Encounter_RefuseReason_NoApproveDateTitleFilterData", AV19BR_Encounter_RefuseReason_NoApproveDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21BR_Encounter_RefuseReason_StatusTitleFilterData", AV21BR_Encounter_RefuseReason_StatusTitleFilterData);
      }

      protected void E157E2( )
      {
         /* Ddo_br_encounter_refusereason_reason_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_encounter_refusereason_reason_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 3;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_encounter_refusereason_reason_Sortedstatus = "ASC";
            ucDdo_br_encounter_refusereason_reason.SendProperty(context, "", false, Ddo_br_encounter_refusereason_reason_Internalname, "SortedStatus", Ddo_br_encounter_refusereason_reason_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_encounter_refusereason_reason_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 3;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_encounter_refusereason_reason_Sortedstatus = "DSC";
            ucDdo_br_encounter_refusereason_reason.SendProperty(context, "", false, Ddo_br_encounter_refusereason_reason_Internalname, "SortedStatus", Ddo_br_encounter_refusereason_reason_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_Encounter_RefuseReasonIDTitleFilterData", AV13BR_Encounter_RefuseReasonIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_EncounterIDTitleFilterData", AV15BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_Encounter_RefuseReason_ReasonTitleFilterData", AV17BR_Encounter_RefuseReason_ReasonTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_Encounter_RefuseReason_NoApproveDateTitleFilterData", AV19BR_Encounter_RefuseReason_NoApproveDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21BR_Encounter_RefuseReason_StatusTitleFilterData", AV21BR_Encounter_RefuseReason_StatusTitleFilterData);
      }

      protected void E167E2( )
      {
         /* Ddo_br_encounter_refusereason_noapprovedate_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_encounter_refusereason_noapprovedate_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 4;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_encounter_refusereason_noapprovedate_Sortedstatus = "ASC";
            ucDdo_br_encounter_refusereason_noapprovedate.SendProperty(context, "", false, Ddo_br_encounter_refusereason_noapprovedate_Internalname, "SortedStatus", Ddo_br_encounter_refusereason_noapprovedate_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_encounter_refusereason_noapprovedate_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 4;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_encounter_refusereason_noapprovedate_Sortedstatus = "DSC";
            ucDdo_br_encounter_refusereason_noapprovedate.SendProperty(context, "", false, Ddo_br_encounter_refusereason_noapprovedate_Internalname, "SortedStatus", Ddo_br_encounter_refusereason_noapprovedate_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_Encounter_RefuseReasonIDTitleFilterData", AV13BR_Encounter_RefuseReasonIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_EncounterIDTitleFilterData", AV15BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_Encounter_RefuseReason_ReasonTitleFilterData", AV17BR_Encounter_RefuseReason_ReasonTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_Encounter_RefuseReason_NoApproveDateTitleFilterData", AV19BR_Encounter_RefuseReason_NoApproveDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21BR_Encounter_RefuseReason_StatusTitleFilterData", AV21BR_Encounter_RefuseReason_StatusTitleFilterData);
      }

      protected void E177E2( )
      {
         /* Ddo_br_encounter_refusereason_status_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_encounter_refusereason_status_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 5;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_encounter_refusereason_status_Sortedstatus = "ASC";
            ucDdo_br_encounter_refusereason_status.SendProperty(context, "", false, Ddo_br_encounter_refusereason_status_Internalname, "SortedStatus", Ddo_br_encounter_refusereason_status_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_encounter_refusereason_status_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 5;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_encounter_refusereason_status_Sortedstatus = "DSC";
            ucDdo_br_encounter_refusereason_status.SendProperty(context, "", false, Ddo_br_encounter_refusereason_status_Internalname, "SortedStatus", Ddo_br_encounter_refusereason_status_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_Encounter_RefuseReasonIDTitleFilterData", AV13BR_Encounter_RefuseReasonIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_EncounterIDTitleFilterData", AV15BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_Encounter_RefuseReason_ReasonTitleFilterData", AV17BR_Encounter_RefuseReason_ReasonTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_Encounter_RefuseReason_NoApproveDateTitleFilterData", AV19BR_Encounter_RefuseReason_NoApproveDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21BR_Encounter_RefuseReason_StatusTitleFilterData", AV21BR_Encounter_RefuseReason_StatusTitleFilterData);
      }

      private void E207E2( )
      {
         /* Grid_Load Routine */
         AV28Select = context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavSelect_Internalname, AV28Select);
         AV32Select_GXI = GXDbFile.PathToUrl( context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( )));
         edtavSelect_Tooltiptext = "选择";
         /* Load Method */
         if ( wbStart != -1 )
         {
            wbStart = 12;
         }
         sendrow_122( ) ;
         GRID_nCurrentRecord = (long)(GRID_nCurrentRecord+1);
         if ( isFullAjaxMode( ) && ! bGXsfl_12_Refreshing )
         {
            context.DoAjaxLoad(12, GridRow);
         }
         /*  Sending Event outputs  */
      }

      public void GXEnter( )
      {
         /* Execute user event: Enter */
         E217E2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E217E2( )
      {
         /* Enter Routine */
         AV8InOutBR_Encounter_RefuseReasonID = A348BR_Encounter_RefuseReasonID;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8InOutBR_Encounter_RefuseReasonID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8InOutBR_Encounter_RefuseReasonID), 18, 0)));
         AV9InOutBR_Encounter_RefuseReason_Reason = A349BR_Encounter_RefuseReason_Reason;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9InOutBR_Encounter_RefuseReason_Reason", AV9InOutBR_Encounter_RefuseReason_Reason);
         context.setWebReturnParms(new Object[] {(long)AV8InOutBR_Encounter_RefuseReasonID,(String)AV9InOutBR_Encounter_RefuseReason_Reason});
         context.setWebReturnParmsMetadata(new Object[] {"AV8InOutBR_Encounter_RefuseReasonID","AV9InOutBR_Encounter_RefuseReason_Reason"});
         context.wjLocDisableFrm = 1;
         context.nUserReturn = 1;
         returnInSub = true;
         if (true) return;
         /*  Sending Event outputs  */
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV8InOutBR_Encounter_RefuseReasonID = Convert.ToInt64(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8InOutBR_Encounter_RefuseReasonID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8InOutBR_Encounter_RefuseReasonID), 18, 0)));
         AV9InOutBR_Encounter_RefuseReason_Reason = (String)getParm(obj,1);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9InOutBR_Encounter_RefuseReason_Reason", AV9InOutBR_Encounter_RefuseReason_Reason);
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
         PA7E2( ) ;
         WS7E2( ) ;
         WE7E2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20202279465748", true);
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
         context.AddJavascriptSource("br_encounter_refusereasonprompt.js", "?20202279465749", false);
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

      protected void SubsflControlProps_122( )
      {
         edtavSelect_Internalname = "vSELECT_"+sGXsfl_12_idx;
         edtBR_Encounter_RefuseReasonID_Internalname = "BR_ENCOUNTER_REFUSEREASONID_"+sGXsfl_12_idx;
         edtBR_EncounterID_Internalname = "BR_ENCOUNTERID_"+sGXsfl_12_idx;
         edtBR_Encounter_RefuseReason_Reason_Internalname = "BR_ENCOUNTER_REFUSEREASON_REASON_"+sGXsfl_12_idx;
         edtBR_Encounter_RefuseReason_NoApproveDate_Internalname = "BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_"+sGXsfl_12_idx;
         cmbBR_Encounter_RefuseReason_Status_Internalname = "BR_ENCOUNTER_REFUSEREASON_STATUS_"+sGXsfl_12_idx;
      }

      protected void SubsflControlProps_fel_122( )
      {
         edtavSelect_Internalname = "vSELECT_"+sGXsfl_12_fel_idx;
         edtBR_Encounter_RefuseReasonID_Internalname = "BR_ENCOUNTER_REFUSEREASONID_"+sGXsfl_12_fel_idx;
         edtBR_EncounterID_Internalname = "BR_ENCOUNTERID_"+sGXsfl_12_fel_idx;
         edtBR_Encounter_RefuseReason_Reason_Internalname = "BR_ENCOUNTER_REFUSEREASON_REASON_"+sGXsfl_12_fel_idx;
         edtBR_Encounter_RefuseReason_NoApproveDate_Internalname = "BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE_"+sGXsfl_12_fel_idx;
         cmbBR_Encounter_RefuseReason_Status_Internalname = "BR_ENCOUNTER_REFUSEREASON_STATUS_"+sGXsfl_12_fel_idx;
      }

      protected void sendrow_122( )
      {
         SubsflControlProps_122( ) ;
         WB7E0( ) ;
         if ( ( subGrid_Rows * 1 == 0 ) || ( nGXsfl_12_idx <= subGrid_Recordsperpage( ) * 1 ) )
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
               if ( ((int)(((nGXsfl_12_idx-1)/ (decimal)(1)) % (2))) == 0 )
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
               context.WriteHtmlText( " gxrow=\""+sGXsfl_12_idx+"\">") ;
            }
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Active Bitmap Variable */
            TempTags = " " + ((edtavSelect_Enabled!=0)&&(edtavSelect_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 13,'',false,'',12)\"" : " ");
            ClassString = "SelectAttribute ActionBaseColorAttribute";
            StyleString = "";
            AV28Select_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV28Select))&&String.IsNullOrEmpty(StringUtil.RTrim( AV32Select_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV28Select)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV28Select)) ? AV32Select_GXI : context.PathToRelativeUrl( AV28Select));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavSelect_Internalname,(String)sImgUrl,(String)"",(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)edtavSelect_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)5,(String)edtavSelect_Jsonclick,"'"+""+"'"+",false,"+"'"+"EENTER."+sGXsfl_12_idx+"'",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)""+TempTags,(String)"",(String)"",(short)1,(bool)AV28Select_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Encounter_RefuseReasonID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A348BR_Encounter_RefuseReasonID), 18, 0, ".", "")),context.localUtil.Format( (decimal)(A348BR_Encounter_RefuseReasonID), "ZZZZZZZZZZZZZZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Encounter_RefuseReasonID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"ID",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_EncounterID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A19BR_EncounterID), 18, 0, ".", "")),context.localUtil.Format( (decimal)(A19BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_EncounterID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"ID",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Encounter_RefuseReason_Reason_Internalname,(String)A349BR_Encounter_RefuseReason_Reason,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Encounter_RefuseReason_Reason_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)300,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Encounter_RefuseReason_NoApproveDate_Internalname,context.localUtil.TToC( A350BR_Encounter_RefuseReason_NoApproveDate, 10, 8, 0, 0, "/", ":", " "),context.localUtil.Format( A350BR_Encounter_RefuseReason_NoApproveDate, "9999/99/99 99:99:99"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Encounter_RefuseReason_NoApproveDate_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)19,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"UpdDate",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            if ( ( cmbBR_Encounter_RefuseReason_Status.ItemCount == 0 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "BR_ENCOUNTER_REFUSEREASON_STATUS_" + sGXsfl_12_idx;
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
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Encounter_RefuseReason_Status_Internalname, "Values", (String)(cmbBR_Encounter_RefuseReason_Status.ToJavascriptSource()), !bGXsfl_12_Refreshing);
            send_integrity_lvl_hashes7E2( ) ;
            GridContainer.AddRow(GridRow);
            nGXsfl_12_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_12_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_12_idx+1));
            sGXsfl_12_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_12_idx), 4, 0)), 4, "0");
            SubsflControlProps_122( ) ;
         }
         /* End function sendrow_122 */
      }

      protected void init_web_controls( )
      {
         GXCCtl = "BR_ENCOUNTER_REFUSEREASON_STATUS_" + sGXsfl_12_idx;
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
         edtavSelect_Internalname = "vSELECT";
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
         edtavSelect_Jsonclick = "";
         edtavSelect_Visible = -1;
         edtavSelect_Enabled = 1;
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
         edtavSelect_Tooltiptext = "选择";
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
         subGrid_Class = "GridWithPaginationBar GridWithBorderColor WorkWith";
         subGrid_Backcolorstyle = 0;
         divTablemain_Height = 0;
         Ddo_br_encounter_refusereason_status_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_encounter_refusereason_status_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_encounter_refusereason_status_Sortasc = "WWP_TSSortASC";
         Ddo_br_encounter_refusereason_status_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_encounter_refusereason_status_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_encounter_refusereason_status_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_encounter_refusereason_status_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_encounter_refusereason_status_Titlecontrolidtoreplace = "";
         Ddo_br_encounter_refusereason_status_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_encounter_refusereason_status_Cls = "ColumnSettings";
         Ddo_br_encounter_refusereason_status_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_encounter_refusereason_status_Caption = "";
         Ddo_br_encounter_refusereason_noapprovedate_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_encounter_refusereason_noapprovedate_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_encounter_refusereason_noapprovedate_Sortasc = "WWP_TSSortASC";
         Ddo_br_encounter_refusereason_noapprovedate_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_encounter_refusereason_noapprovedate_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_encounter_refusereason_noapprovedate_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_encounter_refusereason_noapprovedate_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_encounter_refusereason_noapprovedate_Titlecontrolidtoreplace = "";
         Ddo_br_encounter_refusereason_noapprovedate_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_encounter_refusereason_noapprovedate_Cls = "ColumnSettings";
         Ddo_br_encounter_refusereason_noapprovedate_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_encounter_refusereason_noapprovedate_Caption = "";
         Ddo_br_encounter_refusereason_reason_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_encounter_refusereason_reason_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_encounter_refusereason_reason_Sortasc = "WWP_TSSortASC";
         Ddo_br_encounter_refusereason_reason_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_encounter_refusereason_reason_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_encounter_refusereason_reason_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_encounter_refusereason_reason_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_encounter_refusereason_reason_Titlecontrolidtoreplace = "";
         Ddo_br_encounter_refusereason_reason_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_encounter_refusereason_reason_Cls = "ColumnSettings";
         Ddo_br_encounter_refusereason_reason_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_encounter_refusereason_reason_Caption = "";
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
         Ddo_br_encounter_refusereasonid_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_encounter_refusereasonid_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_encounter_refusereasonid_Sortasc = "WWP_TSSortASC";
         Ddo_br_encounter_refusereasonid_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_encounter_refusereasonid_Includefilter = Convert.ToBoolean( 0);
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
         Form.Caption = "选择就诊信息驳回原因";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_Encounter_RefuseReasonIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_REASONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Encounter_RefuseReason_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]");
         setEventMetadata("REFRESH",",oparms:[{av:'AV13BR_Encounter_RefuseReasonIDTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASONIDTITLEFILTERDATA',pic:''},{av:'AV15BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Encounter_RefuseReason_ReasonTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASON_REASONTITLEFILTERDATA',pic:''},{av:'AV19BR_Encounter_RefuseReason_NoApproveDateTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATETITLEFILTERDATA',pic:''},{av:'AV21BR_Encounter_RefuseReason_StatusTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASON_STATUSTITLEFILTERDATA',pic:''},{av:'edtBR_Encounter_RefuseReasonID_Titleformat',ctrl:'BR_ENCOUNTER_REFUSEREASONID',prop:'Titleformat'},{av:'edtBR_Encounter_RefuseReasonID_Title',ctrl:'BR_ENCOUNTER_REFUSEREASONID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Encounter_RefuseReason_Reason_Titleformat',ctrl:'BR_ENCOUNTER_REFUSEREASON_REASON',prop:'Titleformat'},{av:'edtBR_Encounter_RefuseReason_Reason_Title',ctrl:'BR_ENCOUNTER_REFUSEREASON_REASON',prop:'Title'},{av:'edtBR_Encounter_RefuseReason_NoApproveDate_Titleformat',ctrl:'BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'Titleformat'},{av:'edtBR_Encounter_RefuseReason_NoApproveDate_Title',ctrl:'BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'Title'},{av:'cmbBR_Encounter_RefuseReason_Status'},{av:'AV25GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV26GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV27GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE","{handler:'E117E2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_Encounter_RefuseReasonIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_REASONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Encounter_RefuseReason_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'Gridpaginationbar_Selectedpage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE",",oparms:[]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE","{handler:'E127E2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_Encounter_RefuseReasonIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_REASONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Encounter_RefuseReason_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'Gridpaginationbar_Rowsperpageselectedvalue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE",",oparms:[{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]}");
         setEventMetadata("DDO_BR_ENCOUNTER_REFUSEREASONID.ONOPTIONCLICKED","{handler:'E137E2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_Encounter_RefuseReasonIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_REASONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Encounter_RefuseReason_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_encounter_refusereasonid_Activeeventkey',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASONID',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_ENCOUNTER_REFUSEREASONID.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_encounter_refusereasonid_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASONID',prop:'SortedStatus'},{av:'AV13BR_Encounter_RefuseReasonIDTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASONIDTITLEFILTERDATA',pic:''},{av:'AV15BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Encounter_RefuseReason_ReasonTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASON_REASONTITLEFILTERDATA',pic:''},{av:'AV19BR_Encounter_RefuseReason_NoApproveDateTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATETITLEFILTERDATA',pic:''},{av:'AV21BR_Encounter_RefuseReason_StatusTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASON_STATUSTITLEFILTERDATA',pic:''},{av:'edtBR_Encounter_RefuseReasonID_Titleformat',ctrl:'BR_ENCOUNTER_REFUSEREASONID',prop:'Titleformat'},{av:'edtBR_Encounter_RefuseReasonID_Title',ctrl:'BR_ENCOUNTER_REFUSEREASONID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Encounter_RefuseReason_Reason_Titleformat',ctrl:'BR_ENCOUNTER_REFUSEREASON_REASON',prop:'Titleformat'},{av:'edtBR_Encounter_RefuseReason_Reason_Title',ctrl:'BR_ENCOUNTER_REFUSEREASON_REASON',prop:'Title'},{av:'edtBR_Encounter_RefuseReason_NoApproveDate_Titleformat',ctrl:'BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'Titleformat'},{av:'edtBR_Encounter_RefuseReason_NoApproveDate_Title',ctrl:'BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'Title'},{av:'cmbBR_Encounter_RefuseReason_Status'},{av:'AV25GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV26GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV27GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_ENCOUNTERID.ONOPTIONCLICKED","{handler:'E147E2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_Encounter_RefuseReasonIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_REASONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Encounter_RefuseReason_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_encounterid_Activeeventkey',ctrl:'DDO_BR_ENCOUNTERID',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_ENCOUNTERID.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_encounterid_Sortedstatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'AV13BR_Encounter_RefuseReasonIDTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASONIDTITLEFILTERDATA',pic:''},{av:'AV15BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Encounter_RefuseReason_ReasonTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASON_REASONTITLEFILTERDATA',pic:''},{av:'AV19BR_Encounter_RefuseReason_NoApproveDateTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATETITLEFILTERDATA',pic:''},{av:'AV21BR_Encounter_RefuseReason_StatusTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASON_STATUSTITLEFILTERDATA',pic:''},{av:'edtBR_Encounter_RefuseReasonID_Titleformat',ctrl:'BR_ENCOUNTER_REFUSEREASONID',prop:'Titleformat'},{av:'edtBR_Encounter_RefuseReasonID_Title',ctrl:'BR_ENCOUNTER_REFUSEREASONID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Encounter_RefuseReason_Reason_Titleformat',ctrl:'BR_ENCOUNTER_REFUSEREASON_REASON',prop:'Titleformat'},{av:'edtBR_Encounter_RefuseReason_Reason_Title',ctrl:'BR_ENCOUNTER_REFUSEREASON_REASON',prop:'Title'},{av:'edtBR_Encounter_RefuseReason_NoApproveDate_Titleformat',ctrl:'BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'Titleformat'},{av:'edtBR_Encounter_RefuseReason_NoApproveDate_Title',ctrl:'BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'Title'},{av:'cmbBR_Encounter_RefuseReason_Status'},{av:'AV25GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV26GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV27GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_ENCOUNTER_REFUSEREASON_REASON.ONOPTIONCLICKED","{handler:'E157E2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_Encounter_RefuseReasonIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_REASONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Encounter_RefuseReason_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_encounter_refusereason_reason_Activeeventkey',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_REASON',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_ENCOUNTER_REFUSEREASON_REASON.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_encounter_refusereason_reason_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_REASON',prop:'SortedStatus'},{av:'AV13BR_Encounter_RefuseReasonIDTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASONIDTITLEFILTERDATA',pic:''},{av:'AV15BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Encounter_RefuseReason_ReasonTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASON_REASONTITLEFILTERDATA',pic:''},{av:'AV19BR_Encounter_RefuseReason_NoApproveDateTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATETITLEFILTERDATA',pic:''},{av:'AV21BR_Encounter_RefuseReason_StatusTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASON_STATUSTITLEFILTERDATA',pic:''},{av:'edtBR_Encounter_RefuseReasonID_Titleformat',ctrl:'BR_ENCOUNTER_REFUSEREASONID',prop:'Titleformat'},{av:'edtBR_Encounter_RefuseReasonID_Title',ctrl:'BR_ENCOUNTER_REFUSEREASONID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Encounter_RefuseReason_Reason_Titleformat',ctrl:'BR_ENCOUNTER_REFUSEREASON_REASON',prop:'Titleformat'},{av:'edtBR_Encounter_RefuseReason_Reason_Title',ctrl:'BR_ENCOUNTER_REFUSEREASON_REASON',prop:'Title'},{av:'edtBR_Encounter_RefuseReason_NoApproveDate_Titleformat',ctrl:'BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'Titleformat'},{av:'edtBR_Encounter_RefuseReason_NoApproveDate_Title',ctrl:'BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'Title'},{av:'cmbBR_Encounter_RefuseReason_Status'},{av:'AV25GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV26GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV27GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE.ONOPTIONCLICKED","{handler:'E167E2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_Encounter_RefuseReasonIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_REASONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Encounter_RefuseReason_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_encounter_refusereason_noapprovedate_Activeeventkey',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_encounter_refusereason_noapprovedate_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'SortedStatus'},{av:'AV13BR_Encounter_RefuseReasonIDTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASONIDTITLEFILTERDATA',pic:''},{av:'AV15BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Encounter_RefuseReason_ReasonTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASON_REASONTITLEFILTERDATA',pic:''},{av:'AV19BR_Encounter_RefuseReason_NoApproveDateTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATETITLEFILTERDATA',pic:''},{av:'AV21BR_Encounter_RefuseReason_StatusTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASON_STATUSTITLEFILTERDATA',pic:''},{av:'edtBR_Encounter_RefuseReasonID_Titleformat',ctrl:'BR_ENCOUNTER_REFUSEREASONID',prop:'Titleformat'},{av:'edtBR_Encounter_RefuseReasonID_Title',ctrl:'BR_ENCOUNTER_REFUSEREASONID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Encounter_RefuseReason_Reason_Titleformat',ctrl:'BR_ENCOUNTER_REFUSEREASON_REASON',prop:'Titleformat'},{av:'edtBR_Encounter_RefuseReason_Reason_Title',ctrl:'BR_ENCOUNTER_REFUSEREASON_REASON',prop:'Title'},{av:'edtBR_Encounter_RefuseReason_NoApproveDate_Titleformat',ctrl:'BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'Titleformat'},{av:'edtBR_Encounter_RefuseReason_NoApproveDate_Title',ctrl:'BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'Title'},{av:'cmbBR_Encounter_RefuseReason_Status'},{av:'AV25GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV26GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV27GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_ENCOUNTER_REFUSEREASON_STATUS.ONOPTIONCLICKED","{handler:'E177E2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_Encounter_RefuseReasonIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_REASONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Encounter_RefuseReason_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_REFUSEREASON_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_encounter_refusereason_status_Activeeventkey',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_STATUS',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_ENCOUNTER_REFUSEREASON_STATUS.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_encounter_refusereason_status_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_REFUSEREASON_STATUS',prop:'SortedStatus'},{av:'AV13BR_Encounter_RefuseReasonIDTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASONIDTITLEFILTERDATA',pic:''},{av:'AV15BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Encounter_RefuseReason_ReasonTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASON_REASONTITLEFILTERDATA',pic:''},{av:'AV19BR_Encounter_RefuseReason_NoApproveDateTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATETITLEFILTERDATA',pic:''},{av:'AV21BR_Encounter_RefuseReason_StatusTitleFilterData',fld:'vBR_ENCOUNTER_REFUSEREASON_STATUSTITLEFILTERDATA',pic:''},{av:'edtBR_Encounter_RefuseReasonID_Titleformat',ctrl:'BR_ENCOUNTER_REFUSEREASONID',prop:'Titleformat'},{av:'edtBR_Encounter_RefuseReasonID_Title',ctrl:'BR_ENCOUNTER_REFUSEREASONID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Encounter_RefuseReason_Reason_Titleformat',ctrl:'BR_ENCOUNTER_REFUSEREASON_REASON',prop:'Titleformat'},{av:'edtBR_Encounter_RefuseReason_Reason_Title',ctrl:'BR_ENCOUNTER_REFUSEREASON_REASON',prop:'Title'},{av:'edtBR_Encounter_RefuseReason_NoApproveDate_Titleformat',ctrl:'BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'Titleformat'},{av:'edtBR_Encounter_RefuseReason_NoApproveDate_Title',ctrl:'BR_ENCOUNTER_REFUSEREASON_NOAPPROVEDATE',prop:'Title'},{av:'cmbBR_Encounter_RefuseReason_Status'},{av:'AV25GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV26GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV27GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("GRID.LOAD","{handler:'E207E2',iparms:[]");
         setEventMetadata("GRID.LOAD",",oparms:[{av:'AV28Select',fld:'vSELECT',pic:''},{av:'edtavSelect_Tooltiptext',ctrl:'vSELECT',prop:'Tooltiptext'}]}");
         setEventMetadata("ENTER","{handler:'E217E2',iparms:[{av:'A348BR_Encounter_RefuseReasonID',fld:'BR_ENCOUNTER_REFUSEREASONID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'A349BR_Encounter_RefuseReason_Reason',fld:'BR_ENCOUNTER_REFUSEREASON_REASON',pic:'',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[{av:'AV8InOutBR_Encounter_RefuseReasonID',fld:'vINOUTBR_ENCOUNTER_REFUSEREASONID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV9InOutBR_Encounter_RefuseReason_Reason',fld:'vINOUTBR_ENCOUNTER_REFUSEREASON_REASON',pic:''}]}");
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
         wcpOAV9InOutBR_Encounter_RefuseReason_Reason = "";
         Gridpaginationbar_Selectedpage = "";
         Ddo_br_encounter_refusereasonid_Activeeventkey = "";
         Ddo_br_encounterid_Activeeventkey = "";
         Ddo_br_encounter_refusereason_reason_Activeeventkey = "";
         Ddo_br_encounter_refusereason_noapprovedate_Activeeventkey = "";
         Ddo_br_encounter_refusereason_status_Activeeventkey = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV14ddo_BR_Encounter_RefuseReasonIDTitleControlIdToReplace = "";
         AV16ddo_BR_EncounterIDTitleControlIdToReplace = "";
         AV18ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace = "";
         AV20ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace = "";
         AV22ddo_BR_Encounter_RefuseReason_StatusTitleControlIdToReplace = "";
         GXKey = "";
         AV31Pgmname = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         AV23DDO_TitleSettingsIcons = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV13BR_Encounter_RefuseReasonIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV15BR_EncounterIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV17BR_Encounter_RefuseReason_ReasonTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV19BR_Encounter_RefuseReason_NoApproveDateTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV21BR_Encounter_RefuseReason_StatusTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         Ddo_br_encounter_refusereasonid_Sortedstatus = "";
         Ddo_br_encounterid_Sortedstatus = "";
         Ddo_br_encounter_refusereason_reason_Sortedstatus = "";
         Ddo_br_encounter_refusereason_noapprovedate_Sortedstatus = "";
         Ddo_br_encounter_refusereason_status_Sortedstatus = "";
         GX_FocusControl = "";
         sPrefix = "";
         GridContainer = new GXWebGrid( context);
         sStyleString = "";
         subGrid_Linesclass = "";
         GridColumn = new GXWebColumn();
         AV28Select = "";
         A349BR_Encounter_RefuseReason_Reason = "";
         A350BR_Encounter_RefuseReason_NoApproveDate = (DateTime)(DateTime.MinValue);
         ucGridpaginationbar = new GXUserControl();
         ucDdo_br_encounter_refusereasonid = new GXUserControl();
         TempTags = "";
         ClassString = "";
         StyleString = "";
         ucDdo_br_encounterid = new GXUserControl();
         ucDdo_br_encounter_refusereason_reason = new GXUserControl();
         ucDdo_br_encounter_refusereason_noapprovedate = new GXUserControl();
         ucDdo_br_encounter_refusereason_status = new GXUserControl();
         ucWorkwithplusutilities1 = new GXUserControl();
         Form = new GXWebForm();
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV32Select_GXI = "";
         scmdbuf = "";
         H007E2_A351BR_Encounter_RefuseReason_Status = new short[1] ;
         H007E2_n351BR_Encounter_RefuseReason_Status = new bool[] {false} ;
         H007E2_A350BR_Encounter_RefuseReason_NoApproveDate = new DateTime[] {DateTime.MinValue} ;
         H007E2_n350BR_Encounter_RefuseReason_NoApproveDate = new bool[] {false} ;
         H007E2_A349BR_Encounter_RefuseReason_Reason = new String[] {""} ;
         H007E2_n349BR_Encounter_RefuseReason_Reason = new bool[] {false} ;
         H007E2_A19BR_EncounterID = new long[1] ;
         H007E2_A348BR_Encounter_RefuseReasonID = new long[1] ;
         H007E3_AGRID_nRecordCount = new long[1] ;
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV6WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         GridRow = new GXWebRow();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sImgUrl = "";
         ROClassString = "";
         GXCCtl = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_encounter_refusereasonprompt__default(),
            new Object[][] {
                new Object[] {
               H007E2_A351BR_Encounter_RefuseReason_Status, H007E2_n351BR_Encounter_RefuseReason_Status, H007E2_A350BR_Encounter_RefuseReason_NoApproveDate, H007E2_n350BR_Encounter_RefuseReason_NoApproveDate, H007E2_A349BR_Encounter_RefuseReason_Reason, H007E2_n349BR_Encounter_RefuseReason_Reason, H007E2_A19BR_EncounterID, H007E2_A348BR_Encounter_RefuseReasonID
               }
               , new Object[] {
               H007E3_AGRID_nRecordCount
               }
            }
         );
         AV31Pgmname = "BR_Encounter_RefuseReasonPrompt";
         /* GeneXus formulas. */
         AV31Pgmname = "BR_Encounter_RefuseReasonPrompt";
         context.Gx_err = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_GXsfl_12 ;
      private short nGXsfl_12_idx=1 ;
      private short GRID_nEOF ;
      private short AV11OrderedBy ;
      private short initialized ;
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
      private int divTablemain_Height ;
      private int subGrid_Titlebackcolor ;
      private int subGrid_Allbackcolor ;
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
      private int subGrid_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int AV24PageToGo ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private int edtavSelect_Enabled ;
      private int edtavSelect_Visible ;
      private long AV8InOutBR_Encounter_RefuseReasonID ;
      private long wcpOAV8InOutBR_Encounter_RefuseReasonID ;
      private long GRID_nFirstRecordOnPage ;
      private long AV25GridCurrentPage ;
      private long AV27GridRecordCount ;
      private long AV26GridPageSize ;
      private long A348BR_Encounter_RefuseReasonID ;
      private long A19BR_EncounterID ;
      private long GRID_nCurrentRecord ;
      private long GRID_nRecordCount ;
      private String Gridpaginationbar_Selectedpage ;
      private String Ddo_br_encounter_refusereasonid_Activeeventkey ;
      private String Ddo_br_encounterid_Activeeventkey ;
      private String Ddo_br_encounter_refusereason_reason_Activeeventkey ;
      private String Ddo_br_encounter_refusereason_noapprovedate_Activeeventkey ;
      private String Ddo_br_encounter_refusereason_status_Activeeventkey ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_12_idx="0001" ;
      private String GXKey ;
      private String AV31Pgmname ;
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
      private String Ddo_br_encounter_refusereasonid_Caption ;
      private String Ddo_br_encounter_refusereasonid_Tooltip ;
      private String Ddo_br_encounter_refusereasonid_Cls ;
      private String Ddo_br_encounter_refusereasonid_Dropdownoptionstype ;
      private String Ddo_br_encounter_refusereasonid_Titlecontrolidtoreplace ;
      private String Ddo_br_encounter_refusereasonid_Sortedstatus ;
      private String Ddo_br_encounter_refusereasonid_Sortasc ;
      private String Ddo_br_encounter_refusereasonid_Sortdsc ;
      private String Ddo_br_encounter_refusereasonid_Searchbuttontext ;
      private String Ddo_br_encounterid_Caption ;
      private String Ddo_br_encounterid_Tooltip ;
      private String Ddo_br_encounterid_Cls ;
      private String Ddo_br_encounterid_Dropdownoptionstype ;
      private String Ddo_br_encounterid_Titlecontrolidtoreplace ;
      private String Ddo_br_encounterid_Sortedstatus ;
      private String Ddo_br_encounterid_Sortasc ;
      private String Ddo_br_encounterid_Sortdsc ;
      private String Ddo_br_encounterid_Searchbuttontext ;
      private String Ddo_br_encounter_refusereason_reason_Caption ;
      private String Ddo_br_encounter_refusereason_reason_Tooltip ;
      private String Ddo_br_encounter_refusereason_reason_Cls ;
      private String Ddo_br_encounter_refusereason_reason_Dropdownoptionstype ;
      private String Ddo_br_encounter_refusereason_reason_Titlecontrolidtoreplace ;
      private String Ddo_br_encounter_refusereason_reason_Sortedstatus ;
      private String Ddo_br_encounter_refusereason_reason_Sortasc ;
      private String Ddo_br_encounter_refusereason_reason_Sortdsc ;
      private String Ddo_br_encounter_refusereason_reason_Searchbuttontext ;
      private String Ddo_br_encounter_refusereason_noapprovedate_Caption ;
      private String Ddo_br_encounter_refusereason_noapprovedate_Tooltip ;
      private String Ddo_br_encounter_refusereason_noapprovedate_Cls ;
      private String Ddo_br_encounter_refusereason_noapprovedate_Dropdownoptionstype ;
      private String Ddo_br_encounter_refusereason_noapprovedate_Titlecontrolidtoreplace ;
      private String Ddo_br_encounter_refusereason_noapprovedate_Sortedstatus ;
      private String Ddo_br_encounter_refusereason_noapprovedate_Sortasc ;
      private String Ddo_br_encounter_refusereason_noapprovedate_Sortdsc ;
      private String Ddo_br_encounter_refusereason_noapprovedate_Searchbuttontext ;
      private String Ddo_br_encounter_refusereason_status_Caption ;
      private String Ddo_br_encounter_refusereason_status_Tooltip ;
      private String Ddo_br_encounter_refusereason_status_Cls ;
      private String Ddo_br_encounter_refusereason_status_Dropdownoptionstype ;
      private String Ddo_br_encounter_refusereason_status_Titlecontrolidtoreplace ;
      private String Ddo_br_encounter_refusereason_status_Sortedstatus ;
      private String Ddo_br_encounter_refusereason_status_Sortasc ;
      private String Ddo_br_encounter_refusereason_status_Sortdsc ;
      private String Ddo_br_encounter_refusereason_status_Searchbuttontext ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divLayoutmaintable_Internalname ;
      private String divTablemain_Internalname ;
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
      private String edtavSelect_Tooltiptext ;
      private String divHtml_gridpaginationbar_Internalname ;
      private String Gridpaginationbar_Internalname ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String Ddo_br_encounter_refusereasonid_Internalname ;
      private String TempTags ;
      private String ClassString ;
      private String StyleString ;
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
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavSelect_Internalname ;
      private String edtBR_Encounter_RefuseReasonID_Internalname ;
      private String edtBR_EncounterID_Internalname ;
      private String edtBR_Encounter_RefuseReason_Reason_Internalname ;
      private String edtBR_Encounter_RefuseReason_NoApproveDate_Internalname ;
      private String cmbBR_Encounter_RefuseReason_Status_Internalname ;
      private String scmdbuf ;
      private String sGXsfl_12_fel_idx="0001" ;
      private String sImgUrl ;
      private String edtavSelect_Jsonclick ;
      private String ROClassString ;
      private String edtBR_Encounter_RefuseReasonID_Jsonclick ;
      private String edtBR_EncounterID_Jsonclick ;
      private String edtBR_Encounter_RefuseReason_Reason_Jsonclick ;
      private String edtBR_Encounter_RefuseReason_NoApproveDate_Jsonclick ;
      private String GXCCtl ;
      private String cmbBR_Encounter_RefuseReason_Status_Jsonclick ;
      private DateTime A350BR_Encounter_RefuseReason_NoApproveDate ;
      private bool entryPointCalled ;
      private bool AV12OrderedDsc ;
      private bool toggleJsOutput ;
      private bool Gridpaginationbar_Showfirst ;
      private bool Gridpaginationbar_Showprevious ;
      private bool Gridpaginationbar_Shownext ;
      private bool Gridpaginationbar_Showlast ;
      private bool Gridpaginationbar_Rowsperpageselector ;
      private bool Ddo_br_encounter_refusereasonid_Includesortasc ;
      private bool Ddo_br_encounter_refusereasonid_Includesortdsc ;
      private bool Ddo_br_encounter_refusereasonid_Includefilter ;
      private bool Ddo_br_encounter_refusereasonid_Includedatalist ;
      private bool Ddo_br_encounterid_Includesortasc ;
      private bool Ddo_br_encounterid_Includesortdsc ;
      private bool Ddo_br_encounterid_Includefilter ;
      private bool Ddo_br_encounterid_Includedatalist ;
      private bool Ddo_br_encounter_refusereason_reason_Includesortasc ;
      private bool Ddo_br_encounter_refusereason_reason_Includesortdsc ;
      private bool Ddo_br_encounter_refusereason_reason_Includefilter ;
      private bool Ddo_br_encounter_refusereason_reason_Includedatalist ;
      private bool Ddo_br_encounter_refusereason_noapprovedate_Includesortasc ;
      private bool Ddo_br_encounter_refusereason_noapprovedate_Includesortdsc ;
      private bool Ddo_br_encounter_refusereason_noapprovedate_Includefilter ;
      private bool Ddo_br_encounter_refusereason_noapprovedate_Includedatalist ;
      private bool Ddo_br_encounter_refusereason_status_Includesortasc ;
      private bool Ddo_br_encounter_refusereason_status_Includesortdsc ;
      private bool Ddo_br_encounter_refusereason_status_Includefilter ;
      private bool Ddo_br_encounter_refusereason_status_Includedatalist ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_12_Refreshing=false ;
      private bool n349BR_Encounter_RefuseReason_Reason ;
      private bool n350BR_Encounter_RefuseReason_NoApproveDate ;
      private bool n351BR_Encounter_RefuseReason_Status ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool AV5IsAuthorized ;
      private bool GXt_boolean1 ;
      private bool gx_refresh_fired ;
      private bool AV28Select_IsBlob ;
      private String AV9InOutBR_Encounter_RefuseReason_Reason ;
      private String wcpOAV9InOutBR_Encounter_RefuseReason_Reason ;
      private String AV14ddo_BR_Encounter_RefuseReasonIDTitleControlIdToReplace ;
      private String AV16ddo_BR_EncounterIDTitleControlIdToReplace ;
      private String AV18ddo_BR_Encounter_RefuseReason_ReasonTitleControlIdToReplace ;
      private String AV20ddo_BR_Encounter_RefuseReason_NoApproveDateTitleControlIdToReplace ;
      private String AV22ddo_BR_Encounter_RefuseReason_StatusTitleControlIdToReplace ;
      private String A349BR_Encounter_RefuseReason_Reason ;
      private String AV32Select_GXI ;
      private String AV28Select ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private GXUserControl ucGridpaginationbar ;
      private GXUserControl ucDdo_br_encounter_refusereasonid ;
      private GXUserControl ucDdo_br_encounterid ;
      private GXUserControl ucDdo_br_encounter_refusereason_reason ;
      private GXUserControl ucDdo_br_encounter_refusereason_noapprovedate ;
      private GXUserControl ucDdo_br_encounter_refusereason_status ;
      private GXUserControl ucWorkwithplusutilities1 ;
      private GXWebForm Form ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private long aP0_InOutBR_Encounter_RefuseReasonID ;
      private String aP1_InOutBR_Encounter_RefuseReason_Reason ;
      private GXCombobox cmbBR_Encounter_RefuseReason_Status ;
      private IDataStoreProvider pr_default ;
      private short[] H007E2_A351BR_Encounter_RefuseReason_Status ;
      private bool[] H007E2_n351BR_Encounter_RefuseReason_Status ;
      private DateTime[] H007E2_A350BR_Encounter_RefuseReason_NoApproveDate ;
      private bool[] H007E2_n350BR_Encounter_RefuseReason_NoApproveDate ;
      private String[] H007E2_A349BR_Encounter_RefuseReason_Reason ;
      private bool[] H007E2_n349BR_Encounter_RefuseReason_Reason ;
      private long[] H007E2_A19BR_EncounterID ;
      private long[] H007E2_A348BR_Encounter_RefuseReasonID ;
      private long[] H007E3_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV13BR_Encounter_RefuseReasonIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV15BR_EncounterIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV17BR_Encounter_RefuseReason_ReasonTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV19BR_Encounter_RefuseReason_NoApproveDateTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV21BR_Encounter_RefuseReason_StatusTitleFilterData ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons AV23DDO_TitleSettingsIcons ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 ;
   }

   public class br_encounter_refusereasonprompt__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H007E2( IGxContext context ,
                                             short AV11OrderedBy ,
                                             bool AV12OrderedDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int3 ;
         GXv_int3 = new short [3] ;
         Object[] GXv_Object4 ;
         GXv_Object4 = new Object [2] ;
         String sSelectString ;
         String sFromString ;
         String sOrderString ;
         sSelectString = " [BR_Encounter_RefuseReason_Status], [BR_Encounter_RefuseReason_NoApproveDate], [BR_Encounter_RefuseReason_Reason], [BR_EncounterID], [BR_Encounter_RefuseReasonID]";
         sFromString = " FROM [BR_Encounter_RefuseReason] WITH (NOLOCK)";
         sOrderString = "";
         if ( ( AV11OrderedBy == 1 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Encounter_RefuseReasonID]";
         }
         else if ( ( AV11OrderedBy == 1 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Encounter_RefuseReasonID] DESC";
         }
         else if ( ( AV11OrderedBy == 2 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_EncounterID]";
         }
         else if ( ( AV11OrderedBy == 2 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_EncounterID] DESC";
         }
         else if ( ( AV11OrderedBy == 3 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Encounter_RefuseReason_Reason]";
         }
         else if ( ( AV11OrderedBy == 3 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Encounter_RefuseReason_Reason] DESC";
         }
         else if ( ( AV11OrderedBy == 4 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Encounter_RefuseReason_NoApproveDate]";
         }
         else if ( ( AV11OrderedBy == 4 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Encounter_RefuseReason_NoApproveDate] DESC";
         }
         else if ( ( AV11OrderedBy == 5 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Encounter_RefuseReason_Status]";
         }
         else if ( ( AV11OrderedBy == 5 ) && ( AV12OrderedDsc ) )
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

      protected Object[] conditional_H007E3( IGxContext context ,
                                             short AV11OrderedBy ,
                                             bool AV12OrderedDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         Object[] GXv_Object5 ;
         GXv_Object5 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM [BR_Encounter_RefuseReason] WITH (NOLOCK)";
         if ( ( AV11OrderedBy == 1 ) && ! AV12OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 1 ) && ( AV12OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 2 ) && ! AV12OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 2 ) && ( AV12OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 3 ) && ! AV12OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 3 ) && ( AV12OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 4 ) && ! AV12OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 4 ) && ( AV12OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 5 ) && ! AV12OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 5 ) && ( AV12OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( true )
         {
            scmdbuf = scmdbuf + "";
         }
         GXv_Object5[0] = scmdbuf;
         return GXv_Object5 ;
      }

      public override Object [] getDynamicStatement( int cursor ,
                                                     IGxContext context ,
                                                     Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 0 :
                     return conditional_H007E2(context, (short)dynConstraints[0] , (bool)dynConstraints[1] );
               case 1 :
                     return conditional_H007E3(context, (short)dynConstraints[0] , (bool)dynConstraints[1] );
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
          Object[] prmH007E2 ;
          prmH007E2 = new Object[] {
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH007E3 ;
          prmH007E3 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("H007E2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH007E2,11,0,true,false )
             ,new CursorDef("H007E3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH007E3,1,0,true,false )
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
                   stmt.SetParameter(sIdx, (int)parms[3]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[4]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[5]);
                }
                return;
       }
    }

 }

}
