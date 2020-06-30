/*
               File: BR_EncounterCheckBR_MedicationWC
        Description: Data Mgmt Portal - RAAP
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:34:48.4
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
   public class br_encountercheckbr_medicationwc : GXWebComponent, System.Web.SessionState.IRequiresSessionState
   {
      public br_encountercheckbr_medicationwc( )
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

      public br_encountercheckbr_medicationwc( IGxContext context )
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
         cmbBR_Medication_InpatientChemo = new GXCombobox();
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
                  AV8BR_EncounterID = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  AV18ddo_BR_MedicationIDTitleControlIdToReplace = GetNextPar( );
                  AV22ddo_BR_Medication_RXNameTitleControlIdToReplace = GetNextPar( );
                  AV44ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace = GetNextPar( );
                  AV46ddo_BR_Medication_AdmitEndDateTitleControlIdToReplace = GetNextPar( );
                  AV28ddo_BR_Medication_RXDoseTitleControlIdToReplace = GetNextPar( );
                  AV24ddo_BR_Medication_RXCodeTitleControlIdToReplace = GetNextPar( );
                  AV75Pgmname = GetNextPar( );
                  AV69IsAuthorized_Display = StringUtil.StrToBool( GetNextPar( ));
                  sPrefix = GetNextPar( );
                  init_default_properties( ) ;
                  setAjaxCallMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1;
                     return  ;
                  }
                  gxgrGrid_refresh( subGrid_Rows, AV14OrderedBy, AV15OrderedDsc, AV8BR_EncounterID, AV18ddo_BR_MedicationIDTitleControlIdToReplace, AV22ddo_BR_Medication_RXNameTitleControlIdToReplace, AV44ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace, AV46ddo_BR_Medication_AdmitEndDateTitleControlIdToReplace, AV28ddo_BR_Medication_RXDoseTitleControlIdToReplace, AV24ddo_BR_Medication_RXCodeTitleControlIdToReplace, AV75Pgmname, AV69IsAuthorized_Display, sPrefix) ;
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
            PA422( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV75Pgmname = "BR_EncounterCheckBR_MedicationWC";
               context.Gx_err = 0;
               WS422( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?20202279344832", false);
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
            context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_encountercheckbr_medicationwc.aspx") + "?" + UrlEncode("" +AV8BR_EncounterID)+"\">") ;
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
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, sPrefix+"nRC_GXsfl_12", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_12), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"vGRIDCURRENTPAGE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV60GridCurrentPage), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"vGRIDRECORDCOUNT", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV62GridRecordCount), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"vGRIDPAGESIZE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV61GridPageSize), 10, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, sPrefix+"vDDO_TITLESETTINGSICONS", AV57DDO_TitleSettingsIcons);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(sPrefix+"vDDO_TITLESETTINGSICONS", AV57DDO_TitleSettingsIcons);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, sPrefix+"vBR_MEDICATIONIDTITLEFILTERDATA", AV17BR_MedicationIDTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(sPrefix+"vBR_MEDICATIONIDTITLEFILTERDATA", AV17BR_MedicationIDTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, sPrefix+"vBR_MEDICATION_RXNAMETITLEFILTERDATA", AV21BR_Medication_RXNameTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(sPrefix+"vBR_MEDICATION_RXNAMETITLEFILTERDATA", AV21BR_Medication_RXNameTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, sPrefix+"vBR_MEDICATION_ADMITSTARTDATETITLEFILTERDATA", AV43BR_Medication_AdmitStartDateTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(sPrefix+"vBR_MEDICATION_ADMITSTARTDATETITLEFILTERDATA", AV43BR_Medication_AdmitStartDateTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, sPrefix+"vBR_MEDICATION_ADMITENDDATETITLEFILTERDATA", AV45BR_Medication_AdmitEndDateTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(sPrefix+"vBR_MEDICATION_ADMITENDDATETITLEFILTERDATA", AV45BR_Medication_AdmitEndDateTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, sPrefix+"vBR_MEDICATION_RXDOSETITLEFILTERDATA", AV27BR_Medication_RXDoseTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(sPrefix+"vBR_MEDICATION_RXDOSETITLEFILTERDATA", AV27BR_Medication_RXDoseTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, sPrefix+"vBR_MEDICATION_RXCODETITLEFILTERDATA", AV23BR_Medication_RXCodeTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(sPrefix+"vBR_MEDICATION_RXCODETITLEFILTERDATA", AV23BR_Medication_RXCodeTitleFilterData);
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOAV8BR_EncounterID", StringUtil.LTrim( StringUtil.NToC( (decimal)(wcpOAV8BR_EncounterID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"vPGMNAME", StringUtil.RTrim( AV75Pgmname));
         GxWebStd.gx_boolean_hidden_field( context, sPrefix+"vISAUTHORIZED_DISPLAY", AV69IsAuthorized_Display);
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
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATIONID_Caption", StringUtil.RTrim( Ddo_br_medicationid_Caption));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATIONID_Tooltip", StringUtil.RTrim( Ddo_br_medicationid_Tooltip));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATIONID_Cls", StringUtil.RTrim( Ddo_br_medicationid_Cls));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATIONID_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_medicationid_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATIONID_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_medicationid_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATIONID_Includesortasc", StringUtil.BoolToStr( Ddo_br_medicationid_Includesortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATIONID_Includesortdsc", StringUtil.BoolToStr( Ddo_br_medicationid_Includesortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATIONID_Sortedstatus", StringUtil.RTrim( Ddo_br_medicationid_Sortedstatus));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATIONID_Includefilter", StringUtil.BoolToStr( Ddo_br_medicationid_Includefilter));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATIONID_Includedatalist", StringUtil.BoolToStr( Ddo_br_medicationid_Includedatalist));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATIONID_Sortasc", StringUtil.RTrim( Ddo_br_medicationid_Sortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATIONID_Sortdsc", StringUtil.RTrim( Ddo_br_medicationid_Sortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATIONID_Searchbuttontext", StringUtil.RTrim( Ddo_br_medicationid_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXNAME_Caption", StringUtil.RTrim( Ddo_br_medication_rxname_Caption));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXNAME_Tooltip", StringUtil.RTrim( Ddo_br_medication_rxname_Tooltip));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXNAME_Cls", StringUtil.RTrim( Ddo_br_medication_rxname_Cls));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXNAME_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_medication_rxname_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXNAME_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_medication_rxname_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXNAME_Includesortasc", StringUtil.BoolToStr( Ddo_br_medication_rxname_Includesortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXNAME_Includesortdsc", StringUtil.BoolToStr( Ddo_br_medication_rxname_Includesortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXNAME_Sortedstatus", StringUtil.RTrim( Ddo_br_medication_rxname_Sortedstatus));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXNAME_Includefilter", StringUtil.BoolToStr( Ddo_br_medication_rxname_Includefilter));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXNAME_Includedatalist", StringUtil.BoolToStr( Ddo_br_medication_rxname_Includedatalist));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXNAME_Sortasc", StringUtil.RTrim( Ddo_br_medication_rxname_Sortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXNAME_Sortdsc", StringUtil.RTrim( Ddo_br_medication_rxname_Sortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXNAME_Searchbuttontext", StringUtil.RTrim( Ddo_br_medication_rxname_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_ADMITSTARTDATE_Caption", StringUtil.RTrim( Ddo_br_medication_admitstartdate_Caption));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_ADMITSTARTDATE_Tooltip", StringUtil.RTrim( Ddo_br_medication_admitstartdate_Tooltip));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_ADMITSTARTDATE_Cls", StringUtil.RTrim( Ddo_br_medication_admitstartdate_Cls));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_ADMITSTARTDATE_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_medication_admitstartdate_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_ADMITSTARTDATE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_medication_admitstartdate_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_ADMITSTARTDATE_Includesortasc", StringUtil.BoolToStr( Ddo_br_medication_admitstartdate_Includesortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_ADMITSTARTDATE_Includesortdsc", StringUtil.BoolToStr( Ddo_br_medication_admitstartdate_Includesortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_ADMITSTARTDATE_Sortedstatus", StringUtil.RTrim( Ddo_br_medication_admitstartdate_Sortedstatus));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_ADMITSTARTDATE_Includefilter", StringUtil.BoolToStr( Ddo_br_medication_admitstartdate_Includefilter));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_ADMITSTARTDATE_Includedatalist", StringUtil.BoolToStr( Ddo_br_medication_admitstartdate_Includedatalist));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_ADMITSTARTDATE_Sortasc", StringUtil.RTrim( Ddo_br_medication_admitstartdate_Sortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_ADMITSTARTDATE_Sortdsc", StringUtil.RTrim( Ddo_br_medication_admitstartdate_Sortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_ADMITSTARTDATE_Searchbuttontext", StringUtil.RTrim( Ddo_br_medication_admitstartdate_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_ADMITENDDATE_Caption", StringUtil.RTrim( Ddo_br_medication_admitenddate_Caption));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_ADMITENDDATE_Tooltip", StringUtil.RTrim( Ddo_br_medication_admitenddate_Tooltip));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_ADMITENDDATE_Cls", StringUtil.RTrim( Ddo_br_medication_admitenddate_Cls));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_ADMITENDDATE_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_medication_admitenddate_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_ADMITENDDATE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_medication_admitenddate_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_ADMITENDDATE_Includesortasc", StringUtil.BoolToStr( Ddo_br_medication_admitenddate_Includesortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_ADMITENDDATE_Includesortdsc", StringUtil.BoolToStr( Ddo_br_medication_admitenddate_Includesortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_ADMITENDDATE_Sortedstatus", StringUtil.RTrim( Ddo_br_medication_admitenddate_Sortedstatus));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_ADMITENDDATE_Includefilter", StringUtil.BoolToStr( Ddo_br_medication_admitenddate_Includefilter));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_ADMITENDDATE_Includedatalist", StringUtil.BoolToStr( Ddo_br_medication_admitenddate_Includedatalist));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_ADMITENDDATE_Sortasc", StringUtil.RTrim( Ddo_br_medication_admitenddate_Sortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_ADMITENDDATE_Sortdsc", StringUtil.RTrim( Ddo_br_medication_admitenddate_Sortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_ADMITENDDATE_Searchbuttontext", StringUtil.RTrim( Ddo_br_medication_admitenddate_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXDOSE_Caption", StringUtil.RTrim( Ddo_br_medication_rxdose_Caption));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXDOSE_Tooltip", StringUtil.RTrim( Ddo_br_medication_rxdose_Tooltip));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXDOSE_Cls", StringUtil.RTrim( Ddo_br_medication_rxdose_Cls));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXDOSE_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_medication_rxdose_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXDOSE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_medication_rxdose_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXDOSE_Includesortasc", StringUtil.BoolToStr( Ddo_br_medication_rxdose_Includesortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXDOSE_Includesortdsc", StringUtil.BoolToStr( Ddo_br_medication_rxdose_Includesortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXDOSE_Sortedstatus", StringUtil.RTrim( Ddo_br_medication_rxdose_Sortedstatus));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXDOSE_Includefilter", StringUtil.BoolToStr( Ddo_br_medication_rxdose_Includefilter));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXDOSE_Includedatalist", StringUtil.BoolToStr( Ddo_br_medication_rxdose_Includedatalist));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXDOSE_Sortasc", StringUtil.RTrim( Ddo_br_medication_rxdose_Sortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXDOSE_Sortdsc", StringUtil.RTrim( Ddo_br_medication_rxdose_Sortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXDOSE_Searchbuttontext", StringUtil.RTrim( Ddo_br_medication_rxdose_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXCODE_Caption", StringUtil.RTrim( Ddo_br_medication_rxcode_Caption));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXCODE_Tooltip", StringUtil.RTrim( Ddo_br_medication_rxcode_Tooltip));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXCODE_Cls", StringUtil.RTrim( Ddo_br_medication_rxcode_Cls));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXCODE_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_medication_rxcode_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXCODE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_medication_rxcode_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXCODE_Includesortasc", StringUtil.BoolToStr( Ddo_br_medication_rxcode_Includesortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXCODE_Includesortdsc", StringUtil.BoolToStr( Ddo_br_medication_rxcode_Includesortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXCODE_Sortedstatus", StringUtil.RTrim( Ddo_br_medication_rxcode_Sortedstatus));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXCODE_Includefilter", StringUtil.BoolToStr( Ddo_br_medication_rxcode_Includefilter));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXCODE_Includedatalist", StringUtil.BoolToStr( Ddo_br_medication_rxcode_Includedatalist));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXCODE_Sortasc", StringUtil.RTrim( Ddo_br_medication_rxcode_Sortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXCODE_Sortdsc", StringUtil.RTrim( Ddo_br_medication_rxcode_Sortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXCODE_Searchbuttontext", StringUtil.RTrim( Ddo_br_medication_rxcode_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATIONID_Activeeventkey", StringUtil.RTrim( Ddo_br_medicationid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXNAME_Activeeventkey", StringUtil.RTrim( Ddo_br_medication_rxname_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_ADMITSTARTDATE_Activeeventkey", StringUtil.RTrim( Ddo_br_medication_admitstartdate_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_ADMITENDDATE_Activeeventkey", StringUtil.RTrim( Ddo_br_medication_admitenddate_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXDOSE_Activeeventkey", StringUtil.RTrim( Ddo_br_medication_rxdose_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXCODE_Activeeventkey", StringUtil.RTrim( Ddo_br_medication_rxcode_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATIONID_Activeeventkey", StringUtil.RTrim( Ddo_br_medicationid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXNAME_Activeeventkey", StringUtil.RTrim( Ddo_br_medication_rxname_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_ADMITSTARTDATE_Activeeventkey", StringUtil.RTrim( Ddo_br_medication_admitstartdate_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_ADMITENDDATE_Activeeventkey", StringUtil.RTrim( Ddo_br_medication_admitenddate_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXDOSE_Activeeventkey", StringUtil.RTrim( Ddo_br_medication_rxdose_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_MEDICATION_RXCODE_Activeeventkey", StringUtil.RTrim( Ddo_br_medication_rxcode_Activeeventkey));
      }

      protected void RenderHtmlCloseForm422( )
      {
         SendCloseFormHiddens( ) ;
         if ( ( StringUtil.Len( sPrefix) != 0 ) && ( context.isAjaxRequest( ) || context.isSpaRequest( ) ) )
         {
            context.AddJavascriptSource("br_encountercheckbr_medicationwc.js", "?2020227934524", false);
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
         return "BR_EncounterCheckBR_MedicationWC" ;
      }

      public override String GetPgmdesc( )
      {
         return "Data Mgmt Portal - RAAP" ;
      }

      protected void WB420( )
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
               GxWebStd.gx_hidden_field( context, sPrefix+"_CMPPGM", "br_encountercheckbr_medicationwc.aspx");
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
               if ( edtBR_MedicationID_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_MedicationID_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_MedicationID_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Medication_RXName_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Medication_RXName_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Medication_RXName_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Medication_AdmitStartDate_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Medication_AdmitStartDate_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Medication_AdmitStartDate_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Medication_AdmitEndDate_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Medication_AdmitEndDate_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Medication_AdmitEndDate_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "药物类别") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Medication_RXDose_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Medication_RXDose_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Medication_RXDose_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Medication_RXCode_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Medication_RXCode_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Medication_RXCode_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "计量单位") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "服药频率") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "用药量") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "服药天数") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "给药途径") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "处方日期") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "是否接受住院化疗") ;
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
               GridColumn.AddObjectProperty("Value", context.convertURL( AV67Display));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavDisplay_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavDisplay_Tooltiptext));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavDisplay_Visible), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A119BR_MedicationID), 18, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_MedicationID_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_MedicationID_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A121BR_Medication_RXName);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Medication_RXName_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Medication_RXName_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.localUtil.Format(A132BR_Medication_AdmitStartDate, "9999/99/99"));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Medication_AdmitStartDate_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Medication_AdmitStartDate_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.localUtil.Format(A133BR_Medication_AdmitEndDate, "9999/99/99"));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Medication_AdmitEndDate_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Medication_AdmitEndDate_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A123BR_Medication_RXType);
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A124BR_Medication_RXDose, 15, 5, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Medication_RXDose_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Medication_RXDose_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A122BR_Medication_RXCode);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Medication_RXCode_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Medication_RXCode_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A125BR_Medication_RXUnit);
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A126BR_Medication_RXFrequency);
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A127BR_Medication_RXQuantity);
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A128BR_Medication_RXDaysSupply, 15, 5, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A129BR_Medication_RXRoute);
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.localUtil.Format(A130BR_Medication_PrescriptionDate, "9999/99/99"));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A131BR_Medication_InpatientChemo);
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
            ucGridpaginationbar.SetProperty("CurrentPage", AV60GridCurrentPage);
            ucGridpaginationbar.SetProperty("RecordCount", AV62GridRecordCount);
            ucGridpaginationbar.SetProperty("Page", AV61GridPageSize);
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
            ucDdo_br_medicationid.SetProperty("Caption", Ddo_br_medicationid_Caption);
            ucDdo_br_medicationid.SetProperty("Tooltip", Ddo_br_medicationid_Tooltip);
            ucDdo_br_medicationid.SetProperty("Cls", Ddo_br_medicationid_Cls);
            ucDdo_br_medicationid.SetProperty("DropDownOptionsType", Ddo_br_medicationid_Dropdownoptionstype);
            ucDdo_br_medicationid.SetProperty("IncludeSortASC", Ddo_br_medicationid_Includesortasc);
            ucDdo_br_medicationid.SetProperty("IncludeSortDSC", Ddo_br_medicationid_Includesortdsc);
            ucDdo_br_medicationid.SetProperty("IncludeFilter", Ddo_br_medicationid_Includefilter);
            ucDdo_br_medicationid.SetProperty("IncludeDataList", Ddo_br_medicationid_Includedatalist);
            ucDdo_br_medicationid.SetProperty("SortASC", Ddo_br_medicationid_Sortasc);
            ucDdo_br_medicationid.SetProperty("SortDSC", Ddo_br_medicationid_Sortdsc);
            ucDdo_br_medicationid.SetProperty("SearchButtonText", Ddo_br_medicationid_Searchbuttontext);
            ucDdo_br_medicationid.SetProperty("DropDownOptionsTitleSettingsIcons", AV57DDO_TitleSettingsIcons);
            ucDdo_br_medicationid.SetProperty("DropDownOptionsData", AV17BR_MedicationIDTitleFilterData);
            ucDdo_br_medicationid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_medicationid_Internalname, sPrefix+"DDO_BR_MEDICATIONIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 36,'" + sPrefix + "',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_medicationidtitlecontrolidtoreplace_Internalname, AV18ddo_BR_MedicationIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,36);\"", 0, edtavDdo_br_medicationidtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_EncounterCheckBR_MedicationWC.htm");
            /* User Defined Control */
            ucDdo_br_medication_rxname.SetProperty("Caption", Ddo_br_medication_rxname_Caption);
            ucDdo_br_medication_rxname.SetProperty("Tooltip", Ddo_br_medication_rxname_Tooltip);
            ucDdo_br_medication_rxname.SetProperty("Cls", Ddo_br_medication_rxname_Cls);
            ucDdo_br_medication_rxname.SetProperty("DropDownOptionsType", Ddo_br_medication_rxname_Dropdownoptionstype);
            ucDdo_br_medication_rxname.SetProperty("IncludeSortASC", Ddo_br_medication_rxname_Includesortasc);
            ucDdo_br_medication_rxname.SetProperty("IncludeSortDSC", Ddo_br_medication_rxname_Includesortdsc);
            ucDdo_br_medication_rxname.SetProperty("IncludeFilter", Ddo_br_medication_rxname_Includefilter);
            ucDdo_br_medication_rxname.SetProperty("IncludeDataList", Ddo_br_medication_rxname_Includedatalist);
            ucDdo_br_medication_rxname.SetProperty("SortASC", Ddo_br_medication_rxname_Sortasc);
            ucDdo_br_medication_rxname.SetProperty("SortDSC", Ddo_br_medication_rxname_Sortdsc);
            ucDdo_br_medication_rxname.SetProperty("SearchButtonText", Ddo_br_medication_rxname_Searchbuttontext);
            ucDdo_br_medication_rxname.SetProperty("DropDownOptionsTitleSettingsIcons", AV57DDO_TitleSettingsIcons);
            ucDdo_br_medication_rxname.SetProperty("DropDownOptionsData", AV21BR_Medication_RXNameTitleFilterData);
            ucDdo_br_medication_rxname.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_medication_rxname_Internalname, sPrefix+"DDO_BR_MEDICATION_RXNAMEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'" + sPrefix + "',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_medication_rxnametitlecontrolidtoreplace_Internalname, AV22ddo_BR_Medication_RXNameTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,38);\"", 0, edtavDdo_br_medication_rxnametitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_EncounterCheckBR_MedicationWC.htm");
            /* User Defined Control */
            ucDdo_br_medication_admitstartdate.SetProperty("Caption", Ddo_br_medication_admitstartdate_Caption);
            ucDdo_br_medication_admitstartdate.SetProperty("Tooltip", Ddo_br_medication_admitstartdate_Tooltip);
            ucDdo_br_medication_admitstartdate.SetProperty("Cls", Ddo_br_medication_admitstartdate_Cls);
            ucDdo_br_medication_admitstartdate.SetProperty("DropDownOptionsType", Ddo_br_medication_admitstartdate_Dropdownoptionstype);
            ucDdo_br_medication_admitstartdate.SetProperty("IncludeSortASC", Ddo_br_medication_admitstartdate_Includesortasc);
            ucDdo_br_medication_admitstartdate.SetProperty("IncludeSortDSC", Ddo_br_medication_admitstartdate_Includesortdsc);
            ucDdo_br_medication_admitstartdate.SetProperty("IncludeFilter", Ddo_br_medication_admitstartdate_Includefilter);
            ucDdo_br_medication_admitstartdate.SetProperty("IncludeDataList", Ddo_br_medication_admitstartdate_Includedatalist);
            ucDdo_br_medication_admitstartdate.SetProperty("SortASC", Ddo_br_medication_admitstartdate_Sortasc);
            ucDdo_br_medication_admitstartdate.SetProperty("SortDSC", Ddo_br_medication_admitstartdate_Sortdsc);
            ucDdo_br_medication_admitstartdate.SetProperty("SearchButtonText", Ddo_br_medication_admitstartdate_Searchbuttontext);
            ucDdo_br_medication_admitstartdate.SetProperty("DropDownOptionsTitleSettingsIcons", AV57DDO_TitleSettingsIcons);
            ucDdo_br_medication_admitstartdate.SetProperty("DropDownOptionsData", AV43BR_Medication_AdmitStartDateTitleFilterData);
            ucDdo_br_medication_admitstartdate.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_medication_admitstartdate_Internalname, sPrefix+"DDO_BR_MEDICATION_ADMITSTARTDATEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 40,'" + sPrefix + "',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_medication_admitstartdatetitlecontrolidtoreplace_Internalname, AV44ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,40);\"", 0, edtavDdo_br_medication_admitstartdatetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_EncounterCheckBR_MedicationWC.htm");
            /* User Defined Control */
            ucDdo_br_medication_admitenddate.SetProperty("Caption", Ddo_br_medication_admitenddate_Caption);
            ucDdo_br_medication_admitenddate.SetProperty("Tooltip", Ddo_br_medication_admitenddate_Tooltip);
            ucDdo_br_medication_admitenddate.SetProperty("Cls", Ddo_br_medication_admitenddate_Cls);
            ucDdo_br_medication_admitenddate.SetProperty("DropDownOptionsType", Ddo_br_medication_admitenddate_Dropdownoptionstype);
            ucDdo_br_medication_admitenddate.SetProperty("IncludeSortASC", Ddo_br_medication_admitenddate_Includesortasc);
            ucDdo_br_medication_admitenddate.SetProperty("IncludeSortDSC", Ddo_br_medication_admitenddate_Includesortdsc);
            ucDdo_br_medication_admitenddate.SetProperty("IncludeFilter", Ddo_br_medication_admitenddate_Includefilter);
            ucDdo_br_medication_admitenddate.SetProperty("IncludeDataList", Ddo_br_medication_admitenddate_Includedatalist);
            ucDdo_br_medication_admitenddate.SetProperty("SortASC", Ddo_br_medication_admitenddate_Sortasc);
            ucDdo_br_medication_admitenddate.SetProperty("SortDSC", Ddo_br_medication_admitenddate_Sortdsc);
            ucDdo_br_medication_admitenddate.SetProperty("SearchButtonText", Ddo_br_medication_admitenddate_Searchbuttontext);
            ucDdo_br_medication_admitenddate.SetProperty("DropDownOptionsTitleSettingsIcons", AV57DDO_TitleSettingsIcons);
            ucDdo_br_medication_admitenddate.SetProperty("DropDownOptionsData", AV45BR_Medication_AdmitEndDateTitleFilterData);
            ucDdo_br_medication_admitenddate.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_medication_admitenddate_Internalname, sPrefix+"DDO_BR_MEDICATION_ADMITENDDATEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 42,'" + sPrefix + "',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_medication_admitenddatetitlecontrolidtoreplace_Internalname, AV46ddo_BR_Medication_AdmitEndDateTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,42);\"", 0, edtavDdo_br_medication_admitenddatetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_EncounterCheckBR_MedicationWC.htm");
            /* User Defined Control */
            ucDdo_br_medication_rxdose.SetProperty("Caption", Ddo_br_medication_rxdose_Caption);
            ucDdo_br_medication_rxdose.SetProperty("Tooltip", Ddo_br_medication_rxdose_Tooltip);
            ucDdo_br_medication_rxdose.SetProperty("Cls", Ddo_br_medication_rxdose_Cls);
            ucDdo_br_medication_rxdose.SetProperty("DropDownOptionsType", Ddo_br_medication_rxdose_Dropdownoptionstype);
            ucDdo_br_medication_rxdose.SetProperty("IncludeSortASC", Ddo_br_medication_rxdose_Includesortasc);
            ucDdo_br_medication_rxdose.SetProperty("IncludeSortDSC", Ddo_br_medication_rxdose_Includesortdsc);
            ucDdo_br_medication_rxdose.SetProperty("IncludeFilter", Ddo_br_medication_rxdose_Includefilter);
            ucDdo_br_medication_rxdose.SetProperty("IncludeDataList", Ddo_br_medication_rxdose_Includedatalist);
            ucDdo_br_medication_rxdose.SetProperty("SortASC", Ddo_br_medication_rxdose_Sortasc);
            ucDdo_br_medication_rxdose.SetProperty("SortDSC", Ddo_br_medication_rxdose_Sortdsc);
            ucDdo_br_medication_rxdose.SetProperty("SearchButtonText", Ddo_br_medication_rxdose_Searchbuttontext);
            ucDdo_br_medication_rxdose.SetProperty("DropDownOptionsTitleSettingsIcons", AV57DDO_TitleSettingsIcons);
            ucDdo_br_medication_rxdose.SetProperty("DropDownOptionsData", AV27BR_Medication_RXDoseTitleFilterData);
            ucDdo_br_medication_rxdose.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_medication_rxdose_Internalname, sPrefix+"DDO_BR_MEDICATION_RXDOSEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'" + sPrefix + "',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_medication_rxdosetitlecontrolidtoreplace_Internalname, AV28ddo_BR_Medication_RXDoseTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,44);\"", 0, edtavDdo_br_medication_rxdosetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_EncounterCheckBR_MedicationWC.htm");
            /* User Defined Control */
            ucDdo_br_medication_rxcode.SetProperty("Caption", Ddo_br_medication_rxcode_Caption);
            ucDdo_br_medication_rxcode.SetProperty("Tooltip", Ddo_br_medication_rxcode_Tooltip);
            ucDdo_br_medication_rxcode.SetProperty("Cls", Ddo_br_medication_rxcode_Cls);
            ucDdo_br_medication_rxcode.SetProperty("DropDownOptionsType", Ddo_br_medication_rxcode_Dropdownoptionstype);
            ucDdo_br_medication_rxcode.SetProperty("IncludeSortASC", Ddo_br_medication_rxcode_Includesortasc);
            ucDdo_br_medication_rxcode.SetProperty("IncludeSortDSC", Ddo_br_medication_rxcode_Includesortdsc);
            ucDdo_br_medication_rxcode.SetProperty("IncludeFilter", Ddo_br_medication_rxcode_Includefilter);
            ucDdo_br_medication_rxcode.SetProperty("IncludeDataList", Ddo_br_medication_rxcode_Includedatalist);
            ucDdo_br_medication_rxcode.SetProperty("SortASC", Ddo_br_medication_rxcode_Sortasc);
            ucDdo_br_medication_rxcode.SetProperty("SortDSC", Ddo_br_medication_rxcode_Sortdsc);
            ucDdo_br_medication_rxcode.SetProperty("SearchButtonText", Ddo_br_medication_rxcode_Searchbuttontext);
            ucDdo_br_medication_rxcode.SetProperty("DropDownOptionsTitleSettingsIcons", AV57DDO_TitleSettingsIcons);
            ucDdo_br_medication_rxcode.SetProperty("DropDownOptionsData", AV23BR_Medication_RXCodeTitleFilterData);
            ucDdo_br_medication_rxcode.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_medication_rxcode_Internalname, sPrefix+"DDO_BR_MEDICATION_RXCODEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'" + sPrefix + "',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_medication_rxcodetitlecontrolidtoreplace_Internalname, AV24ddo_BR_Medication_RXCodeTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,46);\"", 0, edtavDdo_br_medication_rxcodetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_EncounterCheckBR_MedicationWC.htm");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_EncounterID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A19BR_EncounterID), 18, 0, ".", "")), context.localUtil.Format( (decimal)(A19BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ"), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_EncounterID_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_EncounterID_Visible, 0, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "HLP_BR_EncounterCheckBR_MedicationWC.htm");
            /* User Defined Control */
            ucWorkwithplusutilities1.Render(context, "dvelop.workwithplusutilities", Workwithplusutilities1_Internalname, sPrefix+"WORKWITHPLUSUTILITIES1Container");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 49,'" + sPrefix + "',false,'" + sGXsfl_12_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrderedby_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV14OrderedBy), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV14OrderedBy), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,49);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrderedby_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrderedby_Visible, 1, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_EncounterCheckBR_MedicationWC.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 50,'" + sPrefix + "',false,'" + sGXsfl_12_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrdereddsc_Internalname, StringUtil.BoolToStr( AV15OrderedDsc), StringUtil.BoolToStr( AV15OrderedDsc), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,50);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrdereddsc_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrdereddsc_Visible, 1, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, 0, 0, true, "", "right", false, "HLP_BR_EncounterCheckBR_MedicationWC.htm");
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

      protected void START422( )
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
               STRUP420( ) ;
            }
         }
      }

      protected void WS422( )
      {
         START422( ) ;
         EVT422( ) ;
      }

      protected void EVT422( )
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
                                 STRUP420( ) ;
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
                                 STRUP420( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    E11422 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEROWSPERPAGE") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP420( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    E12422 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_MEDICATIONID.ONOPTIONCLICKED") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP420( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    E13422 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_MEDICATION_RXNAME.ONOPTIONCLICKED") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP420( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    E14422 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_MEDICATION_ADMITSTARTDATE.ONOPTIONCLICKED") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP420( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    E15422 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_MEDICATION_ADMITENDDATE.ONOPTIONCLICKED") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP420( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    E16422 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_MEDICATION_RXDOSE.ONOPTIONCLICKED") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP420( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    E17422 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_MEDICATION_RXCODE.ONOPTIONCLICKED") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP420( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    E18422 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP420( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    GX_FocusControl = edtavDdo_br_medicationidtitlecontrolidtoreplace_Internalname;
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
                                 STRUP420( ) ;
                              }
                              nGXsfl_12_idx = (short)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_12_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_12_idx), 4, 0)), 4, "0");
                              SubsflControlProps_122( ) ;
                              AV67Display = cgiGet( edtavDisplay_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDisplay_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV67Display)) ? AV74Display_GXI : context.convertURL( context.PathToRelativeUrl( AV67Display))), !bGXsfl_12_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDisplay_Internalname, "SrcSet", context.GetImageSrcSet( AV67Display), true);
                              A119BR_MedicationID = (long)(context.localUtil.CToN( cgiGet( edtBR_MedicationID_Internalname), ".", ","));
                              A121BR_Medication_RXName = cgiGet( edtBR_Medication_RXName_Internalname);
                              n121BR_Medication_RXName = false;
                              A132BR_Medication_AdmitStartDate = DateTimeUtil.ResetTime(context.localUtil.CToT( cgiGet( edtBR_Medication_AdmitStartDate_Internalname), 0));
                              n132BR_Medication_AdmitStartDate = false;
                              A133BR_Medication_AdmitEndDate = DateTimeUtil.ResetTime(context.localUtil.CToT( cgiGet( edtBR_Medication_AdmitEndDate_Internalname), 0));
                              n133BR_Medication_AdmitEndDate = false;
                              A123BR_Medication_RXType = cgiGet( edtBR_Medication_RXType_Internalname);
                              n123BR_Medication_RXType = false;
                              A124BR_Medication_RXDose = context.localUtil.CToN( cgiGet( edtBR_Medication_RXDose_Internalname), ".", ",");
                              n124BR_Medication_RXDose = false;
                              A122BR_Medication_RXCode = cgiGet( edtBR_Medication_RXCode_Internalname);
                              n122BR_Medication_RXCode = false;
                              A125BR_Medication_RXUnit = cgiGet( edtBR_Medication_RXUnit_Internalname);
                              n125BR_Medication_RXUnit = false;
                              A126BR_Medication_RXFrequency = cgiGet( edtBR_Medication_RXFrequency_Internalname);
                              n126BR_Medication_RXFrequency = false;
                              A127BR_Medication_RXQuantity = cgiGet( edtBR_Medication_RXQuantity_Internalname);
                              n127BR_Medication_RXQuantity = false;
                              A128BR_Medication_RXDaysSupply = context.localUtil.CToN( cgiGet( edtBR_Medication_RXDaysSupply_Internalname), ".", ",");
                              n128BR_Medication_RXDaysSupply = false;
                              A129BR_Medication_RXRoute = cgiGet( edtBR_Medication_RXRoute_Internalname);
                              n129BR_Medication_RXRoute = false;
                              A130BR_Medication_PrescriptionDate = DateTimeUtil.ResetTime(context.localUtil.CToT( cgiGet( edtBR_Medication_PrescriptionDate_Internalname), 0));
                              n130BR_Medication_PrescriptionDate = false;
                              cmbBR_Medication_InpatientChemo.Name = cmbBR_Medication_InpatientChemo_Internalname;
                              cmbBR_Medication_InpatientChemo.CurrentValue = cgiGet( cmbBR_Medication_InpatientChemo_Internalname);
                              A131BR_Medication_InpatientChemo = cgiGet( cmbBR_Medication_InpatientChemo_Internalname);
                              n131BR_Medication_InpatientChemo = false;
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
                                          GX_FocusControl = edtavDdo_br_medicationidtitlecontrolidtoreplace_Internalname;
                                          context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
                                          /* Execute user event: Start */
                                          E19422 ();
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
                                          GX_FocusControl = edtavDdo_br_medicationidtitlecontrolidtoreplace_Internalname;
                                          context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
                                          /* Execute user event: Refresh */
                                          E20422 ();
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
                                          GX_FocusControl = edtavDdo_br_medicationidtitlecontrolidtoreplace_Internalname;
                                          context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
                                          E21422 ();
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
                                       STRUP420( ) ;
                                    }
                                    if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1;
                                       if ( ! wbErr )
                                       {
                                          dynload_actions( ) ;
                                          GX_FocusControl = edtavDdo_br_medicationidtitlecontrolidtoreplace_Internalname;
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

      protected void WE422( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm422( ) ;
            }
         }
      }

      protected void PA422( )
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
               GX_FocusControl = edtavDdo_br_medicationidtitlecontrolidtoreplace_Internalname;
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
                                       long AV8BR_EncounterID ,
                                       String AV18ddo_BR_MedicationIDTitleControlIdToReplace ,
                                       String AV22ddo_BR_Medication_RXNameTitleControlIdToReplace ,
                                       String AV44ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace ,
                                       String AV46ddo_BR_Medication_AdmitEndDateTitleControlIdToReplace ,
                                       String AV28ddo_BR_Medication_RXDoseTitleControlIdToReplace ,
                                       String AV24ddo_BR_Medication_RXCodeTitleControlIdToReplace ,
                                       String AV75Pgmname ,
                                       bool AV69IsAuthorized_Display ,
                                       String sPrefix )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GRID_nCurrentRecord = 0;
         RF422( ) ;
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
         RF422( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV75Pgmname = "BR_EncounterCheckBR_MedicationWC";
         context.Gx_err = 0;
      }

      protected void RF422( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridContainer.ClearRows();
         }
         wbStart = 12;
         /* Execute user event: Refresh */
         E20422 ();
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
                                                 AV14OrderedBy ,
                                                 AV15OrderedDsc ,
                                                 A19BR_EncounterID ,
                                                 AV8BR_EncounterID } ,
                                                 new int[]{
                                                 TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.LONG
                                                 }
            } ) ;
            /* Using cursor H00422 */
            pr_default.execute(0, new Object[] {AV8BR_EncounterID, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_12_idx = 1;
            sGXsfl_12_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_12_idx), 4, 0)), 4, "0");
            SubsflControlProps_122( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < subGrid_Recordsperpage( ) ) ) ) )
            {
               A19BR_EncounterID = H00422_A19BR_EncounterID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
               A131BR_Medication_InpatientChemo = H00422_A131BR_Medication_InpatientChemo[0];
               n131BR_Medication_InpatientChemo = H00422_n131BR_Medication_InpatientChemo[0];
               A130BR_Medication_PrescriptionDate = H00422_A130BR_Medication_PrescriptionDate[0];
               n130BR_Medication_PrescriptionDate = H00422_n130BR_Medication_PrescriptionDate[0];
               A129BR_Medication_RXRoute = H00422_A129BR_Medication_RXRoute[0];
               n129BR_Medication_RXRoute = H00422_n129BR_Medication_RXRoute[0];
               A128BR_Medication_RXDaysSupply = H00422_A128BR_Medication_RXDaysSupply[0];
               n128BR_Medication_RXDaysSupply = H00422_n128BR_Medication_RXDaysSupply[0];
               A127BR_Medication_RXQuantity = H00422_A127BR_Medication_RXQuantity[0];
               n127BR_Medication_RXQuantity = H00422_n127BR_Medication_RXQuantity[0];
               A126BR_Medication_RXFrequency = H00422_A126BR_Medication_RXFrequency[0];
               n126BR_Medication_RXFrequency = H00422_n126BR_Medication_RXFrequency[0];
               A125BR_Medication_RXUnit = H00422_A125BR_Medication_RXUnit[0];
               n125BR_Medication_RXUnit = H00422_n125BR_Medication_RXUnit[0];
               A122BR_Medication_RXCode = H00422_A122BR_Medication_RXCode[0];
               n122BR_Medication_RXCode = H00422_n122BR_Medication_RXCode[0];
               A124BR_Medication_RXDose = H00422_A124BR_Medication_RXDose[0];
               n124BR_Medication_RXDose = H00422_n124BR_Medication_RXDose[0];
               A123BR_Medication_RXType = H00422_A123BR_Medication_RXType[0];
               n123BR_Medication_RXType = H00422_n123BR_Medication_RXType[0];
               A133BR_Medication_AdmitEndDate = H00422_A133BR_Medication_AdmitEndDate[0];
               n133BR_Medication_AdmitEndDate = H00422_n133BR_Medication_AdmitEndDate[0];
               A132BR_Medication_AdmitStartDate = H00422_A132BR_Medication_AdmitStartDate[0];
               n132BR_Medication_AdmitStartDate = H00422_n132BR_Medication_AdmitStartDate[0];
               A121BR_Medication_RXName = H00422_A121BR_Medication_RXName[0];
               n121BR_Medication_RXName = H00422_n121BR_Medication_RXName[0];
               A119BR_MedicationID = H00422_A119BR_MedicationID[0];
               E21422 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, sPrefix+"GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 12;
            WB420( ) ;
         }
         bGXsfl_12_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes422( )
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
                                              AV14OrderedBy ,
                                              AV15OrderedDsc ,
                                              A19BR_EncounterID ,
                                              AV8BR_EncounterID } ,
                                              new int[]{
                                              TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.LONG
                                              }
         } ) ;
         /* Using cursor H00423 */
         pr_default.execute(1, new Object[] {AV8BR_EncounterID});
         GRID_nRecordCount = H00423_AGRID_nRecordCount[0];
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
            gxgrGrid_refresh( subGrid_Rows, AV14OrderedBy, AV15OrderedDsc, AV8BR_EncounterID, AV18ddo_BR_MedicationIDTitleControlIdToReplace, AV22ddo_BR_Medication_RXNameTitleControlIdToReplace, AV44ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace, AV46ddo_BR_Medication_AdmitEndDateTitleControlIdToReplace, AV28ddo_BR_Medication_RXDoseTitleControlIdToReplace, AV24ddo_BR_Medication_RXCodeTitleControlIdToReplace, AV75Pgmname, AV69IsAuthorized_Display, sPrefix) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV14OrderedBy, AV15OrderedDsc, AV8BR_EncounterID, AV18ddo_BR_MedicationIDTitleControlIdToReplace, AV22ddo_BR_Medication_RXNameTitleControlIdToReplace, AV44ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace, AV46ddo_BR_Medication_AdmitEndDateTitleControlIdToReplace, AV28ddo_BR_Medication_RXDoseTitleControlIdToReplace, AV24ddo_BR_Medication_RXCodeTitleControlIdToReplace, AV75Pgmname, AV69IsAuthorized_Display, sPrefix) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV14OrderedBy, AV15OrderedDsc, AV8BR_EncounterID, AV18ddo_BR_MedicationIDTitleControlIdToReplace, AV22ddo_BR_Medication_RXNameTitleControlIdToReplace, AV44ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace, AV46ddo_BR_Medication_AdmitEndDateTitleControlIdToReplace, AV28ddo_BR_Medication_RXDoseTitleControlIdToReplace, AV24ddo_BR_Medication_RXCodeTitleControlIdToReplace, AV75Pgmname, AV69IsAuthorized_Display, sPrefix) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV14OrderedBy, AV15OrderedDsc, AV8BR_EncounterID, AV18ddo_BR_MedicationIDTitleControlIdToReplace, AV22ddo_BR_Medication_RXNameTitleControlIdToReplace, AV44ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace, AV46ddo_BR_Medication_AdmitEndDateTitleControlIdToReplace, AV28ddo_BR_Medication_RXDoseTitleControlIdToReplace, AV24ddo_BR_Medication_RXCodeTitleControlIdToReplace, AV75Pgmname, AV69IsAuthorized_Display, sPrefix) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV14OrderedBy, AV15OrderedDsc, AV8BR_EncounterID, AV18ddo_BR_MedicationIDTitleControlIdToReplace, AV22ddo_BR_Medication_RXNameTitleControlIdToReplace, AV44ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace, AV46ddo_BR_Medication_AdmitEndDateTitleControlIdToReplace, AV28ddo_BR_Medication_RXDoseTitleControlIdToReplace, AV24ddo_BR_Medication_RXCodeTitleControlIdToReplace, AV75Pgmname, AV69IsAuthorized_Display, sPrefix) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP420( )
      {
         /* Before Start, stand alone formulas. */
         AV75Pgmname = "BR_EncounterCheckBR_MedicationWC";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E19422 ();
         context.wbGlbDoneStart = 1;
         nDoneStart = 1;
         /* After Start, stand alone formulas. */
         sXEvt = cgiGet( "_EventName");
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( sPrefix+"vDDO_TITLESETTINGSICONS"), AV57DDO_TitleSettingsIcons);
            ajax_req_read_hidden_sdt(cgiGet( sPrefix+"vBR_MEDICATIONIDTITLEFILTERDATA"), AV17BR_MedicationIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( sPrefix+"vBR_MEDICATION_RXNAMETITLEFILTERDATA"), AV21BR_Medication_RXNameTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( sPrefix+"vBR_MEDICATION_ADMITSTARTDATETITLEFILTERDATA"), AV43BR_Medication_AdmitStartDateTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( sPrefix+"vBR_MEDICATION_ADMITENDDATETITLEFILTERDATA"), AV45BR_Medication_AdmitEndDateTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( sPrefix+"vBR_MEDICATION_RXDOSETITLEFILTERDATA"), AV27BR_Medication_RXDoseTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( sPrefix+"vBR_MEDICATION_RXCODETITLEFILTERDATA"), AV23BR_Medication_RXCodeTitleFilterData);
            /* Read variables values. */
            AV18ddo_BR_MedicationIDTitleControlIdToReplace = cgiGet( edtavDdo_br_medicationidtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV18ddo_BR_MedicationIDTitleControlIdToReplace", AV18ddo_BR_MedicationIDTitleControlIdToReplace);
            AV22ddo_BR_Medication_RXNameTitleControlIdToReplace = cgiGet( edtavDdo_br_medication_rxnametitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV22ddo_BR_Medication_RXNameTitleControlIdToReplace", AV22ddo_BR_Medication_RXNameTitleControlIdToReplace);
            AV44ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace = cgiGet( edtavDdo_br_medication_admitstartdatetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV44ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace", AV44ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace);
            AV46ddo_BR_Medication_AdmitEndDateTitleControlIdToReplace = cgiGet( edtavDdo_br_medication_admitenddatetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV46ddo_BR_Medication_AdmitEndDateTitleControlIdToReplace", AV46ddo_BR_Medication_AdmitEndDateTitleControlIdToReplace);
            AV28ddo_BR_Medication_RXDoseTitleControlIdToReplace = cgiGet( edtavDdo_br_medication_rxdosetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV28ddo_BR_Medication_RXDoseTitleControlIdToReplace", AV28ddo_BR_Medication_RXDoseTitleControlIdToReplace);
            AV24ddo_BR_Medication_RXCodeTitleControlIdToReplace = cgiGet( edtavDdo_br_medication_rxcodetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV24ddo_BR_Medication_RXCodeTitleControlIdToReplace", AV24ddo_BR_Medication_RXCodeTitleControlIdToReplace);
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
            /* Read saved values. */
            nRC_GXsfl_12 = (short)(context.localUtil.CToN( cgiGet( sPrefix+"nRC_GXsfl_12"), ".", ","));
            AV60GridCurrentPage = (long)(context.localUtil.CToN( cgiGet( sPrefix+"vGRIDCURRENTPAGE"), ".", ","));
            AV62GridRecordCount = (long)(context.localUtil.CToN( cgiGet( sPrefix+"vGRIDRECORDCOUNT"), ".", ","));
            AV61GridPageSize = (long)(context.localUtil.CToN( cgiGet( sPrefix+"vGRIDPAGESIZE"), ".", ","));
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
            Ddo_br_medicationid_Caption = cgiGet( sPrefix+"DDO_BR_MEDICATIONID_Caption");
            Ddo_br_medicationid_Tooltip = cgiGet( sPrefix+"DDO_BR_MEDICATIONID_Tooltip");
            Ddo_br_medicationid_Cls = cgiGet( sPrefix+"DDO_BR_MEDICATIONID_Cls");
            Ddo_br_medicationid_Dropdownoptionstype = cgiGet( sPrefix+"DDO_BR_MEDICATIONID_Dropdownoptionstype");
            Ddo_br_medicationid_Titlecontrolidtoreplace = cgiGet( sPrefix+"DDO_BR_MEDICATIONID_Titlecontrolidtoreplace");
            Ddo_br_medicationid_Includesortasc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_MEDICATIONID_Includesortasc"));
            Ddo_br_medicationid_Includesortdsc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_MEDICATIONID_Includesortdsc"));
            Ddo_br_medicationid_Sortedstatus = cgiGet( sPrefix+"DDO_BR_MEDICATIONID_Sortedstatus");
            Ddo_br_medicationid_Includefilter = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_MEDICATIONID_Includefilter"));
            Ddo_br_medicationid_Includedatalist = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_MEDICATIONID_Includedatalist"));
            Ddo_br_medicationid_Sortasc = cgiGet( sPrefix+"DDO_BR_MEDICATIONID_Sortasc");
            Ddo_br_medicationid_Sortdsc = cgiGet( sPrefix+"DDO_BR_MEDICATIONID_Sortdsc");
            Ddo_br_medicationid_Searchbuttontext = cgiGet( sPrefix+"DDO_BR_MEDICATIONID_Searchbuttontext");
            Ddo_br_medication_rxname_Caption = cgiGet( sPrefix+"DDO_BR_MEDICATION_RXNAME_Caption");
            Ddo_br_medication_rxname_Tooltip = cgiGet( sPrefix+"DDO_BR_MEDICATION_RXNAME_Tooltip");
            Ddo_br_medication_rxname_Cls = cgiGet( sPrefix+"DDO_BR_MEDICATION_RXNAME_Cls");
            Ddo_br_medication_rxname_Dropdownoptionstype = cgiGet( sPrefix+"DDO_BR_MEDICATION_RXNAME_Dropdownoptionstype");
            Ddo_br_medication_rxname_Titlecontrolidtoreplace = cgiGet( sPrefix+"DDO_BR_MEDICATION_RXNAME_Titlecontrolidtoreplace");
            Ddo_br_medication_rxname_Includesortasc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_MEDICATION_RXNAME_Includesortasc"));
            Ddo_br_medication_rxname_Includesortdsc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_MEDICATION_RXNAME_Includesortdsc"));
            Ddo_br_medication_rxname_Sortedstatus = cgiGet( sPrefix+"DDO_BR_MEDICATION_RXNAME_Sortedstatus");
            Ddo_br_medication_rxname_Includefilter = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_MEDICATION_RXNAME_Includefilter"));
            Ddo_br_medication_rxname_Includedatalist = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_MEDICATION_RXNAME_Includedatalist"));
            Ddo_br_medication_rxname_Sortasc = cgiGet( sPrefix+"DDO_BR_MEDICATION_RXNAME_Sortasc");
            Ddo_br_medication_rxname_Sortdsc = cgiGet( sPrefix+"DDO_BR_MEDICATION_RXNAME_Sortdsc");
            Ddo_br_medication_rxname_Searchbuttontext = cgiGet( sPrefix+"DDO_BR_MEDICATION_RXNAME_Searchbuttontext");
            Ddo_br_medication_admitstartdate_Caption = cgiGet( sPrefix+"DDO_BR_MEDICATION_ADMITSTARTDATE_Caption");
            Ddo_br_medication_admitstartdate_Tooltip = cgiGet( sPrefix+"DDO_BR_MEDICATION_ADMITSTARTDATE_Tooltip");
            Ddo_br_medication_admitstartdate_Cls = cgiGet( sPrefix+"DDO_BR_MEDICATION_ADMITSTARTDATE_Cls");
            Ddo_br_medication_admitstartdate_Dropdownoptionstype = cgiGet( sPrefix+"DDO_BR_MEDICATION_ADMITSTARTDATE_Dropdownoptionstype");
            Ddo_br_medication_admitstartdate_Titlecontrolidtoreplace = cgiGet( sPrefix+"DDO_BR_MEDICATION_ADMITSTARTDATE_Titlecontrolidtoreplace");
            Ddo_br_medication_admitstartdate_Includesortasc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_MEDICATION_ADMITSTARTDATE_Includesortasc"));
            Ddo_br_medication_admitstartdate_Includesortdsc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_MEDICATION_ADMITSTARTDATE_Includesortdsc"));
            Ddo_br_medication_admitstartdate_Sortedstatus = cgiGet( sPrefix+"DDO_BR_MEDICATION_ADMITSTARTDATE_Sortedstatus");
            Ddo_br_medication_admitstartdate_Includefilter = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_MEDICATION_ADMITSTARTDATE_Includefilter"));
            Ddo_br_medication_admitstartdate_Includedatalist = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_MEDICATION_ADMITSTARTDATE_Includedatalist"));
            Ddo_br_medication_admitstartdate_Sortasc = cgiGet( sPrefix+"DDO_BR_MEDICATION_ADMITSTARTDATE_Sortasc");
            Ddo_br_medication_admitstartdate_Sortdsc = cgiGet( sPrefix+"DDO_BR_MEDICATION_ADMITSTARTDATE_Sortdsc");
            Ddo_br_medication_admitstartdate_Searchbuttontext = cgiGet( sPrefix+"DDO_BR_MEDICATION_ADMITSTARTDATE_Searchbuttontext");
            Ddo_br_medication_admitenddate_Caption = cgiGet( sPrefix+"DDO_BR_MEDICATION_ADMITENDDATE_Caption");
            Ddo_br_medication_admitenddate_Tooltip = cgiGet( sPrefix+"DDO_BR_MEDICATION_ADMITENDDATE_Tooltip");
            Ddo_br_medication_admitenddate_Cls = cgiGet( sPrefix+"DDO_BR_MEDICATION_ADMITENDDATE_Cls");
            Ddo_br_medication_admitenddate_Dropdownoptionstype = cgiGet( sPrefix+"DDO_BR_MEDICATION_ADMITENDDATE_Dropdownoptionstype");
            Ddo_br_medication_admitenddate_Titlecontrolidtoreplace = cgiGet( sPrefix+"DDO_BR_MEDICATION_ADMITENDDATE_Titlecontrolidtoreplace");
            Ddo_br_medication_admitenddate_Includesortasc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_MEDICATION_ADMITENDDATE_Includesortasc"));
            Ddo_br_medication_admitenddate_Includesortdsc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_MEDICATION_ADMITENDDATE_Includesortdsc"));
            Ddo_br_medication_admitenddate_Sortedstatus = cgiGet( sPrefix+"DDO_BR_MEDICATION_ADMITENDDATE_Sortedstatus");
            Ddo_br_medication_admitenddate_Includefilter = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_MEDICATION_ADMITENDDATE_Includefilter"));
            Ddo_br_medication_admitenddate_Includedatalist = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_MEDICATION_ADMITENDDATE_Includedatalist"));
            Ddo_br_medication_admitenddate_Sortasc = cgiGet( sPrefix+"DDO_BR_MEDICATION_ADMITENDDATE_Sortasc");
            Ddo_br_medication_admitenddate_Sortdsc = cgiGet( sPrefix+"DDO_BR_MEDICATION_ADMITENDDATE_Sortdsc");
            Ddo_br_medication_admitenddate_Searchbuttontext = cgiGet( sPrefix+"DDO_BR_MEDICATION_ADMITENDDATE_Searchbuttontext");
            Ddo_br_medication_rxdose_Caption = cgiGet( sPrefix+"DDO_BR_MEDICATION_RXDOSE_Caption");
            Ddo_br_medication_rxdose_Tooltip = cgiGet( sPrefix+"DDO_BR_MEDICATION_RXDOSE_Tooltip");
            Ddo_br_medication_rxdose_Cls = cgiGet( sPrefix+"DDO_BR_MEDICATION_RXDOSE_Cls");
            Ddo_br_medication_rxdose_Dropdownoptionstype = cgiGet( sPrefix+"DDO_BR_MEDICATION_RXDOSE_Dropdownoptionstype");
            Ddo_br_medication_rxdose_Titlecontrolidtoreplace = cgiGet( sPrefix+"DDO_BR_MEDICATION_RXDOSE_Titlecontrolidtoreplace");
            Ddo_br_medication_rxdose_Includesortasc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_MEDICATION_RXDOSE_Includesortasc"));
            Ddo_br_medication_rxdose_Includesortdsc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_MEDICATION_RXDOSE_Includesortdsc"));
            Ddo_br_medication_rxdose_Sortedstatus = cgiGet( sPrefix+"DDO_BR_MEDICATION_RXDOSE_Sortedstatus");
            Ddo_br_medication_rxdose_Includefilter = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_MEDICATION_RXDOSE_Includefilter"));
            Ddo_br_medication_rxdose_Includedatalist = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_MEDICATION_RXDOSE_Includedatalist"));
            Ddo_br_medication_rxdose_Sortasc = cgiGet( sPrefix+"DDO_BR_MEDICATION_RXDOSE_Sortasc");
            Ddo_br_medication_rxdose_Sortdsc = cgiGet( sPrefix+"DDO_BR_MEDICATION_RXDOSE_Sortdsc");
            Ddo_br_medication_rxdose_Searchbuttontext = cgiGet( sPrefix+"DDO_BR_MEDICATION_RXDOSE_Searchbuttontext");
            Ddo_br_medication_rxcode_Caption = cgiGet( sPrefix+"DDO_BR_MEDICATION_RXCODE_Caption");
            Ddo_br_medication_rxcode_Tooltip = cgiGet( sPrefix+"DDO_BR_MEDICATION_RXCODE_Tooltip");
            Ddo_br_medication_rxcode_Cls = cgiGet( sPrefix+"DDO_BR_MEDICATION_RXCODE_Cls");
            Ddo_br_medication_rxcode_Dropdownoptionstype = cgiGet( sPrefix+"DDO_BR_MEDICATION_RXCODE_Dropdownoptionstype");
            Ddo_br_medication_rxcode_Titlecontrolidtoreplace = cgiGet( sPrefix+"DDO_BR_MEDICATION_RXCODE_Titlecontrolidtoreplace");
            Ddo_br_medication_rxcode_Includesortasc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_MEDICATION_RXCODE_Includesortasc"));
            Ddo_br_medication_rxcode_Includesortdsc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_MEDICATION_RXCODE_Includesortdsc"));
            Ddo_br_medication_rxcode_Sortedstatus = cgiGet( sPrefix+"DDO_BR_MEDICATION_RXCODE_Sortedstatus");
            Ddo_br_medication_rxcode_Includefilter = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_MEDICATION_RXCODE_Includefilter"));
            Ddo_br_medication_rxcode_Includedatalist = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_MEDICATION_RXCODE_Includedatalist"));
            Ddo_br_medication_rxcode_Sortasc = cgiGet( sPrefix+"DDO_BR_MEDICATION_RXCODE_Sortasc");
            Ddo_br_medication_rxcode_Sortdsc = cgiGet( sPrefix+"DDO_BR_MEDICATION_RXCODE_Sortdsc");
            Ddo_br_medication_rxcode_Searchbuttontext = cgiGet( sPrefix+"DDO_BR_MEDICATION_RXCODE_Searchbuttontext");
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( sPrefix+"GRID_Rows"), ".", ","));
            GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            Gridpaginationbar_Selectedpage = cgiGet( sPrefix+"GRIDPAGINATIONBAR_Selectedpage");
            Gridpaginationbar_Rowsperpageselectedvalue = (int)(context.localUtil.CToN( cgiGet( sPrefix+"GRIDPAGINATIONBAR_Rowsperpageselectedvalue"), ".", ","));
            Ddo_br_medicationid_Activeeventkey = cgiGet( sPrefix+"DDO_BR_MEDICATIONID_Activeeventkey");
            Ddo_br_medication_rxname_Activeeventkey = cgiGet( sPrefix+"DDO_BR_MEDICATION_RXNAME_Activeeventkey");
            Ddo_br_medication_admitstartdate_Activeeventkey = cgiGet( sPrefix+"DDO_BR_MEDICATION_ADMITSTARTDATE_Activeeventkey");
            Ddo_br_medication_admitenddate_Activeeventkey = cgiGet( sPrefix+"DDO_BR_MEDICATION_ADMITENDDATE_Activeeventkey");
            Ddo_br_medication_rxdose_Activeeventkey = cgiGet( sPrefix+"DDO_BR_MEDICATION_RXDOSE_Activeeventkey");
            Ddo_br_medication_rxcode_Activeeventkey = cgiGet( sPrefix+"DDO_BR_MEDICATION_RXCODE_Activeeventkey");
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
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      protected void GXStart( )
      {
         /* Execute user event: Start */
         E19422 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E19422( )
      {
         /* Start Routine */
         subGrid_Rows = 9;
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         Ddo_br_medicationid_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_MedicationID";
         ucDdo_br_medicationid.SendProperty(context, sPrefix, false, Ddo_br_medicationid_Internalname, "TitleControlIdToReplace", Ddo_br_medicationid_Titlecontrolidtoreplace);
         AV18ddo_BR_MedicationIDTitleControlIdToReplace = Ddo_br_medicationid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV18ddo_BR_MedicationIDTitleControlIdToReplace", AV18ddo_BR_MedicationIDTitleControlIdToReplace);
         edtavDdo_br_medicationidtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDdo_br_medicationidtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_medicationidtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_medication_rxname_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Medication_RXName";
         ucDdo_br_medication_rxname.SendProperty(context, sPrefix, false, Ddo_br_medication_rxname_Internalname, "TitleControlIdToReplace", Ddo_br_medication_rxname_Titlecontrolidtoreplace);
         AV22ddo_BR_Medication_RXNameTitleControlIdToReplace = Ddo_br_medication_rxname_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV22ddo_BR_Medication_RXNameTitleControlIdToReplace", AV22ddo_BR_Medication_RXNameTitleControlIdToReplace);
         edtavDdo_br_medication_rxnametitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDdo_br_medication_rxnametitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_medication_rxnametitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_medication_admitstartdate_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Medication_AdmitStartDate";
         ucDdo_br_medication_admitstartdate.SendProperty(context, sPrefix, false, Ddo_br_medication_admitstartdate_Internalname, "TitleControlIdToReplace", Ddo_br_medication_admitstartdate_Titlecontrolidtoreplace);
         AV44ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace = Ddo_br_medication_admitstartdate_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV44ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace", AV44ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace);
         edtavDdo_br_medication_admitstartdatetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDdo_br_medication_admitstartdatetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_medication_admitstartdatetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_medication_admitenddate_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Medication_AdmitEndDate";
         ucDdo_br_medication_admitenddate.SendProperty(context, sPrefix, false, Ddo_br_medication_admitenddate_Internalname, "TitleControlIdToReplace", Ddo_br_medication_admitenddate_Titlecontrolidtoreplace);
         AV46ddo_BR_Medication_AdmitEndDateTitleControlIdToReplace = Ddo_br_medication_admitenddate_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV46ddo_BR_Medication_AdmitEndDateTitleControlIdToReplace", AV46ddo_BR_Medication_AdmitEndDateTitleControlIdToReplace);
         edtavDdo_br_medication_admitenddatetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDdo_br_medication_admitenddatetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_medication_admitenddatetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_medication_rxdose_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Medication_RXDose";
         ucDdo_br_medication_rxdose.SendProperty(context, sPrefix, false, Ddo_br_medication_rxdose_Internalname, "TitleControlIdToReplace", Ddo_br_medication_rxdose_Titlecontrolidtoreplace);
         AV28ddo_BR_Medication_RXDoseTitleControlIdToReplace = Ddo_br_medication_rxdose_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV28ddo_BR_Medication_RXDoseTitleControlIdToReplace", AV28ddo_BR_Medication_RXDoseTitleControlIdToReplace);
         edtavDdo_br_medication_rxdosetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDdo_br_medication_rxdosetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_medication_rxdosetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_medication_rxcode_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Medication_RXCode";
         ucDdo_br_medication_rxcode.SendProperty(context, sPrefix, false, Ddo_br_medication_rxcode_Internalname, "TitleControlIdToReplace", Ddo_br_medication_rxcode_Titlecontrolidtoreplace);
         AV24ddo_BR_Medication_RXCodeTitleControlIdToReplace = Ddo_br_medication_rxcode_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV24ddo_BR_Medication_RXCodeTitleControlIdToReplace", AV24ddo_BR_Medication_RXCodeTitleControlIdToReplace);
         edtavDdo_br_medication_rxcodetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDdo_br_medication_rxcodetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_medication_rxcodetitlecontrolidtoreplace_Visible), 5, 0)), true);
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
         }
         edtavOrdereddsc_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavOrdereddsc_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavOrdereddsc_Visible), 5, 0)), true);
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 = AV57DDO_TitleSettingsIcons;
         new GeneXus.Programs.wwpbaseobjects.getwwptitlesettingsicons(context ).execute( out  GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1) ;
         AV57DDO_TitleSettingsIcons = GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1;
         Gridpaginationbar_Rowsperpageselectedvalue = subGrid_Rows;
         ucGridpaginationbar.SendProperty(context, sPrefix, false, Gridpaginationbar_Internalname, "RowsPerPageSelectedValue", StringUtil.LTrim( StringUtil.Str( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0)));
      }

      protected void E20422( )
      {
         if ( gx_refresh_fired )
         {
            return  ;
         }
         gx_refresh_fired = true;
         /* Refresh Routine */
         AV17BR_MedicationIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV21BR_Medication_RXNameTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV43BR_Medication_AdmitStartDateTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV45BR_Medication_AdmitEndDateTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV27BR_Medication_RXDoseTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV23BR_Medication_RXCodeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
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
         edtBR_MedicationID_Titleformat = 2;
         edtBR_MedicationID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "序号", AV18ddo_BR_MedicationIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_MedicationID_Internalname, "Title", edtBR_MedicationID_Title, !bGXsfl_12_Refreshing);
         edtBR_Medication_RXName_Titleformat = 2;
         edtBR_Medication_RXName_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "药物名称", AV22ddo_BR_Medication_RXNameTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_Medication_RXName_Internalname, "Title", edtBR_Medication_RXName_Title, !bGXsfl_12_Refreshing);
         edtBR_Medication_AdmitStartDate_Titleformat = 2;
         edtBR_Medication_AdmitStartDate_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "服药日期", AV44ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_Medication_AdmitStartDate_Internalname, "Title", edtBR_Medication_AdmitStartDate_Title, !bGXsfl_12_Refreshing);
         edtBR_Medication_AdmitEndDate_Titleformat = 2;
         edtBR_Medication_AdmitEndDate_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "停药日期", AV46ddo_BR_Medication_AdmitEndDateTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_Medication_AdmitEndDate_Internalname, "Title", edtBR_Medication_AdmitEndDate_Title, !bGXsfl_12_Refreshing);
         edtBR_Medication_RXDose_Titleformat = 2;
         edtBR_Medication_RXDose_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "药物剂量", AV28ddo_BR_Medication_RXDoseTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_Medication_RXDose_Internalname, "Title", edtBR_Medication_RXDose_Title, !bGXsfl_12_Refreshing);
         edtBR_Medication_RXCode_Titleformat = 2;
         edtBR_Medication_RXCode_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "药物代码", AV24ddo_BR_Medication_RXCodeTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_Medication_RXCode_Internalname, "Title", edtBR_Medication_RXCode_Title, !bGXsfl_12_Refreshing);
         AV60GridCurrentPage = subGrid_Currentpage( );
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV60GridCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV60GridCurrentPage), 10, 0)));
         AV61GridPageSize = subGrid_Rows;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV61GridPageSize", StringUtil.LTrim( StringUtil.Str( (decimal)(AV61GridPageSize), 10, 0)));
         AV62GridRecordCount = subGrid_Recordcount( );
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV62GridRecordCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV62GridRecordCount), 10, 0)));
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV17BR_MedicationIDTitleFilterData", AV17BR_MedicationIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV21BR_Medication_RXNameTitleFilterData", AV21BR_Medication_RXNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV43BR_Medication_AdmitStartDateTitleFilterData", AV43BR_Medication_AdmitStartDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV45BR_Medication_AdmitEndDateTitleFilterData", AV45BR_Medication_AdmitEndDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV27BR_Medication_RXDoseTitleFilterData", AV27BR_Medication_RXDoseTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV23BR_Medication_RXCodeTitleFilterData", AV23BR_Medication_RXCodeTitleFilterData);
      }

      protected void E11422( )
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
            AV59PageToGo = (int)(NumberUtil.Val( Gridpaginationbar_Selectedpage, "."));
            subgrid_gotopage( AV59PageToGo) ;
         }
      }

      protected void E12422( )
      {
         /* Gridpaginationbar_Changerowsperpage Routine */
         subGrid_Rows = Gridpaginationbar_Rowsperpageselectedvalue;
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         subgrid_firstpage( ) ;
         /*  Sending Event outputs  */
      }

      protected void E13422( )
      {
         /* Ddo_br_medicationid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_medicationid_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV14OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14OrderedBy), 4, 0)));
            AV15OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV15OrderedDsc", AV15OrderedDsc);
            Ddo_br_medicationid_Sortedstatus = "ASC";
            ucDdo_br_medicationid.SendProperty(context, sPrefix, false, Ddo_br_medicationid_Internalname, "SortedStatus", Ddo_br_medicationid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         else if ( StringUtil.StrCmp(Ddo_br_medicationid_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV14OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14OrderedBy), 4, 0)));
            AV15OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV15OrderedDsc", AV15OrderedDsc);
            Ddo_br_medicationid_Sortedstatus = "DSC";
            ucDdo_br_medicationid.SendProperty(context, sPrefix, false, Ddo_br_medicationid_Internalname, "SortedStatus", Ddo_br_medicationid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV17BR_MedicationIDTitleFilterData", AV17BR_MedicationIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV21BR_Medication_RXNameTitleFilterData", AV21BR_Medication_RXNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV43BR_Medication_AdmitStartDateTitleFilterData", AV43BR_Medication_AdmitStartDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV45BR_Medication_AdmitEndDateTitleFilterData", AV45BR_Medication_AdmitEndDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV27BR_Medication_RXDoseTitleFilterData", AV27BR_Medication_RXDoseTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV23BR_Medication_RXCodeTitleFilterData", AV23BR_Medication_RXCodeTitleFilterData);
      }

      protected void E14422( )
      {
         /* Ddo_br_medication_rxname_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_medication_rxname_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV14OrderedBy = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14OrderedBy), 4, 0)));
            AV15OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV15OrderedDsc", AV15OrderedDsc);
            Ddo_br_medication_rxname_Sortedstatus = "ASC";
            ucDdo_br_medication_rxname.SendProperty(context, sPrefix, false, Ddo_br_medication_rxname_Internalname, "SortedStatus", Ddo_br_medication_rxname_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         else if ( StringUtil.StrCmp(Ddo_br_medication_rxname_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV14OrderedBy = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14OrderedBy), 4, 0)));
            AV15OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV15OrderedDsc", AV15OrderedDsc);
            Ddo_br_medication_rxname_Sortedstatus = "DSC";
            ucDdo_br_medication_rxname.SendProperty(context, sPrefix, false, Ddo_br_medication_rxname_Internalname, "SortedStatus", Ddo_br_medication_rxname_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV17BR_MedicationIDTitleFilterData", AV17BR_MedicationIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV21BR_Medication_RXNameTitleFilterData", AV21BR_Medication_RXNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV43BR_Medication_AdmitStartDateTitleFilterData", AV43BR_Medication_AdmitStartDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV45BR_Medication_AdmitEndDateTitleFilterData", AV45BR_Medication_AdmitEndDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV27BR_Medication_RXDoseTitleFilterData", AV27BR_Medication_RXDoseTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV23BR_Medication_RXCodeTitleFilterData", AV23BR_Medication_RXCodeTitleFilterData);
      }

      protected void E15422( )
      {
         /* Ddo_br_medication_admitstartdate_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_medication_admitstartdate_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV14OrderedBy = 3;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14OrderedBy), 4, 0)));
            AV15OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV15OrderedDsc", AV15OrderedDsc);
            Ddo_br_medication_admitstartdate_Sortedstatus = "ASC";
            ucDdo_br_medication_admitstartdate.SendProperty(context, sPrefix, false, Ddo_br_medication_admitstartdate_Internalname, "SortedStatus", Ddo_br_medication_admitstartdate_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         else if ( StringUtil.StrCmp(Ddo_br_medication_admitstartdate_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV14OrderedBy = 3;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14OrderedBy), 4, 0)));
            AV15OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV15OrderedDsc", AV15OrderedDsc);
            Ddo_br_medication_admitstartdate_Sortedstatus = "DSC";
            ucDdo_br_medication_admitstartdate.SendProperty(context, sPrefix, false, Ddo_br_medication_admitstartdate_Internalname, "SortedStatus", Ddo_br_medication_admitstartdate_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV17BR_MedicationIDTitleFilterData", AV17BR_MedicationIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV21BR_Medication_RXNameTitleFilterData", AV21BR_Medication_RXNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV43BR_Medication_AdmitStartDateTitleFilterData", AV43BR_Medication_AdmitStartDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV45BR_Medication_AdmitEndDateTitleFilterData", AV45BR_Medication_AdmitEndDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV27BR_Medication_RXDoseTitleFilterData", AV27BR_Medication_RXDoseTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV23BR_Medication_RXCodeTitleFilterData", AV23BR_Medication_RXCodeTitleFilterData);
      }

      protected void E16422( )
      {
         /* Ddo_br_medication_admitenddate_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_medication_admitenddate_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV14OrderedBy = 4;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14OrderedBy), 4, 0)));
            AV15OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV15OrderedDsc", AV15OrderedDsc);
            Ddo_br_medication_admitenddate_Sortedstatus = "ASC";
            ucDdo_br_medication_admitenddate.SendProperty(context, sPrefix, false, Ddo_br_medication_admitenddate_Internalname, "SortedStatus", Ddo_br_medication_admitenddate_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         else if ( StringUtil.StrCmp(Ddo_br_medication_admitenddate_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV14OrderedBy = 4;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14OrderedBy), 4, 0)));
            AV15OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV15OrderedDsc", AV15OrderedDsc);
            Ddo_br_medication_admitenddate_Sortedstatus = "DSC";
            ucDdo_br_medication_admitenddate.SendProperty(context, sPrefix, false, Ddo_br_medication_admitenddate_Internalname, "SortedStatus", Ddo_br_medication_admitenddate_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV17BR_MedicationIDTitleFilterData", AV17BR_MedicationIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV21BR_Medication_RXNameTitleFilterData", AV21BR_Medication_RXNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV43BR_Medication_AdmitStartDateTitleFilterData", AV43BR_Medication_AdmitStartDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV45BR_Medication_AdmitEndDateTitleFilterData", AV45BR_Medication_AdmitEndDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV27BR_Medication_RXDoseTitleFilterData", AV27BR_Medication_RXDoseTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV23BR_Medication_RXCodeTitleFilterData", AV23BR_Medication_RXCodeTitleFilterData);
      }

      protected void E17422( )
      {
         /* Ddo_br_medication_rxdose_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_medication_rxdose_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV14OrderedBy = 5;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14OrderedBy), 4, 0)));
            AV15OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV15OrderedDsc", AV15OrderedDsc);
            Ddo_br_medication_rxdose_Sortedstatus = "ASC";
            ucDdo_br_medication_rxdose.SendProperty(context, sPrefix, false, Ddo_br_medication_rxdose_Internalname, "SortedStatus", Ddo_br_medication_rxdose_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         else if ( StringUtil.StrCmp(Ddo_br_medication_rxdose_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV14OrderedBy = 5;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14OrderedBy), 4, 0)));
            AV15OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV15OrderedDsc", AV15OrderedDsc);
            Ddo_br_medication_rxdose_Sortedstatus = "DSC";
            ucDdo_br_medication_rxdose.SendProperty(context, sPrefix, false, Ddo_br_medication_rxdose_Internalname, "SortedStatus", Ddo_br_medication_rxdose_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV17BR_MedicationIDTitleFilterData", AV17BR_MedicationIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV21BR_Medication_RXNameTitleFilterData", AV21BR_Medication_RXNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV43BR_Medication_AdmitStartDateTitleFilterData", AV43BR_Medication_AdmitStartDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV45BR_Medication_AdmitEndDateTitleFilterData", AV45BR_Medication_AdmitEndDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV27BR_Medication_RXDoseTitleFilterData", AV27BR_Medication_RXDoseTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV23BR_Medication_RXCodeTitleFilterData", AV23BR_Medication_RXCodeTitleFilterData);
      }

      protected void E18422( )
      {
         /* Ddo_br_medication_rxcode_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_medication_rxcode_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV14OrderedBy = 6;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14OrderedBy), 4, 0)));
            AV15OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV15OrderedDsc", AV15OrderedDsc);
            Ddo_br_medication_rxcode_Sortedstatus = "ASC";
            ucDdo_br_medication_rxcode.SendProperty(context, sPrefix, false, Ddo_br_medication_rxcode_Internalname, "SortedStatus", Ddo_br_medication_rxcode_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         else if ( StringUtil.StrCmp(Ddo_br_medication_rxcode_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV14OrderedBy = 6;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14OrderedBy), 4, 0)));
            AV15OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV15OrderedDsc", AV15OrderedDsc);
            Ddo_br_medication_rxcode_Sortedstatus = "DSC";
            ucDdo_br_medication_rxcode.SendProperty(context, sPrefix, false, Ddo_br_medication_rxcode_Internalname, "SortedStatus", Ddo_br_medication_rxcode_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV17BR_MedicationIDTitleFilterData", AV17BR_MedicationIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV21BR_Medication_RXNameTitleFilterData", AV21BR_Medication_RXNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV43BR_Medication_AdmitStartDateTitleFilterData", AV43BR_Medication_AdmitStartDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV45BR_Medication_AdmitEndDateTitleFilterData", AV45BR_Medication_AdmitEndDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV27BR_Medication_RXDoseTitleFilterData", AV27BR_Medication_RXDoseTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV23BR_Medication_RXCodeTitleFilterData", AV23BR_Medication_RXCodeTitleFilterData);
      }

      private void E21422( )
      {
         /* Grid_Load Routine */
         AV67Display = context.GetImagePath( "f11923b6-6acd-4a79-bfc0-0cfc6f3bced5", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, edtavDisplay_Internalname, AV67Display);
         AV74Display_GXI = GXDbFile.PathToUrl( context.GetImagePath( "f11923b6-6acd-4a79-bfc0-0cfc6f3bced5", "", context.GetTheme( )));
         edtavDisplay_Tooltiptext = "显示";
         if ( AV69IsAuthorized_Display )
         {
            edtavDisplay_Link = formatLink("br_medicationview.aspx") + "?" + UrlEncode("" +A119BR_MedicationID) + "," + UrlEncode(StringUtil.RTrim(""));
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

      protected void S132( )
      {
         /* 'CHECKSECURITYFORACTIONS' Routine */
         GXt_boolean2 = AV69IsAuthorized_Display;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Medication", out  GXt_boolean2) ;
         AV69IsAuthorized_Display = GXt_boolean2;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV69IsAuthorized_Display", AV69IsAuthorized_Display);
         if ( ! ( AV69IsAuthorized_Display ) )
         {
            edtavDisplay_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDisplay_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDisplay_Visible), 5, 0)), !bGXsfl_12_Refreshing);
         }
      }

      protected void S122( )
      {
         /* 'LOADGRIDSTATE' Routine */
         if ( StringUtil.StrCmp(AV16Session.Get(AV75Pgmname+"GridState"), "") == 0 )
         {
            AV12GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  AV75Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         else
         {
            AV12GridState.FromXml(AV16Session.Get(AV75Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         AV14OrderedBy = AV12GridState.gxTpr_Orderedby;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14OrderedBy), 4, 0)));
         AV15OrderedDsc = AV12GridState.gxTpr_Ordereddsc;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV15OrderedDsc", AV15OrderedDsc);
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( StringUtil.Trim( AV12GridState.gxTpr_Pagesize))) )
         {
            subGrid_Rows = (int)(NumberUtil.Val( AV12GridState.gxTpr_Pagesize, "."));
            GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         }
      }

      protected void S142( )
      {
         /* 'SAVEGRIDSTATE' Routine */
         AV12GridState.FromXml(AV16Session.Get(AV75Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         AV12GridState.gxTpr_Orderedby = AV14OrderedBy;
         AV12GridState.gxTpr_Ordereddsc = AV15OrderedDsc;
         AV12GridState.gxTpr_Pagesize = StringUtil.Str( (decimal)(subGrid_Rows), 10, 0);
         new GeneXus.Programs.wwpbaseobjects.savegridstate(context ).execute(  AV75Pgmname+"GridState",  AV12GridState.ToXml(false, true, "WWPGridState", "DataAnalysisPlatform")) ;
      }

      protected void S112( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV10TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV10TrnContext.gxTpr_Callerobject = AV75Pgmname;
         AV10TrnContext.gxTpr_Callerondelete = true;
         AV10TrnContext.gxTpr_Callerurl = AV9HTTPRequest.ScriptName+"?"+AV9HTTPRequest.QueryString;
         AV10TrnContext.gxTpr_Transactionname = "BR_Medication";
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
         PA422( ) ;
         WS422( ) ;
         WE422( ) ;
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
         PA422( ) ;
         WCParametersGet( ) ;
      }

      public override void componentprepare( Object[] obj )
      {
         wbLoad = false;
         sCompPrefix = (String)getParm(obj,0);
         sSFPrefix = (String)getParm(obj,1);
         sPrefix = sCompPrefix + sSFPrefix;
         AddComponentObject(sPrefix, "br_encountercheckbr_medicationwc", GetJustCreated( ));
         if ( ( nDoneStart == 0 ) && ( nDynComponent == 0 ) )
         {
            INITWEB( ) ;
         }
         else
         {
            init_default_properties( ) ;
            init_web_controls( ) ;
         }
         PA422( ) ;
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
         PA422( ) ;
         sEvt = sCompEvt;
         WCParametersGet( ) ;
         WS422( ) ;
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
         WS422( ) ;
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
         WE422( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2020227935784", true);
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
         context.AddJavascriptSource("br_encountercheckbr_medicationwc.js", "?2020227935784", false);
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
         context.AddJavascriptSource("DVelop/WorkWithPlusUtilities/WorkWithPlusUtilitiesRender.js", "", false);
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_122( )
      {
         edtavDisplay_Internalname = sPrefix+"vDISPLAY_"+sGXsfl_12_idx;
         edtBR_MedicationID_Internalname = sPrefix+"BR_MEDICATIONID_"+sGXsfl_12_idx;
         edtBR_Medication_RXName_Internalname = sPrefix+"BR_MEDICATION_RXNAME_"+sGXsfl_12_idx;
         edtBR_Medication_AdmitStartDate_Internalname = sPrefix+"BR_MEDICATION_ADMITSTARTDATE_"+sGXsfl_12_idx;
         edtBR_Medication_AdmitEndDate_Internalname = sPrefix+"BR_MEDICATION_ADMITENDDATE_"+sGXsfl_12_idx;
         edtBR_Medication_RXType_Internalname = sPrefix+"BR_MEDICATION_RXTYPE_"+sGXsfl_12_idx;
         edtBR_Medication_RXDose_Internalname = sPrefix+"BR_MEDICATION_RXDOSE_"+sGXsfl_12_idx;
         edtBR_Medication_RXCode_Internalname = sPrefix+"BR_MEDICATION_RXCODE_"+sGXsfl_12_idx;
         edtBR_Medication_RXUnit_Internalname = sPrefix+"BR_MEDICATION_RXUNIT_"+sGXsfl_12_idx;
         edtBR_Medication_RXFrequency_Internalname = sPrefix+"BR_MEDICATION_RXFREQUENCY_"+sGXsfl_12_idx;
         edtBR_Medication_RXQuantity_Internalname = sPrefix+"BR_MEDICATION_RXQUANTITY_"+sGXsfl_12_idx;
         edtBR_Medication_RXDaysSupply_Internalname = sPrefix+"BR_MEDICATION_RXDAYSSUPPLY_"+sGXsfl_12_idx;
         edtBR_Medication_RXRoute_Internalname = sPrefix+"BR_MEDICATION_RXROUTE_"+sGXsfl_12_idx;
         edtBR_Medication_PrescriptionDate_Internalname = sPrefix+"BR_MEDICATION_PRESCRIPTIONDATE_"+sGXsfl_12_idx;
         cmbBR_Medication_InpatientChemo_Internalname = sPrefix+"BR_MEDICATION_INPATIENTCHEMO_"+sGXsfl_12_idx;
      }

      protected void SubsflControlProps_fel_122( )
      {
         edtavDisplay_Internalname = sPrefix+"vDISPLAY_"+sGXsfl_12_fel_idx;
         edtBR_MedicationID_Internalname = sPrefix+"BR_MEDICATIONID_"+sGXsfl_12_fel_idx;
         edtBR_Medication_RXName_Internalname = sPrefix+"BR_MEDICATION_RXNAME_"+sGXsfl_12_fel_idx;
         edtBR_Medication_AdmitStartDate_Internalname = sPrefix+"BR_MEDICATION_ADMITSTARTDATE_"+sGXsfl_12_fel_idx;
         edtBR_Medication_AdmitEndDate_Internalname = sPrefix+"BR_MEDICATION_ADMITENDDATE_"+sGXsfl_12_fel_idx;
         edtBR_Medication_RXType_Internalname = sPrefix+"BR_MEDICATION_RXTYPE_"+sGXsfl_12_fel_idx;
         edtBR_Medication_RXDose_Internalname = sPrefix+"BR_MEDICATION_RXDOSE_"+sGXsfl_12_fel_idx;
         edtBR_Medication_RXCode_Internalname = sPrefix+"BR_MEDICATION_RXCODE_"+sGXsfl_12_fel_idx;
         edtBR_Medication_RXUnit_Internalname = sPrefix+"BR_MEDICATION_RXUNIT_"+sGXsfl_12_fel_idx;
         edtBR_Medication_RXFrequency_Internalname = sPrefix+"BR_MEDICATION_RXFREQUENCY_"+sGXsfl_12_fel_idx;
         edtBR_Medication_RXQuantity_Internalname = sPrefix+"BR_MEDICATION_RXQUANTITY_"+sGXsfl_12_fel_idx;
         edtBR_Medication_RXDaysSupply_Internalname = sPrefix+"BR_MEDICATION_RXDAYSSUPPLY_"+sGXsfl_12_fel_idx;
         edtBR_Medication_RXRoute_Internalname = sPrefix+"BR_MEDICATION_RXROUTE_"+sGXsfl_12_fel_idx;
         edtBR_Medication_PrescriptionDate_Internalname = sPrefix+"BR_MEDICATION_PRESCRIPTIONDATE_"+sGXsfl_12_fel_idx;
         cmbBR_Medication_InpatientChemo_Internalname = sPrefix+"BR_MEDICATION_INPATIENTCHEMO_"+sGXsfl_12_fel_idx;
      }

      protected void sendrow_122( )
      {
         SubsflControlProps_122( ) ;
         WB420( ) ;
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
            AV67Display_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV67Display))&&String.IsNullOrEmpty(StringUtil.RTrim( AV74Display_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV67Display)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV67Display)) ? AV74Display_GXI : context.PathToRelativeUrl( AV67Display));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavDisplay_Internalname,(String)sImgUrl,(String)edtavDisplay_Link,(String)"",(String)"",context.GetTheme( ),(int)edtavDisplay_Visible,(short)1,(String)"",(String)edtavDisplay_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV67Display_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_MedicationID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A119BR_MedicationID), 18, 0, ".", "")),context.localUtil.Format( (decimal)(A119BR_MedicationID), "ZZZZZZZZZZZZZZZZZZ"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_MedicationID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs hidden-sm",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"ID",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Medication_RXName_Internalname,(String)A121BR_Medication_RXName,(String)"",(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Medication_RXName_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Medication_AdmitStartDate_Internalname,context.localUtil.Format(A132BR_Medication_AdmitStartDate, "9999/99/99"),context.localUtil.Format( A132BR_Medication_AdmitStartDate, "9999/99/99"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Medication_AdmitStartDate_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"DM_Date",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Medication_AdmitEndDate_Internalname,context.localUtil.Format(A133BR_Medication_AdmitEndDate, "9999/99/99"),context.localUtil.Format( A133BR_Medication_AdmitEndDate, "9999/99/99"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Medication_AdmitEndDate_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"DM_Date",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Medication_RXType_Internalname,(String)A123BR_Medication_RXType,(String)"",(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Medication_RXType_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)0,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Medication_RXDose_Internalname,StringUtil.LTrim( StringUtil.NToC( A124BR_Medication_RXDose, 15, 5, ".", "")),context.localUtil.Format( A124BR_Medication_RXDose, "ZZZZZZZZZ.ZZ"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Medication_RXDose_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs hidden-sm",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)15,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"DM_Numeric",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Medication_RXCode_Internalname,(String)A122BR_Medication_RXCode,(String)"",(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Medication_RXCode_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs hidden-sm",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Medication_RXUnit_Internalname,(String)A125BR_Medication_RXUnit,(String)"",(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Medication_RXUnit_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)0,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Medication_RXFrequency_Internalname,(String)A126BR_Medication_RXFrequency,(String)"",(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Medication_RXFrequency_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)0,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Medication_RXQuantity_Internalname,(String)A127BR_Medication_RXQuantity,(String)"",(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Medication_RXQuantity_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)0,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Medication_RXDaysSupply_Internalname,StringUtil.LTrim( StringUtil.NToC( A128BR_Medication_RXDaysSupply, 15, 5, ".", "")),context.localUtil.Format( A128BR_Medication_RXDaysSupply, "ZZZZZZZZZ.ZZZZZ"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Medication_RXDaysSupply_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)0,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)15,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"DM_Numeric",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Medication_RXRoute_Internalname,(String)A129BR_Medication_RXRoute,(String)"",(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Medication_RXRoute_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)0,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Medication_PrescriptionDate_Internalname,context.localUtil.Format(A130BR_Medication_PrescriptionDate, "9999/99/99"),context.localUtil.Format( A130BR_Medication_PrescriptionDate, "9999/99/99"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Medication_PrescriptionDate_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)0,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"DM_Date",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            if ( ( cmbBR_Medication_InpatientChemo.ItemCount == 0 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "BR_MEDICATION_INPATIENTCHEMO_" + sGXsfl_12_idx;
               cmbBR_Medication_InpatientChemo.Name = GXCCtl;
               cmbBR_Medication_InpatientChemo.WebTags = "";
               cmbBR_Medication_InpatientChemo.addItem("", "(请选择)", 0);
               cmbBR_Medication_InpatientChemo.addItem("否", "否", 0);
               cmbBR_Medication_InpatientChemo.addItem("是", "是", 0);
               cmbBR_Medication_InpatientChemo.addItem("不详", "不详", 0);
               if ( cmbBR_Medication_InpatientChemo.ItemCount > 0 )
               {
                  A131BR_Medication_InpatientChemo = cmbBR_Medication_InpatientChemo.getValidValue(A131BR_Medication_InpatientChemo);
                  n131BR_Medication_InpatientChemo = false;
               }
            }
            /* ComboBox */
            GridRow.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbBR_Medication_InpatientChemo,(String)cmbBR_Medication_InpatientChemo_Internalname,StringUtil.RTrim( A131BR_Medication_InpatientChemo),(short)1,(String)cmbBR_Medication_InpatientChemo_Jsonclick,(short)0,(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"svchar",(String)"",(short)0,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)"",(String)"Attribute",(String)"WWColumn hidden-xs",(String)"",(String)"",(String)"",(bool)true});
            cmbBR_Medication_InpatientChemo.CurrentValue = StringUtil.RTrim( A131BR_Medication_InpatientChemo);
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, cmbBR_Medication_InpatientChemo_Internalname, "Values", (String)(cmbBR_Medication_InpatientChemo.ToJavascriptSource()), !bGXsfl_12_Refreshing);
            send_integrity_lvl_hashes422( ) ;
            GridContainer.AddRow(GridRow);
            nGXsfl_12_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_12_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_12_idx+1));
            sGXsfl_12_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_12_idx), 4, 0)), 4, "0");
            SubsflControlProps_122( ) ;
         }
         /* End function sendrow_122 */
      }

      protected void init_web_controls( )
      {
         GXCCtl = "BR_MEDICATION_INPATIENTCHEMO_" + sGXsfl_12_idx;
         cmbBR_Medication_InpatientChemo.Name = GXCCtl;
         cmbBR_Medication_InpatientChemo.WebTags = "";
         cmbBR_Medication_InpatientChemo.addItem("", "(请选择)", 0);
         cmbBR_Medication_InpatientChemo.addItem("否", "否", 0);
         cmbBR_Medication_InpatientChemo.addItem("是", "是", 0);
         cmbBR_Medication_InpatientChemo.addItem("不详", "不详", 0);
         if ( cmbBR_Medication_InpatientChemo.ItemCount > 0 )
         {
         }
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         edtavDisplay_Internalname = sPrefix+"vDISPLAY";
         edtBR_MedicationID_Internalname = sPrefix+"BR_MEDICATIONID";
         edtBR_Medication_RXName_Internalname = sPrefix+"BR_MEDICATION_RXNAME";
         edtBR_Medication_AdmitStartDate_Internalname = sPrefix+"BR_MEDICATION_ADMITSTARTDATE";
         edtBR_Medication_AdmitEndDate_Internalname = sPrefix+"BR_MEDICATION_ADMITENDDATE";
         edtBR_Medication_RXType_Internalname = sPrefix+"BR_MEDICATION_RXTYPE";
         edtBR_Medication_RXDose_Internalname = sPrefix+"BR_MEDICATION_RXDOSE";
         edtBR_Medication_RXCode_Internalname = sPrefix+"BR_MEDICATION_RXCODE";
         edtBR_Medication_RXUnit_Internalname = sPrefix+"BR_MEDICATION_RXUNIT";
         edtBR_Medication_RXFrequency_Internalname = sPrefix+"BR_MEDICATION_RXFREQUENCY";
         edtBR_Medication_RXQuantity_Internalname = sPrefix+"BR_MEDICATION_RXQUANTITY";
         edtBR_Medication_RXDaysSupply_Internalname = sPrefix+"BR_MEDICATION_RXDAYSSUPPLY";
         edtBR_Medication_RXRoute_Internalname = sPrefix+"BR_MEDICATION_RXROUTE";
         edtBR_Medication_PrescriptionDate_Internalname = sPrefix+"BR_MEDICATION_PRESCRIPTIONDATE";
         cmbBR_Medication_InpatientChemo_Internalname = sPrefix+"BR_MEDICATION_INPATIENTCHEMO";
         Gridpaginationbar_Internalname = sPrefix+"GRIDPAGINATIONBAR";
         divHtml_gridpaginationbar_Internalname = sPrefix+"HTML_GRIDPAGINATIONBAR";
         divGridtablewithpaginationbar_Internalname = sPrefix+"GRIDTABLEWITHPAGINATIONBAR";
         divTablegridheader_Internalname = sPrefix+"TABLEGRIDHEADER";
         Ddo_br_medicationid_Internalname = sPrefix+"DDO_BR_MEDICATIONID";
         edtavDdo_br_medicationidtitlecontrolidtoreplace_Internalname = sPrefix+"vDDO_BR_MEDICATIONIDTITLECONTROLIDTOREPLACE";
         Ddo_br_medication_rxname_Internalname = sPrefix+"DDO_BR_MEDICATION_RXNAME";
         edtavDdo_br_medication_rxnametitlecontrolidtoreplace_Internalname = sPrefix+"vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE";
         Ddo_br_medication_admitstartdate_Internalname = sPrefix+"DDO_BR_MEDICATION_ADMITSTARTDATE";
         edtavDdo_br_medication_admitstartdatetitlecontrolidtoreplace_Internalname = sPrefix+"vDDO_BR_MEDICATION_ADMITSTARTDATETITLECONTROLIDTOREPLACE";
         Ddo_br_medication_admitenddate_Internalname = sPrefix+"DDO_BR_MEDICATION_ADMITENDDATE";
         edtavDdo_br_medication_admitenddatetitlecontrolidtoreplace_Internalname = sPrefix+"vDDO_BR_MEDICATION_ADMITENDDATETITLECONTROLIDTOREPLACE";
         Ddo_br_medication_rxdose_Internalname = sPrefix+"DDO_BR_MEDICATION_RXDOSE";
         edtavDdo_br_medication_rxdosetitlecontrolidtoreplace_Internalname = sPrefix+"vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE";
         Ddo_br_medication_rxcode_Internalname = sPrefix+"DDO_BR_MEDICATION_RXCODE";
         edtavDdo_br_medication_rxcodetitlecontrolidtoreplace_Internalname = sPrefix+"vDDO_BR_MEDICATION_RXCODETITLECONTROLIDTOREPLACE";
         edtBR_EncounterID_Internalname = sPrefix+"BR_ENCOUNTERID";
         Workwithplusutilities1_Internalname = sPrefix+"WORKWITHPLUSUTILITIES1";
         edtavOrderedby_Internalname = sPrefix+"vORDEREDBY";
         edtavOrdereddsc_Internalname = sPrefix+"vORDEREDDSC";
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
         cmbBR_Medication_InpatientChemo_Jsonclick = "";
         edtBR_Medication_PrescriptionDate_Jsonclick = "";
         edtBR_Medication_RXRoute_Jsonclick = "";
         edtBR_Medication_RXDaysSupply_Jsonclick = "";
         edtBR_Medication_RXQuantity_Jsonclick = "";
         edtBR_Medication_RXFrequency_Jsonclick = "";
         edtBR_Medication_RXUnit_Jsonclick = "";
         edtBR_Medication_RXCode_Jsonclick = "";
         edtBR_Medication_RXDose_Jsonclick = "";
         edtBR_Medication_RXType_Jsonclick = "";
         edtBR_Medication_AdmitEndDate_Jsonclick = "";
         edtBR_Medication_AdmitStartDate_Jsonclick = "";
         edtBR_Medication_RXName_Jsonclick = "";
         edtBR_MedicationID_Jsonclick = "";
         edtavOrdereddsc_Jsonclick = "";
         edtavOrdereddsc_Visible = 1;
         edtavOrderedby_Jsonclick = "";
         edtavOrderedby_Visible = 1;
         edtBR_EncounterID_Jsonclick = "";
         edtBR_EncounterID_Visible = 1;
         edtavDdo_br_medication_rxcodetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_medication_rxdosetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_medication_admitenddatetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_medication_admitstartdatetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_medication_rxnametitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_medicationidtitlecontrolidtoreplace_Visible = 1;
         subGrid_Allowcollapsing = 0;
         subGrid_Allowselection = 0;
         edtavDisplay_Tooltiptext = "显示";
         edtavDisplay_Link = "";
         subGrid_Sortable = 0;
         subGrid_Header = "";
         edtBR_Medication_RXCode_Titleformat = 0;
         edtBR_Medication_RXCode_Title = "药物代码";
         edtBR_Medication_RXDose_Titleformat = 0;
         edtBR_Medication_RXDose_Title = "药物剂量";
         edtBR_Medication_AdmitEndDate_Titleformat = 0;
         edtBR_Medication_AdmitEndDate_Title = "停药日期";
         edtBR_Medication_AdmitStartDate_Titleformat = 0;
         edtBR_Medication_AdmitStartDate_Title = "服药日期";
         edtBR_Medication_RXName_Titleformat = 0;
         edtBR_Medication_RXName_Title = "药物名称";
         edtBR_MedicationID_Titleformat = 0;
         edtBR_MedicationID_Title = "序号";
         edtavDisplay_Visible = -1;
         subGrid_Class = "GridWithPaginationBar GridWithBorderColor WorkWith";
         subGrid_Backcolorstyle = 0;
         Ddo_br_medication_rxcode_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_medication_rxcode_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_medication_rxcode_Sortasc = "WWP_TSSortASC";
         Ddo_br_medication_rxcode_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_medication_rxcode_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_medication_rxcode_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_medication_rxcode_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_medication_rxcode_Titlecontrolidtoreplace = "";
         Ddo_br_medication_rxcode_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_medication_rxcode_Cls = "ColumnSettings";
         Ddo_br_medication_rxcode_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_medication_rxcode_Caption = "";
         Ddo_br_medication_rxdose_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_medication_rxdose_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_medication_rxdose_Sortasc = "WWP_TSSortASC";
         Ddo_br_medication_rxdose_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_medication_rxdose_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_medication_rxdose_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_medication_rxdose_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_medication_rxdose_Titlecontrolidtoreplace = "";
         Ddo_br_medication_rxdose_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_medication_rxdose_Cls = "ColumnSettings";
         Ddo_br_medication_rxdose_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_medication_rxdose_Caption = "";
         Ddo_br_medication_admitenddate_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_medication_admitenddate_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_medication_admitenddate_Sortasc = "WWP_TSSortASC";
         Ddo_br_medication_admitenddate_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_medication_admitenddate_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_medication_admitenddate_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_medication_admitenddate_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_medication_admitenddate_Titlecontrolidtoreplace = "";
         Ddo_br_medication_admitenddate_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_medication_admitenddate_Cls = "ColumnSettings";
         Ddo_br_medication_admitenddate_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_medication_admitenddate_Caption = "";
         Ddo_br_medication_admitstartdate_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_medication_admitstartdate_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_medication_admitstartdate_Sortasc = "WWP_TSSortASC";
         Ddo_br_medication_admitstartdate_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_medication_admitstartdate_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_medication_admitstartdate_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_medication_admitstartdate_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_medication_admitstartdate_Titlecontrolidtoreplace = "";
         Ddo_br_medication_admitstartdate_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_medication_admitstartdate_Cls = "ColumnSettings";
         Ddo_br_medication_admitstartdate_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_medication_admitstartdate_Caption = "";
         Ddo_br_medication_rxname_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_medication_rxname_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_medication_rxname_Sortasc = "WWP_TSSortASC";
         Ddo_br_medication_rxname_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_medication_rxname_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_medication_rxname_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_medication_rxname_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_medication_rxname_Titlecontrolidtoreplace = "";
         Ddo_br_medication_rxname_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_medication_rxname_Cls = "ColumnSettings";
         Ddo_br_medication_rxname_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_medication_rxname_Caption = "";
         Ddo_br_medicationid_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_medicationid_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_medicationid_Sortasc = "WWP_TSSortASC";
         Ddo_br_medicationid_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_medicationid_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_medicationid_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_medicationid_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_medicationid_Titlecontrolidtoreplace = "";
         Ddo_br_medicationid_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_medicationid_Cls = "ColumnSettings";
         Ddo_br_medicationid_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_medicationid_Caption = "";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV69IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'sPrefix'},{av:'AV18ddo_BR_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV44ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_ADMITSTARTDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV46ddo_BR_Medication_AdmitEndDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_ADMITENDDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_Medication_RXDoseTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Medication_RXCodeTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXCODETITLECONTROLIDTOREPLACE',pic:''},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV75Pgmname',fld:'vPGMNAME',pic:''},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''}]");
         setEventMetadata("REFRESH",",oparms:[{av:'AV17BR_MedicationIDTitleFilterData',fld:'vBR_MEDICATIONIDTITLEFILTERDATA',pic:''},{av:'AV21BR_Medication_RXNameTitleFilterData',fld:'vBR_MEDICATION_RXNAMETITLEFILTERDATA',pic:''},{av:'AV43BR_Medication_AdmitStartDateTitleFilterData',fld:'vBR_MEDICATION_ADMITSTARTDATETITLEFILTERDATA',pic:''},{av:'AV45BR_Medication_AdmitEndDateTitleFilterData',fld:'vBR_MEDICATION_ADMITENDDATETITLEFILTERDATA',pic:''},{av:'AV27BR_Medication_RXDoseTitleFilterData',fld:'vBR_MEDICATION_RXDOSETITLEFILTERDATA',pic:''},{av:'AV23BR_Medication_RXCodeTitleFilterData',fld:'vBR_MEDICATION_RXCODETITLEFILTERDATA',pic:''},{av:'edtBR_MedicationID_Titleformat',ctrl:'BR_MEDICATIONID',prop:'Titleformat'},{av:'edtBR_MedicationID_Title',ctrl:'BR_MEDICATIONID',prop:'Title'},{av:'edtBR_Medication_RXName_Titleformat',ctrl:'BR_MEDICATION_RXNAME',prop:'Titleformat'},{av:'edtBR_Medication_RXName_Title',ctrl:'BR_MEDICATION_RXNAME',prop:'Title'},{av:'edtBR_Medication_AdmitStartDate_Titleformat',ctrl:'BR_MEDICATION_ADMITSTARTDATE',prop:'Titleformat'},{av:'edtBR_Medication_AdmitStartDate_Title',ctrl:'BR_MEDICATION_ADMITSTARTDATE',prop:'Title'},{av:'edtBR_Medication_AdmitEndDate_Titleformat',ctrl:'BR_MEDICATION_ADMITENDDATE',prop:'Titleformat'},{av:'edtBR_Medication_AdmitEndDate_Title',ctrl:'BR_MEDICATION_ADMITENDDATE',prop:'Title'},{av:'edtBR_Medication_RXDose_Titleformat',ctrl:'BR_MEDICATION_RXDOSE',prop:'Titleformat'},{av:'edtBR_Medication_RXDose_Title',ctrl:'BR_MEDICATION_RXDOSE',prop:'Title'},{av:'edtBR_Medication_RXCode_Titleformat',ctrl:'BR_MEDICATION_RXCODE',prop:'Titleformat'},{av:'edtBR_Medication_RXCode_Title',ctrl:'BR_MEDICATION_RXCODE',prop:'Title'},{av:'AV60GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV61GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV62GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV69IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'edtavDisplay_Visible',ctrl:'vDISPLAY',prop:'Visible'}]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE","{handler:'E11422',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18ddo_BR_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV44ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_ADMITSTARTDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV46ddo_BR_Medication_AdmitEndDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_ADMITENDDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_Medication_RXDoseTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Medication_RXCodeTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV75Pgmname',fld:'vPGMNAME',pic:''},{av:'AV69IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'sPrefix'},{av:'Gridpaginationbar_Selectedpage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE",",oparms:[]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE","{handler:'E12422',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18ddo_BR_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV44ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_ADMITSTARTDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV46ddo_BR_Medication_AdmitEndDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_ADMITENDDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_Medication_RXDoseTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Medication_RXCodeTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV75Pgmname',fld:'vPGMNAME',pic:''},{av:'AV69IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'sPrefix'},{av:'Gridpaginationbar_Rowsperpageselectedvalue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE",",oparms:[{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]}");
         setEventMetadata("DDO_BR_MEDICATIONID.ONOPTIONCLICKED","{handler:'E13422',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18ddo_BR_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV44ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_ADMITSTARTDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV46ddo_BR_Medication_AdmitEndDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_ADMITENDDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_Medication_RXDoseTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Medication_RXCodeTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV75Pgmname',fld:'vPGMNAME',pic:''},{av:'AV69IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'sPrefix'},{av:'Ddo_br_medicationid_Activeeventkey',ctrl:'DDO_BR_MEDICATIONID',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_MEDICATIONID.ONOPTIONCLICKED",",oparms:[{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_medicationid_Sortedstatus',ctrl:'DDO_BR_MEDICATIONID',prop:'SortedStatus'},{av:'AV17BR_MedicationIDTitleFilterData',fld:'vBR_MEDICATIONIDTITLEFILTERDATA',pic:''},{av:'AV21BR_Medication_RXNameTitleFilterData',fld:'vBR_MEDICATION_RXNAMETITLEFILTERDATA',pic:''},{av:'AV43BR_Medication_AdmitStartDateTitleFilterData',fld:'vBR_MEDICATION_ADMITSTARTDATETITLEFILTERDATA',pic:''},{av:'AV45BR_Medication_AdmitEndDateTitleFilterData',fld:'vBR_MEDICATION_ADMITENDDATETITLEFILTERDATA',pic:''},{av:'AV27BR_Medication_RXDoseTitleFilterData',fld:'vBR_MEDICATION_RXDOSETITLEFILTERDATA',pic:''},{av:'AV23BR_Medication_RXCodeTitleFilterData',fld:'vBR_MEDICATION_RXCODETITLEFILTERDATA',pic:''},{av:'edtBR_MedicationID_Titleformat',ctrl:'BR_MEDICATIONID',prop:'Titleformat'},{av:'edtBR_MedicationID_Title',ctrl:'BR_MEDICATIONID',prop:'Title'},{av:'edtBR_Medication_RXName_Titleformat',ctrl:'BR_MEDICATION_RXNAME',prop:'Titleformat'},{av:'edtBR_Medication_RXName_Title',ctrl:'BR_MEDICATION_RXNAME',prop:'Title'},{av:'edtBR_Medication_AdmitStartDate_Titleformat',ctrl:'BR_MEDICATION_ADMITSTARTDATE',prop:'Titleformat'},{av:'edtBR_Medication_AdmitStartDate_Title',ctrl:'BR_MEDICATION_ADMITSTARTDATE',prop:'Title'},{av:'edtBR_Medication_AdmitEndDate_Titleformat',ctrl:'BR_MEDICATION_ADMITENDDATE',prop:'Titleformat'},{av:'edtBR_Medication_AdmitEndDate_Title',ctrl:'BR_MEDICATION_ADMITENDDATE',prop:'Title'},{av:'edtBR_Medication_RXDose_Titleformat',ctrl:'BR_MEDICATION_RXDOSE',prop:'Titleformat'},{av:'edtBR_Medication_RXDose_Title',ctrl:'BR_MEDICATION_RXDOSE',prop:'Title'},{av:'edtBR_Medication_RXCode_Titleformat',ctrl:'BR_MEDICATION_RXCODE',prop:'Titleformat'},{av:'edtBR_Medication_RXCode_Title',ctrl:'BR_MEDICATION_RXCODE',prop:'Title'},{av:'AV60GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV61GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV62GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV69IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'edtavDisplay_Visible',ctrl:'vDISPLAY',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_MEDICATION_RXNAME.ONOPTIONCLICKED","{handler:'E14422',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18ddo_BR_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV44ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_ADMITSTARTDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV46ddo_BR_Medication_AdmitEndDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_ADMITENDDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_Medication_RXDoseTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Medication_RXCodeTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV75Pgmname',fld:'vPGMNAME',pic:''},{av:'AV69IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'sPrefix'},{av:'Ddo_br_medication_rxname_Activeeventkey',ctrl:'DDO_BR_MEDICATION_RXNAME',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_MEDICATION_RXNAME.ONOPTIONCLICKED",",oparms:[{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_medication_rxname_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXNAME',prop:'SortedStatus'},{av:'AV17BR_MedicationIDTitleFilterData',fld:'vBR_MEDICATIONIDTITLEFILTERDATA',pic:''},{av:'AV21BR_Medication_RXNameTitleFilterData',fld:'vBR_MEDICATION_RXNAMETITLEFILTERDATA',pic:''},{av:'AV43BR_Medication_AdmitStartDateTitleFilterData',fld:'vBR_MEDICATION_ADMITSTARTDATETITLEFILTERDATA',pic:''},{av:'AV45BR_Medication_AdmitEndDateTitleFilterData',fld:'vBR_MEDICATION_ADMITENDDATETITLEFILTERDATA',pic:''},{av:'AV27BR_Medication_RXDoseTitleFilterData',fld:'vBR_MEDICATION_RXDOSETITLEFILTERDATA',pic:''},{av:'AV23BR_Medication_RXCodeTitleFilterData',fld:'vBR_MEDICATION_RXCODETITLEFILTERDATA',pic:''},{av:'edtBR_MedicationID_Titleformat',ctrl:'BR_MEDICATIONID',prop:'Titleformat'},{av:'edtBR_MedicationID_Title',ctrl:'BR_MEDICATIONID',prop:'Title'},{av:'edtBR_Medication_RXName_Titleformat',ctrl:'BR_MEDICATION_RXNAME',prop:'Titleformat'},{av:'edtBR_Medication_RXName_Title',ctrl:'BR_MEDICATION_RXNAME',prop:'Title'},{av:'edtBR_Medication_AdmitStartDate_Titleformat',ctrl:'BR_MEDICATION_ADMITSTARTDATE',prop:'Titleformat'},{av:'edtBR_Medication_AdmitStartDate_Title',ctrl:'BR_MEDICATION_ADMITSTARTDATE',prop:'Title'},{av:'edtBR_Medication_AdmitEndDate_Titleformat',ctrl:'BR_MEDICATION_ADMITENDDATE',prop:'Titleformat'},{av:'edtBR_Medication_AdmitEndDate_Title',ctrl:'BR_MEDICATION_ADMITENDDATE',prop:'Title'},{av:'edtBR_Medication_RXDose_Titleformat',ctrl:'BR_MEDICATION_RXDOSE',prop:'Titleformat'},{av:'edtBR_Medication_RXDose_Title',ctrl:'BR_MEDICATION_RXDOSE',prop:'Title'},{av:'edtBR_Medication_RXCode_Titleformat',ctrl:'BR_MEDICATION_RXCODE',prop:'Titleformat'},{av:'edtBR_Medication_RXCode_Title',ctrl:'BR_MEDICATION_RXCODE',prop:'Title'},{av:'AV60GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV61GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV62GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV69IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'edtavDisplay_Visible',ctrl:'vDISPLAY',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_MEDICATION_ADMITSTARTDATE.ONOPTIONCLICKED","{handler:'E15422',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18ddo_BR_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV44ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_ADMITSTARTDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV46ddo_BR_Medication_AdmitEndDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_ADMITENDDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_Medication_RXDoseTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Medication_RXCodeTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV75Pgmname',fld:'vPGMNAME',pic:''},{av:'AV69IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'sPrefix'},{av:'Ddo_br_medication_admitstartdate_Activeeventkey',ctrl:'DDO_BR_MEDICATION_ADMITSTARTDATE',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_MEDICATION_ADMITSTARTDATE.ONOPTIONCLICKED",",oparms:[{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_medication_admitstartdate_Sortedstatus',ctrl:'DDO_BR_MEDICATION_ADMITSTARTDATE',prop:'SortedStatus'},{av:'AV17BR_MedicationIDTitleFilterData',fld:'vBR_MEDICATIONIDTITLEFILTERDATA',pic:''},{av:'AV21BR_Medication_RXNameTitleFilterData',fld:'vBR_MEDICATION_RXNAMETITLEFILTERDATA',pic:''},{av:'AV43BR_Medication_AdmitStartDateTitleFilterData',fld:'vBR_MEDICATION_ADMITSTARTDATETITLEFILTERDATA',pic:''},{av:'AV45BR_Medication_AdmitEndDateTitleFilterData',fld:'vBR_MEDICATION_ADMITENDDATETITLEFILTERDATA',pic:''},{av:'AV27BR_Medication_RXDoseTitleFilterData',fld:'vBR_MEDICATION_RXDOSETITLEFILTERDATA',pic:''},{av:'AV23BR_Medication_RXCodeTitleFilterData',fld:'vBR_MEDICATION_RXCODETITLEFILTERDATA',pic:''},{av:'edtBR_MedicationID_Titleformat',ctrl:'BR_MEDICATIONID',prop:'Titleformat'},{av:'edtBR_MedicationID_Title',ctrl:'BR_MEDICATIONID',prop:'Title'},{av:'edtBR_Medication_RXName_Titleformat',ctrl:'BR_MEDICATION_RXNAME',prop:'Titleformat'},{av:'edtBR_Medication_RXName_Title',ctrl:'BR_MEDICATION_RXNAME',prop:'Title'},{av:'edtBR_Medication_AdmitStartDate_Titleformat',ctrl:'BR_MEDICATION_ADMITSTARTDATE',prop:'Titleformat'},{av:'edtBR_Medication_AdmitStartDate_Title',ctrl:'BR_MEDICATION_ADMITSTARTDATE',prop:'Title'},{av:'edtBR_Medication_AdmitEndDate_Titleformat',ctrl:'BR_MEDICATION_ADMITENDDATE',prop:'Titleformat'},{av:'edtBR_Medication_AdmitEndDate_Title',ctrl:'BR_MEDICATION_ADMITENDDATE',prop:'Title'},{av:'edtBR_Medication_RXDose_Titleformat',ctrl:'BR_MEDICATION_RXDOSE',prop:'Titleformat'},{av:'edtBR_Medication_RXDose_Title',ctrl:'BR_MEDICATION_RXDOSE',prop:'Title'},{av:'edtBR_Medication_RXCode_Titleformat',ctrl:'BR_MEDICATION_RXCODE',prop:'Titleformat'},{av:'edtBR_Medication_RXCode_Title',ctrl:'BR_MEDICATION_RXCODE',prop:'Title'},{av:'AV60GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV61GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV62GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV69IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'edtavDisplay_Visible',ctrl:'vDISPLAY',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_MEDICATION_ADMITENDDATE.ONOPTIONCLICKED","{handler:'E16422',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18ddo_BR_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV44ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_ADMITSTARTDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV46ddo_BR_Medication_AdmitEndDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_ADMITENDDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_Medication_RXDoseTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Medication_RXCodeTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV75Pgmname',fld:'vPGMNAME',pic:''},{av:'AV69IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'sPrefix'},{av:'Ddo_br_medication_admitenddate_Activeeventkey',ctrl:'DDO_BR_MEDICATION_ADMITENDDATE',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_MEDICATION_ADMITENDDATE.ONOPTIONCLICKED",",oparms:[{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_medication_admitenddate_Sortedstatus',ctrl:'DDO_BR_MEDICATION_ADMITENDDATE',prop:'SortedStatus'},{av:'AV17BR_MedicationIDTitleFilterData',fld:'vBR_MEDICATIONIDTITLEFILTERDATA',pic:''},{av:'AV21BR_Medication_RXNameTitleFilterData',fld:'vBR_MEDICATION_RXNAMETITLEFILTERDATA',pic:''},{av:'AV43BR_Medication_AdmitStartDateTitleFilterData',fld:'vBR_MEDICATION_ADMITSTARTDATETITLEFILTERDATA',pic:''},{av:'AV45BR_Medication_AdmitEndDateTitleFilterData',fld:'vBR_MEDICATION_ADMITENDDATETITLEFILTERDATA',pic:''},{av:'AV27BR_Medication_RXDoseTitleFilterData',fld:'vBR_MEDICATION_RXDOSETITLEFILTERDATA',pic:''},{av:'AV23BR_Medication_RXCodeTitleFilterData',fld:'vBR_MEDICATION_RXCODETITLEFILTERDATA',pic:''},{av:'edtBR_MedicationID_Titleformat',ctrl:'BR_MEDICATIONID',prop:'Titleformat'},{av:'edtBR_MedicationID_Title',ctrl:'BR_MEDICATIONID',prop:'Title'},{av:'edtBR_Medication_RXName_Titleformat',ctrl:'BR_MEDICATION_RXNAME',prop:'Titleformat'},{av:'edtBR_Medication_RXName_Title',ctrl:'BR_MEDICATION_RXNAME',prop:'Title'},{av:'edtBR_Medication_AdmitStartDate_Titleformat',ctrl:'BR_MEDICATION_ADMITSTARTDATE',prop:'Titleformat'},{av:'edtBR_Medication_AdmitStartDate_Title',ctrl:'BR_MEDICATION_ADMITSTARTDATE',prop:'Title'},{av:'edtBR_Medication_AdmitEndDate_Titleformat',ctrl:'BR_MEDICATION_ADMITENDDATE',prop:'Titleformat'},{av:'edtBR_Medication_AdmitEndDate_Title',ctrl:'BR_MEDICATION_ADMITENDDATE',prop:'Title'},{av:'edtBR_Medication_RXDose_Titleformat',ctrl:'BR_MEDICATION_RXDOSE',prop:'Titleformat'},{av:'edtBR_Medication_RXDose_Title',ctrl:'BR_MEDICATION_RXDOSE',prop:'Title'},{av:'edtBR_Medication_RXCode_Titleformat',ctrl:'BR_MEDICATION_RXCODE',prop:'Titleformat'},{av:'edtBR_Medication_RXCode_Title',ctrl:'BR_MEDICATION_RXCODE',prop:'Title'},{av:'AV60GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV61GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV62GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV69IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'edtavDisplay_Visible',ctrl:'vDISPLAY',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_MEDICATION_RXDOSE.ONOPTIONCLICKED","{handler:'E17422',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18ddo_BR_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV44ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_ADMITSTARTDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV46ddo_BR_Medication_AdmitEndDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_ADMITENDDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_Medication_RXDoseTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Medication_RXCodeTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV75Pgmname',fld:'vPGMNAME',pic:''},{av:'AV69IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'sPrefix'},{av:'Ddo_br_medication_rxdose_Activeeventkey',ctrl:'DDO_BR_MEDICATION_RXDOSE',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_MEDICATION_RXDOSE.ONOPTIONCLICKED",",oparms:[{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_medication_rxdose_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXDOSE',prop:'SortedStatus'},{av:'AV17BR_MedicationIDTitleFilterData',fld:'vBR_MEDICATIONIDTITLEFILTERDATA',pic:''},{av:'AV21BR_Medication_RXNameTitleFilterData',fld:'vBR_MEDICATION_RXNAMETITLEFILTERDATA',pic:''},{av:'AV43BR_Medication_AdmitStartDateTitleFilterData',fld:'vBR_MEDICATION_ADMITSTARTDATETITLEFILTERDATA',pic:''},{av:'AV45BR_Medication_AdmitEndDateTitleFilterData',fld:'vBR_MEDICATION_ADMITENDDATETITLEFILTERDATA',pic:''},{av:'AV27BR_Medication_RXDoseTitleFilterData',fld:'vBR_MEDICATION_RXDOSETITLEFILTERDATA',pic:''},{av:'AV23BR_Medication_RXCodeTitleFilterData',fld:'vBR_MEDICATION_RXCODETITLEFILTERDATA',pic:''},{av:'edtBR_MedicationID_Titleformat',ctrl:'BR_MEDICATIONID',prop:'Titleformat'},{av:'edtBR_MedicationID_Title',ctrl:'BR_MEDICATIONID',prop:'Title'},{av:'edtBR_Medication_RXName_Titleformat',ctrl:'BR_MEDICATION_RXNAME',prop:'Titleformat'},{av:'edtBR_Medication_RXName_Title',ctrl:'BR_MEDICATION_RXNAME',prop:'Title'},{av:'edtBR_Medication_AdmitStartDate_Titleformat',ctrl:'BR_MEDICATION_ADMITSTARTDATE',prop:'Titleformat'},{av:'edtBR_Medication_AdmitStartDate_Title',ctrl:'BR_MEDICATION_ADMITSTARTDATE',prop:'Title'},{av:'edtBR_Medication_AdmitEndDate_Titleformat',ctrl:'BR_MEDICATION_ADMITENDDATE',prop:'Titleformat'},{av:'edtBR_Medication_AdmitEndDate_Title',ctrl:'BR_MEDICATION_ADMITENDDATE',prop:'Title'},{av:'edtBR_Medication_RXDose_Titleformat',ctrl:'BR_MEDICATION_RXDOSE',prop:'Titleformat'},{av:'edtBR_Medication_RXDose_Title',ctrl:'BR_MEDICATION_RXDOSE',prop:'Title'},{av:'edtBR_Medication_RXCode_Titleformat',ctrl:'BR_MEDICATION_RXCODE',prop:'Titleformat'},{av:'edtBR_Medication_RXCode_Title',ctrl:'BR_MEDICATION_RXCODE',prop:'Title'},{av:'AV60GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV61GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV62GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV69IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'edtavDisplay_Visible',ctrl:'vDISPLAY',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_MEDICATION_RXCODE.ONOPTIONCLICKED","{handler:'E18422',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18ddo_BR_MedicationIDTitleControlIdToReplace',fld:'vDDO_BR_MEDICATIONIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Medication_RXNameTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV44ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_ADMITSTARTDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV46ddo_BR_Medication_AdmitEndDateTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_ADMITENDDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_Medication_RXDoseTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXDOSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Medication_RXCodeTitleControlIdToReplace',fld:'vDDO_BR_MEDICATION_RXCODETITLECONTROLIDTOREPLACE',pic:''},{av:'AV75Pgmname',fld:'vPGMNAME',pic:''},{av:'AV69IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'sPrefix'},{av:'Ddo_br_medication_rxcode_Activeeventkey',ctrl:'DDO_BR_MEDICATION_RXCODE',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_MEDICATION_RXCODE.ONOPTIONCLICKED",",oparms:[{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_medication_rxcode_Sortedstatus',ctrl:'DDO_BR_MEDICATION_RXCODE',prop:'SortedStatus'},{av:'AV17BR_MedicationIDTitleFilterData',fld:'vBR_MEDICATIONIDTITLEFILTERDATA',pic:''},{av:'AV21BR_Medication_RXNameTitleFilterData',fld:'vBR_MEDICATION_RXNAMETITLEFILTERDATA',pic:''},{av:'AV43BR_Medication_AdmitStartDateTitleFilterData',fld:'vBR_MEDICATION_ADMITSTARTDATETITLEFILTERDATA',pic:''},{av:'AV45BR_Medication_AdmitEndDateTitleFilterData',fld:'vBR_MEDICATION_ADMITENDDATETITLEFILTERDATA',pic:''},{av:'AV27BR_Medication_RXDoseTitleFilterData',fld:'vBR_MEDICATION_RXDOSETITLEFILTERDATA',pic:''},{av:'AV23BR_Medication_RXCodeTitleFilterData',fld:'vBR_MEDICATION_RXCODETITLEFILTERDATA',pic:''},{av:'edtBR_MedicationID_Titleformat',ctrl:'BR_MEDICATIONID',prop:'Titleformat'},{av:'edtBR_MedicationID_Title',ctrl:'BR_MEDICATIONID',prop:'Title'},{av:'edtBR_Medication_RXName_Titleformat',ctrl:'BR_MEDICATION_RXNAME',prop:'Titleformat'},{av:'edtBR_Medication_RXName_Title',ctrl:'BR_MEDICATION_RXNAME',prop:'Title'},{av:'edtBR_Medication_AdmitStartDate_Titleformat',ctrl:'BR_MEDICATION_ADMITSTARTDATE',prop:'Titleformat'},{av:'edtBR_Medication_AdmitStartDate_Title',ctrl:'BR_MEDICATION_ADMITSTARTDATE',prop:'Title'},{av:'edtBR_Medication_AdmitEndDate_Titleformat',ctrl:'BR_MEDICATION_ADMITENDDATE',prop:'Titleformat'},{av:'edtBR_Medication_AdmitEndDate_Title',ctrl:'BR_MEDICATION_ADMITENDDATE',prop:'Title'},{av:'edtBR_Medication_RXDose_Titleformat',ctrl:'BR_MEDICATION_RXDOSE',prop:'Titleformat'},{av:'edtBR_Medication_RXDose_Title',ctrl:'BR_MEDICATION_RXDOSE',prop:'Title'},{av:'edtBR_Medication_RXCode_Titleformat',ctrl:'BR_MEDICATION_RXCODE',prop:'Titleformat'},{av:'edtBR_Medication_RXCode_Title',ctrl:'BR_MEDICATION_RXCODE',prop:'Title'},{av:'AV60GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV61GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV62GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV69IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'edtavDisplay_Visible',ctrl:'vDISPLAY',prop:'Visible'}]}");
         setEventMetadata("GRID.LOAD","{handler:'E21422',iparms:[{av:'AV69IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'A119BR_MedicationID',fld:'BR_MEDICATIONID',pic:'ZZZZZZZZZZZZZZZZZZ'}]");
         setEventMetadata("GRID.LOAD",",oparms:[{av:'AV67Display',fld:'vDISPLAY',pic:''},{av:'edtavDisplay_Tooltiptext',ctrl:'vDISPLAY',prop:'Tooltiptext'},{av:'edtavDisplay_Link',ctrl:'vDISPLAY',prop:'Link'}]}");
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
         Ddo_br_medicationid_Activeeventkey = "";
         Ddo_br_medication_rxname_Activeeventkey = "";
         Ddo_br_medication_admitstartdate_Activeeventkey = "";
         Ddo_br_medication_admitenddate_Activeeventkey = "";
         Ddo_br_medication_rxdose_Activeeventkey = "";
         Ddo_br_medication_rxcode_Activeeventkey = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         sPrefix = "";
         AV18ddo_BR_MedicationIDTitleControlIdToReplace = "";
         AV22ddo_BR_Medication_RXNameTitleControlIdToReplace = "";
         AV44ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace = "";
         AV46ddo_BR_Medication_AdmitEndDateTitleControlIdToReplace = "";
         AV28ddo_BR_Medication_RXDoseTitleControlIdToReplace = "";
         AV24ddo_BR_Medication_RXCodeTitleControlIdToReplace = "";
         AV75Pgmname = "";
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         AV57DDO_TitleSettingsIcons = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV17BR_MedicationIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV21BR_Medication_RXNameTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV43BR_Medication_AdmitStartDateTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV45BR_Medication_AdmitEndDateTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV27BR_Medication_RXDoseTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV23BR_Medication_RXCodeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         Ddo_br_medicationid_Sortedstatus = "";
         Ddo_br_medication_rxname_Sortedstatus = "";
         Ddo_br_medication_admitstartdate_Sortedstatus = "";
         Ddo_br_medication_admitenddate_Sortedstatus = "";
         Ddo_br_medication_rxdose_Sortedstatus = "";
         Ddo_br_medication_rxcode_Sortedstatus = "";
         GX_FocusControl = "";
         GridContainer = new GXWebGrid( context);
         sStyleString = "";
         subGrid_Linesclass = "";
         GridColumn = new GXWebColumn();
         AV67Display = "";
         A121BR_Medication_RXName = "";
         A132BR_Medication_AdmitStartDate = DateTime.MinValue;
         A133BR_Medication_AdmitEndDate = DateTime.MinValue;
         A123BR_Medication_RXType = "";
         A122BR_Medication_RXCode = "";
         A125BR_Medication_RXUnit = "";
         A126BR_Medication_RXFrequency = "";
         A127BR_Medication_RXQuantity = "";
         A129BR_Medication_RXRoute = "";
         A130BR_Medication_PrescriptionDate = DateTime.MinValue;
         A131BR_Medication_InpatientChemo = "";
         ucGridpaginationbar = new GXUserControl();
         ucDdo_br_medicationid = new GXUserControl();
         TempTags = "";
         ClassString = "";
         StyleString = "";
         ucDdo_br_medication_rxname = new GXUserControl();
         ucDdo_br_medication_admitstartdate = new GXUserControl();
         ucDdo_br_medication_admitenddate = new GXUserControl();
         ucDdo_br_medication_rxdose = new GXUserControl();
         ucDdo_br_medication_rxcode = new GXUserControl();
         ucWorkwithplusutilities1 = new GXUserControl();
         Form = new GXWebForm();
         sXEvt = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV74Display_GXI = "";
         scmdbuf = "";
         H00422_A19BR_EncounterID = new long[1] ;
         H00422_A131BR_Medication_InpatientChemo = new String[] {""} ;
         H00422_n131BR_Medication_InpatientChemo = new bool[] {false} ;
         H00422_A130BR_Medication_PrescriptionDate = new DateTime[] {DateTime.MinValue} ;
         H00422_n130BR_Medication_PrescriptionDate = new bool[] {false} ;
         H00422_A129BR_Medication_RXRoute = new String[] {""} ;
         H00422_n129BR_Medication_RXRoute = new bool[] {false} ;
         H00422_A128BR_Medication_RXDaysSupply = new decimal[1] ;
         H00422_n128BR_Medication_RXDaysSupply = new bool[] {false} ;
         H00422_A127BR_Medication_RXQuantity = new String[] {""} ;
         H00422_n127BR_Medication_RXQuantity = new bool[] {false} ;
         H00422_A126BR_Medication_RXFrequency = new String[] {""} ;
         H00422_n126BR_Medication_RXFrequency = new bool[] {false} ;
         H00422_A125BR_Medication_RXUnit = new String[] {""} ;
         H00422_n125BR_Medication_RXUnit = new bool[] {false} ;
         H00422_A122BR_Medication_RXCode = new String[] {""} ;
         H00422_n122BR_Medication_RXCode = new bool[] {false} ;
         H00422_A124BR_Medication_RXDose = new decimal[1] ;
         H00422_n124BR_Medication_RXDose = new bool[] {false} ;
         H00422_A123BR_Medication_RXType = new String[] {""} ;
         H00422_n123BR_Medication_RXType = new bool[] {false} ;
         H00422_A133BR_Medication_AdmitEndDate = new DateTime[] {DateTime.MinValue} ;
         H00422_n133BR_Medication_AdmitEndDate = new bool[] {false} ;
         H00422_A132BR_Medication_AdmitStartDate = new DateTime[] {DateTime.MinValue} ;
         H00422_n132BR_Medication_AdmitStartDate = new bool[] {false} ;
         H00422_A121BR_Medication_RXName = new String[] {""} ;
         H00422_n121BR_Medication_RXName = new bool[] {false} ;
         H00422_A119BR_MedicationID = new long[1] ;
         H00423_AGRID_nRecordCount = new long[1] ;
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV6WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         GridRow = new GXWebRow();
         AV16Session = context.GetSession();
         AV12GridState = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState(context);
         AV10TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV9HTTPRequest = new GxHttpRequest( context);
         AV11TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sCtrlAV8BR_EncounterID = "";
         sImgUrl = "";
         ROClassString = "";
         GXCCtl = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_encountercheckbr_medicationwc__default(),
            new Object[][] {
                new Object[] {
               H00422_A19BR_EncounterID, H00422_A131BR_Medication_InpatientChemo, H00422_n131BR_Medication_InpatientChemo, H00422_A130BR_Medication_PrescriptionDate, H00422_n130BR_Medication_PrescriptionDate, H00422_A129BR_Medication_RXRoute, H00422_n129BR_Medication_RXRoute, H00422_A128BR_Medication_RXDaysSupply, H00422_n128BR_Medication_RXDaysSupply, H00422_A127BR_Medication_RXQuantity,
               H00422_n127BR_Medication_RXQuantity, H00422_A126BR_Medication_RXFrequency, H00422_n126BR_Medication_RXFrequency, H00422_A125BR_Medication_RXUnit, H00422_n125BR_Medication_RXUnit, H00422_A122BR_Medication_RXCode, H00422_n122BR_Medication_RXCode, H00422_A124BR_Medication_RXDose, H00422_n124BR_Medication_RXDose, H00422_A123BR_Medication_RXType,
               H00422_n123BR_Medication_RXType, H00422_A133BR_Medication_AdmitEndDate, H00422_n133BR_Medication_AdmitEndDate, H00422_A132BR_Medication_AdmitStartDate, H00422_n132BR_Medication_AdmitStartDate, H00422_A121BR_Medication_RXName, H00422_n121BR_Medication_RXName, H00422_A119BR_MedicationID
               }
               , new Object[] {
               H00423_AGRID_nRecordCount
               }
            }
         );
         AV75Pgmname = "BR_EncounterCheckBR_MedicationWC";
         /* GeneXus formulas. */
         AV75Pgmname = "BR_EncounterCheckBR_MedicationWC";
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
      private short edtBR_MedicationID_Titleformat ;
      private short edtBR_Medication_RXName_Titleformat ;
      private short edtBR_Medication_AdmitStartDate_Titleformat ;
      private short edtBR_Medication_AdmitEndDate_Titleformat ;
      private short edtBR_Medication_RXDose_Titleformat ;
      private short edtBR_Medication_RXCode_Titleformat ;
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
      private int edtavDdo_br_medicationidtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_medication_rxnametitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_medication_admitstartdatetitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_medication_admitenddatetitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_medication_rxdosetitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_medication_rxcodetitlecontrolidtoreplace_Visible ;
      private int edtBR_EncounterID_Visible ;
      private int edtavOrderedby_Visible ;
      private int edtavOrdereddsc_Visible ;
      private int subGrid_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int AV59PageToGo ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private long AV8BR_EncounterID ;
      private long wcpOAV8BR_EncounterID ;
      private long GRID_nFirstRecordOnPage ;
      private long AV60GridCurrentPage ;
      private long AV62GridRecordCount ;
      private long AV61GridPageSize ;
      private long A119BR_MedicationID ;
      private long A19BR_EncounterID ;
      private long GRID_nCurrentRecord ;
      private long GRID_nRecordCount ;
      private decimal A124BR_Medication_RXDose ;
      private decimal A128BR_Medication_RXDaysSupply ;
      private String Gridpaginationbar_Selectedpage ;
      private String Ddo_br_medicationid_Activeeventkey ;
      private String Ddo_br_medication_rxname_Activeeventkey ;
      private String Ddo_br_medication_admitstartdate_Activeeventkey ;
      private String Ddo_br_medication_admitenddate_Activeeventkey ;
      private String Ddo_br_medication_rxdose_Activeeventkey ;
      private String Ddo_br_medication_rxcode_Activeeventkey ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sPrefix ;
      private String sCompPrefix ;
      private String sSFPrefix ;
      private String sGXsfl_12_idx="0001" ;
      private String AV75Pgmname ;
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
      private String Ddo_br_medicationid_Caption ;
      private String Ddo_br_medicationid_Tooltip ;
      private String Ddo_br_medicationid_Cls ;
      private String Ddo_br_medicationid_Dropdownoptionstype ;
      private String Ddo_br_medicationid_Titlecontrolidtoreplace ;
      private String Ddo_br_medicationid_Sortedstatus ;
      private String Ddo_br_medicationid_Sortasc ;
      private String Ddo_br_medicationid_Sortdsc ;
      private String Ddo_br_medicationid_Searchbuttontext ;
      private String Ddo_br_medication_rxname_Caption ;
      private String Ddo_br_medication_rxname_Tooltip ;
      private String Ddo_br_medication_rxname_Cls ;
      private String Ddo_br_medication_rxname_Dropdownoptionstype ;
      private String Ddo_br_medication_rxname_Titlecontrolidtoreplace ;
      private String Ddo_br_medication_rxname_Sortedstatus ;
      private String Ddo_br_medication_rxname_Sortasc ;
      private String Ddo_br_medication_rxname_Sortdsc ;
      private String Ddo_br_medication_rxname_Searchbuttontext ;
      private String Ddo_br_medication_admitstartdate_Caption ;
      private String Ddo_br_medication_admitstartdate_Tooltip ;
      private String Ddo_br_medication_admitstartdate_Cls ;
      private String Ddo_br_medication_admitstartdate_Dropdownoptionstype ;
      private String Ddo_br_medication_admitstartdate_Titlecontrolidtoreplace ;
      private String Ddo_br_medication_admitstartdate_Sortedstatus ;
      private String Ddo_br_medication_admitstartdate_Sortasc ;
      private String Ddo_br_medication_admitstartdate_Sortdsc ;
      private String Ddo_br_medication_admitstartdate_Searchbuttontext ;
      private String Ddo_br_medication_admitenddate_Caption ;
      private String Ddo_br_medication_admitenddate_Tooltip ;
      private String Ddo_br_medication_admitenddate_Cls ;
      private String Ddo_br_medication_admitenddate_Dropdownoptionstype ;
      private String Ddo_br_medication_admitenddate_Titlecontrolidtoreplace ;
      private String Ddo_br_medication_admitenddate_Sortedstatus ;
      private String Ddo_br_medication_admitenddate_Sortasc ;
      private String Ddo_br_medication_admitenddate_Sortdsc ;
      private String Ddo_br_medication_admitenddate_Searchbuttontext ;
      private String Ddo_br_medication_rxdose_Caption ;
      private String Ddo_br_medication_rxdose_Tooltip ;
      private String Ddo_br_medication_rxdose_Cls ;
      private String Ddo_br_medication_rxdose_Dropdownoptionstype ;
      private String Ddo_br_medication_rxdose_Titlecontrolidtoreplace ;
      private String Ddo_br_medication_rxdose_Sortedstatus ;
      private String Ddo_br_medication_rxdose_Sortasc ;
      private String Ddo_br_medication_rxdose_Sortdsc ;
      private String Ddo_br_medication_rxdose_Searchbuttontext ;
      private String Ddo_br_medication_rxcode_Caption ;
      private String Ddo_br_medication_rxcode_Tooltip ;
      private String Ddo_br_medication_rxcode_Cls ;
      private String Ddo_br_medication_rxcode_Dropdownoptionstype ;
      private String Ddo_br_medication_rxcode_Titlecontrolidtoreplace ;
      private String Ddo_br_medication_rxcode_Sortedstatus ;
      private String Ddo_br_medication_rxcode_Sortasc ;
      private String Ddo_br_medication_rxcode_Sortdsc ;
      private String Ddo_br_medication_rxcode_Searchbuttontext ;
      private String GX_FocusControl ;
      private String divLayoutmaintable_Internalname ;
      private String divTablegridheader_Internalname ;
      private String divGridtablewithpaginationbar_Internalname ;
      private String sStyleString ;
      private String subGrid_Internalname ;
      private String subGrid_Class ;
      private String subGrid_Linesclass ;
      private String edtBR_MedicationID_Title ;
      private String edtBR_Medication_RXName_Title ;
      private String edtBR_Medication_AdmitStartDate_Title ;
      private String edtBR_Medication_AdmitEndDate_Title ;
      private String edtBR_Medication_RXDose_Title ;
      private String edtBR_Medication_RXCode_Title ;
      private String subGrid_Header ;
      private String edtavDisplay_Link ;
      private String edtavDisplay_Tooltiptext ;
      private String divHtml_gridpaginationbar_Internalname ;
      private String Gridpaginationbar_Internalname ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String Ddo_br_medicationid_Internalname ;
      private String TempTags ;
      private String ClassString ;
      private String StyleString ;
      private String edtavDdo_br_medicationidtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_medication_rxname_Internalname ;
      private String edtavDdo_br_medication_rxnametitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_medication_admitstartdate_Internalname ;
      private String edtavDdo_br_medication_admitstartdatetitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_medication_admitenddate_Internalname ;
      private String edtavDdo_br_medication_admitenddatetitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_medication_rxdose_Internalname ;
      private String edtavDdo_br_medication_rxdosetitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_medication_rxcode_Internalname ;
      private String edtavDdo_br_medication_rxcodetitlecontrolidtoreplace_Internalname ;
      private String edtBR_EncounterID_Internalname ;
      private String edtBR_EncounterID_Jsonclick ;
      private String Workwithplusutilities1_Internalname ;
      private String edtavOrderedby_Internalname ;
      private String edtavOrderedby_Jsonclick ;
      private String edtavOrdereddsc_Internalname ;
      private String edtavOrdereddsc_Jsonclick ;
      private String sXEvt ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavDisplay_Internalname ;
      private String edtBR_MedicationID_Internalname ;
      private String edtBR_Medication_RXName_Internalname ;
      private String edtBR_Medication_AdmitStartDate_Internalname ;
      private String edtBR_Medication_AdmitEndDate_Internalname ;
      private String edtBR_Medication_RXType_Internalname ;
      private String edtBR_Medication_RXDose_Internalname ;
      private String edtBR_Medication_RXCode_Internalname ;
      private String edtBR_Medication_RXUnit_Internalname ;
      private String edtBR_Medication_RXFrequency_Internalname ;
      private String edtBR_Medication_RXQuantity_Internalname ;
      private String edtBR_Medication_RXDaysSupply_Internalname ;
      private String edtBR_Medication_RXRoute_Internalname ;
      private String edtBR_Medication_PrescriptionDate_Internalname ;
      private String cmbBR_Medication_InpatientChemo_Internalname ;
      private String scmdbuf ;
      private String sCtrlAV8BR_EncounterID ;
      private String sGXsfl_12_fel_idx="0001" ;
      private String sImgUrl ;
      private String ROClassString ;
      private String edtBR_MedicationID_Jsonclick ;
      private String edtBR_Medication_RXName_Jsonclick ;
      private String edtBR_Medication_AdmitStartDate_Jsonclick ;
      private String edtBR_Medication_AdmitEndDate_Jsonclick ;
      private String edtBR_Medication_RXType_Jsonclick ;
      private String edtBR_Medication_RXDose_Jsonclick ;
      private String edtBR_Medication_RXCode_Jsonclick ;
      private String edtBR_Medication_RXUnit_Jsonclick ;
      private String edtBR_Medication_RXFrequency_Jsonclick ;
      private String edtBR_Medication_RXQuantity_Jsonclick ;
      private String edtBR_Medication_RXDaysSupply_Jsonclick ;
      private String edtBR_Medication_RXRoute_Jsonclick ;
      private String edtBR_Medication_PrescriptionDate_Jsonclick ;
      private String GXCCtl ;
      private String cmbBR_Medication_InpatientChemo_Jsonclick ;
      private DateTime A132BR_Medication_AdmitStartDate ;
      private DateTime A133BR_Medication_AdmitEndDate ;
      private DateTime A130BR_Medication_PrescriptionDate ;
      private bool entryPointCalled ;
      private bool AV15OrderedDsc ;
      private bool AV69IsAuthorized_Display ;
      private bool toggleJsOutput ;
      private bool Gridpaginationbar_Showfirst ;
      private bool Gridpaginationbar_Showprevious ;
      private bool Gridpaginationbar_Shownext ;
      private bool Gridpaginationbar_Showlast ;
      private bool Gridpaginationbar_Rowsperpageselector ;
      private bool Ddo_br_medicationid_Includesortasc ;
      private bool Ddo_br_medicationid_Includesortdsc ;
      private bool Ddo_br_medicationid_Includefilter ;
      private bool Ddo_br_medicationid_Includedatalist ;
      private bool Ddo_br_medication_rxname_Includesortasc ;
      private bool Ddo_br_medication_rxname_Includesortdsc ;
      private bool Ddo_br_medication_rxname_Includefilter ;
      private bool Ddo_br_medication_rxname_Includedatalist ;
      private bool Ddo_br_medication_admitstartdate_Includesortasc ;
      private bool Ddo_br_medication_admitstartdate_Includesortdsc ;
      private bool Ddo_br_medication_admitstartdate_Includefilter ;
      private bool Ddo_br_medication_admitstartdate_Includedatalist ;
      private bool Ddo_br_medication_admitenddate_Includesortasc ;
      private bool Ddo_br_medication_admitenddate_Includesortdsc ;
      private bool Ddo_br_medication_admitenddate_Includefilter ;
      private bool Ddo_br_medication_admitenddate_Includedatalist ;
      private bool Ddo_br_medication_rxdose_Includesortasc ;
      private bool Ddo_br_medication_rxdose_Includesortdsc ;
      private bool Ddo_br_medication_rxdose_Includefilter ;
      private bool Ddo_br_medication_rxdose_Includedatalist ;
      private bool Ddo_br_medication_rxcode_Includesortasc ;
      private bool Ddo_br_medication_rxcode_Includesortdsc ;
      private bool Ddo_br_medication_rxcode_Includefilter ;
      private bool Ddo_br_medication_rxcode_Includedatalist ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_12_Refreshing=false ;
      private bool n121BR_Medication_RXName ;
      private bool n132BR_Medication_AdmitStartDate ;
      private bool n133BR_Medication_AdmitEndDate ;
      private bool n123BR_Medication_RXType ;
      private bool n124BR_Medication_RXDose ;
      private bool n122BR_Medication_RXCode ;
      private bool n125BR_Medication_RXUnit ;
      private bool n126BR_Medication_RXFrequency ;
      private bool n127BR_Medication_RXQuantity ;
      private bool n128BR_Medication_RXDaysSupply ;
      private bool n129BR_Medication_RXRoute ;
      private bool n130BR_Medication_PrescriptionDate ;
      private bool n131BR_Medication_InpatientChemo ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool gx_refresh_fired ;
      private bool GXt_boolean2 ;
      private bool AV67Display_IsBlob ;
      private String AV18ddo_BR_MedicationIDTitleControlIdToReplace ;
      private String AV22ddo_BR_Medication_RXNameTitleControlIdToReplace ;
      private String AV44ddo_BR_Medication_AdmitStartDateTitleControlIdToReplace ;
      private String AV46ddo_BR_Medication_AdmitEndDateTitleControlIdToReplace ;
      private String AV28ddo_BR_Medication_RXDoseTitleControlIdToReplace ;
      private String AV24ddo_BR_Medication_RXCodeTitleControlIdToReplace ;
      private String A121BR_Medication_RXName ;
      private String A123BR_Medication_RXType ;
      private String A122BR_Medication_RXCode ;
      private String A125BR_Medication_RXUnit ;
      private String A126BR_Medication_RXFrequency ;
      private String A127BR_Medication_RXQuantity ;
      private String A129BR_Medication_RXRoute ;
      private String A131BR_Medication_InpatientChemo ;
      private String AV74Display_GXI ;
      private String AV67Display ;
      private IGxSession AV16Session ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private GXUserControl ucGridpaginationbar ;
      private GXUserControl ucDdo_br_medicationid ;
      private GXUserControl ucDdo_br_medication_rxname ;
      private GXUserControl ucDdo_br_medication_admitstartdate ;
      private GXUserControl ucDdo_br_medication_admitenddate ;
      private GXUserControl ucDdo_br_medication_rxdose ;
      private GXUserControl ucDdo_br_medication_rxcode ;
      private GXUserControl ucWorkwithplusutilities1 ;
      private GXWebForm Form ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbBR_Medication_InpatientChemo ;
      private IDataStoreProvider pr_default ;
      private long[] H00422_A19BR_EncounterID ;
      private String[] H00422_A131BR_Medication_InpatientChemo ;
      private bool[] H00422_n131BR_Medication_InpatientChemo ;
      private DateTime[] H00422_A130BR_Medication_PrescriptionDate ;
      private bool[] H00422_n130BR_Medication_PrescriptionDate ;
      private String[] H00422_A129BR_Medication_RXRoute ;
      private bool[] H00422_n129BR_Medication_RXRoute ;
      private decimal[] H00422_A128BR_Medication_RXDaysSupply ;
      private bool[] H00422_n128BR_Medication_RXDaysSupply ;
      private String[] H00422_A127BR_Medication_RXQuantity ;
      private bool[] H00422_n127BR_Medication_RXQuantity ;
      private String[] H00422_A126BR_Medication_RXFrequency ;
      private bool[] H00422_n126BR_Medication_RXFrequency ;
      private String[] H00422_A125BR_Medication_RXUnit ;
      private bool[] H00422_n125BR_Medication_RXUnit ;
      private String[] H00422_A122BR_Medication_RXCode ;
      private bool[] H00422_n122BR_Medication_RXCode ;
      private decimal[] H00422_A124BR_Medication_RXDose ;
      private bool[] H00422_n124BR_Medication_RXDose ;
      private String[] H00422_A123BR_Medication_RXType ;
      private bool[] H00422_n123BR_Medication_RXType ;
      private DateTime[] H00422_A133BR_Medication_AdmitEndDate ;
      private bool[] H00422_n133BR_Medication_AdmitEndDate ;
      private DateTime[] H00422_A132BR_Medication_AdmitStartDate ;
      private bool[] H00422_n132BR_Medication_AdmitStartDate ;
      private String[] H00422_A121BR_Medication_RXName ;
      private bool[] H00422_n121BR_Medication_RXName ;
      private long[] H00422_A119BR_MedicationID ;
      private long[] H00423_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV9HTTPRequest ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV17BR_MedicationIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV21BR_Medication_RXNameTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV43BR_Medication_AdmitStartDateTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV45BR_Medication_AdmitEndDateTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV27BR_Medication_RXDoseTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV23BR_Medication_RXCodeTitleFilterData ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV10TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute AV11TrnContextAtt ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV12GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons AV57DDO_TitleSettingsIcons ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 ;
   }

   public class br_encountercheckbr_medicationwc__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H00422( IGxContext context ,
                                             short AV14OrderedBy ,
                                             bool AV15OrderedDsc ,
                                             long A19BR_EncounterID ,
                                             long AV8BR_EncounterID )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int3 ;
         GXv_int3 = new short [4] ;
         Object[] GXv_Object4 ;
         GXv_Object4 = new Object [2] ;
         String sSelectString ;
         String sFromString ;
         String sOrderString ;
         sSelectString = " [BR_EncounterID], [BR_Medication_InpatientChemo], [BR_Medication_PrescriptionDate], [BR_Medication_RXRoute], [BR_Medication_RXDaysSupply], [BR_Medication_RXQuantity], [BR_Medication_RXFrequency], [BR_Medication_RXUnit], [BR_Medication_RXCode], [BR_Medication_RXDose], [BR_Medication_RXType], [BR_Medication_AdmitEndDate], [BR_Medication_AdmitStartDate], [BR_Medication_RXName], [BR_MedicationID]";
         sFromString = " FROM [BR_Medication] WITH (NOLOCK)";
         sOrderString = "";
         sWhereString = sWhereString + " WHERE ([BR_EncounterID] = @AV8BR_EncounterID)";
         if ( ( AV14OrderedBy == 1 ) && ! AV15OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_MedicationID] DESC";
         }
         else if ( ( AV14OrderedBy == 1 ) && ( AV15OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_MedicationID]";
         }
         else if ( ( AV14OrderedBy == 2 ) && ! AV15OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_EncounterID], [BR_Medication_RXName]";
         }
         else if ( ( AV14OrderedBy == 2 ) && ( AV15OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_EncounterID] DESC, [BR_Medication_RXName] DESC";
         }
         else if ( ( AV14OrderedBy == 3 ) && ! AV15OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_EncounterID], [BR_Medication_AdmitStartDate]";
         }
         else if ( ( AV14OrderedBy == 3 ) && ( AV15OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_EncounterID] DESC, [BR_Medication_AdmitStartDate] DESC";
         }
         else if ( ( AV14OrderedBy == 4 ) && ! AV15OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_EncounterID], [BR_Medication_AdmitEndDate]";
         }
         else if ( ( AV14OrderedBy == 4 ) && ( AV15OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_EncounterID] DESC, [BR_Medication_AdmitEndDate] DESC";
         }
         else if ( ( AV14OrderedBy == 5 ) && ! AV15OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_EncounterID], [BR_Medication_RXDose]";
         }
         else if ( ( AV14OrderedBy == 5 ) && ( AV15OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_EncounterID] DESC, [BR_Medication_RXDose] DESC";
         }
         else if ( ( AV14OrderedBy == 6 ) && ! AV15OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_EncounterID], [BR_Medication_RXCode]";
         }
         else if ( ( AV14OrderedBy == 6 ) && ( AV15OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_EncounterID] DESC, [BR_Medication_RXCode] DESC";
         }
         else if ( true )
         {
            sOrderString = sOrderString + " ORDER BY [BR_MedicationID]";
         }
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object4[0] = scmdbuf;
         GXv_Object4[1] = GXv_int3;
         return GXv_Object4 ;
      }

      protected Object[] conditional_H00423( IGxContext context ,
                                             short AV14OrderedBy ,
                                             bool AV15OrderedDsc ,
                                             long A19BR_EncounterID ,
                                             long AV8BR_EncounterID )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int5 ;
         GXv_int5 = new short [1] ;
         Object[] GXv_Object6 ;
         GXv_Object6 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM [BR_Medication] WITH (NOLOCK)";
         scmdbuf = scmdbuf + " WHERE ([BR_EncounterID] = @AV8BR_EncounterID)";
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
         else if ( ( AV14OrderedBy == 5 ) && ! AV15OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV14OrderedBy == 5 ) && ( AV15OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV14OrderedBy == 6 ) && ! AV15OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV14OrderedBy == 6 ) && ( AV15OrderedDsc ) )
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
                     return conditional_H00422(context, (short)dynConstraints[0] , (bool)dynConstraints[1] , (long)dynConstraints[2] , (long)dynConstraints[3] );
               case 1 :
                     return conditional_H00423(context, (short)dynConstraints[0] , (bool)dynConstraints[1] , (long)dynConstraints[2] , (long)dynConstraints[3] );
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
          Object[] prmH00422 ;
          prmH00422 = new Object[] {
          new Object[] {"@AV8BR_EncounterID",SqlDbType.Decimal,18,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH00423 ;
          prmH00423 = new Object[] {
          new Object[] {"@AV8BR_EncounterID",SqlDbType.Decimal,18,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H00422", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00422,11,0,true,false )
             ,new CursorDef("H00423", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00423,1,0,true,false )
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
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[2])[0] = rslt.wasNull(2);
                ((DateTime[]) buf[3])[0] = rslt.getGXDate(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((decimal[]) buf[7])[0] = rslt.getDecimal(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((String[]) buf[9])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[10])[0] = rslt.wasNull(6);
                ((String[]) buf[11])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[12])[0] = rslt.wasNull(7);
                ((String[]) buf[13])[0] = rslt.getVarchar(8) ;
                ((bool[]) buf[14])[0] = rslt.wasNull(8);
                ((String[]) buf[15])[0] = rslt.getVarchar(9) ;
                ((bool[]) buf[16])[0] = rslt.wasNull(9);
                ((decimal[]) buf[17])[0] = rslt.getDecimal(10) ;
                ((bool[]) buf[18])[0] = rslt.wasNull(10);
                ((String[]) buf[19])[0] = rslt.getVarchar(11) ;
                ((bool[]) buf[20])[0] = rslt.wasNull(11);
                ((DateTime[]) buf[21])[0] = rslt.getGXDate(12) ;
                ((bool[]) buf[22])[0] = rslt.wasNull(12);
                ((DateTime[]) buf[23])[0] = rslt.getGXDate(13) ;
                ((bool[]) buf[24])[0] = rslt.wasNull(13);
                ((String[]) buf[25])[0] = rslt.getVarchar(14) ;
                ((bool[]) buf[26])[0] = rslt.wasNull(14);
                ((long[]) buf[27])[0] = rslt.getLong(15) ;
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
                   stmt.SetParameter(sIdx, (long)parms[4]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[5]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[6]);
                }
                if ( (short)parms[3] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (int)parms[7]);
                }
                return;
             case 1 :
                sIdx = 0;
                if ( (short)parms[0] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[1]);
                }
                return;
       }
    }

 }

}
