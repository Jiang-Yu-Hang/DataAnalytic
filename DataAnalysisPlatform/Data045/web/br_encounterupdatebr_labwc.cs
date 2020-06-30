/*
               File: BR_EncounterUpdateBR_LabWC
        Description: Data Mgmt Portal - RAAP
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/28/2020 15:6:50.33
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
   public class br_encounterupdatebr_labwc : GXWebComponent, System.Web.SessionState.IRequiresSessionState
   {
      public br_encounterupdatebr_labwc( )
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

      public br_encounterupdatebr_labwc( IGxContext context )
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
                  AV8BR_EncounterID = (long)(NumberUtil.Val( GetNextPar( ), "."));
                  AV18ddo_BR_LabIDTitleControlIdToReplace = GetNextPar( );
                  AV24ddo_BR_Lab_TestNameTitleControlIdToReplace = GetNextPar( );
                  AV28ddo_BR_Lab_SpecimenSourceTitleControlIdToReplace = GetNextPar( );
                  AV26ddo_BR_Lab_SpecimenDateTitleControlIdToReplace = GetNextPar( );
                  AV40ddo_BR_Lab_AbnIndTitleControlIdToReplace = GetNextPar( );
                  AV90Pgmname = GetNextPar( );
                  AV64IsAuthorized_Display = StringUtil.StrToBool( GetNextPar( ));
                  AV62IsAuthorized_Delete = StringUtil.StrToBool( GetNextPar( ));
                  sPrefix = GetNextPar( );
                  init_default_properties( ) ;
                  setAjaxCallMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1;
                     return  ;
                  }
                  gxgrGrid_refresh( subGrid_Rows, AV14OrderedBy, AV15OrderedDsc, AV8BR_EncounterID, AV18ddo_BR_LabIDTitleControlIdToReplace, AV24ddo_BR_Lab_TestNameTitleControlIdToReplace, AV28ddo_BR_Lab_SpecimenSourceTitleControlIdToReplace, AV26ddo_BR_Lab_SpecimenDateTitleControlIdToReplace, AV40ddo_BR_Lab_AbnIndTitleControlIdToReplace, AV90Pgmname, AV64IsAuthorized_Display, AV62IsAuthorized_Delete, sPrefix) ;
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
            PA262( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV90Pgmname = "BR_EncounterUpdateBR_LabWC";
               context.Gx_err = 0;
               WS262( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?20202281565056", false);
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
            context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_encounterupdatebr_labwc.aspx") + "?" + UrlEncode("" +AV8BR_EncounterID)+"\">") ;
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
         GxWebStd.gx_hidden_field( context, sPrefix+"nRC_GXsfl_28", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_28), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"vGRIDCURRENTPAGE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV56GridCurrentPage), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"vGRIDPAGECOUNT", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV84GridPageCount), 10, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, sPrefix+"vDDO_TITLESETTINGSICONS", AV53DDO_TitleSettingsIcons);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(sPrefix+"vDDO_TITLESETTINGSICONS", AV53DDO_TitleSettingsIcons);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, sPrefix+"vBR_LABIDTITLEFILTERDATA", AV17BR_LabIDTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(sPrefix+"vBR_LABIDTITLEFILTERDATA", AV17BR_LabIDTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, sPrefix+"vBR_LAB_TESTNAMETITLEFILTERDATA", AV23BR_Lab_TestNameTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(sPrefix+"vBR_LAB_TESTNAMETITLEFILTERDATA", AV23BR_Lab_TestNameTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, sPrefix+"vBR_LAB_SPECIMENSOURCETITLEFILTERDATA", AV27BR_Lab_SpecimenSourceTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(sPrefix+"vBR_LAB_SPECIMENSOURCETITLEFILTERDATA", AV27BR_Lab_SpecimenSourceTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, sPrefix+"vBR_LAB_SPECIMENDATETITLEFILTERDATA", AV25BR_Lab_SpecimenDateTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(sPrefix+"vBR_LAB_SPECIMENDATETITLEFILTERDATA", AV25BR_Lab_SpecimenDateTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, sPrefix+"vBR_LAB_ABNINDTITLEFILTERDATA", AV39BR_Lab_AbnIndTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(sPrefix+"vBR_LAB_ABNINDTITLEFILTERDATA", AV39BR_Lab_AbnIndTitleFilterData);
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOAV8BR_EncounterID", StringUtil.LTrim( StringUtil.NToC( (decimal)(wcpOAV8BR_EncounterID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"vPGMNAME", StringUtil.RTrim( AV90Pgmname));
         GxWebStd.gx_boolean_hidden_field( context, sPrefix+"vISAUTHORIZED_DISPLAY", AV64IsAuthorized_Display);
         GxWebStd.gx_boolean_hidden_field( context, sPrefix+"vISAUTHORIZED_DELETE", AV62IsAuthorized_Delete);
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
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_LABID_Caption", StringUtil.RTrim( Ddo_br_labid_Caption));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_LABID_Tooltip", StringUtil.RTrim( Ddo_br_labid_Tooltip));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_LABID_Cls", StringUtil.RTrim( Ddo_br_labid_Cls));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_LABID_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_labid_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_LABID_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_labid_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_LABID_Includesortasc", StringUtil.BoolToStr( Ddo_br_labid_Includesortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_LABID_Includesortdsc", StringUtil.BoolToStr( Ddo_br_labid_Includesortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_LABID_Sortedstatus", StringUtil.RTrim( Ddo_br_labid_Sortedstatus));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_LABID_Includefilter", StringUtil.BoolToStr( Ddo_br_labid_Includefilter));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_LABID_Includedatalist", StringUtil.BoolToStr( Ddo_br_labid_Includedatalist));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_LABID_Sortasc", StringUtil.RTrim( Ddo_br_labid_Sortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_LABID_Sortdsc", StringUtil.RTrim( Ddo_br_labid_Sortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_LABID_Searchbuttontext", StringUtil.RTrim( Ddo_br_labid_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_LAB_TESTNAME_Caption", StringUtil.RTrim( Ddo_br_lab_testname_Caption));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_LAB_TESTNAME_Tooltip", StringUtil.RTrim( Ddo_br_lab_testname_Tooltip));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_LAB_TESTNAME_Cls", StringUtil.RTrim( Ddo_br_lab_testname_Cls));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_LAB_TESTNAME_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_lab_testname_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_LAB_TESTNAME_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_lab_testname_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_LAB_TESTNAME_Includesortasc", StringUtil.BoolToStr( Ddo_br_lab_testname_Includesortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_LAB_TESTNAME_Includesortdsc", StringUtil.BoolToStr( Ddo_br_lab_testname_Includesortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_LAB_TESTNAME_Sortedstatus", StringUtil.RTrim( Ddo_br_lab_testname_Sortedstatus));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_LAB_TESTNAME_Includefilter", StringUtil.BoolToStr( Ddo_br_lab_testname_Includefilter));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_LAB_TESTNAME_Includedatalist", StringUtil.BoolToStr( Ddo_br_lab_testname_Includedatalist));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_LAB_TESTNAME_Sortasc", StringUtil.RTrim( Ddo_br_lab_testname_Sortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_LAB_TESTNAME_Sortdsc", StringUtil.RTrim( Ddo_br_lab_testname_Sortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_LAB_TESTNAME_Searchbuttontext", StringUtil.RTrim( Ddo_br_lab_testname_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_LAB_SPECIMENSOURCE_Caption", StringUtil.RTrim( Ddo_br_lab_specimensource_Caption));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_LAB_SPECIMENSOURCE_Tooltip", StringUtil.RTrim( Ddo_br_lab_specimensource_Tooltip));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_LAB_SPECIMENSOURCE_Cls", StringUtil.RTrim( Ddo_br_lab_specimensource_Cls));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_LAB_SPECIMENSOURCE_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_lab_specimensource_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_LAB_SPECIMENSOURCE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_lab_specimensource_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_LAB_SPECIMENSOURCE_Includesortasc", StringUtil.BoolToStr( Ddo_br_lab_specimensource_Includesortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_LAB_SPECIMENSOURCE_Includesortdsc", StringUtil.BoolToStr( Ddo_br_lab_specimensource_Includesortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_LAB_SPECIMENSOURCE_Sortedstatus", StringUtil.RTrim( Ddo_br_lab_specimensource_Sortedstatus));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_LAB_SPECIMENSOURCE_Includefilter", StringUtil.BoolToStr( Ddo_br_lab_specimensource_Includefilter));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_LAB_SPECIMENSOURCE_Includedatalist", StringUtil.BoolToStr( Ddo_br_lab_specimensource_Includedatalist));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_LAB_SPECIMENSOURCE_Sortasc", StringUtil.RTrim( Ddo_br_lab_specimensource_Sortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_LAB_SPECIMENSOURCE_Sortdsc", StringUtil.RTrim( Ddo_br_lab_specimensource_Sortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_LAB_SPECIMENSOURCE_Searchbuttontext", StringUtil.RTrim( Ddo_br_lab_specimensource_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_LAB_SPECIMENDATE_Caption", StringUtil.RTrim( Ddo_br_lab_specimendate_Caption));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_LAB_SPECIMENDATE_Tooltip", StringUtil.RTrim( Ddo_br_lab_specimendate_Tooltip));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_LAB_SPECIMENDATE_Cls", StringUtil.RTrim( Ddo_br_lab_specimendate_Cls));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_LAB_SPECIMENDATE_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_lab_specimendate_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_LAB_SPECIMENDATE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_lab_specimendate_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_LAB_SPECIMENDATE_Includesortasc", StringUtil.BoolToStr( Ddo_br_lab_specimendate_Includesortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_LAB_SPECIMENDATE_Includesortdsc", StringUtil.BoolToStr( Ddo_br_lab_specimendate_Includesortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_LAB_SPECIMENDATE_Sortedstatus", StringUtil.RTrim( Ddo_br_lab_specimendate_Sortedstatus));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_LAB_SPECIMENDATE_Includefilter", StringUtil.BoolToStr( Ddo_br_lab_specimendate_Includefilter));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_LAB_SPECIMENDATE_Includedatalist", StringUtil.BoolToStr( Ddo_br_lab_specimendate_Includedatalist));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_LAB_SPECIMENDATE_Sortasc", StringUtil.RTrim( Ddo_br_lab_specimendate_Sortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_LAB_SPECIMENDATE_Sortdsc", StringUtil.RTrim( Ddo_br_lab_specimendate_Sortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_LAB_SPECIMENDATE_Searchbuttontext", StringUtil.RTrim( Ddo_br_lab_specimendate_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_LAB_ABNIND_Caption", StringUtil.RTrim( Ddo_br_lab_abnind_Caption));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_LAB_ABNIND_Tooltip", StringUtil.RTrim( Ddo_br_lab_abnind_Tooltip));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_LAB_ABNIND_Cls", StringUtil.RTrim( Ddo_br_lab_abnind_Cls));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_LAB_ABNIND_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_lab_abnind_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_LAB_ABNIND_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_lab_abnind_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_LAB_ABNIND_Includesortasc", StringUtil.BoolToStr( Ddo_br_lab_abnind_Includesortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_LAB_ABNIND_Includesortdsc", StringUtil.BoolToStr( Ddo_br_lab_abnind_Includesortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_LAB_ABNIND_Sortedstatus", StringUtil.RTrim( Ddo_br_lab_abnind_Sortedstatus));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_LAB_ABNIND_Includefilter", StringUtil.BoolToStr( Ddo_br_lab_abnind_Includefilter));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_LAB_ABNIND_Includedatalist", StringUtil.BoolToStr( Ddo_br_lab_abnind_Includedatalist));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_LAB_ABNIND_Sortasc", StringUtil.RTrim( Ddo_br_lab_abnind_Sortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_LAB_ABNIND_Sortdsc", StringUtil.RTrim( Ddo_br_lab_abnind_Sortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_LAB_ABNIND_Searchbuttontext", StringUtil.RTrim( Ddo_br_lab_abnind_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_LABID_Activeeventkey", StringUtil.RTrim( Ddo_br_labid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_LAB_TESTNAME_Activeeventkey", StringUtil.RTrim( Ddo_br_lab_testname_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_LAB_SPECIMENSOURCE_Activeeventkey", StringUtil.RTrim( Ddo_br_lab_specimensource_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_LAB_SPECIMENDATE_Activeeventkey", StringUtil.RTrim( Ddo_br_lab_specimendate_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_LAB_ABNIND_Activeeventkey", StringUtil.RTrim( Ddo_br_lab_abnind_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_LABID_Activeeventkey", StringUtil.RTrim( Ddo_br_labid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_LAB_TESTNAME_Activeeventkey", StringUtil.RTrim( Ddo_br_lab_testname_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_LAB_SPECIMENSOURCE_Activeeventkey", StringUtil.RTrim( Ddo_br_lab_specimensource_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_LAB_SPECIMENDATE_Activeeventkey", StringUtil.RTrim( Ddo_br_lab_specimendate_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_LAB_ABNIND_Activeeventkey", StringUtil.RTrim( Ddo_br_lab_abnind_Activeeventkey));
      }

      protected void RenderHtmlCloseForm262( )
      {
         SendCloseFormHiddens( ) ;
         if ( ( StringUtil.Len( sPrefix) != 0 ) && ( context.isAjaxRequest( ) || context.isSpaRequest( ) ) )
         {
            context.AddJavascriptSource("br_encounterupdatebr_labwc.js", "?20202281565328", false);
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
         return "BR_EncounterUpdateBR_LabWC" ;
      }

      public override String GetPgmdesc( )
      {
         return "Data Mgmt Portal - RAAP" ;
      }

      protected void WB260( )
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
               GxWebStd.gx_hidden_field( context, sPrefix+"_CMPPGM", "br_encounterupdatebr_labwc.aspx");
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
            ClassString = "Button ButtonColor";
            StyleString = "";
            GxWebStd.gx_button_ctrl( context, bttBtninsert_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(28), 2, 0)+","+"null"+");", "新增", bttBtninsert_Jsonclick, 5, "插入", "", StyleString, ClassString, bttBtninsert_Visible, 1, "standard", "'"+sPrefix+"'"+",false,"+"'"+sPrefix+"E\\'DOINSERT\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_EncounterUpdateBR_LabWC.htm");
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
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"ActionBaseColorAttribute"+"\" "+" style=\""+((edtavBack_Visible==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"DeleteAttribute ActionBaseColorAttribute"+"\" "+" style=\""+((edtavDelete_Visible==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_LabID_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_LabID_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_LabID_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Lab_TestName_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Lab_TestName_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Lab_TestName_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Lab_SpecimenSource_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Lab_SpecimenSource_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Lab_SpecimenSource_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Lab_SpecimenDate_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Lab_SpecimenDate_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Lab_SpecimenDate_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Lab_AbnInd_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Lab_AbnInd_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Lab_AbnInd_Title) ;
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
               GridColumn.AddObjectProperty("Value", context.convertURL( AV63Display));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavDisplay_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavDisplay_Tooltiptext));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavDisplay_Visible), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.convertURL( AV80back));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavBack_Tooltiptext));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavBack_Visible), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.convertURL( AV61Delete));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavDelete_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavDelete_Tooltiptext));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavDelete_Visible), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A101BR_LabID), 18, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_LabID_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_LabID_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A104BR_Lab_TestName);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Lab_TestName_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Lab_TestName_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A106BR_Lab_SpecimenSource);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Lab_SpecimenSource_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Lab_SpecimenSource_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.localUtil.TToC( A105BR_Lab_SpecimenDate, 10, 8, 0, 0, "/", ":", " "));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Lab_SpecimenDate_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Lab_SpecimenDate_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A112BR_Lab_AbnInd);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Lab_AbnInd_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Lab_AbnInd_Titleformat), 4, 0, ".", "")));
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
            ucGridpaginationbar.SetProperty("CurrentPage", AV56GridCurrentPage);
            ucGridpaginationbar.SetProperty("PageCount", AV84GridPageCount);
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
            ucDdo_br_labid.SetProperty("Caption", Ddo_br_labid_Caption);
            ucDdo_br_labid.SetProperty("Tooltip", Ddo_br_labid_Tooltip);
            ucDdo_br_labid.SetProperty("Cls", Ddo_br_labid_Cls);
            ucDdo_br_labid.SetProperty("DropDownOptionsType", Ddo_br_labid_Dropdownoptionstype);
            ucDdo_br_labid.SetProperty("IncludeSortASC", Ddo_br_labid_Includesortasc);
            ucDdo_br_labid.SetProperty("IncludeSortDSC", Ddo_br_labid_Includesortdsc);
            ucDdo_br_labid.SetProperty("IncludeFilter", Ddo_br_labid_Includefilter);
            ucDdo_br_labid.SetProperty("IncludeDataList", Ddo_br_labid_Includedatalist);
            ucDdo_br_labid.SetProperty("SortASC", Ddo_br_labid_Sortasc);
            ucDdo_br_labid.SetProperty("SortDSC", Ddo_br_labid_Sortdsc);
            ucDdo_br_labid.SetProperty("SearchButtonText", Ddo_br_labid_Searchbuttontext);
            ucDdo_br_labid.SetProperty("DropDownOptionsTitleSettingsIcons", AV53DDO_TitleSettingsIcons);
            ucDdo_br_labid.SetProperty("DropDownOptionsData", AV17BR_LabIDTitleFilterData);
            ucDdo_br_labid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_labid_Internalname, sPrefix+"DDO_BR_LABIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 45,'" + sPrefix + "',false,'" + sGXsfl_28_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_labidtitlecontrolidtoreplace_Internalname, AV18ddo_BR_LabIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,45);\"", 0, edtavDdo_br_labidtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_EncounterUpdateBR_LabWC.htm");
            /* User Defined Control */
            ucDdo_br_lab_testname.SetProperty("Caption", Ddo_br_lab_testname_Caption);
            ucDdo_br_lab_testname.SetProperty("Tooltip", Ddo_br_lab_testname_Tooltip);
            ucDdo_br_lab_testname.SetProperty("Cls", Ddo_br_lab_testname_Cls);
            ucDdo_br_lab_testname.SetProperty("DropDownOptionsType", Ddo_br_lab_testname_Dropdownoptionstype);
            ucDdo_br_lab_testname.SetProperty("IncludeSortASC", Ddo_br_lab_testname_Includesortasc);
            ucDdo_br_lab_testname.SetProperty("IncludeSortDSC", Ddo_br_lab_testname_Includesortdsc);
            ucDdo_br_lab_testname.SetProperty("IncludeFilter", Ddo_br_lab_testname_Includefilter);
            ucDdo_br_lab_testname.SetProperty("IncludeDataList", Ddo_br_lab_testname_Includedatalist);
            ucDdo_br_lab_testname.SetProperty("SortASC", Ddo_br_lab_testname_Sortasc);
            ucDdo_br_lab_testname.SetProperty("SortDSC", Ddo_br_lab_testname_Sortdsc);
            ucDdo_br_lab_testname.SetProperty("SearchButtonText", Ddo_br_lab_testname_Searchbuttontext);
            ucDdo_br_lab_testname.SetProperty("DropDownOptionsTitleSettingsIcons", AV53DDO_TitleSettingsIcons);
            ucDdo_br_lab_testname.SetProperty("DropDownOptionsData", AV23BR_Lab_TestNameTitleFilterData);
            ucDdo_br_lab_testname.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_lab_testname_Internalname, sPrefix+"DDO_BR_LAB_TESTNAMEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 47,'" + sPrefix + "',false,'" + sGXsfl_28_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_lab_testnametitlecontrolidtoreplace_Internalname, AV24ddo_BR_Lab_TestNameTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,47);\"", 0, edtavDdo_br_lab_testnametitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_EncounterUpdateBR_LabWC.htm");
            /* User Defined Control */
            ucDdo_br_lab_specimensource.SetProperty("Caption", Ddo_br_lab_specimensource_Caption);
            ucDdo_br_lab_specimensource.SetProperty("Tooltip", Ddo_br_lab_specimensource_Tooltip);
            ucDdo_br_lab_specimensource.SetProperty("Cls", Ddo_br_lab_specimensource_Cls);
            ucDdo_br_lab_specimensource.SetProperty("DropDownOptionsType", Ddo_br_lab_specimensource_Dropdownoptionstype);
            ucDdo_br_lab_specimensource.SetProperty("IncludeSortASC", Ddo_br_lab_specimensource_Includesortasc);
            ucDdo_br_lab_specimensource.SetProperty("IncludeSortDSC", Ddo_br_lab_specimensource_Includesortdsc);
            ucDdo_br_lab_specimensource.SetProperty("IncludeFilter", Ddo_br_lab_specimensource_Includefilter);
            ucDdo_br_lab_specimensource.SetProperty("IncludeDataList", Ddo_br_lab_specimensource_Includedatalist);
            ucDdo_br_lab_specimensource.SetProperty("SortASC", Ddo_br_lab_specimensource_Sortasc);
            ucDdo_br_lab_specimensource.SetProperty("SortDSC", Ddo_br_lab_specimensource_Sortdsc);
            ucDdo_br_lab_specimensource.SetProperty("SearchButtonText", Ddo_br_lab_specimensource_Searchbuttontext);
            ucDdo_br_lab_specimensource.SetProperty("DropDownOptionsTitleSettingsIcons", AV53DDO_TitleSettingsIcons);
            ucDdo_br_lab_specimensource.SetProperty("DropDownOptionsData", AV27BR_Lab_SpecimenSourceTitleFilterData);
            ucDdo_br_lab_specimensource.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_lab_specimensource_Internalname, sPrefix+"DDO_BR_LAB_SPECIMENSOURCEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 49,'" + sPrefix + "',false,'" + sGXsfl_28_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_lab_specimensourcetitlecontrolidtoreplace_Internalname, AV28ddo_BR_Lab_SpecimenSourceTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,49);\"", 0, edtavDdo_br_lab_specimensourcetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_EncounterUpdateBR_LabWC.htm");
            /* User Defined Control */
            ucDdo_br_lab_specimendate.SetProperty("Caption", Ddo_br_lab_specimendate_Caption);
            ucDdo_br_lab_specimendate.SetProperty("Tooltip", Ddo_br_lab_specimendate_Tooltip);
            ucDdo_br_lab_specimendate.SetProperty("Cls", Ddo_br_lab_specimendate_Cls);
            ucDdo_br_lab_specimendate.SetProperty("DropDownOptionsType", Ddo_br_lab_specimendate_Dropdownoptionstype);
            ucDdo_br_lab_specimendate.SetProperty("IncludeSortASC", Ddo_br_lab_specimendate_Includesortasc);
            ucDdo_br_lab_specimendate.SetProperty("IncludeSortDSC", Ddo_br_lab_specimendate_Includesortdsc);
            ucDdo_br_lab_specimendate.SetProperty("IncludeFilter", Ddo_br_lab_specimendate_Includefilter);
            ucDdo_br_lab_specimendate.SetProperty("IncludeDataList", Ddo_br_lab_specimendate_Includedatalist);
            ucDdo_br_lab_specimendate.SetProperty("SortASC", Ddo_br_lab_specimendate_Sortasc);
            ucDdo_br_lab_specimendate.SetProperty("SortDSC", Ddo_br_lab_specimendate_Sortdsc);
            ucDdo_br_lab_specimendate.SetProperty("SearchButtonText", Ddo_br_lab_specimendate_Searchbuttontext);
            ucDdo_br_lab_specimendate.SetProperty("DropDownOptionsTitleSettingsIcons", AV53DDO_TitleSettingsIcons);
            ucDdo_br_lab_specimendate.SetProperty("DropDownOptionsData", AV25BR_Lab_SpecimenDateTitleFilterData);
            ucDdo_br_lab_specimendate.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_lab_specimendate_Internalname, sPrefix+"DDO_BR_LAB_SPECIMENDATEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 51,'" + sPrefix + "',false,'" + sGXsfl_28_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_lab_specimendatetitlecontrolidtoreplace_Internalname, AV26ddo_BR_Lab_SpecimenDateTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,51);\"", 0, edtavDdo_br_lab_specimendatetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_EncounterUpdateBR_LabWC.htm");
            /* User Defined Control */
            ucDdo_br_lab_abnind.SetProperty("Caption", Ddo_br_lab_abnind_Caption);
            ucDdo_br_lab_abnind.SetProperty("Tooltip", Ddo_br_lab_abnind_Tooltip);
            ucDdo_br_lab_abnind.SetProperty("Cls", Ddo_br_lab_abnind_Cls);
            ucDdo_br_lab_abnind.SetProperty("DropDownOptionsType", Ddo_br_lab_abnind_Dropdownoptionstype);
            ucDdo_br_lab_abnind.SetProperty("IncludeSortASC", Ddo_br_lab_abnind_Includesortasc);
            ucDdo_br_lab_abnind.SetProperty("IncludeSortDSC", Ddo_br_lab_abnind_Includesortdsc);
            ucDdo_br_lab_abnind.SetProperty("IncludeFilter", Ddo_br_lab_abnind_Includefilter);
            ucDdo_br_lab_abnind.SetProperty("IncludeDataList", Ddo_br_lab_abnind_Includedatalist);
            ucDdo_br_lab_abnind.SetProperty("SortASC", Ddo_br_lab_abnind_Sortasc);
            ucDdo_br_lab_abnind.SetProperty("SortDSC", Ddo_br_lab_abnind_Sortdsc);
            ucDdo_br_lab_abnind.SetProperty("SearchButtonText", Ddo_br_lab_abnind_Searchbuttontext);
            ucDdo_br_lab_abnind.SetProperty("DropDownOptionsTitleSettingsIcons", AV53DDO_TitleSettingsIcons);
            ucDdo_br_lab_abnind.SetProperty("DropDownOptionsData", AV39BR_Lab_AbnIndTitleFilterData);
            ucDdo_br_lab_abnind.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_lab_abnind_Internalname, sPrefix+"DDO_BR_LAB_ABNINDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'" + sPrefix + "',false,'" + sGXsfl_28_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_lab_abnindtitlecontrolidtoreplace_Internalname, AV40ddo_BR_Lab_AbnIndTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,53);\"", 0, edtavDdo_br_lab_abnindtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_EncounterUpdateBR_LabWC.htm");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_EncounterID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A19BR_EncounterID), 18, 0, ".", "")), context.localUtil.Format( (decimal)(A19BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ"), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_EncounterID_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_EncounterID_Visible, 0, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "HLP_BR_EncounterUpdateBR_LabWC.htm");
            /* User Defined Control */
            ucWorkwithplusutilities1.Render(context, "dvelop.workwithplusutilities", Workwithplusutilities1_Internalname, sPrefix+"WORKWITHPLUSUTILITIES1Container");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 56,'" + sPrefix + "',false,'" + sGXsfl_28_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrderedby_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV14OrderedBy), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV14OrderedBy), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,56);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrderedby_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrderedby_Visible, 1, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_EncounterUpdateBR_LabWC.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 57,'" + sPrefix + "',false,'" + sGXsfl_28_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrdereddsc_Internalname, StringUtil.BoolToStr( AV15OrderedDsc), StringUtil.BoolToStr( AV15OrderedDsc), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,57);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrdereddsc_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrdereddsc_Visible, 1, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, 0, 0, true, "", "right", false, "HLP_BR_EncounterUpdateBR_LabWC.htm");
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

      protected void START262( )
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
               STRUP260( ) ;
            }
         }
      }

      protected void WS262( )
      {
         START262( ) ;
         EVT262( ) ;
      }

      protected void EVT262( )
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
                                 STRUP260( ) ;
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
                                 STRUP260( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    E11262 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEROWSPERPAGE") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP260( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    E12262 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_LABID.ONOPTIONCLICKED") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP260( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    E13262 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_LAB_TESTNAME.ONOPTIONCLICKED") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP260( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    E14262 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_LAB_SPECIMENSOURCE.ONOPTIONCLICKED") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP260( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    E15262 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_LAB_SPECIMENDATE.ONOPTIONCLICKED") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP260( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    E16262 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_LAB_ABNIND.ONOPTIONCLICKED") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP260( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    E17262 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'DOINSERT'") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP260( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: 'DoInsert' */
                                    E18262 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP260( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    GX_FocusControl = edtavDdo_br_labidtitlecontrolidtoreplace_Internalname;
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
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 7), "REFRESH") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 9), "GRID.LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 11), "VBACK.CLICK") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 13), "VDELETE.CLICK") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 11), "VBACK.CLICK") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 13), "VDELETE.CLICK") == 0 ) )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP260( ) ;
                              }
                              nGXsfl_28_idx = (short)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_28_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_28_idx), 4, 0)), 4, "0");
                              SubsflControlProps_282( ) ;
                              AV63Display = cgiGet( edtavDisplay_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDisplay_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV63Display)) ? AV87Display_GXI : context.convertURL( context.PathToRelativeUrl( AV63Display))), !bGXsfl_28_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDisplay_Internalname, "SrcSet", context.GetImageSrcSet( AV63Display), true);
                              AV80back = cgiGet( edtavBack_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavBack_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV80back)) ? AV88Back_GXI : context.convertURL( context.PathToRelativeUrl( AV80back))), !bGXsfl_28_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavBack_Internalname, "SrcSet", context.GetImageSrcSet( AV80back), true);
                              AV61Delete = cgiGet( edtavDelete_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDelete_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV61Delete)) ? AV89Delete_GXI : context.convertURL( context.PathToRelativeUrl( AV61Delete))), !bGXsfl_28_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDelete_Internalname, "SrcSet", context.GetImageSrcSet( AV61Delete), true);
                              A101BR_LabID = (long)(context.localUtil.CToN( cgiGet( edtBR_LabID_Internalname), ".", ","));
                              A104BR_Lab_TestName = cgiGet( edtBR_Lab_TestName_Internalname);
                              n104BR_Lab_TestName = false;
                              A106BR_Lab_SpecimenSource = cgiGet( edtBR_Lab_SpecimenSource_Internalname);
                              n106BR_Lab_SpecimenSource = false;
                              A105BR_Lab_SpecimenDate = context.localUtil.CToT( cgiGet( edtBR_Lab_SpecimenDate_Internalname), 0);
                              n105BR_Lab_SpecimenDate = false;
                              A112BR_Lab_AbnInd = cgiGet( edtBR_Lab_AbnInd_Internalname);
                              n112BR_Lab_AbnInd = false;
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
                                          GX_FocusControl = edtavDdo_br_labidtitlecontrolidtoreplace_Internalname;
                                          context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
                                          /* Execute user event: Start */
                                          E19262 ();
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
                                          GX_FocusControl = edtavDdo_br_labidtitlecontrolidtoreplace_Internalname;
                                          context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
                                          /* Execute user event: Refresh */
                                          E20262 ();
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
                                          GX_FocusControl = edtavDdo_br_labidtitlecontrolidtoreplace_Internalname;
                                          context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
                                          E21262 ();
                                       }
                                    }
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "VBACK.CLICK") == 0 )
                                 {
                                    if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1;
                                       if ( ! wbErr )
                                       {
                                          dynload_actions( ) ;
                                          GX_FocusControl = edtavDdo_br_labidtitlecontrolidtoreplace_Internalname;
                                          context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
                                          E22262 ();
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
                                          GX_FocusControl = edtavDdo_br_labidtitlecontrolidtoreplace_Internalname;
                                          context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
                                          E23262 ();
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
                                       STRUP260( ) ;
                                    }
                                    if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1;
                                       if ( ! wbErr )
                                       {
                                          dynload_actions( ) ;
                                          GX_FocusControl = edtavDdo_br_labidtitlecontrolidtoreplace_Internalname;
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

      protected void WE262( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm262( ) ;
            }
         }
      }

      protected void PA262( )
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
               GX_FocusControl = edtavDdo_br_labidtitlecontrolidtoreplace_Internalname;
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
                                       long AV8BR_EncounterID ,
                                       String AV18ddo_BR_LabIDTitleControlIdToReplace ,
                                       String AV24ddo_BR_Lab_TestNameTitleControlIdToReplace ,
                                       String AV28ddo_BR_Lab_SpecimenSourceTitleControlIdToReplace ,
                                       String AV26ddo_BR_Lab_SpecimenDateTitleControlIdToReplace ,
                                       String AV40ddo_BR_Lab_AbnIndTitleControlIdToReplace ,
                                       String AV90Pgmname ,
                                       bool AV64IsAuthorized_Display ,
                                       bool AV62IsAuthorized_Delete ,
                                       String sPrefix )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GRID_nCurrentRecord = 0;
         RF262( ) ;
         /* End function gxgrGrid_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, sPrefix+"gxhash_BR_LABID", GetSecureSignedToken( sPrefix, context.localUtil.Format( (decimal)(A101BR_LabID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, sPrefix+"BR_LABID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A101BR_LabID), 18, 0, ".", "")));
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
         RF262( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV90Pgmname = "BR_EncounterUpdateBR_LabWC";
         context.Gx_err = 0;
      }

      protected void RF262( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridContainer.ClearRows();
         }
         wbStart = 28;
         /* Execute user event: Refresh */
         E20262 ();
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
                                                 AV14OrderedBy ,
                                                 AV15OrderedDsc ,
                                                 A19BR_EncounterID ,
                                                 AV8BR_EncounterID } ,
                                                 new int[]{
                                                 TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.LONG
                                                 }
            } ) ;
            /* Using cursor H00262 */
            pr_default.execute(0, new Object[] {AV8BR_EncounterID, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_28_idx = 1;
            sGXsfl_28_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_28_idx), 4, 0)), 4, "0");
            SubsflControlProps_282( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < subGrid_Recordsperpage( ) ) ) ) )
            {
               A19BR_EncounterID = H00262_A19BR_EncounterID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
               A112BR_Lab_AbnInd = H00262_A112BR_Lab_AbnInd[0];
               n112BR_Lab_AbnInd = H00262_n112BR_Lab_AbnInd[0];
               A105BR_Lab_SpecimenDate = H00262_A105BR_Lab_SpecimenDate[0];
               n105BR_Lab_SpecimenDate = H00262_n105BR_Lab_SpecimenDate[0];
               A106BR_Lab_SpecimenSource = H00262_A106BR_Lab_SpecimenSource[0];
               n106BR_Lab_SpecimenSource = H00262_n106BR_Lab_SpecimenSource[0];
               A104BR_Lab_TestName = H00262_A104BR_Lab_TestName[0];
               n104BR_Lab_TestName = H00262_n104BR_Lab_TestName[0];
               A101BR_LabID = H00262_A101BR_LabID[0];
               E21262 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, sPrefix+"GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 28;
            WB260( ) ;
         }
         bGXsfl_28_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes262( )
      {
         GxWebStd.gx_hidden_field( context, sPrefix+"gxhash_BR_LABID"+"_"+sGXsfl_28_idx, GetSecureSignedToken( sPrefix+sGXsfl_28_idx, context.localUtil.Format( (decimal)(A101BR_LabID), "ZZZZZZZZZZZZZZZZZZ"), context));
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
         /* Using cursor H00263 */
         pr_default.execute(1, new Object[] {AV8BR_EncounterID});
         GRID_nRecordCount = H00263_AGRID_nRecordCount[0];
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
            gxgrGrid_refresh( subGrid_Rows, AV14OrderedBy, AV15OrderedDsc, AV8BR_EncounterID, AV18ddo_BR_LabIDTitleControlIdToReplace, AV24ddo_BR_Lab_TestNameTitleControlIdToReplace, AV28ddo_BR_Lab_SpecimenSourceTitleControlIdToReplace, AV26ddo_BR_Lab_SpecimenDateTitleControlIdToReplace, AV40ddo_BR_Lab_AbnIndTitleControlIdToReplace, AV90Pgmname, AV64IsAuthorized_Display, AV62IsAuthorized_Delete, sPrefix) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV14OrderedBy, AV15OrderedDsc, AV8BR_EncounterID, AV18ddo_BR_LabIDTitleControlIdToReplace, AV24ddo_BR_Lab_TestNameTitleControlIdToReplace, AV28ddo_BR_Lab_SpecimenSourceTitleControlIdToReplace, AV26ddo_BR_Lab_SpecimenDateTitleControlIdToReplace, AV40ddo_BR_Lab_AbnIndTitleControlIdToReplace, AV90Pgmname, AV64IsAuthorized_Display, AV62IsAuthorized_Delete, sPrefix) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV14OrderedBy, AV15OrderedDsc, AV8BR_EncounterID, AV18ddo_BR_LabIDTitleControlIdToReplace, AV24ddo_BR_Lab_TestNameTitleControlIdToReplace, AV28ddo_BR_Lab_SpecimenSourceTitleControlIdToReplace, AV26ddo_BR_Lab_SpecimenDateTitleControlIdToReplace, AV40ddo_BR_Lab_AbnIndTitleControlIdToReplace, AV90Pgmname, AV64IsAuthorized_Display, AV62IsAuthorized_Delete, sPrefix) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV14OrderedBy, AV15OrderedDsc, AV8BR_EncounterID, AV18ddo_BR_LabIDTitleControlIdToReplace, AV24ddo_BR_Lab_TestNameTitleControlIdToReplace, AV28ddo_BR_Lab_SpecimenSourceTitleControlIdToReplace, AV26ddo_BR_Lab_SpecimenDateTitleControlIdToReplace, AV40ddo_BR_Lab_AbnIndTitleControlIdToReplace, AV90Pgmname, AV64IsAuthorized_Display, AV62IsAuthorized_Delete, sPrefix) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV14OrderedBy, AV15OrderedDsc, AV8BR_EncounterID, AV18ddo_BR_LabIDTitleControlIdToReplace, AV24ddo_BR_Lab_TestNameTitleControlIdToReplace, AV28ddo_BR_Lab_SpecimenSourceTitleControlIdToReplace, AV26ddo_BR_Lab_SpecimenDateTitleControlIdToReplace, AV40ddo_BR_Lab_AbnIndTitleControlIdToReplace, AV90Pgmname, AV64IsAuthorized_Display, AV62IsAuthorized_Delete, sPrefix) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP260( )
      {
         /* Before Start, stand alone formulas. */
         AV90Pgmname = "BR_EncounterUpdateBR_LabWC";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E19262 ();
         context.wbGlbDoneStart = 1;
         nDoneStart = 1;
         /* After Start, stand alone formulas. */
         sXEvt = cgiGet( "_EventName");
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( sPrefix+"vDDO_TITLESETTINGSICONS"), AV53DDO_TitleSettingsIcons);
            ajax_req_read_hidden_sdt(cgiGet( sPrefix+"vBR_LABIDTITLEFILTERDATA"), AV17BR_LabIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( sPrefix+"vBR_LAB_TESTNAMETITLEFILTERDATA"), AV23BR_Lab_TestNameTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( sPrefix+"vBR_LAB_SPECIMENSOURCETITLEFILTERDATA"), AV27BR_Lab_SpecimenSourceTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( sPrefix+"vBR_LAB_SPECIMENDATETITLEFILTERDATA"), AV25BR_Lab_SpecimenDateTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( sPrefix+"vBR_LAB_ABNINDTITLEFILTERDATA"), AV39BR_Lab_AbnIndTitleFilterData);
            /* Read variables values. */
            AV18ddo_BR_LabIDTitleControlIdToReplace = cgiGet( edtavDdo_br_labidtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV18ddo_BR_LabIDTitleControlIdToReplace", AV18ddo_BR_LabIDTitleControlIdToReplace);
            AV24ddo_BR_Lab_TestNameTitleControlIdToReplace = cgiGet( edtavDdo_br_lab_testnametitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV24ddo_BR_Lab_TestNameTitleControlIdToReplace", AV24ddo_BR_Lab_TestNameTitleControlIdToReplace);
            AV28ddo_BR_Lab_SpecimenSourceTitleControlIdToReplace = cgiGet( edtavDdo_br_lab_specimensourcetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV28ddo_BR_Lab_SpecimenSourceTitleControlIdToReplace", AV28ddo_BR_Lab_SpecimenSourceTitleControlIdToReplace);
            AV26ddo_BR_Lab_SpecimenDateTitleControlIdToReplace = cgiGet( edtavDdo_br_lab_specimendatetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV26ddo_BR_Lab_SpecimenDateTitleControlIdToReplace", AV26ddo_BR_Lab_SpecimenDateTitleControlIdToReplace);
            AV40ddo_BR_Lab_AbnIndTitleControlIdToReplace = cgiGet( edtavDdo_br_lab_abnindtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV40ddo_BR_Lab_AbnIndTitleControlIdToReplace", AV40ddo_BR_Lab_AbnIndTitleControlIdToReplace);
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
            nRC_GXsfl_28 = (short)(context.localUtil.CToN( cgiGet( sPrefix+"nRC_GXsfl_28"), ".", ","));
            AV56GridCurrentPage = (long)(context.localUtil.CToN( cgiGet( sPrefix+"vGRIDCURRENTPAGE"), ".", ","));
            AV84GridPageCount = (long)(context.localUtil.CToN( cgiGet( sPrefix+"vGRIDPAGECOUNT"), ".", ","));
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
            Ddo_br_labid_Caption = cgiGet( sPrefix+"DDO_BR_LABID_Caption");
            Ddo_br_labid_Tooltip = cgiGet( sPrefix+"DDO_BR_LABID_Tooltip");
            Ddo_br_labid_Cls = cgiGet( sPrefix+"DDO_BR_LABID_Cls");
            Ddo_br_labid_Dropdownoptionstype = cgiGet( sPrefix+"DDO_BR_LABID_Dropdownoptionstype");
            Ddo_br_labid_Titlecontrolidtoreplace = cgiGet( sPrefix+"DDO_BR_LABID_Titlecontrolidtoreplace");
            Ddo_br_labid_Includesortasc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_LABID_Includesortasc"));
            Ddo_br_labid_Includesortdsc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_LABID_Includesortdsc"));
            Ddo_br_labid_Sortedstatus = cgiGet( sPrefix+"DDO_BR_LABID_Sortedstatus");
            Ddo_br_labid_Includefilter = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_LABID_Includefilter"));
            Ddo_br_labid_Includedatalist = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_LABID_Includedatalist"));
            Ddo_br_labid_Sortasc = cgiGet( sPrefix+"DDO_BR_LABID_Sortasc");
            Ddo_br_labid_Sortdsc = cgiGet( sPrefix+"DDO_BR_LABID_Sortdsc");
            Ddo_br_labid_Searchbuttontext = cgiGet( sPrefix+"DDO_BR_LABID_Searchbuttontext");
            Ddo_br_lab_testname_Caption = cgiGet( sPrefix+"DDO_BR_LAB_TESTNAME_Caption");
            Ddo_br_lab_testname_Tooltip = cgiGet( sPrefix+"DDO_BR_LAB_TESTNAME_Tooltip");
            Ddo_br_lab_testname_Cls = cgiGet( sPrefix+"DDO_BR_LAB_TESTNAME_Cls");
            Ddo_br_lab_testname_Dropdownoptionstype = cgiGet( sPrefix+"DDO_BR_LAB_TESTNAME_Dropdownoptionstype");
            Ddo_br_lab_testname_Titlecontrolidtoreplace = cgiGet( sPrefix+"DDO_BR_LAB_TESTNAME_Titlecontrolidtoreplace");
            Ddo_br_lab_testname_Includesortasc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_LAB_TESTNAME_Includesortasc"));
            Ddo_br_lab_testname_Includesortdsc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_LAB_TESTNAME_Includesortdsc"));
            Ddo_br_lab_testname_Sortedstatus = cgiGet( sPrefix+"DDO_BR_LAB_TESTNAME_Sortedstatus");
            Ddo_br_lab_testname_Includefilter = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_LAB_TESTNAME_Includefilter"));
            Ddo_br_lab_testname_Includedatalist = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_LAB_TESTNAME_Includedatalist"));
            Ddo_br_lab_testname_Sortasc = cgiGet( sPrefix+"DDO_BR_LAB_TESTNAME_Sortasc");
            Ddo_br_lab_testname_Sortdsc = cgiGet( sPrefix+"DDO_BR_LAB_TESTNAME_Sortdsc");
            Ddo_br_lab_testname_Searchbuttontext = cgiGet( sPrefix+"DDO_BR_LAB_TESTNAME_Searchbuttontext");
            Ddo_br_lab_specimensource_Caption = cgiGet( sPrefix+"DDO_BR_LAB_SPECIMENSOURCE_Caption");
            Ddo_br_lab_specimensource_Tooltip = cgiGet( sPrefix+"DDO_BR_LAB_SPECIMENSOURCE_Tooltip");
            Ddo_br_lab_specimensource_Cls = cgiGet( sPrefix+"DDO_BR_LAB_SPECIMENSOURCE_Cls");
            Ddo_br_lab_specimensource_Dropdownoptionstype = cgiGet( sPrefix+"DDO_BR_LAB_SPECIMENSOURCE_Dropdownoptionstype");
            Ddo_br_lab_specimensource_Titlecontrolidtoreplace = cgiGet( sPrefix+"DDO_BR_LAB_SPECIMENSOURCE_Titlecontrolidtoreplace");
            Ddo_br_lab_specimensource_Includesortasc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_LAB_SPECIMENSOURCE_Includesortasc"));
            Ddo_br_lab_specimensource_Includesortdsc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_LAB_SPECIMENSOURCE_Includesortdsc"));
            Ddo_br_lab_specimensource_Sortedstatus = cgiGet( sPrefix+"DDO_BR_LAB_SPECIMENSOURCE_Sortedstatus");
            Ddo_br_lab_specimensource_Includefilter = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_LAB_SPECIMENSOURCE_Includefilter"));
            Ddo_br_lab_specimensource_Includedatalist = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_LAB_SPECIMENSOURCE_Includedatalist"));
            Ddo_br_lab_specimensource_Sortasc = cgiGet( sPrefix+"DDO_BR_LAB_SPECIMENSOURCE_Sortasc");
            Ddo_br_lab_specimensource_Sortdsc = cgiGet( sPrefix+"DDO_BR_LAB_SPECIMENSOURCE_Sortdsc");
            Ddo_br_lab_specimensource_Searchbuttontext = cgiGet( sPrefix+"DDO_BR_LAB_SPECIMENSOURCE_Searchbuttontext");
            Ddo_br_lab_specimendate_Caption = cgiGet( sPrefix+"DDO_BR_LAB_SPECIMENDATE_Caption");
            Ddo_br_lab_specimendate_Tooltip = cgiGet( sPrefix+"DDO_BR_LAB_SPECIMENDATE_Tooltip");
            Ddo_br_lab_specimendate_Cls = cgiGet( sPrefix+"DDO_BR_LAB_SPECIMENDATE_Cls");
            Ddo_br_lab_specimendate_Dropdownoptionstype = cgiGet( sPrefix+"DDO_BR_LAB_SPECIMENDATE_Dropdownoptionstype");
            Ddo_br_lab_specimendate_Titlecontrolidtoreplace = cgiGet( sPrefix+"DDO_BR_LAB_SPECIMENDATE_Titlecontrolidtoreplace");
            Ddo_br_lab_specimendate_Includesortasc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_LAB_SPECIMENDATE_Includesortasc"));
            Ddo_br_lab_specimendate_Includesortdsc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_LAB_SPECIMENDATE_Includesortdsc"));
            Ddo_br_lab_specimendate_Sortedstatus = cgiGet( sPrefix+"DDO_BR_LAB_SPECIMENDATE_Sortedstatus");
            Ddo_br_lab_specimendate_Includefilter = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_LAB_SPECIMENDATE_Includefilter"));
            Ddo_br_lab_specimendate_Includedatalist = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_LAB_SPECIMENDATE_Includedatalist"));
            Ddo_br_lab_specimendate_Sortasc = cgiGet( sPrefix+"DDO_BR_LAB_SPECIMENDATE_Sortasc");
            Ddo_br_lab_specimendate_Sortdsc = cgiGet( sPrefix+"DDO_BR_LAB_SPECIMENDATE_Sortdsc");
            Ddo_br_lab_specimendate_Searchbuttontext = cgiGet( sPrefix+"DDO_BR_LAB_SPECIMENDATE_Searchbuttontext");
            Ddo_br_lab_abnind_Caption = cgiGet( sPrefix+"DDO_BR_LAB_ABNIND_Caption");
            Ddo_br_lab_abnind_Tooltip = cgiGet( sPrefix+"DDO_BR_LAB_ABNIND_Tooltip");
            Ddo_br_lab_abnind_Cls = cgiGet( sPrefix+"DDO_BR_LAB_ABNIND_Cls");
            Ddo_br_lab_abnind_Dropdownoptionstype = cgiGet( sPrefix+"DDO_BR_LAB_ABNIND_Dropdownoptionstype");
            Ddo_br_lab_abnind_Titlecontrolidtoreplace = cgiGet( sPrefix+"DDO_BR_LAB_ABNIND_Titlecontrolidtoreplace");
            Ddo_br_lab_abnind_Includesortasc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_LAB_ABNIND_Includesortasc"));
            Ddo_br_lab_abnind_Includesortdsc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_LAB_ABNIND_Includesortdsc"));
            Ddo_br_lab_abnind_Sortedstatus = cgiGet( sPrefix+"DDO_BR_LAB_ABNIND_Sortedstatus");
            Ddo_br_lab_abnind_Includefilter = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_LAB_ABNIND_Includefilter"));
            Ddo_br_lab_abnind_Includedatalist = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_LAB_ABNIND_Includedatalist"));
            Ddo_br_lab_abnind_Sortasc = cgiGet( sPrefix+"DDO_BR_LAB_ABNIND_Sortasc");
            Ddo_br_lab_abnind_Sortdsc = cgiGet( sPrefix+"DDO_BR_LAB_ABNIND_Sortdsc");
            Ddo_br_lab_abnind_Searchbuttontext = cgiGet( sPrefix+"DDO_BR_LAB_ABNIND_Searchbuttontext");
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( sPrefix+"GRID_Rows"), ".", ","));
            GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            Gridpaginationbar_Selectedpage = cgiGet( sPrefix+"GRIDPAGINATIONBAR_Selectedpage");
            Gridpaginationbar_Rowsperpageselectedvalue = (int)(context.localUtil.CToN( cgiGet( sPrefix+"GRIDPAGINATIONBAR_Rowsperpageselectedvalue"), ".", ","));
            Ddo_br_labid_Activeeventkey = cgiGet( sPrefix+"DDO_BR_LABID_Activeeventkey");
            Ddo_br_lab_testname_Activeeventkey = cgiGet( sPrefix+"DDO_BR_LAB_TESTNAME_Activeeventkey");
            Ddo_br_lab_specimensource_Activeeventkey = cgiGet( sPrefix+"DDO_BR_LAB_SPECIMENSOURCE_Activeeventkey");
            Ddo_br_lab_specimendate_Activeeventkey = cgiGet( sPrefix+"DDO_BR_LAB_SPECIMENDATE_Activeeventkey");
            Ddo_br_lab_abnind_Activeeventkey = cgiGet( sPrefix+"DDO_BR_LAB_ABNIND_Activeeventkey");
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
         E19262 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E19262( )
      {
         /* Start Routine */
         subGrid_Rows = 9;
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         Ddo_br_labid_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_LabID";
         ucDdo_br_labid.SendProperty(context, sPrefix, false, Ddo_br_labid_Internalname, "TitleControlIdToReplace", Ddo_br_labid_Titlecontrolidtoreplace);
         AV18ddo_BR_LabIDTitleControlIdToReplace = Ddo_br_labid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV18ddo_BR_LabIDTitleControlIdToReplace", AV18ddo_BR_LabIDTitleControlIdToReplace);
         edtavDdo_br_labidtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDdo_br_labidtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_labidtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_lab_testname_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Lab_TestName";
         ucDdo_br_lab_testname.SendProperty(context, sPrefix, false, Ddo_br_lab_testname_Internalname, "TitleControlIdToReplace", Ddo_br_lab_testname_Titlecontrolidtoreplace);
         AV24ddo_BR_Lab_TestNameTitleControlIdToReplace = Ddo_br_lab_testname_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV24ddo_BR_Lab_TestNameTitleControlIdToReplace", AV24ddo_BR_Lab_TestNameTitleControlIdToReplace);
         edtavDdo_br_lab_testnametitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDdo_br_lab_testnametitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_lab_testnametitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_lab_specimensource_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Lab_SpecimenSource";
         ucDdo_br_lab_specimensource.SendProperty(context, sPrefix, false, Ddo_br_lab_specimensource_Internalname, "TitleControlIdToReplace", Ddo_br_lab_specimensource_Titlecontrolidtoreplace);
         AV28ddo_BR_Lab_SpecimenSourceTitleControlIdToReplace = Ddo_br_lab_specimensource_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV28ddo_BR_Lab_SpecimenSourceTitleControlIdToReplace", AV28ddo_BR_Lab_SpecimenSourceTitleControlIdToReplace);
         edtavDdo_br_lab_specimensourcetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDdo_br_lab_specimensourcetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_lab_specimensourcetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_lab_specimendate_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Lab_SpecimenDate";
         ucDdo_br_lab_specimendate.SendProperty(context, sPrefix, false, Ddo_br_lab_specimendate_Internalname, "TitleControlIdToReplace", Ddo_br_lab_specimendate_Titlecontrolidtoreplace);
         AV26ddo_BR_Lab_SpecimenDateTitleControlIdToReplace = Ddo_br_lab_specimendate_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV26ddo_BR_Lab_SpecimenDateTitleControlIdToReplace", AV26ddo_BR_Lab_SpecimenDateTitleControlIdToReplace);
         edtavDdo_br_lab_specimendatetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDdo_br_lab_specimendatetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_lab_specimendatetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_lab_abnind_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Lab_AbnInd";
         ucDdo_br_lab_abnind.SendProperty(context, sPrefix, false, Ddo_br_lab_abnind_Internalname, "TitleControlIdToReplace", Ddo_br_lab_abnind_Titlecontrolidtoreplace);
         AV40ddo_BR_Lab_AbnIndTitleControlIdToReplace = Ddo_br_lab_abnind_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV40ddo_BR_Lab_AbnIndTitleControlIdToReplace", AV40ddo_BR_Lab_AbnIndTitleControlIdToReplace);
         edtavDdo_br_lab_abnindtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDdo_br_lab_abnindtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_lab_abnindtitlecontrolidtoreplace_Visible), 5, 0)), true);
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
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 = AV53DDO_TitleSettingsIcons;
         new GeneXus.Programs.wwpbaseobjects.getwwptitlesettingsicons(context ).execute( out  GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1) ;
         AV53DDO_TitleSettingsIcons = GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1;
         Gridpaginationbar_Rowsperpageselectedvalue = subGrid_Rows;
         ucGridpaginationbar.SendProperty(context, sPrefix, false, Gridpaginationbar_Internalname, "RowsPerPageSelectedValue", StringUtil.LTrim( StringUtil.Str( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0)));
      }

      protected void E20262( )
      {
         if ( gx_refresh_fired )
         {
            return  ;
         }
         gx_refresh_fired = true;
         /* Refresh Routine */
         AV17BR_LabIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV23BR_Lab_TestNameTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV27BR_Lab_SpecimenSourceTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV25BR_Lab_SpecimenDateTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV39BR_Lab_AbnIndTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
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
         edtBR_LabID_Titleformat = 2;
         edtBR_LabID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "序号", AV18ddo_BR_LabIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_LabID_Internalname, "Title", edtBR_LabID_Title, !bGXsfl_28_Refreshing);
         edtBR_Lab_TestName_Titleformat = 2;
         edtBR_Lab_TestName_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "项目名称", AV24ddo_BR_Lab_TestNameTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_Lab_TestName_Internalname, "Title", edtBR_Lab_TestName_Title, !bGXsfl_28_Refreshing);
         edtBR_Lab_SpecimenSource_Titleformat = 2;
         edtBR_Lab_SpecimenSource_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "标本种类", AV28ddo_BR_Lab_SpecimenSourceTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_Lab_SpecimenSource_Internalname, "Title", edtBR_Lab_SpecimenSource_Title, !bGXsfl_28_Refreshing);
         edtBR_Lab_SpecimenDate_Titleformat = 2;
         edtBR_Lab_SpecimenDate_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "采样时间", AV26ddo_BR_Lab_SpecimenDateTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_Lab_SpecimenDate_Internalname, "Title", edtBR_Lab_SpecimenDate_Title, !bGXsfl_28_Refreshing);
         edtBR_Lab_AbnInd_Titleformat = 2;
         edtBR_Lab_AbnInd_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "结果提示", AV40ddo_BR_Lab_AbnIndTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_Lab_AbnInd_Internalname, "Title", edtBR_Lab_AbnInd_Title, !bGXsfl_28_Refreshing);
         AV56GridCurrentPage = subGrid_Currentpage( );
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV56GridCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV56GridCurrentPage), 10, 0)));
         AV84GridPageCount = subGrid_Pagecount( );
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV84GridPageCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV84GridPageCount), 10, 0)));
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV17BR_LabIDTitleFilterData", AV17BR_LabIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV23BR_Lab_TestNameTitleFilterData", AV23BR_Lab_TestNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV27BR_Lab_SpecimenSourceTitleFilterData", AV27BR_Lab_SpecimenSourceTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV25BR_Lab_SpecimenDateTitleFilterData", AV25BR_Lab_SpecimenDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV39BR_Lab_AbnIndTitleFilterData", AV39BR_Lab_AbnIndTitleFilterData);
      }

      protected void E11262( )
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
            AV55PageToGo = (int)(NumberUtil.Val( Gridpaginationbar_Selectedpage, "."));
            subgrid_gotopage( AV55PageToGo) ;
         }
      }

      protected void E12262( )
      {
         /* Gridpaginationbar_Changerowsperpage Routine */
         subGrid_Rows = Gridpaginationbar_Rowsperpageselectedvalue;
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         subgrid_firstpage( ) ;
         /*  Sending Event outputs  */
      }

      protected void E13262( )
      {
         /* Ddo_br_labid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_labid_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV14OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14OrderedBy), 4, 0)));
            AV15OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV15OrderedDsc", AV15OrderedDsc);
            Ddo_br_labid_Sortedstatus = "ASC";
            ucDdo_br_labid.SendProperty(context, sPrefix, false, Ddo_br_labid_Internalname, "SortedStatus", Ddo_br_labid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         else if ( StringUtil.StrCmp(Ddo_br_labid_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV14OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14OrderedBy), 4, 0)));
            AV15OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV15OrderedDsc", AV15OrderedDsc);
            Ddo_br_labid_Sortedstatus = "DSC";
            ucDdo_br_labid.SendProperty(context, sPrefix, false, Ddo_br_labid_Internalname, "SortedStatus", Ddo_br_labid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV17BR_LabIDTitleFilterData", AV17BR_LabIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV23BR_Lab_TestNameTitleFilterData", AV23BR_Lab_TestNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV27BR_Lab_SpecimenSourceTitleFilterData", AV27BR_Lab_SpecimenSourceTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV25BR_Lab_SpecimenDateTitleFilterData", AV25BR_Lab_SpecimenDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV39BR_Lab_AbnIndTitleFilterData", AV39BR_Lab_AbnIndTitleFilterData);
      }

      protected void E14262( )
      {
         /* Ddo_br_lab_testname_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_lab_testname_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV14OrderedBy = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14OrderedBy), 4, 0)));
            AV15OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV15OrderedDsc", AV15OrderedDsc);
            Ddo_br_lab_testname_Sortedstatus = "ASC";
            ucDdo_br_lab_testname.SendProperty(context, sPrefix, false, Ddo_br_lab_testname_Internalname, "SortedStatus", Ddo_br_lab_testname_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         else if ( StringUtil.StrCmp(Ddo_br_lab_testname_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV14OrderedBy = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14OrderedBy), 4, 0)));
            AV15OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV15OrderedDsc", AV15OrderedDsc);
            Ddo_br_lab_testname_Sortedstatus = "DSC";
            ucDdo_br_lab_testname.SendProperty(context, sPrefix, false, Ddo_br_lab_testname_Internalname, "SortedStatus", Ddo_br_lab_testname_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV17BR_LabIDTitleFilterData", AV17BR_LabIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV23BR_Lab_TestNameTitleFilterData", AV23BR_Lab_TestNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV27BR_Lab_SpecimenSourceTitleFilterData", AV27BR_Lab_SpecimenSourceTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV25BR_Lab_SpecimenDateTitleFilterData", AV25BR_Lab_SpecimenDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV39BR_Lab_AbnIndTitleFilterData", AV39BR_Lab_AbnIndTitleFilterData);
      }

      protected void E15262( )
      {
         /* Ddo_br_lab_specimensource_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_lab_specimensource_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV14OrderedBy = 3;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14OrderedBy), 4, 0)));
            AV15OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV15OrderedDsc", AV15OrderedDsc);
            Ddo_br_lab_specimensource_Sortedstatus = "ASC";
            ucDdo_br_lab_specimensource.SendProperty(context, sPrefix, false, Ddo_br_lab_specimensource_Internalname, "SortedStatus", Ddo_br_lab_specimensource_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         else if ( StringUtil.StrCmp(Ddo_br_lab_specimensource_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV14OrderedBy = 3;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14OrderedBy), 4, 0)));
            AV15OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV15OrderedDsc", AV15OrderedDsc);
            Ddo_br_lab_specimensource_Sortedstatus = "DSC";
            ucDdo_br_lab_specimensource.SendProperty(context, sPrefix, false, Ddo_br_lab_specimensource_Internalname, "SortedStatus", Ddo_br_lab_specimensource_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV17BR_LabIDTitleFilterData", AV17BR_LabIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV23BR_Lab_TestNameTitleFilterData", AV23BR_Lab_TestNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV27BR_Lab_SpecimenSourceTitleFilterData", AV27BR_Lab_SpecimenSourceTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV25BR_Lab_SpecimenDateTitleFilterData", AV25BR_Lab_SpecimenDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV39BR_Lab_AbnIndTitleFilterData", AV39BR_Lab_AbnIndTitleFilterData);
      }

      protected void E16262( )
      {
         /* Ddo_br_lab_specimendate_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_lab_specimendate_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV14OrderedBy = 4;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14OrderedBy), 4, 0)));
            AV15OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV15OrderedDsc", AV15OrderedDsc);
            Ddo_br_lab_specimendate_Sortedstatus = "ASC";
            ucDdo_br_lab_specimendate.SendProperty(context, sPrefix, false, Ddo_br_lab_specimendate_Internalname, "SortedStatus", Ddo_br_lab_specimendate_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         else if ( StringUtil.StrCmp(Ddo_br_lab_specimendate_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV14OrderedBy = 4;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14OrderedBy), 4, 0)));
            AV15OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV15OrderedDsc", AV15OrderedDsc);
            Ddo_br_lab_specimendate_Sortedstatus = "DSC";
            ucDdo_br_lab_specimendate.SendProperty(context, sPrefix, false, Ddo_br_lab_specimendate_Internalname, "SortedStatus", Ddo_br_lab_specimendate_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV17BR_LabIDTitleFilterData", AV17BR_LabIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV23BR_Lab_TestNameTitleFilterData", AV23BR_Lab_TestNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV27BR_Lab_SpecimenSourceTitleFilterData", AV27BR_Lab_SpecimenSourceTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV25BR_Lab_SpecimenDateTitleFilterData", AV25BR_Lab_SpecimenDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV39BR_Lab_AbnIndTitleFilterData", AV39BR_Lab_AbnIndTitleFilterData);
      }

      protected void E17262( )
      {
         /* Ddo_br_lab_abnind_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_lab_abnind_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV14OrderedBy = 5;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14OrderedBy), 4, 0)));
            AV15OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV15OrderedDsc", AV15OrderedDsc);
            Ddo_br_lab_abnind_Sortedstatus = "ASC";
            ucDdo_br_lab_abnind.SendProperty(context, sPrefix, false, Ddo_br_lab_abnind_Internalname, "SortedStatus", Ddo_br_lab_abnind_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         else if ( StringUtil.StrCmp(Ddo_br_lab_abnind_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV14OrderedBy = 5;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14OrderedBy), 4, 0)));
            AV15OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV15OrderedDsc", AV15OrderedDsc);
            Ddo_br_lab_abnind_Sortedstatus = "DSC";
            ucDdo_br_lab_abnind.SendProperty(context, sPrefix, false, Ddo_br_lab_abnind_Internalname, "SortedStatus", Ddo_br_lab_abnind_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV17BR_LabIDTitleFilterData", AV17BR_LabIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV23BR_Lab_TestNameTitleFilterData", AV23BR_Lab_TestNameTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV27BR_Lab_SpecimenSourceTitleFilterData", AV27BR_Lab_SpecimenSourceTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV25BR_Lab_SpecimenDateTitleFilterData", AV25BR_Lab_SpecimenDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV39BR_Lab_AbnIndTitleFilterData", AV39BR_Lab_AbnIndTitleFilterData);
      }

      private void E21262( )
      {
         /* Grid_Load Routine */
         AV63Display = context.GetImagePath( "f11923b6-6acd-4a79-bfc0-0cfc6f3bced5", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, edtavDisplay_Internalname, AV63Display);
         AV87Display_GXI = GXDbFile.PathToUrl( context.GetImagePath( "f11923b6-6acd-4a79-bfc0-0cfc6f3bced5", "", context.GetTheme( )));
         edtavDisplay_Tooltiptext = "显示";
         if ( AV64IsAuthorized_Display )
         {
            edtavDisplay_Link = formatLink("br_labview.aspx") + "?" + UrlEncode("" +A101BR_LabID) + "," + UrlEncode(StringUtil.RTrim(""));
         }
         AV80back = context.GetImagePath( "7c63c2b9-483e-4035-b512-febf9186a274", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, edtavBack_Internalname, AV80back);
         AV88Back_GXI = GXDbFile.PathToUrl( context.GetImagePath( "7c63c2b9-483e-4035-b512-febf9186a274", "", context.GetTheme( )));
         edtavBack_Tooltiptext = "";
         AV61Delete = context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, edtavDelete_Internalname, AV61Delete);
         AV89Delete_GXI = GXDbFile.PathToUrl( context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", context.GetTheme( )));
         edtavDelete_Tooltiptext = "删除";
         if ( AV62IsAuthorized_Delete )
         {
            edtavDelete_Link = formatLink("br_lab.aspx") + "?" + UrlEncode(StringUtil.RTrim("DLT")) + "," + UrlEncode("" +A101BR_LabID);
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

      protected void E18262( )
      {
         /* 'DoInsert' Routine */
         if ( 1 == 0 )
         {
            CallWebObject(formatLink("br_lab.aspx") + "?" + UrlEncode(StringUtil.RTrim("INS")) + "," + UrlEncode("" +0));
            context.wjLocDisableFrm = 1;
         }
         CallWebObject(formatLink("br_labinsert.aspx") + "?" + UrlEncode("" +AV8BR_EncounterID));
         context.wjLocDisableFrm = 1;
      }

      protected void S132( )
      {
         /* 'CHECKSECURITYFORACTIONS' Routine */
         GXt_boolean2 = AV64IsAuthorized_Display;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Lab", out  GXt_boolean2) ;
         AV64IsAuthorized_Display = GXt_boolean2;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV64IsAuthorized_Display", AV64IsAuthorized_Display);
         if ( ! ( AV64IsAuthorized_Display ) )
         {
            edtavDisplay_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDisplay_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDisplay_Visible), 5, 0)), !bGXsfl_28_Refreshing);
         }
         GXt_boolean2 = AV82IsAuthorized_back;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Lab", out  GXt_boolean2) ;
         AV82IsAuthorized_back = GXt_boolean2;
         if ( ! ( AV82IsAuthorized_back ) )
         {
            edtavBack_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavBack_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBack_Visible), 5, 0)), !bGXsfl_28_Refreshing);
         }
         GXt_boolean2 = AV62IsAuthorized_Delete;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Lab", out  GXt_boolean2) ;
         AV62IsAuthorized_Delete = GXt_boolean2;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV62IsAuthorized_Delete", AV62IsAuthorized_Delete);
         if ( ! ( AV62IsAuthorized_Delete ) )
         {
            edtavDelete_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDelete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDelete_Visible), 5, 0)), !bGXsfl_28_Refreshing);
         }
         GXt_boolean2 = AV65TempBoolean;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Lab", out  GXt_boolean2) ;
         AV65TempBoolean = GXt_boolean2;
         if ( ! ( AV65TempBoolean ) )
         {
            bttBtninsert_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, bttBtninsert_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtninsert_Visible), 5, 0)), true);
         }
      }

      protected void S122( )
      {
         /* 'LOADGRIDSTATE' Routine */
         if ( StringUtil.StrCmp(AV16Session.Get(AV90Pgmname+"GridState"), "") == 0 )
         {
            AV12GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  AV90Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         else
         {
            AV12GridState.FromXml(AV16Session.Get(AV90Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
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
         AV12GridState.FromXml(AV16Session.Get(AV90Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         AV12GridState.gxTpr_Orderedby = AV14OrderedBy;
         AV12GridState.gxTpr_Ordereddsc = AV15OrderedDsc;
         AV12GridState.gxTpr_Pagesize = StringUtil.Str( (decimal)(subGrid_Rows), 10, 0);
         new GeneXus.Programs.wwpbaseobjects.savegridstate(context ).execute(  AV90Pgmname+"GridState",  AV12GridState.ToXml(false, true, "WWPGridState", "DataAnalysisPlatform")) ;
      }

      protected void S112( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV10TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV10TrnContext.gxTpr_Callerobject = AV90Pgmname;
         AV10TrnContext.gxTpr_Callerondelete = true;
         AV10TrnContext.gxTpr_Callerurl = AV9HTTPRequest.ScriptName+"?"+AV9HTTPRequest.QueryString;
         AV10TrnContext.gxTpr_Transactionname = "BR_Lab";
         AV11TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         AV11TrnContextAtt.gxTpr_Attributename = "BR_EncounterID";
         AV11TrnContextAtt.gxTpr_Attributevalue = StringUtil.Str( (decimal)(AV8BR_EncounterID), 18, 0);
         AV10TrnContext.gxTpr_Attributes.Add(AV11TrnContextAtt, 0);
         AV16Session.Set("TrnContext", AV10TrnContext.ToXml(false, true, "WWPTransactionContext", "DataAnalysisPlatform"));
      }

      protected void E22262( )
      {
         /* Back_Click Routine */
         new zutil_checksession(context ).execute( out  AV83tCheckFlag) ;
         if ( ! AV83tCheckFlag )
         {
            CallWebObject(formatLink("br_labupdate.aspx") + "?" + UrlEncode("" +A101BR_LabID));
            context.wjLocDisableFrm = 1;
         }
      }

      protected void E23262( )
      {
         /* Delete_Click Routine */
         new zutil_checksession(context ).execute( out  AV83tCheckFlag) ;
         if ( ! AV83tCheckFlag )
         {
            CallWebObject(formatLink("br_labdelete.aspx") + "?" + UrlEncode("" +A101BR_LabID));
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
         PA262( ) ;
         WS262( ) ;
         WE262( ) ;
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
         PA262( ) ;
         WCParametersGet( ) ;
      }

      public override void componentprepare( Object[] obj )
      {
         wbLoad = false;
         sCompPrefix = (String)getParm(obj,0);
         sSFPrefix = (String)getParm(obj,1);
         sPrefix = sCompPrefix + sSFPrefix;
         AddComponentObject(sPrefix, "br_encounterupdatebr_labwc", GetJustCreated( ));
         if ( ( nDoneStart == 0 ) && ( nDynComponent == 0 ) )
         {
            INITWEB( ) ;
         }
         else
         {
            init_default_properties( ) ;
            init_web_controls( ) ;
         }
         PA262( ) ;
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
         PA262( ) ;
         sEvt = sCompEvt;
         WCParametersGet( ) ;
         WS262( ) ;
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
         WS262( ) ;
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
         WE262( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?2020228157549", true);
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
         context.AddJavascriptSource("br_encounterupdatebr_labwc.js", "?2020228157550", false);
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
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/WorkWithPlusUtilities/WorkWithPlusUtilitiesRender.js", "", false);
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_282( )
      {
         edtavDisplay_Internalname = sPrefix+"vDISPLAY_"+sGXsfl_28_idx;
         edtavBack_Internalname = sPrefix+"vBACK_"+sGXsfl_28_idx;
         edtavDelete_Internalname = sPrefix+"vDELETE_"+sGXsfl_28_idx;
         edtBR_LabID_Internalname = sPrefix+"BR_LABID_"+sGXsfl_28_idx;
         edtBR_Lab_TestName_Internalname = sPrefix+"BR_LAB_TESTNAME_"+sGXsfl_28_idx;
         edtBR_Lab_SpecimenSource_Internalname = sPrefix+"BR_LAB_SPECIMENSOURCE_"+sGXsfl_28_idx;
         edtBR_Lab_SpecimenDate_Internalname = sPrefix+"BR_LAB_SPECIMENDATE_"+sGXsfl_28_idx;
         edtBR_Lab_AbnInd_Internalname = sPrefix+"BR_LAB_ABNIND_"+sGXsfl_28_idx;
      }

      protected void SubsflControlProps_fel_282( )
      {
         edtavDisplay_Internalname = sPrefix+"vDISPLAY_"+sGXsfl_28_fel_idx;
         edtavBack_Internalname = sPrefix+"vBACK_"+sGXsfl_28_fel_idx;
         edtavDelete_Internalname = sPrefix+"vDELETE_"+sGXsfl_28_fel_idx;
         edtBR_LabID_Internalname = sPrefix+"BR_LABID_"+sGXsfl_28_fel_idx;
         edtBR_Lab_TestName_Internalname = sPrefix+"BR_LAB_TESTNAME_"+sGXsfl_28_fel_idx;
         edtBR_Lab_SpecimenSource_Internalname = sPrefix+"BR_LAB_SPECIMENSOURCE_"+sGXsfl_28_fel_idx;
         edtBR_Lab_SpecimenDate_Internalname = sPrefix+"BR_LAB_SPECIMENDATE_"+sGXsfl_28_fel_idx;
         edtBR_Lab_AbnInd_Internalname = sPrefix+"BR_LAB_ABNIND_"+sGXsfl_28_fel_idx;
      }

      protected void sendrow_282( )
      {
         SubsflControlProps_282( ) ;
         WB260( ) ;
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
            AV63Display_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV63Display))&&String.IsNullOrEmpty(StringUtil.RTrim( AV87Display_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV63Display)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV63Display)) ? AV87Display_GXI : context.PathToRelativeUrl( AV63Display));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavDisplay_Internalname,(String)sImgUrl,(String)edtavDisplay_Link,(String)"",(String)"",context.GetTheme( ),(int)edtavDisplay_Visible,(short)1,(String)"",(String)edtavDisplay_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV63Display_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((edtavBack_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Active Bitmap Variable */
            TempTags = " " + ((edtavBack_Enabled!=0)&&(edtavBack_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 30,'"+sPrefix+"',false,'',28)\"" : " ");
            ClassString = "ActionBaseColorAttribute";
            StyleString = "";
            AV80back_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV80back))&&String.IsNullOrEmpty(StringUtil.RTrim( AV88Back_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV80back)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV80back)) ? AV88Back_GXI : context.PathToRelativeUrl( AV80back));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavBack_Internalname,(String)sImgUrl,(String)"",(String)"",(String)"",context.GetTheme( ),(int)edtavBack_Visible,(short)1,(String)"",(String)edtavBack_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)5,(String)edtavBack_Jsonclick,"'"+sPrefix+"'"+",false,"+"'"+sPrefix+"EVBACK.CLICK."+sGXsfl_28_idx+"'",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)""+TempTags,(String)"",(String)"",(short)1,(bool)AV80back_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((edtavDelete_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Active Bitmap Variable */
            TempTags = " " + ((edtavDelete_Enabled!=0)&&(edtavDelete_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 31,'"+sPrefix+"',false,'',28)\"" : " ");
            ClassString = "DeleteAttribute ActionBaseColorAttribute";
            StyleString = "";
            AV61Delete_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV61Delete))&&String.IsNullOrEmpty(StringUtil.RTrim( AV89Delete_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV61Delete)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV61Delete)) ? AV89Delete_GXI : context.PathToRelativeUrl( AV61Delete));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavDelete_Internalname,(String)sImgUrl,(String)"",(String)"",(String)"",context.GetTheme( ),(int)edtavDelete_Visible,(short)1,(String)"",(String)edtavDelete_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)5,(String)edtavDelete_Jsonclick,"'"+sPrefix+"'"+",false,"+"'"+sPrefix+"EVDELETE.CLICK."+sGXsfl_28_idx+"'",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)""+TempTags,(String)"",(String)"",(short)1,(bool)AV61Delete_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_LabID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A101BR_LabID), 18, 0, ".", "")),context.localUtil.Format( (decimal)(A101BR_LabID), "ZZZZZZZZZZZZZZZZZZ"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_LabID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)28,(short)1,(short)-1,(short)0,(bool)true,(String)"ID",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Lab_TestName_Internalname,(String)A104BR_Lab_TestName,(String)"",(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Lab_TestName_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)28,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Lab_SpecimenSource_Internalname,(String)A106BR_Lab_SpecimenSource,(String)"",(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Lab_SpecimenSource_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)28,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Lab_SpecimenDate_Internalname,context.localUtil.TToC( A105BR_Lab_SpecimenDate, 10, 8, 0, 0, "/", ":", " "),context.localUtil.Format( A105BR_Lab_SpecimenDate, "9999/99/99 99:99:99"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Lab_SpecimenDate_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs hidden-sm",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)19,(short)0,(short)0,(short)28,(short)1,(short)-1,(short)0,(bool)true,(String)"DM_DataTime",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Lab_AbnInd_Internalname,(String)A112BR_Lab_AbnInd,(String)"",(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Lab_AbnInd_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs hidden-sm",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)28,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            send_integrity_lvl_hashes262( ) ;
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
         edtavBack_Internalname = sPrefix+"vBACK";
         edtavDelete_Internalname = sPrefix+"vDELETE";
         edtBR_LabID_Internalname = sPrefix+"BR_LABID";
         edtBR_Lab_TestName_Internalname = sPrefix+"BR_LAB_TESTNAME";
         edtBR_Lab_SpecimenSource_Internalname = sPrefix+"BR_LAB_SPECIMENSOURCE";
         edtBR_Lab_SpecimenDate_Internalname = sPrefix+"BR_LAB_SPECIMENDATE";
         edtBR_Lab_AbnInd_Internalname = sPrefix+"BR_LAB_ABNIND";
         Gridpaginationbar_Internalname = sPrefix+"GRIDPAGINATIONBAR";
         divHtml_gridpaginationbar_Internalname = sPrefix+"HTML_GRIDPAGINATIONBAR";
         divGridtablewithpaginationbar_Internalname = sPrefix+"GRIDTABLEWITHPAGINATIONBAR";
         divTablegridheader_Internalname = sPrefix+"TABLEGRIDHEADER";
         Ddo_br_labid_Internalname = sPrefix+"DDO_BR_LABID";
         edtavDdo_br_labidtitlecontrolidtoreplace_Internalname = sPrefix+"vDDO_BR_LABIDTITLECONTROLIDTOREPLACE";
         Ddo_br_lab_testname_Internalname = sPrefix+"DDO_BR_LAB_TESTNAME";
         edtavDdo_br_lab_testnametitlecontrolidtoreplace_Internalname = sPrefix+"vDDO_BR_LAB_TESTNAMETITLECONTROLIDTOREPLACE";
         Ddo_br_lab_specimensource_Internalname = sPrefix+"DDO_BR_LAB_SPECIMENSOURCE";
         edtavDdo_br_lab_specimensourcetitlecontrolidtoreplace_Internalname = sPrefix+"vDDO_BR_LAB_SPECIMENSOURCETITLECONTROLIDTOREPLACE";
         Ddo_br_lab_specimendate_Internalname = sPrefix+"DDO_BR_LAB_SPECIMENDATE";
         edtavDdo_br_lab_specimendatetitlecontrolidtoreplace_Internalname = sPrefix+"vDDO_BR_LAB_SPECIMENDATETITLECONTROLIDTOREPLACE";
         Ddo_br_lab_abnind_Internalname = sPrefix+"DDO_BR_LAB_ABNIND";
         edtavDdo_br_lab_abnindtitlecontrolidtoreplace_Internalname = sPrefix+"vDDO_BR_LAB_ABNINDTITLECONTROLIDTOREPLACE";
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
         edtBR_Lab_AbnInd_Jsonclick = "";
         edtBR_Lab_SpecimenDate_Jsonclick = "";
         edtBR_Lab_SpecimenSource_Jsonclick = "";
         edtBR_Lab_TestName_Jsonclick = "";
         edtBR_LabID_Jsonclick = "";
         edtavDelete_Jsonclick = "";
         edtavDelete_Enabled = 1;
         edtavBack_Jsonclick = "";
         edtavBack_Enabled = 1;
         edtavOrdereddsc_Jsonclick = "";
         edtavOrdereddsc_Visible = 1;
         edtavOrderedby_Jsonclick = "";
         edtavOrderedby_Visible = 1;
         edtBR_EncounterID_Jsonclick = "";
         edtBR_EncounterID_Visible = 1;
         edtavDdo_br_lab_abnindtitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_lab_specimendatetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_lab_specimensourcetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_lab_testnametitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_labidtitlecontrolidtoreplace_Visible = 1;
         subGrid_Allowcollapsing = 0;
         subGrid_Allowselection = 0;
         edtavDelete_Tooltiptext = "删除";
         edtavDelete_Link = "";
         edtavBack_Tooltiptext = "";
         edtavDisplay_Tooltiptext = "显示";
         edtavDisplay_Link = "";
         subGrid_Sortable = 0;
         subGrid_Header = "";
         edtBR_Lab_AbnInd_Titleformat = 0;
         edtBR_Lab_AbnInd_Title = "结果提示";
         edtBR_Lab_SpecimenDate_Titleformat = 0;
         edtBR_Lab_SpecimenDate_Title = "采样时间";
         edtBR_Lab_SpecimenSource_Titleformat = 0;
         edtBR_Lab_SpecimenSource_Title = "标本种类";
         edtBR_Lab_TestName_Titleformat = 0;
         edtBR_Lab_TestName_Title = "项目名称";
         edtBR_LabID_Titleformat = 0;
         edtBR_LabID_Title = "序号";
         edtavDelete_Visible = -1;
         edtavBack_Visible = -1;
         edtavDisplay_Visible = -1;
         subGrid_Class = "GridWithPaginationBar GridWithBorderColor WorkWith";
         subGrid_Backcolorstyle = 0;
         bttBtninsert_Visible = 1;
         Ddo_br_lab_abnind_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_lab_abnind_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_lab_abnind_Sortasc = "WWP_TSSortASC";
         Ddo_br_lab_abnind_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_lab_abnind_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_lab_abnind_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_lab_abnind_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_lab_abnind_Titlecontrolidtoreplace = "";
         Ddo_br_lab_abnind_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_lab_abnind_Cls = "ColumnSettings";
         Ddo_br_lab_abnind_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_lab_abnind_Caption = "";
         Ddo_br_lab_specimendate_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_lab_specimendate_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_lab_specimendate_Sortasc = "WWP_TSSortASC";
         Ddo_br_lab_specimendate_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_lab_specimendate_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_lab_specimendate_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_lab_specimendate_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_lab_specimendate_Titlecontrolidtoreplace = "";
         Ddo_br_lab_specimendate_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_lab_specimendate_Cls = "ColumnSettings";
         Ddo_br_lab_specimendate_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_lab_specimendate_Caption = "";
         Ddo_br_lab_specimensource_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_lab_specimensource_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_lab_specimensource_Sortasc = "WWP_TSSortASC";
         Ddo_br_lab_specimensource_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_lab_specimensource_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_lab_specimensource_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_lab_specimensource_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_lab_specimensource_Titlecontrolidtoreplace = "";
         Ddo_br_lab_specimensource_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_lab_specimensource_Cls = "ColumnSettings";
         Ddo_br_lab_specimensource_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_lab_specimensource_Caption = "";
         Ddo_br_lab_testname_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_lab_testname_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_lab_testname_Sortasc = "WWP_TSSortASC";
         Ddo_br_lab_testname_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_lab_testname_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_lab_testname_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_lab_testname_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_lab_testname_Titlecontrolidtoreplace = "";
         Ddo_br_lab_testname_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_lab_testname_Cls = "ColumnSettings";
         Ddo_br_lab_testname_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_lab_testname_Caption = "";
         Ddo_br_labid_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_labid_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_labid_Sortasc = "WWP_TSSortASC";
         Ddo_br_labid_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_labid_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_labid_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_labid_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_labid_Titlecontrolidtoreplace = "";
         Ddo_br_labid_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_labid_Cls = "ColumnSettings";
         Ddo_br_labid_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_labid_Caption = "";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV64IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'AV62IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'sPrefix'},{av:'AV18ddo_BR_LabIDTitleControlIdToReplace',fld:'vDDO_BR_LABIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Lab_TestNameTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_Lab_SpecimenSourceTitleControlIdToReplace',fld:'vDDO_BR_LAB_SPECIMENSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Lab_SpecimenDateTitleControlIdToReplace',fld:'vDDO_BR_LAB_SPECIMENDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV40ddo_BR_Lab_AbnIndTitleControlIdToReplace',fld:'vDDO_BR_LAB_ABNINDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV90Pgmname',fld:'vPGMNAME',pic:''},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]");
         setEventMetadata("REFRESH",",oparms:[{av:'AV17BR_LabIDTitleFilterData',fld:'vBR_LABIDTITLEFILTERDATA',pic:''},{av:'AV23BR_Lab_TestNameTitleFilterData',fld:'vBR_LAB_TESTNAMETITLEFILTERDATA',pic:''},{av:'AV27BR_Lab_SpecimenSourceTitleFilterData',fld:'vBR_LAB_SPECIMENSOURCETITLEFILTERDATA',pic:''},{av:'AV25BR_Lab_SpecimenDateTitleFilterData',fld:'vBR_LAB_SPECIMENDATETITLEFILTERDATA',pic:''},{av:'AV39BR_Lab_AbnIndTitleFilterData',fld:'vBR_LAB_ABNINDTITLEFILTERDATA',pic:''},{av:'edtBR_LabID_Titleformat',ctrl:'BR_LABID',prop:'Titleformat'},{av:'edtBR_LabID_Title',ctrl:'BR_LABID',prop:'Title'},{av:'edtBR_Lab_TestName_Titleformat',ctrl:'BR_LAB_TESTNAME',prop:'Titleformat'},{av:'edtBR_Lab_TestName_Title',ctrl:'BR_LAB_TESTNAME',prop:'Title'},{av:'edtBR_Lab_SpecimenSource_Titleformat',ctrl:'BR_LAB_SPECIMENSOURCE',prop:'Titleformat'},{av:'edtBR_Lab_SpecimenSource_Title',ctrl:'BR_LAB_SPECIMENSOURCE',prop:'Title'},{av:'edtBR_Lab_SpecimenDate_Titleformat',ctrl:'BR_LAB_SPECIMENDATE',prop:'Titleformat'},{av:'edtBR_Lab_SpecimenDate_Title',ctrl:'BR_LAB_SPECIMENDATE',prop:'Title'},{av:'edtBR_Lab_AbnInd_Titleformat',ctrl:'BR_LAB_ABNIND',prop:'Titleformat'},{av:'edtBR_Lab_AbnInd_Title',ctrl:'BR_LAB_ABNIND',prop:'Title'},{av:'AV56GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV84GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{av:'AV64IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'edtavDisplay_Visible',ctrl:'vDISPLAY',prop:'Visible'},{av:'edtavBack_Visible',ctrl:'vBACK',prop:'Visible'},{av:'AV62IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE","{handler:'E11262',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18ddo_BR_LabIDTitleControlIdToReplace',fld:'vDDO_BR_LABIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Lab_TestNameTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_Lab_SpecimenSourceTitleControlIdToReplace',fld:'vDDO_BR_LAB_SPECIMENSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Lab_SpecimenDateTitleControlIdToReplace',fld:'vDDO_BR_LAB_SPECIMENDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV40ddo_BR_Lab_AbnIndTitleControlIdToReplace',fld:'vDDO_BR_LAB_ABNINDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV90Pgmname',fld:'vPGMNAME',pic:''},{av:'AV64IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'AV62IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'sPrefix'},{av:'Gridpaginationbar_Selectedpage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE",",oparms:[]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE","{handler:'E12262',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18ddo_BR_LabIDTitleControlIdToReplace',fld:'vDDO_BR_LABIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Lab_TestNameTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_Lab_SpecimenSourceTitleControlIdToReplace',fld:'vDDO_BR_LAB_SPECIMENSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Lab_SpecimenDateTitleControlIdToReplace',fld:'vDDO_BR_LAB_SPECIMENDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV40ddo_BR_Lab_AbnIndTitleControlIdToReplace',fld:'vDDO_BR_LAB_ABNINDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV90Pgmname',fld:'vPGMNAME',pic:''},{av:'AV64IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'AV62IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'sPrefix'},{av:'Gridpaginationbar_Rowsperpageselectedvalue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE",",oparms:[{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]}");
         setEventMetadata("DDO_BR_LABID.ONOPTIONCLICKED","{handler:'E13262',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18ddo_BR_LabIDTitleControlIdToReplace',fld:'vDDO_BR_LABIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Lab_TestNameTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_Lab_SpecimenSourceTitleControlIdToReplace',fld:'vDDO_BR_LAB_SPECIMENSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Lab_SpecimenDateTitleControlIdToReplace',fld:'vDDO_BR_LAB_SPECIMENDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV40ddo_BR_Lab_AbnIndTitleControlIdToReplace',fld:'vDDO_BR_LAB_ABNINDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV90Pgmname',fld:'vPGMNAME',pic:''},{av:'AV64IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'AV62IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'sPrefix'},{av:'Ddo_br_labid_Activeeventkey',ctrl:'DDO_BR_LABID',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_LABID.ONOPTIONCLICKED",",oparms:[{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_labid_Sortedstatus',ctrl:'DDO_BR_LABID',prop:'SortedStatus'},{av:'AV17BR_LabIDTitleFilterData',fld:'vBR_LABIDTITLEFILTERDATA',pic:''},{av:'AV23BR_Lab_TestNameTitleFilterData',fld:'vBR_LAB_TESTNAMETITLEFILTERDATA',pic:''},{av:'AV27BR_Lab_SpecimenSourceTitleFilterData',fld:'vBR_LAB_SPECIMENSOURCETITLEFILTERDATA',pic:''},{av:'AV25BR_Lab_SpecimenDateTitleFilterData',fld:'vBR_LAB_SPECIMENDATETITLEFILTERDATA',pic:''},{av:'AV39BR_Lab_AbnIndTitleFilterData',fld:'vBR_LAB_ABNINDTITLEFILTERDATA',pic:''},{av:'edtBR_LabID_Titleformat',ctrl:'BR_LABID',prop:'Titleformat'},{av:'edtBR_LabID_Title',ctrl:'BR_LABID',prop:'Title'},{av:'edtBR_Lab_TestName_Titleformat',ctrl:'BR_LAB_TESTNAME',prop:'Titleformat'},{av:'edtBR_Lab_TestName_Title',ctrl:'BR_LAB_TESTNAME',prop:'Title'},{av:'edtBR_Lab_SpecimenSource_Titleformat',ctrl:'BR_LAB_SPECIMENSOURCE',prop:'Titleformat'},{av:'edtBR_Lab_SpecimenSource_Title',ctrl:'BR_LAB_SPECIMENSOURCE',prop:'Title'},{av:'edtBR_Lab_SpecimenDate_Titleformat',ctrl:'BR_LAB_SPECIMENDATE',prop:'Titleformat'},{av:'edtBR_Lab_SpecimenDate_Title',ctrl:'BR_LAB_SPECIMENDATE',prop:'Title'},{av:'edtBR_Lab_AbnInd_Titleformat',ctrl:'BR_LAB_ABNIND',prop:'Titleformat'},{av:'edtBR_Lab_AbnInd_Title',ctrl:'BR_LAB_ABNIND',prop:'Title'},{av:'AV56GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV84GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{av:'AV64IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'edtavDisplay_Visible',ctrl:'vDISPLAY',prop:'Visible'},{av:'edtavBack_Visible',ctrl:'vBACK',prop:'Visible'},{av:'AV62IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_LAB_TESTNAME.ONOPTIONCLICKED","{handler:'E14262',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18ddo_BR_LabIDTitleControlIdToReplace',fld:'vDDO_BR_LABIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Lab_TestNameTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_Lab_SpecimenSourceTitleControlIdToReplace',fld:'vDDO_BR_LAB_SPECIMENSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Lab_SpecimenDateTitleControlIdToReplace',fld:'vDDO_BR_LAB_SPECIMENDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV40ddo_BR_Lab_AbnIndTitleControlIdToReplace',fld:'vDDO_BR_LAB_ABNINDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV90Pgmname',fld:'vPGMNAME',pic:''},{av:'AV64IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'AV62IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'sPrefix'},{av:'Ddo_br_lab_testname_Activeeventkey',ctrl:'DDO_BR_LAB_TESTNAME',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_LAB_TESTNAME.ONOPTIONCLICKED",",oparms:[{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_lab_testname_Sortedstatus',ctrl:'DDO_BR_LAB_TESTNAME',prop:'SortedStatus'},{av:'AV17BR_LabIDTitleFilterData',fld:'vBR_LABIDTITLEFILTERDATA',pic:''},{av:'AV23BR_Lab_TestNameTitleFilterData',fld:'vBR_LAB_TESTNAMETITLEFILTERDATA',pic:''},{av:'AV27BR_Lab_SpecimenSourceTitleFilterData',fld:'vBR_LAB_SPECIMENSOURCETITLEFILTERDATA',pic:''},{av:'AV25BR_Lab_SpecimenDateTitleFilterData',fld:'vBR_LAB_SPECIMENDATETITLEFILTERDATA',pic:''},{av:'AV39BR_Lab_AbnIndTitleFilterData',fld:'vBR_LAB_ABNINDTITLEFILTERDATA',pic:''},{av:'edtBR_LabID_Titleformat',ctrl:'BR_LABID',prop:'Titleformat'},{av:'edtBR_LabID_Title',ctrl:'BR_LABID',prop:'Title'},{av:'edtBR_Lab_TestName_Titleformat',ctrl:'BR_LAB_TESTNAME',prop:'Titleformat'},{av:'edtBR_Lab_TestName_Title',ctrl:'BR_LAB_TESTNAME',prop:'Title'},{av:'edtBR_Lab_SpecimenSource_Titleformat',ctrl:'BR_LAB_SPECIMENSOURCE',prop:'Titleformat'},{av:'edtBR_Lab_SpecimenSource_Title',ctrl:'BR_LAB_SPECIMENSOURCE',prop:'Title'},{av:'edtBR_Lab_SpecimenDate_Titleformat',ctrl:'BR_LAB_SPECIMENDATE',prop:'Titleformat'},{av:'edtBR_Lab_SpecimenDate_Title',ctrl:'BR_LAB_SPECIMENDATE',prop:'Title'},{av:'edtBR_Lab_AbnInd_Titleformat',ctrl:'BR_LAB_ABNIND',prop:'Titleformat'},{av:'edtBR_Lab_AbnInd_Title',ctrl:'BR_LAB_ABNIND',prop:'Title'},{av:'AV56GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV84GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{av:'AV64IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'edtavDisplay_Visible',ctrl:'vDISPLAY',prop:'Visible'},{av:'edtavBack_Visible',ctrl:'vBACK',prop:'Visible'},{av:'AV62IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_LAB_SPECIMENSOURCE.ONOPTIONCLICKED","{handler:'E15262',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18ddo_BR_LabIDTitleControlIdToReplace',fld:'vDDO_BR_LABIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Lab_TestNameTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_Lab_SpecimenSourceTitleControlIdToReplace',fld:'vDDO_BR_LAB_SPECIMENSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Lab_SpecimenDateTitleControlIdToReplace',fld:'vDDO_BR_LAB_SPECIMENDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV40ddo_BR_Lab_AbnIndTitleControlIdToReplace',fld:'vDDO_BR_LAB_ABNINDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV90Pgmname',fld:'vPGMNAME',pic:''},{av:'AV64IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'AV62IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'sPrefix'},{av:'Ddo_br_lab_specimensource_Activeeventkey',ctrl:'DDO_BR_LAB_SPECIMENSOURCE',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_LAB_SPECIMENSOURCE.ONOPTIONCLICKED",",oparms:[{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_lab_specimensource_Sortedstatus',ctrl:'DDO_BR_LAB_SPECIMENSOURCE',prop:'SortedStatus'},{av:'AV17BR_LabIDTitleFilterData',fld:'vBR_LABIDTITLEFILTERDATA',pic:''},{av:'AV23BR_Lab_TestNameTitleFilterData',fld:'vBR_LAB_TESTNAMETITLEFILTERDATA',pic:''},{av:'AV27BR_Lab_SpecimenSourceTitleFilterData',fld:'vBR_LAB_SPECIMENSOURCETITLEFILTERDATA',pic:''},{av:'AV25BR_Lab_SpecimenDateTitleFilterData',fld:'vBR_LAB_SPECIMENDATETITLEFILTERDATA',pic:''},{av:'AV39BR_Lab_AbnIndTitleFilterData',fld:'vBR_LAB_ABNINDTITLEFILTERDATA',pic:''},{av:'edtBR_LabID_Titleformat',ctrl:'BR_LABID',prop:'Titleformat'},{av:'edtBR_LabID_Title',ctrl:'BR_LABID',prop:'Title'},{av:'edtBR_Lab_TestName_Titleformat',ctrl:'BR_LAB_TESTNAME',prop:'Titleformat'},{av:'edtBR_Lab_TestName_Title',ctrl:'BR_LAB_TESTNAME',prop:'Title'},{av:'edtBR_Lab_SpecimenSource_Titleformat',ctrl:'BR_LAB_SPECIMENSOURCE',prop:'Titleformat'},{av:'edtBR_Lab_SpecimenSource_Title',ctrl:'BR_LAB_SPECIMENSOURCE',prop:'Title'},{av:'edtBR_Lab_SpecimenDate_Titleformat',ctrl:'BR_LAB_SPECIMENDATE',prop:'Titleformat'},{av:'edtBR_Lab_SpecimenDate_Title',ctrl:'BR_LAB_SPECIMENDATE',prop:'Title'},{av:'edtBR_Lab_AbnInd_Titleformat',ctrl:'BR_LAB_ABNIND',prop:'Titleformat'},{av:'edtBR_Lab_AbnInd_Title',ctrl:'BR_LAB_ABNIND',prop:'Title'},{av:'AV56GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV84GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{av:'AV64IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'edtavDisplay_Visible',ctrl:'vDISPLAY',prop:'Visible'},{av:'edtavBack_Visible',ctrl:'vBACK',prop:'Visible'},{av:'AV62IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_LAB_SPECIMENDATE.ONOPTIONCLICKED","{handler:'E16262',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18ddo_BR_LabIDTitleControlIdToReplace',fld:'vDDO_BR_LABIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Lab_TestNameTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_Lab_SpecimenSourceTitleControlIdToReplace',fld:'vDDO_BR_LAB_SPECIMENSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Lab_SpecimenDateTitleControlIdToReplace',fld:'vDDO_BR_LAB_SPECIMENDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV40ddo_BR_Lab_AbnIndTitleControlIdToReplace',fld:'vDDO_BR_LAB_ABNINDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV90Pgmname',fld:'vPGMNAME',pic:''},{av:'AV64IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'AV62IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'sPrefix'},{av:'Ddo_br_lab_specimendate_Activeeventkey',ctrl:'DDO_BR_LAB_SPECIMENDATE',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_LAB_SPECIMENDATE.ONOPTIONCLICKED",",oparms:[{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_lab_specimendate_Sortedstatus',ctrl:'DDO_BR_LAB_SPECIMENDATE',prop:'SortedStatus'},{av:'AV17BR_LabIDTitleFilterData',fld:'vBR_LABIDTITLEFILTERDATA',pic:''},{av:'AV23BR_Lab_TestNameTitleFilterData',fld:'vBR_LAB_TESTNAMETITLEFILTERDATA',pic:''},{av:'AV27BR_Lab_SpecimenSourceTitleFilterData',fld:'vBR_LAB_SPECIMENSOURCETITLEFILTERDATA',pic:''},{av:'AV25BR_Lab_SpecimenDateTitleFilterData',fld:'vBR_LAB_SPECIMENDATETITLEFILTERDATA',pic:''},{av:'AV39BR_Lab_AbnIndTitleFilterData',fld:'vBR_LAB_ABNINDTITLEFILTERDATA',pic:''},{av:'edtBR_LabID_Titleformat',ctrl:'BR_LABID',prop:'Titleformat'},{av:'edtBR_LabID_Title',ctrl:'BR_LABID',prop:'Title'},{av:'edtBR_Lab_TestName_Titleformat',ctrl:'BR_LAB_TESTNAME',prop:'Titleformat'},{av:'edtBR_Lab_TestName_Title',ctrl:'BR_LAB_TESTNAME',prop:'Title'},{av:'edtBR_Lab_SpecimenSource_Titleformat',ctrl:'BR_LAB_SPECIMENSOURCE',prop:'Titleformat'},{av:'edtBR_Lab_SpecimenSource_Title',ctrl:'BR_LAB_SPECIMENSOURCE',prop:'Title'},{av:'edtBR_Lab_SpecimenDate_Titleformat',ctrl:'BR_LAB_SPECIMENDATE',prop:'Titleformat'},{av:'edtBR_Lab_SpecimenDate_Title',ctrl:'BR_LAB_SPECIMENDATE',prop:'Title'},{av:'edtBR_Lab_AbnInd_Titleformat',ctrl:'BR_LAB_ABNIND',prop:'Titleformat'},{av:'edtBR_Lab_AbnInd_Title',ctrl:'BR_LAB_ABNIND',prop:'Title'},{av:'AV56GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV84GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{av:'AV64IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'edtavDisplay_Visible',ctrl:'vDISPLAY',prop:'Visible'},{av:'edtavBack_Visible',ctrl:'vBACK',prop:'Visible'},{av:'AV62IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_LAB_ABNIND.ONOPTIONCLICKED","{handler:'E17262',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18ddo_BR_LabIDTitleControlIdToReplace',fld:'vDDO_BR_LABIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Lab_TestNameTitleControlIdToReplace',fld:'vDDO_BR_LAB_TESTNAMETITLECONTROLIDTOREPLACE',pic:''},{av:'AV28ddo_BR_Lab_SpecimenSourceTitleControlIdToReplace',fld:'vDDO_BR_LAB_SPECIMENSOURCETITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Lab_SpecimenDateTitleControlIdToReplace',fld:'vDDO_BR_LAB_SPECIMENDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV40ddo_BR_Lab_AbnIndTitleControlIdToReplace',fld:'vDDO_BR_LAB_ABNINDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV90Pgmname',fld:'vPGMNAME',pic:''},{av:'AV64IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'AV62IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'sPrefix'},{av:'Ddo_br_lab_abnind_Activeeventkey',ctrl:'DDO_BR_LAB_ABNIND',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_LAB_ABNIND.ONOPTIONCLICKED",",oparms:[{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_lab_abnind_Sortedstatus',ctrl:'DDO_BR_LAB_ABNIND',prop:'SortedStatus'},{av:'AV17BR_LabIDTitleFilterData',fld:'vBR_LABIDTITLEFILTERDATA',pic:''},{av:'AV23BR_Lab_TestNameTitleFilterData',fld:'vBR_LAB_TESTNAMETITLEFILTERDATA',pic:''},{av:'AV27BR_Lab_SpecimenSourceTitleFilterData',fld:'vBR_LAB_SPECIMENSOURCETITLEFILTERDATA',pic:''},{av:'AV25BR_Lab_SpecimenDateTitleFilterData',fld:'vBR_LAB_SPECIMENDATETITLEFILTERDATA',pic:''},{av:'AV39BR_Lab_AbnIndTitleFilterData',fld:'vBR_LAB_ABNINDTITLEFILTERDATA',pic:''},{av:'edtBR_LabID_Titleformat',ctrl:'BR_LABID',prop:'Titleformat'},{av:'edtBR_LabID_Title',ctrl:'BR_LABID',prop:'Title'},{av:'edtBR_Lab_TestName_Titleformat',ctrl:'BR_LAB_TESTNAME',prop:'Titleformat'},{av:'edtBR_Lab_TestName_Title',ctrl:'BR_LAB_TESTNAME',prop:'Title'},{av:'edtBR_Lab_SpecimenSource_Titleformat',ctrl:'BR_LAB_SPECIMENSOURCE',prop:'Titleformat'},{av:'edtBR_Lab_SpecimenSource_Title',ctrl:'BR_LAB_SPECIMENSOURCE',prop:'Title'},{av:'edtBR_Lab_SpecimenDate_Titleformat',ctrl:'BR_LAB_SPECIMENDATE',prop:'Titleformat'},{av:'edtBR_Lab_SpecimenDate_Title',ctrl:'BR_LAB_SPECIMENDATE',prop:'Title'},{av:'edtBR_Lab_AbnInd_Titleformat',ctrl:'BR_LAB_ABNIND',prop:'Titleformat'},{av:'edtBR_Lab_AbnInd_Title',ctrl:'BR_LAB_ABNIND',prop:'Title'},{av:'AV56GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV84GridPageCount',fld:'vGRIDPAGECOUNT',pic:'ZZZZZZZZZ9'},{av:'AV64IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'edtavDisplay_Visible',ctrl:'vDISPLAY',prop:'Visible'},{av:'edtavBack_Visible',ctrl:'vBACK',prop:'Visible'},{av:'AV62IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''},{av:'edtavDelete_Visible',ctrl:'vDELETE',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("GRID.LOAD","{handler:'E21262',iparms:[{av:'AV64IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'A101BR_LabID',fld:'BR_LABID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV62IsAuthorized_Delete',fld:'vISAUTHORIZED_DELETE',pic:''}]");
         setEventMetadata("GRID.LOAD",",oparms:[{av:'AV63Display',fld:'vDISPLAY',pic:''},{av:'edtavDisplay_Tooltiptext',ctrl:'vDISPLAY',prop:'Tooltiptext'},{av:'edtavDisplay_Link',ctrl:'vDISPLAY',prop:'Link'},{av:'AV80back',fld:'vBACK',pic:''},{av:'edtavBack_Tooltiptext',ctrl:'vBACK',prop:'Tooltiptext'},{av:'AV61Delete',fld:'vDELETE',pic:''},{av:'edtavDelete_Tooltiptext',ctrl:'vDELETE',prop:'Tooltiptext'},{av:'edtavDelete_Link',ctrl:'vDELETE',prop:'Link'}]}");
         setEventMetadata("'DOINSERT'","{handler:'E18262',iparms:[{av:'A101BR_LabID',fld:'BR_LABID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'}]");
         setEventMetadata("'DOINSERT'",",oparms:[]}");
         setEventMetadata("VBACK.CLICK","{handler:'E22262',iparms:[{av:'A101BR_LabID',fld:'BR_LABID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
         setEventMetadata("VBACK.CLICK",",oparms:[]}");
         setEventMetadata("VDELETE.CLICK","{handler:'E23262',iparms:[{av:'A101BR_LabID',fld:'BR_LABID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
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
         Ddo_br_labid_Activeeventkey = "";
         Ddo_br_lab_testname_Activeeventkey = "";
         Ddo_br_lab_specimensource_Activeeventkey = "";
         Ddo_br_lab_specimendate_Activeeventkey = "";
         Ddo_br_lab_abnind_Activeeventkey = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         sPrefix = "";
         AV18ddo_BR_LabIDTitleControlIdToReplace = "";
         AV24ddo_BR_Lab_TestNameTitleControlIdToReplace = "";
         AV28ddo_BR_Lab_SpecimenSourceTitleControlIdToReplace = "";
         AV26ddo_BR_Lab_SpecimenDateTitleControlIdToReplace = "";
         AV40ddo_BR_Lab_AbnIndTitleControlIdToReplace = "";
         AV90Pgmname = "";
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         AV53DDO_TitleSettingsIcons = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV17BR_LabIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV23BR_Lab_TestNameTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV27BR_Lab_SpecimenSourceTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV25BR_Lab_SpecimenDateTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV39BR_Lab_AbnIndTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         Ddo_br_labid_Sortedstatus = "";
         Ddo_br_lab_testname_Sortedstatus = "";
         Ddo_br_lab_specimensource_Sortedstatus = "";
         Ddo_br_lab_specimendate_Sortedstatus = "";
         Ddo_br_lab_abnind_Sortedstatus = "";
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
         AV63Display = "";
         AV80back = "";
         AV61Delete = "";
         A104BR_Lab_TestName = "";
         A106BR_Lab_SpecimenSource = "";
         A105BR_Lab_SpecimenDate = (DateTime)(DateTime.MinValue);
         A112BR_Lab_AbnInd = "";
         ucGridpaginationbar = new GXUserControl();
         ucDdo_br_labid = new GXUserControl();
         ucDdo_br_lab_testname = new GXUserControl();
         ucDdo_br_lab_specimensource = new GXUserControl();
         ucDdo_br_lab_specimendate = new GXUserControl();
         ucDdo_br_lab_abnind = new GXUserControl();
         ucWorkwithplusutilities1 = new GXUserControl();
         Form = new GXWebForm();
         sXEvt = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV87Display_GXI = "";
         AV88Back_GXI = "";
         AV89Delete_GXI = "";
         scmdbuf = "";
         H00262_A19BR_EncounterID = new long[1] ;
         H00262_A112BR_Lab_AbnInd = new String[] {""} ;
         H00262_n112BR_Lab_AbnInd = new bool[] {false} ;
         H00262_A105BR_Lab_SpecimenDate = new DateTime[] {DateTime.MinValue} ;
         H00262_n105BR_Lab_SpecimenDate = new bool[] {false} ;
         H00262_A106BR_Lab_SpecimenSource = new String[] {""} ;
         H00262_n106BR_Lab_SpecimenSource = new bool[] {false} ;
         H00262_A104BR_Lab_TestName = new String[] {""} ;
         H00262_n104BR_Lab_TestName = new bool[] {false} ;
         H00262_A101BR_LabID = new long[1] ;
         H00263_AGRID_nRecordCount = new long[1] ;
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
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_encounterupdatebr_labwc__default(),
            new Object[][] {
                new Object[] {
               H00262_A19BR_EncounterID, H00262_A112BR_Lab_AbnInd, H00262_n112BR_Lab_AbnInd, H00262_A105BR_Lab_SpecimenDate, H00262_n105BR_Lab_SpecimenDate, H00262_A106BR_Lab_SpecimenSource, H00262_n106BR_Lab_SpecimenSource, H00262_A104BR_Lab_TestName, H00262_n104BR_Lab_TestName, H00262_A101BR_LabID
               }
               , new Object[] {
               H00263_AGRID_nRecordCount
               }
            }
         );
         AV90Pgmname = "BR_EncounterUpdateBR_LabWC";
         /* GeneXus formulas. */
         AV90Pgmname = "BR_EncounterUpdateBR_LabWC";
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
      private short edtBR_LabID_Titleformat ;
      private short edtBR_Lab_TestName_Titleformat ;
      private short edtBR_Lab_SpecimenSource_Titleformat ;
      private short edtBR_Lab_SpecimenDate_Titleformat ;
      private short edtBR_Lab_AbnInd_Titleformat ;
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
      private int edtavBack_Visible ;
      private int edtavDelete_Visible ;
      private int subGrid_Selectedindex ;
      private int subGrid_Selectioncolor ;
      private int subGrid_Hoveringcolor ;
      private int edtavDdo_br_labidtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_lab_testnametitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_lab_specimensourcetitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_lab_specimendatetitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_lab_abnindtitlecontrolidtoreplace_Visible ;
      private int edtBR_EncounterID_Visible ;
      private int edtavOrderedby_Visible ;
      private int edtavOrdereddsc_Visible ;
      private int subGrid_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int AV55PageToGo ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private int edtavBack_Enabled ;
      private int edtavDelete_Enabled ;
      private long AV8BR_EncounterID ;
      private long wcpOAV8BR_EncounterID ;
      private long GRID_nFirstRecordOnPage ;
      private long AV56GridCurrentPage ;
      private long AV84GridPageCount ;
      private long A101BR_LabID ;
      private long A19BR_EncounterID ;
      private long GRID_nCurrentRecord ;
      private long GRID_nRecordCount ;
      private String Gridpaginationbar_Selectedpage ;
      private String Ddo_br_labid_Activeeventkey ;
      private String Ddo_br_lab_testname_Activeeventkey ;
      private String Ddo_br_lab_specimensource_Activeeventkey ;
      private String Ddo_br_lab_specimendate_Activeeventkey ;
      private String Ddo_br_lab_abnind_Activeeventkey ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sPrefix ;
      private String sCompPrefix ;
      private String sSFPrefix ;
      private String sGXsfl_28_idx="0001" ;
      private String AV90Pgmname ;
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
      private String Ddo_br_labid_Caption ;
      private String Ddo_br_labid_Tooltip ;
      private String Ddo_br_labid_Cls ;
      private String Ddo_br_labid_Dropdownoptionstype ;
      private String Ddo_br_labid_Titlecontrolidtoreplace ;
      private String Ddo_br_labid_Sortedstatus ;
      private String Ddo_br_labid_Sortasc ;
      private String Ddo_br_labid_Sortdsc ;
      private String Ddo_br_labid_Searchbuttontext ;
      private String Ddo_br_lab_testname_Caption ;
      private String Ddo_br_lab_testname_Tooltip ;
      private String Ddo_br_lab_testname_Cls ;
      private String Ddo_br_lab_testname_Dropdownoptionstype ;
      private String Ddo_br_lab_testname_Titlecontrolidtoreplace ;
      private String Ddo_br_lab_testname_Sortedstatus ;
      private String Ddo_br_lab_testname_Sortasc ;
      private String Ddo_br_lab_testname_Sortdsc ;
      private String Ddo_br_lab_testname_Searchbuttontext ;
      private String Ddo_br_lab_specimensource_Caption ;
      private String Ddo_br_lab_specimensource_Tooltip ;
      private String Ddo_br_lab_specimensource_Cls ;
      private String Ddo_br_lab_specimensource_Dropdownoptionstype ;
      private String Ddo_br_lab_specimensource_Titlecontrolidtoreplace ;
      private String Ddo_br_lab_specimensource_Sortedstatus ;
      private String Ddo_br_lab_specimensource_Sortasc ;
      private String Ddo_br_lab_specimensource_Sortdsc ;
      private String Ddo_br_lab_specimensource_Searchbuttontext ;
      private String Ddo_br_lab_specimendate_Caption ;
      private String Ddo_br_lab_specimendate_Tooltip ;
      private String Ddo_br_lab_specimendate_Cls ;
      private String Ddo_br_lab_specimendate_Dropdownoptionstype ;
      private String Ddo_br_lab_specimendate_Titlecontrolidtoreplace ;
      private String Ddo_br_lab_specimendate_Sortedstatus ;
      private String Ddo_br_lab_specimendate_Sortasc ;
      private String Ddo_br_lab_specimendate_Sortdsc ;
      private String Ddo_br_lab_specimendate_Searchbuttontext ;
      private String Ddo_br_lab_abnind_Caption ;
      private String Ddo_br_lab_abnind_Tooltip ;
      private String Ddo_br_lab_abnind_Cls ;
      private String Ddo_br_lab_abnind_Dropdownoptionstype ;
      private String Ddo_br_lab_abnind_Titlecontrolidtoreplace ;
      private String Ddo_br_lab_abnind_Sortedstatus ;
      private String Ddo_br_lab_abnind_Sortasc ;
      private String Ddo_br_lab_abnind_Sortdsc ;
      private String Ddo_br_lab_abnind_Searchbuttontext ;
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
      private String edtBR_LabID_Title ;
      private String edtBR_Lab_TestName_Title ;
      private String edtBR_Lab_SpecimenSource_Title ;
      private String edtBR_Lab_SpecimenDate_Title ;
      private String edtBR_Lab_AbnInd_Title ;
      private String subGrid_Header ;
      private String edtavDisplay_Link ;
      private String edtavDisplay_Tooltiptext ;
      private String edtavBack_Tooltiptext ;
      private String edtavDelete_Link ;
      private String edtavDelete_Tooltiptext ;
      private String divHtml_gridpaginationbar_Internalname ;
      private String Gridpaginationbar_Internalname ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String Ddo_br_labid_Internalname ;
      private String edtavDdo_br_labidtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_lab_testname_Internalname ;
      private String edtavDdo_br_lab_testnametitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_lab_specimensource_Internalname ;
      private String edtavDdo_br_lab_specimensourcetitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_lab_specimendate_Internalname ;
      private String edtavDdo_br_lab_specimendatetitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_lab_abnind_Internalname ;
      private String edtavDdo_br_lab_abnindtitlecontrolidtoreplace_Internalname ;
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
      private String edtavBack_Internalname ;
      private String edtavDelete_Internalname ;
      private String edtBR_LabID_Internalname ;
      private String edtBR_Lab_TestName_Internalname ;
      private String edtBR_Lab_SpecimenSource_Internalname ;
      private String edtBR_Lab_SpecimenDate_Internalname ;
      private String edtBR_Lab_AbnInd_Internalname ;
      private String scmdbuf ;
      private String sCtrlAV8BR_EncounterID ;
      private String sGXsfl_28_fel_idx="0001" ;
      private String sImgUrl ;
      private String edtavBack_Jsonclick ;
      private String edtavDelete_Jsonclick ;
      private String ROClassString ;
      private String edtBR_LabID_Jsonclick ;
      private String edtBR_Lab_TestName_Jsonclick ;
      private String edtBR_Lab_SpecimenSource_Jsonclick ;
      private String edtBR_Lab_SpecimenDate_Jsonclick ;
      private String edtBR_Lab_AbnInd_Jsonclick ;
      private DateTime A105BR_Lab_SpecimenDate ;
      private bool entryPointCalled ;
      private bool AV15OrderedDsc ;
      private bool AV64IsAuthorized_Display ;
      private bool AV62IsAuthorized_Delete ;
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
      private bool Ddo_br_labid_Includesortasc ;
      private bool Ddo_br_labid_Includesortdsc ;
      private bool Ddo_br_labid_Includefilter ;
      private bool Ddo_br_labid_Includedatalist ;
      private bool Ddo_br_lab_testname_Includesortasc ;
      private bool Ddo_br_lab_testname_Includesortdsc ;
      private bool Ddo_br_lab_testname_Includefilter ;
      private bool Ddo_br_lab_testname_Includedatalist ;
      private bool Ddo_br_lab_specimensource_Includesortasc ;
      private bool Ddo_br_lab_specimensource_Includesortdsc ;
      private bool Ddo_br_lab_specimensource_Includefilter ;
      private bool Ddo_br_lab_specimensource_Includedatalist ;
      private bool Ddo_br_lab_specimendate_Includesortasc ;
      private bool Ddo_br_lab_specimendate_Includesortdsc ;
      private bool Ddo_br_lab_specimendate_Includefilter ;
      private bool Ddo_br_lab_specimendate_Includedatalist ;
      private bool Ddo_br_lab_abnind_Includesortasc ;
      private bool Ddo_br_lab_abnind_Includesortdsc ;
      private bool Ddo_br_lab_abnind_Includefilter ;
      private bool Ddo_br_lab_abnind_Includedatalist ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_28_Refreshing=false ;
      private bool n104BR_Lab_TestName ;
      private bool n106BR_Lab_SpecimenSource ;
      private bool n105BR_Lab_SpecimenDate ;
      private bool n112BR_Lab_AbnInd ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool gx_refresh_fired ;
      private bool AV82IsAuthorized_back ;
      private bool AV65TempBoolean ;
      private bool GXt_boolean2 ;
      private bool AV83tCheckFlag ;
      private bool AV63Display_IsBlob ;
      private bool AV80back_IsBlob ;
      private bool AV61Delete_IsBlob ;
      private String AV18ddo_BR_LabIDTitleControlIdToReplace ;
      private String AV24ddo_BR_Lab_TestNameTitleControlIdToReplace ;
      private String AV28ddo_BR_Lab_SpecimenSourceTitleControlIdToReplace ;
      private String AV26ddo_BR_Lab_SpecimenDateTitleControlIdToReplace ;
      private String AV40ddo_BR_Lab_AbnIndTitleControlIdToReplace ;
      private String A104BR_Lab_TestName ;
      private String A106BR_Lab_SpecimenSource ;
      private String A112BR_Lab_AbnInd ;
      private String AV87Display_GXI ;
      private String AV88Back_GXI ;
      private String AV89Delete_GXI ;
      private String AV63Display ;
      private String AV80back ;
      private String AV61Delete ;
      private IGxSession AV16Session ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private GXUserControl ucDvpanel_tableheader ;
      private GXUserControl ucGridpaginationbar ;
      private GXUserControl ucDdo_br_labid ;
      private GXUserControl ucDdo_br_lab_testname ;
      private GXUserControl ucDdo_br_lab_specimensource ;
      private GXUserControl ucDdo_br_lab_specimendate ;
      private GXUserControl ucDdo_br_lab_abnind ;
      private GXUserControl ucWorkwithplusutilities1 ;
      private GXWebForm Form ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private long[] H00262_A19BR_EncounterID ;
      private String[] H00262_A112BR_Lab_AbnInd ;
      private bool[] H00262_n112BR_Lab_AbnInd ;
      private DateTime[] H00262_A105BR_Lab_SpecimenDate ;
      private bool[] H00262_n105BR_Lab_SpecimenDate ;
      private String[] H00262_A106BR_Lab_SpecimenSource ;
      private bool[] H00262_n106BR_Lab_SpecimenSource ;
      private String[] H00262_A104BR_Lab_TestName ;
      private bool[] H00262_n104BR_Lab_TestName ;
      private long[] H00262_A101BR_LabID ;
      private long[] H00263_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV9HTTPRequest ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV17BR_LabIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV23BR_Lab_TestNameTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV27BR_Lab_SpecimenSourceTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV25BR_Lab_SpecimenDateTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV39BR_Lab_AbnIndTitleFilterData ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV10TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute AV11TrnContextAtt ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV12GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons AV53DDO_TitleSettingsIcons ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 ;
   }

   public class br_encounterupdatebr_labwc__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H00262( IGxContext context ,
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
         sSelectString = " [BR_EncounterID], [BR_Lab_AbnInd], [BR_Lab_SpecimenDate], [BR_Lab_SpecimenSource], [BR_Lab_TestName], [BR_LabID]";
         sFromString = " FROM [BR_Lab] WITH (NOLOCK)";
         sOrderString = "";
         sWhereString = sWhereString + " WHERE ([BR_EncounterID] = @AV8BR_EncounterID)";
         if ( ( AV14OrderedBy == 1 ) && ! AV15OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_LabID] DESC";
         }
         else if ( ( AV14OrderedBy == 1 ) && ( AV15OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_LabID]";
         }
         else if ( ( AV14OrderedBy == 2 ) && ! AV15OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_EncounterID], [BR_Lab_TestName]";
         }
         else if ( ( AV14OrderedBy == 2 ) && ( AV15OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_EncounterID] DESC, [BR_Lab_TestName] DESC";
         }
         else if ( ( AV14OrderedBy == 3 ) && ! AV15OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_EncounterID], [BR_Lab_SpecimenSource]";
         }
         else if ( ( AV14OrderedBy == 3 ) && ( AV15OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_EncounterID] DESC, [BR_Lab_SpecimenSource] DESC";
         }
         else if ( ( AV14OrderedBy == 4 ) && ! AV15OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_EncounterID], [BR_Lab_SpecimenDate]";
         }
         else if ( ( AV14OrderedBy == 4 ) && ( AV15OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_EncounterID] DESC, [BR_Lab_SpecimenDate] DESC";
         }
         else if ( ( AV14OrderedBy == 5 ) && ! AV15OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_EncounterID], [BR_Lab_AbnInd]";
         }
         else if ( ( AV14OrderedBy == 5 ) && ( AV15OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_EncounterID] DESC, [BR_Lab_AbnInd] DESC";
         }
         else if ( true )
         {
            sOrderString = sOrderString + " ORDER BY [BR_LabID]";
         }
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object4[0] = scmdbuf;
         GXv_Object4[1] = GXv_int3;
         return GXv_Object4 ;
      }

      protected Object[] conditional_H00263( IGxContext context ,
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
         scmdbuf = "SELECT COUNT(*) FROM [BR_Lab] WITH (NOLOCK)";
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
                     return conditional_H00262(context, (short)dynConstraints[0] , (bool)dynConstraints[1] , (long)dynConstraints[2] , (long)dynConstraints[3] );
               case 1 :
                     return conditional_H00263(context, (short)dynConstraints[0] , (bool)dynConstraints[1] , (long)dynConstraints[2] , (long)dynConstraints[3] );
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
          Object[] prmH00262 ;
          prmH00262 = new Object[] {
          new Object[] {"@AV8BR_EncounterID",SqlDbType.Decimal,18,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH00263 ;
          prmH00263 = new Object[] {
          new Object[] {"@AV8BR_EncounterID",SqlDbType.Decimal,18,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H00262", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00262,11,0,true,false )
             ,new CursorDef("H00263", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00263,1,0,true,false )
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
                ((DateTime[]) buf[3])[0] = rslt.getGXDateTime(3) ;
                ((bool[]) buf[4])[0] = rslt.wasNull(3);
                ((String[]) buf[5])[0] = rslt.getVarchar(4) ;
                ((bool[]) buf[6])[0] = rslt.wasNull(4);
                ((String[]) buf[7])[0] = rslt.getVarchar(5) ;
                ((bool[]) buf[8])[0] = rslt.wasNull(5);
                ((long[]) buf[9])[0] = rslt.getLong(6) ;
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
