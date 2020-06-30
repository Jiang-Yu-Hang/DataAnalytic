/*
               File: BR_VitalPrompt
        Description: 选择生命体征
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:14:57.25
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
   public class br_vitalprompt : GXHttpHandler, System.Web.SessionState.IRequiresSessionState
   {
      public br_vitalprompt( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_vitalprompt( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( ref long aP0_InOutBR_VitalID )
      {
         this.AV8InOutBR_VitalID = aP0_InOutBR_VitalID;
         executePrivate();
         aP0_InOutBR_VitalID=this.AV8InOutBR_VitalID;
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
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
               AV10OrderedBy = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV11OrderedDsc = StringUtil.StrToBool( GetNextPar( ));
               AV13ddo_BR_VitalIDTitleControlIdToReplace = GetNextPar( );
               AV15ddo_BR_EncounterIDTitleControlIdToReplace = GetNextPar( );
               AV17ddo_BR_Information_PatientNoTitleControlIdToReplace = GetNextPar( );
               AV19ddo_BR_Vital_VitalIDTitleControlIdToReplace = GetNextPar( );
               AV21ddo_BR_Vital_MeasureDateTitleControlIdToReplace = GetNextPar( );
               AV23ddo_BR_Vital_TemperatureTitleControlIdToReplace = GetNextPar( );
               AV25ddo_BR_Vital_PulseTitleControlIdToReplace = GetNextPar( );
               AV27ddo_BR_Vital_RespirationTitleControlIdToReplace = GetNextPar( );
               AV29ddo_BR_Vital_SystolicTitleControlIdToReplace = GetNextPar( );
               AV31ddo_BR_Vital_DiastolicTitleControlIdToReplace = GetNextPar( );
               AV33ddo_BR_Vital_HeightTitleControlIdToReplace = GetNextPar( );
               AV35ddo_BR_Vital_WeightTitleControlIdToReplace = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid_refresh( subGrid_Rows, AV10OrderedBy, AV11OrderedDsc, AV13ddo_BR_VitalIDTitleControlIdToReplace, AV15ddo_BR_EncounterIDTitleControlIdToReplace, AV17ddo_BR_Information_PatientNoTitleControlIdToReplace, AV19ddo_BR_Vital_VitalIDTitleControlIdToReplace, AV21ddo_BR_Vital_MeasureDateTitleControlIdToReplace, AV23ddo_BR_Vital_TemperatureTitleControlIdToReplace, AV25ddo_BR_Vital_PulseTitleControlIdToReplace, AV27ddo_BR_Vital_RespirationTitleControlIdToReplace, AV29ddo_BR_Vital_SystolicTitleControlIdToReplace, AV31ddo_BR_Vital_DiastolicTitleControlIdToReplace, AV33ddo_BR_Vital_HeightTitleControlIdToReplace, AV35ddo_BR_Vital_WeightTitleControlIdToReplace) ;
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
               AV8InOutBR_VitalID = (long)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8InOutBR_VitalID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8InOutBR_VitalID), 18, 0)));
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
            PA622( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV44Pgmname = "BR_VitalPrompt";
               context.Gx_err = 0;
               WS622( ) ;
               if ( ! isAjaxCallMode( ) )
               {
                  WE622( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?202022815145747", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_vitalprompt.aspx") + "?" + UrlEncode("" +AV8InOutBR_VitalID)+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "GXH_vORDEREDBY", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10OrderedBy), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vORDEREDDSC", StringUtil.BoolToStr( AV11OrderedDsc));
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_12", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_12), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDCURRENTPAGE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV38GridCurrentPage), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDRECORDCOUNT", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV40GridRecordCount), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDPAGESIZE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV39GridPageSize), 10, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vDDO_TITLESETTINGSICONS", AV36DDO_TitleSettingsIcons);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vDDO_TITLESETTINGSICONS", AV36DDO_TitleSettingsIcons);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_VITALIDTITLEFILTERDATA", AV12BR_VitalIDTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_VITALIDTITLEFILTERDATA", AV12BR_VitalIDTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_ENCOUNTERIDTITLEFILTERDATA", AV14BR_EncounterIDTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_ENCOUNTERIDTITLEFILTERDATA", AV14BR_EncounterIDTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_INFORMATION_PATIENTNOTITLEFILTERDATA", AV16BR_Information_PatientNoTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_INFORMATION_PATIENTNOTITLEFILTERDATA", AV16BR_Information_PatientNoTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_VITAL_VITALIDTITLEFILTERDATA", AV18BR_Vital_VitalIDTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_VITAL_VITALIDTITLEFILTERDATA", AV18BR_Vital_VitalIDTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_VITAL_MEASUREDATETITLEFILTERDATA", AV20BR_Vital_MeasureDateTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_VITAL_MEASUREDATETITLEFILTERDATA", AV20BR_Vital_MeasureDateTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_VITAL_TEMPERATURETITLEFILTERDATA", AV22BR_Vital_TemperatureTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_VITAL_TEMPERATURETITLEFILTERDATA", AV22BR_Vital_TemperatureTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_VITAL_PULSETITLEFILTERDATA", AV24BR_Vital_PulseTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_VITAL_PULSETITLEFILTERDATA", AV24BR_Vital_PulseTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_VITAL_RESPIRATIONTITLEFILTERDATA", AV26BR_Vital_RespirationTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_VITAL_RESPIRATIONTITLEFILTERDATA", AV26BR_Vital_RespirationTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_VITAL_SYSTOLICTITLEFILTERDATA", AV28BR_Vital_SystolicTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_VITAL_SYSTOLICTITLEFILTERDATA", AV28BR_Vital_SystolicTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_VITAL_DIASTOLICTITLEFILTERDATA", AV30BR_Vital_DiastolicTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_VITAL_DIASTOLICTITLEFILTERDATA", AV30BR_Vital_DiastolicTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_VITAL_HEIGHTTITLEFILTERDATA", AV32BR_Vital_HeightTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_VITAL_HEIGHTTITLEFILTERDATA", AV32BR_Vital_HeightTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_VITAL_WEIGHTTITLEFILTERDATA", AV34BR_Vital_WeightTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_VITAL_WEIGHTTITLEFILTERDATA", AV34BR_Vital_WeightTitleFilterData);
         }
         GxWebStd.gx_hidden_field( context, "vINOUTBR_VITALID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8InOutBR_VitalID), 18, 0, ".", "")));
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
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITALID_Caption", StringUtil.RTrim( Ddo_br_vitalid_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITALID_Tooltip", StringUtil.RTrim( Ddo_br_vitalid_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITALID_Cls", StringUtil.RTrim( Ddo_br_vitalid_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITALID_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_vitalid_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITALID_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_vitalid_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITALID_Includesortasc", StringUtil.BoolToStr( Ddo_br_vitalid_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITALID_Includesortdsc", StringUtil.BoolToStr( Ddo_br_vitalid_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITALID_Sortedstatus", StringUtil.RTrim( Ddo_br_vitalid_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITALID_Includefilter", StringUtil.BoolToStr( Ddo_br_vitalid_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITALID_Includedatalist", StringUtil.BoolToStr( Ddo_br_vitalid_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITALID_Sortasc", StringUtil.RTrim( Ddo_br_vitalid_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITALID_Sortdsc", StringUtil.RTrim( Ddo_br_vitalid_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITALID_Searchbuttontext", StringUtil.RTrim( Ddo_br_vitalid_Searchbuttontext));
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
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_VITALID_Caption", StringUtil.RTrim( Ddo_br_vital_vitalid_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_VITALID_Tooltip", StringUtil.RTrim( Ddo_br_vital_vitalid_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_VITALID_Cls", StringUtil.RTrim( Ddo_br_vital_vitalid_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_VITALID_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_vital_vitalid_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_VITALID_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_vital_vitalid_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_VITALID_Includesortasc", StringUtil.BoolToStr( Ddo_br_vital_vitalid_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_VITALID_Includesortdsc", StringUtil.BoolToStr( Ddo_br_vital_vitalid_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_VITALID_Sortedstatus", StringUtil.RTrim( Ddo_br_vital_vitalid_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_VITALID_Includefilter", StringUtil.BoolToStr( Ddo_br_vital_vitalid_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_VITALID_Includedatalist", StringUtil.BoolToStr( Ddo_br_vital_vitalid_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_VITALID_Sortasc", StringUtil.RTrim( Ddo_br_vital_vitalid_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_VITALID_Sortdsc", StringUtil.RTrim( Ddo_br_vital_vitalid_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_VITALID_Searchbuttontext", StringUtil.RTrim( Ddo_br_vital_vitalid_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_MEASUREDATE_Caption", StringUtil.RTrim( Ddo_br_vital_measuredate_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_MEASUREDATE_Tooltip", StringUtil.RTrim( Ddo_br_vital_measuredate_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_MEASUREDATE_Cls", StringUtil.RTrim( Ddo_br_vital_measuredate_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_MEASUREDATE_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_vital_measuredate_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_MEASUREDATE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_vital_measuredate_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_MEASUREDATE_Includesortasc", StringUtil.BoolToStr( Ddo_br_vital_measuredate_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_MEASUREDATE_Includesortdsc", StringUtil.BoolToStr( Ddo_br_vital_measuredate_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_MEASUREDATE_Sortedstatus", StringUtil.RTrim( Ddo_br_vital_measuredate_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_MEASUREDATE_Includefilter", StringUtil.BoolToStr( Ddo_br_vital_measuredate_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_MEASUREDATE_Includedatalist", StringUtil.BoolToStr( Ddo_br_vital_measuredate_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_MEASUREDATE_Sortasc", StringUtil.RTrim( Ddo_br_vital_measuredate_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_MEASUREDATE_Sortdsc", StringUtil.RTrim( Ddo_br_vital_measuredate_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_MEASUREDATE_Searchbuttontext", StringUtil.RTrim( Ddo_br_vital_measuredate_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_TEMPERATURE_Caption", StringUtil.RTrim( Ddo_br_vital_temperature_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_TEMPERATURE_Tooltip", StringUtil.RTrim( Ddo_br_vital_temperature_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_TEMPERATURE_Cls", StringUtil.RTrim( Ddo_br_vital_temperature_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_TEMPERATURE_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_vital_temperature_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_TEMPERATURE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_vital_temperature_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_TEMPERATURE_Includesortasc", StringUtil.BoolToStr( Ddo_br_vital_temperature_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_TEMPERATURE_Includesortdsc", StringUtil.BoolToStr( Ddo_br_vital_temperature_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_TEMPERATURE_Sortedstatus", StringUtil.RTrim( Ddo_br_vital_temperature_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_TEMPERATURE_Includefilter", StringUtil.BoolToStr( Ddo_br_vital_temperature_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_TEMPERATURE_Includedatalist", StringUtil.BoolToStr( Ddo_br_vital_temperature_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_TEMPERATURE_Sortasc", StringUtil.RTrim( Ddo_br_vital_temperature_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_TEMPERATURE_Sortdsc", StringUtil.RTrim( Ddo_br_vital_temperature_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_TEMPERATURE_Searchbuttontext", StringUtil.RTrim( Ddo_br_vital_temperature_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_PULSE_Caption", StringUtil.RTrim( Ddo_br_vital_pulse_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_PULSE_Tooltip", StringUtil.RTrim( Ddo_br_vital_pulse_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_PULSE_Cls", StringUtil.RTrim( Ddo_br_vital_pulse_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_PULSE_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_vital_pulse_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_PULSE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_vital_pulse_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_PULSE_Includesortasc", StringUtil.BoolToStr( Ddo_br_vital_pulse_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_PULSE_Includesortdsc", StringUtil.BoolToStr( Ddo_br_vital_pulse_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_PULSE_Sortedstatus", StringUtil.RTrim( Ddo_br_vital_pulse_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_PULSE_Includefilter", StringUtil.BoolToStr( Ddo_br_vital_pulse_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_PULSE_Includedatalist", StringUtil.BoolToStr( Ddo_br_vital_pulse_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_PULSE_Sortasc", StringUtil.RTrim( Ddo_br_vital_pulse_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_PULSE_Sortdsc", StringUtil.RTrim( Ddo_br_vital_pulse_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_PULSE_Searchbuttontext", StringUtil.RTrim( Ddo_br_vital_pulse_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_RESPIRATION_Caption", StringUtil.RTrim( Ddo_br_vital_respiration_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_RESPIRATION_Tooltip", StringUtil.RTrim( Ddo_br_vital_respiration_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_RESPIRATION_Cls", StringUtil.RTrim( Ddo_br_vital_respiration_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_RESPIRATION_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_vital_respiration_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_RESPIRATION_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_vital_respiration_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_RESPIRATION_Includesortasc", StringUtil.BoolToStr( Ddo_br_vital_respiration_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_RESPIRATION_Includesortdsc", StringUtil.BoolToStr( Ddo_br_vital_respiration_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_RESPIRATION_Sortedstatus", StringUtil.RTrim( Ddo_br_vital_respiration_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_RESPIRATION_Includefilter", StringUtil.BoolToStr( Ddo_br_vital_respiration_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_RESPIRATION_Includedatalist", StringUtil.BoolToStr( Ddo_br_vital_respiration_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_RESPIRATION_Sortasc", StringUtil.RTrim( Ddo_br_vital_respiration_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_RESPIRATION_Sortdsc", StringUtil.RTrim( Ddo_br_vital_respiration_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_RESPIRATION_Searchbuttontext", StringUtil.RTrim( Ddo_br_vital_respiration_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_SYSTOLIC_Caption", StringUtil.RTrim( Ddo_br_vital_systolic_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_SYSTOLIC_Tooltip", StringUtil.RTrim( Ddo_br_vital_systolic_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_SYSTOLIC_Cls", StringUtil.RTrim( Ddo_br_vital_systolic_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_SYSTOLIC_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_vital_systolic_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_SYSTOLIC_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_vital_systolic_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_SYSTOLIC_Includesortasc", StringUtil.BoolToStr( Ddo_br_vital_systolic_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_SYSTOLIC_Includesortdsc", StringUtil.BoolToStr( Ddo_br_vital_systolic_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_SYSTOLIC_Sortedstatus", StringUtil.RTrim( Ddo_br_vital_systolic_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_SYSTOLIC_Includefilter", StringUtil.BoolToStr( Ddo_br_vital_systolic_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_SYSTOLIC_Includedatalist", StringUtil.BoolToStr( Ddo_br_vital_systolic_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_SYSTOLIC_Sortasc", StringUtil.RTrim( Ddo_br_vital_systolic_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_SYSTOLIC_Sortdsc", StringUtil.RTrim( Ddo_br_vital_systolic_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_SYSTOLIC_Searchbuttontext", StringUtil.RTrim( Ddo_br_vital_systolic_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_DIASTOLIC_Caption", StringUtil.RTrim( Ddo_br_vital_diastolic_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_DIASTOLIC_Tooltip", StringUtil.RTrim( Ddo_br_vital_diastolic_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_DIASTOLIC_Cls", StringUtil.RTrim( Ddo_br_vital_diastolic_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_DIASTOLIC_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_vital_diastolic_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_DIASTOLIC_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_vital_diastolic_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_DIASTOLIC_Includesortasc", StringUtil.BoolToStr( Ddo_br_vital_diastolic_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_DIASTOLIC_Includesortdsc", StringUtil.BoolToStr( Ddo_br_vital_diastolic_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_DIASTOLIC_Sortedstatus", StringUtil.RTrim( Ddo_br_vital_diastolic_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_DIASTOLIC_Includefilter", StringUtil.BoolToStr( Ddo_br_vital_diastolic_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_DIASTOLIC_Includedatalist", StringUtil.BoolToStr( Ddo_br_vital_diastolic_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_DIASTOLIC_Sortasc", StringUtil.RTrim( Ddo_br_vital_diastolic_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_DIASTOLIC_Sortdsc", StringUtil.RTrim( Ddo_br_vital_diastolic_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_DIASTOLIC_Searchbuttontext", StringUtil.RTrim( Ddo_br_vital_diastolic_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_HEIGHT_Caption", StringUtil.RTrim( Ddo_br_vital_height_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_HEIGHT_Tooltip", StringUtil.RTrim( Ddo_br_vital_height_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_HEIGHT_Cls", StringUtil.RTrim( Ddo_br_vital_height_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_HEIGHT_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_vital_height_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_HEIGHT_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_vital_height_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_HEIGHT_Includesortasc", StringUtil.BoolToStr( Ddo_br_vital_height_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_HEIGHT_Includesortdsc", StringUtil.BoolToStr( Ddo_br_vital_height_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_HEIGHT_Sortedstatus", StringUtil.RTrim( Ddo_br_vital_height_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_HEIGHT_Includefilter", StringUtil.BoolToStr( Ddo_br_vital_height_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_HEIGHT_Includedatalist", StringUtil.BoolToStr( Ddo_br_vital_height_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_HEIGHT_Sortasc", StringUtil.RTrim( Ddo_br_vital_height_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_HEIGHT_Sortdsc", StringUtil.RTrim( Ddo_br_vital_height_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_HEIGHT_Searchbuttontext", StringUtil.RTrim( Ddo_br_vital_height_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_WEIGHT_Caption", StringUtil.RTrim( Ddo_br_vital_weight_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_WEIGHT_Tooltip", StringUtil.RTrim( Ddo_br_vital_weight_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_WEIGHT_Cls", StringUtil.RTrim( Ddo_br_vital_weight_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_WEIGHT_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_vital_weight_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_WEIGHT_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_vital_weight_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_WEIGHT_Includesortasc", StringUtil.BoolToStr( Ddo_br_vital_weight_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_WEIGHT_Includesortdsc", StringUtil.BoolToStr( Ddo_br_vital_weight_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_WEIGHT_Sortedstatus", StringUtil.RTrim( Ddo_br_vital_weight_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_WEIGHT_Includefilter", StringUtil.BoolToStr( Ddo_br_vital_weight_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_WEIGHT_Includedatalist", StringUtil.BoolToStr( Ddo_br_vital_weight_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_WEIGHT_Sortasc", StringUtil.RTrim( Ddo_br_vital_weight_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_WEIGHT_Sortdsc", StringUtil.RTrim( Ddo_br_vital_weight_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_WEIGHT_Searchbuttontext", StringUtil.RTrim( Ddo_br_vital_weight_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITALID_Activeeventkey", StringUtil.RTrim( Ddo_br_vitalid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Activeeventkey", StringUtil.RTrim( Ddo_br_encounterid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Activeeventkey", StringUtil.RTrim( Ddo_br_information_patientno_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_VITALID_Activeeventkey", StringUtil.RTrim( Ddo_br_vital_vitalid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_MEASUREDATE_Activeeventkey", StringUtil.RTrim( Ddo_br_vital_measuredate_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_TEMPERATURE_Activeeventkey", StringUtil.RTrim( Ddo_br_vital_temperature_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_PULSE_Activeeventkey", StringUtil.RTrim( Ddo_br_vital_pulse_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_RESPIRATION_Activeeventkey", StringUtil.RTrim( Ddo_br_vital_respiration_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_SYSTOLIC_Activeeventkey", StringUtil.RTrim( Ddo_br_vital_systolic_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_DIASTOLIC_Activeeventkey", StringUtil.RTrim( Ddo_br_vital_diastolic_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_HEIGHT_Activeeventkey", StringUtil.RTrim( Ddo_br_vital_height_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_WEIGHT_Activeeventkey", StringUtil.RTrim( Ddo_br_vital_weight_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITALID_Activeeventkey", StringUtil.RTrim( Ddo_br_vitalid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Activeeventkey", StringUtil.RTrim( Ddo_br_encounterid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Activeeventkey", StringUtil.RTrim( Ddo_br_information_patientno_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_VITALID_Activeeventkey", StringUtil.RTrim( Ddo_br_vital_vitalid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_MEASUREDATE_Activeeventkey", StringUtil.RTrim( Ddo_br_vital_measuredate_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_TEMPERATURE_Activeeventkey", StringUtil.RTrim( Ddo_br_vital_temperature_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_PULSE_Activeeventkey", StringUtil.RTrim( Ddo_br_vital_pulse_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_RESPIRATION_Activeeventkey", StringUtil.RTrim( Ddo_br_vital_respiration_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_SYSTOLIC_Activeeventkey", StringUtil.RTrim( Ddo_br_vital_systolic_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_DIASTOLIC_Activeeventkey", StringUtil.RTrim( Ddo_br_vital_diastolic_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_HEIGHT_Activeeventkey", StringUtil.RTrim( Ddo_br_vital_height_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_VITAL_WEIGHT_Activeeventkey", StringUtil.RTrim( Ddo_br_vital_weight_Activeeventkey));
      }

      protected void RenderHtmlCloseForm622( )
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
         return "BR_VitalPrompt" ;
      }

      public override String GetPgmdesc( )
      {
         return "选择生命体征" ;
      }

      protected void WB620( )
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
               if ( edtBR_Vital_VitalID_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Vital_VitalID_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Vital_VitalID_Title) ;
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
               if ( edtBR_Vital_Temperature_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Vital_Temperature_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Vital_Temperature_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Vital_Pulse_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Vital_Pulse_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Vital_Pulse_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Vital_Respiration_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Vital_Respiration_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Vital_Respiration_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Vital_Systolic_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Vital_Systolic_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Vital_Systolic_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Vital_Diastolic_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Vital_Diastolic_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Vital_Diastolic_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Vital_Height_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Vital_Height_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Vital_Height_Title) ;
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
               GridColumn.AddObjectProperty("Value", context.convertURL( AV41Select));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavSelect_Tooltiptext));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A150BR_VitalID), 18, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_VitalID_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_VitalID_Titleformat), 4, 0, ".", "")));
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
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A151BR_Vital_VitalID), 10, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Vital_VitalID_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Vital_VitalID_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.localUtil.Format(A152BR_Vital_MeasureDate, "9999/99/99"));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Vital_MeasureDate_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Vital_MeasureDate_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A153BR_Vital_Temperature, 15, 5, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Vital_Temperature_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Vital_Temperature_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A154BR_Vital_Pulse, 15, 5, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Vital_Pulse_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Vital_Pulse_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A155BR_Vital_Respiration, 15, 5, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Vital_Respiration_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Vital_Respiration_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A156BR_Vital_Systolic, 15, 5, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Vital_Systolic_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Vital_Systolic_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A157BR_Vital_Diastolic, 15, 5, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Vital_Diastolic_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Vital_Diastolic_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A158BR_Vital_Height, 15, 5, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Vital_Height_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Vital_Height_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A159BR_Vital_Weight, 15, 5, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Vital_Weight_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Vital_Weight_Titleformat), 4, 0, ".", "")));
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
            ucGridpaginationbar.SetProperty("CurrentPage", AV38GridCurrentPage);
            ucGridpaginationbar.SetProperty("RecordCount", AV40GridRecordCount);
            ucGridpaginationbar.SetProperty("Page", AV39GridPageSize);
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
            ucDdo_br_vitalid.SetProperty("DropDownOptionsTitleSettingsIcons", AV36DDO_TitleSettingsIcons);
            ucDdo_br_vitalid.SetProperty("DropDownOptionsData", AV12BR_VitalIDTitleFilterData);
            ucDdo_br_vitalid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_vitalid_Internalname, "DDO_BR_VITALIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_vitalidtitlecontrolidtoreplace_Internalname, AV13ddo_BR_VitalIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,34);\"", 0, edtavDdo_br_vitalidtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_VitalPrompt.htm");
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
            ucDdo_br_encounterid.SetProperty("DropDownOptionsTitleSettingsIcons", AV36DDO_TitleSettingsIcons);
            ucDdo_br_encounterid.SetProperty("DropDownOptionsData", AV14BR_EncounterIDTitleFilterData);
            ucDdo_br_encounterid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_encounterid_Internalname, "DDO_BR_ENCOUNTERIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 36,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_encounteridtitlecontrolidtoreplace_Internalname, AV15ddo_BR_EncounterIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,36);\"", 0, edtavDdo_br_encounteridtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_VitalPrompt.htm");
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
            ucDdo_br_information_patientno.SetProperty("DropDownOptionsTitleSettingsIcons", AV36DDO_TitleSettingsIcons);
            ucDdo_br_information_patientno.SetProperty("DropDownOptionsData", AV16BR_Information_PatientNoTitleFilterData);
            ucDdo_br_information_patientno.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_information_patientno_Internalname, "DDO_BR_INFORMATION_PATIENTNOContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_information_patientnotitlecontrolidtoreplace_Internalname, AV17ddo_BR_Information_PatientNoTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,38);\"", 0, edtavDdo_br_information_patientnotitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_VitalPrompt.htm");
            /* User Defined Control */
            ucDdo_br_vital_vitalid.SetProperty("Caption", Ddo_br_vital_vitalid_Caption);
            ucDdo_br_vital_vitalid.SetProperty("Tooltip", Ddo_br_vital_vitalid_Tooltip);
            ucDdo_br_vital_vitalid.SetProperty("Cls", Ddo_br_vital_vitalid_Cls);
            ucDdo_br_vital_vitalid.SetProperty("DropDownOptionsType", Ddo_br_vital_vitalid_Dropdownoptionstype);
            ucDdo_br_vital_vitalid.SetProperty("IncludeSortASC", Ddo_br_vital_vitalid_Includesortasc);
            ucDdo_br_vital_vitalid.SetProperty("IncludeSortDSC", Ddo_br_vital_vitalid_Includesortdsc);
            ucDdo_br_vital_vitalid.SetProperty("IncludeFilter", Ddo_br_vital_vitalid_Includefilter);
            ucDdo_br_vital_vitalid.SetProperty("IncludeDataList", Ddo_br_vital_vitalid_Includedatalist);
            ucDdo_br_vital_vitalid.SetProperty("SortASC", Ddo_br_vital_vitalid_Sortasc);
            ucDdo_br_vital_vitalid.SetProperty("SortDSC", Ddo_br_vital_vitalid_Sortdsc);
            ucDdo_br_vital_vitalid.SetProperty("SearchButtonText", Ddo_br_vital_vitalid_Searchbuttontext);
            ucDdo_br_vital_vitalid.SetProperty("DropDownOptionsTitleSettingsIcons", AV36DDO_TitleSettingsIcons);
            ucDdo_br_vital_vitalid.SetProperty("DropDownOptionsData", AV18BR_Vital_VitalIDTitleFilterData);
            ucDdo_br_vital_vitalid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_vital_vitalid_Internalname, "DDO_BR_VITAL_VITALIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 40,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_vital_vitalidtitlecontrolidtoreplace_Internalname, AV19ddo_BR_Vital_VitalIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,40);\"", 0, edtavDdo_br_vital_vitalidtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_VitalPrompt.htm");
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
            ucDdo_br_vital_measuredate.SetProperty("DropDownOptionsTitleSettingsIcons", AV36DDO_TitleSettingsIcons);
            ucDdo_br_vital_measuredate.SetProperty("DropDownOptionsData", AV20BR_Vital_MeasureDateTitleFilterData);
            ucDdo_br_vital_measuredate.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_vital_measuredate_Internalname, "DDO_BR_VITAL_MEASUREDATEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 42,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_vital_measuredatetitlecontrolidtoreplace_Internalname, AV21ddo_BR_Vital_MeasureDateTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,42);\"", 0, edtavDdo_br_vital_measuredatetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_VitalPrompt.htm");
            /* User Defined Control */
            ucDdo_br_vital_temperature.SetProperty("Caption", Ddo_br_vital_temperature_Caption);
            ucDdo_br_vital_temperature.SetProperty("Tooltip", Ddo_br_vital_temperature_Tooltip);
            ucDdo_br_vital_temperature.SetProperty("Cls", Ddo_br_vital_temperature_Cls);
            ucDdo_br_vital_temperature.SetProperty("DropDownOptionsType", Ddo_br_vital_temperature_Dropdownoptionstype);
            ucDdo_br_vital_temperature.SetProperty("IncludeSortASC", Ddo_br_vital_temperature_Includesortasc);
            ucDdo_br_vital_temperature.SetProperty("IncludeSortDSC", Ddo_br_vital_temperature_Includesortdsc);
            ucDdo_br_vital_temperature.SetProperty("IncludeFilter", Ddo_br_vital_temperature_Includefilter);
            ucDdo_br_vital_temperature.SetProperty("IncludeDataList", Ddo_br_vital_temperature_Includedatalist);
            ucDdo_br_vital_temperature.SetProperty("SortASC", Ddo_br_vital_temperature_Sortasc);
            ucDdo_br_vital_temperature.SetProperty("SortDSC", Ddo_br_vital_temperature_Sortdsc);
            ucDdo_br_vital_temperature.SetProperty("SearchButtonText", Ddo_br_vital_temperature_Searchbuttontext);
            ucDdo_br_vital_temperature.SetProperty("DropDownOptionsTitleSettingsIcons", AV36DDO_TitleSettingsIcons);
            ucDdo_br_vital_temperature.SetProperty("DropDownOptionsData", AV22BR_Vital_TemperatureTitleFilterData);
            ucDdo_br_vital_temperature.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_vital_temperature_Internalname, "DDO_BR_VITAL_TEMPERATUREContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_vital_temperaturetitlecontrolidtoreplace_Internalname, AV23ddo_BR_Vital_TemperatureTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,44);\"", 0, edtavDdo_br_vital_temperaturetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_VitalPrompt.htm");
            /* User Defined Control */
            ucDdo_br_vital_pulse.SetProperty("Caption", Ddo_br_vital_pulse_Caption);
            ucDdo_br_vital_pulse.SetProperty("Tooltip", Ddo_br_vital_pulse_Tooltip);
            ucDdo_br_vital_pulse.SetProperty("Cls", Ddo_br_vital_pulse_Cls);
            ucDdo_br_vital_pulse.SetProperty("DropDownOptionsType", Ddo_br_vital_pulse_Dropdownoptionstype);
            ucDdo_br_vital_pulse.SetProperty("IncludeSortASC", Ddo_br_vital_pulse_Includesortasc);
            ucDdo_br_vital_pulse.SetProperty("IncludeSortDSC", Ddo_br_vital_pulse_Includesortdsc);
            ucDdo_br_vital_pulse.SetProperty("IncludeFilter", Ddo_br_vital_pulse_Includefilter);
            ucDdo_br_vital_pulse.SetProperty("IncludeDataList", Ddo_br_vital_pulse_Includedatalist);
            ucDdo_br_vital_pulse.SetProperty("SortASC", Ddo_br_vital_pulse_Sortasc);
            ucDdo_br_vital_pulse.SetProperty("SortDSC", Ddo_br_vital_pulse_Sortdsc);
            ucDdo_br_vital_pulse.SetProperty("SearchButtonText", Ddo_br_vital_pulse_Searchbuttontext);
            ucDdo_br_vital_pulse.SetProperty("DropDownOptionsTitleSettingsIcons", AV36DDO_TitleSettingsIcons);
            ucDdo_br_vital_pulse.SetProperty("DropDownOptionsData", AV24BR_Vital_PulseTitleFilterData);
            ucDdo_br_vital_pulse.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_vital_pulse_Internalname, "DDO_BR_VITAL_PULSEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_vital_pulsetitlecontrolidtoreplace_Internalname, AV25ddo_BR_Vital_PulseTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,46);\"", 0, edtavDdo_br_vital_pulsetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_VitalPrompt.htm");
            /* User Defined Control */
            ucDdo_br_vital_respiration.SetProperty("Caption", Ddo_br_vital_respiration_Caption);
            ucDdo_br_vital_respiration.SetProperty("Tooltip", Ddo_br_vital_respiration_Tooltip);
            ucDdo_br_vital_respiration.SetProperty("Cls", Ddo_br_vital_respiration_Cls);
            ucDdo_br_vital_respiration.SetProperty("DropDownOptionsType", Ddo_br_vital_respiration_Dropdownoptionstype);
            ucDdo_br_vital_respiration.SetProperty("IncludeSortASC", Ddo_br_vital_respiration_Includesortasc);
            ucDdo_br_vital_respiration.SetProperty("IncludeSortDSC", Ddo_br_vital_respiration_Includesortdsc);
            ucDdo_br_vital_respiration.SetProperty("IncludeFilter", Ddo_br_vital_respiration_Includefilter);
            ucDdo_br_vital_respiration.SetProperty("IncludeDataList", Ddo_br_vital_respiration_Includedatalist);
            ucDdo_br_vital_respiration.SetProperty("SortASC", Ddo_br_vital_respiration_Sortasc);
            ucDdo_br_vital_respiration.SetProperty("SortDSC", Ddo_br_vital_respiration_Sortdsc);
            ucDdo_br_vital_respiration.SetProperty("SearchButtonText", Ddo_br_vital_respiration_Searchbuttontext);
            ucDdo_br_vital_respiration.SetProperty("DropDownOptionsTitleSettingsIcons", AV36DDO_TitleSettingsIcons);
            ucDdo_br_vital_respiration.SetProperty("DropDownOptionsData", AV26BR_Vital_RespirationTitleFilterData);
            ucDdo_br_vital_respiration.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_vital_respiration_Internalname, "DDO_BR_VITAL_RESPIRATIONContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_vital_respirationtitlecontrolidtoreplace_Internalname, AV27ddo_BR_Vital_RespirationTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,48);\"", 0, edtavDdo_br_vital_respirationtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_VitalPrompt.htm");
            /* User Defined Control */
            ucDdo_br_vital_systolic.SetProperty("Caption", Ddo_br_vital_systolic_Caption);
            ucDdo_br_vital_systolic.SetProperty("Tooltip", Ddo_br_vital_systolic_Tooltip);
            ucDdo_br_vital_systolic.SetProperty("Cls", Ddo_br_vital_systolic_Cls);
            ucDdo_br_vital_systolic.SetProperty("DropDownOptionsType", Ddo_br_vital_systolic_Dropdownoptionstype);
            ucDdo_br_vital_systolic.SetProperty("IncludeSortASC", Ddo_br_vital_systolic_Includesortasc);
            ucDdo_br_vital_systolic.SetProperty("IncludeSortDSC", Ddo_br_vital_systolic_Includesortdsc);
            ucDdo_br_vital_systolic.SetProperty("IncludeFilter", Ddo_br_vital_systolic_Includefilter);
            ucDdo_br_vital_systolic.SetProperty("IncludeDataList", Ddo_br_vital_systolic_Includedatalist);
            ucDdo_br_vital_systolic.SetProperty("SortASC", Ddo_br_vital_systolic_Sortasc);
            ucDdo_br_vital_systolic.SetProperty("SortDSC", Ddo_br_vital_systolic_Sortdsc);
            ucDdo_br_vital_systolic.SetProperty("SearchButtonText", Ddo_br_vital_systolic_Searchbuttontext);
            ucDdo_br_vital_systolic.SetProperty("DropDownOptionsTitleSettingsIcons", AV36DDO_TitleSettingsIcons);
            ucDdo_br_vital_systolic.SetProperty("DropDownOptionsData", AV28BR_Vital_SystolicTitleFilterData);
            ucDdo_br_vital_systolic.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_vital_systolic_Internalname, "DDO_BR_VITAL_SYSTOLICContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 50,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_vital_systolictitlecontrolidtoreplace_Internalname, AV29ddo_BR_Vital_SystolicTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,50);\"", 0, edtavDdo_br_vital_systolictitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_VitalPrompt.htm");
            /* User Defined Control */
            ucDdo_br_vital_diastolic.SetProperty("Caption", Ddo_br_vital_diastolic_Caption);
            ucDdo_br_vital_diastolic.SetProperty("Tooltip", Ddo_br_vital_diastolic_Tooltip);
            ucDdo_br_vital_diastolic.SetProperty("Cls", Ddo_br_vital_diastolic_Cls);
            ucDdo_br_vital_diastolic.SetProperty("DropDownOptionsType", Ddo_br_vital_diastolic_Dropdownoptionstype);
            ucDdo_br_vital_diastolic.SetProperty("IncludeSortASC", Ddo_br_vital_diastolic_Includesortasc);
            ucDdo_br_vital_diastolic.SetProperty("IncludeSortDSC", Ddo_br_vital_diastolic_Includesortdsc);
            ucDdo_br_vital_diastolic.SetProperty("IncludeFilter", Ddo_br_vital_diastolic_Includefilter);
            ucDdo_br_vital_diastolic.SetProperty("IncludeDataList", Ddo_br_vital_diastolic_Includedatalist);
            ucDdo_br_vital_diastolic.SetProperty("SortASC", Ddo_br_vital_diastolic_Sortasc);
            ucDdo_br_vital_diastolic.SetProperty("SortDSC", Ddo_br_vital_diastolic_Sortdsc);
            ucDdo_br_vital_diastolic.SetProperty("SearchButtonText", Ddo_br_vital_diastolic_Searchbuttontext);
            ucDdo_br_vital_diastolic.SetProperty("DropDownOptionsTitleSettingsIcons", AV36DDO_TitleSettingsIcons);
            ucDdo_br_vital_diastolic.SetProperty("DropDownOptionsData", AV30BR_Vital_DiastolicTitleFilterData);
            ucDdo_br_vital_diastolic.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_vital_diastolic_Internalname, "DDO_BR_VITAL_DIASTOLICContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 52,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_vital_diastolictitlecontrolidtoreplace_Internalname, AV31ddo_BR_Vital_DiastolicTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,52);\"", 0, edtavDdo_br_vital_diastolictitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_VitalPrompt.htm");
            /* User Defined Control */
            ucDdo_br_vital_height.SetProperty("Caption", Ddo_br_vital_height_Caption);
            ucDdo_br_vital_height.SetProperty("Tooltip", Ddo_br_vital_height_Tooltip);
            ucDdo_br_vital_height.SetProperty("Cls", Ddo_br_vital_height_Cls);
            ucDdo_br_vital_height.SetProperty("DropDownOptionsType", Ddo_br_vital_height_Dropdownoptionstype);
            ucDdo_br_vital_height.SetProperty("IncludeSortASC", Ddo_br_vital_height_Includesortasc);
            ucDdo_br_vital_height.SetProperty("IncludeSortDSC", Ddo_br_vital_height_Includesortdsc);
            ucDdo_br_vital_height.SetProperty("IncludeFilter", Ddo_br_vital_height_Includefilter);
            ucDdo_br_vital_height.SetProperty("IncludeDataList", Ddo_br_vital_height_Includedatalist);
            ucDdo_br_vital_height.SetProperty("SortASC", Ddo_br_vital_height_Sortasc);
            ucDdo_br_vital_height.SetProperty("SortDSC", Ddo_br_vital_height_Sortdsc);
            ucDdo_br_vital_height.SetProperty("SearchButtonText", Ddo_br_vital_height_Searchbuttontext);
            ucDdo_br_vital_height.SetProperty("DropDownOptionsTitleSettingsIcons", AV36DDO_TitleSettingsIcons);
            ucDdo_br_vital_height.SetProperty("DropDownOptionsData", AV32BR_Vital_HeightTitleFilterData);
            ucDdo_br_vital_height.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_vital_height_Internalname, "DDO_BR_VITAL_HEIGHTContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_vital_heighttitlecontrolidtoreplace_Internalname, AV33ddo_BR_Vital_HeightTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,54);\"", 0, edtavDdo_br_vital_heighttitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_VitalPrompt.htm");
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
            ucDdo_br_vital_weight.SetProperty("DropDownOptionsTitleSettingsIcons", AV36DDO_TitleSettingsIcons);
            ucDdo_br_vital_weight.SetProperty("DropDownOptionsData", AV34BR_Vital_WeightTitleFilterData);
            ucDdo_br_vital_weight.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_vital_weight_Internalname, "DDO_BR_VITAL_WEIGHTContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 56,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_vital_weighttitlecontrolidtoreplace_Internalname, AV35ddo_BR_Vital_WeightTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,56);\"", 0, edtavDdo_br_vital_weighttitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_VitalPrompt.htm");
            /* User Defined Control */
            ucWorkwithplusutilities1.Render(context, "dvelop.workwithplusutilities", Workwithplusutilities1_Internalname, "WORKWITHPLUSUTILITIES1Container");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'" + sGXsfl_12_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrderedby_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10OrderedBy), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV10OrderedBy), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,58);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrderedby_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrderedby_Visible, 1, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_VitalPrompt.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 59,'',false,'" + sGXsfl_12_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrdereddsc_Internalname, StringUtil.BoolToStr( AV11OrderedDsc), StringUtil.BoolToStr( AV11OrderedDsc), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,59);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrdereddsc_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrdereddsc_Visible, 1, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, 0, 0, true, "", "right", false, "HLP_BR_VitalPrompt.htm");
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

      protected void START622( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_0-127771", 0) ;
            Form.Meta.addItem("description", "选择生命体征", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP620( ) ;
      }

      protected void WS622( )
      {
         START622( ) ;
         EVT622( ) ;
      }

      protected void EVT622( )
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
                           E11622 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEROWSPERPAGE") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E12622 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_VITALID.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E13622 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_ENCOUNTERID.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E14622 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_INFORMATION_PATIENTNO.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E15622 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_VITAL_VITALID.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E16622 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_VITAL_MEASUREDATE.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E17622 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_VITAL_TEMPERATURE.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E18622 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_VITAL_PULSE.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E19622 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_VITAL_RESPIRATION.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E20622 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_VITAL_SYSTOLIC.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E21622 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_VITAL_DIASTOLIC.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E22622 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_VITAL_HEIGHT.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E23622 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_VITAL_WEIGHT.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E24622 ();
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
                           AV41Select = cgiGet( edtavSelect_Internalname);
                           context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSelect_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV41Select)) ? AV45Select_GXI : context.convertURL( context.PathToRelativeUrl( AV41Select))), !bGXsfl_12_Refreshing);
                           context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSelect_Internalname, "SrcSet", context.GetImageSrcSet( AV41Select), true);
                           A150BR_VitalID = (long)(context.localUtil.CToN( cgiGet( edtBR_VitalID_Internalname), ".", ","));
                           A19BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( edtBR_EncounterID_Internalname), ".", ","));
                           A36BR_Information_PatientNo = cgiGet( edtBR_Information_PatientNo_Internalname);
                           n36BR_Information_PatientNo = false;
                           A151BR_Vital_VitalID = (long)(context.localUtil.CToN( cgiGet( edtBR_Vital_VitalID_Internalname), ".", ","));
                           n151BR_Vital_VitalID = false;
                           A152BR_Vital_MeasureDate = DateTimeUtil.ResetTime(context.localUtil.CToT( cgiGet( edtBR_Vital_MeasureDate_Internalname), 0));
                           n152BR_Vital_MeasureDate = false;
                           A153BR_Vital_Temperature = context.localUtil.CToN( cgiGet( edtBR_Vital_Temperature_Internalname), ".", ",");
                           n153BR_Vital_Temperature = false;
                           A154BR_Vital_Pulse = context.localUtil.CToN( cgiGet( edtBR_Vital_Pulse_Internalname), ".", ",");
                           n154BR_Vital_Pulse = false;
                           A155BR_Vital_Respiration = context.localUtil.CToN( cgiGet( edtBR_Vital_Respiration_Internalname), ".", ",");
                           n155BR_Vital_Respiration = false;
                           A156BR_Vital_Systolic = context.localUtil.CToN( cgiGet( edtBR_Vital_Systolic_Internalname), ".", ",");
                           n156BR_Vital_Systolic = false;
                           A157BR_Vital_Diastolic = context.localUtil.CToN( cgiGet( edtBR_Vital_Diastolic_Internalname), ".", ",");
                           n157BR_Vital_Diastolic = false;
                           A158BR_Vital_Height = context.localUtil.CToN( cgiGet( edtBR_Vital_Height_Internalname), ".", ",");
                           n158BR_Vital_Height = false;
                           A159BR_Vital_Weight = context.localUtil.CToN( cgiGet( edtBR_Vital_Weight_Internalname), ".", ",");
                           n159BR_Vital_Weight = false;
                           sEvtType = StringUtil.Right( sEvt, 1);
                           if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                           {
                              sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                              if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 /* Execute user event: Start */
                                 E25622 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 /* Execute user event: Refresh */
                                 E26622 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "GRID.LOAD") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 E27622 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    Rfr0gs = false;
                                    /* Set Refresh If Orderedby Changed */
                                    if ( ( context.localUtil.CToN( cgiGet( "GXH_vORDEREDBY"), ".", ",") != Convert.ToDecimal( AV10OrderedBy )) )
                                    {
                                       Rfr0gs = true;
                                    }
                                    /* Set Refresh If Ordereddsc Changed */
                                    if ( StringUtil.StrToBool( cgiGet( "GXH_vORDEREDDSC")) != AV11OrderedDsc )
                                    {
                                       Rfr0gs = true;
                                    }
                                    if ( ! Rfr0gs )
                                    {
                                       /* Execute user event: Enter */
                                       E28622 ();
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

      protected void WE622( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm622( ) ;
            }
         }
      }

      protected void PA622( )
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
               GX_FocusControl = edtavDdo_br_vitalidtitlecontrolidtoreplace_Internalname;
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
                                       short AV10OrderedBy ,
                                       bool AV11OrderedDsc ,
                                       String AV13ddo_BR_VitalIDTitleControlIdToReplace ,
                                       String AV15ddo_BR_EncounterIDTitleControlIdToReplace ,
                                       String AV17ddo_BR_Information_PatientNoTitleControlIdToReplace ,
                                       String AV19ddo_BR_Vital_VitalIDTitleControlIdToReplace ,
                                       String AV21ddo_BR_Vital_MeasureDateTitleControlIdToReplace ,
                                       String AV23ddo_BR_Vital_TemperatureTitleControlIdToReplace ,
                                       String AV25ddo_BR_Vital_PulseTitleControlIdToReplace ,
                                       String AV27ddo_BR_Vital_RespirationTitleControlIdToReplace ,
                                       String AV29ddo_BR_Vital_SystolicTitleControlIdToReplace ,
                                       String AV31ddo_BR_Vital_DiastolicTitleControlIdToReplace ,
                                       String AV33ddo_BR_Vital_HeightTitleControlIdToReplace ,
                                       String AV35ddo_BR_Vital_WeightTitleControlIdToReplace )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GRID_nCurrentRecord = 0;
         RF622( ) ;
         /* End function gxgrGrid_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_BR_VITALID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A150BR_VitalID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, "BR_VITALID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A150BR_VitalID), 18, 0, ".", "")));
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
         RF622( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV44Pgmname = "BR_VitalPrompt";
         context.Gx_err = 0;
      }

      protected void RF622( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridContainer.ClearRows();
         }
         wbStart = 12;
         /* Execute user event: Refresh */
         E26622 ();
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
                                                 AV10OrderedBy ,
                                                 AV11OrderedDsc } ,
                                                 new int[]{
                                                 TypeConstants.SHORT, TypeConstants.BOOLEAN
                                                 }
            } ) ;
            /* Using cursor H00622 */
            pr_default.execute(0, new Object[] {GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_12_idx = 1;
            sGXsfl_12_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_12_idx), 4, 0)), 4, "0");
            SubsflControlProps_122( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < subGrid_Recordsperpage( ) ) ) ) )
            {
               A85BR_Information_ID = H00622_A85BR_Information_ID[0];
               n85BR_Information_ID = H00622_n85BR_Information_ID[0];
               A159BR_Vital_Weight = H00622_A159BR_Vital_Weight[0];
               n159BR_Vital_Weight = H00622_n159BR_Vital_Weight[0];
               A158BR_Vital_Height = H00622_A158BR_Vital_Height[0];
               n158BR_Vital_Height = H00622_n158BR_Vital_Height[0];
               A157BR_Vital_Diastolic = H00622_A157BR_Vital_Diastolic[0];
               n157BR_Vital_Diastolic = H00622_n157BR_Vital_Diastolic[0];
               A156BR_Vital_Systolic = H00622_A156BR_Vital_Systolic[0];
               n156BR_Vital_Systolic = H00622_n156BR_Vital_Systolic[0];
               A155BR_Vital_Respiration = H00622_A155BR_Vital_Respiration[0];
               n155BR_Vital_Respiration = H00622_n155BR_Vital_Respiration[0];
               A154BR_Vital_Pulse = H00622_A154BR_Vital_Pulse[0];
               n154BR_Vital_Pulse = H00622_n154BR_Vital_Pulse[0];
               A153BR_Vital_Temperature = H00622_A153BR_Vital_Temperature[0];
               n153BR_Vital_Temperature = H00622_n153BR_Vital_Temperature[0];
               A152BR_Vital_MeasureDate = H00622_A152BR_Vital_MeasureDate[0];
               n152BR_Vital_MeasureDate = H00622_n152BR_Vital_MeasureDate[0];
               A151BR_Vital_VitalID = H00622_A151BR_Vital_VitalID[0];
               n151BR_Vital_VitalID = H00622_n151BR_Vital_VitalID[0];
               A36BR_Information_PatientNo = H00622_A36BR_Information_PatientNo[0];
               n36BR_Information_PatientNo = H00622_n36BR_Information_PatientNo[0];
               A19BR_EncounterID = H00622_A19BR_EncounterID[0];
               A150BR_VitalID = H00622_A150BR_VitalID[0];
               A85BR_Information_ID = H00622_A85BR_Information_ID[0];
               n85BR_Information_ID = H00622_n85BR_Information_ID[0];
               A36BR_Information_PatientNo = H00622_A36BR_Information_PatientNo[0];
               n36BR_Information_PatientNo = H00622_n36BR_Information_PatientNo[0];
               E27622 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 12;
            WB620( ) ;
         }
         bGXsfl_12_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes622( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_BR_VITALID"+"_"+sGXsfl_12_idx, GetSecureSignedToken( sGXsfl_12_idx, context.localUtil.Format( (decimal)(A150BR_VitalID), "ZZZZZZZZZZZZZZZZZZ"), context));
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
                                              AV10OrderedBy ,
                                              AV11OrderedDsc } ,
                                              new int[]{
                                              TypeConstants.SHORT, TypeConstants.BOOLEAN
                                              }
         } ) ;
         /* Using cursor H00623 */
         pr_default.execute(1);
         GRID_nRecordCount = H00623_AGRID_nRecordCount[0];
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
            gxgrGrid_refresh( subGrid_Rows, AV10OrderedBy, AV11OrderedDsc, AV13ddo_BR_VitalIDTitleControlIdToReplace, AV15ddo_BR_EncounterIDTitleControlIdToReplace, AV17ddo_BR_Information_PatientNoTitleControlIdToReplace, AV19ddo_BR_Vital_VitalIDTitleControlIdToReplace, AV21ddo_BR_Vital_MeasureDateTitleControlIdToReplace, AV23ddo_BR_Vital_TemperatureTitleControlIdToReplace, AV25ddo_BR_Vital_PulseTitleControlIdToReplace, AV27ddo_BR_Vital_RespirationTitleControlIdToReplace, AV29ddo_BR_Vital_SystolicTitleControlIdToReplace, AV31ddo_BR_Vital_DiastolicTitleControlIdToReplace, AV33ddo_BR_Vital_HeightTitleControlIdToReplace, AV35ddo_BR_Vital_WeightTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV10OrderedBy, AV11OrderedDsc, AV13ddo_BR_VitalIDTitleControlIdToReplace, AV15ddo_BR_EncounterIDTitleControlIdToReplace, AV17ddo_BR_Information_PatientNoTitleControlIdToReplace, AV19ddo_BR_Vital_VitalIDTitleControlIdToReplace, AV21ddo_BR_Vital_MeasureDateTitleControlIdToReplace, AV23ddo_BR_Vital_TemperatureTitleControlIdToReplace, AV25ddo_BR_Vital_PulseTitleControlIdToReplace, AV27ddo_BR_Vital_RespirationTitleControlIdToReplace, AV29ddo_BR_Vital_SystolicTitleControlIdToReplace, AV31ddo_BR_Vital_DiastolicTitleControlIdToReplace, AV33ddo_BR_Vital_HeightTitleControlIdToReplace, AV35ddo_BR_Vital_WeightTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV10OrderedBy, AV11OrderedDsc, AV13ddo_BR_VitalIDTitleControlIdToReplace, AV15ddo_BR_EncounterIDTitleControlIdToReplace, AV17ddo_BR_Information_PatientNoTitleControlIdToReplace, AV19ddo_BR_Vital_VitalIDTitleControlIdToReplace, AV21ddo_BR_Vital_MeasureDateTitleControlIdToReplace, AV23ddo_BR_Vital_TemperatureTitleControlIdToReplace, AV25ddo_BR_Vital_PulseTitleControlIdToReplace, AV27ddo_BR_Vital_RespirationTitleControlIdToReplace, AV29ddo_BR_Vital_SystolicTitleControlIdToReplace, AV31ddo_BR_Vital_DiastolicTitleControlIdToReplace, AV33ddo_BR_Vital_HeightTitleControlIdToReplace, AV35ddo_BR_Vital_WeightTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV10OrderedBy, AV11OrderedDsc, AV13ddo_BR_VitalIDTitleControlIdToReplace, AV15ddo_BR_EncounterIDTitleControlIdToReplace, AV17ddo_BR_Information_PatientNoTitleControlIdToReplace, AV19ddo_BR_Vital_VitalIDTitleControlIdToReplace, AV21ddo_BR_Vital_MeasureDateTitleControlIdToReplace, AV23ddo_BR_Vital_TemperatureTitleControlIdToReplace, AV25ddo_BR_Vital_PulseTitleControlIdToReplace, AV27ddo_BR_Vital_RespirationTitleControlIdToReplace, AV29ddo_BR_Vital_SystolicTitleControlIdToReplace, AV31ddo_BR_Vital_DiastolicTitleControlIdToReplace, AV33ddo_BR_Vital_HeightTitleControlIdToReplace, AV35ddo_BR_Vital_WeightTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV10OrderedBy, AV11OrderedDsc, AV13ddo_BR_VitalIDTitleControlIdToReplace, AV15ddo_BR_EncounterIDTitleControlIdToReplace, AV17ddo_BR_Information_PatientNoTitleControlIdToReplace, AV19ddo_BR_Vital_VitalIDTitleControlIdToReplace, AV21ddo_BR_Vital_MeasureDateTitleControlIdToReplace, AV23ddo_BR_Vital_TemperatureTitleControlIdToReplace, AV25ddo_BR_Vital_PulseTitleControlIdToReplace, AV27ddo_BR_Vital_RespirationTitleControlIdToReplace, AV29ddo_BR_Vital_SystolicTitleControlIdToReplace, AV31ddo_BR_Vital_DiastolicTitleControlIdToReplace, AV33ddo_BR_Vital_HeightTitleControlIdToReplace, AV35ddo_BR_Vital_WeightTitleControlIdToReplace) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP620( )
      {
         /* Before Start, stand alone formulas. */
         AV44Pgmname = "BR_VitalPrompt";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E25622 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( "vDDO_TITLESETTINGSICONS"), AV36DDO_TitleSettingsIcons);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_VITALIDTITLEFILTERDATA"), AV12BR_VitalIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_ENCOUNTERIDTITLEFILTERDATA"), AV14BR_EncounterIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_INFORMATION_PATIENTNOTITLEFILTERDATA"), AV16BR_Information_PatientNoTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_VITAL_VITALIDTITLEFILTERDATA"), AV18BR_Vital_VitalIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_VITAL_MEASUREDATETITLEFILTERDATA"), AV20BR_Vital_MeasureDateTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_VITAL_TEMPERATURETITLEFILTERDATA"), AV22BR_Vital_TemperatureTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_VITAL_PULSETITLEFILTERDATA"), AV24BR_Vital_PulseTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_VITAL_RESPIRATIONTITLEFILTERDATA"), AV26BR_Vital_RespirationTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_VITAL_SYSTOLICTITLEFILTERDATA"), AV28BR_Vital_SystolicTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_VITAL_DIASTOLICTITLEFILTERDATA"), AV30BR_Vital_DiastolicTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_VITAL_HEIGHTTITLEFILTERDATA"), AV32BR_Vital_HeightTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_VITAL_WEIGHTTITLEFILTERDATA"), AV34BR_Vital_WeightTitleFilterData);
            /* Read variables values. */
            AV13ddo_BR_VitalIDTitleControlIdToReplace = cgiGet( edtavDdo_br_vitalidtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13ddo_BR_VitalIDTitleControlIdToReplace", AV13ddo_BR_VitalIDTitleControlIdToReplace);
            AV15ddo_BR_EncounterIDTitleControlIdToReplace = cgiGet( edtavDdo_br_encounteridtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15ddo_BR_EncounterIDTitleControlIdToReplace", AV15ddo_BR_EncounterIDTitleControlIdToReplace);
            AV17ddo_BR_Information_PatientNoTitleControlIdToReplace = cgiGet( edtavDdo_br_information_patientnotitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17ddo_BR_Information_PatientNoTitleControlIdToReplace", AV17ddo_BR_Information_PatientNoTitleControlIdToReplace);
            AV19ddo_BR_Vital_VitalIDTitleControlIdToReplace = cgiGet( edtavDdo_br_vital_vitalidtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19ddo_BR_Vital_VitalIDTitleControlIdToReplace", AV19ddo_BR_Vital_VitalIDTitleControlIdToReplace);
            AV21ddo_BR_Vital_MeasureDateTitleControlIdToReplace = cgiGet( edtavDdo_br_vital_measuredatetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21ddo_BR_Vital_MeasureDateTitleControlIdToReplace", AV21ddo_BR_Vital_MeasureDateTitleControlIdToReplace);
            AV23ddo_BR_Vital_TemperatureTitleControlIdToReplace = cgiGet( edtavDdo_br_vital_temperaturetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23ddo_BR_Vital_TemperatureTitleControlIdToReplace", AV23ddo_BR_Vital_TemperatureTitleControlIdToReplace);
            AV25ddo_BR_Vital_PulseTitleControlIdToReplace = cgiGet( edtavDdo_br_vital_pulsetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25ddo_BR_Vital_PulseTitleControlIdToReplace", AV25ddo_BR_Vital_PulseTitleControlIdToReplace);
            AV27ddo_BR_Vital_RespirationTitleControlIdToReplace = cgiGet( edtavDdo_br_vital_respirationtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27ddo_BR_Vital_RespirationTitleControlIdToReplace", AV27ddo_BR_Vital_RespirationTitleControlIdToReplace);
            AV29ddo_BR_Vital_SystolicTitleControlIdToReplace = cgiGet( edtavDdo_br_vital_systolictitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29ddo_BR_Vital_SystolicTitleControlIdToReplace", AV29ddo_BR_Vital_SystolicTitleControlIdToReplace);
            AV31ddo_BR_Vital_DiastolicTitleControlIdToReplace = cgiGet( edtavDdo_br_vital_diastolictitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31ddo_BR_Vital_DiastolicTitleControlIdToReplace", AV31ddo_BR_Vital_DiastolicTitleControlIdToReplace);
            AV33ddo_BR_Vital_HeightTitleControlIdToReplace = cgiGet( edtavDdo_br_vital_heighttitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33ddo_BR_Vital_HeightTitleControlIdToReplace", AV33ddo_BR_Vital_HeightTitleControlIdToReplace);
            AV35ddo_BR_Vital_WeightTitleControlIdToReplace = cgiGet( edtavDdo_br_vital_weighttitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV35ddo_BR_Vital_WeightTitleControlIdToReplace", AV35ddo_BR_Vital_WeightTitleControlIdToReplace);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavOrderedby_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavOrderedby_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vORDEREDBY");
               GX_FocusControl = edtavOrderedby_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV10OrderedBy = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            }
            else
            {
               AV10OrderedBy = (short)(context.localUtil.CToN( cgiGet( edtavOrderedby_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            }
            AV11OrderedDsc = StringUtil.StrToBool( cgiGet( edtavOrdereddsc_Internalname));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            /* Read saved values. */
            nRC_GXsfl_12 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_12"), ".", ","));
            AV38GridCurrentPage = (long)(context.localUtil.CToN( cgiGet( "vGRIDCURRENTPAGE"), ".", ","));
            AV40GridRecordCount = (long)(context.localUtil.CToN( cgiGet( "vGRIDRECORDCOUNT"), ".", ","));
            AV39GridPageSize = (long)(context.localUtil.CToN( cgiGet( "vGRIDPAGESIZE"), ".", ","));
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
            Ddo_br_vitalid_Caption = cgiGet( "DDO_BR_VITALID_Caption");
            Ddo_br_vitalid_Tooltip = cgiGet( "DDO_BR_VITALID_Tooltip");
            Ddo_br_vitalid_Cls = cgiGet( "DDO_BR_VITALID_Cls");
            Ddo_br_vitalid_Dropdownoptionstype = cgiGet( "DDO_BR_VITALID_Dropdownoptionstype");
            Ddo_br_vitalid_Titlecontrolidtoreplace = cgiGet( "DDO_BR_VITALID_Titlecontrolidtoreplace");
            Ddo_br_vitalid_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_VITALID_Includesortasc"));
            Ddo_br_vitalid_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_VITALID_Includesortdsc"));
            Ddo_br_vitalid_Sortedstatus = cgiGet( "DDO_BR_VITALID_Sortedstatus");
            Ddo_br_vitalid_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_VITALID_Includefilter"));
            Ddo_br_vitalid_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_VITALID_Includedatalist"));
            Ddo_br_vitalid_Sortasc = cgiGet( "DDO_BR_VITALID_Sortasc");
            Ddo_br_vitalid_Sortdsc = cgiGet( "DDO_BR_VITALID_Sortdsc");
            Ddo_br_vitalid_Searchbuttontext = cgiGet( "DDO_BR_VITALID_Searchbuttontext");
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
            Ddo_br_vital_vitalid_Caption = cgiGet( "DDO_BR_VITAL_VITALID_Caption");
            Ddo_br_vital_vitalid_Tooltip = cgiGet( "DDO_BR_VITAL_VITALID_Tooltip");
            Ddo_br_vital_vitalid_Cls = cgiGet( "DDO_BR_VITAL_VITALID_Cls");
            Ddo_br_vital_vitalid_Dropdownoptionstype = cgiGet( "DDO_BR_VITAL_VITALID_Dropdownoptionstype");
            Ddo_br_vital_vitalid_Titlecontrolidtoreplace = cgiGet( "DDO_BR_VITAL_VITALID_Titlecontrolidtoreplace");
            Ddo_br_vital_vitalid_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_VITAL_VITALID_Includesortasc"));
            Ddo_br_vital_vitalid_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_VITAL_VITALID_Includesortdsc"));
            Ddo_br_vital_vitalid_Sortedstatus = cgiGet( "DDO_BR_VITAL_VITALID_Sortedstatus");
            Ddo_br_vital_vitalid_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_VITAL_VITALID_Includefilter"));
            Ddo_br_vital_vitalid_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_VITAL_VITALID_Includedatalist"));
            Ddo_br_vital_vitalid_Sortasc = cgiGet( "DDO_BR_VITAL_VITALID_Sortasc");
            Ddo_br_vital_vitalid_Sortdsc = cgiGet( "DDO_BR_VITAL_VITALID_Sortdsc");
            Ddo_br_vital_vitalid_Searchbuttontext = cgiGet( "DDO_BR_VITAL_VITALID_Searchbuttontext");
            Ddo_br_vital_measuredate_Caption = cgiGet( "DDO_BR_VITAL_MEASUREDATE_Caption");
            Ddo_br_vital_measuredate_Tooltip = cgiGet( "DDO_BR_VITAL_MEASUREDATE_Tooltip");
            Ddo_br_vital_measuredate_Cls = cgiGet( "DDO_BR_VITAL_MEASUREDATE_Cls");
            Ddo_br_vital_measuredate_Dropdownoptionstype = cgiGet( "DDO_BR_VITAL_MEASUREDATE_Dropdownoptionstype");
            Ddo_br_vital_measuredate_Titlecontrolidtoreplace = cgiGet( "DDO_BR_VITAL_MEASUREDATE_Titlecontrolidtoreplace");
            Ddo_br_vital_measuredate_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_VITAL_MEASUREDATE_Includesortasc"));
            Ddo_br_vital_measuredate_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_VITAL_MEASUREDATE_Includesortdsc"));
            Ddo_br_vital_measuredate_Sortedstatus = cgiGet( "DDO_BR_VITAL_MEASUREDATE_Sortedstatus");
            Ddo_br_vital_measuredate_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_VITAL_MEASUREDATE_Includefilter"));
            Ddo_br_vital_measuredate_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_VITAL_MEASUREDATE_Includedatalist"));
            Ddo_br_vital_measuredate_Sortasc = cgiGet( "DDO_BR_VITAL_MEASUREDATE_Sortasc");
            Ddo_br_vital_measuredate_Sortdsc = cgiGet( "DDO_BR_VITAL_MEASUREDATE_Sortdsc");
            Ddo_br_vital_measuredate_Searchbuttontext = cgiGet( "DDO_BR_VITAL_MEASUREDATE_Searchbuttontext");
            Ddo_br_vital_temperature_Caption = cgiGet( "DDO_BR_VITAL_TEMPERATURE_Caption");
            Ddo_br_vital_temperature_Tooltip = cgiGet( "DDO_BR_VITAL_TEMPERATURE_Tooltip");
            Ddo_br_vital_temperature_Cls = cgiGet( "DDO_BR_VITAL_TEMPERATURE_Cls");
            Ddo_br_vital_temperature_Dropdownoptionstype = cgiGet( "DDO_BR_VITAL_TEMPERATURE_Dropdownoptionstype");
            Ddo_br_vital_temperature_Titlecontrolidtoreplace = cgiGet( "DDO_BR_VITAL_TEMPERATURE_Titlecontrolidtoreplace");
            Ddo_br_vital_temperature_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_VITAL_TEMPERATURE_Includesortasc"));
            Ddo_br_vital_temperature_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_VITAL_TEMPERATURE_Includesortdsc"));
            Ddo_br_vital_temperature_Sortedstatus = cgiGet( "DDO_BR_VITAL_TEMPERATURE_Sortedstatus");
            Ddo_br_vital_temperature_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_VITAL_TEMPERATURE_Includefilter"));
            Ddo_br_vital_temperature_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_VITAL_TEMPERATURE_Includedatalist"));
            Ddo_br_vital_temperature_Sortasc = cgiGet( "DDO_BR_VITAL_TEMPERATURE_Sortasc");
            Ddo_br_vital_temperature_Sortdsc = cgiGet( "DDO_BR_VITAL_TEMPERATURE_Sortdsc");
            Ddo_br_vital_temperature_Searchbuttontext = cgiGet( "DDO_BR_VITAL_TEMPERATURE_Searchbuttontext");
            Ddo_br_vital_pulse_Caption = cgiGet( "DDO_BR_VITAL_PULSE_Caption");
            Ddo_br_vital_pulse_Tooltip = cgiGet( "DDO_BR_VITAL_PULSE_Tooltip");
            Ddo_br_vital_pulse_Cls = cgiGet( "DDO_BR_VITAL_PULSE_Cls");
            Ddo_br_vital_pulse_Dropdownoptionstype = cgiGet( "DDO_BR_VITAL_PULSE_Dropdownoptionstype");
            Ddo_br_vital_pulse_Titlecontrolidtoreplace = cgiGet( "DDO_BR_VITAL_PULSE_Titlecontrolidtoreplace");
            Ddo_br_vital_pulse_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_VITAL_PULSE_Includesortasc"));
            Ddo_br_vital_pulse_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_VITAL_PULSE_Includesortdsc"));
            Ddo_br_vital_pulse_Sortedstatus = cgiGet( "DDO_BR_VITAL_PULSE_Sortedstatus");
            Ddo_br_vital_pulse_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_VITAL_PULSE_Includefilter"));
            Ddo_br_vital_pulse_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_VITAL_PULSE_Includedatalist"));
            Ddo_br_vital_pulse_Sortasc = cgiGet( "DDO_BR_VITAL_PULSE_Sortasc");
            Ddo_br_vital_pulse_Sortdsc = cgiGet( "DDO_BR_VITAL_PULSE_Sortdsc");
            Ddo_br_vital_pulse_Searchbuttontext = cgiGet( "DDO_BR_VITAL_PULSE_Searchbuttontext");
            Ddo_br_vital_respiration_Caption = cgiGet( "DDO_BR_VITAL_RESPIRATION_Caption");
            Ddo_br_vital_respiration_Tooltip = cgiGet( "DDO_BR_VITAL_RESPIRATION_Tooltip");
            Ddo_br_vital_respiration_Cls = cgiGet( "DDO_BR_VITAL_RESPIRATION_Cls");
            Ddo_br_vital_respiration_Dropdownoptionstype = cgiGet( "DDO_BR_VITAL_RESPIRATION_Dropdownoptionstype");
            Ddo_br_vital_respiration_Titlecontrolidtoreplace = cgiGet( "DDO_BR_VITAL_RESPIRATION_Titlecontrolidtoreplace");
            Ddo_br_vital_respiration_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_VITAL_RESPIRATION_Includesortasc"));
            Ddo_br_vital_respiration_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_VITAL_RESPIRATION_Includesortdsc"));
            Ddo_br_vital_respiration_Sortedstatus = cgiGet( "DDO_BR_VITAL_RESPIRATION_Sortedstatus");
            Ddo_br_vital_respiration_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_VITAL_RESPIRATION_Includefilter"));
            Ddo_br_vital_respiration_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_VITAL_RESPIRATION_Includedatalist"));
            Ddo_br_vital_respiration_Sortasc = cgiGet( "DDO_BR_VITAL_RESPIRATION_Sortasc");
            Ddo_br_vital_respiration_Sortdsc = cgiGet( "DDO_BR_VITAL_RESPIRATION_Sortdsc");
            Ddo_br_vital_respiration_Searchbuttontext = cgiGet( "DDO_BR_VITAL_RESPIRATION_Searchbuttontext");
            Ddo_br_vital_systolic_Caption = cgiGet( "DDO_BR_VITAL_SYSTOLIC_Caption");
            Ddo_br_vital_systolic_Tooltip = cgiGet( "DDO_BR_VITAL_SYSTOLIC_Tooltip");
            Ddo_br_vital_systolic_Cls = cgiGet( "DDO_BR_VITAL_SYSTOLIC_Cls");
            Ddo_br_vital_systolic_Dropdownoptionstype = cgiGet( "DDO_BR_VITAL_SYSTOLIC_Dropdownoptionstype");
            Ddo_br_vital_systolic_Titlecontrolidtoreplace = cgiGet( "DDO_BR_VITAL_SYSTOLIC_Titlecontrolidtoreplace");
            Ddo_br_vital_systolic_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_VITAL_SYSTOLIC_Includesortasc"));
            Ddo_br_vital_systolic_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_VITAL_SYSTOLIC_Includesortdsc"));
            Ddo_br_vital_systolic_Sortedstatus = cgiGet( "DDO_BR_VITAL_SYSTOLIC_Sortedstatus");
            Ddo_br_vital_systolic_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_VITAL_SYSTOLIC_Includefilter"));
            Ddo_br_vital_systolic_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_VITAL_SYSTOLIC_Includedatalist"));
            Ddo_br_vital_systolic_Sortasc = cgiGet( "DDO_BR_VITAL_SYSTOLIC_Sortasc");
            Ddo_br_vital_systolic_Sortdsc = cgiGet( "DDO_BR_VITAL_SYSTOLIC_Sortdsc");
            Ddo_br_vital_systolic_Searchbuttontext = cgiGet( "DDO_BR_VITAL_SYSTOLIC_Searchbuttontext");
            Ddo_br_vital_diastolic_Caption = cgiGet( "DDO_BR_VITAL_DIASTOLIC_Caption");
            Ddo_br_vital_diastolic_Tooltip = cgiGet( "DDO_BR_VITAL_DIASTOLIC_Tooltip");
            Ddo_br_vital_diastolic_Cls = cgiGet( "DDO_BR_VITAL_DIASTOLIC_Cls");
            Ddo_br_vital_diastolic_Dropdownoptionstype = cgiGet( "DDO_BR_VITAL_DIASTOLIC_Dropdownoptionstype");
            Ddo_br_vital_diastolic_Titlecontrolidtoreplace = cgiGet( "DDO_BR_VITAL_DIASTOLIC_Titlecontrolidtoreplace");
            Ddo_br_vital_diastolic_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_VITAL_DIASTOLIC_Includesortasc"));
            Ddo_br_vital_diastolic_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_VITAL_DIASTOLIC_Includesortdsc"));
            Ddo_br_vital_diastolic_Sortedstatus = cgiGet( "DDO_BR_VITAL_DIASTOLIC_Sortedstatus");
            Ddo_br_vital_diastolic_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_VITAL_DIASTOLIC_Includefilter"));
            Ddo_br_vital_diastolic_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_VITAL_DIASTOLIC_Includedatalist"));
            Ddo_br_vital_diastolic_Sortasc = cgiGet( "DDO_BR_VITAL_DIASTOLIC_Sortasc");
            Ddo_br_vital_diastolic_Sortdsc = cgiGet( "DDO_BR_VITAL_DIASTOLIC_Sortdsc");
            Ddo_br_vital_diastolic_Searchbuttontext = cgiGet( "DDO_BR_VITAL_DIASTOLIC_Searchbuttontext");
            Ddo_br_vital_height_Caption = cgiGet( "DDO_BR_VITAL_HEIGHT_Caption");
            Ddo_br_vital_height_Tooltip = cgiGet( "DDO_BR_VITAL_HEIGHT_Tooltip");
            Ddo_br_vital_height_Cls = cgiGet( "DDO_BR_VITAL_HEIGHT_Cls");
            Ddo_br_vital_height_Dropdownoptionstype = cgiGet( "DDO_BR_VITAL_HEIGHT_Dropdownoptionstype");
            Ddo_br_vital_height_Titlecontrolidtoreplace = cgiGet( "DDO_BR_VITAL_HEIGHT_Titlecontrolidtoreplace");
            Ddo_br_vital_height_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_VITAL_HEIGHT_Includesortasc"));
            Ddo_br_vital_height_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_VITAL_HEIGHT_Includesortdsc"));
            Ddo_br_vital_height_Sortedstatus = cgiGet( "DDO_BR_VITAL_HEIGHT_Sortedstatus");
            Ddo_br_vital_height_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_VITAL_HEIGHT_Includefilter"));
            Ddo_br_vital_height_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_VITAL_HEIGHT_Includedatalist"));
            Ddo_br_vital_height_Sortasc = cgiGet( "DDO_BR_VITAL_HEIGHT_Sortasc");
            Ddo_br_vital_height_Sortdsc = cgiGet( "DDO_BR_VITAL_HEIGHT_Sortdsc");
            Ddo_br_vital_height_Searchbuttontext = cgiGet( "DDO_BR_VITAL_HEIGHT_Searchbuttontext");
            Ddo_br_vital_weight_Caption = cgiGet( "DDO_BR_VITAL_WEIGHT_Caption");
            Ddo_br_vital_weight_Tooltip = cgiGet( "DDO_BR_VITAL_WEIGHT_Tooltip");
            Ddo_br_vital_weight_Cls = cgiGet( "DDO_BR_VITAL_WEIGHT_Cls");
            Ddo_br_vital_weight_Dropdownoptionstype = cgiGet( "DDO_BR_VITAL_WEIGHT_Dropdownoptionstype");
            Ddo_br_vital_weight_Titlecontrolidtoreplace = cgiGet( "DDO_BR_VITAL_WEIGHT_Titlecontrolidtoreplace");
            Ddo_br_vital_weight_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_VITAL_WEIGHT_Includesortasc"));
            Ddo_br_vital_weight_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_VITAL_WEIGHT_Includesortdsc"));
            Ddo_br_vital_weight_Sortedstatus = cgiGet( "DDO_BR_VITAL_WEIGHT_Sortedstatus");
            Ddo_br_vital_weight_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_VITAL_WEIGHT_Includefilter"));
            Ddo_br_vital_weight_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_VITAL_WEIGHT_Includedatalist"));
            Ddo_br_vital_weight_Sortasc = cgiGet( "DDO_BR_VITAL_WEIGHT_Sortasc");
            Ddo_br_vital_weight_Sortdsc = cgiGet( "DDO_BR_VITAL_WEIGHT_Sortdsc");
            Ddo_br_vital_weight_Searchbuttontext = cgiGet( "DDO_BR_VITAL_WEIGHT_Searchbuttontext");
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( "GRID_Rows"), ".", ","));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            Gridpaginationbar_Selectedpage = cgiGet( "GRIDPAGINATIONBAR_Selectedpage");
            Gridpaginationbar_Rowsperpageselectedvalue = (int)(context.localUtil.CToN( cgiGet( "GRIDPAGINATIONBAR_Rowsperpageselectedvalue"), ".", ","));
            Ddo_br_vitalid_Activeeventkey = cgiGet( "DDO_BR_VITALID_Activeeventkey");
            Ddo_br_encounterid_Activeeventkey = cgiGet( "DDO_BR_ENCOUNTERID_Activeeventkey");
            Ddo_br_information_patientno_Activeeventkey = cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Activeeventkey");
            Ddo_br_vital_vitalid_Activeeventkey = cgiGet( "DDO_BR_VITAL_VITALID_Activeeventkey");
            Ddo_br_vital_measuredate_Activeeventkey = cgiGet( "DDO_BR_VITAL_MEASUREDATE_Activeeventkey");
            Ddo_br_vital_temperature_Activeeventkey = cgiGet( "DDO_BR_VITAL_TEMPERATURE_Activeeventkey");
            Ddo_br_vital_pulse_Activeeventkey = cgiGet( "DDO_BR_VITAL_PULSE_Activeeventkey");
            Ddo_br_vital_respiration_Activeeventkey = cgiGet( "DDO_BR_VITAL_RESPIRATION_Activeeventkey");
            Ddo_br_vital_systolic_Activeeventkey = cgiGet( "DDO_BR_VITAL_SYSTOLIC_Activeeventkey");
            Ddo_br_vital_diastolic_Activeeventkey = cgiGet( "DDO_BR_VITAL_DIASTOLIC_Activeeventkey");
            Ddo_br_vital_height_Activeeventkey = cgiGet( "DDO_BR_VITAL_HEIGHT_Activeeventkey");
            Ddo_br_vital_weight_Activeeventkey = cgiGet( "DDO_BR_VITAL_WEIGHT_Activeeventkey");
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vORDEREDBY"), ".", ",") != Convert.ToDecimal( AV10OrderedBy )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrToBool( cgiGet( "GXH_vORDEREDDSC")) != AV11OrderedDsc )
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
         E25622 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E25622( )
      {
         /* Start Routine */
         GXt_boolean1 = AV5IsAuthorized;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Check_Vital", out  GXt_boolean1) ;
         AV5IsAuthorized = GXt_boolean1;
         if ( ! AV5IsAuthorized )
         {
            CallWebObject(formatLink("wwpbaseobjects.notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV44Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         divTablemain_Height = 493;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, divTablemain_Internalname, "Height", StringUtil.LTrim( StringUtil.Str( (decimal)(divTablemain_Height), 9, 0)), true);
         subGrid_Rows = 9;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         Ddo_br_vitalid_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_VitalID";
         ucDdo_br_vitalid.SendProperty(context, "", false, Ddo_br_vitalid_Internalname, "TitleControlIdToReplace", Ddo_br_vitalid_Titlecontrolidtoreplace);
         AV13ddo_BR_VitalIDTitleControlIdToReplace = Ddo_br_vitalid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13ddo_BR_VitalIDTitleControlIdToReplace", AV13ddo_BR_VitalIDTitleControlIdToReplace);
         edtavDdo_br_vitalidtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_vitalidtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_vitalidtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_encounterid_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_EncounterID";
         ucDdo_br_encounterid.SendProperty(context, "", false, Ddo_br_encounterid_Internalname, "TitleControlIdToReplace", Ddo_br_encounterid_Titlecontrolidtoreplace);
         AV15ddo_BR_EncounterIDTitleControlIdToReplace = Ddo_br_encounterid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15ddo_BR_EncounterIDTitleControlIdToReplace", AV15ddo_BR_EncounterIDTitleControlIdToReplace);
         edtavDdo_br_encounteridtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_encounteridtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_encounteridtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_information_patientno_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Information_PatientNo";
         ucDdo_br_information_patientno.SendProperty(context, "", false, Ddo_br_information_patientno_Internalname, "TitleControlIdToReplace", Ddo_br_information_patientno_Titlecontrolidtoreplace);
         AV17ddo_BR_Information_PatientNoTitleControlIdToReplace = Ddo_br_information_patientno_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17ddo_BR_Information_PatientNoTitleControlIdToReplace", AV17ddo_BR_Information_PatientNoTitleControlIdToReplace);
         edtavDdo_br_information_patientnotitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_information_patientnotitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_information_patientnotitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_vital_vitalid_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Vital_VitalID";
         ucDdo_br_vital_vitalid.SendProperty(context, "", false, Ddo_br_vital_vitalid_Internalname, "TitleControlIdToReplace", Ddo_br_vital_vitalid_Titlecontrolidtoreplace);
         AV19ddo_BR_Vital_VitalIDTitleControlIdToReplace = Ddo_br_vital_vitalid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19ddo_BR_Vital_VitalIDTitleControlIdToReplace", AV19ddo_BR_Vital_VitalIDTitleControlIdToReplace);
         edtavDdo_br_vital_vitalidtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_vital_vitalidtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_vital_vitalidtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_vital_measuredate_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Vital_MeasureDate";
         ucDdo_br_vital_measuredate.SendProperty(context, "", false, Ddo_br_vital_measuredate_Internalname, "TitleControlIdToReplace", Ddo_br_vital_measuredate_Titlecontrolidtoreplace);
         AV21ddo_BR_Vital_MeasureDateTitleControlIdToReplace = Ddo_br_vital_measuredate_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21ddo_BR_Vital_MeasureDateTitleControlIdToReplace", AV21ddo_BR_Vital_MeasureDateTitleControlIdToReplace);
         edtavDdo_br_vital_measuredatetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_vital_measuredatetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_vital_measuredatetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_vital_temperature_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Vital_Temperature";
         ucDdo_br_vital_temperature.SendProperty(context, "", false, Ddo_br_vital_temperature_Internalname, "TitleControlIdToReplace", Ddo_br_vital_temperature_Titlecontrolidtoreplace);
         AV23ddo_BR_Vital_TemperatureTitleControlIdToReplace = Ddo_br_vital_temperature_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23ddo_BR_Vital_TemperatureTitleControlIdToReplace", AV23ddo_BR_Vital_TemperatureTitleControlIdToReplace);
         edtavDdo_br_vital_temperaturetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_vital_temperaturetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_vital_temperaturetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_vital_pulse_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Vital_Pulse";
         ucDdo_br_vital_pulse.SendProperty(context, "", false, Ddo_br_vital_pulse_Internalname, "TitleControlIdToReplace", Ddo_br_vital_pulse_Titlecontrolidtoreplace);
         AV25ddo_BR_Vital_PulseTitleControlIdToReplace = Ddo_br_vital_pulse_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25ddo_BR_Vital_PulseTitleControlIdToReplace", AV25ddo_BR_Vital_PulseTitleControlIdToReplace);
         edtavDdo_br_vital_pulsetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_vital_pulsetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_vital_pulsetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_vital_respiration_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Vital_Respiration";
         ucDdo_br_vital_respiration.SendProperty(context, "", false, Ddo_br_vital_respiration_Internalname, "TitleControlIdToReplace", Ddo_br_vital_respiration_Titlecontrolidtoreplace);
         AV27ddo_BR_Vital_RespirationTitleControlIdToReplace = Ddo_br_vital_respiration_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27ddo_BR_Vital_RespirationTitleControlIdToReplace", AV27ddo_BR_Vital_RespirationTitleControlIdToReplace);
         edtavDdo_br_vital_respirationtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_vital_respirationtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_vital_respirationtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_vital_systolic_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Vital_Systolic";
         ucDdo_br_vital_systolic.SendProperty(context, "", false, Ddo_br_vital_systolic_Internalname, "TitleControlIdToReplace", Ddo_br_vital_systolic_Titlecontrolidtoreplace);
         AV29ddo_BR_Vital_SystolicTitleControlIdToReplace = Ddo_br_vital_systolic_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29ddo_BR_Vital_SystolicTitleControlIdToReplace", AV29ddo_BR_Vital_SystolicTitleControlIdToReplace);
         edtavDdo_br_vital_systolictitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_vital_systolictitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_vital_systolictitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_vital_diastolic_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Vital_Diastolic";
         ucDdo_br_vital_diastolic.SendProperty(context, "", false, Ddo_br_vital_diastolic_Internalname, "TitleControlIdToReplace", Ddo_br_vital_diastolic_Titlecontrolidtoreplace);
         AV31ddo_BR_Vital_DiastolicTitleControlIdToReplace = Ddo_br_vital_diastolic_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31ddo_BR_Vital_DiastolicTitleControlIdToReplace", AV31ddo_BR_Vital_DiastolicTitleControlIdToReplace);
         edtavDdo_br_vital_diastolictitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_vital_diastolictitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_vital_diastolictitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_vital_height_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Vital_Height";
         ucDdo_br_vital_height.SendProperty(context, "", false, Ddo_br_vital_height_Internalname, "TitleControlIdToReplace", Ddo_br_vital_height_Titlecontrolidtoreplace);
         AV33ddo_BR_Vital_HeightTitleControlIdToReplace = Ddo_br_vital_height_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33ddo_BR_Vital_HeightTitleControlIdToReplace", AV33ddo_BR_Vital_HeightTitleControlIdToReplace);
         edtavDdo_br_vital_heighttitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_vital_heighttitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_vital_heighttitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_vital_weight_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Vital_Weight";
         ucDdo_br_vital_weight.SendProperty(context, "", false, Ddo_br_vital_weight_Internalname, "TitleControlIdToReplace", Ddo_br_vital_weight_Titlecontrolidtoreplace);
         AV35ddo_BR_Vital_WeightTitleControlIdToReplace = Ddo_br_vital_weight_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV35ddo_BR_Vital_WeightTitleControlIdToReplace", AV35ddo_BR_Vital_WeightTitleControlIdToReplace);
         edtavDdo_br_vital_weighttitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_vital_weighttitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_vital_weighttitlecontrolidtoreplace_Visible), 5, 0)), true);
         Form.Caption = "选择生命体征";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption, true);
         edtavOrderedby_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavOrderedby_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavOrderedby_Visible), 5, 0)), true);
         if ( AV10OrderedBy < 1 )
         {
            AV10OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
         }
         edtavOrdereddsc_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavOrdereddsc_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavOrdereddsc_Visible), 5, 0)), true);
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 = AV36DDO_TitleSettingsIcons;
         new GeneXus.Programs.wwpbaseobjects.getwwptitlesettingsicons(context ).execute( out  GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2) ;
         AV36DDO_TitleSettingsIcons = GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2;
         Gridpaginationbar_Rowsperpageselectedvalue = subGrid_Rows;
         ucGridpaginationbar.SendProperty(context, "", false, Gridpaginationbar_Internalname, "RowsPerPageSelectedValue", StringUtil.LTrim( StringUtil.Str( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0)));
      }

      protected void E26622( )
      {
         if ( gx_refresh_fired )
         {
            return  ;
         }
         gx_refresh_fired = true;
         /* Refresh Routine */
         AV12BR_VitalIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV14BR_EncounterIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV16BR_Information_PatientNoTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV18BR_Vital_VitalIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV20BR_Vital_MeasureDateTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV22BR_Vital_TemperatureTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV24BR_Vital_PulseTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV26BR_Vital_RespirationTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV28BR_Vital_SystolicTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV30BR_Vital_DiastolicTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV32BR_Vital_HeightTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV34BR_Vital_WeightTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV6WWPContext) ;
         edtBR_VitalID_Titleformat = 2;
         edtBR_VitalID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "生命体征主键", AV13ddo_BR_VitalIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_VitalID_Internalname, "Title", edtBR_VitalID_Title, !bGXsfl_12_Refreshing);
         edtBR_EncounterID_Titleformat = 2;
         edtBR_EncounterID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "就诊信息主键", AV15ddo_BR_EncounterIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_EncounterID_Internalname, "Title", edtBR_EncounterID_Title, !bGXsfl_12_Refreshing);
         edtBR_Information_PatientNo_Titleformat = 2;
         edtBR_Information_PatientNo_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "患者编号", AV17ddo_BR_Information_PatientNoTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Information_PatientNo_Internalname, "Title", edtBR_Information_PatientNo_Title, !bGXsfl_12_Refreshing);
         edtBR_Vital_VitalID_Titleformat = 2;
         edtBR_Vital_VitalID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "指标序号", AV19ddo_BR_Vital_VitalIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Vital_VitalID_Internalname, "Title", edtBR_Vital_VitalID_Title, !bGXsfl_12_Refreshing);
         edtBR_Vital_MeasureDate_Titleformat = 2;
         edtBR_Vital_MeasureDate_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "测量日期", AV21ddo_BR_Vital_MeasureDateTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Vital_MeasureDate_Internalname, "Title", edtBR_Vital_MeasureDate_Title, !bGXsfl_12_Refreshing);
         edtBR_Vital_Temperature_Titleformat = 2;
         edtBR_Vital_Temperature_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "体温(℃)", AV23ddo_BR_Vital_TemperatureTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Vital_Temperature_Internalname, "Title", edtBR_Vital_Temperature_Title, !bGXsfl_12_Refreshing);
         edtBR_Vital_Pulse_Titleformat = 2;
         edtBR_Vital_Pulse_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "脉搏(次/分钟)", AV25ddo_BR_Vital_PulseTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Vital_Pulse_Internalname, "Title", edtBR_Vital_Pulse_Title, !bGXsfl_12_Refreshing);
         edtBR_Vital_Respiration_Titleformat = 2;
         edtBR_Vital_Respiration_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "呼吸频率(次/分钟)", AV27ddo_BR_Vital_RespirationTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Vital_Respiration_Internalname, "Title", edtBR_Vital_Respiration_Title, !bGXsfl_12_Refreshing);
         edtBR_Vital_Systolic_Titleformat = 2;
         edtBR_Vital_Systolic_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "Hg)", AV29ddo_BR_Vital_SystolicTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Vital_Systolic_Internalname, "Title", edtBR_Vital_Systolic_Title, !bGXsfl_12_Refreshing);
         edtBR_Vital_Diastolic_Titleformat = 2;
         edtBR_Vital_Diastolic_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "Hg)", AV31ddo_BR_Vital_DiastolicTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Vital_Diastolic_Internalname, "Title", edtBR_Vital_Diastolic_Title, !bGXsfl_12_Refreshing);
         edtBR_Vital_Height_Titleformat = 2;
         edtBR_Vital_Height_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "身高(cm)", AV33ddo_BR_Vital_HeightTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Vital_Height_Internalname, "Title", edtBR_Vital_Height_Title, !bGXsfl_12_Refreshing);
         edtBR_Vital_Weight_Titleformat = 2;
         edtBR_Vital_Weight_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "体重(kg)", AV35ddo_BR_Vital_WeightTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Vital_Weight_Internalname, "Title", edtBR_Vital_Weight_Title, !bGXsfl_12_Refreshing);
         AV38GridCurrentPage = subGrid_Currentpage( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV38GridCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV38GridCurrentPage), 10, 0)));
         AV39GridPageSize = subGrid_Rows;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV39GridPageSize", StringUtil.LTrim( StringUtil.Str( (decimal)(AV39GridPageSize), 10, 0)));
         AV40GridRecordCount = subGrid_Recordcount( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV40GridRecordCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV40GridRecordCount), 10, 0)));
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12BR_VitalIDTitleFilterData", AV12BR_VitalIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14BR_EncounterIDTitleFilterData", AV14BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Information_PatientNoTitleFilterData", AV16BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18BR_Vital_VitalIDTitleFilterData", AV18BR_Vital_VitalIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Vital_MeasureDateTitleFilterData", AV20BR_Vital_MeasureDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22BR_Vital_TemperatureTitleFilterData", AV22BR_Vital_TemperatureTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Vital_PulseTitleFilterData", AV24BR_Vital_PulseTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV26BR_Vital_RespirationTitleFilterData", AV26BR_Vital_RespirationTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Vital_SystolicTitleFilterData", AV28BR_Vital_SystolicTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30BR_Vital_DiastolicTitleFilterData", AV30BR_Vital_DiastolicTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Vital_HeightTitleFilterData", AV32BR_Vital_HeightTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34BR_Vital_WeightTitleFilterData", AV34BR_Vital_WeightTitleFilterData);
      }

      protected void E11622( )
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
            AV37PageToGo = (int)(NumberUtil.Val( Gridpaginationbar_Selectedpage, "."));
            subgrid_gotopage( AV37PageToGo) ;
         }
      }

      protected void E12622( )
      {
         /* Gridpaginationbar_Changerowsperpage Routine */
         subGrid_Rows = Gridpaginationbar_Rowsperpageselectedvalue;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         subgrid_firstpage( ) ;
         /*  Sending Event outputs  */
      }

      protected void E13622( )
      {
         /* Ddo_br_vitalid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_vitalid_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV10OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_vitalid_Sortedstatus = "ASC";
            ucDdo_br_vitalid.SendProperty(context, "", false, Ddo_br_vitalid_Internalname, "SortedStatus", Ddo_br_vitalid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_vitalid_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV10OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_vitalid_Sortedstatus = "DSC";
            ucDdo_br_vitalid.SendProperty(context, "", false, Ddo_br_vitalid_Internalname, "SortedStatus", Ddo_br_vitalid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12BR_VitalIDTitleFilterData", AV12BR_VitalIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14BR_EncounterIDTitleFilterData", AV14BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Information_PatientNoTitleFilterData", AV16BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18BR_Vital_VitalIDTitleFilterData", AV18BR_Vital_VitalIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Vital_MeasureDateTitleFilterData", AV20BR_Vital_MeasureDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22BR_Vital_TemperatureTitleFilterData", AV22BR_Vital_TemperatureTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Vital_PulseTitleFilterData", AV24BR_Vital_PulseTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV26BR_Vital_RespirationTitleFilterData", AV26BR_Vital_RespirationTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Vital_SystolicTitleFilterData", AV28BR_Vital_SystolicTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30BR_Vital_DiastolicTitleFilterData", AV30BR_Vital_DiastolicTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Vital_HeightTitleFilterData", AV32BR_Vital_HeightTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34BR_Vital_WeightTitleFilterData", AV34BR_Vital_WeightTitleFilterData);
      }

      protected void E14622( )
      {
         /* Ddo_br_encounterid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_encounterid_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV10OrderedBy = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_encounterid_Sortedstatus = "ASC";
            ucDdo_br_encounterid.SendProperty(context, "", false, Ddo_br_encounterid_Internalname, "SortedStatus", Ddo_br_encounterid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_encounterid_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV10OrderedBy = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_encounterid_Sortedstatus = "DSC";
            ucDdo_br_encounterid.SendProperty(context, "", false, Ddo_br_encounterid_Internalname, "SortedStatus", Ddo_br_encounterid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12BR_VitalIDTitleFilterData", AV12BR_VitalIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14BR_EncounterIDTitleFilterData", AV14BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Information_PatientNoTitleFilterData", AV16BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18BR_Vital_VitalIDTitleFilterData", AV18BR_Vital_VitalIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Vital_MeasureDateTitleFilterData", AV20BR_Vital_MeasureDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22BR_Vital_TemperatureTitleFilterData", AV22BR_Vital_TemperatureTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Vital_PulseTitleFilterData", AV24BR_Vital_PulseTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV26BR_Vital_RespirationTitleFilterData", AV26BR_Vital_RespirationTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Vital_SystolicTitleFilterData", AV28BR_Vital_SystolicTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30BR_Vital_DiastolicTitleFilterData", AV30BR_Vital_DiastolicTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Vital_HeightTitleFilterData", AV32BR_Vital_HeightTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34BR_Vital_WeightTitleFilterData", AV34BR_Vital_WeightTitleFilterData);
      }

      protected void E15622( )
      {
         /* Ddo_br_information_patientno_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_information_patientno_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV10OrderedBy = 3;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_information_patientno_Sortedstatus = "ASC";
            ucDdo_br_information_patientno.SendProperty(context, "", false, Ddo_br_information_patientno_Internalname, "SortedStatus", Ddo_br_information_patientno_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_information_patientno_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV10OrderedBy = 3;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_information_patientno_Sortedstatus = "DSC";
            ucDdo_br_information_patientno.SendProperty(context, "", false, Ddo_br_information_patientno_Internalname, "SortedStatus", Ddo_br_information_patientno_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12BR_VitalIDTitleFilterData", AV12BR_VitalIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14BR_EncounterIDTitleFilterData", AV14BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Information_PatientNoTitleFilterData", AV16BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18BR_Vital_VitalIDTitleFilterData", AV18BR_Vital_VitalIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Vital_MeasureDateTitleFilterData", AV20BR_Vital_MeasureDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22BR_Vital_TemperatureTitleFilterData", AV22BR_Vital_TemperatureTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Vital_PulseTitleFilterData", AV24BR_Vital_PulseTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV26BR_Vital_RespirationTitleFilterData", AV26BR_Vital_RespirationTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Vital_SystolicTitleFilterData", AV28BR_Vital_SystolicTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30BR_Vital_DiastolicTitleFilterData", AV30BR_Vital_DiastolicTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Vital_HeightTitleFilterData", AV32BR_Vital_HeightTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34BR_Vital_WeightTitleFilterData", AV34BR_Vital_WeightTitleFilterData);
      }

      protected void E16622( )
      {
         /* Ddo_br_vital_vitalid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_vital_vitalid_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV10OrderedBy = 4;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_vital_vitalid_Sortedstatus = "ASC";
            ucDdo_br_vital_vitalid.SendProperty(context, "", false, Ddo_br_vital_vitalid_Internalname, "SortedStatus", Ddo_br_vital_vitalid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_vital_vitalid_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV10OrderedBy = 4;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_vital_vitalid_Sortedstatus = "DSC";
            ucDdo_br_vital_vitalid.SendProperty(context, "", false, Ddo_br_vital_vitalid_Internalname, "SortedStatus", Ddo_br_vital_vitalid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12BR_VitalIDTitleFilterData", AV12BR_VitalIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14BR_EncounterIDTitleFilterData", AV14BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Information_PatientNoTitleFilterData", AV16BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18BR_Vital_VitalIDTitleFilterData", AV18BR_Vital_VitalIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Vital_MeasureDateTitleFilterData", AV20BR_Vital_MeasureDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22BR_Vital_TemperatureTitleFilterData", AV22BR_Vital_TemperatureTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Vital_PulseTitleFilterData", AV24BR_Vital_PulseTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV26BR_Vital_RespirationTitleFilterData", AV26BR_Vital_RespirationTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Vital_SystolicTitleFilterData", AV28BR_Vital_SystolicTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30BR_Vital_DiastolicTitleFilterData", AV30BR_Vital_DiastolicTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Vital_HeightTitleFilterData", AV32BR_Vital_HeightTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34BR_Vital_WeightTitleFilterData", AV34BR_Vital_WeightTitleFilterData);
      }

      protected void E17622( )
      {
         /* Ddo_br_vital_measuredate_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_vital_measuredate_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV10OrderedBy = 5;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_vital_measuredate_Sortedstatus = "ASC";
            ucDdo_br_vital_measuredate.SendProperty(context, "", false, Ddo_br_vital_measuredate_Internalname, "SortedStatus", Ddo_br_vital_measuredate_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_vital_measuredate_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV10OrderedBy = 5;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_vital_measuredate_Sortedstatus = "DSC";
            ucDdo_br_vital_measuredate.SendProperty(context, "", false, Ddo_br_vital_measuredate_Internalname, "SortedStatus", Ddo_br_vital_measuredate_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12BR_VitalIDTitleFilterData", AV12BR_VitalIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14BR_EncounterIDTitleFilterData", AV14BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Information_PatientNoTitleFilterData", AV16BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18BR_Vital_VitalIDTitleFilterData", AV18BR_Vital_VitalIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Vital_MeasureDateTitleFilterData", AV20BR_Vital_MeasureDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22BR_Vital_TemperatureTitleFilterData", AV22BR_Vital_TemperatureTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Vital_PulseTitleFilterData", AV24BR_Vital_PulseTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV26BR_Vital_RespirationTitleFilterData", AV26BR_Vital_RespirationTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Vital_SystolicTitleFilterData", AV28BR_Vital_SystolicTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30BR_Vital_DiastolicTitleFilterData", AV30BR_Vital_DiastolicTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Vital_HeightTitleFilterData", AV32BR_Vital_HeightTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34BR_Vital_WeightTitleFilterData", AV34BR_Vital_WeightTitleFilterData);
      }

      protected void E18622( )
      {
         /* Ddo_br_vital_temperature_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_vital_temperature_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV10OrderedBy = 6;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_vital_temperature_Sortedstatus = "ASC";
            ucDdo_br_vital_temperature.SendProperty(context, "", false, Ddo_br_vital_temperature_Internalname, "SortedStatus", Ddo_br_vital_temperature_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_vital_temperature_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV10OrderedBy = 6;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_vital_temperature_Sortedstatus = "DSC";
            ucDdo_br_vital_temperature.SendProperty(context, "", false, Ddo_br_vital_temperature_Internalname, "SortedStatus", Ddo_br_vital_temperature_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12BR_VitalIDTitleFilterData", AV12BR_VitalIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14BR_EncounterIDTitleFilterData", AV14BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Information_PatientNoTitleFilterData", AV16BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18BR_Vital_VitalIDTitleFilterData", AV18BR_Vital_VitalIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Vital_MeasureDateTitleFilterData", AV20BR_Vital_MeasureDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22BR_Vital_TemperatureTitleFilterData", AV22BR_Vital_TemperatureTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Vital_PulseTitleFilterData", AV24BR_Vital_PulseTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV26BR_Vital_RespirationTitleFilterData", AV26BR_Vital_RespirationTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Vital_SystolicTitleFilterData", AV28BR_Vital_SystolicTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30BR_Vital_DiastolicTitleFilterData", AV30BR_Vital_DiastolicTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Vital_HeightTitleFilterData", AV32BR_Vital_HeightTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34BR_Vital_WeightTitleFilterData", AV34BR_Vital_WeightTitleFilterData);
      }

      protected void E19622( )
      {
         /* Ddo_br_vital_pulse_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_vital_pulse_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV10OrderedBy = 7;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_vital_pulse_Sortedstatus = "ASC";
            ucDdo_br_vital_pulse.SendProperty(context, "", false, Ddo_br_vital_pulse_Internalname, "SortedStatus", Ddo_br_vital_pulse_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_vital_pulse_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV10OrderedBy = 7;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_vital_pulse_Sortedstatus = "DSC";
            ucDdo_br_vital_pulse.SendProperty(context, "", false, Ddo_br_vital_pulse_Internalname, "SortedStatus", Ddo_br_vital_pulse_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12BR_VitalIDTitleFilterData", AV12BR_VitalIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14BR_EncounterIDTitleFilterData", AV14BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Information_PatientNoTitleFilterData", AV16BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18BR_Vital_VitalIDTitleFilterData", AV18BR_Vital_VitalIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Vital_MeasureDateTitleFilterData", AV20BR_Vital_MeasureDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22BR_Vital_TemperatureTitleFilterData", AV22BR_Vital_TemperatureTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Vital_PulseTitleFilterData", AV24BR_Vital_PulseTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV26BR_Vital_RespirationTitleFilterData", AV26BR_Vital_RespirationTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Vital_SystolicTitleFilterData", AV28BR_Vital_SystolicTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30BR_Vital_DiastolicTitleFilterData", AV30BR_Vital_DiastolicTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Vital_HeightTitleFilterData", AV32BR_Vital_HeightTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34BR_Vital_WeightTitleFilterData", AV34BR_Vital_WeightTitleFilterData);
      }

      protected void E20622( )
      {
         /* Ddo_br_vital_respiration_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_vital_respiration_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV10OrderedBy = 8;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_vital_respiration_Sortedstatus = "ASC";
            ucDdo_br_vital_respiration.SendProperty(context, "", false, Ddo_br_vital_respiration_Internalname, "SortedStatus", Ddo_br_vital_respiration_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_vital_respiration_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV10OrderedBy = 8;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_vital_respiration_Sortedstatus = "DSC";
            ucDdo_br_vital_respiration.SendProperty(context, "", false, Ddo_br_vital_respiration_Internalname, "SortedStatus", Ddo_br_vital_respiration_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12BR_VitalIDTitleFilterData", AV12BR_VitalIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14BR_EncounterIDTitleFilterData", AV14BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Information_PatientNoTitleFilterData", AV16BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18BR_Vital_VitalIDTitleFilterData", AV18BR_Vital_VitalIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Vital_MeasureDateTitleFilterData", AV20BR_Vital_MeasureDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22BR_Vital_TemperatureTitleFilterData", AV22BR_Vital_TemperatureTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Vital_PulseTitleFilterData", AV24BR_Vital_PulseTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV26BR_Vital_RespirationTitleFilterData", AV26BR_Vital_RespirationTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Vital_SystolicTitleFilterData", AV28BR_Vital_SystolicTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30BR_Vital_DiastolicTitleFilterData", AV30BR_Vital_DiastolicTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Vital_HeightTitleFilterData", AV32BR_Vital_HeightTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34BR_Vital_WeightTitleFilterData", AV34BR_Vital_WeightTitleFilterData);
      }

      protected void E21622( )
      {
         /* Ddo_br_vital_systolic_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_vital_systolic_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV10OrderedBy = 9;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_vital_systolic_Sortedstatus = "ASC";
            ucDdo_br_vital_systolic.SendProperty(context, "", false, Ddo_br_vital_systolic_Internalname, "SortedStatus", Ddo_br_vital_systolic_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_vital_systolic_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV10OrderedBy = 9;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_vital_systolic_Sortedstatus = "DSC";
            ucDdo_br_vital_systolic.SendProperty(context, "", false, Ddo_br_vital_systolic_Internalname, "SortedStatus", Ddo_br_vital_systolic_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12BR_VitalIDTitleFilterData", AV12BR_VitalIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14BR_EncounterIDTitleFilterData", AV14BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Information_PatientNoTitleFilterData", AV16BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18BR_Vital_VitalIDTitleFilterData", AV18BR_Vital_VitalIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Vital_MeasureDateTitleFilterData", AV20BR_Vital_MeasureDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22BR_Vital_TemperatureTitleFilterData", AV22BR_Vital_TemperatureTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Vital_PulseTitleFilterData", AV24BR_Vital_PulseTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV26BR_Vital_RespirationTitleFilterData", AV26BR_Vital_RespirationTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Vital_SystolicTitleFilterData", AV28BR_Vital_SystolicTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30BR_Vital_DiastolicTitleFilterData", AV30BR_Vital_DiastolicTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Vital_HeightTitleFilterData", AV32BR_Vital_HeightTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34BR_Vital_WeightTitleFilterData", AV34BR_Vital_WeightTitleFilterData);
      }

      protected void E22622( )
      {
         /* Ddo_br_vital_diastolic_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_vital_diastolic_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV10OrderedBy = 10;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_vital_diastolic_Sortedstatus = "ASC";
            ucDdo_br_vital_diastolic.SendProperty(context, "", false, Ddo_br_vital_diastolic_Internalname, "SortedStatus", Ddo_br_vital_diastolic_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_vital_diastolic_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV10OrderedBy = 10;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_vital_diastolic_Sortedstatus = "DSC";
            ucDdo_br_vital_diastolic.SendProperty(context, "", false, Ddo_br_vital_diastolic_Internalname, "SortedStatus", Ddo_br_vital_diastolic_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12BR_VitalIDTitleFilterData", AV12BR_VitalIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14BR_EncounterIDTitleFilterData", AV14BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Information_PatientNoTitleFilterData", AV16BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18BR_Vital_VitalIDTitleFilterData", AV18BR_Vital_VitalIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Vital_MeasureDateTitleFilterData", AV20BR_Vital_MeasureDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22BR_Vital_TemperatureTitleFilterData", AV22BR_Vital_TemperatureTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Vital_PulseTitleFilterData", AV24BR_Vital_PulseTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV26BR_Vital_RespirationTitleFilterData", AV26BR_Vital_RespirationTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Vital_SystolicTitleFilterData", AV28BR_Vital_SystolicTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30BR_Vital_DiastolicTitleFilterData", AV30BR_Vital_DiastolicTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Vital_HeightTitleFilterData", AV32BR_Vital_HeightTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34BR_Vital_WeightTitleFilterData", AV34BR_Vital_WeightTitleFilterData);
      }

      protected void E23622( )
      {
         /* Ddo_br_vital_height_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_vital_height_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV10OrderedBy = 11;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_vital_height_Sortedstatus = "ASC";
            ucDdo_br_vital_height.SendProperty(context, "", false, Ddo_br_vital_height_Internalname, "SortedStatus", Ddo_br_vital_height_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_vital_height_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV10OrderedBy = 11;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_vital_height_Sortedstatus = "DSC";
            ucDdo_br_vital_height.SendProperty(context, "", false, Ddo_br_vital_height_Internalname, "SortedStatus", Ddo_br_vital_height_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12BR_VitalIDTitleFilterData", AV12BR_VitalIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14BR_EncounterIDTitleFilterData", AV14BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Information_PatientNoTitleFilterData", AV16BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18BR_Vital_VitalIDTitleFilterData", AV18BR_Vital_VitalIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Vital_MeasureDateTitleFilterData", AV20BR_Vital_MeasureDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22BR_Vital_TemperatureTitleFilterData", AV22BR_Vital_TemperatureTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Vital_PulseTitleFilterData", AV24BR_Vital_PulseTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV26BR_Vital_RespirationTitleFilterData", AV26BR_Vital_RespirationTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Vital_SystolicTitleFilterData", AV28BR_Vital_SystolicTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30BR_Vital_DiastolicTitleFilterData", AV30BR_Vital_DiastolicTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Vital_HeightTitleFilterData", AV32BR_Vital_HeightTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34BR_Vital_WeightTitleFilterData", AV34BR_Vital_WeightTitleFilterData);
      }

      protected void E24622( )
      {
         /* Ddo_br_vital_weight_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_vital_weight_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV10OrderedBy = 12;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_vital_weight_Sortedstatus = "ASC";
            ucDdo_br_vital_weight.SendProperty(context, "", false, Ddo_br_vital_weight_Internalname, "SortedStatus", Ddo_br_vital_weight_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_vital_weight_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV10OrderedBy = 12;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_vital_weight_Sortedstatus = "DSC";
            ucDdo_br_vital_weight.SendProperty(context, "", false, Ddo_br_vital_weight_Internalname, "SortedStatus", Ddo_br_vital_weight_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12BR_VitalIDTitleFilterData", AV12BR_VitalIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14BR_EncounterIDTitleFilterData", AV14BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Information_PatientNoTitleFilterData", AV16BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18BR_Vital_VitalIDTitleFilterData", AV18BR_Vital_VitalIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Vital_MeasureDateTitleFilterData", AV20BR_Vital_MeasureDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV22BR_Vital_TemperatureTitleFilterData", AV22BR_Vital_TemperatureTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Vital_PulseTitleFilterData", AV24BR_Vital_PulseTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV26BR_Vital_RespirationTitleFilterData", AV26BR_Vital_RespirationTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Vital_SystolicTitleFilterData", AV28BR_Vital_SystolicTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30BR_Vital_DiastolicTitleFilterData", AV30BR_Vital_DiastolicTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Vital_HeightTitleFilterData", AV32BR_Vital_HeightTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34BR_Vital_WeightTitleFilterData", AV34BR_Vital_WeightTitleFilterData);
      }

      private void E27622( )
      {
         /* Grid_Load Routine */
         AV41Select = context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavSelect_Internalname, AV41Select);
         AV45Select_GXI = GXDbFile.PathToUrl( context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( )));
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
         E28622 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E28622( )
      {
         /* Enter Routine */
         AV8InOutBR_VitalID = A150BR_VitalID;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8InOutBR_VitalID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8InOutBR_VitalID), 18, 0)));
         context.setWebReturnParms(new Object[] {(long)AV8InOutBR_VitalID});
         context.setWebReturnParmsMetadata(new Object[] {"AV8InOutBR_VitalID"});
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
         AV8InOutBR_VitalID = Convert.ToInt64(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8InOutBR_VitalID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8InOutBR_VitalID), 18, 0)));
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
         PA622( ) ;
         WS622( ) ;
         WE622( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202022815151894", true);
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
         context.AddJavascriptSource("br_vitalprompt.js", "?202022815151894", false);
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
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/WorkWithPlusUtilities/WorkWithPlusUtilitiesRender.js", "", false);
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_122( )
      {
         edtavSelect_Internalname = "vSELECT_"+sGXsfl_12_idx;
         edtBR_VitalID_Internalname = "BR_VITALID_"+sGXsfl_12_idx;
         edtBR_EncounterID_Internalname = "BR_ENCOUNTERID_"+sGXsfl_12_idx;
         edtBR_Information_PatientNo_Internalname = "BR_INFORMATION_PATIENTNO_"+sGXsfl_12_idx;
         edtBR_Vital_VitalID_Internalname = "BR_VITAL_VITALID_"+sGXsfl_12_idx;
         edtBR_Vital_MeasureDate_Internalname = "BR_VITAL_MEASUREDATE_"+sGXsfl_12_idx;
         edtBR_Vital_Temperature_Internalname = "BR_VITAL_TEMPERATURE_"+sGXsfl_12_idx;
         edtBR_Vital_Pulse_Internalname = "BR_VITAL_PULSE_"+sGXsfl_12_idx;
         edtBR_Vital_Respiration_Internalname = "BR_VITAL_RESPIRATION_"+sGXsfl_12_idx;
         edtBR_Vital_Systolic_Internalname = "BR_VITAL_SYSTOLIC_"+sGXsfl_12_idx;
         edtBR_Vital_Diastolic_Internalname = "BR_VITAL_DIASTOLIC_"+sGXsfl_12_idx;
         edtBR_Vital_Height_Internalname = "BR_VITAL_HEIGHT_"+sGXsfl_12_idx;
         edtBR_Vital_Weight_Internalname = "BR_VITAL_WEIGHT_"+sGXsfl_12_idx;
      }

      protected void SubsflControlProps_fel_122( )
      {
         edtavSelect_Internalname = "vSELECT_"+sGXsfl_12_fel_idx;
         edtBR_VitalID_Internalname = "BR_VITALID_"+sGXsfl_12_fel_idx;
         edtBR_EncounterID_Internalname = "BR_ENCOUNTERID_"+sGXsfl_12_fel_idx;
         edtBR_Information_PatientNo_Internalname = "BR_INFORMATION_PATIENTNO_"+sGXsfl_12_fel_idx;
         edtBR_Vital_VitalID_Internalname = "BR_VITAL_VITALID_"+sGXsfl_12_fel_idx;
         edtBR_Vital_MeasureDate_Internalname = "BR_VITAL_MEASUREDATE_"+sGXsfl_12_fel_idx;
         edtBR_Vital_Temperature_Internalname = "BR_VITAL_TEMPERATURE_"+sGXsfl_12_fel_idx;
         edtBR_Vital_Pulse_Internalname = "BR_VITAL_PULSE_"+sGXsfl_12_fel_idx;
         edtBR_Vital_Respiration_Internalname = "BR_VITAL_RESPIRATION_"+sGXsfl_12_fel_idx;
         edtBR_Vital_Systolic_Internalname = "BR_VITAL_SYSTOLIC_"+sGXsfl_12_fel_idx;
         edtBR_Vital_Diastolic_Internalname = "BR_VITAL_DIASTOLIC_"+sGXsfl_12_fel_idx;
         edtBR_Vital_Height_Internalname = "BR_VITAL_HEIGHT_"+sGXsfl_12_fel_idx;
         edtBR_Vital_Weight_Internalname = "BR_VITAL_WEIGHT_"+sGXsfl_12_fel_idx;
      }

      protected void sendrow_122( )
      {
         SubsflControlProps_122( ) ;
         WB620( ) ;
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
            AV41Select_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV41Select))&&String.IsNullOrEmpty(StringUtil.RTrim( AV45Select_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV41Select)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV41Select)) ? AV45Select_GXI : context.PathToRelativeUrl( AV41Select));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavSelect_Internalname,(String)sImgUrl,(String)"",(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)edtavSelect_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)5,(String)edtavSelect_Jsonclick,"'"+""+"'"+",false,"+"'"+"EENTER."+sGXsfl_12_idx+"'",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)""+TempTags,(String)"",(String)"",(short)1,(bool)AV41Select_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_VitalID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A150BR_VitalID), 18, 0, ".", "")),context.localUtil.Format( (decimal)(A150BR_VitalID), "ZZZZZZZZZZZZZZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_VitalID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"ID",(String)"right",(bool)false});
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
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Information_PatientNo_Internalname,(String)A36BR_Information_PatientNo,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Information_PatientNo_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)410,(String)"px",(short)17,(String)"px",(short)2000,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Vital_VitalID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A151BR_Vital_VitalID), 10, 0, ".", "")),context.localUtil.Format( (decimal)(A151BR_Vital_VitalID), "ZZZZZZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Vital_VitalID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Vital_MeasureDate_Internalname,context.localUtil.Format(A152BR_Vital_MeasureDate, "9999/99/99"),context.localUtil.Format( A152BR_Vital_MeasureDate, "9999/99/99"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Vital_MeasureDate_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"DM_Date",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Vital_Temperature_Internalname,StringUtil.LTrim( StringUtil.NToC( A153BR_Vital_Temperature, 15, 5, ".", "")),context.localUtil.Format( A153BR_Vital_Temperature, "ZZZZZZZZZ.ZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Vital_Temperature_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)15,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"DM_Numeric",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Vital_Pulse_Internalname,StringUtil.LTrim( StringUtil.NToC( A154BR_Vital_Pulse, 15, 5, ".", "")),context.localUtil.Format( A154BR_Vital_Pulse, "ZZZZZZZZZ.ZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Vital_Pulse_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)15,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"DM_Numeric",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Vital_Respiration_Internalname,StringUtil.LTrim( StringUtil.NToC( A155BR_Vital_Respiration, 15, 5, ".", "")),context.localUtil.Format( A155BR_Vital_Respiration, "ZZZZZZZZZ.ZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Vital_Respiration_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)15,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"DM_Numeric",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Vital_Systolic_Internalname,StringUtil.LTrim( StringUtil.NToC( A156BR_Vital_Systolic, 15, 5, ".", "")),context.localUtil.Format( A156BR_Vital_Systolic, "ZZZZZZZZZ.ZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Vital_Systolic_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)15,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"DM_Numeric",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Vital_Diastolic_Internalname,StringUtil.LTrim( StringUtil.NToC( A157BR_Vital_Diastolic, 15, 5, ".", "")),context.localUtil.Format( A157BR_Vital_Diastolic, "ZZZZZZZZZ.ZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Vital_Diastolic_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)15,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"DM_Numeric",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Vital_Height_Internalname,StringUtil.LTrim( StringUtil.NToC( A158BR_Vital_Height, 15, 5, ".", "")),context.localUtil.Format( A158BR_Vital_Height, "ZZZZZZZZZ.ZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Vital_Height_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)15,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"DM_Numeric",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Vital_Weight_Internalname,StringUtil.LTrim( StringUtil.NToC( A159BR_Vital_Weight, 15, 5, ".", "")),context.localUtil.Format( A159BR_Vital_Weight, "ZZZZZZZZZ.ZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Vital_Weight_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)15,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"DM_Numeric",(String)"right",(bool)false});
            send_integrity_lvl_hashes622( ) ;
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
         edtavSelect_Internalname = "vSELECT";
         edtBR_VitalID_Internalname = "BR_VITALID";
         edtBR_EncounterID_Internalname = "BR_ENCOUNTERID";
         edtBR_Information_PatientNo_Internalname = "BR_INFORMATION_PATIENTNO";
         edtBR_Vital_VitalID_Internalname = "BR_VITAL_VITALID";
         edtBR_Vital_MeasureDate_Internalname = "BR_VITAL_MEASUREDATE";
         edtBR_Vital_Temperature_Internalname = "BR_VITAL_TEMPERATURE";
         edtBR_Vital_Pulse_Internalname = "BR_VITAL_PULSE";
         edtBR_Vital_Respiration_Internalname = "BR_VITAL_RESPIRATION";
         edtBR_Vital_Systolic_Internalname = "BR_VITAL_SYSTOLIC";
         edtBR_Vital_Diastolic_Internalname = "BR_VITAL_DIASTOLIC";
         edtBR_Vital_Height_Internalname = "BR_VITAL_HEIGHT";
         edtBR_Vital_Weight_Internalname = "BR_VITAL_WEIGHT";
         Gridpaginationbar_Internalname = "GRIDPAGINATIONBAR";
         divHtml_gridpaginationbar_Internalname = "HTML_GRIDPAGINATIONBAR";
         divGridtablewithpaginationbar_Internalname = "GRIDTABLEWITHPAGINATIONBAR";
         divTablemain_Internalname = "TABLEMAIN";
         Ddo_br_vitalid_Internalname = "DDO_BR_VITALID";
         edtavDdo_br_vitalidtitlecontrolidtoreplace_Internalname = "vDDO_BR_VITALIDTITLECONTROLIDTOREPLACE";
         Ddo_br_encounterid_Internalname = "DDO_BR_ENCOUNTERID";
         edtavDdo_br_encounteridtitlecontrolidtoreplace_Internalname = "vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE";
         Ddo_br_information_patientno_Internalname = "DDO_BR_INFORMATION_PATIENTNO";
         edtavDdo_br_information_patientnotitlecontrolidtoreplace_Internalname = "vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE";
         Ddo_br_vital_vitalid_Internalname = "DDO_BR_VITAL_VITALID";
         edtavDdo_br_vital_vitalidtitlecontrolidtoreplace_Internalname = "vDDO_BR_VITAL_VITALIDTITLECONTROLIDTOREPLACE";
         Ddo_br_vital_measuredate_Internalname = "DDO_BR_VITAL_MEASUREDATE";
         edtavDdo_br_vital_measuredatetitlecontrolidtoreplace_Internalname = "vDDO_BR_VITAL_MEASUREDATETITLECONTROLIDTOREPLACE";
         Ddo_br_vital_temperature_Internalname = "DDO_BR_VITAL_TEMPERATURE";
         edtavDdo_br_vital_temperaturetitlecontrolidtoreplace_Internalname = "vDDO_BR_VITAL_TEMPERATURETITLECONTROLIDTOREPLACE";
         Ddo_br_vital_pulse_Internalname = "DDO_BR_VITAL_PULSE";
         edtavDdo_br_vital_pulsetitlecontrolidtoreplace_Internalname = "vDDO_BR_VITAL_PULSETITLECONTROLIDTOREPLACE";
         Ddo_br_vital_respiration_Internalname = "DDO_BR_VITAL_RESPIRATION";
         edtavDdo_br_vital_respirationtitlecontrolidtoreplace_Internalname = "vDDO_BR_VITAL_RESPIRATIONTITLECONTROLIDTOREPLACE";
         Ddo_br_vital_systolic_Internalname = "DDO_BR_VITAL_SYSTOLIC";
         edtavDdo_br_vital_systolictitlecontrolidtoreplace_Internalname = "vDDO_BR_VITAL_SYSTOLICTITLECONTROLIDTOREPLACE";
         Ddo_br_vital_diastolic_Internalname = "DDO_BR_VITAL_DIASTOLIC";
         edtavDdo_br_vital_diastolictitlecontrolidtoreplace_Internalname = "vDDO_BR_VITAL_DIASTOLICTITLECONTROLIDTOREPLACE";
         Ddo_br_vital_height_Internalname = "DDO_BR_VITAL_HEIGHT";
         edtavDdo_br_vital_heighttitlecontrolidtoreplace_Internalname = "vDDO_BR_VITAL_HEIGHTTITLECONTROLIDTOREPLACE";
         Ddo_br_vital_weight_Internalname = "DDO_BR_VITAL_WEIGHT";
         edtavDdo_br_vital_weighttitlecontrolidtoreplace_Internalname = "vDDO_BR_VITAL_WEIGHTTITLECONTROLIDTOREPLACE";
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
         edtBR_Vital_Weight_Jsonclick = "";
         edtBR_Vital_Height_Jsonclick = "";
         edtBR_Vital_Diastolic_Jsonclick = "";
         edtBR_Vital_Systolic_Jsonclick = "";
         edtBR_Vital_Respiration_Jsonclick = "";
         edtBR_Vital_Pulse_Jsonclick = "";
         edtBR_Vital_Temperature_Jsonclick = "";
         edtBR_Vital_MeasureDate_Jsonclick = "";
         edtBR_Vital_VitalID_Jsonclick = "";
         edtBR_Information_PatientNo_Jsonclick = "";
         edtBR_EncounterID_Jsonclick = "";
         edtBR_VitalID_Jsonclick = "";
         edtavSelect_Jsonclick = "";
         edtavSelect_Visible = -1;
         edtavSelect_Enabled = 1;
         edtavOrdereddsc_Jsonclick = "";
         edtavOrdereddsc_Visible = 1;
         edtavOrderedby_Jsonclick = "";
         edtavOrderedby_Visible = 1;
         edtavDdo_br_vital_weighttitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_vital_heighttitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_vital_diastolictitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_vital_systolictitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_vital_respirationtitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_vital_pulsetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_vital_temperaturetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_vital_measuredatetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_vital_vitalidtitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_information_patientnotitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_encounteridtitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_vitalidtitlecontrolidtoreplace_Visible = 1;
         subGrid_Allowcollapsing = 0;
         subGrid_Allowselection = 0;
         edtavSelect_Tooltiptext = "选择";
         subGrid_Sortable = 0;
         subGrid_Header = "";
         edtBR_Vital_Weight_Titleformat = 0;
         edtBR_Vital_Weight_Title = "体重(kg)";
         edtBR_Vital_Height_Titleformat = 0;
         edtBR_Vital_Height_Title = "身高(cm)";
         edtBR_Vital_Diastolic_Titleformat = 0;
         edtBR_Vital_Diastolic_Title = "Hg)";
         edtBR_Vital_Systolic_Titleformat = 0;
         edtBR_Vital_Systolic_Title = "Hg)";
         edtBR_Vital_Respiration_Titleformat = 0;
         edtBR_Vital_Respiration_Title = "呼吸频率(次/分钟)";
         edtBR_Vital_Pulse_Titleformat = 0;
         edtBR_Vital_Pulse_Title = "脉搏(次/分钟)";
         edtBR_Vital_Temperature_Titleformat = 0;
         edtBR_Vital_Temperature_Title = "体温(℃)";
         edtBR_Vital_MeasureDate_Titleformat = 0;
         edtBR_Vital_MeasureDate_Title = "测量日期";
         edtBR_Vital_VitalID_Titleformat = 0;
         edtBR_Vital_VitalID_Title = "指标序号";
         edtBR_Information_PatientNo_Titleformat = 0;
         edtBR_Information_PatientNo_Title = "患者编号";
         edtBR_EncounterID_Titleformat = 0;
         edtBR_EncounterID_Title = "就诊信息主键";
         edtBR_VitalID_Titleformat = 0;
         edtBR_VitalID_Title = "生命体征主键";
         subGrid_Class = "GridWithPaginationBar GridWithBorderColor WorkWith";
         subGrid_Backcolorstyle = 0;
         divTablemain_Height = 0;
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
         Ddo_br_vital_height_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_vital_height_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_vital_height_Sortasc = "WWP_TSSortASC";
         Ddo_br_vital_height_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_vital_height_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_vital_height_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_vital_height_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_vital_height_Titlecontrolidtoreplace = "";
         Ddo_br_vital_height_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_vital_height_Cls = "ColumnSettings";
         Ddo_br_vital_height_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_vital_height_Caption = "";
         Ddo_br_vital_diastolic_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_vital_diastolic_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_vital_diastolic_Sortasc = "WWP_TSSortASC";
         Ddo_br_vital_diastolic_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_vital_diastolic_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_vital_diastolic_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_vital_diastolic_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_vital_diastolic_Titlecontrolidtoreplace = "";
         Ddo_br_vital_diastolic_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_vital_diastolic_Cls = "ColumnSettings";
         Ddo_br_vital_diastolic_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_vital_diastolic_Caption = "";
         Ddo_br_vital_systolic_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_vital_systolic_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_vital_systolic_Sortasc = "WWP_TSSortASC";
         Ddo_br_vital_systolic_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_vital_systolic_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_vital_systolic_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_vital_systolic_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_vital_systolic_Titlecontrolidtoreplace = "";
         Ddo_br_vital_systolic_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_vital_systolic_Cls = "ColumnSettings";
         Ddo_br_vital_systolic_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_vital_systolic_Caption = "";
         Ddo_br_vital_respiration_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_vital_respiration_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_vital_respiration_Sortasc = "WWP_TSSortASC";
         Ddo_br_vital_respiration_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_vital_respiration_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_vital_respiration_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_vital_respiration_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_vital_respiration_Titlecontrolidtoreplace = "";
         Ddo_br_vital_respiration_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_vital_respiration_Cls = "ColumnSettings";
         Ddo_br_vital_respiration_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_vital_respiration_Caption = "";
         Ddo_br_vital_pulse_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_vital_pulse_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_vital_pulse_Sortasc = "WWP_TSSortASC";
         Ddo_br_vital_pulse_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_vital_pulse_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_vital_pulse_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_vital_pulse_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_vital_pulse_Titlecontrolidtoreplace = "";
         Ddo_br_vital_pulse_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_vital_pulse_Cls = "ColumnSettings";
         Ddo_br_vital_pulse_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_vital_pulse_Caption = "";
         Ddo_br_vital_temperature_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_vital_temperature_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_vital_temperature_Sortasc = "WWP_TSSortASC";
         Ddo_br_vital_temperature_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_vital_temperature_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_vital_temperature_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_vital_temperature_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_vital_temperature_Titlecontrolidtoreplace = "";
         Ddo_br_vital_temperature_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_vital_temperature_Cls = "ColumnSettings";
         Ddo_br_vital_temperature_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_vital_temperature_Caption = "";
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
         Ddo_br_vital_vitalid_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_vital_vitalid_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_vital_vitalid_Sortasc = "WWP_TSSortASC";
         Ddo_br_vital_vitalid_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_vital_vitalid_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_vital_vitalid_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_vital_vitalid_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_vital_vitalid_Titlecontrolidtoreplace = "";
         Ddo_br_vital_vitalid_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_vital_vitalid_Cls = "ColumnSettings";
         Ddo_br_vital_vitalid_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_vital_vitalid_Caption = "";
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
         Form.Caption = "选择生命体征";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_VitalIDTitleControlIdToReplace',fld:'vDDO_BR_VITALIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Vital_VitalIDTitleControlIdToReplace',fld:'vDDO_BR_VITAL_VITALIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Vital_MeasureDateTitleControlIdToReplace',fld:'vDDO_BR_VITAL_MEASUREDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_Vital_TemperatureTitleControlIdToReplace',fld:'vDDO_BR_VITAL_TEMPERATURETITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Vital_PulseTitleControlIdToReplace',fld:'vDDO_BR_VITAL_PULSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Vital_RespirationTitleControlIdToReplace',fld:'vDDO_BR_VITAL_RESPIRATIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_BR_Vital_SystolicTitleControlIdToReplace',fld:'vDDO_BR_VITAL_SYSTOLICTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Vital_DiastolicTitleControlIdToReplace',fld:'vDDO_BR_VITAL_DIASTOLICTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Vital_HeightTitleControlIdToReplace',fld:'vDDO_BR_VITAL_HEIGHTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Vital_WeightTitleControlIdToReplace',fld:'vDDO_BR_VITAL_WEIGHTTITLECONTROLIDTOREPLACE',pic:''},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]");
         setEventMetadata("REFRESH",",oparms:[{av:'AV12BR_VitalIDTitleFilterData',fld:'vBR_VITALIDTITLEFILTERDATA',pic:''},{av:'AV14BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV16BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV18BR_Vital_VitalIDTitleFilterData',fld:'vBR_VITAL_VITALIDTITLEFILTERDATA',pic:''},{av:'AV20BR_Vital_MeasureDateTitleFilterData',fld:'vBR_VITAL_MEASUREDATETITLEFILTERDATA',pic:''},{av:'AV22BR_Vital_TemperatureTitleFilterData',fld:'vBR_VITAL_TEMPERATURETITLEFILTERDATA',pic:''},{av:'AV24BR_Vital_PulseTitleFilterData',fld:'vBR_VITAL_PULSETITLEFILTERDATA',pic:''},{av:'AV26BR_Vital_RespirationTitleFilterData',fld:'vBR_VITAL_RESPIRATIONTITLEFILTERDATA',pic:''},{av:'AV28BR_Vital_SystolicTitleFilterData',fld:'vBR_VITAL_SYSTOLICTITLEFILTERDATA',pic:''},{av:'AV30BR_Vital_DiastolicTitleFilterData',fld:'vBR_VITAL_DIASTOLICTITLEFILTERDATA',pic:''},{av:'AV32BR_Vital_HeightTitleFilterData',fld:'vBR_VITAL_HEIGHTTITLEFILTERDATA',pic:''},{av:'AV34BR_Vital_WeightTitleFilterData',fld:'vBR_VITAL_WEIGHTTITLEFILTERDATA',pic:''},{av:'edtBR_VitalID_Titleformat',ctrl:'BR_VITALID',prop:'Titleformat'},{av:'edtBR_VitalID_Title',ctrl:'BR_VITALID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Vital_VitalID_Titleformat',ctrl:'BR_VITAL_VITALID',prop:'Titleformat'},{av:'edtBR_Vital_VitalID_Title',ctrl:'BR_VITAL_VITALID',prop:'Title'},{av:'edtBR_Vital_MeasureDate_Titleformat',ctrl:'BR_VITAL_MEASUREDATE',prop:'Titleformat'},{av:'edtBR_Vital_MeasureDate_Title',ctrl:'BR_VITAL_MEASUREDATE',prop:'Title'},{av:'edtBR_Vital_Temperature_Titleformat',ctrl:'BR_VITAL_TEMPERATURE',prop:'Titleformat'},{av:'edtBR_Vital_Temperature_Title',ctrl:'BR_VITAL_TEMPERATURE',prop:'Title'},{av:'edtBR_Vital_Pulse_Titleformat',ctrl:'BR_VITAL_PULSE',prop:'Titleformat'},{av:'edtBR_Vital_Pulse_Title',ctrl:'BR_VITAL_PULSE',prop:'Title'},{av:'edtBR_Vital_Respiration_Titleformat',ctrl:'BR_VITAL_RESPIRATION',prop:'Titleformat'},{av:'edtBR_Vital_Respiration_Title',ctrl:'BR_VITAL_RESPIRATION',prop:'Title'},{av:'edtBR_Vital_Systolic_Titleformat',ctrl:'BR_VITAL_SYSTOLIC',prop:'Titleformat'},{av:'edtBR_Vital_Systolic_Title',ctrl:'BR_VITAL_SYSTOLIC',prop:'Title'},{av:'edtBR_Vital_Diastolic_Titleformat',ctrl:'BR_VITAL_DIASTOLIC',prop:'Titleformat'},{av:'edtBR_Vital_Diastolic_Title',ctrl:'BR_VITAL_DIASTOLIC',prop:'Title'},{av:'edtBR_Vital_Height_Titleformat',ctrl:'BR_VITAL_HEIGHT',prop:'Titleformat'},{av:'edtBR_Vital_Height_Title',ctrl:'BR_VITAL_HEIGHT',prop:'Title'},{av:'edtBR_Vital_Weight_Titleformat',ctrl:'BR_VITAL_WEIGHT',prop:'Titleformat'},{av:'edtBR_Vital_Weight_Title',ctrl:'BR_VITAL_WEIGHT',prop:'Title'},{av:'AV38GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV39GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV40GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE","{handler:'E11622',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_VitalIDTitleControlIdToReplace',fld:'vDDO_BR_VITALIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Vital_VitalIDTitleControlIdToReplace',fld:'vDDO_BR_VITAL_VITALIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Vital_MeasureDateTitleControlIdToReplace',fld:'vDDO_BR_VITAL_MEASUREDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_Vital_TemperatureTitleControlIdToReplace',fld:'vDDO_BR_VITAL_TEMPERATURETITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Vital_PulseTitleControlIdToReplace',fld:'vDDO_BR_VITAL_PULSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Vital_RespirationTitleControlIdToReplace',fld:'vDDO_BR_VITAL_RESPIRATIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_BR_Vital_SystolicTitleControlIdToReplace',fld:'vDDO_BR_VITAL_SYSTOLICTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Vital_DiastolicTitleControlIdToReplace',fld:'vDDO_BR_VITAL_DIASTOLICTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Vital_HeightTitleControlIdToReplace',fld:'vDDO_BR_VITAL_HEIGHTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Vital_WeightTitleControlIdToReplace',fld:'vDDO_BR_VITAL_WEIGHTTITLECONTROLIDTOREPLACE',pic:''},{av:'Gridpaginationbar_Selectedpage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE",",oparms:[]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE","{handler:'E12622',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_VitalIDTitleControlIdToReplace',fld:'vDDO_BR_VITALIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Vital_VitalIDTitleControlIdToReplace',fld:'vDDO_BR_VITAL_VITALIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Vital_MeasureDateTitleControlIdToReplace',fld:'vDDO_BR_VITAL_MEASUREDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_Vital_TemperatureTitleControlIdToReplace',fld:'vDDO_BR_VITAL_TEMPERATURETITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Vital_PulseTitleControlIdToReplace',fld:'vDDO_BR_VITAL_PULSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Vital_RespirationTitleControlIdToReplace',fld:'vDDO_BR_VITAL_RESPIRATIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_BR_Vital_SystolicTitleControlIdToReplace',fld:'vDDO_BR_VITAL_SYSTOLICTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Vital_DiastolicTitleControlIdToReplace',fld:'vDDO_BR_VITAL_DIASTOLICTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Vital_HeightTitleControlIdToReplace',fld:'vDDO_BR_VITAL_HEIGHTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Vital_WeightTitleControlIdToReplace',fld:'vDDO_BR_VITAL_WEIGHTTITLECONTROLIDTOREPLACE',pic:''},{av:'Gridpaginationbar_Rowsperpageselectedvalue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE",",oparms:[{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]}");
         setEventMetadata("DDO_BR_VITALID.ONOPTIONCLICKED","{handler:'E13622',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_VitalIDTitleControlIdToReplace',fld:'vDDO_BR_VITALIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Vital_VitalIDTitleControlIdToReplace',fld:'vDDO_BR_VITAL_VITALIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Vital_MeasureDateTitleControlIdToReplace',fld:'vDDO_BR_VITAL_MEASUREDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_Vital_TemperatureTitleControlIdToReplace',fld:'vDDO_BR_VITAL_TEMPERATURETITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Vital_PulseTitleControlIdToReplace',fld:'vDDO_BR_VITAL_PULSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Vital_RespirationTitleControlIdToReplace',fld:'vDDO_BR_VITAL_RESPIRATIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_BR_Vital_SystolicTitleControlIdToReplace',fld:'vDDO_BR_VITAL_SYSTOLICTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Vital_DiastolicTitleControlIdToReplace',fld:'vDDO_BR_VITAL_DIASTOLICTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Vital_HeightTitleControlIdToReplace',fld:'vDDO_BR_VITAL_HEIGHTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Vital_WeightTitleControlIdToReplace',fld:'vDDO_BR_VITAL_WEIGHTTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_vitalid_Activeeventkey',ctrl:'DDO_BR_VITALID',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_VITALID.ONOPTIONCLICKED",",oparms:[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_vitalid_Sortedstatus',ctrl:'DDO_BR_VITALID',prop:'SortedStatus'},{av:'AV12BR_VitalIDTitleFilterData',fld:'vBR_VITALIDTITLEFILTERDATA',pic:''},{av:'AV14BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV16BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV18BR_Vital_VitalIDTitleFilterData',fld:'vBR_VITAL_VITALIDTITLEFILTERDATA',pic:''},{av:'AV20BR_Vital_MeasureDateTitleFilterData',fld:'vBR_VITAL_MEASUREDATETITLEFILTERDATA',pic:''},{av:'AV22BR_Vital_TemperatureTitleFilterData',fld:'vBR_VITAL_TEMPERATURETITLEFILTERDATA',pic:''},{av:'AV24BR_Vital_PulseTitleFilterData',fld:'vBR_VITAL_PULSETITLEFILTERDATA',pic:''},{av:'AV26BR_Vital_RespirationTitleFilterData',fld:'vBR_VITAL_RESPIRATIONTITLEFILTERDATA',pic:''},{av:'AV28BR_Vital_SystolicTitleFilterData',fld:'vBR_VITAL_SYSTOLICTITLEFILTERDATA',pic:''},{av:'AV30BR_Vital_DiastolicTitleFilterData',fld:'vBR_VITAL_DIASTOLICTITLEFILTERDATA',pic:''},{av:'AV32BR_Vital_HeightTitleFilterData',fld:'vBR_VITAL_HEIGHTTITLEFILTERDATA',pic:''},{av:'AV34BR_Vital_WeightTitleFilterData',fld:'vBR_VITAL_WEIGHTTITLEFILTERDATA',pic:''},{av:'edtBR_VitalID_Titleformat',ctrl:'BR_VITALID',prop:'Titleformat'},{av:'edtBR_VitalID_Title',ctrl:'BR_VITALID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Vital_VitalID_Titleformat',ctrl:'BR_VITAL_VITALID',prop:'Titleformat'},{av:'edtBR_Vital_VitalID_Title',ctrl:'BR_VITAL_VITALID',prop:'Title'},{av:'edtBR_Vital_MeasureDate_Titleformat',ctrl:'BR_VITAL_MEASUREDATE',prop:'Titleformat'},{av:'edtBR_Vital_MeasureDate_Title',ctrl:'BR_VITAL_MEASUREDATE',prop:'Title'},{av:'edtBR_Vital_Temperature_Titleformat',ctrl:'BR_VITAL_TEMPERATURE',prop:'Titleformat'},{av:'edtBR_Vital_Temperature_Title',ctrl:'BR_VITAL_TEMPERATURE',prop:'Title'},{av:'edtBR_Vital_Pulse_Titleformat',ctrl:'BR_VITAL_PULSE',prop:'Titleformat'},{av:'edtBR_Vital_Pulse_Title',ctrl:'BR_VITAL_PULSE',prop:'Title'},{av:'edtBR_Vital_Respiration_Titleformat',ctrl:'BR_VITAL_RESPIRATION',prop:'Titleformat'},{av:'edtBR_Vital_Respiration_Title',ctrl:'BR_VITAL_RESPIRATION',prop:'Title'},{av:'edtBR_Vital_Systolic_Titleformat',ctrl:'BR_VITAL_SYSTOLIC',prop:'Titleformat'},{av:'edtBR_Vital_Systolic_Title',ctrl:'BR_VITAL_SYSTOLIC',prop:'Title'},{av:'edtBR_Vital_Diastolic_Titleformat',ctrl:'BR_VITAL_DIASTOLIC',prop:'Titleformat'},{av:'edtBR_Vital_Diastolic_Title',ctrl:'BR_VITAL_DIASTOLIC',prop:'Title'},{av:'edtBR_Vital_Height_Titleformat',ctrl:'BR_VITAL_HEIGHT',prop:'Titleformat'},{av:'edtBR_Vital_Height_Title',ctrl:'BR_VITAL_HEIGHT',prop:'Title'},{av:'edtBR_Vital_Weight_Titleformat',ctrl:'BR_VITAL_WEIGHT',prop:'Titleformat'},{av:'edtBR_Vital_Weight_Title',ctrl:'BR_VITAL_WEIGHT',prop:'Title'},{av:'AV38GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV39GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV40GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_ENCOUNTERID.ONOPTIONCLICKED","{handler:'E14622',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_VitalIDTitleControlIdToReplace',fld:'vDDO_BR_VITALIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Vital_VitalIDTitleControlIdToReplace',fld:'vDDO_BR_VITAL_VITALIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Vital_MeasureDateTitleControlIdToReplace',fld:'vDDO_BR_VITAL_MEASUREDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_Vital_TemperatureTitleControlIdToReplace',fld:'vDDO_BR_VITAL_TEMPERATURETITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Vital_PulseTitleControlIdToReplace',fld:'vDDO_BR_VITAL_PULSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Vital_RespirationTitleControlIdToReplace',fld:'vDDO_BR_VITAL_RESPIRATIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_BR_Vital_SystolicTitleControlIdToReplace',fld:'vDDO_BR_VITAL_SYSTOLICTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Vital_DiastolicTitleControlIdToReplace',fld:'vDDO_BR_VITAL_DIASTOLICTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Vital_HeightTitleControlIdToReplace',fld:'vDDO_BR_VITAL_HEIGHTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Vital_WeightTitleControlIdToReplace',fld:'vDDO_BR_VITAL_WEIGHTTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_encounterid_Activeeventkey',ctrl:'DDO_BR_ENCOUNTERID',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_ENCOUNTERID.ONOPTIONCLICKED",",oparms:[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_encounterid_Sortedstatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'AV12BR_VitalIDTitleFilterData',fld:'vBR_VITALIDTITLEFILTERDATA',pic:''},{av:'AV14BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV16BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV18BR_Vital_VitalIDTitleFilterData',fld:'vBR_VITAL_VITALIDTITLEFILTERDATA',pic:''},{av:'AV20BR_Vital_MeasureDateTitleFilterData',fld:'vBR_VITAL_MEASUREDATETITLEFILTERDATA',pic:''},{av:'AV22BR_Vital_TemperatureTitleFilterData',fld:'vBR_VITAL_TEMPERATURETITLEFILTERDATA',pic:''},{av:'AV24BR_Vital_PulseTitleFilterData',fld:'vBR_VITAL_PULSETITLEFILTERDATA',pic:''},{av:'AV26BR_Vital_RespirationTitleFilterData',fld:'vBR_VITAL_RESPIRATIONTITLEFILTERDATA',pic:''},{av:'AV28BR_Vital_SystolicTitleFilterData',fld:'vBR_VITAL_SYSTOLICTITLEFILTERDATA',pic:''},{av:'AV30BR_Vital_DiastolicTitleFilterData',fld:'vBR_VITAL_DIASTOLICTITLEFILTERDATA',pic:''},{av:'AV32BR_Vital_HeightTitleFilterData',fld:'vBR_VITAL_HEIGHTTITLEFILTERDATA',pic:''},{av:'AV34BR_Vital_WeightTitleFilterData',fld:'vBR_VITAL_WEIGHTTITLEFILTERDATA',pic:''},{av:'edtBR_VitalID_Titleformat',ctrl:'BR_VITALID',prop:'Titleformat'},{av:'edtBR_VitalID_Title',ctrl:'BR_VITALID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Vital_VitalID_Titleformat',ctrl:'BR_VITAL_VITALID',prop:'Titleformat'},{av:'edtBR_Vital_VitalID_Title',ctrl:'BR_VITAL_VITALID',prop:'Title'},{av:'edtBR_Vital_MeasureDate_Titleformat',ctrl:'BR_VITAL_MEASUREDATE',prop:'Titleformat'},{av:'edtBR_Vital_MeasureDate_Title',ctrl:'BR_VITAL_MEASUREDATE',prop:'Title'},{av:'edtBR_Vital_Temperature_Titleformat',ctrl:'BR_VITAL_TEMPERATURE',prop:'Titleformat'},{av:'edtBR_Vital_Temperature_Title',ctrl:'BR_VITAL_TEMPERATURE',prop:'Title'},{av:'edtBR_Vital_Pulse_Titleformat',ctrl:'BR_VITAL_PULSE',prop:'Titleformat'},{av:'edtBR_Vital_Pulse_Title',ctrl:'BR_VITAL_PULSE',prop:'Title'},{av:'edtBR_Vital_Respiration_Titleformat',ctrl:'BR_VITAL_RESPIRATION',prop:'Titleformat'},{av:'edtBR_Vital_Respiration_Title',ctrl:'BR_VITAL_RESPIRATION',prop:'Title'},{av:'edtBR_Vital_Systolic_Titleformat',ctrl:'BR_VITAL_SYSTOLIC',prop:'Titleformat'},{av:'edtBR_Vital_Systolic_Title',ctrl:'BR_VITAL_SYSTOLIC',prop:'Title'},{av:'edtBR_Vital_Diastolic_Titleformat',ctrl:'BR_VITAL_DIASTOLIC',prop:'Titleformat'},{av:'edtBR_Vital_Diastolic_Title',ctrl:'BR_VITAL_DIASTOLIC',prop:'Title'},{av:'edtBR_Vital_Height_Titleformat',ctrl:'BR_VITAL_HEIGHT',prop:'Titleformat'},{av:'edtBR_Vital_Height_Title',ctrl:'BR_VITAL_HEIGHT',prop:'Title'},{av:'edtBR_Vital_Weight_Titleformat',ctrl:'BR_VITAL_WEIGHT',prop:'Titleformat'},{av:'edtBR_Vital_Weight_Title',ctrl:'BR_VITAL_WEIGHT',prop:'Title'},{av:'AV38GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV39GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV40GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_INFORMATION_PATIENTNO.ONOPTIONCLICKED","{handler:'E15622',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_VitalIDTitleControlIdToReplace',fld:'vDDO_BR_VITALIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Vital_VitalIDTitleControlIdToReplace',fld:'vDDO_BR_VITAL_VITALIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Vital_MeasureDateTitleControlIdToReplace',fld:'vDDO_BR_VITAL_MEASUREDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_Vital_TemperatureTitleControlIdToReplace',fld:'vDDO_BR_VITAL_TEMPERATURETITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Vital_PulseTitleControlIdToReplace',fld:'vDDO_BR_VITAL_PULSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Vital_RespirationTitleControlIdToReplace',fld:'vDDO_BR_VITAL_RESPIRATIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_BR_Vital_SystolicTitleControlIdToReplace',fld:'vDDO_BR_VITAL_SYSTOLICTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Vital_DiastolicTitleControlIdToReplace',fld:'vDDO_BR_VITAL_DIASTOLICTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Vital_HeightTitleControlIdToReplace',fld:'vDDO_BR_VITAL_HEIGHTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Vital_WeightTitleControlIdToReplace',fld:'vDDO_BR_VITAL_WEIGHTTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_information_patientno_Activeeventkey',ctrl:'DDO_BR_INFORMATION_PATIENTNO',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_INFORMATION_PATIENTNO.ONOPTIONCLICKED",",oparms:[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_information_patientno_Sortedstatus',ctrl:'DDO_BR_INFORMATION_PATIENTNO',prop:'SortedStatus'},{av:'AV12BR_VitalIDTitleFilterData',fld:'vBR_VITALIDTITLEFILTERDATA',pic:''},{av:'AV14BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV16BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV18BR_Vital_VitalIDTitleFilterData',fld:'vBR_VITAL_VITALIDTITLEFILTERDATA',pic:''},{av:'AV20BR_Vital_MeasureDateTitleFilterData',fld:'vBR_VITAL_MEASUREDATETITLEFILTERDATA',pic:''},{av:'AV22BR_Vital_TemperatureTitleFilterData',fld:'vBR_VITAL_TEMPERATURETITLEFILTERDATA',pic:''},{av:'AV24BR_Vital_PulseTitleFilterData',fld:'vBR_VITAL_PULSETITLEFILTERDATA',pic:''},{av:'AV26BR_Vital_RespirationTitleFilterData',fld:'vBR_VITAL_RESPIRATIONTITLEFILTERDATA',pic:''},{av:'AV28BR_Vital_SystolicTitleFilterData',fld:'vBR_VITAL_SYSTOLICTITLEFILTERDATA',pic:''},{av:'AV30BR_Vital_DiastolicTitleFilterData',fld:'vBR_VITAL_DIASTOLICTITLEFILTERDATA',pic:''},{av:'AV32BR_Vital_HeightTitleFilterData',fld:'vBR_VITAL_HEIGHTTITLEFILTERDATA',pic:''},{av:'AV34BR_Vital_WeightTitleFilterData',fld:'vBR_VITAL_WEIGHTTITLEFILTERDATA',pic:''},{av:'edtBR_VitalID_Titleformat',ctrl:'BR_VITALID',prop:'Titleformat'},{av:'edtBR_VitalID_Title',ctrl:'BR_VITALID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Vital_VitalID_Titleformat',ctrl:'BR_VITAL_VITALID',prop:'Titleformat'},{av:'edtBR_Vital_VitalID_Title',ctrl:'BR_VITAL_VITALID',prop:'Title'},{av:'edtBR_Vital_MeasureDate_Titleformat',ctrl:'BR_VITAL_MEASUREDATE',prop:'Titleformat'},{av:'edtBR_Vital_MeasureDate_Title',ctrl:'BR_VITAL_MEASUREDATE',prop:'Title'},{av:'edtBR_Vital_Temperature_Titleformat',ctrl:'BR_VITAL_TEMPERATURE',prop:'Titleformat'},{av:'edtBR_Vital_Temperature_Title',ctrl:'BR_VITAL_TEMPERATURE',prop:'Title'},{av:'edtBR_Vital_Pulse_Titleformat',ctrl:'BR_VITAL_PULSE',prop:'Titleformat'},{av:'edtBR_Vital_Pulse_Title',ctrl:'BR_VITAL_PULSE',prop:'Title'},{av:'edtBR_Vital_Respiration_Titleformat',ctrl:'BR_VITAL_RESPIRATION',prop:'Titleformat'},{av:'edtBR_Vital_Respiration_Title',ctrl:'BR_VITAL_RESPIRATION',prop:'Title'},{av:'edtBR_Vital_Systolic_Titleformat',ctrl:'BR_VITAL_SYSTOLIC',prop:'Titleformat'},{av:'edtBR_Vital_Systolic_Title',ctrl:'BR_VITAL_SYSTOLIC',prop:'Title'},{av:'edtBR_Vital_Diastolic_Titleformat',ctrl:'BR_VITAL_DIASTOLIC',prop:'Titleformat'},{av:'edtBR_Vital_Diastolic_Title',ctrl:'BR_VITAL_DIASTOLIC',prop:'Title'},{av:'edtBR_Vital_Height_Titleformat',ctrl:'BR_VITAL_HEIGHT',prop:'Titleformat'},{av:'edtBR_Vital_Height_Title',ctrl:'BR_VITAL_HEIGHT',prop:'Title'},{av:'edtBR_Vital_Weight_Titleformat',ctrl:'BR_VITAL_WEIGHT',prop:'Titleformat'},{av:'edtBR_Vital_Weight_Title',ctrl:'BR_VITAL_WEIGHT',prop:'Title'},{av:'AV38GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV39GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV40GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_VITAL_VITALID.ONOPTIONCLICKED","{handler:'E16622',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_VitalIDTitleControlIdToReplace',fld:'vDDO_BR_VITALIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Vital_VitalIDTitleControlIdToReplace',fld:'vDDO_BR_VITAL_VITALIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Vital_MeasureDateTitleControlIdToReplace',fld:'vDDO_BR_VITAL_MEASUREDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_Vital_TemperatureTitleControlIdToReplace',fld:'vDDO_BR_VITAL_TEMPERATURETITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Vital_PulseTitleControlIdToReplace',fld:'vDDO_BR_VITAL_PULSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Vital_RespirationTitleControlIdToReplace',fld:'vDDO_BR_VITAL_RESPIRATIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_BR_Vital_SystolicTitleControlIdToReplace',fld:'vDDO_BR_VITAL_SYSTOLICTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Vital_DiastolicTitleControlIdToReplace',fld:'vDDO_BR_VITAL_DIASTOLICTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Vital_HeightTitleControlIdToReplace',fld:'vDDO_BR_VITAL_HEIGHTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Vital_WeightTitleControlIdToReplace',fld:'vDDO_BR_VITAL_WEIGHTTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_vital_vitalid_Activeeventkey',ctrl:'DDO_BR_VITAL_VITALID',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_VITAL_VITALID.ONOPTIONCLICKED",",oparms:[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_vital_vitalid_Sortedstatus',ctrl:'DDO_BR_VITAL_VITALID',prop:'SortedStatus'},{av:'AV12BR_VitalIDTitleFilterData',fld:'vBR_VITALIDTITLEFILTERDATA',pic:''},{av:'AV14BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV16BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV18BR_Vital_VitalIDTitleFilterData',fld:'vBR_VITAL_VITALIDTITLEFILTERDATA',pic:''},{av:'AV20BR_Vital_MeasureDateTitleFilterData',fld:'vBR_VITAL_MEASUREDATETITLEFILTERDATA',pic:''},{av:'AV22BR_Vital_TemperatureTitleFilterData',fld:'vBR_VITAL_TEMPERATURETITLEFILTERDATA',pic:''},{av:'AV24BR_Vital_PulseTitleFilterData',fld:'vBR_VITAL_PULSETITLEFILTERDATA',pic:''},{av:'AV26BR_Vital_RespirationTitleFilterData',fld:'vBR_VITAL_RESPIRATIONTITLEFILTERDATA',pic:''},{av:'AV28BR_Vital_SystolicTitleFilterData',fld:'vBR_VITAL_SYSTOLICTITLEFILTERDATA',pic:''},{av:'AV30BR_Vital_DiastolicTitleFilterData',fld:'vBR_VITAL_DIASTOLICTITLEFILTERDATA',pic:''},{av:'AV32BR_Vital_HeightTitleFilterData',fld:'vBR_VITAL_HEIGHTTITLEFILTERDATA',pic:''},{av:'AV34BR_Vital_WeightTitleFilterData',fld:'vBR_VITAL_WEIGHTTITLEFILTERDATA',pic:''},{av:'edtBR_VitalID_Titleformat',ctrl:'BR_VITALID',prop:'Titleformat'},{av:'edtBR_VitalID_Title',ctrl:'BR_VITALID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Vital_VitalID_Titleformat',ctrl:'BR_VITAL_VITALID',prop:'Titleformat'},{av:'edtBR_Vital_VitalID_Title',ctrl:'BR_VITAL_VITALID',prop:'Title'},{av:'edtBR_Vital_MeasureDate_Titleformat',ctrl:'BR_VITAL_MEASUREDATE',prop:'Titleformat'},{av:'edtBR_Vital_MeasureDate_Title',ctrl:'BR_VITAL_MEASUREDATE',prop:'Title'},{av:'edtBR_Vital_Temperature_Titleformat',ctrl:'BR_VITAL_TEMPERATURE',prop:'Titleformat'},{av:'edtBR_Vital_Temperature_Title',ctrl:'BR_VITAL_TEMPERATURE',prop:'Title'},{av:'edtBR_Vital_Pulse_Titleformat',ctrl:'BR_VITAL_PULSE',prop:'Titleformat'},{av:'edtBR_Vital_Pulse_Title',ctrl:'BR_VITAL_PULSE',prop:'Title'},{av:'edtBR_Vital_Respiration_Titleformat',ctrl:'BR_VITAL_RESPIRATION',prop:'Titleformat'},{av:'edtBR_Vital_Respiration_Title',ctrl:'BR_VITAL_RESPIRATION',prop:'Title'},{av:'edtBR_Vital_Systolic_Titleformat',ctrl:'BR_VITAL_SYSTOLIC',prop:'Titleformat'},{av:'edtBR_Vital_Systolic_Title',ctrl:'BR_VITAL_SYSTOLIC',prop:'Title'},{av:'edtBR_Vital_Diastolic_Titleformat',ctrl:'BR_VITAL_DIASTOLIC',prop:'Titleformat'},{av:'edtBR_Vital_Diastolic_Title',ctrl:'BR_VITAL_DIASTOLIC',prop:'Title'},{av:'edtBR_Vital_Height_Titleformat',ctrl:'BR_VITAL_HEIGHT',prop:'Titleformat'},{av:'edtBR_Vital_Height_Title',ctrl:'BR_VITAL_HEIGHT',prop:'Title'},{av:'edtBR_Vital_Weight_Titleformat',ctrl:'BR_VITAL_WEIGHT',prop:'Titleformat'},{av:'edtBR_Vital_Weight_Title',ctrl:'BR_VITAL_WEIGHT',prop:'Title'},{av:'AV38GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV39GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV40GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_VITAL_MEASUREDATE.ONOPTIONCLICKED","{handler:'E17622',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_VitalIDTitleControlIdToReplace',fld:'vDDO_BR_VITALIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Vital_VitalIDTitleControlIdToReplace',fld:'vDDO_BR_VITAL_VITALIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Vital_MeasureDateTitleControlIdToReplace',fld:'vDDO_BR_VITAL_MEASUREDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_Vital_TemperatureTitleControlIdToReplace',fld:'vDDO_BR_VITAL_TEMPERATURETITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Vital_PulseTitleControlIdToReplace',fld:'vDDO_BR_VITAL_PULSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Vital_RespirationTitleControlIdToReplace',fld:'vDDO_BR_VITAL_RESPIRATIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_BR_Vital_SystolicTitleControlIdToReplace',fld:'vDDO_BR_VITAL_SYSTOLICTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Vital_DiastolicTitleControlIdToReplace',fld:'vDDO_BR_VITAL_DIASTOLICTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Vital_HeightTitleControlIdToReplace',fld:'vDDO_BR_VITAL_HEIGHTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Vital_WeightTitleControlIdToReplace',fld:'vDDO_BR_VITAL_WEIGHTTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_vital_measuredate_Activeeventkey',ctrl:'DDO_BR_VITAL_MEASUREDATE',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_VITAL_MEASUREDATE.ONOPTIONCLICKED",",oparms:[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_vital_measuredate_Sortedstatus',ctrl:'DDO_BR_VITAL_MEASUREDATE',prop:'SortedStatus'},{av:'AV12BR_VitalIDTitleFilterData',fld:'vBR_VITALIDTITLEFILTERDATA',pic:''},{av:'AV14BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV16BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV18BR_Vital_VitalIDTitleFilterData',fld:'vBR_VITAL_VITALIDTITLEFILTERDATA',pic:''},{av:'AV20BR_Vital_MeasureDateTitleFilterData',fld:'vBR_VITAL_MEASUREDATETITLEFILTERDATA',pic:''},{av:'AV22BR_Vital_TemperatureTitleFilterData',fld:'vBR_VITAL_TEMPERATURETITLEFILTERDATA',pic:''},{av:'AV24BR_Vital_PulseTitleFilterData',fld:'vBR_VITAL_PULSETITLEFILTERDATA',pic:''},{av:'AV26BR_Vital_RespirationTitleFilterData',fld:'vBR_VITAL_RESPIRATIONTITLEFILTERDATA',pic:''},{av:'AV28BR_Vital_SystolicTitleFilterData',fld:'vBR_VITAL_SYSTOLICTITLEFILTERDATA',pic:''},{av:'AV30BR_Vital_DiastolicTitleFilterData',fld:'vBR_VITAL_DIASTOLICTITLEFILTERDATA',pic:''},{av:'AV32BR_Vital_HeightTitleFilterData',fld:'vBR_VITAL_HEIGHTTITLEFILTERDATA',pic:''},{av:'AV34BR_Vital_WeightTitleFilterData',fld:'vBR_VITAL_WEIGHTTITLEFILTERDATA',pic:''},{av:'edtBR_VitalID_Titleformat',ctrl:'BR_VITALID',prop:'Titleformat'},{av:'edtBR_VitalID_Title',ctrl:'BR_VITALID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Vital_VitalID_Titleformat',ctrl:'BR_VITAL_VITALID',prop:'Titleformat'},{av:'edtBR_Vital_VitalID_Title',ctrl:'BR_VITAL_VITALID',prop:'Title'},{av:'edtBR_Vital_MeasureDate_Titleformat',ctrl:'BR_VITAL_MEASUREDATE',prop:'Titleformat'},{av:'edtBR_Vital_MeasureDate_Title',ctrl:'BR_VITAL_MEASUREDATE',prop:'Title'},{av:'edtBR_Vital_Temperature_Titleformat',ctrl:'BR_VITAL_TEMPERATURE',prop:'Titleformat'},{av:'edtBR_Vital_Temperature_Title',ctrl:'BR_VITAL_TEMPERATURE',prop:'Title'},{av:'edtBR_Vital_Pulse_Titleformat',ctrl:'BR_VITAL_PULSE',prop:'Titleformat'},{av:'edtBR_Vital_Pulse_Title',ctrl:'BR_VITAL_PULSE',prop:'Title'},{av:'edtBR_Vital_Respiration_Titleformat',ctrl:'BR_VITAL_RESPIRATION',prop:'Titleformat'},{av:'edtBR_Vital_Respiration_Title',ctrl:'BR_VITAL_RESPIRATION',prop:'Title'},{av:'edtBR_Vital_Systolic_Titleformat',ctrl:'BR_VITAL_SYSTOLIC',prop:'Titleformat'},{av:'edtBR_Vital_Systolic_Title',ctrl:'BR_VITAL_SYSTOLIC',prop:'Title'},{av:'edtBR_Vital_Diastolic_Titleformat',ctrl:'BR_VITAL_DIASTOLIC',prop:'Titleformat'},{av:'edtBR_Vital_Diastolic_Title',ctrl:'BR_VITAL_DIASTOLIC',prop:'Title'},{av:'edtBR_Vital_Height_Titleformat',ctrl:'BR_VITAL_HEIGHT',prop:'Titleformat'},{av:'edtBR_Vital_Height_Title',ctrl:'BR_VITAL_HEIGHT',prop:'Title'},{av:'edtBR_Vital_Weight_Titleformat',ctrl:'BR_VITAL_WEIGHT',prop:'Titleformat'},{av:'edtBR_Vital_Weight_Title',ctrl:'BR_VITAL_WEIGHT',prop:'Title'},{av:'AV38GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV39GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV40GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_VITAL_TEMPERATURE.ONOPTIONCLICKED","{handler:'E18622',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_VitalIDTitleControlIdToReplace',fld:'vDDO_BR_VITALIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Vital_VitalIDTitleControlIdToReplace',fld:'vDDO_BR_VITAL_VITALIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Vital_MeasureDateTitleControlIdToReplace',fld:'vDDO_BR_VITAL_MEASUREDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_Vital_TemperatureTitleControlIdToReplace',fld:'vDDO_BR_VITAL_TEMPERATURETITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Vital_PulseTitleControlIdToReplace',fld:'vDDO_BR_VITAL_PULSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Vital_RespirationTitleControlIdToReplace',fld:'vDDO_BR_VITAL_RESPIRATIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_BR_Vital_SystolicTitleControlIdToReplace',fld:'vDDO_BR_VITAL_SYSTOLICTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Vital_DiastolicTitleControlIdToReplace',fld:'vDDO_BR_VITAL_DIASTOLICTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Vital_HeightTitleControlIdToReplace',fld:'vDDO_BR_VITAL_HEIGHTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Vital_WeightTitleControlIdToReplace',fld:'vDDO_BR_VITAL_WEIGHTTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_vital_temperature_Activeeventkey',ctrl:'DDO_BR_VITAL_TEMPERATURE',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_VITAL_TEMPERATURE.ONOPTIONCLICKED",",oparms:[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_vital_temperature_Sortedstatus',ctrl:'DDO_BR_VITAL_TEMPERATURE',prop:'SortedStatus'},{av:'AV12BR_VitalIDTitleFilterData',fld:'vBR_VITALIDTITLEFILTERDATA',pic:''},{av:'AV14BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV16BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV18BR_Vital_VitalIDTitleFilterData',fld:'vBR_VITAL_VITALIDTITLEFILTERDATA',pic:''},{av:'AV20BR_Vital_MeasureDateTitleFilterData',fld:'vBR_VITAL_MEASUREDATETITLEFILTERDATA',pic:''},{av:'AV22BR_Vital_TemperatureTitleFilterData',fld:'vBR_VITAL_TEMPERATURETITLEFILTERDATA',pic:''},{av:'AV24BR_Vital_PulseTitleFilterData',fld:'vBR_VITAL_PULSETITLEFILTERDATA',pic:''},{av:'AV26BR_Vital_RespirationTitleFilterData',fld:'vBR_VITAL_RESPIRATIONTITLEFILTERDATA',pic:''},{av:'AV28BR_Vital_SystolicTitleFilterData',fld:'vBR_VITAL_SYSTOLICTITLEFILTERDATA',pic:''},{av:'AV30BR_Vital_DiastolicTitleFilterData',fld:'vBR_VITAL_DIASTOLICTITLEFILTERDATA',pic:''},{av:'AV32BR_Vital_HeightTitleFilterData',fld:'vBR_VITAL_HEIGHTTITLEFILTERDATA',pic:''},{av:'AV34BR_Vital_WeightTitleFilterData',fld:'vBR_VITAL_WEIGHTTITLEFILTERDATA',pic:''},{av:'edtBR_VitalID_Titleformat',ctrl:'BR_VITALID',prop:'Titleformat'},{av:'edtBR_VitalID_Title',ctrl:'BR_VITALID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Vital_VitalID_Titleformat',ctrl:'BR_VITAL_VITALID',prop:'Titleformat'},{av:'edtBR_Vital_VitalID_Title',ctrl:'BR_VITAL_VITALID',prop:'Title'},{av:'edtBR_Vital_MeasureDate_Titleformat',ctrl:'BR_VITAL_MEASUREDATE',prop:'Titleformat'},{av:'edtBR_Vital_MeasureDate_Title',ctrl:'BR_VITAL_MEASUREDATE',prop:'Title'},{av:'edtBR_Vital_Temperature_Titleformat',ctrl:'BR_VITAL_TEMPERATURE',prop:'Titleformat'},{av:'edtBR_Vital_Temperature_Title',ctrl:'BR_VITAL_TEMPERATURE',prop:'Title'},{av:'edtBR_Vital_Pulse_Titleformat',ctrl:'BR_VITAL_PULSE',prop:'Titleformat'},{av:'edtBR_Vital_Pulse_Title',ctrl:'BR_VITAL_PULSE',prop:'Title'},{av:'edtBR_Vital_Respiration_Titleformat',ctrl:'BR_VITAL_RESPIRATION',prop:'Titleformat'},{av:'edtBR_Vital_Respiration_Title',ctrl:'BR_VITAL_RESPIRATION',prop:'Title'},{av:'edtBR_Vital_Systolic_Titleformat',ctrl:'BR_VITAL_SYSTOLIC',prop:'Titleformat'},{av:'edtBR_Vital_Systolic_Title',ctrl:'BR_VITAL_SYSTOLIC',prop:'Title'},{av:'edtBR_Vital_Diastolic_Titleformat',ctrl:'BR_VITAL_DIASTOLIC',prop:'Titleformat'},{av:'edtBR_Vital_Diastolic_Title',ctrl:'BR_VITAL_DIASTOLIC',prop:'Title'},{av:'edtBR_Vital_Height_Titleformat',ctrl:'BR_VITAL_HEIGHT',prop:'Titleformat'},{av:'edtBR_Vital_Height_Title',ctrl:'BR_VITAL_HEIGHT',prop:'Title'},{av:'edtBR_Vital_Weight_Titleformat',ctrl:'BR_VITAL_WEIGHT',prop:'Titleformat'},{av:'edtBR_Vital_Weight_Title',ctrl:'BR_VITAL_WEIGHT',prop:'Title'},{av:'AV38GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV39GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV40GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_VITAL_PULSE.ONOPTIONCLICKED","{handler:'E19622',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_VitalIDTitleControlIdToReplace',fld:'vDDO_BR_VITALIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Vital_VitalIDTitleControlIdToReplace',fld:'vDDO_BR_VITAL_VITALIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Vital_MeasureDateTitleControlIdToReplace',fld:'vDDO_BR_VITAL_MEASUREDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_Vital_TemperatureTitleControlIdToReplace',fld:'vDDO_BR_VITAL_TEMPERATURETITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Vital_PulseTitleControlIdToReplace',fld:'vDDO_BR_VITAL_PULSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Vital_RespirationTitleControlIdToReplace',fld:'vDDO_BR_VITAL_RESPIRATIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_BR_Vital_SystolicTitleControlIdToReplace',fld:'vDDO_BR_VITAL_SYSTOLICTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Vital_DiastolicTitleControlIdToReplace',fld:'vDDO_BR_VITAL_DIASTOLICTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Vital_HeightTitleControlIdToReplace',fld:'vDDO_BR_VITAL_HEIGHTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Vital_WeightTitleControlIdToReplace',fld:'vDDO_BR_VITAL_WEIGHTTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_vital_pulse_Activeeventkey',ctrl:'DDO_BR_VITAL_PULSE',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_VITAL_PULSE.ONOPTIONCLICKED",",oparms:[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_vital_pulse_Sortedstatus',ctrl:'DDO_BR_VITAL_PULSE',prop:'SortedStatus'},{av:'AV12BR_VitalIDTitleFilterData',fld:'vBR_VITALIDTITLEFILTERDATA',pic:''},{av:'AV14BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV16BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV18BR_Vital_VitalIDTitleFilterData',fld:'vBR_VITAL_VITALIDTITLEFILTERDATA',pic:''},{av:'AV20BR_Vital_MeasureDateTitleFilterData',fld:'vBR_VITAL_MEASUREDATETITLEFILTERDATA',pic:''},{av:'AV22BR_Vital_TemperatureTitleFilterData',fld:'vBR_VITAL_TEMPERATURETITLEFILTERDATA',pic:''},{av:'AV24BR_Vital_PulseTitleFilterData',fld:'vBR_VITAL_PULSETITLEFILTERDATA',pic:''},{av:'AV26BR_Vital_RespirationTitleFilterData',fld:'vBR_VITAL_RESPIRATIONTITLEFILTERDATA',pic:''},{av:'AV28BR_Vital_SystolicTitleFilterData',fld:'vBR_VITAL_SYSTOLICTITLEFILTERDATA',pic:''},{av:'AV30BR_Vital_DiastolicTitleFilterData',fld:'vBR_VITAL_DIASTOLICTITLEFILTERDATA',pic:''},{av:'AV32BR_Vital_HeightTitleFilterData',fld:'vBR_VITAL_HEIGHTTITLEFILTERDATA',pic:''},{av:'AV34BR_Vital_WeightTitleFilterData',fld:'vBR_VITAL_WEIGHTTITLEFILTERDATA',pic:''},{av:'edtBR_VitalID_Titleformat',ctrl:'BR_VITALID',prop:'Titleformat'},{av:'edtBR_VitalID_Title',ctrl:'BR_VITALID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Vital_VitalID_Titleformat',ctrl:'BR_VITAL_VITALID',prop:'Titleformat'},{av:'edtBR_Vital_VitalID_Title',ctrl:'BR_VITAL_VITALID',prop:'Title'},{av:'edtBR_Vital_MeasureDate_Titleformat',ctrl:'BR_VITAL_MEASUREDATE',prop:'Titleformat'},{av:'edtBR_Vital_MeasureDate_Title',ctrl:'BR_VITAL_MEASUREDATE',prop:'Title'},{av:'edtBR_Vital_Temperature_Titleformat',ctrl:'BR_VITAL_TEMPERATURE',prop:'Titleformat'},{av:'edtBR_Vital_Temperature_Title',ctrl:'BR_VITAL_TEMPERATURE',prop:'Title'},{av:'edtBR_Vital_Pulse_Titleformat',ctrl:'BR_VITAL_PULSE',prop:'Titleformat'},{av:'edtBR_Vital_Pulse_Title',ctrl:'BR_VITAL_PULSE',prop:'Title'},{av:'edtBR_Vital_Respiration_Titleformat',ctrl:'BR_VITAL_RESPIRATION',prop:'Titleformat'},{av:'edtBR_Vital_Respiration_Title',ctrl:'BR_VITAL_RESPIRATION',prop:'Title'},{av:'edtBR_Vital_Systolic_Titleformat',ctrl:'BR_VITAL_SYSTOLIC',prop:'Titleformat'},{av:'edtBR_Vital_Systolic_Title',ctrl:'BR_VITAL_SYSTOLIC',prop:'Title'},{av:'edtBR_Vital_Diastolic_Titleformat',ctrl:'BR_VITAL_DIASTOLIC',prop:'Titleformat'},{av:'edtBR_Vital_Diastolic_Title',ctrl:'BR_VITAL_DIASTOLIC',prop:'Title'},{av:'edtBR_Vital_Height_Titleformat',ctrl:'BR_VITAL_HEIGHT',prop:'Titleformat'},{av:'edtBR_Vital_Height_Title',ctrl:'BR_VITAL_HEIGHT',prop:'Title'},{av:'edtBR_Vital_Weight_Titleformat',ctrl:'BR_VITAL_WEIGHT',prop:'Titleformat'},{av:'edtBR_Vital_Weight_Title',ctrl:'BR_VITAL_WEIGHT',prop:'Title'},{av:'AV38GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV39GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV40GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_VITAL_RESPIRATION.ONOPTIONCLICKED","{handler:'E20622',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_VitalIDTitleControlIdToReplace',fld:'vDDO_BR_VITALIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Vital_VitalIDTitleControlIdToReplace',fld:'vDDO_BR_VITAL_VITALIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Vital_MeasureDateTitleControlIdToReplace',fld:'vDDO_BR_VITAL_MEASUREDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_Vital_TemperatureTitleControlIdToReplace',fld:'vDDO_BR_VITAL_TEMPERATURETITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Vital_PulseTitleControlIdToReplace',fld:'vDDO_BR_VITAL_PULSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Vital_RespirationTitleControlIdToReplace',fld:'vDDO_BR_VITAL_RESPIRATIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_BR_Vital_SystolicTitleControlIdToReplace',fld:'vDDO_BR_VITAL_SYSTOLICTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Vital_DiastolicTitleControlIdToReplace',fld:'vDDO_BR_VITAL_DIASTOLICTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Vital_HeightTitleControlIdToReplace',fld:'vDDO_BR_VITAL_HEIGHTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Vital_WeightTitleControlIdToReplace',fld:'vDDO_BR_VITAL_WEIGHTTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_vital_respiration_Activeeventkey',ctrl:'DDO_BR_VITAL_RESPIRATION',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_VITAL_RESPIRATION.ONOPTIONCLICKED",",oparms:[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_vital_respiration_Sortedstatus',ctrl:'DDO_BR_VITAL_RESPIRATION',prop:'SortedStatus'},{av:'AV12BR_VitalIDTitleFilterData',fld:'vBR_VITALIDTITLEFILTERDATA',pic:''},{av:'AV14BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV16BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV18BR_Vital_VitalIDTitleFilterData',fld:'vBR_VITAL_VITALIDTITLEFILTERDATA',pic:''},{av:'AV20BR_Vital_MeasureDateTitleFilterData',fld:'vBR_VITAL_MEASUREDATETITLEFILTERDATA',pic:''},{av:'AV22BR_Vital_TemperatureTitleFilterData',fld:'vBR_VITAL_TEMPERATURETITLEFILTERDATA',pic:''},{av:'AV24BR_Vital_PulseTitleFilterData',fld:'vBR_VITAL_PULSETITLEFILTERDATA',pic:''},{av:'AV26BR_Vital_RespirationTitleFilterData',fld:'vBR_VITAL_RESPIRATIONTITLEFILTERDATA',pic:''},{av:'AV28BR_Vital_SystolicTitleFilterData',fld:'vBR_VITAL_SYSTOLICTITLEFILTERDATA',pic:''},{av:'AV30BR_Vital_DiastolicTitleFilterData',fld:'vBR_VITAL_DIASTOLICTITLEFILTERDATA',pic:''},{av:'AV32BR_Vital_HeightTitleFilterData',fld:'vBR_VITAL_HEIGHTTITLEFILTERDATA',pic:''},{av:'AV34BR_Vital_WeightTitleFilterData',fld:'vBR_VITAL_WEIGHTTITLEFILTERDATA',pic:''},{av:'edtBR_VitalID_Titleformat',ctrl:'BR_VITALID',prop:'Titleformat'},{av:'edtBR_VitalID_Title',ctrl:'BR_VITALID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Vital_VitalID_Titleformat',ctrl:'BR_VITAL_VITALID',prop:'Titleformat'},{av:'edtBR_Vital_VitalID_Title',ctrl:'BR_VITAL_VITALID',prop:'Title'},{av:'edtBR_Vital_MeasureDate_Titleformat',ctrl:'BR_VITAL_MEASUREDATE',prop:'Titleformat'},{av:'edtBR_Vital_MeasureDate_Title',ctrl:'BR_VITAL_MEASUREDATE',prop:'Title'},{av:'edtBR_Vital_Temperature_Titleformat',ctrl:'BR_VITAL_TEMPERATURE',prop:'Titleformat'},{av:'edtBR_Vital_Temperature_Title',ctrl:'BR_VITAL_TEMPERATURE',prop:'Title'},{av:'edtBR_Vital_Pulse_Titleformat',ctrl:'BR_VITAL_PULSE',prop:'Titleformat'},{av:'edtBR_Vital_Pulse_Title',ctrl:'BR_VITAL_PULSE',prop:'Title'},{av:'edtBR_Vital_Respiration_Titleformat',ctrl:'BR_VITAL_RESPIRATION',prop:'Titleformat'},{av:'edtBR_Vital_Respiration_Title',ctrl:'BR_VITAL_RESPIRATION',prop:'Title'},{av:'edtBR_Vital_Systolic_Titleformat',ctrl:'BR_VITAL_SYSTOLIC',prop:'Titleformat'},{av:'edtBR_Vital_Systolic_Title',ctrl:'BR_VITAL_SYSTOLIC',prop:'Title'},{av:'edtBR_Vital_Diastolic_Titleformat',ctrl:'BR_VITAL_DIASTOLIC',prop:'Titleformat'},{av:'edtBR_Vital_Diastolic_Title',ctrl:'BR_VITAL_DIASTOLIC',prop:'Title'},{av:'edtBR_Vital_Height_Titleformat',ctrl:'BR_VITAL_HEIGHT',prop:'Titleformat'},{av:'edtBR_Vital_Height_Title',ctrl:'BR_VITAL_HEIGHT',prop:'Title'},{av:'edtBR_Vital_Weight_Titleformat',ctrl:'BR_VITAL_WEIGHT',prop:'Titleformat'},{av:'edtBR_Vital_Weight_Title',ctrl:'BR_VITAL_WEIGHT',prop:'Title'},{av:'AV38GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV39GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV40GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_VITAL_SYSTOLIC.ONOPTIONCLICKED","{handler:'E21622',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_VitalIDTitleControlIdToReplace',fld:'vDDO_BR_VITALIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Vital_VitalIDTitleControlIdToReplace',fld:'vDDO_BR_VITAL_VITALIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Vital_MeasureDateTitleControlIdToReplace',fld:'vDDO_BR_VITAL_MEASUREDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_Vital_TemperatureTitleControlIdToReplace',fld:'vDDO_BR_VITAL_TEMPERATURETITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Vital_PulseTitleControlIdToReplace',fld:'vDDO_BR_VITAL_PULSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Vital_RespirationTitleControlIdToReplace',fld:'vDDO_BR_VITAL_RESPIRATIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_BR_Vital_SystolicTitleControlIdToReplace',fld:'vDDO_BR_VITAL_SYSTOLICTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Vital_DiastolicTitleControlIdToReplace',fld:'vDDO_BR_VITAL_DIASTOLICTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Vital_HeightTitleControlIdToReplace',fld:'vDDO_BR_VITAL_HEIGHTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Vital_WeightTitleControlIdToReplace',fld:'vDDO_BR_VITAL_WEIGHTTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_vital_systolic_Activeeventkey',ctrl:'DDO_BR_VITAL_SYSTOLIC',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_VITAL_SYSTOLIC.ONOPTIONCLICKED",",oparms:[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_vital_systolic_Sortedstatus',ctrl:'DDO_BR_VITAL_SYSTOLIC',prop:'SortedStatus'},{av:'AV12BR_VitalIDTitleFilterData',fld:'vBR_VITALIDTITLEFILTERDATA',pic:''},{av:'AV14BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV16BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV18BR_Vital_VitalIDTitleFilterData',fld:'vBR_VITAL_VITALIDTITLEFILTERDATA',pic:''},{av:'AV20BR_Vital_MeasureDateTitleFilterData',fld:'vBR_VITAL_MEASUREDATETITLEFILTERDATA',pic:''},{av:'AV22BR_Vital_TemperatureTitleFilterData',fld:'vBR_VITAL_TEMPERATURETITLEFILTERDATA',pic:''},{av:'AV24BR_Vital_PulseTitleFilterData',fld:'vBR_VITAL_PULSETITLEFILTERDATA',pic:''},{av:'AV26BR_Vital_RespirationTitleFilterData',fld:'vBR_VITAL_RESPIRATIONTITLEFILTERDATA',pic:''},{av:'AV28BR_Vital_SystolicTitleFilterData',fld:'vBR_VITAL_SYSTOLICTITLEFILTERDATA',pic:''},{av:'AV30BR_Vital_DiastolicTitleFilterData',fld:'vBR_VITAL_DIASTOLICTITLEFILTERDATA',pic:''},{av:'AV32BR_Vital_HeightTitleFilterData',fld:'vBR_VITAL_HEIGHTTITLEFILTERDATA',pic:''},{av:'AV34BR_Vital_WeightTitleFilterData',fld:'vBR_VITAL_WEIGHTTITLEFILTERDATA',pic:''},{av:'edtBR_VitalID_Titleformat',ctrl:'BR_VITALID',prop:'Titleformat'},{av:'edtBR_VitalID_Title',ctrl:'BR_VITALID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Vital_VitalID_Titleformat',ctrl:'BR_VITAL_VITALID',prop:'Titleformat'},{av:'edtBR_Vital_VitalID_Title',ctrl:'BR_VITAL_VITALID',prop:'Title'},{av:'edtBR_Vital_MeasureDate_Titleformat',ctrl:'BR_VITAL_MEASUREDATE',prop:'Titleformat'},{av:'edtBR_Vital_MeasureDate_Title',ctrl:'BR_VITAL_MEASUREDATE',prop:'Title'},{av:'edtBR_Vital_Temperature_Titleformat',ctrl:'BR_VITAL_TEMPERATURE',prop:'Titleformat'},{av:'edtBR_Vital_Temperature_Title',ctrl:'BR_VITAL_TEMPERATURE',prop:'Title'},{av:'edtBR_Vital_Pulse_Titleformat',ctrl:'BR_VITAL_PULSE',prop:'Titleformat'},{av:'edtBR_Vital_Pulse_Title',ctrl:'BR_VITAL_PULSE',prop:'Title'},{av:'edtBR_Vital_Respiration_Titleformat',ctrl:'BR_VITAL_RESPIRATION',prop:'Titleformat'},{av:'edtBR_Vital_Respiration_Title',ctrl:'BR_VITAL_RESPIRATION',prop:'Title'},{av:'edtBR_Vital_Systolic_Titleformat',ctrl:'BR_VITAL_SYSTOLIC',prop:'Titleformat'},{av:'edtBR_Vital_Systolic_Title',ctrl:'BR_VITAL_SYSTOLIC',prop:'Title'},{av:'edtBR_Vital_Diastolic_Titleformat',ctrl:'BR_VITAL_DIASTOLIC',prop:'Titleformat'},{av:'edtBR_Vital_Diastolic_Title',ctrl:'BR_VITAL_DIASTOLIC',prop:'Title'},{av:'edtBR_Vital_Height_Titleformat',ctrl:'BR_VITAL_HEIGHT',prop:'Titleformat'},{av:'edtBR_Vital_Height_Title',ctrl:'BR_VITAL_HEIGHT',prop:'Title'},{av:'edtBR_Vital_Weight_Titleformat',ctrl:'BR_VITAL_WEIGHT',prop:'Titleformat'},{av:'edtBR_Vital_Weight_Title',ctrl:'BR_VITAL_WEIGHT',prop:'Title'},{av:'AV38GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV39GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV40GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_VITAL_DIASTOLIC.ONOPTIONCLICKED","{handler:'E22622',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_VitalIDTitleControlIdToReplace',fld:'vDDO_BR_VITALIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Vital_VitalIDTitleControlIdToReplace',fld:'vDDO_BR_VITAL_VITALIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Vital_MeasureDateTitleControlIdToReplace',fld:'vDDO_BR_VITAL_MEASUREDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_Vital_TemperatureTitleControlIdToReplace',fld:'vDDO_BR_VITAL_TEMPERATURETITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Vital_PulseTitleControlIdToReplace',fld:'vDDO_BR_VITAL_PULSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Vital_RespirationTitleControlIdToReplace',fld:'vDDO_BR_VITAL_RESPIRATIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_BR_Vital_SystolicTitleControlIdToReplace',fld:'vDDO_BR_VITAL_SYSTOLICTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Vital_DiastolicTitleControlIdToReplace',fld:'vDDO_BR_VITAL_DIASTOLICTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Vital_HeightTitleControlIdToReplace',fld:'vDDO_BR_VITAL_HEIGHTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Vital_WeightTitleControlIdToReplace',fld:'vDDO_BR_VITAL_WEIGHTTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_vital_diastolic_Activeeventkey',ctrl:'DDO_BR_VITAL_DIASTOLIC',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_VITAL_DIASTOLIC.ONOPTIONCLICKED",",oparms:[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_vital_diastolic_Sortedstatus',ctrl:'DDO_BR_VITAL_DIASTOLIC',prop:'SortedStatus'},{av:'AV12BR_VitalIDTitleFilterData',fld:'vBR_VITALIDTITLEFILTERDATA',pic:''},{av:'AV14BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV16BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV18BR_Vital_VitalIDTitleFilterData',fld:'vBR_VITAL_VITALIDTITLEFILTERDATA',pic:''},{av:'AV20BR_Vital_MeasureDateTitleFilterData',fld:'vBR_VITAL_MEASUREDATETITLEFILTERDATA',pic:''},{av:'AV22BR_Vital_TemperatureTitleFilterData',fld:'vBR_VITAL_TEMPERATURETITLEFILTERDATA',pic:''},{av:'AV24BR_Vital_PulseTitleFilterData',fld:'vBR_VITAL_PULSETITLEFILTERDATA',pic:''},{av:'AV26BR_Vital_RespirationTitleFilterData',fld:'vBR_VITAL_RESPIRATIONTITLEFILTERDATA',pic:''},{av:'AV28BR_Vital_SystolicTitleFilterData',fld:'vBR_VITAL_SYSTOLICTITLEFILTERDATA',pic:''},{av:'AV30BR_Vital_DiastolicTitleFilterData',fld:'vBR_VITAL_DIASTOLICTITLEFILTERDATA',pic:''},{av:'AV32BR_Vital_HeightTitleFilterData',fld:'vBR_VITAL_HEIGHTTITLEFILTERDATA',pic:''},{av:'AV34BR_Vital_WeightTitleFilterData',fld:'vBR_VITAL_WEIGHTTITLEFILTERDATA',pic:''},{av:'edtBR_VitalID_Titleformat',ctrl:'BR_VITALID',prop:'Titleformat'},{av:'edtBR_VitalID_Title',ctrl:'BR_VITALID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Vital_VitalID_Titleformat',ctrl:'BR_VITAL_VITALID',prop:'Titleformat'},{av:'edtBR_Vital_VitalID_Title',ctrl:'BR_VITAL_VITALID',prop:'Title'},{av:'edtBR_Vital_MeasureDate_Titleformat',ctrl:'BR_VITAL_MEASUREDATE',prop:'Titleformat'},{av:'edtBR_Vital_MeasureDate_Title',ctrl:'BR_VITAL_MEASUREDATE',prop:'Title'},{av:'edtBR_Vital_Temperature_Titleformat',ctrl:'BR_VITAL_TEMPERATURE',prop:'Titleformat'},{av:'edtBR_Vital_Temperature_Title',ctrl:'BR_VITAL_TEMPERATURE',prop:'Title'},{av:'edtBR_Vital_Pulse_Titleformat',ctrl:'BR_VITAL_PULSE',prop:'Titleformat'},{av:'edtBR_Vital_Pulse_Title',ctrl:'BR_VITAL_PULSE',prop:'Title'},{av:'edtBR_Vital_Respiration_Titleformat',ctrl:'BR_VITAL_RESPIRATION',prop:'Titleformat'},{av:'edtBR_Vital_Respiration_Title',ctrl:'BR_VITAL_RESPIRATION',prop:'Title'},{av:'edtBR_Vital_Systolic_Titleformat',ctrl:'BR_VITAL_SYSTOLIC',prop:'Titleformat'},{av:'edtBR_Vital_Systolic_Title',ctrl:'BR_VITAL_SYSTOLIC',prop:'Title'},{av:'edtBR_Vital_Diastolic_Titleformat',ctrl:'BR_VITAL_DIASTOLIC',prop:'Titleformat'},{av:'edtBR_Vital_Diastolic_Title',ctrl:'BR_VITAL_DIASTOLIC',prop:'Title'},{av:'edtBR_Vital_Height_Titleformat',ctrl:'BR_VITAL_HEIGHT',prop:'Titleformat'},{av:'edtBR_Vital_Height_Title',ctrl:'BR_VITAL_HEIGHT',prop:'Title'},{av:'edtBR_Vital_Weight_Titleformat',ctrl:'BR_VITAL_WEIGHT',prop:'Titleformat'},{av:'edtBR_Vital_Weight_Title',ctrl:'BR_VITAL_WEIGHT',prop:'Title'},{av:'AV38GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV39GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV40GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_VITAL_HEIGHT.ONOPTIONCLICKED","{handler:'E23622',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_VitalIDTitleControlIdToReplace',fld:'vDDO_BR_VITALIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Vital_VitalIDTitleControlIdToReplace',fld:'vDDO_BR_VITAL_VITALIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Vital_MeasureDateTitleControlIdToReplace',fld:'vDDO_BR_VITAL_MEASUREDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_Vital_TemperatureTitleControlIdToReplace',fld:'vDDO_BR_VITAL_TEMPERATURETITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Vital_PulseTitleControlIdToReplace',fld:'vDDO_BR_VITAL_PULSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Vital_RespirationTitleControlIdToReplace',fld:'vDDO_BR_VITAL_RESPIRATIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_BR_Vital_SystolicTitleControlIdToReplace',fld:'vDDO_BR_VITAL_SYSTOLICTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Vital_DiastolicTitleControlIdToReplace',fld:'vDDO_BR_VITAL_DIASTOLICTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Vital_HeightTitleControlIdToReplace',fld:'vDDO_BR_VITAL_HEIGHTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Vital_WeightTitleControlIdToReplace',fld:'vDDO_BR_VITAL_WEIGHTTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_vital_height_Activeeventkey',ctrl:'DDO_BR_VITAL_HEIGHT',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_VITAL_HEIGHT.ONOPTIONCLICKED",",oparms:[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_vital_height_Sortedstatus',ctrl:'DDO_BR_VITAL_HEIGHT',prop:'SortedStatus'},{av:'AV12BR_VitalIDTitleFilterData',fld:'vBR_VITALIDTITLEFILTERDATA',pic:''},{av:'AV14BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV16BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV18BR_Vital_VitalIDTitleFilterData',fld:'vBR_VITAL_VITALIDTITLEFILTERDATA',pic:''},{av:'AV20BR_Vital_MeasureDateTitleFilterData',fld:'vBR_VITAL_MEASUREDATETITLEFILTERDATA',pic:''},{av:'AV22BR_Vital_TemperatureTitleFilterData',fld:'vBR_VITAL_TEMPERATURETITLEFILTERDATA',pic:''},{av:'AV24BR_Vital_PulseTitleFilterData',fld:'vBR_VITAL_PULSETITLEFILTERDATA',pic:''},{av:'AV26BR_Vital_RespirationTitleFilterData',fld:'vBR_VITAL_RESPIRATIONTITLEFILTERDATA',pic:''},{av:'AV28BR_Vital_SystolicTitleFilterData',fld:'vBR_VITAL_SYSTOLICTITLEFILTERDATA',pic:''},{av:'AV30BR_Vital_DiastolicTitleFilterData',fld:'vBR_VITAL_DIASTOLICTITLEFILTERDATA',pic:''},{av:'AV32BR_Vital_HeightTitleFilterData',fld:'vBR_VITAL_HEIGHTTITLEFILTERDATA',pic:''},{av:'AV34BR_Vital_WeightTitleFilterData',fld:'vBR_VITAL_WEIGHTTITLEFILTERDATA',pic:''},{av:'edtBR_VitalID_Titleformat',ctrl:'BR_VITALID',prop:'Titleformat'},{av:'edtBR_VitalID_Title',ctrl:'BR_VITALID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Vital_VitalID_Titleformat',ctrl:'BR_VITAL_VITALID',prop:'Titleformat'},{av:'edtBR_Vital_VitalID_Title',ctrl:'BR_VITAL_VITALID',prop:'Title'},{av:'edtBR_Vital_MeasureDate_Titleformat',ctrl:'BR_VITAL_MEASUREDATE',prop:'Titleformat'},{av:'edtBR_Vital_MeasureDate_Title',ctrl:'BR_VITAL_MEASUREDATE',prop:'Title'},{av:'edtBR_Vital_Temperature_Titleformat',ctrl:'BR_VITAL_TEMPERATURE',prop:'Titleformat'},{av:'edtBR_Vital_Temperature_Title',ctrl:'BR_VITAL_TEMPERATURE',prop:'Title'},{av:'edtBR_Vital_Pulse_Titleformat',ctrl:'BR_VITAL_PULSE',prop:'Titleformat'},{av:'edtBR_Vital_Pulse_Title',ctrl:'BR_VITAL_PULSE',prop:'Title'},{av:'edtBR_Vital_Respiration_Titleformat',ctrl:'BR_VITAL_RESPIRATION',prop:'Titleformat'},{av:'edtBR_Vital_Respiration_Title',ctrl:'BR_VITAL_RESPIRATION',prop:'Title'},{av:'edtBR_Vital_Systolic_Titleformat',ctrl:'BR_VITAL_SYSTOLIC',prop:'Titleformat'},{av:'edtBR_Vital_Systolic_Title',ctrl:'BR_VITAL_SYSTOLIC',prop:'Title'},{av:'edtBR_Vital_Diastolic_Titleformat',ctrl:'BR_VITAL_DIASTOLIC',prop:'Titleformat'},{av:'edtBR_Vital_Diastolic_Title',ctrl:'BR_VITAL_DIASTOLIC',prop:'Title'},{av:'edtBR_Vital_Height_Titleformat',ctrl:'BR_VITAL_HEIGHT',prop:'Titleformat'},{av:'edtBR_Vital_Height_Title',ctrl:'BR_VITAL_HEIGHT',prop:'Title'},{av:'edtBR_Vital_Weight_Titleformat',ctrl:'BR_VITAL_WEIGHT',prop:'Titleformat'},{av:'edtBR_Vital_Weight_Title',ctrl:'BR_VITAL_WEIGHT',prop:'Title'},{av:'AV38GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV39GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV40GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_VITAL_WEIGHT.ONOPTIONCLICKED","{handler:'E24622',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_VitalIDTitleControlIdToReplace',fld:'vDDO_BR_VITALIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Vital_VitalIDTitleControlIdToReplace',fld:'vDDO_BR_VITAL_VITALIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Vital_MeasureDateTitleControlIdToReplace',fld:'vDDO_BR_VITAL_MEASUREDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV23ddo_BR_Vital_TemperatureTitleControlIdToReplace',fld:'vDDO_BR_VITAL_TEMPERATURETITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Vital_PulseTitleControlIdToReplace',fld:'vDDO_BR_VITAL_PULSETITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Vital_RespirationTitleControlIdToReplace',fld:'vDDO_BR_VITAL_RESPIRATIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_BR_Vital_SystolicTitleControlIdToReplace',fld:'vDDO_BR_VITAL_SYSTOLICTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Vital_DiastolicTitleControlIdToReplace',fld:'vDDO_BR_VITAL_DIASTOLICTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Vital_HeightTitleControlIdToReplace',fld:'vDDO_BR_VITAL_HEIGHTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Vital_WeightTitleControlIdToReplace',fld:'vDDO_BR_VITAL_WEIGHTTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_vital_weight_Activeeventkey',ctrl:'DDO_BR_VITAL_WEIGHT',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_VITAL_WEIGHT.ONOPTIONCLICKED",",oparms:[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_vital_weight_Sortedstatus',ctrl:'DDO_BR_VITAL_WEIGHT',prop:'SortedStatus'},{av:'AV12BR_VitalIDTitleFilterData',fld:'vBR_VITALIDTITLEFILTERDATA',pic:''},{av:'AV14BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV16BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV18BR_Vital_VitalIDTitleFilterData',fld:'vBR_VITAL_VITALIDTITLEFILTERDATA',pic:''},{av:'AV20BR_Vital_MeasureDateTitleFilterData',fld:'vBR_VITAL_MEASUREDATETITLEFILTERDATA',pic:''},{av:'AV22BR_Vital_TemperatureTitleFilterData',fld:'vBR_VITAL_TEMPERATURETITLEFILTERDATA',pic:''},{av:'AV24BR_Vital_PulseTitleFilterData',fld:'vBR_VITAL_PULSETITLEFILTERDATA',pic:''},{av:'AV26BR_Vital_RespirationTitleFilterData',fld:'vBR_VITAL_RESPIRATIONTITLEFILTERDATA',pic:''},{av:'AV28BR_Vital_SystolicTitleFilterData',fld:'vBR_VITAL_SYSTOLICTITLEFILTERDATA',pic:''},{av:'AV30BR_Vital_DiastolicTitleFilterData',fld:'vBR_VITAL_DIASTOLICTITLEFILTERDATA',pic:''},{av:'AV32BR_Vital_HeightTitleFilterData',fld:'vBR_VITAL_HEIGHTTITLEFILTERDATA',pic:''},{av:'AV34BR_Vital_WeightTitleFilterData',fld:'vBR_VITAL_WEIGHTTITLEFILTERDATA',pic:''},{av:'edtBR_VitalID_Titleformat',ctrl:'BR_VITALID',prop:'Titleformat'},{av:'edtBR_VitalID_Title',ctrl:'BR_VITALID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Vital_VitalID_Titleformat',ctrl:'BR_VITAL_VITALID',prop:'Titleformat'},{av:'edtBR_Vital_VitalID_Title',ctrl:'BR_VITAL_VITALID',prop:'Title'},{av:'edtBR_Vital_MeasureDate_Titleformat',ctrl:'BR_VITAL_MEASUREDATE',prop:'Titleformat'},{av:'edtBR_Vital_MeasureDate_Title',ctrl:'BR_VITAL_MEASUREDATE',prop:'Title'},{av:'edtBR_Vital_Temperature_Titleformat',ctrl:'BR_VITAL_TEMPERATURE',prop:'Titleformat'},{av:'edtBR_Vital_Temperature_Title',ctrl:'BR_VITAL_TEMPERATURE',prop:'Title'},{av:'edtBR_Vital_Pulse_Titleformat',ctrl:'BR_VITAL_PULSE',prop:'Titleformat'},{av:'edtBR_Vital_Pulse_Title',ctrl:'BR_VITAL_PULSE',prop:'Title'},{av:'edtBR_Vital_Respiration_Titleformat',ctrl:'BR_VITAL_RESPIRATION',prop:'Titleformat'},{av:'edtBR_Vital_Respiration_Title',ctrl:'BR_VITAL_RESPIRATION',prop:'Title'},{av:'edtBR_Vital_Systolic_Titleformat',ctrl:'BR_VITAL_SYSTOLIC',prop:'Titleformat'},{av:'edtBR_Vital_Systolic_Title',ctrl:'BR_VITAL_SYSTOLIC',prop:'Title'},{av:'edtBR_Vital_Diastolic_Titleformat',ctrl:'BR_VITAL_DIASTOLIC',prop:'Titleformat'},{av:'edtBR_Vital_Diastolic_Title',ctrl:'BR_VITAL_DIASTOLIC',prop:'Title'},{av:'edtBR_Vital_Height_Titleformat',ctrl:'BR_VITAL_HEIGHT',prop:'Titleformat'},{av:'edtBR_Vital_Height_Title',ctrl:'BR_VITAL_HEIGHT',prop:'Title'},{av:'edtBR_Vital_Weight_Titleformat',ctrl:'BR_VITAL_WEIGHT',prop:'Titleformat'},{av:'edtBR_Vital_Weight_Title',ctrl:'BR_VITAL_WEIGHT',prop:'Title'},{av:'AV38GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV39GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV40GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("GRID.LOAD","{handler:'E27622',iparms:[]");
         setEventMetadata("GRID.LOAD",",oparms:[{av:'AV41Select',fld:'vSELECT',pic:''},{av:'edtavSelect_Tooltiptext',ctrl:'vSELECT',prop:'Tooltiptext'}]}");
         setEventMetadata("ENTER","{handler:'E28622',iparms:[{av:'A150BR_VitalID',fld:'BR_VITALID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[{av:'AV8InOutBR_VitalID',fld:'vINOUTBR_VITALID',pic:'ZZZZZZZZZZZZZZZZZZ'}]}");
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
         Ddo_br_encounterid_Activeeventkey = "";
         Ddo_br_information_patientno_Activeeventkey = "";
         Ddo_br_vital_vitalid_Activeeventkey = "";
         Ddo_br_vital_measuredate_Activeeventkey = "";
         Ddo_br_vital_temperature_Activeeventkey = "";
         Ddo_br_vital_pulse_Activeeventkey = "";
         Ddo_br_vital_respiration_Activeeventkey = "";
         Ddo_br_vital_systolic_Activeeventkey = "";
         Ddo_br_vital_diastolic_Activeeventkey = "";
         Ddo_br_vital_height_Activeeventkey = "";
         Ddo_br_vital_weight_Activeeventkey = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV13ddo_BR_VitalIDTitleControlIdToReplace = "";
         AV15ddo_BR_EncounterIDTitleControlIdToReplace = "";
         AV17ddo_BR_Information_PatientNoTitleControlIdToReplace = "";
         AV19ddo_BR_Vital_VitalIDTitleControlIdToReplace = "";
         AV21ddo_BR_Vital_MeasureDateTitleControlIdToReplace = "";
         AV23ddo_BR_Vital_TemperatureTitleControlIdToReplace = "";
         AV25ddo_BR_Vital_PulseTitleControlIdToReplace = "";
         AV27ddo_BR_Vital_RespirationTitleControlIdToReplace = "";
         AV29ddo_BR_Vital_SystolicTitleControlIdToReplace = "";
         AV31ddo_BR_Vital_DiastolicTitleControlIdToReplace = "";
         AV33ddo_BR_Vital_HeightTitleControlIdToReplace = "";
         AV35ddo_BR_Vital_WeightTitleControlIdToReplace = "";
         GXKey = "";
         AV44Pgmname = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         AV36DDO_TitleSettingsIcons = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV12BR_VitalIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV14BR_EncounterIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV16BR_Information_PatientNoTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV18BR_Vital_VitalIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV20BR_Vital_MeasureDateTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV22BR_Vital_TemperatureTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV24BR_Vital_PulseTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV26BR_Vital_RespirationTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV28BR_Vital_SystolicTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV30BR_Vital_DiastolicTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV32BR_Vital_HeightTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV34BR_Vital_WeightTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         Ddo_br_vitalid_Sortedstatus = "";
         Ddo_br_encounterid_Sortedstatus = "";
         Ddo_br_information_patientno_Sortedstatus = "";
         Ddo_br_vital_vitalid_Sortedstatus = "";
         Ddo_br_vital_measuredate_Sortedstatus = "";
         Ddo_br_vital_temperature_Sortedstatus = "";
         Ddo_br_vital_pulse_Sortedstatus = "";
         Ddo_br_vital_respiration_Sortedstatus = "";
         Ddo_br_vital_systolic_Sortedstatus = "";
         Ddo_br_vital_diastolic_Sortedstatus = "";
         Ddo_br_vital_height_Sortedstatus = "";
         Ddo_br_vital_weight_Sortedstatus = "";
         GX_FocusControl = "";
         sPrefix = "";
         GridContainer = new GXWebGrid( context);
         sStyleString = "";
         subGrid_Linesclass = "";
         GridColumn = new GXWebColumn();
         AV41Select = "";
         A36BR_Information_PatientNo = "";
         A152BR_Vital_MeasureDate = DateTime.MinValue;
         ucGridpaginationbar = new GXUserControl();
         ucDdo_br_vitalid = new GXUserControl();
         TempTags = "";
         ClassString = "";
         StyleString = "";
         ucDdo_br_encounterid = new GXUserControl();
         ucDdo_br_information_patientno = new GXUserControl();
         ucDdo_br_vital_vitalid = new GXUserControl();
         ucDdo_br_vital_measuredate = new GXUserControl();
         ucDdo_br_vital_temperature = new GXUserControl();
         ucDdo_br_vital_pulse = new GXUserControl();
         ucDdo_br_vital_respiration = new GXUserControl();
         ucDdo_br_vital_systolic = new GXUserControl();
         ucDdo_br_vital_diastolic = new GXUserControl();
         ucDdo_br_vital_height = new GXUserControl();
         ucDdo_br_vital_weight = new GXUserControl();
         ucWorkwithplusutilities1 = new GXUserControl();
         Form = new GXWebForm();
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV45Select_GXI = "";
         scmdbuf = "";
         H00622_A85BR_Information_ID = new long[1] ;
         H00622_n85BR_Information_ID = new bool[] {false} ;
         H00622_A159BR_Vital_Weight = new decimal[1] ;
         H00622_n159BR_Vital_Weight = new bool[] {false} ;
         H00622_A158BR_Vital_Height = new decimal[1] ;
         H00622_n158BR_Vital_Height = new bool[] {false} ;
         H00622_A157BR_Vital_Diastolic = new decimal[1] ;
         H00622_n157BR_Vital_Diastolic = new bool[] {false} ;
         H00622_A156BR_Vital_Systolic = new decimal[1] ;
         H00622_n156BR_Vital_Systolic = new bool[] {false} ;
         H00622_A155BR_Vital_Respiration = new decimal[1] ;
         H00622_n155BR_Vital_Respiration = new bool[] {false} ;
         H00622_A154BR_Vital_Pulse = new decimal[1] ;
         H00622_n154BR_Vital_Pulse = new bool[] {false} ;
         H00622_A153BR_Vital_Temperature = new decimal[1] ;
         H00622_n153BR_Vital_Temperature = new bool[] {false} ;
         H00622_A152BR_Vital_MeasureDate = new DateTime[] {DateTime.MinValue} ;
         H00622_n152BR_Vital_MeasureDate = new bool[] {false} ;
         H00622_A151BR_Vital_VitalID = new long[1] ;
         H00622_n151BR_Vital_VitalID = new bool[] {false} ;
         H00622_A36BR_Information_PatientNo = new String[] {""} ;
         H00622_n36BR_Information_PatientNo = new bool[] {false} ;
         H00622_A19BR_EncounterID = new long[1] ;
         H00622_A150BR_VitalID = new long[1] ;
         H00623_AGRID_nRecordCount = new long[1] ;
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV6WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         GridRow = new GXWebRow();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sImgUrl = "";
         ROClassString = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_vitalprompt__default(),
            new Object[][] {
                new Object[] {
               H00622_A85BR_Information_ID, H00622_n85BR_Information_ID, H00622_A159BR_Vital_Weight, H00622_n159BR_Vital_Weight, H00622_A158BR_Vital_Height, H00622_n158BR_Vital_Height, H00622_A157BR_Vital_Diastolic, H00622_n157BR_Vital_Diastolic, H00622_A156BR_Vital_Systolic, H00622_n156BR_Vital_Systolic,
               H00622_A155BR_Vital_Respiration, H00622_n155BR_Vital_Respiration, H00622_A154BR_Vital_Pulse, H00622_n154BR_Vital_Pulse, H00622_A153BR_Vital_Temperature, H00622_n153BR_Vital_Temperature, H00622_A152BR_Vital_MeasureDate, H00622_n152BR_Vital_MeasureDate, H00622_A151BR_Vital_VitalID, H00622_n151BR_Vital_VitalID,
               H00622_A36BR_Information_PatientNo, H00622_n36BR_Information_PatientNo, H00622_A19BR_EncounterID, H00622_A150BR_VitalID
               }
               , new Object[] {
               H00623_AGRID_nRecordCount
               }
            }
         );
         AV44Pgmname = "BR_VitalPrompt";
         /* GeneXus formulas. */
         AV44Pgmname = "BR_VitalPrompt";
         context.Gx_err = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_GXsfl_12 ;
      private short nGXsfl_12_idx=1 ;
      private short GRID_nEOF ;
      private short AV10OrderedBy ;
      private short initialized ;
      private short wbEnd ;
      private short wbStart ;
      private short subGrid_Backcolorstyle ;
      private short subGrid_Titlebackstyle ;
      private short edtBR_VitalID_Titleformat ;
      private short edtBR_EncounterID_Titleformat ;
      private short edtBR_Information_PatientNo_Titleformat ;
      private short edtBR_Vital_VitalID_Titleformat ;
      private short edtBR_Vital_MeasureDate_Titleformat ;
      private short edtBR_Vital_Temperature_Titleformat ;
      private short edtBR_Vital_Pulse_Titleformat ;
      private short edtBR_Vital_Respiration_Titleformat ;
      private short edtBR_Vital_Systolic_Titleformat ;
      private short edtBR_Vital_Diastolic_Titleformat ;
      private short edtBR_Vital_Height_Titleformat ;
      private short edtBR_Vital_Weight_Titleformat ;
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
      private int divTablemain_Height ;
      private int subGrid_Titlebackcolor ;
      private int subGrid_Allbackcolor ;
      private int subGrid_Selectedindex ;
      private int subGrid_Selectioncolor ;
      private int subGrid_Hoveringcolor ;
      private int edtavDdo_br_vitalidtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_encounteridtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_information_patientnotitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_vital_vitalidtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_vital_measuredatetitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_vital_temperaturetitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_vital_pulsetitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_vital_respirationtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_vital_systolictitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_vital_diastolictitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_vital_heighttitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_vital_weighttitlecontrolidtoreplace_Visible ;
      private int edtavOrderedby_Visible ;
      private int edtavOrdereddsc_Visible ;
      private int subGrid_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int AV37PageToGo ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private int edtavSelect_Enabled ;
      private int edtavSelect_Visible ;
      private long AV8InOutBR_VitalID ;
      private long wcpOAV8InOutBR_VitalID ;
      private long GRID_nFirstRecordOnPage ;
      private long AV38GridCurrentPage ;
      private long AV40GridRecordCount ;
      private long AV39GridPageSize ;
      private long A150BR_VitalID ;
      private long A19BR_EncounterID ;
      private long A151BR_Vital_VitalID ;
      private long GRID_nCurrentRecord ;
      private long A85BR_Information_ID ;
      private long GRID_nRecordCount ;
      private decimal A153BR_Vital_Temperature ;
      private decimal A154BR_Vital_Pulse ;
      private decimal A155BR_Vital_Respiration ;
      private decimal A156BR_Vital_Systolic ;
      private decimal A157BR_Vital_Diastolic ;
      private decimal A158BR_Vital_Height ;
      private decimal A159BR_Vital_Weight ;
      private String Gridpaginationbar_Selectedpage ;
      private String Ddo_br_vitalid_Activeeventkey ;
      private String Ddo_br_encounterid_Activeeventkey ;
      private String Ddo_br_information_patientno_Activeeventkey ;
      private String Ddo_br_vital_vitalid_Activeeventkey ;
      private String Ddo_br_vital_measuredate_Activeeventkey ;
      private String Ddo_br_vital_temperature_Activeeventkey ;
      private String Ddo_br_vital_pulse_Activeeventkey ;
      private String Ddo_br_vital_respiration_Activeeventkey ;
      private String Ddo_br_vital_systolic_Activeeventkey ;
      private String Ddo_br_vital_diastolic_Activeeventkey ;
      private String Ddo_br_vital_height_Activeeventkey ;
      private String Ddo_br_vital_weight_Activeeventkey ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_12_idx="0001" ;
      private String GXKey ;
      private String AV44Pgmname ;
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
      private String Ddo_br_vitalid_Dropdownoptionstype ;
      private String Ddo_br_vitalid_Titlecontrolidtoreplace ;
      private String Ddo_br_vitalid_Sortedstatus ;
      private String Ddo_br_vitalid_Sortasc ;
      private String Ddo_br_vitalid_Sortdsc ;
      private String Ddo_br_vitalid_Searchbuttontext ;
      private String Ddo_br_encounterid_Caption ;
      private String Ddo_br_encounterid_Tooltip ;
      private String Ddo_br_encounterid_Cls ;
      private String Ddo_br_encounterid_Dropdownoptionstype ;
      private String Ddo_br_encounterid_Titlecontrolidtoreplace ;
      private String Ddo_br_encounterid_Sortedstatus ;
      private String Ddo_br_encounterid_Sortasc ;
      private String Ddo_br_encounterid_Sortdsc ;
      private String Ddo_br_encounterid_Searchbuttontext ;
      private String Ddo_br_information_patientno_Caption ;
      private String Ddo_br_information_patientno_Tooltip ;
      private String Ddo_br_information_patientno_Cls ;
      private String Ddo_br_information_patientno_Dropdownoptionstype ;
      private String Ddo_br_information_patientno_Titlecontrolidtoreplace ;
      private String Ddo_br_information_patientno_Sortedstatus ;
      private String Ddo_br_information_patientno_Sortasc ;
      private String Ddo_br_information_patientno_Sortdsc ;
      private String Ddo_br_information_patientno_Searchbuttontext ;
      private String Ddo_br_vital_vitalid_Caption ;
      private String Ddo_br_vital_vitalid_Tooltip ;
      private String Ddo_br_vital_vitalid_Cls ;
      private String Ddo_br_vital_vitalid_Dropdownoptionstype ;
      private String Ddo_br_vital_vitalid_Titlecontrolidtoreplace ;
      private String Ddo_br_vital_vitalid_Sortedstatus ;
      private String Ddo_br_vital_vitalid_Sortasc ;
      private String Ddo_br_vital_vitalid_Sortdsc ;
      private String Ddo_br_vital_vitalid_Searchbuttontext ;
      private String Ddo_br_vital_measuredate_Caption ;
      private String Ddo_br_vital_measuredate_Tooltip ;
      private String Ddo_br_vital_measuredate_Cls ;
      private String Ddo_br_vital_measuredate_Dropdownoptionstype ;
      private String Ddo_br_vital_measuredate_Titlecontrolidtoreplace ;
      private String Ddo_br_vital_measuredate_Sortedstatus ;
      private String Ddo_br_vital_measuredate_Sortasc ;
      private String Ddo_br_vital_measuredate_Sortdsc ;
      private String Ddo_br_vital_measuredate_Searchbuttontext ;
      private String Ddo_br_vital_temperature_Caption ;
      private String Ddo_br_vital_temperature_Tooltip ;
      private String Ddo_br_vital_temperature_Cls ;
      private String Ddo_br_vital_temperature_Dropdownoptionstype ;
      private String Ddo_br_vital_temperature_Titlecontrolidtoreplace ;
      private String Ddo_br_vital_temperature_Sortedstatus ;
      private String Ddo_br_vital_temperature_Sortasc ;
      private String Ddo_br_vital_temperature_Sortdsc ;
      private String Ddo_br_vital_temperature_Searchbuttontext ;
      private String Ddo_br_vital_pulse_Caption ;
      private String Ddo_br_vital_pulse_Tooltip ;
      private String Ddo_br_vital_pulse_Cls ;
      private String Ddo_br_vital_pulse_Dropdownoptionstype ;
      private String Ddo_br_vital_pulse_Titlecontrolidtoreplace ;
      private String Ddo_br_vital_pulse_Sortedstatus ;
      private String Ddo_br_vital_pulse_Sortasc ;
      private String Ddo_br_vital_pulse_Sortdsc ;
      private String Ddo_br_vital_pulse_Searchbuttontext ;
      private String Ddo_br_vital_respiration_Caption ;
      private String Ddo_br_vital_respiration_Tooltip ;
      private String Ddo_br_vital_respiration_Cls ;
      private String Ddo_br_vital_respiration_Dropdownoptionstype ;
      private String Ddo_br_vital_respiration_Titlecontrolidtoreplace ;
      private String Ddo_br_vital_respiration_Sortedstatus ;
      private String Ddo_br_vital_respiration_Sortasc ;
      private String Ddo_br_vital_respiration_Sortdsc ;
      private String Ddo_br_vital_respiration_Searchbuttontext ;
      private String Ddo_br_vital_systolic_Caption ;
      private String Ddo_br_vital_systolic_Tooltip ;
      private String Ddo_br_vital_systolic_Cls ;
      private String Ddo_br_vital_systolic_Dropdownoptionstype ;
      private String Ddo_br_vital_systolic_Titlecontrolidtoreplace ;
      private String Ddo_br_vital_systolic_Sortedstatus ;
      private String Ddo_br_vital_systolic_Sortasc ;
      private String Ddo_br_vital_systolic_Sortdsc ;
      private String Ddo_br_vital_systolic_Searchbuttontext ;
      private String Ddo_br_vital_diastolic_Caption ;
      private String Ddo_br_vital_diastolic_Tooltip ;
      private String Ddo_br_vital_diastolic_Cls ;
      private String Ddo_br_vital_diastolic_Dropdownoptionstype ;
      private String Ddo_br_vital_diastolic_Titlecontrolidtoreplace ;
      private String Ddo_br_vital_diastolic_Sortedstatus ;
      private String Ddo_br_vital_diastolic_Sortasc ;
      private String Ddo_br_vital_diastolic_Sortdsc ;
      private String Ddo_br_vital_diastolic_Searchbuttontext ;
      private String Ddo_br_vital_height_Caption ;
      private String Ddo_br_vital_height_Tooltip ;
      private String Ddo_br_vital_height_Cls ;
      private String Ddo_br_vital_height_Dropdownoptionstype ;
      private String Ddo_br_vital_height_Titlecontrolidtoreplace ;
      private String Ddo_br_vital_height_Sortedstatus ;
      private String Ddo_br_vital_height_Sortasc ;
      private String Ddo_br_vital_height_Sortdsc ;
      private String Ddo_br_vital_height_Searchbuttontext ;
      private String Ddo_br_vital_weight_Caption ;
      private String Ddo_br_vital_weight_Tooltip ;
      private String Ddo_br_vital_weight_Cls ;
      private String Ddo_br_vital_weight_Dropdownoptionstype ;
      private String Ddo_br_vital_weight_Titlecontrolidtoreplace ;
      private String Ddo_br_vital_weight_Sortedstatus ;
      private String Ddo_br_vital_weight_Sortasc ;
      private String Ddo_br_vital_weight_Sortdsc ;
      private String Ddo_br_vital_weight_Searchbuttontext ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divLayoutmaintable_Internalname ;
      private String divTablemain_Internalname ;
      private String divGridtablewithpaginationbar_Internalname ;
      private String sStyleString ;
      private String subGrid_Internalname ;
      private String subGrid_Class ;
      private String subGrid_Linesclass ;
      private String edtBR_VitalID_Title ;
      private String edtBR_EncounterID_Title ;
      private String edtBR_Information_PatientNo_Title ;
      private String edtBR_Vital_VitalID_Title ;
      private String edtBR_Vital_MeasureDate_Title ;
      private String edtBR_Vital_Temperature_Title ;
      private String edtBR_Vital_Pulse_Title ;
      private String edtBR_Vital_Respiration_Title ;
      private String edtBR_Vital_Systolic_Title ;
      private String edtBR_Vital_Diastolic_Title ;
      private String edtBR_Vital_Height_Title ;
      private String edtBR_Vital_Weight_Title ;
      private String subGrid_Header ;
      private String edtavSelect_Tooltiptext ;
      private String divHtml_gridpaginationbar_Internalname ;
      private String Gridpaginationbar_Internalname ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String Ddo_br_vitalid_Internalname ;
      private String TempTags ;
      private String ClassString ;
      private String StyleString ;
      private String edtavDdo_br_vitalidtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_encounterid_Internalname ;
      private String edtavDdo_br_encounteridtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_information_patientno_Internalname ;
      private String edtavDdo_br_information_patientnotitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_vital_vitalid_Internalname ;
      private String edtavDdo_br_vital_vitalidtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_vital_measuredate_Internalname ;
      private String edtavDdo_br_vital_measuredatetitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_vital_temperature_Internalname ;
      private String edtavDdo_br_vital_temperaturetitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_vital_pulse_Internalname ;
      private String edtavDdo_br_vital_pulsetitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_vital_respiration_Internalname ;
      private String edtavDdo_br_vital_respirationtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_vital_systolic_Internalname ;
      private String edtavDdo_br_vital_systolictitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_vital_diastolic_Internalname ;
      private String edtavDdo_br_vital_diastolictitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_vital_height_Internalname ;
      private String edtavDdo_br_vital_heighttitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_vital_weight_Internalname ;
      private String edtavDdo_br_vital_weighttitlecontrolidtoreplace_Internalname ;
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
      private String edtBR_VitalID_Internalname ;
      private String edtBR_EncounterID_Internalname ;
      private String edtBR_Information_PatientNo_Internalname ;
      private String edtBR_Vital_VitalID_Internalname ;
      private String edtBR_Vital_MeasureDate_Internalname ;
      private String edtBR_Vital_Temperature_Internalname ;
      private String edtBR_Vital_Pulse_Internalname ;
      private String edtBR_Vital_Respiration_Internalname ;
      private String edtBR_Vital_Systolic_Internalname ;
      private String edtBR_Vital_Diastolic_Internalname ;
      private String edtBR_Vital_Height_Internalname ;
      private String edtBR_Vital_Weight_Internalname ;
      private String scmdbuf ;
      private String sGXsfl_12_fel_idx="0001" ;
      private String sImgUrl ;
      private String edtavSelect_Jsonclick ;
      private String ROClassString ;
      private String edtBR_VitalID_Jsonclick ;
      private String edtBR_EncounterID_Jsonclick ;
      private String edtBR_Information_PatientNo_Jsonclick ;
      private String edtBR_Vital_VitalID_Jsonclick ;
      private String edtBR_Vital_MeasureDate_Jsonclick ;
      private String edtBR_Vital_Temperature_Jsonclick ;
      private String edtBR_Vital_Pulse_Jsonclick ;
      private String edtBR_Vital_Respiration_Jsonclick ;
      private String edtBR_Vital_Systolic_Jsonclick ;
      private String edtBR_Vital_Diastolic_Jsonclick ;
      private String edtBR_Vital_Height_Jsonclick ;
      private String edtBR_Vital_Weight_Jsonclick ;
      private DateTime A152BR_Vital_MeasureDate ;
      private bool entryPointCalled ;
      private bool AV11OrderedDsc ;
      private bool toggleJsOutput ;
      private bool Gridpaginationbar_Showfirst ;
      private bool Gridpaginationbar_Showprevious ;
      private bool Gridpaginationbar_Shownext ;
      private bool Gridpaginationbar_Showlast ;
      private bool Gridpaginationbar_Rowsperpageselector ;
      private bool Ddo_br_vitalid_Includesortasc ;
      private bool Ddo_br_vitalid_Includesortdsc ;
      private bool Ddo_br_vitalid_Includefilter ;
      private bool Ddo_br_vitalid_Includedatalist ;
      private bool Ddo_br_encounterid_Includesortasc ;
      private bool Ddo_br_encounterid_Includesortdsc ;
      private bool Ddo_br_encounterid_Includefilter ;
      private bool Ddo_br_encounterid_Includedatalist ;
      private bool Ddo_br_information_patientno_Includesortasc ;
      private bool Ddo_br_information_patientno_Includesortdsc ;
      private bool Ddo_br_information_patientno_Includefilter ;
      private bool Ddo_br_information_patientno_Includedatalist ;
      private bool Ddo_br_vital_vitalid_Includesortasc ;
      private bool Ddo_br_vital_vitalid_Includesortdsc ;
      private bool Ddo_br_vital_vitalid_Includefilter ;
      private bool Ddo_br_vital_vitalid_Includedatalist ;
      private bool Ddo_br_vital_measuredate_Includesortasc ;
      private bool Ddo_br_vital_measuredate_Includesortdsc ;
      private bool Ddo_br_vital_measuredate_Includefilter ;
      private bool Ddo_br_vital_measuredate_Includedatalist ;
      private bool Ddo_br_vital_temperature_Includesortasc ;
      private bool Ddo_br_vital_temperature_Includesortdsc ;
      private bool Ddo_br_vital_temperature_Includefilter ;
      private bool Ddo_br_vital_temperature_Includedatalist ;
      private bool Ddo_br_vital_pulse_Includesortasc ;
      private bool Ddo_br_vital_pulse_Includesortdsc ;
      private bool Ddo_br_vital_pulse_Includefilter ;
      private bool Ddo_br_vital_pulse_Includedatalist ;
      private bool Ddo_br_vital_respiration_Includesortasc ;
      private bool Ddo_br_vital_respiration_Includesortdsc ;
      private bool Ddo_br_vital_respiration_Includefilter ;
      private bool Ddo_br_vital_respiration_Includedatalist ;
      private bool Ddo_br_vital_systolic_Includesortasc ;
      private bool Ddo_br_vital_systolic_Includesortdsc ;
      private bool Ddo_br_vital_systolic_Includefilter ;
      private bool Ddo_br_vital_systolic_Includedatalist ;
      private bool Ddo_br_vital_diastolic_Includesortasc ;
      private bool Ddo_br_vital_diastolic_Includesortdsc ;
      private bool Ddo_br_vital_diastolic_Includefilter ;
      private bool Ddo_br_vital_diastolic_Includedatalist ;
      private bool Ddo_br_vital_height_Includesortasc ;
      private bool Ddo_br_vital_height_Includesortdsc ;
      private bool Ddo_br_vital_height_Includefilter ;
      private bool Ddo_br_vital_height_Includedatalist ;
      private bool Ddo_br_vital_weight_Includesortasc ;
      private bool Ddo_br_vital_weight_Includesortdsc ;
      private bool Ddo_br_vital_weight_Includefilter ;
      private bool Ddo_br_vital_weight_Includedatalist ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_12_Refreshing=false ;
      private bool n36BR_Information_PatientNo ;
      private bool n151BR_Vital_VitalID ;
      private bool n152BR_Vital_MeasureDate ;
      private bool n153BR_Vital_Temperature ;
      private bool n154BR_Vital_Pulse ;
      private bool n155BR_Vital_Respiration ;
      private bool n156BR_Vital_Systolic ;
      private bool n157BR_Vital_Diastolic ;
      private bool n158BR_Vital_Height ;
      private bool n159BR_Vital_Weight ;
      private bool gxdyncontrolsrefreshing ;
      private bool n85BR_Information_ID ;
      private bool returnInSub ;
      private bool AV5IsAuthorized ;
      private bool GXt_boolean1 ;
      private bool gx_refresh_fired ;
      private bool AV41Select_IsBlob ;
      private String AV13ddo_BR_VitalIDTitleControlIdToReplace ;
      private String AV15ddo_BR_EncounterIDTitleControlIdToReplace ;
      private String AV17ddo_BR_Information_PatientNoTitleControlIdToReplace ;
      private String AV19ddo_BR_Vital_VitalIDTitleControlIdToReplace ;
      private String AV21ddo_BR_Vital_MeasureDateTitleControlIdToReplace ;
      private String AV23ddo_BR_Vital_TemperatureTitleControlIdToReplace ;
      private String AV25ddo_BR_Vital_PulseTitleControlIdToReplace ;
      private String AV27ddo_BR_Vital_RespirationTitleControlIdToReplace ;
      private String AV29ddo_BR_Vital_SystolicTitleControlIdToReplace ;
      private String AV31ddo_BR_Vital_DiastolicTitleControlIdToReplace ;
      private String AV33ddo_BR_Vital_HeightTitleControlIdToReplace ;
      private String AV35ddo_BR_Vital_WeightTitleControlIdToReplace ;
      private String A36BR_Information_PatientNo ;
      private String AV45Select_GXI ;
      private String AV41Select ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private GXUserControl ucGridpaginationbar ;
      private GXUserControl ucDdo_br_vitalid ;
      private GXUserControl ucDdo_br_encounterid ;
      private GXUserControl ucDdo_br_information_patientno ;
      private GXUserControl ucDdo_br_vital_vitalid ;
      private GXUserControl ucDdo_br_vital_measuredate ;
      private GXUserControl ucDdo_br_vital_temperature ;
      private GXUserControl ucDdo_br_vital_pulse ;
      private GXUserControl ucDdo_br_vital_respiration ;
      private GXUserControl ucDdo_br_vital_systolic ;
      private GXUserControl ucDdo_br_vital_diastolic ;
      private GXUserControl ucDdo_br_vital_height ;
      private GXUserControl ucDdo_br_vital_weight ;
      private GXUserControl ucWorkwithplusutilities1 ;
      private GXWebForm Form ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private long aP0_InOutBR_VitalID ;
      private IDataStoreProvider pr_default ;
      private long[] H00622_A85BR_Information_ID ;
      private bool[] H00622_n85BR_Information_ID ;
      private decimal[] H00622_A159BR_Vital_Weight ;
      private bool[] H00622_n159BR_Vital_Weight ;
      private decimal[] H00622_A158BR_Vital_Height ;
      private bool[] H00622_n158BR_Vital_Height ;
      private decimal[] H00622_A157BR_Vital_Diastolic ;
      private bool[] H00622_n157BR_Vital_Diastolic ;
      private decimal[] H00622_A156BR_Vital_Systolic ;
      private bool[] H00622_n156BR_Vital_Systolic ;
      private decimal[] H00622_A155BR_Vital_Respiration ;
      private bool[] H00622_n155BR_Vital_Respiration ;
      private decimal[] H00622_A154BR_Vital_Pulse ;
      private bool[] H00622_n154BR_Vital_Pulse ;
      private decimal[] H00622_A153BR_Vital_Temperature ;
      private bool[] H00622_n153BR_Vital_Temperature ;
      private DateTime[] H00622_A152BR_Vital_MeasureDate ;
      private bool[] H00622_n152BR_Vital_MeasureDate ;
      private long[] H00622_A151BR_Vital_VitalID ;
      private bool[] H00622_n151BR_Vital_VitalID ;
      private String[] H00622_A36BR_Information_PatientNo ;
      private bool[] H00622_n36BR_Information_PatientNo ;
      private long[] H00622_A19BR_EncounterID ;
      private long[] H00622_A150BR_VitalID ;
      private long[] H00623_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV12BR_VitalIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV14BR_EncounterIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV16BR_Information_PatientNoTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV18BR_Vital_VitalIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV20BR_Vital_MeasureDateTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV22BR_Vital_TemperatureTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV24BR_Vital_PulseTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV26BR_Vital_RespirationTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV28BR_Vital_SystolicTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV30BR_Vital_DiastolicTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV32BR_Vital_HeightTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV34BR_Vital_WeightTitleFilterData ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons AV36DDO_TitleSettingsIcons ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 ;
   }

   public class br_vitalprompt__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H00622( IGxContext context ,
                                             short AV10OrderedBy ,
                                             bool AV11OrderedDsc )
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
         sSelectString = " T2.[BR_Information_ID], T1.[BR_Vital_Weight], T1.[BR_Vital_Height], T1.[BR_Vital_Diastolic], T1.[BR_Vital_Systolic], T1.[BR_Vital_Respiration], T1.[BR_Vital_Pulse], T1.[BR_Vital_Temperature], T1.[BR_Vital_MeasureDate], T1.[BR_Vital_VitalID], T3.[BR_Information_PatientNo], T1.[BR_EncounterID], T1.[BR_VitalID]";
         sFromString = " FROM (([BR_Vital] T1 WITH (NOLOCK) INNER JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = T1.[BR_EncounterID]) LEFT JOIN [BR_Information] T3 WITH (NOLOCK) ON T3.[BR_Information_ID] = T2.[BR_Information_ID])";
         sOrderString = "";
         if ( ( AV10OrderedBy == 1 ) && ! AV11OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_VitalID]";
         }
         else if ( ( AV10OrderedBy == 1 ) && ( AV11OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_VitalID] DESC";
         }
         else if ( ( AV10OrderedBy == 2 ) && ! AV11OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_EncounterID]";
         }
         else if ( ( AV10OrderedBy == 2 ) && ( AV11OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_EncounterID] DESC";
         }
         else if ( ( AV10OrderedBy == 3 ) && ! AV11OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T3.[BR_Information_PatientNo]";
         }
         else if ( ( AV10OrderedBy == 3 ) && ( AV11OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T3.[BR_Information_PatientNo] DESC";
         }
         else if ( ( AV10OrderedBy == 4 ) && ! AV11OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Vital_VitalID]";
         }
         else if ( ( AV10OrderedBy == 4 ) && ( AV11OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Vital_VitalID] DESC";
         }
         else if ( ( AV10OrderedBy == 5 ) && ! AV11OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Vital_MeasureDate]";
         }
         else if ( ( AV10OrderedBy == 5 ) && ( AV11OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Vital_MeasureDate] DESC";
         }
         else if ( ( AV10OrderedBy == 6 ) && ! AV11OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Vital_Temperature]";
         }
         else if ( ( AV10OrderedBy == 6 ) && ( AV11OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Vital_Temperature] DESC";
         }
         else if ( ( AV10OrderedBy == 7 ) && ! AV11OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Vital_Pulse]";
         }
         else if ( ( AV10OrderedBy == 7 ) && ( AV11OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Vital_Pulse] DESC";
         }
         else if ( ( AV10OrderedBy == 8 ) && ! AV11OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Vital_Respiration]";
         }
         else if ( ( AV10OrderedBy == 8 ) && ( AV11OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Vital_Respiration] DESC";
         }
         else if ( ( AV10OrderedBy == 9 ) && ! AV11OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Vital_Systolic]";
         }
         else if ( ( AV10OrderedBy == 9 ) && ( AV11OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Vital_Systolic] DESC";
         }
         else if ( ( AV10OrderedBy == 10 ) && ! AV11OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Vital_Diastolic]";
         }
         else if ( ( AV10OrderedBy == 10 ) && ( AV11OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Vital_Diastolic] DESC";
         }
         else if ( ( AV10OrderedBy == 11 ) && ! AV11OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Vital_Height]";
         }
         else if ( ( AV10OrderedBy == 11 ) && ( AV11OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Vital_Height] DESC";
         }
         else if ( ( AV10OrderedBy == 12 ) && ! AV11OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Vital_Weight]";
         }
         else if ( ( AV10OrderedBy == 12 ) && ( AV11OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Vital_Weight] DESC";
         }
         else if ( true )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_VitalID]";
         }
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object4[0] = scmdbuf;
         GXv_Object4[1] = GXv_int3;
         return GXv_Object4 ;
      }

      protected Object[] conditional_H00623( IGxContext context ,
                                             short AV10OrderedBy ,
                                             bool AV11OrderedDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         Object[] GXv_Object5 ;
         GXv_Object5 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM (([BR_Vital] T1 WITH (NOLOCK) INNER JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = T1.[BR_EncounterID]) LEFT JOIN [BR_Information] T3 WITH (NOLOCK) ON T3.[BR_Information_ID] = T2.[BR_Information_ID])";
         if ( ( AV10OrderedBy == 1 ) && ! AV11OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV10OrderedBy == 1 ) && ( AV11OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV10OrderedBy == 2 ) && ! AV11OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV10OrderedBy == 2 ) && ( AV11OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV10OrderedBy == 3 ) && ! AV11OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV10OrderedBy == 3 ) && ( AV11OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV10OrderedBy == 4 ) && ! AV11OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV10OrderedBy == 4 ) && ( AV11OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV10OrderedBy == 5 ) && ! AV11OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV10OrderedBy == 5 ) && ( AV11OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV10OrderedBy == 6 ) && ! AV11OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV10OrderedBy == 6 ) && ( AV11OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV10OrderedBy == 7 ) && ! AV11OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV10OrderedBy == 7 ) && ( AV11OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV10OrderedBy == 8 ) && ! AV11OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV10OrderedBy == 8 ) && ( AV11OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV10OrderedBy == 9 ) && ! AV11OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV10OrderedBy == 9 ) && ( AV11OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV10OrderedBy == 10 ) && ! AV11OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV10OrderedBy == 10 ) && ( AV11OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV10OrderedBy == 11 ) && ! AV11OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV10OrderedBy == 11 ) && ( AV11OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV10OrderedBy == 12 ) && ! AV11OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV10OrderedBy == 12 ) && ( AV11OrderedDsc ) )
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
                     return conditional_H00622(context, (short)dynConstraints[0] , (bool)dynConstraints[1] );
               case 1 :
                     return conditional_H00623(context, (short)dynConstraints[0] , (bool)dynConstraints[1] );
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
          Object[] prmH00622 ;
          prmH00622 = new Object[] {
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH00623 ;
          prmH00623 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("H00622", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00622,11,0,true,false )
             ,new CursorDef("H00623", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00623,1,0,true,false )
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
                ((decimal[]) buf[4])[0] = rslt.getDecimal(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((decimal[]) buf[6])[0] = rslt.getDecimal(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((decimal[]) buf[8])[0] = rslt.getDecimal(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((decimal[]) buf[10])[0] = rslt.getDecimal(6) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(6);
                ((decimal[]) buf[12])[0] = rslt.getDecimal(7) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(7);
                ((decimal[]) buf[14])[0] = rslt.getDecimal(8) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(8);
                ((DateTime[]) buf[16])[0] = rslt.getGXDate(9) ;
                ((bool[]) buf[17])[0] = rslt.wasNull(9);
                ((long[]) buf[18])[0] = rslt.getLong(10) ;
                ((bool[]) buf[19])[0] = rslt.wasNull(10);
                ((String[]) buf[20])[0] = rslt.getVarchar(11) ;
                ((bool[]) buf[21])[0] = rslt.wasNull(11);
                ((long[]) buf[22])[0] = rslt.getLong(12) ;
                ((long[]) buf[23])[0] = rslt.getLong(13) ;
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
