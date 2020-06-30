/*
               File: BR_EncounterPrompt
        Description: 选择就诊信息
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:9:30.16
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
   public class br_encounterprompt : GXHttpHandler, System.Web.SessionState.IRequiresSessionState
   {
      public br_encounterprompt( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_encounterprompt( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( ref long aP0_InOutBR_EncounterID )
      {
         this.AV8InOutBR_EncounterID = aP0_InOutBR_EncounterID;
         executePrivate();
         aP0_InOutBR_EncounterID=this.AV8InOutBR_EncounterID;
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         cmbBR_Encounter_Status = new GXCombobox();
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
               AV16ddo_BR_EncounterIDTitleControlIdToReplace = GetNextPar( );
               AV18ddo_BR_Encounter_EncIDTitleControlIdToReplace = GetNextPar( );
               AV20ddo_BR_Encounter_DepartmentTitleControlIdToReplace = GetNextPar( );
               AV22ddo_BR_Encounter_ENCTypeTitleControlIdToReplace = GetNextPar( );
               AV24ddo_BR_Encounter_AdmitDateTitleControlIdToReplace = GetNextPar( );
               AV26ddo_BR_Encounter_AdmitSourceTitleControlIdToReplace = GetNextPar( );
               AV28ddo_BR_Encounter_DischargeDateTitleControlIdToReplace = GetNextPar( );
               AV30ddo_BR_Encounter_DischargeStatusTitleControlIdToReplace = GetNextPar( );
               AV50ddo_BR_Encounter_StatusTitleControlIdToReplace = GetNextPar( );
               AV32ddo_BR_Information_IDTitleControlIdToReplace = GetNextPar( );
               AV34ddo_BR_Information_PatientNoTitleControlIdToReplace = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV16ddo_BR_EncounterIDTitleControlIdToReplace, AV18ddo_BR_Encounter_EncIDTitleControlIdToReplace, AV20ddo_BR_Encounter_DepartmentTitleControlIdToReplace, AV22ddo_BR_Encounter_ENCTypeTitleControlIdToReplace, AV24ddo_BR_Encounter_AdmitDateTitleControlIdToReplace, AV26ddo_BR_Encounter_AdmitSourceTitleControlIdToReplace, AV28ddo_BR_Encounter_DischargeDateTitleControlIdToReplace, AV30ddo_BR_Encounter_DischargeStatusTitleControlIdToReplace, AV50ddo_BR_Encounter_StatusTitleControlIdToReplace, AV32ddo_BR_Information_IDTitleControlIdToReplace, AV34ddo_BR_Information_PatientNoTitleControlIdToReplace) ;
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
               AV8InOutBR_EncounterID = (long)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8InOutBR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8InOutBR_EncounterID), 18, 0)));
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
            PA152( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV77Pgmname = "BR_EncounterPrompt";
               context.Gx_err = 0;
               WS152( ) ;
               if ( ! isAjaxCallMode( ) )
               {
                  WE152( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?20202281593036", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_encounterprompt.aspx") + "?" + UrlEncode("" +AV8InOutBR_EncounterID)+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "vGRIDCURRENTPAGE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV41GridCurrentPage), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDRECORDCOUNT", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV43GridRecordCount), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDPAGESIZE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV42GridPageSize), 10, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vDDO_TITLESETTINGSICONS", AV39DDO_TitleSettingsIcons);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vDDO_TITLESETTINGSICONS", AV39DDO_TitleSettingsIcons);
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
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_ENCOUNTER_ENCIDTITLEFILTERDATA", AV17BR_Encounter_EncIDTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_ENCOUNTER_ENCIDTITLEFILTERDATA", AV17BR_Encounter_EncIDTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_ENCOUNTER_DEPARTMENTTITLEFILTERDATA", AV19BR_Encounter_DepartmentTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_ENCOUNTER_DEPARTMENTTITLEFILTERDATA", AV19BR_Encounter_DepartmentTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_ENCOUNTER_ENCTYPETITLEFILTERDATA", AV21BR_Encounter_ENCTypeTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_ENCOUNTER_ENCTYPETITLEFILTERDATA", AV21BR_Encounter_ENCTypeTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_ENCOUNTER_ADMITDATETITLEFILTERDATA", AV23BR_Encounter_AdmitDateTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_ENCOUNTER_ADMITDATETITLEFILTERDATA", AV23BR_Encounter_AdmitDateTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_ENCOUNTER_ADMITSOURCETITLEFILTERDATA", AV25BR_Encounter_AdmitSourceTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_ENCOUNTER_ADMITSOURCETITLEFILTERDATA", AV25BR_Encounter_AdmitSourceTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_ENCOUNTER_DISCHARGEDATETITLEFILTERDATA", AV27BR_Encounter_DischargeDateTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_ENCOUNTER_DISCHARGEDATETITLEFILTERDATA", AV27BR_Encounter_DischargeDateTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_ENCOUNTER_DISCHARGESTATUSTITLEFILTERDATA", AV29BR_Encounter_DischargeStatusTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_ENCOUNTER_DISCHARGESTATUSTITLEFILTERDATA", AV29BR_Encounter_DischargeStatusTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_ENCOUNTER_STATUSTITLEFILTERDATA", AV49BR_Encounter_StatusTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_ENCOUNTER_STATUSTITLEFILTERDATA", AV49BR_Encounter_StatusTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_INFORMATION_IDTITLEFILTERDATA", AV31BR_Information_IDTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_INFORMATION_IDTITLEFILTERDATA", AV31BR_Information_IDTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_INFORMATION_PATIENTNOTITLEFILTERDATA", AV33BR_Information_PatientNoTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_INFORMATION_PATIENTNOTITLEFILTERDATA", AV33BR_Information_PatientNoTitleFilterData);
         }
         GxWebStd.gx_hidden_field( context, "vINOUTBR_ENCOUNTERID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8InOutBR_EncounterID), 18, 0, ".", "")));
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
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ENCID_Caption", StringUtil.RTrim( Ddo_br_encounter_encid_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ENCID_Tooltip", StringUtil.RTrim( Ddo_br_encounter_encid_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ENCID_Cls", StringUtil.RTrim( Ddo_br_encounter_encid_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ENCID_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_encounter_encid_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ENCID_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_encounter_encid_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ENCID_Includesortasc", StringUtil.BoolToStr( Ddo_br_encounter_encid_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ENCID_Includesortdsc", StringUtil.BoolToStr( Ddo_br_encounter_encid_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ENCID_Sortedstatus", StringUtil.RTrim( Ddo_br_encounter_encid_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ENCID_Includefilter", StringUtil.BoolToStr( Ddo_br_encounter_encid_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ENCID_Includedatalist", StringUtil.BoolToStr( Ddo_br_encounter_encid_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ENCID_Sortasc", StringUtil.RTrim( Ddo_br_encounter_encid_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ENCID_Sortdsc", StringUtil.RTrim( Ddo_br_encounter_encid_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ENCID_Searchbuttontext", StringUtil.RTrim( Ddo_br_encounter_encid_Searchbuttontext));
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
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ADMITSOURCE_Caption", StringUtil.RTrim( Ddo_br_encounter_admitsource_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ADMITSOURCE_Tooltip", StringUtil.RTrim( Ddo_br_encounter_admitsource_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ADMITSOURCE_Cls", StringUtil.RTrim( Ddo_br_encounter_admitsource_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ADMITSOURCE_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_encounter_admitsource_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ADMITSOURCE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_encounter_admitsource_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ADMITSOURCE_Includesortasc", StringUtil.BoolToStr( Ddo_br_encounter_admitsource_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ADMITSOURCE_Includesortdsc", StringUtil.BoolToStr( Ddo_br_encounter_admitsource_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ADMITSOURCE_Sortedstatus", StringUtil.RTrim( Ddo_br_encounter_admitsource_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ADMITSOURCE_Includefilter", StringUtil.BoolToStr( Ddo_br_encounter_admitsource_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ADMITSOURCE_Includedatalist", StringUtil.BoolToStr( Ddo_br_encounter_admitsource_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ADMITSOURCE_Sortasc", StringUtil.RTrim( Ddo_br_encounter_admitsource_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ADMITSOURCE_Sortdsc", StringUtil.RTrim( Ddo_br_encounter_admitsource_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ADMITSOURCE_Searchbuttontext", StringUtil.RTrim( Ddo_br_encounter_admitsource_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_DISCHARGEDATE_Caption", StringUtil.RTrim( Ddo_br_encounter_dischargedate_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_DISCHARGEDATE_Tooltip", StringUtil.RTrim( Ddo_br_encounter_dischargedate_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_DISCHARGEDATE_Cls", StringUtil.RTrim( Ddo_br_encounter_dischargedate_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_DISCHARGEDATE_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_encounter_dischargedate_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_DISCHARGEDATE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_encounter_dischargedate_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_DISCHARGEDATE_Includesortasc", StringUtil.BoolToStr( Ddo_br_encounter_dischargedate_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_DISCHARGEDATE_Includesortdsc", StringUtil.BoolToStr( Ddo_br_encounter_dischargedate_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_DISCHARGEDATE_Sortedstatus", StringUtil.RTrim( Ddo_br_encounter_dischargedate_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_DISCHARGEDATE_Includefilter", StringUtil.BoolToStr( Ddo_br_encounter_dischargedate_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_DISCHARGEDATE_Includedatalist", StringUtil.BoolToStr( Ddo_br_encounter_dischargedate_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_DISCHARGEDATE_Sortasc", StringUtil.RTrim( Ddo_br_encounter_dischargedate_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_DISCHARGEDATE_Sortdsc", StringUtil.RTrim( Ddo_br_encounter_dischargedate_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_DISCHARGEDATE_Searchbuttontext", StringUtil.RTrim( Ddo_br_encounter_dischargedate_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_DISCHARGESTATUS_Caption", StringUtil.RTrim( Ddo_br_encounter_dischargestatus_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_DISCHARGESTATUS_Tooltip", StringUtil.RTrim( Ddo_br_encounter_dischargestatus_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_DISCHARGESTATUS_Cls", StringUtil.RTrim( Ddo_br_encounter_dischargestatus_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_DISCHARGESTATUS_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_encounter_dischargestatus_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_DISCHARGESTATUS_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_encounter_dischargestatus_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_DISCHARGESTATUS_Includesortasc", StringUtil.BoolToStr( Ddo_br_encounter_dischargestatus_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_DISCHARGESTATUS_Includesortdsc", StringUtil.BoolToStr( Ddo_br_encounter_dischargestatus_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_DISCHARGESTATUS_Sortedstatus", StringUtil.RTrim( Ddo_br_encounter_dischargestatus_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_DISCHARGESTATUS_Includefilter", StringUtil.BoolToStr( Ddo_br_encounter_dischargestatus_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_DISCHARGESTATUS_Includedatalist", StringUtil.BoolToStr( Ddo_br_encounter_dischargestatus_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_DISCHARGESTATUS_Sortasc", StringUtil.RTrim( Ddo_br_encounter_dischargestatus_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_DISCHARGESTATUS_Sortdsc", StringUtil.RTrim( Ddo_br_encounter_dischargestatus_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_DISCHARGESTATUS_Searchbuttontext", StringUtil.RTrim( Ddo_br_encounter_dischargestatus_Searchbuttontext));
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
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_ID_Caption", StringUtil.RTrim( Ddo_br_information_id_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_ID_Tooltip", StringUtil.RTrim( Ddo_br_information_id_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_ID_Cls", StringUtil.RTrim( Ddo_br_information_id_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_ID_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_information_id_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_ID_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_information_id_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_ID_Includesortasc", StringUtil.BoolToStr( Ddo_br_information_id_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_ID_Includesortdsc", StringUtil.BoolToStr( Ddo_br_information_id_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_ID_Sortedstatus", StringUtil.RTrim( Ddo_br_information_id_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_ID_Includefilter", StringUtil.BoolToStr( Ddo_br_information_id_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_ID_Includedatalist", StringUtil.BoolToStr( Ddo_br_information_id_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_ID_Sortasc", StringUtil.RTrim( Ddo_br_information_id_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_ID_Sortdsc", StringUtil.RTrim( Ddo_br_information_id_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_ID_Searchbuttontext", StringUtil.RTrim( Ddo_br_information_id_Searchbuttontext));
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
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Activeeventkey", StringUtil.RTrim( Ddo_br_encounterid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ENCID_Activeeventkey", StringUtil.RTrim( Ddo_br_encounter_encid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_DEPARTMENT_Activeeventkey", StringUtil.RTrim( Ddo_br_encounter_department_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ENCTYPE_Activeeventkey", StringUtil.RTrim( Ddo_br_encounter_enctype_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ADMITDATE_Activeeventkey", StringUtil.RTrim( Ddo_br_encounter_admitdate_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ADMITSOURCE_Activeeventkey", StringUtil.RTrim( Ddo_br_encounter_admitsource_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_DISCHARGEDATE_Activeeventkey", StringUtil.RTrim( Ddo_br_encounter_dischargedate_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_DISCHARGESTATUS_Activeeventkey", StringUtil.RTrim( Ddo_br_encounter_dischargestatus_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_STATUS_Activeeventkey", StringUtil.RTrim( Ddo_br_encounter_status_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_ID_Activeeventkey", StringUtil.RTrim( Ddo_br_information_id_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Activeeventkey", StringUtil.RTrim( Ddo_br_information_patientno_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Activeeventkey", StringUtil.RTrim( Ddo_br_encounterid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ENCID_Activeeventkey", StringUtil.RTrim( Ddo_br_encounter_encid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_DEPARTMENT_Activeeventkey", StringUtil.RTrim( Ddo_br_encounter_department_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ENCTYPE_Activeeventkey", StringUtil.RTrim( Ddo_br_encounter_enctype_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ADMITDATE_Activeeventkey", StringUtil.RTrim( Ddo_br_encounter_admitdate_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ADMITSOURCE_Activeeventkey", StringUtil.RTrim( Ddo_br_encounter_admitsource_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_DISCHARGEDATE_Activeeventkey", StringUtil.RTrim( Ddo_br_encounter_dischargedate_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_DISCHARGESTATUS_Activeeventkey", StringUtil.RTrim( Ddo_br_encounter_dischargestatus_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_STATUS_Activeeventkey", StringUtil.RTrim( Ddo_br_encounter_status_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_ID_Activeeventkey", StringUtil.RTrim( Ddo_br_information_id_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Activeeventkey", StringUtil.RTrim( Ddo_br_information_patientno_Activeeventkey));
      }

      protected void RenderHtmlCloseForm152( )
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
         return "BR_EncounterPrompt" ;
      }

      public override String GetPgmdesc( )
      {
         return "选择就诊信息" ;
      }

      protected void WB150( )
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
               if ( edtBR_EncounterID_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_EncounterID_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_EncounterID_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Encounter_EncID_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Encounter_EncID_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Encounter_EncID_Title) ;
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
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Encounter_AdmitSource_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Encounter_AdmitSource_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Encounter_AdmitSource_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Encounter_DischargeDate_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Encounter_DischargeDate_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Encounter_DischargeDate_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Encounter_DischargeStatus_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Encounter_DischargeStatus_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Encounter_DischargeStatus_Title) ;
               }
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
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Information_ID_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Information_ID_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Information_ID_Title) ;
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
               GridColumn.AddObjectProperty("Value", context.convertURL( AV44Select));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavSelect_Tooltiptext));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A19BR_EncounterID), 18, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_EncounterID_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_EncounterID_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A35BR_Encounter_EncID), 10, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Encounter_EncID_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Encounter_EncID_Titleformat), 4, 0, ".", "")));
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
               GridColumn.AddObjectProperty("Value", A92BR_Encounter_AdmitSource);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Encounter_AdmitSource_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Encounter_AdmitSource_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.localUtil.Format(A93BR_Encounter_DischargeDate, "9999/99/99"));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Encounter_DischargeDate_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Encounter_DischargeDate_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A94BR_Encounter_DischargeStatus);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Encounter_DischargeStatus_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Encounter_DischargeStatus_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A172BR_Encounter_Status), 4, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( cmbBR_Encounter_Status.Title.Text));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(cmbBR_Encounter_Status_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A85BR_Information_ID), 18, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Information_ID_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Information_ID_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A36BR_Information_PatientNo);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Information_PatientNo_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Information_PatientNo_Titleformat), 4, 0, ".", "")));
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
            ucGridpaginationbar.SetProperty("CurrentPage", AV41GridCurrentPage);
            ucGridpaginationbar.SetProperty("RecordCount", AV43GridRecordCount);
            ucGridpaginationbar.SetProperty("Page", AV42GridPageSize);
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
            ucDdo_br_encounterid.SetProperty("DropDownOptionsTitleSettingsIcons", AV39DDO_TitleSettingsIcons);
            ucDdo_br_encounterid.SetProperty("DropDownOptionsData", AV15BR_EncounterIDTitleFilterData);
            ucDdo_br_encounterid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_encounterid_Internalname, "DDO_BR_ENCOUNTERIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 33,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_encounteridtitlecontrolidtoreplace_Internalname, AV16ddo_BR_EncounterIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,33);\"", 0, edtavDdo_br_encounteridtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_EncounterPrompt.htm");
            /* User Defined Control */
            ucDdo_br_encounter_encid.SetProperty("Caption", Ddo_br_encounter_encid_Caption);
            ucDdo_br_encounter_encid.SetProperty("Tooltip", Ddo_br_encounter_encid_Tooltip);
            ucDdo_br_encounter_encid.SetProperty("Cls", Ddo_br_encounter_encid_Cls);
            ucDdo_br_encounter_encid.SetProperty("DropDownOptionsType", Ddo_br_encounter_encid_Dropdownoptionstype);
            ucDdo_br_encounter_encid.SetProperty("IncludeSortASC", Ddo_br_encounter_encid_Includesortasc);
            ucDdo_br_encounter_encid.SetProperty("IncludeSortDSC", Ddo_br_encounter_encid_Includesortdsc);
            ucDdo_br_encounter_encid.SetProperty("IncludeFilter", Ddo_br_encounter_encid_Includefilter);
            ucDdo_br_encounter_encid.SetProperty("IncludeDataList", Ddo_br_encounter_encid_Includedatalist);
            ucDdo_br_encounter_encid.SetProperty("SortASC", Ddo_br_encounter_encid_Sortasc);
            ucDdo_br_encounter_encid.SetProperty("SortDSC", Ddo_br_encounter_encid_Sortdsc);
            ucDdo_br_encounter_encid.SetProperty("SearchButtonText", Ddo_br_encounter_encid_Searchbuttontext);
            ucDdo_br_encounter_encid.SetProperty("DropDownOptionsTitleSettingsIcons", AV39DDO_TitleSettingsIcons);
            ucDdo_br_encounter_encid.SetProperty("DropDownOptionsData", AV17BR_Encounter_EncIDTitleFilterData);
            ucDdo_br_encounter_encid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_encounter_encid_Internalname, "DDO_BR_ENCOUNTER_ENCIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 35,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_encounter_encidtitlecontrolidtoreplace_Internalname, AV18ddo_BR_Encounter_EncIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,35);\"", 0, edtavDdo_br_encounter_encidtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_EncounterPrompt.htm");
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
            ucDdo_br_encounter_department.SetProperty("DropDownOptionsTitleSettingsIcons", AV39DDO_TitleSettingsIcons);
            ucDdo_br_encounter_department.SetProperty("DropDownOptionsData", AV19BR_Encounter_DepartmentTitleFilterData);
            ucDdo_br_encounter_department.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_encounter_department_Internalname, "DDO_BR_ENCOUNTER_DEPARTMENTContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 37,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_encounter_departmenttitlecontrolidtoreplace_Internalname, AV20ddo_BR_Encounter_DepartmentTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,37);\"", 0, edtavDdo_br_encounter_departmenttitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_EncounterPrompt.htm");
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
            ucDdo_br_encounter_enctype.SetProperty("DropDownOptionsTitleSettingsIcons", AV39DDO_TitleSettingsIcons);
            ucDdo_br_encounter_enctype.SetProperty("DropDownOptionsData", AV21BR_Encounter_ENCTypeTitleFilterData);
            ucDdo_br_encounter_enctype.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_encounter_enctype_Internalname, "DDO_BR_ENCOUNTER_ENCTYPEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_encounter_enctypetitlecontrolidtoreplace_Internalname, AV22ddo_BR_Encounter_ENCTypeTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,39);\"", 0, edtavDdo_br_encounter_enctypetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_EncounterPrompt.htm");
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
            ucDdo_br_encounter_admitdate.SetProperty("DropDownOptionsTitleSettingsIcons", AV39DDO_TitleSettingsIcons);
            ucDdo_br_encounter_admitdate.SetProperty("DropDownOptionsData", AV23BR_Encounter_AdmitDateTitleFilterData);
            ucDdo_br_encounter_admitdate.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_encounter_admitdate_Internalname, "DDO_BR_ENCOUNTER_ADMITDATEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 41,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_encounter_admitdatetitlecontrolidtoreplace_Internalname, AV24ddo_BR_Encounter_AdmitDateTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,41);\"", 0, edtavDdo_br_encounter_admitdatetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_EncounterPrompt.htm");
            /* User Defined Control */
            ucDdo_br_encounter_admitsource.SetProperty("Caption", Ddo_br_encounter_admitsource_Caption);
            ucDdo_br_encounter_admitsource.SetProperty("Tooltip", Ddo_br_encounter_admitsource_Tooltip);
            ucDdo_br_encounter_admitsource.SetProperty("Cls", Ddo_br_encounter_admitsource_Cls);
            ucDdo_br_encounter_admitsource.SetProperty("DropDownOptionsType", Ddo_br_encounter_admitsource_Dropdownoptionstype);
            ucDdo_br_encounter_admitsource.SetProperty("IncludeSortASC", Ddo_br_encounter_admitsource_Includesortasc);
            ucDdo_br_encounter_admitsource.SetProperty("IncludeSortDSC", Ddo_br_encounter_admitsource_Includesortdsc);
            ucDdo_br_encounter_admitsource.SetProperty("IncludeFilter", Ddo_br_encounter_admitsource_Includefilter);
            ucDdo_br_encounter_admitsource.SetProperty("IncludeDataList", Ddo_br_encounter_admitsource_Includedatalist);
            ucDdo_br_encounter_admitsource.SetProperty("SortASC", Ddo_br_encounter_admitsource_Sortasc);
            ucDdo_br_encounter_admitsource.SetProperty("SortDSC", Ddo_br_encounter_admitsource_Sortdsc);
            ucDdo_br_encounter_admitsource.SetProperty("SearchButtonText", Ddo_br_encounter_admitsource_Searchbuttontext);
            ucDdo_br_encounter_admitsource.SetProperty("DropDownOptionsTitleSettingsIcons", AV39DDO_TitleSettingsIcons);
            ucDdo_br_encounter_admitsource.SetProperty("DropDownOptionsData", AV25BR_Encounter_AdmitSourceTitleFilterData);
            ucDdo_br_encounter_admitsource.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_encounter_admitsource_Internalname, "DDO_BR_ENCOUNTER_ADMITSOURCEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_encounter_admitsourcetitlecontrolidtoreplace_Internalname, AV26ddo_BR_Encounter_AdmitSourceTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,43);\"", 0, edtavDdo_br_encounter_admitsourcetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_EncounterPrompt.htm");
            /* User Defined Control */
            ucDdo_br_encounter_dischargedate.SetProperty("Caption", Ddo_br_encounter_dischargedate_Caption);
            ucDdo_br_encounter_dischargedate.SetProperty("Tooltip", Ddo_br_encounter_dischargedate_Tooltip);
            ucDdo_br_encounter_dischargedate.SetProperty("Cls", Ddo_br_encounter_dischargedate_Cls);
            ucDdo_br_encounter_dischargedate.SetProperty("DropDownOptionsType", Ddo_br_encounter_dischargedate_Dropdownoptionstype);
            ucDdo_br_encounter_dischargedate.SetProperty("IncludeSortASC", Ddo_br_encounter_dischargedate_Includesortasc);
            ucDdo_br_encounter_dischargedate.SetProperty("IncludeSortDSC", Ddo_br_encounter_dischargedate_Includesortdsc);
            ucDdo_br_encounter_dischargedate.SetProperty("IncludeFilter", Ddo_br_encounter_dischargedate_Includefilter);
            ucDdo_br_encounter_dischargedate.SetProperty("IncludeDataList", Ddo_br_encounter_dischargedate_Includedatalist);
            ucDdo_br_encounter_dischargedate.SetProperty("SortASC", Ddo_br_encounter_dischargedate_Sortasc);
            ucDdo_br_encounter_dischargedate.SetProperty("SortDSC", Ddo_br_encounter_dischargedate_Sortdsc);
            ucDdo_br_encounter_dischargedate.SetProperty("SearchButtonText", Ddo_br_encounter_dischargedate_Searchbuttontext);
            ucDdo_br_encounter_dischargedate.SetProperty("DropDownOptionsTitleSettingsIcons", AV39DDO_TitleSettingsIcons);
            ucDdo_br_encounter_dischargedate.SetProperty("DropDownOptionsData", AV27BR_Encounter_DischargeDateTitleFilterData);
            ucDdo_br_encounter_dischargedate.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_encounter_dischargedate_Internalname, "DDO_BR_ENCOUNTER_DISCHARGEDATEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 45,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_encounter_dischargedatetitlecontrolidtoreplace_Internalname, AV28ddo_BR_Encounter_DischargeDateTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,45);\"", 0, edtavDdo_br_encounter_dischargedatetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_EncounterPrompt.htm");
            /* User Defined Control */
            ucDdo_br_encounter_dischargestatus.SetProperty("Caption", Ddo_br_encounter_dischargestatus_Caption);
            ucDdo_br_encounter_dischargestatus.SetProperty("Tooltip", Ddo_br_encounter_dischargestatus_Tooltip);
            ucDdo_br_encounter_dischargestatus.SetProperty("Cls", Ddo_br_encounter_dischargestatus_Cls);
            ucDdo_br_encounter_dischargestatus.SetProperty("DropDownOptionsType", Ddo_br_encounter_dischargestatus_Dropdownoptionstype);
            ucDdo_br_encounter_dischargestatus.SetProperty("IncludeSortASC", Ddo_br_encounter_dischargestatus_Includesortasc);
            ucDdo_br_encounter_dischargestatus.SetProperty("IncludeSortDSC", Ddo_br_encounter_dischargestatus_Includesortdsc);
            ucDdo_br_encounter_dischargestatus.SetProperty("IncludeFilter", Ddo_br_encounter_dischargestatus_Includefilter);
            ucDdo_br_encounter_dischargestatus.SetProperty("IncludeDataList", Ddo_br_encounter_dischargestatus_Includedatalist);
            ucDdo_br_encounter_dischargestatus.SetProperty("SortASC", Ddo_br_encounter_dischargestatus_Sortasc);
            ucDdo_br_encounter_dischargestatus.SetProperty("SortDSC", Ddo_br_encounter_dischargestatus_Sortdsc);
            ucDdo_br_encounter_dischargestatus.SetProperty("SearchButtonText", Ddo_br_encounter_dischargestatus_Searchbuttontext);
            ucDdo_br_encounter_dischargestatus.SetProperty("DropDownOptionsTitleSettingsIcons", AV39DDO_TitleSettingsIcons);
            ucDdo_br_encounter_dischargestatus.SetProperty("DropDownOptionsData", AV29BR_Encounter_DischargeStatusTitleFilterData);
            ucDdo_br_encounter_dischargestatus.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_encounter_dischargestatus_Internalname, "DDO_BR_ENCOUNTER_DISCHARGESTATUSContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 47,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_encounter_dischargestatustitlecontrolidtoreplace_Internalname, AV30ddo_BR_Encounter_DischargeStatusTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,47);\"", 0, edtavDdo_br_encounter_dischargestatustitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_EncounterPrompt.htm");
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
            ucDdo_br_encounter_status.SetProperty("DropDownOptionsTitleSettingsIcons", AV39DDO_TitleSettingsIcons);
            ucDdo_br_encounter_status.SetProperty("DropDownOptionsData", AV49BR_Encounter_StatusTitleFilterData);
            ucDdo_br_encounter_status.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_encounter_status_Internalname, "DDO_BR_ENCOUNTER_STATUSContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 49,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_encounter_statustitlecontrolidtoreplace_Internalname, AV50ddo_BR_Encounter_StatusTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,49);\"", 0, edtavDdo_br_encounter_statustitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_EncounterPrompt.htm");
            /* User Defined Control */
            ucDdo_br_information_id.SetProperty("Caption", Ddo_br_information_id_Caption);
            ucDdo_br_information_id.SetProperty("Tooltip", Ddo_br_information_id_Tooltip);
            ucDdo_br_information_id.SetProperty("Cls", Ddo_br_information_id_Cls);
            ucDdo_br_information_id.SetProperty("DropDownOptionsType", Ddo_br_information_id_Dropdownoptionstype);
            ucDdo_br_information_id.SetProperty("IncludeSortASC", Ddo_br_information_id_Includesortasc);
            ucDdo_br_information_id.SetProperty("IncludeSortDSC", Ddo_br_information_id_Includesortdsc);
            ucDdo_br_information_id.SetProperty("IncludeFilter", Ddo_br_information_id_Includefilter);
            ucDdo_br_information_id.SetProperty("IncludeDataList", Ddo_br_information_id_Includedatalist);
            ucDdo_br_information_id.SetProperty("SortASC", Ddo_br_information_id_Sortasc);
            ucDdo_br_information_id.SetProperty("SortDSC", Ddo_br_information_id_Sortdsc);
            ucDdo_br_information_id.SetProperty("SearchButtonText", Ddo_br_information_id_Searchbuttontext);
            ucDdo_br_information_id.SetProperty("DropDownOptionsTitleSettingsIcons", AV39DDO_TitleSettingsIcons);
            ucDdo_br_information_id.SetProperty("DropDownOptionsData", AV31BR_Information_IDTitleFilterData);
            ucDdo_br_information_id.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_information_id_Internalname, "DDO_BR_INFORMATION_IDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 51,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_information_idtitlecontrolidtoreplace_Internalname, AV32ddo_BR_Information_IDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,51);\"", 0, edtavDdo_br_information_idtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_EncounterPrompt.htm");
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
            ucDdo_br_information_patientno.SetProperty("DropDownOptionsTitleSettingsIcons", AV39DDO_TitleSettingsIcons);
            ucDdo_br_information_patientno.SetProperty("DropDownOptionsData", AV33BR_Information_PatientNoTitleFilterData);
            ucDdo_br_information_patientno.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_information_patientno_Internalname, "DDO_BR_INFORMATION_PATIENTNOContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_information_patientnotitlecontrolidtoreplace_Internalname, AV34ddo_BR_Information_PatientNoTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,53);\"", 0, edtavDdo_br_information_patientnotitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_EncounterPrompt.htm");
            /* User Defined Control */
            ucWorkwithplusutilities1.Render(context, "dvelop.workwithplusutilities", Workwithplusutilities1_Internalname, "WORKWITHPLUSUTILITIES1Container");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 55,'',false,'" + sGXsfl_12_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrderedby_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11OrderedBy), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV11OrderedBy), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,55);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrderedby_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrderedby_Visible, 1, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_EncounterPrompt.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 56,'',false,'" + sGXsfl_12_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrdereddsc_Internalname, StringUtil.BoolToStr( AV12OrderedDsc), StringUtil.BoolToStr( AV12OrderedDsc), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,56);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrdereddsc_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrdereddsc_Visible, 1, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, 0, 0, true, "", "right", false, "HLP_BR_EncounterPrompt.htm");
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

      protected void START152( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_0-127771", 0) ;
            Form.Meta.addItem("description", "选择就诊信息", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP150( ) ;
      }

      protected void WS152( )
      {
         START152( ) ;
         EVT152( ) ;
      }

      protected void EVT152( )
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
                           E11152 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEROWSPERPAGE") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E12152 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_ENCOUNTERID.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E13152 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_ENCOUNTER_ENCID.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E14152 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_ENCOUNTER_DEPARTMENT.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E15152 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_ENCOUNTER_ENCTYPE.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E16152 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_ENCOUNTER_ADMITDATE.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E17152 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_ENCOUNTER_ADMITSOURCE.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E18152 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_ENCOUNTER_DISCHARGEDATE.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E19152 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_ENCOUNTER_DISCHARGESTATUS.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E20152 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_ENCOUNTER_STATUS.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E21152 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_INFORMATION_ID.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E22152 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_INFORMATION_PATIENTNO.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E23152 ();
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
                           AV44Select = cgiGet( edtavSelect_Internalname);
                           context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSelect_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV44Select)) ? AV78Select_GXI : context.convertURL( context.PathToRelativeUrl( AV44Select))), !bGXsfl_12_Refreshing);
                           context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSelect_Internalname, "SrcSet", context.GetImageSrcSet( AV44Select), true);
                           A19BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( edtBR_EncounterID_Internalname), ".", ","));
                           A35BR_Encounter_EncID = (long)(context.localUtil.CToN( cgiGet( edtBR_Encounter_EncID_Internalname), ".", ","));
                           n35BR_Encounter_EncID = false;
                           A84BR_Encounter_Department = cgiGet( edtBR_Encounter_Department_Internalname);
                           n84BR_Encounter_Department = false;
                           A90BR_Encounter_ENCType = cgiGet( edtBR_Encounter_ENCType_Internalname);
                           n90BR_Encounter_ENCType = false;
                           A91BR_Encounter_AdmitDate = DateTimeUtil.ResetTime(context.localUtil.CToT( cgiGet( edtBR_Encounter_AdmitDate_Internalname), 0));
                           n91BR_Encounter_AdmitDate = false;
                           A92BR_Encounter_AdmitSource = cgiGet( edtBR_Encounter_AdmitSource_Internalname);
                           n92BR_Encounter_AdmitSource = false;
                           A93BR_Encounter_DischargeDate = DateTimeUtil.ResetTime(context.localUtil.CToT( cgiGet( edtBR_Encounter_DischargeDate_Internalname), 0));
                           n93BR_Encounter_DischargeDate = false;
                           A94BR_Encounter_DischargeStatus = cgiGet( edtBR_Encounter_DischargeStatus_Internalname);
                           n94BR_Encounter_DischargeStatus = false;
                           cmbBR_Encounter_Status.Name = cmbBR_Encounter_Status_Internalname;
                           cmbBR_Encounter_Status.CurrentValue = cgiGet( cmbBR_Encounter_Status_Internalname);
                           A172BR_Encounter_Status = (short)(NumberUtil.Val( cgiGet( cmbBR_Encounter_Status_Internalname), "."));
                           n172BR_Encounter_Status = false;
                           A85BR_Information_ID = (long)(context.localUtil.CToN( cgiGet( edtBR_Information_ID_Internalname), ".", ","));
                           n85BR_Information_ID = false;
                           A36BR_Information_PatientNo = cgiGet( edtBR_Information_PatientNo_Internalname);
                           n36BR_Information_PatientNo = false;
                           sEvtType = StringUtil.Right( sEvt, 1);
                           if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                           {
                              sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                              if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 /* Execute user event: Start */
                                 E24152 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 /* Execute user event: Refresh */
                                 E25152 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "GRID.LOAD") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 E26152 ();
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
                                       E27152 ();
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

      protected void WE152( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm152( ) ;
            }
         }
      }

      protected void PA152( )
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
               GX_FocusControl = edtavDdo_br_encounteridtitlecontrolidtoreplace_Internalname;
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
                                       String AV16ddo_BR_EncounterIDTitleControlIdToReplace ,
                                       String AV18ddo_BR_Encounter_EncIDTitleControlIdToReplace ,
                                       String AV20ddo_BR_Encounter_DepartmentTitleControlIdToReplace ,
                                       String AV22ddo_BR_Encounter_ENCTypeTitleControlIdToReplace ,
                                       String AV24ddo_BR_Encounter_AdmitDateTitleControlIdToReplace ,
                                       String AV26ddo_BR_Encounter_AdmitSourceTitleControlIdToReplace ,
                                       String AV28ddo_BR_Encounter_DischargeDateTitleControlIdToReplace ,
                                       String AV30ddo_BR_Encounter_DischargeStatusTitleControlIdToReplace ,
                                       String AV50ddo_BR_Encounter_StatusTitleControlIdToReplace ,
                                       String AV32ddo_BR_Information_IDTitleControlIdToReplace ,
                                       String AV34ddo_BR_Information_PatientNoTitleControlIdToReplace )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GRID_nCurrentRecord = 0;
         RF152( ) ;
         /* End function gxgrGrid_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_BR_ENCOUNTERID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A19BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, "BR_ENCOUNTERID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A19BR_EncounterID), 18, 0, ".", "")));
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
         RF152( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV77Pgmname = "BR_EncounterPrompt";
         context.Gx_err = 0;
      }

      protected void RF152( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridContainer.ClearRows();
         }
         wbStart = 12;
         /* Execute user event: Refresh */
         E25152 ();
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
            /* Using cursor H00152 */
            pr_default.execute(0, new Object[] {GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_12_idx = 1;
            sGXsfl_12_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_12_idx), 4, 0)), 4, "0");
            SubsflControlProps_122( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < subGrid_Recordsperpage( ) ) ) ) )
            {
               A36BR_Information_PatientNo = H00152_A36BR_Information_PatientNo[0];
               n36BR_Information_PatientNo = H00152_n36BR_Information_PatientNo[0];
               A85BR_Information_ID = H00152_A85BR_Information_ID[0];
               n85BR_Information_ID = H00152_n85BR_Information_ID[0];
               A172BR_Encounter_Status = H00152_A172BR_Encounter_Status[0];
               n172BR_Encounter_Status = H00152_n172BR_Encounter_Status[0];
               A94BR_Encounter_DischargeStatus = H00152_A94BR_Encounter_DischargeStatus[0];
               n94BR_Encounter_DischargeStatus = H00152_n94BR_Encounter_DischargeStatus[0];
               A93BR_Encounter_DischargeDate = H00152_A93BR_Encounter_DischargeDate[0];
               n93BR_Encounter_DischargeDate = H00152_n93BR_Encounter_DischargeDate[0];
               A92BR_Encounter_AdmitSource = H00152_A92BR_Encounter_AdmitSource[0];
               n92BR_Encounter_AdmitSource = H00152_n92BR_Encounter_AdmitSource[0];
               A91BR_Encounter_AdmitDate = H00152_A91BR_Encounter_AdmitDate[0];
               n91BR_Encounter_AdmitDate = H00152_n91BR_Encounter_AdmitDate[0];
               A90BR_Encounter_ENCType = H00152_A90BR_Encounter_ENCType[0];
               n90BR_Encounter_ENCType = H00152_n90BR_Encounter_ENCType[0];
               A84BR_Encounter_Department = H00152_A84BR_Encounter_Department[0];
               n84BR_Encounter_Department = H00152_n84BR_Encounter_Department[0];
               A35BR_Encounter_EncID = H00152_A35BR_Encounter_EncID[0];
               n35BR_Encounter_EncID = H00152_n35BR_Encounter_EncID[0];
               A19BR_EncounterID = H00152_A19BR_EncounterID[0];
               A36BR_Information_PatientNo = H00152_A36BR_Information_PatientNo[0];
               n36BR_Information_PatientNo = H00152_n36BR_Information_PatientNo[0];
               E26152 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 12;
            WB150( ) ;
         }
         bGXsfl_12_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes152( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_BR_ENCOUNTERID"+"_"+sGXsfl_12_idx, GetSecureSignedToken( sGXsfl_12_idx, context.localUtil.Format( (decimal)(A19BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ"), context));
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
         /* Using cursor H00153 */
         pr_default.execute(1);
         GRID_nRecordCount = H00153_AGRID_nRecordCount[0];
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
            gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV16ddo_BR_EncounterIDTitleControlIdToReplace, AV18ddo_BR_Encounter_EncIDTitleControlIdToReplace, AV20ddo_BR_Encounter_DepartmentTitleControlIdToReplace, AV22ddo_BR_Encounter_ENCTypeTitleControlIdToReplace, AV24ddo_BR_Encounter_AdmitDateTitleControlIdToReplace, AV26ddo_BR_Encounter_AdmitSourceTitleControlIdToReplace, AV28ddo_BR_Encounter_DischargeDateTitleControlIdToReplace, AV30ddo_BR_Encounter_DischargeStatusTitleControlIdToReplace, AV50ddo_BR_Encounter_StatusTitleControlIdToReplace, AV32ddo_BR_Information_IDTitleControlIdToReplace, AV34ddo_BR_Information_PatientNoTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV16ddo_BR_EncounterIDTitleControlIdToReplace, AV18ddo_BR_Encounter_EncIDTitleControlIdToReplace, AV20ddo_BR_Encounter_DepartmentTitleControlIdToReplace, AV22ddo_BR_Encounter_ENCTypeTitleControlIdToReplace, AV24ddo_BR_Encounter_AdmitDateTitleControlIdToReplace, AV26ddo_BR_Encounter_AdmitSourceTitleControlIdToReplace, AV28ddo_BR_Encounter_DischargeDateTitleControlIdToReplace, AV30ddo_BR_Encounter_DischargeStatusTitleControlIdToReplace, AV50ddo_BR_Encounter_StatusTitleControlIdToReplace, AV32ddo_BR_Information_IDTitleControlIdToReplace, AV34ddo_BR_Information_PatientNoTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV16ddo_BR_EncounterIDTitleControlIdToReplace, AV18ddo_BR_Encounter_EncIDTitleControlIdToReplace, AV20ddo_BR_Encounter_DepartmentTitleControlIdToReplace, AV22ddo_BR_Encounter_ENCTypeTitleControlIdToReplace, AV24ddo_BR_Encounter_AdmitDateTitleControlIdToReplace, AV26ddo_BR_Encounter_AdmitSourceTitleControlIdToReplace, AV28ddo_BR_Encounter_DischargeDateTitleControlIdToReplace, AV30ddo_BR_Encounter_DischargeStatusTitleControlIdToReplace, AV50ddo_BR_Encounter_StatusTitleControlIdToReplace, AV32ddo_BR_Information_IDTitleControlIdToReplace, AV34ddo_BR_Information_PatientNoTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV16ddo_BR_EncounterIDTitleControlIdToReplace, AV18ddo_BR_Encounter_EncIDTitleControlIdToReplace, AV20ddo_BR_Encounter_DepartmentTitleControlIdToReplace, AV22ddo_BR_Encounter_ENCTypeTitleControlIdToReplace, AV24ddo_BR_Encounter_AdmitDateTitleControlIdToReplace, AV26ddo_BR_Encounter_AdmitSourceTitleControlIdToReplace, AV28ddo_BR_Encounter_DischargeDateTitleControlIdToReplace, AV30ddo_BR_Encounter_DischargeStatusTitleControlIdToReplace, AV50ddo_BR_Encounter_StatusTitleControlIdToReplace, AV32ddo_BR_Information_IDTitleControlIdToReplace, AV34ddo_BR_Information_PatientNoTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV16ddo_BR_EncounterIDTitleControlIdToReplace, AV18ddo_BR_Encounter_EncIDTitleControlIdToReplace, AV20ddo_BR_Encounter_DepartmentTitleControlIdToReplace, AV22ddo_BR_Encounter_ENCTypeTitleControlIdToReplace, AV24ddo_BR_Encounter_AdmitDateTitleControlIdToReplace, AV26ddo_BR_Encounter_AdmitSourceTitleControlIdToReplace, AV28ddo_BR_Encounter_DischargeDateTitleControlIdToReplace, AV30ddo_BR_Encounter_DischargeStatusTitleControlIdToReplace, AV50ddo_BR_Encounter_StatusTitleControlIdToReplace, AV32ddo_BR_Information_IDTitleControlIdToReplace, AV34ddo_BR_Information_PatientNoTitleControlIdToReplace) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP150( )
      {
         /* Before Start, stand alone formulas. */
         AV77Pgmname = "BR_EncounterPrompt";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E24152 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( "vDDO_TITLESETTINGSICONS"), AV39DDO_TitleSettingsIcons);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_ENCOUNTERIDTITLEFILTERDATA"), AV15BR_EncounterIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_ENCOUNTER_ENCIDTITLEFILTERDATA"), AV17BR_Encounter_EncIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_ENCOUNTER_DEPARTMENTTITLEFILTERDATA"), AV19BR_Encounter_DepartmentTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_ENCOUNTER_ENCTYPETITLEFILTERDATA"), AV21BR_Encounter_ENCTypeTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_ENCOUNTER_ADMITDATETITLEFILTERDATA"), AV23BR_Encounter_AdmitDateTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_ENCOUNTER_ADMITSOURCETITLEFILTERDATA"), AV25BR_Encounter_AdmitSourceTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_ENCOUNTER_DISCHARGEDATETITLEFILTERDATA"), AV27BR_Encounter_DischargeDateTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_ENCOUNTER_DISCHARGESTATUSTITLEFILTERDATA"), AV29BR_Encounter_DischargeStatusTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_ENCOUNTER_STATUSTITLEFILTERDATA"), AV49BR_Encounter_StatusTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_INFORMATION_IDTITLEFILTERDATA"), AV31BR_Information_IDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_INFORMATION_PATIENTNOTITLEFILTERDATA"), AV33BR_Information_PatientNoTitleFilterData);
            /* Read variables values. */
            AV16ddo_BR_EncounterIDTitleControlIdToReplace = cgiGet( edtavDdo_br_encounteridtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16ddo_BR_EncounterIDTitleControlIdToReplace", AV16ddo_BR_EncounterIDTitleControlIdToReplace);
            AV18ddo_BR_Encounter_EncIDTitleControlIdToReplace = cgiGet( edtavDdo_br_encounter_encidtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18ddo_BR_Encounter_EncIDTitleControlIdToReplace", AV18ddo_BR_Encounter_EncIDTitleControlIdToReplace);
            AV20ddo_BR_Encounter_DepartmentTitleControlIdToReplace = cgiGet( edtavDdo_br_encounter_departmenttitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20ddo_BR_Encounter_DepartmentTitleControlIdToReplace", AV20ddo_BR_Encounter_DepartmentTitleControlIdToReplace);
            AV22ddo_BR_Encounter_ENCTypeTitleControlIdToReplace = cgiGet( edtavDdo_br_encounter_enctypetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22ddo_BR_Encounter_ENCTypeTitleControlIdToReplace", AV22ddo_BR_Encounter_ENCTypeTitleControlIdToReplace);
            AV24ddo_BR_Encounter_AdmitDateTitleControlIdToReplace = cgiGet( edtavDdo_br_encounter_admitdatetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24ddo_BR_Encounter_AdmitDateTitleControlIdToReplace", AV24ddo_BR_Encounter_AdmitDateTitleControlIdToReplace);
            AV26ddo_BR_Encounter_AdmitSourceTitleControlIdToReplace = cgiGet( edtavDdo_br_encounter_admitsourcetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26ddo_BR_Encounter_AdmitSourceTitleControlIdToReplace", AV26ddo_BR_Encounter_AdmitSourceTitleControlIdToReplace);
            AV28ddo_BR_Encounter_DischargeDateTitleControlIdToReplace = cgiGet( edtavDdo_br_encounter_dischargedatetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV28ddo_BR_Encounter_DischargeDateTitleControlIdToReplace", AV28ddo_BR_Encounter_DischargeDateTitleControlIdToReplace);
            AV30ddo_BR_Encounter_DischargeStatusTitleControlIdToReplace = cgiGet( edtavDdo_br_encounter_dischargestatustitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30ddo_BR_Encounter_DischargeStatusTitleControlIdToReplace", AV30ddo_BR_Encounter_DischargeStatusTitleControlIdToReplace);
            AV50ddo_BR_Encounter_StatusTitleControlIdToReplace = cgiGet( edtavDdo_br_encounter_statustitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV50ddo_BR_Encounter_StatusTitleControlIdToReplace", AV50ddo_BR_Encounter_StatusTitleControlIdToReplace);
            AV32ddo_BR_Information_IDTitleControlIdToReplace = cgiGet( edtavDdo_br_information_idtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV32ddo_BR_Information_IDTitleControlIdToReplace", AV32ddo_BR_Information_IDTitleControlIdToReplace);
            AV34ddo_BR_Information_PatientNoTitleControlIdToReplace = cgiGet( edtavDdo_br_information_patientnotitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34ddo_BR_Information_PatientNoTitleControlIdToReplace", AV34ddo_BR_Information_PatientNoTitleControlIdToReplace);
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
            AV41GridCurrentPage = (long)(context.localUtil.CToN( cgiGet( "vGRIDCURRENTPAGE"), ".", ","));
            AV43GridRecordCount = (long)(context.localUtil.CToN( cgiGet( "vGRIDRECORDCOUNT"), ".", ","));
            AV42GridPageSize = (long)(context.localUtil.CToN( cgiGet( "vGRIDPAGESIZE"), ".", ","));
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
            Ddo_br_encounter_encid_Caption = cgiGet( "DDO_BR_ENCOUNTER_ENCID_Caption");
            Ddo_br_encounter_encid_Tooltip = cgiGet( "DDO_BR_ENCOUNTER_ENCID_Tooltip");
            Ddo_br_encounter_encid_Cls = cgiGet( "DDO_BR_ENCOUNTER_ENCID_Cls");
            Ddo_br_encounter_encid_Dropdownoptionstype = cgiGet( "DDO_BR_ENCOUNTER_ENCID_Dropdownoptionstype");
            Ddo_br_encounter_encid_Titlecontrolidtoreplace = cgiGet( "DDO_BR_ENCOUNTER_ENCID_Titlecontrolidtoreplace");
            Ddo_br_encounter_encid_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_ENCID_Includesortasc"));
            Ddo_br_encounter_encid_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_ENCID_Includesortdsc"));
            Ddo_br_encounter_encid_Sortedstatus = cgiGet( "DDO_BR_ENCOUNTER_ENCID_Sortedstatus");
            Ddo_br_encounter_encid_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_ENCID_Includefilter"));
            Ddo_br_encounter_encid_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_ENCID_Includedatalist"));
            Ddo_br_encounter_encid_Sortasc = cgiGet( "DDO_BR_ENCOUNTER_ENCID_Sortasc");
            Ddo_br_encounter_encid_Sortdsc = cgiGet( "DDO_BR_ENCOUNTER_ENCID_Sortdsc");
            Ddo_br_encounter_encid_Searchbuttontext = cgiGet( "DDO_BR_ENCOUNTER_ENCID_Searchbuttontext");
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
            Ddo_br_encounter_admitsource_Caption = cgiGet( "DDO_BR_ENCOUNTER_ADMITSOURCE_Caption");
            Ddo_br_encounter_admitsource_Tooltip = cgiGet( "DDO_BR_ENCOUNTER_ADMITSOURCE_Tooltip");
            Ddo_br_encounter_admitsource_Cls = cgiGet( "DDO_BR_ENCOUNTER_ADMITSOURCE_Cls");
            Ddo_br_encounter_admitsource_Dropdownoptionstype = cgiGet( "DDO_BR_ENCOUNTER_ADMITSOURCE_Dropdownoptionstype");
            Ddo_br_encounter_admitsource_Titlecontrolidtoreplace = cgiGet( "DDO_BR_ENCOUNTER_ADMITSOURCE_Titlecontrolidtoreplace");
            Ddo_br_encounter_admitsource_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_ADMITSOURCE_Includesortasc"));
            Ddo_br_encounter_admitsource_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_ADMITSOURCE_Includesortdsc"));
            Ddo_br_encounter_admitsource_Sortedstatus = cgiGet( "DDO_BR_ENCOUNTER_ADMITSOURCE_Sortedstatus");
            Ddo_br_encounter_admitsource_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_ADMITSOURCE_Includefilter"));
            Ddo_br_encounter_admitsource_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_ADMITSOURCE_Includedatalist"));
            Ddo_br_encounter_admitsource_Sortasc = cgiGet( "DDO_BR_ENCOUNTER_ADMITSOURCE_Sortasc");
            Ddo_br_encounter_admitsource_Sortdsc = cgiGet( "DDO_BR_ENCOUNTER_ADMITSOURCE_Sortdsc");
            Ddo_br_encounter_admitsource_Searchbuttontext = cgiGet( "DDO_BR_ENCOUNTER_ADMITSOURCE_Searchbuttontext");
            Ddo_br_encounter_dischargedate_Caption = cgiGet( "DDO_BR_ENCOUNTER_DISCHARGEDATE_Caption");
            Ddo_br_encounter_dischargedate_Tooltip = cgiGet( "DDO_BR_ENCOUNTER_DISCHARGEDATE_Tooltip");
            Ddo_br_encounter_dischargedate_Cls = cgiGet( "DDO_BR_ENCOUNTER_DISCHARGEDATE_Cls");
            Ddo_br_encounter_dischargedate_Dropdownoptionstype = cgiGet( "DDO_BR_ENCOUNTER_DISCHARGEDATE_Dropdownoptionstype");
            Ddo_br_encounter_dischargedate_Titlecontrolidtoreplace = cgiGet( "DDO_BR_ENCOUNTER_DISCHARGEDATE_Titlecontrolidtoreplace");
            Ddo_br_encounter_dischargedate_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_DISCHARGEDATE_Includesortasc"));
            Ddo_br_encounter_dischargedate_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_DISCHARGEDATE_Includesortdsc"));
            Ddo_br_encounter_dischargedate_Sortedstatus = cgiGet( "DDO_BR_ENCOUNTER_DISCHARGEDATE_Sortedstatus");
            Ddo_br_encounter_dischargedate_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_DISCHARGEDATE_Includefilter"));
            Ddo_br_encounter_dischargedate_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_DISCHARGEDATE_Includedatalist"));
            Ddo_br_encounter_dischargedate_Sortasc = cgiGet( "DDO_BR_ENCOUNTER_DISCHARGEDATE_Sortasc");
            Ddo_br_encounter_dischargedate_Sortdsc = cgiGet( "DDO_BR_ENCOUNTER_DISCHARGEDATE_Sortdsc");
            Ddo_br_encounter_dischargedate_Searchbuttontext = cgiGet( "DDO_BR_ENCOUNTER_DISCHARGEDATE_Searchbuttontext");
            Ddo_br_encounter_dischargestatus_Caption = cgiGet( "DDO_BR_ENCOUNTER_DISCHARGESTATUS_Caption");
            Ddo_br_encounter_dischargestatus_Tooltip = cgiGet( "DDO_BR_ENCOUNTER_DISCHARGESTATUS_Tooltip");
            Ddo_br_encounter_dischargestatus_Cls = cgiGet( "DDO_BR_ENCOUNTER_DISCHARGESTATUS_Cls");
            Ddo_br_encounter_dischargestatus_Dropdownoptionstype = cgiGet( "DDO_BR_ENCOUNTER_DISCHARGESTATUS_Dropdownoptionstype");
            Ddo_br_encounter_dischargestatus_Titlecontrolidtoreplace = cgiGet( "DDO_BR_ENCOUNTER_DISCHARGESTATUS_Titlecontrolidtoreplace");
            Ddo_br_encounter_dischargestatus_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_DISCHARGESTATUS_Includesortasc"));
            Ddo_br_encounter_dischargestatus_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_DISCHARGESTATUS_Includesortdsc"));
            Ddo_br_encounter_dischargestatus_Sortedstatus = cgiGet( "DDO_BR_ENCOUNTER_DISCHARGESTATUS_Sortedstatus");
            Ddo_br_encounter_dischargestatus_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_DISCHARGESTATUS_Includefilter"));
            Ddo_br_encounter_dischargestatus_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_DISCHARGESTATUS_Includedatalist"));
            Ddo_br_encounter_dischargestatus_Sortasc = cgiGet( "DDO_BR_ENCOUNTER_DISCHARGESTATUS_Sortasc");
            Ddo_br_encounter_dischargestatus_Sortdsc = cgiGet( "DDO_BR_ENCOUNTER_DISCHARGESTATUS_Sortdsc");
            Ddo_br_encounter_dischargestatus_Searchbuttontext = cgiGet( "DDO_BR_ENCOUNTER_DISCHARGESTATUS_Searchbuttontext");
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
            Ddo_br_information_id_Caption = cgiGet( "DDO_BR_INFORMATION_ID_Caption");
            Ddo_br_information_id_Tooltip = cgiGet( "DDO_BR_INFORMATION_ID_Tooltip");
            Ddo_br_information_id_Cls = cgiGet( "DDO_BR_INFORMATION_ID_Cls");
            Ddo_br_information_id_Dropdownoptionstype = cgiGet( "DDO_BR_INFORMATION_ID_Dropdownoptionstype");
            Ddo_br_information_id_Titlecontrolidtoreplace = cgiGet( "DDO_BR_INFORMATION_ID_Titlecontrolidtoreplace");
            Ddo_br_information_id_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_INFORMATION_ID_Includesortasc"));
            Ddo_br_information_id_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_INFORMATION_ID_Includesortdsc"));
            Ddo_br_information_id_Sortedstatus = cgiGet( "DDO_BR_INFORMATION_ID_Sortedstatus");
            Ddo_br_information_id_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_INFORMATION_ID_Includefilter"));
            Ddo_br_information_id_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_INFORMATION_ID_Includedatalist"));
            Ddo_br_information_id_Sortasc = cgiGet( "DDO_BR_INFORMATION_ID_Sortasc");
            Ddo_br_information_id_Sortdsc = cgiGet( "DDO_BR_INFORMATION_ID_Sortdsc");
            Ddo_br_information_id_Searchbuttontext = cgiGet( "DDO_BR_INFORMATION_ID_Searchbuttontext");
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
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( "GRID_Rows"), ".", ","));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            Gridpaginationbar_Selectedpage = cgiGet( "GRIDPAGINATIONBAR_Selectedpage");
            Gridpaginationbar_Rowsperpageselectedvalue = (int)(context.localUtil.CToN( cgiGet( "GRIDPAGINATIONBAR_Rowsperpageselectedvalue"), ".", ","));
            Ddo_br_encounterid_Activeeventkey = cgiGet( "DDO_BR_ENCOUNTERID_Activeeventkey");
            Ddo_br_encounter_encid_Activeeventkey = cgiGet( "DDO_BR_ENCOUNTER_ENCID_Activeeventkey");
            Ddo_br_encounter_department_Activeeventkey = cgiGet( "DDO_BR_ENCOUNTER_DEPARTMENT_Activeeventkey");
            Ddo_br_encounter_enctype_Activeeventkey = cgiGet( "DDO_BR_ENCOUNTER_ENCTYPE_Activeeventkey");
            Ddo_br_encounter_admitdate_Activeeventkey = cgiGet( "DDO_BR_ENCOUNTER_ADMITDATE_Activeeventkey");
            Ddo_br_encounter_admitsource_Activeeventkey = cgiGet( "DDO_BR_ENCOUNTER_ADMITSOURCE_Activeeventkey");
            Ddo_br_encounter_dischargedate_Activeeventkey = cgiGet( "DDO_BR_ENCOUNTER_DISCHARGEDATE_Activeeventkey");
            Ddo_br_encounter_dischargestatus_Activeeventkey = cgiGet( "DDO_BR_ENCOUNTER_DISCHARGESTATUS_Activeeventkey");
            Ddo_br_encounter_status_Activeeventkey = cgiGet( "DDO_BR_ENCOUNTER_STATUS_Activeeventkey");
            Ddo_br_information_id_Activeeventkey = cgiGet( "DDO_BR_INFORMATION_ID_Activeeventkey");
            Ddo_br_information_patientno_Activeeventkey = cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Activeeventkey");
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
         E24152 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E24152( )
      {
         /* Start Routine */
         GXt_boolean1 = AV5IsAuthorized;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Check_Encounter", out  GXt_boolean1) ;
         AV5IsAuthorized = GXt_boolean1;
         if ( ! AV5IsAuthorized )
         {
            CallWebObject(formatLink("wwpbaseobjects.notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV77Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         divTablemain_Height = 493;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, divTablemain_Internalname, "Height", StringUtil.LTrim( StringUtil.Str( (decimal)(divTablemain_Height), 9, 0)), true);
         subGrid_Rows = 9;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         Ddo_br_encounterid_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_EncounterID";
         ucDdo_br_encounterid.SendProperty(context, "", false, Ddo_br_encounterid_Internalname, "TitleControlIdToReplace", Ddo_br_encounterid_Titlecontrolidtoreplace);
         AV16ddo_BR_EncounterIDTitleControlIdToReplace = Ddo_br_encounterid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16ddo_BR_EncounterIDTitleControlIdToReplace", AV16ddo_BR_EncounterIDTitleControlIdToReplace);
         edtavDdo_br_encounteridtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_encounteridtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_encounteridtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_encounter_encid_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Encounter_EncID";
         ucDdo_br_encounter_encid.SendProperty(context, "", false, Ddo_br_encounter_encid_Internalname, "TitleControlIdToReplace", Ddo_br_encounter_encid_Titlecontrolidtoreplace);
         AV18ddo_BR_Encounter_EncIDTitleControlIdToReplace = Ddo_br_encounter_encid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18ddo_BR_Encounter_EncIDTitleControlIdToReplace", AV18ddo_BR_Encounter_EncIDTitleControlIdToReplace);
         edtavDdo_br_encounter_encidtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_encounter_encidtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_encounter_encidtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_encounter_department_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Encounter_Department";
         ucDdo_br_encounter_department.SendProperty(context, "", false, Ddo_br_encounter_department_Internalname, "TitleControlIdToReplace", Ddo_br_encounter_department_Titlecontrolidtoreplace);
         AV20ddo_BR_Encounter_DepartmentTitleControlIdToReplace = Ddo_br_encounter_department_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20ddo_BR_Encounter_DepartmentTitleControlIdToReplace", AV20ddo_BR_Encounter_DepartmentTitleControlIdToReplace);
         edtavDdo_br_encounter_departmenttitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_encounter_departmenttitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_encounter_departmenttitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_encounter_enctype_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Encounter_ENCType";
         ucDdo_br_encounter_enctype.SendProperty(context, "", false, Ddo_br_encounter_enctype_Internalname, "TitleControlIdToReplace", Ddo_br_encounter_enctype_Titlecontrolidtoreplace);
         AV22ddo_BR_Encounter_ENCTypeTitleControlIdToReplace = Ddo_br_encounter_enctype_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22ddo_BR_Encounter_ENCTypeTitleControlIdToReplace", AV22ddo_BR_Encounter_ENCTypeTitleControlIdToReplace);
         edtavDdo_br_encounter_enctypetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_encounter_enctypetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_encounter_enctypetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_encounter_admitdate_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Encounter_AdmitDate";
         ucDdo_br_encounter_admitdate.SendProperty(context, "", false, Ddo_br_encounter_admitdate_Internalname, "TitleControlIdToReplace", Ddo_br_encounter_admitdate_Titlecontrolidtoreplace);
         AV24ddo_BR_Encounter_AdmitDateTitleControlIdToReplace = Ddo_br_encounter_admitdate_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24ddo_BR_Encounter_AdmitDateTitleControlIdToReplace", AV24ddo_BR_Encounter_AdmitDateTitleControlIdToReplace);
         edtavDdo_br_encounter_admitdatetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_encounter_admitdatetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_encounter_admitdatetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_encounter_admitsource_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Encounter_AdmitSource";
         ucDdo_br_encounter_admitsource.SendProperty(context, "", false, Ddo_br_encounter_admitsource_Internalname, "TitleControlIdToReplace", Ddo_br_encounter_admitsource_Titlecontrolidtoreplace);
         AV26ddo_BR_Encounter_AdmitSourceTitleControlIdToReplace = Ddo_br_encounter_admitsource_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26ddo_BR_Encounter_AdmitSourceTitleControlIdToReplace", AV26ddo_BR_Encounter_AdmitSourceTitleControlIdToReplace);
         edtavDdo_br_encounter_admitsourcetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_encounter_admitsourcetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_encounter_admitsourcetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_encounter_dischargedate_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Encounter_DischargeDate";
         ucDdo_br_encounter_dischargedate.SendProperty(context, "", false, Ddo_br_encounter_dischargedate_Internalname, "TitleControlIdToReplace", Ddo_br_encounter_dischargedate_Titlecontrolidtoreplace);
         AV28ddo_BR_Encounter_DischargeDateTitleControlIdToReplace = Ddo_br_encounter_dischargedate_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV28ddo_BR_Encounter_DischargeDateTitleControlIdToReplace", AV28ddo_BR_Encounter_DischargeDateTitleControlIdToReplace);
         edtavDdo_br_encounter_dischargedatetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_encounter_dischargedatetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_encounter_dischargedatetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_encounter_dischargestatus_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Encounter_DischargeStatus";
         ucDdo_br_encounter_dischargestatus.SendProperty(context, "", false, Ddo_br_encounter_dischargestatus_Internalname, "TitleControlIdToReplace", Ddo_br_encounter_dischargestatus_Titlecontrolidtoreplace);
         AV30ddo_BR_Encounter_DischargeStatusTitleControlIdToReplace = Ddo_br_encounter_dischargestatus_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30ddo_BR_Encounter_DischargeStatusTitleControlIdToReplace", AV30ddo_BR_Encounter_DischargeStatusTitleControlIdToReplace);
         edtavDdo_br_encounter_dischargestatustitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_encounter_dischargestatustitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_encounter_dischargestatustitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_encounter_status_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Encounter_Status";
         ucDdo_br_encounter_status.SendProperty(context, "", false, Ddo_br_encounter_status_Internalname, "TitleControlIdToReplace", Ddo_br_encounter_status_Titlecontrolidtoreplace);
         AV50ddo_BR_Encounter_StatusTitleControlIdToReplace = Ddo_br_encounter_status_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV50ddo_BR_Encounter_StatusTitleControlIdToReplace", AV50ddo_BR_Encounter_StatusTitleControlIdToReplace);
         edtavDdo_br_encounter_statustitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_encounter_statustitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_encounter_statustitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_information_id_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Information_ID";
         ucDdo_br_information_id.SendProperty(context, "", false, Ddo_br_information_id_Internalname, "TitleControlIdToReplace", Ddo_br_information_id_Titlecontrolidtoreplace);
         AV32ddo_BR_Information_IDTitleControlIdToReplace = Ddo_br_information_id_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV32ddo_BR_Information_IDTitleControlIdToReplace", AV32ddo_BR_Information_IDTitleControlIdToReplace);
         edtavDdo_br_information_idtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_information_idtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_information_idtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_information_patientno_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Information_PatientNo";
         ucDdo_br_information_patientno.SendProperty(context, "", false, Ddo_br_information_patientno_Internalname, "TitleControlIdToReplace", Ddo_br_information_patientno_Titlecontrolidtoreplace);
         AV34ddo_BR_Information_PatientNoTitleControlIdToReplace = Ddo_br_information_patientno_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34ddo_BR_Information_PatientNoTitleControlIdToReplace", AV34ddo_BR_Information_PatientNoTitleControlIdToReplace);
         edtavDdo_br_information_patientnotitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_information_patientnotitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_information_patientnotitlecontrolidtoreplace_Visible), 5, 0)), true);
         Form.Caption = "";
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
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 = AV39DDO_TitleSettingsIcons;
         new GeneXus.Programs.wwpbaseobjects.getwwptitlesettingsicons(context ).execute( out  GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2) ;
         AV39DDO_TitleSettingsIcons = GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2;
         Gridpaginationbar_Rowsperpageselectedvalue = subGrid_Rows;
         ucGridpaginationbar.SendProperty(context, "", false, Gridpaginationbar_Internalname, "RowsPerPageSelectedValue", StringUtil.LTrim( StringUtil.Str( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0)));
      }

      protected void E25152( )
      {
         if ( gx_refresh_fired )
         {
            return  ;
         }
         gx_refresh_fired = true;
         /* Refresh Routine */
         AV15BR_EncounterIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV17BR_Encounter_EncIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV19BR_Encounter_DepartmentTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV21BR_Encounter_ENCTypeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV23BR_Encounter_AdmitDateTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV25BR_Encounter_AdmitSourceTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV27BR_Encounter_DischargeDateTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV29BR_Encounter_DischargeStatusTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV49BR_Encounter_StatusTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV31BR_Information_IDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV33BR_Information_PatientNoTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV6WWPContext) ;
         edtBR_EncounterID_Titleformat = 2;
         edtBR_EncounterID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "就诊信息主键", AV16ddo_BR_EncounterIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_EncounterID_Internalname, "Title", edtBR_EncounterID_Title, !bGXsfl_12_Refreshing);
         edtBR_Encounter_EncID_Titleformat = 2;
         edtBR_Encounter_EncID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "就诊次序", AV18ddo_BR_Encounter_EncIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Encounter_EncID_Internalname, "Title", edtBR_Encounter_EncID_Title, !bGXsfl_12_Refreshing);
         edtBR_Encounter_Department_Titleformat = 2;
         edtBR_Encounter_Department_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "就诊科室", AV20ddo_BR_Encounter_DepartmentTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Encounter_Department_Internalname, "Title", edtBR_Encounter_Department_Title, !bGXsfl_12_Refreshing);
         edtBR_Encounter_ENCType_Titleformat = 2;
         edtBR_Encounter_ENCType_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "就诊方式", AV22ddo_BR_Encounter_ENCTypeTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Encounter_ENCType_Internalname, "Title", edtBR_Encounter_ENCType_Title, !bGXsfl_12_Refreshing);
         edtBR_Encounter_AdmitDate_Titleformat = 2;
         edtBR_Encounter_AdmitDate_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "就诊/入院时间", AV24ddo_BR_Encounter_AdmitDateTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Encounter_AdmitDate_Internalname, "Title", edtBR_Encounter_AdmitDate_Title, !bGXsfl_12_Refreshing);
         edtBR_Encounter_AdmitSource_Titleformat = 2;
         edtBR_Encounter_AdmitSource_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "入院原因", AV26ddo_BR_Encounter_AdmitSourceTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Encounter_AdmitSource_Internalname, "Title", edtBR_Encounter_AdmitSource_Title, !bGXsfl_12_Refreshing);
         edtBR_Encounter_DischargeDate_Titleformat = 2;
         edtBR_Encounter_DischargeDate_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "出院时间", AV28ddo_BR_Encounter_DischargeDateTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Encounter_DischargeDate_Internalname, "Title", edtBR_Encounter_DischargeDate_Title, !bGXsfl_12_Refreshing);
         edtBR_Encounter_DischargeStatus_Titleformat = 2;
         edtBR_Encounter_DischargeStatus_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "出院状态", AV30ddo_BR_Encounter_DischargeStatusTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Encounter_DischargeStatus_Internalname, "Title", edtBR_Encounter_DischargeStatus_Title, !bGXsfl_12_Refreshing);
         cmbBR_Encounter_Status_Titleformat = 2;
         cmbBR_Encounter_Status.Title.Text = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "审批状态", AV50ddo_BR_Encounter_StatusTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Encounter_Status_Internalname, "Title", cmbBR_Encounter_Status.Title.Text, !bGXsfl_12_Refreshing);
         edtBR_Information_ID_Titleformat = 2;
         edtBR_Information_ID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "患者基本信息主键ID", AV32ddo_BR_Information_IDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Information_ID_Internalname, "Title", edtBR_Information_ID_Title, !bGXsfl_12_Refreshing);
         edtBR_Information_PatientNo_Titleformat = 2;
         edtBR_Information_PatientNo_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "患者编号", AV34ddo_BR_Information_PatientNoTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Information_PatientNo_Internalname, "Title", edtBR_Information_PatientNo_Title, !bGXsfl_12_Refreshing);
         AV41GridCurrentPage = subGrid_Currentpage( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV41GridCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV41GridCurrentPage), 10, 0)));
         AV42GridPageSize = subGrid_Rows;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV42GridPageSize", StringUtil.LTrim( StringUtil.Str( (decimal)(AV42GridPageSize), 10, 0)));
         AV43GridRecordCount = subGrid_Recordcount( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV43GridRecordCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV43GridRecordCount), 10, 0)));
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_EncounterIDTitleFilterData", AV15BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_Encounter_EncIDTitleFilterData", AV17BR_Encounter_EncIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_Encounter_DepartmentTitleFilterData", AV19BR_Encounter_DepartmentTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21BR_Encounter_ENCTypeTitleFilterData", AV21BR_Encounter_ENCTypeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23BR_Encounter_AdmitDateTitleFilterData", AV23BR_Encounter_AdmitDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV25BR_Encounter_AdmitSourceTitleFilterData", AV25BR_Encounter_AdmitSourceTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27BR_Encounter_DischargeDateTitleFilterData", AV27BR_Encounter_DischargeDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29BR_Encounter_DischargeStatusTitleFilterData", AV29BR_Encounter_DischargeStatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV49BR_Encounter_StatusTitleFilterData", AV49BR_Encounter_StatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV31BR_Information_IDTitleFilterData", AV31BR_Information_IDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV33BR_Information_PatientNoTitleFilterData", AV33BR_Information_PatientNoTitleFilterData);
      }

      protected void E11152( )
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
            AV40PageToGo = (int)(NumberUtil.Val( Gridpaginationbar_Selectedpage, "."));
            subgrid_gotopage( AV40PageToGo) ;
         }
      }

      protected void E12152( )
      {
         /* Gridpaginationbar_Changerowsperpage Routine */
         subGrid_Rows = Gridpaginationbar_Rowsperpageselectedvalue;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         subgrid_firstpage( ) ;
         /*  Sending Event outputs  */
      }

      protected void E13152( )
      {
         /* Ddo_br_encounterid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_encounterid_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 1;
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
            AV11OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_encounterid_Sortedstatus = "DSC";
            ucDdo_br_encounterid.SendProperty(context, "", false, Ddo_br_encounterid_Internalname, "SortedStatus", Ddo_br_encounterid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_EncounterIDTitleFilterData", AV15BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_Encounter_EncIDTitleFilterData", AV17BR_Encounter_EncIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_Encounter_DepartmentTitleFilterData", AV19BR_Encounter_DepartmentTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21BR_Encounter_ENCTypeTitleFilterData", AV21BR_Encounter_ENCTypeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23BR_Encounter_AdmitDateTitleFilterData", AV23BR_Encounter_AdmitDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV25BR_Encounter_AdmitSourceTitleFilterData", AV25BR_Encounter_AdmitSourceTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27BR_Encounter_DischargeDateTitleFilterData", AV27BR_Encounter_DischargeDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29BR_Encounter_DischargeStatusTitleFilterData", AV29BR_Encounter_DischargeStatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV49BR_Encounter_StatusTitleFilterData", AV49BR_Encounter_StatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV31BR_Information_IDTitleFilterData", AV31BR_Information_IDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV33BR_Information_PatientNoTitleFilterData", AV33BR_Information_PatientNoTitleFilterData);
      }

      protected void E14152( )
      {
         /* Ddo_br_encounter_encid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_encounter_encid_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_encounter_encid_Sortedstatus = "ASC";
            ucDdo_br_encounter_encid.SendProperty(context, "", false, Ddo_br_encounter_encid_Internalname, "SortedStatus", Ddo_br_encounter_encid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_encounter_encid_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_encounter_encid_Sortedstatus = "DSC";
            ucDdo_br_encounter_encid.SendProperty(context, "", false, Ddo_br_encounter_encid_Internalname, "SortedStatus", Ddo_br_encounter_encid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_EncounterIDTitleFilterData", AV15BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_Encounter_EncIDTitleFilterData", AV17BR_Encounter_EncIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_Encounter_DepartmentTitleFilterData", AV19BR_Encounter_DepartmentTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21BR_Encounter_ENCTypeTitleFilterData", AV21BR_Encounter_ENCTypeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23BR_Encounter_AdmitDateTitleFilterData", AV23BR_Encounter_AdmitDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV25BR_Encounter_AdmitSourceTitleFilterData", AV25BR_Encounter_AdmitSourceTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27BR_Encounter_DischargeDateTitleFilterData", AV27BR_Encounter_DischargeDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29BR_Encounter_DischargeStatusTitleFilterData", AV29BR_Encounter_DischargeStatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV49BR_Encounter_StatusTitleFilterData", AV49BR_Encounter_StatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV31BR_Information_IDTitleFilterData", AV31BR_Information_IDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV33BR_Information_PatientNoTitleFilterData", AV33BR_Information_PatientNoTitleFilterData);
      }

      protected void E15152( )
      {
         /* Ddo_br_encounter_department_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_encounter_department_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 3;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_encounter_department_Sortedstatus = "ASC";
            ucDdo_br_encounter_department.SendProperty(context, "", false, Ddo_br_encounter_department_Internalname, "SortedStatus", Ddo_br_encounter_department_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_encounter_department_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 3;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_encounter_department_Sortedstatus = "DSC";
            ucDdo_br_encounter_department.SendProperty(context, "", false, Ddo_br_encounter_department_Internalname, "SortedStatus", Ddo_br_encounter_department_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_EncounterIDTitleFilterData", AV15BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_Encounter_EncIDTitleFilterData", AV17BR_Encounter_EncIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_Encounter_DepartmentTitleFilterData", AV19BR_Encounter_DepartmentTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21BR_Encounter_ENCTypeTitleFilterData", AV21BR_Encounter_ENCTypeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23BR_Encounter_AdmitDateTitleFilterData", AV23BR_Encounter_AdmitDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV25BR_Encounter_AdmitSourceTitleFilterData", AV25BR_Encounter_AdmitSourceTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27BR_Encounter_DischargeDateTitleFilterData", AV27BR_Encounter_DischargeDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29BR_Encounter_DischargeStatusTitleFilterData", AV29BR_Encounter_DischargeStatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV49BR_Encounter_StatusTitleFilterData", AV49BR_Encounter_StatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV31BR_Information_IDTitleFilterData", AV31BR_Information_IDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV33BR_Information_PatientNoTitleFilterData", AV33BR_Information_PatientNoTitleFilterData);
      }

      protected void E16152( )
      {
         /* Ddo_br_encounter_enctype_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_encounter_enctype_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 4;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_encounter_enctype_Sortedstatus = "ASC";
            ucDdo_br_encounter_enctype.SendProperty(context, "", false, Ddo_br_encounter_enctype_Internalname, "SortedStatus", Ddo_br_encounter_enctype_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_encounter_enctype_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 4;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_encounter_enctype_Sortedstatus = "DSC";
            ucDdo_br_encounter_enctype.SendProperty(context, "", false, Ddo_br_encounter_enctype_Internalname, "SortedStatus", Ddo_br_encounter_enctype_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_EncounterIDTitleFilterData", AV15BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_Encounter_EncIDTitleFilterData", AV17BR_Encounter_EncIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_Encounter_DepartmentTitleFilterData", AV19BR_Encounter_DepartmentTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21BR_Encounter_ENCTypeTitleFilterData", AV21BR_Encounter_ENCTypeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23BR_Encounter_AdmitDateTitleFilterData", AV23BR_Encounter_AdmitDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV25BR_Encounter_AdmitSourceTitleFilterData", AV25BR_Encounter_AdmitSourceTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27BR_Encounter_DischargeDateTitleFilterData", AV27BR_Encounter_DischargeDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29BR_Encounter_DischargeStatusTitleFilterData", AV29BR_Encounter_DischargeStatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV49BR_Encounter_StatusTitleFilterData", AV49BR_Encounter_StatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV31BR_Information_IDTitleFilterData", AV31BR_Information_IDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV33BR_Information_PatientNoTitleFilterData", AV33BR_Information_PatientNoTitleFilterData);
      }

      protected void E17152( )
      {
         /* Ddo_br_encounter_admitdate_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_encounter_admitdate_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 5;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_encounter_admitdate_Sortedstatus = "ASC";
            ucDdo_br_encounter_admitdate.SendProperty(context, "", false, Ddo_br_encounter_admitdate_Internalname, "SortedStatus", Ddo_br_encounter_admitdate_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_encounter_admitdate_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 5;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_encounter_admitdate_Sortedstatus = "DSC";
            ucDdo_br_encounter_admitdate.SendProperty(context, "", false, Ddo_br_encounter_admitdate_Internalname, "SortedStatus", Ddo_br_encounter_admitdate_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_EncounterIDTitleFilterData", AV15BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_Encounter_EncIDTitleFilterData", AV17BR_Encounter_EncIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_Encounter_DepartmentTitleFilterData", AV19BR_Encounter_DepartmentTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21BR_Encounter_ENCTypeTitleFilterData", AV21BR_Encounter_ENCTypeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23BR_Encounter_AdmitDateTitleFilterData", AV23BR_Encounter_AdmitDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV25BR_Encounter_AdmitSourceTitleFilterData", AV25BR_Encounter_AdmitSourceTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27BR_Encounter_DischargeDateTitleFilterData", AV27BR_Encounter_DischargeDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29BR_Encounter_DischargeStatusTitleFilterData", AV29BR_Encounter_DischargeStatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV49BR_Encounter_StatusTitleFilterData", AV49BR_Encounter_StatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV31BR_Information_IDTitleFilterData", AV31BR_Information_IDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV33BR_Information_PatientNoTitleFilterData", AV33BR_Information_PatientNoTitleFilterData);
      }

      protected void E18152( )
      {
         /* Ddo_br_encounter_admitsource_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_encounter_admitsource_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 6;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_encounter_admitsource_Sortedstatus = "ASC";
            ucDdo_br_encounter_admitsource.SendProperty(context, "", false, Ddo_br_encounter_admitsource_Internalname, "SortedStatus", Ddo_br_encounter_admitsource_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_encounter_admitsource_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 6;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_encounter_admitsource_Sortedstatus = "DSC";
            ucDdo_br_encounter_admitsource.SendProperty(context, "", false, Ddo_br_encounter_admitsource_Internalname, "SortedStatus", Ddo_br_encounter_admitsource_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_EncounterIDTitleFilterData", AV15BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_Encounter_EncIDTitleFilterData", AV17BR_Encounter_EncIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_Encounter_DepartmentTitleFilterData", AV19BR_Encounter_DepartmentTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21BR_Encounter_ENCTypeTitleFilterData", AV21BR_Encounter_ENCTypeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23BR_Encounter_AdmitDateTitleFilterData", AV23BR_Encounter_AdmitDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV25BR_Encounter_AdmitSourceTitleFilterData", AV25BR_Encounter_AdmitSourceTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27BR_Encounter_DischargeDateTitleFilterData", AV27BR_Encounter_DischargeDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29BR_Encounter_DischargeStatusTitleFilterData", AV29BR_Encounter_DischargeStatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV49BR_Encounter_StatusTitleFilterData", AV49BR_Encounter_StatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV31BR_Information_IDTitleFilterData", AV31BR_Information_IDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV33BR_Information_PatientNoTitleFilterData", AV33BR_Information_PatientNoTitleFilterData);
      }

      protected void E19152( )
      {
         /* Ddo_br_encounter_dischargedate_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_encounter_dischargedate_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 7;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_encounter_dischargedate_Sortedstatus = "ASC";
            ucDdo_br_encounter_dischargedate.SendProperty(context, "", false, Ddo_br_encounter_dischargedate_Internalname, "SortedStatus", Ddo_br_encounter_dischargedate_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_encounter_dischargedate_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 7;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_encounter_dischargedate_Sortedstatus = "DSC";
            ucDdo_br_encounter_dischargedate.SendProperty(context, "", false, Ddo_br_encounter_dischargedate_Internalname, "SortedStatus", Ddo_br_encounter_dischargedate_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_EncounterIDTitleFilterData", AV15BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_Encounter_EncIDTitleFilterData", AV17BR_Encounter_EncIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_Encounter_DepartmentTitleFilterData", AV19BR_Encounter_DepartmentTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21BR_Encounter_ENCTypeTitleFilterData", AV21BR_Encounter_ENCTypeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23BR_Encounter_AdmitDateTitleFilterData", AV23BR_Encounter_AdmitDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV25BR_Encounter_AdmitSourceTitleFilterData", AV25BR_Encounter_AdmitSourceTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27BR_Encounter_DischargeDateTitleFilterData", AV27BR_Encounter_DischargeDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29BR_Encounter_DischargeStatusTitleFilterData", AV29BR_Encounter_DischargeStatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV49BR_Encounter_StatusTitleFilterData", AV49BR_Encounter_StatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV31BR_Information_IDTitleFilterData", AV31BR_Information_IDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV33BR_Information_PatientNoTitleFilterData", AV33BR_Information_PatientNoTitleFilterData);
      }

      protected void E20152( )
      {
         /* Ddo_br_encounter_dischargestatus_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_encounter_dischargestatus_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 8;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_encounter_dischargestatus_Sortedstatus = "ASC";
            ucDdo_br_encounter_dischargestatus.SendProperty(context, "", false, Ddo_br_encounter_dischargestatus_Internalname, "SortedStatus", Ddo_br_encounter_dischargestatus_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_encounter_dischargestatus_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 8;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_encounter_dischargestatus_Sortedstatus = "DSC";
            ucDdo_br_encounter_dischargestatus.SendProperty(context, "", false, Ddo_br_encounter_dischargestatus_Internalname, "SortedStatus", Ddo_br_encounter_dischargestatus_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_EncounterIDTitleFilterData", AV15BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_Encounter_EncIDTitleFilterData", AV17BR_Encounter_EncIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_Encounter_DepartmentTitleFilterData", AV19BR_Encounter_DepartmentTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21BR_Encounter_ENCTypeTitleFilterData", AV21BR_Encounter_ENCTypeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23BR_Encounter_AdmitDateTitleFilterData", AV23BR_Encounter_AdmitDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV25BR_Encounter_AdmitSourceTitleFilterData", AV25BR_Encounter_AdmitSourceTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27BR_Encounter_DischargeDateTitleFilterData", AV27BR_Encounter_DischargeDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29BR_Encounter_DischargeStatusTitleFilterData", AV29BR_Encounter_DischargeStatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV49BR_Encounter_StatusTitleFilterData", AV49BR_Encounter_StatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV31BR_Information_IDTitleFilterData", AV31BR_Information_IDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV33BR_Information_PatientNoTitleFilterData", AV33BR_Information_PatientNoTitleFilterData);
      }

      protected void E21152( )
      {
         /* Ddo_br_encounter_status_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_encounter_status_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 9;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_encounter_status_Sortedstatus = "ASC";
            ucDdo_br_encounter_status.SendProperty(context, "", false, Ddo_br_encounter_status_Internalname, "SortedStatus", Ddo_br_encounter_status_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_encounter_status_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 9;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_encounter_status_Sortedstatus = "DSC";
            ucDdo_br_encounter_status.SendProperty(context, "", false, Ddo_br_encounter_status_Internalname, "SortedStatus", Ddo_br_encounter_status_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_EncounterIDTitleFilterData", AV15BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_Encounter_EncIDTitleFilterData", AV17BR_Encounter_EncIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_Encounter_DepartmentTitleFilterData", AV19BR_Encounter_DepartmentTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21BR_Encounter_ENCTypeTitleFilterData", AV21BR_Encounter_ENCTypeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23BR_Encounter_AdmitDateTitleFilterData", AV23BR_Encounter_AdmitDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV25BR_Encounter_AdmitSourceTitleFilterData", AV25BR_Encounter_AdmitSourceTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27BR_Encounter_DischargeDateTitleFilterData", AV27BR_Encounter_DischargeDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29BR_Encounter_DischargeStatusTitleFilterData", AV29BR_Encounter_DischargeStatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV49BR_Encounter_StatusTitleFilterData", AV49BR_Encounter_StatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV31BR_Information_IDTitleFilterData", AV31BR_Information_IDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV33BR_Information_PatientNoTitleFilterData", AV33BR_Information_PatientNoTitleFilterData);
      }

      protected void E22152( )
      {
         /* Ddo_br_information_id_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_information_id_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 10;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_information_id_Sortedstatus = "ASC";
            ucDdo_br_information_id.SendProperty(context, "", false, Ddo_br_information_id_Internalname, "SortedStatus", Ddo_br_information_id_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_information_id_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 10;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_information_id_Sortedstatus = "DSC";
            ucDdo_br_information_id.SendProperty(context, "", false, Ddo_br_information_id_Internalname, "SortedStatus", Ddo_br_information_id_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_EncounterIDTitleFilterData", AV15BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_Encounter_EncIDTitleFilterData", AV17BR_Encounter_EncIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_Encounter_DepartmentTitleFilterData", AV19BR_Encounter_DepartmentTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21BR_Encounter_ENCTypeTitleFilterData", AV21BR_Encounter_ENCTypeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23BR_Encounter_AdmitDateTitleFilterData", AV23BR_Encounter_AdmitDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV25BR_Encounter_AdmitSourceTitleFilterData", AV25BR_Encounter_AdmitSourceTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27BR_Encounter_DischargeDateTitleFilterData", AV27BR_Encounter_DischargeDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29BR_Encounter_DischargeStatusTitleFilterData", AV29BR_Encounter_DischargeStatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV49BR_Encounter_StatusTitleFilterData", AV49BR_Encounter_StatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV31BR_Information_IDTitleFilterData", AV31BR_Information_IDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV33BR_Information_PatientNoTitleFilterData", AV33BR_Information_PatientNoTitleFilterData);
      }

      protected void E23152( )
      {
         /* Ddo_br_information_patientno_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_information_patientno_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 11;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_information_patientno_Sortedstatus = "ASC";
            ucDdo_br_information_patientno.SendProperty(context, "", false, Ddo_br_information_patientno_Internalname, "SortedStatus", Ddo_br_information_patientno_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_information_patientno_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 11;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_information_patientno_Sortedstatus = "DSC";
            ucDdo_br_information_patientno.SendProperty(context, "", false, Ddo_br_information_patientno_Internalname, "SortedStatus", Ddo_br_information_patientno_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_EncounterIDTitleFilterData", AV15BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_Encounter_EncIDTitleFilterData", AV17BR_Encounter_EncIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_Encounter_DepartmentTitleFilterData", AV19BR_Encounter_DepartmentTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21BR_Encounter_ENCTypeTitleFilterData", AV21BR_Encounter_ENCTypeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV23BR_Encounter_AdmitDateTitleFilterData", AV23BR_Encounter_AdmitDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV25BR_Encounter_AdmitSourceTitleFilterData", AV25BR_Encounter_AdmitSourceTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV27BR_Encounter_DischargeDateTitleFilterData", AV27BR_Encounter_DischargeDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV29BR_Encounter_DischargeStatusTitleFilterData", AV29BR_Encounter_DischargeStatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV49BR_Encounter_StatusTitleFilterData", AV49BR_Encounter_StatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV31BR_Information_IDTitleFilterData", AV31BR_Information_IDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV33BR_Information_PatientNoTitleFilterData", AV33BR_Information_PatientNoTitleFilterData);
      }

      private void E26152( )
      {
         /* Grid_Load Routine */
         AV44Select = context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavSelect_Internalname, AV44Select);
         AV78Select_GXI = GXDbFile.PathToUrl( context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( )));
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
         E27152 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E27152( )
      {
         /* Enter Routine */
         AV8InOutBR_EncounterID = A19BR_EncounterID;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8InOutBR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8InOutBR_EncounterID), 18, 0)));
         context.setWebReturnParms(new Object[] {(long)AV8InOutBR_EncounterID});
         context.setWebReturnParmsMetadata(new Object[] {"AV8InOutBR_EncounterID"});
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
         AV8InOutBR_EncounterID = Convert.ToInt64(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8InOutBR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8InOutBR_EncounterID), 18, 0)));
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
         PA152( ) ;
         WS152( ) ;
         WE152( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20202281595050", true);
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
         context.AddJavascriptSource("br_encounterprompt.js", "?20202281595051", false);
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
         edtBR_EncounterID_Internalname = "BR_ENCOUNTERID_"+sGXsfl_12_idx;
         edtBR_Encounter_EncID_Internalname = "BR_ENCOUNTER_ENCID_"+sGXsfl_12_idx;
         edtBR_Encounter_Department_Internalname = "BR_ENCOUNTER_DEPARTMENT_"+sGXsfl_12_idx;
         edtBR_Encounter_ENCType_Internalname = "BR_ENCOUNTER_ENCTYPE_"+sGXsfl_12_idx;
         edtBR_Encounter_AdmitDate_Internalname = "BR_ENCOUNTER_ADMITDATE_"+sGXsfl_12_idx;
         edtBR_Encounter_AdmitSource_Internalname = "BR_ENCOUNTER_ADMITSOURCE_"+sGXsfl_12_idx;
         edtBR_Encounter_DischargeDate_Internalname = "BR_ENCOUNTER_DISCHARGEDATE_"+sGXsfl_12_idx;
         edtBR_Encounter_DischargeStatus_Internalname = "BR_ENCOUNTER_DISCHARGESTATUS_"+sGXsfl_12_idx;
         cmbBR_Encounter_Status_Internalname = "BR_ENCOUNTER_STATUS_"+sGXsfl_12_idx;
         edtBR_Information_ID_Internalname = "BR_INFORMATION_ID_"+sGXsfl_12_idx;
         edtBR_Information_PatientNo_Internalname = "BR_INFORMATION_PATIENTNO_"+sGXsfl_12_idx;
      }

      protected void SubsflControlProps_fel_122( )
      {
         edtavSelect_Internalname = "vSELECT_"+sGXsfl_12_fel_idx;
         edtBR_EncounterID_Internalname = "BR_ENCOUNTERID_"+sGXsfl_12_fel_idx;
         edtBR_Encounter_EncID_Internalname = "BR_ENCOUNTER_ENCID_"+sGXsfl_12_fel_idx;
         edtBR_Encounter_Department_Internalname = "BR_ENCOUNTER_DEPARTMENT_"+sGXsfl_12_fel_idx;
         edtBR_Encounter_ENCType_Internalname = "BR_ENCOUNTER_ENCTYPE_"+sGXsfl_12_fel_idx;
         edtBR_Encounter_AdmitDate_Internalname = "BR_ENCOUNTER_ADMITDATE_"+sGXsfl_12_fel_idx;
         edtBR_Encounter_AdmitSource_Internalname = "BR_ENCOUNTER_ADMITSOURCE_"+sGXsfl_12_fel_idx;
         edtBR_Encounter_DischargeDate_Internalname = "BR_ENCOUNTER_DISCHARGEDATE_"+sGXsfl_12_fel_idx;
         edtBR_Encounter_DischargeStatus_Internalname = "BR_ENCOUNTER_DISCHARGESTATUS_"+sGXsfl_12_fel_idx;
         cmbBR_Encounter_Status_Internalname = "BR_ENCOUNTER_STATUS_"+sGXsfl_12_fel_idx;
         edtBR_Information_ID_Internalname = "BR_INFORMATION_ID_"+sGXsfl_12_fel_idx;
         edtBR_Information_PatientNo_Internalname = "BR_INFORMATION_PATIENTNO_"+sGXsfl_12_fel_idx;
      }

      protected void sendrow_122( )
      {
         SubsflControlProps_122( ) ;
         WB150( ) ;
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
            AV44Select_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV44Select))&&String.IsNullOrEmpty(StringUtil.RTrim( AV78Select_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV44Select)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV44Select)) ? AV78Select_GXI : context.PathToRelativeUrl( AV44Select));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavSelect_Internalname,(String)sImgUrl,(String)"",(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)edtavSelect_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)5,(String)edtavSelect_Jsonclick,"'"+""+"'"+",false,"+"'"+"EENTER."+sGXsfl_12_idx+"'",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)""+TempTags,(String)"",(String)"",(short)1,(bool)AV44Select_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_EncounterID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A19BR_EncounterID), 18, 0, ".", "")),context.localUtil.Format( (decimal)(A19BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_EncounterID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"ID",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Encounter_EncID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A35BR_Encounter_EncID), 10, 0, ".", "")),context.localUtil.Format( (decimal)(A35BR_Encounter_EncID), "ZZZZZZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Encounter_EncID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Encounter_Department_Internalname,(String)A84BR_Encounter_Department,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Encounter_Department_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Encounter_ENCType_Internalname,(String)A90BR_Encounter_ENCType,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Encounter_ENCType_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Encounter_AdmitDate_Internalname,context.localUtil.Format(A91BR_Encounter_AdmitDate, "9999/99/99"),context.localUtil.Format( A91BR_Encounter_AdmitDate, "9999/99/99"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Encounter_AdmitDate_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"DM_Date",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Encounter_AdmitSource_Internalname,(String)A92BR_Encounter_AdmitSource,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Encounter_AdmitSource_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Encounter_DischargeDate_Internalname,context.localUtil.Format(A93BR_Encounter_DischargeDate, "9999/99/99"),context.localUtil.Format( A93BR_Encounter_DischargeDate, "9999/99/99"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Encounter_DischargeDate_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"DM_Date",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Encounter_DischargeStatus_Internalname,(String)A94BR_Encounter_DischargeStatus,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Encounter_DischargeStatus_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            if ( ( cmbBR_Encounter_Status.ItemCount == 0 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "BR_ENCOUNTER_STATUS_" + sGXsfl_12_idx;
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
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Encounter_Status_Internalname, "Values", (String)(cmbBR_Encounter_Status.ToJavascriptSource()), !bGXsfl_12_Refreshing);
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Information_ID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A85BR_Information_ID), 18, 0, ".", "")),context.localUtil.Format( (decimal)(A85BR_Information_ID), "ZZZZZZZZZZZZZZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Information_ID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"ID",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Information_PatientNo_Internalname,(String)A36BR_Information_PatientNo,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Information_PatientNo_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)410,(String)"px",(short)17,(String)"px",(short)2000,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            send_integrity_lvl_hashes152( ) ;
            GridContainer.AddRow(GridRow);
            nGXsfl_12_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_12_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_12_idx+1));
            sGXsfl_12_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_12_idx), 4, 0)), 4, "0");
            SubsflControlProps_122( ) ;
         }
         /* End function sendrow_122 */
      }

      protected void init_web_controls( )
      {
         GXCCtl = "BR_ENCOUNTER_STATUS_" + sGXsfl_12_idx;
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
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         edtavSelect_Internalname = "vSELECT";
         edtBR_EncounterID_Internalname = "BR_ENCOUNTERID";
         edtBR_Encounter_EncID_Internalname = "BR_ENCOUNTER_ENCID";
         edtBR_Encounter_Department_Internalname = "BR_ENCOUNTER_DEPARTMENT";
         edtBR_Encounter_ENCType_Internalname = "BR_ENCOUNTER_ENCTYPE";
         edtBR_Encounter_AdmitDate_Internalname = "BR_ENCOUNTER_ADMITDATE";
         edtBR_Encounter_AdmitSource_Internalname = "BR_ENCOUNTER_ADMITSOURCE";
         edtBR_Encounter_DischargeDate_Internalname = "BR_ENCOUNTER_DISCHARGEDATE";
         edtBR_Encounter_DischargeStatus_Internalname = "BR_ENCOUNTER_DISCHARGESTATUS";
         cmbBR_Encounter_Status_Internalname = "BR_ENCOUNTER_STATUS";
         edtBR_Information_ID_Internalname = "BR_INFORMATION_ID";
         edtBR_Information_PatientNo_Internalname = "BR_INFORMATION_PATIENTNO";
         Gridpaginationbar_Internalname = "GRIDPAGINATIONBAR";
         divHtml_gridpaginationbar_Internalname = "HTML_GRIDPAGINATIONBAR";
         divGridtablewithpaginationbar_Internalname = "GRIDTABLEWITHPAGINATIONBAR";
         divTablemain_Internalname = "TABLEMAIN";
         Ddo_br_encounterid_Internalname = "DDO_BR_ENCOUNTERID";
         edtavDdo_br_encounteridtitlecontrolidtoreplace_Internalname = "vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE";
         Ddo_br_encounter_encid_Internalname = "DDO_BR_ENCOUNTER_ENCID";
         edtavDdo_br_encounter_encidtitlecontrolidtoreplace_Internalname = "vDDO_BR_ENCOUNTER_ENCIDTITLECONTROLIDTOREPLACE";
         Ddo_br_encounter_department_Internalname = "DDO_BR_ENCOUNTER_DEPARTMENT";
         edtavDdo_br_encounter_departmenttitlecontrolidtoreplace_Internalname = "vDDO_BR_ENCOUNTER_DEPARTMENTTITLECONTROLIDTOREPLACE";
         Ddo_br_encounter_enctype_Internalname = "DDO_BR_ENCOUNTER_ENCTYPE";
         edtavDdo_br_encounter_enctypetitlecontrolidtoreplace_Internalname = "vDDO_BR_ENCOUNTER_ENCTYPETITLECONTROLIDTOREPLACE";
         Ddo_br_encounter_admitdate_Internalname = "DDO_BR_ENCOUNTER_ADMITDATE";
         edtavDdo_br_encounter_admitdatetitlecontrolidtoreplace_Internalname = "vDDO_BR_ENCOUNTER_ADMITDATETITLECONTROLIDTOREPLACE";
         Ddo_br_encounter_admitsource_Internalname = "DDO_BR_ENCOUNTER_ADMITSOURCE";
         edtavDdo_br_encounter_admitsourcetitlecontrolidtoreplace_Internalname = "vDDO_BR_ENCOUNTER_ADMITSOURCETITLECONTROLIDTOREPLACE";
         Ddo_br_encounter_dischargedate_Internalname = "DDO_BR_ENCOUNTER_DISCHARGEDATE";
         edtavDdo_br_encounter_dischargedatetitlecontrolidtoreplace_Internalname = "vDDO_BR_ENCOUNTER_DISCHARGEDATETITLECONTROLIDTOREPLACE";
         Ddo_br_encounter_dischargestatus_Internalname = "DDO_BR_ENCOUNTER_DISCHARGESTATUS";
         edtavDdo_br_encounter_dischargestatustitlecontrolidtoreplace_Internalname = "vDDO_BR_ENCOUNTER_DISCHARGESTATUSTITLECONTROLIDTOREPLACE";
         Ddo_br_encounter_status_Internalname = "DDO_BR_ENCOUNTER_STATUS";
         edtavDdo_br_encounter_statustitlecontrolidtoreplace_Internalname = "vDDO_BR_ENCOUNTER_STATUSTITLECONTROLIDTOREPLACE";
         Ddo_br_information_id_Internalname = "DDO_BR_INFORMATION_ID";
         edtavDdo_br_information_idtitlecontrolidtoreplace_Internalname = "vDDO_BR_INFORMATION_IDTITLECONTROLIDTOREPLACE";
         Ddo_br_information_patientno_Internalname = "DDO_BR_INFORMATION_PATIENTNO";
         edtavDdo_br_information_patientnotitlecontrolidtoreplace_Internalname = "vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE";
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
         edtBR_Information_PatientNo_Jsonclick = "";
         edtBR_Information_ID_Jsonclick = "";
         cmbBR_Encounter_Status_Jsonclick = "";
         edtBR_Encounter_DischargeStatus_Jsonclick = "";
         edtBR_Encounter_DischargeDate_Jsonclick = "";
         edtBR_Encounter_AdmitSource_Jsonclick = "";
         edtBR_Encounter_AdmitDate_Jsonclick = "";
         edtBR_Encounter_ENCType_Jsonclick = "";
         edtBR_Encounter_Department_Jsonclick = "";
         edtBR_Encounter_EncID_Jsonclick = "";
         edtBR_EncounterID_Jsonclick = "";
         edtavSelect_Jsonclick = "";
         edtavSelect_Visible = -1;
         edtavSelect_Enabled = 1;
         edtavOrdereddsc_Jsonclick = "";
         edtavOrdereddsc_Visible = 1;
         edtavOrderedby_Jsonclick = "";
         edtavOrderedby_Visible = 1;
         edtavDdo_br_information_patientnotitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_information_idtitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_encounter_statustitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_encounter_dischargestatustitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_encounter_dischargedatetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_encounter_admitsourcetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_encounter_admitdatetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_encounter_enctypetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_encounter_departmenttitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_encounter_encidtitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_encounteridtitlecontrolidtoreplace_Visible = 1;
         subGrid_Allowcollapsing = 0;
         subGrid_Allowselection = 0;
         edtavSelect_Tooltiptext = "选择";
         subGrid_Sortable = 0;
         subGrid_Header = "";
         edtBR_Information_PatientNo_Titleformat = 0;
         edtBR_Information_PatientNo_Title = "患者编号";
         edtBR_Information_ID_Titleformat = 0;
         edtBR_Information_ID_Title = "患者基本信息主键ID";
         cmbBR_Encounter_Status_Titleformat = 0;
         cmbBR_Encounter_Status.Title.Text = "审批状态";
         edtBR_Encounter_DischargeStatus_Titleformat = 0;
         edtBR_Encounter_DischargeStatus_Title = "出院状态";
         edtBR_Encounter_DischargeDate_Titleformat = 0;
         edtBR_Encounter_DischargeDate_Title = "出院时间";
         edtBR_Encounter_AdmitSource_Titleformat = 0;
         edtBR_Encounter_AdmitSource_Title = "入院原因";
         edtBR_Encounter_AdmitDate_Titleformat = 0;
         edtBR_Encounter_AdmitDate_Title = "就诊/入院时间";
         edtBR_Encounter_ENCType_Titleformat = 0;
         edtBR_Encounter_ENCType_Title = "就诊方式";
         edtBR_Encounter_Department_Titleformat = 0;
         edtBR_Encounter_Department_Title = "就诊科室";
         edtBR_Encounter_EncID_Titleformat = 0;
         edtBR_Encounter_EncID_Title = "就诊次序";
         edtBR_EncounterID_Titleformat = 0;
         edtBR_EncounterID_Title = "就诊信息主键";
         subGrid_Class = "GridWithPaginationBar GridWithBorderColor WorkWith";
         subGrid_Backcolorstyle = 0;
         divTablemain_Height = 0;
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
         Ddo_br_information_id_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_information_id_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_information_id_Sortasc = "WWP_TSSortASC";
         Ddo_br_information_id_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_information_id_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_information_id_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_information_id_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_information_id_Titlecontrolidtoreplace = "";
         Ddo_br_information_id_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_information_id_Cls = "ColumnSettings";
         Ddo_br_information_id_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_information_id_Caption = "";
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
         Ddo_br_encounter_dischargestatus_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_encounter_dischargestatus_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_encounter_dischargestatus_Sortasc = "WWP_TSSortASC";
         Ddo_br_encounter_dischargestatus_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_encounter_dischargestatus_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_encounter_dischargestatus_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_encounter_dischargestatus_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_encounter_dischargestatus_Titlecontrolidtoreplace = "";
         Ddo_br_encounter_dischargestatus_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_encounter_dischargestatus_Cls = "ColumnSettings";
         Ddo_br_encounter_dischargestatus_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_encounter_dischargestatus_Caption = "";
         Ddo_br_encounter_dischargedate_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_encounter_dischargedate_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_encounter_dischargedate_Sortasc = "WWP_TSSortASC";
         Ddo_br_encounter_dischargedate_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_encounter_dischargedate_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_encounter_dischargedate_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_encounter_dischargedate_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_encounter_dischargedate_Titlecontrolidtoreplace = "";
         Ddo_br_encounter_dischargedate_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_encounter_dischargedate_Cls = "ColumnSettings";
         Ddo_br_encounter_dischargedate_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_encounter_dischargedate_Caption = "";
         Ddo_br_encounter_admitsource_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_encounter_admitsource_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_encounter_admitsource_Sortasc = "WWP_TSSortASC";
         Ddo_br_encounter_admitsource_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_encounter_admitsource_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_encounter_admitsource_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_encounter_admitsource_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_encounter_admitsource_Titlecontrolidtoreplace = "";
         Ddo_br_encounter_admitsource_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_encounter_admitsource_Cls = "ColumnSettings";
         Ddo_br_encounter_admitsource_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_encounter_admitsource_Caption = "";
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
         Ddo_br_encounter_encid_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_encounter_encid_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_encounter_encid_Sortasc = "WWP_TSSortASC";
         Ddo_br_encounter_encid_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_encounter_encid_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_encounter_encid_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_encounter_encid_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_encounter_encid_Titlecontrolidtoreplace = "";
         Ddo_br_encounter_encid_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_encounter_encid_Cls = "ColumnSettings";
         Ddo_br_encounter_encid_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_encounter_encid_Caption = "";
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
         Form.Caption = "选择就诊信息";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV16ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Encounter_EncIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Encounter_DepartmentTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DEPARTMENTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Encounter_ENCTypeTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Encounter_AdmitDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ADMITDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Encounter_AdmitSourceTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ADMITSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_Encounter_DischargeDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DISCHARGEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_Encounter_DischargeStatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DISCHARGESTATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV50ddo_BR_Encounter_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV32ddo_BR_Information_IDTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_IDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV34ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]");
         setEventMetadata("REFRESH",",oparms:[{av:'AV15BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Encounter_EncIDTitleFilterData',fld:'vBR_ENCOUNTER_ENCIDTITLEFILTERDATA',pic:''},{av:'AV19BR_Encounter_DepartmentTitleFilterData',fld:'vBR_ENCOUNTER_DEPARTMENTTITLEFILTERDATA',pic:''},{av:'AV21BR_Encounter_ENCTypeTitleFilterData',fld:'vBR_ENCOUNTER_ENCTYPETITLEFILTERDATA',pic:''},{av:'AV23BR_Encounter_AdmitDateTitleFilterData',fld:'vBR_ENCOUNTER_ADMITDATETITLEFILTERDATA',pic:''},{av:'AV25BR_Encounter_AdmitSourceTitleFilterData',fld:'vBR_ENCOUNTER_ADMITSOURCETITLEFILTERDATA',pic:''},{av:'AV27BR_Encounter_DischargeDateTitleFilterData',fld:'vBR_ENCOUNTER_DISCHARGEDATETITLEFILTERDATA',pic:''},{av:'AV29BR_Encounter_DischargeStatusTitleFilterData',fld:'vBR_ENCOUNTER_DISCHARGESTATUSTITLEFILTERDATA',pic:''},{av:'AV49BR_Encounter_StatusTitleFilterData',fld:'vBR_ENCOUNTER_STATUSTITLEFILTERDATA',pic:''},{av:'AV31BR_Information_IDTitleFilterData',fld:'vBR_INFORMATION_IDTITLEFILTERDATA',pic:''},{av:'AV33BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Encounter_EncID_Titleformat',ctrl:'BR_ENCOUNTER_ENCID',prop:'Titleformat'},{av:'edtBR_Encounter_EncID_Title',ctrl:'BR_ENCOUNTER_ENCID',prop:'Title'},{av:'edtBR_Encounter_Department_Titleformat',ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Titleformat'},{av:'edtBR_Encounter_Department_Title',ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Title'},{av:'edtBR_Encounter_ENCType_Titleformat',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Titleformat'},{av:'edtBR_Encounter_ENCType_Title',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Title'},{av:'edtBR_Encounter_AdmitDate_Titleformat',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Titleformat'},{av:'edtBR_Encounter_AdmitDate_Title',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Title'},{av:'edtBR_Encounter_AdmitSource_Titleformat',ctrl:'BR_ENCOUNTER_ADMITSOURCE',prop:'Titleformat'},{av:'edtBR_Encounter_AdmitSource_Title',ctrl:'BR_ENCOUNTER_ADMITSOURCE',prop:'Title'},{av:'edtBR_Encounter_DischargeDate_Titleformat',ctrl:'BR_ENCOUNTER_DISCHARGEDATE',prop:'Titleformat'},{av:'edtBR_Encounter_DischargeDate_Title',ctrl:'BR_ENCOUNTER_DISCHARGEDATE',prop:'Title'},{av:'edtBR_Encounter_DischargeStatus_Titleformat',ctrl:'BR_ENCOUNTER_DISCHARGESTATUS',prop:'Titleformat'},{av:'edtBR_Encounter_DischargeStatus_Title',ctrl:'BR_ENCOUNTER_DISCHARGESTATUS',prop:'Title'},{av:'cmbBR_Encounter_Status'},{av:'edtBR_Information_ID_Titleformat',ctrl:'BR_INFORMATION_ID',prop:'Titleformat'},{av:'edtBR_Information_ID_Title',ctrl:'BR_INFORMATION_ID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'AV41GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV42GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV43GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE","{handler:'E11152',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV16ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Encounter_EncIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Encounter_DepartmentTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DEPARTMENTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Encounter_ENCTypeTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Encounter_AdmitDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ADMITDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Encounter_AdmitSourceTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ADMITSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_Encounter_DischargeDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DISCHARGEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_Encounter_DischargeStatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DISCHARGESTATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV50ddo_BR_Encounter_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV32ddo_BR_Information_IDTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_IDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV34ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'Gridpaginationbar_Selectedpage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE",",oparms:[]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE","{handler:'E12152',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV16ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Encounter_EncIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Encounter_DepartmentTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DEPARTMENTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Encounter_ENCTypeTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Encounter_AdmitDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ADMITDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Encounter_AdmitSourceTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ADMITSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_Encounter_DischargeDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DISCHARGEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_Encounter_DischargeStatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DISCHARGESTATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV50ddo_BR_Encounter_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV32ddo_BR_Information_IDTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_IDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV34ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'Gridpaginationbar_Rowsperpageselectedvalue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE",",oparms:[{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]}");
         setEventMetadata("DDO_BR_ENCOUNTERID.ONOPTIONCLICKED","{handler:'E13152',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV16ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Encounter_EncIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Encounter_DepartmentTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DEPARTMENTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Encounter_ENCTypeTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Encounter_AdmitDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ADMITDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Encounter_AdmitSourceTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ADMITSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_Encounter_DischargeDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DISCHARGEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_Encounter_DischargeStatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DISCHARGESTATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV50ddo_BR_Encounter_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV32ddo_BR_Information_IDTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_IDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV34ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_encounterid_Activeeventkey',ctrl:'DDO_BR_ENCOUNTERID',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_ENCOUNTERID.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_encounterid_Sortedstatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'AV15BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Encounter_EncIDTitleFilterData',fld:'vBR_ENCOUNTER_ENCIDTITLEFILTERDATA',pic:''},{av:'AV19BR_Encounter_DepartmentTitleFilterData',fld:'vBR_ENCOUNTER_DEPARTMENTTITLEFILTERDATA',pic:''},{av:'AV21BR_Encounter_ENCTypeTitleFilterData',fld:'vBR_ENCOUNTER_ENCTYPETITLEFILTERDATA',pic:''},{av:'AV23BR_Encounter_AdmitDateTitleFilterData',fld:'vBR_ENCOUNTER_ADMITDATETITLEFILTERDATA',pic:''},{av:'AV25BR_Encounter_AdmitSourceTitleFilterData',fld:'vBR_ENCOUNTER_ADMITSOURCETITLEFILTERDATA',pic:''},{av:'AV27BR_Encounter_DischargeDateTitleFilterData',fld:'vBR_ENCOUNTER_DISCHARGEDATETITLEFILTERDATA',pic:''},{av:'AV29BR_Encounter_DischargeStatusTitleFilterData',fld:'vBR_ENCOUNTER_DISCHARGESTATUSTITLEFILTERDATA',pic:''},{av:'AV49BR_Encounter_StatusTitleFilterData',fld:'vBR_ENCOUNTER_STATUSTITLEFILTERDATA',pic:''},{av:'AV31BR_Information_IDTitleFilterData',fld:'vBR_INFORMATION_IDTITLEFILTERDATA',pic:''},{av:'AV33BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Encounter_EncID_Titleformat',ctrl:'BR_ENCOUNTER_ENCID',prop:'Titleformat'},{av:'edtBR_Encounter_EncID_Title',ctrl:'BR_ENCOUNTER_ENCID',prop:'Title'},{av:'edtBR_Encounter_Department_Titleformat',ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Titleformat'},{av:'edtBR_Encounter_Department_Title',ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Title'},{av:'edtBR_Encounter_ENCType_Titleformat',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Titleformat'},{av:'edtBR_Encounter_ENCType_Title',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Title'},{av:'edtBR_Encounter_AdmitDate_Titleformat',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Titleformat'},{av:'edtBR_Encounter_AdmitDate_Title',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Title'},{av:'edtBR_Encounter_AdmitSource_Titleformat',ctrl:'BR_ENCOUNTER_ADMITSOURCE',prop:'Titleformat'},{av:'edtBR_Encounter_AdmitSource_Title',ctrl:'BR_ENCOUNTER_ADMITSOURCE',prop:'Title'},{av:'edtBR_Encounter_DischargeDate_Titleformat',ctrl:'BR_ENCOUNTER_DISCHARGEDATE',prop:'Titleformat'},{av:'edtBR_Encounter_DischargeDate_Title',ctrl:'BR_ENCOUNTER_DISCHARGEDATE',prop:'Title'},{av:'edtBR_Encounter_DischargeStatus_Titleformat',ctrl:'BR_ENCOUNTER_DISCHARGESTATUS',prop:'Titleformat'},{av:'edtBR_Encounter_DischargeStatus_Title',ctrl:'BR_ENCOUNTER_DISCHARGESTATUS',prop:'Title'},{av:'cmbBR_Encounter_Status'},{av:'edtBR_Information_ID_Titleformat',ctrl:'BR_INFORMATION_ID',prop:'Titleformat'},{av:'edtBR_Information_ID_Title',ctrl:'BR_INFORMATION_ID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'AV41GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV42GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV43GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_ENCOUNTER_ENCID.ONOPTIONCLICKED","{handler:'E14152',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV16ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Encounter_EncIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Encounter_DepartmentTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DEPARTMENTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Encounter_ENCTypeTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Encounter_AdmitDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ADMITDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Encounter_AdmitSourceTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ADMITSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_Encounter_DischargeDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DISCHARGEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_Encounter_DischargeStatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DISCHARGESTATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV50ddo_BR_Encounter_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV32ddo_BR_Information_IDTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_IDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV34ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_encounter_encid_Activeeventkey',ctrl:'DDO_BR_ENCOUNTER_ENCID',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_ENCOUNTER_ENCID.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_encounter_encid_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_ENCID',prop:'SortedStatus'},{av:'AV15BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Encounter_EncIDTitleFilterData',fld:'vBR_ENCOUNTER_ENCIDTITLEFILTERDATA',pic:''},{av:'AV19BR_Encounter_DepartmentTitleFilterData',fld:'vBR_ENCOUNTER_DEPARTMENTTITLEFILTERDATA',pic:''},{av:'AV21BR_Encounter_ENCTypeTitleFilterData',fld:'vBR_ENCOUNTER_ENCTYPETITLEFILTERDATA',pic:''},{av:'AV23BR_Encounter_AdmitDateTitleFilterData',fld:'vBR_ENCOUNTER_ADMITDATETITLEFILTERDATA',pic:''},{av:'AV25BR_Encounter_AdmitSourceTitleFilterData',fld:'vBR_ENCOUNTER_ADMITSOURCETITLEFILTERDATA',pic:''},{av:'AV27BR_Encounter_DischargeDateTitleFilterData',fld:'vBR_ENCOUNTER_DISCHARGEDATETITLEFILTERDATA',pic:''},{av:'AV29BR_Encounter_DischargeStatusTitleFilterData',fld:'vBR_ENCOUNTER_DISCHARGESTATUSTITLEFILTERDATA',pic:''},{av:'AV49BR_Encounter_StatusTitleFilterData',fld:'vBR_ENCOUNTER_STATUSTITLEFILTERDATA',pic:''},{av:'AV31BR_Information_IDTitleFilterData',fld:'vBR_INFORMATION_IDTITLEFILTERDATA',pic:''},{av:'AV33BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Encounter_EncID_Titleformat',ctrl:'BR_ENCOUNTER_ENCID',prop:'Titleformat'},{av:'edtBR_Encounter_EncID_Title',ctrl:'BR_ENCOUNTER_ENCID',prop:'Title'},{av:'edtBR_Encounter_Department_Titleformat',ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Titleformat'},{av:'edtBR_Encounter_Department_Title',ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Title'},{av:'edtBR_Encounter_ENCType_Titleformat',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Titleformat'},{av:'edtBR_Encounter_ENCType_Title',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Title'},{av:'edtBR_Encounter_AdmitDate_Titleformat',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Titleformat'},{av:'edtBR_Encounter_AdmitDate_Title',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Title'},{av:'edtBR_Encounter_AdmitSource_Titleformat',ctrl:'BR_ENCOUNTER_ADMITSOURCE',prop:'Titleformat'},{av:'edtBR_Encounter_AdmitSource_Title',ctrl:'BR_ENCOUNTER_ADMITSOURCE',prop:'Title'},{av:'edtBR_Encounter_DischargeDate_Titleformat',ctrl:'BR_ENCOUNTER_DISCHARGEDATE',prop:'Titleformat'},{av:'edtBR_Encounter_DischargeDate_Title',ctrl:'BR_ENCOUNTER_DISCHARGEDATE',prop:'Title'},{av:'edtBR_Encounter_DischargeStatus_Titleformat',ctrl:'BR_ENCOUNTER_DISCHARGESTATUS',prop:'Titleformat'},{av:'edtBR_Encounter_DischargeStatus_Title',ctrl:'BR_ENCOUNTER_DISCHARGESTATUS',prop:'Title'},{av:'cmbBR_Encounter_Status'},{av:'edtBR_Information_ID_Titleformat',ctrl:'BR_INFORMATION_ID',prop:'Titleformat'},{av:'edtBR_Information_ID_Title',ctrl:'BR_INFORMATION_ID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'AV41GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV42GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV43GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_ENCOUNTER_DEPARTMENT.ONOPTIONCLICKED","{handler:'E15152',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV16ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Encounter_EncIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Encounter_DepartmentTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DEPARTMENTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Encounter_ENCTypeTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Encounter_AdmitDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ADMITDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Encounter_AdmitSourceTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ADMITSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_Encounter_DischargeDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DISCHARGEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_Encounter_DischargeStatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DISCHARGESTATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV50ddo_BR_Encounter_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV32ddo_BR_Information_IDTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_IDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV34ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_encounter_department_Activeeventkey',ctrl:'DDO_BR_ENCOUNTER_DEPARTMENT',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_ENCOUNTER_DEPARTMENT.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_encounter_department_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_DEPARTMENT',prop:'SortedStatus'},{av:'AV15BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Encounter_EncIDTitleFilterData',fld:'vBR_ENCOUNTER_ENCIDTITLEFILTERDATA',pic:''},{av:'AV19BR_Encounter_DepartmentTitleFilterData',fld:'vBR_ENCOUNTER_DEPARTMENTTITLEFILTERDATA',pic:''},{av:'AV21BR_Encounter_ENCTypeTitleFilterData',fld:'vBR_ENCOUNTER_ENCTYPETITLEFILTERDATA',pic:''},{av:'AV23BR_Encounter_AdmitDateTitleFilterData',fld:'vBR_ENCOUNTER_ADMITDATETITLEFILTERDATA',pic:''},{av:'AV25BR_Encounter_AdmitSourceTitleFilterData',fld:'vBR_ENCOUNTER_ADMITSOURCETITLEFILTERDATA',pic:''},{av:'AV27BR_Encounter_DischargeDateTitleFilterData',fld:'vBR_ENCOUNTER_DISCHARGEDATETITLEFILTERDATA',pic:''},{av:'AV29BR_Encounter_DischargeStatusTitleFilterData',fld:'vBR_ENCOUNTER_DISCHARGESTATUSTITLEFILTERDATA',pic:''},{av:'AV49BR_Encounter_StatusTitleFilterData',fld:'vBR_ENCOUNTER_STATUSTITLEFILTERDATA',pic:''},{av:'AV31BR_Information_IDTitleFilterData',fld:'vBR_INFORMATION_IDTITLEFILTERDATA',pic:''},{av:'AV33BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Encounter_EncID_Titleformat',ctrl:'BR_ENCOUNTER_ENCID',prop:'Titleformat'},{av:'edtBR_Encounter_EncID_Title',ctrl:'BR_ENCOUNTER_ENCID',prop:'Title'},{av:'edtBR_Encounter_Department_Titleformat',ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Titleformat'},{av:'edtBR_Encounter_Department_Title',ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Title'},{av:'edtBR_Encounter_ENCType_Titleformat',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Titleformat'},{av:'edtBR_Encounter_ENCType_Title',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Title'},{av:'edtBR_Encounter_AdmitDate_Titleformat',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Titleformat'},{av:'edtBR_Encounter_AdmitDate_Title',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Title'},{av:'edtBR_Encounter_AdmitSource_Titleformat',ctrl:'BR_ENCOUNTER_ADMITSOURCE',prop:'Titleformat'},{av:'edtBR_Encounter_AdmitSource_Title',ctrl:'BR_ENCOUNTER_ADMITSOURCE',prop:'Title'},{av:'edtBR_Encounter_DischargeDate_Titleformat',ctrl:'BR_ENCOUNTER_DISCHARGEDATE',prop:'Titleformat'},{av:'edtBR_Encounter_DischargeDate_Title',ctrl:'BR_ENCOUNTER_DISCHARGEDATE',prop:'Title'},{av:'edtBR_Encounter_DischargeStatus_Titleformat',ctrl:'BR_ENCOUNTER_DISCHARGESTATUS',prop:'Titleformat'},{av:'edtBR_Encounter_DischargeStatus_Title',ctrl:'BR_ENCOUNTER_DISCHARGESTATUS',prop:'Title'},{av:'cmbBR_Encounter_Status'},{av:'edtBR_Information_ID_Titleformat',ctrl:'BR_INFORMATION_ID',prop:'Titleformat'},{av:'edtBR_Information_ID_Title',ctrl:'BR_INFORMATION_ID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'AV41GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV42GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV43GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_ENCOUNTER_ENCTYPE.ONOPTIONCLICKED","{handler:'E16152',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV16ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Encounter_EncIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Encounter_DepartmentTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DEPARTMENTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Encounter_ENCTypeTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Encounter_AdmitDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ADMITDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Encounter_AdmitSourceTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ADMITSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_Encounter_DischargeDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DISCHARGEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_Encounter_DischargeStatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DISCHARGESTATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV50ddo_BR_Encounter_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV32ddo_BR_Information_IDTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_IDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV34ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_encounter_enctype_Activeeventkey',ctrl:'DDO_BR_ENCOUNTER_ENCTYPE',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_ENCOUNTER_ENCTYPE.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_encounter_enctype_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_ENCTYPE',prop:'SortedStatus'},{av:'AV15BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Encounter_EncIDTitleFilterData',fld:'vBR_ENCOUNTER_ENCIDTITLEFILTERDATA',pic:''},{av:'AV19BR_Encounter_DepartmentTitleFilterData',fld:'vBR_ENCOUNTER_DEPARTMENTTITLEFILTERDATA',pic:''},{av:'AV21BR_Encounter_ENCTypeTitleFilterData',fld:'vBR_ENCOUNTER_ENCTYPETITLEFILTERDATA',pic:''},{av:'AV23BR_Encounter_AdmitDateTitleFilterData',fld:'vBR_ENCOUNTER_ADMITDATETITLEFILTERDATA',pic:''},{av:'AV25BR_Encounter_AdmitSourceTitleFilterData',fld:'vBR_ENCOUNTER_ADMITSOURCETITLEFILTERDATA',pic:''},{av:'AV27BR_Encounter_DischargeDateTitleFilterData',fld:'vBR_ENCOUNTER_DISCHARGEDATETITLEFILTERDATA',pic:''},{av:'AV29BR_Encounter_DischargeStatusTitleFilterData',fld:'vBR_ENCOUNTER_DISCHARGESTATUSTITLEFILTERDATA',pic:''},{av:'AV49BR_Encounter_StatusTitleFilterData',fld:'vBR_ENCOUNTER_STATUSTITLEFILTERDATA',pic:''},{av:'AV31BR_Information_IDTitleFilterData',fld:'vBR_INFORMATION_IDTITLEFILTERDATA',pic:''},{av:'AV33BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Encounter_EncID_Titleformat',ctrl:'BR_ENCOUNTER_ENCID',prop:'Titleformat'},{av:'edtBR_Encounter_EncID_Title',ctrl:'BR_ENCOUNTER_ENCID',prop:'Title'},{av:'edtBR_Encounter_Department_Titleformat',ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Titleformat'},{av:'edtBR_Encounter_Department_Title',ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Title'},{av:'edtBR_Encounter_ENCType_Titleformat',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Titleformat'},{av:'edtBR_Encounter_ENCType_Title',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Title'},{av:'edtBR_Encounter_AdmitDate_Titleformat',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Titleformat'},{av:'edtBR_Encounter_AdmitDate_Title',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Title'},{av:'edtBR_Encounter_AdmitSource_Titleformat',ctrl:'BR_ENCOUNTER_ADMITSOURCE',prop:'Titleformat'},{av:'edtBR_Encounter_AdmitSource_Title',ctrl:'BR_ENCOUNTER_ADMITSOURCE',prop:'Title'},{av:'edtBR_Encounter_DischargeDate_Titleformat',ctrl:'BR_ENCOUNTER_DISCHARGEDATE',prop:'Titleformat'},{av:'edtBR_Encounter_DischargeDate_Title',ctrl:'BR_ENCOUNTER_DISCHARGEDATE',prop:'Title'},{av:'edtBR_Encounter_DischargeStatus_Titleformat',ctrl:'BR_ENCOUNTER_DISCHARGESTATUS',prop:'Titleformat'},{av:'edtBR_Encounter_DischargeStatus_Title',ctrl:'BR_ENCOUNTER_DISCHARGESTATUS',prop:'Title'},{av:'cmbBR_Encounter_Status'},{av:'edtBR_Information_ID_Titleformat',ctrl:'BR_INFORMATION_ID',prop:'Titleformat'},{av:'edtBR_Information_ID_Title',ctrl:'BR_INFORMATION_ID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'AV41GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV42GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV43GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_ENCOUNTER_ADMITDATE.ONOPTIONCLICKED","{handler:'E17152',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV16ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Encounter_EncIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Encounter_DepartmentTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DEPARTMENTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Encounter_ENCTypeTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Encounter_AdmitDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ADMITDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Encounter_AdmitSourceTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ADMITSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_Encounter_DischargeDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DISCHARGEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_Encounter_DischargeStatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DISCHARGESTATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV50ddo_BR_Encounter_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV32ddo_BR_Information_IDTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_IDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV34ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_encounter_admitdate_Activeeventkey',ctrl:'DDO_BR_ENCOUNTER_ADMITDATE',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_ENCOUNTER_ADMITDATE.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_encounter_admitdate_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_ADMITDATE',prop:'SortedStatus'},{av:'AV15BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Encounter_EncIDTitleFilterData',fld:'vBR_ENCOUNTER_ENCIDTITLEFILTERDATA',pic:''},{av:'AV19BR_Encounter_DepartmentTitleFilterData',fld:'vBR_ENCOUNTER_DEPARTMENTTITLEFILTERDATA',pic:''},{av:'AV21BR_Encounter_ENCTypeTitleFilterData',fld:'vBR_ENCOUNTER_ENCTYPETITLEFILTERDATA',pic:''},{av:'AV23BR_Encounter_AdmitDateTitleFilterData',fld:'vBR_ENCOUNTER_ADMITDATETITLEFILTERDATA',pic:''},{av:'AV25BR_Encounter_AdmitSourceTitleFilterData',fld:'vBR_ENCOUNTER_ADMITSOURCETITLEFILTERDATA',pic:''},{av:'AV27BR_Encounter_DischargeDateTitleFilterData',fld:'vBR_ENCOUNTER_DISCHARGEDATETITLEFILTERDATA',pic:''},{av:'AV29BR_Encounter_DischargeStatusTitleFilterData',fld:'vBR_ENCOUNTER_DISCHARGESTATUSTITLEFILTERDATA',pic:''},{av:'AV49BR_Encounter_StatusTitleFilterData',fld:'vBR_ENCOUNTER_STATUSTITLEFILTERDATA',pic:''},{av:'AV31BR_Information_IDTitleFilterData',fld:'vBR_INFORMATION_IDTITLEFILTERDATA',pic:''},{av:'AV33BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Encounter_EncID_Titleformat',ctrl:'BR_ENCOUNTER_ENCID',prop:'Titleformat'},{av:'edtBR_Encounter_EncID_Title',ctrl:'BR_ENCOUNTER_ENCID',prop:'Title'},{av:'edtBR_Encounter_Department_Titleformat',ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Titleformat'},{av:'edtBR_Encounter_Department_Title',ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Title'},{av:'edtBR_Encounter_ENCType_Titleformat',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Titleformat'},{av:'edtBR_Encounter_ENCType_Title',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Title'},{av:'edtBR_Encounter_AdmitDate_Titleformat',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Titleformat'},{av:'edtBR_Encounter_AdmitDate_Title',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Title'},{av:'edtBR_Encounter_AdmitSource_Titleformat',ctrl:'BR_ENCOUNTER_ADMITSOURCE',prop:'Titleformat'},{av:'edtBR_Encounter_AdmitSource_Title',ctrl:'BR_ENCOUNTER_ADMITSOURCE',prop:'Title'},{av:'edtBR_Encounter_DischargeDate_Titleformat',ctrl:'BR_ENCOUNTER_DISCHARGEDATE',prop:'Titleformat'},{av:'edtBR_Encounter_DischargeDate_Title',ctrl:'BR_ENCOUNTER_DISCHARGEDATE',prop:'Title'},{av:'edtBR_Encounter_DischargeStatus_Titleformat',ctrl:'BR_ENCOUNTER_DISCHARGESTATUS',prop:'Titleformat'},{av:'edtBR_Encounter_DischargeStatus_Title',ctrl:'BR_ENCOUNTER_DISCHARGESTATUS',prop:'Title'},{av:'cmbBR_Encounter_Status'},{av:'edtBR_Information_ID_Titleformat',ctrl:'BR_INFORMATION_ID',prop:'Titleformat'},{av:'edtBR_Information_ID_Title',ctrl:'BR_INFORMATION_ID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'AV41GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV42GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV43GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_ENCOUNTER_ADMITSOURCE.ONOPTIONCLICKED","{handler:'E18152',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV16ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Encounter_EncIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Encounter_DepartmentTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DEPARTMENTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Encounter_ENCTypeTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Encounter_AdmitDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ADMITDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Encounter_AdmitSourceTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ADMITSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_Encounter_DischargeDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DISCHARGEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_Encounter_DischargeStatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DISCHARGESTATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV50ddo_BR_Encounter_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV32ddo_BR_Information_IDTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_IDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV34ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_encounter_admitsource_Activeeventkey',ctrl:'DDO_BR_ENCOUNTER_ADMITSOURCE',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_ENCOUNTER_ADMITSOURCE.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_encounter_admitsource_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_ADMITSOURCE',prop:'SortedStatus'},{av:'AV15BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Encounter_EncIDTitleFilterData',fld:'vBR_ENCOUNTER_ENCIDTITLEFILTERDATA',pic:''},{av:'AV19BR_Encounter_DepartmentTitleFilterData',fld:'vBR_ENCOUNTER_DEPARTMENTTITLEFILTERDATA',pic:''},{av:'AV21BR_Encounter_ENCTypeTitleFilterData',fld:'vBR_ENCOUNTER_ENCTYPETITLEFILTERDATA',pic:''},{av:'AV23BR_Encounter_AdmitDateTitleFilterData',fld:'vBR_ENCOUNTER_ADMITDATETITLEFILTERDATA',pic:''},{av:'AV25BR_Encounter_AdmitSourceTitleFilterData',fld:'vBR_ENCOUNTER_ADMITSOURCETITLEFILTERDATA',pic:''},{av:'AV27BR_Encounter_DischargeDateTitleFilterData',fld:'vBR_ENCOUNTER_DISCHARGEDATETITLEFILTERDATA',pic:''},{av:'AV29BR_Encounter_DischargeStatusTitleFilterData',fld:'vBR_ENCOUNTER_DISCHARGESTATUSTITLEFILTERDATA',pic:''},{av:'AV49BR_Encounter_StatusTitleFilterData',fld:'vBR_ENCOUNTER_STATUSTITLEFILTERDATA',pic:''},{av:'AV31BR_Information_IDTitleFilterData',fld:'vBR_INFORMATION_IDTITLEFILTERDATA',pic:''},{av:'AV33BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Encounter_EncID_Titleformat',ctrl:'BR_ENCOUNTER_ENCID',prop:'Titleformat'},{av:'edtBR_Encounter_EncID_Title',ctrl:'BR_ENCOUNTER_ENCID',prop:'Title'},{av:'edtBR_Encounter_Department_Titleformat',ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Titleformat'},{av:'edtBR_Encounter_Department_Title',ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Title'},{av:'edtBR_Encounter_ENCType_Titleformat',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Titleformat'},{av:'edtBR_Encounter_ENCType_Title',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Title'},{av:'edtBR_Encounter_AdmitDate_Titleformat',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Titleformat'},{av:'edtBR_Encounter_AdmitDate_Title',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Title'},{av:'edtBR_Encounter_AdmitSource_Titleformat',ctrl:'BR_ENCOUNTER_ADMITSOURCE',prop:'Titleformat'},{av:'edtBR_Encounter_AdmitSource_Title',ctrl:'BR_ENCOUNTER_ADMITSOURCE',prop:'Title'},{av:'edtBR_Encounter_DischargeDate_Titleformat',ctrl:'BR_ENCOUNTER_DISCHARGEDATE',prop:'Titleformat'},{av:'edtBR_Encounter_DischargeDate_Title',ctrl:'BR_ENCOUNTER_DISCHARGEDATE',prop:'Title'},{av:'edtBR_Encounter_DischargeStatus_Titleformat',ctrl:'BR_ENCOUNTER_DISCHARGESTATUS',prop:'Titleformat'},{av:'edtBR_Encounter_DischargeStatus_Title',ctrl:'BR_ENCOUNTER_DISCHARGESTATUS',prop:'Title'},{av:'cmbBR_Encounter_Status'},{av:'edtBR_Information_ID_Titleformat',ctrl:'BR_INFORMATION_ID',prop:'Titleformat'},{av:'edtBR_Information_ID_Title',ctrl:'BR_INFORMATION_ID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'AV41GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV42GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV43GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_ENCOUNTER_DISCHARGEDATE.ONOPTIONCLICKED","{handler:'E19152',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV16ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Encounter_EncIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Encounter_DepartmentTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DEPARTMENTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Encounter_ENCTypeTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Encounter_AdmitDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ADMITDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Encounter_AdmitSourceTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ADMITSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_Encounter_DischargeDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DISCHARGEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_Encounter_DischargeStatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DISCHARGESTATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV50ddo_BR_Encounter_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV32ddo_BR_Information_IDTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_IDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV34ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_encounter_dischargedate_Activeeventkey',ctrl:'DDO_BR_ENCOUNTER_DISCHARGEDATE',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_ENCOUNTER_DISCHARGEDATE.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_encounter_dischargedate_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_DISCHARGEDATE',prop:'SortedStatus'},{av:'AV15BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Encounter_EncIDTitleFilterData',fld:'vBR_ENCOUNTER_ENCIDTITLEFILTERDATA',pic:''},{av:'AV19BR_Encounter_DepartmentTitleFilterData',fld:'vBR_ENCOUNTER_DEPARTMENTTITLEFILTERDATA',pic:''},{av:'AV21BR_Encounter_ENCTypeTitleFilterData',fld:'vBR_ENCOUNTER_ENCTYPETITLEFILTERDATA',pic:''},{av:'AV23BR_Encounter_AdmitDateTitleFilterData',fld:'vBR_ENCOUNTER_ADMITDATETITLEFILTERDATA',pic:''},{av:'AV25BR_Encounter_AdmitSourceTitleFilterData',fld:'vBR_ENCOUNTER_ADMITSOURCETITLEFILTERDATA',pic:''},{av:'AV27BR_Encounter_DischargeDateTitleFilterData',fld:'vBR_ENCOUNTER_DISCHARGEDATETITLEFILTERDATA',pic:''},{av:'AV29BR_Encounter_DischargeStatusTitleFilterData',fld:'vBR_ENCOUNTER_DISCHARGESTATUSTITLEFILTERDATA',pic:''},{av:'AV49BR_Encounter_StatusTitleFilterData',fld:'vBR_ENCOUNTER_STATUSTITLEFILTERDATA',pic:''},{av:'AV31BR_Information_IDTitleFilterData',fld:'vBR_INFORMATION_IDTITLEFILTERDATA',pic:''},{av:'AV33BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Encounter_EncID_Titleformat',ctrl:'BR_ENCOUNTER_ENCID',prop:'Titleformat'},{av:'edtBR_Encounter_EncID_Title',ctrl:'BR_ENCOUNTER_ENCID',prop:'Title'},{av:'edtBR_Encounter_Department_Titleformat',ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Titleformat'},{av:'edtBR_Encounter_Department_Title',ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Title'},{av:'edtBR_Encounter_ENCType_Titleformat',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Titleformat'},{av:'edtBR_Encounter_ENCType_Title',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Title'},{av:'edtBR_Encounter_AdmitDate_Titleformat',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Titleformat'},{av:'edtBR_Encounter_AdmitDate_Title',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Title'},{av:'edtBR_Encounter_AdmitSource_Titleformat',ctrl:'BR_ENCOUNTER_ADMITSOURCE',prop:'Titleformat'},{av:'edtBR_Encounter_AdmitSource_Title',ctrl:'BR_ENCOUNTER_ADMITSOURCE',prop:'Title'},{av:'edtBR_Encounter_DischargeDate_Titleformat',ctrl:'BR_ENCOUNTER_DISCHARGEDATE',prop:'Titleformat'},{av:'edtBR_Encounter_DischargeDate_Title',ctrl:'BR_ENCOUNTER_DISCHARGEDATE',prop:'Title'},{av:'edtBR_Encounter_DischargeStatus_Titleformat',ctrl:'BR_ENCOUNTER_DISCHARGESTATUS',prop:'Titleformat'},{av:'edtBR_Encounter_DischargeStatus_Title',ctrl:'BR_ENCOUNTER_DISCHARGESTATUS',prop:'Title'},{av:'cmbBR_Encounter_Status'},{av:'edtBR_Information_ID_Titleformat',ctrl:'BR_INFORMATION_ID',prop:'Titleformat'},{av:'edtBR_Information_ID_Title',ctrl:'BR_INFORMATION_ID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'AV41GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV42GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV43GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_ENCOUNTER_DISCHARGESTATUS.ONOPTIONCLICKED","{handler:'E20152',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV16ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Encounter_EncIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Encounter_DepartmentTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DEPARTMENTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Encounter_ENCTypeTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Encounter_AdmitDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ADMITDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Encounter_AdmitSourceTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ADMITSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_Encounter_DischargeDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DISCHARGEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_Encounter_DischargeStatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DISCHARGESTATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV50ddo_BR_Encounter_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV32ddo_BR_Information_IDTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_IDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV34ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_encounter_dischargestatus_Activeeventkey',ctrl:'DDO_BR_ENCOUNTER_DISCHARGESTATUS',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_ENCOUNTER_DISCHARGESTATUS.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_encounter_dischargestatus_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_DISCHARGESTATUS',prop:'SortedStatus'},{av:'AV15BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Encounter_EncIDTitleFilterData',fld:'vBR_ENCOUNTER_ENCIDTITLEFILTERDATA',pic:''},{av:'AV19BR_Encounter_DepartmentTitleFilterData',fld:'vBR_ENCOUNTER_DEPARTMENTTITLEFILTERDATA',pic:''},{av:'AV21BR_Encounter_ENCTypeTitleFilterData',fld:'vBR_ENCOUNTER_ENCTYPETITLEFILTERDATA',pic:''},{av:'AV23BR_Encounter_AdmitDateTitleFilterData',fld:'vBR_ENCOUNTER_ADMITDATETITLEFILTERDATA',pic:''},{av:'AV25BR_Encounter_AdmitSourceTitleFilterData',fld:'vBR_ENCOUNTER_ADMITSOURCETITLEFILTERDATA',pic:''},{av:'AV27BR_Encounter_DischargeDateTitleFilterData',fld:'vBR_ENCOUNTER_DISCHARGEDATETITLEFILTERDATA',pic:''},{av:'AV29BR_Encounter_DischargeStatusTitleFilterData',fld:'vBR_ENCOUNTER_DISCHARGESTATUSTITLEFILTERDATA',pic:''},{av:'AV49BR_Encounter_StatusTitleFilterData',fld:'vBR_ENCOUNTER_STATUSTITLEFILTERDATA',pic:''},{av:'AV31BR_Information_IDTitleFilterData',fld:'vBR_INFORMATION_IDTITLEFILTERDATA',pic:''},{av:'AV33BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Encounter_EncID_Titleformat',ctrl:'BR_ENCOUNTER_ENCID',prop:'Titleformat'},{av:'edtBR_Encounter_EncID_Title',ctrl:'BR_ENCOUNTER_ENCID',prop:'Title'},{av:'edtBR_Encounter_Department_Titleformat',ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Titleformat'},{av:'edtBR_Encounter_Department_Title',ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Title'},{av:'edtBR_Encounter_ENCType_Titleformat',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Titleformat'},{av:'edtBR_Encounter_ENCType_Title',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Title'},{av:'edtBR_Encounter_AdmitDate_Titleformat',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Titleformat'},{av:'edtBR_Encounter_AdmitDate_Title',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Title'},{av:'edtBR_Encounter_AdmitSource_Titleformat',ctrl:'BR_ENCOUNTER_ADMITSOURCE',prop:'Titleformat'},{av:'edtBR_Encounter_AdmitSource_Title',ctrl:'BR_ENCOUNTER_ADMITSOURCE',prop:'Title'},{av:'edtBR_Encounter_DischargeDate_Titleformat',ctrl:'BR_ENCOUNTER_DISCHARGEDATE',prop:'Titleformat'},{av:'edtBR_Encounter_DischargeDate_Title',ctrl:'BR_ENCOUNTER_DISCHARGEDATE',prop:'Title'},{av:'edtBR_Encounter_DischargeStatus_Titleformat',ctrl:'BR_ENCOUNTER_DISCHARGESTATUS',prop:'Titleformat'},{av:'edtBR_Encounter_DischargeStatus_Title',ctrl:'BR_ENCOUNTER_DISCHARGESTATUS',prop:'Title'},{av:'cmbBR_Encounter_Status'},{av:'edtBR_Information_ID_Titleformat',ctrl:'BR_INFORMATION_ID',prop:'Titleformat'},{av:'edtBR_Information_ID_Title',ctrl:'BR_INFORMATION_ID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'AV41GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV42GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV43GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_ENCOUNTER_STATUS.ONOPTIONCLICKED","{handler:'E21152',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV16ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Encounter_EncIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Encounter_DepartmentTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DEPARTMENTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Encounter_ENCTypeTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Encounter_AdmitDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ADMITDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Encounter_AdmitSourceTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ADMITSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_Encounter_DischargeDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DISCHARGEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_Encounter_DischargeStatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DISCHARGESTATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV50ddo_BR_Encounter_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV32ddo_BR_Information_IDTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_IDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV34ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_encounter_status_Activeeventkey',ctrl:'DDO_BR_ENCOUNTER_STATUS',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_ENCOUNTER_STATUS.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_encounter_status_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_STATUS',prop:'SortedStatus'},{av:'AV15BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Encounter_EncIDTitleFilterData',fld:'vBR_ENCOUNTER_ENCIDTITLEFILTERDATA',pic:''},{av:'AV19BR_Encounter_DepartmentTitleFilterData',fld:'vBR_ENCOUNTER_DEPARTMENTTITLEFILTERDATA',pic:''},{av:'AV21BR_Encounter_ENCTypeTitleFilterData',fld:'vBR_ENCOUNTER_ENCTYPETITLEFILTERDATA',pic:''},{av:'AV23BR_Encounter_AdmitDateTitleFilterData',fld:'vBR_ENCOUNTER_ADMITDATETITLEFILTERDATA',pic:''},{av:'AV25BR_Encounter_AdmitSourceTitleFilterData',fld:'vBR_ENCOUNTER_ADMITSOURCETITLEFILTERDATA',pic:''},{av:'AV27BR_Encounter_DischargeDateTitleFilterData',fld:'vBR_ENCOUNTER_DISCHARGEDATETITLEFILTERDATA',pic:''},{av:'AV29BR_Encounter_DischargeStatusTitleFilterData',fld:'vBR_ENCOUNTER_DISCHARGESTATUSTITLEFILTERDATA',pic:''},{av:'AV49BR_Encounter_StatusTitleFilterData',fld:'vBR_ENCOUNTER_STATUSTITLEFILTERDATA',pic:''},{av:'AV31BR_Information_IDTitleFilterData',fld:'vBR_INFORMATION_IDTITLEFILTERDATA',pic:''},{av:'AV33BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Encounter_EncID_Titleformat',ctrl:'BR_ENCOUNTER_ENCID',prop:'Titleformat'},{av:'edtBR_Encounter_EncID_Title',ctrl:'BR_ENCOUNTER_ENCID',prop:'Title'},{av:'edtBR_Encounter_Department_Titleformat',ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Titleformat'},{av:'edtBR_Encounter_Department_Title',ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Title'},{av:'edtBR_Encounter_ENCType_Titleformat',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Titleformat'},{av:'edtBR_Encounter_ENCType_Title',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Title'},{av:'edtBR_Encounter_AdmitDate_Titleformat',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Titleformat'},{av:'edtBR_Encounter_AdmitDate_Title',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Title'},{av:'edtBR_Encounter_AdmitSource_Titleformat',ctrl:'BR_ENCOUNTER_ADMITSOURCE',prop:'Titleformat'},{av:'edtBR_Encounter_AdmitSource_Title',ctrl:'BR_ENCOUNTER_ADMITSOURCE',prop:'Title'},{av:'edtBR_Encounter_DischargeDate_Titleformat',ctrl:'BR_ENCOUNTER_DISCHARGEDATE',prop:'Titleformat'},{av:'edtBR_Encounter_DischargeDate_Title',ctrl:'BR_ENCOUNTER_DISCHARGEDATE',prop:'Title'},{av:'edtBR_Encounter_DischargeStatus_Titleformat',ctrl:'BR_ENCOUNTER_DISCHARGESTATUS',prop:'Titleformat'},{av:'edtBR_Encounter_DischargeStatus_Title',ctrl:'BR_ENCOUNTER_DISCHARGESTATUS',prop:'Title'},{av:'cmbBR_Encounter_Status'},{av:'edtBR_Information_ID_Titleformat',ctrl:'BR_INFORMATION_ID',prop:'Titleformat'},{av:'edtBR_Information_ID_Title',ctrl:'BR_INFORMATION_ID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'AV41GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV42GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV43GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_INFORMATION_ID.ONOPTIONCLICKED","{handler:'E22152',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV16ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Encounter_EncIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Encounter_DepartmentTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DEPARTMENTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Encounter_ENCTypeTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Encounter_AdmitDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ADMITDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Encounter_AdmitSourceTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ADMITSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_Encounter_DischargeDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DISCHARGEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_Encounter_DischargeStatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DISCHARGESTATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV50ddo_BR_Encounter_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV32ddo_BR_Information_IDTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_IDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV34ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_information_id_Activeeventkey',ctrl:'DDO_BR_INFORMATION_ID',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_INFORMATION_ID.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_information_id_Sortedstatus',ctrl:'DDO_BR_INFORMATION_ID',prop:'SortedStatus'},{av:'AV15BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Encounter_EncIDTitleFilterData',fld:'vBR_ENCOUNTER_ENCIDTITLEFILTERDATA',pic:''},{av:'AV19BR_Encounter_DepartmentTitleFilterData',fld:'vBR_ENCOUNTER_DEPARTMENTTITLEFILTERDATA',pic:''},{av:'AV21BR_Encounter_ENCTypeTitleFilterData',fld:'vBR_ENCOUNTER_ENCTYPETITLEFILTERDATA',pic:''},{av:'AV23BR_Encounter_AdmitDateTitleFilterData',fld:'vBR_ENCOUNTER_ADMITDATETITLEFILTERDATA',pic:''},{av:'AV25BR_Encounter_AdmitSourceTitleFilterData',fld:'vBR_ENCOUNTER_ADMITSOURCETITLEFILTERDATA',pic:''},{av:'AV27BR_Encounter_DischargeDateTitleFilterData',fld:'vBR_ENCOUNTER_DISCHARGEDATETITLEFILTERDATA',pic:''},{av:'AV29BR_Encounter_DischargeStatusTitleFilterData',fld:'vBR_ENCOUNTER_DISCHARGESTATUSTITLEFILTERDATA',pic:''},{av:'AV49BR_Encounter_StatusTitleFilterData',fld:'vBR_ENCOUNTER_STATUSTITLEFILTERDATA',pic:''},{av:'AV31BR_Information_IDTitleFilterData',fld:'vBR_INFORMATION_IDTITLEFILTERDATA',pic:''},{av:'AV33BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Encounter_EncID_Titleformat',ctrl:'BR_ENCOUNTER_ENCID',prop:'Titleformat'},{av:'edtBR_Encounter_EncID_Title',ctrl:'BR_ENCOUNTER_ENCID',prop:'Title'},{av:'edtBR_Encounter_Department_Titleformat',ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Titleformat'},{av:'edtBR_Encounter_Department_Title',ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Title'},{av:'edtBR_Encounter_ENCType_Titleformat',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Titleformat'},{av:'edtBR_Encounter_ENCType_Title',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Title'},{av:'edtBR_Encounter_AdmitDate_Titleformat',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Titleformat'},{av:'edtBR_Encounter_AdmitDate_Title',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Title'},{av:'edtBR_Encounter_AdmitSource_Titleformat',ctrl:'BR_ENCOUNTER_ADMITSOURCE',prop:'Titleformat'},{av:'edtBR_Encounter_AdmitSource_Title',ctrl:'BR_ENCOUNTER_ADMITSOURCE',prop:'Title'},{av:'edtBR_Encounter_DischargeDate_Titleformat',ctrl:'BR_ENCOUNTER_DISCHARGEDATE',prop:'Titleformat'},{av:'edtBR_Encounter_DischargeDate_Title',ctrl:'BR_ENCOUNTER_DISCHARGEDATE',prop:'Title'},{av:'edtBR_Encounter_DischargeStatus_Titleformat',ctrl:'BR_ENCOUNTER_DISCHARGESTATUS',prop:'Titleformat'},{av:'edtBR_Encounter_DischargeStatus_Title',ctrl:'BR_ENCOUNTER_DISCHARGESTATUS',prop:'Title'},{av:'cmbBR_Encounter_Status'},{av:'edtBR_Information_ID_Titleformat',ctrl:'BR_INFORMATION_ID',prop:'Titleformat'},{av:'edtBR_Information_ID_Title',ctrl:'BR_INFORMATION_ID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'AV41GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV42GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV43GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_INFORMATION_PATIENTNO.ONOPTIONCLICKED","{handler:'E23152',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV16ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Encounter_EncIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Encounter_DepartmentTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DEPARTMENTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Encounter_ENCTypeTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Encounter_AdmitDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ADMITDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Encounter_AdmitSourceTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ADMITSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_Encounter_DischargeDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DISCHARGEDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_Encounter_DischargeStatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DISCHARGESTATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV50ddo_BR_Encounter_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV32ddo_BR_Information_IDTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_IDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV34ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_information_patientno_Activeeventkey',ctrl:'DDO_BR_INFORMATION_PATIENTNO',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_INFORMATION_PATIENTNO.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_information_patientno_Sortedstatus',ctrl:'DDO_BR_INFORMATION_PATIENTNO',prop:'SortedStatus'},{av:'AV15BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Encounter_EncIDTitleFilterData',fld:'vBR_ENCOUNTER_ENCIDTITLEFILTERDATA',pic:''},{av:'AV19BR_Encounter_DepartmentTitleFilterData',fld:'vBR_ENCOUNTER_DEPARTMENTTITLEFILTERDATA',pic:''},{av:'AV21BR_Encounter_ENCTypeTitleFilterData',fld:'vBR_ENCOUNTER_ENCTYPETITLEFILTERDATA',pic:''},{av:'AV23BR_Encounter_AdmitDateTitleFilterData',fld:'vBR_ENCOUNTER_ADMITDATETITLEFILTERDATA',pic:''},{av:'AV25BR_Encounter_AdmitSourceTitleFilterData',fld:'vBR_ENCOUNTER_ADMITSOURCETITLEFILTERDATA',pic:''},{av:'AV27BR_Encounter_DischargeDateTitleFilterData',fld:'vBR_ENCOUNTER_DISCHARGEDATETITLEFILTERDATA',pic:''},{av:'AV29BR_Encounter_DischargeStatusTitleFilterData',fld:'vBR_ENCOUNTER_DISCHARGESTATUSTITLEFILTERDATA',pic:''},{av:'AV49BR_Encounter_StatusTitleFilterData',fld:'vBR_ENCOUNTER_STATUSTITLEFILTERDATA',pic:''},{av:'AV31BR_Information_IDTitleFilterData',fld:'vBR_INFORMATION_IDTITLEFILTERDATA',pic:''},{av:'AV33BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Encounter_EncID_Titleformat',ctrl:'BR_ENCOUNTER_ENCID',prop:'Titleformat'},{av:'edtBR_Encounter_EncID_Title',ctrl:'BR_ENCOUNTER_ENCID',prop:'Title'},{av:'edtBR_Encounter_Department_Titleformat',ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Titleformat'},{av:'edtBR_Encounter_Department_Title',ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Title'},{av:'edtBR_Encounter_ENCType_Titleformat',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Titleformat'},{av:'edtBR_Encounter_ENCType_Title',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Title'},{av:'edtBR_Encounter_AdmitDate_Titleformat',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Titleformat'},{av:'edtBR_Encounter_AdmitDate_Title',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Title'},{av:'edtBR_Encounter_AdmitSource_Titleformat',ctrl:'BR_ENCOUNTER_ADMITSOURCE',prop:'Titleformat'},{av:'edtBR_Encounter_AdmitSource_Title',ctrl:'BR_ENCOUNTER_ADMITSOURCE',prop:'Title'},{av:'edtBR_Encounter_DischargeDate_Titleformat',ctrl:'BR_ENCOUNTER_DISCHARGEDATE',prop:'Titleformat'},{av:'edtBR_Encounter_DischargeDate_Title',ctrl:'BR_ENCOUNTER_DISCHARGEDATE',prop:'Title'},{av:'edtBR_Encounter_DischargeStatus_Titleformat',ctrl:'BR_ENCOUNTER_DISCHARGESTATUS',prop:'Titleformat'},{av:'edtBR_Encounter_DischargeStatus_Title',ctrl:'BR_ENCOUNTER_DISCHARGESTATUS',prop:'Title'},{av:'cmbBR_Encounter_Status'},{av:'edtBR_Information_ID_Titleformat',ctrl:'BR_INFORMATION_ID',prop:'Titleformat'},{av:'edtBR_Information_ID_Title',ctrl:'BR_INFORMATION_ID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'AV41GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV42GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV43GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("GRID.LOAD","{handler:'E26152',iparms:[]");
         setEventMetadata("GRID.LOAD",",oparms:[{av:'AV44Select',fld:'vSELECT',pic:''},{av:'edtavSelect_Tooltiptext',ctrl:'vSELECT',prop:'Tooltiptext'}]}");
         setEventMetadata("ENTER","{handler:'E27152',iparms:[{av:'A19BR_EncounterID',fld:'BR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[{av:'AV8InOutBR_EncounterID',fld:'vINOUTBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'}]}");
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
         Ddo_br_encounter_encid_Activeeventkey = "";
         Ddo_br_encounter_department_Activeeventkey = "";
         Ddo_br_encounter_enctype_Activeeventkey = "";
         Ddo_br_encounter_admitdate_Activeeventkey = "";
         Ddo_br_encounter_admitsource_Activeeventkey = "";
         Ddo_br_encounter_dischargedate_Activeeventkey = "";
         Ddo_br_encounter_dischargestatus_Activeeventkey = "";
         Ddo_br_encounter_status_Activeeventkey = "";
         Ddo_br_information_id_Activeeventkey = "";
         Ddo_br_information_patientno_Activeeventkey = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV16ddo_BR_EncounterIDTitleControlIdToReplace = "";
         AV18ddo_BR_Encounter_EncIDTitleControlIdToReplace = "";
         AV20ddo_BR_Encounter_DepartmentTitleControlIdToReplace = "";
         AV22ddo_BR_Encounter_ENCTypeTitleControlIdToReplace = "";
         AV24ddo_BR_Encounter_AdmitDateTitleControlIdToReplace = "";
         AV26ddo_BR_Encounter_AdmitSourceTitleControlIdToReplace = "";
         AV28ddo_BR_Encounter_DischargeDateTitleControlIdToReplace = "";
         AV30ddo_BR_Encounter_DischargeStatusTitleControlIdToReplace = "";
         AV50ddo_BR_Encounter_StatusTitleControlIdToReplace = "";
         AV32ddo_BR_Information_IDTitleControlIdToReplace = "";
         AV34ddo_BR_Information_PatientNoTitleControlIdToReplace = "";
         GXKey = "";
         AV77Pgmname = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         AV39DDO_TitleSettingsIcons = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV15BR_EncounterIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV17BR_Encounter_EncIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV19BR_Encounter_DepartmentTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV21BR_Encounter_ENCTypeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV23BR_Encounter_AdmitDateTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV25BR_Encounter_AdmitSourceTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV27BR_Encounter_DischargeDateTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV29BR_Encounter_DischargeStatusTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV49BR_Encounter_StatusTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV31BR_Information_IDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV33BR_Information_PatientNoTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         Ddo_br_encounterid_Sortedstatus = "";
         Ddo_br_encounter_encid_Sortedstatus = "";
         Ddo_br_encounter_department_Sortedstatus = "";
         Ddo_br_encounter_enctype_Sortedstatus = "";
         Ddo_br_encounter_admitdate_Sortedstatus = "";
         Ddo_br_encounter_admitsource_Sortedstatus = "";
         Ddo_br_encounter_dischargedate_Sortedstatus = "";
         Ddo_br_encounter_dischargestatus_Sortedstatus = "";
         Ddo_br_encounter_status_Sortedstatus = "";
         Ddo_br_information_id_Sortedstatus = "";
         Ddo_br_information_patientno_Sortedstatus = "";
         GX_FocusControl = "";
         sPrefix = "";
         GridContainer = new GXWebGrid( context);
         sStyleString = "";
         subGrid_Linesclass = "";
         GridColumn = new GXWebColumn();
         AV44Select = "";
         A84BR_Encounter_Department = "";
         A90BR_Encounter_ENCType = "";
         A91BR_Encounter_AdmitDate = DateTime.MinValue;
         A92BR_Encounter_AdmitSource = "";
         A93BR_Encounter_DischargeDate = DateTime.MinValue;
         A94BR_Encounter_DischargeStatus = "";
         A36BR_Information_PatientNo = "";
         ucGridpaginationbar = new GXUserControl();
         ucDdo_br_encounterid = new GXUserControl();
         TempTags = "";
         ClassString = "";
         StyleString = "";
         ucDdo_br_encounter_encid = new GXUserControl();
         ucDdo_br_encounter_department = new GXUserControl();
         ucDdo_br_encounter_enctype = new GXUserControl();
         ucDdo_br_encounter_admitdate = new GXUserControl();
         ucDdo_br_encounter_admitsource = new GXUserControl();
         ucDdo_br_encounter_dischargedate = new GXUserControl();
         ucDdo_br_encounter_dischargestatus = new GXUserControl();
         ucDdo_br_encounter_status = new GXUserControl();
         ucDdo_br_information_id = new GXUserControl();
         ucDdo_br_information_patientno = new GXUserControl();
         ucWorkwithplusutilities1 = new GXUserControl();
         Form = new GXWebForm();
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV78Select_GXI = "";
         scmdbuf = "";
         H00152_A36BR_Information_PatientNo = new String[] {""} ;
         H00152_n36BR_Information_PatientNo = new bool[] {false} ;
         H00152_A85BR_Information_ID = new long[1] ;
         H00152_n85BR_Information_ID = new bool[] {false} ;
         H00152_A172BR_Encounter_Status = new short[1] ;
         H00152_n172BR_Encounter_Status = new bool[] {false} ;
         H00152_A94BR_Encounter_DischargeStatus = new String[] {""} ;
         H00152_n94BR_Encounter_DischargeStatus = new bool[] {false} ;
         H00152_A93BR_Encounter_DischargeDate = new DateTime[] {DateTime.MinValue} ;
         H00152_n93BR_Encounter_DischargeDate = new bool[] {false} ;
         H00152_A92BR_Encounter_AdmitSource = new String[] {""} ;
         H00152_n92BR_Encounter_AdmitSource = new bool[] {false} ;
         H00152_A91BR_Encounter_AdmitDate = new DateTime[] {DateTime.MinValue} ;
         H00152_n91BR_Encounter_AdmitDate = new bool[] {false} ;
         H00152_A90BR_Encounter_ENCType = new String[] {""} ;
         H00152_n90BR_Encounter_ENCType = new bool[] {false} ;
         H00152_A84BR_Encounter_Department = new String[] {""} ;
         H00152_n84BR_Encounter_Department = new bool[] {false} ;
         H00152_A35BR_Encounter_EncID = new long[1] ;
         H00152_n35BR_Encounter_EncID = new bool[] {false} ;
         H00152_A19BR_EncounterID = new long[1] ;
         H00153_AGRID_nRecordCount = new long[1] ;
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV6WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         GridRow = new GXWebRow();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sImgUrl = "";
         ROClassString = "";
         GXCCtl = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_encounterprompt__default(),
            new Object[][] {
                new Object[] {
               H00152_A36BR_Information_PatientNo, H00152_n36BR_Information_PatientNo, H00152_A85BR_Information_ID, H00152_n85BR_Information_ID, H00152_A172BR_Encounter_Status, H00152_n172BR_Encounter_Status, H00152_A94BR_Encounter_DischargeStatus, H00152_n94BR_Encounter_DischargeStatus, H00152_A93BR_Encounter_DischargeDate, H00152_n93BR_Encounter_DischargeDate,
               H00152_A92BR_Encounter_AdmitSource, H00152_n92BR_Encounter_AdmitSource, H00152_A91BR_Encounter_AdmitDate, H00152_n91BR_Encounter_AdmitDate, H00152_A90BR_Encounter_ENCType, H00152_n90BR_Encounter_ENCType, H00152_A84BR_Encounter_Department, H00152_n84BR_Encounter_Department, H00152_A35BR_Encounter_EncID, H00152_n35BR_Encounter_EncID,
               H00152_A19BR_EncounterID
               }
               , new Object[] {
               H00153_AGRID_nRecordCount
               }
            }
         );
         AV77Pgmname = "BR_EncounterPrompt";
         /* GeneXus formulas. */
         AV77Pgmname = "BR_EncounterPrompt";
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
      private short edtBR_EncounterID_Titleformat ;
      private short edtBR_Encounter_EncID_Titleformat ;
      private short edtBR_Encounter_Department_Titleformat ;
      private short edtBR_Encounter_ENCType_Titleformat ;
      private short edtBR_Encounter_AdmitDate_Titleformat ;
      private short edtBR_Encounter_AdmitSource_Titleformat ;
      private short edtBR_Encounter_DischargeDate_Titleformat ;
      private short edtBR_Encounter_DischargeStatus_Titleformat ;
      private short cmbBR_Encounter_Status_Titleformat ;
      private short edtBR_Information_ID_Titleformat ;
      private short edtBR_Information_PatientNo_Titleformat ;
      private short subGrid_Sortable ;
      private short A172BR_Encounter_Status ;
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
      private int edtavDdo_br_encounteridtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_encounter_encidtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_encounter_departmenttitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_encounter_enctypetitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_encounter_admitdatetitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_encounter_admitsourcetitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_encounter_dischargedatetitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_encounter_dischargestatustitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_encounter_statustitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_information_idtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_information_patientnotitlecontrolidtoreplace_Visible ;
      private int edtavOrderedby_Visible ;
      private int edtavOrdereddsc_Visible ;
      private int subGrid_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int AV40PageToGo ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private int edtavSelect_Enabled ;
      private int edtavSelect_Visible ;
      private long AV8InOutBR_EncounterID ;
      private long wcpOAV8InOutBR_EncounterID ;
      private long GRID_nFirstRecordOnPage ;
      private long AV41GridCurrentPage ;
      private long AV43GridRecordCount ;
      private long AV42GridPageSize ;
      private long A19BR_EncounterID ;
      private long A35BR_Encounter_EncID ;
      private long A85BR_Information_ID ;
      private long GRID_nCurrentRecord ;
      private long GRID_nRecordCount ;
      private String Gridpaginationbar_Selectedpage ;
      private String Ddo_br_encounterid_Activeeventkey ;
      private String Ddo_br_encounter_encid_Activeeventkey ;
      private String Ddo_br_encounter_department_Activeeventkey ;
      private String Ddo_br_encounter_enctype_Activeeventkey ;
      private String Ddo_br_encounter_admitdate_Activeeventkey ;
      private String Ddo_br_encounter_admitsource_Activeeventkey ;
      private String Ddo_br_encounter_dischargedate_Activeeventkey ;
      private String Ddo_br_encounter_dischargestatus_Activeeventkey ;
      private String Ddo_br_encounter_status_Activeeventkey ;
      private String Ddo_br_information_id_Activeeventkey ;
      private String Ddo_br_information_patientno_Activeeventkey ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_12_idx="0001" ;
      private String GXKey ;
      private String AV77Pgmname ;
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
      private String Ddo_br_encounterid_Caption ;
      private String Ddo_br_encounterid_Tooltip ;
      private String Ddo_br_encounterid_Cls ;
      private String Ddo_br_encounterid_Dropdownoptionstype ;
      private String Ddo_br_encounterid_Titlecontrolidtoreplace ;
      private String Ddo_br_encounterid_Sortedstatus ;
      private String Ddo_br_encounterid_Sortasc ;
      private String Ddo_br_encounterid_Sortdsc ;
      private String Ddo_br_encounterid_Searchbuttontext ;
      private String Ddo_br_encounter_encid_Caption ;
      private String Ddo_br_encounter_encid_Tooltip ;
      private String Ddo_br_encounter_encid_Cls ;
      private String Ddo_br_encounter_encid_Dropdownoptionstype ;
      private String Ddo_br_encounter_encid_Titlecontrolidtoreplace ;
      private String Ddo_br_encounter_encid_Sortedstatus ;
      private String Ddo_br_encounter_encid_Sortasc ;
      private String Ddo_br_encounter_encid_Sortdsc ;
      private String Ddo_br_encounter_encid_Searchbuttontext ;
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
      private String Ddo_br_encounter_admitsource_Caption ;
      private String Ddo_br_encounter_admitsource_Tooltip ;
      private String Ddo_br_encounter_admitsource_Cls ;
      private String Ddo_br_encounter_admitsource_Dropdownoptionstype ;
      private String Ddo_br_encounter_admitsource_Titlecontrolidtoreplace ;
      private String Ddo_br_encounter_admitsource_Sortedstatus ;
      private String Ddo_br_encounter_admitsource_Sortasc ;
      private String Ddo_br_encounter_admitsource_Sortdsc ;
      private String Ddo_br_encounter_admitsource_Searchbuttontext ;
      private String Ddo_br_encounter_dischargedate_Caption ;
      private String Ddo_br_encounter_dischargedate_Tooltip ;
      private String Ddo_br_encounter_dischargedate_Cls ;
      private String Ddo_br_encounter_dischargedate_Dropdownoptionstype ;
      private String Ddo_br_encounter_dischargedate_Titlecontrolidtoreplace ;
      private String Ddo_br_encounter_dischargedate_Sortedstatus ;
      private String Ddo_br_encounter_dischargedate_Sortasc ;
      private String Ddo_br_encounter_dischargedate_Sortdsc ;
      private String Ddo_br_encounter_dischargedate_Searchbuttontext ;
      private String Ddo_br_encounter_dischargestatus_Caption ;
      private String Ddo_br_encounter_dischargestatus_Tooltip ;
      private String Ddo_br_encounter_dischargestatus_Cls ;
      private String Ddo_br_encounter_dischargestatus_Dropdownoptionstype ;
      private String Ddo_br_encounter_dischargestatus_Titlecontrolidtoreplace ;
      private String Ddo_br_encounter_dischargestatus_Sortedstatus ;
      private String Ddo_br_encounter_dischargestatus_Sortasc ;
      private String Ddo_br_encounter_dischargestatus_Sortdsc ;
      private String Ddo_br_encounter_dischargestatus_Searchbuttontext ;
      private String Ddo_br_encounter_status_Caption ;
      private String Ddo_br_encounter_status_Tooltip ;
      private String Ddo_br_encounter_status_Cls ;
      private String Ddo_br_encounter_status_Dropdownoptionstype ;
      private String Ddo_br_encounter_status_Titlecontrolidtoreplace ;
      private String Ddo_br_encounter_status_Sortedstatus ;
      private String Ddo_br_encounter_status_Sortasc ;
      private String Ddo_br_encounter_status_Sortdsc ;
      private String Ddo_br_encounter_status_Searchbuttontext ;
      private String Ddo_br_information_id_Caption ;
      private String Ddo_br_information_id_Tooltip ;
      private String Ddo_br_information_id_Cls ;
      private String Ddo_br_information_id_Dropdownoptionstype ;
      private String Ddo_br_information_id_Titlecontrolidtoreplace ;
      private String Ddo_br_information_id_Sortedstatus ;
      private String Ddo_br_information_id_Sortasc ;
      private String Ddo_br_information_id_Sortdsc ;
      private String Ddo_br_information_id_Searchbuttontext ;
      private String Ddo_br_information_patientno_Caption ;
      private String Ddo_br_information_patientno_Tooltip ;
      private String Ddo_br_information_patientno_Cls ;
      private String Ddo_br_information_patientno_Dropdownoptionstype ;
      private String Ddo_br_information_patientno_Titlecontrolidtoreplace ;
      private String Ddo_br_information_patientno_Sortedstatus ;
      private String Ddo_br_information_patientno_Sortasc ;
      private String Ddo_br_information_patientno_Sortdsc ;
      private String Ddo_br_information_patientno_Searchbuttontext ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divLayoutmaintable_Internalname ;
      private String divTablemain_Internalname ;
      private String divGridtablewithpaginationbar_Internalname ;
      private String sStyleString ;
      private String subGrid_Internalname ;
      private String subGrid_Class ;
      private String subGrid_Linesclass ;
      private String edtBR_EncounterID_Title ;
      private String edtBR_Encounter_EncID_Title ;
      private String edtBR_Encounter_Department_Title ;
      private String edtBR_Encounter_ENCType_Title ;
      private String edtBR_Encounter_AdmitDate_Title ;
      private String edtBR_Encounter_AdmitSource_Title ;
      private String edtBR_Encounter_DischargeDate_Title ;
      private String edtBR_Encounter_DischargeStatus_Title ;
      private String edtBR_Information_ID_Title ;
      private String edtBR_Information_PatientNo_Title ;
      private String subGrid_Header ;
      private String edtavSelect_Tooltiptext ;
      private String divHtml_gridpaginationbar_Internalname ;
      private String Gridpaginationbar_Internalname ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String Ddo_br_encounterid_Internalname ;
      private String TempTags ;
      private String ClassString ;
      private String StyleString ;
      private String edtavDdo_br_encounteridtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_encounter_encid_Internalname ;
      private String edtavDdo_br_encounter_encidtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_encounter_department_Internalname ;
      private String edtavDdo_br_encounter_departmenttitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_encounter_enctype_Internalname ;
      private String edtavDdo_br_encounter_enctypetitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_encounter_admitdate_Internalname ;
      private String edtavDdo_br_encounter_admitdatetitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_encounter_admitsource_Internalname ;
      private String edtavDdo_br_encounter_admitsourcetitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_encounter_dischargedate_Internalname ;
      private String edtavDdo_br_encounter_dischargedatetitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_encounter_dischargestatus_Internalname ;
      private String edtavDdo_br_encounter_dischargestatustitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_encounter_status_Internalname ;
      private String edtavDdo_br_encounter_statustitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_information_id_Internalname ;
      private String edtavDdo_br_information_idtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_information_patientno_Internalname ;
      private String edtavDdo_br_information_patientnotitlecontrolidtoreplace_Internalname ;
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
      private String edtBR_EncounterID_Internalname ;
      private String edtBR_Encounter_EncID_Internalname ;
      private String edtBR_Encounter_Department_Internalname ;
      private String edtBR_Encounter_ENCType_Internalname ;
      private String edtBR_Encounter_AdmitDate_Internalname ;
      private String edtBR_Encounter_AdmitSource_Internalname ;
      private String edtBR_Encounter_DischargeDate_Internalname ;
      private String edtBR_Encounter_DischargeStatus_Internalname ;
      private String cmbBR_Encounter_Status_Internalname ;
      private String edtBR_Information_ID_Internalname ;
      private String edtBR_Information_PatientNo_Internalname ;
      private String scmdbuf ;
      private String sGXsfl_12_fel_idx="0001" ;
      private String sImgUrl ;
      private String edtavSelect_Jsonclick ;
      private String ROClassString ;
      private String edtBR_EncounterID_Jsonclick ;
      private String edtBR_Encounter_EncID_Jsonclick ;
      private String edtBR_Encounter_Department_Jsonclick ;
      private String edtBR_Encounter_ENCType_Jsonclick ;
      private String edtBR_Encounter_AdmitDate_Jsonclick ;
      private String edtBR_Encounter_AdmitSource_Jsonclick ;
      private String edtBR_Encounter_DischargeDate_Jsonclick ;
      private String edtBR_Encounter_DischargeStatus_Jsonclick ;
      private String GXCCtl ;
      private String cmbBR_Encounter_Status_Jsonclick ;
      private String edtBR_Information_ID_Jsonclick ;
      private String edtBR_Information_PatientNo_Jsonclick ;
      private DateTime A91BR_Encounter_AdmitDate ;
      private DateTime A93BR_Encounter_DischargeDate ;
      private bool entryPointCalled ;
      private bool AV12OrderedDsc ;
      private bool toggleJsOutput ;
      private bool Gridpaginationbar_Showfirst ;
      private bool Gridpaginationbar_Showprevious ;
      private bool Gridpaginationbar_Shownext ;
      private bool Gridpaginationbar_Showlast ;
      private bool Gridpaginationbar_Rowsperpageselector ;
      private bool Ddo_br_encounterid_Includesortasc ;
      private bool Ddo_br_encounterid_Includesortdsc ;
      private bool Ddo_br_encounterid_Includefilter ;
      private bool Ddo_br_encounterid_Includedatalist ;
      private bool Ddo_br_encounter_encid_Includesortasc ;
      private bool Ddo_br_encounter_encid_Includesortdsc ;
      private bool Ddo_br_encounter_encid_Includefilter ;
      private bool Ddo_br_encounter_encid_Includedatalist ;
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
      private bool Ddo_br_encounter_admitsource_Includesortasc ;
      private bool Ddo_br_encounter_admitsource_Includesortdsc ;
      private bool Ddo_br_encounter_admitsource_Includefilter ;
      private bool Ddo_br_encounter_admitsource_Includedatalist ;
      private bool Ddo_br_encounter_dischargedate_Includesortasc ;
      private bool Ddo_br_encounter_dischargedate_Includesortdsc ;
      private bool Ddo_br_encounter_dischargedate_Includefilter ;
      private bool Ddo_br_encounter_dischargedate_Includedatalist ;
      private bool Ddo_br_encounter_dischargestatus_Includesortasc ;
      private bool Ddo_br_encounter_dischargestatus_Includesortdsc ;
      private bool Ddo_br_encounter_dischargestatus_Includefilter ;
      private bool Ddo_br_encounter_dischargestatus_Includedatalist ;
      private bool Ddo_br_encounter_status_Includesortasc ;
      private bool Ddo_br_encounter_status_Includesortdsc ;
      private bool Ddo_br_encounter_status_Includefilter ;
      private bool Ddo_br_encounter_status_Includedatalist ;
      private bool Ddo_br_information_id_Includesortasc ;
      private bool Ddo_br_information_id_Includesortdsc ;
      private bool Ddo_br_information_id_Includefilter ;
      private bool Ddo_br_information_id_Includedatalist ;
      private bool Ddo_br_information_patientno_Includesortasc ;
      private bool Ddo_br_information_patientno_Includesortdsc ;
      private bool Ddo_br_information_patientno_Includefilter ;
      private bool Ddo_br_information_patientno_Includedatalist ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_12_Refreshing=false ;
      private bool n35BR_Encounter_EncID ;
      private bool n84BR_Encounter_Department ;
      private bool n90BR_Encounter_ENCType ;
      private bool n91BR_Encounter_AdmitDate ;
      private bool n92BR_Encounter_AdmitSource ;
      private bool n93BR_Encounter_DischargeDate ;
      private bool n94BR_Encounter_DischargeStatus ;
      private bool n172BR_Encounter_Status ;
      private bool n85BR_Information_ID ;
      private bool n36BR_Information_PatientNo ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool AV5IsAuthorized ;
      private bool GXt_boolean1 ;
      private bool gx_refresh_fired ;
      private bool AV44Select_IsBlob ;
      private String AV16ddo_BR_EncounterIDTitleControlIdToReplace ;
      private String AV18ddo_BR_Encounter_EncIDTitleControlIdToReplace ;
      private String AV20ddo_BR_Encounter_DepartmentTitleControlIdToReplace ;
      private String AV22ddo_BR_Encounter_ENCTypeTitleControlIdToReplace ;
      private String AV24ddo_BR_Encounter_AdmitDateTitleControlIdToReplace ;
      private String AV26ddo_BR_Encounter_AdmitSourceTitleControlIdToReplace ;
      private String AV28ddo_BR_Encounter_DischargeDateTitleControlIdToReplace ;
      private String AV30ddo_BR_Encounter_DischargeStatusTitleControlIdToReplace ;
      private String AV50ddo_BR_Encounter_StatusTitleControlIdToReplace ;
      private String AV32ddo_BR_Information_IDTitleControlIdToReplace ;
      private String AV34ddo_BR_Information_PatientNoTitleControlIdToReplace ;
      private String A84BR_Encounter_Department ;
      private String A90BR_Encounter_ENCType ;
      private String A92BR_Encounter_AdmitSource ;
      private String A94BR_Encounter_DischargeStatus ;
      private String A36BR_Information_PatientNo ;
      private String AV78Select_GXI ;
      private String AV44Select ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private GXUserControl ucGridpaginationbar ;
      private GXUserControl ucDdo_br_encounterid ;
      private GXUserControl ucDdo_br_encounter_encid ;
      private GXUserControl ucDdo_br_encounter_department ;
      private GXUserControl ucDdo_br_encounter_enctype ;
      private GXUserControl ucDdo_br_encounter_admitdate ;
      private GXUserControl ucDdo_br_encounter_admitsource ;
      private GXUserControl ucDdo_br_encounter_dischargedate ;
      private GXUserControl ucDdo_br_encounter_dischargestatus ;
      private GXUserControl ucDdo_br_encounter_status ;
      private GXUserControl ucDdo_br_information_id ;
      private GXUserControl ucDdo_br_information_patientno ;
      private GXUserControl ucWorkwithplusutilities1 ;
      private GXWebForm Form ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private long aP0_InOutBR_EncounterID ;
      private GXCombobox cmbBR_Encounter_Status ;
      private IDataStoreProvider pr_default ;
      private String[] H00152_A36BR_Information_PatientNo ;
      private bool[] H00152_n36BR_Information_PatientNo ;
      private long[] H00152_A85BR_Information_ID ;
      private bool[] H00152_n85BR_Information_ID ;
      private short[] H00152_A172BR_Encounter_Status ;
      private bool[] H00152_n172BR_Encounter_Status ;
      private String[] H00152_A94BR_Encounter_DischargeStatus ;
      private bool[] H00152_n94BR_Encounter_DischargeStatus ;
      private DateTime[] H00152_A93BR_Encounter_DischargeDate ;
      private bool[] H00152_n93BR_Encounter_DischargeDate ;
      private String[] H00152_A92BR_Encounter_AdmitSource ;
      private bool[] H00152_n92BR_Encounter_AdmitSource ;
      private DateTime[] H00152_A91BR_Encounter_AdmitDate ;
      private bool[] H00152_n91BR_Encounter_AdmitDate ;
      private String[] H00152_A90BR_Encounter_ENCType ;
      private bool[] H00152_n90BR_Encounter_ENCType ;
      private String[] H00152_A84BR_Encounter_Department ;
      private bool[] H00152_n84BR_Encounter_Department ;
      private long[] H00152_A35BR_Encounter_EncID ;
      private bool[] H00152_n35BR_Encounter_EncID ;
      private long[] H00152_A19BR_EncounterID ;
      private long[] H00153_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV15BR_EncounterIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV17BR_Encounter_EncIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV19BR_Encounter_DepartmentTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV21BR_Encounter_ENCTypeTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV23BR_Encounter_AdmitDateTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV25BR_Encounter_AdmitSourceTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV27BR_Encounter_DischargeDateTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV29BR_Encounter_DischargeStatusTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV49BR_Encounter_StatusTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV31BR_Information_IDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV33BR_Information_PatientNoTitleFilterData ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons AV39DDO_TitleSettingsIcons ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 ;
   }

   public class br_encounterprompt__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H00152( IGxContext context ,
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
         sSelectString = " T2.[BR_Information_PatientNo], T1.[BR_Information_ID], T1.[BR_Encounter_Status], T1.[BR_Encounter_DischargeStatus], T1.[BR_Encounter_DischargeDate], T1.[BR_Encounter_AdmitSource], T1.[BR_Encounter_AdmitDate], T1.[BR_Encounter_ENCType], T1.[BR_Encounter_Department], T1.[BR_Encounter_EncID], T1.[BR_EncounterID]";
         sFromString = " FROM ([BR_Encounter] T1 WITH (NOLOCK) LEFT JOIN [BR_Information] T2 WITH (NOLOCK) ON T2.[BR_Information_ID] = T1.[BR_Information_ID])";
         sOrderString = "";
         if ( ( AV11OrderedBy == 1 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_EncounterID]";
         }
         else if ( ( AV11OrderedBy == 1 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_EncounterID] DESC";
         }
         else if ( ( AV11OrderedBy == 2 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Encounter_EncID]";
         }
         else if ( ( AV11OrderedBy == 2 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Encounter_EncID] DESC";
         }
         else if ( ( AV11OrderedBy == 3 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Encounter_Department]";
         }
         else if ( ( AV11OrderedBy == 3 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Encounter_Department] DESC";
         }
         else if ( ( AV11OrderedBy == 4 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Encounter_ENCType]";
         }
         else if ( ( AV11OrderedBy == 4 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Encounter_ENCType] DESC";
         }
         else if ( ( AV11OrderedBy == 5 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Encounter_AdmitDate]";
         }
         else if ( ( AV11OrderedBy == 5 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Encounter_AdmitDate] DESC";
         }
         else if ( ( AV11OrderedBy == 6 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Encounter_AdmitSource]";
         }
         else if ( ( AV11OrderedBy == 6 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Encounter_AdmitSource] DESC";
         }
         else if ( ( AV11OrderedBy == 7 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Encounter_DischargeDate]";
         }
         else if ( ( AV11OrderedBy == 7 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Encounter_DischargeDate] DESC";
         }
         else if ( ( AV11OrderedBy == 8 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Encounter_DischargeStatus]";
         }
         else if ( ( AV11OrderedBy == 8 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Encounter_DischargeStatus] DESC";
         }
         else if ( ( AV11OrderedBy == 9 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Encounter_Status]";
         }
         else if ( ( AV11OrderedBy == 9 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Encounter_Status] DESC";
         }
         else if ( ( AV11OrderedBy == 10 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Information_ID]";
         }
         else if ( ( AV11OrderedBy == 10 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Information_ID] DESC";
         }
         else if ( ( AV11OrderedBy == 11 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T2.[BR_Information_PatientNo]";
         }
         else if ( ( AV11OrderedBy == 11 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T2.[BR_Information_PatientNo] DESC";
         }
         else if ( true )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_EncounterID]";
         }
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object4[0] = scmdbuf;
         GXv_Object4[1] = GXv_int3;
         return GXv_Object4 ;
      }

      protected Object[] conditional_H00153( IGxContext context ,
                                             short AV11OrderedBy ,
                                             bool AV12OrderedDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         Object[] GXv_Object5 ;
         GXv_Object5 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM ([BR_Encounter] T1 WITH (NOLOCK) LEFT JOIN [BR_Information] T2 WITH (NOLOCK) ON T2.[BR_Information_ID] = T1.[BR_Information_ID])";
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
         else if ( ( AV11OrderedBy == 8 ) && ! AV12OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 8 ) && ( AV12OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 9 ) && ! AV12OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 9 ) && ( AV12OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 10 ) && ! AV12OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 10 ) && ( AV12OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 11 ) && ! AV12OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV11OrderedBy == 11 ) && ( AV12OrderedDsc ) )
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
                     return conditional_H00152(context, (short)dynConstraints[0] , (bool)dynConstraints[1] );
               case 1 :
                     return conditional_H00153(context, (short)dynConstraints[0] , (bool)dynConstraints[1] );
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
          Object[] prmH00152 ;
          prmH00152 = new Object[] {
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH00153 ;
          prmH00153 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("H00152", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00152,11,0,true,false )
             ,new CursorDef("H00153", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00153,1,0,true,false )
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
                ((long[]) buf[2])[0] = rslt.getLong(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((short[]) buf[4])[0] = rslt.getShort(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((String[]) buf[6])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((DateTime[]) buf[8])[0] = rslt.getGXDate(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((String[]) buf[10])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(6);
                ((DateTime[]) buf[12])[0] = rslt.getGXDate(7) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(7);
                ((String[]) buf[14])[0] = rslt.getVarchar(8) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(8);
                ((String[]) buf[16])[0] = rslt.getVarchar(9) ;
                ((bool[]) buf[17])[0] = rslt.wasNull(9);
                ((long[]) buf[18])[0] = rslt.getLong(10) ;
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
