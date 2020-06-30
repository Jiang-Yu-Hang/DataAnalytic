/*
               File: BR_EncounterUpdateBR_ProcedureWC
        Description: Data Mgmt Portal - RAAP
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 11:57:49.10
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
   public class br_encounterupdatebr_procedurewc : GXWebComponent, System.Web.SessionState.IRequiresSessionState
   {
      public br_encounterupdatebr_procedurewc( )
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

      public br_encounterupdatebr_procedurewc( IGxContext context )
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
         cmbBR_Procedure_PXRadiotherapy = new GXCombobox();
         cmbBR_Procedure_PXSurgery = new GXCombobox();
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
                  AV18ddo_BR_ProcedureIDTitleControlIdToReplace = GetNextPar( );
                  AV26ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace = GetNextPar( );
                  AV22ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace = GetNextPar( );
                  AV70Pgmname = GetNextPar( );
                  AV50IsAuthorized_Display = StringUtil.StrToBool( GetNextPar( ));
                  AV46IsAuthorized_Update = StringUtil.StrToBool( GetNextPar( ));
                  sPrefix = GetNextPar( );
                  init_default_properties( ) ;
                  setAjaxCallMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1;
                     return  ;
                  }
                  gxgrGrid_refresh( subGrid_Rows, AV14OrderedBy, AV15OrderedDsc, AV8BR_EncounterID, AV18ddo_BR_ProcedureIDTitleControlIdToReplace, AV26ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace, AV22ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace, AV70Pgmname, AV50IsAuthorized_Display, AV46IsAuthorized_Update, sPrefix) ;
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
            PA282( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               AV70Pgmname = "BR_EncounterUpdateBR_ProcedureWC";
               context.Gx_err = 0;
               WS282( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?202022711574929", false);
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
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/WorkWithPlusUtilities/WorkWithPlusUtilitiesRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/ConfirmPanel/BootstrapConfirmPanelRender.js", "", false);
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
            context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("br_encounterupdatebr_procedurewc.aspx") + "?" + UrlEncode("" +AV8BR_EncounterID)+"\">") ;
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
         GxWebStd.gx_hidden_field( context, sPrefix+"vGRIDCURRENTPAGE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV42GridCurrentPage), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"vGRIDRECORDCOUNT", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV44GridRecordCount), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"vGRIDPAGESIZE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV43GridPageSize), 10, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, sPrefix+"vDDO_TITLESETTINGSICONS", AV39DDO_TitleSettingsIcons);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(sPrefix+"vDDO_TITLESETTINGSICONS", AV39DDO_TitleSettingsIcons);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, sPrefix+"vBR_PROCEDUREIDTITLEFILTERDATA", AV17BR_ProcedureIDTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(sPrefix+"vBR_PROCEDUREIDTITLEFILTERDATA", AV17BR_ProcedureIDTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, sPrefix+"vBR_PROCEDURE_PXRADIOTHERAPYTITLEFILTERDATA", AV25BR_Procedure_PXRadiotherapyTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(sPrefix+"vBR_PROCEDURE_PXRADIOTHERAPYTITLEFILTERDATA", AV25BR_Procedure_PXRadiotherapyTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, sPrefix+"vBR_PROCEDURE_PXSURGERYTITLEFILTERDATA", AV21BR_Procedure_PXSurgeryTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(sPrefix+"vBR_PROCEDURE_PXSURGERYTITLEFILTERDATA", AV21BR_Procedure_PXSurgeryTitleFilterData);
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOAV8BR_EncounterID", StringUtil.LTrim( StringUtil.NToC( (decimal)(wcpOAV8BR_EncounterID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"vPGMNAME", StringUtil.RTrim( AV70Pgmname));
         GxWebStd.gx_boolean_hidden_field( context, sPrefix+"vISAUTHORIZED_DISPLAY", AV50IsAuthorized_Display);
         GxWebStd.gx_boolean_hidden_field( context, sPrefix+"vISAUTHORIZED_UPDATE", AV46IsAuthorized_Update);
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
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PROCEDUREID_Caption", StringUtil.RTrim( Ddo_br_procedureid_Caption));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PROCEDUREID_Tooltip", StringUtil.RTrim( Ddo_br_procedureid_Tooltip));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PROCEDUREID_Cls", StringUtil.RTrim( Ddo_br_procedureid_Cls));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PROCEDUREID_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_procedureid_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PROCEDUREID_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_procedureid_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PROCEDUREID_Includesortasc", StringUtil.BoolToStr( Ddo_br_procedureid_Includesortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PROCEDUREID_Includesortdsc", StringUtil.BoolToStr( Ddo_br_procedureid_Includesortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PROCEDUREID_Sortedstatus", StringUtil.RTrim( Ddo_br_procedureid_Sortedstatus));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PROCEDUREID_Includefilter", StringUtil.BoolToStr( Ddo_br_procedureid_Includefilter));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PROCEDUREID_Includedatalist", StringUtil.BoolToStr( Ddo_br_procedureid_Includedatalist));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PROCEDUREID_Sortasc", StringUtil.RTrim( Ddo_br_procedureid_Sortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PROCEDUREID_Sortdsc", StringUtil.RTrim( Ddo_br_procedureid_Sortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PROCEDUREID_Searchbuttontext", StringUtil.RTrim( Ddo_br_procedureid_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PROCEDURE_PXRADIOTHERAPY_Caption", StringUtil.RTrim( Ddo_br_procedure_pxradiotherapy_Caption));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PROCEDURE_PXRADIOTHERAPY_Tooltip", StringUtil.RTrim( Ddo_br_procedure_pxradiotherapy_Tooltip));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PROCEDURE_PXRADIOTHERAPY_Cls", StringUtil.RTrim( Ddo_br_procedure_pxradiotherapy_Cls));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PROCEDURE_PXRADIOTHERAPY_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_procedure_pxradiotherapy_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PROCEDURE_PXRADIOTHERAPY_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_procedure_pxradiotherapy_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PROCEDURE_PXRADIOTHERAPY_Includesortasc", StringUtil.BoolToStr( Ddo_br_procedure_pxradiotherapy_Includesortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PROCEDURE_PXRADIOTHERAPY_Includesortdsc", StringUtil.BoolToStr( Ddo_br_procedure_pxradiotherapy_Includesortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PROCEDURE_PXRADIOTHERAPY_Sortedstatus", StringUtil.RTrim( Ddo_br_procedure_pxradiotherapy_Sortedstatus));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PROCEDURE_PXRADIOTHERAPY_Includefilter", StringUtil.BoolToStr( Ddo_br_procedure_pxradiotherapy_Includefilter));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PROCEDURE_PXRADIOTHERAPY_Includedatalist", StringUtil.BoolToStr( Ddo_br_procedure_pxradiotherapy_Includedatalist));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PROCEDURE_PXRADIOTHERAPY_Sortasc", StringUtil.RTrim( Ddo_br_procedure_pxradiotherapy_Sortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PROCEDURE_PXRADIOTHERAPY_Sortdsc", StringUtil.RTrim( Ddo_br_procedure_pxradiotherapy_Sortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PROCEDURE_PXRADIOTHERAPY_Searchbuttontext", StringUtil.RTrim( Ddo_br_procedure_pxradiotherapy_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PROCEDURE_PXSURGERY_Caption", StringUtil.RTrim( Ddo_br_procedure_pxsurgery_Caption));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PROCEDURE_PXSURGERY_Tooltip", StringUtil.RTrim( Ddo_br_procedure_pxsurgery_Tooltip));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PROCEDURE_PXSURGERY_Cls", StringUtil.RTrim( Ddo_br_procedure_pxsurgery_Cls));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PROCEDURE_PXSURGERY_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_procedure_pxsurgery_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PROCEDURE_PXSURGERY_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_procedure_pxsurgery_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PROCEDURE_PXSURGERY_Includesortasc", StringUtil.BoolToStr( Ddo_br_procedure_pxsurgery_Includesortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PROCEDURE_PXSURGERY_Includesortdsc", StringUtil.BoolToStr( Ddo_br_procedure_pxsurgery_Includesortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PROCEDURE_PXSURGERY_Sortedstatus", StringUtil.RTrim( Ddo_br_procedure_pxsurgery_Sortedstatus));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PROCEDURE_PXSURGERY_Includefilter", StringUtil.BoolToStr( Ddo_br_procedure_pxsurgery_Includefilter));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PROCEDURE_PXSURGERY_Includedatalist", StringUtil.BoolToStr( Ddo_br_procedure_pxsurgery_Includedatalist));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PROCEDURE_PXSURGERY_Sortasc", StringUtil.RTrim( Ddo_br_procedure_pxsurgery_Sortasc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PROCEDURE_PXSURGERY_Sortdsc", StringUtil.RTrim( Ddo_br_procedure_pxsurgery_Sortdsc));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PROCEDURE_PXSURGERY_Searchbuttontext", StringUtil.RTrim( Ddo_br_procedure_pxsurgery_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, sPrefix+"DVELOP_CONFIRMPANEL_MYDEL_Title", StringUtil.RTrim( Dvelop_confirmpanel_mydel_Title));
         GxWebStd.gx_hidden_field( context, sPrefix+"DVELOP_CONFIRMPANEL_MYDEL_Confirmationtext", StringUtil.RTrim( Dvelop_confirmpanel_mydel_Confirmationtext));
         GxWebStd.gx_hidden_field( context, sPrefix+"DVELOP_CONFIRMPANEL_MYDEL_Yesbuttoncaption", StringUtil.RTrim( Dvelop_confirmpanel_mydel_Yesbuttoncaption));
         GxWebStd.gx_hidden_field( context, sPrefix+"DVELOP_CONFIRMPANEL_MYDEL_Nobuttoncaption", StringUtil.RTrim( Dvelop_confirmpanel_mydel_Nobuttoncaption));
         GxWebStd.gx_hidden_field( context, sPrefix+"DVELOP_CONFIRMPANEL_MYDEL_Cancelbuttoncaption", StringUtil.RTrim( Dvelop_confirmpanel_mydel_Cancelbuttoncaption));
         GxWebStd.gx_hidden_field( context, sPrefix+"DVELOP_CONFIRMPANEL_MYDEL_Yesbuttonposition", StringUtil.RTrim( Dvelop_confirmpanel_mydel_Yesbuttonposition));
         GxWebStd.gx_hidden_field( context, sPrefix+"DVELOP_CONFIRMPANEL_MYDEL_Confirmtype", StringUtil.RTrim( Dvelop_confirmpanel_mydel_Confirmtype));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PROCEDUREID_Activeeventkey", StringUtil.RTrim( Ddo_br_procedureid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PROCEDURE_PXRADIOTHERAPY_Activeeventkey", StringUtil.RTrim( Ddo_br_procedure_pxradiotherapy_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PROCEDURE_PXSURGERY_Activeeventkey", StringUtil.RTrim( Ddo_br_procedure_pxsurgery_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"DVELOP_CONFIRMPANEL_MYDEL_Result", StringUtil.RTrim( Dvelop_confirmpanel_mydel_Result));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, sPrefix+"GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PROCEDUREID_Activeeventkey", StringUtil.RTrim( Ddo_br_procedureid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PROCEDURE_PXRADIOTHERAPY_Activeeventkey", StringUtil.RTrim( Ddo_br_procedure_pxradiotherapy_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"DDO_BR_PROCEDURE_PXSURGERY_Activeeventkey", StringUtil.RTrim( Ddo_br_procedure_pxsurgery_Activeeventkey));
         GxWebStd.gx_hidden_field( context, sPrefix+"DVELOP_CONFIRMPANEL_MYDEL_Result", StringUtil.RTrim( Dvelop_confirmpanel_mydel_Result));
      }

      protected void RenderHtmlCloseForm282( )
      {
         SendCloseFormHiddens( ) ;
         if ( ( StringUtil.Len( sPrefix) != 0 ) && ( context.isAjaxRequest( ) || context.isSpaRequest( ) ) )
         {
            context.AddJavascriptSource("br_encounterupdatebr_procedurewc.js", "?202022711575091", false);
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
         return "BR_EncounterUpdateBR_ProcedureWC" ;
      }

      public override String GetPgmdesc( )
      {
         return "Data Mgmt Portal - RAAP" ;
      }

      protected void WB280( )
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
               GxWebStd.gx_hidden_field( context, sPrefix+"_CMPPGM", "br_encounterupdatebr_procedurewc.aspx");
               context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
               context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
               context.AddJavascriptSource("DVelop/DVPaginationBar/DVPaginationBarRender.js", "", false);
               context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
               context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
               context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
               context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
               context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
               context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
               context.AddJavascriptSource("DVelop/WorkWithPlusUtilities/WorkWithPlusUtilitiesRender.js", "", false);
               context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
               context.AddJavascriptSource("DVelop/Bootstrap/ConfirmPanel/BootstrapConfirmPanelRender.js", "", false);
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
            GxWebStd.gx_button_ctrl( context, bttBtninsert_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(28), 2, 0)+","+"null"+");", "新增", bttBtninsert_Jsonclick, 5, "插入", "", StyleString, ClassString, bttBtninsert_Visible, 1, "standard", "'"+sPrefix+"'"+",false,"+"'"+sPrefix+"E\\'DOINSERT\\'."+"'", TempTags, "", context.GetButtonType( ), "HLP_BR_EncounterUpdateBR_ProcedureWC.htm");
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
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"ActionBaseColorAttribute"+"\" "+" style=\""+((edtavMydel_Visible==0) ? "display:none;" : "")+""+"\" "+">") ;
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
               GridColumn.AddObjectProperty("Value", context.convertURL( AV49Display));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavDisplay_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavDisplay_Tooltiptext));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavDisplay_Visible), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.convertURL( AV45Update));
               GridColumn.AddObjectProperty("Link", StringUtil.RTrim( edtavUpdate_Link));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavUpdate_Tooltiptext));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavUpdate_Visible), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.convertURL( AV60mydel));
               GridColumn.AddObjectProperty("Tooltiptext", StringUtil.RTrim( edtavMydel_Tooltiptext));
               GridColumn.AddObjectProperty("Visible", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtavMydel_Visible), 5, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A139BR_ProcedureID), 18, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_ProcedureID_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_ProcedureID_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A143BR_Procedure_PXRadiotherapy);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( cmbBR_Procedure_PXRadiotherapy.Title.Text));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(cmbBR_Procedure_PXRadiotherapy_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A141BR_Procedure_PXSurgery);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( cmbBR_Procedure_PXSurgery.Title.Text));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(cmbBR_Procedure_PXSurgery_Titleformat), 4, 0, ".", "")));
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
            ucGridpaginationbar.SetProperty("CurrentPage", AV42GridCurrentPage);
            ucGridpaginationbar.SetProperty("RecordCount", AV44GridRecordCount);
            ucGridpaginationbar.SetProperty("Page", AV43GridPageSize);
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
            ucDdo_br_procedureid.SetProperty("DropDownOptionsTitleSettingsIcons", AV39DDO_TitleSettingsIcons);
            ucDdo_br_procedureid.SetProperty("DropDownOptionsData", AV17BR_ProcedureIDTitleFilterData);
            ucDdo_br_procedureid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_procedureid_Internalname, sPrefix+"DDO_BR_PROCEDUREIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'" + sPrefix + "',false,'" + sGXsfl_28_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_procedureidtitlecontrolidtoreplace_Internalname, AV18ddo_BR_ProcedureIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,43);\"", 0, edtavDdo_br_procedureidtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_EncounterUpdateBR_ProcedureWC.htm");
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
            ucDdo_br_procedure_pxradiotherapy.SetProperty("DropDownOptionsTitleSettingsIcons", AV39DDO_TitleSettingsIcons);
            ucDdo_br_procedure_pxradiotherapy.SetProperty("DropDownOptionsData", AV25BR_Procedure_PXRadiotherapyTitleFilterData);
            ucDdo_br_procedure_pxradiotherapy.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_procedure_pxradiotherapy_Internalname, sPrefix+"DDO_BR_PROCEDURE_PXRADIOTHERAPYContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 45,'" + sPrefix + "',false,'" + sGXsfl_28_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_procedure_pxradiotherapytitlecontrolidtoreplace_Internalname, AV26ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,45);\"", 0, edtavDdo_br_procedure_pxradiotherapytitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_EncounterUpdateBR_ProcedureWC.htm");
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
            ucDdo_br_procedure_pxsurgery.SetProperty("DropDownOptionsTitleSettingsIcons", AV39DDO_TitleSettingsIcons);
            ucDdo_br_procedure_pxsurgery.SetProperty("DropDownOptionsData", AV21BR_Procedure_PXSurgeryTitleFilterData);
            ucDdo_br_procedure_pxsurgery.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_procedure_pxsurgery_Internalname, sPrefix+"DDO_BR_PROCEDURE_PXSURGERYContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 47,'" + sPrefix + "',false,'" + sGXsfl_28_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_procedure_pxsurgerytitlecontrolidtoreplace_Internalname, AV22ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,47);\"", 0, edtavDdo_br_procedure_pxsurgerytitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", 0, "HLP_BR_EncounterUpdateBR_ProcedureWC.htm");
            /* Single line edit */
            GxWebStd.gx_single_line_edit( context, edtBR_EncounterID_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A19BR_EncounterID), 18, 0, ".", "")), context.localUtil.Format( (decimal)(A19BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ"), "", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtBR_EncounterID_Jsonclick, 0, "Attribute", "", "", "", "", edtBR_EncounterID_Visible, 0, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "ID", "right", false, "HLP_BR_EncounterUpdateBR_ProcedureWC.htm");
            /* User Defined Control */
            ucWorkwithplusutilities1.Render(context, "dvelop.workwithplusutilities", Workwithplusutilities1_Internalname, sPrefix+"WORKWITHPLUSUTILITIES1Container");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 50,'" + sPrefix + "',false,'" + sGXsfl_28_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavBr_procedureid_selected_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV61BR_ProcedureID_Selected), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV61BR_ProcedureID_Selected), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,50);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavBr_procedureid_selected_Jsonclick, 0, "Attribute", "", "", "", "", edtavBr_procedureid_selected_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_EncounterUpdateBR_ProcedureWC.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 51,'" + sPrefix + "',false,'" + sGXsfl_28_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrderedby_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV14OrderedBy), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV14OrderedBy), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,51);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrderedby_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrderedby_Visible, 1, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_BR_EncounterUpdateBR_ProcedureWC.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 52,'" + sPrefix + "',false,'" + sGXsfl_28_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrdereddsc_Internalname, StringUtil.BoolToStr( AV15OrderedDsc), StringUtil.BoolToStr( AV15OrderedDsc), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,52);\"", "'"+sPrefix+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrdereddsc_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrdereddsc_Visible, 1, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, 0, 0, true, "", "right", false, "HLP_BR_EncounterUpdateBR_ProcedureWC.htm");
            wb_table1_53_282( true) ;
         }
         else
         {
            wb_table1_53_282( false) ;
         }
         return  ;
      }

      protected void wb_table1_53_282e( bool wbgen )
      {
         if ( wbgen )
         {
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

      protected void START282( )
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
               STRUP280( ) ;
            }
         }
      }

      protected void WS282( )
      {
         START282( ) ;
         EVT282( ) ;
      }

      protected void EVT282( )
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
                                 STRUP280( ) ;
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
                                 STRUP280( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    E11282 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEROWSPERPAGE") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP280( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    E12282 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PROCEDUREID.ONOPTIONCLICKED") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP280( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    E13282 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PROCEDURE_PXRADIOTHERAPY.ONOPTIONCLICKED") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP280( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    E14282 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_PROCEDURE_PXSURGERY.ONOPTIONCLICKED") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP280( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    E15282 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DVELOP_CONFIRMPANEL_MYDEL.CLOSE") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP280( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    E16282 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'DOINSERT'") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP280( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: 'DoInsert' */
                                    E17282 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP280( ) ;
                              }
                              if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    GX_FocusControl = edtavDdo_br_procedureidtitlecontrolidtoreplace_Internalname;
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
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 7), "REFRESH") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 9), "GRID.LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 13), "VUPDATE.CLICK") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 13), "VUPDATE.CLICK") == 0 ) )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP280( ) ;
                              }
                              nGXsfl_28_idx = (short)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_28_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_28_idx), 4, 0)), 4, "0");
                              SubsflControlProps_282( ) ;
                              AV49Display = cgiGet( edtavDisplay_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDisplay_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV49Display)) ? AV67Display_GXI : context.convertURL( context.PathToRelativeUrl( AV49Display))), !bGXsfl_28_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDisplay_Internalname, "SrcSet", context.GetImageSrcSet( AV49Display), true);
                              AV45Update = cgiGet( edtavUpdate_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavUpdate_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV45Update)) ? AV68Update_GXI : context.convertURL( context.PathToRelativeUrl( AV45Update))), !bGXsfl_28_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavUpdate_Internalname, "SrcSet", context.GetImageSrcSet( AV45Update), true);
                              AV60mydel = cgiGet( edtavMydel_Internalname);
                              context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavMydel_Internalname, "Bitmap", (String.IsNullOrEmpty(StringUtil.RTrim( AV60mydel)) ? AV69Mydel_GXI : context.convertURL( context.PathToRelativeUrl( AV60mydel))), !bGXsfl_28_Refreshing);
                              context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavMydel_Internalname, "SrcSet", context.GetImageSrcSet( AV60mydel), true);
                              A139BR_ProcedureID = (long)(context.localUtil.CToN( cgiGet( edtBR_ProcedureID_Internalname), ".", ","));
                              cmbBR_Procedure_PXRadiotherapy.Name = cmbBR_Procedure_PXRadiotherapy_Internalname;
                              cmbBR_Procedure_PXRadiotherapy.CurrentValue = cgiGet( cmbBR_Procedure_PXRadiotherapy_Internalname);
                              A143BR_Procedure_PXRadiotherapy = cgiGet( cmbBR_Procedure_PXRadiotherapy_Internalname);
                              n143BR_Procedure_PXRadiotherapy = false;
                              cmbBR_Procedure_PXSurgery.Name = cmbBR_Procedure_PXSurgery_Internalname;
                              cmbBR_Procedure_PXSurgery.CurrentValue = cgiGet( cmbBR_Procedure_PXSurgery_Internalname);
                              A141BR_Procedure_PXSurgery = cgiGet( cmbBR_Procedure_PXSurgery_Internalname);
                              n141BR_Procedure_PXSurgery = false;
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
                                          GX_FocusControl = edtavDdo_br_procedureidtitlecontrolidtoreplace_Internalname;
                                          context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
                                          /* Execute user event: Start */
                                          E18282 ();
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
                                          GX_FocusControl = edtavDdo_br_procedureidtitlecontrolidtoreplace_Internalname;
                                          context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
                                          /* Execute user event: Refresh */
                                          E19282 ();
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
                                          GX_FocusControl = edtavDdo_br_procedureidtitlecontrolidtoreplace_Internalname;
                                          context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
                                          E20282 ();
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
                                          GX_FocusControl = edtavDdo_br_procedureidtitlecontrolidtoreplace_Internalname;
                                          context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
                                          E21282 ();
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
                                       STRUP280( ) ;
                                    }
                                    if ( ! context.WillRedirect( ) && ( context.nUserReturn != 1 ) )
                                    {
                                       context.wbHandled = 1;
                                       if ( ! wbErr )
                                       {
                                          dynload_actions( ) ;
                                          GX_FocusControl = edtavDdo_br_procedureidtitlecontrolidtoreplace_Internalname;
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

      protected void WE282( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm282( ) ;
            }
         }
      }

      protected void PA282( )
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
               GX_FocusControl = edtavDdo_br_procedureidtitlecontrolidtoreplace_Internalname;
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
                                       String AV18ddo_BR_ProcedureIDTitleControlIdToReplace ,
                                       String AV26ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace ,
                                       String AV22ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace ,
                                       String AV70Pgmname ,
                                       bool AV50IsAuthorized_Display ,
                                       bool AV46IsAuthorized_Update ,
                                       String sPrefix )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GRID_nCurrentRecord = 0;
         RF282( ) ;
         /* End function gxgrGrid_refresh */
      }

      protected void send_integrity_hashes( )
      {
         GxWebStd.gx_hidden_field( context, sPrefix+"gxhash_BR_PROCEDUREID", GetSecureSignedToken( sPrefix, context.localUtil.Format( (decimal)(A139BR_ProcedureID), "ZZZZZZZZZZZZZZZZZZ"), context));
         GxWebStd.gx_hidden_field( context, sPrefix+"BR_PROCEDUREID", StringUtil.LTrim( StringUtil.NToC( (decimal)(A139BR_ProcedureID), 18, 0, ".", "")));
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
         RF282( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV70Pgmname = "BR_EncounterUpdateBR_ProcedureWC";
         context.Gx_err = 0;
      }

      protected void RF282( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridContainer.ClearRows();
         }
         wbStart = 28;
         /* Execute user event: Refresh */
         E19282 ();
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
                                                 TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.LONG
                                                 }
            } ) ;
            /* Using cursor H00282 */
            pr_default.execute(0, new Object[] {AV8BR_EncounterID, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_28_idx = 1;
            sGXsfl_28_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_28_idx), 4, 0)), 4, "0");
            SubsflControlProps_282( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < subGrid_Recordsperpage( ) ) ) ) )
            {
               A19BR_EncounterID = H00282_A19BR_EncounterID[0];
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
               n19BR_EncounterID = H00282_n19BR_EncounterID[0];
               A141BR_Procedure_PXSurgery = H00282_A141BR_Procedure_PXSurgery[0];
               n141BR_Procedure_PXSurgery = H00282_n141BR_Procedure_PXSurgery[0];
               A143BR_Procedure_PXRadiotherapy = H00282_A143BR_Procedure_PXRadiotherapy[0];
               n143BR_Procedure_PXRadiotherapy = H00282_n143BR_Procedure_PXRadiotherapy[0];
               A139BR_ProcedureID = H00282_A139BR_ProcedureID[0];
               E20282 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, sPrefix+"GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 28;
            WB280( ) ;
         }
         bGXsfl_28_Refreshing = true;
      }

      protected void send_integrity_lvl_hashes282( )
      {
         GxWebStd.gx_hidden_field( context, sPrefix+"gxhash_BR_PROCEDUREID"+"_"+sGXsfl_28_idx, GetSecureSignedToken( sPrefix+sGXsfl_28_idx, context.localUtil.Format( (decimal)(A139BR_ProcedureID), "ZZZZZZZZZZZZZZZZZZ"), context));
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
                                              TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.BOOLEAN, TypeConstants.LONG
                                              }
         } ) ;
         /* Using cursor H00283 */
         pr_default.execute(1, new Object[] {AV8BR_EncounterID});
         GRID_nRecordCount = H00283_AGRID_nRecordCount[0];
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
            gxgrGrid_refresh( subGrid_Rows, AV14OrderedBy, AV15OrderedDsc, AV8BR_EncounterID, AV18ddo_BR_ProcedureIDTitleControlIdToReplace, AV26ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace, AV22ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace, AV70Pgmname, AV50IsAuthorized_Display, AV46IsAuthorized_Update, sPrefix) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV14OrderedBy, AV15OrderedDsc, AV8BR_EncounterID, AV18ddo_BR_ProcedureIDTitleControlIdToReplace, AV26ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace, AV22ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace, AV70Pgmname, AV50IsAuthorized_Display, AV46IsAuthorized_Update, sPrefix) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV14OrderedBy, AV15OrderedDsc, AV8BR_EncounterID, AV18ddo_BR_ProcedureIDTitleControlIdToReplace, AV26ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace, AV22ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace, AV70Pgmname, AV50IsAuthorized_Display, AV46IsAuthorized_Update, sPrefix) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV14OrderedBy, AV15OrderedDsc, AV8BR_EncounterID, AV18ddo_BR_ProcedureIDTitleControlIdToReplace, AV26ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace, AV22ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace, AV70Pgmname, AV50IsAuthorized_Display, AV46IsAuthorized_Update, sPrefix) ;
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
            gxgrGrid_refresh( subGrid_Rows, AV14OrderedBy, AV15OrderedDsc, AV8BR_EncounterID, AV18ddo_BR_ProcedureIDTitleControlIdToReplace, AV26ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace, AV22ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace, AV70Pgmname, AV50IsAuthorized_Display, AV46IsAuthorized_Update, sPrefix) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUP280( )
      {
         /* Before Start, stand alone formulas. */
         AV70Pgmname = "BR_EncounterUpdateBR_ProcedureWC";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E18282 ();
         context.wbGlbDoneStart = 1;
         nDoneStart = 1;
         /* After Start, stand alone formulas. */
         sXEvt = cgiGet( "_EventName");
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( sPrefix+"vDDO_TITLESETTINGSICONS"), AV39DDO_TitleSettingsIcons);
            ajax_req_read_hidden_sdt(cgiGet( sPrefix+"vBR_PROCEDUREIDTITLEFILTERDATA"), AV17BR_ProcedureIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( sPrefix+"vBR_PROCEDURE_PXRADIOTHERAPYTITLEFILTERDATA"), AV25BR_Procedure_PXRadiotherapyTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( sPrefix+"vBR_PROCEDURE_PXSURGERYTITLEFILTERDATA"), AV21BR_Procedure_PXSurgeryTitleFilterData);
            /* Read variables values. */
            AV18ddo_BR_ProcedureIDTitleControlIdToReplace = cgiGet( edtavDdo_br_procedureidtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV18ddo_BR_ProcedureIDTitleControlIdToReplace", AV18ddo_BR_ProcedureIDTitleControlIdToReplace);
            AV26ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace = cgiGet( edtavDdo_br_procedure_pxradiotherapytitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV26ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace", AV26ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace);
            AV22ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace = cgiGet( edtavDdo_br_procedure_pxsurgerytitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV22ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace", AV22ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace);
            A19BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( edtBR_EncounterID_Internalname), ".", ","));
            n19BR_EncounterID = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "A19BR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(A19BR_EncounterID), 18, 0)));
            if ( ( ( context.localUtil.CToN( cgiGet( edtavBr_procedureid_selected_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavBr_procedureid_selected_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vBR_PROCEDUREID_SELECTED");
               GX_FocusControl = edtavBr_procedureid_selected_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV61BR_ProcedureID_Selected = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV61BR_ProcedureID_Selected", StringUtil.LTrim( StringUtil.Str( (decimal)(AV61BR_ProcedureID_Selected), 18, 0)));
            }
            else
            {
               AV61BR_ProcedureID_Selected = (long)(context.localUtil.CToN( cgiGet( edtavBr_procedureid_selected_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV61BR_ProcedureID_Selected", StringUtil.LTrim( StringUtil.Str( (decimal)(AV61BR_ProcedureID_Selected), 18, 0)));
            }
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
            AV42GridCurrentPage = (long)(context.localUtil.CToN( cgiGet( sPrefix+"vGRIDCURRENTPAGE"), ".", ","));
            AV44GridRecordCount = (long)(context.localUtil.CToN( cgiGet( sPrefix+"vGRIDRECORDCOUNT"), ".", ","));
            AV43GridPageSize = (long)(context.localUtil.CToN( cgiGet( sPrefix+"vGRIDPAGESIZE"), ".", ","));
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
            Ddo_br_procedureid_Caption = cgiGet( sPrefix+"DDO_BR_PROCEDUREID_Caption");
            Ddo_br_procedureid_Tooltip = cgiGet( sPrefix+"DDO_BR_PROCEDUREID_Tooltip");
            Ddo_br_procedureid_Cls = cgiGet( sPrefix+"DDO_BR_PROCEDUREID_Cls");
            Ddo_br_procedureid_Dropdownoptionstype = cgiGet( sPrefix+"DDO_BR_PROCEDUREID_Dropdownoptionstype");
            Ddo_br_procedureid_Titlecontrolidtoreplace = cgiGet( sPrefix+"DDO_BR_PROCEDUREID_Titlecontrolidtoreplace");
            Ddo_br_procedureid_Includesortasc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_PROCEDUREID_Includesortasc"));
            Ddo_br_procedureid_Includesortdsc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_PROCEDUREID_Includesortdsc"));
            Ddo_br_procedureid_Sortedstatus = cgiGet( sPrefix+"DDO_BR_PROCEDUREID_Sortedstatus");
            Ddo_br_procedureid_Includefilter = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_PROCEDUREID_Includefilter"));
            Ddo_br_procedureid_Includedatalist = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_PROCEDUREID_Includedatalist"));
            Ddo_br_procedureid_Sortasc = cgiGet( sPrefix+"DDO_BR_PROCEDUREID_Sortasc");
            Ddo_br_procedureid_Sortdsc = cgiGet( sPrefix+"DDO_BR_PROCEDUREID_Sortdsc");
            Ddo_br_procedureid_Searchbuttontext = cgiGet( sPrefix+"DDO_BR_PROCEDUREID_Searchbuttontext");
            Ddo_br_procedure_pxradiotherapy_Caption = cgiGet( sPrefix+"DDO_BR_PROCEDURE_PXRADIOTHERAPY_Caption");
            Ddo_br_procedure_pxradiotherapy_Tooltip = cgiGet( sPrefix+"DDO_BR_PROCEDURE_PXRADIOTHERAPY_Tooltip");
            Ddo_br_procedure_pxradiotherapy_Cls = cgiGet( sPrefix+"DDO_BR_PROCEDURE_PXRADIOTHERAPY_Cls");
            Ddo_br_procedure_pxradiotherapy_Dropdownoptionstype = cgiGet( sPrefix+"DDO_BR_PROCEDURE_PXRADIOTHERAPY_Dropdownoptionstype");
            Ddo_br_procedure_pxradiotherapy_Titlecontrolidtoreplace = cgiGet( sPrefix+"DDO_BR_PROCEDURE_PXRADIOTHERAPY_Titlecontrolidtoreplace");
            Ddo_br_procedure_pxradiotherapy_Includesortasc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_PROCEDURE_PXRADIOTHERAPY_Includesortasc"));
            Ddo_br_procedure_pxradiotherapy_Includesortdsc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_PROCEDURE_PXRADIOTHERAPY_Includesortdsc"));
            Ddo_br_procedure_pxradiotherapy_Sortedstatus = cgiGet( sPrefix+"DDO_BR_PROCEDURE_PXRADIOTHERAPY_Sortedstatus");
            Ddo_br_procedure_pxradiotherapy_Includefilter = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_PROCEDURE_PXRADIOTHERAPY_Includefilter"));
            Ddo_br_procedure_pxradiotherapy_Includedatalist = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_PROCEDURE_PXRADIOTHERAPY_Includedatalist"));
            Ddo_br_procedure_pxradiotherapy_Sortasc = cgiGet( sPrefix+"DDO_BR_PROCEDURE_PXRADIOTHERAPY_Sortasc");
            Ddo_br_procedure_pxradiotherapy_Sortdsc = cgiGet( sPrefix+"DDO_BR_PROCEDURE_PXRADIOTHERAPY_Sortdsc");
            Ddo_br_procedure_pxradiotherapy_Searchbuttontext = cgiGet( sPrefix+"DDO_BR_PROCEDURE_PXRADIOTHERAPY_Searchbuttontext");
            Ddo_br_procedure_pxsurgery_Caption = cgiGet( sPrefix+"DDO_BR_PROCEDURE_PXSURGERY_Caption");
            Ddo_br_procedure_pxsurgery_Tooltip = cgiGet( sPrefix+"DDO_BR_PROCEDURE_PXSURGERY_Tooltip");
            Ddo_br_procedure_pxsurgery_Cls = cgiGet( sPrefix+"DDO_BR_PROCEDURE_PXSURGERY_Cls");
            Ddo_br_procedure_pxsurgery_Dropdownoptionstype = cgiGet( sPrefix+"DDO_BR_PROCEDURE_PXSURGERY_Dropdownoptionstype");
            Ddo_br_procedure_pxsurgery_Titlecontrolidtoreplace = cgiGet( sPrefix+"DDO_BR_PROCEDURE_PXSURGERY_Titlecontrolidtoreplace");
            Ddo_br_procedure_pxsurgery_Includesortasc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_PROCEDURE_PXSURGERY_Includesortasc"));
            Ddo_br_procedure_pxsurgery_Includesortdsc = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_PROCEDURE_PXSURGERY_Includesortdsc"));
            Ddo_br_procedure_pxsurgery_Sortedstatus = cgiGet( sPrefix+"DDO_BR_PROCEDURE_PXSURGERY_Sortedstatus");
            Ddo_br_procedure_pxsurgery_Includefilter = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_PROCEDURE_PXSURGERY_Includefilter"));
            Ddo_br_procedure_pxsurgery_Includedatalist = StringUtil.StrToBool( cgiGet( sPrefix+"DDO_BR_PROCEDURE_PXSURGERY_Includedatalist"));
            Ddo_br_procedure_pxsurgery_Sortasc = cgiGet( sPrefix+"DDO_BR_PROCEDURE_PXSURGERY_Sortasc");
            Ddo_br_procedure_pxsurgery_Sortdsc = cgiGet( sPrefix+"DDO_BR_PROCEDURE_PXSURGERY_Sortdsc");
            Ddo_br_procedure_pxsurgery_Searchbuttontext = cgiGet( sPrefix+"DDO_BR_PROCEDURE_PXSURGERY_Searchbuttontext");
            Dvelop_confirmpanel_mydel_Title = cgiGet( sPrefix+"DVELOP_CONFIRMPANEL_MYDEL_Title");
            Dvelop_confirmpanel_mydel_Confirmationtext = cgiGet( sPrefix+"DVELOP_CONFIRMPANEL_MYDEL_Confirmationtext");
            Dvelop_confirmpanel_mydel_Yesbuttoncaption = cgiGet( sPrefix+"DVELOP_CONFIRMPANEL_MYDEL_Yesbuttoncaption");
            Dvelop_confirmpanel_mydel_Nobuttoncaption = cgiGet( sPrefix+"DVELOP_CONFIRMPANEL_MYDEL_Nobuttoncaption");
            Dvelop_confirmpanel_mydel_Cancelbuttoncaption = cgiGet( sPrefix+"DVELOP_CONFIRMPANEL_MYDEL_Cancelbuttoncaption");
            Dvelop_confirmpanel_mydel_Yesbuttonposition = cgiGet( sPrefix+"DVELOP_CONFIRMPANEL_MYDEL_Yesbuttonposition");
            Dvelop_confirmpanel_mydel_Confirmtype = cgiGet( sPrefix+"DVELOP_CONFIRMPANEL_MYDEL_Confirmtype");
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( sPrefix+"GRID_Rows"), ".", ","));
            GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            Gridpaginationbar_Selectedpage = cgiGet( sPrefix+"GRIDPAGINATIONBAR_Selectedpage");
            Gridpaginationbar_Rowsperpageselectedvalue = (int)(context.localUtil.CToN( cgiGet( sPrefix+"GRIDPAGINATIONBAR_Rowsperpageselectedvalue"), ".", ","));
            Ddo_br_procedureid_Activeeventkey = cgiGet( sPrefix+"DDO_BR_PROCEDUREID_Activeeventkey");
            Ddo_br_procedure_pxradiotherapy_Activeeventkey = cgiGet( sPrefix+"DDO_BR_PROCEDURE_PXRADIOTHERAPY_Activeeventkey");
            Ddo_br_procedure_pxsurgery_Activeeventkey = cgiGet( sPrefix+"DDO_BR_PROCEDURE_PXSURGERY_Activeeventkey");
            Dvelop_confirmpanel_mydel_Result = cgiGet( sPrefix+"DVELOP_CONFIRMPANEL_MYDEL_Result");
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
         E18282 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E18282( )
      {
         /* Start Routine */
         edtavBr_procedureid_selected_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavBr_procedureid_selected_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavBr_procedureid_selected_Visible), 5, 0)), true);
         subGrid_Rows = 9;
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         Ddo_br_procedureid_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_ProcedureID";
         ucDdo_br_procedureid.SendProperty(context, sPrefix, false, Ddo_br_procedureid_Internalname, "TitleControlIdToReplace", Ddo_br_procedureid_Titlecontrolidtoreplace);
         AV18ddo_BR_ProcedureIDTitleControlIdToReplace = Ddo_br_procedureid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV18ddo_BR_ProcedureIDTitleControlIdToReplace", AV18ddo_BR_ProcedureIDTitleControlIdToReplace);
         edtavDdo_br_procedureidtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDdo_br_procedureidtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_procedureidtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_procedure_pxradiotherapy_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Procedure_PXRadiotherapy";
         ucDdo_br_procedure_pxradiotherapy.SendProperty(context, sPrefix, false, Ddo_br_procedure_pxradiotherapy_Internalname, "TitleControlIdToReplace", Ddo_br_procedure_pxradiotherapy_Titlecontrolidtoreplace);
         AV26ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace = Ddo_br_procedure_pxradiotherapy_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV26ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace", AV26ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace);
         edtavDdo_br_procedure_pxradiotherapytitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDdo_br_procedure_pxradiotherapytitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_procedure_pxradiotherapytitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_procedure_pxsurgery_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Procedure_PXSurgery";
         ucDdo_br_procedure_pxsurgery.SendProperty(context, sPrefix, false, Ddo_br_procedure_pxsurgery_Internalname, "TitleControlIdToReplace", Ddo_br_procedure_pxsurgery_Titlecontrolidtoreplace);
         AV22ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace = Ddo_br_procedure_pxsurgery_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV22ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace", AV22ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace);
         edtavDdo_br_procedure_pxsurgerytitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDdo_br_procedure_pxsurgerytitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_procedure_pxsurgerytitlecontrolidtoreplace_Visible), 5, 0)), true);
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
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 = AV39DDO_TitleSettingsIcons;
         new GeneXus.Programs.wwpbaseobjects.getwwptitlesettingsicons(context ).execute( out  GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1) ;
         AV39DDO_TitleSettingsIcons = GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1;
         Gridpaginationbar_Rowsperpageselectedvalue = subGrid_Rows;
         ucGridpaginationbar.SendProperty(context, sPrefix, false, Gridpaginationbar_Internalname, "RowsPerPageSelectedValue", StringUtil.LTrim( StringUtil.Str( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0)));
      }

      protected void E19282( )
      {
         if ( gx_refresh_fired )
         {
            return  ;
         }
         gx_refresh_fired = true;
         /* Refresh Routine */
         AV17BR_ProcedureIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV25BR_Procedure_PXRadiotherapyTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV21BR_Procedure_PXSurgeryTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
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
         edtBR_ProcedureID_Titleformat = 2;
         edtBR_ProcedureID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "序号", AV18ddo_BR_ProcedureIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtBR_ProcedureID_Internalname, "Title", edtBR_ProcedureID_Title, !bGXsfl_28_Refreshing);
         cmbBR_Procedure_PXRadiotherapy_Titleformat = 2;
         cmbBR_Procedure_PXRadiotherapy.Title.Text = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "是否接受放射疗法", AV26ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, cmbBR_Procedure_PXRadiotherapy_Internalname, "Title", cmbBR_Procedure_PXRadiotherapy.Title.Text, !bGXsfl_28_Refreshing);
         cmbBR_Procedure_PXSurgery_Titleformat = 2;
         cmbBR_Procedure_PXSurgery.Title.Text = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "是否手术", AV22ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, cmbBR_Procedure_PXSurgery_Internalname, "Title", cmbBR_Procedure_PXSurgery.Title.Text, !bGXsfl_28_Refreshing);
         AV42GridCurrentPage = subGrid_Currentpage( );
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV42GridCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV42GridCurrentPage), 10, 0)));
         AV43GridPageSize = subGrid_Rows;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV43GridPageSize", StringUtil.LTrim( StringUtil.Str( (decimal)(AV43GridPageSize), 10, 0)));
         AV44GridRecordCount = subGrid_Recordcount( );
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV44GridRecordCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV44GridRecordCount), 10, 0)));
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV17BR_ProcedureIDTitleFilterData", AV17BR_ProcedureIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV25BR_Procedure_PXRadiotherapyTitleFilterData", AV25BR_Procedure_PXRadiotherapyTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV21BR_Procedure_PXSurgeryTitleFilterData", AV21BR_Procedure_PXSurgeryTitleFilterData);
      }

      protected void E11282( )
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

      protected void E12282( )
      {
         /* Gridpaginationbar_Changerowsperpage Routine */
         subGrid_Rows = Gridpaginationbar_Rowsperpageselectedvalue;
         GxWebStd.gx_hidden_field( context, sPrefix+"GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         subgrid_firstpage( ) ;
         /*  Sending Event outputs  */
      }

      protected void E13282( )
      {
         /* Ddo_br_procedureid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_procedureid_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV14OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14OrderedBy), 4, 0)));
            AV15OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV15OrderedDsc", AV15OrderedDsc);
            Ddo_br_procedureid_Sortedstatus = "ASC";
            ucDdo_br_procedureid.SendProperty(context, sPrefix, false, Ddo_br_procedureid_Internalname, "SortedStatus", Ddo_br_procedureid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         else if ( StringUtil.StrCmp(Ddo_br_procedureid_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV14OrderedBy = 1;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14OrderedBy), 4, 0)));
            AV15OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV15OrderedDsc", AV15OrderedDsc);
            Ddo_br_procedureid_Sortedstatus = "DSC";
            ucDdo_br_procedureid.SendProperty(context, sPrefix, false, Ddo_br_procedureid_Internalname, "SortedStatus", Ddo_br_procedureid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV17BR_ProcedureIDTitleFilterData", AV17BR_ProcedureIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV25BR_Procedure_PXRadiotherapyTitleFilterData", AV25BR_Procedure_PXRadiotherapyTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV21BR_Procedure_PXSurgeryTitleFilterData", AV21BR_Procedure_PXSurgeryTitleFilterData);
      }

      protected void E14282( )
      {
         /* Ddo_br_procedure_pxradiotherapy_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_procedure_pxradiotherapy_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV14OrderedBy = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14OrderedBy), 4, 0)));
            AV15OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV15OrderedDsc", AV15OrderedDsc);
            Ddo_br_procedure_pxradiotherapy_Sortedstatus = "ASC";
            ucDdo_br_procedure_pxradiotherapy.SendProperty(context, sPrefix, false, Ddo_br_procedure_pxradiotherapy_Internalname, "SortedStatus", Ddo_br_procedure_pxradiotherapy_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         else if ( StringUtil.StrCmp(Ddo_br_procedure_pxradiotherapy_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV14OrderedBy = 2;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14OrderedBy), 4, 0)));
            AV15OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV15OrderedDsc", AV15OrderedDsc);
            Ddo_br_procedure_pxradiotherapy_Sortedstatus = "DSC";
            ucDdo_br_procedure_pxradiotherapy.SendProperty(context, sPrefix, false, Ddo_br_procedure_pxradiotherapy_Internalname, "SortedStatus", Ddo_br_procedure_pxradiotherapy_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV17BR_ProcedureIDTitleFilterData", AV17BR_ProcedureIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV25BR_Procedure_PXRadiotherapyTitleFilterData", AV25BR_Procedure_PXRadiotherapyTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV21BR_Procedure_PXSurgeryTitleFilterData", AV21BR_Procedure_PXSurgeryTitleFilterData);
      }

      protected void E15282( )
      {
         /* Ddo_br_procedure_pxsurgery_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_procedure_pxsurgery_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            AV14OrderedBy = 3;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14OrderedBy), 4, 0)));
            AV15OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV15OrderedDsc", AV15OrderedDsc);
            Ddo_br_procedure_pxsurgery_Sortedstatus = "ASC";
            ucDdo_br_procedure_pxsurgery.SendProperty(context, sPrefix, false, Ddo_br_procedure_pxsurgery_Internalname, "SortedStatus", Ddo_br_procedure_pxsurgery_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         else if ( StringUtil.StrCmp(Ddo_br_procedure_pxsurgery_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            AV14OrderedBy = 3;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV14OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14OrderedBy), 4, 0)));
            AV15OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV15OrderedDsc", AV15OrderedDsc);
            Ddo_br_procedure_pxsurgery_Sortedstatus = "DSC";
            ucDdo_br_procedure_pxsurgery.SendProperty(context, sPrefix, false, Ddo_br_procedure_pxsurgery_Internalname, "SortedStatus", Ddo_br_procedure_pxsurgery_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV17BR_ProcedureIDTitleFilterData", AV17BR_ProcedureIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV25BR_Procedure_PXRadiotherapyTitleFilterData", AV25BR_Procedure_PXRadiotherapyTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV21BR_Procedure_PXSurgeryTitleFilterData", AV21BR_Procedure_PXSurgeryTitleFilterData);
      }

      private void E20282( )
      {
         /* Grid_Load Routine */
         AV49Display = context.GetImagePath( "f11923b6-6acd-4a79-bfc0-0cfc6f3bced5", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, edtavDisplay_Internalname, AV49Display);
         AV67Display_GXI = GXDbFile.PathToUrl( context.GetImagePath( "f11923b6-6acd-4a79-bfc0-0cfc6f3bced5", "", context.GetTheme( )));
         edtavDisplay_Tooltiptext = "显示";
         if ( AV50IsAuthorized_Display )
         {
            edtavDisplay_Link = formatLink("br_procedureview.aspx") + "?" + UrlEncode("" +A139BR_ProcedureID) + "," + UrlEncode(StringUtil.RTrim(""));
         }
         AV45Update = context.GetImagePath( "7c63c2b9-483e-4035-b512-febf9186a274", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, edtavUpdate_Internalname, AV45Update);
         AV68Update_GXI = GXDbFile.PathToUrl( context.GetImagePath( "7c63c2b9-483e-4035-b512-febf9186a274", "", context.GetTheme( )));
         edtavUpdate_Tooltiptext = "修改";
         if ( AV46IsAuthorized_Update )
         {
            edtavUpdate_Link = formatLink("br_procedure.aspx") + "?" + UrlEncode(StringUtil.RTrim("UPD")) + "," + UrlEncode("" +A139BR_ProcedureID);
         }
         AV60mydel = context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", context.GetTheme( ));
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, edtavMydel_Internalname, AV60mydel);
         AV69Mydel_GXI = GXDbFile.PathToUrl( context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", context.GetTheme( )));
         edtavMydel_Tooltiptext = "";
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

      protected void E16282( )
      {
         /* Dvelop_confirmpanel_mydel_Close Routine */
         new zutil_checksession(context ).execute( out  AV64tCheckFlag) ;
         if ( ! AV64tCheckFlag )
         {
            if ( StringUtil.StrCmp(Dvelop_confirmpanel_mydel_Result, "Yes") == 0 )
            {
               /* Execute user subroutine: 'DO MYDEL' */
               S152 ();
               if ( returnInSub )
               {
                  returnInSub = true;
                  if (true) return;
               }
            }
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV17BR_ProcedureIDTitleFilterData", AV17BR_ProcedureIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV25BR_Procedure_PXRadiotherapyTitleFilterData", AV25BR_Procedure_PXRadiotherapyTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, "AV21BR_Procedure_PXSurgeryTitleFilterData", AV21BR_Procedure_PXSurgeryTitleFilterData);
      }

      protected void E17282( )
      {
         /* 'DoInsert' Routine */
         if ( 1 == 0 )
         {
            CallWebObject(formatLink("br_procedure.aspx") + "?" + UrlEncode(StringUtil.RTrim("INS")) + "," + UrlEncode("" +0));
            context.wjLocDisableFrm = 1;
         }
         CallWebObject(formatLink("br_procedureinsert.aspx") + "?" + UrlEncode("" +AV8BR_EncounterID));
         context.wjLocDisableFrm = 1;
      }

      protected void S132( )
      {
         /* 'CHECKSECURITYFORACTIONS' Routine */
         GXt_boolean2 = AV50IsAuthorized_Display;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Procedure", out  GXt_boolean2) ;
         AV50IsAuthorized_Display = GXt_boolean2;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV50IsAuthorized_Display", AV50IsAuthorized_Display);
         if ( ! ( AV50IsAuthorized_Display ) )
         {
            edtavDisplay_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavDisplay_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDisplay_Visible), 5, 0)), !bGXsfl_28_Refreshing);
         }
         GXt_boolean2 = AV46IsAuthorized_Update;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Procedure", out  GXt_boolean2) ;
         AV46IsAuthorized_Update = GXt_boolean2;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV46IsAuthorized_Update", AV46IsAuthorized_Update);
         if ( ! ( AV46IsAuthorized_Update ) )
         {
            edtavUpdate_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavUpdate_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavUpdate_Visible), 5, 0)), !bGXsfl_28_Refreshing);
         }
         GXt_boolean2 = AV62IsAuthorized_mydel;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Procedure", out  GXt_boolean2) ;
         AV62IsAuthorized_mydel = GXt_boolean2;
         if ( ! ( AV62IsAuthorized_mydel ) )
         {
            edtavMydel_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, edtavMydel_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavMydel_Visible), 5, 0)), !bGXsfl_28_Refreshing);
         }
         GXt_boolean2 = AV51TempBoolean;
         new GeneXus.Programs.wwpbaseobjects.secisauthbyfunctionalitykey(context ).execute(  "Manage_Procedure", out  GXt_boolean2) ;
         AV51TempBoolean = GXt_boolean2;
         if ( ! ( AV51TempBoolean ) )
         {
            bttBtninsert_Visible = 0;
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, bttBtninsert_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtninsert_Visible), 5, 0)), true);
         }
      }

      protected void S152( )
      {
         /* 'DO MYDEL' Routine */
         new zutil_checksession(context ).execute( out  AV64tCheckFlag) ;
         if ( ! AV64tCheckFlag )
         {
            new zbr_deleteprocedure(context ).execute(  A139BR_ProcedureID) ;
            context.DoAjaxRefreshCmp(sPrefix);
         }
      }

      protected void S122( )
      {
         /* 'LOADGRIDSTATE' Routine */
         if ( StringUtil.StrCmp(AV16Session.Get(AV70Pgmname+"GridState"), "") == 0 )
         {
            AV12GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  AV70Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         else
         {
            AV12GridState.FromXml(AV16Session.Get(AV70Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
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
         AV12GridState.FromXml(AV16Session.Get(AV70Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         AV12GridState.gxTpr_Orderedby = AV14OrderedBy;
         AV12GridState.gxTpr_Ordereddsc = AV15OrderedDsc;
         AV12GridState.gxTpr_Pagesize = StringUtil.Str( (decimal)(subGrid_Rows), 10, 0);
         new GeneXus.Programs.wwpbaseobjects.savegridstate(context ).execute(  AV70Pgmname+"GridState",  AV12GridState.ToXml(false, true, "WWPGridState", "DataAnalysisPlatform")) ;
      }

      protected void S112( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV10TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV10TrnContext.gxTpr_Callerobject = AV70Pgmname;
         AV10TrnContext.gxTpr_Callerondelete = true;
         AV10TrnContext.gxTpr_Callerurl = AV9HTTPRequest.ScriptName+"?"+AV9HTTPRequest.QueryString;
         AV10TrnContext.gxTpr_Transactionname = "BR_Procedure";
         AV11TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         AV11TrnContextAtt.gxTpr_Attributename = "BR_EncounterID";
         AV11TrnContextAtt.gxTpr_Attributevalue = StringUtil.Str( (decimal)(AV8BR_EncounterID), 18, 0);
         AV10TrnContext.gxTpr_Attributes.Add(AV11TrnContextAtt, 0);
         AV16Session.Set("TrnContext", AV10TrnContext.ToXml(false, true, "WWPTransactionContext", "DataAnalysisPlatform"));
      }

      protected void E21282( )
      {
         /* Update_Click Routine */
         new zutil_checksession(context ).execute( out  AV64tCheckFlag) ;
         if ( ! AV64tCheckFlag )
         {
            CallWebObject(formatLink("br_procedureupdate.aspx") + "?" + UrlEncode("" +A139BR_ProcedureID));
            context.wjLocDisableFrm = 1;
         }
      }

      protected void wb_table1_53_282( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "";
            GxWebStd.gx_table_start( context, tblTabledvelop_confirmpanel_mydel_Internalname, tblTabledvelop_confirmpanel_mydel_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td data-align=\"center\"  style=\""+CSSHelper.Prettify( "text-align:-khtml-center;text-align:-moz-center;text-align:-webkit-center")+"\">") ;
            /* User Defined Control */
            ucDvelop_confirmpanel_mydel.SetProperty("Title", Dvelop_confirmpanel_mydel_Title);
            ucDvelop_confirmpanel_mydel.SetProperty("ConfirmationText", Dvelop_confirmpanel_mydel_Confirmationtext);
            ucDvelop_confirmpanel_mydel.SetProperty("YesButtonCaption", Dvelop_confirmpanel_mydel_Yesbuttoncaption);
            ucDvelop_confirmpanel_mydel.SetProperty("NoButtonCaption", Dvelop_confirmpanel_mydel_Nobuttoncaption);
            ucDvelop_confirmpanel_mydel.SetProperty("CancelButtonCaption", Dvelop_confirmpanel_mydel_Cancelbuttoncaption);
            ucDvelop_confirmpanel_mydel.SetProperty("YesButtonPosition", Dvelop_confirmpanel_mydel_Yesbuttonposition);
            ucDvelop_confirmpanel_mydel.SetProperty("ConfirmType", Dvelop_confirmpanel_mydel_Confirmtype);
            ucDvelop_confirmpanel_mydel.Render(context, "dvelop.gxbootstrap.confirmpanel", Dvelop_confirmpanel_mydel_Internalname, sPrefix+"DVELOP_CONFIRMPANEL_MYDELContainer");
            context.WriteHtmlText( "<div class=\"gx_usercontrol_child\" id=\""+sPrefix+"DVELOP_CONFIRMPANEL_MYDELContainer"+"Body"+"\" style=\"display:none;\">") ;
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_53_282e( true) ;
         }
         else
         {
            wb_table1_53_282e( false) ;
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
         PA282( ) ;
         WS282( ) ;
         WE282( ) ;
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
         PA282( ) ;
         WCParametersGet( ) ;
      }

      public override void componentprepare( Object[] obj )
      {
         wbLoad = false;
         sCompPrefix = (String)getParm(obj,0);
         sSFPrefix = (String)getParm(obj,1);
         sPrefix = sCompPrefix + sSFPrefix;
         AddComponentObject(sPrefix, "br_encounterupdatebr_procedurewc", GetJustCreated( ));
         if ( ( nDoneStart == 0 ) && ( nDynComponent == 0 ) )
         {
            INITWEB( ) ;
         }
         else
         {
            init_default_properties( ) ;
            init_web_controls( ) ;
         }
         PA282( ) ;
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
         PA282( ) ;
         sEvt = sCompEvt;
         WCParametersGet( ) ;
         WS282( ) ;
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
         WS282( ) ;
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
         WE282( ) ;
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
         AddThemeStyleSheetFile("", context.GetTheme( )+".css", "?"+GetCacheInvalidationToken( ));
         bool outputEnabled = isOutputEnabled( ) ;
         if ( context.isSpaRequest( ) )
         {
            enableOutput();
         }
         idxLst = 1;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?202022711575770", true);
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
         context.AddJavascriptSource("br_encounterupdatebr_procedurewc.js", "?202022711575771", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Panel/BootstrapPanelRender.js", "", false);
         context.AddJavascriptSource("DVelop/DVPaginationBar/DVPaginationBarRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/WorkWithPlusUtilities/WorkWithPlusUtilitiesRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/ConfirmPanel/BootstrapConfirmPanelRender.js", "", false);
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_282( )
      {
         edtavDisplay_Internalname = sPrefix+"vDISPLAY_"+sGXsfl_28_idx;
         edtavUpdate_Internalname = sPrefix+"vUPDATE_"+sGXsfl_28_idx;
         edtavMydel_Internalname = sPrefix+"vMYDEL_"+sGXsfl_28_idx;
         edtBR_ProcedureID_Internalname = sPrefix+"BR_PROCEDUREID_"+sGXsfl_28_idx;
         cmbBR_Procedure_PXRadiotherapy_Internalname = sPrefix+"BR_PROCEDURE_PXRADIOTHERAPY_"+sGXsfl_28_idx;
         cmbBR_Procedure_PXSurgery_Internalname = sPrefix+"BR_PROCEDURE_PXSURGERY_"+sGXsfl_28_idx;
      }

      protected void SubsflControlProps_fel_282( )
      {
         edtavDisplay_Internalname = sPrefix+"vDISPLAY_"+sGXsfl_28_fel_idx;
         edtavUpdate_Internalname = sPrefix+"vUPDATE_"+sGXsfl_28_fel_idx;
         edtavMydel_Internalname = sPrefix+"vMYDEL_"+sGXsfl_28_fel_idx;
         edtBR_ProcedureID_Internalname = sPrefix+"BR_PROCEDUREID_"+sGXsfl_28_fel_idx;
         cmbBR_Procedure_PXRadiotherapy_Internalname = sPrefix+"BR_PROCEDURE_PXRADIOTHERAPY_"+sGXsfl_28_fel_idx;
         cmbBR_Procedure_PXSurgery_Internalname = sPrefix+"BR_PROCEDURE_PXSURGERY_"+sGXsfl_28_fel_idx;
      }

      protected void sendrow_282( )
      {
         SubsflControlProps_282( ) ;
         WB280( ) ;
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
            AV49Display_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV49Display))&&String.IsNullOrEmpty(StringUtil.RTrim( AV67Display_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV49Display)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV49Display)) ? AV67Display_GXI : context.PathToRelativeUrl( AV49Display));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavDisplay_Internalname,(String)sImgUrl,(String)edtavDisplay_Link,(String)"",(String)"",context.GetTheme( ),(int)edtavDisplay_Visible,(short)1,(String)"",(String)edtavDisplay_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(short)1,(bool)AV49Display_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((edtavUpdate_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Active Bitmap Variable */
            TempTags = " " + ((edtavUpdate_Enabled!=0)&&(edtavUpdate_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 30,'"+sPrefix+"',false,'',28)\"" : " ");
            ClassString = "ActionBaseColorAttribute";
            StyleString = "";
            AV45Update_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV45Update))&&String.IsNullOrEmpty(StringUtil.RTrim( AV68Update_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV45Update)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV45Update)) ? AV68Update_GXI : context.PathToRelativeUrl( AV45Update));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavUpdate_Internalname,(String)sImgUrl,(String)"",(String)"",(String)"",context.GetTheme( ),(int)edtavUpdate_Visible,(short)1,(String)"",(String)edtavUpdate_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)5,(String)edtavUpdate_Jsonclick,"'"+sPrefix+"'"+",false,"+"'"+sPrefix+"EVUPDATE.CLICK."+sGXsfl_28_idx+"'",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)""+TempTags,(String)"",(String)"",(short)1,(bool)AV45Update_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((edtavMydel_Visible==0) ? "display:none;" : "")+"\">") ;
            }
            /* Active Bitmap Variable */
            TempTags = " " + ((edtavMydel_Enabled!=0)&&(edtavMydel_Visible!=0) ? " onfocus=\"gx.evt.onfocus(this, 31,'"+sPrefix+"',false,'',28)\"" : " ");
            ClassString = "ActionBaseColorAttribute";
            StyleString = "";
            AV60mydel_IsBlob = (bool)((String.IsNullOrEmpty(StringUtil.RTrim( AV60mydel))&&String.IsNullOrEmpty(StringUtil.RTrim( AV69Mydel_GXI)))||!String.IsNullOrEmpty(StringUtil.RTrim( AV60mydel)));
            sImgUrl = (String.IsNullOrEmpty(StringUtil.RTrim( AV60mydel)) ? AV69Mydel_GXI : context.PathToRelativeUrl( AV60mydel));
            GridRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavMydel_Internalname,(String)sImgUrl,(String)"",(String)"",(String)"",context.GetTheme( ),(int)edtavMydel_Visible,(short)1,(String)"",(String)edtavMydel_Tooltiptext,(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)7,(String)edtavMydel_Jsonclick,(String)"'"+sPrefix+"'"+",false,"+"'"+"e22282_client"+"'",(String)StyleString,(String)ClassString,(String)"WWActionColumn",(String)"",(String)"",(String)"",(String)""+TempTags,(String)"",(String)"",(short)1,(bool)AV60mydel_IsBlob,(bool)false,context.GetImageSrcSet( sImgUrl)});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_ProcedureID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A139BR_ProcedureID), 18, 0, ".", "")),context.localUtil.Format( (decimal)(A139BR_ProcedureID), "ZZZZZZZZZZZZZZZZZZ"),(String)"",(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_ProcedureID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs hidden-sm",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)28,(short)1,(short)-1,(short)0,(bool)true,(String)"ID",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            if ( ( cmbBR_Procedure_PXRadiotherapy.ItemCount == 0 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "BR_PROCEDURE_PXRADIOTHERAPY_" + sGXsfl_28_idx;
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
            GridRow.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbBR_Procedure_PXRadiotherapy,(String)cmbBR_Procedure_PXRadiotherapy_Internalname,StringUtil.RTrim( A143BR_Procedure_PXRadiotherapy),(short)1,(String)cmbBR_Procedure_PXRadiotherapy_Jsonclick,(short)0,(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"svchar",(String)"",(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)"",(String)"Attribute",(String)"WWColumn",(String)"",(String)"",(String)"",(bool)true});
            cmbBR_Procedure_PXRadiotherapy.CurrentValue = StringUtil.RTrim( A143BR_Procedure_PXRadiotherapy);
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, cmbBR_Procedure_PXRadiotherapy_Internalname, "Values", (String)(cmbBR_Procedure_PXRadiotherapy.ToJavascriptSource()), !bGXsfl_28_Refreshing);
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            if ( ( cmbBR_Procedure_PXSurgery.ItemCount == 0 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "BR_PROCEDURE_PXSURGERY_" + sGXsfl_28_idx;
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
            GridRow.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbBR_Procedure_PXSurgery,(String)cmbBR_Procedure_PXSurgery_Internalname,StringUtil.RTrim( A141BR_Procedure_PXSurgery),(short)1,(String)cmbBR_Procedure_PXSurgery_Jsonclick,(short)0,(String)"'"+sPrefix+"'"+",false,"+"'"+""+"'",(String)"svchar",(String)"",(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)"",(String)"Attribute",(String)"WWColumn",(String)"",(String)"",(String)"",(bool)true});
            cmbBR_Procedure_PXSurgery.CurrentValue = StringUtil.RTrim( A141BR_Procedure_PXSurgery);
            context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, cmbBR_Procedure_PXSurgery_Internalname, "Values", (String)(cmbBR_Procedure_PXSurgery.ToJavascriptSource()), !bGXsfl_28_Refreshing);
            send_integrity_lvl_hashes282( ) ;
            GridContainer.AddRow(GridRow);
            nGXsfl_28_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_28_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_28_idx+1));
            sGXsfl_28_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_28_idx), 4, 0)), 4, "0");
            SubsflControlProps_282( ) ;
         }
         /* End function sendrow_282 */
      }

      protected void init_web_controls( )
      {
         GXCCtl = "BR_PROCEDURE_PXRADIOTHERAPY_" + sGXsfl_28_idx;
         cmbBR_Procedure_PXRadiotherapy.Name = GXCCtl;
         cmbBR_Procedure_PXRadiotherapy.WebTags = "";
         cmbBR_Procedure_PXRadiotherapy.addItem("否", "否", 0);
         cmbBR_Procedure_PXRadiotherapy.addItem("是", "是", 0);
         cmbBR_Procedure_PXRadiotherapy.addItem("不详", "不详", 0);
         if ( cmbBR_Procedure_PXRadiotherapy.ItemCount > 0 )
         {
         }
         GXCCtl = "BR_PROCEDURE_PXSURGERY_" + sGXsfl_28_idx;
         cmbBR_Procedure_PXSurgery.Name = GXCCtl;
         cmbBR_Procedure_PXSurgery.WebTags = "";
         cmbBR_Procedure_PXSurgery.addItem("否", "否", 0);
         cmbBR_Procedure_PXSurgery.addItem("是", "是", 0);
         cmbBR_Procedure_PXSurgery.addItem("不详", "不详", 0);
         if ( cmbBR_Procedure_PXSurgery.ItemCount > 0 )
         {
         }
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
         edtavMydel_Internalname = sPrefix+"vMYDEL";
         edtBR_ProcedureID_Internalname = sPrefix+"BR_PROCEDUREID";
         cmbBR_Procedure_PXRadiotherapy_Internalname = sPrefix+"BR_PROCEDURE_PXRADIOTHERAPY";
         cmbBR_Procedure_PXSurgery_Internalname = sPrefix+"BR_PROCEDURE_PXSURGERY";
         Gridpaginationbar_Internalname = sPrefix+"GRIDPAGINATIONBAR";
         divHtml_gridpaginationbar_Internalname = sPrefix+"HTML_GRIDPAGINATIONBAR";
         divGridtablewithpaginationbar_Internalname = sPrefix+"GRIDTABLEWITHPAGINATIONBAR";
         divTablegridheader_Internalname = sPrefix+"TABLEGRIDHEADER";
         Ddo_br_procedureid_Internalname = sPrefix+"DDO_BR_PROCEDUREID";
         edtavDdo_br_procedureidtitlecontrolidtoreplace_Internalname = sPrefix+"vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE";
         Ddo_br_procedure_pxradiotherapy_Internalname = sPrefix+"DDO_BR_PROCEDURE_PXRADIOTHERAPY";
         edtavDdo_br_procedure_pxradiotherapytitlecontrolidtoreplace_Internalname = sPrefix+"vDDO_BR_PROCEDURE_PXRADIOTHERAPYTITLECONTROLIDTOREPLACE";
         Ddo_br_procedure_pxsurgery_Internalname = sPrefix+"DDO_BR_PROCEDURE_PXSURGERY";
         edtavDdo_br_procedure_pxsurgerytitlecontrolidtoreplace_Internalname = sPrefix+"vDDO_BR_PROCEDURE_PXSURGERYTITLECONTROLIDTOREPLACE";
         edtBR_EncounterID_Internalname = sPrefix+"BR_ENCOUNTERID";
         Workwithplusutilities1_Internalname = sPrefix+"WORKWITHPLUSUTILITIES1";
         edtavBr_procedureid_selected_Internalname = sPrefix+"vBR_PROCEDUREID_SELECTED";
         edtavOrderedby_Internalname = sPrefix+"vORDEREDBY";
         edtavOrdereddsc_Internalname = sPrefix+"vORDEREDDSC";
         Dvelop_confirmpanel_mydel_Internalname = sPrefix+"DVELOP_CONFIRMPANEL_MYDEL";
         tblTabledvelop_confirmpanel_mydel_Internalname = sPrefix+"TABLEDVELOP_CONFIRMPANEL_MYDEL";
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
         cmbBR_Procedure_PXSurgery_Jsonclick = "";
         cmbBR_Procedure_PXRadiotherapy_Jsonclick = "";
         edtBR_ProcedureID_Jsonclick = "";
         edtavMydel_Jsonclick = "";
         edtavMydel_Enabled = 1;
         edtavUpdate_Jsonclick = "";
         edtavUpdate_Enabled = 1;
         edtavOrdereddsc_Jsonclick = "";
         edtavOrdereddsc_Visible = 1;
         edtavOrderedby_Jsonclick = "";
         edtavOrderedby_Visible = 1;
         edtavBr_procedureid_selected_Jsonclick = "";
         edtavBr_procedureid_selected_Visible = 1;
         edtBR_EncounterID_Jsonclick = "";
         edtBR_EncounterID_Visible = 1;
         edtavDdo_br_procedure_pxsurgerytitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_procedure_pxradiotherapytitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_procedureidtitlecontrolidtoreplace_Visible = 1;
         subGrid_Allowcollapsing = 0;
         subGrid_Allowselection = 0;
         edtavMydel_Tooltiptext = "";
         edtavUpdate_Tooltiptext = "修改";
         edtavUpdate_Link = "";
         edtavDisplay_Tooltiptext = "显示";
         edtavDisplay_Link = "";
         subGrid_Sortable = 0;
         subGrid_Header = "";
         cmbBR_Procedure_PXSurgery_Titleformat = 0;
         cmbBR_Procedure_PXSurgery.Title.Text = "是否手术";
         cmbBR_Procedure_PXRadiotherapy_Titleformat = 0;
         cmbBR_Procedure_PXRadiotherapy.Title.Text = "是否接受放射疗法";
         edtBR_ProcedureID_Titleformat = 0;
         edtBR_ProcedureID_Title = "序号";
         edtavMydel_Visible = -1;
         edtavUpdate_Visible = -1;
         edtavDisplay_Visible = -1;
         subGrid_Class = "GridWithPaginationBar GridWithBorderColor WorkWith";
         subGrid_Backcolorstyle = 0;
         bttBtninsert_Visible = 1;
         Dvelop_confirmpanel_mydel_Confirmtype = "1";
         Dvelop_confirmpanel_mydel_Yesbuttonposition = "left";
         Dvelop_confirmpanel_mydel_Cancelbuttoncaption = "WWP_ConfirmTextCancel";
         Dvelop_confirmpanel_mydel_Nobuttoncaption = "WWP_ConfirmTextNo";
         Dvelop_confirmpanel_mydel_Yesbuttoncaption = "WWP_ConfirmTextYes";
         Dvelop_confirmpanel_mydel_Confirmationtext = "确认删除？";
         Dvelop_confirmpanel_mydel_Title = "";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV50IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'AV46IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'sPrefix'},{av:'AV18ddo_BR_ProcedureIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXRADIOTHERAPYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXSURGERYTITLECONTROLIDTOREPLACE',pic:''},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV70Pgmname',fld:'vPGMNAME',pic:''},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''}]");
         setEventMetadata("REFRESH",",oparms:[{av:'AV17BR_ProcedureIDTitleFilterData',fld:'vBR_PROCEDUREIDTITLEFILTERDATA',pic:''},{av:'AV25BR_Procedure_PXRadiotherapyTitleFilterData',fld:'vBR_PROCEDURE_PXRADIOTHERAPYTITLEFILTERDATA',pic:''},{av:'AV21BR_Procedure_PXSurgeryTitleFilterData',fld:'vBR_PROCEDURE_PXSURGERYTITLEFILTERDATA',pic:''},{av:'edtBR_ProcedureID_Titleformat',ctrl:'BR_PROCEDUREID',prop:'Titleformat'},{av:'edtBR_ProcedureID_Title',ctrl:'BR_PROCEDUREID',prop:'Title'},{av:'cmbBR_Procedure_PXRadiotherapy'},{av:'cmbBR_Procedure_PXSurgery'},{av:'AV42GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV43GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV44GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV50IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'edtavDisplay_Visible',ctrl:'vDISPLAY',prop:'Visible'},{av:'AV46IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'edtavMydel_Visible',ctrl:'vMYDEL',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE","{handler:'E11282',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18ddo_BR_ProcedureIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXRADIOTHERAPYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXSURGERYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV70Pgmname',fld:'vPGMNAME',pic:''},{av:'AV50IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'AV46IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'sPrefix'},{av:'Gridpaginationbar_Selectedpage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE",",oparms:[]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE","{handler:'E12282',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18ddo_BR_ProcedureIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXRADIOTHERAPYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXSURGERYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV70Pgmname',fld:'vPGMNAME',pic:''},{av:'AV50IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'AV46IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'sPrefix'},{av:'Gridpaginationbar_Rowsperpageselectedvalue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE",",oparms:[{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]}");
         setEventMetadata("DDO_BR_PROCEDUREID.ONOPTIONCLICKED","{handler:'E13282',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18ddo_BR_ProcedureIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXRADIOTHERAPYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXSURGERYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV70Pgmname',fld:'vPGMNAME',pic:''},{av:'AV50IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'AV46IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'sPrefix'},{av:'Ddo_br_procedureid_Activeeventkey',ctrl:'DDO_BR_PROCEDUREID',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_PROCEDUREID.ONOPTIONCLICKED",",oparms:[{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_procedureid_Sortedstatus',ctrl:'DDO_BR_PROCEDUREID',prop:'SortedStatus'},{av:'AV17BR_ProcedureIDTitleFilterData',fld:'vBR_PROCEDUREIDTITLEFILTERDATA',pic:''},{av:'AV25BR_Procedure_PXRadiotherapyTitleFilterData',fld:'vBR_PROCEDURE_PXRADIOTHERAPYTITLEFILTERDATA',pic:''},{av:'AV21BR_Procedure_PXSurgeryTitleFilterData',fld:'vBR_PROCEDURE_PXSURGERYTITLEFILTERDATA',pic:''},{av:'edtBR_ProcedureID_Titleformat',ctrl:'BR_PROCEDUREID',prop:'Titleformat'},{av:'edtBR_ProcedureID_Title',ctrl:'BR_PROCEDUREID',prop:'Title'},{av:'cmbBR_Procedure_PXRadiotherapy'},{av:'cmbBR_Procedure_PXSurgery'},{av:'AV42GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV43GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV44GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV50IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'edtavDisplay_Visible',ctrl:'vDISPLAY',prop:'Visible'},{av:'AV46IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'edtavMydel_Visible',ctrl:'vMYDEL',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_PROCEDURE_PXRADIOTHERAPY.ONOPTIONCLICKED","{handler:'E14282',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18ddo_BR_ProcedureIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXRADIOTHERAPYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXSURGERYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV70Pgmname',fld:'vPGMNAME',pic:''},{av:'AV50IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'AV46IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'sPrefix'},{av:'Ddo_br_procedure_pxradiotherapy_Activeeventkey',ctrl:'DDO_BR_PROCEDURE_PXRADIOTHERAPY',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_PROCEDURE_PXRADIOTHERAPY.ONOPTIONCLICKED",",oparms:[{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_procedure_pxradiotherapy_Sortedstatus',ctrl:'DDO_BR_PROCEDURE_PXRADIOTHERAPY',prop:'SortedStatus'},{av:'AV17BR_ProcedureIDTitleFilterData',fld:'vBR_PROCEDUREIDTITLEFILTERDATA',pic:''},{av:'AV25BR_Procedure_PXRadiotherapyTitleFilterData',fld:'vBR_PROCEDURE_PXRADIOTHERAPYTITLEFILTERDATA',pic:''},{av:'AV21BR_Procedure_PXSurgeryTitleFilterData',fld:'vBR_PROCEDURE_PXSURGERYTITLEFILTERDATA',pic:''},{av:'edtBR_ProcedureID_Titleformat',ctrl:'BR_PROCEDUREID',prop:'Titleformat'},{av:'edtBR_ProcedureID_Title',ctrl:'BR_PROCEDUREID',prop:'Title'},{av:'cmbBR_Procedure_PXRadiotherapy'},{av:'cmbBR_Procedure_PXSurgery'},{av:'AV42GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV43GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV44GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV50IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'edtavDisplay_Visible',ctrl:'vDISPLAY',prop:'Visible'},{av:'AV46IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'edtavMydel_Visible',ctrl:'vMYDEL',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("DDO_BR_PROCEDURE_PXSURGERY.ONOPTIONCLICKED","{handler:'E15282',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18ddo_BR_ProcedureIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXRADIOTHERAPYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXSURGERYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV70Pgmname',fld:'vPGMNAME',pic:''},{av:'AV50IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'AV46IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'sPrefix'},{av:'Ddo_br_procedure_pxsurgery_Activeeventkey',ctrl:'DDO_BR_PROCEDURE_PXSURGERY',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_PROCEDURE_PXSURGERY.ONOPTIONCLICKED",",oparms:[{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_procedure_pxsurgery_Sortedstatus',ctrl:'DDO_BR_PROCEDURE_PXSURGERY',prop:'SortedStatus'},{av:'AV17BR_ProcedureIDTitleFilterData',fld:'vBR_PROCEDUREIDTITLEFILTERDATA',pic:''},{av:'AV25BR_Procedure_PXRadiotherapyTitleFilterData',fld:'vBR_PROCEDURE_PXRADIOTHERAPYTITLEFILTERDATA',pic:''},{av:'AV21BR_Procedure_PXSurgeryTitleFilterData',fld:'vBR_PROCEDURE_PXSURGERYTITLEFILTERDATA',pic:''},{av:'edtBR_ProcedureID_Titleformat',ctrl:'BR_PROCEDUREID',prop:'Titleformat'},{av:'edtBR_ProcedureID_Title',ctrl:'BR_PROCEDUREID',prop:'Title'},{av:'cmbBR_Procedure_PXRadiotherapy'},{av:'cmbBR_Procedure_PXSurgery'},{av:'AV42GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV43GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV44GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV50IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'edtavDisplay_Visible',ctrl:'vDISPLAY',prop:'Visible'},{av:'AV46IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'edtavMydel_Visible',ctrl:'vMYDEL',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("GRID.LOAD","{handler:'E20282',iparms:[{av:'AV50IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'A139BR_ProcedureID',fld:'BR_PROCEDUREID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV46IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''}]");
         setEventMetadata("GRID.LOAD",",oparms:[{av:'AV49Display',fld:'vDISPLAY',pic:''},{av:'edtavDisplay_Tooltiptext',ctrl:'vDISPLAY',prop:'Tooltiptext'},{av:'edtavDisplay_Link',ctrl:'vDISPLAY',prop:'Link'},{av:'AV45Update',fld:'vUPDATE',pic:''},{av:'edtavUpdate_Tooltiptext',ctrl:'vUPDATE',prop:'Tooltiptext'},{av:'edtavUpdate_Link',ctrl:'vUPDATE',prop:'Link'},{av:'AV60mydel',fld:'vMYDEL',pic:''},{av:'edtavMydel_Tooltiptext',ctrl:'vMYDEL',prop:'Tooltiptext'}]}");
         setEventMetadata("'DOMYDEL'","{handler:'E22282',iparms:[{av:'A139BR_ProcedureID',fld:'BR_PROCEDUREID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
         setEventMetadata("'DOMYDEL'",",oparms:[{av:'AV61BR_ProcedureID_Selected',fld:'vBR_PROCEDUREID_SELECTED',pic:'ZZZZZZZZZZZZZZZZZZ'}]}");
         setEventMetadata("DVELOP_CONFIRMPANEL_MYDEL.CLOSE","{handler:'E16282',iparms:[{av:'Dvelop_confirmpanel_mydel_Result',ctrl:'DVELOP_CONFIRMPANEL_MYDEL',prop:'Result'},{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'AV14OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV15OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV18ddo_BR_ProcedureIDTitleControlIdToReplace',fld:'vDDO_BR_PROCEDUREIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV26ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXRADIOTHERAPYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV22ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace',fld:'vDDO_BR_PROCEDURE_PXSURGERYTITLECONTROLIDTOREPLACE',pic:''},{av:'AV70Pgmname',fld:'vPGMNAME',pic:''},{av:'AV50IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'AV46IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'sPrefix'},{av:'A139BR_ProcedureID',fld:'BR_PROCEDUREID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
         setEventMetadata("DVELOP_CONFIRMPANEL_MYDEL.CLOSE",",oparms:[{av:'AV17BR_ProcedureIDTitleFilterData',fld:'vBR_PROCEDUREIDTITLEFILTERDATA',pic:''},{av:'AV25BR_Procedure_PXRadiotherapyTitleFilterData',fld:'vBR_PROCEDURE_PXRADIOTHERAPYTITLEFILTERDATA',pic:''},{av:'AV21BR_Procedure_PXSurgeryTitleFilterData',fld:'vBR_PROCEDURE_PXSURGERYTITLEFILTERDATA',pic:''},{av:'edtBR_ProcedureID_Titleformat',ctrl:'BR_PROCEDUREID',prop:'Titleformat'},{av:'edtBR_ProcedureID_Title',ctrl:'BR_PROCEDUREID',prop:'Title'},{av:'cmbBR_Procedure_PXRadiotherapy'},{av:'cmbBR_Procedure_PXSurgery'},{av:'AV42GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV43GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV44GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'},{av:'AV50IsAuthorized_Display',fld:'vISAUTHORIZED_DISPLAY',pic:''},{av:'edtavDisplay_Visible',ctrl:'vDISPLAY',prop:'Visible'},{av:'AV46IsAuthorized_Update',fld:'vISAUTHORIZED_UPDATE',pic:''},{av:'edtavUpdate_Visible',ctrl:'vUPDATE',prop:'Visible'},{av:'edtavMydel_Visible',ctrl:'vMYDEL',prop:'Visible'},{ctrl:'BTNINSERT',prop:'Visible'}]}");
         setEventMetadata("'DOINSERT'","{handler:'E17282',iparms:[{av:'A139BR_ProcedureID',fld:'BR_PROCEDUREID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true},{av:'AV8BR_EncounterID',fld:'vBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'}]");
         setEventMetadata("'DOINSERT'",",oparms:[]}");
         setEventMetadata("VUPDATE.CLICK","{handler:'E21282',iparms:[{av:'A139BR_ProcedureID',fld:'BR_PROCEDUREID',pic:'ZZZZZZZZZZZZZZZZZZ',hsh:true}]");
         setEventMetadata("VUPDATE.CLICK",",oparms:[]}");
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
         Ddo_br_procedure_pxradiotherapy_Activeeventkey = "";
         Ddo_br_procedure_pxsurgery_Activeeventkey = "";
         Dvelop_confirmpanel_mydel_Result = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         sPrefix = "";
         AV18ddo_BR_ProcedureIDTitleControlIdToReplace = "";
         AV26ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace = "";
         AV22ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace = "";
         AV70Pgmname = "";
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         AV39DDO_TitleSettingsIcons = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV17BR_ProcedureIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV25BR_Procedure_PXRadiotherapyTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV21BR_Procedure_PXSurgeryTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         Ddo_br_procedureid_Sortedstatus = "";
         Ddo_br_procedure_pxradiotherapy_Sortedstatus = "";
         Ddo_br_procedure_pxsurgery_Sortedstatus = "";
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
         AV49Display = "";
         AV45Update = "";
         AV60mydel = "";
         A143BR_Procedure_PXRadiotherapy = "";
         A141BR_Procedure_PXSurgery = "";
         ucGridpaginationbar = new GXUserControl();
         ucDdo_br_procedureid = new GXUserControl();
         ucDdo_br_procedure_pxradiotherapy = new GXUserControl();
         ucDdo_br_procedure_pxsurgery = new GXUserControl();
         ucWorkwithplusutilities1 = new GXUserControl();
         Form = new GXWebForm();
         sXEvt = "";
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         AV67Display_GXI = "";
         AV68Update_GXI = "";
         AV69Mydel_GXI = "";
         scmdbuf = "";
         H00282_A19BR_EncounterID = new long[1] ;
         H00282_n19BR_EncounterID = new bool[] {false} ;
         H00282_A141BR_Procedure_PXSurgery = new String[] {""} ;
         H00282_n141BR_Procedure_PXSurgery = new bool[] {false} ;
         H00282_A143BR_Procedure_PXRadiotherapy = new String[] {""} ;
         H00282_n143BR_Procedure_PXRadiotherapy = new bool[] {false} ;
         H00282_A139BR_ProcedureID = new long[1] ;
         H00283_AGRID_nRecordCount = new long[1] ;
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV6WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         GridRow = new GXWebRow();
         AV16Session = context.GetSession();
         AV12GridState = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState(context);
         AV10TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV9HTTPRequest = new GxHttpRequest( context);
         AV11TrnContextAtt = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute(context);
         ucDvelop_confirmpanel_mydel = new GXUserControl();
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sCtrlAV8BR_EncounterID = "";
         sImgUrl = "";
         ROClassString = "";
         GXCCtl = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.br_encounterupdatebr_procedurewc__default(),
            new Object[][] {
                new Object[] {
               H00282_A19BR_EncounterID, H00282_n19BR_EncounterID, H00282_A141BR_Procedure_PXSurgery, H00282_n141BR_Procedure_PXSurgery, H00282_A143BR_Procedure_PXRadiotherapy, H00282_n143BR_Procedure_PXRadiotherapy, H00282_A139BR_ProcedureID
               }
               , new Object[] {
               H00283_AGRID_nRecordCount
               }
            }
         );
         AV70Pgmname = "BR_EncounterUpdateBR_ProcedureWC";
         /* GeneXus formulas. */
         AV70Pgmname = "BR_EncounterUpdateBR_ProcedureWC";
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
      private short edtBR_ProcedureID_Titleformat ;
      private short cmbBR_Procedure_PXRadiotherapy_Titleformat ;
      private short cmbBR_Procedure_PXSurgery_Titleformat ;
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
      private int edtavMydel_Visible ;
      private int subGrid_Selectedindex ;
      private int subGrid_Selectioncolor ;
      private int subGrid_Hoveringcolor ;
      private int edtavDdo_br_procedureidtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_procedure_pxradiotherapytitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_procedure_pxsurgerytitlecontrolidtoreplace_Visible ;
      private int edtBR_EncounterID_Visible ;
      private int edtavBr_procedureid_selected_Visible ;
      private int edtavOrderedby_Visible ;
      private int edtavOrdereddsc_Visible ;
      private int subGrid_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int AV41PageToGo ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private int edtavUpdate_Enabled ;
      private int edtavMydel_Enabled ;
      private long AV8BR_EncounterID ;
      private long wcpOAV8BR_EncounterID ;
      private long GRID_nFirstRecordOnPage ;
      private long AV42GridCurrentPage ;
      private long AV44GridRecordCount ;
      private long AV43GridPageSize ;
      private long A139BR_ProcedureID ;
      private long A19BR_EncounterID ;
      private long AV61BR_ProcedureID_Selected ;
      private long GRID_nCurrentRecord ;
      private long GRID_nRecordCount ;
      private String Gridpaginationbar_Selectedpage ;
      private String Ddo_br_procedureid_Activeeventkey ;
      private String Ddo_br_procedure_pxradiotherapy_Activeeventkey ;
      private String Ddo_br_procedure_pxsurgery_Activeeventkey ;
      private String Dvelop_confirmpanel_mydel_Result ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sPrefix ;
      private String sCompPrefix ;
      private String sSFPrefix ;
      private String sGXsfl_28_idx="0001" ;
      private String AV70Pgmname ;
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
      private String Ddo_br_procedureid_Caption ;
      private String Ddo_br_procedureid_Tooltip ;
      private String Ddo_br_procedureid_Cls ;
      private String Ddo_br_procedureid_Dropdownoptionstype ;
      private String Ddo_br_procedureid_Titlecontrolidtoreplace ;
      private String Ddo_br_procedureid_Sortedstatus ;
      private String Ddo_br_procedureid_Sortasc ;
      private String Ddo_br_procedureid_Sortdsc ;
      private String Ddo_br_procedureid_Searchbuttontext ;
      private String Ddo_br_procedure_pxradiotherapy_Caption ;
      private String Ddo_br_procedure_pxradiotherapy_Tooltip ;
      private String Ddo_br_procedure_pxradiotherapy_Cls ;
      private String Ddo_br_procedure_pxradiotherapy_Dropdownoptionstype ;
      private String Ddo_br_procedure_pxradiotherapy_Titlecontrolidtoreplace ;
      private String Ddo_br_procedure_pxradiotherapy_Sortedstatus ;
      private String Ddo_br_procedure_pxradiotherapy_Sortasc ;
      private String Ddo_br_procedure_pxradiotherapy_Sortdsc ;
      private String Ddo_br_procedure_pxradiotherapy_Searchbuttontext ;
      private String Ddo_br_procedure_pxsurgery_Caption ;
      private String Ddo_br_procedure_pxsurgery_Tooltip ;
      private String Ddo_br_procedure_pxsurgery_Cls ;
      private String Ddo_br_procedure_pxsurgery_Dropdownoptionstype ;
      private String Ddo_br_procedure_pxsurgery_Titlecontrolidtoreplace ;
      private String Ddo_br_procedure_pxsurgery_Sortedstatus ;
      private String Ddo_br_procedure_pxsurgery_Sortasc ;
      private String Ddo_br_procedure_pxsurgery_Sortdsc ;
      private String Ddo_br_procedure_pxsurgery_Searchbuttontext ;
      private String Dvelop_confirmpanel_mydel_Title ;
      private String Dvelop_confirmpanel_mydel_Confirmationtext ;
      private String Dvelop_confirmpanel_mydel_Yesbuttoncaption ;
      private String Dvelop_confirmpanel_mydel_Nobuttoncaption ;
      private String Dvelop_confirmpanel_mydel_Cancelbuttoncaption ;
      private String Dvelop_confirmpanel_mydel_Yesbuttonposition ;
      private String Dvelop_confirmpanel_mydel_Confirmtype ;
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
      private String edtBR_ProcedureID_Title ;
      private String subGrid_Header ;
      private String edtavDisplay_Link ;
      private String edtavDisplay_Tooltiptext ;
      private String edtavUpdate_Link ;
      private String edtavUpdate_Tooltiptext ;
      private String edtavMydel_Tooltiptext ;
      private String divHtml_gridpaginationbar_Internalname ;
      private String Gridpaginationbar_Internalname ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String Ddo_br_procedureid_Internalname ;
      private String edtavDdo_br_procedureidtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_procedure_pxradiotherapy_Internalname ;
      private String edtavDdo_br_procedure_pxradiotherapytitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_procedure_pxsurgery_Internalname ;
      private String edtavDdo_br_procedure_pxsurgerytitlecontrolidtoreplace_Internalname ;
      private String edtBR_EncounterID_Internalname ;
      private String edtBR_EncounterID_Jsonclick ;
      private String Workwithplusutilities1_Internalname ;
      private String edtavBr_procedureid_selected_Internalname ;
      private String edtavBr_procedureid_selected_Jsonclick ;
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
      private String edtavUpdate_Internalname ;
      private String edtavMydel_Internalname ;
      private String edtBR_ProcedureID_Internalname ;
      private String cmbBR_Procedure_PXRadiotherapy_Internalname ;
      private String cmbBR_Procedure_PXSurgery_Internalname ;
      private String scmdbuf ;
      private String tblTabledvelop_confirmpanel_mydel_Internalname ;
      private String Dvelop_confirmpanel_mydel_Internalname ;
      private String sCtrlAV8BR_EncounterID ;
      private String sGXsfl_28_fel_idx="0001" ;
      private String sImgUrl ;
      private String edtavUpdate_Jsonclick ;
      private String edtavMydel_Jsonclick ;
      private String ROClassString ;
      private String edtBR_ProcedureID_Jsonclick ;
      private String GXCCtl ;
      private String cmbBR_Procedure_PXRadiotherapy_Jsonclick ;
      private String cmbBR_Procedure_PXSurgery_Jsonclick ;
      private bool entryPointCalled ;
      private bool AV15OrderedDsc ;
      private bool AV50IsAuthorized_Display ;
      private bool AV46IsAuthorized_Update ;
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
      private bool Ddo_br_procedureid_Includesortasc ;
      private bool Ddo_br_procedureid_Includesortdsc ;
      private bool Ddo_br_procedureid_Includefilter ;
      private bool Ddo_br_procedureid_Includedatalist ;
      private bool Ddo_br_procedure_pxradiotherapy_Includesortasc ;
      private bool Ddo_br_procedure_pxradiotherapy_Includesortdsc ;
      private bool Ddo_br_procedure_pxradiotherapy_Includefilter ;
      private bool Ddo_br_procedure_pxradiotherapy_Includedatalist ;
      private bool Ddo_br_procedure_pxsurgery_Includesortasc ;
      private bool Ddo_br_procedure_pxsurgery_Includesortdsc ;
      private bool Ddo_br_procedure_pxsurgery_Includefilter ;
      private bool Ddo_br_procedure_pxsurgery_Includedatalist ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool bGXsfl_28_Refreshing=false ;
      private bool n143BR_Procedure_PXRadiotherapy ;
      private bool n141BR_Procedure_PXSurgery ;
      private bool gxdyncontrolsrefreshing ;
      private bool n19BR_EncounterID ;
      private bool returnInSub ;
      private bool gx_refresh_fired ;
      private bool AV64tCheckFlag ;
      private bool AV62IsAuthorized_mydel ;
      private bool AV51TempBoolean ;
      private bool GXt_boolean2 ;
      private bool AV49Display_IsBlob ;
      private bool AV45Update_IsBlob ;
      private bool AV60mydel_IsBlob ;
      private String AV18ddo_BR_ProcedureIDTitleControlIdToReplace ;
      private String AV26ddo_BR_Procedure_PXRadiotherapyTitleControlIdToReplace ;
      private String AV22ddo_BR_Procedure_PXSurgeryTitleControlIdToReplace ;
      private String A143BR_Procedure_PXRadiotherapy ;
      private String A141BR_Procedure_PXSurgery ;
      private String AV67Display_GXI ;
      private String AV68Update_GXI ;
      private String AV69Mydel_GXI ;
      private String AV49Display ;
      private String AV45Update ;
      private String AV60mydel ;
      private IGxSession AV16Session ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private GXUserControl ucDvpanel_tableheader ;
      private GXUserControl ucGridpaginationbar ;
      private GXUserControl ucDdo_br_procedureid ;
      private GXUserControl ucDdo_br_procedure_pxradiotherapy ;
      private GXUserControl ucDdo_br_procedure_pxsurgery ;
      private GXUserControl ucWorkwithplusutilities1 ;
      private GXUserControl ucDvelop_confirmpanel_mydel ;
      private GXWebForm Form ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbBR_Procedure_PXRadiotherapy ;
      private GXCombobox cmbBR_Procedure_PXSurgery ;
      private IDataStoreProvider pr_default ;
      private long[] H00282_A19BR_EncounterID ;
      private bool[] H00282_n19BR_EncounterID ;
      private String[] H00282_A141BR_Procedure_PXSurgery ;
      private bool[] H00282_n141BR_Procedure_PXSurgery ;
      private String[] H00282_A143BR_Procedure_PXRadiotherapy ;
      private bool[] H00282_n143BR_Procedure_PXRadiotherapy ;
      private long[] H00282_A139BR_ProcedureID ;
      private long[] H00283_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV9HTTPRequest ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV17BR_ProcedureIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV25BR_Procedure_PXRadiotherapyTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV21BR_Procedure_PXSurgeryTitleFilterData ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV10TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext_Attribute AV11TrnContextAtt ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV12GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons AV39DDO_TitleSettingsIcons ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 ;
   }

   public class br_encounterupdatebr_procedurewc__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H00282( IGxContext context ,
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
         sSelectString = " [BR_EncounterID], [BR_Procedure_PXSurgery], [BR_Procedure_PXRadiotherapy], [BR_ProcedureID]";
         sFromString = " FROM [BR_Procedure] WITH (NOLOCK)";
         sOrderString = "";
         sWhereString = sWhereString + " WHERE ([BR_EncounterID] = @AV8BR_EncounterID)";
         if ( ( AV14OrderedBy == 1 ) && ! AV15OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_ProcedureID] DESC";
         }
         else if ( ( AV14OrderedBy == 1 ) && ( AV15OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_ProcedureID]";
         }
         else if ( ( AV14OrderedBy == 2 ) && ! AV15OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_EncounterID], [BR_Procedure_PXRadiotherapy]";
         }
         else if ( ( AV14OrderedBy == 2 ) && ( AV15OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_EncounterID] DESC, [BR_Procedure_PXRadiotherapy] DESC";
         }
         else if ( ( AV14OrderedBy == 3 ) && ! AV15OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_EncounterID], [BR_Procedure_PXSurgery]";
         }
         else if ( ( AV14OrderedBy == 3 ) && ( AV15OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_EncounterID] DESC, [BR_Procedure_PXSurgery] DESC";
         }
         else if ( true )
         {
            sOrderString = sOrderString + " ORDER BY [BR_ProcedureID]";
         }
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object4[0] = scmdbuf;
         GXv_Object4[1] = GXv_int3;
         return GXv_Object4 ;
      }

      protected Object[] conditional_H00283( IGxContext context ,
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
         scmdbuf = "SELECT COUNT(*) FROM [BR_Procedure] WITH (NOLOCK)";
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
                     return conditional_H00282(context, (short)dynConstraints[0] , (bool)dynConstraints[1] , (long)dynConstraints[2] , (long)dynConstraints[3] );
               case 1 :
                     return conditional_H00283(context, (short)dynConstraints[0] , (bool)dynConstraints[1] , (long)dynConstraints[2] , (long)dynConstraints[3] );
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
          Object[] prmH00282 ;
          prmH00282 = new Object[] {
          new Object[] {"@AV8BR_EncounterID",SqlDbType.Decimal,18,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH00283 ;
          prmH00283 = new Object[] {
          new Object[] {"@AV8BR_EncounterID",SqlDbType.Decimal,18,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H00282", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00282,11,0,true,false )
             ,new CursorDef("H00283", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00283,1,0,true,false )
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
                ((long[]) buf[6])[0] = rslt.getLong(4) ;
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
