/*
               File: BR_EncounterReasonPrompt
        Description: 选择初审不通过原因
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:15:58.64
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
   public class br_encounterreasonprompt : GXHttpHandler, System.Web.SessionState.IRequiresSessionState
   {
      public br_encounterreasonprompt( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_encounterreasonprompt( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( ref long aP0_InOutBR_Encounter_ID ,
                           ref String aP1_InOutBR_EncounterReason_Reason )
      {
         this.AV8InOutBR_Encounter_ID = aP0_InOutBR_Encounter_ID;
         this.AV9InOutBR_EncounterReason_Reason = aP1_InOutBR_EncounterReason_Reason;
         executePrivate();
         aP0_InOutBR_Encounter_ID=this.AV8InOutBR_Encounter_ID;
         aP1_InOutBR_EncounterReason_Reason=this.AV9InOutBR_EncounterReason_Reason;
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         chkBR_EncounterReason_IsRandApprove = new GXCheckbox();
         cmbBR_EncounterReason_Status = new GXCombobox();
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
               AV14ddo_BR_Encounter_IDTitleControlIdToReplace = GetNextPar( );
               AV16ddo_BR_EncounterIDTitleControlIdToReplace = GetNextPar( );
               AV18ddo_BR_EncounterReason_ReasonTitleControlIdToReplace = GetNextPar( );
               AV20ddo_BR_EncounterReason_IsRandNoApproveDateTitleControlIdToReplace = GetNextPar( );
               AV22ddo_BR_EncounterReason_IsRandApproveTitleControlIdToReplace = GetNextPar( );
               AV24ddo_BR_EncounterReason_StatusTitleControlIdToReplace = GetNextPar( );
               AV26ddo_BR_EncounterReason_IsRandApproverTitleControlIdToReplace = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_BR_Encounter_IDTitleControlIdToReplace, AV16ddo_BR_EncounterIDTitleControlIdToReplace, AV18ddo_BR_EncounterReason_ReasonTitleControlIdToReplace, AV20ddo_BR_EncounterReason_IsRandNoApproveDateTitleControlIdToReplace, AV22ddo_BR_EncounterReason_IsRandApproveTitleControlIdToReplace, AV24ddo_BR_EncounterReason_StatusTitleControlIdToReplace, AV26ddo_BR_EncounterReason_IsRandApproverTitleControlIdToReplace) ;
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
               AV8InOutBR_Encounter_ID = (long)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8InOutBR_Encounter_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8InOutBR_Encounter_ID), 15, 0)));
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV9InOutBR_EncounterReason_Reason = GetNextPar( );
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9InOutBR_EncounterReason_Reason", AV9InOutBR_EncounterReason_Reason);
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
            PA792( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV35Pgmname = "BR_EncounterReasonPrompt";
               context.Gx_err = 0;
               WS792( ) ;
               if ( ! isAjaxCallMode( ) )
               {
                  WE792( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?202022815155878", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_encounterreasonprompt.aspx") + "?" + UrlEncode("" +AV8InOutBR_Encounter_ID) + "," + UrlEncode(StringUtil.RTrim(AV9InOutBR_EncounterReason_Reason))+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "vGRIDCURRENTPAGE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV29GridCurrentPage), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDRECORDCOUNT", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV31GridRecordCount), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDPAGESIZE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV30GridPageSize), 10, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vDDO_TITLESETTINGSICONS", AV27DDO_TitleSettingsIcons);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vDDO_TITLESETTINGSICONS", AV27DDO_TitleSettingsIcons);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_ENCOUNTER_IDTITLEFILTERDATA", AV13BR_Encounter_IDTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_ENCOUNTER_IDTITLEFILTERDATA", AV13BR_Encounter_IDTitleFilterData);
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
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_ENCOUNTERREASON_REASONTITLEFILTERDATA", AV17BR_EncounterReason_ReasonTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_ENCOUNTERREASON_REASONTITLEFILTERDATA", AV17BR_EncounterReason_ReasonTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_ENCOUNTERREASON_ISRANDNOAPPROVEDATETITLEFILTERDATA", AV19BR_EncounterReason_IsRandNoApproveDateTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_ENCOUNTERREASON_ISRANDNOAPPROVEDATETITLEFILTERDATA", AV19BR_EncounterReason_IsRandNoApproveDateTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_ENCOUNTERREASON_ISRANDAPPROVETITLEFILTERDATA", AV21BR_EncounterReason_IsRandApproveTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_ENCOUNTERREASON_ISRANDAPPROVETITLEFILTERDATA", AV21BR_EncounterReason_IsRandApproveTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_ENCOUNTERREASON_STATUSTITLEFILTERDATA", AV23BR_EncounterReason_StatusTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_ENCOUNTERREASON_STATUSTITLEFILTERDATA", AV23BR_EncounterReason_StatusTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_ENCOUNTERREASON_ISRANDAPPROVERTITLEFILTERDATA", AV25BR_EncounterReason_IsRandApproverTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_ENCOUNTERREASON_ISRANDAPPROVERTITLEFILTERDATA", AV25BR_EncounterReason_IsRandApproverTitleFilterData);
         }
         GxWebStd.gx_hidden_field( context, "vINOUTBR_ENCOUNTER_ID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8InOutBR_Encounter_ID), 15, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vINOUTBR_ENCOUNTERREASON_REASON", AV9InOutBR_EncounterReason_Reason);
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
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ID_Caption", StringUtil.RTrim( Ddo_br_encounter_id_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ID_Tooltip", StringUtil.RTrim( Ddo_br_encounter_id_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ID_Cls", StringUtil.RTrim( Ddo_br_encounter_id_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ID_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_encounter_id_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ID_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_encounter_id_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ID_Includesortasc", StringUtil.BoolToStr( Ddo_br_encounter_id_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ID_Includesortdsc", StringUtil.BoolToStr( Ddo_br_encounter_id_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ID_Sortedstatus", StringUtil.RTrim( Ddo_br_encounter_id_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ID_Includefilter", StringUtil.BoolToStr( Ddo_br_encounter_id_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ID_Includedatalist", StringUtil.BoolToStr( Ddo_br_encounter_id_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ID_Sortasc", StringUtil.RTrim( Ddo_br_encounter_id_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ID_Sortdsc", StringUtil.RTrim( Ddo_br_encounter_id_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ID_Searchbuttontext", StringUtil.RTrim( Ddo_br_encounter_id_Searchbuttontext));
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
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERREASON_REASON_Caption", StringUtil.RTrim( Ddo_br_encounterreason_reason_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERREASON_REASON_Tooltip", StringUtil.RTrim( Ddo_br_encounterreason_reason_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERREASON_REASON_Cls", StringUtil.RTrim( Ddo_br_encounterreason_reason_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERREASON_REASON_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_encounterreason_reason_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERREASON_REASON_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_encounterreason_reason_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERREASON_REASON_Includesortasc", StringUtil.BoolToStr( Ddo_br_encounterreason_reason_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERREASON_REASON_Includesortdsc", StringUtil.BoolToStr( Ddo_br_encounterreason_reason_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERREASON_REASON_Sortedstatus", StringUtil.RTrim( Ddo_br_encounterreason_reason_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERREASON_REASON_Includefilter", StringUtil.BoolToStr( Ddo_br_encounterreason_reason_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERREASON_REASON_Includedatalist", StringUtil.BoolToStr( Ddo_br_encounterreason_reason_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERREASON_REASON_Sortasc", StringUtil.RTrim( Ddo_br_encounterreason_reason_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERREASON_REASON_Sortdsc", StringUtil.RTrim( Ddo_br_encounterreason_reason_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERREASON_REASON_Searchbuttontext", StringUtil.RTrim( Ddo_br_encounterreason_reason_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE_Caption", StringUtil.RTrim( Ddo_br_encounterreason_israndnoapprovedate_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE_Tooltip", StringUtil.RTrim( Ddo_br_encounterreason_israndnoapprovedate_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE_Cls", StringUtil.RTrim( Ddo_br_encounterreason_israndnoapprovedate_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_encounterreason_israndnoapprovedate_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_encounterreason_israndnoapprovedate_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE_Includesortasc", StringUtil.BoolToStr( Ddo_br_encounterreason_israndnoapprovedate_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE_Includesortdsc", StringUtil.BoolToStr( Ddo_br_encounterreason_israndnoapprovedate_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE_Sortedstatus", StringUtil.RTrim( Ddo_br_encounterreason_israndnoapprovedate_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE_Includefilter", StringUtil.BoolToStr( Ddo_br_encounterreason_israndnoapprovedate_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE_Includedatalist", StringUtil.BoolToStr( Ddo_br_encounterreason_israndnoapprovedate_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE_Sortasc", StringUtil.RTrim( Ddo_br_encounterreason_israndnoapprovedate_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE_Sortdsc", StringUtil.RTrim( Ddo_br_encounterreason_israndnoapprovedate_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE_Searchbuttontext", StringUtil.RTrim( Ddo_br_encounterreason_israndnoapprovedate_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERREASON_ISRANDAPPROVE_Caption", StringUtil.RTrim( Ddo_br_encounterreason_israndapprove_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERREASON_ISRANDAPPROVE_Tooltip", StringUtil.RTrim( Ddo_br_encounterreason_israndapprove_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERREASON_ISRANDAPPROVE_Cls", StringUtil.RTrim( Ddo_br_encounterreason_israndapprove_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERREASON_ISRANDAPPROVE_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_encounterreason_israndapprove_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERREASON_ISRANDAPPROVE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_encounterreason_israndapprove_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERREASON_ISRANDAPPROVE_Includesortasc", StringUtil.BoolToStr( Ddo_br_encounterreason_israndapprove_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERREASON_ISRANDAPPROVE_Includesortdsc", StringUtil.BoolToStr( Ddo_br_encounterreason_israndapprove_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERREASON_ISRANDAPPROVE_Sortedstatus", StringUtil.RTrim( Ddo_br_encounterreason_israndapprove_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERREASON_ISRANDAPPROVE_Includefilter", StringUtil.BoolToStr( Ddo_br_encounterreason_israndapprove_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERREASON_ISRANDAPPROVE_Includedatalist", StringUtil.BoolToStr( Ddo_br_encounterreason_israndapprove_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERREASON_ISRANDAPPROVE_Sortasc", StringUtil.RTrim( Ddo_br_encounterreason_israndapprove_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERREASON_ISRANDAPPROVE_Sortdsc", StringUtil.RTrim( Ddo_br_encounterreason_israndapprove_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERREASON_ISRANDAPPROVE_Searchbuttontext", StringUtil.RTrim( Ddo_br_encounterreason_israndapprove_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERREASON_STATUS_Caption", StringUtil.RTrim( Ddo_br_encounterreason_status_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERREASON_STATUS_Tooltip", StringUtil.RTrim( Ddo_br_encounterreason_status_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERREASON_STATUS_Cls", StringUtil.RTrim( Ddo_br_encounterreason_status_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERREASON_STATUS_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_encounterreason_status_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERREASON_STATUS_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_encounterreason_status_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERREASON_STATUS_Includesortasc", StringUtil.BoolToStr( Ddo_br_encounterreason_status_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERREASON_STATUS_Includesortdsc", StringUtil.BoolToStr( Ddo_br_encounterreason_status_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERREASON_STATUS_Sortedstatus", StringUtil.RTrim( Ddo_br_encounterreason_status_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERREASON_STATUS_Includefilter", StringUtil.BoolToStr( Ddo_br_encounterreason_status_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERREASON_STATUS_Includedatalist", StringUtil.BoolToStr( Ddo_br_encounterreason_status_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERREASON_STATUS_Sortasc", StringUtil.RTrim( Ddo_br_encounterreason_status_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERREASON_STATUS_Sortdsc", StringUtil.RTrim( Ddo_br_encounterreason_status_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERREASON_STATUS_Searchbuttontext", StringUtil.RTrim( Ddo_br_encounterreason_status_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERREASON_ISRANDAPPROVER_Caption", StringUtil.RTrim( Ddo_br_encounterreason_israndapprover_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERREASON_ISRANDAPPROVER_Tooltip", StringUtil.RTrim( Ddo_br_encounterreason_israndapprover_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERREASON_ISRANDAPPROVER_Cls", StringUtil.RTrim( Ddo_br_encounterreason_israndapprover_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERREASON_ISRANDAPPROVER_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_encounterreason_israndapprover_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERREASON_ISRANDAPPROVER_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_encounterreason_israndapprover_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERREASON_ISRANDAPPROVER_Includesortasc", StringUtil.BoolToStr( Ddo_br_encounterreason_israndapprover_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERREASON_ISRANDAPPROVER_Includesortdsc", StringUtil.BoolToStr( Ddo_br_encounterreason_israndapprover_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERREASON_ISRANDAPPROVER_Sortedstatus", StringUtil.RTrim( Ddo_br_encounterreason_israndapprover_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERREASON_ISRANDAPPROVER_Includefilter", StringUtil.BoolToStr( Ddo_br_encounterreason_israndapprover_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERREASON_ISRANDAPPROVER_Includedatalist", StringUtil.BoolToStr( Ddo_br_encounterreason_israndapprover_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERREASON_ISRANDAPPROVER_Sortasc", StringUtil.RTrim( Ddo_br_encounterreason_israndapprover_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERREASON_ISRANDAPPROVER_Sortdsc", StringUtil.RTrim( Ddo_br_encounterreason_israndapprover_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERREASON_ISRANDAPPROVER_Searchbuttontext", StringUtil.RTrim( Ddo_br_encounterreason_israndapprover_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ID_Activeeventkey", StringUtil.RTrim( Ddo_br_encounter_id_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Activeeventkey", StringUtil.RTrim( Ddo_br_encounterid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERREASON_REASON_Activeeventkey", StringUtil.RTrim( Ddo_br_encounterreason_reason_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE_Activeeventkey", StringUtil.RTrim( Ddo_br_encounterreason_israndnoapprovedate_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERREASON_ISRANDAPPROVE_Activeeventkey", StringUtil.RTrim( Ddo_br_encounterreason_israndapprove_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERREASON_STATUS_Activeeventkey", StringUtil.RTrim( Ddo_br_encounterreason_status_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERREASON_ISRANDAPPROVER_Activeeventkey", StringUtil.RTrim( Ddo_br_encounterreason_israndapprover_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ID_Activeeventkey", StringUtil.RTrim( Ddo_br_encounter_id_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Activeeventkey", StringUtil.RTrim( Ddo_br_encounterid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERREASON_REASON_Activeeventkey", StringUtil.RTrim( Ddo_br_encounterreason_reason_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE_Activeeventkey", StringUtil.RTrim( Ddo_br_encounterreason_israndnoapprovedate_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERREASON_ISRANDAPPROVE_Activeeventkey", StringUtil.RTrim( Ddo_br_encounterreason_israndapprove_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERREASON_STATUS_Activeeventkey", StringUtil.RTrim( Ddo_br_encounterreason_status_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERREASON_ISRANDAPPROVER_Activeeventkey", StringUtil.RTrim( Ddo_br_encounterreason_israndapprover_Activeeventkey));
      }

      protected void RenderHtmlCloseForm792( )
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
         return "BR_EncounterReasonPrompt" ;
      }

      public override String GetPgmdesc( )
      {
         return "选择初审不通过原因" ;
      }

      protected void WB790( )
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
               if ( edtBR_Encounter_ID_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Encounter_ID_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Encounter_ID_Title) ;
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
               if ( edtBR_EncounterReason_Reason_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_EncounterReason_Reason_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_EncounterReason_Reason_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_EncounterReason_IsRandNoApproveDate_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_EncounterReason_IsRandNoApproveDate_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_EncounterReason_IsRandNoApproveDate_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"AttributeCheckBox"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( chkBR_EncounterReason_IsRandApprove_Titleformat == 0 )
               {
                  context.SendWebValue( chkBR_EncounterReason_IsRandApprove.Title.Text) ;
               }
               else
               {
                  context.WriteHtmlText( chkBR_EncounterReason_IsRandApprove.Title.Text) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( cmbBR_EncounterReason_Status_Titleformat == 0 )
               {
                  context.SendWebValue( cmbBR_EncounterReason_Status.Title.Text) ;
               }
               else
               {
                  context.WriteHtmlText( cmbBR_EncounterReason_Status.Title.Text) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_EncounterReason_IsRandApprover_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_EncounterReason_IsRandApprover_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_EncounterReason_IsRandApprover_Title) ;
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
               GridColumn.AddObjectProperty("Value", context.convertURL( AV32Select));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavSelect_Tooltiptext));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A347BR_Encounter_ID), 15, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Encounter_ID_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Encounter_ID_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A19BR_EncounterID), 18, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_EncounterID_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_EncounterID_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A340BR_EncounterReason_Reason);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_EncounterReason_Reason_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_EncounterReason_Reason_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.localUtil.TToC( A341BR_EncounterReason_IsRandNoApproveDate, 10, 8, 0, 0, "/", ":", " "));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_EncounterReason_IsRandNoApproveDate_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_EncounterReason_IsRandNoApproveDate_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.BoolToStr( A342BR_EncounterReason_IsRandApprove));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( chkBR_EncounterReason_IsRandApprove.Title.Text));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(chkBR_EncounterReason_IsRandApprove_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A343BR_EncounterReason_Status), 4, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( cmbBR_EncounterReason_Status.Title.Text));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(cmbBR_EncounterReason_Status_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A344BR_EncounterReason_IsRandApprover);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_EncounterReason_IsRandApprover_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_EncounterReason_IsRandApprover_Titleformat), 4, 0, ".", "")));
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
            ucGridpaginationbar.SetProperty("CurrentPage", AV29GridCurrentPage);
            ucGridpaginationbar.SetProperty("RecordCount", AV31GridRecordCount);
            ucGridpaginationbar.SetProperty("Page", AV30GridPageSize);
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
            ucDdo_br_encounter_id.SetProperty("Caption", Ddo_br_encounter_id_Caption);
            ucDdo_br_encounter_id.SetProperty("Tooltip", Ddo_br_encounter_id_Tooltip);
            ucDdo_br_encounter_id.SetProperty("Cls", Ddo_br_encounter_id_Cls);
            ucDdo_br_encounter_id.SetProperty("DropDownOptionsType", Ddo_br_encounter_id_Dropdownoptionstype);
            ucDdo_br_encounter_id.SetProperty("IncludeSortASC", Ddo_br_encounter_id_Includesortasc);
            ucDdo_br_encounter_id.SetProperty("IncludeSortDSC", Ddo_br_encounter_id_Includesortdsc);
            ucDdo_br_encounter_id.SetProperty("IncludeFilter", Ddo_br_encounter_id_Includefilter);
            ucDdo_br_encounter_id.SetProperty("IncludeDataList", Ddo_br_encounter_id_Includedatalist);
            ucDdo_br_encounter_id.SetProperty("SortASC", Ddo_br_encounter_id_Sortasc);
            ucDdo_br_encounter_id.SetProperty("SortDSC", Ddo_br_encounter_id_Sortdsc);
            ucDdo_br_encounter_id.SetProperty("SearchButtonText", Ddo_br_encounter_id_Searchbuttontext);
            ucDdo_br_encounter_id.SetProperty("DropDownOptionsTitleSettingsIcons", AV27DDO_TitleSettingsIcons);
            ucDdo_br_encounter_id.SetProperty("DropDownOptionsData", AV13BR_Encounter_IDTitleFilterData);
            ucDdo_br_encounter_id.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_encounter_id_Internalname, "DDO_BR_ENCOUNTER_IDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_encounter_idtitlecontrolidtoreplace_Internalname, AV14ddo_BR_Encounter_IDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,29);\"", 0, edtavDdo_br_encounter_idtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_EncounterReasonPrompt.htm");
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
            ucDdo_br_encounterid.SetProperty("DropDownOptionsTitleSettingsIcons", AV27DDO_TitleSettingsIcons);
            ucDdo_br_encounterid.SetProperty("DropDownOptionsData", AV15BR_EncounterIDTitleFilterData);
            ucDdo_br_encounterid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_encounterid_Internalname, "DDO_BR_ENCOUNTERIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 31,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_encounteridtitlecontrolidtoreplace_Internalname, AV16ddo_BR_EncounterIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,31);\"", 0, edtavDdo_br_encounteridtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_EncounterReasonPrompt.htm");
            /* User Defined Control */
            ucDdo_br_encounterreason_reason.SetProperty("Caption", Ddo_br_encounterreason_reason_Caption);
            ucDdo_br_encounterreason_reason.SetProperty("Tooltip", Ddo_br_encounterreason_reason_Tooltip);
            ucDdo_br_encounterreason_reason.SetProperty("Cls", Ddo_br_encounterreason_reason_Cls);
            ucDdo_br_encounterreason_reason.SetProperty("DropDownOptionsType", Ddo_br_encounterreason_reason_Dropdownoptionstype);
            ucDdo_br_encounterreason_reason.SetProperty("IncludeSortASC", Ddo_br_encounterreason_reason_Includesortasc);
            ucDdo_br_encounterreason_reason.SetProperty("IncludeSortDSC", Ddo_br_encounterreason_reason_Includesortdsc);
            ucDdo_br_encounterreason_reason.SetProperty("IncludeFilter", Ddo_br_encounterreason_reason_Includefilter);
            ucDdo_br_encounterreason_reason.SetProperty("IncludeDataList", Ddo_br_encounterreason_reason_Includedatalist);
            ucDdo_br_encounterreason_reason.SetProperty("SortASC", Ddo_br_encounterreason_reason_Sortasc);
            ucDdo_br_encounterreason_reason.SetProperty("SortDSC", Ddo_br_encounterreason_reason_Sortdsc);
            ucDdo_br_encounterreason_reason.SetProperty("SearchButtonText", Ddo_br_encounterreason_reason_Searchbuttontext);
            ucDdo_br_encounterreason_reason.SetProperty("DropDownOptionsTitleSettingsIcons", AV27DDO_TitleSettingsIcons);
            ucDdo_br_encounterreason_reason.SetProperty("DropDownOptionsData", AV17BR_EncounterReason_ReasonTitleFilterData);
            ucDdo_br_encounterreason_reason.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_encounterreason_reason_Internalname, "DDO_BR_ENCOUNTERREASON_REASONContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 33,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_encounterreason_reasontitlecontrolidtoreplace_Internalname, AV18ddo_BR_EncounterReason_ReasonTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,33);\"", 0, edtavDdo_br_encounterreason_reasontitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_EncounterReasonPrompt.htm");
            /* User Defined Control */
            ucDdo_br_encounterreason_israndnoapprovedate.SetProperty("Caption", Ddo_br_encounterreason_israndnoapprovedate_Caption);
            ucDdo_br_encounterreason_israndnoapprovedate.SetProperty("Tooltip", Ddo_br_encounterreason_israndnoapprovedate_Tooltip);
            ucDdo_br_encounterreason_israndnoapprovedate.SetProperty("Cls", Ddo_br_encounterreason_israndnoapprovedate_Cls);
            ucDdo_br_encounterreason_israndnoapprovedate.SetProperty("DropDownOptionsType", Ddo_br_encounterreason_israndnoapprovedate_Dropdownoptionstype);
            ucDdo_br_encounterreason_israndnoapprovedate.SetProperty("IncludeSortASC", Ddo_br_encounterreason_israndnoapprovedate_Includesortasc);
            ucDdo_br_encounterreason_israndnoapprovedate.SetProperty("IncludeSortDSC", Ddo_br_encounterreason_israndnoapprovedate_Includesortdsc);
            ucDdo_br_encounterreason_israndnoapprovedate.SetProperty("IncludeFilter", Ddo_br_encounterreason_israndnoapprovedate_Includefilter);
            ucDdo_br_encounterreason_israndnoapprovedate.SetProperty("IncludeDataList", Ddo_br_encounterreason_israndnoapprovedate_Includedatalist);
            ucDdo_br_encounterreason_israndnoapprovedate.SetProperty("SortASC", Ddo_br_encounterreason_israndnoapprovedate_Sortasc);
            ucDdo_br_encounterreason_israndnoapprovedate.SetProperty("SortDSC", Ddo_br_encounterreason_israndnoapprovedate_Sortdsc);
            ucDdo_br_encounterreason_israndnoapprovedate.SetProperty("SearchButtonText", Ddo_br_encounterreason_israndnoapprovedate_Searchbuttontext);
            ucDdo_br_encounterreason_israndnoapprovedate.SetProperty("DropDownOptionsTitleSettingsIcons", AV27DDO_TitleSettingsIcons);
            ucDdo_br_encounterreason_israndnoapprovedate.SetProperty("DropDownOptionsData", AV19BR_EncounterReason_IsRandNoApproveDateTitleFilterData);
            ucDdo_br_encounterreason_israndnoapprovedate.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_encounterreason_israndnoapprovedate_Internalname, "DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 35,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_encounterreason_israndnoapprovedatetitlecontrolidtoreplace_Internalname, AV20ddo_BR_EncounterReason_IsRandNoApproveDateTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,35);\"", 0, edtavDdo_br_encounterreason_israndnoapprovedatetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_EncounterReasonPrompt.htm");
            /* User Defined Control */
            ucDdo_br_encounterreason_israndapprove.SetProperty("Caption", Ddo_br_encounterreason_israndapprove_Caption);
            ucDdo_br_encounterreason_israndapprove.SetProperty("Tooltip", Ddo_br_encounterreason_israndapprove_Tooltip);
            ucDdo_br_encounterreason_israndapprove.SetProperty("Cls", Ddo_br_encounterreason_israndapprove_Cls);
            ucDdo_br_encounterreason_israndapprove.SetProperty("DropDownOptionsType", Ddo_br_encounterreason_israndapprove_Dropdownoptionstype);
            ucDdo_br_encounterreason_israndapprove.SetProperty("IncludeSortASC", Ddo_br_encounterreason_israndapprove_Includesortasc);
            ucDdo_br_encounterreason_israndapprove.SetProperty("IncludeSortDSC", Ddo_br_encounterreason_israndapprove_Includesortdsc);
            ucDdo_br_encounterreason_israndapprove.SetProperty("IncludeFilter", Ddo_br_encounterreason_israndapprove_Includefilter);
            ucDdo_br_encounterreason_israndapprove.SetProperty("IncludeDataList", Ddo_br_encounterreason_israndapprove_Includedatalist);
            ucDdo_br_encounterreason_israndapprove.SetProperty("SortASC", Ddo_br_encounterreason_israndapprove_Sortasc);
            ucDdo_br_encounterreason_israndapprove.SetProperty("SortDSC", Ddo_br_encounterreason_israndapprove_Sortdsc);
            ucDdo_br_encounterreason_israndapprove.SetProperty("SearchButtonText", Ddo_br_encounterreason_israndapprove_Searchbuttontext);
            ucDdo_br_encounterreason_israndapprove.SetProperty("DropDownOptionsTitleSettingsIcons", AV27DDO_TitleSettingsIcons);
            ucDdo_br_encounterreason_israndapprove.SetProperty("DropDownOptionsData", AV21BR_EncounterReason_IsRandApproveTitleFilterData);
            ucDdo_br_encounterreason_israndapprove.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_encounterreason_israndapprove_Internalname, "DDO_BR_ENCOUNTERREASON_ISRANDAPPROVEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 37,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_encounterreason_israndapprovetitlecontrolidtoreplace_Internalname, AV22ddo_BR_EncounterReason_IsRandApproveTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,37);\"", 0, edtavDdo_br_encounterreason_israndapprovetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_EncounterReasonPrompt.htm");
            /* User Defined Control */
            ucDdo_br_encounterreason_status.SetProperty("Caption", Ddo_br_encounterreason_status_Caption);
            ucDdo_br_encounterreason_status.SetProperty("Tooltip", Ddo_br_encounterreason_status_Tooltip);
            ucDdo_br_encounterreason_status.SetProperty("Cls", Ddo_br_encounterreason_status_Cls);
            ucDdo_br_encounterreason_status.SetProperty("DropDownOptionsType", Ddo_br_encounterreason_status_Dropdownoptionstype);
            ucDdo_br_encounterreason_status.SetProperty("IncludeSortASC", Ddo_br_encounterreason_status_Includesortasc);
            ucDdo_br_encounterreason_status.SetProperty("IncludeSortDSC", Ddo_br_encounterreason_status_Includesortdsc);
            ucDdo_br_encounterreason_status.SetProperty("IncludeFilter", Ddo_br_encounterreason_status_Includefilter);
            ucDdo_br_encounterreason_status.SetProperty("IncludeDataList", Ddo_br_encounterreason_status_Includedatalist);
            ucDdo_br_encounterreason_status.SetProperty("SortASC", Ddo_br_encounterreason_status_Sortasc);
            ucDdo_br_encounterreason_status.SetProperty("SortDSC", Ddo_br_encounterreason_status_Sortdsc);
            ucDdo_br_encounterreason_status.SetProperty("SearchButtonText", Ddo_br_encounterreason_status_Searchbuttontext);
            ucDdo_br_encounterreason_status.SetProperty("DropDownOptionsTitleSettingsIcons", AV27DDO_TitleSettingsIcons);
            ucDdo_br_encounterreason_status.SetProperty("DropDownOptionsData", AV23BR_EncounterReason_StatusTitleFilterData);
            ucDdo_br_encounterreason_status.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_encounterreason_status_Internalname, "DDO_BR_ENCOUNTERREASON_STATUSContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_encounterreason_statustitlecontrolidtoreplace_Internalname, AV24ddo_BR_EncounterReason_StatusTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,39);\"", 0, edtavDdo_br_encounterreason_statustitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_EncounterReasonPrompt.htm");
            /* User Defined Control */
            ucDdo_br_encounterreason_israndapprover.SetProperty("Caption", Ddo_br_encounterreason_israndapprover_Caption);
            ucDdo_br_encounterreason_israndapprover.SetProperty("Tooltip", Ddo_br_encounterreason_israndapprover_Tooltip);
            ucDdo_br_encounterreason_israndapprover.SetProperty("Cls", Ddo_br_encounterreason_israndapprover_Cls);
            ucDdo_br_encounterreason_israndapprover.SetProperty("DropDownOptionsType", Ddo_br_encounterreason_israndapprover_Dropdownoptionstype);
            ucDdo_br_encounterreason_israndapprover.SetProperty("IncludeSortASC", Ddo_br_encounterreason_israndapprover_Includesortasc);
            ucDdo_br_encounterreason_israndapprover.SetProperty("IncludeSortDSC", Ddo_br_encounterreason_israndapprover_Includesortdsc);
            ucDdo_br_encounterreason_israndapprover.SetProperty("IncludeFilter", Ddo_br_encounterreason_israndapprover_Includefilter);
            ucDdo_br_encounterreason_israndapprover.SetProperty("IncludeDataList", Ddo_br_encounterreason_israndapprover_Includedatalist);
            ucDdo_br_encounterreason_israndapprover.SetProperty("SortASC", Ddo_br_encounterreason_israndapprover_Sortasc);
            ucDdo_br_encounterreason_israndapprover.SetProperty("SortDSC", Ddo_br_encounterreason_israndapprover_Sortdsc);
            ucDdo_br_encounterreason_israndapprover.SetProperty("SearchButtonText", Ddo_br_encounterreason_israndapprover_Searchbuttontext);
            ucDdo_br_encounterreason_israndapprover.SetProperty("DropDownOptionsTitleSettingsIcons", AV27DDO_TitleSettingsIcons);
            ucDdo_br_encounterreason_israndapprover.SetProperty("DropDownOptionsData", AV25BR_EncounterReason_IsRandApproverTitleFilterData);
            ucDdo_br_encounterreason_israndapprover.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_encounterreason_israndapprover_Internalname, "DDO_BR_ENCOUNTERREASON_ISRANDAPPROVERContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 41,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_encounterreason_israndapprovertitlecontrolidtoreplace_Internalname, AV26ddo_BR_EncounterReason_IsRandApproverTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,41);\"", 0, edtavDdo_br_encounterreason_israndapprovertitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_EncounterReasonPrompt.htm");
            /* User Defined Control */
            ucWorkwithplusutilities1.Render(context, "dvelop.workwithplusutilities", Workwithplusutilities1_Internalname, "WORKWITHPLUSUTILITIES1Container");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'" + sGXsfl_12_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrderedby_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11OrderedBy), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV11OrderedBy), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,43);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrderedby_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrderedby_Visible, 1, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_EncounterReasonPrompt.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'" + sGXsfl_12_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrdereddsc_Internalname, StringUtil.BoolToStr( AV12OrderedDsc), StringUtil.BoolToStr( AV12OrderedDsc), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,44);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrdereddsc_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrdereddsc_Visible, 1, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, 0, 0, true, "", "right", false, "HLP_BR_EncounterReasonPrompt.htm");
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

      protected void START792( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_0-127771", 0) ;
            Form.Meta.addItem("description", "选择初审不通过原因", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP790( ) ;
      }

      protected void WS792( )
      {
         START792( ) ;
         EVT792( ) ;
      }

      protected void EVT792( )
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
                           E11792 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEROWSPERPAGE") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E12792 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_ENCOUNTER_ID.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E13792 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_ENCOUNTERID.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E14792 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_ENCOUNTERREASON_REASON.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E15792 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E16792 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_ENCOUNTERREASON_ISRANDAPPROVE.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E17792 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_ENCOUNTERREASON_STATUS.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E18792 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_ENCOUNTERREASON_ISRANDAPPROVER.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E19792 ();
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
                           AV32Select = cgiGet( edtavSelect_Internalname);
                           context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSelect_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV32Select)) ? AV36Select_GXI : context.convertURL( context.PathToRelativeUrl( AV32Select))), !bGXsfl_12_Refreshing);
                           context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSelect_Internalname, "SrcSet", context.GetImageSrcSet( AV32Select), true);
                           A347BR_Encounter_ID = (long)(context.localUtil.CToN( cgiGet( edtBR_Encounter_ID_Internalname), ".", ","));
                           A19BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( edtBR_EncounterID_Internalname), ".", ","));
                           A340BR_EncounterReason_Reason = cgiGet( edtBR_EncounterReason_Reason_Internalname);
                           n340BR_EncounterReason_Reason = false;
                           A341BR_EncounterReason_IsRandNoApproveDate = context.localUtil.CToT( cgiGet( edtBR_EncounterReason_IsRandNoApproveDate_Internalname), 0);
                           n341BR_EncounterReason_IsRandNoApproveDate = false;
                           A342BR_EncounterReason_IsRandApprove = StringUtil.StrToBool( cgiGet( chkBR_EncounterReason_IsRandApprove_Internalname));
                           n342BR_EncounterReason_IsRandApprove = false;
                           cmbBR_EncounterReason_Status.Name = cmbBR_EncounterReason_Status_Internalname;
                           cmbBR_EncounterReason_Status.CurrentValue = cgiGet( cmbBR_EncounterReason_Status_Internalname);
                           A343BR_EncounterReason_Status = (short)(NumberUtil.Val( cgiGet( cmbBR_EncounterReason_Status_Internalname), "."));
                           n343BR_EncounterReason_Status = false;
                           A344BR_EncounterReason_IsRandApprover = cgiGet( edtBR_EncounterReason_IsRandApprover_Internalname);
                           n344BR_EncounterReason_IsRandApprover = false;
                           sEvtType = StringUtil.Right( sEvt, 1);
                           if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                           {
                              sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                              if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 /* Execute user event: Start */
                                 E20792 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 /* Execute user event: Refresh */
                                 E21792 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "GRID.LOAD") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 E22792 ();
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
                                       E23792 ();
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

      protected void WE792( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm792( ) ;
            }
         }
      }

      protected void PA792( )
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
               GX_FocusControl = edtavDdo_br_encounter_idtitlecontrolidtoreplace_Internalname;
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
                                       String AV14ddo_BR_Encounter_IDTitleControlIdToReplace ,
                                       String AV16ddo_BR_EncounterIDTitleControlIdToReplace ,
                                       String AV18ddo_BR_EncounterReason_ReasonTitleControlIdToReplace ,
                                       String AV20ddo_BR_EncounterReason_IsRandNoApproveDateTitleControlIdToReplace ,
                                       String AV22ddo_BR_EncounterReason_IsRandApproveTitleControlIdToReplace ,
                                       String AV24ddo_BR_EncounterReason_StatusTitleControlIdToReplace ,
                                       String AV26ddo_BR_EncounterReason_IsRandApproverTitleControlIdToReplace )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GRID_nCurrentRecord = 0;
         RF792( ) ;
         /* End function gxgrGrid_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_BR_ENCOUNTER_ID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A347BR_Encounter_ID), "ZZZZZZZZZZZZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "BR_ENCOUNTER_ID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A347BR_Encounter_ID), 15, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_BR_ENCOUNTERREASON_REASON", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( A340BR_EncounterReason_Reason, "")), context));
         GxWebStd.gx_hidden_field( context, "BR_ENCOUNTERREASON_REASON", A340BR_EncounterReason_Reason);
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
         RF792( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV35Pgmname = "BR_EncounterReasonPrompt";
         context.Gx_err = 0;
      }

      protected void RF792( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridContainer.ClearRows();
         }
         wbStart = 12;
         /* Execute user event: Refresh */
         E21792 ();
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
            /* Using cursor H00792 */
            pr_default.execute(0, new Object[] {GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_12_idx = 1;
            sGXsfl_12_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_12_idx), 4, 0)), 4, "0");
            SubsflControlProps_122( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < subGrid_Recordsperpage( ) ) ) ) )
            {
               A344BR_EncounterReason_IsRandApprover = H00792_A344BR_EncounterReason_IsRandApprover[0];
               n344BR_EncounterReason_IsRandApprover = H00792_n344BR_EncounterReason_IsRandApprover[0];
               A343BR_EncounterReason_Status = H00792_A343BR_EncounterReason_Status[0];
               n343BR_EncounterReason_Status = H00792_n343BR_EncounterReason_Status[0];
               A342BR_EncounterReason_IsRandApprove = H00792_A342BR_EncounterReason_IsRandApprove[0];
               n342BR_EncounterReason_IsRandApprove = H00792_n342BR_EncounterReason_IsRandApprove[0];
               A341BR_EncounterReason_IsRandNoApproveDate = H00792_A341BR_EncounterReason_IsRandNoApproveDate[0];
               n341BR_EncounterReason_IsRandNoApproveDate = H00792_n341BR_EncounterReason_IsRandNoApproveDate[0];
               A340BR_EncounterReason_Reason = H00792_A340BR_EncounterReason_Reason[0];
               n340BR_EncounterReason_Reason = H00792_n340BR_EncounterReason_Reason[0];
               A19BR_EncounterID = H00792_A19BR_EncounterID[0];
               A347BR_Encounter_ID = H00792_A347BR_Encounter_ID[0];
               E22792 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 12;
            WB790( ) ;
         }
         bGXsfl_12_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes792( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_BR_ENCOUNTER_ID"+"_"+sGXsfl_12_idx, GetSecureSignedToken( sGXsfl_12_idx, context.localUtil.Format( (decimal)(A347BR_Encounter_ID), "ZZZZZZZZZZZZZZ9"), context));
         GxWebStd.gx_hidden_field( context, "gxhash_BR_ENCOUNTERREASON_REASON"+"_"+sGXsfl_12_idx, GetSecureSignedToken( sGXsfl_12_idx, StringUtil.RTrim( context.localUtil.Format( A340BR_EncounterReason_Reason, "")), context));
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
         /* Using cursor H00793 */
         pr_default.execute(1);
         GRID_nRecordCount = H00793_AGRID_nRecordCount[0];
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
            gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_BR_Encounter_IDTitleControlIdToReplace, AV16ddo_BR_EncounterIDTitleControlIdToReplace, AV18ddo_BR_EncounterReason_ReasonTitleControlIdToReplace, AV20ddo_BR_EncounterReason_IsRandNoApproveDateTitleControlIdToReplace, AV22ddo_BR_EncounterReason_IsRandApproveTitleControlIdToReplace, AV24ddo_BR_EncounterReason_StatusTitleControlIdToReplace, AV26ddo_BR_EncounterReason_IsRandApproverTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_BR_Encounter_IDTitleControlIdToReplace, AV16ddo_BR_EncounterIDTitleControlIdToReplace, AV18ddo_BR_EncounterReason_ReasonTitleControlIdToReplace, AV20ddo_BR_EncounterReason_IsRandNoApproveDateTitleControlIdToReplace, AV22ddo_BR_EncounterReason_IsRandApproveTitleControlIdToReplace, AV24ddo_BR_EncounterReason_StatusTitleControlIdToReplace, AV26ddo_BR_EncounterReason_IsRandApproverTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_BR_Encounter_IDTitleControlIdToReplace, AV16ddo_BR_EncounterIDTitleControlIdToReplace, AV18ddo_BR_EncounterReason_ReasonTitleControlIdToReplace, AV20ddo_BR_EncounterReason_IsRandNoApproveDateTitleControlIdToReplace, AV22ddo_BR_EncounterReason_IsRandApproveTitleControlIdToReplace, AV24ddo_BR_EncounterReason_StatusTitleControlIdToReplace, AV26ddo_BR_EncounterReason_IsRandApproverTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_BR_Encounter_IDTitleControlIdToReplace, AV16ddo_BR_EncounterIDTitleControlIdToReplace, AV18ddo_BR_EncounterReason_ReasonTitleControlIdToReplace, AV20ddo_BR_EncounterReason_IsRandNoApproveDateTitleControlIdToReplace, AV22ddo_BR_EncounterReason_IsRandApproveTitleControlIdToReplace, AV24ddo_BR_EncounterReason_StatusTitleControlIdToReplace, AV26ddo_BR_EncounterReason_IsRandApproverTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_BR_Encounter_IDTitleControlIdToReplace, AV16ddo_BR_EncounterIDTitleControlIdToReplace, AV18ddo_BR_EncounterReason_ReasonTitleControlIdToReplace, AV20ddo_BR_EncounterReason_IsRandNoApproveDateTitleControlIdToReplace, AV22ddo_BR_EncounterReason_IsRandApproveTitleControlIdToReplace, AV24ddo_BR_EncounterReason_StatusTitleControlIdToReplace, AV26ddo_BR_EncounterReason_IsRandApproverTitleControlIdToReplace) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP790( )
      {
         /* Before Start, stand alone formulas. */
         AV35Pgmname = "BR_EncounterReasonPrompt";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E20792 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( "vDDO_TITLESETTINGSICONS"), AV27DDO_TitleSettingsIcons);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_ENCOUNTER_IDTITLEFILTERDATA"), AV13BR_Encounter_IDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_ENCOUNTERIDTITLEFILTERDATA"), AV15BR_EncounterIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_ENCOUNTERREASON_REASONTITLEFILTERDATA"), AV17BR_EncounterReason_ReasonTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_ENCOUNTERREASON_ISRANDNOAPPROVEDATETITLEFILTERDATA"), AV19BR_EncounterReason_IsRandNoApproveDateTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_ENCOUNTERREASON_ISRANDAPPROVETITLEFILTERDATA"), AV21BR_EncounterReason_IsRandApproveTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_ENCOUNTERREASON_STATUSTITLEFILTERDATA"), AV23BR_EncounterReason_StatusTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_ENCOUNTERREASON_ISRANDAPPROVERTITLEFILTERDATA"), AV25BR_EncounterReason_IsRandApproverTitleFilterData);
            /* Read variables values. */
            AV14ddo_BR_Encounter_IDTitleControlIdToReplace = cgiGet( edtavDdo_br_encounter_idtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14ddo_BR_Encounter_IDTitleControlIdToReplace", AV14ddo_BR_Encounter_IDTitleControlIdToReplace);
            AV16ddo_BR_EncounterIDTitleControlIdToReplace = cgiGet( edtavDdo_br_encounteridtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16ddo_BR_EncounterIDTitleControlIdToReplace", AV16ddo_BR_EncounterIDTitleControlIdToReplace);
            AV18ddo_BR_EncounterReason_ReasonTitleControlIdToReplace = cgiGet( edtavDdo_br_encounterreason_reasontitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18ddo_BR_EncounterReason_ReasonTitleControlIdToReplace", AV18ddo_BR_EncounterReason_ReasonTitleControlIdToReplace);
            AV20ddo_BR_EncounterReason_IsRandNoApproveDateTitleControlIdToReplace = cgiGet( edtavDdo_br_encounterreason_israndnoapprovedatetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20ddo_BR_EncounterReason_IsRandNoApproveDateTitleControlIdToReplace", AV20ddo_BR_EncounterReason_IsRandNoApproveDateTitleControlIdToReplace);
            AV22ddo_BR_EncounterReason_IsRandApproveTitleControlIdToReplace = cgiGet( edtavDdo_br_encounterreason_israndapprovetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22ddo_BR_EncounterReason_IsRandApproveTitleControlIdToReplace", AV22ddo_BR_EncounterReason_IsRandApproveTitleControlIdToReplace);
            AV24ddo_BR_EncounterReason_StatusTitleControlIdToReplace = cgiGet( edtavDdo_br_encounterreason_statustitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24ddo_BR_EncounterReason_StatusTitleControlIdToReplace", AV24ddo_BR_EncounterReason_StatusTitleControlIdToReplace);
            AV26ddo_BR_EncounterReason_IsRandApproverTitleControlIdToReplace = cgiGet( edtavDdo_br_encounterreason_israndapprovertitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26ddo_BR_EncounterReason_IsRandApproverTitleControlIdToReplace", AV26ddo_BR_EncounterReason_IsRandApproverTitleControlIdToReplace);
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
            AV29GridCurrentPage = (long)(context.localUtil.CToN( cgiGet( "vGRIDCURRENTPAGE"), ".", ","));
            AV31GridRecordCount = (long)(context.localUtil.CToN( cgiGet( "vGRIDRECORDCOUNT"), ".", ","));
            AV30GridPageSize = (long)(context.localUtil.CToN( cgiGet( "vGRIDPAGESIZE"), ".", ","));
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
            Ddo_br_encounter_id_Caption = cgiGet( "DDO_BR_ENCOUNTER_ID_Caption");
            Ddo_br_encounter_id_Tooltip = cgiGet( "DDO_BR_ENCOUNTER_ID_Tooltip");
            Ddo_br_encounter_id_Cls = cgiGet( "DDO_BR_ENCOUNTER_ID_Cls");
            Ddo_br_encounter_id_Dropdownoptionstype = cgiGet( "DDO_BR_ENCOUNTER_ID_Dropdownoptionstype");
            Ddo_br_encounter_id_Titlecontrolidtoreplace = cgiGet( "DDO_BR_ENCOUNTER_ID_Titlecontrolidtoreplace");
            Ddo_br_encounter_id_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_ID_Includesortasc"));
            Ddo_br_encounter_id_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_ID_Includesortdsc"));
            Ddo_br_encounter_id_Sortedstatus = cgiGet( "DDO_BR_ENCOUNTER_ID_Sortedstatus");
            Ddo_br_encounter_id_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_ID_Includefilter"));
            Ddo_br_encounter_id_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_ID_Includedatalist"));
            Ddo_br_encounter_id_Sortasc = cgiGet( "DDO_BR_ENCOUNTER_ID_Sortasc");
            Ddo_br_encounter_id_Sortdsc = cgiGet( "DDO_BR_ENCOUNTER_ID_Sortdsc");
            Ddo_br_encounter_id_Searchbuttontext = cgiGet( "DDO_BR_ENCOUNTER_ID_Searchbuttontext");
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
            Ddo_br_encounterreason_reason_Caption = cgiGet( "DDO_BR_ENCOUNTERREASON_REASON_Caption");
            Ddo_br_encounterreason_reason_Tooltip = cgiGet( "DDO_BR_ENCOUNTERREASON_REASON_Tooltip");
            Ddo_br_encounterreason_reason_Cls = cgiGet( "DDO_BR_ENCOUNTERREASON_REASON_Cls");
            Ddo_br_encounterreason_reason_Dropdownoptionstype = cgiGet( "DDO_BR_ENCOUNTERREASON_REASON_Dropdownoptionstype");
            Ddo_br_encounterreason_reason_Titlecontrolidtoreplace = cgiGet( "DDO_BR_ENCOUNTERREASON_REASON_Titlecontrolidtoreplace");
            Ddo_br_encounterreason_reason_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTERREASON_REASON_Includesortasc"));
            Ddo_br_encounterreason_reason_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTERREASON_REASON_Includesortdsc"));
            Ddo_br_encounterreason_reason_Sortedstatus = cgiGet( "DDO_BR_ENCOUNTERREASON_REASON_Sortedstatus");
            Ddo_br_encounterreason_reason_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTERREASON_REASON_Includefilter"));
            Ddo_br_encounterreason_reason_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTERREASON_REASON_Includedatalist"));
            Ddo_br_encounterreason_reason_Sortasc = cgiGet( "DDO_BR_ENCOUNTERREASON_REASON_Sortasc");
            Ddo_br_encounterreason_reason_Sortdsc = cgiGet( "DDO_BR_ENCOUNTERREASON_REASON_Sortdsc");
            Ddo_br_encounterreason_reason_Searchbuttontext = cgiGet( "DDO_BR_ENCOUNTERREASON_REASON_Searchbuttontext");
            Ddo_br_encounterreason_israndnoapprovedate_Caption = cgiGet( "DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE_Caption");
            Ddo_br_encounterreason_israndnoapprovedate_Tooltip = cgiGet( "DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE_Tooltip");
            Ddo_br_encounterreason_israndnoapprovedate_Cls = cgiGet( "DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE_Cls");
            Ddo_br_encounterreason_israndnoapprovedate_Dropdownoptionstype = cgiGet( "DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE_Dropdownoptionstype");
            Ddo_br_encounterreason_israndnoapprovedate_Titlecontrolidtoreplace = cgiGet( "DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE_Titlecontrolidtoreplace");
            Ddo_br_encounterreason_israndnoapprovedate_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE_Includesortasc"));
            Ddo_br_encounterreason_israndnoapprovedate_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE_Includesortdsc"));
            Ddo_br_encounterreason_israndnoapprovedate_Sortedstatus = cgiGet( "DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE_Sortedstatus");
            Ddo_br_encounterreason_israndnoapprovedate_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE_Includefilter"));
            Ddo_br_encounterreason_israndnoapprovedate_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE_Includedatalist"));
            Ddo_br_encounterreason_israndnoapprovedate_Sortasc = cgiGet( "DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE_Sortasc");
            Ddo_br_encounterreason_israndnoapprovedate_Sortdsc = cgiGet( "DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE_Sortdsc");
            Ddo_br_encounterreason_israndnoapprovedate_Searchbuttontext = cgiGet( "DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE_Searchbuttontext");
            Ddo_br_encounterreason_israndapprove_Caption = cgiGet( "DDO_BR_ENCOUNTERREASON_ISRANDAPPROVE_Caption");
            Ddo_br_encounterreason_israndapprove_Tooltip = cgiGet( "DDO_BR_ENCOUNTERREASON_ISRANDAPPROVE_Tooltip");
            Ddo_br_encounterreason_israndapprove_Cls = cgiGet( "DDO_BR_ENCOUNTERREASON_ISRANDAPPROVE_Cls");
            Ddo_br_encounterreason_israndapprove_Dropdownoptionstype = cgiGet( "DDO_BR_ENCOUNTERREASON_ISRANDAPPROVE_Dropdownoptionstype");
            Ddo_br_encounterreason_israndapprove_Titlecontrolidtoreplace = cgiGet( "DDO_BR_ENCOUNTERREASON_ISRANDAPPROVE_Titlecontrolidtoreplace");
            Ddo_br_encounterreason_israndapprove_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTERREASON_ISRANDAPPROVE_Includesortasc"));
            Ddo_br_encounterreason_israndapprove_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTERREASON_ISRANDAPPROVE_Includesortdsc"));
            Ddo_br_encounterreason_israndapprove_Sortedstatus = cgiGet( "DDO_BR_ENCOUNTERREASON_ISRANDAPPROVE_Sortedstatus");
            Ddo_br_encounterreason_israndapprove_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTERREASON_ISRANDAPPROVE_Includefilter"));
            Ddo_br_encounterreason_israndapprove_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTERREASON_ISRANDAPPROVE_Includedatalist"));
            Ddo_br_encounterreason_israndapprove_Sortasc = cgiGet( "DDO_BR_ENCOUNTERREASON_ISRANDAPPROVE_Sortasc");
            Ddo_br_encounterreason_israndapprove_Sortdsc = cgiGet( "DDO_BR_ENCOUNTERREASON_ISRANDAPPROVE_Sortdsc");
            Ddo_br_encounterreason_israndapprove_Searchbuttontext = cgiGet( "DDO_BR_ENCOUNTERREASON_ISRANDAPPROVE_Searchbuttontext");
            Ddo_br_encounterreason_status_Caption = cgiGet( "DDO_BR_ENCOUNTERREASON_STATUS_Caption");
            Ddo_br_encounterreason_status_Tooltip = cgiGet( "DDO_BR_ENCOUNTERREASON_STATUS_Tooltip");
            Ddo_br_encounterreason_status_Cls = cgiGet( "DDO_BR_ENCOUNTERREASON_STATUS_Cls");
            Ddo_br_encounterreason_status_Dropdownoptionstype = cgiGet( "DDO_BR_ENCOUNTERREASON_STATUS_Dropdownoptionstype");
            Ddo_br_encounterreason_status_Titlecontrolidtoreplace = cgiGet( "DDO_BR_ENCOUNTERREASON_STATUS_Titlecontrolidtoreplace");
            Ddo_br_encounterreason_status_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTERREASON_STATUS_Includesortasc"));
            Ddo_br_encounterreason_status_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTERREASON_STATUS_Includesortdsc"));
            Ddo_br_encounterreason_status_Sortedstatus = cgiGet( "DDO_BR_ENCOUNTERREASON_STATUS_Sortedstatus");
            Ddo_br_encounterreason_status_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTERREASON_STATUS_Includefilter"));
            Ddo_br_encounterreason_status_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTERREASON_STATUS_Includedatalist"));
            Ddo_br_encounterreason_status_Sortasc = cgiGet( "DDO_BR_ENCOUNTERREASON_STATUS_Sortasc");
            Ddo_br_encounterreason_status_Sortdsc = cgiGet( "DDO_BR_ENCOUNTERREASON_STATUS_Sortdsc");
            Ddo_br_encounterreason_status_Searchbuttontext = cgiGet( "DDO_BR_ENCOUNTERREASON_STATUS_Searchbuttontext");
            Ddo_br_encounterreason_israndapprover_Caption = cgiGet( "DDO_BR_ENCOUNTERREASON_ISRANDAPPROVER_Caption");
            Ddo_br_encounterreason_israndapprover_Tooltip = cgiGet( "DDO_BR_ENCOUNTERREASON_ISRANDAPPROVER_Tooltip");
            Ddo_br_encounterreason_israndapprover_Cls = cgiGet( "DDO_BR_ENCOUNTERREASON_ISRANDAPPROVER_Cls");
            Ddo_br_encounterreason_israndapprover_Dropdownoptionstype = cgiGet( "DDO_BR_ENCOUNTERREASON_ISRANDAPPROVER_Dropdownoptionstype");
            Ddo_br_encounterreason_israndapprover_Titlecontrolidtoreplace = cgiGet( "DDO_BR_ENCOUNTERREASON_ISRANDAPPROVER_Titlecontrolidtoreplace");
            Ddo_br_encounterreason_israndapprover_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTERREASON_ISRANDAPPROVER_Includesortasc"));
            Ddo_br_encounterreason_israndapprover_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTERREASON_ISRANDAPPROVER_Includesortdsc"));
            Ddo_br_encounterreason_israndapprover_Sortedstatus = cgiGet( "DDO_BR_ENCOUNTERREASON_ISRANDAPPROVER_Sortedstatus");
            Ddo_br_encounterreason_israndapprover_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTERREASON_ISRANDAPPROVER_Includefilter"));
            Ddo_br_encounterreason_israndapprover_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTERREASON_ISRANDAPPROVER_Includedatalist"));
            Ddo_br_encounterreason_israndapprover_Sortasc = cgiGet( "DDO_BR_ENCOUNTERREASON_ISRANDAPPROVER_Sortasc");
            Ddo_br_encounterreason_israndapprover_Sortdsc = cgiGet( "DDO_BR_ENCOUNTERREASON_ISRANDAPPROVER_Sortdsc");
            Ddo_br_encounterreason_israndapprover_Searchbuttontext = cgiGet( "DDO_BR_ENCOUNTERREASON_ISRANDAPPROVER_Searchbuttontext");
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( "GRID_Rows"), ".", ","));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            Gridpaginationbar_Selectedpage = cgiGet( "GRIDPAGINATIONBAR_Selectedpage");
            Gridpaginationbar_Rowsperpageselectedvalue = (int)(context.localUtil.CToN( cgiGet( "GRIDPAGINATIONBAR_Rowsperpageselectedvalue"), ".", ","));
            Ddo_br_encounter_id_Activeeventkey = cgiGet( "DDO_BR_ENCOUNTER_ID_Activeeventkey");
            Ddo_br_encounterid_Activeeventkey = cgiGet( "DDO_BR_ENCOUNTERID_Activeeventkey");
            Ddo_br_encounterreason_reason_Activeeventkey = cgiGet( "DDO_BR_ENCOUNTERREASON_REASON_Activeeventkey");
            Ddo_br_encounterreason_israndnoapprovedate_Activeeventkey = cgiGet( "DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE_Activeeventkey");
            Ddo_br_encounterreason_israndapprove_Activeeventkey = cgiGet( "DDO_BR_ENCOUNTERREASON_ISRANDAPPROVE_Activeeventkey");
            Ddo_br_encounterreason_status_Activeeventkey = cgiGet( "DDO_BR_ENCOUNTERREASON_STATUS_Activeeventkey");
            Ddo_br_encounterreason_israndapprover_Activeeventkey = cgiGet( "DDO_BR_ENCOUNTERREASON_ISRANDAPPROVER_Activeeventkey");
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
         E20792 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E20792( )
      {
         /* Start Routine */
         GXt_boolean1 = AV5IsAuthorized;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "WWBR_EncounterReason", out  GXt_boolean1) ;
         AV5IsAuthorized = GXt_boolean1;
         if ( ! AV5IsAuthorized )
         {
            CallWebObject(formatLink("wwpbaseobjects.notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV35Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         divTablemain_Height = 493;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, divTablemain_Internalname, "Height", StringUtil.LTrim( StringUtil.Str( (decimal)(divTablemain_Height), 9, 0)), true);
         subGrid_Rows = 9;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         Ddo_br_encounter_id_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Encounter_ID";
         ucDdo_br_encounter_id.SendProperty(context, "", false, Ddo_br_encounter_id_Internalname, "TitleControlIdToReplace", Ddo_br_encounter_id_Titlecontrolidtoreplace);
         AV14ddo_BR_Encounter_IDTitleControlIdToReplace = Ddo_br_encounter_id_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14ddo_BR_Encounter_IDTitleControlIdToReplace", AV14ddo_BR_Encounter_IDTitleControlIdToReplace);
         edtavDdo_br_encounter_idtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_encounter_idtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_encounter_idtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_encounterid_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_EncounterID";
         ucDdo_br_encounterid.SendProperty(context, "", false, Ddo_br_encounterid_Internalname, "TitleControlIdToReplace", Ddo_br_encounterid_Titlecontrolidtoreplace);
         AV16ddo_BR_EncounterIDTitleControlIdToReplace = Ddo_br_encounterid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16ddo_BR_EncounterIDTitleControlIdToReplace", AV16ddo_BR_EncounterIDTitleControlIdToReplace);
         edtavDdo_br_encounteridtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_encounteridtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_encounteridtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_encounterreason_reason_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_EncounterReason_Reason";
         ucDdo_br_encounterreason_reason.SendProperty(context, "", false, Ddo_br_encounterreason_reason_Internalname, "TitleControlIdToReplace", Ddo_br_encounterreason_reason_Titlecontrolidtoreplace);
         AV18ddo_BR_EncounterReason_ReasonTitleControlIdToReplace = Ddo_br_encounterreason_reason_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18ddo_BR_EncounterReason_ReasonTitleControlIdToReplace", AV18ddo_BR_EncounterReason_ReasonTitleControlIdToReplace);
         edtavDdo_br_encounterreason_reasontitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_encounterreason_reasontitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_encounterreason_reasontitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_encounterreason_israndnoapprovedate_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_EncounterReason_IsRandNoApproveDate";
         ucDdo_br_encounterreason_israndnoapprovedate.SendProperty(context, "", false, Ddo_br_encounterreason_israndnoapprovedate_Internalname, "TitleControlIdToReplace", Ddo_br_encounterreason_israndnoapprovedate_Titlecontrolidtoreplace);
         AV20ddo_BR_EncounterReason_IsRandNoApproveDateTitleControlIdToReplace = Ddo_br_encounterreason_israndnoapprovedate_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20ddo_BR_EncounterReason_IsRandNoApproveDateTitleControlIdToReplace", AV20ddo_BR_EncounterReason_IsRandNoApproveDateTitleControlIdToReplace);
         edtavDdo_br_encounterreason_israndnoapprovedatetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_encounterreason_israndnoapprovedatetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_encounterreason_israndnoapprovedatetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_encounterreason_israndapprove_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_EncounterReason_IsRandApprove";
         ucDdo_br_encounterreason_israndapprove.SendProperty(context, "", false, Ddo_br_encounterreason_israndapprove_Internalname, "TitleControlIdToReplace", Ddo_br_encounterreason_israndapprove_Titlecontrolidtoreplace);
         AV22ddo_BR_EncounterReason_IsRandApproveTitleControlIdToReplace = Ddo_br_encounterreason_israndapprove_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22ddo_BR_EncounterReason_IsRandApproveTitleControlIdToReplace", AV22ddo_BR_EncounterReason_IsRandApproveTitleControlIdToReplace);
         edtavDdo_br_encounterreason_israndapprovetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_encounterreason_israndapprovetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_encounterreason_israndapprovetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_encounterreason_status_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_EncounterReason_Status";
         ucDdo_br_encounterreason_status.SendProperty(context, "", false, Ddo_br_encounterreason_status_Internalname, "TitleControlIdToReplace", Ddo_br_encounterreason_status_Titlecontrolidtoreplace);
         AV24ddo_BR_EncounterReason_StatusTitleControlIdToReplace = Ddo_br_encounterreason_status_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24ddo_BR_EncounterReason_StatusTitleControlIdToReplace", AV24ddo_BR_EncounterReason_StatusTitleControlIdToReplace);
         edtavDdo_br_encounterreason_statustitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_encounterreason_statustitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_encounterreason_statustitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_encounterreason_israndapprover_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_EncounterReason_IsRandApprover";
         ucDdo_br_encounterreason_israndapprover.SendProperty(context, "", false, Ddo_br_encounterreason_israndapprover_Internalname, "TitleControlIdToReplace", Ddo_br_encounterreason_israndapprover_Titlecontrolidtoreplace);
         AV26ddo_BR_EncounterReason_IsRandApproverTitleControlIdToReplace = Ddo_br_encounterreason_israndapprover_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26ddo_BR_EncounterReason_IsRandApproverTitleControlIdToReplace", AV26ddo_BR_EncounterReason_IsRandApproverTitleControlIdToReplace);
         edtavDdo_br_encounterreason_israndapprovertitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_encounterreason_israndapprovertitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_encounterreason_israndapprovertitlecontrolidtoreplace_Visible), 5, 0)), true);
         Form.Caption = "选择初审不通过原因";
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
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 = AV27DDO_TitleSettingsIcons;
         new GeneXus.Programs.wwpbaseobjects.getwwptitlesettingsicons(context ).execute( out  GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2) ;
         AV27DDO_TitleSettingsIcons = GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2;
         Gridpaginationbar_Rowsperpageselectedvalue = subGrid_Rows;
         ucGridpaginationbar.SendProperty(context, "", false, Gridpaginationbar_Internalname, "RowsPerPageSelectedValue", StringUtil.LTrim( StringUtil.Str( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0)));
      }

      protected void E21792( )
      {
         if ( gx_refresh_fired )
         {
            return  ;
         }
         gx_refresh_fired = true;
         /* Refresh Routine */
         AV13BR_Encounter_IDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV15BR_EncounterIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV17BR_EncounterReason_ReasonTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV19BR_EncounterReason_IsRandNoApproveDateTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV21BR_EncounterReason_IsRandApproveTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV23BR_EncounterReason_StatusTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV25BR_EncounterReason_IsRandApproverTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV6WWPContext) ;
         edtBR_Encounter_ID_Titleformat = 2;
         edtBR_Encounter_ID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "主键", AV14ddo_BR_Encounter_IDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Encounter_ID_Internalname, "Title", edtBR_Encounter_ID_Title, !bGXsfl_12_Refreshing);
         edtBR_EncounterID_Titleformat = 2;
         edtBR_EncounterID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "就诊信息主键", AV16ddo_BR_EncounterIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_EncounterID_Internalname, "Title", edtBR_EncounterID_Title, !bGXsfl_12_Refreshing);
         edtBR_EncounterReason_Reason_Titleformat = 2;
         edtBR_EncounterReason_Reason_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "初审不通过原因", AV18ddo_BR_EncounterReason_ReasonTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_EncounterReason_Reason_Internalname, "Title", edtBR_EncounterReason_Reason_Title, !bGXsfl_12_Refreshing);
         edtBR_EncounterReason_IsRandNoApproveDate_Titleformat = 2;
         edtBR_EncounterReason_IsRandNoApproveDate_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "初审不通过时间", AV20ddo_BR_EncounterReason_IsRandNoApproveDateTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_EncounterReason_IsRandNoApproveDate_Internalname, "Title", edtBR_EncounterReason_IsRandNoApproveDate_Title, !bGXsfl_12_Refreshing);
         chkBR_EncounterReason_IsRandApprove_Titleformat = 2;
         chkBR_EncounterReason_IsRandApprove.Title.Text = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "是否初审抽查", AV22ddo_BR_EncounterReason_IsRandApproveTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkBR_EncounterReason_IsRandApprove_Internalname, "Title", chkBR_EncounterReason_IsRandApprove.Title.Text, !bGXsfl_12_Refreshing);
         cmbBR_EncounterReason_Status_Titleformat = 2;
         cmbBR_EncounterReason_Status.Title.Text = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "审批状态", AV24ddo_BR_EncounterReason_StatusTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_EncounterReason_Status_Internalname, "Title", cmbBR_EncounterReason_Status.Title.Text, !bGXsfl_12_Refreshing);
         edtBR_EncounterReason_IsRandApprover_Titleformat = 2;
         edtBR_EncounterReason_IsRandApprover_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "初审抽查通过操作人", AV26ddo_BR_EncounterReason_IsRandApproverTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_EncounterReason_IsRandApprover_Internalname, "Title", edtBR_EncounterReason_IsRandApprover_Title, !bGXsfl_12_Refreshing);
         AV29GridCurrentPage = subGrid_Currentpage( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29GridCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV29GridCurrentPage), 10, 0)));
         AV30GridPageSize = subGrid_Rows;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30GridPageSize", StringUtil.LTrim( StringUtil.Str( (decimal)(AV30GridPageSize), 10, 0)));
         AV31GridRecordCount = subGrid_Recordcount( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31GridRecordCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV31GridRecordCount), 10, 0)));
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_Encounter_IDTitleFilterData", AV13BR_Encounter_IDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_EncounterIDTitleFilterData", AV15BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_EncounterReason_ReasonTitleFilterData", AV17BR_EncounterReason_ReasonTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_EncounterReason_IsRandNoApproveDateTitleFilterData", AV19BR_EncounterReason_IsRandNoApproveDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21BR_EncounterReason_IsRandApproveTitleFilterData", AV21BR_EncounterReason_IsRandApproveTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23BR_EncounterReason_StatusTitleFilterData", AV23BR_EncounterReason_StatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV25BR_EncounterReason_IsRandApproverTitleFilterData", AV25BR_EncounterReason_IsRandApproverTitleFilterData);
      }

      protected void E11792( )
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
            AV28PageToGo = (int)(NumberUtil.Val( Gridpaginationbar_Selectedpage, "."));
            subgrid_gotopage( AV28PageToGo) ;
         }
      }

      protected void E12792( )
      {
         /* Gridpaginationbar_Changerowsperpage Routine */
         subGrid_Rows = Gridpaginationbar_Rowsperpageselectedvalue;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         subgrid_firstpage( ) ;
         /*  Sending Event outputs  */
      }

      protected void E13792( )
      {
         /* Ddo_br_encounter_id_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_encounter_id_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_encounter_id_Sortedstatus = "ASC";
            ucDdo_br_encounter_id.SendProperty(context, "", false, Ddo_br_encounter_id_Internalname, "SortedStatus", Ddo_br_encounter_id_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_encounter_id_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_encounter_id_Sortedstatus = "DSC";
            ucDdo_br_encounter_id.SendProperty(context, "", false, Ddo_br_encounter_id_Internalname, "SortedStatus", Ddo_br_encounter_id_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_Encounter_IDTitleFilterData", AV13BR_Encounter_IDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_EncounterIDTitleFilterData", AV15BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_EncounterReason_ReasonTitleFilterData", AV17BR_EncounterReason_ReasonTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_EncounterReason_IsRandNoApproveDateTitleFilterData", AV19BR_EncounterReason_IsRandNoApproveDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21BR_EncounterReason_IsRandApproveTitleFilterData", AV21BR_EncounterReason_IsRandApproveTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23BR_EncounterReason_StatusTitleFilterData", AV23BR_EncounterReason_StatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV25BR_EncounterReason_IsRandApproverTitleFilterData", AV25BR_EncounterReason_IsRandApproverTitleFilterData);
      }

      protected void E14792( )
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
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_Encounter_IDTitleFilterData", AV13BR_Encounter_IDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_EncounterIDTitleFilterData", AV15BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_EncounterReason_ReasonTitleFilterData", AV17BR_EncounterReason_ReasonTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_EncounterReason_IsRandNoApproveDateTitleFilterData", AV19BR_EncounterReason_IsRandNoApproveDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21BR_EncounterReason_IsRandApproveTitleFilterData", AV21BR_EncounterReason_IsRandApproveTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23BR_EncounterReason_StatusTitleFilterData", AV23BR_EncounterReason_StatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV25BR_EncounterReason_IsRandApproverTitleFilterData", AV25BR_EncounterReason_IsRandApproverTitleFilterData);
      }

      protected void E15792( )
      {
         /* Ddo_br_encounterreason_reason_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_encounterreason_reason_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 3;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_encounterreason_reason_Sortedstatus = "ASC";
            ucDdo_br_encounterreason_reason.SendProperty(context, "", false, Ddo_br_encounterreason_reason_Internalname, "SortedStatus", Ddo_br_encounterreason_reason_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_encounterreason_reason_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 3;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_encounterreason_reason_Sortedstatus = "DSC";
            ucDdo_br_encounterreason_reason.SendProperty(context, "", false, Ddo_br_encounterreason_reason_Internalname, "SortedStatus", Ddo_br_encounterreason_reason_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_Encounter_IDTitleFilterData", AV13BR_Encounter_IDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_EncounterIDTitleFilterData", AV15BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_EncounterReason_ReasonTitleFilterData", AV17BR_EncounterReason_ReasonTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_EncounterReason_IsRandNoApproveDateTitleFilterData", AV19BR_EncounterReason_IsRandNoApproveDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21BR_EncounterReason_IsRandApproveTitleFilterData", AV21BR_EncounterReason_IsRandApproveTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23BR_EncounterReason_StatusTitleFilterData", AV23BR_EncounterReason_StatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV25BR_EncounterReason_IsRandApproverTitleFilterData", AV25BR_EncounterReason_IsRandApproverTitleFilterData);
      }

      protected void E16792( )
      {
         /* Ddo_br_encounterreason_israndnoapprovedate_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_encounterreason_israndnoapprovedate_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 4;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_encounterreason_israndnoapprovedate_Sortedstatus = "ASC";
            ucDdo_br_encounterreason_israndnoapprovedate.SendProperty(context, "", false, Ddo_br_encounterreason_israndnoapprovedate_Internalname, "SortedStatus", Ddo_br_encounterreason_israndnoapprovedate_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_encounterreason_israndnoapprovedate_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 4;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_encounterreason_israndnoapprovedate_Sortedstatus = "DSC";
            ucDdo_br_encounterreason_israndnoapprovedate.SendProperty(context, "", false, Ddo_br_encounterreason_israndnoapprovedate_Internalname, "SortedStatus", Ddo_br_encounterreason_israndnoapprovedate_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_Encounter_IDTitleFilterData", AV13BR_Encounter_IDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_EncounterIDTitleFilterData", AV15BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_EncounterReason_ReasonTitleFilterData", AV17BR_EncounterReason_ReasonTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_EncounterReason_IsRandNoApproveDateTitleFilterData", AV19BR_EncounterReason_IsRandNoApproveDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21BR_EncounterReason_IsRandApproveTitleFilterData", AV21BR_EncounterReason_IsRandApproveTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23BR_EncounterReason_StatusTitleFilterData", AV23BR_EncounterReason_StatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV25BR_EncounterReason_IsRandApproverTitleFilterData", AV25BR_EncounterReason_IsRandApproverTitleFilterData);
      }

      protected void E17792( )
      {
         /* Ddo_br_encounterreason_israndapprove_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_encounterreason_israndapprove_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 5;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_encounterreason_israndapprove_Sortedstatus = "ASC";
            ucDdo_br_encounterreason_israndapprove.SendProperty(context, "", false, Ddo_br_encounterreason_israndapprove_Internalname, "SortedStatus", Ddo_br_encounterreason_israndapprove_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_encounterreason_israndapprove_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 5;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_encounterreason_israndapprove_Sortedstatus = "DSC";
            ucDdo_br_encounterreason_israndapprove.SendProperty(context, "", false, Ddo_br_encounterreason_israndapprove_Internalname, "SortedStatus", Ddo_br_encounterreason_israndapprove_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_Encounter_IDTitleFilterData", AV13BR_Encounter_IDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_EncounterIDTitleFilterData", AV15BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_EncounterReason_ReasonTitleFilterData", AV17BR_EncounterReason_ReasonTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_EncounterReason_IsRandNoApproveDateTitleFilterData", AV19BR_EncounterReason_IsRandNoApproveDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21BR_EncounterReason_IsRandApproveTitleFilterData", AV21BR_EncounterReason_IsRandApproveTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23BR_EncounterReason_StatusTitleFilterData", AV23BR_EncounterReason_StatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV25BR_EncounterReason_IsRandApproverTitleFilterData", AV25BR_EncounterReason_IsRandApproverTitleFilterData);
      }

      protected void E18792( )
      {
         /* Ddo_br_encounterreason_status_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_encounterreason_status_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 6;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_encounterreason_status_Sortedstatus = "ASC";
            ucDdo_br_encounterreason_status.SendProperty(context, "", false, Ddo_br_encounterreason_status_Internalname, "SortedStatus", Ddo_br_encounterreason_status_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_encounterreason_status_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 6;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_encounterreason_status_Sortedstatus = "DSC";
            ucDdo_br_encounterreason_status.SendProperty(context, "", false, Ddo_br_encounterreason_status_Internalname, "SortedStatus", Ddo_br_encounterreason_status_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_Encounter_IDTitleFilterData", AV13BR_Encounter_IDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_EncounterIDTitleFilterData", AV15BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_EncounterReason_ReasonTitleFilterData", AV17BR_EncounterReason_ReasonTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_EncounterReason_IsRandNoApproveDateTitleFilterData", AV19BR_EncounterReason_IsRandNoApproveDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21BR_EncounterReason_IsRandApproveTitleFilterData", AV21BR_EncounterReason_IsRandApproveTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23BR_EncounterReason_StatusTitleFilterData", AV23BR_EncounterReason_StatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV25BR_EncounterReason_IsRandApproverTitleFilterData", AV25BR_EncounterReason_IsRandApproverTitleFilterData);
      }

      protected void E19792( )
      {
         /* Ddo_br_encounterreason_israndapprover_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_encounterreason_israndapprover_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 7;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_encounterreason_israndapprover_Sortedstatus = "ASC";
            ucDdo_br_encounterreason_israndapprover.SendProperty(context, "", false, Ddo_br_encounterreason_israndapprover_Internalname, "SortedStatus", Ddo_br_encounterreason_israndapprover_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_encounterreason_israndapprover_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 7;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_encounterreason_israndapprover_Sortedstatus = "DSC";
            ucDdo_br_encounterreason_israndapprover.SendProperty(context, "", false, Ddo_br_encounterreason_israndapprover_Internalname, "SortedStatus", Ddo_br_encounterreason_israndapprover_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_Encounter_IDTitleFilterData", AV13BR_Encounter_IDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_EncounterIDTitleFilterData", AV15BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_EncounterReason_ReasonTitleFilterData", AV17BR_EncounterReason_ReasonTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_EncounterReason_IsRandNoApproveDateTitleFilterData", AV19BR_EncounterReason_IsRandNoApproveDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21BR_EncounterReason_IsRandApproveTitleFilterData", AV21BR_EncounterReason_IsRandApproveTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23BR_EncounterReason_StatusTitleFilterData", AV23BR_EncounterReason_StatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV25BR_EncounterReason_IsRandApproverTitleFilterData", AV25BR_EncounterReason_IsRandApproverTitleFilterData);
      }

      private void E22792( )
      {
         /* Grid_Load Routine */
         AV32Select = context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavSelect_Internalname, AV32Select);
         AV36Select_GXI = GXDbFile.PathToUrl( context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( )));
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
         E23792 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E23792( )
      {
         /* Enter Routine */
         AV8InOutBR_Encounter_ID = A347BR_Encounter_ID;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8InOutBR_Encounter_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8InOutBR_Encounter_ID), 15, 0)));
         AV9InOutBR_EncounterReason_Reason = A340BR_EncounterReason_Reason;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9InOutBR_EncounterReason_Reason", AV9InOutBR_EncounterReason_Reason);
         context.setWebReturnParms(new Object[] {(long)AV8InOutBR_Encounter_ID,(String)AV9InOutBR_EncounterReason_Reason});
         context.setWebReturnParmsMetadata(new Object[] {"AV8InOutBR_Encounter_ID","AV9InOutBR_EncounterReason_Reason"});
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
         AV8InOutBR_Encounter_ID = Convert.ToInt64(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8InOutBR_Encounter_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8InOutBR_Encounter_ID), 15, 0)));
         AV9InOutBR_EncounterReason_Reason = (String)getParm(obj,1);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9InOutBR_EncounterReason_Reason", AV9InOutBR_EncounterReason_Reason);
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
         PA792( ) ;
         WS792( ) ;
         WE792( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202022815161134", true);
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
         context.AddJavascriptSource("br_encounterreasonprompt.js", "?202022815161134", false);
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
         context.AddJavascriptSource("DVelop/WorkWithPlusUtilities/WorkWithPlusUtilitiesRender.js", "", false);
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_122( )
      {
         edtavSelect_Internalname = "vSELECT_"+sGXsfl_12_idx;
         edtBR_Encounter_ID_Internalname = "BR_ENCOUNTER_ID_"+sGXsfl_12_idx;
         edtBR_EncounterID_Internalname = "BR_ENCOUNTERID_"+sGXsfl_12_idx;
         edtBR_EncounterReason_Reason_Internalname = "BR_ENCOUNTERREASON_REASON_"+sGXsfl_12_idx;
         edtBR_EncounterReason_IsRandNoApproveDate_Internalname = "BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE_"+sGXsfl_12_idx;
         chkBR_EncounterReason_IsRandApprove_Internalname = "BR_ENCOUNTERREASON_ISRANDAPPROVE_"+sGXsfl_12_idx;
         cmbBR_EncounterReason_Status_Internalname = "BR_ENCOUNTERREASON_STATUS_"+sGXsfl_12_idx;
         edtBR_EncounterReason_IsRandApprover_Internalname = "BR_ENCOUNTERREASON_ISRANDAPPROVER_"+sGXsfl_12_idx;
      }

      protected void SubsflControlProps_fel_122( )
      {
         edtavSelect_Internalname = "vSELECT_"+sGXsfl_12_fel_idx;
         edtBR_Encounter_ID_Internalname = "BR_ENCOUNTER_ID_"+sGXsfl_12_fel_idx;
         edtBR_EncounterID_Internalname = "BR_ENCOUNTERID_"+sGXsfl_12_fel_idx;
         edtBR_EncounterReason_Reason_Internalname = "BR_ENCOUNTERREASON_REASON_"+sGXsfl_12_fel_idx;
         edtBR_EncounterReason_IsRandNoApproveDate_Internalname = "BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE_"+sGXsfl_12_fel_idx;
         chkBR_EncounterReason_IsRandApprove_Internalname = "BR_ENCOUNTERREASON_ISRANDAPPROVE_"+sGXsfl_12_fel_idx;
         cmbBR_EncounterReason_Status_Internalname = "BR_ENCOUNTERREASON_STATUS_"+sGXsfl_12_fel_idx;
         edtBR_EncounterReason_IsRandApprover_Internalname = "BR_ENCOUNTERREASON_ISRANDAPPROVER_"+sGXsfl_12_fel_idx;
      }

      protected void sendrow_122( )
      {
         SubsflControlProps_122( ) ;
         WB790( ) ;
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
            AV32Select_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV32Select))&&String.IsNullOrEmpty(StringUtil.RTrim( AV36Select_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV32Select)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV32Select)) ? AV36Select_GXI : context.PathToRelativeUrl( AV32Select));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavSelect_Internalname,(String)sImgUrl,(String)"",(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)edtavSelect_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)5,(String)edtavSelect_Jsonclick,"'"+""+"'"+",false,"+"'"+"EENTER."+sGXsfl_12_idx+"'",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)""+TempTags,(String)"",(String)"",(short)1,(bool)AV32Select_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Encounter_ID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A347BR_Encounter_ID), 15, 0, ".", "")),context.localUtil.Format( (decimal)(A347BR_Encounter_ID), "ZZZZZZZZZZZZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Encounter_ID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)15,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
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
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_EncounterReason_Reason_Internalname,(String)A340BR_EncounterReason_Reason,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_EncounterReason_Reason_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)300,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_EncounterReason_IsRandNoApproveDate_Internalname,context.localUtil.TToC( A341BR_EncounterReason_IsRandNoApproveDate, 10, 8, 0, 0, "/", ":", " "),context.localUtil.Format( A341BR_EncounterReason_IsRandNoApproveDate, "9999/99/99 99:99:99"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_EncounterReason_IsRandNoApproveDate_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)19,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"UpdDate",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Check box */
            ClassString = "AttributeCheckBox";
            StyleString = "";
            GridRow.AddColumnProperties("checkbox", 1, isAjaxCallMode( ), new Object[] {(String)chkBR_EncounterReason_IsRandApprove_Internalname,StringUtil.BoolToStr( A342BR_EncounterReason_IsRandApprove),(String)"",(String)"",(short)-1,(short)0,(String)"true",(String)"",(String)StyleString,(String)ClassString,(String)"WWColumn hidden-xs",(String)"",(String)""});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            if ( ( cmbBR_EncounterReason_Status.ItemCount == 0 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "BR_ENCOUNTERREASON_STATUS_" + sGXsfl_12_idx;
               cmbBR_EncounterReason_Status.Name = GXCCtl;
               cmbBR_EncounterReason_Status.WebTags = "";
               cmbBR_EncounterReason_Status.addItem("1", "未处理", 0);
               cmbBR_EncounterReason_Status.addItem("2", "已处理", 0);
               if ( cmbBR_EncounterReason_Status.ItemCount > 0 )
               {
                  A343BR_EncounterReason_Status = (short)(NumberUtil.Val( cmbBR_EncounterReason_Status.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A343BR_EncounterReason_Status), 4, 0))), "."));
                  n343BR_EncounterReason_Status = false;
               }
            }
            /* ComboBox */
            GridRow.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbBR_EncounterReason_Status,(String)cmbBR_EncounterReason_Status_Internalname,StringUtil.Trim( StringUtil.Str( (decimal)(A343BR_EncounterReason_Status), 4, 0)),(short)1,(String)cmbBR_EncounterReason_Status_Jsonclick,(short)0,(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"int",(String)"",(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)"",(String)"Attribute",(String)"WWColumn hidden-xs",(String)"",(String)"",(String)"",(bool)true});
            cmbBR_EncounterReason_Status.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A343BR_EncounterReason_Status), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_EncounterReason_Status_Internalname, "Values", (String)(cmbBR_EncounterReason_Status.ToJavascriptSource()), !bGXsfl_12_Refreshing);
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_EncounterReason_IsRandApprover_Internalname,(String)A344BR_EncounterReason_IsRandApprover,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_EncounterReason_IsRandApprover_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"UpdUser",(String)"left",(bool)true});
            send_integrity_lvl_hashes792( ) ;
            GridContainer.AddRow(GridRow);
            nGXsfl_12_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_12_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_12_idx+1));
            sGXsfl_12_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_12_idx), 4, 0)), 4, "0");
            SubsflControlProps_122( ) ;
         }
         /* End function sendrow_122 */
      }

      protected void init_web_controls( )
      {
         GXCCtl = "BR_ENCOUNTERREASON_ISRANDAPPROVE_" + sGXsfl_12_idx;
         chkBR_EncounterReason_IsRandApprove.Name = GXCCtl;
         chkBR_EncounterReason_IsRandApprove.WebTags = "";
         chkBR_EncounterReason_IsRandApprove.Caption = "";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkBR_EncounterReason_IsRandApprove_Internalname, "TitleCaption", chkBR_EncounterReason_IsRandApprove.Caption, !bGXsfl_12_Refreshing);
         chkBR_EncounterReason_IsRandApprove.CheckedValue = "false";
         GXCCtl = "BR_ENCOUNTERREASON_STATUS_" + sGXsfl_12_idx;
         cmbBR_EncounterReason_Status.Name = GXCCtl;
         cmbBR_EncounterReason_Status.WebTags = "";
         cmbBR_EncounterReason_Status.addItem("1", "未处理", 0);
         cmbBR_EncounterReason_Status.addItem("2", "已处理", 0);
         if ( cmbBR_EncounterReason_Status.ItemCount > 0 )
         {
            A343BR_EncounterReason_Status = (short)(NumberUtil.Val( cmbBR_EncounterReason_Status.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A343BR_EncounterReason_Status), 4, 0))), "."));
            n343BR_EncounterReason_Status = false;
         }
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         edtavSelect_Internalname = "vSELECT";
         edtBR_Encounter_ID_Internalname = "BR_ENCOUNTER_ID";
         edtBR_EncounterID_Internalname = "BR_ENCOUNTERID";
         edtBR_EncounterReason_Reason_Internalname = "BR_ENCOUNTERREASON_REASON";
         edtBR_EncounterReason_IsRandNoApproveDate_Internalname = "BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE";
         chkBR_EncounterReason_IsRandApprove_Internalname = "BR_ENCOUNTERREASON_ISRANDAPPROVE";
         cmbBR_EncounterReason_Status_Internalname = "BR_ENCOUNTERREASON_STATUS";
         edtBR_EncounterReason_IsRandApprover_Internalname = "BR_ENCOUNTERREASON_ISRANDAPPROVER";
         Gridpaginationbar_Internalname = "GRIDPAGINATIONBAR";
         divHtml_gridpaginationbar_Internalname = "HTML_GRIDPAGINATIONBAR";
         divGridtablewithpaginationbar_Internalname = "GRIDTABLEWITHPAGINATIONBAR";
         divTablemain_Internalname = "TABLEMAIN";
         Ddo_br_encounter_id_Internalname = "DDO_BR_ENCOUNTER_ID";
         edtavDdo_br_encounter_idtitlecontrolidtoreplace_Internalname = "vDDO_BR_ENCOUNTER_IDTITLECONTROLIDTOREPLACE";
         Ddo_br_encounterid_Internalname = "DDO_BR_ENCOUNTERID";
         edtavDdo_br_encounteridtitlecontrolidtoreplace_Internalname = "vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE";
         Ddo_br_encounterreason_reason_Internalname = "DDO_BR_ENCOUNTERREASON_REASON";
         edtavDdo_br_encounterreason_reasontitlecontrolidtoreplace_Internalname = "vDDO_BR_ENCOUNTERREASON_REASONTITLECONTROLIDTOREPLACE";
         Ddo_br_encounterreason_israndnoapprovedate_Internalname = "DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE";
         edtavDdo_br_encounterreason_israndnoapprovedatetitlecontrolidtoreplace_Internalname = "vDDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATETITLECONTROLIDTOREPLACE";
         Ddo_br_encounterreason_israndapprove_Internalname = "DDO_BR_ENCOUNTERREASON_ISRANDAPPROVE";
         edtavDdo_br_encounterreason_israndapprovetitlecontrolidtoreplace_Internalname = "vDDO_BR_ENCOUNTERREASON_ISRANDAPPROVETITLECONTROLIDTOREPLACE";
         Ddo_br_encounterreason_status_Internalname = "DDO_BR_ENCOUNTERREASON_STATUS";
         edtavDdo_br_encounterreason_statustitlecontrolidtoreplace_Internalname = "vDDO_BR_ENCOUNTERREASON_STATUSTITLECONTROLIDTOREPLACE";
         Ddo_br_encounterreason_israndapprover_Internalname = "DDO_BR_ENCOUNTERREASON_ISRANDAPPROVER";
         edtavDdo_br_encounterreason_israndapprovertitlecontrolidtoreplace_Internalname = "vDDO_BR_ENCOUNTERREASON_ISRANDAPPROVERTITLECONTROLIDTOREPLACE";
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
         chkBR_EncounterReason_IsRandApprove.Caption = "";
         edtBR_EncounterReason_IsRandApprover_Jsonclick = "";
         cmbBR_EncounterReason_Status_Jsonclick = "";
         edtBR_EncounterReason_IsRandNoApproveDate_Jsonclick = "";
         edtBR_EncounterReason_Reason_Jsonclick = "";
         edtBR_EncounterID_Jsonclick = "";
         edtBR_Encounter_ID_Jsonclick = "";
         edtavSelect_Jsonclick = "";
         edtavSelect_Visible = -1;
         edtavSelect_Enabled = 1;
         edtavOrdereddsc_Jsonclick = "";
         edtavOrdereddsc_Visible = 1;
         edtavOrderedby_Jsonclick = "";
         edtavOrderedby_Visible = 1;
         edtavDdo_br_encounterreason_israndapprovertitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_encounterreason_statustitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_encounterreason_israndapprovetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_encounterreason_israndnoapprovedatetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_encounterreason_reasontitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_encounteridtitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_encounter_idtitlecontrolidtoreplace_Visible = 1;
         subGrid_Allowcollapsing = 0;
         subGrid_Allowselection = 0;
         edtavSelect_Tooltiptext = "选择";
         subGrid_Sortable = 0;
         subGrid_Header = "";
         edtBR_EncounterReason_IsRandApprover_Titleformat = 0;
         edtBR_EncounterReason_IsRandApprover_Title = "初审抽查通过操作人";
         cmbBR_EncounterReason_Status_Titleformat = 0;
         cmbBR_EncounterReason_Status.Title.Text = "审批状态";
         chkBR_EncounterReason_IsRandApprove_Titleformat = 0;
         chkBR_EncounterReason_IsRandApprove.Title.Text = "是否初审抽查";
         edtBR_EncounterReason_IsRandNoApproveDate_Titleformat = 0;
         edtBR_EncounterReason_IsRandNoApproveDate_Title = "初审不通过时间";
         edtBR_EncounterReason_Reason_Titleformat = 0;
         edtBR_EncounterReason_Reason_Title = "初审不通过原因";
         edtBR_EncounterID_Titleformat = 0;
         edtBR_EncounterID_Title = "就诊信息主键";
         edtBR_Encounter_ID_Titleformat = 0;
         edtBR_Encounter_ID_Title = "主键";
         subGrid_Class = "GridWithPaginationBar GridWithBorderColor WorkWith";
         subGrid_Backcolorstyle = 0;
         divTablemain_Height = 0;
         Ddo_br_encounterreason_israndapprover_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_encounterreason_israndapprover_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_encounterreason_israndapprover_Sortasc = "WWP_TSSortASC";
         Ddo_br_encounterreason_israndapprover_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_encounterreason_israndapprover_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_encounterreason_israndapprover_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_encounterreason_israndapprover_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_encounterreason_israndapprover_Titlecontrolidtoreplace = "";
         Ddo_br_encounterreason_israndapprover_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_encounterreason_israndapprover_Cls = "ColumnSettings";
         Ddo_br_encounterreason_israndapprover_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_encounterreason_israndapprover_Caption = "";
         Ddo_br_encounterreason_status_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_encounterreason_status_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_encounterreason_status_Sortasc = "WWP_TSSortASC";
         Ddo_br_encounterreason_status_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_encounterreason_status_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_encounterreason_status_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_encounterreason_status_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_encounterreason_status_Titlecontrolidtoreplace = "";
         Ddo_br_encounterreason_status_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_encounterreason_status_Cls = "ColumnSettings";
         Ddo_br_encounterreason_status_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_encounterreason_status_Caption = "";
         Ddo_br_encounterreason_israndapprove_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_encounterreason_israndapprove_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_encounterreason_israndapprove_Sortasc = "WWP_TSSortASC";
         Ddo_br_encounterreason_israndapprove_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_encounterreason_israndapprove_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_encounterreason_israndapprove_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_encounterreason_israndapprove_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_encounterreason_israndapprove_Titlecontrolidtoreplace = "";
         Ddo_br_encounterreason_israndapprove_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_encounterreason_israndapprove_Cls = "ColumnSettings";
         Ddo_br_encounterreason_israndapprove_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_encounterreason_israndapprove_Caption = "";
         Ddo_br_encounterreason_israndnoapprovedate_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_encounterreason_israndnoapprovedate_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_encounterreason_israndnoapprovedate_Sortasc = "WWP_TSSortASC";
         Ddo_br_encounterreason_israndnoapprovedate_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_encounterreason_israndnoapprovedate_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_encounterreason_israndnoapprovedate_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_encounterreason_israndnoapprovedate_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_encounterreason_israndnoapprovedate_Titlecontrolidtoreplace = "";
         Ddo_br_encounterreason_israndnoapprovedate_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_encounterreason_israndnoapprovedate_Cls = "ColumnSettings";
         Ddo_br_encounterreason_israndnoapprovedate_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_encounterreason_israndnoapprovedate_Caption = "";
         Ddo_br_encounterreason_reason_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_encounterreason_reason_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_encounterreason_reason_Sortasc = "WWP_TSSortASC";
         Ddo_br_encounterreason_reason_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_encounterreason_reason_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_encounterreason_reason_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_encounterreason_reason_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_encounterreason_reason_Titlecontrolidtoreplace = "";
         Ddo_br_encounterreason_reason_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_encounterreason_reason_Cls = "ColumnSettings";
         Ddo_br_encounterreason_reason_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_encounterreason_reason_Caption = "";
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
         Ddo_br_encounter_id_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_encounter_id_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_encounter_id_Sortasc = "WWP_TSSortASC";
         Ddo_br_encounter_id_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_encounter_id_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_encounter_id_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_encounter_id_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_encounter_id_Titlecontrolidtoreplace = "";
         Ddo_br_encounter_id_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_encounter_id_Cls = "ColumnSettings";
         Ddo_br_encounter_id_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_encounter_id_Caption = "";
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
         Form.Caption = "选择初审不通过原因";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_Encounter_IDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_IDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_EncounterReason_ReasonTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_REASONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_EncounterReason_IsRandNoApproveDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_EncounterReason_IsRandApproveTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_EncounterReason_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_EncounterReason_IsRandApproverTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_ISRANDAPPROVERTITLECONTROLIDTOREPLACE',pic:''},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]");
         setEventMetadata("REFRESH",",oparms:[{av:'AV13BR_Encounter_IDTitleFilterData',fld:'vBR_ENCOUNTER_IDTITLEFILTERDATA',pic:''},{av:'AV15BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV17BR_EncounterReason_ReasonTitleFilterData',fld:'vBR_ENCOUNTERREASON_REASONTITLEFILTERDATA',pic:''},{av:'AV19BR_EncounterReason_IsRandNoApproveDateTitleFilterData',fld:'vBR_ENCOUNTERREASON_ISRANDNOAPPROVEDATETITLEFILTERDATA',pic:''},{av:'AV21BR_EncounterReason_IsRandApproveTitleFilterData',fld:'vBR_ENCOUNTERREASON_ISRANDAPPROVETITLEFILTERDATA',pic:''},{av:'AV23BR_EncounterReason_StatusTitleFilterData',fld:'vBR_ENCOUNTERREASON_STATUSTITLEFILTERDATA',pic:''},{av:'AV25BR_EncounterReason_IsRandApproverTitleFilterData',fld:'vBR_ENCOUNTERREASON_ISRANDAPPROVERTITLEFILTERDATA',pic:''},{av:'edtBR_Encounter_ID_Titleformat',ctrl:'BR_ENCOUNTER_ID',prop:'Titleformat'},{av:'edtBR_Encounter_ID_Title',ctrl:'BR_ENCOUNTER_ID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_EncounterReason_Reason_Titleformat',ctrl:'BR_ENCOUNTERREASON_REASON',prop:'Titleformat'},{av:'edtBR_EncounterReason_Reason_Title',ctrl:'BR_ENCOUNTERREASON_REASON',prop:'Title'},{av:'edtBR_EncounterReason_IsRandNoApproveDate_Titleformat',ctrl:'BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE',prop:'Titleformat'},{av:'edtBR_EncounterReason_IsRandNoApproveDate_Title',ctrl:'BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE',prop:'Title'},{av:'chkBR_EncounterReason_IsRandApprove_Titleformat',ctrl:'BR_ENCOUNTERREASON_ISRANDAPPROVE',prop:'Titleformat'},{av:'chkBR_EncounterReason_IsRandApprove.Title.Text',ctrl:'BR_ENCOUNTERREASON_ISRANDAPPROVE',prop:'Title'},{av:'cmbBR_EncounterReason_Status'},{av:'edtBR_EncounterReason_IsRandApprover_Titleformat',ctrl:'BR_ENCOUNTERREASON_ISRANDAPPROVER',prop:'Titleformat'},{av:'edtBR_EncounterReason_IsRandApprover_Title',ctrl:'BR_ENCOUNTERREASON_ISRANDAPPROVER',prop:'Title'},{av:'AV29GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV30GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV31GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE","{handler:'E11792',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_Encounter_IDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_IDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_EncounterReason_ReasonTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_REASONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_EncounterReason_IsRandNoApproveDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_EncounterReason_IsRandApproveTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_EncounterReason_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_EncounterReason_IsRandApproverTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_ISRANDAPPROVERTITLECONTROLIDTOREPLACE',pic:''},{av:'Gridpaginationbar_Selectedpage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE",",oparms:[]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE","{handler:'E12792',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_Encounter_IDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_IDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_EncounterReason_ReasonTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_REASONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_EncounterReason_IsRandNoApproveDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_EncounterReason_IsRandApproveTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_EncounterReason_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_EncounterReason_IsRandApproverTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_ISRANDAPPROVERTITLECONTROLIDTOREPLACE',pic:''},{av:'Gridpaginationbar_Rowsperpageselectedvalue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE",",oparms:[{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]}");
         setEventMetadata("DDO_BR_ENCOUNTER_ID.ONOPTIONCLICKED","{handler:'E13792',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_Encounter_IDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_IDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_EncounterReason_ReasonTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_REASONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_EncounterReason_IsRandNoApproveDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_EncounterReason_IsRandApproveTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_EncounterReason_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_EncounterReason_IsRandApproverTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_ISRANDAPPROVERTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_encounter_id_Activeeventkey',ctrl:'DDO_BR_ENCOUNTER_ID',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_ENCOUNTER_ID.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_encounter_id_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_ID',prop:'SortedStatus'},{av:'AV13BR_Encounter_IDTitleFilterData',fld:'vBR_ENCOUNTER_IDTITLEFILTERDATA',pic:''},{av:'AV15BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV17BR_EncounterReason_ReasonTitleFilterData',fld:'vBR_ENCOUNTERREASON_REASONTITLEFILTERDATA',pic:''},{av:'AV19BR_EncounterReason_IsRandNoApproveDateTitleFilterData',fld:'vBR_ENCOUNTERREASON_ISRANDNOAPPROVEDATETITLEFILTERDATA',pic:''},{av:'AV21BR_EncounterReason_IsRandApproveTitleFilterData',fld:'vBR_ENCOUNTERREASON_ISRANDAPPROVETITLEFILTERDATA',pic:''},{av:'AV23BR_EncounterReason_StatusTitleFilterData',fld:'vBR_ENCOUNTERREASON_STATUSTITLEFILTERDATA',pic:''},{av:'AV25BR_EncounterReason_IsRandApproverTitleFilterData',fld:'vBR_ENCOUNTERREASON_ISRANDAPPROVERTITLEFILTERDATA',pic:''},{av:'edtBR_Encounter_ID_Titleformat',ctrl:'BR_ENCOUNTER_ID',prop:'Titleformat'},{av:'edtBR_Encounter_ID_Title',ctrl:'BR_ENCOUNTER_ID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_EncounterReason_Reason_Titleformat',ctrl:'BR_ENCOUNTERREASON_REASON',prop:'Titleformat'},{av:'edtBR_EncounterReason_Reason_Title',ctrl:'BR_ENCOUNTERREASON_REASON',prop:'Title'},{av:'edtBR_EncounterReason_IsRandNoApproveDate_Titleformat',ctrl:'BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE',prop:'Titleformat'},{av:'edtBR_EncounterReason_IsRandNoApproveDate_Title',ctrl:'BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE',prop:'Title'},{av:'chkBR_EncounterReason_IsRandApprove_Titleformat',ctrl:'BR_ENCOUNTERREASON_ISRANDAPPROVE',prop:'Titleformat'},{av:'chkBR_EncounterReason_IsRandApprove.Title.Text',ctrl:'BR_ENCOUNTERREASON_ISRANDAPPROVE',prop:'Title'},{av:'cmbBR_EncounterReason_Status'},{av:'edtBR_EncounterReason_IsRandApprover_Titleformat',ctrl:'BR_ENCOUNTERREASON_ISRANDAPPROVER',prop:'Titleformat'},{av:'edtBR_EncounterReason_IsRandApprover_Title',ctrl:'BR_ENCOUNTERREASON_ISRANDAPPROVER',prop:'Title'},{av:'AV29GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV30GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV31GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_ENCOUNTERID.ONOPTIONCLICKED","{handler:'E14792',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_Encounter_IDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_IDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_EncounterReason_ReasonTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_REASONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_EncounterReason_IsRandNoApproveDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_EncounterReason_IsRandApproveTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_EncounterReason_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_EncounterReason_IsRandApproverTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_ISRANDAPPROVERTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_encounterid_Activeeventkey',ctrl:'DDO_BR_ENCOUNTERID',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_ENCOUNTERID.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_encounterid_Sortedstatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'AV13BR_Encounter_IDTitleFilterData',fld:'vBR_ENCOUNTER_IDTITLEFILTERDATA',pic:''},{av:'AV15BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV17BR_EncounterReason_ReasonTitleFilterData',fld:'vBR_ENCOUNTERREASON_REASONTITLEFILTERDATA',pic:''},{av:'AV19BR_EncounterReason_IsRandNoApproveDateTitleFilterData',fld:'vBR_ENCOUNTERREASON_ISRANDNOAPPROVEDATETITLEFILTERDATA',pic:''},{av:'AV21BR_EncounterReason_IsRandApproveTitleFilterData',fld:'vBR_ENCOUNTERREASON_ISRANDAPPROVETITLEFILTERDATA',pic:''},{av:'AV23BR_EncounterReason_StatusTitleFilterData',fld:'vBR_ENCOUNTERREASON_STATUSTITLEFILTERDATA',pic:''},{av:'AV25BR_EncounterReason_IsRandApproverTitleFilterData',fld:'vBR_ENCOUNTERREASON_ISRANDAPPROVERTITLEFILTERDATA',pic:''},{av:'edtBR_Encounter_ID_Titleformat',ctrl:'BR_ENCOUNTER_ID',prop:'Titleformat'},{av:'edtBR_Encounter_ID_Title',ctrl:'BR_ENCOUNTER_ID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_EncounterReason_Reason_Titleformat',ctrl:'BR_ENCOUNTERREASON_REASON',prop:'Titleformat'},{av:'edtBR_EncounterReason_Reason_Title',ctrl:'BR_ENCOUNTERREASON_REASON',prop:'Title'},{av:'edtBR_EncounterReason_IsRandNoApproveDate_Titleformat',ctrl:'BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE',prop:'Titleformat'},{av:'edtBR_EncounterReason_IsRandNoApproveDate_Title',ctrl:'BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE',prop:'Title'},{av:'chkBR_EncounterReason_IsRandApprove_Titleformat',ctrl:'BR_ENCOUNTERREASON_ISRANDAPPROVE',prop:'Titleformat'},{av:'chkBR_EncounterReason_IsRandApprove.Title.Text',ctrl:'BR_ENCOUNTERREASON_ISRANDAPPROVE',prop:'Title'},{av:'cmbBR_EncounterReason_Status'},{av:'edtBR_EncounterReason_IsRandApprover_Titleformat',ctrl:'BR_ENCOUNTERREASON_ISRANDAPPROVER',prop:'Titleformat'},{av:'edtBR_EncounterReason_IsRandApprover_Title',ctrl:'BR_ENCOUNTERREASON_ISRANDAPPROVER',prop:'Title'},{av:'AV29GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV30GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV31GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_ENCOUNTERREASON_REASON.ONOPTIONCLICKED","{handler:'E15792',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_Encounter_IDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_IDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_EncounterReason_ReasonTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_REASONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_EncounterReason_IsRandNoApproveDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_EncounterReason_IsRandApproveTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_EncounterReason_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_EncounterReason_IsRandApproverTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_ISRANDAPPROVERTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_encounterreason_reason_Activeeventkey',ctrl:'DDO_BR_ENCOUNTERREASON_REASON',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_ENCOUNTERREASON_REASON.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_encounterreason_reason_Sortedstatus',ctrl:'DDO_BR_ENCOUNTERREASON_REASON',prop:'SortedStatus'},{av:'AV13BR_Encounter_IDTitleFilterData',fld:'vBR_ENCOUNTER_IDTITLEFILTERDATA',pic:''},{av:'AV15BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV17BR_EncounterReason_ReasonTitleFilterData',fld:'vBR_ENCOUNTERREASON_REASONTITLEFILTERDATA',pic:''},{av:'AV19BR_EncounterReason_IsRandNoApproveDateTitleFilterData',fld:'vBR_ENCOUNTERREASON_ISRANDNOAPPROVEDATETITLEFILTERDATA',pic:''},{av:'AV21BR_EncounterReason_IsRandApproveTitleFilterData',fld:'vBR_ENCOUNTERREASON_ISRANDAPPROVETITLEFILTERDATA',pic:''},{av:'AV23BR_EncounterReason_StatusTitleFilterData',fld:'vBR_ENCOUNTERREASON_STATUSTITLEFILTERDATA',pic:''},{av:'AV25BR_EncounterReason_IsRandApproverTitleFilterData',fld:'vBR_ENCOUNTERREASON_ISRANDAPPROVERTITLEFILTERDATA',pic:''},{av:'edtBR_Encounter_ID_Titleformat',ctrl:'BR_ENCOUNTER_ID',prop:'Titleformat'},{av:'edtBR_Encounter_ID_Title',ctrl:'BR_ENCOUNTER_ID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_EncounterReason_Reason_Titleformat',ctrl:'BR_ENCOUNTERREASON_REASON',prop:'Titleformat'},{av:'edtBR_EncounterReason_Reason_Title',ctrl:'BR_ENCOUNTERREASON_REASON',prop:'Title'},{av:'edtBR_EncounterReason_IsRandNoApproveDate_Titleformat',ctrl:'BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE',prop:'Titleformat'},{av:'edtBR_EncounterReason_IsRandNoApproveDate_Title',ctrl:'BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE',prop:'Title'},{av:'chkBR_EncounterReason_IsRandApprove_Titleformat',ctrl:'BR_ENCOUNTERREASON_ISRANDAPPROVE',prop:'Titleformat'},{av:'chkBR_EncounterReason_IsRandApprove.Title.Text',ctrl:'BR_ENCOUNTERREASON_ISRANDAPPROVE',prop:'Title'},{av:'cmbBR_EncounterReason_Status'},{av:'edtBR_EncounterReason_IsRandApprover_Titleformat',ctrl:'BR_ENCOUNTERREASON_ISRANDAPPROVER',prop:'Titleformat'},{av:'edtBR_EncounterReason_IsRandApprover_Title',ctrl:'BR_ENCOUNTERREASON_ISRANDAPPROVER',prop:'Title'},{av:'AV29GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV30GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV31GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE.ONOPTIONCLICKED","{handler:'E16792',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_Encounter_IDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_IDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_EncounterReason_ReasonTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_REASONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_EncounterReason_IsRandNoApproveDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_EncounterReason_IsRandApproveTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_EncounterReason_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_EncounterReason_IsRandApproverTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_ISRANDAPPROVERTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_encounterreason_israndnoapprovedate_Activeeventkey',ctrl:'DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_encounterreason_israndnoapprovedate_Sortedstatus',ctrl:'DDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE',prop:'SortedStatus'},{av:'AV13BR_Encounter_IDTitleFilterData',fld:'vBR_ENCOUNTER_IDTITLEFILTERDATA',pic:''},{av:'AV15BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV17BR_EncounterReason_ReasonTitleFilterData',fld:'vBR_ENCOUNTERREASON_REASONTITLEFILTERDATA',pic:''},{av:'AV19BR_EncounterReason_IsRandNoApproveDateTitleFilterData',fld:'vBR_ENCOUNTERREASON_ISRANDNOAPPROVEDATETITLEFILTERDATA',pic:''},{av:'AV21BR_EncounterReason_IsRandApproveTitleFilterData',fld:'vBR_ENCOUNTERREASON_ISRANDAPPROVETITLEFILTERDATA',pic:''},{av:'AV23BR_EncounterReason_StatusTitleFilterData',fld:'vBR_ENCOUNTERREASON_STATUSTITLEFILTERDATA',pic:''},{av:'AV25BR_EncounterReason_IsRandApproverTitleFilterData',fld:'vBR_ENCOUNTERREASON_ISRANDAPPROVERTITLEFILTERDATA',pic:''},{av:'edtBR_Encounter_ID_Titleformat',ctrl:'BR_ENCOUNTER_ID',prop:'Titleformat'},{av:'edtBR_Encounter_ID_Title',ctrl:'BR_ENCOUNTER_ID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_EncounterReason_Reason_Titleformat',ctrl:'BR_ENCOUNTERREASON_REASON',prop:'Titleformat'},{av:'edtBR_EncounterReason_Reason_Title',ctrl:'BR_ENCOUNTERREASON_REASON',prop:'Title'},{av:'edtBR_EncounterReason_IsRandNoApproveDate_Titleformat',ctrl:'BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE',prop:'Titleformat'},{av:'edtBR_EncounterReason_IsRandNoApproveDate_Title',ctrl:'BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE',prop:'Title'},{av:'chkBR_EncounterReason_IsRandApprove_Titleformat',ctrl:'BR_ENCOUNTERREASON_ISRANDAPPROVE',prop:'Titleformat'},{av:'chkBR_EncounterReason_IsRandApprove.Title.Text',ctrl:'BR_ENCOUNTERREASON_ISRANDAPPROVE',prop:'Title'},{av:'cmbBR_EncounterReason_Status'},{av:'edtBR_EncounterReason_IsRandApprover_Titleformat',ctrl:'BR_ENCOUNTERREASON_ISRANDAPPROVER',prop:'Titleformat'},{av:'edtBR_EncounterReason_IsRandApprover_Title',ctrl:'BR_ENCOUNTERREASON_ISRANDAPPROVER',prop:'Title'},{av:'AV29GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV30GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV31GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_ENCOUNTERREASON_ISRANDAPPROVE.ONOPTIONCLICKED","{handler:'E17792',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_Encounter_IDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_IDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_EncounterReason_ReasonTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_REASONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_EncounterReason_IsRandNoApproveDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_EncounterReason_IsRandApproveTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_EncounterReason_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_EncounterReason_IsRandApproverTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_ISRANDAPPROVERTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_encounterreason_israndapprove_Activeeventkey',ctrl:'DDO_BR_ENCOUNTERREASON_ISRANDAPPROVE',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_ENCOUNTERREASON_ISRANDAPPROVE.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_encounterreason_israndapprove_Sortedstatus',ctrl:'DDO_BR_ENCOUNTERREASON_ISRANDAPPROVE',prop:'SortedStatus'},{av:'AV13BR_Encounter_IDTitleFilterData',fld:'vBR_ENCOUNTER_IDTITLEFILTERDATA',pic:''},{av:'AV15BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV17BR_EncounterReason_ReasonTitleFilterData',fld:'vBR_ENCOUNTERREASON_REASONTITLEFILTERDATA',pic:''},{av:'AV19BR_EncounterReason_IsRandNoApproveDateTitleFilterData',fld:'vBR_ENCOUNTERREASON_ISRANDNOAPPROVEDATETITLEFILTERDATA',pic:''},{av:'AV21BR_EncounterReason_IsRandApproveTitleFilterData',fld:'vBR_ENCOUNTERREASON_ISRANDAPPROVETITLEFILTERDATA',pic:''},{av:'AV23BR_EncounterReason_StatusTitleFilterData',fld:'vBR_ENCOUNTERREASON_STATUSTITLEFILTERDATA',pic:''},{av:'AV25BR_EncounterReason_IsRandApproverTitleFilterData',fld:'vBR_ENCOUNTERREASON_ISRANDAPPROVERTITLEFILTERDATA',pic:''},{av:'edtBR_Encounter_ID_Titleformat',ctrl:'BR_ENCOUNTER_ID',prop:'Titleformat'},{av:'edtBR_Encounter_ID_Title',ctrl:'BR_ENCOUNTER_ID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_EncounterReason_Reason_Titleformat',ctrl:'BR_ENCOUNTERREASON_REASON',prop:'Titleformat'},{av:'edtBR_EncounterReason_Reason_Title',ctrl:'BR_ENCOUNTERREASON_REASON',prop:'Title'},{av:'edtBR_EncounterReason_IsRandNoApproveDate_Titleformat',ctrl:'BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE',prop:'Titleformat'},{av:'edtBR_EncounterReason_IsRandNoApproveDate_Title',ctrl:'BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE',prop:'Title'},{av:'chkBR_EncounterReason_IsRandApprove_Titleformat',ctrl:'BR_ENCOUNTERREASON_ISRANDAPPROVE',prop:'Titleformat'},{av:'chkBR_EncounterReason_IsRandApprove.Title.Text',ctrl:'BR_ENCOUNTERREASON_ISRANDAPPROVE',prop:'Title'},{av:'cmbBR_EncounterReason_Status'},{av:'edtBR_EncounterReason_IsRandApprover_Titleformat',ctrl:'BR_ENCOUNTERREASON_ISRANDAPPROVER',prop:'Titleformat'},{av:'edtBR_EncounterReason_IsRandApprover_Title',ctrl:'BR_ENCOUNTERREASON_ISRANDAPPROVER',prop:'Title'},{av:'AV29GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV30GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV31GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_ENCOUNTERREASON_STATUS.ONOPTIONCLICKED","{handler:'E18792',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_Encounter_IDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_IDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_EncounterReason_ReasonTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_REASONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_EncounterReason_IsRandNoApproveDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_EncounterReason_IsRandApproveTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_EncounterReason_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_EncounterReason_IsRandApproverTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_ISRANDAPPROVERTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_encounterreason_status_Activeeventkey',ctrl:'DDO_BR_ENCOUNTERREASON_STATUS',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_ENCOUNTERREASON_STATUS.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_encounterreason_status_Sortedstatus',ctrl:'DDO_BR_ENCOUNTERREASON_STATUS',prop:'SortedStatus'},{av:'AV13BR_Encounter_IDTitleFilterData',fld:'vBR_ENCOUNTER_IDTITLEFILTERDATA',pic:''},{av:'AV15BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV17BR_EncounterReason_ReasonTitleFilterData',fld:'vBR_ENCOUNTERREASON_REASONTITLEFILTERDATA',pic:''},{av:'AV19BR_EncounterReason_IsRandNoApproveDateTitleFilterData',fld:'vBR_ENCOUNTERREASON_ISRANDNOAPPROVEDATETITLEFILTERDATA',pic:''},{av:'AV21BR_EncounterReason_IsRandApproveTitleFilterData',fld:'vBR_ENCOUNTERREASON_ISRANDAPPROVETITLEFILTERDATA',pic:''},{av:'AV23BR_EncounterReason_StatusTitleFilterData',fld:'vBR_ENCOUNTERREASON_STATUSTITLEFILTERDATA',pic:''},{av:'AV25BR_EncounterReason_IsRandApproverTitleFilterData',fld:'vBR_ENCOUNTERREASON_ISRANDAPPROVERTITLEFILTERDATA',pic:''},{av:'edtBR_Encounter_ID_Titleformat',ctrl:'BR_ENCOUNTER_ID',prop:'Titleformat'},{av:'edtBR_Encounter_ID_Title',ctrl:'BR_ENCOUNTER_ID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_EncounterReason_Reason_Titleformat',ctrl:'BR_ENCOUNTERREASON_REASON',prop:'Titleformat'},{av:'edtBR_EncounterReason_Reason_Title',ctrl:'BR_ENCOUNTERREASON_REASON',prop:'Title'},{av:'edtBR_EncounterReason_IsRandNoApproveDate_Titleformat',ctrl:'BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE',prop:'Titleformat'},{av:'edtBR_EncounterReason_IsRandNoApproveDate_Title',ctrl:'BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE',prop:'Title'},{av:'chkBR_EncounterReason_IsRandApprove_Titleformat',ctrl:'BR_ENCOUNTERREASON_ISRANDAPPROVE',prop:'Titleformat'},{av:'chkBR_EncounterReason_IsRandApprove.Title.Text',ctrl:'BR_ENCOUNTERREASON_ISRANDAPPROVE',prop:'Title'},{av:'cmbBR_EncounterReason_Status'},{av:'edtBR_EncounterReason_IsRandApprover_Titleformat',ctrl:'BR_ENCOUNTERREASON_ISRANDAPPROVER',prop:'Titleformat'},{av:'edtBR_EncounterReason_IsRandApprover_Title',ctrl:'BR_ENCOUNTERREASON_ISRANDAPPROVER',prop:'Title'},{av:'AV29GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV30GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV31GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_ENCOUNTERREASON_ISRANDAPPROVER.ONOPTIONCLICKED","{handler:'E19792',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_Encounter_IDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_IDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_EncounterReason_ReasonTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_REASONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_EncounterReason_IsRandNoApproveDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_EncounterReason_IsRandApproveTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_EncounterReason_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_EncounterReason_IsRandApproverTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERREASON_ISRANDAPPROVERTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_encounterreason_israndapprover_Activeeventkey',ctrl:'DDO_BR_ENCOUNTERREASON_ISRANDAPPROVER',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_ENCOUNTERREASON_ISRANDAPPROVER.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_encounterreason_israndapprover_Sortedstatus',ctrl:'DDO_BR_ENCOUNTERREASON_ISRANDAPPROVER',prop:'SortedStatus'},{av:'AV13BR_Encounter_IDTitleFilterData',fld:'vBR_ENCOUNTER_IDTITLEFILTERDATA',pic:''},{av:'AV15BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV17BR_EncounterReason_ReasonTitleFilterData',fld:'vBR_ENCOUNTERREASON_REASONTITLEFILTERDATA',pic:''},{av:'AV19BR_EncounterReason_IsRandNoApproveDateTitleFilterData',fld:'vBR_ENCOUNTERREASON_ISRANDNOAPPROVEDATETITLEFILTERDATA',pic:''},{av:'AV21BR_EncounterReason_IsRandApproveTitleFilterData',fld:'vBR_ENCOUNTERREASON_ISRANDAPPROVETITLEFILTERDATA',pic:''},{av:'AV23BR_EncounterReason_StatusTitleFilterData',fld:'vBR_ENCOUNTERREASON_STATUSTITLEFILTERDATA',pic:''},{av:'AV25BR_EncounterReason_IsRandApproverTitleFilterData',fld:'vBR_ENCOUNTERREASON_ISRANDAPPROVERTITLEFILTERDATA',pic:''},{av:'edtBR_Encounter_ID_Titleformat',ctrl:'BR_ENCOUNTER_ID',prop:'Titleformat'},{av:'edtBR_Encounter_ID_Title',ctrl:'BR_ENCOUNTER_ID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_EncounterReason_Reason_Titleformat',ctrl:'BR_ENCOUNTERREASON_REASON',prop:'Titleformat'},{av:'edtBR_EncounterReason_Reason_Title',ctrl:'BR_ENCOUNTERREASON_REASON',prop:'Title'},{av:'edtBR_EncounterReason_IsRandNoApproveDate_Titleformat',ctrl:'BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE',prop:'Titleformat'},{av:'edtBR_EncounterReason_IsRandNoApproveDate_Title',ctrl:'BR_ENCOUNTERREASON_ISRANDNOAPPROVEDATE',prop:'Title'},{av:'chkBR_EncounterReason_IsRandApprove_Titleformat',ctrl:'BR_ENCOUNTERREASON_ISRANDAPPROVE',prop:'Titleformat'},{av:'chkBR_EncounterReason_IsRandApprove.Title.Text',ctrl:'BR_ENCOUNTERREASON_ISRANDAPPROVE',prop:'Title'},{av:'cmbBR_EncounterReason_Status'},{av:'edtBR_EncounterReason_IsRandApprover_Titleformat',ctrl:'BR_ENCOUNTERREASON_ISRANDAPPROVER',prop:'Titleformat'},{av:'edtBR_EncounterReason_IsRandApprover_Title',ctrl:'BR_ENCOUNTERREASON_ISRANDAPPROVER',prop:'Title'},{av:'AV29GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV30GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV31GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("GRID.LOAD","{handler:'E22792',iparms:[]");
         setEventMetadata("GRID.LOAD",",oparms:[{av:'AV32Select',fld:'vSELECT',pic:''},{av:'edtavSelect_Tooltiptext',ctrl:'vSELECT',prop:'Tooltiptext'}]}");
         setEventMetadata("ENTER","{handler:'E23792',iparms:[{av:'A347BR_Encounter_ID',fld:'BR_ENCOUNTER_ID',pic:'ZZZZZZZZZZZZZZ9',hsh:true},{av:'A340BR_EncounterReason_Reason',fld:'BR_ENCOUNTERREASON_REASON',pic:'',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[{av:'AV8InOutBR_Encounter_ID',fld:'vINOUTBR_ENCOUNTER_ID',pic:'ZZZZZZZZZZZZZZ9'},{av:'AV9InOutBR_EncounterReason_Reason',fld:'vINOUTBR_ENCOUNTERREASON_REASON',pic:''}]}");
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
         wcpOAV9InOutBR_EncounterReason_Reason = "";
         Gridpaginationbar_Selectedpage = "";
         Ddo_br_encounter_id_Activeeventkey = "";
         Ddo_br_encounterid_Activeeventkey = "";
         Ddo_br_encounterreason_reason_Activeeventkey = "";
         Ddo_br_encounterreason_israndnoapprovedate_Activeeventkey = "";
         Ddo_br_encounterreason_israndapprove_Activeeventkey = "";
         Ddo_br_encounterreason_status_Activeeventkey = "";
         Ddo_br_encounterreason_israndapprover_Activeeventkey = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV14ddo_BR_Encounter_IDTitleControlIdToReplace = "";
         AV16ddo_BR_EncounterIDTitleControlIdToReplace = "";
         AV18ddo_BR_EncounterReason_ReasonTitleControlIdToReplace = "";
         AV20ddo_BR_EncounterReason_IsRandNoApproveDateTitleControlIdToReplace = "";
         AV22ddo_BR_EncounterReason_IsRandApproveTitleControlIdToReplace = "";
         AV24ddo_BR_EncounterReason_StatusTitleControlIdToReplace = "";
         AV26ddo_BR_EncounterReason_IsRandApproverTitleControlIdToReplace = "";
         GXKey = "";
         AV35Pgmname = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         AV27DDO_TitleSettingsIcons = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV13BR_Encounter_IDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV15BR_EncounterIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV17BR_EncounterReason_ReasonTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV19BR_EncounterReason_IsRandNoApproveDateTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV21BR_EncounterReason_IsRandApproveTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV23BR_EncounterReason_StatusTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV25BR_EncounterReason_IsRandApproverTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         Ddo_br_encounter_id_Sortedstatus = "";
         Ddo_br_encounterid_Sortedstatus = "";
         Ddo_br_encounterreason_reason_Sortedstatus = "";
         Ddo_br_encounterreason_israndnoapprovedate_Sortedstatus = "";
         Ddo_br_encounterreason_israndapprove_Sortedstatus = "";
         Ddo_br_encounterreason_status_Sortedstatus = "";
         Ddo_br_encounterreason_israndapprover_Sortedstatus = "";
         GX_FocusControl = "";
         sPrefix = "";
         GridContainer = new GXWebGrid( context);
         sStyleString = "";
         subGrid_Linesclass = "";
         GridColumn = new GXWebColumn();
         AV32Select = "";
         A340BR_EncounterReason_Reason = "";
         A341BR_EncounterReason_IsRandNoApproveDate = (DateTime)(DateTime.MinValue);
         A344BR_EncounterReason_IsRandApprover = "";
         ucGridpaginationbar = new GXUserControl();
         ucDdo_br_encounter_id = new GXUserControl();
         TempTags = "";
         ClassString = "";
         StyleString = "";
         ucDdo_br_encounterid = new GXUserControl();
         ucDdo_br_encounterreason_reason = new GXUserControl();
         ucDdo_br_encounterreason_israndnoapprovedate = new GXUserControl();
         ucDdo_br_encounterreason_israndapprove = new GXUserControl();
         ucDdo_br_encounterreason_status = new GXUserControl();
         ucDdo_br_encounterreason_israndapprover = new GXUserControl();
         ucWorkwithplusutilities1 = new GXUserControl();
         Form = new GXWebForm();
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV36Select_GXI = "";
         scmdbuf = "";
         H00792_A344BR_EncounterReason_IsRandApprover = new String[] {""} ;
         H00792_n344BR_EncounterReason_IsRandApprover = new bool[] {false} ;
         H00792_A343BR_EncounterReason_Status = new short[1] ;
         H00792_n343BR_EncounterReason_Status = new bool[] {false} ;
         H00792_A342BR_EncounterReason_IsRandApprove = new bool[] {false} ;
         H00792_n342BR_EncounterReason_IsRandApprove = new bool[] {false} ;
         H00792_A341BR_EncounterReason_IsRandNoApproveDate = new DateTime[] {DateTime.MinValue} ;
         H00792_n341BR_EncounterReason_IsRandNoApproveDate = new bool[] {false} ;
         H00792_A340BR_EncounterReason_Reason = new String[] {""} ;
         H00792_n340BR_EncounterReason_Reason = new bool[] {false} ;
         H00792_A19BR_EncounterID = new long[1] ;
         H00792_A347BR_Encounter_ID = new long[1] ;
         H00793_AGRID_nRecordCount = new long[1] ;
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV6WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         GridRow = new GXWebRow();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sImgUrl = "";
         ROClassString = "";
         GXCCtl = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_encounterreasonprompt__default(),
            new Object[][] {
                new Object[] {
               H00792_A344BR_EncounterReason_IsRandApprover, H00792_n344BR_EncounterReason_IsRandApprover, H00792_A343BR_EncounterReason_Status, H00792_n343BR_EncounterReason_Status, H00792_A342BR_EncounterReason_IsRandApprove, H00792_n342BR_EncounterReason_IsRandApprove, H00792_A341BR_EncounterReason_IsRandNoApproveDate, H00792_n341BR_EncounterReason_IsRandNoApproveDate, H00792_A340BR_EncounterReason_Reason, H00792_n340BR_EncounterReason_Reason,
               H00792_A19BR_EncounterID, H00792_A347BR_Encounter_ID
               }
               , new Object[] {
               H00793_AGRID_nRecordCount
               }
            }
         );
         AV35Pgmname = "BR_EncounterReasonPrompt";
         /* GeneXus formulas. */
         AV35Pgmname = "BR_EncounterReasonPrompt";
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
      private short edtBR_Encounter_ID_Titleformat ;
      private short edtBR_EncounterID_Titleformat ;
      private short edtBR_EncounterReason_Reason_Titleformat ;
      private short edtBR_EncounterReason_IsRandNoApproveDate_Titleformat ;
      private short chkBR_EncounterReason_IsRandApprove_Titleformat ;
      private short cmbBR_EncounterReason_Status_Titleformat ;
      private short edtBR_EncounterReason_IsRandApprover_Titleformat ;
      private short subGrid_Sortable ;
      private short A343BR_EncounterReason_Status ;
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
      private int edtavDdo_br_encounter_idtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_encounteridtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_encounterreason_reasontitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_encounterreason_israndnoapprovedatetitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_encounterreason_israndapprovetitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_encounterreason_statustitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_encounterreason_israndapprovertitlecontrolidtoreplace_Visible ;
      private int edtavOrderedby_Visible ;
      private int edtavOrdereddsc_Visible ;
      private int subGrid_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int AV28PageToGo ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private int edtavSelect_Enabled ;
      private int edtavSelect_Visible ;
      private long AV8InOutBR_Encounter_ID ;
      private long wcpOAV8InOutBR_Encounter_ID ;
      private long GRID_nFirstRecordOnPage ;
      private long AV29GridCurrentPage ;
      private long AV31GridRecordCount ;
      private long AV30GridPageSize ;
      private long A347BR_Encounter_ID ;
      private long A19BR_EncounterID ;
      private long GRID_nCurrentRecord ;
      private long GRID_nRecordCount ;
      private String Gridpaginationbar_Selectedpage ;
      private String Ddo_br_encounter_id_Activeeventkey ;
      private String Ddo_br_encounterid_Activeeventkey ;
      private String Ddo_br_encounterreason_reason_Activeeventkey ;
      private String Ddo_br_encounterreason_israndnoapprovedate_Activeeventkey ;
      private String Ddo_br_encounterreason_israndapprove_Activeeventkey ;
      private String Ddo_br_encounterreason_status_Activeeventkey ;
      private String Ddo_br_encounterreason_israndapprover_Activeeventkey ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_12_idx="0001" ;
      private String GXKey ;
      private String AV35Pgmname ;
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
      private String Ddo_br_encounter_id_Caption ;
      private String Ddo_br_encounter_id_Tooltip ;
      private String Ddo_br_encounter_id_Cls ;
      private String Ddo_br_encounter_id_Dropdownoptionstype ;
      private String Ddo_br_encounter_id_Titlecontrolidtoreplace ;
      private String Ddo_br_encounter_id_Sortedstatus ;
      private String Ddo_br_encounter_id_Sortasc ;
      private String Ddo_br_encounter_id_Sortdsc ;
      private String Ddo_br_encounter_id_Searchbuttontext ;
      private String Ddo_br_encounterid_Caption ;
      private String Ddo_br_encounterid_Tooltip ;
      private String Ddo_br_encounterid_Cls ;
      private String Ddo_br_encounterid_Dropdownoptionstype ;
      private String Ddo_br_encounterid_Titlecontrolidtoreplace ;
      private String Ddo_br_encounterid_Sortedstatus ;
      private String Ddo_br_encounterid_Sortasc ;
      private String Ddo_br_encounterid_Sortdsc ;
      private String Ddo_br_encounterid_Searchbuttontext ;
      private String Ddo_br_encounterreason_reason_Caption ;
      private String Ddo_br_encounterreason_reason_Tooltip ;
      private String Ddo_br_encounterreason_reason_Cls ;
      private String Ddo_br_encounterreason_reason_Dropdownoptionstype ;
      private String Ddo_br_encounterreason_reason_Titlecontrolidtoreplace ;
      private String Ddo_br_encounterreason_reason_Sortedstatus ;
      private String Ddo_br_encounterreason_reason_Sortasc ;
      private String Ddo_br_encounterreason_reason_Sortdsc ;
      private String Ddo_br_encounterreason_reason_Searchbuttontext ;
      private String Ddo_br_encounterreason_israndnoapprovedate_Caption ;
      private String Ddo_br_encounterreason_israndnoapprovedate_Tooltip ;
      private String Ddo_br_encounterreason_israndnoapprovedate_Cls ;
      private String Ddo_br_encounterreason_israndnoapprovedate_Dropdownoptionstype ;
      private String Ddo_br_encounterreason_israndnoapprovedate_Titlecontrolidtoreplace ;
      private String Ddo_br_encounterreason_israndnoapprovedate_Sortedstatus ;
      private String Ddo_br_encounterreason_israndnoapprovedate_Sortasc ;
      private String Ddo_br_encounterreason_israndnoapprovedate_Sortdsc ;
      private String Ddo_br_encounterreason_israndnoapprovedate_Searchbuttontext ;
      private String Ddo_br_encounterreason_israndapprove_Caption ;
      private String Ddo_br_encounterreason_israndapprove_Tooltip ;
      private String Ddo_br_encounterreason_israndapprove_Cls ;
      private String Ddo_br_encounterreason_israndapprove_Dropdownoptionstype ;
      private String Ddo_br_encounterreason_israndapprove_Titlecontrolidtoreplace ;
      private String Ddo_br_encounterreason_israndapprove_Sortedstatus ;
      private String Ddo_br_encounterreason_israndapprove_Sortasc ;
      private String Ddo_br_encounterreason_israndapprove_Sortdsc ;
      private String Ddo_br_encounterreason_israndapprove_Searchbuttontext ;
      private String Ddo_br_encounterreason_status_Caption ;
      private String Ddo_br_encounterreason_status_Tooltip ;
      private String Ddo_br_encounterreason_status_Cls ;
      private String Ddo_br_encounterreason_status_Dropdownoptionstype ;
      private String Ddo_br_encounterreason_status_Titlecontrolidtoreplace ;
      private String Ddo_br_encounterreason_status_Sortedstatus ;
      private String Ddo_br_encounterreason_status_Sortasc ;
      private String Ddo_br_encounterreason_status_Sortdsc ;
      private String Ddo_br_encounterreason_status_Searchbuttontext ;
      private String Ddo_br_encounterreason_israndapprover_Caption ;
      private String Ddo_br_encounterreason_israndapprover_Tooltip ;
      private String Ddo_br_encounterreason_israndapprover_Cls ;
      private String Ddo_br_encounterreason_israndapprover_Dropdownoptionstype ;
      private String Ddo_br_encounterreason_israndapprover_Titlecontrolidtoreplace ;
      private String Ddo_br_encounterreason_israndapprover_Sortedstatus ;
      private String Ddo_br_encounterreason_israndapprover_Sortasc ;
      private String Ddo_br_encounterreason_israndapprover_Sortdsc ;
      private String Ddo_br_encounterreason_israndapprover_Searchbuttontext ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divLayoutmaintable_Internalname ;
      private String divTablemain_Internalname ;
      private String divGridtablewithpaginationbar_Internalname ;
      private String sStyleString ;
      private String subGrid_Internalname ;
      private String subGrid_Class ;
      private String subGrid_Linesclass ;
      private String edtBR_Encounter_ID_Title ;
      private String edtBR_EncounterID_Title ;
      private String edtBR_EncounterReason_Reason_Title ;
      private String edtBR_EncounterReason_IsRandNoApproveDate_Title ;
      private String edtBR_EncounterReason_IsRandApprover_Title ;
      private String subGrid_Header ;
      private String edtavSelect_Tooltiptext ;
      private String divHtml_gridpaginationbar_Internalname ;
      private String Gridpaginationbar_Internalname ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String Ddo_br_encounter_id_Internalname ;
      private String TempTags ;
      private String ClassString ;
      private String StyleString ;
      private String edtavDdo_br_encounter_idtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_encounterid_Internalname ;
      private String edtavDdo_br_encounteridtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_encounterreason_reason_Internalname ;
      private String edtavDdo_br_encounterreason_reasontitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_encounterreason_israndnoapprovedate_Internalname ;
      private String edtavDdo_br_encounterreason_israndnoapprovedatetitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_encounterreason_israndapprove_Internalname ;
      private String edtavDdo_br_encounterreason_israndapprovetitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_encounterreason_status_Internalname ;
      private String edtavDdo_br_encounterreason_statustitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_encounterreason_israndapprover_Internalname ;
      private String edtavDdo_br_encounterreason_israndapprovertitlecontrolidtoreplace_Internalname ;
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
      private String edtBR_Encounter_ID_Internalname ;
      private String edtBR_EncounterID_Internalname ;
      private String edtBR_EncounterReason_Reason_Internalname ;
      private String edtBR_EncounterReason_IsRandNoApproveDate_Internalname ;
      private String chkBR_EncounterReason_IsRandApprove_Internalname ;
      private String cmbBR_EncounterReason_Status_Internalname ;
      private String edtBR_EncounterReason_IsRandApprover_Internalname ;
      private String scmdbuf ;
      private String sGXsfl_12_fel_idx="0001" ;
      private String sImgUrl ;
      private String edtavSelect_Jsonclick ;
      private String ROClassString ;
      private String edtBR_Encounter_ID_Jsonclick ;
      private String edtBR_EncounterID_Jsonclick ;
      private String edtBR_EncounterReason_Reason_Jsonclick ;
      private String edtBR_EncounterReason_IsRandNoApproveDate_Jsonclick ;
      private String GXCCtl ;
      private String cmbBR_EncounterReason_Status_Jsonclick ;
      private String edtBR_EncounterReason_IsRandApprover_Jsonclick ;
      private DateTime A341BR_EncounterReason_IsRandNoApproveDate ;
      private bool entryPointCalled ;
      private bool AV12OrderedDsc ;
      private bool toggleJsOutput ;
      private bool Gridpaginationbar_Showfirst ;
      private bool Gridpaginationbar_Showprevious ;
      private bool Gridpaginationbar_Shownext ;
      private bool Gridpaginationbar_Showlast ;
      private bool Gridpaginationbar_Rowsperpageselector ;
      private bool Ddo_br_encounter_id_Includesortasc ;
      private bool Ddo_br_encounter_id_Includesortdsc ;
      private bool Ddo_br_encounter_id_Includefilter ;
      private bool Ddo_br_encounter_id_Includedatalist ;
      private bool Ddo_br_encounterid_Includesortasc ;
      private bool Ddo_br_encounterid_Includesortdsc ;
      private bool Ddo_br_encounterid_Includefilter ;
      private bool Ddo_br_encounterid_Includedatalist ;
      private bool Ddo_br_encounterreason_reason_Includesortasc ;
      private bool Ddo_br_encounterreason_reason_Includesortdsc ;
      private bool Ddo_br_encounterreason_reason_Includefilter ;
      private bool Ddo_br_encounterreason_reason_Includedatalist ;
      private bool Ddo_br_encounterreason_israndnoapprovedate_Includesortasc ;
      private bool Ddo_br_encounterreason_israndnoapprovedate_Includesortdsc ;
      private bool Ddo_br_encounterreason_israndnoapprovedate_Includefilter ;
      private bool Ddo_br_encounterreason_israndnoapprovedate_Includedatalist ;
      private bool Ddo_br_encounterreason_israndapprove_Includesortasc ;
      private bool Ddo_br_encounterreason_israndapprove_Includesortdsc ;
      private bool Ddo_br_encounterreason_israndapprove_Includefilter ;
      private bool Ddo_br_encounterreason_israndapprove_Includedatalist ;
      private bool Ddo_br_encounterreason_status_Includesortasc ;
      private bool Ddo_br_encounterreason_status_Includesortdsc ;
      private bool Ddo_br_encounterreason_status_Includefilter ;
      private bool Ddo_br_encounterreason_status_Includedatalist ;
      private bool Ddo_br_encounterreason_israndapprover_Includesortasc ;
      private bool Ddo_br_encounterreason_israndapprover_Includesortdsc ;
      private bool Ddo_br_encounterreason_israndapprover_Includefilter ;
      private bool Ddo_br_encounterreason_israndapprover_Includedatalist ;
      private bool wbLoad ;
      private bool A342BR_EncounterReason_IsRandApprove ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_12_Refreshing=false ;
      private bool n340BR_EncounterReason_Reason ;
      private bool n341BR_EncounterReason_IsRandNoApproveDate ;
      private bool n342BR_EncounterReason_IsRandApprove ;
      private bool n343BR_EncounterReason_Status ;
      private bool n344BR_EncounterReason_IsRandApprover ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool AV5IsAuthorized ;
      private bool GXt_boolean1 ;
      private bool gx_refresh_fired ;
      private bool AV32Select_IsBlob ;
      private String AV9InOutBR_EncounterReason_Reason ;
      private String wcpOAV9InOutBR_EncounterReason_Reason ;
      private String AV14ddo_BR_Encounter_IDTitleControlIdToReplace ;
      private String AV16ddo_BR_EncounterIDTitleControlIdToReplace ;
      private String AV18ddo_BR_EncounterReason_ReasonTitleControlIdToReplace ;
      private String AV20ddo_BR_EncounterReason_IsRandNoApproveDateTitleControlIdToReplace ;
      private String AV22ddo_BR_EncounterReason_IsRandApproveTitleControlIdToReplace ;
      private String AV24ddo_BR_EncounterReason_StatusTitleControlIdToReplace ;
      private String AV26ddo_BR_EncounterReason_IsRandApproverTitleControlIdToReplace ;
      private String A340BR_EncounterReason_Reason ;
      private String A344BR_EncounterReason_IsRandApprover ;
      private String AV36Select_GXI ;
      private String AV32Select ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private GXUserControl ucGridpaginationbar ;
      private GXUserControl ucDdo_br_encounter_id ;
      private GXUserControl ucDdo_br_encounterid ;
      private GXUserControl ucDdo_br_encounterreason_reason ;
      private GXUserControl ucDdo_br_encounterreason_israndnoapprovedate ;
      private GXUserControl ucDdo_br_encounterreason_israndapprove ;
      private GXUserControl ucDdo_br_encounterreason_status ;
      private GXUserControl ucDdo_br_encounterreason_israndapprover ;
      private GXUserControl ucWorkwithplusutilities1 ;
      private GXWebForm Form ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private long aP0_InOutBR_Encounter_ID ;
      private String aP1_InOutBR_EncounterReason_Reason ;
      private GXCheckbox chkBR_EncounterReason_IsRandApprove ;
      private GXCombobox cmbBR_EncounterReason_Status ;
      private IDataStoreProvider pr_default ;
      private String[] H00792_A344BR_EncounterReason_IsRandApprover ;
      private bool[] H00792_n344BR_EncounterReason_IsRandApprover ;
      private short[] H00792_A343BR_EncounterReason_Status ;
      private bool[] H00792_n343BR_EncounterReason_Status ;
      private bool[] H00792_A342BR_EncounterReason_IsRandApprove ;
      private bool[] H00792_n342BR_EncounterReason_IsRandApprove ;
      private DateTime[] H00792_A341BR_EncounterReason_IsRandNoApproveDate ;
      private bool[] H00792_n341BR_EncounterReason_IsRandNoApproveDate ;
      private String[] H00792_A340BR_EncounterReason_Reason ;
      private bool[] H00792_n340BR_EncounterReason_Reason ;
      private long[] H00792_A19BR_EncounterID ;
      private long[] H00792_A347BR_Encounter_ID ;
      private long[] H00793_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV13BR_Encounter_IDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV15BR_EncounterIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV17BR_EncounterReason_ReasonTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV19BR_EncounterReason_IsRandNoApproveDateTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV21BR_EncounterReason_IsRandApproveTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV23BR_EncounterReason_StatusTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV25BR_EncounterReason_IsRandApproverTitleFilterData ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons AV27DDO_TitleSettingsIcons ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 ;
   }

   public class br_encounterreasonprompt__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H00792( IGxContext context ,
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
         sSelectString = " [BR_EncounterReason_IsRandApprover], [BR_EncounterReason_Status], [BR_EncounterReason_IsRandApprove], [BR_EncounterReason_IsRandNoApproveDate], [BR_EncounterReason_Reason], [BR_EncounterID], [BR_Encounter_ID]";
         sFromString = " FROM [BR_EncounterReason] WITH (NOLOCK)";
         sOrderString = "";
         if ( ( AV11OrderedBy == 1 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Encounter_ID]";
         }
         else if ( ( AV11OrderedBy == 1 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Encounter_ID] DESC";
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
            sOrderString = sOrderString + " ORDER BY [BR_EncounterReason_Reason]";
         }
         else if ( ( AV11OrderedBy == 3 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_EncounterReason_Reason] DESC";
         }
         else if ( ( AV11OrderedBy == 4 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_EncounterReason_IsRandNoApproveDate]";
         }
         else if ( ( AV11OrderedBy == 4 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_EncounterReason_IsRandNoApproveDate] DESC";
         }
         else if ( ( AV11OrderedBy == 5 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_EncounterReason_IsRandApprove]";
         }
         else if ( ( AV11OrderedBy == 5 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_EncounterReason_IsRandApprove] DESC";
         }
         else if ( ( AV11OrderedBy == 6 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_EncounterReason_Status]";
         }
         else if ( ( AV11OrderedBy == 6 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_EncounterReason_Status] DESC";
         }
         else if ( ( AV11OrderedBy == 7 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_EncounterReason_IsRandApprover]";
         }
         else if ( ( AV11OrderedBy == 7 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_EncounterReason_IsRandApprover] DESC";
         }
         else if ( true )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Encounter_ID]";
         }
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object4[0] = scmdbuf;
         GXv_Object4[1] = GXv_int3;
         return GXv_Object4 ;
      }

      protected Object[] conditional_H00793( IGxContext context ,
                                             short AV11OrderedBy ,
                                             bool AV12OrderedDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         Object[] GXv_Object5 ;
         GXv_Object5 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM [BR_EncounterReason] WITH (NOLOCK)";
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
         else if ( ( AV11OrderedBy == 6 ) && ! AV12OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 6 ) && ( AV12OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 7 ) && ! AV12OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 7 ) && ( AV12OrderedDsc ) )
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
                     return conditional_H00792(context, (short)dynConstraints[0] , (bool)dynConstraints[1] );
               case 1 :
                     return conditional_H00793(context, (short)dynConstraints[0] , (bool)dynConstraints[1] );
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
          Object[] prmH00792 ;
          prmH00792 = new Object[] {
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH00793 ;
          prmH00793 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("H00792", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00792,11,0,true,false )
             ,new CursorDef("H00793", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00793,1,0,true,false )
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
                ((short[]) buf[2])[0] = rslt.getShort(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((bool[]) buf[4])[0] = rslt.getBool(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((DateTime[]) buf[6])[0] = rslt.getGXDateTime(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((String[]) buf[8])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((long[]) buf[10])[0] = rslt.getLong(6) ;
                ((long[]) buf[11])[0] = rslt.getLong(7) ;
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
