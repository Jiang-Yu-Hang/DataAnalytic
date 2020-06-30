/*
               File: BR_ProcedurePrompt
        Description: 选择诊疗处理
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:11:23.89
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
   public class br_procedureprompt : GXHttpHandler, System.Web.SessionState.IRequiresSessionState
   {
      public br_procedureprompt( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_procedureprompt( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( ref long aP0_InOutBR_ProcedureID )
      {
         this.AV8InOutBR_ProcedureID = aP0_InOutBR_ProcedureID;
         executePrivate();
         aP0_InOutBR_ProcedureID=this.AV8InOutBR_ProcedureID;
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         cmbBR_Procedure_PXSurgery = new GXCombobox();
         cmbBR_Procedure_PXRadiotherapy = new GXCombobox();
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
               AV13ddo_BR_ProcedureIDTitleControlIdToReplace = GetNextPar( );
               AV15ddo_BR_EncounterIDTitleControlIdToReplace = GetNextPar( );
               AV17ddo_BR_Information_PatientNoTitleControlIdToReplace = GetNextPar( );
               AV19ddo_BR_Procedure_PXIDTitleControlIdToReplace = GetNextPar( );
               AV21ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace = GetNextPar( );
               AV45ddo_BR_Procedure_DateTitleControlIdToReplace = GetNextPar( );
               AV25ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace = GetNextPar( );
               AV49ddo_BR_Procedure_RadioDateTitleControlIdToReplace = GetNextPar( );
               AV51ddo_BR_Procedure_RadioTimeTitleControlIdToReplace = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid_refresh( subGrid_Rows, AV10OrderedBy, AV11OrderedDsc, AV13ddo_BR_ProcedureIDTitleControlIdToReplace, AV15ddo_BR_EncounterIDTitleControlIdToReplace, AV17ddo_BR_Information_PatientNoTitleControlIdToReplace, AV19ddo_BR_Procedure_PXIDTitleControlIdToReplace, AV21ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace, AV45ddo_BR_Procedure_DateTitleControlIdToReplace, AV25ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace, AV49ddo_BR_Procedure_RadioDateTitleControlIdToReplace, AV51ddo_BR_Procedure_RadioTimeTitleControlIdToReplace) ;
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
               AV8InOutBR_ProcedureID = (long)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8InOutBR_ProcedureID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8InOutBR_ProcedureID), 18, 0)));
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
            PA3P2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV54Pgmname = "BR_ProcedurePrompt";
               context.Gx_err = 0;
               WS3P2( ) ;
               if ( ! isAjaxCallMode( ) )
               {
                  WE3P2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?20202281511243", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_procedureprompt.aspx") + "?" + UrlEncode("" +AV8InOutBR_ProcedureID)+"\">") ;
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
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_PROCEDUREIDTITLEFILTERDATA", AV12BR_ProcedureIDTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_PROCEDUREIDTITLEFILTERDATA", AV12BR_ProcedureIDTitleFilterData);
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
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_PROCEDURE_PXIDTITLEFILTERDATA", AV18BR_Procedure_PXIDTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_PROCEDURE_PXIDTITLEFILTERDATA", AV18BR_Procedure_PXIDTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_PROCEDURE_PXSURGERYTITLEFILTERDATA", AV20BR_Procedure_PXSurgeryTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_PROCEDURE_PXSURGERYTITLEFILTERDATA", AV20BR_Procedure_PXSurgeryTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_PROCEDURE_DATETITLEFILTERDATA", AV44BR_Procedure_DateTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_PROCEDURE_DATETITLEFILTERDATA", AV44BR_Procedure_DateTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_PROCEDURE_PXRADIOTHERAPYTITLEFILTERDATA", AV24BR_Procedure_PXRadiotherapyTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_PROCEDURE_PXRADIOTHERAPYTITLEFILTERDATA", AV24BR_Procedure_PXRadiotherapyTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_PROCEDURE_RADIODATETITLEFILTERDATA", AV48BR_Procedure_RadioDateTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_PROCEDURE_RADIODATETITLEFILTERDATA", AV48BR_Procedure_RadioDateTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_PROCEDURE_RADIOTIMETITLEFILTERDATA", AV50BR_Procedure_RadioTimeTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_PROCEDURE_RADIOTIMETITLEFILTERDATA", AV50BR_Procedure_RadioTimeTitleFilterData);
         }
         GxWebStd.gx_hidden_field( context, "vINOUTBR_PROCEDUREID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8InOutBR_ProcedureID), 18, 0, ".", "")));
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
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDUREID_Caption", StringUtil.RTrim( Ddo_br_procedureid_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDUREID_Tooltip", StringUtil.RTrim( Ddo_br_procedureid_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDUREID_Cls", StringUtil.RTrim( Ddo_br_procedureid_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDUREID_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_procedureid_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDUREID_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_procedureid_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDUREID_Includesortasc", StringUtil.BoolToStr( Ddo_br_procedureid_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDUREID_Includesortdsc", StringUtil.BoolToStr( Ddo_br_procedureid_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDUREID_Sortedstatus", StringUtil.RTrim( Ddo_br_procedureid_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDUREID_Includefilter", StringUtil.BoolToStr( Ddo_br_procedureid_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDUREID_Includedatalist", StringUtil.BoolToStr( Ddo_br_procedureid_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDUREID_Sortasc", StringUtil.RTrim( Ddo_br_procedureid_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDUREID_Sortdsc", StringUtil.RTrim( Ddo_br_procedureid_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDUREID_Searchbuttontext", StringUtil.RTrim( Ddo_br_procedureid_Searchbuttontext));
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
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXID_Caption", StringUtil.RTrim( Ddo_br_procedure_pxid_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXID_Tooltip", StringUtil.RTrim( Ddo_br_procedure_pxid_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXID_Cls", StringUtil.RTrim( Ddo_br_procedure_pxid_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXID_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_procedure_pxid_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXID_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_procedure_pxid_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXID_Includesortasc", StringUtil.BoolToStr( Ddo_br_procedure_pxid_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXID_Includesortdsc", StringUtil.BoolToStr( Ddo_br_procedure_pxid_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXID_Sortedstatus", StringUtil.RTrim( Ddo_br_procedure_pxid_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXID_Includefilter", StringUtil.BoolToStr( Ddo_br_procedure_pxid_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXID_Includedatalist", StringUtil.BoolToStr( Ddo_br_procedure_pxid_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXID_Sortasc", StringUtil.RTrim( Ddo_br_procedure_pxid_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXID_Sortdsc", StringUtil.RTrim( Ddo_br_procedure_pxid_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXID_Searchbuttontext", StringUtil.RTrim( Ddo_br_procedure_pxid_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXSURGERY_Caption", StringUtil.RTrim( Ddo_br_procedure_pxsurgery_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXSURGERY_Tooltip", StringUtil.RTrim( Ddo_br_procedure_pxsurgery_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXSURGERY_Cls", StringUtil.RTrim( Ddo_br_procedure_pxsurgery_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXSURGERY_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_procedure_pxsurgery_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXSURGERY_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_procedure_pxsurgery_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXSURGERY_Includesortasc", StringUtil.BoolToStr( Ddo_br_procedure_pxsurgery_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXSURGERY_Includesortdsc", StringUtil.BoolToStr( Ddo_br_procedure_pxsurgery_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXSURGERY_Sortedstatus", StringUtil.RTrim( Ddo_br_procedure_pxsurgery_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXSURGERY_Includefilter", StringUtil.BoolToStr( Ddo_br_procedure_pxsurgery_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXSURGERY_Includedatalist", StringUtil.BoolToStr( Ddo_br_procedure_pxsurgery_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXSURGERY_Sortasc", StringUtil.RTrim( Ddo_br_procedure_pxsurgery_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXSURGERY_Sortdsc", StringUtil.RTrim( Ddo_br_procedure_pxsurgery_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXSURGERY_Searchbuttontext", StringUtil.RTrim( Ddo_br_procedure_pxsurgery_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_DATE_Caption", StringUtil.RTrim( Ddo_br_procedure_date_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_DATE_Tooltip", StringUtil.RTrim( Ddo_br_procedure_date_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_DATE_Cls", StringUtil.RTrim( Ddo_br_procedure_date_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_DATE_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_procedure_date_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_DATE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_procedure_date_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_DATE_Includesortasc", StringUtil.BoolToStr( Ddo_br_procedure_date_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_DATE_Includesortdsc", StringUtil.BoolToStr( Ddo_br_procedure_date_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_DATE_Sortedstatus", StringUtil.RTrim( Ddo_br_procedure_date_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_DATE_Includefilter", StringUtil.BoolToStr( Ddo_br_procedure_date_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_DATE_Includedatalist", StringUtil.BoolToStr( Ddo_br_procedure_date_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_DATE_Sortasc", StringUtil.RTrim( Ddo_br_procedure_date_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_DATE_Sortdsc", StringUtil.RTrim( Ddo_br_procedure_date_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_DATE_Searchbuttontext", StringUtil.RTrim( Ddo_br_procedure_date_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXRADIOTHERAPY_Caption", StringUtil.RTrim( Ddo_br_procedure_pxradiotherapy_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXRADIOTHERAPY_Tooltip", StringUtil.RTrim( Ddo_br_procedure_pxradiotherapy_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXRADIOTHERAPY_Cls", StringUtil.RTrim( Ddo_br_procedure_pxradiotherapy_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXRADIOTHERAPY_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_procedure_pxradiotherapy_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXRADIOTHERAPY_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_procedure_pxradiotherapy_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXRADIOTHERAPY_Includesortasc", StringUtil.BoolToStr( Ddo_br_procedure_pxradiotherapy_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXRADIOTHERAPY_Includesortdsc", StringUtil.BoolToStr( Ddo_br_procedure_pxradiotherapy_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXRADIOTHERAPY_Sortedstatus", StringUtil.RTrim( Ddo_br_procedure_pxradiotherapy_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXRADIOTHERAPY_Includefilter", StringUtil.BoolToStr( Ddo_br_procedure_pxradiotherapy_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXRADIOTHERAPY_Includedatalist", StringUtil.BoolToStr( Ddo_br_procedure_pxradiotherapy_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXRADIOTHERAPY_Sortasc", StringUtil.RTrim( Ddo_br_procedure_pxradiotherapy_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXRADIOTHERAPY_Sortdsc", StringUtil.RTrim( Ddo_br_procedure_pxradiotherapy_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXRADIOTHERAPY_Searchbuttontext", StringUtil.RTrim( Ddo_br_procedure_pxradiotherapy_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIODATE_Caption", StringUtil.RTrim( Ddo_br_procedure_radiodate_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIODATE_Tooltip", StringUtil.RTrim( Ddo_br_procedure_radiodate_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIODATE_Cls", StringUtil.RTrim( Ddo_br_procedure_radiodate_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIODATE_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_procedure_radiodate_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIODATE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_procedure_radiodate_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIODATE_Includesortasc", StringUtil.BoolToStr( Ddo_br_procedure_radiodate_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIODATE_Includesortdsc", StringUtil.BoolToStr( Ddo_br_procedure_radiodate_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIODATE_Sortedstatus", StringUtil.RTrim( Ddo_br_procedure_radiodate_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIODATE_Includefilter", StringUtil.BoolToStr( Ddo_br_procedure_radiodate_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIODATE_Includedatalist", StringUtil.BoolToStr( Ddo_br_procedure_radiodate_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIODATE_Sortasc", StringUtil.RTrim( Ddo_br_procedure_radiodate_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIODATE_Sortdsc", StringUtil.RTrim( Ddo_br_procedure_radiodate_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIODATE_Searchbuttontext", StringUtil.RTrim( Ddo_br_procedure_radiodate_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIOTIME_Caption", StringUtil.RTrim( Ddo_br_procedure_radiotime_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIOTIME_Tooltip", StringUtil.RTrim( Ddo_br_procedure_radiotime_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIOTIME_Cls", StringUtil.RTrim( Ddo_br_procedure_radiotime_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIOTIME_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_procedure_radiotime_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIOTIME_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_procedure_radiotime_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIOTIME_Includesortasc", StringUtil.BoolToStr( Ddo_br_procedure_radiotime_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIOTIME_Includesortdsc", StringUtil.BoolToStr( Ddo_br_procedure_radiotime_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIOTIME_Sortedstatus", StringUtil.RTrim( Ddo_br_procedure_radiotime_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIOTIME_Includefilter", StringUtil.BoolToStr( Ddo_br_procedure_radiotime_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIOTIME_Includedatalist", StringUtil.BoolToStr( Ddo_br_procedure_radiotime_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIOTIME_Sortasc", StringUtil.RTrim( Ddo_br_procedure_radiotime_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIOTIME_Sortdsc", StringUtil.RTrim( Ddo_br_procedure_radiotime_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIOTIME_Searchbuttontext", StringUtil.RTrim( Ddo_br_procedure_radiotime_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDUREID_Activeeventkey", StringUtil.RTrim( Ddo_br_procedureid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Activeeventkey", StringUtil.RTrim( Ddo_br_encounterid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Activeeventkey", StringUtil.RTrim( Ddo_br_information_patientno_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXID_Activeeventkey", StringUtil.RTrim( Ddo_br_procedure_pxid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXSURGERY_Activeeventkey", StringUtil.RTrim( Ddo_br_procedure_pxsurgery_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_DATE_Activeeventkey", StringUtil.RTrim( Ddo_br_procedure_date_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXRADIOTHERAPY_Activeeventkey", StringUtil.RTrim( Ddo_br_procedure_pxradiotherapy_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIODATE_Activeeventkey", StringUtil.RTrim( Ddo_br_procedure_radiodate_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIOTIME_Activeeventkey", StringUtil.RTrim( Ddo_br_procedure_radiotime_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDUREID_Activeeventkey", StringUtil.RTrim( Ddo_br_procedureid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Activeeventkey", StringUtil.RTrim( Ddo_br_encounterid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_INFORMATION_PATIENTNO_Activeeventkey", StringUtil.RTrim( Ddo_br_information_patientno_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXID_Activeeventkey", StringUtil.RTrim( Ddo_br_procedure_pxid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXSURGERY_Activeeventkey", StringUtil.RTrim( Ddo_br_procedure_pxsurgery_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_DATE_Activeeventkey", StringUtil.RTrim( Ddo_br_procedure_date_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_PXRADIOTHERAPY_Activeeventkey", StringUtil.RTrim( Ddo_br_procedure_pxradiotherapy_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIODATE_Activeeventkey", StringUtil.RTrim( Ddo_br_procedure_radiodate_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIOTIME_Activeeventkey", StringUtil.RTrim( Ddo_br_procedure_radiotime_Activeeventkey));
      }

      protected void RenderHtmlCloseForm3P2( )
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
         return "BR_ProcedurePrompt" ;
      }

      public override String GetPgmdesc( )
      {
         return "选择诊疗处理" ;
      }

      protected void WB3P0( )
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
               if ( edtBR_ProcedureID_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_ProcedureID_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_ProcedureID_Title) ;
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
               if ( edtBR_Procedure_PXID_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Procedure_PXID_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Procedure_PXID_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( cmbBR_Procedure_PXSurgery_Titleformat == 0 )
               {
                  context.SendWebValue( cmbBR_Procedure_PXSurgery.Title.Text) ;
               }
               else
               {
                  context.WriteHtmlText( cmbBR_Procedure_PXSurgery.Title.Text) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Procedure_Date_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Procedure_Date_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Procedure_Date_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( cmbBR_Procedure_PXRadiotherapy_Titleformat == 0 )
               {
                  context.SendWebValue( cmbBR_Procedure_PXRadiotherapy.Title.Text) ;
               }
               else
               {
                  context.WriteHtmlText( cmbBR_Procedure_PXRadiotherapy.Title.Text) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Procedure_RadioDate_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Procedure_RadioDate_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Procedure_RadioDate_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Procedure_RadioTime_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Procedure_RadioTime_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Procedure_RadioTime_Title) ;
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
               GridColumn.AddObjectProperty("Value", context.convertURL( AV43Select));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavSelect_Tooltiptext));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A139BR_ProcedureID), 18, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_ProcedureID_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_ProcedureID_Titleformat), 4, 0, ".", "")));
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
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A140BR_Procedure_PXID), 10, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Procedure_PXID_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Procedure_PXID_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A141BR_Procedure_PXSurgery);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( cmbBR_Procedure_PXSurgery.Title.Text));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(cmbBR_Procedure_PXSurgery_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.localUtil.Format(A266BR_Procedure_Date, "9999/99/99"));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Procedure_Date_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Procedure_Date_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A143BR_Procedure_PXRadiotherapy);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( cmbBR_Procedure_PXRadiotherapy.Title.Text));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(cmbBR_Procedure_PXRadiotherapy_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.localUtil.Format(A268BR_Procedure_RadioDate, "9999/99/99"));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Procedure_RadioDate_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Procedure_RadioDate_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A269BR_Procedure_RadioTime, 15, 5, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Procedure_RadioTime_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Procedure_RadioTime_Titleformat), 4, 0, ".", "")));
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
            ucDdo_br_procedureid.SetProperty("Caption", Ddo_br_procedureid_Caption);
            ucDdo_br_procedureid.SetProperty("Tooltip", Ddo_br_procedureid_Tooltip);
            ucDdo_br_procedureid.SetProperty("Cls", Ddo_br_procedureid_Cls);
            ucDdo_br_procedureid.SetProperty("DropDownOptionsType", Ddo_br_procedureid_Dropdownoptionstype);
            ucDdo_br_procedureid.SetProperty("IncludeSortASC", Ddo_br_procedureid_Includesortasc);
            ucDdo_br_procedureid.SetProperty("IncludeSortDSC", Ddo_br_procedureid_Includesortdsc);
            ucDdo_br_procedureid.SetProperty("IncludeFilter", Ddo_br_procedureid_Includefilter);
            ucDdo_br_procedureid.SetProperty("IncludeDataList", Ddo_br_procedureid_Includedatalist);
            ucDdo_br_procedureid.SetProperty("SortASC", Ddo_br_procedureid_Sortasc);
            ucDdo_br_procedureid.SetProperty("SortDSC", Ddo_br_procedureid_Sortdsc);
            ucDdo_br_procedureid.SetProperty("SearchButtonText", Ddo_br_procedureid_Searchbuttontext);
            ucDdo_br_procedureid.SetProperty("DropDownOptionsTitleSettingsIcons", AV38DDO_TitleSettingsIcons);
            ucDdo_br_procedureid.SetProperty("DropDownOptionsData", AV12BR_ProcedureIDTitleFilterData);
            ucDdo_br_procedureid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_procedureid_Internalname, "DDO_BR_PROCEDUREIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 31,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_procedureidtitlecontrolidtoreplace_Internalname, AV13ddo_BR_ProcedureIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,31);\"", 0, edtavDdo_br_procedureidtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_ProcedurePrompt.htm");
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
            ucDdo_br_encounterid.SetProperty("DropDownOptionsTitleSettingsIcons", AV38DDO_TitleSettingsIcons);
            ucDdo_br_encounterid.SetProperty("DropDownOptionsData", AV14BR_EncounterIDTitleFilterData);
            ucDdo_br_encounterid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_encounterid_Internalname, "DDO_BR_ENCOUNTERIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 33,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_encounteridtitlecontrolidtoreplace_Internalname, AV15ddo_BR_EncounterIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,33);\"", 0, edtavDdo_br_encounteridtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_ProcedurePrompt.htm");
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
            ucDdo_br_information_patientno.SetProperty("DropDownOptionsTitleSettingsIcons", AV38DDO_TitleSettingsIcons);
            ucDdo_br_information_patientno.SetProperty("DropDownOptionsData", AV16BR_Information_PatientNoTitleFilterData);
            ucDdo_br_information_patientno.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_information_patientno_Internalname, "DDO_BR_INFORMATION_PATIENTNOContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 35,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_information_patientnotitlecontrolidtoreplace_Internalname, AV17ddo_BR_Information_PatientNoTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,35);\"", 0, edtavDdo_br_information_patientnotitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_ProcedurePrompt.htm");
            /* User Defined Control */
            ucDdo_br_procedure_pxid.SetProperty("Caption", Ddo_br_procedure_pxid_Caption);
            ucDdo_br_procedure_pxid.SetProperty("Tooltip", Ddo_br_procedure_pxid_Tooltip);
            ucDdo_br_procedure_pxid.SetProperty("Cls", Ddo_br_procedure_pxid_Cls);
            ucDdo_br_procedure_pxid.SetProperty("DropDownOptionsType", Ddo_br_procedure_pxid_Dropdownoptionstype);
            ucDdo_br_procedure_pxid.SetProperty("IncludeSortASC", Ddo_br_procedure_pxid_Includesortasc);
            ucDdo_br_procedure_pxid.SetProperty("IncludeSortDSC", Ddo_br_procedure_pxid_Includesortdsc);
            ucDdo_br_procedure_pxid.SetProperty("IncludeFilter", Ddo_br_procedure_pxid_Includefilter);
            ucDdo_br_procedure_pxid.SetProperty("IncludeDataList", Ddo_br_procedure_pxid_Includedatalist);
            ucDdo_br_procedure_pxid.SetProperty("SortASC", Ddo_br_procedure_pxid_Sortasc);
            ucDdo_br_procedure_pxid.SetProperty("SortDSC", Ddo_br_procedure_pxid_Sortdsc);
            ucDdo_br_procedure_pxid.SetProperty("SearchButtonText", Ddo_br_procedure_pxid_Searchbuttontext);
            ucDdo_br_procedure_pxid.SetProperty("DropDownOptionsTitleSettingsIcons", AV38DDO_TitleSettingsIcons);
            ucDdo_br_procedure_pxid.SetProperty("DropDownOptionsData", AV18BR_Procedure_PXIDTitleFilterData);
            ucDdo_br_procedure_pxid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_procedure_pxid_Internalname, "DDO_BR_PROCEDURE_PXIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 37,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_procedure_pxidtitlecontrolidtoreplace_Internalname, AV19ddo_BR_Procedure_PXIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,37);\"", 0, edtavDdo_br_procedure_pxidtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_ProcedurePrompt.htm");
            /* User Defined Control */
            ucDdo_br_procedure_pxsurgery.SetProperty("Caption", Ddo_br_procedure_pxsurgery_Caption);
            ucDdo_br_procedure_pxsurgery.SetProperty("Tooltip", Ddo_br_procedure_pxsurgery_Tooltip);
            ucDdo_br_procedure_pxsurgery.SetProperty("Cls", Ddo_br_procedure_pxsurgery_Cls);
            ucDdo_br_procedure_pxsurgery.SetProperty("DropDownOptionsType", Ddo_br_procedure_pxsurgery_Dropdownoptionstype);
            ucDdo_br_procedure_pxsurgery.SetProperty("IncludeSortASC", Ddo_br_procedure_pxsurgery_Includesortasc);
            ucDdo_br_procedure_pxsurgery.SetProperty("IncludeSortDSC", Ddo_br_procedure_pxsurgery_Includesortdsc);
            ucDdo_br_procedure_pxsurgery.SetProperty("IncludeFilter", Ddo_br_procedure_pxsurgery_Includefilter);
            ucDdo_br_procedure_pxsurgery.SetProperty("IncludeDataList", Ddo_br_procedure_pxsurgery_Includedatalist);
            ucDdo_br_procedure_pxsurgery.SetProperty("SortASC", Ddo_br_procedure_pxsurgery_Sortasc);
            ucDdo_br_procedure_pxsurgery.SetProperty("SortDSC", Ddo_br_procedure_pxsurgery_Sortdsc);
            ucDdo_br_procedure_pxsurgery.SetProperty("SearchButtonText", Ddo_br_procedure_pxsurgery_Searchbuttontext);
            ucDdo_br_procedure_pxsurgery.SetProperty("DropDownOptionsTitleSettingsIcons", AV38DDO_TitleSettingsIcons);
            ucDdo_br_procedure_pxsurgery.SetProperty("DropDownOptionsData", AV20BR_Procedure_PXSurgeryTitleFilterData);
            ucDdo_br_procedure_pxsurgery.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_procedure_pxsurgery_Internalname, "DDO_BR_PROCEDURE_PXSURGERYContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_procedure_pxsurgerytitlecontrolidtoreplace_Internalname, AV21ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,39);\"", 0, edtavDdo_br_procedure_pxsurgerytitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_ProcedurePrompt.htm");
            /* User Defined Control */
            ucDdo_br_procedure_date.SetProperty("Caption", Ddo_br_procedure_date_Caption);
            ucDdo_br_procedure_date.SetProperty("Tooltip", Ddo_br_procedure_date_Tooltip);
            ucDdo_br_procedure_date.SetProperty("Cls", Ddo_br_procedure_date_Cls);
            ucDdo_br_procedure_date.SetProperty("DropDownOptionsType", Ddo_br_procedure_date_Dropdownoptionstype);
            ucDdo_br_procedure_date.SetProperty("IncludeSortASC", Ddo_br_procedure_date_Includesortasc);
            ucDdo_br_procedure_date.SetProperty("IncludeSortDSC", Ddo_br_procedure_date_Includesortdsc);
            ucDdo_br_procedure_date.SetProperty("IncludeFilter", Ddo_br_procedure_date_Includefilter);
            ucDdo_br_procedure_date.SetProperty("IncludeDataList", Ddo_br_procedure_date_Includedatalist);
            ucDdo_br_procedure_date.SetProperty("SortASC", Ddo_br_procedure_date_Sortasc);
            ucDdo_br_procedure_date.SetProperty("SortDSC", Ddo_br_procedure_date_Sortdsc);
            ucDdo_br_procedure_date.SetProperty("SearchButtonText", Ddo_br_procedure_date_Searchbuttontext);
            ucDdo_br_procedure_date.SetProperty("DropDownOptionsTitleSettingsIcons", AV38DDO_TitleSettingsIcons);
            ucDdo_br_procedure_date.SetProperty("DropDownOptionsData", AV44BR_Procedure_DateTitleFilterData);
            ucDdo_br_procedure_date.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_procedure_date_Internalname, "DDO_BR_PROCEDURE_DATEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 41,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_procedure_datetitlecontrolidtoreplace_Internalname, AV45ddo_BR_Procedure_DateTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,41);\"", 0, edtavDdo_br_procedure_datetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_ProcedurePrompt.htm");
            /* User Defined Control */
            ucDdo_br_procedure_pxradiotherapy.SetProperty("Caption", Ddo_br_procedure_pxradiotherapy_Caption);
            ucDdo_br_procedure_pxradiotherapy.SetProperty("Tooltip", Ddo_br_procedure_pxradiotherapy_Tooltip);
            ucDdo_br_procedure_pxradiotherapy.SetProperty("Cls", Ddo_br_procedure_pxradiotherapy_Cls);
            ucDdo_br_procedure_pxradiotherapy.SetProperty("DropDownOptionsType", Ddo_br_procedure_pxradiotherapy_Dropdownoptionstype);
            ucDdo_br_procedure_pxradiotherapy.SetProperty("IncludeSortASC", Ddo_br_procedure_pxradiotherapy_Includesortasc);
            ucDdo_br_procedure_pxradiotherapy.SetProperty("IncludeSortDSC", Ddo_br_procedure_pxradiotherapy_Includesortdsc);
            ucDdo_br_procedure_pxradiotherapy.SetProperty("IncludeFilter", Ddo_br_procedure_pxradiotherapy_Includefilter);
            ucDdo_br_procedure_pxradiotherapy.SetProperty("IncludeDataList", Ddo_br_procedure_pxradiotherapy_Includedatalist);
            ucDdo_br_procedure_pxradiotherapy.SetProperty("SortASC", Ddo_br_procedure_pxradiotherapy_Sortasc);
            ucDdo_br_procedure_pxradiotherapy.SetProperty("SortDSC", Ddo_br_procedure_pxradiotherapy_Sortdsc);
            ucDdo_br_procedure_pxradiotherapy.SetProperty("SearchButtonText", Ddo_br_procedure_pxradiotherapy_Searchbuttontext);
            ucDdo_br_procedure_pxradiotherapy.SetProperty("DropDownOptionsTitleSettingsIcons", AV38DDO_TitleSettingsIcons);
            ucDdo_br_procedure_pxradiotherapy.SetProperty("DropDownOptionsData", AV24BR_Procedure_PXRadiotherapyTitleFilterData);
            ucDdo_br_procedure_pxradiotherapy.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_procedure_pxradiotherapy_Internalname, "DDO_BR_PROCEDURE_PXRADIOTHERAPYContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_procedure_pxradiotherapytitlecontrolidtoreplace_Internalname, AV25ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,43);\"", 0, edtavDdo_br_procedure_pxradiotherapytitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_ProcedurePrompt.htm");
            /* User Defined Control */
            ucDdo_br_procedure_radiodate.SetProperty("Caption", Ddo_br_procedure_radiodate_Caption);
            ucDdo_br_procedure_radiodate.SetProperty("Tooltip", Ddo_br_procedure_radiodate_Tooltip);
            ucDdo_br_procedure_radiodate.SetProperty("Cls", Ddo_br_procedure_radiodate_Cls);
            ucDdo_br_procedure_radiodate.SetProperty("DropDownOptionsType", Ddo_br_procedure_radiodate_Dropdownoptionstype);
            ucDdo_br_procedure_radiodate.SetProperty("IncludeSortASC", Ddo_br_procedure_radiodate_Includesortasc);
            ucDdo_br_procedure_radiodate.SetProperty("IncludeSortDSC", Ddo_br_procedure_radiodate_Includesortdsc);
            ucDdo_br_procedure_radiodate.SetProperty("IncludeFilter", Ddo_br_procedure_radiodate_Includefilter);
            ucDdo_br_procedure_radiodate.SetProperty("IncludeDataList", Ddo_br_procedure_radiodate_Includedatalist);
            ucDdo_br_procedure_radiodate.SetProperty("SortASC", Ddo_br_procedure_radiodate_Sortasc);
            ucDdo_br_procedure_radiodate.SetProperty("SortDSC", Ddo_br_procedure_radiodate_Sortdsc);
            ucDdo_br_procedure_radiodate.SetProperty("SearchButtonText", Ddo_br_procedure_radiodate_Searchbuttontext);
            ucDdo_br_procedure_radiodate.SetProperty("DropDownOptionsTitleSettingsIcons", AV38DDO_TitleSettingsIcons);
            ucDdo_br_procedure_radiodate.SetProperty("DropDownOptionsData", AV48BR_Procedure_RadioDateTitleFilterData);
            ucDdo_br_procedure_radiodate.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_procedure_radiodate_Internalname, "DDO_BR_PROCEDURE_RADIODATEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 45,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_procedure_radiodatetitlecontrolidtoreplace_Internalname, AV49ddo_BR_Procedure_RadioDateTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,45);\"", 0, edtavDdo_br_procedure_radiodatetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_ProcedurePrompt.htm");
            /* User Defined Control */
            ucDdo_br_procedure_radiotime.SetProperty("Caption", Ddo_br_procedure_radiotime_Caption);
            ucDdo_br_procedure_radiotime.SetProperty("Tooltip", Ddo_br_procedure_radiotime_Tooltip);
            ucDdo_br_procedure_radiotime.SetProperty("Cls", Ddo_br_procedure_radiotime_Cls);
            ucDdo_br_procedure_radiotime.SetProperty("DropDownOptionsType", Ddo_br_procedure_radiotime_Dropdownoptionstype);
            ucDdo_br_procedure_radiotime.SetProperty("IncludeSortASC", Ddo_br_procedure_radiotime_Includesortasc);
            ucDdo_br_procedure_radiotime.SetProperty("IncludeSortDSC", Ddo_br_procedure_radiotime_Includesortdsc);
            ucDdo_br_procedure_radiotime.SetProperty("IncludeFilter", Ddo_br_procedure_radiotime_Includefilter);
            ucDdo_br_procedure_radiotime.SetProperty("IncludeDataList", Ddo_br_procedure_radiotime_Includedatalist);
            ucDdo_br_procedure_radiotime.SetProperty("SortASC", Ddo_br_procedure_radiotime_Sortasc);
            ucDdo_br_procedure_radiotime.SetProperty("SortDSC", Ddo_br_procedure_radiotime_Sortdsc);
            ucDdo_br_procedure_radiotime.SetProperty("SearchButtonText", Ddo_br_procedure_radiotime_Searchbuttontext);
            ucDdo_br_procedure_radiotime.SetProperty("DropDownOptionsTitleSettingsIcons", AV38DDO_TitleSettingsIcons);
            ucDdo_br_procedure_radiotime.SetProperty("DropDownOptionsData", AV50BR_Procedure_RadioTimeTitleFilterData);
            ucDdo_br_procedure_radiotime.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_procedure_radiotime_Internalname, "DDO_BR_PROCEDURE_RADIOTIMEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 47,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_procedure_radiotimetitlecontrolidtoreplace_Internalname, AV51ddo_BR_Procedure_RadioTimeTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,47);\"", 0, edtavDdo_br_procedure_radiotimetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_ProcedurePrompt.htm");
            /* User Defined Control */
            ucWorkwithplusutilities1.Render(context, "dvelop.workwithplusutilities", Workwithplusutilities1_Internalname, "WORKWITHPLUSUTILITIES1Container");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 49,'',false,'" + sGXsfl_12_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrderedby_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10OrderedBy), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV10OrderedBy), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,49);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrderedby_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrderedby_Visible, 1, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_ProcedurePrompt.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 50,'',false,'" + sGXsfl_12_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrdereddsc_Internalname, StringUtil.BoolToStr( AV11OrderedDsc), StringUtil.BoolToStr( AV11OrderedDsc), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,50);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrdereddsc_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrdereddsc_Visible, 1, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, 0, 0, true, "", "right", false, "HLP_BR_ProcedurePrompt.htm");
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

      protected void START3P2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_0-127771", 0) ;
            Form.Meta.addItem("description", "选择诊疗处理", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP3P0( ) ;
      }

      protected void WS3P2( )
      {
         START3P2( ) ;
         EVT3P2( ) ;
      }

      protected void EVT3P2( )
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
                           E113P2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEROWSPERPAGE") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E123P2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PROCEDUREID.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E133P2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_ENCOUNTERID.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E143P2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_INFORMATION_PATIENTNO.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E153P2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PROCEDURE_PXID.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E163P2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PROCEDURE_PXSURGERY.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E173P2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PROCEDURE_DATE.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E183P2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PROCEDURE_PXRADIOTHERAPY.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E193P2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PROCEDURE_RADIODATE.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E203P2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PROCEDURE_RADIOTIME.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E213P2 ();
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
                           AV43Select = cgiGet( edtavSelect_Internalname);
                           context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSelect_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV43Select)) ? AV55Select_GXI : context.convertURL( context.PathToRelativeUrl( AV43Select))), !bGXsfl_12_Refreshing);
                           context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSelect_Internalname, "SrcSet", context.GetImageSrcSet( AV43Select), true);
                           A139BR_ProcedureID = (long)(context.localUtil.CToN( cgiGet( edtBR_ProcedureID_Internalname), ".", ","));
                           A19BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( edtBR_EncounterID_Internalname), ".", ","));
                           n19BR_EncounterID = false;
                           A36BR_Information_PatientNo = cgiGet( edtBR_Information_PatientNo_Internalname);
                           n36BR_Information_PatientNo = false;
                           A140BR_Procedure_PXID = (long)(context.localUtil.CToN( cgiGet( edtBR_Procedure_PXID_Internalname), ".", ","));
                           n140BR_Procedure_PXID = false;
                           cmbBR_Procedure_PXSurgery.Name = cmbBR_Procedure_PXSurgery_Internalname;
                           cmbBR_Procedure_PXSurgery.CurrentValue = cgiGet( cmbBR_Procedure_PXSurgery_Internalname);
                           A141BR_Procedure_PXSurgery = cgiGet( cmbBR_Procedure_PXSurgery_Internalname);
                           n141BR_Procedure_PXSurgery = false;
                           A266BR_Procedure_Date = DateTimeUtil.ResetTime(context.localUtil.CToT( cgiGet( edtBR_Procedure_Date_Internalname), 0));
                           n266BR_Procedure_Date = false;
                           cmbBR_Procedure_PXRadiotherapy.Name = cmbBR_Procedure_PXRadiotherapy_Internalname;
                           cmbBR_Procedure_PXRadiotherapy.CurrentValue = cgiGet( cmbBR_Procedure_PXRadiotherapy_Internalname);
                           A143BR_Procedure_PXRadiotherapy = cgiGet( cmbBR_Procedure_PXRadiotherapy_Internalname);
                           n143BR_Procedure_PXRadiotherapy = false;
                           A268BR_Procedure_RadioDate = DateTimeUtil.ResetTime(context.localUtil.CToT( cgiGet( edtBR_Procedure_RadioDate_Internalname), 0));
                           n268BR_Procedure_RadioDate = false;
                           A269BR_Procedure_RadioTime = context.localUtil.CToN( cgiGet( edtBR_Procedure_RadioTime_Internalname), ".", ",");
                           n269BR_Procedure_RadioTime = false;
                           sEvtType = StringUtil.Right( sEvt, 1);
                           if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                           {
                              sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                              if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 /* Execute user event: Start */
                                 E223P2 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 /* Execute user event: Refresh */
                                 E233P2 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "GRID.LOAD") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 E243P2 ();
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
                                       E253P2 ();
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

      protected void WE3P2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm3P2( ) ;
            }
         }
      }

      protected void PA3P2( )
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
               GX_FocusControl = edtavDdo_br_procedureidtitlecontrolidtoreplace_Internalname;
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
                                       String AV13ddo_BR_ProcedureIDTitleControlIdToReplace ,
                                       String AV15ddo_BR_EncounterIDTitleControlIdToReplace ,
                                       String AV17ddo_BR_Information_PatientNoTitleControlIdToReplace ,
                                       String AV19ddo_BR_Procedure_PXIDTitleControlIdToReplace ,
                                       String AV21ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace ,
                                       String AV45ddo_BR_Procedure_DateTitleControlIdToReplace ,
                                       String AV25ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace ,
                                       String AV49ddo_BR_Procedure_RadioDateTitleControlIdToReplace ,
                                       String AV51ddo_BR_Procedure_RadioTimeTitleControlIdToReplace )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GRID_nCurrentRecord = 0;
         RF3P2( ) ;
         /* End function gxgrGrid_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_BR_PROCEDUREID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A139BR_ProcedureID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, "BR_PROCEDUREID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A139BR_ProcedureID), 18, 0, ".", "")));
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
         RF3P2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV54Pgmname = "BR_ProcedurePrompt";
         context.Gx_err = 0;
      }

      protected void RF3P2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridContainer.ClearRows();
         }
         wbStart = 12;
         /* Execute user event: Refresh */
         E233P2 ();
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
            /* Using cursor H003P2 */
            pr_default.execute(0, new Object[] {GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_12_idx = 1;
            sGXsfl_12_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_12_idx), 4, 0)), 4, "0");
            SubsflControlProps_122( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < subGrid_Recordsperpage( ) ) ) ) )
            {
               A85BR_Information_ID = H003P2_A85BR_Information_ID[0];
               n85BR_Information_ID = H003P2_n85BR_Information_ID[0];
               A269BR_Procedure_RadioTime = H003P2_A269BR_Procedure_RadioTime[0];
               n269BR_Procedure_RadioTime = H003P2_n269BR_Procedure_RadioTime[0];
               A268BR_Procedure_RadioDate = H003P2_A268BR_Procedure_RadioDate[0];
               n268BR_Procedure_RadioDate = H003P2_n268BR_Procedure_RadioDate[0];
               A143BR_Procedure_PXRadiotherapy = H003P2_A143BR_Procedure_PXRadiotherapy[0];
               n143BR_Procedure_PXRadiotherapy = H003P2_n143BR_Procedure_PXRadiotherapy[0];
               A266BR_Procedure_Date = H003P2_A266BR_Procedure_Date[0];
               n266BR_Procedure_Date = H003P2_n266BR_Procedure_Date[0];
               A141BR_Procedure_PXSurgery = H003P2_A141BR_Procedure_PXSurgery[0];
               n141BR_Procedure_PXSurgery = H003P2_n141BR_Procedure_PXSurgery[0];
               A140BR_Procedure_PXID = H003P2_A140BR_Procedure_PXID[0];
               n140BR_Procedure_PXID = H003P2_n140BR_Procedure_PXID[0];
               A36BR_Information_PatientNo = H003P2_A36BR_Information_PatientNo[0];
               n36BR_Information_PatientNo = H003P2_n36BR_Information_PatientNo[0];
               A19BR_EncounterID = H003P2_A19BR_EncounterID[0];
               n19BR_EncounterID = H003P2_n19BR_EncounterID[0];
               A139BR_ProcedureID = H003P2_A139BR_ProcedureID[0];
               A85BR_Information_ID = H003P2_A85BR_Information_ID[0];
               n85BR_Information_ID = H003P2_n85BR_Information_ID[0];
               A36BR_Information_PatientNo = H003P2_A36BR_Information_PatientNo[0];
               n36BR_Information_PatientNo = H003P2_n36BR_Information_PatientNo[0];
               E243P2 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 12;
            WB3P0( ) ;
         }
         bGXsfl_12_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes3P2( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_BR_PROCEDUREID"+"_"+sGXsfl_12_idx, GetSecureSignedToken( sGXsfl_12_idx, context.localUtil.Format( (decimal)(A139BR_ProcedureID), "ZZZZZZZZZZZZZZZZZZ"), context));
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
         /* Using cursor H003P3 */
         pr_default.execute(1);
         GRID_nRecordCount = H003P3_AGRID_nRecordCount[0];
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
            gxgrGrid_refresh( subGrid_Rows, AV10OrderedBy, AV11OrderedDsc, AV13ddo_BR_ProcedureIDTitleControlIdToReplace, AV15ddo_BR_EncounterIDTitleControlIdToReplace, AV17ddo_BR_Information_PatientNoTitleControlIdToReplace, AV19ddo_BR_Procedure_PXIDTitleControlIdToReplace, AV21ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace, AV45ddo_BR_Procedure_DateTitleControlIdToReplace, AV25ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace, AV49ddo_BR_Procedure_RadioDateTitleControlIdToReplace, AV51ddo_BR_Procedure_RadioTimeTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV10OrderedBy, AV11OrderedDsc, AV13ddo_BR_ProcedureIDTitleControlIdToReplace, AV15ddo_BR_EncounterIDTitleControlIdToReplace, AV17ddo_BR_Information_PatientNoTitleControlIdToReplace, AV19ddo_BR_Procedure_PXIDTitleControlIdToReplace, AV21ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace, AV45ddo_BR_Procedure_DateTitleControlIdToReplace, AV25ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace, AV49ddo_BR_Procedure_RadioDateTitleControlIdToReplace, AV51ddo_BR_Procedure_RadioTimeTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV10OrderedBy, AV11OrderedDsc, AV13ddo_BR_ProcedureIDTitleControlIdToReplace, AV15ddo_BR_EncounterIDTitleControlIdToReplace, AV17ddo_BR_Information_PatientNoTitleControlIdToReplace, AV19ddo_BR_Procedure_PXIDTitleControlIdToReplace, AV21ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace, AV45ddo_BR_Procedure_DateTitleControlIdToReplace, AV25ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace, AV49ddo_BR_Procedure_RadioDateTitleControlIdToReplace, AV51ddo_BR_Procedure_RadioTimeTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV10OrderedBy, AV11OrderedDsc, AV13ddo_BR_ProcedureIDTitleControlIdToReplace, AV15ddo_BR_EncounterIDTitleControlIdToReplace, AV17ddo_BR_Information_PatientNoTitleControlIdToReplace, AV19ddo_BR_Procedure_PXIDTitleControlIdToReplace, AV21ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace, AV45ddo_BR_Procedure_DateTitleControlIdToReplace, AV25ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace, AV49ddo_BR_Procedure_RadioDateTitleControlIdToReplace, AV51ddo_BR_Procedure_RadioTimeTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV10OrderedBy, AV11OrderedDsc, AV13ddo_BR_ProcedureIDTitleControlIdToReplace, AV15ddo_BR_EncounterIDTitleControlIdToReplace, AV17ddo_BR_Information_PatientNoTitleControlIdToReplace, AV19ddo_BR_Procedure_PXIDTitleControlIdToReplace, AV21ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace, AV45ddo_BR_Procedure_DateTitleControlIdToReplace, AV25ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace, AV49ddo_BR_Procedure_RadioDateTitleControlIdToReplace, AV51ddo_BR_Procedure_RadioTimeTitleControlIdToReplace) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP3P0( )
      {
         /* Before Start, stand alone formulas. */
         AV54Pgmname = "BR_ProcedurePrompt";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E223P2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( "vDDO_TITLESETTINGSICONS"), AV38DDO_TitleSettingsIcons);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_PROCEDUREIDTITLEFILTERDATA"), AV12BR_ProcedureIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_ENCOUNTERIDTITLEFILTERDATA"), AV14BR_EncounterIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_INFORMATION_PATIENTNOTITLEFILTERDATA"), AV16BR_Information_PatientNoTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_PROCEDURE_PXIDTITLEFILTERDATA"), AV18BR_Procedure_PXIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_PROCEDURE_PXSURGERYTITLEFILTERDATA"), AV20BR_Procedure_PXSurgeryTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_PROCEDURE_DATETITLEFILTERDATA"), AV44BR_Procedure_DateTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_PROCEDURE_PXRADIOTHERAPYTITLEFILTERDATA"), AV24BR_Procedure_PXRadiotherapyTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_PROCEDURE_RADIODATETITLEFILTERDATA"), AV48BR_Procedure_RadioDateTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_PROCEDURE_RADIOTIMETITLEFILTERDATA"), AV50BR_Procedure_RadioTimeTitleFilterData);
            /* Read variables values. */
            AV13ddo_BR_ProcedureIDTitleControlIdToReplace = cgiGet( edtavDdo_br_procedureidtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13ddo_BR_ProcedureIDTitleControlIdToReplace", AV13ddo_BR_ProcedureIDTitleControlIdToReplace);
            AV15ddo_BR_EncounterIDTitleControlIdToReplace = cgiGet( edtavDdo_br_encounteridtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15ddo_BR_EncounterIDTitleControlIdToReplace", AV15ddo_BR_EncounterIDTitleControlIdToReplace);
            AV17ddo_BR_Information_PatientNoTitleControlIdToReplace = cgiGet( edtavDdo_br_information_patientnotitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17ddo_BR_Information_PatientNoTitleControlIdToReplace", AV17ddo_BR_Information_PatientNoTitleControlIdToReplace);
            AV19ddo_BR_Procedure_PXIDTitleControlIdToReplace = cgiGet( edtavDdo_br_procedure_pxidtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19ddo_BR_Procedure_PXIDTitleControlIdToReplace", AV19ddo_BR_Procedure_PXIDTitleControlIdToReplace);
            AV21ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace = cgiGet( edtavDdo_br_procedure_pxsurgerytitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace", AV21ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace);
            AV45ddo_BR_Procedure_DateTitleControlIdToReplace = cgiGet( edtavDdo_br_procedure_datetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV45ddo_BR_Procedure_DateTitleControlIdToReplace", AV45ddo_BR_Procedure_DateTitleControlIdToReplace);
            AV25ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace = cgiGet( edtavDdo_br_procedure_pxradiotherapytitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace", AV25ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace);
            AV49ddo_BR_Procedure_RadioDateTitleControlIdToReplace = cgiGet( edtavDdo_br_procedure_radiodatetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV49ddo_BR_Procedure_RadioDateTitleControlIdToReplace", AV49ddo_BR_Procedure_RadioDateTitleControlIdToReplace);
            AV51ddo_BR_Procedure_RadioTimeTitleControlIdToReplace = cgiGet( edtavDdo_br_procedure_radiotimetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV51ddo_BR_Procedure_RadioTimeTitleControlIdToReplace", AV51ddo_BR_Procedure_RadioTimeTitleControlIdToReplace);
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
            AV40GridCurrentPage = (long)(context.localUtil.CToN( cgiGet( "vGRIDCURRENTPAGE"), ".", ","));
            AV42GridRecordCount = (long)(context.localUtil.CToN( cgiGet( "vGRIDRECORDCOUNT"), ".", ","));
            AV41GridPageSize = (long)(context.localUtil.CToN( cgiGet( "vGRIDPAGESIZE"), ".", ","));
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
            Ddo_br_procedureid_Caption = cgiGet( "DDO_BR_PROCEDUREID_Caption");
            Ddo_br_procedureid_Tooltip = cgiGet( "DDO_BR_PROCEDUREID_Tooltip");
            Ddo_br_procedureid_Cls = cgiGet( "DDO_BR_PROCEDUREID_Cls");
            Ddo_br_procedureid_Dropdownoptionstype = cgiGet( "DDO_BR_PROCEDUREID_Dropdownoptionstype");
            Ddo_br_procedureid_Titlecontrolidtoreplace = cgiGet( "DDO_BR_PROCEDUREID_Titlecontrolidtoreplace");
            Ddo_br_procedureid_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDUREID_Includesortasc"));
            Ddo_br_procedureid_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDUREID_Includesortdsc"));
            Ddo_br_procedureid_Sortedstatus = cgiGet( "DDO_BR_PROCEDUREID_Sortedstatus");
            Ddo_br_procedureid_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDUREID_Includefilter"));
            Ddo_br_procedureid_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDUREID_Includedatalist"));
            Ddo_br_procedureid_Sortasc = cgiGet( "DDO_BR_PROCEDUREID_Sortasc");
            Ddo_br_procedureid_Sortdsc = cgiGet( "DDO_BR_PROCEDUREID_Sortdsc");
            Ddo_br_procedureid_Searchbuttontext = cgiGet( "DDO_BR_PROCEDUREID_Searchbuttontext");
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
            Ddo_br_procedure_pxid_Caption = cgiGet( "DDO_BR_PROCEDURE_PXID_Caption");
            Ddo_br_procedure_pxid_Tooltip = cgiGet( "DDO_BR_PROCEDURE_PXID_Tooltip");
            Ddo_br_procedure_pxid_Cls = cgiGet( "DDO_BR_PROCEDURE_PXID_Cls");
            Ddo_br_procedure_pxid_Dropdownoptionstype = cgiGet( "DDO_BR_PROCEDURE_PXID_Dropdownoptionstype");
            Ddo_br_procedure_pxid_Titlecontrolidtoreplace = cgiGet( "DDO_BR_PROCEDURE_PXID_Titlecontrolidtoreplace");
            Ddo_br_procedure_pxid_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_PXID_Includesortasc"));
            Ddo_br_procedure_pxid_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_PXID_Includesortdsc"));
            Ddo_br_procedure_pxid_Sortedstatus = cgiGet( "DDO_BR_PROCEDURE_PXID_Sortedstatus");
            Ddo_br_procedure_pxid_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_PXID_Includefilter"));
            Ddo_br_procedure_pxid_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_PXID_Includedatalist"));
            Ddo_br_procedure_pxid_Sortasc = cgiGet( "DDO_BR_PROCEDURE_PXID_Sortasc");
            Ddo_br_procedure_pxid_Sortdsc = cgiGet( "DDO_BR_PROCEDURE_PXID_Sortdsc");
            Ddo_br_procedure_pxid_Searchbuttontext = cgiGet( "DDO_BR_PROCEDURE_PXID_Searchbuttontext");
            Ddo_br_procedure_pxsurgery_Caption = cgiGet( "DDO_BR_PROCEDURE_PXSURGERY_Caption");
            Ddo_br_procedure_pxsurgery_Tooltip = cgiGet( "DDO_BR_PROCEDURE_PXSURGERY_Tooltip");
            Ddo_br_procedure_pxsurgery_Cls = cgiGet( "DDO_BR_PROCEDURE_PXSURGERY_Cls");
            Ddo_br_procedure_pxsurgery_Dropdownoptionstype = cgiGet( "DDO_BR_PROCEDURE_PXSURGERY_Dropdownoptionstype");
            Ddo_br_procedure_pxsurgery_Titlecontrolidtoreplace = cgiGet( "DDO_BR_PROCEDURE_PXSURGERY_Titlecontrolidtoreplace");
            Ddo_br_procedure_pxsurgery_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_PXSURGERY_Includesortasc"));
            Ddo_br_procedure_pxsurgery_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_PXSURGERY_Includesortdsc"));
            Ddo_br_procedure_pxsurgery_Sortedstatus = cgiGet( "DDO_BR_PROCEDURE_PXSURGERY_Sortedstatus");
            Ddo_br_procedure_pxsurgery_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_PXSURGERY_Includefilter"));
            Ddo_br_procedure_pxsurgery_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_PXSURGERY_Includedatalist"));
            Ddo_br_procedure_pxsurgery_Sortasc = cgiGet( "DDO_BR_PROCEDURE_PXSURGERY_Sortasc");
            Ddo_br_procedure_pxsurgery_Sortdsc = cgiGet( "DDO_BR_PROCEDURE_PXSURGERY_Sortdsc");
            Ddo_br_procedure_pxsurgery_Searchbuttontext = cgiGet( "DDO_BR_PROCEDURE_PXSURGERY_Searchbuttontext");
            Ddo_br_procedure_date_Caption = cgiGet( "DDO_BR_PROCEDURE_DATE_Caption");
            Ddo_br_procedure_date_Tooltip = cgiGet( "DDO_BR_PROCEDURE_DATE_Tooltip");
            Ddo_br_procedure_date_Cls = cgiGet( "DDO_BR_PROCEDURE_DATE_Cls");
            Ddo_br_procedure_date_Dropdownoptionstype = cgiGet( "DDO_BR_PROCEDURE_DATE_Dropdownoptionstype");
            Ddo_br_procedure_date_Titlecontrolidtoreplace = cgiGet( "DDO_BR_PROCEDURE_DATE_Titlecontrolidtoreplace");
            Ddo_br_procedure_date_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_DATE_Includesortasc"));
            Ddo_br_procedure_date_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_DATE_Includesortdsc"));
            Ddo_br_procedure_date_Sortedstatus = cgiGet( "DDO_BR_PROCEDURE_DATE_Sortedstatus");
            Ddo_br_procedure_date_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_DATE_Includefilter"));
            Ddo_br_procedure_date_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_DATE_Includedatalist"));
            Ddo_br_procedure_date_Sortasc = cgiGet( "DDO_BR_PROCEDURE_DATE_Sortasc");
            Ddo_br_procedure_date_Sortdsc = cgiGet( "DDO_BR_PROCEDURE_DATE_Sortdsc");
            Ddo_br_procedure_date_Searchbuttontext = cgiGet( "DDO_BR_PROCEDURE_DATE_Searchbuttontext");
            Ddo_br_procedure_pxradiotherapy_Caption = cgiGet( "DDO_BR_PROCEDURE_PXRADIOTHERAPY_Caption");
            Ddo_br_procedure_pxradiotherapy_Tooltip = cgiGet( "DDO_BR_PROCEDURE_PXRADIOTHERAPY_Tooltip");
            Ddo_br_procedure_pxradiotherapy_Cls = cgiGet( "DDO_BR_PROCEDURE_PXRADIOTHERAPY_Cls");
            Ddo_br_procedure_pxradiotherapy_Dropdownoptionstype = cgiGet( "DDO_BR_PROCEDURE_PXRADIOTHERAPY_Dropdownoptionstype");
            Ddo_br_procedure_pxradiotherapy_Titlecontrolidtoreplace = cgiGet( "DDO_BR_PROCEDURE_PXRADIOTHERAPY_Titlecontrolidtoreplace");
            Ddo_br_procedure_pxradiotherapy_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_PXRADIOTHERAPY_Includesortasc"));
            Ddo_br_procedure_pxradiotherapy_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_PXRADIOTHERAPY_Includesortdsc"));
            Ddo_br_procedure_pxradiotherapy_Sortedstatus = cgiGet( "DDO_BR_PROCEDURE_PXRADIOTHERAPY_Sortedstatus");
            Ddo_br_procedure_pxradiotherapy_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_PXRADIOTHERAPY_Includefilter"));
            Ddo_br_procedure_pxradiotherapy_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_PXRADIOTHERAPY_Includedatalist"));
            Ddo_br_procedure_pxradiotherapy_Sortasc = cgiGet( "DDO_BR_PROCEDURE_PXRADIOTHERAPY_Sortasc");
            Ddo_br_procedure_pxradiotherapy_Sortdsc = cgiGet( "DDO_BR_PROCEDURE_PXRADIOTHERAPY_Sortdsc");
            Ddo_br_procedure_pxradiotherapy_Searchbuttontext = cgiGet( "DDO_BR_PROCEDURE_PXRADIOTHERAPY_Searchbuttontext");
            Ddo_br_procedure_radiodate_Caption = cgiGet( "DDO_BR_PROCEDURE_RADIODATE_Caption");
            Ddo_br_procedure_radiodate_Tooltip = cgiGet( "DDO_BR_PROCEDURE_RADIODATE_Tooltip");
            Ddo_br_procedure_radiodate_Cls = cgiGet( "DDO_BR_PROCEDURE_RADIODATE_Cls");
            Ddo_br_procedure_radiodate_Dropdownoptionstype = cgiGet( "DDO_BR_PROCEDURE_RADIODATE_Dropdownoptionstype");
            Ddo_br_procedure_radiodate_Titlecontrolidtoreplace = cgiGet( "DDO_BR_PROCEDURE_RADIODATE_Titlecontrolidtoreplace");
            Ddo_br_procedure_radiodate_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_RADIODATE_Includesortasc"));
            Ddo_br_procedure_radiodate_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_RADIODATE_Includesortdsc"));
            Ddo_br_procedure_radiodate_Sortedstatus = cgiGet( "DDO_BR_PROCEDURE_RADIODATE_Sortedstatus");
            Ddo_br_procedure_radiodate_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_RADIODATE_Includefilter"));
            Ddo_br_procedure_radiodate_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_RADIODATE_Includedatalist"));
            Ddo_br_procedure_radiodate_Sortasc = cgiGet( "DDO_BR_PROCEDURE_RADIODATE_Sortasc");
            Ddo_br_procedure_radiodate_Sortdsc = cgiGet( "DDO_BR_PROCEDURE_RADIODATE_Sortdsc");
            Ddo_br_procedure_radiodate_Searchbuttontext = cgiGet( "DDO_BR_PROCEDURE_RADIODATE_Searchbuttontext");
            Ddo_br_procedure_radiotime_Caption = cgiGet( "DDO_BR_PROCEDURE_RADIOTIME_Caption");
            Ddo_br_procedure_radiotime_Tooltip = cgiGet( "DDO_BR_PROCEDURE_RADIOTIME_Tooltip");
            Ddo_br_procedure_radiotime_Cls = cgiGet( "DDO_BR_PROCEDURE_RADIOTIME_Cls");
            Ddo_br_procedure_radiotime_Dropdownoptionstype = cgiGet( "DDO_BR_PROCEDURE_RADIOTIME_Dropdownoptionstype");
            Ddo_br_procedure_radiotime_Titlecontrolidtoreplace = cgiGet( "DDO_BR_PROCEDURE_RADIOTIME_Titlecontrolidtoreplace");
            Ddo_br_procedure_radiotime_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_RADIOTIME_Includesortasc"));
            Ddo_br_procedure_radiotime_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_RADIOTIME_Includesortdsc"));
            Ddo_br_procedure_radiotime_Sortedstatus = cgiGet( "DDO_BR_PROCEDURE_RADIOTIME_Sortedstatus");
            Ddo_br_procedure_radiotime_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_RADIOTIME_Includefilter"));
            Ddo_br_procedure_radiotime_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_RADIOTIME_Includedatalist"));
            Ddo_br_procedure_radiotime_Sortasc = cgiGet( "DDO_BR_PROCEDURE_RADIOTIME_Sortasc");
            Ddo_br_procedure_radiotime_Sortdsc = cgiGet( "DDO_BR_PROCEDURE_RADIOTIME_Sortdsc");
            Ddo_br_procedure_radiotime_Searchbuttontext = cgiGet( "DDO_BR_PROCEDURE_RADIOTIME_Searchbuttontext");
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( "GRID_Rows"), ".", ","));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            Gridpaginationbar_Selectedpage = cgiGet( "GRIDPAGINATIONBAR_Selectedpage");
            Gridpaginationbar_Rowsperpageselectedvalue = (int)(context.localUtil.CToN( cgiGet( "GRIDPAGINATIONBAR_Rowsperpageselectedvalue"), ".", ","));
            Ddo_br_procedureid_Activeeventkey = cgiGet( "DDO_BR_PROCEDUREID_Activeeventkey");
            Ddo_br_encounterid_Activeeventkey = cgiGet( "DDO_BR_ENCOUNTERID_Activeeventkey");
            Ddo_br_information_patientno_Activeeventkey = cgiGet( "DDO_BR_INFORMATION_PATIENTNO_Activeeventkey");
            Ddo_br_procedure_pxid_Activeeventkey = cgiGet( "DDO_BR_PROCEDURE_PXID_Activeeventkey");
            Ddo_br_procedure_pxsurgery_Activeeventkey = cgiGet( "DDO_BR_PROCEDURE_PXSURGERY_Activeeventkey");
            Ddo_br_procedure_date_Activeeventkey = cgiGet( "DDO_BR_PROCEDURE_DATE_Activeeventkey");
            Ddo_br_procedure_pxradiotherapy_Activeeventkey = cgiGet( "DDO_BR_PROCEDURE_PXRADIOTHERAPY_Activeeventkey");
            Ddo_br_procedure_radiodate_Activeeventkey = cgiGet( "DDO_BR_PROCEDURE_RADIODATE_Activeeventkey");
            Ddo_br_procedure_radiotime_Activeeventkey = cgiGet( "DDO_BR_PROCEDURE_RADIOTIME_Activeeventkey");
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
         E223P2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E223P2( )
      {
         /* Start Routine */
         GXt_boolean1 = AV5IsAuthorized;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Check_Procedure", out  GXt_boolean1) ;
         AV5IsAuthorized = GXt_boolean1;
         if ( ! AV5IsAuthorized )
         {
            CallWebObject(formatLink("wwpbaseobjects.notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV54Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         divTablemain_Height = 493;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, divTablemain_Internalname, "Height", StringUtil.LTrim( StringUtil.Str( (decimal)(divTablemain_Height), 9, 0)), true);
         subGrid_Rows = 9;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         Ddo_br_procedureid_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_ProcedureID";
         ucDdo_br_procedureid.SendProperty(context, "", false, Ddo_br_procedureid_Internalname, "TitleControlIdToReplace", Ddo_br_procedureid_Titlecontrolidtoreplace);
         AV13ddo_BR_ProcedureIDTitleControlIdToReplace = Ddo_br_procedureid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13ddo_BR_ProcedureIDTitleControlIdToReplace", AV13ddo_BR_ProcedureIDTitleControlIdToReplace);
         edtavDdo_br_procedureidtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_procedureidtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_procedureidtitlecontrolidtoreplace_Visible), 5, 0)), true);
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
         Ddo_br_procedure_pxid_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Procedure_PXID";
         ucDdo_br_procedure_pxid.SendProperty(context, "", false, Ddo_br_procedure_pxid_Internalname, "TitleControlIdToReplace", Ddo_br_procedure_pxid_Titlecontrolidtoreplace);
         AV19ddo_BR_Procedure_PXIDTitleControlIdToReplace = Ddo_br_procedure_pxid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19ddo_BR_Procedure_PXIDTitleControlIdToReplace", AV19ddo_BR_Procedure_PXIDTitleControlIdToReplace);
         edtavDdo_br_procedure_pxidtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_procedure_pxidtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_procedure_pxidtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_procedure_pxsurgery_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Procedure_PXSurgery";
         ucDdo_br_procedure_pxsurgery.SendProperty(context, "", false, Ddo_br_procedure_pxsurgery_Internalname, "TitleControlIdToReplace", Ddo_br_procedure_pxsurgery_Titlecontrolidtoreplace);
         AV21ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace = Ddo_br_procedure_pxsurgery_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace", AV21ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace);
         edtavDdo_br_procedure_pxsurgerytitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_procedure_pxsurgerytitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_procedure_pxsurgerytitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_procedure_date_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Procedure_Date";
         ucDdo_br_procedure_date.SendProperty(context, "", false, Ddo_br_procedure_date_Internalname, "TitleControlIdToReplace", Ddo_br_procedure_date_Titlecontrolidtoreplace);
         AV45ddo_BR_Procedure_DateTitleControlIdToReplace = Ddo_br_procedure_date_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV45ddo_BR_Procedure_DateTitleControlIdToReplace", AV45ddo_BR_Procedure_DateTitleControlIdToReplace);
         edtavDdo_br_procedure_datetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_procedure_datetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_procedure_datetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_procedure_pxradiotherapy_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Procedure_PXRadiotherapy";
         ucDdo_br_procedure_pxradiotherapy.SendProperty(context, "", false, Ddo_br_procedure_pxradiotherapy_Internalname, "TitleControlIdToReplace", Ddo_br_procedure_pxradiotherapy_Titlecontrolidtoreplace);
         AV25ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace = Ddo_br_procedure_pxradiotherapy_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace", AV25ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace);
         edtavDdo_br_procedure_pxradiotherapytitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_procedure_pxradiotherapytitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_procedure_pxradiotherapytitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_procedure_radiodate_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Procedure_RadioDate";
         ucDdo_br_procedure_radiodate.SendProperty(context, "", false, Ddo_br_procedure_radiodate_Internalname, "TitleControlIdToReplace", Ddo_br_procedure_radiodate_Titlecontrolidtoreplace);
         AV49ddo_BR_Procedure_RadioDateTitleControlIdToReplace = Ddo_br_procedure_radiodate_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV49ddo_BR_Procedure_RadioDateTitleControlIdToReplace", AV49ddo_BR_Procedure_RadioDateTitleControlIdToReplace);
         edtavDdo_br_procedure_radiodatetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_procedure_radiodatetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_procedure_radiodatetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_procedure_radiotime_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Procedure_RadioTime";
         ucDdo_br_procedure_radiotime.SendProperty(context, "", false, Ddo_br_procedure_radiotime_Internalname, "TitleControlIdToReplace", Ddo_br_procedure_radiotime_Titlecontrolidtoreplace);
         AV51ddo_BR_Procedure_RadioTimeTitleControlIdToReplace = Ddo_br_procedure_radiotime_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV51ddo_BR_Procedure_RadioTimeTitleControlIdToReplace", AV51ddo_BR_Procedure_RadioTimeTitleControlIdToReplace);
         edtavDdo_br_procedure_radiotimetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_procedure_radiotimetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_procedure_radiotimetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Form.Caption = "选择诊疗处理";
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
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 = AV38DDO_TitleSettingsIcons;
         new GeneXus.Programs.wwpbaseobjects.getwwptitlesettingsicons(context ).execute( out  GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2) ;
         AV38DDO_TitleSettingsIcons = GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2;
         Gridpaginationbar_Rowsperpageselectedvalue = subGrid_Rows;
         ucGridpaginationbar.SendProperty(context, "", false, Gridpaginationbar_Internalname, "RowsPerPageSelectedValue", StringUtil.LTrim( StringUtil.Str( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0)));
      }

      protected void E233P2( )
      {
         if ( gx_refresh_fired )
         {
            return  ;
         }
         gx_refresh_fired = true;
         /* Refresh Routine */
         AV12BR_ProcedureIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV14BR_EncounterIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV16BR_Information_PatientNoTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV18BR_Procedure_PXIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV20BR_Procedure_PXSurgeryTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV44BR_Procedure_DateTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV24BR_Procedure_PXRadiotherapyTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV48BR_Procedure_RadioDateTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV50BR_Procedure_RadioTimeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV6WWPContext) ;
         edtBR_ProcedureID_Titleformat = 2;
         edtBR_ProcedureID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "诊疗处理主键", AV13ddo_BR_ProcedureIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_ProcedureID_Internalname, "Title", edtBR_ProcedureID_Title, !bGXsfl_12_Refreshing);
         edtBR_EncounterID_Titleformat = 2;
         edtBR_EncounterID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "就诊信息主键", AV15ddo_BR_EncounterIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_EncounterID_Internalname, "Title", edtBR_EncounterID_Title, !bGXsfl_12_Refreshing);
         edtBR_Information_PatientNo_Titleformat = 2;
         edtBR_Information_PatientNo_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "患者编号", AV17ddo_BR_Information_PatientNoTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Information_PatientNo_Internalname, "Title", edtBR_Information_PatientNo_Title, !bGXsfl_12_Refreshing);
         edtBR_Procedure_PXID_Titleformat = 2;
         edtBR_Procedure_PXID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "诊疗序号", AV19ddo_BR_Procedure_PXIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Procedure_PXID_Internalname, "Title", edtBR_Procedure_PXID_Title, !bGXsfl_12_Refreshing);
         cmbBR_Procedure_PXSurgery_Titleformat = 2;
         cmbBR_Procedure_PXSurgery.Title.Text = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "是否手术", AV21ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Procedure_PXSurgery_Internalname, "Title", cmbBR_Procedure_PXSurgery.Title.Text, !bGXsfl_12_Refreshing);
         edtBR_Procedure_Date_Titleformat = 2;
         edtBR_Procedure_Date_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "手术日期", AV45ddo_BR_Procedure_DateTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Procedure_Date_Internalname, "Title", edtBR_Procedure_Date_Title, !bGXsfl_12_Refreshing);
         cmbBR_Procedure_PXRadiotherapy_Titleformat = 2;
         cmbBR_Procedure_PXRadiotherapy.Title.Text = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "是否接受放射疗法", AV25ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Procedure_PXRadiotherapy_Internalname, "Title", cmbBR_Procedure_PXRadiotherapy.Title.Text, !bGXsfl_12_Refreshing);
         edtBR_Procedure_RadioDate_Titleformat = 2;
         edtBR_Procedure_RadioDate_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "放疗日期", AV49ddo_BR_Procedure_RadioDateTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Procedure_RadioDate_Internalname, "Title", edtBR_Procedure_RadioDate_Title, !bGXsfl_12_Refreshing);
         edtBR_Procedure_RadioTime_Titleformat = 2;
         edtBR_Procedure_RadioTime_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "放疗疗程", AV51ddo_BR_Procedure_RadioTimeTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Procedure_RadioTime_Internalname, "Title", edtBR_Procedure_RadioTime_Title, !bGXsfl_12_Refreshing);
         AV40GridCurrentPage = subGrid_Currentpage( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV40GridCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV40GridCurrentPage), 10, 0)));
         AV41GridPageSize = subGrid_Rows;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV41GridPageSize", StringUtil.LTrim( StringUtil.Str( (decimal)(AV41GridPageSize), 10, 0)));
         AV42GridRecordCount = subGrid_Recordcount( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV42GridRecordCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV42GridRecordCount), 10, 0)));
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12BR_ProcedureIDTitleFilterData", AV12BR_ProcedureIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14BR_EncounterIDTitleFilterData", AV14BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Information_PatientNoTitleFilterData", AV16BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18BR_Procedure_PXIDTitleFilterData", AV18BR_Procedure_PXIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Procedure_PXSurgeryTitleFilterData", AV20BR_Procedure_PXSurgeryTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44BR_Procedure_DateTitleFilterData", AV44BR_Procedure_DateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Procedure_PXRadiotherapyTitleFilterData", AV24BR_Procedure_PXRadiotherapyTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV48BR_Procedure_RadioDateTitleFilterData", AV48BR_Procedure_RadioDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50BR_Procedure_RadioTimeTitleFilterData", AV50BR_Procedure_RadioTimeTitleFilterData);
      }

      protected void E113P2( )
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

      protected void E123P2( )
      {
         /* Gridpaginationbar_Changerowsperpage Routine */
         subGrid_Rows = Gridpaginationbar_Rowsperpageselectedvalue;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         subgrid_firstpage( ) ;
         /*  Sending Event outputs  */
      }

      protected void E133P2( )
      {
         /* Ddo_br_procedureid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_procedureid_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV10OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_procedureid_Sortedstatus = "ASC";
            ucDdo_br_procedureid.SendProperty(context, "", false, Ddo_br_procedureid_Internalname, "SortedStatus", Ddo_br_procedureid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_procedureid_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV10OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_procedureid_Sortedstatus = "DSC";
            ucDdo_br_procedureid.SendProperty(context, "", false, Ddo_br_procedureid_Internalname, "SortedStatus", Ddo_br_procedureid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12BR_ProcedureIDTitleFilterData", AV12BR_ProcedureIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14BR_EncounterIDTitleFilterData", AV14BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Information_PatientNoTitleFilterData", AV16BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18BR_Procedure_PXIDTitleFilterData", AV18BR_Procedure_PXIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Procedure_PXSurgeryTitleFilterData", AV20BR_Procedure_PXSurgeryTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44BR_Procedure_DateTitleFilterData", AV44BR_Procedure_DateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Procedure_PXRadiotherapyTitleFilterData", AV24BR_Procedure_PXRadiotherapyTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV48BR_Procedure_RadioDateTitleFilterData", AV48BR_Procedure_RadioDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50BR_Procedure_RadioTimeTitleFilterData", AV50BR_Procedure_RadioTimeTitleFilterData);
      }

      protected void E143P2( )
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
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12BR_ProcedureIDTitleFilterData", AV12BR_ProcedureIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14BR_EncounterIDTitleFilterData", AV14BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Information_PatientNoTitleFilterData", AV16BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18BR_Procedure_PXIDTitleFilterData", AV18BR_Procedure_PXIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Procedure_PXSurgeryTitleFilterData", AV20BR_Procedure_PXSurgeryTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44BR_Procedure_DateTitleFilterData", AV44BR_Procedure_DateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Procedure_PXRadiotherapyTitleFilterData", AV24BR_Procedure_PXRadiotherapyTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV48BR_Procedure_RadioDateTitleFilterData", AV48BR_Procedure_RadioDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50BR_Procedure_RadioTimeTitleFilterData", AV50BR_Procedure_RadioTimeTitleFilterData);
      }

      protected void E153P2( )
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
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12BR_ProcedureIDTitleFilterData", AV12BR_ProcedureIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14BR_EncounterIDTitleFilterData", AV14BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Information_PatientNoTitleFilterData", AV16BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18BR_Procedure_PXIDTitleFilterData", AV18BR_Procedure_PXIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Procedure_PXSurgeryTitleFilterData", AV20BR_Procedure_PXSurgeryTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44BR_Procedure_DateTitleFilterData", AV44BR_Procedure_DateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Procedure_PXRadiotherapyTitleFilterData", AV24BR_Procedure_PXRadiotherapyTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV48BR_Procedure_RadioDateTitleFilterData", AV48BR_Procedure_RadioDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50BR_Procedure_RadioTimeTitleFilterData", AV50BR_Procedure_RadioTimeTitleFilterData);
      }

      protected void E163P2( )
      {
         /* Ddo_br_procedure_pxid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_procedure_pxid_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV10OrderedBy = 4;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_procedure_pxid_Sortedstatus = "ASC";
            ucDdo_br_procedure_pxid.SendProperty(context, "", false, Ddo_br_procedure_pxid_Internalname, "SortedStatus", Ddo_br_procedure_pxid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_procedure_pxid_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV10OrderedBy = 4;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_procedure_pxid_Sortedstatus = "DSC";
            ucDdo_br_procedure_pxid.SendProperty(context, "", false, Ddo_br_procedure_pxid_Internalname, "SortedStatus", Ddo_br_procedure_pxid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12BR_ProcedureIDTitleFilterData", AV12BR_ProcedureIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14BR_EncounterIDTitleFilterData", AV14BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Information_PatientNoTitleFilterData", AV16BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18BR_Procedure_PXIDTitleFilterData", AV18BR_Procedure_PXIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Procedure_PXSurgeryTitleFilterData", AV20BR_Procedure_PXSurgeryTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44BR_Procedure_DateTitleFilterData", AV44BR_Procedure_DateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Procedure_PXRadiotherapyTitleFilterData", AV24BR_Procedure_PXRadiotherapyTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV48BR_Procedure_RadioDateTitleFilterData", AV48BR_Procedure_RadioDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50BR_Procedure_RadioTimeTitleFilterData", AV50BR_Procedure_RadioTimeTitleFilterData);
      }

      protected void E173P2( )
      {
         /* Ddo_br_procedure_pxsurgery_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_procedure_pxsurgery_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV10OrderedBy = 5;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_procedure_pxsurgery_Sortedstatus = "ASC";
            ucDdo_br_procedure_pxsurgery.SendProperty(context, "", false, Ddo_br_procedure_pxsurgery_Internalname, "SortedStatus", Ddo_br_procedure_pxsurgery_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_procedure_pxsurgery_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV10OrderedBy = 5;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_procedure_pxsurgery_Sortedstatus = "DSC";
            ucDdo_br_procedure_pxsurgery.SendProperty(context, "", false, Ddo_br_procedure_pxsurgery_Internalname, "SortedStatus", Ddo_br_procedure_pxsurgery_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12BR_ProcedureIDTitleFilterData", AV12BR_ProcedureIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14BR_EncounterIDTitleFilterData", AV14BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Information_PatientNoTitleFilterData", AV16BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18BR_Procedure_PXIDTitleFilterData", AV18BR_Procedure_PXIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Procedure_PXSurgeryTitleFilterData", AV20BR_Procedure_PXSurgeryTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44BR_Procedure_DateTitleFilterData", AV44BR_Procedure_DateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Procedure_PXRadiotherapyTitleFilterData", AV24BR_Procedure_PXRadiotherapyTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV48BR_Procedure_RadioDateTitleFilterData", AV48BR_Procedure_RadioDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50BR_Procedure_RadioTimeTitleFilterData", AV50BR_Procedure_RadioTimeTitleFilterData);
      }

      protected void E183P2( )
      {
         /* Ddo_br_procedure_date_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_procedure_date_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV10OrderedBy = 6;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_procedure_date_Sortedstatus = "ASC";
            ucDdo_br_procedure_date.SendProperty(context, "", false, Ddo_br_procedure_date_Internalname, "SortedStatus", Ddo_br_procedure_date_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_procedure_date_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV10OrderedBy = 6;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_procedure_date_Sortedstatus = "DSC";
            ucDdo_br_procedure_date.SendProperty(context, "", false, Ddo_br_procedure_date_Internalname, "SortedStatus", Ddo_br_procedure_date_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12BR_ProcedureIDTitleFilterData", AV12BR_ProcedureIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14BR_EncounterIDTitleFilterData", AV14BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Information_PatientNoTitleFilterData", AV16BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18BR_Procedure_PXIDTitleFilterData", AV18BR_Procedure_PXIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Procedure_PXSurgeryTitleFilterData", AV20BR_Procedure_PXSurgeryTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44BR_Procedure_DateTitleFilterData", AV44BR_Procedure_DateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Procedure_PXRadiotherapyTitleFilterData", AV24BR_Procedure_PXRadiotherapyTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV48BR_Procedure_RadioDateTitleFilterData", AV48BR_Procedure_RadioDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50BR_Procedure_RadioTimeTitleFilterData", AV50BR_Procedure_RadioTimeTitleFilterData);
      }

      protected void E193P2( )
      {
         /* Ddo_br_procedure_pxradiotherapy_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_procedure_pxradiotherapy_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV10OrderedBy = 7;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_procedure_pxradiotherapy_Sortedstatus = "ASC";
            ucDdo_br_procedure_pxradiotherapy.SendProperty(context, "", false, Ddo_br_procedure_pxradiotherapy_Internalname, "SortedStatus", Ddo_br_procedure_pxradiotherapy_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_procedure_pxradiotherapy_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV10OrderedBy = 7;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_procedure_pxradiotherapy_Sortedstatus = "DSC";
            ucDdo_br_procedure_pxradiotherapy.SendProperty(context, "", false, Ddo_br_procedure_pxradiotherapy_Internalname, "SortedStatus", Ddo_br_procedure_pxradiotherapy_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12BR_ProcedureIDTitleFilterData", AV12BR_ProcedureIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14BR_EncounterIDTitleFilterData", AV14BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Information_PatientNoTitleFilterData", AV16BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18BR_Procedure_PXIDTitleFilterData", AV18BR_Procedure_PXIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Procedure_PXSurgeryTitleFilterData", AV20BR_Procedure_PXSurgeryTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44BR_Procedure_DateTitleFilterData", AV44BR_Procedure_DateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Procedure_PXRadiotherapyTitleFilterData", AV24BR_Procedure_PXRadiotherapyTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV48BR_Procedure_RadioDateTitleFilterData", AV48BR_Procedure_RadioDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50BR_Procedure_RadioTimeTitleFilterData", AV50BR_Procedure_RadioTimeTitleFilterData);
      }

      protected void E203P2( )
      {
         /* Ddo_br_procedure_radiodate_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_procedure_radiodate_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV10OrderedBy = 8;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_procedure_radiodate_Sortedstatus = "ASC";
            ucDdo_br_procedure_radiodate.SendProperty(context, "", false, Ddo_br_procedure_radiodate_Internalname, "SortedStatus", Ddo_br_procedure_radiodate_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_procedure_radiodate_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV10OrderedBy = 8;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_procedure_radiodate_Sortedstatus = "DSC";
            ucDdo_br_procedure_radiodate.SendProperty(context, "", false, Ddo_br_procedure_radiodate_Internalname, "SortedStatus", Ddo_br_procedure_radiodate_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12BR_ProcedureIDTitleFilterData", AV12BR_ProcedureIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14BR_EncounterIDTitleFilterData", AV14BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Information_PatientNoTitleFilterData", AV16BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18BR_Procedure_PXIDTitleFilterData", AV18BR_Procedure_PXIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Procedure_PXSurgeryTitleFilterData", AV20BR_Procedure_PXSurgeryTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44BR_Procedure_DateTitleFilterData", AV44BR_Procedure_DateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Procedure_PXRadiotherapyTitleFilterData", AV24BR_Procedure_PXRadiotherapyTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV48BR_Procedure_RadioDateTitleFilterData", AV48BR_Procedure_RadioDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50BR_Procedure_RadioTimeTitleFilterData", AV50BR_Procedure_RadioTimeTitleFilterData);
      }

      protected void E213P2( )
      {
         /* Ddo_br_procedure_radiotime_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_procedure_radiotime_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV10OrderedBy = 9;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_procedure_radiotime_Sortedstatus = "ASC";
            ucDdo_br_procedure_radiotime.SendProperty(context, "", false, Ddo_br_procedure_radiotime_Internalname, "SortedStatus", Ddo_br_procedure_radiotime_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_procedure_radiotime_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV10OrderedBy = 9;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10OrderedBy), 4, 0)));
            AV11OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedDsc", AV11OrderedDsc);
            Ddo_br_procedure_radiotime_Sortedstatus = "DSC";
            ucDdo_br_procedure_radiotime.SendProperty(context, "", false, Ddo_br_procedure_radiotime_Internalname, "SortedStatus", Ddo_br_procedure_radiotime_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV12BR_ProcedureIDTitleFilterData", AV12BR_ProcedureIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV14BR_EncounterIDTitleFilterData", AV14BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16BR_Information_PatientNoTitleFilterData", AV16BR_Information_PatientNoTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV18BR_Procedure_PXIDTitleFilterData", AV18BR_Procedure_PXIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV20BR_Procedure_PXSurgeryTitleFilterData", AV20BR_Procedure_PXSurgeryTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV44BR_Procedure_DateTitleFilterData", AV44BR_Procedure_DateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV24BR_Procedure_PXRadiotherapyTitleFilterData", AV24BR_Procedure_PXRadiotherapyTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV48BR_Procedure_RadioDateTitleFilterData", AV48BR_Procedure_RadioDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV50BR_Procedure_RadioTimeTitleFilterData", AV50BR_Procedure_RadioTimeTitleFilterData);
      }

      private void E243P2( )
      {
         /* Grid_Load Routine */
         AV43Select = context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavSelect_Internalname, AV43Select);
         AV55Select_GXI = GXDbFile.PathToUrl( context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( )));
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
         E253P2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E253P2( )
      {
         /* Enter Routine */
         AV8InOutBR_ProcedureID = A139BR_ProcedureID;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8InOutBR_ProcedureID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8InOutBR_ProcedureID), 18, 0)));
         context.setWebReturnParms(new Object[] {(long)AV8InOutBR_ProcedureID});
         context.setWebReturnParmsMetadata(new Object[] {"AV8InOutBR_ProcedureID"});
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
         AV8InOutBR_ProcedureID = Convert.ToInt64(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8InOutBR_ProcedureID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8InOutBR_ProcedureID), 18, 0)));
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
         PA3P2( ) ;
         WS3P2( ) ;
         WE3P2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202022815114027", true);
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
         context.AddJavascriptSource("br_procedureprompt.js", "?202022815114027", false);
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
         context.AddJavascriptSource("DVelop/WorkWithPlusUtilities/WorkWithPlusUtilitiesRender.js", "", false);
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_122( )
      {
         edtavSelect_Internalname = "vSELECT_"+sGXsfl_12_idx;
         edtBR_ProcedureID_Internalname = "BR_PROCEDUREID_"+sGXsfl_12_idx;
         edtBR_EncounterID_Internalname = "BR_ENCOUNTERID_"+sGXsfl_12_idx;
         edtBR_Information_PatientNo_Internalname = "BR_INFORMATION_PATIENTNO_"+sGXsfl_12_idx;
         edtBR_Procedure_PXID_Internalname = "BR_PROCEDURE_PXID_"+sGXsfl_12_idx;
         cmbBR_Procedure_PXSurgery_Internalname = "BR_PROCEDURE_PXSURGERY_"+sGXsfl_12_idx;
         edtBR_Procedure_Date_Internalname = "BR_PROCEDURE_DATE_"+sGXsfl_12_idx;
         cmbBR_Procedure_PXRadiotherapy_Internalname = "BR_PROCEDURE_PXRADIOTHERAPY_"+sGXsfl_12_idx;
         edtBR_Procedure_RadioDate_Internalname = "BR_PROCEDURE_RADIODATE_"+sGXsfl_12_idx;
         edtBR_Procedure_RadioTime_Internalname = "BR_PROCEDURE_RADIOTIME_"+sGXsfl_12_idx;
      }

      protected void SubsflControlProps_fel_122( )
      {
         edtavSelect_Internalname = "vSELECT_"+sGXsfl_12_fel_idx;
         edtBR_ProcedureID_Internalname = "BR_PROCEDUREID_"+sGXsfl_12_fel_idx;
         edtBR_EncounterID_Internalname = "BR_ENCOUNTERID_"+sGXsfl_12_fel_idx;
         edtBR_Information_PatientNo_Internalname = "BR_INFORMATION_PATIENTNO_"+sGXsfl_12_fel_idx;
         edtBR_Procedure_PXID_Internalname = "BR_PROCEDURE_PXID_"+sGXsfl_12_fel_idx;
         cmbBR_Procedure_PXSurgery_Internalname = "BR_PROCEDURE_PXSURGERY_"+sGXsfl_12_fel_idx;
         edtBR_Procedure_Date_Internalname = "BR_PROCEDURE_DATE_"+sGXsfl_12_fel_idx;
         cmbBR_Procedure_PXRadiotherapy_Internalname = "BR_PROCEDURE_PXRADIOTHERAPY_"+sGXsfl_12_fel_idx;
         edtBR_Procedure_RadioDate_Internalname = "BR_PROCEDURE_RADIODATE_"+sGXsfl_12_fel_idx;
         edtBR_Procedure_RadioTime_Internalname = "BR_PROCEDURE_RADIOTIME_"+sGXsfl_12_fel_idx;
      }

      protected void sendrow_122( )
      {
         SubsflControlProps_122( ) ;
         WB3P0( ) ;
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
            AV43Select_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV43Select))&&String.IsNullOrEmpty(StringUtil.RTrim( AV55Select_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV43Select)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV43Select)) ? AV55Select_GXI : context.PathToRelativeUrl( AV43Select));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavSelect_Internalname,(String)sImgUrl,(String)"",(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)edtavSelect_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)5,(String)edtavSelect_Jsonclick,"'"+""+"'"+",false,"+"'"+"EENTER."+sGXsfl_12_idx+"'",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)""+TempTags,(String)"",(String)"",(short)1,(bool)AV43Select_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_ProcedureID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A139BR_ProcedureID), 18, 0, ".", "")),context.localUtil.Format( (decimal)(A139BR_ProcedureID), "ZZZZZZZZZZZZZZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_ProcedureID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"ID",(String)"right",(bool)false});
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
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Procedure_PXID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A140BR_Procedure_PXID), 10, 0, ".", "")),context.localUtil.Format( (decimal)(A140BR_Procedure_PXID), "ZZZZZZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Procedure_PXID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            if ( ( cmbBR_Procedure_PXSurgery.ItemCount == 0 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "BR_PROCEDURE_PXSURGERY_" + sGXsfl_12_idx;
               cmbBR_Procedure_PXSurgery.Name = GXCCtl;
               cmbBR_Procedure_PXSurgery.WebTags = "";
               cmbBR_Procedure_PXSurgery.addItem("否", "否", 0);
               cmbBR_Procedure_PXSurgery.addItem("是", "是", 0);
               cmbBR_Procedure_PXSurgery.addItem("不详", "不详", 0);
               if ( cmbBR_Procedure_PXSurgery.ItemCount > 0 )
               {
                  A141BR_Procedure_PXSurgery = cmbBR_Procedure_PXSurgery.getValidValue(A141BR_Procedure_PXSurgery);
                  n141BR_Procedure_PXSurgery = false;
               }
            }
            /* ComboBox */
            GridRow.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbBR_Procedure_PXSurgery,(String)cmbBR_Procedure_PXSurgery_Internalname,StringUtil.RTrim( A141BR_Procedure_PXSurgery),(short)1,(String)cmbBR_Procedure_PXSurgery_Jsonclick,(short)0,(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"svchar",(String)"",(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)"",(String)"Attribute",(String)"WWColumn hidden-xs",(String)"",(String)"",(String)"",(bool)true});
            cmbBR_Procedure_PXSurgery.CurrentValue = StringUtil.RTrim( A141BR_Procedure_PXSurgery);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Procedure_PXSurgery_Internalname, "Values", (String)(cmbBR_Procedure_PXSurgery.ToJavascriptSource()), !bGXsfl_12_Refreshing);
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Procedure_Date_Internalname,context.localUtil.Format(A266BR_Procedure_Date, "9999/99/99"),context.localUtil.Format( A266BR_Procedure_Date, "9999/99/99"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Procedure_Date_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"DM_Date",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            if ( ( cmbBR_Procedure_PXRadiotherapy.ItemCount == 0 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "BR_PROCEDURE_PXRADIOTHERAPY_" + sGXsfl_12_idx;
               cmbBR_Procedure_PXRadiotherapy.Name = GXCCtl;
               cmbBR_Procedure_PXRadiotherapy.WebTags = "";
               cmbBR_Procedure_PXRadiotherapy.addItem("否", "否", 0);
               cmbBR_Procedure_PXRadiotherapy.addItem("是", "是", 0);
               cmbBR_Procedure_PXRadiotherapy.addItem("不详", "不详", 0);
               if ( cmbBR_Procedure_PXRadiotherapy.ItemCount > 0 )
               {
                  A143BR_Procedure_PXRadiotherapy = cmbBR_Procedure_PXRadiotherapy.getValidValue(A143BR_Procedure_PXRadiotherapy);
                  n143BR_Procedure_PXRadiotherapy = false;
               }
            }
            /* ComboBox */
            GridRow.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbBR_Procedure_PXRadiotherapy,(String)cmbBR_Procedure_PXRadiotherapy_Internalname,StringUtil.RTrim( A143BR_Procedure_PXRadiotherapy),(short)1,(String)cmbBR_Procedure_PXRadiotherapy_Jsonclick,(short)0,(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"svchar",(String)"",(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)"",(String)"Attribute",(String)"WWColumn hidden-xs",(String)"",(String)"",(String)"",(bool)true});
            cmbBR_Procedure_PXRadiotherapy.CurrentValue = StringUtil.RTrim( A143BR_Procedure_PXRadiotherapy);
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Procedure_PXRadiotherapy_Internalname, "Values", (String)(cmbBR_Procedure_PXRadiotherapy.ToJavascriptSource()), !bGXsfl_12_Refreshing);
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Procedure_RadioDate_Internalname,context.localUtil.Format(A268BR_Procedure_RadioDate, "9999/99/99"),context.localUtil.Format( A268BR_Procedure_RadioDate, "9999/99/99"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Procedure_RadioDate_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"DM_Date",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Procedure_RadioTime_Internalname,StringUtil.LTrim( StringUtil.NToC( A269BR_Procedure_RadioTime, 15, 5, ".", "")),context.localUtil.Format( A269BR_Procedure_RadioTime, "ZZZZZZZZZ.ZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Procedure_RadioTime_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)15,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"DM_Numeric",(String)"right",(bool)false});
            send_integrity_lvl_hashes3P2( ) ;
            GridContainer.AddRow(GridRow);
            nGXsfl_12_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_12_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_12_idx+1));
            sGXsfl_12_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_12_idx), 4, 0)), 4, "0");
            SubsflControlProps_122( ) ;
         }
         /* End function sendrow_122 */
      }

      protected void init_web_controls( )
      {
         GXCCtl = "BR_PROCEDURE_PXSURGERY_" + sGXsfl_12_idx;
         cmbBR_Procedure_PXSurgery.Name = GXCCtl;
         cmbBR_Procedure_PXSurgery.WebTags = "";
         cmbBR_Procedure_PXSurgery.addItem("否", "否", 0);
         cmbBR_Procedure_PXSurgery.addItem("是", "是", 0);
         cmbBR_Procedure_PXSurgery.addItem("不详", "不详", 0);
         if ( cmbBR_Procedure_PXSurgery.ItemCount > 0 )
         {
            A141BR_Procedure_PXSurgery = cmbBR_Procedure_PXSurgery.getValidValue(A141BR_Procedure_PXSurgery);
            n141BR_Procedure_PXSurgery = false;
         }
         GXCCtl = "BR_PROCEDURE_PXRADIOTHERAPY_" + sGXsfl_12_idx;
         cmbBR_Procedure_PXRadiotherapy.Name = GXCCtl;
         cmbBR_Procedure_PXRadiotherapy.WebTags = "";
         cmbBR_Procedure_PXRadiotherapy.addItem("否", "否", 0);
         cmbBR_Procedure_PXRadiotherapy.addItem("是", "是", 0);
         cmbBR_Procedure_PXRadiotherapy.addItem("不详", "不详", 0);
         if ( cmbBR_Procedure_PXRadiotherapy.ItemCount > 0 )
         {
            A143BR_Procedure_PXRadiotherapy = cmbBR_Procedure_PXRadiotherapy.getValidValue(A143BR_Procedure_PXRadiotherapy);
            n143BR_Procedure_PXRadiotherapy = false;
         }
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         edtavSelect_Internalname = "vSELECT";
         edtBR_ProcedureID_Internalname = "BR_PROCEDUREID";
         edtBR_EncounterID_Internalname = "BR_ENCOUNTERID";
         edtBR_Information_PatientNo_Internalname = "BR_INFORMATION_PATIENTNO";
         edtBR_Procedure_PXID_Internalname = "BR_PROCEDURE_PXID";
         cmbBR_Procedure_PXSurgery_Internalname = "BR_PROCEDURE_PXSURGERY";
         edtBR_Procedure_Date_Internalname = "BR_PROCEDURE_DATE";
         cmbBR_Procedure_PXRadiotherapy_Internalname = "BR_PROCEDURE_PXRADIOTHERAPY";
         edtBR_Procedure_RadioDate_Internalname = "BR_PROCEDURE_RADIODATE";
         edtBR_Procedure_RadioTime_Internalname = "BR_PROCEDURE_RADIOTIME";
         Gridpaginationbar_Internalname = "GRIDPAGINATIONBAR";
         divHtml_gridpaginationbar_Internalname = "HTML_GRIDPAGINATIONBAR";
         divGridtablewithpaginationbar_Internalname = "GRIDTABLEWITHPAGINATIONBAR";
         divTablemain_Internalname = "TABLEMAIN";
         Ddo_br_procedureid_Internalname = "DDO_BR_PROCEDUREID";
         edtavDdo_br_procedureidtitlecontrolidtoreplace_Internalname = "vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE";
         Ddo_br_encounterid_Internalname = "DDO_BR_ENCOUNTERID";
         edtavDdo_br_encounteridtitlecontrolidtoreplace_Internalname = "vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE";
         Ddo_br_information_patientno_Internalname = "DDO_BR_INFORMATION_PATIENTNO";
         edtavDdo_br_information_patientnotitlecontrolidtoreplace_Internalname = "vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE";
         Ddo_br_procedure_pxid_Internalname = "DDO_BR_PROCEDURE_PXID";
         edtavDdo_br_procedure_pxidtitlecontrolidtoreplace_Internalname = "vDDO_BR_PROCEDURE_PXIDTITLECONTROLIDTOREPLACE";
         Ddo_br_procedure_pxsurgery_Internalname = "DDO_BR_PROCEDURE_PXSURGERY";
         edtavDdo_br_procedure_pxsurgerytitlecontrolidtoreplace_Internalname = "vDDO_BR_PROCEDURE_PXSURGERYTITLECONTROLIDTOREPLACE";
         Ddo_br_procedure_date_Internalname = "DDO_BR_PROCEDURE_DATE";
         edtavDdo_br_procedure_datetitlecontrolidtoreplace_Internalname = "vDDO_BR_PROCEDURE_DATETITLECONTROLIDTOREPLACE";
         Ddo_br_procedure_pxradiotherapy_Internalname = "DDO_BR_PROCEDURE_PXRADIOTHERAPY";
         edtavDdo_br_procedure_pxradiotherapytitlecontrolidtoreplace_Internalname = "vDDO_BR_PROCEDURE_PXRADIOTHERAPYTITLECONTROLIDTOREPLACE";
         Ddo_br_procedure_radiodate_Internalname = "DDO_BR_PROCEDURE_RADIODATE";
         edtavDdo_br_procedure_radiodatetitlecontrolidtoreplace_Internalname = "vDDO_BR_PROCEDURE_RADIODATETITLECONTROLIDTOREPLACE";
         Ddo_br_procedure_radiotime_Internalname = "DDO_BR_PROCEDURE_RADIOTIME";
         edtavDdo_br_procedure_radiotimetitlecontrolidtoreplace_Internalname = "vDDO_BR_PROCEDURE_RADIOTIMETITLECONTROLIDTOREPLACE";
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
         edtBR_Procedure_RadioTime_Jsonclick = "";
         edtBR_Procedure_RadioDate_Jsonclick = "";
         cmbBR_Procedure_PXRadiotherapy_Jsonclick = "";
         edtBR_Procedure_Date_Jsonclick = "";
         cmbBR_Procedure_PXSurgery_Jsonclick = "";
         edtBR_Procedure_PXID_Jsonclick = "";
         edtBR_Information_PatientNo_Jsonclick = "";
         edtBR_EncounterID_Jsonclick = "";
         edtBR_ProcedureID_Jsonclick = "";
         edtavSelect_Jsonclick = "";
         edtavSelect_Visible = -1;
         edtavSelect_Enabled = 1;
         edtavOrdereddsc_Jsonclick = "";
         edtavOrdereddsc_Visible = 1;
         edtavOrderedby_Jsonclick = "";
         edtavOrderedby_Visible = 1;
         edtavDdo_br_procedure_radiotimetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_procedure_radiodatetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_procedure_pxradiotherapytitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_procedure_datetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_procedure_pxsurgerytitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_procedure_pxidtitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_information_patientnotitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_encounteridtitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_procedureidtitlecontrolidtoreplace_Visible = 1;
         subGrid_Allowcollapsing = 0;
         subGrid_Allowselection = 0;
         edtavSelect_Tooltiptext = "选择";
         subGrid_Sortable = 0;
         subGrid_Header = "";
         edtBR_Procedure_RadioTime_Titleformat = 0;
         edtBR_Procedure_RadioTime_Title = "放疗疗程";
         edtBR_Procedure_RadioDate_Titleformat = 0;
         edtBR_Procedure_RadioDate_Title = "放疗日期";
         cmbBR_Procedure_PXRadiotherapy_Titleformat = 0;
         cmbBR_Procedure_PXRadiotherapy.Title.Text = "是否接受放射疗法";
         edtBR_Procedure_Date_Titleformat = 0;
         edtBR_Procedure_Date_Title = "手术日期";
         cmbBR_Procedure_PXSurgery_Titleformat = 0;
         cmbBR_Procedure_PXSurgery.Title.Text = "是否手术";
         edtBR_Procedure_PXID_Titleformat = 0;
         edtBR_Procedure_PXID_Title = "诊疗序号";
         edtBR_Information_PatientNo_Titleformat = 0;
         edtBR_Information_PatientNo_Title = "患者编号";
         edtBR_EncounterID_Titleformat = 0;
         edtBR_EncounterID_Title = "就诊信息主键";
         edtBR_ProcedureID_Titleformat = 0;
         edtBR_ProcedureID_Title = "诊疗处理主键";
         subGrid_Class = "GridWithPaginationBar GridWithBorderColor WorkWith";
         subGrid_Backcolorstyle = 0;
         divTablemain_Height = 0;
         Ddo_br_procedure_radiotime_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_procedure_radiotime_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_procedure_radiotime_Sortasc = "WWP_TSSortASC";
         Ddo_br_procedure_radiotime_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_procedure_radiotime_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_procedure_radiotime_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_procedure_radiotime_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_procedure_radiotime_Titlecontrolidtoreplace = "";
         Ddo_br_procedure_radiotime_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_procedure_radiotime_Cls = "ColumnSettings";
         Ddo_br_procedure_radiotime_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_procedure_radiotime_Caption = "";
         Ddo_br_procedure_radiodate_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_procedure_radiodate_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_procedure_radiodate_Sortasc = "WWP_TSSortASC";
         Ddo_br_procedure_radiodate_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_procedure_radiodate_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_procedure_radiodate_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_procedure_radiodate_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_procedure_radiodate_Titlecontrolidtoreplace = "";
         Ddo_br_procedure_radiodate_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_procedure_radiodate_Cls = "ColumnSettings";
         Ddo_br_procedure_radiodate_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_procedure_radiodate_Caption = "";
         Ddo_br_procedure_pxradiotherapy_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_procedure_pxradiotherapy_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_procedure_pxradiotherapy_Sortasc = "WWP_TSSortASC";
         Ddo_br_procedure_pxradiotherapy_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_procedure_pxradiotherapy_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_procedure_pxradiotherapy_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_procedure_pxradiotherapy_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_procedure_pxradiotherapy_Titlecontrolidtoreplace = "";
         Ddo_br_procedure_pxradiotherapy_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_procedure_pxradiotherapy_Cls = "ColumnSettings";
         Ddo_br_procedure_pxradiotherapy_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_procedure_pxradiotherapy_Caption = "";
         Ddo_br_procedure_date_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_procedure_date_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_procedure_date_Sortasc = "WWP_TSSortASC";
         Ddo_br_procedure_date_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_procedure_date_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_procedure_date_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_procedure_date_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_procedure_date_Titlecontrolidtoreplace = "";
         Ddo_br_procedure_date_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_procedure_date_Cls = "ColumnSettings";
         Ddo_br_procedure_date_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_procedure_date_Caption = "";
         Ddo_br_procedure_pxsurgery_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_procedure_pxsurgery_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_procedure_pxsurgery_Sortasc = "WWP_TSSortASC";
         Ddo_br_procedure_pxsurgery_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_procedure_pxsurgery_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_procedure_pxsurgery_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_procedure_pxsurgery_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_procedure_pxsurgery_Titlecontrolidtoreplace = "";
         Ddo_br_procedure_pxsurgery_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_procedure_pxsurgery_Cls = "ColumnSettings";
         Ddo_br_procedure_pxsurgery_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_procedure_pxsurgery_Caption = "";
         Ddo_br_procedure_pxid_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_procedure_pxid_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_procedure_pxid_Sortasc = "WWP_TSSortASC";
         Ddo_br_procedure_pxid_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_procedure_pxid_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_procedure_pxid_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_procedure_pxid_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_procedure_pxid_Titlecontrolidtoreplace = "";
         Ddo_br_procedure_pxid_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_procedure_pxid_Cls = "ColumnSettings";
         Ddo_br_procedure_pxid_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_procedure_pxid_Caption = "";
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
         Ddo_br_procedureid_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_procedureid_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_procedureid_Sortasc = "WWP_TSSortASC";
         Ddo_br_procedureid_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_procedureid_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_procedureid_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_procedureid_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_procedureid_Titlecontrolidtoreplace = "";
         Ddo_br_procedureid_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_procedureid_Cls = "ColumnSettings";
         Ddo_br_procedureid_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_procedureid_Caption = "";
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
         Form.Caption = "选择诊疗处理";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_ProcedureIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Procedure_PXIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXSURGERYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_BR_Procedure_DateTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_DATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXRADIOTHERAPYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_Procedure_RadioDateTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIODATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV51ddo_BR_Procedure_RadioTimeTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIOTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]");
         setEventMetadata("REFRESH",",oparms:[{av:'AV12BR_ProcedureIDTitleFilterData',fld:'vBR_PROCEDUREIDTITLEFILTERDATA',pic:''},{av:'AV14BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV16BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV18BR_Procedure_PXIDTitleFilterData',fld:'vBR_PROCEDURE_PXIDTITLEFILTERDATA',pic:''},{av:'AV20BR_Procedure_PXSurgeryTitleFilterData',fld:'vBR_PROCEDURE_PXSURGERYTITLEFILTERDATA',pic:''},{av:'AV44BR_Procedure_DateTitleFilterData',fld:'vBR_PROCEDURE_DATETITLEFILTERDATA',pic:''},{av:'AV24BR_Procedure_PXRadiotherapyTitleFilterData',fld:'vBR_PROCEDURE_PXRADIOTHERAPYTITLEFILTERDATA',pic:''},{av:'AV48BR_Procedure_RadioDateTitleFilterData',fld:'vBR_PROCEDURE_RADIODATETITLEFILTERDATA',pic:''},{av:'AV50BR_Procedure_RadioTimeTitleFilterData',fld:'vBR_PROCEDURE_RADIOTIMETITLEFILTERDATA',pic:''},{av:'edtBR_ProcedureID_Titleformat',ctrl:'BR_PROCEDUREID',prop:'Titleformat'},{av:'edtBR_ProcedureID_Title',ctrl:'BR_PROCEDUREID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Procedure_PXID_Titleformat',ctrl:'BR_PROCEDURE_PXID',prop:'Titleformat'},{av:'edtBR_Procedure_PXID_Title',ctrl:'BR_PROCEDURE_PXID',prop:'Title'},{av:'cmbBR_Procedure_PXSurgery'},{av:'edtBR_Procedure_Date_Titleformat',ctrl:'BR_PROCEDURE_DATE',prop:'Titleformat'},{av:'edtBR_Procedure_Date_Title',ctrl:'BR_PROCEDURE_DATE',prop:'Title'},{av:'cmbBR_Procedure_PXRadiotherapy'},{av:'edtBR_Procedure_RadioDate_Titleformat',ctrl:'BR_PROCEDURE_RADIODATE',prop:'Titleformat'},{av:'edtBR_Procedure_RadioDate_Title',ctrl:'BR_PROCEDURE_RADIODATE',prop:'Title'},{av:'edtBR_Procedure_RadioTime_Titleformat',ctrl:'BR_PROCEDURE_RADIOTIME',prop:'Titleformat'},{av:'edtBR_Procedure_RadioTime_Title',ctrl:'BR_PROCEDURE_RADIOTIME',prop:'Title'},{av:'AV40GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV41GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV42GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE","{handler:'E113P2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_ProcedureIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Procedure_PXIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXSURGERYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_BR_Procedure_DateTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_DATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXRADIOTHERAPYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_Procedure_RadioDateTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIODATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV51ddo_BR_Procedure_RadioTimeTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIOTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'Gridpaginationbar_Selectedpage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE",",oparms:[]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE","{handler:'E123P2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_ProcedureIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Procedure_PXIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXSURGERYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_BR_Procedure_DateTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_DATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXRADIOTHERAPYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_Procedure_RadioDateTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIODATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV51ddo_BR_Procedure_RadioTimeTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIOTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'Gridpaginationbar_Rowsperpageselectedvalue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE",",oparms:[{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]}");
         setEventMetadata("DDO_BR_PROCEDUREID.ONOPTIONCLICKED","{handler:'E133P2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_ProcedureIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Procedure_PXIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXSURGERYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_BR_Procedure_DateTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_DATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXRADIOTHERAPYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_Procedure_RadioDateTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIODATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV51ddo_BR_Procedure_RadioTimeTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIOTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_procedureid_Activeeventkey',ctrl:'DDO_BR_PROCEDUREID',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_PROCEDUREID.ONOPTIONCLICKED",",oparms:[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_procedureid_Sortedstatus',ctrl:'DDO_BR_PROCEDUREID',prop:'SortedStatus'},{av:'AV12BR_ProcedureIDTitleFilterData',fld:'vBR_PROCEDUREIDTITLEFILTERDATA',pic:''},{av:'AV14BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV16BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV18BR_Procedure_PXIDTitleFilterData',fld:'vBR_PROCEDURE_PXIDTITLEFILTERDATA',pic:''},{av:'AV20BR_Procedure_PXSurgeryTitleFilterData',fld:'vBR_PROCEDURE_PXSURGERYTITLEFILTERDATA',pic:''},{av:'AV44BR_Procedure_DateTitleFilterData',fld:'vBR_PROCEDURE_DATETITLEFILTERDATA',pic:''},{av:'AV24BR_Procedure_PXRadiotherapyTitleFilterData',fld:'vBR_PROCEDURE_PXRADIOTHERAPYTITLEFILTERDATA',pic:''},{av:'AV48BR_Procedure_RadioDateTitleFilterData',fld:'vBR_PROCEDURE_RADIODATETITLEFILTERDATA',pic:''},{av:'AV50BR_Procedure_RadioTimeTitleFilterData',fld:'vBR_PROCEDURE_RADIOTIMETITLEFILTERDATA',pic:''},{av:'edtBR_ProcedureID_Titleformat',ctrl:'BR_PROCEDUREID',prop:'Titleformat'},{av:'edtBR_ProcedureID_Title',ctrl:'BR_PROCEDUREID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Procedure_PXID_Titleformat',ctrl:'BR_PROCEDURE_PXID',prop:'Titleformat'},{av:'edtBR_Procedure_PXID_Title',ctrl:'BR_PROCEDURE_PXID',prop:'Title'},{av:'cmbBR_Procedure_PXSurgery'},{av:'edtBR_Procedure_Date_Titleformat',ctrl:'BR_PROCEDURE_DATE',prop:'Titleformat'},{av:'edtBR_Procedure_Date_Title',ctrl:'BR_PROCEDURE_DATE',prop:'Title'},{av:'cmbBR_Procedure_PXRadiotherapy'},{av:'edtBR_Procedure_RadioDate_Titleformat',ctrl:'BR_PROCEDURE_RADIODATE',prop:'Titleformat'},{av:'edtBR_Procedure_RadioDate_Title',ctrl:'BR_PROCEDURE_RADIODATE',prop:'Title'},{av:'edtBR_Procedure_RadioTime_Titleformat',ctrl:'BR_PROCEDURE_RADIOTIME',prop:'Titleformat'},{av:'edtBR_Procedure_RadioTime_Title',ctrl:'BR_PROCEDURE_RADIOTIME',prop:'Title'},{av:'AV40GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV41GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV42GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_ENCOUNTERID.ONOPTIONCLICKED","{handler:'E143P2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_ProcedureIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Procedure_PXIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXSURGERYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_BR_Procedure_DateTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_DATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXRADIOTHERAPYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_Procedure_RadioDateTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIODATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV51ddo_BR_Procedure_RadioTimeTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIOTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_encounterid_Activeeventkey',ctrl:'DDO_BR_ENCOUNTERID',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_ENCOUNTERID.ONOPTIONCLICKED",",oparms:[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_encounterid_Sortedstatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'AV12BR_ProcedureIDTitleFilterData',fld:'vBR_PROCEDUREIDTITLEFILTERDATA',pic:''},{av:'AV14BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV16BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV18BR_Procedure_PXIDTitleFilterData',fld:'vBR_PROCEDURE_PXIDTITLEFILTERDATA',pic:''},{av:'AV20BR_Procedure_PXSurgeryTitleFilterData',fld:'vBR_PROCEDURE_PXSURGERYTITLEFILTERDATA',pic:''},{av:'AV44BR_Procedure_DateTitleFilterData',fld:'vBR_PROCEDURE_DATETITLEFILTERDATA',pic:''},{av:'AV24BR_Procedure_PXRadiotherapyTitleFilterData',fld:'vBR_PROCEDURE_PXRADIOTHERAPYTITLEFILTERDATA',pic:''},{av:'AV48BR_Procedure_RadioDateTitleFilterData',fld:'vBR_PROCEDURE_RADIODATETITLEFILTERDATA',pic:''},{av:'AV50BR_Procedure_RadioTimeTitleFilterData',fld:'vBR_PROCEDURE_RADIOTIMETITLEFILTERDATA',pic:''},{av:'edtBR_ProcedureID_Titleformat',ctrl:'BR_PROCEDUREID',prop:'Titleformat'},{av:'edtBR_ProcedureID_Title',ctrl:'BR_PROCEDUREID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Procedure_PXID_Titleformat',ctrl:'BR_PROCEDURE_PXID',prop:'Titleformat'},{av:'edtBR_Procedure_PXID_Title',ctrl:'BR_PROCEDURE_PXID',prop:'Title'},{av:'cmbBR_Procedure_PXSurgery'},{av:'edtBR_Procedure_Date_Titleformat',ctrl:'BR_PROCEDURE_DATE',prop:'Titleformat'},{av:'edtBR_Procedure_Date_Title',ctrl:'BR_PROCEDURE_DATE',prop:'Title'},{av:'cmbBR_Procedure_PXRadiotherapy'},{av:'edtBR_Procedure_RadioDate_Titleformat',ctrl:'BR_PROCEDURE_RADIODATE',prop:'Titleformat'},{av:'edtBR_Procedure_RadioDate_Title',ctrl:'BR_PROCEDURE_RADIODATE',prop:'Title'},{av:'edtBR_Procedure_RadioTime_Titleformat',ctrl:'BR_PROCEDURE_RADIOTIME',prop:'Titleformat'},{av:'edtBR_Procedure_RadioTime_Title',ctrl:'BR_PROCEDURE_RADIOTIME',prop:'Title'},{av:'AV40GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV41GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV42GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_INFORMATION_PATIENTNO.ONOPTIONCLICKED","{handler:'E153P2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_ProcedureIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Procedure_PXIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXSURGERYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_BR_Procedure_DateTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_DATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXRADIOTHERAPYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_Procedure_RadioDateTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIODATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV51ddo_BR_Procedure_RadioTimeTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIOTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_information_patientno_Activeeventkey',ctrl:'DDO_BR_INFORMATION_PATIENTNO',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_INFORMATION_PATIENTNO.ONOPTIONCLICKED",",oparms:[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_information_patientno_Sortedstatus',ctrl:'DDO_BR_INFORMATION_PATIENTNO',prop:'SortedStatus'},{av:'AV12BR_ProcedureIDTitleFilterData',fld:'vBR_PROCEDUREIDTITLEFILTERDATA',pic:''},{av:'AV14BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV16BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV18BR_Procedure_PXIDTitleFilterData',fld:'vBR_PROCEDURE_PXIDTITLEFILTERDATA',pic:''},{av:'AV20BR_Procedure_PXSurgeryTitleFilterData',fld:'vBR_PROCEDURE_PXSURGERYTITLEFILTERDATA',pic:''},{av:'AV44BR_Procedure_DateTitleFilterData',fld:'vBR_PROCEDURE_DATETITLEFILTERDATA',pic:''},{av:'AV24BR_Procedure_PXRadiotherapyTitleFilterData',fld:'vBR_PROCEDURE_PXRADIOTHERAPYTITLEFILTERDATA',pic:''},{av:'AV48BR_Procedure_RadioDateTitleFilterData',fld:'vBR_PROCEDURE_RADIODATETITLEFILTERDATA',pic:''},{av:'AV50BR_Procedure_RadioTimeTitleFilterData',fld:'vBR_PROCEDURE_RADIOTIMETITLEFILTERDATA',pic:''},{av:'edtBR_ProcedureID_Titleformat',ctrl:'BR_PROCEDUREID',prop:'Titleformat'},{av:'edtBR_ProcedureID_Title',ctrl:'BR_PROCEDUREID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Procedure_PXID_Titleformat',ctrl:'BR_PROCEDURE_PXID',prop:'Titleformat'},{av:'edtBR_Procedure_PXID_Title',ctrl:'BR_PROCEDURE_PXID',prop:'Title'},{av:'cmbBR_Procedure_PXSurgery'},{av:'edtBR_Procedure_Date_Titleformat',ctrl:'BR_PROCEDURE_DATE',prop:'Titleformat'},{av:'edtBR_Procedure_Date_Title',ctrl:'BR_PROCEDURE_DATE',prop:'Title'},{av:'cmbBR_Procedure_PXRadiotherapy'},{av:'edtBR_Procedure_RadioDate_Titleformat',ctrl:'BR_PROCEDURE_RADIODATE',prop:'Titleformat'},{av:'edtBR_Procedure_RadioDate_Title',ctrl:'BR_PROCEDURE_RADIODATE',prop:'Title'},{av:'edtBR_Procedure_RadioTime_Titleformat',ctrl:'BR_PROCEDURE_RADIOTIME',prop:'Titleformat'},{av:'edtBR_Procedure_RadioTime_Title',ctrl:'BR_PROCEDURE_RADIOTIME',prop:'Title'},{av:'AV40GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV41GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV42GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_PROCEDURE_PXID.ONOPTIONCLICKED","{handler:'E163P2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_ProcedureIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Procedure_PXIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXSURGERYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_BR_Procedure_DateTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_DATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXRADIOTHERAPYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_Procedure_RadioDateTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIODATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV51ddo_BR_Procedure_RadioTimeTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIOTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_procedure_pxid_Activeeventkey',ctrl:'DDO_BR_PROCEDURE_PXID',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_PROCEDURE_PXID.ONOPTIONCLICKED",",oparms:[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_procedure_pxid_Sortedstatus',ctrl:'DDO_BR_PROCEDURE_PXID',prop:'SortedStatus'},{av:'AV12BR_ProcedureIDTitleFilterData',fld:'vBR_PROCEDUREIDTITLEFILTERDATA',pic:''},{av:'AV14BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV16BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV18BR_Procedure_PXIDTitleFilterData',fld:'vBR_PROCEDURE_PXIDTITLEFILTERDATA',pic:''},{av:'AV20BR_Procedure_PXSurgeryTitleFilterData',fld:'vBR_PROCEDURE_PXSURGERYTITLEFILTERDATA',pic:''},{av:'AV44BR_Procedure_DateTitleFilterData',fld:'vBR_PROCEDURE_DATETITLEFILTERDATA',pic:''},{av:'AV24BR_Procedure_PXRadiotherapyTitleFilterData',fld:'vBR_PROCEDURE_PXRADIOTHERAPYTITLEFILTERDATA',pic:''},{av:'AV48BR_Procedure_RadioDateTitleFilterData',fld:'vBR_PROCEDURE_RADIODATETITLEFILTERDATA',pic:''},{av:'AV50BR_Procedure_RadioTimeTitleFilterData',fld:'vBR_PROCEDURE_RADIOTIMETITLEFILTERDATA',pic:''},{av:'edtBR_ProcedureID_Titleformat',ctrl:'BR_PROCEDUREID',prop:'Titleformat'},{av:'edtBR_ProcedureID_Title',ctrl:'BR_PROCEDUREID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Procedure_PXID_Titleformat',ctrl:'BR_PROCEDURE_PXID',prop:'Titleformat'},{av:'edtBR_Procedure_PXID_Title',ctrl:'BR_PROCEDURE_PXID',prop:'Title'},{av:'cmbBR_Procedure_PXSurgery'},{av:'edtBR_Procedure_Date_Titleformat',ctrl:'BR_PROCEDURE_DATE',prop:'Titleformat'},{av:'edtBR_Procedure_Date_Title',ctrl:'BR_PROCEDURE_DATE',prop:'Title'},{av:'cmbBR_Procedure_PXRadiotherapy'},{av:'edtBR_Procedure_RadioDate_Titleformat',ctrl:'BR_PROCEDURE_RADIODATE',prop:'Titleformat'},{av:'edtBR_Procedure_RadioDate_Title',ctrl:'BR_PROCEDURE_RADIODATE',prop:'Title'},{av:'edtBR_Procedure_RadioTime_Titleformat',ctrl:'BR_PROCEDURE_RADIOTIME',prop:'Titleformat'},{av:'edtBR_Procedure_RadioTime_Title',ctrl:'BR_PROCEDURE_RADIOTIME',prop:'Title'},{av:'AV40GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV41GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV42GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_PROCEDURE_PXSURGERY.ONOPTIONCLICKED","{handler:'E173P2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_ProcedureIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Procedure_PXIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXSURGERYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_BR_Procedure_DateTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_DATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXRADIOTHERAPYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_Procedure_RadioDateTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIODATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV51ddo_BR_Procedure_RadioTimeTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIOTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_procedure_pxsurgery_Activeeventkey',ctrl:'DDO_BR_PROCEDURE_PXSURGERY',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_PROCEDURE_PXSURGERY.ONOPTIONCLICKED",",oparms:[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_procedure_pxsurgery_Sortedstatus',ctrl:'DDO_BR_PROCEDURE_PXSURGERY',prop:'SortedStatus'},{av:'AV12BR_ProcedureIDTitleFilterData',fld:'vBR_PROCEDUREIDTITLEFILTERDATA',pic:''},{av:'AV14BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV16BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV18BR_Procedure_PXIDTitleFilterData',fld:'vBR_PROCEDURE_PXIDTITLEFILTERDATA',pic:''},{av:'AV20BR_Procedure_PXSurgeryTitleFilterData',fld:'vBR_PROCEDURE_PXSURGERYTITLEFILTERDATA',pic:''},{av:'AV44BR_Procedure_DateTitleFilterData',fld:'vBR_PROCEDURE_DATETITLEFILTERDATA',pic:''},{av:'AV24BR_Procedure_PXRadiotherapyTitleFilterData',fld:'vBR_PROCEDURE_PXRADIOTHERAPYTITLEFILTERDATA',pic:''},{av:'AV48BR_Procedure_RadioDateTitleFilterData',fld:'vBR_PROCEDURE_RADIODATETITLEFILTERDATA',pic:''},{av:'AV50BR_Procedure_RadioTimeTitleFilterData',fld:'vBR_PROCEDURE_RADIOTIMETITLEFILTERDATA',pic:''},{av:'edtBR_ProcedureID_Titleformat',ctrl:'BR_PROCEDUREID',prop:'Titleformat'},{av:'edtBR_ProcedureID_Title',ctrl:'BR_PROCEDUREID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Procedure_PXID_Titleformat',ctrl:'BR_PROCEDURE_PXID',prop:'Titleformat'},{av:'edtBR_Procedure_PXID_Title',ctrl:'BR_PROCEDURE_PXID',prop:'Title'},{av:'cmbBR_Procedure_PXSurgery'},{av:'edtBR_Procedure_Date_Titleformat',ctrl:'BR_PROCEDURE_DATE',prop:'Titleformat'},{av:'edtBR_Procedure_Date_Title',ctrl:'BR_PROCEDURE_DATE',prop:'Title'},{av:'cmbBR_Procedure_PXRadiotherapy'},{av:'edtBR_Procedure_RadioDate_Titleformat',ctrl:'BR_PROCEDURE_RADIODATE',prop:'Titleformat'},{av:'edtBR_Procedure_RadioDate_Title',ctrl:'BR_PROCEDURE_RADIODATE',prop:'Title'},{av:'edtBR_Procedure_RadioTime_Titleformat',ctrl:'BR_PROCEDURE_RADIOTIME',prop:'Titleformat'},{av:'edtBR_Procedure_RadioTime_Title',ctrl:'BR_PROCEDURE_RADIOTIME',prop:'Title'},{av:'AV40GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV41GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV42GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_PROCEDURE_DATE.ONOPTIONCLICKED","{handler:'E183P2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_ProcedureIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Procedure_PXIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXSURGERYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_BR_Procedure_DateTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_DATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXRADIOTHERAPYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_Procedure_RadioDateTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIODATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV51ddo_BR_Procedure_RadioTimeTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIOTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_procedure_date_Activeeventkey',ctrl:'DDO_BR_PROCEDURE_DATE',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_PROCEDURE_DATE.ONOPTIONCLICKED",",oparms:[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_procedure_date_Sortedstatus',ctrl:'DDO_BR_PROCEDURE_DATE',prop:'SortedStatus'},{av:'AV12BR_ProcedureIDTitleFilterData',fld:'vBR_PROCEDUREIDTITLEFILTERDATA',pic:''},{av:'AV14BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV16BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV18BR_Procedure_PXIDTitleFilterData',fld:'vBR_PROCEDURE_PXIDTITLEFILTERDATA',pic:''},{av:'AV20BR_Procedure_PXSurgeryTitleFilterData',fld:'vBR_PROCEDURE_PXSURGERYTITLEFILTERDATA',pic:''},{av:'AV44BR_Procedure_DateTitleFilterData',fld:'vBR_PROCEDURE_DATETITLEFILTERDATA',pic:''},{av:'AV24BR_Procedure_PXRadiotherapyTitleFilterData',fld:'vBR_PROCEDURE_PXRADIOTHERAPYTITLEFILTERDATA',pic:''},{av:'AV48BR_Procedure_RadioDateTitleFilterData',fld:'vBR_PROCEDURE_RADIODATETITLEFILTERDATA',pic:''},{av:'AV50BR_Procedure_RadioTimeTitleFilterData',fld:'vBR_PROCEDURE_RADIOTIMETITLEFILTERDATA',pic:''},{av:'edtBR_ProcedureID_Titleformat',ctrl:'BR_PROCEDUREID',prop:'Titleformat'},{av:'edtBR_ProcedureID_Title',ctrl:'BR_PROCEDUREID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Procedure_PXID_Titleformat',ctrl:'BR_PROCEDURE_PXID',prop:'Titleformat'},{av:'edtBR_Procedure_PXID_Title',ctrl:'BR_PROCEDURE_PXID',prop:'Title'},{av:'cmbBR_Procedure_PXSurgery'},{av:'edtBR_Procedure_Date_Titleformat',ctrl:'BR_PROCEDURE_DATE',prop:'Titleformat'},{av:'edtBR_Procedure_Date_Title',ctrl:'BR_PROCEDURE_DATE',prop:'Title'},{av:'cmbBR_Procedure_PXRadiotherapy'},{av:'edtBR_Procedure_RadioDate_Titleformat',ctrl:'BR_PROCEDURE_RADIODATE',prop:'Titleformat'},{av:'edtBR_Procedure_RadioDate_Title',ctrl:'BR_PROCEDURE_RADIODATE',prop:'Title'},{av:'edtBR_Procedure_RadioTime_Titleformat',ctrl:'BR_PROCEDURE_RADIOTIME',prop:'Titleformat'},{av:'edtBR_Procedure_RadioTime_Title',ctrl:'BR_PROCEDURE_RADIOTIME',prop:'Title'},{av:'AV40GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV41GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV42GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_PROCEDURE_PXRADIOTHERAPY.ONOPTIONCLICKED","{handler:'E193P2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_ProcedureIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Procedure_PXIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXSURGERYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_BR_Procedure_DateTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_DATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXRADIOTHERAPYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_Procedure_RadioDateTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIODATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV51ddo_BR_Procedure_RadioTimeTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIOTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_procedure_pxradiotherapy_Activeeventkey',ctrl:'DDO_BR_PROCEDURE_PXRADIOTHERAPY',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_PROCEDURE_PXRADIOTHERAPY.ONOPTIONCLICKED",",oparms:[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_procedure_pxradiotherapy_Sortedstatus',ctrl:'DDO_BR_PROCEDURE_PXRADIOTHERAPY',prop:'SortedStatus'},{av:'AV12BR_ProcedureIDTitleFilterData',fld:'vBR_PROCEDUREIDTITLEFILTERDATA',pic:''},{av:'AV14BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV16BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV18BR_Procedure_PXIDTitleFilterData',fld:'vBR_PROCEDURE_PXIDTITLEFILTERDATA',pic:''},{av:'AV20BR_Procedure_PXSurgeryTitleFilterData',fld:'vBR_PROCEDURE_PXSURGERYTITLEFILTERDATA',pic:''},{av:'AV44BR_Procedure_DateTitleFilterData',fld:'vBR_PROCEDURE_DATETITLEFILTERDATA',pic:''},{av:'AV24BR_Procedure_PXRadiotherapyTitleFilterData',fld:'vBR_PROCEDURE_PXRADIOTHERAPYTITLEFILTERDATA',pic:''},{av:'AV48BR_Procedure_RadioDateTitleFilterData',fld:'vBR_PROCEDURE_RADIODATETITLEFILTERDATA',pic:''},{av:'AV50BR_Procedure_RadioTimeTitleFilterData',fld:'vBR_PROCEDURE_RADIOTIMETITLEFILTERDATA',pic:''},{av:'edtBR_ProcedureID_Titleformat',ctrl:'BR_PROCEDUREID',prop:'Titleformat'},{av:'edtBR_ProcedureID_Title',ctrl:'BR_PROCEDUREID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Procedure_PXID_Titleformat',ctrl:'BR_PROCEDURE_PXID',prop:'Titleformat'},{av:'edtBR_Procedure_PXID_Title',ctrl:'BR_PROCEDURE_PXID',prop:'Title'},{av:'cmbBR_Procedure_PXSurgery'},{av:'edtBR_Procedure_Date_Titleformat',ctrl:'BR_PROCEDURE_DATE',prop:'Titleformat'},{av:'edtBR_Procedure_Date_Title',ctrl:'BR_PROCEDURE_DATE',prop:'Title'},{av:'cmbBR_Procedure_PXRadiotherapy'},{av:'edtBR_Procedure_RadioDate_Titleformat',ctrl:'BR_PROCEDURE_RADIODATE',prop:'Titleformat'},{av:'edtBR_Procedure_RadioDate_Title',ctrl:'BR_PROCEDURE_RADIODATE',prop:'Title'},{av:'edtBR_Procedure_RadioTime_Titleformat',ctrl:'BR_PROCEDURE_RADIOTIME',prop:'Titleformat'},{av:'edtBR_Procedure_RadioTime_Title',ctrl:'BR_PROCEDURE_RADIOTIME',prop:'Title'},{av:'AV40GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV41GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV42GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_PROCEDURE_RADIODATE.ONOPTIONCLICKED","{handler:'E203P2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_ProcedureIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Procedure_PXIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXSURGERYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_BR_Procedure_DateTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_DATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXRADIOTHERAPYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_Procedure_RadioDateTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIODATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV51ddo_BR_Procedure_RadioTimeTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIOTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_procedure_radiodate_Activeeventkey',ctrl:'DDO_BR_PROCEDURE_RADIODATE',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_PROCEDURE_RADIODATE.ONOPTIONCLICKED",",oparms:[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_procedure_radiodate_Sortedstatus',ctrl:'DDO_BR_PROCEDURE_RADIODATE',prop:'SortedStatus'},{av:'AV12BR_ProcedureIDTitleFilterData',fld:'vBR_PROCEDUREIDTITLEFILTERDATA',pic:''},{av:'AV14BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV16BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV18BR_Procedure_PXIDTitleFilterData',fld:'vBR_PROCEDURE_PXIDTITLEFILTERDATA',pic:''},{av:'AV20BR_Procedure_PXSurgeryTitleFilterData',fld:'vBR_PROCEDURE_PXSURGERYTITLEFILTERDATA',pic:''},{av:'AV44BR_Procedure_DateTitleFilterData',fld:'vBR_PROCEDURE_DATETITLEFILTERDATA',pic:''},{av:'AV24BR_Procedure_PXRadiotherapyTitleFilterData',fld:'vBR_PROCEDURE_PXRADIOTHERAPYTITLEFILTERDATA',pic:''},{av:'AV48BR_Procedure_RadioDateTitleFilterData',fld:'vBR_PROCEDURE_RADIODATETITLEFILTERDATA',pic:''},{av:'AV50BR_Procedure_RadioTimeTitleFilterData',fld:'vBR_PROCEDURE_RADIOTIMETITLEFILTERDATA',pic:''},{av:'edtBR_ProcedureID_Titleformat',ctrl:'BR_PROCEDUREID',prop:'Titleformat'},{av:'edtBR_ProcedureID_Title',ctrl:'BR_PROCEDUREID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Procedure_PXID_Titleformat',ctrl:'BR_PROCEDURE_PXID',prop:'Titleformat'},{av:'edtBR_Procedure_PXID_Title',ctrl:'BR_PROCEDURE_PXID',prop:'Title'},{av:'cmbBR_Procedure_PXSurgery'},{av:'edtBR_Procedure_Date_Titleformat',ctrl:'BR_PROCEDURE_DATE',prop:'Titleformat'},{av:'edtBR_Procedure_Date_Title',ctrl:'BR_PROCEDURE_DATE',prop:'Title'},{av:'cmbBR_Procedure_PXRadiotherapy'},{av:'edtBR_Procedure_RadioDate_Titleformat',ctrl:'BR_PROCEDURE_RADIODATE',prop:'Titleformat'},{av:'edtBR_Procedure_RadioDate_Title',ctrl:'BR_PROCEDURE_RADIODATE',prop:'Title'},{av:'edtBR_Procedure_RadioTime_Titleformat',ctrl:'BR_PROCEDURE_RADIOTIME',prop:'Titleformat'},{av:'edtBR_Procedure_RadioTime_Title',ctrl:'BR_PROCEDURE_RADIOTIME',prop:'Title'},{av:'AV40GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV41GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV42GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_PROCEDURE_RADIOTIME.ONOPTIONCLICKED","{handler:'E213P2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV13ddo_BR_ProcedureIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV15ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV17ddo_BR_Information_PatientNoTitleControlIdToReplace',fld:'vDDO_BR_INFORMATION_PATIENTNOTITLECONTROLIDTOREPLACE',pic:''},{av:'AV19ddo_BR_Procedure_PXIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV21ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXSURGERYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV45ddo_BR_Procedure_DateTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_DATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV25ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXRADIOTHERAPYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV49ddo_BR_Procedure_RadioDateTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIODATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV51ddo_BR_Procedure_RadioTimeTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIOTIMETITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_procedure_radiotime_Activeeventkey',ctrl:'DDO_BR_PROCEDURE_RADIOTIME',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_PROCEDURE_RADIOTIME.ONOPTIONCLICKED",",oparms:[{av:'AV10OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV11OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_procedure_radiotime_Sortedstatus',ctrl:'DDO_BR_PROCEDURE_RADIOTIME',prop:'SortedStatus'},{av:'AV12BR_ProcedureIDTitleFilterData',fld:'vBR_PROCEDUREIDTITLEFILTERDATA',pic:''},{av:'AV14BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV16BR_Information_PatientNoTitleFilterData',fld:'vBR_INFORMATION_PATIENTNOTITLEFILTERDATA',pic:''},{av:'AV18BR_Procedure_PXIDTitleFilterData',fld:'vBR_PROCEDURE_PXIDTITLEFILTERDATA',pic:''},{av:'AV20BR_Procedure_PXSurgeryTitleFilterData',fld:'vBR_PROCEDURE_PXSURGERYTITLEFILTERDATA',pic:''},{av:'AV44BR_Procedure_DateTitleFilterData',fld:'vBR_PROCEDURE_DATETITLEFILTERDATA',pic:''},{av:'AV24BR_Procedure_PXRadiotherapyTitleFilterData',fld:'vBR_PROCEDURE_PXRADIOTHERAPYTITLEFILTERDATA',pic:''},{av:'AV48BR_Procedure_RadioDateTitleFilterData',fld:'vBR_PROCEDURE_RADIODATETITLEFILTERDATA',pic:''},{av:'AV50BR_Procedure_RadioTimeTitleFilterData',fld:'vBR_PROCEDURE_RADIOTIMETITLEFILTERDATA',pic:''},{av:'edtBR_ProcedureID_Titleformat',ctrl:'BR_PROCEDUREID',prop:'Titleformat'},{av:'edtBR_ProcedureID_Title',ctrl:'BR_PROCEDUREID',prop:'Title'},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Information_PatientNo_Titleformat',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Titleformat'},{av:'edtBR_Information_PatientNo_Title',ctrl:'BR_INFORMATION_PATIENTNO',prop:'Title'},{av:'edtBR_Procedure_PXID_Titleformat',ctrl:'BR_PROCEDURE_PXID',prop:'Titleformat'},{av:'edtBR_Procedure_PXID_Title',ctrl:'BR_PROCEDURE_PXID',prop:'Title'},{av:'cmbBR_Procedure_PXSurgery'},{av:'edtBR_Procedure_Date_Titleformat',ctrl:'BR_PROCEDURE_DATE',prop:'Titleformat'},{av:'edtBR_Procedure_Date_Title',ctrl:'BR_PROCEDURE_DATE',prop:'Title'},{av:'cmbBR_Procedure_PXRadiotherapy'},{av:'edtBR_Procedure_RadioDate_Titleformat',ctrl:'BR_PROCEDURE_RADIODATE',prop:'Titleformat'},{av:'edtBR_Procedure_RadioDate_Title',ctrl:'BR_PROCEDURE_RADIODATE',prop:'Title'},{av:'edtBR_Procedure_RadioTime_Titleformat',ctrl:'BR_PROCEDURE_RADIOTIME',prop:'Titleformat'},{av:'edtBR_Procedure_RadioTime_Title',ctrl:'BR_PROCEDURE_RADIOTIME',prop:'Title'},{av:'AV40GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV41GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV42GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("GRID.LOAD","{handler:'E243P2',iparms:[]");
         setEventMetadata("GRID.LOAD",",oparms:[{av:'AV43Select',fld:'vSELECT',pic:''},{av:'edtavSelect_Tooltiptext',ctrl:'vSELECT',prop:'Tooltiptext'}]}");
         setEventMetadata("ENTER","{handler:'E253P2',iparms:[{av:'A139BR_ProcedureID',fld:'BR_PROCEDUREID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[{av:'AV8InOutBR_ProcedureID',fld:'vINOUTBR_PROCEDUREID',pic:'ZZZZZZZZZZZZZZZZZZ'}]}");
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
         Ddo_br_procedureid_Activeeventkey = "";
         Ddo_br_encounterid_Activeeventkey = "";
         Ddo_br_information_patientno_Activeeventkey = "";
         Ddo_br_procedure_pxid_Activeeventkey = "";
         Ddo_br_procedure_pxsurgery_Activeeventkey = "";
         Ddo_br_procedure_date_Activeeventkey = "";
         Ddo_br_procedure_pxradiotherapy_Activeeventkey = "";
         Ddo_br_procedure_radiodate_Activeeventkey = "";
         Ddo_br_procedure_radiotime_Activeeventkey = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV13ddo_BR_ProcedureIDTitleControlIdToReplace = "";
         AV15ddo_BR_EncounterIDTitleControlIdToReplace = "";
         AV17ddo_BR_Information_PatientNoTitleControlIdToReplace = "";
         AV19ddo_BR_Procedure_PXIDTitleControlIdToReplace = "";
         AV21ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace = "";
         AV45ddo_BR_Procedure_DateTitleControlIdToReplace = "";
         AV25ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace = "";
         AV49ddo_BR_Procedure_RadioDateTitleControlIdToReplace = "";
         AV51ddo_BR_Procedure_RadioTimeTitleControlIdToReplace = "";
         GXKey = "";
         AV54Pgmname = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         AV38DDO_TitleSettingsIcons = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV12BR_ProcedureIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV14BR_EncounterIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV16BR_Information_PatientNoTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV18BR_Procedure_PXIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV20BR_Procedure_PXSurgeryTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV44BR_Procedure_DateTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV24BR_Procedure_PXRadiotherapyTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV48BR_Procedure_RadioDateTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV50BR_Procedure_RadioTimeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         Ddo_br_procedureid_Sortedstatus = "";
         Ddo_br_encounterid_Sortedstatus = "";
         Ddo_br_information_patientno_Sortedstatus = "";
         Ddo_br_procedure_pxid_Sortedstatus = "";
         Ddo_br_procedure_pxsurgery_Sortedstatus = "";
         Ddo_br_procedure_date_Sortedstatus = "";
         Ddo_br_procedure_pxradiotherapy_Sortedstatus = "";
         Ddo_br_procedure_radiodate_Sortedstatus = "";
         Ddo_br_procedure_radiotime_Sortedstatus = "";
         GX_FocusControl = "";
         sPrefix = "";
         GridContainer = new GXWebGrid( context);
         sStyleString = "";
         subGrid_Linesclass = "";
         GridColumn = new GXWebColumn();
         AV43Select = "";
         A36BR_Information_PatientNo = "";
         A141BR_Procedure_PXSurgery = "";
         A266BR_Procedure_Date = DateTime.MinValue;
         A143BR_Procedure_PXRadiotherapy = "";
         A268BR_Procedure_RadioDate = DateTime.MinValue;
         ucGridpaginationbar = new GXUserControl();
         ucDdo_br_procedureid = new GXUserControl();
         TempTags = "";
         ClassString = "";
         StyleString = "";
         ucDdo_br_encounterid = new GXUserControl();
         ucDdo_br_information_patientno = new GXUserControl();
         ucDdo_br_procedure_pxid = new GXUserControl();
         ucDdo_br_procedure_pxsurgery = new GXUserControl();
         ucDdo_br_procedure_date = new GXUserControl();
         ucDdo_br_procedure_pxradiotherapy = new GXUserControl();
         ucDdo_br_procedure_radiodate = new GXUserControl();
         ucDdo_br_procedure_radiotime = new GXUserControl();
         ucWorkwithplusutilities1 = new GXUserControl();
         Form = new GXWebForm();
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV55Select_GXI = "";
         scmdbuf = "";
         H003P2_A85BR_Information_ID = new long[1] ;
         H003P2_n85BR_Information_ID = new bool[] {false} ;
         H003P2_A269BR_Procedure_RadioTime = new decimal[1] ;
         H003P2_n269BR_Procedure_RadioTime = new bool[] {false} ;
         H003P2_A268BR_Procedure_RadioDate = new DateTime[] {DateTime.MinValue} ;
         H003P2_n268BR_Procedure_RadioDate = new bool[] {false} ;
         H003P2_A143BR_Procedure_PXRadiotherapy = new String[] {""} ;
         H003P2_n143BR_Procedure_PXRadiotherapy = new bool[] {false} ;
         H003P2_A266BR_Procedure_Date = new DateTime[] {DateTime.MinValue} ;
         H003P2_n266BR_Procedure_Date = new bool[] {false} ;
         H003P2_A141BR_Procedure_PXSurgery = new String[] {""} ;
         H003P2_n141BR_Procedure_PXSurgery = new bool[] {false} ;
         H003P2_A140BR_Procedure_PXID = new long[1] ;
         H003P2_n140BR_Procedure_PXID = new bool[] {false} ;
         H003P2_A36BR_Information_PatientNo = new String[] {""} ;
         H003P2_n36BR_Information_PatientNo = new bool[] {false} ;
         H003P2_A19BR_EncounterID = new long[1] ;
         H003P2_n19BR_EncounterID = new bool[] {false} ;
         H003P2_A139BR_ProcedureID = new long[1] ;
         H003P3_AGRID_nRecordCount = new long[1] ;
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV6WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         GridRow = new GXWebRow();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sImgUrl = "";
         ROClassString = "";
         GXCCtl = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_procedureprompt__default(),
            new Object[][] {
                new Object[] {
               H003P2_A85BR_Information_ID, H003P2_n85BR_Information_ID, H003P2_A269BR_Procedure_RadioTime, H003P2_n269BR_Procedure_RadioTime, H003P2_A268BR_Procedure_RadioDate, H003P2_n268BR_Procedure_RadioDate, H003P2_A143BR_Procedure_PXRadiotherapy, H003P2_n143BR_Procedure_PXRadiotherapy, H003P2_A266BR_Procedure_Date, H003P2_n266BR_Procedure_Date,
               H003P2_A141BR_Procedure_PXSurgery, H003P2_n141BR_Procedure_PXSurgery, H003P2_A140BR_Procedure_PXID, H003P2_n140BR_Procedure_PXID, H003P2_A36BR_Information_PatientNo, H003P2_n36BR_Information_PatientNo, H003P2_A19BR_EncounterID, H003P2_n19BR_EncounterID, H003P2_A139BR_ProcedureID
               }
               , new Object[] {
               H003P3_AGRID_nRecordCount
               }
            }
         );
         AV54Pgmname = "BR_ProcedurePrompt";
         /* GeneXus formulas. */
         AV54Pgmname = "BR_ProcedurePrompt";
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
      private short edtBR_ProcedureID_Titleformat ;
      private short edtBR_EncounterID_Titleformat ;
      private short edtBR_Information_PatientNo_Titleformat ;
      private short edtBR_Procedure_PXID_Titleformat ;
      private short cmbBR_Procedure_PXSurgery_Titleformat ;
      private short edtBR_Procedure_Date_Titleformat ;
      private short cmbBR_Procedure_PXRadiotherapy_Titleformat ;
      private short edtBR_Procedure_RadioDate_Titleformat ;
      private short edtBR_Procedure_RadioTime_Titleformat ;
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
      private int edtavDdo_br_procedureidtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_encounteridtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_information_patientnotitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_procedure_pxidtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_procedure_pxsurgerytitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_procedure_datetitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_procedure_pxradiotherapytitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_procedure_radiodatetitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_procedure_radiotimetitlecontrolidtoreplace_Visible ;
      private int edtavOrderedby_Visible ;
      private int edtavOrdereddsc_Visible ;
      private int subGrid_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int AV39PageToGo ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private int edtavSelect_Enabled ;
      private int edtavSelect_Visible ;
      private long AV8InOutBR_ProcedureID ;
      private long wcpOAV8InOutBR_ProcedureID ;
      private long GRID_nFirstRecordOnPage ;
      private long AV40GridCurrentPage ;
      private long AV42GridRecordCount ;
      private long AV41GridPageSize ;
      private long A139BR_ProcedureID ;
      private long A19BR_EncounterID ;
      private long A140BR_Procedure_PXID ;
      private long GRID_nCurrentRecord ;
      private long A85BR_Information_ID ;
      private long GRID_nRecordCount ;
      private decimal A269BR_Procedure_RadioTime ;
      private String Gridpaginationbar_Selectedpage ;
      private String Ddo_br_procedureid_Activeeventkey ;
      private String Ddo_br_encounterid_Activeeventkey ;
      private String Ddo_br_information_patientno_Activeeventkey ;
      private String Ddo_br_procedure_pxid_Activeeventkey ;
      private String Ddo_br_procedure_pxsurgery_Activeeventkey ;
      private String Ddo_br_procedure_date_Activeeventkey ;
      private String Ddo_br_procedure_pxradiotherapy_Activeeventkey ;
      private String Ddo_br_procedure_radiodate_Activeeventkey ;
      private String Ddo_br_procedure_radiotime_Activeeventkey ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_12_idx="0001" ;
      private String GXKey ;
      private String AV54Pgmname ;
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
      private String Ddo_br_procedureid_Caption ;
      private String Ddo_br_procedureid_Tooltip ;
      private String Ddo_br_procedureid_Cls ;
      private String Ddo_br_procedureid_Dropdownoptionstype ;
      private String Ddo_br_procedureid_Titlecontrolidtoreplace ;
      private String Ddo_br_procedureid_Sortedstatus ;
      private String Ddo_br_procedureid_Sortasc ;
      private String Ddo_br_procedureid_Sortdsc ;
      private String Ddo_br_procedureid_Searchbuttontext ;
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
      private String Ddo_br_procedure_pxid_Caption ;
      private String Ddo_br_procedure_pxid_Tooltip ;
      private String Ddo_br_procedure_pxid_Cls ;
      private String Ddo_br_procedure_pxid_Dropdownoptionstype ;
      private String Ddo_br_procedure_pxid_Titlecontrolidtoreplace ;
      private String Ddo_br_procedure_pxid_Sortedstatus ;
      private String Ddo_br_procedure_pxid_Sortasc ;
      private String Ddo_br_procedure_pxid_Sortdsc ;
      private String Ddo_br_procedure_pxid_Searchbuttontext ;
      private String Ddo_br_procedure_pxsurgery_Caption ;
      private String Ddo_br_procedure_pxsurgery_Tooltip ;
      private String Ddo_br_procedure_pxsurgery_Cls ;
      private String Ddo_br_procedure_pxsurgery_Dropdownoptionstype ;
      private String Ddo_br_procedure_pxsurgery_Titlecontrolidtoreplace ;
      private String Ddo_br_procedure_pxsurgery_Sortedstatus ;
      private String Ddo_br_procedure_pxsurgery_Sortasc ;
      private String Ddo_br_procedure_pxsurgery_Sortdsc ;
      private String Ddo_br_procedure_pxsurgery_Searchbuttontext ;
      private String Ddo_br_procedure_date_Caption ;
      private String Ddo_br_procedure_date_Tooltip ;
      private String Ddo_br_procedure_date_Cls ;
      private String Ddo_br_procedure_date_Dropdownoptionstype ;
      private String Ddo_br_procedure_date_Titlecontrolidtoreplace ;
      private String Ddo_br_procedure_date_Sortedstatus ;
      private String Ddo_br_procedure_date_Sortasc ;
      private String Ddo_br_procedure_date_Sortdsc ;
      private String Ddo_br_procedure_date_Searchbuttontext ;
      private String Ddo_br_procedure_pxradiotherapy_Caption ;
      private String Ddo_br_procedure_pxradiotherapy_Tooltip ;
      private String Ddo_br_procedure_pxradiotherapy_Cls ;
      private String Ddo_br_procedure_pxradiotherapy_Dropdownoptionstype ;
      private String Ddo_br_procedure_pxradiotherapy_Titlecontrolidtoreplace ;
      private String Ddo_br_procedure_pxradiotherapy_Sortedstatus ;
      private String Ddo_br_procedure_pxradiotherapy_Sortasc ;
      private String Ddo_br_procedure_pxradiotherapy_Sortdsc ;
      private String Ddo_br_procedure_pxradiotherapy_Searchbuttontext ;
      private String Ddo_br_procedure_radiodate_Caption ;
      private String Ddo_br_procedure_radiodate_Tooltip ;
      private String Ddo_br_procedure_radiodate_Cls ;
      private String Ddo_br_procedure_radiodate_Dropdownoptionstype ;
      private String Ddo_br_procedure_radiodate_Titlecontrolidtoreplace ;
      private String Ddo_br_procedure_radiodate_Sortedstatus ;
      private String Ddo_br_procedure_radiodate_Sortasc ;
      private String Ddo_br_procedure_radiodate_Sortdsc ;
      private String Ddo_br_procedure_radiodate_Searchbuttontext ;
      private String Ddo_br_procedure_radiotime_Caption ;
      private String Ddo_br_procedure_radiotime_Tooltip ;
      private String Ddo_br_procedure_radiotime_Cls ;
      private String Ddo_br_procedure_radiotime_Dropdownoptionstype ;
      private String Ddo_br_procedure_radiotime_Titlecontrolidtoreplace ;
      private String Ddo_br_procedure_radiotime_Sortedstatus ;
      private String Ddo_br_procedure_radiotime_Sortasc ;
      private String Ddo_br_procedure_radiotime_Sortdsc ;
      private String Ddo_br_procedure_radiotime_Searchbuttontext ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divLayoutmaintable_Internalname ;
      private String divTablemain_Internalname ;
      private String divGridtablewithpaginationbar_Internalname ;
      private String sStyleString ;
      private String subGrid_Internalname ;
      private String subGrid_Class ;
      private String subGrid_Linesclass ;
      private String edtBR_ProcedureID_Title ;
      private String edtBR_EncounterID_Title ;
      private String edtBR_Information_PatientNo_Title ;
      private String edtBR_Procedure_PXID_Title ;
      private String edtBR_Procedure_Date_Title ;
      private String edtBR_Procedure_RadioDate_Title ;
      private String edtBR_Procedure_RadioTime_Title ;
      private String subGrid_Header ;
      private String edtavSelect_Tooltiptext ;
      private String divHtml_gridpaginationbar_Internalname ;
      private String Gridpaginationbar_Internalname ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String Ddo_br_procedureid_Internalname ;
      private String TempTags ;
      private String ClassString ;
      private String StyleString ;
      private String edtavDdo_br_procedureidtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_encounterid_Internalname ;
      private String edtavDdo_br_encounteridtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_information_patientno_Internalname ;
      private String edtavDdo_br_information_patientnotitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_procedure_pxid_Internalname ;
      private String edtavDdo_br_procedure_pxidtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_procedure_pxsurgery_Internalname ;
      private String edtavDdo_br_procedure_pxsurgerytitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_procedure_date_Internalname ;
      private String edtavDdo_br_procedure_datetitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_procedure_pxradiotherapy_Internalname ;
      private String edtavDdo_br_procedure_pxradiotherapytitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_procedure_radiodate_Internalname ;
      private String edtavDdo_br_procedure_radiodatetitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_procedure_radiotime_Internalname ;
      private String edtavDdo_br_procedure_radiotimetitlecontrolidtoreplace_Internalname ;
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
      private String edtBR_ProcedureID_Internalname ;
      private String edtBR_EncounterID_Internalname ;
      private String edtBR_Information_PatientNo_Internalname ;
      private String edtBR_Procedure_PXID_Internalname ;
      private String cmbBR_Procedure_PXSurgery_Internalname ;
      private String edtBR_Procedure_Date_Internalname ;
      private String cmbBR_Procedure_PXRadiotherapy_Internalname ;
      private String edtBR_Procedure_RadioDate_Internalname ;
      private String edtBR_Procedure_RadioTime_Internalname ;
      private String scmdbuf ;
      private String sGXsfl_12_fel_idx="0001" ;
      private String sImgUrl ;
      private String edtavSelect_Jsonclick ;
      private String ROClassString ;
      private String edtBR_ProcedureID_Jsonclick ;
      private String edtBR_EncounterID_Jsonclick ;
      private String edtBR_Information_PatientNo_Jsonclick ;
      private String edtBR_Procedure_PXID_Jsonclick ;
      private String GXCCtl ;
      private String cmbBR_Procedure_PXSurgery_Jsonclick ;
      private String edtBR_Procedure_Date_Jsonclick ;
      private String cmbBR_Procedure_PXRadiotherapy_Jsonclick ;
      private String edtBR_Procedure_RadioDate_Jsonclick ;
      private String edtBR_Procedure_RadioTime_Jsonclick ;
      private DateTime A266BR_Procedure_Date ;
      private DateTime A268BR_Procedure_RadioDate ;
      private bool entryPointCalled ;
      private bool AV11OrderedDsc ;
      private bool toggleJsOutput ;
      private bool Gridpaginationbar_Showfirst ;
      private bool Gridpaginationbar_Showprevious ;
      private bool Gridpaginationbar_Shownext ;
      private bool Gridpaginationbar_Showlast ;
      private bool Gridpaginationbar_Rowsperpageselector ;
      private bool Ddo_br_procedureid_Includesortasc ;
      private bool Ddo_br_procedureid_Includesortdsc ;
      private bool Ddo_br_procedureid_Includefilter ;
      private bool Ddo_br_procedureid_Includedatalist ;
      private bool Ddo_br_encounterid_Includesortasc ;
      private bool Ddo_br_encounterid_Includesortdsc ;
      private bool Ddo_br_encounterid_Includefilter ;
      private bool Ddo_br_encounterid_Includedatalist ;
      private bool Ddo_br_information_patientno_Includesortasc ;
      private bool Ddo_br_information_patientno_Includesortdsc ;
      private bool Ddo_br_information_patientno_Includefilter ;
      private bool Ddo_br_information_patientno_Includedatalist ;
      private bool Ddo_br_procedure_pxid_Includesortasc ;
      private bool Ddo_br_procedure_pxid_Includesortdsc ;
      private bool Ddo_br_procedure_pxid_Includefilter ;
      private bool Ddo_br_procedure_pxid_Includedatalist ;
      private bool Ddo_br_procedure_pxsurgery_Includesortasc ;
      private bool Ddo_br_procedure_pxsurgery_Includesortdsc ;
      private bool Ddo_br_procedure_pxsurgery_Includefilter ;
      private bool Ddo_br_procedure_pxsurgery_Includedatalist ;
      private bool Ddo_br_procedure_date_Includesortasc ;
      private bool Ddo_br_procedure_date_Includesortdsc ;
      private bool Ddo_br_procedure_date_Includefilter ;
      private bool Ddo_br_procedure_date_Includedatalist ;
      private bool Ddo_br_procedure_pxradiotherapy_Includesortasc ;
      private bool Ddo_br_procedure_pxradiotherapy_Includesortdsc ;
      private bool Ddo_br_procedure_pxradiotherapy_Includefilter ;
      private bool Ddo_br_procedure_pxradiotherapy_Includedatalist ;
      private bool Ddo_br_procedure_radiodate_Includesortasc ;
      private bool Ddo_br_procedure_radiodate_Includesortdsc ;
      private bool Ddo_br_procedure_radiodate_Includefilter ;
      private bool Ddo_br_procedure_radiodate_Includedatalist ;
      private bool Ddo_br_procedure_radiotime_Includesortasc ;
      private bool Ddo_br_procedure_radiotime_Includesortdsc ;
      private bool Ddo_br_procedure_radiotime_Includefilter ;
      private bool Ddo_br_procedure_radiotime_Includedatalist ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_12_Refreshing=false ;
      private bool n19BR_EncounterID ;
      private bool n36BR_Information_PatientNo ;
      private bool n140BR_Procedure_PXID ;
      private bool n141BR_Procedure_PXSurgery ;
      private bool n266BR_Procedure_Date ;
      private bool n143BR_Procedure_PXRadiotherapy ;
      private bool n268BR_Procedure_RadioDate ;
      private bool n269BR_Procedure_RadioTime ;
      private bool gxdyncontrolsrefreshing ;
      private bool n85BR_Information_ID ;
      private bool returnInSub ;
      private bool AV5IsAuthorized ;
      private bool GXt_boolean1 ;
      private bool gx_refresh_fired ;
      private bool AV43Select_IsBlob ;
      private String AV13ddo_BR_ProcedureIDTitleControlIdToReplace ;
      private String AV15ddo_BR_EncounterIDTitleControlIdToReplace ;
      private String AV17ddo_BR_Information_PatientNoTitleControlIdToReplace ;
      private String AV19ddo_BR_Procedure_PXIDTitleControlIdToReplace ;
      private String AV21ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace ;
      private String AV45ddo_BR_Procedure_DateTitleControlIdToReplace ;
      private String AV25ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace ;
      private String AV49ddo_BR_Procedure_RadioDateTitleControlIdToReplace ;
      private String AV51ddo_BR_Procedure_RadioTimeTitleControlIdToReplace ;
      private String A36BR_Information_PatientNo ;
      private String A141BR_Procedure_PXSurgery ;
      private String A143BR_Procedure_PXRadiotherapy ;
      private String AV55Select_GXI ;
      private String AV43Select ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private GXUserControl ucGridpaginationbar ;
      private GXUserControl ucDdo_br_procedureid ;
      private GXUserControl ucDdo_br_encounterid ;
      private GXUserControl ucDdo_br_information_patientno ;
      private GXUserControl ucDdo_br_procedure_pxid ;
      private GXUserControl ucDdo_br_procedure_pxsurgery ;
      private GXUserControl ucDdo_br_procedure_date ;
      private GXUserControl ucDdo_br_procedure_pxradiotherapy ;
      private GXUserControl ucDdo_br_procedure_radiodate ;
      private GXUserControl ucDdo_br_procedure_radiotime ;
      private GXUserControl ucWorkwithplusutilities1 ;
      private GXWebForm Form ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private long aP0_InOutBR_ProcedureID ;
      private GXCombobox cmbBR_Procedure_PXSurgery ;
      private GXCombobox cmbBR_Procedure_PXRadiotherapy ;
      private IDataStoreProvider pr_default ;
      private long[] H003P2_A85BR_Information_ID ;
      private bool[] H003P2_n85BR_Information_ID ;
      private decimal[] H003P2_A269BR_Procedure_RadioTime ;
      private bool[] H003P2_n269BR_Procedure_RadioTime ;
      private DateTime[] H003P2_A268BR_Procedure_RadioDate ;
      private bool[] H003P2_n268BR_Procedure_RadioDate ;
      private String[] H003P2_A143BR_Procedure_PXRadiotherapy ;
      private bool[] H003P2_n143BR_Procedure_PXRadiotherapy ;
      private DateTime[] H003P2_A266BR_Procedure_Date ;
      private bool[] H003P2_n266BR_Procedure_Date ;
      private String[] H003P2_A141BR_Procedure_PXSurgery ;
      private bool[] H003P2_n141BR_Procedure_PXSurgery ;
      private long[] H003P2_A140BR_Procedure_PXID ;
      private bool[] H003P2_n140BR_Procedure_PXID ;
      private String[] H003P2_A36BR_Information_PatientNo ;
      private bool[] H003P2_n36BR_Information_PatientNo ;
      private long[] H003P2_A19BR_EncounterID ;
      private bool[] H003P2_n19BR_EncounterID ;
      private long[] H003P2_A139BR_ProcedureID ;
      private long[] H003P3_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV12BR_ProcedureIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV14BR_EncounterIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV16BR_Information_PatientNoTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV18BR_Procedure_PXIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV20BR_Procedure_PXSurgeryTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV44BR_Procedure_DateTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV24BR_Procedure_PXRadiotherapyTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV48BR_Procedure_RadioDateTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV50BR_Procedure_RadioTimeTitleFilterData ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons AV38DDO_TitleSettingsIcons ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 ;
   }

   public class br_procedureprompt__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H003P2( IGxContext context ,
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
         sSelectString = " T2.[BR_Information_ID], T1.[BR_Procedure_RadioTime], T1.[BR_Procedure_RadioDate], T1.[BR_Procedure_PXRadiotherapy], T1.[BR_Procedure_Date], T1.[BR_Procedure_PXSurgery], T1.[BR_Procedure_PXID], T3.[BR_Information_PatientNo], T1.[BR_EncounterID], T1.[BR_ProcedureID]";
         sFromString = " FROM (([BR_Procedure] T1 WITH (NOLOCK) LEFT JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = T1.[BR_EncounterID]) LEFT JOIN [BR_Information] T3 WITH (NOLOCK) ON T3.[BR_Information_ID] = T2.[BR_Information_ID])";
         sOrderString = "";
         if ( ( AV10OrderedBy == 1 ) && ! AV11OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_ProcedureID]";
         }
         else if ( ( AV10OrderedBy == 1 ) && ( AV11OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_ProcedureID] DESC";
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
            sOrderString = sOrderString + " ORDER BY T1.[BR_Procedure_PXID]";
         }
         else if ( ( AV10OrderedBy == 4 ) && ( AV11OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Procedure_PXID] DESC";
         }
         else if ( ( AV10OrderedBy == 5 ) && ! AV11OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Procedure_PXSurgery]";
         }
         else if ( ( AV10OrderedBy == 5 ) && ( AV11OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Procedure_PXSurgery] DESC";
         }
         else if ( ( AV10OrderedBy == 6 ) && ! AV11OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Procedure_Date]";
         }
         else if ( ( AV10OrderedBy == 6 ) && ( AV11OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Procedure_Date] DESC";
         }
         else if ( ( AV10OrderedBy == 7 ) && ! AV11OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Procedure_PXRadiotherapy]";
         }
         else if ( ( AV10OrderedBy == 7 ) && ( AV11OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Procedure_PXRadiotherapy] DESC";
         }
         else if ( ( AV10OrderedBy == 8 ) && ! AV11OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Procedure_RadioDate]";
         }
         else if ( ( AV10OrderedBy == 8 ) && ( AV11OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Procedure_RadioDate] DESC";
         }
         else if ( ( AV10OrderedBy == 9 ) && ! AV11OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Procedure_RadioTime]";
         }
         else if ( ( AV10OrderedBy == 9 ) && ( AV11OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_Procedure_RadioTime] DESC";
         }
         else if ( true )
         {
            sOrderString = sOrderString + " ORDER BY T1.[BR_ProcedureID]";
         }
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object4[0] = scmdbuf;
         GXv_Object4[1] = GXv_int3;
         return GXv_Object4 ;
      }

      protected Object[] conditional_H003P3( IGxContext context ,
                                             short AV10OrderedBy ,
                                             bool AV11OrderedDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         Object[] GXv_Object5 ;
         GXv_Object5 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM (([BR_Procedure] T1 WITH (NOLOCK) LEFT JOIN [BR_Encounter] T2 WITH (NOLOCK) ON T2.[BR_EncounterID] = T1.[BR_EncounterID]) LEFT JOIN [BR_Information] T3 WITH (NOLOCK) ON T3.[BR_Information_ID] = T2.[BR_Information_ID])";
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
                     return conditional_H003P2(context, (short)dynConstraints[0] , (bool)dynConstraints[1] );
               case 1 :
                     return conditional_H003P3(context, (short)dynConstraints[0] , (bool)dynConstraints[1] );
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
          Object[] prmH003P2 ;
          prmH003P2 = new Object[] {
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH003P3 ;
          prmH003P3 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("H003P2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH003P2,11,0,true,false )
             ,new CursorDef("H003P3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH003P3,1,0,true,false )
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
                ((DateTime[]) buf[4])[0] = rslt.getGXDate(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((String[]) buf[6])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((DateTime[]) buf[8])[0] = rslt.getGXDate(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((String[]) buf[10])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(6);
                ((long[]) buf[12])[0] = rslt.getLong(7) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(7);
                ((String[]) buf[14])[0] = rslt.getVarchar(8) ;
                ((bool[]) buf[15])[0] = rslt.wasNull(8);
                ((long[]) buf[16])[0] = rslt.getLong(9) ;
                ((bool[]) buf[17])[0] = rslt.wasNull(9);
                ((long[]) buf[18])[0] = rslt.getLong(10) ;
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
