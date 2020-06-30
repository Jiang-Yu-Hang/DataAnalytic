/*
               File: BR_DemographicsPrompt
        Description: 选择人口信息学
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:39:50.62
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
   public class br_demographicsprompt : GXHttpHandler, System.Web.SessionState.IRequiresSessionState
   {
      public br_demographicsprompt( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_demographicsprompt( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( ref long aP0_InOutBR_Demographics_ID )
      {
         this.AV8InOutBR_Demographics_ID = aP0_InOutBR_Demographics_ID;
         executePrivate();
         aP0_InOutBR_Demographics_ID=this.AV8InOutBR_Demographics_ID;
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
               AV13ddo_BR_Demographics_IDTitleControlIdToReplace = GetNextPar( );
               AV15ddo_BR_EncounterIDTitleControlIdToReplace = GetNextPar( );
               AV19ddo_BR_Information_PatientNoTitleControlIdToReplace = GetNextPar( );
               AV21ddo_BR_Demographics_BirthDateTitleControlIdToReplace = GetNextPar( );
               AV25ddo_BR_Demographics_SexTitleControlIdToReplace = GetNextPar( );
               AV27ddo_BR_Demographics_MarritalStatusTitleControlIdToReplace = GetNextPar( );
               AV29ddo_BR_Demographics_EthnicTitleControlIdToReplace = GetNextPar( );
               AV31ddo_BR_Demographics_EducationTitleControlIdToReplace = GetNextPar( );
               AV33ddo_BR_Demographics_OccupationTitleControlIdToReplace = GetNextPar( );
               AV35ddo_BR_Demographics_InsuranceTitleControlIdToReplace = GetNextPar( );
               AV37ddo_BR_Demographics_ProvinceTitleControlIdToReplace = GetNextPar( );
               AV39ddo_BR_Demographics_CityTitleControlIdToReplace = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid_refresh( subGrid_Rows, AV10OrderedBy, AV11OrderedDsc, AV13ddo_BR_Demographics_IDTitleControlIdToReplace, AV15ddo_BR_EncounterIDTitleControlIdToReplace, AV19ddo_BR_Information_PatientNoTitleControlIdToReplace, AV21ddo_BR_Demographics_BirthDateTitleControlIdToReplace, AV25ddo_BR_Demographics_SexTitleControlIdToReplace, AV27ddo_BR_Demographics_MarritalStatusTitleControlIdToReplace, AV29ddo_BR_Demographics_EthnicTitleControlIdToReplace, AV31ddo_BR_Demographics_EducationTitleControlIdToReplace, AV33ddo_BR_Demographics_OccupationTitleControlIdToReplace, AV35ddo_BR_Demographics_InsuranceTitleControlIdToReplace, AV37ddo_BR_Demographics_ProvinceTitleControlIdToReplace, AV39ddo_BR_Demographics_CityTitleControlIdToReplace) ;
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
               AV8InOutBR_Demographics_ID = (long)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8InOutBR_Demographics_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8InOutBR_Demographics_ID), 18, 0)));
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
            PA2M2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV48Pgmname = "BR_DemographicsPrompt";
               context.Gx_err = 0;
               WS2M2( ) ;
               if ( ! isAjaxCallMode( ) )
               {
                  WE2M2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?20202279395087", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_demographicsprompt.aspx") + "?" + UrlEncode("" +AV8InOutBR_Demographics_ID)+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "vGRIDCURRENTPAGE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV42GridCurrentPage), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDRECORDCOUNT", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV44GridRecordCount), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDPAGESIZE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV43GridPageSize), 10, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vDDO_TITLESETTINGSICONS", AV40DDO_TitleSettingsIcons);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vDDO_TITLESETTINGSICONS", AV40DDO_TitleSettingsIcons);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_DEMOGRAPHICS_IDTITLEFILTERDATA", AV12BR_Demographics_IDTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_DEMOGRAPHICS_IDTITLEFILTERDATA", AV12BR_Demographics_IDTitleFilterData);
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
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_INFORMATION_PATIENTNOTITLEFILTERDATA", AV18BR_Information_PatientNoTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_INFORMATION_PATIENTNOTITLEFILTERDATA", AV18BR_Information_PatientNoTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_DEMOGRAPHICS_BIRTHDATETITLEFILTERDATA", AV20BR_Demographics_BirthDateTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_DEMOGRAPHICS_BIRTHDATETITLEFILTERDATA", AV20BR_Demographics_BirthDateTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_DEMOGRAPHICS_SEXTITLEFILTERDATA", AV24BR_Demographics_SexTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_DEMOGRAPHICS_SEXTITLEFILTERDATA", AV24BR_Demographics_SexTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_DEMOGRAPHICS_MARRITALSTATUSTITLEFILTERDATA", AV26BR_Demographics_MarritalStatusTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_DEMOGRAPHICS_MARRITALSTATUSTITLEFILTERDATA", AV26BR_Demographics_MarritalStatusTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_DEMOGRAPHICS_ETHNICTITLEFILTERDATA", AV28BR_Demographics_EthnicTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_DEMOGRAPHICS_ETHNICTITLEFILTERDATA", AV28BR_Demographics_EthnicTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_DEMOGRAPHICS_EDUCATIONTITLEFILTERDATA", AV30BR_Demographics_EducationTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_DEMOGRAPHICS_EDUCATIONTITLEFILTERDATA", AV30BR_Demographics_EducationTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_DEMOGRAPHICS_OCCUPATIONTITLEFILTERDATA", AV32BR_Demographics_OccupationTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_DEMOGRAPHICS_OCCUPATIONTITLEFILTERDATA", AV32BR_Demographics_OccupationTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_DEMOGRAPHICS_INSURANCETITLEFILTERDATA", AV34BR_Demographics_InsuranceTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_DEMOGRAPHICS_INSURANCETITLEFILTERDATA", AV34BR_Demographics_InsuranceTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_DEMOGRAPHICS_PROVINCETITLEFILTERDATA", AV36BR_Demographics_ProvinceTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_DEMOGRAPHICS_PROVINCETITLEFILTERDATA", AV36BR_Demographics_ProvinceTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_DEMOGRAPHICS_CITYTITLEFILTERDATA", AV38BR_Demographics_CityTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_DEMOGRAPHICS_CITYTITLEFILTERDATA", AV38BR_Demographics_CityTitleFilterData);
         }
         GxWebStd.gx_hidden_field( context, "vINOUTBR_DEMOGRAPHICS_ID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8InOutBR_Demographics_ID), 18, 0, ".", "")));
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
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_ID_Caption", StringUtil.RTrim( Ddo_br_demographics_id_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_ID_Tooltip", StringUtil.RTrim( Ddo_br_demographics_id_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_ID_Cls", StringUtil.RTrim( Ddo_br_demographics_id_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_ID_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_demographics_id_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_ID_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_demographics_id_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_ID_Includesortasc", StringUtil.BoolToStr( Ddo_br_demographics_id_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_ID_Includesortdsc", StringUtil.BoolToStr( Ddo_br_demographics_id_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_ID_Sortedstatus", StringUtil.RTrim( Ddo_br_demographics_id_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_ID_Includefilter", StringUtil.BoolToStr( Ddo_br_demographics_id_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_ID_Includedatalist", StringUtil.BoolToStr( Ddo_br_demographics_id_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_ID_Sortasc", StringUtil.RTrim( Ddo_br_demographics_id_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_ID_Sortdsc", StringUtil.RTrim( Ddo_br_demographics_id_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_ID_Searchbuttontext", StringUtil.RTrim( Ddo_br_demographics_id_Searchbuttontext));
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
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_BIRTHDATE_Caption", StringUtil.RTrim( Ddo_br_demographics_birthdate_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_BIRTHDATE_Tooltip", StringUtil.RTrim( Ddo_br_demographics_birthdate_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_BIRTHDATE_Cls", StringUtil.RTrim( Ddo_br_demographics_birthdate_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_BIRTHDATE_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_demographics_birthdate_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_BIRTHDATE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_demographics_birthdate_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_BIRTHDATE_Includesortasc", StringUtil.BoolToStr( Ddo_br_demographics_birthdate_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_BIRTHDATE_Includesortdsc", StringUtil.BoolToStr( Ddo_br_demographics_birthdate_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_BIRTHDATE_Sortedstatus", StringUtil.RTrim( Ddo_br_demographics_birthdate_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_BIRTHDATE_Includefilter", StringUtil.BoolToStr( Ddo_br_demographics_birthdate_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_BIRTHDATE_Includedatalist", StringUtil.BoolToStr( Ddo_br_demographics_birthdate_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_BIRTHDATE_Sortasc", StringUtil.RTrim( Ddo_br_demographics_birthdate_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_BIRTHDATE_Sortdsc", StringUtil.RTrim( Ddo_br_demographics_birthdate_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_BIRTHDATE_Searchbuttontext", StringUtil.RTrim( Ddo_br_demographics_birthdate_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_SEX_Caption", StringUtil.RTrim( Ddo_br_demographics_sex_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_SEX_Tooltip", StringUtil.RTrim( Ddo_br_demographics_sex_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_SEX_Cls", StringUtil.RTrim( Ddo_br_demographics_sex_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_SEX_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_demographics_sex_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_SEX_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_demographics_sex_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_SEX_Includesortasc", StringUtil.BoolToStr( Ddo_br_demographics_sex_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_SEX_Includesortdsc", StringUtil.BoolToStr( Ddo_br_demographics_sex_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_SEX_Sortedstatus", StringUtil.RTrim( Ddo_br_demographics_sex_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_SEX_Includefilter", StringUtil.BoolToStr( Ddo_br_demographics_sex_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_SEX_Includedatalist", StringUtil.BoolToStr( Ddo_br_demographics_sex_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_SEX_Sortasc", StringUtil.RTrim( Ddo_br_demographics_sex_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_SEX_Sortdsc", StringUtil.RTrim( Ddo_br_demographics_sex_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_SEX_Searchbuttontext", StringUtil.RTrim( Ddo_br_demographics_sex_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_MARRITALSTATUS_Caption", StringUtil.RTrim( Ddo_br_demographics_marritalstatus_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_MARRITALSTATUS_Tooltip", StringUtil.RTrim( Ddo_br_demographics_marritalstatus_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_MARRITALSTATUS_Cls", StringUtil.RTrim( Ddo_br_demographics_marritalstatus_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_MARRITALSTATUS_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_demographics_marritalstatus_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_MARRITALSTATUS_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_demographics_marritalstatus_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_MARRITALSTATUS_Includesortasc", StringUtil.BoolToStr( Ddo_br_demographics_marritalstatus_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_MARRITALSTATUS_Includesortdsc", StringUtil.BoolToStr( Ddo_br_demographics_marritalstatus_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_MARRITALSTATUS_Sortedstatus", StringUtil.RTrim( Ddo_br_demographics_marritalstatus_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_MARRITALSTATUS_Includefilter", StringUtil.BoolToStr( Ddo_br_demographics_marritalstatus_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_MARRITALSTATUS_Includedatalist", StringUtil.BoolToStr( Ddo_br_demographics_marritalstatus_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_MARRITALSTATUS_Sortasc", StringUtil.RTrim( Ddo_br_demographics_marritalstatus_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_MARRITALSTATUS_Sortdsc", StringUtil.RTrim( Ddo_br_demographics_marritalstatus_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_MARRITALSTATUS_Searchbuttontext", StringUtil.RTrim( Ddo_br_demographics_marritalstatus_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_ETHNIC_Caption", StringUtil.RTrim( Ddo_br_demographics_ethnic_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_ETHNIC_Tooltip", StringUtil.RTrim( Ddo_br_demographics_ethnic_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_ETHNIC_Cls", StringUtil.RTrim( Ddo_br_demographics_ethnic_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_ETHNIC_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_demographics_ethnic_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_ETHNIC_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_demographics_ethnic_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_ETHNIC_Includesortasc", StringUtil.BoolToStr( Ddo_br_demographics_ethnic_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_ETHNIC_Includesortdsc", StringUtil.BoolToStr( Ddo_br_demographics_ethnic_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_ETHNIC_Sortedstatus", StringUtil.RTrim( Ddo_br_demographics_ethnic_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_ETHNIC_Includefilter", StringUtil.BoolToStr( Ddo_br_demographics_ethnic_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_ETHNIC_Includedatalist", StringUtil.BoolToStr( Ddo_br_demographics_ethnic_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_ETHNIC_Sortasc", StringUtil.RTrim( Ddo_br_demographics_ethnic_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_ETHNIC_Sortdsc", StringUtil.RTrim( Ddo_br_demographics_ethnic_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_ETHNIC_Searchbuttontext", StringUtil.RTrim( Ddo_br_demographics_ethnic_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_EDUCATION_Caption", StringUtil.RTrim( Ddo_br_demographics_education_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_EDUCATION_Tooltip", StringUtil.RTrim( Ddo_br_demographics_education_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_EDUCATION_Cls", StringUtil.RTrim( Ddo_br_demographics_education_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_EDUCATION_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_demographics_education_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_EDUCATION_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_demographics_education_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_EDUCATION_Includesortasc", StringUtil.BoolToStr( Ddo_br_demographics_education_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_EDUCATION_Includesortdsc", StringUtil.BoolToStr( Ddo_br_demographics_education_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_EDUCATION_Sortedstatus", StringUtil.RTrim( Ddo_br_demographics_education_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_EDUCATION_Includefilter", StringUtil.BoolToStr( Ddo_br_demographics_education_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_EDUCATION_Includedatalist", StringUtil.BoolToStr( Ddo_br_demographics_education_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_EDUCATION_Sortasc", StringUtil.RTrim( Ddo_br_demographics_education_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_EDUCATION_Sortdsc", StringUtil.RTrim( Ddo_br_demographics_education_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_EDUCATION_Searchbuttontext", StringUtil.RTrim( Ddo_br_demographics_education_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_OCCUPATION_Caption", StringUtil.RTrim( Ddo_br_demographics_occupation_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_OCCUPATION_Tooltip", StringUtil.RTrim( Ddo_br_demographics_occupation_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_OCCUPATION_Cls", StringUtil.RTrim( Ddo_br_demographics_occupation_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_OCCUPATION_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_demographics_occupation_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_OCCUPATION_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_demographics_occupation_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_OCCUPATION_Includesortasc", StringUtil.BoolToStr( Ddo_br_demographics_occupation_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_OCCUPATION_Includesortdsc", StringUtil.BoolToStr( Ddo_br_demographics_occupation_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_OCCUPATION_Sortedstatus", StringUtil.RTrim( Ddo_br_demographics_occupation_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_OCCUPATION_Includefilter", StringUtil.BoolToStr( Ddo_br_demographics_occupation_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_OCCUPATION_Includedatalist", StringUtil.BoolToStr( Ddo_br_demographics_occupation_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_OCCUPATION_Sortasc", StringUtil.RTrim( Ddo_br_demographics_occupation_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_OCCUPATION_Sortdsc", StringUtil.RTrim( Ddo_br_demographics_occupation_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_OCCUPATION_Searchbuttontext", StringUtil.RTrim( Ddo_br_demographics_occupation_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_INSURANCE_Caption", StringUtil.RTrim( Ddo_br_demographics_insurance_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_INSURANCE_Tooltip", StringUtil.RTrim( Ddo_br_demographics_insurance_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_INSURANCE_Cls", StringUtil.RTrim( Ddo_br_demographics_insurance_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_INSURANCE_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_demographics_insurance_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_INSURANCE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_demographics_insurance_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_INSURANCE_Includesortasc", StringUtil.BoolToStr( Ddo_br_demographics_insurance_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_INSURANCE_Includesortdsc", StringUtil.BoolToStr( Ddo_br_demographics_insurance_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_INSURANCE_Sortedstatus", StringUtil.RTrim( Ddo_br_demographics_insurance_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_INSURANCE_Includefilter", StringUtil.BoolToStr( Ddo_br_demographics_insurance_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_INSURANCE_Includedatalist", StringUtil.BoolToStr( Ddo_br_demographics_insurance_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_INSURANCE_Sortasc", StringUtil.RTrim( Ddo_br_demographics_insurance_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_INSURANCE_Sortdsc", StringUtil.RTrim( Ddo_br_demographics_insurance_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_INSURANCE_Searchbuttontext", StringUtil.RTrim( Ddo_br_demographics_insurance_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_PROVINCE_Caption", StringUtil.RTrim( Ddo_br_demographics_province_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_PROVINCE_Tooltip", StringUtil.RTrim( Ddo_br_demographics_province_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_PROVINCE_Cls", StringUtil.RTrim( Ddo_br_demographics_province_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_PROVINCE_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_demographics_province_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_PROVINCE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_demographics_province_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_PROVINCE_Includesortasc", StringUtil.BoolToStr( Ddo_br_demographics_province_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_PROVINCE_Includesortdsc", StringUtil.BoolToStr( Ddo_br_demographics_province_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_PROVINCE_Sortedstatus", StringUtil.RTrim( Ddo_br_demographics_province_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_PROVINCE_Includefilter", StringUtil.BoolToStr( Ddo_br_demographics_province_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_PROVINCE_Includedatalist", StringUtil.BoolToStr( Ddo_br_demographics_province_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_PROVINCE_Sortasc", StringUtil.RTrim( Ddo_br_demographics_province_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_PROVINCE_Sortdsc", StringUtil.RTrim( Ddo_br_demographics_province_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_PROVINCE_Searchbuttontext", StringUtil.RTrim( Ddo_br_demographics_province_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_CITY_Caption", StringUtil.RTrim( Ddo_br_demographics_city_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_CITY_Tooltip", StringUtil.RTrim( Ddo_br_demographics_city_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_CITY_Cls", StringUtil.RTrim( Ddo_br_demographics_city_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_CITY_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_demographics_city_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_CITY_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_demographics_city_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_CITY_Includesortasc", StringUtil.BoolToStr( Ddo_br_demographics_city_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_CITY_Includesortdsc", StringUtil.BoolToStr( Ddo_br_demographics_city_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_CITY_Sortedstatus", StringUtil.RTrim( Ddo_br_demographics_city_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_CITY_Includefilter", StringUtil.BoolToStr( Ddo_br_demographics_city_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_CITY_Includedatalist", StringUtil.BoolToStr( Ddo_br_demographics_city_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_CITY_Sortasc", StringUtil.RTrim( Ddo_br_demographics_city_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_CITY_Sortdsc", StringUtil.RTrim( Ddo_br_demographics_city_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_CITY_Searchbuttontext", StringUtil.RTrim( Ddo_br_demographics_city_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_ID_Activeeventkey", StringUtil.RTrim( Ddo_br_demographics_id_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Activeeventkey", StringUtil.RTrim( Ddo_br_encounterid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Activeeventkey", StringUtil.RTrim( Ddo_br_information_patientno_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_BIRTHDATE_Activeeventkey", StringUtil.RTrim( Ddo_br_demographics_birthdate_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_SEX_Activeeventkey", StringUtil.RTrim( Ddo_br_demographics_sex_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_MARRITALSTATUS_Activeeventkey", StringUtil.RTrim( Ddo_br_demographics_marritalstatus_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_ETHNIC_Activeeventkey", StringUtil.RTrim( Ddo_br_demographics_ethnic_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_EDUCATION_Activeeventkey", StringUtil.RTrim( Ddo_br_demographics_education_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_OCCUPATION_Activeeventkey", StringUtil.RTrim( Ddo_br_demographics_occupation_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_INSURANCE_Activeeventkey", StringUtil.RTrim( Ddo_br_demographics_insurance_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_PROVINCE_Activeeventkey", StringUtil.RTrim( Ddo_br_demographics_province_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_CITY_Activeeventkey", StringUtil.RTrim( Ddo_br_demographics_city_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_ID_Activeeventkey", StringUtil.RTrim( Ddo_br_demographics_id_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Activeeventkey", StringUtil.RTrim( Ddo_br_encounterid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Activeeventkey", StringUtil.RTrim( Ddo_br_information_patientno_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_BIRTHDATE_Activeeventkey", StringUtil.RTrim( Ddo_br_demographics_birthdate_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_SEX_Activeeventkey", StringUtil.RTrim( Ddo_br_demographics_sex_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_MARRITALSTATUS_Activeeventkey", StringUtil.RTrim( Ddo_br_demographics_marritalstatus_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_ETHNIC_Activeeventkey", StringUtil.RTrim( Ddo_br_demographics_ethnic_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_EDUCATION_Activeeventkey", StringUtil.RTrim( Ddo_br_demographics_education_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_OCCUPATION_Activeeventkey", StringUtil.RTrim( Ddo_br_demographics_occupation_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_INSURANCE_Activeeventkey", StringUtil.RTrim( Ddo_br_demographics_insurance_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_PROVINCE_Activeeventkey", StringUtil.RTrim( Ddo_br_demographics_province_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_DEMOGRAPHICS_CITY_Activeeventkey", StringUtil.RTrim( Ddo_br_demographics_city_Activeeventkey));
      }

      protected void RenderHtmlCloseForm2M2( )
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
         return "BR_DemographicsPrompt" ;
      }

      public override String GetPgmdesc( )
      {
         return "选择人口信息学" ;
      }

      protected void WB2M0( )
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
               if ( edtBR_Demographics_ID_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Demographics_ID_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Demographics_ID_Title) ;
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
               if ( edtBR_Demographics_BirthDate_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Demographics_BirthDate_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Demographics_BirthDate_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Demographics_Sex_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Demographics_Sex_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Demographics_Sex_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Demographics_MarritalStatus_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Demographics_MarritalStatus_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Demographics_MarritalStatus_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Demographics_Ethnic_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Demographics_Ethnic_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Demographics_Ethnic_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Demographics_Education_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Demographics_Education_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Demographics_Education_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Demographics_Occupation_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Demographics_Occupation_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Demographics_Occupation_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Demographics_Insurance_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Demographics_Insurance_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Demographics_Insurance_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Demographics_Province_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Demographics_Province_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Demographics_Province_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Demographics_City_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Demographics_City_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Demographics_City_Title) ;
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
               GridColumn.AddObjectProperty("Value", context.convertURL( AV45Select));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavSelect_Tooltiptext));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A61BR_Demographics_ID), 18, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Demographics_ID_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Demographics_ID_Titleformat), 4, 0, ".", "")));
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
               GridColumn.AddObjectProperty("Value", context.localUtil.Format(A53BR_Demographics_BirthDate, "9999/99/99"));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Demographics_BirthDate_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Demographics_BirthDate_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A54BR_Demographics_Sex);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Demographics_Sex_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Demographics_Sex_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A63BR_Demographics_MarritalStatus);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Demographics_MarritalStatus_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Demographics_MarritalStatus_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A55BR_Demographics_Ethnic);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Demographics_Ethnic_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Demographics_Ethnic_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A56BR_Demographics_Education);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Demographics_Education_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Demographics_Education_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A57BR_Demographics_Occupation);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Demographics_Occupation_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Demographics_Occupation_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A58BR_Demographics_Insurance);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Demographics_Insurance_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Demographics_Insurance_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A59BR_Demographics_Province);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Demographics_Province_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Demographics_Province_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A60BR_Demographics_City);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Demographics_City_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Demographics_City_Titleformat), 4, 0, ".", "")));
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
            ucGridpaginationbar.SetProperty("CurrentPage", AV42GridCurrentPage);
            ucGridpaginationbar.SetProperty("RecordCount", AV44GridRecordCount);
            ucGridpaginationbar.SetProperty("Page", AV43GridPageSize);
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
            ucDdo_br_demographics_id.SetProperty("Caption", Ddo_br_demographics_id_Caption);
            ucDdo_br_demographics_id.SetProperty("Tooltip", Ddo_br_demographics_id_Tooltip);
            ucDdo_br_demographics_id.SetProperty("Cls", Ddo_br_demographics_id_Cls);
            ucDdo_br_demographics_id.SetProperty("DropDownOptionsType", Ddo_br_demographics_id_Dropdownoptionstype);
            ucDdo_br_demographics_id.SetProperty("IncludeSortASC", Ddo_br_demographics_id_Includesortasc);
            ucDdo_br_demographics_id.SetProperty("IncludeSortDSC", Ddo_br_demographics_id_Includesortdsc);
            ucDdo_br_demographics_id.SetProperty("IncludeFilter", Ddo_br_demographics_id_Includefilter);
            ucDdo_br_demographics_id.SetProperty("IncludeDataList", Ddo_br_demographics_id_Includedatalist);
            ucDdo_br_demographics_id.SetProperty("SortASC", Ddo_br_demographics_id_Sortasc);
            ucDdo_br_demographics_id.SetProperty("SortDSC", Ddo_br_demographics_id_Sortdsc);
            ucDdo_br_demographics_id.SetProperty("SearchButtonText", Ddo_br_demographics_id_Searchbuttontext);
            ucDdo_br_demographics_id.SetProperty("DropDownOptionsTitleSettingsIcons", AV40DDO_TitleSettingsIcons);
            ucDdo_br_demographics_id.SetProperty("DropDownOptionsData", AV12BR_Demographics_IDTitleFilterData);
            ucDdo_br_demographics_id.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_demographics_id_Internalname, "DDO_BR_DEMOGRAPHICS_IDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_demographics_idtitlecontrolidtoreplace_Internalname, AV13ddo_BR_Demographics_IDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,34);\"", 0, edtavDdo_br_demographics_idtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_DemographicsPrompt.htm");
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
            ucDdo_br_encounterid.SetProperty("DropDownOptionsTitleSettingsIcons", AV40DDO_TitleSettingsIcons);
            ucDdo_br_encounterid.SetProperty("DropDownOptionsData", AV14BR_EncounterIDTitleFilterData);
            ucDdo_br_encounterid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_encounterid_Internalname, "DDO_BR_ENCOUNTERIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 36,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_encounteridtitlecontrolidtoreplace_Internalname, AV15ddo_BR_EncounterIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,36);\"", 0, edtavDdo_br_encounteridtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_DemographicsPrompt.htm");
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
            ucDdo_br_information_patientno.SetProperty("DropDownOptionsTitleSettingsIcons", AV40DDO_TitleSettingsIcons);
            ucDdo_br_information_patientno.SetProperty("DropDownOptionsData", AV18BR_Information_PatientNoTitleFilterData);
            ucDdo_br_information_patientno.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_information_patientno_Internalname, "DDO_BR_INFORMATION_PATIENTNOContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_information_patientnotitlecontrolidtoreplace_Internalname, AV19ddo_BR_Information_PatientNoTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,38);\"", 0, edtavDdo_br_information_patientnotitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_DemographicsPrompt.htm");
            /* User Defined Control */
            ucDdo_br_demographics_birthdate.SetProperty("Caption", Ddo_br_demographics_birthdate_Caption);
            ucDdo_br_demographics_birthdate.SetProperty("Tooltip", Ddo_br_demographics_birthdate_Tooltip);
            ucDdo_br_demographics_birthdate.SetProperty("Cls", Ddo_br_demographics_birthdate_Cls);
            ucDdo_br_demographics_birthdate.SetProperty("DropDownOptionsType", Ddo_br_demographics_birthdate_Dropdownoptionstype);
            ucDdo_br_demographics_birthdate.SetProperty("IncludeSortASC", Ddo_br_demographics_birthdate_Includesortasc);
            ucDdo_br_demographics_birthdate.SetProperty("IncludeSortDSC", Ddo_br_demographics_birthdate_Includesortdsc);
            ucDdo_br_demographics_birthdate.SetProperty("IncludeFilter", Ddo_br_demographics_birthdate_Includefilter);
            ucDdo_br_demographics_birthdate.SetProperty("IncludeDataList", Ddo_br_demographics_birthdate_Includedatalist);
            ucDdo_br_demographics_birthdate.SetProperty("SortASC", Ddo_br_demographics_birthdate_Sortasc);
            ucDdo_br_demographics_birthdate.SetProperty("SortDSC", Ddo_br_demographics_birthdate_Sortdsc);
            ucDdo_br_demographics_birthdate.SetProperty("SearchButtonText", Ddo_br_demographics_birthdate_Searchbuttontext);
            ucDdo_br_demographics_birthdate.SetProperty("DropDownOptionsTitleSettingsIcons", AV40DDO_TitleSettingsIcons);
            ucDdo_br_demographics_birthdate.SetProperty("DropDownOptionsData", AV20BR_Demographics_BirthDateTitleFilterData);
            ucDdo_br_demographics_birthdate.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_demographics_birthdate_Internalname, "DDO_BR_DEMOGRAPHICS_BIRTHDATEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 40,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_demographics_birthdatetitlecontrolidtoreplace_Internalname, AV21ddo_BR_Demographics_BirthDateTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,40);\"", 0, edtavDdo_br_demographics_birthdatetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_DemographicsPrompt.htm");
            /* User Defined Control */
            ucDdo_br_demographics_sex.SetProperty("Caption", Ddo_br_demographics_sex_Caption);
            ucDdo_br_demographics_sex.SetProperty("Tooltip", Ddo_br_demographics_sex_Tooltip);
            ucDdo_br_demographics_sex.SetProperty("Cls", Ddo_br_demographics_sex_Cls);
            ucDdo_br_demographics_sex.SetProperty("DropDownOptionsType", Ddo_br_demographics_sex_Dropdownoptionstype);
            ucDdo_br_demographics_sex.SetProperty("IncludeSortASC", Ddo_br_demographics_sex_Includesortasc);
            ucDdo_br_demographics_sex.SetProperty("IncludeSortDSC", Ddo_br_demographics_sex_Includesortdsc);
            ucDdo_br_demographics_sex.SetProperty("IncludeFilter", Ddo_br_demographics_sex_Includefilter);
            ucDdo_br_demographics_sex.SetProperty("IncludeDataList", Ddo_br_demographics_sex_Includedatalist);
            ucDdo_br_demographics_sex.SetProperty("SortASC", Ddo_br_demographics_sex_Sortasc);
            ucDdo_br_demographics_sex.SetProperty("SortDSC", Ddo_br_demographics_sex_Sortdsc);
            ucDdo_br_demographics_sex.SetProperty("SearchButtonText", Ddo_br_demographics_sex_Searchbuttontext);
            ucDdo_br_demographics_sex.SetProperty("DropDownOptionsTitleSettingsIcons", AV40DDO_TitleSettingsIcons);
            ucDdo_br_demographics_sex.SetProperty("DropDownOptionsData", AV24BR_Demographics_SexTitleFilterData);
            ucDdo_br_demographics_sex.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_demographics_sex_Internalname, "DDO_BR_DEMOGRAPHICS_SEXContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 42,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_demographics_sextitlecontrolidtoreplace_Internalname, AV25ddo_BR_Demographics_SexTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,42);\"", 0, edtavDdo_br_demographics_sextitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_DemographicsPrompt.htm");
            /* User Defined Control */
            ucDdo_br_demographics_marritalstatus.SetProperty("Caption", Ddo_br_demographics_marritalstatus_Caption);
            ucDdo_br_demographics_marritalstatus.SetProperty("Tooltip", Ddo_br_demographics_marritalstatus_Tooltip);
            ucDdo_br_demographics_marritalstatus.SetProperty("Cls", Ddo_br_demographics_marritalstatus_Cls);
            ucDdo_br_demographics_marritalstatus.SetProperty("DropDownOptionsType", Ddo_br_demographics_marritalstatus_Dropdownoptionstype);
            ucDdo_br_demographics_marritalstatus.SetProperty("IncludeSortASC", Ddo_br_demographics_marritalstatus_Includesortasc);
            ucDdo_br_demographics_marritalstatus.SetProperty("IncludeSortDSC", Ddo_br_demographics_marritalstatus_Includesortdsc);
            ucDdo_br_demographics_marritalstatus.SetProperty("IncludeFilter", Ddo_br_demographics_marritalstatus_Includefilter);
            ucDdo_br_demographics_marritalstatus.SetProperty("IncludeDataList", Ddo_br_demographics_marritalstatus_Includedatalist);
            ucDdo_br_demographics_marritalstatus.SetProperty("SortASC", Ddo_br_demographics_marritalstatus_Sortasc);
            ucDdo_br_demographics_marritalstatus.SetProperty("SortDSC", Ddo_br_demographics_marritalstatus_Sortdsc);
            ucDdo_br_demographics_marritalstatus.SetProperty("SearchButtonText", Ddo_br_demographics_marritalstatus_Searchbuttontext);
            ucDdo_br_demographics_marritalstatus.SetProperty("DropDownOptionsTitleSettingsIcons", AV40DDO_TitleSettingsIcons);
            ucDdo_br_demographics_marritalstatus.SetProperty("DropDownOptionsData", AV26BR_Demographics_MarritalStatusTitleFilterData);
            ucDdo_br_demographics_marritalstatus.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_demographics_marritalstatus_Internalname, "DDO_BR_DEMOGRAPHICS_MARRITALSTATUSContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_demographics_marritalstatustitlecontrolidtoreplace_Internalname, AV27ddo_BR_Demographics_MarritalStatusTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,44);\"", 0, edtavDdo_br_demographics_marritalstatustitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_DemographicsPrompt.htm");
            /* User Defined Control */
            ucDdo_br_demographics_ethnic.SetProperty("Caption", Ddo_br_demographics_ethnic_Caption);
            ucDdo_br_demographics_ethnic.SetProperty("Tooltip", Ddo_br_demographics_ethnic_Tooltip);
            ucDdo_br_demographics_ethnic.SetProperty("Cls", Ddo_br_demographics_ethnic_Cls);
            ucDdo_br_demographics_ethnic.SetProperty("DropDownOptionsType", Ddo_br_demographics_ethnic_Dropdownoptionstype);
            ucDdo_br_demographics_ethnic.SetProperty("IncludeSortASC", Ddo_br_demographics_ethnic_Includesortasc);
            ucDdo_br_demographics_ethnic.SetProperty("IncludeSortDSC", Ddo_br_demographics_ethnic_Includesortdsc);
            ucDdo_br_demographics_ethnic.SetProperty("IncludeFilter", Ddo_br_demographics_ethnic_Includefilter);
            ucDdo_br_demographics_ethnic.SetProperty("IncludeDataList", Ddo_br_demographics_ethnic_Includedatalist);
            ucDdo_br_demographics_ethnic.SetProperty("SortASC", Ddo_br_demographics_ethnic_Sortasc);
            ucDdo_br_demographics_ethnic.SetProperty("SortDSC", Ddo_br_demographics_ethnic_Sortdsc);
            ucDdo_br_demographics_ethnic.SetProperty("SearchButtonText", Ddo_br_demographics_ethnic_Searchbuttontext);
            ucDdo_br_demographics_ethnic.SetProperty("DropDownOptionsTitleSettingsIcons", AV40DDO_TitleSettingsIcons);
            ucDdo_br_demographics_ethnic.SetProperty("DropDownOptionsData", AV28BR_Demographics_EthnicTitleFilterData);
            ucDdo_br_demographics_ethnic.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_demographics_ethnic_Internalname, "DDO_BR_DEMOGRAPHICS_ETHNICContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 46,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_demographics_ethnictitlecontrolidtoreplace_Internalname, AV29ddo_BR_Demographics_EthnicTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,46);\"", 0, edtavDdo_br_demographics_ethnictitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_DemographicsPrompt.htm");
            /* User Defined Control */
            ucDdo_br_demographics_education.SetProperty("Caption", Ddo_br_demographics_education_Caption);
            ucDdo_br_demographics_education.SetProperty("Tooltip", Ddo_br_demographics_education_Tooltip);
            ucDdo_br_demographics_education.SetProperty("Cls", Ddo_br_demographics_education_Cls);
            ucDdo_br_demographics_education.SetProperty("DropDownOptionsType", Ddo_br_demographics_education_Dropdownoptionstype);
            ucDdo_br_demographics_education.SetProperty("IncludeSortASC", Ddo_br_demographics_education_Includesortasc);
            ucDdo_br_demographics_education.SetProperty("IncludeSortDSC", Ddo_br_demographics_education_Includesortdsc);
            ucDdo_br_demographics_education.SetProperty("IncludeFilter", Ddo_br_demographics_education_Includefilter);
            ucDdo_br_demographics_education.SetProperty("IncludeDataList", Ddo_br_demographics_education_Includedatalist);
            ucDdo_br_demographics_education.SetProperty("SortASC", Ddo_br_demographics_education_Sortasc);
            ucDdo_br_demographics_education.SetProperty("SortDSC", Ddo_br_demographics_education_Sortdsc);
            ucDdo_br_demographics_education.SetProperty("SearchButtonText", Ddo_br_demographics_education_Searchbuttontext);
            ucDdo_br_demographics_education.SetProperty("DropDownOptionsTitleSettingsIcons", AV40DDO_TitleSettingsIcons);
            ucDdo_br_demographics_education.SetProperty("DropDownOptionsData", AV30BR_Demographics_EducationTitleFilterData);
            ucDdo_br_demographics_education.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_demographics_education_Internalname, "DDO_BR_DEMOGRAPHICS_EDUCATIONContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_demographics_educationtitlecontrolidtoreplace_Internalname, AV31ddo_BR_Demographics_EducationTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,48);\"", 0, edtavDdo_br_demographics_educationtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_DemographicsPrompt.htm");
            /* User Defined Control */
            ucDdo_br_demographics_occupation.SetProperty("Caption", Ddo_br_demographics_occupation_Caption);
            ucDdo_br_demographics_occupation.SetProperty("Tooltip", Ddo_br_demographics_occupation_Tooltip);
            ucDdo_br_demographics_occupation.SetProperty("Cls", Ddo_br_demographics_occupation_Cls);
            ucDdo_br_demographics_occupation.SetProperty("DropDownOptionsType", Ddo_br_demographics_occupation_Dropdownoptionstype);
            ucDdo_br_demographics_occupation.SetProperty("IncludeSortASC", Ddo_br_demographics_occupation_Includesortasc);
            ucDdo_br_demographics_occupation.SetProperty("IncludeSortDSC", Ddo_br_demographics_occupation_Includesortdsc);
            ucDdo_br_demographics_occupation.SetProperty("IncludeFilter", Ddo_br_demographics_occupation_Includefilter);
            ucDdo_br_demographics_occupation.SetProperty("IncludeDataList", Ddo_br_demographics_occupation_Includedatalist);
            ucDdo_br_demographics_occupation.SetProperty("SortASC", Ddo_br_demographics_occupation_Sortasc);
            ucDdo_br_demographics_occupation.SetProperty("SortDSC", Ddo_br_demographics_occupation_Sortdsc);
            ucDdo_br_demographics_occupation.SetProperty("SearchButtonText", Ddo_br_demographics_occupation_Searchbuttontext);
            ucDdo_br_demographics_occupation.SetProperty("DropDownOptionsTitleSettingsIcons", AV40DDO_TitleSettingsIcons);
            ucDdo_br_demographics_occupation.SetProperty("DropDownOptionsData", AV32BR_Demographics_OccupationTitleFilterData);
            ucDdo_br_demographics_occupation.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_demographics_occupation_Internalname, "DDO_BR_DEMOGRAPHICS_OCCUPATIONContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 50,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_demographics_occupationtitlecontrolidtoreplace_Internalname, AV33ddo_BR_Demographics_OccupationTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,50);\"", 0, edtavDdo_br_demographics_occupationtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_DemographicsPrompt.htm");
            /* User Defined Control */
            ucDdo_br_demographics_insurance.SetProperty("Caption", Ddo_br_demographics_insurance_Caption);
            ucDdo_br_demographics_insurance.SetProperty("Tooltip", Ddo_br_demographics_insurance_Tooltip);
            ucDdo_br_demographics_insurance.SetProperty("Cls", Ddo_br_demographics_insurance_Cls);
            ucDdo_br_demographics_insurance.SetProperty("DropDownOptionsType", Ddo_br_demographics_insurance_Dropdownoptionstype);
            ucDdo_br_demographics_insurance.SetProperty("IncludeSortASC", Ddo_br_demographics_insurance_Includesortasc);
            ucDdo_br_demographics_insurance.SetProperty("IncludeSortDSC", Ddo_br_demographics_insurance_Includesortdsc);
            ucDdo_br_demographics_insurance.SetProperty("IncludeFilter", Ddo_br_demographics_insurance_Includefilter);
            ucDdo_br_demographics_insurance.SetProperty("IncludeDataList", Ddo_br_demographics_insurance_Includedatalist);
            ucDdo_br_demographics_insurance.SetProperty("SortASC", Ddo_br_demographics_insurance_Sortasc);
            ucDdo_br_demographics_insurance.SetProperty("SortDSC", Ddo_br_demographics_insurance_Sortdsc);
            ucDdo_br_demographics_insurance.SetProperty("SearchButtonText", Ddo_br_demographics_insurance_Searchbuttontext);
            ucDdo_br_demographics_insurance.SetProperty("DropDownOptionsTitleSettingsIcons", AV40DDO_TitleSettingsIcons);
            ucDdo_br_demographics_insurance.SetProperty("DropDownOptionsData", AV34BR_Demographics_InsuranceTitleFilterData);
            ucDdo_br_demographics_insurance.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_demographics_insurance_Internalname, "DDO_BR_DEMOGRAPHICS_INSURANCEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 52,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_demographics_insurancetitlecontrolidtoreplace_Internalname, AV35ddo_BR_Demographics_InsuranceTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,52);\"", 0, edtavDdo_br_demographics_insurancetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_DemographicsPrompt.htm");
            /* User Defined Control */
            ucDdo_br_demographics_province.SetProperty("Caption", Ddo_br_demographics_province_Caption);
            ucDdo_br_demographics_province.SetProperty("Tooltip", Ddo_br_demographics_province_Tooltip);
            ucDdo_br_demographics_province.SetProperty("Cls", Ddo_br_demographics_province_Cls);
            ucDdo_br_demographics_province.SetProperty("DropDownOptionsType", Ddo_br_demographics_province_Dropdownoptionstype);
            ucDdo_br_demographics_province.SetProperty("IncludeSortASC", Ddo_br_demographics_province_Includesortasc);
            ucDdo_br_demographics_province.SetProperty("IncludeSortDSC", Ddo_br_demographics_province_Includesortdsc);
            ucDdo_br_demographics_province.SetProperty("IncludeFilter", Ddo_br_demographics_province_Includefilter);
            ucDdo_br_demographics_province.SetProperty("IncludeDataList", Ddo_br_demographics_province_Includedatalist);
            ucDdo_br_demographics_province.SetProperty("SortASC", Ddo_br_demographics_province_Sortasc);
            ucDdo_br_demographics_province.SetProperty("SortDSC", Ddo_br_demographics_province_Sortdsc);
            ucDdo_br_demographics_province.SetProperty("SearchButtonText", Ddo_br_demographics_province_Searchbuttontext);
            ucDdo_br_demographics_province.SetProperty("DropDownOptionsTitleSettingsIcons", AV40DDO_TitleSettingsIcons);
            ucDdo_br_demographics_province.SetProperty("DropDownOptionsData", AV36BR_Demographics_ProvinceTitleFilterData);
            ucDdo_br_demographics_province.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_demographics_province_Internalname, "DDO_BR_DEMOGRAPHICS_PROVINCEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_demographics_provincetitlecontrolidtoreplace_Internalname, AV37ddo_BR_Demographics_ProvinceTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,54);\"", 0, edtavDdo_br_demographics_provincetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_DemographicsPrompt.htm");
            /* User Defined Control */
            ucDdo_br_demographics_city.SetProperty("Caption", Ddo_br_demographics_city_Caption);
            ucDdo_br_demographics_city.SetProperty("Tooltip", Ddo_br_demographics_city_Tooltip);
            ucDdo_br_demographics_city.SetProperty("Cls", Ddo_br_demographics_city_Cls);
            ucDdo_br_demographics_city.SetProperty("DropDownOptionsType", Ddo_br_demographics_city_Dropdownoptionstype);
            ucDdo_br_demographics_city.SetProperty("IncludeSortASC", Ddo_br_demographics_city_Includesortasc);
            ucDdo_br_demographics_city.SetProperty("IncludeSortDSC", Ddo_br_demographics_city_Includesortdsc);
            ucDdo_br_demographics_city.SetProperty("IncludeFilter", Ddo_br_demographics_city_Includefilter);
            ucDdo_br_demographics_city.SetProperty("IncludeDataList", Ddo_br_demographics_city_Includedatalist);
            ucDdo_br_demographics_city.SetProperty("SortASC", Ddo_br_demographics_city_Sortasc);
            ucDdo_br_demographics_city.SetProperty("SortDSC", Ddo_br_demographics_city_Sortdsc);
            ucDdo_br_demographics_city.SetProperty("SearchButtonText", Ddo_br_demographics_city_Searchbuttontext);
            ucDdo_br_demographics_city.SetProperty("DropDownOptionsTitleSettingsIcons", AV40DDO_TitleSettingsIcons);
            ucDdo_br_demographics_city.SetProperty("DropDownOptionsData", AV38BR_Demographics_CityTitleFilterData);
            ucDdo_br_demographics_city.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_demographics_city_Internalname, "DDO_BR_DEMOGRAPHICS_CITYContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 56,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_demographics_citytitlecontrolidtoreplace_Internalname, AV39ddo_BR_Demographics_CityTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,56);\"", 0, edtavDdo_br_demographics_citytitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_DemographicsPrompt.htm");
            /* User Defined Control */
            ucWorkwithplusutilities1.Render(context, "dvelop.workwithplusutilities", Workwithplusutilities1_Internalname, "WORKWITHPLUSUTILITIES1Container");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'" + sGXsfl_12_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrderedby_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10OrderedBy), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV10OrderedBy), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,58);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrderedby_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrderedby_Visible, 1, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_DemographicsPrompt.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 59,'',false,'" + sGXsfl_12_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrdereddsc_Internalname, StringUtil.BoolToStr( AV11OrderedDsc), StringUtil.BoolToStr( AV11OrderedDsc), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,59);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrdereddsc_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrdereddsc_Visible, 1, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, 0, 0, true, "", "right", false, "HLP_BR_DemographicsPrompt.htm");
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

      protected void START2M2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_0-127771", 0) ;
            Form.Meta.addItem("description", "选择人口信息学", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP2M0( ) ;
      }

      protected void WS2M2( )
      {
         START2M2( ) ;
         EVT2M2( ) ;
      }

      protected void EVT2M2( )
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
                           E112M2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEROWSPERPAGE") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E122M2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_DEMOGRAPHICS_ID.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E132M2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_ENCOUNTERID.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E142M2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_INFORMATION_PATIENTNO.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E152M2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_DEMOGRAPHICS_BIRTHDATE.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E162M2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_DEMOGRAPHICS_SEX.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E172M2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_DEMOGRAPHICS_MARRITALSTATUS.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E182M2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_DEMOGRAPHICS_ETHNIC.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E192M2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_DEMOGRAPHICS_EDUCATION.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E202M2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_DEMOGRAPHICS_OCCUPATION.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E212M2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_DEMOGRAPHICS_INSURANCE.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E222M2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_DEMOGRAPHICS_PROVINCE.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E232M2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_DEMOGRAPHICS_CITY.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E242M2 ();
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
                           AV45Select = cgiGet( edtavSelect_Internalname);
                           context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSelect_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV45Select)) ? AV49Select_GXI : context.convertURL( context.PathToRelativeUrl( AV45Select))), !bGXsfl_12_Refreshing);
                           context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSelect_Internalname, "SrcSet", context.GetImageSrcSet( AV45Select), true);
                           A61BR_Demographics_ID = (long)(context.localUtil.CToN( cgiGet( edtBR_Demographics_ID_Internalname), ".", ","));
                           A19BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( edtBR_EncounterID_Internalname), ".", ","));
                           A36BR_Information_PatientNo = cgiGet( edtBR_Information_PatientNo_Internalname);
                           n36BR_Information_PatientNo = false;
                           A53BR_Demographics_BirthDate = DateTimeUtil.ResetTime(context.localUtil.CToT( cgiGet( edtBR_Demographics_BirthDate_Internalname), 0));
                           n53BR_Demographics_BirthDate = false;
                           A54BR_Demographics_Sex = cgiGet( edtBR_Demographics_Sex_Internalname);
                           n54BR_Demographics_Sex = false;
                           A63BR_Demographics_MarritalStatus = cgiGet( edtBR_Demographics_MarritalStatus_Internalname);
                           n63BR_Demographics_MarritalStatus = false;
                           A55BR_Demographics_Ethnic = cgiGet( edtBR_Demographics_Ethnic_Internalname);
                           n55BR_Demographics_Ethnic = false;
                           A56BR_Demographics_Education = cgiGet( edtBR_Demographics_Education_Internalname);
                           n56BR_Demographics_Education = false;
                           A57BR_Demographics_Occupation = cgiGet( edtBR_Demographics_Occupation_Internalname);
                           n57BR_Demographics_Occupation = false;
                           A58BR_Demographics_Insurance = cgiGet( edtBR_Demographics_Insurance_Internalname);
                           n58BR_Demographics_Insurance = false;
                           A59BR_Demographics_Province = cgiGet( edtBR_Demographics_Province_Internalname);
                           n59BR_Demographics_Province = false;
                           A60BR_Demographics_City = cgiGet( edtBR_Demographics_City_Internalname);
                           n60BR_Demographics_City = false;
                           sEvtType = StringUtil.Right( sEvt, 1);
                           if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                           {
                              sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                              if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 /* Execute user event: Start */
                                 E252M2 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 /* Execute user event: Refresh */
                                 E262M2 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "GRID.LOAD") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 E272M2 ();
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
                                       E282M2 ();
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

      protected void WE2M2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm2M2( ) ;
            }
         }
      }

      protected void PA2M2( )
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
               GX_FocusControl = edtavDdo_br_demographics_idtitlecontrolidtoreplace_Internalname;
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
                                       String AV13ddo_BR_Demographics_IDTitleControlIdToReplace ,
                                       String AV15ddo_BR_EncounterIDTitleControlIdToReplace ,
                                       String AV19ddo_BR_Information_PatientNoTitleControlIdToReplace ,
                                       String AV21ddo_BR_Demographics_BirthDateTitleControlIdToReplace ,
                                       String AV25ddo_BR_Demographics_SexTitleControlIdToReplace ,
                                       String AV27ddo_BR_Demographics_MarritalStatusTitleControlIdToReplace ,
                                       String AV29ddo_BR_Demographics_EthnicTitleControlIdToReplace ,
                                       String AV31ddo_BR_Demographics_EducationTitleControlIdToReplace ,
                                       String AV33ddo_BR_Demographics_OccupationTitleControlIdToReplace ,
                                       String AV35ddo_BR_Demographics_InsuranceTitleControlIdToReplace ,
                                       String AV37ddo_BR_Demographics_ProvinceTitleControlIdToReplace ,
                                       String AV39ddo_BR_Demographics_CityTitleControlIdToReplace )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GRID_nCurrentRecord = 0;
         RF2M2( ) ;
         /* End function gxgrGrid_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_BR_DEMOGRAPHICS_ID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A61BR_Demographics_ID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, "BR_DEMOGRAPHICS_ID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A61BR_Demographics_ID), 18, 0, ".", "")));
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
         RF2M2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV48Pgmname = "BR_DemographicsPrompt";
         context.Gx_err = 0;
      }

      protected void RF2M2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridContainer.ClearRows();
         }
         wbStart = 12;
         /* Execute user event: Refresh */
         E262M2 ();
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
            /* Using cursor H002M2 */
            pr_default.execute(0, new Object[] {GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_12_idx = 1;
            sGXsfl_12_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_12_idx), 4, 0)), 4, "0");
            SubsflControlProps_122( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < subGrid_Recordsperpage( ) ) ) ) )
            {
               A85BR_Information_ID = H002M2_A85BR_Information_ID[0];
               n85BR_Information_ID = H002M2_n85BR_Information_ID[0];
               A60BR_Demographics_City = H002M2_A60BR_Demographics_City[0];
               n60BR_Demographics_City = H002M2_n60BR_Demographics_City[0];
               A59BR_Demographics_Province = H002M2_A59BR_Demographics_Province[0];
               n59BR_Demographics_Province = H002M2_n59BR_Demographics_Province[0];
               A58BR_Demographics_Insurance = H002M2_A58BR_Demographics_Insurance[0];
               n58BR_Demographics_Insurance = H002M2_n58BR_Demographics_Insurance[0];
               A57BR_Demographics_Occupation = H002M2_A57BR_Demographics_Occupation[0];
               n57BR_Demographics_Occupation = H002M2_n57BR_Demographics_Occupation[0];
               A56BR_Demographics_Education = H002M2_A56BR_Demographics_Education[0];
               n56BR_Demographics_Education = H002M2_n56BR_Demographics_Education[0];
               A55BR_Demographics_Ethnic = H002M2_A55BR_Demographics_Ethnic[0];
               n55BR_Demographics_Ethnic = H002M2_n55BR_Demographics_Ethnic[0];
               A63BR_Demographics_MarritalStatus = H002M2_A63BR_Demographics_MarritalStatus[0];
               n63BR_Demographics_MarritalStatus = H002M2_n63BR_Demographics_MarritalStatus[0];
               A54BR_Demographics_Sex = H002M2_A54BR_Demographics_Sex[0];
               n54BR_Demographics_Sex = H002M2_n54BR_Demographics_Sex[0];
               A53BR_Demographics_BirthDate = H002M2_A53BR_Demographics_BirthDate[0];
               n53BR_Demographics_BirthDate = H002M2_n53BR_Demographics_BirthDate[0];
               A36BR_Information_PatientNo = H002M2_A36BR_Information_PatientNo[0];
               n36BR_Information_PatientNo = H002M2_n36BR_Information_PatientNo[0];
               A19BR_EncounterID = H002M2_A19BR_EncounterID[0];
               A61BR_Demographics_ID = H002M2_A61BR_Demographics_ID[0];
               A85BR_Information_ID = H002M2_A85BR_Information_ID[0];
               n85BR_Information_ID = H002M2_n85BR_Information_ID[0];
               A36BR_Information_PatientNo = H002M2_A36BR_Information_PatientNo[0];
               n36BR_Information_PatientNo = H002M2_n36BR_Information_PatientNo[0];
               E272M2 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 12;
            WB2M0( ) ;
         }
         bGXsfl_12_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes2M2( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_BR_DEMOGRAPHICS_ID"+"_"+sGXsfl_12_idx, GetSecureSignedToken( sGXsfl_12_idx, context.localUtil.Format( (decimal)(A61BR_Demographics_ID), "ZZZZZZZZZZZZZZZZZZ"), context));
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
         /* Using cursor H002M3 */
         pr_default.execute(1);
         GRID_nRecordCount = H002M3_AGRID_nRecordCount[0];
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
            gxgrGrid_refresh( subGrid_Rows, AV10OrderedBy, AV11OrderedDsc, AV13ddo_BR_Demographics_IDTitleControlIdToReplace, AV15ddo_BR_EncounterIDTitleControlIdToReplace, AV19ddo_BR_Information_PatientNoTitleControlIdToReplace, AV21ddo_BR_Demographics_BirthDateTitleControlIdToReplace, AV25ddo_BR_Demographics_SexTitleControlIdToReplace, AV27ddo_BR_Demographics_MarritalStatusTitleControlIdToReplace, AV29ddo_BR_Demographics_EthnicTitleControlIdToReplace, AV31ddo_BR_Demographics_EducationTitleControlIdToReplace, AV33ddo_BR_Demographics_OccupationTitleControlIdToReplace, AV35ddo_BR_Demographics_InsuranceTitleControlIdToReplace, AV37ddo_BR_Demographics_ProvinceTitleControlIdToReplace, AV39ddo_BR_Demographics_CityTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV10OrderedBy, AV11OrderedDsc, AV13ddo_BR_Demographics_IDTitleControlIdToReplace, AV15ddo_BR_EncounterIDTitleControlIdToReplace, AV19ddo_BR_Information_PatientNoTitleControlIdToReplace, AV21ddo_BR_Demographics_BirthDateTitleControlIdToReplace, AV25ddo_BR_Demographics_SexTitleControlIdToReplace, AV27ddo_BR_Demographics_MarritalStatusTitleControlIdToReplace, AV29ddo_BR_Demographics_EthnicTitleControlIdToReplace, AV31ddo_BR_Demographics_EducationTitleControlIdToReplace, AV33ddo_BR_Demographics_OccupationTitleControlIdToReplace, AV35ddo_BR_Demographics_InsuranceTitleControlIdToReplace, AV37ddo_BR_Demographics_ProvinceTitleControlIdToReplace, AV39ddo_BR_Demographics_CityTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV10OrderedBy, AV11OrderedDsc, AV13ddo_BR_Demographics_IDTitleControlIdToReplace, AV15ddo_BR_EncounterIDTitleControlIdToReplace, AV19ddo_BR_Information_PatientNoTitleControlIdToReplace, AV21ddo_BR_Demographics_BirthDateTitleControlIdToReplace, AV25ddo_BR_Demographics_SexTitleControlIdToReplace, AV27ddo_BR_Demographics_MarritalStatusTitleControlIdToReplace, AV29ddo_BR_Demographics_EthnicTitleControlIdToReplace, AV31ddo_BR_Demographics_EducationTitleControlIdToReplace, AV33ddo_BR_Demographics_OccupationTitleControlIdToReplace, AV35ddo_BR_Demographics_InsuranceTitleControlIdToReplace, AV37ddo_BR_Demographics_ProvinceTitleControlIdToReplace, AV39ddo_BR_Demographics_CityTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV10OrderedBy, AV11OrderedDsc, AV13ddo_BR_Demographics_IDTitleControlIdToReplace, AV15ddo_BR_EncounterIDTitleControlIdToReplace, AV19ddo_BR_Information_PatientNoTitleControlIdToReplace, AV21ddo_BR_Demographics_BirthDateTitleControlIdToReplace, AV25ddo_BR_Demographics_SexTitleControlIdToReplace, AV27ddo_BR_Demographics_MarritalStatusTitleControlIdToReplace, AV29ddo_BR_Demographics_EthnicTitleControlIdToReplace, AV31ddo_BR_Demographics_EducationTitleControlIdToReplace, AV33ddo_BR_Demographics_OccupationTitleControlIdToReplace, AV35ddo_BR_Demographics_InsuranceTitleControlIdToReplace, AV37ddo_BR_Demographics_ProvinceTitleControlIdToReplace, AV39ddo_BR_Demographics_CityTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV10OrderedBy, AV11OrderedDsc, AV13ddo_BR_Demographics_IDTitleControlIdToReplace, AV15ddo_BR_EncounterIDTitleControlIdToReplace, AV19ddo_BR_Information_PatientNoTitleControlIdToReplace, AV21ddo_BR_Demographics_BirthDateTitleControlIdToReplace, AV25ddo_BR_Demographics_SexTitleControlIdToReplace, AV27ddo_BR_Demographics_MarritalStatusTitleControlIdToReplace, AV29ddo_BR_Demographics_EthnicTitleControlIdToReplace, AV31ddo_BR_Demographics_EducationTitleControlIdToReplace, AV33ddo_BR_Demographics_OccupationTitleControlIdToReplace, AV35ddo_BR_Demographics_InsuranceTitleControlIdToReplace, AV37ddo_BR_Demographics_ProvinceTitleControlIdToReplace, AV39ddo_BR_Demographics_CityTitleControlIdToReplace) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP2M0( )
      {
         /* Before Start, stand alone formulas. */
         AV48Pgmname = "BR_DemographicsPrompt";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E252M2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( "vDDO_TITLESETTINGSICONS"), AV40DDO_TitleSettingsIcons);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_DEMOGRAPHICS_IDTITLEFILTERDATA"), AV12BR_Demographics_IDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_ENCOUNTERIDTITLEFILTERDATA"), AV14BR_EncounterIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_INFORMATION_PATIENTNOTITLEFILTERDATA"), AV18BR_Information_PatientNoTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_DEMOGRAPHICS_BIRTHDATETITLEFILTERDATA"), AV20BR_Demographics_BirthDateTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_DEMOGRAPHICS_SEXTITLEFILTERDATA"), AV24BR_Demographics_SexTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_DEMOGRAPHICS_MARRITALSTATUSTITLEFILTERDATA"), AV26BR_Demographics_MarritalStatusTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_DEMOGRAPHICS_ETHNICTITLEFILTERDATA"), AV28BR_Demographics_EthnicTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_DEMOGRAPHICS_EDUCATIONTITLEFILTERDATA"), AV30BR_Demographics_EducationTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_DEMOGRAPHICS_OCCUPATIONTITLEFILTERDATA"), AV32BR_Demographics_OccupationTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_DEMOGRAPHICS_INSURANCETITLEFILTERDATA"), AV34BR_Demographics_InsuranceTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_DEMOGRAPHICS_PROVINCETITLEFILTERDATA"), AV36BR_Demographics_ProvinceTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_DEMOGRAPHICS_CITYTITLEFILTERDATA"), AV38BR_Demographics_CityTitleFilterData);
            /* Read variables values. */
            AV13ddo_BR_Demographics_IDTitleControlIdToReplace = cgiGet( edtavDdo_br_demographics_idtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13ddo_BR_Demographics_IDTitleControlIdToReplace", AV13ddo_BR_Demographics_IDTitleControlIdToReplace);
            AV15ddo_BR_EncounterIDTitleControlIdToReplace = cgiGet( edtavDdo_br_encounteridtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15ddo_BR_EncounterIDTitleControlIdToReplace", AV15ddo_BR_EncounterIDTitleControlIdToReplace);
            AV19ddo_BR_Information_PatientNoTitleControlIdToReplace = cgiGet( edtavDdo_br_information_patientnotitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19ddo_BR_Information_PatientNoTitleControlIdToReplace", AV19ddo_BR_Information_PatientNoTitleControlIdToReplace);
            AV21ddo_BR_Demographics_BirthDateTitleControlIdToReplace = cgiGet( edtavDdo_br_demographics_birthdatetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21ddo_BR_Demographics_BirthDateTitleControlIdToReplace", AV21ddo_BR_Demographics_BirthDateTitleControlIdToReplace);
            AV25ddo_BR_Demographics_SexTitleControlIdToReplace = cgiGet( edtavDdo_br_demographics_sextitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25ddo_BR_Demographics_SexTitleControlIdToReplace", AV25ddo_BR_Demographics_SexTitleControlIdToReplace);
            AV27ddo_BR_Demographics_MarritalStatusTitleControlIdToReplace = cgiGet( edtavDdo_br_demographics_marritalstatustitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27ddo_BR_Demographics_MarritalStatusTitleControlIdToReplace", AV27ddo_BR_Demographics_MarritalStatusTitleControlIdToReplace);
            AV29ddo_BR_Demographics_EthnicTitleControlIdToReplace = cgiGet( edtavDdo_br_demographics_ethnictitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29ddo_BR_Demographics_EthnicTitleControlIdToReplace", AV29ddo_BR_Demographics_EthnicTitleControlIdToReplace);
            AV31ddo_BR_Demographics_EducationTitleControlIdToReplace = cgiGet( edtavDdo_br_demographics_educationtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31ddo_BR_Demographics_EducationTitleControlIdToReplace", AV31ddo_BR_Demographics_EducationTitleControlIdToReplace);
            AV33ddo_BR_Demographics_OccupationTitleControlIdToReplace = cgiGet( edtavDdo_br_demographics_occupationtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33ddo_BR_Demographics_OccupationTitleControlIdToReplace", AV33ddo_BR_Demographics_OccupationTitleControlIdToReplace);
            AV35ddo_BR_Demographics_InsuranceTitleControlIdToReplace = cgiGet( edtavDdo_br_demographics_insurancetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV35ddo_BR_Demographics_InsuranceTitleControlIdToReplace", AV35ddo_BR_Demographics_InsuranceTitleControlIdToReplace);
            AV37ddo_BR_Demographics_ProvinceTitleControlIdToReplace = cgiGet( edtavDdo_br_demographics_provincetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV37ddo_BR_Demographics_ProvinceTitleControlIdToReplace", AV37ddo_BR_Demographics_ProvinceTitleControlIdToReplace);
            AV39ddo_BR_Demographics_CityTitleControlIdToReplace = cgiGet( edtavDdo_br_demographics_citytitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV39ddo_BR_Demographics_CityTitleControlIdToReplace", AV39ddo_BR_Demographics_CityTitleControlIdToReplace);
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
            AV42GridCurrentPage = (long)(context.localUtil.CToN( cgiGet( "vGRIDCURRENTPAGE"), ".", ","));
            AV44GridRecordCount = (long)(context.localUtil.CToN( cgiGet( "vGRIDRECORDCOUNT"), ".", ","));
            AV43GridPageSize = (long)(context.localUtil.CToN( cgiGet( "vGRIDPAGESIZE"), ".", ","));
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
            Ddo_br_demographics_id_Caption = cgiGet( "DDO_BR_DEMOGRAPHICS_ID_Caption");
            Ddo_br_demographics_id_Tooltip = cgiGet( "DDO_BR_DEMOGRAPHICS_ID_Tooltip");
            Ddo_br_demographics_id_Cls = cgiGet( "DDO_BR_DEMOGRAPHICS_ID_Cls");
            Ddo_br_demographics_id_Dropdownoptionstype = cgiGet( "DDO_BR_DEMOGRAPHICS_ID_Dropdownoptionstype");
            Ddo_br_demographics_id_Titlecontrolidtoreplace = cgiGet( "DDO_BR_DEMOGRAPHICS_ID_Titlecontrolidtoreplace");
            Ddo_br_demographics_id_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_DEMOGRAPHICS_ID_Includesortasc"));
            Ddo_br_demographics_id_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_DEMOGRAPHICS_ID_Includesortdsc"));
            Ddo_br_demographics_id_Sortedstatus = cgiGet( "DDO_BR_DEMOGRAPHICS_ID_Sortedstatus");
            Ddo_br_demographics_id_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_DEMOGRAPHICS_ID_Includefilter"));
            Ddo_br_demographics_id_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_DEMOGRAPHICS_ID_Includedatalist"));
            Ddo_br_demographics_id_Sortasc = cgiGet( "DDO_BR_DEMOGRAPHICS_ID_Sortasc");
            Ddo_br_demographics_id_Sortdsc = cgiGet( "DDO_BR_DEMOGRAPHICS_ID_Sortdsc");
            Ddo_br_demographics_id_Searchbuttontext = cgiGet( "DDO_BR_DEMOGRAPHICS_ID_Searchbuttontext");
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
            Ddo_br_demographics_birthdate_Caption = cgiGet( "DDO_BR_DEMOGRAPHICS_BIRTHDATE_Caption");
            Ddo_br_demographics_birthdate_Tooltip = cgiGet( "DDO_BR_DEMOGRAPHICS_BIRTHDATE_Tooltip");
            Ddo_br_demographics_birthdate_Cls = cgiGet( "DDO_BR_DEMOGRAPHICS_BIRTHDATE_Cls");
            Ddo_br_demographics_birthdate_Dropdownoptionstype = cgiGet( "DDO_BR_DEMOGRAPHICS_BIRTHDATE_Dropdownoptionstype");
            Ddo_br_demographics_birthdate_Titlecontrolidtoreplace = cgiGet( "DDO_BR_DEMOGRAPHICS_BIRTHDATE_Titlecontrolidtoreplace");
            Ddo_br_demographics_birthdate_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_DEMOGRAPHICS_BIRTHDATE_Includesortasc"));
            Ddo_br_demographics_birthdate_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_DEMOGRAPHICS_BIRTHDATE_Includesortdsc"));
            Ddo_br_demographics_birthdate_Sortedstatus = cgiGet( "DDO_BR_DEMOGRAPHICS_BIRTHDATE_Sortedstatus");
            Ddo_br_demographics_birthdate_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_DEMOGRAPHICS_BIRTHDATE_Includefilter"));
            Ddo_br_demographics_birthdate_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_DEMOGRAPHICS_BIRTHDATE_Includedatalist"));
            Ddo_br_demographics_birthdate_Sortasc = cgiGet( "DDO_BR_DEMOGRAPHICS_BIRTHDATE_Sortasc");
            Ddo_br_demographics_birthdate_Sortdsc = cgiGet( "DDO_BR_DEMOGRAPHICS_BIRTHDATE_Sortdsc");
            Ddo_br_demographics_birthdate_Searchbuttontext = cgiGet( "DDO_BR_DEMOGRAPHICS_BIRTHDATE_Searchbuttontext");
            Ddo_br_demographics_sex_Caption = cgiGet( "DDO_BR_DEMOGRAPHICS_SEX_Caption");
            Ddo_br_demographics_sex_Tooltip = cgiGet( "DDO_BR_DEMOGRAPHICS_SEX_Tooltip");
            Ddo_br_demographics_sex_Cls = cgiGet( "DDO_BR_DEMOGRAPHICS_SEX_Cls");
            Ddo_br_demographics_sex_Dropdownoptionstype = cgiGet( "DDO_BR_DEMOGRAPHICS_SEX_Dropdownoptionstype");
            Ddo_br_demographics_sex_Titlecontrolidtoreplace = cgiGet( "DDO_BR_DEMOGRAPHICS_SEX_Titlecontrolidtoreplace");
            Ddo_br_demographics_sex_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_DEMOGRAPHICS_SEX_Includesortasc"));
            Ddo_br_demographics_sex_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_DEMOGRAPHICS_SEX_Includesortdsc"));
            Ddo_br_demographics_sex_Sortedstatus = cgiGet( "DDO_BR_DEMOGRAPHICS_SEX_Sortedstatus");
            Ddo_br_demographics_sex_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_DEMOGRAPHICS_SEX_Includefilter"));
            Ddo_br_demographics_sex_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_DEMOGRAPHICS_SEX_Includedatalist"));
            Ddo_br_demographics_sex_Sortasc = cgiGet( "DDO_BR_DEMOGRAPHICS_SEX_Sortasc");
            Ddo_br_demographics_sex_Sortdsc = cgiGet( "DDO_BR_DEMOGRAPHICS_SEX_Sortdsc");
            Ddo_br_demographics_sex_Searchbuttontext = cgiGet( "DDO_BR_DEMOGRAPHICS_SEX_Searchbuttontext");
            Ddo_br_demographics_marritalstatus_Caption = cgiGet( "DDO_BR_DEMOGRAPHICS_MARRITALSTATUS_Caption");
            Ddo_br_demographics_marritalstatus_Tooltip = cgiGet( "DDO_BR_DEMOGRAPHICS_MARRITALSTATUS_Tooltip");
            Ddo_br_demographics_marritalstatus_Cls = cgiGet( "DDO_BR_DEMOGRAPHICS_MARRITALSTATUS_Cls");
            Ddo_br_demographics_marritalstatus_Dropdownoptionstype = cgiGet( "DDO_BR_DEMOGRAPHICS_MARRITALSTATUS_Dropdownoptionstype");
            Ddo_br_demographics_marritalstatus_Titlecontrolidtoreplace = cgiGet( "DDO_BR_DEMOGRAPHICS_MARRITALSTATUS_Titlecontrolidtoreplace");
            Ddo_br_demographics_marritalstatus_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_DEMOGRAPHICS_MARRITALSTATUS_Includesortasc"));
            Ddo_br_demographics_marritalstatus_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_DEMOGRAPHICS_MARRITALSTATUS_Includesortdsc"));
            Ddo_br_demographics_marritalstatus_Sortedstatus = cgiGet( "DDO_BR_DEMOGRAPHICS_MARRITALSTATUS_Sortedstatus");
            Ddo_br_demographics_marritalstatus_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_DEMOGRAPHICS_MARRITALSTATUS_Includefilter"));
            Ddo_br_demographics_marritalstatus_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_DEMOGRAPHICS_MARRITALSTATUS_Includedatalist"));
            Ddo_br_demographics_marritalstatus_Sortasc = cgiGet( "DDO_BR_DEMOGRAPHICS_MARRITALSTATUS_Sortasc");
            Ddo_br_demographics_marritalstatus_Sortdsc = cgiGet( "DDO_BR_DEMOGRAPHICS_MARRITALSTATUS_Sortdsc");
            Ddo_br_demographics_marritalstatus_Searchbuttontext = cgiGet( "DDO_BR_DEMOGRAPHICS_MARRITALSTATUS_Searchbuttontext");
            Ddo_br_demographics_ethnic_Caption = cgiGet( "DDO_BR_DEMOGRAPHICS_ETHNIC_Caption");
            Ddo_br_demographics_ethnic_Tooltip = cgiGet( "DDO_BR_DEMOGRAPHICS_ETHNIC_Tooltip");
            Ddo_br_demographics_ethnic_Cls = cgiGet( "DDO_BR_DEMOGRAPHICS_ETHNIC_Cls");
            Ddo_br_demographics_ethnic_Dropdownoptionstype = cgiGet( "DDO_BR_DEMOGRAPHICS_ETHNIC_Dropdownoptionstype");
            Ddo_br_demographics_ethnic_Titlecontrolidtoreplace = cgiGet( "DDO_BR_DEMOGRAPHICS_ETHNIC_Titlecontrolidtoreplace");
            Ddo_br_demographics_ethnic_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_DEMOGRAPHICS_ETHNIC_Includesortasc"));
            Ddo_br_demographics_ethnic_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_DEMOGRAPHICS_ETHNIC_Includesortdsc"));
            Ddo_br_demographics_ethnic_Sortedstatus = cgiGet( "DDO_BR_DEMOGRAPHICS_ETHNIC_Sortedstatus");
            Ddo_br_demographics_ethnic_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_DEMOGRAPHICS_ETHNIC_Includefilter"));
            Ddo_br_demographics_ethnic_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_DEMOGRAPHICS_ETHNIC_Includedatalist"));
            Ddo_br_demographics_ethnic_Sortasc = cgiGet( "DDO_BR_DEMOGRAPHICS_ETHNIC_Sortasc");
            Ddo_br_demographics_ethnic_Sortdsc = cgiGet( "DDO_BR_DEMOGRAPHICS_ETHNIC_Sortdsc");
            Ddo_br_demographics_ethnic_Searchbuttontext = cgiGet( "DDO_BR_DEMOGRAPHICS_ETHNIC_Searchbuttontext");
            Ddo_br_demographics_education_Caption = cgiGet( "DDO_BR_DEMOGRAPHICS_EDUCATION_Caption");
            Ddo_br_demographics_education_Tooltip = cgiGet( "DDO_BR_DEMOGRAPHICS_EDUCATION_Tooltip");
            Ddo_br_demographics_education_Cls = cgiGet( "DDO_BR_DEMOGRAPHICS_EDUCATION_Cls");
            Ddo_br_demographics_education_Dropdownoptionstype = cgiGet( "DDO_BR_DEMOGRAPHICS_EDUCATION_Dropdownoptionstype");
            Ddo_br_demographics_education_Titlecontrolidtoreplace = cgiGet( "DDO_BR_DEMOGRAPHICS_EDUCATION_Titlecontrolidtoreplace");
            Ddo_br_demographics_education_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_DEMOGRAPHICS_EDUCATION_Includesortasc"));
            Ddo_br_demographics_education_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_DEMOGRAPHICS_EDUCATION_Includesortdsc"));
            Ddo_br_demographics_education_Sortedstatus = cgiGet( "DDO_BR_DEMOGRAPHICS_EDUCATION_Sortedstatus");
            Ddo_br_demographics_education_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_DEMOGRAPHICS_EDUCATION_Includefilter"));
            Ddo_br_demographics_education_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_DEMOGRAPHICS_EDUCATION_Includedatalist"));
            Ddo_br_demographics_education_Sortasc = cgiGet( "DDO_BR_DEMOGRAPHICS_EDUCATION_Sortasc");
            Ddo_br_demographics_education_Sortdsc = cgiGet( "DDO_BR_DEMOGRAPHICS_EDUCATION_Sortdsc");
            Ddo_br_demographics_education_Searchbuttontext = cgiGet( "DDO_BR_DEMOGRAPHICS_EDUCATION_Searchbuttontext");
            Ddo_br_demographics_occupation_Caption = cgiGet( "DDO_BR_DEMOGRAPHICS_OCCUPATION_Caption");
            Ddo_br_demographics_occupation_Tooltip = cgiGet( "DDO_BR_DEMOGRAPHICS_OCCUPATION_Tooltip");
            Ddo_br_demographics_occupation_Cls = cgiGet( "DDO_BR_DEMOGRAPHICS_OCCUPATION_Cls");
            Ddo_br_demographics_occupation_Dropdownoptionstype = cgiGet( "DDO_BR_DEMOGRAPHICS_OCCUPATION_Dropdownoptionstype");
            Ddo_br_demographics_occupation_Titlecontrolidtoreplace = cgiGet( "DDO_BR_DEMOGRAPHICS_OCCUPATION_Titlecontrolidtoreplace");
            Ddo_br_demographics_occupation_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_DEMOGRAPHICS_OCCUPATION_Includesortasc"));
            Ddo_br_demographics_occupation_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_DEMOGRAPHICS_OCCUPATION_Includesortdsc"));
            Ddo_br_demographics_occupation_Sortedstatus = cgiGet( "DDO_BR_DEMOGRAPHICS_OCCUPATION_Sortedstatus");
            Ddo_br_demographics_occupation_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_DEMOGRAPHICS_OCCUPATION_Includefilter"));
            Ddo_br_demographics_occupation_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_DEMOGRAPHICS_OCCUPATION_Includedatalist"));
            Ddo_br_demographics_occupation_Sortasc = cgiGet( "DDO_BR_DEMOGRAPHICS_OCCUPATION_Sortasc");
            Ddo_br_demographics_occupation_Sortdsc = cgiGet( "DDO_BR_DEMOGRAPHICS_OCCUPATION_Sortdsc");
            Ddo_br_demographics_occupation_Searchbuttontext = cgiGet( "DDO_BR_DEMOGRAPHICS_OCCUPATION_Searchbuttontext");
            Ddo_br_demographics_insurance_Caption = cgiGet( "DDO_BR_DEMOGRAPHICS_INSURANCE_Caption");
            Ddo_br_demographics_insurance_Tooltip = cgiGet( "DDO_BR_DEMOGRAPHICS_INSURANCE_Tooltip");
            Ddo_br_demographics_insurance_Cls = cgiGet( "DDO_BR_DEMOGRAPHICS_INSURANCE_Cls");
            Ddo_br_demographics_insurance_Dropdownoptionstype = cgiGet( "DDO_BR_DEMOGRAPHICS_INSURANCE_Dropdownoptionstype");
            Ddo_br_demographics_insurance_Titlecontrolidtoreplace = cgiGet( "DDO_BR_DEMOGRAPHICS_INSURANCE_Titlecontrolidtoreplace");
            Ddo_br_demographics_insurance_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_DEMOGRAPHICS_INSURANCE_Includesortasc"));
            Ddo_br_demographics_insurance_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_DEMOGRAPHICS_INSURANCE_Includesortdsc"));
            Ddo_br_demographics_insurance_Sortedstatus = cgiGet( "DDO_BR_DEMOGRAPHICS_INSURANCE_Sortedstatus");
            Ddo_br_demographics_insurance_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_DEMOGRAPHICS_INSURANCE_Includefilter"));
            Ddo_br_demographics_insurance_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_DEMOGRAPHICS_INSURANCE_Includedatalist"));
            Ddo_br_demographics_insurance_Sortasc = cgiGet( "DDO_BR_DEMOGRAPHICS_INSURANCE_Sortasc");
            Ddo_br_demographics_insurance_Sortdsc = cgiGet( "DDO_BR_DEMOGRAPHICS_INSURANCE_Sortdsc");
            Ddo_br_demographics_insurance_Searchbuttontext = cgiGet( "DDO_BR_DEMOGRAPHICS_INSURANCE_Searchbuttontext");
            Ddo_br_demographics_province_Caption = cgiGet( "DDO_BR_DEMOGRAPHICS_PROVINCE_Caption");
            Ddo_br_demographics_province_Tooltip = cgiGet( "DDO_BR_DEMOGRAPHICS_PROVINCE_Tooltip");
            Ddo_br_demographics_province_Cls = cgiGet( "DDO_BR_DEMOGRAPHICS_PROVINCE_Cls");
            Ddo_br_demographics_province_Dropdownoptionstype = cgiGet( "DDO_BR_DEMOGRAPHICS_PROVINCE_Dropdownoptionstype");
            Ddo_br_demographics_province_Titlecontrolidtoreplace = cgiGet( "DDO_BR_DEMOGRAPHICS_PROVINCE_Titlecontrolidtoreplace");
            Ddo_br_demographics_province_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_DEMOGRAPHICS_PROVINCE_Includesortasc"));
            Ddo_br_demographics_province_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_DEMOGRAPHICS_PROVINCE_Includesortdsc"));
            Ddo_br_demographics_province_Sortedstatus = cgiGet( "DDO_BR_DEMOGRAPHICS_PROVINCE_Sortedstatus");
            Ddo_br_demographics_province_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_DEMOGRAPHICS_PROVINCE_Includefilter"));
            Ddo_br_demographics_province_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_DEMOGRAPHICS_PROVINCE_Includedatalist"));
            Ddo_br_demographics_province_Sortasc = cgiGet( "DDO_BR_DEMOGRAPHICS_PROVINCE_Sortasc");
            Ddo_br_demographics_province_Sortdsc = cgiGet( "DDO_BR_DEMOGRAPHICS_PROVINCE_Sortdsc");
            Ddo_br_demographics_province_Searchbuttontext = cgiGet( "DDO_BR_DEMOGRAPHICS_PROVINCE_Searchbuttontext");
            Ddo_br_demographics_city_Caption = cgiGet( "DDO_BR_DEMOGRAPHICS_CITY_Caption");
            Ddo_br_demographics_city_Tooltip = cgiGet( "DDO_BR_DEMOGRAPHICS_CITY_Tooltip");
            Ddo_br_demographics_city_Cls = cgiGet( "DDO_BR_DEMOGRAPHICS_CITY_Cls");
            Ddo_br_demographics_city_Dropdownoptionstype = cgiGet( "DDO_BR_DEMOGRAPHICS_CITY_Dropdownoptionstype");
            Ddo_br_demographics_city_Titlecontrolidtoreplace = cgiGet( "DDO_BR_DEMOGRAPHICS_CITY_Titlecontrolidtoreplace");
            Ddo_br_demographics_city_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_DEMOGRAPHICS_CITY_Includesortasc"));
            Ddo_br_demographics_city_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_DEMOGRAPHICS_CITY_Includesortdsc"));
            Ddo_br_demographics_city_Sortedstatus = cgiGet( "DDO_BR_DEMOGRAPHICS_CITY_Sortedstatus");
            Ddo_br_demographics_city_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_DEMOGRAPHICS_CITY_Includefilter"));
            Ddo_br_demographics_city_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_DEMOGRAPHICS_CITY_Includedatalist"));
            Ddo_br_demographics_city_Sortasc = cgiGet( "DDO_BR_DEMOGRAPHICS_CITY_Sortasc");
            Ddo_br_demographics_city_Sortdsc = cgiGet( "DDO_BR_DEMOGRAPHICS_CITY_Sortdsc");
            Ddo_br_demographics_city_Searchbuttontext = cgiGet( "DDO_BR_DEMOGRAPHICS_CITY_Searchbuttontext");
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( "GRID_Rows"), ".", ","));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            Gridpaginationbar_Selectedpage = cgiGet( "GRIDPAGINATIONBAR_Selectedpage");
            Gridpaginationbar_Rowsperpageselectedvalue = (int)(context.localUtil.CToN( cgiGet( "GRIDPAGINATIONBAR_Rowsperpageselectedvalue"), ".", ","));
            Ddo_br_demographics_id_Activeeventkey = cgiGet( "DDO_BR_DEMOGRAPHICS_ID_Activeeventkey");
            Ddo_br_encounterid_Activeeventkey = cgiGet( "DDO_BR_ENCOUNTERID_Activeeventkey");
            Ddo_br_information_patientno_Activeeventkey = cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Activeeventkey");
            Ddo_br_demographics_birthdate_Activeeventkey = cgiGet( "DDO_BR_DEMOGRAPHICS_BIRTHDATE_Activeeventkey");
            Ddo_br_demographics_sex_Activeeventkey = cgiGet( "DDO_BR_DEMOGRAPHICS_SEX_Activeeventkey");
            Ddo_br_demographics_marritalstatus_Activeeventkey = cgiGet( "DDO_BR_DEMOGRAPHICS_MARRITALSTATUS_Activeeventkey");
            Ddo_br_demographics_ethnic_Activeeventkey = cgiGet( "DDO_BR_DEMOGRAPHICS_ETHNIC_Activeeventkey");
            Ddo_br_demographics_education_Activeeventkey = cgiGet( "DDO_BR_DEMOGRAPHICS_EDUCATION_Activeeventkey");
            Ddo_br_demographics_occupation_Activeeventkey = cgiGet( "DDO_BR_DEMOGRAPHICS_OCCUPATION_Activeeventkey");
            Ddo_br_demographics_insurance_Activeeventkey = cgiGet( "DDO_BR_DEMOGRAPHICS_INSURANCE_Activeeventkey");
            Ddo_br_demographics_province_Activeeventkey = cgiGet( "DDO_BR_DEMOGRAPHICS_PROVINCE_Activeeventkey");
            Ddo_br_demographics_city_Activeeventkey = cgiGet( "DDO_BR_DEMOGRAPHICS_CITY_Activeeventkey");
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
         E252M2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E252M2( )
      {
         /* Start Routine */
         GXt_boolean1 = AV5IsAuthorized;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Check_Demographics", out  GXt_boolean1) ;
         AV5IsAuthorized = GXt_boolean1;
         if ( ! AV5IsAuthorized )
         {
            CallWebObject(formatLink("wwpbaseobjects.notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV48Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         divTablemain_Height = 493;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, divTablemain_Internalname, "Height", StringUtil.LTrim( StringUtil.Str( (decimal)(divTablemain_Height), 9, 0)), true);
         subGrid_Rows = 9;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         Ddo_br_demographics_id_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Demographics_ID";
         ucDdo_br_demographics_id.SendProperty(context, "", false, Ddo_br_demographics_id_Internalname, "TitleControlIdToReplace", Ddo_br_demographics_id_Titlecontrolidtoreplace);
         AV13ddo_BR_Demographics_IDTitleControlIdToReplace = Ddo_br_demographics_id_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13ddo_BR_Demographics_IDTitleControlIdToReplace", AV13ddo_BR_Demographics_IDTitleControlIdToReplace);
         edtavDdo_br_demographics_idtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_demographics_idtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_demographics_idtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_encounterid_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_EncounterID";
         ucDdo_br_encounterid.SendProperty(context, "", false, Ddo_br_encounterid_Internalname, "TitleControlIdToReplace", Ddo_br_encounterid_Titlecontrolidtoreplace);
         AV15ddo_BR_EncounterIDTitleControlIdToReplace = Ddo_br_encounterid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15ddo_BR_EncounterIDTitleControlIdToReplace", AV15ddo_BR_EncounterIDTitleControlIdToReplace);
         edtavDdo_br_encounteridtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_encounteridtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_encounteridtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_information_patientno_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Information_PatientNo";
         ucDdo_br_information_patientno.SendProperty(context, "", false, Ddo_br_information_patientno_Internalname, "TitleControlIdToReplace", Ddo_br_information_patientno_Titlecontrolidtoreplace);
         AV19ddo_BR_Information_PatientNoTitleControlIdToReplace = Ddo_br_information_patientno_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19ddo_BR_Information_PatientNoTitleControlIdToReplace", AV19ddo_BR_Information_PatientNoTitleControlIdToReplace);
         edtavDdo_br_information_patientnotitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_information_patientnotitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_information_patientnotitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_demographics_birthdate_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Demographics_BirthDate";
         ucDdo_br_demographics_birthdate.SendProperty(context, "", false, Ddo_br_demographics_birthdate_Internalname, "TitleControlIdToReplace", Ddo_br_demographics_birthdate_Titlecontrolidtoreplace);
         AV21ddo_BR_Demographics_BirthDateTitleControlIdToReplace = Ddo_br_demographics_birthdate_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21ddo_BR_Demographics_BirthDateTitleControlIdToReplace", AV21ddo_BR_Demographics_BirthDateTitleControlIdToReplace);
         edtavDdo_br_demographics_birthdatetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_demographics_birthdatetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_demographics_birthdatetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_demographics_sex_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Demographics_Sex";
         ucDdo_br_demographics_sex.SendProperty(context, "", false, Ddo_br_demographics_sex_Internalname, "TitleControlIdToReplace", Ddo_br_demographics_sex_Titlecontrolidtoreplace);
         AV25ddo_BR_Demographics_SexTitleControlIdToReplace = Ddo_br_demographics_sex_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25ddo_BR_Demographics_SexTitleControlIdToReplace", AV25ddo_BR_Demographics_SexTitleControlIdToReplace);
         edtavDdo_br_demographics_sextitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_demographics_sextitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_demographics_sextitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_demographics_marritalstatus_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Demographics_MarritalStatus";
         ucDdo_br_demographics_marritalstatus.SendProperty(context, "", false, Ddo_br_demographics_marritalstatus_Internalname, "TitleControlIdToReplace", Ddo_br_demographics_marritalstatus_Titlecontrolidtoreplace);
         AV27ddo_BR_Demographics_MarritalStatusTitleControlIdToReplace = Ddo_br_demographics_marritalstatus_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27ddo_BR_Demographics_MarritalStatusTitleControlIdToReplace", AV27ddo_BR_Demographics_MarritalStatusTitleControlIdToReplace);
         edtavDdo_br_demographics_marritalstatustitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_demographics_marritalstatustitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_demographics_marritalstatustitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_demographics_ethnic_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Demographics_Ethnic";
         ucDdo_br_demographics_ethnic.SendProperty(context, "", false, Ddo_br_demographics_ethnic_Internalname, "TitleControlIdToReplace", Ddo_br_demographics_ethnic_Titlecontrolidtoreplace);
         AV29ddo_BR_Demographics_EthnicTitleControlIdToReplace = Ddo_br_demographics_ethnic_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29ddo_BR_Demographics_EthnicTitleControlIdToReplace", AV29ddo_BR_Demographics_EthnicTitleControlIdToReplace);
         edtavDdo_br_demographics_ethnictitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_demographics_ethnictitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_demographics_ethnictitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_demographics_education_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Demographics_Education";
         ucDdo_br_demographics_education.SendProperty(context, "", false, Ddo_br_demographics_education_Internalname, "TitleControlIdToReplace", Ddo_br_demographics_education_Titlecontrolidtoreplace);
         AV31ddo_BR_Demographics_EducationTitleControlIdToReplace = Ddo_br_demographics_education_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31ddo_BR_Demographics_EducationTitleControlIdToReplace", AV31ddo_BR_Demographics_EducationTitleControlIdToReplace);
         edtavDdo_br_demographics_educationtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_demographics_educationtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_demographics_educationtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_demographics_occupation_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Demographics_Occupation";
         ucDdo_br_demographics_occupation.SendProperty(context, "", false, Ddo_br_demographics_occupation_Internalname, "TitleControlIdToReplace", Ddo_br_demographics_occupation_Titlecontrolidtoreplace);
         AV33ddo_BR_Demographics_OccupationTitleControlIdToReplace = Ddo_br_demographics_occupation_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33ddo_BR_Demographics_OccupationTitleControlIdToReplace", AV33ddo_BR_Demographics_OccupationTitleControlIdToReplace);
         edtavDdo_br_demographics_occupationtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_demographics_occupationtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_demographics_occupationtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_demographics_insurance_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Demographics_Insurance";
         ucDdo_br_demographics_insurance.SendProperty(context, "", false, Ddo_br_demographics_insurance_Internalname, "TitleControlIdToReplace", Ddo_br_demographics_insurance_Titlecontrolidtoreplace);
         AV35ddo_BR_Demographics_InsuranceTitleControlIdToReplace = Ddo_br_demographics_insurance_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV35ddo_BR_Demographics_InsuranceTitleControlIdToReplace", AV35ddo_BR_Demographics_InsuranceTitleControlIdToReplace);
         edtavDdo_br_demographics_insurancetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_demographics_insurancetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_demographics_insurancetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_demographics_province_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Demographics_Province";
         ucDdo_br_demographics_province.SendProperty(context, "", false, Ddo_br_demographics_province_Internalname, "TitleControlIdToReplace", Ddo_br_demographics_province_Titlecontrolidtoreplace);
         AV37ddo_BR_Demographics_ProvinceTitleControlIdToReplace = Ddo_br_demographics_province_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV37ddo_BR_Demographics_ProvinceTitleControlIdToReplace", AV37ddo_BR_Demographics_ProvinceTitleControlIdToReplace);
         edtavDdo_br_demographics_provincetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_demographics_provincetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_demographics_provincetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_demographics_city_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Demographics_City";
         ucDdo_br_demographics_city.SendProperty(context, "", false, Ddo_br_demographics_city_Internalname, "TitleControlIdToReplace", Ddo_br_demographics_city_Titlecontrolidtoreplace);
         AV39ddo_BR_Demographics_CityTitleControlIdToReplace = Ddo_br_demographics_city_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV39ddo_BR_Demographics_CityTitleControlIdToReplace", AV39ddo_BR_Demographics_CityTitleControlIdToReplace);
         edtavDdo_br_demographics_citytitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_demographics_citytitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_demographics_citytitlecontrolidtoreplace_Visible), 5, 0)), true);
         Form.Caption = "选择人口信息学";
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
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 = AV40DDO_TitleSettingsIcons;
         new GeneXus.Programs.wwpbaseobjects.getwwptitlesettingsicons(context ).execute( out  GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2) ;
         AV40DDO_TitleSettingsIcons = GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2;
         Gridpaginationbar_Rowsperpageselectedvalue = subGrid_Rows;
         ucGridpaginationbar.SendProperty(context, "", false, Gridpaginationbar_Internalname, "RowsPerPageSelectedValue", StringUtil.LTrim( StringUtil.Str( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0)));
      }

      protected void E262M2( )
      {
         if ( gx_refresh_fired )
         {
            return  ;
         }
         gx_refresh_fired = true;
         /* Refresh Routine */
         AV12BR_Demographics_IDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV14BR_EncounterIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV18BR_Information_PatientNoTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV20BR_Demographics_BirthDateTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV24BR_Demographics_SexTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV26BR_Demographics_MarritalStatusTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV28BR_Demographics_EthnicTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV30BR_Demographics_EducationTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV32BR_Demographics_OccupationTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV34BR_Demographics_InsuranceTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV36BR_Demographics_ProvinceTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV38BR_Demographics_CityTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV6WWPContext) ;
         edtBR_Demographics_ID_Titleformat = 2;
         edtBR_Demographics_ID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "人口信息学主键", AV13ddo_BR_Demographics_IDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Demographics_ID_Internalname, "Title", edtBR_Demographics_ID_Title, !bGXsfl_12_Refreshing);
         edtBR_EncounterID_Titleformat = 2;
         edtBR_EncounterID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "就诊信息主键", AV15ddo_BR_EncounterIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_EncounterID_Internalname, "Title", edtBR_EncounterID_Title, !bGXsfl_12_Refreshing);
         edtBR_Information_PatientNo_Titleformat = 2;
         edtBR_Information_PatientNo_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "患者编号", AV19ddo_BR_Information_PatientNoTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Information_PatientNo_Internalname, "Title", edtBR_Information_PatientNo_Title, !bGXsfl_12_Refreshing);
         edtBR_Demographics_BirthDate_Titleformat = 2;
         edtBR_Demographics_BirthDate_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "出生日期", AV21ddo_BR_Demographics_BirthDateTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Demographics_BirthDate_Internalname, "Title", edtBR_Demographics_BirthDate_Title, !bGXsfl_12_Refreshing);
         edtBR_Demographics_Sex_Titleformat = 2;
         edtBR_Demographics_Sex_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "性别", AV25ddo_BR_Demographics_SexTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Demographics_Sex_Internalname, "Title", edtBR_Demographics_Sex_Title, !bGXsfl_12_Refreshing);
         edtBR_Demographics_MarritalStatus_Titleformat = 2;
         edtBR_Demographics_MarritalStatus_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "婚姻状态", AV27ddo_BR_Demographics_MarritalStatusTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Demographics_MarritalStatus_Internalname, "Title", edtBR_Demographics_MarritalStatus_Title, !bGXsfl_12_Refreshing);
         edtBR_Demographics_Ethnic_Titleformat = 2;
         edtBR_Demographics_Ethnic_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "民族", AV29ddo_BR_Demographics_EthnicTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Demographics_Ethnic_Internalname, "Title", edtBR_Demographics_Ethnic_Title, !bGXsfl_12_Refreshing);
         edtBR_Demographics_Education_Titleformat = 2;
         edtBR_Demographics_Education_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "学历", AV31ddo_BR_Demographics_EducationTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Demographics_Education_Internalname, "Title", edtBR_Demographics_Education_Title, !bGXsfl_12_Refreshing);
         edtBR_Demographics_Occupation_Titleformat = 2;
         edtBR_Demographics_Occupation_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "职业", AV33ddo_BR_Demographics_OccupationTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Demographics_Occupation_Internalname, "Title", edtBR_Demographics_Occupation_Title, !bGXsfl_12_Refreshing);
         edtBR_Demographics_Insurance_Titleformat = 2;
         edtBR_Demographics_Insurance_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "保险类型", AV35ddo_BR_Demographics_InsuranceTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Demographics_Insurance_Internalname, "Title", edtBR_Demographics_Insurance_Title, !bGXsfl_12_Refreshing);
         edtBR_Demographics_Province_Titleformat = 2;
         edtBR_Demographics_Province_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "省", AV37ddo_BR_Demographics_ProvinceTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Demographics_Province_Internalname, "Title", edtBR_Demographics_Province_Title, !bGXsfl_12_Refreshing);
         edtBR_Demographics_City_Titleformat = 2;
         edtBR_Demographics_City_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "市", AV39ddo_BR_Demographics_CityTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Demographics_City_Internalname, "Title", edtBR_Demographics_City_Title, !bGXsfl_12_Refreshing);
         AV42GridCurrentPage = subGrid_Currentpage( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV42GridCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV42GridCurrentPage), 10, 0)));
         AV43GridPageSize = subGrid_Rows;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV43GridPageSize", StringUtil.LTrim( StringUtil.Str( (decimal)(AV43GridPageSize), 10, 0)));
         AV44GridRecordCount = subGrid_Recordcount( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV44GridRecordCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV44GridRecordCount), 10, 0)));
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12BR_Demographics_IDTitleFilterData", AV12BR_Demographics_IDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14BR_EncounterIDTitleFilterData", AV14BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18BR_Information_PatientNoTitleFilterData", AV18BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Demographics_BirthDateTitleFilterData", AV20BR_Demographics_BirthDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Demographics_SexTitleFilterData", AV24BR_Demographics_SexTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV26BR_Demographics_MarritalStatusTitleFilterData", AV26BR_Demographics_MarritalStatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Demographics_EthnicTitleFilterData", AV28BR_Demographics_EthnicTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30BR_Demographics_EducationTitleFilterData", AV30BR_Demographics_EducationTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Demographics_OccupationTitleFilterData", AV32BR_Demographics_OccupationTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34BR_Demographics_InsuranceTitleFilterData", AV34BR_Demographics_InsuranceTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36BR_Demographics_ProvinceTitleFilterData", AV36BR_Demographics_ProvinceTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_Demographics_CityTitleFilterData", AV38BR_Demographics_CityTitleFilterData);
      }

      protected void E112M2( )
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
            AV41PageToGo = (int)(NumberUtil.Val( Gridpaginationbar_Selectedpage, "."));
            subgrid_gotopage( AV41PageToGo) ;
         }
      }

      protected void E122M2( )
      {
         /* Gridpaginationbar_Changerowsperpage Routine */
         subGrid_Rows = Gridpaginationbar_Rowsperpageselectedvalue;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         subgrid_firstpage( ) ;
         /*  Sending Event outputs  */
      }

      protected void E132M2( )
      {
         /* Ddo_br_demographics_id_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_demographics_id_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV10OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_demographics_id_Sortedstatus = "ASC";
            ucDdo_br_demographics_id.SendProperty(context, "", false, Ddo_br_demographics_id_Internalname, "SortedStatus", Ddo_br_demographics_id_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_demographics_id_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV10OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_demographics_id_Sortedstatus = "DSC";
            ucDdo_br_demographics_id.SendProperty(context, "", false, Ddo_br_demographics_id_Internalname, "SortedStatus", Ddo_br_demographics_id_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12BR_Demographics_IDTitleFilterData", AV12BR_Demographics_IDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14BR_EncounterIDTitleFilterData", AV14BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18BR_Information_PatientNoTitleFilterData", AV18BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Demographics_BirthDateTitleFilterData", AV20BR_Demographics_BirthDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Demographics_SexTitleFilterData", AV24BR_Demographics_SexTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV26BR_Demographics_MarritalStatusTitleFilterData", AV26BR_Demographics_MarritalStatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Demographics_EthnicTitleFilterData", AV28BR_Demographics_EthnicTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30BR_Demographics_EducationTitleFilterData", AV30BR_Demographics_EducationTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Demographics_OccupationTitleFilterData", AV32BR_Demographics_OccupationTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34BR_Demographics_InsuranceTitleFilterData", AV34BR_Demographics_InsuranceTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36BR_Demographics_ProvinceTitleFilterData", AV36BR_Demographics_ProvinceTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_Demographics_CityTitleFilterData", AV38BR_Demographics_CityTitleFilterData);
      }

      protected void E142M2( )
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
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12BR_Demographics_IDTitleFilterData", AV12BR_Demographics_IDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14BR_EncounterIDTitleFilterData", AV14BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18BR_Information_PatientNoTitleFilterData", AV18BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Demographics_BirthDateTitleFilterData", AV20BR_Demographics_BirthDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Demographics_SexTitleFilterData", AV24BR_Demographics_SexTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV26BR_Demographics_MarritalStatusTitleFilterData", AV26BR_Demographics_MarritalStatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Demographics_EthnicTitleFilterData", AV28BR_Demographics_EthnicTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30BR_Demographics_EducationTitleFilterData", AV30BR_Demographics_EducationTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Demographics_OccupationTitleFilterData", AV32BR_Demographics_OccupationTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34BR_Demographics_InsuranceTitleFilterData", AV34BR_Demographics_InsuranceTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36BR_Demographics_ProvinceTitleFilterData", AV36BR_Demographics_ProvinceTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_Demographics_CityTitleFilterData", AV38BR_Demographics_CityTitleFilterData);
      }

      protected void E152M2( )
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
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12BR_Demographics_IDTitleFilterData", AV12BR_Demographics_IDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14BR_EncounterIDTitleFilterData", AV14BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18BR_Information_PatientNoTitleFilterData", AV18BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Demographics_BirthDateTitleFilterData", AV20BR_Demographics_BirthDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Demographics_SexTitleFilterData", AV24BR_Demographics_SexTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV26BR_Demographics_MarritalStatusTitleFilterData", AV26BR_Demographics_MarritalStatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Demographics_EthnicTitleFilterData", AV28BR_Demographics_EthnicTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30BR_Demographics_EducationTitleFilterData", AV30BR_Demographics_EducationTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Demographics_OccupationTitleFilterData", AV32BR_Demographics_OccupationTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34BR_Demographics_InsuranceTitleFilterData", AV34BR_Demographics_InsuranceTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36BR_Demographics_ProvinceTitleFilterData", AV36BR_Demographics_ProvinceTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_Demographics_CityTitleFilterData", AV38BR_Demographics_CityTitleFilterData);
      }

      protected void E162M2( )
      {
         /* Ddo_br_demographics_birthdate_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_demographics_birthdate_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV10OrderedBy = 4;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_demographics_birthdate_Sortedstatus = "ASC";
            ucDdo_br_demographics_birthdate.SendProperty(context, "", false, Ddo_br_demographics_birthdate_Internalname, "SortedStatus", Ddo_br_demographics_birthdate_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_demographics_birthdate_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV10OrderedBy = 4;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_demographics_birthdate_Sortedstatus = "DSC";
            ucDdo_br_demographics_birthdate.SendProperty(context, "", false, Ddo_br_demographics_birthdate_Internalname, "SortedStatus", Ddo_br_demographics_birthdate_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12BR_Demographics_IDTitleFilterData", AV12BR_Demographics_IDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14BR_EncounterIDTitleFilterData", AV14BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18BR_Information_PatientNoTitleFilterData", AV18BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Demographics_BirthDateTitleFilterData", AV20BR_Demographics_BirthDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Demographics_SexTitleFilterData", AV24BR_Demographics_SexTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV26BR_Demographics_MarritalStatusTitleFilterData", AV26BR_Demographics_MarritalStatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Demographics_EthnicTitleFilterData", AV28BR_Demographics_EthnicTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30BR_Demographics_EducationTitleFilterData", AV30BR_Demographics_EducationTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Demographics_OccupationTitleFilterData", AV32BR_Demographics_OccupationTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34BR_Demographics_InsuranceTitleFilterData", AV34BR_Demographics_InsuranceTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36BR_Demographics_ProvinceTitleFilterData", AV36BR_Demographics_ProvinceTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_Demographics_CityTitleFilterData", AV38BR_Demographics_CityTitleFilterData);
      }

      protected void E172M2( )
      {
         /* Ddo_br_demographics_sex_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_demographics_sex_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV10OrderedBy = 5;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_demographics_sex_Sortedstatus = "ASC";
            ucDdo_br_demographics_sex.SendProperty(context, "", false, Ddo_br_demographics_sex_Internalname, "SortedStatus", Ddo_br_demographics_sex_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_demographics_sex_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV10OrderedBy = 5;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_demographics_sex_Sortedstatus = "DSC";
            ucDdo_br_demographics_sex.SendProperty(context, "", false, Ddo_br_demographics_sex_Internalname, "SortedStatus", Ddo_br_demographics_sex_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12BR_Demographics_IDTitleFilterData", AV12BR_Demographics_IDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14BR_EncounterIDTitleFilterData", AV14BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18BR_Information_PatientNoTitleFilterData", AV18BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Demographics_BirthDateTitleFilterData", AV20BR_Demographics_BirthDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Demographics_SexTitleFilterData", AV24BR_Demographics_SexTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV26BR_Demographics_MarritalStatusTitleFilterData", AV26BR_Demographics_MarritalStatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Demographics_EthnicTitleFilterData", AV28BR_Demographics_EthnicTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30BR_Demographics_EducationTitleFilterData", AV30BR_Demographics_EducationTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Demographics_OccupationTitleFilterData", AV32BR_Demographics_OccupationTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34BR_Demographics_InsuranceTitleFilterData", AV34BR_Demographics_InsuranceTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36BR_Demographics_ProvinceTitleFilterData", AV36BR_Demographics_ProvinceTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_Demographics_CityTitleFilterData", AV38BR_Demographics_CityTitleFilterData);
      }

      protected void E182M2( )
      {
         /* Ddo_br_demographics_marritalstatus_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_demographics_marritalstatus_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV10OrderedBy = 6;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_demographics_marritalstatus_Sortedstatus = "ASC";
            ucDdo_br_demographics_marritalstatus.SendProperty(context, "", false, Ddo_br_demographics_marritalstatus_Internalname, "SortedStatus", Ddo_br_demographics_marritalstatus_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_demographics_marritalstatus_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV10OrderedBy = 6;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_demographics_marritalstatus_Sortedstatus = "DSC";
            ucDdo_br_demographics_marritalstatus.SendProperty(context, "", false, Ddo_br_demographics_marritalstatus_Internalname, "SortedStatus", Ddo_br_demographics_marritalstatus_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12BR_Demographics_IDTitleFilterData", AV12BR_Demographics_IDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14BR_EncounterIDTitleFilterData", AV14BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18BR_Information_PatientNoTitleFilterData", AV18BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Demographics_BirthDateTitleFilterData", AV20BR_Demographics_BirthDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Demographics_SexTitleFilterData", AV24BR_Demographics_SexTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV26BR_Demographics_MarritalStatusTitleFilterData", AV26BR_Demographics_MarritalStatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Demographics_EthnicTitleFilterData", AV28BR_Demographics_EthnicTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30BR_Demographics_EducationTitleFilterData", AV30BR_Demographics_EducationTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Demographics_OccupationTitleFilterData", AV32BR_Demographics_OccupationTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34BR_Demographics_InsuranceTitleFilterData", AV34BR_Demographics_InsuranceTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36BR_Demographics_ProvinceTitleFilterData", AV36BR_Demographics_ProvinceTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_Demographics_CityTitleFilterData", AV38BR_Demographics_CityTitleFilterData);
      }

      protected void E192M2( )
      {
         /* Ddo_br_demographics_ethnic_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_demographics_ethnic_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV10OrderedBy = 7;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_demographics_ethnic_Sortedstatus = "ASC";
            ucDdo_br_demographics_ethnic.SendProperty(context, "", false, Ddo_br_demographics_ethnic_Internalname, "SortedStatus", Ddo_br_demographics_ethnic_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_demographics_ethnic_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV10OrderedBy = 7;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_demographics_ethnic_Sortedstatus = "DSC";
            ucDdo_br_demographics_ethnic.SendProperty(context, "", false, Ddo_br_demographics_ethnic_Internalname, "SortedStatus", Ddo_br_demographics_ethnic_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12BR_Demographics_IDTitleFilterData", AV12BR_Demographics_IDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14BR_EncounterIDTitleFilterData", AV14BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18BR_Information_PatientNoTitleFilterData", AV18BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Demographics_BirthDateTitleFilterData", AV20BR_Demographics_BirthDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Demographics_SexTitleFilterData", AV24BR_Demographics_SexTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV26BR_Demographics_MarritalStatusTitleFilterData", AV26BR_Demographics_MarritalStatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Demographics_EthnicTitleFilterData", AV28BR_Demographics_EthnicTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30BR_Demographics_EducationTitleFilterData", AV30BR_Demographics_EducationTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Demographics_OccupationTitleFilterData", AV32BR_Demographics_OccupationTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34BR_Demographics_InsuranceTitleFilterData", AV34BR_Demographics_InsuranceTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36BR_Demographics_ProvinceTitleFilterData", AV36BR_Demographics_ProvinceTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_Demographics_CityTitleFilterData", AV38BR_Demographics_CityTitleFilterData);
      }

      protected void E202M2( )
      {
         /* Ddo_br_demographics_education_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_demographics_education_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV10OrderedBy = 8;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_demographics_education_Sortedstatus = "ASC";
            ucDdo_br_demographics_education.SendProperty(context, "", false, Ddo_br_demographics_education_Internalname, "SortedStatus", Ddo_br_demographics_education_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_demographics_education_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV10OrderedBy = 8;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_demographics_education_Sortedstatus = "DSC";
            ucDdo_br_demographics_education.SendProperty(context, "", false, Ddo_br_demographics_education_Internalname, "SortedStatus", Ddo_br_demographics_education_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12BR_Demographics_IDTitleFilterData", AV12BR_Demographics_IDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14BR_EncounterIDTitleFilterData", AV14BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18BR_Information_PatientNoTitleFilterData", AV18BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Demographics_BirthDateTitleFilterData", AV20BR_Demographics_BirthDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Demographics_SexTitleFilterData", AV24BR_Demographics_SexTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV26BR_Demographics_MarritalStatusTitleFilterData", AV26BR_Demographics_MarritalStatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Demographics_EthnicTitleFilterData", AV28BR_Demographics_EthnicTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30BR_Demographics_EducationTitleFilterData", AV30BR_Demographics_EducationTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Demographics_OccupationTitleFilterData", AV32BR_Demographics_OccupationTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34BR_Demographics_InsuranceTitleFilterData", AV34BR_Demographics_InsuranceTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36BR_Demographics_ProvinceTitleFilterData", AV36BR_Demographics_ProvinceTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_Demographics_CityTitleFilterData", AV38BR_Demographics_CityTitleFilterData);
      }

      protected void E212M2( )
      {
         /* Ddo_br_demographics_occupation_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_demographics_occupation_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV10OrderedBy = 9;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_demographics_occupation_Sortedstatus = "ASC";
            ucDdo_br_demographics_occupation.SendProperty(context, "", false, Ddo_br_demographics_occupation_Internalname, "SortedStatus", Ddo_br_demographics_occupation_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_demographics_occupation_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV10OrderedBy = 9;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_demographics_occupation_Sortedstatus = "DSC";
            ucDdo_br_demographics_occupation.SendProperty(context, "", false, Ddo_br_demographics_occupation_Internalname, "SortedStatus", Ddo_br_demographics_occupation_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12BR_Demographics_IDTitleFilterData", AV12BR_Demographics_IDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14BR_EncounterIDTitleFilterData", AV14BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18BR_Information_PatientNoTitleFilterData", AV18BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Demographics_BirthDateTitleFilterData", AV20BR_Demographics_BirthDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Demographics_SexTitleFilterData", AV24BR_Demographics_SexTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV26BR_Demographics_MarritalStatusTitleFilterData", AV26BR_Demographics_MarritalStatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Demographics_EthnicTitleFilterData", AV28BR_Demographics_EthnicTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30BR_Demographics_EducationTitleFilterData", AV30BR_Demographics_EducationTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Demographics_OccupationTitleFilterData", AV32BR_Demographics_OccupationTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34BR_Demographics_InsuranceTitleFilterData", AV34BR_Demographics_InsuranceTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36BR_Demographics_ProvinceTitleFilterData", AV36BR_Demographics_ProvinceTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_Demographics_CityTitleFilterData", AV38BR_Demographics_CityTitleFilterData);
      }

      protected void E222M2( )
      {
         /* Ddo_br_demographics_insurance_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_demographics_insurance_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV10OrderedBy = 10;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_demographics_insurance_Sortedstatus = "ASC";
            ucDdo_br_demographics_insurance.SendProperty(context, "", false, Ddo_br_demographics_insurance_Internalname, "SortedStatus", Ddo_br_demographics_insurance_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_demographics_insurance_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV10OrderedBy = 10;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_demographics_insurance_Sortedstatus = "DSC";
            ucDdo_br_demographics_insurance.SendProperty(context, "", false, Ddo_br_demographics_insurance_Internalname, "SortedStatus", Ddo_br_demographics_insurance_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12BR_Demographics_IDTitleFilterData", AV12BR_Demographics_IDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14BR_EncounterIDTitleFilterData", AV14BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18BR_Information_PatientNoTitleFilterData", AV18BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Demographics_BirthDateTitleFilterData", AV20BR_Demographics_BirthDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Demographics_SexTitleFilterData", AV24BR_Demographics_SexTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV26BR_Demographics_MarritalStatusTitleFilterData", AV26BR_Demographics_MarritalStatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Demographics_EthnicTitleFilterData", AV28BR_Demographics_EthnicTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30BR_Demographics_EducationTitleFilterData", AV30BR_Demographics_EducationTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Demographics_OccupationTitleFilterData", AV32BR_Demographics_OccupationTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34BR_Demographics_InsuranceTitleFilterData", AV34BR_Demographics_InsuranceTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36BR_Demographics_ProvinceTitleFilterData", AV36BR_Demographics_ProvinceTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_Demographics_CityTitleFilterData", AV38BR_Demographics_CityTitleFilterData);
      }

      protected void E232M2( )
      {
         /* Ddo_br_demographics_province_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_demographics_province_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV10OrderedBy = 11;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_demographics_province_Sortedstatus = "ASC";
            ucDdo_br_demographics_province.SendProperty(context, "", false, Ddo_br_demographics_province_Internalname, "SortedStatus", Ddo_br_demographics_province_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_demographics_province_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV10OrderedBy = 11;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_demographics_province_Sortedstatus = "DSC";
            ucDdo_br_demographics_province.SendProperty(context, "", false, Ddo_br_demographics_province_Internalname, "SortedStatus", Ddo_br_demographics_province_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12BR_Demographics_IDTitleFilterData", AV12BR_Demographics_IDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14BR_EncounterIDTitleFilterData", AV14BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18BR_Information_PatientNoTitleFilterData", AV18BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Demographics_BirthDateTitleFilterData", AV20BR_Demographics_BirthDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Demographics_SexTitleFilterData", AV24BR_Demographics_SexTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV26BR_Demographics_MarritalStatusTitleFilterData", AV26BR_Demographics_MarritalStatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Demographics_EthnicTitleFilterData", AV28BR_Demographics_EthnicTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30BR_Demographics_EducationTitleFilterData", AV30BR_Demographics_EducationTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Demographics_OccupationTitleFilterData", AV32BR_Demographics_OccupationTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34BR_Demographics_InsuranceTitleFilterData", AV34BR_Demographics_InsuranceTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36BR_Demographics_ProvinceTitleFilterData", AV36BR_Demographics_ProvinceTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_Demographics_CityTitleFilterData", AV38BR_Demographics_CityTitleFilterData);
      }

      protected void E242M2( )
      {
         /* Ddo_br_demographics_city_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_demographics_city_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV10OrderedBy = 12;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_demographics_city_Sortedstatus = "ASC";
            ucDdo_br_demographics_city.SendProperty(context, "", false, Ddo_br_demographics_city_Internalname, "SortedStatus", Ddo_br_demographics_city_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_demographics_city_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV10OrderedBy = 12;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_demographics_city_Sortedstatus = "DSC";
            ucDdo_br_demographics_city.SendProperty(context, "", false, Ddo_br_demographics_city_Internalname, "SortedStatus", Ddo_br_demographics_city_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12BR_Demographics_IDTitleFilterData", AV12BR_Demographics_IDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14BR_EncounterIDTitleFilterData", AV14BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18BR_Information_PatientNoTitleFilterData", AV18BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Demographics_BirthDateTitleFilterData", AV20BR_Demographics_BirthDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Demographics_SexTitleFilterData", AV24BR_Demographics_SexTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV26BR_Demographics_MarritalStatusTitleFilterData", AV26BR_Demographics_MarritalStatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV28BR_Demographics_EthnicTitleFilterData", AV28BR_Demographics_EthnicTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV30BR_Demographics_EducationTitleFilterData", AV30BR_Demographics_EducationTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Demographics_OccupationTitleFilterData", AV32BR_Demographics_OccupationTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34BR_Demographics_InsuranceTitleFilterData", AV34BR_Demographics_InsuranceTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36BR_Demographics_ProvinceTitleFilterData", AV36BR_Demographics_ProvinceTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_Demographics_CityTitleFilterData", AV38BR_Demographics_CityTitleFilterData);
      }

      private void E272M2( )
      {
         /* Grid_Load Routine */
         AV45Select = context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavSelect_Internalname, AV45Select);
         AV49Select_GXI = GXDbFile.PathToUrl( context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( )));
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
         E282M2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E282M2( )
      {
         /* Enter Routine */
         AV8InOutBR_Demographics_ID = A61BR_Demographics_ID;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8InOutBR_Demographics_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8InOutBR_Demographics_ID), 18, 0)));
         context.setWebReturnParms(new Object[] {(long)AV8InOutBR_Demographics_ID});
         context.setWebReturnParmsMetadata(new Object[] {"AV8InOutBR_Demographics_ID"});
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
         AV8InOutBR_Demographics_ID = Convert.ToInt64(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8InOutBR_Demographics_ID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8InOutBR_Demographics_ID), 18, 0)));
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
         PA2M2( ) ;
         WS2M2( ) ;
         WE2M2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20202279401513", true);
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
         context.AddJavascriptSource("br_demographicsprompt.js", "?20202279401513", false);
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
         edtBR_Demographics_ID_Internalname = "BR_DEMOGRAPHICS_ID_"+sGXsfl_12_idx;
         edtBR_EncounterID_Internalname = "BR_ENCOUNTERID_"+sGXsfl_12_idx;
         edtBR_Information_PatientNo_Internalname = "BR_INFORMATION_PATIENTNO_"+sGXsfl_12_idx;
         edtBR_Demographics_BirthDate_Internalname = "BR_DEMOGRAPHICS_BIRTHDATE_"+sGXsfl_12_idx;
         edtBR_Demographics_Sex_Internalname = "BR_DEMOGRAPHICS_SEX_"+sGXsfl_12_idx;
         edtBR_Demographics_MarritalStatus_Internalname = "BR_DEMOGRAPHICS_MARRITALSTATUS_"+sGXsfl_12_idx;
         edtBR_Demographics_Ethnic_Internalname = "BR_DEMOGRAPHICS_ETHNIC_"+sGXsfl_12_idx;
         edtBR_Demographics_Education_Internalname = "BR_DEMOGRAPHICS_EDUCATION_"+sGXsfl_12_idx;
         edtBR_Demographics_Occupation_Internalname = "BR_DEMOGRAPHICS_OCCUPATION_"+sGXsfl_12_idx;
         edtBR_Demographics_Insurance_Internalname = "BR_DEMOGRAPHICS_INSURANCE_"+sGXsfl_12_idx;
         edtBR_Demographics_Province_Internalname = "BR_DEMOGRAPHICS_PROVINCE_"+sGXsfl_12_idx;
         edtBR_Demographics_City_Internalname = "BR_DEMOGRAPHICS_CITY_"+sGXsfl_12_idx;
      }

      protected void SubsflControlProps_fel_122( )
      {
         edtavSelect_Internalname = "vSELECT_"+sGXsfl_12_fel_idx;
         edtBR_Demographics_ID_Internalname = "BR_DEMOGRAPHICS_ID_"+sGXsfl_12_fel_idx;
         edtBR_EncounterID_Internalname = "BR_ENCOUNTERID_"+sGXsfl_12_fel_idx;
         edtBR_Information_PatientNo_Internalname = "BR_INFORMATION_PATIENTNO_"+sGXsfl_12_fel_idx;
         edtBR_Demographics_BirthDate_Internalname = "BR_DEMOGRAPHICS_BIRTHDATE_"+sGXsfl_12_fel_idx;
         edtBR_Demographics_Sex_Internalname = "BR_DEMOGRAPHICS_SEX_"+sGXsfl_12_fel_idx;
         edtBR_Demographics_MarritalStatus_Internalname = "BR_DEMOGRAPHICS_MARRITALSTATUS_"+sGXsfl_12_fel_idx;
         edtBR_Demographics_Ethnic_Internalname = "BR_DEMOGRAPHICS_ETHNIC_"+sGXsfl_12_fel_idx;
         edtBR_Demographics_Education_Internalname = "BR_DEMOGRAPHICS_EDUCATION_"+sGXsfl_12_fel_idx;
         edtBR_Demographics_Occupation_Internalname = "BR_DEMOGRAPHICS_OCCUPATION_"+sGXsfl_12_fel_idx;
         edtBR_Demographics_Insurance_Internalname = "BR_DEMOGRAPHICS_INSURANCE_"+sGXsfl_12_fel_idx;
         edtBR_Demographics_Province_Internalname = "BR_DEMOGRAPHICS_PROVINCE_"+sGXsfl_12_fel_idx;
         edtBR_Demographics_City_Internalname = "BR_DEMOGRAPHICS_CITY_"+sGXsfl_12_fel_idx;
      }

      protected void sendrow_122( )
      {
         SubsflControlProps_122( ) ;
         WB2M0( ) ;
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
            AV45Select_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV45Select))&&String.IsNullOrEmpty(StringUtil.RTrim( AV49Select_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV45Select)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV45Select)) ? AV49Select_GXI : context.PathToRelativeUrl( AV45Select));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavSelect_Internalname,(String)sImgUrl,(String)"",(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)edtavSelect_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)5,(String)edtavSelect_Jsonclick,"'"+""+"'"+",false,"+"'"+"EENTER."+sGXsfl_12_idx+"'",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)""+TempTags,(String)"",(String)"",(short)1,(bool)AV45Select_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Demographics_ID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A61BR_Demographics_ID), 18, 0, ".", "")),context.localUtil.Format( (decimal)(A61BR_Demographics_ID), "ZZZZZZZZZZZZZZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Demographics_ID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"ID",(String)"right",(bool)false});
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
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Demographics_BirthDate_Internalname,context.localUtil.Format(A53BR_Demographics_BirthDate, "9999/99/99"),context.localUtil.Format( A53BR_Demographics_BirthDate, "9999/99/99"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Demographics_BirthDate_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"DM_Date",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Demographics_Sex_Internalname,(String)A54BR_Demographics_Sex,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Demographics_Sex_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Demographics_MarritalStatus_Internalname,(String)A63BR_Demographics_MarritalStatus,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Demographics_MarritalStatus_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Demographics_Ethnic_Internalname,(String)A55BR_Demographics_Ethnic,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Demographics_Ethnic_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Demographics_Education_Internalname,(String)A56BR_Demographics_Education,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Demographics_Education_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Demographics_Occupation_Internalname,(String)A57BR_Demographics_Occupation,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Demographics_Occupation_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Demographics_Insurance_Internalname,(String)A58BR_Demographics_Insurance,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Demographics_Insurance_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Demographics_Province_Internalname,(String)A59BR_Demographics_Province,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Demographics_Province_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Demographics_City_Internalname,(String)A60BR_Demographics_City,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Demographics_City_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            send_integrity_lvl_hashes2M2( ) ;
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
         edtBR_Demographics_ID_Internalname = "BR_DEMOGRAPHICS_ID";
         edtBR_EncounterID_Internalname = "BR_ENCOUNTERID";
         edtBR_Information_PatientNo_Internalname = "BR_INFORMATION_PATIENTNO";
         edtBR_Demographics_BirthDate_Internalname = "BR_DEMOGRAPHICS_BIRTHDATE";
         edtBR_Demographics_Sex_Internalname = "BR_DEMOGRAPHICS_SEX";
         edtBR_Demographics_MarritalStatus_Internalname = "BR_DEMOGRAPHICS_MARRITALSTATUS";
         edtBR_Demographics_Ethnic_Internalname = "BR_DEMOGRAPHICS_ETHNIC";
         edtBR_Demographics_Education_Internalname = "BR_DEMOGRAPHICS_EDUCATION";
         edtBR_Demographics_Occupation_Internalname = "BR_DEMOGRAPHICS_OCCUPATION";
         edtBR_Demographics_Insurance_Internalname = "BR_DEMOGRAPHICS_INSURANCE";
         edtBR_Demographics_Province_Internalname = "BR_DEMOGRAPHICS_PROVINCE";
         edtBR_Demographics_City_Internalname = "BR_DEMOGRAPHICS_CITY";
         Gridpaginationbar_Internalname = "GRIDPAGINATIONBAR";
         divHtml_gridpaginationbar_Internalname = "HTML_GRIDPAGINATIONBAR";
         divGridtablewithpaginationbar_Internalname = "GRIDTABLEWITHPAGINATIONBAR";
         divTablemain_Internalname = "TABLEMAIN";
         Ddo_br_demographics_id_Internalname = "DDO_BR_DEMOGRAPHICS_ID";
         edtavDdo_br_demographics_idtitlecontrolidtoreplace_Internalname = "vDDO_BR_DEMOGRAPHICS_IDTITLECONTROLIDTOREPLACE";
         Ddo_br_encounterid_Internalname = "DDO_BR_ENCOUNTERID";
         edtavDdo_br_encounteridtitlecontrolidtoreplace_Internalname = "vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE";
         Ddo_br_information_patientno_Internalname = "DDO_BR_INFORMATION_PATIENTNO";
         edtavDdo_br_information_patientnotitlecontrolidtoreplace_Internalname = "vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE";
         Ddo_br_demographics_birthdate_Internalname = "DDO_BR_DEMOGRAPHICS_BIRTHDATE";
         edtavDdo_br_demographics_birthdatetitlecontrolidtoreplace_Internalname = "vDDO_BR_DEMOGRAPHICS_BIRTHDATETITLECONTROLIDTOREPLACE";
         Ddo_br_demographics_sex_Internalname = "DDO_BR_DEMOGRAPHICS_SEX";
         edtavDdo_br_demographics_sextitlecontrolidtoreplace_Internalname = "vDDO_BR_DEMOGRAPHICS_SEXTITLECONTROLIDTOREPLACE";
         Ddo_br_demographics_marritalstatus_Internalname = "DDO_BR_DEMOGRAPHICS_MARRITALSTATUS";
         edtavDdo_br_demographics_marritalstatustitlecontrolidtoreplace_Internalname = "vDDO_BR_DEMOGRAPHICS_MARRITALSTATUSTITLECONTROLIDTOREPLACE";
         Ddo_br_demographics_ethnic_Internalname = "DDO_BR_DEMOGRAPHICS_ETHNIC";
         edtavDdo_br_demographics_ethnictitlecontrolidtoreplace_Internalname = "vDDO_BR_DEMOGRAPHICS_ETHNICTITLECONTROLIDTOREPLACE";
         Ddo_br_demographics_education_Internalname = "DDO_BR_DEMOGRAPHICS_EDUCATION";
         edtavDdo_br_demographics_educationtitlecontrolidtoreplace_Internalname = "vDDO_BR_DEMOGRAPHICS_EDUCATIONTITLECONTROLIDTOREPLACE";
         Ddo_br_demographics_occupation_Internalname = "DDO_BR_DEMOGRAPHICS_OCCUPATION";
         edtavDdo_br_demographics_occupationtitlecontrolidtoreplace_Internalname = "vDDO_BR_DEMOGRAPHICS_OCCUPATIONTITLECONTROLIDTOREPLACE";
         Ddo_br_demographics_insurance_Internalname = "DDO_BR_DEMOGRAPHICS_INSURANCE";
         edtavDdo_br_demographics_insurancetitlecontrolidtoreplace_Internalname = "vDDO_BR_DEMOGRAPHICS_INSURANCETITLECONTROLIDTOREPLACE";
         Ddo_br_demographics_province_Internalname = "DDO_BR_DEMOGRAPHICS_PROVINCE";
         edtavDdo_br_demographics_provincetitlecontrolidtoreplace_Internalname = "vDDO_BR_DEMOGRAPHICS_PROVINCETITLECONTROLIDTOREPLACE";
         Ddo_br_demographics_city_Internalname = "DDO_BR_DEMOGRAPHICS_CITY";
         edtavDdo_br_demographics_citytitlecontrolidtoreplace_Internalname = "vDDO_BR_DEMOGRAPHICS_CITYTITLECONTROLIDTOREPLACE";
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
         edtBR_Demographics_City_Jsonclick = "";
         edtBR_Demographics_Province_Jsonclick = "";
         edtBR_Demographics_Insurance_Jsonclick = "";
         edtBR_Demographics_Occupation_Jsonclick = "";
         edtBR_Demographics_Education_Jsonclick = "";
         edtBR_Demographics_Ethnic_Jsonclick = "";
         edtBR_Demographics_MarritalStatus_Jsonclick = "";
         edtBR_Demographics_Sex_Jsonclick = "";
         edtBR_Demographics_BirthDate_Jsonclick = "";
         edtBR_Information_PatientNo_Jsonclick = "";
         edtBR_EncounterID_Jsonclick = "";
         edtBR_Demographics_ID_Jsonclick = "";
         edtavSelect_Jsonclick = "";
         edtavSelect_Visible = -1;
         edtavSelect_Enabled = 1;
         edtavOrdereddsc_Jsonclick = "";
         edtavOrdereddsc_Visible = 1;
         edtavOrderedby_Jsonclick = "";
         edtavOrderedby_Visible = 1;
         edtavDdo_br_demographics_citytitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_demographics_provincetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_demographics_insurancetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_demographics_occupationtitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_demographics_educationtitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_demographics_ethnictitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_demographics_marritalstatustitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_demographics_sextitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_demographics_birthdatetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_information_patientnotitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_encounteridtitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_demographics_idtitlecontrolidtoreplace_Visible = 1;
         subGrid_Allowcollapsing = 0;
         subGrid_Allowselection = 0;
         edtavSelect_Tooltiptext = "选择";
         subGrid_Sortable = 0;
         subGrid_Header = "";
         edtBR_Demographics_City_Titleformat = 0;
         edtBR_Demographics_City_Title = "市";
         edtBR_Demographics_Province_Titleformat = 0;
         edtBR_Demographics_Province_Title = "省";
         edtBR_Demographics_Insurance_Titleformat = 0;
         edtBR_Demographics_Insurance_Title = "保险类型";
         edtBR_Demographics_Occupation_Titleformat = 0;
         edtBR_Demographics_Occupation_Title = "职业";
         edtBR_Demographics_Education_Titleformat = 0;
         edtBR_Demographics_Education_Title = "学历";
         edtBR_Demographics_Ethnic_Titleformat = 0;
         edtBR_Demographics_Ethnic_Title = "民族";
         edtBR_Demographics_MarritalStatus_Titleformat = 0;
         edtBR_Demographics_MarritalStatus_Title = "婚姻状态";
         edtBR_Demographics_Sex_Titleformat = 0;
         edtBR_Demographics_Sex_Title = "性别";
         edtBR_Demographics_BirthDate_Titleformat = 0;
         edtBR_Demographics_BirthDate_Title = "出生日期";
         edtBR_Information_PatientNo_Titleformat = 0;
         edtBR_Information_PatientNo_Title = "患者编号";
         edtBR_EncounterID_Titleformat = 0;
         edtBR_EncounterID_Title = "就诊信息主键";
         edtBR_Demographics_ID_Titleformat = 0;
         edtBR_Demographics_ID_Title = "人口信息学主键";
         subGrid_Class = "GridWithPaginationBar GridWithBorderColor WorkWith";
         subGrid_Backcolorstyle = 0;
         divTablemain_Height = 0;
         Ddo_br_demographics_city_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_demographics_city_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_demographics_city_Sortasc = "WWP_TSSortASC";
         Ddo_br_demographics_city_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_demographics_city_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_demographics_city_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_demographics_city_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_demographics_city_Titlecontrolidtoreplace = "";
         Ddo_br_demographics_city_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_demographics_city_Cls = "ColumnSettings";
         Ddo_br_demographics_city_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_demographics_city_Caption = "";
         Ddo_br_demographics_province_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_demographics_province_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_demographics_province_Sortasc = "WWP_TSSortASC";
         Ddo_br_demographics_province_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_demographics_province_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_demographics_province_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_demographics_province_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_demographics_province_Titlecontrolidtoreplace = "";
         Ddo_br_demographics_province_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_demographics_province_Cls = "ColumnSettings";
         Ddo_br_demographics_province_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_demographics_province_Caption = "";
         Ddo_br_demographics_insurance_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_demographics_insurance_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_demographics_insurance_Sortasc = "WWP_TSSortASC";
         Ddo_br_demographics_insurance_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_demographics_insurance_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_demographics_insurance_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_demographics_insurance_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_demographics_insurance_Titlecontrolidtoreplace = "";
         Ddo_br_demographics_insurance_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_demographics_insurance_Cls = "ColumnSettings";
         Ddo_br_demographics_insurance_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_demographics_insurance_Caption = "";
         Ddo_br_demographics_occupation_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_demographics_occupation_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_demographics_occupation_Sortasc = "WWP_TSSortASC";
         Ddo_br_demographics_occupation_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_demographics_occupation_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_demographics_occupation_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_demographics_occupation_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_demographics_occupation_Titlecontrolidtoreplace = "";
         Ddo_br_demographics_occupation_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_demographics_occupation_Cls = "ColumnSettings";
         Ddo_br_demographics_occupation_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_demographics_occupation_Caption = "";
         Ddo_br_demographics_education_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_demographics_education_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_demographics_education_Sortasc = "WWP_TSSortASC";
         Ddo_br_demographics_education_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_demographics_education_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_demographics_education_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_demographics_education_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_demographics_education_Titlecontrolidtoreplace = "";
         Ddo_br_demographics_education_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_demographics_education_Cls = "ColumnSettings";
         Ddo_br_demographics_education_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_demographics_education_Caption = "";
         Ddo_br_demographics_ethnic_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_demographics_ethnic_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_demographics_ethnic_Sortasc = "WWP_TSSortASC";
         Ddo_br_demographics_ethnic_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_demographics_ethnic_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_demographics_ethnic_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_demographics_ethnic_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_demographics_ethnic_Titlecontrolidtoreplace = "";
         Ddo_br_demographics_ethnic_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_demographics_ethnic_Cls = "ColumnSettings";
         Ddo_br_demographics_ethnic_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_demographics_ethnic_Caption = "";
         Ddo_br_demographics_marritalstatus_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_demographics_marritalstatus_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_demographics_marritalstatus_Sortasc = "WWP_TSSortASC";
         Ddo_br_demographics_marritalstatus_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_demographics_marritalstatus_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_demographics_marritalstatus_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_demographics_marritalstatus_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_demographics_marritalstatus_Titlecontrolidtoreplace = "";
         Ddo_br_demographics_marritalstatus_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_demographics_marritalstatus_Cls = "ColumnSettings";
         Ddo_br_demographics_marritalstatus_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_demographics_marritalstatus_Caption = "";
         Ddo_br_demographics_sex_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_demographics_sex_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_demographics_sex_Sortasc = "WWP_TSSortASC";
         Ddo_br_demographics_sex_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_demographics_sex_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_demographics_sex_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_demographics_sex_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_demographics_sex_Titlecontrolidtoreplace = "";
         Ddo_br_demographics_sex_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_demographics_sex_Cls = "ColumnSettings";
         Ddo_br_demographics_sex_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_demographics_sex_Caption = "";
         Ddo_br_demographics_birthdate_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_demographics_birthdate_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_demographics_birthdate_Sortasc = "WWP_TSSortASC";
         Ddo_br_demographics_birthdate_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_demographics_birthdate_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_demographics_birthdate_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_demographics_birthdate_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_demographics_birthdate_Titlecontrolidtoreplace = "";
         Ddo_br_demographics_birthdate_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_demographics_birthdate_Cls = "ColumnSettings";
         Ddo_br_demographics_birthdate_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_demographics_birthdate_Caption = "";
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
         Ddo_br_demographics_id_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_demographics_id_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_demographics_id_Sortasc = "WWP_TSSortASC";
         Ddo_br_demographics_id_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_demographics_id_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_demographics_id_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_demographics_id_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_demographics_id_Titlecontrolidtoreplace = "";
         Ddo_br_demographics_id_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_demographics_id_Cls = "ColumnSettings";
         Ddo_br_demographics_id_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_demographics_id_Caption = "";
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
         Form.Caption = "选择人口信息学";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_Demographics_IDTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_IDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Demographics_BirthDateTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_BIRTHDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Demographics_SexTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_SEXTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Demographics_MarritalStatusTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_MARRITALSTATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_BR_Demographics_EthnicTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_ETHNICTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Demographics_EducationTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_EDUCATIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Demographics_OccupationTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_OCCUPATIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Demographics_InsuranceTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_INSURANCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Demographics_ProvinceTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_PROVINCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Demographics_CityTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_CITYTITLECONTROLIDTOREPLACE',pic:''},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]");
         setEventMetadata("REFRESH",",oparms:[{av:'AV12BR_Demographics_IDTitleFilterData',fld:'vBR_DEMOGRAPHICS_IDTITLEFILTERDATA',pic:''},{av:'AV14BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV18BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV20BR_Demographics_BirthDateTitleFilterData',fld:'vBR_DEMOGRAPHICS_BIRTHDATETITLEFILTERDATA',pic:''},{av:'AV24BR_Demographics_SexTitleFilterData',fld:'vBR_DEMOGRAPHICS_SEXTITLEFILTERDATA',pic:''},{av:'AV26BR_Demographics_MarritalStatusTitleFilterData',fld:'vBR_DEMOGRAPHICS_MARRITALSTATUSTITLEFILTERDATA',pic:''},{av:'AV28BR_Demographics_EthnicTitleFilterData',fld:'vBR_DEMOGRAPHICS_ETHNICTITLEFILTERDATA',pic:''},{av:'AV30BR_Demographics_EducationTitleFilterData',fld:'vBR_DEMOGRAPHICS_EDUCATIONTITLEFILTERDATA',pic:''},{av:'AV32BR_Demographics_OccupationTitleFilterData',fld:'vBR_DEMOGRAPHICS_OCCUPATIONTITLEFILTERDATA',pic:''},{av:'AV34BR_Demographics_InsuranceTitleFilterData',fld:'vBR_DEMOGRAPHICS_INSURANCETITLEFILTERDATA',pic:''},{av:'AV36BR_Demographics_ProvinceTitleFilterData',fld:'vBR_DEMOGRAPHICS_PROVINCETITLEFILTERDATA',pic:''},{av:'AV38BR_Demographics_CityTitleFilterData',fld:'vBR_DEMOGRAPHICS_CITYTITLEFILTERDATA',pic:''},{av:'edtBR_Demographics_ID_Titleformat',ctrl:'BR_DEMOGRAPHICS_ID',prop:'Titleformat'},{av:'edtBR_Demographics_ID_Title',ctrl:'BR_DEMOGRAPHICS_ID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Demographics_BirthDate_Titleformat',ctrl:'BR_DEMOGRAPHICS_BIRTHDATE',prop:'Titleformat'},{av:'edtBR_Demographics_BirthDate_Title',ctrl:'BR_DEMOGRAPHICS_BIRTHDATE',prop:'Title'},{av:'edtBR_Demographics_Sex_Titleformat',ctrl:'BR_DEMOGRAPHICS_SEX',prop:'Titleformat'},{av:'edtBR_Demographics_Sex_Title',ctrl:'BR_DEMOGRAPHICS_SEX',prop:'Title'},{av:'edtBR_Demographics_MarritalStatus_Titleformat',ctrl:'BR_DEMOGRAPHICS_MARRITALSTATUS',prop:'Titleformat'},{av:'edtBR_Demographics_MarritalStatus_Title',ctrl:'BR_DEMOGRAPHICS_MARRITALSTATUS',prop:'Title'},{av:'edtBR_Demographics_Ethnic_Titleformat',ctrl:'BR_DEMOGRAPHICS_ETHNIC',prop:'Titleformat'},{av:'edtBR_Demographics_Ethnic_Title',ctrl:'BR_DEMOGRAPHICS_ETHNIC',prop:'Title'},{av:'edtBR_Demographics_Education_Titleformat',ctrl:'BR_DEMOGRAPHICS_EDUCATION',prop:'Titleformat'},{av:'edtBR_Demographics_Education_Title',ctrl:'BR_DEMOGRAPHICS_EDUCATION',prop:'Title'},{av:'edtBR_Demographics_Occupation_Titleformat',ctrl:'BR_DEMOGRAPHICS_OCCUPATION',prop:'Titleformat'},{av:'edtBR_Demographics_Occupation_Title',ctrl:'BR_DEMOGRAPHICS_OCCUPATION',prop:'Title'},{av:'edtBR_Demographics_Insurance_Titleformat',ctrl:'BR_DEMOGRAPHICS_INSURANCE',prop:'Titleformat'},{av:'edtBR_Demographics_Insurance_Title',ctrl:'BR_DEMOGRAPHICS_INSURANCE',prop:'Title'},{av:'edtBR_Demographics_Province_Titleformat',ctrl:'BR_DEMOGRAPHICS_PROVINCE',prop:'Titleformat'},{av:'edtBR_Demographics_Province_Title',ctrl:'BR_DEMOGRAPHICS_PROVINCE',prop:'Title'},{av:'edtBR_Demographics_City_Titleformat',ctrl:'BR_DEMOGRAPHICS_CITY',prop:'Titleformat'},{av:'edtBR_Demographics_City_Title',ctrl:'BR_DEMOGRAPHICS_CITY',prop:'Title'},{av:'AV42GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV43GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV44GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE","{handler:'E112M2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_Demographics_IDTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_IDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Demographics_BirthDateTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_BIRTHDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Demographics_SexTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_SEXTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Demographics_MarritalStatusTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_MARRITALSTATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_BR_Demographics_EthnicTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_ETHNICTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Demographics_EducationTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_EDUCATIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Demographics_OccupationTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_OCCUPATIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Demographics_InsuranceTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_INSURANCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Demographics_ProvinceTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_PROVINCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Demographics_CityTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_CITYTITLECONTROLIDTOREPLACE',pic:''},{av:'Gridpaginationbar_Selectedpage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE",",oparms:[]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE","{handler:'E122M2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_Demographics_IDTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_IDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Demographics_BirthDateTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_BIRTHDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Demographics_SexTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_SEXTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Demographics_MarritalStatusTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_MARRITALSTATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_BR_Demographics_EthnicTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_ETHNICTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Demographics_EducationTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_EDUCATIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Demographics_OccupationTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_OCCUPATIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Demographics_InsuranceTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_INSURANCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Demographics_ProvinceTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_PROVINCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Demographics_CityTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_CITYTITLECONTROLIDTOREPLACE',pic:''},{av:'Gridpaginationbar_Rowsperpageselectedvalue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE",",oparms:[{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]}");
         setEventMetadata("DDO_BR_DEMOGRAPHICS_ID.ONOPTIONCLICKED","{handler:'E132M2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_Demographics_IDTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_IDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Demographics_BirthDateTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_BIRTHDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Demographics_SexTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_SEXTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Demographics_MarritalStatusTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_MARRITALSTATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_BR_Demographics_EthnicTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_ETHNICTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Demographics_EducationTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_EDUCATIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Demographics_OccupationTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_OCCUPATIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Demographics_InsuranceTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_INSURANCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Demographics_ProvinceTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_PROVINCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Demographics_CityTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_CITYTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_demographics_id_Activeeventkey',ctrl:'DDO_BR_DEMOGRAPHICS_ID',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_DEMOGRAPHICS_ID.ONOPTIONCLICKED",",oparms:[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_demographics_id_Sortedstatus',ctrl:'DDO_BR_DEMOGRAPHICS_ID',prop:'SortedStatus'},{av:'AV12BR_Demographics_IDTitleFilterData',fld:'vBR_DEMOGRAPHICS_IDTITLEFILTERDATA',pic:''},{av:'AV14BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV18BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV20BR_Demographics_BirthDateTitleFilterData',fld:'vBR_DEMOGRAPHICS_BIRTHDATETITLEFILTERDATA',pic:''},{av:'AV24BR_Demographics_SexTitleFilterData',fld:'vBR_DEMOGRAPHICS_SEXTITLEFILTERDATA',pic:''},{av:'AV26BR_Demographics_MarritalStatusTitleFilterData',fld:'vBR_DEMOGRAPHICS_MARRITALSTATUSTITLEFILTERDATA',pic:''},{av:'AV28BR_Demographics_EthnicTitleFilterData',fld:'vBR_DEMOGRAPHICS_ETHNICTITLEFILTERDATA',pic:''},{av:'AV30BR_Demographics_EducationTitleFilterData',fld:'vBR_DEMOGRAPHICS_EDUCATIONTITLEFILTERDATA',pic:''},{av:'AV32BR_Demographics_OccupationTitleFilterData',fld:'vBR_DEMOGRAPHICS_OCCUPATIONTITLEFILTERDATA',pic:''},{av:'AV34BR_Demographics_InsuranceTitleFilterData',fld:'vBR_DEMOGRAPHICS_INSURANCETITLEFILTERDATA',pic:''},{av:'AV36BR_Demographics_ProvinceTitleFilterData',fld:'vBR_DEMOGRAPHICS_PROVINCETITLEFILTERDATA',pic:''},{av:'AV38BR_Demographics_CityTitleFilterData',fld:'vBR_DEMOGRAPHICS_CITYTITLEFILTERDATA',pic:''},{av:'edtBR_Demographics_ID_Titleformat',ctrl:'BR_DEMOGRAPHICS_ID',prop:'Titleformat'},{av:'edtBR_Demographics_ID_Title',ctrl:'BR_DEMOGRAPHICS_ID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Demographics_BirthDate_Titleformat',ctrl:'BR_DEMOGRAPHICS_BIRTHDATE',prop:'Titleformat'},{av:'edtBR_Demographics_BirthDate_Title',ctrl:'BR_DEMOGRAPHICS_BIRTHDATE',prop:'Title'},{av:'edtBR_Demographics_Sex_Titleformat',ctrl:'BR_DEMOGRAPHICS_SEX',prop:'Titleformat'},{av:'edtBR_Demographics_Sex_Title',ctrl:'BR_DEMOGRAPHICS_SEX',prop:'Title'},{av:'edtBR_Demographics_MarritalStatus_Titleformat',ctrl:'BR_DEMOGRAPHICS_MARRITALSTATUS',prop:'Titleformat'},{av:'edtBR_Demographics_MarritalStatus_Title',ctrl:'BR_DEMOGRAPHICS_MARRITALSTATUS',prop:'Title'},{av:'edtBR_Demographics_Ethnic_Titleformat',ctrl:'BR_DEMOGRAPHICS_ETHNIC',prop:'Titleformat'},{av:'edtBR_Demographics_Ethnic_Title',ctrl:'BR_DEMOGRAPHICS_ETHNIC',prop:'Title'},{av:'edtBR_Demographics_Education_Titleformat',ctrl:'BR_DEMOGRAPHICS_EDUCATION',prop:'Titleformat'},{av:'edtBR_Demographics_Education_Title',ctrl:'BR_DEMOGRAPHICS_EDUCATION',prop:'Title'},{av:'edtBR_Demographics_Occupation_Titleformat',ctrl:'BR_DEMOGRAPHICS_OCCUPATION',prop:'Titleformat'},{av:'edtBR_Demographics_Occupation_Title',ctrl:'BR_DEMOGRAPHICS_OCCUPATION',prop:'Title'},{av:'edtBR_Demographics_Insurance_Titleformat',ctrl:'BR_DEMOGRAPHICS_INSURANCE',prop:'Titleformat'},{av:'edtBR_Demographics_Insurance_Title',ctrl:'BR_DEMOGRAPHICS_INSURANCE',prop:'Title'},{av:'edtBR_Demographics_Province_Titleformat',ctrl:'BR_DEMOGRAPHICS_PROVINCE',prop:'Titleformat'},{av:'edtBR_Demographics_Province_Title',ctrl:'BR_DEMOGRAPHICS_PROVINCE',prop:'Title'},{av:'edtBR_Demographics_City_Titleformat',ctrl:'BR_DEMOGRAPHICS_CITY',prop:'Titleformat'},{av:'edtBR_Demographics_City_Title',ctrl:'BR_DEMOGRAPHICS_CITY',prop:'Title'},{av:'AV42GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV43GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV44GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_ENCOUNTERID.ONOPTIONCLICKED","{handler:'E142M2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_Demographics_IDTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_IDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Demographics_BirthDateTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_BIRTHDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Demographics_SexTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_SEXTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Demographics_MarritalStatusTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_MARRITALSTATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_BR_Demographics_EthnicTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_ETHNICTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Demographics_EducationTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_EDUCATIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Demographics_OccupationTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_OCCUPATIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Demographics_InsuranceTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_INSURANCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Demographics_ProvinceTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_PROVINCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Demographics_CityTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_CITYTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_encounterid_Activeeventkey',ctrl:'DDO_BR_ENCOUNTERID',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_ENCOUNTERID.ONOPTIONCLICKED",",oparms:[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_encounterid_Sortedstatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'AV12BR_Demographics_IDTitleFilterData',fld:'vBR_DEMOGRAPHICS_IDTITLEFILTERDATA',pic:''},{av:'AV14BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV18BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV20BR_Demographics_BirthDateTitleFilterData',fld:'vBR_DEMOGRAPHICS_BIRTHDATETITLEFILTERDATA',pic:''},{av:'AV24BR_Demographics_SexTitleFilterData',fld:'vBR_DEMOGRAPHICS_SEXTITLEFILTERDATA',pic:''},{av:'AV26BR_Demographics_MarritalStatusTitleFilterData',fld:'vBR_DEMOGRAPHICS_MARRITALSTATUSTITLEFILTERDATA',pic:''},{av:'AV28BR_Demographics_EthnicTitleFilterData',fld:'vBR_DEMOGRAPHICS_ETHNICTITLEFILTERDATA',pic:''},{av:'AV30BR_Demographics_EducationTitleFilterData',fld:'vBR_DEMOGRAPHICS_EDUCATIONTITLEFILTERDATA',pic:''},{av:'AV32BR_Demographics_OccupationTitleFilterData',fld:'vBR_DEMOGRAPHICS_OCCUPATIONTITLEFILTERDATA',pic:''},{av:'AV34BR_Demographics_InsuranceTitleFilterData',fld:'vBR_DEMOGRAPHICS_INSURANCETITLEFILTERDATA',pic:''},{av:'AV36BR_Demographics_ProvinceTitleFilterData',fld:'vBR_DEMOGRAPHICS_PROVINCETITLEFILTERDATA',pic:''},{av:'AV38BR_Demographics_CityTitleFilterData',fld:'vBR_DEMOGRAPHICS_CITYTITLEFILTERDATA',pic:''},{av:'edtBR_Demographics_ID_Titleformat',ctrl:'BR_DEMOGRAPHICS_ID',prop:'Titleformat'},{av:'edtBR_Demographics_ID_Title',ctrl:'BR_DEMOGRAPHICS_ID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Demographics_BirthDate_Titleformat',ctrl:'BR_DEMOGRAPHICS_BIRTHDATE',prop:'Titleformat'},{av:'edtBR_Demographics_BirthDate_Title',ctrl:'BR_DEMOGRAPHICS_BIRTHDATE',prop:'Title'},{av:'edtBR_Demographics_Sex_Titleformat',ctrl:'BR_DEMOGRAPHICS_SEX',prop:'Titleformat'},{av:'edtBR_Demographics_Sex_Title',ctrl:'BR_DEMOGRAPHICS_SEX',prop:'Title'},{av:'edtBR_Demographics_MarritalStatus_Titleformat',ctrl:'BR_DEMOGRAPHICS_MARRITALSTATUS',prop:'Titleformat'},{av:'edtBR_Demographics_MarritalStatus_Title',ctrl:'BR_DEMOGRAPHICS_MARRITALSTATUS',prop:'Title'},{av:'edtBR_Demographics_Ethnic_Titleformat',ctrl:'BR_DEMOGRAPHICS_ETHNIC',prop:'Titleformat'},{av:'edtBR_Demographics_Ethnic_Title',ctrl:'BR_DEMOGRAPHICS_ETHNIC',prop:'Title'},{av:'edtBR_Demographics_Education_Titleformat',ctrl:'BR_DEMOGRAPHICS_EDUCATION',prop:'Titleformat'},{av:'edtBR_Demographics_Education_Title',ctrl:'BR_DEMOGRAPHICS_EDUCATION',prop:'Title'},{av:'edtBR_Demographics_Occupation_Titleformat',ctrl:'BR_DEMOGRAPHICS_OCCUPATION',prop:'Titleformat'},{av:'edtBR_Demographics_Occupation_Title',ctrl:'BR_DEMOGRAPHICS_OCCUPATION',prop:'Title'},{av:'edtBR_Demographics_Insurance_Titleformat',ctrl:'BR_DEMOGRAPHICS_INSURANCE',prop:'Titleformat'},{av:'edtBR_Demographics_Insurance_Title',ctrl:'BR_DEMOGRAPHICS_INSURANCE',prop:'Title'},{av:'edtBR_Demographics_Province_Titleformat',ctrl:'BR_DEMOGRAPHICS_PROVINCE',prop:'Titleformat'},{av:'edtBR_Demographics_Province_Title',ctrl:'BR_DEMOGRAPHICS_PROVINCE',prop:'Title'},{av:'edtBR_Demographics_City_Titleformat',ctrl:'BR_DEMOGRAPHICS_CITY',prop:'Titleformat'},{av:'edtBR_Demographics_City_Title',ctrl:'BR_DEMOGRAPHICS_CITY',prop:'Title'},{av:'AV42GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV43GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV44GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_INFORMATION_PATIENTNO.ONOPTIONCLICKED","{handler:'E152M2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_Demographics_IDTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_IDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Demographics_BirthDateTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_BIRTHDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Demographics_SexTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_SEXTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Demographics_MarritalStatusTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_MARRITALSTATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_BR_Demographics_EthnicTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_ETHNICTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Demographics_EducationTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_EDUCATIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Demographics_OccupationTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_OCCUPATIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Demographics_InsuranceTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_INSURANCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Demographics_ProvinceTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_PROVINCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Demographics_CityTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_CITYTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_information_patientno_Activeeventkey',ctrl:'DDO_BR_INFORMATION_PATIENTNO',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_INFORMATION_PATIENTNO.ONOPTIONCLICKED",",oparms:[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_information_patientno_Sortedstatus',ctrl:'DDO_BR_INFORMATION_PATIENTNO',prop:'SortedStatus'},{av:'AV12BR_Demographics_IDTitleFilterData',fld:'vBR_DEMOGRAPHICS_IDTITLEFILTERDATA',pic:''},{av:'AV14BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV18BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV20BR_Demographics_BirthDateTitleFilterData',fld:'vBR_DEMOGRAPHICS_BIRTHDATETITLEFILTERDATA',pic:''},{av:'AV24BR_Demographics_SexTitleFilterData',fld:'vBR_DEMOGRAPHICS_SEXTITLEFILTERDATA',pic:''},{av:'AV26BR_Demographics_MarritalStatusTitleFilterData',fld:'vBR_DEMOGRAPHICS_MARRITALSTATUSTITLEFILTERDATA',pic:''},{av:'AV28BR_Demographics_EthnicTitleFilterData',fld:'vBR_DEMOGRAPHICS_ETHNICTITLEFILTERDATA',pic:''},{av:'AV30BR_Demographics_EducationTitleFilterData',fld:'vBR_DEMOGRAPHICS_EDUCATIONTITLEFILTERDATA',pic:''},{av:'AV32BR_Demographics_OccupationTitleFilterData',fld:'vBR_DEMOGRAPHICS_OCCUPATIONTITLEFILTERDATA',pic:''},{av:'AV34BR_Demographics_InsuranceTitleFilterData',fld:'vBR_DEMOGRAPHICS_INSURANCETITLEFILTERDATA',pic:''},{av:'AV36BR_Demographics_ProvinceTitleFilterData',fld:'vBR_DEMOGRAPHICS_PROVINCETITLEFILTERDATA',pic:''},{av:'AV38BR_Demographics_CityTitleFilterData',fld:'vBR_DEMOGRAPHICS_CITYTITLEFILTERDATA',pic:''},{av:'edtBR_Demographics_ID_Titleformat',ctrl:'BR_DEMOGRAPHICS_ID',prop:'Titleformat'},{av:'edtBR_Demographics_ID_Title',ctrl:'BR_DEMOGRAPHICS_ID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Demographics_BirthDate_Titleformat',ctrl:'BR_DEMOGRAPHICS_BIRTHDATE',prop:'Titleformat'},{av:'edtBR_Demographics_BirthDate_Title',ctrl:'BR_DEMOGRAPHICS_BIRTHDATE',prop:'Title'},{av:'edtBR_Demographics_Sex_Titleformat',ctrl:'BR_DEMOGRAPHICS_SEX',prop:'Titleformat'},{av:'edtBR_Demographics_Sex_Title',ctrl:'BR_DEMOGRAPHICS_SEX',prop:'Title'},{av:'edtBR_Demographics_MarritalStatus_Titleformat',ctrl:'BR_DEMOGRAPHICS_MARRITALSTATUS',prop:'Titleformat'},{av:'edtBR_Demographics_MarritalStatus_Title',ctrl:'BR_DEMOGRAPHICS_MARRITALSTATUS',prop:'Title'},{av:'edtBR_Demographics_Ethnic_Titleformat',ctrl:'BR_DEMOGRAPHICS_ETHNIC',prop:'Titleformat'},{av:'edtBR_Demographics_Ethnic_Title',ctrl:'BR_DEMOGRAPHICS_ETHNIC',prop:'Title'},{av:'edtBR_Demographics_Education_Titleformat',ctrl:'BR_DEMOGRAPHICS_EDUCATION',prop:'Titleformat'},{av:'edtBR_Demographics_Education_Title',ctrl:'BR_DEMOGRAPHICS_EDUCATION',prop:'Title'},{av:'edtBR_Demographics_Occupation_Titleformat',ctrl:'BR_DEMOGRAPHICS_OCCUPATION',prop:'Titleformat'},{av:'edtBR_Demographics_Occupation_Title',ctrl:'BR_DEMOGRAPHICS_OCCUPATION',prop:'Title'},{av:'edtBR_Demographics_Insurance_Titleformat',ctrl:'BR_DEMOGRAPHICS_INSURANCE',prop:'Titleformat'},{av:'edtBR_Demographics_Insurance_Title',ctrl:'BR_DEMOGRAPHICS_INSURANCE',prop:'Title'},{av:'edtBR_Demographics_Province_Titleformat',ctrl:'BR_DEMOGRAPHICS_PROVINCE',prop:'Titleformat'},{av:'edtBR_Demographics_Province_Title',ctrl:'BR_DEMOGRAPHICS_PROVINCE',prop:'Title'},{av:'edtBR_Demographics_City_Titleformat',ctrl:'BR_DEMOGRAPHICS_CITY',prop:'Titleformat'},{av:'edtBR_Demographics_City_Title',ctrl:'BR_DEMOGRAPHICS_CITY',prop:'Title'},{av:'AV42GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV43GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV44GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_DEMOGRAPHICS_BIRTHDATE.ONOPTIONCLICKED","{handler:'E162M2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_Demographics_IDTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_IDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Demographics_BirthDateTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_BIRTHDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Demographics_SexTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_SEXTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Demographics_MarritalStatusTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_MARRITALSTATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_BR_Demographics_EthnicTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_ETHNICTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Demographics_EducationTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_EDUCATIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Demographics_OccupationTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_OCCUPATIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Demographics_InsuranceTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_INSURANCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Demographics_ProvinceTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_PROVINCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Demographics_CityTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_CITYTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_demographics_birthdate_Activeeventkey',ctrl:'DDO_BR_DEMOGRAPHICS_BIRTHDATE',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_DEMOGRAPHICS_BIRTHDATE.ONOPTIONCLICKED",",oparms:[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_demographics_birthdate_Sortedstatus',ctrl:'DDO_BR_DEMOGRAPHICS_BIRTHDATE',prop:'SortedStatus'},{av:'AV12BR_Demographics_IDTitleFilterData',fld:'vBR_DEMOGRAPHICS_IDTITLEFILTERDATA',pic:''},{av:'AV14BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV18BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV20BR_Demographics_BirthDateTitleFilterData',fld:'vBR_DEMOGRAPHICS_BIRTHDATETITLEFILTERDATA',pic:''},{av:'AV24BR_Demographics_SexTitleFilterData',fld:'vBR_DEMOGRAPHICS_SEXTITLEFILTERDATA',pic:''},{av:'AV26BR_Demographics_MarritalStatusTitleFilterData',fld:'vBR_DEMOGRAPHICS_MARRITALSTATUSTITLEFILTERDATA',pic:''},{av:'AV28BR_Demographics_EthnicTitleFilterData',fld:'vBR_DEMOGRAPHICS_ETHNICTITLEFILTERDATA',pic:''},{av:'AV30BR_Demographics_EducationTitleFilterData',fld:'vBR_DEMOGRAPHICS_EDUCATIONTITLEFILTERDATA',pic:''},{av:'AV32BR_Demographics_OccupationTitleFilterData',fld:'vBR_DEMOGRAPHICS_OCCUPATIONTITLEFILTERDATA',pic:''},{av:'AV34BR_Demographics_InsuranceTitleFilterData',fld:'vBR_DEMOGRAPHICS_INSURANCETITLEFILTERDATA',pic:''},{av:'AV36BR_Demographics_ProvinceTitleFilterData',fld:'vBR_DEMOGRAPHICS_PROVINCETITLEFILTERDATA',pic:''},{av:'AV38BR_Demographics_CityTitleFilterData',fld:'vBR_DEMOGRAPHICS_CITYTITLEFILTERDATA',pic:''},{av:'edtBR_Demographics_ID_Titleformat',ctrl:'BR_DEMOGRAPHICS_ID',prop:'Titleformat'},{av:'edtBR_Demographics_ID_Title',ctrl:'BR_DEMOGRAPHICS_ID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Demographics_BirthDate_Titleformat',ctrl:'BR_DEMOGRAPHICS_BIRTHDATE',prop:'Titleformat'},{av:'edtBR_Demographics_BirthDate_Title',ctrl:'BR_DEMOGRAPHICS_BIRTHDATE',prop:'Title'},{av:'edtBR_Demographics_Sex_Titleformat',ctrl:'BR_DEMOGRAPHICS_SEX',prop:'Titleformat'},{av:'edtBR_Demographics_Sex_Title',ctrl:'BR_DEMOGRAPHICS_SEX',prop:'Title'},{av:'edtBR_Demographics_MarritalStatus_Titleformat',ctrl:'BR_DEMOGRAPHICS_MARRITALSTATUS',prop:'Titleformat'},{av:'edtBR_Demographics_MarritalStatus_Title',ctrl:'BR_DEMOGRAPHICS_MARRITALSTATUS',prop:'Title'},{av:'edtBR_Demographics_Ethnic_Titleformat',ctrl:'BR_DEMOGRAPHICS_ETHNIC',prop:'Titleformat'},{av:'edtBR_Demographics_Ethnic_Title',ctrl:'BR_DEMOGRAPHICS_ETHNIC',prop:'Title'},{av:'edtBR_Demographics_Education_Titleformat',ctrl:'BR_DEMOGRAPHICS_EDUCATION',prop:'Titleformat'},{av:'edtBR_Demographics_Education_Title',ctrl:'BR_DEMOGRAPHICS_EDUCATION',prop:'Title'},{av:'edtBR_Demographics_Occupation_Titleformat',ctrl:'BR_DEMOGRAPHICS_OCCUPATION',prop:'Titleformat'},{av:'edtBR_Demographics_Occupation_Title',ctrl:'BR_DEMOGRAPHICS_OCCUPATION',prop:'Title'},{av:'edtBR_Demographics_Insurance_Titleformat',ctrl:'BR_DEMOGRAPHICS_INSURANCE',prop:'Titleformat'},{av:'edtBR_Demographics_Insurance_Title',ctrl:'BR_DEMOGRAPHICS_INSURANCE',prop:'Title'},{av:'edtBR_Demographics_Province_Titleformat',ctrl:'BR_DEMOGRAPHICS_PROVINCE',prop:'Titleformat'},{av:'edtBR_Demographics_Province_Title',ctrl:'BR_DEMOGRAPHICS_PROVINCE',prop:'Title'},{av:'edtBR_Demographics_City_Titleformat',ctrl:'BR_DEMOGRAPHICS_CITY',prop:'Titleformat'},{av:'edtBR_Demographics_City_Title',ctrl:'BR_DEMOGRAPHICS_CITY',prop:'Title'},{av:'AV42GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV43GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV44GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_DEMOGRAPHICS_SEX.ONOPTIONCLICKED","{handler:'E172M2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_Demographics_IDTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_IDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Demographics_BirthDateTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_BIRTHDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Demographics_SexTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_SEXTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Demographics_MarritalStatusTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_MARRITALSTATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_BR_Demographics_EthnicTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_ETHNICTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Demographics_EducationTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_EDUCATIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Demographics_OccupationTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_OCCUPATIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Demographics_InsuranceTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_INSURANCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Demographics_ProvinceTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_PROVINCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Demographics_CityTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_CITYTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_demographics_sex_Activeeventkey',ctrl:'DDO_BR_DEMOGRAPHICS_SEX',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_DEMOGRAPHICS_SEX.ONOPTIONCLICKED",",oparms:[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_demographics_sex_Sortedstatus',ctrl:'DDO_BR_DEMOGRAPHICS_SEX',prop:'SortedStatus'},{av:'AV12BR_Demographics_IDTitleFilterData',fld:'vBR_DEMOGRAPHICS_IDTITLEFILTERDATA',pic:''},{av:'AV14BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV18BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV20BR_Demographics_BirthDateTitleFilterData',fld:'vBR_DEMOGRAPHICS_BIRTHDATETITLEFILTERDATA',pic:''},{av:'AV24BR_Demographics_SexTitleFilterData',fld:'vBR_DEMOGRAPHICS_SEXTITLEFILTERDATA',pic:''},{av:'AV26BR_Demographics_MarritalStatusTitleFilterData',fld:'vBR_DEMOGRAPHICS_MARRITALSTATUSTITLEFILTERDATA',pic:''},{av:'AV28BR_Demographics_EthnicTitleFilterData',fld:'vBR_DEMOGRAPHICS_ETHNICTITLEFILTERDATA',pic:''},{av:'AV30BR_Demographics_EducationTitleFilterData',fld:'vBR_DEMOGRAPHICS_EDUCATIONTITLEFILTERDATA',pic:''},{av:'AV32BR_Demographics_OccupationTitleFilterData',fld:'vBR_DEMOGRAPHICS_OCCUPATIONTITLEFILTERDATA',pic:''},{av:'AV34BR_Demographics_InsuranceTitleFilterData',fld:'vBR_DEMOGRAPHICS_INSURANCETITLEFILTERDATA',pic:''},{av:'AV36BR_Demographics_ProvinceTitleFilterData',fld:'vBR_DEMOGRAPHICS_PROVINCETITLEFILTERDATA',pic:''},{av:'AV38BR_Demographics_CityTitleFilterData',fld:'vBR_DEMOGRAPHICS_CITYTITLEFILTERDATA',pic:''},{av:'edtBR_Demographics_ID_Titleformat',ctrl:'BR_DEMOGRAPHICS_ID',prop:'Titleformat'},{av:'edtBR_Demographics_ID_Title',ctrl:'BR_DEMOGRAPHICS_ID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Demographics_BirthDate_Titleformat',ctrl:'BR_DEMOGRAPHICS_BIRTHDATE',prop:'Titleformat'},{av:'edtBR_Demographics_BirthDate_Title',ctrl:'BR_DEMOGRAPHICS_BIRTHDATE',prop:'Title'},{av:'edtBR_Demographics_Sex_Titleformat',ctrl:'BR_DEMOGRAPHICS_SEX',prop:'Titleformat'},{av:'edtBR_Demographics_Sex_Title',ctrl:'BR_DEMOGRAPHICS_SEX',prop:'Title'},{av:'edtBR_Demographics_MarritalStatus_Titleformat',ctrl:'BR_DEMOGRAPHICS_MARRITALSTATUS',prop:'Titleformat'},{av:'edtBR_Demographics_MarritalStatus_Title',ctrl:'BR_DEMOGRAPHICS_MARRITALSTATUS',prop:'Title'},{av:'edtBR_Demographics_Ethnic_Titleformat',ctrl:'BR_DEMOGRAPHICS_ETHNIC',prop:'Titleformat'},{av:'edtBR_Demographics_Ethnic_Title',ctrl:'BR_DEMOGRAPHICS_ETHNIC',prop:'Title'},{av:'edtBR_Demographics_Education_Titleformat',ctrl:'BR_DEMOGRAPHICS_EDUCATION',prop:'Titleformat'},{av:'edtBR_Demographics_Education_Title',ctrl:'BR_DEMOGRAPHICS_EDUCATION',prop:'Title'},{av:'edtBR_Demographics_Occupation_Titleformat',ctrl:'BR_DEMOGRAPHICS_OCCUPATION',prop:'Titleformat'},{av:'edtBR_Demographics_Occupation_Title',ctrl:'BR_DEMOGRAPHICS_OCCUPATION',prop:'Title'},{av:'edtBR_Demographics_Insurance_Titleformat',ctrl:'BR_DEMOGRAPHICS_INSURANCE',prop:'Titleformat'},{av:'edtBR_Demographics_Insurance_Title',ctrl:'BR_DEMOGRAPHICS_INSURANCE',prop:'Title'},{av:'edtBR_Demographics_Province_Titleformat',ctrl:'BR_DEMOGRAPHICS_PROVINCE',prop:'Titleformat'},{av:'edtBR_Demographics_Province_Title',ctrl:'BR_DEMOGRAPHICS_PROVINCE',prop:'Title'},{av:'edtBR_Demographics_City_Titleformat',ctrl:'BR_DEMOGRAPHICS_CITY',prop:'Titleformat'},{av:'edtBR_Demographics_City_Title',ctrl:'BR_DEMOGRAPHICS_CITY',prop:'Title'},{av:'AV42GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV43GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV44GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_DEMOGRAPHICS_MARRITALSTATUS.ONOPTIONCLICKED","{handler:'E182M2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_Demographics_IDTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_IDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Demographics_BirthDateTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_BIRTHDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Demographics_SexTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_SEXTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Demographics_MarritalStatusTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_MARRITALSTATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_BR_Demographics_EthnicTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_ETHNICTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Demographics_EducationTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_EDUCATIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Demographics_OccupationTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_OCCUPATIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Demographics_InsuranceTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_INSURANCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Demographics_ProvinceTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_PROVINCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Demographics_CityTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_CITYTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_demographics_marritalstatus_Activeeventkey',ctrl:'DDO_BR_DEMOGRAPHICS_MARRITALSTATUS',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_DEMOGRAPHICS_MARRITALSTATUS.ONOPTIONCLICKED",",oparms:[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_demographics_marritalstatus_Sortedstatus',ctrl:'DDO_BR_DEMOGRAPHICS_MARRITALSTATUS',prop:'SortedStatus'},{av:'AV12BR_Demographics_IDTitleFilterData',fld:'vBR_DEMOGRAPHICS_IDTITLEFILTERDATA',pic:''},{av:'AV14BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV18BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV20BR_Demographics_BirthDateTitleFilterData',fld:'vBR_DEMOGRAPHICS_BIRTHDATETITLEFILTERDATA',pic:''},{av:'AV24BR_Demographics_SexTitleFilterData',fld:'vBR_DEMOGRAPHICS_SEXTITLEFILTERDATA',pic:''},{av:'AV26BR_Demographics_MarritalStatusTitleFilterData',fld:'vBR_DEMOGRAPHICS_MARRITALSTATUSTITLEFILTERDATA',pic:''},{av:'AV28BR_Demographics_EthnicTitleFilterData',fld:'vBR_DEMOGRAPHICS_ETHNICTITLEFILTERDATA',pic:''},{av:'AV30BR_Demographics_EducationTitleFilterData',fld:'vBR_DEMOGRAPHICS_EDUCATIONTITLEFILTERDATA',pic:''},{av:'AV32BR_Demographics_OccupationTitleFilterData',fld:'vBR_DEMOGRAPHICS_OCCUPATIONTITLEFILTERDATA',pic:''},{av:'AV34BR_Demographics_InsuranceTitleFilterData',fld:'vBR_DEMOGRAPHICS_INSURANCETITLEFILTERDATA',pic:''},{av:'AV36BR_Demographics_ProvinceTitleFilterData',fld:'vBR_DEMOGRAPHICS_PROVINCETITLEFILTERDATA',pic:''},{av:'AV38BR_Demographics_CityTitleFilterData',fld:'vBR_DEMOGRAPHICS_CITYTITLEFILTERDATA',pic:''},{av:'edtBR_Demographics_ID_Titleformat',ctrl:'BR_DEMOGRAPHICS_ID',prop:'Titleformat'},{av:'edtBR_Demographics_ID_Title',ctrl:'BR_DEMOGRAPHICS_ID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Demographics_BirthDate_Titleformat',ctrl:'BR_DEMOGRAPHICS_BIRTHDATE',prop:'Titleformat'},{av:'edtBR_Demographics_BirthDate_Title',ctrl:'BR_DEMOGRAPHICS_BIRTHDATE',prop:'Title'},{av:'edtBR_Demographics_Sex_Titleformat',ctrl:'BR_DEMOGRAPHICS_SEX',prop:'Titleformat'},{av:'edtBR_Demographics_Sex_Title',ctrl:'BR_DEMOGRAPHICS_SEX',prop:'Title'},{av:'edtBR_Demographics_MarritalStatus_Titleformat',ctrl:'BR_DEMOGRAPHICS_MARRITALSTATUS',prop:'Titleformat'},{av:'edtBR_Demographics_MarritalStatus_Title',ctrl:'BR_DEMOGRAPHICS_MARRITALSTATUS',prop:'Title'},{av:'edtBR_Demographics_Ethnic_Titleformat',ctrl:'BR_DEMOGRAPHICS_ETHNIC',prop:'Titleformat'},{av:'edtBR_Demographics_Ethnic_Title',ctrl:'BR_DEMOGRAPHICS_ETHNIC',prop:'Title'},{av:'edtBR_Demographics_Education_Titleformat',ctrl:'BR_DEMOGRAPHICS_EDUCATION',prop:'Titleformat'},{av:'edtBR_Demographics_Education_Title',ctrl:'BR_DEMOGRAPHICS_EDUCATION',prop:'Title'},{av:'edtBR_Demographics_Occupation_Titleformat',ctrl:'BR_DEMOGRAPHICS_OCCUPATION',prop:'Titleformat'},{av:'edtBR_Demographics_Occupation_Title',ctrl:'BR_DEMOGRAPHICS_OCCUPATION',prop:'Title'},{av:'edtBR_Demographics_Insurance_Titleformat',ctrl:'BR_DEMOGRAPHICS_INSURANCE',prop:'Titleformat'},{av:'edtBR_Demographics_Insurance_Title',ctrl:'BR_DEMOGRAPHICS_INSURANCE',prop:'Title'},{av:'edtBR_Demographics_Province_Titleformat',ctrl:'BR_DEMOGRAPHICS_PROVINCE',prop:'Titleformat'},{av:'edtBR_Demographics_Province_Title',ctrl:'BR_DEMOGRAPHICS_PROVINCE',prop:'Title'},{av:'edtBR_Demographics_City_Titleformat',ctrl:'BR_DEMOGRAPHICS_CITY',prop:'Titleformat'},{av:'edtBR_Demographics_City_Title',ctrl:'BR_DEMOGRAPHICS_CITY',prop:'Title'},{av:'AV42GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV43GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV44GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_DEMOGRAPHICS_ETHNIC.ONOPTIONCLICKED","{handler:'E192M2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_Demographics_IDTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_IDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Demographics_BirthDateTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_BIRTHDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Demographics_SexTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_SEXTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Demographics_MarritalStatusTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_MARRITALSTATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_BR_Demographics_EthnicTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_ETHNICTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Demographics_EducationTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_EDUCATIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Demographics_OccupationTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_OCCUPATIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Demographics_InsuranceTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_INSURANCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Demographics_ProvinceTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_PROVINCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Demographics_CityTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_CITYTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_demographics_ethnic_Activeeventkey',ctrl:'DDO_BR_DEMOGRAPHICS_ETHNIC',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_DEMOGRAPHICS_ETHNIC.ONOPTIONCLICKED",",oparms:[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_demographics_ethnic_Sortedstatus',ctrl:'DDO_BR_DEMOGRAPHICS_ETHNIC',prop:'SortedStatus'},{av:'AV12BR_Demographics_IDTitleFilterData',fld:'vBR_DEMOGRAPHICS_IDTITLEFILTERDATA',pic:''},{av:'AV14BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV18BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV20BR_Demographics_BirthDateTitleFilterData',fld:'vBR_DEMOGRAPHICS_BIRTHDATETITLEFILTERDATA',pic:''},{av:'AV24BR_Demographics_SexTitleFilterData',fld:'vBR_DEMOGRAPHICS_SEXTITLEFILTERDATA',pic:''},{av:'AV26BR_Demographics_MarritalStatusTitleFilterData',fld:'vBR_DEMOGRAPHICS_MARRITALSTATUSTITLEFILTERDATA',pic:''},{av:'AV28BR_Demographics_EthnicTitleFilterData',fld:'vBR_DEMOGRAPHICS_ETHNICTITLEFILTERDATA',pic:''},{av:'AV30BR_Demographics_EducationTitleFilterData',fld:'vBR_DEMOGRAPHICS_EDUCATIONTITLEFILTERDATA',pic:''},{av:'AV32BR_Demographics_OccupationTitleFilterData',fld:'vBR_DEMOGRAPHICS_OCCUPATIONTITLEFILTERDATA',pic:''},{av:'AV34BR_Demographics_InsuranceTitleFilterData',fld:'vBR_DEMOGRAPHICS_INSURANCETITLEFILTERDATA',pic:''},{av:'AV36BR_Demographics_ProvinceTitleFilterData',fld:'vBR_DEMOGRAPHICS_PROVINCETITLEFILTERDATA',pic:''},{av:'AV38BR_Demographics_CityTitleFilterData',fld:'vBR_DEMOGRAPHICS_CITYTITLEFILTERDATA',pic:''},{av:'edtBR_Demographics_ID_Titleformat',ctrl:'BR_DEMOGRAPHICS_ID',prop:'Titleformat'},{av:'edtBR_Demographics_ID_Title',ctrl:'BR_DEMOGRAPHICS_ID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Demographics_BirthDate_Titleformat',ctrl:'BR_DEMOGRAPHICS_BIRTHDATE',prop:'Titleformat'},{av:'edtBR_Demographics_BirthDate_Title',ctrl:'BR_DEMOGRAPHICS_BIRTHDATE',prop:'Title'},{av:'edtBR_Demographics_Sex_Titleformat',ctrl:'BR_DEMOGRAPHICS_SEX',prop:'Titleformat'},{av:'edtBR_Demographics_Sex_Title',ctrl:'BR_DEMOGRAPHICS_SEX',prop:'Title'},{av:'edtBR_Demographics_MarritalStatus_Titleformat',ctrl:'BR_DEMOGRAPHICS_MARRITALSTATUS',prop:'Titleformat'},{av:'edtBR_Demographics_MarritalStatus_Title',ctrl:'BR_DEMOGRAPHICS_MARRITALSTATUS',prop:'Title'},{av:'edtBR_Demographics_Ethnic_Titleformat',ctrl:'BR_DEMOGRAPHICS_ETHNIC',prop:'Titleformat'},{av:'edtBR_Demographics_Ethnic_Title',ctrl:'BR_DEMOGRAPHICS_ETHNIC',prop:'Title'},{av:'edtBR_Demographics_Education_Titleformat',ctrl:'BR_DEMOGRAPHICS_EDUCATION',prop:'Titleformat'},{av:'edtBR_Demographics_Education_Title',ctrl:'BR_DEMOGRAPHICS_EDUCATION',prop:'Title'},{av:'edtBR_Demographics_Occupation_Titleformat',ctrl:'BR_DEMOGRAPHICS_OCCUPATION',prop:'Titleformat'},{av:'edtBR_Demographics_Occupation_Title',ctrl:'BR_DEMOGRAPHICS_OCCUPATION',prop:'Title'},{av:'edtBR_Demographics_Insurance_Titleformat',ctrl:'BR_DEMOGRAPHICS_INSURANCE',prop:'Titleformat'},{av:'edtBR_Demographics_Insurance_Title',ctrl:'BR_DEMOGRAPHICS_INSURANCE',prop:'Title'},{av:'edtBR_Demographics_Province_Titleformat',ctrl:'BR_DEMOGRAPHICS_PROVINCE',prop:'Titleformat'},{av:'edtBR_Demographics_Province_Title',ctrl:'BR_DEMOGRAPHICS_PROVINCE',prop:'Title'},{av:'edtBR_Demographics_City_Titleformat',ctrl:'BR_DEMOGRAPHICS_CITY',prop:'Titleformat'},{av:'edtBR_Demographics_City_Title',ctrl:'BR_DEMOGRAPHICS_CITY',prop:'Title'},{av:'AV42GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV43GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV44GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_DEMOGRAPHICS_EDUCATION.ONOPTIONCLICKED","{handler:'E202M2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_Demographics_IDTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_IDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Demographics_BirthDateTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_BIRTHDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Demographics_SexTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_SEXTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Demographics_MarritalStatusTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_MARRITALSTATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_BR_Demographics_EthnicTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_ETHNICTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Demographics_EducationTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_EDUCATIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Demographics_OccupationTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_OCCUPATIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Demographics_InsuranceTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_INSURANCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Demographics_ProvinceTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_PROVINCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Demographics_CityTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_CITYTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_demographics_education_Activeeventkey',ctrl:'DDO_BR_DEMOGRAPHICS_EDUCATION',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_DEMOGRAPHICS_EDUCATION.ONOPTIONCLICKED",",oparms:[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_demographics_education_Sortedstatus',ctrl:'DDO_BR_DEMOGRAPHICS_EDUCATION',prop:'SortedStatus'},{av:'AV12BR_Demographics_IDTitleFilterData',fld:'vBR_DEMOGRAPHICS_IDTITLEFILTERDATA',pic:''},{av:'AV14BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV18BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV20BR_Demographics_BirthDateTitleFilterData',fld:'vBR_DEMOGRAPHICS_BIRTHDATETITLEFILTERDATA',pic:''},{av:'AV24BR_Demographics_SexTitleFilterData',fld:'vBR_DEMOGRAPHICS_SEXTITLEFILTERDATA',pic:''},{av:'AV26BR_Demographics_MarritalStatusTitleFilterData',fld:'vBR_DEMOGRAPHICS_MARRITALSTATUSTITLEFILTERDATA',pic:''},{av:'AV28BR_Demographics_EthnicTitleFilterData',fld:'vBR_DEMOGRAPHICS_ETHNICTITLEFILTERDATA',pic:''},{av:'AV30BR_Demographics_EducationTitleFilterData',fld:'vBR_DEMOGRAPHICS_EDUCATIONTITLEFILTERDATA',pic:''},{av:'AV32BR_Demographics_OccupationTitleFilterData',fld:'vBR_DEMOGRAPHICS_OCCUPATIONTITLEFILTERDATA',pic:''},{av:'AV34BR_Demographics_InsuranceTitleFilterData',fld:'vBR_DEMOGRAPHICS_INSURANCETITLEFILTERDATA',pic:''},{av:'AV36BR_Demographics_ProvinceTitleFilterData',fld:'vBR_DEMOGRAPHICS_PROVINCETITLEFILTERDATA',pic:''},{av:'AV38BR_Demographics_CityTitleFilterData',fld:'vBR_DEMOGRAPHICS_CITYTITLEFILTERDATA',pic:''},{av:'edtBR_Demographics_ID_Titleformat',ctrl:'BR_DEMOGRAPHICS_ID',prop:'Titleformat'},{av:'edtBR_Demographics_ID_Title',ctrl:'BR_DEMOGRAPHICS_ID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Demographics_BirthDate_Titleformat',ctrl:'BR_DEMOGRAPHICS_BIRTHDATE',prop:'Titleformat'},{av:'edtBR_Demographics_BirthDate_Title',ctrl:'BR_DEMOGRAPHICS_BIRTHDATE',prop:'Title'},{av:'edtBR_Demographics_Sex_Titleformat',ctrl:'BR_DEMOGRAPHICS_SEX',prop:'Titleformat'},{av:'edtBR_Demographics_Sex_Title',ctrl:'BR_DEMOGRAPHICS_SEX',prop:'Title'},{av:'edtBR_Demographics_MarritalStatus_Titleformat',ctrl:'BR_DEMOGRAPHICS_MARRITALSTATUS',prop:'Titleformat'},{av:'edtBR_Demographics_MarritalStatus_Title',ctrl:'BR_DEMOGRAPHICS_MARRITALSTATUS',prop:'Title'},{av:'edtBR_Demographics_Ethnic_Titleformat',ctrl:'BR_DEMOGRAPHICS_ETHNIC',prop:'Titleformat'},{av:'edtBR_Demographics_Ethnic_Title',ctrl:'BR_DEMOGRAPHICS_ETHNIC',prop:'Title'},{av:'edtBR_Demographics_Education_Titleformat',ctrl:'BR_DEMOGRAPHICS_EDUCATION',prop:'Titleformat'},{av:'edtBR_Demographics_Education_Title',ctrl:'BR_DEMOGRAPHICS_EDUCATION',prop:'Title'},{av:'edtBR_Demographics_Occupation_Titleformat',ctrl:'BR_DEMOGRAPHICS_OCCUPATION',prop:'Titleformat'},{av:'edtBR_Demographics_Occupation_Title',ctrl:'BR_DEMOGRAPHICS_OCCUPATION',prop:'Title'},{av:'edtBR_Demographics_Insurance_Titleformat',ctrl:'BR_DEMOGRAPHICS_INSURANCE',prop:'Titleformat'},{av:'edtBR_Demographics_Insurance_Title',ctrl:'BR_DEMOGRAPHICS_INSURANCE',prop:'Title'},{av:'edtBR_Demographics_Province_Titleformat',ctrl:'BR_DEMOGRAPHICS_PROVINCE',prop:'Titleformat'},{av:'edtBR_Demographics_Province_Title',ctrl:'BR_DEMOGRAPHICS_PROVINCE',prop:'Title'},{av:'edtBR_Demographics_City_Titleformat',ctrl:'BR_DEMOGRAPHICS_CITY',prop:'Titleformat'},{av:'edtBR_Demographics_City_Title',ctrl:'BR_DEMOGRAPHICS_CITY',prop:'Title'},{av:'AV42GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV43GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV44GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_DEMOGRAPHICS_OCCUPATION.ONOPTIONCLICKED","{handler:'E212M2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_Demographics_IDTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_IDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Demographics_BirthDateTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_BIRTHDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Demographics_SexTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_SEXTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Demographics_MarritalStatusTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_MARRITALSTATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_BR_Demographics_EthnicTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_ETHNICTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Demographics_EducationTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_EDUCATIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Demographics_OccupationTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_OCCUPATIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Demographics_InsuranceTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_INSURANCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Demographics_ProvinceTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_PROVINCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Demographics_CityTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_CITYTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_demographics_occupation_Activeeventkey',ctrl:'DDO_BR_DEMOGRAPHICS_OCCUPATION',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_DEMOGRAPHICS_OCCUPATION.ONOPTIONCLICKED",",oparms:[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_demographics_occupation_Sortedstatus',ctrl:'DDO_BR_DEMOGRAPHICS_OCCUPATION',prop:'SortedStatus'},{av:'AV12BR_Demographics_IDTitleFilterData',fld:'vBR_DEMOGRAPHICS_IDTITLEFILTERDATA',pic:''},{av:'AV14BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV18BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV20BR_Demographics_BirthDateTitleFilterData',fld:'vBR_DEMOGRAPHICS_BIRTHDATETITLEFILTERDATA',pic:''},{av:'AV24BR_Demographics_SexTitleFilterData',fld:'vBR_DEMOGRAPHICS_SEXTITLEFILTERDATA',pic:''},{av:'AV26BR_Demographics_MarritalStatusTitleFilterData',fld:'vBR_DEMOGRAPHICS_MARRITALSTATUSTITLEFILTERDATA',pic:''},{av:'AV28BR_Demographics_EthnicTitleFilterData',fld:'vBR_DEMOGRAPHICS_ETHNICTITLEFILTERDATA',pic:''},{av:'AV30BR_Demographics_EducationTitleFilterData',fld:'vBR_DEMOGRAPHICS_EDUCATIONTITLEFILTERDATA',pic:''},{av:'AV32BR_Demographics_OccupationTitleFilterData',fld:'vBR_DEMOGRAPHICS_OCCUPATIONTITLEFILTERDATA',pic:''},{av:'AV34BR_Demographics_InsuranceTitleFilterData',fld:'vBR_DEMOGRAPHICS_INSURANCETITLEFILTERDATA',pic:''},{av:'AV36BR_Demographics_ProvinceTitleFilterData',fld:'vBR_DEMOGRAPHICS_PROVINCETITLEFILTERDATA',pic:''},{av:'AV38BR_Demographics_CityTitleFilterData',fld:'vBR_DEMOGRAPHICS_CITYTITLEFILTERDATA',pic:''},{av:'edtBR_Demographics_ID_Titleformat',ctrl:'BR_DEMOGRAPHICS_ID',prop:'Titleformat'},{av:'edtBR_Demographics_ID_Title',ctrl:'BR_DEMOGRAPHICS_ID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Demographics_BirthDate_Titleformat',ctrl:'BR_DEMOGRAPHICS_BIRTHDATE',prop:'Titleformat'},{av:'edtBR_Demographics_BirthDate_Title',ctrl:'BR_DEMOGRAPHICS_BIRTHDATE',prop:'Title'},{av:'edtBR_Demographics_Sex_Titleformat',ctrl:'BR_DEMOGRAPHICS_SEX',prop:'Titleformat'},{av:'edtBR_Demographics_Sex_Title',ctrl:'BR_DEMOGRAPHICS_SEX',prop:'Title'},{av:'edtBR_Demographics_MarritalStatus_Titleformat',ctrl:'BR_DEMOGRAPHICS_MARRITALSTATUS',prop:'Titleformat'},{av:'edtBR_Demographics_MarritalStatus_Title',ctrl:'BR_DEMOGRAPHICS_MARRITALSTATUS',prop:'Title'},{av:'edtBR_Demographics_Ethnic_Titleformat',ctrl:'BR_DEMOGRAPHICS_ETHNIC',prop:'Titleformat'},{av:'edtBR_Demographics_Ethnic_Title',ctrl:'BR_DEMOGRAPHICS_ETHNIC',prop:'Title'},{av:'edtBR_Demographics_Education_Titleformat',ctrl:'BR_DEMOGRAPHICS_EDUCATION',prop:'Titleformat'},{av:'edtBR_Demographics_Education_Title',ctrl:'BR_DEMOGRAPHICS_EDUCATION',prop:'Title'},{av:'edtBR_Demographics_Occupation_Titleformat',ctrl:'BR_DEMOGRAPHICS_OCCUPATION',prop:'Titleformat'},{av:'edtBR_Demographics_Occupation_Title',ctrl:'BR_DEMOGRAPHICS_OCCUPATION',prop:'Title'},{av:'edtBR_Demographics_Insurance_Titleformat',ctrl:'BR_DEMOGRAPHICS_INSURANCE',prop:'Titleformat'},{av:'edtBR_Demographics_Insurance_Title',ctrl:'BR_DEMOGRAPHICS_INSURANCE',prop:'Title'},{av:'edtBR_Demographics_Province_Titleformat',ctrl:'BR_DEMOGRAPHICS_PROVINCE',prop:'Titleformat'},{av:'edtBR_Demographics_Province_Title',ctrl:'BR_DEMOGRAPHICS_PROVINCE',prop:'Title'},{av:'edtBR_Demographics_City_Titleformat',ctrl:'BR_DEMOGRAPHICS_CITY',prop:'Titleformat'},{av:'edtBR_Demographics_City_Title',ctrl:'BR_DEMOGRAPHICS_CITY',prop:'Title'},{av:'AV42GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV43GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV44GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_DEMOGRAPHICS_INSURANCE.ONOPTIONCLICKED","{handler:'E222M2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_Demographics_IDTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_IDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Demographics_BirthDateTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_BIRTHDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Demographics_SexTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_SEXTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Demographics_MarritalStatusTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_MARRITALSTATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_BR_Demographics_EthnicTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_ETHNICTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Demographics_EducationTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_EDUCATIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Demographics_OccupationTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_OCCUPATIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Demographics_InsuranceTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_INSURANCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Demographics_ProvinceTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_PROVINCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Demographics_CityTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_CITYTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_demographics_insurance_Activeeventkey',ctrl:'DDO_BR_DEMOGRAPHICS_INSURANCE',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_DEMOGRAPHICS_INSURANCE.ONOPTIONCLICKED",",oparms:[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_demographics_insurance_Sortedstatus',ctrl:'DDO_BR_DEMOGRAPHICS_INSURANCE',prop:'SortedStatus'},{av:'AV12BR_Demographics_IDTitleFilterData',fld:'vBR_DEMOGRAPHICS_IDTITLEFILTERDATA',pic:''},{av:'AV14BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV18BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV20BR_Demographics_BirthDateTitleFilterData',fld:'vBR_DEMOGRAPHICS_BIRTHDATETITLEFILTERDATA',pic:''},{av:'AV24BR_Demographics_SexTitleFilterData',fld:'vBR_DEMOGRAPHICS_SEXTITLEFILTERDATA',pic:''},{av:'AV26BR_Demographics_MarritalStatusTitleFilterData',fld:'vBR_DEMOGRAPHICS_MARRITALSTATUSTITLEFILTERDATA',pic:''},{av:'AV28BR_Demographics_EthnicTitleFilterData',fld:'vBR_DEMOGRAPHICS_ETHNICTITLEFILTERDATA',pic:''},{av:'AV30BR_Demographics_EducationTitleFilterData',fld:'vBR_DEMOGRAPHICS_EDUCATIONTITLEFILTERDATA',pic:''},{av:'AV32BR_Demographics_OccupationTitleFilterData',fld:'vBR_DEMOGRAPHICS_OCCUPATIONTITLEFILTERDATA',pic:''},{av:'AV34BR_Demographics_InsuranceTitleFilterData',fld:'vBR_DEMOGRAPHICS_INSURANCETITLEFILTERDATA',pic:''},{av:'AV36BR_Demographics_ProvinceTitleFilterData',fld:'vBR_DEMOGRAPHICS_PROVINCETITLEFILTERDATA',pic:''},{av:'AV38BR_Demographics_CityTitleFilterData',fld:'vBR_DEMOGRAPHICS_CITYTITLEFILTERDATA',pic:''},{av:'edtBR_Demographics_ID_Titleformat',ctrl:'BR_DEMOGRAPHICS_ID',prop:'Titleformat'},{av:'edtBR_Demographics_ID_Title',ctrl:'BR_DEMOGRAPHICS_ID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Demographics_BirthDate_Titleformat',ctrl:'BR_DEMOGRAPHICS_BIRTHDATE',prop:'Titleformat'},{av:'edtBR_Demographics_BirthDate_Title',ctrl:'BR_DEMOGRAPHICS_BIRTHDATE',prop:'Title'},{av:'edtBR_Demographics_Sex_Titleformat',ctrl:'BR_DEMOGRAPHICS_SEX',prop:'Titleformat'},{av:'edtBR_Demographics_Sex_Title',ctrl:'BR_DEMOGRAPHICS_SEX',prop:'Title'},{av:'edtBR_Demographics_MarritalStatus_Titleformat',ctrl:'BR_DEMOGRAPHICS_MARRITALSTATUS',prop:'Titleformat'},{av:'edtBR_Demographics_MarritalStatus_Title',ctrl:'BR_DEMOGRAPHICS_MARRITALSTATUS',prop:'Title'},{av:'edtBR_Demographics_Ethnic_Titleformat',ctrl:'BR_DEMOGRAPHICS_ETHNIC',prop:'Titleformat'},{av:'edtBR_Demographics_Ethnic_Title',ctrl:'BR_DEMOGRAPHICS_ETHNIC',prop:'Title'},{av:'edtBR_Demographics_Education_Titleformat',ctrl:'BR_DEMOGRAPHICS_EDUCATION',prop:'Titleformat'},{av:'edtBR_Demographics_Education_Title',ctrl:'BR_DEMOGRAPHICS_EDUCATION',prop:'Title'},{av:'edtBR_Demographics_Occupation_Titleformat',ctrl:'BR_DEMOGRAPHICS_OCCUPATION',prop:'Titleformat'},{av:'edtBR_Demographics_Occupation_Title',ctrl:'BR_DEMOGRAPHICS_OCCUPATION',prop:'Title'},{av:'edtBR_Demographics_Insurance_Titleformat',ctrl:'BR_DEMOGRAPHICS_INSURANCE',prop:'Titleformat'},{av:'edtBR_Demographics_Insurance_Title',ctrl:'BR_DEMOGRAPHICS_INSURANCE',prop:'Title'},{av:'edtBR_Demographics_Province_Titleformat',ctrl:'BR_DEMOGRAPHICS_PROVINCE',prop:'Titleformat'},{av:'edtBR_Demographics_Province_Title',ctrl:'BR_DEMOGRAPHICS_PROVINCE',prop:'Title'},{av:'edtBR_Demographics_City_Titleformat',ctrl:'BR_DEMOGRAPHICS_CITY',prop:'Titleformat'},{av:'edtBR_Demographics_City_Title',ctrl:'BR_DEMOGRAPHICS_CITY',prop:'Title'},{av:'AV42GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV43GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV44GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_DEMOGRAPHICS_PROVINCE.ONOPTIONCLICKED","{handler:'E232M2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_Demographics_IDTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_IDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Demographics_BirthDateTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_BIRTHDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Demographics_SexTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_SEXTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Demographics_MarritalStatusTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_MARRITALSTATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_BR_Demographics_EthnicTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_ETHNICTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Demographics_EducationTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_EDUCATIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Demographics_OccupationTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_OCCUPATIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Demographics_InsuranceTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_INSURANCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Demographics_ProvinceTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_PROVINCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Demographics_CityTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_CITYTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_demographics_province_Activeeventkey',ctrl:'DDO_BR_DEMOGRAPHICS_PROVINCE',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_DEMOGRAPHICS_PROVINCE.ONOPTIONCLICKED",",oparms:[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_demographics_province_Sortedstatus',ctrl:'DDO_BR_DEMOGRAPHICS_PROVINCE',prop:'SortedStatus'},{av:'AV12BR_Demographics_IDTitleFilterData',fld:'vBR_DEMOGRAPHICS_IDTITLEFILTERDATA',pic:''},{av:'AV14BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV18BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV20BR_Demographics_BirthDateTitleFilterData',fld:'vBR_DEMOGRAPHICS_BIRTHDATETITLEFILTERDATA',pic:''},{av:'AV24BR_Demographics_SexTitleFilterData',fld:'vBR_DEMOGRAPHICS_SEXTITLEFILTERDATA',pic:''},{av:'AV26BR_Demographics_MarritalStatusTitleFilterData',fld:'vBR_DEMOGRAPHICS_MARRITALSTATUSTITLEFILTERDATA',pic:''},{av:'AV28BR_Demographics_EthnicTitleFilterData',fld:'vBR_DEMOGRAPHICS_ETHNICTITLEFILTERDATA',pic:''},{av:'AV30BR_Demographics_EducationTitleFilterData',fld:'vBR_DEMOGRAPHICS_EDUCATIONTITLEFILTERDATA',pic:''},{av:'AV32BR_Demographics_OccupationTitleFilterData',fld:'vBR_DEMOGRAPHICS_OCCUPATIONTITLEFILTERDATA',pic:''},{av:'AV34BR_Demographics_InsuranceTitleFilterData',fld:'vBR_DEMOGRAPHICS_INSURANCETITLEFILTERDATA',pic:''},{av:'AV36BR_Demographics_ProvinceTitleFilterData',fld:'vBR_DEMOGRAPHICS_PROVINCETITLEFILTERDATA',pic:''},{av:'AV38BR_Demographics_CityTitleFilterData',fld:'vBR_DEMOGRAPHICS_CITYTITLEFILTERDATA',pic:''},{av:'edtBR_Demographics_ID_Titleformat',ctrl:'BR_DEMOGRAPHICS_ID',prop:'Titleformat'},{av:'edtBR_Demographics_ID_Title',ctrl:'BR_DEMOGRAPHICS_ID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Demographics_BirthDate_Titleformat',ctrl:'BR_DEMOGRAPHICS_BIRTHDATE',prop:'Titleformat'},{av:'edtBR_Demographics_BirthDate_Title',ctrl:'BR_DEMOGRAPHICS_BIRTHDATE',prop:'Title'},{av:'edtBR_Demographics_Sex_Titleformat',ctrl:'BR_DEMOGRAPHICS_SEX',prop:'Titleformat'},{av:'edtBR_Demographics_Sex_Title',ctrl:'BR_DEMOGRAPHICS_SEX',prop:'Title'},{av:'edtBR_Demographics_MarritalStatus_Titleformat',ctrl:'BR_DEMOGRAPHICS_MARRITALSTATUS',prop:'Titleformat'},{av:'edtBR_Demographics_MarritalStatus_Title',ctrl:'BR_DEMOGRAPHICS_MARRITALSTATUS',prop:'Title'},{av:'edtBR_Demographics_Ethnic_Titleformat',ctrl:'BR_DEMOGRAPHICS_ETHNIC',prop:'Titleformat'},{av:'edtBR_Demographics_Ethnic_Title',ctrl:'BR_DEMOGRAPHICS_ETHNIC',prop:'Title'},{av:'edtBR_Demographics_Education_Titleformat',ctrl:'BR_DEMOGRAPHICS_EDUCATION',prop:'Titleformat'},{av:'edtBR_Demographics_Education_Title',ctrl:'BR_DEMOGRAPHICS_EDUCATION',prop:'Title'},{av:'edtBR_Demographics_Occupation_Titleformat',ctrl:'BR_DEMOGRAPHICS_OCCUPATION',prop:'Titleformat'},{av:'edtBR_Demographics_Occupation_Title',ctrl:'BR_DEMOGRAPHICS_OCCUPATION',prop:'Title'},{av:'edtBR_Demographics_Insurance_Titleformat',ctrl:'BR_DEMOGRAPHICS_INSURANCE',prop:'Titleformat'},{av:'edtBR_Demographics_Insurance_Title',ctrl:'BR_DEMOGRAPHICS_INSURANCE',prop:'Title'},{av:'edtBR_Demographics_Province_Titleformat',ctrl:'BR_DEMOGRAPHICS_PROVINCE',prop:'Titleformat'},{av:'edtBR_Demographics_Province_Title',ctrl:'BR_DEMOGRAPHICS_PROVINCE',prop:'Title'},{av:'edtBR_Demographics_City_Titleformat',ctrl:'BR_DEMOGRAPHICS_CITY',prop:'Titleformat'},{av:'edtBR_Demographics_City_Title',ctrl:'BR_DEMOGRAPHICS_CITY',prop:'Title'},{av:'AV42GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV43GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV44GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_DEMOGRAPHICS_CITY.ONOPTIONCLICKED","{handler:'E242M2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_Demographics_IDTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_IDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Demographics_BirthDateTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_BIRTHDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Demographics_SexTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_SEXTITLECONTROLIDTOREPLACE',pic:''},{av:'AV27ddo_BR_Demographics_MarritalStatusTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_MARRITALSTATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV29ddo_BR_Demographics_EthnicTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_ETHNICTITLECONTROLIDTOREPLACE',pic:''},{av:'AV31ddo_BR_Demographics_EducationTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_EDUCATIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Demographics_OccupationTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_OCCUPATIONTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Demographics_InsuranceTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_INSURANCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Demographics_ProvinceTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_PROVINCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Demographics_CityTitleControlIdToReplace',fld:'vDDO_BR_DEMOGRAPHICS_CITYTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_demographics_city_Activeeventkey',ctrl:'DDO_BR_DEMOGRAPHICS_CITY',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_DEMOGRAPHICS_CITY.ONOPTIONCLICKED",",oparms:[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_demographics_city_Sortedstatus',ctrl:'DDO_BR_DEMOGRAPHICS_CITY',prop:'SortedStatus'},{av:'AV12BR_Demographics_IDTitleFilterData',fld:'vBR_DEMOGRAPHICS_IDTITLEFILTERDATA',pic:''},{av:'AV14BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV18BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV20BR_Demographics_BirthDateTitleFilterData',fld:'vBR_DEMOGRAPHICS_BIRTHDATETITLEFILTERDATA',pic:''},{av:'AV24BR_Demographics_SexTitleFilterData',fld:'vBR_DEMOGRAPHICS_SEXTITLEFILTERDATA',pic:''},{av:'AV26BR_Demographics_MarritalStatusTitleFilterData',fld:'vBR_DEMOGRAPHICS_MARRITALSTATUSTITLEFILTERDATA',pic:''},{av:'AV28BR_Demographics_EthnicTitleFilterData',fld:'vBR_DEMOGRAPHICS_ETHNICTITLEFILTERDATA',pic:''},{av:'AV30BR_Demographics_EducationTitleFilterData',fld:'vBR_DEMOGRAPHICS_EDUCATIONTITLEFILTERDATA',pic:''},{av:'AV32BR_Demographics_OccupationTitleFilterData',fld:'vBR_DEMOGRAPHICS_OCCUPATIONTITLEFILTERDATA',pic:''},{av:'AV34BR_Demographics_InsuranceTitleFilterData',fld:'vBR_DEMOGRAPHICS_INSURANCETITLEFILTERDATA',pic:''},{av:'AV36BR_Demographics_ProvinceTitleFilterData',fld:'vBR_DEMOGRAPHICS_PROVINCETITLEFILTERDATA',pic:''},{av:'AV38BR_Demographics_CityTitleFilterData',fld:'vBR_DEMOGRAPHICS_CITYTITLEFILTERDATA',pic:''},{av:'edtBR_Demographics_ID_Titleformat',ctrl:'BR_DEMOGRAPHICS_ID',prop:'Titleformat'},{av:'edtBR_Demographics_ID_Title',ctrl:'BR_DEMOGRAPHICS_ID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Demographics_BirthDate_Titleformat',ctrl:'BR_DEMOGRAPHICS_BIRTHDATE',prop:'Titleformat'},{av:'edtBR_Demographics_BirthDate_Title',ctrl:'BR_DEMOGRAPHICS_BIRTHDATE',prop:'Title'},{av:'edtBR_Demographics_Sex_Titleformat',ctrl:'BR_DEMOGRAPHICS_SEX',prop:'Titleformat'},{av:'edtBR_Demographics_Sex_Title',ctrl:'BR_DEMOGRAPHICS_SEX',prop:'Title'},{av:'edtBR_Demographics_MarritalStatus_Titleformat',ctrl:'BR_DEMOGRAPHICS_MARRITALSTATUS',prop:'Titleformat'},{av:'edtBR_Demographics_MarritalStatus_Title',ctrl:'BR_DEMOGRAPHICS_MARRITALSTATUS',prop:'Title'},{av:'edtBR_Demographics_Ethnic_Titleformat',ctrl:'BR_DEMOGRAPHICS_ETHNIC',prop:'Titleformat'},{av:'edtBR_Demographics_Ethnic_Title',ctrl:'BR_DEMOGRAPHICS_ETHNIC',prop:'Title'},{av:'edtBR_Demographics_Education_Titleformat',ctrl:'BR_DEMOGRAPHICS_EDUCATION',prop:'Titleformat'},{av:'edtBR_Demographics_Education_Title',ctrl:'BR_DEMOGRAPHICS_EDUCATION',prop:'Title'},{av:'edtBR_Demographics_Occupation_Titleformat',ctrl:'BR_DEMOGRAPHICS_OCCUPATION',prop:'Titleformat'},{av:'edtBR_Demographics_Occupation_Title',ctrl:'BR_DEMOGRAPHICS_OCCUPATION',prop:'Title'},{av:'edtBR_Demographics_Insurance_Titleformat',ctrl:'BR_DEMOGRAPHICS_INSURANCE',prop:'Titleformat'},{av:'edtBR_Demographics_Insurance_Title',ctrl:'BR_DEMOGRAPHICS_INSURANCE',prop:'Title'},{av:'edtBR_Demographics_Province_Titleformat',ctrl:'BR_DEMOGRAPHICS_PROVINCE',prop:'Titleformat'},{av:'edtBR_Demographics_Province_Title',ctrl:'BR_DEMOGRAPHICS_PROVINCE',prop:'Title'},{av:'edtBR_Demographics_City_Titleformat',ctrl:'BR_DEMOGRAPHICS_CITY',prop:'Titleformat'},{av:'edtBR_Demographics_City_Title',ctrl:'BR_DEMOGRAPHICS_CITY',prop:'Title'},{av:'AV42GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV43GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV44GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("GRID.LOAD","{handler:'E272M2',iparms:[]");
         setEventMetadata("GRID.LOAD",",oparms:[{av:'AV45Select',fld:'vSELECT',pic:''},{av:'edtavSelect_Tooltiptext',ctrl:'vSELECT',prop:'Tooltiptext'}]}");
         setEventMetadata("ENTER","{handler:'E282M2',iparms:[{av:'A61BR_Demographics_ID',fld:'BR_DEMOGRAPHICS_ID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[{av:'AV8InOutBR_Demographics_ID',fld:'vINOUTBR_DEMOGRAPHICS_ID',pic:'ZZZZZZZZZZZZZZZZZZ'}]}");
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
         Ddo_br_demographics_id_Activeeventkey = "";
         Ddo_br_encounterid_Activeeventkey = "";
         Ddo_br_information_patientno_Activeeventkey = "";
         Ddo_br_demographics_birthdate_Activeeventkey = "";
         Ddo_br_demographics_sex_Activeeventkey = "";
         Ddo_br_demographics_marritalstatus_Activeeventkey = "";
         Ddo_br_demographics_ethnic_Activeeventkey = "";
         Ddo_br_demographics_education_Activeeventkey = "";
         Ddo_br_demographics_occupation_Activeeventkey = "";
         Ddo_br_demographics_insurance_Activeeventkey = "";
         Ddo_br_demographics_province_Activeeventkey = "";
         Ddo_br_demographics_city_Activeeventkey = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV13ddo_BR_Demographics_IDTitleControlIdToReplace = "";
         AV15ddo_BR_EncounterIDTitleControlIdToReplace = "";
         AV19ddo_BR_Information_PatientNoTitleControlIdToReplace = "";
         AV21ddo_BR_Demographics_BirthDateTitleControlIdToReplace = "";
         AV25ddo_BR_Demographics_SexTitleControlIdToReplace = "";
         AV27ddo_BR_Demographics_MarritalStatusTitleControlIdToReplace = "";
         AV29ddo_BR_Demographics_EthnicTitleControlIdToReplace = "";
         AV31ddo_BR_Demographics_EducationTitleControlIdToReplace = "";
         AV33ddo_BR_Demographics_OccupationTitleControlIdToReplace = "";
         AV35ddo_BR_Demographics_InsuranceTitleControlIdToReplace = "";
         AV37ddo_BR_Demographics_ProvinceTitleControlIdToReplace = "";
         AV39ddo_BR_Demographics_CityTitleControlIdToReplace = "";
         GXKey = "";
         AV48Pgmname = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         AV40DDO_TitleSettingsIcons = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV12BR_Demographics_IDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV14BR_EncounterIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV18BR_Information_PatientNoTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV20BR_Demographics_BirthDateTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV24BR_Demographics_SexTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV26BR_Demographics_MarritalStatusTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV28BR_Demographics_EthnicTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV30BR_Demographics_EducationTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV32BR_Demographics_OccupationTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV34BR_Demographics_InsuranceTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV36BR_Demographics_ProvinceTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV38BR_Demographics_CityTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         Ddo_br_demographics_id_Sortedstatus = "";
         Ddo_br_encounterid_Sortedstatus = "";
         Ddo_br_information_patientno_Sortedstatus = "";
         Ddo_br_demographics_birthdate_Sortedstatus = "";
         Ddo_br_demographics_sex_Sortedstatus = "";
         Ddo_br_demographics_marritalstatus_Sortedstatus = "";
         Ddo_br_demographics_ethnic_Sortedstatus = "";
         Ddo_br_demographics_education_Sortedstatus = "";
         Ddo_br_demographics_occupation_Sortedstatus = "";
         Ddo_br_demographics_insurance_Sortedstatus = "";
         Ddo_br_demographics_province_Sortedstatus = "";
         Ddo_br_demographics_city_Sortedstatus = "";
         GX_FocusControl = "";
         sPrefix = "";
         GridContainer = new GXWebGrid( context);
         sStyleString = "";
         subGrid_Linesclass = "";
         GridColumn = new GXWebColumn();
         AV45Select = "";
         A36BR_Information_PatientNo = "";
         A53BR_Demographics_BirthDate = DateTime.MinValue;
         A54BR_Demographics_Sex = "";
         A63BR_Demographics_MarritalStatus = "";
         A55BR_Demographics_Ethnic = "";
         A56BR_Demographics_Education = "";
         A57BR_Demographics_Occupation = "";
         A58BR_Demographics_Insurance = "";
         A59BR_Demographics_Province = "";
         A60BR_Demographics_City = "";
         ucGridpaginationbar = new GXUserControl();
         ucDdo_br_demographics_id = new GXUserControl();
         TempTags = "";
         ClassString = "";
         StyleString = "";
         ucDdo_br_encounterid = new GXUserControl();
         ucDdo_br_information_patientno = new GXUserControl();
         ucDdo_br_demographics_birthdate = new GXUserControl();
         ucDdo_br_demographics_sex = new GXUserControl();
         ucDdo_br_demographics_marritalstatus = new GXUserControl();
         ucDdo_br_demographics_ethnic = new GXUserControl();
         ucDdo_br_demographics_education = new GXUserControl();
         ucDdo_br_demographics_occupation = new GXUserControl();
         ucDdo_br_demographics_insurance = new GXUserControl();
         ucDdo_br_demographics_province = new GXUserControl();
         ucDdo_br_demographics_city = new GXUserControl();
         ucWorkwithplusutilities1 = new GXUserControl();
         Form = new GXWebForm();
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV49Select_GXI = "";
         scmdbuf = "";
         H002M2_A85BR_Information_ID = new long[1] ;
         H002M2_n85BR_Information_ID = new bool[] {false} ;
         H002M2_A60BR_Demographics_City = new String[] {""} ;
         H002M2_n60BR_Demographics_City = new bool[] {false} ;
         H002M2_A59BR_Demographics_Province = new String[] {""} ;
         H002M2_n59BR_Demographics_Province = new bool[] {false} ;
         H002M2_A58BR_Demographics_Insurance = new String[] {""} ;
         H002M2_n58BR_Demographics_Insurance = new bool[] {false} ;
         H002M2_A57BR_Demographics_Occupation = new String[] {""} ;
         H002M2_n57BR_Demographics_Occupation = new bool[] {false} ;
         H002M2_A56BR_Demographics_Education = new String[] {""} ;
         H002M2_n56BR_Demographics_Education = new bool[] {false} ;
         H002M2_A55BR_Demographics_Ethnic = new String[] {""} ;
         H002M2_n55BR_Demographics_Ethnic = new bool[] {false} ;
         H002M2_A63BR_Demographics_MarritalStatus = new String[] {""} ;
         H002M2_n63BR_Demographics_MarritalStatus = new bool[] {false} ;
         H002M2_A54BR_Demographics_Sex = new String[] {""} ;
         H002M2_n54BR_Demographics_Sex = new bool[] {false} ;
         H002M2_A53BR_Demographics_BirthDate = new DateTime[] {DateTime.MinValue} ;
         H002M2_n53BR_Demographics_BirthDate = new bool[] {false} ;
         H002M2_A36BR_Information_PatientNo = new String[] {""} ;
         H002M2_n36BR_Information_PatientNo = new bool[] {false} ;
         H002M2_A19BR_EncounterID = new long[1] ;
         H002M2_A61BR_Demographics_ID = new long[1] ;
         H002M3_AGRID_nRecordCount = new long[1] ;
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV6WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         GridRow = new GXWebRow();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sImgUrl = "";
         ROClassString = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_demographicsprompt__default(),
            new Object[][] {
                new Object[] {
               H002M2_A85BR_Information_ID, H002M2_n85BR_Information_ID, H002M2_A60BR_Demographics_City, H002M2_n60BR_Demographics_City, H002M2_A59BR_Demographics_Province, H002M2_n59BR_Demographics_Province, H002M2_A58BR_Demographics_Insurance, H002M2_n58BR_Demographics_Insurance, H002M2_A57BR_Demographics_Occupation, H002M2_n57BR_Demographics_Occupation,
               H002M2_A56BR_Demographics_Education, H002M2_n56BR_Demographics_Education, H002M2_A55BR_Demographics_Ethnic, H002M2_n55BR_Demographics_Ethnic, H002M2_A63BR_Demographics_MarritalStatus, H002M2_n63BR_Demographics_MarritalStatus, H002M2_A54BR_Demographics_Sex, H002M2_n54BR_Demographics_Sex, H002M2_A53BR_Demographics_BirthDate, H002M2_n53BR_Demographics_BirthDate,
               H002M2_A36BR_Information_PatientNo, H002M2_n36BR_Information_PatientNo, H002M2_A19BR_EncounterID, H002M2_A61BR_Demographics_ID
               }
               , new Object[] {
               H002M3_AGRID_nRecordCount
               }
            }
         );
         AV48Pgmname = "BR_DemographicsPrompt";
         /* GeneXus formulas. */
         AV48Pgmname = "BR_DemographicsPrompt";
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
      private short edtBR_Demographics_ID_Titleformat ;
      private short edtBR_EncounterID_Titleformat ;
      private short edtBR_Information_PatientNo_Titleformat ;
      private short edtBR_Demographics_BirthDate_Titleformat ;
      private short edtBR_Demographics_Sex_Titleformat ;
      private short edtBR_Demographics_MarritalStatus_Titleformat ;
      private short edtBR_Demographics_Ethnic_Titleformat ;
      private short edtBR_Demographics_Education_Titleformat ;
      private short edtBR_Demographics_Occupation_Titleformat ;
      private short edtBR_Demographics_Insurance_Titleformat ;
      private short edtBR_Demographics_Province_Titleformat ;
      private short edtBR_Demographics_City_Titleformat ;
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
      private int edtavDdo_br_demographics_idtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_encounteridtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_information_patientnotitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_demographics_birthdatetitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_demographics_sextitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_demographics_marritalstatustitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_demographics_ethnictitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_demographics_educationtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_demographics_occupationtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_demographics_insurancetitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_demographics_provincetitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_demographics_citytitlecontrolidtoreplace_Visible ;
      private int edtavOrderedby_Visible ;
      private int edtavOrdereddsc_Visible ;
      private int subGrid_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int AV41PageToGo ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private int edtavSelect_Enabled ;
      private int edtavSelect_Visible ;
      private long AV8InOutBR_Demographics_ID ;
      private long wcpOAV8InOutBR_Demographics_ID ;
      private long GRID_nFirstRecordOnPage ;
      private long AV42GridCurrentPage ;
      private long AV44GridRecordCount ;
      private long AV43GridPageSize ;
      private long A61BR_Demographics_ID ;
      private long A19BR_EncounterID ;
      private long GRID_nCurrentRecord ;
      private long A85BR_Information_ID ;
      private long GRID_nRecordCount ;
      private String Gridpaginationbar_Selectedpage ;
      private String Ddo_br_demographics_id_Activeeventkey ;
      private String Ddo_br_encounterid_Activeeventkey ;
      private String Ddo_br_information_patientno_Activeeventkey ;
      private String Ddo_br_demographics_birthdate_Activeeventkey ;
      private String Ddo_br_demographics_sex_Activeeventkey ;
      private String Ddo_br_demographics_marritalstatus_Activeeventkey ;
      private String Ddo_br_demographics_ethnic_Activeeventkey ;
      private String Ddo_br_demographics_education_Activeeventkey ;
      private String Ddo_br_demographics_occupation_Activeeventkey ;
      private String Ddo_br_demographics_insurance_Activeeventkey ;
      private String Ddo_br_demographics_province_Activeeventkey ;
      private String Ddo_br_demographics_city_Activeeventkey ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_12_idx="0001" ;
      private String GXKey ;
      private String AV48Pgmname ;
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
      private String Ddo_br_demographics_id_Caption ;
      private String Ddo_br_demographics_id_Tooltip ;
      private String Ddo_br_demographics_id_Cls ;
      private String Ddo_br_demographics_id_Dropdownoptionstype ;
      private String Ddo_br_demographics_id_Titlecontrolidtoreplace ;
      private String Ddo_br_demographics_id_Sortedstatus ;
      private String Ddo_br_demographics_id_Sortasc ;
      private String Ddo_br_demographics_id_Sortdsc ;
      private String Ddo_br_demographics_id_Searchbuttontext ;
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
      private String Ddo_br_demographics_birthdate_Caption ;
      private String Ddo_br_demographics_birthdate_Tooltip ;
      private String Ddo_br_demographics_birthdate_Cls ;
      private String Ddo_br_demographics_birthdate_Dropdownoptionstype ;
      private String Ddo_br_demographics_birthdate_Titlecontrolidtoreplace ;
      private String Ddo_br_demographics_birthdate_Sortedstatus ;
      private String Ddo_br_demographics_birthdate_Sortasc ;
      private String Ddo_br_demographics_birthdate_Sortdsc ;
      private String Ddo_br_demographics_birthdate_Searchbuttontext ;
      private String Ddo_br_demographics_sex_Caption ;
      private String Ddo_br_demographics_sex_Tooltip ;
      private String Ddo_br_demographics_sex_Cls ;
      private String Ddo_br_demographics_sex_Dropdownoptionstype ;
      private String Ddo_br_demographics_sex_Titlecontrolidtoreplace ;
      private String Ddo_br_demographics_sex_Sortedstatus ;
      private String Ddo_br_demographics_sex_Sortasc ;
      private String Ddo_br_demographics_sex_Sortdsc ;
      private String Ddo_br_demographics_sex_Searchbuttontext ;
      private String Ddo_br_demographics_marritalstatus_Caption ;
      private String Ddo_br_demographics_marritalstatus_Tooltip ;
      private String Ddo_br_demographics_marritalstatus_Cls ;
      private String Ddo_br_demographics_marritalstatus_Dropdownoptionstype ;
      private String Ddo_br_demographics_marritalstatus_Titlecontrolidtoreplace ;
      private String Ddo_br_demographics_marritalstatus_Sortedstatus ;
      private String Ddo_br_demographics_marritalstatus_Sortasc ;
      private String Ddo_br_demographics_marritalstatus_Sortdsc ;
      private String Ddo_br_demographics_marritalstatus_Searchbuttontext ;
      private String Ddo_br_demographics_ethnic_Caption ;
      private String Ddo_br_demographics_ethnic_Tooltip ;
      private String Ddo_br_demographics_ethnic_Cls ;
      private String Ddo_br_demographics_ethnic_Dropdownoptionstype ;
      private String Ddo_br_demographics_ethnic_Titlecontrolidtoreplace ;
      private String Ddo_br_demographics_ethnic_Sortedstatus ;
      private String Ddo_br_demographics_ethnic_Sortasc ;
      private String Ddo_br_demographics_ethnic_Sortdsc ;
      private String Ddo_br_demographics_ethnic_Searchbuttontext ;
      private String Ddo_br_demographics_education_Caption ;
      private String Ddo_br_demographics_education_Tooltip ;
      private String Ddo_br_demographics_education_Cls ;
      private String Ddo_br_demographics_education_Dropdownoptionstype ;
      private String Ddo_br_demographics_education_Titlecontrolidtoreplace ;
      private String Ddo_br_demographics_education_Sortedstatus ;
      private String Ddo_br_demographics_education_Sortasc ;
      private String Ddo_br_demographics_education_Sortdsc ;
      private String Ddo_br_demographics_education_Searchbuttontext ;
      private String Ddo_br_demographics_occupation_Caption ;
      private String Ddo_br_demographics_occupation_Tooltip ;
      private String Ddo_br_demographics_occupation_Cls ;
      private String Ddo_br_demographics_occupation_Dropdownoptionstype ;
      private String Ddo_br_demographics_occupation_Titlecontrolidtoreplace ;
      private String Ddo_br_demographics_occupation_Sortedstatus ;
      private String Ddo_br_demographics_occupation_Sortasc ;
      private String Ddo_br_demographics_occupation_Sortdsc ;
      private String Ddo_br_demographics_occupation_Searchbuttontext ;
      private String Ddo_br_demographics_insurance_Caption ;
      private String Ddo_br_demographics_insurance_Tooltip ;
      private String Ddo_br_demographics_insurance_Cls ;
      private String Ddo_br_demographics_insurance_Dropdownoptionstype ;
      private String Ddo_br_demographics_insurance_Titlecontrolidtoreplace ;
      private String Ddo_br_demographics_insurance_Sortedstatus ;
      private String Ddo_br_demographics_insurance_Sortasc ;
      private String Ddo_br_demographics_insurance_Sortdsc ;
      private String Ddo_br_demographics_insurance_Searchbuttontext ;
      private String Ddo_br_demographics_province_Caption ;
      private String Ddo_br_demographics_province_Tooltip ;
      private String Ddo_br_demographics_province_Cls ;
      private String Ddo_br_demographics_province_Dropdownoptionstype ;
      private String Ddo_br_demographics_province_Titlecontrolidtoreplace ;
      private String Ddo_br_demographics_province_Sortedstatus ;
      private String Ddo_br_demographics_province_Sortasc ;
      private String Ddo_br_demographics_province_Sortdsc ;
      private String Ddo_br_demographics_province_Searchbuttontext ;
      private String Ddo_br_demographics_city_Caption ;
      private String Ddo_br_demographics_city_Tooltip ;
      private String Ddo_br_demographics_city_Cls ;
      private String Ddo_br_demographics_city_Dropdownoptionstype ;
      private String Ddo_br_demographics_city_Titlecontrolidtoreplace ;
      private String Ddo_br_demographics_city_Sortedstatus ;
      private String Ddo_br_demographics_city_Sortasc ;
      private String Ddo_br_demographics_city_Sortdsc ;
      private String Ddo_br_demographics_city_Searchbuttontext ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divLayoutmaintable_Internalname ;
      private String divTablemain_Internalname ;
      private String divGridtablewithpaginationbar_Internalname ;
      private String sStyleString ;
      private String subGrid_Internalname ;
      private String subGrid_Class ;
      private String subGrid_Linesclass ;
      private String edtBR_Demographics_ID_Title ;
      private String edtBR_EncounterID_Title ;
      private String edtBR_Information_PatientNo_Title ;
      private String edtBR_Demographics_BirthDate_Title ;
      private String edtBR_Demographics_Sex_Title ;
      private String edtBR_Demographics_MarritalStatus_Title ;
      private String edtBR_Demographics_Ethnic_Title ;
      private String edtBR_Demographics_Education_Title ;
      private String edtBR_Demographics_Occupation_Title ;
      private String edtBR_Demographics_Insurance_Title ;
      private String edtBR_Demographics_Province_Title ;
      private String edtBR_Demographics_City_Title ;
      private String subGrid_Header ;
      private String edtavSelect_Tooltiptext ;
      private String divHtml_gridpaginationbar_Internalname ;
      private String Gridpaginationbar_Internalname ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String Ddo_br_demographics_id_Internalname ;
      private String TempTags ;
      private String ClassString ;
      private String StyleString ;
      private String edtavDdo_br_demographics_idtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_encounterid_Internalname ;
      private String edtavDdo_br_encounteridtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_information_patientno_Internalname ;
      private String edtavDdo_br_information_patientnotitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_demographics_birthdate_Internalname ;
      private String edtavDdo_br_demographics_birthdatetitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_demographics_sex_Internalname ;
      private String edtavDdo_br_demographics_sextitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_demographics_marritalstatus_Internalname ;
      private String edtavDdo_br_demographics_marritalstatustitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_demographics_ethnic_Internalname ;
      private String edtavDdo_br_demographics_ethnictitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_demographics_education_Internalname ;
      private String edtavDdo_br_demographics_educationtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_demographics_occupation_Internalname ;
      private String edtavDdo_br_demographics_occupationtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_demographics_insurance_Internalname ;
      private String edtavDdo_br_demographics_insurancetitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_demographics_province_Internalname ;
      private String edtavDdo_br_demographics_provincetitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_demographics_city_Internalname ;
      private String edtavDdo_br_demographics_citytitlecontrolidtoreplace_Internalname ;
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
      private String edtBR_Demographics_ID_Internalname ;
      private String edtBR_EncounterID_Internalname ;
      private String edtBR_Information_PatientNo_Internalname ;
      private String edtBR_Demographics_BirthDate_Internalname ;
      private String edtBR_Demographics_Sex_Internalname ;
      private String edtBR_Demographics_MarritalStatus_Internalname ;
      private String edtBR_Demographics_Ethnic_Internalname ;
      private String edtBR_Demographics_Education_Internalname ;
      private String edtBR_Demographics_Occupation_Internalname ;
      private String edtBR_Demographics_Insurance_Internalname ;
      private String edtBR_Demographics_Province_Internalname ;
      private String edtBR_Demographics_City_Internalname ;
      private String scmdbuf ;
      private String sGXsfl_12_fel_idx="0001" ;
      private String sImgUrl ;
      private String edtavSelect_Jsonclick ;
      private String ROClassString ;
      private String edtBR_Demographics_ID_Jsonclick ;
      private String edtBR_EncounterID_Jsonclick ;
      private String edtBR_Information_PatientNo_Jsonclick ;
      private String edtBR_Demographics_BirthDate_Jsonclick ;
      private String edtBR_Demographics_Sex_Jsonclick ;
      private String edtBR_Demographics_MarritalStatus_Jsonclick ;
      private String edtBR_Demographics_Ethnic_Jsonclick ;
      private String edtBR_Demographics_Education_Jsonclick ;
      private String edtBR_Demographics_Occupation_Jsonclick ;
      private String edtBR_Demographics_Insurance_Jsonclick ;
      private String edtBR_Demographics_Province_Jsonclick ;
      private String edtBR_Demographics_City_Jsonclick ;
      private DateTime A53BR_Demographics_BirthDate ;
      private bool entryPointCalled ;
      private bool AV11OrderedDsc ;
      private bool toggleJsOutput ;
      private bool Gridpaginationbar_Showfirst ;
      private bool Gridpaginationbar_Showprevious ;
      private bool Gridpaginationbar_Shownext ;
      private bool Gridpaginationbar_Showlast ;
      private bool Gridpaginationbar_Rowsperpageselector ;
      private bool Ddo_br_demographics_id_Includesortasc ;
      private bool Ddo_br_demographics_id_Includesortdsc ;
      private bool Ddo_br_demographics_id_Includefilter ;
      private bool Ddo_br_demographics_id_Includedatalist ;
      private bool Ddo_br_encounterid_Includesortasc ;
      private bool Ddo_br_encounterid_Includesortdsc ;
      private bool Ddo_br_encounterid_Includefilter ;
      private bool Ddo_br_encounterid_Includedatalist ;
      private bool Ddo_br_information_patientno_Includesortasc ;
      private bool Ddo_br_information_patientno_Includesortdsc ;
      private bool Ddo_br_information_patientno_Includefilter ;
      private bool Ddo_br_information_patientno_Includedatalist ;
      private bool Ddo_br_demographics_birthdate_Includesortasc ;
      private bool Ddo_br_demographics_birthdate_Includesortdsc ;
      private bool Ddo_br_demographics_birthdate_Includefilter ;
      private bool Ddo_br_demographics_birthdate_Includedatalist ;
      private bool Ddo_br_demographics_sex_Includesortasc ;
      private bool Ddo_br_demographics_sex_Includesortdsc ;
      private bool Ddo_br_demographics_sex_Includefilter ;
      private bool Ddo_br_demographics_sex_Includedatalist ;
      private bool Ddo_br_demographics_marritalstatus_Includesortasc ;
      private bool Ddo_br_demographics_marritalstatus_Includesortdsc ;
      private bool Ddo_br_demographics_marritalstatus_Includefilter ;
      private bool Ddo_br_demographics_marritalstatus_Includedatalist ;
      private bool Ddo_br_demographics_ethnic_Includesortasc ;
      private bool Ddo_br_demographics_ethnic_Includesortdsc ;
      private bool Ddo_br_demographics_ethnic_Includefilter ;
      private bool Ddo_br_demographics_ethnic_Includedatalist ;
      private bool Ddo_br_demographics_education_Includesortasc ;
      private bool Ddo_br_demographics_education_Includesortdsc ;
      private bool Ddo_br_demographics_education_Includefilter ;
      private bool Ddo_br_demographics_education_Includedatalist ;
      private bool Ddo_br_demographics_occupation_Includesortasc ;
      private bool Ddo_br_demographics_occupation_Includesortdsc ;
      private bool Ddo_br_demographics_occupation_Includefilter ;
      private bool Ddo_br_demographics_occupation_Includedatalist ;
      private bool Ddo_br_demographics_insurance_Includesortasc ;
      private bool Ddo_br_demographics_insurance_Includesortdsc ;
      private bool Ddo_br_demographics_insurance_Includefilter ;
      private bool Ddo_br_demographics_insurance_Includedatalist ;
      private bool Ddo_br_demographics_province_Includesortasc ;
      private bool Ddo_br_demographics_province_Includesortdsc ;
      private bool Ddo_br_demographics_province_Includefilter ;
      private bool Ddo_br_demographics_province_Includedatalist ;
      private bool Ddo_br_demographics_city_Includesortasc ;
      private bool Ddo_br_demographics_city_Includesortdsc ;
      private bool Ddo_br_demographics_city_Includefilter ;
      private bool Ddo_br_demographics_city_Includedatalist ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_12_Refreshing=false ;
      private bool n36BR_Information_PatientNo ;
      private bool n53BR_Demographics_BirthDate ;
      private bool n54BR_Demographics_Sex ;
      private bool n63BR_Demographics_MarritalStatus ;
      private bool n55BR_Demographics_Ethnic ;
      private bool n56BR_Demographics_Education ;
      private bool n57BR_Demographics_Occupation ;
      private bool n58BR_Demographics_Insurance ;
      private bool n59BR_Demographics_Province ;
      private bool n60BR_Demographics_City ;
      private bool gxdyncontrolsrefreshing ;
      private bool n85BR_Information_ID ;
      private bool returnInSub ;
      private bool AV5IsAuthorized ;
      private bool GXt_boolean1 ;
      private bool gx_refresh_fired ;
      private bool AV45Select_IsBlob ;
      private String AV13ddo_BR_Demographics_IDTitleControlIdToReplace ;
      private String AV15ddo_BR_EncounterIDTitleControlIdToReplace ;
      private String AV19ddo_BR_Information_PatientNoTitleControlIdToReplace ;
      private String AV21ddo_BR_Demographics_BirthDateTitleControlIdToReplace ;
      private String AV25ddo_BR_Demographics_SexTitleControlIdToReplace ;
      private String AV27ddo_BR_Demographics_MarritalStatusTitleControlIdToReplace ;
      private String AV29ddo_BR_Demographics_EthnicTitleControlIdToReplace ;
      private String AV31ddo_BR_Demographics_EducationTitleControlIdToReplace ;
      private String AV33ddo_BR_Demographics_OccupationTitleControlIdToReplace ;
      private String AV35ddo_BR_Demographics_InsuranceTitleControlIdToReplace ;
      private String AV37ddo_BR_Demographics_ProvinceTitleControlIdToReplace ;
      private String AV39ddo_BR_Demographics_CityTitleControlIdToReplace ;
      private String A36BR_Information_PatientNo ;
      private String A54BR_Demographics_Sex ;
      private String A63BR_Demographics_MarritalStatus ;
      private String A55BR_Demographics_Ethnic ;
      private String A56BR_Demographics_Education ;
      private String A57BR_Demographics_Occupation ;
      private String A58BR_Demographics_Insurance ;
      private String A59BR_Demographics_Province ;
      private String A60BR_Demographics_City ;
      private String AV49Select_GXI ;
      private String AV45Select ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private GXUserControl ucGridpaginationbar ;
      private GXUserControl ucDdo_br_demographics_id ;
      private GXUserControl ucDdo_br_encounterid ;
      private GXUserControl ucDdo_br_information_patientno ;
      private GXUserControl ucDdo_br_demographics_birthdate ;
      private GXUserControl ucDdo_br_demographics_sex ;
      private GXUserControl ucDdo_br_demographics_marritalstatus ;
      private GXUserControl ucDdo_br_demographics_ethnic ;
      private GXUserControl ucDdo_br_demographics_education ;
      private GXUserControl ucDdo_br_demographics_occupation ;
      private GXUserControl ucDdo_br_demographics_insurance ;
      private GXUserControl ucDdo_br_demographics_province ;
      private GXUserControl ucDdo_br_demographics_city ;
      private GXUserControl ucWorkwithplusutilities1 ;
      private GXWebForm Form ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private long aP0_InOutBR_Demographics_ID ;
      private IDataStoreProvider pr_default ;
      private long[] H002M2_A85BR_Information_ID ;
      private bool[] H002M2_n85BR_Information_ID ;
      private String[] H002M2_A60BR_Demographics_City ;
      private bool[] H002M2_n60BR_Demographics_City ;
      private String[] H002M2_A59BR_Demographics_Province ;
      private bool[] H002M2_n59BR_Demographics_Province ;
      private String[] H002M2_A58BR_Demographics_Insurance ;
      private bool[] H002M2_n58BR_Demographics_Insurance ;
      private String[] H002M2_A57BR_Demographics_Occupation ;
      private bool[] H002M2_n57BR_Demographics_Occupation ;
      private String[] H002M2_A56BR_Demographics_Education ;
      private bool[] H002M2_n56BR_Demographics_Education ;
      private String[] H002M2_A55BR_Demographics_Ethnic ;
      private bool[] H002M2_n55BR_Demographics_Ethnic ;
      private String[] H002M2_A63BR_Demographics_MarritalStatus ;
      private bool[] H002M2_n63BR_Demographics_MarritalStatus ;
      private String[] H002M2_A54BR_Demographics_Sex ;
      private bool[] H002M2_n54BR_Demographics_Sex ;
      private DateTime[] H002M2_A53BR_Demographics_BirthDate ;
      private bool[] H002M2_n53BR_Demographics_BirthDate ;
      private String[] H002M2_A36BR_Information_PatientNo ;
      private bool[] H002M2_n36BR_Information_PatientNo ;
      private long[] H002M2_A19BR_EncounterID ;
      private long[] H002M2_A61BR_Demographics_ID ;
      private long[] H002M3_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV12BR_Demographics_IDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV14BR_EncounterIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV18BR_Information_PatientNoTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV20BR_Demographics_BirthDateTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV24BR_Demographics_SexTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV26BR_Demographics_MarritalStatusTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV28BR_Demographics_EthnicTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV30BR_Demographics_EducationTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV32BR_Demographics_OccupationTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV34BR_Demographics_InsuranceTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV36BR_Demographics_ProvinceTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV38BR_Demographics_CityTitleFilterData ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons AV40DDO_TitleSettingsIcons ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 ;
   }

   public class br_demographicsprompt__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H002M2( IGxContext context ,
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
         sSelectString = " T2.[BR_Information_ID], T1.[BR_Demographics_City], T1.[BR_Demographics_Province], T1.[BR_Demographics_Insurance], T1.[BR_Demographics_Occupation], T1.[BR_Demographics_Education], T1.[BR_Demographics_Ethnic], T1.[BR_Demographics_MarritalStatus], T1.[BR_Demographics_Sex], T1.[BR_Demographics_BirthDate], T3.[BR_Information_PatientNo], T1.[BR_EncounterID], T1.[BR_Demographics_ID]";
         sFromString = " FROM (([BR_Demographics] T1 WITH (NOLOCK) INNER JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = T1.[BR_EncounterID]) LEFT JOIN [BR_Information] T3 WITH (NOLOCK) ON T3.[BR_Information_ID] = T2.[BR_Information_ID])";
         sOrderString = "";
         if ( ( AV10OrderedBy == 1 ) && ! AV11OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Demographics_ID]";
         }
         else if ( ( AV10OrderedBy == 1 ) && ( AV11OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Demographics_ID] DESC";
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
            sOrderString = sOrderString + " ORDER BY T1.[BR_Demographics_BirthDate]";
         }
         else if ( ( AV10OrderedBy == 4 ) && ( AV11OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Demographics_BirthDate] DESC";
         }
         else if ( ( AV10OrderedBy == 5 ) && ! AV11OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Demographics_Sex]";
         }
         else if ( ( AV10OrderedBy == 5 ) && ( AV11OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Demographics_Sex] DESC";
         }
         else if ( ( AV10OrderedBy == 6 ) && ! AV11OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Demographics_MarritalStatus]";
         }
         else if ( ( AV10OrderedBy == 6 ) && ( AV11OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Demographics_MarritalStatus] DESC";
         }
         else if ( ( AV10OrderedBy == 7 ) && ! AV11OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Demographics_Ethnic]";
         }
         else if ( ( AV10OrderedBy == 7 ) && ( AV11OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Demographics_Ethnic] DESC";
         }
         else if ( ( AV10OrderedBy == 8 ) && ! AV11OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Demographics_Education]";
         }
         else if ( ( AV10OrderedBy == 8 ) && ( AV11OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Demographics_Education] DESC";
         }
         else if ( ( AV10OrderedBy == 9 ) && ! AV11OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Demographics_Occupation]";
         }
         else if ( ( AV10OrderedBy == 9 ) && ( AV11OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Demographics_Occupation] DESC";
         }
         else if ( ( AV10OrderedBy == 10 ) && ! AV11OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Demographics_Insurance]";
         }
         else if ( ( AV10OrderedBy == 10 ) && ( AV11OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Demographics_Insurance] DESC";
         }
         else if ( ( AV10OrderedBy == 11 ) && ! AV11OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Demographics_Province]";
         }
         else if ( ( AV10OrderedBy == 11 ) && ( AV11OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Demographics_Province] DESC";
         }
         else if ( ( AV10OrderedBy == 12 ) && ! AV11OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Demographics_City]";
         }
         else if ( ( AV10OrderedBy == 12 ) && ( AV11OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Demographics_City] DESC";
         }
         else if ( true )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Demographics_ID]";
         }
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object4[0] = scmdbuf;
         GXv_Object4[1] = GXv_int3;
         return GXv_Object4 ;
      }

      protected Object[] conditional_H002M3( IGxContext context ,
                                             short AV10OrderedBy ,
                                             bool AV11OrderedDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         Object[] GXv_Object5 ;
         GXv_Object5 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM (([BR_Demographics] T1 WITH (NOLOCK) INNER JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = T1.[BR_EncounterID]) LEFT JOIN [BR_Information] T3 WITH (NOLOCK) ON T3.[BR_Information_ID] = T2.[BR_Information_ID])";
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
                     return conditional_H002M2(context, (short)dynConstraints[0] , (bool)dynConstraints[1] );
               case 1 :
                     return conditional_H002M3(context, (short)dynConstraints[0] , (bool)dynConstraints[1] );
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
          Object[] prmH002M2 ;
          prmH002M2 = new Object[] {
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH002M3 ;
          prmH002M3 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("H002M2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002M2,11,0,true,false )
             ,new CursorDef("H002M3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002M3,1,0,true,false )
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
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((String[]) buf[4])[0] = rslt.getVarchar(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((String[]) buf[6])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((String[]) buf[8])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((String[]) buf[10])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(6);
                ((String[]) buf[12])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(7);
                ((String[]) buf[14])[0] = rslt.getVarchar(8) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(8);
                ((String[]) buf[16])[0] = rslt.getVarchar(9) ;
                ((bool[]) buf[17])[0] = rslt.wasNull(9);
                ((DateTime[]) buf[18])[0] = rslt.getGXDate(10) ;
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
