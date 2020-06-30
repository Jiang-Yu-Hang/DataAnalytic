/*
               File: webpanel5
        Description: webpanel5
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 6/5/2019 17:46:31.69
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
   public class webpanel5 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public webpanel5( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public webpanel5( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( )
      {
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         cmbview_NE_Status = new GXCombobox();
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
               nRC_GXsfl_35 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               nGXsfl_35_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
               sGXsfl_35_idx = GetNextPar( );
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
               AV72stest = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV13OrderedBy = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV14OrderedDsc = StringUtil.StrToBool( GetNextPar( ));
               AV17TFview_NE_EncounterID = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV18TFview_NE_EncounterID_To = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV19ddo_view_NE_EncounterIDTitleControlIdToReplace = GetNextPar( );
               AV37ddo_view_NE_StatusTitleControlIdToReplace = GetNextPar( );
               ajax_req_read_hidden_sdt(GetNextPar( ), AV36TFview_NE_Status_Sels);
               AV81Pgmname = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid_refresh( subGrid_Rows, AV72stest, AV13OrderedBy, AV14OrderedDsc, AV17TFview_NE_EncounterID, AV18TFview_NE_EncounterID_To, AV19ddo_view_NE_EncounterIDTitleControlIdToReplace, AV37ddo_view_NE_StatusTitleControlIdToReplace, AV36TFview_NE_Status_Sels, AV81Pgmname) ;
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
            MasterPageObj = (GXMasterPage) ClassLoader.GetInstance("wwpbaseobjects.workwithplusmasterpage", "GeneXus.Programs.wwpbaseobjects.workwithplusmasterpage", new Object[] {new GxContext( context.handle, context.DataStores, context.HttpContext)});
            MasterPageObj.setDataArea(this,false);
            ValidateSpaRequest();
            MasterPageObj.webExecute();
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

      public override short ExecuteStartEvent( )
      {
         PAAF2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            STARTAF2( ) ;
         }
         return gxajaxcallmode ;
      }

      public override void RenderHtmlHeaders( )
      {
         GxWebStd.gx_html_headers( context, 0, "", "", Form.Meta, Form.Metaequiv, true);
      }

      public override void RenderHtmlOpenForm( )
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
         if ( nGXWrapped != 1 )
         {
            MasterPageObj.master_styles();
         }
         if ( ( ( context.GetBrowserType( ) == 1 ) || ( context.GetBrowserType( ) == 5 ) ) && ( StringUtil.StrCmp(context.GetBrowserVersion( ), "7.0") == 0 ) )
         {
            context.AddJavascriptSource("json2.js", "?"+context.GetBuildNumber( 127771), false);
         }
         context.AddJavascriptSource("jquery.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("gxtimezone.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("gxgral.js", "?"+context.GetBuildNumber( 127771), false);
         context.AddJavascriptSource("gxcfg.js", "?20196517463181", false);
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         context.AddJavascriptSource("DVelop/DVPaginationBar/DVPaginationBarRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/WorkWithPlusUtilities/WorkWithPlusUtilitiesRender.js", "", false);
         context.WriteHtmlText( Form.Headerrawhtml) ;
         context.CloseHtmlHeader();
         if ( context.isSpaRequest( ) )
         {
            disableOutput();
         }
         FormProcess = " data-HasEnter=\"false\" data-Skiponenter=\"false\"";
         context.WriteHtmlText( "<body ") ;
         bodyStyle = "" + "background-color:" + context.BuildHTMLColor( Form.Backcolor) + ";color:" + context.BuildHTMLColor( Form.Textcolor) + ";";
         if ( nGXWrapped == 0 )
         {
            bodyStyle = bodyStyle + "-moz-opacity:0;opacity:0;";
         }
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( Form.Background)) ) )
         {
            bodyStyle = bodyStyle + " background-image:url(" + context.convertURL( Form.Background) + ")";
         }
         context.WriteHtmlText( " "+"class=\"form-horizontal Form\""+" "+ "style='"+bodyStyle+"'") ;
         context.WriteHtmlText( FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("webpanel5.aspx") +"\">") ;
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
         GxWebStd.gx_hidden_field( context, "GXH_vSTEST", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV72stest), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vORDEREDBY", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13OrderedBy), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vORDEREDDSC", StringUtil.BoolToStr( AV14OrderedDsc));
         GxWebStd.gx_hidden_field( context, "GXH_vTFVIEW_NE_ENCOUNTERID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV17TFview_NE_EncounterID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFVIEW_NE_ENCOUNTERID_TO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV18TFview_NE_EncounterID_To), 18, 0, ".", "")));
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_35", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_35), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDCURRENTPAGE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV64GridCurrentPage), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDRECORDCOUNT", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV66GridRecordCount), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDPAGESIZE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV65GridPageSize), 10, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vDDO_TITLESETTINGSICONS", AV62DDO_TitleSettingsIcons);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vDDO_TITLESETTINGSICONS", AV62DDO_TitleSettingsIcons);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vVIEW_NE_ENCOUNTERIDTITLEFILTERDATA", AV16view_NE_EncounterIDTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vVIEW_NE_ENCOUNTERIDTITLEFILTERDATA", AV16view_NE_EncounterIDTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vVIEW_NE_STATUSTITLEFILTERDATA", AV34view_NE_StatusTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vVIEW_NE_STATUSTITLEFILTERDATA", AV34view_NE_StatusTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vTFVIEW_NE_STATUS_SELS", AV36TFview_NE_Status_Sels);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vTFVIEW_NE_STATUS_SELS", AV36TFview_NE_Status_Sels);
         }
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV81Pgmname));
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEHEADER_Width", StringUtil.RTrim( Dvpanel_tableheader_Width));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEHEADER_Cls", StringUtil.RTrim( Dvpanel_tableheader_Cls));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEHEADER_Title", StringUtil.RTrim( Dvpanel_tableheader_Title));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEHEADER_Collapsible", StringUtil.BoolToStr( Dvpanel_tableheader_Collapsible));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEHEADER_Collapsed", StringUtil.BoolToStr( Dvpanel_tableheader_Collapsed));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEHEADER_Autowidth", StringUtil.BoolToStr( Dvpanel_tableheader_Autowidth));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEHEADER_Autoheight", StringUtil.BoolToStr( Dvpanel_tableheader_Autoheight));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEHEADER_Showcollapseicon", StringUtil.BoolToStr( Dvpanel_tableheader_Showcollapseicon));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEHEADER_Iconposition", StringUtil.RTrim( Dvpanel_tableheader_Iconposition));
         GxWebStd.gx_hidden_field( context, "DVPANEL_TABLEHEADER_Autoscroll", StringUtil.BoolToStr( Dvpanel_tableheader_Autoscroll));
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
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_ENCOUNTERID_Caption", StringUtil.RTrim( Ddo_view_ne_encounterid_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_ENCOUNTERID_Tooltip", StringUtil.RTrim( Ddo_view_ne_encounterid_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_ENCOUNTERID_Cls", StringUtil.RTrim( Ddo_view_ne_encounterid_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_ENCOUNTERID_Filteredtext_set", StringUtil.RTrim( Ddo_view_ne_encounterid_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_ENCOUNTERID_Filteredtextto_set", StringUtil.RTrim( Ddo_view_ne_encounterid_Filteredtextto_set));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_ENCOUNTERID_Dropdownoptionstype", StringUtil.RTrim( Ddo_view_ne_encounterid_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_ENCOUNTERID_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_view_ne_encounterid_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_ENCOUNTERID_Includesortasc", StringUtil.BoolToStr( Ddo_view_ne_encounterid_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_ENCOUNTERID_Includesortdsc", StringUtil.BoolToStr( Ddo_view_ne_encounterid_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_ENCOUNTERID_Sortedstatus", StringUtil.RTrim( Ddo_view_ne_encounterid_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_ENCOUNTERID_Includefilter", StringUtil.BoolToStr( Ddo_view_ne_encounterid_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_ENCOUNTERID_Filtertype", StringUtil.RTrim( Ddo_view_ne_encounterid_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_ENCOUNTERID_Filterisrange", StringUtil.BoolToStr( Ddo_view_ne_encounterid_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_ENCOUNTERID_Includedatalist", StringUtil.BoolToStr( Ddo_view_ne_encounterid_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_ENCOUNTERID_Sortasc", StringUtil.RTrim( Ddo_view_ne_encounterid_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_ENCOUNTERID_Sortdsc", StringUtil.RTrim( Ddo_view_ne_encounterid_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_ENCOUNTERID_Cleanfilter", StringUtil.RTrim( Ddo_view_ne_encounterid_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_ENCOUNTERID_Rangefilterfrom", StringUtil.RTrim( Ddo_view_ne_encounterid_Rangefilterfrom));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_ENCOUNTERID_Rangefilterto", StringUtil.RTrim( Ddo_view_ne_encounterid_Rangefilterto));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_ENCOUNTERID_Searchbuttontext", StringUtil.RTrim( Ddo_view_ne_encounterid_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_STATUS_Caption", StringUtil.RTrim( Ddo_view_ne_status_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_STATUS_Tooltip", StringUtil.RTrim( Ddo_view_ne_status_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_STATUS_Cls", StringUtil.RTrim( Ddo_view_ne_status_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_STATUS_Selectedvalue_set", StringUtil.RTrim( Ddo_view_ne_status_Selectedvalue_set));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_STATUS_Dropdownoptionstype", StringUtil.RTrim( Ddo_view_ne_status_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_STATUS_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_view_ne_status_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_STATUS_Includesortasc", StringUtil.BoolToStr( Ddo_view_ne_status_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_STATUS_Includesortdsc", StringUtil.BoolToStr( Ddo_view_ne_status_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_STATUS_Sortedstatus", StringUtil.RTrim( Ddo_view_ne_status_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_STATUS_Includefilter", StringUtil.BoolToStr( Ddo_view_ne_status_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_STATUS_Includedatalist", StringUtil.BoolToStr( Ddo_view_ne_status_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_STATUS_Datalisttype", StringUtil.RTrim( Ddo_view_ne_status_Datalisttype));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_STATUS_Allowmultipleselection", StringUtil.BoolToStr( Ddo_view_ne_status_Allowmultipleselection));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_STATUS_Datalistfixedvalues", StringUtil.RTrim( Ddo_view_ne_status_Datalistfixedvalues));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_STATUS_Sortasc", StringUtil.RTrim( Ddo_view_ne_status_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_STATUS_Sortdsc", StringUtil.RTrim( Ddo_view_ne_status_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_STATUS_Cleanfilter", StringUtil.RTrim( Ddo_view_ne_status_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_STATUS_Searchbuttontext", StringUtil.RTrim( Ddo_view_ne_status_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_ENCOUNTERID_Activeeventkey", StringUtil.RTrim( Ddo_view_ne_encounterid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_ENCOUNTERID_Filteredtext_get", StringUtil.RTrim( Ddo_view_ne_encounterid_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_ENCOUNTERID_Filteredtextto_get", StringUtil.RTrim( Ddo_view_ne_encounterid_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_STATUS_Activeeventkey", StringUtil.RTrim( Ddo_view_ne_status_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_STATUS_Selectedvalue_get", StringUtil.RTrim( Ddo_view_ne_status_Selectedvalue_get));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_ENCOUNTERID_Activeeventkey", StringUtil.RTrim( Ddo_view_ne_encounterid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_ENCOUNTERID_Filteredtext_get", StringUtil.RTrim( Ddo_view_ne_encounterid_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_ENCOUNTERID_Filteredtextto_get", StringUtil.RTrim( Ddo_view_ne_encounterid_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_STATUS_Activeeventkey", StringUtil.RTrim( Ddo_view_ne_status_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_VIEW_NE_STATUS_Selectedvalue_get", StringUtil.RTrim( Ddo_view_ne_status_Selectedvalue_get));
      }

      public override void RenderHtmlCloseForm( )
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
      }

      public override void RenderHtmlContent( )
      {
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            context.WriteHtmlText( "<div") ;
            GxWebStd.ClassAttribute( context, "gx-ct-body"+" "+(String.IsNullOrEmpty(StringUtil.RTrim( Form.Class)) ? "form-horizontal Form" : Form.Class)+"-fx");
            context.WriteHtmlText( ">") ;
            WEAF2( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVTAF2( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return false ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("webpanel5.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "webpanel5" ;
      }

      public override String GetPgmdesc( )
      {
         return "webpanel5" ;
      }

      protected void WBAF0( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! wbLoad )
         {
            if ( nGXWrapped == 1 )
            {
               RenderHtmlHeaders( ) ;
               RenderHtmlOpenForm( ) ;
            }
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "Section", "left", "top", " "+"data-gx-base-lib=\"bootstrapv3\""+" "+"data-abstract-form"+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divLayoutmaintable_Internalname, 1, 0, "px", 0, "px", "Table", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "row", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, divTablemain_Internalname, 1, 0, "px", 0, "px", "TableMain", "left", "top", "", "", "div");
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
            ucDvpanel_tableheader.Render(context, "dvelop.gxbootstrap.panel", Dvpanel_tableheader_Internalname, "DVPANEL_TABLEHEADERContainer");
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+"DVPANEL_TABLEHEADERContainer"+"Body"+"\" style=\"display:none;\">") ;
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-action-group ActionGroupColoredActions", "left", "top", " "+"data-gx-actiongroup-type=\"toolbar\""+" ", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "gx-button", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"";
            ClassString = "Button ButtonColor";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtninsert_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(35), 2, 0)+","+"null"+");", "≤Â»Î", bttBtninsert_Jsonclick, 5, "≤Â»Î", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"E\\'DOINSERT\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_webpanel5.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12 col-sm-6", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+edtavStest_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, edtavStest_Internalname, "≤‚ ‘À—À˜¿∏", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 26,'',false,'" + sGXsfl_35_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavStest_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV72stest), 4, 0, ".", "")), ((edtavStest_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV72stest), "ZZZ9")) : context.localUtil.Format( (decimal)(AV72stest), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,26);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavStest_Jsonclick, 0, "Attribute", "", "", "", "", 1, edtavStest_Enabled, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_webpanel5.htm");
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            ClassString = "ErrorViewer";
            StyleString = "";
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, "", "false");
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
               context.WriteHtmlText( "<div id=\""+"GridContainer"+"DivS\" data-gxgridid=\"35\">") ;
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
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"ActionBaseColorAttribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"ActionBaseColorAttribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"DeleteAttribute ActionBaseColorAttribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtview_NE_EncounterID_Titleformat == 0 )
               {
                  context.SendWebValue( edtview_NE_EncounterID_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtview_NE_EncounterID_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               context.SendWebValue( "≤‚ ‘") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( cmbview_NE_Status_Titleformat == 0 )
               {
                  context.SendWebValue( cmbview_NE_Status.Title.Text) ;
               }
               else
               {
                  context.WriteHtmlText( cmbview_NE_Status.Title.Text) ;
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
               GridColumn.AddObjectProperty("Value", context.convertURL( AV67Display));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavDisplay_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavDisplay_Tooltiptext));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.convertURL( AV68Update));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavUpdate_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavUpdate_Tooltiptext));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.convertURL( AV69Delete));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavDelete_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavDelete_Tooltiptext));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A549view_NE_EncounterID), 18, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtview_NE_EncounterID_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtview_NE_EncounterID_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV71teststatus), 4, 0, ".", "")));
               GridColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavTeststatus_Enabled), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A553view_NE_Status), 4, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( cmbview_NE_Status.Title.Text));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(cmbview_NE_Status_Titleformat), 4, 0, ".", "")));
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
         if ( wbEnd == 35 )
         {
            wbEnd = 0;
            nRC_GXsfl_35 = (short)(nGXsfl_35_idx-1);
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
            ucGridpaginationbar.SetProperty("CurrentPage", AV64GridCurrentPage);
            ucGridpaginationbar.SetProperty("RecordCount", AV66GridRecordCount);
            ucGridpaginationbar.SetProperty("Page", AV65GridPageSize);
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
            ucDdo_view_ne_encounterid.SetProperty("Caption", Ddo_view_ne_encounterid_Caption);
            ucDdo_view_ne_encounterid.SetProperty("Tooltip", Ddo_view_ne_encounterid_Tooltip);
            ucDdo_view_ne_encounterid.SetProperty("Cls", Ddo_view_ne_encounterid_Cls);
            ucDdo_view_ne_encounterid.SetProperty("DropDownOptionsType", Ddo_view_ne_encounterid_Dropdownoptionstype);
            ucDdo_view_ne_encounterid.SetProperty("IncludeSortASC", Ddo_view_ne_encounterid_Includesortasc);
            ucDdo_view_ne_encounterid.SetProperty("IncludeSortDSC", Ddo_view_ne_encounterid_Includesortdsc);
            ucDdo_view_ne_encounterid.SetProperty("IncludeFilter", Ddo_view_ne_encounterid_Includefilter);
            ucDdo_view_ne_encounterid.SetProperty("FilterType", Ddo_view_ne_encounterid_Filtertype);
            ucDdo_view_ne_encounterid.SetProperty("FilterIsRange", Ddo_view_ne_encounterid_Filterisrange);
            ucDdo_view_ne_encounterid.SetProperty("IncludeDataList", Ddo_view_ne_encounterid_Includedatalist);
            ucDdo_view_ne_encounterid.SetProperty("SortASC", Ddo_view_ne_encounterid_Sortasc);
            ucDdo_view_ne_encounterid.SetProperty("SortDSC", Ddo_view_ne_encounterid_Sortdsc);
            ucDdo_view_ne_encounterid.SetProperty("CleanFilter", Ddo_view_ne_encounterid_Cleanfilter);
            ucDdo_view_ne_encounterid.SetProperty("RangeFilterFrom", Ddo_view_ne_encounterid_Rangefilterfrom);
            ucDdo_view_ne_encounterid.SetProperty("RangeFilterTo", Ddo_view_ne_encounterid_Rangefilterto);
            ucDdo_view_ne_encounterid.SetProperty("SearchButtonText", Ddo_view_ne_encounterid_Searchbuttontext);
            ucDdo_view_ne_encounterid.SetProperty("DropDownOptionsTitleSettingsIcons", AV62DDO_TitleSettingsIcons);
            ucDdo_view_ne_encounterid.SetProperty("DropDownOptionsData", AV16view_NE_EncounterIDTitleFilterData);
            ucDdo_view_ne_encounterid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_view_ne_encounterid_Internalname, "DDO_VIEW_NE_ENCOUNTERIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 50,'',false,'" + sGXsfl_35_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_view_ne_encounteridtitlecontrolidtoreplace_Internalname, AV19ddo_view_NE_EncounterIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,50);\"", 0, edtavDdo_view_ne_encounteridtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_webpanel5.htm");
            /* User Defined Control */
            ucDdo_view_ne_status.SetProperty("Caption", Ddo_view_ne_status_Caption);
            ucDdo_view_ne_status.SetProperty("Tooltip", Ddo_view_ne_status_Tooltip);
            ucDdo_view_ne_status.SetProperty("Cls", Ddo_view_ne_status_Cls);
            ucDdo_view_ne_status.SetProperty("DropDownOptionsType", Ddo_view_ne_status_Dropdownoptionstype);
            ucDdo_view_ne_status.SetProperty("IncludeSortASC", Ddo_view_ne_status_Includesortasc);
            ucDdo_view_ne_status.SetProperty("IncludeSortDSC", Ddo_view_ne_status_Includesortdsc);
            ucDdo_view_ne_status.SetProperty("IncludeFilter", Ddo_view_ne_status_Includefilter);
            ucDdo_view_ne_status.SetProperty("IncludeDataList", Ddo_view_ne_status_Includedatalist);
            ucDdo_view_ne_status.SetProperty("DataListType", Ddo_view_ne_status_Datalisttype);
            ucDdo_view_ne_status.SetProperty("AllowMultipleSelection", Ddo_view_ne_status_Allowmultipleselection);
            ucDdo_view_ne_status.SetProperty("DataListFixedValues", Ddo_view_ne_status_Datalistfixedvalues);
            ucDdo_view_ne_status.SetProperty("SortASC", Ddo_view_ne_status_Sortasc);
            ucDdo_view_ne_status.SetProperty("SortDSC", Ddo_view_ne_status_Sortdsc);
            ucDdo_view_ne_status.SetProperty("CleanFilter", Ddo_view_ne_status_Cleanfilter);
            ucDdo_view_ne_status.SetProperty("SearchButtonText", Ddo_view_ne_status_Searchbuttontext);
            ucDdo_view_ne_status.SetProperty("DropDownOptionsTitleSettingsIcons", AV62DDO_TitleSettingsIcons);
            ucDdo_view_ne_status.SetProperty("DropDownOptionsData", AV34view_NE_StatusTitleFilterData);
            ucDdo_view_ne_status.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_view_ne_status_Internalname, "DDO_VIEW_NE_STATUSContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 52,'',false,'" + sGXsfl_35_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_view_ne_statustitlecontrolidtoreplace_Internalname, AV37ddo_view_NE_StatusTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,52);\"", 0, edtavDdo_view_ne_statustitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_webpanel5.htm");
            /* User Defined Control */
            ucWorkwithplusutilities1.Render(context, "dvelop.workwithplusutilities", Workwithplusutilities1_Internalname, "WORKWITHPLUSUTILITIES1Container");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'',false,'" + sGXsfl_35_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrderedby_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13OrderedBy), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV13OrderedBy), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,54);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrderedby_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrderedby_Visible, 1, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_webpanel5.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 55,'',false,'" + sGXsfl_35_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrdereddsc_Internalname, StringUtil.BoolToStr( AV14OrderedDsc), StringUtil.BoolToStr( AV14OrderedDsc), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,55);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrdereddsc_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrdereddsc_Visible, 1, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, 0, 0, true, "", "right", false, "HLP_webpanel5.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 56,'',false,'" + sGXsfl_35_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfview_ne_encounterid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV17TFview_NE_EncounterID), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV17TFview_NE_EncounterID), "ZZZZZZZZZZZZZZZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,56);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfview_ne_encounterid_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfview_ne_encounterid_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_webpanel5.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 57,'',false,'" + sGXsfl_35_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfview_ne_encounterid_to_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV18TFview_NE_EncounterID_To), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV18TFview_NE_EncounterID_To), "ZZZZZZZZZZZZZZZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,57);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfview_ne_encounterid_to_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfview_ne_encounterid_to_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_webpanel5.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         if ( wbEnd == 35 )
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

      protected void STARTAF2( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_0-127771", 0) ;
            Form.Meta.addItem("description", "webpanel5", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUPAF0( ) ;
      }

      protected void WSAF2( )
      {
         STARTAF2( ) ;
         EVTAF2( ) ;
      }

      protected void EVTAF2( )
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
                  if ( StringUtil.StrCmp(sEvtType, "M") != 0 )
                  {
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
                              E11AF2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEROWSPERPAGE") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E12AF2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_VIEW_NE_ENCOUNTERID.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E13AF2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_VIEW_NE_STATUS.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E14AF2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'DOINSERT'") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              /* Execute user event: 'DoInsert' */
                              E15AF2 ();
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
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 7), "REFRESH") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 9), "GRID.LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) )
                           {
                              nGXsfl_35_idx = (short)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_35_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_35_idx), 4, 0)), 4, "0");
                              SubsflControlProps_352( ) ;
                              AV67Display = cgiGet( edtavDisplay_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDisplay_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV67Display)) ? AV78Display_GXI : context.convertURL( context.PathToRelativeUrl( AV67Display))), !bGXsfl_35_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDisplay_Internalname, "SrcSet", context.GetImageSrcSet( AV67Display), true);
                              AV68Update = cgiGet( edtavUpdate_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV68Update)) ? AV79Update_GXI : context.convertURL( context.PathToRelativeUrl( AV68Update))), !bGXsfl_35_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavUpdate_Internalname, "SrcSet", context.GetImageSrcSet( AV68Update), true);
                              AV69Delete = cgiGet( edtavDelete_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV69Delete)) ? AV80Delete_GXI : context.convertURL( context.PathToRelativeUrl( AV69Delete))), !bGXsfl_35_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDelete_Internalname, "SrcSet", context.GetImageSrcSet( AV69Delete), true);
                              A549view_NE_EncounterID = (long)(context.localUtil.CToN( cgiGet( edtview_NE_EncounterID_Internalname), ".", ","));
                              AV71teststatus = (short)(context.localUtil.CToN( cgiGet( edtavTeststatus_Internalname), ".", ","));
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavTeststatus_Internalname, StringUtil.LTrim( StringUtil.Str( (decimal)(AV71teststatus), 4, 0)));
                              cmbview_NE_Status.Name = cmbview_NE_Status_Internalname;
                              cmbview_NE_Status.CurrentValue = cgiGet( cmbview_NE_Status_Internalname);
                              A553view_NE_Status = (short)(NumberUtil.Val( cgiGet( cmbview_NE_Status_Internalname), "."));
                              n553view_NE_Status = false;
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E16AF2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Refresh */
                                    E17AF2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "GRID.LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    E18AF2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false;
                                       /* Set Refresh If Stest Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vSTEST"), ".", ",") != Convert.ToDecimal( AV72stest )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Orderedby Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vORDEREDBY"), ".", ",") != Convert.ToDecimal( AV13OrderedBy )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Ordereddsc Changed */
                                       if ( StringUtil.StrToBool( cgiGet( "GXH_vORDEREDDSC")) != AV14OrderedDsc )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfview_ne_encounterid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFVIEW_NE_ENCOUNTERID"), ".", ",") != Convert.ToDecimal( AV17TFview_NE_EncounterID )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfview_ne_encounterid_to Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFVIEW_NE_ENCOUNTERID_TO"), ".", ",") != Convert.ToDecimal( AV18TFview_NE_EncounterID_To )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       if ( ! Rfr0gs )
                                       {
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
      }

      protected void WEAF2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               if ( nGXWrapped == 1 )
               {
                  RenderHtmlCloseForm( ) ;
               }
            }
         }
      }

      protected void PAAF2( )
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
               GX_FocusControl = edtavStest_Internalname;
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
         SubsflControlProps_352( ) ;
         while ( nGXsfl_35_idx <= nRC_GXsfl_35 )
         {
            sendrow_352( ) ;
            nGXsfl_35_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_35_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_35_idx+1));
            sGXsfl_35_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_35_idx), 4, 0)), 4, "0");
            SubsflControlProps_352( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( GridContainer));
         /* End function gxnrGrid_newrow */
      }

      protected void gxgrGrid_refresh( int subGrid_Rows ,
                                       short AV72stest ,
                                       short AV13OrderedBy ,
                                       bool AV14OrderedDsc ,
                                       long AV17TFview_NE_EncounterID ,
                                       long AV18TFview_NE_EncounterID_To ,
                                       String AV19ddo_view_NE_EncounterIDTitleControlIdToReplace ,
                                       String AV37ddo_view_NE_StatusTitleControlIdToReplace ,
                                       GxSimpleCollection<short> AV36TFview_NE_Status_Sels ,
                                       String AV81Pgmname )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GRID_nCurrentRecord = 0;
         RFAF2( ) ;
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
         RFAF2( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV81Pgmname = "webpanel5";
         context.Gx_err = 0;
         edtavTeststatus_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTeststatus_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTeststatus_Enabled), 5, 0)), !bGXsfl_35_Refreshing);
      }

      protected void RFAF2( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridContainer.ClearRows();
         }
         wbStart = 35;
         /* Execute user event: Refresh */
         E17AF2 ();
         nGXsfl_35_idx = 1;
         sGXsfl_35_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_35_idx), 4, 0)), 4, "0");
         SubsflControlProps_352( ) ;
         bGXsfl_35_Refreshing = true;
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
            SubsflControlProps_352( ) ;
            GXPagingFrom2 = (int)(((subGrid_Rows==0) ? 0 : GRID_nFirstRecordOnPage));
            GXPagingTo2 = ((subGrid_Rows==0) ? 10000 : subGrid_Recordsperpage( )+1);
            pr_default.dynParam(0, new Object[]{ new Object[]{
                                                 A553view_NE_Status ,
                                                 AV77webpanel5DS_3_Tfview_ne_status_sels ,
                                                 AV75webpanel5DS_1_Tfview_ne_encounterid ,
                                                 AV76webpanel5DS_2_Tfview_ne_encounterid_to ,
                                                 AV77webpanel5DS_3_Tfview_ne_status_sels.Count ,
                                                 AV72stest ,
                                                 A549view_NE_EncounterID ,
                                                 AV13OrderedBy ,
                                                 AV14OrderedDsc } ,
                                                 new int[]{
                                                 TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.INT, TypeConstants.SHORT, TypeConstants.LONG, TypeConstants.SHORT, TypeConstants.BOOLEAN
                                                 }
            } ) ;
            /* Using cursor H00AF2 */
            pr_default.execute(0, new Object[] {AV75webpanel5DS_1_Tfview_ne_encounterid, AV76webpanel5DS_2_Tfview_ne_encounterid_to, AV72stest, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_35_idx = 1;
            sGXsfl_35_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_35_idx), 4, 0)), 4, "0");
            SubsflControlProps_352( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < subGrid_Recordsperpage( ) ) ) ) )
            {
               A553view_NE_Status = H00AF2_A553view_NE_Status[0];
               n553view_NE_Status = H00AF2_n553view_NE_Status[0];
               A549view_NE_EncounterID = H00AF2_A549view_NE_EncounterID[0];
               E18AF2 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 35;
            WBAF0( ) ;
         }
         bGXsfl_35_Refreshing = true;
      }

      protected void send_integrity_lvl_hashesAF2( )
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
         AV75webpanel5DS_1_Tfview_ne_encounterid = AV17TFview_NE_EncounterID;
         AV76webpanel5DS_2_Tfview_ne_encounterid_to = AV18TFview_NE_EncounterID_To;
         AV77webpanel5DS_3_Tfview_ne_status_sels = AV36TFview_NE_Status_Sels;
         pr_default.dynParam(1, new Object[]{ new Object[]{
                                              A553view_NE_Status ,
                                              AV77webpanel5DS_3_Tfview_ne_status_sels ,
                                              AV75webpanel5DS_1_Tfview_ne_encounterid ,
                                              AV76webpanel5DS_2_Tfview_ne_encounterid_to ,
                                              AV77webpanel5DS_3_Tfview_ne_status_sels.Count ,
                                              AV72stest ,
                                              A549view_NE_EncounterID ,
                                              AV13OrderedBy ,
                                              AV14OrderedDsc } ,
                                              new int[]{
                                              TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.INT, TypeConstants.SHORT, TypeConstants.LONG, TypeConstants.SHORT, TypeConstants.BOOLEAN
                                              }
         } ) ;
         /* Using cursor H00AF3 */
         pr_default.execute(1, new Object[] {AV75webpanel5DS_1_Tfview_ne_encounterid, AV76webpanel5DS_2_Tfview_ne_encounterid_to, AV72stest});
         GRID_nRecordCount = H00AF3_AGRID_nRecordCount[0];
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
         AV75webpanel5DS_1_Tfview_ne_encounterid = AV17TFview_NE_EncounterID;
         AV76webpanel5DS_2_Tfview_ne_encounterid_to = AV18TFview_NE_EncounterID_To;
         AV77webpanel5DS_3_Tfview_ne_status_sels = AV36TFview_NE_Status_Sels;
         GRID_nFirstRecordOnPage = 0;
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV72stest, AV13OrderedBy, AV14OrderedDsc, AV17TFview_NE_EncounterID, AV18TFview_NE_EncounterID_To, AV19ddo_view_NE_EncounterIDTitleControlIdToReplace, AV37ddo_view_NE_StatusTitleControlIdToReplace, AV36TFview_NE_Status_Sels, AV81Pgmname) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid_nextpage( )
      {
         AV75webpanel5DS_1_Tfview_ne_encounterid = AV17TFview_NE_EncounterID;
         AV76webpanel5DS_2_Tfview_ne_encounterid_to = AV18TFview_NE_EncounterID_To;
         AV77webpanel5DS_3_Tfview_ne_status_sels = AV36TFview_NE_Status_Sels;
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
            gxgrGrid_refresh( subGrid_Rows, AV72stest, AV13OrderedBy, AV14OrderedDsc, AV17TFview_NE_EncounterID, AV18TFview_NE_EncounterID_To, AV19ddo_view_NE_EncounterIDTitleControlIdToReplace, AV37ddo_view_NE_StatusTitleControlIdToReplace, AV36TFview_NE_Status_Sels, AV81Pgmname) ;
         }
         send_integrity_footer_hashes( ) ;
         return (short)(((GRID_nEOF==0) ? 0 : 2)) ;
      }

      protected short subgrid_previouspage( )
      {
         AV75webpanel5DS_1_Tfview_ne_encounterid = AV17TFview_NE_EncounterID;
         AV76webpanel5DS_2_Tfview_ne_encounterid_to = AV18TFview_NE_EncounterID_To;
         AV77webpanel5DS_3_Tfview_ne_status_sels = AV36TFview_NE_Status_Sels;
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
            gxgrGrid_refresh( subGrid_Rows, AV72stest, AV13OrderedBy, AV14OrderedDsc, AV17TFview_NE_EncounterID, AV18TFview_NE_EncounterID_To, AV19ddo_view_NE_EncounterIDTitleControlIdToReplace, AV37ddo_view_NE_StatusTitleControlIdToReplace, AV36TFview_NE_Status_Sels, AV81Pgmname) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid_lastpage( )
      {
         AV75webpanel5DS_1_Tfview_ne_encounterid = AV17TFview_NE_EncounterID;
         AV76webpanel5DS_2_Tfview_ne_encounterid_to = AV18TFview_NE_EncounterID_To;
         AV77webpanel5DS_3_Tfview_ne_status_sels = AV36TFview_NE_Status_Sels;
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
            gxgrGrid_refresh( subGrid_Rows, AV72stest, AV13OrderedBy, AV14OrderedDsc, AV17TFview_NE_EncounterID, AV18TFview_NE_EncounterID_To, AV19ddo_view_NE_EncounterIDTitleControlIdToReplace, AV37ddo_view_NE_StatusTitleControlIdToReplace, AV36TFview_NE_Status_Sels, AV81Pgmname) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected int subgrid_gotopage( int nPageNo )
      {
         AV75webpanel5DS_1_Tfview_ne_encounterid = AV17TFview_NE_EncounterID;
         AV76webpanel5DS_2_Tfview_ne_encounterid_to = AV18TFview_NE_EncounterID_To;
         AV77webpanel5DS_3_Tfview_ne_status_sels = AV36TFview_NE_Status_Sels;
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
            gxgrGrid_refresh( subGrid_Rows, AV72stest, AV13OrderedBy, AV14OrderedDsc, AV17TFview_NE_EncounterID, AV18TFview_NE_EncounterID_To, AV19ddo_view_NE_EncounterIDTitleControlIdToReplace, AV37ddo_view_NE_StatusTitleControlIdToReplace, AV36TFview_NE_Status_Sels, AV81Pgmname) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUPAF0( )
      {
         /* Before Start, stand alone formulas. */
         AV81Pgmname = "webpanel5";
         context.Gx_err = 0;
         edtavTeststatus_Enabled = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTeststatus_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTeststatus_Enabled), 5, 0)), !bGXsfl_35_Refreshing);
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E16AF2 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( "vDDO_TITLESETTINGSICONS"), AV62DDO_TitleSettingsIcons);
            ajax_req_read_hidden_sdt(cgiGet( "vVIEW_NE_ENCOUNTERIDTITLEFILTERDATA"), AV16view_NE_EncounterIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vVIEW_NE_STATUSTITLEFILTERDATA"), AV34view_NE_StatusTitleFilterData);
            /* Read variables values. */
            if ( ( ( context.localUtil.CToN( cgiGet( edtavStest_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavStest_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vSTEST");
               GX_FocusControl = edtavStest_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV72stest = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV72stest", StringUtil.LTrim( StringUtil.Str( (decimal)(AV72stest), 4, 0)));
            }
            else
            {
               AV72stest = (short)(context.localUtil.CToN( cgiGet( edtavStest_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV72stest", StringUtil.LTrim( StringUtil.Str( (decimal)(AV72stest), 4, 0)));
            }
            AV19ddo_view_NE_EncounterIDTitleControlIdToReplace = cgiGet( edtavDdo_view_ne_encounteridtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19ddo_view_NE_EncounterIDTitleControlIdToReplace", AV19ddo_view_NE_EncounterIDTitleControlIdToReplace);
            AV37ddo_view_NE_StatusTitleControlIdToReplace = cgiGet( edtavDdo_view_ne_statustitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV37ddo_view_NE_StatusTitleControlIdToReplace", AV37ddo_view_NE_StatusTitleControlIdToReplace);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavOrderedby_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavOrderedby_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vORDEREDBY");
               GX_FocusControl = edtavOrderedby_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV13OrderedBy = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            }
            else
            {
               AV13OrderedBy = (short)(context.localUtil.CToN( cgiGet( edtavOrderedby_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            }
            AV14OrderedDsc = StringUtil.StrToBool( cgiGet( edtavOrdereddsc_Internalname));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfview_ne_encounterid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfview_ne_encounterid_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFVIEW_NE_ENCOUNTERID");
               GX_FocusControl = edtavTfview_ne_encounterid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV17TFview_NE_EncounterID = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17TFview_NE_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17TFview_NE_EncounterID), 18, 0)));
            }
            else
            {
               AV17TFview_NE_EncounterID = (long)(context.localUtil.CToN( cgiGet( edtavTfview_ne_encounterid_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17TFview_NE_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17TFview_NE_EncounterID), 18, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfview_ne_encounterid_to_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfview_ne_encounterid_to_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFVIEW_NE_ENCOUNTERID_TO");
               GX_FocusControl = edtavTfview_ne_encounterid_to_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV18TFview_NE_EncounterID_To = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18TFview_NE_EncounterID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18TFview_NE_EncounterID_To), 18, 0)));
            }
            else
            {
               AV18TFview_NE_EncounterID_To = (long)(context.localUtil.CToN( cgiGet( edtavTfview_ne_encounterid_to_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18TFview_NE_EncounterID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18TFview_NE_EncounterID_To), 18, 0)));
            }
            /* Read saved values. */
            nRC_GXsfl_35 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_35"), ".", ","));
            AV64GridCurrentPage = (long)(context.localUtil.CToN( cgiGet( "vGRIDCURRENTPAGE"), ".", ","));
            AV66GridRecordCount = (long)(context.localUtil.CToN( cgiGet( "vGRIDRECORDCOUNT"), ".", ","));
            AV65GridPageSize = (long)(context.localUtil.CToN( cgiGet( "vGRIDPAGESIZE"), ".", ","));
            GRID_nFirstRecordOnPage = (long)(context.localUtil.CToN( cgiGet( "GRID_nFirstRecordOnPage"), ".", ","));
            GRID_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRID_nEOF"), ".", ","));
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( "GRID_Rows"), ".", ","));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            Dvpanel_tableheader_Width = cgiGet( "DVPANEL_TABLEHEADER_Width");
            Dvpanel_tableheader_Cls = cgiGet( "DVPANEL_TABLEHEADER_Cls");
            Dvpanel_tableheader_Title = cgiGet( "DVPANEL_TABLEHEADER_Title");
            Dvpanel_tableheader_Collapsible = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEHEADER_Collapsible"));
            Dvpanel_tableheader_Collapsed = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEHEADER_Collapsed"));
            Dvpanel_tableheader_Autowidth = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEHEADER_Autowidth"));
            Dvpanel_tableheader_Autoheight = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEHEADER_Autoheight"));
            Dvpanel_tableheader_Showcollapseicon = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEHEADER_Showcollapseicon"));
            Dvpanel_tableheader_Iconposition = cgiGet( "DVPANEL_TABLEHEADER_Iconposition");
            Dvpanel_tableheader_Autoscroll = StringUtil.StrToBool( cgiGet( "DVPANEL_TABLEHEADER_Autoscroll"));
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
            Ddo_view_ne_encounterid_Caption = cgiGet( "DDO_VIEW_NE_ENCOUNTERID_Caption");
            Ddo_view_ne_encounterid_Tooltip = cgiGet( "DDO_VIEW_NE_ENCOUNTERID_Tooltip");
            Ddo_view_ne_encounterid_Cls = cgiGet( "DDO_VIEW_NE_ENCOUNTERID_Cls");
            Ddo_view_ne_encounterid_Filteredtext_set = cgiGet( "DDO_VIEW_NE_ENCOUNTERID_Filteredtext_set");
            Ddo_view_ne_encounterid_Filteredtextto_set = cgiGet( "DDO_VIEW_NE_ENCOUNTERID_Filteredtextto_set");
            Ddo_view_ne_encounterid_Dropdownoptionstype = cgiGet( "DDO_VIEW_NE_ENCOUNTERID_Dropdownoptionstype");
            Ddo_view_ne_encounterid_Titlecontrolidtoreplace = cgiGet( "DDO_VIEW_NE_ENCOUNTERID_Titlecontrolidtoreplace");
            Ddo_view_ne_encounterid_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_VIEW_NE_ENCOUNTERID_Includesortasc"));
            Ddo_view_ne_encounterid_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_VIEW_NE_ENCOUNTERID_Includesortdsc"));
            Ddo_view_ne_encounterid_Sortedstatus = cgiGet( "DDO_VIEW_NE_ENCOUNTERID_Sortedstatus");
            Ddo_view_ne_encounterid_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_VIEW_NE_ENCOUNTERID_Includefilter"));
            Ddo_view_ne_encounterid_Filtertype = cgiGet( "DDO_VIEW_NE_ENCOUNTERID_Filtertype");
            Ddo_view_ne_encounterid_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_VIEW_NE_ENCOUNTERID_Filterisrange"));
            Ddo_view_ne_encounterid_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_VIEW_NE_ENCOUNTERID_Includedatalist"));
            Ddo_view_ne_encounterid_Sortasc = cgiGet( "DDO_VIEW_NE_ENCOUNTERID_Sortasc");
            Ddo_view_ne_encounterid_Sortdsc = cgiGet( "DDO_VIEW_NE_ENCOUNTERID_Sortdsc");
            Ddo_view_ne_encounterid_Cleanfilter = cgiGet( "DDO_VIEW_NE_ENCOUNTERID_Cleanfilter");
            Ddo_view_ne_encounterid_Rangefilterfrom = cgiGet( "DDO_VIEW_NE_ENCOUNTERID_Rangefilterfrom");
            Ddo_view_ne_encounterid_Rangefilterto = cgiGet( "DDO_VIEW_NE_ENCOUNTERID_Rangefilterto");
            Ddo_view_ne_encounterid_Searchbuttontext = cgiGet( "DDO_VIEW_NE_ENCOUNTERID_Searchbuttontext");
            Ddo_view_ne_status_Caption = cgiGet( "DDO_VIEW_NE_STATUS_Caption");
            Ddo_view_ne_status_Tooltip = cgiGet( "DDO_VIEW_NE_STATUS_Tooltip");
            Ddo_view_ne_status_Cls = cgiGet( "DDO_VIEW_NE_STATUS_Cls");
            Ddo_view_ne_status_Selectedvalue_set = cgiGet( "DDO_VIEW_NE_STATUS_Selectedvalue_set");
            Ddo_view_ne_status_Dropdownoptionstype = cgiGet( "DDO_VIEW_NE_STATUS_Dropdownoptionstype");
            Ddo_view_ne_status_Titlecontrolidtoreplace = cgiGet( "DDO_VIEW_NE_STATUS_Titlecontrolidtoreplace");
            Ddo_view_ne_status_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_VIEW_NE_STATUS_Includesortasc"));
            Ddo_view_ne_status_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_VIEW_NE_STATUS_Includesortdsc"));
            Ddo_view_ne_status_Sortedstatus = cgiGet( "DDO_VIEW_NE_STATUS_Sortedstatus");
            Ddo_view_ne_status_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_VIEW_NE_STATUS_Includefilter"));
            Ddo_view_ne_status_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_VIEW_NE_STATUS_Includedatalist"));
            Ddo_view_ne_status_Datalisttype = cgiGet( "DDO_VIEW_NE_STATUS_Datalisttype");
            Ddo_view_ne_status_Allowmultipleselection = StringUtil.StrToBool( cgiGet( "DDO_VIEW_NE_STATUS_Allowmultipleselection"));
            Ddo_view_ne_status_Datalistfixedvalues = cgiGet( "DDO_VIEW_NE_STATUS_Datalistfixedvalues");
            Ddo_view_ne_status_Sortasc = cgiGet( "DDO_VIEW_NE_STATUS_Sortasc");
            Ddo_view_ne_status_Sortdsc = cgiGet( "DDO_VIEW_NE_STATUS_Sortdsc");
            Ddo_view_ne_status_Cleanfilter = cgiGet( "DDO_VIEW_NE_STATUS_Cleanfilter");
            Ddo_view_ne_status_Searchbuttontext = cgiGet( "DDO_VIEW_NE_STATUS_Searchbuttontext");
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( "GRID_Rows"), ".", ","));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            Gridpaginationbar_Selectedpage = cgiGet( "GRIDPAGINATIONBAR_Selectedpage");
            Gridpaginationbar_Rowsperpageselectedvalue = (int)(context.localUtil.CToN( cgiGet( "GRIDPAGINATIONBAR_Rowsperpageselectedvalue"), ".", ","));
            Ddo_view_ne_encounterid_Activeeventkey = cgiGet( "DDO_VIEW_NE_ENCOUNTERID_Activeeventkey");
            Ddo_view_ne_encounterid_Filteredtext_get = cgiGet( "DDO_VIEW_NE_ENCOUNTERID_Filteredtext_get");
            Ddo_view_ne_encounterid_Filteredtextto_get = cgiGet( "DDO_VIEW_NE_ENCOUNTERID_Filteredtextto_get");
            Ddo_view_ne_status_Activeeventkey = cgiGet( "DDO_VIEW_NE_STATUS_Activeeventkey");
            Ddo_view_ne_status_Selectedvalue_get = cgiGet( "DDO_VIEW_NE_STATUS_Selectedvalue_get");
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vSTEST"), ".", ",") != Convert.ToDecimal( AV72stest )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vORDEREDBY"), ".", ",") != Convert.ToDecimal( AV13OrderedBy )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( StringUtil.StrToBool( cgiGet( "GXH_vORDEREDDSC")) != AV14OrderedDsc )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFVIEW_NE_ENCOUNTERID"), ".", ",") != Convert.ToDecimal( AV17TFview_NE_EncounterID )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFVIEW_NE_ENCOUNTERID_TO"), ".", ",") != Convert.ToDecimal( AV18TFview_NE_EncounterID_To )) )
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
         E16AF2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E16AF2( )
      {
         /* Start Routine */
         subGrid_Rows = 9;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         edtavTfview_ne_encounterid_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfview_ne_encounterid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfview_ne_encounterid_Visible), 5, 0)), true);
         edtavTfview_ne_encounterid_to_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfview_ne_encounterid_to_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfview_ne_encounterid_to_Visible), 5, 0)), true);
         Ddo_view_ne_encounterid_Titlecontrolidtoreplace = subGrid_Internalname+"_view_NE_EncounterID";
         ucDdo_view_ne_encounterid.SendProperty(context, "", false, Ddo_view_ne_encounterid_Internalname, "TitleControlIdToReplace", Ddo_view_ne_encounterid_Titlecontrolidtoreplace);
         AV19ddo_view_NE_EncounterIDTitleControlIdToReplace = Ddo_view_ne_encounterid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19ddo_view_NE_EncounterIDTitleControlIdToReplace", AV19ddo_view_NE_EncounterIDTitleControlIdToReplace);
         edtavDdo_view_ne_encounteridtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_view_ne_encounteridtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_view_ne_encounteridtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_view_ne_status_Titlecontrolidtoreplace = subGrid_Internalname+"_view_NE_Status";
         ucDdo_view_ne_status.SendProperty(context, "", false, Ddo_view_ne_status_Internalname, "TitleControlIdToReplace", Ddo_view_ne_status_Titlecontrolidtoreplace);
         AV37ddo_view_NE_StatusTitleControlIdToReplace = Ddo_view_ne_status_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV37ddo_view_NE_StatusTitleControlIdToReplace", AV37ddo_view_NE_StatusTitleControlIdToReplace);
         edtavDdo_view_ne_statustitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_view_ne_statustitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_view_ne_statustitlecontrolidtoreplace_Visible), 5, 0)), true);
         Form.Caption = " View_New_Encounter";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption, true);
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
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavOrderedby_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavOrderedby_Visible), 5, 0)), true);
         if ( AV13OrderedBy < 1 )
         {
            AV13OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            /* Execute user subroutine: 'SETDDOSORTEDSTATUS' */
            S132 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
         }
         edtavOrdereddsc_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavOrdereddsc_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavOrdereddsc_Visible), 5, 0)), true);
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 = AV62DDO_TitleSettingsIcons;
         new GeneXus.Programs.wwpbaseobjects.getwwptitlesettingsicons(context ).execute( out  GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1) ;
         AV62DDO_TitleSettingsIcons = GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1;
         Gridpaginationbar_Rowsperpageselectedvalue = subGrid_Rows;
         ucGridpaginationbar.SendProperty(context, "", false, Gridpaginationbar_Internalname, "RowsPerPageSelectedValue", StringUtil.LTrim( StringUtil.Str( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0)));
      }

      protected void E17AF2( )
      {
         if ( gx_refresh_fired )
         {
            return  ;
         }
         gx_refresh_fired = true;
         /* Refresh Routine */
         AV16view_NE_EncounterIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV34view_NE_StatusTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV6WWPContext) ;
         /* Execute user subroutine: 'SAVEGRIDSTATE' */
         S142 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         edtview_NE_EncounterID_Titleformat = 2;
         edtview_NE_EncounterID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "view_NE_Encounter ID", AV19ddo_view_NE_EncounterIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtview_NE_EncounterID_Internalname, "Title", edtview_NE_EncounterID_Title, !bGXsfl_35_Refreshing);
         cmbview_NE_Status_Titleformat = 2;
         cmbview_NE_Status.Title.Text = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "view_NE_Status", AV37ddo_view_NE_StatusTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbview_NE_Status_Internalname, "Title", cmbview_NE_Status.Title.Text, !bGXsfl_35_Refreshing);
         AV64GridCurrentPage = subGrid_Currentpage( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV64GridCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV64GridCurrentPage), 10, 0)));
         AV65GridPageSize = subGrid_Rows;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV65GridPageSize", StringUtil.LTrim( StringUtil.Str( (decimal)(AV65GridPageSize), 10, 0)));
         AV66GridRecordCount = subGrid_Recordcount( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV66GridRecordCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV66GridRecordCount), 10, 0)));
         AV75webpanel5DS_1_Tfview_ne_encounterid = AV17TFview_NE_EncounterID;
         AV76webpanel5DS_2_Tfview_ne_encounterid_to = AV18TFview_NE_EncounterID_To;
         AV77webpanel5DS_3_Tfview_ne_status_sels = AV36TFview_NE_Status_Sels;
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16view_NE_EncounterIDTitleFilterData", AV16view_NE_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34view_NE_StatusTitleFilterData", AV34view_NE_StatusTitleFilterData);
      }

      protected void E11AF2( )
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
            AV63PageToGo = (int)(NumberUtil.Val( Gridpaginationbar_Selectedpage, "."));
            subgrid_gotopage( AV63PageToGo) ;
         }
      }

      protected void E12AF2( )
      {
         /* Gridpaginationbar_Changerowsperpage Routine */
         subGrid_Rows = Gridpaginationbar_Rowsperpageselectedvalue;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         subgrid_firstpage( ) ;
         /*  Sending Event outputs  */
      }

      protected void E13AF2( )
      {
         /* Ddo_view_ne_encounterid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_view_ne_encounterid_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S152 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_view_ne_encounterid_Sortedstatus = "ASC";
            ucDdo_view_ne_encounterid.SendProperty(context, "", false, Ddo_view_ne_encounterid_Internalname, "SortedStatus", Ddo_view_ne_encounterid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_view_ne_encounterid_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S152 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_view_ne_encounterid_Sortedstatus = "DSC";
            ucDdo_view_ne_encounterid.SendProperty(context, "", false, Ddo_view_ne_encounterid_Internalname, "SortedStatus", Ddo_view_ne_encounterid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_view_ne_encounterid_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV17TFview_NE_EncounterID = (long)(NumberUtil.Val( Ddo_view_ne_encounterid_Filteredtext_get, "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17TFview_NE_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17TFview_NE_EncounterID), 18, 0)));
            AV18TFview_NE_EncounterID_To = (long)(NumberUtil.Val( Ddo_view_ne_encounterid_Filteredtextto_get, "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18TFview_NE_EncounterID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18TFview_NE_EncounterID_To), 18, 0)));
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16view_NE_EncounterIDTitleFilterData", AV16view_NE_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34view_NE_StatusTitleFilterData", AV34view_NE_StatusTitleFilterData);
      }

      protected void E14AF2( )
      {
         /* Ddo_view_ne_status_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_view_ne_status_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S152 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_view_ne_status_Sortedstatus = "ASC";
            ucDdo_view_ne_status.SendProperty(context, "", false, Ddo_view_ne_status_Internalname, "SortedStatus", Ddo_view_ne_status_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_view_ne_status_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S152 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_view_ne_status_Sortedstatus = "DSC";
            ucDdo_view_ne_status.SendProperty(context, "", false, Ddo_view_ne_status_Internalname, "SortedStatus", Ddo_view_ne_status_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_view_ne_status_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV35TFview_NE_Status_SelsJson = Ddo_view_ne_status_Selectedvalue_get;
            AV36TFview_NE_Status_Sels.FromJSonString(StringUtil.StringReplace( AV35TFview_NE_Status_SelsJson, "\"", ""), null);
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36TFview_NE_Status_Sels", AV36TFview_NE_Status_Sels);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV16view_NE_EncounterIDTitleFilterData", AV16view_NE_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34view_NE_StatusTitleFilterData", AV34view_NE_StatusTitleFilterData);
      }

      private void E18AF2( )
      {
         /* Grid_Load Routine */
         AV67Display = context.GetImagePath( "f11923b6-6acd-4a79-bfc0-0cfc6f3bced5", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavDisplay_Internalname, AV67Display);
         AV78Display_GXI = GXDbFile.PathToUrl( context.GetImagePath( "f11923b6-6acd-4a79-bfc0-0cfc6f3bced5", "", context.GetTheme( )));
         edtavDisplay_Tooltiptext = "œ‘ æ";
         edtavDisplay_Link = formatLink("view_new_encounter.aspx") + "?" + UrlEncode(StringUtil.RTrim("DSP")) + "," + UrlEncode("" +A549view_NE_EncounterID);
         AV68Update = context.GetImagePath( "7c63c2b9-483e-4035-b512-febf9186a274", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavUpdate_Internalname, AV68Update);
         AV79Update_GXI = GXDbFile.PathToUrl( context.GetImagePath( "7c63c2b9-483e-4035-b512-febf9186a274", "", context.GetTheme( )));
         edtavUpdate_Tooltiptext = "–ﬁ∏ƒ";
         edtavUpdate_Link = formatLink("view_new_encounter.aspx") + "?" + UrlEncode(StringUtil.RTrim("UPD")) + "," + UrlEncode("" +A549view_NE_EncounterID);
         AV69Delete = context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavDelete_Internalname, AV69Delete);
         AV80Delete_GXI = GXDbFile.PathToUrl( context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", context.GetTheme( )));
         edtavDelete_Tooltiptext = "…æ≥˝";
         edtavDelete_Link = formatLink("view_new_encounter.aspx") + "?" + UrlEncode(StringUtil.RTrim("DLT")) + "," + UrlEncode("" +A549view_NE_EncounterID);
         AV71teststatus = A553view_NE_Status;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, edtavTeststatus_Internalname, StringUtil.LTrim( StringUtil.Str( (decimal)(AV71teststatus), 4, 0)));
         /* Load Method */
         if ( wbStart != -1 )
         {
            wbStart = 35;
         }
         sendrow_352( ) ;
         GRID_nCurrentRecord = (long)(GRID_nCurrentRecord+1);
         if ( isFullAjaxMode( ) && ! bGXsfl_35_Refreshing )
         {
            context.DoAjaxLoad(35, GridRow);
         }
         /*  Sending Event outputs  */
      }

      protected void E15AF2( )
      {
         /* 'DoInsert' Routine */
         CallWebObject(formatLink("view_new_encounter.aspx") + "?" + UrlEncode(StringUtil.RTrim("INS")) + "," + UrlEncode("" +0));
         context.wjLocDisableFrm = 1;
         /*  Sending Event outputs  */
      }

      protected void S152( )
      {
         /* 'RESETDDOSORTEDSTATUS' Routine */
         Ddo_view_ne_encounterid_Sortedstatus = "";
         ucDdo_view_ne_encounterid.SendProperty(context, "", false, Ddo_view_ne_encounterid_Internalname, "SortedStatus", Ddo_view_ne_encounterid_Sortedstatus);
         Ddo_view_ne_status_Sortedstatus = "";
         ucDdo_view_ne_status.SendProperty(context, "", false, Ddo_view_ne_status_Internalname, "SortedStatus", Ddo_view_ne_status_Sortedstatus);
      }

      protected void S132( )
      {
         /* 'SETDDOSORTEDSTATUS' Routine */
         /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
         S152 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         if ( AV13OrderedBy == 1 )
         {
            Ddo_view_ne_encounterid_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_view_ne_encounterid.SendProperty(context, "", false, Ddo_view_ne_encounterid_Internalname, "SortedStatus", Ddo_view_ne_encounterid_Sortedstatus);
         }
         else if ( AV13OrderedBy == 2 )
         {
            Ddo_view_ne_status_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_view_ne_status.SendProperty(context, "", false, Ddo_view_ne_status_Internalname, "SortedStatus", Ddo_view_ne_status_Sortedstatus);
         }
      }

      protected void S122( )
      {
         /* 'LOADGRIDSTATE' Routine */
         if ( StringUtil.StrCmp(AV15Session.Get(AV81Pgmname+"GridState"), "") == 0 )
         {
            AV11GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  AV81Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         else
         {
            AV11GridState.FromXml(AV15Session.Get(AV81Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         AV13OrderedBy = AV11GridState.gxTpr_Orderedby;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
         AV14OrderedDsc = AV11GridState.gxTpr_Ordereddsc;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
         /* Execute user subroutine: 'SETDDOSORTEDSTATUS' */
         S132 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         AV82GXV1 = 1;
         while ( AV82GXV1 <= AV11GridState.gxTpr_Filtervalues.Count )
         {
            AV12GridStateFilterValue = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue)AV11GridState.gxTpr_Filtervalues.Item(AV82GXV1));
            if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFVIEW_NE_ENCOUNTERID") == 0 )
            {
               AV17TFview_NE_EncounterID = (long)(NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Value, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17TFview_NE_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV17TFview_NE_EncounterID), 18, 0)));
               AV18TFview_NE_EncounterID_To = (long)(NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Valueto, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18TFview_NE_EncounterID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18TFview_NE_EncounterID_To), 18, 0)));
               if ( ! (0==AV17TFview_NE_EncounterID) )
               {
                  Ddo_view_ne_encounterid_Filteredtext_set = StringUtil.Str( (decimal)(AV17TFview_NE_EncounterID), 18, 0);
                  ucDdo_view_ne_encounterid.SendProperty(context, "", false, Ddo_view_ne_encounterid_Internalname, "FilteredText_set", Ddo_view_ne_encounterid_Filteredtext_set);
               }
               if ( ! (0==AV18TFview_NE_EncounterID_To) )
               {
                  Ddo_view_ne_encounterid_Filteredtextto_set = StringUtil.Str( (decimal)(AV18TFview_NE_EncounterID_To), 18, 0);
                  ucDdo_view_ne_encounterid.SendProperty(context, "", false, Ddo_view_ne_encounterid_Internalname, "FilteredTextTo_set", Ddo_view_ne_encounterid_Filteredtextto_set);
               }
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFVIEW_NE_STATUS_SEL") == 0 )
            {
               AV35TFview_NE_Status_SelsJson = AV12GridStateFilterValue.gxTpr_Value;
               AV36TFview_NE_Status_Sels.FromJSonString(AV35TFview_NE_Status_SelsJson, null);
               if ( ! ( AV36TFview_NE_Status_Sels.Count == 0 ) )
               {
                  Ddo_view_ne_status_Selectedvalue_set = AV35TFview_NE_Status_SelsJson;
                  ucDdo_view_ne_status.SendProperty(context, "", false, Ddo_view_ne_status_Internalname, "SelectedValue_set", Ddo_view_ne_status_Selectedvalue_set);
               }
            }
            AV82GXV1 = (int)(AV82GXV1+1);
         }
         if ( ! String.IsNullOrEmpty(StringUtil.RTrim( StringUtil.Trim( AV11GridState.gxTpr_Pagesize))) )
         {
            subGrid_Rows = (int)(NumberUtil.Val( AV11GridState.gxTpr_Pagesize, "."));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         }
         subgrid_gotopage( AV11GridState.gxTpr_Currentpage) ;
      }

      protected void S142( )
      {
         /* 'SAVEGRIDSTATE' Routine */
         AV11GridState.FromXml(AV15Session.Get(AV81Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         AV11GridState.gxTpr_Orderedby = AV13OrderedBy;
         AV11GridState.gxTpr_Ordereddsc = AV14OrderedDsc;
         AV11GridState.gxTpr_Filtervalues.Clear();
         if ( ! ( (0==AV17TFview_NE_EncounterID) && (0==AV18TFview_NE_EncounterID_To) ) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFVIEW_NE_ENCOUNTERID";
            AV12GridStateFilterValue.gxTpr_Value = StringUtil.Str( (decimal)(AV17TFview_NE_EncounterID), 18, 0);
            AV12GridStateFilterValue.gxTpr_Valueto = StringUtil.Str( (decimal)(AV18TFview_NE_EncounterID_To), 18, 0);
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! ( AV36TFview_NE_Status_Sels.Count == 0 ) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFVIEW_NE_STATUS_SEL";
            AV12GridStateFilterValue.gxTpr_Value = AV36TFview_NE_Status_Sels.ToJSonString(false);
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         AV11GridState.gxTpr_Pagesize = StringUtil.Str( (decimal)(subGrid_Rows), 10, 0);
         AV11GridState.gxTpr_Currentpage = (short)(subGrid_Currentpage( ));
         new GeneXus.Programs.wwpbaseobjects.savegridstate(context ).execute(  AV81Pgmname+"GridState",  AV11GridState.ToXml(false, true, "WWPGridState", "DataAnalysisPlatform")) ;
      }

      protected void S112( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV9TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV9TrnContext.gxTpr_Callerobject = AV81Pgmname;
         AV9TrnContext.gxTpr_Callerondelete = true;
         AV9TrnContext.gxTpr_Callerurl = AV8HTTPRequest.ScriptName+"?"+AV8HTTPRequest.QueryString;
         AV9TrnContext.gxTpr_Transactionname = "View_New_Encounter";
         AV15Session.Set("TrnContext", AV9TrnContext.ToXml(false, true, "WWPTransactionContext", "DataAnalysisPlatform"));
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
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
         PAAF2( ) ;
         WSAF2( ) ;
         WEAF2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20196517463716", true);
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
         context.AddJavascriptSource("webpanel5.js", "?20196517463716", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         context.AddJavascriptSource("DVelop/DVPaginationBar/DVPaginationBarRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/WorkWithPlusUtilities/WorkWithPlusUtilitiesRender.js", "", false);
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_352( )
      {
         edtavDisplay_Internalname = "vDISPLAY_"+sGXsfl_35_idx;
         edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_35_idx;
         edtavDelete_Internalname = "vDELETE_"+sGXsfl_35_idx;
         edtview_NE_EncounterID_Internalname = "VIEW_NE_ENCOUNTERID_"+sGXsfl_35_idx;
         edtavTeststatus_Internalname = "vTESTSTATUS_"+sGXsfl_35_idx;
         cmbview_NE_Status_Internalname = "VIEW_NE_STATUS_"+sGXsfl_35_idx;
      }

      protected void SubsflControlProps_fel_352( )
      {
         edtavDisplay_Internalname = "vDISPLAY_"+sGXsfl_35_fel_idx;
         edtavUpdate_Internalname = "vUPDATE_"+sGXsfl_35_fel_idx;
         edtavDelete_Internalname = "vDELETE_"+sGXsfl_35_fel_idx;
         edtview_NE_EncounterID_Internalname = "VIEW_NE_ENCOUNTERID_"+sGXsfl_35_fel_idx;
         edtavTeststatus_Internalname = "vTESTSTATUS_"+sGXsfl_35_fel_idx;
         cmbview_NE_Status_Internalname = "VIEW_NE_STATUS_"+sGXsfl_35_fel_idx;
      }

      protected void sendrow_352( )
      {
         SubsflControlProps_352( ) ;
         WBAF0( ) ;
         if ( ( subGrid_Rows * 1 == 0 ) || ( nGXsfl_35_idx <= subGrid_Recordsperpage( ) * 1 ) )
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
               if ( ((int)(((nGXsfl_35_idx-1)/ (decimal)(1)) % (2))) == 0 )
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
               context.WriteHtmlText( " gxrow=\""+sGXsfl_35_idx+"\">") ;
            }
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "ActionBaseColorAttribute";
            StyleString = "";
            AV67Display_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV67Display))&&String.IsNullOrEmpty(StringUtil.RTrim( AV78Display_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV67Display)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV67Display)) ? AV78Display_GXI : context.PathToRelativeUrl( AV67Display));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavDisplay_Internalname,(String)sImgUrl,(String)edtavDisplay_Link,(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)edtavDisplay_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV67Display_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "ActionBaseColorAttribute";
            StyleString = "";
            AV68Update_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV68Update))&&String.IsNullOrEmpty(StringUtil.RTrim( AV79Update_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV68Update)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV68Update)) ? AV79Update_GXI : context.PathToRelativeUrl( AV68Update));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavUpdate_Internalname,(String)sImgUrl,(String)edtavUpdate_Link,(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)edtavUpdate_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV68Update_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Static Bitmap Variable */
            ClassString = "DeleteAttribute ActionBaseColorAttribute";
            StyleString = "";
            AV69Delete_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV69Delete))&&String.IsNullOrEmpty(StringUtil.RTrim( AV80Delete_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV69Delete)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV69Delete)) ? AV80Delete_GXI : context.PathToRelativeUrl( AV69Delete));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavDelete_Internalname,(String)sImgUrl,(String)edtavDelete_Link,(String)"",(String)"",context.GetTheme( ),(short)-1,(short)1,(String)"",(String)edtavDelete_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV69Delete_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtview_NE_EncounterID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A549view_NE_EncounterID), 18, 0, ".", "")),context.localUtil.Format( (decimal)(A549view_NE_EncounterID), "ZZZZZZZZZZZZZZZZZ9"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtview_NE_EncounterID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)35,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtavTeststatus_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(AV71teststatus), 4, 0, ".", "")),((edtavTeststatus_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV71teststatus), "ZZZ9")) : context.localUtil.Format( (decimal)(AV71teststatus), "ZZZ9")),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtavTeststatus_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(int)edtavTeststatus_Enabled,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)35,(short)1,(short)-1,(short)0,(bool)true,(String)"",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            if ( ( cmbview_NE_Status.ItemCount == 0 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "VIEW_NE_STATUS_" + sGXsfl_35_idx;
               cmbview_NE_Status.Name = GXCCtl;
               cmbview_NE_Status.WebTags = "";
               if ( cmbview_NE_Status.ItemCount > 0 )
               {
                  A553view_NE_Status = (short)(NumberUtil.Val( cmbview_NE_Status.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A553view_NE_Status), 4, 0))), "."));
                  n553view_NE_Status = false;
               }
            }
            /* ComboBox */
            GridRow.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbview_NE_Status,(String)cmbview_NE_Status_Internalname,StringUtil.Trim( StringUtil.Str( (decimal)(A553view_NE_Status), 4, 0)),(short)1,(String)cmbview_NE_Status_Jsonclick,(short)0,(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"int",(String)"",(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)"",(String)"Attribute",(String)"WWColumn hidden-xs",(String)"",(String)"",(String)"",(bool)true});
            cmbview_NE_Status.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A553view_NE_Status), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbview_NE_Status_Internalname, "Values", (String)(cmbview_NE_Status.ToJavascriptSource()), !bGXsfl_35_Refreshing);
            send_integrity_lvl_hashesAF2( ) ;
            GridContainer.AddRow(GridRow);
            nGXsfl_35_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_35_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_35_idx+1));
            sGXsfl_35_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_35_idx), 4, 0)), 4, "0");
            SubsflControlProps_352( ) ;
         }
         /* End function sendrow_352 */
      }

      protected void init_web_controls( )
      {
         GXCCtl = "VIEW_NE_STATUS_" + sGXsfl_35_idx;
         cmbview_NE_Status.Name = GXCCtl;
         cmbview_NE_Status.WebTags = "";
         if ( cmbview_NE_Status.ItemCount > 0 )
         {
            A553view_NE_Status = (short)(NumberUtil.Val( cmbview_NE_Status.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A553view_NE_Status), 4, 0))), "."));
            n553view_NE_Status = false;
         }
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         bttBtninsert_Internalname = "BTNINSERT";
         edtavStest_Internalname = "vSTEST";
         divTableactions_Internalname = "TABLEACTIONS";
         divTableheader_Internalname = "TABLEHEADER";
         divLayout_tableheader_Internalname = "LAYOUT_TABLEHEADER";
         Dvpanel_tableheader_Internalname = "DVPANEL_TABLEHEADER";
         divHtml_dvpanel_tableheader_Internalname = "HTML_DVPANEL_TABLEHEADER";
         edtavDisplay_Internalname = "vDISPLAY";
         edtavUpdate_Internalname = "vUPDATE";
         edtavDelete_Internalname = "vDELETE";
         edtview_NE_EncounterID_Internalname = "VIEW_NE_ENCOUNTERID";
         edtavTeststatus_Internalname = "vTESTSTATUS";
         cmbview_NE_Status_Internalname = "VIEW_NE_STATUS";
         Gridpaginationbar_Internalname = "GRIDPAGINATIONBAR";
         divHtml_gridpaginationbar_Internalname = "HTML_GRIDPAGINATIONBAR";
         divGridtablewithpaginationbar_Internalname = "GRIDTABLEWITHPAGINATIONBAR";
         divTablemain_Internalname = "TABLEMAIN";
         Ddo_view_ne_encounterid_Internalname = "DDO_VIEW_NE_ENCOUNTERID";
         edtavDdo_view_ne_encounteridtitlecontrolidtoreplace_Internalname = "vDDO_VIEW_NE_ENCOUNTERIDTITLECONTROLIDTOREPLACE";
         Ddo_view_ne_status_Internalname = "DDO_VIEW_NE_STATUS";
         edtavDdo_view_ne_statustitlecontrolidtoreplace_Internalname = "vDDO_VIEW_NE_STATUSTITLECONTROLIDTOREPLACE";
         Workwithplusutilities1_Internalname = "WORKWITHPLUSUTILITIES1";
         edtavOrderedby_Internalname = "vORDEREDBY";
         edtavOrdereddsc_Internalname = "vORDEREDDSC";
         edtavTfview_ne_encounterid_Internalname = "vTFVIEW_NE_ENCOUNTERID";
         edtavTfview_ne_encounterid_to_Internalname = "vTFVIEW_NE_ENCOUNTERID_TO";
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
         cmbview_NE_Status_Jsonclick = "";
         edtavTeststatus_Jsonclick = "";
         edtview_NE_EncounterID_Jsonclick = "";
         edtavTfview_ne_encounterid_to_Jsonclick = "";
         edtavTfview_ne_encounterid_to_Visible = 1;
         edtavTfview_ne_encounterid_Jsonclick = "";
         edtavTfview_ne_encounterid_Visible = 1;
         edtavOrdereddsc_Jsonclick = "";
         edtavOrdereddsc_Visible = 1;
         edtavOrderedby_Jsonclick = "";
         edtavOrderedby_Visible = 1;
         edtavDdo_view_ne_statustitlecontrolidtoreplace_Visible = 1;
         edtavDdo_view_ne_encounteridtitlecontrolidtoreplace_Visible = 1;
         subGrid_Allowcollapsing = 0;
         subGrid_Allowselection = 0;
         edtavDelete_Tooltiptext = "…æ≥˝";
         edtavDelete_Link = "";
         edtavUpdate_Tooltiptext = "–ﬁ∏ƒ";
         edtavUpdate_Link = "";
         edtavDisplay_Tooltiptext = "œ‘ æ";
         edtavDisplay_Link = "";
         subGrid_Sortable = 0;
         subGrid_Header = "";
         cmbview_NE_Status_Titleformat = 0;
         cmbview_NE_Status.Title.Text = "view_NE_Status";
         edtavTeststatus_Enabled = 0;
         edtview_NE_EncounterID_Titleformat = 0;
         edtview_NE_EncounterID_Title = "view_NE_Encounter ID";
         subGrid_Class = "GridWithPaginationBar GridWithBorderColor WorkWith";
         subGrid_Backcolorstyle = 0;
         edtavStest_Jsonclick = "";
         edtavStest_Enabled = 1;
         Ddo_view_ne_status_Searchbuttontext = "WWP_FilterSelected";
         Ddo_view_ne_status_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_view_ne_status_Sortdsc = "WWP_TSSortDSC";
         Ddo_view_ne_status_Sortasc = "WWP_TSSortASC";
         Ddo_view_ne_status_Datalistfixedvalues = "";
         Ddo_view_ne_status_Allowmultipleselection = Convert.ToBoolean( -1);
         Ddo_view_ne_status_Datalisttype = "FixedValues";
         Ddo_view_ne_status_Includedatalist = Convert.ToBoolean( -1);
         Ddo_view_ne_status_Includefilter = Convert.ToBoolean( 0);
         Ddo_view_ne_status_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_view_ne_status_Includesortasc = Convert.ToBoolean( -1);
         Ddo_view_ne_status_Titlecontrolidtoreplace = "";
         Ddo_view_ne_status_Dropdownoptionstype = "GridTitleSettings";
         Ddo_view_ne_status_Cls = "ColumnSettings";
         Ddo_view_ne_status_Tooltip = "WWP_TSColumnOptions";
         Ddo_view_ne_status_Caption = "";
         Ddo_view_ne_encounterid_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_view_ne_encounterid_Rangefilterto = "WWP_TSTo";
         Ddo_view_ne_encounterid_Rangefilterfrom = "WWP_TSFrom";
         Ddo_view_ne_encounterid_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_view_ne_encounterid_Sortdsc = "WWP_TSSortDSC";
         Ddo_view_ne_encounterid_Sortasc = "WWP_TSSortASC";
         Ddo_view_ne_encounterid_Includedatalist = Convert.ToBoolean( 0);
         Ddo_view_ne_encounterid_Filterisrange = Convert.ToBoolean( -1);
         Ddo_view_ne_encounterid_Filtertype = "Numeric";
         Ddo_view_ne_encounterid_Includefilter = Convert.ToBoolean( -1);
         Ddo_view_ne_encounterid_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_view_ne_encounterid_Includesortasc = Convert.ToBoolean( -1);
         Ddo_view_ne_encounterid_Titlecontrolidtoreplace = "";
         Ddo_view_ne_encounterid_Dropdownoptionstype = "GridTitleSettings";
         Ddo_view_ne_encounterid_Cls = "ColumnSettings";
         Ddo_view_ne_encounterid_Tooltip = "WWP_TSColumnOptions";
         Ddo_view_ne_encounterid_Caption = "";
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
         Gridpaginationbar_Caption = "<CURRENT_PAGE>“≥/<TOTAL_PAGES>“≥ º«¬º£∫<TOTAL_RECORDS>Ãı";
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
         Dvpanel_tableheader_Title = "—°œÓ";
         Dvpanel_tableheader_Cls = "PanelNoHeader";
         Dvpanel_tableheader_Width = "100%";
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "webpanel5";
         subGrid_Rows = 0;
         context.GX_msglist.DisplayMode = 1;
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV72stest',fld:'vSTEST',pic:'ZZZ9'},{av:'AV19ddo_view_NE_EncounterIDTitleControlIdToReplace',fld:'vDDO_VIEW_NE_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_view_NE_StatusTitleControlIdToReplace',fld:'vDDO_VIEW_NE_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV17TFview_NE_EncounterID',fld:'vTFVIEW_NE_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZ9'},{av:'AV18TFview_NE_EncounterID_To',fld:'vTFVIEW_NE_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZ9'},{av:'AV36TFview_NE_Status_Sels',fld:'vTFVIEW_NE_STATUS_SELS',pic:''},{av:'AV81Pgmname',fld:'vPGMNAME',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''}]");
         setEventMetadata("REFRESH",",oparms:[{av:'AV16view_NE_EncounterIDTitleFilterData',fld:'vVIEW_NE_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV34view_NE_StatusTitleFilterData',fld:'vVIEW_NE_STATUSTITLEFILTERDATA',pic:''},{av:'edtview_NE_EncounterID_Titleformat',ctrl:'VIEW_NE_ENCOUNTERID',prop:'Titleformat'},{av:'edtview_NE_EncounterID_Title',ctrl:'VIEW_NE_ENCOUNTERID',prop:'Title'},{av:'cmbview_NE_Status'},{av:'AV64GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV65GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV66GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE","{handler:'E11AF2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV72stest',fld:'vSTEST',pic:'ZZZ9'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFview_NE_EncounterID',fld:'vTFVIEW_NE_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZ9'},{av:'AV18TFview_NE_EncounterID_To',fld:'vTFVIEW_NE_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZ9'},{av:'AV19ddo_view_NE_EncounterIDTitleControlIdToReplace',fld:'vDDO_VIEW_NE_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_view_NE_StatusTitleControlIdToReplace',fld:'vDDO_VIEW_NE_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV36TFview_NE_Status_Sels',fld:'vTFVIEW_NE_STATUS_SELS',pic:''},{av:'AV81Pgmname',fld:'vPGMNAME',pic:''},{av:'Gridpaginationbar_Selectedpage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE",",oparms:[]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE","{handler:'E12AF2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV72stest',fld:'vSTEST',pic:'ZZZ9'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFview_NE_EncounterID',fld:'vTFVIEW_NE_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZ9'},{av:'AV18TFview_NE_EncounterID_To',fld:'vTFVIEW_NE_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZ9'},{av:'AV19ddo_view_NE_EncounterIDTitleControlIdToReplace',fld:'vDDO_VIEW_NE_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_view_NE_StatusTitleControlIdToReplace',fld:'vDDO_VIEW_NE_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV36TFview_NE_Status_Sels',fld:'vTFVIEW_NE_STATUS_SELS',pic:''},{av:'AV81Pgmname',fld:'vPGMNAME',pic:''},{av:'Gridpaginationbar_Rowsperpageselectedvalue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE",",oparms:[{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]}");
         setEventMetadata("DDO_VIEW_NE_ENCOUNTERID.ONOPTIONCLICKED","{handler:'E13AF2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV72stest',fld:'vSTEST',pic:'ZZZ9'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFview_NE_EncounterID',fld:'vTFVIEW_NE_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZ9'},{av:'AV18TFview_NE_EncounterID_To',fld:'vTFVIEW_NE_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZ9'},{av:'AV19ddo_view_NE_EncounterIDTitleControlIdToReplace',fld:'vDDO_VIEW_NE_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_view_NE_StatusTitleControlIdToReplace',fld:'vDDO_VIEW_NE_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV36TFview_NE_Status_Sels',fld:'vTFVIEW_NE_STATUS_SELS',pic:''},{av:'AV81Pgmname',fld:'vPGMNAME',pic:''},{av:'Ddo_view_ne_encounterid_Activeeventkey',ctrl:'DDO_VIEW_NE_ENCOUNTERID',prop:'ActiveEventKey'},{av:'Ddo_view_ne_encounterid_Filteredtext_get',ctrl:'DDO_VIEW_NE_ENCOUNTERID',prop:'FilteredText_get'},{av:'Ddo_view_ne_encounterid_Filteredtextto_get',ctrl:'DDO_VIEW_NE_ENCOUNTERID',prop:'FilteredTextTo_get'}]");
         setEventMetadata("DDO_VIEW_NE_ENCOUNTERID.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_view_ne_encounterid_Sortedstatus',ctrl:'DDO_VIEW_NE_ENCOUNTERID',prop:'SortedStatus'},{av:'AV17TFview_NE_EncounterID',fld:'vTFVIEW_NE_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZ9'},{av:'AV18TFview_NE_EncounterID_To',fld:'vTFVIEW_NE_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZ9'},{av:'Ddo_view_ne_status_Sortedstatus',ctrl:'DDO_VIEW_NE_STATUS',prop:'SortedStatus'},{av:'AV16view_NE_EncounterIDTitleFilterData',fld:'vVIEW_NE_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV34view_NE_StatusTitleFilterData',fld:'vVIEW_NE_STATUSTITLEFILTERDATA',pic:''},{av:'edtview_NE_EncounterID_Titleformat',ctrl:'VIEW_NE_ENCOUNTERID',prop:'Titleformat'},{av:'edtview_NE_EncounterID_Title',ctrl:'VIEW_NE_ENCOUNTERID',prop:'Title'},{av:'cmbview_NE_Status'},{av:'AV64GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV65GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV66GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_VIEW_NE_STATUS.ONOPTIONCLICKED","{handler:'E14AF2',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV72stest',fld:'vSTEST',pic:'ZZZ9'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV17TFview_NE_EncounterID',fld:'vTFVIEW_NE_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZ9'},{av:'AV18TFview_NE_EncounterID_To',fld:'vTFVIEW_NE_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZ9'},{av:'AV19ddo_view_NE_EncounterIDTitleControlIdToReplace',fld:'vDDO_VIEW_NE_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_view_NE_StatusTitleControlIdToReplace',fld:'vDDO_VIEW_NE_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV36TFview_NE_Status_Sels',fld:'vTFVIEW_NE_STATUS_SELS',pic:''},{av:'AV81Pgmname',fld:'vPGMNAME',pic:''},{av:'Ddo_view_ne_status_Activeeventkey',ctrl:'DDO_VIEW_NE_STATUS',prop:'ActiveEventKey'},{av:'Ddo_view_ne_status_Selectedvalue_get',ctrl:'DDO_VIEW_NE_STATUS',prop:'SelectedValue_get'}]");
         setEventMetadata("DDO_VIEW_NE_STATUS.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_view_ne_status_Sortedstatus',ctrl:'DDO_VIEW_NE_STATUS',prop:'SortedStatus'},{av:'AV36TFview_NE_Status_Sels',fld:'vTFVIEW_NE_STATUS_SELS',pic:''},{av:'Ddo_view_ne_encounterid_Sortedstatus',ctrl:'DDO_VIEW_NE_ENCOUNTERID',prop:'SortedStatus'},{av:'AV16view_NE_EncounterIDTitleFilterData',fld:'vVIEW_NE_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV34view_NE_StatusTitleFilterData',fld:'vVIEW_NE_STATUSTITLEFILTERDATA',pic:''},{av:'edtview_NE_EncounterID_Titleformat',ctrl:'VIEW_NE_ENCOUNTERID',prop:'Titleformat'},{av:'edtview_NE_EncounterID_Title',ctrl:'VIEW_NE_ENCOUNTERID',prop:'Title'},{av:'cmbview_NE_Status'},{av:'AV64GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV65GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV66GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("GRID.LOAD","{handler:'E18AF2',iparms:[{av:'A549view_NE_EncounterID',fld:'VIEW_NE_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZ9'},{av:'cmbview_NE_Status'},{av:'A553view_NE_Status',fld:'VIEW_NE_STATUS',pic:'ZZZ9'}]");
         setEventMetadata("GRID.LOAD",",oparms:[{av:'AV67Display',fld:'vDISPLAY',pic:''},{av:'edtavDisplay_Tooltiptext',ctrl:'vDISPLAY',prop:'Tooltiptext'},{av:'edtavDisplay_Link',ctrl:'vDISPLAY',prop:'Link'},{av:'AV68Update',fld:'vUPDATE',pic:''},{av:'edtavUpdate_Tooltiptext',ctrl:'vUPDATE',prop:'Tooltiptext'},{av:'edtavUpdate_Link',ctrl:'vUPDATE',prop:'Link'},{av:'AV69Delete',fld:'vDELETE',pic:''},{av:'edtavDelete_Tooltiptext',ctrl:'vDELETE',prop:'Tooltiptext'},{av:'edtavDelete_Link',ctrl:'vDELETE',prop:'Link'},{av:'AV71teststatus',fld:'vTESTSTATUS',pic:'ZZZ9'}]}");
         setEventMetadata("'DOINSERT'","{handler:'E15AF2',iparms:[{av:'A549view_NE_EncounterID',fld:'VIEW_NE_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZ9'}]");
         setEventMetadata("'DOINSERT'",",oparms:[{av:'A549view_NE_EncounterID',fld:'VIEW_NE_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZ9'}]}");
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
         Ddo_view_ne_encounterid_Activeeventkey = "";
         Ddo_view_ne_encounterid_Filteredtext_get = "";
         Ddo_view_ne_encounterid_Filteredtextto_get = "";
         Ddo_view_ne_status_Activeeventkey = "";
         Ddo_view_ne_status_Selectedvalue_get = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV19ddo_view_NE_EncounterIDTitleControlIdToReplace = "";
         AV37ddo_view_NE_StatusTitleControlIdToReplace = "";
         AV36TFview_NE_Status_Sels = new GxSimpleCollection<short>();
         AV81Pgmname = "";
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         AV62DDO_TitleSettingsIcons = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV16view_NE_EncounterIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV34view_NE_StatusTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         Ddo_view_ne_encounterid_Filteredtext_set = "";
         Ddo_view_ne_encounterid_Filteredtextto_set = "";
         Ddo_view_ne_encounterid_Sortedstatus = "";
         Ddo_view_ne_status_Selectedvalue_set = "";
         Ddo_view_ne_status_Sortedstatus = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         ucDvpanel_tableheader = new GXUserControl();
         TempTags = "";
         ClassString = "";
         StyleString = "";
         bttBtninsert_Jsonclick = "";
         GridContainer = new GXWebGrid( context);
         sStyleString = "";
         subGrid_Linesclass = "";
         GridColumn = new GXWebColumn();
         AV67Display = "";
         AV68Update = "";
         AV69Delete = "";
         ucGridpaginationbar = new GXUserControl();
         ucDdo_view_ne_encounterid = new GXUserControl();
         ucDdo_view_ne_status = new GXUserControl();
         ucWorkwithplusutilities1 = new GXUserControl();
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV78Display_GXI = "";
         AV79Update_GXI = "";
         AV80Delete_GXI = "";
         AV77webpanel5DS_3_Tfview_ne_status_sels = new GxSimpleCollection<short>();
         scmdbuf = "";
         H00AF2_A553view_NE_Status = new short[1] ;
         H00AF2_n553view_NE_Status = new bool[] {false} ;
         H00AF2_A549view_NE_EncounterID = new long[1] ;
         H00AF3_AGRID_nRecordCount = new long[1] ;
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV6WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         AV35TFview_NE_Status_SelsJson = "";
         GridRow = new GXWebRow();
         AV15Session = context.GetSession();
         AV11GridState = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState(context);
         AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
         AV9TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV8HTTPRequest = new GxHttpRequest( context);
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sImgUrl = "";
         ROClassString = "";
         GXCCtl = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.webpanel5__default(),
            new Object[][] {
                new Object[] {
               H00AF2_A553view_NE_Status, H00AF2_n553view_NE_Status, H00AF2_A549view_NE_EncounterID
               }
               , new Object[] {
               H00AF3_AGRID_nRecordCount
               }
            }
         );
         AV81Pgmname = "webpanel5";
         /* GeneXus formulas. */
         AV81Pgmname = "webpanel5";
         context.Gx_err = 0;
         edtavTeststatus_Enabled = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_GXsfl_35 ;
      private short nGXsfl_35_idx=1 ;
      private short GRID_nEOF ;
      private short AV72stest ;
      private short AV13OrderedBy ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short subGrid_Backcolorstyle ;
      private short subGrid_Titlebackstyle ;
      private short edtview_NE_EncounterID_Titleformat ;
      private short cmbview_NE_Status_Titleformat ;
      private short subGrid_Sortable ;
      private short AV71teststatus ;
      private short A553view_NE_Status ;
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
      private int edtavStest_Enabled ;
      private int subGrid_Titlebackcolor ;
      private int subGrid_Allbackcolor ;
      private int edtavTeststatus_Enabled ;
      private int subGrid_Selectedindex ;
      private int subGrid_Selectioncolor ;
      private int subGrid_Hoveringcolor ;
      private int edtavDdo_view_ne_encounteridtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_view_ne_statustitlecontrolidtoreplace_Visible ;
      private int edtavOrderedby_Visible ;
      private int edtavOrdereddsc_Visible ;
      private int edtavTfview_ne_encounterid_Visible ;
      private int edtavTfview_ne_encounterid_to_Visible ;
      private int subGrid_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int AV77webpanel5DS_3_Tfview_ne_status_sels_Count ;
      private int AV63PageToGo ;
      private int AV82GXV1 ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private long GRID_nFirstRecordOnPage ;
      private long AV17TFview_NE_EncounterID ;
      private long AV18TFview_NE_EncounterID_To ;
      private long AV64GridCurrentPage ;
      private long AV66GridRecordCount ;
      private long AV65GridPageSize ;
      private long A549view_NE_EncounterID ;
      private long GRID_nCurrentRecord ;
      private long AV75webpanel5DS_1_Tfview_ne_encounterid ;
      private long AV76webpanel5DS_2_Tfview_ne_encounterid_to ;
      private long GRID_nRecordCount ;
      private String Gridpaginationbar_Selectedpage ;
      private String Ddo_view_ne_encounterid_Activeeventkey ;
      private String Ddo_view_ne_encounterid_Filteredtext_get ;
      private String Ddo_view_ne_encounterid_Filteredtextto_get ;
      private String Ddo_view_ne_status_Activeeventkey ;
      private String Ddo_view_ne_status_Selectedvalue_get ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_35_idx="0001" ;
      private String AV81Pgmname ;
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
      private String Ddo_view_ne_encounterid_Caption ;
      private String Ddo_view_ne_encounterid_Tooltip ;
      private String Ddo_view_ne_encounterid_Cls ;
      private String Ddo_view_ne_encounterid_Filteredtext_set ;
      private String Ddo_view_ne_encounterid_Filteredtextto_set ;
      private String Ddo_view_ne_encounterid_Dropdownoptionstype ;
      private String Ddo_view_ne_encounterid_Titlecontrolidtoreplace ;
      private String Ddo_view_ne_encounterid_Sortedstatus ;
      private String Ddo_view_ne_encounterid_Filtertype ;
      private String Ddo_view_ne_encounterid_Sortasc ;
      private String Ddo_view_ne_encounterid_Sortdsc ;
      private String Ddo_view_ne_encounterid_Cleanfilter ;
      private String Ddo_view_ne_encounterid_Rangefilterfrom ;
      private String Ddo_view_ne_encounterid_Rangefilterto ;
      private String Ddo_view_ne_encounterid_Searchbuttontext ;
      private String Ddo_view_ne_status_Caption ;
      private String Ddo_view_ne_status_Tooltip ;
      private String Ddo_view_ne_status_Cls ;
      private String Ddo_view_ne_status_Selectedvalue_set ;
      private String Ddo_view_ne_status_Dropdownoptionstype ;
      private String Ddo_view_ne_status_Titlecontrolidtoreplace ;
      private String Ddo_view_ne_status_Sortedstatus ;
      private String Ddo_view_ne_status_Datalisttype ;
      private String Ddo_view_ne_status_Datalistfixedvalues ;
      private String Ddo_view_ne_status_Sortasc ;
      private String Ddo_view_ne_status_Sortdsc ;
      private String Ddo_view_ne_status_Cleanfilter ;
      private String Ddo_view_ne_status_Searchbuttontext ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divLayoutmaintable_Internalname ;
      private String divTablemain_Internalname ;
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
      private String edtavStest_Internalname ;
      private String edtavStest_Jsonclick ;
      private String divGridtablewithpaginationbar_Internalname ;
      private String sStyleString ;
      private String subGrid_Internalname ;
      private String subGrid_Class ;
      private String subGrid_Linesclass ;
      private String edtview_NE_EncounterID_Title ;
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
      private String Ddo_view_ne_encounterid_Internalname ;
      private String edtavDdo_view_ne_encounteridtitlecontrolidtoreplace_Internalname ;
      private String Ddo_view_ne_status_Internalname ;
      private String edtavDdo_view_ne_statustitlecontrolidtoreplace_Internalname ;
      private String Workwithplusutilities1_Internalname ;
      private String edtavOrderedby_Internalname ;
      private String edtavOrderedby_Jsonclick ;
      private String edtavOrdereddsc_Internalname ;
      private String edtavOrdereddsc_Jsonclick ;
      private String edtavTfview_ne_encounterid_Internalname ;
      private String edtavTfview_ne_encounterid_Jsonclick ;
      private String edtavTfview_ne_encounterid_to_Internalname ;
      private String edtavTfview_ne_encounterid_to_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavDisplay_Internalname ;
      private String edtavUpdate_Internalname ;
      private String edtavDelete_Internalname ;
      private String edtview_NE_EncounterID_Internalname ;
      private String edtavTeststatus_Internalname ;
      private String cmbview_NE_Status_Internalname ;
      private String scmdbuf ;
      private String sGXsfl_35_fel_idx="0001" ;
      private String sImgUrl ;
      private String ROClassString ;
      private String edtview_NE_EncounterID_Jsonclick ;
      private String edtavTeststatus_Jsonclick ;
      private String GXCCtl ;
      private String cmbview_NE_Status_Jsonclick ;
      private bool entryPointCalled ;
      private bool AV14OrderedDsc ;
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
      private bool Ddo_view_ne_encounterid_Includesortasc ;
      private bool Ddo_view_ne_encounterid_Includesortdsc ;
      private bool Ddo_view_ne_encounterid_Includefilter ;
      private bool Ddo_view_ne_encounterid_Filterisrange ;
      private bool Ddo_view_ne_encounterid_Includedatalist ;
      private bool Ddo_view_ne_status_Includesortasc ;
      private bool Ddo_view_ne_status_Includesortdsc ;
      private bool Ddo_view_ne_status_Includefilter ;
      private bool Ddo_view_ne_status_Includedatalist ;
      private bool Ddo_view_ne_status_Allowmultipleselection ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_35_Refreshing=false ;
      private bool n553view_NE_Status ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool gx_refresh_fired ;
      private bool AV67Display_IsBlob ;
      private bool AV68Update_IsBlob ;
      private bool AV69Delete_IsBlob ;
      private String AV35TFview_NE_Status_SelsJson ;
      private String AV19ddo_view_NE_EncounterIDTitleControlIdToReplace ;
      private String AV37ddo_view_NE_StatusTitleControlIdToReplace ;
      private String AV78Display_GXI ;
      private String AV79Update_GXI ;
      private String AV80Delete_GXI ;
      private String AV67Display ;
      private String AV68Update ;
      private String AV69Delete ;
      private GxSimpleCollection<short> AV36TFview_NE_Status_Sels ;
      private GxSimpleCollection<short> AV77webpanel5DS_3_Tfview_ne_status_sels ;
      private IGxSession AV15Session ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private GXUserControl ucDvpanel_tableheader ;
      private GXUserControl ucGridpaginationbar ;
      private GXUserControl ucDdo_view_ne_encounterid ;
      private GXUserControl ucDdo_view_ne_status ;
      private GXUserControl ucWorkwithplusutilities1 ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbview_NE_Status ;
      private IDataStoreProvider pr_default ;
      private short[] H00AF2_A553view_NE_Status ;
      private bool[] H00AF2_n553view_NE_Status ;
      private long[] H00AF2_A549view_NE_EncounterID ;
      private long[] H00AF3_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV8HTTPRequest ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV16view_NE_EncounterIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV34view_NE_StatusTitleFilterData ;
      private GXWebForm Form ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV9TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV11GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue AV12GridStateFilterValue ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons AV62DDO_TitleSettingsIcons ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 ;
   }

   public class webpanel5__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H00AF2( IGxContext context ,
                                             short A553view_NE_Status ,
                                             GxSimpleCollection<short> AV77webpanel5DS_3_Tfview_ne_status_sels ,
                                             long AV75webpanel5DS_1_Tfview_ne_encounterid ,
                                             long AV76webpanel5DS_2_Tfview_ne_encounterid_to ,
                                             int AV77webpanel5DS_3_Tfview_ne_status_sels_Count ,
                                             short AV72stest ,
                                             long A549view_NE_EncounterID ,
                                             short AV13OrderedBy ,
                                             bool AV14OrderedDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int2 ;
         GXv_int2 = new short [6] ;
         Object[] GXv_Object3 ;
         GXv_Object3 = new Object [2] ;
         String sSelectString ;
         String sFromString ;
         String sOrderString ;
         sSelectString = " [view_NE_Status], [view_NE_EncounterID]";
         sFromString = " FROM dbo.[View_New_Encounter] WITH (NOLOCK)";
         sOrderString = "";
         if ( ! (0==AV75webpanel5DS_1_Tfview_ne_encounterid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_EncounterID] >= @AV75webpanel5DS_1_Tfview_ne_encounterid)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_EncounterID] >= @AV75webpanel5DS_1_Tfview_ne_encounterid)";
            }
         }
         else
         {
            GXv_int2[0] = 1;
         }
         if ( ! (0==AV76webpanel5DS_2_Tfview_ne_encounterid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_EncounterID] <= @AV76webpanel5DS_2_Tfview_ne_encounterid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_EncounterID] <= @AV76webpanel5DS_2_Tfview_ne_encounterid_to)";
            }
         }
         else
         {
            GXv_int2[1] = 1;
         }
         if ( AV77webpanel5DS_3_Tfview_ne_status_sels_Count > 0 )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV77webpanel5DS_3_Tfview_ne_status_sels, "[view_NE_Status] IN (", ")") + ")";
            }
            else
            {
               sWhereString = sWhereString + " (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV77webpanel5DS_3_Tfview_ne_status_sels, "[view_NE_Status] IN (", ")") + ")";
            }
         }
         if ( ! (0==AV72stest) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (RTRIM(LTRIM(CONVERT( char(4), CAST([view_NE_Status] AS decimal(4,0))))) = RTRIM(LTRIM(CONVERT( char(4), CAST(@AV72stest AS decimal(4,0))))))";
            }
            else
            {
               sWhereString = sWhereString + " (RTRIM(LTRIM(CONVERT( char(4), CAST([view_NE_Status] AS decimal(4,0))))) = RTRIM(LTRIM(CONVERT( char(4), CAST(@AV72stest AS decimal(4,0))))))";
            }
         }
         else
         {
            GXv_int2[2] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            sWhereString = " WHERE" + sWhereString;
         }
         if ( ( AV13OrderedBy == 1 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [view_NE_EncounterID]";
         }
         else if ( ( AV13OrderedBy == 1 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [view_NE_EncounterID] DESC";
         }
         else if ( ( AV13OrderedBy == 2 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [view_NE_Status]";
         }
         else if ( ( AV13OrderedBy == 2 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [view_NE_Status] DESC";
         }
         else if ( true )
         {
            sOrderString = sOrderString + " ORDER BY [view_NE_EncounterID]";
         }
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object3[0] = scmdbuf;
         GXv_Object3[1] = GXv_int2;
         return GXv_Object3 ;
      }

      protected Object[] conditional_H00AF3( IGxContext context ,
                                             short A553view_NE_Status ,
                                             GxSimpleCollection<short> AV77webpanel5DS_3_Tfview_ne_status_sels ,
                                             long AV75webpanel5DS_1_Tfview_ne_encounterid ,
                                             long AV76webpanel5DS_2_Tfview_ne_encounterid_to ,
                                             int AV77webpanel5DS_3_Tfview_ne_status_sels_Count ,
                                             short AV72stest ,
                                             long A549view_NE_EncounterID ,
                                             short AV13OrderedBy ,
                                             bool AV14OrderedDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int4 ;
         GXv_int4 = new short [3] ;
         Object[] GXv_Object5 ;
         GXv_Object5 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM dbo.[View_New_Encounter] WITH (NOLOCK)";
         if ( ! (0==AV75webpanel5DS_1_Tfview_ne_encounterid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_EncounterID] >= @AV75webpanel5DS_1_Tfview_ne_encounterid)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_EncounterID] >= @AV75webpanel5DS_1_Tfview_ne_encounterid)";
            }
         }
         else
         {
            GXv_int4[0] = 1;
         }
         if ( ! (0==AV76webpanel5DS_2_Tfview_ne_encounterid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([view_NE_EncounterID] <= @AV76webpanel5DS_2_Tfview_ne_encounterid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([view_NE_EncounterID] <= @AV76webpanel5DS_2_Tfview_ne_encounterid_to)";
            }
         }
         else
         {
            GXv_int4[1] = 1;
         }
         if ( AV77webpanel5DS_3_Tfview_ne_status_sels_Count > 0 )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV77webpanel5DS_3_Tfview_ne_status_sels, "[view_NE_Status] IN (", ")") + ")";
            }
            else
            {
               sWhereString = sWhereString + " (" + new GxDbmsUtils( new GxSqlServer()).ValueList(AV77webpanel5DS_3_Tfview_ne_status_sels, "[view_NE_Status] IN (", ")") + ")";
            }
         }
         if ( ! (0==AV72stest) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and (RTRIM(LTRIM(CONVERT( char(4), CAST([view_NE_Status] AS decimal(4,0))))) = RTRIM(LTRIM(CONVERT( char(4), CAST(@AV72stest AS decimal(4,0))))))";
            }
            else
            {
               sWhereString = sWhereString + " (RTRIM(LTRIM(CONVERT( char(4), CAST([view_NE_Status] AS decimal(4,0))))) = RTRIM(LTRIM(CONVERT( char(4), CAST(@AV72stest AS decimal(4,0))))))";
            }
         }
         else
         {
            GXv_int4[2] = 1;
         }
         if ( StringUtil.StrCmp("", sWhereString) != 0 )
         {
            scmdbuf = scmdbuf + " WHERE" + sWhereString;
         }
         if ( ( AV13OrderedBy == 1 ) && ! AV14OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 1 ) && ( AV14OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 2 ) && ! AV14OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 2 ) && ( AV14OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( true )
         {
            scmdbuf = scmdbuf + "";
         }
         GXv_Object5[0] = scmdbuf;
         GXv_Object5[1] = GXv_int4;
         return GXv_Object5 ;
      }

      public override Object [] getDynamicStatement( int cursor ,
                                                     IGxContext context ,
                                                     Object [] dynConstraints )
      {
         switch ( cursor )
         {
               case 0 :
                     return conditional_H00AF2(context, (short)dynConstraints[0] , (GxSimpleCollection<short>)dynConstraints[1] , (long)dynConstraints[2] , (long)dynConstraints[3] , (int)dynConstraints[4] , (short)dynConstraints[5] , (long)dynConstraints[6] , (short)dynConstraints[7] , (bool)dynConstraints[8] );
               case 1 :
                     return conditional_H00AF3(context, (short)dynConstraints[0] , (GxSimpleCollection<short>)dynConstraints[1] , (long)dynConstraints[2] , (long)dynConstraints[3] , (int)dynConstraints[4] , (short)dynConstraints[5] , (long)dynConstraints[6] , (short)dynConstraints[7] , (bool)dynConstraints[8] );
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
          Object[] prmH00AF2 ;
          prmH00AF2 = new Object[] {
          new Object[] {"@AV75webpanel5DS_1_Tfview_ne_encounterid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV76webpanel5DS_2_Tfview_ne_encounterid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV72stest",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH00AF3 ;
          prmH00AF3 = new Object[] {
          new Object[] {"@AV75webpanel5DS_1_Tfview_ne_encounterid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV76webpanel5DS_2_Tfview_ne_encounterid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV72stest",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H00AF2", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00AF2,11,0,true,false )
             ,new CursorDef("H00AF3", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00AF3,1,0,true,false )
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
                ((long[]) buf[2])[0] = rslt.getLong(2) ;
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
                   stmt.SetParameter(sIdx, (long)parms[7]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[8]);
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
                   stmt.SetParameter(sIdx, (long)parms[4]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (short)parms[5]);
                }
                return;
       }
    }

 }

}
