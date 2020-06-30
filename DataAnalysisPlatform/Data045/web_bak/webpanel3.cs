/*
               File: WebPanel3
        Description: Web Panel3
             Author: GeneXus C# Generator version 16_0_0-127771
       Generated on: 2/27/2020 9:48:4.34
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
   public class webpanel3 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public webpanel3( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDataStore1 = context.GetDataStore("DataStore1");
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("WorkWithPlusTheme");
      }

      public webpanel3( IGxContext context )
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
         cmbavBr_encounter_status = new GXCombobox();
         cmbBR_Encounter_Status = new GXCombobox();
         chkBR_Encounter_IsRandApprove = new GXCheckbox();
         chkBR_Encounter_IsRandRecheck = new GXCheckbox();
         chkBR_Encounter_IsUpdate = new GXCheckbox();
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
               nRC_GXsfl_31 = (short)(NumberUtil.Val( GetNextPar( ), "."));
               nGXsfl_31_idx = (short)(NumberUtil.Val( GetNextPar( ), "."));
               sGXsfl_31_idx = GetNextPar( );
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
               AV15BR_Encounter_Status = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV13OrderedBy = (short)(NumberUtil.Val( GetNextPar( ), "."));
               AV14OrderedDsc = StringUtil.StrToBool( GetNextPar( ));
               AV18TFBR_EncounterID = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV19TFBR_EncounterID_To = (long)(NumberUtil.Val( GetNextPar( ), "."));
               AV20ddo_BR_EncounterIDTitleControlIdToReplace = GetNextPar( );
               AV33ddo_BR_Encounter_DepartmentTitleControlIdToReplace = GetNextPar( );
               AV35ddo_BR_Encounter_ENCTypeTitleControlIdToReplace = GetNextPar( );
               AV37ddo_BR_Encounter_AdmitDateTitleControlIdToReplace = GetNextPar( );
               AV24ddo_BR_Encounter_StatusTitleControlIdToReplace = GetNextPar( );
               AV39ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace = GetNextPar( );
               AV41ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace = GetNextPar( );
               AV43ddo_BR_Encounter_IsUpdateTitleControlIdToReplace = GetNextPar( );
               AV49Pgmname = GetNextPar( );
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1;
                  return  ;
               }
               gxgrGrid_refresh( subGrid_Rows, AV15BR_Encounter_Status, AV13OrderedBy, AV14OrderedDsc, AV18TFBR_EncounterID, AV19TFBR_EncounterID_To, AV20ddo_BR_EncounterIDTitleControlIdToReplace, AV33ddo_BR_Encounter_DepartmentTitleControlIdToReplace, AV35ddo_BR_Encounter_ENCTypeTitleControlIdToReplace, AV37ddo_BR_Encounter_AdmitDateTitleControlIdToReplace, AV24ddo_BR_Encounter_StatusTitleControlIdToReplace, AV39ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace, AV41ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace, AV43ddo_BR_Encounter_IsUpdateTitleControlIdToReplace, AV49Pgmname) ;
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
         PAA82( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0));
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            STARTA82( ) ;
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
         context.AddJavascriptSource("gxcfg.js", "?2020227948459", false);
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
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" autocomplete=\"off\" name=\"MAINFORM\" method=\"post\" tabindex=-1  class=\"form-horizontal Form\" data-gx-class=\"form-horizontal Form\" novalidate action=\""+formatLink("webpanel3.aspx") +"\">") ;
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
         GxWebStd.gx_hidden_field( context, "GXH_vBR_ENCOUNTER_STATUS", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV15BR_Encounter_Status), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vORDEREDBY", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13OrderedBy), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vORDEREDDSC", StringUtil.BoolToStr( AV14OrderedDsc));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_ENCOUNTERID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV18TFBR_EncounterID), 18, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vTFBR_ENCOUNTERID_TO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV19TFBR_EncounterID_To), 18, 0, ".", "")));
         /* Send saved values. */
         send_integrity_footer_hashes( ) ;
         GxWebStd.gx_hidden_field( context, "nRC_GXsfl_31", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_GXsfl_31), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDCURRENTPAGE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV27GridCurrentPage), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDRECORDCOUNT", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV29GridRecordCount), 10, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vGRIDPAGESIZE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV28GridPageSize), 10, 0, ".", "")));
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vDDO_TITLESETTINGSICONS", AV25DDO_TitleSettingsIcons);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vDDO_TITLESETTINGSICONS", AV25DDO_TitleSettingsIcons);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_ENCOUNTERIDTITLEFILTERDATA", AV17BR_EncounterIDTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_ENCOUNTERIDTITLEFILTERDATA", AV17BR_EncounterIDTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_ENCOUNTER_DEPARTMENTTITLEFILTERDATA", AV32BR_Encounter_DepartmentTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_ENCOUNTER_DEPARTMENTTITLEFILTERDATA", AV32BR_Encounter_DepartmentTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_ENCOUNTER_ENCTYPETITLEFILTERDATA", AV34BR_Encounter_ENCTypeTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_ENCOUNTER_ENCTYPETITLEFILTERDATA", AV34BR_Encounter_ENCTypeTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_ENCOUNTER_ADMITDATETITLEFILTERDATA", AV36BR_Encounter_AdmitDateTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_ENCOUNTER_ADMITDATETITLEFILTERDATA", AV36BR_Encounter_AdmitDateTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_ENCOUNTER_STATUSTITLEFILTERDATA", AV21BR_Encounter_StatusTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_ENCOUNTER_STATUSTITLEFILTERDATA", AV21BR_Encounter_StatusTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_ENCOUNTER_ISRANDAPPROVETITLEFILTERDATA", AV38BR_Encounter_IsRandApproveTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_ENCOUNTER_ISRANDAPPROVETITLEFILTERDATA", AV38BR_Encounter_IsRandApproveTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_ENCOUNTER_ISRANDRECHECKTITLEFILTERDATA", AV40BR_Encounter_IsRandRecheckTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_ENCOUNTER_ISRANDRECHECKTITLEFILTERDATA", AV40BR_Encounter_IsRandRecheckTitleFilterData);
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vBR_ENCOUNTER_ISUPDATETITLEFILTERDATA", AV42BR_Encounter_IsUpdateTitleFilterData);
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vBR_ENCOUNTER_ISUPDATETITLEFILTERDATA", AV42BR_Encounter_IsUpdateTitleFilterData);
         }
         GxWebStd.gx_hidden_field( context, "vPGMNAME", StringUtil.RTrim( AV49Pgmname));
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
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Caption", StringUtil.RTrim( Ddo_br_encounterid_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Tooltip", StringUtil.RTrim( Ddo_br_encounterid_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Cls", StringUtil.RTrim( Ddo_br_encounterid_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Filteredtext_set", StringUtil.RTrim( Ddo_br_encounterid_Filteredtext_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Filteredtextto_set", StringUtil.RTrim( Ddo_br_encounterid_Filteredtextto_set));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_encounterid_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_encounterid_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Includesortasc", StringUtil.BoolToStr( Ddo_br_encounterid_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Includesortdsc", StringUtil.BoolToStr( Ddo_br_encounterid_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Sortedstatus", StringUtil.RTrim( Ddo_br_encounterid_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Includefilter", StringUtil.BoolToStr( Ddo_br_encounterid_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Filtertype", StringUtil.RTrim( Ddo_br_encounterid_Filtertype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Filterisrange", StringUtil.BoolToStr( Ddo_br_encounterid_Filterisrange));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Includedatalist", StringUtil.BoolToStr( Ddo_br_encounterid_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Sortasc", StringUtil.RTrim( Ddo_br_encounterid_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Sortdsc", StringUtil.RTrim( Ddo_br_encounterid_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Cleanfilter", StringUtil.RTrim( Ddo_br_encounterid_Cleanfilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Rangefilterfrom", StringUtil.RTrim( Ddo_br_encounterid_Rangefilterfrom));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Rangefilterto", StringUtil.RTrim( Ddo_br_encounterid_Rangefilterto));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Searchbuttontext", StringUtil.RTrim( Ddo_br_encounterid_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_DEPARTMENT_Caption", StringUtil.RTrim( Ddo_br_encounter_department_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_DEPARTMENT_Tooltip", StringUtil.RTrim( Ddo_br_encounter_department_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_DEPARTMENT_Cls", StringUtil.RTrim( Ddo_br_encounter_department_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_DEPARTMENT_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_encounter_department_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_DEPARTMENT_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_encounter_department_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_DEPARTMENT_Includesortasc", StringUtil.BoolToStr( Ddo_br_encounter_department_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_DEPARTMENT_Includesortdsc", StringUtil.BoolToStr( Ddo_br_encounter_department_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_DEPARTMENT_Sortedstatus", StringUtil.RTrim( Ddo_br_encounter_department_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_DEPARTMENT_Includefilter", StringUtil.BoolToStr( Ddo_br_encounter_department_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_DEPARTMENT_Includedatalist", StringUtil.BoolToStr( Ddo_br_encounter_department_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_DEPARTMENT_Sortasc", StringUtil.RTrim( Ddo_br_encounter_department_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_DEPARTMENT_Sortdsc", StringUtil.RTrim( Ddo_br_encounter_department_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_DEPARTMENT_Searchbuttontext", StringUtil.RTrim( Ddo_br_encounter_department_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ENCTYPE_Caption", StringUtil.RTrim( Ddo_br_encounter_enctype_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ENCTYPE_Tooltip", StringUtil.RTrim( Ddo_br_encounter_enctype_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ENCTYPE_Cls", StringUtil.RTrim( Ddo_br_encounter_enctype_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ENCTYPE_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_encounter_enctype_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ENCTYPE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_encounter_enctype_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ENCTYPE_Includesortasc", StringUtil.BoolToStr( Ddo_br_encounter_enctype_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ENCTYPE_Includesortdsc", StringUtil.BoolToStr( Ddo_br_encounter_enctype_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ENCTYPE_Sortedstatus", StringUtil.RTrim( Ddo_br_encounter_enctype_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ENCTYPE_Includefilter", StringUtil.BoolToStr( Ddo_br_encounter_enctype_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ENCTYPE_Includedatalist", StringUtil.BoolToStr( Ddo_br_encounter_enctype_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ENCTYPE_Sortasc", StringUtil.RTrim( Ddo_br_encounter_enctype_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ENCTYPE_Sortdsc", StringUtil.RTrim( Ddo_br_encounter_enctype_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ENCTYPE_Searchbuttontext", StringUtil.RTrim( Ddo_br_encounter_enctype_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ADMITDATE_Caption", StringUtil.RTrim( Ddo_br_encounter_admitdate_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ADMITDATE_Tooltip", StringUtil.RTrim( Ddo_br_encounter_admitdate_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ADMITDATE_Cls", StringUtil.RTrim( Ddo_br_encounter_admitdate_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ADMITDATE_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_encounter_admitdate_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ADMITDATE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_encounter_admitdate_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ADMITDATE_Includesortasc", StringUtil.BoolToStr( Ddo_br_encounter_admitdate_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ADMITDATE_Includesortdsc", StringUtil.BoolToStr( Ddo_br_encounter_admitdate_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ADMITDATE_Sortedstatus", StringUtil.RTrim( Ddo_br_encounter_admitdate_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ADMITDATE_Includefilter", StringUtil.BoolToStr( Ddo_br_encounter_admitdate_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ADMITDATE_Includedatalist", StringUtil.BoolToStr( Ddo_br_encounter_admitdate_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ADMITDATE_Sortasc", StringUtil.RTrim( Ddo_br_encounter_admitdate_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ADMITDATE_Sortdsc", StringUtil.RTrim( Ddo_br_encounter_admitdate_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ADMITDATE_Searchbuttontext", StringUtil.RTrim( Ddo_br_encounter_admitdate_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_STATUS_Caption", StringUtil.RTrim( Ddo_br_encounter_status_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_STATUS_Tooltip", StringUtil.RTrim( Ddo_br_encounter_status_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_STATUS_Cls", StringUtil.RTrim( Ddo_br_encounter_status_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_STATUS_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_encounter_status_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_STATUS_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_encounter_status_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_STATUS_Includesortasc", StringUtil.BoolToStr( Ddo_br_encounter_status_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_STATUS_Includesortdsc", StringUtil.BoolToStr( Ddo_br_encounter_status_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_STATUS_Sortedstatus", StringUtil.RTrim( Ddo_br_encounter_status_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_STATUS_Includefilter", StringUtil.BoolToStr( Ddo_br_encounter_status_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_STATUS_Includedatalist", StringUtil.BoolToStr( Ddo_br_encounter_status_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_STATUS_Sortasc", StringUtil.RTrim( Ddo_br_encounter_status_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_STATUS_Sortdsc", StringUtil.RTrim( Ddo_br_encounter_status_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_STATUS_Searchbuttontext", StringUtil.RTrim( Ddo_br_encounter_status_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ISRANDAPPROVE_Caption", StringUtil.RTrim( Ddo_br_encounter_israndapprove_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ISRANDAPPROVE_Tooltip", StringUtil.RTrim( Ddo_br_encounter_israndapprove_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ISRANDAPPROVE_Cls", StringUtil.RTrim( Ddo_br_encounter_israndapprove_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ISRANDAPPROVE_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_encounter_israndapprove_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ISRANDAPPROVE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_encounter_israndapprove_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ISRANDAPPROVE_Includesortasc", StringUtil.BoolToStr( Ddo_br_encounter_israndapprove_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ISRANDAPPROVE_Includesortdsc", StringUtil.BoolToStr( Ddo_br_encounter_israndapprove_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ISRANDAPPROVE_Sortedstatus", StringUtil.RTrim( Ddo_br_encounter_israndapprove_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ISRANDAPPROVE_Includefilter", StringUtil.BoolToStr( Ddo_br_encounter_israndapprove_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ISRANDAPPROVE_Includedatalist", StringUtil.BoolToStr( Ddo_br_encounter_israndapprove_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ISRANDAPPROVE_Sortasc", StringUtil.RTrim( Ddo_br_encounter_israndapprove_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ISRANDAPPROVE_Sortdsc", StringUtil.RTrim( Ddo_br_encounter_israndapprove_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ISRANDAPPROVE_Searchbuttontext", StringUtil.RTrim( Ddo_br_encounter_israndapprove_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ISRANDRECHECK_Caption", StringUtil.RTrim( Ddo_br_encounter_israndrecheck_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ISRANDRECHECK_Tooltip", StringUtil.RTrim( Ddo_br_encounter_israndrecheck_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ISRANDRECHECK_Cls", StringUtil.RTrim( Ddo_br_encounter_israndrecheck_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ISRANDRECHECK_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_encounter_israndrecheck_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ISRANDRECHECK_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_encounter_israndrecheck_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ISRANDRECHECK_Includesortasc", StringUtil.BoolToStr( Ddo_br_encounter_israndrecheck_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ISRANDRECHECK_Includesortdsc", StringUtil.BoolToStr( Ddo_br_encounter_israndrecheck_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ISRANDRECHECK_Sortedstatus", StringUtil.RTrim( Ddo_br_encounter_israndrecheck_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ISRANDRECHECK_Includefilter", StringUtil.BoolToStr( Ddo_br_encounter_israndrecheck_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ISRANDRECHECK_Includedatalist", StringUtil.BoolToStr( Ddo_br_encounter_israndrecheck_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ISRANDRECHECK_Sortasc", StringUtil.RTrim( Ddo_br_encounter_israndrecheck_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ISRANDRECHECK_Sortdsc", StringUtil.RTrim( Ddo_br_encounter_israndrecheck_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ISRANDRECHECK_Searchbuttontext", StringUtil.RTrim( Ddo_br_encounter_israndrecheck_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ISUPDATE_Caption", StringUtil.RTrim( Ddo_br_encounter_isupdate_Caption));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ISUPDATE_Tooltip", StringUtil.RTrim( Ddo_br_encounter_isupdate_Tooltip));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ISUPDATE_Cls", StringUtil.RTrim( Ddo_br_encounter_isupdate_Cls));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ISUPDATE_Dropdownoptionstype", StringUtil.RTrim( Ddo_br_encounter_isupdate_Dropdownoptionstype));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ISUPDATE_Titlecontrolidtoreplace", StringUtil.RTrim( Ddo_br_encounter_isupdate_Titlecontrolidtoreplace));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ISUPDATE_Includesortasc", StringUtil.BoolToStr( Ddo_br_encounter_isupdate_Includesortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ISUPDATE_Includesortdsc", StringUtil.BoolToStr( Ddo_br_encounter_isupdate_Includesortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ISUPDATE_Sortedstatus", StringUtil.RTrim( Ddo_br_encounter_isupdate_Sortedstatus));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ISUPDATE_Includefilter", StringUtil.BoolToStr( Ddo_br_encounter_isupdate_Includefilter));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ISUPDATE_Includedatalist", StringUtil.BoolToStr( Ddo_br_encounter_isupdate_Includedatalist));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ISUPDATE_Sortasc", StringUtil.RTrim( Ddo_br_encounter_isupdate_Sortasc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ISUPDATE_Sortdsc", StringUtil.RTrim( Ddo_br_encounter_isupdate_Sortdsc));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ISUPDATE_Searchbuttontext", StringUtil.RTrim( Ddo_br_encounter_isupdate_Searchbuttontext));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Activeeventkey", StringUtil.RTrim( Ddo_br_encounterid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Filteredtext_get", StringUtil.RTrim( Ddo_br_encounterid_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Filteredtextto_get", StringUtil.RTrim( Ddo_br_encounterid_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_DEPARTMENT_Activeeventkey", StringUtil.RTrim( Ddo_br_encounter_department_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ENCTYPE_Activeeventkey", StringUtil.RTrim( Ddo_br_encounter_enctype_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ADMITDATE_Activeeventkey", StringUtil.RTrim( Ddo_br_encounter_admitdate_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_STATUS_Activeeventkey", StringUtil.RTrim( Ddo_br_encounter_status_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ISRANDAPPROVE_Activeeventkey", StringUtil.RTrim( Ddo_br_encounter_israndapprove_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ISRANDRECHECK_Activeeventkey", StringUtil.RTrim( Ddo_br_encounter_israndrecheck_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ISUPDATE_Activeeventkey", StringUtil.RTrim( Ddo_br_encounter_isupdate_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Selectedpage", StringUtil.RTrim( Gridpaginationbar_Selectedpage));
         GxWebStd.gx_hidden_field( context, "GRIDPAGINATIONBAR_Rowsperpageselectedvalue", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Activeeventkey", StringUtil.RTrim( Ddo_br_encounterid_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Filteredtext_get", StringUtil.RTrim( Ddo_br_encounterid_Filteredtext_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTERID_Filteredtextto_get", StringUtil.RTrim( Ddo_br_encounterid_Filteredtextto_get));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_DEPARTMENT_Activeeventkey", StringUtil.RTrim( Ddo_br_encounter_department_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ENCTYPE_Activeeventkey", StringUtil.RTrim( Ddo_br_encounter_enctype_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ADMITDATE_Activeeventkey", StringUtil.RTrim( Ddo_br_encounter_admitdate_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_STATUS_Activeeventkey", StringUtil.RTrim( Ddo_br_encounter_status_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ISRANDAPPROVE_Activeeventkey", StringUtil.RTrim( Ddo_br_encounter_israndapprove_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ISRANDRECHECK_Activeeventkey", StringUtil.RTrim( Ddo_br_encounter_israndrecheck_Activeeventkey));
         GxWebStd.gx_hidden_field( context, "DDO_BR_ENCOUNTER_ISUPDATE_Activeeventkey", StringUtil.RTrim( Ddo_br_encounter_isupdate_Activeeventkey));
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
            WEA82( ) ;
            context.WriteHtmlText( "</div>") ;
         }
      }

      public override void DispatchEvents( )
      {
         EVTA82( ) ;
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
         return formatLink("webpanel3.aspx")  ;
      }

      public override String GetPgmname( )
      {
         return "WebPanel3" ;
      }

      public override String GetPgmdesc( )
      {
         return "Web Panel3" ;
      }

      protected void WBA80( )
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
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-xs-12", "left", "top", "", "", "div");
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "form-group gx-form-group", "left", "top", ""+" data-gx-for=\""+cmbavBr_encounter_status_Internalname+"\"", "", "div");
            /* Attribute/Variable Label */
            GxWebStd.gx_label_element( context, cmbavBr_encounter_status_Internalname, "审批状态", "col-sm-3 AttributeLabel", 1, true);
            /* Div Control */
            GxWebStd.gx_div_start( context, "", 1, 0, "px", 0, "px", "col-sm-9 gx-attribute", "left", "top", "", "", "div");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'" + sGXsfl_31_idx + "',0)\"";
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavBr_encounter_status, cmbavBr_encounter_status_Internalname, StringUtil.Trim( StringUtil.Str( (decimal)(AV15BR_Encounter_Status), 4, 0)), 1, cmbavBr_encounter_status_Jsonclick, 0, "'"+""+"'"+",false,"+"'"+""+"'", "int", "", 1, cmbavBr_encounter_status.Enabled, 0, 0, 0, "em", 0, "", "", "Attribute", "", "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,22);\"", "", true, "HLP_WebPanel3.htm");
            cmbavBr_encounter_status.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV15BR_Encounter_Status), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavBr_encounter_status_Internalname, "Values", (String)(cmbavBr_encounter_status.ToJavascriptSource()), true);
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
               context.WriteHtmlText( "<div id=\""+"GridContainer"+"DivS\" data-gxgridid=\"31\">") ;
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
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Encounter_Department_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Encounter_Department_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Encounter_Department_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Encounter_ENCType_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Encounter_ENCType_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Encounter_ENCType_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( edtBR_Encounter_AdmitDate_Titleformat == 0 )
               {
                  context.SendWebValue( edtBR_Encounter_AdmitDate_Title) ;
               }
               else
               {
                  context.WriteHtmlText( edtBR_Encounter_AdmitDate_Title) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+"Attribute"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( cmbBR_Encounter_Status_Titleformat == 0 )
               {
                  context.SendWebValue( cmbBR_Encounter_Status.Title.Text) ;
               }
               else
               {
                  context.WriteHtmlText( cmbBR_Encounter_Status.Title.Text) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"AttributeCheckBox"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( chkBR_Encounter_IsRandApprove_Titleformat == 0 )
               {
                  context.SendWebValue( chkBR_Encounter_IsRandApprove.Title.Text) ;
               }
               else
               {
                  context.WriteHtmlText( chkBR_Encounter_IsRandApprove.Title.Text) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"AttributeCheckBox"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( chkBR_Encounter_IsRandRecheck_Titleformat == 0 )
               {
                  context.SendWebValue( chkBR_Encounter_IsRandRecheck.Title.Text) ;
               }
               else
               {
                  context.WriteHtmlText( chkBR_Encounter_IsRandRecheck.Title.Text) ;
               }
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+"AttributeCheckBox"+"\" "+" style=\""+""+""+"\" "+">") ;
               if ( chkBR_Encounter_IsUpdate_Titleformat == 0 )
               {
                  context.SendWebValue( chkBR_Encounter_IsUpdate.Title.Text) ;
               }
               else
               {
                  context.WriteHtmlText( chkBR_Encounter_IsUpdate.Title.Text) ;
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
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A19BR_EncounterID), 18, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_EncounterID_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_EncounterID_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A84BR_Encounter_Department);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Encounter_Department_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Encounter_Department_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", A90BR_Encounter_ENCType);
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Encounter_ENCType_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Encounter_ENCType_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", context.localUtil.Format(A91BR_Encounter_AdmitDate, "9999/99/99"));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( edtBR_Encounter_AdmitDate_Title));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtBR_Encounter_AdmitDate_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A172BR_Encounter_Status), 4, 0, ".", "")));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( cmbBR_Encounter_Status.Title.Text));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(cmbBR_Encounter_Status_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.BoolToStr( A192BR_Encounter_IsRandApprove));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( chkBR_Encounter_IsRandApprove.Title.Text));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(chkBR_Encounter_IsRandApprove_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.BoolToStr( A193BR_Encounter_IsRandRecheck));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( chkBR_Encounter_IsRandRecheck.Title.Text));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(chkBR_Encounter_IsRandRecheck_Titleformat), 4, 0, ".", "")));
               GridContainer.AddColumnProperties(GridColumn);
               GridColumn = GXWebColumn.GetNew(isAjaxCallMode( ));
               GridColumn.AddObjectProperty("Value", StringUtil.BoolToStr( A202BR_Encounter_IsUpdate));
               GridColumn.AddObjectProperty("Title", StringUtil.RTrim( chkBR_Encounter_IsUpdate.Title.Text));
               GridColumn.AddObjectProperty("Titleformat", StringUtil.LTrim( StringUtil.NToC( (decimal)(chkBR_Encounter_IsUpdate_Titleformat), 4, 0, ".", "")));
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
         if ( wbEnd == 31 )
         {
            wbEnd = 0;
            nRC_GXsfl_31 = (short)(nGXsfl_31_idx-1);
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
            ucGridpaginationbar.SetProperty("CurrentPage", AV27GridCurrentPage);
            ucGridpaginationbar.SetProperty("RecordCount", AV29GridRecordCount);
            ucGridpaginationbar.SetProperty("Page", AV28GridPageSize);
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
            ucDdo_br_encounterid.SetProperty("Caption", Ddo_br_encounterid_Caption);
            ucDdo_br_encounterid.SetProperty("Tooltip", Ddo_br_encounterid_Tooltip);
            ucDdo_br_encounterid.SetProperty("Cls", Ddo_br_encounterid_Cls);
            ucDdo_br_encounterid.SetProperty("DropDownOptionsType", Ddo_br_encounterid_Dropdownoptionstype);
            ucDdo_br_encounterid.SetProperty("IncludeSortASC", Ddo_br_encounterid_Includesortasc);
            ucDdo_br_encounterid.SetProperty("IncludeSortDSC", Ddo_br_encounterid_Includesortdsc);
            ucDdo_br_encounterid.SetProperty("IncludeFilter", Ddo_br_encounterid_Includefilter);
            ucDdo_br_encounterid.SetProperty("FilterType", Ddo_br_encounterid_Filtertype);
            ucDdo_br_encounterid.SetProperty("FilterIsRange", Ddo_br_encounterid_Filterisrange);
            ucDdo_br_encounterid.SetProperty("IncludeDataList", Ddo_br_encounterid_Includedatalist);
            ucDdo_br_encounterid.SetProperty("SortASC", Ddo_br_encounterid_Sortasc);
            ucDdo_br_encounterid.SetProperty("SortDSC", Ddo_br_encounterid_Sortdsc);
            ucDdo_br_encounterid.SetProperty("CleanFilter", Ddo_br_encounterid_Cleanfilter);
            ucDdo_br_encounterid.SetProperty("RangeFilterFrom", Ddo_br_encounterid_Rangefilterfrom);
            ucDdo_br_encounterid.SetProperty("RangeFilterTo", Ddo_br_encounterid_Rangefilterto);
            ucDdo_br_encounterid.SetProperty("SearchButtonText", Ddo_br_encounterid_Searchbuttontext);
            ucDdo_br_encounterid.SetProperty("DropDownOptionsTitleSettingsIcons", AV25DDO_TitleSettingsIcons);
            ucDdo_br_encounterid.SetProperty("DropDownOptionsData", AV17BR_EncounterIDTitleFilterData);
            ucDdo_br_encounterid.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_encounterid_Internalname, "DDO_BR_ENCOUNTERIDContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_encounteridtitlecontrolidtoreplace_Internalname, AV20ddo_BR_EncounterIDTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,48);\"", 0, edtavDdo_br_encounteridtitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_WebPanel3.htm");
            /* User Defined Control */
            ucDdo_br_encounter_department.SetProperty("Caption", Ddo_br_encounter_department_Caption);
            ucDdo_br_encounter_department.SetProperty("Tooltip", Ddo_br_encounter_department_Tooltip);
            ucDdo_br_encounter_department.SetProperty("Cls", Ddo_br_encounter_department_Cls);
            ucDdo_br_encounter_department.SetProperty("DropDownOptionsType", Ddo_br_encounter_department_Dropdownoptionstype);
            ucDdo_br_encounter_department.SetProperty("IncludeSortASC", Ddo_br_encounter_department_Includesortasc);
            ucDdo_br_encounter_department.SetProperty("IncludeSortDSC", Ddo_br_encounter_department_Includesortdsc);
            ucDdo_br_encounter_department.SetProperty("IncludeFilter", Ddo_br_encounter_department_Includefilter);
            ucDdo_br_encounter_department.SetProperty("IncludeDataList", Ddo_br_encounter_department_Includedatalist);
            ucDdo_br_encounter_department.SetProperty("SortASC", Ddo_br_encounter_department_Sortasc);
            ucDdo_br_encounter_department.SetProperty("SortDSC", Ddo_br_encounter_department_Sortdsc);
            ucDdo_br_encounter_department.SetProperty("SearchButtonText", Ddo_br_encounter_department_Searchbuttontext);
            ucDdo_br_encounter_department.SetProperty("DropDownOptionsTitleSettingsIcons", AV25DDO_TitleSettingsIcons);
            ucDdo_br_encounter_department.SetProperty("DropDownOptionsData", AV32BR_Encounter_DepartmentTitleFilterData);
            ucDdo_br_encounter_department.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_encounter_department_Internalname, "DDO_BR_ENCOUNTER_DEPARTMENTContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 50,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_encounter_departmenttitlecontrolidtoreplace_Internalname, AV33ddo_BR_Encounter_DepartmentTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,50);\"", 0, edtavDdo_br_encounter_departmenttitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_WebPanel3.htm");
            /* User Defined Control */
            ucDdo_br_encounter_enctype.SetProperty("Caption", Ddo_br_encounter_enctype_Caption);
            ucDdo_br_encounter_enctype.SetProperty("Tooltip", Ddo_br_encounter_enctype_Tooltip);
            ucDdo_br_encounter_enctype.SetProperty("Cls", Ddo_br_encounter_enctype_Cls);
            ucDdo_br_encounter_enctype.SetProperty("DropDownOptionsType", Ddo_br_encounter_enctype_Dropdownoptionstype);
            ucDdo_br_encounter_enctype.SetProperty("IncludeSortASC", Ddo_br_encounter_enctype_Includesortasc);
            ucDdo_br_encounter_enctype.SetProperty("IncludeSortDSC", Ddo_br_encounter_enctype_Includesortdsc);
            ucDdo_br_encounter_enctype.SetProperty("IncludeFilter", Ddo_br_encounter_enctype_Includefilter);
            ucDdo_br_encounter_enctype.SetProperty("IncludeDataList", Ddo_br_encounter_enctype_Includedatalist);
            ucDdo_br_encounter_enctype.SetProperty("SortASC", Ddo_br_encounter_enctype_Sortasc);
            ucDdo_br_encounter_enctype.SetProperty("SortDSC", Ddo_br_encounter_enctype_Sortdsc);
            ucDdo_br_encounter_enctype.SetProperty("SearchButtonText", Ddo_br_encounter_enctype_Searchbuttontext);
            ucDdo_br_encounter_enctype.SetProperty("DropDownOptionsTitleSettingsIcons", AV25DDO_TitleSettingsIcons);
            ucDdo_br_encounter_enctype.SetProperty("DropDownOptionsData", AV34BR_Encounter_ENCTypeTitleFilterData);
            ucDdo_br_encounter_enctype.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_encounter_enctype_Internalname, "DDO_BR_ENCOUNTER_ENCTYPEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 52,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_encounter_enctypetitlecontrolidtoreplace_Internalname, AV35ddo_BR_Encounter_ENCTypeTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,52);\"", 0, edtavDdo_br_encounter_enctypetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_WebPanel3.htm");
            /* User Defined Control */
            ucDdo_br_encounter_admitdate.SetProperty("Caption", Ddo_br_encounter_admitdate_Caption);
            ucDdo_br_encounter_admitdate.SetProperty("Tooltip", Ddo_br_encounter_admitdate_Tooltip);
            ucDdo_br_encounter_admitdate.SetProperty("Cls", Ddo_br_encounter_admitdate_Cls);
            ucDdo_br_encounter_admitdate.SetProperty("DropDownOptionsType", Ddo_br_encounter_admitdate_Dropdownoptionstype);
            ucDdo_br_encounter_admitdate.SetProperty("IncludeSortASC", Ddo_br_encounter_admitdate_Includesortasc);
            ucDdo_br_encounter_admitdate.SetProperty("IncludeSortDSC", Ddo_br_encounter_admitdate_Includesortdsc);
            ucDdo_br_encounter_admitdate.SetProperty("IncludeFilter", Ddo_br_encounter_admitdate_Includefilter);
            ucDdo_br_encounter_admitdate.SetProperty("IncludeDataList", Ddo_br_encounter_admitdate_Includedatalist);
            ucDdo_br_encounter_admitdate.SetProperty("SortASC", Ddo_br_encounter_admitdate_Sortasc);
            ucDdo_br_encounter_admitdate.SetProperty("SortDSC", Ddo_br_encounter_admitdate_Sortdsc);
            ucDdo_br_encounter_admitdate.SetProperty("SearchButtonText", Ddo_br_encounter_admitdate_Searchbuttontext);
            ucDdo_br_encounter_admitdate.SetProperty("DropDownOptionsTitleSettingsIcons", AV25DDO_TitleSettingsIcons);
            ucDdo_br_encounter_admitdate.SetProperty("DropDownOptionsData", AV36BR_Encounter_AdmitDateTitleFilterData);
            ucDdo_br_encounter_admitdate.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_encounter_admitdate_Internalname, "DDO_BR_ENCOUNTER_ADMITDATEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 54,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_encounter_admitdatetitlecontrolidtoreplace_Internalname, AV37ddo_BR_Encounter_AdmitDateTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,54);\"", 0, edtavDdo_br_encounter_admitdatetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_WebPanel3.htm");
            /* User Defined Control */
            ucDdo_br_encounter_status.SetProperty("Caption", Ddo_br_encounter_status_Caption);
            ucDdo_br_encounter_status.SetProperty("Tooltip", Ddo_br_encounter_status_Tooltip);
            ucDdo_br_encounter_status.SetProperty("Cls", Ddo_br_encounter_status_Cls);
            ucDdo_br_encounter_status.SetProperty("DropDownOptionsType", Ddo_br_encounter_status_Dropdownoptionstype);
            ucDdo_br_encounter_status.SetProperty("IncludeSortASC", Ddo_br_encounter_status_Includesortasc);
            ucDdo_br_encounter_status.SetProperty("IncludeSortDSC", Ddo_br_encounter_status_Includesortdsc);
            ucDdo_br_encounter_status.SetProperty("IncludeFilter", Ddo_br_encounter_status_Includefilter);
            ucDdo_br_encounter_status.SetProperty("IncludeDataList", Ddo_br_encounter_status_Includedatalist);
            ucDdo_br_encounter_status.SetProperty("SortASC", Ddo_br_encounter_status_Sortasc);
            ucDdo_br_encounter_status.SetProperty("SortDSC", Ddo_br_encounter_status_Sortdsc);
            ucDdo_br_encounter_status.SetProperty("SearchButtonText", Ddo_br_encounter_status_Searchbuttontext);
            ucDdo_br_encounter_status.SetProperty("DropDownOptionsTitleSettingsIcons", AV25DDO_TitleSettingsIcons);
            ucDdo_br_encounter_status.SetProperty("DropDownOptionsData", AV21BR_Encounter_StatusTitleFilterData);
            ucDdo_br_encounter_status.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_encounter_status_Internalname, "DDO_BR_ENCOUNTER_STATUSContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 56,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_encounter_statustitlecontrolidtoreplace_Internalname, AV24ddo_BR_Encounter_StatusTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,56);\"", 0, edtavDdo_br_encounter_statustitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_WebPanel3.htm");
            /* User Defined Control */
            ucDdo_br_encounter_israndapprove.SetProperty("Caption", Ddo_br_encounter_israndapprove_Caption);
            ucDdo_br_encounter_israndapprove.SetProperty("Tooltip", Ddo_br_encounter_israndapprove_Tooltip);
            ucDdo_br_encounter_israndapprove.SetProperty("Cls", Ddo_br_encounter_israndapprove_Cls);
            ucDdo_br_encounter_israndapprove.SetProperty("DropDownOptionsType", Ddo_br_encounter_israndapprove_Dropdownoptionstype);
            ucDdo_br_encounter_israndapprove.SetProperty("IncludeSortASC", Ddo_br_encounter_israndapprove_Includesortasc);
            ucDdo_br_encounter_israndapprove.SetProperty("IncludeSortDSC", Ddo_br_encounter_israndapprove_Includesortdsc);
            ucDdo_br_encounter_israndapprove.SetProperty("IncludeFilter", Ddo_br_encounter_israndapprove_Includefilter);
            ucDdo_br_encounter_israndapprove.SetProperty("IncludeDataList", Ddo_br_encounter_israndapprove_Includedatalist);
            ucDdo_br_encounter_israndapprove.SetProperty("SortASC", Ddo_br_encounter_israndapprove_Sortasc);
            ucDdo_br_encounter_israndapprove.SetProperty("SortDSC", Ddo_br_encounter_israndapprove_Sortdsc);
            ucDdo_br_encounter_israndapprove.SetProperty("SearchButtonText", Ddo_br_encounter_israndapprove_Searchbuttontext);
            ucDdo_br_encounter_israndapprove.SetProperty("DropDownOptionsTitleSettingsIcons", AV25DDO_TitleSettingsIcons);
            ucDdo_br_encounter_israndapprove.SetProperty("DropDownOptionsData", AV38BR_Encounter_IsRandApproveTitleFilterData);
            ucDdo_br_encounter_israndapprove.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_encounter_israndapprove_Internalname, "DDO_BR_ENCOUNTER_ISRANDAPPROVEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_encounter_israndapprovetitlecontrolidtoreplace_Internalname, AV39ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,58);\"", 0, edtavDdo_br_encounter_israndapprovetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_WebPanel3.htm");
            /* User Defined Control */
            ucDdo_br_encounter_israndrecheck.SetProperty("Caption", Ddo_br_encounter_israndrecheck_Caption);
            ucDdo_br_encounter_israndrecheck.SetProperty("Tooltip", Ddo_br_encounter_israndrecheck_Tooltip);
            ucDdo_br_encounter_israndrecheck.SetProperty("Cls", Ddo_br_encounter_israndrecheck_Cls);
            ucDdo_br_encounter_israndrecheck.SetProperty("DropDownOptionsType", Ddo_br_encounter_israndrecheck_Dropdownoptionstype);
            ucDdo_br_encounter_israndrecheck.SetProperty("IncludeSortASC", Ddo_br_encounter_israndrecheck_Includesortasc);
            ucDdo_br_encounter_israndrecheck.SetProperty("IncludeSortDSC", Ddo_br_encounter_israndrecheck_Includesortdsc);
            ucDdo_br_encounter_israndrecheck.SetProperty("IncludeFilter", Ddo_br_encounter_israndrecheck_Includefilter);
            ucDdo_br_encounter_israndrecheck.SetProperty("IncludeDataList", Ddo_br_encounter_israndrecheck_Includedatalist);
            ucDdo_br_encounter_israndrecheck.SetProperty("SortASC", Ddo_br_encounter_israndrecheck_Sortasc);
            ucDdo_br_encounter_israndrecheck.SetProperty("SortDSC", Ddo_br_encounter_israndrecheck_Sortdsc);
            ucDdo_br_encounter_israndrecheck.SetProperty("SearchButtonText", Ddo_br_encounter_israndrecheck_Searchbuttontext);
            ucDdo_br_encounter_israndrecheck.SetProperty("DropDownOptionsTitleSettingsIcons", AV25DDO_TitleSettingsIcons);
            ucDdo_br_encounter_israndrecheck.SetProperty("DropDownOptionsData", AV40BR_Encounter_IsRandRecheckTitleFilterData);
            ucDdo_br_encounter_israndrecheck.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_encounter_israndrecheck_Internalname, "DDO_BR_ENCOUNTER_ISRANDRECHECKContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 60,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_encounter_israndrechecktitlecontrolidtoreplace_Internalname, AV41ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,60);\"", 0, edtavDdo_br_encounter_israndrechecktitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_WebPanel3.htm");
            /* User Defined Control */
            ucDdo_br_encounter_isupdate.SetProperty("Caption", Ddo_br_encounter_isupdate_Caption);
            ucDdo_br_encounter_isupdate.SetProperty("Tooltip", Ddo_br_encounter_isupdate_Tooltip);
            ucDdo_br_encounter_isupdate.SetProperty("Cls", Ddo_br_encounter_isupdate_Cls);
            ucDdo_br_encounter_isupdate.SetProperty("DropDownOptionsType", Ddo_br_encounter_isupdate_Dropdownoptionstype);
            ucDdo_br_encounter_isupdate.SetProperty("IncludeSortASC", Ddo_br_encounter_isupdate_Includesortasc);
            ucDdo_br_encounter_isupdate.SetProperty("IncludeSortDSC", Ddo_br_encounter_isupdate_Includesortdsc);
            ucDdo_br_encounter_isupdate.SetProperty("IncludeFilter", Ddo_br_encounter_isupdate_Includefilter);
            ucDdo_br_encounter_isupdate.SetProperty("IncludeDataList", Ddo_br_encounter_isupdate_Includedatalist);
            ucDdo_br_encounter_isupdate.SetProperty("SortASC", Ddo_br_encounter_isupdate_Sortasc);
            ucDdo_br_encounter_isupdate.SetProperty("SortDSC", Ddo_br_encounter_isupdate_Sortdsc);
            ucDdo_br_encounter_isupdate.SetProperty("SearchButtonText", Ddo_br_encounter_isupdate_Searchbuttontext);
            ucDdo_br_encounter_isupdate.SetProperty("DropDownOptionsTitleSettingsIcons", AV25DDO_TitleSettingsIcons);
            ucDdo_br_encounter_isupdate.SetProperty("DropDownOptionsData", AV42BR_Encounter_IsUpdateTitleFilterData);
            ucDdo_br_encounter_isupdate.Render(context, "dvelop.gxbootstrap.dropdownoptions", Ddo_br_encounter_isupdate_Internalname, "DDO_BR_ENCOUNTER_ISUPDATEContainer");
            /* Multiple line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 62,'',false,'" + sGXsfl_31_idx + "',0)\"";
            ClassString = "Attribute";
            StyleString = "";
            ClassString = "Attribute";
            StyleString = "";
            GxWebStd.gx_html_textarea( context, edtavDdo_br_encounter_isupdatetitlecontrolidtoreplace_Internalname, AV43ddo_BR_Encounter_IsUpdateTitleControlIdToReplace, "", TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,62);\"", 0, edtavDdo_br_encounter_isupdatetitlecontrolidtoreplace_Visible, 1, 0, 80, "chr", 4, "row", StyleString, ClassString, "", "", "300", -1, 0, "", "", -1, true, "", "'"+""+"'"+",false,"+"'"+""+"'", 0, "HLP_WebPanel3.htm");
            /* User Defined Control */
            ucWorkwithplusutilities1.Render(context, "dvelop.workwithplusutilities", Workwithplusutilities1_Internalname, "WORKWITHPLUSUTILITIES1Container");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 64,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrderedby_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13OrderedBy), 4, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV13OrderedBy), "ZZZ9")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,64);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrderedby_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrderedby_Visible, 1, 0, "number", "1", 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_WebPanel3.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 65,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavOrdereddsc_Internalname, StringUtil.BoolToStr( AV14OrderedDsc), StringUtil.BoolToStr( AV14OrderedDsc), TempTags+" onchange=\""+""+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,65);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavOrdereddsc_Jsonclick, 0, "Attribute", "", "", "", "", edtavOrdereddsc_Visible, 1, 0, "text", "", 4, "chr", 1, "row", 4, 0, 0, 0, 1, 0, 0, true, "", "right", false, "HLP_WebPanel3.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 66,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_encounterid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV18TFBR_EncounterID), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV18TFBR_EncounterID), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,66);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_encounterid_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_encounterid_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_WebPanel3.htm");
            /* Single line edit */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 67,'',false,'" + sGXsfl_31_idx + "',0)\"";
            GxWebStd.gx_single_line_edit( context, edtavTfbr_encounterid_to_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV19TFBR_EncounterID_To), 18, 0, ".", "")), StringUtil.LTrim( context.localUtil.Format( (decimal)(AV19TFBR_EncounterID_To), "ZZZZZZZZZZZZZZZZZZ")), TempTags+" onchange=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onchange(this, event)\" "+" onblur=\""+";gx.evt.onblur(this,67);\"", "'"+""+"'"+",false,"+"'"+""+"'", "", "", "", "", edtavTfbr_encounterid_to_Jsonclick, 0, "Attribute", "", "", "", "", edtavTfbr_encounterid_to_Visible, 1, 0, "number", "1", 18, "chr", 1, "row", 18, 0, 0, 0, 1, -1, 0, true, "", "right", false, "HLP_WebPanel3.htm");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
            GxWebStd.gx_div_end( context, "left", "top", "div");
         }
         if ( wbEnd == 31 )
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

      protected void STARTA82( )
      {
         wbLoad = false;
         wbEnd = 0;
         wbStart = 0;
         if ( ! context.isSpaRequest( ) )
         {
            Form.Meta.addItem("generator", "GeneXus C# 16_0_0-127771", 0) ;
            Form.Meta.addItem("description", "Web Panel3", 0) ;
         }
         context.wjLoc = "";
         context.nUserReturn = 0;
         context.wbHandled = 0;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false;
         STRUPA80( ) ;
      }

      protected void WSA82( )
      {
         STARTA82( ) ;
         EVTA82( ) ;
      }

      protected void EVTA82( )
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
                              E11A82 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRIDPAGINATIONBAR.CHANGEROWSPERPAGE") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E12A82 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_ENCOUNTERID.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E13A82 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_ENCOUNTER_DEPARTMENT.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E14A82 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_ENCOUNTER_ENCTYPE.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E15A82 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_ENCOUNTER_ADMITDATE.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E16A82 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_ENCOUNTER_STATUS.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E17A82 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_ENCOUNTER_ISRANDAPPROVE.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E18A82 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_ENCOUNTER_ISRANDRECHECK.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E19A82 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "DDO_BR_ENCOUNTER_ISUPDATE.ONOPTIONCLICKED") == 0 )
                           {
                              context.wbHandled = 1;
                              dynload_actions( ) ;
                              E20A82 ();
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
                              nGXsfl_31_idx = (short)(NumberUtil.Val( sEvtType, "."));
                              sGXsfl_31_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_31_idx), 4, 0)), 4, "0");
                              SubsflControlProps_312( ) ;
                              A19BR_EncounterID = (long)(context.localUtil.CToN( cgiGet( edtBR_EncounterID_Internalname), ".", ","));
                              A84BR_Encounter_Department = cgiGet( edtBR_Encounter_Department_Internalname);
                              n84BR_Encounter_Department = false;
                              A90BR_Encounter_ENCType = cgiGet( edtBR_Encounter_ENCType_Internalname);
                              n90BR_Encounter_ENCType = false;
                              A91BR_Encounter_AdmitDate = DateTimeUtil.ResetTime(context.localUtil.CToT( cgiGet( edtBR_Encounter_AdmitDate_Internalname), 0));
                              n91BR_Encounter_AdmitDate = false;
                              cmbBR_Encounter_Status.Name = cmbBR_Encounter_Status_Internalname;
                              cmbBR_Encounter_Status.CurrentValue = cgiGet( cmbBR_Encounter_Status_Internalname);
                              A172BR_Encounter_Status = (short)(NumberUtil.Val( cgiGet( cmbBR_Encounter_Status_Internalname), "."));
                              n172BR_Encounter_Status = false;
                              A192BR_Encounter_IsRandApprove = StringUtil.StrToBool( cgiGet( chkBR_Encounter_IsRandApprove_Internalname));
                              n192BR_Encounter_IsRandApprove = false;
                              A193BR_Encounter_IsRandRecheck = StringUtil.StrToBool( cgiGet( chkBR_Encounter_IsRandRecheck_Internalname));
                              n193BR_Encounter_IsRandRecheck = false;
                              A202BR_Encounter_IsUpdate = StringUtil.StrToBool( cgiGet( chkBR_Encounter_IsUpdate_Internalname));
                              n202BR_Encounter_IsUpdate = false;
                              sEvtType = StringUtil.Right( sEvt, 1);
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1));
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Start */
                                    E21A82 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    /* Execute user event: Refresh */
                                    E22A82 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "GRID.LOAD") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    dynload_actions( ) ;
                                    E23A82 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false;
                                       /* Set Refresh If Br_encounter_status Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vBR_ENCOUNTER_STATUS"), ".", ",") != Convert.ToDecimal( AV15BR_Encounter_Status )) )
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
                                       /* Set Refresh If Tfbr_encounterid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_ENCOUNTERID"), ".", ",") != Convert.ToDecimal( AV18TFBR_EncounterID )) )
                                       {
                                          Rfr0gs = true;
                                       }
                                       /* Set Refresh If Tfbr_encounterid_to Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_ENCOUNTERID_TO"), ".", ",") != Convert.ToDecimal( AV19TFBR_EncounterID_To )) )
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

      protected void WEA82( )
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

      protected void PAA82( )
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
               GX_FocusControl = cmbavBr_encounter_status_Internalname;
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
         SubsflControlProps_312( ) ;
         while ( nGXsfl_31_idx <= nRC_GXsfl_31 )
         {
            sendrow_312( ) ;
            nGXsfl_31_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_31_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_31_idx+1));
            sGXsfl_31_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_31_idx), 4, 0)), 4, "0");
            SubsflControlProps_312( ) ;
         }
         context.GX_webresponse.AddString(context.httpAjaxContext.getJSONContainerResponse( GridContainer));
         /* End function gxnrGrid_newrow */
      }

      protected void gxgrGrid_refresh( int subGrid_Rows ,
                                       short AV15BR_Encounter_Status ,
                                       short AV13OrderedBy ,
                                       bool AV14OrderedDsc ,
                                       long AV18TFBR_EncounterID ,
                                       long AV19TFBR_EncounterID_To ,
                                       String AV20ddo_BR_EncounterIDTitleControlIdToReplace ,
                                       String AV33ddo_BR_Encounter_DepartmentTitleControlIdToReplace ,
                                       String AV35ddo_BR_Encounter_ENCTypeTitleControlIdToReplace ,
                                       String AV37ddo_BR_Encounter_AdmitDateTitleControlIdToReplace ,
                                       String AV24ddo_BR_Encounter_StatusTitleControlIdToReplace ,
                                       String AV39ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace ,
                                       String AV41ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace ,
                                       String AV43ddo_BR_Encounter_IsUpdateTitleControlIdToReplace ,
                                       String AV49Pgmname )
      {
         initialize_formulas( ) ;
         GxWebStd.set_html_headers( context, 0, "", "");
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         GRID_nCurrentRecord = 0;
         RFA82( ) ;
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
         if ( cmbavBr_encounter_status.ItemCount > 0 )
         {
            AV15BR_Encounter_Status = (short)(NumberUtil.Val( cmbavBr_encounter_status.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV15BR_Encounter_Status), 4, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15BR_Encounter_Status", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15BR_Encounter_Status), 4, 0)));
         }
         if ( context.isAjaxRequest( ) )
         {
            cmbavBr_encounter_status.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(AV15BR_Encounter_Status), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavBr_encounter_status_Internalname, "Values", cmbavBr_encounter_status.ToJavascriptSource(), true);
         }
      }

      public void Refresh( )
      {
         send_integrity_hashes( ) ;
         RFA82( ) ;
         if ( isFullAjaxMode( ) )
         {
            send_integrity_footer_hashes( ) ;
         }
      }

      protected void initialize_formulas( )
      {
         /* GeneXus formulas. */
         AV49Pgmname = "WebPanel3";
         context.Gx_err = 0;
      }

      protected void RFA82( )
      {
         initialize_formulas( ) ;
         clear_multi_value_controls( ) ;
         if ( isAjaxCallMode( ) )
         {
            GridContainer.ClearRows();
         }
         wbStart = 31;
         /* Execute user event: Refresh */
         E22A82 ();
         nGXsfl_31_idx = 1;
         sGXsfl_31_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_31_idx), 4, 0)), 4, "0");
         SubsflControlProps_312( ) ;
         bGXsfl_31_Refreshing = true;
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
            SubsflControlProps_312( ) ;
            GXPagingFrom2 = (int)(((subGrid_Rows==0) ? 0 : GRID_nFirstRecordOnPage));
            GXPagingTo2 = ((subGrid_Rows==0) ? 10000 : subGrid_Recordsperpage( )+1);
            pr_default.dynParam(0, new Object[]{ new Object[]{
                                                 AV46WebPanel3DS_1_Br_encounter_status ,
                                                 AV47WebPanel3DS_2_Tfbr_encounterid ,
                                                 AV48WebPanel3DS_3_Tfbr_encounterid_to ,
                                                 A172BR_Encounter_Status ,
                                                 A19BR_EncounterID ,
                                                 AV13OrderedBy ,
                                                 AV14OrderedDsc } ,
                                                 new int[]{
                                                 TypeConstants.SHORT, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.SHORT, TypeConstants.BOOLEAN
                                                 }
            } ) ;
            /* Using cursor H00A82 */
            pr_default.execute(0, new Object[] {AV46WebPanel3DS_1_Br_encounter_status, AV47WebPanel3DS_2_Tfbr_encounterid, AV48WebPanel3DS_3_Tfbr_encounterid_to, GXPagingFrom2, GXPagingTo2, GXPagingTo2});
            nGXsfl_31_idx = 1;
            sGXsfl_31_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_31_idx), 4, 0)), 4, "0");
            SubsflControlProps_312( ) ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( subGrid_Rows == 0 ) || ( GRID_nCurrentRecord < subGrid_Recordsperpage( ) ) ) ) )
            {
               A202BR_Encounter_IsUpdate = H00A82_A202BR_Encounter_IsUpdate[0];
               n202BR_Encounter_IsUpdate = H00A82_n202BR_Encounter_IsUpdate[0];
               A193BR_Encounter_IsRandRecheck = H00A82_A193BR_Encounter_IsRandRecheck[0];
               n193BR_Encounter_IsRandRecheck = H00A82_n193BR_Encounter_IsRandRecheck[0];
               A192BR_Encounter_IsRandApprove = H00A82_A192BR_Encounter_IsRandApprove[0];
               n192BR_Encounter_IsRandApprove = H00A82_n192BR_Encounter_IsRandApprove[0];
               A172BR_Encounter_Status = H00A82_A172BR_Encounter_Status[0];
               n172BR_Encounter_Status = H00A82_n172BR_Encounter_Status[0];
               A91BR_Encounter_AdmitDate = H00A82_A91BR_Encounter_AdmitDate[0];
               n91BR_Encounter_AdmitDate = H00A82_n91BR_Encounter_AdmitDate[0];
               A90BR_Encounter_ENCType = H00A82_A90BR_Encounter_ENCType[0];
               n90BR_Encounter_ENCType = H00A82_n90BR_Encounter_ENCType[0];
               A84BR_Encounter_Department = H00A82_A84BR_Encounter_Department[0];
               n84BR_Encounter_Department = H00A82_n84BR_Encounter_Department[0];
               A19BR_EncounterID = H00A82_A19BR_EncounterID[0];
               E23A82 ();
               pr_default.readNext(0);
            }
            GRID_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0));
            GxWebStd.gx_hidden_field( context, "GRID_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nEOF), 1, 0, ".", "")));
            pr_default.close(0);
            wbEnd = 31;
            WBA80( ) ;
         }
         bGXsfl_31_Refreshing = true;
      }

      protected void send_integrity_lvl_hashesA82( )
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
         AV46WebPanel3DS_1_Br_encounter_status = AV15BR_Encounter_Status;
         AV47WebPanel3DS_2_Tfbr_encounterid = AV18TFBR_EncounterID;
         AV48WebPanel3DS_3_Tfbr_encounterid_to = AV19TFBR_EncounterID_To;
         pr_default.dynParam(1, new Object[]{ new Object[]{
                                              AV46WebPanel3DS_1_Br_encounter_status ,
                                              AV47WebPanel3DS_2_Tfbr_encounterid ,
                                              AV48WebPanel3DS_3_Tfbr_encounterid_to ,
                                              A172BR_Encounter_Status ,
                                              A19BR_EncounterID ,
                                              AV13OrderedBy ,
                                              AV14OrderedDsc } ,
                                              new int[]{
                                              TypeConstants.SHORT, TypeConstants.LONG, TypeConstants.LONG, TypeConstants.SHORT, TypeConstants.BOOLEAN, TypeConstants.LONG, TypeConstants.SHORT, TypeConstants.BOOLEAN
                                              }
         } ) ;
         /* Using cursor H00A83 */
         pr_default.execute(1, new Object[] {AV46WebPanel3DS_1_Br_encounter_status, AV47WebPanel3DS_2_Tfbr_encounterid, AV48WebPanel3DS_3_Tfbr_encounterid_to});
         GRID_nRecordCount = H00A83_AGRID_nRecordCount[0];
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
         AV46WebPanel3DS_1_Br_encounter_status = AV15BR_Encounter_Status;
         AV47WebPanel3DS_2_Tfbr_encounterid = AV18TFBR_EncounterID;
         AV48WebPanel3DS_3_Tfbr_encounterid_to = AV19TFBR_EncounterID_To;
         GRID_nFirstRecordOnPage = 0;
         GxWebStd.gx_hidden_field( context, "GRID_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID_nFirstRecordOnPage), 15, 0, ".", "")));
         if ( isFullAjaxMode( ) )
         {
            gxgrGrid_refresh( subGrid_Rows, AV15BR_Encounter_Status, AV13OrderedBy, AV14OrderedDsc, AV18TFBR_EncounterID, AV19TFBR_EncounterID_To, AV20ddo_BR_EncounterIDTitleControlIdToReplace, AV33ddo_BR_Encounter_DepartmentTitleControlIdToReplace, AV35ddo_BR_Encounter_ENCTypeTitleControlIdToReplace, AV37ddo_BR_Encounter_AdmitDateTitleControlIdToReplace, AV24ddo_BR_Encounter_StatusTitleControlIdToReplace, AV39ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace, AV41ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace, AV43ddo_BR_Encounter_IsUpdateTitleControlIdToReplace, AV49Pgmname) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid_nextpage( )
      {
         AV46WebPanel3DS_1_Br_encounter_status = AV15BR_Encounter_Status;
         AV47WebPanel3DS_2_Tfbr_encounterid = AV18TFBR_EncounterID;
         AV48WebPanel3DS_3_Tfbr_encounterid_to = AV19TFBR_EncounterID_To;
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
            gxgrGrid_refresh( subGrid_Rows, AV15BR_Encounter_Status, AV13OrderedBy, AV14OrderedDsc, AV18TFBR_EncounterID, AV19TFBR_EncounterID_To, AV20ddo_BR_EncounterIDTitleControlIdToReplace, AV33ddo_BR_Encounter_DepartmentTitleControlIdToReplace, AV35ddo_BR_Encounter_ENCTypeTitleControlIdToReplace, AV37ddo_BR_Encounter_AdmitDateTitleControlIdToReplace, AV24ddo_BR_Encounter_StatusTitleControlIdToReplace, AV39ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace, AV41ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace, AV43ddo_BR_Encounter_IsUpdateTitleControlIdToReplace, AV49Pgmname) ;
         }
         send_integrity_footer_hashes( ) ;
         return (short)(((GRID_nEOF==0) ? 0 : 2)) ;
      }

      protected short subgrid_previouspage( )
      {
         AV46WebPanel3DS_1_Br_encounter_status = AV15BR_Encounter_Status;
         AV47WebPanel3DS_2_Tfbr_encounterid = AV18TFBR_EncounterID;
         AV48WebPanel3DS_3_Tfbr_encounterid_to = AV19TFBR_EncounterID_To;
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
            gxgrGrid_refresh( subGrid_Rows, AV15BR_Encounter_Status, AV13OrderedBy, AV14OrderedDsc, AV18TFBR_EncounterID, AV19TFBR_EncounterID_To, AV20ddo_BR_EncounterIDTitleControlIdToReplace, AV33ddo_BR_Encounter_DepartmentTitleControlIdToReplace, AV35ddo_BR_Encounter_ENCTypeTitleControlIdToReplace, AV37ddo_BR_Encounter_AdmitDateTitleControlIdToReplace, AV24ddo_BR_Encounter_StatusTitleControlIdToReplace, AV39ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace, AV41ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace, AV43ddo_BR_Encounter_IsUpdateTitleControlIdToReplace, AV49Pgmname) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected short subgrid_lastpage( )
      {
         AV46WebPanel3DS_1_Br_encounter_status = AV15BR_Encounter_Status;
         AV47WebPanel3DS_2_Tfbr_encounterid = AV18TFBR_EncounterID;
         AV48WebPanel3DS_3_Tfbr_encounterid_to = AV19TFBR_EncounterID_To;
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
            gxgrGrid_refresh( subGrid_Rows, AV15BR_Encounter_Status, AV13OrderedBy, AV14OrderedDsc, AV18TFBR_EncounterID, AV19TFBR_EncounterID_To, AV20ddo_BR_EncounterIDTitleControlIdToReplace, AV33ddo_BR_Encounter_DepartmentTitleControlIdToReplace, AV35ddo_BR_Encounter_ENCTypeTitleControlIdToReplace, AV37ddo_BR_Encounter_AdmitDateTitleControlIdToReplace, AV24ddo_BR_Encounter_StatusTitleControlIdToReplace, AV39ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace, AV41ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace, AV43ddo_BR_Encounter_IsUpdateTitleControlIdToReplace, AV49Pgmname) ;
         }
         send_integrity_footer_hashes( ) ;
         return 0 ;
      }

      protected int subgrid_gotopage( int nPageNo )
      {
         AV46WebPanel3DS_1_Br_encounter_status = AV15BR_Encounter_Status;
         AV47WebPanel3DS_2_Tfbr_encounterid = AV18TFBR_EncounterID;
         AV48WebPanel3DS_3_Tfbr_encounterid_to = AV19TFBR_EncounterID_To;
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
            gxgrGrid_refresh( subGrid_Rows, AV15BR_Encounter_Status, AV13OrderedBy, AV14OrderedDsc, AV18TFBR_EncounterID, AV19TFBR_EncounterID_To, AV20ddo_BR_EncounterIDTitleControlIdToReplace, AV33ddo_BR_Encounter_DepartmentTitleControlIdToReplace, AV35ddo_BR_Encounter_ENCTypeTitleControlIdToReplace, AV37ddo_BR_Encounter_AdmitDateTitleControlIdToReplace, AV24ddo_BR_Encounter_StatusTitleControlIdToReplace, AV39ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace, AV41ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace, AV43ddo_BR_Encounter_IsUpdateTitleControlIdToReplace, AV49Pgmname) ;
         }
         send_integrity_footer_hashes( ) ;
         return (int)(0) ;
      }

      protected void STRUPA80( )
      {
         /* Before Start, stand alone formulas. */
         AV49Pgmname = "WebPanel3";
         context.Gx_err = 0;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0;
         /* Execute user event: Start */
         E21A82 ();
         context.wbGlbDoneStart = 1;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( "vDDO_TITLESETTINGSICONS"), AV25DDO_TitleSettingsIcons);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_ENCOUNTERIDTITLEFILTERDATA"), AV17BR_EncounterIDTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_ENCOUNTER_DEPARTMENTTITLEFILTERDATA"), AV32BR_Encounter_DepartmentTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_ENCOUNTER_ENCTYPETITLEFILTERDATA"), AV34BR_Encounter_ENCTypeTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_ENCOUNTER_ADMITDATETITLEFILTERDATA"), AV36BR_Encounter_AdmitDateTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_ENCOUNTER_STATUSTITLEFILTERDATA"), AV21BR_Encounter_StatusTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_ENCOUNTER_ISRANDAPPROVETITLEFILTERDATA"), AV38BR_Encounter_IsRandApproveTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_ENCOUNTER_ISRANDRECHECKTITLEFILTERDATA"), AV40BR_Encounter_IsRandRecheckTitleFilterData);
            ajax_req_read_hidden_sdt(cgiGet( "vBR_ENCOUNTER_ISUPDATETITLEFILTERDATA"), AV42BR_Encounter_IsUpdateTitleFilterData);
            /* Read variables values. */
            cmbavBr_encounter_status.Name = cmbavBr_encounter_status_Internalname;
            cmbavBr_encounter_status.CurrentValue = cgiGet( cmbavBr_encounter_status_Internalname);
            AV15BR_Encounter_Status = (short)(NumberUtil.Val( cgiGet( cmbavBr_encounter_status_Internalname), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15BR_Encounter_Status", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15BR_Encounter_Status), 4, 0)));
            AV20ddo_BR_EncounterIDTitleControlIdToReplace = cgiGet( edtavDdo_br_encounteridtitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20ddo_BR_EncounterIDTitleControlIdToReplace", AV20ddo_BR_EncounterIDTitleControlIdToReplace);
            AV33ddo_BR_Encounter_DepartmentTitleControlIdToReplace = cgiGet( edtavDdo_br_encounter_departmenttitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33ddo_BR_Encounter_DepartmentTitleControlIdToReplace", AV33ddo_BR_Encounter_DepartmentTitleControlIdToReplace);
            AV35ddo_BR_Encounter_ENCTypeTitleControlIdToReplace = cgiGet( edtavDdo_br_encounter_enctypetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV35ddo_BR_Encounter_ENCTypeTitleControlIdToReplace", AV35ddo_BR_Encounter_ENCTypeTitleControlIdToReplace);
            AV37ddo_BR_Encounter_AdmitDateTitleControlIdToReplace = cgiGet( edtavDdo_br_encounter_admitdatetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV37ddo_BR_Encounter_AdmitDateTitleControlIdToReplace", AV37ddo_BR_Encounter_AdmitDateTitleControlIdToReplace);
            AV24ddo_BR_Encounter_StatusTitleControlIdToReplace = cgiGet( edtavDdo_br_encounter_statustitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24ddo_BR_Encounter_StatusTitleControlIdToReplace", AV24ddo_BR_Encounter_StatusTitleControlIdToReplace);
            AV39ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace = cgiGet( edtavDdo_br_encounter_israndapprovetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV39ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace", AV39ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace);
            AV41ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace = cgiGet( edtavDdo_br_encounter_israndrechecktitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV41ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace", AV41ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace);
            AV43ddo_BR_Encounter_IsUpdateTitleControlIdToReplace = cgiGet( edtavDdo_br_encounter_isupdatetitlecontrolidtoreplace_Internalname);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV43ddo_BR_Encounter_IsUpdateTitleControlIdToReplace", AV43ddo_BR_Encounter_IsUpdateTitleControlIdToReplace);
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
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_encounterid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_encounterid_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_ENCOUNTERID");
               GX_FocusControl = edtavTfbr_encounterid_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV18TFBR_EncounterID = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18TFBR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18TFBR_EncounterID), 18, 0)));
            }
            else
            {
               AV18TFBR_EncounterID = (long)(context.localUtil.CToN( cgiGet( edtavTfbr_encounterid_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18TFBR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18TFBR_EncounterID), 18, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavTfbr_encounterid_to_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavTfbr_encounterid_to_Internalname), ".", ",") > Convert.ToDecimal( 999999999999999999L )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vTFBR_ENCOUNTERID_TO");
               GX_FocusControl = edtavTfbr_encounterid_to_Internalname;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true;
               AV19TFBR_EncounterID_To = 0;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19TFBR_EncounterID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV19TFBR_EncounterID_To), 18, 0)));
            }
            else
            {
               AV19TFBR_EncounterID_To = (long)(context.localUtil.CToN( cgiGet( edtavTfbr_encounterid_to_Internalname), ".", ","));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19TFBR_EncounterID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV19TFBR_EncounterID_To), 18, 0)));
            }
            /* Read saved values. */
            nRC_GXsfl_31 = (short)(context.localUtil.CToN( cgiGet( "nRC_GXsfl_31"), ".", ","));
            AV27GridCurrentPage = (long)(context.localUtil.CToN( cgiGet( "vGRIDCURRENTPAGE"), ".", ","));
            AV29GridRecordCount = (long)(context.localUtil.CToN( cgiGet( "vGRIDRECORDCOUNT"), ".", ","));
            AV28GridPageSize = (long)(context.localUtil.CToN( cgiGet( "vGRIDPAGESIZE"), ".", ","));
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
            Ddo_br_encounterid_Caption = cgiGet( "DDO_BR_ENCOUNTERID_Caption");
            Ddo_br_encounterid_Tooltip = cgiGet( "DDO_BR_ENCOUNTERID_Tooltip");
            Ddo_br_encounterid_Cls = cgiGet( "DDO_BR_ENCOUNTERID_Cls");
            Ddo_br_encounterid_Filteredtext_set = cgiGet( "DDO_BR_ENCOUNTERID_Filteredtext_set");
            Ddo_br_encounterid_Filteredtextto_set = cgiGet( "DDO_BR_ENCOUNTERID_Filteredtextto_set");
            Ddo_br_encounterid_Dropdownoptionstype = cgiGet( "DDO_BR_ENCOUNTERID_Dropdownoptionstype");
            Ddo_br_encounterid_Titlecontrolidtoreplace = cgiGet( "DDO_BR_ENCOUNTERID_Titlecontrolidtoreplace");
            Ddo_br_encounterid_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTERID_Includesortasc"));
            Ddo_br_encounterid_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTERID_Includesortdsc"));
            Ddo_br_encounterid_Sortedstatus = cgiGet( "DDO_BR_ENCOUNTERID_Sortedstatus");
            Ddo_br_encounterid_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTERID_Includefilter"));
            Ddo_br_encounterid_Filtertype = cgiGet( "DDO_BR_ENCOUNTERID_Filtertype");
            Ddo_br_encounterid_Filterisrange = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTERID_Filterisrange"));
            Ddo_br_encounterid_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTERID_Includedatalist"));
            Ddo_br_encounterid_Sortasc = cgiGet( "DDO_BR_ENCOUNTERID_Sortasc");
            Ddo_br_encounterid_Sortdsc = cgiGet( "DDO_BR_ENCOUNTERID_Sortdsc");
            Ddo_br_encounterid_Cleanfilter = cgiGet( "DDO_BR_ENCOUNTERID_Cleanfilter");
            Ddo_br_encounterid_Rangefilterfrom = cgiGet( "DDO_BR_ENCOUNTERID_Rangefilterfrom");
            Ddo_br_encounterid_Rangefilterto = cgiGet( "DDO_BR_ENCOUNTERID_Rangefilterto");
            Ddo_br_encounterid_Searchbuttontext = cgiGet( "DDO_BR_ENCOUNTERID_Searchbuttontext");
            Ddo_br_encounter_department_Caption = cgiGet( "DDO_BR_ENCOUNTER_DEPARTMENT_Caption");
            Ddo_br_encounter_department_Tooltip = cgiGet( "DDO_BR_ENCOUNTER_DEPARTMENT_Tooltip");
            Ddo_br_encounter_department_Cls = cgiGet( "DDO_BR_ENCOUNTER_DEPARTMENT_Cls");
            Ddo_br_encounter_department_Dropdownoptionstype = cgiGet( "DDO_BR_ENCOUNTER_DEPARTMENT_Dropdownoptionstype");
            Ddo_br_encounter_department_Titlecontrolidtoreplace = cgiGet( "DDO_BR_ENCOUNTER_DEPARTMENT_Titlecontrolidtoreplace");
            Ddo_br_encounter_department_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_DEPARTMENT_Includesortasc"));
            Ddo_br_encounter_department_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_DEPARTMENT_Includesortdsc"));
            Ddo_br_encounter_department_Sortedstatus = cgiGet( "DDO_BR_ENCOUNTER_DEPARTMENT_Sortedstatus");
            Ddo_br_encounter_department_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_DEPARTMENT_Includefilter"));
            Ddo_br_encounter_department_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_DEPARTMENT_Includedatalist"));
            Ddo_br_encounter_department_Sortasc = cgiGet( "DDO_BR_ENCOUNTER_DEPARTMENT_Sortasc");
            Ddo_br_encounter_department_Sortdsc = cgiGet( "DDO_BR_ENCOUNTER_DEPARTMENT_Sortdsc");
            Ddo_br_encounter_department_Searchbuttontext = cgiGet( "DDO_BR_ENCOUNTER_DEPARTMENT_Searchbuttontext");
            Ddo_br_encounter_enctype_Caption = cgiGet( "DDO_BR_ENCOUNTER_ENCTYPE_Caption");
            Ddo_br_encounter_enctype_Tooltip = cgiGet( "DDO_BR_ENCOUNTER_ENCTYPE_Tooltip");
            Ddo_br_encounter_enctype_Cls = cgiGet( "DDO_BR_ENCOUNTER_ENCTYPE_Cls");
            Ddo_br_encounter_enctype_Dropdownoptionstype = cgiGet( "DDO_BR_ENCOUNTER_ENCTYPE_Dropdownoptionstype");
            Ddo_br_encounter_enctype_Titlecontrolidtoreplace = cgiGet( "DDO_BR_ENCOUNTER_ENCTYPE_Titlecontrolidtoreplace");
            Ddo_br_encounter_enctype_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_ENCTYPE_Includesortasc"));
            Ddo_br_encounter_enctype_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_ENCTYPE_Includesortdsc"));
            Ddo_br_encounter_enctype_Sortedstatus = cgiGet( "DDO_BR_ENCOUNTER_ENCTYPE_Sortedstatus");
            Ddo_br_encounter_enctype_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_ENCTYPE_Includefilter"));
            Ddo_br_encounter_enctype_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_ENCTYPE_Includedatalist"));
            Ddo_br_encounter_enctype_Sortasc = cgiGet( "DDO_BR_ENCOUNTER_ENCTYPE_Sortasc");
            Ddo_br_encounter_enctype_Sortdsc = cgiGet( "DDO_BR_ENCOUNTER_ENCTYPE_Sortdsc");
            Ddo_br_encounter_enctype_Searchbuttontext = cgiGet( "DDO_BR_ENCOUNTER_ENCTYPE_Searchbuttontext");
            Ddo_br_encounter_admitdate_Caption = cgiGet( "DDO_BR_ENCOUNTER_ADMITDATE_Caption");
            Ddo_br_encounter_admitdate_Tooltip = cgiGet( "DDO_BR_ENCOUNTER_ADMITDATE_Tooltip");
            Ddo_br_encounter_admitdate_Cls = cgiGet( "DDO_BR_ENCOUNTER_ADMITDATE_Cls");
            Ddo_br_encounter_admitdate_Dropdownoptionstype = cgiGet( "DDO_BR_ENCOUNTER_ADMITDATE_Dropdownoptionstype");
            Ddo_br_encounter_admitdate_Titlecontrolidtoreplace = cgiGet( "DDO_BR_ENCOUNTER_ADMITDATE_Titlecontrolidtoreplace");
            Ddo_br_encounter_admitdate_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_ADMITDATE_Includesortasc"));
            Ddo_br_encounter_admitdate_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_ADMITDATE_Includesortdsc"));
            Ddo_br_encounter_admitdate_Sortedstatus = cgiGet( "DDO_BR_ENCOUNTER_ADMITDATE_Sortedstatus");
            Ddo_br_encounter_admitdate_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_ADMITDATE_Includefilter"));
            Ddo_br_encounter_admitdate_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_ADMITDATE_Includedatalist"));
            Ddo_br_encounter_admitdate_Sortasc = cgiGet( "DDO_BR_ENCOUNTER_ADMITDATE_Sortasc");
            Ddo_br_encounter_admitdate_Sortdsc = cgiGet( "DDO_BR_ENCOUNTER_ADMITDATE_Sortdsc");
            Ddo_br_encounter_admitdate_Searchbuttontext = cgiGet( "DDO_BR_ENCOUNTER_ADMITDATE_Searchbuttontext");
            Ddo_br_encounter_status_Caption = cgiGet( "DDO_BR_ENCOUNTER_STATUS_Caption");
            Ddo_br_encounter_status_Tooltip = cgiGet( "DDO_BR_ENCOUNTER_STATUS_Tooltip");
            Ddo_br_encounter_status_Cls = cgiGet( "DDO_BR_ENCOUNTER_STATUS_Cls");
            Ddo_br_encounter_status_Dropdownoptionstype = cgiGet( "DDO_BR_ENCOUNTER_STATUS_Dropdownoptionstype");
            Ddo_br_encounter_status_Titlecontrolidtoreplace = cgiGet( "DDO_BR_ENCOUNTER_STATUS_Titlecontrolidtoreplace");
            Ddo_br_encounter_status_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_STATUS_Includesortasc"));
            Ddo_br_encounter_status_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_STATUS_Includesortdsc"));
            Ddo_br_encounter_status_Sortedstatus = cgiGet( "DDO_BR_ENCOUNTER_STATUS_Sortedstatus");
            Ddo_br_encounter_status_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_STATUS_Includefilter"));
            Ddo_br_encounter_status_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_STATUS_Includedatalist"));
            Ddo_br_encounter_status_Sortasc = cgiGet( "DDO_BR_ENCOUNTER_STATUS_Sortasc");
            Ddo_br_encounter_status_Sortdsc = cgiGet( "DDO_BR_ENCOUNTER_STATUS_Sortdsc");
            Ddo_br_encounter_status_Searchbuttontext = cgiGet( "DDO_BR_ENCOUNTER_STATUS_Searchbuttontext");
            Ddo_br_encounter_israndapprove_Caption = cgiGet( "DDO_BR_ENCOUNTER_ISRANDAPPROVE_Caption");
            Ddo_br_encounter_israndapprove_Tooltip = cgiGet( "DDO_BR_ENCOUNTER_ISRANDAPPROVE_Tooltip");
            Ddo_br_encounter_israndapprove_Cls = cgiGet( "DDO_BR_ENCOUNTER_ISRANDAPPROVE_Cls");
            Ddo_br_encounter_israndapprove_Dropdownoptionstype = cgiGet( "DDO_BR_ENCOUNTER_ISRANDAPPROVE_Dropdownoptionstype");
            Ddo_br_encounter_israndapprove_Titlecontrolidtoreplace = cgiGet( "DDO_BR_ENCOUNTER_ISRANDAPPROVE_Titlecontrolidtoreplace");
            Ddo_br_encounter_israndapprove_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_ISRANDAPPROVE_Includesortasc"));
            Ddo_br_encounter_israndapprove_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_ISRANDAPPROVE_Includesortdsc"));
            Ddo_br_encounter_israndapprove_Sortedstatus = cgiGet( "DDO_BR_ENCOUNTER_ISRANDAPPROVE_Sortedstatus");
            Ddo_br_encounter_israndapprove_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_ISRANDAPPROVE_Includefilter"));
            Ddo_br_encounter_israndapprove_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_ISRANDAPPROVE_Includedatalist"));
            Ddo_br_encounter_israndapprove_Sortasc = cgiGet( "DDO_BR_ENCOUNTER_ISRANDAPPROVE_Sortasc");
            Ddo_br_encounter_israndapprove_Sortdsc = cgiGet( "DDO_BR_ENCOUNTER_ISRANDAPPROVE_Sortdsc");
            Ddo_br_encounter_israndapprove_Searchbuttontext = cgiGet( "DDO_BR_ENCOUNTER_ISRANDAPPROVE_Searchbuttontext");
            Ddo_br_encounter_israndrecheck_Caption = cgiGet( "DDO_BR_ENCOUNTER_ISRANDRECHECK_Caption");
            Ddo_br_encounter_israndrecheck_Tooltip = cgiGet( "DDO_BR_ENCOUNTER_ISRANDRECHECK_Tooltip");
            Ddo_br_encounter_israndrecheck_Cls = cgiGet( "DDO_BR_ENCOUNTER_ISRANDRECHECK_Cls");
            Ddo_br_encounter_israndrecheck_Dropdownoptionstype = cgiGet( "DDO_BR_ENCOUNTER_ISRANDRECHECK_Dropdownoptionstype");
            Ddo_br_encounter_israndrecheck_Titlecontrolidtoreplace = cgiGet( "DDO_BR_ENCOUNTER_ISRANDRECHECK_Titlecontrolidtoreplace");
            Ddo_br_encounter_israndrecheck_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_ISRANDRECHECK_Includesortasc"));
            Ddo_br_encounter_israndrecheck_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_ISRANDRECHECK_Includesortdsc"));
            Ddo_br_encounter_israndrecheck_Sortedstatus = cgiGet( "DDO_BR_ENCOUNTER_ISRANDRECHECK_Sortedstatus");
            Ddo_br_encounter_israndrecheck_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_ISRANDRECHECK_Includefilter"));
            Ddo_br_encounter_israndrecheck_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_ISRANDRECHECK_Includedatalist"));
            Ddo_br_encounter_israndrecheck_Sortasc = cgiGet( "DDO_BR_ENCOUNTER_ISRANDRECHECK_Sortasc");
            Ddo_br_encounter_israndrecheck_Sortdsc = cgiGet( "DDO_BR_ENCOUNTER_ISRANDRECHECK_Sortdsc");
            Ddo_br_encounter_israndrecheck_Searchbuttontext = cgiGet( "DDO_BR_ENCOUNTER_ISRANDRECHECK_Searchbuttontext");
            Ddo_br_encounter_isupdate_Caption = cgiGet( "DDO_BR_ENCOUNTER_ISUPDATE_Caption");
            Ddo_br_encounter_isupdate_Tooltip = cgiGet( "DDO_BR_ENCOUNTER_ISUPDATE_Tooltip");
            Ddo_br_encounter_isupdate_Cls = cgiGet( "DDO_BR_ENCOUNTER_ISUPDATE_Cls");
            Ddo_br_encounter_isupdate_Dropdownoptionstype = cgiGet( "DDO_BR_ENCOUNTER_ISUPDATE_Dropdownoptionstype");
            Ddo_br_encounter_isupdate_Titlecontrolidtoreplace = cgiGet( "DDO_BR_ENCOUNTER_ISUPDATE_Titlecontrolidtoreplace");
            Ddo_br_encounter_isupdate_Includesortasc = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_ISUPDATE_Includesortasc"));
            Ddo_br_encounter_isupdate_Includesortdsc = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_ISUPDATE_Includesortdsc"));
            Ddo_br_encounter_isupdate_Sortedstatus = cgiGet( "DDO_BR_ENCOUNTER_ISUPDATE_Sortedstatus");
            Ddo_br_encounter_isupdate_Includefilter = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_ISUPDATE_Includefilter"));
            Ddo_br_encounter_isupdate_Includedatalist = StringUtil.StrToBool( cgiGet( "DDO_BR_ENCOUNTER_ISUPDATE_Includedatalist"));
            Ddo_br_encounter_isupdate_Sortasc = cgiGet( "DDO_BR_ENCOUNTER_ISUPDATE_Sortasc");
            Ddo_br_encounter_isupdate_Sortdsc = cgiGet( "DDO_BR_ENCOUNTER_ISUPDATE_Sortdsc");
            Ddo_br_encounter_isupdate_Searchbuttontext = cgiGet( "DDO_BR_ENCOUNTER_ISUPDATE_Searchbuttontext");
            subGrid_Rows = (int)(context.localUtil.CToN( cgiGet( "GRID_Rows"), ".", ","));
            GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
            Gridpaginationbar_Selectedpage = cgiGet( "GRIDPAGINATIONBAR_Selectedpage");
            Gridpaginationbar_Rowsperpageselectedvalue = (int)(context.localUtil.CToN( cgiGet( "GRIDPAGINATIONBAR_Rowsperpageselectedvalue"), ".", ","));
            Ddo_br_encounterid_Activeeventkey = cgiGet( "DDO_BR_ENCOUNTERID_Activeeventkey");
            Ddo_br_encounterid_Filteredtext_get = cgiGet( "DDO_BR_ENCOUNTERID_Filteredtext_get");
            Ddo_br_encounterid_Filteredtextto_get = cgiGet( "DDO_BR_ENCOUNTERID_Filteredtextto_get");
            Ddo_br_encounter_department_Activeeventkey = cgiGet( "DDO_BR_ENCOUNTER_DEPARTMENT_Activeeventkey");
            Ddo_br_encounter_enctype_Activeeventkey = cgiGet( "DDO_BR_ENCOUNTER_ENCTYPE_Activeeventkey");
            Ddo_br_encounter_admitdate_Activeeventkey = cgiGet( "DDO_BR_ENCOUNTER_ADMITDATE_Activeeventkey");
            Ddo_br_encounter_status_Activeeventkey = cgiGet( "DDO_BR_ENCOUNTER_STATUS_Activeeventkey");
            Ddo_br_encounter_israndapprove_Activeeventkey = cgiGet( "DDO_BR_ENCOUNTER_ISRANDAPPROVE_Activeeventkey");
            Ddo_br_encounter_israndrecheck_Activeeventkey = cgiGet( "DDO_BR_ENCOUNTER_ISRANDRECHECK_Activeeventkey");
            Ddo_br_encounter_isupdate_Activeeventkey = cgiGet( "DDO_BR_ENCOUNTER_ISUPDATE_Activeeventkey");
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXKey = Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( ));
            /* Check if conditions changed and reset current page numbers */
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vBR_ENCOUNTER_STATUS"), ".", ",") != Convert.ToDecimal( AV15BR_Encounter_Status )) )
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
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_ENCOUNTERID"), ".", ",") != Convert.ToDecimal( AV18TFBR_EncounterID )) )
            {
               GRID_nFirstRecordOnPage = 0;
            }
            if ( ( context.localUtil.CToN( cgiGet( "GXH_vTFBR_ENCOUNTERID_TO"), ".", ",") != Convert.ToDecimal( AV19TFBR_EncounterID_To )) )
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
         E21A82 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E21A82( )
      {
         /* Start Routine */
         subGrid_Rows = 9;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         AV15BR_Encounter_Status = 0;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15BR_Encounter_Status", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15BR_Encounter_Status), 4, 0)));
         edtavTfbr_encounterid_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_encounterid_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_encounterid_Visible), 5, 0)), true);
         edtavTfbr_encounterid_to_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavTfbr_encounterid_to_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavTfbr_encounterid_to_Visible), 5, 0)), true);
         Ddo_br_encounterid_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_EncounterID";
         ucDdo_br_encounterid.SendProperty(context, "", false, Ddo_br_encounterid_Internalname, "TitleControlIdToReplace", Ddo_br_encounterid_Titlecontrolidtoreplace);
         AV20ddo_BR_EncounterIDTitleControlIdToReplace = Ddo_br_encounterid_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20ddo_BR_EncounterIDTitleControlIdToReplace", AV20ddo_BR_EncounterIDTitleControlIdToReplace);
         edtavDdo_br_encounteridtitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_encounteridtitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_encounteridtitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_encounter_department_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Encounter_Department";
         ucDdo_br_encounter_department.SendProperty(context, "", false, Ddo_br_encounter_department_Internalname, "TitleControlIdToReplace", Ddo_br_encounter_department_Titlecontrolidtoreplace);
         AV33ddo_BR_Encounter_DepartmentTitleControlIdToReplace = Ddo_br_encounter_department_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33ddo_BR_Encounter_DepartmentTitleControlIdToReplace", AV33ddo_BR_Encounter_DepartmentTitleControlIdToReplace);
         edtavDdo_br_encounter_departmenttitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_encounter_departmenttitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_encounter_departmenttitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_encounter_enctype_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Encounter_ENCType";
         ucDdo_br_encounter_enctype.SendProperty(context, "", false, Ddo_br_encounter_enctype_Internalname, "TitleControlIdToReplace", Ddo_br_encounter_enctype_Titlecontrolidtoreplace);
         AV35ddo_BR_Encounter_ENCTypeTitleControlIdToReplace = Ddo_br_encounter_enctype_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV35ddo_BR_Encounter_ENCTypeTitleControlIdToReplace", AV35ddo_BR_Encounter_ENCTypeTitleControlIdToReplace);
         edtavDdo_br_encounter_enctypetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_encounter_enctypetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_encounter_enctypetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_encounter_admitdate_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Encounter_AdmitDate";
         ucDdo_br_encounter_admitdate.SendProperty(context, "", false, Ddo_br_encounter_admitdate_Internalname, "TitleControlIdToReplace", Ddo_br_encounter_admitdate_Titlecontrolidtoreplace);
         AV37ddo_BR_Encounter_AdmitDateTitleControlIdToReplace = Ddo_br_encounter_admitdate_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV37ddo_BR_Encounter_AdmitDateTitleControlIdToReplace", AV37ddo_BR_Encounter_AdmitDateTitleControlIdToReplace);
         edtavDdo_br_encounter_admitdatetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_encounter_admitdatetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_encounter_admitdatetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_encounter_status_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Encounter_Status";
         ucDdo_br_encounter_status.SendProperty(context, "", false, Ddo_br_encounter_status_Internalname, "TitleControlIdToReplace", Ddo_br_encounter_status_Titlecontrolidtoreplace);
         AV24ddo_BR_Encounter_StatusTitleControlIdToReplace = Ddo_br_encounter_status_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24ddo_BR_Encounter_StatusTitleControlIdToReplace", AV24ddo_BR_Encounter_StatusTitleControlIdToReplace);
         edtavDdo_br_encounter_statustitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_encounter_statustitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_encounter_statustitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_encounter_israndapprove_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Encounter_IsRandApprove";
         ucDdo_br_encounter_israndapprove.SendProperty(context, "", false, Ddo_br_encounter_israndapprove_Internalname, "TitleControlIdToReplace", Ddo_br_encounter_israndapprove_Titlecontrolidtoreplace);
         AV39ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace = Ddo_br_encounter_israndapprove_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV39ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace", AV39ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace);
         edtavDdo_br_encounter_israndapprovetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_encounter_israndapprovetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_encounter_israndapprovetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_encounter_israndrecheck_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Encounter_IsRandRecheck";
         ucDdo_br_encounter_israndrecheck.SendProperty(context, "", false, Ddo_br_encounter_israndrecheck_Internalname, "TitleControlIdToReplace", Ddo_br_encounter_israndrecheck_Titlecontrolidtoreplace);
         AV41ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace = Ddo_br_encounter_israndrecheck_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV41ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace", AV41ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace);
         edtavDdo_br_encounter_israndrechecktitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_encounter_israndrechecktitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_encounter_israndrechecktitlecontrolidtoreplace_Visible), 5, 0)), true);
         Ddo_br_encounter_isupdate_Titlecontrolidtoreplace = subGrid_Internalname+"_BR_Encounter_IsUpdate";
         ucDdo_br_encounter_isupdate.SendProperty(context, "", false, Ddo_br_encounter_isupdate_Internalname, "TitleControlIdToReplace", Ddo_br_encounter_isupdate_Titlecontrolidtoreplace);
         AV43ddo_BR_Encounter_IsUpdateTitleControlIdToReplace = Ddo_br_encounter_isupdate_Titlecontrolidtoreplace;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV43ddo_BR_Encounter_IsUpdateTitleControlIdToReplace", AV43ddo_BR_Encounter_IsUpdateTitleControlIdToReplace);
         edtavDdo_br_encounter_isupdatetitlecontrolidtoreplace_Visible = 0;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavDdo_br_encounter_isupdatetitlecontrolidtoreplace_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavDdo_br_encounter_isupdatetitlecontrolidtoreplace_Visible), 5, 0)), true);
         Form.Caption = " 就诊信息";
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
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 = AV25DDO_TitleSettingsIcons;
         new GeneXus.Programs.wwpbaseobjects.getwwptitlesettingsicons(context ).execute( out  GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1) ;
         AV25DDO_TitleSettingsIcons = GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1;
         Gridpaginationbar_Rowsperpageselectedvalue = subGrid_Rows;
         ucGridpaginationbar.SendProperty(context, "", false, Gridpaginationbar_Internalname, "RowsPerPageSelectedValue", StringUtil.LTrim( StringUtil.Str( (decimal)(Gridpaginationbar_Rowsperpageselectedvalue), 9, 0)));
      }

      protected void E22A82( )
      {
         if ( gx_refresh_fired )
         {
            return  ;
         }
         gx_refresh_fired = true;
         /* Refresh Routine */
         AV17BR_EncounterIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV32BR_Encounter_DepartmentTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV34BR_Encounter_ENCTypeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV36BR_Encounter_AdmitDateTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV21BR_Encounter_StatusTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV38BR_Encounter_IsRandApproveTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV40BR_Encounter_IsRandRecheckTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV42BR_Encounter_IsUpdateTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         new GeneXus.Programs.wwpbaseobjects.loadwwpcontext(context ).execute( out  AV6WWPContext) ;
         /* Execute user subroutine: 'SAVEGRIDSTATE' */
         S142 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         edtBR_EncounterID_Titleformat = 2;
         edtBR_EncounterID_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "就诊序号", AV20ddo_BR_EncounterIDTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_EncounterID_Internalname, "Title", edtBR_EncounterID_Title, !bGXsfl_31_Refreshing);
         edtBR_Encounter_Department_Titleformat = 2;
         edtBR_Encounter_Department_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "就诊科室", AV33ddo_BR_Encounter_DepartmentTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Encounter_Department_Internalname, "Title", edtBR_Encounter_Department_Title, !bGXsfl_31_Refreshing);
         edtBR_Encounter_ENCType_Titleformat = 2;
         edtBR_Encounter_ENCType_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "就诊方式", AV35ddo_BR_Encounter_ENCTypeTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Encounter_ENCType_Internalname, "Title", edtBR_Encounter_ENCType_Title, !bGXsfl_31_Refreshing);
         edtBR_Encounter_AdmitDate_Titleformat = 2;
         edtBR_Encounter_AdmitDate_Title = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "就诊/入院时间", AV37ddo_BR_Encounter_AdmitDateTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtBR_Encounter_AdmitDate_Internalname, "Title", edtBR_Encounter_AdmitDate_Title, !bGXsfl_31_Refreshing);
         cmbBR_Encounter_Status_Titleformat = 2;
         cmbBR_Encounter_Status.Title.Text = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "审批状态", AV24ddo_BR_Encounter_StatusTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Encounter_Status_Internalname, "Title", cmbBR_Encounter_Status.Title.Text, !bGXsfl_31_Refreshing);
         chkBR_Encounter_IsRandApprove_Titleformat = 2;
         chkBR_Encounter_IsRandApprove.Title.Text = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "初审抽查", AV39ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkBR_Encounter_IsRandApprove_Internalname, "Title", chkBR_Encounter_IsRandApprove.Title.Text, !bGXsfl_31_Refreshing);
         chkBR_Encounter_IsRandRecheck_Titleformat = 2;
         chkBR_Encounter_IsRandRecheck.Title.Text = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "复审抽查", AV41ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkBR_Encounter_IsRandRecheck_Internalname, "Title", chkBR_Encounter_IsRandRecheck.Title.Text, !bGXsfl_31_Refreshing);
         chkBR_Encounter_IsUpdate_Titleformat = 2;
         chkBR_Encounter_IsUpdate.Title.Text = StringUtil.Format( "<div class='ColumnSettingsContainer''><span>%1</span><div id='%2'></div>", "是否修改", AV43ddo_BR_Encounter_IsUpdateTitleControlIdToReplace, "", "", "", "", "", "", "");
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkBR_Encounter_IsUpdate_Internalname, "Title", chkBR_Encounter_IsUpdate.Title.Text, !bGXsfl_31_Refreshing);
         AV27GridCurrentPage = subGrid_Currentpage( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27GridCurrentPage", StringUtil.LTrim( StringUtil.Str( (decimal)(AV27GridCurrentPage), 10, 0)));
         AV28GridPageSize = subGrid_Rows;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV28GridPageSize", StringUtil.LTrim( StringUtil.Str( (decimal)(AV28GridPageSize), 10, 0)));
         AV29GridRecordCount = subGrid_Recordcount( );
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29GridRecordCount", StringUtil.LTrim( StringUtil.Str( (decimal)(AV29GridRecordCount), 10, 0)));
         AV46WebPanel3DS_1_Br_encounter_status = AV15BR_Encounter_Status;
         AV47WebPanel3DS_2_Tfbr_encounterid = AV18TFBR_EncounterID;
         AV48WebPanel3DS_3_Tfbr_encounterid_to = AV19TFBR_EncounterID_To;
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_EncounterIDTitleFilterData", AV17BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Encounter_DepartmentTitleFilterData", AV32BR_Encounter_DepartmentTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34BR_Encounter_ENCTypeTitleFilterData", AV34BR_Encounter_ENCTypeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36BR_Encounter_AdmitDateTitleFilterData", AV36BR_Encounter_AdmitDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21BR_Encounter_StatusTitleFilterData", AV21BR_Encounter_StatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_Encounter_IsRandApproveTitleFilterData", AV38BR_Encounter_IsRandApproveTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40BR_Encounter_IsRandRecheckTitleFilterData", AV40BR_Encounter_IsRandRecheckTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42BR_Encounter_IsUpdateTitleFilterData", AV42BR_Encounter_IsUpdateTitleFilterData);
      }

      protected void E11A82( )
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
            AV26PageToGo = (int)(NumberUtil.Val( Gridpaginationbar_Selectedpage, "."));
            subgrid_gotopage( AV26PageToGo) ;
         }
      }

      protected void E12A82( )
      {
         /* Gridpaginationbar_Changerowsperpage Routine */
         subGrid_Rows = Gridpaginationbar_Rowsperpageselectedvalue;
         GxWebStd.gx_hidden_field( context, "GRID_Rows", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid_Rows), 6, 0, ".", "")));
         subgrid_firstpage( ) ;
         /*  Sending Event outputs  */
      }

      protected void E13A82( )
      {
         /* Ddo_br_encounterid_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_encounterid_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_br_encounterid_Sortedstatus = "ASC";
            ucDdo_br_encounterid.SendProperty(context, "", false, Ddo_br_encounterid_Internalname, "SortedStatus", Ddo_br_encounterid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_encounterid_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_br_encounterid_Sortedstatus = "DSC";
            ucDdo_br_encounterid.SendProperty(context, "", false, Ddo_br_encounterid_Internalname, "SortedStatus", Ddo_br_encounterid_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_encounterid_Activeeventkey, "<#Filter#>") == 0 )
         {
            AV18TFBR_EncounterID = (long)(NumberUtil.Val( Ddo_br_encounterid_Filteredtext_get, "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18TFBR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18TFBR_EncounterID), 18, 0)));
            AV19TFBR_EncounterID_To = (long)(NumberUtil.Val( Ddo_br_encounterid_Filteredtextto_get, "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19TFBR_EncounterID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV19TFBR_EncounterID_To), 18, 0)));
            subgrid_firstpage( ) ;
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_EncounterIDTitleFilterData", AV17BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Encounter_DepartmentTitleFilterData", AV32BR_Encounter_DepartmentTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34BR_Encounter_ENCTypeTitleFilterData", AV34BR_Encounter_ENCTypeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36BR_Encounter_AdmitDateTitleFilterData", AV36BR_Encounter_AdmitDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21BR_Encounter_StatusTitleFilterData", AV21BR_Encounter_StatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_Encounter_IsRandApproveTitleFilterData", AV38BR_Encounter_IsRandApproveTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40BR_Encounter_IsRandRecheckTitleFilterData", AV40BR_Encounter_IsRandRecheckTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42BR_Encounter_IsUpdateTitleFilterData", AV42BR_Encounter_IsUpdateTitleFilterData);
      }

      protected void E14A82( )
      {
         /* Ddo_br_encounter_department_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_encounter_department_Activeeventkey, "<#OrderASC#>") == 0 )
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
            Ddo_br_encounter_department_Sortedstatus = "ASC";
            ucDdo_br_encounter_department.SendProperty(context, "", false, Ddo_br_encounter_department_Internalname, "SortedStatus", Ddo_br_encounter_department_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_encounter_department_Activeeventkey, "<#OrderDSC#>") == 0 )
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
            Ddo_br_encounter_department_Sortedstatus = "DSC";
            ucDdo_br_encounter_department.SendProperty(context, "", false, Ddo_br_encounter_department_Internalname, "SortedStatus", Ddo_br_encounter_department_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_EncounterIDTitleFilterData", AV17BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Encounter_DepartmentTitleFilterData", AV32BR_Encounter_DepartmentTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34BR_Encounter_ENCTypeTitleFilterData", AV34BR_Encounter_ENCTypeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36BR_Encounter_AdmitDateTitleFilterData", AV36BR_Encounter_AdmitDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21BR_Encounter_StatusTitleFilterData", AV21BR_Encounter_StatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_Encounter_IsRandApproveTitleFilterData", AV38BR_Encounter_IsRandApproveTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40BR_Encounter_IsRandRecheckTitleFilterData", AV40BR_Encounter_IsRandRecheckTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42BR_Encounter_IsUpdateTitleFilterData", AV42BR_Encounter_IsUpdateTitleFilterData);
      }

      protected void E15A82( )
      {
         /* Ddo_br_encounter_enctype_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_encounter_enctype_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S152 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 3;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_encounter_enctype_Sortedstatus = "ASC";
            ucDdo_br_encounter_enctype.SendProperty(context, "", false, Ddo_br_encounter_enctype_Internalname, "SortedStatus", Ddo_br_encounter_enctype_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_encounter_enctype_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S152 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 3;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_encounter_enctype_Sortedstatus = "DSC";
            ucDdo_br_encounter_enctype.SendProperty(context, "", false, Ddo_br_encounter_enctype_Internalname, "SortedStatus", Ddo_br_encounter_enctype_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_EncounterIDTitleFilterData", AV17BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Encounter_DepartmentTitleFilterData", AV32BR_Encounter_DepartmentTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34BR_Encounter_ENCTypeTitleFilterData", AV34BR_Encounter_ENCTypeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36BR_Encounter_AdmitDateTitleFilterData", AV36BR_Encounter_AdmitDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21BR_Encounter_StatusTitleFilterData", AV21BR_Encounter_StatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_Encounter_IsRandApproveTitleFilterData", AV38BR_Encounter_IsRandApproveTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40BR_Encounter_IsRandRecheckTitleFilterData", AV40BR_Encounter_IsRandRecheckTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42BR_Encounter_IsUpdateTitleFilterData", AV42BR_Encounter_IsUpdateTitleFilterData);
      }

      protected void E16A82( )
      {
         /* Ddo_br_encounter_admitdate_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_encounter_admitdate_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S152 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 4;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_encounter_admitdate_Sortedstatus = "ASC";
            ucDdo_br_encounter_admitdate.SendProperty(context, "", false, Ddo_br_encounter_admitdate_Internalname, "SortedStatus", Ddo_br_encounter_admitdate_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_encounter_admitdate_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S152 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 4;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_encounter_admitdate_Sortedstatus = "DSC";
            ucDdo_br_encounter_admitdate.SendProperty(context, "", false, Ddo_br_encounter_admitdate_Internalname, "SortedStatus", Ddo_br_encounter_admitdate_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_EncounterIDTitleFilterData", AV17BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Encounter_DepartmentTitleFilterData", AV32BR_Encounter_DepartmentTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34BR_Encounter_ENCTypeTitleFilterData", AV34BR_Encounter_ENCTypeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36BR_Encounter_AdmitDateTitleFilterData", AV36BR_Encounter_AdmitDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21BR_Encounter_StatusTitleFilterData", AV21BR_Encounter_StatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_Encounter_IsRandApproveTitleFilterData", AV38BR_Encounter_IsRandApproveTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40BR_Encounter_IsRandRecheckTitleFilterData", AV40BR_Encounter_IsRandRecheckTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42BR_Encounter_IsUpdateTitleFilterData", AV42BR_Encounter_IsUpdateTitleFilterData);
      }

      protected void E17A82( )
      {
         /* Ddo_br_encounter_status_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_encounter_status_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S152 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 5;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_encounter_status_Sortedstatus = "ASC";
            ucDdo_br_encounter_status.SendProperty(context, "", false, Ddo_br_encounter_status_Internalname, "SortedStatus", Ddo_br_encounter_status_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_encounter_status_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S152 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 5;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_encounter_status_Sortedstatus = "DSC";
            ucDdo_br_encounter_status.SendProperty(context, "", false, Ddo_br_encounter_status_Internalname, "SortedStatus", Ddo_br_encounter_status_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_EncounterIDTitleFilterData", AV17BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Encounter_DepartmentTitleFilterData", AV32BR_Encounter_DepartmentTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34BR_Encounter_ENCTypeTitleFilterData", AV34BR_Encounter_ENCTypeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36BR_Encounter_AdmitDateTitleFilterData", AV36BR_Encounter_AdmitDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21BR_Encounter_StatusTitleFilterData", AV21BR_Encounter_StatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_Encounter_IsRandApproveTitleFilterData", AV38BR_Encounter_IsRandApproveTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40BR_Encounter_IsRandRecheckTitleFilterData", AV40BR_Encounter_IsRandRecheckTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42BR_Encounter_IsUpdateTitleFilterData", AV42BR_Encounter_IsUpdateTitleFilterData);
      }

      protected void E18A82( )
      {
         /* Ddo_br_encounter_israndapprove_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_encounter_israndapprove_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S152 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 6;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_encounter_israndapprove_Sortedstatus = "ASC";
            ucDdo_br_encounter_israndapprove.SendProperty(context, "", false, Ddo_br_encounter_israndapprove_Internalname, "SortedStatus", Ddo_br_encounter_israndapprove_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_encounter_israndapprove_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S152 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 6;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_encounter_israndapprove_Sortedstatus = "DSC";
            ucDdo_br_encounter_israndapprove.SendProperty(context, "", false, Ddo_br_encounter_israndapprove_Internalname, "SortedStatus", Ddo_br_encounter_israndapprove_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_EncounterIDTitleFilterData", AV17BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Encounter_DepartmentTitleFilterData", AV32BR_Encounter_DepartmentTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34BR_Encounter_ENCTypeTitleFilterData", AV34BR_Encounter_ENCTypeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36BR_Encounter_AdmitDateTitleFilterData", AV36BR_Encounter_AdmitDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21BR_Encounter_StatusTitleFilterData", AV21BR_Encounter_StatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_Encounter_IsRandApproveTitleFilterData", AV38BR_Encounter_IsRandApproveTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40BR_Encounter_IsRandRecheckTitleFilterData", AV40BR_Encounter_IsRandRecheckTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42BR_Encounter_IsUpdateTitleFilterData", AV42BR_Encounter_IsUpdateTitleFilterData);
      }

      protected void E19A82( )
      {
         /* Ddo_br_encounter_israndrecheck_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_encounter_israndrecheck_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S152 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 7;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_encounter_israndrecheck_Sortedstatus = "ASC";
            ucDdo_br_encounter_israndrecheck.SendProperty(context, "", false, Ddo_br_encounter_israndrecheck_Internalname, "SortedStatus", Ddo_br_encounter_israndrecheck_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_encounter_israndrecheck_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S152 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 7;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_encounter_israndrecheck_Sortedstatus = "DSC";
            ucDdo_br_encounter_israndrecheck.SendProperty(context, "", false, Ddo_br_encounter_israndrecheck_Internalname, "SortedStatus", Ddo_br_encounter_israndrecheck_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_EncounterIDTitleFilterData", AV17BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Encounter_DepartmentTitleFilterData", AV32BR_Encounter_DepartmentTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34BR_Encounter_ENCTypeTitleFilterData", AV34BR_Encounter_ENCTypeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36BR_Encounter_AdmitDateTitleFilterData", AV36BR_Encounter_AdmitDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21BR_Encounter_StatusTitleFilterData", AV21BR_Encounter_StatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_Encounter_IsRandApproveTitleFilterData", AV38BR_Encounter_IsRandApproveTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40BR_Encounter_IsRandRecheckTitleFilterData", AV40BR_Encounter_IsRandRecheckTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42BR_Encounter_IsUpdateTitleFilterData", AV42BR_Encounter_IsUpdateTitleFilterData);
      }

      protected void E20A82( )
      {
         /* Ddo_br_encounter_isupdate_Onoptionclicked Routine */
         if ( StringUtil.StrCmp(Ddo_br_encounter_isupdate_Activeeventkey, "<#OrderASC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S152 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 8;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = false;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_encounter_isupdate_Sortedstatus = "ASC";
            ucDdo_br_encounter_isupdate.SendProperty(context, "", false, Ddo_br_encounter_isupdate_Internalname, "SortedStatus", Ddo_br_encounter_isupdate_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         else if ( StringUtil.StrCmp(Ddo_br_encounter_isupdate_Activeeventkey, "<#OrderDSC#>") == 0 )
         {
            /* Execute user subroutine: 'RESETDDOSORTEDSTATUS' */
            S152 ();
            if ( returnInSub )
            {
               returnInSub = true;
               if (true) return;
            }
            AV13OrderedBy = 8;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13OrderedBy", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13OrderedBy), 4, 0)));
            AV14OrderedDsc = true;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14OrderedDsc", AV14OrderedDsc);
            Ddo_br_encounter_isupdate_Sortedstatus = "DSC";
            ucDdo_br_encounter_isupdate.SendProperty(context, "", false, Ddo_br_encounter_isupdate_Internalname, "SortedStatus", Ddo_br_encounter_isupdate_Sortedstatus);
            subgrid_firstpage( ) ;
            context.DoAjaxRefresh();
         }
         /*  Sending Event outputs  */
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV17BR_EncounterIDTitleFilterData", AV17BR_EncounterIDTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV32BR_Encounter_DepartmentTitleFilterData", AV32BR_Encounter_DepartmentTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV34BR_Encounter_ENCTypeTitleFilterData", AV34BR_Encounter_ENCTypeTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV36BR_Encounter_AdmitDateTitleFilterData", AV36BR_Encounter_AdmitDateTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV21BR_Encounter_StatusTitleFilterData", AV21BR_Encounter_StatusTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV38BR_Encounter_IsRandApproveTitleFilterData", AV38BR_Encounter_IsRandApproveTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV40BR_Encounter_IsRandRecheckTitleFilterData", AV40BR_Encounter_IsRandRecheckTitleFilterData);
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV42BR_Encounter_IsUpdateTitleFilterData", AV42BR_Encounter_IsUpdateTitleFilterData);
      }

      private void E23A82( )
      {
         /* Grid_Load Routine */
         /* Load Method */
         if ( wbStart != -1 )
         {
            wbStart = 31;
         }
         sendrow_312( ) ;
         GRID_nCurrentRecord = (long)(GRID_nCurrentRecord+1);
         if ( isFullAjaxMode( ) && ! bGXsfl_31_Refreshing )
         {
            context.DoAjaxLoad(31, GridRow);
         }
      }

      protected void S152( )
      {
         /* 'RESETDDOSORTEDSTATUS' Routine */
         Ddo_br_encounterid_Sortedstatus = "";
         ucDdo_br_encounterid.SendProperty(context, "", false, Ddo_br_encounterid_Internalname, "SortedStatus", Ddo_br_encounterid_Sortedstatus);
         Ddo_br_encounter_department_Sortedstatus = "";
         ucDdo_br_encounter_department.SendProperty(context, "", false, Ddo_br_encounter_department_Internalname, "SortedStatus", Ddo_br_encounter_department_Sortedstatus);
         Ddo_br_encounter_enctype_Sortedstatus = "";
         ucDdo_br_encounter_enctype.SendProperty(context, "", false, Ddo_br_encounter_enctype_Internalname, "SortedStatus", Ddo_br_encounter_enctype_Sortedstatus);
         Ddo_br_encounter_admitdate_Sortedstatus = "";
         ucDdo_br_encounter_admitdate.SendProperty(context, "", false, Ddo_br_encounter_admitdate_Internalname, "SortedStatus", Ddo_br_encounter_admitdate_Sortedstatus);
         Ddo_br_encounter_status_Sortedstatus = "";
         ucDdo_br_encounter_status.SendProperty(context, "", false, Ddo_br_encounter_status_Internalname, "SortedStatus", Ddo_br_encounter_status_Sortedstatus);
         Ddo_br_encounter_israndapprove_Sortedstatus = "";
         ucDdo_br_encounter_israndapprove.SendProperty(context, "", false, Ddo_br_encounter_israndapprove_Internalname, "SortedStatus", Ddo_br_encounter_israndapprove_Sortedstatus);
         Ddo_br_encounter_israndrecheck_Sortedstatus = "";
         ucDdo_br_encounter_israndrecheck.SendProperty(context, "", false, Ddo_br_encounter_israndrecheck_Internalname, "SortedStatus", Ddo_br_encounter_israndrecheck_Sortedstatus);
         Ddo_br_encounter_isupdate_Sortedstatus = "";
         ucDdo_br_encounter_isupdate.SendProperty(context, "", false, Ddo_br_encounter_isupdate_Internalname, "SortedStatus", Ddo_br_encounter_isupdate_Sortedstatus);
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
            Ddo_br_encounterid_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_encounterid.SendProperty(context, "", false, Ddo_br_encounterid_Internalname, "SortedStatus", Ddo_br_encounterid_Sortedstatus);
         }
         else if ( AV13OrderedBy == 2 )
         {
            Ddo_br_encounter_department_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_encounter_department.SendProperty(context, "", false, Ddo_br_encounter_department_Internalname, "SortedStatus", Ddo_br_encounter_department_Sortedstatus);
         }
         else if ( AV13OrderedBy == 3 )
         {
            Ddo_br_encounter_enctype_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_encounter_enctype.SendProperty(context, "", false, Ddo_br_encounter_enctype_Internalname, "SortedStatus", Ddo_br_encounter_enctype_Sortedstatus);
         }
         else if ( AV13OrderedBy == 4 )
         {
            Ddo_br_encounter_admitdate_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_encounter_admitdate.SendProperty(context, "", false, Ddo_br_encounter_admitdate_Internalname, "SortedStatus", Ddo_br_encounter_admitdate_Sortedstatus);
         }
         else if ( AV13OrderedBy == 5 )
         {
            Ddo_br_encounter_status_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_encounter_status.SendProperty(context, "", false, Ddo_br_encounter_status_Internalname, "SortedStatus", Ddo_br_encounter_status_Sortedstatus);
         }
         else if ( AV13OrderedBy == 6 )
         {
            Ddo_br_encounter_israndapprove_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_encounter_israndapprove.SendProperty(context, "", false, Ddo_br_encounter_israndapprove_Internalname, "SortedStatus", Ddo_br_encounter_israndapprove_Sortedstatus);
         }
         else if ( AV13OrderedBy == 7 )
         {
            Ddo_br_encounter_israndrecheck_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_encounter_israndrecheck.SendProperty(context, "", false, Ddo_br_encounter_israndrecheck_Internalname, "SortedStatus", Ddo_br_encounter_israndrecheck_Sortedstatus);
         }
         else if ( AV13OrderedBy == 8 )
         {
            Ddo_br_encounter_isupdate_Sortedstatus = (AV14OrderedDsc ? "DSC" : "ASC");
            ucDdo_br_encounter_isupdate.SendProperty(context, "", false, Ddo_br_encounter_isupdate_Internalname, "SortedStatus", Ddo_br_encounter_isupdate_Sortedstatus);
         }
      }

      protected void S122( )
      {
         /* 'LOADGRIDSTATE' Routine */
         if ( StringUtil.StrCmp(AV16Session.Get(AV49Pgmname+"GridState"), "") == 0 )
         {
            AV11GridState.FromXml(new GeneXus.Programs.wwpbaseobjects.loadgridstate(context).executeUdp(  AV49Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         }
         else
         {
            AV11GridState.FromXml(AV16Session.Get(AV49Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
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
         AV50GXV1 = 1;
         while ( AV50GXV1 <= AV11GridState.gxTpr_Filtervalues.Count )
         {
            AV12GridStateFilterValue = ((GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue)AV11GridState.gxTpr_Filtervalues.Item(AV50GXV1));
            if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "BR_ENCOUNTER_STATUS") == 0 )
            {
               AV15BR_Encounter_Status = (short)(NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Value, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15BR_Encounter_Status", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15BR_Encounter_Status), 4, 0)));
            }
            else if ( StringUtil.StrCmp(AV12GridStateFilterValue.gxTpr_Name, "TFBR_ENCOUNTERID") == 0 )
            {
               AV18TFBR_EncounterID = (long)(NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Value, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18TFBR_EncounterID", StringUtil.LTrim( StringUtil.Str( (decimal)(AV18TFBR_EncounterID), 18, 0)));
               AV19TFBR_EncounterID_To = (long)(NumberUtil.Val( AV12GridStateFilterValue.gxTpr_Valueto, "."));
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19TFBR_EncounterID_To", StringUtil.LTrim( StringUtil.Str( (decimal)(AV19TFBR_EncounterID_To), 18, 0)));
               if ( ! (0==AV18TFBR_EncounterID) )
               {
                  Ddo_br_encounterid_Filteredtext_set = StringUtil.Str( (decimal)(AV18TFBR_EncounterID), 18, 0);
                  ucDdo_br_encounterid.SendProperty(context, "", false, Ddo_br_encounterid_Internalname, "FilteredText_set", Ddo_br_encounterid_Filteredtext_set);
               }
               if ( ! (0==AV19TFBR_EncounterID_To) )
               {
                  Ddo_br_encounterid_Filteredtextto_set = StringUtil.Str( (decimal)(AV19TFBR_EncounterID_To), 18, 0);
                  ucDdo_br_encounterid.SendProperty(context, "", false, Ddo_br_encounterid_Internalname, "FilteredTextTo_set", Ddo_br_encounterid_Filteredtextto_set);
               }
            }
            AV50GXV1 = (int)(AV50GXV1+1);
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
         AV11GridState.FromXml(AV16Session.Get(AV49Pgmname+"GridState"), null, "WWPGridState", "DataAnalysisPlatform");
         AV11GridState.gxTpr_Orderedby = AV13OrderedBy;
         AV11GridState.gxTpr_Ordereddsc = AV14OrderedDsc;
         AV11GridState.gxTpr_Filtervalues.Clear();
         if ( ! (0==AV15BR_Encounter_Status) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "BR_ENCOUNTER_STATUS";
            AV12GridStateFilterValue.gxTpr_Value = StringUtil.Str( (decimal)(AV15BR_Encounter_Status), 4, 0);
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         if ( ! ( (0==AV18TFBR_EncounterID) && (0==AV19TFBR_EncounterID_To) ) )
         {
            AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
            AV12GridStateFilterValue.gxTpr_Name = "TFBR_ENCOUNTERID";
            AV12GridStateFilterValue.gxTpr_Value = StringUtil.Str( (decimal)(AV18TFBR_EncounterID), 18, 0);
            AV12GridStateFilterValue.gxTpr_Valueto = StringUtil.Str( (decimal)(AV19TFBR_EncounterID_To), 18, 0);
            AV11GridState.gxTpr_Filtervalues.Add(AV12GridStateFilterValue, 0);
         }
         AV11GridState.gxTpr_Pagesize = StringUtil.Str( (decimal)(subGrid_Rows), 10, 0);
         AV11GridState.gxTpr_Currentpage = (short)(subGrid_Currentpage( ));
         new GeneXus.Programs.wwpbaseobjects.savegridstate(context ).execute(  AV49Pgmname+"GridState",  AV11GridState.ToXml(false, true, "WWPGridState", "DataAnalysisPlatform")) ;
      }

      protected void S112( )
      {
         /* 'PREPARETRANSACTION' Routine */
         AV9TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV9TrnContext.gxTpr_Callerobject = AV49Pgmname;
         AV9TrnContext.gxTpr_Callerondelete = true;
         AV9TrnContext.gxTpr_Callerurl = AV8HTTPRequest.ScriptName+"?"+AV8HTTPRequest.QueryString;
         AV9TrnContext.gxTpr_Transactionname = "BR_Encounter";
         AV16Session.Set("TrnContext", AV9TrnContext.ToXml(false, true, "WWPTransactionContext", "DataAnalysisPlatform"));
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
         PAA82( ) ;
         WSA82( ) ;
         WEA82( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( ((String)Form.Jscriptsrc.Item(idxLst))), "?20202279482069", true);
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
         context.AddJavascriptSource("webpanel3.js", "?20202279482069", false);
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
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/Shared/DVelopBootstrap.js", "", false);
         context.AddJavascriptSource("DVelop/Bootstrap/DropDownOptions/BootstrapDropDownOptionsRender.js", "", false);
         context.AddJavascriptSource("DVelop/WorkWithPlusUtilities/WorkWithPlusUtilitiesRender.js", "", false);
         /* End function include_jscripts */
      }

      protected void SubsflControlProps_312( )
      {
         edtBR_EncounterID_Internalname = "BR_ENCOUNTERID_"+sGXsfl_31_idx;
         edtBR_Encounter_Department_Internalname = "BR_ENCOUNTER_DEPARTMENT_"+sGXsfl_31_idx;
         edtBR_Encounter_ENCType_Internalname = "BR_ENCOUNTER_ENCTYPE_"+sGXsfl_31_idx;
         edtBR_Encounter_AdmitDate_Internalname = "BR_ENCOUNTER_ADMITDATE_"+sGXsfl_31_idx;
         cmbBR_Encounter_Status_Internalname = "BR_ENCOUNTER_STATUS_"+sGXsfl_31_idx;
         chkBR_Encounter_IsRandApprove_Internalname = "BR_ENCOUNTER_ISRANDAPPROVE_"+sGXsfl_31_idx;
         chkBR_Encounter_IsRandRecheck_Internalname = "BR_ENCOUNTER_ISRANDRECHECK_"+sGXsfl_31_idx;
         chkBR_Encounter_IsUpdate_Internalname = "BR_ENCOUNTER_ISUPDATE_"+sGXsfl_31_idx;
      }

      protected void SubsflControlProps_fel_312( )
      {
         edtBR_EncounterID_Internalname = "BR_ENCOUNTERID_"+sGXsfl_31_fel_idx;
         edtBR_Encounter_Department_Internalname = "BR_ENCOUNTER_DEPARTMENT_"+sGXsfl_31_fel_idx;
         edtBR_Encounter_ENCType_Internalname = "BR_ENCOUNTER_ENCTYPE_"+sGXsfl_31_fel_idx;
         edtBR_Encounter_AdmitDate_Internalname = "BR_ENCOUNTER_ADMITDATE_"+sGXsfl_31_fel_idx;
         cmbBR_Encounter_Status_Internalname = "BR_ENCOUNTER_STATUS_"+sGXsfl_31_fel_idx;
         chkBR_Encounter_IsRandApprove_Internalname = "BR_ENCOUNTER_ISRANDAPPROVE_"+sGXsfl_31_fel_idx;
         chkBR_Encounter_IsRandRecheck_Internalname = "BR_ENCOUNTER_ISRANDRECHECK_"+sGXsfl_31_fel_idx;
         chkBR_Encounter_IsUpdate_Internalname = "BR_ENCOUNTER_ISUPDATE_"+sGXsfl_31_fel_idx;
      }

      protected void sendrow_312( )
      {
         SubsflControlProps_312( ) ;
         WBA80( ) ;
         if ( ( subGrid_Rows * 1 == 0 ) || ( nGXsfl_31_idx <= subGrid_Recordsperpage( ) * 1 ) )
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
               if ( ((int)(((nGXsfl_31_idx-1)/ (decimal)(1)) % (2))) == 0 )
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
               context.WriteHtmlText( " gxrow=\""+sGXsfl_31_idx+"\">") ;
            }
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_EncounterID_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A19BR_EncounterID), 18, 0, ".", "")),context.localUtil.Format( (decimal)(A19BR_EncounterID), "ZZZZZZZZZZZZZZZZZZ"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_EncounterID_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn",(String)"",(short)-1,(short)0,(short)0,(String)"number",(String)"1",(short)0,(String)"px",(short)17,(String)"px",(short)18,(short)0,(short)0,(short)31,(short)1,(short)-1,(short)0,(bool)true,(String)"ID",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Encounter_Department_Internalname,(String)A84BR_Encounter_Department,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Encounter_Department_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)31,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Encounter_ENCType_Internalname,(String)A90BR_Encounter_ENCType,(String)"",(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Encounter_ENCType_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)31,(short)1,(short)-1,(short)-1,(bool)true,(String)"",(String)"left",(bool)true});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            /* Single line edit */
            ROClassString = "Attribute";
            GridRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBR_Encounter_AdmitDate_Internalname,context.localUtil.Format(A91BR_Encounter_AdmitDate, "9999/99/99"),context.localUtil.Format( A91BR_Encounter_AdmitDate, "9999/99/99"),(String)"",(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"",(String)"",(String)"",(String)"",(String)edtBR_Encounter_AdmitDate_Jsonclick,(short)0,(String)"Attribute",(String)"",(String)ROClassString,(String)"WWColumn hidden-xs",(String)"",(short)-1,(short)0,(short)0,(String)"text",(String)"",(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)31,(short)1,(short)-1,(short)0,(bool)true,(String)"DM_Date",(String)"right",(bool)false});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+""+"\">") ;
            }
            if ( ( cmbBR_Encounter_Status.ItemCount == 0 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "BR_ENCOUNTER_STATUS_" + sGXsfl_31_idx;
               cmbBR_Encounter_Status.Name = GXCCtl;
               cmbBR_Encounter_Status.WebTags = "";
               cmbBR_Encounter_Status.addItem(StringUtil.Trim( StringUtil.Str( (decimal)(0), 4, 0)), "(请选择)", 0);
               cmbBR_Encounter_Status.addItem("1", "录入中", 0);
               cmbBR_Encounter_Status.addItem("2", "待初审", 0);
               cmbBR_Encounter_Status.addItem("3", "初审不通过", 0);
               cmbBR_Encounter_Status.addItem("4", "待复审", 0);
               cmbBR_Encounter_Status.addItem("5", "复审不通过", 0);
               cmbBR_Encounter_Status.addItem("6", "完成", 0);
               if ( cmbBR_Encounter_Status.ItemCount > 0 )
               {
                  A172BR_Encounter_Status = (short)(NumberUtil.Val( cmbBR_Encounter_Status.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A172BR_Encounter_Status), 4, 0))), "."));
                  n172BR_Encounter_Status = false;
               }
            }
            /* ComboBox */
            GridRow.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbBR_Encounter_Status,(String)cmbBR_Encounter_Status_Internalname,StringUtil.Trim( StringUtil.Str( (decimal)(A172BR_Encounter_Status), 4, 0)),(short)1,(String)cmbBR_Encounter_Status_Jsonclick,(short)0,(String)"'"+""+"'"+",false,"+"'"+""+"'",(String)"int",(String)"",(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)"",(String)"Attribute",(String)"WWColumn hidden-xs",(String)"",(String)"",(String)"",(bool)true});
            cmbBR_Encounter_Status.CurrentValue = StringUtil.Trim( StringUtil.Str( (decimal)(A172BR_Encounter_Status), 4, 0));
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbBR_Encounter_Status_Internalname, "Values", (String)(cmbBR_Encounter_Status.ToJavascriptSource()), !bGXsfl_31_Refreshing);
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Check box */
            ClassString = "AttributeCheckBox";
            StyleString = "";
            GridRow.AddColumnProperties("checkbox", 1, isAjaxCallMode( ), new Object[] {(String)chkBR_Encounter_IsRandApprove_Internalname,StringUtil.BoolToStr( A192BR_Encounter_IsRandApprove),(String)"",(String)"",(short)-1,(short)0,(String)"true",(String)"",(String)StyleString,(String)ClassString,(String)"WWColumn hidden-xs",(String)"",(String)""});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Check box */
            ClassString = "AttributeCheckBox";
            StyleString = "";
            GridRow.AddColumnProperties("checkbox", 1, isAjaxCallMode( ), new Object[] {(String)chkBR_Encounter_IsRandRecheck_Internalname,StringUtil.BoolToStr( A193BR_Encounter_IsRandRecheck),(String)"",(String)"",(short)-1,(short)0,(String)"true",(String)"",(String)StyleString,(String)ClassString,(String)"WWColumn",(String)"",(String)""});
            /* Subfile cell */
            if ( GridContainer.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+""+"\">") ;
            }
            /* Check box */
            ClassString = "AttributeCheckBox";
            StyleString = "";
            GridRow.AddColumnProperties("checkbox", 1, isAjaxCallMode( ), new Object[] {(String)chkBR_Encounter_IsUpdate_Internalname,StringUtil.BoolToStr( A202BR_Encounter_IsUpdate),(String)"",(String)"",(short)-1,(short)0,(String)"true",(String)"",(String)StyleString,(String)ClassString,(String)"WWColumn",(String)"",(String)""});
            send_integrity_lvl_hashesA82( ) ;
            GridContainer.AddRow(GridRow);
            nGXsfl_31_idx = (short)(((subGrid_Islastpage==1)&&(nGXsfl_31_idx+1>subGrid_Recordsperpage( )) ? 1 : nGXsfl_31_idx+1));
            sGXsfl_31_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_31_idx), 4, 0)), 4, "0");
            SubsflControlProps_312( ) ;
         }
         /* End function sendrow_312 */
      }

      protected void init_web_controls( )
      {
         cmbavBr_encounter_status.Name = "vBR_ENCOUNTER_STATUS";
         cmbavBr_encounter_status.WebTags = "";
         cmbavBr_encounter_status.addItem(StringUtil.Trim( StringUtil.Str( (decimal)(0), 4, 0)), "全部", 0);
         cmbavBr_encounter_status.addItem("1", "录入中", 0);
         cmbavBr_encounter_status.addItem("2", "待初审", 0);
         cmbavBr_encounter_status.addItem("3", "初审不通过", 0);
         cmbavBr_encounter_status.addItem("4", "待复审", 0);
         cmbavBr_encounter_status.addItem("5", "复审不通过", 0);
         cmbavBr_encounter_status.addItem("6", "完成", 0);
         if ( cmbavBr_encounter_status.ItemCount > 0 )
         {
            AV15BR_Encounter_Status = (short)(NumberUtil.Val( cmbavBr_encounter_status.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(AV15BR_Encounter_Status), 4, 0))), "."));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15BR_Encounter_Status", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15BR_Encounter_Status), 4, 0)));
         }
         GXCCtl = "BR_ENCOUNTER_STATUS_" + sGXsfl_31_idx;
         cmbBR_Encounter_Status.Name = GXCCtl;
         cmbBR_Encounter_Status.WebTags = "";
         cmbBR_Encounter_Status.addItem(StringUtil.Trim( StringUtil.Str( (decimal)(0), 4, 0)), "(请选择)", 0);
         cmbBR_Encounter_Status.addItem("1", "录入中", 0);
         cmbBR_Encounter_Status.addItem("2", "待初审", 0);
         cmbBR_Encounter_Status.addItem("3", "初审不通过", 0);
         cmbBR_Encounter_Status.addItem("4", "待复审", 0);
         cmbBR_Encounter_Status.addItem("5", "复审不通过", 0);
         cmbBR_Encounter_Status.addItem("6", "完成", 0);
         if ( cmbBR_Encounter_Status.ItemCount > 0 )
         {
            A172BR_Encounter_Status = (short)(NumberUtil.Val( cmbBR_Encounter_Status.getValidValue(StringUtil.Trim( StringUtil.Str( (decimal)(A172BR_Encounter_Status), 4, 0))), "."));
            n172BR_Encounter_Status = false;
         }
         GXCCtl = "BR_ENCOUNTER_ISRANDAPPROVE_" + sGXsfl_31_idx;
         chkBR_Encounter_IsRandApprove.Name = GXCCtl;
         chkBR_Encounter_IsRandApprove.WebTags = "";
         chkBR_Encounter_IsRandApprove.Caption = "";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkBR_Encounter_IsRandApprove_Internalname, "TitleCaption", chkBR_Encounter_IsRandApprove.Caption, !bGXsfl_31_Refreshing);
         chkBR_Encounter_IsRandApprove.CheckedValue = "false";
         GXCCtl = "BR_ENCOUNTER_ISRANDRECHECK_" + sGXsfl_31_idx;
         chkBR_Encounter_IsRandRecheck.Name = GXCCtl;
         chkBR_Encounter_IsRandRecheck.WebTags = "";
         chkBR_Encounter_IsRandRecheck.Caption = "";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkBR_Encounter_IsRandRecheck_Internalname, "TitleCaption", chkBR_Encounter_IsRandRecheck.Caption, !bGXsfl_31_Refreshing);
         chkBR_Encounter_IsRandRecheck.CheckedValue = "false";
         GXCCtl = "BR_ENCOUNTER_ISUPDATE_" + sGXsfl_31_idx;
         chkBR_Encounter_IsUpdate.Name = GXCCtl;
         chkBR_Encounter_IsUpdate.WebTags = "";
         chkBR_Encounter_IsUpdate.Caption = "";
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkBR_Encounter_IsUpdate_Internalname, "TitleCaption", chkBR_Encounter_IsUpdate.Caption, !bGXsfl_31_Refreshing);
         chkBR_Encounter_IsUpdate.CheckedValue = "false";
         /* End function init_web_controls */
      }

      protected void init_default_properties( )
      {
         cmbavBr_encounter_status_Internalname = "vBR_ENCOUNTER_STATUS";
         divTableactions_Internalname = "TABLEACTIONS";
         divTableheader_Internalname = "TABLEHEADER";
         divLayout_tableheader_Internalname = "LAYOUT_TABLEHEADER";
         Dvpanel_tableheader_Internalname = "DVPANEL_TABLEHEADER";
         divHtml_dvpanel_tableheader_Internalname = "HTML_DVPANEL_TABLEHEADER";
         edtBR_EncounterID_Internalname = "BR_ENCOUNTERID";
         edtBR_Encounter_Department_Internalname = "BR_ENCOUNTER_DEPARTMENT";
         edtBR_Encounter_ENCType_Internalname = "BR_ENCOUNTER_ENCTYPE";
         edtBR_Encounter_AdmitDate_Internalname = "BR_ENCOUNTER_ADMITDATE";
         cmbBR_Encounter_Status_Internalname = "BR_ENCOUNTER_STATUS";
         chkBR_Encounter_IsRandApprove_Internalname = "BR_ENCOUNTER_ISRANDAPPROVE";
         chkBR_Encounter_IsRandRecheck_Internalname = "BR_ENCOUNTER_ISRANDRECHECK";
         chkBR_Encounter_IsUpdate_Internalname = "BR_ENCOUNTER_ISUPDATE";
         Gridpaginationbar_Internalname = "GRIDPAGINATIONBAR";
         divHtml_gridpaginationbar_Internalname = "HTML_GRIDPAGINATIONBAR";
         divGridtablewithpaginationbar_Internalname = "GRIDTABLEWITHPAGINATIONBAR";
         divTablemain_Internalname = "TABLEMAIN";
         Ddo_br_encounterid_Internalname = "DDO_BR_ENCOUNTERID";
         edtavDdo_br_encounteridtitlecontrolidtoreplace_Internalname = "vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE";
         Ddo_br_encounter_department_Internalname = "DDO_BR_ENCOUNTER_DEPARTMENT";
         edtavDdo_br_encounter_departmenttitlecontrolidtoreplace_Internalname = "vDDO_BR_ENCOUNTER_DEPARTMENTTITLECONTROLIDTOREPLACE";
         Ddo_br_encounter_enctype_Internalname = "DDO_BR_ENCOUNTER_ENCTYPE";
         edtavDdo_br_encounter_enctypetitlecontrolidtoreplace_Internalname = "vDDO_BR_ENCOUNTER_ENCTYPETITLECONTROLIDTOREPLACE";
         Ddo_br_encounter_admitdate_Internalname = "DDO_BR_ENCOUNTER_ADMITDATE";
         edtavDdo_br_encounter_admitdatetitlecontrolidtoreplace_Internalname = "vDDO_BR_ENCOUNTER_ADMITDATETITLECONTROLIDTOREPLACE";
         Ddo_br_encounter_status_Internalname = "DDO_BR_ENCOUNTER_STATUS";
         edtavDdo_br_encounter_statustitlecontrolidtoreplace_Internalname = "vDDO_BR_ENCOUNTER_STATUSTITLECONTROLIDTOREPLACE";
         Ddo_br_encounter_israndapprove_Internalname = "DDO_BR_ENCOUNTER_ISRANDAPPROVE";
         edtavDdo_br_encounter_israndapprovetitlecontrolidtoreplace_Internalname = "vDDO_BR_ENCOUNTER_ISRANDAPPROVETITLECONTROLIDTOREPLACE";
         Ddo_br_encounter_israndrecheck_Internalname = "DDO_BR_ENCOUNTER_ISRANDRECHECK";
         edtavDdo_br_encounter_israndrechecktitlecontrolidtoreplace_Internalname = "vDDO_BR_ENCOUNTER_ISRANDRECHECKTITLECONTROLIDTOREPLACE";
         Ddo_br_encounter_isupdate_Internalname = "DDO_BR_ENCOUNTER_ISUPDATE";
         edtavDdo_br_encounter_isupdatetitlecontrolidtoreplace_Internalname = "vDDO_BR_ENCOUNTER_ISUPDATETITLECONTROLIDTOREPLACE";
         Workwithplusutilities1_Internalname = "WORKWITHPLUSUTILITIES1";
         edtavOrderedby_Internalname = "vORDEREDBY";
         edtavOrdereddsc_Internalname = "vORDEREDDSC";
         edtavTfbr_encounterid_Internalname = "vTFBR_ENCOUNTERID";
         edtavTfbr_encounterid_to_Internalname = "vTFBR_ENCOUNTERID_TO";
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
         chkBR_Encounter_IsUpdate.Caption = "";
         chkBR_Encounter_IsRandRecheck.Caption = "";
         chkBR_Encounter_IsRandApprove.Caption = "";
         cmbBR_Encounter_Status_Jsonclick = "";
         edtBR_Encounter_AdmitDate_Jsonclick = "";
         edtBR_Encounter_ENCType_Jsonclick = "";
         edtBR_Encounter_Department_Jsonclick = "";
         edtBR_EncounterID_Jsonclick = "";
         edtavTfbr_encounterid_to_Jsonclick = "";
         edtavTfbr_encounterid_to_Visible = 1;
         edtavTfbr_encounterid_Jsonclick = "";
         edtavTfbr_encounterid_Visible = 1;
         edtavOrdereddsc_Jsonclick = "";
         edtavOrdereddsc_Visible = 1;
         edtavOrderedby_Jsonclick = "";
         edtavOrderedby_Visible = 1;
         edtavDdo_br_encounter_isupdatetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_encounter_israndrechecktitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_encounter_israndapprovetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_encounter_statustitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_encounter_admitdatetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_encounter_enctypetitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_encounter_departmenttitlecontrolidtoreplace_Visible = 1;
         edtavDdo_br_encounteridtitlecontrolidtoreplace_Visible = 1;
         subGrid_Allowcollapsing = 0;
         subGrid_Allowselection = 0;
         subGrid_Sortable = 0;
         subGrid_Header = "";
         chkBR_Encounter_IsUpdate_Titleformat = 0;
         chkBR_Encounter_IsUpdate.Title.Text = "是否修改";
         chkBR_Encounter_IsRandRecheck_Titleformat = 0;
         chkBR_Encounter_IsRandRecheck.Title.Text = "复审抽查";
         chkBR_Encounter_IsRandApprove_Titleformat = 0;
         chkBR_Encounter_IsRandApprove.Title.Text = "初审抽查";
         cmbBR_Encounter_Status_Titleformat = 0;
         cmbBR_Encounter_Status.Title.Text = "审批状态";
         edtBR_Encounter_AdmitDate_Titleformat = 0;
         edtBR_Encounter_AdmitDate_Title = "就诊/入院时间";
         edtBR_Encounter_ENCType_Titleformat = 0;
         edtBR_Encounter_ENCType_Title = "就诊方式";
         edtBR_Encounter_Department_Titleformat = 0;
         edtBR_Encounter_Department_Title = "就诊科室";
         edtBR_EncounterID_Titleformat = 0;
         edtBR_EncounterID_Title = "就诊序号";
         subGrid_Class = "GridWithPaginationBar GridWithBorderColor WorkWith";
         subGrid_Backcolorstyle = 0;
         cmbavBr_encounter_status_Jsonclick = "";
         cmbavBr_encounter_status.Enabled = 1;
         Ddo_br_encounter_isupdate_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_encounter_isupdate_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_encounter_isupdate_Sortasc = "WWP_TSSortASC";
         Ddo_br_encounter_isupdate_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_encounter_isupdate_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_encounter_isupdate_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_encounter_isupdate_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_encounter_isupdate_Titlecontrolidtoreplace = "";
         Ddo_br_encounter_isupdate_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_encounter_isupdate_Cls = "ColumnSettings";
         Ddo_br_encounter_isupdate_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_encounter_isupdate_Caption = "";
         Ddo_br_encounter_israndrecheck_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_encounter_israndrecheck_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_encounter_israndrecheck_Sortasc = "WWP_TSSortASC";
         Ddo_br_encounter_israndrecheck_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_encounter_israndrecheck_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_encounter_israndrecheck_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_encounter_israndrecheck_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_encounter_israndrecheck_Titlecontrolidtoreplace = "";
         Ddo_br_encounter_israndrecheck_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_encounter_israndrecheck_Cls = "ColumnSettings";
         Ddo_br_encounter_israndrecheck_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_encounter_israndrecheck_Caption = "";
         Ddo_br_encounter_israndapprove_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_encounter_israndapprove_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_encounter_israndapprove_Sortasc = "WWP_TSSortASC";
         Ddo_br_encounter_israndapprove_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_encounter_israndapprove_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_encounter_israndapprove_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_encounter_israndapprove_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_encounter_israndapprove_Titlecontrolidtoreplace = "";
         Ddo_br_encounter_israndapprove_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_encounter_israndapprove_Cls = "ColumnSettings";
         Ddo_br_encounter_israndapprove_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_encounter_israndapprove_Caption = "";
         Ddo_br_encounter_status_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_encounter_status_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_encounter_status_Sortasc = "WWP_TSSortASC";
         Ddo_br_encounter_status_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_encounter_status_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_encounter_status_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_encounter_status_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_encounter_status_Titlecontrolidtoreplace = "";
         Ddo_br_encounter_status_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_encounter_status_Cls = "ColumnSettings";
         Ddo_br_encounter_status_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_encounter_status_Caption = "";
         Ddo_br_encounter_admitdate_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_encounter_admitdate_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_encounter_admitdate_Sortasc = "WWP_TSSortASC";
         Ddo_br_encounter_admitdate_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_encounter_admitdate_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_encounter_admitdate_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_encounter_admitdate_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_encounter_admitdate_Titlecontrolidtoreplace = "";
         Ddo_br_encounter_admitdate_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_encounter_admitdate_Cls = "ColumnSettings";
         Ddo_br_encounter_admitdate_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_encounter_admitdate_Caption = "";
         Ddo_br_encounter_enctype_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_encounter_enctype_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_encounter_enctype_Sortasc = "WWP_TSSortASC";
         Ddo_br_encounter_enctype_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_encounter_enctype_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_encounter_enctype_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_encounter_enctype_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_encounter_enctype_Titlecontrolidtoreplace = "";
         Ddo_br_encounter_enctype_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_encounter_enctype_Cls = "ColumnSettings";
         Ddo_br_encounter_enctype_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_encounter_enctype_Caption = "";
         Ddo_br_encounter_department_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_encounter_department_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_encounter_department_Sortasc = "WWP_TSSortASC";
         Ddo_br_encounter_department_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_encounter_department_Includefilter = Convert.ToBoolean( 0);
         Ddo_br_encounter_department_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_encounter_department_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_encounter_department_Titlecontrolidtoreplace = "";
         Ddo_br_encounter_department_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_encounter_department_Cls = "ColumnSettings";
         Ddo_br_encounter_department_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_encounter_department_Caption = "";
         Ddo_br_encounterid_Searchbuttontext = "WWP_TSSearchButtonCaption";
         Ddo_br_encounterid_Rangefilterto = "WWP_TSTo";
         Ddo_br_encounterid_Rangefilterfrom = "WWP_TSFrom";
         Ddo_br_encounterid_Cleanfilter = "WWP_TSCleanFilter";
         Ddo_br_encounterid_Sortdsc = "WWP_TSSortDSC";
         Ddo_br_encounterid_Sortasc = "WWP_TSSortASC";
         Ddo_br_encounterid_Includedatalist = Convert.ToBoolean( 0);
         Ddo_br_encounterid_Filterisrange = Convert.ToBoolean( -1);
         Ddo_br_encounterid_Filtertype = "Numeric";
         Ddo_br_encounterid_Includefilter = Convert.ToBoolean( -1);
         Ddo_br_encounterid_Includesortdsc = Convert.ToBoolean( -1);
         Ddo_br_encounterid_Includesortasc = Convert.ToBoolean( -1);
         Ddo_br_encounterid_Titlecontrolidtoreplace = "";
         Ddo_br_encounterid_Dropdownoptionstype = "GridTitleSettings";
         Ddo_br_encounterid_Cls = "ColumnSettings";
         Ddo_br_encounterid_Tooltip = "WWP_TSColumnOptions";
         Ddo_br_encounterid_Caption = "";
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
         Form.Headerrawhtml = "";
         Form.Background = "";
         Form.Textcolor = 0;
         Form.Backcolor = (int)(0xFFFFFF);
         Form.Caption = "Web Panel3";
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
         setEventMetadata("REFRESH","{handler:'Refresh',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'AV20ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Encounter_DepartmentTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DEPARTMENTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Encounter_ENCTypeTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Encounter_AdmitDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ADMITDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Encounter_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDRECHECKTITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Encounter_IsUpdateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISUPDATETITLECONTROLIDTOREPLACE',pic:''},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavBr_encounter_status'},{av:'AV15BR_Encounter_Status',fld:'vBR_ENCOUNTER_STATUS',pic:'ZZZ9'},{av:'AV18TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV19TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV49Pgmname',fld:'vPGMNAME',pic:''},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''}]");
         setEventMetadata("REFRESH",",oparms:[{av:'AV17BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV32BR_Encounter_DepartmentTitleFilterData',fld:'vBR_ENCOUNTER_DEPARTMENTTITLEFILTERDATA',pic:''},{av:'AV34BR_Encounter_ENCTypeTitleFilterData',fld:'vBR_ENCOUNTER_ENCTYPETITLEFILTERDATA',pic:''},{av:'AV36BR_Encounter_AdmitDateTitleFilterData',fld:'vBR_ENCOUNTER_ADMITDATETITLEFILTERDATA',pic:''},{av:'AV21BR_Encounter_StatusTitleFilterData',fld:'vBR_ENCOUNTER_STATUSTITLEFILTERDATA',pic:''},{av:'AV38BR_Encounter_IsRandApproveTitleFilterData',fld:'vBR_ENCOUNTER_ISRANDAPPROVETITLEFILTERDATA',pic:''},{av:'AV40BR_Encounter_IsRandRecheckTitleFilterData',fld:'vBR_ENCOUNTER_ISRANDRECHECKTITLEFILTERDATA',pic:''},{av:'AV42BR_Encounter_IsUpdateTitleFilterData',fld:'vBR_ENCOUNTER_ISUPDATETITLEFILTERDATA',pic:''},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Encounter_Department_Titleformat',ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Titleformat'},{av:'edtBR_Encounter_Department_Title',ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Title'},{av:'edtBR_Encounter_ENCType_Titleformat',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Titleformat'},{av:'edtBR_Encounter_ENCType_Title',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Title'},{av:'edtBR_Encounter_AdmitDate_Titleformat',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Titleformat'},{av:'edtBR_Encounter_AdmitDate_Title',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Title'},{av:'cmbBR_Encounter_Status'},{av:'chkBR_Encounter_IsRandApprove_Titleformat',ctrl:'BR_ENCOUNTER_ISRANDAPPROVE',prop:'Titleformat'},{av:'chkBR_Encounter_IsRandApprove.Title.Text',ctrl:'BR_ENCOUNTER_ISRANDAPPROVE',prop:'Title'},{av:'chkBR_Encounter_IsRandRecheck_Titleformat',ctrl:'BR_ENCOUNTER_ISRANDRECHECK',prop:'Titleformat'},{av:'chkBR_Encounter_IsRandRecheck.Title.Text',ctrl:'BR_ENCOUNTER_ISRANDRECHECK',prop:'Title'},{av:'chkBR_Encounter_IsUpdate_Titleformat',ctrl:'BR_ENCOUNTER_ISUPDATE',prop:'Titleformat'},{av:'chkBR_Encounter_IsUpdate.Title.Text',ctrl:'BR_ENCOUNTER_ISUPDATE',prop:'Title'},{av:'AV27GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV28GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV29GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE","{handler:'E11A82',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavBr_encounter_status'},{av:'AV15BR_Encounter_Status',fld:'vBR_ENCOUNTER_STATUS',pic:'ZZZ9'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV18TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV19TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV20ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Encounter_DepartmentTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DEPARTMENTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Encounter_ENCTypeTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Encounter_AdmitDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ADMITDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Encounter_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDRECHECKTITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Encounter_IsUpdateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISUPDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49Pgmname',fld:'vPGMNAME',pic:''},{av:'Gridpaginationbar_Selectedpage',ctrl:'GRIDPAGINATIONBAR',prop:'SelectedPage'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEPAGE",",oparms:[]}");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE","{handler:'E12A82',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavBr_encounter_status'},{av:'AV15BR_Encounter_Status',fld:'vBR_ENCOUNTER_STATUS',pic:'ZZZ9'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV18TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV19TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV20ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Encounter_DepartmentTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DEPARTMENTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Encounter_ENCTypeTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Encounter_AdmitDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ADMITDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Encounter_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDRECHECKTITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Encounter_IsUpdateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISUPDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49Pgmname',fld:'vPGMNAME',pic:''},{av:'Gridpaginationbar_Rowsperpageselectedvalue',ctrl:'GRIDPAGINATIONBAR',prop:'RowsPerPageSelectedValue'}]");
         setEventMetadata("GRIDPAGINATIONBAR.CHANGEROWSPERPAGE",",oparms:[{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'}]}");
         setEventMetadata("DDO_BR_ENCOUNTERID.ONOPTIONCLICKED","{handler:'E13A82',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavBr_encounter_status'},{av:'AV15BR_Encounter_Status',fld:'vBR_ENCOUNTER_STATUS',pic:'ZZZ9'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV18TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV19TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV20ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Encounter_DepartmentTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DEPARTMENTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Encounter_ENCTypeTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Encounter_AdmitDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ADMITDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Encounter_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDRECHECKTITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Encounter_IsUpdateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISUPDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49Pgmname',fld:'vPGMNAME',pic:''},{av:'Ddo_br_encounterid_Activeeventkey',ctrl:'DDO_BR_ENCOUNTERID',prop:'ActiveEventKey'},{av:'Ddo_br_encounterid_Filteredtext_get',ctrl:'DDO_BR_ENCOUNTERID',prop:'FilteredText_get'},{av:'Ddo_br_encounterid_Filteredtextto_get',ctrl:'DDO_BR_ENCOUNTERID',prop:'FilteredTextTo_get'}]");
         setEventMetadata("DDO_BR_ENCOUNTERID.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_encounterid_Sortedstatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'AV18TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV19TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'Ddo_br_encounter_department_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_DEPARTMENT',prop:'SortedStatus'},{av:'Ddo_br_encounter_enctype_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_ENCTYPE',prop:'SortedStatus'},{av:'Ddo_br_encounter_admitdate_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_ADMITDATE',prop:'SortedStatus'},{av:'Ddo_br_encounter_status_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_STATUS',prop:'SortedStatus'},{av:'Ddo_br_encounter_israndapprove_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_ISRANDAPPROVE',prop:'SortedStatus'},{av:'Ddo_br_encounter_israndrecheck_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_ISRANDRECHECK',prop:'SortedStatus'},{av:'Ddo_br_encounter_isupdate_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_ISUPDATE',prop:'SortedStatus'},{av:'AV17BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV32BR_Encounter_DepartmentTitleFilterData',fld:'vBR_ENCOUNTER_DEPARTMENTTITLEFILTERDATA',pic:''},{av:'AV34BR_Encounter_ENCTypeTitleFilterData',fld:'vBR_ENCOUNTER_ENCTYPETITLEFILTERDATA',pic:''},{av:'AV36BR_Encounter_AdmitDateTitleFilterData',fld:'vBR_ENCOUNTER_ADMITDATETITLEFILTERDATA',pic:''},{av:'AV21BR_Encounter_StatusTitleFilterData',fld:'vBR_ENCOUNTER_STATUSTITLEFILTERDATA',pic:''},{av:'AV38BR_Encounter_IsRandApproveTitleFilterData',fld:'vBR_ENCOUNTER_ISRANDAPPROVETITLEFILTERDATA',pic:''},{av:'AV40BR_Encounter_IsRandRecheckTitleFilterData',fld:'vBR_ENCOUNTER_ISRANDRECHECKTITLEFILTERDATA',pic:''},{av:'AV42BR_Encounter_IsUpdateTitleFilterData',fld:'vBR_ENCOUNTER_ISUPDATETITLEFILTERDATA',pic:''},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Encounter_Department_Titleformat',ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Titleformat'},{av:'edtBR_Encounter_Department_Title',ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Title'},{av:'edtBR_Encounter_ENCType_Titleformat',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Titleformat'},{av:'edtBR_Encounter_ENCType_Title',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Title'},{av:'edtBR_Encounter_AdmitDate_Titleformat',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Titleformat'},{av:'edtBR_Encounter_AdmitDate_Title',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Title'},{av:'cmbBR_Encounter_Status'},{av:'chkBR_Encounter_IsRandApprove_Titleformat',ctrl:'BR_ENCOUNTER_ISRANDAPPROVE',prop:'Titleformat'},{av:'chkBR_Encounter_IsRandApprove.Title.Text',ctrl:'BR_ENCOUNTER_ISRANDAPPROVE',prop:'Title'},{av:'chkBR_Encounter_IsRandRecheck_Titleformat',ctrl:'BR_ENCOUNTER_ISRANDRECHECK',prop:'Titleformat'},{av:'chkBR_Encounter_IsRandRecheck.Title.Text',ctrl:'BR_ENCOUNTER_ISRANDRECHECK',prop:'Title'},{av:'chkBR_Encounter_IsUpdate_Titleformat',ctrl:'BR_ENCOUNTER_ISUPDATE',prop:'Titleformat'},{av:'chkBR_Encounter_IsUpdate.Title.Text',ctrl:'BR_ENCOUNTER_ISUPDATE',prop:'Title'},{av:'AV27GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV28GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV29GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_ENCOUNTER_DEPARTMENT.ONOPTIONCLICKED","{handler:'E14A82',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavBr_encounter_status'},{av:'AV15BR_Encounter_Status',fld:'vBR_ENCOUNTER_STATUS',pic:'ZZZ9'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV18TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV19TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV20ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Encounter_DepartmentTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DEPARTMENTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Encounter_ENCTypeTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Encounter_AdmitDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ADMITDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Encounter_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDRECHECKTITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Encounter_IsUpdateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISUPDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49Pgmname',fld:'vPGMNAME',pic:''},{av:'Ddo_br_encounter_department_Activeeventkey',ctrl:'DDO_BR_ENCOUNTER_DEPARTMENT',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_ENCOUNTER_DEPARTMENT.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_encounter_department_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_DEPARTMENT',prop:'SortedStatus'},{av:'Ddo_br_encounterid_Sortedstatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'Ddo_br_encounter_enctype_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_ENCTYPE',prop:'SortedStatus'},{av:'Ddo_br_encounter_admitdate_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_ADMITDATE',prop:'SortedStatus'},{av:'Ddo_br_encounter_status_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_STATUS',prop:'SortedStatus'},{av:'Ddo_br_encounter_israndapprove_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_ISRANDAPPROVE',prop:'SortedStatus'},{av:'Ddo_br_encounter_israndrecheck_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_ISRANDRECHECK',prop:'SortedStatus'},{av:'Ddo_br_encounter_isupdate_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_ISUPDATE',prop:'SortedStatus'},{av:'AV17BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV32BR_Encounter_DepartmentTitleFilterData',fld:'vBR_ENCOUNTER_DEPARTMENTTITLEFILTERDATA',pic:''},{av:'AV34BR_Encounter_ENCTypeTitleFilterData',fld:'vBR_ENCOUNTER_ENCTYPETITLEFILTERDATA',pic:''},{av:'AV36BR_Encounter_AdmitDateTitleFilterData',fld:'vBR_ENCOUNTER_ADMITDATETITLEFILTERDATA',pic:''},{av:'AV21BR_Encounter_StatusTitleFilterData',fld:'vBR_ENCOUNTER_STATUSTITLEFILTERDATA',pic:''},{av:'AV38BR_Encounter_IsRandApproveTitleFilterData',fld:'vBR_ENCOUNTER_ISRANDAPPROVETITLEFILTERDATA',pic:''},{av:'AV40BR_Encounter_IsRandRecheckTitleFilterData',fld:'vBR_ENCOUNTER_ISRANDRECHECKTITLEFILTERDATA',pic:''},{av:'AV42BR_Encounter_IsUpdateTitleFilterData',fld:'vBR_ENCOUNTER_ISUPDATETITLEFILTERDATA',pic:''},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Encounter_Department_Titleformat',ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Titleformat'},{av:'edtBR_Encounter_Department_Title',ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Title'},{av:'edtBR_Encounter_ENCType_Titleformat',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Titleformat'},{av:'edtBR_Encounter_ENCType_Title',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Title'},{av:'edtBR_Encounter_AdmitDate_Titleformat',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Titleformat'},{av:'edtBR_Encounter_AdmitDate_Title',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Title'},{av:'cmbBR_Encounter_Status'},{av:'chkBR_Encounter_IsRandApprove_Titleformat',ctrl:'BR_ENCOUNTER_ISRANDAPPROVE',prop:'Titleformat'},{av:'chkBR_Encounter_IsRandApprove.Title.Text',ctrl:'BR_ENCOUNTER_ISRANDAPPROVE',prop:'Title'},{av:'chkBR_Encounter_IsRandRecheck_Titleformat',ctrl:'BR_ENCOUNTER_ISRANDRECHECK',prop:'Titleformat'},{av:'chkBR_Encounter_IsRandRecheck.Title.Text',ctrl:'BR_ENCOUNTER_ISRANDRECHECK',prop:'Title'},{av:'chkBR_Encounter_IsUpdate_Titleformat',ctrl:'BR_ENCOUNTER_ISUPDATE',prop:'Titleformat'},{av:'chkBR_Encounter_IsUpdate.Title.Text',ctrl:'BR_ENCOUNTER_ISUPDATE',prop:'Title'},{av:'AV27GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV28GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV29GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_ENCOUNTER_ENCTYPE.ONOPTIONCLICKED","{handler:'E15A82',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavBr_encounter_status'},{av:'AV15BR_Encounter_Status',fld:'vBR_ENCOUNTER_STATUS',pic:'ZZZ9'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV18TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV19TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV20ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Encounter_DepartmentTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DEPARTMENTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Encounter_ENCTypeTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Encounter_AdmitDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ADMITDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Encounter_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDRECHECKTITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Encounter_IsUpdateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISUPDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49Pgmname',fld:'vPGMNAME',pic:''},{av:'Ddo_br_encounter_enctype_Activeeventkey',ctrl:'DDO_BR_ENCOUNTER_ENCTYPE',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_ENCOUNTER_ENCTYPE.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_encounter_enctype_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_ENCTYPE',prop:'SortedStatus'},{av:'Ddo_br_encounterid_Sortedstatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'Ddo_br_encounter_department_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_DEPARTMENT',prop:'SortedStatus'},{av:'Ddo_br_encounter_admitdate_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_ADMITDATE',prop:'SortedStatus'},{av:'Ddo_br_encounter_status_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_STATUS',prop:'SortedStatus'},{av:'Ddo_br_encounter_israndapprove_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_ISRANDAPPROVE',prop:'SortedStatus'},{av:'Ddo_br_encounter_israndrecheck_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_ISRANDRECHECK',prop:'SortedStatus'},{av:'Ddo_br_encounter_isupdate_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_ISUPDATE',prop:'SortedStatus'},{av:'AV17BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV32BR_Encounter_DepartmentTitleFilterData',fld:'vBR_ENCOUNTER_DEPARTMENTTITLEFILTERDATA',pic:''},{av:'AV34BR_Encounter_ENCTypeTitleFilterData',fld:'vBR_ENCOUNTER_ENCTYPETITLEFILTERDATA',pic:''},{av:'AV36BR_Encounter_AdmitDateTitleFilterData',fld:'vBR_ENCOUNTER_ADMITDATETITLEFILTERDATA',pic:''},{av:'AV21BR_Encounter_StatusTitleFilterData',fld:'vBR_ENCOUNTER_STATUSTITLEFILTERDATA',pic:''},{av:'AV38BR_Encounter_IsRandApproveTitleFilterData',fld:'vBR_ENCOUNTER_ISRANDAPPROVETITLEFILTERDATA',pic:''},{av:'AV40BR_Encounter_IsRandRecheckTitleFilterData',fld:'vBR_ENCOUNTER_ISRANDRECHECKTITLEFILTERDATA',pic:''},{av:'AV42BR_Encounter_IsUpdateTitleFilterData',fld:'vBR_ENCOUNTER_ISUPDATETITLEFILTERDATA',pic:''},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Encounter_Department_Titleformat',ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Titleformat'},{av:'edtBR_Encounter_Department_Title',ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Title'},{av:'edtBR_Encounter_ENCType_Titleformat',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Titleformat'},{av:'edtBR_Encounter_ENCType_Title',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Title'},{av:'edtBR_Encounter_AdmitDate_Titleformat',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Titleformat'},{av:'edtBR_Encounter_AdmitDate_Title',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Title'},{av:'cmbBR_Encounter_Status'},{av:'chkBR_Encounter_IsRandApprove_Titleformat',ctrl:'BR_ENCOUNTER_ISRANDAPPROVE',prop:'Titleformat'},{av:'chkBR_Encounter_IsRandApprove.Title.Text',ctrl:'BR_ENCOUNTER_ISRANDAPPROVE',prop:'Title'},{av:'chkBR_Encounter_IsRandRecheck_Titleformat',ctrl:'BR_ENCOUNTER_ISRANDRECHECK',prop:'Titleformat'},{av:'chkBR_Encounter_IsRandRecheck.Title.Text',ctrl:'BR_ENCOUNTER_ISRANDRECHECK',prop:'Title'},{av:'chkBR_Encounter_IsUpdate_Titleformat',ctrl:'BR_ENCOUNTER_ISUPDATE',prop:'Titleformat'},{av:'chkBR_Encounter_IsUpdate.Title.Text',ctrl:'BR_ENCOUNTER_ISUPDATE',prop:'Title'},{av:'AV27GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV28GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV29GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_ENCOUNTER_ADMITDATE.ONOPTIONCLICKED","{handler:'E16A82',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavBr_encounter_status'},{av:'AV15BR_Encounter_Status',fld:'vBR_ENCOUNTER_STATUS',pic:'ZZZ9'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV18TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV19TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV20ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Encounter_DepartmentTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DEPARTMENTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Encounter_ENCTypeTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Encounter_AdmitDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ADMITDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Encounter_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDRECHECKTITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Encounter_IsUpdateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISUPDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49Pgmname',fld:'vPGMNAME',pic:''},{av:'Ddo_br_encounter_admitdate_Activeeventkey',ctrl:'DDO_BR_ENCOUNTER_ADMITDATE',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_ENCOUNTER_ADMITDATE.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_encounter_admitdate_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_ADMITDATE',prop:'SortedStatus'},{av:'Ddo_br_encounterid_Sortedstatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'Ddo_br_encounter_department_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_DEPARTMENT',prop:'SortedStatus'},{av:'Ddo_br_encounter_enctype_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_ENCTYPE',prop:'SortedStatus'},{av:'Ddo_br_encounter_status_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_STATUS',prop:'SortedStatus'},{av:'Ddo_br_encounter_israndapprove_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_ISRANDAPPROVE',prop:'SortedStatus'},{av:'Ddo_br_encounter_israndrecheck_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_ISRANDRECHECK',prop:'SortedStatus'},{av:'Ddo_br_encounter_isupdate_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_ISUPDATE',prop:'SortedStatus'},{av:'AV17BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV32BR_Encounter_DepartmentTitleFilterData',fld:'vBR_ENCOUNTER_DEPARTMENTTITLEFILTERDATA',pic:''},{av:'AV34BR_Encounter_ENCTypeTitleFilterData',fld:'vBR_ENCOUNTER_ENCTYPETITLEFILTERDATA',pic:''},{av:'AV36BR_Encounter_AdmitDateTitleFilterData',fld:'vBR_ENCOUNTER_ADMITDATETITLEFILTERDATA',pic:''},{av:'AV21BR_Encounter_StatusTitleFilterData',fld:'vBR_ENCOUNTER_STATUSTITLEFILTERDATA',pic:''},{av:'AV38BR_Encounter_IsRandApproveTitleFilterData',fld:'vBR_ENCOUNTER_ISRANDAPPROVETITLEFILTERDATA',pic:''},{av:'AV40BR_Encounter_IsRandRecheckTitleFilterData',fld:'vBR_ENCOUNTER_ISRANDRECHECKTITLEFILTERDATA',pic:''},{av:'AV42BR_Encounter_IsUpdateTitleFilterData',fld:'vBR_ENCOUNTER_ISUPDATETITLEFILTERDATA',pic:''},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Encounter_Department_Titleformat',ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Titleformat'},{av:'edtBR_Encounter_Department_Title',ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Title'},{av:'edtBR_Encounter_ENCType_Titleformat',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Titleformat'},{av:'edtBR_Encounter_ENCType_Title',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Title'},{av:'edtBR_Encounter_AdmitDate_Titleformat',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Titleformat'},{av:'edtBR_Encounter_AdmitDate_Title',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Title'},{av:'cmbBR_Encounter_Status'},{av:'chkBR_Encounter_IsRandApprove_Titleformat',ctrl:'BR_ENCOUNTER_ISRANDAPPROVE',prop:'Titleformat'},{av:'chkBR_Encounter_IsRandApprove.Title.Text',ctrl:'BR_ENCOUNTER_ISRANDAPPROVE',prop:'Title'},{av:'chkBR_Encounter_IsRandRecheck_Titleformat',ctrl:'BR_ENCOUNTER_ISRANDRECHECK',prop:'Titleformat'},{av:'chkBR_Encounter_IsRandRecheck.Title.Text',ctrl:'BR_ENCOUNTER_ISRANDRECHECK',prop:'Title'},{av:'chkBR_Encounter_IsUpdate_Titleformat',ctrl:'BR_ENCOUNTER_ISUPDATE',prop:'Titleformat'},{av:'chkBR_Encounter_IsUpdate.Title.Text',ctrl:'BR_ENCOUNTER_ISUPDATE',prop:'Title'},{av:'AV27GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV28GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV29GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_ENCOUNTER_STATUS.ONOPTIONCLICKED","{handler:'E17A82',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavBr_encounter_status'},{av:'AV15BR_Encounter_Status',fld:'vBR_ENCOUNTER_STATUS',pic:'ZZZ9'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV18TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV19TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV20ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Encounter_DepartmentTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DEPARTMENTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Encounter_ENCTypeTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Encounter_AdmitDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ADMITDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Encounter_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDRECHECKTITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Encounter_IsUpdateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISUPDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49Pgmname',fld:'vPGMNAME',pic:''},{av:'Ddo_br_encounter_status_Activeeventkey',ctrl:'DDO_BR_ENCOUNTER_STATUS',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_ENCOUNTER_STATUS.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_encounter_status_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_STATUS',prop:'SortedStatus'},{av:'Ddo_br_encounterid_Sortedstatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'Ddo_br_encounter_department_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_DEPARTMENT',prop:'SortedStatus'},{av:'Ddo_br_encounter_enctype_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_ENCTYPE',prop:'SortedStatus'},{av:'Ddo_br_encounter_admitdate_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_ADMITDATE',prop:'SortedStatus'},{av:'Ddo_br_encounter_israndapprove_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_ISRANDAPPROVE',prop:'SortedStatus'},{av:'Ddo_br_encounter_israndrecheck_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_ISRANDRECHECK',prop:'SortedStatus'},{av:'Ddo_br_encounter_isupdate_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_ISUPDATE',prop:'SortedStatus'},{av:'AV17BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV32BR_Encounter_DepartmentTitleFilterData',fld:'vBR_ENCOUNTER_DEPARTMENTTITLEFILTERDATA',pic:''},{av:'AV34BR_Encounter_ENCTypeTitleFilterData',fld:'vBR_ENCOUNTER_ENCTYPETITLEFILTERDATA',pic:''},{av:'AV36BR_Encounter_AdmitDateTitleFilterData',fld:'vBR_ENCOUNTER_ADMITDATETITLEFILTERDATA',pic:''},{av:'AV21BR_Encounter_StatusTitleFilterData',fld:'vBR_ENCOUNTER_STATUSTITLEFILTERDATA',pic:''},{av:'AV38BR_Encounter_IsRandApproveTitleFilterData',fld:'vBR_ENCOUNTER_ISRANDAPPROVETITLEFILTERDATA',pic:''},{av:'AV40BR_Encounter_IsRandRecheckTitleFilterData',fld:'vBR_ENCOUNTER_ISRANDRECHECKTITLEFILTERDATA',pic:''},{av:'AV42BR_Encounter_IsUpdateTitleFilterData',fld:'vBR_ENCOUNTER_ISUPDATETITLEFILTERDATA',pic:''},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Encounter_Department_Titleformat',ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Titleformat'},{av:'edtBR_Encounter_Department_Title',ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Title'},{av:'edtBR_Encounter_ENCType_Titleformat',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Titleformat'},{av:'edtBR_Encounter_ENCType_Title',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Title'},{av:'edtBR_Encounter_AdmitDate_Titleformat',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Titleformat'},{av:'edtBR_Encounter_AdmitDate_Title',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Title'},{av:'cmbBR_Encounter_Status'},{av:'chkBR_Encounter_IsRandApprove_Titleformat',ctrl:'BR_ENCOUNTER_ISRANDAPPROVE',prop:'Titleformat'},{av:'chkBR_Encounter_IsRandApprove.Title.Text',ctrl:'BR_ENCOUNTER_ISRANDAPPROVE',prop:'Title'},{av:'chkBR_Encounter_IsRandRecheck_Titleformat',ctrl:'BR_ENCOUNTER_ISRANDRECHECK',prop:'Titleformat'},{av:'chkBR_Encounter_IsRandRecheck.Title.Text',ctrl:'BR_ENCOUNTER_ISRANDRECHECK',prop:'Title'},{av:'chkBR_Encounter_IsUpdate_Titleformat',ctrl:'BR_ENCOUNTER_ISUPDATE',prop:'Titleformat'},{av:'chkBR_Encounter_IsUpdate.Title.Text',ctrl:'BR_ENCOUNTER_ISUPDATE',prop:'Title'},{av:'AV27GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV28GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV29GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_ENCOUNTER_ISRANDAPPROVE.ONOPTIONCLICKED","{handler:'E18A82',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavBr_encounter_status'},{av:'AV15BR_Encounter_Status',fld:'vBR_ENCOUNTER_STATUS',pic:'ZZZ9'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV18TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV19TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV20ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Encounter_DepartmentTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DEPARTMENTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Encounter_ENCTypeTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Encounter_AdmitDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ADMITDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Encounter_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDRECHECKTITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Encounter_IsUpdateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISUPDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49Pgmname',fld:'vPGMNAME',pic:''},{av:'Ddo_br_encounter_israndapprove_Activeeventkey',ctrl:'DDO_BR_ENCOUNTER_ISRANDAPPROVE',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_ENCOUNTER_ISRANDAPPROVE.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_encounter_israndapprove_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_ISRANDAPPROVE',prop:'SortedStatus'},{av:'Ddo_br_encounterid_Sortedstatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'Ddo_br_encounter_department_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_DEPARTMENT',prop:'SortedStatus'},{av:'Ddo_br_encounter_enctype_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_ENCTYPE',prop:'SortedStatus'},{av:'Ddo_br_encounter_admitdate_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_ADMITDATE',prop:'SortedStatus'},{av:'Ddo_br_encounter_status_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_STATUS',prop:'SortedStatus'},{av:'Ddo_br_encounter_israndrecheck_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_ISRANDRECHECK',prop:'SortedStatus'},{av:'Ddo_br_encounter_isupdate_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_ISUPDATE',prop:'SortedStatus'},{av:'AV17BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV32BR_Encounter_DepartmentTitleFilterData',fld:'vBR_ENCOUNTER_DEPARTMENTTITLEFILTERDATA',pic:''},{av:'AV34BR_Encounter_ENCTypeTitleFilterData',fld:'vBR_ENCOUNTER_ENCTYPETITLEFILTERDATA',pic:''},{av:'AV36BR_Encounter_AdmitDateTitleFilterData',fld:'vBR_ENCOUNTER_ADMITDATETITLEFILTERDATA',pic:''},{av:'AV21BR_Encounter_StatusTitleFilterData',fld:'vBR_ENCOUNTER_STATUSTITLEFILTERDATA',pic:''},{av:'AV38BR_Encounter_IsRandApproveTitleFilterData',fld:'vBR_ENCOUNTER_ISRANDAPPROVETITLEFILTERDATA',pic:''},{av:'AV40BR_Encounter_IsRandRecheckTitleFilterData',fld:'vBR_ENCOUNTER_ISRANDRECHECKTITLEFILTERDATA',pic:''},{av:'AV42BR_Encounter_IsUpdateTitleFilterData',fld:'vBR_ENCOUNTER_ISUPDATETITLEFILTERDATA',pic:''},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Encounter_Department_Titleformat',ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Titleformat'},{av:'edtBR_Encounter_Department_Title',ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Title'},{av:'edtBR_Encounter_ENCType_Titleformat',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Titleformat'},{av:'edtBR_Encounter_ENCType_Title',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Title'},{av:'edtBR_Encounter_AdmitDate_Titleformat',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Titleformat'},{av:'edtBR_Encounter_AdmitDate_Title',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Title'},{av:'cmbBR_Encounter_Status'},{av:'chkBR_Encounter_IsRandApprove_Titleformat',ctrl:'BR_ENCOUNTER_ISRANDAPPROVE',prop:'Titleformat'},{av:'chkBR_Encounter_IsRandApprove.Title.Text',ctrl:'BR_ENCOUNTER_ISRANDAPPROVE',prop:'Title'},{av:'chkBR_Encounter_IsRandRecheck_Titleformat',ctrl:'BR_ENCOUNTER_ISRANDRECHECK',prop:'Titleformat'},{av:'chkBR_Encounter_IsRandRecheck.Title.Text',ctrl:'BR_ENCOUNTER_ISRANDRECHECK',prop:'Title'},{av:'chkBR_Encounter_IsUpdate_Titleformat',ctrl:'BR_ENCOUNTER_ISUPDATE',prop:'Titleformat'},{av:'chkBR_Encounter_IsUpdate.Title.Text',ctrl:'BR_ENCOUNTER_ISUPDATE',prop:'Title'},{av:'AV27GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV28GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV29GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_ENCOUNTER_ISRANDRECHECK.ONOPTIONCLICKED","{handler:'E19A82',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavBr_encounter_status'},{av:'AV15BR_Encounter_Status',fld:'vBR_ENCOUNTER_STATUS',pic:'ZZZ9'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV18TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV19TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV20ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Encounter_DepartmentTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DEPARTMENTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Encounter_ENCTypeTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Encounter_AdmitDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ADMITDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Encounter_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDRECHECKTITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Encounter_IsUpdateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISUPDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49Pgmname',fld:'vPGMNAME',pic:''},{av:'Ddo_br_encounter_israndrecheck_Activeeventkey',ctrl:'DDO_BR_ENCOUNTER_ISRANDRECHECK',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_ENCOUNTER_ISRANDRECHECK.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_encounter_israndrecheck_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_ISRANDRECHECK',prop:'SortedStatus'},{av:'Ddo_br_encounterid_Sortedstatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'Ddo_br_encounter_department_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_DEPARTMENT',prop:'SortedStatus'},{av:'Ddo_br_encounter_enctype_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_ENCTYPE',prop:'SortedStatus'},{av:'Ddo_br_encounter_admitdate_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_ADMITDATE',prop:'SortedStatus'},{av:'Ddo_br_encounter_status_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_STATUS',prop:'SortedStatus'},{av:'Ddo_br_encounter_israndapprove_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_ISRANDAPPROVE',prop:'SortedStatus'},{av:'Ddo_br_encounter_isupdate_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_ISUPDATE',prop:'SortedStatus'},{av:'AV17BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV32BR_Encounter_DepartmentTitleFilterData',fld:'vBR_ENCOUNTER_DEPARTMENTTITLEFILTERDATA',pic:''},{av:'AV34BR_Encounter_ENCTypeTitleFilterData',fld:'vBR_ENCOUNTER_ENCTYPETITLEFILTERDATA',pic:''},{av:'AV36BR_Encounter_AdmitDateTitleFilterData',fld:'vBR_ENCOUNTER_ADMITDATETITLEFILTERDATA',pic:''},{av:'AV21BR_Encounter_StatusTitleFilterData',fld:'vBR_ENCOUNTER_STATUSTITLEFILTERDATA',pic:''},{av:'AV38BR_Encounter_IsRandApproveTitleFilterData',fld:'vBR_ENCOUNTER_ISRANDAPPROVETITLEFILTERDATA',pic:''},{av:'AV40BR_Encounter_IsRandRecheckTitleFilterData',fld:'vBR_ENCOUNTER_ISRANDRECHECKTITLEFILTERDATA',pic:''},{av:'AV42BR_Encounter_IsUpdateTitleFilterData',fld:'vBR_ENCOUNTER_ISUPDATETITLEFILTERDATA',pic:''},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Encounter_Department_Titleformat',ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Titleformat'},{av:'edtBR_Encounter_Department_Title',ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Title'},{av:'edtBR_Encounter_ENCType_Titleformat',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Titleformat'},{av:'edtBR_Encounter_ENCType_Title',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Title'},{av:'edtBR_Encounter_AdmitDate_Titleformat',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Titleformat'},{av:'edtBR_Encounter_AdmitDate_Title',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Title'},{av:'cmbBR_Encounter_Status'},{av:'chkBR_Encounter_IsRandApprove_Titleformat',ctrl:'BR_ENCOUNTER_ISRANDAPPROVE',prop:'Titleformat'},{av:'chkBR_Encounter_IsRandApprove.Title.Text',ctrl:'BR_ENCOUNTER_ISRANDAPPROVE',prop:'Title'},{av:'chkBR_Encounter_IsRandRecheck_Titleformat',ctrl:'BR_ENCOUNTER_ISRANDRECHECK',prop:'Titleformat'},{av:'chkBR_Encounter_IsRandRecheck.Title.Text',ctrl:'BR_ENCOUNTER_ISRANDRECHECK',prop:'Title'},{av:'chkBR_Encounter_IsUpdate_Titleformat',ctrl:'BR_ENCOUNTER_ISUPDATE',prop:'Titleformat'},{av:'chkBR_Encounter_IsUpdate.Title.Text',ctrl:'BR_ENCOUNTER_ISUPDATE',prop:'Title'},{av:'AV27GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV28GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV29GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("DDO_BR_ENCOUNTER_ISUPDATE.ONOPTIONCLICKED","{handler:'E20A82',iparms:[{av:'GRID_nFirstRecordOnPage'},{av:'GRID_nEOF'},{av:'subGrid_Rows',ctrl:'GRID',prop:'Rows'},{av:'cmbavBr_encounter_status'},{av:'AV15BR_Encounter_Status',fld:'vBR_ENCOUNTER_STATUS',pic:'ZZZ9'},{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'AV18TFBR_EncounterID',fld:'vTFBR_ENCOUNTERID',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV19TFBR_EncounterID_To',fld:'vTFBR_ENCOUNTERID_TO',pic:'ZZZZZZZZZZZZZZZZZZ'},{av:'AV20ddo_BR_EncounterIDTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTERIDTITLECONTROLIDTOREPLACE',pic:''},{av:'AV33ddo_BR_Encounter_DepartmentTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_DEPARTMENTTITLECONTROLIDTOREPLACE',pic:''},{av:'AV35ddo_BR_Encounter_ENCTypeTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ENCTYPETITLECONTROLIDTOREPLACE',pic:''},{av:'AV37ddo_BR_Encounter_AdmitDateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ADMITDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV24ddo_BR_Encounter_StatusTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_STATUSTITLECONTROLIDTOREPLACE',pic:''},{av:'AV39ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDAPPROVETITLECONTROLIDTOREPLACE',pic:''},{av:'AV41ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISRANDRECHECKTITLECONTROLIDTOREPLACE',pic:''},{av:'AV43ddo_BR_Encounter_IsUpdateTitleControlIdToReplace',fld:'vDDO_BR_ENCOUNTER_ISUPDATETITLECONTROLIDTOREPLACE',pic:''},{av:'AV49Pgmname',fld:'vPGMNAME',pic:''},{av:'Ddo_br_encounter_isupdate_Activeeventkey',ctrl:'DDO_BR_ENCOUNTER_ISUPDATE',prop:'ActiveEventKey'}]");
         setEventMetadata("DDO_BR_ENCOUNTER_ISUPDATE.ONOPTIONCLICKED",",oparms:[{av:'AV13OrderedBy',fld:'vORDEREDBY',pic:'ZZZ9'},{av:'AV14OrderedDsc',fld:'vORDEREDDSC',pic:''},{av:'Ddo_br_encounter_isupdate_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_ISUPDATE',prop:'SortedStatus'},{av:'Ddo_br_encounterid_Sortedstatus',ctrl:'DDO_BR_ENCOUNTERID',prop:'SortedStatus'},{av:'Ddo_br_encounter_department_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_DEPARTMENT',prop:'SortedStatus'},{av:'Ddo_br_encounter_enctype_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_ENCTYPE',prop:'SortedStatus'},{av:'Ddo_br_encounter_admitdate_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_ADMITDATE',prop:'SortedStatus'},{av:'Ddo_br_encounter_status_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_STATUS',prop:'SortedStatus'},{av:'Ddo_br_encounter_israndapprove_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_ISRANDAPPROVE',prop:'SortedStatus'},{av:'Ddo_br_encounter_israndrecheck_Sortedstatus',ctrl:'DDO_BR_ENCOUNTER_ISRANDRECHECK',prop:'SortedStatus'},{av:'AV17BR_EncounterIDTitleFilterData',fld:'vBR_ENCOUNTERIDTITLEFILTERDATA',pic:''},{av:'AV32BR_Encounter_DepartmentTitleFilterData',fld:'vBR_ENCOUNTER_DEPARTMENTTITLEFILTERDATA',pic:''},{av:'AV34BR_Encounter_ENCTypeTitleFilterData',fld:'vBR_ENCOUNTER_ENCTYPETITLEFILTERDATA',pic:''},{av:'AV36BR_Encounter_AdmitDateTitleFilterData',fld:'vBR_ENCOUNTER_ADMITDATETITLEFILTERDATA',pic:''},{av:'AV21BR_Encounter_StatusTitleFilterData',fld:'vBR_ENCOUNTER_STATUSTITLEFILTERDATA',pic:''},{av:'AV38BR_Encounter_IsRandApproveTitleFilterData',fld:'vBR_ENCOUNTER_ISRANDAPPROVETITLEFILTERDATA',pic:''},{av:'AV40BR_Encounter_IsRandRecheckTitleFilterData',fld:'vBR_ENCOUNTER_ISRANDRECHECKTITLEFILTERDATA',pic:''},{av:'AV42BR_Encounter_IsUpdateTitleFilterData',fld:'vBR_ENCOUNTER_ISUPDATETITLEFILTERDATA',pic:''},{av:'edtBR_EncounterID_Titleformat',ctrl:'BR_ENCOUNTERID',prop:'Titleformat'},{av:'edtBR_EncounterID_Title',ctrl:'BR_ENCOUNTERID',prop:'Title'},{av:'edtBR_Encounter_Department_Titleformat',ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Titleformat'},{av:'edtBR_Encounter_Department_Title',ctrl:'BR_ENCOUNTER_DEPARTMENT',prop:'Title'},{av:'edtBR_Encounter_ENCType_Titleformat',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Titleformat'},{av:'edtBR_Encounter_ENCType_Title',ctrl:'BR_ENCOUNTER_ENCTYPE',prop:'Title'},{av:'edtBR_Encounter_AdmitDate_Titleformat',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Titleformat'},{av:'edtBR_Encounter_AdmitDate_Title',ctrl:'BR_ENCOUNTER_ADMITDATE',prop:'Title'},{av:'cmbBR_Encounter_Status'},{av:'chkBR_Encounter_IsRandApprove_Titleformat',ctrl:'BR_ENCOUNTER_ISRANDAPPROVE',prop:'Titleformat'},{av:'chkBR_Encounter_IsRandApprove.Title.Text',ctrl:'BR_ENCOUNTER_ISRANDAPPROVE',prop:'Title'},{av:'chkBR_Encounter_IsRandRecheck_Titleformat',ctrl:'BR_ENCOUNTER_ISRANDRECHECK',prop:'Titleformat'},{av:'chkBR_Encounter_IsRandRecheck.Title.Text',ctrl:'BR_ENCOUNTER_ISRANDRECHECK',prop:'Title'},{av:'chkBR_Encounter_IsUpdate_Titleformat',ctrl:'BR_ENCOUNTER_ISUPDATE',prop:'Titleformat'},{av:'chkBR_Encounter_IsUpdate.Title.Text',ctrl:'BR_ENCOUNTER_ISUPDATE',prop:'Title'},{av:'AV27GridCurrentPage',fld:'vGRIDCURRENTPAGE',pic:'ZZZZZZZZZ9'},{av:'AV28GridPageSize',fld:'vGRIDPAGESIZE',pic:'ZZZZZZZZZ9'},{av:'AV29GridRecordCount',fld:'vGRIDRECORDCOUNT',pic:'ZZZZZZZZZ9'}]}");
         setEventMetadata("GRID.LOAD","{handler:'E23A82',iparms:[]");
         setEventMetadata("GRID.LOAD",",oparms:[]}");
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
         Ddo_br_encounterid_Activeeventkey = "";
         Ddo_br_encounterid_Filteredtext_get = "";
         Ddo_br_encounterid_Filteredtextto_get = "";
         Ddo_br_encounter_department_Activeeventkey = "";
         Ddo_br_encounter_enctype_Activeeventkey = "";
         Ddo_br_encounter_admitdate_Activeeventkey = "";
         Ddo_br_encounter_status_Activeeventkey = "";
         Ddo_br_encounter_israndapprove_Activeeventkey = "";
         Ddo_br_encounter_israndrecheck_Activeeventkey = "";
         Ddo_br_encounter_isupdate_Activeeventkey = "";
         gxfirstwebparm = "";
         gxfirstwebparm_bkp = "";
         AV20ddo_BR_EncounterIDTitleControlIdToReplace = "";
         AV33ddo_BR_Encounter_DepartmentTitleControlIdToReplace = "";
         AV35ddo_BR_Encounter_ENCTypeTitleControlIdToReplace = "";
         AV37ddo_BR_Encounter_AdmitDateTitleControlIdToReplace = "";
         AV24ddo_BR_Encounter_StatusTitleControlIdToReplace = "";
         AV39ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace = "";
         AV41ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace = "";
         AV43ddo_BR_Encounter_IsUpdateTitleControlIdToReplace = "";
         AV49Pgmname = "";
         GXKey = "";
         sDynURL = "";
         FormProcess = "";
         bodyStyle = "";
         AV25DDO_TitleSettingsIcons = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV17BR_EncounterIDTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV32BR_Encounter_DepartmentTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV34BR_Encounter_ENCTypeTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV36BR_Encounter_AdmitDateTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV21BR_Encounter_StatusTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV38BR_Encounter_IsRandApproveTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV40BR_Encounter_IsRandRecheckTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         AV42BR_Encounter_IsUpdateTitleFilterData = new GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item>( context, "Item", "");
         Ddo_br_encounterid_Filteredtext_set = "";
         Ddo_br_encounterid_Filteredtextto_set = "";
         Ddo_br_encounterid_Sortedstatus = "";
         Ddo_br_encounter_department_Sortedstatus = "";
         Ddo_br_encounter_enctype_Sortedstatus = "";
         Ddo_br_encounter_admitdate_Sortedstatus = "";
         Ddo_br_encounter_status_Sortedstatus = "";
         Ddo_br_encounter_israndapprove_Sortedstatus = "";
         Ddo_br_encounter_israndrecheck_Sortedstatus = "";
         Ddo_br_encounter_isupdate_Sortedstatus = "";
         GX_FocusControl = "";
         Form = new GXWebForm();
         sPrefix = "";
         ucDvpanel_tableheader = new GXUserControl();
         TempTags = "";
         ClassString = "";
         StyleString = "";
         GridContainer = new GXWebGrid( context);
         sStyleString = "";
         subGrid_Linesclass = "";
         GridColumn = new GXWebColumn();
         A84BR_Encounter_Department = "";
         A90BR_Encounter_ENCType = "";
         A91BR_Encounter_AdmitDate = DateTime.MinValue;
         ucGridpaginationbar = new GXUserControl();
         ucDdo_br_encounterid = new GXUserControl();
         ucDdo_br_encounter_department = new GXUserControl();
         ucDdo_br_encounter_enctype = new GXUserControl();
         ucDdo_br_encounter_admitdate = new GXUserControl();
         ucDdo_br_encounter_status = new GXUserControl();
         ucDdo_br_encounter_israndapprove = new GXUserControl();
         ucDdo_br_encounter_israndrecheck = new GXUserControl();
         ucDdo_br_encounter_isupdate = new GXUserControl();
         ucWorkwithplusutilities1 = new GXUserControl();
         sEvt = "";
         EvtGridId = "";
         EvtRowId = "";
         sEvtType = "";
         scmdbuf = "";
         H00A82_A202BR_Encounter_IsUpdate = new bool[] {false} ;
         H00A82_n202BR_Encounter_IsUpdate = new bool[] {false} ;
         H00A82_A193BR_Encounter_IsRandRecheck = new bool[] {false} ;
         H00A82_n193BR_Encounter_IsRandRecheck = new bool[] {false} ;
         H00A82_A192BR_Encounter_IsRandApprove = new bool[] {false} ;
         H00A82_n192BR_Encounter_IsRandApprove = new bool[] {false} ;
         H00A82_A172BR_Encounter_Status = new short[1] ;
         H00A82_n172BR_Encounter_Status = new bool[] {false} ;
         H00A82_A91BR_Encounter_AdmitDate = new DateTime[] {DateTime.MinValue} ;
         H00A82_n91BR_Encounter_AdmitDate = new bool[] {false} ;
         H00A82_A90BR_Encounter_ENCType = new String[] {""} ;
         H00A82_n90BR_Encounter_ENCType = new bool[] {false} ;
         H00A82_A84BR_Encounter_Department = new String[] {""} ;
         H00A82_n84BR_Encounter_Department = new bool[] {false} ;
         H00A82_A19BR_EncounterID = new long[1] ;
         H00A83_AGRID_nRecordCount = new long[1] ;
         GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 = new GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons(context);
         AV6WWPContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPContext(context);
         GridRow = new GXWebRow();
         AV16Session = context.GetSession();
         AV11GridState = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState(context);
         AV12GridStateFilterValue = new GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue(context);
         AV9TrnContext = new GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext(context);
         AV8HTTPRequest = new GxHttpRequest( context);
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         ROClassString = "";
         GXCCtl = "";
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.webpanel3__default(),
            new Object[][] {
                new Object[] {
               H00A82_A202BR_Encounter_IsUpdate, H00A82_n202BR_Encounter_IsUpdate, H00A82_A193BR_Encounter_IsRandRecheck, H00A82_n193BR_Encounter_IsRandRecheck, H00A82_A192BR_Encounter_IsRandApprove, H00A82_n192BR_Encounter_IsRandApprove, H00A82_A172BR_Encounter_Status, H00A82_n172BR_Encounter_Status, H00A82_A91BR_Encounter_AdmitDate, H00A82_n91BR_Encounter_AdmitDate,
               H00A82_A90BR_Encounter_ENCType, H00A82_n90BR_Encounter_ENCType, H00A82_A84BR_Encounter_Department, H00A82_n84BR_Encounter_Department, H00A82_A19BR_EncounterID
               }
               , new Object[] {
               H00A83_AGRID_nRecordCount
               }
            }
         );
         AV49Pgmname = "WebPanel3";
         /* GeneXus formulas. */
         AV49Pgmname = "WebPanel3";
         context.Gx_err = 0;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_GXsfl_31 ;
      private short nGXsfl_31_idx=1 ;
      private short GRID_nEOF ;
      private short AV15BR_Encounter_Status ;
      private short AV13OrderedBy ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short subGrid_Backcolorstyle ;
      private short subGrid_Titlebackstyle ;
      private short edtBR_EncounterID_Titleformat ;
      private short edtBR_Encounter_Department_Titleformat ;
      private short edtBR_Encounter_ENCType_Titleformat ;
      private short edtBR_Encounter_AdmitDate_Titleformat ;
      private short cmbBR_Encounter_Status_Titleformat ;
      private short chkBR_Encounter_IsRandApprove_Titleformat ;
      private short chkBR_Encounter_IsRandRecheck_Titleformat ;
      private short chkBR_Encounter_IsUpdate_Titleformat ;
      private short subGrid_Sortable ;
      private short A172BR_Encounter_Status ;
      private short subGrid_Allowselection ;
      private short subGrid_Allowhovering ;
      private short subGrid_Allowcollapsing ;
      private short subGrid_Collapsed ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short AV46WebPanel3DS_1_Br_encounter_status ;
      private short nGXWrapped ;
      private short subGrid_Backstyle ;
      private int subGrid_Rows ;
      private int Gridpaginationbar_Rowsperpageselectedvalue ;
      private int Gridpaginationbar_Pagestoshow ;
      private int subGrid_Titlebackcolor ;
      private int subGrid_Allbackcolor ;
      private int subGrid_Selectedindex ;
      private int subGrid_Selectioncolor ;
      private int subGrid_Hoveringcolor ;
      private int edtavDdo_br_encounteridtitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_encounter_departmenttitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_encounter_enctypetitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_encounter_admitdatetitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_encounter_statustitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_encounter_israndapprovetitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_encounter_israndrechecktitlecontrolidtoreplace_Visible ;
      private int edtavDdo_br_encounter_isupdatetitlecontrolidtoreplace_Visible ;
      private int edtavOrderedby_Visible ;
      private int edtavOrdereddsc_Visible ;
      private int edtavTfbr_encounterid_Visible ;
      private int edtavTfbr_encounterid_to_Visible ;
      private int subGrid_Islastpage ;
      private int GXPagingFrom2 ;
      private int GXPagingTo2 ;
      private int AV26PageToGo ;
      private int AV50GXV1 ;
      private int idxLst ;
      private int subGrid_Backcolor ;
      private long GRID_nFirstRecordOnPage ;
      private long AV18TFBR_EncounterID ;
      private long AV19TFBR_EncounterID_To ;
      private long AV27GridCurrentPage ;
      private long AV29GridRecordCount ;
      private long AV28GridPageSize ;
      private long A19BR_EncounterID ;
      private long GRID_nCurrentRecord ;
      private long AV47WebPanel3DS_2_Tfbr_encounterid ;
      private long AV48WebPanel3DS_3_Tfbr_encounterid_to ;
      private long GRID_nRecordCount ;
      private String Gridpaginationbar_Selectedpage ;
      private String Ddo_br_encounterid_Activeeventkey ;
      private String Ddo_br_encounterid_Filteredtext_get ;
      private String Ddo_br_encounterid_Filteredtextto_get ;
      private String Ddo_br_encounter_department_Activeeventkey ;
      private String Ddo_br_encounter_enctype_Activeeventkey ;
      private String Ddo_br_encounter_admitdate_Activeeventkey ;
      private String Ddo_br_encounter_status_Activeeventkey ;
      private String Ddo_br_encounter_israndapprove_Activeeventkey ;
      private String Ddo_br_encounter_israndrecheck_Activeeventkey ;
      private String Ddo_br_encounter_isupdate_Activeeventkey ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_31_idx="0001" ;
      private String AV49Pgmname ;
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
      private String Ddo_br_encounterid_Caption ;
      private String Ddo_br_encounterid_Tooltip ;
      private String Ddo_br_encounterid_Cls ;
      private String Ddo_br_encounterid_Filteredtext_set ;
      private String Ddo_br_encounterid_Filteredtextto_set ;
      private String Ddo_br_encounterid_Dropdownoptionstype ;
      private String Ddo_br_encounterid_Titlecontrolidtoreplace ;
      private String Ddo_br_encounterid_Sortedstatus ;
      private String Ddo_br_encounterid_Filtertype ;
      private String Ddo_br_encounterid_Sortasc ;
      private String Ddo_br_encounterid_Sortdsc ;
      private String Ddo_br_encounterid_Cleanfilter ;
      private String Ddo_br_encounterid_Rangefilterfrom ;
      private String Ddo_br_encounterid_Rangefilterto ;
      private String Ddo_br_encounterid_Searchbuttontext ;
      private String Ddo_br_encounter_department_Caption ;
      private String Ddo_br_encounter_department_Tooltip ;
      private String Ddo_br_encounter_department_Cls ;
      private String Ddo_br_encounter_department_Dropdownoptionstype ;
      private String Ddo_br_encounter_department_Titlecontrolidtoreplace ;
      private String Ddo_br_encounter_department_Sortedstatus ;
      private String Ddo_br_encounter_department_Sortasc ;
      private String Ddo_br_encounter_department_Sortdsc ;
      private String Ddo_br_encounter_department_Searchbuttontext ;
      private String Ddo_br_encounter_enctype_Caption ;
      private String Ddo_br_encounter_enctype_Tooltip ;
      private String Ddo_br_encounter_enctype_Cls ;
      private String Ddo_br_encounter_enctype_Dropdownoptionstype ;
      private String Ddo_br_encounter_enctype_Titlecontrolidtoreplace ;
      private String Ddo_br_encounter_enctype_Sortedstatus ;
      private String Ddo_br_encounter_enctype_Sortasc ;
      private String Ddo_br_encounter_enctype_Sortdsc ;
      private String Ddo_br_encounter_enctype_Searchbuttontext ;
      private String Ddo_br_encounter_admitdate_Caption ;
      private String Ddo_br_encounter_admitdate_Tooltip ;
      private String Ddo_br_encounter_admitdate_Cls ;
      private String Ddo_br_encounter_admitdate_Dropdownoptionstype ;
      private String Ddo_br_encounter_admitdate_Titlecontrolidtoreplace ;
      private String Ddo_br_encounter_admitdate_Sortedstatus ;
      private String Ddo_br_encounter_admitdate_Sortasc ;
      private String Ddo_br_encounter_admitdate_Sortdsc ;
      private String Ddo_br_encounter_admitdate_Searchbuttontext ;
      private String Ddo_br_encounter_status_Caption ;
      private String Ddo_br_encounter_status_Tooltip ;
      private String Ddo_br_encounter_status_Cls ;
      private String Ddo_br_encounter_status_Dropdownoptionstype ;
      private String Ddo_br_encounter_status_Titlecontrolidtoreplace ;
      private String Ddo_br_encounter_status_Sortedstatus ;
      private String Ddo_br_encounter_status_Sortasc ;
      private String Ddo_br_encounter_status_Sortdsc ;
      private String Ddo_br_encounter_status_Searchbuttontext ;
      private String Ddo_br_encounter_israndapprove_Caption ;
      private String Ddo_br_encounter_israndapprove_Tooltip ;
      private String Ddo_br_encounter_israndapprove_Cls ;
      private String Ddo_br_encounter_israndapprove_Dropdownoptionstype ;
      private String Ddo_br_encounter_israndapprove_Titlecontrolidtoreplace ;
      private String Ddo_br_encounter_israndapprove_Sortedstatus ;
      private String Ddo_br_encounter_israndapprove_Sortasc ;
      private String Ddo_br_encounter_israndapprove_Sortdsc ;
      private String Ddo_br_encounter_israndapprove_Searchbuttontext ;
      private String Ddo_br_encounter_israndrecheck_Caption ;
      private String Ddo_br_encounter_israndrecheck_Tooltip ;
      private String Ddo_br_encounter_israndrecheck_Cls ;
      private String Ddo_br_encounter_israndrecheck_Dropdownoptionstype ;
      private String Ddo_br_encounter_israndrecheck_Titlecontrolidtoreplace ;
      private String Ddo_br_encounter_israndrecheck_Sortedstatus ;
      private String Ddo_br_encounter_israndrecheck_Sortasc ;
      private String Ddo_br_encounter_israndrecheck_Sortdsc ;
      private String Ddo_br_encounter_israndrecheck_Searchbuttontext ;
      private String Ddo_br_encounter_isupdate_Caption ;
      private String Ddo_br_encounter_isupdate_Tooltip ;
      private String Ddo_br_encounter_isupdate_Cls ;
      private String Ddo_br_encounter_isupdate_Dropdownoptionstype ;
      private String Ddo_br_encounter_isupdate_Titlecontrolidtoreplace ;
      private String Ddo_br_encounter_isupdate_Sortedstatus ;
      private String Ddo_br_encounter_isupdate_Sortasc ;
      private String Ddo_br_encounter_isupdate_Sortdsc ;
      private String Ddo_br_encounter_isupdate_Searchbuttontext ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String divLayoutmaintable_Internalname ;
      private String divTablemain_Internalname ;
      private String divHtml_dvpanel_tableheader_Internalname ;
      private String Dvpanel_tableheader_Internalname ;
      private String divLayout_tableheader_Internalname ;
      private String divTableheader_Internalname ;
      private String divTableactions_Internalname ;
      private String cmbavBr_encounter_status_Internalname ;
      private String TempTags ;
      private String cmbavBr_encounter_status_Jsonclick ;
      private String ClassString ;
      private String StyleString ;
      private String divGridtablewithpaginationbar_Internalname ;
      private String sStyleString ;
      private String subGrid_Internalname ;
      private String subGrid_Class ;
      private String subGrid_Linesclass ;
      private String edtBR_EncounterID_Title ;
      private String edtBR_Encounter_Department_Title ;
      private String edtBR_Encounter_ENCType_Title ;
      private String edtBR_Encounter_AdmitDate_Title ;
      private String subGrid_Header ;
      private String divHtml_gridpaginationbar_Internalname ;
      private String Gridpaginationbar_Internalname ;
      private String divHtml_bottomauxiliarcontrols_Internalname ;
      private String Ddo_br_encounterid_Internalname ;
      private String edtavDdo_br_encounteridtitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_encounter_department_Internalname ;
      private String edtavDdo_br_encounter_departmenttitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_encounter_enctype_Internalname ;
      private String edtavDdo_br_encounter_enctypetitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_encounter_admitdate_Internalname ;
      private String edtavDdo_br_encounter_admitdatetitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_encounter_status_Internalname ;
      private String edtavDdo_br_encounter_statustitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_encounter_israndapprove_Internalname ;
      private String edtavDdo_br_encounter_israndapprovetitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_encounter_israndrecheck_Internalname ;
      private String edtavDdo_br_encounter_israndrechecktitlecontrolidtoreplace_Internalname ;
      private String Ddo_br_encounter_isupdate_Internalname ;
      private String edtavDdo_br_encounter_isupdatetitlecontrolidtoreplace_Internalname ;
      private String Workwithplusutilities1_Internalname ;
      private String edtavOrderedby_Internalname ;
      private String edtavOrderedby_Jsonclick ;
      private String edtavOrdereddsc_Internalname ;
      private String edtavOrdereddsc_Jsonclick ;
      private String edtavTfbr_encounterid_Internalname ;
      private String edtavTfbr_encounterid_Jsonclick ;
      private String edtavTfbr_encounterid_to_Internalname ;
      private String edtavTfbr_encounterid_to_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtBR_EncounterID_Internalname ;
      private String edtBR_Encounter_Department_Internalname ;
      private String edtBR_Encounter_ENCType_Internalname ;
      private String edtBR_Encounter_AdmitDate_Internalname ;
      private String cmbBR_Encounter_Status_Internalname ;
      private String chkBR_Encounter_IsRandApprove_Internalname ;
      private String chkBR_Encounter_IsRandRecheck_Internalname ;
      private String chkBR_Encounter_IsUpdate_Internalname ;
      private String scmdbuf ;
      private String sGXsfl_31_fel_idx="0001" ;
      private String ROClassString ;
      private String edtBR_EncounterID_Jsonclick ;
      private String edtBR_Encounter_Department_Jsonclick ;
      private String edtBR_Encounter_ENCType_Jsonclick ;
      private String edtBR_Encounter_AdmitDate_Jsonclick ;
      private String GXCCtl ;
      private String cmbBR_Encounter_Status_Jsonclick ;
      private DateTime A91BR_Encounter_AdmitDate ;
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
      private bool Ddo_br_encounterid_Includesortasc ;
      private bool Ddo_br_encounterid_Includesortdsc ;
      private bool Ddo_br_encounterid_Includefilter ;
      private bool Ddo_br_encounterid_Filterisrange ;
      private bool Ddo_br_encounterid_Includedatalist ;
      private bool Ddo_br_encounter_department_Includesortasc ;
      private bool Ddo_br_encounter_department_Includesortdsc ;
      private bool Ddo_br_encounter_department_Includefilter ;
      private bool Ddo_br_encounter_department_Includedatalist ;
      private bool Ddo_br_encounter_enctype_Includesortasc ;
      private bool Ddo_br_encounter_enctype_Includesortdsc ;
      private bool Ddo_br_encounter_enctype_Includefilter ;
      private bool Ddo_br_encounter_enctype_Includedatalist ;
      private bool Ddo_br_encounter_admitdate_Includesortasc ;
      private bool Ddo_br_encounter_admitdate_Includesortdsc ;
      private bool Ddo_br_encounter_admitdate_Includefilter ;
      private bool Ddo_br_encounter_admitdate_Includedatalist ;
      private bool Ddo_br_encounter_status_Includesortasc ;
      private bool Ddo_br_encounter_status_Includesortdsc ;
      private bool Ddo_br_encounter_status_Includefilter ;
      private bool Ddo_br_encounter_status_Includedatalist ;
      private bool Ddo_br_encounter_israndapprove_Includesortasc ;
      private bool Ddo_br_encounter_israndapprove_Includesortdsc ;
      private bool Ddo_br_encounter_israndapprove_Includefilter ;
      private bool Ddo_br_encounter_israndapprove_Includedatalist ;
      private bool Ddo_br_encounter_israndrecheck_Includesortasc ;
      private bool Ddo_br_encounter_israndrecheck_Includesortdsc ;
      private bool Ddo_br_encounter_israndrecheck_Includefilter ;
      private bool Ddo_br_encounter_israndrecheck_Includedatalist ;
      private bool Ddo_br_encounter_isupdate_Includesortasc ;
      private bool Ddo_br_encounter_isupdate_Includesortdsc ;
      private bool Ddo_br_encounter_isupdate_Includefilter ;
      private bool Ddo_br_encounter_isupdate_Includedatalist ;
      private bool wbLoad ;
      private bool A192BR_Encounter_IsRandApprove ;
      private bool A193BR_Encounter_IsRandRecheck ;
      private bool A202BR_Encounter_IsUpdate ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool n84BR_Encounter_Department ;
      private bool n90BR_Encounter_ENCType ;
      private bool n91BR_Encounter_AdmitDate ;
      private bool n172BR_Encounter_Status ;
      private bool n192BR_Encounter_IsRandApprove ;
      private bool n193BR_Encounter_IsRandRecheck ;
      private bool n202BR_Encounter_IsUpdate ;
      private bool bGXsfl_31_Refreshing=false ;
      private bool gxdyncontrolsrefreshing ;
      private bool returnInSub ;
      private bool gx_refresh_fired ;
      private String AV20ddo_BR_EncounterIDTitleControlIdToReplace ;
      private String AV33ddo_BR_Encounter_DepartmentTitleControlIdToReplace ;
      private String AV35ddo_BR_Encounter_ENCTypeTitleControlIdToReplace ;
      private String AV37ddo_BR_Encounter_AdmitDateTitleControlIdToReplace ;
      private String AV24ddo_BR_Encounter_StatusTitleControlIdToReplace ;
      private String AV39ddo_BR_Encounter_IsRandApproveTitleControlIdToReplace ;
      private String AV41ddo_BR_Encounter_IsRandRecheckTitleControlIdToReplace ;
      private String AV43ddo_BR_Encounter_IsUpdateTitleControlIdToReplace ;
      private String A84BR_Encounter_Department ;
      private String A90BR_Encounter_ENCType ;
      private IGxSession AV16Session ;
      private GXWebGrid GridContainer ;
      private GXWebRow GridRow ;
      private GXWebColumn GridColumn ;
      private GXUserControl ucDvpanel_tableheader ;
      private GXUserControl ucGridpaginationbar ;
      private GXUserControl ucDdo_br_encounterid ;
      private GXUserControl ucDdo_br_encounter_department ;
      private GXUserControl ucDdo_br_encounter_enctype ;
      private GXUserControl ucDdo_br_encounter_admitdate ;
      private GXUserControl ucDdo_br_encounter_status ;
      private GXUserControl ucDdo_br_encounter_israndapprove ;
      private GXUserControl ucDdo_br_encounter_israndrecheck ;
      private GXUserControl ucDdo_br_encounter_isupdate ;
      private GXUserControl ucWorkwithplusutilities1 ;
      private IGxDataStore dsDataStore1 ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbavBr_encounter_status ;
      private GXCombobox cmbBR_Encounter_Status ;
      private GXCheckbox chkBR_Encounter_IsRandApprove ;
      private GXCheckbox chkBR_Encounter_IsRandRecheck ;
      private GXCheckbox chkBR_Encounter_IsUpdate ;
      private IDataStoreProvider pr_default ;
      private bool[] H00A82_A202BR_Encounter_IsUpdate ;
      private bool[] H00A82_n202BR_Encounter_IsUpdate ;
      private bool[] H00A82_A193BR_Encounter_IsRandRecheck ;
      private bool[] H00A82_n193BR_Encounter_IsRandRecheck ;
      private bool[] H00A82_A192BR_Encounter_IsRandApprove ;
      private bool[] H00A82_n192BR_Encounter_IsRandApprove ;
      private short[] H00A82_A172BR_Encounter_Status ;
      private bool[] H00A82_n172BR_Encounter_Status ;
      private DateTime[] H00A82_A91BR_Encounter_AdmitDate ;
      private bool[] H00A82_n91BR_Encounter_AdmitDate ;
      private String[] H00A82_A90BR_Encounter_ENCType ;
      private bool[] H00A82_n90BR_Encounter_ENCType ;
      private String[] H00A82_A84BR_Encounter_Department ;
      private bool[] H00A82_n84BR_Encounter_Department ;
      private long[] H00A82_A19BR_EncounterID ;
      private long[] H00A83_AGRID_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GxHttpRequest AV8HTTPRequest ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV17BR_EncounterIDTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV32BR_Encounter_DepartmentTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV34BR_Encounter_ENCTypeTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV36BR_Encounter_AdmitDateTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV21BR_Encounter_StatusTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV38BR_Encounter_IsRandApproveTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV40BR_Encounter_IsRandRecheckTitleFilterData ;
      private GXBaseCollection<GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsData_Item> AV42BR_Encounter_IsUpdateTitleFilterData ;
      private GXWebForm Form ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPContext AV6WWPContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPTransactionContext AV9TrnContext ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState AV11GridState ;
      private GeneXus.Programs.wwpbaseobjects.SdtWWPGridState_FilterValue AV12GridStateFilterValue ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons AV25DDO_TitleSettingsIcons ;
      private GeneXus.Programs.wwpbaseobjects.SdtDVB_SDTDropDownOptionsTitleSettingsIcons GXt_SdtDVB_SDTDropDownOptionsTitleSettingsIcons1 ;
   }

   public class webpanel3__default : DataStoreHelperBase, IDataStoreHelper
   {
      protected Object[] conditional_H00A82( IGxContext context ,
                                             short AV46WebPanel3DS_1_Br_encounter_status ,
                                             long AV47WebPanel3DS_2_Tfbr_encounterid ,
                                             long AV48WebPanel3DS_3_Tfbr_encounterid_to ,
                                             short A172BR_Encounter_Status ,
                                             long A19BR_EncounterID ,
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
         sSelectString = " [BR_Encounter_IsUpdate], [BR_Encounter_IsRandRecheck], [BR_Encounter_IsRandApprove], [BR_Encounter_Status], [BR_Encounter_AdmitDate], [BR_Encounter_ENCType], [BR_Encounter_Department], [BR_EncounterID]";
         sFromString = " FROM [BR_Encounter] WITH (NOLOCK)";
         sOrderString = "";
         if ( ! (0==AV46WebPanel3DS_1_Br_encounter_status) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Encounter_Status] = @AV46WebPanel3DS_1_Br_encounter_status)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Encounter_Status] = @AV46WebPanel3DS_1_Br_encounter_status)";
            }
         }
         else
         {
            GXv_int2[0] = 1;
         }
         if ( ! (0==AV47WebPanel3DS_2_Tfbr_encounterid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_EncounterID] >= @AV47WebPanel3DS_2_Tfbr_encounterid)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_EncounterID] >= @AV47WebPanel3DS_2_Tfbr_encounterid)";
            }
         }
         else
         {
            GXv_int2[1] = 1;
         }
         if ( ! (0==AV48WebPanel3DS_3_Tfbr_encounterid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_EncounterID] <= @AV48WebPanel3DS_3_Tfbr_encounterid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_EncounterID] <= @AV48WebPanel3DS_3_Tfbr_encounterid_to)";
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
            sOrderString = sOrderString + " ORDER BY [BR_EncounterID]";
         }
         else if ( ( AV13OrderedBy == 1 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_EncounterID] DESC";
         }
         else if ( ( AV13OrderedBy == 2 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Encounter_Department]";
         }
         else if ( ( AV13OrderedBy == 2 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Encounter_Department] DESC";
         }
         else if ( ( AV13OrderedBy == 3 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Encounter_ENCType]";
         }
         else if ( ( AV13OrderedBy == 3 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Encounter_ENCType] DESC";
         }
         else if ( ( AV13OrderedBy == 4 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Encounter_AdmitDate]";
         }
         else if ( ( AV13OrderedBy == 4 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Encounter_AdmitDate] DESC";
         }
         else if ( ( AV13OrderedBy == 5 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Encounter_Status]";
         }
         else if ( ( AV13OrderedBy == 5 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Encounter_Status] DESC";
         }
         else if ( ( AV13OrderedBy == 6 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Encounter_IsRandApprove]";
         }
         else if ( ( AV13OrderedBy == 6 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Encounter_IsRandApprove] DESC";
         }
         else if ( ( AV13OrderedBy == 7 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Encounter_IsRandRecheck]";
         }
         else if ( ( AV13OrderedBy == 7 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Encounter_IsRandRecheck] DESC";
         }
         else if ( ( AV13OrderedBy == 8 ) && ! AV14OrderedDsc )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Encounter_IsUpdate]";
         }
         else if ( ( AV13OrderedBy == 8 ) && ( AV14OrderedDsc ) )
         {
            sOrderString = sOrderString + " ORDER BY [BR_Encounter_IsUpdate] DESC";
         }
         else if ( true )
         {
            sOrderString = sOrderString + " ORDER BY [BR_EncounterID]";
         }
         scmdbuf = "SELECT " + sSelectString + sFromString + sWhereString + "" + sOrderString + " OFFSET " + "@GXPagingFrom2" + " ROWS FETCH NEXT CAST((SELECT CASE WHEN " + "@GXPagingTo2" + " > 0 THEN " + "@GXPagingTo2" + " ELSE 1e9 END) AS INTEGER) ROWS ONLY";
         GXv_Object3[0] = scmdbuf;
         GXv_Object3[1] = GXv_int2;
         return GXv_Object3 ;
      }

      protected Object[] conditional_H00A83( IGxContext context ,
                                             short AV46WebPanel3DS_1_Br_encounter_status ,
                                             long AV47WebPanel3DS_2_Tfbr_encounterid ,
                                             long AV48WebPanel3DS_3_Tfbr_encounterid_to ,
                                             short A172BR_Encounter_Status ,
                                             long A19BR_EncounterID ,
                                             short AV13OrderedBy ,
                                             bool AV14OrderedDsc )
      {
         String sWhereString = "" ;
         String scmdbuf ;
         short[] GXv_int4 ;
         GXv_int4 = new short [3] ;
         Object[] GXv_Object5 ;
         GXv_Object5 = new Object [2] ;
         scmdbuf = "SELECT COUNT(*) FROM [BR_Encounter] WITH (NOLOCK)";
         if ( ! (0==AV46WebPanel3DS_1_Br_encounter_status) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_Encounter_Status] = @AV46WebPanel3DS_1_Br_encounter_status)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_Encounter_Status] = @AV46WebPanel3DS_1_Br_encounter_status)";
            }
         }
         else
         {
            GXv_int4[0] = 1;
         }
         if ( ! (0==AV47WebPanel3DS_2_Tfbr_encounterid) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_EncounterID] >= @AV47WebPanel3DS_2_Tfbr_encounterid)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_EncounterID] >= @AV47WebPanel3DS_2_Tfbr_encounterid)";
            }
         }
         else
         {
            GXv_int4[1] = 1;
         }
         if ( ! (0==AV48WebPanel3DS_3_Tfbr_encounterid_to) )
         {
            if ( StringUtil.StrCmp("", sWhereString) != 0 )
            {
               sWhereString = sWhereString + " and ([BR_EncounterID] <= @AV48WebPanel3DS_3_Tfbr_encounterid_to)";
            }
            else
            {
               sWhereString = sWhereString + " ([BR_EncounterID] <= @AV48WebPanel3DS_3_Tfbr_encounterid_to)";
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
         else if ( ( AV13OrderedBy == 3 ) && ! AV14OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 3 ) && ( AV14OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 4 ) && ! AV14OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 4 ) && ( AV14OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 5 ) && ! AV14OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 5 ) && ( AV14OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 6 ) && ! AV14OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 6 ) && ( AV14OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 7 ) && ! AV14OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 7 ) && ( AV14OrderedDsc ) )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 8 ) && ! AV14OrderedDsc )
         {
            scmdbuf = scmdbuf + "";
         }
         else if ( ( AV13OrderedBy == 8 ) && ( AV14OrderedDsc ) )
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
                     return conditional_H00A82(context, (short)dynConstraints[0] , (long)dynConstraints[1] , (long)dynConstraints[2] , (short)dynConstraints[3] , (long)dynConstraints[4] , (short)dynConstraints[5] , (bool)dynConstraints[6] );
               case 1 :
                     return conditional_H00A83(context, (short)dynConstraints[0] , (long)dynConstraints[1] , (long)dynConstraints[2] , (short)dynConstraints[3] , (long)dynConstraints[4] , (short)dynConstraints[5] , (bool)dynConstraints[6] );
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
          Object[] prmH00A82 ;
          prmH00A82 = new Object[] {
          new Object[] {"@AV46WebPanel3DS_1_Br_encounter_status",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV47WebPanel3DS_2_Tfbr_encounterid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV48WebPanel3DS_3_Tfbr_encounterid_to",SqlDbType.Decimal,18,0} ,
          new Object[] {"@GXPagingFrom2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo2",SqlDbType.Int,9,0}
          } ;
          Object[] prmH00A83 ;
          prmH00A83 = new Object[] {
          new Object[] {"@AV46WebPanel3DS_1_Br_encounter_status",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV47WebPanel3DS_2_Tfbr_encounterid",SqlDbType.Decimal,18,0} ,
          new Object[] {"@AV48WebPanel3DS_3_Tfbr_encounterid_to",SqlDbType.Decimal,18,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H00A82", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00A82,11,0,true,false )
             ,new CursorDef("H00A83", "scmdbuf",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00A83,1,0,true,false )
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
                ((bool[]) buf[0])[0] = rslt.getBool(1) ;
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((bool[]) buf[2])[0] = rslt.getBool(2) ;
                ((bool[]) buf[3])[0] = rslt.wasNull(2);
                ((bool[]) buf[4])[0] = rslt.getBool(3) ;
                ((bool[]) buf[5])[0] = rslt.wasNull(3);
                ((short[]) buf[6])[0] = rslt.getShort(4) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(4);
                ((DateTime[]) buf[8])[0] = rslt.getGXDate(5) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(5);
                ((String[]) buf[10])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[11])[0] = rslt.wasNull(6);
                ((String[]) buf[12])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[13])[0] = rslt.wasNull(7);
                ((long[]) buf[14])[0] = rslt.getLong(8) ;
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
                   stmt.SetParameter(sIdx, (short)parms[6]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[7]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[8]);
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
                   stmt.SetParameter(sIdx, (short)parms[3]);
                }
                if ( (short)parms[1] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[4]);
                }
                if ( (short)parms[2] == 0 )
                {
                   sIdx = (short)(sIdx+1);
                   stmt.SetParameter(sIdx, (long)parms[5]);
                }
                return;
       }
    }

 }

}
