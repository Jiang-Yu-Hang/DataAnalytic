/*
               File: BR_EncounterCheckVitalWC
        Description: Data Mgmt Portal - RAAP
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:4:56.33
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
   public class br_encountercheckvitalwc : GXWebComponent, System.Web.SessionState.IRequiresSessionState
   {
      public br_encountercheckvitalwc( )
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

      public br_encountercheckvitalwc( IGxContext context )
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
                  nRC_GXsfl_12 = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  nGXsfl_12_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
                  sGXsfl_12_idx = GetNextPar( );
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
                  AV18TFBR_VitalID = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  AV19TFBR_VitalID_To = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  AV22TFBR_Vital_MeasureDate = context.localUtil.ParseDateParm( GetNextPar( ));
                  AV23TFBR_Vital_MeasureDate_To = context.localUtil.ParseDateParm( GetNextPar( ));
                  AV28TFBR_Vital_Weight = NumberUtil.Val( GetNextPar( ), ".");
                  AV29TFBR_Vital_Weight_To = NumberUtil.Val( GetNextPar( ), ".");
                  AV32TFBR_Vital_Temperature = NumberUtil.Val( GetNextPar( ), ".");
                  AV33TFBR_Vital_Temperature_To = NumberUtil.Val( GetNextPar( ), ".");
                  AV8BR_EncounterID = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  AV20ddo_BR_VitalIDTitleControlIdToReplace = GetNextPar( );
                  AV26ddo_BR_Vital_MeasureDateTitleControlIdToReplace = GetNextPar( );
                  AV30ddo_BR_Vital_WeightTitleControlIdToReplace = GetNextPar( );
                  AV34ddo_BR_Vital_TemperatureTitleControlIdToReplace = GetNextPar( );
                  AV65Pgmname = GetNextPar( );
                  AV58IsAuthorized_Display = StringUtil.StrToBool( GetNextPar( ));
                  sPrefix = GetNextPar( );
                  init_default_properties( ) ;
                  setAjaxCallMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1;
                     return  ;
                  }
                  gxgrGrid_refresh( subGrid_Rows, AV14OrderedBy, AV15OrderedDsc, AV18TFBR_VitalID, AV19TFBR_VitalID_To, AV22TFBR_Vital_MeasureDate, AV23TFBR_Vital_MeasureDate_To, AV28TFBR_Vital_Weight, AV29TFBR_Vital_Weight_To, AV32TFBR_Vital_Temperature, AV33TFBR_Vital_Temperature_To, AV8BR_EncounterID, AV20ddo_BR_VitalIDTitleControlIdToReplace, AV26ddo_BR_Vital_MeasureDateTitleControlIdToReplace, AV30ddo_BR_Vital_WeightTitleControlIdToReplace, AV34ddo_BR_Vital_TemperatureTitleControlIdToReplace, AV65Pgmname, AV58IsAuthorized_Display, sPrefix) ;
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
            PA612( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV65Pgmname = "BR_EncounterCheckVitalWC";
               context.Gx_err = 0;
               WS612( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?20202281545672", false);
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
            context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_encountercheckvitalwc.aspx") + "?" + UrlEncode("" +AV8BR_EncounterID)+"\">") ;
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
         GxWebStd.gx_hidden_field( context, sPrefix+"GXH_vTFBR_VITALID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV18TFBR_VitalID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GXH_vTFBR_VITALID_TO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV19TFBR_VitalID_To), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GXH_vTFBR_VITAL_MEASUREDATE", context.localUtil.Format(AV22TFBR_Vital_MeasureDate, "9999/99/99"));
         GxWebStd.gx_hidden_field( context, sPrefix+"GXH_vTFBR_VITAL_MEASUREDATE_TO", context.localUtil.Format(AV23TFBR_Vital_MeasureDate_To, "9999/99/99"));
         GxWebStd.gx_hidden_field( context, sPrefix+"GXH_vTFBR_VITAL_WEIGHT", StringUtil.LTrim( StringUtil.NToC( AV28TFBR_Vital_Weight, 15, 5, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GXH_vTFBR_VITAL_WEIGHT_TO", StringUtil.LTrim( StringUtil.NToC( AV29TFBR_Vital_Weight_To, 15, 5, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GXH_vTFBR_VITAL_TEMPERATURE", StringUtil.LTrim( StringUtil.NToC( AV32TFBR_Vital_Temperature, 15, 5, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GXH_vTFBR_VITAL_TEMPERATURE_TO", StringUtil.LTrim( StringUtil.NToC( AV33TFBR_Vital_Temperature_To, 15, 5, ".", "")));
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, sPrefix+"nRC_GXsfl_12", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_12), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"vGRIDCURRENTPAGE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV54GridCurrentPage), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"vGRIDRECORDCOUNT", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV56GridRecordCount), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"vGRIDPAGESIZE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV55GridPageSize), 10, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, sPrefix+"vDDO_TITLESETTINGSICONS", AV51DDO_TitleSettingsIcons);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(sPrefix+"vDDO_TITLESETTINGSICONS", AV51DDO_TitleSettingsIcons);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, sPrefix+"vBR_VITALIDTITLEFILTERDATA", AV17BR_VitalIDTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(sPrefix+"vBR_VITALIDTITLEFILTERDATA", AV17BR_VitalIDTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, sPrefix+"vBR_VITAL_MEASUREDATETITLEFILTERDATA", AV21BR_Vital_MeasureDateTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(sPrefix+"vBR_VITAL_MEASUREDATETITLEFILTERDATA", AV21BR_Vital_MeasureDateTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, sPrefix+"vBR_VITAL_WEIGHTTITLEFILTERDATA", AV27BR_Vital_WeightTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(sPrefix+"vBR_VITAL_WEIGHTTITLEFILTERDATA", AV27BR_Vital_WeightTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, sPrefix+"vBR_VITAL_TEMPERATURETITLEFILTERDATA", AV31BR_Vital_TemperatureTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(sPrefix+"vBR_VITAL_TEMPERATURETITLEFILTERDATA", AV31BR_Vital_TemperatureTitleFilterData);
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOAV8BR_EncounterID", StringUtil.LTrim( StringUtil.NToC( (decimal)(wcpOAV8BR_EncounterID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"vPGMNAME", StringUtil.RTrim( AV65Pgmname));
         GxWebStd.gx_boolean_hidden_field( context, sPrefix+"vISAUTHORIZED_DISPLAY", AV58IsAuthorized_Display);
         GxWebStd.gx_hidden_field( context, sPrefix+"vBR_ENCOUNTERID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8BR_EncounterID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
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
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITALID_Filteredtext_set", StringUtil.RTrim( Ddo_br_vitalid_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITALID_Filteredtextto_set", StringUtil.RTrim( Ddo_br_vitalid_Filteredtextto_set));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITALID_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_vitalid_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITALID_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_vitalid_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITALID_Includesortasc", StringUtil.BoolToStr( Ddo_br_vitalid_Includesortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITALID_Includesortdsc", StringUtil.BoolToStr( Ddo_br_vitalid_Includesortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITALID_Sortedstatus", StringUtil.RTrim( Ddo_br_vitalid_Sortedstatus));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITALID_Includefilter", StringUtil.BoolToStr( Ddo_br_vitalid_Includefilter));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITALID_Filtertype", StringUtil.RTrim( Ddo_br_vitalid_Filtertype));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITALID_Filterisrange", StringUtil.BoolToStr( Ddo_br_vitalid_Filterisrange));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITALID_Includedatalist", StringUtil.BoolToStr( Ddo_br_vitalid_Includedatalist));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITALID_Sortasc", StringUtil.RTrim( Ddo_br_vitalid_Sortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITALID_Sortdsc", StringUtil.RTrim( Ddo_br_vitalid_Sortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITALID_Cleanfilter", StringUtil.RTrim( Ddo_br_vitalid_Cleanfilter));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITALID_Rangefilterfrom", StringUtil.RTrim( Ddo_br_vitalid_Rangefilterfrom));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITALID_Rangefilterto", StringUtil.RTrim( Ddo_br_vitalid_Rangefilterto));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITALID_Searchbuttontext", StringUtil.RTrim( Ddo_br_vitalid_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_MEASUREDATE_Caption", StringUtil.RTrim( Ddo_br_vital_measuredate_Caption));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_MEASUREDATE_Tooltip", StringUtil.RTrim( Ddo_br_vital_measuredate_Tooltip));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_MEASUREDATE_Cls", StringUtil.RTrim( Ddo_br_vital_measuredate_Cls));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_MEASUREDATE_Filteredtext_set", StringUtil.RTrim( Ddo_br_vital_measuredate_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_MEASUREDATE_Filteredtextto_set", StringUtil.RTrim( Ddo_br_vital_measuredate_Filteredtextto_set));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_MEASUREDATE_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_vital_measuredate_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_MEASUREDATE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_vital_measuredate_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_MEASUREDATE_Includesortasc", StringUtil.BoolToStr( Ddo_br_vital_measuredate_Includesortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_MEASUREDATE_Includesortdsc", StringUtil.BoolToStr( Ddo_br_vital_measuredate_Includesortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_MEASUREDATE_Sortedstatus", StringUtil.RTrim( Ddo_br_vital_measuredate_Sortedstatus));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_MEASUREDATE_Includefilter", StringUtil.BoolToStr( Ddo_br_vital_measuredate_Includefilter));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_MEASUREDATE_Filtertype", StringUtil.RTrim( Ddo_br_vital_measuredate_Filtertype));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_MEASUREDATE_Filterisrange", StringUtil.BoolToStr( Ddo_br_vital_measuredate_Filterisrange));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_MEASUREDATE_Includedatalist", StringUtil.BoolToStr( Ddo_br_vital_measuredate_Includedatalist));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_MEASUREDATE_Sortasc", StringUtil.RTrim( Ddo_br_vital_measuredate_Sortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_MEASUREDATE_Sortdsc", StringUtil.RTrim( Ddo_br_vital_measuredate_Sortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_MEASUREDATE_Cleanfilter", StringUtil.RTrim( Ddo_br_vital_measuredate_Cleanfilter));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_MEASUREDATE_Rangefilterfrom", StringUtil.RTrim( Ddo_br_vital_measuredate_Rangefilterfrom));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_MEASUREDATE_Rangefilterto", StringUtil.RTrim( Ddo_br_vital_measuredate_Rangefilterto));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_MEASUREDATE_Searchbuttontext", StringUtil.RTrim( Ddo_br_vital_measuredate_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_WEIGHT_Caption", StringUtil.RTrim( Ddo_br_vital_weight_Caption));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_WEIGHT_Tooltip", StringUtil.RTrim( Ddo_br_vital_weight_Tooltip));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_WEIGHT_Cls", StringUtil.RTrim( Ddo_br_vital_weight_Cls));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_WEIGHT_Filteredtext_set", StringUtil.RTrim( Ddo_br_vital_weight_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_WEIGHT_Filteredtextto_set", StringUtil.RTrim( Ddo_br_vital_weight_Filteredtextto_set));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_WEIGHT_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_vital_weight_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_WEIGHT_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_vital_weight_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_WEIGHT_Includesortasc", StringUtil.BoolToStr( Ddo_br_vital_weight_Includesortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_WEIGHT_Includesortdsc", StringUtil.BoolToStr( Ddo_br_vital_weight_Includesortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_WEIGHT_Sortedstatus", StringUtil.RTrim( Ddo_br_vital_weight_Sortedstatus));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_WEIGHT_Includefilter", StringUtil.BoolToStr( Ddo_br_vital_weight_Includefilter));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_WEIGHT_Filtertype", StringUtil.RTrim( Ddo_br_vital_weight_Filtertype));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_WEIGHT_Filterisrange", StringUtil.BoolToStr( Ddo_br_vital_weight_Filterisrange));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_WEIGHT_Includedatalist", StringUtil.BoolToStr( Ddo_br_vital_weight_Includedatalist));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_WEIGHT_Sortasc", StringUtil.RTrim( Ddo_br_vital_weight_Sortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_WEIGHT_Sortdsc", StringUtil.RTrim( Ddo_br_vital_weight_Sortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_WEIGHT_Cleanfilter", StringUtil.RTrim( Ddo_br_vital_weight_Cleanfilter));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_WEIGHT_Rangefilterfrom", StringUtil.RTrim( Ddo_br_vital_weight_Rangefilterfrom));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_WEIGHT_Rangefilterto", StringUtil.RTrim( Ddo_br_vital_weight_Rangefilterto));
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
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITALID_Filteredtext_get", StringUtil.RTrim( Ddo_br_vitalid_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITALID_Filteredtextto_get", StringUtil.RTrim( Ddo_br_vitalid_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_MEASUREDATE_Activeeventkey", StringUtil.RTrim( Ddo_br_vital_measuredate_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_MEASUREDATE_Filteredtext_get", StringUtil.RTrim( Ddo_br_vital_measuredate_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_MEASUREDATE_Filteredtextto_get", StringUtil.RTrim( Ddo_br_vital_measuredate_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_WEIGHT_Activeeventkey", StringUtil.RTrim( Ddo_br_vital_weight_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_WEIGHT_Filteredtext_get", StringUtil.RTrim( Ddo_br_vital_weight_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_WEIGHT_Filteredtextto_get", StringUtil.RTrim( Ddo_br_vital_weight_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_TEMPERATURE_Activeeventkey", StringUtil.RTrim( Ddo_br_vital_temperature_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_TEMPERATURE_Filteredtext_get", StringUtil.RTrim( Ddo_br_vital_temperature_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_TEMPERATURE_Filteredtextto_get", StringUtil.RTrim( Ddo_br_vital_temperature_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITALID_Activeeventkey", StringUtil.RTrim( Ddo_br_vitalid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITALID_Filteredtext_get", StringUtil.RTrim( Ddo_br_vitalid_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITALID_Filteredtextto_get", StringUtil.RTrim( Ddo_br_vitalid_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_MEASUREDATE_Activeeventkey", StringUtil.RTrim( Ddo_br_vital_measuredate_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_MEASUREDATE_Filteredtext_get", StringUtil.RTrim( Ddo_br_vital_measuredate_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_MEASUREDATE_Filteredtextto_get", StringUtil.RTrim( Ddo_br_vital_measuredate_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_WEIGHT_Activeeventkey", StringUtil.RTrim( Ddo_br_vital_weight_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_WEIGHT_Filteredtext_get", StringUtil.RTrim( Ddo_br_vital_weight_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_WEIGHT_Filteredtextto_get", StringUtil.RTrim( Ddo_br_vital_weight_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_TEMPERATURE_Activeeventkey", StringUtil.RTrim( Ddo_br_vital_temperature_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_TEMPERATURE_Filteredtext_get", StringUtil.RTrim( Ddo_br_vital_temperature_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_VITAL_TEMPERATURE_Filteredtextto_get", StringUtil.RTrim( Ddo_br_vital_temperature_Filteredtextto_get));
      }

      protected void RenderHtmlCloseForm612( )
      {
         SendCloseFormHiddens( ) ;
         if ( ( StringUtil.Len( sPrefix) != 0 ) && ( context.isAjaxRequest( ) || context.isSpaRequest( ) ) )
         {
            context.AddJavascriptSource("br_encountercheckvitalwc.js", "?20202281545953", false);
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
         return "BR_EncounterCheckVitalWC" ;
      }

      public override String GetPgmdesc( )
      {
         return "Data Mgmt Portal - RAAP" ;
      }

      protected void WB610( )
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
               GxWebStd.gx_hidden_field( context, sPrefix+"_CMPPGM", "br_encountercheckvitalwc.aspx");
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
            GxWebStd.gx_div_start( context, divUnnamedtable1_Internalname, 1, 0, "px", 0, "px", "", "left", "top", "", "", "div");
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
               context.WriteHtmlText( "<div id=\""+sPrefix+"GridContainer"+"DivS\" data-gxgridid=\"12\">") ;
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
               GridColumn.AddObjectProperty("Value", context.convertURL( AV57Display));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavDisplay_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavDisplay_Tooltiptext));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavDisplay_Visible), 5, 0, ".", "")));
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
            ucGridpaginationbar.SetProperty("CurrentPage", AV54GridCurrentPage);
            ucGridpaginationbar.SetProperty("RecordCount", AV56GridRecordCount);
            ucGridpaginationbar.SetProperty("Page", AV55GridPageSize);
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
            ucDdo_br_vitalid.SetProperty("FilterType", Ddo_br_vitalid_Filtertype);
            ucDdo_br_vitalid.SetProperty("FilterIsRange", Ddo_br_vitalid_Filterisrange);
            ucDdo_br_vitalid.SetProperty("IncludeDataList", Ddo_br_vitalid_Includedatalist);
            ucDdo_br_vitalid.SetProperty("SortASC", Ddo_br_vitalid_Sortasc);
            ucDdo_br_vitalid.SetProperty("SortDSC", Ddo_br_vitalid_Sortdsc);
            ucDdo_br_vitalid.SetProperty("CleanFilter", Ddo_br_vitalid_Cleanfilter);
            ucDdo_br_vitalid.SetProperty("RangeFilterFrom", Ddo_br_vitalid_Rangefilterfrom);
            ucDdo_br_vitalid.SetProperty("RangeFilterTo", Ddo_br_vitalid_Rangefilterto);
            ucDdo_br_vitalid.SetProperty("SearchButtonText", Ddo_br_vitalid_Searchbuttontext);
            ucDdo_br_vitalid.SetProperty("DropDownOptionsTitleSettingsIcons", AV51DDO_TitleSettingsIcons);
            ucDdo_br_vitalid.SetProperty("DropDownOptionsData", AV17BR_VitalIDTitleFilterData);
            ucDdo_br_vitalid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_vitalid_Internalname, sPrefix+"DDO_BR_VITALIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 26,'" + sPrefix + "',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_vitalidtitlecontrolidtoreplace_Internalname, AV20ddo_BR_VitalIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,26);\"", 0, edtavDdo_br_vitalidtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_EncounterCheckVitalWC.htm");
            /* User Defined Control */
            ucDdo_br_vital_measuredate.SetProperty("Caption", Ddo_br_vital_measuredate_Caption);
            ucDdo_br_vital_measuredate.SetProperty("Tooltip", Ddo_br_vital_measuredate_Tooltip);
            ucDdo_br_vital_measuredate.SetProperty("Cls", Ddo_br_vital_measuredate_Cls);
            ucDdo_br_vital_measuredate.SetProperty("DropDownOptionsType", Ddo_br_vital_measuredate_Dropdownoptionstype);
            ucDdo_br_vital_measuredate.SetProperty("IncludeSortASC", Ddo_br_vital_measuredate_Includesortasc);
            ucDdo_br_vital_measuredate.SetProperty("IncludeSortDSC", Ddo_br_vital_measuredate_Includesortdsc);
            ucDdo_br_vital_measuredate.SetProperty("IncludeFilter", Ddo_br_vital_measuredate_Includefilter);
            ucDdo_br_vital_measuredate.SetProperty("FilterType", Ddo_br_vital_measuredate_Filtertype);
            ucDdo_br_vital_measuredate.SetProperty("FilterIsRange", Ddo_br_vital_measuredate_Filterisrange);
            ucDdo_br_vital_measuredate.SetProperty("IncludeDataList", Ddo_br_vital_measuredate_Includedatalist);
            ucDdo_br_vital_measuredate.SetProperty("SortASC", Ddo_br_vital_measuredate_Sortasc);
            ucDdo_br_vital_measuredate.SetProperty("SortDSC", Ddo_br_vital_measuredate_Sortdsc);
            ucDdo_br_vital_measuredate.SetProperty("CleanFilter", Ddo_br_vital_measuredate_Cleanfilter);
            ucDdo_br_vital_measuredate.SetProperty("RangeFilterFrom", Ddo_br_vital_measuredate_Rangefilterfrom);
            ucDdo_br_vital_measuredate.SetProperty("RangeFilterTo", Ddo_br_vital_measuredate_Rangefilterto);
            ucDdo_br_vital_measuredate.SetProperty("SearchButtonText", Ddo_br_vital_measuredate_Searchbuttontext);
            ucDdo_br_vital_measuredate.SetProperty("DropDownOptionsTitleSettingsIcons", AV51DDO_TitleSettingsIcons);
            ucDdo_br_vital_measuredate.SetProperty("DropDownOptionsData", AV21BR_Vital_MeasureDateTitleFilterData);
            ucDdo_br_vital_measuredate.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_vital_measuredate_Internalname, sPrefix+"DDO_BR_VITAL_MEASUREDATEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 28,'" + sPrefix + "',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_vital_measuredatetitlecontrolidtoreplace_Internalname, AV26ddo_BR_Vital_MeasureDateTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,28);\"", 0, edtavDdo_br_vital_measuredatetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_EncounterCheckVitalWC.htm");
            /* User Defined Control */
            ucDdo_br_vital_weight.SetProperty("Caption", Ddo_br_vital_weight_Caption);
            ucDdo_br_vital_weight.SetProperty("Tooltip", Ddo_br_vital_weight_Tooltip);
            ucDdo_br_vital_weight.SetProperty("Cls", Ddo_br_vital_weight_Cls);
            ucDdo_br_vital_weight.SetProperty("DropDownOptionsType", Ddo_br_vital_weight_Dropdownoptionstype);
            ucDdo_br_vital_weight.SetProperty("IncludeSortASC", Ddo_br_vital_weight_Includesortasc);
            ucDdo_br_vital_weight.SetProperty("IncludeSortDSC", Ddo_br_vital_weight_Includesortdsc);
            ucDdo_br_vital_weight.SetProperty("IncludeFilter", Ddo_br_vital_weight_Includefilter);
            ucDdo_br_vital_weight.SetProperty("FilterType", Ddo_br_vital_weight_Filtertype);
            ucDdo_br_vital_weight.SetProperty("FilterIsRange", Ddo_br_vital_weight_Filterisrange);
            ucDdo_br_vital_weight.SetProperty("IncludeDataList", Ddo_br_vital_weight_Includedatalist);
            ucDdo_br_vital_weight.SetProperty("SortASC", Ddo_br_vital_weight_Sortasc);
            ucDdo_br_vital_weight.SetProperty("SortDSC", Ddo_br_vital_weight_Sortdsc);
            ucDdo_br_vital_weight.SetProperty("CleanFilter", Ddo_br_vital_weight_Cleanfilter);
            ucDdo_br_vital_weight.SetProperty("RangeFilterFrom", Ddo_br_vital_weight_Rangefilterfrom);
            ucDdo_br_vital_weight.SetProperty("RangeFilterTo", Ddo_br_vital_weight_Rangefilterto);
            ucDdo_br_vital_weight.SetProperty("SearchButtonText", Ddo_br_vital_weight_Searchbuttontext);
            ucDdo_br_vital_weight.SetProperty("DropDownOptionsTitleSettingsIcons", AV51DDO_TitleSettingsIcons);
            ucDdo_br_vital_weight.SetProperty("DropDownOptionsData", AV27BR_Vital_WeightTitleFilterData);
            ucDdo_br_vital_weight.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_vital_weight_Internalname, sPrefix+"DDO_BR_VITAL_WEIGHTContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 30,'" + sPrefix + "',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_vital_weighttitlecontrolidtoreplace_Internalname, AV30ddo_BR_Vital_WeightTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,30);\"", 0, edtavDdo_br_vital_weighttitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_EncounterCheckVitalWC.htm");
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
            ucDdo_br_vital_temperature.SetProperty("DropDownOptionsTitleSettingsIcons", AV51DDO_TitleSettingsIcons);
            ucDdo_br_vital_temperature.SetProperty("DropDownOptionsData", AV31BR_Vital_TemperatureTitleFilterData);
            ucDdo_br_vital_temperature.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_vital_temperature_Internalname, sPrefix+"DDO_BR_VITAL_TEMPERATUREContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 32,'" + sPrefix + "',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_vital_temperaturetitlecontrolidtoreplace_Internalname, AV34ddo_BR_Vital_TemperatureTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,32);\"", 0, edtavDdo_br_vital_temperaturetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_EncounterCheckVitalWC.htm");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_EncounterID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A19BR_EncounterID), 18, 0, ".", "")), context.localUtil.Format( (decimal)(A19BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ"), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_EncounterID_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_EncounterID_Visible, 0, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "HLP_BR_EncounterCheckVitalWC.htm");
            /* User Defined Control */
            ucWorkwithplusutilities1.Render(context, "dvelop.workwithplusutilities", Workwithplusutilities1_Internalname, sPrefix+"WORKWITHPLUSUTILITIES1Container");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 35,'" + sPrefix + "',false,'" + sGXsfl_12_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrderedby_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV14OrderedBy), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV14OrderedBy), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,35);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrderedby_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrderedby_Visible, 1, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_EncounterCheckVitalWC.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 36,'" + sPrefix + "',false,'" + sGXsfl_12_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrdereddsc_Internalname, StringUtil.BoolToStr( AV15OrderedDsc), StringUtil.BoolToStr( AV15OrderedDsc), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,36);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrdereddsc_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrdereddsc_Visible, 1, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, 0, 0, true, "", "right", false, "HLP_BR_EncounterCheckVitalWC.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 37,'" + sPrefix + "',false,'" + sGXsfl_12_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_vitalid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV18TFBR_VitalID), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV18TFBR_VitalID), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,37);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_vitalid_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_vitalid_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_EncounterCheckVitalWC.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'" + sPrefix + "',false,'" + sGXsfl_12_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_vitalid_to_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV19TFBR_VitalID_To), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV19TFBR_VitalID_To), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,38);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_vitalid_to_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_vitalid_to_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_EncounterCheckVitalWC.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'" + sPrefix + "',false,'" + sGXsfl_12_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavTfbr_vital_measuredate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavTfbr_vital_measuredate_Internalname, context.localUtil.Format(AV22TFBR_Vital_MeasureDate, "9999/99/99"), context.localUtil.Format( AV22TFBR_Vital_MeasureDate, "9999/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',0,24,'chs',false,1);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,39);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_vital_measuredate_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_vital_measuredate_Visible, 1, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_EncounterCheckVitalWC.htm");
            GxWebStd.gx_bitmap( context, edtavTfbr_vital_measuredate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((edtavTfbr_vital_measuredate_Visible==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_EncounterCheckVitalWC.htm");
            context.WriteHtmlTextNl( "</div>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 40,'" + sPrefix + "',false,'" + sGXsfl_12_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavTfbr_vital_measuredate_to_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavTfbr_vital_measuredate_to_Internalname, context.localUtil.Format(AV23TFBR_Vital_MeasureDate_To, "9999/99/99"), context.localUtil.Format( AV23TFBR_Vital_MeasureDate_To, "9999/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',0,24,'chs',false,1);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,40);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_vital_measuredate_to_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_vital_measuredate_to_Visible, 1, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_EncounterCheckVitalWC.htm");
            GxWebStd.gx_bitmap( context, edtavTfbr_vital_measuredate_to_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((edtavTfbr_vital_measuredate_to_Visible==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_EncounterCheckVitalWC.htm");
            context.WriteHtmlTextNl( "</div>") ;
            /* Div Control */
            GxWebStd.gx_div_start( context, divDdo_br_vital_measuredateauxdates_Internalname, 1, 0, "px", 0, "px", "Invisible", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 42,'" + sPrefix + "',false,'" + sGXsfl_12_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavDdo_br_vital_measuredateauxdate_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavDdo_br_vital_measuredateauxdate_Internalname, context.localUtil.Format(AV24DDO_BR_Vital_MeasureDateAuxDate, "9999/99/99"), context.localUtil.Format( AV24DDO_BR_Vital_MeasureDateAuxDate, "9999/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',0,24,'chs',false,1);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,42);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavDdo_br_vital_measuredateauxdate_Jsonclick, 0, "Attribute", "", "", "", "", 1, 1, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_EncounterCheckVitalWC.htm");
            GxWebStd.gx_bitmap( context, edtavDdo_br_vital_measuredateauxdate_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_EncounterCheckVitalWC.htm");
            context.WriteHtmlTextNl( "</div>") ;
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'" + sPrefix + "',false,'" + sGXsfl_12_idx + "',0)\"";
            context.WriteHtmlText( "<div id=\""+edtavDdo_br_vital_measuredateauxdateto_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavDdo_br_vital_measuredateauxdateto_Internalname, context.localUtil.Format(AV25DDO_BR_Vital_MeasureDateAuxDateTo, "9999/99/99"), context.localUtil.Format( AV25DDO_BR_Vital_MeasureDateAuxDateTo, "9999/99/99"), TempTags+" onchange=\""+"gx.date.valid_date(this, 10,'YMD',0,24,'chs',false,1);"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,43);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavDdo_br_vital_measuredateauxdateto_Jsonclick, 0, "Attribute", "", "", "", "", 1, 1, 0, "text", "", 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_EncounterCheckVitalWC.htm");
            GxWebStd.gx_bitmap( context, edtavDdo_br_vital_measuredateauxdateto_Internalname+"_dp_trigger", context.GetImagePath( "61b9b5d3-dff6-4d59-9b00-da61bc2cbe93", "", context.GetTheme( )), "", "", "", "", ((1==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;", "", "", "", "", "", "", "", "", 1, false, false, "", "HLP_BR_EncounterCheckVitalWC.htm");
            context.WriteHtmlTextNl( "</div>") ;
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'" + sPrefix + "',false,'" + sGXsfl_12_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_vital_weight_Internalname, StringUtil.LTrim( StringUtil.NToC( AV28TFBR_Vital_Weight, 15, 5, ".", "")), StringUtil.LTrim( context.localUtil.Format( AV28TFBR_Vital_Weight, "ZZZZZZZZZ.ZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, ',','.','5');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,44);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_vital_weight_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_vital_weight_Visible, 1, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_EncounterCheckVitalWC.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 45,'" + sPrefix + "',false,'" + sGXsfl_12_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_vital_weight_to_Internalname, StringUtil.LTrim( StringUtil.NToC( AV29TFBR_Vital_Weight_To, 15, 5, ".", "")), StringUtil.LTrim( context.localUtil.Format( AV29TFBR_Vital_Weight_To, "ZZZZZZZZZ.ZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, ',','.','5');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,45);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_vital_weight_to_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_vital_weight_to_Visible, 1, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_EncounterCheckVitalWC.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'" + sPrefix + "',false,'" + sGXsfl_12_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_vital_temperature_Internalname, StringUtil.LTrim( StringUtil.NToC( AV32TFBR_Vital_Temperature, 15, 5, ".", "")), StringUtil.LTrim( context.localUtil.Format( AV32TFBR_Vital_Temperature, "ZZZZZZZZZ.ZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, ',','.','5');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,46);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_vital_temperature_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_vital_temperature_Visible, 1, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_EncounterCheckVitalWC.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 47,'" + sPrefix + "',false,'" + sGXsfl_12_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_vital_temperature_to_Internalname, StringUtil.LTrim( StringUtil.NToC( AV33TFBR_Vital_Temperature_To, 15, 5, ".", "")), StringUtil.LTrim( context.localUtil.Format( AV33TFBR_Vital_Temperature_To, "ZZZZZZZZZ.ZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_decimal( this, ',','.','5');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,47);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_vital_temperature_to_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_vital_temperature_to_Visible, 1, 0, "text", "", 15, "chr", 1, "row", 15, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_EncounterCheckVitalWC.htm");
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

      protected void START612( )
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
               STRUP610( ) ;
            }
         }
      }

      protected void WS612( )
      {
         START612( ) ;
         EVT612( ) ;
      }

      protected void EVT612( )
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
                                 STRUP610( ) ;
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
                                 STRUP610( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    E11612 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEROWSPERPAGE") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP610( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    E12612 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_VITALID.ONOPTIONCLICKED") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP610( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    E13612 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_VITAL_MEASUREDATE.ONOPTIONCLICKED") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP610( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    E14612 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_VITAL_WEIGHT.ONOPTIONCLICKED") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP610( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    E15612 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_VITAL_TEMPERATURE.ONOPTIONCLICKED") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP610( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    E16612 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP610( ) ;
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
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 7), "REFRESH") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 9), "GRID.LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP610( ) ;
                              }
                              nGXsfl_12_idx = (short)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_12_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_12_idx), 4, 0)), 4, "0");
                              SubsflControlProps_122( ) ;
                              AV57Display = cgiGet( edtavDisplay_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDisplay_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV57Display)) ? AV64Display_GXI : context.convertURL( context.PathToRelativeUrl( AV57Display))), !bGXsfl_12_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDisplay_Internalname, "SrcSet", context.GetImageSrcSet( AV57Display), true);
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
                                          E17612 ();
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
                                          E18612 ();
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
                                          E19612 ();
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
                                             /* Set Refresh If Tfbr_vitalid Changed */
                                             if ( ( context.localUtil.CToN( cgiGet( sPrefix+"GXH_vTFBR_VITALID"), ".", ",") != Convert.ToDecimal( AV18TFBR_VitalID )) )
                                             {
                                                Rfr0gs = true;
                                             }
                                             /* Set Refresh If Tfbr_vitalid_to Changed */
                                             if ( ( context.localUtil.CToN( cgiGet( sPrefix+"GXH_vTFBR_VITALID_TO"), ".", ",") != Convert.ToDecimal( AV19TFBR_VitalID_To )) )
                                             {
                                                Rfr0gs = true;
                                             }
                                             /* Set Refresh If Tfbr_vital_measuredate Changed */
                                             if ( context.localUtil.CToT( cgiGet( sPrefix+"GXH_vTFBR_VITAL_MEASUREDATE"), 0) != AV22TFBR_Vital_MeasureDate )
                                             {
                                                Rfr0gs = true;
                                             }
                                             /* Set Refresh If Tfbr_vital_measuredate_to Changed */
                                             if ( context.localUtil.CToT( cgiGet( sPrefix+"GXH_vTFBR_VITAL_MEASUREDATE_TO"), 0) != AV23TFBR_Vital_MeasureDate_To )
                                             {
                                                Rfr0gs = true;
                                             }
                                             /* Set Refresh If Tfbr_vital_weight Changed */
                                             if ( context.localUtil.CToN( cgiGet( sPrefix+"GXH_vTFBR_VITAL_WEIGHT"), ".", ",") != AV28TFBR_Vital_Weight )
                                             {
                                                Rfr0gs = true;
                                             }
                                             /* Set Refresh If Tfbr_vital_weight_to Changed */
                                             if ( context.localUtil.CToN( cgiGet( sPrefix+"GXH_vTFBR_VITAL_WEIGHT_TO"), ".", ",") != AV29TFBR_Vital_Weight_To )
                                             {
                                                Rfr0gs = true;
                                             }
                                             /* Set Refresh If Tfbr_vital_temperature Changed */
                                             if ( context.localUtil.CToN( cgiGet( sPrefix+"GXH_vTFBR_VITAL_TEMPERATURE"), ".", ",") != AV32TFBR_Vital_Temperature )
                                             {
                                                Rfr0gs = true;
                                             }
                                             /* Set Refresh If Tfbr_vital_temperature_to Changed */
                                             if ( context.localUtil.CToN( cgiGet( sPrefix+"GXH_vTFBR_VITAL_TEMPERATURE_TO"), ".", ",") != AV33TFBR_Vital_Temperature_To )
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
                                       STRUP610( ) ;
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

      protected void WE612( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm612( ) ;
            }
         }
      }

      protected void PA612( )
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
                                       short AV14OrderedBy ,
                                       bool AV15OrderedDsc ,
                                       long AV18TFBR_VitalID ,
                                       long AV19TFBR_VitalID_To ,
                                       DateTime AV22TFBR_Vital_MeasureDate ,
                                       DateTime AV23TFBR_Vital_MeasureDate_To ,
                                       decimal AV28TFBR_Vital_Weight ,
                                       decimal AV29TFBR_Vital_Weight_To ,
                                       decimal AV32TFBR_Vital_Temperature ,
                                       decimal AV33TFBR_Vital_Temperature_To ,
                                       long AV8BR_EncounterID ,
                                       String AV20ddo_BR_VitalIDTitleControlIdToReplace ,
                                       String AV26ddo_BR_Vital_MeasureDateTitleControlIdToReplace ,
                                       String AV30ddo_BR_Vital_WeightTitleControlIdToReplace ,
                                       String AV34ddo_BR_Vital_TemperatureTitleControlIdToReplace ,
                                       String AV65Pgmname ,
                                       bool AV58IsAuthorized_Display ,
                                       String sPrefix )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GRID_nCurrentRecord = 0;
         RF612( ) ;
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
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RF612( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV65Pgmname = "BR_EncounterCheckVitalWC";
         context.Gx_err = 0;
      }

      protected void RF612( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridContainer.ClearRows();
         }
         wbStart = 12;
         /* Execute user event: Refresh */
         E18612 ();
         nGXsfl_12_idx = 1;
         sGXsfl_12_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_12_idx), 4, 0)), 4, "0");
         SubsflControlProps_122( ) ;
         bGXsfl_12_Refreshing = true;
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
            SubsflControlProps_122( ) ;
            GXPagingFrom2 = (int)(((subGrid_Rows==0) ? 0 : GRID_nFirstRecordOnPage));
            GXPagingTo2 = ((subGrid_Rows==0) ? 10000 : subGrid_Recordsperpage( )+1);
            pr_default.dynParam(0, new Object[]{ new Object[]{
                                                 AV18TFBR_VitalID ,
                                                 AV19TFBR_VitalID_To ,
                                                 AV22TFBR_Vital_MeasureDate ,
                                                 AV23TFBR_Vital_MeasureDate_To ,
                                                 AV28TFBR_Vital_Weight ,
                                                 AV29TFBR_Vital_Weight_To ,
                                                 AV32TFBR_Vital_Temperature ,
                                                 AV33TFBR_Vital_Temperature_To ,
                                                 A150BR_VitalID ,
                                                 A152BR_Vital_MeasureDate ,
                                                 A159BR_Vital_Weight ,
                                                 A153BR_Vital_Temperature ,
                                                 AV14OrderedBy ,
                                                 AV15OrderedDsc ,
                                                 A19BR_EncounterID ,
                                                 AV8BR_EncounterID } ,
                                                 new int[]{
                                                 TypeConstants.LONG, TypeConstants.LONG, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.LONG, TypeConstants.DATE,
                                                 TypeConstants.BOOLEAN, TypeConstants.DECIMAL, TypeConstants.BOOLEAN, TypeConstants.DECIMAL, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.LONG
                                                 }
            } ) ;
            /* Using cursor H00612 */
            pr_default.execute(0, new Object[] {AV8BR_EncounterID, AV18TFBR_VitalID, AV19TFBR_VitalID_To, AV22TFBR_Vital_MeasureDate, AV23TFBR_Vital_MeasureDate_To, AV28TFBR_Vital_Weight, AV29TFBR_Vital_Weight_To, AV32TFBR_Vital_Temperature, AV33TFBR_Vital_Temperature_To, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_12_idx = 1;
            sGXsfl_12_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_12_idx), 4, 0)), 4, "0");
            SubsflControlProps_122( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < subGrid_Recordsperpage( ) ) ) ) )
            {
               A19BR_EncounterID = H00612_A19BR_EncounterID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
               A153BR_Vital_Temperature = H00612_A153BR_Vital_Temperature[0];
               n153BR_Vital_Temperature = H00612_n153BR_Vital_Temperature[0];
               A159BR_Vital_Weight = H00612_A159BR_Vital_Weight[0];
               n159BR_Vital_Weight = H00612_n159BR_Vital_Weight[0];
               A152BR_Vital_MeasureDate = H00612_A152BR_Vital_MeasureDate[0];
               n152BR_Vital_MeasureDate = H00612_n152BR_Vital_MeasureDate[0];
               A150BR_VitalID = H00612_A150BR_VitalID[0];
               E19612 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, sPrefix+"GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 12;
            WB610( ) ;
         }
         bGXsfl_12_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes612( )
      {
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
                                              AV18TFBR_VitalID ,
                                              AV19TFBR_VitalID_To ,
                                              AV22TFBR_Vital_MeasureDate ,
                                              AV23TFBR_Vital_MeasureDate_To ,
                                              AV28TFBR_Vital_Weight ,
                                              AV29TFBR_Vital_Weight_To ,
                                              AV32TFBR_Vital_Temperature ,
                                              AV33TFBR_Vital_Temperature_To ,
                                              A150BR_VitalID ,
                                              A152BR_Vital_MeasureDate ,
                                              A159BR_Vital_Weight ,
                                              A153BR_Vital_Temperature ,
                                              AV14OrderedBy ,
                                              AV15OrderedDsc ,
                                              A19BR_EncounterID ,
                                              AV8BR_EncounterID } ,
                                              new int[]{
                                              TypeConstants.LONG, TypeConstants.LONG, TypeConstants.DATE, TypeConstants.DATE, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.DECIMAL, TypeConstants.LONG, TypeConstants.DATE,
                                              TypeConstants.BOOLEAN, TypeConstants.DECIMAL, TypeConstants.BOOLEAN, TypeConstants.DECIMAL, TypeConstants.BOOLEAN, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.LONG
                                              }
         } ) ;
         /* Using cursor H00613 */
         pr_default.execute(1, new Object[] {AV8BR_EncounterID, AV18TFBR_VitalID, AV19TFBR_VitalID_To, AV22TFBR_Vital_MeasureDate, AV23TFBR_Vital_MeasureDate_To, AV28TFBR_Vital_Weight, AV29TFBR_Vital_Weight_To, AV32TFBR_Vital_Temperature, AV33TFBR_Vital_Temperature_To});
         GRID_nRecordCount = H00613_AGRID_nRecordCount[0];
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
            gxgrGrid_refresh( subGrid_Rows, AV14OrderedBy, AV15OrderedDsc, AV18TFBR_VitalID, AV19TFBR_VitalID_To, AV22TFBR_Vital_MeasureDate, AV23TFBR_Vital_MeasureDate_To, AV28TFBR_Vital_Weight, AV29TFBR_Vital_Weight_To, AV32TFBR_Vital_Temperature, AV33TFBR_Vital_Temperature_To, AV8BR_EncounterID, AV20ddo_BR_VitalIDTitleControlIdToReplace, AV26ddo_BR_Vital_MeasureDateTitleControlIdToReplace, AV30ddo_BR_Vital_WeightTitleControlIdToReplace, AV34ddo_BR_Vital_TemperatureTitleControlIdToReplace, AV65Pgmname, AV58IsAuthorized_Display, sPrefix) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV14OrderedBy, AV15OrderedDsc, AV18TFBR_VitalID, AV19TFBR_VitalID_To, AV22TFBR_Vital_MeasureDate, AV23TFBR_Vital_MeasureDate_To, AV28TFBR_Vital_Weight, AV29TFBR_Vital_Weight_To, AV32TFBR_Vital_Temperature, AV33TFBR_Vital_Temperature_To, AV8BR_EncounterID, AV20ddo_BR_VitalIDTitleControlIdToReplace, AV26ddo_BR_Vital_MeasureDateTitleControlIdToReplace, AV30ddo_BR_Vital_WeightTitleControlIdToReplace, AV34ddo_BR_Vital_TemperatureTitleControlIdToReplace, AV65Pgmname, AV58IsAuthorized_Display, sPrefix) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV14OrderedBy, AV15OrderedDsc, AV18TFBR_VitalID, AV19TFBR_VitalID_To, AV22TFBR_Vital_MeasureDate, AV23TFBR_Vital_MeasureDate_To, AV28TFBR_Vital_Weight, AV29TFBR_Vital_Weight_To, AV32TFBR_Vital_Temperature, AV33TFBR_Vital_Temperature_To, AV8BR_EncounterID, AV20ddo_BR_VitalIDTitleControlIdToReplace, AV26ddo_BR_Vital_MeasureDateTitleControlIdToReplace, AV30ddo_BR_Vital_WeightTitleControlIdToReplace, AV34ddo_BR_Vital_TemperatureTitleControlIdToReplace, AV65Pgmname, AV58IsAuthorized_Display, sPrefix) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV14OrderedBy, AV15OrderedDsc, AV18TFBR_VitalID, AV19TFBR_VitalID_To, AV22TFBR_Vital_MeasureDate, AV23TFBR_Vital_MeasureDate_To, AV28TFBR_Vital_Weight, AV29TFBR_Vital_Weight_To, AV32TFBR_Vital_Temperature, AV33TFBR_Vital_Temperature_To, AV8BR_EncounterID, AV20ddo_BR_VitalIDTitleControlIdToReplace, AV26ddo_BR_Vital_MeasureDateTitleControlIdToReplace, AV30ddo_BR_Vital_WeightTitleControlIdToReplace, AV34ddo_BR_Vital_TemperatureTitleControlIdToReplace, AV65Pgmname, AV58IsAuthorized_Display, sPrefix) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV14OrderedBy, AV15OrderedDsc, AV18TFBR_VitalID, AV19TFBR_VitalID_To, AV22TFBR_Vital_MeasureDate, AV23TFBR_Vital_MeasureDate_To, AV28TFBR_Vital_Weight, AV29TFBR_Vital_Weight_To, AV32TFBR_Vital_Temperature, AV33TFBR_Vital_Temperature_To, AV8BR_EncounterID, AV20ddo_BR_VitalIDTitleControlIdToReplace, AV26ddo_BR_Vital_MeasureDateTitleControlIdToReplace, AV30ddo_BR_Vital_WeightTitleControlIdToReplace, AV34ddo_BR_Vital_TemperatureTitleControlIdToReplace, AV65Pgmname, AV58IsAuthorized_Display, sPrefix) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP610( )
      {
         /* Before Start, stand alone formulas. */
         AV65Pgmname = "BR_EncounterCheckVitalWC";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E17612 ();
         context.wbGlbDoneStart = 1;
         nDoneStart = 1;
         /* After Start, stand alone formulas. */
         sXEvt = cgiGet( "_EventName");
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( sPrefix+"vDDO_TITLESETTINGSICONS"), AV51DDO_TitleSettingsIcons);
            ajax_req_read_hidden_sdt(cgiGet( sPrefix+"vBR_VITALIDTITLEFILTERDATA"), AV17BR_VitalIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( sPrefix+"vBR_VITAL_MEASUREDATETITLEFILTERDATA"), AV21BR_Vital_MeasureDateTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( sPrefix+"vBR_VITAL_WEIGHTTITLEFILTERDATA"), AV27BR_Vital_WeightTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( sPrefix+"vBR_VITAL_TEMPERATURETITLEFILTERDATA"), AV31BR_Vital_TemperatureTitleFilterData);
            /* Read variables values. */
            AV20ddo_BR_VitalIDTitleControlIdToReplace = cgiGet( edtavDdo_br_vitalidtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV20ddo_BR_VitalIDTitleControlIdToReplace", AV20ddo_BR_VitalIDTitleControlIdToReplace);
            AV26ddo_BR_Vital_MeasureDateTitleControlIdToReplace = cgiGet( edtavDdo_br_vital_measuredatetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV26ddo_BR_Vital_MeasureDateTitleControlIdToReplace", AV26ddo_BR_Vital_MeasureDateTitleControlIdToReplace);
            AV30ddo_BR_Vital_WeightTitleControlIdToReplace = cgiGet( edtavDdo_br_vital_weighttitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV30ddo_BR_Vital_WeightTitleControlIdToReplace", AV30ddo_BR_Vital_WeightTitleControlIdToReplace);
            AV34ddo_BR_Vital_TemperatureTitleControlIdToReplace = cgiGet( edtavDdo_br_vital_temperaturetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV34ddo_BR_Vital_TemperatureTitleControlIdToReplace", AV34ddo_BR_Vital_TemperatureTitleControlIdToReplace);
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
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_vitalid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_vitalid_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_VITALID");
               GX_FocusControl = edtavTfbr_vitalid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV18TFBR_VitalID = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV18TFBR_VitalID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18TFBR_VitalID), 18, 0)));
            }
            else
            {
               AV18TFBR_VitalID = (long)(context.localUtil.CToN( cgiGet( edtavTfbr_vitalid_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV18TFBR_VitalID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18TFBR_VitalID), 18, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_vitalid_to_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_vitalid_to_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_VITALID_TO");
               GX_FocusControl = edtavTfbr_vitalid_to_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV19TFBR_VitalID_To = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV19TFBR_VitalID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV19TFBR_VitalID_To), 18, 0)));
            }
            else
            {
               AV19TFBR_VitalID_To = (long)(context.localUtil.CToN( cgiGet( edtavTfbr_vitalid_to_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV19TFBR_VitalID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV19TFBR_VitalID_To), 18, 0)));
            }
            if ( context.localUtil.VCDate( cgiGet( edtavTfbr_vital_measuredate_Internalname), 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"TFBR_Vital_Measure Date"}), 1, "vTFBR_VITAL_MEASUREDATE");
               GX_FocusControl = edtavTfbr_vital_measuredate_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV22TFBR_Vital_MeasureDate = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV22TFBR_Vital_MeasureDate", context.localUtil.Format(AV22TFBR_Vital_MeasureDate, "9999/99/99"));
            }
            else
            {
               AV22TFBR_Vital_MeasureDate = context.localUtil.CToD( cgiGet( edtavTfbr_vital_measuredate_Internalname), 0);
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV22TFBR_Vital_MeasureDate", context.localUtil.Format(AV22TFBR_Vital_MeasureDate, "9999/99/99"));
            }
            if ( context.localUtil.VCDate( cgiGet( edtavTfbr_vital_measuredate_to_Internalname), 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"TFBR_Vital_Measure Date_To"}), 1, "vTFBR_VITAL_MEASUREDATE_TO");
               GX_FocusControl = edtavTfbr_vital_measuredate_to_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV23TFBR_Vital_MeasureDate_To = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV23TFBR_Vital_MeasureDate_To", context.localUtil.Format(AV23TFBR_Vital_MeasureDate_To, "9999/99/99"));
            }
            else
            {
               AV23TFBR_Vital_MeasureDate_To = context.localUtil.CToD( cgiGet( edtavTfbr_vital_measuredate_to_Internalname), 0);
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV23TFBR_Vital_MeasureDate_To", context.localUtil.Format(AV23TFBR_Vital_MeasureDate_To, "9999/99/99"));
            }
            if ( context.localUtil.VCDate( cgiGet( edtavDdo_br_vital_measuredateauxdate_Internalname), 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"DDO_BR_Vital_Measure Date Aux Date"}), 1, "vDDO_BR_VITAL_MEASUREDATEAUXDATE");
               GX_FocusControl = edtavDdo_br_vital_measuredateauxdate_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV24DDO_BR_Vital_MeasureDateAuxDate = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV24DDO_BR_Vital_MeasureDateAuxDate", context.localUtil.Format(AV24DDO_BR_Vital_MeasureDateAuxDate, "9999/99/99"));
            }
            else
            {
               AV24DDO_BR_Vital_MeasureDateAuxDate = context.localUtil.CToD( cgiGet( edtavDdo_br_vital_measuredateauxdate_Internalname), 0);
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV24DDO_BR_Vital_MeasureDateAuxDate", context.localUtil.Format(AV24DDO_BR_Vital_MeasureDateAuxDate, "9999/99/99"));
            }
            if ( context.localUtil.VCDate( cgiGet( edtavDdo_br_vital_measuredateauxdateto_Internalname), 0) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"DDO_BR_Vital_Measure Date Aux Date To"}), 1, "vDDO_BR_VITAL_MEASUREDATEAUXDATETO");
               GX_FocusControl = edtavDdo_br_vital_measuredateauxdateto_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV25DDO_BR_Vital_MeasureDateAuxDateTo = DateTime.MinValue;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV25DDO_BR_Vital_MeasureDateAuxDateTo", context.localUtil.Format(AV25DDO_BR_Vital_MeasureDateAuxDateTo, "9999/99/99"));
            }
            else
            {
               AV25DDO_BR_Vital_MeasureDateAuxDateTo = context.localUtil.CToD( cgiGet( edtavDdo_br_vital_measuredateauxdateto_Internalname), 0);
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV25DDO_BR_Vital_MeasureDateAuxDateTo", context.localUtil.Format(AV25DDO_BR_Vital_MeasureDateAuxDateTo, "9999/99/99"));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_vital_weight_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_vital_weight_Internalname), ".", ",") > 999999999.99999m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_VITAL_WEIGHT");
               GX_FocusControl = edtavTfbr_vital_weight_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV28TFBR_Vital_Weight = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV28TFBR_Vital_Weight", StringUtil.LTrim( StringUtil.Str( AV28TFBR_Vital_Weight, 15, 5)));
            }
            else
            {
               AV28TFBR_Vital_Weight = context.localUtil.CToN( cgiGet( edtavTfbr_vital_weight_Internalname), ".", ",");
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV28TFBR_Vital_Weight", StringUtil.LTrim( StringUtil.Str( AV28TFBR_Vital_Weight, 15, 5)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_vital_weight_to_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_vital_weight_to_Internalname), ".", ",") > 999999999.99999m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_VITAL_WEIGHT_TO");
               GX_FocusControl = edtavTfbr_vital_weight_to_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV29TFBR_Vital_Weight_To = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV29TFBR_Vital_Weight_To", StringUtil.LTrim( StringUtil.Str( AV29TFBR_Vital_Weight_To, 15, 5)));
            }
            else
            {
               AV29TFBR_Vital_Weight_To = context.localUtil.CToN( cgiGet( edtavTfbr_vital_weight_to_Internalname), ".", ",");
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV29TFBR_Vital_Weight_To", StringUtil.LTrim( StringUtil.Str( AV29TFBR_Vital_Weight_To, 15, 5)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_vital_temperature_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_vital_temperature_Internalname), ".", ",") > 999999999.99999m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_VITAL_TEMPERATURE");
               GX_FocusControl = edtavTfbr_vital_temperature_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV32TFBR_Vital_Temperature = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV32TFBR_Vital_Temperature", StringUtil.LTrim( StringUtil.Str( AV32TFBR_Vital_Temperature, 15, 5)));
            }
            else
            {
               AV32TFBR_Vital_Temperature = context.localUtil.CToN( cgiGet( edtavTfbr_vital_temperature_Internalname), ".", ",");
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV32TFBR_Vital_Temperature", StringUtil.LTrim( StringUtil.Str( AV32TFBR_Vital_Temperature, 15, 5)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_vital_temperature_to_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_vital_temperature_to_Internalname), ".", ",") > 999999999.99999m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_VITAL_TEMPERATURE_TO");
               GX_FocusControl = edtavTfbr_vital_temperature_to_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV33TFBR_Vital_Temperature_To = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV33TFBR_Vital_Temperature_To", StringUtil.LTrim( StringUtil.Str( AV33TFBR_Vital_Temperature_To, 15, 5)));
            }
            else
            {
               AV33TFBR_Vital_Temperature_To = context.localUtil.CToN( cgiGet( edtavTfbr_vital_temperature_to_Internalname), ".", ",");
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV33TFBR_Vital_Temperature_To", StringUtil.LTrim( StringUtil.Str( AV33TFBR_Vital_Temperature_To, 15, 5)));
            }
            /* Read saved values. */
            nRC_GXsfl_12 = (short)(context.localUtil.CToN( cgiGet( sPrefix+"nRC_GXsfl_12"), ".", ","));
            AV54GridCurrentPage = (long)(context.localUtil.CToN( cgiGet( sPrefix+"vGRIDCURRENTPAGE"), ".", ","));
            AV56GridRecordCount = (long)(context.localUtil.CToN( cgiGet( sPrefix+"vGRIDRECORDCOUNT"), ".", ","));
            AV55GridPageSize = (long)(context.localUtil.CToN( cgiGet( sPrefix+"vGRIDPAGESIZE"), ".", ","));
            wcpOAV8BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( sPrefix+"wcpOAV8BR_EncounterID"), ".", ","));
            GRID_nFirstRecordOnPage = (long)(context.localUtil.CToN( cgiGet( sPrefix+"GRID_nFirstRecordOnPage"), ".", ","));
            GRID_nEOF = (short)(context.localUtil.CToN( cgiGet( sPrefix+"GRID_nEOF"), ".", ","));
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( sPrefix+"GRID_Rows"), ".", ","));
            GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
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
            Ddo_br_vitalid_Filteredtext_set = cgiGet( sPrefix+"DDO_BR_VITALID_Filteredtext_set");
            Ddo_br_vitalid_Filteredtextto_set = cgiGet( sPrefix+"DDO_BR_VITALID_Filteredtextto_set");
            Ddo_br_vitalid_Dropdownoptionstype = cgiGet( sPrefix+"DDO_BR_VITALID_Dropdownoptionstype");
            Ddo_br_vitalid_Titlecontrolidtoreplace = cgiGet( sPrefix+"DDO_BR_VITALID_Titlecontrolidtoreplace");
            Ddo_br_vitalid_Includesortasc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_VITALID_Includesortasc"));
            Ddo_br_vitalid_Includesortdsc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_VITALID_Includesortdsc"));
            Ddo_br_vitalid_Sortedstatus = cgiGet( sPrefix+"DDO_BR_VITALID_Sortedstatus");
            Ddo_br_vitalid_Includefilter = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_VITALID_Includefilter"));
            Ddo_br_vitalid_Filtertype = cgiGet( sPrefix+"DDO_BR_VITALID_Filtertype");
            Ddo_br_vitalid_Filterisrange = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_VITALID_Filterisrange"));
            Ddo_br_vitalid_Includedatalist = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_VITALID_Includedatalist"));
            Ddo_br_vitalid_Sortasc = cgiGet( sPrefix+"DDO_BR_VITALID_Sortasc");
            Ddo_br_vitalid_Sortdsc = cgiGet( sPrefix+"DDO_BR_VITALID_Sortdsc");
            Ddo_br_vitalid_Cleanfilter = cgiGet( sPrefix+"DDO_BR_VITALID_Cleanfilter");
            Ddo_br_vitalid_Rangefilterfrom = cgiGet( sPrefix+"DDO_BR_VITALID_Rangefilterfrom");
            Ddo_br_vitalid_Rangefilterto = cgiGet( sPrefix+"DDO_BR_VITALID_Rangefilterto");
            Ddo_br_vitalid_Searchbuttontext = cgiGet( sPrefix+"DDO_BR_VITALID_Searchbuttontext");
            Ddo_br_vital_measuredate_Caption = cgiGet( sPrefix+"DDO_BR_VITAL_MEASUREDATE_Caption");
            Ddo_br_vital_measuredate_Tooltip = cgiGet( sPrefix+"DDO_BR_VITAL_MEASUREDATE_Tooltip");
            Ddo_br_vital_measuredate_Cls = cgiGet( sPrefix+"DDO_BR_VITAL_MEASUREDATE_Cls");
            Ddo_br_vital_measuredate_Filteredtext_set = cgiGet( sPrefix+"DDO_BR_VITAL_MEASUREDATE_Filteredtext_set");
            Ddo_br_vital_measuredate_Filteredtextto_set = cgiGet( sPrefix+"DDO_BR_VITAL_MEASUREDATE_Filteredtextto_set");
            Ddo_br_vital_measuredate_Dropdownoptionstype = cgiGet( sPrefix+"DDO_BR_VITAL_MEASUREDATE_Dropdownoptionstype");
            Ddo_br_vital_measuredate_Titlecontrolidtoreplace = cgiGet( sPrefix+"DDO_BR_VITAL_MEASUREDATE_Titlecontrolidtoreplace");
            Ddo_br_vital_measuredate_Includesortasc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_VITAL_MEASUREDATE_Includesortasc"));
            Ddo_br_vital_measuredate_Includesortdsc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_VITAL_MEASUREDATE_Includesortdsc"));
            Ddo_br_vital_measuredate_Sortedstatus = cgiGet( sPrefix+"DDO_BR_VITAL_MEASUREDATE_Sortedstatus");
            Ddo_br_vital_measuredate_Includefilter = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_VITAL_MEASUREDATE_Includefilter"));
            Ddo_br_vital_measuredate_Filtertype = cgiGet( sPrefix+"DDO_BR_VITAL_MEASUREDATE_Filtertype");
            Ddo_br_vital_measuredate_Filterisrange = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_VITAL_MEASUREDATE_Filterisrange"));
            Ddo_br_vital_measuredate_Includedatalist = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_VITAL_MEASUREDATE_Includedatalist"));
            Ddo_br_vital_measuredate_Sortasc = cgiGet( sPrefix+"DDO_BR_VITAL_MEASUREDATE_Sortasc");
            Ddo_br_vital_measuredate_Sortdsc = cgiGet( sPrefix+"DDO_BR_VITAL_MEASUREDATE_Sortdsc");
            Ddo_br_vital_measuredate_Cleanfilter = cgiGet( sPrefix+"DDO_BR_VITAL_MEASUREDATE_Cleanfilter");
            Ddo_br_vital_measuredate_Rangefilterfrom = cgiGet( sPrefix+"DDO_BR_VITAL_MEASUREDATE_Rangefilterfrom");
            Ddo_br_vital_measuredate_Rangefilterto = cgiGet( sPrefix+"DDO_BR_VITAL_MEASUREDATE_Rangefilterto");
            Ddo_br_vital_measuredate_Searchbuttontext = cgiGet( sPrefix+"DDO_BR_VITAL_MEASUREDATE_Searchbuttontext");
            Ddo_br_vital_weight_Caption = cgiGet( sPrefix+"DDO_BR_VITAL_WEIGHT_Caption");
            Ddo_br_vital_weight_Tooltip = cgiGet( sPrefix+"DDO_BR_VITAL_WEIGHT_Tooltip");
            Ddo_br_vital_weight_Cls = cgiGet( sPrefix+"DDO_BR_VITAL_WEIGHT_Cls");
            Ddo_br_vital_weight_Filteredtext_set = cgiGet( sPrefix+"DDO_BR_VITAL_WEIGHT_Filteredtext_set");
            Ddo_br_vital_weight_Filteredtextto_set = cgiGet( sPrefix+"DDO_BR_VITAL_WEIGHT_Filteredtextto_set");
            Ddo_br_vital_weight_Dropdownoptionstype = cgiGet( sPrefix+"DDO_BR_VITAL_WEIGHT_Dropdownoptionstype");
            Ddo_br_vital_weight_Titlecontrolidtoreplace = cgiGet( sPrefix+"DDO_BR_VITAL_WEIGHT_Titlecontrolidtoreplace");
            Ddo_br_vital_weight_Includesortasc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_VITAL_WEIGHT_Includesortasc"));
            Ddo_br_vital_weight_Includesortdsc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_VITAL_WEIGHT_Includesortdsc"));
            Ddo_br_vital_weight_Sortedstatus = cgiGet( sPrefix+"DDO_BR_VITAL_WEIGHT_Sortedstatus");
            Ddo_br_vital_weight_Includefilter = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_VITAL_WEIGHT_Includefilter"));
            Ddo_br_vital_weight_Filtertype = cgiGet( sPrefix+"DDO_BR_VITAL_WEIGHT_Filtertype");
            Ddo_br_vital_weight_Filterisrange = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_VITAL_WEIGHT_Filterisrange"));
            Ddo_br_vital_weight_Includedatalist = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_VITAL_WEIGHT_Includedatalist"));
            Ddo_br_vital_weight_Sortasc = cgiGet( sPrefix+"DDO_BR_VITAL_WEIGHT_Sortasc");
            Ddo_br_vital_weight_Sortdsc = cgiGet( sPrefix+"DDO_BR_VITAL_WEIGHT_Sortdsc");
            Ddo_br_vital_weight_Cleanfilter = cgiGet( sPrefix+"DDO_BR_VITAL_WEIGHT_Cleanfilter");
            Ddo_br_vital_weight_Rangefilterfrom = cgiGet( sPrefix+"DDO_BR_VITAL_WEIGHT_Rangefilterfrom");
            Ddo_br_vital_weight_Rangefilterto = cgiGet( sPrefix+"DDO_BR_VITAL_WEIGHT_Rangefilterto");
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
            Ddo_br_vitalid_Filteredtext_get = cgiGet( sPrefix+"DDO_BR_VITALID_Filteredtext_get");
            Ddo_br_vitalid_Filteredtextto_get = cgiGet( sPrefix+"DDO_BR_VITALID_Filteredtextto_get");
            Ddo_br_vital_measuredate_Activeeventkey = cgiGet( sPrefix+"DDO_BR_VITAL_MEASUREDATE_Activeeventkey");
            Ddo_br_vital_measuredate_Filteredtext_get = cgiGet( sPrefix+"DDO_BR_VITAL_MEASUREDATE_Filteredtext_get");
            Ddo_br_vital_measuredate_Filteredtextto_get = cgiGet( sPrefix+"DDO_BR_VITAL_MEASUREDATE_Filteredtextto_get");
            Ddo_br_vital_weight_Activeeventkey = cgiGet( sPrefix+"DDO_BR_VITAL_WEIGHT_Activeeventkey");
            Ddo_br_vital_weight_Filteredtext_get = cgiGet( sPrefix+"DDO_BR_VITAL_WEIGHT_Filteredtext_get");
            Ddo_br_vital_weight_Filteredtextto_get = cgiGet( sPrefix+"DDO_BR_VITAL_WEIGHT_Filteredtextto_get");
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
            if ( ( context.localUtil.CToN( cgiGet( sPrefix+"GXH_vTFBR_VITALID"), ".", ",") != Convert.ToDecimal( AV18TFBR_VitalID )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( sPrefix+"GXH_vTFBR_VITALID_TO"), ".", ",") != Convert.ToDecimal( AV19TFBR_VitalID_To )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToD( cgiGet( sPrefix+"GXH_vTFBR_VITAL_MEASUREDATE"), 0) != AV22TFBR_Vital_MeasureDate )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToD( cgiGet( sPrefix+"GXH_vTFBR_VITAL_MEASUREDATE_TO"), 0) != AV23TFBR_Vital_MeasureDate_To )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToN( cgiGet( sPrefix+"GXH_vTFBR_VITAL_WEIGHT"), ".", ",") != AV28TFBR_Vital_Weight )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToN( cgiGet( sPrefix+"GXH_vTFBR_VITAL_WEIGHT_TO"), ".", ",") != AV29TFBR_Vital_Weight_To )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToN( cgiGet( sPrefix+"GXH_vTFBR_VITAL_TEMPERATURE"), ".", ",") != AV32TFBR_Vital_Temperature )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( context.localUtil.CToN( cgiGet( sPrefix+"GXH_vTFBR_VITAL_TEMPERATURE_TO"), ".", ",") != AV33TFBR_Vital_Temperature_To )
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
         E17612 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E17612( )
      {
         /* Start Routine */
         subGrid_Rows = 9;
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         edtavTfbr_vitalid_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavTfbr_vitalid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_vitalid_Visible), 5, 0)), true);
         edtavTfbr_vitalid_to_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavTfbr_vitalid_to_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_vitalid_to_Visible), 5, 0)), true);
         edtavTfbr_vital_measuredate_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavTfbr_vital_measuredate_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_vital_measuredate_Visible), 5, 0)), true);
         edtavTfbr_vital_measuredate_to_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavTfbr_vital_measuredate_to_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_vital_measuredate_to_Visible), 5, 0)), true);
         edtavTfbr_vital_weight_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavTfbr_vital_weight_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_vital_weight_Visible), 5, 0)), true);
         edtavTfbr_vital_weight_to_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavTfbr_vital_weight_to_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_vital_weight_to_Visible), 5, 0)), true);
         edtavTfbr_vital_temperature_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavTfbr_vital_temperature_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_vital_temperature_Visible), 5, 0)), true);
         edtavTfbr_vital_temperature_to_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavTfbr_vital_temperature_to_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_vital_temperature_to_Visible), 5, 0)), true);
         Ddo_br_vitalid_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_VitalID";
         ucDdo_br_vitalid.SendProperty(context, sPrefix, false, Ddo_br_vitalid_Internalname, "TitleControlIdToReplace", Ddo_br_vitalid_Titlecontrolidtoreplace);
         AV20ddo_BR_VitalIDTitleControlIdToReplace = Ddo_br_vitalid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV20ddo_BR_VitalIDTitleControlIdToReplace", AV20ddo_BR_VitalIDTitleControlIdToReplace);
         edtavDdo_br_vitalidtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDdo_br_vitalidtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_vitalidtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_vital_measuredate_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Vital_MeasureDate";
         ucDdo_br_vital_measuredate.SendProperty(context, sPrefix, false, Ddo_br_vital_measuredate_Internalname, "TitleControlIdToReplace", Ddo_br_vital_measuredate_Titlecontrolidtoreplace);
         AV26ddo_BR_Vital_MeasureDateTitleControlIdToReplace = Ddo_br_vital_measuredate_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV26ddo_BR_Vital_MeasureDateTitleControlIdToReplace", AV26ddo_BR_Vital_MeasureDateTitleControlIdToReplace);
         edtavDdo_br_vital_measuredatetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDdo_br_vital_measuredatetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_vital_measuredatetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_vital_weight_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Vital_Weight";
         ucDdo_br_vital_weight.SendProperty(context, sPrefix, false, Ddo_br_vital_weight_Internalname, "TitleControlIdToReplace", Ddo_br_vital_weight_Titlecontrolidtoreplace);
         AV30ddo_BR_Vital_WeightTitleControlIdToReplace = Ddo_br_vital_weight_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV30ddo_BR_Vital_WeightTitleControlIdToReplace", AV30ddo_BR_Vital_WeightTitleControlIdToReplace);
         edtavDdo_br_vital_weighttitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDdo_br_vital_weighttitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_vital_weighttitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_vital_temperature_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Vital_Temperature";
         ucDdo_br_vital_temperature.SendProperty(context, sPrefix, false, Ddo_br_vital_temperature_Internalname, "TitleControlIdToReplace", Ddo_br_vital_temperature_Titlecontrolidtoreplace);
         AV34ddo_BR_Vital_TemperatureTitleControlIdToReplace = Ddo_br_vital_temperature_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV34ddo_BR_Vital_TemperatureTitleControlIdToReplace", AV34ddo_BR_Vital_TemperatureTitleControlIdToReplace);
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
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 = AV51DDO_TitleSettingsIcons;
         new GeneXus.Programs.wwpbaseobjects.getwwptitlesettingsicons(context ).execute( out  GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1) ;
         AV51DDO_TitleSettingsIcons = GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1;
         Gridpaginationbar_Rowsperpageselectedvalue = subGrid_Rows;
         ucGridpaginationbar.SendProperty(context, sPrefix, false, Gridpaginationbar_Internalname, "RowsPerPageSelectedValue", StringUtil.LTrim( StringUtil.Str( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0)));
      }

      protected void E18612( )
      {
         if ( gx_refresh_fired )
         {
            return  ;
         }
         gx_refresh_fired = true;
         /* Refresh Routine */
         AV17BR_VitalIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV21BR_Vital_MeasureDateTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV27BR_Vital_WeightTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV31BR_Vital_TemperatureTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
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
         edtBR_VitalID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "序号", AV20ddo_BR_VitalIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_VitalID_Internalname, "Title", edtBR_VitalID_Title, !bGXsfl_12_Refreshing);
         edtBR_Vital_MeasureDate_Titleformat = 2;
         edtBR_Vital_MeasureDate_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "测量日期", AV26ddo_BR_Vital_MeasureDateTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_Vital_MeasureDate_Internalname, "Title", edtBR_Vital_MeasureDate_Title, !bGXsfl_12_Refreshing);
         edtBR_Vital_Weight_Titleformat = 2;
         edtBR_Vital_Weight_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "体重(kg)", AV30ddo_BR_Vital_WeightTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_Vital_Weight_Internalname, "Title", edtBR_Vital_Weight_Title, !bGXsfl_12_Refreshing);
         edtBR_Vital_Temperature_Titleformat = 2;
         edtBR_Vital_Temperature_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "体温(℃)", AV34ddo_BR_Vital_TemperatureTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_Vital_Temperature_Internalname, "Title", edtBR_Vital_Temperature_Title, !bGXsfl_12_Refreshing);
         AV54GridCurrentPage = subGrid_Currentpage( );
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV54GridCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV54GridCurrentPage), 10, 0)));
         AV55GridPageSize = subGrid_Rows;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV55GridPageSize", StringUtil.LTrim( StringUtil.Str( (decimal)(AV55GridPageSize), 10, 0)));
         AV56GridRecordCount = subGrid_Recordcount( );
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV56GridRecordCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV56GridRecordCount), 10, 0)));
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV17BR_VitalIDTitleFilterData", AV17BR_VitalIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV21BR_Vital_MeasureDateTitleFilterData", AV21BR_Vital_MeasureDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV27BR_Vital_WeightTitleFilterData", AV27BR_Vital_WeightTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV31BR_Vital_TemperatureTitleFilterData", AV31BR_Vital_TemperatureTitleFilterData);
      }

      protected void E11612( )
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
            AV53PageToGo = (int)(NumberUtil.Val( Gridpaginationbar_Selectedpage, "."));
            subgrid_gotopage( AV53PageToGo) ;
         }
      }

      protected void E12612( )
      {
         /* Gridpaginationbar_Changerowsperpage Routine */
         subGrid_Rows = Gridpaginationbar_Rowsperpageselectedvalue;
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         subgrid_firstpage( ) ;
         /*  Sending Event outputs  */
      }

      protected void E13612( )
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
         else if ( StringUtil.StrCmp(Ddo_br_vitalid_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV18TFBR_VitalID = (long)(NumberUtil.Val( Ddo_br_vitalid_Filteredtext_get, "."));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV18TFBR_VitalID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18TFBR_VitalID), 18, 0)));
            AV19TFBR_VitalID_To = (long)(NumberUtil.Val( Ddo_br_vitalid_Filteredtextto_get, "."));
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV19TFBR_VitalID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV19TFBR_VitalID_To), 18, 0)));
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV17BR_VitalIDTitleFilterData", AV17BR_VitalIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV21BR_Vital_MeasureDateTitleFilterData", AV21BR_Vital_MeasureDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV27BR_Vital_WeightTitleFilterData", AV27BR_Vital_WeightTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV31BR_Vital_TemperatureTitleFilterData", AV31BR_Vital_TemperatureTitleFilterData);
      }

      protected void E14612( )
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
         else if ( StringUtil.StrCmp(Ddo_br_vital_measuredate_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV22TFBR_Vital_MeasureDate = context.localUtil.CToD( Ddo_br_vital_measuredate_Filteredtext_get, 0);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV22TFBR_Vital_MeasureDate", context.localUtil.Format(AV22TFBR_Vital_MeasureDate, "9999/99/99"));
            AV23TFBR_Vital_MeasureDate_To = context.localUtil.CToD( Ddo_br_vital_measuredate_Filteredtextto_get, 0);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV23TFBR_Vital_MeasureDate_To", context.localUtil.Format(AV23TFBR_Vital_MeasureDate_To, "9999/99/99"));
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV17BR_VitalIDTitleFilterData", AV17BR_VitalIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV21BR_Vital_MeasureDateTitleFilterData", AV21BR_Vital_MeasureDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV27BR_Vital_WeightTitleFilterData", AV27BR_Vital_WeightTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV31BR_Vital_TemperatureTitleFilterData", AV31BR_Vital_TemperatureTitleFilterData);
      }

      protected void E15612( )
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
         else if ( StringUtil.StrCmp(Ddo_br_vital_weight_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV28TFBR_Vital_Weight = NumberUtil.Val( Ddo_br_vital_weight_Filteredtext_get, ".");
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV28TFBR_Vital_Weight", StringUtil.LTrim( StringUtil.Str( AV28TFBR_Vital_Weight, 15, 5)));
            AV29TFBR_Vital_Weight_To = NumberUtil.Val( Ddo_br_vital_weight_Filteredtextto_get, ".");
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV29TFBR_Vital_Weight_To", StringUtil.LTrim( StringUtil.Str( AV29TFBR_Vital_Weight_To, 15, 5)));
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV17BR_VitalIDTitleFilterData", AV17BR_VitalIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV21BR_Vital_MeasureDateTitleFilterData", AV21BR_Vital_MeasureDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV27BR_Vital_WeightTitleFilterData", AV27BR_Vital_WeightTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV31BR_Vital_TemperatureTitleFilterData", AV31BR_Vital_TemperatureTitleFilterData);
      }

      protected void E16612( )
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
            AV32TFBR_Vital_Temperature = NumberUtil.Val( Ddo_br_vital_temperature_Filteredtext_get, ".");
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV32TFBR_Vital_Temperature", StringUtil.LTrim( StringUtil.Str( AV32TFBR_Vital_Temperature, 15, 5)));
            AV33TFBR_Vital_Temperature_To = NumberUtil.Val( Ddo_br_vital_temperature_Filteredtextto_get, ".");
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV33TFBR_Vital_Temperature_To", StringUtil.LTrim( StringUtil.Str( AV33TFBR_Vital_Temperature_To, 15, 5)));
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV17BR_VitalIDTitleFilterData", AV17BR_VitalIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV21BR_Vital_MeasureDateTitleFilterData", AV21BR_Vital_MeasureDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV27BR_Vital_WeightTitleFilterData", AV27BR_Vital_WeightTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV31BR_Vital_TemperatureTitleFilterData", AV31BR_Vital_TemperatureTitleFilterData);
      }

      private void E19612( )
      {
         /* Grid_Load Routine */
         AV57Display = context.GetImagePath( "f11923b6-6acd-4a79-bfc0-0cfc6f3bced5", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, edtavDisplay_Internalname, AV57Display);
         AV64Display_GXI = GXDbFile.PathToUrl( context.GetImagePath( "f11923b6-6acd-4a79-bfc0-0cfc6f3bced5", "", context.GetTheme( )));
         edtavDisplay_Tooltiptext = "显示";
         if ( AV58IsAuthorized_Display )
         {
            edtavDisplay_Link = formatLink("br_vitalview.aspx") + "?" + UrlEncode("" +A150BR_VitalID) + "," + UrlEncode(StringUtil.RTrim(""));
         }
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
         GXt_boolean2 = AV58IsAuthorized_Display;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Vital", out  GXt_boolean2) ;
         AV58IsAuthorized_Display = GXt_boolean2;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV58IsAuthorized_Display", AV58IsAuthorized_Display);
         if ( ! ( AV58IsAuthorized_Display ) )
         {
            edtavDisplay_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDisplay_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDisplay_Visible), 5, 0)), !bGXsfl_12_Refreshing);
         }
      }

      protected void S122( )
      {
         /* 'LOADGRIDSTATE' Routine */
         if ( StringUtil.StrCmp(AV16Session.Get(AV65Pgmname+"GridState"), "") == 0 )
         {
            AV12GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  AV65Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         else
         {
            AV12GridState.FromXml(AV16Session.Get(AV65Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
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
         AV66GXV1 = 1;
         while ( AV66GXV1 <= AV12GridState.gxTpr_Filtervalues.Count )
         {
            AV13GridStateFilterValue = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue)AV12GridState.gxTpr_Filtervalues.Item(AV66GXV1));
            if ( StringUtil.StrCmp(AV13GridStateFilterValue.gxTpr_Name, "TFBR_VITALID") == 0 )
            {
               AV18TFBR_VitalID = (long)(NumberUtil.Val( AV13GridStateFilterValue.gxTpr_Value, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV18TFBR_VitalID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18TFBR_VitalID), 18, 0)));
               AV19TFBR_VitalID_To = (long)(NumberUtil.Val( AV13GridStateFilterValue.gxTpr_Valueto, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV19TFBR_VitalID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV19TFBR_VitalID_To), 18, 0)));
               if ( ! (0==AV18TFBR_VitalID) )
               {
                  Ddo_br_vitalid_Filteredtext_set = StringUtil.Str( (decimal)(AV18TFBR_VitalID), 18, 0);
                  ucDdo_br_vitalid.SendProperty(context, sPrefix, false, Ddo_br_vitalid_Internalname, "FilteredText_set", Ddo_br_vitalid_Filteredtext_set);
               }
               if ( ! (0==AV19TFBR_VitalID_To) )
               {
                  Ddo_br_vitalid_Filteredtextto_set = StringUtil.Str( (decimal)(AV19TFBR_VitalID_To), 18, 0);
                  ucDdo_br_vitalid.SendProperty(context, sPrefix, false, Ddo_br_vitalid_Internalname, "FilteredTextTo_set", Ddo_br_vitalid_Filteredtextto_set);
               }
            }
            else if ( StringUtil.StrCmp(AV13GridStateFilterValue.gxTpr_Name, "TFBR_VITAL_MEASUREDATE") == 0 )
            {
               AV22TFBR_Vital_MeasureDate = context.localUtil.CToD( AV13GridStateFilterValue.gxTpr_Value, 0);
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV22TFBR_Vital_MeasureDate", context.localUtil.Format(AV22TFBR_Vital_MeasureDate, "9999/99/99"));
               AV23TFBR_Vital_MeasureDate_To = context.localUtil.CToD( AV13GridStateFilterValue.gxTpr_Valueto, 0);
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV23TFBR_Vital_MeasureDate_To", context.localUtil.Format(AV23TFBR_Vital_MeasureDate_To, "9999/99/99"));
               if ( ! (DateTime.MinValue==AV22TFBR_Vital_MeasureDate) )
               {
                  Ddo_br_vital_measuredate_Filteredtext_set = context.localUtil.DToC( AV22TFBR_Vital_MeasureDate, 0, "/");
                  ucDdo_br_vital_measuredate.SendProperty(context, sPrefix, false, Ddo_br_vital_measuredate_Internalname, "FilteredText_set", Ddo_br_vital_measuredate_Filteredtext_set);
               }
               if ( ! (DateTime.MinValue==AV23TFBR_Vital_MeasureDate_To) )
               {
                  Ddo_br_vital_measuredate_Filteredtextto_set = context.localUtil.DToC( AV23TFBR_Vital_MeasureDate_To, 0, "/");
                  ucDdo_br_vital_measuredate.SendProperty(context, sPrefix, false, Ddo_br_vital_measuredate_Internalname, "FilteredTextTo_set", Ddo_br_vital_measuredate_Filteredtextto_set);
               }
            }
            else if ( StringUtil.StrCmp(AV13GridStateFilterValue.gxTpr_Name, "TFBR_VITAL_WEIGHT") == 0 )
            {
               AV28TFBR_Vital_Weight = NumberUtil.Val( AV13GridStateFilterValue.gxTpr_Value, ".");
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV28TFBR_Vital_Weight", StringUtil.LTrim( StringUtil.Str( AV28TFBR_Vital_Weight, 15, 5)));
               AV29TFBR_Vital_Weight_To = NumberUtil.Val( AV13GridStateFilterValue.gxTpr_Valueto, ".");
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV29TFBR_Vital_Weight_To", StringUtil.LTrim( StringUtil.Str( AV29TFBR_Vital_Weight_To, 15, 5)));
               if ( ! (Convert.ToDecimal(0)==AV28TFBR_Vital_Weight) )
               {
                  Ddo_br_vital_weight_Filteredtext_set = StringUtil.Str( AV28TFBR_Vital_Weight, 15, 5);
                  ucDdo_br_vital_weight.SendProperty(context, sPrefix, false, Ddo_br_vital_weight_Internalname, "FilteredText_set", Ddo_br_vital_weight_Filteredtext_set);
               }
               if ( ! (Convert.ToDecimal(0)==AV29TFBR_Vital_Weight_To) )
               {
                  Ddo_br_vital_weight_Filteredtextto_set = StringUtil.Str( AV29TFBR_Vital_Weight_To, 15, 5);
                  ucDdo_br_vital_weight.SendProperty(context, sPrefix, false, Ddo_br_vital_weight_Internalname, "FilteredTextTo_set", Ddo_br_vital_weight_Filteredtextto_set);
               }
            }
            else if ( StringUtil.StrCmp(AV13GridStateFilterValue.gxTpr_Name, "TFBR_VITAL_TEMPERATURE") == 0 )
            {
               AV32TFBR_Vital_Temperature = NumberUtil.Val( AV13GridStateFilterValue.gxTpr_Value, ".");
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV32TFBR_Vital_Temperature", StringUtil.LTrim( StringUtil.Str( AV32TFBR_Vital_Temperature, 15, 5)));
               AV33TFBR_Vital_Temperature_To = NumberUtil.Val( AV13GridStateFilterValue.gxTpr_Valueto, ".");
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV33TFBR_Vital_Temperature_To", StringUtil.LTrim( StringUtil.Str( AV33TFBR_Vital_Temperature_To, 15, 5)));
               if ( ! (Convert.ToDecimal(0)==AV32TFBR_Vital_Temperature) )
               {
                  Ddo_br_vital_temperature_Filteredtext_set = StringUtil.Str( AV32TFBR_Vital_Temperature, 15, 5);
                  ucDdo_br_vital_temperature.SendProperty(context, sPrefix, false, Ddo_br_vital_temperature_Internalname, "FilteredText_set", Ddo_br_vital_temperature_Filteredtext_set);
               }
               if ( ! (Convert.ToDecimal(0)==AV33TFBR_Vital_Temperature_To) )
               {
                  Ddo_br_vital_temperature_Filteredtextto_set = StringUtil.Str( AV33TFBR_Vital_Temperature_To, 15, 5);
                  ucDdo_br_vital_temperature.SendProperty(context, sPrefix, false, Ddo_br_vital_temperature_Internalname, "FilteredTextTo_set", Ddo_br_vital_temperature_Filteredtextto_set);
               }
            }
            AV66GXV1 = (int)(AV66GXV1+1);
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
         AV12GridState.FromXml(AV16Session.Get(AV65Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         AV12GridState.gxTpr_Orderedby = AV14OrderedBy;
         AV12GridState.gxTpr_Ordereddsc = AV15OrderedDsc;
         AV12GridState.gxTpr_Filtervalues.Clear();
         if ( ! ( (0==AV18TFBR_VitalID) && (0==AV19TFBR_VitalID_To) ) )
         {
            AV13GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV13GridStateFilterValue.gxTpr_Name = "TFBR_VITALID";
            AV13GridStateFilterValue.gxTpr_Value = StringUtil.Str( (decimal)(AV18TFBR_VitalID), 18, 0);
            AV13GridStateFilterValue.gxTpr_Valueto = StringUtil.Str( (decimal)(AV19TFBR_VitalID_To), 18, 0);
            AV12GridState.gxTpr_Filtervalues.Add(AV13GridStateFilterValue, 0);
         }
         if ( ! ( (DateTime.MinValue==AV22TFBR_Vital_MeasureDate) && (DateTime.MinValue==AV23TFBR_Vital_MeasureDate_To) ) )
         {
            AV13GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV13GridStateFilterValue.gxTpr_Name = "TFBR_VITAL_MEASUREDATE";
            AV13GridStateFilterValue.gxTpr_Value = context.localUtil.DToC( AV22TFBR_Vital_MeasureDate, 0, "/");
            AV13GridStateFilterValue.gxTpr_Valueto = context.localUtil.DToC( AV23TFBR_Vital_MeasureDate_To, 0, "/");
            AV12GridState.gxTpr_Filtervalues.Add(AV13GridStateFilterValue, 0);
         }
         if ( ! ( (Convert.ToDecimal(0)==AV28TFBR_Vital_Weight) && (Convert.ToDecimal(0)==AV29TFBR_Vital_Weight_To) ) )
         {
            AV13GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV13GridStateFilterValue.gxTpr_Name = "TFBR_VITAL_WEIGHT";
            AV13GridStateFilterValue.gxTpr_Value = StringUtil.Str( AV28TFBR_Vital_Weight, 15, 5);
            AV13GridStateFilterValue.gxTpr_Valueto = StringUtil.Str( AV29TFBR_Vital_Weight_To, 15, 5);
            AV12GridState.gxTpr_Filtervalues.Add(AV13GridStateFilterValue, 0);
         }
         if ( ! ( (Convert.ToDecimal(0)==AV32TFBR_Vital_Temperature) && (Convert.ToDecimal(0)==AV33TFBR_Vital_Temperature_To) ) )
         {
            AV13GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV13GridStateFilterValue.gxTpr_Name = "TFBR_VITAL_TEMPERATURE";
            AV13GridStateFilterValue.gxTpr_Value = StringUtil.Str( AV32TFBR_Vital_Temperature, 15, 5);
            AV13GridStateFilterValue.gxTpr_Valueto = StringUtil.Str( AV33TFBR_Vital_Temperature_To, 15, 5);
            AV12GridState.gxTpr_Filtervalues.Add(AV13GridStateFilterValue, 0);
         }
         AV12GridState.gxTpr_Pagesize = StringUtil.Str( (decimal)(subGrid_Rows), 10, 0);
         new GeneXus.Programs.wwpbaseobjects.savegridstate(context ).execute(  AV65Pgmname+"GridState",  AV12GridState.ToXml(false, true, "WWPGridState", "DataAnalysisPlatform")) ;
      }

      protected void S112( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV10TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV10TrnContext.gxTpr_Callerobject = AV65Pgmname;
         AV10TrnContext.gxTpr_Callerondelete = true;
         AV10TrnContext.gxTpr_Callerurl = AV9HTTPRequest.ScriptName+"?"+AV9HTTPRequest.QueryString;
         AV10TrnContext.gxTpr_Transactionname = "BR_Vital";
         AV11TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         AV11TrnContextAtt.gxTpr_Attributename = "BR_EncounterID";
         AV11TrnContextAtt.gxTpr_Attributevalue = StringUtil.Str( (decimal)(AV8BR_EncounterID), 18, 0);
         AV10TrnContext.gxTpr_Attributes.Add(AV11TrnContextAtt, 0);
         AV16Session.Set("TrnContext", AV10TrnContext.ToXml(false, true, "WWPTransactionContext", "DataAnalysisPlatform"));
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
         PA612( ) ;
         WS612( ) ;
         WE612( ) ;
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
         PA612( ) ;
         WCParametersGet( ) ;
      }

      public override void componentprepare( Object[] obj )
      {
         wbLoad = false;
         sCompPrefix = (String)getParm(obj,0);
         sSFPrefix = (String)getParm(obj,1);
         sPrefix = sCompPrefix + sSFPrefix;
         AddComponentObject(sPrefix, "br_encountercheckvitalwc", GetJustCreated( ));
         if ( ( nDoneStart == 0 ) && ( nDynComponent == 0 ) )
         {
            INITWEB( ) ;
         }
         else
         {
            init_default_properties( ) ;
            init_web_controls( ) ;
         }
         PA612( ) ;
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
         PA612( ) ;
         sEvt = sCompEvt;
         WCParametersGet( ) ;
         WS612( ) ;
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
         WS612( ) ;
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
         WE612( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2020228155990", true);
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
         context.AddJavascriptSource("br_encountercheckvitalwc.js", "?2020228155991", false);
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

      protected void SubsflControlProps_122( )
      {
         edtavDisplay_Internalname = sPrefix+"vDISPLAY_"+sGXsfl_12_idx;
         edtBR_VitalID_Internalname = sPrefix+"BR_VITALID_"+sGXsfl_12_idx;
         edtBR_Vital_MeasureDate_Internalname = sPrefix+"BR_VITAL_MEASUREDATE_"+sGXsfl_12_idx;
         edtBR_Vital_Weight_Internalname = sPrefix+"BR_VITAL_WEIGHT_"+sGXsfl_12_idx;
         edtBR_Vital_Temperature_Internalname = sPrefix+"BR_VITAL_TEMPERATURE_"+sGXsfl_12_idx;
      }

      protected void SubsflControlProps_fel_122( )
      {
         edtavDisplay_Internalname = sPrefix+"vDISPLAY_"+sGXsfl_12_fel_idx;
         edtBR_VitalID_Internalname = sPrefix+"BR_VITALID_"+sGXsfl_12_fel_idx;
         edtBR_Vital_MeasureDate_Internalname = sPrefix+"BR_VITAL_MEASUREDATE_"+sGXsfl_12_fel_idx;
         edtBR_Vital_Weight_Internalname = sPrefix+"BR_VITAL_WEIGHT_"+sGXsfl_12_fel_idx;
         edtBR_Vital_Temperature_Internalname = sPrefix+"BR_VITAL_TEMPERATURE_"+sGXsfl_12_fel_idx;
      }

      protected void sendrow_122( )
      {
         SubsflControlProps_122( ) ;
         WB610( ) ;
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
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((edtavDisplay_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "ActionBaseColorAttribute";
            StyleString = "";
            AV57Display_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV57Display))&&String.IsNullOrEmpty(StringUtil.RTrim( AV64Display_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV57Display)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV57Display)) ? AV64Display_GXI : context.PathToRelativeUrl( AV57Display));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavDisplay_Internalname,(String)sImgUrl,(String)edtavDisplay_Link,(String)"",(String)"",context.GetTheme( ),(int)edtavDisplay_Visible,(short)1,(String)"",(String)edtavDisplay_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV57Display_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_VitalID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A150BR_VitalID), 18, 0, ".", "")),context.localUtil.Format( (decimal)(A150BR_VitalID), "ZZZZZZZZZZZZZZZZZZ"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_VitalID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs hidden-sm",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"ID",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Vital_MeasureDate_Internalname,context.localUtil.Format(A152BR_Vital_MeasureDate, "9999/99/99"),context.localUtil.Format( A152BR_Vital_MeasureDate, "9999/99/99"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Vital_MeasureDate_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"DM_Date",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Vital_Weight_Internalname,StringUtil.LTrim( StringUtil.NToC( A159BR_Vital_Weight, 15, 5, ".", "")),context.localUtil.Format( A159BR_Vital_Weight, "ZZZZZZZZZ.ZZZZZ"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Vital_Weight_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs hidden-sm",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)15,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"DM_Numeric",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Vital_Temperature_Internalname,StringUtil.LTrim( StringUtil.NToC( A153BR_Vital_Temperature, 15, 5, ".", "")),context.localUtil.Format( A153BR_Vital_Temperature, "ZZZZZZZZZ.ZZZZZ"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Vital_Temperature_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)15,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"DM_Numeric",(String)"right",(bool)false});
            send_integrity_lvl_hashes612( ) ;
            GridContainer.AddRow(GridRow);
            nGXsfl_12_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_12_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_12_idx+1));
            sGXsfl_12_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_12_idx), 4, 0)), 4, "0");
            SubsflControlProps_122( ) ;
         }
         /* End function sendrow_122 */
      }

      protected void init_web_controls( )
      {
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         edtavDisplay_Internalname = sPrefix+"vDISPLAY";
         edtBR_VitalID_Internalname = sPrefix+"BR_VITALID";
         edtBR_Vital_MeasureDate_Internalname = sPrefix+"BR_VITAL_MEASUREDATE";
         edtBR_Vital_Weight_Internalname = sPrefix+"BR_VITAL_WEIGHT";
         edtBR_Vital_Temperature_Internalname = sPrefix+"BR_VITAL_TEMPERATURE";
         Gridpaginationbar_Internalname = sPrefix+"GRIDPAGINATIONBAR";
         divHtml_gridpaginationbar_Internalname = sPrefix+"HTML_GRIDPAGINATIONBAR";
         divGridtablewithpaginationbar_Internalname = sPrefix+"GRIDTABLEWITHPAGINATIONBAR";
         divUnnamedtable1_Internalname = sPrefix+"UNNAMEDTABLE1";
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
         edtavTfbr_vitalid_Internalname = sPrefix+"vTFBR_VITALID";
         edtavTfbr_vitalid_to_Internalname = sPrefix+"vTFBR_VITALID_TO";
         edtavTfbr_vital_measuredate_Internalname = sPrefix+"vTFBR_VITAL_MEASUREDATE";
         edtavTfbr_vital_measuredate_to_Internalname = sPrefix+"vTFBR_VITAL_MEASUREDATE_TO";
         edtavDdo_br_vital_measuredateauxdate_Internalname = sPrefix+"vDDO_BR_VITAL_MEASUREDATEAUXDATE";
         edtavDdo_br_vital_measuredateauxdateto_Internalname = sPrefix+"vDDO_BR_VITAL_MEASUREDATEAUXDATETO";
         divDdo_br_vital_measuredateauxdates_Internalname = sPrefix+"DDO_BR_VITAL_MEASUREDATEAUXDATES";
         edtavTfbr_vital_weight_Internalname = sPrefix+"vTFBR_VITAL_WEIGHT";
         edtavTfbr_vital_weight_to_Internalname = sPrefix+"vTFBR_VITAL_WEIGHT_TO";
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
         edtavTfbr_vital_temperature_to_Jsonclick = "";
         edtavTfbr_vital_temperature_to_Visible = 1;
         edtavTfbr_vital_temperature_Jsonclick = "";
         edtavTfbr_vital_temperature_Visible = 1;
         edtavTfbr_vital_weight_to_Jsonclick = "";
         edtavTfbr_vital_weight_to_Visible = 1;
         edtavTfbr_vital_weight_Jsonclick = "";
         edtavTfbr_vital_weight_Visible = 1;
         edtavDdo_br_vital_measuredateauxdateto_Jsonclick = "";
         edtavDdo_br_vital_measuredateauxdate_Jsonclick = "";
         edtavTfbr_vital_measuredate_to_Jsonclick = "";
         edtavTfbr_vital_measuredate_to_Visible = 1;
         edtavTfbr_vital_measuredate_Jsonclick = "";
         edtavTfbr_vital_measuredate_Visible = 1;
         edtavTfbr_vitalid_to_Jsonclick = "";
         edtavTfbr_vitalid_to_Visible = 1;
         edtavTfbr_vitalid_Jsonclick = "";
         edtavTfbr_vitalid_Visible = 1;
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
         edtavDisplay_Visible = -1;
         subGrid_Class = "GridWithPaginationBar GridWithBorderColor WorkWith";
         subGrid_Backcolorstyle = 0;
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
         Ddo_br_vital_weight_Rangefilterto = "WWP_TSTo";
         Ddo_br_vital_weight_Rangefilterfrom = "WWP_TSFrom";
         Ddo_br_vital_weight_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_vital_weight_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_vital_weight_Sortasc = "WWP_TSSortASC";
         Ddo_br_vital_weight_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_vital_weight_Filterisrange = Convert.ToBoolean( -1);
         Ddo_br_vital_weight_Filtertype = "Numeric";
         Ddo_br_vital_weight_Includefilter = Convert.ToBoolean( -1);
         Ddo_br_vital_weight_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_vital_weight_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_vital_weight_Titlecontrolidtoreplace = "";
         Ddo_br_vital_weight_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_vital_weight_Cls = "ColumnSettings";
         Ddo_br_vital_weight_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_vital_weight_Caption = "";
         Ddo_br_vital_measuredate_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_vital_measuredate_Rangefilterto = "WWP_TSTo";
         Ddo_br_vital_measuredate_Rangefilterfrom = "WWP_TSFrom";
         Ddo_br_vital_measuredate_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_vital_measuredate_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_vital_measuredate_Sortasc = "WWP_TSSortASC";
         Ddo_br_vital_measuredate_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_vital_measuredate_Filterisrange = Convert.ToBoolean( -1);
         Ddo_br_vital_measuredate_Filtertype = "Date";
         Ddo_br_vital_measuredate_Includefilter = Convert.ToBoolean( -1);
         Ddo_br_vital_measuredate_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_vital_measuredate_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_vital_measuredate_Titlecontrolidtoreplace = "";
         Ddo_br_vital_measuredate_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_vital_measuredate_Cls = "ColumnSettings";
         Ddo_br_vital_measuredate_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_vital_measuredate_Caption = "";
         Ddo_br_vitalid_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_vitalid_Rangefilterto = "WWP_TSTo";
         Ddo_br_vitalid_Rangefilterfrom = "WWP_TSFrom";
         Ddo_br_vitalid_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_vitalid_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_vitalid_Sortasc = "WWP_TSSortASC";
         Ddo_br_vitalid_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_vitalid_Filterisrange = Convert.ToBoolean( -1);
         Ddo_br_vitalid_Filtertype = "Numeric";
         Ddo_br_vitalid_Includefilter = Convert.ToBoolean( -1);
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV58IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'sPrefix'},{av:'AV20ddo_BR_VitalIDTitleControlIdToReplace',fld:'vDDO_BR_VITALIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Vital_MeasureDateTitleControlIdToReplace',fld:'vDDO_BR_VITAL_MEASUREDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_Vital_WeightTitleControlIdToReplace',fld:'vDDO_BR_VITAL_WEIGHTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV34ddo_BR_Vital_TemperatureTitleControlIdToReplace',fld:'vDDO_BR_VITAL_TEMPERATURETITLECONTROLIDTOREPLACE',pic:''},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV65Pgmname',fld:'vPGMNAME',pic:''},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV18TFBR_VitalID',fld:'vTFBR_VITALID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV19TFBR_VitalID_To',fld:'vTFBR_VITALID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_Vital_MeasureDate',fld:'vTFBR_VITAL_MEASUREDATE',pic:''},{av:'AV23TFBR_Vital_MeasureDate_To',fld:'vTFBR_VITAL_MEASUREDATE_TO',pic:''},{av:'AV28TFBR_Vital_Weight',fld:'vTFBR_VITAL_WEIGHT',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV29TFBR_Vital_Weight_To',fld:'vTFBR_VITAL_WEIGHT_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV32TFBR_Vital_Temperature',fld:'vTFBR_VITAL_TEMPERATURE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV33TFBR_Vital_Temperature_To',fld:'vTFBR_VITAL_TEMPERATURE_TO',pic:'ZZZZZZZZZ.ZZZZZ'}]");
         setEventMetadata("REFRESH",",oparms:[{av:'AV17BR_VitalIDTitleFilterData',fld:'vBR_VITALIDTITLEFILTERDATA',pic:''},{av:'AV21BR_Vital_MeasureDateTitleFilterData',fld:'vBR_VITAL_MEASUREDATETITLEFILTERDATA',pic:''},{av:'AV27BR_Vital_WeightTitleFilterData',fld:'vBR_VITAL_WEIGHTTITLEFILTERDATA',pic:''},{av:'AV31BR_Vital_TemperatureTitleFilterData',fld:'vBR_VITAL_TEMPERATURETITLEFILTERDATA',pic:''},{av:'edtBR_VitalID_Titleformat',ctrl:'BR_VITALID',prop:'Titleformat'},{av:'edtBR_VitalID_Title',ctrl:'BR_VITALID',prop:'Title'},{av:'edtBR_Vital_MeasureDate_Titleformat',ctrl:'BR_VITAL_MEASUREDATE',prop:'Titleformat'},{av:'edtBR_Vital_MeasureDate_Title',ctrl:'BR_VITAL_MEASUREDATE',prop:'Title'},{av:'edtBR_Vital_Weight_Titleformat',ctrl:'BR_VITAL_WEIGHT',prop:'Titleformat'},{av:'edtBR_Vital_Weight_Title',ctrl:'BR_VITAL_WEIGHT',prop:'Title'},{av:'edtBR_Vital_Temperature_Titleformat',ctrl:'BR_VITAL_TEMPERATURE',prop:'Titleformat'},{av:'edtBR_Vital_Temperature_Title',ctrl:'BR_VITAL_TEMPERATURE',prop:'Title'},{av:'AV54GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV55GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV56GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV58IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'edtavDisplay_Visible',ctrl:'vDISPLAY',prop:'Visible'}]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE","{handler:'E11612',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV18TFBR_VitalID',fld:'vTFBR_VITALID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV19TFBR_VitalID_To',fld:'vTFBR_VITALID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_Vital_MeasureDate',fld:'vTFBR_VITAL_MEASUREDATE',pic:''},{av:'AV23TFBR_Vital_MeasureDate_To',fld:'vTFBR_VITAL_MEASUREDATE_TO',pic:''},{av:'AV28TFBR_Vital_Weight',fld:'vTFBR_VITAL_WEIGHT',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV29TFBR_Vital_Weight_To',fld:'vTFBR_VITAL_WEIGHT_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV32TFBR_Vital_Temperature',fld:'vTFBR_VITAL_TEMPERATURE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV33TFBR_Vital_Temperature_To',fld:'vTFBR_VITAL_TEMPERATURE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV20ddo_BR_VitalIDTitleControlIdToReplace',fld:'vDDO_BR_VITALIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Vital_MeasureDateTitleControlIdToReplace',fld:'vDDO_BR_VITAL_MEASUREDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_Vital_WeightTitleControlIdToReplace',fld:'vDDO_BR_VITAL_WEIGHTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV34ddo_BR_Vital_TemperatureTitleControlIdToReplace',fld:'vDDO_BR_VITAL_TEMPERATURETITLECONTROLIDTOREPLACE',pic:''},{av:'AV65Pgmname',fld:'vPGMNAME',pic:''},{av:'AV58IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'sPrefix'},{av:'Gridpaginationbar_Selectedpage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE",",oparms:[]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE","{handler:'E12612',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV18TFBR_VitalID',fld:'vTFBR_VITALID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV19TFBR_VitalID_To',fld:'vTFBR_VITALID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_Vital_MeasureDate',fld:'vTFBR_VITAL_MEASUREDATE',pic:''},{av:'AV23TFBR_Vital_MeasureDate_To',fld:'vTFBR_VITAL_MEASUREDATE_TO',pic:''},{av:'AV28TFBR_Vital_Weight',fld:'vTFBR_VITAL_WEIGHT',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV29TFBR_Vital_Weight_To',fld:'vTFBR_VITAL_WEIGHT_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV32TFBR_Vital_Temperature',fld:'vTFBR_VITAL_TEMPERATURE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV33TFBR_Vital_Temperature_To',fld:'vTFBR_VITAL_TEMPERATURE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV20ddo_BR_VitalIDTitleControlIdToReplace',fld:'vDDO_BR_VITALIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Vital_MeasureDateTitleControlIdToReplace',fld:'vDDO_BR_VITAL_MEASUREDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_Vital_WeightTitleControlIdToReplace',fld:'vDDO_BR_VITAL_WEIGHTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV34ddo_BR_Vital_TemperatureTitleControlIdToReplace',fld:'vDDO_BR_VITAL_TEMPERATURETITLECONTROLIDTOREPLACE',pic:''},{av:'AV65Pgmname',fld:'vPGMNAME',pic:''},{av:'AV58IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'sPrefix'},{av:'Gridpaginationbar_Rowsperpageselectedvalue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE",",oparms:[{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]}");
         setEventMetadata("DDO_BR_VITALID.ONOPTIONCLICKED","{handler:'E13612',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV18TFBR_VitalID',fld:'vTFBR_VITALID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV19TFBR_VitalID_To',fld:'vTFBR_VITALID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_Vital_MeasureDate',fld:'vTFBR_VITAL_MEASUREDATE',pic:''},{av:'AV23TFBR_Vital_MeasureDate_To',fld:'vTFBR_VITAL_MEASUREDATE_TO',pic:''},{av:'AV28TFBR_Vital_Weight',fld:'vTFBR_VITAL_WEIGHT',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV29TFBR_Vital_Weight_To',fld:'vTFBR_VITAL_WEIGHT_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV32TFBR_Vital_Temperature',fld:'vTFBR_VITAL_TEMPERATURE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV33TFBR_Vital_Temperature_To',fld:'vTFBR_VITAL_TEMPERATURE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV20ddo_BR_VitalIDTitleControlIdToReplace',fld:'vDDO_BR_VITALIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Vital_MeasureDateTitleControlIdToReplace',fld:'vDDO_BR_VITAL_MEASUREDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_Vital_WeightTitleControlIdToReplace',fld:'vDDO_BR_VITAL_WEIGHTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV34ddo_BR_Vital_TemperatureTitleControlIdToReplace',fld:'vDDO_BR_VITAL_TEMPERATURETITLECONTROLIDTOREPLACE',pic:''},{av:'AV65Pgmname',fld:'vPGMNAME',pic:''},{av:'AV58IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'sPrefix'},{av:'Ddo_br_vitalid_Activeeventkey',ctrl:'DDO_BR_VITALID',prop:'ActiveEventKey'},{av:'Ddo_br_vitalid_Filteredtext_get',ctrl:'DDO_BR_VITALID',prop:'FilteredText_get'},{av:'Ddo_br_vitalid_Filteredtextto_get',ctrl:'DDO_BR_VITALID',prop:'FilteredTextTo_get'}]");
         setEventMetadata("DDO_BR_VITALID.ONOPTIONCLICKED",",oparms:[{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_vitalid_Sortedstatus',ctrl:'DDO_BR_VITALID',prop:'SortedStatus'},{av:'AV18TFBR_VitalID',fld:'vTFBR_VITALID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV19TFBR_VitalID_To',fld:'vTFBR_VITALID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'Ddo_br_vital_measuredate_Sortedstatus',ctrl:'DDO_BR_VITAL_MEASUREDATE',prop:'SortedStatus'},{av:'Ddo_br_vital_weight_Sortedstatus',ctrl:'DDO_BR_VITAL_WEIGHT',prop:'SortedStatus'},{av:'Ddo_br_vital_temperature_Sortedstatus',ctrl:'DDO_BR_VITAL_TEMPERATURE',prop:'SortedStatus'},{av:'AV17BR_VitalIDTitleFilterData',fld:'vBR_VITALIDTITLEFILTERDATA',pic:''},{av:'AV21BR_Vital_MeasureDateTitleFilterData',fld:'vBR_VITAL_MEASUREDATETITLEFILTERDATA',pic:''},{av:'AV27BR_Vital_WeightTitleFilterData',fld:'vBR_VITAL_WEIGHTTITLEFILTERDATA',pic:''},{av:'AV31BR_Vital_TemperatureTitleFilterData',fld:'vBR_VITAL_TEMPERATURETITLEFILTERDATA',pic:''},{av:'edtBR_VitalID_Titleformat',ctrl:'BR_VITALID',prop:'Titleformat'},{av:'edtBR_VitalID_Title',ctrl:'BR_VITALID',prop:'Title'},{av:'edtBR_Vital_MeasureDate_Titleformat',ctrl:'BR_VITAL_MEASUREDATE',prop:'Titleformat'},{av:'edtBR_Vital_MeasureDate_Title',ctrl:'BR_VITAL_MEASUREDATE',prop:'Title'},{av:'edtBR_Vital_Weight_Titleformat',ctrl:'BR_VITAL_WEIGHT',prop:'Titleformat'},{av:'edtBR_Vital_Weight_Title',ctrl:'BR_VITAL_WEIGHT',prop:'Title'},{av:'edtBR_Vital_Temperature_Titleformat',ctrl:'BR_VITAL_TEMPERATURE',prop:'Titleformat'},{av:'edtBR_Vital_Temperature_Title',ctrl:'BR_VITAL_TEMPERATURE',prop:'Title'},{av:'AV54GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV55GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV56GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV58IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'edtavDisplay_Visible',ctrl:'vDISPLAY',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_VITAL_MEASUREDATE.ONOPTIONCLICKED","{handler:'E14612',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV18TFBR_VitalID',fld:'vTFBR_VITALID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV19TFBR_VitalID_To',fld:'vTFBR_VITALID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_Vital_MeasureDate',fld:'vTFBR_VITAL_MEASUREDATE',pic:''},{av:'AV23TFBR_Vital_MeasureDate_To',fld:'vTFBR_VITAL_MEASUREDATE_TO',pic:''},{av:'AV28TFBR_Vital_Weight',fld:'vTFBR_VITAL_WEIGHT',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV29TFBR_Vital_Weight_To',fld:'vTFBR_VITAL_WEIGHT_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV32TFBR_Vital_Temperature',fld:'vTFBR_VITAL_TEMPERATURE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV33TFBR_Vital_Temperature_To',fld:'vTFBR_VITAL_TEMPERATURE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV20ddo_BR_VitalIDTitleControlIdToReplace',fld:'vDDO_BR_VITALIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Vital_MeasureDateTitleControlIdToReplace',fld:'vDDO_BR_VITAL_MEASUREDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_Vital_WeightTitleControlIdToReplace',fld:'vDDO_BR_VITAL_WEIGHTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV34ddo_BR_Vital_TemperatureTitleControlIdToReplace',fld:'vDDO_BR_VITAL_TEMPERATURETITLECONTROLIDTOREPLACE',pic:''},{av:'AV65Pgmname',fld:'vPGMNAME',pic:''},{av:'AV58IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'sPrefix'},{av:'Ddo_br_vital_measuredate_Activeeventkey',ctrl:'DDO_BR_VITAL_MEASUREDATE',prop:'ActiveEventKey'},{av:'Ddo_br_vital_measuredate_Filteredtext_get',ctrl:'DDO_BR_VITAL_MEASUREDATE',prop:'FilteredText_get'},{av:'Ddo_br_vital_measuredate_Filteredtextto_get',ctrl:'DDO_BR_VITAL_MEASUREDATE',prop:'FilteredTextTo_get'}]");
         setEventMetadata("DDO_BR_VITAL_MEASUREDATE.ONOPTIONCLICKED",",oparms:[{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_vital_measuredate_Sortedstatus',ctrl:'DDO_BR_VITAL_MEASUREDATE',prop:'SortedStatus'},{av:'AV22TFBR_Vital_MeasureDate',fld:'vTFBR_VITAL_MEASUREDATE',pic:''},{av:'AV23TFBR_Vital_MeasureDate_To',fld:'vTFBR_VITAL_MEASUREDATE_TO',pic:''},{av:'Ddo_br_vitalid_Sortedstatus',ctrl:'DDO_BR_VITALID',prop:'SortedStatus'},{av:'Ddo_br_vital_weight_Sortedstatus',ctrl:'DDO_BR_VITAL_WEIGHT',prop:'SortedStatus'},{av:'Ddo_br_vital_temperature_Sortedstatus',ctrl:'DDO_BR_VITAL_TEMPERATURE',prop:'SortedStatus'},{av:'AV17BR_VitalIDTitleFilterData',fld:'vBR_VITALIDTITLEFILTERDATA',pic:''},{av:'AV21BR_Vital_MeasureDateTitleFilterData',fld:'vBR_VITAL_MEASUREDATETITLEFILTERDATA',pic:''},{av:'AV27BR_Vital_WeightTitleFilterData',fld:'vBR_VITAL_WEIGHTTITLEFILTERDATA',pic:''},{av:'AV31BR_Vital_TemperatureTitleFilterData',fld:'vBR_VITAL_TEMPERATURETITLEFILTERDATA',pic:''},{av:'edtBR_VitalID_Titleformat',ctrl:'BR_VITALID',prop:'Titleformat'},{av:'edtBR_VitalID_Title',ctrl:'BR_VITALID',prop:'Title'},{av:'edtBR_Vital_MeasureDate_Titleformat',ctrl:'BR_VITAL_MEASUREDATE',prop:'Titleformat'},{av:'edtBR_Vital_MeasureDate_Title',ctrl:'BR_VITAL_MEASUREDATE',prop:'Title'},{av:'edtBR_Vital_Weight_Titleformat',ctrl:'BR_VITAL_WEIGHT',prop:'Titleformat'},{av:'edtBR_Vital_Weight_Title',ctrl:'BR_VITAL_WEIGHT',prop:'Title'},{av:'edtBR_Vital_Temperature_Titleformat',ctrl:'BR_VITAL_TEMPERATURE',prop:'Titleformat'},{av:'edtBR_Vital_Temperature_Title',ctrl:'BR_VITAL_TEMPERATURE',prop:'Title'},{av:'AV54GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV55GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV56GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV58IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'edtavDisplay_Visible',ctrl:'vDISPLAY',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_VITAL_WEIGHT.ONOPTIONCLICKED","{handler:'E15612',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV18TFBR_VitalID',fld:'vTFBR_VITALID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV19TFBR_VitalID_To',fld:'vTFBR_VITALID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_Vital_MeasureDate',fld:'vTFBR_VITAL_MEASUREDATE',pic:''},{av:'AV23TFBR_Vital_MeasureDate_To',fld:'vTFBR_VITAL_MEASUREDATE_TO',pic:''},{av:'AV28TFBR_Vital_Weight',fld:'vTFBR_VITAL_WEIGHT',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV29TFBR_Vital_Weight_To',fld:'vTFBR_VITAL_WEIGHT_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV32TFBR_Vital_Temperature',fld:'vTFBR_VITAL_TEMPERATURE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV33TFBR_Vital_Temperature_To',fld:'vTFBR_VITAL_TEMPERATURE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV20ddo_BR_VitalIDTitleControlIdToReplace',fld:'vDDO_BR_VITALIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Vital_MeasureDateTitleControlIdToReplace',fld:'vDDO_BR_VITAL_MEASUREDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_Vital_WeightTitleControlIdToReplace',fld:'vDDO_BR_VITAL_WEIGHTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV34ddo_BR_Vital_TemperatureTitleControlIdToReplace',fld:'vDDO_BR_VITAL_TEMPERATURETITLECONTROLIDTOREPLACE',pic:''},{av:'AV65Pgmname',fld:'vPGMNAME',pic:''},{av:'AV58IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'sPrefix'},{av:'Ddo_br_vital_weight_Activeeventkey',ctrl:'DDO_BR_VITAL_WEIGHT',prop:'ActiveEventKey'},{av:'Ddo_br_vital_weight_Filteredtext_get',ctrl:'DDO_BR_VITAL_WEIGHT',prop:'FilteredText_get'},{av:'Ddo_br_vital_weight_Filteredtextto_get',ctrl:'DDO_BR_VITAL_WEIGHT',prop:'FilteredTextTo_get'}]");
         setEventMetadata("DDO_BR_VITAL_WEIGHT.ONOPTIONCLICKED",",oparms:[{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_vital_weight_Sortedstatus',ctrl:'DDO_BR_VITAL_WEIGHT',prop:'SortedStatus'},{av:'AV28TFBR_Vital_Weight',fld:'vTFBR_VITAL_WEIGHT',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV29TFBR_Vital_Weight_To',fld:'vTFBR_VITAL_WEIGHT_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'Ddo_br_vitalid_Sortedstatus',ctrl:'DDO_BR_VITALID',prop:'SortedStatus'},{av:'Ddo_br_vital_measuredate_Sortedstatus',ctrl:'DDO_BR_VITAL_MEASUREDATE',prop:'SortedStatus'},{av:'Ddo_br_vital_temperature_Sortedstatus',ctrl:'DDO_BR_VITAL_TEMPERATURE',prop:'SortedStatus'},{av:'AV17BR_VitalIDTitleFilterData',fld:'vBR_VITALIDTITLEFILTERDATA',pic:''},{av:'AV21BR_Vital_MeasureDateTitleFilterData',fld:'vBR_VITAL_MEASUREDATETITLEFILTERDATA',pic:''},{av:'AV27BR_Vital_WeightTitleFilterData',fld:'vBR_VITAL_WEIGHTTITLEFILTERDATA',pic:''},{av:'AV31BR_Vital_TemperatureTitleFilterData',fld:'vBR_VITAL_TEMPERATURETITLEFILTERDATA',pic:''},{av:'edtBR_VitalID_Titleformat',ctrl:'BR_VITALID',prop:'Titleformat'},{av:'edtBR_VitalID_Title',ctrl:'BR_VITALID',prop:'Title'},{av:'edtBR_Vital_MeasureDate_Titleformat',ctrl:'BR_VITAL_MEASUREDATE',prop:'Titleformat'},{av:'edtBR_Vital_MeasureDate_Title',ctrl:'BR_VITAL_MEASUREDATE',prop:'Title'},{av:'edtBR_Vital_Weight_Titleformat',ctrl:'BR_VITAL_WEIGHT',prop:'Titleformat'},{av:'edtBR_Vital_Weight_Title',ctrl:'BR_VITAL_WEIGHT',prop:'Title'},{av:'edtBR_Vital_Temperature_Titleformat',ctrl:'BR_VITAL_TEMPERATURE',prop:'Titleformat'},{av:'edtBR_Vital_Temperature_Title',ctrl:'BR_VITAL_TEMPERATURE',prop:'Title'},{av:'AV54GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV55GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV56GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV58IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'edtavDisplay_Visible',ctrl:'vDISPLAY',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_VITAL_TEMPERATURE.ONOPTIONCLICKED","{handler:'E16612',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV18TFBR_VitalID',fld:'vTFBR_VITALID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV19TFBR_VitalID_To',fld:'vTFBR_VITALID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV22TFBR_Vital_MeasureDate',fld:'vTFBR_VITAL_MEASUREDATE',pic:''},{av:'AV23TFBR_Vital_MeasureDate_To',fld:'vTFBR_VITAL_MEASUREDATE_TO',pic:''},{av:'AV28TFBR_Vital_Weight',fld:'vTFBR_VITAL_WEIGHT',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV29TFBR_Vital_Weight_To',fld:'vTFBR_VITAL_WEIGHT_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV32TFBR_Vital_Temperature',fld:'vTFBR_VITAL_TEMPERATURE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV33TFBR_Vital_Temperature_To',fld:'vTFBR_VITAL_TEMPERATURE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV20ddo_BR_VitalIDTitleControlIdToReplace',fld:'vDDO_BR_VITALIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Vital_MeasureDateTitleControlIdToReplace',fld:'vDDO_BR_VITAL_MEASUREDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV30ddo_BR_Vital_WeightTitleControlIdToReplace',fld:'vDDO_BR_VITAL_WEIGHTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV34ddo_BR_Vital_TemperatureTitleControlIdToReplace',fld:'vDDO_BR_VITAL_TEMPERATURETITLECONTROLIDTOREPLACE',pic:''},{av:'AV65Pgmname',fld:'vPGMNAME',pic:''},{av:'AV58IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'sPrefix'},{av:'Ddo_br_vital_temperature_Activeeventkey',ctrl:'DDO_BR_VITAL_TEMPERATURE',prop:'ActiveEventKey'},{av:'Ddo_br_vital_temperature_Filteredtext_get',ctrl:'DDO_BR_VITAL_TEMPERATURE',prop:'FilteredText_get'},{av:'Ddo_br_vital_temperature_Filteredtextto_get',ctrl:'DDO_BR_VITAL_TEMPERATURE',prop:'FilteredTextTo_get'}]");
         setEventMetadata("DDO_BR_VITAL_TEMPERATURE.ONOPTIONCLICKED",",oparms:[{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_vital_temperature_Sortedstatus',ctrl:'DDO_BR_VITAL_TEMPERATURE',prop:'SortedStatus'},{av:'AV32TFBR_Vital_Temperature',fld:'vTFBR_VITAL_TEMPERATURE',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'AV33TFBR_Vital_Temperature_To',fld:'vTFBR_VITAL_TEMPERATURE_TO',pic:'ZZZZZZZZZ.ZZZZZ'},{av:'Ddo_br_vitalid_Sortedstatus',ctrl:'DDO_BR_VITALID',prop:'SortedStatus'},{av:'Ddo_br_vital_measuredate_Sortedstatus',ctrl:'DDO_BR_VITAL_MEASUREDATE',prop:'SortedStatus'},{av:'Ddo_br_vital_weight_Sortedstatus',ctrl:'DDO_BR_VITAL_WEIGHT',prop:'SortedStatus'},{av:'AV17BR_VitalIDTitleFilterData',fld:'vBR_VITALIDTITLEFILTERDATA',pic:''},{av:'AV21BR_Vital_MeasureDateTitleFilterData',fld:'vBR_VITAL_MEASUREDATETITLEFILTERDATA',pic:''},{av:'AV27BR_Vital_WeightTitleFilterData',fld:'vBR_VITAL_WEIGHTTITLEFILTERDATA',pic:''},{av:'AV31BR_Vital_TemperatureTitleFilterData',fld:'vBR_VITAL_TEMPERATURETITLEFILTERDATA',pic:''},{av:'edtBR_VitalID_Titleformat',ctrl:'BR_VITALID',prop:'Titleformat'},{av:'edtBR_VitalID_Title',ctrl:'BR_VITALID',prop:'Title'},{av:'edtBR_Vital_MeasureDate_Titleformat',ctrl:'BR_VITAL_MEASUREDATE',prop:'Titleformat'},{av:'edtBR_Vital_MeasureDate_Title',ctrl:'BR_VITAL_MEASUREDATE',prop:'Title'},{av:'edtBR_Vital_Weight_Titleformat',ctrl:'BR_VITAL_WEIGHT',prop:'Titleformat'},{av:'edtBR_Vital_Weight_Title',ctrl:'BR_VITAL_WEIGHT',prop:'Title'},{av:'edtBR_Vital_Temperature_Titleformat',ctrl:'BR_VITAL_TEMPERATURE',prop:'Titleformat'},{av:'edtBR_Vital_Temperature_Title',ctrl:'BR_VITAL_TEMPERATURE',prop:'Title'},{av:'AV54GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV55GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV56GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV58IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'edtavDisplay_Visible',ctrl:'vDISPLAY',prop:'Visible'}]}");
         setEventMetadata("GRID.LOAD","{handler:'E19612',iparms:[{av:'AV58IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'A150BR_VitalID',fld:'BR_VITALID',pic:'ZZZZZZZZZZZZZZZZZZ'}]");
         setEventMetadata("GRID.LOAD",",oparms:[{av:'AV57Display',fld:'vDISPLAY',pic:''},{av:'edtavDisplay_Tooltiptext',ctrl:'vDISPLAY',prop:'Tooltiptext'},{av:'edtavDisplay_Link',ctrl:'vDISPLAY',prop:'Link'}]}");
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
         Ddo_br_vitalid_Filteredtext_get = "";
         Ddo_br_vitalid_Filteredtextto_get = "";
         Ddo_br_vital_measuredate_Activeeventkey = "";
         Ddo_br_vital_measuredate_Filteredtext_get = "";
         Ddo_br_vital_measuredate_Filteredtextto_get = "";
         Ddo_br_vital_weight_Activeeventkey = "";
         Ddo_br_vital_weight_Filteredtext_get = "";
         Ddo_br_vital_weight_Filteredtextto_get = "";
         Ddo_br_vital_temperature_Activeeventkey = "";
         Ddo_br_vital_temperature_Filteredtext_get = "";
         Ddo_br_vital_temperature_Filteredtextto_get = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         sPrefix = "";
         AV22TFBR_Vital_MeasureDate = DateTime.MinValue;
         AV23TFBR_Vital_MeasureDate_To = DateTime.MinValue;
         AV20ddo_BR_VitalIDTitleControlIdToReplace = "";
         AV26ddo_BR_Vital_MeasureDateTitleControlIdToReplace = "";
         AV30ddo_BR_Vital_WeightTitleControlIdToReplace = "";
         AV34ddo_BR_Vital_TemperatureTitleControlIdToReplace = "";
         AV65Pgmname = "";
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         AV51DDO_TitleSettingsIcons = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV17BR_VitalIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV21BR_Vital_MeasureDateTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV27BR_Vital_WeightTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV31BR_Vital_TemperatureTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         Ddo_br_vitalid_Filteredtext_set = "";
         Ddo_br_vitalid_Filteredtextto_set = "";
         Ddo_br_vitalid_Sortedstatus = "";
         Ddo_br_vital_measuredate_Filteredtext_set = "";
         Ddo_br_vital_measuredate_Filteredtextto_set = "";
         Ddo_br_vital_measuredate_Sortedstatus = "";
         Ddo_br_vital_weight_Filteredtext_set = "";
         Ddo_br_vital_weight_Filteredtextto_set = "";
         Ddo_br_vital_weight_Sortedstatus = "";
         Ddo_br_vital_temperature_Filteredtext_set = "";
         Ddo_br_vital_temperature_Filteredtextto_set = "";
         Ddo_br_vital_temperature_Sortedstatus = "";
         GX_FocusControl = "";
         GridContainer = new GXWebGrid( context);
         sStyleString = "";
         subGrid_Linesclass = "";
         GridColumn = new GXWebColumn();
         AV57Display = "";
         A152BR_Vital_MeasureDate = DateTime.MinValue;
         ucGridpaginationbar = new GXUserControl();
         ucDdo_br_vitalid = new GXUserControl();
         TempTags = "";
         ClassString = "";
         StyleString = "";
         ucDdo_br_vital_measuredate = new GXUserControl();
         ucDdo_br_vital_weight = new GXUserControl();
         ucDdo_br_vital_temperature = new GXUserControl();
         ucWorkwithplusutilities1 = new GXUserControl();
         AV24DDO_BR_Vital_MeasureDateAuxDate = DateTime.MinValue;
         AV25DDO_BR_Vital_MeasureDateAuxDateTo = DateTime.MinValue;
         Form = new GXWebForm();
         sXEvt = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV64Display_GXI = "";
         scmdbuf = "";
         H00612_A19BR_EncounterID = new long[1] ;
         H00612_A153BR_Vital_Temperature = new decimal[1] ;
         H00612_n153BR_Vital_Temperature = new bool[] {false} ;
         H00612_A159BR_Vital_Weight = new decimal[1] ;
         H00612_n159BR_Vital_Weight = new bool[] {false} ;
         H00612_A152BR_Vital_MeasureDate = new DateTime[] {DateTime.MinValue} ;
         H00612_n152BR_Vital_MeasureDate = new bool[] {false} ;
         H00612_A150BR_VitalID = new long[1] ;
         H00613_AGRID_nRecordCount = new long[1] ;
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
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_encountercheckvitalwc__default(),
            new Object[][] {
                new Object[] {
               H00612_A19BR_EncounterID, H00612_A153BR_Vital_Temperature, H00612_n153BR_Vital_Temperature, H00612_A159BR_Vital_Weight, H00612_n159BR_Vital_Weight, H00612_A152BR_Vital_MeasureDate, H00612_n152BR_Vital_MeasureDate, H00612_A150BR_VitalID
               }
               , new Object[] {
               H00613_AGRID_nRecordCount
               }
            }
         );
         AV65Pgmname = "BR_EncounterCheckVitalWC";
         /* GeneXus formulas. */
         AV65Pgmname = "BR_EncounterCheckVitalWC";
         context.Gx_err = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nDynComponent ;
      private short nRC_GXsfl_12 ;
      private short nGXsfl_12_idx=1 ;
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
      private int subGrid_Titlebackcolor ;
      private int subGrid_Allbackcolor ;
      private int edtavDisplay_Visible ;
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
      private int edtavTfbr_vitalid_Visible ;
      private int edtavTfbr_vitalid_to_Visible ;
      private int edtavTfbr_vital_measuredate_Visible ;
      private int edtavTfbr_vital_measuredate_to_Visible ;
      private int edtavTfbr_vital_weight_Visible ;
      private int edtavTfbr_vital_weight_to_Visible ;
      private int edtavTfbr_vital_temperature_Visible ;
      private int edtavTfbr_vital_temperature_to_Visible ;
      private int subGrid_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int AV53PageToGo ;
      private int AV66GXV1 ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private long AV8BR_EncounterID ;
      private long wcpOAV8BR_EncounterID ;
      private long GRID_nFirstRecordOnPage ;
      private long AV18TFBR_VitalID ;
      private long AV19TFBR_VitalID_To ;
      private long AV54GridCurrentPage ;
      private long AV56GridRecordCount ;
      private long AV55GridPageSize ;
      private long A150BR_VitalID ;
      private long A19BR_EncounterID ;
      private long GRID_nCurrentRecord ;
      private long GRID_nRecordCount ;
      private decimal AV28TFBR_Vital_Weight ;
      private decimal AV29TFBR_Vital_Weight_To ;
      private decimal AV32TFBR_Vital_Temperature ;
      private decimal AV33TFBR_Vital_Temperature_To ;
      private decimal A159BR_Vital_Weight ;
      private decimal A153BR_Vital_Temperature ;
      private String Gridpaginationbar_Selectedpage ;
      private String Ddo_br_vitalid_Activeeventkey ;
      private String Ddo_br_vitalid_Filteredtext_get ;
      private String Ddo_br_vitalid_Filteredtextto_get ;
      private String Ddo_br_vital_measuredate_Activeeventkey ;
      private String Ddo_br_vital_measuredate_Filteredtext_get ;
      private String Ddo_br_vital_measuredate_Filteredtextto_get ;
      private String Ddo_br_vital_weight_Activeeventkey ;
      private String Ddo_br_vital_weight_Filteredtext_get ;
      private String Ddo_br_vital_weight_Filteredtextto_get ;
      private String Ddo_br_vital_temperature_Activeeventkey ;
      private String Ddo_br_vital_temperature_Filteredtext_get ;
      private String Ddo_br_vital_temperature_Filteredtextto_get ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sPrefix ;
      private String sCompPrefix ;
      private String sSFPrefix ;
      private String sGXsfl_12_idx="0001" ;
      private String AV65Pgmname ;
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
      private String Ddo_br_vitalid_Caption ;
      private String Ddo_br_vitalid_Tooltip ;
      private String Ddo_br_vitalid_Cls ;
      private String Ddo_br_vitalid_Filteredtext_set ;
      private String Ddo_br_vitalid_Filteredtextto_set ;
      private String Ddo_br_vitalid_Dropdownoptionstype ;
      private String Ddo_br_vitalid_Titlecontrolidtoreplace ;
      private String Ddo_br_vitalid_Sortedstatus ;
      private String Ddo_br_vitalid_Filtertype ;
      private String Ddo_br_vitalid_Sortasc ;
      private String Ddo_br_vitalid_Sortdsc ;
      private String Ddo_br_vitalid_Cleanfilter ;
      private String Ddo_br_vitalid_Rangefilterfrom ;
      private String Ddo_br_vitalid_Rangefilterto ;
      private String Ddo_br_vitalid_Searchbuttontext ;
      private String Ddo_br_vital_measuredate_Caption ;
      private String Ddo_br_vital_measuredate_Tooltip ;
      private String Ddo_br_vital_measuredate_Cls ;
      private String Ddo_br_vital_measuredate_Filteredtext_set ;
      private String Ddo_br_vital_measuredate_Filteredtextto_set ;
      private String Ddo_br_vital_measuredate_Dropdownoptionstype ;
      private String Ddo_br_vital_measuredate_Titlecontrolidtoreplace ;
      private String Ddo_br_vital_measuredate_Sortedstatus ;
      private String Ddo_br_vital_measuredate_Filtertype ;
      private String Ddo_br_vital_measuredate_Sortasc ;
      private String Ddo_br_vital_measuredate_Sortdsc ;
      private String Ddo_br_vital_measuredate_Cleanfilter ;
      private String Ddo_br_vital_measuredate_Rangefilterfrom ;
      private String Ddo_br_vital_measuredate_Rangefilterto ;
      private String Ddo_br_vital_measuredate_Searchbuttontext ;
      private String Ddo_br_vital_weight_Caption ;
      private String Ddo_br_vital_weight_Tooltip ;
      private String Ddo_br_vital_weight_Cls ;
      private String Ddo_br_vital_weight_Filteredtext_set ;
      private String Ddo_br_vital_weight_Filteredtextto_set ;
      private String Ddo_br_vital_weight_Dropdownoptionstype ;
      private String Ddo_br_vital_weight_Titlecontrolidtoreplace ;
      private String Ddo_br_vital_weight_Sortedstatus ;
      private String Ddo_br_vital_weight_Filtertype ;
      private String Ddo_br_vital_weight_Sortasc ;
      private String Ddo_br_vital_weight_Sortdsc ;
      private String Ddo_br_vital_weight_Cleanfilter ;
      private String Ddo_br_vital_weight_Rangefilterfrom ;
      private String Ddo_br_vital_weight_Rangefilterto ;
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
      private String divUnnamedtable1_Internalname ;
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
      private String divHtml_gridpaginationbar_Internalname ;
      private String Gridpaginationbar_Internalname ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String Ddo_br_vitalid_Internalname ;
      private String TempTags ;
      private String ClassString ;
      private String StyleString ;
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
      private String edtavTfbr_vitalid_Internalname ;
      private String edtavTfbr_vitalid_Jsonclick ;
      private String edtavTfbr_vitalid_to_Internalname ;
      private String edtavTfbr_vitalid_to_Jsonclick ;
      private String edtavTfbr_vital_measuredate_Internalname ;
      private String edtavTfbr_vital_measuredate_Jsonclick ;
      private String edtavTfbr_vital_measuredate_to_Internalname ;
      private String edtavTfbr_vital_measuredate_to_Jsonclick ;
      private String divDdo_br_vital_measuredateauxdates_Internalname ;
      private String edtavDdo_br_vital_measuredateauxdate_Internalname ;
      private String edtavDdo_br_vital_measuredateauxdate_Jsonclick ;
      private String edtavDdo_br_vital_measuredateauxdateto_Internalname ;
      private String edtavDdo_br_vital_measuredateauxdateto_Jsonclick ;
      private String edtavTfbr_vital_weight_Internalname ;
      private String edtavTfbr_vital_weight_Jsonclick ;
      private String edtavTfbr_vital_weight_to_Internalname ;
      private String edtavTfbr_vital_weight_to_Jsonclick ;
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
      private String edtBR_VitalID_Internalname ;
      private String edtBR_Vital_MeasureDate_Internalname ;
      private String edtBR_Vital_Weight_Internalname ;
      private String edtBR_Vital_Temperature_Internalname ;
      private String scmdbuf ;
      private String sCtrlAV8BR_EncounterID ;
      private String sGXsfl_12_fel_idx="0001" ;
      private String sImgUrl ;
      private String ROClassString ;
      private String edtBR_VitalID_Jsonclick ;
      private String edtBR_Vital_MeasureDate_Jsonclick ;
      private String edtBR_Vital_Weight_Jsonclick ;
      private String edtBR_Vital_Temperature_Jsonclick ;
      private DateTime AV22TFBR_Vital_MeasureDate ;
      private DateTime AV23TFBR_Vital_MeasureDate_To ;
      private DateTime A152BR_Vital_MeasureDate ;
      private DateTime AV24DDO_BR_Vital_MeasureDateAuxDate ;
      private DateTime AV25DDO_BR_Vital_MeasureDateAuxDateTo ;
      private bool entryPointCalled ;
      private bool AV15OrderedDsc ;
      private bool AV58IsAuthorized_Display ;
      private bool toggleJsOutput ;
      private bool Gridpaginationbar_Showfirst ;
      private bool Gridpaginationbar_Showprevious ;
      private bool Gridpaginationbar_Shownext ;
      private bool Gridpaginationbar_Showlast ;
      private bool Gridpaginationbar_Rowsperpageselector ;
      private bool Ddo_br_vitalid_Includesortasc ;
      private bool Ddo_br_vitalid_Includesortdsc ;
      private bool Ddo_br_vitalid_Includefilter ;
      private bool Ddo_br_vitalid_Filterisrange ;
      private bool Ddo_br_vitalid_Includedatalist ;
      private bool Ddo_br_vital_measuredate_Includesortasc ;
      private bool Ddo_br_vital_measuredate_Includesortdsc ;
      private bool Ddo_br_vital_measuredate_Includefilter ;
      private bool Ddo_br_vital_measuredate_Filterisrange ;
      private bool Ddo_br_vital_measuredate_Includedatalist ;
      private bool Ddo_br_vital_weight_Includesortasc ;
      private bool Ddo_br_vital_weight_Includesortdsc ;
      private bool Ddo_br_vital_weight_Includefilter ;
      private bool Ddo_br_vital_weight_Filterisrange ;
      private bool Ddo_br_vital_weight_Includedatalist ;
      private bool Ddo_br_vital_temperature_Includesortasc ;
      private bool Ddo_br_vital_temperature_Includesortdsc ;
      private bool Ddo_br_vital_temperature_Includefilter ;
      private bool Ddo_br_vital_temperature_Filterisrange ;
      private bool Ddo_br_vital_temperature_Includedatalist ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_12_Refreshing=false ;
      private bool n152BR_Vital_MeasureDate ;
      private bool n159BR_Vital_Weight ;
      private bool n153BR_Vital_Temperature ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool gx_refresh_fired ;
      private bool GXt_boolean2 ;
      private bool AV57Display_IsBlob ;
      private String AV20ddo_BR_VitalIDTitleControlIdToReplace ;
      private String AV26ddo_BR_Vital_MeasureDateTitleControlIdToReplace ;
      private String AV30ddo_BR_Vital_WeightTitleControlIdToReplace ;
      private String AV34ddo_BR_Vital_TemperatureTitleControlIdToReplace ;
      private String AV64Display_GXI ;
      private String AV57Display ;
      private IGxSession AV16Session ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
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
      private long[] H00612_A19BR_EncounterID ;
      private decimal[] H00612_A153BR_Vital_Temperature ;
      private bool[] H00612_n153BR_Vital_Temperature ;
      private decimal[] H00612_A159BR_Vital_Weight ;
      private bool[] H00612_n159BR_Vital_Weight ;
      private DateTime[] H00612_A152BR_Vital_MeasureDate ;
      private bool[] H00612_n152BR_Vital_MeasureDate ;
      private long[] H00612_A150BR_VitalID ;
      private long[] H00613_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV9HTTPRequest ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV17BR_VitalIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV21BR_Vital_MeasureDateTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV27BR_Vital_WeightTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV31BR_Vital_TemperatureTitleFilterData ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV10TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute AV11TrnContextAtt ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV12GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue AV13GridStateFilterValue ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons AV51DDO_TitleSettingsIcons ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 ;
   }

   public class br_encountercheckvitalwc__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H00612( IGxContext context ,
                                             long AV18TFBR_VitalID ,
                                             long AV19TFBR_VitalID_To ,
                                             DateTime AV22TFBR_Vital_MeasureDate ,
                                             DateTime AV23TFBR_Vital_MeasureDate_To ,
                                             decimal AV28TFBR_Vital_Weight ,
                                             decimal AV29TFBR_Vital_Weight_To ,
                                             decimal AV32TFBR_Vital_Temperature ,
                                             decimal AV33TFBR_Vital_Temperature_To ,
                                             long A150BR_VitalID ,
                                             DateTime A152BR_Vital_MeasureDate ,
                                             decimal A159BR_Vital_Weight ,
                                             decimal A153BR_Vital_Temperature ,
                                             short AV14OrderedBy ,
                                             bool AV15OrderedDsc ,
                                             long A19BR_EncounterID ,
                                             long AV8BR_EncounterID )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int3 ;
         GXv_int3 = new short [12] ;
         Object[] GXv_Object4 ;
         GXv_Object4 = new Object [2] ;
         String sSelectString ;
         String sFromString ;
         String sOrderString ;
         sSelectString = " [BR_EncounterID], [BR_Vital_Temperature], [BR_Vital_Weight], [BR_Vital_MeasureDate], [BR_VitalID]";
         sFromString = " FROM [BR_Vital] WITH (NOLOCK)";
         sOrderString = "";
         sWhereString = sWhereString + " WHERE ([BR_EncounterID] = @AV8BR_EncounterID)";
         if ( ! (0==AV18TFBR_VitalID) )
         {
            sWhereString = sWhereString + " and ([BR_VitalID] >= @AV18TFBR_VitalID)";
         }
         else
         {
            GXv_int3[1] = 1;
         }
         if ( ! (0==AV19TFBR_VitalID_To) )
         {
            sWhereString = sWhereString + " and ([BR_VitalID] <= @AV19TFBR_VitalID_To)";
         }
         else
         {
            GXv_int3[2] = 1;
         }
         if ( ! (DateTime.MinValue==AV22TFBR_Vital_MeasureDate) )
         {
            sWhereString = sWhereString + " and ([BR_Vital_MeasureDate] >= @AV22TFBR_Vital_MeasureDate)";
         }
         else
         {
            GXv_int3[3] = 1;
         }
         if ( ! (DateTime.MinValue==AV23TFBR_Vital_MeasureDate_To) )
         {
            sWhereString = sWhereString + " and ([BR_Vital_MeasureDate] <= @AV23TFBR_Vital_MeasureDate_To)";
         }
         else
         {
            GXv_int3[4] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV28TFBR_Vital_Weight) )
         {
            sWhereString = sWhereString + " and ([BR_Vital_Weight] >= @AV28TFBR_Vital_Weight)";
         }
         else
         {
            GXv_int3[5] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV29TFBR_Vital_Weight_To) )
         {
            sWhereString = sWhereString + " and ([BR_Vital_Weight] <= @AV29TFBR_Vital_Weight_To)";
         }
         else
         {
            GXv_int3[6] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV32TFBR_Vital_Temperature) )
         {
            sWhereString = sWhereString + " and ([BR_Vital_Temperature] >= @AV32TFBR_Vital_Temperature)";
         }
         else
         {
            GXv_int3[7] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV33TFBR_Vital_Temperature_To) )
         {
            sWhereString = sWhereString + " and ([BR_Vital_Temperature] <= @AV33TFBR_Vital_Temperature_To)";
         }
         else
         {
            GXv_int3[8] = 1;
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

      protected Object[] conditional_H00613( IGxContext context ,
                                             long AV18TFBR_VitalID ,
                                             long AV19TFBR_VitalID_To ,
                                             DateTime AV22TFBR_Vital_MeasureDate ,
                                             DateTime AV23TFBR_Vital_MeasureDate_To ,
                                             decimal AV28TFBR_Vital_Weight ,
                                             decimal AV29TFBR_Vital_Weight_To ,
                                             decimal AV32TFBR_Vital_Temperature ,
                                             decimal AV33TFBR_Vital_Temperature_To ,
                                             long A150BR_VitalID ,
                                             DateTime A152BR_Vital_MeasureDate ,
                                             decimal A159BR_Vital_Weight ,
                                             decimal A153BR_Vital_Temperature ,
                                             short AV14OrderedBy ,
                                             bool AV15OrderedDsc ,
                                             long A19BR_EncounterID ,
                                             long AV8BR_EncounterID )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int5 ;
         GXv_int5 = new short [9] ;
         Object[] GXv_Object6 ;
         GXv_Object6 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM [BR_Vital] WITH (NOLOCK)";
         scmdbuf = scmdbuf + " WHERE ([BR_EncounterID] = @AV8BR_EncounterID)";
         if ( ! (0==AV18TFBR_VitalID) )
         {
            sWhereString = sWhereString + " and ([BR_VitalID] >= @AV18TFBR_VitalID)";
         }
         else
         {
            GXv_int5[1] = 1;
         }
         if ( ! (0==AV19TFBR_VitalID_To) )
         {
            sWhereString = sWhereString + " and ([BR_VitalID] <= @AV19TFBR_VitalID_To)";
         }
         else
         {
            GXv_int5[2] = 1;
         }
         if ( ! (DateTime.MinValue==AV22TFBR_Vital_MeasureDate) )
         {
            sWhereString = sWhereString + " and ([BR_Vital_MeasureDate] >= @AV22TFBR_Vital_MeasureDate)";
         }
         else
         {
            GXv_int5[3] = 1;
         }
         if ( ! (DateTime.MinValue==AV23TFBR_Vital_MeasureDate_To) )
         {
            sWhereString = sWhereString + " and ([BR_Vital_MeasureDate] <= @AV23TFBR_Vital_MeasureDate_To)";
         }
         else
         {
            GXv_int5[4] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV28TFBR_Vital_Weight) )
         {
            sWhereString = sWhereString + " and ([BR_Vital_Weight] >= @AV28TFBR_Vital_Weight)";
         }
         else
         {
            GXv_int5[5] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV29TFBR_Vital_Weight_To) )
         {
            sWhereString = sWhereString + " and ([BR_Vital_Weight] <= @AV29TFBR_Vital_Weight_To)";
         }
         else
         {
            GXv_int5[6] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV32TFBR_Vital_Temperature) )
         {
            sWhereString = sWhereString + " and ([BR_Vital_Temperature] >= @AV32TFBR_Vital_Temperature)";
         }
         else
         {
            GXv_int5[7] = 1;
         }
         if ( ! (Convert.ToDecimal(0)==AV33TFBR_Vital_Temperature_To) )
         {
            sWhereString = sWhereString + " and ([BR_Vital_Temperature] <= @AV33TFBR_Vital_Temperature_To)";
         }
         else
         {
            GXv_int5[8] = 1;
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
                     return conditional_H00612(context, (long)dynConstraints[0] , (long)dynConstraints[1] , (DateTime)dynConstraints[2] , (DateTime)dynConstraints[3] , (decimal)dynConstraints[4] , (decimal)dynConstraints[5] , (decimal)dynConstraints[6] , (decimal)dynConstraints[7] , (long)dynConstraints[8] , (DateTime)dynConstraints[9] , (decimal)dynConstraints[10] , (decimal)dynConstraints[11] , (short)dynConstraints[12] , (bool)dynConstraints[13] , (long)dynConstraints[14] , (long)dynConstraints[15] );
               case 1 :
                     return conditional_H00613(context, (long)dynConstraints[0] , (long)dynConstraints[1] , (DateTime)dynConstraints[2] , (DateTime)dynConstraints[3] , (decimal)dynConstraints[4] , (decimal)dynConstraints[5] , (decimal)dynConstraints[6] , (decimal)dynConstraints[7] , (long)dynConstraints[8] , (DateTime)dynConstraints[9] , (decimal)dynConstraints[10] , (decimal)dynConstraints[11] , (short)dynConstraints[12] , (bool)dynConstraints[13] , (long)dynConstraints[14] , (long)dynConstraints[15] );
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
          Object[] prmH00612 ;
          prmH00612 = new Object[] {
          new Object[] {"@AV8BR_EncounterID",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV18TFBR_VitalID",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV19TFBR_VitalID_To",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV22TFBR_Vital_MeasureDate",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV23TFBR_Vital_MeasureDate_To",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV28TFBR_Vital_Weight",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV29TFBR_Vital_Weight_To",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV32TFBR_Vital_Temperature",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV33TFBR_Vital_Temperature_To",SqlDbType.Decimal,15,5} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH00613 ;
          prmH00613 = new Object[] {
          new Object[] {"@AV8BR_EncounterID",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV18TFBR_VitalID",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV19TFBR_VitalID_To",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV22TFBR_Vital_MeasureDate",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV23TFBR_Vital_MeasureDate_To",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV28TFBR_Vital_Weight",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV29TFBR_Vital_Weight_To",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV32TFBR_Vital_Temperature",SqlDbType.Decimal,15,5} ,
          new Object[] {"@AV33TFBR_Vital_Temperature_To",SqlDbType.Decimal,15,5}
          } ;
          def= new CursorDef[] {
              new CursorDef("H00612", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00612,11,0,true,false )
             ,new CursorDef("H00613", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00613,1,0,true,false )
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
                   stmt.SetParameter(sIdx, (long)parms[12]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[13]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[14]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[15]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[16]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[17]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[18]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[19]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[20]);
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
                   stmt.SetParameter(sIdx, (long)parms[9]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[10]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[11]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[12]);
                }
                if ( (short)parms[4] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (DateTime)parms[13]);
                }
                if ( (short)parms[5] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[14]);
                }
                if ( (short)parms[6] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[15]);
                }
                if ( (short)parms[7] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[16]);
                }
                if ( (short)parms[8] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (decimal)parms[17]);
                }
                return;
       }
    }

 }

}
