/*
               File: BR_EncounterUpdateBR_VitalWC
        Description: Data Mgmt Portal - RAAP
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 11:56:54.29
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
   public class br_encounterupdatebr_vitalwc : GXWebComponent, System.Web.SessionState.IRequiresSessionState
   {
      public br_encounterupdatebr_vitalwc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         if ( StringUtil.Len( (String)(sPrefix)) == 0 )
         {
            context.SetDefaultTheme("WorkWithPlusTheme");
         }
      }

      public br_encounterupdatebr_vitalwc( IGxContext context )
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
         this.AV8BR_EncounterID = aP0_BR_EncounterID;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      public override void SetPrefix( String sPPrefix )
      {
         sPrefix = sPPrefix;
      }

      protected override void createObjects( )
      {
      }

      protected void INITWEB( )
      {
         initialize_properties( ) ;
         if ( StringUtil.Len( (String)(sPrefix)) == 0 )
         {
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
               else if ( StringUtil.StrCmp(gxfirstwebparm, "dyncomponent") == 0 )
               {
                  setAjaxEventMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1;
                     return  ;
                  }
                  nDynComponent = 1;
                  sCompPrefix = GetNextPar( );
                  sSFPrefix = GetNextPar( );
                  AV8BR_EncounterID = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV8BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8BR_EncounterID), 18, 0)));
                  setjustcreated();
                  componentprepare(new Object[] {(String)sCompPrefix,(String)sSFPrefix,(long)AV8BR_EncounterID});
                  componentstart();
                  context.httpAjaxContext.ajax_rspStartCmp(sPrefix);
                  componentdraw();
                  context.httpAjaxContext.ajax_rspEndCmp();
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
                  sPrefix = GetNextPar( );
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
                  AV14OrderedBy = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  AV15OrderedDsc = StringUtil.StrToBool( GetNextPar( ));
                  AV28TFBR_Vital_Temperature = NumberUtil.Val( GetNextPar( ), ".");
                  AV29TFBR_Vital_Temperature_To = NumberUtil.Val( GetNextPar( ), ".");
                  AV8BR_EncounterID = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  AV62ddo_BR_VitalIDTitleControlIdToReplace = GetNextPar( );
                  AV22ddo_BR_Vital_MeasureDateTitleControlIdToReplace = GetNextPar( );
                  AV26ddo_BR_Vital_WeightTitleControlIdToReplace = GetNextPar( );
                  AV30ddo_BR_Vital_TemperatureTitleControlIdToReplace = GetNextPar( );
                  AV77Pgmname = GetNextPar( );
                  AV54IsAuthorized_Display = StringUtil.StrToBool( GetNextPar( ));
                  AV56IsAuthorized_Update = StringUtil.StrToBool( GetNextPar( ));
                  AV58IsAuthorized_Delete = StringUtil.StrToBool( GetNextPar( ));
                  sPrefix = GetNextPar( );
                  init_default_properties( ) ;
                  setAjaxCallMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1;
                     return  ;
                  }
                  gxgrGrid_refresh( subGrid_Rows, AV14OrderedBy, AV15OrderedDsc, AV28TFBR_Vital_Temperature, AV29TFBR_Vital_Temperature_To, AV8BR_EncounterID, AV62ddo_BR_VitalIDTitleControlIdToReplace, AV22ddo_BR_Vital_MeasureDateTitleControlIdToReplace, AV26ddo_BR_Vital_WeightTitleControlIdToReplace, AV30ddo_BR_Vital_TemperatureTitleControlIdToReplace, AV77Pgmname, AV54IsAuthorized_Display, AV56IsAuthorized_Update, AV58IsAuthorized_Delete, sPrefix) ;
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
         }
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( ! context.IsLocalStorageSupported( ) )
            {
               context.PushCurrentUrl();
            }
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
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               ValidateSpaRequest();
            }
            PA602( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV77Pgmname = "BR_EncounterUpdateBR_VitalWC";
               context.Gx_err = 0;
               WS602( ) ;
               if ( ! isAjaxCallMode( ) )
               {
                  if ( nDynComponent == 0 )
                  {
                     throw new System.Net.WebException("WebComponent is not allowed to run") ;
                  }
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
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( context.isSpaRequest( ) )
            {
               enableOutput();
            }
            context.WriteHtmlText( "<title>") ;
            context.SendWebValue( "Data Mgmt Portal - RAAP") ;
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
         }
         if ( ( ( context.GetBrowserType( ) == 1 ) || ( context.GetBrowserType( ) == 5 ) ) && ( StringUtil.StrCmp(context.GetBrowserVersion( ), "7.0") == 0 ) )
         {
            context.AddJavascriptSource("json2.js", "?"+context.GetBuildNumber( 127771), false);
         }
         context.AddJavascriptSource("jquery.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("gxtimezone.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("gxgral.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("gxcfg.js", "?202022711565460", false);
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
         context.AddJavascriptSource("DVelop/WorkWithPlusUtilities/WorkWithPlusUtilitiesRender.js", "", false);
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            context.CloseHtmlHeader();
            if ( context.isSpaRequest( ) )
            {
               disableOutput();
            }
            FormProcess = " data-HasEnter=\"false\" data-Skiponenter=\"false\"";
            context.WriteHtmlText( "<body ") ;
            bodyStyle = "";
            if ( nGXWrapped == 0 )
            {
               bodyStyle = bodyStyle + "-moz-opacity:0;opacity:0;";
            }
            context.WriteHtmlText( " "+"class=\"form-horizontal Form\""+" "+ "style='"+bodyStyle+"'") ;
            context.WriteHtmlText( FormProcess+">") ;
            context.skipLines(1);
            context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_encounterupdatebr_vitalwc.aspx") + "?" + UrlEncode("" +AV8BR_EncounterID)+"\">") ;
            GxWebStd.gx_hidden_field( context, "_EventName", "");
            GxWebStd.gx_hidden_field( context, "_EventGridId", "");
            GxWebStd.gx_hidden_field( context, "_EventRowId", "");
            context.WriteHtmlText( "<input type=\"submit\" title=\"submit\" style=\"display:none\" disabled>") ;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, "FORM", "Class", "form-horizontal Form", true);
         }
         else
         {
            bool toggleHtmlOutput = isOutputEnabled( ) ;
            if ( StringUtil.StringSearch( sPrefix, "MP", 1) == 1 )
            {
               if ( context.isSpaRequest( ) )
               {
                  disableOutput();
               }
            }
            context.WriteHtmlText( "<div") ;
            GxWebStd.ClassAttribute( context, "gxwebcomponent-body"+" "+(String.IsNullOrEmpty(StringUtil.RTrim( Form.Class)) ? "form-horizontal Form" : Form.Class)+"-fx");
            context.WriteHtmlText( ">") ;
            if ( toggleHtmlOutput )
            {
               if ( StringUtil.StringSearch( sPrefix, "MP", 1) == 1 )
               {
                  if ( context.isSpaRequest( ) )
                  {
                     enableOutput();
                  }
               }
            }
            toggleJsOutput = isJsOutputEnabled( );
            if ( context.isSpaRequest( ) )
            {
               disableJsOutput();
            }
         }
         if ( StringUtil.StringSearch( sPrefix, "MP", 1) == 1 )
         {
            if ( context.isSpaRequest( ) )
            {
               disableOutput();
            }
         }
      }

      protected void send_integrity_footer_hashes( )
      {
         GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
      }

      protected void SendCloseFormHiddens( )
      {
         /* Send hidden variables. */
         GxWebStd.gx_hidden_field( context, sPrefix+"GXH_vORDEREDBY", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV14OrderedBy), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GXH_vORDEREDDSC", StringUtil.BoolToStr( AV15OrderedDsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"GXH_vTFBR_VITAL_TEMPERATURE", StringUtil.LTrim( StringUtil.NToC( AV28TFBR_Vital_Temperature, 15, 5, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GXH_vTFBR_VITAL_TEMPERATURE_TO", StringUtil.LTrim( StringUtil.NToC( AV29TFBR_Vital_Temperature_To, 15, 5, ".", "")));
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, sPrefix+"nRC_GXsfl_28", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_28), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"vGRIDCURRENTPAGE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV50GridCurrentPage), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"vGRIDRECORDCOUNT", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV52GridRecordCount), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"vGRIDPAGESIZE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV51GridPageSize), 10, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, sPrefix+"vDDO_TITLESETTINGSICONS", AV47DDO_TitleSettingsIcons);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(sPrefix+"vDDO_TITLESETTINGSICONS", AV47DDO_TitleSettingsIcons);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, sPrefix+"vBR_VITALIDTITLEFILTERDATA", AV59BR_VitalIDTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(sPrefix+"vBR_VITALIDTITLEFILTERDATA", AV59BR_VitalIDTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, sPrefix+"vBR_VITAL_MEASUREDATETITLEFILTERDATA", AV17BR_Vital_MeasureDateTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(sPrefix+"vBR_VITAL_MEASUREDATETITLEFILTERDATA", AV17BR_Vital_MeasureDateTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, sPrefix+"vBR_VITAL_WEIGHTTITLEFILTERDATA", AV23BR_Vital_WeightTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(sPrefix+"vBR_VITAL_WEIGHTTITLEFILTERDATA", AV23BR_Vital_WeightTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, sPrefix+"vBR_VITAL_TEMPERATURETITLEFILTERDATA", AV27BR_Vital_TemperatureTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(sPrefix+"vBR_VITAL_TEMPERATURETITLEFILTERDATA", AV27BR_Vital_TemperatureTitleFilterData);
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOAV8BR_EncounterID", StringUtil.LTrim( StringUtil.NToC( (decimal)(wcpOAV8BR_EncounterID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"vPGMNAME", StringUtil.RTrim( AV77Pgmname));
         GxWebStd.gx_boolean_hidden_field( context, sPrefix+"vISAUTHORIZED_DISPLAY", AV54IsAuthorized_Display);
         GxWebStd.gx_boolean_hidden_field( context, sPrefix+"vISAUTHORIZED_UPDATE", AV56IsAuthorized_Update);
         GxWebStd.gx_boolean_hidden_field( context, sPrefix+"vISAUTHORIZED_DELETE", AV58IsAuthorized_Delete);
         GxWebStd.gx_hidden_field( context, sPrefix+"vBR_ENCOUNTERID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8BR_EncounterID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"DVPANEL_TABLEHEADER_Width", StringUtil.RTrim( Dvpanel_tableheader_Width));
         GxWebStd.gx_hidden_field( context, sPrefix+"DVPANEL_TABLEHEADER_Cls", StringUtil.RTrim( Dvpanel_tableheader_Cls));
         GxWebStd.gx_hidden_field( context, sPrefix+"DVPANEL_TABLEHEADER_Title", StringUtil.RTrim( Dvpanel_tableheader_Title));
         GxWebStd.gx_hidden_field( context, sPrefix+"DVPANEL_TABLEHEADER_Collapsible", StringUtil.BoolToStr( Dvpanel_tableheader_Collapsible));
         GxWebStd.gx_hidden_field( context, sPrefix+"DVPANEL_TABLEHEADER_Collapsed", StringUtil.BoolToStr( Dvpanel_tableheader_Collapsed));
         GxWebStd.gx_hidden_field( context, sPrefix+"DVPANEL_TABLEHEADER_Autowidth", StringUtil.BoolToStr( Dvpanel_tableheader_Autowidth));
         GxWebStd.gx_hidden_field( context, sPrefix+"DVPANEL_TABLEHEADER_Autoheight", StringUtil.BoolToStr( Dvpanel_tableheader_Autoheight));
         GxWebStd.gx_hidden_field( context, sPrefix+"DVPANEL_TABLEHEADER_Showcollapseicon", StringUtil.BoolToStr( Dvpanel_tableheader_Showcollapseicon));
         GxWebStd.gx_hidden_field( context, sPrefix+"DVPANEL_TABLEHEADER_Iconposition", StringUtil.RTrim( Dvpanel_tableheader_Iconposition));
         GxWebStd.gx_hidden_field( context, sPrefix+"DVPANEL_TABLEHEADER_Autoscroll", StringUtil.BoolToStr( Dvpanel_tableheader_Autoscroll));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Class", StringUtil.RTrim( Gridpaginationbar_Class));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Previous", StringUtil.RTrim( Gridpaginationbar_Previous));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Next", StringUtil.RTrim( Gridpaginationbar_Next));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Caption", StringUtil.RTrim( Gridpaginationbar_Caption));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Showfirst", StringUtil.BoolToStr( Gridpaginationbar_Showfirst));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Showprevious", StringUtil.BoolToStr( Gridpaginationbar_Showprevious));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Shownext", StringUtil.BoolToStr( Gridpaginationbar_Shownext));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Showlast", StringUtil.BoolToStr( Gridpaginationbar_Showlast));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Pagestoshow", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Pagestoshow), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Pagingbuttonsposition", StringUtil.RTrim( Gridpaginationbar_Pagingbuttonsposition));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Pagingcaptionposition", StringUtil.RTrim( Gridpaginationbar_Pagingcaptionposition));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Emptygridclass", StringUtil.RTrim( Gridpaginationbar_Emptygridclass));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Rowsperpageselector", StringUtil.BoolToStr( Gridpaginationbar_Rowsperpageselector));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Rowsperpageoptions", StringUtil.RTrim( Gridpaginationbar_Rowsperpageoptions));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Emptygridcaption", StringUtil.RTrim( Gridpaginationbar_Emptygridcaption));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Rowsperpagecaption", StringUtil.RTrim( Gridpaginationbar_Rowsperpagecaption));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITALID_Caption", StringUtil.RTrim( Ddo_br_vitalid_Caption));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITALID_Tooltip", StringUtil.RTrim( Ddo_br_vitalid_Tooltip));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITALID_Cls", StringUtil.RTrim( Ddo_br_vitalid_Cls));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITALID_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_vitalid_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITALID_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_vitalid_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITALID_Includesortasc", StringUtil.BoolToStr( Ddo_br_vitalid_Includesortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITALID_Includesortdsc", StringUtil.BoolToStr( Ddo_br_vitalid_Includesortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITALID_Sortedstatus", StringUtil.RTrim( Ddo_br_vitalid_Sortedstatus));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITALID_Includefilter", StringUtil.BoolToStr( Ddo_br_vitalid_Includefilter));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITALID_Includedatalist", StringUtil.BoolToStr( Ddo_br_vitalid_Includedatalist));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITALID_Sortasc", StringUtil.RTrim( Ddo_br_vitalid_Sortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITALID_Sortdsc", StringUtil.RTrim( Ddo_br_vitalid_Sortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITALID_Searchbuttontext", StringUtil.RTrim( Ddo_br_vitalid_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_MEASUREDATE_Caption", StringUtil.RTrim( Ddo_br_vital_measuredate_Caption));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_MEASUREDATE_Tooltip", StringUtil.RTrim( Ddo_br_vital_measuredate_Tooltip));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_MEASUREDATE_Cls", StringUtil.RTrim( Ddo_br_vital_measuredate_Cls));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_MEASUREDATE_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_vital_measuredate_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_MEASUREDATE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_vital_measuredate_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_MEASUREDATE_Includesortasc", StringUtil.BoolToStr( Ddo_br_vital_measuredate_Includesortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_MEASUREDATE_Includesortdsc", StringUtil.BoolToStr( Ddo_br_vital_measuredate_Includesortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_MEASUREDATE_Sortedstatus", StringUtil.RTrim( Ddo_br_vital_measuredate_Sortedstatus));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_MEASUREDATE_Includefilter", StringUtil.BoolToStr( Ddo_br_vital_measuredate_Includefilter));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_MEASUREDATE_Includedatalist", StringUtil.BoolToStr( Ddo_br_vital_measuredate_Includedatalist));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_MEASUREDATE_Sortasc", StringUtil.RTrim( Ddo_br_vital_measuredate_Sortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_MEASUREDATE_Sortdsc", StringUtil.RTrim( Ddo_br_vital_measuredate_Sortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_MEASUREDATE_Searchbuttontext", StringUtil.RTrim( Ddo_br_vital_measuredate_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_WEIGHT_Caption", StringUtil.RTrim( Ddo_br_vital_weight_Caption));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_WEIGHT_Tooltip", StringUtil.RTrim( Ddo_br_vital_weight_Tooltip));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_WEIGHT_Cls", StringUtil.RTrim( Ddo_br_vital_weight_Cls));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_WEIGHT_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_vital_weight_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_WEIGHT_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_vital_weight_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_WEIGHT_Includesortasc", StringUtil.BoolToStr( Ddo_br_vital_weight_Includesortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_WEIGHT_Includesortdsc", StringUtil.BoolToStr( Ddo_br_vital_weight_Includesortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_WEIGHT_Sortedstatus", StringUtil.RTrim( Ddo_br_vital_weight_Sortedstatus));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_WEIGHT_Includefilter", StringUtil.BoolToStr( Ddo_br_vital_weight_Includefilter));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_WEIGHT_Includedatalist", StringUtil.BoolToStr( Ddo_br_vital_weight_Includedatalist));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_WEIGHT_Sortasc", StringUtil.RTrim( Ddo_br_vital_weight_Sortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_WEIGHT_Sortdsc", StringUtil.RTrim( Ddo_br_vital_weight_Sortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_WEIGHT_Searchbuttontext", StringUtil.RTrim( Ddo_br_vital_weight_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_TEMPERATURE_Caption", StringUtil.RTrim( Ddo_br_vital_temperature_Caption));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_TEMPERATURE_Tooltip", StringUtil.RTrim( Ddo_br_vital_temperature_Tooltip));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_TEMPERATURE_Cls", StringUtil.RTrim( Ddo_br_vital_temperature_Cls));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_TEMPERATURE_Filteredtext_set", StringUtil.RTrim( Ddo_br_vital_temperature_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_TEMPERATURE_Filteredtextto_set", StringUtil.RTrim( Ddo_br_vital_temperature_Filteredtextto_set));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_TEMPERATURE_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_vital_temperature_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_TEMPERATURE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_vital_temperature_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_TEMPERATURE_Includesortasc", StringUtil.BoolToStr( Ddo_br_vital_temperature_Includesortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_TEMPERATURE_Includesortdsc", StringUtil.BoolToStr( Ddo_br_vital_temperature_Includesortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_TEMPERATURE_Sortedstatus", StringUtil.RTrim( Ddo_br_vital_temperature_Sortedstatus));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_TEMPERATURE_Includefilter", StringUtil.BoolToStr( Ddo_br_vital_temperature_Includefilter));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_TEMPERATURE_Filtertype", StringUtil.RTrim( Ddo_br_vital_temperature_Filtertype));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_TEMPERATURE_Filterisrange", StringUtil.BoolToStr( Ddo_br_vital_temperature_Filterisrange));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_TEMPERATURE_Includedatalist", StringUtil.BoolToStr( Ddo_br_vital_temperature_Includedatalist));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_TEMPERATURE_Sortasc", StringUtil.RTrim( Ddo_br_vital_temperature_Sortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_TEMPERATURE_Sortdsc", StringUtil.RTrim( Ddo_br_vital_temperature_Sortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_TEMPERATURE_Cleanfilter", StringUtil.RTrim( Ddo_br_vital_temperature_Cleanfilter));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_TEMPERATURE_Rangefilterfrom", StringUtil.RTrim( Ddo_br_vital_temperature_Rangefilterfrom));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_TEMPERATURE_Rangefilterto", StringUtil.RTrim( Ddo_br_vital_temperature_Rangefilterto));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_TEMPERATURE_Searchbuttontext", StringUtil.RTrim( Ddo_br_vital_temperature_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITALID_Activeeventkey", StringUtil.RTrim( Ddo_br_vitalid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_MEASUREDATE_Activeeventkey", StringUtil.RTrim( Ddo_br_vital_measuredate_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_WEIGHT_Activeeventkey", StringUtil.RTrim( Ddo_br_vital_weight_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_TEMPERATURE_Activeeventkey", StringUtil.RTrim( Ddo_br_vital_temperature_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_TEMPERATURE_Filteredtext_get", StringUtil.RTrim( Ddo_br_vital_temperature_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_TEMPERATURE_Filteredtextto_get", StringUtil.RTrim( Ddo_br_vital_temperature_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITALID_Activeeventkey", StringUtil.RTrim( Ddo_br_vitalid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_MEASUREDATE_Activeeventkey", StringUtil.RTrim( Ddo_br_vital_measuredate_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_WEIGHT_Activeeventkey", StringUtil.RTrim( Ddo_br_vital_weight_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_TEMPERATURE_Activeeventkey", StringUtil.RTrim( Ddo_br_vital_temperature_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_TEMPERATURE_Filteredtext_get", StringUtil.RTrim( Ddo_br_vital_temperature_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_TEMPERATURE_Filteredtextto_get", StringUtil.RTrim( Ddo_br_vital_temperature_Filteredtextto_get));
      }

      protected void RenderHtmlCloseForm602( )
      {
         SendCloseFormHiddens( ) ;
         if ( ( StringUtil.Len( sPrefix) != 0 ) && ( context.isAjaxRequest( ) || context.isSpaRequest( ) ) )
         {
            context.AddJavascriptSource("br_encounterupdatebr_vitalwc.js", "?202022711565765", false);
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"GX_FocusControl", GX_FocusControl);
         define_styles( ) ;
         SendSecurityToken(sPrefix);
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            SendAjaxEncryptionKey();
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
         else
         {
            SendWebComponentState();
            context.WriteHtmlText( "</div>") ;
            if ( toggleJsOutput )
            {
               if ( context.isSpaRequest( ) )
               {
                  enableJsOutput();
               }
            }
         }
      }

      public override String GetPgmname( )
      {
         return "BR_EncounterUpdateBR_VitalWC" ;
      }

      public override String GetPgmdesc( )
      {
         return "Data Mgmt Portal - RAAP" ;
      }

      protected void WB600( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! wbLoad )
         {
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               RenderHtmlHeaders( ) ;
            }
            RenderHtmlOpenForm( ) ;
            if ( StringUtil.Len( sPrefix) != 0 )
            {
               GxWebStd.gx_hidden_field( context, sPrefix+"_CMPPGM", "br_encounterupdatebr_vitalwc.aspx");
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
               context.AddJavascriptSource("DVelop/WorkWithPlusUtilities/WorkWithPlusUtilitiesRender.js", "", false);
            }
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, "", "", sPrefix, "false");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-gx-base-lib=\"bootstrapv3\""+" "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divLayoutmaintable_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablegridheader_Internalname, 1, 0, "px", 0, "px", "Table100x100", "left", "top", "", "", "div");
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
            ucDvpanel_tableheader.Render(context, "dvelop.gxbootstrap.panel", Dvpanel_tableheader_Internalname, sPrefix+"DVPANEL_TABLEHEADERContainer");
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+sPrefix+"DVPANEL_TABLEHEADERContainer"+"Body"+"\" style=\"display:none;\">") ;
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group ActionGroup", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'" + sPrefix + "',false,'',0)\"";
            ClassString = "ButtonColor";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtninsert_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(28), 2, 0)+","+"null"+");", "新增", bttBtninsert_Jsonclick, 5, "插入", "", StyleString, ClassString, bttBtninsert_Visible, 1, "standard", "'"+sPrefix+"'"+",false,"+"'"+sPrefix+"E\\'DOINSERT\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_EncounterUpdateBR_VitalWC.htm");
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
               context.WriteHtmlText( "<div id=\""+sPrefix+"GridContainer"+"DivS\" data-gxgridid=\"28\">") ;
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
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"ActionBaseColorAttribute"+"\" "+" style=\""+((edtavDisplay_Visible==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"ActionBaseColorAttribute"+"\" "+" style=\""+((edtavUpdate_Visible==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"DeleteAttribute ActionBaseColorAttribute"+"\" "+" style=\""+((edtavDelete_Visible==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_VitalID_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_VitalID_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_VitalID_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Vital_MeasureDate_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Vital_MeasureDate_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Vital_MeasureDate_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Vital_Weight_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Vital_Weight_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Vital_Weight_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Vital_Temperature_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Vital_Temperature_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Vital_Temperature_Title) ;
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
               GridContainer.AddObjectProperty("CmpContext", sPrefix);
               GridContainer.AddObjectProperty("InMasterPage", "false");
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.convertURL( AV53Display));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavDisplay_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavDisplay_Tooltiptext));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavDisplay_Visible), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.convertURL( AV55Update));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavUpdate_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavUpdate_Tooltiptext));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavUpdate_Visible), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.convertURL( AV57Delete));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavDelete_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavDelete_Tooltiptext));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavDelete_Visible), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A150BR_VitalID), 18, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_VitalID_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_VitalID_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.localUtil.Format(A152BR_Vital_MeasureDate, "9999/99/99"));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Vital_MeasureDate_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Vital_MeasureDate_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A159BR_Vital_Weight, 15, 5, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Vital_Weight_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Vital_Weight_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A153BR_Vital_Temperature, 15, 5, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Vital_Temperature_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Vital_Temperature_Titleformat), 4, 0, ".", "")));
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
               context.WriteHtmlText( "<div id=\""+sPrefix+"GridContainer"+"Div\" "+sStyleString+">"+"</div>") ;
               context.httpAjaxContext.ajax_rsp_assign_grid(sPrefix+"_"+"Grid", GridContainer);
               if ( ! isAjaxCallMode( ) && ! context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, sPrefix+"GridContainerData", GridContainer.ToJavascriptSource());
               }
               if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, sPrefix+"GridContainerData"+"V", GridContainer.GridValuesHidden());
               }
               else
               {
                  context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+sPrefix+"GridContainerData"+"V"+"\" value='"+GridContainer.GridValuesHidden()+"'/>") ;
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
            ucGridpaginationbar.SetProperty("CurrentPage", AV50GridCurrentPage);
            ucGridpaginationbar.SetProperty("RecordCount", AV52GridRecordCount);
            ucGridpaginationbar.SetProperty("Page", AV51GridPageSize);
            ucGridpaginationbar.Render(context, "dvelop.dvpaginationbar", Gridpaginationbar_Internalname, sPrefix+"GRIDPAGINATIONBARContainer");
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
            ucDdo_br_vitalid.SetProperty("Caption", Ddo_br_vitalid_Caption);
            ucDdo_br_vitalid.SetProperty("Tooltip", Ddo_br_vitalid_Tooltip);
            ucDdo_br_vitalid.SetProperty("Cls", Ddo_br_vitalid_Cls);
            ucDdo_br_vitalid.SetProperty("DropDownOptionsType", Ddo_br_vitalid_Dropdownoptionstype);
            ucDdo_br_vitalid.SetProperty("IncludeSortASC", Ddo_br_vitalid_Includesortasc);
            ucDdo_br_vitalid.SetProperty("IncludeSortDSC", Ddo_br_vitalid_Includesortdsc);
            ucDdo_br_vitalid.SetProperty("IncludeFilter", Ddo_br_vitalid_Includefilter);
            ucDdo_br_vitalid.SetProperty("IncludeDataList", Ddo_br_vitalid_Includedatalist);
            ucDdo_br_vitalid.SetProperty("SortASC", Ddo_br_vitalid_Sortasc);
            ucDdo_br_vitalid.SetProperty("SortDSC", Ddo_br_vitalid_Sortdsc);
            ucDdo_br_vitalid.SetProperty("SearchButtonText", Ddo_br_vitalid_Searchbuttontext);
            ucDdo_br_vitalid.SetProperty("DropDownOptionsTitleSettingsIcons", AV47DDO_TitleSettingsIcons);
            ucDdo_br_vitalid.SetProperty("DropDownOptionsData", AV59BR_VitalIDTitleFilterData);
            ucDdo_br_vitalid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_vitalid_Internalname, sPrefix+"DDO_BR_VITALIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'" + sPrefix + "',false,'" + sGXsfl_28_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_vitalidtitlecontrolidtoreplace_Internalname, AV62ddo_BR_VitalIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,44);\"", 0, edtavDdo_br_vitalidtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_EncounterUpdateBR_VitalWC.htm");
            /* User Defined Control */
            ucDdo_br_vital_measuredate.SetProperty("Caption", Ddo_br_vital_measuredate_Caption);
            ucDdo_br_vital_measuredate.SetProperty("Tooltip", Ddo_br_vital_measuredate_Tooltip);
            ucDdo_br_vital_measuredate.SetProperty("Cls", Ddo_br_vital_measuredate_Cls);
            ucDdo_br_vital_measuredate.SetProperty("DropDownOptionsType", Ddo_br_vital_measuredate_Dropdownoptionstype);
            ucDdo_br_vital_measuredate.SetProperty("IncludeSortASC", Ddo_br_vital_measuredate_Includesortasc);
            ucDdo_br_vital_measuredate.SetProperty("IncludeSortDSC", Ddo_br_vital_measuredate_Includesortdsc);
            ucDdo_br_vital_measuredate.SetProperty("IncludeFilter", Ddo_br_vital_measuredate_Includefilter);
            ucDdo_br_vital_measuredate.SetProperty("IncludeDataList", Ddo_br_vital_measuredate_Includedatalist);
            ucDdo_br_vital_measuredate.SetProperty("SortASC", Ddo_br_vital_measuredate_Sortasc);
            ucDdo_br_vital_measuredate.SetProperty("SortDSC", Ddo_br_vital_measuredate_Sortdsc);
            ucDdo_br_vital_measuredate.SetProperty("SearchButtonText", Ddo_br_vital_measuredate_Searchbuttontext);
            ucDdo_br_vital_measuredate.SetProperty("DropDownOptionsTitleSettingsIcons", AV47DDO_TitleSettingsIcons);
            ucDdo_br_vital_measuredate.SetProperty("DropDownOptionsData", AV17BR_Vital_MeasureDateTitleFilterData);
            ucDdo_br_vital_measuredate.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_vital_measuredate_Internalname, sPrefix+"DDO_BR_VITAL_MEASUREDATEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'" + sPrefix + "',false,'" + sGXsfl_28_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_vital_measuredatetitlecontrolidtoreplace_Internalname, AV22ddo_BR_Vital_MeasureDateTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,46);\"", 0, edtavDdo_br_vital_measuredatetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_EncounterUpdateBR_VitalWC.htm");
            /* User Defined Control */
            ucDdo_br_vital_weight.SetProperty("Caption", Ddo_br_vital_weight_Caption);
            ucDdo_br_vital_weight.SetProperty("Tooltip", Ddo_br_vital_weight_Tooltip);
            ucDdo_br_vital_weight.SetProperty("Cls", Ddo_br_vital_weight_Cls);
            ucDdo_br_vital_weight.SetProperty("DropDownOptionsType", Ddo_br_vital_weight_Dropdownoptionstype);
            ucDdo_br_vital_weight.SetProperty("IncludeSortASC", Ddo_br_vital_weight_Includesortasc);
            ucDdo_br_vital_weight.SetProperty("IncludeSortDSC", Ddo_br_vital_weight_Includesortdsc);
            ucDdo_br_vital_weight.SetProperty("IncludeFilter", Ddo_br_vital_weight_Includefilter);
            ucDdo_br_vital_weight.SetProperty("IncludeDataList", Ddo_br_vital_weight_Includedatalist);
            ucDdo_br_vital_weight.SetProperty("SortASC", Ddo_br_vital_weight_Sortasc);
            ucDdo_br_vital_weight.SetProperty("SortDSC", Ddo_br_vital_weight_Sortdsc);
            ucDdo_br_vital_weight.SetProperty("SearchButtonText", Ddo_br_vital_weight_Searchbuttontext);
            ucDdo_br_vital_weight.SetProperty("DropDownOptionsTitleSettingsIcons", AV47DDO_TitleSettingsIcons);
            ucDdo_br_vital_weight.SetProperty("DropDownOptionsData", AV23BR_Vital_WeightTitleFilterData);
            ucDdo_br_vital_weight.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_vital_weight_Internalname, sPrefix+"DDO_BR_VITAL_WEIGHTContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'" + sPrefix + "',false,'" + sGXsfl_28_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_vital_weighttitlecontrolidtoreplace_Internalname, AV26ddo_BR_Vital_WeightTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,48);\"", 0, edtavDdo_br_vital_weighttitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_EncounterUpdateBR_VitalWC.htm");
            /* User Defined Control */
            ucDdo_br_vital_temperature.SetProperty("Caption", Ddo_br_vital_temperature_Caption);
            ucDdo_br_vital_temperature.SetProperty("Tooltip", Ddo_br_vital_temperature_Tooltip);
            ucDdo_br_vital_temperature.SetProperty("Cls", Ddo_br_vital_temperature_Cls);
            ucDdo_br_vital_temperature.SetProperty("DropDownOptionsType", Ddo_br_vital_temperature_Dropdownoptionstype);
            ucDdo_br_vital_temperature.SetProperty("IncludeSortASC", Ddo_br_vital_temperature_Includesortasc);
            ucDdo_br_vital_temperature.SetProperty("IncludeSortDSC", Ddo_br_vital_temperature_Includesortdsc);
            ucDdo_br_vital_temperature.SetProperty("IncludeFilter", Ddo_br_vital_temperature_Includefilter);
            ucDdo_br_vital_temperature.SetProperty("FilterType", Ddo_br_vital_temperature_Filtertype);
            ucDdo_br_vital_temperature.SetProperty("FilterIsRange", Ddo_br_vital_temperature_Filterisrange);
            ucDdo_br_vital_temperature.SetProperty("IncludeDataList", Ddo_br_vital_temperature_Includedatalist);
            ucDdo_br_vital_temperature.SetProperty("SortASC", Ddo_br_vital_temperature_Sortasc);
            ucDdo_br_vital_temperature.SetProperty("SortDSC", Ddo_br_vital_temperature_Sortdsc);
            ucDdo_br_vital_temperature.SetProperty("CleanFilter", Ddo_br_vital_temperature_Cleanfilter);
            ucDdo_br_vital_temperature.SetProperty("RangeFilterFrom", Ddo_br_vital_temperature_Rangefilterfrom);
            ucDdo_br_vital_temperature.SetProperty("RangeFilterTo", Ddo_br_vital_temperature_Rangefilterto);
            ucDdo_br_vital_temperature.SetProperty("SearchButtonText", Ddo_br_vital_temperature_Searchbuttontext);
            ucDdo_br_vital_temperature.SetProperty("DropDownOptionsTitleSettingsIcons", AV47DDO_TitleSettingsIcons);
            ucDdo_br_vital_temperature.SetProperty("DropDownOptionsData", AV27BR_Vital_TemperatureTitleFilterData);
            ucDdo_br_vital_temperature.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_vital_temperature_Internalname, sPrefix+"DDO_BR_VITAL_TEMPERATUREContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 50,'" + sPrefix + "',false,'" + sGXsfl_28_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_vital_temperaturetitlecontrolidtoreplace_Internalname, AV30ddo_BR_Vital_TemperatureTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,50);\"", 0, edtavDdo_br_vital_temperaturetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_EncounterUpdateBR_VitalWC.htm");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_EncounterID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A19BR_EncounterID), 18, 0, ".", "")), context.localUtil.Format( (decimal)(A19BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ"), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_EncounterID_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_EncounterID_Visible, 0, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "HLP_BR_EncounterUpdateBR_VitalWC.htm");
            /* User Defined Control */
            ucWorkwithplusutilities1.Render(context, "dvelop.workwithplusutilities", Workwithplusutilities1_Internalname, sPrefix+"WORKWITHPLUSUTILITIES1Container");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'" + sPrefix + "',false,'" + sGXsfl_28_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrderedby_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV14OrderedBy), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV14OrderedBy), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,53);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrderedby_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrderedby_Visible, 1, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_EncounterUpdateBR_VitalWC.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'" + sPrefix + "',false,'" + sGXsfl_28_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrdereddsc_Internalname, StringUtil.BoolToStr( AV15OrderedDsc), StringUtil.BoolToStr( AV15OrderedDsc), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,54);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrdereddsc_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrdereddsc_Visible, 1, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, 0, 0, true, "", "right", false, "HLP_BR_EncounterUpdateBR_VitalWC.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 55,'" + sPrefix + "',false,'" + sGXsfl_28_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_vital_temperature_Internalname, StringUtil.LTrim( StringUtil.NToC( AV28TFBR_Vital_Temperature, 15, 5, ".", "")), StringUtil.LTrim( context.localUtil.Format( AV28TFBR_Vital_Temperature, "ZZZZZZZZZ.ZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, ',','.','5');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,55);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_vital_temperature_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_vital_temperature_Visible, 1, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_EncounterUpdateBR_VitalWC.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 56,'" + sPrefix + "',false,'" + sGXsfl_28_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_vital_temperature_to_Internalname, StringUtil.LTrim( StringUtil.NToC( AV29TFBR_Vital_Temperature_To, 15, 5, ".", "")), StringUtil.LTrim( context.localUtil.Format( AV29TFBR_Vital_Temperature_To, "ZZZZZZZZZ.ZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, ',','.','5');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,56);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_vital_temperature_to_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_vital_temperature_to_Visible, 1, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_EncounterUpdateBR_VitalWC.htm");
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
                  context.WriteHtmlText( "<div id=\""+sPrefix+"GridContainer"+"Div\" "+sStyleString+">"+"</div>") ;
                  context.httpAjaxContext.ajax_rsp_assign_grid(sPrefix+"_"+"Grid", GridContainer);
                  if ( ! isAjaxCallMode( ) && ! context.isSpaRequest( ) )
                  {
                     GxWebStd.gx_hidden_field( context, sPrefix+"GridContainerData", GridContainer.ToJavascriptSource());
                  }
                  if ( context.isAjaxRequest( ) || context.isSpaRequest( ) )
                  {
                     GxWebStd.gx_hidden_field( context, sPrefix+"GridContainerData"+"V", GridContainer.GridValuesHidden());
                  }
                  else
                  {
                     context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+sPrefix+"GridContainerData"+"V"+"\" value='"+GridContainer.GridValuesHidden()+"'/>") ;
                  }
               }
            }
         }
         wbLoad = true;
      }

      protected void START602( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( ! context.isSpaRequest( ) )
            {
               Form.Meta.addItem("generator", "GeneXus C# 16_0_0-127771", 0) ;
               Form.Meta.addItem("description", "Data Mgmt Portal - RAAP", 0) ;
            }
            context.wjLoc = "";
            context.nUserReturn = 0;
            context.wbHandled = 0;
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               sXEvt = cgiGet( "_EventName");
               if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
               {
               }
            }
         }
         wbErr = false;
         if ( ( StringUtil.Len( sPrefix) == 0 ) || ( nDraw == 1 ) )
         {
            if ( nDoneStart == 0 )
            {
               STRUP600( ) ;
            }
         }
      }

      protected void WS602( )
      {
         START602( ) ;
         EVT602( ) ;
      }

      protected void EVT602( )
      {
         sXEvt = cgiGet( "_EventName");
         if ( ( ( ( StringUtil.Len( sPrefix) == 0 ) ) || ( StringUtil.StringSearch( sXEvt, sPrefix, 1) > 0 ) ) && ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) && ! wbErr )
            {
               /* Read Web Panel buttons. */
               if ( context.wbHandled == 0 )
               {
                  if ( StringUtil.Len( sPrefix) == 0 )
                  {
                     sEvt = cgiGet( "_EventName");
                     EvtGridId = cgiGet( "_EventGridId");
                     EvtRowId = cgiGet( "_EventRowId");
                  }
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
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP600( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEPAGE") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP600( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    E11602 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEROWSPERPAGE") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP600( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    E12602 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_VITALID.ONOPTIONCLICKED") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP600( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    E13602 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_VITAL_MEASUREDATE.ONOPTIONCLICKED") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP600( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    E14602 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_VITAL_WEIGHT.ONOPTIONCLICKED") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP600( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    E15602 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_VITAL_TEMPERATURE.ONOPTIONCLICKED") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP600( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    E16602 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'DOINSERT'") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP600( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: 'DoInsert' */
                                    E17602 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP600( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    GX_FocusControl = edtavDdo_br_vitalidtitlecontrolidtoreplace_Internalname;
                                    context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
                                 }
                              }
                              dynload_actions( ) ;
                           }
                        }
                        else
                        {
                           sEvtType = StringUtil.Right( sEvt, 4);
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4));
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 7), "REFRESH") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 9), "GRID.LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 13), "VUPDATE.CLICK") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 13), "VDELETE.CLICK") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 13), "VUPDATE.CLICK") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 13), "VDELETE.CLICK") == 0 ) )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP600( ) ;
                              }
                              nGXsfl_28_idx = (short)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_28_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_28_idx), 4, 0)), 4, "0");
                              SubsflControlProps_282( ) ;
                              AV53Display = cgiGet( edtavDisplay_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDisplay_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV53Display)) ? AV74Display_GXI : context.convertURL( context.PathToRelativeUrl( AV53Display))), !bGXsfl_28_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDisplay_Internalname, "SrcSet", context.GetImageSrcSet( AV53Display), true);
                              AV55Update = cgiGet( edtavUpdate_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavUpdate_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV55Update)) ? AV75Update_GXI : context.convertURL( context.PathToRelativeUrl( AV55Update))), !bGXsfl_28_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavUpdate_Internalname, "SrcSet", context.GetImageSrcSet( AV55Update), true);
                              AV57Delete = cgiGet( edtavDelete_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDelete_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV57Delete)) ? AV76Delete_GXI : context.convertURL( context.PathToRelativeUrl( AV57Delete))), !bGXsfl_28_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDelete_Internalname, "SrcSet", context.GetImageSrcSet( AV57Delete), true);
                              A150BR_VitalID = (long)(context.localUtil.CToN( cgiGet( edtBR_VitalID_Internalname), ".", ","));
                              A152BR_Vital_MeasureDate = DateTimeUtil.ResetTime(context.localUtil.CToT( cgiGet( edtBR_Vital_MeasureDate_Internalname), 0));
                              n152BR_Vital_MeasureDate = false;
                              A159BR_Vital_Weight = context.localUtil.CToN( cgiGet( edtBR_Vital_Weight_Internalname), ".", ",");
                              n159BR_Vital_Weight = false;
                              A153BR_Vital_Temperature = context.localUtil.CToN( cgiGet( edtBR_Vital_Temperature_Internalname), ".", ",");
                              n153BR_Vital_Temperature = false;
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1;
                                       if ( ! wbErr )
                                       {
                                          dynload_actions( ) ;
                                          GX_FocusControl = edtavDdo_br_vitalidtitlecontrolidtoreplace_Internalname;
                                          context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
                                          /* Execute user event: Start */
                                          E18602 ();
                                       }
                                    }
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                                 {
                                    if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1;
                                       if ( ! wbErr )
                                       {
                                          dynload_actions( ) ;
                                          GX_FocusControl = edtavDdo_br_vitalidtitlecontrolidtoreplace_Internalname;
                                          context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
                                          /* Execute user event: Refresh */
                                          E19602 ();
                                       }
                                    }
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "GRID.LOAD") == 0 )
                                 {
                                    if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1;
                                       if ( ! wbErr )
                                       {
                                          dynload_actions( ) ;
                                          GX_FocusControl = edtavDdo_br_vitalidtitlecontrolidtoreplace_Internalname;
                                          context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
                                          E20602 ();
                                       }
                                    }
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "VUPDATE.CLICK") == 0 )
                                 {
                                    if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1;
                                       if ( ! wbErr )
                                       {
                                          dynload_actions( ) ;
                                          GX_FocusControl = edtavDdo_br_vitalidtitlecontrolidtoreplace_Internalname;
                                          context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
                                          E21602 ();
                                       }
                                    }
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "VDELETE.CLICK") == 0 )
                                 {
                                    if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1;
                                       if ( ! wbErr )
                                       {
                                          dynload_actions( ) ;
                                          GX_FocusControl = edtavDdo_br_vitalidtitlecontrolidtoreplace_Internalname;
                                          context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
                                          E22602 ();
                                       }
                                    }
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1;
                                       if ( ! wbErr )
                                       {
                                          if ( ! wbErr )
                                          {
                                             Rfr0gs = false;
                                             /* Set Refresh If Orderedby Changed */
                                             if ( ( context.localUtil.CToN( cgiGet( sPrefix+"GXH_vORDEREDBY"), ".", ",") != Convert.ToDecimal( AV14OrderedBy )) )
                                             {
                                                Rfr0gs = true;
                                             }
                                             /* Set Refresh If Ordereddsc Changed */
                                             if ( StringUtil.StrToBool( cgiGet( sPrefix+"GXH_vORDEREDDSC")) != AV15OrderedDsc )
                                             {
                                                Rfr0gs = true;
                                             }
                                             /* Set Refresh If Tfbr_vital_temperature Changed */
                                             if ( context.localUtil.CToN( cgiGet( sPrefix+"GXH_vTFBR_VITAL_TEMPERATURE"), ".", ",") != AV28TFBR_Vital_Temperature )
                                             {
                                                Rfr0gs = true;
                                             }
                                             /* Set Refresh If Tfbr_vital_temperature_to Changed */
                                             if ( context.localUtil.CToN( cgiGet( sPrefix+"GXH_vTFBR_VITAL_TEMPERATURE_TO"), ".", ",") != AV29TFBR_Vital_Temperature_To )
                                             {
                                                Rfr0gs = true;
                                             }
                                             if ( ! Rfr0gs )
                                             {
                                             }
                                             dynload_actions( ) ;
                                          }
                                       }
                                    }
                                    /* No code required for Cancel button. It is implemented as the Reset button. */
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                                 {
                                    if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                                    {
                                       STRUP600( ) ;
                                    }
                                    if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1;
                                       if ( ! wbErr )
                                       {
                                          dynload_actions( ) ;
                                          GX_FocusControl = edtavDdo_br_vitalidtitlecontrolidtoreplace_Internalname;
                                          context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
                                       }
                                    }
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

      protected void WE602( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm602( ) ;
            }
         }
      }

      protected void PA602( )
      {
         if ( nDonePA == 0 )
         {
            if ( StringUtil.Len( sPrefix) != 0 )
            {
               initialize_properties( ) ;
            }
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
               {
                  gxcookieaux = context.SetCookie( "GX_SESSION_ID", Encrypt64( Crypto.GetEncryptionKey( ), Crypto.GetServerKey( )), "", (DateTime)(DateTime.MinValue), "", 0);
               }
            }
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            toggleJsOutput = isJsOutputEnabled( );
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               if ( context.isSpaRequest( ) )
               {
                  disableJsOutput();
               }
            }
            init_web_controls( ) ;
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               if ( toggleJsOutput )
               {
                  if ( context.isSpaRequest( ) )
                  {
                     enableJsOutput();
                  }
               }
            }
            if ( ! context.isAjaxRequest( ) )
            {
               GX_FocusControl = edtavDdo_br_vitalidtitlecontrolidtoreplace_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
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
                                       short AV14OrderedBy ,
                                       bool AV15OrderedDsc ,
                                       decimal AV28TFBR_Vital_Temperature ,
                                       decimal AV29TFBR_Vital_Temperature_To ,
                                       long AV8BR_EncounterID ,
                                       String AV62ddo_BR_VitalIDTitleControlIdToReplace ,
                                       String AV22ddo_BR_Vital_MeasureDateTitleControlIdToReplace ,
                                       String AV26ddo_BR_Vital_WeightTitleControlIdToReplace ,
                                       String AV30ddo_BR_Vital_TemperatureTitleControlIdToReplace ,
                                       String AV77Pgmname ,
                                       bool AV54IsAuthorized_Display ,
                                       bool AV56IsAuthorized_Update ,
                                       bool AV58IsAuthorized_Delete ,
                                       String sPrefix )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GRID_nCurrentRecord = 0;
         RF602( ) ;
         /* End function gxgrGrid_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, sPrefix+"gxhash_BR_VITALID", GetSecureSignedToken( sPrefix, context.localUtil.Format( (decimal)(A150BR_VitalID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, sPrefix+"BR_VITALID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A150BR_VitalID), 18, 0, ".", "")));
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
         RF602( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV77Pgmname = "BR_EncounterUpdateBR_VitalWC";
         context.Gx_err = 0;
      }

      protected void RF602( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridContainer.ClearRows();
         }
         wbStart = 28;
         /* Execute user event: Refresh */
         E19602 ();
         nGXsfl_28_idx = 1;
         sGXsfl_28_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_28_idx), 4, 0)), 4, "0");
         SubsflControlProps_282( ) ;
         bGXsfl_28_Refreshing = true;
         GridContainer.AddObjectProperty("GridName", "Grid");
         GridContainer.AddObjectProperty("CmpContext", sPrefix);
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
                                                 AV28TFBR_Vital_Temperature ,
                                                 AV29TFBR_Vital_Temperature_To ,
                                                 A153BR_Vital_Temperature ,
                                                 AV14OrderedBy ,
                                                 AV15OrderedDsc ,
                                                 A19BR_EncounterID ,
                                                 AV8BR_EncounterID } ,
                                                 new int[]{
                                                 TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.LONG
                                                 }
            } ) ;
            /* Using cursor H00602 */
            pr_default.execute(0, new Object[] {AV8BR_EncounterID, AV28TFBR_Vital_Temperature, AV29TFBR_Vital_Temperature_To, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_28_idx = 1;
            sGXsfl_28_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_28_idx), 4, 0)), 4, "0");
            SubsflControlProps_282( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < subGrid_Recordsperpage( ) ) ) ) )
            {
               A19BR_EncounterID = H00602_A19BR_EncounterID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
               A153BR_Vital_Temperature = H00602_A153BR_Vital_Temperature[0];
               n153BR_Vital_Temperature = H00602_n153BR_Vital_Temperature[0];
               A159BR_Vital_Weight = H00602_A159BR_Vital_Weight[0];
               n159BR_Vital_Weight = H00602_n159BR_Vital_Weight[0];
               A152BR_Vital_MeasureDate = H00602_A152BR_Vital_MeasureDate[0];
               n152BR_Vital_MeasureDate = H00602_n152BR_Vital_MeasureDate[0];
               A150BR_VitalID = H00602_A150BR_VitalID[0];
               E20602 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, sPrefix+"GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 28;
            WB600( ) ;
         }
         bGXsfl_28_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes602( )
      {
         GxWebStd.gx_hidden_field( context, sPrefix+"gxhash_BR_VITALID"+"_"+sGXsfl_28_idx, GetSecureSignedToken( sPrefix+sGXsfl_28_idx, context.localUtil.Format( (decimal)(A150BR_VitalID), "ZZZZZZZZZZZZZZZZZZ"), context));
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
                                              AV28TFBR_Vital_Temperature ,
                                              AV29TFBR_Vital_Temperature_To ,
                                              A153BR_Vital_Temperature ,
                                              AV14OrderedBy ,
                                              AV15OrderedDsc ,
                                              A19BR_EncounterID ,
                                              AV8BR_EncounterID } ,
                                              new int[]{
                                              TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.LONG
                                              }
         } ) ;
         /* Using cursor H00603 */
         pr_default.execute(1, new Object[] {AV8BR_EncounterID, AV28TFBR_Vital_Temperature, AV29TFBR_Vital_Temperature_To});
         GRID_nRecordCount = H00603_AGRID_nRecordCount[0];
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
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV14OrderedBy, AV15OrderedDsc, AV28TFBR_Vital_Temperature, AV29TFBR_Vital_Temperature_To, AV8BR_EncounterID, AV62ddo_BR_VitalIDTitleControlIdToReplace, AV22ddo_BR_Vital_MeasureDateTitleControlIdToReplace, AV26ddo_BR_Vital_WeightTitleControlIdToReplace, AV30ddo_BR_Vital_TemperatureTitleControlIdToReplace, AV77Pgmname, AV54IsAuthorized_Display, AV56IsAuthorized_Update, AV58IsAuthorized_Delete, sPrefix) ;
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
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         GridContainer.AddObjectProperty("GRID_nFirstRecordOnPage", GRID_nFirstRecordOnPage);
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV14OrderedBy, AV15OrderedDsc, AV28TFBR_Vital_Temperature, AV29TFBR_Vital_Temperature_To, AV8BR_EncounterID, AV62ddo_BR_VitalIDTitleControlIdToReplace, AV22ddo_BR_Vital_MeasureDateTitleControlIdToReplace, AV26ddo_BR_Vital_WeightTitleControlIdToReplace, AV30ddo_BR_Vital_TemperatureTitleControlIdToReplace, AV77Pgmname, AV54IsAuthorized_Display, AV56IsAuthorized_Update, AV58IsAuthorized_Delete, sPrefix) ;
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
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV14OrderedBy, AV15OrderedDsc, AV28TFBR_Vital_Temperature, AV29TFBR_Vital_Temperature_To, AV8BR_EncounterID, AV62ddo_BR_VitalIDTitleControlIdToReplace, AV22ddo_BR_Vital_MeasureDateTitleControlIdToReplace, AV26ddo_BR_Vital_WeightTitleControlIdToReplace, AV30ddo_BR_Vital_TemperatureTitleControlIdToReplace, AV77Pgmname, AV54IsAuthorized_Display, AV56IsAuthorized_Update, AV58IsAuthorized_Delete, sPrefix) ;
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
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV14OrderedBy, AV15OrderedDsc, AV28TFBR_Vital_Temperature, AV29TFBR_Vital_Temperature_To, AV8BR_EncounterID, AV62ddo_BR_VitalIDTitleControlIdToReplace, AV22ddo_BR_Vital_MeasureDateTitleControlIdToReplace, AV26ddo_BR_Vital_WeightTitleControlIdToReplace, AV30ddo_BR_Vital_TemperatureTitleControlIdToReplace, AV77Pgmname, AV54IsAuthorized_Display, AV56IsAuthorized_Update, AV58IsAuthorized_Delete, sPrefix) ;
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
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV14OrderedBy, AV15OrderedDsc, AV28TFBR_Vital_Temperature, AV29TFBR_Vital_Temperature_To, AV8BR_EncounterID, AV62ddo_BR_VitalIDTitleControlIdToReplace, AV22ddo_BR_Vital_MeasureDateTitleControlIdToReplace, AV26ddo_BR_Vital_WeightTitleControlIdToReplace, AV30ddo_BR_Vital_TemperatureTitleControlIdToReplace, AV77Pgmname, AV54IsAuthorized_Display, AV56IsAuthorized_Update, AV58IsAuthorized_Delete, sPrefix) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP600( )
      {
         /* Before Start, stand alone formulas. */
         AV77Pgmname = "BR_EncounterUpdateBR_VitalWC";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E18602 ();
         context.wbGlbDoneStart = 1;
         nDoneStart = 1;
         /* After Start, stand alone formulas. */
         sXEvt = cgiGet( "_EventName");
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( sPrefix+"vDDO_TITLESETTINGSICONS"), AV47DDO_TitleSettingsIcons);
            ajax_req_read_hidden_sdt(cgiGet( sPrefix+"vBR_VITALIDTITLEFILTERDATA"), AV59BR_VitalIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( sPrefix+"vBR_VITAL_MEASUREDATETITLEFILTERDATA"), AV17BR_Vital_MeasureDateTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( sPrefix+"vBR_VITAL_WEIGHTTITLEFILTERDATA"), AV23BR_Vital_WeightTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( sPrefix+"vBR_VITAL_TEMPERATURETITLEFILTERDATA"), AV27BR_Vital_TemperatureTitleFilterData);
            /* Read variables values. */
            AV62ddo_BR_VitalIDTitleControlIdToReplace = cgiGet( edtavDdo_br_vitalidtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV62ddo_BR_VitalIDTitleControlIdToReplace", AV62ddo_BR_VitalIDTitleControlIdToReplace);
            AV22ddo_BR_Vital_MeasureDateTitleControlIdToReplace = cgiGet( edtavDdo_br_vital_measuredatetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV22ddo_BR_Vital_MeasureDateTitleControlIdToReplace", AV22ddo_BR_Vital_MeasureDateTitleControlIdToReplace);
            AV26ddo_BR_Vital_WeightTitleControlIdToReplace = cgiGet( edtavDdo_br_vital_weighttitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV26ddo_BR_Vital_WeightTitleControlIdToReplace", AV26ddo_BR_Vital_WeightTitleControlIdToReplace);
            AV30ddo_BR_Vital_TemperatureTitleControlIdToReplace = cgiGet( edtavDdo_br_vital_temperaturetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV30ddo_BR_Vital_TemperatureTitleControlIdToReplace", AV30ddo_BR_Vital_TemperatureTitleControlIdToReplace);
            A19BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( edtBR_EncounterID_Internalname), ".", ","));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
            if ( ( ( context.localUtil.CToN( cgiGet( edtavOrderedby_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavOrderedby_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vORDEREDBY");
               GX_FocusControl = edtavOrderedby_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV14OrderedBy = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14OrderedBy), 4, 0)));
            }
            else
            {
               AV14OrderedBy = (short)(context.localUtil.CToN( cgiGet( edtavOrderedby_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14OrderedBy), 4, 0)));
            }
            AV15OrderedDsc = StringUtil.StrToBool( cgiGet( edtavOrdereddsc_Internalname));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV15OrderedDsc", AV15OrderedDsc);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_vital_temperature_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_vital_temperature_Internalname), ".", ",") > 999999999.99999m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_VITAL_TEMPERATURE");
               GX_FocusControl = edtavTfbr_vital_temperature_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV28TFBR_Vital_Temperature = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV28TFBR_Vital_Temperature", StringUtil.LTrim( StringUtil.Str( AV28TFBR_Vital_Temperature, 15, 5)));
            }
            else
            {
               AV28TFBR_Vital_Temperature = context.localUtil.CToN( cgiGet( edtavTfbr_vital_temperature_Internalname), ".", ",");
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV28TFBR_Vital_Temperature", StringUtil.LTrim( StringUtil.Str( AV28TFBR_Vital_Temperature, 15, 5)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_vital_temperature_to_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_vital_temperature_to_Internalname), ".", ",") > 999999999.99999m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_VITAL_TEMPERATURE_TO");
               GX_FocusControl = edtavTfbr_vital_temperature_to_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV29TFBR_Vital_Temperature_To = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV29TFBR_Vital_Temperature_To", StringUtil.LTrim( StringUtil.Str( AV29TFBR_Vital_Temperature_To, 15, 5)));
            }
            else
            {
               AV29TFBR_Vital_Temperature_To = context.localUtil.CToN( cgiGet( edtavTfbr_vital_temperature_to_Internalname), ".", ",");
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV29TFBR_Vital_Temperature_To", StringUtil.LTrim( StringUtil.Str( AV29TFBR_Vital_Temperature_To, 15, 5)));
            }
            /* Read saved values. */
            nRC_GXsfl_28 = (short)(context.localUtil.CToN( cgiGet( sPrefix+"nRC_GXsfl_28"), ".", ","));
            AV50GridCurrentPage = (long)(context.localUtil.CToN( cgiGet( sPrefix+"vGRIDCURRENTPAGE"), ".", ","));
            AV52GridRecordCount = (long)(context.localUtil.CToN( cgiGet( sPrefix+"vGRIDRECORDCOUNT"), ".", ","));
            AV51GridPageSize = (long)(context.localUtil.CToN( cgiGet( sPrefix+"vGRIDPAGESIZE"), ".", ","));
            wcpOAV8BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOAV8BR_EncounterID"), ".", ","));
            GRID_nFirstRecordOnPage = (long)(context.localUtil.CToN( cgiGet( sPrefix+"GRID_nFirstRecordOnPage"), ".", ","));
            GRID_nEOF = (short)(context.localUtil.CToN( cgiGet( sPrefix+"GRID_nEOF"), ".", ","));
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( sPrefix+"GRID_Rows"), ".", ","));
            GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            Dvpanel_tableheader_Width = cgiGet( sPrefix+"DVPANEL_TABLEHEADER_Width");
            Dvpanel_tableheader_Cls = cgiGet( sPrefix+"DVPANEL_TABLEHEADER_Cls");
            Dvpanel_tableheader_Title = cgiGet( sPrefix+"DVPANEL_TABLEHEADER_Title");
            Dvpanel_tableheader_Collapsible = StringUtil.StrToBool( cgiGet( sPrefix+"DVPANEL_TABLEHEADER_Collapsible"));
            Dvpanel_tableheader_Collapsed = StringUtil.StrToBool( cgiGet( sPrefix+"DVPANEL_TABLEHEADER_Collapsed"));
            Dvpanel_tableheader_Autowidth = StringUtil.StrToBool( cgiGet( sPrefix+"DVPANEL_TABLEHEADER_Autowidth"));
            Dvpanel_tableheader_Autoheight = StringUtil.StrToBool( cgiGet( sPrefix+"DVPANEL_TABLEHEADER_Autoheight"));
            Dvpanel_tableheader_Showcollapseicon = StringUtil.StrToBool( cgiGet( sPrefix+"DVPANEL_TABLEHEADER_Showcollapseicon"));
            Dvpanel_tableheader_Iconposition = cgiGet( sPrefix+"DVPANEL_TABLEHEADER_Iconposition");
            Dvpanel_tableheader_Autoscroll = StringUtil.StrToBool( cgiGet( sPrefix+"DVPANEL_TABLEHEADER_Autoscroll"));
            Gridpaginationbar_Class = cgiGet( sPrefix+"GRIDPAGINATIONBAR_Class");
            Gridpaginationbar_Previous = cgiGet( sPrefix+"GRIDPAGINATIONBAR_Previous");
            Gridpaginationbar_Next = cgiGet( sPrefix+"GRIDPAGINATIONBAR_Next");
            Gridpaginationbar_Caption = cgiGet( sPrefix+"GRIDPAGINATIONBAR_Caption");
            Gridpaginationbar_Showfirst = StringUtil.StrToBool( cgiGet( sPrefix+"GRIDPAGINATIONBAR_Showfirst"));
            Gridpaginationbar_Showprevious = StringUtil.StrToBool( cgiGet( sPrefix+"GRIDPAGINATIONBAR_Showprevious"));
            Gridpaginationbar_Shownext = StringUtil.StrToBool( cgiGet( sPrefix+"GRIDPAGINATIONBAR_Shownext"));
            Gridpaginationbar_Showlast = StringUtil.StrToBool( cgiGet( sPrefix+"GRIDPAGINATIONBAR_Showlast"));
            Gridpaginationbar_Pagestoshow = (int)(context.localUtil.CToN( cgiGet( sPrefix+"GRIDPAGINATIONBAR_Pagestoshow"), ".", ","));
            Gridpaginationbar_Pagingbuttonsposition = cgiGet( sPrefix+"GRIDPAGINATIONBAR_Pagingbuttonsposition");
            Gridpaginationbar_Pagingcaptionposition = cgiGet( sPrefix+"GRIDPAGINATIONBAR_Pagingcaptionposition");
            Gridpaginationbar_Emptygridclass = cgiGet( sPrefix+"GRIDPAGINATIONBAR_Emptygridclass");
            Gridpaginationbar_Rowsperpageselector = StringUtil.StrToBool( cgiGet( sPrefix+"GRIDPAGINATIONBAR_Rowsperpageselector"));
            Gridpaginationbar_Rowsperpageselectedvalue = (int)(context.localUtil.CToN( cgiGet( sPrefix+"GRIDPAGINATIONBAR_Rowsperpageselectedvalue"), ".", ","));
            Gridpaginationbar_Rowsperpageoptions = cgiGet( sPrefix+"GRIDPAGINATIONBAR_Rowsperpageoptions");
            Gridpaginationbar_Emptygridcaption = cgiGet( sPrefix+"GRIDPAGINATIONBAR_Emptygridcaption");
            Gridpaginationbar_Rowsperpagecaption = cgiGet( sPrefix+"GRIDPAGINATIONBAR_Rowsperpagecaption");
            Ddo_br_vitalid_Caption = cgiGet( sPrefix+"DDO_BR_VITALID_Caption");
            Ddo_br_vitalid_Tooltip = cgiGet( sPrefix+"DDO_BR_VITALID_Tooltip");
            Ddo_br_vitalid_Cls = cgiGet( sPrefix+"DDO_BR_VITALID_Cls");
            Ddo_br_vitalid_Dropdownoptionstype = cgiGet( sPrefix+"DDO_BR_VITALID_Dropdownoptionstype");
            Ddo_br_vitalid_Titlecontrolidtoreplace = cgiGet( sPrefix+"DDO_BR_VITALID_Titlecontrolidtoreplace");
            Ddo_br_vitalid_Includesortasc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_VITALID_Includesortasc"));
            Ddo_br_vitalid_Includesortdsc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_VITALID_Includesortdsc"));
            Ddo_br_vitalid_Sortedstatus = cgiGet( sPrefix+"DDO_BR_VITALID_Sortedstatus");
            Ddo_br_vitalid_Includefilter = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_VITALID_Includefilter"));
            Ddo_br_vitalid_Includedatalist = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_VITALID_Includedatalist"));
            Ddo_br_vitalid_Sortasc = cgiGet( sPrefix+"DDO_BR_VITALID_Sortasc");
            Ddo_br_vitalid_Sortdsc = cgiGet( sPrefix+"DDO_BR_VITALID_Sortdsc");
            Ddo_br_vitalid_Searchbuttontext = cgiGet( sPrefix+"DDO_BR_VITALID_Searchbuttontext");
            Ddo_br_vital_measuredate_Caption = cgiGet( sPrefix+"DDO_BR_VITAL_MEASUREDATE_Caption");
            Ddo_br_vital_measuredate_Tooltip = cgiGet( sPrefix+"DDO_BR_VITAL_MEASUREDATE_Tooltip");
            Ddo_br_vital_measuredate_Cls = cgiGet( sPrefix+"DDO_BR_VITAL_MEASUREDATE_Cls");
            Ddo_br_vital_measuredate_Dropdownoptionstype = cgiGet( sPrefix+"DDO_BR_VITAL_MEASUREDATE_Dropdownoptionstype");
            Ddo_br_vital_measuredate_Titlecontrolidtoreplace = cgiGet( sPrefix+"DDO_BR_VITAL_MEASUREDATE_Titlecontrolidtoreplace");
            Ddo_br_vital_measuredate_Includesortasc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_VITAL_MEASUREDATE_Includesortasc"));
            Ddo_br_vital_measuredate_Includesortdsc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_VITAL_MEASUREDATE_Includesortdsc"));
            Ddo_br_vital_measuredate_Sortedstatus = cgiGet( sPrefix+"DDO_BR_VITAL_MEASUREDATE_Sortedstatus");
            Ddo_br_vital_measuredate_Includefilter = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_VITAL_MEASUREDATE_Includefilter"));
            Ddo_br_vital_measuredate_Includedatalist = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_VITAL_MEASUREDATE_Includedatalist"));
            Ddo_br_vital_measuredate_Sortasc = cgiGet( sPrefix+"DDO_BR_VITAL_MEASUREDATE_Sortasc");
            Ddo_br_vital_measuredate_Sortdsc = cgiGet( sPrefix+"DDO_BR_VITAL_MEASUREDATE_Sortdsc");
            Ddo_br_vital_measuredate_Searchbuttontext = cgiGet( sPrefix+"DDO_BR_VITAL_MEASUREDATE_Searchbuttontext");
            Ddo_br_vital_weight_Caption = cgiGet( sPrefix+"DDO_BR_VITAL_WEIGHT_Caption");
            Ddo_br_vital_weight_Tooltip = cgiGet( sPrefix+"DDO_BR_VITAL_WEIGHT_Tooltip");
            Ddo_br_vital_weight_Cls = cgiGet( sPrefix+"DDO_BR_VITAL_WEIGHT_Cls");
            Ddo_br_vital_weight_Dropdownoptionstype = cgiGet( sPrefix+"DDO_BR_VITAL_WEIGHT_Dropdownoptionstype");
            Ddo_br_vital_weight_Titlecontrolidtoreplace = cgiGet( sPrefix+"DDO_BR_VITAL_WEIGHT_Titlecontrolidtoreplace");
            Ddo_br_vital_weight_Includesortasc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_VITAL_WEIGHT_Includesortasc"));
            Ddo_br_vital_weight_Includesortdsc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_VITAL_WEIGHT_Includesortdsc"));
            Ddo_br_vital_weight_Sortedstatus = cgiGet( sPrefix+"DDO_BR_VITAL_WEIGHT_Sortedstatus");
            Ddo_br_vital_weight_Includefilter = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_VITAL_WEIGHT_Includefilter"));
            Ddo_br_vital_weight_Includedatalist = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_VITAL_WEIGHT_Includedatalist"));
            Ddo_br_vital_weight_Sortasc = cgiGet( sPrefix+"DDO_BR_VITAL_WEIGHT_Sortasc");
            Ddo_br_vital_weight_Sortdsc = cgiGet( sPrefix+"DDO_BR_VITAL_WEIGHT_Sortdsc");
            Ddo_br_vital_weight_Searchbuttontext = cgiGet( sPrefix+"DDO_BR_VITAL_WEIGHT_Searchbuttontext");
            Ddo_br_vital_temperature_Caption = cgiGet( sPrefix+"DDO_BR_VITAL_TEMPERATURE_Caption");
            Ddo_br_vital_temperature_Tooltip = cgiGet( sPrefix+"DDO_BR_VITAL_TEMPERATURE_Tooltip");
            Ddo_br_vital_temperature_Cls = cgiGet( sPrefix+"DDO_BR_VITAL_TEMPERATURE_Cls");
            Ddo_br_vital_temperature_Filteredtext_set = cgiGet( sPrefix+"DDO_BR_VITAL_TEMPERATURE_Filteredtext_set");
            Ddo_br_vital_temperature_Filteredtextto_set = cgiGet( sPrefix+"DDO_BR_VITAL_TEMPERATURE_Filteredtextto_set");
            Ddo_br_vital_temperature_Dropdownoptionstype = cgiGet( sPrefix+"DDO_BR_VITAL_TEMPERATURE_Dropdownoptionstype");
            Ddo_br_vital_temperature_Titlecontrolidtoreplace = cgiGet( sPrefix+"DDO_BR_VITAL_TEMPERATURE_Titlecontrolidtoreplace");
            Ddo_br_vital_temperature_Includesortasc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_VITAL_TEMPERATURE_Includesortasc"));
            Ddo_br_vital_temperature_Includesortdsc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_VITAL_TEMPERATURE_Includesortdsc"));
            Ddo_br_vital_temperature_Sortedstatus = cgiGet( sPrefix+"DDO_BR_VITAL_TEMPERATURE_Sortedstatus");
            Ddo_br_vital_temperature_Includefilter = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_VITAL_TEMPERATURE_Includefilter"));
            Ddo_br_vital_temperature_Filtertype = cgiGet( sPrefix+"DDO_BR_VITAL_TEMPERATURE_Filtertype");
            Ddo_br_vital_temperature_Filterisrange = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_VITAL_TEMPERATURE_Filterisrange"));
            Ddo_br_vital_temperature_Includedatalist = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_VITAL_TEMPERATURE_Includedatalist"));
            Ddo_br_vital_temperature_Sortasc = cgiGet( sPrefix+"DDO_BR_VITAL_TEMPERATURE_Sortasc");
            Ddo_br_vital_temperature_Sortdsc = cgiGet( sPrefix+"DDO_BR_VITAL_TEMPERATURE_Sortdsc");
            Ddo_br_vital_temperature_Cleanfilter = cgiGet( sPrefix+"DDO_BR_VITAL_TEMPERATURE_Cleanfilter");
            Ddo_br_vital_temperature_Rangefilterfrom = cgiGet( sPrefix+"DDO_BR_VITAL_TEMPERATURE_Rangefilterfrom");
            Ddo_br_vital_temperature_Rangefilterto = cgiGet( sPrefix+"DDO_BR_VITAL_TEMPERATURE_Rangefilterto");
            Ddo_br_vital_temperature_Searchbuttontext = cgiGet( sPrefix+"DDO_BR_VITAL_TEMPERATURE_Searchbuttontext");
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( sPrefix+"GRID_Rows"), ".", ","));
            GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            Gridpaginationbar_Selectedpage = cgiGet( sPrefix+"GRIDPAGINATIONBAR_Selectedpage");
            Gridpaginationbar_Rowsperpageselectedvalue = (int)(context.localUtil.CToN( cgiGet( sPrefix+"GRIDPAGINATIONBAR_Rowsperpageselectedvalue"), ".", ","));
            Ddo_br_vitalid_Activeeventkey = cgiGet( sPrefix+"DDO_BR_VITALID_Activeeventkey");
            Ddo_br_vital_measuredate_Activeeventkey = cgiGet( sPrefix+"DDO_BR_VITAL_MEASUREDATE_Activeeventkey");
            Ddo_br_vital_weight_Activeeventkey = cgiGet( sPrefix+"DDO_BR_VITAL_WEIGHT_Activeeventkey");
            Ddo_br_vital_temperature_Activeeventkey = cgiGet( sPrefix+"DDO_BR_VITAL_TEMPERATURE_Activeeventkey");
            Ddo_br_vital_temperature_Filteredtext_get = cgiGet( sPrefix+"DDO_BR_VITAL_TEMPERATURE_Filteredtext_get");
            Ddo_br_vital_temperature_Filteredtextto_get = cgiGet( sPrefix+"DDO_BR_VITAL_TEMPERATURE_Filteredtextto_get");
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
            if ( ( context.localUtil.CToN( cgiGet( sPrefix+"GXH_vORDEREDBY"), ".", ",") != Convert.ToDecimal( AV14OrderedBy )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrToBool( cgiGet( sPrefix+"GXH_vORDEREDDSC")) != AV15OrderedDsc )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToN( cgiGet( sPrefix+"GXH_vTFBR_VITAL_TEMPERATURE"), ".", ",") != AV28TFBR_Vital_Temperature )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToN( cgiGet( sPrefix+"GXH_vTFBR_VITAL_TEMPERATURE_TO"), ".", ",") != AV29TFBR_Vital_Temperature_To )
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
         E18602 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E18602( )
      {
         /* Start Routine */
         subGrid_Rows = 9;
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         edtavTfbr_vital_temperature_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavTfbr_vital_temperature_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_vital_temperature_Visible), 5, 0)), true);
         edtavTfbr_vital_temperature_to_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavTfbr_vital_temperature_to_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_vital_temperature_to_Visible), 5, 0)), true);
         Ddo_br_vitalid_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_VitalID";
         ucDdo_br_vitalid.SendProperty(context, sPrefix, false, Ddo_br_vitalid_Internalname, "TitleControlIdToReplace", Ddo_br_vitalid_Titlecontrolidtoreplace);
         AV62ddo_BR_VitalIDTitleControlIdToReplace = Ddo_br_vitalid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV62ddo_BR_VitalIDTitleControlIdToReplace", AV62ddo_BR_VitalIDTitleControlIdToReplace);
         edtavDdo_br_vitalidtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDdo_br_vitalidtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_vitalidtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_vital_measuredate_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Vital_MeasureDate";
         ucDdo_br_vital_measuredate.SendProperty(context, sPrefix, false, Ddo_br_vital_measuredate_Internalname, "TitleControlIdToReplace", Ddo_br_vital_measuredate_Titlecontrolidtoreplace);
         AV22ddo_BR_Vital_MeasureDateTitleControlIdToReplace = Ddo_br_vital_measuredate_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV22ddo_BR_Vital_MeasureDateTitleControlIdToReplace", AV22ddo_BR_Vital_MeasureDateTitleControlIdToReplace);
         edtavDdo_br_vital_measuredatetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDdo_br_vital_measuredatetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_vital_measuredatetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_vital_weight_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Vital_Weight";
         ucDdo_br_vital_weight.SendProperty(context, sPrefix, false, Ddo_br_vital_weight_Internalname, "TitleControlIdToReplace", Ddo_br_vital_weight_Titlecontrolidtoreplace);
         AV26ddo_BR_Vital_WeightTitleControlIdToReplace = Ddo_br_vital_weight_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV26ddo_BR_Vital_WeightTitleControlIdToReplace", AV26ddo_BR_Vital_WeightTitleControlIdToReplace);
         edtavDdo_br_vital_weighttitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDdo_br_vital_weighttitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_vital_weighttitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_vital_temperature_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Vital_Temperature";
         ucDdo_br_vital_temperature.SendProperty(context, sPrefix, false, Ddo_br_vital_temperature_Internalname, "TitleControlIdToReplace", Ddo_br_vital_temperature_Titlecontrolidtoreplace);
         AV30ddo_BR_Vital_TemperatureTitleControlIdToReplace = Ddo_br_vital_temperature_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV30ddo_BR_Vital_TemperatureTitleControlIdToReplace", AV30ddo_BR_Vital_TemperatureTitleControlIdToReplace);
         edtavDdo_br_vital_temperaturetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDdo_br_vital_temperaturetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_vital_temperaturetitlecontrolidtoreplace_Visible), 5, 0)), true);
         edtBR_EncounterID_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_EncounterID_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtBR_EncounterID_Visible), 5, 0)), true);
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
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavOrderedby_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavOrderedby_Visible), 5, 0)), true);
         if ( AV14OrderedBy < 1 )
         {
            AV14OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14OrderedBy), 4, 0)));
            /* Execute user subroutine: 'SETDDOSORTEDSTATUS' */
            S132 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
         }
         edtavOrdereddsc_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavOrdereddsc_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavOrdereddsc_Visible), 5, 0)), true);
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 = AV47DDO_TitleSettingsIcons;
         new GeneXus.Programs.wwpbaseobjects.getwwptitlesettingsicons(context ).execute( out  GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1) ;
         AV47DDO_TitleSettingsIcons = GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1;
         Gridpaginationbar_Rowsperpageselectedvalue = subGrid_Rows;
         ucGridpaginationbar.SendProperty(context, sPrefix, false, Gridpaginationbar_Internalname, "RowsPerPageSelectedValue", StringUtil.LTrim( StringUtil.Str( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0)));
      }

      protected void E19602( )
      {
         if ( gx_refresh_fired )
         {
            return  ;
         }
         gx_refresh_fired = true;
         /* Refresh Routine */
         AV59BR_VitalIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV17BR_Vital_MeasureDateTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV23BR_Vital_WeightTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV27BR_Vital_TemperatureTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
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
         edtBR_VitalID_Titleformat = 2;
         edtBR_VitalID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "序号", AV62ddo_BR_VitalIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_VitalID_Internalname, "Title", edtBR_VitalID_Title, !bGXsfl_28_Refreshing);
         edtBR_Vital_MeasureDate_Titleformat = 2;
         edtBR_Vital_MeasureDate_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "测量日期", AV22ddo_BR_Vital_MeasureDateTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_Vital_MeasureDate_Internalname, "Title", edtBR_Vital_MeasureDate_Title, !bGXsfl_28_Refreshing);
         edtBR_Vital_Weight_Titleformat = 2;
         edtBR_Vital_Weight_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "体重(kg)", AV26ddo_BR_Vital_WeightTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_Vital_Weight_Internalname, "Title", edtBR_Vital_Weight_Title, !bGXsfl_28_Refreshing);
         edtBR_Vital_Temperature_Titleformat = 2;
         edtBR_Vital_Temperature_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "体温(℃)", AV30ddo_BR_Vital_TemperatureTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_Vital_Temperature_Internalname, "Title", edtBR_Vital_Temperature_Title, !bGXsfl_28_Refreshing);
         AV50GridCurrentPage = subGrid_Currentpage( );
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV50GridCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV50GridCurrentPage), 10, 0)));
         AV51GridPageSize = subGrid_Rows;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV51GridPageSize", StringUtil.LTrim( StringUtil.Str( (decimal)(AV51GridPageSize), 10, 0)));
         AV52GridRecordCount = subGrid_Recordcount( );
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV52GridRecordCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV52GridRecordCount), 10, 0)));
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV59BR_VitalIDTitleFilterData", AV59BR_VitalIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV17BR_Vital_MeasureDateTitleFilterData", AV17BR_Vital_MeasureDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV23BR_Vital_WeightTitleFilterData", AV23BR_Vital_WeightTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV27BR_Vital_TemperatureTitleFilterData", AV27BR_Vital_TemperatureTitleFilterData);
      }

      protected void E11602( )
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
            AV49PageToGo = (int)(NumberUtil.Val( Gridpaginationbar_Selectedpage, "."));
            subgrid_gotopage( AV49PageToGo) ;
         }
      }

      protected void E12602( )
      {
         /* Gridpaginationbar_Changerowsperpage Routine */
         subGrid_Rows = Gridpaginationbar_Rowsperpageselectedvalue;
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         subgrid_firstpage( ) ;
         /*  Sending Event outputs  */
      }

      protected void E13602( )
      {
         /* Ddo_br_vitalid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_vitalid_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV14OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14OrderedBy), 4, 0)));
            AV15OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV15OrderedDsc", AV15OrderedDsc);
            Ddo_br_vitalid_Sortedstatus = "ASC";
            ucDdo_br_vitalid.SendProperty(context, sPrefix, false, Ddo_br_vitalid_Internalname, "SortedStatus", Ddo_br_vitalid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         else if ( StringUtil.StrCmp(Ddo_br_vitalid_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV14OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14OrderedBy), 4, 0)));
            AV15OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV15OrderedDsc", AV15OrderedDsc);
            Ddo_br_vitalid_Sortedstatus = "DSC";
            ucDdo_br_vitalid.SendProperty(context, sPrefix, false, Ddo_br_vitalid_Internalname, "SortedStatus", Ddo_br_vitalid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV59BR_VitalIDTitleFilterData", AV59BR_VitalIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV17BR_Vital_MeasureDateTitleFilterData", AV17BR_Vital_MeasureDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV23BR_Vital_WeightTitleFilterData", AV23BR_Vital_WeightTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV27BR_Vital_TemperatureTitleFilterData", AV27BR_Vital_TemperatureTitleFilterData);
      }

      protected void E14602( )
      {
         /* Ddo_br_vital_measuredate_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_vital_measuredate_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV14OrderedBy = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14OrderedBy), 4, 0)));
            AV15OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV15OrderedDsc", AV15OrderedDsc);
            Ddo_br_vital_measuredate_Sortedstatus = "ASC";
            ucDdo_br_vital_measuredate.SendProperty(context, sPrefix, false, Ddo_br_vital_measuredate_Internalname, "SortedStatus", Ddo_br_vital_measuredate_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         else if ( StringUtil.StrCmp(Ddo_br_vital_measuredate_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV14OrderedBy = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14OrderedBy), 4, 0)));
            AV15OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV15OrderedDsc", AV15OrderedDsc);
            Ddo_br_vital_measuredate_Sortedstatus = "DSC";
            ucDdo_br_vital_measuredate.SendProperty(context, sPrefix, false, Ddo_br_vital_measuredate_Internalname, "SortedStatus", Ddo_br_vital_measuredate_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV59BR_VitalIDTitleFilterData", AV59BR_VitalIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV17BR_Vital_MeasureDateTitleFilterData", AV17BR_Vital_MeasureDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV23BR_Vital_WeightTitleFilterData", AV23BR_Vital_WeightTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV27BR_Vital_TemperatureTitleFilterData", AV27BR_Vital_TemperatureTitleFilterData);
      }

      protected void E15602( )
      {
         /* Ddo_br_vital_weight_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_vital_weight_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV14OrderedBy = 3;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14OrderedBy), 4, 0)));
            AV15OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV15OrderedDsc", AV15OrderedDsc);
            Ddo_br_vital_weight_Sortedstatus = "ASC";
            ucDdo_br_vital_weight.SendProperty(context, sPrefix, false, Ddo_br_vital_weight_Internalname, "SortedStatus", Ddo_br_vital_weight_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         else if ( StringUtil.StrCmp(Ddo_br_vital_weight_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV14OrderedBy = 3;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14OrderedBy), 4, 0)));
            AV15OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV15OrderedDsc", AV15OrderedDsc);
            Ddo_br_vital_weight_Sortedstatus = "DSC";
            ucDdo_br_vital_weight.SendProperty(context, sPrefix, false, Ddo_br_vital_weight_Internalname, "SortedStatus", Ddo_br_vital_weight_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV59BR_VitalIDTitleFilterData", AV59BR_VitalIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV17BR_Vital_MeasureDateTitleFilterData", AV17BR_Vital_MeasureDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV23BR_Vital_WeightTitleFilterData", AV23BR_Vital_WeightTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV27BR_Vital_TemperatureTitleFilterData", AV27BR_Vital_TemperatureTitleFilterData);
      }

      protected void E16602( )
      {
         /* Ddo_br_vital_temperature_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_vital_temperature_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV14OrderedBy = 4;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14OrderedBy), 4, 0)));
            AV15OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV15OrderedDsc", AV15OrderedDsc);
            Ddo_br_vital_temperature_Sortedstatus = "ASC";
            ucDdo_br_vital_temperature.SendProperty(context, sPrefix, false, Ddo_br_vital_temperature_Internalname, "SortedStatus", Ddo_br_vital_temperature_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         else if ( StringUtil.StrCmp(Ddo_br_vital_temperature_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S162 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV14OrderedBy = 4;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14OrderedBy), 4, 0)));
            AV15OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV15OrderedDsc", AV15OrderedDsc);
            Ddo_br_vital_temperature_Sortedstatus = "DSC";
            ucDdo_br_vital_temperature.SendProperty(context, sPrefix, false, Ddo_br_vital_temperature_Internalname, "SortedStatus", Ddo_br_vital_temperature_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         else if ( StringUtil.StrCmp(Ddo_br_vital_temperature_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV28TFBR_Vital_Temperature = NumberUtil.Val( Ddo_br_vital_temperature_Filteredtext_get, ".");
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV28TFBR_Vital_Temperature", StringUtil.LTrim( StringUtil.Str( AV28TFBR_Vital_Temperature, 15, 5)));
            AV29TFBR_Vital_Temperature_To = NumberUtil.Val( Ddo_br_vital_temperature_Filteredtextto_get, ".");
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV29TFBR_Vital_Temperature_To", StringUtil.LTrim( StringUtil.Str( AV29TFBR_Vital_Temperature_To, 15, 5)));
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV59BR_VitalIDTitleFilterData", AV59BR_VitalIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV17BR_Vital_MeasureDateTitleFilterData", AV17BR_Vital_MeasureDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV23BR_Vital_WeightTitleFilterData", AV23BR_Vital_WeightTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV27BR_Vital_TemperatureTitleFilterData", AV27BR_Vital_TemperatureTitleFilterData);
      }

      private void E20602( )
      {
         /* Grid_Load Routine */
         AV53Display = context.GetImagePath( "f11923b6-6acd-4a79-bfc0-0cfc6f3bced5", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, edtavDisplay_Internalname, AV53Display);
         AV74Display_GXI = GXDbFile.PathToUrl( context.GetImagePath( "f11923b6-6acd-4a79-bfc0-0cfc6f3bced5", "", context.GetTheme( )));
         edtavDisplay_Tooltiptext = "显示";
         if ( AV54IsAuthorized_Display )
         {
            edtavDisplay_Link = formatLink("br_vitalview.aspx") + "?" + UrlEncode("" +A150BR_VitalID) + "," + UrlEncode(StringUtil.RTrim(""));
         }
         AV55Update = context.GetImagePath( "7c63c2b9-483e-4035-b512-febf9186a274", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, edtavUpdate_Internalname, AV55Update);
         AV75Update_GXI = GXDbFile.PathToUrl( context.GetImagePath( "7c63c2b9-483e-4035-b512-febf9186a274", "", context.GetTheme( )));
         edtavUpdate_Tooltiptext = "修改";
         if ( AV56IsAuthorized_Update )
         {
            edtavUpdate_Link = formatLink("br_vital.aspx") + "?" + UrlEncode(StringUtil.RTrim("UPD")) + "," + UrlEncode("" +A150BR_VitalID);
         }
         AV57Delete = context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, edtavDelete_Internalname, AV57Delete);
         AV76Delete_GXI = GXDbFile.PathToUrl( context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", context.GetTheme( )));
         edtavDelete_Tooltiptext = "删除";
         if ( AV58IsAuthorized_Delete )
         {
            edtavDelete_Link = formatLink("br_vital.aspx") + "?" + UrlEncode(StringUtil.RTrim("DLT")) + "," + UrlEncode("" +A150BR_VitalID);
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

      protected void E17602( )
      {
         /* 'DoInsert' Routine */
         if ( 1 == 0 )
         {
            CallWebObject(formatLink("br_vital.aspx") + "?" + UrlEncode(StringUtil.RTrim("INS")) + "," + UrlEncode("" +0));
            context.wjLocDisableFrm = 1;
         }
         CallWebObject(formatLink("br_vitalinsert.aspx") + "?" + UrlEncode("" +AV8BR_EncounterID));
         context.wjLocDisableFrm = 1;
      }

      protected void S162( )
      {
         /* 'RESETDDOSORTEDSTATUS' Routine */
         Ddo_br_vitalid_Sortedstatus = "";
         ucDdo_br_vitalid.SendProperty(context, sPrefix, false, Ddo_br_vitalid_Internalname, "SortedStatus", Ddo_br_vitalid_Sortedstatus);
         Ddo_br_vital_measuredate_Sortedstatus = "";
         ucDdo_br_vital_measuredate.SendProperty(context, sPrefix, false, Ddo_br_vital_measuredate_Internalname, "SortedStatus", Ddo_br_vital_measuredate_Sortedstatus);
         Ddo_br_vital_weight_Sortedstatus = "";
         ucDdo_br_vital_weight.SendProperty(context, sPrefix, false, Ddo_br_vital_weight_Internalname, "SortedStatus", Ddo_br_vital_weight_Sortedstatus);
         Ddo_br_vital_temperature_Sortedstatus = "";
         ucDdo_br_vital_temperature.SendProperty(context, sPrefix, false, Ddo_br_vital_temperature_Internalname, "SortedStatus", Ddo_br_vital_temperature_Sortedstatus);
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
         if ( AV14OrderedBy == 1 )
         {
            Ddo_br_vitalid_Sortedstatus = (AV15OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_vitalid.SendProperty(context, sPrefix, false, Ddo_br_vitalid_Internalname, "SortedStatus", Ddo_br_vitalid_Sortedstatus);
         }
         else if ( AV14OrderedBy == 2 )
         {
            Ddo_br_vital_measuredate_Sortedstatus = (AV15OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_vital_measuredate.SendProperty(context, sPrefix, false, Ddo_br_vital_measuredate_Internalname, "SortedStatus", Ddo_br_vital_measuredate_Sortedstatus);
         }
         else if ( AV14OrderedBy == 3 )
         {
            Ddo_br_vital_weight_Sortedstatus = (AV15OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_vital_weight.SendProperty(context, sPrefix, false, Ddo_br_vital_weight_Internalname, "SortedStatus", Ddo_br_vital_weight_Sortedstatus);
         }
         else if ( AV14OrderedBy == 4 )
         {
            Ddo_br_vital_temperature_Sortedstatus = (AV15OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_vital_temperature.SendProperty(context, sPrefix, false, Ddo_br_vital_temperature_Internalname, "SortedStatus", Ddo_br_vital_temperature_Sortedstatus);
         }
      }

      protected void S142( )
      {
         /* 'CHECKSECURITYFORACTIONS' Routine */
         GXt_boolean2 = AV54IsAuthorized_Display;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Vital", out  GXt_boolean2) ;
         AV54IsAuthorized_Display = GXt_boolean2;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV54IsAuthorized_Display", AV54IsAuthorized_Display);
         if ( ! ( AV54IsAuthorized_Display ) )
         {
            edtavDisplay_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDisplay_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDisplay_Visible), 5, 0)), !bGXsfl_28_Refreshing);
         }
         GXt_boolean2 = AV56IsAuthorized_Update;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Vital", out  GXt_boolean2) ;
         AV56IsAuthorized_Update = GXt_boolean2;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV56IsAuthorized_Update", AV56IsAuthorized_Update);
         if ( ! ( AV56IsAuthorized_Update ) )
         {
            edtavUpdate_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavUpdate_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUpdate_Visible), 5, 0)), !bGXsfl_28_Refreshing);
         }
         GXt_boolean2 = AV58IsAuthorized_Delete;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Vital", out  GXt_boolean2) ;
         AV58IsAuthorized_Delete = GXt_boolean2;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV58IsAuthorized_Delete", AV58IsAuthorized_Delete);
         if ( ! ( AV58IsAuthorized_Delete ) )
         {
            edtavDelete_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDelete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDelete_Visible), 5, 0)), !bGXsfl_28_Refreshing);
         }
         GXt_boolean2 = AV67TempBoolean;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Vital", out  GXt_boolean2) ;
         AV67TempBoolean = GXt_boolean2;
         if ( ! ( AV67TempBoolean ) )
         {
            bttBtninsert_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, bttBtninsert_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtninsert_Visible), 5, 0)), true);
         }
      }

      protected void S122( )
      {
         /* 'LOADGRIDSTATE' Routine */
         if ( StringUtil.StrCmp(AV16Session.Get(AV77Pgmname+"GridState"), "") == 0 )
         {
            AV12GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  AV77Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         else
         {
            AV12GridState.FromXml(AV16Session.Get(AV77Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         AV14OrderedBy = AV12GridState.gxTpr_Orderedby;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14OrderedBy), 4, 0)));
         AV15OrderedDsc = AV12GridState.gxTpr_Ordereddsc;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV15OrderedDsc", AV15OrderedDsc);
         /* Execute user subroutine: 'SETDDOSORTEDSTATUS' */
         S132 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         AV78GXV1 = 1;
         while ( AV78GXV1 <= AV12GridState.gxTpr_Filtervalues.Count )
         {
            AV13GridStateFilterValue = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue)AV12GridState.gxTpr_Filtervalues.Item(AV78GXV1));
            if ( StringUtil.StrCmp(AV13GridStateFilterValue.gxTpr_Name, "TFBR_VITAL_TEMPERATURE") == 0 )
            {
               AV28TFBR_Vital_Temperature = NumberUtil.Val( AV13GridStateFilterValue.gxTpr_Value, ".");
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV28TFBR_Vital_Temperature", StringUtil.LTrim( StringUtil.Str( AV28TFBR_Vital_Temperature, 15, 5)));
               AV29TFBR_Vital_Temperature_To = NumberUtil.Val( AV13GridStateFilterValue.gxTpr_Valueto, ".");
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV29TFBR_Vital_Temperature_To", StringUtil.LTrim( StringUtil.Str( AV29TFBR_Vital_Temperature_To, 15, 5)));
               if ( ! (Convert.ToDecimal(0)==AV28TFBR_Vital_Temperature) )
               {
                  Ddo_br_vital_temperature_Filteredtext_set = StringUtil.Str( AV28TFBR_Vital_Temperature, 15, 5);
                  ucDdo_br_vital_temperature.SendProperty(context, sPrefix, false, Ddo_br_vital_temperature_Internalname, "FilteredText_set", Ddo_br_vital_temperature_Filteredtext_set);
               }
               if ( ! (Convert.ToDecimal(0)==AV29TFBR_Vital_Temperature_To) )
               {
                  Ddo_br_vital_temperature_Filteredtextto_set = StringUtil.Str( AV29TFBR_Vital_Temperature_To, 15, 5);
                  ucDdo_br_vital_temperature.SendProperty(context, sPrefix, false, Ddo_br_vital_temperature_Internalname, "FilteredTextTo_set", Ddo_br_vital_temperature_Filteredtextto_set);
               }
            }
            AV78GXV1 = (int)(AV78GXV1+1);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( StringUtil.Trim( AV12GridState.gxTpr_Pagesize))) )
         {
            subGrid_Rows = (int)(NumberUtil.Val( AV12GridState.gxTpr_Pagesize, "."));
            GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         }
      }

      protected void S152( )
      {
         /* 'SAVEGRIDSTATE' Routine */
         AV12GridState.FromXml(AV16Session.Get(AV77Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         AV12GridState.gxTpr_Orderedby = AV14OrderedBy;
         AV12GridState.gxTpr_Ordereddsc = AV15OrderedDsc;
         AV12GridState.gxTpr_Filtervalues.Clear();
         if ( ! ( (Convert.ToDecimal(0)==AV28TFBR_Vital_Temperature) && (Convert.ToDecimal(0)==AV29TFBR_Vital_Temperature_To) ) )
         {
            AV13GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV13GridStateFilterValue.gxTpr_Name = "TFBR_VITAL_TEMPERATURE";
            AV13GridStateFilterValue.gxTpr_Value = StringUtil.Str( AV28TFBR_Vital_Temperature, 15, 5);
            AV13GridStateFilterValue.gxTpr_Valueto = StringUtil.Str( AV29TFBR_Vital_Temperature_To, 15, 5);
            AV12GridState.gxTpr_Filtervalues.Add(AV13GridStateFilterValue, 0);
         }
         AV12GridState.gxTpr_Pagesize = StringUtil.Str( (decimal)(subGrid_Rows), 10, 0);
         new GeneXus.Programs.wwpbaseobjects.savegridstate(context ).execute(  AV77Pgmname+"GridState",  AV12GridState.ToXml(false, true, "WWPGridState", "DataAnalysisPlatform")) ;
      }

      protected void S112( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV10TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV10TrnContext.gxTpr_Callerobject = AV77Pgmname;
         AV10TrnContext.gxTpr_Callerondelete = true;
         AV10TrnContext.gxTpr_Callerurl = AV9HTTPRequest.ScriptName+"?"+AV9HTTPRequest.QueryString;
         AV10TrnContext.gxTpr_Transactionname = "BR_Vital";
         AV11TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         AV11TrnContextAtt.gxTpr_Attributename = "BR_EncounterID";
         AV11TrnContextAtt.gxTpr_Attributevalue = StringUtil.Str( (decimal)(AV8BR_EncounterID), 18, 0);
         AV10TrnContext.gxTpr_Attributes.Add(AV11TrnContextAtt, 0);
         AV16Session.Set("TrnContext", AV10TrnContext.ToXml(false, true, "WWPTransactionContext", "DataAnalysisPlatform"));
      }

      protected void E21602( )
      {
         /* Update_Click Routine */
         new zutil_checksession(context ).execute( out  AV71tCheckFlag) ;
         if ( ! AV71tCheckFlag )
         {
            CallWebObject(formatLink("br_vitalupdate.aspx") + "?" + UrlEncode("" +A150BR_VitalID));
            context.wjLocDisableFrm = 1;
         }
      }

      protected void E22602( )
      {
         /* Delete_Click Routine */
         new zutil_checksession(context ).execute( out  AV71tCheckFlag) ;
         if ( ! AV71tCheckFlag )
         {
            CallWebObject(formatLink("br_vitaldelete.aspx") + "?" + UrlEncode("" +A150BR_VitalID));
            context.wjLocDisableFrm = 1;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV8BR_EncounterID = Convert.ToInt64(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV8BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8BR_EncounterID), 18, 0)));
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
         PA602( ) ;
         WS602( ) ;
         WE602( ) ;
         this.cleanup();
         context.SetWrapped(false);
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
         return "";
      }

      public void responsestatic( String sGXDynURL )
      {
      }

      public override void componentbind( Object[] obj )
      {
         if ( IsUrlCreated( ) )
         {
            return  ;
         }
         sCtrlAV8BR_EncounterID = (String)((String)getParm(obj,0));
      }

      public override void componentrestorestate( String sPPrefix ,
                                                  String sPSFPrefix )
      {
         sPrefix = sPPrefix + sPSFPrefix;
         PA602( ) ;
         WCParametersGet( ) ;
      }

      public override void componentprepare( Object[] obj )
      {
         wbLoad = false;
         sCompPrefix = (String)getParm(obj,0);
         sSFPrefix = (String)getParm(obj,1);
         sPrefix = sCompPrefix + sSFPrefix;
         AddComponentObject(sPrefix, "br_encounterupdatebr_vitalwc", GetJustCreated( ));
         if ( ( nDoneStart == 0 ) && ( nDynComponent == 0 ) )
         {
            INITWEB( ) ;
         }
         else
         {
            init_default_properties( ) ;
            init_web_controls( ) ;
         }
         PA602( ) ;
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) && ( context.wbGlbDoneStart == 0 ) )
         {
            WCParametersGet( ) ;
         }
         else
         {
            AV8BR_EncounterID = Convert.ToInt64(getParm(obj,2));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV8BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8BR_EncounterID), 18, 0)));
         }
         wcpOAV8BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOAV8BR_EncounterID"), ".", ","));
         if ( ! GetJustCreated( ) && ( ( AV8BR_EncounterID != wcpOAV8BR_EncounterID ) ) )
         {
            setjustcreated();
         }
         wcpOAV8BR_EncounterID = AV8BR_EncounterID;
      }

      protected void WCParametersGet( )
      {
         /* Read Component Parameters. */
         sCtrlAV8BR_EncounterID = cgiGet( sPrefix+"AV8BR_EncounterID_CTRL");
         if ( StringUtil.Len( sCtrlAV8BR_EncounterID) > 0 )
         {
            AV8BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( sCtrlAV8BR_EncounterID), ".", ","));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV8BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8BR_EncounterID), 18, 0)));
         }
         else
         {
            AV8BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( sPrefix+"AV8BR_EncounterID_PARM"), ".", ","));
         }
      }

      public override void componentprocess( String sPPrefix ,
                                             String sPSFPrefix ,
                                             String sCompEvt )
      {
         sCompPrefix = sPPrefix;
         sSFPrefix = sPSFPrefix;
         sPrefix = sCompPrefix + sSFPrefix;
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         INITWEB( ) ;
         nDraw = 0;
         PA602( ) ;
         sEvt = sCompEvt;
         WCParametersGet( ) ;
         WS602( ) ;
         if ( isFullAjaxMode( ) )
         {
            componentdraw();
         }
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
      }

      public override void componentstart( )
      {
         if ( nDoneStart == 0 )
         {
            WCStart( ) ;
         }
      }

      protected void WCStart( )
      {
         nDraw = 1;
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         WS602( ) ;
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
      }

      protected void WCParametersSet( )
      {
         GxWebStd.gx_hidden_field( context, sPrefix+"AV8BR_EncounterID_PARM", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8BR_EncounterID), 18, 0, ".", "")));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlAV8BR_EncounterID)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"AV8BR_EncounterID_CTRL", StringUtil.RTrim( sCtrlAV8BR_EncounterID));
         }
      }

      public override void componentdraw( )
      {
         if ( nDoneStart == 0 )
         {
            WCStart( ) ;
         }
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         WCParametersSet( ) ;
         WE602( ) ;
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst;
      }

      public override String getstring( String sGXControl )
      {
         String sCtrlName ;
         if ( StringUtil.StrCmp(StringUtil.Substring( sGXControl, 1, 1), "&") == 0 )
         {
            sCtrlName = StringUtil.Substring( sGXControl, 2, StringUtil.Len( sGXControl)-1);
         }
         else
         {
            sCtrlName = sGXControl;
         }
         return cgiGet( sPrefix+"v"+StringUtil.Upper( sCtrlName)) ;
      }

      public override void componentjscripts( )
      {
         include_jscripts( ) ;
      }

      public override void componentthemes( )
      {
         define_styles( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202022711571095", true);
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
         context.AddJavascriptSource("br_encounterupdatebr_vitalwc.js", "?202022711571096", false);
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
         context.AddJavascriptSource("DVelop/WorkWithPlusUtilities/WorkWithPlusUtilitiesRender.js", "", false);
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_282( )
      {
         edtavDisplay_Internalname = sPrefix+"vDISPLAY_"+sGXsfl_28_idx;
         edtavUpdate_Internalname = sPrefix+"vUPDATE_"+sGXsfl_28_idx;
         edtavDelete_Internalname = sPrefix+"vDELETE_"+sGXsfl_28_idx;
         edtBR_VitalID_Internalname = sPrefix+"BR_VITALID_"+sGXsfl_28_idx;
         edtBR_Vital_MeasureDate_Internalname = sPrefix+"BR_VITAL_MEASUREDATE_"+sGXsfl_28_idx;
         edtBR_Vital_Weight_Internalname = sPrefix+"BR_VITAL_WEIGHT_"+sGXsfl_28_idx;
         edtBR_Vital_Temperature_Internalname = sPrefix+"BR_VITAL_TEMPERATURE_"+sGXsfl_28_idx;
      }

      protected void SubsflControlProps_fel_282( )
      {
         edtavDisplay_Internalname = sPrefix+"vDISPLAY_"+sGXsfl_28_fel_idx;
         edtavUpdate_Internalname = sPrefix+"vUPDATE_"+sGXsfl_28_fel_idx;
         edtavDelete_Internalname = sPrefix+"vDELETE_"+sGXsfl_28_fel_idx;
         edtBR_VitalID_Internalname = sPrefix+"BR_VITALID_"+sGXsfl_28_fel_idx;
         edtBR_Vital_MeasureDate_Internalname = sPrefix+"BR_VITAL_MEASUREDATE_"+sGXsfl_28_fel_idx;
         edtBR_Vital_Weight_Internalname = sPrefix+"BR_VITAL_WEIGHT_"+sGXsfl_28_fel_idx;
         edtBR_Vital_Temperature_Internalname = sPrefix+"BR_VITAL_TEMPERATURE_"+sGXsfl_28_fel_idx;
      }

      protected void sendrow_282( )
      {
         SubsflControlProps_282( ) ;
         WB600( ) ;
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
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((edtavDisplay_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "ActionBaseColorAttribute";
            StyleString = "";
            AV53Display_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV53Display))&&String.IsNullOrEmpty(StringUtil.RTrim( AV74Display_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV53Display)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV53Display)) ? AV74Display_GXI : context.PathToRelativeUrl( AV53Display));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavDisplay_Internalname,(String)sImgUrl,(String)edtavDisplay_Link,(String)"",(String)"",context.GetTheme( ),(int)edtavDisplay_Visible,(short)1,(String)"",(String)edtavDisplay_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV53Display_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((edtavUpdate_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Active Bitmap Variable */
            TempTags = " " + ((edtavUpdate_Enabled!=0)&&(edtavUpdate_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 30,'"+sPrefix+"',false,'',28)\"" : " ");
            ClassString = "ActionBaseColorAttribute";
            StyleString = "";
            AV55Update_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV55Update))&&String.IsNullOrEmpty(StringUtil.RTrim( AV75Update_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV55Update)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV55Update)) ? AV75Update_GXI : context.PathToRelativeUrl( AV55Update));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavUpdate_Internalname,(String)sImgUrl,(String)"",(String)"",(String)"",context.GetTheme( ),(int)edtavUpdate_Visible,(short)1,(String)"",(String)edtavUpdate_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)5,(String)edtavUpdate_Jsonclick,"'"+sPrefix+"'"+",false,"+"'"+sPrefix+"EVUPDATE.CLICK."+sGXsfl_28_idx+"'",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)""+TempTags,(String)"",(String)"",(short)1,(bool)AV55Update_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((edtavDelete_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Active Bitmap Variable */
            TempTags = " " + ((edtavDelete_Enabled!=0)&&(edtavDelete_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 31,'"+sPrefix+"',false,'',28)\"" : " ");
            ClassString = "DeleteAttribute ActionBaseColorAttribute";
            StyleString = "";
            AV57Delete_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV57Delete))&&String.IsNullOrEmpty(StringUtil.RTrim( AV76Delete_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV57Delete)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV57Delete)) ? AV76Delete_GXI : context.PathToRelativeUrl( AV57Delete));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavDelete_Internalname,(String)sImgUrl,(String)"",(String)"",(String)"",context.GetTheme( ),(int)edtavDelete_Visible,(short)1,(String)"",(String)edtavDelete_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)5,(String)edtavDelete_Jsonclick,"'"+sPrefix+"'"+",false,"+"'"+sPrefix+"EVDELETE.CLICK."+sGXsfl_28_idx+"'",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)""+TempTags,(String)"",(String)"",(short)1,(bool)AV57Delete_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_VitalID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A150BR_VitalID), 18, 0, ".", "")),context.localUtil.Format( (decimal)(A150BR_VitalID), "ZZZZZZZZZZZZZZZZZZ"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_VitalID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs hidden-sm",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)28,(short)1,(short)-1,(short)0,(bool)true,(String)"ID",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Vital_MeasureDate_Internalname,context.localUtil.Format(A152BR_Vital_MeasureDate, "9999/99/99"),context.localUtil.Format( A152BR_Vital_MeasureDate, "9999/99/99"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Vital_MeasureDate_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)28,(short)1,(short)-1,(short)0,(bool)true,(String)"DM_Date",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Vital_Weight_Internalname,StringUtil.LTrim( StringUtil.NToC( A159BR_Vital_Weight, 15, 5, ".", "")),context.localUtil.Format( A159BR_Vital_Weight, "ZZZZZZZZZ.ZZZZZ"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Vital_Weight_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs hidden-sm",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)15,(short)0,(short)0,(short)28,(short)1,(short)-1,(short)0,(bool)true,(String)"DM_Numeric",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Vital_Temperature_Internalname,StringUtil.LTrim( StringUtil.NToC( A153BR_Vital_Temperature, 15, 5, ".", "")),context.localUtil.Format( A153BR_Vital_Temperature, "ZZZZZZZZZ.ZZZZZ"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Vital_Temperature_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)15,(short)0,(short)0,(short)28,(short)1,(short)-1,(short)0,(bool)true,(String)"DM_Numeric",(String)"right",(bool)false});
            send_integrity_lvl_hashes602( ) ;
            GridContainer.AddRow(GridRow);
            nGXsfl_28_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_28_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_28_idx+1));
            sGXsfl_28_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_28_idx), 4, 0)), 4, "0");
            SubsflControlProps_282( ) ;
         }
         /* End function sendrow_282 */
      }

      protected void init_web_controls( )
      {
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         bttBtninsert_Internalname = sPrefix+"BTNINSERT";
         divTableactions_Internalname = sPrefix+"TABLEACTIONS";
         divTableheader_Internalname = sPrefix+"TABLEHEADER";
         divLayout_tableheader_Internalname = sPrefix+"LAYOUT_TABLEHEADER";
         Dvpanel_tableheader_Internalname = sPrefix+"DVPANEL_TABLEHEADER";
         divHtml_dvpanel_tableheader_Internalname = sPrefix+"HTML_DVPANEL_TABLEHEADER";
         edtavDisplay_Internalname = sPrefix+"vDISPLAY";
         edtavUpdate_Internalname = sPrefix+"vUPDATE";
         edtavDelete_Internalname = sPrefix+"vDELETE";
         edtBR_VitalID_Internalname = sPrefix+"BR_VITALID";
         edtBR_Vital_MeasureDate_Internalname = sPrefix+"BR_VITAL_MEASUREDATE";
         edtBR_Vital_Weight_Internalname = sPrefix+"BR_VITAL_WEIGHT";
         edtBR_Vital_Temperature_Internalname = sPrefix+"BR_VITAL_TEMPERATURE";
         Gridpaginationbar_Internalname = sPrefix+"GRIDPAGINATIONBAR";
         divHtml_gridpaginationbar_Internalname = sPrefix+"HTML_GRIDPAGINATIONBAR";
         divGridtablewithpaginationbar_Internalname = sPrefix+"GRIDTABLEWITHPAGINATIONBAR";
         divTablegridheader_Internalname = sPrefix+"TABLEGRIDHEADER";
         Ddo_br_vitalid_Internalname = sPrefix+"DDO_BR_VITALID";
         edtavDdo_br_vitalidtitlecontrolidtoreplace_Internalname = sPrefix+"vDDO_BR_VITALIDTITLECONTROLIDTOREPLACE";
         Ddo_br_vital_measuredate_Internalname = sPrefix+"DDO_BR_VITAL_MEASUREDATE";
         edtavDdo_br_vital_measuredatetitlecontrolidtoreplace_Internalname = sPrefix+"vDDO_BR_VITAL_MEASUREDATETITLECONTROLIDTOREPLACE";
         Ddo_br_vital_weight_Internalname = sPrefix+"DDO_BR_VITAL_WEIGHT";
         edtavDdo_br_vital_weighttitlecontrolidtoreplace_Internalname = sPrefix+"vDDO_BR_VITAL_WEIGHTTITLECONTROLIDTOREPLACE";
         Ddo_br_vital_temperature_Internalname = sPrefix+"DDO_BR_VITAL_TEMPERATURE";
         edtavDdo_br_vital_temperaturetitlecontrolidtoreplace_Internalname = sPrefix+"vDDO_BR_VITAL_TEMPERATURETITLECONTROLIDTOREPLACE";
         edtBR_EncounterID_Internalname = sPrefix+"BR_ENCOUNTERID";
         Workwithplusutilities1_Internalname = sPrefix+"WORKWITHPLUSUTILITIES1";
         edtavOrderedby_Internalname = sPrefix+"vORDEREDBY";
         edtavOrdereddsc_Internalname = sPrefix+"vORDEREDDSC";
         edtavTfbr_vital_temperature_Internalname = sPrefix+"vTFBR_VITAL_TEMPERATURE";
         edtavTfbr_vital_temperature_to_Internalname = sPrefix+"vTFBR_VITAL_TEMPERATURE_TO";
         divHtml_bottomauxiliarcontrols_Internalname = sPrefix+"HTML_BOTTOMAUXILIARCONTROLS";
         divLayoutmaintable_Internalname = sPrefix+"LAYOUTMAINTABLE";
         Form.Internalname = sPrefix+"FORM";
         subGrid_Internalname = sPrefix+"GRID";
      }

      public override void initialize_properties( )
      {
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            context.SetDefaultTheme("WorkWithPlusTheme");
         }
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( context.isSpaRequest( ) )
            {
               disableJsOutput();
            }
         }
         init_default_properties( ) ;
         edtBR_Vital_Temperature_Jsonclick = "";
         edtBR_Vital_Weight_Jsonclick = "";
         edtBR_Vital_MeasureDate_Jsonclick = "";
         edtBR_VitalID_Jsonclick = "";
         edtavDelete_Jsonclick = "";
         edtavDelete_Enabled = 1;
         edtavUpdate_Jsonclick = "";
         edtavUpdate_Enabled = 1;
         edtavTfbr_vital_temperature_to_Jsonclick = "";
         edtavTfbr_vital_temperature_to_Visible = 1;
         edtavTfbr_vital_temperature_Jsonclick = "";
         edtavTfbr_vital_temperature_Visible = 1;
         edtavOrdereddsc_Jsonclick = "";
         edtavOrdereddsc_Visible = 1;
         edtavOrderedby_Jsonclick = "";
         edtavOrderedby_Visible = 1;
         edtBR_EncounterID_Jsonclick = "";
         edtBR_EncounterID_Visible = 1;
         edtavDdo_br_vital_temperaturetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_vital_weighttitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_vital_measuredatetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_vitalidtitlecontrolidtoreplace_Visible = 1;
         subGrid_Allowcollapsing = 0;
         subGrid_Allowselection = 0;
         edtavDelete_Tooltiptext = "删除";
         edtavDelete_Link = "";
         edtavUpdate_Tooltiptext = "修改";
         edtavUpdate_Link = "";
         edtavDisplay_Tooltiptext = "显示";
         edtavDisplay_Link = "";
         subGrid_Sortable = 0;
         subGrid_Header = "";
         edtBR_Vital_Temperature_Titleformat = 0;
         edtBR_Vital_Temperature_Title = "体温(℃)";
         edtBR_Vital_Weight_Titleformat = 0;
         edtBR_Vital_Weight_Title = "体重(kg)";
         edtBR_Vital_MeasureDate_Titleformat = 0;
         edtBR_Vital_MeasureDate_Title = "测量日期";
         edtBR_VitalID_Titleformat = 0;
         edtBR_VitalID_Title = "序号";
         edtavDelete_Visible = -1;
         edtavUpdate_Visible = -1;
         edtavDisplay_Visible = -1;
         subGrid_Class = "GridWithPaginationBar GridWithBorderColor WorkWith";
         subGrid_Backcolorstyle = 0;
         bttBtninsert_Visible = 1;
         Ddo_br_vital_temperature_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_vital_temperature_Rangefilterto = "WWP_TSTo";
         Ddo_br_vital_temperature_Rangefilterfrom = "WWP_TSFrom";
         Ddo_br_vital_temperature_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_vital_temperature_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_vital_temperature_Sortasc = "WWP_TSSortASC";
         Ddo_br_vital_temperature_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_vital_temperature_Filterisrange = Convert.ToBoolean( -1);
         Ddo_br_vital_temperature_Filtertype = "Numeric";
         Ddo_br_vital_temperature_Includefilter = Convert.ToBoolean( -1);
         Ddo_br_vital_temperature_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_vital_temperature_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_vital_temperature_Titlecontrolidtoreplace = "";
         Ddo_br_vital_temperature_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_vital_temperature_Cls = "ColumnSettings";
         Ddo_br_vital_temperature_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_vital_temperature_Caption = "";
         Ddo_br_vital_weight_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_vital_weight_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_vital_weight_Sortasc = "WWP_TSSortASC";
         Ddo_br_vital_weight_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_vital_weight_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_vital_weight_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_vital_weight_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_vital_weight_Titlecontrolidtoreplace = "";
         Ddo_br_vital_weight_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_vital_weight_Cls = "ColumnSettings";
         Ddo_br_vital_weight_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_vital_weight_Caption = "";
         Ddo_br_vital_measuredate_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_vital_measuredate_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_vital_measuredate_Sortasc = "WWP_TSSortASC";
         Ddo_br_vital_measuredate_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_vital_measuredate_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_vital_measuredate_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_vital_measuredate_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_vital_measuredate_Titlecontrolidtoreplace = "";
         Ddo_br_vital_measuredate_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_vital_measuredate_Cls = "ColumnSettings";
         Ddo_br_vital_measuredate_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_vital_measuredate_Caption = "";
         Ddo_br_vitalid_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_vitalid_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_vitalid_Sortasc = "WWP_TSSortASC";
         Ddo_br_vitalid_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_vitalid_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_vitalid_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_vitalid_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_vitalid_Titlecontrolidtoreplace = "";
         Ddo_br_vitalid_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_vitalid_Cls = "ColumnSettings";
         Ddo_br_vitalid_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_vitalid_Caption = "";
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
         subGrid_Rows = 0;
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            if ( context.isSpaRequest( ) )
            {
               enableJsOutput();
            }
         }
      }

      public override bool SupportAjaxEvent( )
      {
         return true ;
      }

      public override void InitializeDynEvents( )
      {
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV54IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'AV56IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV58IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'sPrefix'},{av:'AV62ddo_BR_VitalIDTitleControlIdToReplace',fld:'vDDO_BR_VITALIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Vital_MeasureDateTitleControlIdToReplace',fld:'vDDO_BR_VITAL_MEASUREDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Vital_WeightTitleControlIdToReplace',fld:'vDDO_BR_VITAL_WEIGHTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_Vital_TemperatureTitleControlIdToReplace',fld:'vDDO_BR_VITAL_TEMPERATURETITLECONTROLIDTOREPLACE',pic:''},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV77Pgmname',fld:'vPGMNAME',pic:''},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV28TFBR_Vital_Temperature',fld:'vTFBR_VITAL_TEMPERATURE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV29TFBR_Vital_Temperature_To',fld:'vTFBR_VITAL_TEMPERATURE_TO',pic:'ZZZZZZZZZ.ZZZZZ'}]");
         setEventMetadata("REFRESH",",oparms:[{av:'AV59BR_VitalIDTitleFilterData',fld:'vBR_VITALIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Vital_MeasureDateTitleFilterData',fld:'vBR_VITAL_MEASUREDATETITLEFILTERDATA',pic:''},{av:'AV23BR_Vital_WeightTitleFilterData',fld:'vBR_VITAL_WEIGHTTITLEFILTERDATA',pic:''},{av:'AV27BR_Vital_TemperatureTitleFilterData',fld:'vBR_VITAL_TEMPERATURETITLEFILTERDATA',pic:''},{av:'edtBR_VitalID_Titleformat',ctrl:'BR_VITALID',prop:'Titleformat'},{av:'edtBR_VitalID_Title',ctrl:'BR_VITALID',prop:'Title'},{av:'edtBR_Vital_MeasureDate_Titleformat',ctrl:'BR_VITAL_MEASUREDATE',prop:'Titleformat'},{av:'edtBR_Vital_MeasureDate_Title',ctrl:'BR_VITAL_MEASUREDATE',prop:'Title'},{av:'edtBR_Vital_Weight_Titleformat',ctrl:'BR_VITAL_WEIGHT',prop:'Titleformat'},{av:'edtBR_Vital_Weight_Title',ctrl:'BR_VITAL_WEIGHT',prop:'Title'},{av:'edtBR_Vital_Temperature_Titleformat',ctrl:'BR_VITAL_TEMPERATURE',prop:'Titleformat'},{av:'edtBR_Vital_Temperature_Title',ctrl:'BR_VITAL_TEMPERATURE',prop:'Title'},{av:'AV50GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV51GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV52GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV54IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'edtavDisplay_Visible',ctrl:'vDISPLAY',prop:'Visible'},{av:'AV56IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV58IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE","{handler:'E11602',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV28TFBR_Vital_Temperature',fld:'vTFBR_VITAL_TEMPERATURE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV29TFBR_Vital_Temperature_To',fld:'vTFBR_VITAL_TEMPERATURE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV62ddo_BR_VitalIDTitleControlIdToReplace',fld:'vDDO_BR_VITALIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Vital_MeasureDateTitleControlIdToReplace',fld:'vDDO_BR_VITAL_MEASUREDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Vital_WeightTitleControlIdToReplace',fld:'vDDO_BR_VITAL_WEIGHTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_Vital_TemperatureTitleControlIdToReplace',fld:'vDDO_BR_VITAL_TEMPERATURETITLECONTROLIDTOREPLACE',pic:''},{av:'AV77Pgmname',fld:'vPGMNAME',pic:''},{av:'AV54IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'AV56IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV58IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'sPrefix'},{av:'Gridpaginationbar_Selectedpage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE",",oparms:[]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE","{handler:'E12602',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV28TFBR_Vital_Temperature',fld:'vTFBR_VITAL_TEMPERATURE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV29TFBR_Vital_Temperature_To',fld:'vTFBR_VITAL_TEMPERATURE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV62ddo_BR_VitalIDTitleControlIdToReplace',fld:'vDDO_BR_VITALIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Vital_MeasureDateTitleControlIdToReplace',fld:'vDDO_BR_VITAL_MEASUREDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Vital_WeightTitleControlIdToReplace',fld:'vDDO_BR_VITAL_WEIGHTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_Vital_TemperatureTitleControlIdToReplace',fld:'vDDO_BR_VITAL_TEMPERATURETITLECONTROLIDTOREPLACE',pic:''},{av:'AV77Pgmname',fld:'vPGMNAME',pic:''},{av:'AV54IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'AV56IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV58IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'sPrefix'},{av:'Gridpaginationbar_Rowsperpageselectedvalue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE",",oparms:[{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]}");
         setEventMetadata("DDO_BR_VITALID.ONOPTIONCLICKED","{handler:'E13602',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV28TFBR_Vital_Temperature',fld:'vTFBR_VITAL_TEMPERATURE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV29TFBR_Vital_Temperature_To',fld:'vTFBR_VITAL_TEMPERATURE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV62ddo_BR_VitalIDTitleControlIdToReplace',fld:'vDDO_BR_VITALIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Vital_MeasureDateTitleControlIdToReplace',fld:'vDDO_BR_VITAL_MEASUREDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Vital_WeightTitleControlIdToReplace',fld:'vDDO_BR_VITAL_WEIGHTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_Vital_TemperatureTitleControlIdToReplace',fld:'vDDO_BR_VITAL_TEMPERATURETITLECONTROLIDTOREPLACE',pic:''},{av:'AV77Pgmname',fld:'vPGMNAME',pic:''},{av:'AV54IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'AV56IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV58IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'sPrefix'},{av:'Ddo_br_vitalid_Activeeventkey',ctrl:'DDO_BR_VITALID',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_VITALID.ONOPTIONCLICKED",",oparms:[{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_vitalid_Sortedstatus',ctrl:'DDO_BR_VITALID',prop:'SortedStatus'},{av:'Ddo_br_vital_measuredate_Sortedstatus',ctrl:'DDO_BR_VITAL_MEASUREDATE',prop:'SortedStatus'},{av:'Ddo_br_vital_weight_Sortedstatus',ctrl:'DDO_BR_VITAL_WEIGHT',prop:'SortedStatus'},{av:'Ddo_br_vital_temperature_Sortedstatus',ctrl:'DDO_BR_VITAL_TEMPERATURE',prop:'SortedStatus'},{av:'AV59BR_VitalIDTitleFilterData',fld:'vBR_VITALIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Vital_MeasureDateTitleFilterData',fld:'vBR_VITAL_MEASUREDATETITLEFILTERDATA',pic:''},{av:'AV23BR_Vital_WeightTitleFilterData',fld:'vBR_VITAL_WEIGHTTITLEFILTERDATA',pic:''},{av:'AV27BR_Vital_TemperatureTitleFilterData',fld:'vBR_VITAL_TEMPERATURETITLEFILTERDATA',pic:''},{av:'edtBR_VitalID_Titleformat',ctrl:'BR_VITALID',prop:'Titleformat'},{av:'edtBR_VitalID_Title',ctrl:'BR_VITALID',prop:'Title'},{av:'edtBR_Vital_MeasureDate_Titleformat',ctrl:'BR_VITAL_MEASUREDATE',prop:'Titleformat'},{av:'edtBR_Vital_MeasureDate_Title',ctrl:'BR_VITAL_MEASUREDATE',prop:'Title'},{av:'edtBR_Vital_Weight_Titleformat',ctrl:'BR_VITAL_WEIGHT',prop:'Titleformat'},{av:'edtBR_Vital_Weight_Title',ctrl:'BR_VITAL_WEIGHT',prop:'Title'},{av:'edtBR_Vital_Temperature_Titleformat',ctrl:'BR_VITAL_TEMPERATURE',prop:'Titleformat'},{av:'edtBR_Vital_Temperature_Title',ctrl:'BR_VITAL_TEMPERATURE',prop:'Title'},{av:'AV50GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV51GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV52GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV54IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'edtavDisplay_Visible',ctrl:'vDISPLAY',prop:'Visible'},{av:'AV56IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV58IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_VITAL_MEASUREDATE.ONOPTIONCLICKED","{handler:'E14602',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV28TFBR_Vital_Temperature',fld:'vTFBR_VITAL_TEMPERATURE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV29TFBR_Vital_Temperature_To',fld:'vTFBR_VITAL_TEMPERATURE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV62ddo_BR_VitalIDTitleControlIdToReplace',fld:'vDDO_BR_VITALIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Vital_MeasureDateTitleControlIdToReplace',fld:'vDDO_BR_VITAL_MEASUREDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Vital_WeightTitleControlIdToReplace',fld:'vDDO_BR_VITAL_WEIGHTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_Vital_TemperatureTitleControlIdToReplace',fld:'vDDO_BR_VITAL_TEMPERATURETITLECONTROLIDTOREPLACE',pic:''},{av:'AV77Pgmname',fld:'vPGMNAME',pic:''},{av:'AV54IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'AV56IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV58IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'sPrefix'},{av:'Ddo_br_vital_measuredate_Activeeventkey',ctrl:'DDO_BR_VITAL_MEASUREDATE',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_VITAL_MEASUREDATE.ONOPTIONCLICKED",",oparms:[{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_vital_measuredate_Sortedstatus',ctrl:'DDO_BR_VITAL_MEASUREDATE',prop:'SortedStatus'},{av:'Ddo_br_vitalid_Sortedstatus',ctrl:'DDO_BR_VITALID',prop:'SortedStatus'},{av:'Ddo_br_vital_weight_Sortedstatus',ctrl:'DDO_BR_VITAL_WEIGHT',prop:'SortedStatus'},{av:'Ddo_br_vital_temperature_Sortedstatus',ctrl:'DDO_BR_VITAL_TEMPERATURE',prop:'SortedStatus'},{av:'AV59BR_VitalIDTitleFilterData',fld:'vBR_VITALIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Vital_MeasureDateTitleFilterData',fld:'vBR_VITAL_MEASUREDATETITLEFILTERDATA',pic:''},{av:'AV23BR_Vital_WeightTitleFilterData',fld:'vBR_VITAL_WEIGHTTITLEFILTERDATA',pic:''},{av:'AV27BR_Vital_TemperatureTitleFilterData',fld:'vBR_VITAL_TEMPERATURETITLEFILTERDATA',pic:''},{av:'edtBR_VitalID_Titleformat',ctrl:'BR_VITALID',prop:'Titleformat'},{av:'edtBR_VitalID_Title',ctrl:'BR_VITALID',prop:'Title'},{av:'edtBR_Vital_MeasureDate_Titleformat',ctrl:'BR_VITAL_MEASUREDATE',prop:'Titleformat'},{av:'edtBR_Vital_MeasureDate_Title',ctrl:'BR_VITAL_MEASUREDATE',prop:'Title'},{av:'edtBR_Vital_Weight_Titleformat',ctrl:'BR_VITAL_WEIGHT',prop:'Titleformat'},{av:'edtBR_Vital_Weight_Title',ctrl:'BR_VITAL_WEIGHT',prop:'Title'},{av:'edtBR_Vital_Temperature_Titleformat',ctrl:'BR_VITAL_TEMPERATURE',prop:'Titleformat'},{av:'edtBR_Vital_Temperature_Title',ctrl:'BR_VITAL_TEMPERATURE',prop:'Title'},{av:'AV50GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV51GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV52GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV54IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'edtavDisplay_Visible',ctrl:'vDISPLAY',prop:'Visible'},{av:'AV56IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV58IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_VITAL_WEIGHT.ONOPTIONCLICKED","{handler:'E15602',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV28TFBR_Vital_Temperature',fld:'vTFBR_VITAL_TEMPERATURE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV29TFBR_Vital_Temperature_To',fld:'vTFBR_VITAL_TEMPERATURE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV62ddo_BR_VitalIDTitleControlIdToReplace',fld:'vDDO_BR_VITALIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Vital_MeasureDateTitleControlIdToReplace',fld:'vDDO_BR_VITAL_MEASUREDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Vital_WeightTitleControlIdToReplace',fld:'vDDO_BR_VITAL_WEIGHTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_Vital_TemperatureTitleControlIdToReplace',fld:'vDDO_BR_VITAL_TEMPERATURETITLECONTROLIDTOREPLACE',pic:''},{av:'AV77Pgmname',fld:'vPGMNAME',pic:''},{av:'AV54IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'AV56IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV58IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'sPrefix'},{av:'Ddo_br_vital_weight_Activeeventkey',ctrl:'DDO_BR_VITAL_WEIGHT',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_VITAL_WEIGHT.ONOPTIONCLICKED",",oparms:[{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_vital_weight_Sortedstatus',ctrl:'DDO_BR_VITAL_WEIGHT',prop:'SortedStatus'},{av:'Ddo_br_vitalid_Sortedstatus',ctrl:'DDO_BR_VITALID',prop:'SortedStatus'},{av:'Ddo_br_vital_measuredate_Sortedstatus',ctrl:'DDO_BR_VITAL_MEASUREDATE',prop:'SortedStatus'},{av:'Ddo_br_vital_temperature_Sortedstatus',ctrl:'DDO_BR_VITAL_TEMPERATURE',prop:'SortedStatus'},{av:'AV59BR_VitalIDTitleFilterData',fld:'vBR_VITALIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Vital_MeasureDateTitleFilterData',fld:'vBR_VITAL_MEASUREDATETITLEFILTERDATA',pic:''},{av:'AV23BR_Vital_WeightTitleFilterData',fld:'vBR_VITAL_WEIGHTTITLEFILTERDATA',pic:''},{av:'AV27BR_Vital_TemperatureTitleFilterData',fld:'vBR_VITAL_TEMPERATURETITLEFILTERDATA',pic:''},{av:'edtBR_VitalID_Titleformat',ctrl:'BR_VITALID',prop:'Titleformat'},{av:'edtBR_VitalID_Title',ctrl:'BR_VITALID',prop:'Title'},{av:'edtBR_Vital_MeasureDate_Titleformat',ctrl:'BR_VITAL_MEASUREDATE',prop:'Titleformat'},{av:'edtBR_Vital_MeasureDate_Title',ctrl:'BR_VITAL_MEASUREDATE',prop:'Title'},{av:'edtBR_Vital_Weight_Titleformat',ctrl:'BR_VITAL_WEIGHT',prop:'Titleformat'},{av:'edtBR_Vital_Weight_Title',ctrl:'BR_VITAL_WEIGHT',prop:'Title'},{av:'edtBR_Vital_Temperature_Titleformat',ctrl:'BR_VITAL_TEMPERATURE',prop:'Titleformat'},{av:'edtBR_Vital_Temperature_Title',ctrl:'BR_VITAL_TEMPERATURE',prop:'Title'},{av:'AV50GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV51GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV52GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV54IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'edtavDisplay_Visible',ctrl:'vDISPLAY',prop:'Visible'},{av:'AV56IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV58IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_VITAL_TEMPERATURE.ONOPTIONCLICKED","{handler:'E16602',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV28TFBR_Vital_Temperature',fld:'vTFBR_VITAL_TEMPERATURE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV29TFBR_Vital_Temperature_To',fld:'vTFBR_VITAL_TEMPERATURE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV62ddo_BR_VitalIDTitleControlIdToReplace',fld:'vDDO_BR_VITALIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Vital_MeasureDateTitleControlIdToReplace',fld:'vDDO_BR_VITAL_MEASUREDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Vital_WeightTitleControlIdToReplace',fld:'vDDO_BR_VITAL_WEIGHTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_Vital_TemperatureTitleControlIdToReplace',fld:'vDDO_BR_VITAL_TEMPERATURETITLECONTROLIDTOREPLACE',pic:''},{av:'AV77Pgmname',fld:'vPGMNAME',pic:''},{av:'AV54IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'AV56IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV58IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'sPrefix'},{av:'Ddo_br_vital_temperature_Activeeventkey',ctrl:'DDO_BR_VITAL_TEMPERATURE',prop:'ActiveEventKey'},{av:'Ddo_br_vital_temperature_Filteredtext_get',ctrl:'DDO_BR_VITAL_TEMPERATURE',prop:'FilteredText_get'},{av:'Ddo_br_vital_temperature_Filteredtextto_get',ctrl:'DDO_BR_VITAL_TEMPERATURE',prop:'FilteredTextTo_get'}]");
         setEventMetadata("DDO_BR_VITAL_TEMPERATURE.ONOPTIONCLICKED",",oparms:[{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_vital_temperature_Sortedstatus',ctrl:'DDO_BR_VITAL_TEMPERATURE',prop:'SortedStatus'},{av:'AV28TFBR_Vital_Temperature',fld:'vTFBR_VITAL_TEMPERATURE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV29TFBR_Vital_Temperature_To',fld:'vTFBR_VITAL_TEMPERATURE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'Ddo_br_vitalid_Sortedstatus',ctrl:'DDO_BR_VITALID',prop:'SortedStatus'},{av:'Ddo_br_vital_measuredate_Sortedstatus',ctrl:'DDO_BR_VITAL_MEASUREDATE',prop:'SortedStatus'},{av:'Ddo_br_vital_weight_Sortedstatus',ctrl:'DDO_BR_VITAL_WEIGHT',prop:'SortedStatus'},{av:'AV59BR_VitalIDTitleFilterData',fld:'vBR_VITALIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Vital_MeasureDateTitleFilterData',fld:'vBR_VITAL_MEASUREDATETITLEFILTERDATA',pic:''},{av:'AV23BR_Vital_WeightTitleFilterData',fld:'vBR_VITAL_WEIGHTTITLEFILTERDATA',pic:''},{av:'AV27BR_Vital_TemperatureTitleFilterData',fld:'vBR_VITAL_TEMPERATURETITLEFILTERDATA',pic:''},{av:'edtBR_VitalID_Titleformat',ctrl:'BR_VITALID',prop:'Titleformat'},{av:'edtBR_VitalID_Title',ctrl:'BR_VITALID',prop:'Title'},{av:'edtBR_Vital_MeasureDate_Titleformat',ctrl:'BR_VITAL_MEASUREDATE',prop:'Titleformat'},{av:'edtBR_Vital_MeasureDate_Title',ctrl:'BR_VITAL_MEASUREDATE',prop:'Title'},{av:'edtBR_Vital_Weight_Titleformat',ctrl:'BR_VITAL_WEIGHT',prop:'Titleformat'},{av:'edtBR_Vital_Weight_Title',ctrl:'BR_VITAL_WEIGHT',prop:'Title'},{av:'edtBR_Vital_Temperature_Titleformat',ctrl:'BR_VITAL_TEMPERATURE',prop:'Titleformat'},{av:'edtBR_Vital_Temperature_Title',ctrl:'BR_VITAL_TEMPERATURE',prop:'Title'},{av:'AV50GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV51GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV52GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV54IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'edtavDisplay_Visible',ctrl:'vDISPLAY',prop:'Visible'},{av:'AV56IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'AV58IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("GRID.LOAD","{handler:'E20602',iparms:[{av:'AV54IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'A150BR_VitalID',fld:'BR_VITALID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV56IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'AV58IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''}]");
         setEventMetadata("GRID.LOAD",",oparms:[{av:'AV53Display',fld:'vDISPLAY',pic:''},{av:'edtavDisplay_Tooltiptext',ctrl:'vDISPLAY',prop:'Tooltiptext'},{av:'edtavDisplay_Link',ctrl:'vDISPLAY',prop:'Link'},{av:'AV55Update',fld:'vUPDATE',pic:''},{av:'edtavUpdate_Tooltiptext',ctrl:'vUPDATE',prop:'Tooltiptext'},{av:'edtavUpdate_Link',ctrl:'vUPDATE',prop:'Link'},{av:'AV57Delete',fld:'vDELETE',pic:''},{av:'edtavDelete_Tooltiptext',ctrl:'vDELETE',prop:'Tooltiptext'},{av:'edtavDelete_Link',ctrl:'vDELETE',prop:'Link'}]}");
         setEventMetadata("'DOINSERT'","{handler:'E17602',iparms:[{av:'A150BR_VitalID',fld:'BR_VITALID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'}]");
         setEventMetadata("'DOINSERT'",",oparms:[]}");
         setEventMetadata("VUPDATE.CLICK","{handler:'E21602',iparms:[{av:'A150BR_VitalID',fld:'BR_VITALID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
         setEventMetadata("VUPDATE.CLICK",",oparms:[]}");
         setEventMetadata("VDELETE.CLICK","{handler:'E22602',iparms:[{av:'A150BR_VitalID',fld:'BR_VITALID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
         setEventMetadata("VDELETE.CLICK",",oparms:[]}");
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
         Ddo_br_vitalid_Activeeventkey = "";
         Ddo_br_vital_measuredate_Activeeventkey = "";
         Ddo_br_vital_weight_Activeeventkey = "";
         Ddo_br_vital_temperature_Activeeventkey = "";
         Ddo_br_vital_temperature_Filteredtext_get = "";
         Ddo_br_vital_temperature_Filteredtextto_get = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         sPrefix = "";
         AV62ddo_BR_VitalIDTitleControlIdToReplace = "";
         AV22ddo_BR_Vital_MeasureDateTitleControlIdToReplace = "";
         AV26ddo_BR_Vital_WeightTitleControlIdToReplace = "";
         AV30ddo_BR_Vital_TemperatureTitleControlIdToReplace = "";
         AV77Pgmname = "";
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         AV47DDO_TitleSettingsIcons = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV59BR_VitalIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV17BR_Vital_MeasureDateTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV23BR_Vital_WeightTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV27BR_Vital_TemperatureTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         Ddo_br_vitalid_Sortedstatus = "";
         Ddo_br_vital_measuredate_Sortedstatus = "";
         Ddo_br_vital_weight_Sortedstatus = "";
         Ddo_br_vital_temperature_Filteredtext_set = "";
         Ddo_br_vital_temperature_Filteredtextto_set = "";
         Ddo_br_vital_temperature_Sortedstatus = "";
         GX_FocusControl = "";
         ucDvpanel_tableheader = new GXUserControl();
         TempTags = "";
         ClassString = "";
         StyleString = "";
         bttBtninsert_Jsonclick = "";
         GridContainer = new GXWebGrid( context);
         sStyleString = "";
         subGrid_Linesclass = "";
         GridColumn = new GXWebColumn();
         AV53Display = "";
         AV55Update = "";
         AV57Delete = "";
         A152BR_Vital_MeasureDate = DateTime.MinValue;
         ucGridpaginationbar = new GXUserControl();
         ucDdo_br_vitalid = new GXUserControl();
         ucDdo_br_vital_measuredate = new GXUserControl();
         ucDdo_br_vital_weight = new GXUserControl();
         ucDdo_br_vital_temperature = new GXUserControl();
         ucWorkwithplusutilities1 = new GXUserControl();
         Form = new GXWebForm();
         sXEvt = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV74Display_GXI = "";
         AV75Update_GXI = "";
         AV76Delete_GXI = "";
         scmdbuf = "";
         H00602_A19BR_EncounterID = new long[1] ;
         H00602_A153BR_Vital_Temperature = new decimal[1] ;
         H00602_n153BR_Vital_Temperature = new bool[] {false} ;
         H00602_A159BR_Vital_Weight = new decimal[1] ;
         H00602_n159BR_Vital_Weight = new bool[] {false} ;
         H00602_A152BR_Vital_MeasureDate = new DateTime[] {DateTime.MinValue} ;
         H00602_n152BR_Vital_MeasureDate = new bool[] {false} ;
         H00602_A150BR_VitalID = new long[1] ;
         H00603_AGRID_nRecordCount = new long[1] ;
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV6WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         GridRow = new GXWebRow();
         AV16Session = context.GetSession();
         AV12GridState = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState(context);
         AV13GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
         AV10TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV9HTTPRequest = new GxHttpRequest( context);
         AV11TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sCtrlAV8BR_EncounterID = "";
         sImgUrl = "";
         ROClassString = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_encounterupdatebr_vitalwc__default(),
            new Object[][] {
                new Object[] {
               H00602_A19BR_EncounterID, H00602_A153BR_Vital_Temperature, H00602_n153BR_Vital_Temperature, H00602_A159BR_Vital_Weight, H00602_n159BR_Vital_Weight, H00602_A152BR_Vital_MeasureDate, H00602_n152BR_Vital_MeasureDate, H00602_A150BR_VitalID
               }
               , new Object[] {
               H00603_AGRID_nRecordCount
               }
            }
         );
         AV77Pgmname = "BR_EncounterUpdateBR_VitalWC";
         /* GeneXus formulas. */
         AV77Pgmname = "BR_EncounterUpdateBR_VitalWC";
         context.Gx_err = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nDynComponent ;
      private short nRC_GXsfl_28 ;
      private short nGXsfl_28_idx=1 ;
      private short GRID_nEOF ;
      private short AV14OrderedBy ;
      private short initialized ;
      private short wbEnd ;
      private short wbStart ;
      private short subGrid_Backcolorstyle ;
      private short subGrid_Titlebackstyle ;
      private short edtBR_VitalID_Titleformat ;
      private short edtBR_Vital_MeasureDate_Titleformat ;
      private short edtBR_Vital_Weight_Titleformat ;
      private short edtBR_Vital_Temperature_Titleformat ;
      private short subGrid_Sortable ;
      private short subGrid_Allowselection ;
      private short subGrid_Allowhovering ;
      private short subGrid_Allowcollapsing ;
      private short subGrid_Collapsed ;
      private short nDraw ;
      private short nDoneStart ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short nGXWrapped ;
      private short subGrid_Backstyle ;
      private int subGrid_Rows ;
      private int Gridpaginationbar_Rowsperpageselectedvalue ;
      private int Gridpaginationbar_Pagestoshow ;
      private int bttBtninsert_Visible ;
      private int subGrid_Titlebackcolor ;
      private int subGrid_Allbackcolor ;
      private int edtavDisplay_Visible ;
      private int edtavUpdate_Visible ;
      private int edtavDelete_Visible ;
      private int subGrid_Selectedindex ;
      private int subGrid_Selectioncolor ;
      private int subGrid_Hoveringcolor ;
      private int edtavDdo_br_vitalidtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_vital_measuredatetitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_vital_weighttitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_vital_temperaturetitlecontrolidtoreplace_Visible ;
      private int edtBR_EncounterID_Visible ;
      private int edtavOrderedby_Visible ;
      private int edtavOrdereddsc_Visible ;
      private int edtavTfbr_vital_temperature_Visible ;
      private int edtavTfbr_vital_temperature_to_Visible ;
      private int subGrid_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int AV49PageToGo ;
      private int AV78GXV1 ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private int edtavUpdate_Enabled ;
      private int edtavDelete_Enabled ;
      private long AV8BR_EncounterID ;
      private long wcpOAV8BR_EncounterID ;
      private long GRID_nFirstRecordOnPage ;
      private long AV50GridCurrentPage ;
      private long AV52GridRecordCount ;
      private long AV51GridPageSize ;
      private long A150BR_VitalID ;
      private long A19BR_EncounterID ;
      private long GRID_nCurrentRecord ;
      private long GRID_nRecordCount ;
      private decimal AV28TFBR_Vital_Temperature ;
      private decimal AV29TFBR_Vital_Temperature_To ;
      private decimal A159BR_Vital_Weight ;
      private decimal A153BR_Vital_Temperature ;
      private String Gridpaginationbar_Selectedpage ;
      private String Ddo_br_vitalid_Activeeventkey ;
      private String Ddo_br_vital_measuredate_Activeeventkey ;
      private String Ddo_br_vital_weight_Activeeventkey ;
      private String Ddo_br_vital_temperature_Activeeventkey ;
      private String Ddo_br_vital_temperature_Filteredtext_get ;
      private String Ddo_br_vital_temperature_Filteredtextto_get ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sPrefix ;
      private String sCompPrefix ;
      private String sSFPrefix ;
      private String sGXsfl_28_idx="0001" ;
      private String AV77Pgmname ;
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
      private String Ddo_br_vitalid_Caption ;
      private String Ddo_br_vitalid_Tooltip ;
      private String Ddo_br_vitalid_Cls ;
      private String Ddo_br_vitalid_Dropdownoptionstype ;
      private String Ddo_br_vitalid_Titlecontrolidtoreplace ;
      private String Ddo_br_vitalid_Sortedstatus ;
      private String Ddo_br_vitalid_Sortasc ;
      private String Ddo_br_vitalid_Sortdsc ;
      private String Ddo_br_vitalid_Searchbuttontext ;
      private String Ddo_br_vital_measuredate_Caption ;
      private String Ddo_br_vital_measuredate_Tooltip ;
      private String Ddo_br_vital_measuredate_Cls ;
      private String Ddo_br_vital_measuredate_Dropdownoptionstype ;
      private String Ddo_br_vital_measuredate_Titlecontrolidtoreplace ;
      private String Ddo_br_vital_measuredate_Sortedstatus ;
      private String Ddo_br_vital_measuredate_Sortasc ;
      private String Ddo_br_vital_measuredate_Sortdsc ;
      private String Ddo_br_vital_measuredate_Searchbuttontext ;
      private String Ddo_br_vital_weight_Caption ;
      private String Ddo_br_vital_weight_Tooltip ;
      private String Ddo_br_vital_weight_Cls ;
      private String Ddo_br_vital_weight_Dropdownoptionstype ;
      private String Ddo_br_vital_weight_Titlecontrolidtoreplace ;
      private String Ddo_br_vital_weight_Sortedstatus ;
      private String Ddo_br_vital_weight_Sortasc ;
      private String Ddo_br_vital_weight_Sortdsc ;
      private String Ddo_br_vital_weight_Searchbuttontext ;
      private String Ddo_br_vital_temperature_Caption ;
      private String Ddo_br_vital_temperature_Tooltip ;
      private String Ddo_br_vital_temperature_Cls ;
      private String Ddo_br_vital_temperature_Filteredtext_set ;
      private String Ddo_br_vital_temperature_Filteredtextto_set ;
      private String Ddo_br_vital_temperature_Dropdownoptionstype ;
      private String Ddo_br_vital_temperature_Titlecontrolidtoreplace ;
      private String Ddo_br_vital_temperature_Sortedstatus ;
      private String Ddo_br_vital_temperature_Filtertype ;
      private String Ddo_br_vital_temperature_Sortasc ;
      private String Ddo_br_vital_temperature_Sortdsc ;
      private String Ddo_br_vital_temperature_Cleanfilter ;
      private String Ddo_br_vital_temperature_Rangefilterfrom ;
      private String Ddo_br_vital_temperature_Rangefilterto ;
      private String Ddo_br_vital_temperature_Searchbuttontext ;
      private String GX_FocusControl ;
      private String divLayoutmaintable_Internalname ;
      private String divTablegridheader_Internalname ;
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
      private String edtBR_VitalID_Title ;
      private String edtBR_Vital_MeasureDate_Title ;
      private String edtBR_Vital_Weight_Title ;
      private String edtBR_Vital_Temperature_Title ;
      private String subGrid_Header ;
      private String edtavDisplay_Link ;
      private String edtavDisplay_Tooltiptext ;
      private String edtavUpdate_Link ;
      private String edtavUpdate_Tooltiptext ;
      private String edtavDelete_Link ;
      private String edtavDelete_Tooltiptext ;
      private String divHtml_gridpaginationbar_Internalname ;
      private String Gridpaginationbar_Internalname ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String Ddo_br_vitalid_Internalname ;
      private String edtavDdo_br_vitalidtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_vital_measuredate_Internalname ;
      private String edtavDdo_br_vital_measuredatetitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_vital_weight_Internalname ;
      private String edtavDdo_br_vital_weighttitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_vital_temperature_Internalname ;
      private String edtavDdo_br_vital_temperaturetitlecontrolidtoreplace_Internalname ;
      private String edtBR_EncounterID_Internalname ;
      private String edtBR_EncounterID_Jsonclick ;
      private String Workwithplusutilities1_Internalname ;
      private String edtavOrderedby_Internalname ;
      private String edtavOrderedby_Jsonclick ;
      private String edtavOrdereddsc_Internalname ;
      private String edtavOrdereddsc_Jsonclick ;
      private String edtavTfbr_vital_temperature_Internalname ;
      private String edtavTfbr_vital_temperature_Jsonclick ;
      private String edtavTfbr_vital_temperature_to_Internalname ;
      private String edtavTfbr_vital_temperature_to_Jsonclick ;
      private String sXEvt ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavDisplay_Internalname ;
      private String edtavUpdate_Internalname ;
      private String edtavDelete_Internalname ;
      private String edtBR_VitalID_Internalname ;
      private String edtBR_Vital_MeasureDate_Internalname ;
      private String edtBR_Vital_Weight_Internalname ;
      private String edtBR_Vital_Temperature_Internalname ;
      private String scmdbuf ;
      private String sCtrlAV8BR_EncounterID ;
      private String sGXsfl_28_fel_idx="0001" ;
      private String sImgUrl ;
      private String edtavUpdate_Jsonclick ;
      private String edtavDelete_Jsonclick ;
      private String ROClassString ;
      private String edtBR_VitalID_Jsonclick ;
      private String edtBR_Vital_MeasureDate_Jsonclick ;
      private String edtBR_Vital_Weight_Jsonclick ;
      private String edtBR_Vital_Temperature_Jsonclick ;
      private DateTime A152BR_Vital_MeasureDate ;
      private bool entryPointCalled ;
      private bool AV15OrderedDsc ;
      private bool AV54IsAuthorized_Display ;
      private bool AV56IsAuthorized_Update ;
      private bool AV58IsAuthorized_Delete ;
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
      private bool Ddo_br_vitalid_Includesortasc ;
      private bool Ddo_br_vitalid_Includesortdsc ;
      private bool Ddo_br_vitalid_Includefilter ;
      private bool Ddo_br_vitalid_Includedatalist ;
      private bool Ddo_br_vital_measuredate_Includesortasc ;
      private bool Ddo_br_vital_measuredate_Includesortdsc ;
      private bool Ddo_br_vital_measuredate_Includefilter ;
      private bool Ddo_br_vital_measuredate_Includedatalist ;
      private bool Ddo_br_vital_weight_Includesortasc ;
      private bool Ddo_br_vital_weight_Includesortdsc ;
      private bool Ddo_br_vital_weight_Includefilter ;
      private bool Ddo_br_vital_weight_Includedatalist ;
      private bool Ddo_br_vital_temperature_Includesortasc ;
      private bool Ddo_br_vital_temperature_Includesortdsc ;
      private bool Ddo_br_vital_temperature_Includefilter ;
      private bool Ddo_br_vital_temperature_Filterisrange ;
      private bool Ddo_br_vital_temperature_Includedatalist ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_28_Refreshing=false ;
      private bool n152BR_Vital_MeasureDate ;
      private bool n159BR_Vital_Weight ;
      private bool n153BR_Vital_Temperature ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool gx_refresh_fired ;
      private bool AV67TempBoolean ;
      private bool GXt_boolean2 ;
      private bool AV71tCheckFlag ;
      private bool AV53Display_IsBlob ;
      private bool AV55Update_IsBlob ;
      private bool AV57Delete_IsBlob ;
      private String AV62ddo_BR_VitalIDTitleControlIdToReplace ;
      private String AV22ddo_BR_Vital_MeasureDateTitleControlIdToReplace ;
      private String AV26ddo_BR_Vital_WeightTitleControlIdToReplace ;
      private String AV30ddo_BR_Vital_TemperatureTitleControlIdToReplace ;
      private String AV74Display_GXI ;
      private String AV75Update_GXI ;
      private String AV76Delete_GXI ;
      private String AV53Display ;
      private String AV55Update ;
      private String AV57Delete ;
      private IGxSession AV16Session ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private GXUserControl ucDvpanel_tableheader ;
      private GXUserControl ucGridpaginationbar ;
      private GXUserControl ucDdo_br_vitalid ;
      private GXUserControl ucDdo_br_vital_measuredate ;
      private GXUserControl ucDdo_br_vital_weight ;
      private GXUserControl ucDdo_br_vital_temperature ;
      private GXUserControl ucWorkwithplusutilities1 ;
      private GXWebForm Form ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] H00602_A19BR_EncounterID ;
      private decimal[] H00602_A153BR_Vital_Temperature ;
      private bool[] H00602_n153BR_Vital_Temperature ;
      private decimal[] H00602_A159BR_Vital_Weight ;
      private bool[] H00602_n159BR_Vital_Weight ;
      private DateTime[] H00602_A152BR_Vital_MeasureDate ;
      private bool[] H00602_n152BR_Vital_MeasureDate ;
      private long[] H00602_A150BR_VitalID ;
      private long[] H00603_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV9HTTPRequest ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV59BR_VitalIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV17BR_Vital_MeasureDateTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV23BR_Vital_WeightTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV27BR_Vital_TemperatureTitleFilterData ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV10TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute AV11TrnContextAtt ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV12GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue AV13GridStateFilterValue ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons AV47DDO_TitleSettingsIcons ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 ;
   }

   public class br_encounterupdatebr_vitalwc__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H00602( IGxContext context ,
                                             decimal AV28TFBR_Vital_Temperature ,
                                             decimal AV29TFBR_Vital_Temperature_To ,
                                             decimal A153BR_Vital_Temperature ,
                                             short AV14OrderedBy ,
                                             bool AV15OrderedDsc ,
                                             long A19BR_EncounterID ,
                                             long AV8BR_EncounterID )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int3 ;
         GXv_int3 = new short [6] ;
         Object[] GXv_Object4 ;
         GXv_Object4 = new Object [2] ;
         String sSelectString ;
         String sFromString ;
         String sOrderString ;
         sSelectString = " [BR_EncounterID], [BR_Vital_Temperature], [BR_Vital_Weight], [BR_Vital_MeasureDate], [BR_VitalID]";
         sFromString = " FROM [BR_Vital] WITH (NOLOCK)";
         sOrderString = "";
         sWhereString = sWhereString + " WHERE ([BR_EncounterID] = @AV8BR_EncounterID)";
         if ( ! (Convert.ToDecimal(0)==AV28TFBR_Vital_Temperature) )
         {
            sWhereString = sWhereString + " and ([BR_Vital_Temperature] >= @AV28TFBR_Vital_Temperature)";
         }
         else
         {
            GXv_int3[1] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV29TFBR_Vital_Temperature_To) )
         {
            sWhereString = sWhereString + " and ([BR_Vital_Temperature] <= @AV29TFBR_Vital_Temperature_To)";
         }
         else
         {
            GXv_int3[2] = 1;
         }
         if ( ( AV14OrderedBy == 1 ) && ! AV15OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_VitalID] DESC";
         }
         else if ( ( AV14OrderedBy == 1 ) && ( AV15OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_VitalID]";
         }
         else if ( ( AV14OrderedBy == 2 ) && ! AV15OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_EncounterID], [BR_Vital_MeasureDate]";
         }
         else if ( ( AV14OrderedBy == 2 ) && ( AV15OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_EncounterID] DESC, [BR_Vital_MeasureDate] DESC";
         }
         else if ( ( AV14OrderedBy == 3 ) && ! AV15OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_EncounterID], [BR_Vital_Weight]";
         }
         else if ( ( AV14OrderedBy == 3 ) && ( AV15OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_EncounterID] DESC, [BR_Vital_Weight] DESC";
         }
         else if ( ( AV14OrderedBy == 4 ) && ! AV15OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_EncounterID], [BR_Vital_Temperature]";
         }
         else if ( ( AV14OrderedBy == 4 ) && ( AV15OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_EncounterID] DESC, [BR_Vital_Temperature] DESC";
         }
         else if ( true )
         {
            sOrderString = sOrderString + " ORDER BY [BR_VitalID]";
         }
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object4[0] = scmdbuf;
         GXv_Object4[1] = GXv_int3;
         return GXv_Object4 ;
      }

      protected Object[] conditional_H00603( IGxContext context ,
                                             decimal AV28TFBR_Vital_Temperature ,
                                             decimal AV29TFBR_Vital_Temperature_To ,
                                             decimal A153BR_Vital_Temperature ,
                                             short AV14OrderedBy ,
                                             bool AV15OrderedDsc ,
                                             long A19BR_EncounterID ,
                                             long AV8BR_EncounterID )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int5 ;
         GXv_int5 = new short [3] ;
         Object[] GXv_Object6 ;
         GXv_Object6 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM [BR_Vital] WITH (NOLOCK)";
         scmdbuf = scmdbuf + " WHERE ([BR_EncounterID] = @AV8BR_EncounterID)";
         if ( ! (Convert.ToDecimal(0)==AV28TFBR_Vital_Temperature) )
         {
            sWhereString = sWhereString + " and ([BR_Vital_Temperature] >= @AV28TFBR_Vital_Temperature)";
         }
         else
         {
            GXv_int5[1] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV29TFBR_Vital_Temperature_To) )
         {
            sWhereString = sWhereString + " and ([BR_Vital_Temperature] <= @AV29TFBR_Vital_Temperature_To)";
         }
         else
         {
            GXv_int5[2] = 1;
         }
         scmdbuf = scmdbuf + sWhereString;
         if ( ( AV14OrderedBy == 1 ) && ! AV15OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV14OrderedBy == 1 ) && ( AV15OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV14OrderedBy == 2 ) && ! AV15OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV14OrderedBy == 2 ) && ( AV15OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV14OrderedBy == 3 ) && ! AV15OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV14OrderedBy == 3 ) && ( AV15OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV14OrderedBy == 4 ) && ! AV15OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV14OrderedBy == 4 ) && ( AV15OrderedDsc ) )
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
                     return conditional_H00602(context, (decimal)dynConstraints[0] , (decimal)dynConstraints[1] , (decimal)dynConstraints[2] , (short)dynConstraints[3] , (bool)dynConstraints[4] , (long)dynConstraints[5] , (long)dynConstraints[6] );
               case 1 :
                     return conditional_H00603(context, (decimal)dynConstraints[0] , (decimal)dynConstraints[1] , (decimal)dynConstraints[2] , (short)dynConstraints[3] , (bool)dynConstraints[4] , (long)dynConstraints[5] , (long)dynConstraints[6] );
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
          Object[] prmH00602 ;
          prmH00602 = new Object[] {
          new Object[] {"@AV8BR_EncounterID",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV28TFBR_Vital_Temperature",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV29TFBR_Vital_Temperature_To",SqlDbType.Decimal,15,5} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH00603 ;
          prmH00603 = new Object[] {
          new Object[] {"@AV8BR_EncounterID",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV28TFBR_Vital_Temperature",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV29TFBR_Vital_Temperature_To",SqlDbType.Decimal,15,5}
          } ;
          def= new CursorDef[] {
              new CursorDef("H00602", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00602,11,0,true,false )
             ,new CursorDef("H00603", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00603,1,0,true,false )
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
                ((decimal[]) buf[1])[0] = rslt.getDecimal(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((decimal[]) buf[3])[0] = rslt.getDecimal(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((DateTime[]) buf[5])[0] = rslt.getGXDate(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
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
                   stmt.SetParameter(sIdx, (long)parms[6]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[7]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[8]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[9]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[10]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[11]);
                }
                return;
             case 1 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[3]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[4]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[5]);
                }
                return;
       }
    }

 }

}
