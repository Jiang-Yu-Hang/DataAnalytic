/*
               File: BR_Procedure_RadioPrompt
        Description: 选择诊疗处理化疗信息
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 12:4:35.13
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
   public class br_procedure_radioprompt : GXHttpHandler, System.Web.SessionState.IRequiresSessionState
   {
      public br_procedure_radioprompt( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public br_procedure_radioprompt( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( ref long aP0_InOutBR_Procedure_RadioID ,
                           ref String aP1_InOutBR_Procedure_Radio_Loc )
      {
         this.AV8InOutBR_Procedure_RadioID = aP0_InOutBR_Procedure_RadioID;
         this.AV9InOutBR_Procedure_Radio_Loc = aP1_InOutBR_Procedure_Radio_Loc;
         executePrivate();
         aP0_InOutBR_Procedure_RadioID=this.AV8InOutBR_Procedure_RadioID;
         aP1_InOutBR_Procedure_Radio_Loc=this.AV9InOutBR_Procedure_Radio_Loc;
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
               AV11OrderedBy = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV12OrderedDsc = StringUtil.StrToBool( GetNextPar( ));
               AV14ddo_BR_Procedure_RadioIDTitleControlIdToReplace = GetNextPar( );
               AV16ddo_BR_ProcedureIDTitleControlIdToReplace = GetNextPar( );
               AV18ddo_BR_Procedure_Radio_LocTitleControlIdToReplace = GetNextPar( );
               AV20ddo_BR_Procedure_Radio_AmountTitleControlIdToReplace = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_BR_Procedure_RadioIDTitleControlIdToReplace, AV16ddo_BR_ProcedureIDTitleControlIdToReplace, AV18ddo_BR_Procedure_Radio_LocTitleControlIdToReplace, AV20ddo_BR_Procedure_Radio_AmountTitleControlIdToReplace) ;
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
               AV8InOutBR_Procedure_RadioID = (long)(NumberUtil.Val( gxfirstwebparm, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8InOutBR_Procedure_RadioID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8InOutBR_Procedure_RadioID), 18, 0)));
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV9InOutBR_Procedure_Radio_Loc = GetNextPar( );
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9InOutBR_Procedure_Radio_Loc", AV9InOutBR_Procedure_Radio_Loc);
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
            PA6B2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV29Pgmname = "BR_Procedure_RadioPrompt";
               context.Gx_err = 0;
               WS6B2( ) ;
               if ( ! isAjaxCallMode( ) )
               {
                  WE6B2( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?20202271243522", false);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_procedure_radioprompt.aspx") + "?" + UrlEncode("" +AV8InOutBR_Procedure_RadioID) + "," + UrlEncode(StringUtil.RTrim(AV9InOutBR_Procedure_Radio_Loc))+"\">") ;
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
         GxWebStd.gx_hidden_field( context, "vGRIDCURRENTPAGE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV23GridCurrentPage), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDRECORDCOUNT", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV25GridRecordCount), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDPAGESIZE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV24GridPageSize), 10, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vDDO_TITLESETTINGSICONS", AV21DDO_TitleSettingsIcons);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vDDO_TITLESETTINGSICONS", AV21DDO_TitleSettingsIcons);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_PROCEDURE_RADIOIDTITLEFILTERDATA", AV13BR_Procedure_RadioIDTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_PROCEDURE_RADIOIDTITLEFILTERDATA", AV13BR_Procedure_RadioIDTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_PROCEDUREIDTITLEFILTERDATA", AV15BR_ProcedureIDTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_PROCEDUREIDTITLEFILTERDATA", AV15BR_ProcedureIDTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_PROCEDURE_RADIO_LOCTITLEFILTERDATA", AV17BR_Procedure_Radio_LocTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_PROCEDURE_RADIO_LOCTITLEFILTERDATA", AV17BR_Procedure_Radio_LocTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_PROCEDURE_RADIO_AMOUNTTITLEFILTERDATA", AV19BR_Procedure_Radio_AmountTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_PROCEDURE_RADIO_AMOUNTTITLEFILTERDATA", AV19BR_Procedure_Radio_AmountTitleFilterData);
         }
         GxWebStd.gx_hidden_field( context, "vINOUTBR_PROCEDURE_RADIOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8InOutBR_Procedure_RadioID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vINOUTBR_PROCEDURE_RADIO_LOC", AV9InOutBR_Procedure_Radio_Loc);
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
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIOID_Caption", StringUtil.RTrim( Ddo_br_procedure_radioid_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIOID_Tooltip", StringUtil.RTrim( Ddo_br_procedure_radioid_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIOID_Cls", StringUtil.RTrim( Ddo_br_procedure_radioid_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIOID_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_procedure_radioid_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIOID_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_procedure_radioid_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIOID_Includesortasc", StringUtil.BoolToStr( Ddo_br_procedure_radioid_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIOID_Includesortdsc", StringUtil.BoolToStr( Ddo_br_procedure_radioid_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIOID_Sortedstatus", StringUtil.RTrim( Ddo_br_procedure_radioid_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIOID_Includefilter", StringUtil.BoolToStr( Ddo_br_procedure_radioid_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIOID_Includedatalist", StringUtil.BoolToStr( Ddo_br_procedure_radioid_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIOID_Sortasc", StringUtil.RTrim( Ddo_br_procedure_radioid_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIOID_Sortdsc", StringUtil.RTrim( Ddo_br_procedure_radioid_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIOID_Searchbuttontext", StringUtil.RTrim( Ddo_br_procedure_radioid_Searchbuttontext));
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
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIO_LOC_Caption", StringUtil.RTrim( Ddo_br_procedure_radio_loc_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIO_LOC_Tooltip", StringUtil.RTrim( Ddo_br_procedure_radio_loc_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIO_LOC_Cls", StringUtil.RTrim( Ddo_br_procedure_radio_loc_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIO_LOC_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_procedure_radio_loc_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIO_LOC_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_procedure_radio_loc_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIO_LOC_Includesortasc", StringUtil.BoolToStr( Ddo_br_procedure_radio_loc_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIO_LOC_Includesortdsc", StringUtil.BoolToStr( Ddo_br_procedure_radio_loc_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIO_LOC_Sortedstatus", StringUtil.RTrim( Ddo_br_procedure_radio_loc_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIO_LOC_Includefilter", StringUtil.BoolToStr( Ddo_br_procedure_radio_loc_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIO_LOC_Includedatalist", StringUtil.BoolToStr( Ddo_br_procedure_radio_loc_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIO_LOC_Sortasc", StringUtil.RTrim( Ddo_br_procedure_radio_loc_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIO_LOC_Sortdsc", StringUtil.RTrim( Ddo_br_procedure_radio_loc_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIO_LOC_Searchbuttontext", StringUtil.RTrim( Ddo_br_procedure_radio_loc_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIO_AMOUNT_Caption", StringUtil.RTrim( Ddo_br_procedure_radio_amount_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIO_AMOUNT_Tooltip", StringUtil.RTrim( Ddo_br_procedure_radio_amount_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIO_AMOUNT_Cls", StringUtil.RTrim( Ddo_br_procedure_radio_amount_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIO_AMOUNT_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_procedure_radio_amount_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIO_AMOUNT_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_procedure_radio_amount_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIO_AMOUNT_Includesortasc", StringUtil.BoolToStr( Ddo_br_procedure_radio_amount_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIO_AMOUNT_Includesortdsc", StringUtil.BoolToStr( Ddo_br_procedure_radio_amount_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIO_AMOUNT_Sortedstatus", StringUtil.RTrim( Ddo_br_procedure_radio_amount_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIO_AMOUNT_Includefilter", StringUtil.BoolToStr( Ddo_br_procedure_radio_amount_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIO_AMOUNT_Includedatalist", StringUtil.BoolToStr( Ddo_br_procedure_radio_amount_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIO_AMOUNT_Sortasc", StringUtil.RTrim( Ddo_br_procedure_radio_amount_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIO_AMOUNT_Sortdsc", StringUtil.RTrim( Ddo_br_procedure_radio_amount_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIO_AMOUNT_Searchbuttontext", StringUtil.RTrim( Ddo_br_procedure_radio_amount_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIOID_Activeeventkey", StringUtil.RTrim( Ddo_br_procedure_radioid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDUREID_Activeeventkey", StringUtil.RTrim( Ddo_br_procedureid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIO_LOC_Activeeventkey", StringUtil.RTrim( Ddo_br_procedure_radio_loc_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIO_AMOUNT_Activeeventkey", StringUtil.RTrim( Ddo_br_procedure_radio_amount_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIOID_Activeeventkey", StringUtil.RTrim( Ddo_br_procedure_radioid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDUREID_Activeeventkey", StringUtil.RTrim( Ddo_br_procedureid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIO_LOC_Activeeventkey", StringUtil.RTrim( Ddo_br_procedure_radio_loc_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_PROCEDURE_RADIO_AMOUNT_Activeeventkey", StringUtil.RTrim( Ddo_br_procedure_radio_amount_Activeeventkey));
      }

      protected void RenderHtmlCloseForm6B2( )
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
         return "BR_Procedure_RadioPrompt" ;
      }

      public override String GetPgmdesc( )
      {
         return "选择诊疗处理化疗信息" ;
      }

      protected void WB6B0( )
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
               if ( edtBR_Procedure_RadioID_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Procedure_RadioID_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Procedure_RadioID_Title) ;
               }
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
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Procedure_Radio_Loc_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Procedure_Radio_Loc_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Procedure_Radio_Loc_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Procedure_Radio_Amount_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Procedure_Radio_Amount_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Procedure_Radio_Amount_Title) ;
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
               GridColumn.AddObjectProperty("Value", context.convertURL( AV26Select));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavSelect_Tooltiptext));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A323BR_Procedure_RadioID), 18, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Procedure_RadioID_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Procedure_RadioID_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A139BR_ProcedureID), 18, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_ProcedureID_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_ProcedureID_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A324BR_Procedure_Radio_Loc);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Procedure_Radio_Loc_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Procedure_Radio_Loc_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A325BR_Procedure_Radio_Amount);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Procedure_Radio_Amount_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Procedure_Radio_Amount_Titleformat), 4, 0, ".", "")));
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
            ucGridpaginationbar.SetProperty("CurrentPage", AV23GridCurrentPage);
            ucGridpaginationbar.SetProperty("RecordCount", AV25GridRecordCount);
            ucGridpaginationbar.SetProperty("Page", AV24GridPageSize);
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
            ucDdo_br_procedure_radioid.SetProperty("Caption", Ddo_br_procedure_radioid_Caption);
            ucDdo_br_procedure_radioid.SetProperty("Tooltip", Ddo_br_procedure_radioid_Tooltip);
            ucDdo_br_procedure_radioid.SetProperty("Cls", Ddo_br_procedure_radioid_Cls);
            ucDdo_br_procedure_radioid.SetProperty("DropDownOptionsType", Ddo_br_procedure_radioid_Dropdownoptionstype);
            ucDdo_br_procedure_radioid.SetProperty("IncludeSortASC", Ddo_br_procedure_radioid_Includesortasc);
            ucDdo_br_procedure_radioid.SetProperty("IncludeSortDSC", Ddo_br_procedure_radioid_Includesortdsc);
            ucDdo_br_procedure_radioid.SetProperty("IncludeFilter", Ddo_br_procedure_radioid_Includefilter);
            ucDdo_br_procedure_radioid.SetProperty("IncludeDataList", Ddo_br_procedure_radioid_Includedatalist);
            ucDdo_br_procedure_radioid.SetProperty("SortASC", Ddo_br_procedure_radioid_Sortasc);
            ucDdo_br_procedure_radioid.SetProperty("SortDSC", Ddo_br_procedure_radioid_Sortdsc);
            ucDdo_br_procedure_radioid.SetProperty("SearchButtonText", Ddo_br_procedure_radioid_Searchbuttontext);
            ucDdo_br_procedure_radioid.SetProperty("DropDownOptionsTitleSettingsIcons", AV21DDO_TitleSettingsIcons);
            ucDdo_br_procedure_radioid.SetProperty("DropDownOptionsData", AV13BR_Procedure_RadioIDTitleFilterData);
            ucDdo_br_procedure_radioid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_procedure_radioid_Internalname, "DDO_BR_PROCEDURE_RADIOIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 26,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_procedure_radioidtitlecontrolidtoreplace_Internalname, AV14ddo_BR_Procedure_RadioIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,26);\"", 0, edtavDdo_br_procedure_radioidtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Procedure_RadioPrompt.htm");
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
            ucDdo_br_procedureid.SetProperty("DropDownOptionsTitleSettingsIcons", AV21DDO_TitleSettingsIcons);
            ucDdo_br_procedureid.SetProperty("DropDownOptionsData", AV15BR_ProcedureIDTitleFilterData);
            ucDdo_br_procedureid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_procedureid_Internalname, "DDO_BR_PROCEDUREIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 28,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_procedureidtitlecontrolidtoreplace_Internalname, AV16ddo_BR_ProcedureIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,28);\"", 0, edtavDdo_br_procedureidtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Procedure_RadioPrompt.htm");
            /* User Defined Control */
            ucDdo_br_procedure_radio_loc.SetProperty("Caption", Ddo_br_procedure_radio_loc_Caption);
            ucDdo_br_procedure_radio_loc.SetProperty("Tooltip", Ddo_br_procedure_radio_loc_Tooltip);
            ucDdo_br_procedure_radio_loc.SetProperty("Cls", Ddo_br_procedure_radio_loc_Cls);
            ucDdo_br_procedure_radio_loc.SetProperty("DropDownOptionsType", Ddo_br_procedure_radio_loc_Dropdownoptionstype);
            ucDdo_br_procedure_radio_loc.SetProperty("IncludeSortASC", Ddo_br_procedure_radio_loc_Includesortasc);
            ucDdo_br_procedure_radio_loc.SetProperty("IncludeSortDSC", Ddo_br_procedure_radio_loc_Includesortdsc);
            ucDdo_br_procedure_radio_loc.SetProperty("IncludeFilter", Ddo_br_procedure_radio_loc_Includefilter);
            ucDdo_br_procedure_radio_loc.SetProperty("IncludeDataList", Ddo_br_procedure_radio_loc_Includedatalist);
            ucDdo_br_procedure_radio_loc.SetProperty("SortASC", Ddo_br_procedure_radio_loc_Sortasc);
            ucDdo_br_procedure_radio_loc.SetProperty("SortDSC", Ddo_br_procedure_radio_loc_Sortdsc);
            ucDdo_br_procedure_radio_loc.SetProperty("SearchButtonText", Ddo_br_procedure_radio_loc_Searchbuttontext);
            ucDdo_br_procedure_radio_loc.SetProperty("DropDownOptionsTitleSettingsIcons", AV21DDO_TitleSettingsIcons);
            ucDdo_br_procedure_radio_loc.SetProperty("DropDownOptionsData", AV17BR_Procedure_Radio_LocTitleFilterData);
            ucDdo_br_procedure_radio_loc.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_procedure_radio_loc_Internalname, "DDO_BR_PROCEDURE_RADIO_LOCContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 30,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_procedure_radio_loctitlecontrolidtoreplace_Internalname, AV18ddo_BR_Procedure_Radio_LocTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,30);\"", 0, edtavDdo_br_procedure_radio_loctitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Procedure_RadioPrompt.htm");
            /* User Defined Control */
            ucDdo_br_procedure_radio_amount.SetProperty("Caption", Ddo_br_procedure_radio_amount_Caption);
            ucDdo_br_procedure_radio_amount.SetProperty("Tooltip", Ddo_br_procedure_radio_amount_Tooltip);
            ucDdo_br_procedure_radio_amount.SetProperty("Cls", Ddo_br_procedure_radio_amount_Cls);
            ucDdo_br_procedure_radio_amount.SetProperty("DropDownOptionsType", Ddo_br_procedure_radio_amount_Dropdownoptionstype);
            ucDdo_br_procedure_radio_amount.SetProperty("IncludeSortASC", Ddo_br_procedure_radio_amount_Includesortasc);
            ucDdo_br_procedure_radio_amount.SetProperty("IncludeSortDSC", Ddo_br_procedure_radio_amount_Includesortdsc);
            ucDdo_br_procedure_radio_amount.SetProperty("IncludeFilter", Ddo_br_procedure_radio_amount_Includefilter);
            ucDdo_br_procedure_radio_amount.SetProperty("IncludeDataList", Ddo_br_procedure_radio_amount_Includedatalist);
            ucDdo_br_procedure_radio_amount.SetProperty("SortASC", Ddo_br_procedure_radio_amount_Sortasc);
            ucDdo_br_procedure_radio_amount.SetProperty("SortDSC", Ddo_br_procedure_radio_amount_Sortdsc);
            ucDdo_br_procedure_radio_amount.SetProperty("SearchButtonText", Ddo_br_procedure_radio_amount_Searchbuttontext);
            ucDdo_br_procedure_radio_amount.SetProperty("DropDownOptionsTitleSettingsIcons", AV21DDO_TitleSettingsIcons);
            ucDdo_br_procedure_radio_amount.SetProperty("DropDownOptionsData", AV19BR_Procedure_Radio_AmountTitleFilterData);
            ucDdo_br_procedure_radio_amount.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_procedure_radio_amount_Internalname, "DDO_BR_PROCEDURE_RADIO_AMOUNTContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 32,'',false,'" + sGXsfl_12_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_procedure_radio_amounttitlecontrolidtoreplace_Internalname, AV20ddo_BR_Procedure_Radio_AmountTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,32);\"", 0, edtavDdo_br_procedure_radio_amounttitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_Procedure_RadioPrompt.htm");
            /* User Defined Control */
            ucWorkwithplusutilities1.Render(context, "dvelop.workwithplusutilities", Workwithplusutilities1_Internalname, "WORKWITHPLUSUTILITIES1Container");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'" + sGXsfl_12_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrderedby_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11OrderedBy), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV11OrderedBy), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,34);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrderedby_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrderedby_Visible, 1, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_Procedure_RadioPrompt.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 35,'',false,'" + sGXsfl_12_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrdereddsc_Internalname, StringUtil.BoolToStr( AV12OrderedDsc), StringUtil.BoolToStr( AV12OrderedDsc), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,35);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrdereddsc_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrdereddsc_Visible, 1, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, 0, 0, true, "", "right", false, "HLP_BR_Procedure_RadioPrompt.htm");
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

      protected void START6B2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_0-127771", 0) ;
            Form.Meta.addItem("description", "选择诊疗处理化疗信息", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUP6B0( ) ;
      }

      protected void WS6B2( )
      {
         START6B2( ) ;
         EVT6B2( ) ;
      }

      protected void EVT6B2( )
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
                           E116B2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEROWSPERPAGE") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E126B2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PROCEDURE_RADIOID.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E136B2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PROCEDUREID.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E146B2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PROCEDURE_RADIO_LOC.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E156B2 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PROCEDURE_RADIO_AMOUNT.ONOPTIONCLICKED") == 0 )
                        {
                           context.wbHandled = 1;
                           dynload_actions( ) ;
                           E166B2 ();
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
                           AV26Select = cgiGet( edtavSelect_Internalname);
                           context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSelect_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV26Select)) ? AV30Select_GXI : context.convertURL( context.PathToRelativeUrl( AV26Select))), !bGXsfl_12_Refreshing);
                           context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavSelect_Internalname, "SrcSet", context.GetImageSrcSet( AV26Select), true);
                           A323BR_Procedure_RadioID = (long)(context.localUtil.CToN( cgiGet( edtBR_Procedure_RadioID_Internalname), ".", ","));
                           A139BR_ProcedureID = (long)(context.localUtil.CToN( cgiGet( edtBR_ProcedureID_Internalname), ".", ","));
                           A324BR_Procedure_Radio_Loc = cgiGet( edtBR_Procedure_Radio_Loc_Internalname);
                           n324BR_Procedure_Radio_Loc = false;
                           A325BR_Procedure_Radio_Amount = cgiGet( edtBR_Procedure_Radio_Amount_Internalname);
                           n325BR_Procedure_Radio_Amount = false;
                           sEvtType = StringUtil.Right( sEvt, 1);
                           if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                           {
                              sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                              if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 /* Execute user event: Start */
                                 E176B2 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 /* Execute user event: Refresh */
                                 E186B2 ();
                              }
                              else if ( StringUtil.StrCmp(sEvt, "GRID.LOAD") == 0 )
                              {
                                 context.wbHandled = 1;
                                 dynload_actions( ) ;
                                 E196B2 ();
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
                                       E206B2 ();
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

      protected void WE6B2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm6B2( ) ;
            }
         }
      }

      protected void PA6B2( )
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
               GX_FocusControl = edtavDdo_br_procedure_radioidtitlecontrolidtoreplace_Internalname;
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
                                       String AV14ddo_BR_Procedure_RadioIDTitleControlIdToReplace ,
                                       String AV16ddo_BR_ProcedureIDTitleControlIdToReplace ,
                                       String AV18ddo_BR_Procedure_Radio_LocTitleControlIdToReplace ,
                                       String AV20ddo_BR_Procedure_Radio_AmountTitleControlIdToReplace )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GRID_nCurrentRecord = 0;
         RF6B2( ) ;
         /* End function gxgrGrid_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_BR_PROCEDURE_RADIOID", GetSecureSignedToken( "", context.localUtil.Format( (decimal)(A323BR_Procedure_RadioID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, "BR_PROCEDURE_RADIOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A323BR_Procedure_RadioID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "gxhash_BR_PROCEDURE_RADIO_LOC", GetSecureSignedToken( "", StringUtil.RTrim( context.localUtil.Format( A324BR_Procedure_Radio_Loc, "")), context));
         GxWebStd.gx_hidden_field( context, "BR_PROCEDURE_RADIO_LOC", A324BR_Procedure_Radio_Loc);
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
         RF6B2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV29Pgmname = "BR_Procedure_RadioPrompt";
         context.Gx_err = 0;
      }

      protected void RF6B2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridContainer.ClearRows();
         }
         wbStart = 12;
         /* Execute user event: Refresh */
         E186B2 ();
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
            /* Using cursor H006B2 */
            pr_default.execute(0, new Object[] {GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_12_idx = 1;
            sGXsfl_12_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_12_idx), 4, 0)), 4, "0");
            SubsflControlProps_122( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < subGrid_Recordsperpage( ) ) ) ) )
            {
               A325BR_Procedure_Radio_Amount = H006B2_A325BR_Procedure_Radio_Amount[0];
               n325BR_Procedure_Radio_Amount = H006B2_n325BR_Procedure_Radio_Amount[0];
               A324BR_Procedure_Radio_Loc = H006B2_A324BR_Procedure_Radio_Loc[0];
               n324BR_Procedure_Radio_Loc = H006B2_n324BR_Procedure_Radio_Loc[0];
               A139BR_ProcedureID = H006B2_A139BR_ProcedureID[0];
               A323BR_Procedure_RadioID = H006B2_A323BR_Procedure_RadioID[0];
               E196B2 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 12;
            WB6B0( ) ;
         }
         bGXsfl_12_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes6B2( )
      {
         GxWebStd.gx_hidden_field( context, "gxhash_BR_PROCEDURE_RADIOID"+"_"+sGXsfl_12_idx, GetSecureSignedToken( sGXsfl_12_idx, context.localUtil.Format( (decimal)(A323BR_Procedure_RadioID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, "gxhash_BR_PROCEDURE_RADIO_LOC"+"_"+sGXsfl_12_idx, GetSecureSignedToken( sGXsfl_12_idx, StringUtil.RTrim( context.localUtil.Format( A324BR_Procedure_Radio_Loc, "")), context));
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
         /* Using cursor H006B3 */
         pr_default.execute(1);
         GRID_nRecordCount = H006B3_AGRID_nRecordCount[0];
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
            gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_BR_Procedure_RadioIDTitleControlIdToReplace, AV16ddo_BR_ProcedureIDTitleControlIdToReplace, AV18ddo_BR_Procedure_Radio_LocTitleControlIdToReplace, AV20ddo_BR_Procedure_Radio_AmountTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_BR_Procedure_RadioIDTitleControlIdToReplace, AV16ddo_BR_ProcedureIDTitleControlIdToReplace, AV18ddo_BR_Procedure_Radio_LocTitleControlIdToReplace, AV20ddo_BR_Procedure_Radio_AmountTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_BR_Procedure_RadioIDTitleControlIdToReplace, AV16ddo_BR_ProcedureIDTitleControlIdToReplace, AV18ddo_BR_Procedure_Radio_LocTitleControlIdToReplace, AV20ddo_BR_Procedure_Radio_AmountTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_BR_Procedure_RadioIDTitleControlIdToReplace, AV16ddo_BR_ProcedureIDTitleControlIdToReplace, AV18ddo_BR_Procedure_Radio_LocTitleControlIdToReplace, AV20ddo_BR_Procedure_Radio_AmountTitleControlIdToReplace) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV11OrderedBy, AV12OrderedDsc, AV14ddo_BR_Procedure_RadioIDTitleControlIdToReplace, AV16ddo_BR_ProcedureIDTitleControlIdToReplace, AV18ddo_BR_Procedure_Radio_LocTitleControlIdToReplace, AV20ddo_BR_Procedure_Radio_AmountTitleControlIdToReplace) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP6B0( )
      {
         /* Before Start, stand alone formulas. */
         AV29Pgmname = "BR_Procedure_RadioPrompt";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E176B2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( "vDDO_TITLESETTINGSICONS"), AV21DDO_TitleSettingsIcons);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_PROCEDURE_RADIOIDTITLEFILTERDATA"), AV13BR_Procedure_RadioIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_PROCEDUREIDTITLEFILTERDATA"), AV15BR_ProcedureIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_PROCEDURE_RADIO_LOCTITLEFILTERDATA"), AV17BR_Procedure_Radio_LocTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_PROCEDURE_RADIO_AMOUNTTITLEFILTERDATA"), AV19BR_Procedure_Radio_AmountTitleFilterData);
            /* Read variables values. */
            AV14ddo_BR_Procedure_RadioIDTitleControlIdToReplace = cgiGet( edtavDdo_br_procedure_radioidtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14ddo_BR_Procedure_RadioIDTitleControlIdToReplace", AV14ddo_BR_Procedure_RadioIDTitleControlIdToReplace);
            AV16ddo_BR_ProcedureIDTitleControlIdToReplace = cgiGet( edtavDdo_br_procedureidtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16ddo_BR_ProcedureIDTitleControlIdToReplace", AV16ddo_BR_ProcedureIDTitleControlIdToReplace);
            AV18ddo_BR_Procedure_Radio_LocTitleControlIdToReplace = cgiGet( edtavDdo_br_procedure_radio_loctitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18ddo_BR_Procedure_Radio_LocTitleControlIdToReplace", AV18ddo_BR_Procedure_Radio_LocTitleControlIdToReplace);
            AV20ddo_BR_Procedure_Radio_AmountTitleControlIdToReplace = cgiGet( edtavDdo_br_procedure_radio_amounttitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20ddo_BR_Procedure_Radio_AmountTitleControlIdToReplace", AV20ddo_BR_Procedure_Radio_AmountTitleControlIdToReplace);
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
            AV23GridCurrentPage = (long)(context.localUtil.CToN( cgiGet( "vGRIDCURRENTPAGE"), ".", ","));
            AV25GridRecordCount = (long)(context.localUtil.CToN( cgiGet( "vGRIDRECORDCOUNT"), ".", ","));
            AV24GridPageSize = (long)(context.localUtil.CToN( cgiGet( "vGRIDPAGESIZE"), ".", ","));
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
            Ddo_br_procedure_radioid_Caption = cgiGet( "DDO_BR_PROCEDURE_RADIOID_Caption");
            Ddo_br_procedure_radioid_Tooltip = cgiGet( "DDO_BR_PROCEDURE_RADIOID_Tooltip");
            Ddo_br_procedure_radioid_Cls = cgiGet( "DDO_BR_PROCEDURE_RADIOID_Cls");
            Ddo_br_procedure_radioid_Dropdownoptionstype = cgiGet( "DDO_BR_PROCEDURE_RADIOID_Dropdownoptionstype");
            Ddo_br_procedure_radioid_Titlecontrolidtoreplace = cgiGet( "DDO_BR_PROCEDURE_RADIOID_Titlecontrolidtoreplace");
            Ddo_br_procedure_radioid_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_RADIOID_Includesortasc"));
            Ddo_br_procedure_radioid_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_RADIOID_Includesortdsc"));
            Ddo_br_procedure_radioid_Sortedstatus = cgiGet( "DDO_BR_PROCEDURE_RADIOID_Sortedstatus");
            Ddo_br_procedure_radioid_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_RADIOID_Includefilter"));
            Ddo_br_procedure_radioid_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_RADIOID_Includedatalist"));
            Ddo_br_procedure_radioid_Sortasc = cgiGet( "DDO_BR_PROCEDURE_RADIOID_Sortasc");
            Ddo_br_procedure_radioid_Sortdsc = cgiGet( "DDO_BR_PROCEDURE_RADIOID_Sortdsc");
            Ddo_br_procedure_radioid_Searchbuttontext = cgiGet( "DDO_BR_PROCEDURE_RADIOID_Searchbuttontext");
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
            Ddo_br_procedure_radio_loc_Caption = cgiGet( "DDO_BR_PROCEDURE_RADIO_LOC_Caption");
            Ddo_br_procedure_radio_loc_Tooltip = cgiGet( "DDO_BR_PROCEDURE_RADIO_LOC_Tooltip");
            Ddo_br_procedure_radio_loc_Cls = cgiGet( "DDO_BR_PROCEDURE_RADIO_LOC_Cls");
            Ddo_br_procedure_radio_loc_Dropdownoptionstype = cgiGet( "DDO_BR_PROCEDURE_RADIO_LOC_Dropdownoptionstype");
            Ddo_br_procedure_radio_loc_Titlecontrolidtoreplace = cgiGet( "DDO_BR_PROCEDURE_RADIO_LOC_Titlecontrolidtoreplace");
            Ddo_br_procedure_radio_loc_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_RADIO_LOC_Includesortasc"));
            Ddo_br_procedure_radio_loc_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_RADIO_LOC_Includesortdsc"));
            Ddo_br_procedure_radio_loc_Sortedstatus = cgiGet( "DDO_BR_PROCEDURE_RADIO_LOC_Sortedstatus");
            Ddo_br_procedure_radio_loc_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_RADIO_LOC_Includefilter"));
            Ddo_br_procedure_radio_loc_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_RADIO_LOC_Includedatalist"));
            Ddo_br_procedure_radio_loc_Sortasc = cgiGet( "DDO_BR_PROCEDURE_RADIO_LOC_Sortasc");
            Ddo_br_procedure_radio_loc_Sortdsc = cgiGet( "DDO_BR_PROCEDURE_RADIO_LOC_Sortdsc");
            Ddo_br_procedure_radio_loc_Searchbuttontext = cgiGet( "DDO_BR_PROCEDURE_RADIO_LOC_Searchbuttontext");
            Ddo_br_procedure_radio_amount_Caption = cgiGet( "DDO_BR_PROCEDURE_RADIO_AMOUNT_Caption");
            Ddo_br_procedure_radio_amount_Tooltip = cgiGet( "DDO_BR_PROCEDURE_RADIO_AMOUNT_Tooltip");
            Ddo_br_procedure_radio_amount_Cls = cgiGet( "DDO_BR_PROCEDURE_RADIO_AMOUNT_Cls");
            Ddo_br_procedure_radio_amount_Dropdownoptionstype = cgiGet( "DDO_BR_PROCEDURE_RADIO_AMOUNT_Dropdownoptionstype");
            Ddo_br_procedure_radio_amount_Titlecontrolidtoreplace = cgiGet( "DDO_BR_PROCEDURE_RADIO_AMOUNT_Titlecontrolidtoreplace");
            Ddo_br_procedure_radio_amount_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_RADIO_AMOUNT_Includesortasc"));
            Ddo_br_procedure_radio_amount_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_RADIO_AMOUNT_Includesortdsc"));
            Ddo_br_procedure_radio_amount_Sortedstatus = cgiGet( "DDO_BR_PROCEDURE_RADIO_AMOUNT_Sortedstatus");
            Ddo_br_procedure_radio_amount_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_RADIO_AMOUNT_Includefilter"));
            Ddo_br_procedure_radio_amount_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_PROCEDURE_RADIO_AMOUNT_Includedatalist"));
            Ddo_br_procedure_radio_amount_Sortasc = cgiGet( "DDO_BR_PROCEDURE_RADIO_AMOUNT_Sortasc");
            Ddo_br_procedure_radio_amount_Sortdsc = cgiGet( "DDO_BR_PROCEDURE_RADIO_AMOUNT_Sortdsc");
            Ddo_br_procedure_radio_amount_Searchbuttontext = cgiGet( "DDO_BR_PROCEDURE_RADIO_AMOUNT_Searchbuttontext");
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( "GRID_Rows"), ".", ","));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            Gridpaginationbar_Selectedpage = cgiGet( "GRIDPAGINATIONBAR_Selectedpage");
            Gridpaginationbar_Rowsperpageselectedvalue = (int)(context.localUtil.CToN( cgiGet( "GRIDPAGINATIONBAR_Rowsperpageselectedvalue"), ".", ","));
            Ddo_br_procedure_radioid_Activeeventkey = cgiGet( "DDO_BR_PROCEDURE_RADIOID_Activeeventkey");
            Ddo_br_procedureid_Activeeventkey = cgiGet( "DDO_BR_PROCEDUREID_Activeeventkey");
            Ddo_br_procedure_radio_loc_Activeeventkey = cgiGet( "DDO_BR_PROCEDURE_RADIO_LOC_Activeeventkey");
            Ddo_br_procedure_radio_amount_Activeeventkey = cgiGet( "DDO_BR_PROCEDURE_RADIO_AMOUNT_Activeeventkey");
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
         E176B2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E176B2( )
      {
         /* Start Routine */
         GXt_boolean1 = AV5IsAuthorized;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Check_Procedure_Radio", out  GXt_boolean1) ;
         AV5IsAuthorized = GXt_boolean1;
         if ( ! AV5IsAuthorized )
         {
            CallWebObject(formatLink("wwpbaseobjects.notauthorized.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV29Pgmname)));
            context.wjLocDisableFrm = 1;
         }
         divTablemain_Height = 493;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, divTablemain_Internalname, "Height", StringUtil.LTrim( StringUtil.Str( (decimal)(divTablemain_Height), 9, 0)), true);
         subGrid_Rows = 9;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         Ddo_br_procedure_radioid_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Procedure_RadioID";
         ucDdo_br_procedure_radioid.SendProperty(context, "", false, Ddo_br_procedure_radioid_Internalname, "TitleControlIdToReplace", Ddo_br_procedure_radioid_Titlecontrolidtoreplace);
         AV14ddo_BR_Procedure_RadioIDTitleControlIdToReplace = Ddo_br_procedure_radioid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14ddo_BR_Procedure_RadioIDTitleControlIdToReplace", AV14ddo_BR_Procedure_RadioIDTitleControlIdToReplace);
         edtavDdo_br_procedure_radioidtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_procedure_radioidtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_procedure_radioidtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_procedureid_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_ProcedureID";
         ucDdo_br_procedureid.SendProperty(context, "", false, Ddo_br_procedureid_Internalname, "TitleControlIdToReplace", Ddo_br_procedureid_Titlecontrolidtoreplace);
         AV16ddo_BR_ProcedureIDTitleControlIdToReplace = Ddo_br_procedureid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16ddo_BR_ProcedureIDTitleControlIdToReplace", AV16ddo_BR_ProcedureIDTitleControlIdToReplace);
         edtavDdo_br_procedureidtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_procedureidtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_procedureidtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_procedure_radio_loc_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Procedure_Radio_Loc";
         ucDdo_br_procedure_radio_loc.SendProperty(context, "", false, Ddo_br_procedure_radio_loc_Internalname, "TitleControlIdToReplace", Ddo_br_procedure_radio_loc_Titlecontrolidtoreplace);
         AV18ddo_BR_Procedure_Radio_LocTitleControlIdToReplace = Ddo_br_procedure_radio_loc_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18ddo_BR_Procedure_Radio_LocTitleControlIdToReplace", AV18ddo_BR_Procedure_Radio_LocTitleControlIdToReplace);
         edtavDdo_br_procedure_radio_loctitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_procedure_radio_loctitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_procedure_radio_loctitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_procedure_radio_amount_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Procedure_Radio_Amount";
         ucDdo_br_procedure_radio_amount.SendProperty(context, "", false, Ddo_br_procedure_radio_amount_Internalname, "TitleControlIdToReplace", Ddo_br_procedure_radio_amount_Titlecontrolidtoreplace);
         AV20ddo_BR_Procedure_Radio_AmountTitleControlIdToReplace = Ddo_br_procedure_radio_amount_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20ddo_BR_Procedure_Radio_AmountTitleControlIdToReplace", AV20ddo_BR_Procedure_Radio_AmountTitleControlIdToReplace);
         edtavDdo_br_procedure_radio_amounttitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_procedure_radio_amounttitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_procedure_radio_amounttitlecontrolidtoreplace_Visible), 5, 0)), true);
         Form.Caption = "选择诊疗处理化疗信息";
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
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 = AV21DDO_TitleSettingsIcons;
         new GeneXus.Programs.wwpbaseobjects.getwwptitlesettingsicons(context ).execute( out  GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2) ;
         AV21DDO_TitleSettingsIcons = GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2;
         Gridpaginationbar_Rowsperpageselectedvalue = subGrid_Rows;
         ucGridpaginationbar.SendProperty(context, "", false, Gridpaginationbar_Internalname, "RowsPerPageSelectedValue", StringUtil.LTrim( StringUtil.Str( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0)));
      }

      protected void E186B2( )
      {
         if ( gx_refresh_fired )
         {
            return  ;
         }
         gx_refresh_fired = true;
         /* Refresh Routine */
         AV13BR_Procedure_RadioIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV15BR_ProcedureIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV17BR_Procedure_Radio_LocTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV19BR_Procedure_Radio_AmountTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV6WWPContext) ;
         edtBR_Procedure_RadioID_Titleformat = 2;
         edtBR_Procedure_RadioID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "主键", AV14ddo_BR_Procedure_RadioIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Procedure_RadioID_Internalname, "Title", edtBR_Procedure_RadioID_Title, !bGXsfl_12_Refreshing);
         edtBR_ProcedureID_Titleformat = 2;
         edtBR_ProcedureID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "诊疗处理主键", AV16ddo_BR_ProcedureIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_ProcedureID_Internalname, "Title", edtBR_ProcedureID_Title, !bGXsfl_12_Refreshing);
         edtBR_Procedure_Radio_Loc_Titleformat = 2;
         edtBR_Procedure_Radio_Loc_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "放疗部位", AV18ddo_BR_Procedure_Radio_LocTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Procedure_Radio_Loc_Internalname, "Title", edtBR_Procedure_Radio_Loc_Title, !bGXsfl_12_Refreshing);
         edtBR_Procedure_Radio_Amount_Titleformat = 2;
         edtBR_Procedure_Radio_Amount_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "放疗计量", AV20ddo_BR_Procedure_Radio_AmountTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Procedure_Radio_Amount_Internalname, "Title", edtBR_Procedure_Radio_Amount_Title, !bGXsfl_12_Refreshing);
         AV23GridCurrentPage = subGrid_Currentpage( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23GridCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV23GridCurrentPage), 10, 0)));
         AV24GridPageSize = subGrid_Rows;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24GridPageSize", StringUtil.LTrim( StringUtil.Str( (decimal)(AV24GridPageSize), 10, 0)));
         AV25GridRecordCount = subGrid_Recordcount( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25GridRecordCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV25GridRecordCount), 10, 0)));
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_Procedure_RadioIDTitleFilterData", AV13BR_Procedure_RadioIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_ProcedureIDTitleFilterData", AV15BR_ProcedureIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_Procedure_Radio_LocTitleFilterData", AV17BR_Procedure_Radio_LocTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_Procedure_Radio_AmountTitleFilterData", AV19BR_Procedure_Radio_AmountTitleFilterData);
      }

      protected void E116B2( )
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
            AV22PageToGo = (int)(NumberUtil.Val( Gridpaginationbar_Selectedpage, "."));
            subgrid_gotopage( AV22PageToGo) ;
         }
      }

      protected void E126B2( )
      {
         /* Gridpaginationbar_Changerowsperpage Routine */
         subGrid_Rows = Gridpaginationbar_Rowsperpageselectedvalue;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         subgrid_firstpage( ) ;
         /*  Sending Event outputs  */
      }

      protected void E136B2( )
      {
         /* Ddo_br_procedure_radioid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_procedure_radioid_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_procedure_radioid_Sortedstatus = "ASC";
            ucDdo_br_procedure_radioid.SendProperty(context, "", false, Ddo_br_procedure_radioid_Internalname, "SortedStatus", Ddo_br_procedure_radioid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_procedure_radioid_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_procedure_radioid_Sortedstatus = "DSC";
            ucDdo_br_procedure_radioid.SendProperty(context, "", false, Ddo_br_procedure_radioid_Internalname, "SortedStatus", Ddo_br_procedure_radioid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_Procedure_RadioIDTitleFilterData", AV13BR_Procedure_RadioIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_ProcedureIDTitleFilterData", AV15BR_ProcedureIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_Procedure_Radio_LocTitleFilterData", AV17BR_Procedure_Radio_LocTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_Procedure_Radio_AmountTitleFilterData", AV19BR_Procedure_Radio_AmountTitleFilterData);
      }

      protected void E146B2( )
      {
         /* Ddo_br_procedureid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_procedureid_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_procedureid_Sortedstatus = "ASC";
            ucDdo_br_procedureid.SendProperty(context, "", false, Ddo_br_procedureid_Internalname, "SortedStatus", Ddo_br_procedureid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_procedureid_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_procedureid_Sortedstatus = "DSC";
            ucDdo_br_procedureid.SendProperty(context, "", false, Ddo_br_procedureid_Internalname, "SortedStatus", Ddo_br_procedureid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_Procedure_RadioIDTitleFilterData", AV13BR_Procedure_RadioIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_ProcedureIDTitleFilterData", AV15BR_ProcedureIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_Procedure_Radio_LocTitleFilterData", AV17BR_Procedure_Radio_LocTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_Procedure_Radio_AmountTitleFilterData", AV19BR_Procedure_Radio_AmountTitleFilterData);
      }

      protected void E156B2( )
      {
         /* Ddo_br_procedure_radio_loc_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_procedure_radio_loc_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 3;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_procedure_radio_loc_Sortedstatus = "ASC";
            ucDdo_br_procedure_radio_loc.SendProperty(context, "", false, Ddo_br_procedure_radio_loc_Internalname, "SortedStatus", Ddo_br_procedure_radio_loc_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_procedure_radio_loc_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 3;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_procedure_radio_loc_Sortedstatus = "DSC";
            ucDdo_br_procedure_radio_loc.SendProperty(context, "", false, Ddo_br_procedure_radio_loc_Internalname, "SortedStatus", Ddo_br_procedure_radio_loc_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_Procedure_RadioIDTitleFilterData", AV13BR_Procedure_RadioIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_ProcedureIDTitleFilterData", AV15BR_ProcedureIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_Procedure_Radio_LocTitleFilterData", AV17BR_Procedure_Radio_LocTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_Procedure_Radio_AmountTitleFilterData", AV19BR_Procedure_Radio_AmountTitleFilterData);
      }

      protected void E166B2( )
      {
         /* Ddo_br_procedure_radio_amount_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_procedure_radio_amount_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV11OrderedBy = 4;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_procedure_radio_amount_Sortedstatus = "ASC";
            ucDdo_br_procedure_radio_amount.SendProperty(context, "", false, Ddo_br_procedure_radio_amount_Internalname, "SortedStatus", Ddo_br_procedure_radio_amount_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_procedure_radio_amount_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV11OrderedBy = 4;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11OrderedBy), 4, 0)));
            AV12OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12OrderedDsc", AV12OrderedDsc);
            Ddo_br_procedure_radio_amount_Sortedstatus = "DSC";
            ucDdo_br_procedure_radio_amount.SendProperty(context, "", false, Ddo_br_procedure_radio_amount_Internalname, "SortedStatus", Ddo_br_procedure_radio_amount_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV13BR_Procedure_RadioIDTitleFilterData", AV13BR_Procedure_RadioIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV15BR_ProcedureIDTitleFilterData", AV15BR_ProcedureIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_Procedure_Radio_LocTitleFilterData", AV17BR_Procedure_Radio_LocTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV19BR_Procedure_Radio_AmountTitleFilterData", AV19BR_Procedure_Radio_AmountTitleFilterData);
      }

      private void E196B2( )
      {
         /* Grid_Load Routine */
         AV26Select = context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavSelect_Internalname, AV26Select);
         AV30Select_GXI = GXDbFile.PathToUrl( context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", context.GetTheme( )));
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
         E206B2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E206B2( )
      {
         /* Enter Routine */
         AV8InOutBR_Procedure_RadioID = A323BR_Procedure_RadioID;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8InOutBR_Procedure_RadioID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8InOutBR_Procedure_RadioID), 18, 0)));
         AV9InOutBR_Procedure_Radio_Loc = A324BR_Procedure_Radio_Loc;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9InOutBR_Procedure_Radio_Loc", AV9InOutBR_Procedure_Radio_Loc);
         context.setWebReturnParms(new Object[] {(long)AV8InOutBR_Procedure_RadioID,(String)AV9InOutBR_Procedure_Radio_Loc});
         context.setWebReturnParmsMetadata(new Object[] {"AV8InOutBR_Procedure_RadioID","AV9InOutBR_Procedure_Radio_Loc"});
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
         AV8InOutBR_Procedure_RadioID = Convert.ToInt64(getParm(obj,0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8InOutBR_Procedure_RadioID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8InOutBR_Procedure_RadioID), 18, 0)));
         AV9InOutBR_Procedure_Radio_Loc = (String)getParm(obj,1);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9InOutBR_Procedure_Radio_Loc", AV9InOutBR_Procedure_Radio_Loc);
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
         PA6B2( ) ;
         WS6B2( ) ;
         WE6B2( ) ;
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
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?"+GetCacheInvalidationToken( ));
         bool outputEnabled = isOutputEnabled( ) ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20202271244326", true);
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
         context.AddJavascriptSource("br_procedure_radioprompt.js", "?20202271244326", false);
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
         edtavSelect_Internalname = "vSELECT_"+sGXsfl_12_idx;
         edtBR_Procedure_RadioID_Internalname = "BR_PROCEDURE_RADIOID_"+sGXsfl_12_idx;
         edtBR_ProcedureID_Internalname = "BR_PROCEDUREID_"+sGXsfl_12_idx;
         edtBR_Procedure_Radio_Loc_Internalname = "BR_PROCEDURE_RADIO_LOC_"+sGXsfl_12_idx;
         edtBR_Procedure_Radio_Amount_Internalname = "BR_PROCEDURE_RADIO_AMOUNT_"+sGXsfl_12_idx;
      }

      protected void SubsflControlProps_fel_122( )
      {
         edtavSelect_Internalname = "vSELECT_"+sGXsfl_12_fel_idx;
         edtBR_Procedure_RadioID_Internalname = "BR_PROCEDURE_RADIOID_"+sGXsfl_12_fel_idx;
         edtBR_ProcedureID_Internalname = "BR_PROCEDUREID_"+sGXsfl_12_fel_idx;
         edtBR_Procedure_Radio_Loc_Internalname = "BR_PROCEDURE_RADIO_LOC_"+sGXsfl_12_fel_idx;
         edtBR_Procedure_Radio_Amount_Internalname = "BR_PROCEDURE_RADIO_AMOUNT_"+sGXsfl_12_fel_idx;
      }

      protected void sendrow_122( )
      {
         SubsflControlProps_122( ) ;
         WB6B0( ) ;
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
            AV26Select_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV26Select))&&String.IsNullOrEmpty(StringUtil.RTrim( AV30Select_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV26Select)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV26Select)) ? AV30Select_GXI : context.PathToRelativeUrl( AV26Select));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavSelect_Internalname,(String)sImgUrl,(String)"",(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)edtavSelect_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)5,(String)edtavSelect_Jsonclick,"'"+""+"'"+",false,"+"'"+"EENTER."+sGXsfl_12_idx+"'",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)""+TempTags,(String)"",(String)"",(short)1,(bool)AV26Select_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Procedure_RadioID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A323BR_Procedure_RadioID), 18, 0, ".", "")),context.localUtil.Format( (decimal)(A323BR_Procedure_RadioID), "ZZZZZZZZZZZZZZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Procedure_RadioID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"ID",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_ProcedureID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A139BR_ProcedureID), 18, 0, ".", "")),context.localUtil.Format( (decimal)(A139BR_ProcedureID), "ZZZZZZZZZZZZZZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_ProcedureID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)0,(bool)true,(String)"ID",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Procedure_Radio_Loc_Internalname,(String)A324BR_Procedure_Radio_Loc,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Procedure_Radio_Loc_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Procedure_Radio_Amount_Internalname,(String)A325BR_Procedure_Radio_Amount,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Procedure_Radio_Amount_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)12,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            send_integrity_lvl_hashes6B2( ) ;
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
         edtBR_Procedure_RadioID_Internalname = "BR_PROCEDURE_RADIOID";
         edtBR_ProcedureID_Internalname = "BR_PROCEDUREID";
         edtBR_Procedure_Radio_Loc_Internalname = "BR_PROCEDURE_RADIO_LOC";
         edtBR_Procedure_Radio_Amount_Internalname = "BR_PROCEDURE_RADIO_AMOUNT";
         Gridpaginationbar_Internalname = "GRIDPAGINATIONBAR";
         divHtml_gridpaginationbar_Internalname = "HTML_GRIDPAGINATIONBAR";
         divGridtablewithpaginationbar_Internalname = "GRIDTABLEWITHPAGINATIONBAR";
         divTablemain_Internalname = "TABLEMAIN";
         Ddo_br_procedure_radioid_Internalname = "DDO_BR_PROCEDURE_RADIOID";
         edtavDdo_br_procedure_radioidtitlecontrolidtoreplace_Internalname = "vDDO_BR_PROCEDURE_RADIOIDTITLECONTROLIDTOREPLACE";
         Ddo_br_procedureid_Internalname = "DDO_BR_PROCEDUREID";
         edtavDdo_br_procedureidtitlecontrolidtoreplace_Internalname = "vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE";
         Ddo_br_procedure_radio_loc_Internalname = "DDO_BR_PROCEDURE_RADIO_LOC";
         edtavDdo_br_procedure_radio_loctitlecontrolidtoreplace_Internalname = "vDDO_BR_PROCEDURE_RADIO_LOCTITLECONTROLIDTOREPLACE";
         Ddo_br_procedure_radio_amount_Internalname = "DDO_BR_PROCEDURE_RADIO_AMOUNT";
         edtavDdo_br_procedure_radio_amounttitlecontrolidtoreplace_Internalname = "vDDO_BR_PROCEDURE_RADIO_AMOUNTTITLECONTROLIDTOREPLACE";
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
         edtBR_Procedure_Radio_Amount_Jsonclick = "";
         edtBR_Procedure_Radio_Loc_Jsonclick = "";
         edtBR_ProcedureID_Jsonclick = "";
         edtBR_Procedure_RadioID_Jsonclick = "";
         edtavSelect_Jsonclick = "";
         edtavSelect_Visible = -1;
         edtavSelect_Enabled = 1;
         edtavOrdereddsc_Jsonclick = "";
         edtavOrdereddsc_Visible = 1;
         edtavOrderedby_Jsonclick = "";
         edtavOrderedby_Visible = 1;
         edtavDdo_br_procedure_radio_amounttitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_procedure_radio_loctitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_procedureidtitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_procedure_radioidtitlecontrolidtoreplace_Visible = 1;
         subGrid_Allowcollapsing = 0;
         subGrid_Allowselection = 0;
         edtavSelect_Tooltiptext = "选择";
         subGrid_Sortable = 0;
         subGrid_Header = "";
         edtBR_Procedure_Radio_Amount_Titleformat = 0;
         edtBR_Procedure_Radio_Amount_Title = "放疗计量";
         edtBR_Procedure_Radio_Loc_Titleformat = 0;
         edtBR_Procedure_Radio_Loc_Title = "放疗部位";
         edtBR_ProcedureID_Titleformat = 0;
         edtBR_ProcedureID_Title = "诊疗处理主键";
         edtBR_Procedure_RadioID_Titleformat = 0;
         edtBR_Procedure_RadioID_Title = "主键";
         subGrid_Class = "GridWithPaginationBar GridWithBorderColor WorkWith";
         subGrid_Backcolorstyle = 0;
         divTablemain_Height = 0;
         Ddo_br_procedure_radio_amount_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_procedure_radio_amount_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_procedure_radio_amount_Sortasc = "WWP_TSSortASC";
         Ddo_br_procedure_radio_amount_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_procedure_radio_amount_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_procedure_radio_amount_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_procedure_radio_amount_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_procedure_radio_amount_Titlecontrolidtoreplace = "";
         Ddo_br_procedure_radio_amount_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_procedure_radio_amount_Cls = "ColumnSettings";
         Ddo_br_procedure_radio_amount_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_procedure_radio_amount_Caption = "";
         Ddo_br_procedure_radio_loc_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_procedure_radio_loc_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_procedure_radio_loc_Sortasc = "WWP_TSSortASC";
         Ddo_br_procedure_radio_loc_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_procedure_radio_loc_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_procedure_radio_loc_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_procedure_radio_loc_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_procedure_radio_loc_Titlecontrolidtoreplace = "";
         Ddo_br_procedure_radio_loc_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_procedure_radio_loc_Cls = "ColumnSettings";
         Ddo_br_procedure_radio_loc_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_procedure_radio_loc_Caption = "";
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
         Ddo_br_procedure_radioid_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_procedure_radioid_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_procedure_radioid_Sortasc = "WWP_TSSortASC";
         Ddo_br_procedure_radioid_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_procedure_radioid_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_procedure_radioid_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_procedure_radioid_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_procedure_radioid_Titlecontrolidtoreplace = "";
         Ddo_br_procedure_radioid_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_procedure_radioid_Cls = "ColumnSettings";
         Ddo_br_procedure_radioid_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_procedure_radioid_Caption = "";
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
         Form.Caption = "选择诊疗处理化疗信息";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_Procedure_RadioIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_ProcedureIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Procedure_Radio_LocTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIO_LOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Procedure_Radio_AmountTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIO_AMOUNTTITLECONTROLIDTOREPLACE',pic:''},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]");
         setEventMetadata("REFRESH",",oparms:[{av:'AV13BR_Procedure_RadioIDTitleFilterData',fld:'vBR_PROCEDURE_RADIOIDTITLEFILTERDATA',pic:''},{av:'AV15BR_ProcedureIDTitleFilterData',fld:'vBR_PROCEDUREIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Procedure_Radio_LocTitleFilterData',fld:'vBR_PROCEDURE_RADIO_LOCTITLEFILTERDATA',pic:''},{av:'AV19BR_Procedure_Radio_AmountTitleFilterData',fld:'vBR_PROCEDURE_RADIO_AMOUNTTITLEFILTERDATA',pic:''},{av:'edtBR_Procedure_RadioID_Titleformat',ctrl:'BR_PROCEDURE_RADIOID',prop:'Titleformat'},{av:'edtBR_Procedure_RadioID_Title',ctrl:'BR_PROCEDURE_RADIOID',prop:'Title'},{av:'edtBR_ProcedureID_Titleformat',ctrl:'BR_PROCEDUREID',prop:'Titleformat'},{av:'edtBR_ProcedureID_Title',ctrl:'BR_PROCEDUREID',prop:'Title'},{av:'edtBR_Procedure_Radio_Loc_Titleformat',ctrl:'BR_PROCEDURE_RADIO_LOC',prop:'Titleformat'},{av:'edtBR_Procedure_Radio_Loc_Title',ctrl:'BR_PROCEDURE_RADIO_LOC',prop:'Title'},{av:'edtBR_Procedure_Radio_Amount_Titleformat',ctrl:'BR_PROCEDURE_RADIO_AMOUNT',prop:'Titleformat'},{av:'edtBR_Procedure_Radio_Amount_Title',ctrl:'BR_PROCEDURE_RADIO_AMOUNT',prop:'Title'},{av:'AV23GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV24GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV25GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE","{handler:'E116B2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_Procedure_RadioIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_ProcedureIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Procedure_Radio_LocTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIO_LOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Procedure_Radio_AmountTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIO_AMOUNTTITLECONTROLIDTOREPLACE',pic:''},{av:'Gridpaginationbar_Selectedpage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE",",oparms:[]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE","{handler:'E126B2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_Procedure_RadioIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_ProcedureIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Procedure_Radio_LocTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIO_LOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Procedure_Radio_AmountTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIO_AMOUNTTITLECONTROLIDTOREPLACE',pic:''},{av:'Gridpaginationbar_Rowsperpageselectedvalue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE",",oparms:[{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]}");
         setEventMetadata("DDO_BR_PROCEDURE_RADIOID.ONOPTIONCLICKED","{handler:'E136B2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_Procedure_RadioIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_ProcedureIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Procedure_Radio_LocTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIO_LOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Procedure_Radio_AmountTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIO_AMOUNTTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_procedure_radioid_Activeeventkey',ctrl:'DDO_BR_PROCEDURE_RADIOID',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_PROCEDURE_RADIOID.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_procedure_radioid_Sortedstatus',ctrl:'DDO_BR_PROCEDURE_RADIOID',prop:'SortedStatus'},{av:'AV13BR_Procedure_RadioIDTitleFilterData',fld:'vBR_PROCEDURE_RADIOIDTITLEFILTERDATA',pic:''},{av:'AV15BR_ProcedureIDTitleFilterData',fld:'vBR_PROCEDUREIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Procedure_Radio_LocTitleFilterData',fld:'vBR_PROCEDURE_RADIO_LOCTITLEFILTERDATA',pic:''},{av:'AV19BR_Procedure_Radio_AmountTitleFilterData',fld:'vBR_PROCEDURE_RADIO_AMOUNTTITLEFILTERDATA',pic:''},{av:'edtBR_Procedure_RadioID_Titleformat',ctrl:'BR_PROCEDURE_RADIOID',prop:'Titleformat'},{av:'edtBR_Procedure_RadioID_Title',ctrl:'BR_PROCEDURE_RADIOID',prop:'Title'},{av:'edtBR_ProcedureID_Titleformat',ctrl:'BR_PROCEDUREID',prop:'Titleformat'},{av:'edtBR_ProcedureID_Title',ctrl:'BR_PROCEDUREID',prop:'Title'},{av:'edtBR_Procedure_Radio_Loc_Titleformat',ctrl:'BR_PROCEDURE_RADIO_LOC',prop:'Titleformat'},{av:'edtBR_Procedure_Radio_Loc_Title',ctrl:'BR_PROCEDURE_RADIO_LOC',prop:'Title'},{av:'edtBR_Procedure_Radio_Amount_Titleformat',ctrl:'BR_PROCEDURE_RADIO_AMOUNT',prop:'Titleformat'},{av:'edtBR_Procedure_Radio_Amount_Title',ctrl:'BR_PROCEDURE_RADIO_AMOUNT',prop:'Title'},{av:'AV23GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV24GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV25GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_PROCEDUREID.ONOPTIONCLICKED","{handler:'E146B2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_Procedure_RadioIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_ProcedureIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Procedure_Radio_LocTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIO_LOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Procedure_Radio_AmountTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIO_AMOUNTTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_procedureid_Activeeventkey',ctrl:'DDO_BR_PROCEDUREID',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_PROCEDUREID.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_procedureid_Sortedstatus',ctrl:'DDO_BR_PROCEDUREID',prop:'SortedStatus'},{av:'AV13BR_Procedure_RadioIDTitleFilterData',fld:'vBR_PROCEDURE_RADIOIDTITLEFILTERDATA',pic:''},{av:'AV15BR_ProcedureIDTitleFilterData',fld:'vBR_PROCEDUREIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Procedure_Radio_LocTitleFilterData',fld:'vBR_PROCEDURE_RADIO_LOCTITLEFILTERDATA',pic:''},{av:'AV19BR_Procedure_Radio_AmountTitleFilterData',fld:'vBR_PROCEDURE_RADIO_AMOUNTTITLEFILTERDATA',pic:''},{av:'edtBR_Procedure_RadioID_Titleformat',ctrl:'BR_PROCEDURE_RADIOID',prop:'Titleformat'},{av:'edtBR_Procedure_RadioID_Title',ctrl:'BR_PROCEDURE_RADIOID',prop:'Title'},{av:'edtBR_ProcedureID_Titleformat',ctrl:'BR_PROCEDUREID',prop:'Titleformat'},{av:'edtBR_ProcedureID_Title',ctrl:'BR_PROCEDUREID',prop:'Title'},{av:'edtBR_Procedure_Radio_Loc_Titleformat',ctrl:'BR_PROCEDURE_RADIO_LOC',prop:'Titleformat'},{av:'edtBR_Procedure_Radio_Loc_Title',ctrl:'BR_PROCEDURE_RADIO_LOC',prop:'Title'},{av:'edtBR_Procedure_Radio_Amount_Titleformat',ctrl:'BR_PROCEDURE_RADIO_AMOUNT',prop:'Titleformat'},{av:'edtBR_Procedure_Radio_Amount_Title',ctrl:'BR_PROCEDURE_RADIO_AMOUNT',prop:'Title'},{av:'AV23GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV24GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV25GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_PROCEDURE_RADIO_LOC.ONOPTIONCLICKED","{handler:'E156B2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_Procedure_RadioIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_ProcedureIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Procedure_Radio_LocTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIO_LOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Procedure_Radio_AmountTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIO_AMOUNTTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_procedure_radio_loc_Activeeventkey',ctrl:'DDO_BR_PROCEDURE_RADIO_LOC',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_PROCEDURE_RADIO_LOC.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_procedure_radio_loc_Sortedstatus',ctrl:'DDO_BR_PROCEDURE_RADIO_LOC',prop:'SortedStatus'},{av:'AV13BR_Procedure_RadioIDTitleFilterData',fld:'vBR_PROCEDURE_RADIOIDTITLEFILTERDATA',pic:''},{av:'AV15BR_ProcedureIDTitleFilterData',fld:'vBR_PROCEDUREIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Procedure_Radio_LocTitleFilterData',fld:'vBR_PROCEDURE_RADIO_LOCTITLEFILTERDATA',pic:''},{av:'AV19BR_Procedure_Radio_AmountTitleFilterData',fld:'vBR_PROCEDURE_RADIO_AMOUNTTITLEFILTERDATA',pic:''},{av:'edtBR_Procedure_RadioID_Titleformat',ctrl:'BR_PROCEDURE_RADIOID',prop:'Titleformat'},{av:'edtBR_Procedure_RadioID_Title',ctrl:'BR_PROCEDURE_RADIOID',prop:'Title'},{av:'edtBR_ProcedureID_Titleformat',ctrl:'BR_PROCEDUREID',prop:'Titleformat'},{av:'edtBR_ProcedureID_Title',ctrl:'BR_PROCEDUREID',prop:'Title'},{av:'edtBR_Procedure_Radio_Loc_Titleformat',ctrl:'BR_PROCEDURE_RADIO_LOC',prop:'Titleformat'},{av:'edtBR_Procedure_Radio_Loc_Title',ctrl:'BR_PROCEDURE_RADIO_LOC',prop:'Title'},{av:'edtBR_Procedure_Radio_Amount_Titleformat',ctrl:'BR_PROCEDURE_RADIO_AMOUNT',prop:'Titleformat'},{av:'edtBR_Procedure_Radio_Amount_Title',ctrl:'BR_PROCEDURE_RADIO_AMOUNT',prop:'Title'},{av:'AV23GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV24GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV25GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_PROCEDURE_RADIO_AMOUNT.ONOPTIONCLICKED","{handler:'E166B2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV14ddo_BR_Procedure_RadioIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIOIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV16ddo_BR_ProcedureIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV18ddo_BR_Procedure_Radio_LocTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIO_LOCTITLECONTROLIDTOREPLACE',pic:''},{av:'AV20ddo_BR_Procedure_Radio_AmountTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_RADIO_AMOUNTTITLECONTROLIDTOREPLACE',pic:''},{av:'Ddo_br_procedure_radio_amount_Activeeventkey',ctrl:'DDO_BR_PROCEDURE_RADIO_AMOUNT',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_PROCEDURE_RADIO_AMOUNT.ONOPTIONCLICKED",",oparms:[{av:'AV11OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV12OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_procedure_radio_amount_Sortedstatus',ctrl:'DDO_BR_PROCEDURE_RADIO_AMOUNT',prop:'SortedStatus'},{av:'AV13BR_Procedure_RadioIDTitleFilterData',fld:'vBR_PROCEDURE_RADIOIDTITLEFILTERDATA',pic:''},{av:'AV15BR_ProcedureIDTitleFilterData',fld:'vBR_PROCEDUREIDTITLEFILTERDATA',pic:''},{av:'AV17BR_Procedure_Radio_LocTitleFilterData',fld:'vBR_PROCEDURE_RADIO_LOCTITLEFILTERDATA',pic:''},{av:'AV19BR_Procedure_Radio_AmountTitleFilterData',fld:'vBR_PROCEDURE_RADIO_AMOUNTTITLEFILTERDATA',pic:''},{av:'edtBR_Procedure_RadioID_Titleformat',ctrl:'BR_PROCEDURE_RADIOID',prop:'Titleformat'},{av:'edtBR_Procedure_RadioID_Title',ctrl:'BR_PROCEDURE_RADIOID',prop:'Title'},{av:'edtBR_ProcedureID_Titleformat',ctrl:'BR_PROCEDUREID',prop:'Titleformat'},{av:'edtBR_ProcedureID_Title',ctrl:'BR_PROCEDUREID',prop:'Title'},{av:'edtBR_Procedure_Radio_Loc_Titleformat',ctrl:'BR_PROCEDURE_RADIO_LOC',prop:'Titleformat'},{av:'edtBR_Procedure_Radio_Loc_Title',ctrl:'BR_PROCEDURE_RADIO_LOC',prop:'Title'},{av:'edtBR_Procedure_Radio_Amount_Titleformat',ctrl:'BR_PROCEDURE_RADIO_AMOUNT',prop:'Titleformat'},{av:'edtBR_Procedure_Radio_Amount_Title',ctrl:'BR_PROCEDURE_RADIO_AMOUNT',prop:'Title'},{av:'AV23GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV24GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV25GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("GRID.LOAD","{handler:'E196B2',iparms:[]");
         setEventMetadata("GRID.LOAD",",oparms:[{av:'AV26Select',fld:'vSELECT',pic:''},{av:'edtavSelect_Tooltiptext',ctrl:'vSELECT',prop:'Tooltiptext'}]}");
         setEventMetadata("ENTER","{handler:'E206B2',iparms:[{av:'A323BR_Procedure_RadioID',fld:'BR_PROCEDURE_RADIOID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'A324BR_Procedure_Radio_Loc',fld:'BR_PROCEDURE_RADIO_LOC',pic:'',hsh:true}]");
         setEventMetadata("ENTER",",oparms:[{av:'AV8InOutBR_Procedure_RadioID',fld:'vINOUTBR_PROCEDURE_RADIOID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV9InOutBR_Procedure_Radio_Loc',fld:'vINOUTBR_PROCEDURE_RADIO_LOC',pic:''}]}");
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
         wcpOAV9InOutBR_Procedure_Radio_Loc = "";
         Gridpaginationbar_Selectedpage = "";
         Ddo_br_procedure_radioid_Activeeventkey = "";
         Ddo_br_procedureid_Activeeventkey = "";
         Ddo_br_procedure_radio_loc_Activeeventkey = "";
         Ddo_br_procedure_radio_amount_Activeeventkey = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV14ddo_BR_Procedure_RadioIDTitleControlIdToReplace = "";
         AV16ddo_BR_ProcedureIDTitleControlIdToReplace = "";
         AV18ddo_BR_Procedure_Radio_LocTitleControlIdToReplace = "";
         AV20ddo_BR_Procedure_Radio_AmountTitleControlIdToReplace = "";
         GXKey = "";
         AV29Pgmname = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         AV21DDO_TitleSettingsIcons = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV13BR_Procedure_RadioIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV15BR_ProcedureIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV17BR_Procedure_Radio_LocTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV19BR_Procedure_Radio_AmountTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         Ddo_br_procedure_radioid_Sortedstatus = "";
         Ddo_br_procedureid_Sortedstatus = "";
         Ddo_br_procedure_radio_loc_Sortedstatus = "";
         Ddo_br_procedure_radio_amount_Sortedstatus = "";
         GX_FocusControl = "";
         sPrefix = "";
         GridContainer = new GXWebGrid( context);
         sStyleString = "";
         subGrid_Linesclass = "";
         GridColumn = new GXWebColumn();
         AV26Select = "";
         A324BR_Procedure_Radio_Loc = "";
         A325BR_Procedure_Radio_Amount = "";
         ucGridpaginationbar = new GXUserControl();
         ucDdo_br_procedure_radioid = new GXUserControl();
         TempTags = "";
         ClassString = "";
         StyleString = "";
         ucDdo_br_procedureid = new GXUserControl();
         ucDdo_br_procedure_radio_loc = new GXUserControl();
         ucDdo_br_procedure_radio_amount = new GXUserControl();
         ucWorkwithplusutilities1 = new GXUserControl();
         Form = new GXWebForm();
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV30Select_GXI = "";
         scmdbuf = "";
         H006B2_A325BR_Procedure_Radio_Amount = new String[] {""} ;
         H006B2_n325BR_Procedure_Radio_Amount = new bool[] {false} ;
         H006B2_A324BR_Procedure_Radio_Loc = new String[] {""} ;
         H006B2_n324BR_Procedure_Radio_Loc = new bool[] {false} ;
         H006B2_A139BR_ProcedureID = new long[1] ;
         H006B2_A323BR_Procedure_RadioID = new long[1] ;
         H006B3_AGRID_nRecordCount = new long[1] ;
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV6WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         GridRow = new GXWebRow();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sImgUrl = "";
         ROClassString = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_procedure_radioprompt__default(),
            new Object[][] {
                new Object[] {
               H006B2_A325BR_Procedure_Radio_Amount, H006B2_n325BR_Procedure_Radio_Amount, H006B2_A324BR_Procedure_Radio_Loc, H006B2_n324BR_Procedure_Radio_Loc, H006B2_A139BR_ProcedureID, H006B2_A323BR_Procedure_RadioID
               }
               , new Object[] {
               H006B3_AGRID_nRecordCount
               }
            }
         );
         AV29Pgmname = "BR_Procedure_RadioPrompt";
         /* GeneXus formulas. */
         AV29Pgmname = "BR_Procedure_RadioPrompt";
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
      private short edtBR_Procedure_RadioID_Titleformat ;
      private short edtBR_ProcedureID_Titleformat ;
      private short edtBR_Procedure_Radio_Loc_Titleformat ;
      private short edtBR_Procedure_Radio_Amount_Titleformat ;
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
      private int edtavDdo_br_procedure_radioidtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_procedureidtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_procedure_radio_loctitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_procedure_radio_amounttitlecontrolidtoreplace_Visible ;
      private int edtavOrderedby_Visible ;
      private int edtavOrdereddsc_Visible ;
      private int subGrid_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int AV22PageToGo ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private int edtavSelect_Enabled ;
      private int edtavSelect_Visible ;
      private long AV8InOutBR_Procedure_RadioID ;
      private long wcpOAV8InOutBR_Procedure_RadioID ;
      private long GRID_nFirstRecordOnPage ;
      private long AV23GridCurrentPage ;
      private long AV25GridRecordCount ;
      private long AV24GridPageSize ;
      private long A323BR_Procedure_RadioID ;
      private long A139BR_ProcedureID ;
      private long GRID_nCurrentRecord ;
      private long GRID_nRecordCount ;
      private String Gridpaginationbar_Selectedpage ;
      private String Ddo_br_procedure_radioid_Activeeventkey ;
      private String Ddo_br_procedureid_Activeeventkey ;
      private String Ddo_br_procedure_radio_loc_Activeeventkey ;
      private String Ddo_br_procedure_radio_amount_Activeeventkey ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_12_idx="0001" ;
      private String GXKey ;
      private String AV29Pgmname ;
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
      private String Ddo_br_procedure_radioid_Caption ;
      private String Ddo_br_procedure_radioid_Tooltip ;
      private String Ddo_br_procedure_radioid_Cls ;
      private String Ddo_br_procedure_radioid_Dropdownoptionstype ;
      private String Ddo_br_procedure_radioid_Titlecontrolidtoreplace ;
      private String Ddo_br_procedure_radioid_Sortedstatus ;
      private String Ddo_br_procedure_radioid_Sortasc ;
      private String Ddo_br_procedure_radioid_Sortdsc ;
      private String Ddo_br_procedure_radioid_Searchbuttontext ;
      private String Ddo_br_procedureid_Caption ;
      private String Ddo_br_procedureid_Tooltip ;
      private String Ddo_br_procedureid_Cls ;
      private String Ddo_br_procedureid_Dropdownoptionstype ;
      private String Ddo_br_procedureid_Titlecontrolidtoreplace ;
      private String Ddo_br_procedureid_Sortedstatus ;
      private String Ddo_br_procedureid_Sortasc ;
      private String Ddo_br_procedureid_Sortdsc ;
      private String Ddo_br_procedureid_Searchbuttontext ;
      private String Ddo_br_procedure_radio_loc_Caption ;
      private String Ddo_br_procedure_radio_loc_Tooltip ;
      private String Ddo_br_procedure_radio_loc_Cls ;
      private String Ddo_br_procedure_radio_loc_Dropdownoptionstype ;
      private String Ddo_br_procedure_radio_loc_Titlecontrolidtoreplace ;
      private String Ddo_br_procedure_radio_loc_Sortedstatus ;
      private String Ddo_br_procedure_radio_loc_Sortasc ;
      private String Ddo_br_procedure_radio_loc_Sortdsc ;
      private String Ddo_br_procedure_radio_loc_Searchbuttontext ;
      private String Ddo_br_procedure_radio_amount_Caption ;
      private String Ddo_br_procedure_radio_amount_Tooltip ;
      private String Ddo_br_procedure_radio_amount_Cls ;
      private String Ddo_br_procedure_radio_amount_Dropdownoptionstype ;
      private String Ddo_br_procedure_radio_amount_Titlecontrolidtoreplace ;
      private String Ddo_br_procedure_radio_amount_Sortedstatus ;
      private String Ddo_br_procedure_radio_amount_Sortasc ;
      private String Ddo_br_procedure_radio_amount_Sortdsc ;
      private String Ddo_br_procedure_radio_amount_Searchbuttontext ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divLayoutmaintable_Internalname ;
      private String divTablemain_Internalname ;
      private String divGridtablewithpaginationbar_Internalname ;
      private String sStyleString ;
      private String subGrid_Internalname ;
      private String subGrid_Class ;
      private String subGrid_Linesclass ;
      private String edtBR_Procedure_RadioID_Title ;
      private String edtBR_ProcedureID_Title ;
      private String edtBR_Procedure_Radio_Loc_Title ;
      private String edtBR_Procedure_Radio_Amount_Title ;
      private String subGrid_Header ;
      private String edtavSelect_Tooltiptext ;
      private String divHtml_gridpaginationbar_Internalname ;
      private String Gridpaginationbar_Internalname ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String Ddo_br_procedure_radioid_Internalname ;
      private String TempTags ;
      private String ClassString ;
      private String StyleString ;
      private String edtavDdo_br_procedure_radioidtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_procedureid_Internalname ;
      private String edtavDdo_br_procedureidtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_procedure_radio_loc_Internalname ;
      private String edtavDdo_br_procedure_radio_loctitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_procedure_radio_amount_Internalname ;
      private String edtavDdo_br_procedure_radio_amounttitlecontrolidtoreplace_Internalname ;
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
      private String edtBR_Procedure_RadioID_Internalname ;
      private String edtBR_ProcedureID_Internalname ;
      private String edtBR_Procedure_Radio_Loc_Internalname ;
      private String edtBR_Procedure_Radio_Amount_Internalname ;
      private String scmdbuf ;
      private String sGXsfl_12_fel_idx="0001" ;
      private String sImgUrl ;
      private String edtavSelect_Jsonclick ;
      private String ROClassString ;
      private String edtBR_Procedure_RadioID_Jsonclick ;
      private String edtBR_ProcedureID_Jsonclick ;
      private String edtBR_Procedure_Radio_Loc_Jsonclick ;
      private String edtBR_Procedure_Radio_Amount_Jsonclick ;
      private bool entryPointCalled ;
      private bool AV12OrderedDsc ;
      private bool toggleJsOutput ;
      private bool Gridpaginationbar_Showfirst ;
      private bool Gridpaginationbar_Showprevious ;
      private bool Gridpaginationbar_Shownext ;
      private bool Gridpaginationbar_Showlast ;
      private bool Gridpaginationbar_Rowsperpageselector ;
      private bool Ddo_br_procedure_radioid_Includesortasc ;
      private bool Ddo_br_procedure_radioid_Includesortdsc ;
      private bool Ddo_br_procedure_radioid_Includefilter ;
      private bool Ddo_br_procedure_radioid_Includedatalist ;
      private bool Ddo_br_procedureid_Includesortasc ;
      private bool Ddo_br_procedureid_Includesortdsc ;
      private bool Ddo_br_procedureid_Includefilter ;
      private bool Ddo_br_procedureid_Includedatalist ;
      private bool Ddo_br_procedure_radio_loc_Includesortasc ;
      private bool Ddo_br_procedure_radio_loc_Includesortdsc ;
      private bool Ddo_br_procedure_radio_loc_Includefilter ;
      private bool Ddo_br_procedure_radio_loc_Includedatalist ;
      private bool Ddo_br_procedure_radio_amount_Includesortasc ;
      private bool Ddo_br_procedure_radio_amount_Includesortdsc ;
      private bool Ddo_br_procedure_radio_amount_Includefilter ;
      private bool Ddo_br_procedure_radio_amount_Includedatalist ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_12_Refreshing=false ;
      private bool n324BR_Procedure_Radio_Loc ;
      private bool n325BR_Procedure_Radio_Amount ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool AV5IsAuthorized ;
      private bool GXt_boolean1 ;
      private bool gx_refresh_fired ;
      private bool AV26Select_IsBlob ;
      private String AV9InOutBR_Procedure_Radio_Loc ;
      private String wcpOAV9InOutBR_Procedure_Radio_Loc ;
      private String AV14ddo_BR_Procedure_RadioIDTitleControlIdToReplace ;
      private String AV16ddo_BR_ProcedureIDTitleControlIdToReplace ;
      private String AV18ddo_BR_Procedure_Radio_LocTitleControlIdToReplace ;
      private String AV20ddo_BR_Procedure_Radio_AmountTitleControlIdToReplace ;
      private String A324BR_Procedure_Radio_Loc ;
      private String A325BR_Procedure_Radio_Amount ;
      private String AV30Select_GXI ;
      private String AV26Select ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private GXUserControl ucGridpaginationbar ;
      private GXUserControl ucDdo_br_procedure_radioid ;
      private GXUserControl ucDdo_br_procedureid ;
      private GXUserControl ucDdo_br_procedure_radio_loc ;
      private GXUserControl ucDdo_br_procedure_radio_amount ;
      private GXUserControl ucWorkwithplusutilities1 ;
      private GXWebForm Form ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private long aP0_InOutBR_Procedure_RadioID ;
      private String aP1_InOutBR_Procedure_Radio_Loc ;
      private IDataStoreProvider pr_default ;
      private String[] H006B2_A325BR_Procedure_Radio_Amount ;
      private bool[] H006B2_n325BR_Procedure_Radio_Amount ;
      private String[] H006B2_A324BR_Procedure_Radio_Loc ;
      private bool[] H006B2_n324BR_Procedure_Radio_Loc ;
      private long[] H006B2_A139BR_ProcedureID ;
      private long[] H006B2_A323BR_Procedure_RadioID ;
      private long[] H006B3_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV13BR_Procedure_RadioIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV15BR_ProcedureIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV17BR_Procedure_Radio_LocTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV19BR_Procedure_Radio_AmountTitleFilterData ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons AV21DDO_TitleSettingsIcons ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons2 ;
   }

   public class br_procedure_radioprompt__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H006B2( IGxContext context ,
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
         sSelectString = " [BR_Procedure_Radio_Amount], [BR_Procedure_Radio_Loc], [BR_ProcedureID], [BR_Procedure_RadioID]";
         sFromString = " FROM [BR_Procedure_Radio] WITH (NOLOCK)";
         sOrderString = "";
         if ( ( AV11OrderedBy == 1 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Procedure_RadioID]";
         }
         else if ( ( AV11OrderedBy == 1 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Procedure_RadioID] DESC";
         }
         else if ( ( AV11OrderedBy == 2 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_ProcedureID]";
         }
         else if ( ( AV11OrderedBy == 2 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_ProcedureID] DESC";
         }
         else if ( ( AV11OrderedBy == 3 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Procedure_Radio_Loc]";
         }
         else if ( ( AV11OrderedBy == 3 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Procedure_Radio_Loc] DESC";
         }
         else if ( ( AV11OrderedBy == 4 ) && ! AV12OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Procedure_Radio_Amount]";
         }
         else if ( ( AV11OrderedBy == 4 ) && ( AV12OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Procedure_Radio_Amount] DESC";
         }
         else if ( true )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Procedure_RadioID]";
         }
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object4[0] = scmdbuf;
         GXv_Object4[1] = GXv_int3;
         return GXv_Object4 ;
      }

      protected Object[] conditional_H006B3( IGxContext context ,
                                             short AV11OrderedBy ,
                                             bool AV12OrderedDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         Object[] GXv_Object5 ;
         GXv_Object5 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM [BR_Procedure_Radio] WITH (NOLOCK)";
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
                     return conditional_H006B2(context, (short)dynConstraints[0] , (bool)dynConstraints[1] );
               case 1 :
                     return conditional_H006B3(context, (short)dynConstraints[0] , (bool)dynConstraints[1] );
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
          Object[] prmH006B2 ;
          prmH006B2 = new Object[] {
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH006B3 ;
          prmH006B3 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("H006B2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH006B2,11,0,true,false )
             ,new CursorDef("H006B3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH006B3,1,0,true,false )
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
                ((String[]) buf[2])[0] = rslt.getVarchar(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((long[]) buf[4])[0] = rslt.getLong(3) ;
                ((long[]) buf[5])[0] = rslt.getLong(4) ;
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
